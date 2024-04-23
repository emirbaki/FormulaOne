Public Class DriversDAO

    Public ReadOnly Property Drivers As Collection

    Public Sub New()
        Me.Drivers = New Collection
    End Sub
    Public Function Insert(ByVal t As Drivers) As Integer
        Return DBBroker.GetBroker.Change("INSERT INTO Drivers VALUES ('" & t.DriverID & "', '" & t.DriverName & "', '" & t.DriverSurname & "', '" & t.DriverCountry & "');")
    End Function

    Public Sub Read(ByRef t As Drivers)
        Dim col As Collection : Dim aux As Collection
        col = DBBroker.GetBroker.Read("SELECT * FROM Drivers WHERE DriverID='" & t.DriverID & "';")
    End Sub

    Public Sub ReadAll()
        Dim t As Drivers
        Dim col, aux As Collection
        col = DBBroker.GetBroker().Read("SELECT * FROM Drivers ORDER BY DriverID")
        For Each aux In col
            t = New Drivers(aux(1))
            t.DriverName = aux(2).ToString
            t.DriverCountry = aux(3).ToString
            Me.Drivers.Add(t)
        Next
    End Sub

    Public Function Update(ByVal t As Drivers) As Integer
        Return DBBroker.GetBroker.Change("UPDATE Drivers SET DriverName='" & t.DriverName & "', DriversSurname='" & t.DriverSurname & "' WHERE DriverID='" & t.DriverID & "';")
    End Function

    Public Function Delete(ByVal t As Drivers) As Integer
        Return DBBroker.GetBroker.Change("DELETE FROM Drivers WHERE DriverID='" & t.DriverID & "';")
    End Function


End Class
