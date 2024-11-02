<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IssueStudent
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IssueStudent))
        Me.menu1 = New System.Windows.Forms.PictureBox()
        Me.LogoutPanel = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.UploadButton1 = New System.Windows.Forms.LinkLabel()
        Me.LogoutLabel = New System.Windows.Forms.Label()
        Me.ProfilePanel1 = New System.Windows.Forms.PictureBox()
        Me.PreviewPictureBox2 = New System.Windows.Forms.PictureBox()
        Me.signout1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SlideOutTimer3 = New System.Windows.Forms.Timer(Me.components)
        Me.SlideInTimer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.submitBtn = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.RtIssueDateTb = New System.Windows.Forms.DateTimePicker()
        Me.RtStNameTb = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.RtBookNameTb = New System.Windows.Forms.TextBox()
        Me.RtBookIdTb = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.StdepartmentTb = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.RtStIdTb = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        CType(Me.menu1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LogoutPanel.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.ProfilePanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PreviewPictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'menu1
        '
        Me.menu1.Image = CType(resources.GetObject("menu1.Image"), System.Drawing.Image)
        Me.menu1.Location = New System.Drawing.Point(0, 0)
        Me.menu1.Name = "menu1"
        Me.menu1.Size = New System.Drawing.Size(49, 262)
        Me.menu1.TabIndex = 23
        Me.menu1.TabStop = False
        '
        'LogoutPanel
        '
        Me.LogoutPanel.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.LogoutPanel.Controls.Add(Me.Panel5)
        Me.LogoutPanel.Controls.Add(Me.signout1)
        Me.LogoutPanel.Controls.Add(Me.PictureBox1)
        Me.LogoutPanel.Location = New System.Drawing.Point(55, 0)
        Me.LogoutPanel.Name = "LogoutPanel"
        Me.LogoutPanel.Size = New System.Drawing.Size(176, 273)
        Me.LogoutPanel.TabIndex = 46
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Panel5.Controls.Add(Me.UploadButton1)
        Me.Panel5.Controls.Add(Me.LogoutLabel)
        Me.Panel5.Controls.Add(Me.ProfilePanel1)
        Me.Panel5.Controls.Add(Me.PreviewPictureBox2)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(176, 69)
        Me.Panel5.TabIndex = 3
        '
        'UploadButton1
        '
        Me.UploadButton1.ActiveLinkColor = System.Drawing.SystemColors.WindowFrame
        Me.UploadButton1.AutoSize = True
        Me.UploadButton1.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UploadButton1.LinkColor = System.Drawing.Color.White
        Me.UploadButton1.Location = New System.Drawing.Point(114, 20)
        Me.UploadButton1.Name = "UploadButton1"
        Me.UploadButton1.Size = New System.Drawing.Size(43, 21)
        Me.UploadButton1.TabIndex = 48
        Me.UploadButton1.TabStop = True
        Me.UploadButton1.Text = "EDIT"
        '
        'LogoutLabel
        '
        Me.LogoutLabel.AutoSize = True
        Me.LogoutLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogoutLabel.Location = New System.Drawing.Point(15, 51)
        Me.LogoutLabel.Name = "LogoutLabel"
        Me.LogoutLabel.Size = New System.Drawing.Size(0, 18)
        Me.LogoutLabel.TabIndex = 2
        Me.LogoutLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ProfilePanel1
        '
        Me.ProfilePanel1.Location = New System.Drawing.Point(15, 0)
        Me.ProfilePanel1.Name = "ProfilePanel1"
        Me.ProfilePanel1.Size = New System.Drawing.Size(51, 50)
        Me.ProfilePanel1.TabIndex = 46
        Me.ProfilePanel1.TabStop = False
        '
        'PreviewPictureBox2
        '
        Me.PreviewPictureBox2.Location = New System.Drawing.Point(15, 0)
        Me.PreviewPictureBox2.Name = "PreviewPictureBox2"
        Me.PreviewPictureBox2.Size = New System.Drawing.Size(51, 50)
        Me.PreviewPictureBox2.TabIndex = 46
        Me.PreviewPictureBox2.TabStop = False
        '
        'signout1
        '
        Me.signout1.AutoSize = True
        Me.signout1.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.signout1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.signout1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.signout1.ForeColor = System.Drawing.Color.Red
        Me.signout1.Location = New System.Drawing.Point(65, 221)
        Me.signout1.Name = "signout1"
        Me.signout1.Size = New System.Drawing.Size(79, 16)
        Me.signout1.TabIndex = 1
        Me.signout1.Text = "SIGN OUT"
        Me.signout1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(47, 218)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(20, 34)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(364, 121)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(404, 76)
        Me.Label8.TabIndex = 47
        Me.Label8.Text = "WELCOME "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(1410, 73)
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
        Me.Label2.Location = New System.Drawing.Point(22, 73)
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
        Me.submitBtn.Location = New System.Drawing.Point(654, 220)
        Me.submitBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.submitBtn.Name = "submitBtn"
        Me.submitBtn.Size = New System.Drawing.Size(193, 45)
        Me.submitBtn.TabIndex = 13
        Me.submitBtn.Text = "Submit"
        Me.submitBtn.UseVisualStyleBackColor = False
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
        Me.RtIssueDateTb.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RtIssueDateTb.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.RtIssueDateTb.Location = New System.Drawing.Point(1414, 109)
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
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.FloralWhite
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(691, 315)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 20)
        Me.Label7.TabIndex = 22
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
        'RtStIdTb
        '
        Me.RtStIdTb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.RtStIdTb.Depth = 0
        Me.RtStIdTb.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RtStIdTb.ForeColor = System.Drawing.Color.Navy
        Me.RtStIdTb.Hint = ""
        Me.RtStIdTb.Location = New System.Drawing.Point(26, 109)
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
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(920, 114)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(0, 17)
        Me.Label9.TabIndex = 50
        '
        'Panel2
        '
        Me.Panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel2.BackColor = System.Drawing.Color.FloralWhite
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.RtStIdTb)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.StdepartmentTb)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.RtBookIdTb)
        Me.Panel2.Controls.Add(Me.RtBookNameTb)
        Me.Panel2.Controls.Add(Me.RtStNameTb)
        Me.Panel2.Controls.Add(Me.RtIssueDateTb)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.submitBtn)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.ForeColor = System.Drawing.Color.Navy
        Me.Panel2.Location = New System.Drawing.Point(0, 276)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1569, 558)
        Me.Panel2.TabIndex = 21
        '
        'IssueStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1569, 834)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.LogoutPanel)
        Me.Controls.Add(Me.menu1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "IssueStudent"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "IssueStudentvb"
        CType(Me.menu1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LogoutPanel.ResumeLayout(False)
        Me.LogoutPanel.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.ProfilePanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PreviewPictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents menu1 As PictureBox
    Friend WithEvents LogoutPanel As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents LogoutLabel As Label
    Friend WithEvents ProfilePanel1 As PictureBox
    Friend WithEvents PreviewPictureBox2 As PictureBox
    Friend WithEvents signout1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents SlideOutTimer As Timer
    Friend WithEvents SlideOutTimer3 As Timer
    Friend WithEvents SlideInTimer1 As Timer
    Friend WithEvents Label8 As Label
    Friend WithEvents UploadButton1 As LinkLabel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents submitBtn As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents RtIssueDateTb As DateTimePicker
    Public WithEvents RtStNameTb As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents RtBookNameTb As TextBox
    Public WithEvents RtBookIdTb As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Label7 As Label
    Public WithEvents StdepartmentTb As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Label13 As Label
    Public WithEvents RtStIdTb As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel2 As Panel
End Class
