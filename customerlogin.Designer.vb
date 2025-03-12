<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class customerlogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(customerlogin))
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.lblForgPasGuest = New System.Windows.Forms.Label()
        Me.lblRegGuest = New System.Windows.Forms.Label()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtEmailG = New System.Windows.Forms.TextBox()
        Me.GunaElipse2 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.maskPasswordG = New System.Windows.Forms.MaskedTextBox()
        Me.btnBack = New System.Windows.Forms.PictureBox()
        Me.picEye = New System.Windows.Forms.PictureBox()
        Me.picClose2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.btnBack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picEye, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picClose2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaElipse1
        '
        Me.GunaElipse1.TargetControl = Me
        '
        'lblForgPasGuest
        '
        Me.lblForgPasGuest.AutoSize = True
        Me.lblForgPasGuest.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblForgPasGuest.Location = New System.Drawing.Point(489, 368)
        Me.lblForgPasGuest.Name = "lblForgPasGuest"
        Me.lblForgPasGuest.Size = New System.Drawing.Size(156, 16)
        Me.lblForgPasGuest.TabIndex = 60
        Me.lblForgPasGuest.Text = "FORGOT PASSWORD ?"
        '
        'lblRegGuest
        '
        Me.lblRegGuest.AutoSize = True
        Me.lblRegGuest.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblRegGuest.Location = New System.Drawing.Point(436, 344)
        Me.lblRegGuest.Name = "lblRegGuest"
        Me.lblRegGuest.Size = New System.Drawing.Size(244, 16)
        Me.lblRegGuest.TabIndex = 59
        Me.lblRegGuest.Text = "NO ACCOUNT YET ? REGISTER NOW"
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.PeachPuff
        Me.btnLogin.Location = New System.Drawing.Point(521, 283)
        Me.btnLogin.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(96, 35)
        Me.btnLogin.TabIndex = 58
        Me.btnLogin.Text = "LOGIN"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(323, 243)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 16)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "Password :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(350, 207)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 16)
        Me.Label1.TabIndex = 56
        Me.Label1.Text = "Email :"
        '
        'txtEmailG
        '
        Me.txtEmailG.Location = New System.Drawing.Point(410, 205)
        Me.txtEmailG.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtEmailG.Name = "txtEmailG"
        Me.txtEmailG.Size = New System.Drawing.Size(315, 22)
        Me.txtEmailG.TabIndex = 55
        '
        'GunaElipse2
        '
        Me.GunaElipse2.TargetControl = Me
        '
        'maskPasswordG
        '
        Me.maskPasswordG.Location = New System.Drawing.Point(410, 243)
        Me.maskPasswordG.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.maskPasswordG.Name = "maskPasswordG"
        Me.maskPasswordG.Size = New System.Drawing.Size(274, 22)
        Me.maskPasswordG.TabIndex = 62
        '
        'btnBack
        '
        Me.btnBack.Image = Global.techcare.My.Resources.Resources.icons8_arrow_60
        Me.btnBack.Location = New System.Drawing.Point(233, 3)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(30, 31)
        Me.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnBack.TabIndex = 64
        Me.btnBack.TabStop = False
        '
        'picEye
        '
        Me.picEye.Image = Global.techcare.My.Resources.Resources.view
        Me.picEye.Location = New System.Drawing.Point(695, 243)
        Me.picEye.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.picEye.Name = "picEye"
        Me.picEye.Size = New System.Drawing.Size(30, 21)
        Me.picEye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picEye.TabIndex = 63
        Me.picEye.TabStop = False
        '
        'picClose2
        '
        Me.picClose2.Image = CType(resources.GetObject("picClose2.Image"), System.Drawing.Image)
        Me.picClose2.Location = New System.Drawing.Point(781, 11)
        Me.picClose2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.picClose2.Name = "picClose2"
        Me.picClose2.Size = New System.Drawing.Size(29, 23)
        Me.picClose2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picClose2.TabIndex = 61
        Me.picClose2.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(256, -7)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(539, 190)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 54
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-72, -7)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(285, 432)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 53
        Me.PictureBox1.TabStop = False
        '
        'customerlogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(822, 418)
        Me.Controls.Add(Me.lblForgPasGuest)
        Me.Controls.Add(Me.lblRegGuest)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtEmailG)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.picEye)
        Me.Controls.Add(Me.maskPasswordG)
        Me.Controls.Add(Me.picClose2)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "customerlogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "customerlogin"
        CType(Me.btnBack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picEye, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picClose2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents lblForgPasGuest As Label
    Friend WithEvents lblRegGuest As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtEmailG As TextBox
    Friend WithEvents btnBack As PictureBox
    Friend WithEvents picEye As PictureBox
    Friend WithEvents maskPasswordG As MaskedTextBox
    Friend WithEvents picClose2 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GunaElipse2 As Guna.UI.WinForms.GunaElipse
End Class
