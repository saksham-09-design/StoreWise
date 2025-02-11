<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeleteItem
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
        Me.Delete = New System.Windows.Forms.Button()
        Me.itemName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ComboBox1.Font = New System.Drawing.Font("Now Medium", 15.0!)
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Oil", "Ghee", "Sugar", "Mustard Oil", "Detergent", "Chocolate"})
        Me.ComboBox1.Location = New System.Drawing.Point(529, 134)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(388, 38)
        Me.ComboBox1.TabIndex = 59
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Now", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(114, 140)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(170, 32)
        Me.Label3.TabIndex = 58
        Me.Label3.Text = "Select Item"
        '
        'cancle
        '
        Me.cancle.BackColor = System.Drawing.Color.Red
        Me.cancle.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cancle.Font = New System.Drawing.Font("Now", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancle.ForeColor = System.Drawing.Color.Ivory
        Me.cancle.Location = New System.Drawing.Point(609, 576)
        Me.cancle.Name = "cancle"
        Me.cancle.Size = New System.Drawing.Size(168, 52)
        Me.cancle.TabIndex = 57
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
        Me.itemGST.Location = New System.Drawing.Point(529, 503)
        Me.itemGST.Name = "itemGST"
        Me.itemGST.Size = New System.Drawing.Size(388, 38)
        Me.itemGST.TabIndex = 47
        Me.itemGST.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Now", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(114, 509)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(133, 32)
        Me.Label8.TabIndex = 56
        Me.Label8.Text = "GST (%):"
        Me.Label8.Visible = False
        '
        'itemSP
        '
        Me.itemSP.Font = New System.Drawing.Font("Now Medium", 15.0!)
        Me.itemSP.Location = New System.Drawing.Point(529, 439)
        Me.itemSP.Name = "itemSP"
        Me.itemSP.ReadOnly = True
        Me.itemSP.Size = New System.Drawing.Size(388, 37)
        Me.itemSP.TabIndex = 46
        Me.itemSP.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Now", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(114, 444)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(314, 32)
        Me.Label7.TabIndex = 55
        Me.Label7.Text = "Selling Price per Unit:"
        Me.Label7.Visible = False
        '
        'itemCost
        '
        Me.itemCost.Font = New System.Drawing.Font("Now Medium", 15.0!)
        Me.itemCost.Location = New System.Drawing.Point(529, 375)
        Me.itemCost.Name = "itemCost"
        Me.itemCost.ReadOnly = True
        Me.itemCost.Size = New System.Drawing.Size(388, 37)
        Me.itemCost.TabIndex = 45
        Me.itemCost.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Now", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(114, 380)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(201, 32)
        Me.Label6.TabIndex = 54
        Me.Label6.Text = "Cost per unit:"
        Me.Label6.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Now", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(114, 317)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(144, 32)
        Me.Label5.TabIndex = 53
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
        Me.itemUnit.Location = New System.Drawing.Point(529, 251)
        Me.itemUnit.Name = "itemUnit"
        Me.itemUnit.Size = New System.Drawing.Size(388, 38)
        Me.itemUnit.TabIndex = 43
        Me.itemUnit.Visible = False
        '
        'itemQuantity
        '
        Me.itemQuantity.Font = New System.Drawing.Font("Now Medium", 15.0!)
        Me.itemQuantity.Location = New System.Drawing.Point(529, 312)
        Me.itemQuantity.Name = "itemQuantity"
        Me.itemQuantity.ReadOnly = True
        Me.itemQuantity.Size = New System.Drawing.Size(388, 37)
        Me.itemQuantity.TabIndex = 44
        Me.itemQuantity.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Now", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(114, 257)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 32)
        Me.Label4.TabIndex = 52
        Me.Label4.Text = "Unit:"
        Me.Label4.Visible = False
        '
        'Delete
        '
        Me.Delete.BackColor = System.Drawing.Color.Red
        Me.Delete.Font = New System.Drawing.Font("Now", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Delete.ForeColor = System.Drawing.Color.Ivory
        Me.Delete.Location = New System.Drawing.Point(240, 576)
        Me.Delete.Name = "Delete"
        Me.Delete.Size = New System.Drawing.Size(168, 52)
        Me.Delete.TabIndex = 50
        Me.Delete.Text = "Delete"
        Me.Delete.UseVisualStyleBackColor = False
        Me.Delete.Visible = False
        '
        'itemName
        '
        Me.itemName.Font = New System.Drawing.Font("Now Medium", 15.8!)
        Me.itemName.Location = New System.Drawing.Point(529, 191)
        Me.itemName.Name = "itemName"
        Me.itemName.ReadOnly = True
        Me.itemName.Size = New System.Drawing.Size(388, 39)
        Me.itemName.TabIndex = 42
        Me.itemName.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Now", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(114, 200)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(176, 32)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "Item Name:"
        Me.Label2.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Now", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(405, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(255, 48)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "Delete Item"
        '
        'DeleteItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1031, 692)
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
        Me.Controls.Add(Me.Delete)
        Me.Controls.Add(Me.itemName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "DeleteItem"
        Me.Text = "Delete Item"
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
    Friend WithEvents Delete As System.Windows.Forms.Button
    Friend WithEvents itemName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
