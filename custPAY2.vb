Imports System.Text

Public Class custPAY2
    Public Property LoggedInUser As String
    Public Property grandtotal As String
    Public Property Amount As String
    Public Sub New(Email As String)
        InitializeComponent()
        LoggedInUser = Email
    End Sub

    Public Sub New(Email As String, amount As String)
        InitializeComponent()
        LoggedInUser = Email
        'GunaLabel9.Text = amount ' Set the text of GunaLabel9 to the passed "amount" value
    End Sub
    Private Sub custPAY2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        GunaLabel12.Text = DateTime.Now.ToString("MM/dd/yyyy")
        GunaLabel9.Text = Amount
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim receiptBuilder As New StringBuilder()

        ' Add the receipt header
        receiptBuilder.AppendLine("Receipt")
        receiptBuilder.AppendLine("--------------------")
        receiptBuilder.AppendLine("Date :" & GunaLabel12.Text)


        ' Add the total to the receipt
        receiptBuilder.AppendLine("--------------------")
        receiptBuilder.AppendLine("Total:" & GunaLabel9.Text)

        ' Display the receipt in a message box
        MessageBox.Show(receiptBuilder.ToString(), "Receipt")
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