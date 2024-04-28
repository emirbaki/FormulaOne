Public Class CalendarsDAO

    Public ReadOnly Property Calendars As Collection

    Public Sub New()
        Me.Calendars = New Collection
    End Sub
    Public Function Insert(ByVal t As Calendars) As Integer
        Return DBBroker.GetBroker.Change("INSERT INTO Calendar VALUES ('" & t.Season & "', '" & t.GP & "', '" & t.Order & "');")
    End Function

    Public Sub Read(ByRef t As Calendars)
        Dim col As Collection : Dim aux As Collection
        col = DBBroker.GetBroker.Read("SELECT * FROM Calendar WHERE Season='" & t.Season & "' AND GP='" & t.GP & "';")
        If col.Count > 0 Then  ' Check if there's any data retrieved
            aux = col(1) ' Access the first item in the collection
            t.GP = aux(2) ' Update existing object's properties
            t.Order = aux(3)
        End If
    End Sub

    Public Sub ReadGP(ByRef t As Calendars)
        Dim col As Collection : Dim aux As Collection
        col = DBBroker.GetBroker.Read("SELECT * FROM calendar WHERE Season='" & t.Season & "' AND `Order`= '" & t.Order & "';")
        If col.Count > 0 Then  ' Check if there's any data retrieved
            aux = col(1) ' Access the first item in the collection
            t.GP = aux(2)
            t.Order = aux(3)
        End If
    End Sub

    Public Sub ReadAll()
        Dim t As Calendars
        Dim col, aux As Collection
        col = DBBroker.GetBroker().Read("SELECT * FROM Calendars ORDER BY Season")
        For Each aux In col
            t = New Calendars(aux(1))
            t.Season = aux(2).ToString
            t.GP = aux(3).ToString
            t.Order = aux(4).ToString
            Me.Calendars.Add(t)
        Next
    End Sub

    Public Function Update(ByVal t As Calendars) As Integer
        Return DBBroker.GetBroker.Change("UPDATE Calendars SET GP='" & t.GP & "', Order='" & t.Order & "' WHERE Season='" & t.Season & "' AND GP='" & t.GP & "';")
    End Function

    Public Function Delete(ByVal t As Calendars) As Integer
        Return DBBroker.GetBroker.Change("DELETE FROM Calendars WHERE Season='" & t.Season & "' AND GP='" & t.GP & "';")
    End Function


End Class
