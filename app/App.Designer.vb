<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class App
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(App))
        Me.main_tab_control = New System.Windows.Forms.TabControl()
        Me.Reiseziel = New System.Windows.Forms.TabPage()
        Me.btn_group = New System.Windows.Forms.Button()
        Me.btn_single = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.arrival_combo_box = New System.Windows.Forms.ComboBox()
        Me.departure_combo_box = New System.Windows.Forms.ComboBox()
        Me.Einzelticket = New System.Windows.Forms.TabPage()
        Me.btn_single_ticket_proceed = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rb_bc_0 = New System.Windows.Forms.RadioButton()
        Me.rb_bc_25 = New System.Windows.Forms.RadioButton()
        Me.rb_bc_50 = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rb_child = New System.Windows.Forms.RadioButton()
        Me.rb_atault = New System.Windows.Forms.RadioButton()
        Me.rb_ermäßigt = New System.Windows.Forms.RadioButton()
        Me.Gruppenticket = New System.Windows.Forms.TabPage()
        Me.btn_group_ticket_proceed = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tb_gt_e = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tb_gt_k = New System.Windows.Forms.TextBox()
        Me.tb_gt_er = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tb_gt_er_25 = New System.Windows.Forms.TextBox()
        Me.tb_gt_k_25 = New System.Windows.Forms.TextBox()
        Me.tb_gt_e_25 = New System.Windows.Forms.TextBox()
        Me.tb_gt_er_50 = New System.Windows.Forms.TextBox()
        Me.tb_gt_k_50 = New System.Windows.Forms.TextBox()
        Me.tb_gt_e_50 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Zahlung = New System.Windows.Forms.TabPage()
        Me.label_total_amount = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btn_complete_payment = New System.Windows.Forms.Button()
        Me.rb_kreditkarte = New System.Windows.Forms.RadioButton()
        Me.rb_eckarte = New System.Windows.Forms.RadioButton()
        Me.rb_bargeld = New System.Windows.Forms.RadioButton()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.label_entfernung = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.label_start = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.label_ziel = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.label_dauer = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.label_sum_rabatt = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.label_sum_erwachsene = New System.Windows.Forms.Label()
        Me.label_sum_kinder = New System.Windows.Forms.Label()
        Me.label_sum_ermäßigte = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.label_erw_reg_preis = New System.Windows.Forms.Label()
        Me.label_kin_reg_preis = New System.Windows.Forms.Label()
        Me.label_erm_reg_preis = New System.Windows.Forms.Label()
        Me.label_erw_rabatt = New System.Windows.Forms.Label()
        Me.label_kin_rabatt = New System.Windows.Forms.Label()
        Me.label_erm_rabatt = New System.Windows.Forms.Label()
        Me.label_erw_preis = New System.Windows.Forms.Label()
        Me.label_kin_preis = New System.Windows.Forms.Label()
        Me.label_erm_preis = New System.Windows.Forms.Label()
        Me.label_sum_reg_preis = New System.Windows.Forms.Label()
        Me.label_sum_preis = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.label_zahl_gebühr = New System.Windows.Forms.Label()
        Me.label_sum_passagiere = New System.Windows.Forms.Label()
        Me.label_zahl_art = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.btn_restart = New System.Windows.Forms.Button()
        Me.main_tab_control.SuspendLayout()
        Me.Reiseziel.SuspendLayout()
        Me.Einzelticket.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Gruppenticket.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Zahlung.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'main_tab_control
        '
        Me.main_tab_control.Controls.Add(Me.Reiseziel)
        Me.main_tab_control.Controls.Add(Me.Einzelticket)
        Me.main_tab_control.Controls.Add(Me.Gruppenticket)
        Me.main_tab_control.Controls.Add(Me.Zahlung)
        Me.main_tab_control.Controls.Add(Me.TabPage1)
        Me.main_tab_control.Location = New System.Drawing.Point(0, 1)
        Me.main_tab_control.Name = "main_tab_control"
        Me.main_tab_control.SelectedIndex = 0
        Me.main_tab_control.Size = New System.Drawing.Size(419, 219)
        Me.main_tab_control.TabIndex = 0
        Me.main_tab_control.TabStop = False
        '
        'Reiseziel
        '
        Me.Reiseziel.Controls.Add(Me.btn_group)
        Me.Reiseziel.Controls.Add(Me.btn_single)
        Me.Reiseziel.Controls.Add(Me.Label2)
        Me.Reiseziel.Controls.Add(Me.Label1)
        Me.Reiseziel.Controls.Add(Me.arrival_combo_box)
        Me.Reiseziel.Controls.Add(Me.departure_combo_box)
        Me.Reiseziel.Location = New System.Drawing.Point(4, 22)
        Me.Reiseziel.Name = "Reiseziel"
        Me.Reiseziel.Padding = New System.Windows.Forms.Padding(3)
        Me.Reiseziel.Size = New System.Drawing.Size(411, 193)
        Me.Reiseziel.TabIndex = 0
        Me.Reiseziel.Text = "Reiseziel"
        Me.Reiseziel.UseVisualStyleBackColor = True
        '
        'btn_group
        '
        Me.btn_group.Enabled = False
        Me.btn_group.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_group.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_group.Location = New System.Drawing.Point(214, 101)
        Me.btn_group.Name = "btn_group"
        Me.btn_group.Size = New System.Drawing.Size(187, 37)
        Me.btn_group.TabIndex = 6
        Me.btn_group.Text = "Gruppenticket"
        Me.btn_group.UseVisualStyleBackColor = True
        '
        'btn_single
        '
        Me.btn_single.Enabled = False
        Me.btn_single.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_single.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_single.Location = New System.Drawing.Point(6, 101)
        Me.btn_single.Name = "btn_single"
        Me.btn_single.Size = New System.Drawing.Size(187, 37)
        Me.btn_single.TabIndex = 5
        Me.btn_single.Text = "Einzelticket"
        Me.btn_single.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(211, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Ziel:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Start:"
        '
        'arrival_combo_box
        '
        Me.arrival_combo_box.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.arrival_combo_box.FormattingEnabled = True
        Me.arrival_combo_box.Location = New System.Drawing.Point(214, 65)
        Me.arrival_combo_box.Name = "arrival_combo_box"
        Me.arrival_combo_box.Size = New System.Drawing.Size(187, 21)
        Me.arrival_combo_box.Sorted = True
        Me.arrival_combo_box.TabIndex = 2
        Me.arrival_combo_box.Text = "Bitte auswählen"
        '
        'departure_combo_box
        '
        Me.departure_combo_box.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.departure_combo_box.FormattingEnabled = True
        Me.departure_combo_box.Location = New System.Drawing.Point(6, 65)
        Me.departure_combo_box.Name = "departure_combo_box"
        Me.departure_combo_box.Size = New System.Drawing.Size(187, 21)
        Me.departure_combo_box.Sorted = True
        Me.departure_combo_box.TabIndex = 0
        Me.departure_combo_box.Text = "Bitte auswählen"
        '
        'Einzelticket
        '
        Me.Einzelticket.Controls.Add(Me.btn_single_ticket_proceed)
        Me.Einzelticket.Controls.Add(Me.GroupBox2)
        Me.Einzelticket.Controls.Add(Me.GroupBox1)
        Me.Einzelticket.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.Einzelticket.Location = New System.Drawing.Point(4, 22)
        Me.Einzelticket.Name = "Einzelticket"
        Me.Einzelticket.Padding = New System.Windows.Forms.Padding(3)
        Me.Einzelticket.Size = New System.Drawing.Size(411, 193)
        Me.Einzelticket.TabIndex = 1
        Me.Einzelticket.Text = "Einzelticket"
        Me.Einzelticket.UseVisualStyleBackColor = True
        '
        'btn_single_ticket_proceed
        '
        Me.btn_single_ticket_proceed.BackColor = System.Drawing.SystemColors.Control
        Me.btn_single_ticket_proceed.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_single_ticket_proceed.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_single_ticket_proceed.Location = New System.Drawing.Point(6, 147)
        Me.btn_single_ticket_proceed.Name = "btn_single_ticket_proceed"
        Me.btn_single_ticket_proceed.Size = New System.Drawing.Size(399, 40)
        Me.btn_single_ticket_proceed.TabIndex = 10
        Me.btn_single_ticket_proceed.Text = "Weiter zu Zahlungsmethoden"
        Me.btn_single_ticket_proceed.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rb_bc_0)
        Me.GroupBox2.Controls.Add(Me.rb_bc_25)
        Me.GroupBox2.Controls.Add(Me.rb_bc_50)
        Me.GroupBox2.Location = New System.Drawing.Point(218, 26)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(117, 100)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Bahncard"
        '
        'rb_bc_0
        '
        Me.rb_bc_0.AutoSize = True
        Me.rb_bc_0.Checked = True
        Me.rb_bc_0.Location = New System.Drawing.Point(6, 19)
        Me.rb_bc_0.Name = "rb_bc_0"
        Me.rb_bc_0.Size = New System.Drawing.Size(101, 17)
        Me.rb_bc_0.TabIndex = 3
        Me.rb_bc_0.TabStop = True
        Me.rb_bc_0.Text = "Keine Bahncard"
        Me.rb_bc_0.UseVisualStyleBackColor = True
        '
        'rb_bc_25
        '
        Me.rb_bc_25.AutoSize = True
        Me.rb_bc_25.Location = New System.Drawing.Point(6, 42)
        Me.rb_bc_25.Name = "rb_bc_25"
        Me.rb_bc_25.Size = New System.Drawing.Size(86, 17)
        Me.rb_bc_25.TabIndex = 4
        Me.rb_bc_25.Text = "Bahncard 25"
        Me.rb_bc_25.UseVisualStyleBackColor = True
        '
        'rb_bc_50
        '
        Me.rb_bc_50.AutoSize = True
        Me.rb_bc_50.Location = New System.Drawing.Point(6, 65)
        Me.rb_bc_50.Name = "rb_bc_50"
        Me.rb_bc_50.Size = New System.Drawing.Size(86, 17)
        Me.rb_bc_50.TabIndex = 5
        Me.rb_bc_50.Text = "Bahncard 50"
        Me.rb_bc_50.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rb_child)
        Me.GroupBox1.Controls.Add(Me.rb_atault)
        Me.GroupBox1.Controls.Add(Me.rb_ermäßigt)
        Me.GroupBox1.Location = New System.Drawing.Point(91, 26)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(106, 100)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Reisender"
        '
        'rb_child
        '
        Me.rb_child.AutoSize = True
        Me.rb_child.Location = New System.Drawing.Point(6, 42)
        Me.rb_child.Name = "rb_child"
        Me.rb_child.Size = New System.Drawing.Size(46, 17)
        Me.rb_child.TabIndex = 1
        Me.rb_child.Text = "Kind"
        Me.rb_child.UseVisualStyleBackColor = True
        '
        'rb_atault
        '
        Me.rb_atault.AutoSize = True
        Me.rb_atault.Checked = True
        Me.rb_atault.Location = New System.Drawing.Point(6, 19)
        Me.rb_atault.Name = "rb_atault"
        Me.rb_atault.Size = New System.Drawing.Size(87, 17)
        Me.rb_atault.TabIndex = 0
        Me.rb_atault.TabStop = True
        Me.rb_atault.Text = "Erwachsener"
        Me.rb_atault.UseVisualStyleBackColor = True
        '
        'rb_ermäßigt
        '
        Me.rb_ermäßigt.AutoSize = True
        Me.rb_ermäßigt.Location = New System.Drawing.Point(6, 65)
        Me.rb_ermäßigt.Name = "rb_ermäßigt"
        Me.rb_ermäßigt.Size = New System.Drawing.Size(66, 17)
        Me.rb_ermäßigt.TabIndex = 2
        Me.rb_ermäßigt.Text = "Ermäßigt"
        Me.rb_ermäßigt.UseVisualStyleBackColor = True
        '
        'Gruppenticket
        '
        Me.Gruppenticket.Controls.Add(Me.btn_group_ticket_proceed)
        Me.Gruppenticket.Controls.Add(Me.TableLayoutPanel1)
        Me.Gruppenticket.Location = New System.Drawing.Point(4, 22)
        Me.Gruppenticket.Name = "Gruppenticket"
        Me.Gruppenticket.Padding = New System.Windows.Forms.Padding(3)
        Me.Gruppenticket.Size = New System.Drawing.Size(411, 193)
        Me.Gruppenticket.TabIndex = 2
        Me.Gruppenticket.Text = "Gruppenticket"
        Me.Gruppenticket.UseVisualStyleBackColor = True
        '
        'btn_group_ticket_proceed
        '
        Me.btn_group_ticket_proceed.BackColor = System.Drawing.SystemColors.Control
        Me.btn_group_ticket_proceed.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_group_ticket_proceed.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_group_ticket_proceed.Location = New System.Drawing.Point(6, 148)
        Me.btn_group_ticket_proceed.Name = "btn_group_ticket_proceed"
        Me.btn_group_ticket_proceed.Size = New System.Drawing.Size(399, 40)
        Me.btn_group_ticket_proceed.TabIndex = 11
        Me.btn_group_ticket_proceed.Text = "Weiter zu Zahlungsmethoden"
        Me.btn_group_ticket_proceed.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.5!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.5!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 76.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 93.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label7, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.tb_gt_e, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.tb_gt_k, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.tb_gt_er, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.tb_gt_er_25, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.tb_gt_k_25, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.tb_gt_e_25, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.tb_gt_er_50, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.tb_gt_k_50, 3, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.tb_gt_e_50, 3, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label8, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(50, 20)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.13726!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.86274!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(300, 111)
        Me.TableLayoutPanel1.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Ermäßigte"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(209, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Bahncard 50"
        '
        'tb_gt_e
        '
        Me.tb_gt_e.Location = New System.Drawing.Point(67, 83)
        Me.tb_gt_e.Name = "tb_gt_e"
        Me.tb_gt_e.Size = New System.Drawing.Size(60, 20)
        Me.tb_gt_e.TabIndex = 5
        Me.tb_gt_e.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(133, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Bahncard 25"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Kinder"
        '
        'tb_gt_k
        '
        Me.tb_gt_k.Location = New System.Drawing.Point(67, 52)
        Me.tb_gt_k.Name = "tb_gt_k"
        Me.tb_gt_k.Size = New System.Drawing.Size(60, 20)
        Me.tb_gt_k.TabIndex = 4
        Me.tb_gt_k.Text = "0"
        '
        'tb_gt_er
        '
        Me.tb_gt_er.Location = New System.Drawing.Point(67, 24)
        Me.tb_gt_er.Name = "tb_gt_er"
        Me.tb_gt_er.Size = New System.Drawing.Size(60, 20)
        Me.tb_gt_er.TabIndex = 3
        Me.tb_gt_er.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 26)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Erwachene"
        '
        'tb_gt_er_25
        '
        Me.tb_gt_er_25.Location = New System.Drawing.Point(133, 24)
        Me.tb_gt_er_25.Name = "tb_gt_er_25"
        Me.tb_gt_er_25.Size = New System.Drawing.Size(70, 20)
        Me.tb_gt_er_25.TabIndex = 8
        Me.tb_gt_er_25.Text = "0"
        '
        'tb_gt_k_25
        '
        Me.tb_gt_k_25.Location = New System.Drawing.Point(133, 52)
        Me.tb_gt_k_25.Name = "tb_gt_k_25"
        Me.tb_gt_k_25.Size = New System.Drawing.Size(70, 20)
        Me.tb_gt_k_25.TabIndex = 9
        Me.tb_gt_k_25.Text = "0"
        '
        'tb_gt_e_25
        '
        Me.tb_gt_e_25.Location = New System.Drawing.Point(133, 83)
        Me.tb_gt_e_25.Name = "tb_gt_e_25"
        Me.tb_gt_e_25.Size = New System.Drawing.Size(70, 20)
        Me.tb_gt_e_25.TabIndex = 10
        Me.tb_gt_e_25.Text = "0"
        '
        'tb_gt_er_50
        '
        Me.tb_gt_er_50.Location = New System.Drawing.Point(209, 24)
        Me.tb_gt_er_50.Name = "tb_gt_er_50"
        Me.tb_gt_er_50.Size = New System.Drawing.Size(70, 20)
        Me.tb_gt_er_50.TabIndex = 11
        Me.tb_gt_er_50.Text = "0"
        '
        'tb_gt_k_50
        '
        Me.tb_gt_k_50.Location = New System.Drawing.Point(209, 52)
        Me.tb_gt_k_50.Name = "tb_gt_k_50"
        Me.tb_gt_k_50.Size = New System.Drawing.Size(70, 20)
        Me.tb_gt_k_50.TabIndex = 12
        Me.tb_gt_k_50.Text = "0"
        '
        'tb_gt_e_50
        '
        Me.tb_gt_e_50.Location = New System.Drawing.Point(209, 83)
        Me.tb_gt_e_50.Name = "tb_gt_e_50"
        Me.tb_gt_e_50.Size = New System.Drawing.Size(70, 20)
        Me.tb_gt_e_50.TabIndex = 13
        Me.tb_gt_e_50.Text = "0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(67, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Anzahl"
        '
        'Zahlung
        '
        Me.Zahlung.Controls.Add(Me.label_total_amount)
        Me.Zahlung.Controls.Add(Me.Label9)
        Me.Zahlung.Controls.Add(Me.btn_complete_payment)
        Me.Zahlung.Controls.Add(Me.rb_kreditkarte)
        Me.Zahlung.Controls.Add(Me.rb_eckarte)
        Me.Zahlung.Controls.Add(Me.rb_bargeld)
        Me.Zahlung.Location = New System.Drawing.Point(4, 22)
        Me.Zahlung.Name = "Zahlung"
        Me.Zahlung.Padding = New System.Windows.Forms.Padding(3)
        Me.Zahlung.Size = New System.Drawing.Size(411, 193)
        Me.Zahlung.TabIndex = 3
        Me.Zahlung.Text = "Zahlung"
        Me.Zahlung.UseVisualStyleBackColor = True
        '
        'label_total_amount
        '
        Me.label_total_amount.AutoSize = True
        Me.label_total_amount.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_total_amount.Location = New System.Drawing.Point(59, 86)
        Me.label_total_amount.Name = "label_total_amount"
        Me.label_total_amount.Size = New System.Drawing.Size(21, 13)
        Me.label_total_amount.TabIndex = 13
        Me.label_total_amount.Text = "0€"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(8, 86)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 13)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Summe:"
        '
        'btn_complete_payment
        '
        Me.btn_complete_payment.BackColor = System.Drawing.SystemColors.Control
        Me.btn_complete_payment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_complete_payment.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_complete_payment.Location = New System.Drawing.Point(6, 147)
        Me.btn_complete_payment.Name = "btn_complete_payment"
        Me.btn_complete_payment.Size = New System.Drawing.Size(399, 40)
        Me.btn_complete_payment.TabIndex = 11
        Me.btn_complete_payment.Text = "Bezahlen"
        Me.btn_complete_payment.UseVisualStyleBackColor = False
        '
        'rb_kreditkarte
        '
        Me.rb_kreditkarte.AutoSize = True
        Me.rb_kreditkarte.Location = New System.Drawing.Point(8, 52)
        Me.rb_kreditkarte.Name = "rb_kreditkarte"
        Me.rb_kreditkarte.Size = New System.Drawing.Size(108, 17)
        Me.rb_kreditkarte.TabIndex = 2
        Me.rb_kreditkarte.TabStop = True
        Me.rb_kreditkarte.Text = "Kreditkarte (+ 3%)"
        Me.rb_kreditkarte.UseVisualStyleBackColor = True
        '
        'rb_eckarte
        '
        Me.rb_eckarte.AutoSize = True
        Me.rb_eckarte.Location = New System.Drawing.Point(8, 29)
        Me.rb_eckarte.Name = "rb_eckarte"
        Me.rb_eckarte.Size = New System.Drawing.Size(108, 17)
        Me.rb_eckarte.TabIndex = 1
        Me.rb_eckarte.TabStop = True
        Me.rb_eckarte.Text = "EC Karte (+ 0.1%)"
        Me.rb_eckarte.UseVisualStyleBackColor = True
        '
        'rb_bargeld
        '
        Me.rb_bargeld.AutoSize = True
        Me.rb_bargeld.Checked = True
        Me.rb_bargeld.Location = New System.Drawing.Point(8, 6)
        Me.rb_bargeld.Name = "rb_bargeld"
        Me.rb_bargeld.Size = New System.Drawing.Size(96, 17)
        Me.rb_bargeld.TabIndex = 0
        Me.rb_bargeld.TabStop = True
        Me.rb_bargeld.Text = "Bargeld ( + 0%)"
        Me.rb_bargeld.UseVisualStyleBackColor = True
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.TableLayoutPanel3)
        Me.TabPage1.Controls.Add(Me.TableLayoutPanel2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(411, 193)
        Me.TabPage1.TabIndex = 4
        Me.TabPage1.Text = "Beleg"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 4
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 71.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 128.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 44.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 167.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.label_entfernung, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Label21, 2, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Label10, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.label_start, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label11, 2, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.label_ziel, 3, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label12, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.label_dauer, 3, 1)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 6)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.38095!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.61905!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(410, 42)
        Me.TableLayoutPanel3.TabIndex = 1
        '
        'label_entfernung
        '
        Me.label_entfernung.AutoSize = True
        Me.label_entfernung.Location = New System.Drawing.Point(74, 22)
        Me.label_entfernung.Name = "label_entfernung"
        Me.label_entfernung.Size = New System.Drawing.Size(30, 13)
        Me.label_entfernung.TabIndex = 19
        Me.label_entfernung.Text = "0 km"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(202, 22)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(36, 13)
        Me.Label21.TabIndex = 18
        Me.Label21.Text = "Dauer"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(3, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(29, 13)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Von"
        '
        'label_start
        '
        Me.label_start.AutoSize = True
        Me.label_start.Location = New System.Drawing.Point(74, 0)
        Me.label_start.Name = "label_start"
        Me.label_start.Size = New System.Drawing.Size(27, 13)
        Me.label_start.TabIndex = 16
        Me.label_start.Text = "start"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(202, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(37, 13)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Nach"
        '
        'label_ziel
        '
        Me.label_ziel.AutoSize = True
        Me.label_ziel.Location = New System.Drawing.Point(246, 0)
        Me.label_ziel.Name = "label_ziel"
        Me.label_ziel.Size = New System.Drawing.Size(22, 13)
        Me.label_ziel.TabIndex = 17
        Me.label_ziel.Text = "ziel"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(3, 22)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(59, 13)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "Entfernung"
        '
        'label_dauer
        '
        Me.label_dauer.AutoSize = True
        Me.label_dauer.Location = New System.Drawing.Point(246, 22)
        Me.label_dauer.Name = "label_dauer"
        Me.label_dauer.Size = New System.Drawing.Size(22, 13)
        Me.label_dauer.TabIndex = 15
        Me.label_dauer.Text = "0 h"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 5
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 73.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 52.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 89.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 132.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.label_sum_rabatt, 3, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.Label13, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label14, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Label15, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.label_sum_erwachsene, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.label_sum_kinder, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.label_sum_ermäßigte, 1, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.Label16, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label20, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label19, 0, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.Label18, 3, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label17, 4, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.label_erw_reg_preis, 2, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.label_kin_reg_preis, 2, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.label_erm_reg_preis, 2, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.label_erw_rabatt, 3, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.label_kin_rabatt, 3, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.label_erm_rabatt, 3, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.label_erw_preis, 4, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.label_kin_preis, 4, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.label_erm_preis, 4, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.label_sum_reg_preis, 2, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.label_sum_preis, 4, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.Label24, 3, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.label_zahl_gebühr, 4, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.label_sum_passagiere, 1, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.label_zahl_art, 1, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.Label22, 0, 5)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 54)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 6
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(411, 137)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'label_sum_rabatt
        '
        Me.label_sum_rabatt.AutoSize = True
        Me.label_sum_rabatt.Location = New System.Drawing.Point(217, 75)
        Me.label_sum_rabatt.Name = "label_sum_rabatt"
        Me.label_sum_rabatt.Size = New System.Drawing.Size(13, 13)
        Me.label_sum_rabatt.TabIndex = 27
        Me.label_sum_rabatt.Text = "0"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(3, 17)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(66, 13)
        Me.Label13.TabIndex = 3
        Me.Label13.Text = "Erwachsene"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(3, 37)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(37, 13)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "Kinder"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(3, 56)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(54, 13)
        Me.Label15.TabIndex = 5
        Me.Label15.Text = "Ermäßigte"
        '
        'label_sum_erwachsene
        '
        Me.label_sum_erwachsene.AutoSize = True
        Me.label_sum_erwachsene.Location = New System.Drawing.Point(76, 17)
        Me.label_sum_erwachsene.Name = "label_sum_erwachsene"
        Me.label_sum_erwachsene.Size = New System.Drawing.Size(13, 13)
        Me.label_sum_erwachsene.TabIndex = 7
        Me.label_sum_erwachsene.Text = "0"
        '
        'label_sum_kinder
        '
        Me.label_sum_kinder.AutoSize = True
        Me.label_sum_kinder.Location = New System.Drawing.Point(76, 37)
        Me.label_sum_kinder.Name = "label_sum_kinder"
        Me.label_sum_kinder.Size = New System.Drawing.Size(13, 13)
        Me.label_sum_kinder.TabIndex = 8
        Me.label_sum_kinder.Text = "0"
        '
        'label_sum_ermäßigte
        '
        Me.label_sum_ermäßigte.AutoSize = True
        Me.label_sum_ermäßigte.Location = New System.Drawing.Point(76, 56)
        Me.label_sum_ermäßigte.Name = "label_sum_ermäßigte"
        Me.label_sum_ermäßigte.Size = New System.Drawing.Size(13, 13)
        Me.label_sum_ermäßigte.TabIndex = 9
        Me.label_sum_ermäßigte.Text = "0"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(76, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(45, 13)
        Me.Label16.TabIndex = 10
        Me.Label16.Text = "Anzahl"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(128, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(78, 13)
        Me.Label20.TabIndex = 14
        Me.Label20.Text = "Regulärpreis"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(3, 75)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(47, 13)
        Me.Label19.TabIndex = 13
        Me.Label19.Text = "Summe"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(217, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(52, 13)
        Me.Label18.TabIndex = 12
        Me.Label18.Text = "Rabatte"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(282, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(59, 13)
        Me.Label17.TabIndex = 15
        Me.Label17.Text = "Fahrpreis"
        '
        'label_erw_reg_preis
        '
        Me.label_erw_reg_preis.AutoSize = True
        Me.label_erw_reg_preis.Location = New System.Drawing.Point(128, 17)
        Me.label_erw_reg_preis.Name = "label_erw_reg_preis"
        Me.label_erw_reg_preis.Size = New System.Drawing.Size(13, 13)
        Me.label_erw_reg_preis.TabIndex = 16
        Me.label_erw_reg_preis.Text = "0"
        '
        'label_kin_reg_preis
        '
        Me.label_kin_reg_preis.AutoSize = True
        Me.label_kin_reg_preis.Location = New System.Drawing.Point(128, 37)
        Me.label_kin_reg_preis.Name = "label_kin_reg_preis"
        Me.label_kin_reg_preis.Size = New System.Drawing.Size(13, 13)
        Me.label_kin_reg_preis.TabIndex = 17
        Me.label_kin_reg_preis.Text = "0"
        '
        'label_erm_reg_preis
        '
        Me.label_erm_reg_preis.AutoSize = True
        Me.label_erm_reg_preis.Location = New System.Drawing.Point(128, 56)
        Me.label_erm_reg_preis.Name = "label_erm_reg_preis"
        Me.label_erm_reg_preis.Size = New System.Drawing.Size(13, 13)
        Me.label_erm_reg_preis.TabIndex = 18
        Me.label_erm_reg_preis.Text = "0"
        '
        'label_erw_rabatt
        '
        Me.label_erw_rabatt.AutoSize = True
        Me.label_erw_rabatt.Location = New System.Drawing.Point(217, 17)
        Me.label_erw_rabatt.Name = "label_erw_rabatt"
        Me.label_erw_rabatt.Size = New System.Drawing.Size(13, 13)
        Me.label_erw_rabatt.TabIndex = 19
        Me.label_erw_rabatt.Text = "0"
        '
        'label_kin_rabatt
        '
        Me.label_kin_rabatt.AutoSize = True
        Me.label_kin_rabatt.Location = New System.Drawing.Point(217, 37)
        Me.label_kin_rabatt.Name = "label_kin_rabatt"
        Me.label_kin_rabatt.Size = New System.Drawing.Size(13, 13)
        Me.label_kin_rabatt.TabIndex = 20
        Me.label_kin_rabatt.Text = "0"
        '
        'label_erm_rabatt
        '
        Me.label_erm_rabatt.AutoSize = True
        Me.label_erm_rabatt.Location = New System.Drawing.Point(217, 56)
        Me.label_erm_rabatt.Name = "label_erm_rabatt"
        Me.label_erm_rabatt.Size = New System.Drawing.Size(13, 13)
        Me.label_erm_rabatt.TabIndex = 21
        Me.label_erm_rabatt.Text = "0"
        '
        'label_erw_preis
        '
        Me.label_erw_preis.AutoSize = True
        Me.label_erw_preis.Location = New System.Drawing.Point(282, 17)
        Me.label_erw_preis.Name = "label_erw_preis"
        Me.label_erw_preis.Size = New System.Drawing.Size(13, 13)
        Me.label_erw_preis.TabIndex = 22
        Me.label_erw_preis.Text = "0"
        '
        'label_kin_preis
        '
        Me.label_kin_preis.AutoSize = True
        Me.label_kin_preis.Location = New System.Drawing.Point(282, 37)
        Me.label_kin_preis.Name = "label_kin_preis"
        Me.label_kin_preis.Size = New System.Drawing.Size(13, 13)
        Me.label_kin_preis.TabIndex = 23
        Me.label_kin_preis.Text = "0"
        '
        'label_erm_preis
        '
        Me.label_erm_preis.AutoSize = True
        Me.label_erm_preis.Location = New System.Drawing.Point(282, 56)
        Me.label_erm_preis.Name = "label_erm_preis"
        Me.label_erm_preis.Size = New System.Drawing.Size(13, 13)
        Me.label_erm_preis.TabIndex = 24
        Me.label_erm_preis.Text = "0"
        '
        'label_sum_reg_preis
        '
        Me.label_sum_reg_preis.AutoSize = True
        Me.label_sum_reg_preis.Location = New System.Drawing.Point(128, 75)
        Me.label_sum_reg_preis.Name = "label_sum_reg_preis"
        Me.label_sum_reg_preis.Size = New System.Drawing.Size(13, 13)
        Me.label_sum_reg_preis.TabIndex = 25
        Me.label_sum_reg_preis.Text = "0"
        '
        'label_sum_preis
        '
        Me.label_sum_preis.AutoSize = True
        Me.label_sum_preis.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_sum_preis.Location = New System.Drawing.Point(282, 75)
        Me.label_sum_preis.Name = "label_sum_preis"
        Me.label_sum_preis.Size = New System.Drawing.Size(14, 13)
        Me.label_sum_preis.TabIndex = 26
        Me.label_sum_preis.Text = "0"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(217, 109)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(42, 13)
        Me.Label24.TabIndex = 31
        Me.Label24.Text = "Gebühr"
        '
        'label_zahl_gebühr
        '
        Me.label_zahl_gebühr.AutoSize = True
        Me.label_zahl_gebühr.Location = New System.Drawing.Point(282, 109)
        Me.label_zahl_gebühr.Name = "label_zahl_gebühr"
        Me.label_zahl_gebühr.Size = New System.Drawing.Size(22, 13)
        Me.label_zahl_gebühr.TabIndex = 32
        Me.label_zahl_gebühr.Text = "0 €"
        '
        'label_sum_passagiere
        '
        Me.label_sum_passagiere.AutoSize = True
        Me.label_sum_passagiere.Location = New System.Drawing.Point(76, 75)
        Me.label_sum_passagiere.Name = "label_sum_passagiere"
        Me.label_sum_passagiere.Size = New System.Drawing.Size(13, 13)
        Me.label_sum_passagiere.TabIndex = 28
        Me.label_sum_passagiere.Text = "0"
        '
        'label_zahl_art
        '
        Me.label_zahl_art.AutoSize = True
        Me.label_zahl_art.Location = New System.Drawing.Point(76, 109)
        Me.label_zahl_art.Name = "label_zahl_art"
        Me.label_zahl_art.Size = New System.Drawing.Size(23, 13)
        Me.label_zahl_art.TabIndex = 30
        Me.label_zahl_art.Text = "Bar"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(3, 109)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(40, 13)
        Me.Label22.TabIndex = 29
        Me.Label22.Text = "Zahlart"
        '
        'btn_restart
        '
        Me.btn_restart.BackColor = System.Drawing.Color.Cornsilk
        Me.btn_restart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_restart.Location = New System.Drawing.Point(3, 220)
        Me.btn_restart.Name = "btn_restart"
        Me.btn_restart.Size = New System.Drawing.Size(411, 37)
        Me.btn_restart.TabIndex = 1
        Me.btn_restart.Text = "Neues Ticket"
        Me.btn_restart.UseVisualStyleBackColor = False
        '
        'App
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(417, 261)
        Me.Controls.Add(Me.btn_restart)
        Me.Controls.Add(Me.main_tab_control)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(433, 300)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(433, 300)
        Me.Name = "App"
        Me.Text = "Fahrkartenautomat"
        Me.main_tab_control.ResumeLayout(False)
        Me.Reiseziel.ResumeLayout(False)
        Me.Reiseziel.PerformLayout()
        Me.Einzelticket.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Gruppenticket.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.Zahlung.ResumeLayout(False)
        Me.Zahlung.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents main_tab_control As TabControl
    Friend WithEvents Reiseziel As TabPage
    Friend WithEvents Einzelticket As TabPage
    Friend WithEvents Zahlung As TabPage
    Friend WithEvents Gruppenticket As TabPage
    Friend WithEvents departure_combo_box As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents arrival_combo_box As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_group As Button
    Friend WithEvents btn_single As Button
    Friend WithEvents rb_ermäßigt As RadioButton
    Friend WithEvents rb_child As RadioButton
    Friend WithEvents rb_atault As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rb_bc_0 As RadioButton
    Friend WithEvents rb_bc_25 As RadioButton
    Friend WithEvents rb_bc_50 As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents tb_gt_er As TextBox
    Friend WithEvents tb_gt_e As TextBox
    Friend WithEvents tb_gt_k As TextBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents tb_gt_er_25 As TextBox
    Friend WithEvents tb_gt_k_25 As TextBox
    Friend WithEvents tb_gt_e_25 As TextBox
    Friend WithEvents tb_gt_er_50 As TextBox
    Friend WithEvents tb_gt_k_50 As TextBox
    Friend WithEvents tb_gt_e_50 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btn_single_ticket_proceed As Button
    Friend WithEvents btn_group_ticket_proceed As Button
    Friend WithEvents rb_kreditkarte As RadioButton
    Friend WithEvents rb_eckarte As RadioButton
    Friend WithEvents rb_bargeld As RadioButton
    Friend WithEvents btn_complete_payment As Button
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents label_total_amount As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents label_sum_erwachsene As Label
    Friend WithEvents label_sum_kinder As Label
    Friend WithEvents label_sum_ermäßigte As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents label_dauer As Label
    Friend WithEvents label_start As Label
    Friend WithEvents label_ziel As Label
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Label21 As Label
    Friend WithEvents label_sum_passagiere As Label
    Friend WithEvents label_sum_rabatt As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents label_erw_reg_preis As Label
    Friend WithEvents label_kin_reg_preis As Label
    Friend WithEvents label_erm_reg_preis As Label
    Friend WithEvents label_erw_rabatt As Label
    Friend WithEvents label_kin_rabatt As Label
    Friend WithEvents label_erm_rabatt As Label
    Friend WithEvents label_erw_preis As Label
    Friend WithEvents label_kin_preis As Label
    Friend WithEvents label_erm_preis As Label
    Friend WithEvents label_sum_reg_preis As Label
    Friend WithEvents label_sum_preis As Label
    Friend WithEvents label_entfernung As Label
    Friend WithEvents label_zahl_art As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents label_zahl_gebühr As Label
    Friend WithEvents btn_restart As Button
End Class
