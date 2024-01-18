<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QuickSearch
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
        Label_Username = New Label()
        Label_Access_Level = New Label()
        Label_Display_Username = New Label()
        Label_Display_Access_Level = New Label()
        Label_Video_Id = New Label()
        TextBox_Movie_ID = New TextBox()
        Label_Movie_Title = New Label()
        TextBox_Title = New TextBox()
        Button_Quick_Search = New Button()
        DataGridView_Quick_Search = New DataGridView()
        Button_Rent = New Button()
        Button_Clear = New Button()
        Label_Instruction = New Label()
        TextBox_Selected_Movie_Id = New TextBox()
        Button_Edit = New Button()
        Button_Dashboard = New Button()
        CType(DataGridView_Quick_Search, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label_Title
        ' 
        Label_Title.AutoSize = True
        Label_Title.Font = New Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point)
        Label_Title.ForeColor = Color.FromArgb(CByte(245), CByte(200), CByte(35))
        Label_Title.Location = New Point(33, 41)
        Label_Title.Name = "Label_Title"
        Label_Title.Size = New Size(474, 65)
        Label_Title.TabIndex = 1
        Label_Title.Text = "Quick Search Movie"
        ' 
        ' Label_Username
        ' 
        Label_Username.AutoSize = True
        Label_Username.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label_Username.ForeColor = Color.White
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
        Label_Access_Level.ForeColor = Color.White
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
        Label_Video_Id.ForeColor = Color.White
        Label_Video_Id.Location = New Point(456, 138)
        Label_Video_Id.Name = "Label_Video_Id"
        Label_Video_Id.Size = New Size(76, 21)
        Label_Video_Id.TabIndex = 31
        Label_Video_Id.Text = "Movie ID"
        ' 
        ' TextBox_Movie_ID
        ' 
        TextBox_Movie_ID.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox_Movie_ID.Location = New Point(538, 138)
        TextBox_Movie_ID.Name = "TextBox_Movie_ID"
        TextBox_Movie_ID.Size = New Size(312, 29)
        TextBox_Movie_ID.TabIndex = 32
        ' 
        ' Label_Movie_Title
        ' 
        Label_Movie_Title.AutoSize = True
        Label_Movie_Title.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label_Movie_Title.ForeColor = Color.White
        Label_Movie_Title.Location = New Point(45, 138)
        Label_Movie_Title.Name = "Label_Movie_Title"
        Label_Movie_Title.Size = New Size(42, 21)
        Label_Movie_Title.TabIndex = 33
        Label_Movie_Title.Text = "Title"
        ' 
        ' TextBox_Title
        ' 
        TextBox_Title.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox_Title.Location = New Point(93, 138)
        TextBox_Title.Name = "TextBox_Title"
        TextBox_Title.Size = New Size(312, 29)
        TextBox_Title.TabIndex = 34
        ' 
        ' Button_Quick_Search
        ' 
        Button_Quick_Search.BackColor = Color.White
        Button_Quick_Search.FlatAppearance.BorderSize = 4
        Button_Quick_Search.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(245), CByte(200), CByte(35))
        Button_Quick_Search.FlatStyle = FlatStyle.Flat
        Button_Quick_Search.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Button_Quick_Search.Location = New Point(93, 190)
        Button_Quick_Search.Name = "Button_Quick_Search"
        Button_Quick_Search.Size = New Size(275, 71)
        Button_Quick_Search.TabIndex = 35
        Button_Quick_Search.Text = "SEARCH"
        Button_Quick_Search.UseVisualStyleBackColor = False
        ' 
        ' DataGridView_Quick_Search
        ' 
        DataGridView_Quick_Search.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView_Quick_Search.Location = New Point(93, 321)
        DataGridView_Quick_Search.Name = "DataGridView_Quick_Search"
        DataGridView_Quick_Search.RowTemplate.Height = 25
        DataGridView_Quick_Search.Size = New Size(1308, 313)
        DataGridView_Quick_Search.TabIndex = 36
        ' 
        ' Button_Rent
        ' 
        Button_Rent.BackColor = Color.White
        Button_Rent.FlatAppearance.BorderSize = 4
        Button_Rent.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(245), CByte(200), CByte(35))
        Button_Rent.FlatStyle = FlatStyle.Flat
        Button_Rent.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
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
        Button_Clear.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(245), CByte(200), CByte(35))
        Button_Clear.FlatStyle = FlatStyle.Flat
        Button_Clear.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
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
        Label_Instruction.ForeColor = Color.White
        Label_Instruction.Location = New Point(93, 286)
        Label_Instruction.Name = "Label_Instruction"
        Label_Instruction.Size = New Size(303, 25)
        Label_Instruction.TabIndex = 39
        Label_Instruction.Text = "Click on a movie to upload the ID "
        ' 
        ' TextBox_Selected_Movie_Id
        ' 
        TextBox_Selected_Movie_Id.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox_Selected_Movie_Id.Location = New Point(390, 286)
        TextBox_Selected_Movie_Id.Name = "TextBox_Selected_Movie_Id"
        TextBox_Selected_Movie_Id.ReadOnly = True
        TextBox_Selected_Movie_Id.Size = New Size(142, 29)
        TextBox_Selected_Movie_Id.TabIndex = 40
        ' 
        ' Button_Edit
        ' 
        Button_Edit.BackColor = Color.White
        Button_Edit.FlatAppearance.BorderSize = 4
        Button_Edit.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(245), CByte(200), CByte(35))
        Button_Edit.FlatStyle = FlatStyle.Flat
        Button_Edit.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Button_Edit.Location = New Point(374, 668)
        Button_Edit.Name = "Button_Edit"
        Button_Edit.Size = New Size(275, 71)
        Button_Edit.TabIndex = 41
        Button_Edit.Text = "EDIT"
        Button_Edit.UseVisualStyleBackColor = False
        ' 
        ' Button_Dashboard
        ' 
        Button_Dashboard.BackColor = Color.White
        Button_Dashboard.FlatAppearance.BorderSize = 4
        Button_Dashboard.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(245), CByte(200), CByte(35))
        Button_Dashboard.FlatStyle = FlatStyle.Flat
        Button_Dashboard.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Button_Dashboard.Location = New Point(590, 47)
        Button_Dashboard.Name = "Button_Dashboard"
        Button_Dashboard.Size = New Size(260, 50)
        Button_Dashboard.TabIndex = 42
        Button_Dashboard.Text = "DASHBOARD"
        Button_Dashboard.UseVisualStyleBackColor = False
        ' 
        ' QuickSearch
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(50), CByte(90), CByte(235))
        ClientSize = New Size(1484, 761)
        Controls.Add(Button_Dashboard)
        Controls.Add(Button_Edit)
        Controls.Add(TextBox_Selected_Movie_Id)
        Controls.Add(Label_Instruction)
        Controls.Add(Button_Clear)
        Controls.Add(Button_Rent)
        Controls.Add(DataGridView_Quick_Search)
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
        Name = "QuickSearch"
        StartPosition = FormStartPosition.CenterScreen
        Text = "QuickSearch"
        CType(DataGridView_Quick_Search, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents DataGridView_Quick_Search As DataGridView
    Friend WithEvents Button_Rent As Button
    Friend WithEvents Button_Clear As Button
    Friend WithEvents Label_Instruction As Label
    Friend WithEvents TextBox_Selected_Movie_Id As TextBox
    Friend WithEvents Button_Edit As Button
    Friend WithEvents Button_Dashboard As Button
End Class
