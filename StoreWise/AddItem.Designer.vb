<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddItem
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.clear = New System.Windows.Forms.Button()
        Me.save = New System.Windows.Forms.Button()
        Me.itemName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.itemQuantity = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.itemUnit = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.itemCost = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.itemSP = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.itemGST = New System.Windows.Forms.ComboBox()
        Me.cancle = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Now", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(317, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(202, 48)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Add Item"
        '
        'clear
        '
        Me.clear.BackColor = System.Drawing.Color.Red
        Me.clear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.clear.Font = New System.Drawing.Font("Now", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clear.ForeColor = System.Drawing.Color.Ivory
        Me.clear.Location = New System.Drawing.Point(336, 495)
        Me.clear.Name = "clear"
        Me.clear.Size = New System.Drawing.Size(168, 52)
        Me.clear.TabIndex = 12
        Me.clear.Text = "Clear"
        Me.clear.UseVisualStyleBackColor = False
        '
        'save
        '
        Me.save.BackColor = System.Drawing.Color.Red
        Me.save.Font = New System.Drawing.Font("Now", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.save.ForeColor = System.Drawing.Color.Ivory
        Me.save.Location = New System.Drawing.Point(152, 495)
        Me.save.Name = "save"
        Me.save.Size = New System.Drawing.Size(168, 52)
        Me.save.TabIndex = 11
        Me.save.Text = "Save"
        Me.save.UseVisualStyleBackColor = False
        '
        'itemName
        '
        Me.itemName.Font = New System.Drawing.Font("Now Medium", 15.8!)
        Me.itemName.Location = New System.Drawing.Point(441, 110)
        Me.itemName.Name = "itemName"
        Me.itemName.Size = New System.Drawing.Size(388, 39)
        Me.itemName.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Now", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(26, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(176, 32)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Item Name:"
        '
        'itemQuantity
        '
        Me.itemQuantity.Font = New System.Drawing.Font("Now Medium", 15.0!)
        Me.itemQuantity.Location = New System.Drawing.Point(441, 231)
        Me.itemQuantity.Name = "itemQuantity"
        Me.itemQuantity.Size = New System.Drawing.Size(388, 37)
        Me.itemQuantity.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Now", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(26, 176)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 32)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Unit:"
        '
        'itemUnit
        '
        Me.itemUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.itemUnit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.itemUnit.Font = New System.Drawing.Font("Now Medium", 15.0!)
        Me.itemUnit.FormattingEnabled = True
        Me.itemUnit.Items.AddRange(New Object() {"Pcs.", "Kgs.", "Dozen", "Gms.", "Meter", "Units"})
        Me.itemUnit.Location = New System.Drawing.Point(441, 170)
        Me.itemUnit.Name = "itemUnit"
        Me.itemUnit.Size = New System.Drawing.Size(388, 38)
        Me.itemUnit.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Now", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(26, 236)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(144, 32)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Quantity:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Now", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(26, 299)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(201, 32)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Cost per unit:"
        '
        'itemCost
        '
        Me.itemCost.Font = New System.Drawing.Font("Now Medium", 15.0!)
        Me.itemCost.Location = New System.Drawing.Point(441, 294)
        Me.itemCost.Name = "itemCost"
        Me.itemCost.Size = New System.Drawing.Size(388, 37)
        Me.itemCost.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Now", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(26, 363)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(314, 32)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Selling Price per Unit:"
        '
        'itemSP
        '
        Me.itemSP.Font = New System.Drawing.Font("Now Medium", 15.0!)
        Me.itemSP.Location = New System.Drawing.Point(441, 358)
        Me.itemSP.Name = "itemSP"
        Me.itemSP.Size = New System.Drawing.Size(388, 37)
        Me.itemSP.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Now", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(26, 428)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(133, 32)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "GST (%):"
        '
        'itemGST
        '
        Me.itemGST.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.itemGST.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.itemGST.Font = New System.Drawing.Font("Now Medium", 15.0!)
        Me.itemGST.FormattingEnabled = True
        Me.itemGST.Items.AddRange(New Object() {"5%", "12%", "18%", "28%", "Exempt"})
        Me.itemGST.Location = New System.Drawing.Point(441, 422)
        Me.itemGST.Name = "itemGST"
        Me.itemGST.Size = New System.Drawing.Size(388, 38)
        Me.itemGST.TabIndex = 7
        '
        'cancle
        '
        Me.cancle.BackColor = System.Drawing.Color.Red
        Me.cancle.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cancle.Font = New System.Drawing.Font("Now", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancle.ForeColor = System.Drawing.Color.Ivory
        Me.cancle.Location = New System.Drawing.Point(521, 495)
        Me.cancle.Name = "cancle"
        Me.cancle.Size = New System.Drawing.Size(168, 52)
        Me.cancle.TabIndex = 22
        Me.cancle.Text = "Cancle"
        Me.cancle.UseVisualStyleBackColor = False
        '
        'AddItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(877, 593)
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
        Me.Controls.Add(Me.clear)
        Me.Controls.Add(Me.save)
        Me.Controls.Add(Me.itemName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "AddItem"
        Me.Text = "Add Item"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents clear As System.Windows.Forms.Button
    Friend WithEvents save As System.Windows.Forms.Button
    Friend WithEvents itemName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents itemQuantity As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents itemUnit As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents itemCost As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents itemSP As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents itemGST As System.Windows.Forms.ComboBox
    Friend WithEvents cancle As System.Windows.Forms.Button
End Class
