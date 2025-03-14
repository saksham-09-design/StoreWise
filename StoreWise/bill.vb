Imports System.Drawing.Printing
Imports Microsoft.VisualBasic.PowerPacks.Printing

Public Class bill
    Private Sub bill_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim con As New OleDb.OleDbConnection
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Saksham\Documents\StoreWise.accdb"

        'fetching Bill format details
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Try
            Dim sql As String = "select * from billFormat"
            Dim da As New OleDb.OleDbDataAdapter(sql, con)
            Dim dt As New DataTable
            da.Fill(dt)
            fName.Text = dt.Rows(0).Item(0).ToString
            phEm.Text = dt.Rows(0).Item(1).ToString & "     |     " & dt.Rows(0).Item(2).ToString
            add.Text = dt.Rows(0).Item(3).ToString
            term0.Text = dt.Rows(0).Item(4).ToString
            term1.Text = dt.Rows(0).Item(5).ToString
            term2.Text = dt.Rows(0).Item(6).ToString
            term3.Text = dt.Rows(0).Item(7).ToString
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.ToString, "Storewise", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try


        'fetching customer details
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Try
            Dim sql As String = "select * from saleTable where ID = " & showBillId
            Dim da As New OleDb.OleDbDataAdapter(sql, con)
            Dim dt As New DataTable
            da.Fill(dt)
            cName.Text &= " " & dt.Rows(0).Item(1).ToString
            cPh.Text &= " " & dt.Rows(0).Item(3).ToString
            iDate.Text &= " " & Format(dt.Rows(0).Item(2), "Short Date")
            type.Text &= " " & dt.Rows(0).Item(4).ToString
            iNo.Text &= " " & dt.Rows(0).Item(0).ToString
            nPay.Text &= " " & dt.Rows(0).Item(6).ToString
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.ToString, "Storewise", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try


        'fetching bill items
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Try
            Dim sql As String = "select * from sSupportTable where billId = " & showBillId
            Dim da As New OleDb.OleDbDataAdapter(sql, con)
            Dim dt As New DataTable
            da.Fill(dt)
            Dim rec As Integer = dt.Rows.Count - 1
            itemList.Text = ""
            priceList.Text = ""
            quantityList.Text = ""
            gstList.Text = ""
            amountList.Text = ""
            For i = 0 To rec
                itemList.Text &= dt.Rows(i).Item(1).ToString & vbNewLine
                priceList.Text &= dt.Rows(i).Item(3).ToString & vbNewLine
                quantityList.Text &= dt.Rows(i).Item(2).ToString & vbNewLine
                gstList.Text &= dt.Rows(i).Item(4).ToString & vbNewLine
                amountList.Text &= dt.Rows(i).Item(5).ToString & vbNewLine
            Next
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.ToString, "Storewise", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try

        'fetching total amount, discount, gst amount
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Try
            'fetching total amount
            Dim sql As String = "select sum(price * quantity) from sSupportTable where billId =" & showBillId
            Dim da As New OleDb.OleDbDataAdapter(sql, con)
            Dim dt As New DataTable
            da.Fill(dt)
            Dim totalAmount As Single = CSng(dt.Rows(0).Item(0))
            tAmt.Text &= Format(dt.Rows(0).Item(0), "Standard")

            'fetching total gst
            Dim sql2 As String = "select sum(gst * quantity) from sSupportTable where billId =" & showBillId
            Dim da2 As New OleDb.OleDbDataAdapter(sql2, con)
            Dim dt2 As New DataTable
            da2.Fill(dt2)
            Dim totalGst As Single = CSng(dt2.Rows(0).Item(0))
            gst.Text &= Format(dt2.Rows(0).Item(0), "Standard")


            'fetching discount amount
            Dim sql1 As String = "select tDiscount from saleTable where Id =" & showBillId
            Dim da1 As New OleDb.OleDbDataAdapter(sql1, con)
            Dim dt1 As New DataTable
            da1.Fill(dt1)
            Dim disPer As Single = CSng(dt1.Rows(0).Item(0))
            disc.Text &= (((totalAmount + totalGst) * disPer) / 100).ToString
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.ToString, "Storewise", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try

        Me.PrintForm1.PrintAction = PrintAction.PrintToPreview    'Printing
        PrintForm1.PrinterSettings.DefaultPageSettings.Margins = New Margins(0, 0, 0, 0) 'Microsoft.VisualBasic.PowerPacks.Printing
        PrintForm1.Print(Me, PrintForm.PrintOption.ClientAreaOnly)
        Me.Close()
    End Sub
End Class