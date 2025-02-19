Public Class DeleteItem

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Label1.Visible = True
        Label2.Visible = True
        Label3.Visible = True
        Label4.Visible = True
        Label6.Visible = True
        Label7.Visible = True
        Label8.Visible = True
        Label5.Visible = True
        ComboBox2.Visible = True
        itemName.Visible = True
        itemUnit.Visible = True
        itemCost.Visible = True
        itemSP.Visible = True
        itemGST.Visible = True
        Delete.Visible = True
        cancle.Visible = True
        itemName.Text = ComboBox1.SelectedItem
    End Sub
    Private Sub cancle_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cancle.Click
        Me.Close()
    End Sub

    Private Sub DeleteItem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BackColor = Color.FromArgb(255, 13, 17, 23)
        For i = 1 To 8
            Dim lbl As Label = Me.Controls("Label" & i)
            lbl.ForeColor = Color.FromArgb(255, 240, 246, 252)
        Next
        Delete.BackColor = Color.FromArgb(255, 31, 111, 235)
        cancle.BackColor = Color.FromArgb(255, 31, 111, 235)
        Delete.ForeColor = Color.FromArgb(255, Color.White)
        cancle.ForeColor = Color.FromArgb(255, Color.White)
        ComboBox1.BackColor = Color.FromArgb(255, 33, 40, 48)
        ComboBox1.ForeColor = Color.FromArgb(255, 240, 246, 252)
        itemName.BackColor = Color.FromArgb(255, 33, 40, 48)
        itemName.ForeColor = Color.FromArgb(255, 240, 246, 252)
        itemUnit.BackColor = Color.FromArgb(255, 33, 40, 48)
        itemUnit.ForeColor = Color.FromArgb(255, 240, 246, 252)
        itemCost.BackColor = Color.FromArgb(255, 33, 40, 48)
        itemCost.ForeColor = Color.FromArgb(255, 240, 246, 252)
        itemGST.BackColor = Color.FromArgb(255, 33, 40, 48)
        itemGST.ForeColor = Color.FromArgb(255, 240, 246, 252)
        itemSP.BackColor = Color.FromArgb(255, 33, 40, 48)
        itemSP.ForeColor = Color.FromArgb(255, 240, 246, 252)
        ComboBox2.BackColor = Color.FromArgb(255, 33, 40, 48)
        ComboBox2.ForeColor = Color.FromArgb(255, 240, 246, 252)
    End Sub
End Class