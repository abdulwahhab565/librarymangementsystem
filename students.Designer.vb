<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class students
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(students))
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.StsmstTb = New System.Windows.Forms.ComboBox()
        Me.saveBtn = New System.Windows.Forms.Button()
        Me.editBtn = New System.Windows.Forms.Button()
        Me.deleteBtn = New System.Windows.Forms.Button()
        Me.resetBtn = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PhoneValidationLbl = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.StIdTb = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.StphoneTb = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.StnameTb = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.StdepartmentTb = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnShowAll = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.StudentsDGV = New System.Windows.Forms.DataGridView()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.btnShowNew = New System.Windows.Forms.Button()
        Me.btnShowTodayRegistrations = New System.Windows.Forms.Button()
        Me.btnAddNew = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.StudentsDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel1.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1732, 93)
        Me.Panel1.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel3.Controls.Add(Me.PictureBox3)
        Me.Panel3.Location = New System.Drawing.Point(1532, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(200, 37)
        Me.Panel3.TabIndex = 42
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.PictureBox3.Dock = System.Windows.Forms.DockStyle.Right
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(160, 0)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(40, 37)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox3.TabIndex = 18
        Me.PictureBox3.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(80, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 25)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Students"
        '
        'PictureBox2
        '
        Me.PictureBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(3, 2)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(80, 84)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(19, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 20)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(781, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 20)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Department"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(1296, 71)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 20)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Semester"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(1442, 71)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 20)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Phone"
        '
        'StsmstTb
        '
        Me.StsmstTb.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.StsmstTb.FormattingEnabled = True
        Me.StsmstTb.Items.AddRange(New Object() {"1", "2"})
        Me.StsmstTb.Location = New System.Drawing.Point(1306, 103)
        Me.StsmstTb.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.StsmstTb.Name = "StsmstTb"
        Me.StsmstTb.Size = New System.Drawing.Size(61, 25)
        Me.StsmstTb.TabIndex = 12
        '
        'saveBtn
        '
        Me.saveBtn.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.saveBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saveBtn.ForeColor = System.Drawing.Color.White
        Me.saveBtn.Location = New System.Drawing.Point(277, 215)
        Me.saveBtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.saveBtn.Name = "saveBtn"
        Me.saveBtn.Size = New System.Drawing.Size(132, 46)
        Me.saveBtn.TabIndex = 13
        Me.saveBtn.Text = "Save"
        Me.saveBtn.UseVisualStyleBackColor = False
        '
        'editBtn
        '
        Me.editBtn.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.editBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.editBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.editBtn.ForeColor = System.Drawing.Color.White
        Me.editBtn.Location = New System.Drawing.Point(600, 215)
        Me.editBtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.editBtn.Name = "editBtn"
        Me.editBtn.Size = New System.Drawing.Size(132, 46)
        Me.editBtn.TabIndex = 14
        Me.editBtn.Text = "Edit"
        Me.editBtn.UseVisualStyleBackColor = False
        '
        'deleteBtn
        '
        Me.deleteBtn.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.deleteBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deleteBtn.ForeColor = System.Drawing.Color.White
        Me.deleteBtn.Location = New System.Drawing.Point(933, 215)
        Me.deleteBtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.deleteBtn.Name = "deleteBtn"
        Me.deleteBtn.Size = New System.Drawing.Size(132, 46)
        Me.deleteBtn.TabIndex = 15
        Me.deleteBtn.Text = "Delete"
        Me.deleteBtn.UseVisualStyleBackColor = False
        '
        'resetBtn
        '
        Me.resetBtn.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.resetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.resetBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.resetBtn.ForeColor = System.Drawing.Color.White
        Me.resetBtn.Location = New System.Drawing.Point(1250, 215)
        Me.resetBtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.resetBtn.Name = "resetBtn"
        Me.resetBtn.Size = New System.Drawing.Size(132, 46)
        Me.resetBtn.TabIndex = 16
        Me.resetBtn.Text = "Reset"
        Me.resetBtn.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.PhoneValidationLbl)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.StIdTb)
        Me.Panel2.Controls.Add(Me.StphoneTb)
        Me.Panel2.Controls.Add(Me.StnameTb)
        Me.Panel2.Controls.Add(Me.StdepartmentTb)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.resetBtn)
        Me.Panel2.Controls.Add(Me.deleteBtn)
        Me.Panel2.Controls.Add(Me.editBtn)
        Me.Panel2.Controls.Add(Me.saveBtn)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.StsmstTb)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Location = New System.Drawing.Point(38, 158)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1666, 289)
        Me.Panel2.TabIndex = 17
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Red
        Me.Label13.Location = New System.Drawing.Point(597, 161)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(0, 18)
        Me.Label13.TabIndex = 47
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(68, 109)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(0, 17)
        Me.Label9.TabIndex = 46
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(1173, 107)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(0, 16)
        Me.Label12.TabIndex = 45
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(779, 109)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(0, 17)
        Me.Label11.TabIndex = 44
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(379, 109)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(0, 17)
        Me.Label10.TabIndex = 43
        '
        'PhoneValidationLbl
        '
        Me.PhoneValidationLbl.AutoSize = True
        Me.PhoneValidationLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PhoneValidationLbl.ForeColor = System.Drawing.Color.Red
        Me.PhoneValidationLbl.Location = New System.Drawing.Point(1481, 107)
        Me.PhoneValidationLbl.Name = "PhoneValidationLbl"
        Me.PhoneValidationLbl.Size = New System.Drawing.Size(0, 17)
        Me.PhoneValidationLbl.TabIndex = 41
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(438, 71)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(94, 20)
        Me.Label8.TabIndex = 40
        Me.Label8.Text = "Student Id"
        '
        'StIdTb
        '
        Me.StIdTb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.StIdTb.Depth = 0
        Me.StIdTb.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StIdTb.ForeColor = System.Drawing.Color.Navy
        Me.StIdTb.Hint = "Enter Student Name"
        Me.StIdTb.Location = New System.Drawing.Point(442, 107)
        Me.StIdTb.MaxLength = 32767
        Me.StIdTb.MouseState = MaterialSkin.MouseState.HOVER
        Me.StIdTb.Name = "StIdTb"
        Me.StIdTb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.StIdTb.SelectedText = ""
        Me.StIdTb.SelectionLength = 0
        Me.StIdTb.SelectionStart = 0
        Me.StIdTb.Size = New System.Drawing.Size(272, 23)
        Me.StIdTb.TabIndex = 39
        Me.StIdTb.TabStop = False
        Me.StIdTb.UseSystemPasswordChar = False
        '
        'StphoneTb
        '
        Me.StphoneTb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.StphoneTb.Depth = 0
        Me.StphoneTb.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StphoneTb.ForeColor = System.Drawing.Color.Navy
        Me.StphoneTb.Hint = "Enter  Phone Number"
        Me.StphoneTb.Location = New System.Drawing.Point(1446, 107)
        Me.StphoneTb.MaxLength = 32767
        Me.StphoneTb.MouseState = MaterialSkin.MouseState.HOVER
        Me.StphoneTb.Name = "StphoneTb"
        Me.StphoneTb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.StphoneTb.SelectedText = ""
        Me.StphoneTb.SelectionLength = 0
        Me.StphoneTb.SelectionStart = 0
        Me.StphoneTb.Size = New System.Drawing.Size(193, 23)
        Me.StphoneTb.TabIndex = 38
        Me.StphoneTb.TabStop = False
        Me.StphoneTb.UseSystemPasswordChar = False
        '
        'StnameTb
        '
        Me.StnameTb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.StnameTb.Depth = 0
        Me.StnameTb.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StnameTb.ForeColor = System.Drawing.Color.Navy
        Me.StnameTb.Hint = "Enter Student Name"
        Me.StnameTb.Location = New System.Drawing.Point(23, 107)
        Me.StnameTb.MaxLength = 32767
        Me.StnameTb.MouseState = MaterialSkin.MouseState.HOVER
        Me.StnameTb.Name = "StnameTb"
        Me.StnameTb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.StnameTb.SelectedText = ""
        Me.StnameTb.SelectionLength = 0
        Me.StnameTb.SelectionStart = 0
        Me.StnameTb.Size = New System.Drawing.Size(364, 23)
        Me.StnameTb.TabIndex = 37
        Me.StnameTb.TabStop = False
        Me.StnameTb.UseSystemPasswordChar = False
        '
        'StdepartmentTb
        '
        Me.StdepartmentTb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.StdepartmentTb.Depth = 0
        Me.StdepartmentTb.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StdepartmentTb.ForeColor = System.Drawing.Color.Navy
        Me.StdepartmentTb.Hint = "Enter  Department"
        Me.StdepartmentTb.Location = New System.Drawing.Point(785, 107)
        Me.StdepartmentTb.MaxLength = 32767
        Me.StdepartmentTb.MouseState = MaterialSkin.MouseState.HOVER
        Me.StdepartmentTb.Name = "StdepartmentTb"
        Me.StdepartmentTb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.StdepartmentTb.SelectedText = ""
        Me.StdepartmentTb.SelectionLength = 0
        Me.StdepartmentTb.SelectionStart = 0
        Me.StdepartmentTb.Size = New System.Drawing.Size(447, 23)
        Me.StdepartmentTb.TabIndex = 36
        Me.StdepartmentTb.TabStop = False
        Me.StdepartmentTb.UseSystemPasswordChar = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(753, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(148, 20)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Students Details "
        '
        'btnShowAll
        '
        Me.btnShowAll.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnShowAll.FlatAppearance.BorderColor = System.Drawing.Color.MediumSeaGreen
        Me.btnShowAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnShowAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowAll.ForeColor = System.Drawing.Color.White
        Me.btnShowAll.Location = New System.Drawing.Point(419, 809)
        Me.btnShowAll.Name = "btnShowAll"
        Me.btnShowAll.Size = New System.Drawing.Size(143, 46)
        Me.btnShowAll.TabIndex = 42
        Me.btnShowAll.Text = "View All Student"
        Me.btnShowAll.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(787, 449)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(148, 20)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Students Details "
        '
        'StudentsDGV
        '
        Me.StudentsDGV.AllowUserToResizeColumns = False
        Me.StudentsDGV.AllowUserToResizeRows = False
        Me.StudentsDGV.BackgroundColor = System.Drawing.Color.FloralWhite
        Me.StudentsDGV.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.StudentsDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Navy
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Lavender
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.StudentsDGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.StudentsDGV.ColumnHeadersHeight = 30
        Me.StudentsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FloralWhite
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FloralWhite
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.StudentsDGV.DefaultCellStyle = DataGridViewCellStyle5
        Me.StudentsDGV.GridColor = System.Drawing.Color.Gainsboro
        Me.StudentsDGV.Location = New System.Drawing.Point(204, 504)
        Me.StudentsDGV.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.StudentsDGV.MaximumSize = New System.Drawing.Size(1283, 279)
        Me.StudentsDGV.Name = "StudentsDGV"
        Me.StudentsDGV.ReadOnly = True
        Me.StudentsDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.Navy
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.StudentsDGV.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.StudentsDGV.RowHeadersVisible = False
        Me.StudentsDGV.RowHeadersWidth = 51
        Me.StudentsDGV.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.StudentsDGV.RowTemplate.Height = 24
        Me.StudentsDGV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.StudentsDGV.Size = New System.Drawing.Size(1283, 279)
        Me.StudentsDGV.TabIndex = 22
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(663, 809)
        Me.Button5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(132, 46)
        Me.Button5.TabIndex = 23
        Me.Button5.Text = "Back"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'btnShowNew
        '
        Me.btnShowNew.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnShowNew.FlatAppearance.BorderColor = System.Drawing.Color.MediumSeaGreen
        Me.btnShowNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnShowNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowNew.ForeColor = System.Drawing.Color.White
        Me.btnShowNew.Location = New System.Drawing.Point(1117, 809)
        Me.btnShowNew.Name = "btnShowNew"
        Me.btnShowNew.Size = New System.Drawing.Size(149, 46)
        Me.btnShowNew.TabIndex = 24
        Me.btnShowNew.Text = "View New Students"
        Me.btnShowNew.UseVisualStyleBackColor = False
        '
        'btnShowTodayRegistrations
        '
        Me.btnShowTodayRegistrations.Location = New System.Drawing.Point(758, 459)
        Me.btnShowTodayRegistrations.Name = "btnShowTodayRegistrations"
        Me.btnShowTodayRegistrations.Size = New System.Drawing.Size(8, 9)
        Me.btnShowTodayRegistrations.TabIndex = 25
        Me.btnShowTodayRegistrations.Text = "Button2"
        Me.btnShowTodayRegistrations.UseVisualStyleBackColor = True
        '
        'btnAddNew
        '
        Me.btnAddNew.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddNew.ForeColor = System.Drawing.Color.White
        Me.btnAddNew.Location = New System.Drawing.Point(884, 809)
        Me.btnAddNew.Name = "btnAddNew"
        Me.btnAddNew.Size = New System.Drawing.Size(132, 46)
        Me.btnAddNew.TabIndex = 43
        Me.btnAddNew.Text = "Add--->>"
        Me.btnAddNew.UseVisualStyleBackColor = False
        '
        'students
        '
        Me.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FloralWhite
        Me.ClientSize = New System.Drawing.Size(1732, 865)
        Me.Controls.Add(Me.btnAddNew)
        Me.Controls.Add(Me.btnShowAll)
        Me.Controls.Add(Me.btnShowTodayRegistrations)
        Me.Controls.Add(Me.btnShowNew)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.StudentsDGV)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MinimumSize = New System.Drawing.Size(1421, 788)
        Me.Name = "students"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "students"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.StudentsDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents StsmstTb As ComboBox
    Friend WithEvents saveBtn As Button
    Friend WithEvents editBtn As Button
    Friend WithEvents deleteBtn As Button
    Friend WithEvents resetBtn As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents StudentsDGV As DataGridView
    Friend WithEvents Button5 As Button
    Public WithEvents StnameTb As MaterialSkin.Controls.MaterialSingleLineTextField
    Public WithEvents StdepartmentTb As MaterialSkin.Controls.MaterialSingleLineTextField
    Public WithEvents StphoneTb As MaterialSkin.Controls.MaterialSingleLineTextField
    Public WithEvents StIdTb As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Label8 As Label
    Friend WithEvents PhoneValidationLbl As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnShowNew As Button
    Friend WithEvents btnShowTodayRegistrations As Button
    Friend WithEvents btnShowAll As Button
    Friend WithEvents btnAddNew As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label13 As Label
End Class
