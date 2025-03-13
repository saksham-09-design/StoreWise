Public Class addSupplier
    Dim conn As OleDb.OleDbConnection
    Dim da As OleDb.OleDbDataAdapter
    Dim cmd As OleDb.OleDbCommand
    Private Sub clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clear.Click
        supplierName.Text = ""
        phone.Text = ""
        eMail.Text = ""
    End Sub

    Private Sub phone_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles phone.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MessageBox.Show("Phone must be in Numbers.", "Store Wise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub save_Click(sender As Object, e As EventArgs) Handles save.Click
        'Adding Supplier
        If (supplierName.Text.Trim = "" Or phone.Text.Trim = "" Or eMail.Text.Trim = "") Then
            MessageBox.Show("All fields are required", "Store Wise", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf ((eMail.Text.Trim.EndsWith(".com") = False) Or (eMail.Text.Trim.Contains("@") = False)) Then
            MessageBox.Show("Invalid Email", "Store Wise", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            conn = New OleDb.OleDbConnection
            conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Saksham\Documents\StoreWise.accdb"
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            Dim sql As String = "insert into supplierTable (sName, sPhone, sEMail, sBalance) values('" & supplierName.Text.Trim & "','" & CInt(phone.Text.Trim) & "','" & eMail.Text.Trim & "'," & 0 & ")"
            cmd = New OleDb.OleDbCommand(sql, conn)
            If cmd.ExecuteNonQuery() <> 0 Then
                    MessageBox.Show("Supplier Added Successfully", "Store Wise", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    supplierName.Text = ""
                    phone.Text = ""
                    eMail.Text = ""
                End If
                conn.Close()
        End If
    End Sub

    Private Sub eMail_KeyPress(sender As Object, e As KeyPressEventArgs) Handles eMail.KeyPress
        If e.KeyChar = "@"c AndAlso eMail.Text.Contains("@") Then
            e.Handled = True
            MessageBox.Show("Only one @ is allowed.", "Store Wise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub addSupplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'setting up dark mode
        If (DMode) Then
            Me.BackColor = Color.FromArgb(255, 13, 17, 23)
            For i = 1 To 4
                Dim lbl As Label = Me.Controls("Label" & i)
                lbl.ForeColor = Color.FromArgb(255, 240, 246, 252)
            Next
            save.BackColor = Color.FromArgb(255, 31, 111, 235)
            save.BackColor = Color.FromArgb(255, 31, 111, 235)
            cancle.BackColor = Color.FromArgb(255, 31, 111, 235)
            cancle.BackColor = Color.FromArgb(255, 31, 111, 235)
            cancle.BackColor = Color.FromArgb(255, 31, 111, 235)
            clear.BackColor = Color.FromArgb(255, 31, 111, 235)
            clear.BackColor = Color.FromArgb(255, 31, 111, 235)
            supplierName.BackColor = Color.FromArgb(255, 33, 40, 48)
            supplierName.ForeColor = Color.FromArgb(255, 240, 246, 252)
            phone.BackColor = Color.FromArgb(255, 33, 40, 48)
            phone.ForeColor = Color.FromArgb(255, 240, 246, 252)
            eMail.BackColor = Color.FromArgb(255, 33, 40, 48)
            eMail.ForeColor = Color.FromArgb(255, 240, 246, 252)
        End If
    End Sub

    Private Sub supplierName_TextChanged(sender As Object, e As EventArgs) Handles supplierName.TextChanged

    End Sub

    Private Sub eMail_TextChanged(sender As Object, e As EventArgs) Handles eMail.TextChanged

    End Sub
End Class