Public Class loginPage
    Private uName = "Saksham"
    Private pass = "admin"

    Private Sub login_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles login.Click
        Dim u_name As String
        Dim password As String
        u_name = TextBox1.Text
        password = TextBox2.Text
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

    End Sub
End Class