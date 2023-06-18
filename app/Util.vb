Imports System.Globalization
Imports System.IO
Imports System.Text

Module Util
    Public Function disable_all_pages(tab_control As TabControl)
        For i As Integer = 0 To tab_control.TabPages.Count - 1
            tab_control.TabPages(i).Enabled = False
        Next
        Return 0
    End Function

    Public Function select_tab(tab_control As TabControl, index As Integer)
        disable_all_pages(tab_control)
        tab_control.TabPages(index).Enabled = True
        tab_control.SelectTab(index)
        Return 0
    End Function

    Public Function populate_dropdown(populate_element As ComboBox, cities As List(Of City), exclude_value As String)
        populate_element.Items.Clear()
        For Each city As City In cities
            If String.Equals(city.Name, exclude_value) Then
                Continue For
            End If
            populate_element.Items.Add(city.Name)
        Next
        Return 0
    End Function

    Public Function verify_group_ticket_bahncards(pessenger_count_textbox As TextBox, discount_25_count_textbox As TextBox, discount_50_count_textbox As TextBox)
        Dim max_value As Integer = Integer.Parse(pessenger_count_textbox.Text)
        Dim discount_25_count As Integer = Integer.Parse(discount_25_count_textbox.Text)
        Dim discount_50_count As Integer = Integer.Parse(discount_50_count_textbox.Text)

        If discount_25_count > max_value Then
            discount_25_count_textbox.BackColor = Color.LightCoral
            discount_50_count_textbox.BackColor = SystemColors.Window
            Return 1
        ElseIf discount_50_count > max_value Then
            discount_50_count_textbox.BackColor = Color.LightCoral
            discount_25_count_textbox.BackColor = SystemColors.Window
            Return 1
        ElseIf (discount_25_count + discount_50_count) > max_value Then
            discount_25_count_textbox.BackColor = Color.LightCoral
            discount_50_count_textbox.BackColor = Color.LightCoral
            Return 1
        End If

        discount_25_count_textbox.BackColor = SystemColors.Window
        discount_50_count_textbox.BackColor = SystemColors.Window
        Return 0
    End Function


    Function load_cities_from_file(filePath As String) As List(Of City)
        Dim städteListe As New List(Of City)
        Dim kultur As CultureInfo = CultureInfo.InvariantCulture ' für . as ,
        Try
            Dim zeilen As String() = File.ReadAllLines(filePath)

            For Each zeile As String In zeilen
                Dim spalte As String() = zeile.Split(";")
                Dim stadt As New City(spalte(0), Double.Parse(spalte(1), kultur), Double.Parse(spalte(2), kultur))
                städteListe.Add(stadt)
            Next
        Catch ex As Exception
            Console.WriteLine("Fehler beim Einlesen der Datei: " & ex.Message)
        End Try
        Return städteListe
    End Function

    Public Function get_passenger_list(passenger_count_tb As TextBox, passenger_type As PassengerType, bahncard_25_count_tb As TextBox, bahncard_50_count_tb As TextBox) As List(Of Passenger)
        Dim passengers As List(Of Passenger) = New List(Of Passenger)

        Dim passenger_count As Integer = Integer.Parse(passenger_count_tb.Text)
        Dim bahncard_25_count As Integer = Integer.Parse(bahncard_25_count_tb.Text)
        Dim bahncard_50_count As Integer = Integer.Parse(bahncard_50_count_tb.Text)

        For i As Integer = 1 To passenger_count - bahncard_25_count - bahncard_50_count
            passengers.Add(New Passenger(passenger_type, 0))
        Next

        For i As Integer = 1 To bahncard_25_count
            passengers.Add(New Passenger(passenger_type, 0.25))
        Next

        For i As Integer = 1 To bahncard_50_count
            passengers.Add(New Passenger(passenger_type, 0.5))
        Next
        Return passengers
    End Function


    Private Function ConvertToRadians(degrees As Decimal) As Decimal
        Return degrees * Math.PI / 180
    End Function

    Public Function BerechneEntfernung(start As City, ziel As City) As Decimal
        ' Konstante für den Erdradius in Kilometern
        Const Erdradius As Decimal = 6371

        ' Umwandlung der geographischen Koordinaten in Radiant
        Dim startLatRad As Decimal = ConvertToRadians(start.Lat)
        Dim startLonRad As Decimal = ConvertToRadians(start.Lon)
        Dim zielLatRad As Decimal = ConvertToRadians(ziel.Lat)
        Dim zielLonRad As Decimal = ConvertToRadians(ziel.Lon)

        ' Berechnung des Abstands
        Dim latDiffRad As Decimal = zielLatRad - startLatRad
        Dim lonDiffRad As Decimal = zielLonRad - startLonRad

        Dim a As Decimal = Math.Sin(latDiffRad / 2) ^ 2 + Math.Cos(startLatRad) * Math.Cos(zielLatRad) * Math.Sin(lonDiffRad / 2) ^ 2
        Dim c As Decimal = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a))

        ' Berechnung der Entfernung unter Berücksichtigung des Erdradius
        Dim entfernung As Decimal = Erdradius * c

        Return entfernung
    End Function

    Public Function get_km_preis()
        Return 0.1
    End Function

    Public Function get_kind_rabatt()
        Return 0.5 ' 50 %
    End Function

    Public Function get_erm_rabatt()
        Return 0.8 ' 20%
    End Function


    Public Function get_gruppen_rabatt(anzahl As Integer) As Decimal
        If anzahl > 25 Then
            Return 0.1
        ElseIf anzahl > 10 Then
            Return 0.07
        ElseIf anzahl > 5 Then
            Return 0.03
        End If
        Return 0
    End Function

    Public Function get_payment_method_fee(pyment_type As PaymentType) As Decimal
        Select Case pyment_type
            Case PaymentType.CreditCard
                Return 0.3
            Case PaymentType.EC
                Return 0.01
            Case PaymentType.Cash
                Return 0
        End Select
    End Function

    Public Function calculate_prices(start As City, ziel As City, passagiere As List(Of Passenger)) As Results
        Dim ergebnis As Results = New Results
        Dim entfernung As Decimal = BerechneEntfernung(start, ziel) ' Annahme: Funktion zum Berechnen der Entfernung
        Dim preisProKilometer As Decimal = get_km_preis() ' Annahme: Preis pro Kilometer

        Dim gruppen_rabatt = get_gruppen_rabatt(passagiere.Count())
        ergebnis.Gruppen_Rabatt = gruppen_rabatt

        For Each passagier In passagiere
            Dim preis As Decimal = preisProKilometer * entfernung

            Select Case passagier.Typ
                Case PassengerType.Adault
                    ergebnis.Anzahl_Erwachsene += 1
                    preis *= 1 ' Kein Rabatt für Erwachsene
                    ergebnis.Regulärpreis_Erwachsene += preis
                    preis *= (1 - passagier.Bahncard - gruppen_rabatt)
                    ergebnis.Preis_Erwachsene += preis
                Case PassengerType.Child
                    ergebnis.Anzahl_Kinder += 1
                    preis *= get_kind_rabatt()
                    ergebnis.Regulärpreis_Kinder += preis
                    preis *= (1 - passagier.Bahncard - gruppen_rabatt)
                    ergebnis.Preis_Kinder += preis
                Case PassengerType.Reduced
                    ergebnis.Anzahl_Ermäßigte += 1
                    preis *= get_erm_rabatt()
                    ergebnis.Regulärpreis_Ermäßigte += preis
                    preis *= (1 - passagier.Bahncard - gruppen_rabatt)
                    ergebnis.Preis_Ermäßigte += preis
            End Select
        Next
        Return ergebnis
    End Function
End Module
