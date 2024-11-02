Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class books
    Dim Con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\Documents\hello.mdf;Integrated Security=True;Connect Timeout=30")
    Dim Key As String = ""

    Private Sub displaybook()
        Con.Open()
        Dim query = "SELECT * FROM BookTable"
        Dim adapter As SqlDataAdapter
        Dim cmd = New SqlCommand(query, Con)
        adapter = New SqlDataAdapter(cmd)
        Dim builder = New SqlCommandBuilder(adapter)
        Dim ds = New DataSet()
        adapter.Fill(ds)
        BooksDGV.DataSource = ds.Tables(0)
        Con.Close()
    End Sub

    Private Sub Reset()
        BookIdTb.Text = ""
        BnameTb.Text = ""
        BauthorTb.Text = ""
        BpublisherTb.Text = ""
        BquantityTb.Text = ""
        Key = 0
    End Sub

    Private Sub SaveBtn_Click_1(sender As Object, e As EventArgs) Handles SaveBtn.Click

        If BnameTb.Text = "" Then
            Label12.Text = "Required"
            Label12.Visible = True
        ElseIf BookIdTb.Text = "" Then
            Label13.Text = "Required"
            Label13.Visible = True
        ElseIf BauthorTb.Text = "" Then
            Label14.Text = "Required"
            Label14.Visible = True
        ElseIf BpublisherTb.Text = "" Then
            Label15.Text = "Required"
            Label15.Visible = True
        ElseIf BquantityTb.Text = "" Then
            Label16.Text = "Required"
            Label16.Visible = True

        End If
        If Label12.Visible Or Label13.Visible Or Label14.Visible Or Label15.Visible Or Label16.Visible Then
            Exit Sub
        End If
        Try
            Con.Open()

            Dim checkQuery = "SELECT * FROM BookTable WHERE BookId = @BookId"
            Using checkCmd As New SqlCommand(checkQuery, Con)
                checkCmd.Parameters.AddWithValue("@BookId", BookIdTb.Text)
                Using reader As SqlDataReader = checkCmd.ExecuteReader()
                    If reader.HasRows Then
                        reader.Read()
                        If reader("BookName").ToString() = BnameTb.Text AndAlso
                           reader("BookAuthor").ToString() = BauthorTb.Text AndAlso
                           reader("BookPublisher").ToString() = BpublisherTb.Text AndAlso
                           reader("BookQuantity").ToString() = BquantityTb.Text Then
                            Label10.Text = "Book details are unchanged. No update made."
                            Label10.ForeColor = Color.Red
                            Con.Close()
                            Return
                        Else
                            Con.Close()
                            Con.Open()
                            Dim query = "UPDATE BookTable SET BookName=@BookName, BookAuthor=@BookAuthor, BookPublisher=@BookPublisher, BookQuantity=@BookQuantity WHERE BookId=@BookId"
                            Using cmd As New SqlCommand(query, Con)
                                cmd.Parameters.AddWithValue("@BookId", BookIdTb.Text)
                                cmd.Parameters.AddWithValue("@BookName", BnameTb.Text)
                                cmd.Parameters.AddWithValue("@BookAuthor", BauthorTb.Text)
                                cmd.Parameters.AddWithValue("@BookPublisher", BpublisherTb.Text)
                                cmd.Parameters.AddWithValue("@BookQuantity", BquantityTb.Text)

                                cmd.ExecuteNonQuery()
                            End Using
                            Label10.Text = "Book Updated"
                            Label10.ForeColor = Color.Black
                            Con.Close()
                            displaybook()
                            Reset()
                            Return
                        End If
                    End If
                End Using
            End Using
            Dim insertQuery = "INSERT INTO BookTable (BookId, BookName, BookAuthor, BookPublisher, BookQuantity) VALUES (@BookId, @BookName, @BookAuthor, @BookPublisher, @BookQuantity)"
            Using cmd As New SqlCommand(insertQuery, Con)
                cmd.Parameters.AddWithValue("@BookId", BookIdTb.Text)
                cmd.Parameters.AddWithValue("@BookName", BnameTb.Text)
                cmd.Parameters.AddWithValue("@BookAuthor", BauthorTb.Text)
                cmd.Parameters.AddWithValue("@BookPublisher", BpublisherTb.Text)
                cmd.Parameters.AddWithValue("@BookQuantity", BquantityTb.Text)
                cmd.ExecuteNonQuery()
            End Using
            Label10.Text = "Book Saved"
            Label10.ForeColor = Color.Black
            Con.Close()
            displaybook()
            Reset()
        Catch ex As Exception
            Label10.Text = "Invalid Input"
            Label10.ForeColor = Color.Red
        Finally
            If Con.State = ConnectionState.Open Then
                Con.Close()
            End If
        End Try
    End Sub

    Private Sub EditBtn_Click_1(sender As Object, e As EventArgs) Handles EditBtn.Click
        If BookIdTb.Text = "" Or BnameTb.Text = "" Or BauthorTb.Text = "" Or BpublisherTb.Text = "" Or BquantityTb.Text = "" Then
            Label10.Text = "Missing Information"
        Else
            Con.Open()
            Dim query = "UPDATE BookTable SET BookName=@BookName, BookAuthor=@BookAuthor, BookPublisher=@BookPublisher, BookQuantity=@BookQuantity WHERE BookId=@BookId"
            Using cmd As New SqlCommand(query, Con)
                cmd.Parameters.AddWithValue("@BookId", BookIdTb.Text)
                cmd.Parameters.AddWithValue("@BookName", BnameTb.Text)
                cmd.Parameters.AddWithValue("@BookAuthor", BauthorTb.Text)
                cmd.Parameters.AddWithValue("@BookPublisher", BpublisherTb.Text)
                cmd.Parameters.AddWithValue("@BookQuantity", BquantityTb.Text)
                cmd.ExecuteNonQuery()
            End Using
            Label10.Text = "Book Edited"
            Label10.ForeColor = Color.Red
            Con.Close()
            displaybook()
            Reset()
        End If

    End Sub

    Private Sub DeleteBtn_Click_1(sender As Object, e As EventArgs) Handles DeleteBtn.Click
        If Key = "" Then
            Label10.Text = "Missing Information"
            Label10.ForeColor = Color.Red
        Else
            Con.Open()
            Dim query = "DELETE FROM BookTable WHERE BookId=@BookId"
            Using cmd As New SqlCommand(query, Con)
                cmd.Parameters.AddWithValue("@BookId", Key)
                cmd.ExecuteNonQuery()
            End Using
            Label10.Text = "Book Deleted"
            Label10.ForeColor = Color.Red
            Con.Close()
            displaybook()
            Reset()
        End If
    End Sub

    Private Sub books_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        displaybook()
        CustomizeDataGridViewHeaders()
        ResizeAndAdjustDataGridView()
    End Sub

    Private Sub CustomizeDataGridViewHeaders()
        BooksDGV.ColumnHeadersDefaultCellStyle.BackColor = Color.MediumSeaGreen
        BooksDGV.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        BooksDGV.ColumnHeadersDefaultCellStyle.Font = New Font("Microsoft Sans Serif", 14, FontStyle.Bold)
        BooksDGV.EnableHeadersVisualStyles = False
    End Sub

    Private Sub ResizeAndAdjustDataGridView()
        BooksDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        BooksDGV.Columns(0).Width = 50
        BooksDGV.Columns(1).Width = 100
        BooksDGV.Columns(2).Width = 100
        BooksDGV.Columns(3).Width = 80
        BooksDGV.Columns(4).Width = 200
    End Sub

    Private Sub BooksDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles BooksDGV.CellMouseClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim row As DataGridViewRow = BooksDGV.Rows(e.RowIndex)
            BookIdTb.Text = row.Cells(0).Value.ToString()
            BnameTb.Text = row.Cells(1).Value.ToString()
            BauthorTb.Text = row.Cells(2).Value.ToString()
            BpublisherTb.Text = row.Cells(3).Value.ToString()
            BquantityTb.Text = row.Cells(4).Value.ToString()
            Key = row.Cells(0).Value.ToString()
        End If
    End Sub

    Private Sub BnameTb_TextChanged(sender As Object, e As EventArgs) Handles BnameTb.TextChanged
        ' Define the regex pattern for valid author names (letters, spaces, and symbols, but no numbers)
        Dim AuthorRegex As New Regex("^[a-zA-Z0-9\s]*$")

        ' Check if the input matches the regex pattern
        If Not AuthorRegex.IsMatch(BnameTb.Text) Then
            ' If it doesn't match, set the background color to LightCoral (indicates invalid input)
            BnameTb.BackColor = Color.LightCoral
        Else
            ' If it matches, set the background color to FloralWhite (indicates valid input)
            BnameTb.BackColor = Color.FloralWhite
        End If

        ' Convert the input text to Proper Case (capitalizing the first letter of each word)
        BnameTb.Text = StrConv(BnameTb.Text, VbStrConv.ProperCase)

        ' Set the cursor position to the end of the text
        BnameTb.SelectionStart = BnameTb.Text.Length
    End Sub



    Private Sub BookIdTb_TextChanged(sender As Object, e As EventArgs) Handles BookIdTb.TextChanged
        Dim BookidRegex As New Regex("^[A-Z0-9]*$")
        If Not BookidRegex.IsMatch(BookIdTb.Text) Then
            BookIdTb.BackColor = Color.LightCoral

        Else
            BookIdTb.BackColor = Color.FloralWhite
        End If

        BookIdTb.Text = StrConv(BookIdTb.Text, VbStrConv.Uppercase)
            BookIdTb.SelectionStart = BookIdTb.Text.Length


    End Sub
    Private Sub BquantityTb_TextChanged(sender As Object, e As EventArgs) Handles BquantityTb.TextChanged
        Dim phoneRegex As New Regex("^\d*$")
        If Not phoneRegex.IsMatch(BquantityTb.Text) Then
            BquantityTb.BackColor = Color.LightCoral
        Else
            BquantityTb.BackColor = Color.FloralWhite
        End If
        If BquantityTb.Text.Length > 10 Then
            BquantityTb.Text = BquantityTb.Text.Substring(10)
        End If
    End Sub

    Private Sub ResetBtn_Click(sender As Object, e As EventArgs) Handles ResetBtn.Click
        Reset()
    End Sub

    Private Function TitleCase(input As String) As String
        Dim result As String = ""
        Dim words() As String = input.Split(" "c)
        For Each word As String In words
            If word.Length > 0 Then
                result &= Char.ToUpper(word(0)) & word.Substring(1).ToLower() & " "
            End If
        Next
        Return result.Trim()
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim obj = New mainform
        obj.Show()
        Me.Hide()
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

    Private Sub BnameTb_Click(sender As Object, e As EventArgs) Handles BnameTb.Click
        Label12.Visible = False
    End Sub

    Private Sub BookIdTb_Click(sender As Object, e As EventArgs) Handles BookIdTb.Click
        Label13.Visible = False
    End Sub

    Private Sub BauthorTb_Click(sender As Object, e As EventArgs) Handles BauthorTb.Click
        Label14.Visible = False
    End Sub

    Private Sub BpublisherTb_Click(sender As Object, e As EventArgs) Handles BpublisherTb.Click
        Label15.Visible = False
    End Sub
    Private Sub BquantityTb_Click(sender As Object, e As EventArgs) Handles BquantityTb.Click
        Label16.Visible = False
    End Sub

    Private Sub BauthorTb_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BauthorTb.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Char.IsControl(e.KeyChar) Then
            e.Handled = False
        End If
    End Sub

    Private Sub BpublisherTb_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BpublisherTb.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Char.IsControl(e.KeyChar) Then
            e.Handled = False
        End If
    End Sub

    Private Sub BpublisherTb_TextChanged(sender As Object, e As EventArgs) Handles BpublisherTb.TextChanged
        ' Define the regex pattern for valid author names (letters, spaces, and symbols, but no numbers)
        Dim AuthorRegex As New Regex("^[^\d]*$")

        ' Check if the input matches the regex pattern
        If Not AuthorRegex.IsMatch(BpublisherTb.Text) Then
            ' If it doesn't match, set the background color to LightCoral (indicates invalid input)
            BpublisherTb.BackColor = Color.LightCoral
        Else
            ' If it matches, set the background color to FloralWhite (indicates valid input)
            BpublisherTb.BackColor = Color.FloralWhite
        End If

        ' Convert the input text to Proper Case (capitalizing the first letter of each word)
        BpublisherTb.Text = StrConv(BpublisherTb.Text, VbStrConv.ProperCase)

        ' Set the cursor position to the end of the text
        BpublisherTb.SelectionStart = BpublisherTb.Text.Length
    End Sub

    Private Sub BauthorTb_TextChanged(sender As Object, e As EventArgs) Handles BauthorTb.TextChanged
        ' Define the regex pattern for valid author names (letters, spaces, and symbols, but no numbers)
        Dim AuthorRegex As New Regex("^[^\d]*$")

        ' Check if the input matches the regex pattern
        If Not AuthorRegex.IsMatch(BauthorTb.Text) Then
            ' If it doesn't match, set the background color to LightCoral (indicates invalid input)
            BauthorTb.BackColor = Color.LightCoral
        Else
            ' If it matches, set the background color to FloralWhite (indicates valid input)
            BauthorTb.BackColor = Color.FloralWhite
        End If

        ' Convert the input text to Proper Case (capitalizing the first letter of each word)
        BauthorTb.Text = StrConv(BauthorTb.Text, VbStrConv.ProperCase)

        ' Set the cursor position to the end of the text
        BauthorTb.SelectionStart = BauthorTb.Text.Length
    End Sub
End Class
