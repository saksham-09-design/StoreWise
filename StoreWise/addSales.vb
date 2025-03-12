Public Class addSales

    'function for handelling phone validation
    Private Sub phone_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles phone.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MessageBox.Show("Phone must be in Numbers.", "Store Wise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    'function for handelling quantity validation
    Private Sub itemQuantity_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles itemQuantity.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not e.KeyChar = "."c AndAlso Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MessageBox.Show("Quantity must be in Numbers.", "Store Wise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf e.KeyChar = "."c AndAlso itemQuantity.Text.Contains(".") Then
            e.Handled = True
            MessageBox.Show("Only one decimal point is allowed.", "Store Wise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    'function for handelling cancle button
    Private Sub cancle_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cancle.Click
        Me.Close()
    End Sub

    'function for handelling clear button
    Private Sub clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clear.Click
        'clearing form
        customerName.Text = "Cash"
        phone.Text = "NA"
        cash.Checked = True
        itemNamelist.SelectedIndex = -1
        itemQuantity.Clear()
        itemList.Items.Clear()
        quantityList.Items.Clear()
        priceList.Items.Clear()
        gstAmt.Items.Clear()
        totalPrice.Items.Clear()
        Discount.Clear()
        fBill.Text = "₹0/-"
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
            Dim sql As String = "SELECT saleID from support"
            Dim cmd As New OleDb.OleDbCommand(sql, conn)
            Dim da As New OleDb.OleDbDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)
            transID = CInt(dt.Rows(0).Item(0))
            tID.Text = transID
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Store Wise", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub

    'function for handelling save button
    Private Sub save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles save.Click
        'validating Items
        If itemList.Items.Count = 0 Then
            MessageBox.Show("Please Add Items", "Store Wise", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf customerName.Text = "" Then
            MessageBox.Show("Please Enter Customer Name", "Store Wise", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf phone.Text = "" Then
            MessageBox.Show("Please Enter Phone Number", "Store Wise", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

            'pushing data in sSupportTable table
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
                    Dim sql As String = "INSERT INTO sSupportTable (billId, itemName, quantity, price, gst, tPrice) VALUES (" & billId & ",'" & iNa & "'," & iQu & "," & iPr & "," & iGst & "," & iAmt & ")"
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
                    Dim sql As String = "UPDATE inventoryTable SET quantity = quantity - " & iQu & " WHERE itemId = " & itemID
                    Dim cmd As New OleDb.OleDbCommand(sql, conn)
                    cmd.ExecuteNonQuery()
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message, "Store Wise", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    conn.Close()
                End Try
            Next

            'Pushing data in salesTable
            Try
                If conn.State = ConnectionState.Closed Then
                    conn.Open()
                End If
                Dim sql As String = "insert into saleTable (cName, tDate, phoneNumber, tType, tDiscount, bAmt) values('" & customerName.Text.Trim & "', #" & dateTrans & "# , '" & phone.Text.Trim & "' , '" & type & "'," & discountPer & "," & totalAmount & ")"
                Dim cmd As New OleDb.OleDbCommand(sql, conn)
                cmd.ExecuteNonQuery()
                Dim sql1 As String = "UPDATE support SET saleID = saleID + 1"
                Dim cmd1 As New OleDb.OleDbCommand(sql1, conn)
                cmd1.ExecuteNonQuery()
                MessageBox.Show("Transaction Saved Successfully", "Store Wise", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Store Wise", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                conn.Close()
            End Try
        End If

        'clearing form
        customerName.Text = "Cash"
        phone.Text = "NA"
        cash.Checked = True
        itemNamelist.SelectedIndex = -1
        itemQuantity.Clear()
        itemList.Items.Clear()
        quantityList.Items.Clear()
        priceList.Items.Clear()
        gstAmt.Items.Clear()
        totalPrice.Items.Clear()
        Discount.Clear()
        fBill.Text = "₹0/-"
        fetchTransId()
    End Sub

    'function for handelling add button
    Private Sub Add_Click(sender As Object, e As EventArgs) Handles Add.Click

        Dim conn As New OleDb.OleDbConnection
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Saksham\Documents\StoreWise.accdb"

        If itemQuantity.Text <> "" Then
            Dim itemQ As Single
            Dim itemQD As Single

            'fetching quantity from database
            Try
                If conn.State = ConnectionState.Closed Then
                    conn.Open()
                End If
                Dim sql As String = "SELECT quantity FROM inventoryTable WHERE itemName = '" & itemNamelist.Text & "'"
                Dim cmd As New OleDb.OleDbCommand(sql, conn)
                Dim da As New OleDb.OleDbDataAdapter(cmd)
                Dim dt As New DataTable
                da.Fill(dt)
                itemQD = CInt(dt.Rows(0).Item(0))
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Store Wise", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                conn.Close()
            End Try

            'getting quantity from the list
            itemQ = CSng(itemQuantity.Text)

            If itemQ > 0.0 Then

                If itemQ < itemQD Then
                    Dim quantity As Integer
                    Dim fAmt As Single
                    Dim fAmount As String
                    Dim finalAmount As Single
                    Dim gst As Single


                    itemList.Items.Add(itemNamelist.Text)                      'Quantity and Price Logic
                    quantityList.Items.Add(itemQuantity.Text)

                    'fetching price from database

                    Dim priceItem As Single
                    Try
                        If conn.State = ConnectionState.Closed Then
                            conn.Open()
                        End If
                        Dim sql As String = "SELECT sellUnit FROM itemTable WHERE itemName = '" & itemNamelist.Text & "'"
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
                        Dim sql As String = "SELECT gst FROM itemTable WHERE itemName = '" & itemNamelist.Text & "'"
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
                    MessageBox.Show("Stock Not Available. Available Quantity is: " & itemQD, "Store Wise", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("Quantity Can't be Zero or Negative", "Store Wise", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Quantity Can't be Empty", "Store Wise", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    'Code for removing item from the bill
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

    'Discount %age Validation
    Private Sub Discount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Discount.TextChanged
        If Discount.Text <> "" Then
            If CSng(Discount.Text) > 100 Then
                MessageBox.Show("Discount Should be less than 100%", "Store Wise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If
        Discount_Cal()
    End Sub

    'Discount Calcultion
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

    Private Sub addSales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'fetching items
        Dim conn As New OleDb.OleDbConnection
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Saksham\Documents\StoreWise.accdb"
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            Dim sql As String = "SELECT itemName FROM itemTable"
            Dim cmd As New OleDb.OleDbCommand(sql, conn)
            Dim da As New OleDb.OleDbDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)
            itemNamelist.DataSource = dt
            itemNamelist.DisplayMember = "itemName"
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Store Wise", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try


        'Dark Mode Code
        If (DMode) Then
            Me.BackColor = Color.FromArgb(255, 13, 17, 23)
            For i = 1 To 15
                Dim lbl As Label = Me.Controls("Label" & i)
                lbl.ForeColor = Color.FromArgb(255, 240, 246, 252)
            Next
            save.BackColor = Color.FromArgb(255, 31, 111, 235)
            clear.BackColor = Color.FromArgb(255, 31, 111, 235)
            cancle.BackColor = Color.FromArgb(255, 31, 111, 235)
            save.ForeColor = Color.FromArgb(255, Color.White)
            clear.ForeColor = Color.FromArgb(255, Color.White)
            cancle.ForeColor = Color.FromArgb(255, Color.White)
            print.BackColor = Color.FromArgb(255, 31, 111, 235)
            Add.BackColor = Color.FromArgb(255, 31, 111, 235)
            print.ForeColor = Color.FromArgb(255, Color.White)
            Add.ForeColor = Color.FromArgb(255, Color.White)
            customerName.BackColor = Color.FromArgb(255, 33, 40, 48)
            customerName.ForeColor = Color.FromArgb(255, 240, 246, 252)
            phone.BackColor = Color.FromArgb(255, 33, 40, 48)
            phone.ForeColor = Color.FromArgb(255, 240, 246, 252)
            transactionDate.BackColor = Color.FromArgb(255, 33, 40, 48)
            transactionDate.ForeColor = Color.FromArgb(255, 240, 246, 252)
            tID.BackColor = Color.FromArgb(255, 33, 40, 48)
            tID.ForeColor = Color.FromArgb(255, 240, 246, 252)
            itemNamelist.BackColor = Color.FromArgb(255, 33, 40, 48)
            itemNamelist.ForeColor = Color.FromArgb(255, 240, 246, 252)
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
        End If
    End Sub

    Private Sub print_Click(sender As Object, e As EventArgs) Handles print.Click

    End Sub
End Class