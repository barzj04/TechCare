Public Class kpi
    Public Property LoggedInUser As String
    Public Sub New(AdminEmail As String)
        InitializeComponent()
        LoggedInUser = AdminEmail

    End Sub
    Private Sub kpi_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim partner As New partner(LoggedInUser)
        partner.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim info As New infoadmin(LoggedInUser)
        info.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim faq As New faq(LoggedInUser)
        faq.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim prof As New profile(LoggedInUser)
        prof.Show()
        Me.Hide()
    End Sub
End Class