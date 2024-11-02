Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class librarians
    Dim Con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\Documents\hello.mdf;Integrated Security=True;Connect Timeout=30")
    Dim Key As String = ""
    Private Sub displaylibrarians()
        Con.Open()
        Dim query = "SELECT * FROM LibrarianTable"
        Dim adapter As New SqlDataAdapter(query, Con)
        Dim builder As New SqlCommandBuilder(adapter)
        Dim ds As New DataSet()
        adapter.Fill(ds)
        LibDGV.DataSource = ds.Tables(0)
        Con.Close()
    End Sub

    Private Sub reset()
        LibIdTb.Text = ""
        LibnameTb.Text = ""
        LibphoneTb.Text = ""
        LibpassTb.Text = ""
        Label9.Visible = False
        Label10.Visible = False
        Label11.Visible = False
        Label12.Visible = False
        Label5.Visible = False

    End Sub

    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        If LibIdTb.Text = "" Then
            Label10.Text = "required"
            Label10.Visible = True
            Label10.BackColor = Color.FloralWhite
        End If
        If LibnameTb.Text = "" Then
            Label9.Text = "required"
            Label9.Visible = True
            Label9.BackColor = Color.FloralWhite

        End If

        If LibphoneTb.Text = "" Then
            Label11.Text = "required"
            Label11.Visible = True
            Label11.BackColor = Color.FloralWhite
        End If

        If LibpassTb.Text = "" Then
            Label12.Text = "required"
            Label12.Visible = True
            Label12.BackColor = Color.FloralWhite

        End If

        If Not IsValidInput() Then
            Exit Sub
        End If

        Con.Open()
        Dim query = "INSERT INTO LibrarianTable (LibrarianId, LibrarianName, LibrarianPhone, LibrarianPassword) VALUES (@LibrarianId, @LibrarianName, @LibrarianPhone, @LibrarianPassword)"
        Using cmd As New SqlCommand(query, Con)
            cmd.Parameters.AddWithValue("@LibrarianId", LibIdTb.Text)
            cmd.Parameters.AddWithValue("@LibrarianName", LibnameTb.Text)
            cmd.Parameters.AddWithValue("@LibrarianPhone", LibphoneTb.Text)
            cmd.Parameters.AddWithValue("@LibrarianPassword", LibpassTb.Text)
            cmd.ExecuteNonQuery()
        End Using
        Label5.Text = "Librarian Saved"
        Label5.ForeColor = Color.Black
        Con.Close()
        displaylibrarians()
        reset()
    End Sub

    Private Sub ResetBtn_Click(sender As Object, e As EventArgs) Handles ResetBtn.Click
        reset()
    End Sub

    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click
        If Key = "" Then
            Label5.Text = "Please select a student to delete."
            Label5.Visible = True
            Return
        End If
        Con.Open()
            Dim query = "DELETE FROM LibrarianTable WHERE LibrarianId = @key"
            Using cmd As New SqlCommand(query, Con)
                cmd.Parameters.AddWithValue("@key", key)
                cmd.ExecuteNonQuery()
            End Using
            Label5.Text = "Librarian Deleted"
            Label5.ForeColor = Color.Black
            Con.Close()
            displaylibrarians()
        reset()
    End Sub

    Private Sub EditBtn_Click(sender As Object, e As EventArgs) Handles EditBtn.Click
        If Key = "" Then
            Label5.Text = "Please select a student to edit."
            Label5.Visible = True
            Return
        End If
        If Not IsValidInput() Then
            Exit Sub
        End If

        Con.Open()
        Dim query = "UPDATE LibrarianTable SET LibrarianName = @LibrarianName,, LibrarianPhone = @LibrarianPhone, LibrarianPassword = @LibrarianPassword WHERE LibrarianId = @LibrarianId"
        Using cmd As New SqlCommand(query, Con)
            cmd.Parameters.AddWithValue("@LibrarianId", LibIdTb.Text)
            cmd.Parameters.AddWithValue("@LibrarianName", LibnameTb.Text)
            cmd.Parameters.AddWithValue("@LibrarianPhone", LibphoneTb.Text)
            cmd.Parameters.AddWithValue("@LibrarianPassword", LibpassTb.Text)
            cmd.ExecuteNonQuery()
        End Using

        Label5.Text = "Librarian Edited"
        Label5.ForeColor = Color.Black
        Con.Close()
        displaylibrarians()
        reset()
    End Sub

    Private Sub librarians_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        displaylibrarians()
        CustomizeDataGridViewHeaders()
        ResizeAndAdjustDataGridView()
        LibpassTb.UseSystemPasswordChar = True
        Label5.Visible = False
    End Sub


    Private Sub LibDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles LibDGV.CellMouseClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim row As DataGridViewRow = LibDGV.Rows(e.RowIndex)
            LibIdTb.Text = row.Cells(0).Value.ToString()
            LibnameTb.Text = row.Cells(1).Value.ToString()
            LibphoneTb.Text = row.Cells(2).Value.ToString()
            LibpassTb.Text = row.Cells(3).Value.ToString()
            key = row.Cells(0).Value.ToString()
        End If
    End Sub

    Private Sub CustomizeDataGridViewHeaders()
        LibDGV.ColumnHeadersDefaultCellStyle.BackColor = Color.MediumSeaGreen
        LibDGV.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        LibDGV.ColumnHeadersDefaultCellStyle.Font = New Font("Microsoft Sans Serif", 14, FontStyle.Bold)
        LibDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        LibDGV.EnableHeadersVisualStyles = False
    End Sub

    Private Sub ResizeAndAdjustDataGridView()
        LibDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        LibDGV.Columns(0).Width = 100
        LibDGV.Columns(1).Width = 200
        LibDGV.Columns(2).Width = 200
        LibDGV.Columns(3).Width = 200
    End Sub

    Private Function IsValidInput() As Boolean
        Dim idRegex As New Regex("^[A-Z0-9]+$")
        Dim nameRegex As New Regex("^[a-zA-Z\s]+$")
        Dim phoneRegex As New Regex("^\d+$")
    End Function

    Private Sub LibnameTb_TextChanged(sender As Object, e As EventArgs) Handles LibnameTb.TextChanged
        Dim nameRegex As New Regex("^[a-zA-Z\s]*$")
        If Not nameRegex.IsMatch(LibnameTb.Text) Then
            LibnameTb.BackColor = Color.LightCoral
        Else
            LibnameTb.BackColor = Color.FloralWhite
        End If
        LibnameTb.Text = StrConv(LibnameTb.Text, VbStrConv.ProperCase)
        LibnameTb.SelectionStart = LibnameTb.Text.Length
    End Sub

    Private Sub LibIdTb_TextChanged(sender As Object, e As EventArgs) Handles LibIdTb.TextChanged
        ' Define the regex pattern for valid input
        Dim idRegex As New Regex("^[A-Z]{1}\d{5}$")
        ' Define the regex pattern for filtering invalid characters
        Dim invalidCharRegex As New Regex("[^A-Za-z0-9]")

        ' Filter out any invalid characters
        If invalidCharRegex.IsMatch(LibIdTb.Text) Then
            LibIdTb.Text = invalidCharRegex.Replace(LibIdTb.Text, "")
            LibIdTb.SelectionStart = LibIdTb.Text.Length
        End If

        ' Ensure the first three characters are uppercase
        If LibIdTb.Text.Length > 3 Then
            Dim firstPart As String = LibIdTb.Text.Substring(0, 1).ToUpper()
            Dim remainingPart As String = LibIdTb.Text.Substring(3)
            LibIdTb.Text = firstPart & remainingPart
            LibIdTb.SelectionStart = LibIdTb.Text.Length
        End If
        If idRegex.IsMatch(LibIdTb.Text) Then
            LibIdTb.BackColor = Color.FloralWhite
        Else
            LibIdTb.BackColor = Color.LightCoral
        End If
    End Sub
    Private Sub LibphoneTb_TextChanged(sender As Object, e As EventArgs) Handles LibphoneTb.TextChanged
        Dim phoneRegex As New Regex("^\d*$")
        If Not phoneRegex.IsMatch(LibphoneTb.Text) Then
            LibphoneTb.BackColor = Color.LightCoral
        Else
            LibphoneTb.BackColor = Color.FloralWhite
        End If
        If LibphoneTb.Text.Length > 10 Then
            LibphoneTb.Text = LibphoneTb.Text.Substring(0, 10)
        End If
        If LibphoneTb.Text.Length < 10 Then
            Label5.Text = "Invalid Phone number."
            Label5.ForeColor = Color.Red
            Label5.Visible = True
        Else
            Label5.Text = ""
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim obj = New mainform
        obj.Show()
        Me.Hide()
    End Sub
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Application.Exit()
        PictureBox3.BackColor = Color.DarkGray
    End Sub
    Private Sub PictureBox3_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox3.MouseEnter
        PictureBox3.BackColor = Color.DarkGray
    End Sub

    Private Sub PictureBox3_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox3.MouseLeave
        PictureBox3.BackColor = Color.MediumSeaGreen  ' Or any other color you want it to revert to
    End Sub

    Private Sub LibnameTb_Click(sender As Object, e As EventArgs) Handles LibnameTb.Click
        Label9.Visible = False
        Label10.Visible = False
        Label11.Visible = False
        Label12.Visible = False
        Label5.Visible = False

    End Sub

    Private Sub LibIdTb_Click(sender As Object, e As EventArgs) Handles LibIdTb.Click
        Label9.Visible = False
        Label10.Visible = False
        Label11.Visible = False
        Label12.Visible = False
        Label5.Visible = False

    End Sub

    Private Sub LibphoneTb_Click(sender As Object, e As EventArgs) Handles LibphoneTb.Click
        Label9.Visible = False
        Label10.Visible = False
        Label11.Visible = False
        Label12.Visible = False
        Label5.Visible = False

    End Sub

    Private Sub LibpassTb_Click(sender As Object, e As EventArgs) Handles LibpassTb.Click
        Label9.Visible = False
        Label10.Visible = False
        Label11.Visible = False
        Label12.Visible = False
        Label5.Visible = False

    End Sub
End Class
