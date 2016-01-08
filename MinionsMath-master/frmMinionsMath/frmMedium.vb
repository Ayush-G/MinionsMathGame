Public Class frmMedium

    Dim Score As Integer
    Dim Num As Short
    Dim Den As Short

    Private Sub frmEasy_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
        Me.AutoScroll = False
        PictureBox3.Visible = True
        Panel1.Visible = False
    End Sub

    Private Sub frmEasy_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        PictureBox3.Visible = False
        If e.KeyCode = Keys.D Then
            MsgBox("RIGHT")
            tmrRight.Start()
            tmrLeft.Stop()
        ElseIf e.KeyCode = Keys.A
            MsgBox("LEFT")
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

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs)
        Me.Focus()
        Panel1.Visible = False
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        End
    End Sub

    Private Sub tmrRight_Tick(sender As Object, e As EventArgs) Handles tmrRight.Tick
        'Move to the right by moving pictures to left
        picBanana1.Left -= 3
        picBanana2.Left -= 3
        picBanana3.Left -= 3
        picBanana4.Left -= 3
        picBanana5.Left -= 3
        picBanana6.Left -= 3
        picBanana7.Left -= 3
        picBanana8.Left -= 3
        'Collision Check
        If PictureBox2.Bounds.IntersectsWith(picBanana1.Bounds) Or PictureBox2.Bounds.IntersectsWith(picBanana2.Bounds) Or PictureBox2.Bounds.IntersectsWith(picBanana3.Bounds) Or PictureBox2.Bounds.IntersectsWith(picBanana4.Bounds) Or PictureBox2.Bounds.IntersectsWith(picBanana5.Bounds) Or PictureBox2.Bounds.IntersectsWith(picBanana6.Bounds) Or PictureBox2.Bounds.IntersectsWith(picBanana7.Bounds) Or PictureBox2.Bounds.IntersectsWith(picBanana8.Bounds) Then
            AnsNum.Focus()
            Panel1.Visible = True
            Num = Int(15 * Rnd() + 1)
            Den = Int((15 - Num) * Rnd() + Num)
            Numerator.Text = Num
            Denominator.Text = Den
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
            AnsNum.Focus()
            Panel1.Visible = True
            Num = Int(15 * Rnd() + 1)
            Den = Int((15 - Num) * Rnd() + Num)
            Numerator.Text = Num
            Denominator.Text = Den
        Else panel1.Visible = False
        End If
    End Sub

    Private Sub Answer_Click(sender As Object, e As EventArgs) Handles Answer.Click
        If Num / Den = AnsNum.Text / AnsDen.Text Then
            Score = Score + 1
        Else Score = Score
        End If
        Num = Int(15 * Rnd() + 1)
        Den = Int((15 - Num) * Rnd() + Num)
        Numerator.Text = Num
        Denominator.Text = Den
        lblPlayerScore.Text = Score
        AnsNum.Text = ""
        AnsDen.Text = ""
        Panel1.Visible = False
    End Sub
End Class