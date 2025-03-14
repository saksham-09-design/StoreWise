<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class bill
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(bill))
        Me.fName = New System.Windows.Forms.Label()
        Me.add = New System.Windows.Forms.Label()
        Me.phEm = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cName = New System.Windows.Forms.Label()
        Me.cPh = New System.Windows.Forms.Label()
        Me.iNo = New System.Windows.Forms.Label()
        Me.iDate = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.term1 = New System.Windows.Forms.Label()
        Me.term2 = New System.Windows.Forms.Label()
        Me.term3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tAmt = New System.Windows.Forms.Label()
        Me.disc = New System.Windows.Forms.Label()
        Me.nPay = New System.Windows.Forms.Label()
        Me.gst = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.itemList = New System.Windows.Forms.Label()
        Me.quantityList = New System.Windows.Forms.Label()
        Me.gstList = New System.Windows.Forms.Label()
        Me.amountList = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.priceList = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.term0 = New System.Windows.Forms.Label()
        Me.type = New System.Windows.Forms.Label()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'fName
        '
        Me.fName.AutoSize = True
        Me.fName.Font = New System.Drawing.Font("Now", 15.0!, System.Drawing.FontStyle.Bold)
        Me.fName.ForeColor = System.Drawing.Color.Black
        Me.fName.Location = New System.Drawing.Point(12, 10)
        Me.fName.Name = "fName"
        Me.fName.Size = New System.Drawing.Size(247, 30)
        Me.fName.TabIndex = 9
        Me.fName.Text = "Storewise Pvt. Ltd."
        Me.fName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'add
        '
        Me.add.AutoSize = True
        Me.add.Font = New System.Drawing.Font("Now", 10.0!)
        Me.add.ForeColor = System.Drawing.Color.Black
        Me.add.Location = New System.Drawing.Point(13, 85)
        Me.add.Name = "add"
        Me.add.Size = New System.Drawing.Size(325, 21)
        Me.add.TabIndex = 12
        Me.add.Text = "St. No. 6, Sukhera Basti, Abohar-152116"
        '
        'phEm
        '
        Me.phEm.AutoSize = True
        Me.phEm.Font = New System.Drawing.Font("Now", 10.0!, System.Drawing.FontStyle.Bold)
        Me.phEm.ForeColor = System.Drawing.Color.Black
        Me.phEm.Location = New System.Drawing.Point(13, 49)
        Me.phEm.Name = "phEm"
        Me.phEm.Size = New System.Drawing.Size(414, 20)
        Me.phEm.TabIndex = 13
        Me.phEm.Text = "9988776655     |     storewise.pvt.ltd@gmail.com"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Now", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(-3, 115)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(621, 20)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "--------------------------------------------------------------------"
        '
        'cName
        '
        Me.cName.AutoSize = True
        Me.cName.Font = New System.Drawing.Font("Now", 10.0!)
        Me.cName.ForeColor = System.Drawing.Color.Black
        Me.cName.Location = New System.Drawing.Point(12, 142)
        Me.cName.Name = "cName"
        Me.cName.Size = New System.Drawing.Size(148, 21)
        Me.cName.TabIndex = 15
        Me.cName.Text = "Customer Name:"
        '
        'cPh
        '
        Me.cPh.AutoSize = True
        Me.cPh.Font = New System.Drawing.Font("Now", 10.0!)
        Me.cPh.ForeColor = System.Drawing.Color.Black
        Me.cPh.Location = New System.Drawing.Point(12, 171)
        Me.cPh.Name = "cPh"
        Me.cPh.Size = New System.Drawing.Size(149, 21)
        Me.cPh.TabIndex = 16
        Me.cPh.Text = "Customer Phone:"
        '
        'iNo
        '
        Me.iNo.AutoSize = True
        Me.iNo.Font = New System.Drawing.Font("Now", 10.0!)
        Me.iNo.ForeColor = System.Drawing.Color.Black
        Me.iNo.Location = New System.Drawing.Point(298, 198)
        Me.iNo.Name = "iNo"
        Me.iNo.Size = New System.Drawing.Size(145, 21)
        Me.iNo.TabIndex = 17
        Me.iNo.Text = "Invoice Number:"
        '
        'iDate
        '
        Me.iDate.AutoSize = True
        Me.iDate.Font = New System.Drawing.Font("Now", 10.0!)
        Me.iDate.ForeColor = System.Drawing.Color.Black
        Me.iDate.Location = New System.Drawing.Point(12, 199)
        Me.iDate.Name = "iDate"
        Me.iDate.Size = New System.Drawing.Size(120, 21)
        Me.iDate.TabIndex = 18
        Me.iDate.Text = "Invoice Date:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Now", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(-3, 228)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(621, 20)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "--------------------------------------------------------------------"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Now", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(-3, 674)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(621, 20)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "--------------------------------------------------------------------"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Now", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(-4, 412)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 20)
        Me.Label3.TabIndex = 21
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Now", 10.0!)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(11, 697)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(193, 21)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Terms and Conditions:"
        '
        'term1
        '
        Me.term1.AutoSize = True
        Me.term1.Font = New System.Drawing.Font("Now", 10.0!)
        Me.term1.ForeColor = System.Drawing.Color.Black
        Me.term1.Location = New System.Drawing.Point(11, 745)
        Me.term1.Name = "term1"
        Me.term1.Size = New System.Drawing.Size(359, 21)
        Me.term1.TabIndex = 23
        Me.term1.Text = "1. Goods once sold will not be taken back."
        '
        'term2
        '
        Me.term2.AutoSize = True
        Me.term2.Font = New System.Drawing.Font("Now", 10.0!)
        Me.term2.ForeColor = System.Drawing.Color.Black
        Me.term2.Location = New System.Drawing.Point(11, 769)
        Me.term2.Name = "term2"
        Me.term2.Size = New System.Drawing.Size(551, 21)
        Me.term2.TabIndex = 24
        Me.term2.Text = "2. This copy does not entitle the holder too claim Input Tax Credit."
        '
        'term3
        '
        Me.term3.AutoSize = True
        Me.term3.Font = New System.Drawing.Font("Now", 10.0!)
        Me.term3.ForeColor = System.Drawing.Color.Black
        Me.term3.Location = New System.Drawing.Point(11, 793)
        Me.term3.Name = "term3"
        Me.term3.Size = New System.Drawing.Size(323, 21)
        Me.term3.TabIndex = 25
        Me.term3.Text = "3. Subject to 'Punjab' Jurisdiction only."
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Now", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(349, 823)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(269, 20)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "This invoice is digitally signed."
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Now", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(-3, 577)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(621, 20)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "--------------------------------------------------------------------"
        '
        'tAmt
        '
        Me.tAmt.AutoSize = True
        Me.tAmt.Font = New System.Drawing.Font("Now", 10.0!)
        Me.tAmt.ForeColor = System.Drawing.Color.Black
        Me.tAmt.Location = New System.Drawing.Point(12, 601)
        Me.tAmt.Name = "tAmt"
        Me.tAmt.Size = New System.Drawing.Size(121, 21)
        Me.tAmt.TabIndex = 28
        Me.tAmt.Text = "Total Amount:"
        '
        'disc
        '
        Me.disc.AutoSize = True
        Me.disc.Font = New System.Drawing.Font("Now", 10.0!)
        Me.disc.ForeColor = System.Drawing.Color.Black
        Me.disc.Location = New System.Drawing.Point(11, 626)
        Me.disc.Name = "disc"
        Me.disc.Size = New System.Drawing.Size(85, 21)
        Me.disc.TabIndex = 29
        Me.disc.Text = "Discount:"
        '
        'nPay
        '
        Me.nPay.AutoSize = True
        Me.nPay.Font = New System.Drawing.Font("Now", 10.0!, System.Drawing.FontStyle.Bold)
        Me.nPay.ForeColor = System.Drawing.Color.Black
        Me.nPay.Location = New System.Drawing.Point(321, 650)
        Me.nPay.Name = "nPay"
        Me.nPay.Size = New System.Drawing.Size(122, 20)
        Me.nPay.TabIndex = 30
        Me.nPay.Text = "Net Payable:"
        '
        'gst
        '
        Me.gst.AutoSize = True
        Me.gst.Font = New System.Drawing.Font("Now", 10.0!)
        Me.gst.ForeColor = System.Drawing.Color.Black
        Me.gst.Location = New System.Drawing.Point(12, 650)
        Me.gst.Name = "gst"
        Me.gst.Size = New System.Drawing.Size(48, 21)
        Me.gst.TabIndex = 31
        Me.gst.Text = "GST:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Now", 10.0!)
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(12, 256)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(46, 21)
        Me.Label14.TabIndex = 32
        Me.Label14.Text = "Item"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Now", 10.0!)
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(363, 256)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(43, 21)
        Me.Label15.TabIndex = 33
        Me.Label15.Text = "Qty."
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Now", 10.0!)
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(426, 256)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(43, 21)
        Me.Label16.TabIndex = 34
        Me.Label16.Text = "GST"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Now", 10.0!)
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(505, 256)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(71, 21)
        Me.Label17.TabIndex = 35
        Me.Label17.Text = "Amount"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Now", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(-9, 285)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(621, 20)
        Me.Label18.TabIndex = 36
        Me.Label18.Text = "--------------------------------------------------------------------"
        '
        'itemList
        '
        Me.itemList.AutoSize = True
        Me.itemList.Font = New System.Drawing.Font("Now", 8.0!)
        Me.itemList.ForeColor = System.Drawing.Color.Black
        Me.itemList.Location = New System.Drawing.Point(12, 312)
        Me.itemList.Name = "itemList"
        Me.itemList.Size = New System.Drawing.Size(43, 17)
        Me.itemList.TabIndex = 37
        Me.itemList.Text = "Soap"
        '
        'quantityList
        '
        Me.quantityList.AutoSize = True
        Me.quantityList.Font = New System.Drawing.Font("Now", 8.0!)
        Me.quantityList.ForeColor = System.Drawing.Color.Black
        Me.quantityList.Location = New System.Drawing.Point(364, 312)
        Me.quantityList.Name = "quantityList"
        Me.quantityList.Size = New System.Drawing.Size(23, 17)
        Me.quantityList.TabIndex = 38
        Me.quantityList.Text = "10"
        '
        'gstList
        '
        Me.gstList.AutoSize = True
        Me.gstList.Font = New System.Drawing.Font("Now", 8.0!)
        Me.gstList.ForeColor = System.Drawing.Color.Black
        Me.gstList.Location = New System.Drawing.Point(427, 312)
        Me.gstList.Name = "gstList"
        Me.gstList.Size = New System.Drawing.Size(32, 17)
        Me.gstList.TabIndex = 39
        Me.gstList.Text = "12%"
        '
        'amountList
        '
        Me.amountList.AutoSize = True
        Me.amountList.Font = New System.Drawing.Font("Now", 8.0!)
        Me.amountList.ForeColor = System.Drawing.Color.Black
        Me.amountList.Location = New System.Drawing.Point(506, 312)
        Me.amountList.Name = "amountList"
        Me.amountList.Size = New System.Drawing.Size(27, 17)
        Me.amountList.TabIndex = 40
        Me.amountList.Text = "112"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Now", 10.0!)
        Me.Label23.ForeColor = System.Drawing.Color.Black
        Me.Label23.Location = New System.Drawing.Point(283, 256)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(52, 21)
        Me.Label23.TabIndex = 41
        Me.Label23.Text = "Price"
        '
        'priceList
        '
        Me.priceList.AutoSize = True
        Me.priceList.Font = New System.Drawing.Font("Now", 8.0!)
        Me.priceList.ForeColor = System.Drawing.Color.Black
        Me.priceList.Location = New System.Drawing.Point(284, 312)
        Me.priceList.Name = "priceList"
        Me.priceList.Size = New System.Drawing.Size(33, 17)
        Me.priceList.TabIndex = 42
        Me.priceList.Text = "100"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(508, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(78, 70)
        Me.PictureBox1.TabIndex = 43
        Me.PictureBox1.TabStop = False
        '
        'term0
        '
        Me.term0.AutoSize = True
        Me.term0.Font = New System.Drawing.Font("Now", 10.0!)
        Me.term0.ForeColor = System.Drawing.Color.Black
        Me.term0.Location = New System.Drawing.Point(11, 721)
        Me.term0.Name = "term0"
        Me.term0.Size = New System.Drawing.Size(94, 21)
        Me.term0.TabIndex = 44
        Me.term0.Text = "E. and O.E."
        '
        'type
        '
        Me.type.AutoSize = True
        Me.type.Font = New System.Drawing.Font("Now", 10.0!)
        Me.type.ForeColor = System.Drawing.Color.Black
        Me.type.Location = New System.Drawing.Point(298, 166)
        Me.type.Name = "type"
        Me.type.Size = New System.Drawing.Size(54, 21)
        Me.type.TabIndex = 45
        Me.type.Text = "Type:"
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'bill
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(625, 847)
        Me.Controls.Add(Me.type)
        Me.Controls.Add(Me.term1)
        Me.Controls.Add(Me.gst)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.term0)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.priceList)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.amountList)
        Me.Controls.Add(Me.gstList)
        Me.Controls.Add(Me.quantityList)
        Me.Controls.Add(Me.itemList)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.nPay)
        Me.Controls.Add(Me.disc)
        Me.Controls.Add(Me.tAmt)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.term3)
        Me.Controls.Add(Me.term2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.iDate)
        Me.Controls.Add(Me.iNo)
        Me.Controls.Add(Me.cPh)
        Me.Controls.Add(Me.cName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.phEm)
        Me.Controls.Add(Me.add)
        Me.Controls.Add(Me.fName)
        Me.Name = "bill"
        Me.Text = "Bill"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents fName As Label
    Friend WithEvents add As Label
    Friend WithEvents phEm As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cName As Label
    Friend WithEvents cPh As Label
    Friend WithEvents iNo As Label
    Friend WithEvents iDate As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents term1 As Label
    Friend WithEvents term2 As Label
    Friend WithEvents term3 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents tAmt As Label
    Friend WithEvents disc As Label
    Friend WithEvents nPay As Label
    Friend WithEvents gst As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents itemList As Label
    Friend WithEvents quantityList As Label
    Friend WithEvents gstList As Label
    Friend WithEvents amountList As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents priceList As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents term0 As Label
    Friend WithEvents type As Label
    Friend WithEvents PrintForm1 As PowerPacks.Printing.PrintForm
End Class
