Public Class sales

    Private Sub itemName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles filter.SelectedIndexChanged

        'fetching according to filters
        If filter.Text = "Custom Dates" Then
            Dim dateFrom As Date = CDate(Format(toDate.Value, "Short Date"))
            Dim dateTo As Date = CDate(Format(fromDate.Value, "Short Date"))
            fetch_data_UG("select ID, cName, tDate, phoneNumber, tType, bAmt from saleTable where tDate >= #" & dateFrom & "# and tDate <= #" & dateTo & "#")
            fromDate.Enabled = True
            toDate.Enabled = True
            customerName.Enabled = False
        ElseIf filter.Text = "Customer Name" Then
            customerName.Enabled = True
            fromDate.Enabled = False
            toDate.Enabled = False
        ElseIf filter.Text = "Today" Then
            Dim dateT As Date = CDate(Format(Now(), "Short Date"))
            fetch_data_UG("select ID, cName, tDate, phoneNumber, tType, bAmt from saleTable where tDate = #" & dateT & "#")
            fromDate.Enabled = False
            toDate.Enabled = False
            customerName.Enabled = False
        ElseIf filter.Text = "Yesterday" Then
            Dim dateT As Date = CDate(Format(Now().AddDays(-1), "Short Date"))
            fetch_data_UG("select ID, cName, tDate, phoneNumber, tType, bAmt from saleTable where tDate = #" & dateT & "#")
            fromDate.Enabled = False
            toDate.Enabled = False
            customerName.Enabled = False
        ElseIf filter.Text = "Past 7 days" Then
            Dim dateT As Date = CDate(Format(Now().AddDays(-7), "Short Date"))
            fetch_data_UG("select ID, cName, tDate, phoneNumber, tType, bAmt from saleTable where tDate >= #" & dateT & "#")
            fromDate.Enabled = False
            toDate.Enabled = False
            customerName.Enabled = False
        ElseIf filter.Text = "Past 1 Month" Then
            Dim dateT As Date = CDate(Format(Now().AddMonths(-1), "Short Date"))
            fetch_data_UG("select ID, cName, tDate, phoneNumber, tType, bAmt from saleTable where tDate >= #" & dateT & "#")
            fromDate.Enabled = False
            toDate.Enabled = False
            customerName.Enabled = False
        ElseIf filter.Text = "Past 1 Year" Then
            Dim dateT As Date = CDate(Format(Now().AddYears(-1), "Short Date"))
            fetch_data_UG("select ID, cName, tDate, phoneNumber, tType, bAmt from saleTable where tDate >= #" & dateT & "#")
            fromDate.Enabled = False
            toDate.Enabled = False
            customerName.Enabled = False
        Else
            fetch_data_UG("select ID, cName, tDate, phoneNumber, tType, bAmt from saleTable")
            fromDate.Enabled = False
            toDate.Enabled = False
            customerName.Enabled = False
        End If
    End Sub

    Private Sub sales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conn As New OleDb.OleDbConnection
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Saksham\Documents\StoreWise.accdb"


        'updating the customer list
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            Dim sql As String = "SELECT DISTINCT cName FROM saleTable"
            Dim cmd As New OleDb.OleDbCommand(sql, conn)
            Dim da As New OleDb.OleDbDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)
            customerName.DataSource = dt
            customerName.DisplayMember = "cName"
            If dt.Rows.Count = 0 Then
                MessageBox.Show("No Customer found", "Store Wise", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Store Wise", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try


        'setting up data grid
        fetch_data_UG("select ID, cName, tDate, phoneNumber, tType, bAmt from saleTable")

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
            customerName.BackColor = Color.FromArgb(255, 13, 17, 23)
            customerName.ForeColor = Color.FromArgb(255, 240, 246, 252)
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
            DataGridView1.Columns(5).Width = 160

            DataGridView1.Columns(0).HeaderText = "Transaction ID"
            DataGridView1.Columns(1).HeaderText = "Customer Name"
            DataGridView1.Columns(2).HeaderText = "Date"
            DataGridView1.Columns(3).HeaderText = "Phone Number"
            DataGridView1.Columns(4).HeaderText = "Type"
            DataGridView1.Columns(4).HeaderText = "Amount"

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.ToString, "Store Wise", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub customerName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles customerName.SelectedIndexChanged
        fetch_data_UG("select ID, cName, tDate, phoneNumber, tType, bAmt from saleTable where cName = '" & customerName.Text & "'")
    End Sub

    Private Sub fromDate_ValueChanged(sender As Object, e As EventArgs) Handles fromDate.ValueChanged
        Dim dateFrom As Date = CDate(Format(toDate.Value, "Short Date"))
        Dim dateTo As Date = CDate(Format(fromDate.Value, "Short Date"))
        fetch_data_UG("select ID, cName, tDate, phoneNumber, tType, bAmt from saleTable where pDate >= #" & dateFrom & "# and pDate <= #" & dateTo & "#")
    End Sub

    Private Sub toDate_ValueChanged(sender As Object, e As EventArgs) Handles toDate.ValueChanged
        Dim dateFrom As Date = CDate(Format(toDate.Value, "Short Date"))
        Dim dateTo As Date = CDate(Format(fromDate.Value, "Short Date"))
        fetch_data_UG("select ID, cName, tDate, phoneNumber, tType, bAmt from saleTable where pDate >= #" & dateFrom & "# and pDate <= #" & dateTo & "#")
    End Sub

    Private Sub DataGridView1_RowHeaderMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.RowHeaderMouseDoubleClick
        salId = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        If dSale = True Then
            Dim sl As New deleteSales()
            sl.MdiParent = MainPage
            sl.Show()
        ElseIf disSale = True Then
            Dim sl As New displaySales()
            sl.MdiParent = MainPage
            sl.Show()
        End If
    End Sub

    Private Sub sales_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        fetch_data_UG("select ID, cName, tDate, phoneNumber, tType, bAmt from saleTable")
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class