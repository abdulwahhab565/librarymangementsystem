Public Class adminlogin
    Private Const maxAttempts As Integer = 4
    Private Const lockoutTime As Integer = 1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If LoginState.AttemptCount >= maxAttempts AndAlso DateTime.Now < LoginState.LastFailedAttempt.AddMinutes(lockoutTime) Then
            Dim remainingTime As TimeSpan = LoginState.LastFailedAttempt.AddMinutes(lockoutTime) - DateTime.Now
            MsgBox("Too many attempts. Please wait " & remainingTime.Minutes & " minutes and " & remainingTime.Seconds & " seconds.")
            Return
        End If

        If UpasswordTb.Text = "" Then
            lblWrongPassword.Text = "Enter Admin password"
            lblWrongPassword.Visible = True
        ElseIf UpasswordTb.Text = "1234" Then
            LoginState.AttemptCount = 0
            Dim obj = New librarians
            obj.Show()
            Me.Hide()
        Else
            lblWrongPassword.Text = "Wrong password"
            lblWrongPassword.ForeColor = Color.Red
            lblWrongPassword.Visible = True
            UpasswordTb.Text = ""

            LoginState.AttemptCount += 1
            If LoginState.AttemptCount >= maxAttempts Then
                LoginState.LastFailedAttempt = DateTime.Now
                Timer1.Interval = lockoutTime * 60000
                Timer1.Start()
                Button1.Enabled = False
                lblWrongPassword.Text = "Too many attempts. Please wait " & lockoutTime & " minutes."
            End If
        End If
    End Sub

    Private Sub UpasswordTb_Enter(sender As Object, e As EventArgs) Handles UpasswordTb.Enter
        lblWrongPassword.Visible = False
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        Button1.Enabled = True
        LoginState.AttemptCount = 0
    End Sub

    Private Sub adminlogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Mask the password using system-defined character initially
        UpasswordTb.UseSystemPasswordChar = True

        ' Check if the user is currently locked out
        If LoginState.AttemptCount >= maxAttempts AndAlso DateTime.Now < LoginState.LastFailedAttempt.AddMinutes(lockoutTime) Then
            Button1.Enabled = False
            Dim remainingTime As TimeSpan = LoginState.LastFailedAttempt.AddMinutes(lockoutTime) - DateTime.Now
            Timer1.Interval = remainingTime.TotalMilliseconds
            Timer1.Start()
        End If
    End Sub

    Private Sub chkShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPassword.CheckedChanged
        If chkShowPassword.Checked Then
            UpasswordTb.UseSystemPasswordChar = False  ' Show password
        Else
            UpasswordTb.UseSystemPasswordChar = True   ' Mask password
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Application.Exit()
        PictureBox2.BackColor = Color.DarkGray
    End Sub
    Private Sub PictureBox2_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox2.MouseEnter
        PictureBox2.BackColor = Color.DarkGray
    End Sub

    Private Sub PictureBox2_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox2.MouseLeave
        PictureBox2.BackColor = Color.MediumSeaGreen  ' Or any other color you want it to revert to
    End Sub

    Private Sub Label1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Label1.LinkClicked
        Dim obj = New login
        obj.Show()
        Me.Hide()
    End Sub
End Class
