Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Calculator
    Dim firstNum As Double
    Dim secondNum As Double
    Dim operand As String

    Private Sub buttonZero_Click(sender As Object, e As EventArgs) Handles buttonZero.Click
        calcBox.Text = calcBox.Text + sender.text
    End Sub
    Private Sub buttonOne_Click(sender As Object, e As EventArgs) Handles buttonOne.Click
        calcBox.Text = calcBox.Text + sender.text
    End Sub
    Private Sub buttonTwo_Click(sender As Object, e As EventArgs) Handles buttonTwo.Click
        calcBox.Text = calcBox.Text + sender.text
    End Sub
    Private Sub buttonThree_Click(sender As Object, e As EventArgs) Handles buttonThree.Click
        calcBox.Text = calcBox.Text + sender.text
    End Sub
    Private Sub buttonFour_Click(sender As Object, e As EventArgs) Handles buttonFour.Click
        calcBox.Text = calcBox.Text + sender.text
    End Sub
    Private Sub buttonFive_Click(sender As Object, e As EventArgs) Handles buttonFive.Click
        calcBox.Text = calcBox.Text + sender.text
    End Sub
    Private Sub buttonSix_Click(sender As Object, e As EventArgs) Handles buttonSix.Click
        calcBox.Text = calcBox.Text + sender.text
    End Sub
    Private Sub buttonSeven_Click(sender As Object, e As EventArgs) Handles buttonSeven.Click
        calcBox.Text = calcBox.Text + sender.text
    End Sub
    Private Sub buttonEight_Click(sender As Object, e As EventArgs) Handles buttonEight.Click
        calcBox.Text = calcBox.Text + sender.text
    End Sub
    Private Sub buttonNine_Click(sender As Object, e As EventArgs) Handles buttonNine.Click
        calcBox.Text = calcBox.Text + sender.text
    End Sub

    Private Sub buttonPlus_Click(sender As Object, e As EventArgs) Handles buttonPlus.Click
        firstNum = Val(calcBox.Text)
        calcBox.Text = ""
        calcBox.Focus()
        operand = "+"
    End Sub

    Private Sub buttonMinus_Click(sender As Object, e As EventArgs) Handles buttonMinus.Click
        firstNum = Val(calcBox.Text)
        calcBox.Text = ""
        calcBox.Focus()
        operand = "-"
    End Sub

    Private Sub buttonMultiply_Click(sender As Object, e As EventArgs) Handles buttonMultiply.Click
        firstNum = Val(calcBox.Text)
        calcBox.Text = ""
        calcBox.Focus()
        operand = "*"
    End Sub

    Private Sub buttonDivide_Click(sender As Object, e As EventArgs) Handles buttonDivide.Click
        firstNum = Val(calcBox.Text)
        calcBox.Text = ""
        calcBox.Focus()
        operand = "/"
    End Sub

    Private Sub buttonEquals_Click(sender As Object, e As EventArgs) Handles buttonEquals.Click
        Dim result As Double
        secondNum = Val(calcBox.Text)

        Select Case operand
            Case "+"
                result = firstNum + secondNum
                calcBox.Text = result.ToString()
            Case "-"
                result = firstNum - secondNum
                calcBox.Text = result.ToString()
            Case "/"
                result = firstNum / secondNum
                calcBox.Text = result.ToString()
            Case "*"
                result = firstNum * secondNum
                calcBox.Text = result.ToString()
        End Select
    End Sub

    Private Sub resetButton_Click(sender As Object, e As EventArgs) Handles resetButton.Click
        calcBox.Text = ""
        firstNum = 0
    End Sub

    Private Sub backToLogin_Click(sender As Object, e As EventArgs) Handles backToLogin.Click
        Me.Hide()
        Menu.Show()
    End Sub
End Class