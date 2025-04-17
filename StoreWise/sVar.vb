Imports System.IdentityModel.Metadata

Module sVar

    'Support variable for dark mode
    Public DMode = True

    'Support variables for reducing number of forms
    Public dPur As Boolean = False
    Public disPur As Boolean = False
    Public dSale As Boolean = False
    Public disSale As Boolean = False

    'Support variables for handling transactions
    Public purId As Integer = 0
    Public salId As Integer = 0
    Public showBillId As Integer = 0


    'variable for supporting Dashboard
    Public TotalPurhcase As Single = 0.0
    Public TotalSales As Single = 0.0
    Public reOrderLevel(4, 1) As String
    Public inputGST As Single = 0.0
    Public outputGST As Single = 0.0
    Public netPayable As Single = 0.0
    Public netRecievable As Single = 0.0
    Public cashSales As Single = 0.0
    Public creditSales As Single = 0.0
    Public cashPurchase As Single = 0.0
    Public creditPurchase As Single = 0.0
    Public stockPurchaseValue As Single = 0.0
    Public stockMarketValue As Single = 0.0
    Public netProfit As Single = 0.0
End Module
