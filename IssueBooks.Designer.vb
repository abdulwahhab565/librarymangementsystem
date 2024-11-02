<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class IssueBooks
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IssueBooks))
        Me.Label7 = New System.Windows.Forms.Label()
        Me.IssueDGV = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.submitBtn = New System.Windows.Forms.Button()
        Me.editBtn = New System.Windows.Forms.Button()
        Me.resetBtn = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.RtIssueDateTb = New System.Windows.Forms.DateTimePicker()
        Me.RtStNameTb = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.RtBookNameTb = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.RtStIdTb = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.StdepartmentTb = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.RtBookIdTb = New MaterialSkin.Controls.MaterialSingleLineTextField()
        CType(Me.IssueDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(790, 448)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 20)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Book Issue "
        '
        'IssueDGV
        '
        Me.IssueDGV.AllowUserToResizeColumns = False
        Me.IssueDGV.AllowUserToResizeRows = False
        Me.IssueDGV.BackgroundColor = System.Drawing.Color.FloralWhite
        Me.IssueDGV.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.IssueDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Navy
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Lavender
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.IssueDGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.IssueDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FloralWhite
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FloralWhite
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.IssueDGV.DefaultCellStyle = DataGridViewCellStyle2
        Me.IssueDGV.GridColor = System.Drawing.Color.Gainsboro
        Me.IssueDGV.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.IssueDGV.Location = New System.Drawing.Point(220, 492)
        Me.IssueDGV.Margin = New System.Windows.Forms.Padding(2)
        Me.IssueDGV.MaximumSize = New System.Drawing.Size(1283, 279)
        Me.IssueDGV.MinimumSize = New System.Drawing.Size(1283, 279)
        Me.IssueDGV.Name = "IssueDGV"
        Me.IssueDGV.ReadOnly = True
        Me.IssueDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Navy
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Navy
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Navy
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.IssueDGV.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.IssueDGV.RowHeadersVisible = False
        Me.IssueDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader
        Me.IssueDGV.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IssueDGV.RowTemplate.Height = 24
        Me.IssueDGV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.IssueDGV.Size = New System.Drawing.Size(1283, 279)
        Me.IssueDGV.TabIndex = 25
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(782, 809)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(132, 45)
        Me.Button1.TabIndex = 27
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel1.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1732, 97)
        Me.Panel1.TabIndex = 28
        '
        'Panel3
        '
        Me.Panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Location = New System.Drawing.Point(1532, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(200, 37)
        Me.Panel3.TabIndex = 43
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(160, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(40, 37)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(98, 34)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(119, 25)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Issue Book"
        '
        'PictureBox2
        '
        Me.PictureBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(12, 4)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(80, 84)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(1427, 73)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 20)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Issue Date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(3, 73)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 20)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Student Id "
        '
        'submitBtn
        '
        Me.submitBtn.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.submitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.submitBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.submitBtn.ForeColor = System.Drawing.Color.White
        Me.submitBtn.Location = New System.Drawing.Point(712, 214)
        Me.submitBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.submitBtn.Name = "submitBtn"
        Me.submitBtn.Size = New System.Drawing.Size(132, 45)
        Me.submitBtn.TabIndex = 13
        Me.submitBtn.Text = "Submit"
        Me.submitBtn.UseVisualStyleBackColor = False
        '
        'editBtn
        '
        Me.editBtn.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.editBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.editBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.editBtn.ForeColor = System.Drawing.Color.White
        Me.editBtn.Location = New System.Drawing.Point(343, 214)
        Me.editBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.editBtn.Name = "editBtn"
        Me.editBtn.Size = New System.Drawing.Size(132, 45)
        Me.editBtn.TabIndex = 14
        Me.editBtn.Text = "Edit"
        Me.editBtn.UseVisualStyleBackColor = False
        '
        'resetBtn
        '
        Me.resetBtn.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.resetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.resetBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.resetBtn.ForeColor = System.Drawing.Color.White
        Me.resetBtn.Location = New System.Drawing.Point(1131, 214)
        Me.resetBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.resetBtn.Name = "resetBtn"
        Me.resetBtn.Size = New System.Drawing.Size(132, 45)
        Me.resetBtn.TabIndex = 16
        Me.resetBtn.Text = "Reset"
        Me.resetBtn.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(828, 73)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 20)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Book Name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(691, 0)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(169, 20)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "IssueBooks Details "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(251, 73)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 20)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(1153, 73)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 20)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Book Id"
        '
        'RtIssueDateTb
        '
        Me.RtIssueDateTb.Enabled = False
        Me.RtIssueDateTb.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RtIssueDateTb.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.RtIssueDateTb.Location = New System.Drawing.Point(1431, 109)
        Me.RtIssueDateTb.Margin = New System.Windows.Forms.Padding(2)
        Me.RtIssueDateTb.Name = "RtIssueDateTb"
        Me.RtIssueDateTb.Size = New System.Drawing.Size(133, 26)
        Me.RtIssueDateTb.TabIndex = 24
        '
        'RtStNameTb
        '
        Me.RtStNameTb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.RtStNameTb.Depth = 0
        Me.RtStNameTb.Enabled = False
        Me.RtStNameTb.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RtStNameTb.ForeColor = System.Drawing.Color.Navy
        Me.RtStNameTb.Hint = ""
        Me.RtStNameTb.Location = New System.Drawing.Point(255, 112)
        Me.RtStNameTb.MaxLength = 32767
        Me.RtStNameTb.MouseState = MaterialSkin.MouseState.HOVER
        Me.RtStNameTb.Name = "RtStNameTb"
        Me.RtStNameTb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.RtStNameTb.SelectedText = ""
        Me.RtStNameTb.SelectionLength = 0
        Me.RtStNameTb.SelectionStart = 0
        Me.RtStNameTb.Size = New System.Drawing.Size(268, 23)
        Me.RtStNameTb.TabIndex = 39
        Me.RtStNameTb.TabStop = False
        Me.RtStNameTb.UseSystemPasswordChar = False
        '
        'RtBookNameTb
        '
        Me.RtBookNameTb.BackColor = System.Drawing.Color.FloralWhite
        Me.RtBookNameTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RtBookNameTb.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RtBookNameTb.Location = New System.Drawing.Point(819, 109)
        Me.RtBookNameTb.Name = "RtBookNameTb"
        Me.RtBookNameTb.Size = New System.Drawing.Size(272, 26)
        Me.RtBookNameTb.TabIndex = 42
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FloralWhite
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.RtStIdTb)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.StdepartmentTb)
        Me.Panel2.Controls.Add(Me.RtBookIdTb)
        Me.Panel2.Controls.Add(Me.RtBookNameTb)
        Me.Panel2.Controls.Add(Me.RtStNameTb)
        Me.Panel2.Controls.Add(Me.RtIssueDateTb)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.resetBtn)
        Me.Panel2.Controls.Add(Me.editBtn)
        Me.Panel2.Controls.Add(Me.submitBtn)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(70, 137)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1592, 289)
        Me.Panel2.TabIndex = 20
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(938, 114)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(0, 17)
        Me.Label11.TabIndex = 52
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(81, 114)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(0, 17)
        Me.Label10.TabIndex = 51
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(751, 169)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(0, 17)
        Me.Label9.TabIndex = 50
        '
        'RtStIdTb
        '
        Me.RtStIdTb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.RtStIdTb.Depth = 0
        Me.RtStIdTb.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RtStIdTb.ForeColor = System.Drawing.Color.Navy
        Me.RtStIdTb.Hint = ""
        Me.RtStIdTb.Location = New System.Drawing.Point(7, 112)
        Me.RtStIdTb.MaxLength = 32767
        Me.RtStIdTb.MouseState = MaterialSkin.MouseState.HOVER
        Me.RtStIdTb.Name = "RtStIdTb"
        Me.RtStIdTb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.RtStIdTb.SelectedText = ""
        Me.RtStIdTb.SelectionLength = 0
        Me.RtStIdTb.SelectionStart = 0
        Me.RtStIdTb.Size = New System.Drawing.Size(205, 23)
        Me.RtStIdTb.TabIndex = 49
        Me.RtStIdTb.TabStop = False
        Me.RtStIdTb.UseSystemPasswordChar = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(559, 73)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(104, 20)
        Me.Label13.TabIndex = 48
        Me.Label13.Text = "Department"
        '
        'StdepartmentTb
        '
        Me.StdepartmentTb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.StdepartmentTb.Depth = 0
        Me.StdepartmentTb.Enabled = False
        Me.StdepartmentTb.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StdepartmentTb.ForeColor = System.Drawing.Color.Navy
        Me.StdepartmentTb.Hint = ""
        Me.StdepartmentTb.Location = New System.Drawing.Point(563, 112)
        Me.StdepartmentTb.MaxLength = 32767
        Me.StdepartmentTb.MouseState = MaterialSkin.MouseState.HOVER
        Me.StdepartmentTb.Name = "StdepartmentTb"
        Me.StdepartmentTb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.StdepartmentTb.SelectedText = ""
        Me.StdepartmentTb.SelectionLength = 0
        Me.StdepartmentTb.SelectionStart = 0
        Me.StdepartmentTb.Size = New System.Drawing.Size(205, 23)
        Me.StdepartmentTb.TabIndex = 47
        Me.StdepartmentTb.TabStop = False
        Me.StdepartmentTb.UseSystemPasswordChar = False
        '
        'RtBookIdTb
        '
        Me.RtBookIdTb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.RtBookIdTb.Depth = 0
        Me.RtBookIdTb.Enabled = False
        Me.RtBookIdTb.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RtBookIdTb.ForeColor = System.Drawing.Color.Navy
        Me.RtBookIdTb.Hint = ""
        Me.RtBookIdTb.Location = New System.Drawing.Point(1157, 112)
        Me.RtBookIdTb.MaxLength = 32767
        Me.RtBookIdTb.MouseState = MaterialSkin.MouseState.HOVER
        Me.RtBookIdTb.Name = "RtBookIdTb"
        Me.RtBookIdTb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.RtBookIdTb.SelectedText = ""
        Me.RtBookIdTb.SelectionLength = 0
        Me.RtBookIdTb.SelectionStart = 0
        Me.RtBookIdTb.Size = New System.Drawing.Size(205, 23)
        Me.RtBookIdTb.TabIndex = 46
        Me.RtBookIdTb.TabStop = False
        Me.RtBookIdTb.UseSystemPasswordChar = False
        '
        'IssueBooks
        '
        Me.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FloralWhite
        Me.ClientSize = New System.Drawing.Size(1732, 865)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.IssueDGV)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Panel2)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MinimumSize = New System.Drawing.Size(1438, 829)
        Me.Name = "IssueBooks"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "IssueBooks"
        CType(Me.IssueDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label7 As Label
    Friend WithEvents IssueDGV As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents submitBtn As Button
    Friend WithEvents editBtn As Button
    Friend WithEvents resetBtn As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents RtIssueDateTb As DateTimePicker
    Public WithEvents RtStNameTb As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents RtBookNameTb As TextBox
    Friend WithEvents Panel2 As Panel
    Public WithEvents RtBookIdTb As MaterialSkin.Controls.MaterialSingleLineTextField
    Public WithEvents StdepartmentTb As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Label13 As Label
    Public WithEvents RtStIdTb As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
End Class
