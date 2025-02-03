<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModifyItem
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
        Me.cancle = New System.Windows.Forms.Button()
        Me.itemGST = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.itemSP = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.itemCost = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.itemUnit = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.clear = New System.Windows.Forms.Button()
        Me.Modify = New System.Windows.Forms.Button()
        Me.itemName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'cancle
        '
        Me.cancle.BackColor = System.Drawing.Color.Red
        Me.cancle.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cancle.Font = New System.Drawing.Font("Now", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancle.ForeColor = System.Drawing.Color.Ivory
        Me.cancle.Location = New System.Drawing.Point(548, 465)
        Me.cancle.Name = "cancle"
        Me.cancle.Size = New System.Drawing.Size(168, 52)
        Me.cancle.TabIndex = 38
        Me.cancle.Text = "Cancle"
        Me.cancle.UseVisualStyleBackColor = False
        Me.cancle.Visible = False
        '
        'itemGST
        '
        Me.itemGST.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.itemGST.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.itemGST.Font = New System.Drawing.Font("Now Medium", 15.0!)
        Me.itemGST.FormattingEnabled = True
        Me.itemGST.Items.AddRange(New Object() {"5%", "12%", "18%", "28%", "Exempt"})
        Me.itemGST.Location = New System.Drawing.Point(468, 392)
        Me.itemGST.Name = "itemGST"
        Me.itemGST.Size = New System.Drawing.Size(388, 38)
        Me.itemGST.TabIndex = 7
        Me.itemGST.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Now", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(53, 398)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(133, 32)
        Me.Label8.TabIndex = 37
        Me.Label8.Text = "GST (%):"
        Me.Label8.Visible = False
        '
        'itemSP
        '
        Me.itemSP.Font = New System.Drawing.Font("Now Medium", 15.0!)
        Me.itemSP.Location = New System.Drawing.Point(468, 328)
        Me.itemSP.Name = "itemSP"
        Me.itemSP.Size = New System.Drawing.Size(388, 37)
        Me.itemSP.TabIndex = 6
        Me.itemSP.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Now", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(53, 333)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(314, 32)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "Selling Price per Unit:"
        Me.Label7.Visible = False
        '
        'itemCost
        '
        Me.itemCost.Font = New System.Drawing.Font("Now Medium", 15.0!)
        Me.itemCost.Location = New System.Drawing.Point(468, 264)
        Me.itemCost.Name = "itemCost"
        Me.itemCost.Size = New System.Drawing.Size(388, 37)
        Me.itemCost.TabIndex = 5
        Me.itemCost.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Now", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(53, 269)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(201, 32)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "Cost per unit:"
        Me.Label6.Visible = False
        '
        'itemUnit
        '
        Me.itemUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.itemUnit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.itemUnit.Font = New System.Drawing.Font("Now Medium", 15.0!)
        Me.itemUnit.FormattingEnabled = True
        Me.itemUnit.Items.AddRange(New Object() {"Pcs.", "Kgs.", "Dozen", "Gms.", "Meter", "Units"})
        Me.itemUnit.Location = New System.Drawing.Point(468, 203)
        Me.itemUnit.Name = "itemUnit"
        Me.itemUnit.Size = New System.Drawing.Size(388, 38)
        Me.itemUnit.TabIndex = 3
        Me.itemUnit.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Now", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(53, 209)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 32)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Unit:"
        Me.Label4.Visible = False
        '
        'clear
        '
        Me.clear.BackColor = System.Drawing.Color.Red
        Me.clear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.clear.Font = New System.Drawing.Font("Now", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clear.ForeColor = System.Drawing.Color.Ivory
        Me.clear.Location = New System.Drawing.Point(363, 465)
        Me.clear.Name = "clear"
        Me.clear.Size = New System.Drawing.Size(168, 52)
        Me.clear.TabIndex = 32
        Me.clear.Text = "Clear"
        Me.clear.UseVisualStyleBackColor = False
        Me.clear.Visible = False
        '
        'Modify
        '
        Me.Modify.BackColor = System.Drawing.Color.Red
        Me.Modify.Font = New System.Drawing.Font("Now", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Modify.ForeColor = System.Drawing.Color.Ivory
        Me.Modify.Location = New System.Drawing.Point(179, 465)
        Me.Modify.Name = "Modify"
        Me.Modify.Size = New System.Drawing.Size(168, 52)
        Me.Modify.TabIndex = 31
        Me.Modify.Text = "Modify"
        Me.Modify.UseVisualStyleBackColor = False
        Me.Modify.Visible = False
        '
        'itemName
        '
        Me.itemName.Font = New System.Drawing.Font("Now Medium", 15.8!)
        Me.itemName.Location = New System.Drawing.Point(468, 143)
        Me.itemName.Name = "itemName"
        Me.itemName.Size = New System.Drawing.Size(388, 39)
        Me.itemName.TabIndex = 2
        Me.itemName.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Now", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(53, 152)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(176, 32)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Item Name:"
        Me.Label2.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Now", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(344, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(263, 48)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Modify Item"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Now", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(53, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(170, 32)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "Select Item"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ComboBox1.Font = New System.Drawing.Font("Now Medium", 15.0!)
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Oil", "Ghee", "Sugar", "Mustard Oil", "Detergent", "Chocolate"})
        Me.ComboBox1.Location = New System.Drawing.Point(468, 86)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(388, 38)
        Me.ComboBox1.TabIndex = 41
        '
        'ModifyItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(934, 553)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cancle)
        Me.Controls.Add(Me.itemGST)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.itemSP)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.itemCost)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.itemUnit)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.clear)
        Me.Controls.Add(Me.Modify)
        Me.Controls.Add(Me.itemName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ModifyItem"
        Me.Text = "Modify Item"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cancle As System.Windows.Forms.Button
    Friend WithEvents itemGST As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents itemSP As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents itemCost As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents itemUnit As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents clear As System.Windows.Forms.Button
    Friend WithEvents Modify As System.Windows.Forms.Button
    Friend WithEvents itemName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
End Class
