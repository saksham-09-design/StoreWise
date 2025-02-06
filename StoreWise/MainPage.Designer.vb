<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainPage
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
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.UserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModifyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisplayToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransactionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModifyToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisplayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PurchaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModifyToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisplayToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SupplierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModifyToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisplayToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DashboardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.addItem = New System.Windows.Forms.Button()
        Me.addSupplier = New System.Windows.Forms.Button()
        Me.addSale = New System.Windows.Forms.Button()
        Me.addPurchase = New System.Windows.Forms.Button()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AddItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddSalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddPurchaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.UpdateStockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.SearchToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.searchTransaction = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UserToolStripMenuItem, Me.ItemToolStripMenuItem, Me.StockToolStripMenuItem, Me.TransactionsToolStripMenuItem, Me.SupplierToolStripMenuItem, Me.DashboardToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1902, 28)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'UserToolStripMenuItem
        '
        Me.UserToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem1})
        Me.UserToolStripMenuItem.Name = "UserToolStripMenuItem"
        Me.UserToolStripMenuItem.Size = New System.Drawing.Size(50, 24)
        Me.UserToolStripMenuItem.Text = "User"
        Me.UserToolStripMenuItem.ToolTipText = "User"
        '
        'ExitToolStripMenuItem1
        '
        Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(125, 24)
        Me.ExitToolStripMenuItem1.Text = "Logout"
        '
        'ItemToolStripMenuItem
        '
        Me.ItemToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddToolStripMenuItem, Me.ModifyToolStripMenuItem, Me.DeleteToolStripMenuItem, Me.DisplayToolStripMenuItem2, Me.SearchToolStripMenuItem})
        Me.ItemToolStripMenuItem.Name = "ItemToolStripMenuItem"
        Me.ItemToolStripMenuItem.Size = New System.Drawing.Size(51, 24)
        Me.ItemToolStripMenuItem.Text = "Item"
        '
        'AddToolStripMenuItem
        '
        Me.AddToolStripMenuItem.Name = "AddToolStripMenuItem"
        Me.AddToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
                    Or System.Windows.Forms.Keys.I), System.Windows.Forms.Keys)
        Me.AddToolStripMenuItem.Size = New System.Drawing.Size(181, 24)
        Me.AddToolStripMenuItem.Text = "Add"
        '
        'ModifyToolStripMenuItem
        '
        Me.ModifyToolStripMenuItem.Name = "ModifyToolStripMenuItem"
        Me.ModifyToolStripMenuItem.Size = New System.Drawing.Size(181, 24)
        Me.ModifyToolStripMenuItem.Text = "Modify"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(181, 24)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'DisplayToolStripMenuItem2
        '
        Me.DisplayToolStripMenuItem2.Name = "DisplayToolStripMenuItem2"
        Me.DisplayToolStripMenuItem2.Size = New System.Drawing.Size(181, 24)
        Me.DisplayToolStripMenuItem2.Text = "Display"
        '
        'SearchToolStripMenuItem
        '
        Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(181, 24)
        Me.SearchToolStripMenuItem.Text = "Search"
        '
        'StockToolStripMenuItem
        '
        Me.StockToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UpdateToolStripMenuItem})
        Me.StockToolStripMenuItem.Name = "StockToolStripMenuItem"
        Me.StockToolStripMenuItem.Size = New System.Drawing.Size(57, 24)
        Me.StockToolStripMenuItem.Text = "Stock"
        '
        'UpdateToolStripMenuItem
        '
        Me.UpdateToolStripMenuItem.Name = "UpdateToolStripMenuItem"
        Me.UpdateToolStripMenuItem.Size = New System.Drawing.Size(127, 24)
        Me.UpdateToolStripMenuItem.Text = "Update"
        '
        'TransactionsToolStripMenuItem
        '
        Me.TransactionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaleToolStripMenuItem, Me.PurchaseToolStripMenuItem, Me.SearchToolStripMenuItem2})
        Me.TransactionsToolStripMenuItem.Name = "TransactionsToolStripMenuItem"
        Me.TransactionsToolStripMenuItem.Size = New System.Drawing.Size(102, 24)
        Me.TransactionsToolStripMenuItem.Text = "Transactions"
        '
        'SaleToolStripMenuItem
        '
        Me.SaleToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddToolStripMenuItem2, Me.ModifyToolStripMenuItem2, Me.DeleteToolStripMenuItem2, Me.DisplayToolStripMenuItem})
        Me.SaleToolStripMenuItem.Name = "SaleToolStripMenuItem"
        Me.SaleToolStripMenuItem.Size = New System.Drawing.Size(200, 24)
        Me.SaleToolStripMenuItem.Text = "Sale"
        '
        'AddToolStripMenuItem2
        '
        Me.AddToolStripMenuItem2.Name = "AddToolStripMenuItem2"
        Me.AddToolStripMenuItem2.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
                    Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.AddToolStripMenuItem2.Size = New System.Drawing.Size(185, 24)
        Me.AddToolStripMenuItem2.Text = "Add"
        '
        'ModifyToolStripMenuItem2
        '
        Me.ModifyToolStripMenuItem2.Name = "ModifyToolStripMenuItem2"
        Me.ModifyToolStripMenuItem2.Size = New System.Drawing.Size(185, 24)
        Me.ModifyToolStripMenuItem2.Text = "Modify"
        '
        'DeleteToolStripMenuItem2
        '
        Me.DeleteToolStripMenuItem2.Name = "DeleteToolStripMenuItem2"
        Me.DeleteToolStripMenuItem2.Size = New System.Drawing.Size(185, 24)
        Me.DeleteToolStripMenuItem2.Text = "Delete"
        '
        'DisplayToolStripMenuItem
        '
        Me.DisplayToolStripMenuItem.Name = "DisplayToolStripMenuItem"
        Me.DisplayToolStripMenuItem.Size = New System.Drawing.Size(185, 24)
        Me.DisplayToolStripMenuItem.Text = "Display"
        '
        'PurchaseToolStripMenuItem
        '
        Me.PurchaseToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddToolStripMenuItem3, Me.ModifyToolStripMenuItem3, Me.DeleteToolStripMenuItem3, Me.DisplayToolStripMenuItem1})
        Me.PurchaseToolStripMenuItem.Name = "PurchaseToolStripMenuItem"
        Me.PurchaseToolStripMenuItem.Size = New System.Drawing.Size(200, 24)
        Me.PurchaseToolStripMenuItem.Text = "Purchase"
        '
        'AddToolStripMenuItem3
        '
        Me.AddToolStripMenuItem3.Name = "AddToolStripMenuItem3"
        Me.AddToolStripMenuItem3.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
                    Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.AddToolStripMenuItem3.Size = New System.Drawing.Size(185, 24)
        Me.AddToolStripMenuItem3.Text = "Add"
        '
        'ModifyToolStripMenuItem3
        '
        Me.ModifyToolStripMenuItem3.Name = "ModifyToolStripMenuItem3"
        Me.ModifyToolStripMenuItem3.Size = New System.Drawing.Size(185, 24)
        Me.ModifyToolStripMenuItem3.Text = "Modify"
        '
        'DeleteToolStripMenuItem3
        '
        Me.DeleteToolStripMenuItem3.Name = "DeleteToolStripMenuItem3"
        Me.DeleteToolStripMenuItem3.Size = New System.Drawing.Size(185, 24)
        Me.DeleteToolStripMenuItem3.Text = "Delete"
        '
        'DisplayToolStripMenuItem1
        '
        Me.DisplayToolStripMenuItem1.Name = "DisplayToolStripMenuItem1"
        Me.DisplayToolStripMenuItem1.Size = New System.Drawing.Size(185, 24)
        Me.DisplayToolStripMenuItem1.Text = "Display"
        '
        'SearchToolStripMenuItem2
        '
        Me.SearchToolStripMenuItem2.Name = "SearchToolStripMenuItem2"
        Me.SearchToolStripMenuItem2.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
                    Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.SearchToolStripMenuItem2.Size = New System.Drawing.Size(200, 24)
        Me.SearchToolStripMenuItem2.Text = "Search"
        '
        'SupplierToolStripMenuItem
        '
        Me.SupplierToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddToolStripMenuItem4, Me.ModifyToolStripMenuItem4, Me.DeleteToolStripMenuItem4, Me.DisplayToolStripMenuItem4, Me.SearchToolStripMenuItem3})
        Me.SupplierToolStripMenuItem.Name = "SupplierToolStripMenuItem"
        Me.SupplierToolStripMenuItem.Size = New System.Drawing.Size(76, 24)
        Me.SupplierToolStripMenuItem.Text = "Supplier"
        '
        'AddToolStripMenuItem4
        '
        Me.AddToolStripMenuItem4.Name = "AddToolStripMenuItem4"
        Me.AddToolStripMenuItem4.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
                    Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.AddToolStripMenuItem4.Size = New System.Drawing.Size(185, 24)
        Me.AddToolStripMenuItem4.Text = "Add"
        '
        'ModifyToolStripMenuItem4
        '
        Me.ModifyToolStripMenuItem4.Name = "ModifyToolStripMenuItem4"
        Me.ModifyToolStripMenuItem4.Size = New System.Drawing.Size(185, 24)
        Me.ModifyToolStripMenuItem4.Text = "Modify"
        '
        'DeleteToolStripMenuItem4
        '
        Me.DeleteToolStripMenuItem4.Name = "DeleteToolStripMenuItem4"
        Me.DeleteToolStripMenuItem4.Size = New System.Drawing.Size(185, 24)
        Me.DeleteToolStripMenuItem4.Text = "Delete"
        '
        'DisplayToolStripMenuItem4
        '
        Me.DisplayToolStripMenuItem4.Name = "DisplayToolStripMenuItem4"
        Me.DisplayToolStripMenuItem4.Size = New System.Drawing.Size(185, 24)
        Me.DisplayToolStripMenuItem4.Text = "Display"
        '
        'SearchToolStripMenuItem3
        '
        Me.SearchToolStripMenuItem3.Name = "SearchToolStripMenuItem3"
        Me.SearchToolStripMenuItem3.Size = New System.Drawing.Size(185, 24)
        Me.SearchToolStripMenuItem3.Text = "Search"
        '
        'DashboardToolStripMenuItem
        '
        Me.DashboardToolStripMenuItem.Name = "DashboardToolStripMenuItem"
        Me.DashboardToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
                    Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.DashboardToolStripMenuItem.Size = New System.Drawing.Size(94, 24)
        Me.DashboardToolStripMenuItem.Text = "Dashboard"
        '
        'addItem
        '
        Me.addItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addItem.ForeColor = System.Drawing.SystemColors.Highlight
        Me.addItem.Location = New System.Drawing.Point(1686, 47)
        Me.addItem.Name = "addItem"
        Me.addItem.Size = New System.Drawing.Size(308, 65)
        Me.addItem.TabIndex = 2
        Me.addItem.Text = "Add Item"
        Me.addItem.UseVisualStyleBackColor = True
        '
        'addSupplier
        '
        Me.addSupplier.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addSupplier.ForeColor = System.Drawing.SystemColors.Highlight
        Me.addSupplier.Location = New System.Drawing.Point(1686, 138)
        Me.addSupplier.Name = "addSupplier"
        Me.addSupplier.Size = New System.Drawing.Size(308, 65)
        Me.addSupplier.TabIndex = 4
        Me.addSupplier.Text = "Add supplier"
        Me.addSupplier.UseVisualStyleBackColor = True
        '
        'addSale
        '
        Me.addSale.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addSale.ForeColor = System.Drawing.SystemColors.Highlight
        Me.addSale.Location = New System.Drawing.Point(1686, 230)
        Me.addSale.Name = "addSale"
        Me.addSale.Size = New System.Drawing.Size(308, 65)
        Me.addSale.TabIndex = 5
        Me.addSale.Text = "Add sale"
        Me.addSale.UseVisualStyleBackColor = True
        '
        'addPurchase
        '
        Me.addPurchase.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addPurchase.ForeColor = System.Drawing.SystemColors.Highlight
        Me.addPurchase.Location = New System.Drawing.Point(1686, 319)
        Me.addPurchase.Name = "addPurchase"
        Me.addPurchase.Size = New System.Drawing.Size(308, 65)
        Me.addPurchase.TabIndex = 6
        Me.addPurchase.Text = "Add purchase"
        Me.addPurchase.UseVisualStyleBackColor = True
        '
        'ContextMenuStrip1
        '
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
        'searchTransaction
        '
        Me.searchTransaction.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchTransaction.ForeColor = System.Drawing.SystemColors.Highlight
        Me.searchTransaction.Location = New System.Drawing.Point(1686, 406)
        Me.searchTransaction.Name = "searchTransaction"
        Me.searchTransaction.Size = New System.Drawing.Size(308, 65)
        Me.searchTransaction.TabIndex = 8
        Me.searchTransaction.Text = "Search Tansaction"
        Me.searchTransaction.UseVisualStyleBackColor = True
        '
        'ToolTip1
        '
        Me.ToolTip1.ToolTipTitle = "Click here to logout"
        '
        'MainPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1902, 1033)
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Controls.Add(Me.searchTransaction)
        Me.Controls.Add(Me.addPurchase)
        Me.Controls.Add(Me.addSale)
        Me.Controls.Add(Me.addSupplier)
        Me.Controls.Add(Me.addItem)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainPage"
        Me.Text = "Store Wise"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents UserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ItemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModifyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DisplayToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TransactionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModifyToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DisplayToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PurchaseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModifyToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DisplayToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SupplierToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModifyToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DisplayToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents addItem As System.Windows.Forms.Button
    Friend WithEvents addSupplier As System.Windows.Forms.Button
    Friend WithEvents addSale As System.Windows.Forms.Button
    Friend WithEvents addPurchase As System.Windows.Forms.Button
    Friend WithEvents DashboardToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SearchToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SearchToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SearchToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StockToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpdateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AddItemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddSalesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddPurchaseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents UpdateStockToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SearchToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents searchTransaction As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
