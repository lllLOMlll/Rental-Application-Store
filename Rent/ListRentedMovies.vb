Public Class ListRentedMovies

    Private Sub ListRentedMovies_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Adding an instance of the Menu
        Me.Controls.Add(New CommonMenuControl())

        'Display username and access level
        Label_Display_Username.Text = Globals.Username
        Label_Display_Access_Level.Text = Globals.AccessLevel

        ' Set AutoGenerateColumns to True to automatically create columns
        DataGridView_List_Rented_Movies.AutoGenerateColumns = True

        'Load the MovieData to display it in the DataGridView
        FormatDataGridView()
    End Sub

    Private Sub FormatDataGridView()
        Dim dbManager As New DBManagerMovie()
        Dim movieData As DataTable = dbManager.GetRentedMovies()
        DataGridView_List_Rented_Movies.DataSource = movieData

        'Format table
        DataGridView_List_Rented_Movies.ForeColor = Color.Black
        DataGridView_List_Rented_Movies.Columns("title").Width = 250
        DataGridView_List_Rented_Movies.Columns("video_id").Width = 70
        DataGridView_List_Rented_Movies.Columns("year").Width = 50
        DataGridView_List_Rented_Movies.Columns("length").Width = 50
        DataGridView_List_Rented_Movies.Columns("genre").Width = 250
        DataGridView_List_Rented_Movies.Columns("status").Width = 45



    End Sub


    ' Display the movie info in a MsgBox when click on a line
    Private Sub DataGridView_Movies_List_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView_List_Rented_Movies.CellContentClick
        ' Check if the click is on a row, not the column header
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = DataGridView_List_Rented_Movies.Rows(e.RowIndex)

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
            Dim result As DialogResult = MessageBox.Show(userDetails.ToString() & vbCrLf & "Do you want to return this movie?", "Movie Details", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                ' Using Globals to rescue movie object          
                Globals.MovieId = selectedRow.Cells("video_id").Value.ToString()
                Globals.MoviePoster = selectedRow.Cells("photo").Value.ToString()
                ShowSelectedForm(Me, New RentMovie)
            End If
        End If
    End Sub

    Private Sub Button_Dashboard_Click(sender As Object, e As EventArgs) Handles Button_Dashboard.Click
        ShowSelectedForm(Me, New Dashboard)
    End Sub
End Class