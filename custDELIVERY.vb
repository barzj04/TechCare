Imports System.Collections.ObjectModel
Imports System.Data.OleDb
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Guna.UI.WinForms

Public Class custDELIVERY

    Dim conn As New OleDbConnection
    Dim cmd As OleDbCommand
    Public Property LoggedInUser As String
    Public Sub New(Email As String)
        InitializeComponent()
        LoggedInUser = Email
    End Sub
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click

        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\LENOVO\Documents\LoginDatabase.accdb"
        conn.Open()
        cmd = conn.CreateCommand()
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "UPDATE GuestData SET Phone = '" + GunaTextBox2.Text + "', Address = '" + GunaTextBox4.Text + "', State = '" + GunaTextBox3.Text + "', Postal_Code = '" + GunaTextBox5.Text + "' , GuestName = '" + GunaTextBox1.Text + "' WHERE Email = '" + LoggedInUser + "'"

        cmd.ExecuteNonQuery()
        conn.Close()
        MessageBox.Show("record saved")
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim customerpay As New custPAY1(LoggedInUser)
        customerpay.Show()
        Me.Hide()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        GunaTextBox1.Text = ""
        GunaTextBox2.Text = ""
        GunaTextBox3.Text = ""
        GunaTextBox4.Text = ""
        GunaTextBox5.Text = ""
    End Sub

    Private Sub custDELIVERY_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\LENOVO\Documents\LoginDatabase.accdb"

        Dim query As String = "SELECT * FROM GuestData WHERE GuestName = @GuestName"
        Try
            conn.Open()
            Dim cmd As New OleDbCommand(query, conn)
            cmd.Parameters.AddWithValue("@GuestName", loggedInUser)

            Dim reader As OleDbDataReader = cmd.ExecuteReader()
            If reader.HasRows Then
                reader.Read()
                GunaTextBox1.Text = reader("GuestName").ToString()
                GunaTextBox2.Text = reader("Phone").ToString()
                GunaTextBox4.Text = reader("Address").ToString()
                GunaTextBox3.Text = reader("State").ToString()
                GunaTextBox5.Text = reader("Postal_Code").ToString()
            Else
                GunaTextBox1.Text = ""
                GunaTextBox2.Text = ""
                GunaTextBox3.Text = ""
                GunaTextBox4.Text = ""
                GunaTextBox5.Text = ""
            End If
            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error occurred while retrieving user information: " & ex.Message)
        Finally
            conn.Close()
        End Try
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

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim customerprofile As New custPROFILE(LoggedInUser)
        customerprofile.Show()
        Me.Hide()
    End Sub
End Class