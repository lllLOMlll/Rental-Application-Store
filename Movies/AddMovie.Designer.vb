<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddMovie
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
        Label_Title = New Label()
        Label_Title_Movie = New Label()
        TextBox_Title = New TextBox()
        Label_Genre = New Label()
        TextBox_Genre = New TextBox()
        Label_Release_Year = New Label()
        DomainUpDown_Release_Year = New DomainUpDown()
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
        Label_Poster = New Label()
        Label_Poster_URL = New Label()
        TextBox3 = New TextBox()
        Label1 = New Label()
        TextBox_Resume = New TextBox()
        Button_Add_Movie = New Button()
        Button_Clear = New Button()
        Button_Upload_Picture_URL = New Button()
        Label_Username = New Label()
        Label_Access_Level = New Label()
        Label_Display_Username = New Label()
        Label_Display_Access_Level = New Label()
        Button_Upload_Picture_Download = New Button()
        ComboBox_Country = New ComboBox()
        TextBox_Countries = New TextBox()
        ComboBox_Genre = New ComboBox()
        ComboBox_Language = New ComboBox()
        Button_Clear_Genre = New Button()
        Button_Clear_Language = New Button()
        Button_Clear_Country = New Button()
        Button_Dashboard = New Button()
        CType(PictureBox_Poster, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label_Title
        ' 
        Label_Title.AutoSize = True
        Label_Title.Font = New Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point)
        Label_Title.ForeColor = Color.FromArgb(CByte(245), CByte(200), CByte(35))
        Label_Title.Location = New Point(85, 40)
        Label_Title.Name = "Label_Title"
        Label_Title.Size = New Size(276, 65)
        Label_Title.TabIndex = 0
        Label_Title.Text = "Add Movie"
        ' 
        ' Label_Title_Movie
        ' 
        Label_Title_Movie.AutoSize = True
        Label_Title_Movie.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label_Title_Movie.Location = New Point(101, 123)
        Label_Title_Movie.Name = "Label_Title_Movie"
        Label_Title_Movie.Size = New Size(42, 21)
        Label_Title_Movie.TabIndex = 1
        Label_Title_Movie.Text = "Title"
        ' 
        ' TextBox_Title
        ' 
        TextBox_Title.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox_Title.Location = New Point(101, 147)
        TextBox_Title.Name = "TextBox_Title"
        TextBox_Title.Size = New Size(407, 29)
        TextBox_Title.TabIndex = 1
        ' 
        ' Label_Genre
        ' 
        Label_Genre.AutoSize = True
        Label_Genre.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label_Genre.Location = New Point(101, 195)
        Label_Genre.Name = "Label_Genre"
        Label_Genre.Size = New Size(54, 21)
        Label_Genre.TabIndex = 3
        Label_Genre.Text = "Genre"
        ' 
        ' TextBox_Genre
        ' 
        TextBox_Genre.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox_Genre.Location = New Point(268, 219)
        TextBox_Genre.Name = "TextBox_Genre"
        TextBox_Genre.Size = New Size(240, 29)
        TextBox_Genre.TabIndex = 2
        ' 
        ' Label_Release_Year
        ' 
        Label_Release_Year.AutoSize = True
        Label_Release_Year.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label_Release_Year.Location = New Point(101, 263)
        Label_Release_Year.Name = "Label_Release_Year"
        Label_Release_Year.Size = New Size(109, 21)
        Label_Release_Year.TabIndex = 5
        Label_Release_Year.Text = "Realease Year"
        ' 
        ' DomainUpDown_Release_Year
        ' 
        DomainUpDown_Release_Year.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        DomainUpDown_Release_Year.Location = New Point(101, 287)
        DomainUpDown_Release_Year.Name = "DomainUpDown_Release_Year"
        DomainUpDown_Release_Year.Size = New Size(192, 29)
        DomainUpDown_Release_Year.TabIndex = 3
        ' 
        ' Label_Original_Language
        ' 
        Label_Original_Language.AutoSize = True
        Label_Original_Language.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label_Original_Language.Location = New Point(101, 334)
        Label_Original_Language.Name = "Label_Original_Language"
        Label_Original_Language.Size = New Size(142, 21)
        Label_Original_Language.TabIndex = 7
        Label_Original_Language.Text = "Original Language"
        ' 
        ' TextBox_Original_Language
        ' 
        TextBox_Original_Language.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox_Original_Language.Location = New Point(268, 358)
        TextBox_Original_Language.Name = "TextBox_Original_Language"
        TextBox_Original_Language.Size = New Size(240, 29)
        TextBox_Original_Language.TabIndex = 5
        ' 
        ' Label_Run_Time
        ' 
        Label_Run_Time.AutoSize = True
        Label_Run_Time.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label_Run_Time.Location = New Point(322, 263)
        Label_Run_Time.Name = "Label_Run_Time"
        Label_Run_Time.Size = New Size(119, 21)
        Label_Run_Time.TabIndex = 9
        Label_Run_Time.Text = "Run Time (min)"
        ' 
        ' TextBox_Run_Time
        ' 
        TextBox_Run_Time.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox_Run_Time.Location = New Point(322, 287)
        TextBox_Run_Time.Name = "TextBox_Run_Time"
        TextBox_Run_Time.Size = New Size(186, 29)
        TextBox_Run_Time.TabIndex = 4
        ' 
        ' Label_Director
        ' 
        Label_Director.AutoSize = True
        Label_Director.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label_Director.Location = New Point(101, 407)
        Label_Director.Name = "Label_Director"
        Label_Director.Size = New Size(70, 21)
        Label_Director.TabIndex = 11
        Label_Director.Text = "Director"
        ' 
        ' TextBox_Director
        ' 
        TextBox_Director.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox_Director.Location = New Point(101, 431)
        TextBox_Director.Name = "TextBox_Director"
        TextBox_Director.Size = New Size(407, 29)
        TextBox_Director.TabIndex = 6
        ' 
        ' Label_Starring
        ' 
        Label_Starring.AutoSize = True
        Label_Starring.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label_Starring.Location = New Point(101, 474)
        Label_Starring.Name = "Label_Starring"
        Label_Starring.Size = New Size(68, 21)
        Label_Starring.TabIndex = 13
        Label_Starring.Text = "Starring"
        ' 
        ' TextBox_Starring
        ' 
        TextBox_Starring.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox_Starring.Location = New Point(101, 498)
        TextBox_Starring.Name = "TextBox_Starring"
        TextBox_Starring.Size = New Size(407, 29)
        TextBox_Starring.TabIndex = 7
        ' 
        ' Label_Country
        ' 
        Label_Country.AutoSize = True
        Label_Country.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label_Country.Location = New Point(101, 542)
        Label_Country.Name = "Label_Country"
        Label_Country.Size = New Size(69, 21)
        Label_Country.TabIndex = 15
        Label_Country.Text = "Country"
        ' 
        ' PictureBox_Poster
        ' 
        PictureBox_Poster.Location = New Point(1037, 147)
        PictureBox_Poster.Name = "PictureBox_Poster"
        PictureBox_Poster.Size = New Size(258, 380)
        PictureBox_Poster.TabIndex = 17
        PictureBox_Poster.TabStop = False
        ' 
        ' Label_Poster
        ' 
        Label_Poster.AutoSize = True
        Label_Poster.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label_Poster.Location = New Point(1037, 123)
        Label_Poster.Name = "Label_Poster"
        Label_Poster.Size = New Size(116, 21)
        Label_Poster.TabIndex = 18
        Label_Poster.Text = "Release Poster"
        ' 
        ' Label_Poster_URL
        ' 
        Label_Poster_URL.AutoSize = True
        Label_Poster_URL.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label_Poster_URL.Location = New Point(1037, 542)
        Label_Poster_URL.Name = "Label_Poster_URL"
        Label_Poster_URL.Size = New Size(43, 21)
        Label_Poster_URL.TabIndex = 19
        Label_Poster_URL.Text = " URL"
        ' 
        ' TextBox3
        ' 
        TextBox3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox3.Location = New Point(1037, 571)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(407, 29)
        TextBox3.TabIndex = 10
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(572, 123)
        Label1.Name = "Label1"
        Label1.Size = New Size(68, 21)
        Label1.TabIndex = 21
        Label1.Text = "Resume"
        ' 
        ' TextBox_Resume
        ' 
        TextBox_Resume.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox_Resume.Location = New Point(572, 147)
        TextBox_Resume.Multiline = True
        TextBox_Resume.Name = "TextBox_Resume"
        TextBox_Resume.Size = New Size(407, 448)
        TextBox_Resume.TabIndex = 9
        ' 
        ' Button_Add_Movie
        ' 
        Button_Add_Movie.BackColor = Color.White
        Button_Add_Movie.FlatAppearance.BorderColor = Color.Black
        Button_Add_Movie.FlatAppearance.BorderSize = 4
        Button_Add_Movie.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(245), CByte(200), CByte(35))
        Button_Add_Movie.FlatStyle = FlatStyle.Flat
        Button_Add_Movie.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Button_Add_Movie.ForeColor = Color.Black
        Button_Add_Movie.Location = New Point(572, 630)
        Button_Add_Movie.Name = "Button_Add_Movie"
        Button_Add_Movie.Size = New Size(192, 65)
        Button_Add_Movie.TabIndex = 22
        Button_Add_Movie.Text = "ADD MOVIE"
        Button_Add_Movie.UseVisualStyleBackColor = False
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
        Button_Clear.Location = New Point(800, 630)
        Button_Clear.Name = "Button_Clear"
        Button_Clear.Size = New Size(192, 65)
        Button_Clear.TabIndex = 23
        Button_Clear.Text = "CLEAR"
        Button_Clear.UseVisualStyleBackColor = False
        ' 
        ' Button_Upload_Picture_URL
        ' 
        Button_Upload_Picture_URL.BackColor = Color.White
        Button_Upload_Picture_URL.FlatAppearance.BorderColor = Color.Black
        Button_Upload_Picture_URL.FlatAppearance.BorderSize = 4
        Button_Upload_Picture_URL.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(245), CByte(200), CByte(35))
        Button_Upload_Picture_URL.FlatStyle = FlatStyle.Flat
        Button_Upload_Picture_URL.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Button_Upload_Picture_URL.ForeColor = Color.Black
        Button_Upload_Picture_URL.Location = New Point(1037, 629)
        Button_Upload_Picture_URL.Name = "Button_Upload_Picture_URL"
        Button_Upload_Picture_URL.Size = New Size(407, 30)
        Button_Upload_Picture_URL.TabIndex = 24
        Button_Upload_Picture_URL.Text = "Upload Picture_URL"
        Button_Upload_Picture_URL.UseVisualStyleBackColor = False
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
        ' Button_Upload_Picture_Download
        ' 
        Button_Upload_Picture_Download.BackColor = Color.White
        Button_Upload_Picture_Download.FlatAppearance.BorderColor = Color.Black
        Button_Upload_Picture_Download.FlatAppearance.BorderSize = 4
        Button_Upload_Picture_Download.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(245), CByte(200), CByte(35))
        Button_Upload_Picture_Download.FlatStyle = FlatStyle.Flat
        Button_Upload_Picture_Download.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Button_Upload_Picture_Download.ForeColor = Color.Black
        Button_Upload_Picture_Download.Location = New Point(1037, 665)
        Button_Upload_Picture_Download.Name = "Button_Upload_Picture_Download"
        Button_Upload_Picture_Download.Size = New Size(407, 30)
        Button_Upload_Picture_Download.TabIndex = 30
        Button_Upload_Picture_Download.Text = "Upload Picture Dowload"
        Button_Upload_Picture_Download.UseVisualStyleBackColor = False
        ' 
        ' ComboBox_Country
        ' 
        ComboBox_Country.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ComboBox_Country.FormattingEnabled = True
        ComboBox_Country.Items.AddRange(New Object() {" Algeria", "Australia", "Austria", "Brazil", "China", "Czech Republic", "France", "Germany", "Hong Kong ", "India", "Italy", "Japan", "Malta", "Mexico", "New Zealand", "Poland", "South Africa", "South Korea", "Spain", "Sweden", "Taiwan", "UK", "West Germany", "Canada", "USA", ""})
        ComboBox_Country.Location = New Point(101, 572)
        ComboBox_Country.Name = "ComboBox_Country"
        ComboBox_Country.Size = New Size(161, 29)
        ComboBox_Country.TabIndex = 8
        ' 
        ' TextBox_Countries
        ' 
        TextBox_Countries.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox_Countries.Location = New Point(268, 572)
        TextBox_Countries.Name = "TextBox_Countries"
        TextBox_Countries.ReadOnly = True
        TextBox_Countries.Size = New Size(240, 29)
        TextBox_Countries.TabIndex = 31
        ' 
        ' ComboBox_Genre
        ' 
        ComboBox_Genre.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ComboBox_Genre.FormattingEnabled = True
        ComboBox_Genre.Items.AddRange(New Object() {"Action", "Adventure", "Animation", "Biography", "Comedy", "Crime", "Drama", "Family", "Fantasy", "History", "Musical", "Mystery", "Romance", "Sci-Fi", "Sport", "Thriller", "War", "Western"})
        ComboBox_Genre.Location = New Point(101, 219)
        ComboBox_Genre.Name = "ComboBox_Genre"
        ComboBox_Genre.Size = New Size(161, 29)
        ComboBox_Genre.TabIndex = 2
        ' 
        ' ComboBox_Language
        ' 
        ComboBox_Language.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ComboBox_Language.FormattingEnabled = True
        ComboBox_Language.Items.AddRange(New Object() {"Aramaic", "Cantonese", "English", "French", "Italian", "German", "Japanese", "Korean", "Portuguese", "Spanish", "Swedish"})
        ComboBox_Language.Location = New Point(101, 358)
        ComboBox_Language.Name = "ComboBox_Language"
        ComboBox_Language.Size = New Size(161, 29)
        ComboBox_Language.TabIndex = 5
        ' 
        ' Button_Clear_Genre
        ' 
        Button_Clear_Genre.BackColor = Color.White
        Button_Clear_Genre.FlatAppearance.BorderColor = Color.Black
        Button_Clear_Genre.FlatAppearance.BorderSize = 4
        Button_Clear_Genre.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(245), CByte(200), CByte(35))
        Button_Clear_Genre.FlatStyle = FlatStyle.Flat
        Button_Clear_Genre.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point)
        Button_Clear_Genre.ForeColor = Color.Black
        Button_Clear_Genre.Location = New Point(449, 219)
        Button_Clear_Genre.Name = "Button_Clear_Genre"
        Button_Clear_Genre.Size = New Size(59, 30)
        Button_Clear_Genre.TabIndex = 32
        Button_Clear_Genre.Text = "CLEAR"
        Button_Clear_Genre.UseVisualStyleBackColor = False
        ' 
        ' Button_Clear_Language
        ' 
        Button_Clear_Language.BackColor = Color.White
        Button_Clear_Language.FlatAppearance.BorderColor = Color.Black
        Button_Clear_Language.FlatAppearance.BorderSize = 4
        Button_Clear_Language.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(245), CByte(200), CByte(35))
        Button_Clear_Language.FlatStyle = FlatStyle.Flat
        Button_Clear_Language.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point)
        Button_Clear_Language.ForeColor = Color.Black
        Button_Clear_Language.Location = New Point(449, 358)
        Button_Clear_Language.Name = "Button_Clear_Language"
        Button_Clear_Language.Size = New Size(59, 29)
        Button_Clear_Language.TabIndex = 33
        Button_Clear_Language.Text = "CLEAR"
        Button_Clear_Language.UseVisualStyleBackColor = False
        ' 
        ' Button_Clear_Country
        ' 
        Button_Clear_Country.BackColor = Color.White
        Button_Clear_Country.FlatAppearance.BorderColor = Color.Black
        Button_Clear_Country.FlatAppearance.BorderSize = 4
        Button_Clear_Country.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(245), CByte(200), CByte(35))
        Button_Clear_Country.FlatStyle = FlatStyle.Flat
        Button_Clear_Country.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point)
        Button_Clear_Country.ForeColor = Color.Black
        Button_Clear_Country.Location = New Point(449, 572)
        Button_Clear_Country.Name = "Button_Clear_Country"
        Button_Clear_Country.Size = New Size(59, 29)
        Button_Clear_Country.TabIndex = 34
        Button_Clear_Country.Text = "CLEAR"
        Button_Clear_Country.UseVisualStyleBackColor = False
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
        Button_Dashboard.Location = New Point(544, 46)
        Button_Dashboard.Name = "Button_Dashboard"
        Button_Dashboard.Size = New Size(260, 50)
        Button_Dashboard.TabIndex = 38
        Button_Dashboard.Text = "DASHBOARD"
        Button_Dashboard.UseVisualStyleBackColor = False
        ' 
        ' AddMovie
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(50), CByte(90), CByte(235))
        ClientSize = New Size(1484, 761)
        Controls.Add(Button_Dashboard)
        Controls.Add(Button_Clear_Country)
        Controls.Add(Button_Clear_Language)
        Controls.Add(Button_Clear_Genre)
        Controls.Add(ComboBox_Language)
        Controls.Add(ComboBox_Genre)
        Controls.Add(TextBox_Countries)
        Controls.Add(ComboBox_Country)
        Controls.Add(Button_Upload_Picture_Download)
        Controls.Add(Label_Display_Access_Level)
        Controls.Add(Label_Display_Username)
        Controls.Add(Label_Access_Level)
        Controls.Add(Label_Username)
        Controls.Add(Button_Upload_Picture_URL)
        Controls.Add(Button_Clear)
        Controls.Add(Button_Add_Movie)
        Controls.Add(TextBox_Resume)
        Controls.Add(Label1)
        Controls.Add(TextBox3)
        Controls.Add(Label_Poster_URL)
        Controls.Add(Label_Poster)
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
        Controls.Add(DomainUpDown_Release_Year)
        Controls.Add(Label_Release_Year)
        Controls.Add(TextBox_Genre)
        Controls.Add(Label_Genre)
        Controls.Add(TextBox_Title)
        Controls.Add(Label_Title_Movie)
        Controls.Add(Label_Title)
        ForeColor = SystemColors.ButtonHighlight
        Name = "AddMovie"
        StartPosition = FormStartPosition.CenterScreen
        Text = "AddMovie"
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
    Friend WithEvents DomainUpDown_Release_Year As DomainUpDown
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
    Friend WithEvents Label_Poster As Label
    Friend WithEvents Label_Poster_URL As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox_Resume As TextBox
    Friend WithEvents Button_Add_Movie As Button
    Friend WithEvents Button_Clear As Button
    Friend WithEvents Button_Upload_Picture_URL As Button
    Friend WithEvents Label_Username As Label
    Friend WithEvents Label_Access_Level As Label
    Friend WithEvents Label_Display_Username As Label
    Friend WithEvents Label_Display_Access_Level As Label
    Friend WithEvents Button_Upload_Picture_Download As Button
    Friend WithEvents ComboBox_Country As ComboBox
    Friend WithEvents TextBox_Countries As TextBox
    Friend WithEvents ComboBox_Genre As ComboBox
    Friend WithEvents ComboBox_Language As ComboBox
    Friend WithEvents Button_Clear_Genre As Button
    Friend WithEvents Button_Clear_Language As Button
    Friend WithEvents Button_Clear_Country As Button
    Friend WithEvents Button_Dashboard As Button
End Class
