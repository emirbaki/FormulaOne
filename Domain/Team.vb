Public Class Team
    Public Property TeamID As Integer
    Public Property TeamName As String

    Public Property TeamCountry As String
    Public Property TeamCreationDate As Date

    Public ReadOnly Property TeamDAO As TeamsDAO

    Public Sub New()
        Me.TeamDAO = New TeamsDAO
    End Sub

    Public Sub New(id As Integer)
        Me.TeamDAO = New TeamsDAO
        Me.TeamID = id
    End Sub

    Public Function InsertTeam() As Integer
        Return Me.TeamDAO.Insert(Me)
    End Function

    Public Sub ReadTeam()
        Me.TeamDAO.Read(Me)
    End Sub

    Public Function UpdateTeam() As Integer
        Return Me.TeamDAO.Update(Me)
    End Function

    Public Function DeleteTeam() As Integer
        Return Me.TeamDAO.Delete(Me)
    End Function

    Public Overrides Function ToString() As String
        Return TeamName
    End Function

End Class