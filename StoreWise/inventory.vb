Public Class inventory
    Dim itCount As Integer = 0
    Private Sub inventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        update_inv("SELECT inventoryTable.itemId, inventoryTable.itemName, inventoryTable.quantity, itemTable.reOrderLevel FROM inventoryTable, itemTable where inventoryTable.itemName = itemTable.itemName")

        'setting up dark mode
        If DMode Then
            Me.BackColor = Color.FromArgb(255, 13, 17, 23)
            For i = 1 To 2
                Dim lbl As Label = Me.Controls("Label" & i)
                lbl.ForeColor = Color.FromArgb(255, 240, 246, 252)
            Next
            DataGridView1.BackgroundColor = Color.FromArgb(255, 13, 17, 23)
            DataGridView1.DefaultCellStyle.BackColor = Color.FromArgb(255, 13, 17, 23)
            DataGridView1.DefaultCellStyle.ForeColor = Color.FromArgb(255, 240, 246, 252)
            DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 13, 17, 23)
            DataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(255, 240, 246, 252)
            DataGridView1.GridColor = Color.FromArgb(255, 240, 246, 252)
            RadioButton1.BackColor = Color.FromArgb(255, 13, 17, 23)
            RadioButton1.ForeColor = Color.FromArgb(255, 240, 246, 252)
            RadioButton2.BackColor = Color.FromArgb(255, 13, 17, 23)
            RadioButton2.ForeColor = Color.FromArgb(255, 240, 246, 252)
        End If
    End Sub

    'update inventory grid
    Sub update_inv(sqlInp As String)
        Dim conn As New OleDb.OleDbConnection
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Saksham\Documents\StoreWise.accdb"
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            Dim sql As String = sqlInp
            Dim cmd As New OleDb.OleDbCommand(sql, conn)
            Dim da As New OleDb.OleDbDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)
            itCount = dt.Rows.Count
            DataGridView1.DataSource = dt
            DataGridView1.Columns(0).HeaderText = "Item ID"
            DataGridView1.Columns(1).HeaderText = "Item Name"
            DataGridView1.Columns(2).HeaderText = "Quantity"
            DataGridView1.Columns(3).HeaderText = "ReOrderLevel"

            DataGridView1.Columns(0).Width = 100
            DataGridView1.Columns(1).Width = 160
            DataGridView1.Columns(2).Width = 100
            DataGridView1.Columns(3).Width = 100
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Store Wise", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        update_inv("SELECT inventoryTable.itemId, inventoryTable.itemName, inventoryTable.quantity, itemTable.reOrderLevel FROM inventoryTable, itemTable where inventoryTable.itemName = itemTable.itemName")
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        update_inv("SELECT inventoryTable.itemId, inventoryTable.itemName, inventoryTable.quantity, itemTable.reOrderLevel FROM inventoryTable, itemTable where inventoryTable.itemName = itemTable.itemName and inventoryTable.quantity < itemTable.reOrderLevel")
    End Sub
End Class