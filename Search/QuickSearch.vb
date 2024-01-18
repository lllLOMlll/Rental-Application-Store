Public Class QuickSearch
    Private Sub QuickSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Controls.Add(New CommonMenuControl())

        'Display username and access level
        Label_Display_Username.Text = Globals.Username
        Label_Display_Access_Level.Text = Globals.AccessLevel

        ' Set AutoGenerateColumns to True to automatically create columns
        DataGridView_Quick_Search.AutoGenerateColumns = True
    End Sub

    Private Sub Button_Quick_Search_Click(sender As Object, e As EventArgs) Handles Button_Quick_Search.Click
        Dim dbManager As New DBManagerMovie()
        Dim dataTable As DataTable

        If Not String.IsNullOrWhiteSpace(TextBox_Movie_ID.Text) AndAlso Long.TryParse(TextBox_Movie_ID.Text, New Long()) Then
            ' Search by Movie ID
            dataTable = dbManager.SearchMoviesById(Long.Parse(TextBox_Movie_ID.Text))
        ElseIf Not String.IsNullOrWhiteSpace(TextBox_Title.Text) Then
            ' Search by Title
            dataTable = dbManager.SearchMoviesByTitle(TextBox_Title.Text)
        Else
            MessageBox.Show("Please enter a Movie ID or Title for search.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        ' Check if there are any results
        If dataTable IsNot Nothing AndAlso dataTable.Rows.Count > 0 Then
            ' Display the search results in DataGridView_Quick_Search
            DataGridView_Quick_Search.DataSource = dataTable
        Else
            ' No results found      
            DataGridView_Quick_Search.DataSource = Nothing
        End If


        'Column "photo" Not Visible

        If dataTable IsNot Nothing AndAlso dataTable.Rows.Count > 0 Then
            ' Display the search results in DataGridView_Quick_Search
            DataGridView_Quick_Search.DataSource = dataTable

            ' Make sure the "photo" column exists before trying to hide it
            If DataGridView_Quick_Search.Columns.Contains("photo") Then
                DataGridView_Quick_Search.Columns("photo").Visible = False
            End If

            'Format the widh of the columns
            DataGridView_Quick_Search.ForeColor = Color.Black
            DataGridView_Quick_Search.Columns("video_id").Width = 70
            DataGridView_Quick_Search.Columns("title").Width = 200
            DataGridView_Quick_Search.Columns("year").Width = 50
            DataGridView_Quick_Search.Columns("country").Width = 60
            DataGridView_Quick_Search.Columns("language").Width = 120
            DataGridView_Quick_Search.Columns("length").Width = 55
            DataGridView_Quick_Search.Columns("resume").Width = 175
            DataGridView_Quick_Search.Columns("genre").Width = 160
            DataGridView_Quick_Search.Columns("actors").Width = 210
            DataGridView_Quick_Search.Columns("title").Width = 200
            DataGridView_Quick_Search.Columns("director").Width = 100
            DataGridView_Quick_Search.Columns("status").Width = 45

        Else
            ' No results found
            MessageBox.Show("No movies found matching the search criteria.", "No Results", MessageBoxButtons.OK, MessageBoxIcon.Information)
            DataGridView_Quick_Search.DataSource = Nothing
        End If
    End Sub

    Private Sub DataGridView_Quick_Search_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView_Quick_Search.CellContentClick
        ' Check if the click is on a row, not the column header
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = DataGridView_Quick_Search.Rows(e.RowIndex)

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
        TextBox_Selected_Movie_Id.Text = ""
        DataGridView_Quick_Search.DataSource = Nothing
    End Sub

    Private Sub TextBox_Movie_ID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_Movie_ID.KeyPress
        ' Allow only digits and control characters (like backspace)
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True ' Ignore the character (don't add it to the TextBox)
        End If
    End Sub

    Private Sub Button_Dashboard_Click(sender As Object, e As EventArgs) Handles Button_Dashboard.Click
        ShowSelectedForm(Me, New Dashboard)
    End Sub
End Class