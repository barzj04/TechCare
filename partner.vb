Imports System.Windows.Forms
Imports System.Data.OleDb
Imports Guna.UI.WinForms

Public Class partner
    Public Property LoggedInUser As String
    Public Sub New(AdminEmail As String)
        InitializeComponent()
        LoggedInUser = AdminEmail

    End Sub
    Dim conn As New OleDbConnection
    Dim cmd As OleDbCommand
    Private Sub partner_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\LENOVO\Documents\LoginDatabase.accdb"
        LoadPendingRegistrations()
    End Sub
    Private Sub LoadPendingRegistrations()
        ' Clear existing controls
        FlowLayoutPanel1.Controls.Clear()

        ' Retrieve pending seller registrations
        Dim sellerQuery As String = "SELECT SellerName, SellerPharmacy FROM Seller WHERE Verification = No"
        Dim sellerCmd As New OleDbCommand(sellerQuery, conn)
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        Dim sellerReader As OleDbDataReader = sellerCmd.ExecuteReader()

        ' Add seller registrations to FlowLayoutPanel
        While sellerReader.Read()

            Dim sellerName As String = sellerReader.GetString(0)
            Dim sellerPharmacy As String = sellerReader.GetString(1)
            'Dim sellerIC As String = sellerReader.GetString(3)

            Dim registrationPanel As New Panel()
            registrationPanel.BackColor = Color.Tan
            registrationPanel.Size = New Size(783, 156)


            Dim roleLabel As New GunaLabel()
            roleLabel.Text = "Pharmacy"
            roleLabel.BackColor = Color.Tan
            roleLabel.Location = New Point(21, 0)
            roleLabel.Size = New Size(106, 31)
            registrationPanel.Controls.Add(roleLabel)

            Dim nameLabel As New Label()
            nameLabel.Text = "Dr. " & sellerName
            nameLabel.BackColor = Color.BurlyWood
            nameLabel.Location = New Point(311, 30)
            nameLabel.AutoSize = True
            registrationPanel.Controls.Add(nameLabel)

            Dim pharmacyLabel As New Label()
            pharmacyLabel.Text = sellerPharmacy
            pharmacyLabel.BackColor = Color.BurlyWood
            pharmacyLabel.Location = New Point(299, 72)
            pharmacyLabel.AutoSize = True
            registrationPanel.Controls.Add(pharmacyLabel)

            Dim approveButton As New Button()
            approveButton.Text = "Accept"
            approveButton.Tag = sellerName
            approveButton.BackColor = Color.LawnGreen
            approveButton.Size = New Size(93, 26)
            approveButton.Location = New Point(268, 115)
            AddHandler approveButton.Click, AddressOf ApproveSellerRegistration
            registrationPanel.Controls.Add(approveButton)

            Dim declineButton As New Button()
            declineButton.Text = "Decline"
            declineButton.Tag = sellerName
            declineButton.BackColor = Color.Red
            declineButton.Size = New Size(93, 26)
            declineButton.Location = New Point(430, 115)
            AddHandler declineButton.Click, AddressOf declineSellerRegistration
            registrationPanel.Controls.Add(declineButton)

            FlowLayoutPanel1.Controls.Add(registrationPanel)
        End While

        sellerReader.Close()

        ' Retrieve pending seller registrations
        Dim DoctorQuery As String = "SELECT DoctorName, DoctorPharmacy FROM DoctorData WHERE DoctorVerification = No"
        Dim DoctorCmd As New OleDbCommand(DoctorQuery, conn)
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        Dim DoctorReader As OleDbDataReader = DoctorCmd.ExecuteReader()

        ' Add Doctor registrations to FlowLayoutPanel
        While DoctorReader.Read()

            Dim DoctorName As String = DoctorReader.GetString(0)
            Dim DoctorPharmacy As String = DoctorReader.GetString(1)


            Dim registrationPanel As New Panel()
            registrationPanel.BackColor = Color.Tan
            registrationPanel.Size = New Size(783, 156)


            Dim roleLabel As New GunaLabel()
            roleLabel.Text = "Doctor"
            roleLabel.BackColor = Color.Tan
            roleLabel.Location = New Point(21, 0)
            roleLabel.Size = New Size(106, 31)
            registrationPanel.Controls.Add(roleLabel)

            Dim nameLabel As New Label()
            nameLabel.Text = "Dr. " & DoctorName
            nameLabel.BackColor = Color.BurlyWood
            nameLabel.Location = New Point(311, 30)
            nameLabel.AutoSize = True
            registrationPanel.Controls.Add(nameLabel)

            Dim pharmacyLabel As New Label()
            pharmacyLabel.Text = DoctorPharmacy
            pharmacyLabel.BackColor = Color.BurlyWood
            pharmacyLabel.Location = New Point(299, 72)
            pharmacyLabel.AutoSize = True
            registrationPanel.Controls.Add(pharmacyLabel)

            Dim approveButton As New Button()
            approveButton.Text = "Accept"
            approveButton.Tag = DoctorName
            approveButton.BackColor = Color.LawnGreen
            approveButton.Size = New Size(93, 26)
            approveButton.Location = New Point(268, 115)
            AddHandler approveButton.Click, AddressOf ApproveDoctorRegistration
            registrationPanel.Controls.Add(approveButton)

            Dim declineButton As New Button()
            declineButton.Text = "Decline"
            declineButton.Tag = DoctorName
            declineButton.BackColor = Color.Red
            declineButton.Size = New Size(93, 26)
            declineButton.Location = New Point(430, 115)
            AddHandler declineButton.Click, AddressOf declinedoctorRegistration
            registrationPanel.Controls.Add(declineButton)

            FlowLayoutPanel1.Controls.Add(registrationPanel)
        End While

        sellerReader.Close()
    End Sub

    Private Sub ApproveSellerRegistration(sender As Object, e As EventArgs)
        Dim sellerName As String = DirectCast(sender, Button).Tag.ToString()

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        ' Update the Seller table to mark the registration as approved
        Dim updateQuery As String = "UPDATE Seller SET Verification=? WHERE SellerName=?"
        Dim updateCmd As New OleDbCommand(updateQuery, conn)
        updateCmd.Parameters.AddWithValue("@Verification", True)
        updateCmd.Parameters.AddWithValue("@SellerName", sellerName)
        updateCmd.ExecuteNonQuery()

        conn.Close()

        LoadPendingRegistrations()
    End Sub

    Private Sub declineSellerRegistration(sender As Object, e As EventArgs)
        Dim sellerName As String = DirectCast(sender, Button).Tag.ToString()

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        ' Update the Seller table to mark the registration as approved
        Dim updateQuery As String = "UPDATE Seller SET  Verification=? WHERE SellerName=?"
        Dim updateCmd As New OleDbCommand(updateQuery, conn)
        updateCmd.Parameters.AddWithValue("@Verification", False)
        updateCmd.Parameters.AddWithValue("@SellerName", sellerName)
        updateCmd.ExecuteNonQuery()

        conn.Close()

        LoadPendingRegistrations()
    End Sub

    Private Sub ApproveDoctorRegistration(sender As Object, e As EventArgs)
        Dim DoctorName As String = DirectCast(sender, Button).Tag.ToString()

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        ' Update the doctor table to mark the registration as approved
        Dim updateQuery As String = "UPDATE DoctorData SET DoctorVerification= ? WHERE DoctorName=?"
        Dim updateCmd As New OleDbCommand(updateQuery, conn)
        updateCmd.Parameters.AddWithValue("@DoctorVerification", True)
        updateCmd.Parameters.AddWithValue("@DoctorName", DoctorName)
        updateCmd.ExecuteNonQuery()

        conn.Close()

        LoadPendingRegistrations()
    End Sub

    Private Sub declinedoctorRegistration(sender As Object, e As EventArgs)
        Dim DoctorName As String = DirectCast(sender, Button).Tag.ToString()

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        ' Update the Doctor table to mark the registration as approved
        Dim updateQuery As String = "UPDATE DoctorData SET DoctorVerification=? WHERE DoctorName=?"
        Dim updateCmd As New OleDbCommand(updateQuery, conn)
        updateCmd.Parameters.AddWithValue("@DoctorVerification", False)
        updateCmd.Parameters.AddWithValue("@DoctorName", DoctorName)
        updateCmd.ExecuteNonQuery()

        conn.Close()

        LoadPendingRegistrations()
    End Sub

    Private Sub FlowLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles FlowLayoutPanel1.Paint

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim kpi As New kpi(LoggedInUser)
        kpi.Show()
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