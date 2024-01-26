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
        tileOne = New Button()
        tileTwo = New Button()
        tileThree = New Button()
        tileFour = New Button()
        tileFive = New Button()
        tileSix = New Button()
        tileSeven = New Button()
        tileEight = New Button()
        SuspendLayout()
        ' 
        ' tileOne
        ' 
        tileOne.BackgroundImage = My.Resources.Resources.buttongradient
        tileOne.BackgroundImageLayout = ImageLayout.Stretch
        tileOne.FlatStyle = FlatStyle.Popup
        tileOne.Location = New Point(158, 195)
        tileOne.Name = "tileOne"
        tileOne.Size = New Size(75, 75)
        tileOne.TabIndex = 0
        tileOne.UseVisualStyleBackColor = True
        ' 
        ' tileTwo
        ' 
        tileTwo.BackgroundImage = My.Resources.Resources.buttongradient
        tileTwo.BackgroundImageLayout = ImageLayout.Stretch
        tileTwo.FlatStyle = FlatStyle.Popup
        tileTwo.Location = New Point(248, 150)
        tileTwo.Name = "tileTwo"
        tileTwo.Size = New Size(75, 75)
        tileTwo.TabIndex = 1
        tileTwo.UseVisualStyleBackColor = True
        ' 
        ' tileThree
        ' 
        tileThree.BackgroundImage = My.Resources.Resources.buttongradient
        tileThree.BackgroundImageLayout = ImageLayout.Stretch
        tileThree.FlatStyle = FlatStyle.Popup
        tileThree.Location = New Point(248, 240)
        tileThree.Name = "tileThree"
        tileThree.Size = New Size(75, 75)
        tileThree.TabIndex = 2
        tileThree.UseVisualStyleBackColor = True
        ' 
        ' tileFour
        ' 
        tileFour.BackgroundImage = My.Resources.Resources.buttongradient
        tileFour.BackgroundImageLayout = ImageLayout.Stretch
        tileFour.FlatStyle = FlatStyle.Popup
        tileFour.Location = New Point(338, 150)
        tileFour.Name = "tileFour"
        tileFour.Size = New Size(75, 75)
        tileFour.TabIndex = 3
        tileFour.UseVisualStyleBackColor = True
        ' 
        ' tileFive
        ' 
        tileFive.BackgroundImage = My.Resources.Resources.buttongradient
        tileFive.BackgroundImageLayout = ImageLayout.Stretch
        tileFive.FlatStyle = FlatStyle.Popup
        tileFive.Location = New Point(338, 240)
        tileFive.Name = "tileFive"
        tileFive.Size = New Size(75, 75)
        tileFive.TabIndex = 4
        tileFive.UseVisualStyleBackColor = True
        ' 
        ' tileSix
        ' 
        tileSix.BackgroundImage = My.Resources.Resources.buttongradient
        tileSix.BackgroundImageLayout = ImageLayout.Stretch
        tileSix.FlatStyle = FlatStyle.Popup
        tileSix.Location = New Point(428, 150)
        tileSix.Name = "tileSix"
        tileSix.Size = New Size(75, 75)
        tileSix.TabIndex = 5
        tileSix.UseVisualStyleBackColor = True
        ' 
        ' tileSeven
        ' 
        tileSeven.BackgroundImage = My.Resources.Resources.buttongradient
        tileSeven.BackgroundImageLayout = ImageLayout.Stretch
        tileSeven.FlatStyle = FlatStyle.Popup
        tileSeven.Location = New Point(428, 240)
        tileSeven.Name = "tileSeven"
        tileSeven.Size = New Size(75, 75)
        tileSeven.TabIndex = 6
        tileSeven.UseVisualStyleBackColor = True
        ' 
        ' tileEight
        ' 
        tileEight.BackgroundImage = My.Resources.Resources.buttongradient
        tileEight.BackgroundImageLayout = ImageLayout.Stretch
        tileEight.FlatStyle = FlatStyle.Popup
        tileEight.Location = New Point(518, 195)
        tileEight.Name = "tileEight"
        tileEight.Size = New Size(75, 75)
        tileEight.TabIndex = 7
        tileEight.UseVisualStyleBackColor = True
        ' 
        ' Glass
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.logingradient
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(tileEight)
        Controls.Add(tileSeven)
        Controls.Add(tileSix)
        Controls.Add(tileFive)
        Controls.Add(tileFour)
        Controls.Add(tileThree)
        Controls.Add(tileTwo)
        Controls.Add(tileOne)
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
End Class
