Public Class Races
    Public Property Season As UShort
    Public Property GP As Integer
    Public Property Driver As Integer
    Public Property Position As SByte
    Public Property Point As SByte


    Public ReadOnly Property RaceDAO As RacesDAO

    Public Sub New()
        Me.RaceDAO = New RacesDAO
    End Sub

    Public Sub New(id As Integer)
        Me.RaceDAO = New RacesDAO
        Me.Season = id
    End Sub

    Public Function InsertRace() As Integer
        Return Me.RaceDAO.Insert(Me)
    End Function

    Public Sub ReadRace()
        Me.RaceDAO.Read(Me)
    End Sub

    Public Sub ReadRaceDrivers()
        Me.RaceDAO.ReadDrivers(Me)
    End Sub

    Public Function UpdateRace() As Integer
        Return Me.RaceDAO.Update(Me)
    End Function

    Public Function DeleteRace() As Integer
        Return Me.RaceDAO.Delete(Me)
    End Function

    Public Overrides Function ToString() As String
        Return Season + GP + Position + Point
    End Function

End Class