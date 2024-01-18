Public Class MainLogin

    '*********************** ERASE THIS WHEN I DONT NEED IT ANYMORE *************************************
    'To the Dasboard


    'LOGIN
    Private Sub Button_Login_Click(sender As Object, e As EventArgs) Handles Button_Login.Click
        Dim usernameInput As String = TextBox_Username.Text
        Dim passwordInput As String = TextBox_Password.Text
        Dim dbManager As New DbManagerEmployee()

        ' Hash the input password
        Dim hashedPasswordInput As String = dbManager.HashPassword(passwordInput)

        ' Check the login credentials
        Dim loginResult = dbManager.CheckLogin(usernameInput, hashedPasswordInput)
        Dim isValid As Boolean = loginResult.isValid
        Dim status As String = loginResult.status
        Dim level As String = loginResult.level

        If isValid Then
            ' User is active, set global variables
            Globals.IsUserLogged = True
            Globals.Username = usernameInput
            Globals.AccessLevel = level

            ' Clear the Textbox
            TextBox_Username.Text = ""
            TextBox_Password.Text = ""

            ' Check if the user is active or inactive
            If status = "Inactive" Then
                MsgBox($"You account is inactive. You need to change your password", MsgBoxStyle.Information, "Account Inactive")

                'Direct the user the to change password Form
                FormUtilities.ShowSelectedForm(Me, New ChangePassword)
            ElseIf status = "Deleted" Then
                MsgBox($"You account was deleted! Please contact an admin!", MsgBoxStyle.Critical, "Account Deleted")
                TextBox_Username.Text = ""
                TextBox_Password.Text = ""
            ElseIf status = "Active" Then
                FormUtilities.ShowSelectedForm(Me, New Dashboard)
            Else
                MsgBox($"Something is wrong with your status! Please contact an admin!", MsgBoxStyle.Critical, "Accout Status unspecified")
            End If
        Else
            MsgBox("Invalid username or password", MsgBoxStyle.Exclamation, "Login Failed")
        End If
    End Sub


End Class
