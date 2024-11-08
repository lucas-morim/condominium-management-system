Public Class SplashScreen
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False
        FrmLogin.Show()
        Me.Close()
    End Sub
End Class
