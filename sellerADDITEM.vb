Imports System.Data.OleDb
Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class sellerADDITEM
    Dim conn As New OleDbConnection
    Dim cmd As OleDbCommand
    Public Property LoggedInUser As String
    Public Sub New(SellerEmail As String)
        InitializeComponent()
        LoggedInUser = SellerEmail
    End Sub
    Private Sub GunaPictureBox3_Click(sender As Object, e As EventArgs) Handles GunaPictureBox3.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sellerProfile As New sellerPROFILE(LoggedInUser)
        sellerProfile.Show()

        Me.Hide()
    End Sub

    Private Sub sellerADDITEM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\LENOVO\Documents\LoginDatabase.accdb"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim sellerorderform As New sellerORDERRECEIVED(LoggedInUser)
        sellerorderform.Show()

        Me.Hide()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        conn.Open()
        cmd = conn.CreateCommand()
        cmd.CommandType = CommandType.Text
        Dim quantity As String = CStr(NumericUpDown1.Value)


        cmd.CommandText = "INSERT INTO DatabaseItem (SellerEmail, ItemName, ItemPrice, ItemStock , ItemDetails, ItemEffect) VALUES (@SellerEmail, @ItemName, @ItemPrice, @ItemStock, @ItemDetails, @ItemEffect)"
        cmd.Parameters.AddWithValue("@SellerEmail", LoggedInUser)
        cmd.Parameters.AddWithValue("@ItemName", GunaTextBox1.Text)
        cmd.Parameters.AddWithValue("@ItemPrice", GunaTextBox4.Text)
        cmd.Parameters.AddWithValue("@ItemStock", quantity)
        cmd.Parameters.AddWithValue("@ItemDetails", GunaTextBox2.Text)
        cmd.Parameters.AddWithValue("@ItemEffect", GunaTextBox3.Text)

        Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

        If rowsAffected > 0 Then
            MessageBox.Show("Record saved successfully.")
        Else
            MessageBox.Show("No records were inserted.")
        End If
        'cmd.ExecuteNonQuery()
        conn.Close()

        'MessageBox.Show("record saved")

    End Sub


End Class