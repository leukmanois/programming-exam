Public Class RPS
    Dim playerScoreNum As Integer = 0
    Dim computerScoreNum As Integer = 0

    Private Sub RPS_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub backToLogin_Click(sender As Object, e As EventArgs) Handles backToLogin.Click
        Me.Hide()
        Menu.Show()
    End Sub

    Private Sub buttonRock_Click(sender As Object, e As EventArgs) Handles buttonRock.Click
        PlayGame("🗿")
    End Sub

    Private Sub buttonPaper_Click(sender As Object, e As EventArgs) Handles buttonPaper.Click
        PlayGame("🧻")
    End Sub

    Private Sub buttonScissors_Click(sender As Object, e As EventArgs) Handles buttonScissors.Click
        PlayGame("⚔️")
    End Sub

    Private Sub PlayGame(playerChoice As String)
        ' Generate a random choice for the computer
        Dim choices As String() = {"🗿", "🧻", "⚔️"}
        Dim random As New Random()
        Dim computerChoice As String = choices(random.Next(choices.Length))

        If playerChoice = computerChoice Then

        ElseIf (playerChoice = "🗿" And computerChoice = "⚔️") Or
               (playerChoice = "🧻" And computerChoice = "🗿") Or
               (playerChoice = "⚔️" And computerChoice = "🧻") Then
            playerScoreNum += 1
            playerScore.Text = playerScoreNum
        Else
            computerScoreNum += 1
            computerScore.Text = computerScoreNum
        End If

        playerDisplay.Text = playerChoice
        computerDisplay.Text = computerChoice

    End Sub

    Private Sub playerScore_Click(sender As Object, e As EventArgs) Handles playerScore.Click

    End Sub
End Class