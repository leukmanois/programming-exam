' QUOTA IN SCHOOL 01.27.24
' Turn messageboxes into labels + add replay button with ResetGame()

Public Class Glass
    Dim playerPosition As Integer = 1 ' Starting position
    Dim gameOver As Boolean = False
    Dim random As New Random()

    Private Sub Glass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set the starting position
        SetPlayerPosition()
        DisableUpdate()
    End Sub

    Private Sub SetPlayerPosition()
        Me.Controls("tile" & playerPosition).Text = "🚶"
    End Sub

    Private Sub MovePlayer(nextPosition As Integer)
        ' Update the player position
        Me.Controls("tile" & playerPosition).Text = "" ' Clear current position
        playerPosition = nextPosition
        SetPlayerPosition()
        DisableUpdate()
    End Sub

    Private Sub CheckGameOver()
        ' For the message boxes if you reached tile8 or just died lmao 🔥🔥
        If playerPosition = 8 Then
            MessageBox.Show("Congratulations! You reached the end platform.")
            ResetGame()
        ElseIf random.Next(2) = 0 Then ' The 50% chance of dying
            MessageBox.Show("Oops! You stepped on a fragile glass panel. Game over.")
            ResetGame()
        End If
    End Sub

    Private Sub ResetGame()
        gameOver = False

        ' Clear player emoji
        For i As Integer = 1 To 8
            Me.Controls("tile" & i).Text = ""
        Next

        ' Reset playerPosition then put player emoji on playerPosition, also updates disabled buttons yeah
        playerPosition = 1
        SetPlayerPosition()
        DisableUpdate()
    End Sub

    Private Sub DisableUpdate()
        If playerPosition = 1 Then
            For i As Integer = 1 To 8
                Me.Controls("tile" & i).Enabled = False
            Next
            tile2.Enabled = True
            tile3.Enabled = True
        ElseIf playerPosition = 2 Or playerPosition = 3 Then
            For i As Integer = 1 To 8
                Me.Controls("tile" & i).Enabled = False
            Next
            tile4.Enabled = True
            tile5.Enabled = True
        ElseIf playerPosition = 4 Or playerPosition = 5 Then
            For i As Integer = 1 To 8
                Me.Controls("tile" & i).Enabled = False
            Next
            tile6.Enabled = True
            tile7.Enabled = True
        ElseIf playerPosition = 6 Or playerPosition = 7 Then
            For i As Integer = 1 To 8
                Me.Controls("tile" & i).Enabled = False
            Next
            tile8.Enabled = True
        End If
    End Sub

    Private Sub tile2_Click(sender As Object, e As EventArgs) Handles tile2.Click
        If Not gameOver Then
            MovePlayer(2)
            CheckGameOver()
        End If
    End Sub

    Private Sub tile3_Click(sender As Object, e As EventArgs) Handles tile3.Click
        If Not gameOver Then
            MovePlayer(3)
            CheckGameOver()
        End If
    End Sub

    Private Sub tile4_Click(sender As Object, e As EventArgs) Handles tile4.Click
        If Not gameOver Then
            MovePlayer(4)
            CheckGameOver()
        End If
    End Sub

    Private Sub tile5_Click(sender As Object, e As EventArgs) Handles tile5.Click
        If Not gameOver Then
            MovePlayer(5)
            CheckGameOver()
        End If
    End Sub

    Private Sub tile6_Click(sender As Object, e As EventArgs) Handles tile6.Click
        If Not gameOver Then
            MovePlayer(6)
            CheckGameOver()
        End If
    End Sub

    Private Sub tile7_Click(sender As Object, e As EventArgs) Handles tile7.Click
        If Not gameOver Then
            MovePlayer(7)
            CheckGameOver()
        End If
    End Sub

    Private Sub tile8_Click(sender As Object, e As EventArgs) Handles tile8.Click
        If Not gameOver Then
            MovePlayer(8)
            CheckGameOver()
        End If
    End Sub

    Private Sub backToLogin_Click(sender As Object, e As EventArgs) Handles backToLogin.Click
        ResetGame()
        Me.Hide()
        Menu.Show()
    End Sub
End Class
