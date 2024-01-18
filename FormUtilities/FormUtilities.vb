Public Module FormUtilities
    Public Sub ShowSelectedForm(fromForm As Form, toForm As Form)
        If fromForm IsNot Nothing Then
            Globals.parentFormGlobal = fromForm
            fromForm.Hide()
        End If

        ' Show the specified form.
        toForm.Show()
    End Sub

End Module
