Imports System.Data.OleDb
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms
Imports Guna.UI.WinForms
Public Class doclogin
    Public Property LoggedInUser As String
    Public Sub New(DoctorEmail As String)
        InitializeComponent()
        LoggedInUser = DoctorEmail
    End Sub
    Dim conn As New OleDbConnection
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = Nothing Or MaskedTextBox1.Text = Nothing Then
            MsgBox("enter the credentials please")
        Else
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            Dim cmd As New OleDbCommand("select count(*) from DoctorData where DoctorEmail=? and DoctorPassword=?", conn)
            cmd.Parameters.AddWithValue("@1", OleDbType.VarChar).Value = TextBox1.Text
            cmd.Parameters.AddWithValue("@2", OleDbType.VarChar).Value = MaskedTextBox1.Text
            Dim count = Convert.ToInt32(cmd.ExecuteScalar())

            If (count > 0) Then
                MsgBox("login success")
                Dim LoggedInUser As String = TextBox1.Text
                Dim DocAppointment As New docAPPOINTMENT(LoggedInUser)
                DocAppointment.Show()

                Me.Hide()
            Else
                MsgBox("check credentials")

            End If

        End If
    End Sub

    Private Sub doclogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\LENOVO\Documents\LoginDatabase.accdb"
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        docregister.Show()
        Me.Hide()

    End Sub
End Class