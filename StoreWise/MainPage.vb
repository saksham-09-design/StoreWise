Public Class MainPage


    'text animation support variables
    Dim textPosition As Integer
    Dim textSpeed As Integer = 5
    Dim colorIndex As Integer = 0
    Dim lightColors As Color() = {Color.LightBlue, Color.LightGreen, Color.LightPink, Color.LightYellow, Color.LightCyan, Color.LightCoral, Color.LightSkyBlue}


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

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
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
        'Initial setting for name animation
        Label1.Left = Panel1.Width
        textPosition = Label1.Left
        Timer1.Interval = 50
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'main animation
        textPosition -= textSpeed
        Label1.Left = textPosition

        Label1.ForeColor = lightColors(colorIndex)
        colorIndex += 1
        If colorIndex = lightColors.Length Then
            colorIndex = 0
        End If

        If Label1.Right < 0 Then
            textPosition = Panel1.Width
        End If
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

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
        dPur = False
        disPur = True

        Dim pur As New purchase()
        pur.MdiParent = Me
        pur.Show()
    End Sub

    Private Sub DisplayToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles DisplayToolStripMenuItem4.Click
        Dim supplier As New displaySupplier()
        supplier.MdiParent = Me
        supplier.Show()
    End Sub

    Private Sub AddToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem1.Click
        Dim purchase As New addPurchase()
        purchase.MdiParent = Me
        purchase.Show()
    End Sub

    Private Sub DeleteToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem1.Click
        dPur = True
        disPur = False

        Dim pur As New purchase()
        pur.MdiParent = Me
        pur.Show()
    End Sub

    Private Sub DisplayToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DisplayToolStripMenuItem1.Click
        Dim inv As New inventory()
        inv.MdiParent = Me
        inv.Show()
    End Sub
End Class