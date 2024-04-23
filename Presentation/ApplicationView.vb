Imports Google.Protobuf.Compiler

Public Class ApplicationView
    Private c As Country
    Private t As Team
    Private Sub ApplicationView_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        If DBBroker.GetBroker IsNot Nothing Then
            'Label1.Text = "Bağlandım."
        End If

        c = New Country
        t = New Team

        c.CountDAO.ReadAll()

        countryList.DataSource = c.CountDAO.Countries
        countryList.Update()
        c.CountDAO.ReadAll()


        Dim count = c.CountDAO.Countries.Count

        teamsList.DataSource = t.TeamDAO.Teams
        teamsList.Update()

        cbox_teamCountry.DataSource = c.CountDAO.Countries
        cbox_teamCountry.DisplayMember = "CountryID"
        cbox_teamCountry.ValueMember = "CountryID"

        cbox_teamCountry.Update()



    End Sub

    Private Sub LstPersons_SelectedIndexChanged(sender As Object, e As EventArgs) Handles countryList.SelectedIndexChanged
        btn_Delete.Enabled = True
        btn_Update.Enabled = True

        c = CType(countryList.SelectedItem, Country)

        If (c IsNot Nothing) Then
            txt_countryID.Text = c.CountryID
            txt_countryName.Text = c.CountryName
            txt_countryPop.Text = c.CountryPopulation
        End If

        'txt_countryID.Enabled = False
        txt_countryName.Enabled = True



    End Sub

    Private Sub btn_Add_Click(sender As Object, e As EventArgs)
        Dim CountrySample As New Country With {
            .CountryID = txt_countryID.Text,
            .CountryName = txt_countryName.Text,
            .CountryPopulation = txt_countryPop.Text
        }
        CountrySample.InsertCountry()

        CountrySample.CountDAO.ReadAll()

        countryList.DataSource = CountrySample.CountDAO.Countries
        countryList.Update()
    End Sub

    Private Sub btn_Delete_Click(sender As Object, e As EventArgs) Handles btn_Delete.Click
        c = CType(countryList.SelectedItem, Country)
        If (c Is Nothing) Then
            MessageBox.Show("You can't delete a person while you haven't chose a person in the list, yet", "Errorrrrrrrr")
            Return
        End If

        c.DeleteCountry()

        c.CountDAO.ReadAll()

        countryList.DataSource = c.CountDAO.Countries

        countryList.Update()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbox_teamCountry.SelectedIndexChanged

        cbox_teamCountry.SelectedItem = c
        cbox_teamCountry.DataSource = c.CountDAO.Countries
        cbox_teamCountry.Update()
    End Sub

    Private Sub btn_AddTeam_Click(sender As Object, e As EventArgs) Handles btn_addTeam.Click, btn_Add.Click
        Dim selectedCountry As Country = cbox_teamCountry.SelectedItem

        Dim TeamSample As New Team With {
            .TeamID = txt_teamID.Text,
            .TeamName = txt_teamName.Text,
            .TeamCountry = selectedCountry.CountryID.ToString,
            .TeamCreationDate = DateTime.Now.ToString("yyyy.MM.dd")
        }
        TeamSample.InsertCountry()

        TeamSample.TeamDAO.ReadAll()

        teamsList.DataSource = TeamSample.TeamDAO.Teams
        teamsList.Update()
    End Sub
End Class
