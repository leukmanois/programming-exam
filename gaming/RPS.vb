Public Class RPS
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub RPS_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub backToLogin_Click(sender As Object, e As EventArgs) Handles backToLogin.Click
        Me.Hide()
        Menu.Show()
    End Sub
End Class