Public Class frmHard
    Dim lvlScore As Integer 'dim variables
    Dim lvlWrong As Integer
    Dim rng1, rng2, rng3, rng4, rng5 As Integer 'random numbers
    Dim sec1 As Long
    Dim sec2 As Long
    Dim shtAns1, shtAns2, shtAns3 As Long 'evaluation variables
    Dim rngOp1, rngOp2, rngOp3 As Integer 'operations
    Dim a, b As Integer 'always divisible
    Dim charactersAllowed As String = "1234567890-" 'allowed textbox characters
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        My.Forms.frmCalc.Show() 'integrated calculator
    End Sub

    Private Sub frmEasy_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
        Me.AutoScroll = False 'no scroll
        PictureBox3.Visible = True 'no walking minion
        Panel1.Visible = False ' no question
        Me.KeyPreview = True ' keys enabled
        lblPlayerScore.Text = Score 'updates player score
        lblPlayerName.Text = PlayerName 'player name entered
    End Sub

    Private Sub frmEasy_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        PictureBox3.Visible = False 'walking animation
        If e.KeyCode = Keys.D Then 'starts timer based on key down
            tmrRight.Start()
            tmrLeft.Stop()
        ElseIf e.KeyCode = Keys.A
            tmrRight.Stop()
            tmrLeft.Start()
        End If
    End Sub

    Private Sub frmEasy_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        PictureBox3.Visible = True 'still minion
        If e.KeyCode = Keys.A Then 'stops timers
            tmrLeft.Stop()
        End If
        If e.KeyCode = Keys.D Then
            tmrRight.Stop()
        End If

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        'Solves the problem
        If lblOp1.Text = "+" Then
            shtAns1 = rng1 + rng2
        ElseIf lblOp1.Text = "-" Then
            shtAns1 = rng1 - rng2
        ElseIf lblOp1.Text = "x" Then
            shtAns1 = rng1 * rng2
        ElseIf lblOp1.Text = "÷" Then
            shtAns1 = rng1 / rng2
        End If
        If lblOp3.Text = "+" Then
            shtAns2 = rng4 + rng5
        ElseIf lblOp3.Text = "-" Then
            shtAns2 = rng4 - rng5
        ElseIf lblOp3.Text = "x" Then
            shtAns2 = rng4 * rng5
        ElseIf lblOp3.Text = "÷" Then
            shtAns2 = rng4 / rng5
        End If

        shtAns2 = shtAns2 * rng3

        If lblOp2.Text = "+" Then
            shtAns3 = shtAns1 + shtAns2
        ElseIf lblOp2.Text = "-" Then
            shtAns3 = shtAns1 - shtAns2
        ElseIf lblOp2.Text = "x" Then
            shtAns3 = shtAns1 * shtAns2
        End If

        'Checks user's answer
        If txtAnswer.Text = shtAns3 Then
            lvlScore += 1
            If UpDblPts = True Then 'awards points based on upgrades bought
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
        Me.KeyPreview = True 'keys reenabled
        Panel1.Visible = False 'no question appears
        lblPlayerScore.Text = Score 'score updated
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Me.Close() 'close level
        My.Forms.MainMenu.Show() 'return to main menu
    End Sub

    Private Sub tmrRight_Tick(sender As Object, e As EventArgs) Handles tmrRight.Tick
        'Move to the right by moving pictures to left
        If UpSpeed = True Then
            picBanana1.Left -= 6
            picBanana2.Left -= 6
            picBanana3.Left -= 6
            picBanana4.Left -= 6
            picBanana5.Left -= 6
            picBanana6.Left -= 6
            picBanana7.Left -= 6
            picBanana8.Left -= 6
        Else
            picBanana1.Left -= 4
            picBanana2.Left -= 4
            picBanana3.Left -= 4
            picBanana4.Left -= 4
            picBanana5.Left -= 4
            picBanana6.Left -= 4
            picBanana7.Left -= 4
            picBanana8.Left -= 4
        End If

        'Collision Check
        If PictureBox2.Bounds.IntersectsWith(picBanana1.Bounds) Or PictureBox2.Bounds.IntersectsWith(picBanana2.Bounds) Or PictureBox2.Bounds.IntersectsWith(picBanana3.Bounds) Or PictureBox2.Bounds.IntersectsWith(picBanana4.Bounds) Or PictureBox2.Bounds.IntersectsWith(picBanana5.Bounds) Or PictureBox2.Bounds.IntersectsWith(picBanana6.Bounds) Or PictureBox2.Bounds.IntersectsWith(picBanana7.Bounds) Or PictureBox2.Bounds.IntersectsWith(picBanana8.Bounds) Then
            Me.KeyPreview = False 'keys disabled
            PictureBox3.Visible = True 'still minion
            tmrLeft.Enabled = False 'timers stopped
            tmrRight.Enabled = False
            Panel1.Visible = True 'question visible
            txtAnswer.Focus() 'focus on textbox for easy answering
            txtAnswer.Text = "" 'clear textbox
            rng1 = CInt(Int(9 * Rnd()) + 1) 'generate randoms
            rng2 = CInt(Int(9 * Rnd()) + 1)
            rng3 = CInt(Int(9 * Rnd()) + 1)
            rng4 = CInt(Int(9 * Rnd()) + 1)
            rng5 = CInt(Int(9 * Rnd()) + 1)
            rngOp1 = CInt(Int(4 * Rnd()) + 1)
            rngOp2 = CInt(Int(3 * Rnd()) + 1)
            rngOp3 = CInt(Int(4 * Rnd()) + 1)

            If rngOp1 = 1 Then 'display proper operations
                lblOp1.Text = "+"
            ElseIf rngOp1 = 2
                lblOp1.Text = "-"
            ElseIf rngOp1 = 3
                lblOp1.Text = "x"
            ElseIf rngOp1 = 4
                lblOp1.Text = "÷"
                a = rng1 'make sure it is divisible
                rng1 = a * rng2
            End If

            If rngOp2 = 1 Then
                lblOp2.Text = "+"
            ElseIf rngOp2 = 2
                lblOp2.Text = "-"
            ElseIf rngOp2 = 3
                lblOp2.Text = "x"
            End If

            If rngOp3 = 1 Then
                lblOp3.Text = "+"
            ElseIf rngOp3 = 2
                lblOp3.Text = "-"
            ElseIf rngOp3 = 3
                lblOp3.Text = "x"
            ElseIf rngOp3 = 4
                lblOp3.Text = "÷"
                b = rng4 'make sure it is divisible
                rng4 = b * rng5
            End If

            Num1.Text = rng1 'shows numbers
            Num2.Text = rng2
            Num3.Text = rng3
            Num4.Text = rng4
            Num5.Text = rng5
        Else Panel1.Visible = False
        End If
    End Sub

    Private Sub tmrLeft_Tick(sender As Object, e As EventArgs) Handles tmrLeft.Tick
        'Move to the left by moving pictures to right

        If UpSpeed = True Then
            picBanana1.Left += 6
            picBanana2.Left += 6
            picBanana3.Left += 6
            picBanana4.Left += 6
            picBanana5.Left += 6
            picBanana6.Left += 6
            picBanana7.Left += 6
            picBanana8.Left += 6
        Else
            picBanana1.Left += 4
            picBanana2.Left += 4
            picBanana3.Left += 4
            picBanana4.Left += 4
            picBanana5.Left += 4
            picBanana6.Left += 4
            picBanana7.Left += 4
            picBanana8.Left += 4
        End If

        'Collision Check
        If PictureBox2.Bounds.IntersectsWith(picBanana1.Bounds) Or PictureBox2.Bounds.IntersectsWith(picBanana2.Bounds) Or PictureBox2.Bounds.IntersectsWith(picBanana3.Bounds) Or PictureBox2.Bounds.IntersectsWith(picBanana4.Bounds) Or PictureBox2.Bounds.IntersectsWith(picBanana5.Bounds) Or PictureBox2.Bounds.IntersectsWith(picBanana6.Bounds) Or PictureBox2.Bounds.IntersectsWith(picBanana7.Bounds) Or PictureBox2.Bounds.IntersectsWith(picBanana8.Bounds) Then
            Me.KeyPreview = False 'no keys
            tmrRight.Enabled = False 'stop timers
            tmrLeft.Enabled = False
            PictureBox3.Visible = False 'still minion
            Panel1.Visible = True 'question shown
            txtAnswer.Focus() 'easy question answering
            txtAnswer.Text = "" 'clear textbox
            rng1 = CInt(Int(9 * Rnd()) + 1) 'random numbers and operations
            rng2 = CInt(Int(9 * Rnd()) + 1)
            rng3 = CInt(Int(9 * Rnd()) + 1)
            rng4 = CInt(Int(9 * Rnd()) + 1)
            rng5 = CInt(Int(9 * Rnd()) + 1)
            rngOp1 = CInt(Int(4 * Rnd()) + 1)
            rngOp2 = CInt(Int(3 * Rnd()) + 1)
            rngOp3 = CInt(Int(4 * Rnd()) + 1)

            If rngOp1 = 1 Then 'shows proper operations
                lblOp1.Text = "+"
            ElseIf rngOp1 = 2
                lblOp1.Text = "-"
            ElseIf rngOp1 = 3
                lblOp1.Text = "x"
            ElseIf rngOp1 = 4
                lblOp1.Text = "÷"
                a = rng1 'ensures number is divisible
                rng1 = a * rng2
            End If

            If rngOp2 = 1 Then
                lblOp2.Text = "+"
            ElseIf rngOp2 = 2
                lblOp2.Text = "-"
            ElseIf rngOp2 = 3
                lblOp2.Text = "x"
            End If

            If rngOp3 = 1 Then
                lblOp3.Text = "+"
            ElseIf rngOp3 = 2
                lblOp3.Text = "-"
            ElseIf rngOp3 = 3
                lblOp3.Text = "x"
            ElseIf rngOp3 = 4
                lblOp3.Text = "÷"
                b = rng4 'ensures number is divisible
                rng4 = b * rng5
            End If

            Num1.Text = rng1 'shows numbers
            Num2.Text = rng2
            Num3.Text = rng3
            Num4.Text = rng4
            Num5.Text = rng5
        End If
    End Sub
    Private Sub txtAnswer_TextChanged(sender As Object, e As EventArgs) Handles txtAnswer.TextChanged
        Dim theText As String = txtAnswer.Text
        Dim Letter As String
        Dim SelectionIndex As Integer = txtAnswer.SelectionStart
        Dim Change As Integer
        ' Ensures that the text entered into the box is only a numeric value.
        For x As Integer = 0 To txtAnswer.Text.Length - 1
            Letter = txtAnswer.Text.Substring(x, 1)
            If charactersAllowed.Contains(Letter) = False Then
                theText = theText.Replace(Letter, String.Empty)
                Change = 1
            End If
        Next
        txtAnswer.Text = theText
        txtAnswer.Select(SelectionIndex - Change, 0)
    End Sub
    Private Sub txtAnswer_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAnswer.KeyDown
        If e.KeyCode = Keys.Enter Then 'able to click enter to submit answer
            btnSubmit.PerformClick()
        End If
    End Sub
End Class