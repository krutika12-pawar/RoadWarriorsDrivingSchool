<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Dashboard
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        TraineeForm = New Panel()
        AboutRichTextBox = New RichTextBox()
        Student_management = New Label()
        PictureBox1 = New PictureBox()
        Dashboard_label = New Label()
        App_logo = New PictureBox()
        User_profilePhoto = New PictureBox()
        UserProfile = New Label()
        App_name = New Label()
        Trainee_icon = New PictureBox()
        Learners_icon = New PictureBox()
        Online_lessons_icon = New PictureBox()
        License_icon = New PictureBox()
        Logout_icon = New PictureBox()
        PictureBox2 = New PictureBox()
        SideMenu_Dashboard = New Label()
        SideMenu_Instructors = New Label()
        SideMenu_Students = New Label()
        SideMenu_Lessons = New Label()
        SideMenu_License = New Label()
        SideMenu_Logout = New Label()
        Side_panel = New Panel()
        ContextMenuStrip1 = New ContextMenuStrip(components)
        TraineeForm.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(App_logo, ComponentModel.ISupportInitialize).BeginInit()
        CType(User_profilePhoto, ComponentModel.ISupportInitialize).BeginInit()
        CType(Trainee_icon, ComponentModel.ISupportInitialize).BeginInit()
        CType(Learners_icon, ComponentModel.ISupportInitialize).BeginInit()
        CType(Online_lessons_icon, ComponentModel.ISupportInitialize).BeginInit()
        CType(License_icon, ComponentModel.ISupportInitialize).BeginInit()
        CType(Logout_icon, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Side_panel.SuspendLayout()
        SuspendLayout()
        ' 
        ' TraineeForm
        ' 
        TraineeForm.BackColor = Color.FromArgb(CByte(0), CByte(108), CByte(112))
        TraineeForm.Controls.Add(AboutRichTextBox)
        TraineeForm.Controls.Add(Student_management)
        TraineeForm.Controls.Add(PictureBox1)
        TraineeForm.Controls.Add(Dashboard_label)
        TraineeForm.Location = New Point(324, 214)
        TraineeForm.Name = "TraineeForm"
        TraineeForm.Size = New Size(1699, 926)
        TraineeForm.TabIndex = 0
        ' 
        ' AboutRichTextBox
        ' 
        AboutRichTextBox.BackColor = Color.FromArgb(CByte(0), CByte(108), CByte(112))
        AboutRichTextBox.BorderStyle = BorderStyle.None
        AboutRichTextBox.Font = New Font("Segoe UI", 11F)
        AboutRichTextBox.ForeColor = Color.Black
        AboutRichTextBox.Location = New Point(132, 137)
        AboutRichTextBox.Name = "AboutRichTextBox"
        AboutRichTextBox.ReadOnly = True
        AboutRichTextBox.Size = New Size(1401, 757)
        AboutRichTextBox.TabIndex = 3
        AboutRichTextBox.Text = ""
        ' 
        ' Student_management
        ' 
        Student_management.AutoSize = True
        Student_management.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Student_management.Location = New Point(123, 58)
        Student_management.Name = "Student_management"
        Student_management.Size = New Size(160, 45)
        Student_management.TabIndex = 2
        Student_management.Text = "About Us"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(3, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(114, 100)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' Dashboard_label
        ' 
        Dashboard_label.AutoSize = True
        Dashboard_label.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Dashboard_label.Location = New Point(123, 3)
        Dashboard_label.Name = "Dashboard_label"
        Dashboard_label.Size = New Size(184, 45)
        Dashboard_label.TabIndex = 0
        Dashboard_label.Text = "Dashboard"
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
        ' User_profilePhoto
        ' 
        User_profilePhoto.Image = CType(resources.GetObject("User_profilePhoto.Image"), Image)
        User_profilePhoto.Location = New Point(1932, 70)
        User_profilePhoto.Name = "User_profilePhoto"
        User_profilePhoto.Size = New Size(79, 95)
        User_profilePhoto.SizeMode = PictureBoxSizeMode.StretchImage
        User_profilePhoto.TabIndex = 2
        User_profilePhoto.TabStop = False
        ' 
        ' UserProfile
        ' 
        UserProfile.AutoSize = True
        UserProfile.Font = New Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        UserProfile.ForeColor = Color.FromArgb(CByte(0), CByte(108), CByte(112))
        UserProfile.Location = New Point(1818, 95)
        UserProfile.Name = "UserProfile"
        UserProfile.Size = New Size(108, 40)
        UserProfile.TabIndex = 3
        UserProfile.Text = "Admin"
        ' 
        ' App_name
        ' 
        App_name.AutoSize = True
        App_name.Font = New Font("Segoe UI", 19.875F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        App_name.ForeColor = Color.FromArgb(CByte(0), CByte(108), CByte(112))
        App_name.Location = New Point(762, 70)
        App_name.Name = "App_name"
        App_name.Size = New Size(765, 71)
        App_name.TabIndex = 4
        App_name.Text = "Road Warriors Driving School"
        ' 
        ' Trainee_icon
        ' 
        Trainee_icon.Image = CType(resources.GetObject("Trainee_icon.Image"), Image)
        Trainee_icon.Location = New Point(91, 361)
        Trainee_icon.Name = "Trainee_icon"
        Trainee_icon.Size = New Size(108, 95)
        Trainee_icon.SizeMode = PictureBoxSizeMode.Zoom
        Trainee_icon.TabIndex = 3
        Trainee_icon.TabStop = False
        ' 
        ' Learners_icon
        ' 
        Learners_icon.Image = CType(resources.GetObject("Learners_icon.Image"), Image)
        Learners_icon.Location = New Point(91, 520)
        Learners_icon.Name = "Learners_icon"
        Learners_icon.Size = New Size(108, 95)
        Learners_icon.SizeMode = PictureBoxSizeMode.Zoom
        Learners_icon.TabIndex = 5
        Learners_icon.TabStop = False
        ' 
        ' Online_lessons_icon
        ' 
        Online_lessons_icon.Image = CType(resources.GetObject("Online_lessons_icon.Image"), Image)
        Online_lessons_icon.Location = New Point(91, 684)
        Online_lessons_icon.Name = "Online_lessons_icon"
        Online_lessons_icon.Size = New Size(108, 95)
        Online_lessons_icon.SizeMode = PictureBoxSizeMode.Zoom
        Online_lessons_icon.TabIndex = 4
        Online_lessons_icon.TabStop = False
        ' 
        ' License_icon
        ' 
        License_icon.Image = CType(resources.GetObject("License_icon.Image"), Image)
        License_icon.Location = New Point(91, 842)
        License_icon.Name = "License_icon"
        License_icon.Size = New Size(108, 95)
        License_icon.SizeMode = PictureBoxSizeMode.Zoom
        License_icon.TabIndex = 4
        License_icon.TabStop = False
        ' 
        ' Logout_icon
        ' 
        Logout_icon.Image = CType(resources.GetObject("Logout_icon.Image"), Image)
        Logout_icon.Location = New Point(91, 988)
        Logout_icon.Name = "Logout_icon"
        Logout_icon.Size = New Size(108, 95)
        Logout_icon.SizeMode = PictureBoxSizeMode.Zoom
        Logout_icon.TabIndex = 4
        Logout_icon.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(91, 214)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(108, 107)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 6
        PictureBox2.TabStop = False
        ' 
        ' SideMenu_Dashboard
        ' 
        SideMenu_Dashboard.AutoSize = True
        SideMenu_Dashboard.Font = New Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        SideMenu_Dashboard.ForeColor = Color.FromArgb(CByte(0), CByte(108), CByte(112))
        SideMenu_Dashboard.Location = New Point(73, 317)
        SideMenu_Dashboard.Name = "SideMenu_Dashboard"
        SideMenu_Dashboard.Size = New Size(157, 37)
        SideMenu_Dashboard.TabIndex = 9
        SideMenu_Dashboard.Text = "Dashboard"
        ' 
        ' SideMenu_Instructors
        ' 
        SideMenu_Instructors.AutoSize = True
        SideMenu_Instructors.Font = New Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        SideMenu_Instructors.ForeColor = Color.FromArgb(CByte(0), CByte(108), CByte(112))
        SideMenu_Instructors.Location = New Point(73, 471)
        SideMenu_Instructors.Name = "SideMenu_Instructors"
        SideMenu_Instructors.Size = New Size(156, 37)
        SideMenu_Instructors.TabIndex = 10
        SideMenu_Instructors.Text = "Instructors"
        ' 
        ' SideMenu_Students
        ' 
        SideMenu_Students.AutoSize = True
        SideMenu_Students.Font = New Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        SideMenu_Students.ForeColor = Color.FromArgb(CByte(0), CByte(108), CByte(112))
        SideMenu_Students.Location = New Point(80, 627)
        SideMenu_Students.Name = "SideMenu_Students"
        SideMenu_Students.Size = New Size(129, 37)
        SideMenu_Students.TabIndex = 11
        SideMenu_Students.Text = "Students"
        ' 
        ' SideMenu_Lessons
        ' 
        SideMenu_Lessons.AutoSize = True
        SideMenu_Lessons.Font = New Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        SideMenu_Lessons.ForeColor = Color.FromArgb(CByte(0), CByte(108), CByte(112))
        SideMenu_Lessons.Location = New Point(91, 791)
        SideMenu_Lessons.Name = "SideMenu_Lessons"
        SideMenu_Lessons.Size = New Size(115, 37)
        SideMenu_Lessons.TabIndex = 12
        SideMenu_Lessons.Text = "Lessons"
        ' 
        ' SideMenu_License
        ' 
        SideMenu_License.AutoSize = True
        SideMenu_License.Font = New Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        SideMenu_License.ForeColor = Color.FromArgb(CByte(0), CByte(108), CByte(112))
        SideMenu_License.Location = New Point(73, 940)
        SideMenu_License.Name = "SideMenu_License"
        SideMenu_License.Size = New Size(169, 37)
        SideMenu_License.TabIndex = 13
        SideMenu_License.Text = "License Test"
        ' 
        ' SideMenu_Logout
        ' 
        SideMenu_Logout.AutoSize = True
        SideMenu_Logout.Font = New Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        SideMenu_Logout.ForeColor = Color.FromArgb(CByte(0), CByte(108), CByte(112))
        SideMenu_Logout.Location = New Point(91, 1096)
        SideMenu_Logout.Name = "SideMenu_Logout"
        SideMenu_Logout.Size = New Size(109, 37)
        SideMenu_Logout.TabIndex = 14
        SideMenu_Logout.Text = "Logout"
        ' 
        ' Side_panel
        ' 
        Side_panel.BackColor = Color.Black
        Side_panel.Controls.Add(App_logo)
        Side_panel.Location = New Point(0, 0)
        Side_panel.Name = "Side_panel"
        Side_panel.Size = New Size(321, 1140)
        Side_panel.TabIndex = 15
        ' 
        ' ContextMenuStrip1
        ' 
        ContextMenuStrip1.ImageScalingSize = New Size(32, 32)
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        ContextMenuStrip1.Size = New Size(61, 4)
        ' 
        ' Dashboard
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Black
        ClientSize = New Size(2055, 1142)
        Controls.Add(SideMenu_Logout)
        Controls.Add(SideMenu_License)
        Controls.Add(SideMenu_Lessons)
        Controls.Add(SideMenu_Students)
        Controls.Add(SideMenu_Instructors)
        Controls.Add(SideMenu_Dashboard)
        Controls.Add(PictureBox2)
        Controls.Add(Logout_icon)
        Controls.Add(License_icon)
        Controls.Add(Online_lessons_icon)
        Controls.Add(Learners_icon)
        Controls.Add(Trainee_icon)
        Controls.Add(App_name)
        Controls.Add(UserProfile)
        Controls.Add(User_profilePhoto)
        Controls.Add(TraineeForm)
        Controls.Add(Side_panel)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "Dashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Dashboard"
        TraineeForm.ResumeLayout(False)
        TraineeForm.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(App_logo, ComponentModel.ISupportInitialize).EndInit()
        CType(User_profilePhoto, ComponentModel.ISupportInitialize).EndInit()
        CType(Trainee_icon, ComponentModel.ISupportInitialize).EndInit()
        CType(Learners_icon, ComponentModel.ISupportInitialize).EndInit()
        CType(Online_lessons_icon, ComponentModel.ISupportInitialize).EndInit()
        CType(License_icon, ComponentModel.ISupportInitialize).EndInit()
        CType(Logout_icon, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Side_panel.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TraineeForm As Panel
    Friend WithEvents App_logo As PictureBox
    Friend WithEvents User_profilePhoto As PictureBox
    Friend WithEvents Trainee_icon As PictureBox
    Friend WithEvents Learners_icon As PictureBox
    Friend WithEvents Online_lessons_icon As PictureBox
    Friend WithEvents License_icon As PictureBox
    Friend WithEvents Logout_icon As PictureBox
    Friend WithEvents UserProfile As Label
    Friend WithEvents App_name As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Dashboard_label As Label
    Friend WithEvents Student_management As Label
    Friend WithEvents Student_list As ListView
    Friend WithEvents SideMenu_Instructors As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents SideMenu_Dashboard As Label
    Friend WithEvents SideMenu_Students As Label
    Friend WithEvents SideMenu_Lessons As Label
    Friend WithEvents SideMenu_License As Label
    Friend WithEvents SideMenu_Logout As Label
    Friend WithEvents Side_panel As Panel
    Friend WithEvents AboutRichTextBox As RichTextBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
End Class
