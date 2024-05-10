Imports System.Windows.Forms.VisualStyles.VisualStyleElement


Public Class Dashboard

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AboutRichTextBox.Text = "Road Warriors Driving School" & vbCrLf & vbCrLf &
                             "Road Warriors Driving School is a premier driving school located in Birmingham. We offer a wide range of driving courses for beginners, experienced drivers, and commercial vehicle operators." & vbCrLf & vbCrLf &
                             "Our experienced and certified instructors provide comprehensive training to ensure that our students develop the necessary skills and knowledge to become safe and responsible drivers." & vbCrLf & vbCrLf &
                             "At Road Warriors Driving School, we prioritize safety, professionalism, and customer satisfaction. Our state-of-the-art facilities and modern teaching methods ensure an engaging and effective learning experience." & vbCrLf & vbCrLf &
                             "Contact us today to learn more about our driving courses and enroll in one of our programs." & vbCrLf & vbCrLf &
                             "roadwarriors@drive.com"

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

    Private Sub Online_lessons_icon_Click(sender As Object, e As EventArgs) Handles Online_lessons_icon.Click
        Dim mainForm As New DrivingCourses()
        mainForm.Show()
        Me.Hide()
    End Sub

    Private Sub License_icon_Click(sender As Object, e As EventArgs) Handles License_icon.Click
        Dim mainForm As New LicenseTestInfo()
        mainForm.Show()
        Me.Hide()
    End Sub

    Private Sub Logout_Click(sender As Object, e As EventArgs) Handles Logout_icon.Click
        ' Close the current form
        Me.Close()

        ' Show the login form or the main application form
        Dim loginForm As New Login_page()
        loginForm.Show()
    End Sub


End Class