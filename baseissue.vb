Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class BaseIssueForm
    ' Declare common controls here
    Protected WithEvents RtStIdTb As New TextBox()
    Protected WithEvents RtStNameTb As New TextBox()
    Protected WithEvents StdepartmentTb As New TextBox()
    Protected WithEvents RtBookIdTb As New TextBox()
    Protected WithEvents RtBookNameTb As New TextBox()
    Protected WithEvents RtIssueDateTb As New DateTimePicker()
    Protected WithEvents submitBtn As New Button()
    Protected WithEvents editBtn As New Button()
    Protected WithEvents resetBtn As New Button()
    Protected WithEvents PictureBox1 As New PictureBox()

    Public Sub New()
        ' InitializeComponent() Call this in derived forms
        InitializeCommonControls()
    End Sub

    Protected Sub InitializeCommonControls()
        ' Add initialization code for common controls
        Me.Controls.Add(RtStIdTb)
        Me.Controls.Add(RtStNameTb)
        Me.Controls.Add(StdepartmentTb)
        Me.Controls.Add(RtBookIdTb)
        Me.Controls.Add(RtBookNameTb)
        Me.Controls.Add(RtIssueDateTb)
        Me.Controls.Add(submitBtn)
        Me.Controls.Add(editBtn)
        Me.Controls.Add(resetBtn)
        Me.Controls.Add(PictureBox1)

        ' Set properties for controls (e.g., size, location, etc.)
        ' Example:
        RtStIdTb.Location = New Point(20, 20)
        RtStIdTb.Size = New Size(200, 30)
        ' Similarly set properties for other controls
    End Sub

    Protected Sub GetStudentDetailsById(studentId As String)
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
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub

    Protected Sub GetBookIdByName(bookName As String)
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
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub

    Protected Sub submitBtn_Click(sender As Object, e As EventArgs) Handles submitBtn.Click
        If RtBookIdTb.Text = "" Or RtStNameTb.Text = "" Or RtStIdTb.Text = "" Or RtBookNameTb.Text = "" Then
            MsgBox("Missing Information")
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
                            MsgBox("This issue record already exists.")
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
                            MsgBox("Book Issued")
                            reset()
                        End If
                    End Using
                Catch ex As Exception
                    MsgBox("Error: " & ex.Message)
                End Try
            End Using
        End If
    End Sub

    Protected Sub reset()
        RtStIdTb.Text = ""
        RtStNameTb.Text = ""
        StdepartmentTb.Text = ""
        RtBookIdTb.Text = ""
        RtBookNameTb.Text = ""
    End Sub

    Protected Sub resetBtn_Click(sender As Object, e As EventArgs) Handles resetBtn.Click
        reset()
    End Sub

    Protected Sub RtStIdTb_TextChanged(sender As Object, e As EventArgs) Handles RtStIdTb.TextChanged
        If Not String.IsNullOrEmpty(RtStIdTb.Text) Then
            If RtStIdTb.Text.Length > 3 Then
                RtStIdTb.Text = RtStIdTb.Text.Substring(0, 3).ToUpper() & RtStIdTb.Text.Substring(3)
                RtStIdTb.SelectionStart = RtStIdTb.Text.Length
            End If
            GetStudentDetailsById(RtStIdTb.Text)
        End If
    End Sub

    Protected Sub RtBookNameTb_TextChanged(sender As Object, e As EventArgs) Handles RtBookNameTb.TextChanged
        If Not String.IsNullOrEmpty(RtBookNameTb.Text) Then
            GetBookIdByName(RtBookNameTb.Text)
        End If
    End Sub

    Protected Sub RtStIdTb_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles RtStIdTb.Validating
        Dim regex As New Regex("^[A-Z]{3}\d{7}$")
        If Not regex.IsMatch(RtStIdTb.Text) Then
            e.Cancel = True
        Else
            ' Do something when valid
        End If
    End Sub

    Protected Sub RtBookNameTb_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles RtBookNameTb.Validating
        Dim regex As New Regex("^[a-zA-Z\s]+$")
        If Not regex.IsMatch(RtBookNameTb.Text) Then
            MsgBox("Invalid Book Name. Only alphabetic characters and spaces are allowed.")
            e.Cancel = True
        End If
    End Sub

    Protected Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Application.Exit()
        PictureBox1.BackColor = Color.DarkGray
    End Sub

    Protected Sub PictureBox1_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox1.MouseEnter
        PictureBox1.BackColor = Color.DarkGray
    End Sub

    Protected Sub PictureBox1_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox1.MouseLeave
        PictureBox1.BackColor = Color.MediumSeaGreen  ' Or any other color you want it to revert to
    End Sub

End Class
