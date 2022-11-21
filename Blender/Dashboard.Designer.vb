<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDashboard))
        Me.ptbLogo = New System.Windows.Forms.PictureBox()
        Me.flwMenu = New System.Windows.Forms.FlowLayoutPanel()
        Me.ptbHorXP = New System.Windows.Forms.PictureBox()
        Me.ptbEmailBlend = New System.Windows.Forms.PictureBox()
        Me.ptbEmailXP = New System.Windows.Forms.PictureBox()
        Me.ptbTutorial = New System.Windows.Forms.PictureBox()
        Me.ptbStatDeman = New System.Windows.Forms.PictureBox()
        Me.ptbResgExpress = New System.Windows.Forms.PictureBox()
        Me.ptbBorda = New System.Windows.Forms.PictureBox()
        Me.ptbCadastro = New System.Windows.Forms.PictureBox()
        Me.lblPlanOpe = New System.Windows.Forms.Label()
        Me.ptbContBol = New System.Windows.Forms.PictureBox()
        Me.ptbMiddle = New System.Windows.Forms.PictureBox()
        Me.ptbPrevidencia = New System.Windows.Forms.PictureBox()
        Me.ptbMovFin = New System.Windows.Forms.PictureBox()
        Me.ptbTranCust = New System.Windows.Forms.PictureBox()
        Me.ptbCalcRubi = New System.Windows.Forms.PictureBox()
        CType(Me.ptbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.flwMenu.SuspendLayout()
        CType(Me.ptbHorXP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptbEmailBlend, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptbEmailXP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptbTutorial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptbStatDeman, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptbResgExpress, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptbBorda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptbCadastro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptbContBol, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptbMiddle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptbPrevidencia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptbMovFin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptbTranCust, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptbCalcRubi, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.flwMenu.Controls.Add(Me.ptbHorXP)
        Me.flwMenu.Controls.Add(Me.ptbEmailBlend)
        Me.flwMenu.Controls.Add(Me.ptbEmailXP)
        Me.flwMenu.Controls.Add(Me.ptbTutorial)
        Me.flwMenu.Controls.Add(Me.ptbStatDeman)
        Me.flwMenu.Controls.Add(Me.ptbResgExpress)
        Me.flwMenu.Location = New System.Drawing.Point(157, 12)
        Me.flwMenu.Name = "flwMenu"
        Me.flwMenu.Padding = New System.Windows.Forms.Padding(3)
        Me.flwMenu.Size = New System.Drawing.Size(1115, 56)
        Me.flwMenu.TabIndex = 1
        '
        'ptbHorXP
        '
        Me.ptbHorXP.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ptbHorXP.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ptbHorXP.Image = Global.Blender.My.Resources.Resources.Horario_XP
        Me.ptbHorXP.Location = New System.Drawing.Point(6, 6)
        Me.ptbHorXP.Name = "ptbHorXP"
        Me.ptbHorXP.Size = New System.Drawing.Size(177, 42)
        Me.ptbHorXP.TabIndex = 0
        Me.ptbHorXP.TabStop = False
        '
        'ptbEmailBlend
        '
        Me.ptbEmailBlend.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ptbEmailBlend.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ptbEmailBlend.Image = Global.Blender.My.Resources.Resources.Emails_Blend
        Me.ptbEmailBlend.Location = New System.Drawing.Point(189, 6)
        Me.ptbEmailBlend.Name = "ptbEmailBlend"
        Me.ptbEmailBlend.Size = New System.Drawing.Size(177, 42)
        Me.ptbEmailBlend.TabIndex = 1
        Me.ptbEmailBlend.TabStop = False
        '
        'ptbEmailXP
        '
        Me.ptbEmailXP.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ptbEmailXP.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ptbEmailXP.Image = Global.Blender.My.Resources.Resources.Emails_XP
        Me.ptbEmailXP.Location = New System.Drawing.Point(372, 6)
        Me.ptbEmailXP.Name = "ptbEmailXP"
        Me.ptbEmailXP.Size = New System.Drawing.Size(177, 42)
        Me.ptbEmailXP.TabIndex = 2
        Me.ptbEmailXP.TabStop = False
        '
        'ptbTutorial
        '
        Me.ptbTutorial.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ptbTutorial.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ptbTutorial.Image = Global.Blender.My.Resources.Resources.Tutoriais
        Me.ptbTutorial.Location = New System.Drawing.Point(555, 6)
        Me.ptbTutorial.Name = "ptbTutorial"
        Me.ptbTutorial.Size = New System.Drawing.Size(177, 42)
        Me.ptbTutorial.TabIndex = 3
        Me.ptbTutorial.TabStop = False
        '
        'ptbStatDeman
        '
        Me.ptbStatDeman.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ptbStatDeman.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ptbStatDeman.Image = Global.Blender.My.Resources.Resources.Status_Demandas
        Me.ptbStatDeman.Location = New System.Drawing.Point(738, 6)
        Me.ptbStatDeman.Name = "ptbStatDeman"
        Me.ptbStatDeman.Size = New System.Drawing.Size(177, 42)
        Me.ptbStatDeman.TabIndex = 4
        Me.ptbStatDeman.TabStop = False
        '
        'ptbResgExpress
        '
        Me.ptbResgExpress.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ptbResgExpress.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ptbResgExpress.Image = Global.Blender.My.Resources.Resources.Resgate_Express
        Me.ptbResgExpress.Location = New System.Drawing.Point(921, 6)
        Me.ptbResgExpress.Name = "ptbResgExpress"
        Me.ptbResgExpress.Size = New System.Drawing.Size(177, 42)
        Me.ptbResgExpress.TabIndex = 5
        Me.ptbResgExpress.TabStop = False
        '
        'ptbBorda
        '
        Me.ptbBorda.Image = Global.Blender.My.Resources.Resources.Borda
        Me.ptbBorda.Location = New System.Drawing.Point(712, 88)
        Me.ptbBorda.Name = "ptbBorda"
        Me.ptbBorda.Size = New System.Drawing.Size(543, 418)
        Me.ptbBorda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptbBorda.TabIndex = 2
        Me.ptbBorda.TabStop = False
        '
        'ptbCadastro
        '
        Me.ptbCadastro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ptbCadastro.Image = Global.Blender.My.Resources.Resources.Cadastro
        Me.ptbCadastro.Location = New System.Drawing.Point(782, 172)
        Me.ptbCadastro.Name = "ptbCadastro"
        Me.ptbCadastro.Size = New System.Drawing.Size(87, 102)
        Me.ptbCadastro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ptbCadastro.TabIndex = 3
        Me.ptbCadastro.TabStop = False
        '
        'lblPlanOpe
        '
        Me.lblPlanOpe.AutoSize = True
        Me.lblPlanOpe.BackColor = System.Drawing.Color.Transparent
        Me.lblPlanOpe.Font = New System.Drawing.Font("Marlin Geo", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblPlanOpe.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.lblPlanOpe.Location = New System.Drawing.Point(869, 122)
        Me.lblPlanOpe.Name = "lblPlanOpe"
        Me.lblPlanOpe.Size = New System.Drawing.Size(251, 26)
        Me.lblPlanOpe.TabIndex = 4
        Me.lblPlanOpe.Text = "PLANILHA OPERACIONAL"
        '
        'ptbContBol
        '
        Me.ptbContBol.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ptbContBol.Image = Global.Blender.My.Resources.Resources.Contabilidade_da_Bolsa
        Me.ptbContBol.Location = New System.Drawing.Point(870, 429)
        Me.ptbContBol.Name = "ptbContBol"
        Me.ptbContBol.Size = New System.Drawing.Size(240, 35)
        Me.ptbContBol.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ptbContBol.TabIndex = 6
        Me.ptbContBol.TabStop = False
        '
        'ptbMiddle
        '
        Me.ptbMiddle.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ptbMiddle.Image = Global.Blender.My.Resources.Resources.Middle
        Me.ptbMiddle.Location = New System.Drawing.Point(940, 172)
        Me.ptbMiddle.Name = "ptbMiddle"
        Me.ptbMiddle.Size = New System.Drawing.Size(87, 102)
        Me.ptbMiddle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ptbMiddle.TabIndex = 7
        Me.ptbMiddle.TabStop = False
        '
        'ptbPrevidencia
        '
        Me.ptbPrevidencia.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ptbPrevidencia.Image = Global.Blender.My.Resources.Resources.Previdencia
        Me.ptbPrevidencia.Location = New System.Drawing.Point(1096, 172)
        Me.ptbPrevidencia.Name = "ptbPrevidencia"
        Me.ptbPrevidencia.Size = New System.Drawing.Size(87, 102)
        Me.ptbPrevidencia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ptbPrevidencia.TabIndex = 8
        Me.ptbPrevidencia.TabStop = False
        '
        'ptbMovFin
        '
        Me.ptbMovFin.BackColor = System.Drawing.Color.Transparent
        Me.ptbMovFin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ptbMovFin.Image = Global.Blender.My.Resources.Resources.Movimentacoes_Financeiras
        Me.ptbMovFin.Location = New System.Drawing.Point(775, 290)
        Me.ptbMovFin.Name = "ptbMovFin"
        Me.ptbMovFin.Size = New System.Drawing.Size(101, 103)
        Me.ptbMovFin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ptbMovFin.TabIndex = 5
        Me.ptbMovFin.TabStop = False
        '
        'ptbTranCust
        '
        Me.ptbTranCust.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ptbTranCust.Image = Global.Blender.My.Resources.Resources.Tranferencia_de_Custodia
        Me.ptbTranCust.Location = New System.Drawing.Point(933, 290)
        Me.ptbTranCust.Name = "ptbTranCust"
        Me.ptbTranCust.Size = New System.Drawing.Size(101, 103)
        Me.ptbTranCust.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ptbTranCust.TabIndex = 9
        Me.ptbTranCust.TabStop = False
        '
        'ptbCalcRubi
        '
        Me.ptbCalcRubi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ptbCalcRubi.Image = Global.Blender.My.Resources.Resources.Calculadora_de_Rubi
        Me.ptbCalcRubi.Location = New System.Drawing.Point(1089, 290)
        Me.ptbCalcRubi.Name = "ptbCalcRubi"
        Me.ptbCalcRubi.Size = New System.Drawing.Size(101, 103)
        Me.ptbCalcRubi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ptbCalcRubi.TabIndex = 10
        Me.ptbCalcRubi.TabStop = False
        '
        'frmDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1284, 518)
        Me.Controls.Add(Me.ptbCalcRubi)
        Me.Controls.Add(Me.ptbTranCust)
        Me.Controls.Add(Me.ptbPrevidencia)
        Me.Controls.Add(Me.ptbMiddle)
        Me.Controls.Add(Me.ptbContBol)
        Me.Controls.Add(Me.ptbMovFin)
        Me.Controls.Add(Me.lblPlanOpe)
        Me.Controls.Add(Me.ptbCadastro)
        Me.Controls.Add(Me.flwMenu)
        Me.Controls.Add(Me.ptbLogo)
        Me.Controls.Add(Me.ptbBorda)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BLENDER - DASHBOARD"
        CType(Me.ptbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.flwMenu.ResumeLayout(False)
        CType(Me.ptbHorXP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptbEmailBlend, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptbEmailXP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptbTutorial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptbStatDeman, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptbResgExpress, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptbBorda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptbCadastro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptbContBol, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptbMiddle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptbPrevidencia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptbMovFin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptbTranCust, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptbCalcRubi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ptbLogo As PictureBox
    Friend WithEvents flwMenu As FlowLayoutPanel
    Friend WithEvents ptbHorXP As PictureBox
    Friend WithEvents ptbEmailBlend As PictureBox
    Friend WithEvents ptbEmailXP As PictureBox
    Friend WithEvents ptbTutorial As PictureBox
    Friend WithEvents ptbStatDeman As PictureBox
    Friend WithEvents ptbResgExpress As PictureBox
    Friend WithEvents ptbBorda As PictureBox
    Friend WithEvents ptbCadastro As PictureBox
    Friend WithEvents lblPlanOpe As Label
    Friend WithEvents ptbContBol As PictureBox
    Friend WithEvents ptbMiddle As PictureBox
    Friend WithEvents ptbPrevidencia As PictureBox
    Friend WithEvents ptbMovFin As PictureBox
    Friend WithEvents ptbTranCust As PictureBox
    Friend WithEvents ptbCalcRubi As PictureBox
End Class
