Imports System.IO
Imports System.Text.RegularExpressions


Public Class Students
    Public Learners As New List(Of Learner)

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load the saved trainee data from the file
        LoadLearnerData()

        ' Populate the GridView with the trainee data
        PopulateGridView()


    End Sub

    Private Sub LoadLearnerData()
        ' Load the trainee data from the file
        Learners = LoadLearnerDataFromFile()
    End Sub

    Public Function GetStudentCount() As Integer
        Return Learners.Count
    End Function

    Private Sub PopulateGridView()
        ' Bind the trainee data to the GridView
        Student_listing.DataSource = Learners
        Student_listing.Columns("Name").HeaderText = "Student Name"
        Student_listing.Columns("Phone").HeaderText = "Phone Number"
        Student_listing.Columns("Address").HeaderText = "Address"
        Student_listing.Columns("Gender").HeaderText = "Gender"
        Student_listing.Columns("Email").HeaderText = "Email Id"
        Student_listing.Columns("Age").HeaderText = "Age"
        Student_listing.Columns("Course").HeaderText = "Course Type"

    End Sub

    Private Sub StudentName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles StudentName.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub StudentPhone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles StudentPhone.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub StudentAge_KeyPress(sender As Object, e As KeyPressEventArgs) Handles StudentAge.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Save_Click(sender As Object, e As EventArgs) Handles Save.Click

        If String.IsNullOrWhiteSpace(StudentName.Text) Then
            MessageBox.Show("Please enter the student name.")
            StudentName.Focus()
            Return
        End If

        ' Validate the phone field
        If String.IsNullOrWhiteSpace(StudentPhone.Text) Then
            MessageBox.Show("Please enter the student phone number.")
            StudentPhone.Focus()
            Return
        End If

        ' Validate the address field
        If String.IsNullOrWhiteSpace(StudentAddress.Text) Then
            MessageBox.Show("Please enter the student address.")
            StudentAddress.Focus()
            Return
        End If

        ' Validate the gender field
        If String.IsNullOrWhiteSpace(StudentGender.Text) Then
            MessageBox.Show("Please select the student gender.")
            StudentGender.Focus()
            Return
        End If

        ' Validate the email field
        If String.IsNullOrWhiteSpace(StudentEmail.Text) Then
            MessageBox.Show("Please enter the student email.")
            StudentEmail.Focus()
            Return
        End If

        ' Validate the age field
        Dim ageValue As Integer
        If String.IsNullOrWhiteSpace(StudentAge.Text) Then
            MessageBox.Show("Please enter the student age.")
            StudentAge.Focus()
            Return
        ElseIf Not Integer.TryParse(StudentAge.Text, ageValue) Then
            MessageBox.Show("Please enter a valid age (numeric value).")
            StudentAge.Focus()
            Return
        ElseIf ageValue < 18 Then
            MessageBox.Show("The student age must be 18 or above.")
            StudentAge.Focus()
            Return
        End If

        If String.IsNullOrWhiteSpace(Course_type_dropdown.Text) Then
            MessageBox.Show("Please select the course type.")
            Course_type_dropdown.Focus()
            Return
        End If

        ' Validate the email ID
        If Not IsValidEmail(StudentEmail.Text) Then
            MessageBox.Show("Please enter a valid email ID.")
            Return
        End If

        ' Retrieve the values from the form controls
        Dim student As New Learner With {
        .Name = StudentName.Text,
        .Phone = StudentPhone.Text,
        .Address = StudentAddress.Text,
        .Gender = StudentGender.Text,
        .Email = StudentEmail.Text,
        .Age = StudentAge.Text,
        .Course = Course_type_dropdown.Text
    }

        ' Save the trainee data to the list
        Learners.Add(student)

        ' Save the values to a file, database, or other storage mechanism
        If SaveStudentData() Then
            ' Clear the form fields
            ClearFormFields()

            ' Reload the trainee data from the file
            LoadLearnerData()

            ' Refresh the GridView
            PopulateGridView()
        End If
    End Sub


    Public Function IsValidEmail(ByVal email As String) As Boolean
        Dim pattern As String = "^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$"
        Dim regex As New Regex(pattern)
        Return regex.IsMatch(email)
    End Function

    Private Function SaveStudentData() As Boolean
        ' Example: Save the trainee data to a text file
        Dim filePath As String = FilePathManager.StudentDataFilePath
        Dim learnerData As String = String.Join(Environment.NewLine, Learners.Select(Function(t) $"Name: {t.Name}, Phone: {t.Phone}, Address: {t.Address}, Gender: {t.Gender}, Email: {t.Email}, Age: {t.Age}, Course: {t.Course}"))

        Try
            Using writer As New StreamWriter(filePath)
                writer.Write(learnerData)
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show($"Error saving student data: {ex.Message}")
            Return False
        End Try
    End Function

    Private Function LoadLearnerDataFromFile() As List(Of Learner)
        Dim learners As New List(Of Learner)

        ' Load the trainee data from the file
        Dim filePath As String = FilePathManager.StudentDataFilePath

        If File.Exists(filePath) Then
            Try
                Using reader As New StreamReader(filePath)
                    While Not reader.EndOfStream
                        ' Read each line and split it into individual trainee data
                        Dim line As String = reader.ReadLine()
                        Dim learnerData As String() = line.Split(New String() {", "}, StringSplitOptions.RemoveEmptyEntries)

                        ' Check if the trainee data has the expected number of elements
                        If learnerData.Length = 7 Then
                            ' Create a new Trainee object and add it to the list
                            Dim learner As New Learner With {
                                .Name = learnerData(0).Split(":"c)(1).Trim(),
                                .Phone = learnerData(1).Split(":"c)(1).Trim(),
                                .Address = learnerData(2).Split(":"c)(1).Trim(),
                                .Gender = learnerData(3).Split(":"c)(1).Trim(),
                                .Email = learnerData(4).Split(":"c)(1).Trim(),
                                .Age = learnerData(5).Split(":"c)(1).Trim(),
                                .Course = learnerData(6).Split(":"c)(1).Trim()
                            }
                            learners.Add(learner)
                        Else
                            ' Handle the case where the line does not have the expected number of elements
                            MessageBox.Show($"Invalid student data format: {line}")
                        End If
                    End While
                End Using
            Catch ex As Exception
                MessageBox.Show($"Error loading student data: {ex.Message}")
            End Try
        Else
            MessageBox.Show("Student data file not found.")
        End If

        Return learners
    End Function

    Private Sub ClearFormFields()
        ' Clear the form fields
        StudentName.Text = ""
        StudentPhone.Text = ""
        StudentAddress.Text = ""
        StudentGender.Text = ""
        StudentEmail.Text = ""
        StudentAge.Text = ""
        Course_type_dropdown.Text = ""
    End Sub

    Private UpdateButton As Button
    Private Sub Edit_Click(sender As Object, e As EventArgs) Handles Edit.Click
        ' Check if a row is selected in the DataGridView
        If Student_listing.SelectedRows.Count > 0 Then
            ' Get the selected student data
            Dim selectedLearner As Learner = CType(Student_listing.SelectedRows(0).DataBoundItem, Learner)

            ' Populate the form fields with the selected student data
            StudentName.Text = selectedLearner.Name
            StudentPhone.Text = selectedLearner.Phone
            StudentAddress.Text = selectedLearner.Address
            StudentGender.Text = selectedLearner.Gender
            StudentEmail.Text = selectedLearner.Email
            StudentAge.Text = selectedLearner.Age
            Course_type_dropdown.Text = selectedLearner.Course

            ' Disable the Save button and enable the Update button
            ' Change the button text to "Update"
            Save.Text = "Update"
            UpdateButton = New Button
            UpdateButton.Text = "Update"
            StudentList.Controls.Add(UpdateButton)
            AddHandler UpdateButton.Click, AddressOf UpdateLearner
        End If
    End Sub

    Private Sub UpdateLearner(sender As Object, e As EventArgs)
        ' Validate the email ID
        If Not IsValidEmail(StudentEmail.Text) Then
            MessageBox.Show("Please enter a valid email ID.")
            Return
        End If

        ' Validate the age
        Dim ageValue As Integer
        If Not Integer.TryParse(StudentAge.Text, ageValue) Then
            MessageBox.Show("Please enter a valid age.")
            StudentAge.Focus()
            Return
        ElseIf ageValue < 18 Then
            MessageBox.Show("Your age should be 18 Years or more to take admission.")
            StudentAge.Focus()
            Return
        End If


        ' Retrieve the values from the form controls
        Dim updatedLearner As New Learner With {
            .Name = StudentName.Text,
            .Phone = StudentPhone.Text,
            .Address = StudentAddress.Text,
            .Gender = StudentGender.Text,
            .Email = StudentEmail.Text,
            .Age = StudentAge.Text,
            .Course = Course_type_dropdown.Text
        }

        ' Find the selected learner in the Learners list
        Dim selectedIndex As Integer = Student_listing.SelectedRows(0).Index
        Learners(selectedIndex) = updatedLearner

        ' Update the DataGridView row with the updated data
        Dim selectedRow As DataGridViewRow = Student_listing.Rows(selectedIndex)
        selectedRow.Cells("Name").Value = updatedLearner.Name
        selectedRow.Cells("Phone").Value = updatedLearner.Phone
        selectedRow.Cells("Address").Value = updatedLearner.Address
        selectedRow.Cells("Gender").Value = updatedLearner.Gender
        selectedRow.Cells("Email").Value = updatedLearner.Email
        selectedRow.Cells("Age").Value = updatedLearner.Age
        selectedRow.Cells("Course").Value = updatedLearner.Course


        ' Save the updated student data to the file
        If SaveStudentData() Then
            ' Clear the form fields
            ClearFormFields()

            ' Refresh the GridView
            PopulateGridView()

            ' Remove the Update button and enable the Save button
            StudentList.Controls.Remove(UpdateButton)
            Save.Enabled = True
            Save.Text = "Save"
        End If
    End Sub

    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles Delete.Click
        ' Get the selected student index
        Dim selectedIndex As Integer = Student_listing.SelectedRows(0).Index

        ' Remove the selected student from the list
        Learners.RemoveAt(selectedIndex)

        ' Save the updated student data to the file
        If SaveStudentData() Then
            ' Clear the form fields
            ClearFormFields()

            ' Reload the student data from the file
            LoadLearnerData()

            ' Refresh the GridView
            PopulateGridView()

            ' Remove the Delete button
            StudentList.Controls.Remove(Delete)
        End If
    End Sub

    Private Sub RefreshButton_Click(sender As Object, e As EventArgs) Handles RefreshButton.Click
        'TraineeList.Controls.Add(RefreshButton)
        AddHandler RefreshButton.Click, AddressOf RefreshData

    End Sub

    Private Sub RefreshData(sender As Object, e As EventArgs)
        ' Clear the form fields
        ClearFormFields()

        ' Reload the student data from the file
        LoadLearnerData()

        ' Refresh the GridView
        PopulateGridView()

        ' Remove the Refresh button
        'TraineeList.Controls.Remove(RefreshButton)
    End Sub

    Private Sub Trainee_icon_Click(sender As Object, e As EventArgs) Handles Trainee_icon.Click
        Dim mainForm As New Trainers()
        mainForm.Show()
        Me.Hide()
    End Sub

    Private Sub Dashboard_icon_Click(sender As Object, e As EventArgs) Handles Dashboard_icon.Click
        Dim mainForm As New Dashboard()
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
        ' Perform any necessary cleanup or logout operations here
        ' For example, you can clear user data, close connections, or save user preferences

        ' Close the current form
        Me.Close()

        ' Show the login form or the main application form
        Dim loginForm As New Login_page()
        loginForm.Show()
    End Sub


End Class

Public Class Learner
    Public Property Name As String
    Public Property Phone As String
    Public Property Address As String
    Public Property Gender As String
    Public Property Email As String
    Public Property Age As String
    Public Property Course As String

End Class