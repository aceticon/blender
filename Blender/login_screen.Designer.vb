<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class login_screen
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(login_screen))
        Me.lblVersao = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtSenha = New System.Windows.Forms.TextBox()
        Me.txtClose = New System.Windows.Forms.Label()
        Me.ptbLogo = New System.Windows.Forms.PictureBox()
        Me.ptbEmailText = New System.Windows.Forms.PictureBox()
        Me.ptbSenhaText = New System.Windows.Forms.PictureBox()
        Me.ptbEntrar = New System.Windows.Forms.PictureBox()
        Me.ptbEmailLabel = New System.Windows.Forms.PictureBox()
        Me.ptbSenhaLabel = New System.Windows.Forms.PictureBox()
        Me.ptbEsqSenha = New System.Windows.Forms.PictureBox()
        CType(Me.ptbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptbEmailText, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptbSenhaText, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptbEntrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptbEmailLabel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptbSenhaLabel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptbEsqSenha, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblVersao
        '
        Me.lblVersao.AutoSize = True
        Me.lblVersao.BackColor = System.Drawing.Color.Transparent
        Me.lblVersao.Font = New System.Drawing.Font("Marlin Geo Medium", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblVersao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblVersao.Location = New System.Drawing.Point(18, 175)
        Me.lblVersao.Margin = New System.Windows.Forms.Padding(0)
        Me.lblVersao.Name = "lblVersao"
        Me.lblVersao.Size = New System.Drawing.Size(65, 19)
        Me.lblVersao.TabIndex = 3
        Me.lblVersao.Text = "v. 1.3.5.1"
        '
        'txtEmail
        '
        Me.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEmail.Font = New System.Drawing.Font("Marlin Geo Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtEmail.Location = New System.Drawing.Point(126, 101)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(0)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(149, 21)
        Me.txtEmail.TabIndex = 5
        '
        'txtSenha
        '
        Me.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSenha.Font = New System.Drawing.Font("Marlin Geo Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtSenha.Location = New System.Drawing.Point(126, 140)
        Me.txtSenha.Margin = New System.Windows.Forms.Padding(0)
        Me.txtSenha.Name = "txtSenha"
        Me.txtSenha.Size = New System.Drawing.Size(149, 21)
        Me.txtSenha.TabIndex = 6
        Me.txtSenha.UseSystemPasswordChar = True
        '
        'txtClose
        '
        Me.txtClose.AutoSize = True
        Me.txtClose.BackColor = System.Drawing.Color.Transparent
        Me.txtClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtClose.Font = New System.Drawing.Font("Marlin Geo Medium", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.txtClose.Location = New System.Drawing.Point(375, 13)
        Me.txtClose.Margin = New System.Windows.Forms.Padding(0)
        Me.txtClose.Name = "txtClose"
        Me.txtClose.Size = New System.Drawing.Size(20, 19)
        Me.txtClose.TabIndex = 10
        Me.txtClose.Text = "X"
        '
        'ptbLogo
        '
        Me.ptbLogo.BackColor = System.Drawing.Color.Transparent
        Me.ptbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ptbLogo.Image = Global.Blender.My.Resources.Resources.logo
        Me.ptbLogo.Location = New System.Drawing.Point(-17, -100)
        Me.ptbLogo.Name = "ptbLogo"
        Me.ptbLogo.Size = New System.Drawing.Size(395, 196)
        Me.ptbLogo.TabIndex = 12
        Me.ptbLogo.TabStop = False
        '
        'ptbEmailText
        '
        Me.ptbEmailText.Image = Global.Blender.My.Resources.Resources.textbox
        Me.ptbEmailText.Location = New System.Drawing.Point(117, 95)
        Me.ptbEmailText.Name = "ptbEmailText"
        Me.ptbEmailText.Size = New System.Drawing.Size(167, 32)
        Me.ptbEmailText.TabIndex = 13
        Me.ptbEmailText.TabStop = False
        '
        'ptbSenhaText
        '
        Me.ptbSenhaText.Image = Global.Blender.My.Resources.Resources.textbox
        Me.ptbSenhaText.Location = New System.Drawing.Point(117, 134)
        Me.ptbSenhaText.Name = "ptbSenhaText"
        Me.ptbSenhaText.Size = New System.Drawing.Size(167, 32)
        Me.ptbSenhaText.TabIndex = 14
        Me.ptbSenhaText.TabStop = False
        '
        'ptbEntrar
        '
        Me.ptbEntrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ptbEntrar.Image = Global.Blender.My.Resources.Resources.entrar
        Me.ptbEntrar.Location = New System.Drawing.Point(296, 116)
        Me.ptbEntrar.Name = "ptbEntrar"
        Me.ptbEntrar.Size = New System.Drawing.Size(87, 32)
        Me.ptbEntrar.TabIndex = 15
        Me.ptbEntrar.TabStop = False
        '
        'ptbEmailLabel
        '
        Me.ptbEmailLabel.Image = Global.Blender.My.Resources.Resources.email
        Me.ptbEmailLabel.Location = New System.Drawing.Point(18, 95)
        Me.ptbEmailLabel.Name = "ptbEmailLabel"
        Me.ptbEmailLabel.Size = New System.Drawing.Size(87, 32)
        Me.ptbEmailLabel.TabIndex = 16
        Me.ptbEmailLabel.TabStop = False
        '
        'ptbSenhaLabel
        '
        Me.ptbSenhaLabel.Image = Global.Blender.My.Resources.Resources.senha
        Me.ptbSenhaLabel.Location = New System.Drawing.Point(18, 138)
        Me.ptbSenhaLabel.Name = "ptbSenhaLabel"
        Me.ptbSenhaLabel.Size = New System.Drawing.Size(87, 32)
        Me.ptbSenhaLabel.TabIndex = 17
        Me.ptbSenhaLabel.TabStop = False
        '
        'ptbEsqSenha
        '
        Me.ptbEsqSenha.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ptbEsqSenha.Image = Global.Blender.My.Resources.Resources.esquecisenha
        Me.ptbEsqSenha.Location = New System.Drawing.Point(141, 177)
        Me.ptbEsqSenha.Name = "ptbEsqSenha"
        Me.ptbEsqSenha.Size = New System.Drawing.Size(116, 19)
        Me.ptbEsqSenha.TabIndex = 18
        Me.ptbEsqSenha.TabStop = False
        '
        'login_screen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(400, 200)
        Me.Controls.Add(Me.ptbEsqSenha)
        Me.Controls.Add(Me.ptbSenhaLabel)
        Me.Controls.Add(Me.ptbEmailLabel)
        Me.Controls.Add(Me.ptbEntrar)
        Me.Controls.Add(Me.txtClose)
        Me.Controls.Add(Me.txtSenha)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.lblVersao)
        Me.Controls.Add(Me.ptbLogo)
        Me.Controls.Add(Me.ptbEmailText)
        Me.Controls.Add(Me.ptbSenhaText)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "login_screen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Blender - Tela de Login"
        CType(Me.ptbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptbEmailText, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptbSenhaText, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptbEntrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptbEmailLabel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptbSenhaLabel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptbEsqSenha, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblVersao As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtSenha As TextBox
    Friend WithEvents txtClose As Label
    Friend WithEvents ptbLogo As PictureBox
    Friend WithEvents ptbEmailText As PictureBox
    Friend WithEvents ptbSenhaText As PictureBox
    Friend WithEvents ptbEntrar As PictureBox
    Friend WithEvents ptbEmailLabel As PictureBox
    Friend WithEvents ptbSenhaLabel As PictureBox
    Friend WithEvents ptbEsqSenha As PictureBox
End Class
