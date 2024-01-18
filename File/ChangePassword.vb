Public Class ChangePassword

    Private Sub ChangePassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim username = Globals.Username
        Label_Username.Text = username
    End Sub

    Private Sub Button_Change_Password_Click(sender As Object, e As EventArgs) Handles Button_Change_Password.Click
        ' Retrieve the password values from the form
        Dim oldPassword As String = TextBox_Old_Password.Text
        Dim newPassword As String = TextBox_New_Password.Text
        Dim confirmPassword As String = TextBox_Confirm_Password.Text


        ' Check if the new password and confirm password match
        If newPassword <> confirmPassword Then
            MsgBox("The new passwords do not match.", MsgBoxStyle.Exclamation, "Password Error")
            Return
        End If


        ' Create an instance of the DbManagerEmployee to interact with the database
        Dim dbManager As New DbManagerEmployee()

        ' Hash the old password input by the user
        Dim hashedOldPassword As String = dbManager.HashPassword(oldPassword)

        ' Check if the new password is the same as old password
        If dbManager.HashPassword(oldPassword) = dbManager.HashPassword(newPassword) Then
            MsgBox("The new password must be different than the old password", MsgBoxStyle.Exclamation, "Password Error")
            Return
        End If

        ' Check the login credentials
        Dim loginResult = dbManager.CheckLogin(Globals.Username, hashedOldPassword)
        Dim isValid As Boolean = loginResult.isValid

        If Not isValid Then
            ' Handle the incorrect old password case
            MessageBox.Show("The old password is incorrect.", "Password Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If


        ' If the old password is correct, hash the new password
        Dim hashedNewPassword As String = dbManager.HashPassword(newPassword)

        ' Update the password in the database
        If dbManager.ChangePassword(Globals.Username, hashedNewPassword) Then
            MsgBox("Password changed successfully.", MsgBoxStyle.Exclamation, "Password Changed")


            ' Change the status to active (if not already)
            If dbManager.SetUserStatusActive(Globals.Username) Then
                MsgBox("User status updated to Active.", MsgBoxStyle.Information, "Status Updated")
            End If

            'Clear the TextBox
            TextBox_Old_Password.Text = ""
            TextBox_New_Password.Text = ""
            TextBox_Confirm_Password.Text = ""

            'Redirect the user to the Login Screen
            FormUtilities.ShowSelectedForm(Me, MainLogin)
        Else
            MsgBox("Failed to change the password.", MsgBoxStyle.Information, "Password Error")
        End If
    End Sub


End Class