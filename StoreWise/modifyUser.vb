Public Class modifyUser
    Private dbuName = ""
    Private dbpass = ""

    'Database Variables
    Dim conn As OleDb.OleDbConnection
    Dim da As OleDb.OleDbDataAdapter
    Dim ds As DataSet
    Dim cmd As OleDb.OleDbCommand
    Dim dt As DataTable

    Private Sub modifyUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'setting up connection
        conn = New OleDb.OleDbConnection
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Saksham\Documents\StoreWise.accdb"
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        'fetching user name, pass, dark mode from database
        Dim sql As String = "select * from userTable"
        da = New OleDb.OleDbDataAdapter(sql, conn)
        ds = New DataSet
        da.Fill(ds, "userTable")
        dt = ds.Tables("userTable")

        'assigning fetched values to variables
        dbuName = dt.Rows(0).Item(0)
        dbpass = dt.Rows(0).Item(1)
        DMode = dt.Rows(0).Item(2)

        'closing connection
        conn.Close()


        'Dark Mode logic
        If (DMode) Then
            Me.BackColor = Color.FromArgb(255, 13, 17, 23)
            For i = 1 To 5
                Dim lbl As Label = Me.Controls("Label" & i)
                lbl.ForeColor = Color.FromArgb(255, 240, 246, 252)
            Next
            modify.BackColor = Color.FromArgb(255, 31, 111, 235)
            modify.BackColor = Color.FromArgb(255, 31, 111, 235)
            cancle.BackColor = Color.FromArgb(255, 31, 111, 235)
            cancle.BackColor = Color.FromArgb(255, 31, 111, 235)
            OuName.BackColor = Color.FromArgb(255, 33, 40, 48)
            OuName.ForeColor = Color.FromArgb(255, 240, 246, 252)
            oPass.BackColor = Color.FromArgb(255, 33, 40, 48)
            oPass.ForeColor = Color.FromArgb(255, 240, 246, 252)
            nPass.BackColor = Color.FromArgb(255, 33, 40, 48)
            nPass.ForeColor = Color.FromArgb(255, 240, 246, 252)
            cPass.BackColor = Color.FromArgb(255, 33, 40, 48)
            cPass.ForeColor = Color.FromArgb(255, 240, 246, 252)
        End If
    End Sub

    Private Sub modify_Click(sender As Object, e As EventArgs) Handles modify.Click
        Dim oeUname As String = OuName.Text.Trim
        Dim oepass As String = oPass.Text.Trim
        Dim nepass As String = nPass.Text.Trim
        Dim cepass As String = cPass.Text.Trim
        If (oeUname = "" Or oepass = "" Or nepass = "" Or cepass = "") Then
            MessageBox.Show("All fields are required", "Store Wise", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf (oeUname <> dbuName Or oepass <> dbpass) Then
            MessageBox.Show("Old Password or Username Doesn't Match", "Store Wise", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf (nepass <> cepass) Then
            MessageBox.Show("Old Password and New Password Doesn't Match", "Store Wise", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf (IsValidPassword(nepass)) Then
            conn = New OleDb.OleDbConnection
            conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Saksham\Documents\StoreWise.accdb"
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            Dim sql As String = "update userTable set password = '" & nepass & "', username = '" & oeUname & "' where uName = '" & oeUname & "'"
            MessageBox.Show("User Updated Successfully", "Store Wise", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Password is weak", "Store Wise", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    'Password Validation Logic
    Function IsValidPassword(password As String) As Boolean
        If password.Length < 8 Then Return False

        Dim hasLower As Boolean = False
        Dim hasUpper As Boolean = False
        Dim hasSpecial As Boolean = False
        Dim specialChars As String = "@$#&"

        For Each ch As Char In password
            If Char.IsLower(ch) Then
                hasLower = True
            ElseIf Char.IsUpper(ch) Then
                hasUpper = True
            ElseIf specialChars.Contains(ch) Then
                hasSpecial = True
            End If

            If hasLower AndAlso hasUpper AndAlso hasSpecial Then
                Return True
            End If
        Next
        Return False
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show("Password should contain" & vbNewLine & "Minimum 8 Characters" & vbNewLine & "1 Lower Case Character" & vbNewLine & "1 Upper Case Character" & vbNewLine & "1 Special Symbol from (@,$,#,&)", "Store Wise", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class