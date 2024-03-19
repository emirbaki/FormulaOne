Public Class ApplicationView
    Private Sub ApplicationView_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        If DBBroker.GetBroker() IsNot Nothing Then
            Label1.Text = "Bağlandım."
        End If

        DBBroker.GetBroker().Read()

    End Sub
End Class
