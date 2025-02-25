Public Class deleteSupplier
    Dim sid As Integer

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles supplierNameList.SelectedIndexChanged
        'fetching supplier details
        Dim conn As New OleDb.OleDbConnection
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Saksham\Documents\StoreWise.accdb"
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        Dim sql As String = "select * from supplierTable where sName='" & supplierNameList.Text & "'"
        Dim cmd As New OleDb.OleDbCommand(sql, conn)
        Dim da As OleDb.OleDbDataAdapter
        da = New OleDb.OleDbDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            supplierName.Text = dt.Rows(0).Item(1)
            phone.Text = dt.Rows(0).Item(2)
            eMail.Text = dt.Rows(0).Item(3)
            sid = dt.Rows(0).Item(0)
        End If
        conn.Close()
    End Sub
    Sub update_List()
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
                supplierName.Clear()
                phone.Clear()
                eMail.Clear()
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Store Wise", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub deleteSupplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            update_List()
        Catch ex As Exception
            MessageBox.Show("No Supplier Found", "Store Wise", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        'setting up dark mode
        If (DMode) Then
            Me.BackColor = Color.FromArgb(255, 13, 17, 23)
            For i = 1 To 5
                Dim lbl As Label = Me.Controls("Label" & i)
                lbl.ForeColor = Color.FromArgb(255, 240, 246, 252)
            Next
            delete.BackColor = Color.FromArgb(255, 31, 111, 235)
            delete.BackColor = Color.FromArgb(255, 31, 111, 235)
            cancle.BackColor = Color.FromArgb(255, 31, 111, 235)
            cancle.BackColor = Color.FromArgb(255, 31, 111, 235)
            cancle.BackColor = Color.FromArgb(255, 31, 111, 235)
            supplierName.BackColor = Color.FromArgb(255, 33, 40, 48)
            supplierName.ForeColor = Color.FromArgb(255, 240, 246, 252)
            phone.BackColor = Color.FromArgb(255, 33, 40, 48)
            phone.ForeColor = Color.FromArgb(255, 240, 246, 252)
            eMail.BackColor = Color.FromArgb(255, 33, 40, 48)
            eMail.ForeColor = Color.FromArgb(255, 240, 246, 252)
            supplierNameList.BackColor = Color.FromArgb(255, 33, 40, 48)
            supplierNameList.ForeColor = Color.FromArgb(255, 240, 246, 252)
        End If
    End Sub

    Private Sub delete_Click(sender As Object, e As EventArgs) Handles delete.Click
        If supplierName.Text.Trim = "" Then
            MessageBox.Show("No Supplier to delete", "Store Wise", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Dim conn As New OleDb.OleDbConnection
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Saksham\Documents\StoreWise.accdb"
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        Dim sql As String = "delete from supplierTable where ID =" & sid
        Dim cmd As New OleDb.OleDbCommand(sql, conn)
        If cmd.ExecuteNonQuery() <> 0 Then
            MessageBox.Show("Supplier Deleted Successfully", "Store Wise", MessageBoxButtons.OK, MessageBoxIcon.Information)
            update_List()
        End If
        conn.Close()
    End Sub
End Class