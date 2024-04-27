Public Class Calendars
    Public Property Season As UShort
    Public Property GP As Integer
    Public Property Order As SByte

    Public ReadOnly Property CalendarDAO As CalendarsDAO

    Public Sub New()
        Me.CalendarDAO = New CalendarsDAO
    End Sub

    Public Sub New(id As Integer)
        Me.CalendarDAO = New CalendarsDAO
        Me.Season = id
    End Sub

    Public Function InsertCalendar() As Integer
        Return Me.CalendarDAO.Insert(Me)
    End Function

    Public Sub ReadCalendar()
        Me.CalendarDAO.Read(Me)
    End Sub

    Public Sub ReadCalendarGP()
        Me.CalendarDAO.ReadGP(Me)
    End Sub

    Public Function UpdateCalendar() As Integer
        Return Me.CalendarDAO.Update(Me)
    End Function

    Public Function DeleteCalendar() As Integer
        Return Me.CalendarDAO.Delete(Me)
    End Function

    Public Overrides Function ToString() As String
        Return Season + GP + Order
    End Function

End Class