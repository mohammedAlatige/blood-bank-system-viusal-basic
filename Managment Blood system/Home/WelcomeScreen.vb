Public Class welcomeScreen

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Myprogers.Increment(1)
        proLable.Text = Myprogers.Value
        If Myprogers.Value = 100 Then
            Me.Hide()
             login.Show()
            Timer1.Enabled = False

        End If
    End Sub

    Private Sub welcomeScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub
End Class