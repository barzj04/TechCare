Imports System.Data.OleDb
Imports System.Net.Security

Imports System.IO
Public Class custAPPOINTMENT
    Dim ConnectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\LENOVO\Documents\LoginDatabase.accdb"
    Dim connection As New OleDbConnection(ConnectionString)
    Dim appointmentConnection As New OleDbConnection(ConnectionString)
    Dim doctorConnection As New OleDbConnection(ConnectionString)
    Dim bookingConnection As New OleDbConnection(ConnectionString)
    Dim guestConnection As New OleDbConnection(ConnectionString)

    Public Property LoggedInUser As String
    Public Sub New(Email As String)
        InitializeComponent()
        LoggedInUser = Email
    End Sub
    Private Sub custAPPOINTMENT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadAppointmentDates()
    End Sub

    Private Sub LoadAppointmentDates()
        FlowLayoutPanel1.Controls.Clear()

        Dim selectQuery As String = "SELECT  DoctorEmail,DoctorDate FROM DoctorAvailability"
        Dim command As New OleDbCommand(selectQuery, appointmentConnection)
        appointmentConnection.Open()
        Dim reader As OleDbDataReader = command.ExecuteReader()

        While reader.Read()

            Dim doctorEmail As String = reader.GetString(0)
            Dim appointmentDate As Date = reader.GetDateTime(1)

            Dim panel As New Panel()
            panel.Size = New Size(727, 189)
            panel.Margin = New Padding(5)
            panel.BackColor = Color.Brown

            Dim label As New Label()
            label.Text = appointmentDate.ToShortDateString()
            label.Location = New Point(413, 117)
            label.TextAlign = ContentAlignment.MiddleCenter

            Dim doctorInfo As (Name As String, CompanyName As String) = GetDoctorInfo(doctorEmail)

            Dim doctorNameLabel As New Label()
            doctorNameLabel.Location = New Point(0, 0)
            doctorNameLabel.TextAlign = ContentAlignment.MiddleCenter
            doctorNameLabel.Text = "Doctor: " & doctorInfo.Name

            Dim companyNameLabel As New Label()
            companyNameLabel.Location = New Point(184, 32)
            companyNameLabel.TextAlign = ContentAlignment.MiddleCenter
            companyNameLabel.Text = doctorInfo.CompanyName

            Dim problemTextBox As New TextBox()
            problemTextBox.Location = New Point(16, 87)
            problemTextBox.Size = New Size(388, 24)
            problemTextBox.Multiline = True
            problemTextBox.ScrollBars = ScrollBars.Vertical

            Dim problemlabel As New Label()
            problemlabel.Text = "PROBLEM"
            problemlabel.BackColor = Color.White
            problemlabel.Location = New Point(13, 55)


            Dim bookButton As New Button()
            bookButton.Text = "Book"
            bookButton.Location = New Point(555, 121)
            bookButton.Tag = (appointmentDate, problemTextBox, doctorEmail)
            AddHandler bookButton.Click, AddressOf BookButton_Click

            panel.Controls.Add(label)
            panel.Controls.Add(doctorNameLabel)
            panel.Controls.Add(companyNameLabel)
            panel.Controls.Add(problemTextBox)
            panel.Controls.Add(bookButton)
            panel.Controls.Add(problemlabel)
            FlowLayoutPanel1.Controls.Add(panel)
        End While

        reader.Close()
        appointmentConnection.Close()
    End Sub

    Private Function GetDoctorInfo(doctorEmail As String) As (Name As String, CompanyName As String)
        Dim selectQuery As String = "SELECT DoctorName, DoctorPharmacy FROM DoctorData WHERE DoctorEmail = @DoctorEmail"
        Dim command As New OleDbCommand(selectQuery, doctorConnection)
        command.Parameters.AddWithValue("@DoctorEmail", doctorEmail)
        doctorConnection.Open()
        Dim reader As OleDbDataReader = command.ExecuteReader()

        Dim doctorName As String = String.Empty
        Dim doctorPharmacy As String = String.Empty

        If reader.Read() Then
            doctorName = reader.GetString(0)
            doctorPharmacy = reader.GetString(1)
        End If

        reader.Close()
        doctorConnection.Close()

        Return (doctorName, doctorPharmacy)
    End Function

    Private Function GetGuestName(email As String) As String
        guestConnection.Open()
        Dim selectQuery As String = "SELECT GuestName FROM GuestData WHERE [Email] = @Email"
        Dim command As New OleDbCommand(selectQuery, guestConnection)
        command.Parameters.AddWithValue("@Email", LoggedInUser)

        Dim guestName As String = Convert.ToString(command.ExecuteScalar())
        guestConnection.Close()
        Return guestName
    End Function

    Private Sub BookButton_Click(sender As Object, e As EventArgs)
        Dim bookButton As Button = DirectCast(sender, Button)
        Dim appointmentDate As Date = DirectCast(bookButton.Tag, (Date, TextBox, String)).Item1
        Dim problemTextBox As TextBox = DirectCast(bookButton.Tag, (Date, TextBox, String)).Item2
        Dim doctorEmail As String = DirectCast(bookButton.Tag, (Date, TextBox, String)).Item3
        Dim problem As String = problemTextBox.Text

        Dim guestName As String = GetGuestName(LoggedInUser)

        Dim insertQuery As String = "INSERT INTO Booking (BookDate, Problem, DoctorEmail, PatientName, [Email]) VALUES (@BookingDate, @Problem, @DoctorEmail, @GuestName, @Email)"
        Dim command As New OleDbCommand(insertQuery, bookingConnection)
        command.Parameters.AddWithValue("@BookDate", appointmentDate)
        command.Parameters.AddWithValue("@Problem", problem)
        command.Parameters.AddWithValue("@DoctorEmail", doctorEmail)
        command.Parameters.AddWithValue("@GuestName", guestName)
        command.Parameters.AddWithValue("@Email", LoggedInUser)
        bookingConnection.Open()
        command.ExecuteNonQuery()
        bookingConnection.Close()

        MessageBox.Show("Date booked successfully!")

        LoadAppointmentDates()
    End Sub

    Private Sub GunaGroupBox1_Click(sender As Object, e As EventArgs) Handles GunaGroupBox1.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

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