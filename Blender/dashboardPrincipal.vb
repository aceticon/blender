Public Class frmDashPrin

    Private Sub ptbSair_Click(sender As Object, e As EventArgs) Handles ptbSair.Click

        frmLoginScreen.Show()
        Me.Close()

    End Sub

    Private Sub ptbContBolsa_Click(sender As Object, e As EventArgs) 

        Dim OutApp As Object
        Dim OutMail As Object
        Dim strbody As String

        OutApp = CreateObject("Outlook.Application")
        OutMail = OutApp.CreateItem(0)

        strbody = "Olá, tudo bem? <br><br>" &
                "Segue em anexo a Documentação solicitada do(a) cliente - XXXXXX <br><br>" &
                "Att.,"

        On Error Resume Next

        With OutMail
            .Display()
            .To = "backoffice@contabilidadebolsa.com.br"
            .CC = ""
            .BCC = ""
            .Subject = "Documentação Contabilidade da Bolsa - XXXXX"
            .HTMLBody = strbody & "<br>" & .HTMLBody
        End With

        On Error GoTo 0
        OutMail = Nothing
        OutApp = Nothing

    End Sub
End Class