<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class deleteSupplier
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
        Me.supplierNameList = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cancle = New System.Windows.Forms.Button()
        Me.delete = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.eMail = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.phone = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.supplierName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'supplierNameList
        '
        Me.supplierNameList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.supplierNameList.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.supplierNameList.Font = New System.Drawing.Font("Now Medium", 15.0!)
        Me.supplierNameList.FormattingEnabled = True
        Me.supplierNameList.Items.AddRange(New Object() {"Sunfeast", "Cremica", "Nestle"})
        Me.supplierNameList.Location = New System.Drawing.Point(344, 189)
        Me.supplierNameList.Name = "supplierNameList"
        Me.supplierNameList.Size = New System.Drawing.Size(470, 38)
        Me.supplierNameList.TabIndex = 92
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Now", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(66, 195)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 32)
        Me.Label3.TabIndex = 93
        Me.Label3.Text = "Supplier:"
        '
        'cancle
        '
        Me.cancle.BackColor = System.Drawing.Color.Red
        Me.cancle.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cancle.Font = New System.Drawing.Font("Now", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancle.ForeColor = System.Drawing.Color.Ivory
        Me.cancle.Location = New System.Drawing.Point(564, 470)
        Me.cancle.Name = "cancle"
        Me.cancle.Size = New System.Drawing.Size(168, 52)
        Me.cancle.TabIndex = 91
        Me.cancle.Text = "&Cancel"
        Me.cancle.UseVisualStyleBackColor = False
        '
        'delete
        '
        Me.delete.BackColor = System.Drawing.Color.Red
        Me.delete.Font = New System.Drawing.Font("Now", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.delete.ForeColor = System.Drawing.Color.Ivory
        Me.delete.Location = New System.Drawing.Point(159, 470)
        Me.delete.Name = "delete"
        Me.delete.Size = New System.Drawing.Size(168, 52)
        Me.delete.TabIndex = 90
        Me.delete.Text = "Delete"
        Me.delete.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Now", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(249, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(332, 48)
        Me.Label1.TabIndex = 89
        Me.Label1.Text = "Delete Supplier"
        '
        'eMail
        '
        Me.eMail.Font = New System.Drawing.Font("Now Medium", 15.8!)
        Me.eMail.Location = New System.Drawing.Point(344, 397)
        Me.eMail.Name = "eMail"
        Me.eMail.ReadOnly = True
        Me.eMail.Size = New System.Drawing.Size(470, 39)
        Me.eMail.TabIndex = 86
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Now Medium", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(66, 399)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 34)
        Me.Label4.TabIndex = 88
        Me.Label4.Text = "E-Mail:"
        '
        'phone
        '
        Me.phone.Font = New System.Drawing.Font("Now Medium", 15.8!)
        Me.phone.Location = New System.Drawing.Point(344, 323)
        Me.phone.Name = "phone"
        Me.phone.ReadOnly = True
        Me.phone.Size = New System.Drawing.Size(470, 39)
        Me.phone.TabIndex = 85
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Now Medium", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(66, 325)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(250, 34)
        Me.Label5.TabIndex = 87
        Me.Label5.Text = "*Phone Number:"
        '
        'supplierName
        '
        Me.supplierName.Font = New System.Drawing.Font("Now Medium", 15.8!)
        Me.supplierName.Location = New System.Drawing.Point(344, 257)
        Me.supplierName.Name = "supplierName"
        Me.supplierName.ReadOnly = True
        Me.supplierName.Size = New System.Drawing.Size(470, 39)
        Me.supplierName.TabIndex = 83
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Now Medium", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(66, 259)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 34)
        Me.Label2.TabIndex = 84
        Me.Label2.Text = "*Name:"
        '
        'deleteSupplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(881, 612)
        Me.Controls.Add(Me.supplierNameList)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cancle)
        Me.Controls.Add(Me.delete)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.eMail)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.phone)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.supplierName)
        Me.Controls.Add(Me.Label2)
        Me.Name = "deleteSupplier"
        Me.Text = "deleteSupplier"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents supplierNameList As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cancle As System.Windows.Forms.Button
    Friend WithEvents delete As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents eMail As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents phone As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents supplierName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
