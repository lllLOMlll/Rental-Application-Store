Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.Text

Public Class DbManagerEmployee
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

    Public Sub TestConnection()
        If Me.connect.State = ConnectionState.Open Then
            MsgBox("TEST CONNECTION" & vbCrLf & "Success!")
        Else
            MsgBox("TEST CONNECTION" & vbCrLf & "Failed!")
        End If
    End Sub

    Public Sub AddEmployee(employee As Employee)
        Try
            Dim sql As String = "INSERT INTO users (employee_number, username, password, fname, lname, dob, address, city, province, postal_code, home_phone, cell_phone, start_date, sin, hourly_pay, education, level, status) VALUES (@EmployeeNumber, @Username, @Password, @FirstName, @LastName, @DateOfBirth, @Address, @City, @Province, @PostalCode, @HomePhone, @CellPhone, @StartDate, @SIN, @HourlyPay, @Education, @Level, @Status)"

            Dim cmd As New MySqlCommand(sql, connect)

            ' Set the parameters using the employee object
            cmd.Parameters.AddWithValue("@EmployeeNumber", employee.EmployeeNumber)
            cmd.Parameters.AddWithValue("@Username", employee.Username)
            cmd.Parameters.AddWithValue("@Password", employee.Password)
            cmd.Parameters.AddWithValue("@FirstName", employee.FirstName)
            cmd.Parameters.AddWithValue("@LastName", employee.LastName)
            cmd.Parameters.AddWithValue("@DateOfBirth", employee.DateOfBirth)
            cmd.Parameters.AddWithValue("@Address", employee.Address)
            cmd.Parameters.AddWithValue("@City", employee.City)
            cmd.Parameters.AddWithValue("@Province", employee.Province.ToString())
            cmd.Parameters.AddWithValue("@PostalCode", employee.PostalCode)
            cmd.Parameters.AddWithValue("@HomePhone", employee.HomePhone)
            cmd.Parameters.AddWithValue("@CellPhone", employee.CellPhone)
            cmd.Parameters.AddWithValue("@StartDate", employee.StartDate)
            cmd.Parameters.AddWithValue("@SIN", employee.SIN)
            cmd.Parameters.AddWithValue("@HourlyPay", employee.HourlyPay)
            cmd.Parameters.AddWithValue("@Education", employee.Education.ToString())
            cmd.Parameters.AddWithValue("@Level", employee.Level.ToString())
            cmd.Parameters.AddWithValue("@Status", employee.Status.ToString())

            If connect.State <> ConnectionState.Open Then
                connect.Open()
            End If

            cmd.ExecuteNonQuery()

            MsgBox("Employee added successfully!", MsgBoxStyle.Information, "Success")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error Adding Employee")
        Finally
            If connect.State <> ConnectionState.Closed Then
                connect.Close()
            End If
        End Try
    End Sub




    Public Function CheckLogin(username As String, hashedPassword As String) As (isValid As Boolean, status As String, level As String)
        Try
            Dim sql As String = "SELECT password, status, level FROM users WHERE username = @Username LIMIT 1"
            Using cmd As New MySqlCommand(sql, connect)
                cmd.Parameters.AddWithValue("@Username", username)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        Dim storedHashedPassword As String = reader("password").ToString()
                        Dim status As String = reader("status").ToString()
                        Dim level As String = reader("level").ToString()

                        ' Check if the hashed passwords match and return the result along with status and level
                        Return (storedHashedPassword = hashedPassword, status, level)
                    Else
                        ' Username not found
                        Return (False, String.Empty, String.Empty)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return (False, String.Empty, String.Empty)
        End Try
    End Function

    Public Function UsernameExists(username As String) As Boolean
        Try
            Dim sql As String = "SELECT COUNT(*) FROM users WHERE username = @Username"
            Using cmd As New MySqlCommand(sql, connect)
                ' Check if connection is not already open
                If connect.State <> ConnectionState.Open Then
                    connect.Open()
                End If

                cmd.Parameters.AddWithValue("@Username", username)
                Dim result As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                Return result > 0
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Finally
            ' Ensure the connection is closed after operation
            If connect.State <> ConnectionState.Closed Then
                connect.Close()
            End If
        End Try
    End Function


    Public Function ChangePassword(username As String, hashedNewPassword As String) As Boolean
        Try
            Dim sql As String = "UPDATE users SET password = @NewPassword WHERE username = @Username"
            Using cmd As New MySqlCommand(sql, connect)
                cmd.Parameters.AddWithValue("@NewPassword", hashedNewPassword)
                cmd.Parameters.AddWithValue("@Username", username)

                ' Check if connection is not already open
                If connect.State <> ConnectionState.Open Then
                    connect.Open()
                End If

                Dim result As Integer = cmd.ExecuteNonQuery()

                Return result > 0
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Finally
            ' Ensure the connection is closed after operation
            If connect.State <> ConnectionState.Closed Then
                connect.Close()
            End If
        End Try
    End Function



    Public Function SetUserStatusActive(username As String) As Boolean
        Try
            Dim sql As String = "UPDATE users SET status = 'Active' WHERE username = @Username AND status = 'Inactive'"
            Using cmd As New MySqlCommand(sql, connect)
                ' Check if connection is not already open
                If connect.State <> ConnectionState.Open Then
                    connect.Open()
                End If

                cmd.Parameters.AddWithValue("@Username", username)
                Dim result As Integer = cmd.ExecuteNonQuery()

                Return result > 0
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Finally
            ' Ensure the connection is closed after operation
            If connect.State <> ConnectionState.Closed Then
                connect.Close()
            End If
        End Try
    End Function

    'This is to display the user data (ListEmployees Form)
    Public Function GetAllEmployeesWithoutPassword() As DataTable
        Dim dataTable As New DataTable()
        Try
            Dim sql As String = "SELECT employee_number, username, fname, lname, dob, address, city, province, postal_code, home_phone, cell_phone, start_date, sin, hourly_pay, education, level, status FROM users ORDER BY lname ASC"

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

    Public Function GetUserByEmployeeNumber(employeeNumber As String) As Employee
        Dim employee As New Employee()
        Try
            Dim sql As String = "SELECT employee_number, username, fname, lname, dob, address, city, province, postal_code, home_phone, cell_phone, start_date, sin, hourly_pay, education, level, status FROM users WHERE employee_number = @EmployeeNumber"

            Using cmd As New MySqlCommand(sql, connect)
                cmd.Parameters.AddWithValue("@EmployeeNumber", employeeNumber)

                If connect.State <> ConnectionState.Open Then
                    connect.Open()
                End If

                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        employee.EmployeeNumber = reader("employee_number").ToString()
                        employee.Username = reader("username").ToString()
                        employee.FirstName = reader("fname").ToString()
                        employee.LastName = reader("lname").ToString()
                        employee.DateOfBirth = Convert.ToDateTime(reader("dob")).Date
                        employee.Address = reader("address").ToString()
                        employee.City = reader("city").ToString()
                        employee.Province = reader("province").ToString()
                        employee.PostalCode = reader("postal_code").ToString()
                        employee.HomePhone = reader("home_phone").ToString()
                        employee.CellPhone = reader("cell_phone").ToString()
                        employee.StartDate = Convert.ToDateTime(reader("start_date")).Date
                        employee.SIN = reader("sin").ToString()
                        employee.HourlyPay = Convert.ToDouble(reader("hourly_pay"))
                        employee.Education = reader("education").ToString()
                        employee.Level = reader("level").ToString()
                        employee.Status = reader("status").ToString()
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
        Return employee
    End Function

    Public Sub UpdateEmployee(employee As Employee)
        Try
            Dim sql As String = "UPDATE users SET username = @Username, fname = @FirstName, lname = @LastName, dob = @DateOfBirth, address = @Address, city = @City, province = @Province, postal_code = @PostalCode, home_phone = @HomePhone, cell_phone = @CellPhone, start_date = @StartDate, sin = @SIN, hourly_pay = @HourlyPay, education = @Education, level = @Level, status = @Status WHERE employee_number = @EmployeeNumber"

            Dim cmd As New MySqlCommand(sql, connect)

            ' Set the parameters for the SQL command
            cmd.Parameters.AddWithValue("@EmployeeNumber", employee.EmployeeNumber)
            cmd.Parameters.AddWithValue("@Username", employee.Username)
            cmd.Parameters.AddWithValue("@FirstName", employee.FirstName)
            cmd.Parameters.AddWithValue("@LastName", employee.LastName)
            cmd.Parameters.AddWithValue("@DateOfBirth", employee.DateOfBirth)
            cmd.Parameters.AddWithValue("@Address", employee.Address)
            cmd.Parameters.AddWithValue("@City", employee.City)
            cmd.Parameters.AddWithValue("@Province", employee.Province)
            cmd.Parameters.AddWithValue("@PostalCode", employee.PostalCode)
            cmd.Parameters.AddWithValue("@HomePhone", employee.HomePhone)
            cmd.Parameters.AddWithValue("@CellPhone", employee.CellPhone)
            cmd.Parameters.AddWithValue("@StartDate", employee.StartDate)
            cmd.Parameters.AddWithValue("@SIN", employee.SIN)
            cmd.Parameters.AddWithValue("@HourlyPay", employee.HourlyPay)
            cmd.Parameters.AddWithValue("@Education", employee.Education)
            cmd.Parameters.AddWithValue("@Level", employee.Level)
            cmd.Parameters.AddWithValue("@Status", employee.Status)

            If connect.State <> ConnectionState.Open Then
                connect.Open()
            End If

            cmd.ExecuteNonQuery()

            MsgBox("Employee updated successfully!", MsgBoxStyle.Information, "Success")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error Updating Employee")
        Finally
            If connect.State <> ConnectionState.Closed Then
                connect.Close()
            End If
        End Try
    End Sub

    Public Sub DeleteEmployee(employeeNumber As String)
        Try
            Dim sql As String = "UPDATE users SET status = 'Deleted' WHERE employee_number = @EmployeeNumber"

            Using cmd As New MySqlCommand(sql, connect)
                cmd.Parameters.AddWithValue("@EmployeeNumber", employeeNumber)

                If connect.State <> ConnectionState.Open Then
                    connect.Open()
                End If

                cmd.ExecuteNonQuery()
            End Using

            MsgBox("Employee marked as deleted successfully!", MsgBoxStyle.Information, "Success")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error Deleting Employee")
        Finally
            If connect.State <> ConnectionState.Closed Then
                connect.Close()
            End If
        End Try
    End Sub




    '******************************** UTILITIES ********************************
    Public Function HashPassword(password As String) As String
        ' Create a SHA256 hash object
        Using sha256Hash As SHA256 = SHA256.Create()
            ' ComputeHash - returns byte array
            Dim bytes As Byte() = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password))

            ' Convert byte array to a string
            Dim builder As New StringBuilder()
            For i As Integer = 0 To bytes.Length - 1
                builder.Append(bytes(i).ToString("x2"))
            Next
            Return builder.ToString()
        End Using
    End Function
End Class
