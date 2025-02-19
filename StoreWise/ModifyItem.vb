Public Class ModifyItem

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Label1.Visible = True
        Label2.Visible = True
        Label3.Visible = True
        Label4.Visible = True
        Label6.Visible = True
        Label7.Visible = True
        Label8.Visible = True
        Label9.Visible = True
        itemName.Visible = True
        itemUnit.Visible = True
        itemCost.Visible = True
        itemSP.Visible = True
        itemGST.Visible = True
        Modify.Visible = True
        clear.Visible = True
        cancle.Visible = True
        reOrder.Visible = True
        Label5.Visible = True
        supplier.Visible = True

        itemName.Text = ComboBox1.SelectedItem
    End Sub

    Private Sub Modify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Modify.Click
        If (itemName.Text.Trim = "" Or itemCost.Text.Trim = "" Or itemSP.Text.Trim = "" Or reOrder.Text.Trim = "") Then
            MessageBox.Show("Please Fill All Fields")
        Else
            MessageBox.Show("Modified Data is: " & itemName.Text & itemCost.Text & itemSP.Text & itemUnit.SelectedItem & itemGST.SelectedItem)
        End If
    End Sub

    Private Sub itemCost_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles itemCost.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not e.KeyChar = "."c AndAlso Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MessageBox.Show("Quantity must be in Numbers.", "Store Wise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf e.KeyChar = "."c AndAlso itemCost.Text.Contains(".") Then
            e.Handled = True
            MessageBox.Show("Only one decimal point is allowed.", "Store Wise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub itemSP_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles itemSP.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not e.KeyChar = "."c AndAlso Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MessageBox.Show("Quantity must be in Numbers.", "Store Wise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf e.KeyChar = "."c AndAlso itemSP.Text.Contains(".") Then
            e.Handled = True
            MessageBox.Show("Only one decimal point is allowed.", "Store Wise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub reOrder_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles reOrder.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not e.KeyChar = "."c AndAlso Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MessageBox.Show("Quantity must be in Numbers.", "Store Wise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf e.KeyChar = "."c AndAlso itemSP.Text.Contains(".") Then
            e.Handled = True
            MessageBox.Show("Only one decimal point is allowed.", "Store Wise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clear.Click
        itemName.Clear()
        itemUnit.SelectedIndex = 5
        reOrder.Clear()
        itemCost.Clear()
        itemSP.Clear()
        itemGST.SelectedIndex = 4
    End Sub

    Private Sub cancle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cancle.Click
        Me.Close()
    End Sub

    Private Sub ModifyItem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BackColor = Color.FromArgb(255, 13, 17, 23)
        For i = 1 To 9
            Dim lbl As Label = Me.Controls("Label" & i)
            lbl.ForeColor = Color.FromArgb(255, 240, 246, 252)
        Next
        Modify.BackColor = Color.FromArgb(255, 31, 111, 235)
        clear.BackColor = Color.FromArgb(255, 31, 111, 235)
        cancle.BackColor = Color.FromArgb(255, 31, 111, 235)
        Modify.ForeColor = Color.FromArgb(255, Color.White)
        clear.ForeColor = Color.FromArgb(255, Color.White)
        cancle.ForeColor = Color.FromArgb(255, Color.White)
        ComboBox1.BackColor = Color.FromArgb(255, 33, 40, 48)
        ComboBox1.ForeColor = Color.FromArgb(255, 240, 246, 252)
        itemName.BackColor = Color.FromArgb(255, 33, 40, 48)
        itemName.ForeColor = Color.FromArgb(255, 240, 246, 252)
        itemUnit.BackColor = Color.FromArgb(255, 33, 40, 48)
        itemUnit.ForeColor = Color.FromArgb(255, 240, 246, 252)
        reOrder.BackColor = Color.FromArgb(255, 33, 40, 48)
        reOrder.ForeColor = Color.FromArgb(255, 240, 246, 252) '
        itemCost.BackColor = Color.FromArgb(255, 33, 40, 48)
        itemCost.ForeColor = Color.FromArgb(255, 240, 246, 252)
        itemGST.BackColor = Color.FromArgb(255, 33, 40, 48)
        itemGST.ForeColor = Color.FromArgb(255, 240, 246, 252)
        itemSP.BackColor = Color.FromArgb(255, 33, 40, 48)
        itemSP.ForeColor = Color.FromArgb(255, 240, 246, 252)
        supplier.BackColor = Color.FromArgb(255, 33, 40, 48)
        supplier.ForeColor = Color.FromArgb(255, 240, 246, 252)
    End Sub
End Class