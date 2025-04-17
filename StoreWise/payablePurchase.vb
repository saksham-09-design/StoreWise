Public Class payablePurchase
    Private Sub purchase_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim conn As New OleDb.OleDbConnection
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Saksham\Documents\StoreWise.accdb"
        'updating the supplier list
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
        'setting up data grid
        fetch_data_UG("select ID, sName, pDate, amtDis, type from purchaseTable where type = 'Credit'")

        'setting up dark mode
        If DMode Then
            Me.BackColor = Color.FromArgb(255, 13, 17, 23)
            For i = 1 To 5
                Dim lbl As Label = Me.Controls("Label" & i)
                lbl.ForeColor = Color.FromArgb(255, 240, 246, 252)
            Next
            DataGridView1.BackgroundColor = Color.FromArgb(255, 13, 17, 23)
            DataGridView1.DefaultCellStyle.BackColor = Color.FromArgb(255, 13, 17, 23)
            DataGridView1.DefaultCellStyle.ForeColor = Color.FromArgb(255, 240, 246, 252)
            DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 13, 17, 23)
            DataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(255, 240, 246, 252)
            DataGridView1.GridColor = Color.FromArgb(255, 240, 246, 252)
            filter.BackColor = Color.FromArgb(255, 13, 17, 23)
            filter.ForeColor = Color.FromArgb(255, 240, 246, 252)
            supplierName.BackColor = Color.FromArgb(255, 13, 17, 23)
            supplierName.ForeColor = Color.FromArgb(255, 240, 246, 252)
            fromDate.BackColor = Color.FromArgb(255, 13, 17, 23)
            fromDate.ForeColor = Color.FromArgb(255, 240, 246, 252)
            fromDate.CalendarMonthBackground = Color.FromArgb(255, 13, 17, 23)
            fromDate.CalendarTitleBackColor = Color.FromArgb(255, 13, 17, 23)
            fromDate.CalendarTitleForeColor = Color.FromArgb(255, 240, 246, 252)
            fromDate.CalendarTrailingForeColor = Color.FromArgb(255, 240, 246, 252)
            fromDate.CalendarForeColor = Color.FromArgb(255, 240, 246, 252)
            toDate.BackColor = Color.FromArgb(255, 13, 17, 23)
            toDate.ForeColor = Color.FromArgb(255, 240, 246, 252)
            toDate.CalendarMonthBackground = Color.FromArgb(255, 13, 17, 23)
            toDate.CalendarTitleBackColor = Color.FromArgb(255, 13, 17, 23)
            toDate.CalendarTitleForeColor = Color.FromArgb(255, 240, 246, 252)
            toDate.CalendarTrailingForeColor = Color.FromArgb(255, 240, 246, 252)
            toDate.CalendarForeColor = Color.FromArgb(255, 240, 246, 252)
        End If

    End Sub

    'fetching Data and updating the datagrid
    Sub fetch_data_UG(sqlI As String)
        Dim conn As New OleDb.OleDbConnection
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Saksham\Documents\StoreWise.accdb"
        Try
            Dim sql As String = sqlI
            Dim da As New OleDb.OleDbDataAdapter(sql, conn)
            Dim dt As New DataTable
            dt.Clear()
            da.Fill(dt)
            DataGridView1.DataSource = dt
            DataGridView1.Columns(0).Width = 100
            DataGridView1.Columns(1).Width = 270
            DataGridView1.Columns(2).Width = 160
            DataGridView1.Columns(3).Width = 160
            DataGridView1.Columns(4).Width = 160

            DataGridView1.Columns(0).HeaderText = "Transaction ID"
            DataGridView1.Columns(1).HeaderText = "Supplier Name"
            DataGridView1.Columns(2).HeaderText = "Date"
            DataGridView1.Columns(3).HeaderText = "Amount"
            DataGridView1.Columns(4).HeaderText = "Type"
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Store Wise", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub
    Private Sub itemName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles filter.SelectedIndexChanged
        If filter.Text = "Custom Dates" Then
            Dim dateFrom As Date = CDate(Format(toDate.Value, "Short Date"))
            Dim dateTo As Date = CDate(Format(fromDate.Value, "Short Date"))
            fetch_data_UG("select ID, sName, pDate, amtDis, type from purchaseTable where type = 'Credit' and pDate >= #" & dateFrom & "# and pDate <= #" & dateTo & "#")
            fromDate.Enabled = True
            toDate.Enabled = True
            supplierName.Enabled = False
        ElseIf filter.Text = "Supplier Name" Then
            supplierName.Enabled = True
            fromDate.Enabled = False
            toDate.Enabled = False
        ElseIf filter.Text = "Today" Then
            Dim dateT As Date = CDate(Format(Now(), "Short Date"))
            fetch_data_UG("select ID, sName, pDate, amtDis, type from purchaseTable where type = 'Credit' and pDate = #" & dateT & "#")
            fromDate.Enabled = False
            toDate.Enabled = False
            supplierName.Enabled = False
        ElseIf filter.Text = "Yesterday" Then
            Dim dateT As Date = CDate(Format(Now().AddDays(-1), "Short Date"))
            fetch_data_UG("select ID, sName, pDate, amtDis, type from purchaseTable where type = 'Credit' and pDate = #" & dateT & "#")
            fromDate.Enabled = False
            toDate.Enabled = False
            supplierName.Enabled = False
        ElseIf filter.Text = "Past 7 days" Then
            Dim dateT As Date = CDate(Format(Now().AddDays(-7), "Short Date"))
            fetch_data_UG("select ID, sName, pDate, amtDis, type from purchaseTable where type = 'Credit' and pDate >= #" & dateT & "#")
            fromDate.Enabled = False
            toDate.Enabled = False
            supplierName.Enabled = False
        ElseIf filter.Text = "Past 1 Month" Then
            Dim dateT As Date = CDate(Format(Now().AddMonths(-1), "Short Date"))
            fetch_data_UG("select ID, sName, pDate, amtDis, type from purchaseTable where type = 'Credit' and pDate >= #" & dateT & "#")
            fromDate.Enabled = False
            toDate.Enabled = False
            supplierName.Enabled = False
        ElseIf filter.Text = "Past 1 Year" Then
            Dim dateT As Date = CDate(Format(Now().AddYears(-1), "Short Date"))
            fetch_data_UG("select ID, sName, pDate, amtDis, type from purchaseTable where type = 'Credit' and pDate >= #" & dateT & "#")
            fromDate.Enabled = False
            toDate.Enabled = False
            supplierName.Enabled = False
        Else
            fetch_data_UG("select ID, sName, pDate, amtDis, type from purchaseTable where type = 'Credit'")
            fromDate.Enabled = False
            toDate.Enabled = False
            supplierName.Enabled = False
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub supplierName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles supplierName.SelectedIndexChanged
        'Updating datagrid according to supplier
        fetch_data_UG("select ID, sName, pDate, amtDis, type from purchaseTable where type = 'Credit' and sName = '" & supplierName.Text & "'")
    End Sub

    Private Sub transactionFromDate_ValueChanged(sender As Object, e As EventArgs) Handles fromDate.ValueChanged
        Dim dateFrom As Date = CDate(Format(toDate.Value, "Short Date"))
        Dim dateTo As Date = CDate(Format(fromDate.Value, "Short Date"))
        fetch_data_UG("select ID, sName, pDate, amtDis, type from purchaseTable where type = 'Credit' and pDate >= #" & dateFrom & "# and pDate <= #" & dateTo & "#")
    End Sub

    Private Sub transactioToDate_ValueChanged(sender As Object, e As EventArgs) Handles toDate.ValueChanged
        Dim dateFrom As Date = CDate(Format(toDate.Value, "Short Date"))
        Dim dateTo As Date = CDate(Format(fromDate.Value, "Short Date"))
        fetch_data_UG("select ID, sName, pDate, amtDis, type from purchaseTable where type = 'Credit' and pDate >= #" & dateFrom & "# and pDate <= #" & dateTo & "#")
    End Sub

    Private Sub DataGridView1_RowHeaderMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.RowHeaderMouseDoubleClick
        Dim payPer = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        Dim supplier = DataGridView1.Rows(e.RowIndex).Cells(1).Value
        If MessageBox.Show("Payment Paid for this Transactio?", "StoreWise", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
            Dim con As New OleDb.OleDbConnection
            con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Saksham\Documents\StoreWise.accdb"
            Try
                If con.State = ConnectionState.Closed Then
                    con.Open()
                End If

                Dim sql As String = "Update purchaseTable set type = 'Cash' where ID = " & payPer
                Dim sql2 As String = "Update supplierTable set sBalance = sBalance - " & DataGridView1.Rows(e.RowIndex).Cells(3).Value & " where sName = '" & supplier & "'"
                Dim cmd2 As New OleDb.OleDbCommand(sql2, con)
                cmd2.ExecuteNonQuery()
                Dim cmd As New OleDb.OleDbCommand(sql, con)
                If cmd.ExecuteNonQuery() Then
                    MessageBox.Show("Changes Done", "StoreWise", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    fetch_data_UG("select ID, sName, pDate, amtDis, type from purchaseTable where type = 'Credit'")
                End If
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Storewise", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

    End Sub

    Private Sub purchase_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        fetch_data_UG("select ID, sName, pDate, amtDis, type from purchaseTable where type = 'Credit'")
    End Sub
End Class