<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateEmployee
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label_Display_Username = New Label()
        Label_Display_Access_Level = New Label()
        Label_Title = New Label()
        Label_First_Name = New Label()
        TextBox_First_Name = New TextBox()
        Label_DOB = New Label()
        Label_Postal_Code = New Label()
        TextBox_Postal_Code = New TextBox()
        Label_Last_Name = New Label()
        TextBox_Last_Name = New TextBox()
        Label_Address = New Label()
        TextBox_Address = New TextBox()
        Label_Cell_Phone = New Label()
        TextBox_Cell_Phone = New TextBox()
        Label_City = New Label()
        TextBox_City = New TextBox()
        Label_Home_Phone = New Label()
        TextBox_Home_Phone = New TextBox()
        Label_Province = New Label()
        Label_Sid_Number = New Label()
        TextBox_SID_Number = New TextBox()
        Label_Starting_Date = New Label()
        Label_Salary = New Label()
        TextBox_Salary = New TextBox()
        Label_Education = New Label()
        Label_Username = New Label()
        TextBox_Username = New TextBox()
        Label_Password = New Label()
        TextBox_Password = New TextBox()
        Label_Access_Level = New Label()
        Label_Status = New Label()
        Button_Add_User = New Button()
        Button_Reset = New Button()
        DateTimePicker_Starting_Date = New DateTimePicker()
        ComboBox_Education = New ComboBox()
        ComboBox_Access_Level = New ComboBox()
        ComboBox_Status = New ComboBox()
        DateTimePicker_DOB = New DateTimePicker()
        Label_Username_Label = New Label()
        Label_Access_Level_Label = New Label()
        ComboBox_Province = New ComboBox()
        Button_Dashboard = New Button()
        SuspendLayout()
        ' 
        ' Label_Display_Username
        ' 
        Label_Display_Username.AutoSize = True
        Label_Display_Username.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label_Display_Username.ForeColor = Color.FromArgb(CByte(245), CByte(200), CByte(35))
        Label_Display_Username.Location = New Point(1147, 51)
        Label_Display_Username.Name = "Label_Display_Username"
        Label_Display_Username.Size = New Size(87, 21)
        Label_Display_Username.TabIndex = 0
        Label_Display_Username.Text = "Username"
        ' 
        ' Label_Display_Access_Level
        ' 
        Label_Display_Access_Level.AutoSize = True
        Label_Display_Access_Level.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label_Display_Access_Level.ForeColor = Color.FromArgb(CByte(245), CByte(200), CByte(35))
        Label_Display_Access_Level.Location = New Point(1147, 86)
        Label_Display_Access_Level.Name = "Label_Display_Access_Level"
        Label_Display_Access_Level.Size = New Size(104, 21)
        Label_Display_Access_Level.TabIndex = 1
        Label_Display_Access_Level.Text = "Access Level"
        ' 
        ' Label_Title
        ' 
        Label_Title.AutoSize = True
        Label_Title.Font = New Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point)
        Label_Title.ForeColor = Color.FromArgb(CByte(245), CByte(200), CByte(35))
        Label_Title.Location = New Point(235, 51)
        Label_Title.Name = "Label_Title"
        Label_Title.Size = New Size(471, 65)
        Label_Title.TabIndex = 2
        Label_Title.Text = "Add New Employee"
        ' 
        ' Label_First_Name
        ' 
        Label_First_Name.AutoSize = True
        Label_First_Name.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label_First_Name.ForeColor = SystemColors.ButtonHighlight
        Label_First_Name.Location = New Point(244, 155)
        Label_First_Name.Name = "Label_First_Name"
        Label_First_Name.Size = New Size(83, 20)
        Label_First_Name.TabIndex = 3
        Label_First_Name.Text = "First Name"
        Label_First_Name.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' TextBox_First_Name
        ' 
        TextBox_First_Name.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox_First_Name.Location = New Point(333, 151)
        TextBox_First_Name.Name = "TextBox_First_Name"
        TextBox_First_Name.Size = New Size(205, 29)
        TextBox_First_Name.TabIndex = 1
        ' 
        ' Label_DOB
        ' 
        Label_DOB.AutoSize = True
        Label_DOB.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label_DOB.ForeColor = SystemColors.ButtonHighlight
        Label_DOB.Location = New Point(285, 212)
        Label_DOB.Name = "Label_DOB"
        Label_DOB.Size = New Size(40, 20)
        Label_DOB.TabIndex = 5
        Label_DOB.Text = "DOB"
        Label_DOB.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label_Postal_Code
        ' 
        Label_Postal_Code.AutoSize = True
        Label_Postal_Code.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label_Postal_Code.ForeColor = SystemColors.ButtonHighlight
        Label_Postal_Code.Location = New Point(239, 260)
        Label_Postal_Code.Name = "Label_Postal_Code"
        Label_Postal_Code.Size = New Size(88, 20)
        Label_Postal_Code.TabIndex = 6
        Label_Postal_Code.Text = "Postal Code"
        Label_Postal_Code.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' TextBox_Postal_Code
        ' 
        TextBox_Postal_Code.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox_Postal_Code.Location = New Point(333, 260)
        TextBox_Postal_Code.Name = "TextBox_Postal_Code"
        TextBox_Postal_Code.PlaceholderText = "X1X 1X1"
        TextBox_Postal_Code.Size = New Size(205, 29)
        TextBox_Postal_Code.TabIndex = 7
        ' 
        ' Label_Last_Name
        ' 
        Label_Last_Name.AutoSize = True
        Label_Last_Name.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label_Last_Name.Location = New Point(614, 147)
        Label_Last_Name.Name = "Label_Last_Name"
        Label_Last_Name.Size = New Size(80, 20)
        Label_Last_Name.TabIndex = 8
        Label_Last_Name.Text = "Last Name"
        Label_Last_Name.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' TextBox_Last_Name
        ' 
        TextBox_Last_Name.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox_Last_Name.Location = New Point(700, 147)
        TextBox_Last_Name.Name = "TextBox_Last_Name"
        TextBox_Last_Name.Size = New Size(205, 29)
        TextBox_Last_Name.TabIndex = 2
        ' 
        ' Label_Address
        ' 
        Label_Address.AutoSize = True
        Label_Address.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label_Address.Location = New Point(992, 143)
        Label_Address.Name = "Label_Address"
        Label_Address.Size = New Size(63, 20)
        Label_Address.TabIndex = 10
        Label_Address.Text = "Address"
        Label_Address.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' TextBox_Address
        ' 
        TextBox_Address.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox_Address.Location = New Point(1061, 143)
        TextBox_Address.Name = "TextBox_Address"
        TextBox_Address.Size = New Size(205, 29)
        TextBox_Address.TabIndex = 3
        ' 
        ' Label_Cell_Phone
        ' 
        Label_Cell_Phone.AutoSize = True
        Label_Cell_Phone.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label_Cell_Phone.Location = New Point(617, 203)
        Label_Cell_Phone.Name = "Label_Cell_Phone"
        Label_Cell_Phone.Size = New Size(78, 20)
        Label_Cell_Phone.TabIndex = 12
        Label_Cell_Phone.Text = "Cellphone"
        Label_Cell_Phone.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' TextBox_Cell_Phone
        ' 
        TextBox_Cell_Phone.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox_Cell_Phone.Location = New Point(701, 203)
        TextBox_Cell_Phone.Name = "TextBox_Cell_Phone"
        TextBox_Cell_Phone.PlaceholderText = "XXX-XXX-XXXX"
        TextBox_Cell_Phone.Size = New Size(205, 29)
        TextBox_Cell_Phone.TabIndex = 5
        ' 
        ' Label_City
        ' 
        Label_City.AutoSize = True
        Label_City.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label_City.Location = New Point(1020, 199)
        Label_City.Name = "Label_City"
        Label_City.Size = New Size(35, 20)
        Label_City.TabIndex = 14
        Label_City.Text = "City"
        Label_City.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' TextBox_City
        ' 
        TextBox_City.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox_City.Location = New Point(1061, 199)
        TextBox_City.Name = "TextBox_City"
        TextBox_City.Size = New Size(205, 29)
        TextBox_City.TabIndex = 6
        ' 
        ' Label_Home_Phone
        ' 
        Label_Home_Phone.AutoSize = True
        Label_Home_Phone.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label_Home_Phone.Location = New Point(597, 256)
        Label_Home_Phone.Name = "Label_Home_Phone"
        Label_Home_Phone.Size = New Size(98, 20)
        Label_Home_Phone.TabIndex = 16
        Label_Home_Phone.Text = "Home Phone"
        Label_Home_Phone.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' TextBox_Home_Phone
        ' 
        TextBox_Home_Phone.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox_Home_Phone.Location = New Point(701, 256)
        TextBox_Home_Phone.Name = "TextBox_Home_Phone"
        TextBox_Home_Phone.PlaceholderText = "XXX-XXX-XXXX"
        TextBox_Home_Phone.Size = New Size(205, 29)
        TextBox_Home_Phone.TabIndex = 8
        ' 
        ' Label_Province
        ' 
        Label_Province.AutoSize = True
        Label_Province.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label_Province.Location = New Point(986, 252)
        Label_Province.Name = "Label_Province"
        Label_Province.Size = New Size(69, 20)
        Label_Province.TabIndex = 18
        Label_Province.Text = "Province"
        Label_Province.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label_Sid_Number
        ' 
        Label_Sid_Number.AutoSize = True
        Label_Sid_Number.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label_Sid_Number.Location = New Point(234, 339)
        Label_Sid_Number.Name = "Label_Sid_Number"
        Label_Sid_Number.Size = New Size(93, 20)
        Label_Sid_Number.TabIndex = 20
        Label_Sid_Number.Text = "SID Number"
        Label_Sid_Number.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' TextBox_SID_Number
        ' 
        TextBox_SID_Number.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox_SID_Number.Location = New Point(333, 339)
        TextBox_SID_Number.Name = "TextBox_SID_Number"
        TextBox_SID_Number.PlaceholderText = "XXX XXX XXX"
        TextBox_SID_Number.Size = New Size(205, 29)
        TextBox_SID_Number.TabIndex = 10
        ' 
        ' Label_Starting_Date
        ' 
        Label_Starting_Date.AutoSize = True
        Label_Starting_Date.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label_Starting_Date.Location = New Point(600, 343)
        Label_Starting_Date.Name = "Label_Starting_Date"
        Label_Starting_Date.Size = New Size(99, 20)
        Label_Starting_Date.TabIndex = 22
        Label_Starting_Date.Text = "Starting Date"
        Label_Starting_Date.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label_Salary
        ' 
        Label_Salary.AutoSize = True
        Label_Salary.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label_Salary.Location = New Point(275, 395)
        Label_Salary.Name = "Label_Salary"
        Label_Salary.Size = New Size(52, 20)
        Label_Salary.TabIndex = 23
        Label_Salary.Text = "Salary"
        Label_Salary.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' TextBox_Salary
        ' 
        TextBox_Salary.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox_Salary.Location = New Point(333, 395)
        TextBox_Salary.Name = "TextBox_Salary"
        TextBox_Salary.Size = New Size(205, 29)
        TextBox_Salary.TabIndex = 12
        ' 
        ' Label_Education
        ' 
        Label_Education.AutoSize = True
        Label_Education.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label_Education.Location = New Point(624, 395)
        Label_Education.Name = "Label_Education"
        Label_Education.Size = New Size(77, 20)
        Label_Education.TabIndex = 25
        Label_Education.Text = "Education"
        Label_Education.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label_Username
        ' 
        Label_Username.AutoSize = True
        Label_Username.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label_Username.Location = New Point(249, 508)
        Label_Username.Name = "Label_Username"
        Label_Username.Size = New Size(78, 20)
        Label_Username.TabIndex = 27
        Label_Username.Text = "Username"
        Label_Username.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' TextBox_Username
        ' 
        TextBox_Username.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox_Username.Location = New Point(333, 508)
        TextBox_Username.Name = "TextBox_Username"
        TextBox_Username.Size = New Size(205, 29)
        TextBox_Username.TabIndex = 14
        ' 
        ' Label_Password
        ' 
        Label_Password.AutoSize = True
        Label_Password.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label_Password.Location = New Point(626, 501)
        Label_Password.Name = "Label_Password"
        Label_Password.Size = New Size(73, 20)
        Label_Password.TabIndex = 29
        Label_Password.Text = "Password"
        Label_Password.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' TextBox_Password
        ' 
        TextBox_Password.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox_Password.Location = New Point(708, 501)
        TextBox_Password.Name = "TextBox_Password"
        TextBox_Password.Size = New Size(205, 29)
        TextBox_Password.TabIndex = 15
        ' 
        ' Label_Access_Level
        ' 
        Label_Access_Level.AutoSize = True
        Label_Access_Level.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label_Access_Level.Location = New Point(235, 559)
        Label_Access_Level.Name = "Label_Access_Level"
        Label_Access_Level.Size = New Size(92, 20)
        Label_Access_Level.TabIndex = 31
        Label_Access_Level.Text = "Access Level"
        Label_Access_Level.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label_Status
        ' 
        Label_Status.AutoSize = True
        Label_Status.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label_Status.ForeColor = SystemColors.ButtonHighlight
        Label_Status.Location = New Point(649, 546)
        Label_Status.Name = "Label_Status"
        Label_Status.Size = New Size(50, 20)
        Label_Status.TabIndex = 32
        Label_Status.Text = "Status"
        Label_Status.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Button_Add_User
        ' 
        Button_Add_User.BackColor = Color.White
        Button_Add_User.FlatAppearance.BorderColor = Color.Black
        Button_Add_User.FlatAppearance.BorderSize = 4
        Button_Add_User.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(245), CByte(200), CByte(35))
        Button_Add_User.FlatStyle = FlatStyle.Flat
        Button_Add_User.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Button_Add_User.ForeColor = Color.Black
        Button_Add_User.Location = New Point(1057, 395)
        Button_Add_User.Name = "Button_Add_User"
        Button_Add_User.Size = New Size(205, 78)
        Button_Add_User.TabIndex = 33
        Button_Add_User.Text = "ADD"
        Button_Add_User.UseVisualStyleBackColor = False
        ' 
        ' Button_Reset
        ' 
        Button_Reset.BackColor = Color.White
        Button_Reset.FlatAppearance.BorderColor = Color.Black
        Button_Reset.FlatAppearance.BorderSize = 4
        Button_Reset.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(245), CByte(200), CByte(35))
        Button_Reset.FlatStyle = FlatStyle.Flat
        Button_Reset.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Button_Reset.ForeColor = Color.Black
        Button_Reset.Location = New Point(1057, 501)
        Button_Reset.Name = "Button_Reset"
        Button_Reset.Size = New Size(205, 78)
        Button_Reset.TabIndex = 34
        Button_Reset.Text = "RESET"
        Button_Reset.UseVisualStyleBackColor = False
        ' 
        ' DateTimePicker_Starting_Date
        ' 
        DateTimePicker_Starting_Date.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        DateTimePicker_Starting_Date.Location = New Point(705, 343)
        DateTimePicker_Starting_Date.Name = "DateTimePicker_Starting_Date"
        DateTimePicker_Starting_Date.Size = New Size(200, 29)
        DateTimePicker_Starting_Date.TabIndex = 11
        ' 
        ' ComboBox_Education
        ' 
        ComboBox_Education.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ComboBox_Education.FormattingEnabled = True
        ComboBox_Education.Items.AddRange(New Object() {"DES", "AEC", "DEC", "Certificate", "BAC", "Master", "Doc"})
        ComboBox_Education.Location = New Point(707, 395)
        ComboBox_Education.Name = "ComboBox_Education"
        ComboBox_Education.Size = New Size(201, 29)
        ComboBox_Education.TabIndex = 13
        ' 
        ' ComboBox_Access_Level
        ' 
        ComboBox_Access_Level.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ComboBox_Access_Level.FormattingEnabled = True
        ComboBox_Access_Level.Items.AddRange(New Object() {"Low", "Medium", "High", "Admin"})
        ComboBox_Access_Level.Location = New Point(333, 555)
        ComboBox_Access_Level.Name = "ComboBox_Access_Level"
        ComboBox_Access_Level.Size = New Size(205, 29)
        ComboBox_Access_Level.TabIndex = 16
        ' 
        ' ComboBox_Status
        ' 
        ComboBox_Status.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ComboBox_Status.FormattingEnabled = True
        ComboBox_Status.Items.AddRange(New Object() {"Inactive"})
        ComboBox_Status.Location = New Point(707, 546)
        ComboBox_Status.Name = "ComboBox_Status"
        ComboBox_Status.Size = New Size(206, 29)
        ComboBox_Status.TabIndex = 17
        ' 
        ' DateTimePicker_DOB
        ' 
        DateTimePicker_DOB.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        DateTimePicker_DOB.Location = New Point(333, 205)
        DateTimePicker_DOB.Name = "DateTimePicker_DOB"
        DateTimePicker_DOB.Size = New Size(205, 29)
        DateTimePicker_DOB.TabIndex = 4
        ' 
        ' Label_Username_Label
        ' 
        Label_Username_Label.AutoSize = True
        Label_Username_Label.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label_Username_Label.Location = New Point(1053, 51)
        Label_Username_Label.Name = "Label_Username_Label"
        Label_Username_Label.Size = New Size(88, 21)
        Label_Username_Label.TabIndex = 35
        Label_Username_Label.Text = "Username :"
        ' 
        ' Label_Access_Level_Label
        ' 
        Label_Access_Level_Label.AutoSize = True
        Label_Access_Level_Label.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label_Access_Level_Label.Location = New Point(1038, 86)
        Label_Access_Level_Label.Name = "Label_Access_Level_Label"
        Label_Access_Level_Label.Size = New Size(103, 21)
        Label_Access_Level_Label.TabIndex = 36
        Label_Access_Level_Label.Text = "Access Level :"
        ' 
        ' ComboBox_Province
        ' 
        ComboBox_Province.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ComboBox_Province.FormattingEnabled = True
        ComboBox_Province.Items.AddRange(New Object() {"Alberta", "BritishColumbia", "Manitoba", "NewBrunswick", "NewfoundlandAndLabrador", "NovaScotia", "Ontario", "PrinceEdwardIsland", "Quebec", "Saskatchewan", "NorthwestTerritories", "Nunavut", "Yukon"})
        ComboBox_Province.Location = New Point(1061, 252)
        ComboBox_Province.Name = "ComboBox_Province"
        ComboBox_Province.Size = New Size(201, 29)
        ComboBox_Province.TabIndex = 9
        ' 
        ' Button_Dashboard
        ' 
        Button_Dashboard.BackColor = Color.White
        Button_Dashboard.FlatAppearance.BorderColor = Color.Black
        Button_Dashboard.FlatAppearance.BorderSize = 4
        Button_Dashboard.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(245), CByte(200), CByte(35))
        Button_Dashboard.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(245), CByte(200), CByte(35))
        Button_Dashboard.FlatStyle = FlatStyle.Flat
        Button_Dashboard.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Button_Dashboard.ForeColor = Color.Black
        Button_Dashboard.Location = New Point(731, 57)
        Button_Dashboard.Name = "Button_Dashboard"
        Button_Dashboard.Size = New Size(260, 50)
        Button_Dashboard.TabIndex = 37
        Button_Dashboard.Text = "DASHBOARD"
        Button_Dashboard.UseVisualStyleBackColor = False
        ' 
        ' CreateEmployee
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(50), CByte(90), CByte(235))
        ClientSize = New Size(1484, 761)
        Controls.Add(Button_Dashboard)
        Controls.Add(ComboBox_Province)
        Controls.Add(Label_Access_Level_Label)
        Controls.Add(Label_Username_Label)
        Controls.Add(DateTimePicker_DOB)
        Controls.Add(ComboBox_Status)
        Controls.Add(ComboBox_Access_Level)
        Controls.Add(ComboBox_Education)
        Controls.Add(DateTimePicker_Starting_Date)
        Controls.Add(Button_Reset)
        Controls.Add(Button_Add_User)
        Controls.Add(Label_Status)
        Controls.Add(Label_Access_Level)
        Controls.Add(TextBox_Password)
        Controls.Add(Label_Password)
        Controls.Add(TextBox_Username)
        Controls.Add(Label_Username)
        Controls.Add(Label_Education)
        Controls.Add(TextBox_Salary)
        Controls.Add(Label_Salary)
        Controls.Add(Label_Starting_Date)
        Controls.Add(TextBox_SID_Number)
        Controls.Add(Label_Sid_Number)
        Controls.Add(Label_Province)
        Controls.Add(TextBox_Home_Phone)
        Controls.Add(Label_Home_Phone)
        Controls.Add(TextBox_City)
        Controls.Add(Label_City)
        Controls.Add(TextBox_Cell_Phone)
        Controls.Add(Label_Cell_Phone)
        Controls.Add(TextBox_Address)
        Controls.Add(Label_Address)
        Controls.Add(TextBox_Last_Name)
        Controls.Add(Label_Last_Name)
        Controls.Add(TextBox_Postal_Code)
        Controls.Add(Label_Postal_Code)
        Controls.Add(Label_DOB)
        Controls.Add(TextBox_First_Name)
        Controls.Add(Label_First_Name)
        Controls.Add(Label_Title)
        Controls.Add(Label_Display_Access_Level)
        Controls.Add(Label_Display_Username)
        ForeColor = SystemColors.ButtonHighlight
        Name = "CreateEmployee"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Add Employee"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label_Display_Username As Label
    Friend WithEvents Label_Display_Access_Level As Label
    Friend WithEvents Label_Title As Label
    Friend WithEvents Label_First_Name As Label
    Friend WithEvents TextBox_First_Name As TextBox
    Friend WithEvents Label_DOB As Label
    Friend WithEvents Label_Postal_Code As Label
    Friend WithEvents TextBox_Postal_Code As TextBox
    Friend WithEvents Label_Last_Name As Label
    Friend WithEvents TextBox_Last_Name As TextBox
    Friend WithEvents Label_Address As Label
    Friend WithEvents TextBox_Address As TextBox
    Friend WithEvents Label_Cell_Phone As Label
    Friend WithEvents TextBox_Cell_Phone As TextBox
    Friend WithEvents Label_City As Label
    Friend WithEvents TextBox_City As TextBox
    Friend WithEvents Label_Home_Phone As Label
    Friend WithEvents TextBox_Home_Phone As TextBox
    Friend WithEvents Label_Province As Label
    Friend WithEvents Label_Sid_Number As Label
    Friend WithEvents TextBox_SID_Number As TextBox
    Friend WithEvents Label_Starting_Date As Label
    Friend WithEvents Label_Salary As Label
    Friend WithEvents TextBox_Salary As TextBox
    Friend WithEvents Label_Education As Label
    Friend WithEvents Label_Username As Label
    Friend WithEvents TextBox_Username As TextBox
    Friend WithEvents Label_Password As Label
    Friend WithEvents TextBox_Password As TextBox
    Friend WithEvents Label_Access_Level As Label
    Friend WithEvents Label_Status As Label
    Friend WithEvents Button_Add_User As Button
    Friend WithEvents Button_Reset As Button
    Friend WithEvents DateTimePicker_Starting_Date As DateTimePicker
    Friend WithEvents ComboBox_Education As ComboBox
    Friend WithEvents ComboBox_Access_Level As ComboBox
    Friend WithEvents ComboBox_Status As ComboBox
    Friend WithEvents DateTimePicker_DOB As DateTimePicker
    Friend WithEvents Label_Username_Label As Label
    Friend WithEvents Label_Access_Level_Label As Label
    Friend WithEvents ComboBox_Province As ComboBox
    Friend WithEvents Button_Dashboard As Button
End Class
