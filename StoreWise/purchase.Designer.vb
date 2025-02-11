<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class purchase
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
        Me.supplierName = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.transactioToDate = New System.Windows.Forms.DateTimePicker()
        Me.transactionFromDate = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.filter = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'supplierName
        '
        Me.supplierName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.supplierName.Enabled = False
        Me.supplierName.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.supplierName.Font = New System.Drawing.Font("Now Medium", 15.0!)
        Me.supplierName.FormattingEnabled = True
        Me.supplierName.Items.AddRange(New Object() {"Ram", "Sham", "Rahul", "Anshika", "Sneha", "Rohit", "Piyush", "Manan", "Kashish"})
        Me.supplierName.Location = New System.Drawing.Point(352, 227)
        Me.supplierName.Name = "supplierName"
        Me.supplierName.Size = New System.Drawing.Size(903, 38)
        Me.supplierName.TabIndex = 96
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Now Medium", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(85, 229)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(243, 34)
        Me.Label2.TabIndex = 95
        Me.Label2.Text = "Supplier Name:"
        '
        'transactioToDate
        '
        Me.transactioToDate.Enabled = False
        Me.transactioToDate.Font = New System.Drawing.Font("Now Medium", 12.8!)
        Me.transactioToDate.Location = New System.Drawing.Point(836, 167)
        Me.transactioToDate.Name = "transactioToDate"
        Me.transactioToDate.Size = New System.Drawing.Size(419, 33)
        Me.transactioToDate.TabIndex = 94
        '
        'transactionFromDate
        '
        Me.transactionFromDate.Enabled = False
        Me.transactionFromDate.Font = New System.Drawing.Font("Now Medium", 12.8!)
        Me.transactionFromDate.Location = New System.Drawing.Point(238, 167)
        Me.transactionFromDate.Name = "transactionFromDate"
        Me.transactionFromDate.Size = New System.Drawing.Size(419, 33)
        Me.transactionFromDate.TabIndex = 93
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Now Medium", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(756, 166)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 34)
        Me.Label6.TabIndex = 92
        Me.Label6.Text = "To:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Now Medium", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(85, 168)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 34)
        Me.Label5.TabIndex = 91
        Me.Label5.Text = "From:"
        '
        'filter
        '
        Me.filter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.filter.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.filter.Font = New System.Drawing.Font("Now Medium", 15.0!)
        Me.filter.FormattingEnabled = True
        Me.filter.Items.AddRange(New Object() {"Today", "Tomorrow", "Past 7 days", "Past 1 Month", "Last Month", "Past 1 Year", "Last Year", "Custom Dates", "Supplier Name"})
        Me.filter.Location = New System.Drawing.Point(238, 104)
        Me.filter.Name = "filter"
        Me.filter.Size = New System.Drawing.Size(1017, 38)
        Me.filter.TabIndex = 90
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Now", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(85, 104)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(95, 32)
        Me.Label10.TabIndex = 89
        Me.Label10.Text = "Filter:"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(17, 300)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1295, 410)
        Me.DataGridView1.TabIndex = 88
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Now", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(482, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(455, 48)
        Me.Label1.TabIndex = 87
        Me.Label1.Text = "Purchase Transaction"
        '
        'purchase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1329, 735)
        Me.Controls.Add(Me.supplierName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.transactioToDate)
        Me.Controls.Add(Me.transactionFromDate)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.filter)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "purchase"
        Me.Text = "purchase"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents supplierName As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents transactioToDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents transactionFromDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents filter As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
