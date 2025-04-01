Imports System.Threading.Tasks
Imports System.Data.OleDb


Public Class dashboardLoading

    Private Async Sub dashboardLoading_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Label1.Text = "Generating Useful Insights Just For You <3"
        Label2.Text = "Please Wait"

        Await Task.Delay(100)

        Await settingDashboard()

        Dim dash As New Dashboard()
        dash.MdiParent = MainPage
        dash.Show()

        Me.Close()
    End Sub

    Private Async Function settingDashboard() As Task
        Dim con As New OleDb.OleDbConnection
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Saksham\Documents\StoreWise.accdb"

        'fetching total sales
        Try
            Dim sql As String = "select sum(bAmt) from saleTable"
            Dim da As New OleDb.OleDbDataAdapter(sql, con)
            Dim dt As New DataTable
            da.Fill(dt)
            TotalSales = CSng(dt.Rows(0).Item(0))
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
            TotalPurhcase = CSng(dt.Rows(0).Item(0))
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Storewise", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try

        ProgressBar1.Value = 10

        'fetching Net Payables
        Try
            Dim sql As String = "select sum(sBalance) from supplierTable"
            Dim da As New OleDb.OleDbDataAdapter(sql, con)
            Dim dt As New DataTable
            da.Fill(dt)
            netPayable = CSng(dt.Rows(0).Item(0))
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Storewise", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try

        'fetching net receivables
        Try
            Dim sql As String = "select sum(bAmt) from saleTable where tType = 'Credit'"
            Dim da As New OleDb.OleDbDataAdapter(sql, con)
            Dim dt As New DataTable
            da.Fill(dt)
            netRecievable = CSng(dt.Rows(0).Item(0))
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Storewise", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try

        ProgressBar1.Value = 20


        'fetching market & Purchase value of stocks
        Try
            Dim sql As String = "select itemName from itemTable"
            Dim da As New OleDb.OleDbDataAdapter(sql, con)
            Dim dt As New DataTable
            da.Fill(dt)
            Dim count As Integer = dt.Rows.Count
            Dim itemsList As String() = New String(count - 1) {}
            Dim totalMKV As Integer = 0
            Dim totalPV As Integer = 0
            For i = 0 To count - 1
                itemsList(i) = dt.Rows(i).Item(0)
            Next
            For Each item In itemsList
                Dim sql1 As String = "select inventoryTable.quantity * itemTable.sellUnit from inventoryTable, itemTable where inventoryTable.itemName = '" & item & "' and itemTable.itemName = '" & item & "'"
                Dim da1 As New OleDb.OleDbDataAdapter(sql1, con)
                Dim dt1 As New DataTable
                da1.Fill(dt1)
                totalMKV += CSng(dt1.Rows(0).Item(0))
                Dim sql2 As String = "select inventoryTable.quantity * itemTable.costUnit from inventoryTable, itemTable where inventoryTable.itemName = '" & item & "' and itemTable.itemName = '" & item & "'"
                Dim da2 As New OleDb.OleDbDataAdapter(sql2, con)
                Dim dt2 As New DataTable
                da2.Fill(dt2)
                totalPV += CSng(dt2.Rows(0).Item(0))
            Next

            'Market value
            stockMarketValue = totalMKV


            'purchase value
            stockPurchaseValue = totalPV

            ProgressBar1.Value = 30

        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Storewise", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try


        'fetching cash  sales
        Try
            Dim sql As String = "select sum(bAmt) from saleTable where tType = 'Cash'"
            Dim da As New OleDb.OleDbDataAdapter(sql, con)
            Dim dt As New DataTable
            da.Fill(dt)
            cashSales = CSng(dt.Rows(0).Item(0))
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Storewise", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try

        'fetching  credit sales
        Try
            Dim sql As String = "select sum(bAmt) from saleTable where tType = 'Credit'"
            Dim da As New OleDb.OleDbDataAdapter(sql, con)
            Dim dt As New DataTable
            da.Fill(dt)
            creditSales = CSng(dt.Rows(0).Item(0))
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Storewise", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
        ProgressBar1.Value = 40


        'fetching cash purchase
        Try
            Dim sql As String = "select sum(amtDis) from purchaseTable where type = 'Cash'"
            Dim da As New OleDb.OleDbDataAdapter(sql, con)
            Dim dt As New DataTable
            da.Fill(dt)
            cashPurchase = CSng(dt.Rows(0).Item(0))
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Storewise", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try

        'fetching credit purchase
        Try
            Dim sql As String = "select sum(amtDis) from purchaseTable where type = 'Credit'"
            Dim da As New OleDb.OleDbDataAdapter(sql, con)
            Dim dt As New DataTable
            da.Fill(dt)
            creditPurchase = CSng(dt.Rows(0).Item(0))
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Storewise", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try

        ProgressBar1.Value = 50


        'fetching output gst
        Try
            Dim sql As String = "select sum(gst * quantity) from sSupportTable"
            Dim da As New OleDb.OleDbDataAdapter(sql, con)
            Dim dt As New DataTable
            da.Fill(dt)
            outputGST = CSng(dt.Rows(0).Item(0))
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Storewise", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try

        'fetching input gst
        Dim finalInputGST As Single = 0.0
        Dim itemsListSsupport As String() = {}

        'fetching sold items
        Try
            Dim sql As String = "select distinct itemName from sSupportTable"
            Dim da As New OleDb.OleDbDataAdapter(sql, con)
            Dim dt As New DataTable
            da.Fill(dt)
            Dim count As Integer = dt.Rows.Count
            itemsListSsupport = New String(count - 1) {}
            For i = 0 To count - 1
                itemsListSsupport(i) = dt.Rows(i).Item(0)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Storewise", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try

        'fetching total quantity of the unique items and calculating the input gst

        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If

            For Each item In itemsListSsupport
                Dim itemQ As Single = 0.0
                Dim costUnit As Single = 0.0
                Dim totalCost As Single = 0.0
                Dim gstI As Single = 0.0
                Dim gsAmount As Single = 0.0


                'fetching total quantity
                Dim sql As String = "select sum(quantity) from sSupportTable where itemName= '" & item & "'"
                Dim da As New OleDb.OleDbDataAdapter(sql, con)
                Dim dt As New DataTable
                da.Fill(dt)
                itemQ = CSng(dt.Rows(0).Item(0))

                'fetching total amount on which gst should be calculated
                Dim sql1 As String = "select costUnit from itemTable where itemName = '" & item & "'"
                Dim da1 As New OleDb.OleDbDataAdapter(sql1, con)
                Dim dt1 As New DataTable
                da1.Fill(dt1)
                costUnit = CSng(dt1.Rows(0).Item(0))

                'calculating total cost
                totalCost = itemQ * costUnit


                'fetching gst % from database
                Dim sql2 As String = "select gst from itemTable where itemName = '" & item & "'"
                Dim da2 As New OleDbDataAdapter(sql2, con)
                Dim dt2 As New DataTable
                da2.Fill(dt2)
                gstI = CSng(dt.Rows(0).Item(0))


                'calculating total gst of the items
                gsAmount = (totalCost * gstI) / 100

                finalInputGST += gsAmount

            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Storewise", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try

        inputGST = finalInputGST
        ProgressBar1.Value = 90


        'fetching overall profit or loss
        netProfit = cashSales + creditSales - cashPurchase - creditPurchase + netRecievable - netPayable + stockMarketValue - gstPayable

        ProgressBar1.Value = 100


    End Function

    Private Sub dashboardLoading_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
End Class