Imports System.Data.SqlClient

Public Class login

    Private Sub Admin_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Admin.LinkClicked
        Dim obj = New adminlogin
        obj.Show()
        Me.Hide()
    End Sub

    Dim Con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\Documents\hello.mdf;Integrated Security=True;Connect Timeout=30")

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label5.Visible = False

        If UnameTb.Text = "" Then
            Label5.Text = "Enter Librarian Name"
            Label5.Visible = True
        ElseIf UpasswordTb.Text = "" Then
            Label5.Text = "Enter The Password"
            Label5.ForeColor = Color.Red
            Label5.Visible = True
        Else
            Try
                Con.Open()
                Dim query = "SELECT * FROM LibrarianTable WHERE LibrarianName = @LibrarianName AND LibrarianPassword = @LibrarianPassword"
                Dim cmd = New SqlCommand(query, Con)
                cmd.Parameters.AddWithValue("@LibrarianName", UnameTb.Text)
                cmd.Parameters.AddWithValue("@LibrarianPassword", UpasswordTb.Text)
                Dim da = New SqlDataAdapter(cmd)
                Dim ds = New DataSet()
                da.Fill(ds)
                Dim a As Integer = ds.Tables(0).Rows.Count
                If a = 0 Then
                    Label5.Text = "Wrong User Name Or Password"
                    Label5.ForeColor = Color.Red
                    Label5.Visible = True
                Else
                    Dim obj = New mainform()
                    obj.LibrarianName = UnameTb.Text ' Pass the librarian's name
                    obj.Show()
                    Me.Hide()
                End If
                Con.Close()
            Catch ex As Exception
                MsgBox("Error: " & ex.Message)
                If Con.State = ConnectionState.Open Then
                    Con.Close()
                End If
            End Try
        End If
    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initially mask the password
        UpasswordTb.UseSystemPasswordChar = True
    End Sub

    Private Sub chkShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPassword.CheckedChanged
        ' Toggle password visibility based on checkbox state
        UpasswordTb.UseSystemPasswordChar = Not chkShowPassword.Checked

        ' Change the checkbox color based on its checked state
        If chkShowPassword.Checked Then
            chkShowPassword.BackColor = Color.SeaGreen
        Else
            chkShowPassword.BackColor = Color.Transparent ' Or any other default color
        End If
    End Sub

    Private Sub PictureBox2_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox2.MouseMove
        PictureBox2.BackColor = Color.DarkRed
    End Sub

    Private Sub PictureBox2_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox2.MouseLeave
        PictureBox2.BackColor = Color.FloralWhite ' Or any other color you want it to revert to
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        PictureBox2.BackColor = Color.DarkRed
        Application.Exit()
    End Sub

    Private Sub UnameTb_TextChanged(sender As Object, e As EventArgs) Handles UnameTb.TextChanged
        Dim words As String() = UnameTb.Text.Split(" "c)
        For i As Integer = 0 To words.Length - 1
            If words(i).Length > 0 Then
                words(i) = Char.ToUpper(words(i)(0)) & words(i).Substring(1).ToLower()
            End If
        Next
        UnameTb.Text = String.Join(" ", words)
        UnameTb.SelectionStart = UnameTb.Text.Length ' Move cursor to the end
    End Sub

    Private Sub Student_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Student.LinkClicked
        Dim obj = New Registering
        obj.Show()
        Me.Hide()
    End Sub


End Class