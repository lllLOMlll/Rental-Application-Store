<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        Label_Welcome = New Label()
        Label_Username = New Label()
        SuspendLayout()
        ' 
        ' Label_Welcome
        ' 
        Label_Welcome.AutoSize = True
        Label_Welcome.Font = New Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point)
        Label_Welcome.ForeColor = Color.FromArgb(CByte(245), CByte(200), CByte(35))
        Label_Welcome.Location = New Point(62, 94)
        Label_Welcome.Name = "Label_Welcome"
        Label_Welcome.Size = New Size(332, 86)
        Label_Welcome.TabIndex = 0
        Label_Welcome.Text = "Welcome :"
        ' 
        ' Label_Username
        ' 
        Label_Username.AutoSize = True
        Label_Username.Font = New Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point)
        Label_Username.ForeColor = Color.FromArgb(CByte(245), CByte(200), CByte(35))
        Label_Username.Location = New Point(389, 94)
        Label_Username.Name = "Label_Username"
        Label_Username.Size = New Size(338, 86)
        Label_Username.TabIndex = 1
        Label_Username.Text = "Username"
        ' 
        ' Dashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1484, 761)
        Controls.Add(Label_Username)
        Controls.Add(Label_Welcome)
        Name = "Dashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Dashbord"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label_Welcome As Label
    Friend WithEvents Label_Username As Label
End Class
