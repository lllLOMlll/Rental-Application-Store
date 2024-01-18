Imports MySql.Data.MySqlClient

Public Class DBManagerClient
    Private Property connectionString As String = "server=localhost;user id=root;password=;database=video_store_application"
    Private Property connect As MySqlConnection

    ' Constructor to initialize the database connection
    Public Sub New()
        Try
            connect = New MySqlConnection(connectionString)
            connect.Open()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try
    End Sub

    ' Method to retrieve all clients from the database
    Public Function GetAllClients() As DataTable
        Dim dataTable As New DataTable()
        Try
            Dim sql As String = "SELECT * FROM clients ORDER BY client_id DESC"
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

    Public Sub AddClient(client As Client)
        Try
            Dim sql As String = "INSERT INTO clients (client_number, fname, lname, email, phone, dob, address, city, province, postal_code, status) VALUES (@ClientNumber, @FirstName, @LastName, @Email, @Phone, @DOB, @Address, @City, @Province, @PostalCode, 1)"

            Using cmd As New MySqlCommand(sql, connect)
                cmd.Parameters.AddWithValue("@ClientNumber", client.ClientNumber)
                cmd.Parameters.AddWithValue("@FirstName", client.FirstName)
                cmd.Parameters.AddWithValue("@LastName", client.LastName)
                cmd.Parameters.AddWithValue("@Email", client.Email)
                cmd.Parameters.AddWithValue("@Phone", client.Phone)
                cmd.Parameters.AddWithValue("@DOB", client.DateOfBirth)
                cmd.Parameters.AddWithValue("@Address", client.Address)
                cmd.Parameters.AddWithValue("@City", client.City)
                cmd.Parameters.AddWithValue("@Province", client.Province)
                cmd.Parameters.AddWithValue("@PostalCode", client.PostalCode)
                If connect.State <> ConnectionState.Open Then
                    connect.Open()
                End If

                cmd.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error adding client: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If connect.State <> ConnectionState.Closed Then
                connect.Close()
            End If
        End Try
    End Sub

    Public Function GetClientByClientNumber(clientNumber As String) As Client
        Dim client As New Client()
        Try
            Dim sql As String = "SELECT * FROM clients WHERE client_number = @ClientNumber"
            Using cmd As New MySqlCommand(sql, connect)
                cmd.Parameters.AddWithValue("@ClientNumber", clientNumber)
                If connect.State <> ConnectionState.Open Then
                    connect.Open()
                End If

                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        client.ClientId = Convert.ToInt64(reader("client_id"))
                        client.ClientNumber = reader("client_number").ToString()
                        client.FirstName = reader("fname").ToString()
                        client.LastName = reader("lname").ToString()
                        client.Email = reader("email").ToString()
                        client.Phone = reader("phone").ToString()
                        client.DateOfBirth = Convert.ToDateTime(reader("dob"))
                        client.Address = reader("address").ToString()
                        client.City = reader("city").ToString()
                        client.Province = reader("province").ToString()
                        client.PostalCode = reader("postal_code").ToString()
                        client.Status = CType(Convert.ToInt32(reader("status")), Client.ClientStatus)
                    End If
                End Using
            End Using
        Catch ex As MySqlException
            MessageBox.Show("Error retrieving client: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Ensure the connection is closed after the operation
            If connect.State <> ConnectionState.Closed Then
                connect.Close()
            End If
        End Try
        Return client
    End Function

    Public Sub UpdateClient(client As Client)
        Try
            Dim sql As String = "UPDATE clients SET fname = @FirstName, lname = @LastName, email = @Email, phone = @Phone, dob = @DOB, address = @Address, city = @City, province = @Province, postal_code = @PostalCode, status = @Status WHERE client_number = @ClientNumber"

            Using cmd As New MySqlCommand(sql, connect)
                ' Add parameters using the client object
                cmd.Parameters.AddWithValue("@ClientNumber", client.ClientNumber)
                cmd.Parameters.AddWithValue("@FirstName", client.FirstName)
                cmd.Parameters.AddWithValue("@LastName", client.LastName)
                cmd.Parameters.AddWithValue("@Email", client.Email)
                cmd.Parameters.AddWithValue("@Phone", client.Phone)
                cmd.Parameters.AddWithValue("@DOB", client.DateOfBirth)
                cmd.Parameters.AddWithValue("@Address", client.Address)
                cmd.Parameters.AddWithValue("@City", client.City)
                cmd.Parameters.AddWithValue("@Province", client.Province)
                cmd.Parameters.AddWithValue("@PostalCode", client.PostalCode)
                cmd.Parameters.AddWithValue("@Status", client.Status)

                ' Open connection and execute the command
                If connect.State <> ConnectionState.Open Then
                    connect.Open()
                End If

                cmd.ExecuteNonQuery()
            End Using
        Catch ex As MySqlException
            MessageBox.Show("Error updating client: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If connect.State <> ConnectionState.Closed Then
                connect.Close()
            End If
        End Try
    End Sub


    Public Sub UpdateClientStatus(clientNumber As String, newStatus As Integer)
        Try
            Dim sql As String = "UPDATE clients SET status = @NewStatus WHERE client_number = @ClientNumber"

            Using cmd As New MySqlCommand(sql, connect)
                cmd.Parameters.AddWithValue("@NewStatus", newStatus)
                cmd.Parameters.AddWithValue("@ClientNumber", clientNumber)

                If connect.State <> ConnectionState.Open Then
                    connect.Open()
                End If
                cmd.ExecuteNonQuery()
            End Using
        Catch ex As MySqlException
            MessageBox.Show("Error updating client status: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If connect.State <> ConnectionState.Closed Then
                connect.Close()
            End If
        End Try
    End Sub

    Public Function GetAllClientNumbers() As List(Of String)
        Dim clientNumbers As New List(Of String)
        Try
            Dim sql As String = "SELECT client_number FROM clients"
            Using cmd As New MySqlCommand(sql, connect)
                If connect.State <> ConnectionState.Open Then
                    connect.Open()
                End If

                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        clientNumbers.Add(reader("client_number").ToString())
                    End While
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error retrieving client numbers: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If connect.State <> ConnectionState.Closed Then
                connect.Close()
            End If
        End Try
        Return clientNumbers
    End Function

    Public Function GetAllClientNumberAndFirstNames() As DataTable
        Dim dataTable As New DataTable()
        Try
            ' Modify the SQL query to select both client_number and the first name (fname)
            Dim sql As String = "SELECT client_number, fname FROM clients ORDER BY client_id DESC"
            Using cmd As New MySqlCommand(sql, connect)
                If connect.State <> ConnectionState.Open Then
                    connect.Open()
                End If

                Using adapter As New MySqlDataAdapter(cmd)
                    adapter.Fill(dataTable)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error retrieving client numbers and names: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If connect.State <> ConnectionState.Closed Then
                connect.Close()
            End If
        End Try
        Return dataTable
    End Function

End Class


