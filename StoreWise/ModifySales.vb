Public Class ModifySales

    Private Sub phone_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If (Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Delete)) Then
            e.Handled = True
            MessageBox.Show("Price must be in Numbers.")
        End If
    End Sub

    Private Sub itemQuantity_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If (Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Delete)) Then
            e.Handled = True
            MessageBox.Show("Quantity must be in Numbers.")
        End If
    End Sub

    Private Sub cancle_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        customerName.Text = ""
        customerAddress.Text = ""
        phone.Text = ""
        eMail.Text = ""
        itemQuantity.Text = ""
    End Sub

    Private Sub save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If (itemName.Text.Trim = "" Or itemQuantity.Text.Trim = "" Or customerName.Text.Trim = "" Or phone.Text.Trim = "" Or itemQuantity.Text.Trim = "") Then
            MessageBox.Show("Please Fill All Fields")
        Else

        End If
    End Sub

    Private Sub ModifySales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ModifySales_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class