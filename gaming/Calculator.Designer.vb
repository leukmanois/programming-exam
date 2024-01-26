<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Calculator
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
        calcBox = New TextBox()
        buttonSeven = New Button()
        buttonEight = New Button()
        buttonNine = New Button()
        buttonDivide = New Button()
        buttonMultiply = New Button()
        buttonMinus = New Button()
        buttonPlus = New Button()
        buttonSix = New Button()
        buttonFive = New Button()
        buttonFour = New Button()
        buttonThree = New Button()
        buttonZero = New Button()
        buttonTwo = New Button()
        buttonOne = New Button()
        buttonEquals = New Button()
        resetButton = New Button()
        backToLogin = New Button()
        SuspendLayout()
        ' 
        ' calcBox
        ' 
        calcBox.Font = New Font("Yu Gothic UI", 30F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        calcBox.Location = New Point(13, 41)
        calcBox.MaximumSize = New Size(357, 60)
        calcBox.MinimumSize = New Size(358, 60)
        calcBox.Name = "calcBox"
        calcBox.ReadOnly = True
        calcBox.RightToLeft = RightToLeft.Yes
        calcBox.Size = New Size(358, 60)
        calcBox.TabIndex = 0
        ' 
        ' buttonSeven
        ' 
        buttonSeven.BackgroundImage = My.Resources.Resources.buttongradient
        buttonSeven.BackgroundImageLayout = ImageLayout.Stretch
        buttonSeven.FlatStyle = FlatStyle.Popup
        buttonSeven.Font = New Font("Yu Gothic UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        buttonSeven.ForeColor = SystemColors.ButtonFace
        buttonSeven.Location = New Point(13, 107)
        buttonSeven.Name = "buttonSeven"
        buttonSeven.Size = New Size(85, 85)
        buttonSeven.TabIndex = 1
        buttonSeven.Text = "7"
        buttonSeven.UseVisualStyleBackColor = True
        ' 
        ' buttonEight
        ' 
        buttonEight.BackgroundImage = My.Resources.Resources.buttongradient
        buttonEight.BackgroundImageLayout = ImageLayout.Stretch
        buttonEight.FlatStyle = FlatStyle.Popup
        buttonEight.Font = New Font("Yu Gothic UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        buttonEight.ForeColor = SystemColors.ButtonFace
        buttonEight.Location = New Point(104, 107)
        buttonEight.Name = "buttonEight"
        buttonEight.Size = New Size(85, 85)
        buttonEight.TabIndex = 2
        buttonEight.Text = "8"
        buttonEight.UseVisualStyleBackColor = True
        ' 
        ' buttonNine
        ' 
        buttonNine.BackgroundImage = My.Resources.Resources.buttongradient
        buttonNine.BackgroundImageLayout = ImageLayout.Stretch
        buttonNine.FlatStyle = FlatStyle.Popup
        buttonNine.Font = New Font("Yu Gothic UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        buttonNine.ForeColor = SystemColors.ButtonFace
        buttonNine.Location = New Point(195, 107)
        buttonNine.Name = "buttonNine"
        buttonNine.Size = New Size(85, 85)
        buttonNine.TabIndex = 3
        buttonNine.Text = "9"
        buttonNine.UseVisualStyleBackColor = True
        ' 
        ' buttonDivide
        ' 
        buttonDivide.BackgroundImage = My.Resources.Resources.buttongradient
        buttonDivide.BackgroundImageLayout = ImageLayout.Stretch
        buttonDivide.FlatStyle = FlatStyle.Popup
        buttonDivide.Font = New Font("Yu Gothic UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        buttonDivide.ForeColor = SystemColors.ButtonFace
        buttonDivide.Location = New Point(286, 107)
        buttonDivide.Name = "buttonDivide"
        buttonDivide.Size = New Size(85, 85)
        buttonDivide.TabIndex = 4
        buttonDivide.Text = "/"
        buttonDivide.UseVisualStyleBackColor = True
        ' 
        ' buttonMultiply
        ' 
        buttonMultiply.BackgroundImage = My.Resources.Resources.buttongradient
        buttonMultiply.BackgroundImageLayout = ImageLayout.Stretch
        buttonMultiply.FlatStyle = FlatStyle.Popup
        buttonMultiply.Font = New Font("Yu Gothic UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        buttonMultiply.ForeColor = SystemColors.ButtonFace
        buttonMultiply.Location = New Point(286, 198)
        buttonMultiply.Name = "buttonMultiply"
        buttonMultiply.Size = New Size(85, 85)
        buttonMultiply.TabIndex = 5
        buttonMultiply.Text = "x"
        buttonMultiply.UseVisualStyleBackColor = True
        ' 
        ' buttonMinus
        ' 
        buttonMinus.BackgroundImage = My.Resources.Resources.buttongradient
        buttonMinus.BackgroundImageLayout = ImageLayout.Stretch
        buttonMinus.FlatStyle = FlatStyle.Popup
        buttonMinus.Font = New Font("Yu Gothic UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        buttonMinus.ForeColor = SystemColors.ButtonFace
        buttonMinus.Location = New Point(286, 289)
        buttonMinus.Name = "buttonMinus"
        buttonMinus.Size = New Size(85, 85)
        buttonMinus.TabIndex = 6
        buttonMinus.Text = "-"
        buttonMinus.UseVisualStyleBackColor = True
        ' 
        ' buttonPlus
        ' 
        buttonPlus.BackgroundImage = My.Resources.Resources.buttongradient
        buttonPlus.BackgroundImageLayout = ImageLayout.Stretch
        buttonPlus.FlatStyle = FlatStyle.Popup
        buttonPlus.Font = New Font("Yu Gothic UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        buttonPlus.ForeColor = SystemColors.ButtonFace
        buttonPlus.Location = New Point(286, 380)
        buttonPlus.Name = "buttonPlus"
        buttonPlus.Size = New Size(85, 85)
        buttonPlus.TabIndex = 7
        buttonPlus.Text = "+"
        buttonPlus.UseVisualStyleBackColor = True
        ' 
        ' buttonSix
        ' 
        buttonSix.BackgroundImage = My.Resources.Resources.buttongradient
        buttonSix.BackgroundImageLayout = ImageLayout.Stretch
        buttonSix.FlatStyle = FlatStyle.Popup
        buttonSix.Font = New Font("Yu Gothic UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        buttonSix.ForeColor = SystemColors.ButtonFace
        buttonSix.Location = New Point(195, 198)
        buttonSix.Name = "buttonSix"
        buttonSix.Size = New Size(85, 85)
        buttonSix.TabIndex = 8
        buttonSix.Text = "6"
        buttonSix.UseVisualStyleBackColor = True
        ' 
        ' buttonFive
        ' 
        buttonFive.BackgroundImage = My.Resources.Resources.buttongradient
        buttonFive.BackgroundImageLayout = ImageLayout.Stretch
        buttonFive.FlatStyle = FlatStyle.Popup
        buttonFive.Font = New Font("Yu Gothic UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        buttonFive.ForeColor = SystemColors.ButtonFace
        buttonFive.Location = New Point(104, 198)
        buttonFive.Name = "buttonFive"
        buttonFive.Size = New Size(85, 85)
        buttonFive.TabIndex = 9
        buttonFive.Text = "5"
        buttonFive.UseVisualStyleBackColor = True
        ' 
        ' buttonFour
        ' 
        buttonFour.BackgroundImage = My.Resources.Resources.buttongradient
        buttonFour.BackgroundImageLayout = ImageLayout.Stretch
        buttonFour.FlatStyle = FlatStyle.Popup
        buttonFour.Font = New Font("Yu Gothic UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        buttonFour.ForeColor = SystemColors.ButtonFace
        buttonFour.Location = New Point(13, 198)
        buttonFour.Name = "buttonFour"
        buttonFour.Size = New Size(85, 85)
        buttonFour.TabIndex = 10
        buttonFour.Text = "4"
        buttonFour.UseVisualStyleBackColor = True
        ' 
        ' buttonThree
        ' 
        buttonThree.BackgroundImage = My.Resources.Resources.buttongradient
        buttonThree.BackgroundImageLayout = ImageLayout.Stretch
        buttonThree.FlatStyle = FlatStyle.Popup
        buttonThree.Font = New Font("Yu Gothic UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        buttonThree.ForeColor = SystemColors.ButtonFace
        buttonThree.Location = New Point(195, 289)
        buttonThree.Name = "buttonThree"
        buttonThree.Size = New Size(85, 85)
        buttonThree.TabIndex = 11
        buttonThree.Text = "3"
        buttonThree.UseVisualStyleBackColor = True
        ' 
        ' buttonZero
        ' 
        buttonZero.BackgroundImage = My.Resources.Resources.buttongradient
        buttonZero.BackgroundImageLayout = ImageLayout.Stretch
        buttonZero.FlatStyle = FlatStyle.Popup
        buttonZero.Font = New Font("Yu Gothic UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        buttonZero.ForeColor = SystemColors.ButtonFace
        buttonZero.Location = New Point(195, 380)
        buttonZero.Name = "buttonZero"
        buttonZero.Size = New Size(85, 85)
        buttonZero.TabIndex = 12
        buttonZero.Text = "0"
        buttonZero.UseVisualStyleBackColor = True
        ' 
        ' buttonTwo
        ' 
        buttonTwo.BackgroundImage = My.Resources.Resources.buttongradient
        buttonTwo.BackgroundImageLayout = ImageLayout.Stretch
        buttonTwo.FlatStyle = FlatStyle.Popup
        buttonTwo.Font = New Font("Yu Gothic UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        buttonTwo.ForeColor = SystemColors.ButtonFace
        buttonTwo.Location = New Point(104, 289)
        buttonTwo.Name = "buttonTwo"
        buttonTwo.Size = New Size(85, 85)
        buttonTwo.TabIndex = 13
        buttonTwo.Text = "2"
        buttonTwo.UseVisualStyleBackColor = True
        ' 
        ' buttonOne
        ' 
        buttonOne.BackgroundImage = My.Resources.Resources.buttongradient
        buttonOne.BackgroundImageLayout = ImageLayout.Stretch
        buttonOne.FlatStyle = FlatStyle.Popup
        buttonOne.Font = New Font("Yu Gothic UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        buttonOne.ForeColor = SystemColors.ButtonFace
        buttonOne.Location = New Point(13, 289)
        buttonOne.Name = "buttonOne"
        buttonOne.Size = New Size(85, 85)
        buttonOne.TabIndex = 14
        buttonOne.Text = "1"
        buttonOne.UseVisualStyleBackColor = True
        ' 
        ' buttonEquals
        ' 
        buttonEquals.BackgroundImage = My.Resources.Resources.buttongradient
        buttonEquals.BackgroundImageLayout = ImageLayout.Stretch
        buttonEquals.FlatStyle = FlatStyle.Popup
        buttonEquals.Font = New Font("Yu Gothic UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        buttonEquals.ForeColor = SystemColors.ButtonFace
        buttonEquals.Location = New Point(13, 380)
        buttonEquals.Name = "buttonEquals"
        buttonEquals.Size = New Size(176, 85)
        buttonEquals.TabIndex = 15
        buttonEquals.Text = "="
        buttonEquals.UseVisualStyleBackColor = True
        ' 
        ' resetButton
        ' 
        resetButton.BackgroundImage = My.Resources.Resources.buttongradient
        resetButton.BackgroundImageLayout = ImageLayout.Stretch
        resetButton.FlatStyle = FlatStyle.Popup
        resetButton.ForeColor = SystemColors.ButtonFace
        resetButton.Location = New Point(286, 12)
        resetButton.Name = "resetButton"
        resetButton.Size = New Size(85, 23)
        resetButton.TabIndex = 16
        resetButton.Text = "Reset"
        resetButton.UseVisualStyleBackColor = True
        ' 
        ' backToLogin
        ' 
        backToLogin.BackgroundImage = My.Resources.Resources.buttongradient
        backToLogin.BackgroundImageLayout = ImageLayout.Stretch
        backToLogin.FlatStyle = FlatStyle.Popup
        backToLogin.ForeColor = SystemColors.ButtonFace
        backToLogin.Location = New Point(12, 12)
        backToLogin.Name = "backToLogin"
        backToLogin.Size = New Size(110, 23)
        backToLogin.TabIndex = 17
        backToLogin.Text = "Back to Menu"
        backToLogin.UseVisualStyleBackColor = True
        ' 
        ' Calculator
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.logingradient
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(383, 476)
        Controls.Add(backToLogin)
        Controls.Add(resetButton)
        Controls.Add(buttonEquals)
        Controls.Add(buttonOne)
        Controls.Add(buttonTwo)
        Controls.Add(buttonZero)
        Controls.Add(buttonThree)
        Controls.Add(buttonFour)
        Controls.Add(buttonFive)
        Controls.Add(buttonSix)
        Controls.Add(buttonPlus)
        Controls.Add(buttonMinus)
        Controls.Add(buttonMultiply)
        Controls.Add(buttonDivide)
        Controls.Add(buttonNine)
        Controls.Add(buttonEight)
        Controls.Add(buttonSeven)
        Controls.Add(calcBox)
        DoubleBuffered = True
        Name = "Calculator"
        Text = "Calculator"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents calcBox As TextBox
    Friend WithEvents buttonSeven As Button
    Friend WithEvents buttonEight As Button
    Friend WithEvents buttonNine As Button
    Friend WithEvents buttonDivide As Button
    Friend WithEvents buttonMultiply As Button
    Friend WithEvents buttonMinus As Button
    Friend WithEvents buttonPlus As Button
    Friend WithEvents buttonSix As Button
    Friend WithEvents buttonFive As Button
    Friend WithEvents buttonFour As Button
    Friend WithEvents buttonThree As Button
    Friend WithEvents buttonZero As Button
    Friend WithEvents buttonTwo As Button
    Friend WithEvents buttonOne As Button
    Friend WithEvents buttonEquals As Button
    Friend WithEvents resetButton As Button
    Friend WithEvents backToLogin As Button
End Class
