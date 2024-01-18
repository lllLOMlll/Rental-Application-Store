

Imports System.IO
Imports System.Net.Http


Public Class EditMovie

    Private picturePath As String = String.Empty
    Private selectedItems As New List(Of String)
    Private selectedMovie As Movie

    Private Sub EditMovie_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Adding an instance of the Menu
        Me.Controls.Add(New CommonMenuControl())

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
        TextBox_Title.Text = title
        TextBox_Genre.Text = genre
        DomainUpDown_Release_Year.Text = releaseYear.ToString()
        TextBox_Run_Time.Text = runTime
        TextBox_Original_Language.Text = language
        TextBox_Director.Text = director
        TextBox_Starring.Text = actors
        TextBox_Countries.Text = country
        TextBox_Resume.Text = [resume]
        Select Case status
            Case 0
                ComboBox_Status.SelectedIndex = 0
            Case 1
                ComboBox_Status.SelectedIndex = 1
            Case 2
                ComboBox_Status.SelectedIndex = 2
            Case 3
                ComboBox_Status.SelectedIndex = 3
            Case Else
                ComboBox_Status.SelectedIndex = -1
        End Select
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
            MessageBox.Show("No poster path provided.", "Image Load Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            PictureBox_Poster.Image = Nothing
        End If



        'Display username and access level
        Label_Display_Username.Text = Globals.Username
        Label_Display_Access_Level.Text = Globals.AccessLevel

        ' Format Genre, Language and Country TextBox (ReadOnly and Background = White)
        TextBox_Genre.ReadOnly = True
        TextBox_Genre.BackColor = System.Drawing.Color.White
        TextBox_Original_Language.ReadOnly = True
        TextBox_Original_Language.BackColor = System.Drawing.Color.White
        TextBox_Countries.ReadOnly = True
        TextBox_Countries.BackColor = System.Drawing.Color.White


        ' Populate the DomainUpDown with years
        PopulateYearsDomainUpDown()


    End Sub

    Private Sub PopulateYearsDomainUpDown()
        ' Define the range of years
        Dim startYear As Integer = 2100
        Dim endYear As Integer = 1900

        ' Add years to the DomainUpDown control in descending order
        For year As Integer = startYear To endYear Step -1
            DomainUpDown_Release_Year.Items.Add(year.ToString())
        Next
    End Sub

    ' Add the selected Genre to the TextBox_Genre 
    Private Sub ComboBox_Genre_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_Genre.SelectedIndexChanged
        AddItemFromComboBoxToTextBox(ComboBox_Genre, TextBox_Genre)
    End Sub

    ' Add the selected Language to the TextBox_Genre 
    Private Sub ComboBox_Language_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_Language.SelectedIndexChanged
        AddItemFromComboBoxToTextBox(ComboBox_Language, TextBox_Original_Language)
    End Sub

    ' Add the selected country to the TextBox_Countries
    Private Sub ComboBox_Country_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_Country.SelectedIndexChanged
        AddItemFromComboBoxToTextBox(ComboBox_Country, TextBox_Countries)
    End Sub



    Private Sub DomainUpDown1_SelectedItemChanged(sender As Object, e As EventArgs) Handles DomainUpDown_Release_Year.SelectedItemChanged
        ' Handle the event when a new year is selected
        Dim selectedYear As String = DomainUpDown_Release_Year.Text
    End Sub

    ' This method will be triggered when the upload button is clicked
    Private Sub Button_Upload_Picture_Download_Click(sender As Object, e As EventArgs) Handles Button_Upload_Picture_Download.Click
        Using openFileDialog As New OpenFileDialog()
            openFileDialog.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp"
            If openFileDialog.ShowDialog() = DialogResult.OK Then
                PictureBox_Poster.Image = Image.FromFile(openFileDialog.FileName)
                PictureBox_Poster.SizeMode = PictureBoxSizeMode.StretchImage
                ' Store the path of the selected picture (I need this to store it in the database)
                picturePath = openFileDialog.FileName
            End If
        End Using
    End Sub




    ' EDIT A MOVIE
    Private Sub Button_Edit_Movie_Click(sender As Object, e As EventArgs) Handles Button_Edit_Movie.Click
        ' Retrieve values from form controls
        Dim photo As String = picturePath
        Dim title As String = TextBox_Title.Text
        Dim year As String = DomainUpDown_Release_Year.Text
        Dim country As String = TextBox_Countries.Text
        Dim language As String = TextBox_Original_Language.Text
        Dim lengthStr As String = TextBox_Run_Time.Text
        Dim [resume] As String = TextBox_Resume.Text
        Dim genre As String = TextBox_Genre.Text
        Dim actors As String = TextBox_Starring.Text
        Dim director As String = TextBox_Director.Text

        Dim status As Integer = ComboBox_Status.SelectedIndex

        ' Title validation
        If String.IsNullOrWhiteSpace(title) OrElse title.Length > 100 Then
            MessageBox.Show("Title cannot be empty and must be less than 100 characters.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Genre validation
        If String.IsNullOrWhiteSpace(genre) Then
            MessageBox.Show("Genre cannot be empty.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Year validation
        If IsFieldEmpty("Year", year) Then Return
        If Not Integer.TryParse(year, Nothing) OrElse Integer.Parse(year) < 1890 OrElse Integer.Parse(year) > 2024 Then
            MessageBox.Show("Year must be between 1890 and 2024.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Length validation
        If IsFieldEmpty("Movie Length", lengthStr) Then Return
        Dim length As Integer
        If Not Integer.TryParse(lengthStr, length) OrElse length < 1 OrElse length > 480 Then
            MessageBox.Show("Length must be between 1 and 480.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If


        ' Language validation
        If IsFieldEmpty("Language", language) Then Return
        If String.IsNullOrWhiteSpace(language) Then
            MessageBox.Show("Language cannot be empty.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Director validation
        If IsFieldEmpty("Director", director) Then Return
        If director.Length > 50 Then
            MessageBox.Show("Director name must be less than 50 characters.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Actors validation
        If IsFieldEmpty("Actor", actors) Then Return
        If actors.Length > 1000 Then
            MessageBox.Show("Actors list must be less than 1000 characters.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Country validation
        If IsFieldEmpty("Country", country) Then Return
        If country.Length > 50 Then
            MessageBox.Show("Country name must be less than 50 characters.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Status validation 
        If ComboBox_Status.SelectedIndex = -1 Then
            MessageBox.Show("Status cannot be empty.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Resume validation
        If IsFieldEmpty("Resume", [resume]) Then Return
        If [resume].Length > 10000 Then
            MessageBox.Show("Resume must be less than 10000 characters.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Photo validation
        If String.IsNullOrWhiteSpace(photo) Then
            photo = Globals.MoviePoster
        End If

        If String.IsNullOrWhiteSpace(photo) OrElse Not IsValidImageFile(photo) Then
            MessageBox.Show("Please select a valid image file for the photo.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Add movie to the database
        Dim editedMovie As New Movie()
            editedMovie.VideoId = Globals.MovieId
        editedMovie.Photo = photo
        editedMovie.Title = TextBox_Title.Text
            editedMovie.Year = DomainUpDown_Release_Year.Text
            editedMovie.Country = TextBox_Countries.Text
            editedMovie.Language = TextBox_Original_Language.Text
        editedMovie.Length = Integer.Parse(TextBox_Run_Time.Text)
        editedMovie.Resume = TextBox_Resume.Text
            editedMovie.Genre = TextBox_Genre.Text
            editedMovie.Actors = TextBox_Starring.Text
            editedMovie.Director = TextBox_Director.Text
        editedMovie.Status = CType(ComboBox_Status.SelectedIndex, Movie.MovieStatus)


        ' Update movie in the database
        Try
                Dim dbManager As New DBManagerMovie()
                dbManager.UpdateMovie(editedMovie)

                MsgBox($"{title} has been successfully edited")

            ' Redirect the user to the Dashboard
            ShowSelectedForm(Me, New Dashboard)
        Catch ex As Exception
            MessageBox.Show("An error occurred while adding the movie: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Function to validate if the file path points to a valid image file
    Private Function IsValidImageFile(filePath As String) As Boolean
        Dim validExtensions As String() = {".jpg", ".jpeg", ".png", ".gif"}
        Return validExtensions.Any(Function(ext) filePath.EndsWith(ext, StringComparison.OrdinalIgnoreCase))
    End Function

    'CLEAR BUTTON
    Private Sub Button_Clear_Click(sender As Object, e As EventArgs) Handles Button_Clear.Click
        picturePath = ""
        TextBox_Title.Text = ""
        DomainUpDown_Release_Year.Text = ""
        TextBox_Countries.Text = ""
        TextBox_Original_Language.Text = ""
        TextBox_Run_Time.Text = ""
        TextBox_Resume.Text = ""
        TextBox_Genre.Text = ""
        TextBox_Starring.Text = ""
        TextBox_Director.Text = ""

        'Clear the selected item so the user can choose something in the ComboBox
        selectedItems.Clear()
    End Sub

    'Clear Genre
    Private Sub Button_Clear_Genre_Click(sender As Object, e As EventArgs) Handles Button_Clear_Genre.Click
        TextBox_Genre.Text = ""
        selectedItems.Clear()
    End Sub
    'Clear Language
    Private Sub Button_Clear_Language_Click(sender As Object, e As EventArgs) Handles Button_Clear_Language.Click
        TextBox_Original_Language.Text = ""
        selectedItems.Clear()
    End Sub
    'Clear Country
    Private Sub Button_Clear_Country_Click(sender As Object, e As EventArgs) Handles Button_Clear_Country.Click
        TextBox_Countries.Text = ""
        selectedItems.Clear()
    End Sub

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

    Private Sub Button_Dashboard_Click(sender As Object, e As EventArgs) Handles Button_Dashboard.Click
        ShowSelectedForm(Me, New Dashboard)
    End Sub
End Class