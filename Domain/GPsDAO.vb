Public Class GPsDAO

    Public ReadOnly Property GPs As Collection

    Public Sub New()
        Me.GPs = New Collection
    End Sub
    Public Function Insert(ByVal t As GPs) As Integer
        Return DBBroker.GetBroker.Change("INSERT INTO gps VALUES ('" & t.GPID & "', '" & t.GPName & "', '" & t.GPCountry & "');")
    End Function

    Public Sub Read(ByRef t As GPs)
        Dim col As Collection : Dim aux As Collection
        col = DBBroker.GetBroker.Read("SELECT * FROM gps WHERE GPID='" & t.GPID & "';")
    End Sub

    Public Sub ReadAll()
        Dim t As GPs
        Dim col, aux As Collection
        col = DBBroker.GetBroker().Read("SELECT * FROM gps ORDER BY GPID")
        For Each aux In col
            t = New GPs(aux(1))
            t.GPName = aux(2).ToString
            t.GPCountry = aux(3).ToString
            Me.GPs.Add(t)
        Next
    End Sub

    Public Function Update(ByVal t As GPs) As Integer
        Return DBBroker.GetBroker.Change("UPDATE gps SET GPName='" & t.GPName & "' WHERE GPID='" & t.GPID & "';")
    End Function

    Public Function Delete(ByVal t As GPs) As Integer
        Return DBBroker.GetBroker.Change("DELETE FROM gps WHERE GPID='" & t.GPID & "';")
    End Function


End Class
