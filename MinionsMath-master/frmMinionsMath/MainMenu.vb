Public Module GlobalVariable
    Public Score As Integer
    Public UpSpeed As Boolean = False
    Public UpWinPts As Boolean = False
    Public UpDblPts As Boolean = False
End Module

Public Class MainMenu
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Me.Hide()
        My.Forms.frmLevel.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub btnShop_Click(sender As Object, e As EventArgs) Handles btnShop.Click
        Me.Close()
        My.Forms.frmShop.Show()
    End Sub
End Class
