Public Class frmDashPrin

    Private Sub ptbSair_Click(sender As Object, e As EventArgs) Handles ptbSair.Click

        frmLoginScreen.Show()
        Me.Close()

    End Sub

    Private Sub ptbTranCust_Click(sender As Object, e As EventArgs) Handles ptbTranCust.Click

        frmTransCust.Show()
        Me.Close()

    End Sub

End Class
