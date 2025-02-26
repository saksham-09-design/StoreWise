<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class displayItem
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.supplier = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.itemGST = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.itemSP = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.itemCost = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.itemName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Filter = New System.Windows.Forms.ComboBox()
        Me.price = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.rol = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.gstFilter = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.iUnit = New System.Windows.Forms.TextBox()
        Me.nameSupplier = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'supplier
        '
        Me.supplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.supplier.Enabled = False
        Me.supplier.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.supplier.Font = New System.Drawing.Font("Now Medium", 15.0!)
        Me.supplier.FormattingEnabled = True
        Me.supplier.Items.AddRange(New Object() {"Sunfeast", "Cremica", "Nestle"})
        Me.supplier.Location = New System.Drawing.Point(192, 360)
        Me.supplier.Name = "supplier"
        Me.supplier.Size = New System.Drawing.Size(388, 38)
        Me.supplier.TabIndex = 77
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Now", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(29, 362)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(136, 32)
        Me.Label5.TabIndex = 78
        Me.Label5.Text = "Supplier:"
        '
        'itemGST
        '
        Me.itemGST.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.itemGST.Enabled = False
        Me.itemGST.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.itemGST.Font = New System.Drawing.Font("Now Medium", 15.0!)
        Me.itemGST.FormattingEnabled = True
        Me.itemGST.Items.AddRange(New Object() {"5%", "12%", "18%", "28%", "Exempt"})
        Me.itemGST.Location = New System.Drawing.Point(857, 200)
        Me.itemGST.Name = "itemGST"
        Me.itemGST.Size = New System.Drawing.Size(388, 38)
        Me.itemGST.TabIndex = 66
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Now", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(651, 202)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(132, 32)
        Me.Label8.TabIndex = 73
        Me.Label8.Text = "GST (%):"
        '
        'itemSP
        '
        Me.itemSP.Font = New System.Drawing.Font("Now Medium", 15.0!)
        Me.itemSP.Location = New System.Drawing.Point(305, 197)
        Me.itemSP.Name = "itemSP"
        Me.itemSP.ReadOnly = True
        Me.itemSP.Size = New System.Drawing.Size(275, 37)
        Me.itemSP.TabIndex = 65
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Now", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(29, 202)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(270, 32)
        Me.Label7.TabIndex = 72
        Me.Label7.Text = "Selling Price/Unit:"
        '
        'itemCost
        '
        Me.itemCost.Font = New System.Drawing.Font("Now Medium", 15.0!)
        Me.itemCost.Location = New System.Drawing.Point(857, 143)
        Me.itemCost.Name = "itemCost"
        Me.itemCost.ReadOnly = True
        Me.itemCost.Size = New System.Drawing.Size(388, 37)
        Me.itemCost.TabIndex = 64
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Now", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(651, 148)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(200, 32)
        Me.Label6.TabIndex = 71
        Me.Label6.Text = "Cost per unit:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Now", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(651, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 32)
        Me.Label4.TabIndex = 70
        Me.Label4.Text = "Unit:"
        '
        'itemName
        '
        Me.itemName.Font = New System.Drawing.Font("Now Medium", 15.8!)
        Me.itemName.Location = New System.Drawing.Point(235, 93)
        Me.itemName.Name = "itemName"
        Me.itemName.ReadOnly = True
        Me.itemName.Size = New System.Drawing.Size(345, 39)
        Me.itemName.TabIndex = 62
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Now", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(29, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(175, 32)
        Me.Label2.TabIndex = 68
        Me.Label2.Text = "Item Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Now", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(512, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(271, 48)
        Me.Label1.TabIndex = 67
        Me.Label1.Text = "Display Item"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(35, 416)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Now Medium", 13.8!, System.Drawing.FontStyle.Bold)
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1210, 334)
        Me.DataGridView1.TabIndex = 79
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Now", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(29, 307)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 32)
        Me.Label3.TabIndex = 81
        Me.Label3.Text = "Filter:"
        '
        'Filter
        '
        Me.Filter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Filter.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Filter.Font = New System.Drawing.Font("Now Medium", 15.0!)
        Me.Filter.FormattingEnabled = True
        Me.Filter.Items.AddRange(New Object() {"All", "Supplier Wise", "Price Greater Than", "Price Less Than", "Tax Rate"})
        Me.Filter.Location = New System.Drawing.Point(192, 305)
        Me.Filter.Name = "Filter"
        Me.Filter.Size = New System.Drawing.Size(388, 38)
        Me.Filter.TabIndex = 103
        '
        'price
        '
        Me.price.Font = New System.Drawing.Font("Now Medium", 15.0!)
        Me.price.Location = New System.Drawing.Point(857, 305)
        Me.price.Name = "price"
        Me.price.ReadOnly = True
        Me.price.Size = New System.Drawing.Size(388, 37)
        Me.price.TabIndex = 104
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Now", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(651, 310)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(94, 32)
        Me.Label9.TabIndex = 105
        Me.Label9.Text = "Price:"
        '
        'rol
        '
        Me.rol.Font = New System.Drawing.Font("Now Medium", 15.0!)
        Me.rol.Location = New System.Drawing.Point(235, 146)
        Me.rol.Name = "rol"
        Me.rol.ReadOnly = True
        Me.rol.Size = New System.Drawing.Size(345, 37)
        Me.rol.TabIndex = 106
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Now", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(29, 151)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(78, 32)
        Me.Label10.TabIndex = 107
        Me.Label10.Text = "ROL:"
        '
        'gstFilter
        '
        Me.gstFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.gstFilter.Enabled = False
        Me.gstFilter.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.gstFilter.Font = New System.Drawing.Font("Now Medium", 15.0!)
        Me.gstFilter.FormattingEnabled = True
        Me.gstFilter.Items.AddRange(New Object() {"5%", "12%", "18%", "28%", "Exempt"})
        Me.gstFilter.Location = New System.Drawing.Point(857, 360)
        Me.gstFilter.Name = "gstFilter"
        Me.gstFilter.Size = New System.Drawing.Size(388, 38)
        Me.gstFilter.TabIndex = 108
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Now", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(651, 362)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(125, 32)
        Me.Label11.TabIndex = 109
        Me.Label11.Text = "Tax (%):"
        '
        'iUnit
        '
        Me.iUnit.Font = New System.Drawing.Font("Now Medium", 15.0!)
        Me.iUnit.Location = New System.Drawing.Point(857, 97)
        Me.iUnit.Name = "iUnit"
        Me.iUnit.ReadOnly = True
        Me.iUnit.Size = New System.Drawing.Size(388, 37)
        Me.iUnit.TabIndex = 110
        '
        'nameSupplier
        '
        Me.nameSupplier.Font = New System.Drawing.Font("Now Medium", 15.0!)
        Me.nameSupplier.Location = New System.Drawing.Point(305, 250)
        Me.nameSupplier.Name = "nameSupplier"
        Me.nameSupplier.ReadOnly = True
        Me.nameSupplier.Size = New System.Drawing.Size(940, 37)
        Me.nameSupplier.TabIndex = 111
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Now", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label12.ForeColor = System.Drawing.Color.Red
        Me.Label12.Location = New System.Drawing.Point(29, 255)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(234, 32)
        Me.Label12.TabIndex = 112
        Me.Label12.Text = "Supplier Name: "
        '
        'displayItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1311, 772)
        Me.Controls.Add(Me.nameSupplier)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.iUnit)
        Me.Controls.Add(Me.gstFilter)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.rol)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.price)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Filter)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.supplier)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.itemGST)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.itemSP)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.itemCost)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.itemName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "displayItem"
        Me.Text = "displayItem"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents supplier As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents itemGST As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents itemSP As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents itemCost As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents itemName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents Filter As ComboBox
    Friend WithEvents price As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents rol As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents gstFilter As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents iUnit As TextBox
    Friend WithEvents nameSupplier As TextBox
    Friend WithEvents Label12 As Label
End Class
