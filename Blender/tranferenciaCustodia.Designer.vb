<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTransCust
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTransCust))
        Me.ptbSafra = New System.Windows.Forms.PictureBox()
        Me.ptbVoltar = New System.Windows.Forms.PictureBox()
        Me.ptbTransCust = New System.Windows.Forms.PictureBox()
        Me.ptbStvm = New System.Windows.Forms.PictureBox()
        Me.txtCodCliente = New System.Windows.Forms.TextBox()
        CType(Me.ptbSafra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptbVoltar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptbTransCust, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptbStvm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ptbSafra
        '
        Me.ptbSafra.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ptbSafra.Image = CType(resources.GetObject("ptbSafra.Image"), System.Drawing.Image)
        Me.ptbSafra.Location = New System.Drawing.Point(302, 240)
        Me.ptbSafra.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ptbSafra.Name = "ptbSafra"
        Me.ptbSafra.Size = New System.Drawing.Size(553, 63)
        Me.ptbSafra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ptbSafra.TabIndex = 0
        Me.ptbSafra.TabStop = False
        '
        'ptbVoltar
        '
        Me.ptbVoltar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ptbVoltar.BackColor = System.Drawing.Color.White
        Me.ptbVoltar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ptbVoltar.Image = CType(resources.GetObject("ptbVoltar.Image"), System.Drawing.Image)
        Me.ptbVoltar.Location = New System.Drawing.Point(1023, 779)
        Me.ptbVoltar.Margin = New System.Windows.Forms.Padding(0)
        Me.ptbVoltar.Name = "ptbVoltar"
        Me.ptbVoltar.Size = New System.Drawing.Size(92, 37)
        Me.ptbVoltar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ptbVoltar.TabIndex = 12
        Me.ptbVoltar.TabStop = False
        '
        'ptbTransCust
        '
        Me.ptbTransCust.Image = CType(resources.GetObject("ptbTransCust.Image"), System.Drawing.Image)
        Me.ptbTransCust.Location = New System.Drawing.Point(14, 16)
        Me.ptbTransCust.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ptbTransCust.Name = "ptbTransCust"
        Me.ptbTransCust.Size = New System.Drawing.Size(1101, 80)
        Me.ptbTransCust.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ptbTransCust.TabIndex = 13
        Me.ptbTransCust.TabStop = False
        '
        'ptbStvm
        '
        Me.ptbStvm.Image = CType(resources.GetObject("ptbStvm.Image"), System.Drawing.Image)
        Me.ptbStvm.Location = New System.Drawing.Point(192, 104)
        Me.ptbStvm.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ptbStvm.Name = "ptbStvm"
        Me.ptbStvm.Size = New System.Drawing.Size(744, 635)
        Me.ptbStvm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ptbStvm.TabIndex = 14
        Me.ptbStvm.TabStop = False
        '
        'txtCodCliente
        '
        Me.txtCodCliente.Location = New System.Drawing.Point(461, 180)
        Me.txtCodCliente.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtCodCliente.Name = "txtCodCliente"
        Me.txtCodCliente.PlaceholderText = "Código de cliente"
        Me.txtCodCliente.Size = New System.Drawing.Size(210, 27)
        Me.txtCodCliente.TabIndex = 15
        Me.txtCodCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'frmTransCust
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1125, 828)
        Me.Controls.Add(Me.txtCodCliente)
        Me.Controls.Add(Me.ptbTransCust)
        Me.Controls.Add(Me.ptbVoltar)
        Me.Controls.Add(Me.ptbSafra)
        Me.Controls.Add(Me.ptbStvm)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "frmTransCust"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BLENDER - TRANSFERÊNCIA DE CUSTÓDIA"
        CType(Me.ptbSafra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptbVoltar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptbTransCust, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptbStvm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ptbSafra As PictureBox
    Friend WithEvents ptbVoltar As PictureBox
    Friend WithEvents ptbTransCust As PictureBox
    Friend WithEvents ptbStvm As PictureBox
    Friend WithEvents txtCodCliente As TextBox
End Class
