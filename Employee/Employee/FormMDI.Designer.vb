<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMDI
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HomeToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmployeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalaryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HomeToolStripMenuItem, Me.ListToolStripMenuItem, Me.AboutToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(771, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HomeToolStripMenuItem
        '
        Me.HomeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HomeToolStripMenuItem1})
        Me.HomeToolStripMenuItem.Name = "HomeToolStripMenuItem"
        Me.HomeToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.HomeToolStripMenuItem.Text = "Home"
        '
        'HomeToolStripMenuItem1
        '
        Me.HomeToolStripMenuItem1.Name = "HomeToolStripMenuItem1"
        Me.HomeToolStripMenuItem1.Size = New System.Drawing.Size(112, 22)
        Me.HomeToolStripMenuItem1.Text = "Logout"
        '
        'ListToolStripMenuItem
        '
        Me.ListToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmployeeToolStripMenuItem, Me.DetailsToolStripMenuItem, Me.SalaryToolStripMenuItem})
        Me.ListToolStripMenuItem.Name = "ListToolStripMenuItem"
        Me.ListToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.ListToolStripMenuItem.Text = "List"
        '
        'EmployeeToolStripMenuItem
        '
        Me.EmployeeToolStripMenuItem.Name = "EmployeeToolStripMenuItem"
        Me.EmployeeToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.EmployeeToolStripMenuItem.Text = "Employee"
        '
        'DetailsToolStripMenuItem
        '
        Me.DetailsToolStripMenuItem.Name = "DetailsToolStripMenuItem"
        Me.DetailsToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.DetailsToolStripMenuItem.Text = "Details"
        '
        'SalaryToolStripMenuItem
        '
        Me.SalaryToolStripMenuItem.Name = "SalaryToolStripMenuItem"
        Me.SalaryToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.SalaryToolStripMenuItem.Text = "Salary"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(38, 20)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'FormMDI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(771, 561)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FormMDI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormMDI"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents HomeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmployeeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DetailsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalaryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents HomeToolStripMenuItem1 As ToolStripMenuItem
End Class
