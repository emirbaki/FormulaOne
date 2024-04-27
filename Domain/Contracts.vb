Public Class Contracts
    Public Property Season As UShort
    Public Property Driver1 As Integer
    Public Property Driver2 As Integer
    Public Property Team As Byte


    Public ReadOnly Property ContractDAO As ContractsDAO

    Public Sub New()
        Me.ContractDAO = New ContractsDAO
    End Sub

    Public Sub New(id As Integer)
        Me.ContractDAO = New ContractsDAO
        Me.Season = id
    End Sub

    Public Function InsertContract() As Integer
        Return Me.ContractDAO.Insert(Me)
    End Function

    Public Sub ReadContract()
        Me.ContractDAO.Read(Me)
    End Sub

    Public Function UpdateContract() As Integer
        Return Me.ContractDAO.Update(Me)
    End Function

    Public Function DeleteContract() As Integer
        Return Me.ContractDAO.Delete(Me)
    End Function

    Public Overrides Function ToString() As String
        Return Season + Driver1 + Driver2 + Team
    End Function

End Class