Imports System.Data.OleDb

Public Class docBOOKING
    Dim ConnectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\LENOVO\Documents\LoginDatabase.accdb"
    Dim bookingConnection As New OleDbConnection(ConnectionString)
    Dim guestConnection As New OleDbConnection(ConnectionString)
    Public Property LoggedInUser As String
    Public Sub New(DoctorEmail As String)
        InitializeComponent()
        LoggedInUser = DoctorEmail
    End Sub
    Private Sub docBOOKING_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadBookingDetails()
    End Sub

    Private Sub LoadBookingDetails()
        FlowLayoutPanel1.Controls.Clear()

        Dim selectQuery As String = "SELECT PatientName, Email, Problem, Acceptance,Decline FROM Booking WHERE DoctorEmail = @DoctorEmail AND Acceptance = False AND Decline = False "
        Dim command As New OleDbCommand(selectQuery, bookingConnection)
        command.Parameters.AddWithValue("@DoctorEmail", LoggedInUser)
        bookingConnection.Open()
        Dim reader As OleDbDataReader = command.ExecuteReader()

        While reader.Read()
            Dim patientName As String = reader.GetString(0)
            Dim patientEmail As String = reader.GetString(1)
            Dim problem As String = reader.GetString(2)
            'Dim accepted As Boolean = reader.GetBoolean(3)

            Dim panel As New Panel()
            panel.Size = New Size(631, 377)
            panel.Location = New Point(3, 3)
            panel.Margin = New Padding(5)
            panel.BackColor = Color.PeachPuff


            Dim nameLabel As New Label()
            nameLabel.Location = New Point(14, 9)
            nameLabel.Text = "Name:   " & patientName
            nameLabel.AutoSize = True

            Dim emailLabel As New Label()
            emailLabel.Location = New Point(14, 38)
            emailLabel.Text = "Email:   " & patientEmail
            emailLabel.AutoSize = True

            Dim phoneLabel As New Label()
            phoneLabel.Location = New Point(14, 67)
            phoneLabel.AutoSize = True
            phoneLabel.Text = "Phone: " & GetGuestPhoneNumber(patientEmail)

            Dim ageLabel As New Label()
            ageLabel.Location = New Point(16, 97)
            ageLabel.AutoSize = True
            ageLabel.Text = "Age: " & GetGuestAge(patientEmail)

            Dim problemLabel As New Label()
            problemLabel.Location = New Point(14, 141)
            problemLabel.Text = "Problem: "
            problemLabel.AutoSize = True

            Dim problemtext As New Label()
            problemtext.Location = New Point(130, 141)
            problemtext.Size = New Size(488, 178)
            problemtext.BackColor = Color.White
            problemtext.Text = problem

            'Dim acceptanceLabel As New Label()
            'acceptanceLabel.AutoSize = True
            'acceptanceLabel.Text = "Accepted: " & If(accepted, "Yes", "No")

            Dim acceptButton As New Button()
            acceptButton.Text = "Accept"
            acceptButton.Tag = patientEmail
            acceptButton.BackColor = Color.PeachPuff
            acceptButton.AutoSize = true
            acceptButton.Location = New Point(413, 342)
            AddHandler acceptButton.Click, AddressOf AcceptButton_Click


            Dim declineButton As New Button()
            declineButton.Text = "Decline"
            declineButton.AutoSize = True
            declineButton.BackColor = Color.Red
            declineButton.Location = New Point(105, 342)
            declineButton.Tag = patientEmail
            AddHandler declineButton.Click, AddressOf DeclineButton_Click

            panel.Controls.Add(nameLabel)
            panel.Controls.Add(emailLabel)
            panel.Controls.Add(phoneLabel)
            panel.Controls.Add(ageLabel)
            panel.Controls.Add(problemLabel)
            ' panel.Controls.Add(acceptanceLabel)
            panel.Controls.Add(problemtext)
            panel.Controls.Add(acceptButton)
            panel.Controls.Add(declineButton)

            FlowLayoutPanel1.Controls.Add(panel)
        End While

        reader.Close()
        bookingConnection.Close()
    End Sub

    Private Function GetGuestPhoneNumber(email As String) As String
        Dim selectQuery As String = "SELECT Phone FROM GuestData WHERE Email = @Email"
        Dim command As New OleDbCommand(selectQuery, guestConnection)
        command.Parameters.AddWithValue("@Email", email)
        guestConnection.Open()
        Dim phoneNumber As String = Convert.ToString(command.ExecuteScalar())
        guestConnection.Close()
        Return phoneNumber
    End Function

    Private Function GetGuestAge(email As String) As Integer
        Dim selectQuery As String = "SELECT Age FROM GuestData WHERE Email = @Email"
        Dim command As New OleDbCommand(selectQuery, guestConnection)
        command.Parameters.AddWithValue("@Email", email)
        guestConnection.Open()
        Dim age As Integer = CInt(command.ExecuteScalar())
        guestConnection.Close()
        Return age
    End Function

    Private Sub AcceptButton_Click(sender As Object, e As EventArgs)
        Dim acceptButton As Button = DirectCast(sender, Button)
        Dim Email As String = DirectCast(acceptButton.Tag, String)

        Dim updateQuery As String = "UPDATE Booking SET Acceptance = True WHERE Email = @Email"
        Dim command As New OleDbCommand(updateQuery, bookingConnection)
        command.Parameters.AddWithValue("@Email", Email)
        bookingConnection.Open()
        command.ExecuteNonQuery()
        bookingConnection.Close()

        LoadBookingDetails()
    End Sub

    Private Sub DeclineButton_Click(sender As Object, e As EventArgs)
        Dim declineButton As Button = DirectCast(sender, Button)
        Dim Email As String = DirectCast(declineButton.Tag, String)

        Dim updateQuery As String = "UPDATE Booking SET Decline = True WHERE Email = @Email"
        Dim command As New OleDbCommand(updateQuery, bookingConnection)
        command.Parameters.AddWithValue("@Email", Email)
        bookingConnection.Open()
        command.ExecuteNonQuery()
        bookingConnection.Close()

        LoadBookingDetails()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim docprof As New docPROFILE(LoggedInUser)
        docprof.Show()
        Me.Hide()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click

    End Sub
End Class