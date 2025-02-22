Public Class sales

    Private Sub itemName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles filter.SelectedIndexChanged
        If filter.Text = "Custom Dates" Then
            transactionFromDate.Enabled = True
            transactioToDate.Enabled = True
            customerName.Enabled = False
        ElseIf filter.Text = "Customer Name" Then
            customerName.Enabled = True
            transactionFromDate.Enabled = False
            transactioToDate.Enabled = False
        Else
            transactionFromDate.Enabled = False
            transactioToDate.Enabled = False
            customerName.Enabled = False
        End If
    End Sub

    Private Sub sales_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class