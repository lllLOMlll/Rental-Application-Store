Public Class EditListMovies

    Private Sub EditListMovies_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Adding an instance of the Menu
        Me.Controls.Add(New CommonMenuControl())

        'Display username and access level
        Label_Display_Username.Text = Globals.Username
        Label_Display_Access_Level.Text = Globals.AccessLevel

        ' Set AutoGenerateColumns to True to automatically create columns
        DataGridView_Movies_List.AutoGenerateColumns = True

        'Load the MovieData to display it in the DataGridView
        LoadMovieData()
    End Sub

    Private Sub LoadMovieData()
        Dim dbManager As New DBManagerMovie()
        Dim movieData As DataTable = dbManager.GetAllMovies()
        DataGridView_Movies_List.DataSource = movieData

        'Format table
        DataGridView_Movies_List.ForeColor = Color.Black
        DataGridView_Movies_List.Columns("title").Width = 250
        DataGridView_Movies_List.Columns("video_id").Width = 70
        DataGridView_Movies_List.Columns("year").Width = 50
        DataGridView_Movies_List.Columns("length").Width = 50
        DataGridView_Movies_List.Columns("genre").Width = 250
        DataGridView_Movies_List.Columns("status").Width = 45


        ' Hide the 'photo' column
        If DataGridView_Movies_List.Columns("photo") IsNot Nothing Then
            DataGridView_Movies_List.Columns("photo").Visible = False
        End If
    End Sub


    ' Display the movie info in a MsgBox when click on a line
    Private Sub DataGridView_Movies_List_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView_Movies_List.CellContentClick
        ' Check if the click is on a row, not the column header
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = DataGridView_Movies_List.Rows(e.RowIndex)

            ' StringBuilder to create the message string
            Dim userDetails As New System.Text.StringBuilder()

            ' Loop through each cell in the row
            For Each cell As DataGridViewCell In selectedRow.Cells
                ' Skip the 'photo' column
                If selectedRow.DataGridView.Columns(cell.ColumnIndex).Name.ToLower() <> "photo" Then
                    ' Append the column name and value to the string
                    userDetails.AppendLine(selectedRow.DataGridView.Columns(cell.ColumnIndex).Name & ": " & cell.Value.ToString())
                End If
            Next

            ' Display the user details and ask if the user wants to update
            Dim result As DialogResult = MessageBox.Show(userDetails.ToString() & vbCrLf & "Do you want to update this movie?", "Movie Details", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                ' Using Globals to rescue movie object          
                Globals.MovieId = selectedRow.Cells("video_id").Value.ToString()
                Globals.MoviePoster = selectedRow.Cells("photo").Value.ToString()
                ShowSelectedForm(Me, New EditMovie)
            End If
        End If
    End Sub

    Private Sub Button_Dashboard_Click(sender As Object, e As EventArgs) Handles Button_Dashboard.Click
        ShowSelectedForm(Me, New Dashboard)
    End Sub
End Class