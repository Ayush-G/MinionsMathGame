Public Class frmEasy
    Dim RandomImage As Integer 'Dims variables
    Dim lvlScore As Integer
    Dim lvlWrong As Integer
    Private Sub frmEasy_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
        Me.AutoScroll = False 'So that there is no scroll bar
        PictureBox3.Visible = True 'Still minion
        Panel1.Visible = False 'no question visible
        Me.KeyPreview = True 'keys usable
        lblPlayerScore.Text = Score 'updates player score
        lblPlayerName.Text = PlayerName 'player name in label
    End Sub

    Private Sub frmEasy_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        PictureBox3.Visible = False 'moving minion
        If e.KeyCode = Keys.D Then 'keys start timer corresponding to direction
            tmrRight.Start()
            tmrLeft.Stop()
        ElseIf e.KeyCode = Keys.A
            tmrRight.Stop()
            tmrLeft.Start()
        End If
    End Sub

    Private Sub frmEasy_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        PictureBox3.Visible = True 'shows still minion
        If e.KeyCode = Keys.A Then 'keys stop timer corresponding to direction
            tmrLeft.Stop()
        End If
        If e.KeyCode = Keys.D Then
            tmrRight.Stop()
        End If

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        'checks answer from image
        If RandomImage = 0 Then
            If RadioButton1.Checked = True Then
                lvlScore += 1
                If UpDblPts = True Then 'sees if you have upgrade for double points, awards accordingly
                    Score += 2
                Else
                    Score += 1
                End If
            Else
                lvlWrong += 1
                If UpDblPts = True Then
                    Score -= 2
                Else
                    Score -= 1
                End If
            End If
        ElseIf RandomImage = 1 Then
            If RadioButton2.Checked = True Then
                lvlScore += 1
                If UpDblPts = True Then
                    Score += 2
                Else
                    Score += 1
                End If
            Else
                lvlWrong += 1
                If UpDblPts = True Then
                    Score -= 2
                Else
                    Score -= 1
                End If
            End If
        ElseIf RandomImage = 2 Then
            If RadioButton3.Checked = True Then
                lvlScore += 1
                If UpDblPts = True Then
                    Score += 2
                Else
                    Score += 1
                End If
            Else
                lvlWrong += 1
                If UpDblPts = True Then
                    Score -= 2
                Else
                    Score -= 1
                End If
            End If
        ElseIf RandomImage = 3 Then
            If RadioButton4.Checked = True Then
                lvlScore += 1
                If UpDblPts = True Then
                    Score += 2
                Else
                    Score += 1
                End If
            Else
                lvlWrong += 1
                If UpDblPts = True Then
                    Score -= 2
                Else
                    Score -= 1
                End If
            End If
        ElseIf RandomImage = 4 Then
            If RadioButton5.Checked = True Then
                lvlScore += 1
                If UpDblPts = True Then
                    Score += 2
                Else
                    Score += 1
                End If
            Else
                lvlWrong += 1
                If UpDblPts = True Then
                    Score -= 2
                Else
                    Score -= 1
                End If
            End If
        ElseIf RandomImage = 5 Then
            If RadioButton6.Checked = True Then
                lvlScore += 1
                If UpDblPts = True Then
                    Score += 2
                Else
                    Score += 1
                End If
            Else
                lvlWrong += 1
                If UpDblPts = True Then
                    Score -= 2
                Else
                    Score -= 1
                End If
            End If
        End If
        ' Points given based on upgrades, then pictures move to avoid walking into them again
        If UpWinPts = True Then
            If lvlScore = 3 Then
                lvlScore = lvlScore - lvlWrong
                Score = Score + lvlScore
                Me.Close()
                My.Forms.frmWin.Show()
            ElseIf lvlWrong = 2
                lvlScore = (lvlScore / 2)
                Score = Score + lvlScore
                Me.Close()
                My.Forms.frmLose.Show()
            Else
                picBanana1.Left -= 200
                picBanana2.Left -= 200
                picBanana3.Left -= 200
                picBanana4.Left -= 200
                picBanana5.Left -= 200
                picBanana6.Left -= 200
                picBanana7.Left -= 200
                picBanana8.Left -= 200
            End If
        Else
            If lvlScore = 5 Then
                lvlScore = lvlScore - lvlWrong
                Score = Score + lvlScore
                Me.Close()
                My.Forms.frmWin.Show()
            ElseIf lvlWrong = 3
                lvlScore = (lvlScore / 2)
                Score = Score + lvlScore
                Me.Close()
                My.Forms.frmLose.Show()
            Else
                picBanana1.Left -= 200
                picBanana2.Left -= 200
                picBanana3.Left -= 200
                picBanana4.Left -= 200
                picBanana5.Left -= 200
                picBanana6.Left -= 200
                picBanana7.Left -= 200
                picBanana8.Left -= 200
            End If
        End If


        Me.KeyPreview = True 'reenable keys, question gone, score added to label
        Panel1.Visible = False
        lblPlayerScore.Text = Score
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Me.Close() 'closes instead of hide to not keep previous stats
        My.Forms.MainMenu.Show() 'goes to main menu
    End Sub

    Private Sub tmrRight_Tick(sender As Object, e As EventArgs) Handles tmrRight.Tick
        'Move to the right by moving pictures to left
        If UpSpeed = True Then
            picBanana1.Left -= 3
            picBanana2.Left -= 3
            picBanana3.Left -= 3
            picBanana4.Left -= 3
            picBanana5.Left -= 3
            picBanana6.Left -= 3
            picBanana7.Left -= 3
            picBanana8.Left -= 3
        Else
            picBanana1.Left -= 1
            picBanana2.Left -= 1
            picBanana3.Left -= 1
            picBanana4.Left -= 1
            picBanana5.Left -= 1
            picBanana6.Left -= 1
            picBanana7.Left -= 1
            picBanana8.Left -= 1
        End If

        'Collision Check, generates question
        If PictureBox2.Bounds.IntersectsWith(picBanana1.Bounds) Or PictureBox2.Bounds.IntersectsWith(picBanana2.Bounds) Or PictureBox2.Bounds.IntersectsWith(picBanana3.Bounds) Or PictureBox2.Bounds.IntersectsWith(picBanana4.Bounds) Or PictureBox2.Bounds.IntersectsWith(picBanana5.Bounds) Or PictureBox2.Bounds.IntersectsWith(picBanana6.Bounds) Or PictureBox2.Bounds.IntersectsWith(picBanana7.Bounds) Or PictureBox2.Bounds.IntersectsWith(picBanana8.Bounds) Then
            Me.KeyPreview = False
            PictureBox3.Visible = True
            tmrLeft.Enabled = False
            tmrRight.Enabled = False
            RandomImage = Int(6 * Rnd() + 0)
            Panel1.Visible = True
            If RandomImage = 0 Then
                picShape.Image = ImageList1.Images(0)
            ElseIf RandomImage = 1 Then
                picShape.Image = ImageList1.Images(1)
            ElseIf RandomImage = 2 Then
                picShape.Image = ImageList1.Images(2)
            ElseIf RandomImage = 3 Then
                picShape.Image = ImageList1.Images(3)
            ElseIf RandomImage = 4 Then
                picShape.Image = ImageList1.Images(4)
            ElseIf RandomImage = 5 Then
                picShape.Image = ImageList1.Images(5)
            End If
        Else Panel1.Visible = False
        End If
    End Sub

    Private Sub tmrLeft_Tick(sender As Object, e As EventArgs) Handles tmrLeft.Tick
        'Move to the left by moving pictures to right
        picBanana1.Left += 3
        picBanana2.Left += 3
        picBanana3.Left += 3
        picBanana4.Left += 3
        picBanana5.Left += 3
        picBanana6.Left += 3
        picBanana7.Left += 3
        picBanana8.Left += 3
        'Collision Check, generates question
        If PictureBox2.Bounds.IntersectsWith(picBanana1.Bounds) Or PictureBox2.Bounds.IntersectsWith(picBanana2.Bounds) Or PictureBox2.Bounds.IntersectsWith(picBanana3.Bounds) Or PictureBox2.Bounds.IntersectsWith(picBanana4.Bounds) Or PictureBox2.Bounds.IntersectsWith(picBanana5.Bounds) Or PictureBox2.Bounds.IntersectsWith(picBanana6.Bounds) Or PictureBox2.Bounds.IntersectsWith(picBanana7.Bounds) Or PictureBox2.Bounds.IntersectsWith(picBanana8.Bounds) Then
            Me.KeyPreview = False
            tmrRight.Enabled = False
            tmrLeft.Enabled = False
            PictureBox3.Visible = False
            RandomImage = Int(6 * Rnd() + 0)
            Panel1.Visible = True
            If RandomImage = 0 Then
                picShape.Image = ImageList1.Images(0)
            ElseIf RandomImage = 1 Then
                picShape.Image = ImageList1.Images(1)
            ElseIf RandomImage = 2 Then
                picShape.Image = ImageList1.Images(2)
            ElseIf RandomImage = 3 Then
                picShape.Image = ImageList1.Images(3)
            ElseIf RandomImage = 4 Then
                picShape.Image = ImageList1.Images(4)
            ElseIf RandomImage = 5 Then
                picShape.Image = ImageList1.Images(5)
            End If
        End If
    End Sub

End Class