Public Class frmEasy
    Dim RandomImage As Integer
    Dim Score As Integer

    Private Sub frmEasy_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
        Me.AutoScroll = False
        PictureBox3.Visible = True
        Panel1.Visible = False
        Me.KeyPreview = True
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

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If RandomImage = 0 Then
            If RadioButton1.Checked = True Then
                MsgBox("Correct Answer")
                lblPlayerScore.Text = lblPlayerScore.Text + 1
            Else
                MsgBox("Incorrect Answer")
                lblPlayerScore.Text = lblPlayerScore.Text - 1
            End If
        ElseIf RandomImage = 1 Then
            If RadioButton2.Checked = True Then
                MsgBox("Correct Answer")
                lblPlayerScore.Text = lblPlayerScore.Text + 1
            Else
                MsgBox("Incorrect Answer")
                lblPlayerScore.Text = lblPlayerScore.Text - 1
            End If
        ElseIf RandomImage = 2 Then
            If RadioButton3.Checked = True Then
                MsgBox("Correct Answer")
                lblPlayerScore.Text = lblPlayerScore.Text + 1
            Else
                MsgBox("Incorrect Answer")
                lblPlayerScore.Text = lblPlayerScore.Text - 1
            End If
        ElseIf RandomImage = 3 Then
            If RadioButton4.Checked = True Then
                MsgBox("Correct Answer")
                lblPlayerScore.Text = lblPlayerScore.Text + 1
            Else
                MsgBox("Incorrect Answer")
                lblPlayerScore.Text = lblPlayerScore.Text - 1
            End If
        ElseIf RandomImage = 4 Then
            If RadioButton5.Checked = True Then
                MsgBox("Correct Answer")
                lblPlayerScore.Text = lblPlayerScore.Text + 1
            Else
                MsgBox("Incorrect Answer")
                lblPlayerScore.Text = lblPlayerScore.Text - 1
            End If
        ElseIf RandomImage = 5 Then
            If RadioButton6.Checked = True Then
                MsgBox("Correct Answer")
                lblPlayerScore.Text = lblPlayerScore.Text + 1
            Else
                MsgBox("Incorrect Answer")
                lblPlayerScore.Text = lblPlayerScore.Text - 1
            End If
        ElseIf RandomImage = 6 Then
            If RadioButton7.Checked = True Then
                MsgBox("Correct Answer")
                lblPlayerScore.Text = lblPlayerScore.Text + 1
            Else
                MsgBox("Incorrect Answer")
                lblPlayerScore.Text = lblPlayerScore.Text - 1
            End If
        End If
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
            Me.KeyPreview = False
            RandomImage = Int(7 * Rnd() + 0)
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
            Else
                picShape.Image = ImageList1.Images(6)
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
        'Collision Check
        If PictureBox2.Bounds.IntersectsWith(picBanana1.Bounds) Or PictureBox2.Bounds.IntersectsWith(picBanana2.Bounds) Or PictureBox2.Bounds.IntersectsWith(picBanana3.Bounds) Or PictureBox2.Bounds.IntersectsWith(picBanana4.Bounds) Or PictureBox2.Bounds.IntersectsWith(picBanana5.Bounds) Or PictureBox2.Bounds.IntersectsWith(picBanana6.Bounds) Or PictureBox2.Bounds.IntersectsWith(picBanana7.Bounds) Or PictureBox2.Bounds.IntersectsWith(picBanana8.Bounds) Then
            RadioButton1.Focus()
            RandomImage = Int(7 * Rnd() + 0)
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
            Else
                picShape.Image = ImageList1.Images(6)
            End If
        End If
    End Sub

End Class