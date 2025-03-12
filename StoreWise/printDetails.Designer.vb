<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class printDetails
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.fName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.phone = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.mail = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.add = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cancle = New System.Windows.Forms.Button()
        Me.sFormat = New System.Windows.Forms.Button()
        Me.t4 = New System.Windows.Forms.TextBox()
        Me.t3 = New System.Windows.Forms.TextBox()
        Me.t2 = New System.Windows.Forms.TextBox()
        Me.t1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Now", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(347, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(345, 48)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Bill Print Details"
        '
        'fName
        '
        Me.fName.Font = New System.Drawing.Font("Now Medium", 15.8!)
        Me.fName.Location = New System.Drawing.Point(283, 95)
        Me.fName.Name = "fName"
        Me.fName.Size = New System.Drawing.Size(717, 39)
        Me.fName.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Now", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(83, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(172, 32)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Firm Name:"
        '
        'phone
        '
        Me.phone.Font = New System.Drawing.Font("Now Medium", 15.8!)
        Me.phone.Location = New System.Drawing.Point(283, 154)
        Me.phone.Name = "phone"
        Me.phone.Size = New System.Drawing.Size(717, 39)
        Me.phone.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Now", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(83, 161)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(157, 32)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Phone No:"
        '
        'mail
        '
        Me.mail.Font = New System.Drawing.Font("Now Medium", 15.8!)
        Me.mail.Location = New System.Drawing.Point(283, 215)
        Me.mail.Name = "mail"
        Me.mail.Size = New System.Drawing.Size(717, 39)
        Me.mail.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Now", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(83, 222)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 32)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "E-Mail:"
        '
        'add
        '
        Me.add.Font = New System.Drawing.Font("Now Medium", 15.8!)
        Me.add.Location = New System.Drawing.Point(283, 275)
        Me.add.Name = "add"
        Me.add.Size = New System.Drawing.Size(717, 39)
        Me.add.TabIndex = 18
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Now", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(83, 282)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(131, 32)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Address:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Now", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(83, 348)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 32)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Terms:"
        '
        'cancle
        '
        Me.cancle.BackColor = System.Drawing.Color.Red
        Me.cancle.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cancle.Font = New System.Drawing.Font("Now", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancle.ForeColor = System.Drawing.Color.Ivory
        Me.cancle.Location = New System.Drawing.Point(538, 574)
        Me.cancle.Name = "cancle"
        Me.cancle.Size = New System.Drawing.Size(168, 52)
        Me.cancle.TabIndex = 22
        Me.cancle.Text = "Cancel"
        Me.cancle.UseVisualStyleBackColor = False
        '
        'sFormat
        '
        Me.sFormat.BackColor = System.Drawing.Color.Red
        Me.sFormat.Font = New System.Drawing.Font("Now", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sFormat.ForeColor = System.Drawing.Color.Ivory
        Me.sFormat.Location = New System.Drawing.Point(308, 574)
        Me.sFormat.Name = "sFormat"
        Me.sFormat.Size = New System.Drawing.Size(168, 52)
        Me.sFormat.TabIndex = 21
        Me.sFormat.Text = "Save"
        Me.sFormat.UseVisualStyleBackColor = False
        '
        't4
        '
        Me.t4.Font = New System.Drawing.Font("Now Medium", 15.8!)
        Me.t4.Location = New System.Drawing.Point(283, 505)
        Me.t4.Name = "t4"
        Me.t4.Size = New System.Drawing.Size(717, 39)
        Me.t4.TabIndex = 26
        Me.t4.Text = "3. Subject to 'Punjab' Jurisdiction only."
        '
        't3
        '
        Me.t3.Font = New System.Drawing.Font("Now Medium", 15.8!)
        Me.t3.Location = New System.Drawing.Point(283, 453)
        Me.t3.Name = "t3"
        Me.t3.Size = New System.Drawing.Size(717, 39)
        Me.t3.TabIndex = 25
        Me.t3.Text = "2. This copy does not entitle the holder too claim Input Tax Credit."
        '
        't2
        '
        Me.t2.Font = New System.Drawing.Font("Now Medium", 15.8!)
        Me.t2.Location = New System.Drawing.Point(283, 397)
        Me.t2.Name = "t2"
        Me.t2.Size = New System.Drawing.Size(717, 39)
        Me.t2.TabIndex = 24
        Me.t2.Text = "1. Goods once sold will not be taken back."
        '
        't1
        '
        Me.t1.Font = New System.Drawing.Font("Now Medium", 15.8!)
        Me.t1.Location = New System.Drawing.Point(283, 346)
        Me.t1.Name = "t1"
        Me.t1.Size = New System.Drawing.Size(717, 39)
        Me.t1.TabIndex = 23
        Me.t1.Text = "E.& O.E."
        '
        'printDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1053, 652)
        Me.Controls.Add(Me.t4)
        Me.Controls.Add(Me.t3)
        Me.Controls.Add(Me.t2)
        Me.Controls.Add(Me.t1)
        Me.Controls.Add(Me.cancle)
        Me.Controls.Add(Me.sFormat)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.add)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.mail)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.phone)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.fName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "printDetails"
        Me.Text = "printDetails"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents fName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents phone As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents mail As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents add As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cancle As Button
    Friend WithEvents sFormat As Button
    Friend WithEvents t4 As TextBox
    Friend WithEvents t3 As TextBox
    Friend WithEvents t2 As TextBox
    Friend WithEvents t1 As TextBox
End Class
