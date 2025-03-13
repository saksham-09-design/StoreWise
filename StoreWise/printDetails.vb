Public Class printDetails


    Private Sub sFormat_Click(sender As Object, e As EventArgs) Handles sFormat.Click
        Dim con As New OleDb.OleDbConnection
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Saksham\Documents\StoreWise.accdb"
        Dim fBillVal As Boolean = False

        'fetching bill format state
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Try
            Dim sql As String = "select bSet from support"
            Dim da As New OleDb.OleDbDataAdapter(sql, con)
            Dim dt As New DataTable
            da.Fill(dt)
            fBillVal = CBool(dt.Rows(0).Item(0))
        Catch ex As Exception
            MessageBox.Show("Unable to fetch Bill Format", "Storewise", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try

        If fBillVal Then
            MessageBox.Show("Format already set!", "Storewise", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf (fName.Text.Trim = "" Or phone.Text.Trim = "" Or mail.Text.Trim = "" Or add.Text.Trim = "" Or t1.Text.Trim = "" Or t2.Text.Trim = "" Or t3.Text.Trim = "" Or t4.Text.Trim = "") Then
            MessageBox.Show("Please Fill All Details!", "Store Wise", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf ((mail.Text.Trim.EndsWith(".com") = False) Or (mail.Text.Trim.Contains("@") = False)) Then
            MessageBox.Show("Invalid Email", "Store Wise", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            'saving bill info in database
            Try
                If con.State = ConnectionState.Closed Then
                    con.Open()
                End If
                Dim sql = "Insert into billFormat Values('" & fName.Text.Trim & "','" & phone.Text.Trim & "','" & mail.Text.Trim & "','" & add.Text.Trim & "','" & t1.Text.Trim & "','" & t2.Text.Trim & "','" & t3.Text.Trim & "','" & t4.Text.Trim & "')"
                Dim cmd As New OleDb.OleDbCommand(sql, con)
                cmd.ExecuteNonQuery()


                'Bill format setting
                Dim sql1 = "Update support set bSet = " & True
                Dim cmd1 As New OleDb.OleDbCommand(sql1, con)
                cmd1.ExecuteNonQuery()
                MessageBox.Show("Format Saved Successfully!", "Store Wise", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Error:" & ex.ToString(), "Store Wise", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                con.Close()
            End Try
        End If
    End Sub

    Private Sub mail_KeyPress(sender As Object, e As KeyPressEventArgs) Handles mail.KeyPress
        If e.KeyChar = "@"c AndAlso mail.Text.Contains("@") Then
            e.Handled = True
            MessageBox.Show("Only one @ is allowed.", "Store Wise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub phone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles phone.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MessageBox.Show("Phone must be in Numbers.", "Store Wise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
End Class