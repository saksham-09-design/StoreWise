<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class modifyPurchase
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.itemQuantity = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.credit = New System.Windows.Forms.RadioButton()
        Me.cash = New System.Windows.Forms.RadioButton()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tID = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.transactionDate = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.sellerName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Add
        '
        Me.Add.BackColor = System.Drawing.Color.Red
        Me.Add.Font = New System.Drawing.Font("Now", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Add.ForeColor = System.Drawing.Color.Ivory
        Me.Add.Location = New System.Drawing.Point(306, 597)
        Me.Add.Name = "Add"
        Me.Add.Size = New System.Drawing.Size(168, 52)
        Me.Add.TabIndex = 119
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
        Me.itemName.Location = New System.Drawing.Point(297, 302)
        Me.itemName.Name = "itemName"
        Me.itemName.Size = New System.Drawing.Size(308, 38)
        Me.itemName.TabIndex = 118
        '
        'cancle
        '
        Me.cancle.BackColor = System.Drawing.Color.Red
        Me.cancle.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cancle.Font = New System.Drawing.Font("Now", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancle.ForeColor = System.Drawing.Color.Ivory
        Me.cancle.Location = New System.Drawing.Point(861, 597)
        Me.cancle.Name = "cancle"
        Me.cancle.Size = New System.Drawing.Size(168, 52)
        Me.cancle.TabIndex = 117
        Me.cancle.Text = "&Cancel"
        Me.cancle.UseVisualStyleBackColor = False
        '
        'clear
        '
        Me.clear.BackColor = System.Drawing.Color.Red
        Me.clear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.clear.Font = New System.Drawing.Font("Now", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clear.ForeColor = System.Drawing.Color.Ivory
        Me.clear.Location = New System.Drawing.Point(676, 597)
        Me.clear.Name = "clear"
        Me.clear.Size = New System.Drawing.Size(168, 52)
        Me.clear.TabIndex = 116
        Me.clear.Text = "Clear"
        Me.clear.UseVisualStyleBackColor = False
        '
        'save
        '
        Me.save.BackColor = System.Drawing.Color.Red
        Me.save.Font = New System.Drawing.Font("Now", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.save.ForeColor = System.Drawing.Color.Ivory
        Me.save.Location = New System.Drawing.Point(492, 597)
        Me.save.Name = "save"
        Me.save.Size = New System.Drawing.Size(168, 52)
        Me.save.TabIndex = 115
        Me.save.Text = "&Save"
        Me.save.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(36, 370)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1270, 198)
        Me.DataGridView1.TabIndex = 114
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Now", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(670, 302)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(154, 32)
        Me.Label9.TabIndex = 113
        Me.Label9.Text = "*Quantity:"
        '
        'itemQuantity
        '
        Me.itemQuantity.Font = New System.Drawing.Font("Now Medium", 15.0!)
        Me.itemQuantity.Location = New System.Drawing.Point(846, 302)
        Me.itemQuantity.Name = "itemQuantity"
        Me.itemQuantity.Size = New System.Drawing.Size(460, 37)
        Me.itemQuantity.TabIndex = 111
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Now", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(19, 302)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(186, 32)
        Me.Label10.TabIndex = 112
        Me.Label10.Text = "*Item Name:"
        '
        'credit
        '
        Me.credit.AutoSize = True
        Me.credit.Font = New System.Drawing.Font("Now", 16.0!, System.Drawing.FontStyle.Bold)
        Me.credit.ForeColor = System.Drawing.Color.Red
        Me.credit.Location = New System.Drawing.Point(1091, 234)
        Me.credit.Name = "credit"
        Me.credit.Size = New System.Drawing.Size(123, 36)
        Me.credit.TabIndex = 110
        Me.credit.Text = "Credit"
        Me.credit.UseVisualStyleBackColor = True
        '
        'cash
        '
        Me.cash.AutoSize = True
        Me.cash.Checked = True
        Me.cash.Font = New System.Drawing.Font("Now", 16.0!, System.Drawing.FontStyle.Bold)
        Me.cash.ForeColor = System.Drawing.Color.Red
        Me.cash.Location = New System.Drawing.Point(906, 234)
        Me.cash.Name = "cash"
        Me.cash.Size = New System.Drawing.Size(105, 36)
        Me.cash.TabIndex = 109
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
        Me.Label8.Location = New System.Drawing.Point(670, 238)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(98, 32)
        Me.Label8.TabIndex = 108
        Me.Label8.Text = "*Type:"
        '
        'tID
        '
        Me.tID.Font = New System.Drawing.Font("Now Medium", 15.8!)
        Me.tID.Location = New System.Drawing.Point(297, 236)
        Me.tID.Name = "tID"
        Me.tID.ReadOnly = True
        Me.tID.Size = New System.Drawing.Size(308, 39)
        Me.tID.TabIndex = 107
        Me.tID.Text = "1"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Now Medium", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(19, 238)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(234, 34)
        Me.Label7.TabIndex = 106
        Me.Label7.Text = "Transaction Id:"
        '
        'transactionDate
        '
        Me.transactionDate.Font = New System.Drawing.Font("Now Medium", 12.8!)
        Me.transactionDate.Location = New System.Drawing.Point(836, 174)
        Me.transactionDate.Name = "transactionDate"
        Me.transactionDate.Size = New System.Drawing.Size(470, 33)
        Me.transactionDate.TabIndex = 105
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Now Medium", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(670, 174)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 34)
        Me.Label3.TabIndex = 104
        Me.Label3.Text = "*Date:"
        '
        'sellerName
        '
        Me.sellerName.Font = New System.Drawing.Font("Now Medium", 15.8!)
        Me.sellerName.Location = New System.Drawing.Point(297, 172)
        Me.sellerName.Name = "sellerName"
        Me.sellerName.Size = New System.Drawing.Size(308, 39)
        Me.sellerName.TabIndex = 103
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Now Medium", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(19, 174)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(215, 34)
        Me.Label2.TabIndex = 102
        Me.Label2.Text = "*Seller Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Now", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(361, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(608, 48)
        Me.Label1.TabIndex = 101
        Me.Label1.Text = "Modify Purchase Transaction"
        '
        'modifyPurchase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1325, 741)
        Me.Controls.Add(Me.Add)
        Me.Controls.Add(Me.itemName)
        Me.Controls.Add(Me.cancle)
        Me.Controls.Add(Me.clear)
        Me.Controls.Add(Me.save)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.itemQuantity)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.credit)
        Me.Controls.Add(Me.cash)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.tID)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.transactionDate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.sellerName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "modifyPurchase"
        Me.Text = "modifyPurchase"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Add As System.Windows.Forms.Button
    Friend WithEvents itemName As System.Windows.Forms.ComboBox
    Friend WithEvents cancle As System.Windows.Forms.Button
    Friend WithEvents clear As System.Windows.Forms.Button
    Friend WithEvents save As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents itemQuantity As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents credit As System.Windows.Forms.RadioButton
    Friend WithEvents cash As System.Windows.Forms.RadioButton
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tID As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents transactionDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents sellerName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
