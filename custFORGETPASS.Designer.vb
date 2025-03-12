<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class custFORGETPASS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(custFORGETPASS))
        Me.txtNewPassword = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnSendCode = New Guna.UI.WinForms.GunaLinkLabel()
        Me.txtCode = New Guna.UI.WinForms.GunaTextBox()
        Me.txtEmailG = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaElipse8 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaElipse7 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.btnBack = New Guna.UI.WinForms.GunaPictureBox()
        Me.GunaPictureBox1 = New Guna.UI.WinForms.GunaPictureBox()
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.GunaElipse6 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.GunaElipse4 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.GunaElipse3 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.GunaElipse2 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.GunaElipse5 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.btnClose = New System.Windows.Forms.PictureBox()
        CType(Me.btnBack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtNewPassword
        '
        Me.txtNewPassword.BaseColor = System.Drawing.Color.White
        Me.txtNewPassword.BorderColor = System.Drawing.Color.Silver
        Me.txtNewPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNewPassword.FocusedBaseColor = System.Drawing.Color.White
        Me.txtNewPassword.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNewPassword.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtNewPassword.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtNewPassword.Location = New System.Drawing.Point(215, 337)
        Me.txtNewPassword.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNewPassword.Name = "txtNewPassword"
        Me.txtNewPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNewPassword.SelectedText = ""
        Me.txtNewPassword.Size = New System.Drawing.Size(404, 30)
        Me.txtNewPassword.TabIndex = 121
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel3.Location = New System.Drawing.Point(89, 337)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(111, 20)
        Me.GunaLabel3.TabIndex = 120
        Me.GunaLabel3.Text = "New Password :"
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(363, 400)
        Me.btnSubmit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(113, 36)
        Me.btnSubmit.TabIndex = 119
        Me.btnSubmit.Text = "SUBMIT"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'btnSendCode
        '
        Me.btnSendCode.AutoSize = True
        Me.btnSendCode.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnSendCode.Location = New System.Drawing.Point(359, 196)
        Me.btnSendCode.Name = "btnSendCode"
        Me.btnSendCode.Size = New System.Drawing.Size(104, 20)
        Me.btnSendCode.TabIndex = 118
        Me.btnSendCode.TabStop = True
        Me.btnSendCode.Text = "Send me code"
        '
        'txtCode
        '
        Me.txtCode.BaseColor = System.Drawing.Color.White
        Me.txtCode.BorderColor = System.Drawing.Color.Silver
        Me.txtCode.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCode.FocusedBaseColor = System.Drawing.Color.White
        Me.txtCode.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCode.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtCode.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCode.ForeColor = System.Drawing.Color.Gray
        Me.txtCode.Location = New System.Drawing.Point(290, 231)
        Me.txtCode.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCode.SelectedText = ""
        Me.txtCode.Size = New System.Drawing.Size(232, 65)
        Me.txtCode.TabIndex = 114
        Me.txtCode.Text = "0000"
        Me.txtCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEmailG
        '
        Me.txtEmailG.BaseColor = System.Drawing.Color.White
        Me.txtEmailG.BorderColor = System.Drawing.Color.Silver
        Me.txtEmailG.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEmailG.FocusedBaseColor = System.Drawing.Color.White
        Me.txtEmailG.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtEmailG.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtEmailG.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtEmailG.Location = New System.Drawing.Point(215, 156)
        Me.txtEmailG.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtEmailG.Name = "txtEmailG"
        Me.txtEmailG.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEmailG.SelectedText = ""
        Me.txtEmailG.Size = New System.Drawing.Size(404, 30)
        Me.txtEmailG.TabIndex = 113
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel2.Location = New System.Drawing.Point(154, 156)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(53, 20)
        Me.GunaLabel2.TabIndex = 112
        Me.GunaLabel2.Text = "Email :"
        '
        'GunaElipse8
        '
        Me.GunaElipse8.Radius = 10
        Me.GunaElipse8.TargetControl = Me.GunaLabel1
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.BackColor = System.Drawing.Color.Bisque
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel1.Location = New System.Drawing.Point(330, 111)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(146, 20)
        Me.GunaLabel1.TabIndex = 111
        Me.GunaLabel1.Text = "FORGOT PASSWORD"
        '
        'GunaElipse7
        '
        Me.GunaElipse7.Radius = 10
        Me.GunaElipse7.TargetControl = Me
        '
        'btnBack
        '
        Me.btnBack.BaseColor = System.Drawing.Color.White
        Me.btnBack.Image = CType(resources.GetObject("btnBack.Image"), System.Drawing.Image)
        Me.btnBack.Location = New System.Drawing.Point(73, 11)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(48, 40)
        Me.btnBack.TabIndex = 110
        Me.btnBack.TabStop = False
        '
        'GunaPictureBox1
        '
        Me.GunaPictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox1.Image = CType(resources.GetObject("GunaPictureBox1.Image"), System.Drawing.Image)
        Me.GunaPictureBox1.Location = New System.Drawing.Point(335, 11)
        Me.GunaPictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GunaPictureBox1.Name = "GunaPictureBox1"
        Me.GunaPictureBox1.Size = New System.Drawing.Size(156, 98)
        Me.GunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.GunaPictureBox1.TabIndex = 109
        Me.GunaPictureBox1.TabStop = False
        '
        'GunaElipse1
        '
        Me.GunaElipse1.Radius = 10
        Me.GunaElipse1.TargetControl = Me
        '
        'GunaElipse6
        '
        Me.GunaElipse6.Radius = 20
        Me.GunaElipse6.TargetControl = Me
        '
        'GunaElipse4
        '
        Me.GunaElipse4.Radius = 20
        Me.GunaElipse4.TargetControl = Me
        '
        'GunaElipse3
        '
        Me.GunaElipse3.Radius = 20
        Me.GunaElipse3.TargetControl = Me
        '
        'GunaElipse2
        '
        Me.GunaElipse2.Radius = 20
        Me.GunaElipse2.TargetControl = Me
        '
        'GunaElipse5
        '
        Me.GunaElipse5.Radius = 20
        Me.GunaElipse5.TargetControl = Me
        '
        'btnClose
        '
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.Location = New System.Drawing.Point(711, 11)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(29, 23)
        Me.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnClose.TabIndex = 122
        Me.btnClose.TabStop = False
        '
        'custFORGETPASS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(765, 473)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.txtNewPassword)
        Me.Controls.Add(Me.GunaLabel3)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.btnSendCode)
        Me.Controls.Add(Me.txtCode)
        Me.Controls.Add(Me.txtEmailG)
        Me.Controls.Add(Me.GunaLabel2)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.GunaPictureBox1)
        Me.Controls.Add(Me.GunaLabel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "custFORGETPASS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "custFORGETPASS"
        CType(Me.btnBack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNewPassword As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnSendCode As Guna.UI.WinForms.GunaLinkLabel
    Friend WithEvents txtCode As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txtEmailG As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaElipse8 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaElipse7 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents btnBack As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents GunaPictureBox1 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents GunaElipse6 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents GunaElipse4 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents GunaElipse3 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents GunaElipse2 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents GunaElipse5 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents btnClose As PictureBox
End Class
