<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class sales
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.filter = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.fromDate = New System.Windows.Forms.DateTimePicker()
        Me.toDate = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.customerName = New System.Windows.Forms.ComboBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Now", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(477, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(357, 48)
        Me.Label1.TabIndex = 76
        Me.Label1.Text = "Sale Transaction"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(86, 300)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Now Medium", 13.8!, System.Drawing.FontStyle.Bold)
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1164, 410)
        Me.DataGridView1.TabIndex = 77
        '
        'filter
        '
        Me.filter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.filter.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.filter.Font = New System.Drawing.Font("Now Medium", 15.0!)
        Me.filter.FormattingEnabled = True
        Me.filter.Items.AddRange(New Object() {"All", "Today", "Yesterday", "Past 7 days", "Past 1 Month", "Past 1 Year", "Custom Dates", "Customer Name"})
        Me.filter.Location = New System.Drawing.Point(233, 104)
        Me.filter.Name = "filter"
        Me.filter.Size = New System.Drawing.Size(1017, 38)
        Me.filter.TabIndex = 79
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Now", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(80, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 32)
        Me.Label3.TabIndex = 78
        Me.Label3.Text = "Filter:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Now Medium", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(751, 166)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 34)
        Me.Label4.TabIndex = 82
        Me.Label4.Text = "To:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Now Medium", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(80, 168)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 34)
        Me.Label5.TabIndex = 80
        Me.Label5.Text = "From:"
        '
        'fromDate
        '
        Me.fromDate.Enabled = False
        Me.fromDate.Font = New System.Drawing.Font("Now Medium", 12.8!)
        Me.fromDate.Location = New System.Drawing.Point(233, 167)
        Me.fromDate.Name = "fromDate"
        Me.fromDate.Size = New System.Drawing.Size(419, 33)
        Me.fromDate.TabIndex = 83
        '
        'toDate
        '
        Me.toDate.Enabled = False
        Me.toDate.Font = New System.Drawing.Font("Now Medium", 12.8!)
        Me.toDate.Location = New System.Drawing.Point(831, 167)
        Me.toDate.Name = "toDate"
        Me.toDate.Size = New System.Drawing.Size(419, 33)
        Me.toDate.TabIndex = 84
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Now Medium", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(80, 229)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(261, 34)
        Me.Label2.TabIndex = 85
        Me.Label2.Text = "Customer Name:"
        '
        'customerName
        '
        Me.customerName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.customerName.Enabled = False
        Me.customerName.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.customerName.Font = New System.Drawing.Font("Now Medium", 15.0!)
        Me.customerName.FormattingEnabled = True
        Me.customerName.Items.AddRange(New Object() {"Ram", "Sham", "Rahul", "Anshika", "Sneha", "Rohit", "Piyush", "Manan", "Kashish"})
        Me.customerName.Location = New System.Drawing.Point(347, 227)
        Me.customerName.Name = "customerName"
        Me.customerName.Size = New System.Drawing.Size(903, 38)
        Me.customerName.TabIndex = 86
        '
        'sales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1319, 736)
        Me.Controls.Add(Me.customerName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.toDate)
        Me.Controls.Add(Me.fromDate)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.filter)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "sales"
        Me.Text = "Sale Transaction"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents filter As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents fromDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents toDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents ItemTableBindingSource As BindingSource
    Friend WithEvents Label2 As Label
    Friend WithEvents customerName As ComboBox
End Class
