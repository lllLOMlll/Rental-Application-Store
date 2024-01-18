<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChangePassword
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
        Label_Old_Password = New Label()
        TextBox_Old_Password = New TextBox()
        Label_New_Password = New Label()
        TextBox_New_Password = New TextBox()
        Label_Confirm_Password = New Label()
        TextBox_Confirm_Password = New TextBox()
        Button_Change_Password = New Button()
        Label_Username = New Label()
        Label_Welcom = New Label()
        SuspendLayout()
        ' 
        ' Label_Title
        ' 
        Label_Title.AutoSize = True
        Label_Title.Font = New Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point)
        Label_Title.ForeColor = Color.FromArgb(CByte(245), CByte(200), CByte(35))
        Label_Title.Location = New Point(28, 33)
        Label_Title.Name = "Label_Title"
        Label_Title.Size = New Size(423, 65)
        Label_Title.TabIndex = 0
        Label_Title.Text = "Change Password"
        ' 
        ' Label_Old_Password
        ' 
        Label_Old_Password.AutoSize = True
        Label_Old_Password.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label_Old_Password.ForeColor = Color.White
        Label_Old_Password.Location = New Point(46, 131)
        Label_Old_Password.Name = "Label_Old_Password"
        Label_Old_Password.Size = New Size(143, 30)
        Label_Old_Password.TabIndex = 1
        Label_Old_Password.Text = "Old Password"
        ' 
        ' TextBox_Old_Password
        ' 
        TextBox_Old_Password.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox_Old_Password.Location = New Point(46, 164)
        TextBox_Old_Password.Name = "TextBox_Old_Password"
        TextBox_Old_Password.PasswordChar = "*"c
        TextBox_Old_Password.Size = New Size(278, 33)
        TextBox_Old_Password.TabIndex = 2
        ' 
        ' Label_New_Password
        ' 
        Label_New_Password.AutoSize = True
        Label_New_Password.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label_New_Password.ForeColor = Color.White
        Label_New_Password.Location = New Point(46, 209)
        Label_New_Password.Name = "Label_New_Password"
        Label_New_Password.Size = New Size(152, 30)
        Label_New_Password.TabIndex = 3
        Label_New_Password.Text = "New Password"
        ' 
        ' TextBox_New_Password
        ' 
        TextBox_New_Password.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox_New_Password.Location = New Point(46, 242)
        TextBox_New_Password.Name = "TextBox_New_Password"
        TextBox_New_Password.PasswordChar = "*"c
        TextBox_New_Password.Size = New Size(278, 33)
        TextBox_New_Password.TabIndex = 4
        ' 
        ' Label_Confirm_Password
        ' 
        Label_Confirm_Password.AutoSize = True
        Label_Confirm_Password.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label_Confirm_Password.ForeColor = Color.White
        Label_Confirm_Password.Location = New Point(46, 291)
        Label_Confirm_Password.Name = "Label_Confirm_Password"
        Label_Confirm_Password.Size = New Size(186, 30)
        Label_Confirm_Password.TabIndex = 5
        Label_Confirm_Password.Text = "Confirm Password"
        ' 
        ' TextBox_Confirm_Password
        ' 
        TextBox_Confirm_Password.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox_Confirm_Password.Location = New Point(46, 324)
        TextBox_Confirm_Password.Name = "TextBox_Confirm_Password"
        TextBox_Confirm_Password.PasswordChar = "*"c
        TextBox_Confirm_Password.Size = New Size(278, 33)
        TextBox_Confirm_Password.TabIndex = 6
        ' 
        ' Button_Change_Password
        ' 
        Button_Change_Password.BackColor = Color.White
        Button_Change_Password.FlatAppearance.BorderSize = 4
        Button_Change_Password.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(245), CByte(200), CByte(35))
        Button_Change_Password.FlatStyle = FlatStyle.Flat
        Button_Change_Password.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Button_Change_Password.Location = New Point(46, 397)
        Button_Change_Password.Name = "Button_Change_Password"
        Button_Change_Password.Size = New Size(278, 51)
        Button_Change_Password.TabIndex = 8
        Button_Change_Password.Text = "Change Password"
        Button_Change_Password.UseVisualStyleBackColor = False
        ' 
        ' Label_Username
        ' 
        Label_Username.AutoSize = True
        Label_Username.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label_Username.ForeColor = Color.FromArgb(CByte(245), CByte(200), CByte(35))
        Label_Username.Location = New Point(514, 135)
        Label_Username.Name = "Label_Username"
        Label_Username.Size = New Size(101, 25)
        Label_Username.TabIndex = 9
        Label_Username.Text = "Username"
        ' 
        ' Label_Welcom
        ' 
        Label_Welcom.AutoSize = True
        Label_Welcom.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label_Welcom.ForeColor = Color.White
        Label_Welcom.Location = New Point(407, 131)
        Label_Welcom.Name = "Label_Welcom"
        Label_Welcom.Size = New Size(112, 30)
        Label_Welcom.TabIndex = 10
        Label_Welcom.Text = "Welcome :"
        ' 
        ' ChangePassword
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(50), CByte(90), CByte(235))
        ClientSize = New Size(804, 501)
        Controls.Add(Label_Welcom)
        Controls.Add(Label_Username)
        Controls.Add(Button_Change_Password)
        Controls.Add(TextBox_Confirm_Password)
        Controls.Add(Label_Confirm_Password)
        Controls.Add(TextBox_New_Password)
        Controls.Add(Label_New_Password)
        Controls.Add(TextBox_Old_Password)
        Controls.Add(Label_Old_Password)
        Controls.Add(Label_Title)
        Name = "ChangePassword"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ChangePassword"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label_Title As Label
    Friend WithEvents Label_Old_Password As Label
    Friend WithEvents TextBox_Old_Password As TextBox
    Friend WithEvents Label_New_Password As Label
    Friend WithEvents TextBox_New_Password As TextBox
    Friend WithEvents Label_Confirm_Password As Label
    Friend WithEvents TextBox_Confirm_Password As TextBox
    Friend WithEvents Button_Change_Password As Button
    Friend WithEvents Label_Username As Label
    Friend WithEvents Label_Welcom As Label
End Class
