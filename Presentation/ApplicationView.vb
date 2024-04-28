Imports System.Globalization
Imports Google.Protobuf.Compiler
Imports System.Linq

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
        If txt_countryID.Text.Length <> 3 And txt_countryID.Text <> Nothing And txt_countryID.Text <> "" Then
            MessageBox.Show("Identifier must be composed of 3 letters.", "Invalid Identifier", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim identifier As String = txt_countryID.Text.ToUpper()

        Dim countryDAO As New CountryDAO()
        If countryDAO.CheckID(identifier) Then
            MessageBox.Show("Identifier is already in use.", "Duplicate Identifier", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If txt_countryID.Text <> Nothing Or txt_countryID.Text <> "" Then
            Dim CountrySample As New Country With {
            .CountryID = identifier,
            .CountryName = txt_countryName.Text,
            .CountryPopulation = txt_countryPop.Text
              }

            CountrySample.InsertCountry()

            CountrySample.CountDAO.ReadAll()

            countryList.DataSource = CountrySample.CountDAO.Countries
            countryList.Update()
        Else
            Dim CountrySample As New Country With {
            .CountryName = txt_countryName.Text,
            .CountryPopulation = txt_countryPop.Text
              }

            CountrySample.InsertCountry()

            CountrySample.CountDAO.ReadAll()

            countryList.DataSource = CountrySample.CountDAO.Countries
            countryList.Update()
        End If
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
        TeamSample.InsertTeam()

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
    Dim _driverList_List As New List(Of Drivers)

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
        Dim report As New DriverStandingsReport

        For i As Integer = 1 To grandPrixList.Count
            Dim calendars As New Calendars With {
                .Season = year,
                .GP = grandPrixList(i).GPID,
                .Order = i
            }
            calendars.InsertCalendar()
            report.GenerateRandomRacePositions(_driverList_List, year, grandPrixList(i).GPID)

        Next
        ' Display information (replace with your actual data display logic)
        teamsList_RacesPage.Items.Clear()
        For Each team In _teamsList_list
            teamsList_RacesPage.Items.Add(team.TeamName)
        Next

        gp_listview.Items.Clear()

        For Each gp In grandPrixList
            gp_listview.Items.Add(gp.GPName)
        Next





        RacesDriverList.Items.Clear()


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
        t.TeamDAO.ReadAll()

        ' Ensure requested number doesn't exceed available GPs
        If numTeams > t.TeamDAO.Teams.Count Then
            Throw New ArgumentOutOfRangeException(NameOf(numTeams), numTeams, "Requested number of Grand Prix entries exceeds available data.")
        End If

        ' Check if any GPs are available
        If numTeams = 0 Then
            ' Handle no available GPs (optional: return empty list or log message)
            Console.WriteLine("No Grand Prix data available to generate calendar.")
            Return teams
        End If

        Dim tempCol = t.TeamDAO.Teams
        ' Select unique GPs for the calendar
        For i As Integer = 0 To numTeams - 1
            ' Get the index of the GP to select
            Dim selectedItem = RandomlyPickAndRemove(tempCol)

            ' Add the selected GP to the calendar
            teams.Add(selectedItem)
        Next

        For i As Integer = 0 To teams.Count - 1

            Dim contract As New Contracts With {
                .Team = teams(i).TeamID,
                .Season = year
            }

            contract.ReadContract()
            Dim Driver1 As New Drivers With {
              .DriverID = contract.Driver1
            }
            Dim Driver2 As New Drivers With {
              .DriverID = contract.Driver2
            }

            Driver1.ReadDriver()
            Driver2.ReadDriver()
            _driverList_List.Add(Driver1)
            _driverList_List.Add(Driver2)

            RacesDriverList.Items.Add(Driver1.ToString)
            RacesDriverList.Items.Add(Driver2.ToString)
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
        gp.GpDAO.ReadAll()

        ' Ensure requested number doesn't exceed available GPs
        If numGrandPrixs > gp.GpDAO.GPs.Count Then
            Throw New ArgumentOutOfRangeException(NameOf(numGrandPrixs), numGrandPrixs, "Requested number of Grand Prix entries exceeds available data.")
        End If

        ' Check if any GPs are available
        If numGrandPrixs = 0 Then
            ' Handle no available GPs (optional: return empty list or log message)
            Console.WriteLine("No Grand Prix data available to generate calendar.")
            Return calendar
        End If

        Dim tempCol = gp.GpDAO.GPs

        ' Select unique GPs for the calendar
        For i As Integer = 0 To numGrandPrixs - 1
            ' Get the index of the GP to select
            Dim selectedItem = RandomlyPickAndRemove(tempCol)

            ' Add the selected GP to the calendar
            calendar.Add(selectedItem)
        Next



        Return calendar

    End Function
    Private Function RandomlyPickAndRemove(ByRef list As Collection) As Object
        Dim random = New Random()

        ' Check if the collection is empty
        If list.Count = 0 Then
            Throw New InvalidOperationException("The collection is empty.")
        End If

        ' Generate a random index between 1 and list.Count
        Dim randomIndex = random.Next(1, list.Count)

        ' Retrieve the item at the random index
        Dim selectedItem = list(randomIndex)

        ' Remove the item from the collection
        list.Remove(randomIndex)

        Return selectedItem
    End Function
    Private Function Shuffle(Of T)(list As List(Of T), random As Random) As List(Of T)
        Dim n As Integer = list.Count
        While n > 1
            n -= 1
            Dim k As Integer = random.Next(n + 1)
            Dim value As T = list(k)
            list(k) = list(n)
            list(n) = value
        End While
        Return list
    End Function


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
    Dim TeamDetailCount = 0

    Private Sub btn_GetDetails_Click(sender As Object, e As EventArgs) Handles btn_GetDetails.Click
        TeamDetailsListView.Items.Clear()
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
        Console.WriteLine(driver1)
        Dim lvItem1 As ListViewItem
        Dim lvItem2 As ListViewItem
        TeamDetailsListView.BeginUpdate()
        lvItem1 = TeamDetailsListView.Items.Add(TeamDetailCount + 1)
        lvItem1.SubItems.Add(driver1.DriverName + driver1.DriverSurname)
        lvItem1.SubItems.Add(contracts.Season)
        lvItem2 = TeamDetailsListView.Items.Add(TeamDetailCount + 2)
        lvItem2.SubItems.Add(driver2.DriverName + driver2.DriverSurname)
        lvItem2.SubItems.Add(contracts.Season)
        'TeamDetailsListView.Items.Add(New ListViewItem({driver1.DriverName + driver1.DriverSurname, contracts.Season}))
        'TeamDetailsListView.Items.Add(New ListViewItem({driver2.DriverName + driver2.DriverSurname, contracts.Season}))
        TeamDetailsListView.Update()
        TeamDetailsListView.EndUpdate()
    End Sub

    Private Sub btn_GenerateReport_Click(sender As Object, e As EventArgs) Handles btn_GenerateReport.Click

        Dim report As New DriverStandingsReport

        resultText.Text = report.GenerateReport(2004, 3, 2)
    End Sub
End Class
