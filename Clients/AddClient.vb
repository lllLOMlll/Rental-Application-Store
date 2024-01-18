Imports System.Text.RegularExpressions

Public Class AddClient
    Private Sub AddClient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Controls.Add(New CommonMenuControl())

        'Display Username and Status
        Label_Display_Username.Text = Globals.Username
        Label_Display_Access_Level.Text = Globals.AccessLevel

        'Format Age TextBox
        TextBox_Age.Text = ""

        'Set DOB to 2010/01/01
        DateTimePicker_DOB.Value = New DateTime(2010, 1, 1)

        'Adding Handler to control the input of the user in certain fields
        AddHandler TextBox_Cell_Phone.KeyPress, AddressOf TextBox_Cell_Phone_KeyPress

    End Sub

    Private Sub Button_Add_Client_Click(sender As Object, e As EventArgs) Handles Button_Add_Client.Click
        ' Retrieve values from form controls
        Dim clientNumber As String = GenerateClientNumber()
        Dim firstName As String = TextBox_First_Name.Text
        Dim lastName As String = TextBox_Last_Name.Text
        Dim email As String = TextBox_Email.Text
        Dim phone As String = TextBox_Cell_Phone.Text
        Dim dob As Date = DateTimePicker_DOB.Value
        Dim address As String = TextBox_Address.Text
        Dim city As String = TextBox_City.Text
        Dim province As String = String.Empty
        Dim postalCode As String = TextBox_Postal_Code.Text

        'VALIDATION
        'Firt Name
        If IsFieldEmpty("First Name", firstName) Then Return
        If IsFieldOverCharactersLimit("First Name", firstName, 20) Then Return

        'Last Name
        If IsFieldEmpty("Last Name", lastName) Then Return
        If IsFieldOverCharactersLimit("Last Name", lastName, 20) Then Return


        'Email
        If IsFieldEmpty("Email", email) Then Return
        If Not IsEmailValid(email) Then Return


        'Phone
        If IsFieldEmpty("Cell Phone", phone) Then Return
        If Not IsPhoneNumberValid(phone) Then Return

        'DOB
        Dim minimumAgeDate As Date = DateTime.Now.AddYears(-16)

        If dob > minimumAgeDate Then
            MsgBox("Employee must be at least 16 years old.", MsgBoxStyle.Critical, "Input Error")
            Return
        End If


        'Address
        If IsFieldEmpty("Address", address) Then Return
        If IsFieldOverCharactersLimit("Address", address, 100) Then Return


        'City
        If IsFieldEmpty("City", city) Then Return
        If IsFieldOverCharactersLimit("City", city, 50) Then Return


        'Province
        If ComboBox_Province.SelectedItem IsNot Nothing Then
            province = ComboBox_Province.SelectedItem.ToString()
        Else
            MsgBox("You must select a province", MsgBoxStyle.Critical, "Input Error")
            Return
        End If

        'Postal Code
        If IsFieldEmpty("Postal Code", postalCode) Then Return
        If Not IsValidPostalCode(postalCode) Then Return


        'CREDIT CARD
        ' Retrieve credit card information
        Dim cardType As String = ComboBox_Card_Type.SelectedItem.ToString()
        Dim cardNumber As String = TextBox_Card_Number.Text
        Dim expDate As Date = DateTimePicker_Exp_Date.Value

        ' Validate credit card information
        If String.IsNullOrWhiteSpace(cardType) Then
            MsgBox("Card type cannot be empty", MsgBoxStyle.Critical, "Input Error")
            Return
        End If

        If String.IsNullOrWhiteSpace(cardNumber) OrElse Not IsCardNumberValid(cardNumber) Then
            MsgBox("Invalid card number", MsgBoxStyle.Critical, "Input Error")
            Return
        End If

        If expDate < Date.Today Then
            MsgBox("Expiration date cannot be in the past", MsgBoxStyle.Critical, "Input Error")
            Return
        End If

        ' Add client to the database
        Dim dbManagerClient As New DBManagerClient()

        ' Create an instance of DBManagerClient and add the client
        Dim newClient As New Client()
        newClient.ClientNumber = clientNumber
        newClient.FirstName = TextBox_First_Name.Text
        newClient.LastName = TextBox_Last_Name.Text
        newClient.Email = TextBox_Email.Text
        newClient.Phone = TextBox_Cell_Phone.Text
        newClient.DateOfBirth = DateTimePicker_DOB.Value
        newClient.Address = TextBox_Address.Text
        newClient.City = TextBox_City.Text
        newClient.Province = ComboBox_Province.SelectedItem.ToString()
        newClient.PostalCode = TextBox_Postal_Code.Text

        ' Add client to the database     
        dbManagerClient.AddClient(newClient)

        ' Add credit card information to the database  
        ' Create a new CreditCard object
        Dim newCreditCard As New CreditCard()
        newCreditCard.ClientNumber = clientNumber
        newCreditCard.CardType = ComboBox_Card_Type.SelectedItem.ToString()
        newCreditCard.Number = TextBox_Card_Number.Text
        newCreditCard.ExpDate = DateTimePicker_Exp_Date.Value

        ' Add credit card to the database
        Dim dbManagerCreditCard As New DbManagerCreditCard()
        dbManagerCreditCard.AddCreditCard(newCreditCard)

        MsgBox($"{firstName} {lastName} have beed had successfully to the database", MsgBoxStyle.Information, "New client")

        'Redirect to the Dasboard
        ShowSelectedForm(Me, New Dashboard)

    End Sub


    Private Function GenerateClientNumber() As String
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



    Private Function IsValidPostalCode(postalCode As String) As Boolean
        Dim pattern As String = "^[A-Za-z]\d[A-Za-z] \d[A-Za-z]\d$"
        Dim regex As New Regex(pattern)

        If regex.IsMatch(postalCode) Then
            Return True
        End If
        MsgBox("The Postal Code must be that format : X1X 1X1", MsgBoxStyle.Critical, "Input Error")
        Return False
    End Function

    Private Function IsEmailValid(email As String) As Boolean
        ' Regex pattern for email
        Dim pattern As String = "^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$"
        Dim regex As New Regex(pattern)

        If Not regex.IsMatch(email) Then
            MsgBox("Please enter a valid email address.", MsgBoxStyle.Critical, "Validation Error")
            Return False
        End If
        Return True
    End Function

    Private Function IsCardNumberValid(number As String) As Boolean
        Return number.Length >= 13 AndAlso number.Length <= 19 ' Most card numbers are between 13 and 19 digits
    End Function

    'Display the age of the client
    Private Sub DateTimePicker_DOB_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker_DOB.ValueChanged
        UpdateAge()
    End Sub

    Private Sub UpdateAge()
        Dim birthday As Date = DateTimePicker_DOB.Value
        Dim today As Date = Date.Today
        Dim age As Integer = today.Year - birthday.Year

        ' Adjust for cases where the birthday has not occurred yet this year
        If (birthday > today.AddYears(-age)) Then
            age -= 1
        End If

        TextBox_Age.Text = age.ToString()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ShowSelectedForm(Me, New Dashboard)
    End Sub


End Class