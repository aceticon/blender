<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDashMid
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDashMid))
        Me.ptbLogo = New System.Windows.Forms.PictureBox()
        Me.ptbOfePub = New System.Windows.Forms.PictureBox()
        Me.lblOperacional = New System.Windows.Forms.Label()
        Me.ptbMovFin = New System.Windows.Forms.PictureBox()
        Me.ptbCalcRubi = New System.Windows.Forms.PictureBox()
        Me.ptbBorda = New System.Windows.Forms.PictureBox()
        Me.ptbSair = New System.Windows.Forms.PictureBox()
        CType(Me.ptbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptbOfePub, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptbMovFin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptbCalcRubi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptbBorda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptbSair, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ptbLogo
        '
        Me.ptbLogo.Image = Global.Blender.My.Resources.Resources.Logo_Blend_Azul
        Me.ptbLogo.Location = New System.Drawing.Point(12, 12)
        Me.ptbLogo.Name = "ptbLogo"
        Me.ptbLogo.Size = New System.Drawing.Size(128, 56)
        Me.ptbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ptbLogo.TabIndex = 1
        Me.ptbLogo.TabStop = False
        '
        'ptbOfePub
        '
        Me.ptbOfePub.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ptbOfePub.Image = Global.Blender.My.Resources.Resources.Ofertas_Publicas1
        Me.ptbOfePub.Location = New System.Drawing.Point(587, 482)
        Me.ptbOfePub.Name = "ptbOfePub"
        Me.ptbOfePub.Size = New System.Drawing.Size(128, 103)
        Me.ptbOfePub.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ptbOfePub.TabIndex = 2
        Me.ptbOfePub.TabStop = False
        '
        'lblOperacional
        '
        Me.lblOperacional.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblOperacional.AutoSize = True
        Me.lblOperacional.BackColor = System.Drawing.Color.Transparent
        Me.lblOperacional.Font = New System.Drawing.Font("Marlin Geo Medium", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblOperacional.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.lblOperacional.Location = New System.Drawing.Point(575, 425)
        Me.lblOperacional.Name = "lblOperacional"
        Me.lblOperacional.Size = New System.Drawing.Size(155, 26)
        Me.lblOperacional.TabIndex = 6
        Me.lblOperacional.Text = "OPERACIONAL"
        '
        'ptbMovFin
        '
        Me.ptbMovFin.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.ptbMovFin.BackColor = System.Drawing.Color.Transparent
        Me.ptbMovFin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ptbMovFin.Image = Global.Blender.My.Resources.Resources.Movimentacoes_Financeiras2
        Me.ptbMovFin.Location = New System.Drawing.Point(460, 560)
        Me.ptbMovFin.Name = "ptbMovFin"
        Me.ptbMovFin.Size = New System.Drawing.Size(101, 103)
        Me.ptbMovFin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ptbMovFin.TabIndex = 7
        Me.ptbMovFin.TabStop = False
        '
        'ptbCalcRubi
        '
        Me.ptbCalcRubi.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.ptbCalcRubi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ptbCalcRubi.Image = Global.Blender.My.Resources.Resources.Calculadora_de_Rubi2
        Me.ptbCalcRubi.Location = New System.Drawing.Point(736, 560)
        Me.ptbCalcRubi.Name = "ptbCalcRubi"
        Me.ptbCalcRubi.Size = New System.Drawing.Size(101, 103)
        Me.ptbCalcRubi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ptbCalcRubi.TabIndex = 11
        Me.ptbCalcRubi.TabStop = False
        '
        'ptbBorda
        '
        Me.ptbBorda.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ptbBorda.Image = Global.Blender.My.Resources.Resources.Borda
        Me.ptbBorda.Location = New System.Drawing.Point(432, 396)
        Me.ptbBorda.Name = "ptbBorda"
        Me.ptbBorda.Size = New System.Drawing.Size(428, 289)
        Me.ptbBorda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptbBorda.TabIndex = 12
        Me.ptbBorda.TabStop = False
        '
        'ptbSair
        '
        Me.ptbSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ptbSair.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ptbSair.Image = Global.Blender.My.Resources.Resources.Sair
        Me.ptbSair.Location = New System.Drawing.Point(736, 698)
        Me.ptbSair.Margin = New System.Windows.Forms.Padding(0)
        Me.ptbSair.Name = "ptbSair"
        Me.ptbSair.Size = New System.Drawing.Size(124, 42)
        Me.ptbSair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ptbSair.TabIndex = 13
        Me.ptbSair.TabStop = False
        '
        'frmDashMid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(886, 749)
        Me.Controls.Add(Me.ptbSair)
        Me.Controls.Add(Me.ptbCalcRubi)
        Me.Controls.Add(Me.ptbMovFin)
        Me.Controls.Add(Me.lblOperacional)
        Me.Controls.Add(Me.ptbOfePub)
        Me.Controls.Add(Me.ptbLogo)
        Me.Controls.Add(Me.ptbBorda)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmDashMid"
        Me.Text = "BLENDER - DASHBOARD"
        CType(Me.ptbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptbOfePub, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptbMovFin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptbCalcRubi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptbBorda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptbSair, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ptbLogo As PictureBox
    Friend WithEvents ptbOfePub As PictureBox
    Friend WithEvents lblOperacional As Label
    Friend WithEvents ptbMovFin As PictureBox
    Friend WithEvents ptbCalcRubi As PictureBox
    Friend WithEvents ptbBorda As PictureBox
    Friend WithEvents ptbSair As PictureBox
End Class
