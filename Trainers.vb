Imports System.IO
Imports System.Text.RegularExpressions

Public Class Trainers
    Private trainees As New List(Of Trainee)

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load the saved trainee data from the file
        LoadTraineeData()

        ' Populate the GridView with the trainee data
        PopulateGridView()
    End Sub

    Public Sub LoadTraineeData()
        ' Load the trainee data from the file
        trainees = LoadTraineeDataFromFile()
    End Sub

    Public Sub PopulateGridView()
        ' Bind the trainee data to the GridView
        Trainee_listing.DataSource = trainees
        Trainee_listing.Columns("Name").HeaderText = "Trainee Name"
        Trainee_listing.Columns("Phone").HeaderText = "Phone Number"
        Trainee_listing.Columns("Address").HeaderText = "Address"
        Trainee_listing.Columns("Gender").HeaderText = "Gender"
        Trainee_listing.Columns("Email").HeaderText = "Email Id"
    End Sub

    Private Sub TraineeName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TraineeName.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TraineePhone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TraineePhone.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Save_Click(sender As Object, e As EventArgs) Handles Save.Click

        If String.IsNullOrWhiteSpace(TraineeName.Text) Then
            MessageBox.Show("Please enter the instructor name.")
            TraineeName.Focus()
            Return
        End If

        ' Validate the phone field
        If String.IsNullOrWhiteSpace(TraineePhone.Text) Then
            MessageBox.Show("Please enter the instructor phone number.")
            TraineePhone.Focus()
            Return
        End If

        ' Validate the address field
        If String.IsNullOrWhiteSpace(TraineeAddress.Text) Then
            MessageBox.Show("Please enter the instructor address.")
            TraineeAddress.Focus()
            Return
        End If

        ' Validate the gender field
        If String.IsNullOrWhiteSpace(TraineeGender.Text) Then
            MessageBox.Show("Please select the instructor gender.")
            TraineeGender.Focus()
            Return
        End If

        ' Validate the email field
        If String.IsNullOrWhiteSpace(TraineeEmail.Text) Then
            MessageBox.Show("Please enter the instructor email.")
            TraineeEmail.Focus()
            Return
        End If

        ' Validate the email ID
        If Not IsValidEmail(TraineeEmail.Text) Then
            MessageBox.Show("Please enter a valid email ID.")
            Return
        End If

        ' Retrieve the values from the form controls
        Dim trainee As New Trainee With {
        .Name = TraineeName.Text,
        .Phone = TraineePhone.Text,
        .Address = TraineeAddress.Text,
        .Gender = TraineeGender.Text,
        .Email = TraineeEmail.Text
    }

        ' Save the trainee data to the list
        trainees.Add(trainee)

        ' Save the values to a file, database, or other storage mechanism
        If SaveTraineeData() Then
            ' Clear the form fields
            ClearFormFields()

            ' Reload the trainee data from the file
            LoadTraineeData()

            ' Refresh the GridView
            PopulateGridView()
        End If
    End Sub


    Public Function IsValidEmail(ByVal email As String) As Boolean
        Dim pattern As String = "^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$"
        Dim regex As New Regex(pattern)
        Return regex.IsMatch(email)
    End Function

    Private Function SaveTraineeData() As Boolean
        ' Example: Save the trainee data to a text file
        Dim filePath As String = FilePathManager.TraineeDataFilePath
        Dim traineeData As String = String.Join(Environment.NewLine, trainees.Select(Function(t) $"Name: {t.Name}, Phone: {t.Phone}, Address: {t.Address}, Gender: {t.Gender}, Email: {t.Email}"))

        Try
            Using writer As New StreamWriter(filePath)
                writer.Write(traineeData)
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show($"Error saving trainee data: {ex.Message}")
            Return False
        End Try
    End Function

    Public Function LoadTraineeDataFromFile() As List(Of Trainee)
        Dim trainees As New List(Of Trainee)

        ' Load the trainee data from the file
        Dim filePath As String = FilePathManager.TraineeDataFilePath

        If File.Exists(filePath) Then
            Try
                Using reader As New StreamReader(filePath)
                    While Not reader.EndOfStream
                        ' Read each line and split it into individual trainee data
                        Dim line As String = reader.ReadLine()
                        Dim traineeData As String() = line.Split(New String() {", "}, StringSplitOptions.RemoveEmptyEntries)

                        ' Check if the trainee data has the expected number of elements
                        If traineeData.Length = 5 Then
                            ' Create a new Trainee object and add it to the list
                            Dim trainee As New Trainee With {
                                .Name = traineeData(0).Split(":"c)(1).Trim(),
                                .Phone = traineeData(1).Split(":"c)(1).Trim(),
                                .Address = traineeData(2).Split(":"c)(1).Trim(),
                                .Gender = traineeData(3).Split(":"c)(1).Trim(),
                                .Email = traineeData(4).Split(":"c)(1).Trim()
                            }
                            trainees.Add(trainee)
                        Else
                            ' Handle the case where the line does not have the expected number of elements
                            MessageBox.Show($"Invalid trainee data format: {line}")
                        End If
                    End While
                End Using
            Catch ex As Exception
                MessageBox.Show($"Error loading trainee data: {ex.Message}")
            End Try
        Else
            MessageBox.Show("Trainee data file not found.")
        End If

        Return trainees
    End Function

    Private Sub ClearFormFields()
        ' Clear the form fields
        TraineeName.Text = ""
        TraineePhone.Text = ""
        TraineeAddress.Text = ""
        TraineeGender.Text = ""
        TraineeEmail.Text = ""
    End Sub

    Private UpdateButton As Button
    Private Sub Edit_Click(sender As Object, e As EventArgs) Handles Edit.Click
        ' Check if a row is selected in the DataGridView
        If Trainee_listing.SelectedRows.Count > 0 Then
            ' Get the selected trainee data
            Dim selectedTrainee As Trainee = CType(Trainee_listing.SelectedRows(0).DataBoundItem, Trainee)

            ' Populate the form fields with the selected trainee data
            TraineeName.Text = selectedTrainee.Name
            TraineePhone.Text = selectedTrainee.Phone
            TraineeAddress.Text = selectedTrainee.Address
            TraineeGender.Text = selectedTrainee.Gender
            TraineeEmail.Text = selectedTrainee.Email

            ' Disable the Save button and enable the Update button
            ' Change the button text to "Update"
            Save.Text = "Update"
            UpdateButton = New Button
            UpdateButton.Text = "Update"
            TraineeList.Controls.Add(UpdateButton)
            AddHandler UpdateButton.Click, AddressOf UpdateTrainee
        End If
    End Sub

    Private Sub UpdateTrainee(sender As Object, e As EventArgs)
        ' Validate the email ID
        If Not IsValidEmail(TraineeEmail.Text) Then
            MessageBox.Show("Please enter a valid email ID.")
            Return
        End If

        ' Retrieve the values from the form controls
        Dim updatedTrainee As New Trainee With {
            .Name = TraineeName.Text,
            .Phone = TraineePhone.Text,
            .Address = TraineeAddress.Text,
            .Gender = TraineeGender.Text,
            .Email = TraineeEmail.Text
        }


        Dim selectedRow As DataGridViewRow = Trainee_listing.SelectedRows(0)
        selectedRow.Cells("Name").Value = TraineeName.Text
        selectedRow.Cells("Phone").Value = TraineePhone.Text
        selectedRow.Cells("Address").Value = TraineeAddress.Text
        selectedRow.Cells("Gender").Value = TraineeGender.Text
        selectedRow.Cells("Email").Value = TraineeEmail.Text

        ' Save the updated trainee data to the file
        If SaveTraineeData() Then
            ' Clear the form fields
            ClearFormFields()

            ' Reload the trainee data from the file
            LoadTraineeData()

            ' Refresh the GridView
            PopulateGridView()

            ' Remove the Update button and enable the Save button
            TraineeList.Controls.Remove(UpdateButton)
            Save.Enabled = True
            Save.Text = "Save"
        End If
    End Sub

    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles Delete.Click
        ' Get the selected trainee index
        Dim selectedIndex As Integer = Trainee_listing.SelectedRows(0).Index

        ' Remove the selected trainee from the list
        trainees.RemoveAt(selectedIndex)

        ' Save the updated trainee data to the file
        If SaveTraineeData() Then
            ' Clear the form fields
            ClearFormFields()

            ' Reload the trainee data from the file
            LoadTraineeData()

            ' Refresh the GridView
            PopulateGridView()

            ' Remove the Delete button
            TraineeList.Controls.Remove(Delete)
        End If
    End Sub

    Private Sub RefreshButton_Click(sender As Object, e As EventArgs) Handles RefreshButton.Click
        'TraineeList.Controls.Add(RefreshButton)
        AddHandler RefreshButton.Click, AddressOf RefreshData

    End Sub

    Private Sub RefreshData(sender As Object, e As EventArgs)
        ' Clear the form fields
        ClearFormFields()

        ' Reload the trainee data from the file
        LoadTraineeData()

        ' Refresh the GridView
        PopulateGridView()

        ' Remove the Refresh button
        'TraineeList.Controls.Remove(RefreshButton)
    End Sub

    Private Sub Learners_icon_Click(sender As Object, e As EventArgs) Handles Learners_icon.Click
        Dim mainForm As New Students()
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

Public Class Trainee
    Public Property Name As String
    Public Property Phone As String
    Public Property Address As String
    Public Property Gender As String
    Public Property Email As String
End Class