Imports System.ComponentModel
Imports System.Data.OleDb
Imports System.Net.Security
Imports System.Text.RegularExpressions
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class customerregister
    Dim conn As New OleDbConnection
    Dim cmd As OleDbCommand
    Private Sub customerregister_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.16.0;Data Source=C:\Users\arlee\Downloads\LoginDatabase.accdb"
        maskIC.Mask = "000000-00-0000"
        maskIC.PromptChar = " "
        maskIC.ValidatingType = GetType(String)
        txtEmail.Text = "example@example.com"
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\LENOVO\Documents\LoginDatabase.accdb"
    End Sub
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
        End
    End Sub

    Private Sub btnRegC_Click(sender As Object, e As EventArgs) Handles btnRegC.Click
        If String.IsNullOrWhiteSpace(txtName.Text) OrElse
        String.IsNullOrWhiteSpace(txtEmail.Text) OrElse
        String.IsNullOrWhiteSpace(maskPasswordCu.Text) OrElse
        String.IsNullOrWhiteSpace(maskIC.Text) OrElse
        String.IsNullOrWhiteSpace(txtPhoneNo.Text) OrElse
        String.IsNullOrWhiteSpace(maskAddress.Text) OrElse
        (Not rboFemale.Checked AndAlso Not rboMale.Checked) OrElse
        numAge.Value = 0 Then
            MessageBox.Show("Please fill in all the required fields.", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return ' Exit the method without proceeding further
        End If

        Using conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\LENOVO\Documents\LoginDatabase.accdb")
            conn.Open()

            Dim gender As String = ""
            If rboFemale.Checked Then
                gender = "Female"
            ElseIf rboMale.Checked Then
                gender = "Male"
            End If

            Dim Age As Integer = CInt(numAge.Value)

            Dim cmd As New OleDbCommand("INSERT INTO GuestData (GuestName, Email, [Password], IC, Phone, Address, Gender, Age) VALUES (?, ?, ?, ?, ?, ?, ?, ?)", conn)
            cmd.Parameters.AddWithValue("@GuestName", txtName.Text)
            cmd.Parameters.AddWithValue("@Email", txtEmail.Text)
            cmd.Parameters.AddWithValue("@Password", maskPasswordCu.Text)
            cmd.Parameters.AddWithValue("@IC", maskIC.Text)
            cmd.Parameters.AddWithValue("@Phone", txtPhoneNo.Text)
            cmd.Parameters.AddWithValue("@Address", maskAddress.Text)
            cmd.Parameters.AddWithValue("@Gender", gender)
            cmd.Parameters.AddWithValue("@Age", Age)

            cmd.ExecuteNonQuery()
        End Using

        MessageBox.Show("Record saved")
    End Sub


    Private Sub picBack_Click(sender As Object, e As EventArgs) Handles picBack.Click
        Dim chooseFirstForm As New CHOOSEFIRST()
        chooseFirstForm.Show()
        Me.Hide()
    End Sub

    Private Sub maskIC_Validating(sender As Object, e As CancelEventArgs) Handles maskIC.Validating
        Dim icNumber As String = maskIC.Text.Replace("-", "")

        ' Check if the IC number length is not equal to 12 (excluding the dashes)
        If icNumber.Length <> 12 Then
            MessageBox.Show("Invalid IC number. Please enter a valid 12-digit IC number in the format '000000-00-0000'.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            e.Cancel = True ' Cancel the event to keep the focus on the TextBox
        End If
    End Sub


    Private Sub txtEmail_Validating(sender As Object, e As CancelEventArgs) Handles txtEmail.Validating
        Dim email As String = txtEmail.Text

        ' Define the regular expression pattern for email validation
        Dim pattern As String = "^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$"

        ' Check if the email address matches the pattern
        If Not Regex.IsMatch(email, pattern) Then
            MessageBox.Show("Invalid email address. Please enter a valid email address.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            e.Cancel = True ' Cancel the event to keep the focus on the TextBox
        End If
    End Sub
End Class
