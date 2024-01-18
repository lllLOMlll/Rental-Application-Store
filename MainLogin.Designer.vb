<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainLogin
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
        Label_Password = New Label()
        TextBox_Username = New TextBox()
        TextBox_Password = New TextBox()
        Button_Login = New Button()
        SuspendLayout()
        ' 
        ' Label_Title
        ' 
        Label_Title.AutoSize = True
        Label_Title.Font = New Font("Tw Cen MT Condensed Extra Bold", 48F, FontStyle.Regular, GraphicsUnit.Point)
        Label_Title.ForeColor = Color.FromArgb(CByte(244), CByte(198), CByte(36))
        Label_Title.Location = New Point(119, 35)
        Label_Title.Margin = New Padding(5, 0, 5, 0)
        Label_Title.Name = "Label_Title"
        Label_Title.Size = New Size(538, 74)
        Label_Title.TabIndex = 0
        Label_Title.Text = "MAJOR VIDEO STORE"
        ' 
        ' Label_Username
        ' 
        Label_Username.AutoSize = True
        Label_Username.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label_Username.ForeColor = Color.FromArgb(CByte(244), CByte(198), CByte(36))
        Label_Username.Location = New Point(200, 162)
        Label_Username.Margin = New Padding(5, 0, 5, 0)
        Label_Username.Name = "Label_Username"
        Label_Username.Size = New Size(98, 25)
        Label_Username.TabIndex = 1
        Label_Username.Text = "Username"
        ' 
        ' Label_Password
        ' 
        Label_Password.AutoSize = True
        Label_Password.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label_Password.ForeColor = Color.FromArgb(CByte(244), CByte(198), CByte(36))
        Label_Password.Location = New Point(200, 268)
        Label_Password.Margin = New Padding(5, 0, 5, 0)
        Label_Password.Name = "Label_Password"
        Label_Password.Size = New Size(91, 25)
        Label_Password.TabIndex = 2
        Label_Password.Text = "Password"
        ' 
        ' TextBox_Username
        ' 
        TextBox_Username.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox_Username.Location = New Point(200, 193)
        TextBox_Username.Margin = New Padding(5, 6, 5, 6)
        TextBox_Username.Name = "TextBox_Username"
        TextBox_Username.Size = New Size(354, 29)
        TextBox_Username.TabIndex = 3
        ' 
        ' TextBox_Password
        ' 
        TextBox_Password.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox_Password.Location = New Point(200, 299)
        TextBox_Password.Margin = New Padding(5, 6, 5, 6)
        TextBox_Password.Name = "TextBox_Password"
        TextBox_Password.PasswordChar = "*"c
        TextBox_Password.Size = New Size(354, 29)
        TextBox_Password.TabIndex = 4
        ' 
        ' Button_Login
        ' 
        Button_Login.BackColor = Color.White
        Button_Login.FlatAppearance.BorderColor = Color.Black
        Button_Login.FlatAppearance.BorderSize = 3
        Button_Login.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(244), CByte(198), CByte(36))
        Button_Login.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(244), CByte(198), CByte(36))
        Button_Login.FlatStyle = FlatStyle.Flat
        Button_Login.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Button_Login.ForeColor = Color.Black
        Button_Login.Location = New Point(200, 380)
        Button_Login.Margin = New Padding(5, 6, 5, 6)
        Button_Login.Name = "Button_Login"
        Button_Login.Size = New Size(354, 67)
        Button_Login.TabIndex = 5
        Button_Login.Text = "Login"
        Button_Login.UseVisualStyleBackColor = False
        ' 
        ' MainLogin
        ' 
        AutoScaleDimensions = New SizeF(12F, 30F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(51), CByte(88), CByte(236))
        ClientSize = New Size(804, 501)
        Controls.Add(Button_Login)
        Controls.Add(TextBox_Password)
        Controls.Add(TextBox_Username)
        Controls.Add(Label_Password)
        Controls.Add(Label_Username)
        Controls.Add(Label_Title)
        Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        Margin = New Padding(5, 6, 5, 6)
        Name = "MainLogin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "MainLogin"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label_Title As Label
    Friend WithEvents Label_Username As Label
    Friend WithEvents Label_Password As Label
    Friend WithEvents TextBox_Username As TextBox
    Friend WithEvents TextBox_Password As TextBox
    Friend WithEvents Button_Login As Button
End Class
