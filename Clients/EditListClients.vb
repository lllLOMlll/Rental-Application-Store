Public Class EditListClients

    Private Sub EditListClients_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Adding an instance of the Menu
        Me.Controls.Add(New CommonMenuControl())

        'Display username and access level
        Label_Display_Username.Text = Globals.Username
        Label_Display_Access_Level.Text = Globals.AccessLevel

        ' Set AutoGenerateColumns to True to automatically create columns
        DataGridView_Clients_List.AutoGenerateColumns = True


        ' Load the Client Data
        LoadClientData()
    End Sub

    Private Sub LoadClientData()
        Dim dbManager As New DBManagerClient()
        Dim clientData As DataTable = dbManager.GetAllClients()
        DataGridView_Clients_List.DataSource = clientData

        'Format the DataGridView
        DataGridView_Clients_List.ForeColor = Color.Black
        DataGridView_Clients_List.Columns("client_id").Width = 60
        DataGridView_Clients_List.Columns("client_number").Width = 90
        DataGridView_Clients_List.Columns("email").Width = 250
        DataGridView_Clients_List.Columns("dob").Width = 70
        DataGridView_Clients_List.Columns("address").Width = 165
        DataGridView_Clients_List.Columns("province").Width = 60
        DataGridView_Clients_List.Columns("postal_code").Width = 80
        DataGridView_Clients_List.Columns("status").Width = 40
    End Sub

    ' Display the client info in a MsgBox when clicked on a line
    Private Sub DataGridView_Clients_List_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView_Clients_List.CellContentClick
        ' Check if the click is on a row, not the column header
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = DataGridView_Clients_List.Rows(e.RowIndex)

            ' StringBuilder to create the message string
            Dim clientDetails As New System.Text.StringBuilder()

            ' Loop through each cell in the row
            For Each cell As DataGridViewCell In selectedRow.Cells
                ' Append the column name and value to the string
                clientDetails.AppendLine(selectedRow.DataGridView.Columns(cell.ColumnIndex).Name & ": " & cell.Value.ToString())
            Next

            ' Display the user details and ask if the user wants to update
            Dim result As DialogResult = MessageBox.Show(clientDetails.ToString() & vbCrLf & "Do you want to update this user?", "Employee Details", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                ' User chose to update the user             
                Globals.ClientNumber = selectedRow.Cells("client_number").Value.ToString()
                ShowSelectedForm(Me, New EditClient)
            End If
        End If
    End Sub

    Private Sub Button_Dashboard_Click(sender As Object, e As EventArgs) Handles Button_Dashboard.Click
        ShowSelectedForm(Me, New Dashboard)
    End Sub
End Class
