Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class IssueBooks
    Dim Key As Integer = 0
    Dim keyIssue = 0
    Private Sub IssueBooks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillBooksAutoComplete()
        FillBooksAutoComplete()
        displayIssue()
        CustomizeDataGridViewHeaders(IssueDGV)
    End Sub


    Private Sub displayIssue()
        Using Con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\Documents\hello.mdf;Integrated Security=True;Connect Timeout=30")
            Try
                Con.Open()
                Dim query = "SELECT * FROM IssueTable"
                Dim adapter As New SqlDataAdapter(query, Con)
                Dim ds As New DataSet()
                adapter.Fill(ds)
                IssueDGV.DataSource = ds.Tables(0)
                ResizeAndAdjustDataGridView(IssueDGV)
            Catch ex As Exception
                Label9.Text = "Error: " & ex.Message
            End Try
        End Using
    End Sub


    Private Sub FillBooksAutoComplete()
        Using Con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\Documents\hello.mdf;Integrated Security=True;Connect Timeout=30")
            Try
                Con.Open()
                Dim bookNamesQuery = "SELECT BookName FROM BookTable"
                Dim bookNamesCmd As New SqlCommand(bookNamesQuery, Con)
                Dim bookNamesReader As SqlDataReader = bookNamesCmd.ExecuteReader()
                Dim bookNames As New AutoCompleteStringCollection()

                While bookNamesReader.Read()
                    bookNames.Add(bookNamesReader("BookName").ToString())
                End While

                RtBookNameTb.AutoCompleteMode = AutoCompleteMode.SuggestAppend
                RtBookNameTb.AutoCompleteSource = AutoCompleteSource.CustomSource
                RtBookNameTb.AutoCompleteCustomSource = bookNames
            Catch ex As Exception
                Label9.Text = "Error: " & ex.Message
            End Try
        End Using
    End Sub

    Private Sub GetStudentDetailsById(studentId As String)
        Using Con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\Documents\hello.mdf;Integrated Security=True;Connect Timeout=30")
            Try
                Con.Open()
                Dim query = "SELECT StudentName, StudentDepartment FROM StudentTable WHERE StudentId = @StudentId"
                Dim cmd As New SqlCommand(query, Con)
                cmd.Parameters.AddWithValue("@StudentId", studentId)

                Dim reader As SqlDataReader = cmd.ExecuteReader()
                If reader.Read() Then
                    RtStNameTb.Text = reader("StudentName").ToString()
                    StdepartmentTb.Text = reader("StudentDepartment").ToString()
                Else
                    RtStNameTb.Text = ""
                    StdepartmentTb.Text = ""
                End If
                Con.Close()
            Catch ex As Exception
                Label9.Text = "Error: " & ex.Message
            End Try
        End Using
    End Sub

    Private Sub GetBookIdByName(bookName As String)
        Using Con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\Documents\hello.mdf;Integrated Security=True;Connect Timeout=30")
            Try
                Con.Open()
                Dim query = "SELECT BookId FROM BookTable WHERE BookName = @BookName"
                Dim cmd As New SqlCommand(query, Con)
                cmd.Parameters.AddWithValue("@BookName", bookName)

                Dim result = cmd.ExecuteScalar()
                If result IsNot Nothing Then
                    RtBookIdTb.Text = result.ToString()
                Else
                    RtBookIdTb.Text = ""
                End If
                Con.Close()
            Catch ex As Exception
                Label9.Text = "Error: " & ex.Message
            End Try
        End Using
    End Sub

    Private Sub submitBtn_Click(sender As Object, e As EventArgs) Handles submitBtn.Click
        If RtStIdTb.Text = "" Then
            Label10.Text = "Required"
            Label10.Visible = True
        ElseIf RtBookNameTb.Text = "" Then
            Label11.Text = "Required"
            Label11.Visible = True
        ElseIf RtBookIdTb.Text = "" Then
            Label9.Text = "Missing Information"
            Label9.Visible = True
            Label9.ForeColor = Color.Red

        Else
            Using Con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\Documents\hello.mdf;Integrated Security=True;Connect Timeout=30")
                Try
                    Con.Open()
                    Dim checkQuery = "SELECT COUNT(*) FROM IssueTable WHERE StudentId = @StudentId AND BookId = @BookId AND IssueTime = @IssueTime"
                    Using checkCmd As New SqlCommand(checkQuery, Con)
                        checkCmd.Parameters.AddWithValue("@StudentId", RtStIdTb.Text)
                        checkCmd.Parameters.AddWithValue("@BookId", RtBookIdTb.Text)
                        checkCmd.Parameters.AddWithValue("@IssueTime", RtIssueDateTb.Value.Date)

                        Dim count As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())
                        If count > 0 Then
                            Label9.Text = "This issue record already exists."
                            Label9.ForeColor = Color.Red
                            Label9.Visible = True

                        Else

                            Dim insertQuery = "INSERT INTO IssueTable (StudentId, StudentName, StudentDepartment, BookId, BookName, IssueTime) VALUES (@StudentId, @StudentName, @StudentDepartment, @BookId, @BookName, @IssueTime)"
                            Using cmd As New SqlCommand(insertQuery, Con)
                                cmd.Parameters.AddWithValue("@StudentId", RtStIdTb.Text)
                                cmd.Parameters.AddWithValue("@StudentName", RtStNameTb.Text)
                                cmd.Parameters.AddWithValue("@StudentDepartment", StdepartmentTb.Text)
                                cmd.Parameters.AddWithValue("@BookId", RtBookIdTb.Text)
                                cmd.Parameters.AddWithValue("@BookName", RtBookNameTb.Text)
                                cmd.Parameters.AddWithValue("@IssueTime", RtIssueDateTb.Value.Date)
                                cmd.ExecuteNonQuery()
                            End Using
                            Label9.Text = "Book Issued"
                            Label9.Visible = True
                            Label9.ForeColor = Color.Black
                            displayIssue()
                            reset()
                        End If
                    End Using
                Catch ex As Exception
                    Label9.Text = "Error: " & ex.Message
                End Try
            End Using
        End If
    End Sub

    Private Sub editBtn_Click(sender As Object, e As EventArgs) Handles editBtn.Click
        If RtStIdTb.Text = "" Or RtBookIdTb.Text = "" Or RtBookNameTb.Text = "" Or RtStNameTb.Text = "" Or RtIssueDateTb.Text = "" Then
            Label9.Text = "Missing Information"
            Label9.Visible = True
            Label9.ForeColor = Color.Red
        Else
            If Key = 0 Then
                Label9.Text = "No record selected for editing"
                Label9.Visible = True
                Label9.ForeColor = Color.Red
                Return
            End If

            Using Con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\Documents\hello.mdf;Integrated Security=True;Connect Timeout=30")
                Try
                    Con.Open()
                    Dim checkQuery = "SELECT StudentId, StudentName, StudentDepartment, BookId, BookName, IssueDate FROM IssueTable WHERE Id = @Key"
                    Dim updateQuery = "UPDATE IssueTable SET StudentId = @StudentId, StudentName = @StudentName, StudentDepartment = @StudentDepartment, BookId = @BookId, BookName = @BookName, IssueTime = @IssueTime WHERE Id = @Key"


                    Dim changesMade As Boolean = False
                    Using cmdCheck As New SqlCommand(checkQuery, Con)
                        cmdCheck.Parameters.AddWithValue("@Key", Key)
                        Dim reader As SqlDataReader = cmdCheck.ExecuteReader()
                        If reader.Read() Then
                            If RtStIdTb.Text <> reader("StudentId").ToString() OrElse
                               RtStNameTb.Text <> reader("StudentName").ToString() OrElse
                               StdepartmentTb.Text <> reader("StudentDepartment").ToString() OrElse
                               RtBookIdTb.Text <> reader("BookId").ToString() OrElse
                               RtBookNameTb.Text <> reader("BookName").ToString() OrElse
                               RtIssueDateTb.Value.Date <> Convert.ToDateTime(reader("IssueTime")).Date Then
                                changesMade = True
                            End If
                        End If
                        reader.Close()
                    End Using


                    If Not changesMade Then
                        Label9.Text = "No changes made to the record"
                        Label9.Visible = True
                        Label9.ForeColor = Color.Red
                        Return
                    End If

                    Using cmdUpdate As New SqlCommand(updateQuery, Con)
                        cmdUpdate.Parameters.AddWithValue("@StudentId", RtStIdTb.Text)
                        cmdUpdate.Parameters.AddWithValue("@StudentName", RtStNameTb.Text)
                        cmdUpdate.Parameters.AddWithValue("@StudentDepartment", StdepartmentTb.Text)
                        cmdUpdate.Parameters.AddWithValue("@BookId", RtBookIdTb.Text)
                        cmdUpdate.Parameters.AddWithValue("@BookName", RtBookNameTb.Text)
                        cmdUpdate.Parameters.AddWithValue("@IssueTime", RtIssueDateTb.Value.Date)
                        cmdUpdate.Parameters.AddWithValue("@Key", Key)
                        cmdUpdate.ExecuteNonQuery()
                    End Using
                    Label9.Text = "Record Edited"
                    Label9.Visible = True
                    Label9.ForeColor = Color.Black
                    displayIssue()
                    reset()
                Catch ex As Exception
                    Label9.Text = "Error: " & ex.Message
                End Try
            End Using
        End If
    End Sub
    Private Sub IssueDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles IssueDGV.CellMouseClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim row As DataGridViewRow = IssueDGV.Rows(e.RowIndex)
            RtStIdTb.Text = row.Cells(1).Value.ToString()
            RtStNameTb.Text = row.Cells(2).Value.ToString()
            StdepartmentTb.Text = row.Cells(3).Value.ToString()
            RtBookIdTb.Text = row.Cells(4).Value.ToString()
            RtBookNameTb.Text = row.Cells(5).Value.ToString()
            RtIssueDateTb.Text = row.Cells(6).Value.ToString()
            If RtStIdTb.Text = "" Then
                keyIssue = 0
            Else
                keyIssue = Convert.ToInt32(row.Cells(0).Value.ToString())
            End If
        End If
    End Sub
    Private Sub CustomizeDataGridViewHeaders(dgv As DataGridView)
        dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.MediumSeaGreen
        dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        dgv.ColumnHeadersDefaultCellStyle.Font = New Font("Microsoft Sans Serif", 14, FontStyle.Bold)
        dgv.EnableHeadersVisualStyles = False

    End Sub

    Private Sub ResizeAndAdjustDataGridView(dgv As DataGridView)
        dgv.Columns(0).Width = 150
        dgv.Columns(1).Width = 150
        dgv.Columns(2).Width = 250
        dgv.Columns(3).Width = 220
        dgv.Columns(4).Width = 200
        dgv.Columns(5).Width = 200
        dgv.Columns(6).Width = 200
    End Sub

    Private Sub reset()
        RtStIdTb.Text = ""
        RtStNameTb.Text = ""
        StdepartmentTb.Text = ""
        RtBookIdTb.Text = ""
        RtBookNameTb.Text = ""
        Key = 0
    End Sub

    Private Sub resetBtn_Click(sender As Object, e As EventArgs) Handles resetBtn.Click
        reset()
        Label9.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim obj = New mainform
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub RtStIdTb_TextChanged(sender As Object, e As EventArgs) Handles RtStIdTb.TextChanged
        ' Define the regex pattern for valid input
        Dim idRegex As New Regex("^[A-Z]{3}\d{7}$")
        ' Define the regex pattern for filtering invalid characters
        Dim invalidCharRegex As New Regex("[^A-Za-z0-9]")

        ' Filter out any invalid characters
        If invalidCharRegex.IsMatch(RtStIdTb.Text) Then
            RtStIdTb.Text = invalidCharRegex.Replace(RtStIdTb.Text, "")
            RtStIdTb.SelectionStart = RtStIdTb.Text.Length
        End If

        ' Ensure the first three characters are uppercase
        If RtStIdTb.Text.Length > 3 Then
            Dim firstPart As String = RtStIdTb.Text.Substring(0, 3).ToUpper()
            Dim remainingPart As String = RtStIdTb.Text.Substring(3)
            RtStIdTb.Text = firstPart & remainingPart
            RtStIdTb.SelectionStart = RtStIdTb.Text.Length
        End If
        If idRegex.IsMatch(RtStIdTb.Text) Then
            RtStIdTb.BackColor = Color.FloralWhite
        Else
            RtStIdTb.BackColor = Color.LightCoral
        End If
        RtStIdTb.Text = StrConv(RtStIdTb.Text, VbStrConv.Uppercase)
            RtStIdTb.SelectionStart = RtStIdTb.Text.Length
        GetStudentDetailsById(RtStIdTb.Text)
        Label10.Visible = False
    End Sub

    Private Sub RtBookNameTb_TextChanged(sender As Object, e As EventArgs) Handles RtBookNameTb.TextChanged
        RtBookNameTb.Text = StrConv(RtBookNameTb.Text, VbStrConv.ProperCase)
        RtBookNameTb.SelectionStart = RtBookNameTb.Text.Length
        RtBookNameTb.Text = CapitalizeFirstLetterOfEachWord(RtBookNameTb.Text)
        RtBookNameTb.SelectionStart = RtBookNameTb.Text.Length
        RtBookNameTb.Text = CapitalizeFirstLetterOfEachWord(RtBookNameTb.Text)
        RtBookNameTb.SelectionStart = RtBookNameTb.Text.Length
        If Not String.IsNullOrEmpty(RtBookNameTb.Text) Then
            GetBookIdByName(RtBookNameTb.Text)
            Label11.Visible = False
        End If
    End Sub
    Private Function CapitalizeFirstLetterOfEachWord(input As String) As String
        Dim sb As New System.Text.StringBuilder(input.Length)
        Dim capitalizeNext As Boolean = True

        For Each c As Char In input
            If Char.IsWhiteSpace(c) Then
                sb.Append(c)
                capitalizeNext = True
            ElseIf capitalizeNext Then
                sb.Append(Char.ToUpper(c))
                capitalizeNext = False
            Else
                sb.Append(Char.ToLower(c))
            End If
        Next

        Return sb.ToString()
    End Function


    Private Sub RtStIdTb_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles RtStIdTb.Validating
        Dim regex As New Regex("^[A-Z]{3}\d{7}$")
        If Not regex.IsMatch(RtStIdTb.Text) Then
        Else
        End If
    End Sub
    Private Sub RtBookNameTb_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles RtBookNameTb.Validating
        Dim regex As New Regex("^[a-zA-Z\s]+$")
        If Not regex.IsMatch(RtBookNameTb.Text) Then
        Else
        End If
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Application.Exit()
        PictureBox1.BackColor = Color.DarkGray
    End Sub
    Private Sub PictureBox1_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox1.MouseEnter
        PictureBox1.BackColor = Color.DarkGray
    End Sub

    Private Sub PictureBox1_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox1.MouseLeave
        PictureBox1.BackColor = Color.MediumSeaGreen  ' Or any other color you want it to revert to
    End Sub
    Private Sub RtBookNameTb_Click(sender As Object, e As EventArgs) Handles RtBookNameTb.Click
        Label9.Visible = False
    End Sub

    Private Sub RtStIdTb_Click(sender As Object, e As EventArgs) Handles RtStIdTb.Click
        Label9.Visible = False
    End Sub
End Class