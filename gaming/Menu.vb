Public Class Menu
    Private Sub Calculator_Click(sender As Object, e As EventArgs) Handles Calcu.Click
        Me.Hide()
        Calculator.Show()
    End Sub

    Private Sub RPS_Click(sender As Object, e As EventArgs) Handles RockPaper.Click
        Me.Hide()
        RPS.Show()
    End Sub

    Private Sub Glass_Click(sender As Object, e As EventArgs) Handles GlassGe.Click
        Me.Hide()
        Glass.Show()
    End Sub
    Private Sub backToLogin_Click(sender As Object, e As EventArgs) Handles backToLogin.Click
        Me.Hide()
        Login.Show()
    End Sub
End Class