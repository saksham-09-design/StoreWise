<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class updateStock
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.itemQuantity = New System.Windows.Forms.TextBox()
        Me.updateSt = New System.Windows.Forms.Button()
        Me.itemName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.add = New System.Windows.Forms.RadioButton()
        Me.remove = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ComboBox1.Font = New System.Drawing.Font("Now Medium", 15.0!)
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Oil", "Ghee", "Sugar", "Mustard Oil", "Detergent", "Chocolate"})
        Me.ComboBox1.Location = New System.Drawing.Point(506, 111)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(388, 38)
        Me.ComboBox1.TabIndex = 59
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Now", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(91, 117)
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
        Me.cancle.Location = New System.Drawing.Point(509, 377)
        Me.cancle.Name = "cancle"
        Me.cancle.Size = New System.Drawing.Size(168, 52)
        Me.cancle.TabIndex = 57
        Me.cancle.Text = "Cancle"
        Me.cancle.UseVisualStyleBackColor = False
        Me.cancle.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Now", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(91, 236)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(144, 32)
        Me.Label5.TabIndex = 53
        Me.Label5.Text = "Quantity:"
        Me.Label5.Visible = False
        '
        'itemQuantity
        '
        Me.itemQuantity.Font = New System.Drawing.Font("Now Medium", 15.0!)
        Me.itemQuantity.Location = New System.Drawing.Point(506, 231)
        Me.itemQuantity.Name = "itemQuantity"
        Me.itemQuantity.Size = New System.Drawing.Size(388, 37)
        Me.itemQuantity.TabIndex = 44
        Me.itemQuantity.Visible = False
        '
        'updateSt
        '
        Me.updateSt.BackColor = System.Drawing.Color.Red
        Me.updateSt.Font = New System.Drawing.Font("Now", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updateSt.ForeColor = System.Drawing.Color.Ivory
        Me.updateSt.Location = New System.Drawing.Point(253, 377)
        Me.updateSt.Name = "updateSt"
        Me.updateSt.Size = New System.Drawing.Size(168, 52)
        Me.updateSt.TabIndex = 50
        Me.updateSt.Text = "Update"
        Me.updateSt.UseVisualStyleBackColor = False
        Me.updateSt.Visible = False
        '
        'itemName
        '
        Me.itemName.Font = New System.Drawing.Font("Now Medium", 15.8!)
        Me.itemName.Location = New System.Drawing.Point(506, 168)
        Me.itemName.Name = "itemName"
        Me.itemName.Size = New System.Drawing.Size(388, 39)
        Me.itemName.TabIndex = 42
        Me.itemName.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Now", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(91, 177)
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
        Me.Label1.Location = New System.Drawing.Point(330, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(297, 48)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "Update Stock"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Now", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(91, 295)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(207, 32)
        Me.Label4.TabIndex = 60
        Me.Label4.Text = "Add/Remove:"
        Me.Label4.Visible = False
        '
        'add
        '
        Me.add.AutoSize = True
        Me.add.Checked = True
        Me.add.Font = New System.Drawing.Font("Now", 16.0!, System.Drawing.FontStyle.Bold)
        Me.add.ForeColor = System.Drawing.Color.Red
        Me.add.Location = New System.Drawing.Point(564, 293)
        Me.add.Name = "add"
        Me.add.Size = New System.Drawing.Size(91, 36)
        Me.add.TabIndex = 61
        Me.add.TabStop = True
        Me.add.Text = "Add"
        Me.add.UseVisualStyleBackColor = True
        Me.add.Visible = False
        '
        'remove
        '
        Me.remove.AutoSize = True
        Me.remove.Font = New System.Drawing.Font("Now", 16.0!, System.Drawing.FontStyle.Bold)
        Me.remove.ForeColor = System.Drawing.Color.Red
        Me.remove.Location = New System.Drawing.Point(690, 293)
        Me.remove.Name = "remove"
        Me.remove.Size = New System.Drawing.Size(144, 36)
        Me.remove.TabIndex = 62
        Me.remove.Text = "Remove"
        Me.remove.UseVisualStyleBackColor = True
        Me.remove.Visible = False
        '
        'updateStock
        '
        Me.AcceptButton = Me.updateSt
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(978, 517)
        Me.Controls.Add(Me.remove)
        Me.Controls.Add(Me.add)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cancle)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.itemQuantity)
        Me.Controls.Add(Me.updateSt)
        Me.Controls.Add(Me.itemName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "updateStock"
        Me.Text = "Update Stock"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cancle As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents itemQuantity As System.Windows.Forms.TextBox
    Friend WithEvents updateSt As System.Windows.Forms.Button
    Friend WithEvents itemName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents add As System.Windows.Forms.RadioButton
    Friend WithEvents remove As System.Windows.Forms.RadioButton
End Class
