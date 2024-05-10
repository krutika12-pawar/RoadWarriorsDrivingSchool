Imports System.Security.Cryptography.Xml

Public Class Login_page
    Private Sub Login_page_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetTextBoxRoundedRegion(Username, 40) ' Radius of 40 pixels
        SetTextBoxRoundedRegion(Password, 40) ' Radius of 40 pixels
        SetButtonRoundedRegion(LoginButton, 60)
    End Sub

    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        ' Get the entered username and password
        Dim enteredUsername As String = Username.Text.Trim()
        Dim enteredPassword As String = Password.Text.Trim()

        ' Check if the username and password are correct
        ' Replace the following with your actual authentication logic
        If enteredUsername = "admin" AndAlso enteredPassword = "password" Then
            ' Login successful
            'MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ' Perform any additional actions after successful login
            ' For example, open the main form or navigate to the next page
            Dim mainForm As New Dashboard()
            mainForm.Show()
            Me.Hide()
        Else
            ' Login failed
            MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ' Clear the username and password fields
            Username.Clear()
            Password.Clear()
        End If
    End Sub
End Class