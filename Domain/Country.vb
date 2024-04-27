Public Class Country
    Public Property CountryID As String
    Public Property CountryName As String
    Public Property CountryPopulation As String
    Public ReadOnly Property CountDAO As CountryDAO

    Public Sub New()
        Me.CountDAO = New CountryDAO
    End Sub

    Public Sub New(id As String)
        Me.CountDAO = New CountryDAO
        Me.CountryID = id
    End Sub

    Public Function InsertCountry() As Integer
        CountryID = GenerateUniqueCode(CapitalizeFirstThree(CountryName))
        Return Me.CountDAO.Insert(Me)
    End Function

    Public Sub ReadCountry()
        Me.CountDAO.Read(Me)
    End Sub

    Public Function UpdateCountry() As Integer
        Return Me.CountDAO.Update(Me)
    End Function

    Public Function DeleteCountry() As Integer
        Return Me.CountDAO.Delete(Me)
    End Function

    Public Overrides Function ToString() As String
        Return CountryID
    End Function


    Function CapitalizeFirstThree(inputString As String) As String
        If inputString.Length < 3 Then
            Return inputString.ToUpper()
        Else
            Return inputString.Substring(0, 3).ToUpper()
        End If
    End Function


    Function GenerateUniqueCode(capitalizedFirstThree As String) As String
        Dim uniqueCode As String = String.Empty


        If Me.CountDAO.CheckID(capitalizedFirstThree) > 0 Then
            Dim count = 3
            uniqueCode = capitalizedFirstThree
            While Me.CountDAO.CheckID(uniqueCode) = 1
                count += 1
                uniqueCode = capitalizedFirstThree.Substring(0, 2) & Char.ToUpper(Me.CountryName(count))
            End While
            uniqueCode = capitalizedFirstThree.Substring(0, 2) & Char.ToUpper(Me.CountryName(count))
        Else
            uniqueCode = capitalizedFirstThree
        End If

        Return uniqueCode
    End Function

End Class
