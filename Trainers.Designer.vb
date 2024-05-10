<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Trainers
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Trainers))
        TraineeForm = New Panel()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Asterix = New Label()
        RefreshButton = New Button()
        TraineeEmail = New TextBox()
        TraineeList = New Label()
        Trainee_listing = New DataGridView()
        Trainee_email = New Label()
        Delete = New Button()
        Save = New Button()
        Edit = New Button()
        TraineeGender = New ComboBox()
        TraineeAddress = New RichTextBox()
        TraineePhone = New TextBox()
        TraineeName = New TextBox()
        Trainee_gender = New Label()
        Trainee_address = New Label()
        Trainee_phone = New Label()
        Trainee_name = New Label()
        ManageTrainee = New Label()
        Trainee_logo = New PictureBox()
        App_logo = New PictureBox()
        User_profilePhoto = New PictureBox()
        UserProfile = New Label()
        App_name = New Label()
        Trainee_icon = New PictureBox()
        Learners_icon = New PictureBox()
        Online_lessons_icon = New PictureBox()
        License_icon = New PictureBox()
        Logout_icon = New PictureBox()
        Dashboard_icon = New PictureBox()
        SideMenu_Dashboard = New Label()
        SideMenu_Instructors = New Label()
        SideMenu_Students = New Label()
        SideMenu_Lessons = New Label()
        SideMenu_License = New Label()
        SideMenu_Logout = New Label()
        Panel1 = New Panel()
        TraineeForm.SuspendLayout()
        CType(Trainee_listing, ComponentModel.ISupportInitialize).BeginInit()
        CType(Trainee_logo, ComponentModel.ISupportInitialize).BeginInit()
        CType(App_logo, ComponentModel.ISupportInitialize).BeginInit()
        CType(User_profilePhoto, ComponentModel.ISupportInitialize).BeginInit()
        CType(Trainee_icon, ComponentModel.ISupportInitialize).BeginInit()
        CType(Learners_icon, ComponentModel.ISupportInitialize).BeginInit()
        CType(Online_lessons_icon, ComponentModel.ISupportInitialize).BeginInit()
        CType(License_icon, ComponentModel.ISupportInitialize).BeginInit()
        CType(Logout_icon, ComponentModel.ISupportInitialize).BeginInit()
        CType(Dashboard_icon, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TraineeForm
        ' 
        TraineeForm.BackColor = Color.FromArgb(CByte(0), CByte(108), CByte(112))
        TraineeForm.Controls.Add(Label4)
        TraineeForm.Controls.Add(Label3)
        TraineeForm.Controls.Add(Label2)
        TraineeForm.Controls.Add(Label1)
        TraineeForm.Controls.Add(Asterix)
        TraineeForm.Controls.Add(RefreshButton)
        TraineeForm.Controls.Add(TraineeEmail)
        TraineeForm.Controls.Add(TraineeList)
        TraineeForm.Controls.Add(Trainee_listing)
        TraineeForm.Controls.Add(Trainee_email)
        TraineeForm.Controls.Add(Delete)
        TraineeForm.Controls.Add(Save)
        TraineeForm.Controls.Add(Edit)
        TraineeForm.Controls.Add(TraineeGender)
        TraineeForm.Controls.Add(TraineeAddress)
        TraineeForm.Controls.Add(TraineePhone)
        TraineeForm.Controls.Add(TraineeName)
        TraineeForm.Controls.Add(Trainee_gender)
        TraineeForm.Controls.Add(Trainee_address)
        TraineeForm.Controls.Add(Trainee_phone)
        TraineeForm.Controls.Add(Trainee_name)
        TraineeForm.Controls.Add(ManageTrainee)
        TraineeForm.Controls.Add(Trainee_logo)
        TraineeForm.Location = New Point(324, 180)
        TraineeForm.Name = "TraineeForm"
        TraineeForm.Size = New Size(1699, 967)
        TraineeForm.TabIndex = 0
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.ForeColor = Color.Red
        Label4.Location = New Point(271, 656)
        Label4.Name = "Label4"
        Label4.Size = New Size(24, 32)
        Label4.TabIndex = 30
        Label4.Text = "*"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.ForeColor = Color.Red
        Label3.Location = New Point(260, 542)
        Label3.Name = "Label3"
        Label3.Size = New Size(24, 32)
        Label3.TabIndex = 29
        Label3.Text = "*"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = Color.Red
        Label2.Location = New Point(271, 384)
        Label2.Name = "Label2"
        Label2.Size = New Size(24, 32)
        Label2.TabIndex = 28
        Label2.Text = "*"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = Color.Red
        Label1.Location = New Point(378, 264)
        Label1.Name = "Label1"
        Label1.Size = New Size(24, 32)
        Label1.TabIndex = 27
        Label1.Text = "*"
        ' 
        ' Asterix
        ' 
        Asterix.AutoSize = True
        Asterix.ForeColor = Color.Red
        Asterix.Location = New Point(238, 144)
        Asterix.Name = "Asterix"
        Asterix.Size = New Size(24, 32)
        Asterix.TabIndex = 26
        Asterix.Text = "*"
        ' 
        ' RefreshButton
        ' 
        RefreshButton.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        RefreshButton.Location = New Point(414, 899)
        RefreshButton.Name = "RefreshButton"
        RefreshButton.Size = New Size(178, 57)
        RefreshButton.TabIndex = 24
        RefreshButton.Text = "Refresh"
        RefreshButton.UseVisualStyleBackColor = True
        ' 
        ' TraineeEmail
        ' 
        TraineeEmail.AcceptsReturn = True
        TraineeEmail.AcceptsTab = True
        TraineeEmail.AutoCompleteMode = AutoCompleteMode.Suggest
        TraineeEmail.Font = New Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TraineeEmail.Location = New Point(155, 708)
        TraineeEmail.MaxLength = 20
        TraineeEmail.Name = "TraineeEmail"
        TraineeEmail.PlaceholderText = "Enter your Email Id"
        TraineeEmail.Size = New Size(437, 43)
        TraineeEmail.TabIndex = 22
        ' 
        ' TraineeList
        ' 
        TraineeList.AutoSize = True
        TraineeList.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TraineeList.Location = New Point(650, 136)
        TraineeList.Name = "TraineeList"
        TraineeList.Size = New Size(227, 45)
        TraineeList.TabIndex = 21
        TraineeList.Text = "Instructor List"
        ' 
        ' Trainee_listing
        ' 
        Trainee_listing.BackgroundColor = SystemColors.ControlLightLight
        Trainee_listing.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Trainee_listing.Location = New Point(650, 195)
        Trainee_listing.Name = "Trainee_listing"
        Trainee_listing.RowHeadersWidth = 82
        Trainee_listing.Size = New Size(1023, 761)
        Trainee_listing.TabIndex = 20
        ' 
        ' Trainee_email
        ' 
        Trainee_email.AutoSize = True
        Trainee_email.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Trainee_email.Location = New Point(144, 656)
        Trainee_email.Name = "Trainee_email"
        Trainee_email.Size = New Size(140, 45)
        Trainee_email.TabIndex = 18
        Trainee_email.Text = "Email Id"
        ' 
        ' Delete
        ' 
        Delete.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Delete.Location = New Point(155, 899)
        Delete.Name = "Delete"
        Delete.Size = New Size(178, 57)
        Delete.TabIndex = 17
        Delete.Text = "Delete"
        Delete.UseVisualStyleBackColor = True
        ' 
        ' Save
        ' 
        Save.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Save.Location = New Point(414, 824)
        Save.Name = "Save"
        Save.Size = New Size(178, 57)
        Save.TabIndex = 16
        Save.Text = "Save"
        Save.UseVisualStyleBackColor = True
        ' 
        ' Edit
        ' 
        Edit.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Edit.Location = New Point(155, 824)
        Edit.Name = "Edit"
        Edit.Size = New Size(178, 57)
        Edit.TabIndex = 14
        Edit.Text = "Edit"
        Edit.UseVisualStyleBackColor = True
        ' 
        ' TraineeGender
        ' 
        TraineeGender.Font = New Font("Segoe UI", 10F)
        TraineeGender.FormattingEnabled = True
        TraineeGender.Items.AddRange(New Object() {"Female", "Male"})
        TraineeGender.Location = New Point(155, 590)
        TraineeGender.Name = "TraineeGender"
        TraineeGender.Size = New Size(437, 45)
        TraineeGender.TabIndex = 13
        ' 
        ' TraineeAddress
        ' 
        TraineeAddress.Font = New Font("Segoe UI", 10F)
        TraineeAddress.Location = New Point(155, 444)
        TraineeAddress.Name = "TraineeAddress"
        TraineeAddress.Size = New Size(437, 73)
        TraineeAddress.TabIndex = 12
        TraineeAddress.Text = ""
        ' 
        ' TraineePhone
        ' 
        TraineePhone.AcceptsReturn = True
        TraineePhone.AcceptsTab = True
        TraineePhone.AutoCompleteMode = AutoCompleteMode.Suggest
        TraineePhone.Font = New Font("Segoe UI", 10F)
        TraineePhone.Location = New Point(155, 316)
        TraineePhone.MaxLength = 11
        TraineePhone.Name = "TraineePhone"
        TraineePhone.PlaceholderText = "Enter your phone number"
        TraineePhone.Size = New Size(437, 43)
        TraineePhone.TabIndex = 11
        ' 
        ' TraineeName
        ' 
        TraineeName.AcceptsReturn = True
        TraineeName.AcceptsTab = True
        TraineeName.AutoCompleteMode = AutoCompleteMode.Suggest
        TraineeName.Font = New Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TraineeName.Location = New Point(155, 195)
        TraineeName.MaxLength = 20
        TraineeName.Name = "TraineeName"
        TraineeName.PlaceholderText = "Enter your Name"
        TraineeName.Size = New Size(437, 43)
        TraineeName.TabIndex = 10
        ' 
        ' Trainee_gender
        ' 
        Trainee_gender.AutoSize = True
        Trainee_gender.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Trainee_gender.Location = New Point(144, 542)
        Trainee_gender.Name = "Trainee_gender"
        Trainee_gender.Size = New Size(129, 45)
        Trainee_gender.TabIndex = 9
        Trainee_gender.Text = "Gender"
        ' 
        ' Trainee_address
        ' 
        Trainee_address.AutoSize = True
        Trainee_address.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Trainee_address.Location = New Point(144, 384)
        Trainee_address.Name = "Trainee_address"
        Trainee_address.Size = New Size(141, 45)
        Trainee_address.TabIndex = 8
        Trainee_address.Text = "Address"
        ' 
        ' Trainee_phone
        ' 
        Trainee_phone.AutoSize = True
        Trainee_phone.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Trainee_phone.Location = New Point(144, 264)
        Trainee_phone.Name = "Trainee_phone"
        Trainee_phone.Size = New Size(247, 45)
        Trainee_phone.TabIndex = 7
        Trainee_phone.Text = "Phone Number"
        ' 
        ' Trainee_name
        ' 
        Trainee_name.AutoSize = True
        Trainee_name.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Trainee_name.Location = New Point(144, 136)
        Trainee_name.Name = "Trainee_name"
        Trainee_name.Size = New Size(108, 45)
        Trainee_name.TabIndex = 6
        Trainee_name.Text = "Name"
        ' 
        ' ManageTrainee
        ' 
        ManageTrainee.AutoSize = True
        ManageTrainee.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ManageTrainee.Location = New Point(133, 44)
        ManageTrainee.Name = "ManageTrainee"
        ManageTrainee.Size = New Size(311, 45)
        ManageTrainee.TabIndex = 5
        ManageTrainee.Text = "Manage Instructors"
        ' 
        ' Trainee_logo
        ' 
        Trainee_logo.Image = CType(resources.GetObject("Trainee_logo.Image"), Image)
        Trainee_logo.Location = New Point(19, 24)
        Trainee_logo.Name = "Trainee_logo"
        Trainee_logo.Size = New Size(108, 95)
        Trainee_logo.SizeMode = PictureBoxSizeMode.Zoom
        Trainee_logo.TabIndex = 4
        Trainee_logo.TabStop = False
        ' 
        ' App_logo
        ' 
        App_logo.Image = CType(resources.GetObject("App_logo.Image"), Image)
        App_logo.Location = New Point(12, 2)
        App_logo.Name = "App_logo"
        App_logo.Size = New Size(292, 170)
        App_logo.SizeMode = PictureBoxSizeMode.StretchImage
        App_logo.TabIndex = 1
        App_logo.TabStop = False
        ' 
        ' User_profilePhoto
        ' 
        User_profilePhoto.Image = CType(resources.GetObject("User_profilePhoto.Image"), Image)
        User_profilePhoto.Location = New Point(1918, 42)
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
        UserProfile.Location = New Point(1756, 65)
        UserProfile.Name = "UserProfile"
        UserProfile.Size = New Size(156, 40)
        UserProfile.TabIndex = 3
        UserProfile.Text = "Username"
        ' 
        ' App_name
        ' 
        App_name.AutoSize = True
        App_name.Font = New Font("Segoe UI", 19.875F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        App_name.ForeColor = Color.FromArgb(CByte(0), CByte(108), CByte(112))
        App_name.Location = New Point(783, 52)
        App_name.Name = "App_name"
        App_name.Size = New Size(765, 71)
        App_name.TabIndex = 4
        App_name.Text = "Road Warriors Driving School"
        ' 
        ' Trainee_icon
        ' 
        Trainee_icon.Image = CType(resources.GetObject("Trainee_icon.Image"), Image)
        Trainee_icon.Location = New Point(98, 370)
        Trainee_icon.Name = "Trainee_icon"
        Trainee_icon.Size = New Size(108, 95)
        Trainee_icon.SizeMode = PictureBoxSizeMode.Zoom
        Trainee_icon.TabIndex = 3
        Trainee_icon.TabStop = False
        ' 
        ' Learners_icon
        ' 
        Learners_icon.Image = CType(resources.GetObject("Learners_icon.Image"), Image)
        Learners_icon.Location = New Point(98, 529)
        Learners_icon.Name = "Learners_icon"
        Learners_icon.Size = New Size(108, 95)
        Learners_icon.SizeMode = PictureBoxSizeMode.Zoom
        Learners_icon.TabIndex = 5
        Learners_icon.TabStop = False
        ' 
        ' Online_lessons_icon
        ' 
        Online_lessons_icon.Image = CType(resources.GetObject("Online_lessons_icon.Image"), Image)
        Online_lessons_icon.Location = New Point(98, 678)
        Online_lessons_icon.Name = "Online_lessons_icon"
        Online_lessons_icon.Size = New Size(108, 95)
        Online_lessons_icon.SizeMode = PictureBoxSizeMode.Zoom
        Online_lessons_icon.TabIndex = 4
        Online_lessons_icon.TabStop = False
        ' 
        ' License_icon
        ' 
        License_icon.Image = CType(resources.GetObject("License_icon.Image"), Image)
        License_icon.Location = New Point(98, 842)
        License_icon.Name = "License_icon"
        License_icon.Size = New Size(108, 95)
        License_icon.SizeMode = PictureBoxSizeMode.Zoom
        License_icon.TabIndex = 4
        License_icon.TabStop = False
        ' 
        ' Logout_icon
        ' 
        Logout_icon.Image = CType(resources.GetObject("Logout_icon.Image"), Image)
        Logout_icon.Location = New Point(98, 989)
        Logout_icon.Name = "Logout_icon"
        Logout_icon.Size = New Size(108, 95)
        Logout_icon.SizeMode = PictureBoxSizeMode.Zoom
        Logout_icon.TabIndex = 4
        Logout_icon.TabStop = False
        ' 
        ' Dashboard_icon
        ' 
        Dashboard_icon.Image = CType(resources.GetObject("Dashboard_icon.Image"), Image)
        Dashboard_icon.Location = New Point(98, 180)
        Dashboard_icon.Name = "Dashboard_icon"
        Dashboard_icon.Size = New Size(108, 100)
        Dashboard_icon.SizeMode = PictureBoxSizeMode.Zoom
        Dashboard_icon.TabIndex = 7
        Dashboard_icon.TabStop = False
        ' 
        ' SideMenu_Dashboard
        ' 
        SideMenu_Dashboard.AutoSize = True
        SideMenu_Dashboard.Font = New Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        SideMenu_Dashboard.ForeColor = Color.FromArgb(CByte(0), CByte(108), CByte(112))
        SideMenu_Dashboard.Location = New Point(73, 300)
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
        ' Panel1
        ' 
        Panel1.Location = New Point(1, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(317, 1136)
        Panel1.TabIndex = 15
        ' 
        ' Trainers
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
        Controls.Add(Dashboard_icon)
        Controls.Add(Logout_icon)
        Controls.Add(License_icon)
        Controls.Add(Online_lessons_icon)
        Controls.Add(Learners_icon)
        Controls.Add(Trainee_icon)
        Controls.Add(App_name)
        Controls.Add(UserProfile)
        Controls.Add(User_profilePhoto)
        Controls.Add(App_logo)
        Controls.Add(TraineeForm)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "Trainers"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Trainers_form"
        TraineeForm.ResumeLayout(False)
        TraineeForm.PerformLayout()
        CType(Trainee_listing, ComponentModel.ISupportInitialize).EndInit()
        CType(Trainee_logo, ComponentModel.ISupportInitialize).EndInit()
        CType(App_logo, ComponentModel.ISupportInitialize).EndInit()
        CType(User_profilePhoto, ComponentModel.ISupportInitialize).EndInit()
        CType(Trainee_icon, ComponentModel.ISupportInitialize).EndInit()
        CType(Learners_icon, ComponentModel.ISupportInitialize).EndInit()
        CType(Online_lessons_icon, ComponentModel.ISupportInitialize).EndInit()
        CType(License_icon, ComponentModel.ISupportInitialize).EndInit()
        CType(Logout_icon, ComponentModel.ISupportInitialize).EndInit()
        CType(Dashboard_icon, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Trainee_logo As PictureBox
    Friend WithEvents TraineeAddress As RichTextBox
    Friend WithEvents UserProfile As Label
    Friend WithEvents App_name As Label
    Friend WithEvents Trainee_gender As Label
    Friend WithEvents Trainee_address As Label
    Friend WithEvents Trainee_phone As Label
    Friend WithEvents Trainee_name As Label
    Friend WithEvents ManageTrainee As Label
    Friend WithEvents Trainee_email As Label
    Friend WithEvents TraineeList As Label
    Friend WithEvents TraineePhone As TextBox
    Friend WithEvents TraineeName As TextBox
    Friend WithEvents TraineeEmail As TextBox
    Friend WithEvents TraineeGender As ComboBox
    Friend WithEvents Delete As Button
    Friend WithEvents Save As Button
    Friend WithEvents Update As Button
    Friend WithEvents Edit As Button
    Friend WithEvents Trainee_listing As DataGridView
    Friend WithEvents RefreshButton As Button
    Friend WithEvents Dashboard_icon As PictureBox
    Friend WithEvents SideMenu_Dashboard As Label
    Friend WithEvents SideMenu_Students As Label
    Friend WithEvents SideMenu_Lessons As Label
    Friend WithEvents SideMenu_License As Label
    Friend WithEvents SideMenu_Logout As Label
    Friend WithEvents SideMenu_Instructors As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Asterix As Label
    Friend WithEvents Panel1 As Panel
End Class
