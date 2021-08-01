Public Class splash


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar2.Increment(1)
        Label1.Text = ProgressBar2.Value & ("%")
        If ProgressBar2.Value = 100 Then
            Me.Hide()
            Dim log = New Login
            log.Show()
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub splash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        BackColor = Color.Black
        TransparencyKey = BackColor
    End Sub


End Class
