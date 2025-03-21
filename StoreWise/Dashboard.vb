Imports System.Runtime.InteropServices

Public Class Dashboard
    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tSales.Text = "₹" & Format(TotalSales, "Standard") & "/-"
        tPur.Text = "₹" & Format(TotalPurhcase, "Standard") & "/-"
        pay.Text &= " ₹" & Format(netPayable, "Standard") & "/-"
        rec.Text &= " ₹" & Format(netRecievable, "Standard") & "/-"
        mValue.Text &= " ₹" & Format(stockMarketValue, "Standard") & "/-"
        purVal.Text &= " ₹" & Format(stockPurchaseValue, "Standard") & "/-"
        stock.Text &= " ₹" & Format(stockPurchaseValue, "Standard") & "/-"
        cSale.Text &= " ₹" & Format(cashSales, "Standard") & "/-"
        crSales.Text &= " ₹" & Format(creditSales, "Standard") & "/-"
        cPur.Text &= " ₹" & Format(cashPurchase, "Standard") & "/-"
        crPur.Text &= " ₹" & Format(creditPurchase, "Standard") & "/-"
        ogst.Text = " ₹" & Format(outputGST, "Standard") & "/-"
    End Sub


    Private Sub Modify_Click(sender As Object, e As EventArgs) Handles Modify.Click
        dSale = False
        disSale = True

        Dim sales As New sales()
        sales.MdiParent = MainPage
        sales.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        dPur = False
        disPur = True

        Dim pur As New purchase()
        pur.MdiParent = MainPage
        pur.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim inv As New inventory()
        inv.MdiParent = MainPage
        inv.Show()
    End Sub
End Class