Public Class RacesDAO

    Public ReadOnly Property Races As Collection

    Public Sub New()
        Me.Races = New Collection
    End Sub
    Public Function Insert(ByVal t As Races) As Integer
        Return DBBroker.GetBroker.Change("INSERT INTO Races VALUES ('" & t.Season & "', '" & t.GP & "', '" & t.Driver & "', '" & t.Position & "', '" & t.Point & "');")
    End Function

    Public Sub Read(ByRef t As Races)
        Dim col As Collection : Dim aux As Collection
        col = DBBroker.GetBroker.Read("SELECT * FROM Races WHERE Season='" & t.Season & "' AND GP='" & t.GP & "' AND Driver='" & t.Driver & "';")
    End Sub


    Public Sub ReadDrivers(ByRef t As Races)
        Dim col As Collection : Dim aux As Collection
        col = DBBroker.GetBroker.Read("SELECT * FROM Races WHERE Season='" & t.Season & "' AND GP='" & t.GP & "' AND Position='" & t.Position & "';")
    End Sub

    Public Sub ReadAll()
        Dim t As Races
        Dim col, aux As Collection
        col = DBBroker.GetBroker().Read("SELECT * FROM Races ORDER BY Season")
        For Each aux In col
            t = New Races(aux(1))
            t.Season = aux(2).ToString
            t.GP = aux(3).ToString
            t.Driver = aux(4).ToString
            t.Position = aux(5).ToString
            t.Point = aux(6).ToString
            Me.Races.Add(t)
        Next
    End Sub

    Public Function Update(ByVal t As Races) As Integer
        Return DBBroker.GetBroker.Change("UPDATE Races SET Position='" & t.Position & "', Point='" & t.Point & "' WHERE Season='" & t.Season & "' AND GP='" & t.GP & "' AND Driver='" & t.Driver & "';")
    End Function

    Public Function Delete(ByVal t As Races) As Integer
        Return DBBroker.GetBroker.Change("DELETE FROM Races WHERE Season='" & t.Season & "' AND GP='" & t.GP & "' AND Driver='" & t.Driver & "';")
    End Function


End Class
