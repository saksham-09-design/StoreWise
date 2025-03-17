Public Class displaySales
    Private Sub displaySales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conn As New OleDb.OleDbConnection
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Saksham\Documents\StoreWise.accdb"


        'fetching Transaction Details
        Try
            Dim sql As String = "SELECT * FROM saleTable WHERE ID = " & salId
            Dim da As New OleDb.OleDbDataAdapter(sql, conn)
            Dim dt As New DataTable
            dt.Clear()
            da.Fill(dt)
            customerName.Text = dt.Rows(0).Item(1)
            dateTrans.Text = dt.Rows(0).Item(2)
            phone.Text = dt.Rows(0).Item(3)
            tId.Text = salId
            discountt.Text = dt.Rows(0).Item(5) & "%"
            fBill.Text = "₹" & dt.Rows(0).Item(6) & "/-"
            Dim type As String = dt.Rows(0).Item(4)
            If type = "Cash" Then
                ttype.Text = "Cash"
            Else
                ttype.Text = "Credit"
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Store Wise", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try


        'fetching items from database
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            Dim sql As String = "SELECT * FROM sSupportTable WHERE billId = " & salId
            Dim cmd As New OleDb.OleDbCommand(sql, conn)
            Dim da As New OleDb.OleDbDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)
            For i = 0 To dt.Rows.Count - 1
                itemList.Items.Add(dt.Rows(i).Item(1))
                quantityList.Items.Add(dt.Rows(i).Item(2))
                priceList.Items.Add(dt.Rows(i).Item(3))
                gstAmt.Items.Add(dt.Rows(i).Item(4))
                totalPrice.Items.Add(dt.Rows(i).Item(5))
            Next
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Store Wise", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try


        'setting up dark mode
        If (DMode) Then
            Me.BackColor = Color.FromArgb(255, 13, 17, 23)
            For i = 1 To 13
                Dim lbl As Label = Me.Controls("Label" & i)
                lbl.ForeColor = Color.FromArgb(255, 240, 246, 252)
            Next
            Print.BackColor = Color.FromArgb(255, 31, 111, 235)
            cancle.BackColor = Color.FromArgb(255, 31, 111, 235)
            Print.ForeColor = Color.FromArgb(255, Color.White)
            cancle.ForeColor = Color.FromArgb(255, Color.White)
            Print.BackColor = Color.FromArgb(255, 31, 111, 235)
            Print.ForeColor = Color.FromArgb(255, Color.White)
            dateTrans.ForeColor = Color.FromArgb(255, 240, 246, 252)
            tId.ForeColor = Color.FromArgb(255, 240, 246, 252)
            itemList.BackColor = Color.FromArgb(255, 33, 40, 48)
            itemList.ForeColor = Color.FromArgb(255, 240, 246, 252)
            quantityList.BackColor = Color.FromArgb(255, 33, 40, 48)
            quantityList.ForeColor = Color.FromArgb(255, 240, 246, 252)
            priceList.BackColor = Color.FromArgb(255, 33, 40, 48)
            priceList.ForeColor = Color.FromArgb(255, 240, 246, 252)
            gstAmt.BackColor = Color.FromArgb(255, 33, 40, 48)
            gstAmt.ForeColor = Color.FromArgb(255, 240, 246, 252)
            totalPrice.BackColor = Color.FromArgb(255, 33, 40, 48)
            totalPrice.ForeColor = Color.FromArgb(255, 240, 246, 252)
            discountt.ForeColor = Color.FromArgb(255, 240, 246, 252)
            fBill.ForeColor = Color.FromArgb(255, 240, 246, 252)
            ttype.ForeColor = Color.FromArgb(255, 240, 246, 252)
            customerName.ForeColor = Color.FromArgb(255, 240, 246, 252)
            phone.ForeColor = Color.FromArgb(255, 240, 246, 252)
        End If
    End Sub

    Private Sub cancle_Click(sender As Object, e As EventArgs) Handles cancle.Click
        Me.Close()
    End Sub

    Private Sub Print_Click(sender As Object, e As EventArgs) Handles Print.Click
        Dim bil As New bill
        bil.Show()
    End Sub
End Class