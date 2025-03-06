<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class displayPuchase
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
        Me.discountt = New System.Windows.Forms.Label()
        Me.ttype = New System.Windows.Forms.Label()
        Me.tId = New System.Windows.Forms.Label()
        Me.dateTrans = New System.Windows.Forms.Label()
        Me.supplierName = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.gstAmt = New System.Windows.Forms.ListBox()
        Me.fBill = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.totalPrice = New System.Windows.Forms.ListBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.priceList = New System.Windows.Forms.ListBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.quantityList = New System.Windows.Forms.ListBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.itemList = New System.Windows.Forms.ListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cancle = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'discountt
        '
        Me.discountt.AutoSize = True
        Me.discountt.Font = New System.Drawing.Font("Now Medium", 16.2!, System.Drawing.FontStyle.Bold)
        Me.discountt.ForeColor = System.Drawing.Color.Red
        Me.discountt.Location = New System.Drawing.Point(196, 546)
        Me.discountt.Name = "discountt"
        Me.discountt.Size = New System.Drawing.Size(78, 34)
        Me.discountt.TabIndex = 174
        Me.discountt.Text = "00%"
        '
        'ttype
        '
        Me.ttype.AutoSize = True
        Me.ttype.Font = New System.Drawing.Font("Now Medium", 16.2!, System.Drawing.FontStyle.Bold)
        Me.ttype.ForeColor = System.Drawing.Color.Red
        Me.ttype.Location = New System.Drawing.Point(813, 233)
        Me.ttype.Name = "ttype"
        Me.ttype.Size = New System.Drawing.Size(89, 34)
        Me.ttype.TabIndex = 173
        Me.ttype.Text = "Cash"
        '
        'tId
        '
        Me.tId.AutoSize = True
        Me.tId.Font = New System.Drawing.Font("Now Medium", 16.2!, System.Drawing.FontStyle.Bold)
        Me.tId.ForeColor = System.Drawing.Color.Red
        Me.tId.Location = New System.Drawing.Point(295, 233)
        Me.tId.Name = "tId"
        Me.tId.Size = New System.Drawing.Size(87, 34)
        Me.tId.TabIndex = 172
        Me.tId.Text = "0001"
        '
        'dateTrans
        '
        Me.dateTrans.AutoSize = True
        Me.dateTrans.Font = New System.Drawing.Font("Now Medium", 16.2!, System.Drawing.FontStyle.Bold)
        Me.dateTrans.ForeColor = System.Drawing.Color.Red
        Me.dateTrans.Location = New System.Drawing.Point(813, 169)
        Me.dateTrans.Name = "dateTrans"
        Me.dateTrans.Size = New System.Drawing.Size(215, 34)
        Me.dateTrans.TabIndex = 171
        Me.dateTrans.Text = "00/00/0000"
        '
        'supplierName
        '
        Me.supplierName.AutoSize = True
        Me.supplierName.Font = New System.Drawing.Font("Now Medium", 16.2!, System.Drawing.FontStyle.Bold)
        Me.supplierName.ForeColor = System.Drawing.Color.Red
        Me.supplierName.Location = New System.Drawing.Point(295, 169)
        Me.supplierName.Name = "supplierName"
        Me.supplierName.Size = New System.Drawing.Size(220, 34)
        Me.supplierName.TabIndex = 170
        Me.supplierName.Text = "supplierName"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Now", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(851, 304)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(77, 32)
        Me.Label11.TabIndex = 169
        Me.Label11.Text = "GST:"
        '
        'gstAmt
        '
        Me.gstAmt.Font = New System.Drawing.Font("Now Medium", 12.8!)
        Me.gstAmt.FormattingEnabled = True
        Me.gstAmt.ItemHeight = 25
        Me.gstAmt.Location = New System.Drawing.Point(857, 347)
        Me.gstAmt.Name = "gstAmt"
        Me.gstAmt.Size = New System.Drawing.Size(192, 179)
        Me.gstAmt.TabIndex = 168
        '
        'fBill
        '
        Me.fBill.AutoSize = True
        Me.fBill.Font = New System.Drawing.Font("Now", 18.0!, System.Drawing.FontStyle.Bold)
        Me.fBill.ForeColor = System.Drawing.Color.Red
        Me.fBill.Location = New System.Drawing.Point(845, 546)
        Me.fBill.Name = "fBill"
        Me.fBill.Size = New System.Drawing.Size(89, 36)
        Me.fBill.TabIndex = 167
        Me.fBill.Text = "₹0/-"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Now", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(590, 548)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(252, 32)
        Me.Label7.TabIndex = 166
        Me.Label7.Text = "Final Bill Amount:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Now Medium", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(38, 546)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(152, 34)
        Me.Label6.TabIndex = 165
        Me.Label6.Text = "Discount:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Now", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label12.ForeColor = System.Drawing.Color.Red
        Me.Label12.Location = New System.Drawing.Point(1064, 304)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(168, 32)
        Me.Label12.TabIndex = 164
        Me.Label12.Text = "Final Price:"
        '
        'totalPrice
        '
        Me.totalPrice.Font = New System.Drawing.Font("Now Medium", 12.8!)
        Me.totalPrice.FormattingEnabled = True
        Me.totalPrice.ItemHeight = 25
        Me.totalPrice.Location = New System.Drawing.Point(1068, 347)
        Me.totalPrice.Name = "totalPrice"
        Me.totalPrice.Size = New System.Drawing.Size(257, 179)
        Me.totalPrice.TabIndex = 163
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Now", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(580, 304)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(94, 32)
        Me.Label10.TabIndex = 162
        Me.Label10.Text = "Price:"
        '
        'priceList
        '
        Me.priceList.Font = New System.Drawing.Font("Now Medium", 12.8!)
        Me.priceList.FormattingEnabled = True
        Me.priceList.ItemHeight = 25
        Me.priceList.Location = New System.Drawing.Point(586, 347)
        Me.priceList.Name = "priceList"
        Me.priceList.Size = New System.Drawing.Size(257, 179)
        Me.priceList.TabIndex = 161
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Now", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(387, 304)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(143, 32)
        Me.Label9.TabIndex = 160
        Me.Label9.Text = "Quantity:"
        '
        'quantityList
        '
        Me.quantityList.Font = New System.Drawing.Font("Now Medium", 12.8!)
        Me.quantityList.FormattingEnabled = True
        Me.quantityList.ItemHeight = 25
        Me.quantityList.Location = New System.Drawing.Point(393, 347)
        Me.quantityList.Name = "quantityList"
        Me.quantityList.Size = New System.Drawing.Size(173, 179)
        Me.quantityList.TabIndex = 159
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Now", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(38, 304)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(97, 32)
        Me.Label8.TabIndex = 158
        Me.Label8.Text = "Items:"
        '
        'itemList
        '
        Me.itemList.Font = New System.Drawing.Font("Now Medium", 12.8!)
        Me.itemList.FormattingEnabled = True
        Me.itemList.ItemHeight = 25
        Me.itemList.Location = New System.Drawing.Point(44, 347)
        Me.itemList.Name = "itemList"
        Me.itemList.Size = New System.Drawing.Size(331, 179)
        Me.itemList.TabIndex = 157
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Now", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(690, 233)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 32)
        Me.Label5.TabIndex = 156
        Me.Label5.Text = "*Type:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Now Medium", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(39, 233)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(234, 34)
        Me.Label4.TabIndex = 155
        Me.Label4.Text = "Transaction Id:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Now Medium", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(690, 169)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 34)
        Me.Label3.TabIndex = 154
        Me.Label3.Text = "*Date:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Now Medium", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(39, 169)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(215, 34)
        Me.Label2.TabIndex = 153
        Me.Label2.Text = "*Seller Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Now", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(368, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(616, 48)
        Me.Label1.TabIndex = 152
        Me.Label1.Text = "Display Purchase Transaction"
        '
        'cancle
        '
        Me.cancle.BackColor = System.Drawing.Color.Red
        Me.cancle.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cancle.Font = New System.Drawing.Font("Now", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancle.ForeColor = System.Drawing.Color.Ivory
        Me.cancle.Location = New System.Drawing.Point(586, 620)
        Me.cancle.Name = "cancle"
        Me.cancle.Size = New System.Drawing.Size(168, 52)
        Me.cancle.TabIndex = 175
        Me.cancle.Text = "&Cancel"
        Me.cancle.UseVisualStyleBackColor = False
        '
        'displayPuchase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1363, 688)
        Me.Controls.Add(Me.cancle)
        Me.Controls.Add(Me.discountt)
        Me.Controls.Add(Me.ttype)
        Me.Controls.Add(Me.tId)
        Me.Controls.Add(Me.dateTrans)
        Me.Controls.Add(Me.supplierName)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.gstAmt)
        Me.Controls.Add(Me.fBill)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.totalPrice)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.priceList)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.quantityList)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.itemList)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "displayPuchase"
        Me.Text = "displayPuchase"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents discountt As Label
    Friend WithEvents ttype As Label
    Friend WithEvents tId As Label
    Friend WithEvents dateTrans As Label
    Friend WithEvents supplierName As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents gstAmt As ListBox
    Friend WithEvents fBill As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents totalPrice As ListBox
    Friend WithEvents Label10 As Label
    Friend WithEvents priceList As ListBox
    Friend WithEvents Label9 As Label
    Friend WithEvents quantityList As ListBox
    Friend WithEvents Label8 As Label
    Friend WithEvents itemList As ListBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cancle As Button
End Class
