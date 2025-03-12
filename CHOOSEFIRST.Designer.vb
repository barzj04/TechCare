<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CHOOSEFIRST
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CHOOSEFIRST))
        Me.GunaPanel1 = New Guna.UI.WinForms.GunaPanel()
        Me.btnClose = New Guna.UI.WinForms.GunaPictureBox()
        Me.GunaPictureBox1 = New Guna.UI.WinForms.GunaPictureBox()
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.lblAdminLog = New System.Windows.Forms.Label()
        Me.lblDocLog = New System.Windows.Forms.Label()
        Me.lblPharLog = New System.Windows.Forms.Label()
        Me.lblGuestLog = New System.Windows.Forms.Label()
        Me.picAdmin = New System.Windows.Forms.PictureBox()
        Me.picDoc = New System.Windows.Forms.PictureBox()
        Me.picPhar = New System.Windows.Forms.PictureBox()
        Me.picGuest = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.GunaPanel1.SuspendLayout()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picAdmin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDoc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPhar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picGuest, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaPanel1
        '
        Me.GunaPanel1.BackColor = System.Drawing.Color.AntiqueWhite
        Me.GunaPanel1.Controls.Add(Me.btnClose)
        Me.GunaPanel1.Controls.Add(Me.GunaPictureBox1)
        Me.GunaPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GunaPanel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GunaPanel1.Name = "GunaPanel1"
        Me.GunaPanel1.Size = New System.Drawing.Size(928, 148)
        Me.GunaPanel1.TabIndex = 21
        '
        'btnClose
        '
        Me.btnClose.BaseColor = System.Drawing.Color.White
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.Location = New System.Drawing.Point(833, 9)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(28, 26)
        Me.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnClose.TabIndex = 150
        Me.btnClose.TabStop = False
        '
        'GunaPictureBox1
        '
        Me.GunaPictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox1.ErrorImage = Nothing
        Me.GunaPictureBox1.Image = CType(resources.GetObject("GunaPictureBox1.Image"), System.Drawing.Image)
        Me.GunaPictureBox1.Location = New System.Drawing.Point(141, -57)
        Me.GunaPictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GunaPictureBox1.Name = "GunaPictureBox1"
        Me.GunaPictureBox1.Size = New System.Drawing.Size(619, 283)
        Me.GunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaPictureBox1.TabIndex = 1
        Me.GunaPictureBox1.TabStop = False
        '
        'GunaElipse1
        '
        Me.GunaElipse1.TargetControl = Me
        '
        'lblAdminLog
        '
        Me.lblAdminLog.AutoSize = True
        Me.lblAdminLog.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdminLog.Location = New System.Drawing.Point(680, 357)
        Me.lblAdminLog.Name = "lblAdminLog"
        Me.lblAdminLog.Size = New System.Drawing.Size(70, 25)
        Me.lblAdminLog.TabIndex = 29
        Me.lblAdminLog.Text = "ADMIN"
        '
        'lblDocLog
        '
        Me.lblDocLog.AutoSize = True
        Me.lblDocLog.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDocLog.Location = New System.Drawing.Point(514, 357)
        Me.lblDocLog.Name = "lblDocLog"
        Me.lblDocLog.Size = New System.Drawing.Size(85, 25)
        Me.lblDocLog.TabIndex = 28
        Me.lblDocLog.Text = "DOCTOR"
        '
        'lblPharLog
        '
        Me.lblPharLog.AutoSize = True
        Me.lblPharLog.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPharLog.Location = New System.Drawing.Point(337, 357)
        Me.lblPharLog.Name = "lblPharLog"
        Me.lblPharLog.Size = New System.Drawing.Size(124, 25)
        Me.lblPharLog.TabIndex = 27
        Me.lblPharLog.Text = "PHARMACIST"
        '
        'lblGuestLog
        '
        Me.lblGuestLog.AutoSize = True
        Me.lblGuestLog.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGuestLog.Location = New System.Drawing.Point(191, 357)
        Me.lblGuestLog.Name = "lblGuestLog"
        Me.lblGuestLog.Size = New System.Drawing.Size(69, 25)
        Me.lblGuestLog.TabIndex = 26
        Me.lblGuestLog.Text = "GUEST"
        '
        'picAdmin
        '
        Me.picAdmin.BackColor = System.Drawing.Color.Bisque
        Me.picAdmin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picAdmin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picAdmin.Image = CType(resources.GetObject("picAdmin.Image"), System.Drawing.Image)
        Me.picAdmin.Location = New System.Drawing.Point(647, 206)
        Me.picAdmin.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.picAdmin.Name = "picAdmin"
        Me.picAdmin.Size = New System.Drawing.Size(122, 128)
        Me.picAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picAdmin.TabIndex = 25
        Me.picAdmin.TabStop = False
        '
        'picDoc
        '
        Me.picDoc.BackColor = System.Drawing.Color.Bisque
        Me.picDoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picDoc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picDoc.Image = CType(resources.GetObject("picDoc.Image"), System.Drawing.Image)
        Me.picDoc.Location = New System.Drawing.Point(496, 206)
        Me.picDoc.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.picDoc.Name = "picDoc"
        Me.picDoc.Size = New System.Drawing.Size(124, 128)
        Me.picDoc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picDoc.TabIndex = 24
        Me.picDoc.TabStop = False
        '
        'picPhar
        '
        Me.picPhar.BackColor = System.Drawing.Color.Bisque
        Me.picPhar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picPhar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picPhar.Image = CType(resources.GetObject("picPhar.Image"), System.Drawing.Image)
        Me.picPhar.Location = New System.Drawing.Point(342, 206)
        Me.picPhar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.picPhar.Name = "picPhar"
        Me.picPhar.Size = New System.Drawing.Size(119, 128)
        Me.picPhar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picPhar.TabIndex = 23
        Me.picPhar.TabStop = False
        '
        'picGuest
        '
        Me.picGuest.BackColor = System.Drawing.Color.Bisque
        Me.picGuest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picGuest.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picGuest.Image = CType(resources.GetObject("picGuest.Image"), System.Drawing.Image)
        Me.picGuest.Location = New System.Drawing.Point(166, 206)
        Me.picGuest.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.picGuest.Name = "picGuest"
        Me.picGuest.Size = New System.Drawing.Size(125, 128)
        Me.picGuest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picGuest.TabIndex = 22
        Me.picGuest.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(-120, -43)
        Me.PictureBox5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(1168, 556)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 31
        Me.PictureBox5.TabStop = False
        '
        'CHOOSEFIRST
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(928, 470)
        Me.Controls.Add(Me.GunaPanel1)
        Me.Controls.Add(Me.lblAdminLog)
        Me.Controls.Add(Me.lblDocLog)
        Me.Controls.Add(Me.lblPharLog)
        Me.Controls.Add(Me.lblGuestLog)
        Me.Controls.Add(Me.picAdmin)
        Me.Controls.Add(Me.picDoc)
        Me.Controls.Add(Me.picPhar)
        Me.Controls.Add(Me.picGuest)
        Me.Controls.Add(Me.PictureBox5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CHOOSEFIRST"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CHOOSEFIRST"
        Me.GunaPanel1.ResumeLayout(False)
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picAdmin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDoc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPhar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picGuest, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents btnClose As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents GunaPictureBox1 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents lblAdminLog As Label
    Friend WithEvents lblDocLog As Label
    Private WithEvents lblPharLog As Label
    Friend WithEvents lblGuestLog As Label
    Friend WithEvents picAdmin As PictureBox
    Friend WithEvents picDoc As PictureBox
    Friend WithEvents picPhar As PictureBox
    Friend WithEvents picGuest As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
End Class
