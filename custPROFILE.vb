Imports System.Data.OleDb

Public Class custPROFILE

    Dim conn As New OleDbConnection
    Dim cmd As OleDbCommand

    Public Property LoggedInUser As String
    Public Sub New(Email As String)
        InitializeComponent()
        LoggedInUser = Email
    End Sub
    Private Sub custPROFILE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\LENOVO\Documents\LoginDatabase.accdb"

        Dim query As String = "SELECT * FROM GuestData WHERE Email = @Email"
        Try
            conn.Open()
            Dim cmd As New OleDbCommand(query, conn)
            cmd.Parameters.AddWithValue("@Email", loggedInUser)

            Dim reader As OleDbDataReader = cmd.ExecuteReader()
            If reader.Read() Then
                TextBox1.Text = reader("GuestName").ToString()
                TextBox2.Text = reader("Gender").ToString()
                TextBox3.Text = reader("Age").ToString()
                TextBox4.Text = reader("Address").ToString()
            End If
            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error occurred while retrieving user information: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub GunaPanel3_Paint(sender As Object, e As PaintEventArgs) Handles GunaPanel3.Paint

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim customerfaq As New custFAQ(LoggedInUser)
        customerfaq.Show()
        Me.Hide()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim custaboutus As New custABOUT(LoggedInUser)
        custaboutus.Show()
        Me.Hide()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim custprog As New custPROG1(LoggedInUser)
        custprog.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim customertracker As New custTRACKER(LoggedInUser)
        customertracker.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim customerappointment As New custAPPOINTMENT(LoggedInUser)
        customerappointment.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim customerpharmacy As New customerpharmacy(LoggedInUser)
        customerpharmacy.Show()
        Me.Hide()
    End Sub
End Class