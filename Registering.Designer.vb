<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Registering
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Registering))
        Me.LabelSt = New System.Windows.Forms.Label()
        Me.StTb = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.PictureSignup = New System.Windows.Forms.PictureBox()
        Me.LabelId = New System.Windows.Forms.Label()
        Me.LabelDp = New System.Windows.Forms.Label()
        Me.LabelSms = New System.Windows.Forms.Label()
        Me.LabelPhone = New System.Windows.Forms.Label()
        Me.IdTb = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.DpTb = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.PhoneTb = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.SignupBtn = New System.Windows.Forms.Button()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.PasswordTb = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.SignInButton = New System.Windows.Forms.Button()
        Me.IndexNumberTb = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.SignInPasswordTb = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.RegistrationPanel = New System.Windows.Forms.Panel()
        Me.MaterialCheckBox1 = New MaterialSkin.Controls.MaterialCheckBox()
        Me.MaterialFlatButton1 = New MaterialSkin.Controls.MaterialFlatButton()
        Me.SmsTb = New System.Windows.Forms.ComboBox()
        Me.SignInPanel = New System.Windows.Forms.Panel()
        Me.chkShowPassword = New MaterialSkin.Controls.MaterialCheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.SwitchToSignIn = New System.Windows.Forms.LinkLabel()
        Me.SwitchToRegistration = New MaterialSkin.Controls.MaterialFlatButton()
        CType(Me.PictureSignup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RegistrationPanel.SuspendLayout()
        Me.SignInPanel.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelSt
        '
        Me.LabelSt.AutoSize = True
        Me.LabelSt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSt.Location = New System.Drawing.Point(35, 114)
        Me.LabelSt.Name = "LabelSt"
        Me.LabelSt.Size = New System.Drawing.Size(55, 20)
        Me.LabelSt.TabIndex = 0
        Me.LabelSt.Text = " Name"
        '
        'StTb
        '
        Me.StTb.Depth = 0
        Me.StTb.Hint = "Name"
        Me.StTb.Location = New System.Drawing.Point(193, 111)
        Me.StTb.MaxLength = 32767
        Me.StTb.MouseState = MaterialSkin.MouseState.HOVER
        Me.StTb.Name = "StTb"
        Me.StTb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.StTb.SelectedText = ""
        Me.StTb.SelectionLength = 0
        Me.StTb.SelectionStart = 0
        Me.StTb.Size = New System.Drawing.Size(281, 23)
        Me.StTb.TabIndex = 1
        Me.StTb.TabStop = False
        Me.StTb.UseSystemPasswordChar = False
        '
        'PictureSignup
        '
        Me.PictureSignup.BackColor = System.Drawing.Color.White
        Me.PictureSignup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureSignup.Location = New System.Drawing.Point(39, 28)
        Me.PictureSignup.Name = "PictureSignup"
        Me.PictureSignup.Size = New System.Drawing.Size(51, 50)
        Me.PictureSignup.TabIndex = 2
        Me.PictureSignup.TabStop = False
        '
        'LabelId
        '
        Me.LabelId.AutoSize = True
        Me.LabelId.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelId.Location = New System.Drawing.Point(35, 183)
        Me.LabelId.Name = "LabelId"
        Me.LabelId.Size = New System.Drawing.Size(84, 20)
        Me.LabelId.TabIndex = 3
        Me.LabelId.Text = "Student Id"
        '
        'LabelDp
        '
        Me.LabelDp.AutoSize = True
        Me.LabelDp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDp.Location = New System.Drawing.Point(35, 262)
        Me.LabelDp.Name = "LabelDp"
        Me.LabelDp.Size = New System.Drawing.Size(94, 20)
        Me.LabelDp.TabIndex = 4
        Me.LabelDp.Text = "Department"
        '
        'LabelSms
        '
        Me.LabelSms.AutoSize = True
        Me.LabelSms.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSms.Location = New System.Drawing.Point(35, 341)
        Me.LabelSms.Name = "LabelSms"
        Me.LabelSms.Size = New System.Drawing.Size(78, 20)
        Me.LabelSms.TabIndex = 5
        Me.LabelSms.Text = "Semester"
        '
        'LabelPhone
        '
        Me.LabelPhone.AutoSize = True
        Me.LabelPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPhone.Location = New System.Drawing.Point(35, 421)
        Me.LabelPhone.Name = "LabelPhone"
        Me.LabelPhone.Size = New System.Drawing.Size(115, 20)
        Me.LabelPhone.TabIndex = 6
        Me.LabelPhone.Text = "Phone Number"
        '
        'IdTb
        '
        Me.IdTb.Depth = 0
        Me.IdTb.Hint = "Student ID"
        Me.IdTb.Location = New System.Drawing.Point(193, 180)
        Me.IdTb.MaxLength = 32767
        Me.IdTb.MouseState = MaterialSkin.MouseState.HOVER
        Me.IdTb.Name = "IdTb"
        Me.IdTb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.IdTb.SelectedText = ""
        Me.IdTb.SelectionLength = 0
        Me.IdTb.SelectionStart = 0
        Me.IdTb.Size = New System.Drawing.Size(281, 23)
        Me.IdTb.TabIndex = 7
        Me.IdTb.TabStop = False
        Me.IdTb.UseSystemPasswordChar = False
        '
        'DpTb
        '
        Me.DpTb.Depth = 0
        Me.DpTb.Hint = "Department"
        Me.DpTb.Location = New System.Drawing.Point(193, 259)
        Me.DpTb.MaxLength = 32767
        Me.DpTb.MouseState = MaterialSkin.MouseState.HOVER
        Me.DpTb.Name = "DpTb"
        Me.DpTb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.DpTb.SelectedText = ""
        Me.DpTb.SelectionLength = 0
        Me.DpTb.SelectionStart = 0
        Me.DpTb.Size = New System.Drawing.Size(281, 23)
        Me.DpTb.TabIndex = 8
        Me.DpTb.TabStop = False
        Me.DpTb.UseSystemPasswordChar = False
        '
        'PhoneTb
        '
        Me.PhoneTb.Depth = 0
        Me.PhoneTb.Hint = " Phone Number"
        Me.PhoneTb.Location = New System.Drawing.Point(193, 418)
        Me.PhoneTb.MaxLength = 32767
        Me.PhoneTb.MouseState = MaterialSkin.MouseState.HOVER
        Me.PhoneTb.Name = "PhoneTb"
        Me.PhoneTb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.PhoneTb.SelectedText = ""
        Me.PhoneTb.SelectionLength = 0
        Me.PhoneTb.SelectionStart = 0
        Me.PhoneTb.Size = New System.Drawing.Size(281, 23)
        Me.PhoneTb.TabIndex = 10
        Me.PhoneTb.TabStop = False
        Me.PhoneTb.UseSystemPasswordChar = False
        '
        'SignupBtn
        '
        Me.SignupBtn.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.SignupBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SignupBtn.ForeColor = System.Drawing.Color.White
        Me.SignupBtn.Location = New System.Drawing.Point(887, 605)
        Me.SignupBtn.Name = "SignupBtn"
        Me.SignupBtn.Size = New System.Drawing.Size(117, 44)
        Me.SignupBtn.TabIndex = 11
        Me.SignupBtn.Text = "SIGN UP "
        Me.SignupBtn.UseVisualStyleBackColor = False
        '
        'PasswordLabel
        '
        Me.PasswordLabel.AutoSize = True
        Me.PasswordLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordLabel.Location = New System.Drawing.Point(35, 478)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(78, 20)
        Me.PasswordLabel.TabIndex = 15
        Me.PasswordLabel.Text = "Password"
        '
        'PasswordTb
        '
        Me.PasswordTb.Depth = 0
        Me.PasswordTb.Hint = "Password"
        Me.PasswordTb.Location = New System.Drawing.Point(193, 475)
        Me.PasswordTb.MaxLength = 32767
        Me.PasswordTb.MouseState = MaterialSkin.MouseState.HOVER
        Me.PasswordTb.Name = "PasswordTb"
        Me.PasswordTb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.PasswordTb.SelectedText = ""
        Me.PasswordTb.SelectionLength = 0
        Me.PasswordTb.SelectionStart = 0
        Me.PasswordTb.Size = New System.Drawing.Size(281, 23)
        Me.PasswordTb.TabIndex = 16
        Me.PasswordTb.TabStop = False
        Me.PasswordTb.UseSystemPasswordChar = False
        '
        'SignInButton
        '
        Me.SignInButton.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.SignInButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SignInButton.ForeColor = System.Drawing.Color.White
        Me.SignInButton.Location = New System.Drawing.Point(318, 308)
        Me.SignInButton.Name = "SignInButton"
        Me.SignInButton.Size = New System.Drawing.Size(85, 38)
        Me.SignInButton.TabIndex = 17
        Me.SignInButton.Text = "SIGN IN"
        Me.SignInButton.UseVisualStyleBackColor = False
        '
        'IndexNumberTb
        '
        Me.IndexNumberTb.Depth = 0
        Me.IndexNumberTb.Hint = "Enter Your Student ID"
        Me.IndexNumberTb.Location = New System.Drawing.Point(182, 10)
        Me.IndexNumberTb.MaxLength = 32767
        Me.IndexNumberTb.MouseState = MaterialSkin.MouseState.HOVER
        Me.IndexNumberTb.Name = "IndexNumberTb"
        Me.IndexNumberTb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.IndexNumberTb.SelectedText = ""
        Me.IndexNumberTb.SelectionLength = 0
        Me.IndexNumberTb.SelectionStart = 0
        Me.IndexNumberTb.Size = New System.Drawing.Size(156, 23)
        Me.IndexNumberTb.TabIndex = 18
        Me.IndexNumberTb.TabStop = False
        Me.IndexNumberTb.UseSystemPasswordChar = False
        '
        'SignInPasswordTb
        '
        Me.SignInPasswordTb.Depth = 0
        Me.SignInPasswordTb.Hint = "Enter Password"
        Me.SignInPasswordTb.Location = New System.Drawing.Point(182, 87)
        Me.SignInPasswordTb.MaxLength = 32767
        Me.SignInPasswordTb.MouseState = MaterialSkin.MouseState.HOVER
        Me.SignInPasswordTb.Name = "SignInPasswordTb"
        Me.SignInPasswordTb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.SignInPasswordTb.SelectedText = ""
        Me.SignInPasswordTb.SelectionLength = 0
        Me.SignInPasswordTb.SelectionStart = 0
        Me.SignInPasswordTb.Size = New System.Drawing.Size(156, 23)
        Me.SignInPasswordTb.TabIndex = 19
        Me.SignInPasswordTb.TabStop = False
        Me.SignInPasswordTb.UseSystemPasswordChar = False
        '
        'RegistrationPanel
        '
        Me.RegistrationPanel.Controls.Add(Me.MaterialCheckBox1)
        Me.RegistrationPanel.Controls.Add(Me.MaterialFlatButton1)
        Me.RegistrationPanel.Controls.Add(Me.SmsTb)
        Me.RegistrationPanel.Controls.Add(Me.PasswordLabel)
        Me.RegistrationPanel.Controls.Add(Me.PasswordTb)
        Me.RegistrationPanel.Controls.Add(Me.PhoneTb)
        Me.RegistrationPanel.Controls.Add(Me.LabelPhone)
        Me.RegistrationPanel.Controls.Add(Me.LabelSt)
        Me.RegistrationPanel.Controls.Add(Me.DpTb)
        Me.RegistrationPanel.Controls.Add(Me.LabelSms)
        Me.RegistrationPanel.Controls.Add(Me.IdTb)
        Me.RegistrationPanel.Controls.Add(Me.PictureSignup)
        Me.RegistrationPanel.Controls.Add(Me.StTb)
        Me.RegistrationPanel.Controls.Add(Me.LabelDp)
        Me.RegistrationPanel.Controls.Add(Me.LabelId)
        Me.RegistrationPanel.Location = New System.Drawing.Point(527, 46)
        Me.RegistrationPanel.Name = "RegistrationPanel"
        Me.RegistrationPanel.Size = New System.Drawing.Size(477, 553)
        Me.RegistrationPanel.TabIndex = 20
        '
        'MaterialCheckBox1
        '
        Me.MaterialCheckBox1.AutoSize = True
        Me.MaterialCheckBox1.Depth = 0
        Me.MaterialCheckBox1.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.MaterialCheckBox1.Location = New System.Drawing.Point(193, 511)
        Me.MaterialCheckBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.MaterialCheckBox1.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.MaterialCheckBox1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCheckBox1.Name = "MaterialCheckBox1"
        Me.MaterialCheckBox1.Ripple = True
        Me.MaterialCheckBox1.Size = New System.Drawing.Size(128, 30)
        Me.MaterialCheckBox1.TabIndex = 19
        Me.MaterialCheckBox1.Text = "Show Password"
        Me.MaterialCheckBox1.UseVisualStyleBackColor = True
        '
        'MaterialFlatButton1
        '
        Me.MaterialFlatButton1.AutoSize = True
        Me.MaterialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialFlatButton1.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.MaterialFlatButton1.Depth = 0
        Me.MaterialFlatButton1.FlatAppearance.BorderColor = System.Drawing.Color.MediumSeaGreen
        Me.MaterialFlatButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSeaGreen
        Me.MaterialFlatButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen
        Me.MaterialFlatButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MaterialFlatButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 1.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaterialFlatButton1.ForeColor = System.Drawing.Color.MediumSeaGreen
        Me.MaterialFlatButton1.Icon = Nothing
        Me.MaterialFlatButton1.Location = New System.Drawing.Point(108, 44)
        Me.MaterialFlatButton1.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaterialFlatButton1.MaximumSize = New System.Drawing.Size(90, 20)
        Me.MaterialFlatButton1.MinimumSize = New System.Drawing.Size(90, 20)
        Me.MaterialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialFlatButton1.Name = "MaterialFlatButton1"
        Me.MaterialFlatButton1.Primary = False
        Me.MaterialFlatButton1.Size = New System.Drawing.Size(90, 20)
        Me.MaterialFlatButton1.TabIndex = 18
        Me.MaterialFlatButton1.Text = "Set Profile"
        Me.MaterialFlatButton1.UseCompatibleTextRendering = True
        Me.MaterialFlatButton1.UseVisualStyleBackColor = False
        '
        'SmsTb
        '
        Me.SmsTb.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SmsTb.Items.AddRange(New Object() {"1", "2"})
        Me.SmsTb.Location = New System.Drawing.Point(193, 338)
        Me.SmsTb.Name = "SmsTb"
        Me.SmsTb.Size = New System.Drawing.Size(44, 28)
        Me.SmsTb.TabIndex = 0
        '
        'SignInPanel
        '
        Me.SignInPanel.Controls.Add(Me.chkShowPassword)
        Me.SignInPanel.Controls.Add(Me.Label2)
        Me.SignInPanel.Controls.Add(Me.Label1)
        Me.SignInPanel.Controls.Add(Me.IndexNumberTb)
        Me.SignInPanel.Controls.Add(Me.SignInPasswordTb)
        Me.SignInPanel.Location = New System.Drawing.Point(12, 118)
        Me.SignInPanel.Name = "SignInPanel"
        Me.SignInPanel.Size = New System.Drawing.Size(391, 176)
        Me.SignInPanel.TabIndex = 21
        '
        'chkShowPassword
        '
        Me.chkShowPassword.AutoSize = True
        Me.chkShowPassword.Depth = 0
        Me.chkShowPassword.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.chkShowPassword.Location = New System.Drawing.Point(182, 131)
        Me.chkShowPassword.Margin = New System.Windows.Forms.Padding(0)
        Me.chkShowPassword.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.chkShowPassword.MouseState = MaterialSkin.MouseState.HOVER
        Me.chkShowPassword.Name = "chkShowPassword"
        Me.chkShowPassword.Ripple = True
        Me.chkShowPassword.Size = New System.Drawing.Size(128, 30)
        Me.chkShowPassword.TabIndex = 20
        Me.chkShowPassword.Text = "Show Password"
        Me.chkShowPassword.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(25, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 23)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "PASSWORD:"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "USERNAME:"
        '
        'Panel3
        '
        Me.Panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Controls.Add(Me.PictureBox3)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1057, 37)
        Me.Panel3.TabIndex = 43
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(0, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(85, 37)
        Me.Button1.TabIndex = 44
        Me.Button1.Text = "BACK"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.FloralWhite
        Me.PictureBox3.Dock = System.Windows.Forms.DockStyle.Right
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(1017, 0)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(40, 37)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox3.TabIndex = 18
        Me.PictureBox3.TabStop = False
        '
        'SwitchToSignIn
        '
        Me.SwitchToSignIn.AutoSize = True
        Me.SwitchToSignIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SwitchToSignIn.LinkColor = System.Drawing.Color.Red
        Me.SwitchToSignIn.Location = New System.Drawing.Point(838, 664)
        Me.SwitchToSignIn.Name = "SwitchToSignIn"
        Me.SwitchToSignIn.Size = New System.Drawing.Size(166, 17)
        Me.SwitchToSignIn.TabIndex = 44
        Me.SwitchToSignIn.TabStop = True
        Me.SwitchToSignIn.Text = "Already have an Account"
        '
        'SwitchToRegistration
        '
        Me.SwitchToRegistration.AutoSize = True
        Me.SwitchToRegistration.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.SwitchToRegistration.Depth = 0
        Me.SwitchToRegistration.ForeColor = System.Drawing.Color.Red
        Me.SwitchToRegistration.Icon = Nothing
        Me.SwitchToRegistration.Location = New System.Drawing.Point(231, 371)
        Me.SwitchToRegistration.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.SwitchToRegistration.MouseState = MaterialSkin.MouseState.HOVER
        Me.SwitchToRegistration.Name = "SwitchToRegistration"
        Me.SwitchToRegistration.Primary = False
        Me.SwitchToRegistration.Size = New System.Drawing.Size(172, 36)
        Me.SwitchToRegistration.TabIndex = 45
        Me.SwitchToRegistration.Text = "Create New Account"
        Me.SwitchToRegistration.UseVisualStyleBackColor = True
        '
        'Registering
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FloralWhite
        Me.ClientSize = New System.Drawing.Size(1057, 844)
        Me.Controls.Add(Me.SwitchToRegistration)
        Me.Controls.Add(Me.SwitchToSignIn)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.SignInButton)
        Me.Controls.Add(Me.SignInPanel)
        Me.Controls.Add(Me.SignupBtn)
        Me.Controls.Add(Me.RegistrationPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Registering"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registering"
        CType(Me.PictureSignup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RegistrationPanel.ResumeLayout(False)
        Me.RegistrationPanel.PerformLayout()
        Me.SignInPanel.ResumeLayout(False)
        Me.SignInPanel.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelSt As Label
    Friend WithEvents StTb As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents PictureSignup As PictureBox
    Friend WithEvents LabelId As Label
    Friend WithEvents LabelDp As Label
    Friend WithEvents LabelSms As Label
    Friend WithEvents LabelPhone As Label
    Friend WithEvents IdTb As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents DpTb As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents PhoneTb As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents SignupBtn As Button

    Private Sub Registering_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Friend WithEvents PasswordLabel As Label
    Friend WithEvents PasswordTb As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents SignInButton As Button
    Friend WithEvents IndexNumberTb As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents SignInPasswordTb As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents RegistrationPanel As Panel
    Friend WithEvents SignInPanel As Panel
    Friend WithEvents SmsTb As ComboBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents MaterialFlatButton1 As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents SwitchToSignIn As LinkLabel
    Friend WithEvents SwitchToRegistration As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents chkShowPassword As MaterialSkin.Controls.MaterialCheckBox
    Friend WithEvents MaterialCheckBox1 As MaterialSkin.Controls.MaterialCheckBox
End Class
