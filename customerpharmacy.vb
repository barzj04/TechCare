Imports System.Data.OleDb
Imports Guna.UI.WinForms

Public Class customerpharmacy
    Dim conn As New OleDbConnection
    Private grandTotal As Double = 0
    Public Property LoggedInUser As String
    Public Sub New(Email As String)
        InitializeComponent()
        LoggedInUser = Email
    End Sub

    Public ReadOnly Property SelectedItems As ListBox.ObjectCollection
        Get
            Return ListBox1.Items
        End Get
    End Property
    Private Sub GunaButton5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim customerprofile As New custPROFILE(LoggedInUser)
        customerprofile.Show()
        Me.Hide()

    End Sub

    Private Sub customerpharmacy_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\LENOVO\Documents\LoginDatabase.accdb"
        LoadItemsFromDatabase()

        'FlowLayoutPanel1.Controls.Clear()
    End Sub
    Private Sub LoadItemsFromDatabase()
        ' Clear existing controls
        FlowLayoutPanel1.Controls.Clear()

        ' Retrieve items from the database
        Dim query As String = "SELECT ItemName, ItemPrice ,ItemDetails FROM [DatabaseItem]"
        Dim cmd As New OleDbCommand(query, conn)

        Try
            conn.Open()
            Dim reader As OleDbDataReader = cmd.ExecuteReader()

            While reader.Read()
                Dim itemName As String = reader.GetString(0)
                Dim itemPrice As String = reader.GetString(1)
                Dim convertedPrice As Double = CDec(itemPrice)
                Dim itemDetails As String = reader.GetString(2)


                ' Create item panel
                Dim itemPanel As New Panel()
                itemPanel.BackColor = Color.Transparent
                itemPanel.BorderStyle = BorderStyle.FixedSingle
                itemPanel.Size = New Size(269, 110)

                ' Add picturebox


                ' Add name textbox
                Dim txtname As New GunaLineTextBox()
                txtname.Text = itemName
                txtname.Size = New Size(142, 29)
                txtname.Location = New Point(114, -1)
                txtname.BackColor = Color.White
                itemPanel.Controls.Add(txtname)

                ' Add price label
                Dim priceLabel As New Label()

                priceLabel.Text = "RM" & convertedPrice.ToString("0.00")
                priceLabel.BackColor = Color.White
                priceLabel.AutoSize = True
                priceLabel.Location = New Point(111, 29)
                itemPanel.Controls.Add(priceLabel)

                ' Add info button
                Dim infoButton As New Button()
                infoButton.Text = "Info"
                infoButton.Size = New Size(51, 27)
                infoButton.Location = New Point(115, 70)
                AddHandler infoButton.Click, Sub(s As Object, args As EventArgs)
                                                 ShowItemInfo(itemDetails)
                                             End Sub
                itemPanel.Controls.Add(infoButton)

                ' Add add to cart button
                Dim addButton As New Button()
                addButton.Text = "Add"
                addButton.Size = New Size(51, 27)
                addButton.Location = New Point(172, 70)
                AddHandler addButton.Click, Sub(s As Object, args As EventArgs)
                                                AddToCart(itemName)
                                            End Sub
                itemPanel.Controls.Add(addButton)

                FlowLayoutPanel1.Controls.Add(itemPanel)
            End While

            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error retrieving items from the database: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
    Private Sub ShowItemInfo(itemName As String)
        ' Retrieve item info from the database based on the item name
        Dim query As String = "SELECT ItemDetails FROM DatabaseItem WHERE ItemName = ?"
        Dim cmd As New OleDbCommand(query, conn)
        cmd.Parameters.AddWithValue("@ItemName", itemName)

        Try
            conn.Open()
            Dim ItemDetails As String = cmd.ExecuteScalar().ToString()
            MessageBox.Show(ItemDetails, "Item Information")
        Catch ex As Exception
            MessageBox.Show("Error retrieving item information: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub AddToCart(itemName As String)
        ListBox1.Items.Add(itemName)
        MessageBox.Show(itemName & " added to cart!", "Add to Cart")
    End Sub

    Private Function BytesToImage(imageBytes() As Byte) As Image
        ' Convert byte array to Image
        Using stream As New IO.MemoryStream(imageBytes)
            Return Image.FromStream(stream)
        End Using
    End Function
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim custcart As New custCART(LoggedInUser, Me)
        custcart.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim customerappointment As New custAPPOINTMENT(LoggedInUser)
        customerappointment.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim customertracker As New custTRACKER(LoggedInUser)
        customertracker.Show()
        Me.Hide()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim custprog As New custPROG1(LoggedInUser)
        custprog.Show()
        Me.Hide()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim custaboutus As New custABOUT(LoggedInUser)
        custaboutus.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim customerfaq As New custFAQ(LoggedInUser)
        customerfaq.Show()
        Me.Hide()
    End Sub

    Private Sub FlowLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles FlowLayoutPanel1.Paint

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        ListBox1.Items.Clear()
    End Sub

    Private Sub GunaTextBox1_TextChanged(sender As Object, e As EventArgs) Handles GunaTextBox1.TextChanged

    End Sub

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click
        Dim conn As New OleDbConnection
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\LENOVO\Documents\LoginDatabase.accdb"
        Dim searchQuery As String = "SELECT ItemName, ItemPrice ,ItemDetails FROM DatabaseItem WHERE ItemName LIKE @SearchTerm"
        Dim searchTerm As String = "%" & GunaTextBox1.Text & "%"
        Dim command As New OleDbCommand(searchQuery, conn)
        command.Parameters.AddWithValue("@SearchTerm", searchTerm)
        conn.Open()
        Dim reader As OleDbDataReader = command.ExecuteReader()

        FlowLayoutPanel1.Controls.Clear()
        While reader.Read()
            Dim itemName As String = reader.GetString(0)
            Dim itemPrice As Double = reader.GetInt32(1)
            Dim convertedPrice As Double = CDbl(itemPrice)
            Dim itemDetails As String = reader.GetString(2)

            'Dim itemImageBytes() As Byte = DirectCast(reader.GetValue(5), Byte())
            'Dim itemImage As Image = BytesToImage(itemImageBytes)

            ' Create item panel
            Dim itemPanel As New Panel()
            itemPanel.BackColor = Color.Transparent
            itemPanel.BorderStyle = BorderStyle.FixedSingle
            itemPanel.Size = New Size(269, 110)

            ' Add picturebox

            ' Add name textbox
            Dim txtname As New GunaLineTextBox()
            txtname.Text = itemName
            txtname.Size = New Size(142, 29)
            txtname.Location = New Point(114, -1)
            txtname.BackColor = Color.White
            itemPanel.Controls.Add(txtname)

            ' Add price label
            Dim priceLabel As New Label()
            priceLabel.Text = "RM" & convertedPrice.ToString("0.00")
            priceLabel.BackColor = Color.White
            priceLabel.AutoSize = True
            priceLabel.Location = New Point(111, 29)
            itemPanel.Controls.Add(priceLabel)

            ' Add info button
            Dim infoButton As New Button()
            infoButton.Text = "Info"
            infoButton.Size = New Size(51, 27)
            infoButton.Location = New Point(115, 70)
            AddHandler infoButton.Click, Sub(s As Object, args As EventArgs)
                                             ShowItemInfo(itemDetails)
                                         End Sub
            itemPanel.Controls.Add(infoButton)

            ' Add add to cart button
            Dim addButton As New Button()
            addButton.Text = "Add"
            addButton.Size = New Size(172, 70)
            addButton.Location = New Point(95, 160)
            AddHandler addButton.Click, Sub(s As Object, args As EventArgs)
                                            AddToCart(itemName)
                                        End Sub
            itemPanel.Controls.Add(addButton)

            FlowLayoutPanel1.Controls.Add(itemPanel)
        End While

        reader.Close()
        conn.Close()
    End Sub
End Class