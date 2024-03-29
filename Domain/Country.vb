﻿Public Class Country
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
        Return CountryName
    End Function
End Class
