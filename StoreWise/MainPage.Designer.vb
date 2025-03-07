<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainPage
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
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.UserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeCredentialsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeThemeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModifyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisplayToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.InventoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisplayToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransactionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModifyToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisplayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PurchaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SupplierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModifyToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisplayToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DashboardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AddItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddSalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddPurchaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.UpdateStockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.SearchToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.Info
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UserToolStripMenuItem, Me.ItemToolStripMenuItem, Me.InventoryToolStripMenuItem, Me.TransactionsToolStripMenuItem, Me.SupplierToolStripMenuItem, Me.DashboardToolStripMenuItem})
        Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1902, 39)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'UserToolStripMenuItem
        '
        Me.UserToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChangeCredentialsToolStripMenuItem, Me.ChangeThemeToolStripMenuItem, Me.ExitToolStripMenuItem1})
        Me.UserToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserToolStripMenuItem.Name = "UserToolStripMenuItem"
        Me.UserToolStripMenuItem.Size = New System.Drawing.Size(75, 35)
        Me.UserToolStripMenuItem.Text = "User"
        Me.UserToolStripMenuItem.ToolTipText = "User"
        '
        'ChangeCredentialsToolStripMenuItem
        '
        Me.ChangeCredentialsToolStripMenuItem.Name = "ChangeCredentialsToolStripMenuItem"
        Me.ChangeCredentialsToolStripMenuItem.Size = New System.Drawing.Size(256, 36)
        Me.ChangeCredentialsToolStripMenuItem.Text = "Modify User"
        '
        'ChangeThemeToolStripMenuItem
        '
        Me.ChangeThemeToolStripMenuItem.Name = "ChangeThemeToolStripMenuItem"
        Me.ChangeThemeToolStripMenuItem.Size = New System.Drawing.Size(256, 36)
        Me.ChangeThemeToolStripMenuItem.Text = "Change Theme"
        '
        'ExitToolStripMenuItem1
        '
        Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(256, 36)
        Me.ExitToolStripMenuItem1.Text = "Logout"
        '
        'ItemToolStripMenuItem
        '
        Me.ItemToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddToolStripMenuItem, Me.ModifyToolStripMenuItem, Me.DisplayToolStripMenuItem2})
        Me.ItemToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 13.8!, System.Drawing.FontStyle.Bold)
        Me.ItemToolStripMenuItem.Name = "ItemToolStripMenuItem"
        Me.ItemToolStripMenuItem.Size = New System.Drawing.Size(75, 35)
        Me.ItemToolStripMenuItem.Text = "Item"
        '
        'AddToolStripMenuItem
        '
        Me.AddToolStripMenuItem.Name = "AddToolStripMenuItem"
        Me.AddToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.I), System.Windows.Forms.Keys)
        Me.AddToolStripMenuItem.Size = New System.Drawing.Size(264, 36)
        Me.AddToolStripMenuItem.Text = "Add"
        '
        'ModifyToolStripMenuItem
        '
        Me.ModifyToolStripMenuItem.Name = "ModifyToolStripMenuItem"
        Me.ModifyToolStripMenuItem.Size = New System.Drawing.Size(264, 36)
        Me.ModifyToolStripMenuItem.Text = "Modify"
        '
        'DisplayToolStripMenuItem2
        '
        Me.DisplayToolStripMenuItem2.Name = "DisplayToolStripMenuItem2"
        Me.DisplayToolStripMenuItem2.Size = New System.Drawing.Size(264, 36)
        Me.DisplayToolStripMenuItem2.Text = "Display"
        '
        'InventoryToolStripMenuItem
        '
        Me.InventoryToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DisplayToolStripMenuItem1})
        Me.InventoryToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 13.8!, System.Drawing.FontStyle.Bold)
        Me.InventoryToolStripMenuItem.Name = "InventoryToolStripMenuItem"
        Me.InventoryToolStripMenuItem.Size = New System.Drawing.Size(129, 35)
        Me.InventoryToolStripMenuItem.Text = "Inventory"
        '
        'DisplayToolStripMenuItem1
        '
        Me.DisplayToolStripMenuItem1.Name = "DisplayToolStripMenuItem1"
        Me.DisplayToolStripMenuItem1.Size = New System.Drawing.Size(179, 36)
        Me.DisplayToolStripMenuItem1.Text = "Display"
        '
        'TransactionsToolStripMenuItem
        '
        Me.TransactionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaleToolStripMenuItem, Me.PurchaseToolStripMenuItem})
        Me.TransactionsToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 13.8!, System.Drawing.FontStyle.Bold)
        Me.TransactionsToolStripMenuItem.Name = "TransactionsToolStripMenuItem"
        Me.TransactionsToolStripMenuItem.Size = New System.Drawing.Size(157, 35)
        Me.TransactionsToolStripMenuItem.Text = "Transactions"
        '
        'SaleToolStripMenuItem
        '
        Me.SaleToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddToolStripMenuItem2, Me.ModifyToolStripMenuItem2, Me.DeleteToolStripMenuItem2, Me.DisplayToolStripMenuItem})
        Me.SaleToolStripMenuItem.Name = "SaleToolStripMenuItem"
        Me.SaleToolStripMenuItem.Size = New System.Drawing.Size(195, 36)
        Me.SaleToolStripMenuItem.Text = "Sale"
        '
        'AddToolStripMenuItem2
        '
        Me.AddToolStripMenuItem2.Name = "AddToolStripMenuItem2"
        Me.AddToolStripMenuItem2.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.AddToolStripMenuItem2.Size = New System.Drawing.Size(270, 36)
        Me.AddToolStripMenuItem2.Text = "Add"
        '
        'ModifyToolStripMenuItem2
        '
        Me.ModifyToolStripMenuItem2.Name = "ModifyToolStripMenuItem2"
        Me.ModifyToolStripMenuItem2.Size = New System.Drawing.Size(270, 36)
        Me.ModifyToolStripMenuItem2.Text = "Modify"
        '
        'DeleteToolStripMenuItem2
        '
        Me.DeleteToolStripMenuItem2.Name = "DeleteToolStripMenuItem2"
        Me.DeleteToolStripMenuItem2.Size = New System.Drawing.Size(270, 36)
        Me.DeleteToolStripMenuItem2.Text = "Delete"
        '
        'DisplayToolStripMenuItem
        '
        Me.DisplayToolStripMenuItem.Name = "DisplayToolStripMenuItem"
        Me.DisplayToolStripMenuItem.Size = New System.Drawing.Size(270, 36)
        Me.DisplayToolStripMenuItem.Text = "Display"
        '
        'PurchaseToolStripMenuItem
        '
        Me.PurchaseToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddToolStripMenuItem1, Me.DeleteToolStripMenuItem1, Me.SearchToolStripMenuItem4})
        Me.PurchaseToolStripMenuItem.Name = "PurchaseToolStripMenuItem"
        Me.PurchaseToolStripMenuItem.Size = New System.Drawing.Size(195, 36)
        Me.PurchaseToolStripMenuItem.Text = "Purchase"
        '
        'AddToolStripMenuItem1
        '
        Me.AddToolStripMenuItem1.Name = "AddToolStripMenuItem1"
        Me.AddToolStripMenuItem1.Size = New System.Drawing.Size(179, 36)
        Me.AddToolStripMenuItem1.Text = "Add"
        '
        'DeleteToolStripMenuItem1
        '
        Me.DeleteToolStripMenuItem1.Name = "DeleteToolStripMenuItem1"
        Me.DeleteToolStripMenuItem1.Size = New System.Drawing.Size(179, 36)
        Me.DeleteToolStripMenuItem1.Text = "Delete"
        '
        'SearchToolStripMenuItem4
        '
        Me.SearchToolStripMenuItem4.Name = "SearchToolStripMenuItem4"
        Me.SearchToolStripMenuItem4.Size = New System.Drawing.Size(179, 36)
        Me.SearchToolStripMenuItem4.Text = "Display"
        '
        'SupplierToolStripMenuItem
        '
        Me.SupplierToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddToolStripMenuItem4, Me.ModifyToolStripMenuItem4, Me.DisplayToolStripMenuItem4})
        Me.SupplierToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 13.8!, System.Drawing.FontStyle.Bold)
        Me.SupplierToolStripMenuItem.Name = "SupplierToolStripMenuItem"
        Me.SupplierToolStripMenuItem.Size = New System.Drawing.Size(115, 35)
        Me.SupplierToolStripMenuItem.Text = "Supplier"
        '
        'AddToolStripMenuItem4
        '
        Me.AddToolStripMenuItem4.Name = "AddToolStripMenuItem4"
        Me.AddToolStripMenuItem4.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
        Me.AddToolStripMenuItem4.Size = New System.Drawing.Size(268, 36)
        Me.AddToolStripMenuItem4.Text = "Add"
        '
        'ModifyToolStripMenuItem4
        '
        Me.ModifyToolStripMenuItem4.Name = "ModifyToolStripMenuItem4"
        Me.ModifyToolStripMenuItem4.Size = New System.Drawing.Size(268, 36)
        Me.ModifyToolStripMenuItem4.Text = "Modify"
        '
        'DisplayToolStripMenuItem4
        '
        Me.DisplayToolStripMenuItem4.Name = "DisplayToolStripMenuItem4"
        Me.DisplayToolStripMenuItem4.Size = New System.Drawing.Size(268, 36)
        Me.DisplayToolStripMenuItem4.Text = "Display"
        '
        'DashboardToolStripMenuItem
        '
        Me.DashboardToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 13.8!, System.Drawing.FontStyle.Bold)
        Me.DashboardToolStripMenuItem.Name = "DashboardToolStripMenuItem"
        Me.DashboardToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.DashboardToolStripMenuItem.Size = New System.Drawing.Size(143, 35)
        Me.DashboardToolStripMenuItem.Text = "Dashboard"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddItemToolStripMenuItem, Me.AddSalesToolStripMenuItem, Me.AddPurchaseToolStripMenuItem, Me.ToolStripMenuItem1, Me.UpdateStockToolStripMenuItem, Me.ToolStripMenuItem2, Me.SearchToolStripMenuItem1})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(202, 136)
        '
        'AddItemToolStripMenuItem
        '
        Me.AddItemToolStripMenuItem.Name = "AddItemToolStripMenuItem"
        Me.AddItemToolStripMenuItem.Size = New System.Drawing.Size(201, 24)
        Me.AddItemToolStripMenuItem.Text = "Add Item"
        '
        'AddSalesToolStripMenuItem
        '
        Me.AddSalesToolStripMenuItem.Name = "AddSalesToolStripMenuItem"
        Me.AddSalesToolStripMenuItem.Size = New System.Drawing.Size(201, 24)
        Me.AddSalesToolStripMenuItem.Text = "Add Sales"
        '
        'AddPurchaseToolStripMenuItem
        '
        Me.AddPurchaseToolStripMenuItem.Name = "AddPurchaseToolStripMenuItem"
        Me.AddPurchaseToolStripMenuItem.Size = New System.Drawing.Size(201, 24)
        Me.AddPurchaseToolStripMenuItem.Text = "Add Purchase"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(198, 6)
        '
        'UpdateStockToolStripMenuItem
        '
        Me.UpdateStockToolStripMenuItem.Name = "UpdateStockToolStripMenuItem"
        Me.UpdateStockToolStripMenuItem.Size = New System.Drawing.Size(201, 24)
        Me.UpdateStockToolStripMenuItem.Text = "Update Stock"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(198, 6)
        '
        'SearchToolStripMenuItem1
        '
        Me.SearchToolStripMenuItem1.Name = "SearchToolStripMenuItem1"
        Me.SearchToolStripMenuItem1.Size = New System.Drawing.Size(201, 24)
        Me.SearchToolStripMenuItem1.Text = "Search Transaction"
        '
        'ToolTip1
        '
        Me.ToolTip1.ToolTipTitle = "Click here to logout"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 911)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(2050, 66)
        Me.Panel1.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Now", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(3, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1555, 34)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Store Wise (SAKSHAM BCA III 5556) Store Wise (SAKSHAM BCA III 5556) Store Wise (S" &
    "AKSHAM BCA III 5556)"
        '
        'Timer1
        '
        '
        'MainPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1902, 1033)
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainPage"
        Me.Text = "Store Wise"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents UserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ItemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModifyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DisplayToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TransactionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModifyToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DisplayToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SupplierToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModifyToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DisplayToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DashboardToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AddItemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddSalesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddPurchaseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents UpdateStockToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SearchToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents PurchaseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SearchToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangeCredentialsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangeThemeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InventoryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DisplayToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
End Class
