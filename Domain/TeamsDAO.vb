Imports System.Globalization

Public Class TeamsDAO

    Public ReadOnly Property Teams As Collection

    Public Sub New()
        Me.Teams = New Collection
    End Sub
    Public Function Insert(ByVal t As Team) As Integer
        Return DBBroker.GetBroker.Change("INSERT INTO teams VALUES ('" & t.TeamID & "', '" & t.TeamName & "', '" & t.TeamCountry & "' , STR_TO_DATE('" & t.TeamCreationDate & "', '%d.%m.%Y'))")
    End Function

    Public Sub Read(ByRef t As Team)
        Dim col As Collection : Dim aux As Collection
        col = DBBroker.GetBroker.Read("SELECT * FROM teams WHERE TeamID='" & t.TeamID & "';")
    End Sub

    Public Sub ReadAll()
        Dim t As Team
        Dim col, aux As Collection
        col = DBBroker.GetBroker().Read("SELECT * FROM teams ORDER BY TeamID")
        For Each aux In col
            t = New Team(aux(1))
            t.TeamName = aux(2).ToString
            t.TeamCountry = aux(3).ToString
            t.TeamCreationDate = aux(4)
            Me.Teams.Add(t)
        Next
    End Sub

    Public Function Update(ByVal t As Team) As Integer
        Return DBBroker.GetBroker.Change("UPDATE teams SET TeamName='" & t.TeamName & "', TeamPopulation='" & t.TeamCreationDate & "' WHERE PersonID='" & t.TeamID & "';")
    End Function

    Public Function Delete(ByVal t As Team) As Integer
        Return DBBroker.GetBroker.Change("DELETE FROM teams WHERE TeamID='" & t.TeamID & "';")
    End Function


End Class
