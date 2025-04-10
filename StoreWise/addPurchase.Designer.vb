<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addPurchase
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
        Me.Add = New System.Windows.Forms.Button()
        Me.itemName = New System.Windows.Forms.ComboBox()
        Me.cancle = New System.Windows.Forms.Button()
        Me.clear = New System.Windows.Forms.Button()
        Me.save = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.itemQuantity = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.credit = New System.Windows.Forms.RadioButton()
        Me.cash = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tID = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.transactionDate = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.gstAmt = New System.Windows.Forms.ListBox()
        Me.fBill = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Discount = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.totalPrice = New System.Windows.Forms.ListBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.priceList = New System.Windows.Forms.ListBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.quantityList = New System.Windows.Forms.ListBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.itemList = New System.Windows.Forms.ListBox()
        Me.supplierNameList = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Add
        '
        Me.Add.BackColor = System.Drawing.Color.Red
        Me.Add.Font = New System.Drawing.Font("Now", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Add.ForeColor = System.Drawing.Color.Ivory
        Me.Add.Location = New System.Drawing.Point(313, 601)
        Me.Add.Name = "Add"
        Me.Add.Size = New System.Drawing.Size(168, 52)
        Me.Add.TabIndex = 100
        Me.Add.Text = "Add"
        Me.Add.UseVisualStyleBackColor = False
        '
        'itemName
        '
        Me.itemName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.itemName.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.itemName.Font = New System.Drawing.Font("Now Medium", 15.0!)
        Me.itemName.FormattingEnabled = True
        Me.itemName.Items.AddRange(New Object() {"Oil", "Ghee", "Sugar", "Mustard Oil", "Detergent", "Chocolate"})
        Me.itemName.Location = New System.Drawing.Point(298, 238)
        Me.itemName.Name = "itemName"
        Me.itemName.Size = New System.Drawing.Size(308, 38)
        Me.itemName.TabIndex = 5
        '
        'cancle
        '
        Me.cancle.BackColor = System.Drawing.Color.Red
        Me.cancle.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cancle.Font = New System.Drawing.Font("Now", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancle.ForeColor = System.Drawing.Color.Ivory
        Me.cancle.Location = New System.Drawing.Point(868, 601)
        Me.cancle.Name = "cancle"
        Me.cancle.Size = New System.Drawing.Size(168, 52)
        Me.cancle.TabIndex = 98
        Me.cancle.Text = "&Cancel"
        Me.cancle.UseVisualStyleBackColor = False
        '
        'clear
        '
        Me.clear.BackColor = System.Drawing.Color.Red
        Me.clear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.clear.Font = New System.Drawing.Font("Now", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clear.ForeColor = System.Drawing.Color.Ivory
        Me.clear.Location = New System.Drawing.Point(683, 601)
        Me.clear.Name = "clear"
        Me.clear.Size = New System.Drawing.Size(168, 52)
        Me.clear.TabIndex = 97
        Me.clear.Text = "Clear"
        Me.clear.UseVisualStyleBackColor = False
        '
        'save
        '
        Me.save.BackColor = System.Drawing.Color.Red
        Me.save.Font = New System.Drawing.Font("Now", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.save.ForeColor = System.Drawing.Color.Ivory
        Me.save.Location = New System.Drawing.Point(499, 601)
        Me.save.Name = "save"
        Me.save.Size = New System.Drawing.Size(168, 52)
        Me.save.TabIndex = 96
        Me.save.Text = "&Save"
        Me.save.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Now", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(671, 238)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(153, 32)
        Me.Label7.TabIndex = 94
        Me.Label7.Text = "*Quantity:"
        '
        'itemQuantity
        '
        Me.itemQuantity.Font = New System.Drawing.Font("Now Medium", 15.0!)
        Me.itemQuantity.Location = New System.Drawing.Point(847, 238)
        Me.itemQuantity.Name = "itemQuantity"
        Me.itemQuantity.Size = New System.Drawing.Size(460, 37)
        Me.itemQuantity.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Now", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(20, 238)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(185, 32)
        Me.Label6.TabIndex = 93
        Me.Label6.Text = "*Item Name:"
        '
        'credit
        '
        Me.credit.AutoSize = True
        Me.credit.Font = New System.Drawing.Font("Now", 16.0!, System.Drawing.FontStyle.Bold)
        Me.credit.ForeColor = System.Drawing.Color.Red
        Me.credit.Location = New System.Drawing.Point(1092, 170)
        Me.credit.Name = "credit"
        Me.credit.Size = New System.Drawing.Size(122, 36)
        Me.credit.TabIndex = 4
        Me.credit.Text = "Credit"
        Me.credit.UseVisualStyleBackColor = True
        '
        'cash
        '
        Me.cash.AutoSize = True
        Me.cash.Checked = True
        Me.cash.Font = New System.Drawing.Font("Now", 16.0!, System.Drawing.FontStyle.Bold)
        Me.cash.ForeColor = System.Drawing.Color.Red
        Me.cash.Location = New System.Drawing.Point(907, 170)
        Me.cash.Name = "cash"
        Me.cash.Size = New System.Drawing.Size(104, 36)
        Me.cash.TabIndex = 3
        Me.cash.TabStop = True
        Me.cash.Text = "Cash"
        Me.cash.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cash.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Now", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(671, 174)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 32)
        Me.Label5.TabIndex = 89
        Me.Label5.Text = "*Type:"
        '
        'tID
        '
        Me.tID.Font = New System.Drawing.Font("Now Medium", 15.8!)
        Me.tID.Location = New System.Drawing.Point(298, 172)
        Me.tID.Name = "tID"
        Me.tID.ReadOnly = True
        Me.tID.Size = New System.Drawing.Size(308, 39)
        Me.tID.TabIndex = 88
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Now Medium", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(20, 174)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(234, 34)
        Me.Label4.TabIndex = 87
        Me.Label4.Text = "Transaction Id:"
        '
        'transactionDate
        '
        Me.transactionDate.Font = New System.Drawing.Font("Now Medium", 12.8!)
        Me.transactionDate.Location = New System.Drawing.Point(837, 110)
        Me.transactionDate.Name = "transactionDate"
        Me.transactionDate.Size = New System.Drawing.Size(470, 33)
        Me.transactionDate.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Now Medium", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(671, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 34)
        Me.Label3.TabIndex = 79
        Me.Label3.Text = "*Date:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Now Medium", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(20, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(215, 34)
        Me.Label2.TabIndex = 77
        Me.Label2.Text = "*Seller Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Now", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(394, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(547, 48)
        Me.Label1.TabIndex = 76
        Me.Label1.Text = "Add Purchase Transaction"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Now", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(832, 295)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(77, 32)
        Me.Label11.TabIndex = 114
        Me.Label11.Text = "GST:"
        '
        'gstAmt
        '
        Me.gstAmt.Font = New System.Drawing.Font("Now Medium", 12.8!)
        Me.gstAmt.FormattingEnabled = True
        Me.gstAmt.ItemHeight = 25
        Me.gstAmt.Location = New System.Drawing.Point(838, 338)
        Me.gstAmt.Name = "gstAmt"
        Me.gstAmt.Size = New System.Drawing.Size(192, 179)
        Me.gstAmt.TabIndex = 113
        '
        'fBill
        '
        Me.fBill.AutoSize = True
        Me.fBill.Font = New System.Drawing.Font("Now", 18.0!, System.Drawing.FontStyle.Bold)
        Me.fBill.ForeColor = System.Drawing.Color.Red
        Me.fBill.Location = New System.Drawing.Point(826, 537)
        Me.fBill.Name = "fBill"
        Me.fBill.Size = New System.Drawing.Size(89, 36)
        Me.fBill.TabIndex = 112
        Me.fBill.Text = "₹0/-"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Now", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label14.ForeColor = System.Drawing.Color.Red
        Me.Label14.Location = New System.Drawing.Point(571, 543)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(252, 32)
        Me.Label14.TabIndex = 111
        Me.Label14.Text = "Final Bill Amount:"
        '
        'Discount
        '
        Me.Discount.Font = New System.Drawing.Font("Now Medium", 15.8!)
        Me.Discount.Location = New System.Drawing.Point(177, 536)
        Me.Discount.Name = "Discount"
        Me.Discount.Size = New System.Drawing.Size(308, 39)
        Me.Discount.TabIndex = 7
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Now Medium", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Red
        Me.Label13.Location = New System.Drawing.Point(19, 541)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(152, 34)
        Me.Label13.TabIndex = 110
        Me.Label13.Text = "Discount:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Now", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label12.ForeColor = System.Drawing.Color.Red
        Me.Label12.Location = New System.Drawing.Point(1045, 295)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(168, 32)
        Me.Label12.TabIndex = 108
        Me.Label12.Text = "Final Price:"
        '
        'totalPrice
        '
        Me.totalPrice.Font = New System.Drawing.Font("Now Medium", 12.8!)
        Me.totalPrice.FormattingEnabled = True
        Me.totalPrice.ItemHeight = 25
        Me.totalPrice.Location = New System.Drawing.Point(1049, 338)
        Me.totalPrice.Name = "totalPrice"
        Me.totalPrice.Size = New System.Drawing.Size(257, 179)
        Me.totalPrice.TabIndex = 107
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Now", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(561, 295)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(94, 32)
        Me.Label10.TabIndex = 106
        Me.Label10.Text = "Price:"
        '
        'priceList
        '
        Me.priceList.Font = New System.Drawing.Font("Now Medium", 12.8!)
        Me.priceList.FormattingEnabled = True
        Me.priceList.ItemHeight = 25
        Me.priceList.Location = New System.Drawing.Point(567, 338)
        Me.priceList.Name = "priceList"
        Me.priceList.Size = New System.Drawing.Size(257, 179)
        Me.priceList.TabIndex = 105
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Now", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(368, 295)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(143, 32)
        Me.Label9.TabIndex = 104
        Me.Label9.Text = "Quantity:"
        '
        'quantityList
        '
        Me.quantityList.Font = New System.Drawing.Font("Now Medium", 12.8!)
        Me.quantityList.FormattingEnabled = True
        Me.quantityList.ItemHeight = 25
        Me.quantityList.Location = New System.Drawing.Point(374, 338)
        Me.quantityList.Name = "quantityList"
        Me.quantityList.Size = New System.Drawing.Size(173, 179)
        Me.quantityList.TabIndex = 103
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Now", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(19, 295)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(97, 32)
        Me.Label8.TabIndex = 102
        Me.Label8.Text = "Items:"
        '
        'itemList
        '
        Me.itemList.Font = New System.Drawing.Font("Now Medium", 12.8!)
        Me.itemList.FormattingEnabled = True
        Me.itemList.ItemHeight = 25
        Me.itemList.Location = New System.Drawing.Point(25, 338)
        Me.itemList.Name = "itemList"
        Me.itemList.Size = New System.Drawing.Size(331, 179)
        Me.itemList.TabIndex = 101
        '
        'supplierNameList
        '
        Me.supplierNameList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.supplierNameList.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.supplierNameList.Font = New System.Drawing.Font("Now Medium", 15.0!)
        Me.supplierNameList.FormattingEnabled = True
        Me.supplierNameList.Items.AddRange(New Object() {"Sunfeast", "Cremica", "Nestle"})
        Me.supplierNameList.Location = New System.Drawing.Point(298, 108)
        Me.supplierNameList.Name = "supplierNameList"
        Me.supplierNameList.Size = New System.Drawing.Size(308, 38)
        Me.supplierNameList.TabIndex = 1
        '
        'addPurchase
        '
        Me.AcceptButton = Me.Add
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cancle
        Me.ClientSize = New System.Drawing.Size(1327, 680)
        Me.Controls.Add(Me.supplierNameList)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.gstAmt)
        Me.Controls.Add(Me.fBill)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Discount)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.totalPrice)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.priceList)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.quantityList)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.itemList)
        Me.Controls.Add(Me.Add)
        Me.Controls.Add(Me.itemName)
        Me.Controls.Add(Me.cancle)
        Me.Controls.Add(Me.clear)
        Me.Controls.Add(Me.save)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.itemQuantity)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.credit)
        Me.Controls.Add(Me.cash)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tID)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.transactionDate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "addPurchase"
        Me.Text = "purchase"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Add As System.Windows.Forms.Button
    Friend WithEvents itemName As System.Windows.Forms.ComboBox
    Friend WithEvents cancle As System.Windows.Forms.Button
    Friend WithEvents clear As System.Windows.Forms.Button
    Friend WithEvents save As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents itemQuantity As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents credit As System.Windows.Forms.RadioButton
    Friend WithEvents cash As System.Windows.Forms.RadioButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tID As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents transactionDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label11 As Label
    Friend WithEvents gstAmt As ListBox
    Friend WithEvents fBill As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Discount As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents totalPrice As ListBox
    Friend WithEvents Label10 As Label
    Friend WithEvents priceList As ListBox
    Friend WithEvents Label9 As Label
    Friend WithEvents quantityList As ListBox
    Friend WithEvents Label8 As Label
    Friend WithEvents itemList As ListBox
    Friend WithEvents supplierNameList As ComboBox
End Class
