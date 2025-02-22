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
        customerName.Text = ""
        customerAddress.Text = ""
        phone.Text = ""
        eMail.Text = ""
        itemQuantity.Text = ""
    End Sub

    'function for handelling save button
    Private Sub save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles save.Click
        If (itemNamelist.Text.Trim = "" Or itemQuantity.Text.Trim = "" Or customerName.Text.Trim = "" Or phone.Text.Trim = "" Or itemQuantity.Text.Trim = "") Then
            MessageBox.Show("Please Fill All Fields", "Store Wise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else

        End If
    End Sub

    'function for handelling add button
    Private Sub Add_Click(sender As Object, e As EventArgs) Handles Add.Click
        If itemQuantity.Text <> "" Then
            If CInt(itemQuantity.Text) > 0 Then
                Dim price As Single
                Dim quantity As Integer
                Dim fAmt As Single
                Dim fAmount As String
                Dim finalAmount As Single
                Dim gst As Single


                itemList.Items.Add(itemNamelist.Text)                                   'Quantity and Price Logic
                quantityList.Items.Add(itemQuantity.Text)
                priceList.Items.Add("100")
                price = CSng(priceList.Items.Item(priceList.Items.Count - 1))


                quantity = CInt(quantityList.Items.Item(quantityList.Items.Count - 1))  'Quantity Logic


                gst = ((price * 18) / 100)                                              'GST Logic
                gstAmt.Items.Add(gst)



                fAmt = (price + gst) * quantity                                         'Total Amount Logic
                totalPrice.Items.Add(fAmt)
                itemQuantity.Text = ""
                itemNamelist.SelectedIndex = 0



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

        'Dark Mode Code
        If (DMode) Then
            Me.BackColor = Color.FromArgb(255, 13, 17, 23)
            For i = 1 To 17
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
            customerAddress.BackColor = Color.FromArgb(255, 33, 40, 48)
            customerAddress.ForeColor = Color.FromArgb(255, 240, 246, 252)
            phone.BackColor = Color.FromArgb(255, 33, 40, 48)
            phone.ForeColor = Color.FromArgb(255, 240, 246, 252)
            transactionDate.BackColor = Color.FromArgb(255, 33, 40, 48)
            transactionDate.ForeColor = Color.FromArgb(255, 240, 246, 252)
            eMail.BackColor = Color.FromArgb(255, 33, 40, 48)
            eMail.ForeColor = Color.FromArgb(255, 240, 246, 252)
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

    Private Sub itemNamelist_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles itemNamelist.SelectedIndexChanged

    End Sub
End Class