Imports MySql.Data.MySqlClient

Public Class DbManagerCreditCard
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

    Public Sub AddCreditCard(creditCard As CreditCard)
        Try
            Dim sql As String = "INSERT INTO credit_card (card_type, number, exp_date, client_number) VALUES (@CardType, @CardNumber, @ExpDate, @ClientNumber)"

            Using cmd As New MySqlCommand(sql, connect)
                cmd.Parameters.AddWithValue("@CardType", creditCard.CardType)
                cmd.Parameters.AddWithValue("@CardNumber", creditCard.Number)
                cmd.Parameters.AddWithValue("@ExpDate", creditCard.ExpDate)
                cmd.Parameters.AddWithValue("@ClientNumber", creditCard.ClientNumber)

                If connect.State <> ConnectionState.Open Then
                    connect.Open()
                End If
                cmd.ExecuteNonQuery()
            End Using
        Catch ex As MySqlException
            MessageBox.Show("Error adding credit card: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If connect.State <> ConnectionState.Closed Then
                connect.Close()
            End If
        End Try
    End Sub


    Public Function GetCreditCardByClientNumber(clientNumber As String) As CreditCard
        Dim creditCard As New CreditCard()
        Try
            Dim sql As String = "SELECT * FROM credit_card WHERE client_number = @ClientNumber"

            Using cmd As New MySqlCommand(sql, connect)
                cmd.Parameters.AddWithValue("@ClientNumber", clientNumber)

                If connect.State <> ConnectionState.Open Then
                    connect.Open()
                End If

                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        creditCard.CreditCardId = Convert.ToInt64(reader("credit_card_id"))
                        creditCard.CardType = reader("card_type").ToString()
                        creditCard.Number = reader("number").ToString()
                        creditCard.ExpDate = Convert.ToDateTime(reader("exp_date"))
                        creditCard.ClientNumber = reader("client_number").ToString()
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error retrieving credit card: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If connect.State <> ConnectionState.Closed Then
                connect.Close()
            End If
        End Try
        Return creditCard
    End Function

    Public Sub UpdateCreditCard(creditCard As CreditCard)
        Try
            Dim sql As String = "UPDATE credit_card SET card_type = @CardType, number = @CardNumber, exp_date = @ExpDate WHERE client_number = @ClientNumber"

            Using cmd As New MySqlCommand(sql, connect)
                cmd.Parameters.AddWithValue("@CardType", creditCard.CardType)
                cmd.Parameters.AddWithValue("@CardNumber", creditCard.Number)
                cmd.Parameters.AddWithValue("@ExpDate", creditCard.ExpDate)
                cmd.Parameters.AddWithValue("@ClientNumber", creditCard.ClientNumber)

                If connect.State <> ConnectionState.Open Then
                    connect.Open()
                End If
                cmd.ExecuteNonQuery()
            End Using
        Catch ex As MySqlException
            MessageBox.Show("Error updating credit card: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If connect.State <> ConnectionState.Closed Then
                connect.Close()
            End If
        End Try
    End Sub


    Public Function CreditCardExists(clientNumber As String) As Boolean
        Try
            Dim sql As String = "SELECT COUNT(*) FROM credit_card WHERE client_number = @ClientNumber"
            Using cmd As New MySqlCommand(sql, connect)
                cmd.Parameters.AddWithValue("@ClientNumber", clientNumber)
                If connect.State <> ConnectionState.Open Then
                    connect.Open()
                End If
                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                Return count > 0
            End Using
        Catch ex As Exception
            MessageBox.Show("Error checking credit card existence: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Finally
            If connect.State <> ConnectionState.Closed Then
                connect.Close()
            End If
        End Try
    End Function

End Class
