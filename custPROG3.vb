Public Class custPROG3
    Public Property LoggedInUser As String
    Public Sub New(Email As String)
        InitializeComponent()
        LoggedInUser = Email
    End Sub
    Private Sub custPROG3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
    Private Sub GunaComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GunaComboBox1.SelectedIndexChanged
        ' Retrieve the selected disease from GunaComboBox1
        Dim disease As String = GunaComboBox1.SelectedItem.ToString()

        ' Determine the selected disease and update the corresponding text boxes
        Select Case disease
            Case "Influenza (Flu)"
                ' Update information about Influenza
                GunaTextBox3.Text = "Influenza is a highly contagious viral infection that affects the respiratory system."
                GunaTextBox1.Text = "Fever, chills, sore throat, cough, runny or stuffy nose, body aches, fatigue."
                GunaTextBox2.Text = "Get plenty of rest, drink fluids to stay hydrated, use over-the-counter pain relievers for fever and discomfort, and avoid contact with others to prevent spreading the virus. In severe cases, antiviral medication may be prescribed."
            Case "Diabetes"
                ' Update information about Diabetes
                GunaTextBox3.Text = "Diabetes is a chronic condition characterized by high blood sugar levels due to the body's inability to produce or use insulin effectively."
                GunaTextBox1.Text = "Frequent urination, excessive thirst, unexplained weight loss, fatigue, blurred vision."
                GunaTextBox2.Text = "Follow a healthy diet, monitor blood sugar levels regularly, take prescribed medications (insulin or oral medications), engage in regular physical activity, and maintain a healthy weight. Regular check-ups with a healthcare provider are essential."
            Case "Asthma"
                ' Update information about Asthma
                GunaTextBox3.Text = "Asthma is a chronic lung disease that causes inflammation and narrowing of the airways, leading to breathing difficulties."
                GunaTextBox1.Text = "Wheezing, coughing (especially at night or during exercise), shortness of breath, chest tightness."
                GunaTextBox2.Text = "Use prescribed inhalers (quick-relief and long-term control medications) as directed by a healthcare provider, avoid triggers such as allergens and smoke, create an asthma action plan, and seek emergency medical care if symptoms worsen."
        End Select

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim disease As String = GunaComboBox1.SelectedItem.ToString()

        ' Determine the selected disease and update the corresponding text boxes
        Select Case disease
            Case "Influenza (Flu)"
                ' Update information about Influenza
                GunaTextBox3.Text = "Influenza is a highly contagious viral infection that affects the respiratory system."
                GunaTextBox1.Text = "Fever, chills, sore throat, cough, runny or stuffy nose, body aches, fatigue."
                GunaTextBox2.Text = "Get plenty of rest, drink fluids to stay hydrated, use over-the-counter pain relievers for fever and discomfort, and avoid contact with others to prevent spreading the virus. In severe cases, antiviral medication may be prescribed."
            Case "Diabetes"
                ' Update information about Diabetes
                GunaTextBox3.Text = "Diabetes is a chronic condition characterized by high blood sugar levels due to the body's inability to produce or use insulin effectively."
                GunaTextBox1.Text = "Frequent urination, excessive thirst, unexplained weight loss, fatigue, blurred vision."
                GunaTextBox2.Text = "Follow a healthy diet, monitor blood sugar levels regularly, take prescribed medications (insulin or oral medications), engage in regular physical activity, and maintain a healthy weight. Regular check-ups with a healthcare provider are essential."
            Case "Asthma"
                ' Update information about Asthma
                GunaTextBox3.Text = "Asthma is a chronic lung disease that causes inflammation and narrowing of the airways, leading to breathing difficulties."
                GunaTextBox1.Text = "Wheezing, coughing (especially at night or during exercise), shortness of breath, chest tightness."
                GunaTextBox2.Text = "Use prescribed inhalers (quick-relief and long-term control medications) as directed by a healthcare provider, avoid triggers such as allergens and smoke, create an asthma action plan, and seek emergency medical care if symptoms worsen."
        End Select
    End Sub
End Class