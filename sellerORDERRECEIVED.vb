Imports System.Data.OleDb
Imports Guna.UI.WinForms
Public Class sellerORDERRECEIVED
    Dim conn As New OleDbConnection
    Public Property LoggedInUser As String

    'Private loggedInUser As String = ""
    Public Sub New(SellerEmail As String)
        InitializeComponent()
        LoggedInUser = SellerEmail
    End Sub
    Private Sub GunaLabel5_Click(sender As Object, e As EventArgs) Handles GunaLabel5.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim sellerprofile As New sellerPROFILE(LoggedInUser)
        sellerprofile.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim selleradditem As New sellerADDITEM(LoggedInUser)
        selleradditem.Show()
        Me.Hide()
    End Sub

    Private Sub sellerORDERRECEIVED_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connectionstring As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\LENOVO\Documents\LoginDatabase.accdb"
        FlowLayoutPanel1.Controls.Clear()

        Dim query As String = "SELECT * FROM [Order] WHERE SellerEmail = @SellerEmail"

        Using connection As New OleDbConnection(connectionString)
            connection.Open()

            Using command As New OleDbCommand(query, connection)
                ' Add the SellerEmail parameter to the command
                command.Parameters.AddWithValue("@SellerEmail", LoggedInUser)

                Using reader As OleDbDataReader = command.ExecuteReader()
                    While reader.Read()
                        ' Retrieve order details from the reader
                        Dim orderID As String = reader.GetString(0)
                        Dim itemName As String = reader.GetString(2)
                        Dim buyerName As String = reader.GetString(1)
                        Dim Quantity As String = reader.GetString(3)
                        Dim Address As String = reader.GetString(6)
                        'Dim imageUrl As String = reader.GetString(5)

                        ' Create a panel for each order
                        Dim orderPanel As New Panel()
                        orderPanel.BorderStyle = BorderStyle.FixedSingle
                        orderPanel.Size = New Size(686, 118)
                        orderPanel.BackColor = Color.Tan
                        orderPanel.Location = New Point(3, 2)

                        ' Create a PictureBox for the item image
                        'Dim pictureBox As New PictureBox()
                        'PictureBox.SizeMode = PictureBoxSizeMode.StretchImage
                        'ictureBox.ImageLocation = imageUrl
                        'PictureBox.Width = 100
                        'PictureBox.Height = 100

                        ' Create a Label for the item name
                        Dim lblItemName As New Label()
                        lblItemName.Text = itemName
                        lblItemName.Location = New Point(108, 14)
                        lblItemName.BackColor = Color.White
                        lblItemName.AutoSize = True

                        Dim lblorder As New Label()
                        lblorder.Text = "New Order!!!!!!!!"
                        lblorder.Location = New Point(108, 42)
                        lblorder.BackColor = Color.White
                        lblorder.AutoSize = True

                        ' Create a Button for displaying buyer name and order details
                        Dim btnShowDetails As New Button()
                        btnShowDetails.Text = "Information"
                        btnShowDetails.Location = New Point(560, 80)
                        btnShowDetails.BackColor = Color.White
                        btnShowDetails.AutoSize = True

                        ' Event handler for the button click event
                        AddHandler btnShowDetails.Click, Sub(senderBtn As Object, eBtn As EventArgs)
                                                             MessageBox.Show("Buyer Name: " & buyerName & vbCrLf & "    Quantity: " & Quantity & vbCrLf & "Address  :" & Address)
                                                         End Sub

                        ' Add the order panel to the flow layout panel
                        FlowLayoutPanel1.Controls.Add(orderPanel)

                        ' Add controls to the order panel
                        'orderPanel.Controls.Add(pictureBox)
                        orderPanel.Controls.Add(lblItemName)
                        orderPanel.Controls.Add(btnShowDetails)
                        orderPanel.Controls.Add(lblorder)


                    End While
                End Using
            End Using

            connection.Close()
        End Using
    End Sub

    Private Sub FlowLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles FlowLayoutPanel1.Paint

    End Sub
End Class