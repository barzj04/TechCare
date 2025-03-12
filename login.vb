Imports System.Data.OleDb
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class login
    Dim conn As New OleDbConnection

    Public Property LoggedInUser As String
    Public Sub New(adminEmail As String)
        InitializeComponent()
        LoggedInUser = adminEmail
    End Sub
    Private Sub GunaLabel1_Click(sender As Object, e As EventArgs) Handles GunaLabel1.Click

    End Sub

    Private Sub GunaLabel5_Click(sender As Object, e As EventArgs) Handles GunaLabel5.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If GunaTextBox1.Text = Nothing Or GunaTextBox2.Text = Nothing Then
            MsgBox("enter the credentials please")
        Else
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            Dim cmd As New OleDbCommand("select count(*) from Admin where AdminEmail=? and AdminPassword=?", conn)
            cmd.Parameters.AddWithValue("@1", OleDbType.VarChar).Value = GunaTextBox1.Text
            cmd.Parameters.AddWithValue("@2", OleDbType.VarChar).Value = GunaTextBox2.Text
            Dim count = Convert.ToInt32(cmd.ExecuteScalar())

            If (count > 0) Then
                MsgBox("login success")
                Dim loggedinuser As String = GunaTextBox1.Text
                Dim kpi As New kpi(LoggedInUser)
                kpi.Show()
                Me.Hide()
            Else
                MsgBox("check credentials")

            End If

        End If
    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\LENOVO\Documents\LoginDatabase.accdb"
    End Sub
End Class