<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CommonMenuControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        MenuStrip1 = New MenuStrip()
        ToolStripMenuItem1 = New ToolStripMenuItem()
        ChangePasswordToolStripMenuItem = New ToolStripMenuItem()
        LogoutToolStripMenuItem = New ToolStripMenuItem()
        ExitToolStripMenuItem = New ToolStripMenuItem()
        EmployeeToolStripMenuItem = New ToolStripMenuItem()
        ListToolStripMenuItem = New ToolStripMenuItem()
        CreateToolStripMenuItem = New ToolStripMenuItem()
        EditToolStripMenuItem = New ToolStripMenuItem()
        DeleteToolStripMenuItem = New ToolStripMenuItem()
        MovieToolStripMenuItem = New ToolStripMenuItem()
        ListToolStripMenuItem1 = New ToolStripMenuItem()
        CreateToolStripMenuItem1 = New ToolStripMenuItem()
        EditToolStripMenuItem1 = New ToolStripMenuItem()
        DeleteToolStripMenuItem1 = New ToolStripMenuItem()
        ClientToolStripMenuItem = New ToolStripMenuItem()
        ListToolStripMenuItem2 = New ToolStripMenuItem()
        CreateToolStripMenuItem2 = New ToolStripMenuItem()
        EditToolStripMenuItem2 = New ToolStripMenuItem()
        DeleteToolStripMenuItem2 = New ToolStripMenuItem()
        SearchToolStripMenuItem = New ToolStripMenuItem()
        QuickToolStripMenuItem = New ToolStripMenuItem()
        AdvanceToolStripMenuItem = New ToolStripMenuItem()
        RentToolStripMenuItem = New ToolStripMenuItem()
        RendVideoToolStripMenuItem = New ToolStripMenuItem()
        ListOfRentedVideoToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {ToolStripMenuItem1, EmployeeToolStripMenuItem, MovieToolStripMenuItem, ClientToolStripMenuItem, SearchToolStripMenuItem, RentToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(1500, 24)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' ToolStripMenuItem1
        ' 
        ToolStripMenuItem1.DropDownItems.AddRange(New ToolStripItem() {ChangePasswordToolStripMenuItem, LogoutToolStripMenuItem, ExitToolStripMenuItem})
        ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        ToolStripMenuItem1.Size = New Size(37, 20)
        ToolStripMenuItem1.Text = "&File"
        ' 
        ' ChangePasswordToolStripMenuItem
        ' 
        ChangePasswordToolStripMenuItem.Name = "ChangePasswordToolStripMenuItem"
        ChangePasswordToolStripMenuItem.Size = New Size(168, 22)
        ChangePasswordToolStripMenuItem.Text = "&Change Password"
        ' 
        ' LogoutToolStripMenuItem
        ' 
        LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        LogoutToolStripMenuItem.Size = New Size(168, 22)
        LogoutToolStripMenuItem.Text = "&Logout"
        ' 
        ' ExitToolStripMenuItem
        ' 
        ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        ExitToolStripMenuItem.Size = New Size(168, 22)
        ExitToolStripMenuItem.Text = "&Exit"
        ' 
        ' EmployeeToolStripMenuItem
        ' 
        EmployeeToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ListToolStripMenuItem, CreateToolStripMenuItem, EditToolStripMenuItem, DeleteToolStripMenuItem})
        EmployeeToolStripMenuItem.Name = "EmployeeToolStripMenuItem"
        EmployeeToolStripMenuItem.Size = New Size(71, 20)
        EmployeeToolStripMenuItem.Text = "&Employee"
        ' 
        ' ListToolStripMenuItem
        ' 
        ListToolStripMenuItem.Name = "ListToolStripMenuItem"
        ListToolStripMenuItem.Size = New Size(108, 22)
        ListToolStripMenuItem.Text = "&List"
        ' 
        ' CreateToolStripMenuItem
        ' 
        CreateToolStripMenuItem.Name = "CreateToolStripMenuItem"
        CreateToolStripMenuItem.Size = New Size(108, 22)
        CreateToolStripMenuItem.Text = "&Create"
        ' 
        ' EditToolStripMenuItem
        ' 
        EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        EditToolStripMenuItem.Size = New Size(108, 22)
        EditToolStripMenuItem.Text = "&Edit"
        ' 
        ' DeleteToolStripMenuItem
        ' 
        DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        DeleteToolStripMenuItem.Size = New Size(108, 22)
        DeleteToolStripMenuItem.Text = "&Delete"
        ' 
        ' MovieToolStripMenuItem
        ' 
        MovieToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ListToolStripMenuItem1, CreateToolStripMenuItem1, EditToolStripMenuItem1, DeleteToolStripMenuItem1})
        MovieToolStripMenuItem.Name = "MovieToolStripMenuItem"
        MovieToolStripMenuItem.Size = New Size(52, 20)
        MovieToolStripMenuItem.Text = "&Movie"
        ' 
        ' ListToolStripMenuItem1
        ' 
        ListToolStripMenuItem1.Name = "ListToolStripMenuItem1"
        ListToolStripMenuItem1.Size = New Size(108, 22)
        ListToolStripMenuItem1.Text = "&List"
        ' 
        ' CreateToolStripMenuItem1
        ' 
        CreateToolStripMenuItem1.Name = "CreateToolStripMenuItem1"
        CreateToolStripMenuItem1.Size = New Size(108, 22)
        CreateToolStripMenuItem1.Text = "&Create"
        ' 
        ' EditToolStripMenuItem1
        ' 
        EditToolStripMenuItem1.Name = "EditToolStripMenuItem1"
        EditToolStripMenuItem1.Size = New Size(108, 22)
        EditToolStripMenuItem1.Text = "&Edit"
        ' 
        ' DeleteToolStripMenuItem1
        ' 
        DeleteToolStripMenuItem1.Name = "DeleteToolStripMenuItem1"
        DeleteToolStripMenuItem1.Size = New Size(108, 22)
        DeleteToolStripMenuItem1.Text = "&Delete"
        ' 
        ' ClientToolStripMenuItem
        ' 
        ClientToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ListToolStripMenuItem2, CreateToolStripMenuItem2, EditToolStripMenuItem2, DeleteToolStripMenuItem2})
        ClientToolStripMenuItem.Name = "ClientToolStripMenuItem"
        ClientToolStripMenuItem.Size = New Size(50, 20)
        ClientToolStripMenuItem.Text = "&Client"
        ' 
        ' ListToolStripMenuItem2
        ' 
        ListToolStripMenuItem2.Name = "ListToolStripMenuItem2"
        ListToolStripMenuItem2.Size = New Size(108, 22)
        ListToolStripMenuItem2.Text = "&List"
        ' 
        ' CreateToolStripMenuItem2
        ' 
        CreateToolStripMenuItem2.Name = "CreateToolStripMenuItem2"
        CreateToolStripMenuItem2.Size = New Size(108, 22)
        CreateToolStripMenuItem2.Text = "&Create"
        ' 
        ' EditToolStripMenuItem2
        ' 
        EditToolStripMenuItem2.Name = "EditToolStripMenuItem2"
        EditToolStripMenuItem2.Size = New Size(108, 22)
        EditToolStripMenuItem2.Text = "&Edit"
        ' 
        ' DeleteToolStripMenuItem2
        ' 
        DeleteToolStripMenuItem2.Name = "DeleteToolStripMenuItem2"
        DeleteToolStripMenuItem2.Size = New Size(108, 22)
        DeleteToolStripMenuItem2.Text = "&Delete"
        ' 
        ' SearchToolStripMenuItem
        ' 
        SearchToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {QuickToolStripMenuItem, AdvanceToolStripMenuItem})
        SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        SearchToolStripMenuItem.Size = New Size(54, 20)
        SearchToolStripMenuItem.Text = "&Search"
        ' 
        ' QuickToolStripMenuItem
        ' 
        QuickToolStripMenuItem.Name = "QuickToolStripMenuItem"
        QuickToolStripMenuItem.Size = New Size(158, 22)
        QuickToolStripMenuItem.Text = "&Quick Search"
        ' 
        ' AdvanceToolStripMenuItem
        ' 
        AdvanceToolStripMenuItem.Name = "AdvanceToolStripMenuItem"
        AdvanceToolStripMenuItem.Size = New Size(158, 22)
        AdvanceToolStripMenuItem.Text = "&Advance Search"
        ' 
        ' RentToolStripMenuItem
        ' 
        RentToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {RendVideoToolStripMenuItem, ListOfRentedVideoToolStripMenuItem})
        RentToolStripMenuItem.Name = "RentToolStripMenuItem"
        RentToolStripMenuItem.Size = New Size(43, 20)
        RentToolStripMenuItem.Text = "&Rent"
        ' 
        ' RendVideoToolStripMenuItem
        ' 
        RendVideoToolStripMenuItem.Name = "RendVideoToolStripMenuItem"
        RendVideoToolStripMenuItem.Size = New Size(187, 22)
        RendVideoToolStripMenuItem.Text = "Rend &Video"
        ' 
        ' ListOfRentedVideoToolStripMenuItem
        ' 
        ListOfRentedVideoToolStripMenuItem.Name = "ListOfRentedVideoToolStripMenuItem"
        ListOfRentedVideoToolStripMenuItem.Size = New Size(187, 22)
        ListOfRentedVideoToolStripMenuItem.Text = "&List of Rented Movies"
        ' 
        ' CommonMenuControl
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(MenuStrip1)
        Name = "CommonMenuControl"
        Size = New Size(1500, 150)
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ChangePasswordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmployeeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CreateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MovieToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents CreateToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ClientToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents CreateToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents SearchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuickToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdvanceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RendVideoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListOfRentedVideoToolStripMenuItem As ToolStripMenuItem
End Class
