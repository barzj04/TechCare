<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class customerregister
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(customerregister))
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.picBack = New System.Windows.Forms.PictureBox()
        Me.numAge = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rboMale = New System.Windows.Forms.RadioButton()
        Me.rboFemale = New System.Windows.Forms.RadioButton()
        Me.GunaElipse2 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.btnRegC = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.maskAddress = New System.Windows.Forms.MaskedTextBox()
        Me.txtPhoneNo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.maskIC = New System.Windows.Forms.MaskedTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.btnClose = New System.Windows.Forms.PictureBox()
        Me.maskPasswordCu = New System.Windows.Forms.MaskedTextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.picBack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numAge, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaElipse1
        '
        Me.GunaElipse1.TargetControl = Me
        '
        'picBack
        '
        Me.picBack.Image = Global.techcare.My.Resources.Resources.icons8_arrow_60
        Me.picBack.Location = New System.Drawing.Point(297, 11)
        Me.picBack.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.picBack.Name = "picBack"
        Me.picBack.Size = New System.Drawing.Size(30, 21)
        Me.picBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBack.TabIndex = 77
        Me.picBack.TabStop = False
        '
        'numAge
        '
        Me.numAge.Location = New System.Drawing.Point(746, 252)
        Me.numAge.Name = "numAge"
        Me.numAge.Size = New System.Drawing.Size(90, 22)
        Me.numAge.TabIndex = 76
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rboMale)
        Me.GroupBox1.Controls.Add(Me.rboFemale)
        Me.GroupBox1.Location = New System.Drawing.Point(698, 139)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(138, 75)
        Me.GroupBox1.TabIndex = 75
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GENDER :"
        '
        'rboMale
        '
        Me.rboMale.AutoSize = True
        Me.rboMale.Location = New System.Drawing.Point(15, 42)
        Me.rboMale.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rboMale.Name = "rboMale"
        Me.rboMale.Size = New System.Drawing.Size(64, 20)
        Me.rboMale.TabIndex = 51
        Me.rboMale.TabStop = True
        Me.rboMale.Text = "MALE"
        Me.rboMale.UseVisualStyleBackColor = True
        '
        'rboFemale
        '
        Me.rboFemale.AutoSize = True
        Me.rboFemale.Location = New System.Drawing.Point(15, 20)
        Me.rboFemale.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rboFemale.Name = "rboFemale"
        Me.rboFemale.Size = New System.Drawing.Size(81, 20)
        Me.rboFemale.TabIndex = 50
        Me.rboFemale.TabStop = True
        Me.rboFemale.Text = "FEMALE"
        Me.rboFemale.UseVisualStyleBackColor = True
        '
        'GunaElipse2
        '
        Me.GunaElipse2.TargetControl = Me
        '
        'btnRegC
        '
        Me.btnRegC.BackColor = System.Drawing.Color.PeachPuff
        Me.btnRegC.Location = New System.Drawing.Point(723, 366)
        Me.btnRegC.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnRegC.Name = "btnRegC"
        Me.btnRegC.Size = New System.Drawing.Size(113, 33)
        Me.btnRegC.TabIndex = 74
        Me.btnRegC.Text = "REGISTER"
        Me.btnRegC.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(698, 254)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 16)
        Me.Label8.TabIndex = 73
        Me.Label8.Text = "AGE:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(312, 283)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 16)
        Me.Label6.TabIndex = 71
        Me.Label6.Text = "PHONE NO. :"
        '
        'maskAddress
        '
        Me.maskAddress.Location = New System.Drawing.Point(411, 313)
        Me.maskAddress.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.maskAddress.Name = "maskAddress"
        Me.maskAddress.Size = New System.Drawing.Size(262, 22)
        Me.maskAddress.TabIndex = 70
        '
        'txtPhoneNo
        '
        Me.txtPhoneNo.Location = New System.Drawing.Point(411, 278)
        Me.txtPhoneNo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtPhoneNo.Name = "txtPhoneNo"
        Me.txtPhoneNo.Size = New System.Drawing.Size(262, 22)
        Me.txtPhoneNo.TabIndex = 69
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(348, 247)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 16)
        Me.Label3.TabIndex = 68
        Me.Label3.Text = "NO. IC :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(307, 214)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 16)
        Me.Label4.TabIndex = 67
        Me.Label4.Text = "PASSWORD :"
        '
        'maskIC
        '
        Me.maskIC.Location = New System.Drawing.Point(411, 247)
        Me.maskIC.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.maskIC.Name = "maskIC"
        Me.maskIC.Size = New System.Drawing.Size(262, 22)
        Me.maskIC.TabIndex = 66
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(318, 318)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 16)
        Me.Label5.TabIndex = 72
        Me.Label5.Text = "ADDRESS :"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(411, 177)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(262, 22)
        Me.txtEmail.TabIndex = 65
        '
        'btnClose
        '
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.Location = New System.Drawing.Point(806, 9)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(29, 23)
        Me.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnClose.TabIndex = 64
        Me.btnClose.TabStop = False
        '
        'maskPasswordCu
        '
        Me.maskPasswordCu.Location = New System.Drawing.Point(411, 211)
        Me.maskPasswordCu.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.maskPasswordCu.Name = "maskPasswordCu"
        Me.maskPasswordCu.Size = New System.Drawing.Size(262, 22)
        Me.maskPasswordCu.TabIndex = 61
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(411, 139)
        Me.txtName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(262, 22)
        Me.txtName.TabIndex = 60
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(287, -1)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(578, 127)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 59
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-3, -1)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(285, 432)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 58
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(348, 177)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 16)
        Me.Label2.TabIndex = 63
        Me.Label2.Text = "EMAIL :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(350, 141)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 16)
        Me.Label1.TabIndex = 62
        Me.Label1.Text = "NAME :"
        '
        'customerregister
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(863, 430)
        Me.Controls.Add(Me.picBack)
        Me.Controls.Add(Me.numAge)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnRegC)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.maskAddress)
        Me.Controls.Add(Me.txtPhoneNo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.maskIC)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.maskPasswordCu)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "customerregister"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "customerregister"
        CType(Me.picBack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numAge, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents picBack As PictureBox
    Friend WithEvents numAge As NumericUpDown
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rboMale As RadioButton
    Friend WithEvents rboFemale As RadioButton
    Friend WithEvents btnRegC As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents maskAddress As MaskedTextBox
    Friend WithEvents txtPhoneNo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents maskIC As MaskedTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents btnClose As PictureBox
    Friend WithEvents maskPasswordCu As MaskedTextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GunaElipse2 As Guna.UI.WinForms.GunaElipse
End Class
