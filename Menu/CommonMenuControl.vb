Public Class CommonMenuControl

    '*********************************** FILE ***********************************
    'Change Password
    Private Sub ChangePasswordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangePasswordToolStripMenuItem.Click
        'If I want to hide the form, the program needs to know what is the parent form
        'The "FindForm()" method do just that
        Dim parentForm As Form = Me.FindForm()

        If parentForm IsNot Nothing Then
            ' Hide the parent form (Dashbord.vb in this case).
            parentForm.Hide()

            ' Create and show the login screen.
            ChangePassword.Show()
        End If
    End Sub

    ' Exit
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        MsgBox("Thanks for using Video Store Application, a Major Software product", MsgBoxStyle.Information, "Exit")
        Application.Exit()
    End Sub

    ' Logout
    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        ' Reset the Globals variables
        Globals.Username = ""
        Globals.IsUserLogged = False
        Globals.AccessLevel = ""

        MsgBox("You've been logged out. See you soon!", MsgBoxStyle.Information, "Logout")

        ' Redirect the user to the Login Screen
        ShowSelectedForm(New MainLogin)


    End Sub


    '*********************************** EMPLOYE ***********************************
    'Create a new employee
    Private Sub CreateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreateToolStripMenuItem.Click
        ShowSelectedForm(New CreateEmployee)
    End Sub

    'List of employees
    Private Sub ListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListToolStripMenuItem.Click
        ShowSelectedForm(New ListEmployees)
    End Sub

    'Edit employee
    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click
        If Globals.AccessLevel = "Low" Then
            MsgBox("Employee with 'Low' access level cannot Edit", MsgBoxStyle.Exclamation, "Access Level")
            Return
        Else
            ShowSelectedForm(New EditListEmployees)
        End If

    End Sub

    'Delete employee
    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        If Globals.AccessLevel = "Low" OrElse Globals.AccessLevel = "Medium" Then
            MsgBox("Employee with 'Low' or 'Medium' access level cannot Delete", MsgBoxStyle.Exclamation, "Access Level")
            Return
        Else
            ShowSelectedForm(New DeleteEmployee)
        End If
    End Sub


    '*********************************** MOVIE ***********************************
    'List of movies
    Private Sub ListToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ListToolStripMenuItem1.Click
        ShowSelectedForm(New ListMovies)
    End Sub

    'Add a movie
    Private Sub CreateToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CreateToolStripMenuItem1.Click
        ShowSelectedForm(New AddMovie)
    End Sub

    'Edit a movie
    Private Sub EditToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem1.Click
        If Globals.AccessLevel = "Low" Then
            MsgBox("Employee with 'Low' access level cannot Edit", MsgBoxStyle.Exclamation, "Access Level")
            Return
        Else
            ShowSelectedForm(New EditListMovies)
        End If
    End Sub

    'Delete movie
    Private Sub DeleteToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem1.Click
        If Globals.AccessLevel = "Low" OrElse Globals.AccessLevel = "Medium" Then
            MsgBox("Employee with 'Low' or 'Medium' access level cannot Delete", MsgBoxStyle.Exclamation, "Access Level")
            Return
        Else
            ShowSelectedForm(New DeleteListMovies)
        End If
    End Sub

    '*********************************** CLIENT ***********************************
    'List clients
    Private Sub ListToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ListToolStripMenuItem2.Click
        ShowSelectedForm(New ListClients)
    End Sub

    'Add client
    Private Sub CreateToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles CreateToolStripMenuItem2.Click
        ShowSelectedForm(New AddClient)
    End Sub

    'Edit client
    Private Sub EditToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem2.Click
        If Globals.AccessLevel = "Low" Then
            MsgBox("Employee with 'Low' access level cannot Edit", MsgBoxStyle.Exclamation, "Access Level")
            Return
        Else
            ShowSelectedForm(New EditListClients)
        End If
    End Sub

    'Delete
    Private Sub DeleteToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem2.Click
        If Globals.AccessLevel = "Low" OrElse Globals.AccessLevel = "Medium" Then
            MsgBox("Employee with 'Low' or 'Medium' access level cannot Delete", MsgBoxStyle.Exclamation, "Access Level")
            Return
        Else
            ShowSelectedForm(New DeleteListClients)
        End If
    End Sub

    '*********************************** SEARCH ***********************************
    'Quick Search
    Private Sub QuickToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuickToolStripMenuItem.Click
        ShowSelectedForm(New QuickSearch)
    End Sub

    'Advance Search
    Private Sub AdvanceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdvanceToolStripMenuItem.Click
        ShowSelectedForm(New AdvanceSearch)
    End Sub

    '*********************************** RENT ***********************************
    'Rent a movie
    Private Sub RendVideoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RendVideoToolStripMenuItem.Click
        ShowSelectedForm(New RentMovie)
    End Sub

    'List of rented movies
    Private Sub ListOfRentedVideoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListOfRentedVideoToolStripMenuItem.Click
        ShowSelectedForm(New ListRentedMovies)
    End Sub

    '*********************************** SUBS ***********************************
    Private Sub ShowSelectedForm(formName As Form)
        Dim parentForm As Form = Me.FindForm()

        If parentForm IsNot Nothing Then

            Globals.parentFormGlobal = parentForm
            parentForm.Hide()

            ' Show the specified form.
            formName.Show()
        End If
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub
End Class
