Public Class Passenger
    Public Bahncard As Decimal
    Public Typ As PassengerType

    Public Sub New(Typ As PassengerType, Bahncard As Decimal)
        Me.Typ = Typ
        Me.Bahncard = Bahncard
    End Sub

End Class
