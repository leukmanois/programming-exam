<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
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
        Calcu = New Button()
        RockPaper = New Button()
        GlassGe = New Button()
        backToLogin = New Button()
        SuspendLayout()
        ' 
        ' Calcu
        ' 
        Calcu.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Calcu.Location = New Point(300, 115)
        Calcu.Name = "Calcu"
        Calcu.Size = New Size(188, 38)
        Calcu.TabIndex = 0
        Calcu.Text = "Calculator"
        Calcu.UseVisualStyleBackColor = True
        ' 
        ' RockPaper
        ' 
        RockPaper.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        RockPaper.Location = New Point(300, 159)
        RockPaper.Name = "RockPaper"
        RockPaper.Size = New Size(188, 38)
        RockPaper.TabIndex = 1
        RockPaper.Text = "Rock-Paper-Scissors"
        RockPaper.UseVisualStyleBackColor = True
        ' 
        ' GlassGe
        ' 
        GlassGe.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        GlassGe.Location = New Point(300, 203)
        GlassGe.Name = "GlassGe"
        GlassGe.Size = New Size(188, 38)
        GlassGe.TabIndex = 2
        GlassGe.Text = "Glass Game"
        GlassGe.UseVisualStyleBackColor = True
        ' 
        ' backToLogin
        ' 
        backToLogin.Location = New Point(12, 12)
        backToLogin.Name = "backToLogin"
        backToLogin.Size = New Size(110, 24)
        backToLogin.TabIndex = 3
        backToLogin.Text = "Back to Login"
        backToLogin.UseVisualStyleBackColor = True
        ' 
        ' Menu
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(784, 441)
        Controls.Add(backToLogin)
        Controls.Add(GlassGe)
        Controls.Add(RockPaper)
        Controls.Add(Calcu)
        Name = "Menu"
        Text = "Menu"
        ResumeLayout(False)
    End Sub

    Friend WithEvents Calcu As Button
    Friend WithEvents RockPaper As Button
    Friend WithEvents GlassGe As Button
    Friend WithEvents backToLogin As Button
End Class
