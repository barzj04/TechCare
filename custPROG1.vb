Public Class custPROG1

    Public Property LoggedInUser As String
    Public Sub New(Email As String)
        InitializeComponent()
        LoggedInUser = Email
    End Sub
    Private Sub GunaPanel1_Paint(sender As Object, e As PaintEventArgs) Handles GunaPanel1.Paint

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim program3 As New custPROG3(LoggedInUser)
        program3.Show()

        Me.Hide()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim program2 As New custPROG2(LoggedInUser)
        program2.Show()

        Me.Hide()
    End Sub

    Private Sub GunaPictureBox9_Click(sender As Object, e As EventArgs) Handles GunaPictureBox9.Click

    End Sub

    Private Sub GunaPictureBox10_Click(sender As Object, e As EventArgs) Handles GunaPictureBox10.Click

    End Sub

    Private Sub GunaPictureBox11_Click(sender As Object, e As EventArgs) Handles GunaPictureBox11.Click

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim customerfaq As New custFAQ(LoggedInUser)
        customerfaq.Show()
        Me.Hide()
    End Sub

    Private Sub GunaPictureBox5_Click(sender As Object, e As EventArgs) Handles GunaPictureBox5.Click
        Dim custaboutus As New custABOUT(LoggedInUser)
        custaboutus.Show()
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim customerpharmacy As New customerpharmacy(LoggedInUser)
        customerpharmacy.Show()
        Me.Hide()
    End Sub
End Class