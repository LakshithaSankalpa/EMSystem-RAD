<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDI
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
        Me.MenuStripMDI = New System.Windows.Forms.MenuStrip()
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmployeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalaryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.MenuStripMDI.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStripMDI
        '
        Me.MenuStripMDI.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStripMDI.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HomeToolStripMenuItem, Me.AboutToolStripMenuItem, Me.ListToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStripMDI.Location = New System.Drawing.Point(0, 0)
        Me.MenuStripMDI.Name = "MenuStripMDI"
        Me.MenuStripMDI.Size = New System.Drawing.Size(800, 28)
        Me.MenuStripMDI.TabIndex = 0
        Me.MenuStripMDI.Text = "MenuStrip1"
        '
        'HomeToolStripMenuItem
        '
        Me.HomeToolStripMenuItem.Name = "HomeToolStripMenuItem"
        Me.HomeToolStripMenuItem.Size = New System.Drawing.Size(64, 24)
        Me.HomeToolStripMenuItem.Text = "Home"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(64, 24)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'ListToolStripMenuItem
        '
        Me.ListToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmployeeToolStripMenuItem, Me.DetailsToolStripMenuItem, Me.SalaryToolStripMenuItem})
        Me.ListToolStripMenuItem.Name = "ListToolStripMenuItem"
        Me.ListToolStripMenuItem.Size = New System.Drawing.Size(45, 24)
        Me.ListToolStripMenuItem.Text = "List"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(47, 24)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'EmployeeToolStripMenuItem
        '
        Me.EmployeeToolStripMenuItem.Name = "EmployeeToolStripMenuItem"
        Me.EmployeeToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.EmployeeToolStripMenuItem.Text = "Employee"
        '
        'DetailsToolStripMenuItem
        '
        Me.DetailsToolStripMenuItem.Name = "DetailsToolStripMenuItem"
        Me.DetailsToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.DetailsToolStripMenuItem.Text = "Details"
        '
        'SalaryToolStripMenuItem
        '
        Me.SalaryToolStripMenuItem.Name = "SalaryToolStripMenuItem"
        Me.SalaryToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.SalaryToolStripMenuItem.Text = "Salary"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Black
        Me.Label7.Font = New System.Drawing.Font("Rockwell", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(773, 3)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(24, 23)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "X"
        '
        'MDI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.MenuStripMDI)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStripMDI
        Me.Name = "MDI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MDI"
        Me.MenuStripMDI.ResumeLayout(False)
        Me.MenuStripMDI.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStripMDI As MenuStrip
    Friend WithEvents HomeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmployeeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DetailsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalaryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label7 As Label
End Class
