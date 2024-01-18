Public Class ListEmployees



    Private Sub ListEmployees_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Adding an instance of the Menu
        Me.Controls.Add(New CommonMenuControl())

        'Colors
        Me.BackColor = Globals.BackgroundCustomColor


        'Display username and access level
        Label_Display_Username.Text = Globals.Username
        Label_Display_Access_Level.Text = Globals.AccessLevel

        ' Set AutoGenerateColumns to True to automatically create columns
        DataGridView_List_Employees.AutoGenerateColumns = True
        DataGridView_List_Employees.ForeColor = Color.Black

        LoadEmployeeData()
    End Sub

    Private Sub LoadEmployeeData()
        Dim dbManager As New DbManagerEmployee()
        Dim employeeData As DataTable = dbManager.GetAllEmployeesWithoutPassword()
        DataGridView_List_Employees.DataSource = employeeData

        ' Check if there are columns to modify
        If DataGridView_List_Employees.Columns.Count > 0 Then
            ' Set the width of the first column
            DataGridView_List_Employees.Columns(0).Width = 150
        End If
    End Sub

    'Display the user info in a Message box
    Private Sub DataGridView_List_Employees_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView_List_Employees.CellClick
        ' Check if the click is on a row, not the column header
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = DataGridView_List_Employees.Rows(e.RowIndex)

            ' StringBuilder to create the message string
            Dim userDetails As New System.Text.StringBuilder()

            ' Loop through each cell in the row
            For Each cell As DataGridViewCell In selectedRow.Cells
                ' Append the column name and value to the string
                userDetails.AppendLine(selectedRow.DataGridView.Columns(cell.ColumnIndex).Name & ": " & cell.Value.ToString())
            Next

            ' Display the user details
            MsgBox(userDetails.ToString(), MsgBoxStyle.Information, "Employee Details")
        End If
    End Sub

    Private Sub Button_Dashboard_Click(sender As Object, e As EventArgs) Handles Button_Dashboard.Click
        ShowSelectedForm(Me, New Dashboard)
    End Sub
End Class