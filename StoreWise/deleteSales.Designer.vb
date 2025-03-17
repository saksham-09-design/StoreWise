<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class deleteSales
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
        Me.discountt = New System.Windows.Forms.Label()
        Me.ttype = New System.Windows.Forms.Label()
        Me.tId = New System.Windows.Forms.Label()
        Me.dateTrans = New System.Windows.Forms.Label()
        Me.customerName = New System.Windows.Forms.Label()
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
        Me.Delete = New System.Windows.Forms.Button()
        Me.cancle = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.phone = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'discountt
        '
        Me.discountt.AutoSize = True
        Me.discountt.Font = New System.Drawing.Font("Now Medium", 16.2!, System.Drawing.FontStyle.Bold)
        Me.discountt.ForeColor = System.Drawing.Color.Red
        Me.discountt.Location = New System.Drawing.Point(175, 547)
        Me.discountt.Name = "discountt"
        Me.discountt.Size = New System.Drawing.Size(78, 34)
        Me.discountt.TabIndex = 176
        Me.discountt.Text = "00%"
        '
        'ttype
        '
        Me.ttype.AutoSize = True
        Me.ttype.Font = New System.Drawing.Font("Now Medium", 16.2!, System.Drawing.FontStyle.Bold)
        Me.ttype.ForeColor = System.Drawing.Color.Red
        Me.ttype.Location = New System.Drawing.Point(792, 234)
        Me.ttype.Name = "ttype"
        Me.ttype.Size = New System.Drawing.Size(89, 34)
        Me.ttype.TabIndex = 175
        Me.ttype.Text = "Cash"
        '
        'tId
        '
        Me.tId.AutoSize = True
        Me.tId.Font = New System.Drawing.Font("Now Medium", 16.2!, System.Drawing.FontStyle.Bold)
        Me.tId.ForeColor = System.Drawing.Color.Red
        Me.tId.Location = New System.Drawing.Point(274, 234)
        Me.tId.Name = "tId"
        Me.tId.Size = New System.Drawing.Size(87, 34)
        Me.tId.TabIndex = 174
        Me.tId.Text = "0001"
        '
        'dateTrans
        '
        Me.dateTrans.AutoSize = True
        Me.dateTrans.Font = New System.Drawing.Font("Now Medium", 16.2!, System.Drawing.FontStyle.Bold)
        Me.dateTrans.ForeColor = System.Drawing.Color.Red
        Me.dateTrans.Location = New System.Drawing.Point(792, 127)
        Me.dateTrans.Name = "dateTrans"
        Me.dateTrans.Size = New System.Drawing.Size(215, 34)
        Me.dateTrans.TabIndex = 173
        Me.dateTrans.Text = "00/00/0000"
        '
        'customerName
        '
        Me.customerName.AutoSize = True
        Me.customerName.Font = New System.Drawing.Font("Now Medium", 16.2!, System.Drawing.FontStyle.Bold)
        Me.customerName.ForeColor = System.Drawing.Color.Red
        Me.customerName.Location = New System.Drawing.Point(274, 127)
        Me.customerName.Name = "customerName"
        Me.customerName.Size = New System.Drawing.Size(236, 34)
        Me.customerName.TabIndex = 172
        Me.customerName.Text = "customerName"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Now", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(830, 305)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(77, 32)
        Me.Label11.TabIndex = 171
        Me.Label11.Text = "GST:"
        '
        'gstAmt
        '
        Me.gstAmt.Font = New System.Drawing.Font("Now Medium", 12.8!)
        Me.gstAmt.FormattingEnabled = True
        Me.gstAmt.ItemHeight = 25
        Me.gstAmt.Location = New System.Drawing.Point(836, 348)
        Me.gstAmt.Name = "gstAmt"
        Me.gstAmt.Size = New System.Drawing.Size(192, 179)
        Me.gstAmt.TabIndex = 170
        '
        'fBill
        '
        Me.fBill.AutoSize = True
        Me.fBill.Font = New System.Drawing.Font("Now", 18.0!, System.Drawing.FontStyle.Bold)
        Me.fBill.ForeColor = System.Drawing.Color.Red
        Me.fBill.Location = New System.Drawing.Point(824, 547)
        Me.fBill.Name = "fBill"
        Me.fBill.Size = New System.Drawing.Size(89, 36)
        Me.fBill.TabIndex = 169
        Me.fBill.Text = "₹0/-"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Now", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(569, 549)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(252, 32)
        Me.Label7.TabIndex = 168
        Me.Label7.Text = "Final Bill Amount:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Now Medium", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(17, 547)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(152, 34)
        Me.Label6.TabIndex = 167
        Me.Label6.Text = "Discount:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Now", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label12.ForeColor = System.Drawing.Color.Red
        Me.Label12.Location = New System.Drawing.Point(1043, 305)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(168, 32)
        Me.Label12.TabIndex = 166
        Me.Label12.Text = "Final Price:"
        '
        'totalPrice
        '
        Me.totalPrice.Font = New System.Drawing.Font("Now Medium", 12.8!)
        Me.totalPrice.FormattingEnabled = True
        Me.totalPrice.ItemHeight = 25
        Me.totalPrice.Location = New System.Drawing.Point(1047, 348)
        Me.totalPrice.Name = "totalPrice"
        Me.totalPrice.Size = New System.Drawing.Size(257, 179)
        Me.totalPrice.TabIndex = 165
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Now", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(559, 305)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(94, 32)
        Me.Label10.TabIndex = 164
        Me.Label10.Text = "Price:"
        '
        'priceList
        '
        Me.priceList.Font = New System.Drawing.Font("Now Medium", 12.8!)
        Me.priceList.FormattingEnabled = True
        Me.priceList.ItemHeight = 25
        Me.priceList.Location = New System.Drawing.Point(565, 348)
        Me.priceList.Name = "priceList"
        Me.priceList.Size = New System.Drawing.Size(257, 179)
        Me.priceList.TabIndex = 163
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Now", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(366, 305)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(143, 32)
        Me.Label9.TabIndex = 162
        Me.Label9.Text = "Quantity:"
        '
        'quantityList
        '
        Me.quantityList.Font = New System.Drawing.Font("Now Medium", 12.8!)
        Me.quantityList.FormattingEnabled = True
        Me.quantityList.ItemHeight = 25
        Me.quantityList.Location = New System.Drawing.Point(372, 348)
        Me.quantityList.Name = "quantityList"
        Me.quantityList.Size = New System.Drawing.Size(173, 179)
        Me.quantityList.TabIndex = 161
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Now", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(17, 305)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(97, 32)
        Me.Label8.TabIndex = 160
        Me.Label8.Text = "Items:"
        '
        'itemList
        '
        Me.itemList.Font = New System.Drawing.Font("Now Medium", 12.8!)
        Me.itemList.FormattingEnabled = True
        Me.itemList.ItemHeight = 25
        Me.itemList.Location = New System.Drawing.Point(23, 348)
        Me.itemList.Name = "itemList"
        Me.itemList.Size = New System.Drawing.Size(331, 179)
        Me.itemList.TabIndex = 159
        '
        'Delete
        '
        Me.Delete.BackColor = System.Drawing.Color.Red
        Me.Delete.Font = New System.Drawing.Font("Now", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Delete.ForeColor = System.Drawing.Color.Ivory
        Me.Delete.Location = New System.Drawing.Point(408, 621)
        Me.Delete.Name = "Delete"
        Me.Delete.Size = New System.Drawing.Size(168, 52)
        Me.Delete.TabIndex = 158
        Me.Delete.Text = "Delete"
        Me.Delete.UseVisualStyleBackColor = False
        '
        'cancle
        '
        Me.cancle.BackColor = System.Drawing.Color.Red
        Me.cancle.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cancle.Font = New System.Drawing.Font("Now", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancle.ForeColor = System.Drawing.Color.Ivory
        Me.cancle.Location = New System.Drawing.Point(780, 621)
        Me.cancle.Name = "cancle"
        Me.cancle.Size = New System.Drawing.Size(168, 52)
        Me.cancle.TabIndex = 157
        Me.cancle.Text = "&Cancel"
        Me.cancle.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Now", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(669, 234)
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
        Me.Label4.Location = New System.Drawing.Point(18, 234)
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
        Me.Label3.Location = New System.Drawing.Point(669, 127)
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
        Me.Label2.Location = New System.Drawing.Point(18, 127)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(261, 34)
        Me.Label2.TabIndex = 153
        Me.Label2.Text = "Customer Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Now", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(405, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(502, 48)
        Me.Label1.TabIndex = 152
        Me.Label1.Text = "Delete Sale Transaction"
        '
        'phone
        '
        Me.phone.AutoSize = True
        Me.phone.Font = New System.Drawing.Font("Now Medium", 16.2!, System.Drawing.FontStyle.Bold)
        Me.phone.ForeColor = System.Drawing.Color.Red
        Me.phone.Location = New System.Drawing.Point(274, 181)
        Me.phone.Name = "phone"
        Me.phone.Size = New System.Drawing.Size(238, 34)
        Me.phone.TabIndex = 178
        Me.phone.Text = "customerPhone"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Now Medium", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Red
        Me.Label13.Location = New System.Drawing.Point(18, 181)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(263, 34)
        Me.Label13.TabIndex = 177
        Me.Label13.Text = "Customer Phone:"
        '
        'deleteSales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1321, 708)
        Me.Controls.Add(Me.phone)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.discountt)
        Me.Controls.Add(Me.ttype)
        Me.Controls.Add(Me.tId)
        Me.Controls.Add(Me.dateTrans)
        Me.Controls.Add(Me.customerName)
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
        Me.Controls.Add(Me.Delete)
        Me.Controls.Add(Me.cancle)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "deleteSales"
        Me.Text = "Delete Sales"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents discountt As Label
    Friend WithEvents ttype As Label
    Friend WithEvents tId As Label
    Friend WithEvents dateTrans As Label
    Friend WithEvents customerName As Label
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
    Friend WithEvents Delete As Button
    Friend WithEvents cancle As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents phone As Label
    Friend WithEvents Label13 As Label
End Class
