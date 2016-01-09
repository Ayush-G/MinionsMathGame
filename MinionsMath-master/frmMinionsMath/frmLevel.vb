Public Module GlobalVariables
    Public PlayerName As String
End Module

Public Class frmLevel
    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        PlayerName = StrConv(txtName.Text, vbProperCase) 'Converts name to proper case
        txtName.Text = "ENJOY THE GAME!"
        Panel1.Visible = False
    End Sub

    Private Sub frmLevel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If PlayerName = "" Then
            Panel1.Visible = True 'shows name entering panel if there is no named entered yet
        Else Panel1.Visible = False
        End If


    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        End 'quit
    End Sub

    Private Sub btnEasy_Click(sender As Object, e As EventArgs) Handles btnEasy.Click
        Me.Close()
        My.Forms.frmEasy.Show() 'start easy level
    End Sub

    Private Sub btnMedium_Click(sender As Object, e As EventArgs) Handles btnMedium.Click
        Me.Close()
        My.Forms.frmMedium.Show() 'start medium
    End Sub

    Private Sub btnHard_Click(sender As Object, e As EventArgs) Handles btnHard.Click
        Me.Close()
        My.Forms.frmHard.Show() 'start hard
    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtName.KeyDown
        If e.KeyCode = Keys.Enter Then 'allows enter to click button
            btnPlay.PerformClick()
        End If
    End Sub

    Private Sub btnShop_Click(sender As Object, e As EventArgs) Handles btnShop.Click
        Me.Close()
        My.Forms.frmShop.Show() 'takes you to the shop
    End Sub
End Class