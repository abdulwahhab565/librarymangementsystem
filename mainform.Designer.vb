<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class mainform
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mainform))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.welcome4 = New System.Windows.Forms.PictureBox()
        Me.welcome2 = New System.Windows.Forms.PictureBox()
        Me.welcome3 = New System.Windows.Forms.PictureBox()
        Me.welcome1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LogoutPanel = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.UploadButton1 = New System.Windows.Forms.LinkLabel()
        Me.LogoutLabel = New System.Windows.Forms.Label()
        Me.ProfilePictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PreviewPictureBox2 = New System.Windows.Forms.PictureBox()
        Me.signout1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.menu1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SlideTimer = New System.Windows.Forms.Timer(Me.components)
        Me.SlideOutTimer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.welcome4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.welcome2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.welcome3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.welcome1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.LogoutPanel.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.ProfilePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PreviewPictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.menu1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.welcome4)
        Me.Panel1.Controls.Add(Me.welcome2)
        Me.Panel1.Controls.Add(Me.welcome3)
        Me.Panel1.Controls.Add(Me.welcome1)
        Me.Panel1.Location = New System.Drawing.Point(86, 259)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1283, 237)
        Me.Panel1.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(1097, 212)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 25)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Returns"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(769, 212)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 25)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Issues"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(462, 212)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 25)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Books"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(112, 212)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 25)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Students"
        '
        'welcome4
        '
        Me.welcome4.Image = CType(resources.GetObject("welcome4.Image"), System.Drawing.Image)
        Me.welcome4.Location = New System.Drawing.Point(1045, 33)
        Me.welcome4.Name = "welcome4"
        Me.welcome4.Size = New System.Drawing.Size(179, 159)
        Me.welcome4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.welcome4.TabIndex = 3
        Me.welcome4.TabStop = False
        '
        'welcome2
        '
        Me.welcome2.Image = CType(resources.GetObject("welcome2.Image"), System.Drawing.Image)
        Me.welcome2.Location = New System.Drawing.Point(408, 33)
        Me.welcome2.Name = "welcome2"
        Me.welcome2.Size = New System.Drawing.Size(179, 159)
        Me.welcome2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.welcome2.TabIndex = 2
        Me.welcome2.TabStop = False
        '
        'welcome3
        '
        Me.welcome3.Image = CType(resources.GetObject("welcome3.Image"), System.Drawing.Image)
        Me.welcome3.Location = New System.Drawing.Point(719, 33)
        Me.welcome3.Name = "welcome3"
        Me.welcome3.Size = New System.Drawing.Size(175, 159)
        Me.welcome3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.welcome3.TabIndex = 1
        Me.welcome3.TabStop = False
        '
        'welcome1
        '
        Me.welcome1.Image = CType(resources.GetObject("welcome1.Image"), System.Drawing.Image)
        Me.welcome1.Location = New System.Drawing.Point(-9, 33)
        Me.welcome1.Name = "welcome1"
        Me.welcome1.Size = New System.Drawing.Size(351, 159)
        Me.welcome1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.welcome1.TabIndex = 0
        Me.welcome1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel2.BackColor = System.Drawing.Color.FloralWhite
        Me.Panel2.Controls.Add(Me.LogoutPanel)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.menu1)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1437, 262)
        Me.Panel2.TabIndex = 2
        '
        'LogoutPanel
        '
        Me.LogoutPanel.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.LogoutPanel.Controls.Add(Me.Panel5)
        Me.LogoutPanel.Controls.Add(Me.signout1)
        Me.LogoutPanel.Controls.Add(Me.PictureBox1)
        Me.LogoutPanel.Location = New System.Drawing.Point(12, 3)
        Me.LogoutPanel.Name = "LogoutPanel"
        Me.LogoutPanel.Size = New System.Drawing.Size(176, 273)
        Me.LogoutPanel.TabIndex = 45
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Panel5.Controls.Add(Me.UploadButton1)
        Me.Panel5.Controls.Add(Me.LogoutLabel)
        Me.Panel5.Controls.Add(Me.ProfilePictureBox1)
        Me.Panel5.Controls.Add(Me.PreviewPictureBox2)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(176, 69)
        Me.Panel5.TabIndex = 3
        '
        'UploadButton1
        '
        Me.UploadButton1.AutoSize = True
        Me.UploadButton1.Font = New System.Drawing.Font("Yu Gothic UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UploadButton1.LinkColor = System.Drawing.Color.White
        Me.UploadButton1.Location = New System.Drawing.Point(71, 21)
        Me.UploadButton1.Name = "UploadButton1"
        Me.UploadButton1.Size = New System.Drawing.Size(61, 13)
        Me.UploadButton1.TabIndex = 47
        Me.UploadButton1.TabStop = True
        Me.UploadButton1.Text = "Set  Profile"
        '
        'LogoutLabel
        '
        Me.LogoutLabel.AutoSize = True
        Me.LogoutLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogoutLabel.Location = New System.Drawing.Point(16, 51)
        Me.LogoutLabel.Name = "LogoutLabel"
        Me.LogoutLabel.Size = New System.Drawing.Size(57, 17)
        Me.LogoutLabel.TabIndex = 2
        Me.LogoutLabel.Text = "Label6"
        '
        'ProfilePictureBox1
        '
        Me.ProfilePictureBox1.Location = New System.Drawing.Point(19, 0)
        Me.ProfilePictureBox1.Name = "ProfilePictureBox1"
        Me.ProfilePictureBox1.Size = New System.Drawing.Size(51, 50)
        Me.ProfilePictureBox1.TabIndex = 46
        Me.ProfilePictureBox1.TabStop = False
        '
        'PreviewPictureBox2
        '
        Me.PreviewPictureBox2.Location = New System.Drawing.Point(19, 0)
        Me.PreviewPictureBox2.Name = "PreviewPictureBox2"
        Me.PreviewPictureBox2.Size = New System.Drawing.Size(51, 50)
        Me.PreviewPictureBox2.TabIndex = 46
        Me.PreviewPictureBox2.TabStop = False
        '
        'signout1
        '
        Me.signout1.AutoSize = True
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
        'Panel4
        '
        Me.Panel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel4.Controls.Add(Me.PictureBox5)
        Me.Panel4.Location = New System.Drawing.Point(1237, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(200, 37)
        Me.Panel4.TabIndex = 44
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.FloralWhite
        Me.PictureBox5.Dock = System.Windows.Forms.DockStyle.Right
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(160, 0)
        Me.PictureBox5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(40, 37)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox5.TabIndex = 18
        Me.PictureBox5.TabStop = False
        '
        'menu1
        '
        Me.menu1.Dock = System.Windows.Forms.DockStyle.Left
        Me.menu1.Image = CType(resources.GetObject("menu1.Image"), System.Drawing.Image)
        Me.menu1.Location = New System.Drawing.Point(0, 0)
        Me.menu1.Name = "menu1"
        Me.menu1.Size = New System.Drawing.Size(49, 262)
        Me.menu1.TabIndex = 1
        Me.menu1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 50.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(190, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(413, 76)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "WELCOME "
        '
        'Panel3
        '
        Me.Panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel3.BackColor = System.Drawing.Color.FloralWhite
        Me.Panel3.Location = New System.Drawing.Point(-1, 560)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1445, 262)
        Me.Panel3.TabIndex = 3
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogoutToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(110, 26)
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(109, 22)
        Me.LogoutToolStripMenuItem.Text = "logout"
        '
        'SlideTimer
        '
        Me.SlideTimer.Interval = 10
        '
        'SlideOutTimer2
        '
        Me.SlideOutTimer2.Interval = 10
        '
        'mainform
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(1437, 820)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MinimumSize = New System.Drawing.Size(1437, 820)
        Me.Name = "mainform"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "mainform"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.welcome4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.welcome2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.welcome3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.welcome1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.LogoutPanel.ResumeLayout(False)
        Me.LogoutPanel.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.ProfilePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PreviewPictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.menu1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents welcome4 As PictureBox
    Friend WithEvents welcome2 As PictureBox
    Friend WithEvents welcome3 As PictureBox
    Friend WithEvents welcome1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents menu1 As PictureBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents LogoutPanel As Panel
    Friend WithEvents SlideTimer As Timer
    Friend WithEvents SlideOutTimer2 As Timer
    Friend WithEvents signout1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LogoutLabel As Label
    Friend WithEvents ProfilePictureBox1 As PictureBox
    Friend WithEvents PreviewPictureBox2 As PictureBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents UploadButton1 As LinkLabel
End Class
