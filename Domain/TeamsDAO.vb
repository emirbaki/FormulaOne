Public Class TeamsDAO

    Public Function Insert(ByVal t As Team) As Integer
        Return DBBroker.GetBroker.Change("INSERT INTO teams VALUES ('" & t.TeamID & "', '" & t.TeamName & "' , '" & t.TeamCreationDate & "');")
    End Function

    Public Sub Read(ByRef t As Team)
        Dim col As Collection : Dim aux As Collection
        col = DBBroker.GetBroker.Read("SELECT * FROM teams WHERE TeamID='" & t.TeamID & "';")
    End Sub
    Public Function Update(ByVal t As Team) As Integer
        Return DBBroker.GetBroker.Change("UPDATE teams SET TeamName='" & t.TeamName & "', TeamPopulation='" & t.TeamCreationDate & "' WHERE PersonID='" & t.TeamID & "';")
    End Function

    Public Function Delete(ByVal t As Team) As Integer
        Return DBBroker.GetBroker.Change("DELETE FROM teams WHERE TeamID='" & t.TeamID & "';")
    End Function


End Class
