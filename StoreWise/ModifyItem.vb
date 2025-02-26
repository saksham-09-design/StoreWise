Public Class ModifyItem

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        'showing all fields
        Label1.Visible = True
        Label2.Visible = True
        Label3.Visible = True
        Label4.Visible = True
        Label6.Visible = True
        Label7.Visible = True
        Label8.Visible = True
        Label9.Visible = True
        itemName.Visible = True
        itemUnit.Visible = True
        itemCost.Visible = True
        itemSP.Visible = True
        itemGST.Visible = True
        Modify.Visible = True
        cancle.Visible = True
        reOrder.Visible = True
        Label5.Visible = True
        supplierName.Visible = True

        'fetching item details from database
        Dim conn As New OleDb.OleDbConnection
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Saksham\Documents\StoreWise.accdb"
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            Dim sql As String = "SELECT * FROM itemTable WHERE itemName = '" & ComboBox1.Text & "'"
            Dim cmd As New OleDb.OleDbCommand(sql, conn)
            Dim da As New OleDb.OleDbDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                itemName.Text = dt.Rows(0).Item(2).ToString
                itemUnit.SelectedItem = dt.Rows(0).Item(3).ToString
                reOrder.Text = dt.Rows(0).Item(4)
                itemCost.Text = dt.Rows(0).Item(5)
                itemSP.Text = dt.Rows(0).Item(6)
                itemGST.SelectedItem = dt.Rows(0).Item(7).ToString & "%"
                supplierName.Text = dt.Rows(0).Item(1).ToString
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Store Wise", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try

    End Sub

    Private Sub Modify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Modify.Click
        If (itemName.Text.Trim = "" Or itemUnit.Text.Trim = "" Or itemSP.Text.Trim = "" Or itemCost.Text.Trim = "" Or reOrder.Text.Trim = "") Then
            MessageBox.Show("Please Fill All Fields")
        Else
            Dim conn As New OleDb.OleDbConnection
            conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Saksham\Documents\StoreWise.accdb"
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            Dim sql As String = "UPDATE itemTable SET itemName = '" & itemName.Text.Trim & "', unit = '" & itemUnit.Text.Trim & "', reOrderLevel = '" & CDbl(reOrder.Text.Trim) & "', costUnit = '" & CDbl(itemCost.Text.Trim) & "', sellUnit = '" & CDbl(itemSP.Text.Trim) & "', gst = '" & CDbl(itemGST.Text.Trim.Replace("%", "")) & "' WHERE itemName = '" & ComboBox1.Text & "'"
            Dim cmd As New OleDb.OleDbCommand(sql, conn)
            Try
                cmd.ExecuteNonQuery()
                MessageBox.Show("Item Updated Successfully", "Store Wise", MessageBoxButtons.OK, MessageBoxIcon.Information)
                itemName.Clear()
                itemCost.Clear()
                itemGST.SelectedIndex = 0
                itemSP.Clear()
                itemUnit.SelectedIndex = 0
                reOrder.Clear()
                supplierName.Clear()
                updateItem()
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Store Wise", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                conn.Close()
            End Try
        End If
    End Sub

    Private Sub itemCost_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles itemCost.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not e.KeyChar = "."c AndAlso Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MessageBox.Show("Quantity must be in Numbers.", "Store Wise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf e.KeyChar = "."c AndAlso itemCost.Text.Contains(".") Then
            e.Handled = True
            MessageBox.Show("Only one decimal point is allowed.", "Store Wise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub itemSP_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles itemSP.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not e.KeyChar = "."c AndAlso Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MessageBox.Show("Quantity must be in Numbers.", "Store Wise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf e.KeyChar = "."c AndAlso itemSP.Text.Contains(".") Then
            e.Handled = True
            MessageBox.Show("Only one decimal point is allowed.", "Store Wise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub reOrder_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles reOrder.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not e.KeyChar = "."c AndAlso Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MessageBox.Show("Quantity must be in Numbers.", "Store Wise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf e.KeyChar = "."c AndAlso itemSP.Text.Contains(".") Then
            e.Handled = True
            MessageBox.Show("Only one decimal point is allowed.", "Store Wise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub cancle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cancle.Click
        Me.Close()
    End Sub

    'Updating Item List
    Sub updateItem()
        Dim conn As New OleDb.OleDbConnection
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Saksham\Documents\StoreWise.accdb"
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            Dim sql As String = "SELECT itemName FROM itemTable"
            Dim cmd As New OleDb.OleDbCommand(sql, conn)
            Dim da As New OleDb.OleDbDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)
            ComboBox1.DataSource = dt
            ComboBox1.DisplayMember = "itemName"
            If dt.Rows.Count = 0 Then
                MessageBox.Show("No Item found update list ", "Store Wise", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Store Wise", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub ModifyItem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim conn As New OleDb.OleDbConnection
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Saksham\Documents\StoreWise.accdb"
        updateItem()
        'setting default values
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            Dim sql As String = "SELECT * FROM itemTable WHERE itemName = '" & ComboBox1.Text & "'"
            Dim cmd As New OleDb.OleDbCommand(sql, conn)
            Dim da As New OleDb.OleDbDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                itemName.Text = dt.Rows(0).Item(2).ToString
                itemUnit.SelectedItem = dt.Rows(0).Item(3).ToString
                reOrder.Text = dt.Rows(0).Item(4)
                itemCost.Text = dt.Rows(0).Item(5)
                itemSP.Text = dt.Rows(0).Item(6)
                itemGST.SelectedItem = dt.Rows(0).Item(7).ToString & "%"
                supplierName.Text = dt.Rows(0).Item(1).ToString
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Store Wise", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try

        'Setting the dark mode
        If (DMode) Then
            Me.BackColor = Color.FromArgb(255, 13, 17, 23)
            For i = 1 To 9
                Dim lbl As Label = Me.Controls("Label" & i)
                lbl.ForeColor = Color.FromArgb(255, 240, 246, 252)
            Next
            Modify.BackColor = Color.FromArgb(255, 31, 111, 235)
            cancle.BackColor = Color.FromArgb(255, 31, 111, 235)
            Modify.ForeColor = Color.FromArgb(255, Color.White)
            cancle.ForeColor = Color.FromArgb(255, Color.White)
            ComboBox1.BackColor = Color.FromArgb(255, 33, 40, 48)
            ComboBox1.ForeColor = Color.FromArgb(255, 240, 246, 252)
            itemName.BackColor = Color.FromArgb(255, 33, 40, 48)
            itemName.ForeColor = Color.FromArgb(255, 240, 246, 252)
            itemUnit.BackColor = Color.FromArgb(255, 33, 40, 48)
            itemUnit.ForeColor = Color.FromArgb(255, 240, 246, 252)
            reOrder.BackColor = Color.FromArgb(255, 33, 40, 48)
            reOrder.ForeColor = Color.FromArgb(255, 240, 246, 252) '
            itemCost.BackColor = Color.FromArgb(255, 33, 40, 48)
            itemCost.ForeColor = Color.FromArgb(255, 240, 246, 252)
            itemGST.BackColor = Color.FromArgb(255, 33, 40, 48)
            itemGST.ForeColor = Color.FromArgb(255, 240, 246, 252)
            itemSP.BackColor = Color.FromArgb(255, 33, 40, 48)
            itemSP.ForeColor = Color.FromArgb(255, 240, 246, 252)
            supplierName.BackColor = Color.FromArgb(255, 33, 40, 48)
            supplierName.ForeColor = Color.FromArgb(255, 240, 246, 252)
        End If
    End Sub
End Class