Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class BookReturn
    Dim Con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\Documents\hello.mdf;Integrated Security=True;Connect Timeout=30")
    Dim keyIssue As Integer = 0
    Dim keyReturn As Integer = 0

    Private Sub displayReturn()
        Con.Open()
        Dim query = "SELECT * FROM ReturnTable"
        Dim adapter As SqlDataAdapter
        Dim cmd As New SqlCommand(query, Con)
        adapter = New SqlDataAdapter(cmd)
        Dim builder As New SqlCommandBuilder(adapter)
        Dim ds As New DataSet()
        adapter.Fill(ds)
        ReturnDGV.DataSource = ds.Tables(0)
        Con.Close()
    End Sub

    Private Sub removeFromIssue()
        Try
            Con.Open()
            Dim query = "DELETE FROM IssueTable WHERE IssueNumber = @keyIssue"
            Dim cmd As New SqlCommand(query, Con)
            cmd.Parameters.AddWithValue("@keyIssue", keyIssue)
            cmd.ExecuteNonQuery()
            Label7.Text = "Issue Removed"
            Label7.Visible = True
            Con.Close()
        Catch ex As Exception
            Label7.Text = ex.Message
        End Try
    End Sub

    Private Sub reset()
        RtStIdTb.Text = ""
        RtStNameTb.Text = ""
        RdepartmentTb.Text = ""
        RtBookIdTb.Text = ""
        RtBookNameTb.Text = ""
        RtIssueDateTb.Text = ""
        RtDateTb.Text = ""
        RtFineTb.Text = ""
        keyIssue = 0
        keyReturn = 0
    End Sub

    Private Sub saveBtn_Click(sender As Object, e As EventArgs) Handles saveBtn.Click
        Try
            Con.Open()

            If RtStIdTb.Text = "" Then
                Label10.Text = "Required"
                Label10.Visible = True
            ElseIf RtBookNameTb.Text = "" Then
                Label15.Text = "Required"
                Label15.Visible = True
            ElseIf RtDateTb.Text = "" Then
                Label7.Text = "Select Return Date"
                Label7.Visible = True
            Else
                ' Check if the book being returned matches the book issued to the student
                Dim checkIssueQuery = "SELECT COUNT(*) FROM IssueTable WHERE StudentId = @StudentId AND BookName = @BookName"
                Using cmdCheckIssue As New SqlCommand(checkIssueQuery, Con)
                    cmdCheckIssue.Parameters.AddWithValue("@StudentId", RtStIdTb.Text)
                    cmdCheckIssue.Parameters.AddWithValue("@BookName", RtBookNameTb.Text)
                    Dim count As Integer = Convert.ToInt32(cmdCheckIssue.ExecuteScalar())
                    If count = 0 Then
                        Label7.Text = "Record not found. This book was not issued to the provided student."
                        Label7.Visible = True
                        Exit Sub
                    End If
                End Using

                ' Check if the same return record already exists
                Dim checkQuery = "SELECT COUNT(*) FROM ReturnTable WHERE StudentId = @StudentId AND BookId = @BookId AND IssueDate = @IssueDate"
                Using cmdCheck As New SqlCommand(checkQuery, Con)
                    cmdCheck.Parameters.AddWithValue("@StudentId", RtStIdTb.Text)
                    cmdCheck.Parameters.AddWithValue("@BookId", RtBookIdTb.Text.ToString())
                    cmdCheck.Parameters.AddWithValue("@IssueDate", Convert.ToDateTime(RtIssueDateTb.Text))
                    Dim count As Integer = Convert.ToInt32(cmdCheck.ExecuteScalar())
                    If count > 0 Then
                        Label7.Text = "This return record already exists."
                        Label7.Visible = True

                        Exit Sub
                    End If
                End Using

                Dim insertQuery = "INSERT INTO ReturnTable (StudentId, StudentName, StudentDepartment, BookId, BookName, IssueDate, ReturnTime) VALUES (@StudentId, @StudentName, @StudentDepartment, @BookId, @BookName, @IssueDate, @ReturnTime)"
                Using cmdInsert As New SqlCommand(insertQuery, Con)
                    cmdInsert.Parameters.AddWithValue("@StudentId", RtStIdTb.Text)
                    cmdInsert.Parameters.AddWithValue("@StudentName", RtStNameTb.Text)
                    cmdInsert.Parameters.AddWithValue("@StudentDepartment", RdepartmentTb.Text)
                    cmdInsert.Parameters.AddWithValue("@BookId", RtBookIdTb.Text.ToString())
                    cmdInsert.Parameters.AddWithValue("@BookName", RtBookNameTb.Text)
                    cmdInsert.Parameters.AddWithValue("@IssueDate", Convert.ToDateTime(RtIssueDateTb.Text))
                    cmdInsert.Parameters.AddWithValue("@ReturnTime", DateTime.Now)
                    cmdInsert.ExecuteNonQuery()
                End Using

                Dim deleteQuery = "DELETE FROM IssueTable WHERE BookId = @BookId"
                Using cmdDelete As New SqlCommand(deleteQuery, Con)
                    cmdDelete.Parameters.AddWithValue("@BookId", RtBookIdTb.Text.ToString())
                    cmdDelete.ExecuteNonQuery()
                End Using
                Con.Close()
                Label7.Text = "Return Saved and Issue Removed"
                Label7.Visible = True
                displayReturn()
                reset()

            End If

        Catch ex As Exception
            Label7.Text = "Error: " & ex.Message
        Finally
            If Con.State = ConnectionState.Open Then
                Con.Close()
            End If
        End Try
    End Sub


    Private Sub editBtn_Click(sender As Object, e As EventArgs)
        If RtStIdTb.Text = "" Or RtStNameTb.Text = "" Or RdepartmentTb.Text = "" Or RtBookIdTb.Text = "" Or RtBookNameTb.Text = "" Or RtIssueDateTb.Text = "" Or RtDateTb.Text = "" Then
            Label7.Text = "Missing Information"
        Else
            Try
                Using Con
                    Con.Open()
                    Dim updateQuery = "UPDATE ReturnTable SET StudentId = @StudentId, StudentName = @StudentName, StudentDepartment = @StudentDepartment, BookId = @BookId, BookName = @BookName, IssueDate = @IssueDate, ReturnTime = @ReturnTime WHERE ReturnNumber = @keyReturn"
                    Using cmdUpdate As New SqlCommand(updateQuery, Con)
                        cmdUpdate.Parameters.AddWithValue("@StudentId", RtStIdTb.Text)
                        cmdUpdate.Parameters.AddWithValue("@StudentName", RtStNameTb.Text)
                        cmdUpdate.Parameters.AddWithValue("@StudentDepartment", RdepartmentTb.Text)
                        cmdUpdate.Parameters.AddWithValue("@BookId", RtBookIdTb.Text.ToString())
                        cmdUpdate.Parameters.AddWithValue("@BookName", RtBookNameTb.Text)
                        cmdUpdate.Parameters.AddWithValue("@IssueDate", Convert.ToDateTime(RtIssueDateTb.Text))
                        cmdUpdate.Parameters.AddWithValue("@ReturnTime", Convert.ToDateTime(RtDateTb.Text))
                        cmdUpdate.Parameters.AddWithValue("@keyReturn", keyReturn)
                        cmdUpdate.ExecuteNonQuery()
                    End Using

                    Label7.Text = "Edit Saved"
                    displayReturn()
                    reset()
                End Using
            Catch ex As Exception
                Label7.Text = "Error: " & ex.Message
            End Try
        End If
    End Sub

    Private Sub resetBtn_Click(sender As Object, e As EventArgs) Handles resetBtn.Click
        reset()
    End Sub

    Private Sub deleteBtn_Click(sender As Object, e As EventArgs)
        If keyReturn = 0 Then
            Label7.Text = "Missing Information"
        Else
            Con.Open()
            Dim query = "Delete from ReturnTable Where ReturnNumber = @keyReturn"
            Using cmd As New SqlCommand(query, Con)
                cmd.Parameters.AddWithValue("@keyReturn", keyReturn)
                cmd.ExecuteNonQuery()
                Con.Close()
            End Using
            Label7.Text = "Return Deleted"
            displayReturn()
            reset()
        End If
    End Sub

    Private Sub BookReturn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        displayReturn()
        CustomizeDataGridViewHeaders(ReturnDGV)
        ResizeAndAdjustDataGridView(ReturnDGV)
        FillBooksAutoComplete()
    End Sub

    Private Sub ReturnDGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ReturnDGV.CellContentClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim row As DataGridViewRow = ReturnDGV.Rows(e.RowIndex)
            RtStIdTb.Text = row.Cells(1).Value.ToString()
            RtStNameTb.Text = row.Cells(2).Value.ToString()
            RdepartmentTb.Text = row.Cells(3).Value.ToString()
            RtBookIdTb.Text = row.Cells(4).Value.ToString()
            RtBookNameTb.Text = row.Cells(5).Value.ToString()
            RtIssueDateTb.Text = row.Cells(6).Value.ToString()
            RtDateTb.Text = row.Cells(7).Value.ToString()

            If RtStIdTb.Text = "" Then
                keyReturn = 0
            Else
                keyReturn = Convert.ToInt32(row.Cells(0).Value.ToString())
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
        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
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
        If Not String.IsNullOrEmpty(RtStIdTb.Text) Then
            If RtStIdTb.Text.Length > 3 Then
                RtStIdTb.Text = RtStIdTb.Text.Substring(0, 3).ToUpper() & RtStIdTb.Text.Substring(3)
                RtStIdTb.SelectionStart = RtStIdTb.Text.Length
            End If
            fetchStudentDetails(RtStIdTb.Text)
        End If
    End Sub
    Private Sub fetchIssueDate(studentId As String, bookId As String)
        Try
            Con.Open()
            Dim query = "SELECT IssueDate FROM IssueTable WHERE StudentId = @StudentId AND BookId = @BookId"
            Dim cmd As New SqlCommand(query, Con)
            cmd.Parameters.AddWithValue("@StudentId", studentId)
            cmd.Parameters.AddWithValue("@BookId", bookId)
            Dim reader As SqlDataReader = cmd.ExecuteReader()
            If reader.Read() Then
                RtIssueDateTb.Text = Convert.ToDateTime(reader("IssueDate")).ToString("yyyy-MM-dd")
            End If
            reader.Close()
            Con.Close()
        Catch ex As Exception
            Label7.Text = ex.Message
        End Try
    End Sub

    Private Sub fetchStudentDetails(studentId As String)
        Try
            Con.Open()
            Dim query = "SELECT StudentName, StudentDepartment FROM StudentTable WHERE StudentId = @StudentId"
            Dim cmd As New SqlCommand(query, Con)
            cmd.Parameters.AddWithValue("@StudentId", studentId)
            Dim reader As SqlDataReader = cmd.ExecuteReader()
            If reader.Read() Then
                RtStNameTb.Text = reader("StudentName").ToString()
                RdepartmentTb.Text = reader("StudentDepartment").ToString()
            Else
                RtStNameTb.Text = ""
                RdepartmentTb.Text = ""
            End If

            reader.Close()
            Con.Close()
        Catch ex As Exception
            Label7.Text = ex.Message
        End Try
    End Sub

    Private Sub RtBookNameTb_TextChanged(sender As Object, e As EventArgs) Handles RtBookNameTb.TextChanged
        RtBookNameTb.Text = CapitalizeFirstLetterOfEachWord(RtBookNameTb.Text)
        RtBookNameTb.SelectionStart = RtBookNameTb.Text.Length
        If Not String.IsNullOrEmpty(RtBookNameTb.Text) Then
            fetchBookDetails(RtBookNameTb.Text)

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


    Private Sub fetchBookDetails(bookName As String)
        Try
            Con.Open()
            Dim query = "SELECT BookId FROM BookTable WHERE BookName = @BookName"
            Dim cmd As New SqlCommand(query, Con)
            cmd.Parameters.AddWithValue("@BookName", bookName)
            Dim reader As SqlDataReader = cmd.ExecuteReader()
            If reader.Read() Then
                RtBookIdTb.Text = reader("BookId").ToString()
            Else
                RtBookIdTb.Text = ""
            End If
            reader.Close()
            Con.Close()
        Catch ex As Exception
            Label7.Text = ex.Message
        End Try
    End Sub

    Private Sub FillBooksAutoComplete()
        Try
            Con.Open()
            Dim query = "SELECT BookName FROM BookTable"
            Dim cmd As New SqlCommand(query, Con)
            Dim reader As SqlDataReader = cmd.ExecuteReader()
            Dim autoComplete As New AutoCompleteStringCollection()
            While reader.Read()
                autoComplete.Add(reader("BookName").ToString())
            End While
            reader.Close()
            RtBookNameTb.AutoCompleteCustomSource = autoComplete
            RtBookNameTb.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            RtBookNameTb.AutoCompleteSource = AutoCompleteSource.CustomSource
            Con.Close()
        Catch ex As Exception
            Label7.Text = ex.Message
        End Try
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Application.Exit()
        PictureBox1.BackColor = Color.DarkGray
    End Sub

    Private Sub PictureBox5_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox1.MouseEnter
        PictureBox1.BackColor = Color.DarkGray
    End Sub

    Private Sub PictureBox1_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox1.MouseLeave
        PictureBox1.BackColor = Color.MediumSeaGreen  ' Or any other color you want it to revert to
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim obj = New mainform
        obj.Show()
        Me.Hide()
    End Sub

    ' New code for calculating fines

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim finePerDay As Decimal = 1D ' Fine per day in GHC
        Dim maxDaysLate As Integer = 4 ' Changed to 4 days
        Label7.Visible = False

        Try
            Dim issueDate As DateTime = Convert.ToDateTime(RtIssueDateTb.Text)
            Dim returnDate As DateTime = DateTime.Now
            Dim daysLate As Integer = (returnDate - issueDate).Days

            If daysLate > maxDaysLate Then
                Dim fine As Decimal = (daysLate - maxDaysLate) * finePerDay
                RtFineTb.Text = "GHC " & fine.ToString("0.00")
            Else
                RtFineTb.Text = "No fine to pay."
            End If
        Catch ex As Exception
            Label7.Text = "Error: " & ex.Message
        End Try
    End Sub

    Private Sub RtStIdTb_Click(sender As Object, e As EventArgs) Handles RtStIdTb.Click
        Label10.Visible = False
        Label7.Visible = False
    End Sub

    Private Sub RtBookNameTb_Click(sender As Object, e As EventArgs) Handles RtBookNameTb.Click
        Label15.Visible = False
        Label7.Visible = False
    End Sub
End Class
