Imports System.Text.RegularExpressions
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class EditClient
    Private Sub EditClient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        ' Instance of the DBManagerClient
        Dim dbManagerClient As New DBManagerClient()
        Dim dbManagerCreditCard As New DbManagerCreditCard()

        ' Get the Client object using the client number
        Dim client As Client = dbManagerClient.GetClientByClientNumber(Globals.ClientNumber)
        Dim creditCard As CreditCard = dbManagerCreditCard.GetCreditCardByClientNumber(Globals.ClientNumber)

        ' Attribute each property of the Client object to variables
        Dim clientNumber As String = client.ClientNumber
        Dim firstName As String = client.FirstName
        Dim lastName As String = client.LastName
        Dim email As String = client.Email
        Dim phone As String = client.Phone
        Dim dob As Date = client.DateOfBirth
        Dim address As String = client.Address
        Dim city As String = client.City
        Dim province As String = client.Province
        Dim postalCode As String = client.PostalCode
        Dim status As Integer = client.Status

        ' Fill the input boxes with the values of the object Client
        TextBox_First_Name.Text = firstName
        TextBox_Last_Name.Text = lastName
        TextBox_Email.Text = email
        TextBox_Cell_Phone.Text = phone
        DateTimePicker_DOB.Value = dob
        TextBox_Address.Text = address
        TextBox_City.Text = city
        ComboBox_Province.SelectedItem = province
        TextBox_Postal_Code.Text = postalCode
        Select Case status
            Case 0
                ComboBox_Status.SelectedIndex = 0
            Case 1
                ComboBox_Status.SelectedIndex = 1
            Case 2
                ComboBox_Status.SelectedIndex = 2
            Case 3
                ComboBox_Status.SelectedIndex = 3
            Case Else
                ComboBox_Status.SelectedIndex = -1
        End Select

        'BECAUSE I HAD PROBLEM WITH THIS LINE (DateTimePicker_Exp_Date.Value = creditCard.ExpDate)     
        DateTimePicker_Exp_Date.MinDate = New DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day)

        'Check if the client got a rented movie (if so, cannot update the status)
        Dim dbManagerRent As New DbManagerRent()
        If dbManagerRent.HasOutstandingRentals(clientNumber) Then
            MessageBox.Show("This client has a rentals and cannot have their status changed.", "Operation Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ComboBox_Status.Enabled = False
        End If

        ' Fill credit card information
        If creditCard IsNot Nothing AndAlso creditCard.ExpDate <> Date.MinValue Then
            ComboBox_Card_Type.SelectedItem = creditCard.CardType
            TextBox_Card_Number.Text = creditCard.Number
            DateTimePicker_Exp_Date.Value = creditCard.ExpDate
        Else
            ' Handle the case when there is no credit card or the expiration date is not set      
            DateTimePicker_Exp_Date.Value = DateTimePicker_Exp_Date.MinDate
        End If

    End Sub



    Private Sub Button_Edit_Client_Click(sender As Object, e As EventArgs) Handles Button_Edit_Client.Click
        Dim dbManagerClient As New DBManagerClient()
        Dim client As Client = dbManagerClient.GetClientByClientNumber(Globals.ClientNumber)
        ' Retrieve values from form controls

        Dim clientNumber As String = client.ClientNumber
        Dim firstName As String = TextBox_First_Name.Text
        Dim lastName As String = TextBox_Last_Name.Text
        Dim email As String = TextBox_Email.Text
        Dim phone As String = TextBox_Cell_Phone.Text
        Dim dob As Date = DateTimePicker_DOB.Value
        Dim address As String = TextBox_Address.Text
        Dim city As String = TextBox_City.Text
        Dim province As String = String.Empty
        Dim postalCode As String = TextBox_Postal_Code.Text
        Dim status As Integer = ComboBox_Status.SelectedIndex

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

        ' Status validation 
        If ComboBox_Status.SelectedIndex = -1 Then
            MessageBox.Show("Status cannot be empty.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        'CREDIT CARD
        ' Retrieve credit card information
        Dim cardType As String = If(ComboBox_Card_Type.SelectedItem IsNot Nothing, ComboBox_Card_Type.SelectedItem.ToString(), String.Empty)
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



        ' Update client in the database          
        Dim clientToUpdate As New Client()

        ' Retrieve values from form controls
        clientToUpdate.ClientNumber = client.ClientNumber
        clientToUpdate.FirstName = TextBox_First_Name.Text
        clientToUpdate.LastName = TextBox_Last_Name.Text
        clientToUpdate.Email = TextBox_Email.Text
        clientToUpdate.Phone = TextBox_Cell_Phone.Text
        clientToUpdate.DateOfBirth = DateTimePicker_DOB.Value
        clientToUpdate.Address = TextBox_Address.Text
        clientToUpdate.City = TextBox_City.Text
        clientToUpdate.Province = ComboBox_Province.SelectedItem.ToString()
        clientToUpdate.PostalCode = TextBox_Postal_Code.Text
        clientToUpdate.Status = ComboBox_Status.SelectedIndex


        dbManagerClient.UpdateClient(clientToUpdate)


        ' Update or Add credit card information in the database
        ' Create a new CreditCard object
        Dim creditCard As New CreditCard()
        creditCard.ClientNumber = clientNumber
        creditCard.CardType = ComboBox_Card_Type.SelectedItem.ToString()
        creditCard.Number = TextBox_Card_Number.Text
        creditCard.ExpDate = DateTimePicker_Exp_Date.Value

        Dim dbManagerCreditCard As New DbManagerCreditCard()

        If dbManagerCreditCard.CreditCardExists(clientNumber) Then
            ' Update the existing credit card
            dbManagerCreditCard.UpdateCreditCard(creditCard)
        Else
            ' Add a new credit card
            dbManagerCreditCard.AddCreditCard(creditCard)
        End If


        MsgBox($"{firstName} {lastName} and their credit card information have been updated successfully.", MsgBoxStyle.Information, "Client Updated")

        ' Redirect to the Dashboard
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
        Return number.Length >= 13 AndAlso number.Length <= 19
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

    Private Sub Button_Dashboard_Click(sender As Object, e As EventArgs) Handles Button_Dashboard.Click
        ShowSelectedForm(Me, New Dashboard)
    End Sub
End Class