Public Class addSales

    Private Sub phone_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles phone.KeyPress
        If (Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Delete)) Then
            e.Handled = True
            MessageBox.Show("Price must be in Numbers.")
        End If
    End Sub

    Private Sub itemQuantity_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles itemQuantity.KeyPress
        If (Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Delete)) Then
            e.Handled = True
            MessageBox.Show("Quantity must be in Numbers.")
        End If
    End Sub

    Private Sub cancle_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cancle.Click
        Me.Close()
    End Sub

    Private Sub clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clear.Click
        customerName.Text = ""
        customerAddress.Text = ""
        phone.Text = ""
        eMail.Text = ""
        itemQuantity.Text = ""
    End Sub

    Private Sub save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles save.Click
        If (itemName.Text.Trim = "" Or itemQuantity.Text.Trim = "" Or customerName.Text.Trim = "" Or phone.Text.Trim = "" Or itemQuantity.Text.Trim = "") Then
            MessageBox.Show("Please Fill All Fields")
        Else

        End If
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub SalesPage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Add.Click
        If itemQuantity.Text <> "" Then
            If CInt(itemQuantity.Text) > 0 Then
                itemList.Items.Add(itemName.Text)
                quantityList.Items.Add(itemQuantity.Text)
                itemQuantity.Text = ""
                itemName.SelectedIndex = 0
            Else
                MessageBox.Show("Quantity Can't be Zero or Negative", "Store Wise", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Quantity Can't be Empty", "Store Wise", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub itemList_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles itemList.DoubleClick
        If (MessageBox.Show("Delete this item?", "Store Wise", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) = Windows.Forms.DialogResult.Yes Then
            Dim ind As Integer
            ind = itemList.SelectedIndex
            If (ind < 0) Then
                MessageBox.Show("Item list is empty.", "Store Wise", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                itemList.Items.RemoveAt(ind)
                quantityList.Items.RemoveAt(ind)
            End If
        End If

    End Sub

    Private Sub quantityList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles quantityList.SelectedIndexChanged

    End Sub
End Class