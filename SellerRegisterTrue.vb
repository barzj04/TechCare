Imports System.Data.OleDb
Imports System.Net.Security
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button

Public Class SellerRegisterTrue
    Dim filePath1 As String = ""
    Dim filePath2 As String = ""
    Dim conn As New OleDbConnection
    Dim cmd As OleDbCommand
    Public Property LoggedInUser As String

    Public Sub New(SellerEmail As String)
        InitializeComponent()
        LoggedInUser = SellerEmail
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        conn.Open()
        cmd = conn.CreateCommand()
        cmd.CommandType = CommandType.Text

        Dim Age As String = CStr(NumericUpDown1.Value)

        Dim gender As String = ""
        If RadioButton1.Checked = True Then
            gender = "Female"
        ElseIf RadioButton2.Checked = True Then
            gender = "Male"
        End If

        Try
            Dim fileData1 As Byte() = File.ReadAllBytes(filePath1)
            Dim fileData2 As Byte() = File.ReadAllBytes(filePath2)
            cmd.CommandText = "INSERT INTO Seller(SellerName,SellerEmail,[SellerPassword],SellerIC,SellerPhone,SellerPharmacy,SellerGender,SellerAge,SellerCert,SellerCertData,SellerLicense,SellerLicenseData )values ('" + TextBox1.Text + "','" + MaskedTextBox1.Text + "','" + TextBox2.Text + "','" + MaskedTextBox2.Text + "','" + TextBox3.Text + "','" + MaskedTextBox3.Text + "','" + gender + "' ,'" + Age + "',@SellerCert, @SellerCertData,@SellerLicense, @SellerLicenseData ,@Verification)"

            cmd.Parameters.AddWithValue("@SellerCert", Path.GetFileName(filePath1))
            cmd.Parameters.AddWithValue("@SellerCertData", OleDbType.VarBinary).Value = fileData1
            cmd.Parameters.AddWithValue("@SellerLicense", Path.GetFileName(filePath2))
            cmd.Parameters.AddWithValue("@SellerLicenseData", OleDbType.VarBinary).Value = fileData2
            cmd.Parameters.AddWithValue("@SellerGender", gender)
            cmd.Parameters.AddWithValue("@SellerAge", Age)
            cmd.Parameters.AddWithValue("@Verification", False)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Record added successfully! Please wait for verification.")

            Dim loginForm As New sellerlogin()
            loginForm.Show()
            Me.Hide()
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub ListBox1_Click(sender As Object, e As EventArgs) Handles ListBox1.Click
        Dim openFileDialog1 As New OpenFileDialog()
        openFileDialog1.Title = "Select File"
        openFileDialog1.Filter = "All Files (*.*)|*.*"

        If openFileDialog1.ShowDialog() = DialogResult.OK Then
            filePath1 = openFileDialog1.FileName
            MessageBox.Show("File selected and stored.")
        End If
    End Sub

    Private Sub ListBox2_Click(sender As Object, e As EventArgs) Handles ListBox2.Click
        Dim openFileDialog2 As New OpenFileDialog()
        openFileDialog2.Title = "Select File"
        openFileDialog2.Filter = "All Files (*.*)|*.*"

        If openFileDialog2.ShowDialog() = DialogResult.OK Then
            filePath2 = openFileDialog2.FileName
            MessageBox.Show("File selected and stored.")
        End If
    End Sub

    Private Sub SellerRegisterTrue_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\LENOVO\Documents\LoginDatabase.accdb"
    End Sub
End Class
