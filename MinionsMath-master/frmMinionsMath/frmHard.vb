Public Class frmHard
    Dim lvlScore As Integer
    Dim lvlWrong As Integer
    Dim rng1, rng2, rng3, rng4, rng5 As Integer
    Dim sec1 As Long
    Dim sec2 As Long
    Dim shtAns1, shtAns2, shtAns3 As Short
    Dim rngOp1, rngOp2, rngOp3 As Integer
    Dim a, b As Integer

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        My.Forms.frmCalc.Show()
    End Sub

    Dim charactersAllowed As String = "1234567890"
    Private Sub frmEasy_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
        Me.AutoScroll = False
        PictureBox3.Visible = True
        Panel1.Visible = False
        Me.KeyPreview = True
        lblPlayerName.Text = PlayerName
    End Sub

    Private Sub frmEasy_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        PictureBox3.Visible = False
        If e.KeyCode = Keys.D Then
            tmrRight.Start()
            tmrLeft.Stop()
        ElseIf e.KeyCode = Keys.A
            tmrRight.Stop()
            tmrLeft.Start()
        End If
    End Sub

    Private Sub frmEasy_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        PictureBox3.Visible = True
        If e.KeyCode = Keys.A Then
            tmrLeft.Stop()
        End If
        If e.KeyCode = Keys.D Then
            tmrRight.Stop()
        End If

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        'Solve
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
        'Check
        If IsNumeric(txtAnswer.Text) Then
            If txtAnswer.Text = shtAns3 Then
                Score = Score + 1
                txtAnswer.Text = ""
                lblPlayerScore.Text = Score
            Else
                txtAnswer.Text = ""
                Score = Score - 1
                lblPlayerScore.Text = Score
            End If
        Else
            txtAnswer.Text = ""
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
        Me.KeyPreview = True
        Panel1.Visible = False
        lblPlayerScore.Text = Score
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Me.Close()
        My.Forms.MainMenu.Show()
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

        'Collision Check
        If PictureBox2.Bounds.IntersectsWith(picBanana1.Bounds) Or PictureBox2.Bounds.IntersectsWith(picBanana2.Bounds) Or PictureBox2.Bounds.IntersectsWith(picBanana3.Bounds) Or PictureBox2.Bounds.IntersectsWith(picBanana4.Bounds) Or PictureBox2.Bounds.IntersectsWith(picBanana5.Bounds) Or PictureBox2.Bounds.IntersectsWith(picBanana6.Bounds) Or PictureBox2.Bounds.IntersectsWith(picBanana7.Bounds) Or PictureBox2.Bounds.IntersectsWith(picBanana8.Bounds) Then
            Me.KeyPreview = False
            PictureBox3.Visible = True
            tmrLeft.Enabled = False
            tmrRight.Enabled = False
            Panel1.Visible = True
            txtAnswer.Focus()
            txtAnswer.Text = ""
            rng1 = CInt(Int(9 * Rnd()) + 1)
            rng2 = CInt(Int(9 * Rnd()) + 1)
            rng3 = CInt(Int(9 * Rnd()) + 1)
            rng4 = CInt(Int(9 * Rnd()) + 1)
            rng5 = CInt(Int(9 * Rnd()) + 1)
            rngOp1 = CInt(Int(4 * Rnd()) + 1)
            rngOp2 = CInt(Int(3 * Rnd()) + 1)
            rngOp3 = CInt(Int(4 * Rnd()) + 1)

            If rngOp1 = 1 Then
                lblOp1.Text = "+"
            ElseIf rngOp1 = 2
                lblOp1.Text = "-"
            ElseIf rngOp1 = 3
                lblOp1.Text = "x"
            ElseIf rngOp1 = 4
                lblOp1.Text = "÷"
                a = rng1
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
                b = rng4
                rng4 = b * rng5
            End If

            Num1.Text = rng1
            Num2.Text = rng2
            Num3.Text = rng3
            Num4.Text = rng4
            Num5.Text = rng5
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
        'Collision Check
        If PictureBox2.Bounds.IntersectsWith(picBanana1.Bounds) Or PictureBox2.Bounds.IntersectsWith(picBanana2.Bounds) Or PictureBox2.Bounds.IntersectsWith(picBanana3.Bounds) Or PictureBox2.Bounds.IntersectsWith(picBanana4.Bounds) Or PictureBox2.Bounds.IntersectsWith(picBanana5.Bounds) Or PictureBox2.Bounds.IntersectsWith(picBanana6.Bounds) Or PictureBox2.Bounds.IntersectsWith(picBanana7.Bounds) Or PictureBox2.Bounds.IntersectsWith(picBanana8.Bounds) Then
            Me.KeyPreview = False
            tmrRight.Enabled = False
            tmrLeft.Enabled = False
            PictureBox3.Visible = False
            Panel1.Visible = True
            txtAnswer.Focus()
            txtAnswer.Text = ""
            rng1 = CInt(Int(9 * Rnd()) + 1)
            rng2 = CInt(Int(9 * Rnd()) + 1)
            rng3 = CInt(Int(9 * Rnd()) + 1)
            rng4 = CInt(Int(9 * Rnd()) + 1)
            rng5 = CInt(Int(9 * Rnd()) + 1)
            rngOp1 = CInt(Int(4 * Rnd()) + 1)
            rngOp2 = CInt(Int(3 * Rnd()) + 1)
            rngOp3 = CInt(Int(4 * Rnd()) + 1)

            If rngOp1 = 1 Then
                lblOp1.Text = "+"
            ElseIf rngOp1 = 2
                lblOp1.Text = "-"
            ElseIf rngOp1 = 3
                lblOp1.Text = "x"
            ElseIf rngOp1 = 4
                lblOp1.Text = "÷"
                a = rng1
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
                b = rng4
                rng4 = b * rng5
            End If

            Num1.Text = rng1
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
End Class