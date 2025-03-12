Imports Guna.UI.WinForms

Public Class custTRACKER
    Public Property LoggedInUser As String
    Public Sub New(Email As String)
        InitializeComponent()
        LoggedInUser = Email
    End Sub
    Private Sub custTRACKER_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim customerpharmacy As New customerpharmacy(LoggedInUser)
        customerpharmacy.Show()
        Me.Hide()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click

        ' Retrieve the input from TextBox1
        Dim time As String = ComboBox1.SelectedItem.ToString()
        Dim ubat As String = TextBox1.Text

        ' Retrieve the selected time from ComboBox1


        If ComboBox1.SelectedItem Is Nothing Then
            MessageBox.Show("Please select a time.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If TextBox1.Text.Trim() = "" Then
            MessageBox.Show("Please enter the medication.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If



        If time = "7.00" Then
            Label22.Text = ubat
        ElseIf time = "8.00" Then
            Label23.Text = ubat
        ElseIf time = "9.00" Then
            Label24.Text = ubat
        ElseIf time = "10.00" Then
            Label25.Text = ubat
        ElseIf time = "11.00" Then
            Label26.Text = ubat
        ElseIf time = "12.00" Then
            Label27.Text = ubat
        ElseIf time = "13.00" Then
            Label28.Text = ubat
        ElseIf time = "14.00" Then
            Label29.Text = ubat
        ElseIf time = "15.00" Then
            Label30.Text = ubat
        ElseIf time = "16.00" Then
            Label31.Text = ubat
        ElseIf time = "17.00" Then
            Label32.Text = ubat
        ElseIf time = "18.00" Then
            Label33.Text = ubat
        ElseIf time = "19.00" Then
            Label34.Text = ubat
        ElseIf time = "20.00" Then
            Label35.Text = ubat
        ElseIf time = "21.00" Then
            Label36.Text = ubat
        ElseIf time = "22.00" Then
            Label37.Text = ubat
        ElseIf time = "23.00" Then
            Label38.Text = ubat
        ElseIf time = "00.00" Then
            Label39.Text = ubat
        End If


    End Sub


End Class