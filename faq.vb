Public Class faq
    Public Property LoggedInUser As String
    Public Sub New(AdminEmail As String)
        InitializeComponent()
        LoggedInUser = AdminEmail

    End Sub
    Private Sub GunaLabel5_Click(sender As Object, e As EventArgs) Handles GunaLabel5.Click

    End Sub

    Private Sub faq_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim kpi As New kpi(LoggedInUser)
        kpi.Show()
        Me.Hide()
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim prof As New profile(LoggedInUser)
        prof.Show()
        Me.Hide()
    End Sub
End Class