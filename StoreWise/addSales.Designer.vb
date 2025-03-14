<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class addSales
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.customerName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.transactionDate = New System.Windows.Forms.DateTimePicker()
        Me.phone = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tID = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.credit = New System.Windows.Forms.RadioButton()
        Me.cash = New System.Windows.Forms.RadioButton()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.itemQuantity = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cancle = New System.Windows.Forms.Button()
        Me.clear = New System.Windows.Forms.Button()
        Me.save = New System.Windows.Forms.Button()
        Me.itemNamelist = New System.Windows.Forms.ComboBox()
        Me.Add = New System.Windows.Forms.Button()
        Me.itemList = New System.Windows.Forms.ListBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.quantityList = New System.Windows.Forms.ListBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.priceList = New System.Windows.Forms.ListBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.totalPrice = New System.Windows.Forms.ListBox()
        Me.Discount = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.fBill = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.gstAmt = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Now", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(490, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(449, 48)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Add Sale Transaction"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Now Medium", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(28, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(272, 34)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "*Customer Name:"
        '
        'customerName
        '
        Me.customerName.Font = New System.Drawing.Font("Now Medium", 15.8!)
        Me.customerName.Location = New System.Drawing.Point(306, 109)
        Me.customerName.Name = "customerName"
        Me.customerName.Size = New System.Drawing.Size(308, 39)
        Me.customerName.TabIndex = 1
        Me.customerName.Text = "Cash"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Now Medium", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(679, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 34)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "*Date:"
        '
        'transactionDate
        '
        Me.transactionDate.Font = New System.Drawing.Font("Now Medium", 12.8!)
        Me.transactionDate.Location = New System.Drawing.Point(845, 111)
        Me.transactionDate.Name = "transactionDate"
        Me.transactionDate.Size = New System.Drawing.Size(470, 33)
        Me.transactionDate.TabIndex = 2
        '
        'phone
        '
        Me.phone.Font = New System.Drawing.Font("Now Medium", 15.8!)
        Me.phone.Location = New System.Drawing.Point(306, 177)
        Me.phone.Name = "phone"
        Me.phone.Size = New System.Drawing.Size(1009, 39)
        Me.phone.TabIndex = 4
        Me.phone.Text = "NA"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Now Medium", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(28, 179)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(250, 34)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "*Phone Number:"
        '
        'tID
        '
        Me.tID.Font = New System.Drawing.Font("Now Medium", 15.8!)
        Me.tID.Location = New System.Drawing.Point(306, 242)
        Me.tID.Name = "tID"
        Me.tID.ReadOnly = True
        Me.tID.Size = New System.Drawing.Size(308, 39)
        Me.tID.TabIndex = 14
        Me.tID.Text = "1"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Now Medium", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(28, 244)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(234, 34)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Transaction Id:"
        '
        'credit
        '
        Me.credit.AutoSize = True
        Me.credit.Font = New System.Drawing.Font("Now", 16.0!, System.Drawing.FontStyle.Bold)
        Me.credit.ForeColor = System.Drawing.Color.Red
        Me.credit.Location = New System.Drawing.Point(1100, 240)
        Me.credit.Name = "credit"
        Me.credit.Size = New System.Drawing.Size(122, 36)
        Me.credit.TabIndex = 7
        Me.credit.Text = "Credit"
        Me.credit.UseVisualStyleBackColor = True
        '
        'cash
        '
        Me.cash.AutoSize = True
        Me.cash.Checked = True
        Me.cash.Font = New System.Drawing.Font("Now", 16.0!, System.Drawing.FontStyle.Bold)
        Me.cash.ForeColor = System.Drawing.Color.Red
        Me.cash.Location = New System.Drawing.Point(915, 240)
        Me.cash.Name = "cash"
        Me.cash.Size = New System.Drawing.Size(104, 36)
        Me.cash.TabIndex = 6
        Me.cash.TabStop = True
        Me.cash.Text = "Cash"
        Me.cash.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cash.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Now", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(679, 244)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(97, 32)
        Me.Label8.TabIndex = 63
        Me.Label8.Text = "*Type:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Now", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(679, 308)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(153, 32)
        Me.Label9.TabIndex = 69
        Me.Label9.Text = "*Quantity:"
        '
        'itemQuantity
        '
        Me.itemQuantity.Font = New System.Drawing.Font("Now Medium", 15.0!)
        Me.itemQuantity.Location = New System.Drawing.Point(855, 308)
        Me.itemQuantity.Name = "itemQuantity"
        Me.itemQuantity.Size = New System.Drawing.Size(460, 37)
        Me.itemQuantity.TabIndex = 9
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Now", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(28, 308)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(185, 32)
        Me.Label10.TabIndex = 68
        Me.Label10.Text = "*Item Name:"
        '
        'cancle
        '
        Me.cancle.BackColor = System.Drawing.Color.Red
        Me.cancle.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cancle.Font = New System.Drawing.Font("Now", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancle.ForeColor = System.Drawing.Color.Ivory
        Me.cancle.Location = New System.Drawing.Point(874, 692)
        Me.cancle.Name = "cancle"
        Me.cancle.Size = New System.Drawing.Size(168, 52)
        Me.cancle.TabIndex = 73
        Me.cancle.Text = "&Cancel"
        Me.cancle.UseVisualStyleBackColor = False
        '
        'clear
        '
        Me.clear.BackColor = System.Drawing.Color.Red
        Me.clear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.clear.Font = New System.Drawing.Font("Now", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clear.ForeColor = System.Drawing.Color.Ivory
        Me.clear.Location = New System.Drawing.Point(689, 692)
        Me.clear.Name = "clear"
        Me.clear.Size = New System.Drawing.Size(168, 52)
        Me.clear.TabIndex = 72
        Me.clear.Text = "Clear"
        Me.clear.UseVisualStyleBackColor = False
        '
        'save
        '
        Me.save.BackColor = System.Drawing.Color.Red
        Me.save.Font = New System.Drawing.Font("Now", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.save.ForeColor = System.Drawing.Color.Ivory
        Me.save.Location = New System.Drawing.Point(491, 692)
        Me.save.Name = "save"
        Me.save.Size = New System.Drawing.Size(168, 52)
        Me.save.TabIndex = 71
        Me.save.Text = "&Save"
        Me.save.UseVisualStyleBackColor = False
        '
        'itemNamelist
        '
        Me.itemNamelist.AllowDrop = True
        Me.itemNamelist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.itemNamelist.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.itemNamelist.Font = New System.Drawing.Font("Now Medium", 15.0!)
        Me.itemNamelist.FormattingEnabled = True
        Me.itemNamelist.Items.AddRange(New Object() {"Oil", "Ghee", "Sugar", "Mustard Oil", "Detergent", "Chocolate"})
        Me.itemNamelist.Location = New System.Drawing.Point(306, 308)
        Me.itemNamelist.Name = "itemNamelist"
        Me.itemNamelist.Size = New System.Drawing.Size(308, 38)
        Me.itemNamelist.TabIndex = 8
        '
        'Add
        '
        Me.Add.BackColor = System.Drawing.Color.Red
        Me.Add.Font = New System.Drawing.Font("Now", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Add.ForeColor = System.Drawing.Color.Ivory
        Me.Add.Location = New System.Drawing.Point(305, 692)
        Me.Add.Name = "Add"
        Me.Add.Size = New System.Drawing.Size(168, 52)
        Me.Add.TabIndex = 75
        Me.Add.Text = "Add"
        Me.Add.UseVisualStyleBackColor = False
        '
        'itemList
        '
        Me.itemList.Font = New System.Drawing.Font("Now Medium", 12.8!)
        Me.itemList.FormattingEnabled = True
        Me.itemList.ItemHeight = 25
        Me.itemList.Location = New System.Drawing.Point(34, 411)
        Me.itemList.Name = "itemList"
        Me.itemList.Size = New System.Drawing.Size(331, 179)
        Me.itemList.TabIndex = 76
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Now", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(28, 368)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(97, 32)
        Me.Label11.TabIndex = 77
        Me.Label11.Text = "Items:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Now", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label12.ForeColor = System.Drawing.Color.Red
        Me.Label12.Location = New System.Drawing.Point(377, 368)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(143, 32)
        Me.Label12.TabIndex = 79
        Me.Label12.Text = "Quantity:"
        '
        'quantityList
        '
        Me.quantityList.Font = New System.Drawing.Font("Now Medium", 12.8!)
        Me.quantityList.FormattingEnabled = True
        Me.quantityList.ItemHeight = 25
        Me.quantityList.Location = New System.Drawing.Point(383, 411)
        Me.quantityList.Name = "quantityList"
        Me.quantityList.Size = New System.Drawing.Size(173, 179)
        Me.quantityList.TabIndex = 78
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Now", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label13.ForeColor = System.Drawing.Color.Red
        Me.Label13.Location = New System.Drawing.Point(570, 368)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(94, 32)
        Me.Label13.TabIndex = 81
        Me.Label13.Text = "Price:"
        '
        'priceList
        '
        Me.priceList.Font = New System.Drawing.Font("Now Medium", 12.8!)
        Me.priceList.FormattingEnabled = True
        Me.priceList.ItemHeight = 25
        Me.priceList.Location = New System.Drawing.Point(576, 411)
        Me.priceList.Name = "priceList"
        Me.priceList.Size = New System.Drawing.Size(257, 179)
        Me.priceList.TabIndex = 80
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Now", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label14.ForeColor = System.Drawing.Color.Red
        Me.Label14.Location = New System.Drawing.Point(1054, 368)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(168, 32)
        Me.Label14.TabIndex = 83
        Me.Label14.Text = "Final Price:"
        '
        'totalPrice
        '
        Me.totalPrice.Font = New System.Drawing.Font("Now Medium", 12.8!)
        Me.totalPrice.FormattingEnabled = True
        Me.totalPrice.ItemHeight = 25
        Me.totalPrice.Location = New System.Drawing.Point(1058, 411)
        Me.totalPrice.Name = "totalPrice"
        Me.totalPrice.Size = New System.Drawing.Size(257, 179)
        Me.totalPrice.TabIndex = 82
        '
        'Discount
        '
        Me.Discount.Font = New System.Drawing.Font("Now Medium", 15.8!)
        Me.Discount.Location = New System.Drawing.Point(186, 609)
        Me.Discount.Name = "Discount"
        Me.Discount.Size = New System.Drawing.Size(308, 39)
        Me.Discount.TabIndex = 88
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Now Medium", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(28, 614)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(152, 34)
        Me.Label6.TabIndex = 89
        Me.Label6.Text = "Discount:"
        '
        'fBill
        '
        Me.fBill.AutoSize = True
        Me.fBill.Font = New System.Drawing.Font("Now", 18.0!, System.Drawing.FontStyle.Bold)
        Me.fBill.ForeColor = System.Drawing.Color.Red
        Me.fBill.Location = New System.Drawing.Point(835, 610)
        Me.fBill.Name = "fBill"
        Me.fBill.Size = New System.Drawing.Size(89, 36)
        Me.fBill.TabIndex = 91
        Me.fBill.Text = "₹0/-"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Now", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(580, 616)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(252, 32)
        Me.Label4.TabIndex = 90
        Me.Label4.Text = "Final Bill Amount:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Now", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label15.ForeColor = System.Drawing.Color.Red
        Me.Label15.Location = New System.Drawing.Point(841, 368)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(77, 32)
        Me.Label15.TabIndex = 94
        Me.Label15.Text = "GST:"
        '
        'gstAmt
        '
        Me.gstAmt.Font = New System.Drawing.Font("Now Medium", 12.8!)
        Me.gstAmt.FormattingEnabled = True
        Me.gstAmt.ItemHeight = 25
        Me.gstAmt.Location = New System.Drawing.Point(847, 411)
        Me.gstAmt.Name = "gstAmt"
        Me.gstAmt.Size = New System.Drawing.Size(192, 179)
        Me.gstAmt.TabIndex = 93
        '
        'addSales
        '
        Me.AcceptButton = Me.Add
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.CancelButton = Me.clear
        Me.ClientSize = New System.Drawing.Size(1351, 818)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.gstAmt)
        Me.Controls.Add(Me.fBill)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Discount)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.totalPrice)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.priceList)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.quantityList)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.itemList)
        Me.Controls.Add(Me.Add)
        Me.Controls.Add(Me.itemNamelist)
        Me.Controls.Add(Me.cancle)
        Me.Controls.Add(Me.clear)
        Me.Controls.Add(Me.save)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.itemQuantity)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.credit)
        Me.Controls.Add(Me.cash)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.tID)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.phone)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.transactionDate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.customerName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "addSales"
        Me.Text = "Sale Transaction"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents customerName As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents transactionDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents phone As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tID As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents credit As System.Windows.Forms.RadioButton
    Friend WithEvents cash As System.Windows.Forms.RadioButton
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents itemQuantity As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cancle As System.Windows.Forms.Button
    Friend WithEvents clear As System.Windows.Forms.Button
    Friend WithEvents save As System.Windows.Forms.Button
    Friend WithEvents itemNamelist As System.Windows.Forms.ComboBox
    Friend WithEvents Add As System.Windows.Forms.Button
    Friend WithEvents itemList As System.Windows.Forms.ListBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents quantityList As System.Windows.Forms.ListBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents priceList As System.Windows.Forms.ListBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents totalPrice As System.Windows.Forms.ListBox
    Friend WithEvents Discount As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents fBill As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents gstAmt As System.Windows.Forms.ListBox
End Class
