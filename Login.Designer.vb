Imports System.Drawing

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login_page
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login_page))
        AppLogo = New PictureBox()
        Login = New Label()
        Username = New TextBox()
        Password = New TextBox()
        LoginButton = New Button()
        CType(AppLogo, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' AppLogo
        ' 
        AppLogo.BackColor = Color.Transparent
        AppLogo.Image = CType(resources.GetObject("AppLogo.Image"), Image)
        AppLogo.Location = New Point(806, 12)
        AppLogo.Name = "AppLogo"
        AppLogo.Size = New Size(455, 298)
        AppLogo.SizeMode = PictureBoxSizeMode.StretchImage
        AppLogo.TabIndex = 0
        AppLogo.TabStop = False
        ' 
        ' Login
        ' 
        Login.AutoSize = True
        Login.BackColor = Color.Transparent
        Login.Font = New Font("Sans Serif Collection", 13.875F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Login.ForeColor = Color.White
        Login.Location = New Point(702, 313)
        Login.Name = "Login"
        Login.Size = New Size(671, 91)
        Login.TabIndex = 2
        Login.Text = "Login to Your Account"
        Login.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Username
        ' 
        Username.BackColor = Color.FromArgb(CByte(219), CByte(206), CByte(208))
        Username.BorderStyle = BorderStyle.None
        Username.Font = New Font("Sans Serif Collection", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Username.Location = New Point(748, 472)
        Username.Name = "Username"
        Username.PlaceholderText = "   Username"
        Username.Size = New Size(558, 66)
        Username.TabIndex = 3
        Username.UseWaitCursor = True
        ' 
        ' Password
        ' 
        Password.BackColor = Color.FromArgb(CByte(219), CByte(206), CByte(208))
        Password.BorderStyle = BorderStyle.None
        Password.Font = New Font("Sans Serif Collection", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Password.Location = New Point(748, 583)
        Password.Name = "Password"
        Password.PasswordChar = "*"c
        Password.PlaceholderText = "   Password"
        Password.Size = New Size(558, 66)
        Password.TabIndex = 4
        ' 
        ' LoginButton
        ' 
        LoginButton.BackColor = Color.FromArgb(CByte(0), CByte(108), CByte(112))
        LoginButton.FlatAppearance.BorderSize = 0
        LoginButton.FlatStyle = FlatStyle.Flat
        LoginButton.Font = New Font("Sans Serif Collection", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LoginButton.ForeColor = Color.Black
        LoginButton.Location = New Point(898, 717)
        LoginButton.Name = "LoginButton"
        LoginButton.Size = New Size(289, 77)
        LoginButton.TabIndex = 5
        LoginButton.Text = "Sign In"
        LoginButton.UseVisualStyleBackColor = False
        ' 
        ' Login_page
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Black
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(2055, 1142)
        Controls.Add(LoginButton)
        Controls.Add(Password)
        Controls.Add(Username)
        Controls.Add(Login)
        Controls.Add(AppLogo)
        Name = "Login_page"
        Text = "Login_page"
        CType(AppLogo, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Private Sub SetTextBoxRoundedRegion(ByVal textBox As TextBox, ByVal radius As Integer)
        Dim path As Drawing2D.GraphicsPath = New Drawing2D.GraphicsPath()
        path.StartFigure()
        path.AddArc(New Rectangle(0, 0, radius, radius), 180, 90)
        path.AddArc(New Rectangle(textBox.Width - radius - 1, 0, radius, radius), 270, 90)
        path.AddArc(New Rectangle(textBox.Width - radius - 1, textBox.Height - radius - 1, radius, radius), 0, 90)
        path.AddArc(New Rectangle(0, textBox.Height - radius - 1, radius, radius), 90, 90)
        path.CloseFigure()
        textBox.Region = New Region(path)
    End Sub

    Private Sub SetButtonRoundedRegion(ByVal button As Button, ByVal radius As Integer)
        Dim path As Drawing2D.GraphicsPath = New Drawing2D.GraphicsPath()
        path.StartFigure()
        path.AddArc(New Rectangle(0, 0, radius, radius), 180, 90)
        path.AddArc(New Rectangle(button.Width - radius - 1, 0, radius, radius), 270, 90)
        path.AddArc(New Rectangle(button.Width - radius - 1, button.Height - radius - 1, radius, radius), 0, 90)
        path.AddArc(New Rectangle(0, button.Height - radius - 1, radius, radius), 90, 90)
        path.CloseFigure()
        button.Region = New Region(path)
    End Sub

    Friend WithEvents AppLogo As PictureBox
    Friend WithEvents Login As Label
    Friend WithEvents Username As TextBox
    Friend WithEvents Password As TextBox
    Friend WithEvents LoginButton As Button
End Class
