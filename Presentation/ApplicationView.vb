Public Class ApplicationView
    Private Sub ApplicationView_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        If DBBroker.GetBroker() IsNot Nothing Then
            Label1.Text = "Bağlandım."
        End If

        Dim CountrySample As New Country With {
            .CountryID = "SPA",
            .CountryName = "Spain",
            .CountryPopulation = "55123124"
        }

        CountrySample.InsertCountry()

        CountrySample.ReadCountry()

        Label1.Text = CountrySample.CountryName


    End Sub
End Class
