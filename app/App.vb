Public Class App
    Const START_TAB As Integer = 0
    Const SINGLE_TICKET_TAB As Integer = 1
    Const GROUP_TICKET_TAB As Integer = 2
    Const CHECK_OUT_TAB As Integer = 3
    Const RRCEIPT_TAB As Integer = 4
    Const DEFAULT_DEPARTURE_ARRIVAL_VALUE = "Bitte auswählen"


    Dim Cities As List(Of City)
    Dim Passengers As List(Of Passenger) = New List(Of Passenger)
    Dim DepartureCity As City
    Dim ArrivalCity As City
    Dim PAYMENT_TYPE As PaymentType



    Private Sub App_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cities = load_cities_from_file("Cities.txt")
        arrival_combo_box.DisplayMember = "Text"
        departure_combo_box.DisplayMember = "Text"
        For Each city As City In Cities
            departure_combo_box.Items.Add(city.Name)
            arrival_combo_box.Items.Add(city.Name)
        Next
        arrival_combo_box.Text = DEFAULT_DEPARTURE_ARRIVAL_VALUE
        departure_combo_box.Text = DEFAULT_DEPARTURE_ARRIVAL_VALUE
        Util.select_tab(main_tab_control, START_TAB)
    End Sub

#Region "Zeichen Filter"
    Private Function filter_non_digt_char(e As KeyPressEventArgs)
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True ' Unterdrückt das Einfügen des Zeichens
        End If
    End Function

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_gt_er.KeyPress
        filter_non_digt_char(e)
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_gt_k.KeyPress
        filter_non_digt_char(e)
    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_gt_e.KeyPress
        filter_non_digt_char(e)
    End Sub


    Private Sub tb_gt_er_25_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_gt_er_25.KeyPress
        filter_non_digt_char(e)
    End Sub

    Private Sub tb_gt_k_25_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_gt_k_25.KeyPress
        filter_non_digt_char(e)

    End Sub

    Private Sub tb_gt_e_25_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_gt_e_25.KeyPress
        filter_non_digt_char(e)
    End Sub

    Private Sub tb_gt_er_50_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_gt_er_50.KeyPress
        filter_non_digt_char(e)
    End Sub

    Private Sub tb_gt_k_50_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_gt_k_50.KeyPress
        filter_non_digt_char(e)
    End Sub

    Private Sub tb_gt_e_50_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_gt_e_50.KeyPress
        filter_non_digt_char(e)
    End Sub


#End Region


#Region "Start Tab"
    Private Sub btn_single_Click(sender As Object, e As EventArgs) Handles btn_single.Click
        Util.select_tab(main_tab_control, SINGLE_TICKET_TAB)
    End Sub

    Private Sub btn_btn_group_Click(sender As Object, e As EventArgs) Handles btn_group.Click
        Util.select_tab(main_tab_control, GROUP_TICKET_TAB)
    End Sub


    Private Sub departure_combo_box_Click(sender As Object, e As EventArgs) Handles departure_combo_box.Click
        Util.populate_dropdown(sender, Cities, arrival_combo_box.Text)
    End Sub

    Private Sub arrival_combo_box_Click(sender As Object, e As EventArgs) Handles arrival_combo_box.Click
        Util.populate_dropdown(sender, Cities, departure_combo_box.Text)
    End Sub


    Private Sub departure_combo_box_SelectedIndexChanged(sender As Object, e As EventArgs) Handles departure_combo_box.SelectedIndexChanged
        verify_selection_and_proceed()
        DepartureCity = Cities.Find(Function(c) c.Name = departure_combo_box.Text)

    End Sub

    Private Sub arrival_combo_box_SelectedIndexChanged(sender As Object, e As EventArgs) Handles arrival_combo_box.SelectedIndexChanged
        verify_selection_and_proceed()
        ArrivalCity = Cities.Find(Function(c) c.Name = arrival_combo_box.Text)
    End Sub
    Private Function verify_selection_and_proceed()
        If String.Equals(departure_combo_box.Text, DEFAULT_DEPARTURE_ARRIVAL_VALUE) Or
            String.Equals(arrival_combo_box.Text, DEFAULT_DEPARTURE_ARRIVAL_VALUE) Or
            String.Equals(departure_combo_box.Text, arrival_combo_box.Text) Then
            btn_single.Enabled = False
            btn_group.Enabled = False
            Return 0
        End If

        btn_single.Enabled = True
        btn_group.Enabled = True
        Return 0
    End Function
#End Region

#Region "Single Ticket Tab"
    Private Sub btn_single_ticket_proceed_Click(sender As Object, e As EventArgs) Handles btn_single_ticket_proceed.Click
        Passengers.Clear()
        Dim passenger_type As PassengerType
        Dim bahncard As Decimal

        If rb_atault.Checked Then
            passenger_type = PassengerType.Adault
        ElseIf rb_child.Checked Then
            passenger_type = PassengerType.Child
        Else
            passenger_type = PassengerType.Reduced
        End If

        If rb_bc_0.Checked Then
            bahncard = 0
        ElseIf rb_bc_25.Checked Then
            bahncard = 0.25
        Else
            bahncard = 0.5
        End If
        Passengers.Add(New Passenger(passenger_type, bahncard))

        Util.select_tab(main_tab_control, CHECK_OUT_TAB)
    End Sub
#End Region

#Region "Group Ticket Tab"
    Private Sub btn_group_ticket_proceed_Click(sender As Object, e As EventArgs) Handles btn_group_ticket_proceed.Click
        Passengers.Clear()

        If verify_minimum_group_passengers() Then
            MessageBox.Show("Gruppenticket ab min. 5 Fahrgästen!", "Info", MessageBoxButtons.OK)
            Return
        End If

        If verify_bahncards() Then
            MessageBox.Show("Ungültige eingabe!", "Info", MessageBoxButtons.OK)
            Return
        End If

        Dim adault_passengers As List(Of Passenger) = Util.get_passenger_list(tb_gt_er, PassengerType.Adault, tb_gt_er_25, tb_gt_er_50)
        Passengers.AddRange(adault_passengers)

        Dim child_passengers As List(Of Passenger) = Util.get_passenger_list(tb_gt_k, PassengerType.Child, tb_gt_k_25, tb_gt_k_50)
        Passengers.AddRange(child_passengers)

        Dim reduced_passengers As List(Of Passenger) = Util.get_passenger_list(tb_gt_e, PassengerType.Reduced, tb_gt_e_25, tb_gt_e_50)
        Passengers.AddRange(reduced_passengers)

        Util.select_tab(main_tab_control, CHECK_OUT_TAB)
    End Sub

    Private Function verify_minimum_group_passengers() As Boolean
        Dim adault_count As Integer = Integer.Parse(tb_gt_er.Text)
        Dim child_count As Integer = Integer.Parse(tb_gt_k.Text)
        Dim reduced_count As Integer = Integer.Parse(tb_gt_e.Text)
        Const min_passengers = 5

        If (adault_count + child_count + reduced_count) < min_passengers Then
            tb_gt_er.BackColor = Color.LightCoral
            tb_gt_k.BackColor = Color.LightCoral
            tb_gt_e.BackColor = Color.LightCoral
            Return True
        End If
        tb_gt_er.BackColor = SystemColors.Window
        tb_gt_k.BackColor = SystemColors.Window
        tb_gt_e.BackColor = SystemColors.Window
        Return False
    End Function

    Private Function verify_bahncards() As Boolean
        Dim c As Integer = Util.verify_group_ticket_bahncards(tb_gt_er, tb_gt_er_25, tb_gt_er_50)
        c += Util.verify_group_ticket_bahncards(tb_gt_k, tb_gt_k_25, tb_gt_k_50)
        c += Util.verify_group_ticket_bahncards(tb_gt_e, tb_gt_e_25, tb_gt_e_50)
        If c > 0 Then
            Return True
        End If
        Return False
    End Function

#End Region

#Region "Payment Type Tab"
    Private Sub btn_cash_Click(sender As Object, e As EventArgs) Handles btn_cash.Click
        PAYMENT_TYPE = PaymentType.Cash
        display_recive()
    End Sub

    Private Sub btn_ec_Click(sender As Object, e As EventArgs) Handles btn_ec.Click
        PAYMENT_TYPE = PaymentType.EC
        display_recive()
    End Sub

    Private Sub btn_credit_card_Click(sender As Object, e As EventArgs) Handles btn_credit_card.Click
        PAYMENT_TYPE = PaymentType.CreditCard
        display_recive()
    End Sub
    Private Function display_recive()
        Util.select_tab(main_tab_control, RRCEIPT_TAB)

        label_start.Text = departure_combo_box.Text
        label_ziel.Text = arrival_combo_box.Text
        Dim entfernung As Decimal = Math.Round(BerechneEntfernung(DepartureCity, ArrivalCity), 2)
        label_entfernung.Text = entfernung.ToString() + " km"
        label_dauer.Text = Math.Round(entfernung / 100, 2).ToString() + " h"

        Dim details As Results = calculate_prices(DepartureCity, ArrivalCity, Passengers)

        label_sum_erwachsene.Text = details.Anzahl_Erwachsene
        label_sum_kinder.Text = details.Anzahl_Kinder
        label_sum_ermäßigte.Text = details.Anzahl_Kinder
        label_sum_passagiere.Text = Passengers.Count()

        label_erw_reg_preis.Text = Math.Round(details.Regulärpreis_Erwachsene, 2).ToString() + " €"
        label_kin_reg_preis.Text = Math.Round(details.Regulärpreis_Kinder, 2).ToString() + " €"
        label_erm_reg_preis.Text = Math.Round(details.Regulärpreis_Ermäßigte, 2).ToString() + " €"
        label_sum_reg_preis.Text = Math.Round(details.Summe_Regulärpreis, 2).ToString() + " €"

        label_erw_preis.Text = Math.Round(details.Preis_Erwachsene, 2).ToString() + " €"
        label_kin_preis.Text = Math.Round(details.Preis_Kinder, 2).ToString() + " €"
        label_erm_preis.Text = Math.Round(details.Preis_Ermäßigte, 2).ToString() + " €"
        label_sum_preis.Text = Math.Round(details.total, 2).ToString() + " €"

        label_erw_rabatt.Text = Math.Round(details.Rabatt_Erwachsene, 2).ToString() + " €"
        label_kin_rabatt.Text = Math.Round(details.Rabatt_Kinder, 2).ToString() + " €"
        label_erm_rabatt.Text = Math.Round(details.Rabatt_Ermäßigte, 2).ToString() + " €"
        label_sum_rabatt.Text = Math.Round(details.Summe_Rabatt, 2).ToString() + " €"

        label_zahl_art.Text = PAYMENT_TYPE.ToString()
        label_zahl_gebühr.Text = Math.Round(get_payment_method_fee(PAYMENT_TYPE) * details.total, 2).ToString() + " €"
    End Function
#End Region
    Private Function reset_start_tab()
        arrival_combo_box.Text = DEFAULT_DEPARTURE_ARRIVAL_VALUE
        departure_combo_box.Text = DEFAULT_DEPARTURE_ARRIVAL_VALUE

        Dim elements_to_rest As TextBox() = {tb_gt_er, tb_gt_er_25, tb_gt_er_50, tb_gt_k, tb_gt_k_25, tb_gt_k_50, tb_gt_e, tb_gt_e_25, tb_gt_e_50}

        For Each textBox As TextBox In elements_to_rest
            textBox.Text = "0"
        Next

        btn_single.Enabled = False
        btn_group.Enabled = False
        Return 0
    End Function

    Private Sub btn_restart_Click(sender As Object, e As EventArgs) Handles btn_restart.Click
        reset_start_tab()

        Util.select_tab(main_tab_control, START_TAB)
    End Sub

End Class
