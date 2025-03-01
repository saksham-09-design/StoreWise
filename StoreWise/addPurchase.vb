Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class addPurchase

    Private Sub purchase_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
            supplierNameList.DataSource = dt
            supplierNameList.DisplayMember = "sName"
            If dt.Rows.Count = 0 Then
                MessageBox.Show("No Supplier found update list ", "Store Wise", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Store Wise", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try

        'fetch Item Details
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            Dim sql As String = "SELECT itemName FROM itemTable where sName = '" & supplierNameList.Text & "'"
            Dim cmd As New OleDb.OleDbCommand(sql, conn)
            Dim da As New OleDb.OleDbDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)
            itemName.DataSource = dt
            itemName.DisplayMember = "itemName"
            If dt.Rows.Count = 0 Then
                MessageBox.Show("No Item found update list ", "Store Wise", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Store Wise", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try

        fetchTransId()

        'setting up dark mode
        If (DMode) Then
            Me.BackColor = Color.FromArgb(255, 13, 17, 23)
            For i = 1 To 14
                Dim lbl As Label = Me.Controls("Label" & i)
                lbl.ForeColor = Color.FromArgb(255, 240, 246, 252)
            Next
            save.BackColor = Color.FromArgb(255, 31, 111, 235)
            clear.BackColor = Color.FromArgb(255, 31, 111, 235)
            cancle.BackColor = Color.FromArgb(255, 31, 111, 235)
            save.ForeColor = Color.FromArgb(255, Color.White)
            clear.ForeColor = Color.FromArgb(255, Color.White)
            cancle.ForeColor = Color.FromArgb(255, Color.White)
            Add.BackColor = Color.FromArgb(255, 31, 111, 235)
            Add.ForeColor = Color.FromArgb(255, Color.White)
            transactionDate.BackColor = Color.FromArgb(255, 33, 40, 48)
            transactionDate.ForeColor = Color.FromArgb(255, 240, 246, 252)
            tID.BackColor = Color.FromArgb(255, 33, 40, 48)
            tID.ForeColor = Color.FromArgb(255, 240, 246, 252)
            itemQuantity.BackColor = Color.FromArgb(255, 33, 40, 48)
            itemQuantity.ForeColor = Color.FromArgb(255, 240, 246, 252)
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
            Discount.BackColor = Color.FromArgb(255, 33, 40, 48)
            Discount.ForeColor = Color.FromArgb(255, 240, 246, 252)
            fBill.ForeColor = Color.FromArgb(255, 240, 246, 252)
            cash.ForeColor = Color.FromArgb(255, 240, 246, 252)
            credit.ForeColor = Color.FromArgb(255, 240, 246, 252)
            supplierNameList.BackColor = Color.FromArgb(255, 33, 40, 48)
            supplierNameList.ForeColor = Color.FromArgb(255, 240, 246, 252)
            itemName.BackColor = Color.FromArgb(255, 33, 40, 48)
            itemName.ForeColor = Color.FromArgb(255, 240, 246, 252)
            transactionDate.CalendarMonthBackground = Color.FromArgb(255, 33, 40, 48)
            transactionDate.CalendarTitleBackColor = Color.FromArgb(255, 33, 40, 48)
            transactionDate.CalendarTitleForeColor = Color.FromArgb(255, 240, 246, 252)
            transactionDate.CalendarTrailingForeColor = Color.FromArgb(255, 240, 246, 252)
            transactionDate.CalendarForeColor = Color.FromArgb(255, 240, 246, 252)
        End If


    End Sub

    'Fetching Transaction id
    Sub fetchTransId()
        Dim conn As New OleDb.OleDbConnection
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Saksham\Documents\StoreWise.accdb"
        Dim transID As Integer
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            Dim sql As String = "SELECT ID FROM purchaseTable"
            Dim cmd As New OleDb.OleDbCommand(sql, conn)
            Dim da As New OleDb.OleDbDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)
            Dim rowCount As Integer = dt.Rows.Count
            rowCount -= 1
            Dim a() As Integer = New Integer(rowCount) {}   'Elements baad m assign krenge
            For i = 0 To rowCount
                a(i) = dt.Rows(i).Item(0)
            Next
            transID = a.Max + 1
            tID.Text = transID
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Store Wise", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Add_Click(sender As Object, e As EventArgs) Handles Add.Click
        If itemQuantity.Text <> "" Then
            If CInt(itemQuantity.Text) > 0 Then
                Dim price As Single
                Dim quantity As Integer
                Dim fAmt As Single
                Dim fAmount As String
                Dim finalAmount As Single
                Dim gst As Single


                itemList.Items.Add(itemName.Text)                                   'Quantity and Price Logic
                quantityList.Items.Add(itemQuantity.Text)

                'fetching price from database

                Dim priceItem As Single
                Dim conn As New OleDb.OleDbConnection
                conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Saksham\Documents\StoreWise.accdb"
                Try
                    If conn.State = ConnectionState.Closed Then
                        conn.Open()
                    End If
                    Dim sql As String = "SELECT sellUnit FROM itemTable WHERE itemName = '" & itemName.Text & "'"
                    Dim cmd As New OleDb.OleDbCommand(sql, conn)
                    Dim da As New OleDb.OleDbDataAdapter(cmd)
                    Dim dt As New DataTable
                    da.Fill(dt)
                    priceItem = CInt(dt.Rows(0).Item(0))
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message, "Store Wise", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    conn.Close()
                End Try

                priceList.Items.Add(priceItem)
                quantity = CInt(quantityList.Items.Item(quantityList.Items.Count - 1))  'Quantity Logic


                'fetching gst from database
                Dim gstItem As Single
                Try
                    If conn.State = ConnectionState.Closed Then
                        conn.Open()
                    End If
                    Dim sql As String = "SELECT gst FROM itemTable WHERE itemName = '" & itemName.Text & "'"
                    Dim cmd As New OleDb.OleDbCommand(sql, conn)
                    Dim da As New OleDb.OleDbDataAdapter(cmd)
                    Dim dt As New DataTable
                    da.Fill(dt)
                    gstItem = CInt(dt.Rows(0).Item(0))
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message, "Store Wise", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    conn.Close()
                End Try

                gst = ((priceItem * gstItem) / 100)                                              'GST Logic
                gstAmt.Items.Add(gst)


                fAmt = (priceItem + gst) * quantity                                         'Total Amount Logic
                totalPrice.Items.Add(fAmt)
                itemQuantity.Text = ""
                itemList.SelectedIndex = 0



                fAmount = fBill.Text                                                    'Final Bill Amount Logic
                fAmount = fAmount.Replace("₹"c, "")
                fAmount = fAmount.Replace("/"c, "")
                fAmount = fAmount.Replace("-"c, "")
                finalAmount = CSng(fAmount)
                finalAmount += fAmt
                fBill.Text = "₹" & Format(finalAmount, "Standard") & "/-"
                If Discount.Text <> "" Then
                    Discount_Cal()
                End If
            Else
                MessageBox.Show("Quantity Can't be Zero or Negative", "Store Wise", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Quantity Can't be Empty", "Store Wise", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub itemList_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles itemList.DoubleClick
        If (MessageBox.Show("Delete this item?", "Store Wise", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) = Windows.Forms.DialogResult.Yes Then
            Dim ind As Integer
            ind = itemList.SelectedIndex
            If (ind < 0) Then
                MessageBox.Show("Item list is empty.", "Store Wise", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim fAmount As String
                Dim finalAmount As Single
                Dim fAmt As Single
                Dim gst As Single
                Dim price As Single
                Dim disc As Single
                Dim quantity As Single

                quantity = CSng(quantityList.Items.Item(ind))       'getting quantity

                gst = CSng(gstAmt.Items.Item(ind))                  'getting gst

                price = CSng(priceList.Items.Item(ind))             'getting price

                If Discount.Text <> "" Then                         'getting Discount %age
                    disc = CSng(Discount.Text)
                Else
                    disc = 0
                End If


                fAmount = fBill.Text                                    'Final Bill Amount Logic
                fAmount = fAmount.Replace("₹"c, "")
                fAmount = fAmount.Replace("/"c, "")
                fAmount = fAmount.Replace("-"c, "")
                finalAmount = CSng(fAmount)
                fAmt = finalAmount - ((price + gst - (((price + gst) * disc) / 100)) * quantity)    'Calculation of Final bill amount
                finalAmount = fAmt
                fBill.Text = "₹" & Format(finalAmount, "Standard") & "/-"



                itemList.Items.RemoveAt(ind)                'Removing the previous values
                quantityList.Items.RemoveAt(ind)
                gstAmt.Items.RemoveAt(ind)
                totalPrice.Items.RemoveAt(ind)
                priceList.Items.RemoveAt(ind)
            End If
        End If
    End Sub


    'Handling Discount Validation
    Private Sub Discount_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Discount.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not e.KeyChar = "."c AndAlso Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MessageBox.Show("Price must be in Numbers.", "Store Wise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf e.KeyChar = "."c AndAlso Discount.Text.Contains(".") Then
            e.Handled = True
            MessageBox.Show("Only one decimal point is allowed.", "Store Wise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf Discount.Text = "" And e.KeyChar = "."c Then
            e.Handled = True
            MessageBox.Show("Enter Numeric Value!", "Store Wise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    'Discount Validation
    Private Sub Discount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Discount.TextChanged
        If Discount.Text <> "" Then
            If CSng(Discount.Text) > 100 Then
                MessageBox.Show("Discount Should be less than 100%", "Store Wise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If
        Discount_Cal()
    End Sub

    Private Sub Discount_Cal()
        Dim fAmount As Single
        Dim discountRate As Single

        For Each i In totalPrice.Items  'calculating the total price
            fAmount += CSng(i)
        Next
        If Discount.Text = "" Then
            discountRate = 0
        Else
            discountRate = CSng(Discount.Text)
        End If
        Dim disAmt = (fAmount * discountRate) / 100     'calculating the discount

        fBill.Text = "₹" & Format((fAmount - disAmt), "Standard") & "/-"
    End Sub

    Private Sub itemQuantity_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles itemQuantity.KeyPress
        If (Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Delete)) Then
            e.Handled = True
            MessageBox.Show("Quantity must be in Numbers.")
        End If
    End Sub

    Private Sub cancle_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cancle.Click
        Me.Close()
    End Sub

    Private Sub clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clear.Click
        supplierNameList.SelectedIndex = 1
        itemQuantity.Text = ""
    End Sub

    Private Sub save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles save.Click
        'validating Items
        If itemList.Items.Count = 0 Then
            MessageBox.Show("Please Add Items", "Store Wise", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            Dim conn As New OleDb.OleDbConnection
            conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Saksham\Documents\StoreWise.accdb"

            'Fetching Date
            Dim dateTrans As Date = CDate(Format(transactionDate.Value, "Short Date"))


            'Fetching Payment Type
            Dim type As String
            If cash.Checked = True Then
                type = "Cash"
            Else
                type = "Credit"
            End If


            'fetching Discount
            Dim discountPer As Single
            If Discount.Text.Trim <> "" Then
                discountPer = CSng(Discount.Text)
            End If


            'fetching Total Amount
            Dim totalAmount As Single = CSng(fBill.Text.Replace("₹"c, "").Replace("/-", ""))

            'pushing data in purchaseSupport table
            Dim transCount As Integer = itemList.Items.Count
            For i = 0 To transCount - 1
                Dim iNa As String = itemList.Items.Item(i)
                Dim iQu As Integer = quantityList.Items.Item(i)
                Dim iPr As Single = Single.Parse(priceList.Items.Item(i))
                Dim iGst As Single = Single.Parse(gstAmt.Items.Item(i))
                Dim iAmt As Single = Single.Parse(totalPrice.Items.Item(i))
                Dim billId As Integer = Integer.Parse(tID.Text)
                Try
                    If conn.State = ConnectionState.Closed Then
                        conn.Open()
                    End If
                    Dim sql As String = "INSERT INTO pSupportTable (billId, itemName, itemQuantity, price, gst, priceGST) VALUES (" & billId & ",'" & iNa & "'," & iQu & "," & iPr & "," & iGst & "," & iAmt & ")"
                    Dim cmd As New OleDb.OleDbCommand(sql, conn)
                    cmd.ExecuteNonQuery()
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message, "Store Wise", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    conn.Close()
                End Try

                'fetching item Id
                Dim itemID As Integer

                If conn.State = ConnectionState.Closed Then
                    conn.Open()
                End If
                Try
                    Dim sql2 As String = "SELECT ID FROM itemTable WHERE itemName = '" & iNa & "'"
                    Dim cmd2 As New OleDb.OleDbCommand(sql2, conn)
                    Dim da As New OleDb.OleDbDataAdapter(cmd2)
                    Dim dt As New DataTable
                    da.Fill(dt)
                    itemID = dt.Rows(0).Item(0)
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message, "Store Wise", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    conn.Close()
                End Try

                'Updating Inventory Table
                Try
                    If conn.State = ConnectionState.Closed Then
                        conn.Open()
                    End If
                    Dim sql As String = "UPDATE inventoryTable SET quantity = quantity + " & iQu & " WHERE itemId = " & itemID
                    Dim cmd As New OleDb.OleDbCommand(sql, conn)
                    cmd.ExecuteNonQuery()
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message, "Store Wise", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    conn.Close()
                End Try
            Next

            'Pushing data in purchaseTable
            Try
                If conn.State = ConnectionState.Closed Then
                    conn.Open()
                End If
                Dim sql As String = "INSERT INTO purchaseTable (sName, pDate, discount, amtDis, type) VALUES ('" & supplierNameList.Text.ToString & "',#" & dateTrans & "#," & discountPer & "," & totalAmount & ",'" & type & "')"
                Dim cmd As New OleDb.OleDbCommand(sql, conn)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Transaction Saved Successfully", "Store Wise", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Store Wise", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                conn.Close()
            End Try
        End If
        fetchTransId()

        'resetting the form
        supplierNameList.Enabled = True
        itemList.Items.Clear()
        quantityList.Items.Clear()
        priceList.Items.Clear()
        gstAmt.Items.Clear()
        totalPrice.Items.Clear()
        fBill.Text = "₹0.00/-"
        Discount.Text = ""
        cash.Checked = True
        credit.Checked = False

    End Sub

    Private Sub supplierNameList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles supplierNameList.SelectedIndexChanged
        If supplierNameList.SelectedIndex = 0 Then
            supplierNameList.Enabled = True
        Else
            supplierNameList.Enabled = False
        End If

        'fetch Item Details
        Dim conn As New OleDb.OleDbConnection
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Saksham\Documents\StoreWise.accdb"
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            Dim sql As String = "SELECT itemName FROM itemTable where sName = '" & supplierNameList.Text & "'"
            Dim cmd As New OleDb.OleDbCommand(sql, conn)
            Dim da As New OleDb.OleDbDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)
            itemName.DataSource = dt
            itemName.DisplayMember = "itemName"
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Store Wise", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub transactionDate_ValueChanged(sender As Object, e As EventArgs) Handles transactionDate.ValueChanged
        If transactionDate.Value > Now() Then
            MessageBox.Show("Transaction Date can't be in Future", "Store Wise", MessageBoxButtons.OK, MessageBoxIcon.Error)
            transactionDate.Value = Now()
        End If
    End Sub
End Class