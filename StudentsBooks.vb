Imports System.Data.SqlClient

Public Class StudentsBooks
    Dim Con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\Documents\hello.mdf;Integrated Security=True;Connect Timeout=30")
    Public loggedInStudentId As String
    Private Sub StudentsBooks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayBooks()
        CustomizeDataGridViewHeaders(StudentBooksDGV)
        ResizeAndAdjustDataGridView(StudentBooksDGV)
    End Sub

    Private Sub DisplayBooks()
        Con.Open()
        Dim query = "SELECT * FROM BookTable"
        Dim adapter As SqlDataAdapter
        Dim cmd = New SqlCommand(query, Con)
        adapter = New SqlDataAdapter(cmd)
        Dim builder = New SqlCommandBuilder(adapter)
        Dim ds = New DataSet()
        adapter.Fill(ds)
        StudentBooksDGV.DataSource = ds.Tables(0)
        Con.Close()
    End Sub

    Private Sub CustomizeDataGridViewHeaders(dgv As DataGridView)
        dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.MediumSeaGreen
        dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        dgv.ColumnHeadersDefaultCellStyle.Font = New Font("Microsoft Sans Serif", 14, FontStyle.Bold)
        dgv.EnableHeadersVisualStyles = False
    End Sub

    Private Sub ResizeAndAdjustDataGridView(dgv As DataGridView)
        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgv.Columns(0).Width = 50
        dgv.Columns(1).Width = 100
        dgv.Columns(2).Width = 100
        dgv.Columns(3).Width = 80
        dgv.Columns(4).Width = 200
    End Sub

    Private Sub SignOutBtn_Click(sender As Object, e As EventArgs) Handles SignOutBtn.Click
        ' Redirect to the main registration form
        Dim mainForm As New mainform()
        mainForm.Show()
        Me.Close()
    End Sub

    Private Sub IssueBookBtn_Click(sender As Object, e As EventArgs) Handles IssueBookBtn.Click
        ' Redirect to the book issue form
        Dim issueForm As New IssueStudent()
        issueForm.Show()
        Me.Close()
    End Sub
End Class
