
Imports System.Collections.ObjectModel
Imports System.Data.OleDb
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class customerlogin
    Dim conn As New OleDbConnection
    Public Property LoggedInUser As String
    Public Sub New(Email As String)
        InitializeComponent()
        LoggedInUser = Email
    End Sub

    Private Sub customerlogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\LENOVO\Documents\LoginDatabase.accdb"
        maskPasswordG.PasswordChar = "*" ' Set the desired masking character
    End Sub


    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        If txtEmailG.Text = Nothing Or maskPasswordG.Text = Nothing Then
            MsgBox("Enter the credentials please")
        Else
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            Dim cmd As New OleDbCommand("select count(*) from GuestData where Email=? and Password=?", conn)
            cmd.Parameters.AddWithValue("@1", OleDbType.VarChar).Value = txtEmailG.Text
            cmd.Parameters.AddWithValue("@2", OleDbType.VarChar).Value = maskPasswordG.Text
            Dim count = Convert.ToInt32(cmd.ExecuteScalar())

            If (count > 0) Then
                MsgBox("Login success")
                Dim LoggedInUser As String = txtEmailG.Text
                Dim customerPharmacyform As New customerpharmacy(LoggedInUser)

                customerPharmacyform.Show()
                Me.Hide()
            Else
                MsgBox("Incorrect credentials")

            End If

        End If
    End Sub

    Private Sub lblRegGuest_Click(sender As Object, e As EventArgs) Handles lblRegGuest.Click
        customerregister.Show()
        Me.Hide()
    End Sub

    Private Sub lblForgPasGuest_Click(sender As Object, e As EventArgs) Handles lblForgPasGuest.Click
        custFORGETPASS.Show()
        Me.Hide()
    End Sub

    Private isPasswordMasked As Boolean = True
    Private Sub picEye_Click(sender As Object, e As EventArgs) Handles picEye.Click
        If isPasswordMasked Then
            maskPasswordG.PasswordChar = ControlChars.NullChar
            picEye.Image = My.Resources.view
        Else
            maskPasswordG.PasswordChar = "*"c
            picEye.Image = My.Resources.hide
        End If

        isPasswordMasked = Not isPasswordMasked
    End Sub

    Private Sub picClose2_Click(sender As Object, e As EventArgs) Handles picClose2.Click
        Me.Close()
        End
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        CHOOSEFIRST.Show()
        Me.Hide()
    End Sub
End Class