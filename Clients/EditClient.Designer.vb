<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EditClient
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label_Title = New Label()
        Label_Username = New Label()
        Label_Access_Level = New Label()
        Label_Display_Username = New Label()
        Label_Display_Access_Level = New Label()
        Label_First_Name = New Label()
        TextBox_First_Name = New TextBox()
        Label_Last_Name = New Label()
        TextBox_Last_Name = New TextBox()
        Label_Email = New Label()
        TextBox_Email = New TextBox()
        TextBox_Cell_Phone = New TextBox()
        Label_Cell_Phone = New Label()
        DateTimePicker_DOB = New DateTimePicker()
        Label_DOB = New Label()
        TextBox_Address = New TextBox()
        Label_Address = New Label()
        TextBox_City = New TextBox()
        Label_City = New Label()
        ComboBox_Province = New ComboBox()
        Label_Province = New Label()
        TextBox_Postal_Code = New TextBox()
        Label_Postal_Code = New Label()
        Label_Age = New Label()
        TextBox_Age = New TextBox()
        Label_Credit_Card = New Label()
        Label_Card_Type = New Label()
        ComboBox_Card_Type = New ComboBox()
        Label_Card_Number = New Label()
        TextBox_Card_Number = New TextBox()
        Label_Expiration_Date = New Label()
        DateTimePicker_Exp_Date = New DateTimePicker()
        Button_Edit_Client = New Button()
        Button_Clear = New Button()
        ComboBox_Status = New ComboBox()
        Label_Status = New Label()
        Button_Dashboard = New Button()
        SuspendLayout()
        ' 
        ' Label_Title
        ' 
        Label_Title.AutoSize = True
        Label_Title.Font = New Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point)
        Label_Title.ForeColor = Color.FromArgb(CByte(245), CByte(200), CByte(35))
        Label_Title.Location = New Point(66, 58)
        Label_Title.Name = "Label_Title"
        Label_Title.Size = New Size(262, 65)
        Label_Title.TabIndex = 0
        Label_Title.Text = "Edit Client"
        ' 
        ' Label_Username
        ' 
        Label_Username.AutoSize = True
        Label_Username.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label_Username.ForeColor = SystemColors.ButtonHighlight
        Label_Username.Location = New Point(968, 58)
        Label_Username.Name = "Label_Username"
        Label_Username.Size = New Size(88, 21)
        Label_Username.TabIndex = 3
        Label_Username.Text = "Username :"
        ' 
        ' Label_Access_Level
        ' 
        Label_Access_Level.AutoSize = True
        Label_Access_Level.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label_Access_Level.ForeColor = SystemColors.ButtonHighlight
        Label_Access_Level.Location = New Point(953, 93)
        Label_Access_Level.Name = "Label_Access_Level"
        Label_Access_Level.Size = New Size(103, 21)
        Label_Access_Level.TabIndex = 4
        Label_Access_Level.Text = "Access Level :"
        ' 
        ' Label_Display_Username
        ' 
        Label_Display_Username.AutoSize = True
        Label_Display_Username.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label_Display_Username.ForeColor = Color.FromArgb(CByte(245), CByte(200), CByte(35))
        Label_Display_Username.Location = New Point(1062, 58)
        Label_Display_Username.Name = "Label_Display_Username"
        Label_Display_Username.Size = New Size(83, 21)
        Label_Display_Username.TabIndex = 5
        Label_Display_Username.Text = "Username"
        ' 
        ' Label_Display_Access_Level
        ' 
        Label_Display_Access_Level.AutoSize = True
        Label_Display_Access_Level.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label_Display_Access_Level.ForeColor = Color.FromArgb(CByte(245), CByte(200), CByte(35))
        Label_Display_Access_Level.Location = New Point(1062, 93)
        Label_Display_Access_Level.Name = "Label_Display_Access_Level"
        Label_Display_Access_Level.Size = New Size(102, 21)
        Label_Display_Access_Level.TabIndex = 6
        Label_Display_Access_Level.Text = "Access Level"
        ' 
        ' Label_First_Name
        ' 
        Label_First_Name.AutoSize = True
        Label_First_Name.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label_First_Name.ForeColor = SystemColors.ButtonHighlight
        Label_First_Name.Location = New Point(75, 162)
        Label_First_Name.Name = "Label_First_Name"
        Label_First_Name.Size = New Size(88, 21)
        Label_First_Name.TabIndex = 7
        Label_First_Name.Text = "First Name"
        ' 
        ' TextBox_First_Name
        ' 
        TextBox_First_Name.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox_First_Name.Location = New Point(169, 162)
        TextBox_First_Name.Name = "TextBox_First_Name"
        TextBox_First_Name.Size = New Size(312, 29)
        TextBox_First_Name.TabIndex = 1
        ' 
        ' Label_Last_Name
        ' 
        Label_Last_Name.AutoSize = True
        Label_Last_Name.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label_Last_Name.ForeColor = SystemColors.ButtonHighlight
        Label_Last_Name.Location = New Point(77, 212)
        Label_Last_Name.Name = "Label_Last_Name"
        Label_Last_Name.Size = New Size(86, 21)
        Label_Last_Name.TabIndex = 9
        Label_Last_Name.Text = "Last Name"
        ' 
        ' TextBox_Last_Name
        ' 
        TextBox_Last_Name.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox_Last_Name.Location = New Point(169, 212)
        TextBox_Last_Name.Name = "TextBox_Last_Name"
        TextBox_Last_Name.Size = New Size(312, 29)
        TextBox_Last_Name.TabIndex = 2
        ' 
        ' Label_Email
        ' 
        Label_Email.AutoSize = True
        Label_Email.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label_Email.ForeColor = SystemColors.ButtonHighlight
        Label_Email.Location = New Point(115, 263)
        Label_Email.Name = "Label_Email"
        Label_Email.Size = New Size(48, 21)
        Label_Email.TabIndex = 11
        Label_Email.Text = "Email"
        ' 
        ' TextBox_Email
        ' 
        TextBox_Email.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox_Email.Location = New Point(169, 263)
        TextBox_Email.Name = "TextBox_Email"
        TextBox_Email.Size = New Size(312, 29)
        TextBox_Email.TabIndex = 3
        ' 
        ' TextBox_Cell_Phone
        ' 
        TextBox_Cell_Phone.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox_Cell_Phone.Location = New Point(169, 308)
        TextBox_Cell_Phone.Name = "TextBox_Cell_Phone"
        TextBox_Cell_Phone.PlaceholderText = "XXX-XXX-XXXX"
        TextBox_Cell_Phone.Size = New Size(205, 29)
        TextBox_Cell_Phone.TabIndex = 4
        ' 
        ' Label_Cell_Phone
        ' 
        Label_Cell_Phone.AutoSize = True
        Label_Cell_Phone.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label_Cell_Phone.ForeColor = SystemColors.ButtonHighlight
        Label_Cell_Phone.Location = New Point(85, 308)
        Label_Cell_Phone.Name = "Label_Cell_Phone"
        Label_Cell_Phone.Size = New Size(78, 20)
        Label_Cell_Phone.TabIndex = 14
        Label_Cell_Phone.Text = "Cellphone"
        Label_Cell_Phone.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' DateTimePicker_DOB
        ' 
        DateTimePicker_DOB.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        DateTimePicker_DOB.Location = New Point(169, 355)
        DateTimePicker_DOB.Name = "DateTimePicker_DOB"
        DateTimePicker_DOB.Size = New Size(205, 29)
        DateTimePicker_DOB.TabIndex = 5
        ' 
        ' Label_DOB
        ' 
        Label_DOB.AutoSize = True
        Label_DOB.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label_DOB.ForeColor = SystemColors.ButtonHighlight
        Label_DOB.Location = New Point(115, 355)
        Label_DOB.Name = "Label_DOB"
        Label_DOB.Size = New Size(40, 20)
        Label_DOB.TabIndex = 16
        Label_DOB.Text = "DOB"
        Label_DOB.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' TextBox_Address
        ' 
        TextBox_Address.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox_Address.Location = New Point(802, 159)
        TextBox_Address.Name = "TextBox_Address"
        TextBox_Address.Size = New Size(362, 29)
        TextBox_Address.TabIndex = 6
        ' 
        ' Label_Address
        ' 
        Label_Address.AutoSize = True
        Label_Address.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label_Address.ForeColor = SystemColors.ButtonHighlight
        Label_Address.Location = New Point(733, 162)
        Label_Address.Name = "Label_Address"
        Label_Address.Size = New Size(63, 20)
        Label_Address.TabIndex = 18
        Label_Address.Text = "Address"
        Label_Address.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' TextBox_City
        ' 
        TextBox_City.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox_City.Location = New Point(802, 209)
        TextBox_City.Name = "TextBox_City"
        TextBox_City.Size = New Size(362, 29)
        TextBox_City.TabIndex = 7
        ' 
        ' Label_City
        ' 
        Label_City.AutoSize = True
        Label_City.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label_City.ForeColor = SystemColors.ButtonHighlight
        Label_City.Location = New Point(761, 209)
        Label_City.Name = "Label_City"
        Label_City.Size = New Size(35, 20)
        Label_City.TabIndex = 20
        Label_City.Text = "City"
        Label_City.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' ComboBox_Province
        ' 
        ComboBox_Province.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ComboBox_Province.FormattingEnabled = True
        ComboBox_Province.Items.AddRange(New Object() {"AB", "BC", "MB", "NB", "NL", "NS", "ON", "PE", "QC", "SK", "NT", "NU", "YT"})
        ComboBox_Province.Location = New Point(802, 263)
        ComboBox_Province.Name = "ComboBox_Province"
        ComboBox_Province.Size = New Size(201, 29)
        ComboBox_Province.TabIndex = 8
        ' 
        ' Label_Province
        ' 
        Label_Province.AutoSize = True
        Label_Province.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label_Province.ForeColor = SystemColors.ButtonHighlight
        Label_Province.Location = New Point(727, 263)
        Label_Province.Name = "Label_Province"
        Label_Province.Size = New Size(69, 20)
        Label_Province.TabIndex = 22
        Label_Province.Text = "Province"
        Label_Province.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' TextBox_Postal_Code
        ' 
        TextBox_Postal_Code.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox_Postal_Code.Location = New Point(802, 308)
        TextBox_Postal_Code.Name = "TextBox_Postal_Code"
        TextBox_Postal_Code.PlaceholderText = "X1X 1X1"
        TextBox_Postal_Code.Size = New Size(201, 29)
        TextBox_Postal_Code.TabIndex = 9
        ' 
        ' Label_Postal_Code
        ' 
        Label_Postal_Code.AutoSize = True
        Label_Postal_Code.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label_Postal_Code.ForeColor = SystemColors.ButtonHighlight
        Label_Postal_Code.Location = New Point(708, 312)
        Label_Postal_Code.Name = "Label_Postal_Code"
        Label_Postal_Code.Size = New Size(88, 20)
        Label_Postal_Code.TabIndex = 24
        Label_Postal_Code.Text = "Postal Code"
        Label_Postal_Code.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label_Age
        ' 
        Label_Age.AutoSize = True
        Label_Age.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label_Age.ForeColor = SystemColors.ButtonHighlight
        Label_Age.Location = New Point(760, 351)
        Label_Age.Name = "Label_Age"
        Label_Age.Size = New Size(36, 20)
        Label_Age.TabIndex = 25
        Label_Age.Text = "Age"
        Label_Age.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' TextBox_Age
        ' 
        TextBox_Age.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox_Age.Location = New Point(802, 351)
        TextBox_Age.Name = "TextBox_Age"
        TextBox_Age.Size = New Size(71, 29)
        TextBox_Age.TabIndex = 26
        ' 
        ' Label_Credit_Card
        ' 
        Label_Credit_Card.AutoSize = True
        Label_Credit_Card.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label_Credit_Card.ForeColor = Color.FromArgb(CByte(245), CByte(200), CByte(35))
        Label_Credit_Card.Location = New Point(77, 453)
        Label_Credit_Card.Name = "Label_Credit_Card"
        Label_Credit_Card.Size = New Size(163, 37)
        Label_Credit_Card.TabIndex = 28
        Label_Credit_Card.Text = "Credit Card"
        ' 
        ' Label_Card_Type
        ' 
        Label_Card_Type.AutoSize = True
        Label_Card_Type.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label_Card_Type.ForeColor = SystemColors.ButtonHighlight
        Label_Card_Type.Location = New Point(90, 505)
        Label_Card_Type.Name = "Label_Card_Type"
        Label_Card_Type.Size = New Size(83, 21)
        Label_Card_Type.TabIndex = 29
        Label_Card_Type.Text = "Card Type"
        ' 
        ' ComboBox_Card_Type
        ' 
        ComboBox_Card_Type.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ComboBox_Card_Type.FormattingEnabled = True
        ComboBox_Card_Type.Items.AddRange(New Object() {"Visa", "MasterCard", "Discover", "Amex", "Switch", "Solo"})
        ComboBox_Card_Type.Location = New Point(179, 505)
        ComboBox_Card_Type.Name = "ComboBox_Card_Type"
        ComboBox_Card_Type.Size = New Size(201, 29)
        ComboBox_Card_Type.TabIndex = 10
        ' 
        ' Label_Card_Number
        ' 
        Label_Card_Number.AutoSize = True
        Label_Card_Number.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label_Card_Number.ForeColor = SystemColors.ButtonHighlight
        Label_Card_Number.Location = New Point(482, 505)
        Label_Card_Number.Name = "Label_Card_Number"
        Label_Card_Number.Size = New Size(108, 21)
        Label_Card_Number.TabIndex = 31
        Label_Card_Number.Text = "Card Number"
        ' 
        ' TextBox_Card_Number
        ' 
        TextBox_Card_Number.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox_Card_Number.Location = New Point(596, 505)
        TextBox_Card_Number.Name = "TextBox_Card_Number"
        TextBox_Card_Number.PlaceholderText = "XXXX XXXX XXXX XXXX "
        TextBox_Card_Number.Size = New Size(205, 29)
        TextBox_Card_Number.TabIndex = 11
        ' 
        ' Label_Expiration_Date
        ' 
        Label_Expiration_Date.AutoSize = True
        Label_Expiration_Date.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label_Expiration_Date.ForeColor = SystemColors.ButtonHighlight
        Label_Expiration_Date.Location = New Point(854, 505)
        Label_Expiration_Date.Name = "Label_Expiration_Date"
        Label_Expiration_Date.Size = New Size(121, 21)
        Label_Expiration_Date.TabIndex = 33
        Label_Expiration_Date.Text = "Expiration Date"
        ' 
        ' DateTimePicker_Exp_Date
        ' 
        DateTimePicker_Exp_Date.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        DateTimePicker_Exp_Date.Location = New Point(981, 505)
        DateTimePicker_Exp_Date.Name = "DateTimePicker_Exp_Date"
        DateTimePicker_Exp_Date.Size = New Size(205, 29)
        DateTimePicker_Exp_Date.TabIndex = 12
        ' 
        ' Button_Edit_Client
        ' 
        Button_Edit_Client.BackColor = Color.White
        Button_Edit_Client.FlatAppearance.BorderColor = Color.Black
        Button_Edit_Client.FlatAppearance.BorderSize = 4
        Button_Edit_Client.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(245), CByte(200), CByte(35))
        Button_Edit_Client.FlatStyle = FlatStyle.Flat
        Button_Edit_Client.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Button_Edit_Client.ForeColor = Color.Black
        Button_Edit_Client.Location = New Point(77, 624)
        Button_Edit_Client.Name = "Button_Edit_Client"
        Button_Edit_Client.Size = New Size(221, 76)
        Button_Edit_Client.TabIndex = 35
        Button_Edit_Client.Text = "EDIT CLIENT"
        Button_Edit_Client.UseVisualStyleBackColor = False
        ' 
        ' Button_Clear
        ' 
        Button_Clear.BackColor = Color.White
        Button_Clear.FlatAppearance.BorderColor = Color.Black
        Button_Clear.FlatAppearance.BorderSize = 4
        Button_Clear.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(245), CByte(200), CByte(35))
        Button_Clear.FlatStyle = FlatStyle.Flat
        Button_Clear.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Button_Clear.ForeColor = Color.Black
        Button_Clear.Location = New Point(350, 624)
        Button_Clear.Name = "Button_Clear"
        Button_Clear.Size = New Size(221, 76)
        Button_Clear.TabIndex = 36
        Button_Clear.Text = "CLEAR"
        Button_Clear.UseVisualStyleBackColor = False
        ' 
        ' ComboBox_Status
        ' 
        ComboBox_Status.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ComboBox_Status.FormattingEnabled = True
        ComboBox_Status.Items.AddRange(New Object() {" Inactive", " Active", " Deleted"})
        ComboBox_Status.Location = New Point(802, 395)
        ComboBox_Status.Name = "ComboBox_Status"
        ComboBox_Status.Size = New Size(201, 29)
        ComboBox_Status.TabIndex = 38
        ' 
        ' Label_Status
        ' 
        Label_Status.AutoSize = True
        Label_Status.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label_Status.ForeColor = SystemColors.ButtonHighlight
        Label_Status.Location = New Point(746, 395)
        Label_Status.Name = "Label_Status"
        Label_Status.Size = New Size(50, 20)
        Label_Status.TabIndex = 39
        Label_Status.Text = "Status"
        Label_Status.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Button_Dashboard
        ' 
        Button_Dashboard.BackColor = Color.White
        Button_Dashboard.FlatAppearance.BorderColor = Color.Black
        Button_Dashboard.FlatAppearance.BorderSize = 4
        Button_Dashboard.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(245), CByte(200), CByte(35))
        Button_Dashboard.FlatStyle = FlatStyle.Flat
        Button_Dashboard.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Button_Dashboard.ForeColor = Color.Black
        Button_Dashboard.Location = New Point(510, 64)
        Button_Dashboard.Name = "Button_Dashboard"
        Button_Dashboard.Size = New Size(260, 50)
        Button_Dashboard.TabIndex = 40
        Button_Dashboard.Text = "DASHBOARD"
        Button_Dashboard.UseVisualStyleBackColor = False
        ' 
        ' EditClient
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(50), CByte(90), CByte(235))
        ClientSize = New Size(1484, 761)
        Controls.Add(Button_Dashboard)
        Controls.Add(Label_Status)
        Controls.Add(ComboBox_Status)
        Controls.Add(Button_Clear)
        Controls.Add(Button_Edit_Client)
        Controls.Add(DateTimePicker_Exp_Date)
        Controls.Add(Label_Expiration_Date)
        Controls.Add(TextBox_Card_Number)
        Controls.Add(Label_Card_Number)
        Controls.Add(ComboBox_Card_Type)
        Controls.Add(Label_Card_Type)
        Controls.Add(Label_Credit_Card)
        Controls.Add(TextBox_Age)
        Controls.Add(Label_Age)
        Controls.Add(Label_Postal_Code)
        Controls.Add(TextBox_Postal_Code)
        Controls.Add(Label_Province)
        Controls.Add(ComboBox_Province)
        Controls.Add(Label_City)
        Controls.Add(TextBox_City)
        Controls.Add(Label_Address)
        Controls.Add(TextBox_Address)
        Controls.Add(Label_DOB)
        Controls.Add(DateTimePicker_DOB)
        Controls.Add(Label_Cell_Phone)
        Controls.Add(TextBox_Cell_Phone)
        Controls.Add(TextBox_Email)
        Controls.Add(Label_Email)
        Controls.Add(TextBox_Last_Name)
        Controls.Add(Label_Last_Name)
        Controls.Add(TextBox_First_Name)
        Controls.Add(Label_First_Name)
        Controls.Add(Label_Display_Access_Level)
        Controls.Add(Label_Display_Username)
        Controls.Add(Label_Access_Level)
        Controls.Add(Label_Username)
        Controls.Add(Label_Title)
        ForeColor = SystemColors.ButtonHighlight
        Name = "EditClient"
        Text = "EditClient"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label_Title As Label
    Friend WithEvents Label_Username As Label
    Friend WithEvents Label_Access_Level As Label
    Friend WithEvents Label_Display_Username As Label
    Friend WithEvents Label_Display_Access_Level As Label
    Friend WithEvents Label_First_Name As Label
    Friend WithEvents TextBox_First_Name As TextBox
    Friend WithEvents Label_Last_Name As Label
    Friend WithEvents TextBox_Last_Name As TextBox
    Friend WithEvents Label_Email As Label
    Friend WithEvents TextBox_Email As TextBox
    Friend WithEvents TextBox_Cell_Phone As TextBox
    Friend WithEvents Label_Cell_Phone As Label
    Friend WithEvents DateTimePicker_DOB As DateTimePicker
    Friend WithEvents Label_DOB As Label
    Friend WithEvents TextBox_Address As TextBox
    Friend WithEvents Label_Address As Label
    Friend WithEvents TextBox_City As TextBox
    Friend WithEvents Label_City As Label
    Friend WithEvents ComboBox_Province As ComboBox
    Friend WithEvents Label_Province As Label
    Friend WithEvents TextBox_Postal_Code As TextBox
    Friend WithEvents Label_Postal_Code As Label
    Friend WithEvents Label_Age As Label
    Friend WithEvents TextBox_Age As TextBox
    Friend WithEvents Label_Credit_Card As Label
    Friend WithEvents Label_Card_Type As Label
    Friend WithEvents ComboBox_Card_Type As ComboBox
    Friend WithEvents Label_Card_Number As Label
    Friend WithEvents TextBox_Card_Number As TextBox
    Friend WithEvents Label_Expiration_Date As Label
    Friend WithEvents DateTimePicker_Exp_Date As DateTimePicker
    Friend WithEvents Button_Edit_Client As Button
    Friend WithEvents Button_Clear As Button
    Friend WithEvents ComboBox_Status As ComboBox
    Friend WithEvents Label_Status As Label
    Friend WithEvents Button_Dashboard As Button
End Class
