Public Class AddItem

    Private Sub cancle_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cancle.Click
        Me.Close()
    End Sub

    Private Sub clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clear.Click
        itemName.Clear()
        itemUnit.SelectedIndex = 5
        itemQuantity.Clear()
        itemCost.Clear()
        itemSP.Clear()
        itemGST.SelectedIndex = 4
    End Sub

    Private Sub save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles save.Click
        If (itemName.Text = "" Or itemQuantity.Text = "" Or itemCost.Text = "" Or itemSP.Text = "") Then
            MessageBox.Show("Please Fill All Fields")
        Else
            MessageBox.Show("Entered Data is: " & itemName.Text & itemQuantity.Text & itemCost.Text & itemSP.Text & itemUnit.SelectedItem & itemGST.SelectedItem)
        End If
    End Sub

    Private Sub AddItem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        itemUnit.SelectedIndex = 5
        itemGST.SelectedIndex = 4
    End Sub

    Private Sub itemQuantity_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles itemQuantity.KeyPress
        If (Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Delete)) Then
            e.Handled = True
            MessageBox.Show("Quantity must be in Numbers.")
        End If
    End Sub

    Private Sub itemCost_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles itemCost.KeyPress
        If (Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Delete)) Then
            e.Handled = True
            MessageBox.Show("Price must be in Numbers.")
        End If
    End Sub

    Private Sub itemSP_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles itemSP.KeyPress
        If (Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Delete)) Then
            e.Handled = True
            MessageBox.Show("Price must be in Numbers.")
        End If
    End Sub

    Private Sub itemQuantity_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles itemQuantity.TextChanged

    End Sub
End Class