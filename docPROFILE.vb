Imports System.Data.OleDb
Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class docPROFILE
    Dim conn As New OleDbConnection
    Dim cmd As OleDbCommand
    Dim filepath1 As String = ""
    Dim filePath2 As String = ""

    Public Property LoggedInUser As String
    Public Sub New(DoctorEmail As String)
        InitializeComponent()
        LoggedInUser = DoctorEmail
    End Sub
    Private Sub docPROFILE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\LENOVO\Documents\LoginDatabase.accdb"

        Dim query As String = "SELECT * FROM DoctorData WHERE DoctorEmail = @DoctorEmail"
        Try
            conn.Open()
            Dim cmd As New OleDbCommand(query, conn)
            cmd.Parameters.AddWithValue("@DoctorEmail", loggedInUser)

            Dim reader As OleDbDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                GunaLineTextBox1.Text = reader("DoctorName").ToString()
                'GunaLineTextBox3.Text = reader("DoctorCert").ToString()
                GunaLineTextBox4.Text = reader("DoctorEmail").ToString()
                'GunaLineTextBox5.Text = reader("DoctorLicense").ToString()
                GunaLineTextBox7.Text = reader("DoctorPharmacy").ToString()
                GunaLineTextBox8.Text = reader("DoctorPhone").ToString()
                GunaLineTextBox2.Text = reader("DoctorAge").ToString()

                Dim attachmentData1 As Byte() = DirectCast(reader("DoctorCertData"), Byte())

                If attachmentData1 IsNot Nothing AndAlso attachmentData1.Length > 0 Then
                    ' Convert the attachment data to a string representation for display in the TextBox
                    Dim attachmentString1 As String = Convert.ToBase64String(attachmentData1)

                    ' Set the TextBox text to the attachment string
                    GunaLineTextBox3.Text = attachmentString1
                Else
                    ' No attachment found, clear the TextBox
                    GunaLineTextBox3.Text = ""
                End If
                Dim attachmentData2 As Byte() = DirectCast(reader("DoctorLicenseData"), Byte())

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

    Private Sub GunaLineTextBox1_TextChanged(sender As Object, e As EventArgs) Handles GunaLineTextBox1.TextChanged

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

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim fileData1 As Byte() = File.ReadAllBytes(filepath1)
        Dim fileData2 As Byte() = File.ReadAllBytes(filePath2)
        Dim query As String = "UPDATE DoctorData SET DoctorEmail = @DoctorEmail, DoctorPhone = @DoctorPhone, DoctorPharmacy = @DoctorPharmacy, DoctorCert = @DoctorCert, DoctorCertData = @DoctorCertData, DoctorLicense = @DoctorLicense, DoctorLicenseData = @DoctorLicenseData WHERE DoctorName = @DoctorName"

        Try
            conn.Open()
            Dim cmd As New OleDbCommand(query, conn)
            cmd.Parameters.AddWithValue("@DoctorEmail", GunaLineTextBox4.Text)
            cmd.Parameters.AddWithValue("@DoctorName", GunaLineTextBox1.Text)
            cmd.Parameters.AddWithValue("@DoctorPhone", GunaLineTextBox8.Text)
            cmd.Parameters.AddWithValue("@DoctorPharmacy", GunaLineTextBox7.Text)
            cmd.Parameters.AddWithValue("@DoctorAge", GunaLineTextBox2.Text)
            cmd.Parameters.AddWithValue("@DoctorCert", Path.GetFileName(filepath1))
            cmd.Parameters.AddWithValue("@DoctorLicense", Path.GetFileName(filePath2))
            cmd.Parameters.AddWithValue("@DoctorCertData", fileData1)
            cmd.Parameters.AddWithValue("@DoctorLicenseData", fileData2)

            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

            If rowsAffected > 0 Then
                MessageBox.Show("Doctor information updated successfully.")
            Else
                MessageBox.Show("No rows were affected. Please check the doctor name.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error occurred while updating doctor information: " & ex.Message)
        Finally
            conn.Close()
        End Try
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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim docbook As New docBOOKING(LoggedInUser)
        docbook.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim docapp As New docAPPOINTMENT(LoggedInUser)
        docapp.Show()
        Me.Hide()
    End Sub
End Class