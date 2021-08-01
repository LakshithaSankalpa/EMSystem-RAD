Public Class FormMDI


    Private Sub EmployeeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmployeeToolStripMenuItem.Click
        Dim FMDI As New Employee
        FMDI.MdiParent = Me
        FMDI.Show()
    End Sub



    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub HomeToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem1.Click
        Me.Hide()
        Dim MF = New Login
        MF.Show()
    End Sub

    Private Sub DetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DetailsToolStripMenuItem.Click
        Dim FMDI As New Details
        FMDI.MdiParent = Me
        FMDI.Show()
    End Sub

    Private Sub SalaryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalaryToolStripMenuItem.Click
        Dim FMDI As New Salary
        FMDI.MdiParent = Me
        FMDI.Show()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MsgBox("Im Sithu Nikasha GAL/IT/@@@@@@@@@@@@@@@@@")
    End Sub
End Class