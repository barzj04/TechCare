Imports System.Data.OleDb
Imports System.Net
Imports System.Net.Mail
Imports System.Text.RegularExpressions
Imports Guna.UI.WinForms

Public Class custFORGETPASS
    Dim randomCode As String
    Public Shared toUser As String
    Dim conn As New OleDbConnection
    Dim cmd As OleDbCommand


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If (txtCode.Text.Equals(randomCode)) Then
            toUser = txtEmailG.Text
            Dim query As String = "UPDATE GuestData SET Password = @Password"
            conn.Open()
            Dim cmd As New OleDbCommand(query, conn)
            cmd.Parameters.AddWithValue("@Password", txtNewPassword.Text)
            conn.Close()
        Else
            MessageBox.Show("Wrong Code")
        End If
    End Sub

    Private Sub GunaLinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles btnSendCode.LinkClicked
        Dim from, pass, messageBody As String
        Dim rand As Random = New Random()
        randomCode = (rand.Next(999999)).ToString()
        Dim message As MailMessage = New MailMessage()
        toUser = txtEmailG.Text
        from = "taufiqifwat106@gmail.com" ' Replace with your email address
        pass = "040610110335*$Ta"  ' Replace with your email password
        messageBody = "Your reset code is " + randomCode
        message.To.Add(toUser)
        message.From = New MailAddress(from)
        message.Body = messageBody
        message.Subject = "Password resetting code"
        Dim smtp As SmtpClient = New SmtpClient("smtp.gmail.com")
        smtp.EnableSsl = True
        smtp.Port = 587
        smtp.DeliveryMethod = SmtpDeliveryMethod.Network
        smtp.Credentials = New NetworkCredential(from, pass)
        smtp.UseDefaultCredentials = False ' Add this line
        Try
            smtp.Send(message)
            MessageBox.Show("Please check your email and enter the code in the enter code textbox")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub custFORGETPASS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\LENOVO\Documents\LoginDatabase.accdb"
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
        End
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim loginForm As New customerlogin(txtEmailG.Text.Trim())
        loginForm.Show()
        Me.Close()
    End Sub
End Class
