Public Class displayItem
    Private Sub displayItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'fetch Supplier Details
        Dim conn As New OleDb.OleDbConnection
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Saksham\Documents\StoreWise.accdb"
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            Dim sql As String = "SELECT sName FROM supplierTable"
            Dim cmd As New OleDb.OleDbCommand(sql, conn)
            Dim da As New OleDb.OleDbDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)
            supplierName.DataSource = dt
            supplierName.DisplayMember = "sName"
            If dt.Rows.Count = 0 Then
                MessageBox.Show("No Supplier found update list ", "Store Wise", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Store Wise", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try

        'fetching item data and updating datagrid view
        UpdateGrid("SELECT itemName, sName, unit, reOrderLevel, costUnit, sellUnit, gst from itemTable")

    End Sub

    Private Sub UpdateGrid(sqlR As String)
        Dim conn As New OleDb.OleDbConnection
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Saksham\Documents\StoreWise.accdb"
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            Dim sql As String = sqlR
            Dim cmd As New OleDb.OleDbCommand(sql, conn)
            Dim da As New OleDb.OleDbDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)
            DataGridView1.DataSource = dt
            DataGridView1.Columns(0).HeaderText = "Item Name"
            DataGridView1.Columns(1).HeaderText = "Supplier Name"
            DataGridView1.Columns(2).HeaderText = "Unit"
            DataGridView1.Columns(3).HeaderText = "Reorder Level"
            DataGridView1.Columns(4).HeaderText = "Cost Price"
            DataGridView1.Columns(5).HeaderText = "Sell Price"
            DataGridView1.Columns(6).HeaderText = "GST"

            DataGridView1.Columns(0).Width = 200
            DataGridView1.Columns(1).Width = 200
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Store Wise", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub filter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles filter.SelectedIndexChanged
        If filter.SelectedIndex = 0 Then
            supplierName.Enabled = False
            pTo.Enabled = False
            pFrom.Enabled = False
            UpdateGrid("SELECT itemName, sName, unit, reOrderLevel, costUnit, sellUnit, gst from itemTable")
        ElseIf filter.SelectedIndex = 1 Then
            supplierName.Enabled = False
            pTo.Enabled = True
            pFrom.Enabled = True
            If pTo.Text.Trim = "" Or pTo.Text.Trim = "" Then
                UpdateGrid("SELECT itemName, sName, unit, reOrderLevel, costUnit, sellUnit, gst from itemTable")
            Else
                Dim sql As String = "SELECT itemName, sName, unit, reOrderLevel, costUnit, sellUnit, gst from itemTable where costUnit between " & pFrom.Text & " and " & pTo.Text
                UpdateGrid(sql)
            End If
        ElseIf filter.SelectedIndex = 2 Then
            supplierName.Enabled = True
            pTo.Enabled = False
            pFrom.Enabled = False
            Dim sql As String = "SELECT itemName, sName, unit, reOrderLevel, costUnit, sellUnit, gst from itemTable where sName = '" & supplierName.Text & "'"
            UpdateGrid(sql)
        End If
    End Sub

    Private Sub supplierName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles supplierName.SelectedIndexChanged
        Dim sql As String = "SELECT itemName, sName, unit, reOrderLevel, costUnit, sellUnit, gst from itemTable where sName = '" & supplierName.Text & "'"
        UpdateGrid(sql)
    End Sub

    Private Sub pFrom_TextChanged(sender As Object, e As EventArgs) Handles pFrom.TextChanged
        If pTo.Text.Trim <> "" Then
            Dim sql As String = "SELECT itemName, sName, unit, reOrderLevel, costUnit, sellUnit, gst from itemTable where costUnit between " & pFrom.Text & " and " & pTo.Text
            UpdateGrid(sql)
        End If
    End Sub

    Private Sub pTo_TextChanged(sender As Object, e As EventArgs) Handles pTo.TextChanged
        If pFrom.Text.Trim <> "" Then
            Dim sql As String = "SELECT itemName, sName, unit, reOrderLevel, costUnit, sellUnit, gst from itemTable where costUnit between " & pFrom.Text & " and " & pTo.Text
            UpdateGrid(sql)
        End If
    End Sub
End Class