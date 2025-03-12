Imports System.Data.OleDb
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class sellerlogin
    Dim conn As New OleDbConnection

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLoginS.Click
        Dim password As String = maskPasswordS.Text

        If txtEmailS.Text = Nothing Or password = Nothing Then
            MsgBox("Please enter the credentials.")
        Else
            maskPasswordS.Clear() ' Clear the MaskedTextBox after retrieving the password value

            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

            Dim cmd As New OleDbCommand("SELECT COUNT(*) FROM Seller WHERE SellerEmail=? AND SellerPassword=?", conn)
            cmd.Parameters.AddWithValue("@1", OleDbType.VarChar).Value = txtEmailS.Text
            cmd.Parameters.AddWithValue("@2", OleDbType.VarChar).Value = password

            Dim count = Convert.ToInt32(cmd.ExecuteScalar())

            If count > 0 Then
                MsgBox("Login successful")

                Dim addItemForm As New SellerRegisterTrue(txtEmailS.Text)
                addItemForm.Show()
                Me.Hide()
            Else
                MsgBox("Invalid credentials")
            End If
        End If
    End Sub

    Private Sub sellerlogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\LENOVO\Documents\LoginDatabase.accdb"
        maskPasswordS.PasswordChar = "*"
    End Sub

    Private Sub lblRegSeller_Click(sender As Object, e As EventArgs) Handles lblRegSeller.Click
        Dim sellerRegisterForm As New SellerRegisterTrue(txtEmailS.Text)
        sellerRegisterForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
        End
    End Sub

    Private isPasswordMasked As Boolean = True

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles picEye.Click
        If isPasswordMasked Then
            maskPasswordS.PasswordChar = ControlChars.NullChar
            picEye.Image = My.Resources.view
        Else
            maskPasswordS.PasswordChar = "*"c
            picEye.Image = My.Resources.hide
        End If

        isPasswordMasked = Not isPasswordMasked
    End Sub

    Private Sub lblForgPasSeller_Click(sender As Object, e As EventArgs) Handles lblForgPasSeller.Click
        Dim forgotPasswordForm As New sellerFORGORPASSWORD()
        forgotPasswordForm.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox3_Click_1(sender As Object, e As EventArgs) Handles picBack.Click
        CHOOSEFIRST.Show()
        Me.Hide()
    End Sub
End Class
