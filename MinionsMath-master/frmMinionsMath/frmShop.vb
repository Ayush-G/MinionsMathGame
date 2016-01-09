Public Class frmShop
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
        My.Forms.MainMenu.Show()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
        My.Forms.frmLevel.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        End
    End Sub

    Private Sub frmShop_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblPlayerScore.Text = Score
        lblPlayerName.Text = PlayerName
    End Sub

    Private Sub btnUpSpeed_Click(sender As Object, e As EventArgs) Handles btnUpSpeed.Click
        If Score = 20 Then
            Score -= 20
            UpSpeed = True
            btnUpSpeed.Enabled = False
            btnUpSpeed.Text = "Upgrade Speed - Purchased"
        Else MsgBox("ERROR: Insufficient funds.")
        End If
    End Sub

    Private Sub btnWinPts_Click(sender As Object, e As EventArgs) Handles btnWinPts.Click
        If Score = 30 Then
            Score -= 30
            UpWinPts = True
            btnWinPts.Enabled = False
            btnWinPts.Text = "Upgrade Win Points - Purchased"
        Else MsgBox("ERROR: Insufficient funds.")
        End If

    End Sub

    Private Sub btnDblPts_Click(sender As Object, e As EventArgs) Handles btnDblPts.Click
        If Score = 50 Then
            Score -= 50
            UpDblPts = True
            btnDblPts.Enabled = False
            btnDblPts.Text = "Upgrade Double Points - Purchased"
        Else MsgBox("ERROR: Insufficient funds.")
        End If
    End Sub
End Class