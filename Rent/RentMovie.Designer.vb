<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RentMovie
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
        Label_Title_Movie = New Label()
        TextBox_Title = New TextBox()
        Label_Genre = New Label()
        TextBox_Genre = New TextBox()
        Label_Release_Year = New Label()
        Label_Original_Language = New Label()
        TextBox_Original_Language = New TextBox()
        Label_Run_Time = New Label()
        TextBox_Run_Time = New TextBox()
        Label_Director = New Label()
        TextBox_Director = New TextBox()
        Label_Starring = New Label()
        TextBox_Starring = New TextBox()
        Label_Country = New Label()
        PictureBox_Poster = New PictureBox()
        Label1 = New Label()
        TextBox_Resume = New TextBox()
        Button_Rent_Movie = New Button()
        Button_Clear = New Button()
        Label_Username = New Label()
        Label_Access_Level = New Label()
        Label_Display_Username = New Label()
        Label_Display_Access_Level = New Label()
        TextBox_Countries = New TextBox()
        Label_Status = New Label()
        ComboBox_Status = New ComboBox()
        Label_Select_A_Movie = New Label()
        ComboBox_Movies_Id = New ComboBox()
        Label_Movie_ID = New Label()
        TextBox_Movie_ID = New TextBox()
        TextBox_Year_Release = New TextBox()
        Label_Choose_Client_Number = New Label()
        ComboBox_Client_Number = New ComboBox()
        Label_First_Name = New Label()
        TextBox_First_Name = New TextBox()
        Label_Last_Name = New Label()
        TextBox_Last_Name = New TextBox()
        Label_DOB = New Label()
        TextBox_DOB = New TextBox()
        Label_Address = New Label()
        TextBox_Address = New TextBox()
        Label_City = New Label()
        TextBox_City = New TextBox()
        Label_Phone = New Label()
        TextBox_Phone = New TextBox()
        Label_Client_Number = New Label()
        TextBox_Client_Number = New TextBox()
        Button_Dashboard = New Button()
        CType(PictureBox_Poster, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label_Title
        ' 
        Label_Title.AutoSize = True
        Label_Title.Font = New Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point)
        Label_Title.ForeColor = Color.FromArgb(CByte(245), CByte(200), CByte(35))
        Label_Title.Location = New Point(101, 40)
        Label_Title.Name = "Label_Title"
        Label_Title.Size = New Size(286, 65)
        Label_Title.TabIndex = 0
        Label_Title.Text = "Rent Movie"
        ' 
        ' Label_Title_Movie
        ' 
        Label_Title_Movie.AutoSize = True
        Label_Title_Movie.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label_Title_Movie.Location = New Point(142, 193)
        Label_Title_Movie.Name = "Label_Title_Movie"
        Label_Title_Movie.Size = New Size(42, 21)
        Label_Title_Movie.TabIndex = 1
        Label_Title_Movie.Text = "Title"
        ' 
        ' TextBox_Title
        ' 
        TextBox_Title.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox_Title.Location = New Point(190, 193)
        TextBox_Title.Name = "TextBox_Title"
        TextBox_Title.ReadOnly = True
        TextBox_Title.Size = New Size(240, 29)
        TextBox_Title.TabIndex = 1
        ' 
        ' Label_Genre
        ' 
        Label_Genre.AutoSize = True
        Label_Genre.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label_Genre.Location = New Point(132, 246)
        Label_Genre.Name = "Label_Genre"
        Label_Genre.Size = New Size(54, 21)
        Label_Genre.TabIndex = 3
        Label_Genre.Text = "Genre"
        ' 
        ' TextBox_Genre
        ' 
        TextBox_Genre.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox_Genre.Location = New Point(190, 246)
        TextBox_Genre.Name = "TextBox_Genre"
        TextBox_Genre.ReadOnly = True
        TextBox_Genre.Size = New Size(240, 29)
        TextBox_Genre.TabIndex = 2
        ' 
        ' Label_Release_Year
        ' 
        Label_Release_Year.AutoSize = True
        Label_Release_Year.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label_Release_Year.Location = New Point(291, 299)
        Label_Release_Year.Name = "Label_Release_Year"
        Label_Release_Year.Size = New Size(41, 21)
        Label_Release_Year.TabIndex = 5
        Label_Release_Year.Text = "Year"
        ' 
        ' Label_Original_Language
        ' 
        Label_Original_Language.AutoSize = True
        Label_Original_Language.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label_Original_Language.Location = New Point(105, 400)
        Label_Original_Language.Name = "Label_Original_Language"
        Label_Original_Language.Size = New Size(81, 21)
        Label_Original_Language.TabIndex = 7
        Label_Original_Language.Text = "Language"
        ' 
        ' TextBox_Original_Language
        ' 
        TextBox_Original_Language.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox_Original_Language.Location = New Point(190, 400)
        TextBox_Original_Language.Name = "TextBox_Original_Language"
        TextBox_Original_Language.ReadOnly = True
        TextBox_Original_Language.Size = New Size(240, 29)
        TextBox_Original_Language.TabIndex = 5
        ' 
        ' Label_Run_Time
        ' 
        Label_Run_Time.AutoSize = True
        Label_Run_Time.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label_Run_Time.Location = New Point(121, 296)
        Label_Run_Time.Name = "Label_Run_Time"
        Label_Run_Time.Size = New Size(65, 21)
        Label_Run_Time.TabIndex = 9
        Label_Run_Time.Text = "Length "
        ' 
        ' TextBox_Run_Time
        ' 
        TextBox_Run_Time.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox_Run_Time.Location = New Point(190, 296)
        TextBox_Run_Time.Name = "TextBox_Run_Time"
        TextBox_Run_Time.ReadOnly = True
        TextBox_Run_Time.Size = New Size(74, 29)
        TextBox_Run_Time.TabIndex = 4
        ' 
        ' Label_Director
        ' 
        Label_Director.AutoSize = True
        Label_Director.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label_Director.Location = New Point(116, 445)
        Label_Director.Name = "Label_Director"
        Label_Director.Size = New Size(70, 21)
        Label_Director.TabIndex = 11
        Label_Director.Text = "Director"
        ' 
        ' TextBox_Director
        ' 
        TextBox_Director.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox_Director.Location = New Point(190, 445)
        TextBox_Director.Name = "TextBox_Director"
        TextBox_Director.ReadOnly = True
        TextBox_Director.Size = New Size(240, 29)
        TextBox_Director.TabIndex = 6
        ' 
        ' Label_Starring
        ' 
        Label_Starring.AutoSize = True
        Label_Starring.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label_Starring.Location = New Point(116, 496)
        Label_Starring.Name = "Label_Starring"
        Label_Starring.Size = New Size(68, 21)
        Label_Starring.TabIndex = 13
        Label_Starring.Text = "Starring"
        ' 
        ' TextBox_Starring
        ' 
        TextBox_Starring.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox_Starring.Location = New Point(190, 496)
        TextBox_Starring.Multiline = True
        TextBox_Starring.Name = "TextBox_Starring"
        TextBox_Starring.ReadOnly = True
        TextBox_Starring.Size = New Size(516, 86)
        TextBox_Starring.TabIndex = 7
        ' 
        ' Label_Country
        ' 
        Label_Country.AutoSize = True
        Label_Country.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label_Country.Location = New Point(114, 352)
        Label_Country.Name = "Label_Country"
        Label_Country.Size = New Size(69, 21)
        Label_Country.TabIndex = 15
        Label_Country.Text = "Country"
        ' 
        ' PictureBox_Poster
        ' 
        PictureBox_Poster.Location = New Point(449, 193)
        PictureBox_Poster.Name = "PictureBox_Poster"
        PictureBox_Poster.Size = New Size(196, 281)
        PictureBox_Poster.TabIndex = 17
        PictureBox_Poster.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(114, 596)
        Label1.Name = "Label1"
        Label1.Size = New Size(68, 21)
        Label1.TabIndex = 21
        Label1.Text = "Resume"
        ' 
        ' TextBox_Resume
        ' 
        TextBox_Resume.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox_Resume.Location = New Point(190, 596)
        TextBox_Resume.Multiline = True
        TextBox_Resume.Name = "TextBox_Resume"
        TextBox_Resume.ReadOnly = True
        TextBox_Resume.Size = New Size(516, 87)
        TextBox_Resume.TabIndex = 9
        ' 
        ' Button_Rent_Movie
        ' 
        Button_Rent_Movie.BackColor = Color.White
        Button_Rent_Movie.FlatAppearance.BorderColor = Color.Black
        Button_Rent_Movie.FlatAppearance.BorderSize = 4
        Button_Rent_Movie.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(245), CByte(200), CByte(35))
        Button_Rent_Movie.FlatStyle = FlatStyle.Flat
        Button_Rent_Movie.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Button_Rent_Movie.ForeColor = Color.Black
        Button_Rent_Movie.Location = New Point(828, 663)
        Button_Rent_Movie.Name = "Button_Rent_Movie"
        Button_Rent_Movie.Size = New Size(192, 65)
        Button_Rent_Movie.TabIndex = 22
        Button_Rent_Movie.Text = "RENT / RETURN"
        Button_Rent_Movie.UseVisualStyleBackColor = False
        ' 
        ' Button_Clear
        ' 
        Button_Clear.BackColor = Color.White
        Button_Clear.FlatAppearance.BorderColor = Color.Black
        Button_Clear.FlatAppearance.BorderSize = 4
        Button_Clear.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(245), CByte(200), CByte(35))
        Button_Clear.FlatStyle = FlatStyle.Flat
        Button_Clear.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Button_Clear.ForeColor = Color.Black
        Button_Clear.Location = New Point(1061, 663)
        Button_Clear.Name = "Button_Clear"
        Button_Clear.Size = New Size(192, 65)
        Button_Clear.TabIndex = 23
        Button_Clear.Text = "CLEAR"
        Button_Clear.UseVisualStyleBackColor = False
        ' 
        ' Label_Username
        ' 
        Label_Username.AutoSize = True
        Label_Username.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label_Username.Location = New Point(1037, 40)
        Label_Username.Name = "Label_Username"
        Label_Username.Size = New Size(88, 21)
        Label_Username.TabIndex = 26
        Label_Username.Text = "Username :"
        ' 
        ' Label_Access_Level
        ' 
        Label_Access_Level.AutoSize = True
        Label_Access_Level.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label_Access_Level.Location = New Point(1022, 75)
        Label_Access_Level.Name = "Label_Access_Level"
        Label_Access_Level.Size = New Size(103, 21)
        Label_Access_Level.TabIndex = 27
        Label_Access_Level.Text = "Access Level :"
        ' 
        ' Label_Display_Username
        ' 
        Label_Display_Username.AutoSize = True
        Label_Display_Username.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label_Display_Username.ForeColor = Color.FromArgb(CByte(245), CByte(200), CByte(35))
        Label_Display_Username.Location = New Point(1131, 40)
        Label_Display_Username.Name = "Label_Display_Username"
        Label_Display_Username.Size = New Size(83, 21)
        Label_Display_Username.TabIndex = 28
        Label_Display_Username.Text = "Username"
        ' 
        ' Label_Display_Access_Level
        ' 
        Label_Display_Access_Level.AutoSize = True
        Label_Display_Access_Level.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label_Display_Access_Level.ForeColor = Color.FromArgb(CByte(245), CByte(200), CByte(35))
        Label_Display_Access_Level.Location = New Point(1131, 75)
        Label_Display_Access_Level.Name = "Label_Display_Access_Level"
        Label_Display_Access_Level.Size = New Size(102, 21)
        Label_Display_Access_Level.TabIndex = 29
        Label_Display_Access_Level.Text = "Access Level"
        ' 
        ' TextBox_Countries
        ' 
        TextBox_Countries.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox_Countries.Location = New Point(190, 352)
        TextBox_Countries.Name = "TextBox_Countries"
        TextBox_Countries.ReadOnly = True
        TextBox_Countries.Size = New Size(240, 29)
        TextBox_Countries.TabIndex = 31
        ' 
        ' Label_Status
        ' 
        Label_Status.AutoSize = True
        Label_Status.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label_Status.Location = New Point(129, 699)
        Label_Status.Name = "Label_Status"
        Label_Status.Size = New Size(55, 21)
        Label_Status.TabIndex = 32
        Label_Status.Text = "Status"
        ' 
        ' ComboBox_Status
        ' 
        ComboBox_Status.Enabled = False
        ComboBox_Status.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ComboBox_Status.FormattingEnabled = True
        ComboBox_Status.Items.AddRange(New Object() {" Rented ", " Available ", " Removed ", " Lost "})
        ComboBox_Status.Location = New Point(190, 699)
        ComboBox_Status.Name = "ComboBox_Status"
        ComboBox_Status.Size = New Size(147, 29)
        ComboBox_Status.TabIndex = 33
        ' 
        ' Label_Select_A_Movie
        ' 
        Label_Select_A_Movie.AutoSize = True
        Label_Select_A_Movie.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label_Select_A_Movie.Location = New Point(140, 129)
        Label_Select_A_Movie.Name = "Label_Select_A_Movie"
        Label_Select_A_Movie.Size = New Size(136, 25)
        Label_Select_A_Movie.TabIndex = 34
        Label_Select_A_Movie.Text = "Select a movie"
        ' 
        ' ComboBox_Movies_Id
        ' 
        ComboBox_Movies_Id.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        ComboBox_Movies_Id.FormattingEnabled = True
        ComboBox_Movies_Id.Location = New Point(282, 134)
        ComboBox_Movies_Id.Name = "ComboBox_Movies_Id"
        ComboBox_Movies_Id.Size = New Size(363, 28)
        ComboBox_Movies_Id.TabIndex = 35
        ' 
        ' Label_Movie_ID
        ' 
        Label_Movie_ID.AutoSize = True
        Label_Movie_ID.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label_Movie_ID.Location = New Point(500, 699)
        Label_Movie_ID.Name = "Label_Movie_ID"
        Label_Movie_ID.Size = New Size(72, 21)
        Label_Movie_ID.TabIndex = 36
        Label_Movie_ID.Text = "MovieID"
        ' 
        ' TextBox_Movie_ID
        ' 
        TextBox_Movie_ID.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox_Movie_ID.Location = New Point(578, 699)
        TextBox_Movie_ID.Name = "TextBox_Movie_ID"
        TextBox_Movie_ID.ReadOnly = True
        TextBox_Movie_ID.Size = New Size(128, 29)
        TextBox_Movie_ID.TabIndex = 37
        ' 
        ' TextBox_Year_Release
        ' 
        TextBox_Year_Release.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox_Year_Release.Location = New Point(338, 299)
        TextBox_Year_Release.Name = "TextBox_Year_Release"
        TextBox_Year_Release.ReadOnly = True
        TextBox_Year_Release.Size = New Size(92, 29)
        TextBox_Year_Release.TabIndex = 38
        ' 
        ' Label_Choose_Client_Number
        ' 
        Label_Choose_Client_Number.AutoSize = True
        Label_Choose_Client_Number.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label_Choose_Client_Number.Location = New Point(732, 134)
        Label_Choose_Client_Number.Name = "Label_Choose_Client_Number"
        Label_Choose_Client_Number.Size = New Size(217, 25)
        Label_Choose_Client_Number.TabIndex = 39
        Label_Choose_Client_Number.Text = "Choose a Client number"
        ' 
        ' ComboBox_Client_Number
        ' 
        ComboBox_Client_Number.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        ComboBox_Client_Number.FormattingEnabled = True
        ComboBox_Client_Number.Location = New Point(955, 133)
        ComboBox_Client_Number.Name = "ComboBox_Client_Number"
        ComboBox_Client_Number.Size = New Size(259, 28)
        ComboBox_Client_Number.TabIndex = 40
        ' 
        ' Label_First_Name
        ' 
        Label_First_Name.AutoSize = True
        Label_First_Name.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label_First_Name.Location = New Point(828, 196)
        Label_First_Name.Name = "Label_First_Name"
        Label_First_Name.Size = New Size(88, 21)
        Label_First_Name.TabIndex = 41
        Label_First_Name.Text = "First Name"
        ' 
        ' TextBox_First_Name
        ' 
        TextBox_First_Name.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox_First_Name.Location = New Point(922, 196)
        TextBox_First_Name.Name = "TextBox_First_Name"
        TextBox_First_Name.ReadOnly = True
        TextBox_First_Name.Size = New Size(292, 29)
        TextBox_First_Name.TabIndex = 42
        ' 
        ' Label_Last_Name
        ' 
        Label_Last_Name.AutoSize = True
        Label_Last_Name.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label_Last_Name.Location = New Point(828, 249)
        Label_Last_Name.Name = "Label_Last_Name"
        Label_Last_Name.Size = New Size(86, 21)
        Label_Last_Name.TabIndex = 43
        Label_Last_Name.Text = "Last Name"
        ' 
        ' TextBox_Last_Name
        ' 
        TextBox_Last_Name.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox_Last_Name.Location = New Point(920, 249)
        TextBox_Last_Name.Name = "TextBox_Last_Name"
        TextBox_Last_Name.ReadOnly = True
        TextBox_Last_Name.Size = New Size(294, 29)
        TextBox_Last_Name.TabIndex = 44
        ' 
        ' Label_DOB
        ' 
        Label_DOB.AutoSize = True
        Label_DOB.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label_DOB.Location = New Point(871, 296)
        Label_DOB.Name = "Label_DOB"
        Label_DOB.Size = New Size(43, 21)
        Label_DOB.TabIndex = 45
        Label_DOB.Text = "DOB"
        ' 
        ' TextBox_DOB
        ' 
        TextBox_DOB.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox_DOB.Location = New Point(920, 296)
        TextBox_DOB.Name = "TextBox_DOB"
        TextBox_DOB.ReadOnly = True
        TextBox_DOB.Size = New Size(294, 29)
        TextBox_DOB.TabIndex = 46
        ' 
        ' Label_Address
        ' 
        Label_Address.AutoSize = True
        Label_Address.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label_Address.Location = New Point(844, 347)
        Label_Address.Name = "Label_Address"
        Label_Address.Size = New Size(70, 21)
        Label_Address.TabIndex = 47
        Label_Address.Text = "Address"
        ' 
        ' TextBox_Address
        ' 
        TextBox_Address.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox_Address.Location = New Point(922, 344)
        TextBox_Address.Name = "TextBox_Address"
        TextBox_Address.ReadOnly = True
        TextBox_Address.Size = New Size(292, 29)
        TextBox_Address.TabIndex = 48
        ' 
        ' Label_City
        ' 
        Label_City.AutoSize = True
        Label_City.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label_City.Location = New Point(876, 395)
        Label_City.Name = "Label_City"
        Label_City.Size = New Size(38, 21)
        Label_City.TabIndex = 49
        Label_City.Text = "City"
        ' 
        ' TextBox_City
        ' 
        TextBox_City.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox_City.Location = New Point(922, 392)
        TextBox_City.Name = "TextBox_City"
        TextBox_City.ReadOnly = True
        TextBox_City.Size = New Size(292, 29)
        TextBox_City.TabIndex = 50
        ' 
        ' Label_Phone
        ' 
        Label_Phone.AutoSize = True
        Label_Phone.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label_Phone.Location = New Point(858, 445)
        Label_Phone.Name = "Label_Phone"
        Label_Phone.Size = New Size(56, 21)
        Label_Phone.TabIndex = 51
        Label_Phone.Text = "Phone"
        ' 
        ' TextBox_Phone
        ' 
        TextBox_Phone.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox_Phone.Location = New Point(920, 445)
        TextBox_Phone.Name = "TextBox_Phone"
        TextBox_Phone.ReadOnly = True
        TextBox_Phone.Size = New Size(294, 29)
        TextBox_Phone.TabIndex = 52
        ' 
        ' Label_Client_Number
        ' 
        Label_Client_Number.AutoSize = True
        Label_Client_Number.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label_Client_Number.Location = New Point(800, 496)
        Label_Client_Number.Name = "Label_Client_Number"
        Label_Client_Number.Size = New Size(116, 21)
        Label_Client_Number.TabIndex = 53
        Label_Client_Number.Text = "Client Number"
        ' 
        ' TextBox_Client_Number
        ' 
        TextBox_Client_Number.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox_Client_Number.Location = New Point(920, 496)
        TextBox_Client_Number.Name = "TextBox_Client_Number"
        TextBox_Client_Number.ReadOnly = True
        TextBox_Client_Number.Size = New Size(294, 29)
        TextBox_Client_Number.TabIndex = 54
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
        Button_Dashboard.Location = New Point(553, 46)
        Button_Dashboard.Name = "Button_Dashboard"
        Button_Dashboard.Size = New Size(260, 50)
        Button_Dashboard.TabIndex = 56
        Button_Dashboard.Text = "DASHBOARD"
        Button_Dashboard.UseVisualStyleBackColor = False
        ' 
        ' RentMovie
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(50), CByte(90), CByte(235))
        ClientSize = New Size(1484, 761)
        Controls.Add(Button_Dashboard)
        Controls.Add(TextBox_Client_Number)
        Controls.Add(Label_Client_Number)
        Controls.Add(TextBox_Phone)
        Controls.Add(Label_Phone)
        Controls.Add(TextBox_City)
        Controls.Add(Label_City)
        Controls.Add(TextBox_Address)
        Controls.Add(Label_Address)
        Controls.Add(TextBox_DOB)
        Controls.Add(Label_DOB)
        Controls.Add(TextBox_Last_Name)
        Controls.Add(Label_Last_Name)
        Controls.Add(TextBox_First_Name)
        Controls.Add(Label_First_Name)
        Controls.Add(ComboBox_Client_Number)
        Controls.Add(Label_Choose_Client_Number)
        Controls.Add(TextBox_Year_Release)
        Controls.Add(TextBox_Movie_ID)
        Controls.Add(Label_Movie_ID)
        Controls.Add(ComboBox_Movies_Id)
        Controls.Add(Label_Select_A_Movie)
        Controls.Add(ComboBox_Status)
        Controls.Add(Label_Status)
        Controls.Add(TextBox_Countries)
        Controls.Add(Label_Display_Access_Level)
        Controls.Add(Label_Display_Username)
        Controls.Add(Label_Access_Level)
        Controls.Add(Label_Username)
        Controls.Add(Button_Clear)
        Controls.Add(Button_Rent_Movie)
        Controls.Add(TextBox_Resume)
        Controls.Add(Label1)
        Controls.Add(PictureBox_Poster)
        Controls.Add(Label_Country)
        Controls.Add(TextBox_Starring)
        Controls.Add(Label_Starring)
        Controls.Add(TextBox_Director)
        Controls.Add(Label_Director)
        Controls.Add(TextBox_Run_Time)
        Controls.Add(Label_Run_Time)
        Controls.Add(TextBox_Original_Language)
        Controls.Add(Label_Original_Language)
        Controls.Add(Label_Release_Year)
        Controls.Add(TextBox_Genre)
        Controls.Add(Label_Genre)
        Controls.Add(TextBox_Title)
        Controls.Add(Label_Title_Movie)
        Controls.Add(Label_Title)
        ForeColor = SystemColors.ButtonHighlight
        Name = "RentMovie"
        StartPosition = FormStartPosition.CenterScreen
        Text = "EditMovie"
        CType(PictureBox_Poster, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label_Title As Label
    Friend WithEvents Label_Title_Movie As Label
    Friend WithEvents TextBox_Title As TextBox
    Friend WithEvents Label_Genre As Label
    Friend WithEvents TextBox_Genre As TextBox
    Friend WithEvents Label_Release_Year As Label
    Friend WithEvents Label_Original_Language As Label
    Friend WithEvents TextBox_Original_Language As TextBox
    Friend WithEvents Label_Run_Time As Label
    Friend WithEvents TextBox_Run_Time As TextBox
    Friend WithEvents Label_Director As Label
    Friend WithEvents TextBox_Director As TextBox
    Friend WithEvents Label_Starring As Label
    Friend WithEvents TextBox_Starring As TextBox
    Friend WithEvents Label_Country As Label
    Friend WithEvents PictureBox_Poster As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox_Resume As TextBox
    Friend WithEvents Button_Rent_Movie As Button
    Friend WithEvents Button_Clear As Button
    Friend WithEvents Label_Username As Label
    Friend WithEvents Label_Access_Level As Label
    Friend WithEvents Label_Display_Username As Label
    Friend WithEvents Label_Display_Access_Level As Label
    Friend WithEvents TextBox_Countries As TextBox
    Friend WithEvents Label_Status As Label
    Friend WithEvents ComboBox_Status As ComboBox
    Friend WithEvents Label_Select_A_Movie As Label
    Friend WithEvents ComboBox_Movies_Id As ComboBox
    Friend WithEvents Label_Movie_ID As Label
    Friend WithEvents TextBox_Movie_ID As TextBox
    Friend WithEvents TextBox_Year_Release As TextBox
    Friend WithEvents Label_Choose_Client_Number As Label
    Friend WithEvents ComboBox_Client_Number As ComboBox
    Friend WithEvents Label_First_Name As Label
    Friend WithEvents TextBox_First_Name As TextBox
    Friend WithEvents Label_Last_Name As Label
    Friend WithEvents TextBox_Last_Name As TextBox
    Friend WithEvents Label_DOB As Label
    Friend WithEvents TextBox_DOB As TextBox
    Friend WithEvents Label_Address As Label
    Friend WithEvents TextBox_Address As TextBox
    Friend WithEvents Label_City As Label
    Friend WithEvents TextBox_City As TextBox
    Friend WithEvents Label_Phone As Label
    Friend WithEvents TextBox_Phone As TextBox
    Friend WithEvents Label_Client_Number As Label
    Friend WithEvents TextBox_Client_Number As TextBox
    Friend WithEvents Button_Dashboard As Button
End Class
