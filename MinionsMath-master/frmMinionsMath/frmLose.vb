Public Class frmLose
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        My.Forms.frmLevel.Show()

    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        End

    End Sub

    Private Sub frmLose_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblPlayerScore.Text = Score
    End Sub
End Class