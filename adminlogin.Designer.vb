<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class adminlogin
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(adminlogin))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.UpasswordTb = New System.Windows.Forms.TextBox()
        Me.lblWrongPassword = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.chkShowPassword = New MaterialSkin.Controls.MaterialCheckBox()
        Me.Label1 = New System.Windows.Forms.LinkLabel()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel1.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 97)
        Me.Panel1.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel3.Controls.Add(Me.PictureBox2)
        Me.Panel3.Location = New System.Drawing.Point(600, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(200, 37)
        Me.Panel3.TabIndex = 43
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Right
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(160, 0)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(40, 37)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox2.TabIndex = 17
        Me.PictureBox2.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(199, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(383, 63)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "ADMIN LOGIN"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(323, 241)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(132, 45)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "LOGIN"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(214, 155)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 31)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Password"
        '
        'UpasswordTb
        '
        Me.UpasswordTb.BackColor = System.Drawing.SystemColors.Menu
        Me.UpasswordTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UpasswordTb.CausesValidation = False
        Me.UpasswordTb.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpasswordTb.Location = New System.Drawing.Point(418, 148)
        Me.UpasswordTb.Name = "UpasswordTb"
        Me.UpasswordTb.Size = New System.Drawing.Size(290, 38)
        Me.UpasswordTb.TabIndex = 7
        Me.UpasswordTb.WordWrap = False
        '
        'lblWrongPassword
        '
        Me.lblWrongPassword.AutoSize = True
        Me.lblWrongPassword.BackColor = System.Drawing.SystemColors.Menu
        Me.lblWrongPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblWrongPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWrongPassword.ForeColor = System.Drawing.Color.Red
        Me.lblWrongPassword.Location = New System.Drawing.Point(491, 156)
        Me.lblWrongPassword.Name = "lblWrongPassword"
        Me.lblWrongPassword.Size = New System.Drawing.Size(0, 25)
        Me.lblWrongPassword.TabIndex = 12
        '
        'Timer1
        '
        '
        'chkShowPassword
        '
        Me.chkShowPassword.AutoSize = True
        Me.chkShowPassword.Depth = 0
        Me.chkShowPassword.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.chkShowPassword.Location = New System.Drawing.Point(418, 208)
        Me.chkShowPassword.Margin = New System.Windows.Forms.Padding(0)
        Me.chkShowPassword.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.chkShowPassword.MouseState = MaterialSkin.MouseState.HOVER
        Me.chkShowPassword.Name = "chkShowPassword"
        Me.chkShowPassword.Ripple = True
        Me.chkShowPassword.Size = New System.Drawing.Size(128, 30)
        Me.chkShowPassword.TabIndex = 14
        Me.chkShowPassword.Text = "Show Password"
        Me.chkShowPassword.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.Label1.LinkColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(385, 327)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 29)
        Me.Label1.TabIndex = 15
        Me.Label1.TabStop = True
        Me.Label1.Text = "Back"
        '
        'adminlogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FloralWhite
        Me.ClientSize = New System.Drawing.Size(800, 391)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.chkShowPassword)
        Me.Controls.Add(Me.lblWrongPassword)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.UpasswordTb)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "adminlogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "adminlogin"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents UpasswordTb As TextBox
    Friend WithEvents lblWrongPassword As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents chkShowPassword As MaterialSkin.Controls.MaterialCheckBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As LinkLabel
End Class
