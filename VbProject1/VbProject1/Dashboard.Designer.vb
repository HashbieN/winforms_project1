<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDashboard
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuVolunteers = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuVaccines = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCases = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblVolunteers = New System.Windows.Forms.Label()
        Me.lblVaccines = New System.Windows.Forms.Label()
        Me.lblCases = New System.Windows.Forms.Label()
        Me.txtVolunteers = New System.Windows.Forms.TextBox()
        Me.txtVaccines = New System.Windows.Forms.TextBox()
        Me.txtCases = New System.Windows.Forms.TextBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuVolunteers, Me.mnuVaccines, Me.mnuCases, Me.mnuAbout})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(384, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuVolunteers
        '
        Me.mnuVolunteers.Name = "mnuVolunteers"
        Me.mnuVolunteers.Size = New System.Drawing.Size(74, 20)
        Me.mnuVolunteers.Text = "Volunteers"
        '
        'mnuVaccines
        '
        Me.mnuVaccines.Name = "mnuVaccines"
        Me.mnuVaccines.Size = New System.Drawing.Size(64, 20)
        Me.mnuVaccines.Text = "Vaccines"
        '
        'mnuCases
        '
        Me.mnuCases.Name = "mnuCases"
        Me.mnuCases.Size = New System.Drawing.Size(49, 20)
        Me.mnuCases.Text = "Cases"
        '
        'mnuAbout
        '
        Me.mnuAbout.Name = "mnuAbout"
        Me.mnuAbout.Size = New System.Drawing.Size(52, 20)
        Me.mnuAbout.Text = "About"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Location = New System.Drawing.Point(0, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(384, 53)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'lblVolunteers
        '
        Me.lblVolunteers.AutoSize = True
        Me.lblVolunteers.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVolunteers.Location = New System.Drawing.Point(31, 109)
        Me.lblVolunteers.Name = "lblVolunteers"
        Me.lblVolunteers.Size = New System.Drawing.Size(73, 20)
        Me.lblVolunteers.TabIndex = 2
        Me.lblVolunteers.Text = "Volunteers"
        '
        'lblVaccines
        '
        Me.lblVaccines.AutoSize = True
        Me.lblVaccines.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVaccines.Location = New System.Drawing.Point(31, 142)
        Me.lblVaccines.Name = "lblVaccines"
        Me.lblVaccines.Size = New System.Drawing.Size(64, 20)
        Me.lblVaccines.TabIndex = 3
        Me.lblVaccines.Text = "Vaccines"
        '
        'lblCases
        '
        Me.lblCases.AutoSize = True
        Me.lblCases.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCases.Location = New System.Drawing.Point(31, 174)
        Me.lblCases.Name = "lblCases"
        Me.lblCases.Size = New System.Drawing.Size(47, 20)
        Me.lblCases.TabIndex = 4
        Me.lblCases.Text = "Cases"
        '
        'txtVolunteers
        '
        Me.txtVolunteers.Location = New System.Drawing.Point(127, 111)
        Me.txtVolunteers.Name = "txtVolunteers"
        Me.txtVolunteers.Size = New System.Drawing.Size(74, 20)
        Me.txtVolunteers.TabIndex = 5
        '
        'txtVaccines
        '
        Me.txtVaccines.Location = New System.Drawing.Point(127, 144)
        Me.txtVaccines.Name = "txtVaccines"
        Me.txtVaccines.Size = New System.Drawing.Size(74, 20)
        Me.txtVaccines.TabIndex = 6
        '
        'txtCases
        '
        Me.txtCases.Location = New System.Drawing.Point(127, 176)
        Me.txtCases.Name = "txtCases"
        Me.txtCases.Size = New System.Drawing.Size(74, 20)
        Me.txtCases.TabIndex = 7
        '
        'frmDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 261)
        Me.Controls.Add(Me.txtCases)
        Me.Controls.Add(Me.txtVaccines)
        Me.Controls.Add(Me.txtVolunteers)
        Me.Controls.Add(Me.lblCases)
        Me.Controls.Add(Me.lblVaccines)
        Me.Controls.Add(Me.lblVolunteers)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmDashboard"
        Me.Text = "MySentosa"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuVolunteers As ToolStripMenuItem
    Friend WithEvents mnuVaccines As ToolStripMenuItem
    Friend WithEvents mnuCases As ToolStripMenuItem
    Friend WithEvents mnuAbout As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblVolunteers As Label
    Friend WithEvents lblVaccines As Label
    Friend WithEvents lblCases As Label
    Friend WithEvents txtVolunteers As TextBox
    Friend WithEvents txtVaccines As TextBox
    Friend WithEvents txtCases As TextBox
End Class
