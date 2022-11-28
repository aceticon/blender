<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLoginScreen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLoginScreen))
        Me.ptbLogo = New System.Windows.Forms.PictureBox()
        Me.lblClose = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.ptbEmailLabel = New System.Windows.Forms.PictureBox()
        Me.ptbSenhaLabel = New System.Windows.Forms.PictureBox()
        Me.ptbEntrar = New System.Windows.Forms.PictureBox()
        Me.ptbEsqSenha = New System.Windows.Forms.PictureBox()
        Me.ptbEmail = New System.Windows.Forms.PictureBox()
        Me.ptbSenha = New System.Windows.Forms.PictureBox()
        Me.txtSenha = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.ptbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptbEmailLabel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptbSenhaLabel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptbEntrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptbEsqSenha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptbEmail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptbSenha, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ptbLogo
        '
        Me.ptbLogo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ptbLogo.Image = CType(resources.GetObject("ptbLogo.Image"), System.Drawing.Image)
        Me.ptbLogo.Location = New System.Drawing.Point(-17, -131)
        Me.ptbLogo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ptbLogo.Name = "ptbLogo"
        Me.ptbLogo.Size = New System.Drawing.Size(489, 308)
        Me.ptbLogo.TabIndex = 1
        Me.ptbLogo.TabStop = False
        '
        'lblClose
        '
        Me.lblClose.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblClose.AutoSize = True
        Me.lblClose.BackColor = System.Drawing.Color.Transparent
        Me.lblClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.lblClose.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.lblClose.Location = New System.Drawing.Point(429, 17)
        Me.lblClose.Name = "lblClose"
        Me.lblClose.Size = New System.Drawing.Size(19, 18)
        Me.lblClose.TabIndex = 0
        Me.lblClose.Text = "X"
        '
        'txtEmail
        '
        Me.txtEmail.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtEmail.Location = New System.Drawing.Point(144, 136)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(170, 17)
        Me.txtEmail.TabIndex = 2
        Me.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ptbEmailLabel
        '
        Me.ptbEmailLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ptbEmailLabel.BackColor = System.Drawing.Color.Transparent
        Me.ptbEmailLabel.Image = CType(resources.GetObject("ptbEmailLabel.Image"), System.Drawing.Image)
        Me.ptbEmailLabel.Location = New System.Drawing.Point(21, 127)
        Me.ptbEmailLabel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ptbEmailLabel.Name = "ptbEmailLabel"
        Me.ptbEmailLabel.Size = New System.Drawing.Size(99, 43)
        Me.ptbEmailLabel.TabIndex = 4
        Me.ptbEmailLabel.TabStop = False
        '
        'ptbSenhaLabel
        '
        Me.ptbSenhaLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ptbSenhaLabel.BackColor = System.Drawing.Color.Transparent
        Me.ptbSenhaLabel.Image = CType(resources.GetObject("ptbSenhaLabel.Image"), System.Drawing.Image)
        Me.ptbSenhaLabel.Location = New System.Drawing.Point(21, 184)
        Me.ptbSenhaLabel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ptbSenhaLabel.Name = "ptbSenhaLabel"
        Me.ptbSenhaLabel.Size = New System.Drawing.Size(99, 43)
        Me.ptbSenhaLabel.TabIndex = 5
        Me.ptbSenhaLabel.TabStop = False
        '
        'ptbEntrar
        '
        Me.ptbEntrar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ptbEntrar.BackColor = System.Drawing.Color.Transparent
        Me.ptbEntrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ptbEntrar.Image = CType(resources.GetObject("ptbEntrar.Image"), System.Drawing.Image)
        Me.ptbEntrar.Location = New System.Drawing.Point(338, 155)
        Me.ptbEntrar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ptbEntrar.Name = "ptbEntrar"
        Me.ptbEntrar.Size = New System.Drawing.Size(99, 43)
        Me.ptbEntrar.TabIndex = 6
        Me.ptbEntrar.TabStop = False
        '
        'ptbEsqSenha
        '
        Me.ptbEsqSenha.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ptbEsqSenha.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ptbEsqSenha.Image = CType(resources.GetObject("ptbEsqSenha.Image"), System.Drawing.Image)
        Me.ptbEsqSenha.Location = New System.Drawing.Point(161, 236)
        Me.ptbEsqSenha.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ptbEsqSenha.Name = "ptbEsqSenha"
        Me.ptbEsqSenha.Size = New System.Drawing.Size(133, 25)
        Me.ptbEsqSenha.TabIndex = 7
        Me.ptbEsqSenha.TabStop = False
        '
        'ptbEmail
        '
        Me.ptbEmail.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ptbEmail.Image = CType(resources.GetObject("ptbEmail.Image"), System.Drawing.Image)
        Me.ptbEmail.Location = New System.Drawing.Point(134, 127)
        Me.ptbEmail.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ptbEmail.Name = "ptbEmail"
        Me.ptbEmail.Size = New System.Drawing.Size(191, 43)
        Me.ptbEmail.TabIndex = 8
        Me.ptbEmail.TabStop = False
        '
        'ptbSenha
        '
        Me.ptbSenha.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ptbSenha.Image = CType(resources.GetObject("ptbSenha.Image"), System.Drawing.Image)
        Me.ptbSenha.Location = New System.Drawing.Point(134, 185)
        Me.ptbSenha.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ptbSenha.Name = "ptbSenha"
        Me.ptbSenha.Size = New System.Drawing.Size(191, 43)
        Me.ptbSenha.TabIndex = 9
        Me.ptbSenha.TabStop = False
        '
        'txtSenha
        '
        Me.txtSenha.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSenha.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtSenha.Location = New System.Drawing.Point(144, 195)
        Me.txtSenha.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtSenha.Name = "txtSenha"
        Me.txtSenha.Size = New System.Drawing.Size(170, 17)
        Me.txtSenha.TabIndex = 10
        Me.txtSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtSenha.UseSystemPasswordChar = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(21, 241)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 16)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "v. 1.0.0.0"
        '
        'frmLoginScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(457, 267)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtSenha)
        Me.Controls.Add(Me.ptbSenha)
        Me.Controls.Add(Me.ptbEsqSenha)
        Me.Controls.Add(Me.ptbEntrar)
        Me.Controls.Add(Me.ptbSenhaLabel)
        Me.Controls.Add(Me.ptbEmailLabel)
        Me.Controls.Add(Me.lblClose)
        Me.Controls.Add(Me.ptbEmail)
        Me.Controls.Add(Me.ptbLogo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmLoginScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Blender - Login"
        CType(Me.ptbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptbEmailLabel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptbSenhaLabel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptbEntrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptbEsqSenha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptbEmail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptbSenha, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ptbLogo As PictureBox
    Friend WithEvents lblClose As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents ptbEmailLabel As PictureBox
    Friend WithEvents ptbSenhaLabel As PictureBox
    Friend WithEvents ptbEntrar As PictureBox
    Friend WithEvents ptbEsqSenha As PictureBox
    Friend WithEvents ptbEmail As PictureBox
    Friend WithEvents ptbSenha As PictureBox
    Friend WithEvents txtSenha As TextBox
    Friend WithEvents Label1 As Label
End Class
