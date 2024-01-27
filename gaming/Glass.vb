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
        If playerPosition = 14 Then
            gameIndicator.ForeColor = Color.YellowGreen
            gameIndicator.Text = "You won!"
        ElseIf random.Next(2) = 0 Then ' The 50% chance of dying
            Me.Controls("tile" & playerPosition).Text = "💀"
            For i As Integer = 1 To 14
                Me.Controls("tile" & i).Enabled = False
            Next
            gameIndicator.ForeColor = Color.IndianRed
            gameIndicator.Text = "You died!"
        End If
    End Sub

    Private Sub ResetGame()
        gameOver = False

        ' Clear player emoji and reset font colors
        For i As Integer = 1 To 14
            Me.Controls("tile" & i).Text = ""
        Next

        gameIndicator.Text = ""

        ' Reset playerPosition then put player emoji on playerPosition, also updates disabled buttons yeah
        playerPosition = 1
        SetPlayerPosition()
        DisableUpdate()
    End Sub

    Private Sub DisableUpdate()
        For i As Integer = 1 To 14
            Me.Controls("tile" & i).Enabled = False
        Next
        If playerPosition = 1 Then
            tile2.Enabled = True
            tile3.Enabled = True
        ElseIf playerPosition = 2 Or playerPosition = 3 Then
            tile4.Enabled = True
            tile5.Enabled = True
        ElseIf playerPosition = 4 Or playerPosition = 5 Then
            tile6.Enabled = True
            tile7.Enabled = True
        ElseIf playerPosition = 6 Or playerPosition = 7 Then
            tile8.Enabled = True
            tile9.Enabled = True
        ElseIf playerPosition = 8 Or playerPosition = 9 Then
            tile10.Enabled = True
            tile11.Enabled = True
        ElseIf playerPosition = 10 Or playerPosition = 11 Then
            tile12.Enabled = True
            tile13.Enabled = True
        ElseIf playerPosition = 12 Or playerPosition = 13 Then
            tile14.Enabled = True
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

    Private Sub tile9_Click(sender As Object, e As EventArgs) Handles tile9.Click
        If Not gameOver Then
            MovePlayer(9)
            CheckGameOver()
        End If
    End Sub

    Private Sub tile10_Click(sender As Object, e As EventArgs) Handles tile10.Click
        If Not gameOver Then
            MovePlayer(10)
            CheckGameOver()
        End If
    End Sub

    Private Sub tile11_Click(sender As Object, e As EventArgs) Handles tile11.Click
        If Not gameOver Then
            MovePlayer(11)
            CheckGameOver()
        End If
    End Sub

    Private Sub tile12_Click(sender As Object, e As EventArgs) Handles tile12.Click
        If Not gameOver Then
            MovePlayer(12)
            CheckGameOver()
        End If
    End Sub

    Private Sub tile13_Click(sender As Object, e As EventArgs) Handles tile13.Click
        If Not gameOver Then
            MovePlayer(13)
            CheckGameOver()
        End If
    End Sub

    Private Sub tile14_Click(sender As Object, e As EventArgs) Handles tile14.Click
        If Not gameOver Then
            MovePlayer(14)
            CheckGameOver()
        End If
    End Sub
    Private Sub backToLogin_Click(sender As Object, e As EventArgs) Handles backToLogin.Click
        ResetGame()
        Me.Hide()
        Menu.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ResetGame()
    End Sub
End Class
