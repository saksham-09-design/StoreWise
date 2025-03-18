Imports System.ComponentModel.DataAnnotations

Public Class modifyPrintDetails
    Dim firmName As String = ""
    Private Sub modifyPrintDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim con As New OleDb.OleDbConnection
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Saksham\Documents\StoreWise.accdb"
        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            Dim sql As String = "select * from billFormat"
            Dim da As New OleDb.OleDbDataAdapter(sql, con)
            Dim dt As New DataTable
            da.Fill(dt)
            firmName = CStr(dt.Rows(0).Item(0))
            fName.Text = CStr(dt.Rows(0).Item(0))
            phone.Text = CStr(dt.Rows(0).Item(1))
            mail.Text = CStr(dt.Rows(0).Item(2))
            add.Text = CStr(dt.Rows(0).Item(3))
            t1.Text = CStr(dt.Rows(0).Item(4))
            t2.Text = CStr(dt.Rows(0).Item(5))
            t3.Text = CStr(dt.Rows(0).Item(6))
            t4.Text = CStr(dt.Rows(0).Item(7))
        Catch ex As Exception
            MessageBox.Show("Error " & ex.ToString, "Storewise", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try

        'setting up dark mode
        If DMode Then
            Me.BackColor = Color.FromArgb(255, 13, 17, 23)
            For i = 1 To 6
                Dim lbl As Label = Me.Controls("Label" & i)
                lbl.ForeColor = Color.FromArgb(255, 240, 246, 252)
            Next
            phone.BackColor = Color.FromArgb(255, 13, 17, 23)
            phone.ForeColor = Color.FromArgb(255, 240, 246, 252)
            mail.BackColor = Color.FromArgb(255, 13, 17, 23)
            mail.ForeColor = Color.FromArgb(255, 240, 246, 252)
            add.BackColor = Color.FromArgb(255, 13, 17, 23)
            add.ForeColor = Color.FromArgb(255, 240, 246, 252)
            fName.BackColor = Color.FromArgb(255, 13, 17, 23)
            fName.ForeColor = Color.FromArgb(255, 240, 246, 252)
            t1.BackColor = Color.FromArgb(255, 13, 17, 23)
            t1.ForeColor = Color.FromArgb(255, 240, 246, 252)
            t2.BackColor = Color.FromArgb(255, 13, 17, 23)
            t2.ForeColor = Color.FromArgb(255, 240, 246, 252)
            t3.BackColor = Color.FromArgb(255, 13, 17, 23)
            t3.ForeColor = Color.FromArgb(255, 240, 246, 252)
            t4.BackColor = Color.FromArgb(255, 13, 17, 23)
            t4.ForeColor = Color.FromArgb(255, 240, 246, 252)
            sFormat.BackColor = Color.FromArgb(255, 31, 111, 235)
            sFormat.ForeColor = Color.FromArgb(255, Color.White)
            cancle.BackColor = Color.FromArgb(255, 31, 111, 235)
            cancle.ForeColor = Color.FromArgb(255, Color.White)
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

    Private Sub sFormat_Click(sender As Object, e As EventArgs) Handles sFormat.Click
        If (fName.Text.Trim = "" Or phone.Text.Trim = "" Or mail.Text.Trim = "" Or add.Text.Trim = "" Or t1.Text.Trim = "" Or t2.Text.Trim = "" Or t3.Text.Trim = "" Or t4.Text.Trim = "") Then
            MessageBox.Show("Please Fill All Details!", "Store Wise", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf ((mail.Text.Trim.EndsWith(".com") = False) Or (mail.Text.Trim.Contains("@") = False)) Then
            MessageBox.Show("Invalid Email", "Store Wise", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim con As New OleDb.OleDbConnection
            con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Saksham\Documents\StoreWise.accdb"
            'modifing bill info in database
            Try
                If con.State = ConnectionState.Closed Then
                    con.Open()
                End If
                Dim sql = "Update billFormat set fName = '" & fName.Text.Trim & "', phone = '" & phone.Text.Trim & "', eMail = '" & mail.Text.Trim & "', [add] = '" & add.Text.Trim & "', t1 = '" & t1.Text.Trim & "', t2 = '" & t2.Text.Trim & "', t3 = '" & t3.Text.Trim & "', t4 = '" & t4.Text.Trim & "' where fName = '" & firmName & "'"
                Dim cmd As New OleDb.OleDbCommand(sql, con)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Format Modified Successfully!", "Store Wise", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Error:" & ex.ToString(), "Store Wise", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                con.Close()
            End Try
        End If
    End Sub
End Class