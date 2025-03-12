Imports System.Data.OleDb
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Guna.UI.WinForms

Public Class custPAY1

    Public Property LoggedInUser As String
    Public Sub New(Email As String)
        InitializeComponent()
        LoggedInUser = Email
    End Sub
    Public Property GrandTotal As Double
    Public Property Amount As String
    Public Property tax As String
    Dim conn As New OleDbConnection
    Dim cmd As OleDbCommand
    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\LENOVO\Documents\LoginDatabase.accdb"
        conn.Open()
        cmd = conn.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "INSERT INTO GuestData(CardHolderName,Cardnumber,CardDate,CardCCV)values('" + GunaTextBox1.Text + "','" + GunaTextBox2.Text + "','" + GunaTextBox3.Text + "','" + GunaTextBox4.Text + "')"
        cmd.ExecuteNonQuery()
        conn.Close()
        MessageBox.Show("record saved")


        Dim pay2 As New custPAY2(LoggedInUser)
        pay2.Amount = GunaLabel14.Text
        pay2.Show()

        Me.Hide()
    End Sub

    Private Sub custPAY1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim total As New custPAY2(LoggedInUser, Amount)
        total.grandtotal = GunaLabel14.Text
        GunaLabel12.Text = GrandTotal.ToString("0.00")
        GunaLabel13.Text = (GrandTotal * 0.06).ToString("0.00")
        GunaLabel14.Text = (GrandTotal + (GrandTotal * 0.06) + 5).ToString("0.00")
    End Sub

    Private Sub GunaLabel12_Click(sender As Object, e As EventArgs) Handles GunaLabel12.Click

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim customerfaq As New custFAQ(LoggedInUser)
        customerfaq.Show()
        Me.Hide()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim custaboutus As New custABOUT(LoggedInUser)
        custaboutus.Show()
        Me.Hide()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim custprog As New custPROG1(LoggedInUser)
        custprog.Show()
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
End Class