Public Class modifyUser

    Private Sub modifyUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If (DMode) Then
            Me.BackColor = Color.FromArgb(255, 13, 17, 23)
            For i = 1 To 5
                Dim lbl As Label = Me.Controls("Label" & i)
                lbl.ForeColor = Color.FromArgb(255, 240, 246, 252)
            Next
            modify.BackColor = Color.FromArgb(255, 31, 111, 235)
            modify.BackColor = Color.FromArgb(255, 31, 111, 235)
            cancle.BackColor = Color.FromArgb(255, 31, 111, 235)
            cancle.BackColor = Color.FromArgb(255, 31, 111, 235)
            uName.BackColor = Color.FromArgb(255, 33, 40, 48)
            uName.ForeColor = Color.FromArgb(255, 240, 246, 252)
            oPass.BackColor = Color.FromArgb(255, 33, 40, 48)
            oPass.ForeColor = Color.FromArgb(255, 240, 246, 252)
            nPass.BackColor = Color.FromArgb(255, 33, 40, 48)
            nPass.ForeColor = Color.FromArgb(255, 240, 246, 252)
            cPass.BackColor = Color.FromArgb(255, 33, 40, 48)
            cPass.ForeColor = Color.FromArgb(255, 240, 246, 252)
        End If
    End Sub

    Private Sub oPass_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles oPass.TextChanged

    End Sub
End Class