Imports System.Data.SqlClient
Imports System.Drawing.Drawing2D
Imports System.IO
Imports System.Text.RegularExpressions

Public Class Registering

    Private Sub Registerin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RegistrationPanel.Visible = True
        SignInPanel.Visible = True
        SwitchToSignIn.Visible = True
        SwitchToSignIn.Enabled = False
        SignupBtn.Visible = True
        SignupBtn.Enabled = False
        RegistrationPanel.Enabled = False
        SignInPasswordTb.UseSystemPasswordChar = True
        PasswordTb.UseSystemPasswordChar = True
        PictureSignup.Enabled = False
        Dim defaultImagePath As String = IO.Path.Combine(Application.StartupPath, "png.png")
        If IO.File.Exists(defaultImagePath) Then
            PictureSignup.Image = Image.FromFile(defaultImagePath)
            PictureSignup.Image = Image.FromFile(defaultImagePath)
            MakePictureBoxRound(PictureSignup)
            MakePictureBoxRound(PictureSignup)
        End If

    End Sub
    Private Sub CheckStudentRegistrationStatus()
        Dim studentId As String = InputStudentId()

        If Not String.IsNullOrEmpty(studentId) AndAlso IsStudentRegistered(studentId) Then
            RegistrationPanel.Visible = False
            SignInPanel.Visible = True
        Else
            RegistrationPanel.Visible = True
            SignInPanel.Visible = False
        End If
    End Sub

    Private Function IsStudentRegistered(studentId As String) As Boolean
        Dim connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\Documents\hello.mdf;Integrated Security=True;Connect Timeout=30"
        Dim query As String = "SELECT COUNT(*) FROM RStudentTable WHERE RStudentId = @RStudentId"

        Using con As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@RStudentId", studentId)
                con.Open()
                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                Return count > 0
            End Using
        End Using
    End Function

    Private Sub SignupBtn_Click(sender As Object, e As EventArgs) Handles SignupBtn.Click
        Dim validationMessage As String = ValidateInputs()

        If Not String.IsNullOrEmpty(validationMessage) Then
            MessageBox.Show(validationMessage, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        SaveStudentData(StTb.Text, IdTb.Text, DpTb.Text, SmsTb.Text, PhoneTb.Text, PasswordTb.Text)
        Dim welcomeMessage As String = $"Hello {StTb.Text}, welcome to UENR Library!"
        MessageBox.Show(welcomeMessage, "Registration Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)

        RegistrationPanel.Visible = True
        RegistrationPanel.Enabled = False
        SignInPanel.Visible = True
        SignInPanel.Enabled = True
        SignInButton.Visible = True
        SignInButton.Enabled = True
        SignupBtn.Visible = True
        SignupBtn.Enabled = False
        SwitchToRegistration.Visible = True
        SwitchToRegistration.Enabled = True
        RegistrationPanel.Enabled = False
        SwitchToSignIn.Enabled = False
        PictureSignup.Enabled = False
        PasswordTb.Clear()
        StTb.Clear()
        IdTb.Clear()
        DpTb.Clear()
        PhoneTb.Clear()
        PictureSignup.Visible = False
        SmsTb.Text = String.Empty
    End Sub

    Private Function ValidateInputs() As String
        If String.IsNullOrWhiteSpace(StTb.Text) Then
            Return "Student Name is required."
        ElseIf Not Regex.IsMatch(StTb.Text, "^[A-Z][a-zA-Z\s]+$") Then
            Return "Student Name must only contain letters and spaces, starting with an uppercase letter."
        End If

        If String.IsNullOrWhiteSpace(IdTb.Text) Then
            Return "Student ID is required."
        ElseIf Not Regex.IsMatch(IdTb.Text, "^[A-Z]{3}\d{7}$") Then
            Return "Student ID must be in the format of 3 uppercase letters followed by 7 digits."
        End If

        If String.IsNullOrWhiteSpace(DpTb.Text) Then
            Return "Department is required."
        ElseIf Not Regex.IsMatch(DpTb.Text, "^[A-Z][a-zA-Z\s]+$") Then
            Return "Department must only contain letters and spaces, starting with an uppercase letter."
        End If

        If String.IsNullOrWhiteSpace(SmsTb.Text) Then
            Return "SMS is required."
        End If

        If String.IsNullOrWhiteSpace(PhoneTb.Text) Then
            Return "Phone number is required."
        ElseIf Not Regex.IsMatch(PhoneTb.Text, "^\d{10}$") Then
            Return "Phone number must be exactly 10 digits."
        End If

        If String.IsNullOrWhiteSpace(PasswordTb.Text) Then
            Return "Password is required."
        ElseIf PasswordTb.Text.Length < 6 Then
            Return "Password must be at least 6 characters long."
        End If

        If PictureSignup.Image Is Nothing Then
            Return "Please upload a profile picture."
        End If

        Return String.Empty
    End Function

    Private Function SaveStudentData(name As String, id As String, department As String, sms As String, phone As String, password As String) As Boolean
        Dim connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\Documents\hello.mdf;Integrated Security=True;Connect Timeout=30"
        Dim checkQuery As String = "SELECT COUNT(*) FROM RStudentTable WHERE RStudentId = @RStudentId"
        Dim insertQuery As String = "INSERT INTO RStudentTable (RStudentId, RStudentName, RStudentDepartment, RStudentSemester, RStudentPhone, RStudentPassword, RegistrationDate, ProfileImagePath) VALUES (@RStudentId, @RStudentName, @RStudentDepartment, @RStudentSemester, @RStudentPhone, @RStudentPassword, @RegistrationDate, @ProfileImagePath)"
        Dim profileImagePath As String = SaveProfilePicture(id)

        Using con As New SqlConnection(connectionString)
            con.Open()

            ' Check if the ID already exists
            Using checkCmd As New SqlCommand(checkQuery, con)
                checkCmd.Parameters.AddWithValue("@RStudentId", id)
                Dim count As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())

                If count > 0 Then
                    ' ID already exists
                    MessageBox.Show("ID already exists.")

                    ' Highlight the ID TextBox in red
                    IdTb.BackColor = Color.LightCoral
                    Return False
                End If
            End Using
            con.Close()

            ' Reset TextBox color if ID is unique
            IdTb.BackColor = Color.FloralWhite

            con.Open()
            Using insertCmd As New SqlCommand(insertQuery, con)
                insertCmd.Parameters.AddWithValue("@RStudentId", id)
                insertCmd.Parameters.AddWithValue("@RStudentName", name)
                insertCmd.Parameters.AddWithValue("@RStudentDepartment", department)
                insertCmd.Parameters.AddWithValue("@RStudentSemester", sms)
                insertCmd.Parameters.AddWithValue("@RStudentPhone", phone)
                insertCmd.Parameters.AddWithValue("@RStudentPassword", password)
                insertCmd.Parameters.AddWithValue("@RegistrationDate", DateTime.Now)
                insertCmd.Parameters.AddWithValue("@ProfileImagePath", profileImagePath)
                insertCmd.ExecuteNonQuery()
            End Using

            con.Close()
        End Using

        Return True
    End Function

    Private Function SaveProfilePicture(studentId As String) As String
        If PictureSignup.Image IsNot Nothing Then
            Dim profilePicturesDirectory As String = Path.Combine(Application.StartupPath, "ProfilePictures")
            If Not Directory.Exists(profilePicturesDirectory) Then
                Directory.CreateDirectory(profilePicturesDirectory)
            End If
            Dim profilePicturePath As String = Path.Combine(profilePicturesDirectory, studentId & ".jpg")
            PictureSignup.Image.Save(profilePicturePath, System.Drawing.Imaging.ImageFormat.Jpeg)
            Return profilePicturePath
        End If
        Return Nothing
    End Function

    Private Sub MakePictureBoxRound(pb As PictureBox)
        Dim path As New GraphicsPath()
        path.AddEllipse(0, 0, pb.Height, pb.Height)
        pb.Region = New Region(path)
    End Sub

    ' Example code in the login form

    ' Function to validate login and return StudentId
    Private Function GetLoggedInStudentId() As String
        ' Replace with your login validation logic
        ' Return the logged-in student's StudentId
        Return "ABC1234567" ' Example StudentId
    End Function

    Private Function GetProfileImagePath(studentId As String) As String
        Dim connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\Documents\hello.mdf;Integrated Security=True;Connect Timeout=30"
        Dim query As String = "SELECT ProfileImagePath FROM RStudentTable WHERE RStudentId = @RStudentId"

        Using con As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@RStudentId", studentId)
                con.Open()
                Return Convert.ToString(cmd.ExecuteScalar())
            End Using
        End Using
    End Function

    Private Sub SignInButton_Click(sender As Object, e As EventArgs) Handles SignInButton.Click
        Dim studentId As String = IndexNumberTb.Text
        Dim password As String = SignInPasswordTb.Text

        If ValidateSignIn(studentId, password) Then
            MessageBox.Show("Sign-In Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dim studentDetails As StudentDetails = GetStudentDetails(studentId)

            ' Open the IssueStudent form and pass the student details
            Dim issueStudentForm As New IssueStudent()
            issueStudentForm.loggedInStudentId = studentDetails.StudentId
            issueStudentForm.loggedInStudentName = studentDetails.StudentName
            issueStudentForm.loggedInStudentDepartment = studentDetails.StudentDepartment

            ' Get the profile image path and set it
            Dim profileImagePath As String = GetProfileImagePath(studentId)
            If String.IsNullOrEmpty(profileImagePath) Then
                profileImagePath = AGetProfileImagePath(studentId)
            End If

            If Not String.IsNullOrEmpty(profileImagePath) AndAlso File.Exists(profileImagePath) Then
                issueStudentForm.ProfileImagePath = profileImagePath
            Else
                MessageBox.Show("Profile picture not found or path is invalid.")
            End If

            issueStudentForm.Show()
            Me.Hide()
        ElseIf AuthenticateUser(studentId, password) Then
            MessageBox.Show("Sign-In Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dim studentDetails As StudentDetails = AGetStudentDetails(studentId)

            ' Open the IssueStudent form and pass the student details
            Dim issueStudentForm As New IssueStudent()
            issueStudentForm.loggedInStudentId = studentDetails.StudentId
            issueStudentForm.loggedInStudentName = studentDetails.StudentName
            issueStudentForm.loggedInStudentDepartment = studentDetails.StudentDepartment

            ' Get the profile image path and set it
            Dim profileImagePath As String = AGetProfileImagePath(studentId)
            If Not String.IsNullOrEmpty(profileImagePath) AndAlso File.Exists(profileImagePath) Then
                issueStudentForm.ProfileImagePath = profileImagePath
            Else
                MessageBox.Show("Profile picture not found or path is invalid.")
            End If

            issueStudentForm.Show()
            Me.Hide()
        Else
            MessageBox.Show("Invalid student ID or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Public Class StudentDetails
        Public Property StudentId As String
        Public Property StudentName As String
        Public Property StudentDepartment As String
    End Class
    Private Function GetStudentDetails(studentId As String) As StudentDetails
        Dim studentDetails As New StudentDetails()
        Dim connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\Documents\hello.mdf;Integrated Security=True;Connect Timeout=30"
        Dim query As String = "SELECT RStudentId, RStudentName, RStudentDepartment FROM RStudentTable WHERE RStudentId = @RStudentId"

        Using con As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@RStudentId", studentId)
                con.Open()
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        studentDetails.StudentId = reader("RStudentId").ToString()
                        studentDetails.StudentName = reader("RStudentName").ToString()
                        studentDetails.StudentDepartment = reader("RStudentDepartment").ToString()
                    End If
                End Using
            End Using
        End Using

        Return studentDetails
    End Function

    Private Function AGetStudentDetails(studentId As String) As StudentDetails
        Dim studentDetails As New StudentDetails()
        Dim connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\Documents\hello.mdf;Integrated Security=True;Connect Timeout=30"
        Dim query As String = "SELECT RStudentId, RStudentName, RStudentDepartment FROM ArchivedStudentTable WHERE RStudentId = @RStudentId"

        Using con As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@RStudentId", studentId)
                con.Open()
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        studentDetails.StudentId = reader("RStudentId").ToString()
                        studentDetails.StudentName = reader("RStudentName").ToString()
                        studentDetails.StudentDepartment = reader("RStudentDepartment").ToString()
                    End If
                End Using
            End Using
        End Using

        Return studentDetails
    End Function

    Private Function AGetProfileImagePath(studentId As String) As String
        Dim connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\Documents\hello.mdf;Integrated Security=True;Connect Timeout=30"
        Dim query As String = "SELECT ProfileImagePath FROM ArchivedStudentTable WHERE RStudentId = @RStudentId"

        Using con As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@RStudentId", studentId)
                con.Open()
                Return Convert.ToString(cmd.ExecuteScalar())
            End Using
        End Using
    End Function

    Private Function ValidateSignIn(studentId As String, password As String) As Boolean
        Dim connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\Documents\hello.mdf;Integrated Security=True;Connect Timeout=30"
        Dim query As String = "SELECT COUNT(*) FROM RStudentTable WHERE RStudentId = @RStudentId AND RStudentPassword = @RStudentPassword"

        Using con As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@RStudentId", studentId)
                cmd.Parameters.AddWithValue("@RStudentPassword", password)
                con.Open()
                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                Return count > 0
            End Using
        End Using
    End Function
    Private Sub UploadPictureButton_Click(sender As Object, e As EventArgs)
        ' Create a new instance of OpenFileDialog
        Using openFileDialog As New OpenFileDialog()
            ' Set the filter to display only image files
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
            openFileDialog.Title = "Select a Profile Picture"

            ' Show the dialog and check if the user selected a file
            If openFileDialog.ShowDialog() = DialogResult.OK Then
                Try
                    ' Load the selected image
                    Dim img As Image = Image.FromFile(openFileDialog.FileName)

                    ' Resize the image to fit the PictureBox dimensions
                    PictureSignup.Image = New Bitmap(img, PictureSignup.Width, PictureSignup.Height)

                    ' Optionally, you can dispose of the original image to free up resources
                    img.Dispose()
                Catch ex As Exception
                    ' Handle any exceptions that might occur during image loading
                    MessageBox.Show("An error occurred while loading the image. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End Using
    End Sub

    Private Function InputStudentId() As String
        ' Replace this method with actual logic to get the student ID from user input
        Return String.Empty
    End Function
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Application.Exit()
        PictureBox3.BackColor = Color.DarkGray
    End Sub

    Private Sub PictureBox3_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox3.MouseEnter
        PictureBox3.BackColor = Color.DarkGray
    End Sub

    Private Sub PictureBox3_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox3.MouseLeave
        PictureBox3.BackColor = Color.FloralWhite
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim obj = New login
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub DisplayProfilePanel(studentId As String)
        ' Fetch student details
        Dim studentDetails As StudentDetails = GetStudentDetails(studentId)

        ' Set the profile details in the profile panel

        ' Show the profile panel
        PictureSignup.Visible = True
        SignInPanel.Visible = False
        RegistrationPanel.Visible = False
    End Sub

    Private Function AuthenticateUser(studentId As String, password As String) As Boolean
        Dim connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\Documents\hello.mdf;Integrated Security=True;Connect Timeout=30"
        Dim query As String = "SELECT COUNT(*) FROM ArchivedStudentTable WHERE RStudentId = @RStudentId AND RStudentPassword = @RStudentPassword"

        Using con As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@RStudentId", studentId)
                cmd.Parameters.AddWithValue("@RStudentPassword", password)
                con.Open()
                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                Return count > 0
            End Using
        End Using
    End Function

    Private Sub MaterialFlatButton1_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton1.Click
        Using openFileDialog As New OpenFileDialog()
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
            Dim selected As Boolean = False
            While Not selected
                If openFileDialog.ShowDialog() = DialogResult.OK Then
                    Dim img As Image = Image.FromFile(openFileDialog.FileName)

                    ' Check if the image dimensions are within the range for passport size (500x500 to 700x700 pixels)
                    If img.Width >= 20 AndAlso img.Width <= 700 AndAlso img.Height >= 20 AndAlso img.Height <= 700 Then
                        PictureSignup.Image = New Bitmap(img, PictureSignup.Width, PictureSignup.Height)
                        MakePictureBoxRound(PictureSignup) ' Apply round shape after setting the image
                        If MessageBox.Show("Do you want to set this image as your profile picture?", "Confirm Image", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                            PictureSignup.Image = New Bitmap(img, PictureSignup.Width, PictureSignup.Height)
                            MakePictureBoxRound(PictureSignup) ' Apply round shape after setting the image
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

    Private Sub SwitchToRegistration_Click_1(sender As Object, e As EventArgs) Handles SwitchToRegistration.Click
        RegistrationPanel.Visible = True
        SignInPanel.Visible = True
        SignInPanel.Enabled = False
        SignInButton.Visible = True
        SignInButton.Enabled = False
        SwitchToSignIn.Visible = True
        SwitchToSignIn.Enabled = True
        SignupBtn.Visible = True
        SignupBtn.Enabled = True
        SwitchToRegistration.Enabled = False
        RegistrationPanel.Enabled = True
        SignInPasswordTb.Clear()
        IndexNumberTb.Clear()
        PictureSignup.Visible = True

    End Sub

    Private Sub SwitchToSignIn_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles SwitchToSignIn.LinkClicked
        RegistrationPanel.Visible = True
        RegistrationPanel.Enabled = False
        SignInPanel.Visible = True
        SignInPanel.Enabled = True
        SignInButton.Visible = True
        SignInButton.Enabled = True
        SignupBtn.Visible = True
        SignupBtn.Enabled = False
        SwitchToRegistration.Visible = True
        SwitchToRegistration.Enabled = True
        RegistrationPanel.Enabled = False
        SwitchToSignIn.Enabled = False
        PictureSignup.Enabled = False
        PasswordTb.Clear()
        StTb.Clear()
        IdTb.Clear()
        DpTb.Clear()
        PhoneTb.Clear()
        PictureSignup.Visible = False
        SmsTb.Text = String.Empty
    End Sub

    Private Sub MaterialCheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles MaterialCheckBox1.CheckedChanged
        If MaterialCheckBox1.Checked Then
            PasswordTb.UseSystemPasswordChar = False
        Else
            PasswordTb.UseSystemPasswordChar = True
        End If
    End Sub
    Private Sub chkShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPassword.CheckedChanged
        If chkShowPassword.Checked Then
            SignInPasswordTb.UseSystemPasswordChar = False
        Else
            SignInPasswordTb.UseSystemPasswordChar = True
        End If
    End Sub
End Class
