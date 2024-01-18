

Imports System.IO
Imports System.Net.Http

Public Class RentMovie



    Private picturePath As String = String.Empty
    Private selectedItems As New List(Of String)


    Private Sub RentMovie_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Adding an instance of the Menu
        Me.Controls.Add(New CommonMenuControl())


        ' Reset Movie Id if the user comes from Edit, Delete 
        If TypeOf Globals.parentFormGlobal Is EditMovie Then
            Globals.MovieId = Nothing
        End If
        If TypeOf Globals.parentFormGlobal Is Dashboard Then
            Globals.MovieId = Nothing
        End If


        'Display username and access level
        Label_Display_Username.Text = Globals.Username
        Label_Display_Access_Level.Text = Globals.AccessLevel

        'Instance of my DBManager
        Dim dbManagerMovie As New DBManagerMovie


        ' Create an object of the selected movie
        Dim selectedMovie As Movie = dbManagerMovie.GetMovieById(Globals.MovieId)



        ' Retrive the data from the method 
        Dim title As String = selectedMovie.Title
        Dim genre As String = selectedMovie.Genre
        Dim releaseYear As String = selectedMovie.Year
        Dim runTime As String = selectedMovie.Length
        Dim language As String = selectedMovie.Language
        Dim director As String = selectedMovie.Director
        Dim actors As String = selectedMovie.Actors
        Dim country As String = selectedMovie.Country
        Dim [resume] As String = selectedMovie.Resume
        Dim posterPath As String = selectedMovie.Photo
        Dim status As Integer = selectedMovie.Status


        'Display the data
        TextBox_Movie_ID.Text = Globals.MovieId
        TextBox_Title.Text = title
        TextBox_Genre.Text = genre
        TextBox_Year_Release.Text = releaseYear
        TextBox_Run_Time.Text = runTime
        TextBox_Original_Language.Text = language
        TextBox_Director.Text = director
        TextBox_Starring.Text = actors
        TextBox_Countries.Text = country
        TextBox_Resume.Text = [resume]
        ' Handle Status ComboBox selection
        ComboBox_Status.SelectedIndex = selectedMovie.Status

        ' Load and display the poster image
        If Not String.IsNullOrEmpty(posterPath) Then
            If posterPath.StartsWith("https:") Then
                ' Load image from URL
                LoadImageFromUrlAsync(posterPath, PictureBox_Poster)
            ElseIf IO.File.Exists(posterPath) Then
                ' Load image from file
                Try
                    PictureBox_Poster.Image = Image.FromFile(posterPath)
                    PictureBox_Poster.SizeMode = PictureBoxSizeMode.StretchImage
                Catch ex As Exception
                    MessageBox.Show("Error loading image: " & ex.Message, "Image Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    PictureBox_Poster.Image = Nothing
                End Try
            Else
                MessageBox.Show("Poster path is not valid.", "Image Load Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                PictureBox_Poster.Image = Nothing
            End If
        Else
            ' Handle the case where the poster path is empty
            'MessageBox.Show("No poster path provided.", "Image Load Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            PictureBox_Poster.Image = Nothing
        End If


        ' Display Client data if the Movie ID is not empty
        If Not String.IsNullOrEmpty(Globals.MovieId) Then
            Try
                Dim dbManagerRent As New DbManagerRent
                ' Get the latest rent data for the movie that hasn't been returned yet
                Dim rentData As Rent = dbManagerRent.GetLatestRentByMovieId(Globals.MovieId)

                If rentData IsNot Nothing AndAlso rentData.ReturnDate = Nothing Then
                    ' The movie is currently rented out
                    Dim clientNumber As String = rentData.ClientFk
                    Dim dbManagerClient As New DBManagerClient
                    Dim clientWithRented As Client = dbManagerClient.GetClientByClientNumber(clientNumber)

                    If clientWithRented IsNot Nothing Then
                        ' Display client details
                        DisplayClientDetails(clientWithRented)

                        'Disable the MovieID and ClientNumber Combo box so user cannot mismatch rented movie and client
                        ComboBox_Movies_Id.Enabled = False
                        ComboBox_Client_Number.Enabled = False

                    Else
                        MsgBox("Client data not found.", MsgBoxStyle.Information, "Client not found")
                    End If
                Else
                    ' The movie is not currently rented out
                    'MsgBox("This movie is not currently rented out.", MsgBoxStyle.Information, "Available")
                End If
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End If



        ' Format Genre, Language and Country TextBox (ReadOnly and Background = White)
        TextBox_Genre.ReadOnly = True
        TextBox_Genre.BackColor = System.Drawing.Color.White
        TextBox_Original_Language.ReadOnly = True
        TextBox_Original_Language.BackColor = System.Drawing.Color.White
        TextBox_Countries.ReadOnly = True
        TextBox_Countries.BackColor = System.Drawing.Color.White
        TextBox_Title.BackColor = System.Drawing.Color.White
        TextBox_Year_Release.BackColor = System.Drawing.Color.White
        TextBox_Run_Time.BackColor = System.Drawing.Color.White
        TextBox_Director.BackColor = System.Drawing.Color.White
        TextBox_Starring.BackColor = System.Drawing.Color.White
        TextBox_Resume.BackColor = System.Drawing.Color.White

        'Handlers to manage ComboBox Movie Id and Client's number
        AddHandler ComboBox_Client_Number.SelectedIndexChanged, AddressOf ComboBox_Client_Number_SelectedIndexChanged
        AddHandler ComboBox_Movies_Id.SelectedIndexChanged, AddressOf ComboBox_Movies_Id_SelectedIndexChanged

        'Display all movies Id and client numbers
        PopulateMovieIdsComboBox()
        PopulateClientNumbersComboBox()

        'Format Status ComboBox (set to nothing if there is no value)
        ' I CANNOT TAKE selectedMovie.Status BECAUSE IF THERE IS NO MOVIE, IT RETURN 0 AND 0 IS "Rented"
        If String.IsNullOrEmpty(Globals.MovieId) Then
            ComboBox_Status.SelectedIndex = -1
        End If

        'Format Length 
        TextBox_Run_Time.Text = ""
    End Sub

    Private Sub PopulateClientNumbersComboBox()
        Dim dbManagerClient As New DBManagerClient()
        Dim clientsData As DataTable = dbManagerClient.GetAllClientNumberAndFirstNames()

        ComboBox_Client_Number.Items.Clear()
        For Each row As DataRow In clientsData.Rows
            Dim clientNumber As String = row("client_number").ToString()
            Dim firstName As String = row("fname").ToString()
            ComboBox_Client_Number.Items.Add(clientNumber & " - " & firstName)
        Next
    End Sub




    Private Sub ComboBox_Movies_Id_SelectedIndexChanged(sender As Object, e As EventArgs)
        If ComboBox_Movies_Id.SelectedItem Is Nothing Then
            Return
        End If

        ' Split the selected item to get the movie ID
        Dim selectedItem As String = ComboBox_Movies_Id.SelectedItem.ToString()
        Dim splitItems As String() = selectedItem.Split(New Char() {"-"c}, StringSplitOptions.RemoveEmptyEntries)
        Dim selectedMovieIdAsString As String = splitItems(0).Trim()

        Dim selectedMovieId As Long
        If Long.TryParse(selectedMovieIdAsString, selectedMovieId) Then
            ' Retrieve movie details
            Dim dbManager As New DBManagerMovie()
            Dim movie As Movie = dbManager.GetMovieById(selectedMovieId)

            ' Display movie details
            DisplayMovieDetails(movie)

            Try
                Dim dbManagerRent As New DbManagerRent
                ' Get the latest rent data for the movie that hasn't been returned yet
                Dim rentData As Rent = dbManagerRent.GetLatestRentByMovieId(selectedMovieId)

                If rentData IsNot Nothing AndAlso rentData.ReturnDate = Nothing Then
                    ' The movie is currently rented out
                    Dim clientNumber As String = rentData.ClientFk
                    Dim dbManagerClient As New DBManagerClient
                    Dim clientWithRented As Client = dbManagerClient.GetClientByClientNumber(clientNumber)

                    If clientWithRented IsNot Nothing Then
                        ' Display client details
                        DisplayClientDetails(clientWithRented)

                        'Disable the MovieID and ClientNumber Combo box so user cannot mismatch rented movie and client
                        ComboBox_Movies_Id.Enabled = False
                        ComboBox_Client_Number.Enabled = False
                    Else
                        MsgBox("Client data not found.", MsgBoxStyle.Information, "Client not found")
                    End If
                Else
                    ' The movie is not currently rented out
                    ' Re-enable the ComboBoxes
                    ComboBox_Movies_Id.Enabled = True
                    ComboBox_Client_Number.Enabled = True
                End If
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End If
    End Sub




    Private Sub ComboBox_Client_Number_SelectedIndexChanged(sender As Object, e As EventArgs)
        If ComboBox_Client_Number.SelectedItem Is Nothing Then
            Return
        End If

        ' Split the selected item to get the client number
        Dim selectedItem As String = ComboBox_Client_Number.SelectedItem.ToString()
        Dim splitItems As String() = selectedItem.Split(New Char() {"-"c}, StringSplitOptions.RemoveEmptyEntries)
        Dim selectedClientNumber As String = splitItems(0).Trim()

        If Not String.IsNullOrWhiteSpace(selectedClientNumber) Then
            ' Retrieve client details
            Dim dbManagerClient As New DBManagerClient()
            Dim client As Client = dbManagerClient.GetClientByClientNumber(selectedClientNumber)
            DisplayClientDetails(client)

            Try
                Dim dbManagerRent As New DbManagerRent
                Dim rentData As Rent = dbManagerRent.GetLatestRentByClientNumber(selectedClientNumber)

                If rentData IsNot Nothing Then
                    'MessageBox.Show("Rent Data Found. Movie ID: " & rentData.VideoFk.ToString() & ", Return Date: " & rentData.ReturnDate.ToString()) ' Debugging line
                    Dim movieId As Long = rentData.VideoFk
                    Dim dbManagerMovie As New DBManagerMovie
                    Dim movieWithRented As Movie = dbManagerMovie.GetMovieById(movieId)
                    DisplayMovieDetails(movieWithRented)
                    ComboBox_Movies_Id.Enabled = False
                    ComboBox_Client_Number.Enabled = False
                    If IsDBNull(rentData.ReturnDate) Then
                    Else
                        'MsgBox("Client has no current rental.", MsgBoxStyle.Information, "No Rental")
                        ' Re-enable the ComboBoxes
                    End If
                Else
                    'MsgBox("No Rent Data Found.", MsgBoxStyle.Information, "No Rental Data")
                End If
            Catch ex As Exception
                'MessageBox.Show("Error: " & ex.Message)
            End Try

        End If
    End Sub


    Private Sub DisplayClientDetails(client As Client)
        If client IsNot Nothing Then
            TextBox_First_Name.Text = client.FirstName
            TextBox_Last_Name.Text = client.LastName
            TextBox_DOB.Text = client.DateOfBirth.ToString("yyyy-MM-dd") ' Format date as needed
            TextBox_Address.Text = client.Address
            TextBox_City.Text = client.City
            TextBox_Phone.Text = client.Phone
            TextBox_Client_Number.Text = client.ClientNumber
        End If
    End Sub


    Private Sub DisplayMovieDetails(movie As Movie)
        If movie IsNot Nothing Then
            TextBox_Movie_ID.Text = movie.VideoId.ToString()
            TextBox_Title.Text = movie.Title
            TextBox_Genre.Text = movie.Genre
            TextBox_Year_Release.Text = movie.Year
            TextBox_Run_Time.Text = movie.Length.ToString()
            TextBox_Original_Language.Text = movie.Language
            TextBox_Director.Text = movie.Director
            TextBox_Starring.Text = movie.Actors
            TextBox_Countries.Text = movie.Country
            TextBox_Resume.Text = movie.Resume

            ' Handle Status ComboBox selection
            ComboBox_Status.SelectedIndex = movie.Status

            ' Load and display the poster image
            If Not String.IsNullOrEmpty(movie.Photo) Then
                If movie.Photo.StartsWith("https:") Then
                    LoadImageFromUrlAsync(movie.Photo, PictureBox_Poster)
                ElseIf IO.File.Exists(movie.Photo) Then
                    PictureBox_Poster.Image = Image.FromFile(movie.Photo)
                    PictureBox_Poster.SizeMode = PictureBoxSizeMode.StretchImage
                Else
                    PictureBox_Poster.Image = Nothing
                End If
            Else
                PictureBox_Poster.Image = Nothing
            End If
        End If
    End Sub


    ' Function to validate if the file path points to a valid image file
    Private Function IsValidImageFile(filePath As String) As Boolean
        Dim validExtensions As String() = {".jpg", ".jpeg", ".png", ".gif"}
        Return validExtensions.Any(Function(ext) filePath.EndsWith(ext, StringComparison.OrdinalIgnoreCase))
    End Function



    Public Sub AddItemFromComboBoxToTextBox(comboBoxName As ComboBox, textBoxName As TextBox)
        ' Verify that the item is not already added
        If comboBoxName.SelectedIndex <> -1 Then
            Dim selectedItem As String = comboBoxName.SelectedItem.ToString()

            ' Check if the item is already selected
            If Not selectedItems.Contains(selectedItem) Then
                ' Append the selected item to the TextBox
                If Not String.IsNullOrWhiteSpace(textBoxName.Text) Then
                    textBoxName.Text &= ", "
                End If
                textBoxName.Text &= selectedItem

                ' Add the selected item to the list
                selectedItems.Add(selectedItem)
            Else
                MsgBox("You've already added that item", MsgBoxStyle.Exclamation, "Input Error")
            End If

            ' Reset the ComboBox
            comboBoxName.SelectedIndex = -1
        End If
    End Sub

    'Function to validate empty field
    Private Function IsFieldEmpty(fieldName As String, fieldValue As String) As Boolean
        If String.IsNullOrWhiteSpace(fieldValue) Then
            MsgBox(fieldName & " cannot be empty", MsgBoxStyle.Critical, "Input Error")
            Return True
        End If
        Return False
    End Function

    Public Async Sub LoadImageFromUrlAsync(url As String, pb As PictureBox)
        Using httpClient As New HttpClient()
            Try
                Dim response As HttpResponseMessage = Await httpClient.GetAsync(url)
                If response.IsSuccessStatusCode Then
                    Using stream As Stream = Await response.Content.ReadAsStreamAsync()
                        Dim img As Image = Image.FromStream(stream)
                        pb.SizeMode = PictureBoxSizeMode.StretchImage
                        pb.Image = img
                    End Using
                End If
            Catch ex As Exception
                MessageBox.Show("Error loading image from URL: " & ex.Message, "Image Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub


    Private Sub PopulateMovieIdsComboBox()
        Dim dbManager As New DBManagerMovie()
        Dim moviesData As DataTable = dbManager.GetAllMovieIdsAndTitles()

        ComboBox_Movies_Id.Items.Clear()
        For Each row As DataRow In moviesData.Rows
            Dim movieId As Long = Convert.ToInt64(row("video_id"))
            Dim title As String = row("title").ToString()
            ComboBox_Movies_Id.Items.Add(movieId.ToString() & " - " & title)
        Next
    End Sub


    Private Sub Button_Rent_Movie_Click(sender As Object, e As EventArgs) Handles Button_Rent_Movie.Click
        Dim movieId As Long
        Dim clientId As Long

        If Long.TryParse(TextBox_Movie_ID.Text, movieId) AndAlso Long.TryParse(TextBox_Client_Number.Text, clientId) Then
            Dim dbManagerMovie As New DBManagerMovie()
            Dim dbManagerRent As New DbManagerRent()
            Dim dbManagerClient As New DBManagerClient()

            ' Check the status of the client
            Dim client As Client = dbManagerClient.GetClientByClientNumber(clientId.ToString())
            If client IsNot Nothing AndAlso (client.Status = Client.ClientStatus.Inactive OrElse client.Status = Client.ClientStatus.Deleted) Then
                MessageBox.Show("Client is not active or has been deleted. Cannot rent movie.", "Operation Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' Check if the movie is available for rent
            Dim movie As Movie = dbManagerMovie.GetMovieById(movieId)
            If movie IsNot Nothing Then
                If movie.Status = 1 Then ' Movie is available
                    ' Rent the movie
                    dbManagerRent.AddRent(clientId, movieId, DateTime.Now)
                    ' Update movie status to rented
                    dbManagerMovie.UpdateMovieStatus(movieId, 0)
                    MessageBox.Show("Movie rented successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    'Clear the boxes
                    clearAllFields()
                ElseIf movie.Status = 0 Then ' Movie is already rented
                    ' Return the movie
                    dbManagerRent.UpdateRentReturn(movieId)
                    dbManagerMovie.UpdateMovieStatus(movieId, 1)
                    MessageBox.Show("Movie returned successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    'Clear all the field
                    clearAllFields()
                Else
                    MessageBox.Show("This movie is not available for rent or return.", "Unavailable", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Else
                MessageBox.Show("Movie not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Invalid movie or client ID.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub




    Private Sub Button_Clear_Click(sender As Object, e As EventArgs) Handles Button_Clear.Click
        clearAllFields()
    End Sub

    Private Sub clearAllFields()
        'Movie
        TextBox_Movie_ID.Text = ""
        TextBox_Title.Text = ""
        TextBox_Genre.Text = ""
        TextBox_Year_Release.Text = ""
        TextBox_Run_Time.Text = ""
        TextBox_Original_Language.Text = ""
        TextBox_Director.Text = ""
        TextBox_Starring.Text = ""
        TextBox_Countries.Text = ""
        TextBox_Resume.Text = ""
        ComboBox_Movies_Id.SelectedIndex = -1
        PictureBox_Poster.Image = Nothing

        Globals.MovieId = Nothing
        If String.IsNullOrEmpty(Globals.MovieId) Then
            ComboBox_Status.SelectedIndex = -1
        End If

        'Client
        TextBox_First_Name.Text = ""
        TextBox_Last_Name.Text = ""
        TextBox_DOB.Text = ""
        TextBox_Address.Text = ""
        TextBox_City.Text = ""
        TextBox_Phone.Text = ""
        TextBox_Client_Number.Text = ""
        ComboBox_Client_Number.SelectedIndex = -1

        'Combo box MovieId and ClientNumber Enabled
        ComboBox_Movies_Id.Enabled = True
        ComboBox_Client_Number.Enabled = True
    End Sub

    Private Sub ComboBox_Status_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_Status.SelectedIndexChanged
        If ComboBox_Status.SelectedIndex = 0 Then
            Button_Rent_Movie.Text = "RETURN"
        ElseIf ComboBox_Status.SelectedIndex = 1 Then
            Button_Rent_Movie.Text = "RENT"
        ElseIf ComboBox_Status.SelectedIndex = 2 Then
            Button_Rent_Movie.Text = "Movie Removed"
        ElseIf ComboBox_Status.SelectedIndex = 3 Then
            Button_Rent_Movie.Text = "Movie lost"
        ElseIf ComboBox_Status.SelectedIndex = -1 Then
            Button_Rent_Movie.Text = "RENT/RETURN"
        End If
    End Sub

    Private Sub Button_Dashboard_Click(sender As Object, e As EventArgs) Handles Button_Dashboard.Click
        ShowSelectedForm(Me, New Dashboard)
    End Sub


End Class