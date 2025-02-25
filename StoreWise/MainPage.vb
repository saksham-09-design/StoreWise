Public Class MainPage

    Private Sub ExitToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem1.Click
        End
    End Sub

    Private Sub AddToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddToolStripMenuItem.Click
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

    Private Sub SearchToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim searchItem As New SearchItem
        searchItem.MdiParent = Me
        searchItem.Show()
    End Sub

    Private Sub AddItemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddItemToolStripMenuItem.Click
        Dim addItem As New AddItem
        addItem.MdiParent = Me
        addItem.Show()
    End Sub

    Private Sub AddToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddToolStripMenuItem2.Click
        Dim addSales As New addSales
        addSales.MdiParent = Me
        addSales.Show()
    End Sub

    Private Sub MainPage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub ModifyToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModifyToolStripMenuItem2.Click
        Dim sales As New sales()
        sales.MdiParent = Me
        sales.Show()
    End Sub

    Private Sub DeleteToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem2.Click
        Dim sales As New sales()
        sales.MdiParent = Me
        sales.Show()
    End Sub

    Private Sub DisplayToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DisplayToolStripMenuItem.Click
        Dim sales As New sales()
        sales.MdiParent = Me
        sales.Show()
    End Sub

    Private Sub AddToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddToolStripMenuItem4.Click
        Dim supplier As New addSupplier()
        supplier.MdiParent = Me
        supplier.Show()
    End Sub

    Private Sub ModifyToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModifyToolStripMenuItem4.Click
        Dim supplier As New modifySupplier()
        supplier.MdiParent = Me
        supplier.Show()
    End Sub

    Private Sub DeleteToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem4.Click
        Dim supplier As New deleteSupplier()
        supplier.MdiParent = Me
        supplier.Show()
    End Sub

    Private Sub ChangeCredentialsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangeCredentialsToolStripMenuItem.Click
        Dim mUser As New modifyUser()
        mUser.MdiParent = Me
        mUser.Show()
    End Sub

    Private Sub ChangeThemeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangeThemeToolStripMenuItem.Click
        'Saving the Dark Mode Prefrences in the database
        DMode = Not DMode
        Dim conn As OleDb.OleDbConnection
        Dim cmd As OleDb.OleDbCommand
        conn = New OleDb.OleDbConnection
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Saksham\Documents\StoreWise.accdb"
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        Dim sql As String = "update userTable set mode = " & CBool(DMode)
        cmd = New OleDb.OleDbCommand(sql, conn)
        cmd.ExecuteNonQuery()
        conn.Close()
    End Sub

    Private Sub SearchToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchToolStripMenuItem4.Click
    End Sub

    Private Sub DisplayToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles DisplayToolStripMenuItem4.Click
        Dim supplier As New displaySupplier()
        supplier.MdiParent = Me
        supplier.Show()
    End Sub
End Class