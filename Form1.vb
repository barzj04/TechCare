Imports System.Data.OleDb
Imports System.IO
Public Class profile
    Dim conn As New OleDbConnection
    Dim cmd As OleDbCommand
    Public Property LoggedInUser As String
    Public Sub New(AdminEmail As String)
        InitializeComponent()
        LoggedInUser = AdminEmail

    End Sub
    Private Sub GunaProgressBar1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim partner As New partner(LoggedInUser)
        partner.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim faq As New faq(LoggedInUser)
        faq.Show()
        Me.Hide()
    End Sub

    Private Sub profile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\LENOVO\Documents\LoginDatabase.accdb"

        Dim query As String = "SELECT * FROM Admin WHERE AdminEmail = @AdminEmail"
        Try
            conn.Open()
            Dim cmd As New OleDbCommand(query, conn)
            cmd.Parameters.AddWithValue("@AdminEmail", LoggedInUser)

            Dim reader As OleDbDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                GunaLineTextBox1.Text = reader("AdminName").ToString()
                'GunaLineTextBox3.Text = reader("DoctorCert").ToString()
                GunaLineTextBox4.Text = reader("AdminEmail").ToString()
                GunaLineTextBox5.Text = reader("AdminAddress").ToString()
                GunaLineTextBox7.Text = reader("AdminCountry").ToString()
                GunaLineTextBox8.Text = reader("AdminPhone").ToString()
                GunaLineTextBox2.Text = reader("AdminAge").ToString()
            End If
            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error occurred while retrieving user information: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub GunaLineTextBox1_TextChanged(sender As Object, e As EventArgs) Handles GunaLineTextBox1.TextChanged

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim kpi As New kpi(LoggedInUser)
        kpi.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim info As New infoadmin(LoggedInUser)
        info.Show()
        Me.Hide()
    End Sub
End Class
