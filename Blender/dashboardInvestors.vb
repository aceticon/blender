Public Class frmDashInvest

    Private Sub ptbSair_Click(sender As Object, e As EventArgs) Handles ptbSair.Click

        frmLoginScreen.Show()
        Me.Close()

    End Sub

    Private Sub ptbIniJorn_Click(sender As Object, e As EventArgs) Handles ptbIniJorn.Click

        Dim proc As New System.Diagnostics.Process()
        If Not System.IO.File.Exists("C:\Program Files (x86)\Google\Chrome\Application\Chrome.exe") Then
            proc = Process.Start("C:\Program Files\Google\Chrome\Application\Chrome.exe", "https://hub.xpi.com.br/")
        ElseIf System.IO.File.Exists("C:\Program Files (x86)\Google\Chrome\Application\Chrome.exe") Then
            proc = Process.Start("C:\Program Files (x86)\Google\Chrome\Application\Chrome.exe", "https://hub.xpi.com.br/")
        Else
            MsgBox("Não foi possível encontrar o chrome.", MsgBoxStyle.Critical)
        End If

        Dim proc2 As New System.Diagnostics.Process()
        If Not System.IO.File.Exists("C:\Program Files (x86)\Google\Chrome\Application\Chrome.exe") Then
            proc2 = Process.Start("C:\Program Files\Google\Chrome\Application\Chrome.exe", "https://xpconnect.xpi.com.br/Web/Connect/Conta/Login?ReturnUrl=%2fWeb%2fConnect%2f")
        ElseIf System.IO.File.Exists("C:\Program Files (x86)\Google\Chrome\Application\Chrome.exe") Then
            proc2 = Process.Start("C:\Program Files (x86)\Google\Chrome\Application\Chrome.exe", "https://xpconnect.xpi.com.br/Web/Connect/Conta/Login?ReturnUrl=%2fWeb%2fConnect%2f")
        Else
            MsgBox("Não foi possível encontrar o chrome.", MsgBoxStyle.Critical)
        End If

        Dim proc4 As New System.Diagnostics.Process()
        If Not System.IO.File.Exists("C:\Program Files (x86)\Google\Chrome\Application\Chrome.exe") Then
            proc4 = Process.Start("C:\Program Files\Google\Chrome\Application\Chrome.exe", "http://plataforma.investimentosblue.com.br/apex/f?p=104:LOGIN_DESKTOP:781057776222:::::")
        ElseIf System.IO.File.Exists("C:\Program Files (x86)\Google\Chrome\Application\Chrome.exe") Then
            proc4 = Process.Start("C:\Program Files (x86)\Google\Chrome\Application\Chrome.exe", "http://plataforma.investimentosblue.com.br/apex/f?p=104:LOGIN_DESKTOP:781057776222:::::")
        Else
            MsgBox("Não foi possível encontrar o chrome.", MsgBoxStyle.Critical)
        End If

        If Not System.IO.File.Exists("C:\Program Files (x86)\Microsoft Office\root\Office16\OUTLOOK.exe") Then
            proc4 = Process.Start("C:\Program Files\Microsoft Office\root\Office16\OUTLOOK.exe", "http://plataforma.investimentosblue.com.br/apex/f?p=104:LOGIN_DESKTOP:781057776222:::::")
        ElseIf System.IO.File.Exists("C:\Program Files (x86)\Microsoft Office\root\Office16\OUTLOOK.exe") Then
            proc4 = Process.Start("C:\Program Files (x86)\Microsoft Office\root\Office16\OUTLOOK.exe", "http://plataforma.investimentosblue.com.br/apex/f?p=104:LOGIN_DESKTOP:781057776222:::::")
        Else
            MsgBox("Não foi possível encontrar o outlook.", MsgBoxStyle.Critical)
        End If

    End Sub
End Class
