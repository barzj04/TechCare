Imports System.Data.OleDb
Imports System.Net.Security
Imports System.IO

Public Class docAPPOINTMENT
    Dim ConnectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\LENOVO\Documents\LoginDatabase.accdb"
    Dim connection As New OleDbConnection(connectionString)
    Public Property LoggedInUser As String
    Public Sub New(DoctorEmail As String)
        InitializeComponent()
        LoggedInUser = DoctorEmail
    End Sub
    Private Sub docAPPOINTMENT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplaySelectedDates()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim selectedDate As Date = MonthCalendar1.SelectionRange.Start

        Dim insertQuery As String = "INSERT INTO DoctorAvailability (DoctorDate, DoctorEmail) VALUES (@DoctorDate, @DoctorEmail)"
        Dim command As New OleDbCommand(insertQuery, connection)
        command.Parameters.AddWithValue("@DoctorDate", selectedDate)
        command.Parameters.AddWithValue("@DoctorEmail", LoggedInUser)
        connection.Open()
        command.ExecuteNonQuery()
        connection.Close()

        DisplaySelectedDates()
    End Sub

    Private Sub DisplaySelectedDates()
        FlowLayoutPanel1.Controls.Clear()

        Dim selectQuery As String = $"SELECT DoctorDate FROM DoctorAvailability WHERE DoctorEmail = '{LoggedInUser}'"
        Dim command As New OleDbCommand(selectQuery, connection)
        connection.Open()
        Dim reader As OleDbDataReader = command.ExecuteReader()

        While reader.Read()
            Dim selectedDate As Date = reader.GetDateTime(0)

            Dim panel As New Panel()
            panel.Size = New Size(434, 68)
            panel.Location = New Point(3, 3)
            panel.BackColor = Color.White

            Dim dateTimePicker As New Guna.UI.WinForms.GunaDateTimePicker()
            dateTimePicker.Value = selectedDate
            dateTimePicker.BackColor = Color.White
            dateTimePicker.Enabled = False
            dateTimePicker.Size = New Size(365, 62)
            dateTimePicker.Location = New Point(3, 3)

            Dim removeButton As New Button()
            removeButton.BackColor = Color.Red
            removeButton.Size = New Size(65, 60)
            removeButton.Location = New Point(374, 3)
            removeButton.Text = "Remove"
            removeButton.Tag = selectedDate

            AddHandler removeButton.Click, AddressOf RemoveButton_Click
            FlowLayoutPanel1.Controls.Add(panel)
            panel.Controls.Add(dateTimePicker)
            panel.Controls.Add(removeButton)

        End While

        reader.Close()
        connection.Close()
    End Sub

    Private Sub RemoveButton_Click(sender As Object, e As EventArgs)
        Dim removeButton As Button = DirectCast(sender, Button)
        Dim selectedDate As Date = DirectCast(removeButton.Tag, Date)

        Dim deleteQuery As String = "DELETE FROM DoctorAvailability WHERE DoctorDate = @DoctorDate AND DoctorEmail = @DoctorEmail"
        Dim command As New OleDbCommand(deleteQuery, connection)
        command.Parameters.AddWithValue("@DoctorDate", selectedDate)
        command.Parameters.AddWithValue("@DoctorEmail", LoggedInUser)
        connection.Open()
        command.ExecuteNonQuery()
        connection.Close()

        Dim panel As Panel = DirectCast(removeButton.Parent, Panel)
        FlowLayoutPanel1.Controls.Remove(panel)
    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim docbook As New docBOOKING(LoggedInUser)
        docbook.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim docprof As New docPROFILE(LoggedInUser)
        docprof.Show()
        Me.Hide()
    End Sub

    Private Function GetDoctorName() As String
        Dim doctorName As String = ""

        Dim selectQuery As String = "SELECT DoctorName FROM DoctorData WHERE DoctorEmail = @DoctorEmail"
        Dim command As New OleDbCommand(selectQuery, connection)
        command.Parameters.AddWithValue("@DoctorEmail", LoggedInUser)

        connection.Open()
        Dim reader As OleDbDataReader = command.ExecuteReader()

        If reader.Read() Then
            doctorName = reader.GetString(0)
        End If

        reader.Close()
        connection.Close()

        Return doctorName
    End Function

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class