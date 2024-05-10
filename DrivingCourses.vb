Public Class DrivingCourses
    Private Courses As New List(Of Course)

    Private Sub DrivingCourses_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load the driving course data from a file or database
        LoadCourseData()

        ' Populate the course data grid view
        PopulateCourseDataGridView()
    End Sub

    Private Sub LoadCourseData()
        ' Load the driving course data from a file or database and add it to the Courses list
        Courses.Add(New Course With {
            .CourseID = 1,
            .CourseName = "Basic Driving Course",
            .CourseDescription = "Covers the fundamentals of driving a car",
            .TotalLessons = 10,
            .LessonDuration = 1,
            .CourseFeesPerLesson = 50,
            .TotalCourseFeesWithDiscount = 450
        })

        Courses.Add(New Course With {
            .CourseID = 2,
            .CourseName = "Advanced Driving Course",
            .CourseDescription = "Focuses on complex driving techniques and maneuvers",
            .TotalLessons = 15,
            .LessonDuration = 1.5,
            .CourseFeesPerLesson = 60,
            .TotalCourseFeesWithDiscount = 825
        })

        Courses.Add(New Course With {
            .CourseID = 3,
            .CourseName = "Defensive Driving Course",
            .CourseDescription = "Teaches defensive driving techniques and strategies",
            .TotalLessons = 8,
            .LessonDuration = 2.0,
            .CourseFeesPerLesson = 70,
            .TotalCourseFeesWithDiscount = 520
        })

        Courses.Add(New Course With {
            .CourseID = 4,
            .CourseName = "Refresher Driving Course",
            .CourseDescription = "Helps experienced drivers brush up on their skills",
            .TotalLessons = 5,
            .LessonDuration = 1.0,
            .CourseFeesPerLesson = 45,
            .TotalCourseFeesWithDiscount = 200
        })

        Courses.Add(New Course With {
            .CourseID = 5,
            .CourseName = "Commercial Driving Course",
            .CourseDescription = "Prepares students for driving commercial vehicles",
            .TotalLessons = 20,
            .LessonDuration = 2.5,
            .CourseFeesPerLesson = 80,
            .TotalCourseFeesWithDiscount = 1500
        })

        Courses.Add(New Course With {
            .CourseID = 6,
            .CourseName = "Motorcycle Riding Course",
            .CourseDescription = "Covers the basics of riding a motorcycle",
            .TotalLessons = 12,
            .LessonDuration = 1.5,
            .CourseFeesPerLesson = 65,
            .TotalCourseFeesWithDiscount = 720
        })

    End Sub

    Public Function GetCourses() As List(Of Course)
        Return Courses
    End Function

    Private Sub PopulateCourseDataGridView()
        ' Bind the Courses list to the data grid view
        CourseDataGridView.DataSource = Courses

        ' Set the column headers
        CourseDataGridView.Columns("CourseID").HeaderText = "Course ID"
        CourseDataGridView.Columns("CourseName").HeaderText = "Course Name"
        CourseDataGridView.Columns("CourseDescription").HeaderText = "Course Description"
        CourseDataGridView.Columns("TotalLessons").HeaderText = "Total Lessons"
        CourseDataGridView.Columns("LessonDuration").HeaderText = "Lesson Duration (hours)"
        CourseDataGridView.Columns("CourseFeesPerLesson").HeaderText = "Course Fees Per Lesson (Pounds)"
        CourseDataGridView.Columns("TotalCourseFeesWithDiscount").HeaderText = "Total Course Fees With Discount (Pounds)"
    End Sub

    Private Sub Dashboard_icon_Click(sender As Object, e As EventArgs) Handles Dashboard_icon.Click
        Dim mainForm As New Dashboard()
        mainForm.Show()
        Me.Hide()
    End Sub
    Private Sub Trainee_icon_Click(sender As Object, e As EventArgs) Handles Trainee_icon.Click
        Dim mainForm As New Trainers()
        mainForm.Show()
        Me.Hide()
    End Sub

    Private Sub Learners_icon_Click(sender As Object, e As EventArgs) Handles Learners_icon.Click
        Dim mainForm As New Students()
        mainForm.Show()
        Me.Hide()
    End Sub

    Private Sub License_icon_Click(sender As Object, e As EventArgs) Handles License_icon.Click
        Dim mainForm As New LicenseTestInfo()
        mainForm.Show()
        Me.Hide()
    End Sub

    Private Sub Logout_Click(sender As Object, e As EventArgs) Handles Logout_icon.Click
        ' Perform any necessary cleanup or logout operations here
        ' For example, you can clear user data, close connections, or save user preferences

        ' Close the current form
        Me.Close()

        ' Show the login form or the main application form
        Dim loginForm As New Login_page()
        loginForm.Show()
    End Sub

End Class
Public Class Course
    Public Property CourseID As Integer
    Public Property CourseName As String
    Public Property CourseDescription As String
    Public Property TotalLessons As Integer
    Public Property LessonDuration As Double
    Public Property CourseFeesPerLesson As Double
    Public Property TotalCourseFeesWithDiscount As Double
End Class
