Imports Google.Protobuf.Compiler
Public Class CountryDAO

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


End Class
