Public Class Drivers
    Public Property DriverID As Integer
    Public Property DriverName As String
    Public Property DriverSurname As String
    Public Property DriverCountry As String

    Public ReadOnly Property DriverDAO As DriversDAO

    Public Sub New()
        Me.DriverDAO = New DriversDAO
    End Sub

    Public Sub New(id As Integer)
        Me.DriverDAO = New DriversDAO
        Me.DriverID = id
    End Sub

    Public Function InsertDriver() As Integer
        Return Me.DriverDAO.Insert(Me)
    End Function

    Public Sub ReadDriver()
        Me.DriverDAO.Read(Me)
    End Sub

    Public Function UpdateDriver() As Integer
        Return Me.DriverDAO.Update(Me)
    End Function

    Public Function DeleteDriver() As Integer
        Return Me.DriverDAO.Delete(Me)
    End Function

    Public Overrides Function ToString() As String
        Return DriverName + " " + DriverSurname
    End Function

End Class