Public Class MainPage

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub MainPage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub dashboard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dashboard.Click
    End Sub

    Private Sub ManageToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

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
End Class