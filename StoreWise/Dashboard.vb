Public Class Dashboard
    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim con As New OleDb.OleDbConnection
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Saksham\Documents\StoreWise.accdb"

        'fetching total sales
        Try
            Dim sql As String = "select sum(bAmt) from saleTable"
            Dim da As New OleDb.OleDbDataAdapter(sql, con)
            Dim dt As New DataTable
            da.Fill(dt)
            tSales.Text = "₹" & Format(dt.Rows(0)(0), "Standard") & "/-"
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Storewise", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try

        'fetching total puchase
        Try
            Dim sql As String = "select sum(amtDis) from purchaseTable"
            Dim da As New OleDb.OleDbDataAdapter(sql, con)
            Dim dt As New DataTable
            da.Fill(dt)
            tPur.Text = "₹" & Format(dt.Rows(0)(0), "Standard") & "/-"
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Storewise", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Modify_Click(sender As Object, e As EventArgs) Handles Modify.Click
        dSale = False
        disSale = True

        Dim sales As New sales()
        sales.MdiParent = MainPage
        sales.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        dPur = False
        disPur = True

        Dim pur As New purchase()
        pur.MdiParent = MainPage
        pur.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim inv As New inventory()
        inv.MdiParent = Me
        inv.Show()
    End Sub
End Class