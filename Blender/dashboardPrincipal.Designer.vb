<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDashPrin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDashPrin))
        Me.ptbLogo = New System.Windows.Forms.PictureBox()
        Me.flwMenu = New System.Windows.Forms.FlowLayoutPanel()
        Me.ptbEmailBlend = New System.Windows.Forms.PictureBox()
        Me.ptbBorda = New System.Windows.Forms.PictureBox()
        Me.ptbMiddle = New System.Windows.Forms.PictureBox()
        Me.ptbMovFin = New System.Windows.Forms.PictureBox()
        Me.ptbPrevidencia = New System.Windows.Forms.PictureBox()
        Me.lblPlanOpe = New System.Windows.Forms.Label()
        Me.ptbTranCust = New System.Windows.Forms.PictureBox()
        Me.ptbCadastro = New System.Windows.Forms.PictureBox()
        Me.ptbCalcRubi = New System.Windows.Forms.PictureBox()
        Me.ptbSair = New System.Windows.Forms.PictureBox()
        CType(Me.ptbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.flwMenu.SuspendLayout()
        CType(Me.ptbEmailBlend, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptbBorda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptbMiddle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptbMovFin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptbPrevidencia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptbTranCust, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptbCadastro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptbCalcRubi, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.ptbLogo.TabIndex = 0
        Me.ptbLogo.TabStop = False
        '
        'flwMenu
        '
        Me.flwMenu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.flwMenu.AutoSize = True
        Me.flwMenu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.flwMenu.Controls.Add(Me.ptbEmailBlend)
        Me.flwMenu.Location = New System.Drawing.Point(162, 12)
        Me.flwMenu.Name = "flwMenu"
        Me.flwMenu.Padding = New System.Windows.Forms.Padding(3)
        Me.flwMenu.Size = New System.Drawing.Size(189, 54)
        Me.flwMenu.TabIndex = 1
        '
        'ptbEmailBlend
        '
        Me.ptbEmailBlend.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ptbEmailBlend.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ptbEmailBlend.Image = Global.Blender.My.Resources.Resources.Emails_Blend
        Me.ptbEmailBlend.Location = New System.Drawing.Point(6, 6)
        Me.ptbEmailBlend.Name = "ptbEmailBlend"
        Me.ptbEmailBlend.Size = New System.Drawing.Size(177, 42)
        Me.ptbEmailBlend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ptbEmailBlend.TabIndex = 1
        Me.ptbEmailBlend.TabStop = False
        '
        'ptbBorda
        '
        Me.ptbBorda.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ptbBorda.Image = Global.Blender.My.Resources.Resources.Borda
        Me.ptbBorda.Location = New System.Drawing.Point(723, 86)
        Me.ptbBorda.Name = "ptbBorda"
        Me.ptbBorda.Size = New System.Drawing.Size(543, 448)
        Me.ptbBorda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptbBorda.TabIndex = 2
        Me.ptbBorda.TabStop = False
        '
        'ptbMiddle
        '
        Me.ptbMiddle.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.ptbMiddle.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ptbMiddle.Image = Global.Blender.My.Resources.Resources.Middle
        Me.ptbMiddle.Location = New System.Drawing.Point(951, 199)
        Me.ptbMiddle.Name = "ptbMiddle"
        Me.ptbMiddle.Size = New System.Drawing.Size(87, 102)
        Me.ptbMiddle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ptbMiddle.TabIndex = 7
        Me.ptbMiddle.TabStop = False
        '
        'ptbMovFin
        '
        Me.ptbMovFin.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.ptbMovFin.BackColor = System.Drawing.Color.Transparent
        Me.ptbMovFin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ptbMovFin.Image = Global.Blender.My.Resources.Resources.Movimentacoes_Financeiras
        Me.ptbMovFin.Location = New System.Drawing.Point(786, 317)
        Me.ptbMovFin.Name = "ptbMovFin"
        Me.ptbMovFin.Size = New System.Drawing.Size(101, 103)
        Me.ptbMovFin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ptbMovFin.TabIndex = 5
        Me.ptbMovFin.TabStop = False
        '
        'ptbPrevidencia
        '
        Me.ptbPrevidencia.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.ptbPrevidencia.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ptbPrevidencia.Image = Global.Blender.My.Resources.Resources.Previdencia
        Me.ptbPrevidencia.Location = New System.Drawing.Point(1107, 199)
        Me.ptbPrevidencia.Name = "ptbPrevidencia"
        Me.ptbPrevidencia.Size = New System.Drawing.Size(87, 102)
        Me.ptbPrevidencia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ptbPrevidencia.TabIndex = 8
        Me.ptbPrevidencia.TabStop = False
        '
        'lblPlanOpe
        '
        Me.lblPlanOpe.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPlanOpe.AutoSize = True
        Me.lblPlanOpe.BackColor = System.Drawing.Color.White
        Me.lblPlanOpe.Font = New System.Drawing.Font("Marlin Geo Medium", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblPlanOpe.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.lblPlanOpe.Location = New System.Drawing.Point(880, 129)
        Me.lblPlanOpe.Name = "lblPlanOpe"
        Me.lblPlanOpe.Size = New System.Drawing.Size(256, 26)
        Me.lblPlanOpe.TabIndex = 4
        Me.lblPlanOpe.Text = "PLANILHA OPERACIONAL"
        '
        'ptbTranCust
        '
        Me.ptbTranCust.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.ptbTranCust.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ptbTranCust.Image = Global.Blender.My.Resources.Resources.Tranferencia_de_Custodia
        Me.ptbTranCust.Location = New System.Drawing.Point(944, 317)
        Me.ptbTranCust.Name = "ptbTranCust"
        Me.ptbTranCust.Size = New System.Drawing.Size(101, 103)
        Me.ptbTranCust.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ptbTranCust.TabIndex = 9
        Me.ptbTranCust.TabStop = False
        '
        'ptbCadastro
        '
        Me.ptbCadastro.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.ptbCadastro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ptbCadastro.Image = Global.Blender.My.Resources.Resources.Cadastro
        Me.ptbCadastro.Location = New System.Drawing.Point(793, 199)
        Me.ptbCadastro.Name = "ptbCadastro"
        Me.ptbCadastro.Size = New System.Drawing.Size(87, 102)
        Me.ptbCadastro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ptbCadastro.TabIndex = 3
        Me.ptbCadastro.TabStop = False
        '
        'ptbCalcRubi
        '
        Me.ptbCalcRubi.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.ptbCalcRubi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ptbCalcRubi.Image = Global.Blender.My.Resources.Resources.Calculadora_de_Rubi
        Me.ptbCalcRubi.Location = New System.Drawing.Point(1100, 317)
        Me.ptbCalcRubi.Name = "ptbCalcRubi"
        Me.ptbCalcRubi.Size = New System.Drawing.Size(101, 103)
        Me.ptbCalcRubi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ptbCalcRubi.TabIndex = 10
        Me.ptbCalcRubi.TabStop = False
        '
        'ptbSair
        '
        Me.ptbSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ptbSair.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ptbSair.Image = Global.Blender.My.Resources.Resources.Sair
        Me.ptbSair.Location = New System.Drawing.Point(1142, 547)
        Me.ptbSair.Margin = New System.Windows.Forms.Padding(0)
        Me.ptbSair.Name = "ptbSair"
        Me.ptbSair.Size = New System.Drawing.Size(124, 42)
        Me.ptbSair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ptbSair.TabIndex = 11
        Me.ptbSair.TabStop = False
        '
        'frmDashPrin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1284, 598)
        Me.Controls.Add(Me.ptbSair)
        Me.Controls.Add(Me.ptbLogo)
        Me.Controls.Add(Me.flwMenu)
        Me.Controls.Add(Me.lblPlanOpe)
        Me.Controls.Add(Me.ptbPrevidencia)
        Me.Controls.Add(Me.ptbMiddle)
        Me.Controls.Add(Me.ptbMovFin)
        Me.Controls.Add(Me.ptbCalcRubi)
        Me.Controls.Add(Me.ptbCadastro)
        Me.Controls.Add(Me.ptbTranCust)
        Me.Controls.Add(Me.ptbBorda)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmDashPrin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BLENDER - DASHBOARD"
        CType(Me.ptbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.flwMenu.ResumeLayout(False)
        CType(Me.ptbEmailBlend, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptbBorda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptbMiddle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptbMovFin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptbPrevidencia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptbTranCust, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptbCadastro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptbCalcRubi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptbSair, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ptbLogo As PictureBox
    Friend WithEvents flwMenu As FlowLayoutPanel
    Friend WithEvents ptbEmailBlend As PictureBox
    Friend WithEvents ptbBorda As PictureBox
    Friend WithEvents ptbMiddle As PictureBox
    Friend WithEvents ptbMovFin As PictureBox
    Friend WithEvents ptbPrevidencia As PictureBox
    Friend WithEvents lblPlanOpe As Label
    Friend WithEvents ptbTranCust As PictureBox
    Friend WithEvents ptbCadastro As PictureBox
    Friend WithEvents ptbCalcRubi As PictureBox
    Friend WithEvents ptbSair As PictureBox
End Class
