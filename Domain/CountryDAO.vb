Imports Google.Protobuf.Compiler
Public Class CountryDAO

    Public Function Insert(ByVal c As Country) As Integer
        Return DBBroker.GetBroker.Change("INSERT INTO Persons VALUES ('" & c.CountryID & "', '" & c.CountryName & "' , '" & c.CountryPopulation & "');")
    End Function
End Class

//Test