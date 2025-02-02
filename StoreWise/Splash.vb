Public Class Splash

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value < 1000 Then
            ProgressBar1.Value += 100
        Else
            Me.Hide()
            loginPage.Show()
            Timer1.Enabled = False
        End If
    End Sub
End Class
