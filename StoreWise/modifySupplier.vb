Public Class modifySupplier
    Dim sid As Integer = 1

    Private Sub phone_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles phone.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MessageBox.Show("Phone must be in Numbers.", "Store Wise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
    Private Sub eMail_KeyPress(sender As Object, e As KeyPressEventArgs) Handles eMail.KeyPress
        If e.KeyChar = "@"c AndAlso eMail.Text.Contains("@") Then
            e.Handled = True
            MessageBox.Show("Only one @ is allowed.", "Store Wise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub save_Click(sender As Object, e As EventArgs) Handles save.Click
        'Modifying Supplier
        If (supplierName.Text.Trim = "" Or phone.Text.Trim = "" Or eMail.Text.Trim = "") Then
            MessageBox.Show("All fields are required", "Store Wise", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf ((eMail.Text.Trim.EndsWith(".com") = False) Or (eMail.Text.Trim.Contains("@") = False)) Then
            MessageBox.Show("Invalid Email", "Store Wise", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim conn As New OleDb.OleDbConnection
            conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Saksham\Documents\StoreWise.accdb"
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            Dim sql As String = "update supplierTable set sName='" & supplierName.Text.Trim & "', sPhone='" & CInt(phone.Text.Trim) & "', sEMail='" & eMail.Text.Trim & "' where ID =" & sid
            Dim cmd As New OleDb.OleDbCommand(sql, conn)
            If cmd.ExecuteNonQuery() <> 0 Then
                MessageBox.Show("Supplier Modified Successfully", "Store Wise", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Try
                    update_List()
                Catch ex As Exception
                    MessageBox.Show("No Supplier Found", "Store Wise", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
                supplierName.Text = ""
                phone.Text = ""
                eMail.Text = ""
                Try
                    supplierNameList.SelectedIndex = 0
                Catch ex As Exception
                    MessageBox.Show("No Supplier Found", "Store Wise", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
            conn.Close()
        End If
    End Sub

    Sub update_List()
        Dim conn As New OleDb.OleDbConnection
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Saksham\Documents\StoreWise.accdb"
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        Dim sql As String = "select sName from supplierTable"
        Dim cmd As New OleDb.OleDbCommand(sql, conn)
        Dim da As OleDb.OleDbDataAdapter
        da = New OleDb.OleDbDataAdapter(cmd)
        Dim dt As New DataTable
        dt.Clear()
        da.Fill(dt)
        If dt.Rows.Count = 0 Then
            MessageBox.Show("No Supplier found", "Store Wise", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            supplierNameList.DataSource = dt
            supplierNameList.DisplayMember = "sName"
        End If
        conn.Close()
    End Sub

    Private Sub modifySupplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            save.BackColor = Color.FromArgb(255, 31, 111, 235)
            save.BackColor = Color.FromArgb(255, 31, 111, 235)
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

    Private Sub cancle_Click(sender As Object, e As EventArgs) Handles cancle.Click
        Me.Close()
    End Sub

    Private Sub supplierNameList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles supplierNameList.SelectedIndexChanged
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
        dt.Clear()
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            supplierName.Text = dt.Rows(0).Item(1)
            phone.Text = dt.Rows(0).Item(2)
            eMail.Text = dt.Rows(0).Item(3)
            sid = dt.Rows(0).Item(0)
        Else
            MessageBox.Show("No Supplier found", "Store Wise", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        conn.Close()
    End Sub
End Class