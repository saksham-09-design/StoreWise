<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class modifyUser
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
        Me.modify = New System.Windows.Forms.Button()
        Me.oPass = New System.Windows.Forms.TextBox()
        Me.OuName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nPass = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cPass = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.nUName = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cancle
        '
        Me.cancle.BackColor = System.Drawing.Color.Red
        Me.cancle.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cancle.Font = New System.Drawing.Font("Now", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancle.ForeColor = System.Drawing.Color.Ivory
        Me.cancle.Location = New System.Drawing.Point(428, 542)
        Me.cancle.Name = "cancle"
        Me.cancle.Size = New System.Drawing.Size(168, 52)
        Me.cancle.TabIndex = 13
        Me.cancle.Text = "Cancel"
        Me.cancle.UseVisualStyleBackColor = False
        '
        'modify
        '
        Me.modify.BackColor = System.Drawing.Color.Red
        Me.modify.Font = New System.Drawing.Font("Now", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.modify.ForeColor = System.Drawing.Color.Ivory
        Me.modify.Location = New System.Drawing.Point(198, 542)
        Me.modify.Name = "modify"
        Me.modify.Size = New System.Drawing.Size(168, 52)
        Me.modify.TabIndex = 12
        Me.modify.Text = "Modify"
        Me.modify.UseVisualStyleBackColor = False
        '
        'oPass
        '
        Me.oPass.Font = New System.Drawing.Font("Now Medium", 15.0!)
        Me.oPass.Location = New System.Drawing.Point(387, 277)
        Me.oPass.Name = "oPass"
        Me.oPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.oPass.Size = New System.Drawing.Size(336, 37)
        Me.oPass.TabIndex = 11
        '
        'OuName
        '
        Me.OuName.Font = New System.Drawing.Font("Now Medium", 15.8!)
        Me.OuName.Location = New System.Drawing.Point(387, 143)
        Me.OuName.Name = "OuName"
        Me.OuName.Size = New System.Drawing.Size(336, 39)
        Me.OuName.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Now", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(110, 282)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(209, 32)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Old Password:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Now", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(110, 150)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(224, 32)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Old UserName:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Now", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(267, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(264, 48)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Modify User"
        '
        'nPass
        '
        Me.nPass.Font = New System.Drawing.Font("Now Medium", 15.0!)
        Me.nPass.Location = New System.Drawing.Point(387, 353)
        Me.nPass.Name = "nPass"
        Me.nPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.nPass.Size = New System.Drawing.Size(336, 37)
        Me.nPass.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Now", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(110, 358)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(223, 32)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "New Password:"
        '
        'cPass
        '
        Me.cPass.Font = New System.Drawing.Font("Now Medium", 15.0!)
        Me.cPass.Location = New System.Drawing.Point(387, 426)
        Me.cPass.Name = "cPass"
        Me.cPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.cPass.Size = New System.Drawing.Size(336, 37)
        Me.cPass.TabIndex = 17
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Now", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(110, 431)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(270, 32)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Confirm Password:"
        '
        'nUName
        '
        Me.nUName.Font = New System.Drawing.Font("Now Medium", 15.8!)
        Me.nUName.Location = New System.Drawing.Point(387, 211)
        Me.nUName.Name = "nUName"
        Me.nUName.Size = New System.Drawing.Size(336, 39)
        Me.nUName.TabIndex = 19
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Now", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(110, 218)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(238, 32)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "New UserName:"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.Font = New System.Drawing.Font("Now Black", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button1.Location = New System.Drawing.Point(740, 353)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(58, 37)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "i"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'modifyUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(841, 640)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.nUName)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cPass)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.nPass)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cancle)
        Me.Controls.Add(Me.modify)
        Me.Controls.Add(Me.oPass)
        Me.Controls.Add(Me.OuName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "modifyUser"
        Me.Text = "Modify User"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cancle As System.Windows.Forms.Button
    Friend WithEvents modify As System.Windows.Forms.Button
    Friend WithEvents oPass As System.Windows.Forms.TextBox
    Friend WithEvents OuName As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents nPass As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cPass As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents nUName As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Button1 As Button
End Class
