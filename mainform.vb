Imports System.Drawing.Drawing2D

Public Class mainform
    Public Property LibrarianName As String
    Public Property IsAdmin As Boolean
    Private WithEvents SlideInTimer As New Timer
    Private WithEvents SlideOutTimer As New Timer
    Private panelWidth As Integer
    Public Property loggedInStudentId As String
    Public Property loggedInStudentName As String
    Public Property loggedInStudentDepartment As String

    Public Sub NavigateToIssueStudent()
        Dim issueStudentForm As New IssueStudent()
        issueStudentForm.RStudentName = Me.LibrarianName ' Assuming this is the name of the logged-in student
        issueStudentForm.IsStudent = Not Me.IsAdmin ' Assume IsAdmin flag differentiates between student and admin
        issueStudentForm.loggedInStudentId = Me.loggedInStudentId ' Pass the student ID if applicable
        issueStudentForm.loggedInStudentName = Me.loggedInStudentName ' Pass the student name if applicable
        issueStudentForm.loggedInStudentDepartment = Me.loggedInStudentDepartment ' Pass the department if applicable
        issueStudentForm.Show()
        Me.Hide()
    End Sub

    Private Sub welcome2_Click(sender As Object, e As EventArgs) Handles welcome2.Click
        Dim obj = New books
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub welcome1_Click(sender As Object, e As EventArgs) Handles welcome1.Click
        Dim obj = New students
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub welcome3_Click(sender As Object, e As EventArgs) Handles welcome3.Click
        Dim obj = New IssueBooks
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub welcome4_Click(sender As Object, e As EventArgs) Handles welcome4.Click
        Dim obj = New BookReturn
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub mainform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProfilePictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
        ' Call MakePictureBoxRound to apply rounded corners
        MakePictureBoxRound(ProfilePictureBox1)
        If IsAdmin Then
            Label1.Text = "Welcome Admin!"
        Else
            Label1.Text = "Welcome " & LibrarianName & "..."
        End If

        ' Set default image if no profile image is available
        Dim defaultImagePath As String = IO.Path.Combine(Application.StartupPath, "png.png")
        If IO.File.Exists(defaultImagePath) Then
            ProfilePictureBox1.Image = Image.FromFile(defaultImagePath)
            PreviewPictureBox2.Image = Image.FromFile(defaultImagePath)
            MakePictureBoxRound(ProfilePictureBox1)
            MakePictureBoxRound(PreviewPictureBox2)
        End If

        LogoutPanel.Visible = False ' Ensure the LogoutPanel is hidden initially
        LogoutPanel.Width = 200 ' Set the width of the panel
        LogoutPanel.Location = New Point(-LogoutPanel.Width, 0) ' Position it off-screen to the left

        AddHandler SlideInTimer.Tick, AddressOf SlideInTimer_Tick
        AddHandler SlideOutTimer.Tick, AddressOf SlideOutTimer_Tick
    End Sub

    Private Sub menu1_Click(sender As Object, e As EventArgs) Handles menu1.Click
        ' Start the slide-in effect
        LogoutLabel.Text = "Hi " & LibrarianName & "!"

        menu1.Visible = False
        LogoutPanel.Visible = True
        LogoutPanel.Location = New Point(-LogoutPanel.Width, 0) ' Start off-screen to the left
        SlideInTimer.Interval = 20
        SlideInTimer.Start()

        ' Disable other controls
        welcome1.Enabled = False
        welcome2.Enabled = False
        welcome3.Enabled = False
        welcome4.Enabled = False
    End Sub

    Private Sub SlideInTimer_Tick(sender As Object, e As EventArgs)
        ' Slide the LogoutPanel into view from the left edge
        If LogoutPanel.Left < 0 Then
            LogoutPanel.Left += 20 ' Adjust this value to control the speed
        Else
            SlideInTimer.Stop()
        End If
    End Sub

    Private Sub SlideOutTimer_Tick(sender As Object, e As EventArgs)
        ' Slide the LogoutPanel out of view to the left
        If LogoutPanel.Left > -LogoutPanel.Width Then
            LogoutPanel.Left -= 20 ' Adjust this value to control the speed
        Else
            SlideOutTimer.Stop()
            LogoutPanel.Visible = False
            menu1.Visible = True

            ' Re-enable other controls
            welcome1.Enabled = True
            welcome2.Enabled = True
            welcome3.Enabled = True
            welcome4.Enabled = True
        End If
    End Sub

    Private Sub signout1_Click(sender As Object, e As EventArgs) Handles signout1.Click
        Dim obj = New login
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Application.Exit()
        PictureBox5.BackColor = Color.DarkGray
    End Sub

    Private Sub PictureBox5_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox5.MouseEnter
        PictureBox5.BackColor = Color.DarkGray
    End Sub

    Private Sub PictureBox5_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox5.MouseLeave
        PictureBox5.BackColor = Color.FloralWhite  ' Or any other color you want it to revert to
    End Sub

    Private Sub LogoutLabel_Click(sender As Object, e As EventArgs) Handles LogoutLabel.Click
        SlideOutTimer.Interval = 20
        SlideOutTimer.Start()
    End Sub

    Private Sub mainform_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        If LogoutPanel.Visible Then
            SlideOutTimer.Interval = 20
            SlideOutTimer.Start()
        End If
    End Sub

    ' Additional code for circular PictureBox and image upload
    Private Sub MakePictureBoxRound(pb As PictureBox)
        Dim path As New GraphicsPath()
        path.AddEllipse(0, 0, pb.Height, pb.Height)
        pb.Region = New Region(path)
    End Sub
    Private Sub ProfilePictureBox1_Click(sender As Object, e As EventArgs) Handles ProfilePictureBox1.Click
        SlideOutTimer.Interval = 20
        SlideOutTimer.Start()
    End Sub

    ' Add this new event handler
    Private Sub Panel5_Click(sender As Object, e As EventArgs) Handles Panel5.Click
        ' Mimic the ProfilePictureBox1 click action
        SlideOutTimer.Interval = 20
        SlideOutTimer.Start()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        Dim obj = New mainform
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub LogoutPanel_Paint(sender As Object, e As PaintEventArgs) Handles LogoutPanel.Paint

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
                            ProfilePictureBox1.Image = New Bitmap(img, ProfilePictureBox1.Width, ProfilePictureBox1.Height)
                            MakePictureBoxRound(ProfilePictureBox1) ' Apply round shape after setting the image
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
