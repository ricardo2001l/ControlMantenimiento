<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class informe
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(informe))
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tabCtrlInforme = New System.Windows.Forms.TabControl()
        Me.tabUltMant = New System.Windows.Forms.TabPage()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.radioTipoMantUlt = New System.Windows.Forms.Panel()
        Me.radioAmbosUlt = New System.Windows.Forms.RadioButton()
        Me.radioPreventivoUlt = New System.Windows.Forms.RadioButton()
        Me.radioCorrectivoUlt = New System.Windows.Forms.RadioButton()
        Me.radioEquipoUlt = New System.Windows.Forms.Panel()
        Me.radioModeloUlt = New System.Windows.Forms.RadioButton()
        Me.radioMarcaUlt = New System.Windows.Forms.RadioButton()
        Me.radioTodosUlt = New System.Windows.Forms.RadioButton()
        Me.radioCodigoUlt = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbModeloUlt = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbMarcaUlt = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbCodEquipoUlt = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnRealizarUlt = New System.Windows.Forms.Button()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.tabFechas = New System.Windows.Forms.TabPage()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.btnRealizarFechas = New System.Windows.Forms.Button()
        Me.fechaFinal = New System.Windows.Forms.DateTimePicker()
        Me.fechaInicial = New System.Windows.Forms.DateTimePicker()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.radioTipoMantFechas = New System.Windows.Forms.Panel()
        Me.radioAmbosFechas = New System.Windows.Forms.RadioButton()
        Me.radioPreventivoFechas = New System.Windows.Forms.RadioButton()
        Me.radioCorrectivoFechas = New System.Windows.Forms.RadioButton()
        Me.radioEquipoFechas = New System.Windows.Forms.Panel()
        Me.radioModeloFechas = New System.Windows.Forms.RadioButton()
        Me.radioMarcaFechas = New System.Windows.Forms.RadioButton()
        Me.radioTodosFechas = New System.Windows.Forms.RadioButton()
        Me.radioCodigoFechas = New System.Windows.Forms.RadioButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbModeloFechas = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmbMarcaFechas = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmbCodEquipoFechas = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.tabCtrlInforme.SuspendLayout()
        Me.tabUltMant.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.radioTipoMantUlt.SuspendLayout()
        Me.radioEquipoUlt.SuspendLayout()
        Me.tabFechas.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.radioTipoMantFechas.SuspendLayout()
        Me.radioEquipoFechas.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Old English Text MT", 14.25!)
        Me.Label13.Location = New System.Drawing.Point(196, 86)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(79, 23)
        Me.Label13.TabIndex = 24
        Me.Label13.Text = "Informes"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Old English Text MT", 12.75!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(116, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(237, 21)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "U. E. ""Miguel Otero Silva"""
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Old English Text MT", 21.75!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(68, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(343, 34)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Control de Mantenimiento"
        '
        'tabCtrlInforme
        '
        Me.tabCtrlInforme.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabCtrlInforme.Controls.Add(Me.tabUltMant)
        Me.tabCtrlInforme.Controls.Add(Me.tabFechas)
        Me.tabCtrlInforme.Location = New System.Drawing.Point(0, 120)
        Me.tabCtrlInforme.MinimumSize = New System.Drawing.Size(486, 385)
        Me.tabCtrlInforme.Name = "tabCtrlInforme"
        Me.tabCtrlInforme.SelectedIndex = 0
        Me.tabCtrlInforme.Size = New System.Drawing.Size(486, 385)
        Me.tabCtrlInforme.TabIndex = 25
        '
        'tabUltMant
        '
        Me.tabUltMant.BackColor = System.Drawing.Color.Lavender
        Me.tabUltMant.Controls.Add(Me.Panel5)
        Me.tabUltMant.Location = New System.Drawing.Point(4, 27)
        Me.tabUltMant.Name = "tabUltMant"
        Me.tabUltMant.Padding = New System.Windows.Forms.Padding(3)
        Me.tabUltMant.Size = New System.Drawing.Size(478, 354)
        Me.tabUltMant.TabIndex = 0
        Me.tabUltMant.Text = "Ultimo mantenimiento"
        '
        'Panel5
        '
        Me.Panel5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel5.Controls.Add(Me.radioTipoMantUlt)
        Me.Panel5.Controls.Add(Me.radioEquipoUlt)
        Me.Panel5.Controls.Add(Me.Label6)
        Me.Panel5.Controls.Add(Me.cmbModeloUlt)
        Me.Panel5.Controls.Add(Me.Label5)
        Me.Panel5.Controls.Add(Me.cmbMarcaUlt)
        Me.Panel5.Controls.Add(Me.Label2)
        Me.Panel5.Controls.Add(Me.cmbCodEquipoUlt)
        Me.Panel5.Controls.Add(Me.Label1)
        Me.Panel5.Controls.Add(Me.btnRealizarUlt)
        Me.Panel5.Controls.Add(Me.Label34)
        Me.Panel5.Location = New System.Drawing.Point(3, 3)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(472, 353)
        Me.Panel5.TabIndex = 44
        '
        'radioTipoMantUlt
        '
        Me.radioTipoMantUlt.Controls.Add(Me.radioAmbosUlt)
        Me.radioTipoMantUlt.Controls.Add(Me.radioPreventivoUlt)
        Me.radioTipoMantUlt.Controls.Add(Me.radioCorrectivoUlt)
        Me.radioTipoMantUlt.Location = New System.Drawing.Point(30, 43)
        Me.radioTipoMantUlt.Name = "radioTipoMantUlt"
        Me.radioTipoMantUlt.Size = New System.Drawing.Size(336, 31)
        Me.radioTipoMantUlt.TabIndex = 43
        '
        'radioAmbosUlt
        '
        Me.radioAmbosUlt.AutoSize = True
        Me.radioAmbosUlt.Checked = True
        Me.radioAmbosUlt.Location = New System.Drawing.Point(248, 8)
        Me.radioAmbosUlt.Name = "radioAmbosUlt"
        Me.radioAmbosUlt.Size = New System.Drawing.Size(69, 22)
        Me.radioAmbosUlt.TabIndex = 30
        Me.radioAmbosUlt.TabStop = True
        Me.radioAmbosUlt.Text = "Ambos"
        Me.radioAmbosUlt.UseVisualStyleBackColor = True
        '
        'radioPreventivoUlt
        '
        Me.radioPreventivoUlt.AutoSize = True
        Me.radioPreventivoUlt.Location = New System.Drawing.Point(15, 8)
        Me.radioPreventivoUlt.Name = "radioPreventivoUlt"
        Me.radioPreventivoUlt.Size = New System.Drawing.Size(96, 22)
        Me.radioPreventivoUlt.TabIndex = 28
        Me.radioPreventivoUlt.Text = "Preventivo"
        Me.radioPreventivoUlt.UseVisualStyleBackColor = True
        '
        'radioCorrectivoUlt
        '
        Me.radioCorrectivoUlt.AutoSize = True
        Me.radioCorrectivoUlt.Location = New System.Drawing.Point(130, 8)
        Me.radioCorrectivoUlt.Name = "radioCorrectivoUlt"
        Me.radioCorrectivoUlt.Size = New System.Drawing.Size(94, 22)
        Me.radioCorrectivoUlt.TabIndex = 29
        Me.radioCorrectivoUlt.Text = "Correctivo"
        Me.radioCorrectivoUlt.UseVisualStyleBackColor = True
        '
        'radioEquipoUlt
        '
        Me.radioEquipoUlt.Controls.Add(Me.radioModeloUlt)
        Me.radioEquipoUlt.Controls.Add(Me.radioMarcaUlt)
        Me.radioEquipoUlt.Controls.Add(Me.radioTodosUlt)
        Me.radioEquipoUlt.Controls.Add(Me.radioCodigoUlt)
        Me.radioEquipoUlt.Location = New System.Drawing.Point(30, 110)
        Me.radioEquipoUlt.Name = "radioEquipoUlt"
        Me.radioEquipoUlt.Size = New System.Drawing.Size(423, 34)
        Me.radioEquipoUlt.TabIndex = 42
        '
        'radioModeloUlt
        '
        Me.radioModeloUlt.AutoSize = True
        Me.radioModeloUlt.Location = New System.Drawing.Point(315, 7)
        Me.radioModeloUlt.Name = "radioModeloUlt"
        Me.radioModeloUlt.Size = New System.Drawing.Size(97, 22)
        Me.radioModeloUlt.TabIndex = 35
        Me.radioModeloUlt.Text = "Por modelo"
        Me.radioModeloUlt.UseVisualStyleBackColor = True
        '
        'radioMarcaUlt
        '
        Me.radioMarcaUlt.AutoSize = True
        Me.radioMarcaUlt.Location = New System.Drawing.Point(209, 7)
        Me.radioMarcaUlt.Name = "radioMarcaUlt"
        Me.radioMarcaUlt.Size = New System.Drawing.Size(93, 22)
        Me.radioMarcaUlt.TabIndex = 34
        Me.radioMarcaUlt.Text = "Por marca"
        Me.radioMarcaUlt.UseVisualStyleBackColor = True
        '
        'radioTodosUlt
        '
        Me.radioTodosUlt.AutoSize = True
        Me.radioTodosUlt.Checked = True
        Me.radioTodosUlt.Location = New System.Drawing.Point(15, 7)
        Me.radioTodosUlt.Name = "radioTodosUlt"
        Me.radioTodosUlt.Size = New System.Drawing.Size(63, 22)
        Me.radioTodosUlt.TabIndex = 32
        Me.radioTodosUlt.TabStop = True
        Me.radioTodosUlt.Text = "Todos"
        Me.radioTodosUlt.UseVisualStyleBackColor = True
        '
        'radioCodigoUlt
        '
        Me.radioCodigoUlt.AutoSize = True
        Me.radioCodigoUlt.Location = New System.Drawing.Point(98, 7)
        Me.radioCodigoUlt.Name = "radioCodigoUlt"
        Me.radioCodigoUlt.Size = New System.Drawing.Size(91, 22)
        Me.radioCodigoUlt.TabIndex = 33
        Me.radioCodigoUlt.Text = "Por código"
        Me.radioCodigoUlt.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(27, 239)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(123, 18)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "Modelo del equipo"
        '
        'cmbModeloUlt
        '
        Me.cmbModeloUlt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbModeloUlt.Enabled = False
        Me.cmbModeloUlt.FormattingEnabled = True
        Me.cmbModeloUlt.Location = New System.Drawing.Point(160, 236)
        Me.cmbModeloUlt.Name = "cmbModeloUlt"
        Me.cmbModeloUlt.Size = New System.Drawing.Size(282, 26)
        Me.cmbModeloUlt.TabIndex = 40
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(27, 200)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 18)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "Marca del equipo"
        '
        'cmbMarcaUlt
        '
        Me.cmbMarcaUlt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMarcaUlt.Enabled = False
        Me.cmbMarcaUlt.FormattingEnabled = True
        Me.cmbMarcaUlt.Location = New System.Drawing.Point(160, 197)
        Me.cmbMarcaUlt.Name = "cmbMarcaUlt"
        Me.cmbMarcaUlt.Size = New System.Drawing.Size(282, 26)
        Me.cmbMarcaUlt.TabIndex = 38
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 165)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 18)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Código del equipo"
        '
        'cmbCodEquipoUlt
        '
        Me.cmbCodEquipoUlt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCodEquipoUlt.Enabled = False
        Me.cmbCodEquipoUlt.FormattingEnabled = True
        Me.cmbCodEquipoUlt.Location = New System.Drawing.Point(160, 162)
        Me.cmbCodEquipoUlt.Name = "cmbCodEquipoUlt"
        Me.cmbCodEquipoUlt.Size = New System.Drawing.Size(282, 26)
        Me.cmbCodEquipoUlt.TabIndex = 36
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 18)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Selección de equipos"
        '
        'btnRealizarUlt
        '
        Me.btnRealizarUlt.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnRealizarUlt.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnRealizarUlt.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRealizarUlt.Font = New System.Drawing.Font("Bookman Old Style", 12.0!)
        Me.btnRealizarUlt.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnRealizarUlt.Location = New System.Drawing.Point(342, 306)
        Me.btnRealizarUlt.Name = "btnRealizarUlt"
        Me.btnRealizarUlt.Size = New System.Drawing.Size(98, 31)
        Me.btnRealizarUlt.TabIndex = 0
        Me.btnRealizarUlt.Text = "Realizar"
        Me.btnRealizarUlt.UseVisualStyleBackColor = False
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(19, 17)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(163, 18)
        Me.Label34.TabIndex = 27
        Me.Label34.Text = "Tipo de mantenimiento"
        '
        'tabFechas
        '
        Me.tabFechas.AutoScroll = True
        Me.tabFechas.AutoScrollMargin = New System.Drawing.Size(0, 15)
        Me.tabFechas.BackColor = System.Drawing.Color.Lavender
        Me.tabFechas.Controls.Add(Me.Panel6)
        Me.tabFechas.Location = New System.Drawing.Point(4, 27)
        Me.tabFechas.Name = "tabFechas"
        Me.tabFechas.Padding = New System.Windows.Forms.Padding(3)
        Me.tabFechas.Size = New System.Drawing.Size(478, 354)
        Me.tabFechas.TabIndex = 1
        Me.tabFechas.Text = "Fechas"
        '
        'Panel6
        '
        Me.Panel6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel6.Controls.Add(Me.btnRealizarFechas)
        Me.Panel6.Controls.Add(Me.fechaFinal)
        Me.Panel6.Controls.Add(Me.fechaInicial)
        Me.Panel6.Controls.Add(Me.Label14)
        Me.Panel6.Controls.Add(Me.Label12)
        Me.Panel6.Controls.Add(Me.radioTipoMantFechas)
        Me.Panel6.Controls.Add(Me.radioEquipoFechas)
        Me.Panel6.Controls.Add(Me.Label7)
        Me.Panel6.Controls.Add(Me.cmbModeloFechas)
        Me.Panel6.Controls.Add(Me.Label8)
        Me.Panel6.Controls.Add(Me.cmbMarcaFechas)
        Me.Panel6.Controls.Add(Me.Label9)
        Me.Panel6.Controls.Add(Me.cmbCodEquipoFechas)
        Me.Panel6.Controls.Add(Me.Label10)
        Me.Panel6.Controls.Add(Me.Label11)
        Me.Panel6.Location = New System.Drawing.Point(-6, 3)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(455, 437)
        Me.Panel6.TabIndex = 59
        '
        'btnRealizarFechas
        '
        Me.btnRealizarFechas.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnRealizarFechas.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnRealizarFechas.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRealizarFechas.Font = New System.Drawing.Font("Bookman Old Style", 12.0!)
        Me.btnRealizarFechas.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnRealizarFechas.Location = New System.Drawing.Point(339, 394)
        Me.btnRealizarFechas.Name = "btnRealizarFechas"
        Me.btnRealizarFechas.Size = New System.Drawing.Size(98, 31)
        Me.btnRealizarFechas.TabIndex = 44
        Me.btnRealizarFechas.Text = "Realizar"
        Me.btnRealizarFechas.UseVisualStyleBackColor = False
        '
        'fechaFinal
        '
        Me.fechaFinal.Location = New System.Drawing.Point(158, 68)
        Me.fechaFinal.Name = "fechaFinal"
        Me.fechaFinal.Size = New System.Drawing.Size(282, 23)
        Me.fechaFinal.TabIndex = 58
        '
        'fechaInicial
        '
        Me.fechaInicial.Location = New System.Drawing.Point(157, 23)
        Me.fechaInicial.Name = "fechaInicial"
        Me.fechaInicial.Size = New System.Drawing.Size(283, 23)
        Me.fechaInicial.TabIndex = 57
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(17, 68)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(82, 18)
        Me.Label14.TabIndex = 56
        Me.Label14.Text = "Fecha final"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(17, 27)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(95, 18)
        Me.Label12.TabIndex = 55
        Me.Label12.Text = "Fecha inicial"
        '
        'radioTipoMantFechas
        '
        Me.radioTipoMantFechas.Controls.Add(Me.radioAmbosFechas)
        Me.radioTipoMantFechas.Controls.Add(Me.radioPreventivoFechas)
        Me.radioTipoMantFechas.Controls.Add(Me.radioCorrectivoFechas)
        Me.radioTipoMantFechas.Location = New System.Drawing.Point(28, 136)
        Me.radioTipoMantFechas.Name = "radioTipoMantFechas"
        Me.radioTipoMantFechas.Size = New System.Drawing.Size(336, 31)
        Me.radioTipoMantFechas.TabIndex = 54
        '
        'radioAmbosFechas
        '
        Me.radioAmbosFechas.AutoSize = True
        Me.radioAmbosFechas.Checked = True
        Me.radioAmbosFechas.Location = New System.Drawing.Point(248, 8)
        Me.radioAmbosFechas.Name = "radioAmbosFechas"
        Me.radioAmbosFechas.Size = New System.Drawing.Size(69, 22)
        Me.radioAmbosFechas.TabIndex = 30
        Me.radioAmbosFechas.TabStop = True
        Me.radioAmbosFechas.Text = "Ambos"
        Me.radioAmbosFechas.UseVisualStyleBackColor = True
        '
        'radioPreventivoFechas
        '
        Me.radioPreventivoFechas.AutoSize = True
        Me.radioPreventivoFechas.Location = New System.Drawing.Point(15, 8)
        Me.radioPreventivoFechas.Name = "radioPreventivoFechas"
        Me.radioPreventivoFechas.Size = New System.Drawing.Size(96, 22)
        Me.radioPreventivoFechas.TabIndex = 28
        Me.radioPreventivoFechas.Text = "Preventivo"
        Me.radioPreventivoFechas.UseVisualStyleBackColor = True
        '
        'radioCorrectivoFechas
        '
        Me.radioCorrectivoFechas.AutoSize = True
        Me.radioCorrectivoFechas.Location = New System.Drawing.Point(130, 8)
        Me.radioCorrectivoFechas.Name = "radioCorrectivoFechas"
        Me.radioCorrectivoFechas.Size = New System.Drawing.Size(94, 22)
        Me.radioCorrectivoFechas.TabIndex = 29
        Me.radioCorrectivoFechas.Text = "Correctivo"
        Me.radioCorrectivoFechas.UseVisualStyleBackColor = True
        '
        'radioEquipoFechas
        '
        Me.radioEquipoFechas.Controls.Add(Me.radioModeloFechas)
        Me.radioEquipoFechas.Controls.Add(Me.radioMarcaFechas)
        Me.radioEquipoFechas.Controls.Add(Me.radioTodosFechas)
        Me.radioEquipoFechas.Controls.Add(Me.radioCodigoFechas)
        Me.radioEquipoFechas.Location = New System.Drawing.Point(28, 203)
        Me.radioEquipoFechas.Name = "radioEquipoFechas"
        Me.radioEquipoFechas.Size = New System.Drawing.Size(423, 34)
        Me.radioEquipoFechas.TabIndex = 53
        '
        'radioModeloFechas
        '
        Me.radioModeloFechas.AutoSize = True
        Me.radioModeloFechas.Location = New System.Drawing.Point(315, 7)
        Me.radioModeloFechas.Name = "radioModeloFechas"
        Me.radioModeloFechas.Size = New System.Drawing.Size(97, 22)
        Me.radioModeloFechas.TabIndex = 35
        Me.radioModeloFechas.Text = "Por modelo"
        Me.radioModeloFechas.UseVisualStyleBackColor = True
        '
        'radioMarcaFechas
        '
        Me.radioMarcaFechas.AutoSize = True
        Me.radioMarcaFechas.Location = New System.Drawing.Point(209, 7)
        Me.radioMarcaFechas.Name = "radioMarcaFechas"
        Me.radioMarcaFechas.Size = New System.Drawing.Size(93, 22)
        Me.radioMarcaFechas.TabIndex = 34
        Me.radioMarcaFechas.Text = "Por marca"
        Me.radioMarcaFechas.UseVisualStyleBackColor = True
        '
        'radioTodosFechas
        '
        Me.radioTodosFechas.AutoSize = True
        Me.radioTodosFechas.Checked = True
        Me.radioTodosFechas.Location = New System.Drawing.Point(15, 7)
        Me.radioTodosFechas.Name = "radioTodosFechas"
        Me.radioTodosFechas.Size = New System.Drawing.Size(63, 22)
        Me.radioTodosFechas.TabIndex = 32
        Me.radioTodosFechas.TabStop = True
        Me.radioTodosFechas.Text = "Todos"
        Me.radioTodosFechas.UseVisualStyleBackColor = True
        '
        'radioCodigoFechas
        '
        Me.radioCodigoFechas.AutoSize = True
        Me.radioCodigoFechas.Location = New System.Drawing.Point(98, 7)
        Me.radioCodigoFechas.Name = "radioCodigoFechas"
        Me.radioCodigoFechas.Size = New System.Drawing.Size(91, 22)
        Me.radioCodigoFechas.TabIndex = 33
        Me.radioCodigoFechas.Text = "Por código"
        Me.radioCodigoFechas.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(25, 332)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(123, 18)
        Me.Label7.TabIndex = 52
        Me.Label7.Text = "Modelo del equipo"
        '
        'cmbModeloFechas
        '
        Me.cmbModeloFechas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbModeloFechas.Enabled = False
        Me.cmbModeloFechas.FormattingEnabled = True
        Me.cmbModeloFechas.Location = New System.Drawing.Point(158, 329)
        Me.cmbModeloFechas.Name = "cmbModeloFechas"
        Me.cmbModeloFechas.Size = New System.Drawing.Size(282, 26)
        Me.cmbModeloFechas.TabIndex = 51
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(25, 293)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(119, 18)
        Me.Label8.TabIndex = 50
        Me.Label8.Text = "Marca del equipo"
        '
        'cmbMarcaFechas
        '
        Me.cmbMarcaFechas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMarcaFechas.Enabled = False
        Me.cmbMarcaFechas.FormattingEnabled = True
        Me.cmbMarcaFechas.Location = New System.Drawing.Point(158, 290)
        Me.cmbMarcaFechas.Name = "cmbMarcaFechas"
        Me.cmbMarcaFechas.Size = New System.Drawing.Size(282, 26)
        Me.cmbMarcaFechas.TabIndex = 49
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(25, 258)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(121, 18)
        Me.Label9.TabIndex = 48
        Me.Label9.Text = "Código del equipo"
        '
        'cmbCodEquipoFechas
        '
        Me.cmbCodEquipoFechas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCodEquipoFechas.Enabled = False
        Me.cmbCodEquipoFechas.FormattingEnabled = True
        Me.cmbCodEquipoFechas.Location = New System.Drawing.Point(158, 255)
        Me.cmbCodEquipoFechas.Name = "cmbCodEquipoFechas"
        Me.cmbCodEquipoFechas.Size = New System.Drawing.Size(282, 26)
        Me.cmbCodEquipoFechas.TabIndex = 47
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(17, 180)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(145, 18)
        Me.Label10.TabIndex = 46
        Me.Label10.Text = "Selección de equipos"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(17, 110)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(163, 18)
        Me.Label11.TabIndex = 45
        Me.Label11.Text = "Tipo de mantenimiento"
        '
        'btnVolver
        '
        Me.btnVolver.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnVolver.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnVolver.Font = New System.Drawing.Font("Bookman Old Style", 12.0!)
        Me.btnVolver.Location = New System.Drawing.Point(369, 516)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(97, 31)
        Me.btnVolver.TabIndex = 29
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnSalir.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSalir.Font = New System.Drawing.Font("Bookman Old Style", 12.0!)
        Me.btnSalir.Location = New System.Drawing.Point(14, 516)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(97, 31)
        Me.btnSalir.TabIndex = 28
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'informe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.CancelButton = Me.btnSalir
        Me.ClientSize = New System.Drawing.Size(484, 561)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.tabCtrlInforme)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Font = New System.Drawing.Font("Bookman Old Style", 9.75!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(500, 600)
        Me.Name = "informe"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Informes"
        Me.tabCtrlInforme.ResumeLayout(False)
        Me.tabUltMant.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.radioTipoMantUlt.ResumeLayout(False)
        Me.radioTipoMantUlt.PerformLayout()
        Me.radioEquipoUlt.ResumeLayout(False)
        Me.radioEquipoUlt.PerformLayout()
        Me.tabFechas.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.radioTipoMantFechas.ResumeLayout(False)
        Me.radioTipoMantFechas.PerformLayout()
        Me.radioEquipoFechas.ResumeLayout(False)
        Me.radioEquipoFechas.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tabCtrlInforme As System.Windows.Forms.TabControl
    Friend WithEvents tabUltMant As System.Windows.Forms.TabPage
    Friend WithEvents tabFechas As System.Windows.Forms.TabPage
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents fechaFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents fechaInicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents radioTipoMantFechas As System.Windows.Forms.Panel
    Friend WithEvents radioAmbosFechas As System.Windows.Forms.RadioButton
    Friend WithEvents radioPreventivoFechas As System.Windows.Forms.RadioButton
    Friend WithEvents radioCorrectivoFechas As System.Windows.Forms.RadioButton
    Friend WithEvents radioEquipoFechas As System.Windows.Forms.Panel
    Friend WithEvents radioModeloFechas As System.Windows.Forms.RadioButton
    Friend WithEvents radioMarcaFechas As System.Windows.Forms.RadioButton
    Friend WithEvents radioTodosFechas As System.Windows.Forms.RadioButton
    Friend WithEvents radioCodigoFechas As System.Windows.Forms.RadioButton
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmbModeloFechas As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmbMarcaFechas As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmbCodEquipoFechas As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnRealizarFechas As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents radioTipoMantUlt As System.Windows.Forms.Panel
    Friend WithEvents radioAmbosUlt As System.Windows.Forms.RadioButton
    Friend WithEvents radioPreventivoUlt As System.Windows.Forms.RadioButton
    Friend WithEvents radioCorrectivoUlt As System.Windows.Forms.RadioButton
    Friend WithEvents radioEquipoUlt As System.Windows.Forms.Panel
    Friend WithEvents radioModeloUlt As System.Windows.Forms.RadioButton
    Friend WithEvents radioMarcaUlt As System.Windows.Forms.RadioButton
    Friend WithEvents radioTodosUlt As System.Windows.Forms.RadioButton
    Friend WithEvents radioCodigoUlt As System.Windows.Forms.RadioButton
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbModeloUlt As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbMarcaUlt As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbCodEquipoUlt As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnRealizarUlt As System.Windows.Forms.Button
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
End Class
