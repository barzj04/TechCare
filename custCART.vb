Imports System.Data.OleDb
Imports System.IO
Imports Guna.UI.WinForms
Public Class custCART
    Private selectedItems As List(Of String)
    Dim conn As New OleDbConnection
    Dim cmd As OleDbCommand
    Private mainpage As customerpharmacy

    Public Property LoggedInUser As String
    Private grandTotal As Double = 0
    Dim filePath1 As String = ""
    Public Sub New(Email As String)
        InitializeComponent()
        LoggedInUser = Email

    End Sub

    Public Sub New(Email As String, prevForm As customerpharmacy)
        InitializeComponent()
        LoggedInUser = Email
        mainpage = prevForm ' Store the reference to the previous form
    End Sub
    Private Sub GunaLinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles GunaLinkLabel2.LinkClicked
        Dim mainpage As New customerpharmacy(LoggedInUser)
        mainpage.Show()
        Me.Hide()

    End Sub

    Private Sub custCART_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\LENOVO\Documents\LoginDatabase.accdb"
        LoadItemsFromListBox()
        Dim query As String = "SELECT * FROM DatabaseItem WHERE ItemName = @ItemName"

    End Sub
    Private Sub LoadItemsFromListBox()
        FlowLayoutPanel1.Controls.Clear() ' Clear existing controls
        grandTotal = 0

        Dim orderID As Integer = GenerateOrderID()
        If mainpage IsNot Nothing Then
            For Each item As Object In mainpage.SelectedItems
                Dim itemName As String = item.ToString()
                Dim price As Double = GetPriceFromDatabase(itemName) ' Retrieve the price from the database
                Dim quantity As Integer = 1 ' Set the initial quantity as per your requirement
                Dim image As Image = GetImageFromDatabase(itemName)

                'create panel
                Dim itemPanel As New Panel()
                itemPanel.BackColor = Color.Transparent
                itemPanel.BorderStyle = BorderStyle.FixedSingle
                itemPanel.Location = New Point(3, 2)
                itemPanel.Size = New Size(525, 79)

                ' Create controls for the item
                Dim itemLabel As New Label()
                itemLabel.Text = itemName
                itemLabel.AutoSize = True
                itemLabel.Location = New Point(85, 29)
                itemLabel.BackColor = Color.Transparent
                itemLabel.Name = "itemNameLabel"
                'itemLabel.Name = "itemNameLabel"

                itemPanel.Controls.Add(itemLabel)

                Dim itemprice As New Label()
                itemprice.Text = price
                itemprice.AutoSize = True
                itemprice.Location = New Point(214, 29)
                itemprice.BackColor = Color.Transparent

                itemPanel.Controls.Add(itemprice)

                Dim quantityNumericUpDown As New NumericUpDown()
                quantityNumericUpDown.Minimum = 1
                quantityNumericUpDown.Location = New Point(300, 19)
                quantityNumericUpDown.Size = New Size(67, 30)
                quantityNumericUpDown.Value = quantity
                quantityNumericUpDown.Name = "quantityNumericUpDown"
                quantityNumericUpDown.Tag = price ' Attach the price to the NumericUpDown control
                AddHandler quantityNumericUpDown.ValueChanged, AddressOf QuantityNumericUpDown_ValueChanged
                itemPanel.Controls.Add(quantityNumericUpDown)

                Dim totalLabel As New Label()
                totalLabel.AutoSize = True
                totalLabel.Location = New Point(389, 29)
                totalLabel.BackColor = Color.Transparent
                totalLabel.Name = "totalLabel"
                itemPanel.Controls.Add(totalLabel)

                Dim itemimage As New PictureBox()
                itemimage.Size = New Size(67, 54)
                itemimage.SizeMode = PictureBoxSizeMode.StretchImage
                itemimage.Location = New Point(12, 15)
                itemPanel.Controls.Add(itemimage)

                FlowLayoutPanel1.Controls.Add(itemPanel)
                ' Calculate and display the initial total
                Dim itemTotal As Double = price * quantity
                totalLabel.Text = "RM" & itemTotal

                ' Add the item's total to the grand total
                grandTotal += itemTotal
                AddOrderDetails(orderID, itemName, quantity)
            Next
        End If

        ' Display the grand total
        GunaLabel12.Text = "RM" & grandTotal
        GunaLabel13.Text = "RM" & (grandTotal * 0.06)
        GunaLabel14.Text = "RM " & (grandTotal + (grandTotal * 0.06))




    End Sub

    Private Function GetPriceFromDatabase(itemName As String) As Double
        Dim price As Double = 0

        Try
            conn.Open()
            Dim query As String = "SELECT ItemPrice FROM DatabaseItem WHERE ItemName = @ItemName"
            Using command As New OleDbCommand(query, conn)
                command.Parameters.AddWithValue("@ItemName", itemName)
                Dim result As Object = command.ExecuteScalar()
                If result IsNot Nothing AndAlso Double.TryParse(result.ToString(), price) Then
                    ' Price retrieved successfully from the database
                Else
                    ' Handle the case where the price is not found or not a valid number
                End If
            End Using
        Catch ex As Exception
            ' Handle any exceptions
        Finally
            conn.Close()
        End Try

        Return price
    End Function


    Private Sub QuantityNumericUpDown_ValueChanged(sender As Object, e As EventArgs)
        Dim quantityNumericUpDown As NumericUpDown = DirectCast(sender, NumericUpDown)
        Dim price As Double = Convert.ToDouble(quantityNumericUpDown.Tag)
        Dim quantity As Integer = Convert.ToInt32(quantityNumericUpDown.Value)
        Dim itemPanel As Panel = DirectCast(quantityNumericUpDown.Parent, Panel)
        Dim totalLabel As Label = DirectCast(itemPanel.Controls("totalLabel"), Label)
        Dim itemTotal As Double = price * quantity
        totalLabel.Text = "Total: RM" & itemTotal.ToString("0.00")

        ' Recalculate the grand total
        grandTotal = 0
        For Each control As Control In FlowLayoutPanel1.Controls
            If TypeOf control Is Panel Then
                Dim panel As Panel = DirectCast(control, Panel)
                Dim panelTotalLabel As Label = DirectCast(panel.Controls("totalLabel"), Label)
                Dim panelTotal As Double

                If Double.TryParse(panelTotalLabel.Text.Replace("Total: RM", ""), panelTotal) Then
                    grandTotal += panelTotal
                Else
                    ' Handle the case where the panel total is not a valid number
                End If
            End If
        Next

        ' Update the grand total label
        GunaLabel12.Text = "RM" & grandTotal.ToString("0.00")
        GunaLabel13.Text = "RM" & (grandTotal * 0.06).ToString("0.00")
        GunaLabel14.Text = "RM " & (grandTotal + (grandTotal * 0.06)).ToString("0.00")
    End Sub

    Private Function GetImageFromDatabase(itemName As String) As Image
        Dim image As Image = Nothing

        ' Database access code to retrieve the image based on the item name
        ' Replace this with your actual database retrieval logic
        Try
            conn.Open()
            Dim query As String = "SELECT ImageData FROM Items WHERE ItemName = @ItemName"

            Using command As New OleDbCommand(query, conn)
                command.Parameters.AddWithValue("@ItemName", itemName)
                Dim result As Object = command.ExecuteScalar()

                If result IsNot Nothing AndAlso TypeOf result Is Byte() Then
                    Dim imageData As Byte() = DirectCast(result, Byte())
                    Using memoryStream As New MemoryStream(imageData)
                        image = Image.FromStream(memoryStream)
                    End Using
                End If
            End Using
        Catch ex As Exception
            ' Handle any exceptions
        Finally
            conn.Close()
        End Try

        Return image
    End Function

    Private Function GenerateOrderID() As Integer

        ' Generate a random 4-digit order ID
        Dim random As New Random()
        Dim orderID As Integer = random.Next(1000, 10000)

        Return orderID
    End Function

    Private Sub AddOrderDetails(orderID As Integer, itemName As String, quantity As Integer)

        Try
            conn.Open()
            Dim query As String = "INSERT INTO [Order] (OrderID, ItemName, Quantity, [Email],SellerEmail,Address) VALUES (@OrderID, @ItemName, @Quantity, @Email, @SellerEmail,@Address)"

            Using command As New OleDbCommand(query, conn)
                command.Parameters.AddWithValue("@OrderID", orderID)
                command.Parameters.AddWithValue("@ItemName", itemName)
                command.Parameters.AddWithValue("@Quantity", quantity)
                command.Parameters.AddWithValue("@Email", LoggedInUser) ' Use the logged-in user name
                Dim sellerEmail As String = GetSellerEmailFromDatabase(itemName)
                command.Parameters.AddWithValue("@SellerEmail", sellerEmail)
                command.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            ' Handle any exceptions
        Finally
            conn.Close()
        End Try
    End Sub
    Private Sub FlowLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles FlowLayoutPanel1.Paint

    End Sub

    Private Sub GunaLabel13_Click(sender As Object, e As EventArgs) Handles GunaLabel13.Click

    End Sub

    Private Sub GunaTextBox1_click(sender As Object, e As EventArgs) Handles GunaTextBox1.Click
        cmd = conn.CreateCommand()
        cmd.CommandType = CommandType.Text

        Dim openFileDialog1 As New OpenFileDialog()
        openFileDialog1.Title = "Select File"
        openFileDialog1.Filter = "All Files (*.*)|*.*"
        Dim fileData1 As Byte()

        If openFileDialog1.ShowDialog() = DialogResult.OK Then
            filePath1 = openFileDialog1.FileName
            fileData1 = File.ReadAllBytes(filePath1)
            MessageBox.Show("File selected and stored.")
            Try
                conn.Open()
                Dim query As String = "INSERT INTO [Order] (PrescriptionName, PrescriptionData) VALUES (@PrescriptionName ,@PrescriptionName)"
                Using command As New OleDbCommand(query, conn)
                    cmd.Parameters.AddWithValue("@PrescriptionName", Path.GetFileName(filePath1))
                    'cmd.Parameters.AddWithValue("@SellerCertData", fileData1)
                    cmd.Parameters.AddWithValue("@PrescriptionData", OleDbType.VarBinary).Value = fileData1
                    command.ExecuteNonQuery()
                End Using
            Catch ex As Exception
                ' Handle any exceptions
            Finally
                conn.Close()
            End Try
        End If


    End Sub

    Private Function GetSellerEmailFromDatabase(itemName As String) As String
        Dim sellerEmail As String = ""

        Try
            conn.Open()
            Dim query As String = "SELECT SellerEmail FROM DatabaseItem WHERE ItemName = @ItemName"

            Using command As New OleDbCommand(query, conn)
                command.Parameters.AddWithValue("@ItemName", itemName)
                Dim result As Object = command.ExecuteScalar()

                If result IsNot Nothing AndAlso TypeOf result Is String Then
                    sellerEmail = DirectCast(result, String)
                End If
            End Using
        Catch ex As Exception
            ' Handle any exceptions
        Finally
            conn.Close()
        End Try

        Return sellerEmail
    End Function

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click
        Dim orderID As Integer = GenerateOrderID()

        ' Iterate through the items in the FlowLayoutPanel
        For Each control As Control In FlowLayoutPanel1.Controls
            If TypeOf control Is Panel Then
                Dim panel As Panel = DirectCast(control, Panel)
                Dim itemNameLabel As Label = panel.Controls("itemNameLabel")
                Dim quantityNumericUpDown As NumericUpDown = panel.Controls("quantityNumericUpDown")

                ' Retrieve the item name and quantity from the controls
                Dim itemName As String = itemNameLabel.Text
                Dim quantity As Integer = Convert.ToInt32(quantityNumericUpDown.Value)

                ' Call the AddOrderDetails method to add the order details to the database
                AddOrderDetails(orderID, itemName, quantity)
            End If
        Next

        Dim delivery As New custPAY1(LoggedInUser)
        delivery.GrandTotal = grandTotal
        delivery.Show()
        Me.Hide()
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

    Private _items As ListBox.ObjectCollection
    Public Property Items As ListBox.ObjectCollection
        Get
            Return _items
        End Get
        Set(value As ListBox.ObjectCollection)
            _items = value
        End Set
    End Property

    Public Sub New(Email As String, items As ListBox.ObjectCollection)
        InitializeComponent()
        LoggedInUser = Email
        _items = items
    End Sub


End Class