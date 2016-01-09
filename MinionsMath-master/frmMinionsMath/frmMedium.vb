Public Class frmMedium
    Dim Num As Short 'dims variables
    Dim Den As Short
    Dim TallyNum As Short
    Dim lvlScore As Integer
    Dim lvlWrong As Integer
    Dim charactersAllowed As String = "1234567890" 'characters permitted in textboxes
    Private Sub frmEasy_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
        Me.AutoScroll = False 'no scrolling
        PictureBox3.Visible = True 'still minion picture
        Panel1.Visible = False 'no question
        Me.KeyPreview = True ' keys enabled
        lblPlayerName.Text = PlayerName 'name shown
        lblPlayerScore.Text = Score 'updates player score
        Me.Focus() 'focused on the form so you don't type in hidden textboxes :P
    End Sub

    Private Sub frmEasy_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        PictureBox3.Visible = False 'walking minion shown
        If e.KeyCode = Keys.D Then 'keys start the timer for direction, respectively
            tmrRight.Start()
            tmrLeft.Stop()
        ElseIf e.KeyCode = Keys.A
            tmrRight.Stop()
            tmrLeft.Start()
        End If
    End Sub

    Private Sub frmEasy_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        PictureBox3.Visible = True ' walking minion animation disappears
        If e.KeyCode = Keys.A Then ' keys stop timer
            tmrLeft.Stop()
        End If
        If e.KeyCode = Keys.D Then
            tmrRight.Stop()
        End If

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If Num / Den = AnsNum.Text / AnsDen.Text Then 'checks answer
            lvlScore += 1
            If UpDblPts = True Then 'awards score based on level of upgrades
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

        Me.Focus() 'refocus to form
        Me.KeyPreview = True 'keys enabled
        Panel1.Visible = False 'question panel disappears
        lblPlayerScore.Text = Score 'player's score updated
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Me.Close() 'close level
        My.Forms.MainMenu.Show() ' go to main menu
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

        'Collision Check and generates question
        If PictureBox2.Bounds.IntersectsWith(picBanana1.Bounds) Or PictureBox2.Bounds.IntersectsWith(picBanana2.Bounds) Or PictureBox2.Bounds.IntersectsWith(picBanana3.Bounds) Or PictureBox2.Bounds.IntersectsWith(picBanana4.Bounds) Or PictureBox2.Bounds.IntersectsWith(picBanana5.Bounds) Or PictureBox2.Bounds.IntersectsWith(picBanana6.Bounds) Or PictureBox2.Bounds.IntersectsWith(picBanana7.Bounds) Or PictureBox2.Bounds.IntersectsWith(picBanana8.Bounds) Then
            Me.KeyPreview = False
            PictureBox3.Visible = True
            tmrLeft.Enabled = False
            tmrRight.Enabled = False
            Panel1.Visible = True
            AnsNum.Focus()
            AnsNum.Text = ""
            AnsDen.Text = ""
            Num = Int(15 * Rnd() + 1)
            Den = Int((15 - Num) * Rnd() + Num)
            Numerator.Text = Num
            Denominator.Text = Den
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

        'Collision Check and generates question
        If PictureBox2.Bounds.IntersectsWith(picBanana1.Bounds) Or PictureBox2.Bounds.IntersectsWith(picBanana2.Bounds) Or PictureBox2.Bounds.IntersectsWith(picBanana3.Bounds) Or PictureBox2.Bounds.IntersectsWith(picBanana4.Bounds) Or PictureBox2.Bounds.IntersectsWith(picBanana5.Bounds) Or PictureBox2.Bounds.IntersectsWith(picBanana6.Bounds) Or PictureBox2.Bounds.IntersectsWith(picBanana7.Bounds) Or PictureBox2.Bounds.IntersectsWith(picBanana8.Bounds) Then
            Me.KeyPreview = False
            tmrRight.Enabled = False
            tmrLeft.Enabled = False
            PictureBox3.Visible = False
            Panel1.Visible = True
            AnsNum.Focus()
            AnsNum.Text = ""
            AnsDen.Text = ""
            Num = Int(15 * Rnd() + 1)
            Den = Int((15 - Num) * Rnd() + Num)
            Numerator.Text = Num
            Denominator.Text = Den
        End If
    End Sub

    Private Sub AnsNum_TextChanged(sender As Object, e As EventArgs) Handles AnsNum.TextChanged
        Dim theText As String = AnsNum.Text
        Dim Letter As String
        Dim SelectionIndex As Integer = AnsNum.SelectionStart
        Dim Change As Integer
        ' Ensures that the text entered into the box is only a numeric value.
        For x As Integer = 0 To AnsNum.Text.Length - 1
            Letter = AnsNum.Text.Substring(x, 1)
            If charactersAllowed.Contains(Letter) = False Then
                theText = theText.Replace(Letter, String.Empty)
                Change = 1
            End If
        Next

        AnsNum.Text = theText
        AnsNum.Select(SelectionIndex - Change, 0)
    End Sub

    Private Sub AnsDen_TextChanged(sender As Object, e As EventArgs) Handles AnsDen.TextChanged
        Dim theText As String = AnsDen.Text
        Dim Letter As String
        Dim SelectionIndex As Integer = AnsDen.SelectionStart
        Dim Change As Integer
        ' Ensures that the text entered into the box is only a numeric value.
        For x As Integer = 0 To AnsDen.Text.Length - 1
            Letter = AnsDen.Text.Substring(x, 1)
            If charactersAllowed.Contains(Letter) = False Then
                theText = theText.Replace(Letter, String.Empty)
                Change = 1
            End If
        Next

        AnsDen.Text = theText
        AnsDen.Select(SelectionIndex - Change, 0)
    End Sub

    Private Sub AnsNum_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles AnsNum.KeyDown
        If e.KeyCode = Keys.Enter Then 'able to click enter to submit answer
            btnSubmit.PerformClick()
        End If
    End Sub

    Private Sub AnsDen_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles AnsDen.KeyDown
        If e.KeyCode = Keys.Enter Then 'able to click enter to submit answer
            btnSubmit.PerformClick()
        End If
    End Sub

End Class