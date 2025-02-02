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
End Class