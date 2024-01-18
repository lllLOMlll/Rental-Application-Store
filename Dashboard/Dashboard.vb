Public Class Dashboard
    Private Sub Dashbord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Adding an instance of the Menu
        Me.Controls.Add(New CommonMenuControl())

        'Colors
        Me.BackColor = Globals.BackgroundCustomColor

        ' Display username
        Label_Username.Text = Globals.Username

        ' Test connection
        'Uncomment if I want to test the connection
        'Dim DbManagerEmployeeInstance As New DbManagerEmployee
        'DbManagerEmployeeInstance.TestConnection()
    End Sub
End Class