Public Class CHOOSEFIRST

    Private Property LoggedInUser As String

    Private Sub picGuest_Click(sender As Object, e As EventArgs) Handles picGuest.Click, lblGuestLog.Click
        ' Handle click event for Guest login option

        ' Create a new instance of the customerlogin form
        Dim logincust As New customerlogin(LoggedInUser)

        ' Show the customerlogin form
        logincust.Show()

        ' Hide the current form (CHOOSEFIRST)
        Me.Hide()
    End Sub

    Private Sub picDoc_Click(sender As Object, e As EventArgs) Handles picDoc.Click, lblDocLog.Click
        ' Handle click event for Doctor login option

        ' Create a new instance of the docLogin form
        Dim logindoctor As New docLogin(LoggedInUser)

        ' Show the docLogin form
        logindoctor.Show()

        ' Hide the current form (CHOOSEFIRST)
        Me.Hide()
    End Sub

    Private Sub picAdmin_Click(sender As Object, e As EventArgs) Handles picAdmin.Click, lblAdminLog.Click
        ' Handle click event for Pharmacist login option

        ' Create a new instance of the login form
        Dim sellerlogin As New login(LoggedInUser)

        ' Show the login form
        sellerlogin.Show()

        ' Hide the current form (CHOOSEFIRST)
        Me.Hide()
    End Sub

    Private Sub picPhar_Click(sender As Object, e As EventArgs) Handles picPhar.Click, lblPharLog.Click
        ' Handle click event for Admin login option

        ' Create a new instance of the sellerlogin form
        Dim logins As New sellerlogin

        ' Show the sellerlogin form
        logins.Show()

        ' Hide the current form (CHOOSEFIRST)
        Me.Hide()
    End Sub

    Private Sub GunaPictureBox9_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        ' Handle click event for the Close button

        ' Close the current form (CHOOSEFIRST)
        Me.Close()
    End Sub

End Class