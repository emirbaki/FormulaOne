Public Class GPs
    Public Property GPID As Integer
    Public Property GPName As String
    Public Property GPCountry As String

    Public ReadOnly Property GpDAO As GPsDAO

    Public Sub New()
        Me.GpDAO = New GPsDAO
    End Sub

    Public Sub New(id As Integer)
        Me.GpDAO = New GPsDAO
        Me.GPID = id
    End Sub

    Public Function InsertGP() As Integer
        Return Me.GpDAO.Insert(Me)
    End Function

    Public Sub ReadGP()
        Me.GpDAO.Read(Me)
    End Sub

    Public Function UpdateGP() As Integer
        Return Me.GpDAO.Update(Me)
    End Function

    Public Function DeleteGP() As Integer
        Return Me.GpDAO.Delete(Me)
    End Function

    Public Overrides Function ToString() As String
        Return GPName
    End Function

End Class