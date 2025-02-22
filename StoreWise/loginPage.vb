Public Class loginPage
    Private uName = ""
    Private pass = ""

    'Database Variables
    Dim conn As OleDb.OleDbConnection
    Dim da As OleDb.OleDbDataAdapter
    Dim ds As DataSet
    Dim cmd As OleDb.OleDbCommand
    Dim dt As DataTable

    Private Sub login_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles login.Click
        Dim u_name As String
        Dim password As String
        u_name = eUName.Text.Trim
        password = eUPass.Text.Trim

        'username and password validation
        If (u_name = uName And password = pass) Then
            MessageBox.Show("Welcome " & uName, "Store Wise", MessageBoxButtons.OK, MessageBoxIcon.Information)
            MainPage.Show()
            Me.Close()
        Else
            MessageBox.Show("Invalid Username or Passowrd", "Store Wise", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub cancle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cancle.Click
        End
    End Sub

    Private Sub loginPage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        uName = dt.Rows(0).Item(0)
        pass = dt.Rows(0).Item(1)
        DMode = dt.Rows(0).Item(2)

        'closing connection
        conn.Close()

        'setting up dark mode
        If (DMode) Then
            Me.BackColor = Color.FromArgb(255, 13, 17, 23)
            For i = 1 To 3
                Dim lbl As Label = Me.Controls("Label" & i)
                lbl.ForeColor = Color.FromArgb(255, 240, 246, 252)
            Next
            login.BackColor = Color.FromArgb(255, 31, 111, 235)
            login.BackColor = Color.FromArgb(255, 31, 111, 235)
            cancle.BackColor = Color.FromArgb(255, 31, 111, 235)
            cancle.BackColor = Color.FromArgb(255, 31, 111, 235)
            eUName.BackColor = Color.FromArgb(255, 33, 40, 48)
            eUName.ForeColor = Color.FromArgb(255, 240, 246, 252)
            eUPass.BackColor = Color.FromArgb(255, 33, 40, 48)
            eUPass.ForeColor = Color.FromArgb(255, 240, 246, 252)
        End If
    End Sub
End Class