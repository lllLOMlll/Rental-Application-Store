Imports System.Text
Imports MySql.Data.MySqlClient

Public Class DBManagerMovie
    Private Property connectionString = "server=localhost;user id=root;password=;database=video_store_application"
    Private Property connect As MySqlConnection

    Public Sub New()
        Try
            connect = New MySqlConnection(connectionString)
            connect.Open()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try
    End Sub

    Public Function GetAllMovies() As DataTable
        Dim dataTable As New DataTable()
        Try
            Dim sql As String = "SELECT * FROM movies ORDER BY video_id DESC"
            Using cmd As New MySqlCommand(sql, connect)
                ' Check if connection is not already open
                If connect.State <> ConnectionState.Open Then
                    connect.Open()
                End If

                ' Execute the command and fill the DataTable
                Using adapter As New MySqlDataAdapter(cmd)
                    adapter.Fill(dataTable)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Ensure the connection is closed after operation
            If connect.State <> ConnectionState.Closed Then
                connect.Close()
            End If
        End Try
        Return dataTable
    End Function


    Public Sub AddMovie(movie As Movie)
        Try
            Dim sql As String = "INSERT INTO movies (photo, title, year, country, language, length, resume, genre, actors, director, status) VALUES (@Photo, @Title, @Year, @Country, @Language, @Length, @Resume, @Genre, @Actors, @Director, 1)"

            Using cmd As New MySqlCommand(sql, connect)
                cmd.Parameters.AddWithValue("@Photo", movie.Photo)
                cmd.Parameters.AddWithValue("@Title", movie.Title)
                cmd.Parameters.AddWithValue("@Year", movie.Year)
                cmd.Parameters.AddWithValue("@Country", movie.Country)
                cmd.Parameters.AddWithValue("@Language", movie.Language)
                cmd.Parameters.AddWithValue("@Length", movie.Length)
                cmd.Parameters.AddWithValue("@Resume", movie.Resume)
                cmd.Parameters.AddWithValue("@Genre", movie.Genre)
                cmd.Parameters.AddWithValue("@Actors", movie.Actors)
                cmd.Parameters.AddWithValue("@Director", movie.Director)

                If connect.State <> ConnectionState.Open Then
                    connect.Open()
                End If

                cmd.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error adding movie: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If connect.State <> ConnectionState.Closed Then
                connect.Close()
            End If
        End Try
    End Sub


    Public Function GetMovieById(videoId As Long) As Movie
        Dim movie As New Movie()
        Try
            Dim sql As String = "SELECT video_id, photo, title, year, country, language, length, resume, genre, actors, director, status FROM movies WHERE video_id = @VideoId"

            Using cmd As New MySqlCommand(sql, connect)
                cmd.Parameters.AddWithValue("@VideoId", videoId)

                If connect.State <> ConnectionState.Open Then
                    connect.Open()
                End If

                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        movie.VideoId = Convert.ToInt64(reader("video_id"))
                        movie.Photo = reader("photo").ToString()
                        movie.Title = reader("title").ToString()
                        movie.Year = reader("year").ToString()
                        movie.Country = reader("country").ToString()
                        movie.Language = reader("language").ToString()
                        movie.Length = Convert.ToInt32(reader("length"))
                        movie.Resume = reader("resume").ToString()
                        movie.Genre = reader("genre").ToString()
                        movie.Actors = reader("actors").ToString()
                        movie.Director = reader("director").ToString()
                        movie.Status = CType(Convert.ToInt32(reader("status")), Movie.MovieStatus)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If connect.State <> ConnectionState.Closed Then
                connect.Close()
            End If
        End Try
        Return movie
    End Function

    Public Sub UpdateMovie(movie As Movie)
        Try
            Dim sql As String = "UPDATE movies SET photo = @Photo, title = @Title, year = @Year, country = @Country, language = @Language, length = @Length, resume = @Resume, genre = @Genre, actors = @Actors, director = @Director, status = @Status WHERE video_id = @MovieId"

            Using cmd As New MySqlCommand(sql, connect)
                cmd.Parameters.AddWithValue("@MovieId", movie.VideoId)
                cmd.Parameters.AddWithValue("@Photo", movie.Photo)
                cmd.Parameters.AddWithValue("@Title", movie.Title)
                cmd.Parameters.AddWithValue("@Year", movie.Year)
                cmd.Parameters.AddWithValue("@Country", movie.Country)
                cmd.Parameters.AddWithValue("@Language", movie.Language)
                cmd.Parameters.AddWithValue("@Length", movie.Length)
                cmd.Parameters.AddWithValue("@Resume", movie.Resume)
                cmd.Parameters.AddWithValue("@Genre", movie.Genre)
                cmd.Parameters.AddWithValue("@Actors", movie.Actors)
                cmd.Parameters.AddWithValue("@Director", movie.Director)
                cmd.Parameters.AddWithValue("@Status", movie.Status)

                If connect.State <> ConnectionState.Open Then
                    connect.Open()
                End If
                cmd.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error updating movie: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If connect.State <> ConnectionState.Closed Then
                connect.Close()
            End If
        End Try
    End Sub


    Public Sub DeleteMovieWithId(movieId As Long)
        Try
            Dim sql As String = "UPDATE movies SET status = 2 WHERE video_id = @MovieId"

            Using cmd As New MySqlCommand(sql, connect)
                cmd.Parameters.AddWithValue("@MovieId", movieId)

                ' Open connection and execute the command
                If connect.State <> ConnectionState.Open Then
                    connect.Open()
                End If

                cmd.ExecuteNonQuery()
                ' No message because I prefer to write in the delete section
            End Using
        Catch ex As Exception
            MessageBox.Show("Error deleting movie: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Ensure the connection is closed after operation
            If connect.State <> ConnectionState.Closed Then
                connect.Close()
            End If
        End Try
    End Sub

    ' Method to search movies by title
    Public Function SearchMoviesByTitle(title As String) As DataTable
        Dim dataTable As New DataTable()
        Try
            Dim sql As String = "SELECT * FROM movies WHERE title LIKE @Title ORDER BY video_id DESC"
            Using cmd As New MySqlCommand(sql, connect)
                cmd.Parameters.AddWithValue("@Title", "%" & title & "%")

                If connect.State <> ConnectionState.Open Then
                    connect.Open()
                End If

                Using adapter As New MySqlDataAdapter(cmd)
                    adapter.Fill(dataTable)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error searching movies: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If connect.State <> ConnectionState.Closed Then
                connect.Close()
            End If
        End Try
        Return dataTable
    End Function


    ' Method to search movies by movie ID
    Public Function SearchMoviesById(movieId As Long) As DataTable
        Dim dataTable As New DataTable()
        Try
            Dim sql As String = "SELECT * FROM movies WHERE video_id = @MovieId"
            Using cmd As New MySqlCommand(sql, connect)
                cmd.Parameters.AddWithValue("@MovieId", movieId)

                If connect.State <> ConnectionState.Open Then
                    connect.Open()
                End If

                Using adapter As New MySqlDataAdapter(cmd)
                    adapter.Fill(dataTable)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error searching movies: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If connect.State <> ConnectionState.Closed Then
                connect.Close()
            End If
        End Try
        Return dataTable
    End Function

    Public Function GetAllMovieIds() As List(Of Long)
        Dim movieIds As New List(Of Long)
        Try
            ' Modified to order by video_id in descending order
            Dim sql As String = "SELECT video_id FROM movies ORDER BY video_id DESC"
            Using cmd As New MySqlCommand(sql, connect)
                If connect.State <> ConnectionState.Open Then
                    connect.Open()
                End If

                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        movieIds.Add(Convert.ToInt64(reader("video_id")))
                    End While
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error fetching movie IDs: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If connect.State <> ConnectionState.Closed Then
                connect.Close()
            End If
        End Try
        Return movieIds
    End Function


    Public Sub UpdateMovieStatus(movieId As Long, newStatus As Integer)
        Try
            Dim sql As String = "UPDATE movies SET status = @NewStatus WHERE video_id = @MovieId"

            Using cmd As New MySqlCommand(sql, connect)
                ' Add parameters to the command
                cmd.Parameters.AddWithValue("@MovieId", movieId)
                cmd.Parameters.AddWithValue("@NewStatus", newStatus)

                ' Open connection and execute the command
                If connect.State <> ConnectionState.Open Then
                    connect.Open()
                End If
                cmd.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error updating movie status: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Ensure the connection is closed after operation
            If connect.State <> ConnectionState.Closed Then
                connect.Close()
            End If
        End Try
    End Sub

    Public Function GetRentedMovies() As DataTable
        Dim dataTable As New DataTable()
        Try
            Dim sql As String = "SELECT * FROM movies WHERE status = 0"
            Using cmd As New MySqlCommand(sql, connect)
                If connect.State <> ConnectionState.Open Then
                    connect.Open()
                End If

                Using adapter As New MySqlDataAdapter(cmd)
                    adapter.Fill(dataTable)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If connect.State <> ConnectionState.Closed Then
                connect.Close()
            End If
        End Try
        Return dataTable
    End Function

    Public Function AdvancedSearch(title As String, movieId As String, genre As String, director As String, releaseYear As String, runTime As String, starring As String, originalLanguage As String, countries As String, resumeText As String) As DataTable
        Dim dataTable As New DataTable()
        Try
            Dim sql As New StringBuilder("SELECT * FROM movies WHERE 1=1")

            ' Build the SQL query
            If Not String.IsNullOrWhiteSpace(title) Then
                sql.Append(" AND title LIKE @Title")
            End If
            If Not String.IsNullOrWhiteSpace(movieId) Then
                sql.Append(" AND video_id = @MovieId")
            End If
            If Not String.IsNullOrWhiteSpace(genre) Then
                sql.Append(" AND genre LIKE @Genre")
            End If
            If Not String.IsNullOrWhiteSpace(director) Then
                sql.Append(" AND director LIKE @Director")
            End If
            If Not String.IsNullOrWhiteSpace(releaseYear) Then
                sql.Append(" AND year = @ReleaseYear")
            End If
            If Not String.IsNullOrWhiteSpace(runTime) Then
                sql.Append(" AND length = @RunTime")
            End If
            If Not String.IsNullOrWhiteSpace(starring) Then
                sql.Append(" AND actors LIKE @Starring")
            End If
            If Not String.IsNullOrWhiteSpace(originalLanguage) Then
                sql.Append(" AND language LIKE @OriginalLanguage")
            End If
            If Not String.IsNullOrWhiteSpace(countries) Then
                sql.Append(" AND country LIKE @Countries")
            End If
            If Not String.IsNullOrWhiteSpace(resumeText) Then
                sql.Append(" AND resume LIKE @ResumeText")
            End If

            ' Add ORDER BY clause
            sql.Append(" ORDER BY video_id DESC")

            Using cmd As New MySqlCommand(sql.ToString(), connect)
                ' Add parameters inside the Using block
                If Not String.IsNullOrWhiteSpace(title) Then
                    cmd.Parameters.AddWithValue("@Title", "%" & title & "%")
                End If
                If Not String.IsNullOrWhiteSpace(movieId) Then
                    cmd.Parameters.AddWithValue("@MovieId", movieId)
                End If
                If Not String.IsNullOrWhiteSpace(genre) Then
                    cmd.Parameters.AddWithValue("@Genre", "%" & genre & "%")
                End If
                If Not String.IsNullOrWhiteSpace(director) Then
                    cmd.Parameters.AddWithValue("@Director", "%" & director & "%")
                End If
                If Not String.IsNullOrWhiteSpace(releaseYear) Then
                    cmd.Parameters.AddWithValue("@ReleaseYear", releaseYear)
                End If
                If Not String.IsNullOrWhiteSpace(runTime) Then
                    cmd.Parameters.AddWithValue("@RunTime", runTime)
                End If
                If Not String.IsNullOrWhiteSpace(starring) Then
                    cmd.Parameters.AddWithValue("@Starring", "%" & starring & "%")
                End If
                If Not String.IsNullOrWhiteSpace(originalLanguage) Then
                    cmd.Parameters.AddWithValue("@OriginalLanguage", "%" & originalLanguage & "%")
                End If
                If Not String.IsNullOrWhiteSpace(countries) Then
                    cmd.Parameters.AddWithValue("@Countries", "%" & countries & "%")
                End If
                If Not String.IsNullOrWhiteSpace(resumeText) Then
                    cmd.Parameters.AddWithValue("@ResumeText", "%" & resumeText & "%")
                End If

                ' Execute the command and fill the DataTable
                If connect.State <> ConnectionState.Open Then
                    connect.Open()
                End If

                Using adapter As New MySqlDataAdapter(cmd)
                    adapter.Fill(dataTable)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Ensure the connection is closed after operation
            If connect.State <> ConnectionState.Closed Then
                connect.Close()
            End If
        End Try
        Return dataTable
    End Function

    Public Function GetAllMovieIdsAndTitles() As DataTable
        Dim dataTable As New DataTable()
        Try
            Dim sql As String = "SELECT video_id, title FROM movies ORDER BY video_id DESC"
            Using cmd As New MySqlCommand(sql, connect)
                If connect.State <> ConnectionState.Open Then
                    connect.Open()
                End If

                Using adapter As New MySqlDataAdapter(cmd)
                    adapter.Fill(dataTable)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If connect.State <> ConnectionState.Closed Then
                connect.Close()
            End If
        End Try
        Return dataTable
    End Function







End Class
