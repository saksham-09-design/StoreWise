Public Class SearchItem

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Label1.Visible = True
        Label2.Visible = True
        Label3.Visible = True
        Label4.Visible = True
        Label5.Visible = True
        Label6.Visible = True
        Label7.Visible = True
        Label8.Visible = True
        itemName.Visible = True
        itemUnit.Visible = True
        itemQuantity.Visible = True
        itemCost.Visible = True
        itemSP.Visible = True
        itemGST.Visible = True
        cancle.Visible = True
        reOrder.Visible = True
        Label5.Visible = True
        itemName.Text = ComboBox1.SelectedItem
    End Sub
    Private Sub cancle_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cancle.Click
        Me.Close()
    End Sub

    Private Sub SearchItem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class