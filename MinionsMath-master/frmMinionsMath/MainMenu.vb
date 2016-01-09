Public Module GlobalVariable 'sets global variables to be used in any form such as the player's: score, and upgrades
    Public Score As Integer
    Public UpSpeed As Boolean = False
    Public UpWinPts As Boolean = False
    Public UpDblPts As Boolean = False
End Module

Public Class MainMenu
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Me.Hide()
        My.Forms.frmLevel.Show() 'starts game, takes to level select
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End 'quit the game :(
    End Sub

    Private Sub btnShop_Click(sender As Object, e As EventArgs) Handles btnShop.Click
        Me.Hide()
        My.Forms.frmShop.Show() 'go to shop
    End Sub
End Class
