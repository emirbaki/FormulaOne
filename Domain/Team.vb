Public Class Team
    Public Property TeamID As Integer
    Public Property TeamName As String

    Public Property TeamCountry As String
    Public Property TeamCreationDate As DateTime

    Public ReadOnly Property TeamDAO As TeamsDAO

    Public Sub New()
        Me.TeamDAO = New TeamsDAO
    End Sub

    Public Sub New(id As Integer)
        Me.TeamDAO = New TeamsDAO
        Me.TeamID = id
    End Sub

    Public Function InsertCountry() As Integer
        Return Me.TeamDAO.Insert(Me)
    End Function

    Public Sub ReadCountry()
        Me.TeamDAO.Read(Me)
    End Sub

    Public Function UpdateCountry() As Integer
        Return Me.TeamDAO.Update(Me)
    End Function

    Public Function DeleteCountry() As Integer
        Return Me.TeamDAO.Delete(Me)
    End Function

    Public Overrides Function ToString() As String
        Return TeamName
    End Function

End Class