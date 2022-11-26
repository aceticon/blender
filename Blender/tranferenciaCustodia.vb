Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class frmTransCust

    Private Sub ptbVoltar_Click(sender As Object, e As EventArgs) Handles ptbVoltar.Click

        frmDashPrin.Show()
        Me.Close()

    End Sub

    Private Sub ptbSafra_Click(sender As Object, e As EventArgs) Handles ptbSafra.Click

        Dim OutApp As Object
        Dim OutMail As Object
        Dim strbody As String

        OutApp = CreateObject("Outlook.Application")
        OutMail = OutApp.CreateItem(0)

        strbody = "<div dir=""ltr"">
        <div><span style=""box-sizing:border-box!important;font-family: Montserrat,sans-serif;color: rgb(102,102,102);text-align:justify;background-color:rgb(255,255,255)""><strong style=""box-sizing:border-box!important;font-family: Montserrat,sans-serif!important"">
        <p style=""font-weight: 400;margin-top:30px;margin-bottom:1rem;text-decoration:underline;line-height:28px;box-sizing:border-box!important;color: rgb(45,190,213)!important"">
        <span style=""box-sizing: border-box!important;font-family: Montserrat,sans-serif!important;font-size: large""><strong style=""box-sizing: border-box!important;font-weight: bolder""></strong></span></p>
        <p style=""box-sizing: border-box!important;margin-top: 30px;margin-bottom:1rem;font-size:16px;color:rgb(106,114,130);font-weight:400"">
        <span style=""box-sizing:border-box!important;font-family: Montserrat,sans-serif!important;color: rgb(102,102,102)""><strong style=""box-sizing:border-box!important;font-weight:bolder"">1.</strong><span>&nbsp;</span>Preencha
         o documento com os seus dados de conta no modalmais como Cedente e os dados da Corretora de destino como Cessionário.</span></p>
        <p style=""box-sizing: border-box!important;margin-top: 30px;margin-bottom:1rem;font-size:16px;color:rgb(106,114,130);font-weight:400"">
        <span style=""box-sizing:border-box!important;font-family: Montserrat,sans-serif!important;color:rgb(102,102,102)""><strong style=""box-sizing:border-box!important;font-weight:bolder"">Importante:<span>&nbsp;</span></strong>dados
         da Instituição – Agente de Custódia: Modal DTVM 1982-8</span></p>
        <p style=""box-sizing: border-box!important;margin-top: 30px;margin-bottom:1rem;font-size:16px;color:rgb(106,114,130);font-weight:400"">
        <span style=""box-sizing:border-box!important;font-family: Montserrat,sans-serif!important;color:rgb(102,102,102)""><strong style=""box-sizing:border-box!important;font-weight:bolder"">2.</strong><span>&nbsp;</span>Os
         tipos de ativos que você pode transferir, por tipo de valor mobiliário, são:</span></p>
        <p style=""box-sizing: border-box!important;margin-top: 30px;margin-bottom:1rem;font-size:16px;color:rgb(106,114,130);font-weight:400"">
        <span style=""box-sizing:border-box!important;font-family: Montserrat,sans-serif!important;color: rgb(102,102,102)"">I) Ação, FII, ETF, Opção, Termo, BM&amp;F (disponível e futuro) e Eventos Corporativos;</span></p>
        <p style=""box-sizing:border-box!important;margin-top: 30px;margin-bottom:1rem;font-size:16px;color:rgb(106,114,130);font-weight:400"">
        <span style=""box-sizing:border-box!important;font-family: Montserrat,sans-serif!important;color: rgb(102,102,102)"">II) CDB, LCI, LCA, LC, COE ou outros títulos bancários</span></p>
        <p style=""box-sizing:border-box!important;margin-top: 30px;margin-bottom:1rem;font-size:16px;color:rgb(106,114,130);font-weight:400"">
        <span style=""box-sizing:border-box!important;font-family: Montserrat,sans-serif!important;color: rgb(102,102,102)"">III) CRI, CRA e Debêntures</span></p>
        <p style=""box-sizing:border-box!important;margin-top: 30px;margin-bottom:1rem;font-size:16px;color:rgb(106,114,130);font-weight:400"">
        <span style=""box-sizing:border-box!important;font-family: Montserrat,sans-serif!important;color: rgb(102,102,102)"">IV) Fundos de Previdência Privada</span></p>
        <p style=""box-sizing:border-box!important;margin-top: 30px;margin-bottom:1rem;font-size:16px;color:rgb(106,114,130);font-weight:400"">
        <span style=""box-sizing:border-box!important;font-family: Montserrat,sans-serif!important;color: rgb(102,102,102)"">V) Títulos Públicos (LFT, LTN, NTN-B, etc.)</span></p>
        <p style=""box-sizing:border-box!important;margin-top: 30px;margin-bottom:1rem;font-size:16px;color:rgb(106,114,130);font-weight:400"">
        <span style=""box-sizing:border-box!important;font-family: Montserrat,sans-serif!important;color:rgb(102,102,102)"">Nos casos de transferência de valores mobiliários por quaisquer outros motivos, por exemplo: herança,
         doação, ordem judicial, etc., entre em contato com o nosso atendimento via Chat.</span></p>
        <p style=""box-sizing:border-box!important;margin-top: 30px;margin-bottom:1rem;font-size:16px;color:rgb(106,114,130);font-weight:400"">
        <span style=""box-sizing:border-box!important;font-family: Montserrat,sans-serif!important;color:rgb(102,102,102)""><strong style=""box-sizing:border-box!important;font-weight:bolder"">3.</strong><span>&nbsp;</span>Para
         Fundos de Investimento, exceto Fundos de Previdência Privada</span></p>
        <p style=""box-sizing: border-box!important;margin-top: 30px;margin-bottom:1rem;font-size:16px;color:rgb(106,114,130);font-weight:400"">
        <span style=""color:rgb(102,102,102);font-family:Montserrat,sans-serif;font-weight: bolder;box-sizing:border-box!important"">Importante</span><span style=""color: rgb(102,102,102);font-family:Montserrat,sans-serif"">: a transferência
         de Fundos de Investimento somente é possível caso a instituição financeira de destino tenha o mesmo Fundo disponível em sua plataforma. Verifique o CNPJ do Fundo e compare.&nbsp;</span><br>
        </p>
        </strong></span>
        <p></p>
        <p style=""font-weight: 400;margin-top:30px;margin-bottom:1rem;text-decoration:underline;line-height:28px;box-sizing:border-box!important;color: rgb(45,190,213)!important"">
        <span style=""font-family: Montserrat,sans-serif;font-size: large;font-weight:bolder;box-sizing:border-box!important"">Envio Digital</span><br>
        </p>
        <ul style=""list-style: initial;margin:0px 0px 1rem;padding:0px 0px 0px 3em;color:rgb(106,114,130);box-sizing:border-box!important"">
        <li style=""font-weight:  400;box-sizing:border-box!important;font-family: Montserrat,sans-serif!important"">
        <span style=""box-sizing: border-box!important;color: rgb(102,102,102)"">Depois de preenchido, o documento deverá ser convertido em PDF e poderá ser assinado em certificado digital (ICP Brasil);</span></li><li style=""font-weight:400;box-sizing:border-box!important;font-family: Montserrat,sans-serif!important"">
        <span style=""box-sizing: border-box!important;color: rgb(102,102,102)"">Ou, poderá ser impresso e assinado no papel;</span></li><li style=""box-sizing:border-box!important;font-family: Montserrat,sans-serif!important"">
        <span style=""color: rgb(102,102,102);box-sizing:border-box!important""><span style=""font-weight: 400"">Enviar para o e-mail
        </span><u><a href=""mailto:atendimento@modalmais.com.br"" target=""_blank"">atendimento@modalmais.com.br</a></u><span style=""font-weight: 400""> com cópia de sua CNH</span></span></li></ul>
        <br>
        </div>
        <div><span style=""box-sizing:border-box!important;font-family: Montserrat,sans-serif;color: rgb(102,102,102);text-align:justify;background-color:rgb(255,255,255)""><strong style=""box-sizing:border-box!important;font-family: Montserrat,sans-serif!important;font-weight: bolder"">Ou</strong></span></div>
        <div><span style=""box-sizing: border-box!important;font-family: Montserrat,sans-serif;color:rgb(102,102,102);text-align:justify;background-color:rgb(255,255,255)""><strong style=""box-sizing:border-box!important;font-family: Montserrat,sans-serif!important;font-weight: bolder""><br>
        </strong></span></div>
        <div><span style=""box-sizing: border-box!important;font-family: Montserrat,sans-serif;color: rgb(102,102,102);text-align:justify;background-color:rgb(255,255,255)""><strong style=""box-sizing:border-box!important;font-family: Montserrat,sans-serif!important;font-weight: bolder"">1.</strong><span>&nbsp;</span>Acesse
         sua conta pelo<span>&nbsp;</span><a href=""https: //bancodigital.modalmais.com.br/login"" rel=""noopener"" style=""box-sizing:border-box!important;font-family: Montserrat,sans-serif!important;color: rgb(0,123,255)"" target=""_blank"" data-saferedirecturl=""https://www.google.com/url?q=https://bancodigital.modalmais.com.br/login&amp;source=gmail&amp;ust=1669496884971000&amp;usg=AOvVaw0-C6t-QaeDb58FLCy62Z30"">site do Banco Digital</a>;</span><br style=""box-sizing:border-box!important;font-family: Montserrat,sans-serif;color: rgb(106,114,130);text-align:justify;background-color:rgb(255,255,255)"">
        </div>
        <div><span style=""color:rgb(102,102,102);text-align:justify;font-weight:bolder;font-family:Montserrat,sans-serif!important;box-sizing: border-box!important"">2.</span><span style=""color: rgb(102,102,102);font-family:Montserrat,sans-serif;text-align: justify"">&nbsp;</span><span style=""color:rgb(102,102,102);font-family:Montserrat,sans-serif;text-align: justify"">Clique
         no ícone de ponto de interrogação;</span><br>
        </div>
        <span style=""box-sizing: border-box!important;font-family: Montserrat,sans-serif;color: rgb(102,102,102);text-align:justify;background-color:rgb(255,255,255)""><strong style=""box-sizing:border-box!important;font-family: Montserrat,sans-serif!important;font-weight: bolder"">3.</strong><span>&nbsp;</span>Clique
         em ""Menu"" no canto superior esquerdo da tela;</span><br style=""box-sizing: border-box!important;font-family: Montserrat,sans-serif;color: rgb(106,114,130);text-align:justify;background-color:rgb(255,255,255)"">
        <span style=""box-sizing:border-box!important;font-family: Montserrat,sans-serif;color: rgb(102,102,102);text-align:justify;background-color:rgb(255,255,255)""><strong style=""box-sizing:border-box!important;font-family: Montserrat,sans-serif!important;font-weight: bolder"">4.</strong><span>&nbsp;</span>Clique
         em ""Envie uma solicitação"";</span><br style=""box-sizing: border-box!important;font-family: Montserrat,sans-serif;color: rgb(106,114,130);text-align:justify;background-color:rgb(255,255,255)"">
        <span style=""box-sizing:border-box!important;font-family: Montserrat,sans-serif;color: rgb(102,102,102);text-align:justify;background-color:rgb(255,255,255)""><strong style=""box-sizing:border-box!important;font-family: Montserrat,sans-serif!important;font-weight: bolder"">5.</strong><span>&nbsp;</span>Selecione
         o formulário ""STVM - Transferência de Custódia para outra instituição"";</span><br style=""box-sizing: border-box!important;font-family: Montserrat,sans-serif;color: rgb(106,114,130);text-align:justify;background-color:rgb(255,255,255)"">
        <span style=""box-sizing:border-box!important;font-family: Montserrat,sans-serif;color: rgb(102,102,102);text-align:justify;background-color:rgb(255,255,255)""><strong style=""box-sizing:border-box!important;font-family: Montserrat,sans-serif!important;font-weight: bolder"">6.<span>&nbsp;</span></strong>Preencha
         todos os campos solicitados e clique em ""Enviar"";</span><br style=""box-sizing: border-box!important;font-family: Montserrat,sans-serif;color: rgb(106,114,130);text-align:justify;background-color:rgb(255,255,255)"">
        <span style=""box-sizing:border-box!important;font-family: Montserrat,sans-serif;color: rgb(102,102,102);text-align:justify;background-color:rgb(255,255,255)""><strong style=""box-sizing:border-box!important;font-family: Montserrat,sans-serif!important;font-weight: bolder"">7.</strong><span>&nbsp;</span>Adicione
         ou solte os documentos solicitados e descritos nesse artigo;</span><br style=""box-sizing:border-box!important;font-family:Montserrat,sans-serif;color:rgb(106,114,130);text-align:justify;background-color:rgb(255,255,255)"">
        <span style=""box-sizing:border-box!important;font-family:Montserrat,sans-serif;color:rgb(102,102,102);text-align:justify;background-color:rgb(255,255,255)""><strong style=""box-sizing:border-box!important;font-family:Montserrat,sans-serif!important;font-weight:bolder"">8.</strong><span>&nbsp;</span>Clique
         em ""Enviar"";</span><br style=""box-sizing:border-box!important;font-family:Montserrat,sans-serif;color:rgb(106,114,130);text-align:justify;background-color:rgb(255,255,255)"">
        <span style=""box-sizing:border-box!important;font-family:Montserrat,sans-serif;color:rgb(102,102,102);text-align:justify;background-color:rgb(255,255,255)""><strong style=""box-sizing:border-box!important;font-family:Montserrat,sans-serif!important;font-weight:bolder"">9.</strong><span>&nbsp;</span>Feito,
         sua solicitação foi enviada com sucesso! Agora basta aguardar, um de nossos especialistas entrarão em contato com você.</span><div class=""yj6qo""></div><div class=""adL"">
        </div><div style=""font-family:Calibri,Arial,Helvetica,sans-serif;font-size:12pt;color:rgb(0,0,0);background-color:rgb(255,255,255)"" class=""adL"">
        <br>
        </div><div class=""adL"">
        </div></div>"

        On Error Resume Next

        With OutMail
            .Display()
            .To = ""
            .CC = ""
            .BCC = ""
            .Subject = "Transferência de custódia: Banco Original > modalmais - " & txtCodCliente.Text
            .HTMLBody = strbody & "<br>" & .HTMLBody
        End With

        On Error GoTo 0
        OutMail = Nothing
        OutApp = Nothing
        txtCodCliente.Text = ""

    End Sub

End Class