Public Class Results
    Public Regulärpreis_Erwachsene As Decimal = 0
    Public Regulärpreis_Kinder As Decimal = 0
    Public Regulärpreis_Ermäßigte As Decimal = 0

    Public Preis_Erwachsene As Decimal = 0
    Public Preis_Kinder As Decimal = 0
    Public Preis_Ermäßigte As Decimal = 0

    Public Property Rabatt_Erwachsene As Decimal
        Get
            Return Me.Regulärpreis_Erwachsene - Me.Preis_Erwachsene
        End Get
        Protected Set(value As Decimal)
        End Set
    End Property

    Public Property Rabatt_Kinder As Decimal
        Get
            Return Me.Regulärpreis_Kinder - Me.Preis_Kinder
        End Get
        Protected Set(value As Decimal)
        End Set
    End Property

    Public Property Rabatt_Ermäßigte As Decimal
        Get
            Return Me.Regulärpreis_Ermäßigte - Me.Preis_Ermäßigte
        End Get
        Set(value As Decimal)

        End Set
    End Property

    Public Gruppen_Rabatt As Integer = 0

    Public Anzahl_Erwachsene As Integer = 0
    Public Anzahl_Kinder As Integer = 0
    Public Anzahl_Ermäßigte As Integer = 0

    Public Property total As Decimal
        Get
            Return Me.Preis_Erwachsene + Me.Preis_Kinder + Me.Preis_Ermäßigte
        End Get
        Set(value As Decimal)

        End Set
    End Property

    Public Property Summe_Regulärpreis As Decimal
        Get
            Return Me.Regulärpreis_Erwachsene + Me.Regulärpreis_Kinder + Me.Regulärpreis_Ermäßigte
        End Get
        Set(value As Decimal)

        End Set
    End Property

    Public Property Summe_Rabatt As Decimal
        Get
            Return Me.Rabatt_Erwachsene + Me.Rabatt_Kinder + Me.Rabatt_Ermäßigte
        End Get
        Set(value As Decimal)

        End Set
    End Property

End Class
