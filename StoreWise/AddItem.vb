Public Class AddItem

    Private Sub cancle_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cancle.Click
        Me.Close()
    End Sub

    Private Sub clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clear.Click
        itemName.Clear()
        itemUnit.SelectedIndex = 0
        reOrder.Clear()
        itemCost.Clear()
        itemSP.Clear()
        itemGST.SelectedIndex = 0
    End Sub
    Private Sub save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles save.Click
        If (supplierNameList.Text = "" Or itemName.Text.Trim = "" Or itemUnit.Text.Trim = "" Or itemSP.Text.Trim = "" Or itemCost.Text.Trim = "" Or itemGST.Text.Trim = "" Or reOrder.Text.Trim = "") Then
            MessageBox.Show("Please Fill All Fields")
        Else
            Dim conn As New OleDb.OleDbConnection
            conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Saksham\Documents\StoreWise.accdb"

            'Inserting into item table
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            Dim sql As String = "insert into itemTable (sName, itemName, unit, reOrderLevel, costUnit, sellUnit, gst) values ('" & supplierNameList.Text.Trim & "','" & itemName.Text.Trim & "','" & itemUnit.Text.Trim & "','" & CDbl(reOrder.Text.Trim) & "','" & CDbl(itemCost.Text.Trim) & "','" & CDbl(itemSP.Text.Trim) & "','" & CDbl(itemGST.Text.Trim.Replace("%", "")) & "')"
            Dim cmd As New OleDb.OleDbCommand(sql, conn)
            Try
                cmd.ExecuteNonQuery()
                MessageBox.Show("Item Added Successfully", "Store Wise", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Store Wise", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                conn.Close()
            End Try

            'fetching Item id
            Dim itemID As Integer

            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            Try
                Dim sql2 As String = "SELECT ID FROM itemTable WHERE itemName = '" & itemName.Text.Trim & "'"
                Dim cmd2 As New OleDb.OleDbCommand(sql2, conn)
                Dim da As New OleDb.OleDbDataAdapter(cmd2)
                Dim dt As New DataTable
                da.Fill(dt)
                itemID = dt.Rows(0).Item(0)
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Store Wise", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                conn.Close()
            End Try

            'Inserting into inventory table
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            Dim sql1 As String = "insert into inventoryTable (itemId, itemName, quantity) values( '" & itemID & "','" & itemName.Text.Trim & "'," & 0 & ")"
            Dim cmd1 As New OleDb.OleDbCommand(sql1, conn)
            Try
                cmd1.ExecuteNonQuery()
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Store Wise", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                conn.Close()
            End Try


            'clearing data fields
            Try
                itemName.Clear()
                itemCost.Clear()
                itemGST.SelectedIndex = 0
                itemSP.Clear()
                itemUnit.SelectedIndex = 0
                reOrder.Clear()
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Store Wise", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub AddItem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim conn As New OleDb.OleDbConnection

        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Saksham\Documents\StoreWise.accdb"

        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

            Dim sql As String = "SELECT sName FROM supplierTable"
            Dim cmd As New OleDb.OleDbCommand(sql, conn)
            Dim da As New OleDb.OleDbDataAdapter(cmd)
            Dim dt As New DataTable

            da.Fill(dt)

            supplierNameList.DataSource = dt
            supplierNameList.DisplayMember = "sName"

            If dt.Rows.Count = 0 Then
                MessageBox.Show("No Supplier found update list ", "Store Wise", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Store Wise", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            conn.Close()
        End Try
        'Setting the default values
        itemUnit.SelectedIndex = 0
        itemGST.SelectedIndex = 0
        If (DMode) Then
            Me.BackColor = Color.FromArgb(255, 13, 17, 23)
            For i = 1 To 8
                Dim lbl As Label = Me.Controls("Label" & i)
                lbl.ForeColor = Color.FromArgb(255, 240, 246, 252)
            Next
            save.BackColor = Color.FromArgb(255, 31, 111, 235)
            clear.BackColor = Color.FromArgb(255, 31, 111, 235)
            cancle.BackColor = Color.FromArgb(255, 31, 111, 235)
            save.ForeColor = Color.FromArgb(255, Color.White)
            clear.ForeColor = Color.FromArgb(255, Color.White)
            cancle.ForeColor = Color.FromArgb(255, Color.White)
            supplierNameList.BackColor = Color.FromArgb(255, 33, 40, 48)
            supplierNameList.ForeColor = Color.FromArgb(255, 240, 246, 252)
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
        ElseIf e.KeyChar = "."c AndAlso reOrder.Text.Contains(".") Then
            e.Handled = True
            MessageBox.Show("Only one decimal point is allowed.", "Store Wise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub supplierNameList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles supplierNameList.SelectedIndexChanged

    End Sub
End Class