Imports System.Data.OleDb
Imports System.IO
Public Class sellerPROFILE
    Dim conn As New OleDbConnection
    Dim cmd As OleDbCommand
    Dim filepath1 As String = ""
    Dim filePath2 As String = ""
    'Private loggedInUser As String = ""
    Public Property LoggedInUser As String
    Public Sub New(SellerEmail As String)
        InitializeComponent()
        loggedInUser = SellerEmail
    End Sub
    Private Sub GunaLineTextBox1_TextChanged(sender As Object, e As EventArgs) Handles GunaLineTextBox1.TextChanged

    End Sub

    Private Sub sellerPROFILE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\LENOVO\Documents\LoginDatabase.accdb"

        Dim query As String = "SELECT * FROM Seller WHERE SellerEmail = @SellerEmail"
        Try
            conn.Open()
            Dim cmd As New OleDbCommand(query, conn)
            cmd.Parameters.AddWithValue("@SellerEmail", loggedInUser)

            Dim reader As OleDbDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                GunaLineTextBox1.Text = reader("SellerName").ToString()
                'GunaLineTextBox3.Text = reader("DoctorCert").ToString()
                GunaLineTextBox4.Text = reader("SellerEmail").ToString()
                'GunaLineTextBox5.Text = reader("DoctorLicense").ToString()
                GunaLineTextBox7.Text = reader("SellerPharmacy").ToString()
                GunaLineTextBox8.Text = reader("SellerPhone").ToString()
                GunaLineTextBox2.Text = reader("SellerAge").ToString()

                Dim attachmentData1 As Byte() = DirectCast(reader("SellerCertData"), Byte())

                If attachmentData1 IsNot Nothing AndAlso attachmentData1.Length > 0 Then
                    ' Convert the attachment data to a string representation for display in the TextBox
                    Dim attachmentString1 As String = Convert.ToBase64String(attachmentData1)

                    ' Set the TextBox text to the attachment string
                    GunaLineTextBox3.Text = attachmentString1
                Else
                    ' No attachment found, clear the TextBox
                    GunaLineTextBox3.Text = ""
                End If
                Dim attachmentData2 As Byte() = DirectCast(reader("SellerLicenseData"), Byte())

                If attachmentData2 IsNot Nothing AndAlso attachmentData2.Length > 0 Then
                    ' Convert the attachment data to a string representation for display in the TextBox
                    Dim attachmentString2 As String = Convert.ToBase64String(attachmentData2)

                    ' Set the TextBox text to the attachment string
                    GunaLineTextBox5.Text = attachmentString2
                Else
                    ' No attachment found, clear the TextBox
                    GunaLineTextBox5.Text = ""
                End If
            End If
            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error occurred while retrieving user information: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        GunaLineTextBox1.Text = ""
        GunaLineTextBox3.Text = ""
        GunaLineTextBox4.Text = ""
        GunaLineTextBox5.Text = ""
        GunaLineTextBox7.Text = ""
        GunaLineTextBox8.Text = ""
        GunaLineTextBox2.Text = ""
    End Sub

    Private Sub GunaLineTextBox5_click(sender As Object, e As EventArgs) Handles GunaLineTextBox5.Click
        Dim openFileDialog2 As New OpenFileDialog()
        openFileDialog2.Title = "Select File"
        openFileDialog2.Filter = "All Files (*.*)|*.*"

        If openFileDialog2.ShowDialog() = DialogResult.OK Then
            filePath2 = openFileDialog2.FileName
            MessageBox.Show("File selected and stored.")
        End If
    End Sub

    Private Sub GunaLineTextBox3_click(sender As Object, e As EventArgs) Handles GunaLineTextBox3.Click
        Dim openFileDialog1 As New OpenFileDialog()
        openFileDialog1.Title = "Select File"
        openFileDialog1.Filter = "All Files (*.*)|*.*"

        If openFileDialog1.ShowDialog() = DialogResult.OK Then
            filepath1 = openFileDialog1.FileName
            MessageBox.Show("File selected and stored.")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim sellerorderform As New sellerORDERRECEIVED(loggedInUser)
        sellerorderform.Show()

        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim selleradditem As New sellerADDITEM(LoggedInUser)
        selleradditem.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

    End Sub
End Class