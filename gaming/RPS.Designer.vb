<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RPS
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        buttonRock = New Button()
        buttonPaper = New Button()
        buttonScissors = New Button()
        playerDisplay = New Button()
        computerDisplay = New Button()
        Label1 = New Label()
        Label2 = New Label()
        playerScore = New Label()
        computerScore = New Label()
        Label5 = New Label()
        backToLogin = New Button()
        SuspendLayout()
        ' 
        ' buttonRock
        ' 
        buttonRock.BackgroundImage = My.Resources.Resources.buttongradient
        buttonRock.BackgroundImageLayout = ImageLayout.Stretch
        buttonRock.FlatStyle = FlatStyle.Popup
        buttonRock.Font = New Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        buttonRock.ForeColor = SystemColors.ButtonFace
        buttonRock.Location = New Point(243, 286)
        buttonRock.Name = "buttonRock"
        buttonRock.Size = New Size(100, 55)
        buttonRock.TabIndex = 0
        buttonRock.Text = "🗿"
        buttonRock.UseVisualStyleBackColor = True
        ' 
        ' buttonPaper
        ' 
        buttonPaper.BackgroundImage = My.Resources.Resources.buttongradient
        buttonPaper.BackgroundImageLayout = ImageLayout.Stretch
        buttonPaper.FlatStyle = FlatStyle.Popup
        buttonPaper.Font = New Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        buttonPaper.ForeColor = SystemColors.ButtonFace
        buttonPaper.Location = New Point(349, 286)
        buttonPaper.Name = "buttonPaper"
        buttonPaper.Size = New Size(100, 55)
        buttonPaper.TabIndex = 1
        buttonPaper.Text = ChrW(55358) & ChrW(56827)
        buttonPaper.UseVisualStyleBackColor = True
        ' 
        ' buttonScissors
        ' 
        buttonScissors.BackgroundImage = My.Resources.Resources.buttongradient
        buttonScissors.BackgroundImageLayout = ImageLayout.Stretch
        buttonScissors.FlatStyle = FlatStyle.Popup
        buttonScissors.Font = New Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        buttonScissors.ForeColor = SystemColors.ButtonFace
        buttonScissors.Location = New Point(455, 286)
        buttonScissors.Name = "buttonScissors"
        buttonScissors.Size = New Size(100, 55)
        buttonScissors.TabIndex = 2
        buttonScissors.Text = "⚔️"
        buttonScissors.UseVisualStyleBackColor = True
        ' 
        ' playerDisplay
        ' 
        playerDisplay.Enabled = False
        playerDisplay.Font = New Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        playerDisplay.ForeColor = SystemColors.ControlText
        playerDisplay.Location = New Point(243, 117)
        playerDisplay.Name = "playerDisplay"
        playerDisplay.Size = New Size(100, 100)
        playerDisplay.TabIndex = 3
        playerDisplay.UseVisualStyleBackColor = True
        ' 
        ' computerDisplay
        ' 
        computerDisplay.Enabled = False
        computerDisplay.Font = New Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        computerDisplay.Location = New Point(455, 117)
        computerDisplay.Name = "computerDisplay"
        computerDisplay.Size = New Size(100, 100)
        computerDisplay.TabIndex = 4
        computerDisplay.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ButtonFace
        Label1.Location = New Point(243, 89)
        Label1.Name = "Label1"
        Label1.Size = New Size(100, 23)
        Label1.TabIndex = 5
        Label1.Text = "PLAYER"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ButtonFace
        Label2.Location = New Point(455, 89)
        Label2.Name = "Label2"
        Label2.Size = New Size(100, 23)
        Label2.TabIndex = 6
        Label2.Text = "COMPUTER"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' playerScore
        ' 
        playerScore.BackColor = Color.Transparent
        playerScore.Font = New Font("Yu Gothic UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        playerScore.ForeColor = SystemColors.ButtonFace
        playerScore.Location = New Point(349, 117)
        playerScore.Name = "playerScore"
        playerScore.Size = New Size(37, 100)
        playerScore.TabIndex = 7
        playerScore.Text = "0"
        playerScore.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' computerScore
        ' 
        computerScore.BackColor = Color.Transparent
        computerScore.Font = New Font("Yu Gothic UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        computerScore.ForeColor = SystemColors.ButtonFace
        computerScore.Location = New Point(412, 117)
        computerScore.Name = "computerScore"
        computerScore.Size = New Size(37, 100)
        computerScore.TabIndex = 8
        computerScore.Text = "0"
        computerScore.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label5
        ' 
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Yu Gothic UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = SystemColors.ButtonFace
        Label5.Location = New Point(385, 117)
        Label5.Name = "Label5"
        Label5.Size = New Size(28, 100)
        Label5.TabIndex = 9
        Label5.Text = "-"
        Label5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' backToLogin
        ' 
        backToLogin.BackgroundImage = My.Resources.Resources.buttongradient
        backToLogin.BackgroundImageLayout = ImageLayout.Stretch
        backToLogin.FlatStyle = FlatStyle.Popup
        backToLogin.ForeColor = SystemColors.ButtonFace
        backToLogin.Location = New Point(12, 12)
        backToLogin.Name = "backToLogin"
        backToLogin.Size = New Size(110, 24)
        backToLogin.TabIndex = 10
        backToLogin.Text = "Back to Menu"
        backToLogin.UseVisualStyleBackColor = True
        ' 
        ' RPS
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.logingradient
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(backToLogin)
        Controls.Add(Label5)
        Controls.Add(computerScore)
        Controls.Add(playerScore)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(computerDisplay)
        Controls.Add(playerDisplay)
        Controls.Add(buttonScissors)
        Controls.Add(buttonPaper)
        Controls.Add(buttonRock)
        DoubleBuffered = True
        Name = "RPS"
        Text = "Rock-Paper-Scissors"
        ResumeLayout(False)
    End Sub

    Friend WithEvents buttonRock As Button
    Friend WithEvents buttonPaper As Button
    Friend WithEvents buttonScissors As Button
    Friend WithEvents playerDisplay As Button
    Friend WithEvents computerDisplay As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents playerScore As Label
    Friend WithEvents computerScore As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents backToLogin As Button
End Class
