Public Class updateStock
    Private Sub cancle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cancle.Click
        Me.Close()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Label2.Visible = True
        Label4.Visible = True
        Label5.Visible = True
        itemName.Visible = True
        itemQuantity.Visible = True
        add.Visible = True
        remove.Visible = True
        updateSt.Visible = True
        cancle.Visible = True

        itemName.Text = ComboBox1.SelectedItem
    End Sub

    Private Sub itemQuantity_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles itemQuantity.KeyPress
        If (Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Delete)) Then
            e.Handled = True
            MessageBox.Show("Quantity must be in Numbers.")
        End If
    End Sub

End Class