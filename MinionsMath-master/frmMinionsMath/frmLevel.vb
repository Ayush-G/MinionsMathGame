Public Module GlobalVariables
    Public PlayerName As String
End Module

Public Class frmLevel
    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        PlayerName = StrConv(txtName.Text, vbProperCase)
        txtName.Text = "ENJOY THE GAME!"
        Panel1.Visible = False
    End Sub

    Private Sub frmLevel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.Visible = True

    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        End
    End Sub

    Private Sub btnEasy_Click(sender As Object, e As EventArgs) Handles btnEasy.Click
        Me.Hide()
        My.Forms.frmEasy.Show()
    End Sub

    Private Sub btnMedium_Click(sender As Object, e As EventArgs) Handles btnMedium.Click
        Me.Hide()
        My.Forms.frmMedium.Show()
    End Sub

    Private Sub btnHard_Click(sender As Object, e As EventArgs) Handles btnHard.Click
        Me.Hide()
        My.Forms.frmHard.Show()
    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtName.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnPlay.PerformClick()
        End If
    End Sub

    Private Sub btnShop_Click(sender As Object, e As EventArgs) Handles btnShop.Click
        Me.Close()
        My.Forms.frmShop.Show()
    End Sub
End Class