Imports System.Data.SqlClient
Imports System.Drawing.Drawing2D
Imports System.IO
Imports System.Text.RegularExpressions

Public Class IssueStudent
    Public Property ProfileImagePath As String

    Public Property IsStudent As Boolean
    Private WithEvents SlideInTimer As New Timer
    Private WithEvents SlideOutTimer2 As New Timer
    Private panelWidth As Integer

    Public Property RStudentName As String
    Public Property loggedInStudentId As String
    Public Property loggedInStudentName As String
    Public Property loggedInStudentDepartment As String
    Public Property StudentProfileImagePath As String
    Dim Con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\Documents\hello.mdf;Integrated Security=True;Connect Timeout=30")
    Dim keyIssue As Integer = 0
    Dim keyReturn As Integer = 0
    Private Sub IssueStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If loggedInStudentId IsNot Nothing Then
            RtStIdTb.Text = loggedInStudentId
        End If
        If loggedInStudentName IsNot Nothing Then
            RtStNameTb.Text = loggedInStudentName
        End If
        If loggedInStudentDepartment IsNot Nothing Then
            StdepartmentTb.Text = loggedInStudentDepartment
        End If
        RtIssueDateTb.Value = DateTime.Now
        RtIssueDateTb.Enabled = False

        RtStIdTb.Enabled = False
        RtStNameTb.Enabled = False
        StdepartmentTb.Enabled = False
        FillBooksAutoComplete()
        If Not String.IsNullOrEmpty(loggedInStudentName) Then
            Dim firstName As String = loggedInStudentName.Split(" "c)(0)
            ' Set greeting messages
            Label8.Text = "Welcome " & firstName & "!"
            LogoutLabel.Text = "Hi " & firstName & "!"
        Else
            ' Set default messages if loggedInStudentName is null or empty
            Label8.Text = "Welcome!"
            LogoutLabel.Text = "Hi!"
        End If
        ' Load student profile picture
        If ProfileImagePath IsNot Nothing Then
            ProfilePanel1.Image = Image.FromFile(ProfileImagePath)
            PreviewPictureBox2.Image = Image.FromFile(ProfileImagePath)
        Else
            ' Set default image if no profile image is available
            Dim defaultImagePath As String = IO.Path.Combine(Application.StartupPath, "png.png")
            If IO.File.Exists(defaultImagePath) Then
                ProfilePanel1.Image = Image.FromFile(defaultImagePath)
                PreviewPictureBox2.Image = Image.FromFile(defaultImagePath)
            End If
        End If
        MakePictureBoxRound(ProfilePanel1)
        MakePictureBoxRound(PreviewPictureBox2)

        LogoutPanel.Visible = False ' Ensure the LogoutPanel is hidden initially
        LogoutPanel.Width = 200 ' Set the width of the panel
        LogoutPanel.Location = New Point(-LogoutPanel.Width, 0) ' Position it off-screen to the left

        ' Ensure the event handlers are added correctly
        AddHandler SlideInTimer.Tick, AddressOf SlideInTimer_Tick
        AddHandler SlideOutTimer2.Tick, AddressOf SlideOutTimer_Tick

        If LogoutPanel.Visible Then
            SlideOutTimer.Interval = 20
            SlideOutTimer.Start()
        End If
    End Sub



    Private Sub MakePictureBoxRound(pb As PictureBox)
        Dim path As New GraphicsPath()
        path.AddEllipse(0, 0, pb.Height, pb.Height)
        pb.Region = New Region(path)
    End Sub

    Private Sub RtStIdTb_Leave(sender As Object, e As EventArgs) Handles RtStIdTb.Leave
        ' Fetch student name based on the student ID
        If RtStIdTb.Text.Trim() <> String.Empty Then
            FetchStudentName(RtStIdTb.Text.Trim())
        End If
    End Sub

    Private Sub RtBookNameTb_Leave(sender As Object, e As EventArgs) Handles RtBookNameTb.Leave, RtBookNameTb.TextChanged
        RtBookNameTb.Text = CapitalizeFirstLetterOfEachWord(RtBookNameTb.Text)
        RtBookNameTb.SelectionStart = RtBookNameTb.Text.Length
        If Not String.IsNullOrEmpty(RtBookNameTb.Text) Then
            fetchBookDetails(RtBookNameTb.Text)
            Label9.Visible = False
            Label7.Visible = False
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


    Private Sub submitBtn_Click(sender As Object, e As EventArgs) Handles submitBtn.Click
        Label7.Visible = True
        If ValidateInputs() Then
            IssueBook()
        End If
    End Sub

    Private Sub FetchStudentName(studentId As String)
        Try
            Using conn As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\Documents\hello.mdf;Integrated Security=True;Connect Timeout=30")
                conn.Open()
                Using cmd As New SqlCommand("SELECT RStudentName, RStudentDepartment, ProfileImagePath FROM RStudentTable WHERE RStudentId = @StudentId", conn)
                    cmd.Parameters.AddWithValue("@StudentId", studentId)
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            RtStNameTb.Text = reader("RStudentName").ToString()
                            StdepartmentTb.Text = reader("RStudentDepartment").ToString()
                            If Not IsDBNull(reader("ProfileImagePath")) Then
                                StudentProfileImagePath = reader("ProfileImagePath").ToString()
                            End If
                        Else
                            Label7.Text = "Invalid Student ID."
                            RtStNameTb.Clear()
                            StdepartmentTb.Clear()
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            Label7.Text = "An error occurred: " & ex.Message
        End Try
    End Sub

    Private Sub fetchBookDetails(bookName As String)
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
                Label7.Text = "Error: " & ex.Message
            End Try
        End Using
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

    Private Function ValidateInputs() As Boolean
        If String.IsNullOrWhiteSpace(RtStIdTb.Text) OrElse String.IsNullOrWhiteSpace(RtStNameTb.Text) OrElse String.IsNullOrWhiteSpace(StdepartmentTb.Text) OrElse String.IsNullOrWhiteSpace(RtBookIdTb.Text) OrElse String.IsNullOrWhiteSpace(RtBookNameTb.Text) Then
            Label9.Text = "Required."
            Return False
        End If

        Dim studentIdPattern As String = "^[A-Z]{3}\d{7}$"
        If Not Regex.IsMatch(RtStIdTb.Text, studentIdPattern) Then
            Label7.Text = "Invalid Student ID."
            Return False
        End If

        If Not Regex.IsMatch(RtStNameTb.Text, "^[A-Za-z\s]+$") Then
            Label7.Text = "Invalid Student Name."
            Return False
        End If

        If Not Regex.IsMatch(StdepartmentTb.Text, "^[A-Za-z\s]+$") Then
            Label7.Text = "Invalid Department Name."
            Return False
        End If

        If Not Regex.IsMatch(RtBookNameTb.Text, "^[A-Za-z\s]+$") Then
            Label9.Text = "Invalid Book Name."
            Return False
        End If

        Return True
    End Function

    Private Sub IssueBook()
        If RtBookIdTb.Text = "" Or RtStNameTb.Text = "" Or RtStIdTb.Text = "" Or RtBookNameTb.Text = "" Then
            Label7.Text = "Input Required"
            Label7.Visible = True
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
                            Label7.Text = "This issue record already exists."

                            Label7.ForeColor = Color.Red
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
                            Label7.Text = "Book Issued"
                            Label7.ForeColor = Color.Black
                            Label7.TextAlign = ContentAlignment.MiddleCenter
                            Reset()
                        End If
                    End Using
                Catch ex As Exception
                    Label7.Text = "Error: " & ex.Message
                End Try
            End Using
        End If
    End Sub

    ' Implement the sliding menu panel functionality
    Private Sub SlideInTimer_Tick(sender As Object, e As EventArgs) Handles SlideInTimer.Tick
        If LogoutPanel.Left < 0 Then
            LogoutPanel.Left += 20
        Else
            SlideInTimer.Stop()
        End If
    End Sub

    Private Sub SlideOutTimer_Tick(sender As Object, e As EventArgs)
        If LogoutPanel.Left > -LogoutPanel.Width Then
            LogoutPanel.Left -= 20 ' Adjust this value to control the speed
        Else
            SlideOutTimer2.Stop()
            LogoutPanel.Visible = False
            menu1.Visible = True

            ' Re-enable other controls
            RtBookIdTb.Enabled = True
            RtBookNameTb.Enabled = True
            RtIssueDateTb.Enabled = True
            RtStIdTb.Enabled = True
            RtStNameTb.Enabled = True
        End If
    End Sub

    Private Sub SignOut_Click(sender As Object, e As EventArgs) Handles signout1.Click
        Dim obj = New login
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub LogoutLabel_Click(sender As Object, e As EventArgs) Handles LogoutLabel.Click
        SlideOutTimer2.Interval = 30 ' Adjust the interval for smoother sliding
        SlideOutTimer2.Start()
    End Sub

    Private Sub menu1_Click(sender As Object, e As EventArgs) Handles menu1.Click
        If Not String.IsNullOrEmpty(loggedInStudentName) Then
            Dim firstName As String = loggedInStudentName.Split(" "c)(0)
            ' Start the slide-in effect
            LogoutLabel.Text = "Hi, " & firstName & "!"
        End If


        menu1.Visible = False
        LogoutPanel.Visible = True
        LogoutPanel.Location = New Point(-LogoutPanel.Width, 0) ' Start off-screen to the left
        SlideInTimer.Interval = 20
        SlideInTimer.Start()

        ' Disable other controls
        RtBookIdTb.Enabled = False
        RtBookNameTb.Enabled = False
        RtIssueDateTb.Enabled = False
        RtStIdTb.Enabled = False
        RtStNameTb.Enabled = False
    End Sub


    Private Sub Panel5_Click(sender As Object, e As EventArgs) Handles Panel5.Click
        ' Mimic the ProfilePictureBox1 click action
        SlideOutTimer2.Interval = 20
        SlideOutTimer2.Start()
    End Sub

    Private Sub UploadButton1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles UploadButton1.LinkClicked
        Using openFileDialog As New OpenFileDialog()
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
            Dim selected As Boolean = False
            While Not selected
                If openFileDialog.ShowDialog() = DialogResult.OK Then
                    Dim img As Image = Image.FromFile(openFileDialog.FileName)

                    ' Check if the image dimensions are within the range for passport size (500x500 to 700x700 pixels)
                    If img.Width >= 20 AndAlso img.Width <= 700 AndAlso img.Height >= 20 AndAlso img.Height <= 700 Then
                        PreviewPictureBox2.Image = New Bitmap(img, PreviewPictureBox2.Width, PreviewPictureBox2.Height)
                        MakePictureBoxRound(PreviewPictureBox2) ' Apply round shape after setting the image
                        If MessageBox.Show("Do you want to set this image as your profile picture?", "Confirm Image", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                            ProfilePanel1.Image = New Bitmap(img, ProfilePanel1.Width, ProfilePanel1.Height)
                            MakePictureBoxRound(ProfilePanel1) ' Apply round shape after setting the image
                            selected = True
                        End If
                    Else
                        MessageBox.Show("Please select an image with dimensions between 500x500 pixels and 700x700 pixels.", "Invalid Image Size", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                Else
                    ' User canceled the operation, exit the loop
                    selected = True
                End If
            End While
        End Using
    End Sub
End Class
