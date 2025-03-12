Imports System.Data.OleDb
Imports System.Net.Security
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.IO

Public Class docregister
    Dim filePath1 As String = ""
    Dim filePath2 As String = ""
    Dim conn As New OleDbConnection
    Dim cmd As OleDbCommand
    Private Sub docregister_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\LENOVO\Documents\LoginDatabase.accdb"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        conn.Open()
        cmd = conn.CreateCommand()
        cmd.CommandType = CommandType.Text


        Dim age As String = CStr(NumericUpDown1.Value)

        Dim gender As String = ""
        If RadioButton1.Checked = True Then
            gender = "Female"
        ElseIf RadioButton2.Checked = True Then
            gender = "Male"
        End If

        Try

            Dim fileData1 As Byte() = File.ReadAllBytes(filePath1)
            Dim fileData2 As Byte() = File.ReadAllBytes(filePath2)
            cmd.CommandText = "INSERT INTO DoctorData(DoctorName,DoctorEmail,[DoctorPassword],DoctorIC,DoctorPhone,DoctorPharmacy,DoctorGender,DoctorAge,DoctorCert,DoctorCertData,DoctorLicense,DoctorLicenseData )values ('" + TextBox1.Text + "','" + MaskedTextBox1.Text + "','" + TextBox2.Text + "','" + MaskedTextBox2.Text + "','" + TextBox3.Text + "','" + MaskedTextBox3.Text + "','" + gender + "','" + age + "',@DoctorCert, @DoctorCertData,@DoctorLicense, @DoctorLicenseData )"
            cmd.Parameters.AddWithValue("@DoctorGender", gender)
            cmd.Parameters.AddWithValue("@DoctorAge", age)
            cmd.Parameters.AddWithValue("@DoctorCert", Path.GetFileName(filePath1))
            cmd.Parameters.AddWithValue("@DoctorLicense", Path.GetFileName(filePath2))
            cmd.Parameters.AddWithValue("@DoctorCertData", fileData1)
            cmd.Parameters.AddWithValue("@DoctorLicenseData", fileData2)
            cmd.ExecuteNonQuery()
            MessageBox.Show("record added successfully!")
        Finally
            conn.Close()
        End Try


    End Sub

    Private Sub ListBox1_click(sender As Object, e As EventArgs) Handles ListBox1.Click

        Dim openFileDialog1 As New OpenFileDialog()
        openFileDialog1.Title = "Select File"
        openFileDialog1.Filter = "All Files (*.*)|*.*"

        If openFileDialog1.ShowDialog() = DialogResult.OK Then
            filePath1 = openFileDialog1.FileName
            MessageBox.Show("File selected and stored.")
        End If

    End Sub

    Private Sub ListBox2_CLICK(sender As Object, e As EventArgs) Handles ListBox2.Click
        Dim openFileDialog2 As New OpenFileDialog()
        openFileDialog2.Title = "Select File"
        OpenFileDialog2.Filter = "All Files (*.*)|*.*"

        If openFileDialog2.ShowDialog() = DialogResult.OK Then
            filePath2 = openFileDialog2.FileName
            MessageBox.Show("File selected and stored.")
        End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged

    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged

    End Sub
End Class