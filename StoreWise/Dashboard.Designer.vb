<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Dashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim ChartArea4 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend4 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series4 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea5 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend5 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series5 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea6 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend6 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series6 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Modify = New System.Windows.Forms.Button()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.tSales = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Chart2 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.tPur = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Chart3 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.ReOrderItem = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.paygst = New System.Windows.Forms.Label()
        Me.ogst = New System.Windows.Forms.Label()
        Me.igst = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.rec = New System.Windows.Forms.Label()
        Me.pay = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.purVal = New System.Windows.Forms.Label()
        Me.mValue = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.nProfitFinal = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.crPur = New System.Windows.Forms.Label()
        Me.cPur = New System.Windows.Forms.Label()
        Me.crSales = New System.Windows.Forms.Label()
        Me.cSale = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.stock = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.Chart3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Modify)
        Me.Panel1.Controls.Add(Me.Chart1)
        Me.Panel1.Controls.Add(Me.tSales)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(393, 345)
        Me.Panel1.TabIndex = 0
        '
        'Modify
        '
        Me.Modify.BackColor = System.Drawing.Color.Red
        Me.Modify.Font = New System.Drawing.Font("Now", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Modify.ForeColor = System.Drawing.Color.Ivory
        Me.Modify.Location = New System.Drawing.Point(9, 282)
        Me.Modify.Name = "Modify"
        Me.Modify.Size = New System.Drawing.Size(371, 52)
        Me.Modify.TabIndex = 32
        Me.Modify.Text = "View All Sales"
        Me.Modify.UseVisualStyleBackColor = False
        '
        'Chart1
        '
        ChartArea4.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea4)
        Legend4.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend4)
        Me.Chart1.Location = New System.Drawing.Point(9, 60)
        Me.Chart1.Name = "Chart1"
        Series4.ChartArea = "ChartArea1"
        Series4.Legend = "Legend1"
        Series4.Name = "Series1"
        Me.Chart1.Series.Add(Series4)
        Me.Chart1.Size = New System.Drawing.Size(371, 212)
        Me.Chart1.TabIndex = 4
        Me.Chart1.Text = "Chart1"
        '
        'tSales
        '
        Me.tSales.AutoSize = True
        Me.tSales.Font = New System.Drawing.Font("Now", 15.8!, System.Drawing.FontStyle.Bold)
        Me.tSales.ForeColor = System.Drawing.Color.Blue
        Me.tSales.Location = New System.Drawing.Point(156, 16)
        Me.tSales.Name = "tSales"
        Me.tSales.Size = New System.Drawing.Size(179, 32)
        Me.tSales.TabIndex = 2
        Me.tSales.Text = "₹1,00,000/-"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Now", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(14, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 28)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Total Sales:"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.Chart2)
        Me.Panel2.Controls.Add(Me.tPur)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Location = New System.Drawing.Point(427, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(422, 345)
        Me.Panel2.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.Font = New System.Drawing.Font("Now", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Ivory
        Me.Button1.Location = New System.Drawing.Point(26, 281)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(371, 52)
        Me.Button1.TabIndex = 33
        Me.Button1.Text = "View All Purchases"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Chart2
        '
        ChartArea5.Name = "ChartArea1"
        Me.Chart2.ChartAreas.Add(ChartArea5)
        Legend5.Name = "Legend1"
        Me.Chart2.Legends.Add(Legend5)
        Me.Chart2.Location = New System.Drawing.Point(26, 60)
        Me.Chart2.Name = "Chart2"
        Series5.ChartArea = "ChartArea1"
        Series5.Legend = "Legend1"
        Series5.Name = "Series1"
        Me.Chart2.Series.Add(Series5)
        Me.Chart2.Size = New System.Drawing.Size(371, 212)
        Me.Chart2.TabIndex = 5
        Me.Chart2.Text = "Chart2"
        '
        'tPur
        '
        Me.tPur.AutoSize = True
        Me.tPur.Font = New System.Drawing.Font("Now", 15.8!, System.Drawing.FontStyle.Bold)
        Me.tPur.ForeColor = System.Drawing.Color.Blue
        Me.tPur.Location = New System.Drawing.Point(200, 16)
        Me.tPur.Name = "tPur"
        Me.tPur.Size = New System.Drawing.Size(179, 32)
        Me.tPur.TabIndex = 2
        Me.tPur.Text = "₹1,00,000/-"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Now", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(14, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(188, 28)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Total Purchase:"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Chart3)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Location = New System.Drawing.Point(427, 378)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(422, 278)
        Me.Panel3.TabIndex = 5
        '
        'Chart3
        '
        ChartArea6.Name = "ChartArea1"
        Me.Chart3.ChartAreas.Add(ChartArea6)
        Legend6.Name = "Legend1"
        Me.Chart3.Legends.Add(Legend6)
        Me.Chart3.Location = New System.Drawing.Point(9, 53)
        Me.Chart3.Name = "Chart3"
        Series6.ChartArea = "ChartArea1"
        Series6.Legend = "Legend1"
        Series6.Name = "Series1"
        Me.Chart3.Series.Add(Series6)
        Me.Chart3.Size = New System.Drawing.Size(388, 212)
        Me.Chart3.TabIndex = 4
        Me.Chart3.Text = "Chart3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Now", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(14, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(203, 28)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Most Sold Items:"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.ReOrderItem)
        Me.Panel4.Controls.Add(Me.Button3)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Location = New System.Drawing.Point(12, 378)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(393, 278)
        Me.Panel4.TabIndex = 33
        '
        'ReOrderItem
        '
        Me.ReOrderItem.AutoSize = True
        Me.ReOrderItem.Font = New System.Drawing.Font("Now", 12.8!, System.Drawing.FontStyle.Bold)
        Me.ReOrderItem.ForeColor = System.Drawing.Color.Blue
        Me.ReOrderItem.Location = New System.Drawing.Point(14, 59)
        Me.ReOrderItem.Name = "ReOrderItem"
        Me.ReOrderItem.Size = New System.Drawing.Size(334, 26)
        Me.ReOrderItem.TabIndex = 33
        Me.ReOrderItem.Text = "Items below Re-Order Level:"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Red
        Me.Button3.Font = New System.Drawing.Font("Now", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Ivory
        Me.Button3.Location = New System.Drawing.Point(9, 211)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(371, 52)
        Me.Button3.TabIndex = 32
        Me.Button3.Text = "View Inventory"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Now", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(14, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(339, 28)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Items below Re-Order Level:"
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.paygst)
        Me.Panel5.Controls.Add(Me.ogst)
        Me.Panel5.Controls.Add(Me.igst)
        Me.Panel5.Controls.Add(Me.Label9)
        Me.Panel5.Controls.Add(Me.Label8)
        Me.Panel5.Controls.Add(Me.Label7)
        Me.Panel5.Controls.Add(Me.Label6)
        Me.Panel5.Location = New System.Drawing.Point(12, 673)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(837, 120)
        Me.Panel5.TabIndex = 34
        '
        'paygst
        '
        Me.paygst.AutoSize = True
        Me.paygst.Font = New System.Drawing.Font("Now", 25.8!, System.Drawing.FontStyle.Bold)
        Me.paygst.ForeColor = System.Drawing.Color.Blue
        Me.paygst.Location = New System.Drawing.Point(455, 51)
        Me.paygst.Name = "paygst"
        Me.paygst.Size = New System.Drawing.Size(287, 52)
        Me.paygst.TabIndex = 39
        Me.paygst.Text = "₹1,00,000/-"
        '
        'ogst
        '
        Me.ogst.AutoSize = True
        Me.ogst.Font = New System.Drawing.Font("Now", 15.8!, System.Drawing.FontStyle.Bold)
        Me.ogst.ForeColor = System.Drawing.Color.Blue
        Me.ogst.Location = New System.Drawing.Point(169, 80)
        Me.ogst.Name = "ogst"
        Me.ogst.Size = New System.Drawing.Size(179, 32)
        Me.ogst.TabIndex = 38
        Me.ogst.Text = "₹1,00,000/-"
        '
        'igst
        '
        Me.igst.AutoSize = True
        Me.igst.Font = New System.Drawing.Font("Now", 15.8!, System.Drawing.FontStyle.Bold)
        Me.igst.ForeColor = System.Drawing.Color.Blue
        Me.igst.Location = New System.Drawing.Point(169, 45)
        Me.igst.Name = "igst"
        Me.igst.Size = New System.Drawing.Size(179, 32)
        Me.igst.TabIndex = 33
        Me.igst.Text = "₹1,00,000/-"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Now", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(450, 19)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(191, 28)
        Me.Label9.TabIndex = 37
        Me.Label9.Text = "GST to be Paid:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Now", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(9, 84)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(154, 28)
        Me.Label8.TabIndex = 36
        Me.Label8.Text = "Output GST:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Now", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(9, 47)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(132, 28)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "Input GST:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Now", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(9, 15)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 28)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "GST:"
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.rec)
        Me.Panel6.Controls.Add(Me.pay)
        Me.Panel6.Location = New System.Drawing.Point(865, 12)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(616, 100)
        Me.Panel6.TabIndex = 35
        '
        'rec
        '
        Me.rec.AutoSize = True
        Me.rec.Font = New System.Drawing.Font("Now", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rec.ForeColor = System.Drawing.Color.Red
        Me.rec.Location = New System.Drawing.Point(19, 60)
        Me.rec.Name = "rec"
        Me.rec.Size = New System.Drawing.Size(197, 28)
        Me.rec.TabIndex = 41
        Me.rec.Text = "Net Recievable:"
        '
        'pay
        '
        Me.pay.AutoSize = True
        Me.pay.Font = New System.Drawing.Font("Now", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pay.ForeColor = System.Drawing.Color.Red
        Me.pay.Location = New System.Drawing.Point(19, 16)
        Me.pay.Name = "pay"
        Me.pay.Size = New System.Drawing.Size(163, 28)
        Me.pay.TabIndex = 40
        Me.pay.Text = "Net Payable:"
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.purVal)
        Me.Panel7.Controls.Add(Me.mValue)
        Me.Panel7.Controls.Add(Me.Label12)
        Me.Panel7.Location = New System.Drawing.Point(865, 130)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(616, 139)
        Me.Panel7.TabIndex = 42
        '
        'purVal
        '
        Me.purVal.AutoSize = True
        Me.purVal.Font = New System.Drawing.Font("Now", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.purVal.ForeColor = System.Drawing.Color.Red
        Me.purVal.Location = New System.Drawing.Point(19, 94)
        Me.purVal.Name = "purVal"
        Me.purVal.Size = New System.Drawing.Size(195, 28)
        Me.purVal.TabIndex = 42
        Me.purVal.Text = "Purchase Value:"
        '
        'mValue
        '
        Me.mValue.AutoSize = True
        Me.mValue.Font = New System.Drawing.Font("Now", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mValue.ForeColor = System.Drawing.Color.Red
        Me.mValue.Location = New System.Drawing.Point(19, 60)
        Me.mValue.Name = "mValue"
        Me.mValue.Size = New System.Drawing.Size(175, 28)
        Me.mValue.TabIndex = 41
        Me.mValue.Text = "Market Value:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Now", 17.8!, System.Drawing.FontStyle.Bold)
        Me.Label12.ForeColor = System.Drawing.Color.Red
        Me.Label12.Location = New System.Drawing.Point(19, 16)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(112, 36)
        Me.Label12.TabIndex = 40
        Me.Label12.Text = "Stock:"
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.nProfitFinal)
        Me.Panel8.Controls.Add(Me.Label2)
        Me.Panel8.Controls.Add(Me.stock)
        Me.Panel8.Controls.Add(Me.crPur)
        Me.Panel8.Controls.Add(Me.cPur)
        Me.Panel8.Controls.Add(Me.crSales)
        Me.Panel8.Controls.Add(Me.cSale)
        Me.Panel8.Controls.Add(Me.Label16)
        Me.Panel8.Location = New System.Drawing.Point(865, 287)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(616, 386)
        Me.Panel8.TabIndex = 43
        '
        'nProfitFinal
        '
        Me.nProfitFinal.AutoSize = True
        Me.nProfitFinal.Font = New System.Drawing.Font("Now", 30.8!, System.Drawing.FontStyle.Bold)
        Me.nProfitFinal.ForeColor = System.Drawing.Color.Red
        Me.nProfitFinal.Location = New System.Drawing.Point(51, 314)
        Me.nProfitFinal.Name = "nProfitFinal"
        Me.nProfitFinal.Size = New System.Drawing.Size(389, 62)
        Me.nProfitFinal.TabIndex = 48
        Me.nProfitFinal.Text = "₹10,00,000/-"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Now", 20.8!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(20, 266)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(349, 42)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "NET PROFIT/LOSS:"
        '
        'crPur
        '
        Me.crPur.AutoSize = True
        Me.crPur.Font = New System.Drawing.Font("Now", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.crPur.ForeColor = System.Drawing.Color.Red
        Me.crPur.Location = New System.Drawing.Point(20, 178)
        Me.crPur.Name = "crPur"
        Me.crPur.Size = New System.Drawing.Size(259, 28)
        Me.crPur.TabIndex = 44
        Me.crPur.Text = "Total Credit Puchase:"
        '
        'cPur
        '
        Me.cPur.AutoSize = True
        Me.cPur.Font = New System.Drawing.Font("Now", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cPur.ForeColor = System.Drawing.Color.Red
        Me.cPur.Location = New System.Drawing.Point(20, 138)
        Me.cPur.Name = "cPur"
        Me.cPur.Size = New System.Drawing.Size(253, 28)
        Me.cPur.TabIndex = 43
        Me.cPur.Text = "Total Cash Purchase:"
        '
        'crSales
        '
        Me.crSales.AutoSize = True
        Me.crSales.Font = New System.Drawing.Font("Now", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.crSales.ForeColor = System.Drawing.Color.Red
        Me.crSales.Location = New System.Drawing.Point(19, 100)
        Me.crSales.Name = "crSales"
        Me.crSales.Size = New System.Drawing.Size(224, 28)
        Me.crSales.TabIndex = 42
        Me.crSales.Text = "Total Credit Sales:"
        '
        'cSale
        '
        Me.cSale.AutoSize = True
        Me.cSale.Font = New System.Drawing.Font("Now", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cSale.ForeColor = System.Drawing.Color.Red
        Me.cSale.Location = New System.Drawing.Point(19, 60)
        Me.cSale.Name = "cSale"
        Me.cSale.Size = New System.Drawing.Size(209, 28)
        Me.cSale.TabIndex = 41
        Me.cSale.Text = "Total Cash Sales:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Now", 17.8!, System.Drawing.FontStyle.Bold)
        Me.Label16.ForeColor = System.Drawing.Color.Red
        Me.Label16.Location = New System.Drawing.Point(19, 16)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(343, 36)
        Me.Label16.TabIndex = 40
        Me.Label16.Text = "Overall Performance:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Now", 50.8!, System.Drawing.FontStyle.Bold)
        Me.Label14.ForeColor = System.Drawing.Color.Red
        Me.Label14.Location = New System.Drawing.Point(950, 688)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(531, 102)
        Me.Label14.TabIndex = 49
        Me.Label14.Text = "STOREWISE"
        '
        'stock
        '
        Me.stock.AutoSize = True
        Me.stock.Font = New System.Drawing.Font("Now", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stock.ForeColor = System.Drawing.Color.Red
        Me.stock.Location = New System.Drawing.Point(20, 217)
        Me.stock.Name = "stock"
        Me.stock.Size = New System.Drawing.Size(86, 28)
        Me.stock.TabIndex = 45
        Me.stock.Text = "Stock:"
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1493, 805)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Dashboard"
        Me.Text = "Dashboard"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.Chart3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents tSales As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents tPur As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents Chart2 As DataVisualization.Charting.Chart
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Chart3 As DataVisualization.Charting.Chart
    Friend WithEvents Label4 As Label
    Friend WithEvents Modify As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents ReOrderItem As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents paygst As Label
    Friend WithEvents ogst As Label
    Friend WithEvents igst As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents rec As Label
    Friend WithEvents pay As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents purVal As Label
    Friend WithEvents mValue As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents crSales As Label
    Friend WithEvents cSale As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents crPur As Label
    Friend WithEvents cPur As Label
    Friend WithEvents nProfitFinal As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents stock As Label
End Class
