

Public Class DriverStandingsReport

    Public Function GenerateReport(ByVal year As Integer, ByVal number_gp As SByte, ByVal number_team As SByte) As String

        Dim results = GetRaceResults(year, number_gp, number_team) ' Replace with your data access logic
        Dim standings = GetDriverStandings(results) ' Calculate standings with points and tiebreakers

        Dim reportText As String = String.Empty
        reportText &= "Final Driver Standings - Season " & year & vbCrLf
        reportText &= "------------------------------------" & vbCrLf
        reportText &= "Rank" & vbTab & "Driver Name" & vbTab & "Team Name" & vbTab & "Points" & vbCrLf
        For Each driver In standings
            reportText &= driver.Rank & vbTab & driver.DriverName & vbTab & driver.TeamName & vbTab & driver.Points & vbCrLf
        Next

        Dim constructorsStandings = GetConstructorStandings(standings) ' Calculate constructor standings

        reportText &= vbCrLf & vbCrLf
        'reportText &= "World Constructors' Champion: " & constructorsStandings.TeamName & vbCrLf
        Dim race As New Races
        race.RaceDAO.ReadAll()
        Dim racess As New List(Of Races)
        For Each _race As Races In race.RaceDAO.Races
            racess.Add(_race)
        Next
        Dim seasonRanking = CalculateDriverRanking(racess, 2024)

        Dim rCount = 1
        ' Output the ranking
        For Each entry In seasonRanking
            reportText &= $"Rank: {rCount} { vbTab } Driver ID: {entry.Key}, { vbTab } Points: {entry.Value}" & vbCrLf
            rCount += 1
        Next
        ' /final
        Return reportText
    End Function

    ' Helper functions for data retrieval and processing (replace with your actual implementation)
    Public Function GetRaceResults(ByVal year As UShort, ByVal number_gp As SByte, ByVal number_team As SByte) As List(Of RaceResult)

        Dim race As New Races
        Dim raceres As New RaceResult
        Dim gp As New GPs
        Dim calendar As New Calendars
        Dim driver As New Drivers
        Dim team As New Team
        Dim contract As New Contracts


        Dim i As SByte = 1
        Dim j As SByte = 1

        Dim raceresult As New List(Of RaceResult)()

        While i <= number_gp
            calendar.Season = year
            calendar.Order = i
            calendar.ReadCalendarGP()
            gp.GPID = calendar.GP

            j = 1

            While j <= (number_team * 2)
                race.GP = 1
                race.Position = 1
                race.Season = year
                If (race.RaceDAO.CheckPosition(race) > 0) Then
                    race.ReadRaceDrivers()
                    race = race.RaceDAO.Races(1)
                    raceres.Season = race.Season
                    raceres.GPName = gp.GPName
                    driver.DriverID = race.Driver
                    driver.ReadDriver()
                    raceres.DriverName = driver.DriverName
                    raceres.DriverSurname = driver.DriverSurname
                    raceres.DriverID = driver.DriverID
                    raceres.Points = race.Point
                    raceres.Position = race.Position

                    contract.Season = raceres.Season
                    contract.Driver1 = raceres.DriverID
                    contract.ContractDAO.ReadByDrivers(contract)
                    team.TeamID = contract.Team
                    team.TeamDAO.Read(team)

                    raceres.TeamName = team.TeamName


                    raceresult.Add(raceres)
                End If

                j += 1
            End While

            i += 1
        End While
        race.RaceDAO.ReadAll()


        Return raceresult
    End Function

    Private Function GetDriverStandings(ByVal results As List(Of RaceResult)) As List(Of DriverStanding)
        ' ... (implementation to calculate driver standings with points and tiebreakers) ...
        Dim standings As New Dictionary(Of Integer, DriverStanding)  ' Use Dictionary for efficient lookup by driver ID

        For Each result In results
            Dim driverID = result.DriverID
            If Not standings.ContainsKey(driverID) Then
                standings.Add(driverID, New DriverStanding With {.DriverID = driverID})
            End If

            Dim driverStanding = standings(driverID)
            driverStanding.Points += result.Points
            driverStanding.DriverName = result.DriverName + " " + result.DriverSurname

            driverStanding.TeamName = result.TeamName
            If Not driverStanding.Results.ContainsKey(result.GPID) Then
                driverStanding.Results.Add(result.GPID, New RaceResult() With {
                    .Season = result.Season,
                    .GPID = result.GPID,
                    .TeamID = result.TeamID,
                    .DriverID = result.DriverID,
                    .Position = result.Position,
                    .Points = result.Points
                })
            End If
        Next


        Dim resultList As New List(Of DriverStanding)
        resultList.AddRange(standings.Values)

        'Sort standings by points (descending), then by race wins (descending), etc. (implement tiebreaker logic)
        resultList.Sort(Function(x, y)
                            If x.Points <> y.Points Then
                                Return -x.Points.CompareTo(y.Points) ' Descending order for points
                            ElseIf x.RaceWins <> y.RaceWins Then
                                Return -x.RaceWins.CompareTo(y.RaceWins) ' Descending order for race wins
                            Else
                                ' Implement further tie-breaking logic here (optional)
                                ' ...
                                Return 0 ' If all comparisons are equal
                            End If
                        End Function)

        For i As Integer = 0 To resultList.Count - 1
            resultList(i).Rank = i + 1 ' Assign ranks based on sorted position
        Next

        Return resultList

    End Function


    Private Function GetConstructorStandings(ByVal driverStandings As List(Of DriverStanding)) As TeamStanding
        ' ... (implementation to calculate constructor standings based on driver standings) ...
    End Function

    Public Sub GenerateRandomRacePositions(drivers As List(Of Drivers), ByVal year As UShort, ByVal number_gp As SByte)
        Dim random As New Random()

        Dim race As New Races

        ' Shuffle the list of drivers randomly
        Dim shuffledDrivers As New List(Of Drivers)
        For i As Integer = shuffledDrivers.Count - 1 To 1 Step -1
            Dim j As Integer = random.Next(0, i + 1)
            Dim temp As Drivers = shuffledDrivers(i)
            shuffledDrivers(i) = shuffledDrivers(j)
            shuffledDrivers(j) = temp
        Next

        ' Assign positions and points based on the shuffled drivers
        For i As Integer = 0 To drivers.Count - 1
            Dim position As Integer = i + 1
            Dim driver As Drivers = shuffledDrivers(i)
            Dim point As SByte

            Select Case position
                Case 1
                    point = 10
                Case 2
                    point = 6
                Case 3
                    point = 4
                Case 4
                    point = 3
                Case 5
                    point = 2
                Case 6
                    point = 1
                Case Else
                    point = 0
            End Select

            ' Insert the race into the database
            race.Season = year
            race.GP = number_gp
            race.Driver = driver.DriverID
            race.Position = position
            race.Point = point

            race.InsertRace()
        Next
    End Sub

    Public Shared Function CalculateDriverRanking(raceList As List(Of Races), season As UShort) As Dictionary(Of Integer, Integer)
        Dim driverPoints As New Dictionary(Of Integer, Integer)()

        ' Iterate through each race and sum up the points for each driver
        For Each race In raceList
            If race.Season = season Then
                If driverPoints.ContainsKey(race.Driver) Then
                    ' If the driver already exists in the dictionary, add the points to their existing total
                    driverPoints(race.Driver) += race.Point
                Else
                    ' If the driver is not in the dictionary, add them with their initial points
                    driverPoints.Add(race.Driver, race.Point)
                End If
            End If
        Next

        ' Sort the dictionary by points in descending order to create the ranking
        Dim sortedRanking = From entry In driverPoints Order By entry.Value Descending Select entry

        ' Convert the sorted ranking to a dictionary
        Dim rankingDictionary As New Dictionary(Of Integer, Integer)()
        For Each entry In sortedRanking
            rankingDictionary.Add(entry.Key, entry.Value)
        Next

        ' Return the sorted ranking
        Return rankingDictionary
    End Function


End Class

Public Class DriverStanding
    Public Property Rank As Integer
    Public Property DriverID As Integer
    Public Property DriverName As String
    Public Property TeamName As String
    Public Property Points As Integer
    Public Property RaceWins As Integer

    Private _results As New Dictionary(Of Integer, RaceResult)
    Public ReadOnly Property Results As Dictionary(Of Integer, RaceResult)
        Get
            Return _results
        End Get
    End Property

End Class

Public Class TeamStanding
    Public Property TeamName As String
    Public Property Points As Integer
End Class

Public Class RaceResult

    Public Property Season As Integer
    Public Property GPID As Integer
    Public Property TeamID As Integer
    Public Property DriverID As Integer
    Public Property Position As Integer
    Public Property Points As Integer

    ' Additional properties you might want to include (optional)
    Public Property GPName As String ' Name of the Grand Prix
    Public Property TeamName As String ' Name of the team driver raced for
    Public Property DriverName As String ' Name of the driver
    Public Property DriverSurname As String ' Name of the driver


End Class