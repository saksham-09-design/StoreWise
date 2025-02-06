Public Class MainPage

    Private Sub ExitToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem1.Click
        End
    End Sub

    Private Sub AddToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddToolStripMenuItem.Click
        Dim addItem As New AddItem
        addItem.MdiParent = Me
        addItem.Show()
    End Sub

    Private Sub addItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addItem.Click
        Dim addItem As New AddItem
        addItem.MdiParent = Me
        addItem.Show()
    End Sub

    Private Sub ModifyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModifyToolStripMenuItem.Click
        Dim modifyItem As New ModifyItem
        modifyItem.MdiParent = Me
        modifyItem.Show()
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        Dim deleteItem As New DeleteItem
        deleteItem.MdiParent = Me
        deleteItem.Show()
    End Sub

    Private Sub SearchToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchToolStripMenuItem.Click
        Dim searchItem As New SearchItem
        searchItem.MdiParent = Me
        searchItem.Show()
    End Sub

    Private Sub UpdateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateToolStripMenuItem.Click
        Dim updateStock As New updateStock
        updateStock.MdiParent = Me
        updateStock.Show()
    End Sub

    Private Sub AddItemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddItemToolStripMenuItem.Click
        Dim addItem As New AddItem
        addItem.MdiParent = Me
        addItem.Show()
    End Sub

    Private Sub UpdateStockToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateStockToolStripMenuItem.Click
        Dim updateStock As New updateStock
        updateStock.MdiParent = Me
        updateStock.Show()
    End Sub

    Private Sub AddToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddToolStripMenuItem2.Click
        Dim addSales As New SalesPage
        addSales.MdiParent = Me
        addSales.Show()
    End Sub
End Class