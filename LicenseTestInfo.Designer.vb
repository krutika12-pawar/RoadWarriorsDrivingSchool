<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LicenseTestInfo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LicenseTestInfo))
        Course_icon = New PictureBox()
        Course_label = New Label()
        App_logo = New PictureBox()
        SideMenu_License = New Label()
        SideMenu_Courses = New Label()
        SideMenu_Students = New Label()
        SideMenu_Dashboard = New Label()
        SideMenu_Logout = New Label()
        SideMenu_Instructor = New Label()
        Dashboard_icon = New PictureBox()
        Logout_icon = New PictureBox()
        License_icon = New PictureBox()
        Online_lessons_icon = New PictureBox()
        Learners_icon = New PictureBox()
        Trainee_icon = New PictureBox()
        User_profilePhoto = New PictureBox()
        App_name = New Label()
        UserProfile = New Label()
        Side_panel = New Panel()
        QuestionForm = New Panel()
        LicenseTestTimings = New RichTextBox()
        LicenseTypes = New RichTextBox()
        LicensTestInfo = New RichTextBox()
        ResultLabel = New Label()
        CType(Course_icon, ComponentModel.ISupportInitialize).BeginInit()
        CType(App_logo, ComponentModel.ISupportInitialize).BeginInit()
        CType(Dashboard_icon, ComponentModel.ISupportInitialize).BeginInit()
        CType(Logout_icon, ComponentModel.ISupportInitialize).BeginInit()
        CType(License_icon, ComponentModel.ISupportInitialize).BeginInit()
        CType(Online_lessons_icon, ComponentModel.ISupportInitialize).BeginInit()
        CType(Learners_icon, ComponentModel.ISupportInitialize).BeginInit()
        CType(Trainee_icon, ComponentModel.ISupportInitialize).BeginInit()
        CType(User_profilePhoto, ComponentModel.ISupportInitialize).BeginInit()
        Side_panel.SuspendLayout()
        QuestionForm.SuspendLayout()
        SuspendLayout()
        ' 
        ' Course_icon
        ' 
        Course_icon.Image = CType(resources.GetObject("Course_icon.Image"), Image)
        Course_icon.Location = New Point(0, 0)
        Course_icon.Name = "Course_icon"
        Course_icon.Size = New Size(117, 107)
        Course_icon.SizeMode = PictureBoxSizeMode.Zoom
        Course_icon.TabIndex = 0
        Course_icon.TabStop = False
        ' 
        ' Course_label
        ' 
        Course_label.AutoSize = True
        Course_label.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Course_label.Location = New Point(123, 32)
        Course_label.Name = "Course_label"
        Course_label.Size = New Size(319, 45)
        Course_label.TabIndex = 0
        Course_label.Text = "Know about License"
        ' 
        ' App_logo
        ' 
        App_logo.Image = CType(resources.GetObject("App_logo.Image"), Image)
        App_logo.Location = New Point(-3, -34)
        App_logo.Name = "App_logo"
        App_logo.Size = New Size(321, 238)
        App_logo.SizeMode = PictureBoxSizeMode.StretchImage
        App_logo.TabIndex = 1
        App_logo.TabStop = False
        ' 
        ' SideMenu_License
        ' 
        SideMenu_License.AutoSize = True
        SideMenu_License.BackColor = Color.Black
        SideMenu_License.Font = New Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        SideMenu_License.ForeColor = Color.FromArgb(CByte(0), CByte(108), CByte(112))
        SideMenu_License.Location = New Point(96, 941)
        SideMenu_License.Name = "SideMenu_License"
        SideMenu_License.Size = New Size(169, 37)
        SideMenu_License.TabIndex = 47
        SideMenu_License.Text = "License Test"
        ' 
        ' SideMenu_Courses
        ' 
        SideMenu_Courses.AutoSize = True
        SideMenu_Courses.BackColor = Color.Black
        SideMenu_Courses.Font = New Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        SideMenu_Courses.ForeColor = Color.FromArgb(CByte(0), CByte(108), CByte(112))
        SideMenu_Courses.Location = New Point(114, 792)
        SideMenu_Courses.Name = "SideMenu_Courses"
        SideMenu_Courses.Size = New Size(117, 37)
        SideMenu_Courses.TabIndex = 46
        SideMenu_Courses.Text = "Courses"
        ' 
        ' SideMenu_Students
        ' 
        SideMenu_Students.AutoSize = True
        SideMenu_Students.BackColor = Color.Black
        SideMenu_Students.Font = New Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        SideMenu_Students.ForeColor = Color.FromArgb(CByte(0), CByte(108), CByte(112))
        SideMenu_Students.Location = New Point(103, 628)
        SideMenu_Students.Name = "SideMenu_Students"
        SideMenu_Students.Size = New Size(129, 37)
        SideMenu_Students.TabIndex = 45
        SideMenu_Students.Text = "Students"
        ' 
        ' SideMenu_Dashboard
        ' 
        SideMenu_Dashboard.AutoSize = True
        SideMenu_Dashboard.BackColor = Color.Black
        SideMenu_Dashboard.Font = New Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        SideMenu_Dashboard.ForeColor = Color.FromArgb(CByte(0), CByte(108), CByte(112))
        SideMenu_Dashboard.Location = New Point(96, 318)
        SideMenu_Dashboard.Name = "SideMenu_Dashboard"
        SideMenu_Dashboard.Size = New Size(157, 37)
        SideMenu_Dashboard.TabIndex = 43
        SideMenu_Dashboard.Text = "Dashboard"
        ' 
        ' SideMenu_Logout
        ' 
        SideMenu_Logout.AutoSize = True
        SideMenu_Logout.BackColor = Color.Black
        SideMenu_Logout.Font = New Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        SideMenu_Logout.ForeColor = Color.FromArgb(CByte(0), CByte(108), CByte(112))
        SideMenu_Logout.Location = New Point(114, 1097)
        SideMenu_Logout.Name = "SideMenu_Logout"
        SideMenu_Logout.Size = New Size(109, 37)
        SideMenu_Logout.TabIndex = 48
        SideMenu_Logout.Text = "Logout"
        ' 
        ' SideMenu_Instructor
        ' 
        SideMenu_Instructor.AutoSize = True
        SideMenu_Instructor.BackColor = Color.Black
        SideMenu_Instructor.Font = New Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        SideMenu_Instructor.ForeColor = Color.FromArgb(CByte(0), CByte(108), CByte(112))
        SideMenu_Instructor.Location = New Point(96, 472)
        SideMenu_Instructor.Name = "SideMenu_Instructor"
        SideMenu_Instructor.Size = New Size(156, 37)
        SideMenu_Instructor.TabIndex = 44
        SideMenu_Instructor.Text = "Instructors"
        ' 
        ' Dashboard_icon
        ' 
        Dashboard_icon.BackColor = Color.Black
        Dashboard_icon.Image = CType(resources.GetObject("Dashboard_icon.Image"), Image)
        Dashboard_icon.Location = New Point(114, 215)
        Dashboard_icon.Name = "Dashboard_icon"
        Dashboard_icon.Size = New Size(108, 107)
        Dashboard_icon.SizeMode = PictureBoxSizeMode.Zoom
        Dashboard_icon.TabIndex = 42
        Dashboard_icon.TabStop = False
        ' 
        ' Logout_icon
        ' 
        Logout_icon.BackColor = Color.Black
        Logout_icon.Image = CType(resources.GetObject("Logout_icon.Image"), Image)
        Logout_icon.Location = New Point(114, 989)
        Logout_icon.Name = "Logout_icon"
        Logout_icon.Size = New Size(108, 95)
        Logout_icon.SizeMode = PictureBoxSizeMode.Zoom
        Logout_icon.TabIndex = 38
        Logout_icon.TabStop = False
        ' 
        ' License_icon
        ' 
        License_icon.BackColor = Color.Black
        License_icon.Image = CType(resources.GetObject("License_icon.Image"), Image)
        License_icon.Location = New Point(114, 843)
        License_icon.Name = "License_icon"
        License_icon.Size = New Size(108, 95)
        License_icon.SizeMode = PictureBoxSizeMode.Zoom
        License_icon.TabIndex = 39
        License_icon.TabStop = False
        ' 
        ' Online_lessons_icon
        ' 
        Online_lessons_icon.BackColor = Color.Black
        Online_lessons_icon.Image = CType(resources.GetObject("Online_lessons_icon.Image"), Image)
        Online_lessons_icon.Location = New Point(114, 685)
        Online_lessons_icon.Name = "Online_lessons_icon"
        Online_lessons_icon.Size = New Size(108, 95)
        Online_lessons_icon.SizeMode = PictureBoxSizeMode.Zoom
        Online_lessons_icon.TabIndex = 40
        Online_lessons_icon.TabStop = False
        ' 
        ' Learners_icon
        ' 
        Learners_icon.BackColor = Color.Black
        Learners_icon.Image = CType(resources.GetObject("Learners_icon.Image"), Image)
        Learners_icon.Location = New Point(114, 521)
        Learners_icon.Name = "Learners_icon"
        Learners_icon.Size = New Size(108, 95)
        Learners_icon.SizeMode = PictureBoxSizeMode.Zoom
        Learners_icon.TabIndex = 41
        Learners_icon.TabStop = False
        ' 
        ' Trainee_icon
        ' 
        Trainee_icon.BackColor = Color.Black
        Trainee_icon.Image = CType(resources.GetObject("Trainee_icon.Image"), Image)
        Trainee_icon.Location = New Point(114, 362)
        Trainee_icon.Name = "Trainee_icon"
        Trainee_icon.Size = New Size(108, 95)
        Trainee_icon.SizeMode = PictureBoxSizeMode.Zoom
        Trainee_icon.TabIndex = 36
        Trainee_icon.TabStop = False
        ' 
        ' User_profilePhoto
        ' 
        User_profilePhoto.Image = CType(resources.GetObject("User_profilePhoto.Image"), Image)
        User_profilePhoto.Location = New Point(1955, 71)
        User_profilePhoto.Name = "User_profilePhoto"
        User_profilePhoto.Size = New Size(79, 95)
        User_profilePhoto.SizeMode = PictureBoxSizeMode.StretchImage
        User_profilePhoto.TabIndex = 34
        User_profilePhoto.TabStop = False
        ' 
        ' App_name
        ' 
        App_name.AutoSize = True
        App_name.Font = New Font("Segoe UI", 19.875F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        App_name.ForeColor = Color.FromArgb(CByte(0), CByte(108), CByte(112))
        App_name.Location = New Point(785, 71)
        App_name.Name = "App_name"
        App_name.Size = New Size(765, 71)
        App_name.TabIndex = 37
        App_name.Text = "Road Warriors Driving School"
        ' 
        ' UserProfile
        ' 
        UserProfile.AutoSize = True
        UserProfile.Font = New Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        UserProfile.ForeColor = Color.FromArgb(CByte(0), CByte(108), CByte(112))
        UserProfile.Location = New Point(1841, 96)
        UserProfile.Name = "UserProfile"
        UserProfile.Size = New Size(108, 40)
        UserProfile.TabIndex = 35
        UserProfile.Text = "Admin"
        ' 
        ' Side_panel
        ' 
        Side_panel.BackColor = Color.Black
        Side_panel.Controls.Add(App_logo)
        Side_panel.ForeColor = Color.FromArgb(CByte(0), CByte(108), CByte(112))
        Side_panel.Location = New Point(8, 1)
        Side_panel.Name = "Side_panel"
        Side_panel.Size = New Size(321, 1140)
        Side_panel.TabIndex = 49
        ' 
        ' QuestionForm
        ' 
        QuestionForm.BackColor = Color.FromArgb(CByte(0), CByte(108), CByte(112))
        QuestionForm.Controls.Add(LicenseTestTimings)
        QuestionForm.Controls.Add(LicenseTypes)
        QuestionForm.Controls.Add(LicensTestInfo)
        QuestionForm.Controls.Add(ResultLabel)
        QuestionForm.Controls.Add(Course_icon)
        QuestionForm.Controls.Add(Course_label)
        QuestionForm.Location = New Point(347, 215)
        QuestionForm.Name = "QuestionForm"
        QuestionForm.Size = New Size(1696, 919)
        QuestionForm.TabIndex = 33
        ' 
        ' LicenseTestTimings
        ' 
        LicenseTestTimings.BackColor = Color.FromArgb(CByte(0), CByte(108), CByte(112))
        LicenseTestTimings.BorderStyle = BorderStyle.None
        LicenseTestTimings.Font = New Font("Segoe UI", 11F)
        LicenseTestTimings.ForeColor = Color.Black
        LicenseTestTimings.Location = New Point(123, 643)
        LicenseTestTimings.Name = "LicenseTestTimings"
        LicenseTestTimings.ReadOnly = True
        LicenseTestTimings.Size = New Size(1530, 226)
        LicenseTestTimings.TabIndex = 9
        LicenseTestTimings.Text = ""
        ' 
        ' LicenseTypes
        ' 
        LicenseTypes.BackColor = Color.FromArgb(CByte(0), CByte(108), CByte(112))
        LicenseTypes.BorderStyle = BorderStyle.None
        LicenseTypes.Font = New Font("Segoe UI", 11F)
        LicenseTypes.ForeColor = Color.Black
        LicenseTypes.Location = New Point(123, 348)
        LicenseTypes.Name = "LicenseTypes"
        LicenseTypes.ReadOnly = True
        LicenseTypes.Size = New Size(1530, 331)
        LicenseTypes.TabIndex = 8
        LicenseTypes.Text = ""
        ' 
        ' LicensTestInfo
        ' 
        LicensTestInfo.BackColor = Color.FromArgb(CByte(0), CByte(108), CByte(112))
        LicensTestInfo.BorderStyle = BorderStyle.None
        LicensTestInfo.Font = New Font("Segoe UI", 11F)
        LicensTestInfo.ForeColor = Color.Black
        LicensTestInfo.Location = New Point(123, 121)
        LicensTestInfo.Name = "LicensTestInfo"
        LicensTestInfo.ReadOnly = True
        LicensTestInfo.Size = New Size(1530, 221)
        LicensTestInfo.TabIndex = 7
        LicensTestInfo.Text = ""
        ' 
        ' ResultLabel
        ' 
        ResultLabel.AutoSize = True
        ResultLabel.Location = New Point(135, 86)
        ResultLabel.Name = "ResultLabel"
        ResultLabel.Size = New Size(0, 32)
        ResultLabel.TabIndex = 6
        ' 
        ' LicenseTestInfo
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Black
        ClientSize = New Size(2055, 1142)
        Controls.Add(SideMenu_License)
        Controls.Add(SideMenu_Courses)
        Controls.Add(SideMenu_Students)
        Controls.Add(SideMenu_Dashboard)
        Controls.Add(SideMenu_Logout)
        Controls.Add(SideMenu_Instructor)
        Controls.Add(Dashboard_icon)
        Controls.Add(Logout_icon)
        Controls.Add(License_icon)
        Controls.Add(Online_lessons_icon)
        Controls.Add(Learners_icon)
        Controls.Add(Trainee_icon)
        Controls.Add(User_profilePhoto)
        Controls.Add(App_name)
        Controls.Add(UserProfile)
        Controls.Add(Side_panel)
        Controls.Add(QuestionForm)
        Name = "LicenseTestInfo"
        StartPosition = FormStartPosition.CenterScreen
        Text = "GetLicense"
        CType(Course_icon, ComponentModel.ISupportInitialize).EndInit()
        CType(App_logo, ComponentModel.ISupportInitialize).EndInit()
        CType(Dashboard_icon, ComponentModel.ISupportInitialize).EndInit()
        CType(Logout_icon, ComponentModel.ISupportInitialize).EndInit()
        CType(License_icon, ComponentModel.ISupportInitialize).EndInit()
        CType(Online_lessons_icon, ComponentModel.ISupportInitialize).EndInit()
        CType(Learners_icon, ComponentModel.ISupportInitialize).EndInit()
        CType(Trainee_icon, ComponentModel.ISupportInitialize).EndInit()
        CType(User_profilePhoto, ComponentModel.ISupportInitialize).EndInit()
        Side_panel.ResumeLayout(False)
        QuestionForm.ResumeLayout(False)
        QuestionForm.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Course_icon As PictureBox
    Friend WithEvents Course_label As Label
    Friend WithEvents App_logo As PictureBox
    Friend WithEvents SideMenu_License As Label
    Friend WithEvents SideMenu_Courses As Label
    Friend WithEvents SideMenu_Students As Label
    Friend WithEvents SideMenu_Dashboard As Label
    Friend WithEvents SideMenu_Logout As Label
    Friend WithEvents SideMenu_Instructor As Label
    Friend WithEvents Dashboard_icon As PictureBox
    Friend WithEvents Logout_icon As PictureBox
    Friend WithEvents License_icon As PictureBox
    Friend WithEvents Online_lessons_icon As PictureBox
    Friend WithEvents Learners_icon As PictureBox
    Friend WithEvents Trainee_icon As PictureBox
    Friend WithEvents User_profilePhoto As PictureBox
    Friend WithEvents App_name As Label
    Friend WithEvents UserProfile As Label
    Friend WithEvents Side_panel As Panel
    Friend WithEvents QuestionForm As Panel
    Friend WithEvents ResultLabel As Label
    Friend WithEvents LicensTestInfo As RichTextBox
    Friend WithEvents LicenseTestTimings As RichTextBox
    Friend WithEvents LicenseTypes As RichTextBox
End Class
