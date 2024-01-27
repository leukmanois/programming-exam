Public Class Login

    Private Sub loginButton_Click(sender As Object, e As EventArgs) Handles loginButton.Click

        Dim UserUserName As String = userName.Text
        Dim Password As String = userPass.Text

        If UserUserName = "amongus" And Password = "amongus123" Then
            Me.Hide()
            Menu.Show()
        Else : loginFailIndicator.Text = "Wrong username or password."
        End If
    End Sub
    Private Sub closeButton_Click(sender As Object, e As EventArgs) Handles closeButton.Click
        Application.Exit()
    End Sub
End Class
