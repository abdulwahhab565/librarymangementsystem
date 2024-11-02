Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Imports System.Drawing

Public Class students

    Dim Con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\Documents\hello.mdf;Integrated Security=True;Connect Timeout=30")
    Dim key As String = ""

    Private Sub displaystudents()
        Dim ds As New DataSet()
        Try
            Con.Open()
            Dim query = "SELECT StudentId, StudentName, StudentDepartment, StudentSemester, StudentPhone FROM StudentTable"
            Dim adapter As New SqlDataAdapter(query, Con)
            Dim builder As New SqlCommandBuilder(adapter)
            adapter.Fill(ds)
            StudentsDGV.DataSource = ds.Tables(0)
        Catch ex As Exception
            MessageBox.Show("An error occurred while displaying students: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Con.Close()
        End Try
    End Sub


    Private Sub displayNewStudents()
        Con.Open()

        ' Check if RegistrationDate column exists
        Dim checkColumnQuery = "IF COL_LENGTH('StudentTable', 'RegistrationDate') IS NOT NULL SELECT 1 ELSE SELECT 0"
        Dim columnCheckCmd As New SqlCommand(checkColumnQuery, Con)
        Dim columnExists As Integer = Convert.ToInt32(columnCheckCmd.ExecuteScalar())

        If columnExists = 0 Then
            MsgBox("RegistrationDate column does not exist in StudentTable.")
            Con.Close()
            Return
        End If

        ' Prepare the query to fetch students registered today
        Dim today As String = DateTime.Now.ToString("yyyy-MM-dd")
        Dim query As String = "SELECT StudentId, StudentName, StudentDepartment, StudentSemester, StudentPhone FROM StudentTable WHERE CAST(RegistrationDate AS DATE) = @today"

        Try
            Dim adapter As New SqlDataAdapter(query, Con)
            adapter.SelectCommand.Parameters.AddWithValue("@today", today)
            Dim ds As New DataSet()
            adapter.Fill(ds)
            StudentsDGV.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox("An error occurred while fetching new students: " & ex.Message)
        End Try

        Con.Close()
    End Sub


    Private Sub reset()
        Label13.Visible = False
        key = ""
        StIdTb.Text = ""
        StnameTb.Text = ""
        StdepartmentTb.Text = ""
        StsmstTb.SelectedIndex = -1
        StphoneTb.Text = ""
    End Sub

    Private Sub saveBtn_Click(sender As Object, e As EventArgs) Handles saveBtn.Click
        Label13.Visible = False
        If StIdTb.Text = "" Then
            Label10.Text = "required"
            Label10.Visible = True
            Label10.BackColor = Color.FloralWhite
        End If
        If StnameTb.Text = "" Then
            Label9.Text = "required"
            Label9.Visible = True
            Label9.BackColor = Color.FloralWhite

        End If

        If StdepartmentTb.Text = "" Then
            Label11.Text = "required"
            Label11.Visible = True
            Label11.BackColor = Color.FloralWhite

        End If

        If StphoneTb.Text = "" Then
            PhoneValidationLbl.Text = "required"
            PhoneValidationLbl.Visible = True
            PhoneValidationLbl.BackColor = Color.FloralWhite

        End If
        If Not IsValidInput() Then
            Exit Sub
        End If

        Try
            Con.Open()

            If key = "" Then
                ' Check if the StudentId already exists
                Dim checkQuery = "SELECT COUNT(*) FROM StudentTable WHERE StudentId = @StudentId"
                Using checkCmd As New SqlCommand(checkQuery, Con)
                    checkCmd.Parameters.AddWithValue("@StudentId", StIdTb.Text)
                    Dim count As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())
                    If count > 0 Then
                        MsgBox("Student ID already exists. Please use a different ID.")
                        Con.Close()
                        Exit Sub
                    End If
                End Using

                ' Insert new student
                Dim query = "INSERT INTO StudentTable (StudentId, StudentName, StudentDepartment, StudentSemester, StudentPhone, RegistrationDate) VALUES (@StudentId, @StudentName, @StudentDepartment, @StudentSemester, @StudentPhone, @RegistrationDate)"
                Using cmd As New SqlCommand(query, Con)
                    cmd.Parameters.AddWithValue("@StudentId", StIdTb.Text)
                    cmd.Parameters.AddWithValue("@StudentName", StnameTb.Text)
                    cmd.Parameters.AddWithValue("@StudentDepartment", StdepartmentTb.Text)
                    cmd.Parameters.AddWithValue("@StudentSemester", StsmstTb.Text)
                    cmd.Parameters.AddWithValue("@StudentPhone", StphoneTb.Text)
                    cmd.Parameters.AddWithValue("@RegistrationDate", DateTime.Now)
                    cmd.ExecuteNonQuery()
                End Using
                MsgBox("Student Saved")
            Else
                ' Update existing student
                Dim query = "UPDATE StudentTable SET StudentName = @StudentName, StudentDepartment = @StudentDepartment, StudentSemester = @StudentSemester, StudentPhone = @StudentPhone WHERE StudentId = @StudentId"
                Using cmd As New SqlCommand(query, Con)
                    cmd.Parameters.AddWithValue("@StudentId", StIdTb.Text)
                    cmd.Parameters.AddWithValue("@StudentName", StnameTb.Text)
                    cmd.Parameters.AddWithValue("@StudentDepartment", StdepartmentTb.Text)
                    cmd.Parameters.AddWithValue("@StudentSemester", StsmstTb.Text)
                    cmd.Parameters.AddWithValue("@StudentPhone", StphoneTb.Text)
                    cmd.ExecuteNonQuery()
                End Using
                MsgBox("Student Updated")
            End If

        Catch ex As SqlException
            MsgBox("An error occurred: " & ex.Message)
        Finally
            Con.Close()
            displaystudents()
            reset()
        End Try
    End Sub


    Private Sub students_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        displaystudents()
        CustomizeDataGridViewHeaders()
        ResizeAndAdjustDataGridView()
        displaystudents()
        btnAddNew.Enabled = False


    End Sub

    Private Sub resetBtn_Click(sender As Object, e As EventArgs) Handles resetBtn.Click
        reset()
    End Sub

    Private Sub StudentsDGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles StudentsDGV.CellContentClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim row As DataGridViewRow = StudentsDGV.Rows(e.RowIndex)
            key = row.Cells(0).Value.ToString()
            StIdTb.Text = row.Cells(0).Value.ToString()
            StnameTb.Text = row.Cells(1).Value.ToString()
            StdepartmentTb.Text = row.Cells(2).Value.ToString()
            StsmstTb.Text = row.Cells(3).Value.ToString()
            StphoneTb.Text = row.Cells(4).Value.ToString()
        End If
    End Sub

    Private Sub editBtn_Click(sender As Object, e As EventArgs) Handles editBtn.Click
        If key = "" Then
            Label13.Text = "Please select a student to edit."
            Label13.Visible = True
            Return
        End If

        If Not IsValidInput() Then
            Exit Sub
        End If

        Con.Open()
        Dim query = "UPDATE StudentTable SET StudentName = @StudentName, StudentDepartment = @StudentDepartment, StudentSemester = @StudentSemester, StudentPhone = @StudentPhone WHERE StudentId = @StudentId"
        Using cmd As New SqlCommand(query, Con)
            cmd.Parameters.AddWithValue("@StudentId", StIdTb.Text)
            cmd.Parameters.AddWithValue("@StudentName", StnameTb.Text)
            cmd.Parameters.AddWithValue("@StudentDepartment", StdepartmentTb.Text)
            cmd.Parameters.AddWithValue("@StudentSemester", StsmstTb.Text)
            cmd.Parameters.AddWithValue("@StudentPhone", StphoneTb.Text)
            cmd.ExecuteNonQuery()
        End Using
        MsgBox("Student Edited")
        Con.Close()
        displaystudents()
        reset()
    End Sub

    Private Sub deleteBtn_Click(sender As Object, e As EventArgs) Handles deleteBtn.Click
        If key = "" Then
            Label13.Text = "Please select a student to delete."
            Label13.Visible = True
            Return
        End If

        Con.Open()
        Dim query = "DELETE FROM StudentTable WHERE StudentId = @StudentId"
        Using cmd As New SqlCommand(query, Con)
            cmd.Parameters.AddWithValue("@StudentId", key)
            cmd.ExecuteNonQuery()
        End Using
        MsgBox("Student Deleted")
        Con.Close()
        displaystudents()
        reset()
    End Sub

    Private Sub CustomizeDataGridViewHeaders()
        StudentsDGV.ColumnHeadersDefaultCellStyle.BackColor = Color.MediumSeaGreen
        StudentsDGV.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        StudentsDGV.ColumnHeadersDefaultCellStyle.Font = New Font("Microsoft Sans Serif", 14, FontStyle.Bold)
        StudentsDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        StudentsDGV.EnableHeadersVisualStyles = False
    End Sub


    Private Sub ResizeAndAdjustDataGridView()
        StudentsDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        StudentsDGV.Columns(0).Width = 120
        StudentsDGV.Columns(1).Width = 400
        StudentsDGV.Columns(2).Width = 400
        StudentsDGV.Columns(3).Width = 200
    End Sub

    Private Function IsValidInput() As Boolean
        Dim idRegex As New Regex("^[A-Z]{3}\d{7}$")
        Dim nameRegex As New Regex("^[A-Z][a-z]*( [A-Z][a-z]*)*$")
        Dim departmentRegex As New Regex("^[A-Z][a-z]*( [A-Z][a-z]*)*$")
        Dim phoneRegex As New Regex("^\d+$")

    End Function
    Private Sub btnShowNew_Click(sender As Object, e As EventArgs) Handles btnShowNew.Click
        ' Enable/Disable Controls
        btnAddNew.Enabled = True
        Label10.Visible = False
        Label11.Visible = False
        Label12.Visible = False
        PhoneValidationLbl.Visible = False
        Label13.Visible = False

        ' Get the current date and calculate the future date if needed
        Dim today As String = DateTime.UtcNow.Date.ToString("yyyy-MM-dd")

        ' Retrieve new students registered today
        Dim newStudentsTable As DataTable = GetStudentsByRegistrationDate(today)

        ' Display new students in the DataGridView
        StudentsDGV.DataSource = newStudentsTable
    End Sub

    Private Function GetStudentsByRegistrationDate(dateTime As String) As DataTable
        Dim dt As New DataTable()
        Try
            Con.Open()
            Dim query As String = "SELECT RStudentId, RStudentName, RStudentDepartment, RStudentSemester, RStudentPhone FROM RStudentTable WHERE CAST(RegistrationDate AS DATE) = @today"
            Dim adapter As New SqlDataAdapter(query, Con)
            adapter.SelectCommand.Parameters.AddWithValue("@today", dateTime)
            adapter.Fill(dt)
        Catch ex As Exception
            MessageBox.Show("An error occurred while fetching new students: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Con.Close()
        End Try
        Return dt
    End Function

    ' Add a new student to the DataGridView

    ' Switch back to showing all students
    Private Sub btnShowAll_Click(sender As Object, e As EventArgs) Handles btnShowAll.Click
        displaystudents()
        Label10.Visible = False
        Label11.Visible = False
        Label12.Visible = False
        PhoneValidationLbl.Visible = False
        Label13.Visible = False

    End Sub
    Public Sub LoadStudents()
        Dim connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\Documents\hello.mdf;Integrated Security=True;Connect Timeout=30"
        Dim query As String = "SELECT RStudentId, RStudentName, RStudentDepartment, RStudentSemester, RStudentPhone FROM RStudentTable"

        Try
            Using con As New SqlConnection(connectionString)
                Using cmd As New SqlCommand(query, con)
                    Dim adapter As New SqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    adapter.Fill(dt)
                    StudentsDGV.DataSource = dt
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while loading students: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub btnAddNew_Click(sender As Object, e As EventArgs) Handles btnAddNew.Click
        Label10.Visible = False
        Label11.Visible = False
        Label12.Visible = False
        PhoneValidationLbl.Visible = False
        Label13.Visible = False

        Dim today As String = DateTime.Now.ToString("yyyy-MM-dd")
        Dim newStudentsTable As DataTable = GetStudentsByRegistrationDate(today)

        If newStudentsTable.Rows.Count > 0 Then
            Try
                ' Add new students to the main list
                AddNewStudentsToAllStudents(newStudentsTable)
                ' Clear new students from the temporary table
                ClearNewStudentsFromDatabase(today)
            Catch ex As Exception
                MessageBox.Show("An error occurred while processing new students: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

        ' Refresh the main student list display
        displaystudents()
    End Sub

    Private Sub ClearNewStudentsFromDatabase(dateTime As String)
        Dim transaction As SqlTransaction = Nothing
        Try
            Con.Open()

            ' Start a transaction
            transaction = Con.BeginTransaction()

            ' Move records to ArchivedStudentTable
            Dim moveQuery As String = "INSERT INTO ArchivedStudentTable (RStudentId, RStudentName, RStudentDepartment, RStudentSemester, RStudentPhone, RStudentPassword, RegistrationDate, ProfileImagePath) " &
                                  "SELECT RStudentId, RStudentName, RStudentDepartment, RStudentSemester, RStudentPhone, RStudentPassword, RegistrationDate, ProfileImagePath FROM RStudentTable " &
                                  "WHERE CAST(RegistrationDate AS DATE) = @today"
            Using moveCmd As New SqlCommand(moveQuery, Con, transaction)
                moveCmd.Parameters.AddWithValue("@today", dateTime)
                moveCmd.ExecuteNonQuery()
            End Using

            ' Delete records from RStudentTable
            Dim deleteQuery As String = "DELETE FROM RStudentTable WHERE CAST(RegistrationDate AS DATE) = @today"
            Using deleteCmd As New SqlCommand(deleteQuery, Con, transaction)
                deleteCmd.Parameters.AddWithValue("@today", dateTime)
                deleteCmd.ExecuteNonQuery()
            End Using

            ' Commit the transaction
            transaction.Commit()

        Catch ex As Exception
            ' Rollback the transaction in case of error
            If Not transaction Is Nothing Then transaction.Rollback()
            MessageBox.Show("An error occurred while clearing new students: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Con.Close()
        End Try
    End Sub



    Private Sub AddNewStudentsToAllStudents(newStudentsTable As DataTable)
        Try
            Con.Open()
            Dim query As String = "INSERT INTO StudentTable (StudentId, StudentName, StudentDepartment, StudentSemester, StudentPhone) VALUES (@StudentId, @StudentName, @StudentDepartment, @StudentSemester, @StudentPhone)"
            For Each row As DataRow In newStudentsTable.Rows
                Using cmd As New SqlCommand(query, Con)
                    cmd.Parameters.AddWithValue("@StudentId", row("RStudentId"))
                    cmd.Parameters.AddWithValue("@StudentName", row("RStudentName"))
                    cmd.Parameters.AddWithValue("@StudentDepartment", row("RStudentDepartment"))
                    cmd.Parameters.AddWithValue("@StudentSemester", row("RStudentSemester"))
                    cmd.Parameters.AddWithValue("@StudentPhone", row("RStudentPhone"))
                    cmd.ExecuteNonQuery()
                End Using
            Next
        Catch ex As Exception
            MessageBox.Show("An error occurred while adding new students to the main list: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Con.Close()
        End Try
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
        PictureBox3.BackColor = Color.MediumSeaGreen
    End Sub

    Private Sub StnameTb_TextChanged(sender As Object, e As EventArgs) Handles StnameTb.TextChanged
        Dim nameRegex As New Regex("^[a-zA-Z\s]*$")
        If Not nameRegex.IsMatch(StnameTb.Text) Then
            StnameTb.BackColor = Color.LightCoral
        Else
            StnameTb.BackColor = Color.FloralWhite
        End If
        StnameTb.Text = StrConv(StnameTb.Text, VbStrConv.ProperCase)
        StnameTb.SelectionStart = StnameTb.Text.Length
    End Sub

    Private Sub StsmstTb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles StsmstTb.SelectedIndexChanged
        Dim phoneRegex As New Regex("^\d*$")
        If Not phoneRegex.IsMatch(StsmstTb.Text) Then
            StsmstTb.BackColor = Color.LightCoral
        Else
            StsmstTb.BackColor = Color.FloralWhite
        End If
        If StsmstTb.Text.Length > 1 Then
            StsmstTb.Text = StsmstTb.Text.Substring(1)
        End If
        If StsmstTb.Text.Length < 0 Then
            StsmstTb.Visible = False

        End If

        Label10.Visible = False
        Label11.Visible = False
        Label12.Visible = False
        PhoneValidationLbl.Visible = False


    End Sub

    Private Sub StphoneTb_TextChanged(sender As Object, e As EventArgs) Handles StphoneTb.TextChanged
        Dim phoneRegex As New Regex("^\d*$")
        If Not phoneRegex.IsMatch(StphoneTb.Text) Then
            StphoneTb.BackColor = Color.LightCoral
        Else
            StphoneTb.BackColor = Color.FloralWhite
        End If
        If StphoneTb.Text.Length > 10 Then
            StphoneTb.Text = StphoneTb.Text.Substring(10)
        End If
        If StphoneTb.Text.Length < 10 Then
            PhoneValidationLbl.Visible = False

            PhoneValidationLbl.Text = "Invalid Phone number."
            PhoneValidationLbl.ForeColor = Color.Red
        Else
            PhoneValidationLbl.Text = ""
        End If
    End Sub

    Private Sub StdepartmentTb_TextChanged(sender As Object, e As EventArgs) Handles StdepartmentTb.TextChanged
        Dim DepartmentRegex As New Regex("^[a-zA-Z\s]*$")
        If Not DepartmentRegex.IsMatch(StdepartmentTb.Text) Then
            StdepartmentTb.BackColor = Color.LightCoral
        Else
            StdepartmentTb.BackColor = Color.FloralWhite
        End If
        StdepartmentTb.Text = StrConv(StdepartmentTb.Text, VbStrConv.ProperCase)
        StdepartmentTb.SelectionStart = StdepartmentTb.Text.Length
    End Sub


    Private Sub StIdTb_TextChanged(sender As Object, e As EventArgs) Handles StIdTb.TextChanged
        ' Define the regex pattern for valid input
        Dim idRegex As New Regex("^[A-Z]{3}\d{7}$")
        ' Define the regex pattern for filtering invalid characters
        Dim invalidCharRegex As New Regex("[^A-Za-z0-9]")

        ' Filter out any invalid characters
        If invalidCharRegex.IsMatch(StIdTb.Text) Then
            StIdTb.Text = invalidCharRegex.Replace(StIdTb.Text, "")
            StIdTb.SelectionStart = StIdTb.Text.Length
        End If

        ' Ensure the first three characters are uppercase
        If StIdTb.Text.Length > 3 Then
            Dim firstPart As String = StIdTb.Text.Substring(0, 3).ToUpper()
            Dim remainingPart As String = StIdTb.Text.Substring(3)
            StIdTb.Text = firstPart & remainingPart
            StIdTb.SelectionStart = StIdTb.Text.Length
        End If

        If idRegex.IsMatch(StIdTb.Text) Then
            StIdTb.BackColor = Color.FloralWhite
        Else
            StIdTb.BackColor = Color.LightCoral
        End If
    End Sub

    Private Sub StnameTb_KeyPress(sender As Object, e As KeyPressEventArgs) Handles StnameTb.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Char.IsControl(e.KeyChar) Then
            e.Handled = False
        End If
    End Sub

    Private Sub StnameTb_Click(sender As Object, e As EventArgs) Handles StnameTb.Click
        Label9.Visible = False
        Label10.Visible = False
        Label11.Visible = False
        Label12.Visible = False
        PhoneValidationLbl.Visible = False
        Label13.Visible = False

    End Sub

    Private Sub StIdTb_Click(sender As Object, e As EventArgs) Handles StIdTb.Click
        Label9.Visible = False
        Label10.Visible = False
        Label11.Visible = False
        Label12.Visible = False
        PhoneValidationLbl.Visible = False
        Label13.Visible = False

    End Sub

    Private Sub StdepartmentTb_Click(sender As Object, e As EventArgs) Handles StdepartmentTb.Click
        Label9.Visible = False
        Label10.Visible = False
        Label11.Visible = False
        Label12.Visible = False
        PhoneValidationLbl.Visible = False
        Label13.Visible = False

    End Sub

    Private Sub StphoneTb_Click(sender As Object, e As EventArgs) Handles StphoneTb.Click
        Label9.Visible = False
        Label10.Visible = False
        Label11.Visible = False
        Label12.Visible = False
        PhoneValidationLbl.Visible = False
        Label13.Visible = False


    End Sub
End Class
