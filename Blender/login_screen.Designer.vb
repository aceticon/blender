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
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtSenha = New System.Windows.Forms.TextBox()
        Me.txtEsqueciSenha = New System.Windows.Forms.Label()
        Me.txtClose = New System.Windows.Forms.Label()
        Me.btnEntrar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblEmail
        '
        Me.lblEmail.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.lblEmail.Font = New System.Drawing.Font("Marlin Geo Medium", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lblEmail.ForeColor = System.Drawing.Color.White
        Me.lblEmail.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblEmail.Location = New System.Drawing.Point(18, 95)
        Me.lblEmail.Margin = New System.Windows.Forms.Padding(0)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(87, 32)
        Me.lblEmail.TabIndex = 0
        Me.lblEmail.Text = "E-mail"
        Me.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Marlin Geo Medium", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(18, 138)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 32)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Senha"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Marlin Geo Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label2.Location = New System.Drawing.Point(18, 181)
        Me.Label2.Margin = New System.Windows.Forms.Padding(0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "v. 1.3.5.1"
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Marlin Geo Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtEmail.Location = New System.Drawing.Point(117, 95)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(0)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(167, 28)
        Me.txtEmail.TabIndex = 5
        '
        'txtSenha
        '
        Me.txtSenha.Font = New System.Drawing.Font("Marlin Geo Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtSenha.Location = New System.Drawing.Point(117, 138)
        Me.txtSenha.Margin = New System.Windows.Forms.Padding(0)
        Me.txtSenha.Name = "txtSenha"
        Me.txtSenha.Size = New System.Drawing.Size(167, 28)
        Me.txtSenha.TabIndex = 6
        Me.txtSenha.UseSystemPasswordChar = True
        '
        'txtEsqueciSenha
        '
        Me.txtEsqueciSenha.AutoSize = True
        Me.txtEsqueciSenha.BackColor = System.Drawing.Color.Transparent
        Me.txtEsqueciSenha.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtEsqueciSenha.Font = New System.Drawing.Font("Marlin Geo Medium", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.txtEsqueciSenha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.txtEsqueciSenha.Location = New System.Drawing.Point(141, 177)
        Me.txtEsqueciSenha.Margin = New System.Windows.Forms.Padding(0)
        Me.txtEsqueciSenha.Name = "txtEsqueciSenha"
        Me.txtEsqueciSenha.Size = New System.Drawing.Size(130, 19)
        Me.txtEsqueciSenha.TabIndex = 8
        Me.txtEsqueciSenha.Text = "Esqueci a senha"
        Me.txtEsqueciSenha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        'btnEntrar
        '
        Me.btnEntrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btnEntrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEntrar.Font = New System.Drawing.Font("Marlin Geo Medium", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.btnEntrar.ForeColor = System.Drawing.Color.White
        Me.btnEntrar.Location = New System.Drawing.Point(296, 116)
        Me.btnEntrar.Margin = New System.Windows.Forms.Padding(0)
        Me.btnEntrar.Name = "btnEntrar"
        Me.btnEntrar.Size = New System.Drawing.Size(87, 32)
        Me.btnEntrar.TabIndex = 11
        Me.btnEntrar.Text = "Entrar"
        Me.btnEntrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEntrar.UseVisualStyleBackColor = False
        '
        'login_screen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(400, 200)
        Me.Controls.Add(Me.btnEntrar)
        Me.Controls.Add(Me.txtClose)
        Me.Controls.Add(Me.txtEsqueciSenha)
        Me.Controls.Add(Me.txtSenha)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblEmail)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "login_screen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Blender - Tela de Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblEmail As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtSenha As TextBox
    Friend WithEvents txtEsqueciSenha As Label
    Friend WithEvents txtClose As Label
    Friend WithEvents btnEntrar As Button
End Class
