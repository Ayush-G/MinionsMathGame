Public Class frmCalc
    Dim dblNum1 As Double
    Dim dblNum2 As Double
    Dim Answer As Double
    Dim dblSet As Double
    Dim dblMem As Double
    Dim shtUse As Short
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        calcDisplay.Text = calcDisplay.Text + "1"
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        calcDisplay.Text = calcDisplay.Text + "2"
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        calcDisplay.Text = calcDisplay.Text + "3"
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        calcDisplay.Text = calcDisplay.Text + "4"
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        calcDisplay.Text = calcDisplay.Text + "5"
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        calcDisplay.Text = calcDisplay.Text + "6"
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        calcDisplay.Text = calcDisplay.Text + "7"
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        calcDisplay.Text = calcDisplay.Text + "8"
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        calcDisplay.Text = calcDisplay.Text + "9"
    End Sub

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        calcDisplay.Text = calcDisplay.Text + "0"
    End Sub

    Private Sub btnMinus_Click(sender As Object, e As EventArgs) Handles btnMinus.Click
        If calcDisplay.Text = "" Then
            calcDisplay.Text = "-"
        Else
            dblNum1 = calcDisplay.Text
            calcDisplay.Text = ""
            dblSet = 2
        End If

    End Sub

    Private Sub btnPlus_Click(sender As Object, e As EventArgs) Handles btnPlus.Click
        dblNum1 = calcDisplay.Text
        calcDisplay.Text = ""
        dblSet = 1
    End Sub

    Private Sub btnDecimal_Click(sender As Object, e As EventArgs) Handles btnDecimal.Click
        If calcDisplay.Text.Contains(".") Then
            calcDisplay.Text = calcDisplay.Text
        Else
            calcDisplay.Text = calcDisplay.Text & "."
        End If
    End Sub

    Private Sub btnMultiply_Click(sender As Object, e As EventArgs) Handles btnMultiply.Click
        dblNum1 = calcDisplay.Text
        calcDisplay.Text = ""
        dblSet = 3
    End Sub

    Private Sub btnDivide_Click(sender As Object, e As EventArgs) Handles btnDivide.Click
        dblNum1 = calcDisplay.Text
        calcDisplay.Text = ""
        dblSet = 4
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnExp.Click
        dblNum1 = calcDisplay.Text
        calcDisplay.Text = ""
        dblSet = 5
    End Sub


    Private Sub btnSqrt_Click(sender As Object, e As EventArgs) Handles btnSqrt.Click
        dblNum1 = calcDisplay.Text
        Answer = dblNum1 ^ 0.5
        calcDisplay.Text = Answer
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        calcDisplay.Text = ""
    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        If Len(calcDisplay.Text) > 1 Then
            calcDisplay.Text = Mid(calcDisplay.Text, 1, Len(calcDisplay.Text) - 1)
        Else
            calcDisplay.Text = ""
        End If
    End Sub

    Private Sub btnMem1_Click(sender As Object, e As EventArgs) Handles btnMS.Click
        dblMem = calcDisplay.Text
        calcDisplay.Text = ""
    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles btnMR.Click
        calcDisplay.Text = dblMem
    End Sub

    Private Sub btnMPlus_Click(sender As Object, e As EventArgs) Handles btnMPlus.Click
        dblMem = calcDisplay.Text + dblMem
        calcDisplay.Text = ""
    End Sub

    Private Sub btnMClear_Click(sender As Object, e As EventArgs) Handles btnMClear.Click
        dblMem = 0
    End Sub

    Private Sub btnEqual_Click(sender As Object, e As EventArgs) Handles btnEqual.Click
        If calcDisplay.Text = "" Then
            dblNum2 = 0
        Else dblNum2 = calcDisplay.Text

        End If
        If dblSet = 1 Then
            Answer = dblNum1 + dblNum2
            calcDisplay.Text = ""
            calcDisplay.Text = Answer
        ElseIf dblSet = 2 Then
            Answer = dblNum1 - dblNum2
            calcDisplay.Text = ""
            calcDisplay.Text = Answer
        ElseIf dblSet = 3 Then
            Answer = dblNum1 * dblNum2
            calcDisplay.Text = ""
            calcDisplay.Text = Answer
        ElseIf dblSet = 4 Then
            Answer = dblNum1 / dblNum2
            calcDisplay.Text = ""
            calcDisplay.Text = Answer
        ElseIf dblSet = 5 Then
            Answer = dblNum1 ^ dblNum2
            calcDisplay.Text = ""
            calcDisplay.Text = Answer
        Else
            calcDisplay.Text = "0"
        End If
    End Sub

    Private Sub btnUse_Click_3(sender As Object, e As EventArgs) Handles btnUse.Click
        shtUse = calcDisplay.Text
        My.Forms.frmHard.txtAnswer.Text = shtUse
    End Sub
End Class