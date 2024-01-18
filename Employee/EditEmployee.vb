Imports Google.Protobuf.WellKnownTypes
Imports System.Text.RegularExpressions


Public Class EditEmployee

    Private Sub EditEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Controls.Add(New CommonMenuControl())

        'Colors
        Me.BackColor = Globals.BackgroundCustomColor


        ' Instance of the DbManagerEmployee
        Dim dbManager As New DbManagerEmployee

        ' Get the Employee object using the employee number
        Dim employee As Employee = dbManager.GetUserByEmployeeNumber(Globals.EmployeeNumberEdit)

        ' Attribute each property of the Employee object to variables
        Dim employeeNumber As String = employee.EmployeeNumber
        Dim username As String = employee.Username
        Dim firstName As String = employee.FirstName
        Dim lastName As String = employee.LastName
        Dim dateOfBirth As Date = employee.DateOfBirth
        Dim address As String = employee.Address
        Dim city As String = employee.City
        Dim province As String = employee.Province
        Dim postalCode As String = employee.PostalCode
        Dim homePhone As String = employee.HomePhone
        Dim cellPhone As String = employee.CellPhone
        Dim startDate As Date = employee.StartDate
        Dim sin As String = employee.SIN
        Dim hourlyPay As Double = employee.HourlyPay
        Dim education As String = employee.Education
        Dim level As String = employee.Level
        Dim status As String = employee.Status


        ' Fill the input box with the value of the object Employee
        TextBox_Username.Text = username
        TextBox_First_Name.Text = firstName
        TextBox_Last_Name.Text = lastName
        DateTimePicker_DOB.Value = dateOfBirth
        TextBox_Address.Text = address
        TextBox_City.Text = city
        ComboBox_Province.SelectedItem = province.ToString
        TextBox_Postal_Code.Text = postalCode
        TextBox_Home_Phone.Text = homePhone
        TextBox_Cell_Phone.Text = cellPhone
        DateTimePicker_Starting_Date.Value = startDate
        TextBox_SID_Number.Text = sin
        TextBox_Salary.Text = hourlyPay
        ComboBox_Education.SelectedItem = education.ToString
        ComboBox_Access_Level.SelectedItem = level.ToString
        ComboBox_Status.SelectedItem = status.ToString


        'Display Username and Status
        Label_Display_Username.Text = Globals.Username
        Label_Display_Access_Level.Text = Globals.AccessLevel


        'Only Admin can edit Status, Access Level, Password, Username
        If Not Globals.AccessLevel = "Admin" Then
            ComboBox_Status.Enabled = False
            ComboBox_Access_Level.Enabled = False
            TextBox_Username.Enabled = False
            TextBox_Password.Enabled = False
        End If


        'Adding Handler to control the input of the user in certain fields
        AddHandler TextBox_Cell_Phone.KeyPress, AddressOf TextBox_Cell_Phone_KeyPress
        AddHandler TextBox_Home_Phone.KeyPress, AddressOf TextBox_Home_Phone_KeyPress
        AddHandler TextBox_SID_Number.KeyPress, AddressOf TextBox_SID_Number_KeyPress
        AddHandler TextBox_Salary.KeyPress, AddressOf TextBox_Salary_KeyPress




    End Sub

    Private Sub Button_Add_User_Click(sender As Object, e As EventArgs) Handles Button_Edit.Click
        ' Assert that the form is invalid
        Dim isFormValid = False

        ' Retrieve values from your form controls with proper validation
        Dim firstName As String = TextBox_First_Name.Text
        Dim lastName As String = TextBox_Last_Name.Text
        Dim address As String = TextBox_Address.Text
        Dim dateOfBirth As Date = DateTimePicker_DOB.Value
        Dim cellPhone As String = TextBox_Cell_Phone.Text
        Dim city As String = TextBox_City.Text
        Dim postalCode As String = TextBox_Postal_Code.Text
        Dim homePhone As String = TextBox_Home_Phone.Text
        Dim province As String = ComboBox_Province.SelectedItem.ToString()
        Dim sin As String = TextBox_SID_Number.Text
        Dim startDate As Date = DateTimePicker_Starting_Date.Value
        Dim hourlyPay As Double
        Dim education As String = String.Empty
        Dim level As String = String.Empty
        Dim status As String = String.Empty
        Dim username As String = TextBox_Username.Text
        Dim password As String = TextBox_Password.Text

        'VALIDATION
        ' First Name
        If IsFieldEmpty("First Name", firstName) Then Return
        If IsFieldOverCharactersLimit("First Name", firstName, 20) Then Return


        ' Last Name
        If IsFieldEmpty("Last Name", lastName) Then Return
        If IsFieldOverCharactersLimit("Last Name", lastName, 20) Then Return

        ' Address
        If IsFieldEmpty("Address", address) Then Return
        If IsFieldOverCharactersLimit("Address", address, 100) Then Return

        ' DOB
        Dim minimumAgeDate As Date = DateTime.Now.AddYears(-16)

        If dateOfBirth > minimumAgeDate Then
            MsgBox("Employee must be at least 16 years old.", MsgBoxStyle.Critical, "Input Error")
            Return
        End If

        ' Cell Phone
        If IsFieldEmpty("Cell Phone", cellPhone) Then Return
        If Not IsPhoneNumberValid(cellPhone) Then Return

        ' City
        If IsFieldEmpty("City", city) Then Return
        If IsFieldOverCharactersLimit("City", city, 50) Then Return

        ' Postal Code
        If IsFieldEmpty("Postal Code", postalCode) Then Return
        If Not IsValidPostalCode(postalCode) Then Return

        ' Home Phone
        If IsFieldEmpty("Home Phone", homePhone) Then Return
        If Not IsPhoneNumberValid(homePhone) Then Return

        ' Province
        If IsFieldEmpty("Province", province) Then Return

        ' SIN
        If IsFieldEmpty("SIN", sin) Then Return
        If Not IsSINValid(sin) Then Return

        ' Start Date


        ' Hourly Pay
        If IsFieldEmpty("Hourly Pay", hourlyPay) Then Return

        If Not Double.TryParse(TextBox_Salary.Text, hourlyPay) Then
            MsgBox("Invalid salary input.", MsgBoxStyle.Critical, "Input Error")
            Return
        End If

        If hourlyPay < 15.25 OrElse hourlyPay >= 50 Then
            MsgBox("Hourly pas must be between 15.25$ and 50.00$", MsgBoxStyle.Critical, "Input Error")
            Return
        End If

        ' Education
        If ComboBox_Education.SelectedItem IsNot Nothing Then
            education = ComboBox_Education.SelectedItem.ToString()
        Else
            MsgBox("You must select an item in the dropdown education", MsgBoxStyle.Critical, "Input Error")
            Return
        End If

        ' Username
        If IsFieldEmpty("Username", username) Then Return
        If IsFieldOverCharactersLimit("Username", username, 16) Then Return

        ' Acess Level
        If ComboBox_Access_Level.SelectedItem IsNot Nothing Then
            level = ComboBox_Access_Level.SelectedItem.ToString()
        Else
            MsgBox("One or more dropdown selections are missing.", MsgBoxStyle.Critical, "Input Error")
            Return
        End If

        ' Status
        If ComboBox_Access_Level.SelectedItem IsNot Nothing Then
            status = ComboBox_Status.SelectedItem.ToString()
        Else
            MsgBox("One or more dropdown selections are missing.", MsgBoxStyle.Critical, "Input Error")
            Return
        End If

        'Password

        ' If all validation are passed
        isFormValid = True

        If isFormValid Then
            If Not String.IsNullOrEmpty(password) Then
                ' Create an instance of DbManagerEmployee
                Dim dbManager As New DbManagerEmployee()

                ' Password
                Dim hashedPassword As String = dbManager.HashPassword(password)
                dbManager.ChangePassword(username, hashedPassword)
            End If

            ' Update the employee
            Try
                Dim employeeToUpdate As New Employee()

                employeeToUpdate.EmployeeNumber = Globals.EmployeeNumberEdit
                employeeToUpdate.Username = TextBox_Username.Text
                employeeToUpdate.FirstName = TextBox_First_Name.Text
                employeeToUpdate.LastName = TextBox_Last_Name.Text
                employeeToUpdate.DateOfBirth = DateTimePicker_DOB.Value
                employeeToUpdate.Address = TextBox_Address.Text
                employeeToUpdate.City = TextBox_City.Text
                employeeToUpdate.Province = ComboBox_Province.Text
                employeeToUpdate.PostalCode = TextBox_Postal_Code.Text
                employeeToUpdate.HomePhone = TextBox_Home_Phone.Text
                employeeToUpdate.CellPhone = TextBox_Cell_Phone.Text
                employeeToUpdate.StartDate = DateTimePicker_Starting_Date.Value
                employeeToUpdate.SIN = TextBox_SID_Number.Text
                employeeToUpdate.HourlyPay = Double.Parse(TextBox_Salary.Text)
                employeeToUpdate.Education = ComboBox_Education.SelectedItem.ToString()
                employeeToUpdate.Level = ComboBox_Access_Level.SelectedItem.ToString()
                employeeToUpdate.Status = ComboBox_Status.SelectedItem.ToString()

                ' Create an instance of DbManagerEmployee and update the employee
                Dim dbManager As New DbManagerEmployee()
                dbManager.UpdateEmployee(employeeToUpdate)


                ' Back to Dashboard
                ShowSelectedForm(Me, New Dashboard)
            Catch ex As Exception
                MsgBox("An error occurred: " & ex.Message, MsgBoxStyle.Critical, "Error Updating Employee")
            End Try
        End If
    End Sub



    ' *************************** FUNCTIONS***************************
    Private Function GenerateEmployeeNumber() As String
        'The number of the employee is the currentTime
        Return Now.ToString("yyyyMMddHHmmssfff")
    End Function

    'VALIDATION
    Private Function IsFieldEmpty(fieldName As String, fieldValue As String) As Boolean
        If String.IsNullOrWhiteSpace(fieldValue) Then
            MsgBox(fieldName & " cannot be empty", MsgBoxStyle.Critical, "Input Error")
            Return True
        End If
        Return False
    End Function

    Private Function IsFieldOverCharactersLimit(fieldName As String, fieldValue As String, charNum As Integer) As Boolean
        If fieldValue.Length > charNum Then
            MsgBox($"{fieldName} must be {charNum} characters or less", MsgBoxStyle.Critical, "Input Error")
            Return True
        End If
        Return False
    End Function

    Private Function IsPhoneNumberValid(phoneNumber As String) As Boolean
        ' Regex pattern for phone number format xxx-xxx-xxxx
        Dim pattern As String = "^\d{3}-\d{3}-\d{4}$"
        Dim regex As New Regex(pattern)

        If Not regex.IsMatch(phoneNumber) Then
            MsgBox("Phone number must be in the format xxx-xxx-xxxx.", MsgBoxStyle.Critical, "Validation Error")
            Return False
        End If
        Return True
    End Function

    Private Function IsSINValid(sin As String) As Boolean
        ' Regex pattern for SIN format XXX XXX XXX
        Dim pattern As String = "^\d{3} \d{3} \d{3}$"
        Dim regex As New Regex(pattern)

        If Not regex.IsMatch(sin) Then
            MsgBox("SIN must be in the format XXX XXX XXX.", MsgBoxStyle.Critical, "Validation Error")
            Return False
        End If
        Return True
    End Function


    ' KEY PRESS
    ' Cell phone (only digits and "-")
    Private Sub TextBox_Cell_Phone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_Cell_Phone.KeyPress
        ' Allow digits, hyphen, backspace, and control characters
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "-"c AndAlso e.KeyChar <> ControlChars.Back Then
            ' Ignore the character (don't add it to the TextBox)
            e.Handled = True
        End If
    End Sub

    ' Home Phone (only digits and "-")
    Private Sub TextBox_Home_Phone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_Home_Phone.KeyPress
        ' Allow digits, hyphen, backspace, and control characters
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "-"c AndAlso e.KeyChar <> ControlChars.Back Then
            ' Ignore the character (don't add it to the TextBox)
            e.Handled = True
        End If
    End Sub

    ' SIN (only digits)
    Private Sub TextBox_SID_Number_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_SID_Number.KeyPress
        ' Allow only digit, control characters, and space
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso e.KeyChar <> " "c Then
            e.Handled = True ' Ignore the character (don't add it to the TextBox)
        End If
    End Sub

    ' Salary (digits only and "." and only 2 digits after the ".")
    Private Sub TextBox_Salary_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_Salary.KeyPress
        ' Allow only digit, control characters, and one decimal point
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            If e.KeyChar = "."c AndAlso TextBox_Salary.Text.IndexOf(".") = -1 Then
                ' Allow decimal point if it hasn't been entered yet
            Else
                e.Handled = True ' Ignore the character (don't add it to the TextBox)
            End If
        End If

        ' Check if there is already a decimal point
        If TextBox_Salary.Text.Contains(".") AndAlso TextBox_Salary.Text.Substring(TextBox_Salary.Text.IndexOf(".") + 1).Length >= 2 AndAlso Not Char.IsControl(e.KeyChar) Then
            ' If there are already two digits after the decimal point, ignore further digit input
            If TextBox_Salary.SelectionStart > TextBox_Salary.Text.IndexOf(".") Then
                e.Handled = True
            End If
        End If
    End Sub


    Private Function IsValidPostalCode(postalCode As String) As Boolean
        Dim pattern As String = "^[A-Za-z]\d[A-Za-z] \d[A-Za-z]\d$"
        Dim regex As New Regex(pattern)

        If regex.IsMatch(postalCode) Then
            Return True
        End If
        MsgBox("The Postal Code must be that format : X1X 1X1", MsgBoxStyle.Critical, "Input Error")
        Return False
    End Function

    Private Sub Button_Dashboard_Click(sender As Object, e As EventArgs) Handles Button_Dashboard.Click
        ShowSelectedForm(Me, New Dashboard)
    End Sub
End Class
