<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sellerlogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(sellerlogin))
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.lblForgPasSeller = New System.Windows.Forms.Label()
        Me.lblRegSeller = New System.Windows.Forms.Label()
        Me.btnLoginS = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.maskPasswordS = New System.Windows.Forms.MaskedTextBox()
        Me.txtEmailS = New System.Windows.Forms.TextBox()
        Me.GunaElipse2 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.picBack = New System.Windows.Forms.PictureBox()
        Me.picEye = New System.Windows.Forms.PictureBox()
        Me.btnClose = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.picBack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picEye, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaElipse1
        '
        Me.GunaElipse1.TargetControl = Me
        '
        'lblForgPasSeller
        '
        Me.lblForgPasSeller.AutoSize = True
        Me.lblForgPasSeller.Location = New System.Drawing.Point(522, 376)
        Me.lblForgPasSeller.Name = "lblForgPasSeller"
        Me.lblForgPasSeller.Size = New System.Drawing.Size(156, 16)
        Me.lblForgPasSeller.TabIndex = 60
        Me.lblForgPasSeller.Text = "FORGOT PASSWORD ?"
        '
        'lblRegSeller
        '
        Me.lblRegSeller.AutoSize = True
        Me.lblRegSeller.Location = New System.Drawing.Point(468, 352)
        Me.lblRegSeller.Name = "lblRegSeller"
        Me.lblRegSeller.Size = New System.Drawing.Size(244, 16)
        Me.lblRegSeller.TabIndex = 59
        Me.lblRegSeller.Text = "NO ACCOUNT YET ? REGISTER NOW"
        '
        'btnLoginS
        '
        Me.btnLoginS.BackColor = System.Drawing.Color.PeachPuff
        Me.btnLoginS.Location = New System.Drawing.Point(554, 290)
        Me.btnLoginS.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnLoginS.Name = "btnLoginS"
        Me.btnLoginS.Size = New System.Drawing.Size(96, 35)
        Me.btnLoginS.TabIndex = 58
        Me.btnLoginS.Text = "LOGIN"
        Me.btnLoginS.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(355, 250)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 16)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "Password :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(382, 215)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 16)
        Me.Label1.TabIndex = 56
        Me.Label1.Text = "Email :"
        '
        'maskPasswordS
        '
        Me.maskPasswordS.Location = New System.Drawing.Point(443, 248)
        Me.maskPasswordS.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.maskPasswordS.Name = "maskPasswordS"
        Me.maskPasswordS.Size = New System.Drawing.Size(273, 22)
        Me.maskPasswordS.TabIndex = 55
        '
        'txtEmailS
        '
        Me.txtEmailS.Location = New System.Drawing.Point(443, 212)
        Me.txtEmailS.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtEmailS.Name = "txtEmailS"
        Me.txtEmailS.Size = New System.Drawing.Size(315, 22)
        Me.txtEmailS.TabIndex = 54
        '
        'GunaElipse2
        '
        Me.GunaElipse2.TargetControl = Me
        '
        'picBack
        '
        Me.picBack.Image = Global.techcare.My.Resources.Resources.icons8_arrow_50__1_
        Me.picBack.Location = New System.Drawing.Point(302, 10)
        Me.picBack.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.picBack.Name = "picBack"
        Me.picBack.Size = New System.Drawing.Size(30, 21)
        Me.picBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBack.TabIndex = 63
        Me.picBack.TabStop = False
        '
        'picEye
        '
        Me.picEye.Image = Global.techcare.My.Resources.Resources.view
        Me.picEye.Location = New System.Drawing.Point(727, 248)
        Me.picEye.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.picEye.Name = "picEye"
        Me.picEye.Size = New System.Drawing.Size(30, 21)
        Me.picEye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picEye.TabIndex = 62
        Me.picEye.TabStop = False
        '
        'btnClose
        '
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.Location = New System.Drawing.Point(808, 10)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(29, 23)
        Me.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnClose.TabIndex = 61
        Me.btnClose.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(289, 0)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(539, 190)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 53
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-2, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(285, 432)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 52
        Me.PictureBox1.TabStop = False
        '
        'sellerlogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(855, 430)
        Me.Controls.Add(Me.lblForgPasSeller)
        Me.Controls.Add(Me.lblRegSeller)
        Me.Controls.Add(Me.btnLoginS)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.maskPasswordS)
        Me.Controls.Add(Me.txtEmailS)
        Me.Controls.Add(Me.picBack)
        Me.Controls.Add(Me.picEye)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "sellerlogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "sellerlogin"
        CType(Me.picBack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picEye, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents lblForgPasSeller As Label
    Friend WithEvents lblRegSeller As Label
    Friend WithEvents btnLoginS As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents maskPasswordS As MaskedTextBox
    Friend WithEvents txtEmailS As TextBox
    Friend WithEvents picBack As PictureBox
    Friend WithEvents picEye As PictureBox
    Friend WithEvents btnClose As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GunaElipse2 As Guna.UI.WinForms.GunaElipse
End Class
