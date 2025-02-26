Public Class displayItem
    Private Sub displayItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'updating the supplier list
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
            supplier.DataSource = dt
            supplier.DisplayMember = "sName"
            If dt.Rows.Count = 0 Then
                MessageBox.Show("No Supplier found update list ", "Store Wise", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Store Wise", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try

        updateDatagrid("select * from itemTable")

        'setting up dark mode
        If (DMode) Then
            Me.BackColor = Color.FromArgb(255, 13, 17, 23)
            For i = 1 To 12
                Dim lbl As Label = Me.Controls("Label" & i)
                lbl.ForeColor = Color.FromArgb(255, 240, 246, 252)
            Next
            DataGridView1.BackgroundColor = Color.FromArgb(255, 33, 40, 48)
            DataGridView1.DefaultCellStyle.BackColor = Color.FromArgb(255, 33, 40, 48)
            DataGridView1.DefaultCellStyle.ForeColor = Color.FromArgb(255, 240, 246, 252)
            DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 33, 40, 48)
            DataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(255, 240, 246, 252)
            DataGridView1.GridColor = Color.FromArgb(255, 240, 246, 252)
            Filter.BackColor = Color.FromArgb(255, 33, 40, 48)
            Filter.ForeColor = Color.FromArgb(255, 240, 246, 252)
            itemName.BackColor = Color.FromArgb(255, 33, 40, 48)
            itemName.ForeColor = Color.FromArgb(255, 240, 246, 252)
            iUnit.BackColor = Color.FromArgb(255, 33, 40, 48)
            iUnit.ForeColor = Color.FromArgb(255, 240, 246, 252)
            rol.BackColor = Color.FromArgb(255, 33, 40, 48)
            rol.ForeColor = Color.FromArgb(255, 240, 246, 252)
            itemCost.BackColor = Color.FromArgb(255, 33, 40, 48)
            itemCost.ForeColor = Color.FromArgb(255, 240, 246, 252)
            itemSP.BackColor = Color.FromArgb(255, 33, 40, 48)
            itemSP.ForeColor = Color.FromArgb(255, 240, 246, 252)
            itemGST.BackColor = Color.FromArgb(255, 33, 40, 48)
            itemGST.ForeColor = Color.FromArgb(255, 240, 246, 252)
            nameSupplier.BackColor = Color.FromArgb(255, 33, 40, 48)
            nameSupplier.ForeColor = Color.FromArgb(255, 240, 246, 252)
            price.BackColor = Color.FromArgb(255, 33, 40, 48)
            price.ForeColor = Color.FromArgb(255, 240, 246, 252)
            supplier.BackColor = Color.FromArgb(255, 33, 40, 48)
            supplier.ForeColor = Color.FromArgb(255, 240, 246, 252)
            gstFilter.BackColor = Color.FromArgb(255, 33, 40, 48)
            gstFilter.ForeColor = Color.FromArgb(255, 240, 246, 252)
        End If

    End Sub

    Sub updateDatagrid(sqlToEx As String)
        Dim conn As New OleDb.OleDbConnection
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Saksham\Documents\StoreWise.accdb"
        'update the datagrid table
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            Dim sql As String = sqlToEx
            Dim cmd As New OleDb.OleDbCommand(sql, conn)
            Dim da As New OleDb.OleDbDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)
            DataGridView1.DataSource = dt
            DataGridView1.Columns(1).Width = 200
            DataGridView1.Columns(2).Width = 200
            DataGridView1.Columns(0).HeaderText = "ID"
            DataGridView1.Columns(1).HeaderText = "Supplier Name"
            DataGridView1.Columns(2).HeaderText = "Item Name"
            DataGridView1.Columns(3).HeaderText = "Unit"
            DataGridView1.Columns(4).HeaderText = "ROL"
            DataGridView1.Columns(5).HeaderText = "Cost Price"
            DataGridView1.Columns(6).HeaderText = "Sell Price"
            DataGridView1.Columns(7).HeaderText = "GST Rate"
        Catch ex As Exception
            MessageBox.Show("No Item found update list ", "Store Wise", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Filter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Filter.SelectedIndexChanged
        If Filter.SelectedIndex = 0 Then
            price.ReadOnly = True
            price.Text = ""
            supplier.Enabled = False
            gstFilter.Enabled = False
            updateDatagrid("select * from itemTable")
        ElseIf Filter.SelectedIndex = 1 Then
            price.ReadOnly = True
            price.Text = ""
            supplier.Enabled = True
            gstFilter.Enabled = False
        ElseIf Filter.SelectedIndex = 2 Then
            price.ReadOnly = False
            price.Text = ""
            supplier.Enabled = False
            gstFilter.Enabled = False
        ElseIf Filter.SelectedIndex = 3 Then
            price.ReadOnly = False
            price.Text = ""
            supplier.Enabled = False
            gstFilter.Enabled = False
        ElseIf Filter.SelectedIndex = 4 Then
            price.ReadOnly = True
            price.Text = ""
            supplier.Enabled = False
            gstFilter.Enabled = True
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        itemName.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString
        iUnit.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString
        rol.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString
        itemCost.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString
        itemSP.Text = DataGridView1.CurrentRow.Cells(6).Value.ToString
        itemGST.SelectedItem = DataGridView1.CurrentRow.Cells(7).Value.ToString & "%"
        nameSupplier.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
    End Sub

    Private Sub DataGridView1_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.RowHeaderMouseClick
        itemName.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString
        iUnit.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString
        rol.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString
        itemCost.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString
        itemSP.Text = DataGridView1.CurrentRow.Cells(6).Value.ToString
        itemGST.SelectedItem = DataGridView1.CurrentRow.Cells(7).Value.ToString & "%"
        nameSupplier.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
    End Sub

    Private Sub price_TextChanged(sender As Object, e As EventArgs) Handles price.TextChanged
        If price.Text.Trim = "" Then
            MessageBox.Show("Please enter a price", "Store Wise", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf Filter.SelectedIndex = 2 Then
            updateDatagrid("select * from itemTable where costUnit > " & CDbl(price.Text))
        ElseIf Filter.SelectedIndex = 3 Then
            updateDatagrid("select * from itemTable where costUnit < " & CDbl(price.Text))
        End If
    End Sub

    Private Sub supplier_SelectedIndexChanged(sender As Object, e As EventArgs) Handles supplier.SelectedIndexChanged
        updateDatagrid("select * from itemTable where sName = '" & supplier.Text & "'")
    End Sub

    Private Sub gstFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles gstFilter.SelectedIndexChanged
        updateDatagrid("select * from itemTable where gst = " & CInt(gstFilter.Text.Replace("%", "")))
    End Sub
End Class