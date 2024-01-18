Public Class AdvanceSearch
    Private selectedItems As New List(Of String)
    Private Sub AdvanceSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Controls.Add(New CommonMenuControl())

        'Display username and access level
        Label_Display_Username.Text = Globals.Username
        Label_Display_Access_Level.Text = Globals.AccessLevel

        ' Set AutoGenerateColumns to True to automatically create columns
        DataGridView_Advance_Search.AutoGenerateColumns = True
    End Sub

    Private Sub Button_Advance_Search_Click(sender As Object, e As EventArgs) Handles Button_Quick_Search.Click
        ' Create an instance of your DBManagerMovie
        Dim dbManager As New DBManagerMovie()

        ' Retrieve the values from your input controls
        Dim title As String = TextBox_Title.Text
        Dim movieId As String = TextBox_Movie_ID.Text
        Dim genre As String = TextBox_Genre.Text
        Dim director As String = TextBox_Director.Text
        Dim releaseYear As String = TextBox_Release_Year.Text
        Dim runTime As String = TextBox_Run_Time.Text
        Dim starring As String = TextBox_Starring.Text
        Dim originalLanguage As String = TextBox_Original_Language.Text
        Dim countries As String = TextBox_Countries.Text
        Dim resumeText As String = TextBox_Resume.Text

        ' Call the AdvancedSearch method
        Dim searchResults As DataTable = dbManager.AdvancedSearch(title, movieId, genre, director, releaseYear, runTime, starring, originalLanguage, countries, resumeText)

        ' Check if the search results are empty
        If searchResults.Rows.Count = 0 Then
            MsgBox("No movie matches your description", MsgBoxStyle.Information, "Search Result")
        Else
            ' Bind the search results to the DataGridView
            DataGridView_Advance_Search.DataSource = searchResults
        End If

        'Column "photo" Not Visible
        If searchResults IsNot Nothing AndAlso searchResults.Rows.Count > 0 Then
            ' Display the search results in DataGridView_Quick_Search
            DataGridView_Advance_Search.DataSource = searchResults

            ' Make sure the "photo" column exists before trying to hide it
            If DataGridView_Advance_Search.Columns.Contains("photo") Then
                DataGridView_Advance_Search.Columns("photo").Visible = False
            End If

            'Format the widh of the columns
            DataGridView_Advance_Search.ForeColor = Color.Black
            DataGridView_Advance_Search.Columns("video_id").Width = 70
            DataGridView_Advance_Search.Columns("title").Width = 200
            DataGridView_Advance_Search.Columns("year").Width = 50
            DataGridView_Advance_Search.Columns("country").Width = 60
            DataGridView_Advance_Search.Columns("language").Width = 120
            DataGridView_Advance_Search.Columns("length").Width = 55
            DataGridView_Advance_Search.Columns("resume").Width = 175
            DataGridView_Advance_Search.Columns("genre").Width = 160
            DataGridView_Advance_Search.Columns("actors").Width = 210
            DataGridView_Advance_Search.Columns("title").Width = 200
            DataGridView_Advance_Search.Columns("director").Width = 100
            DataGridView_Advance_Search.Columns("status").Width = 45

        Else
            ' No results found
            'MessageBox.Show("No movies found matching the search criteria.", "No Results", MessageBoxButtons.OK, MessageBoxIcon.Information)
            DataGridView_Advance_Search.DataSource = Nothing
        End If
    End Sub



    Private Sub DataGridView_Quick_Search_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView_Advance_Search.CellContentClick
        ' Check if the click is on a row, not the column header
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = DataGridView_Advance_Search.Rows(e.RowIndex)

            ' StringBuilder to create the message string
            Dim movieDetails As New System.Text.StringBuilder()

            ' Loop through each cell in the row
            For Each cell As DataGridViewCell In selectedRow.Cells
                ' Append the column name and value to the string
                movieDetails.AppendLine(selectedRow.DataGridView.Columns(cell.ColumnIndex).Name & ": " & cell.Value.ToString())
            Next


            ' Display the user details and ask if the user wants to update
            Dim result As DialogResult = MessageBox.Show(movieDetails.ToString() & vbCrLf & "Do you want to select this movie?", "Movie Details", MessageBoxButtons.OK, MessageBoxIcon.Information)


            ' Using Globals to rescue movie object          
            Globals.MovieId = selectedRow.Cells("video_id").Value.ToString()
            TextBox_Selected_Movie_Id.Text = Globals.MovieId
            Globals.MoviePoster = selectedRow.Cells("photo").Value.ToString()

        End If
    End Sub
    'BUTTONS
    'Edit
    Private Sub Button_Edit_Click(sender As Object, e As EventArgs) Handles Button_Edit.Click
        If Globals.AccessLevel = "Low" Then
            MsgBox("Employee with 'Low' access security cannot Edit", MsgBoxStyle.Exclamation, "Access Level")
            Return
        ElseIf String.IsNullOrEmpty(TextBox_Selected_Movie_Id.Text) Then
            MsgBox("Please choose a movie to Edit", MsgBoxStyle.Information, "Error")
        Else
            ShowSelectedForm(Me, New EditMovie)
        End If

    End Sub

    'Rent
    Private Sub Button_Rent_Click(sender As Object, e As EventArgs) Handles Button_Rent.Click
        If String.IsNullOrEmpty(TextBox_Selected_Movie_Id.Text) Then
            MsgBox("Please choose a movie to Edit", MsgBoxStyle.Information, "Error")
        Else
            ShowSelectedForm(Me, New RentMovie)
        End If
    End Sub

    'Button Clear
    Private Sub Button_Clear_Click(sender As Object, e As EventArgs) Handles Button_Clear.Click
        TextBox_Title.Text = ""
        TextBox_Movie_ID.Text = ""
        TextBox_Genre.Text = ""
        TextBox_Director.Text = ""
        TextBox_Release_Year.Text = ""
        TextBox_Run_Time.Text = ""
        TextBox_Starring.Text = ""
        TextBox_Original_Language.Text = ""
        TextBox_Countries.Text = ""
        TextBox_Resume.Text = ""
        TextBox_Selected_Movie_Id.Text = ""
        DataGridView_Advance_Search.DataSource = Nothing

        'Clear the selectedItems (ComboBox)
        selectedItems.Clear()
    End Sub

    Private Sub TextBox_Movie_ID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_Movie_ID.KeyPress
        ' Allow only digits and control characters (like backspace)
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True ' Ignore the character (don't add it to the TextBox)
        End If
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

    Private Sub Button_Dashboard_Click(sender As Object, e As EventArgs) Handles Button_Dashboard.Click
        ShowSelectedForm(Me, New Dashboard)
    End Sub
End Class