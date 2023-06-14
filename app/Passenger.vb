Public Class Passenger
    Public Property Bahncard As Decimal
    Public Property Typ As PassengerType

    Public Sub New(Typ As PassengerType, Bahncard As Decimal)
        Me.Typ = Typ
        Me.Bahncard = Bahncard
    End Sub

End Class
