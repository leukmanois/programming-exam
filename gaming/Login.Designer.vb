<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        userName = New TextBox()
        userPass = New TextBox()
        loginButton = New Button()
        loginFailIndicator = New Label()
        closeButton = New Button()
        SuspendLayout()
        ' 
        ' userName
        ' 
        userName.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        userName.Location = New Point(240, 150)
        userName.Name = "userName"
        userName.PlaceholderText = "Username"
        userName.Size = New Size(126, 23)
        userName.TabIndex = 0
        ' 
        ' userPass
        ' 
        userPass.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        userPass.Location = New Point(240, 179)
        userPass.Name = "userPass"
        userPass.PasswordChar = "*"c
        userPass.PlaceholderText = "Password"
        userPass.Size = New Size(126, 23)
        userPass.TabIndex = 1
        ' 
        ' loginButton
        ' 
        loginButton.BackColor = Color.Black
        loginButton.BackgroundImage = CType(resources.GetObject("loginButton.BackgroundImage"), Image)
        loginButton.BackgroundImageLayout = ImageLayout.Stretch
        loginButton.FlatStyle = FlatStyle.Popup
        loginButton.ForeColor = SystemColors.ButtonFace
        loginButton.Location = New Point(240, 208)
        loginButton.Name = "loginButton"
        loginButton.Size = New Size(126, 23)
        loginButton.TabIndex = 2
        loginButton.Text = "Login"
        loginButton.UseVisualStyleBackColor = False
        ' 
        ' loginFailIndicator
        ' 
        loginFailIndicator.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        loginFailIndicator.BackColor = Color.Transparent
        loginFailIndicator.Font = New Font("Segoe UI", 6F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        loginFailIndicator.ForeColor = Color.IndianRed
        loginFailIndicator.Location = New Point(240, 234)
        loginFailIndicator.Name = "loginFailIndicator"
        loginFailIndicator.RightToLeft = RightToLeft.Yes
        loginFailIndicator.Size = New Size(126, 15)
        loginFailIndicator.TabIndex = 3
        ' 
        ' closeButton
        ' 
        closeButton.BackgroundImage = CType(resources.GetObject("closeButton.BackgroundImage"), Image)
        closeButton.BackgroundImageLayout = ImageLayout.Stretch
        closeButton.FlatStyle = FlatStyle.Popup
        closeButton.ForeColor = SystemColors.ButtonFace
        closeButton.Location = New Point(12, 12)
        closeButton.Name = "closeButton"
        closeButton.Size = New Size(49, 23)
        closeButton.TabIndex = 4
        closeButton.Text = "Close"
        closeButton.UseVisualStyleBackColor = True
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Black
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(624, 381)
        Controls.Add(closeButton)
        Controls.Add(loginFailIndicator)
        Controls.Add(loginButton)
        Controls.Add(userPass)
        Controls.Add(userName)
        DoubleBuffered = True
        Name = "Login"
        Text = "Login"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents userName As TextBox
    Friend WithEvents userPass As TextBox
    Friend WithEvents loginButton As Button
    Friend WithEvents loginFailIndicator As Label
    Friend WithEvents closeButton As Button

End Class
