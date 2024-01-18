Imports MySql.Data.MySqlClient

Public Class DbManagerRent
    Private Property connectionString As String = "server=localhost;user id=root;password=;database=video_store_application"
    Private Property connect As MySqlConnection

    Public Sub New()
        Try
            connect = New MySqlConnection(connectionString)
            connect.Open()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try
    End Sub

    ' Method to add a rent entry
    Public Sub AddRent(clientFk As Long, videoFk As Long, rentDate As DateTime)
        Try
            ' Insert a new rent entry with rent_date set and return_date as NULL
            Dim sql As String = "INSERT INTO rents (client_fk, video_fk, rent_date) VALUES (@ClientFk, @VideoFk, @RentDate)"
            Using cmd As New MySqlCommand(sql, connect)
                cmd.Parameters.AddWithValue("@ClientFk", clientFk)
                cmd.Parameters.AddWithValue("@VideoFk", videoFk)
                cmd.Parameters.AddWithValue("@RentDate", rentDate)
                If connect.State <> ConnectionState.Open Then
                    connect.Open()
                End If
                cmd.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error renting movie: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If connect.State <> ConnectionState.Closed Then
                connect.Close()
            End If
        End Try
    End Sub

    ' Method to update rent entry and return a movie
    Public Sub UpdateRentReturn(videoFk As Long)
        Try
            ' Update the return_date of the rent entry where return_date is NULL (not yet returned)
            Dim updateRentSql As String = "UPDATE rents SET return_date = NOW() WHERE video_fk = @VideoFk AND return_date IS NULL"
            Using cmd As New MySqlCommand(updateRentSql, connect)
                cmd.Parameters.AddWithValue("@VideoFk", videoFk)
                If connect.State <> ConnectionState.Open Then
                    connect.Open()
                End If
                cmd.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error returning movie: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If connect.State <> ConnectionState.Closed Then
                connect.Close()
            End If
        End Try
    End Sub

    Public Function GetRentByMovieId(movieId As Long) As Rent
        Dim rent As New Rent()
        Try
            Dim sql As String = "SELECT * FROM rents WHERE video_fk = @VideoFk AND return_date IS NULL ORDER BY rent_id ASC"
            Using cmd As New MySqlCommand(sql, connect)
                cmd.Parameters.AddWithValue("@VideoFk", movieId)
                If connect.State <> ConnectionState.Open Then
                    connect.Open()
                End If

                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        rent.RentId = Convert.ToInt64(reader("rent_id"))
                        rent.ClientFk = Convert.ToInt64(reader("client_fk"))
                        rent.VideoFk = Convert.ToInt64(reader("video_fk"))
                        rent.RentDate = Convert.ToDateTime(reader("rent_date"))
                        ' return_date is NULL, so I don't set it
                    Else
                        Return Nothing ' No rent found
                    End If
                End Using
            End Using
        Catch ex As MySqlException
            MessageBox.Show("Error retrieving rent: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        Finally
            If connect.State <> ConnectionState.Closed Then
                connect.Close()
            End If
        End Try
        Return rent
    End Function

    Public Function GetLatestRentByMovieId(movieId As Long) As Rent
        Dim rent As Rent = Nothing
        Try
            Dim sql As String = "SELECT * FROM rents WHERE video_fk = @VideoFk AND return_date IS NULL ORDER BY rent_date DESC LIMIT 1"
            Using cmd As New MySqlCommand(sql, connect)
                cmd.Parameters.AddWithValue("@VideoFk", movieId)
                If connect.State <> ConnectionState.Open Then
                    connect.Open()
                End If

                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        rent = New Rent()
                        rent.RentId = Convert.ToInt64(reader("rent_id"))
                        rent.ClientFk = Convert.ToInt64(reader("client_fk"))
                        rent.VideoFk = Convert.ToInt64(reader("video_fk"))
                        rent.RentDate = Convert.ToDateTime(reader("rent_date"))
                        If IsDBNull(reader("return_date")) Then
                            rent.ReturnDate = Nothing
                        Else
                            rent.ReturnDate = Convert.ToDateTime(reader("return_date"))
                        End If
                    End If
                End Using
            End Using
        Catch ex As MySqlException
            MessageBox.Show("Error retrieving latest rent: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If connect.State <> ConnectionState.Closed Then
                connect.Close()
            End If
        End Try
        Return rent
    End Function

    Public Function GetLatestRentByClientNumber(clientNumber As String) As Rent
        Dim rent As Rent = Nothing
        Try
            Dim sql As String = "SELECT * FROM rents WHERE client_fk = @ClientFk AND return_date IS NULL ORDER BY rent_date DESC LIMIT 1"
            Using cmd As New MySqlCommand(sql, connect)
                cmd.Parameters.AddWithValue("@ClientFk", clientNumber)
                If connect.State <> ConnectionState.Open Then
                    connect.Open()
                End If

                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        rent = New Rent()
                        rent.RentId = Convert.ToInt64(reader("rent_id"))
                        rent.ClientFk = Convert.ToInt64(reader("client_fk"))
                        rent.VideoFk = Convert.ToInt64(reader("video_fk"))
                        rent.RentDate = Convert.ToDateTime(reader("rent_date"))
                        If IsDBNull(reader("return_date")) Then
                            rent.ReturnDate = Nothing
                        Else
                            rent.ReturnDate = Convert.ToDateTime(reader("return_date"))
                        End If
                    End If
                End Using
            End Using
        Catch ex As MySqlException
            MessageBox.Show("Error retrieving latest rent for client: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If connect.State <> ConnectionState.Closed Then
                connect.Close()
            End If
        End Try
        Return rent
    End Function

    ' In DbManagerRent class
    Public Function HasOutstandingRentals(clientNumber As String) As Boolean
        Try
            Dim sql As String = "SELECT COUNT(*) FROM rents WHERE client_fk = @ClientFk AND return_date IS NULL"
            Using cmd As New MySqlCommand(sql, connect)
                cmd.Parameters.AddWithValue("@ClientFk", clientNumber)
                If connect.State <> ConnectionState.Open Then
                    connect.Open()
                End If

                Dim result As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                Return result > 0
            End Using
        Catch ex As Exception
            MessageBox.Show("Error checking for outstanding rentals: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Finally
            If connect.State <> ConnectionState.Closed Then
                connect.Close()
            End If
        End Try
    End Function


End Class
