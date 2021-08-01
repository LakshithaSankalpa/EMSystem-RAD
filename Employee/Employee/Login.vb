Public Class Login
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (TextBox1.Text = "" And TextBox2.Text = "") Then
            MsgBox("Is Empty Please Type Username OR Password")
        ElseIf (TextBox1.Text = "user" And TextBox2.Text = "1234") Then

            Me.Hide()
            Dim MF = New FormMDI
            MF.Show()
        Else
            MsgBox("Username OR Password Incorrect !!!!")
        End If



    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.ResetText()
        TextBox2.ResetText()
    End Sub


End Class