Public Class ApplicationView
    Private Sub ApplicationView_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        If DBBroker.GetBroker IsNot Nothing Then
            'Label1.Text = "Bağlandım."
        End If

        Dim CountrySample As New Country With {
            .CountryID = "TUR",
            .CountryName = "Türkiye",
            .CountryPopulation = "85123124"
        }
        CountrySample.InsertCountry()

        CountrySample.CountDAO.ReadAll()

        countryList.DataSource = CountrySample.CountDAO.Countries
        countryList.Update()
        'CountrySample.DeleteCountry()

        'CountrySample.ReadCountry()


    End Sub
End Class
