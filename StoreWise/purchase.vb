Public Class purchase

    Private Sub purchase_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Private Sub itemName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles filter.SelectedIndexChanged
        If filter.Text = "Custom Dates" Then
            transactionFromDate.Enabled = True
            transactioToDate.Enabled = True
            supplierName.Enabled = False
        ElseIf filter.Text = "Customer Name" Then
            supplierName.Enabled = True
            transactionFromDate.Enabled = False
            transactioToDate.Enabled = False
        Else
            transactionFromDate.Enabled = False
            transactioToDate.Enabled = False
            supplierName.Enabled = False
        End If
    End Sub
End Class