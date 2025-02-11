<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SearchItem
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
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cancle = New System.Windows.Forms.Button()
        Me.itemGST = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.itemSP = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.itemCost = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.itemUnit = New System.Windows.Forms.ComboBox()
        Me.itemQuantity = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.itemName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.reOrder = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ComboBox1.Font = New System.Drawing.Font("Now Medium", 15.0!)
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Oil", "Ghee", "Sugar", "Mustard Oil", "Detergent", "Chocolate"})
        Me.ComboBox1.Location = New System.Drawing.Point(521, 110)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(388, 38)
        Me.ComboBox1.TabIndex = 76
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Now", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(106, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(170, 32)
        Me.Label3.TabIndex = 75
        Me.Label3.Text = "Select Item"
        '
        'cancle
        '
        Me.cancle.BackColor = System.Drawing.Color.Red
        Me.cancle.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cancle.Font = New System.Drawing.Font("Now", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancle.ForeColor = System.Drawing.Color.Ivory
        Me.cancle.Location = New System.Drawing.Point(426, 607)
        Me.cancle.Name = "cancle"
        Me.cancle.Size = New System.Drawing.Size(168, 52)
        Me.cancle.TabIndex = 74
        Me.cancle.Text = "Cancel"
        Me.cancle.UseVisualStyleBackColor = False
        Me.cancle.Visible = False
        '
        'itemGST
        '
        Me.itemGST.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.itemGST.Enabled = False
        Me.itemGST.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.itemGST.Font = New System.Drawing.Font("Now Medium", 15.0!)
        Me.itemGST.FormattingEnabled = True
        Me.itemGST.Items.AddRange(New Object() {"5%", "12%", "18%", "28%", "Exempt"})
        Me.itemGST.Location = New System.Drawing.Point(521, 524)
        Me.itemGST.Name = "itemGST"
        Me.itemGST.Size = New System.Drawing.Size(388, 38)
        Me.itemGST.TabIndex = 65
        Me.itemGST.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Now", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(106, 530)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(133, 32)
        Me.Label8.TabIndex = 73
        Me.Label8.Text = "GST (%):"
        Me.Label8.Visible = False
        '
        'itemSP
        '
        Me.itemSP.Font = New System.Drawing.Font("Now Medium", 15.0!)
        Me.itemSP.Location = New System.Drawing.Point(521, 460)
        Me.itemSP.Name = "itemSP"
        Me.itemSP.ReadOnly = True
        Me.itemSP.Size = New System.Drawing.Size(388, 37)
        Me.itemSP.TabIndex = 64
        Me.itemSP.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Now", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(106, 465)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(314, 32)
        Me.Label7.TabIndex = 72
        Me.Label7.Text = "Selling Price per Unit:"
        Me.Label7.Visible = False
        '
        'itemCost
        '
        Me.itemCost.Font = New System.Drawing.Font("Now Medium", 15.0!)
        Me.itemCost.Location = New System.Drawing.Point(521, 396)
        Me.itemCost.Name = "itemCost"
        Me.itemCost.ReadOnly = True
        Me.itemCost.Size = New System.Drawing.Size(388, 37)
        Me.itemCost.TabIndex = 63
        Me.itemCost.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Now", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(106, 401)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(201, 32)
        Me.Label6.TabIndex = 71
        Me.Label6.Text = "Cost per unit:"
        Me.Label6.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Now", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(106, 293)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(144, 32)
        Me.Label5.TabIndex = 70
        Me.Label5.Text = "Quantity:"
        Me.Label5.Visible = False
        '
        'itemUnit
        '
        Me.itemUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.itemUnit.Enabled = False
        Me.itemUnit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.itemUnit.Font = New System.Drawing.Font("Now Medium", 15.0!)
        Me.itemUnit.FormattingEnabled = True
        Me.itemUnit.Items.AddRange(New Object() {"Pcs.", "Kgs.", "Dozen", "Gms.", "Meter", "Units"})
        Me.itemUnit.Location = New System.Drawing.Point(521, 227)
        Me.itemUnit.Name = "itemUnit"
        Me.itemUnit.Size = New System.Drawing.Size(388, 38)
        Me.itemUnit.TabIndex = 61
        Me.itemUnit.Visible = False
        '
        'itemQuantity
        '
        Me.itemQuantity.Font = New System.Drawing.Font("Now Medium", 15.0!)
        Me.itemQuantity.Location = New System.Drawing.Point(521, 288)
        Me.itemQuantity.Name = "itemQuantity"
        Me.itemQuantity.ReadOnly = True
        Me.itemQuantity.Size = New System.Drawing.Size(388, 37)
        Me.itemQuantity.TabIndex = 62
        Me.itemQuantity.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Now", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(106, 233)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 32)
        Me.Label4.TabIndex = 69
        Me.Label4.Text = "Unit:"
        Me.Label4.Visible = False
        '
        'itemName
        '
        Me.itemName.Font = New System.Drawing.Font("Now Medium", 15.8!)
        Me.itemName.Location = New System.Drawing.Point(521, 167)
        Me.itemName.Name = "itemName"
        Me.itemName.ReadOnly = True
        Me.itemName.Size = New System.Drawing.Size(388, 39)
        Me.itemName.TabIndex = 60
        Me.itemName.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Now", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(106, 176)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(176, 32)
        Me.Label2.TabIndex = 67
        Me.Label2.Text = "Item Name:"
        Me.Label2.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Now", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(373, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(265, 48)
        Me.Label1.TabIndex = 66
        Me.Label1.Text = "Search Item"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Now", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(106, 349)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(232, 32)
        Me.Label9.TabIndex = 78
        Me.Label9.Text = "Re-Order Level:"
        Me.Label9.Visible = False
        '
        'reOrder
        '
        Me.reOrder.Font = New System.Drawing.Font("Now Medium", 15.0!)
        Me.reOrder.Location = New System.Drawing.Point(521, 344)
        Me.reOrder.Name = "reOrder"
        Me.reOrder.ReadOnly = True
        Me.reOrder.Size = New System.Drawing.Size(388, 37)
        Me.reOrder.TabIndex = 77
        Me.reOrder.Visible = False
        '
        'SearchItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cancle
        Me.ClientSize = New System.Drawing.Size(1020, 690)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.reOrder)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cancle)
        Me.Controls.Add(Me.itemGST)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.itemSP)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.itemCost)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.itemUnit)
        Me.Controls.Add(Me.itemQuantity)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.itemName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "SearchItem"
        Me.Text = "Search Item"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cancle As System.Windows.Forms.Button
    Friend WithEvents itemGST As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents itemSP As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents itemCost As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents itemUnit As System.Windows.Forms.ComboBox
    Friend WithEvents itemQuantity As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents itemName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents reOrder As System.Windows.Forms.TextBox
End Class
