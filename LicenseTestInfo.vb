Public Class LicenseTestInfo

    Private licenseTestInfo As String = "The driving license test consists of two parts: a written test and a road test." & vbCrLf & vbCrLf &
    "The written test evaluates your knowledge of traffic rules, road signs, and safe driving practices. The road test assesses your practical driving skills and ability to operate a vehicle safely on the road."

    Private testTypes As String = "We offer the following types of license tests:" & vbCrLf & vbCrLf &
                                "Basic Driving License Test" & vbCrLf &
                                "Advanced Driving License Test" & vbCrLf &
                                "Commercial Driving License Test" & vbCrLf &
                                "Motorcycle Driving License Test"


    Private testTimings As String = "The license tests are conducted on the following days and times:" & vbCrLf & vbCrLf &
                                    "Written Test: Monday to Friday, 9:00 AM to 5:00 PM" & vbCrLf &
                                    "Road Test: Saturday and Sunday, 8:00 AM to 4:00 PM"

    Private Sub LicenseTestInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Display the license test information
        LicensTestInfo.Text = licenseTestInfo

        ' Display the test types
        LicenseTypes.Text = testTypes

        ' Display the test timings
        LicenseTestTimings.Text = testTimings
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
        ' Close the current form
        Me.Close()

        ' Show the login form or the main application form
        Dim loginForm As New Login_page()
        loginForm.Show()
    End Sub


End Class







