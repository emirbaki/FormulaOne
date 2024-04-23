Imports System.Globalization
Imports Google.Protobuf.Compiler

Public Class ApplicationView
    Private c As Country
    Private t As Team
    Private gp As GPs
    Private d As Drivers
    Private Sub ApplicationView_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        If DBBroker.GetBroker IsNot Nothing Then
            'Label1.Text = "Bağlandım."
        End If

        c = New Country
        t = New Team
        gp = New GPs
        d = New Drivers

        'Initiliazing Driver Data from DB
        d.DriverDAO.ReadAll()
        driverList.DataSource = d.DriverDAO.Drivers
        driverList.Update()

        'Initiliazing Country Data from DB
        c.CountDAO.ReadAll()
        countryList.DataSource = c.CountDAO.Countries
        countryList.Update()

        'Initiliazing GP Data from DB
        gp.GpDAO.ReadAll()
        gpList.DataSource = gp.GpDAO.GPs
        gpList.Update()




        teamsList.DataSource = t.TeamDAO.Teams
        teamsList.Update()

        cbox_teamCountry.DataSource = c.CountDAO.Countries
        cbox_teamCountry.DisplayMember = "CountryID"
        cbox_teamCountry.ValueMember = "CountryID"

        cbox_teamCountry.Update()


        cbox_GP.DataSource = c.CountDAO.Countries
        cbox_GP.DisplayMember = "CountryID"
        cbox_GP.ValueMember = "CountryID"

        cbox_GP.Update()


        cbox_driverCountry.DataSource = c.CountDAO.Countries
        cbox_driverCountry.DisplayMember = "CountryID"
        cbox_driverCountry.ValueMember = "CountryID"

        cbox_driverCountry.Update()

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
        Dim dateString As DateTime = DateTime.Now
        Dim originalDate As DateTime = DateTime.Now
        DateTime.TryParseExact(dateString, "dd.MM.yyyy", Nothing, DateTimeStyles.None, originalDate)
        Dim TeamSample As New Team With {
            .TeamID = txt_teamID.Text,
            .TeamName = txt_teamName.Text,
            .TeamCountry = selectedCountry.CountryID.ToString,
            .TeamCreationDate = originalDate.ToString("yyyy-MM-dd")
        }
        TeamSample.InsertCountry()

        TeamSample.TeamDAO.ReadAll()

        teamsList.DataSource = TeamSample.TeamDAO.Teams
        teamsList.Update()
    End Sub

    Private Sub btn_AddGP_Click(sender As Object, e As EventArgs) Handles btn_AddGP.Click

        Dim selectedCountry As Country = cbox_GP.SelectedItem

        Dim GPSample As New GPs With {
            .GPID = txt_gpID.Text,
            .GPName = txt_gpName.Text,
            .GPCountry = selectedCountry.CountryID.ToString
        }

        GPSample.InsertGP()

        GPSample.GpDAO.ReadAll()
        gpList.DataSource = GPSample.GpDAO.GPs
        gpList.Update()


    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btn_AddDriver.Click
        Dim selectedCountry As Country = cbox_driverCountry.SelectedItem

        Dim DriverSample As New Drivers With {
            .DriverID = txt_driverID.Text,
            .DriverName = txt_driverName.Text,
            .DriverSurname = txt_driverSurname.Text,
            .DriverCountry = selectedCountry.CountryID.ToString
        }

        DriverSample.InsertDriver()

        DriverSample.DriverDAO.ReadAll()
        driverList.DataSource = DriverSample.DriverDAO.Drivers
        driverList.Update()
    End Sub
End Class
