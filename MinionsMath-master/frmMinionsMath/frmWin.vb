﻿Public Class frmWin
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        My.Forms.frmLevel.Show()

    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        End
    End Sub

    Private Sub frmWin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblPlayerScore.Text = Score
    End Sub

    Private Sub btnShop_Click(sender As Object, e As EventArgs) Handles btnShop.Click
        Me.Close()
        My.Forms.frmShop.Show() 'takes you to the shop
    End Sub
End Class