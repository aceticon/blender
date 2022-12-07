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
        Me.ptbBorda = New System.Windows.Forms.PictureBox()
        Me.lblCentralOpe = New System.Windows.Forms.Label()
        Me.ptbTranCust = New System.Windows.Forms.PictureBox()
        Me.ptbSair = New System.Windows.Forms.PictureBox()
        CType(Me.ptbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptbBorda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptbTranCust, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptbSair, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ptbLogo
        '
        Me.ptbLogo.Image = CType(resources.GetObject("ptbLogo.Image"), System.Drawing.Image)
        Me.ptbLogo.Location = New System.Drawing.Point(12, 12)
        Me.ptbLogo.Name = "ptbLogo"
        Me.ptbLogo.Size = New System.Drawing.Size(128, 56)
        Me.ptbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ptbLogo.TabIndex = 0
        Me.ptbLogo.TabStop = False
        '
        'ptbBorda
        '
        Me.ptbBorda.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ptbBorda.Image = CType(resources.GetObject("ptbBorda.Image"), System.Drawing.Image)
        Me.ptbBorda.Location = New System.Drawing.Point(811, 167)
        Me.ptbBorda.Name = "ptbBorda"
        Me.ptbBorda.Size = New System.Drawing.Size(455, 365)
        Me.ptbBorda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptbBorda.TabIndex = 2
        Me.ptbBorda.TabStop = False
        '
        'lblCentralOpe
        '
        Me.lblCentralOpe.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCentralOpe.AutoSize = True
        Me.lblCentralOpe.BackColor = System.Drawing.Color.White
        Me.lblCentralOpe.Font = New System.Drawing.Font("Marlin Geo Medium", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblCentralOpe.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.lblCentralOpe.Location = New System.Drawing.Point(910, 230)
        Me.lblCentralOpe.Name = "lblCentralOpe"
        Me.lblCentralOpe.Size = New System.Drawing.Size(264, 26)
        Me.lblCentralOpe.TabIndex = 4
        Me.lblCentralOpe.Text = "CENTRAL DE OPERAÇÕES"
        '
        'ptbTranCust
        '
        Me.ptbTranCust.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.ptbTranCust.BackColor = System.Drawing.Color.White
        Me.ptbTranCust.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ptbTranCust.Image = CType(resources.GetObject("ptbTranCust.Image"), System.Drawing.Image)
        Me.ptbTranCust.Location = New System.Drawing.Point(854, 361)
        Me.ptbTranCust.Name = "ptbTranCust"
        Me.ptbTranCust.Size = New System.Drawing.Size(108, 104)
        Me.ptbTranCust.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ptbTranCust.TabIndex = 9
        Me.ptbTranCust.TabStop = False
        '
        'ptbSair
        '
        Me.ptbSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ptbSair.BackColor = System.Drawing.Color.White
        Me.ptbSair.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ptbSair.Image = CType(resources.GetObject("ptbSair.Image"), System.Drawing.Image)
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
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1284, 598)
        Me.Controls.Add(Me.ptbSair)
        Me.Controls.Add(Me.ptbLogo)
        Me.Controls.Add(Me.lblCentralOpe)
        Me.Controls.Add(Me.ptbTranCust)
        Me.Controls.Add(Me.ptbBorda)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmDashPrin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BLENDER - DASHBOARD"
        CType(Me.ptbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptbBorda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptbTranCust, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptbSair, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ptbLogo As PictureBox
    Friend WithEvents ptbBorda As PictureBox
    Friend WithEvents lblCentralOpe As Label
    Friend WithEvents ptbTranCust As PictureBox
    Friend WithEvents ptbSair As PictureBox
End Class
