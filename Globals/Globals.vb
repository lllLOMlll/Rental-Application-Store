Module Globals

    'Login User (employee)
    Public IsUserLogged As Boolean = False
    Public Username As String
    Public AccessLevel As String

    'Edit User (employee) Globals
    Public EmployeeNumberEdit As String

    'Movie Globals
    Public MovieId As String
    Public MoviePoster As String
    Public MovieTitle As String

    'Client Globals
    Public ClientNumber As String

    'Parent Form
    'I'm using this to reset MovieId when the user go to the Rent Form from EditMovie, DeleteMovie or ListRentedMovie
    Public parentFormGlobal As Form

    'Style
    Public BackgroundCustomColor As Color = Color.FromArgb(50, 90, 235)
    Public ForeCustomColor As Color = Color.FromArgb(245, 200, 35)


End Module
