Public Class custFAQ
    Public Property LoggedInUser As String
    Public Sub New(Email As String)
        InitializeComponent()
        LoggedInUser = Email
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim selectedOption As String = ComboBox1.SelectedItem.ToString()
        Select Case selectedOption
            Case "is your online pharmacy legit?"
                Label2.Text = "is your online pharmacy legit?"
                GunaLabel1.Text = "Yes, our online pharmacy is legitimate. " &
                    "We are a licensed and reputable pharmacy operating in accordance with all applicable laws and regulations. " &
                    "We prioritize the health and safety of our customers and ensure that all medications dispensed are sourced from approved manufacturers."

            Case "why should we choose your online pharmacy?"
                Label2.Text = "why should we choose your online pharmacy?"
                GunaLabel1.Text = "You should choose our online pharmacy as we can offer various medicine from different pharmacy." &
                    " There also might be a close pharmacy near you, ensuring the speed of the medicine to arrived"

            Case "how many type of medicine will be there?"
                Label2.Text = "how many type of medicine will be there?"
                GunaLabel1.Text = "There will be various type of medicine from various brands." &
                    "However as of now, we are only focusing on common medicine for easier regulation such as paracetamol,Loratodine, Cetrizine Hydrochloride and others commonly found medicine"
        End Select
    End Sub

    Private Sub custFAQ_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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