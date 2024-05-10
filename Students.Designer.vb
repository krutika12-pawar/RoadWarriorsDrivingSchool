<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Students
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Students))
        StudentForm = New Panel()
        Course_type_dropdown = New ComboBox()
        CourseType = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Asterix = New Label()
        RefreshButton = New Button()
        StudentEmail = New TextBox()
        StudentList = New Label()
        Student_listing = New DataGridView()
        Student_email = New Label()
        Delete = New Button()
        Save = New Button()
        Edit = New Button()
        StudentGender = New ComboBox()
        StudentAddress = New RichTextBox()
        StudentPhone = New TextBox()
        StudentAge = New TextBox()
        StudentName = New TextBox()
        Student_gender = New Label()
        Student_address = New Label()
        Student_phone = New Label()
        Student_age = New Label()
        Student_name = New Label()
        ManageStudent = New Label()
        Trainee_logo = New PictureBox()
        CourseBindingSource = New BindingSource(components)
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
        FileSystemWatcher1 = New IO.FileSystemWatcher()
        Panel1 = New Panel()
        Label6 = New Label()
        StudentForm.SuspendLayout()
        CType(Student_listing, ComponentModel.ISupportInitialize).BeginInit()
        CType(Trainee_logo, ComponentModel.ISupportInitialize).BeginInit()
        CType(CourseBindingSource, ComponentModel.ISupportInitialize).BeginInit()
        CType(App_logo, ComponentModel.ISupportInitialize).BeginInit()
        CType(User_profilePhoto, ComponentModel.ISupportInitialize).BeginInit()
        CType(Trainee_icon, ComponentModel.ISupportInitialize).BeginInit()
        CType(Learners_icon, ComponentModel.ISupportInitialize).BeginInit()
        CType(Online_lessons_icon, ComponentModel.ISupportInitialize).BeginInit()
        CType(License_icon, ComponentModel.ISupportInitialize).BeginInit()
        CType(Logout_icon, ComponentModel.ISupportInitialize).BeginInit()
        CType(Dashboard_icon, ComponentModel.ISupportInitialize).BeginInit()
        CType(FileSystemWatcher1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' StudentForm
        ' 
        StudentForm.AutoScroll = True
        StudentForm.BackColor = Color.FromArgb(CByte(0), CByte(108), CByte(112))
        StudentForm.Controls.Add(Label6)
        StudentForm.Controls.Add(Course_type_dropdown)
        StudentForm.Controls.Add(CourseType)
        StudentForm.Controls.Add(Label5)
        StudentForm.Controls.Add(Label4)
        StudentForm.Controls.Add(Label3)
        StudentForm.Controls.Add(Label2)
        StudentForm.Controls.Add(Label1)
        StudentForm.Controls.Add(Asterix)
        StudentForm.Controls.Add(RefreshButton)
        StudentForm.Controls.Add(StudentEmail)
        StudentForm.Controls.Add(StudentList)
        StudentForm.Controls.Add(Student_listing)
        StudentForm.Controls.Add(Student_email)
        StudentForm.Controls.Add(Delete)
        StudentForm.Controls.Add(Save)
        StudentForm.Controls.Add(Edit)
        StudentForm.Controls.Add(StudentGender)
        StudentForm.Controls.Add(StudentAddress)
        StudentForm.Controls.Add(StudentPhone)
        StudentForm.Controls.Add(StudentAge)
        StudentForm.Controls.Add(StudentName)
        StudentForm.Controls.Add(Student_gender)
        StudentForm.Controls.Add(Student_address)
        StudentForm.Controls.Add(Student_phone)
        StudentForm.Controls.Add(Student_age)
        StudentForm.Controls.Add(Student_name)
        StudentForm.Controls.Add(ManageStudent)
        StudentForm.Controls.Add(Trainee_logo)
        StudentForm.ForeColor = Color.Black
        StudentForm.Location = New Point(324, 180)
        StudentForm.Name = "StudentForm"
        StudentForm.Size = New Size(1699, 1281)
        StudentForm.TabIndex = 0
        ' 
        ' Course_type_dropdown
        ' 
        Course_type_dropdown.Font = New Font("Segoe UI", 10.0F)
        Course_type_dropdown.FormattingEnabled = True
        Course_type_dropdown.Items.AddRange(New Object() {"Basic Driving Course", "Advanced Driving Course", "Defensive Driving Course", "Refresher Driving Course", "Commercial Driving Course", "Motorcycle Driving Course"})
        Course_type_dropdown.Location = New Point(155, 791)
        Course_type_dropdown.Name = "Course_type_dropdown"
        Course_type_dropdown.Size = New Size(437, 45)
        Course_type_dropdown.TabIndex = 32
        ' 
        ' CourseType
        ' 
        CourseType.AutoSize = True
        CourseType.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        CourseType.Location = New Point(144, 743)
        CourseType.Name = "CourseType"
        CourseType.Size = New Size(204, 45)
        CourseType.TabIndex = 31
        CourseType.Text = "Course Type"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.ForeColor = Color.Red
        Label5.Location = New Point(211, 649)
        Label5.Name = "Label5"
        Label5.Size = New Size(24, 32)
        Label5.TabIndex = 30
        Label5.Text = "*"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.ForeColor = Color.Red
        Label4.Location = New Point(271, 545)
        Label4.Name = "Label4"
        Label4.Size = New Size(24, 32)
        Label4.TabIndex = 29
        Label4.Text = "*"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.ForeColor = Color.Red
        Label3.Location = New Point(261, 459)
        Label3.Name = "Label3"
        Label3.Size = New Size(24, 32)
        Label3.TabIndex = 28
        Label3.Text = "*"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = Color.Red
        Label2.Location = New Point(271, 334)
        Label2.Name = "Label2"
        Label2.Size = New Size(24, 32)
        Label2.TabIndex = 27
        Label2.Text = "*"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = Color.Red
        Label1.Location = New Point(379, 240)
        Label1.Name = "Label1"
        Label1.Size = New Size(24, 32)
        Label1.TabIndex = 26
        Label1.Text = "*"
        ' 
        ' Asterix
        ' 
        Asterix.AutoSize = True
        Asterix.ForeColor = Color.Red
        Asterix.Location = New Point(239, 146)
        Asterix.Name = "Asterix"
        Asterix.Size = New Size(24, 32)
        Asterix.TabIndex = 25
        Asterix.Text = "*"
        ' 
        ' RefreshButton
        ' 
        RefreshButton.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        RefreshButton.Location = New Point(414, 1202)
        RefreshButton.Name = "RefreshButton"
        RefreshButton.Size = New Size(178, 57)
        RefreshButton.TabIndex = 24
        RefreshButton.Text = "Refresh"
        RefreshButton.UseVisualStyleBackColor = True
        ' 
        ' StudentEmail
        ' 
        StudentEmail.AcceptsReturn = True
        StudentEmail.AcceptsTab = True
        StudentEmail.AutoCompleteMode = AutoCompleteMode.Suggest
        StudentEmail.Font = New Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        StudentEmail.Location = New Point(155, 592)
        StudentEmail.MaxLength = 20
        StudentEmail.Name = "StudentEmail"
        StudentEmail.PlaceholderText = "Enter your Email Id"
        StudentEmail.Size = New Size(437, 43)
        StudentEmail.TabIndex = 22
        ' 
        ' StudentList
        ' 
        StudentList.AutoSize = True
        StudentList.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        StudentList.Location = New Point(650, 136)
        StudentList.Name = "StudentList"
        StudentList.Size = New Size(196, 45)
        StudentList.TabIndex = 21
        StudentList.Text = "Student List"
        ' 
        ' Student_listing
        ' 
        Student_listing.BackgroundColor = SystemColors.ControlLightLight
        Student_listing.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Student_listing.Location = New Point(650, 195)
        Student_listing.Name = "Student_listing"
        Student_listing.RowHeadersWidth = 82
        Student_listing.Size = New Size(1023, 761)
        Student_listing.TabIndex = 20
        ' 
        ' Student_email
        ' 
        Student_email.AutoSize = True
        Student_email.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Student_email.Location = New Point(145, 545)
        Student_email.Name = "Student_email"
        Student_email.Size = New Size(140, 45)
        Student_email.TabIndex = 18
        Student_email.Text = "Email Id"
        ' 
        ' Delete
        ' 
        Delete.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Delete.Location = New Point(155, 1202)
        Delete.Name = "Delete"
        Delete.Size = New Size(178, 57)
        Delete.TabIndex = 17
        Delete.Text = "Delete"
        Delete.UseVisualStyleBackColor = True
        ' 
        ' Save
        ' 
        Save.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Save.Location = New Point(414, 1124)
        Save.Name = "Save"
        Save.Size = New Size(178, 57)
        Save.TabIndex = 16
        Save.Text = "Save"
        Save.UseVisualStyleBackColor = True
        ' 
        ' Edit
        ' 
        Edit.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Edit.Location = New Point(155, 1124)
        Edit.Name = "Edit"
        Edit.Size = New Size(178, 57)
        Edit.TabIndex = 14
        Edit.Text = "Edit"
        Edit.UseVisualStyleBackColor = True
        ' 
        ' StudentGender
        ' 
        StudentGender.Font = New Font("Segoe UI", 10.0F)
        StudentGender.FormattingEnabled = True
        StudentGender.Items.AddRange(New Object() {"Female", "Male"})
        StudentGender.Location = New Point(155, 497)
        StudentGender.Name = "StudentGender"
        StudentGender.Size = New Size(437, 45)
        StudentGender.TabIndex = 13
        ' 
        ' StudentAddress
        ' 
        StudentAddress.Font = New Font("Segoe UI", 10.0F)
        StudentAddress.Location = New Point(155, 373)
        StudentAddress.Name = "StudentAddress"
        StudentAddress.Size = New Size(437, 73)
        StudentAddress.TabIndex = 12
        StudentAddress.Text = ""
        ' 
        ' StudentPhone
        ' 
        StudentPhone.AcceptsReturn = True
        StudentPhone.AcceptsTab = True
        StudentPhone.AutoCompleteMode = AutoCompleteMode.Suggest
        StudentPhone.Font = New Font("Segoe UI", 10.0F)
        StudentPhone.Location = New Point(155, 278)
        StudentPhone.MaxLength = 11
        StudentPhone.Name = "StudentPhone"
        StudentPhone.PlaceholderText = "Enter your phone number"
        StudentPhone.Size = New Size(437, 43)
        StudentPhone.TabIndex = 11
        ' 
        ' StudentAge
        ' 
        StudentAge.AcceptsReturn = True
        StudentAge.AcceptsTab = True
        StudentAge.AutoCompleteMode = AutoCompleteMode.Suggest
        StudentAge.Font = New Font("Segoe UI", 10.0F)
        StudentAge.Location = New Point(155, 697)
        StudentAge.MaxLength = 2
        StudentAge.Name = "StudentAge"
        StudentAge.PlaceholderText = "Enter your age"
        StudentAge.Size = New Size(437, 43)
        StudentAge.TabIndex = 11
        ' 
        ' StudentName
        ' 
        StudentName.AcceptsReturn = True
        StudentName.AcceptsTab = True
        StudentName.AutoCompleteMode = AutoCompleteMode.Suggest
        StudentName.Font = New Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        StudentName.Location = New Point(155, 184)
        StudentName.MaxLength = 20
        StudentName.Name = "StudentName"
        StudentName.PlaceholderText = "Enter your Name"
        StudentName.Size = New Size(437, 43)
        StudentName.TabIndex = 10
        ' 
        ' Student_gender
        ' 
        Student_gender.AutoSize = True
        Student_gender.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Student_gender.Location = New Point(144, 449)
        Student_gender.Name = "Student_gender"
        Student_gender.Size = New Size(129, 45)
        Student_gender.TabIndex = 9
        Student_gender.Text = "Gender"
        ' 
        ' Student_address
        ' 
        Student_address.AutoSize = True
        Student_address.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Student_address.Location = New Point(144, 324)
        Student_address.Name = "Student_address"
        Student_address.Size = New Size(141, 45)
        Student_address.TabIndex = 8
        Student_address.Text = "Address"
        ' 
        ' Student_phone
        ' 
        Student_phone.AutoSize = True
        Student_phone.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Student_phone.Location = New Point(144, 230)
        Student_phone.Name = "Student_phone"
        Student_phone.Size = New Size(247, 45)
        Student_phone.TabIndex = 7
        Student_phone.Text = "Phone Number"
        ' 
        ' Student_age
        ' 
        Student_age.AutoSize = True
        Student_age.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Student_age.Location = New Point(145, 649)
        Student_age.Name = "Student_age"
        Student_age.Size = New Size(80, 45)
        Student_age.TabIndex = 7
        Student_age.Text = "Age"
        ' 
        ' Student_name
        ' 
        Student_name.AutoSize = True
        Student_name.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Student_name.Location = New Point(144, 136)
        Student_name.Name = "Student_name"
        Student_name.Size = New Size(108, 45)
        Student_name.TabIndex = 6
        Student_name.Text = "Name"
        ' 
        ' ManageStudent
        ' 
        ManageStudent.AutoSize = True
        ManageStudent.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ManageStudent.Location = New Point(133, 44)
        ManageStudent.Name = "ManageStudent"
        ManageStudent.Size = New Size(280, 45)
        ManageStudent.TabIndex = 5
        ManageStudent.Text = "Manage Students"
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
        ' CourseBindingSource
        ' 
        CourseBindingSource.DataSource = GetType(Course)
        ' 
        ' App_logo
        ' 
        App_logo.Image = CType(resources.GetObject("App_logo.Image"), Image)
        App_logo.Location = New Point(-13, -25)
        App_logo.Name = "App_logo"
        App_logo.Size = New Size(316, 201)
        App_logo.SizeMode = PictureBoxSizeMode.StretchImage
        App_logo.TabIndex = 1
        App_logo.TabStop = False
        ' 
        ' User_profilePhoto
        ' 
        User_profilePhoto.Image = CType(resources.GetObject("User_profilePhoto.Image"), Image)
        User_profilePhoto.Location = New Point(1944, 37)
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
        UserProfile.Location = New Point(1830, 62)
        UserProfile.Name = "UserProfile"
        UserProfile.Size = New Size(108, 40)
        UserProfile.TabIndex = 3
        UserProfile.Text = "Admin"
        ' 
        ' App_name
        ' 
        App_name.AutoSize = True
        App_name.Font = New Font("Segoe UI", 19.875F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        App_name.Location = New Point(643, 37)
        App_name.Name = "App_name"
        App_name.Size = New Size(765, 71)
        App_name.TabIndex = 4
        App_name.Text = "Road Warriors Driving School"
        App_name.TextAlign = ContentAlignment.TopCenter
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
        SideMenu_Logout.Location = New Point(91, 1096)
        SideMenu_Logout.Name = "SideMenu_Logout"
        SideMenu_Logout.Size = New Size(109, 37)
        SideMenu_Logout.TabIndex = 14
        SideMenu_Logout.Text = "Logout"
        ' 
        ' FileSystemWatcher1
        ' 
        FileSystemWatcher1.EnableRaisingEvents = True
        FileSystemWatcher1.SynchronizingObject = Me
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(App_logo)
        Panel1.Location = New Point(1, -2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(303, 1149)
        Panel1.TabIndex = 15
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.ForeColor = Color.Red
        Label6.Location = New Point(336, 743)
        Label6.Name = "Label6"
        Label6.Size = New Size(24, 32)
        Label6.TabIndex = 33
        Label6.Text = "*"
        ' 
        ' Students
        ' 
        AutoScaleDimensions = New SizeF(13.0F, 32.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Black
        ClientSize = New Size(2055, 1473)
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
        Controls.Add(StudentForm)
        Controls.Add(Panel1)
        ForeColor = Color.FromArgb(CByte(0), CByte(108), CByte(112))
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "Students"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Students_form"
        StudentForm.ResumeLayout(False)
        StudentForm.PerformLayout()
        CType(Student_listing, ComponentModel.ISupportInitialize).EndInit()
        CType(Trainee_logo, ComponentModel.ISupportInitialize).EndInit()
        CType(CourseBindingSource, ComponentModel.ISupportInitialize).EndInit()
        CType(App_logo, ComponentModel.ISupportInitialize).EndInit()
        CType(User_profilePhoto, ComponentModel.ISupportInitialize).EndInit()
        CType(Trainee_icon, ComponentModel.ISupportInitialize).EndInit()
        CType(Learners_icon, ComponentModel.ISupportInitialize).EndInit()
        CType(Online_lessons_icon, ComponentModel.ISupportInitialize).EndInit()
        CType(License_icon, ComponentModel.ISupportInitialize).EndInit()
        CType(Logout_icon, ComponentModel.ISupportInitialize).EndInit()
        CType(Dashboard_icon, ComponentModel.ISupportInitialize).EndInit()
        CType(FileSystemWatcher1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents StudentForm As Panel
    Friend WithEvents App_logo As PictureBox
    Friend WithEvents User_profilePhoto As PictureBox
    Friend WithEvents Trainee_icon As PictureBox
    Friend WithEvents Learners_icon As PictureBox
    Friend WithEvents Online_lessons_icon As PictureBox
    Friend WithEvents License_icon As PictureBox
    Friend WithEvents Logout_icon As PictureBox
    Friend WithEvents Trainee_logo As PictureBox
    Friend WithEvents StudentAddress As RichTextBox
    Friend WithEvents UserProfile As Label
    Friend WithEvents App_name As Label
    Friend WithEvents Student_gender As Label
    Friend WithEvents Student_address As Label
    Friend WithEvents Student_phone As Label
    Friend WithEvents Student_age As Label
    Friend WithEvents Student_name As Label
    Friend WithEvents ManageStudent As Label
    Friend WithEvents Student_email As Label
    Friend WithEvents StudentList As Label
    Friend WithEvents StudentPhone As TextBox
    Friend WithEvents StudentAge As TextBox
    Friend WithEvents StudentName As TextBox
    Friend WithEvents StudentEmail As TextBox
    Friend WithEvents StudentGender As ComboBox
    Friend WithEvents Delete As Button
    Friend WithEvents Save As Button
    Friend WithEvents Edit As Button
    Friend WithEvents Student_listing As DataGridView
    Friend WithEvents RefreshButton As Button
    Friend WithEvents Dashboard_icon As PictureBox
    Friend WithEvents SideMenu_Dashboard As Label
    Friend WithEvents SideMenu_Students As Label
    Friend WithEvents SideMenu_Lessons As Label
    Friend WithEvents SideMenu_License As Label
    Friend WithEvents SideMenu_Logout As Label
    Friend WithEvents SideMenu_Instructors As Label
    Friend WithEvents Asterix As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents FileSystemWatcher1 As IO.FileSystemWatcher
    Friend WithEvents Panel1 As Panel
    Friend WithEvents CourseType As Label
    Friend WithEvents Course_type_dropdown As ComboBox
    Friend WithEvents CourseBindingSource As BindingSource
    Friend WithEvents Label6 As Label
End Class
