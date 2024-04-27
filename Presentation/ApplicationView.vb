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

        For year As Integer = 1970 To 2024
            cbox_Season.Items.Add(year)
            cbox_contractSeason.Items.Add(year)
            cbox_teamDetailsSeason.Items.Add(year)

        Next


        'Initiliazing Driver Data from DB
        d.DriverDAO.ReadAll()
        driverList.DataSource = d.DriverDAO.Drivers
        driverList.Update()

        'Initiliazing Country Data from DB
        c.CountDAO.ReadAll()
        countryList.DataSource = c.CountDAO.Countries
        countryList.Update()

        t.TeamDAO.ReadAll()
        teamsList.DataSource = t.TeamDAO.Teams
        cbox_contractTeam.DataSource = t.TeamDAO.Teams
        teamsList.Update()

        'Initiliazing GP Data from DB
        gp.GpDAO.ReadAll()
        gpList.DataSource = gp.GpDAO.GPs
        gpList.Update()




        teamsList.DataSource = t.TeamDAO.Teams
        teamsList.Update()
        c.CountDAO.ReadAll()

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

    Private Sub btn_Add_Click(sender As Object, e As EventArgs) Handles btn_Add.Click
        Dim CountrySample As New Country With {
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

    Private Sub btn_AddTeam_Click(sender As Object, e As EventArgs) Handles btn_addTeam.Click
        Dim selectedCountry As Country = cbox_teamCountry.SelectedItem

        Dim TeamSample As New Team With {
            .TeamID = txt_teamID.Text,
            .TeamName = txt_teamName.Text,
            .TeamCountry = selectedCountry.CountryID.ToString,
            .TeamCreationDate = Date.Now.ToShortDateString
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

    ' Define variables
    Dim year As Integer
    Dim numTeams As Integer
    Dim numDriversPerTeam As Integer = 2
    Dim numGrandPrixs As Integer
    Dim _teamsList_list As List(Of Team)
    Dim grandPrixList As List(Of GPs)
    Dim randomizer As New Random()

    Private Sub ButtonGenerateSeason_Click(sender As Object, e As EventArgs) Handles btn_generateCalendar.Click
        ' Get year input (ensure it's within range)
        Dim parsedYear As Integer
        If Not Integer.TryParse(cbox_Season.SelectedItem.ToString(), parsedYear) Then
            MessageBox.Show("Invalid year selection!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        year = parsedYear

        If year < 1970 Or year > 2024 Then
            MessageBox.Show("Year must be between 1970 and 2024!", "Invalid Year", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' Check if user provided team and GP limits

        numTeams = CInt(nud_teamCount.Value)
        numGrandPrixs = CInt(nud_gpCount.Value)

        ' Validate team and GP count
        If numTeams < 5 Or numTeams > 10 Then
            MessageBox.Show("Number of teams must be between 5 and 10!", "Invalid Team Count", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If numGrandPrixs < 10 Or numGrandPrixs > 20 Then
            MessageBox.Show("Number of Grand Prixs must be between 10 and 20!", "Invalid GP Count", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' Generate teams and drivers
        _teamsList_list = GenerateTeams(numTeams)

        ' Generate Grand Prix calendar
        grandPrixList = GenerateGrandPrixCalendar(numGrandPrixs)

        ' Display information (replace with your actual data display logic)
        teamsList_RacesPage.Items.Clear()
        For Each team In _teamsList_list
            teamsList_RacesPage.Items.Add(team.TeamName)
        Next

        gp_listview.Items.Clear()
        For Each gp In grandPrixList
            gp_listview.Items.Add(gp.GPName)
        Next
    End Sub

    ' Function to generate random team count (5-10)
    Private Function GetRandomTeamCount() As Integer
        Return randomizer.Next(5, 11)
    End Function

    ' Function to generate random Grand Prix count (10-20)
    Private Function GetRandomGrandPrixCount() As Integer
        Return randomizer.Next(10, 21)
    End Function

    '' Function to generate teams with random drivers (from database)
    '' (Replace this with your logic to retrieve drivers from database)
    Private Function GenerateTeams(numTeams As Integer) As List(Of Team)
        Dim teams As New List(Of Team)
        For i As Integer = 1 To numTeams
            Dim team As New Team()
            team.TeamName = "Team " & i.ToString()
            'team.Drivers = GetRandomDrivers(numDriversPerTeam)
            teams.Add(team)
        Next
        Return teams
    End Function

    ' Function to generate random driver names (replace with database access)
    ' (Simulate this part for now)
    Private Function GetRandomDrivers(numDrivers As Integer) As List(Of String)
        Dim drivers As New List(Of String)
        For i As Integer = 1 To numDrivers
            drivers.Add("Driver " & i.ToString())
        Next
        Return drivers
    End Function

    ' Function to generate Grand Prix calendar with random names
    Private Function GenerateGrandPrixCalendar(numGrandPrixs As Integer) As List(Of GPs)
        Dim calendar As New List(Of GPs)
        For i As Integer = 1 To numGrandPrixs
            calendar.Add(New GPs With
                {
                .GPName = "Grand Prix " & i.ToString()}
                         )
        Next
        Return calendar
    End Function

    Private Sub teamsList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles teamsList.SelectedIndexChanged

        'TeamDetailsListView.Clear()
        Dim selectedTeam = CType(teamsList.SelectedItem, Team)

        Dim contracts As New Contracts With
            {
                .Team = selectedTeam.TeamID,
                .Season = CType(cbox_teamDetailsSeason.SelectedItem, UShort)
            }
        contracts.ReadContract()


        Dim driver1 As New Drivers With
            {.DriverID = contracts.Driver1}
        Dim driver2 As New Drivers With
            {.DriverID = contracts.Driver2}

        driver2.ReadDriver()
        driver1.ReadDriver()



        TeamDetailsListView.Items.Add(New ListViewItem({driver1.DriverName + driver1.DriverSurname, contracts.Season}))
        TeamDetailsListView.Items.Add(New ListViewItem({driver2.DriverName + driver2.DriverSurname, contracts.Season}))



    End Sub

    Private Sub btn_AddSelectedDriverContract_Click(sender As Object, e As EventArgs) Handles btn_AddSelectedDriverContract.Click
        If selectedDriversListBox.Items.Count = 2 Then
            MessageBox.Show("You can only assign two driver for each team for each season!", "Invalid Selected Driver Count", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        selectedDriversListBox.Items.Add(driverList.SelectedItem)

    End Sub

    Private Sub btn_RemoveSelectedDriverContract_Click(sender As Object, e As EventArgs) Handles btn_RemoveSelectedDriverContract.Click
        selectedDriversListBox.Items.Remove(driverList.SelectedItem)
    End Sub

    Private Sub btn_Contract_Click(sender As Object, e As EventArgs) Handles btn_Contract.Click

        Dim selectedTeam = CType(cbox_contractTeam.SelectedItem, Team)
        Dim driver1 = CType(selectedDriversListBox.Items(0), Drivers)
        Dim driver2 = CType(selectedDriversListBox.Items(1), Drivers)
        Dim newContract As New Contracts With {
            .Season = CType(cbox_contractSeason.SelectedItem, UShort),
            .Team = selectedTeam.TeamID,
            .Driver1 = driver1.DriverID,
            .Driver2 = driver2.DriverID
        }

        newContract.ContractDAO.Insert(newContract)
    End Sub

End Class
