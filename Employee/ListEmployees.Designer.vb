﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListEmployees
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
        components = New ComponentModel.Container()
        Label_Title = New Label()
        DataGridView_List_Employees = New DataGridView()
        DbManagerEmployeeBindingSource = New BindingSource(components)
        Label_Username = New Label()
        Label_Access_Level = New Label()
        Label_Display_Username = New Label()
        Label_Display_Access_Level = New Label()
        Button_Dashboard = New Button()
        CType(DataGridView_List_Employees, ComponentModel.ISupportInitialize).BeginInit()
        CType(DbManagerEmployeeBindingSource, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label_Title
        ' 
        Label_Title.AutoSize = True
        Label_Title.Font = New Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point)
        Label_Title.ForeColor = Color.FromArgb(CByte(245), CByte(200), CByte(35))
        Label_Title.Location = New Point(38, 49)
        Label_Title.Name = "Label_Title"
        Label_Title.Size = New Size(357, 65)
        Label_Title.TabIndex = 0
        Label_Title.Text = "Employess List"
        ' 
        ' DataGridView_List_Employees
        ' 
        DataGridView_List_Employees.AllowUserToDeleteRows = False
        DataGridView_List_Employees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView_List_Employees.Location = New Point(38, 128)
        DataGridView_List_Employees.Name = "DataGridView_List_Employees"
        DataGridView_List_Employees.ReadOnly = True
        DataGridView_List_Employees.RowTemplate.Height = 25
        DataGridView_List_Employees.Size = New Size(1408, 580)
        DataGridView_List_Employees.TabIndex = 1
        ' 
        ' DbManagerEmployeeBindingSource
        ' 
        DbManagerEmployeeBindingSource.DataSource = GetType(DbManagerEmployee)
        ' 
        ' Label_Username
        ' 
        Label_Username.AutoSize = True
        Label_Username.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label_Username.ForeColor = Color.White
        Label_Username.Location = New Point(1138, 49)
        Label_Username.Name = "Label_Username"
        Label_Username.Size = New Size(88, 21)
        Label_Username.TabIndex = 2
        Label_Username.Text = "Username :"
        ' 
        ' Label_Access_Level
        ' 
        Label_Access_Level.AutoSize = True
        Label_Access_Level.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label_Access_Level.ForeColor = Color.White
        Label_Access_Level.Location = New Point(1123, 84)
        Label_Access_Level.Name = "Label_Access_Level"
        Label_Access_Level.Size = New Size(103, 21)
        Label_Access_Level.TabIndex = 3
        Label_Access_Level.Text = "Access Level :"
        ' 
        ' Label_Display_Username
        ' 
        Label_Display_Username.AutoSize = True
        Label_Display_Username.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label_Display_Username.ForeColor = Color.FromArgb(CByte(245), CByte(200), CByte(35))
        Label_Display_Username.Location = New Point(1232, 49)
        Label_Display_Username.Name = "Label_Display_Username"
        Label_Display_Username.Size = New Size(83, 21)
        Label_Display_Username.TabIndex = 4
        Label_Display_Username.Text = "Username"
        ' 
        ' Label_Display_Access_Level
        ' 
        Label_Display_Access_Level.AutoSize = True
        Label_Display_Access_Level.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label_Display_Access_Level.ForeColor = Color.FromArgb(CByte(245), CByte(200), CByte(35))
        Label_Display_Access_Level.Location = New Point(1232, 84)
        Label_Display_Access_Level.Name = "Label_Display_Access_Level"
        Label_Display_Access_Level.Size = New Size(102, 21)
        Label_Display_Access_Level.TabIndex = 5
        Label_Display_Access_Level.Text = "Access Level"
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
        Button_Dashboard.Location = New Point(591, 55)
        Button_Dashboard.Name = "Button_Dashboard"
        Button_Dashboard.Size = New Size(260, 50)
        Button_Dashboard.TabIndex = 38
        Button_Dashboard.Text = "DASHBOARD"
        Button_Dashboard.UseVisualStyleBackColor = False
        ' 
        ' ListEmployees
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(51), CByte(88), CByte(236))
        ClientSize = New Size(1484, 761)
        Controls.Add(Button_Dashboard)
        Controls.Add(Label_Display_Access_Level)
        Controls.Add(Label_Display_Username)
        Controls.Add(Label_Access_Level)
        Controls.Add(Label_Username)
        Controls.Add(DataGridView_List_Employees)
        Controls.Add(Label_Title)
        ForeColor = Color.FromArgb(CByte(245), CByte(200), CByte(35))
        Name = "ListEmployees"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Employees List"
        CType(DataGridView_List_Employees, ComponentModel.ISupportInitialize).EndInit()
        CType(DbManagerEmployeeBindingSource, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label_Title As Label
    Friend WithEvents DataGridView_List_Employees As DataGridView
    Friend WithEvents DbManagerEmployeeBindingSource As BindingSource
    Friend WithEvents Label_Username As Label
    Friend WithEvents Label_Access_Level As Label
    Friend WithEvents Label_Display_Username As Label
    Friend WithEvents Label_Display_Access_Level As Label
    Friend WithEvents Button_Dashboard As Button
End Class
