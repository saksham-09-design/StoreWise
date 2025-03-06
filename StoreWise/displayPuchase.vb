Public Class displayPuchase
    Private Sub displayPuchase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conn As New OleDb.OleDbConnection
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Saksham\Documents\StoreWise.accdb"


        'fetching Transaction Details
        Try
            Dim sql As String = "SELECT * FROM purchaseTable WHERE ID = " & purId
            Dim da As New OleDb.OleDbDataAdapter(sql, conn)
            Dim dt As New DataTable
            dt.Clear()
            da.Fill(dt)
            supplierName.Text = dt.Rows(0).Item(1)
            dateTrans.Text = dt.Rows(0).Item(2)
            tId.Text = purId
            discountt.Text = dt.Rows(0).Item(3) & "%"
            fBill.Text = "₹" & dt.Rows(0).Item(4) & "/-"
            Dim type As String = dt.Rows(0).Item(5)
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
        Dim conn2 As New OleDb.OleDbConnection
        conn2.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Saksham\Documents\StoreWise.accdb"
        Try
            If conn2.State = ConnectionState.Closed Then
                conn2.Open()
            End If
            Dim sql As String = "SELECT * FROM pSupportTable WHERE billId = " & purId
            Dim cmd As New OleDb.OleDbCommand(sql, conn2)
            Dim da As New OleDb.OleDbDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)
            For i = 0 To dt.Rows.Count - 1
                itemList.Items.Add(dt.Rows(i).Item(2))
                quantityList.Items.Add(dt.Rows(i).Item(3))
                priceList.Items.Add(dt.Rows(i).Item(4))
                gstAmt.Items.Add(dt.Rows(i).Item(5))
                totalPrice.Items.Add(dt.Rows(i).Item(6))
            Next
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Store Wise", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn2.Close()
        End Try




        'setting up dark mode
        If (DMode) Then
            Me.BackColor = Color.FromArgb(255, 13, 17, 23)
            For i = 1 To 12
                Dim lbl As Label = Me.Controls("Label" & i)
                lbl.ForeColor = Color.FromArgb(255, 240, 246, 252)
            Next
            cancle.BackColor = Color.FromArgb(255, 31, 111, 235)
            cancle.ForeColor = Color.FromArgb(255, Color.White)
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
            supplierName.ForeColor = Color.FromArgb(255, 240, 246, 252)
        End If
    End Sub
End Class