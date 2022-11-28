Imports Microsoft.Office
Imports Microsoft.Office.Interop
Public Class frmTransCust

    Private Sub ptbVoltar_Click(sender As Object, e As EventArgs) Handles ptbVoltar.Click

        frmDashPrin.Show()
        Me.Close()

    End Sub

    Private Sub ptbSafra_Click(sender As Object, e As EventArgs) Handles ptbSafra.Click

        'BIMO STVM SANTANDER -> XP'
        Dim OutApp As Object
        Dim OutMail As Object
        Dim strbody As String

        OutApp = CreateObject("Outlook.Application")
        OutMail = OutApp.CreateItem(0)

        strbody = "Prezado(a), <br><br>" &
            "Venho através deste e-mail auxiliá-lo(a) quanto a Transferência de custódia: Santander Corretora > XP. <br><br>" &
            "Para darmos seguimento, precisamos seguir o passo a passo abaixo: <br><br>" &
            "<h3>Preenchimento do formulário STVM </h3> <br>" &
            "• Nos enviar a sua posição consolidada e o código de investidor na Santander Corretora para preenchermos a STVM <br>" &
            "- Caso possua ativos de Renda Fixa, é necessário nos enviar a nota de compra de cada ativo. <br><br>" &
            "<h3>Envio da STVM para a Santander Corretora </h3> " &
                        "&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; 1.	Imprimir a STVM<br>" &
            "&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; 2.   Assinar a STVM à punho<br>" &
            "&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; 3.   Enviar a STVM + Documento de identificação para o endereço de e-mail <a href='mailto:corretoracustodiatransferencias@santander.com.br'>corretoracustodiatransferencias@santander.com.br</a>. <br>" &
            "&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; 4.	Verificar se não há nenhuma pendência na conta da Santander Corretora como: conta negativa, pendência cadastral, etc. <br><br>" &
            "<i>Obs: Este processo é realizado pelo Santander </i> <br><br>" &
            "<b>Atenção: Durante o período de Transferência de Valores Mobiliários, é recomendado que não sejam feitas movimentações dos ativos solicitados sob pena de multa de liquidação conforme regra da B3. </b>" &
            "<br><br>Quaisquer dúvidas estou à disposição."

        On Error Resume Next

        With OutMail
            .Display()
            .To = ""
            .CC = ""
            .BCC = ""
            .Subject = "Transferência de custódia: Santander Corretora> XP - "
            .HTMLBody = strbody & "<br>" & .HTMLBody
        End With

        On Error GoTo 0
        OutMail = Nothing
        OutApp = Nothing

    End Sub
End Class