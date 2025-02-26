Public Class displaySupplier
    Private Sub displaySupplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Sql As String = "select * from supplierTable"
        fetchData(Sql)

        'setting up dark mode
        If (DMode) Then
            Me.BackColor = Color.FromArgb(255, 13, 17, 23)
            For i = 1 To 5
                Dim lbl As Label = Me.Controls("Label" & i)
                lbl.ForeColor = Color.FromArgb(255, 240, 246, 252)
            Next
            supplierGrid.BackgroundColor = Color.FromArgb(255, 33, 40, 48)
            supplierGrid.DefaultCellStyle.BackColor = Color.FromArgb(255, 33, 40, 48)
            supplierGrid.DefaultCellStyle.ForeColor = Color.FromArgb(255, 240, 246, 252)
            supplierGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 33, 40, 48)
            supplierGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(255, 240, 246, 252)
            supplierGrid.GridColor = Color.FromArgb(255, 240, 246, 252)
            Filter.BackColor = Color.FromArgb(255, 33, 40, 48)
            Filter.ForeColor = Color.FromArgb(255, 240, 246, 252)
            Filter.FlatStyle = FlatStyle.Popup
            Filter.DropDownStyle = ComboBoxStyle.DropDownList
            supplierName.BackColor = Color.FromArgb(255, 33, 40, 48)
            supplierName.ForeColor = Color.FromArgb(255, 240, 246, 252)
            phone.BackColor = Color.FromArgb(255, 33, 40, 48)
            phone.ForeColor = Color.FromArgb(255, 240, 246, 252)
            eMail.BackColor = Color.FromArgb(255, 33, 40, 48)
            eMail.ForeColor = Color.FromArgb(255, 240, 246, 252)
        End If
    End Sub

    'fetch All data
    Private Sub fetchData(sql_rec As String)
        Try
            Dim conn As New OleDb.OleDbConnection
            conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Saksham\Documents\StoreWise.accdb"
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            Dim sql As String = sql_rec
            Dim cmd As New OleDb.OleDbCommand(sql, conn)
            Dim da As OleDb.OleDbDataAdapter
            da = New OleDb.OleDbDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)
            supplierGrid.DataSource = dt
            supplierGrid.Columns(0).Width = 100
            supplierGrid.Columns(1).Width = 200
            supplierGrid.Columns(2).Width = 200
            supplierGrid.Columns(3).Width = 300
            supplierGrid.Columns(4).Width = 100

            supplierGrid.Columns(0).HeaderText = "Supplier ID"
            supplierGrid.Columns(1).HeaderText = "Supplier Name"
            supplierGrid.Columns(2).HeaderText = "Phone"
            supplierGrid.Columns(3).HeaderText = "Email"
            supplierGrid.Columns(4).HeaderText = "Balance"
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("No Supplier found update list ", "Store Wise", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub supplierGrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles supplierGrid.CellContentClick
        supplierName.Text = supplierGrid.CurrentRow.Cells(1).Value
        phone.Text = supplierGrid.CurrentRow.Cells(2).Value
        eMail.Text = supplierGrid.CurrentRow.Cells(3).Value
    End Sub

    Private Sub supplierGrid_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles supplierGrid.RowHeaderMouseClick
        supplierName.Text = supplierGrid.CurrentRow.Cells(1).Value
        phone.Text = supplierGrid.CurrentRow.Cells(2).Value
        eMail.Text = supplierGrid.CurrentRow.Cells(3).Value
    End Sub

    Private Sub Filter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Filter.SelectedIndexChanged
        If Filter.SelectedIndex = 0 Then
            Dim Sql As String = "select * from supplierTable"
            fetchData(Sql)
        ElseIf Filter.SelectedIndex = 1 Then
            Dim Sql As String = "select * from supplierTable where sBalance = 0"
            fetchData(Sql)
        Else
            Dim Sql As String = "select * from supplierTable where sBalance > 0"
            fetchData(Sql)
        End If
        supplierName.Clear()
        phone.Clear()
        eMail.Clear()
    End Sub
End Class