Public Class ModifyItem

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Label1.Visible = True
        Label2.Visible = True
        Label3.Visible = True
        Label4.Visible = True
        Label6.Visible = True
        Label7.Visible = True
        Label8.Visible = True
        itemName.Visible = True
        itemUnit.Visible = True
        itemCost.Visible = True
        itemSP.Visible = True
        itemGST.Visible = True
        Modify.Visible = True
        clear.Visible = True
        cancle.Visible = True
        itemName.Text = ComboBox1.SelectedItem
    End Sub

    Private Sub Modify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Modify.Click
        If (itemName.Text = "" Or itemCost.Text = "" Or itemSP.Text = "") Then
            MessageBox.Show("Please Fill All Fields")
        Else
            MessageBox.Show("Modified Data is: " & itemName.Text & itemCost.Text & itemSP.Text & itemUnit.SelectedItem & itemGST.SelectedItem)
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

End Class