Imports Google.Protobuf.Compiler

Public Class CountryDAO
    Public ReadOnly Property Countries As Collection

    Public Sub New()
        Me.Countries = New Collection
    End Sub

    Public Function Insert(ByVal c As Country) As Integer
        Return DBBroker.GetBroker.Change("INSERT INTO countries VALUES ('" & c.CountryID & "', '" & c.CountryName & "' , '" & c.CountryPopulation & "');")
    End Function

    Public Sub Read(ByRef c As Country)
        Dim col As Collection : Dim aux As Collection
        col = DBBroker.GetBroker.Read("SELECT * FROM countries WHERE CountryID='" & c.CountryID & "';")
        For Each aux In col
            c.CountryName = aux(2).ToString
        Next
    End Sub

    Public Sub ReadAll()
        Dim c As Country
        Dim col, aux As Collection
        col = DBBroker.GetBroker().Read("SELECT * FROM countries ORDER BY CountryID")
        For Each aux In col
            c = New Country(aux(1).ToString)
            c.CountryName = aux(2).ToString
            Me.Countries.Add(c)
        Next
    End Sub
    Public Function Update(ByVal c As Country) As Integer
        Return DBBroker.GetBroker.Change("UPDATE countries SET CountryName='" & c.CountryName & "', CountryPopulation='" & c.CountryPopulation & "' WHERE PersonID='" & c.CountryID & "';")
    End Function

    Public Function Delete(ByVal c As Country) As Integer
        Return DBBroker.GetBroker.Change("DELETE FROM countries WHERE CountryID='" & c.CountryID & "';")
    End Function


End Class
