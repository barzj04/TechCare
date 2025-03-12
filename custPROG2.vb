Imports System.Data.OleDb
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Guna.UI.WinForms
Public Class custPROG2
    Public Property LoggedInUser As String
    Public Sub New(Email As String)
        InitializeComponent()
        LoggedInUser = Email
    End Sub
    Dim conn As New OleDbConnection
    Dim cmd As OleDbCommand
    Private Sub custPROG2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click
        MessageBox.Show("thank you for donating")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim customerfaq As New custFAQ(LoggedInUser)
        customerfaq.Show()
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim customerpharmacy As New customerpharmacy(LoggedInUser)
        customerpharmacy.Show()
        Me.Hide()
    End Sub
End Class