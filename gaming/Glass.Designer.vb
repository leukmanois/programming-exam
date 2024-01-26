<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Glass
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
        tile1 = New Button()
        tile2 = New Button()
        tile3 = New Button()
        tile4 = New Button()
        tile5 = New Button()
        tile6 = New Button()
        tile7 = New Button()
        tile8 = New Button()
        backToLogin = New Button()
        SuspendLayout()
        ' 
        ' tile1
        ' 
        tile1.BackgroundImage = My.Resources.Resources.buttongradient
        tile1.BackgroundImageLayout = ImageLayout.Stretch
        tile1.FlatStyle = FlatStyle.Popup
        tile1.Location = New Point(158, 195)
        tile1.Name = "tile1"
        tile1.Size = New Size(75, 75)
        tile1.TabIndex = 0
        tile1.UseVisualStyleBackColor = True
        ' 
        ' tile2
        ' 
        tile2.BackgroundImage = My.Resources.Resources.buttongradient
        tile2.BackgroundImageLayout = ImageLayout.Stretch
        tile2.FlatStyle = FlatStyle.Popup
        tile2.Location = New Point(248, 150)
        tile2.Name = "tile2"
        tile2.Size = New Size(75, 75)
        tile2.TabIndex = 1
        tile2.UseVisualStyleBackColor = True
        ' 
        ' tile3
        ' 
        tile3.BackgroundImage = My.Resources.Resources.buttongradient
        tile3.BackgroundImageLayout = ImageLayout.Stretch
        tile3.FlatStyle = FlatStyle.Popup
        tile3.Location = New Point(248, 240)
        tile3.Name = "tile3"
        tile3.Size = New Size(75, 75)
        tile3.TabIndex = 2
        tile3.UseVisualStyleBackColor = True
        ' 
        ' tile4
        ' 
        tile4.BackgroundImage = My.Resources.Resources.buttongradient
        tile4.BackgroundImageLayout = ImageLayout.Stretch
        tile4.FlatStyle = FlatStyle.Popup
        tile4.Location = New Point(338, 150)
        tile4.Name = "tile4"
        tile4.Size = New Size(75, 75)
        tile4.TabIndex = 3
        tile4.UseVisualStyleBackColor = True
        ' 
        ' tile5
        ' 
        tile5.BackgroundImage = My.Resources.Resources.buttongradient
        tile5.BackgroundImageLayout = ImageLayout.Stretch
        tile5.FlatStyle = FlatStyle.Popup
        tile5.Location = New Point(338, 240)
        tile5.Name = "tile5"
        tile5.Size = New Size(75, 75)
        tile5.TabIndex = 4
        tile5.UseVisualStyleBackColor = True
        ' 
        ' tile6
        ' 
        tile6.BackgroundImage = My.Resources.Resources.buttongradient
        tile6.BackgroundImageLayout = ImageLayout.Stretch
        tile6.FlatStyle = FlatStyle.Popup
        tile6.Location = New Point(428, 150)
        tile6.Name = "tile6"
        tile6.Size = New Size(75, 75)
        tile6.TabIndex = 5
        tile6.UseVisualStyleBackColor = True
        ' 
        ' tile7
        ' 
        tile7.BackgroundImage = My.Resources.Resources.buttongradient
        tile7.BackgroundImageLayout = ImageLayout.Stretch
        tile7.FlatStyle = FlatStyle.Popup
        tile7.Location = New Point(428, 240)
        tile7.Name = "tile7"
        tile7.Size = New Size(75, 75)
        tile7.TabIndex = 6
        tile7.UseVisualStyleBackColor = True
        ' 
        ' tile8
        ' 
        tile8.BackgroundImage = My.Resources.Resources.buttongradient
        tile8.BackgroundImageLayout = ImageLayout.Stretch
        tile8.FlatStyle = FlatStyle.Popup
        tile8.Location = New Point(518, 195)
        tile8.Name = "tile8"
        tile8.Size = New Size(75, 75)
        tile8.TabIndex = 7
        tile8.UseVisualStyleBackColor = True
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
        backToLogin.TabIndex = 11
        backToLogin.Text = "Back to Menu"
        backToLogin.UseVisualStyleBackColor = True
        ' 
        ' Glass
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.logingradient
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(751, 450)
        Controls.Add(backToLogin)
        Controls.Add(tile8)
        Controls.Add(tile7)
        Controls.Add(tile6)
        Controls.Add(tile5)
        Controls.Add(tile4)
        Controls.Add(tile3)
        Controls.Add(tile2)
        Controls.Add(tile1)
        DoubleBuffered = True
        Name = "Glass"
        Text = "Glass"
        ResumeLayout(False)
    End Sub

    Friend WithEvents tileOne As Button
    Friend WithEvents tileTwo As Button
    Friend WithEvents tileThree As Button
    Friend WithEvents tileFour As Button
    Friend WithEvents tileFive As Button
    Friend WithEvents tileSix As Button
    Friend WithEvents tileSeven As Button
    Friend WithEvents tileEight As Button
    Friend WithEvents tile1 As Button
    Friend WithEvents tile2 As Button
    Friend WithEvents tile3 As Button
    Friend WithEvents tile4 As Button
    Friend WithEvents tile5 As Button
    Friend WithEvents tile6 As Button
    Friend WithEvents tile7 As Button
    Friend WithEvents tile8 As Button
    Friend WithEvents backToLogin As Button
End Class
