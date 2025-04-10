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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.filter = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.supplierName = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.pFrom = New System.Windows.Forms.TextBox()
        Me.pTo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(80, 280)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Now Medium", 13.8!, System.Drawing.FontStyle.Bold)
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1164, 383)
        Me.DataGridView1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Now", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(535, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(271, 48)
        Me.Label1.TabIndex = 153
        Me.Label1.Text = "Display Item"
        '
        'filter
        '
        Me.filter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.filter.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.filter.Font = New System.Drawing.Font("Now Medium", 15.0!)
        Me.filter.FormattingEnabled = True
        Me.filter.Items.AddRange(New Object() {"All", "Price", "Supplier Name"})
        Me.filter.Location = New System.Drawing.Point(341, 109)
        Me.filter.Name = "filter"
        Me.filter.Size = New System.Drawing.Size(903, 38)
        Me.filter.TabIndex = 155
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Now", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(74, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 32)
        Me.Label3.TabIndex = 154
        Me.Label3.Text = "Filter:"
        '
        'supplierName
        '
        Me.supplierName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.supplierName.Enabled = False
        Me.supplierName.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.supplierName.Font = New System.Drawing.Font("Now Medium", 15.0!)
        Me.supplierName.FormattingEnabled = True
        Me.supplierName.Items.AddRange(New Object() {"Ram", "Sham", "Rahul", "Anshika", "Sneha", "Rohit", "Piyush", "Manan", "Kashish"})
        Me.supplierName.Location = New System.Drawing.Point(341, 163)
        Me.supplierName.Name = "supplierName"
        Me.supplierName.Size = New System.Drawing.Size(903, 38)
        Me.supplierName.TabIndex = 157
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Now Medium", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(74, 165)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(243, 34)
        Me.Label2.TabIndex = 156
        Me.Label2.Text = "Supplier Name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Now Medium", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(74, 222)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(203, 34)
        Me.Label4.TabIndex = 158
        Me.Label4.Text = "Price Range:"
        '
        'pFrom
        '
        Me.pFrom.Enabled = False
        Me.pFrom.Font = New System.Drawing.Font("Now Medium", 15.8!)
        Me.pFrom.Location = New System.Drawing.Point(449, 220)
        Me.pFrom.Name = "pFrom"
        Me.pFrom.Size = New System.Drawing.Size(336, 39)
        Me.pFrom.TabIndex = 159
        '
        'pTo
        '
        Me.pTo.Enabled = False
        Me.pTo.Font = New System.Drawing.Font("Now Medium", 15.8!)
        Me.pTo.Location = New System.Drawing.Point(908, 220)
        Me.pTo.Name = "pTo"
        Me.pTo.Size = New System.Drawing.Size(336, 39)
        Me.pTo.TabIndex = 160
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Now Medium", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(335, 222)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 34)
        Me.Label5.TabIndex = 161
        Me.Label5.Text = "From:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Now Medium", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(828, 222)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 34)
        Me.Label6.TabIndex = 162
        Me.Label6.Text = "To:"
        '
        'displayItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1326, 688)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.pTo)
        Me.Controls.Add(Me.pFrom)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.supplierName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.filter)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "displayItem"
        Me.Text = "displayItem"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents filter As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents supplierName As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents pFrom As TextBox
    Friend WithEvents pTo As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
