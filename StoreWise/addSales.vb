Public Class addSales

    Private Sub phone_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles phone.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MessageBox.Show("Phone must be in Numbers.", "Store Wise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub itemQuantity_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles itemQuantity.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not e.KeyChar = "."c AndAlso Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MessageBox.Show("Quantity must be in Numbers.", "Store Wise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf e.KeyChar = "."c AndAlso itemQuantity.Text.Contains(".") Then
            e.Handled = True
            MessageBox.Show("Only one decimal point is allowed.", "Store Wise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub cancle_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cancle.Click
        Me.Close()
    End Sub

    Private Sub clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clear.Click
        customerName.Text = ""
        customerAddress.Text = ""
        phone.Text = ""
        eMail.Text = ""
        itemQuantity.Text = ""
    End Sub

    Private Sub save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles save.Click
        If (itemName.Text.Trim = "" Or itemQuantity.Text.Trim = "" Or customerName.Text.Trim = "" Or phone.Text.Trim = "" Or itemQuantity.Text.Trim = "") Then
            MessageBox.Show("Please Fill All Fields", "Store Wise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else

        End If
    End Sub

    Private Sub Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Add.Click
        If itemQuantity.Text <> "" Then
            If CInt(itemQuantity.Text) > 0 Then
                Dim price As Single
                Dim quantity As Integer
                Dim fAmt As Single
                Dim fAmount As String
                Dim finalAmount As Single
                Dim gst As Single


                itemList.Items.Add(itemName.Text)   'Quantity and Price Logic
                quantityList.Items.Add(itemQuantity.Text)
                priceList.Items.Add("100")
                price = CSng(priceList.Items.Item(priceList.Items.Count - 1))


                quantity = CInt(quantityList.Items.Item(quantityList.Items.Count - 1))  'Quantity Logic


                gst = ((price * 18) / 100)       'GST Logic
                gstAmt.Items.Add(gst)



                fAmt = (price + gst) * quantity'Total Amount Logic
                totalPrice.Items.Add(fAmt)
                itemQuantity.Text = ""
                itemName.SelectedIndex = 0



                fAmount = fBill.Text            'Final Bill Amount Logic
                fAmount = fAmount.Replace("₹"c, "")
                fAmount = fAmount.Replace("/"c, "")
                fAmount = fAmount.Replace("-"c, "")
                finalAmount = CSng(fAmount)
                finalAmount += fAmt
                fBill.Text = "₹" & finalAmount & "/-"
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

                quantity = CSng(quantityList.Items.Item(ind))

                gst = CSng(gstAmt.Items.Item(ind))
                price = CSng(priceList.Items.Item(ind))
                If Discount.Text <> "" Then
                    disc = CSng(Discount.Text)
                Else
                    disc = 0
                End If


                fAmount = fBill.Text            'Final Bill Amount Logic
                fAmount = fAmount.Replace("₹"c, "")
                fAmount = fAmount.Replace("/"c, "")
                fAmount = fAmount.Replace("-"c, "")
                finalAmount = CSng(fAmount)
                fAmt = finalAmount - ((price + gst - (((price + gst) * disc) / 100)) * quantity)
                finalAmount = fAmt
                fBill.Text = "₹" & finalAmount & "/-"



                itemList.Items.RemoveAt(ind)
                quantityList.Items.RemoveAt(ind)
                gstAmt.Items.RemoveAt(ind)
                totalPrice.Items.RemoveAt(ind)
                priceList.Items.RemoveAt(ind)
            End If
        End If

    End Sub

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

        fBill.Text = "₹" & (fAmount - disAmt) & "/-"
    End Sub

    Private Sub itemQuantity_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles itemQuantity.TextChanged

    End Sub
End Class