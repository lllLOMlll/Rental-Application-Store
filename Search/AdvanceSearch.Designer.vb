<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdvanceSearch

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
        Label_Video_Id = New Label()
        TextBox_Movie_ID = New TextBox()
        Label_Movie_Title = New Label()
        TextBox_Title = New TextBox()
        Button_Quick_Search = New Button()
        Button_Rent = New Button()
        Button_Clear = New Button()
        Label_Instruction = New Label()
        TextBox_Selected_Movie_Id = New TextBox()
        Button_Edit = New Button()
        ComboBox_Genre = New ComboBox()
        TextBox_Genre = New TextBox()
        Label_Genre = New Label()
        Label_Release_Year = New Label()
        TextBox_Run_Time = New TextBox()
        Label_Run_Time = New Label()
        Label_Original_Language = New Label()
        ComboBox_Language = New ComboBox()
        TextBox_Original_Language = New TextBox()
        Label_Director = New Label()
        TextBox_Director = New TextBox()
        TextBox_Starring = New TextBox()
        Label_Starring = New Label()
        Label_Country = New Label()
        ComboBox_Country = New ComboBox()
        TextBox_Countries = New TextBox()
        Label1 = New Label()
        TextBox_Resume = New TextBox()
        DataGridView_Advance_Search = New DataGridView()
        TextBox_Release_Year = New TextBox()
        Button_Dashboard = New Button()
        CType(DataGridView_Advance_Search, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label_Title
        ' 
        Label_Title.AutoSize = True
        Label_Title.Font = New Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point)
        Label_Title.ForeColor = Color.FromArgb(CByte(245), CByte(200), CByte(35))
        Label_Title.Location = New Point(33, 41)
        Label_Title.Name = "Label_Title"
        Label_Title.Size = New Size(538, 65)
        Label_Title.TabIndex = 1
        Label_Title.Text = "Advance Search Movie"
        ' 
        ' Label_Username
        ' 
        Label_Username.AutoSize = True
        Label_Username.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label_Username.Location = New Point(1000, 41)
        Label_Username.Name = "Label_Username"
        Label_Username.Size = New Size(88, 21)
        Label_Username.TabIndex = 4
        Label_Username.Text = "Username :"
        ' 
        ' Label_Access_Level
        ' 
        Label_Access_Level.AutoSize = True
        Label_Access_Level.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label_Access_Level.Location = New Point(985, 76)
        Label_Access_Level.Name = "Label_Access_Level"
        Label_Access_Level.Size = New Size(103, 21)
        Label_Access_Level.TabIndex = 5
        Label_Access_Level.Text = "Access Level :"
        ' 
        ' Label_Display_Username
        ' 
        Label_Display_Username.AutoSize = True
        Label_Display_Username.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label_Display_Username.ForeColor = Color.FromArgb(CByte(245), CByte(200), CByte(35))
        Label_Display_Username.Location = New Point(1094, 41)
        Label_Display_Username.Name = "Label_Display_Username"
        Label_Display_Username.Size = New Size(83, 21)
        Label_Display_Username.TabIndex = 29
        Label_Display_Username.Text = "Username"
        ' 
        ' Label_Display_Access_Level
        ' 
        Label_Display_Access_Level.AutoSize = True
        Label_Display_Access_Level.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label_Display_Access_Level.ForeColor = Color.FromArgb(CByte(245), CByte(200), CByte(35))
        Label_Display_Access_Level.Location = New Point(1094, 76)
        Label_Display_Access_Level.Name = "Label_Display_Access_Level"
        Label_Display_Access_Level.Size = New Size(102, 21)
        Label_Display_Access_Level.TabIndex = 30
        Label_Display_Access_Level.Text = "Access Level"
        ' 
        ' Label_Video_Id
        ' 
        Label_Video_Id.AutoSize = True
        Label_Video_Id.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label_Video_Id.Location = New Point(540, 135)
        Label_Video_Id.Name = "Label_Video_Id"
        Label_Video_Id.Size = New Size(76, 21)
        Label_Video_Id.TabIndex = 31
        Label_Video_Id.Text = "Movie ID"
        ' 
        ' TextBox_Movie_ID
        ' 
        TextBox_Movie_ID.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox_Movie_ID.Location = New Point(618, 132)
        TextBox_Movie_ID.Name = "TextBox_Movie_ID"
        TextBox_Movie_ID.Size = New Size(312, 29)
        TextBox_Movie_ID.TabIndex = 32
        ' 
        ' Label_Movie_Title
        ' 
        Label_Movie_Title.AutoSize = True
        Label_Movie_Title.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label_Movie_Title.Location = New Point(84, 135)
        Label_Movie_Title.Name = "Label_Movie_Title"
        Label_Movie_Title.Size = New Size(42, 21)
        Label_Movie_Title.TabIndex = 33
        Label_Movie_Title.Text = "Title"
        ' 
        ' TextBox_Title
        ' 
        TextBox_Title.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox_Title.Location = New Point(138, 135)
        TextBox_Title.Name = "TextBox_Title"
        TextBox_Title.Size = New Size(312, 29)
        TextBox_Title.TabIndex = 34
        ' 
        ' Button_Quick_Search
        ' 
        Button_Quick_Search.BackColor = Color.White
        Button_Quick_Search.FlatAppearance.BorderSize = 4
        Button_Quick_Search.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(245), CByte(200), CByte(35))
        Button_Quick_Search.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(245), CByte(200), CByte(35))
        Button_Quick_Search.FlatStyle = FlatStyle.Flat
        Button_Quick_Search.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Button_Quick_Search.ForeColor = Color.Black
        Button_Quick_Search.Location = New Point(1016, 385)
        Button_Quick_Search.Name = "Button_Quick_Search"
        Button_Quick_Search.Size = New Size(275, 71)
        Button_Quick_Search.TabIndex = 35
        Button_Quick_Search.Text = "SEARCH"
        Button_Quick_Search.UseVisualStyleBackColor = False
        ' 
        ' Button_Rent
        ' 
        Button_Rent.BackColor = Color.White
        Button_Rent.FlatAppearance.BorderSize = 4
        Button_Rent.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(245), CByte(200), CByte(35))
        Button_Rent.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(245), CByte(200), CByte(35))
        Button_Rent.FlatStyle = FlatStyle.Flat
        Button_Rent.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Button_Rent.ForeColor = Color.Black
        Button_Rent.Location = New Point(93, 668)
        Button_Rent.Name = "Button_Rent"
        Button_Rent.Size = New Size(275, 71)
        Button_Rent.TabIndex = 37
        Button_Rent.Text = "RENT"
        Button_Rent.UseVisualStyleBackColor = False
        ' 
        ' Button_Clear
        ' 
        Button_Clear.BackColor = Color.White
        Button_Clear.FlatAppearance.BorderSize = 4
        Button_Clear.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(245), CByte(200), CByte(35))
        Button_Clear.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(245), CByte(200), CByte(35))
        Button_Clear.FlatStyle = FlatStyle.Flat
        Button_Clear.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Button_Clear.ForeColor = Color.Black
        Button_Clear.Location = New Point(655, 668)
        Button_Clear.Name = "Button_Clear"
        Button_Clear.Size = New Size(275, 71)
        Button_Clear.TabIndex = 38
        Button_Clear.Text = "CLEAR"
        Button_Clear.UseVisualStyleBackColor = False
        ' 
        ' Label_Instruction
        ' 
        Label_Instruction.AutoSize = True
        Label_Instruction.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label_Instruction.Location = New Point(93, 443)
        Label_Instruction.Name = "Label_Instruction"
        Label_Instruction.Size = New Size(303, 25)
        Label_Instruction.TabIndex = 39
        Label_Instruction.Text = "Click on a movie to upload the ID "
        ' 
        ' TextBox_Selected_Movie_Id
        ' 
        TextBox_Selected_Movie_Id.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox_Selected_Movie_Id.Location = New Point(402, 443)
        TextBox_Selected_Movie_Id.Name = "TextBox_Selected_Movie_Id"
        TextBox_Selected_Movie_Id.ReadOnly = True
        TextBox_Selected_Movie_Id.Size = New Size(142, 29)
        TextBox_Selected_Movie_Id.TabIndex = 40
        ' 
        ' Button_Edit
        ' 
        Button_Edit.BackColor = Color.White
        Button_Edit.FlatAppearance.BorderSize = 4
        Button_Edit.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(245), CByte(200), CByte(35))
        Button_Edit.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(245), CByte(200), CByte(35))
        Button_Edit.FlatStyle = FlatStyle.Flat
        Button_Edit.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Button_Edit.ForeColor = Color.Black
        Button_Edit.Location = New Point(374, 668)
        Button_Edit.Name = "Button_Edit"
        Button_Edit.Size = New Size(275, 71)
        Button_Edit.TabIndex = 41
        Button_Edit.Text = "EDIT"
        Button_Edit.UseVisualStyleBackColor = False
        ' 
        ' ComboBox_Genre
        ' 
        ComboBox_Genre.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ComboBox_Genre.FormattingEnabled = True
        ComboBox_Genre.Items.AddRange(New Object() {"Action", "Adventure", "Animation", "Biography", "Comedy", "Crime", "Drama", "Family", "Fantasy", "History", "Musical", "Mystery", "Romance", "Sci-Fi", "Sport", "Thriller", "War", "Western"})
        ComboBox_Genre.Location = New Point(84, 233)
        ComboBox_Genre.Name = "ComboBox_Genre"
        ComboBox_Genre.Size = New Size(161, 29)
        ComboBox_Genre.TabIndex = 43
        ' 
        ' TextBox_Genre
        ' 
        TextBox_Genre.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox_Genre.Location = New Point(251, 233)
        TextBox_Genre.Name = "TextBox_Genre"
        TextBox_Genre.Size = New Size(240, 29)
        TextBox_Genre.TabIndex = 44
        ' 
        ' Label_Genre
        ' 
        Label_Genre.AutoSize = True
        Label_Genre.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label_Genre.Location = New Point(84, 209)
        Label_Genre.Name = "Label_Genre"
        Label_Genre.Size = New Size(54, 21)
        Label_Genre.TabIndex = 45
        Label_Genre.Text = "Genre"
        ' 
        ' Label_Release_Year
        ' 
        Label_Release_Year.AutoSize = True
        Label_Release_Year.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label_Release_Year.Location = New Point(84, 280)
        Label_Release_Year.Name = "Label_Release_Year"
        Label_Release_Year.Size = New Size(109, 21)
        Label_Release_Year.TabIndex = 46
        Label_Release_Year.Text = "Realease Year"
        ' 
        ' TextBox_Run_Time
        ' 
        TextBox_Run_Time.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox_Run_Time.Location = New Point(305, 303)
        TextBox_Run_Time.Name = "TextBox_Run_Time"
        TextBox_Run_Time.Size = New Size(186, 29)
        TextBox_Run_Time.TabIndex = 48
        ' 
        ' Label_Run_Time
        ' 
        Label_Run_Time.AutoSize = True
        Label_Run_Time.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label_Run_Time.Location = New Point(305, 279)
        Label_Run_Time.Name = "Label_Run_Time"
        Label_Run_Time.Size = New Size(119, 21)
        Label_Run_Time.TabIndex = 49
        Label_Run_Time.Text = "Run Time (min)"
        ' 
        ' Label_Original_Language
        ' 
        Label_Original_Language.AutoSize = True
        Label_Original_Language.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label_Original_Language.Location = New Point(84, 359)
        Label_Original_Language.Name = "Label_Original_Language"
        Label_Original_Language.Size = New Size(142, 21)
        Label_Original_Language.TabIndex = 50
        Label_Original_Language.Text = "Original Language"
        ' 
        ' ComboBox_Language
        ' 
        ComboBox_Language.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ComboBox_Language.FormattingEnabled = True
        ComboBox_Language.Items.AddRange(New Object() {"Aramaic", "Cantonese", "English", "French", "Italian", "German", "Japanese", "Korean", "Portuguese", "Spanish", "Swedish"})
        ComboBox_Language.Location = New Point(84, 385)
        ComboBox_Language.Name = "ComboBox_Language"
        ComboBox_Language.Size = New Size(161, 29)
        ComboBox_Language.TabIndex = 51
        ' 
        ' TextBox_Original_Language
        ' 
        TextBox_Original_Language.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox_Original_Language.Location = New Point(251, 385)
        TextBox_Original_Language.Name = "TextBox_Original_Language"
        TextBox_Original_Language.Size = New Size(240, 29)
        TextBox_Original_Language.TabIndex = 52
        ' 
        ' Label_Director
        ' 
        Label_Director.AutoSize = True
        Label_Director.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label_Director.Location = New Point(547, 209)
        Label_Director.Name = "Label_Director"
        Label_Director.Size = New Size(70, 21)
        Label_Director.TabIndex = 53
        Label_Director.Text = "Director"
        ' 
        ' TextBox_Director
        ' 
        TextBox_Director.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox_Director.Location = New Point(547, 233)
        TextBox_Director.Name = "TextBox_Director"
        TextBox_Director.Size = New Size(407, 29)
        TextBox_Director.TabIndex = 54
        ' 
        ' TextBox_Starring
        ' 
        TextBox_Starring.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox_Starring.Location = New Point(547, 303)
        TextBox_Starring.Name = "TextBox_Starring"
        TextBox_Starring.Size = New Size(407, 29)
        TextBox_Starring.TabIndex = 55
        ' 
        ' Label_Starring
        ' 
        Label_Starring.AutoSize = True
        Label_Starring.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label_Starring.Location = New Point(549, 279)
        Label_Starring.Name = "Label_Starring"
        Label_Starring.Size = New Size(68, 21)
        Label_Starring.TabIndex = 56
        Label_Starring.Text = "Starring"
        ' 
        ' Label_Country
        ' 
        Label_Country.AutoSize = True
        Label_Country.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label_Country.Location = New Point(547, 359)
        Label_Country.Name = "Label_Country"
        Label_Country.Size = New Size(69, 21)
        Label_Country.TabIndex = 57
        Label_Country.Text = "Country"
        ' 
        ' ComboBox_Country
        ' 
        ComboBox_Country.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ComboBox_Country.FormattingEnabled = True
        ComboBox_Country.Items.AddRange(New Object() {" Algeria", "Australia", "Austria", "Brazil", "China", "Czech Republic", "France", "Germany", "Hong Kong ", "India", "Italy", "Japan", "Malta", "Mexico", "New Zealand", "Poland", "South Africa", "South Korea", "Spain", "Sweden", "Taiwan", "UK", "West Germany", "Canada", "USA", ""})
        ComboBox_Country.Location = New Point(547, 385)
        ComboBox_Country.Name = "ComboBox_Country"
        ComboBox_Country.Size = New Size(161, 29)
        ComboBox_Country.TabIndex = 58
        ' 
        ' TextBox_Countries
        ' 
        TextBox_Countries.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox_Countries.Location = New Point(714, 385)
        TextBox_Countries.Name = "TextBox_Countries"
        TextBox_Countries.ReadOnly = True
        TextBox_Countries.Size = New Size(240, 29)
        TextBox_Countries.TabIndex = 59
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(1016, 209)
        Label1.Name = "Label1"
        Label1.Size = New Size(68, 21)
        Label1.TabIndex = 60
        Label1.Text = "Resume"
        ' 
        ' TextBox_Resume
        ' 
        TextBox_Resume.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox_Resume.Location = New Point(1016, 233)
        TextBox_Resume.Multiline = True
        TextBox_Resume.Name = "TextBox_Resume"
        TextBox_Resume.Size = New Size(385, 120)
        TextBox_Resume.TabIndex = 61
        ' 
        ' DataGridView_Advance_Search
        ' 
        DataGridView_Advance_Search.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView_Advance_Search.Location = New Point(93, 482)
        DataGridView_Advance_Search.Name = "DataGridView_Advance_Search"
        DataGridView_Advance_Search.RowTemplate.Height = 25
        DataGridView_Advance_Search.Size = New Size(1308, 152)
        DataGridView_Advance_Search.TabIndex = 36
        ' 
        ' TextBox_Release_Year
        ' 
        TextBox_Release_Year.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox_Release_Year.Location = New Point(84, 303)
        TextBox_Release_Year.Name = "TextBox_Release_Year"
        TextBox_Release_Year.Size = New Size(186, 29)
        TextBox_Release_Year.TabIndex = 62
        ' 
        ' Button_Dashboard
        ' 
        Button_Dashboard.BackColor = Color.White
        Button_Dashboard.FlatAppearance.BorderSize = 4
        Button_Dashboard.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(245), CByte(200), CByte(35))
        Button_Dashboard.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(245), CByte(200), CByte(35))
        Button_Dashboard.FlatStyle = FlatStyle.Flat
        Button_Dashboard.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Button_Dashboard.ForeColor = Color.Black
        Button_Dashboard.Location = New Point(631, 47)
        Button_Dashboard.Name = "Button_Dashboard"
        Button_Dashboard.Size = New Size(260, 50)
        Button_Dashboard.TabIndex = 63
        Button_Dashboard.Text = "DASHBOARD"
        Button_Dashboard.UseVisualStyleBackColor = False
        ' 
        ' AdvanceSearch
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(50), CByte(90), CByte(235))
        ClientSize = New Size(1484, 761)
        Controls.Add(Button_Dashboard)
        Controls.Add(TextBox_Release_Year)
        Controls.Add(TextBox_Resume)
        Controls.Add(Label1)
        Controls.Add(TextBox_Countries)
        Controls.Add(ComboBox_Country)
        Controls.Add(Label_Country)
        Controls.Add(Label_Starring)
        Controls.Add(TextBox_Starring)
        Controls.Add(TextBox_Director)
        Controls.Add(Label_Director)
        Controls.Add(TextBox_Original_Language)
        Controls.Add(ComboBox_Language)
        Controls.Add(Label_Original_Language)
        Controls.Add(Label_Run_Time)
        Controls.Add(TextBox_Run_Time)
        Controls.Add(Label_Release_Year)
        Controls.Add(Label_Genre)
        Controls.Add(TextBox_Genre)
        Controls.Add(ComboBox_Genre)
        Controls.Add(Button_Edit)
        Controls.Add(TextBox_Selected_Movie_Id)
        Controls.Add(Label_Instruction)
        Controls.Add(Button_Clear)
        Controls.Add(Button_Rent)
        Controls.Add(DataGridView_Advance_Search)
        Controls.Add(Button_Quick_Search)
        Controls.Add(TextBox_Title)
        Controls.Add(Label_Movie_Title)
        Controls.Add(TextBox_Movie_ID)
        Controls.Add(Label_Video_Id)
        Controls.Add(Label_Display_Access_Level)
        Controls.Add(Label_Display_Username)
        Controls.Add(Label_Access_Level)
        Controls.Add(Label_Username)
        Controls.Add(Label_Title)
        ForeColor = Color.White
        Name = "AdvanceSearch"
        StartPosition = FormStartPosition.CenterScreen
        Text = "AdvanceSearch"
        CType(DataGridView_Advance_Search, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label_Title As Label
    Friend WithEvents Label_Username As Label
    Friend WithEvents Label_Access_Level As Label
    Friend WithEvents Label_Display_Username As Label
    Friend WithEvents Label_Display_Access_Level As Label
    Friend WithEvents Label_Video_Id As Label
    Friend WithEvents TextBox_Movie_ID As TextBox
    Friend WithEvents Label_Movie_Title As Label
    Friend WithEvents TextBox_Title As TextBox
    Friend WithEvents Button_Quick_Search As Button
    Friend WithEvents Button_Rent As Button
    Friend WithEvents Button_Clear As Button
    Friend WithEvents Label_Instruction As Label
    Friend WithEvents TextBox_Selected_Movie_Id As TextBox
    Friend WithEvents Button_Edit As Button
    Friend WithEvents ComboBox_Genre As ComboBox
    Friend WithEvents TextBox_Genre As TextBox
    Friend WithEvents Label_Genre As Label
    Friend WithEvents Label_Release_Year As Label
    Friend WithEvents TextBox_Run_Time As TextBox
    Friend WithEvents Label_Run_Time As Label
    Friend WithEvents Label_Original_Language As Label
    Friend WithEvents ComboBox_Language As ComboBox
    Friend WithEvents TextBox_Original_Language As TextBox
    Friend WithEvents Label_Director As Label
    Friend WithEvents TextBox_Director As TextBox
    Friend WithEvents TextBox_Starring As TextBox
    Friend WithEvents Label_Starring As Label
    Friend WithEvents Label_Country As Label
    Friend WithEvents ComboBox_Country As ComboBox
    Friend WithEvents TextBox_Countries As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox_Resume As TextBox
    Friend WithEvents DataGridView_Advance_Search As DataGridView
    Friend WithEvents TextBox_Release_Year As TextBox
    Friend WithEvents Button_Dashboard As Button
End Class
