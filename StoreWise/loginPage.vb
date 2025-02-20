Public Class loginPage
    Private uName = "Saksham"
    Private pass = "admin"

    Private Sub login_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles login.Click
        Dim u_name As String
        Dim password As String
        u_name = eUName.Text
        password = eUPass.Text
        If (u_name = uName And password = pass) Then
            MessageBox.Show("Welcome " & uName)
            MainPage.Show()
            Me.Close()
        Else
            MessageBox.Show("Invalid Username or Passowrd")
        End If

    End Sub

    Private Sub cancle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cancle.Click
        End
    End Sub

    Private Sub loginPage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If (DMode) Then
            Me.BackColor = Color.FromArgb(255, 13, 17, 23)
            For i = 1 To 3
                Dim lbl As Label = Me.Controls("Label" & i)
                lbl.ForeColor = Color.FromArgb(255, 240, 246, 252)
            Next
            login.BackColor = Color.FromArgb(255, 31, 111, 235)
            login.BackColor = Color.FromArgb(255, 31, 111, 235)
            cancle.BackColor = Color.FromArgb(255, 31, 111, 235)
            cancle.BackColor = Color.FromArgb(255, 31, 111, 235)
            eUName.BackColor = Color.FromArgb(255, 33, 40, 48)
            eUName.ForeColor = Color.FromArgb(255, 240, 246, 252)
            eUPass.BackColor = Color.FromArgb(255, 33, 40, 48)
            eUPass.ForeColor = Color.FromArgb(255, 240, 246, 252)
        End If
    End Sub
End Class