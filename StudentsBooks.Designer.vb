<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentsBooks
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.StudentBooksDGV = New System.Windows.Forms.DataGridView()
        Me.SignOutBtn = New System.Windows.Forms.Button()
        Me.IssueBookBtn = New System.Windows.Forms.Button()
        CType(Me.StudentBooksDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StudentBooksDGV
        '
        Me.StudentBooksDGV.BackgroundColor = System.Drawing.Color.FloralWhite
        Me.StudentBooksDGV.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.StudentBooksDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.MediumSeaGreen
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FloralWhite
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.StudentBooksDGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.StudentBooksDGV.ColumnHeadersHeight = 30
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FloralWhite
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FloralWhite
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.StudentBooksDGV.DefaultCellStyle = DataGridViewCellStyle8
        Me.StudentBooksDGV.GridColor = System.Drawing.Color.Gainsboro
        Me.StudentBooksDGV.Location = New System.Drawing.Point(22, 76)
        Me.StudentBooksDGV.Margin = New System.Windows.Forms.Padding(2)
        Me.StudentBooksDGV.MaximumSize = New System.Drawing.Size(1283, 279)
        Me.StudentBooksDGV.MinimumSize = New System.Drawing.Size(1283, 279)
        Me.StudentBooksDGV.Name = "StudentBooksDGV"
        Me.StudentBooksDGV.ReadOnly = True
        Me.StudentBooksDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.Navy
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Navy
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Navy
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.StudentBooksDGV.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.StudentBooksDGV.RowHeadersVisible = False
        Me.StudentBooksDGV.RowHeadersWidth = 60
        Me.StudentBooksDGV.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StudentBooksDGV.RowTemplate.Height = 24
        Me.StudentBooksDGV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.StudentBooksDGV.Size = New System.Drawing.Size(1283, 279)
        Me.StudentBooksDGV.TabIndex = 26
        '
        'SignOutBtn
        '
        Me.SignOutBtn.Location = New System.Drawing.Point(285, 482)
        Me.SignOutBtn.Name = "SignOutBtn"
        Me.SignOutBtn.Size = New System.Drawing.Size(114, 23)
        Me.SignOutBtn.TabIndex = 27
        Me.SignOutBtn.Text = "SIGN OUT"
        Me.SignOutBtn.UseVisualStyleBackColor = True
        '
        'IssueBookBtn
        '
        Me.IssueBookBtn.Location = New System.Drawing.Point(688, 482)
        Me.IssueBookBtn.Name = "IssueBookBtn"
        Me.IssueBookBtn.Size = New System.Drawing.Size(138, 23)
        Me.IssueBookBtn.TabIndex = 28
        Me.IssueBookBtn.Text = "ISSUE BOOK"
        Me.IssueBookBtn.UseVisualStyleBackColor = True
        '
        'StudentsBooks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1403, 619)
        Me.Controls.Add(Me.IssueBookBtn)
        Me.Controls.Add(Me.SignOutBtn)
        Me.Controls.Add(Me.StudentBooksDGV)
        Me.Name = "StudentsBooks"
        Me.Text = "StudentsBooks"
        CType(Me.StudentBooksDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents StudentBooksDGV As DataGridView
    Friend WithEvents SignOutBtn As Button
    Friend WithEvents IssueBookBtn As Button
End Class
