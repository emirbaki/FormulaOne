Public Class ContractsDAO

    Public ReadOnly Property Contracts As Collection

    Public Sub New()
        Me.Contracts = New Collection
    End Sub
    Public Function Insert(ByVal t As Contracts) As Integer
        Return DBBroker.GetBroker.Change("INSERT INTO Contracts VALUES ('" & t.Team & "', '" & t.Season & "', '" & t.Driver1 & "', '" & t.Driver2 & "');")
    End Function

    Public Sub Read(ByRef t As Contracts)
        Dim col As Collection : Dim aux As Collection
        col = DBBroker.GetBroker.Read("SELECT * FROM Contracts WHERE Season='" & t.Season & "' AND Team='" & t.Team & "';")
    End Sub

    Public Sub ReadAll()
        Dim t As Contracts
        Dim col, aux As Collection
        col = DBBroker.GetBroker().Read("SELECT * FROM Contracts ORDER BY Season")
        For Each aux In col
            t = New Contracts(aux(1))
            t.Season = aux(2).ToString
            t.Team = aux(3).ToString
            t.Driver1 = aux(4).ToString
            t.Driver2 = aux(5).ToString
            Me.Contracts.Add(t)
        Next
    End Sub

    Public Function Update(ByVal t As Contracts) As Integer
        Return DBBroker.GetBroker.Change("UPDATE Contracts SET Driver1='" & t.Driver1 & "', Driver2='" & t.Driver2 & "' WHERE Season='" & t.Season & "' AND Team='" & t.Team & "';")
    End Function

    Public Function Delete(ByVal t As Contracts) As Integer
        Return DBBroker.GetBroker.Change("DELETE FROM Contracts WHERE Season='" & t.Season & "' AND Team='" & t.Team & "';")
    End Function


End Class