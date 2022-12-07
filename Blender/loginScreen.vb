Imports System.Net.Mail
Imports MySql.Data.MySqlClient

Public Class frmLoginScreen

    Dim connection As New MySqlConnection("datasource=ec2-54-207-202-146.sa-east-1.compute.amazonaws.com;
        port=3306;username=root;password=@Vemseraceticon2022;database=blendcapital")

    Private Sub frmLoginScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.SuspendLayout()

        Me.FormBorderStyle = FormBorderStyle.None
        Me.Height = 200
        Me.Width = 400

        Dim p As New Drawing2D.GraphicsPath()

        p.StartFigure()
        p.AddArc(New Rectangle(0, 0, 20, 20), 180, 90)
        p.AddLine(20, 0, Me.Width - 20, 0)
        p.AddArc(New Rectangle(Me.Width - 20, 0, 20, 20), -90, 90)
        p.AddLine(Me.Width, 20, Me.Width, Me.Height - 20)
        p.AddArc(New Rectangle(Me.Width - 20, Me.Height - 20, 20, 20), 0, 90)
        p.AddLine(Me.Width - 20, Me.Height, 20, Me.Height)
        p.AddArc(New Rectangle(0, Me.Height - 20, 20, 20), 90, 90)
        p.CloseFigure()

        Me.Region = New Region(p)

    End Sub

    Private Sub lblClose_Click(sender As Object, e As EventArgs) Handles lblClose.Click

        Application.ExitThread()

    End Sub

    Private Sub ptbEntrar_Click(sender As Object, e As EventArgs) Handles ptbEntrar.Click

        Try
            Dim vEmailAddress As New System.Net.Mail.MailAddress(txtEmail.Text)
        Catch ex As Exception
            MsgBox("Insira um E-mail valido!", vbInformation)
            Return
        End Try

        Dim address As New MailAddress(txtEmail.Text)

        Dim command As New MySqlCommand("SELECT * FROM blendcapital.usuario
            WHERE email = @email;", connection)

        command.Parameters.Add("@email", MySqlDbType.VarChar).Value = address

        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)

        For Each row As DataRow In table.Rows

            If String.Equals(txtSenha.Text, row.Item("senha")) Then

                Select Case row.Item("id")

                    Case 1
                        frmDashPrin.Show()
                        Me.Close()
                        Return

                    Case 2
                        frmDashMid.Show()
                        Me.Close()
                        Return

                    Case 3
                        frmDashInvest.Show()
                        Me.Close()
                        Return

                    Case 4
                        frmDashBrokers.Show()
                        Me.Close()
                        Return

                End Select

            End If

        Next

        MsgBox("E-mail ou senha invalidos!", vbInformation)

    End Sub

    Private Sub ptbEsqSenha_Click(sender As Object, e As EventArgs) Handles ptbEsqSenha.Click

        MsgBox("Entre em contato com o suporte para soliciar a recuperação de senha!", vbInformation)

    End Sub

End Class
