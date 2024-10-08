<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mantenimiento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mantenimiento))
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.tabCtrlMant = New System.Windows.Forms.TabControl()
        Me.tabAnadir = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.radioCorrectivoAdd = New System.Windows.Forms.RadioButton()
        Me.radioPreventivoAdd = New System.Windows.Forms.RadioButton()
        Me.fechaMantAdd = New System.Windows.Forms.DateTimePicker()
        Me.lblModeloAdd = New System.Windows.Forms.Label()
        Me.lblMarcaAdd = New System.Windows.Forms.Label()
        Me.cmbCodEquipoAdd = New System.Windows.Forms.ComboBox()
        Me.txtDescMantAdd = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.btnAnadir = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tabModificar = New System.Windows.Forms.TabPage()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.radioCorrectivoMdf = New System.Windows.Forms.RadioButton()
        Me.radioPreventivoMdf = New System.Windows.Forms.RadioButton()
        Me.fechaMantMdf = New System.Windows.Forms.DateTimePicker()
        Me.lblModeloMdf = New System.Windows.Forms.Label()
        Me.lblMarcaMdf = New System.Windows.Forms.Label()
        Me.cmbCodEquipoMdf = New System.Windows.Forms.ComboBox()
        Me.txtDescMantMdf = New System.Windows.Forms.TextBox()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.tabBuscar = New System.Windows.Forms.TabPage()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.radioCorrectivoBus = New System.Windows.Forms.RadioButton()
        Me.radioPreventivoBus = New System.Windows.Forms.RadioButton()
        Me.fechaMantBus = New System.Windows.Forms.DateTimePicker()
        Me.lblModeloBus = New System.Windows.Forms.Label()
        Me.lblMarcaBus = New System.Windows.Forms.Label()
        Me.cmbCodEquipoBus = New System.Windows.Forms.ComboBox()
        Me.txtDescMantBus = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tabEliminar = New System.Windows.Forms.TabPage()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.radioCorrectivoDel = New System.Windows.Forms.RadioButton()
        Me.radioPreventivoDel = New System.Windows.Forms.RadioButton()
        Me.fechaMantDel = New System.Windows.Forms.DateTimePicker()
        Me.lblModeloDel = New System.Windows.Forms.Label()
        Me.lblMarcaDel = New System.Windows.Forms.Label()
        Me.cmbCodEquipoDel = New System.Windows.Forms.ComboBox()
        Me.txtDescMantDel = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.tabCtrlMant.SuspendLayout()
        Me.tabAnadir.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.tabModificar.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.tabBuscar.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.tabEliminar.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnSalir.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSalir.Font = New System.Drawing.Font("Bookman Old Style", 12.0!)
        Me.btnSalir.Location = New System.Drawing.Point(15, 516)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(97, 31)
        Me.btnSalir.TabIndex = 25
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'tabCtrlMant
        '
        Me.tabCtrlMant.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.tabCtrlMant.Controls.Add(Me.tabAnadir)
        Me.tabCtrlMant.Controls.Add(Me.tabModificar)
        Me.tabCtrlMant.Controls.Add(Me.tabBuscar)
        Me.tabCtrlMant.Controls.Add(Me.tabEliminar)
        Me.tabCtrlMant.Font = New System.Drawing.Font("Bookman Old Style", 9.75!)
        Me.tabCtrlMant.Location = New System.Drawing.Point(0, 120)
        Me.tabCtrlMant.Margin = New System.Windows.Forms.Padding(0)
        Me.tabCtrlMant.MinimumSize = New System.Drawing.Size(487, 385)
        Me.tabCtrlMant.Name = "tabCtrlMant"
        Me.tabCtrlMant.SelectedIndex = 0
        Me.tabCtrlMant.Size = New System.Drawing.Size(487, 385)
        Me.tabCtrlMant.TabIndex = 24
        '
        'tabAnadir
        '
        Me.tabAnadir.AutoScroll = True
        Me.tabAnadir.AutoScrollMargin = New System.Drawing.Size(0, 15)
        Me.tabAnadir.BackColor = System.Drawing.Color.Lavender
        Me.tabAnadir.Controls.Add(Me.Panel1)
        Me.tabAnadir.Location = New System.Drawing.Point(4, 27)
        Me.tabAnadir.Name = "tabAnadir"
        Me.tabAnadir.Padding = New System.Windows.Forms.Padding(3)
        Me.tabAnadir.Size = New System.Drawing.Size(479, 354)
        Me.tabAnadir.TabIndex = 0
        Me.tabAnadir.Text = "Añadir"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label38)
        Me.Panel1.Controls.Add(Me.radioCorrectivoAdd)
        Me.Panel1.Controls.Add(Me.radioPreventivoAdd)
        Me.Panel1.Controls.Add(Me.fechaMantAdd)
        Me.Panel1.Controls.Add(Me.lblModeloAdd)
        Me.Panel1.Controls.Add(Me.lblMarcaAdd)
        Me.Panel1.Controls.Add(Me.cmbCodEquipoAdd)
        Me.Panel1.Controls.Add(Me.txtDescMantAdd)
        Me.Panel1.Controls.Add(Me.Label33)
        Me.Panel1.Controls.Add(Me.Label34)
        Me.Panel1.Controls.Add(Me.Label35)
        Me.Panel1.Controls.Add(Me.btnAnadir)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(456, 446)
        Me.Panel1.TabIndex = 39
        '
        'Label38
        '
        Me.Label38.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Bookman Old Style", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.Location = New System.Drawing.Point(9, 178)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(200, 19)
        Me.Label38.TabIndex = 38
        Me.Label38.Text = "Datos del mantenimiento" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'radioCorrectivoAdd
        '
        Me.radioCorrectivoAdd.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.radioCorrectivoAdd.AutoSize = True
        Me.radioCorrectivoAdd.Location = New System.Drawing.Point(349, 261)
        Me.radioCorrectivoAdd.Name = "radioCorrectivoAdd"
        Me.radioCorrectivoAdd.Size = New System.Drawing.Size(94, 22)
        Me.radioCorrectivoAdd.TabIndex = 37
        Me.radioCorrectivoAdd.TabStop = True
        Me.radioCorrectivoAdd.Text = "Correctivo"
        Me.radioCorrectivoAdd.UseVisualStyleBackColor = True
        '
        'radioPreventivoAdd
        '
        Me.radioPreventivoAdd.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.radioPreventivoAdd.AutoSize = True
        Me.radioPreventivoAdd.Location = New System.Drawing.Point(244, 261)
        Me.radioPreventivoAdd.Name = "radioPreventivoAdd"
        Me.radioPreventivoAdd.Size = New System.Drawing.Size(96, 22)
        Me.radioPreventivoAdd.TabIndex = 36
        Me.radioPreventivoAdd.TabStop = True
        Me.radioPreventivoAdd.Text = "Preventivo"
        Me.radioPreventivoAdd.UseVisualStyleBackColor = True
        '
        'fechaMantAdd
        '
        Me.fechaMantAdd.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.fechaMantAdd.Location = New System.Drawing.Point(159, 213)
        Me.fechaMantAdd.Name = "fechaMantAdd"
        Me.fechaMantAdd.Size = New System.Drawing.Size(285, 23)
        Me.fechaMantAdd.TabIndex = 35
        '
        'lblModeloAdd
        '
        Me.lblModeloAdd.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblModeloAdd.AutoSize = True
        Me.lblModeloAdd.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModeloAdd.Location = New System.Drawing.Point(136, 146)
        Me.lblModeloAdd.Name = "lblModeloAdd"
        Me.lblModeloAdd.Size = New System.Drawing.Size(308, 16)
        Me.lblModeloAdd.TabIndex = 34
        Me.lblModeloAdd.Text = "El modelo de este equipo no está registrado"
        Me.lblModeloAdd.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblMarcaAdd
        '
        Me.lblMarcaAdd.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblMarcaAdd.AutoSize = True
        Me.lblMarcaAdd.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMarcaAdd.Location = New System.Drawing.Point(142, 104)
        Me.lblMarcaAdd.Name = "lblMarcaAdd"
        Me.lblMarcaAdd.Size = New System.Drawing.Size(302, 16)
        Me.lblMarcaAdd.TabIndex = 33
        Me.lblMarcaAdd.Text = "La marca de este equipo no está registrada"
        Me.lblMarcaAdd.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cmbCodEquipoAdd
        '
        Me.cmbCodEquipoAdd.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cmbCodEquipoAdd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCodEquipoAdd.FormattingEnabled = True
        Me.cmbCodEquipoAdd.Location = New System.Drawing.Point(159, 54)
        Me.cmbCodEquipoAdd.Name = "cmbCodEquipoAdd"
        Me.cmbCodEquipoAdd.Size = New System.Drawing.Size(285, 26)
        Me.cmbCodEquipoAdd.TabIndex = 32
        '
        'txtDescMantAdd
        '
        Me.txtDescMantAdd.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtDescMantAdd.Location = New System.Drawing.Point(159, 306)
        Me.txtDescMantAdd.Multiline = True
        Me.txtDescMantAdd.Name = "txtDescMantAdd"
        Me.txtDescMantAdd.Size = New System.Drawing.Size(285, 93)
        Me.txtDescMantAdd.TabIndex = 28
        '
        'Label33
        '
        Me.Label33.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(30, 309)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(112, 36)
        Me.Label33.TabIndex = 31
        Me.Label33.Text = "Descripción del" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "mantenimiento"
        '
        'Label34
        '
        Me.Label34.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(29, 263)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(163, 18)
        Me.Label34.TabIndex = 30
        Me.Label34.Text = "Tipo de mantenimiento"
        '
        'Label35
        '
        Me.Label35.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(29, 211)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(112, 36)
        Me.Label35.TabIndex = 29
        Me.Label35.Text = "Fecha del" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "mantenimiento"
        '
        'btnAnadir
        '
        Me.btnAnadir.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnAnadir.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnAnadir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAnadir.Font = New System.Drawing.Font("Bookman Old Style", 12.0!)
        Me.btnAnadir.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnAnadir.Location = New System.Drawing.Point(346, 409)
        Me.btnAnadir.Name = "btnAnadir"
        Me.btnAnadir.Size = New System.Drawing.Size(98, 31)
        Me.btnAnadir.TabIndex = 0
        Me.btnAnadir.Text = "Añadir"
        Me.btnAnadir.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Bookman Old Style", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(9, 14)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(286, 20)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Añadir datos de un mantenimiento" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(29, 144)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 18)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Modelo"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(29, 102)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 18)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Marca"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 18)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Código del equipo"
        '
        'tabModificar
        '
        Me.tabModificar.AutoScroll = True
        Me.tabModificar.AutoScrollMargin = New System.Drawing.Size(0, 15)
        Me.tabModificar.BackColor = System.Drawing.Color.Lavender
        Me.tabModificar.Controls.Add(Me.Panel2)
        Me.tabModificar.Location = New System.Drawing.Point(4, 27)
        Me.tabModificar.Name = "tabModificar"
        Me.tabModificar.Padding = New System.Windows.Forms.Padding(3)
        Me.tabModificar.Size = New System.Drawing.Size(479, 354)
        Me.tabModificar.TabIndex = 1
        Me.tabModificar.Text = "Modificar"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.radioCorrectivoMdf)
        Me.Panel2.Controls.Add(Me.radioPreventivoMdf)
        Me.Panel2.Controls.Add(Me.fechaMantMdf)
        Me.Panel2.Controls.Add(Me.lblModeloMdf)
        Me.Panel2.Controls.Add(Me.lblMarcaMdf)
        Me.Panel2.Controls.Add(Me.cmbCodEquipoMdf)
        Me.Panel2.Controls.Add(Me.txtDescMantMdf)
        Me.Panel2.Controls.Add(Me.Label39)
        Me.Panel2.Controls.Add(Me.Label40)
        Me.Panel2.Controls.Add(Me.Label41)
        Me.Panel2.Controls.Add(Me.Label42)
        Me.Panel2.Controls.Add(Me.Label43)
        Me.Panel2.Controls.Add(Me.Label44)
        Me.Panel2.Controls.Add(Me.btnModificar)
        Me.Panel2.Controls.Add(Me.Label23)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(456, 448)
        Me.Panel2.TabIndex = 53
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Bookman Old Style", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(9, 178)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(200, 19)
        Me.Label8.TabIndex = 52
        Me.Label8.Text = "Datos del mantenimiento" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'radioCorrectivoMdf
        '
        Me.radioCorrectivoMdf.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.radioCorrectivoMdf.AutoSize = True
        Me.radioCorrectivoMdf.Location = New System.Drawing.Point(349, 261)
        Me.radioCorrectivoMdf.Name = "radioCorrectivoMdf"
        Me.radioCorrectivoMdf.Size = New System.Drawing.Size(94, 22)
        Me.radioCorrectivoMdf.TabIndex = 51
        Me.radioCorrectivoMdf.TabStop = True
        Me.radioCorrectivoMdf.Text = "Correctivo"
        Me.radioCorrectivoMdf.UseVisualStyleBackColor = True
        '
        'radioPreventivoMdf
        '
        Me.radioPreventivoMdf.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.radioPreventivoMdf.AutoSize = True
        Me.radioPreventivoMdf.Location = New System.Drawing.Point(244, 261)
        Me.radioPreventivoMdf.Name = "radioPreventivoMdf"
        Me.radioPreventivoMdf.Size = New System.Drawing.Size(96, 22)
        Me.radioPreventivoMdf.TabIndex = 50
        Me.radioPreventivoMdf.TabStop = True
        Me.radioPreventivoMdf.Text = "Preventivo"
        Me.radioPreventivoMdf.UseVisualStyleBackColor = True
        '
        'fechaMantMdf
        '
        Me.fechaMantMdf.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.fechaMantMdf.Location = New System.Drawing.Point(159, 213)
        Me.fechaMantMdf.Name = "fechaMantMdf"
        Me.fechaMantMdf.Size = New System.Drawing.Size(285, 23)
        Me.fechaMantMdf.TabIndex = 49
        '
        'lblModeloMdf
        '
        Me.lblModeloMdf.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblModeloMdf.AutoSize = True
        Me.lblModeloMdf.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModeloMdf.Location = New System.Drawing.Point(136, 146)
        Me.lblModeloMdf.Name = "lblModeloMdf"
        Me.lblModeloMdf.Size = New System.Drawing.Size(308, 16)
        Me.lblModeloMdf.TabIndex = 48
        Me.lblModeloMdf.Text = "El modelo de este equipo no está registrado"
        Me.lblModeloMdf.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblMarcaMdf
        '
        Me.lblMarcaMdf.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblMarcaMdf.AutoSize = True
        Me.lblMarcaMdf.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMarcaMdf.Location = New System.Drawing.Point(142, 104)
        Me.lblMarcaMdf.Name = "lblMarcaMdf"
        Me.lblMarcaMdf.Size = New System.Drawing.Size(302, 16)
        Me.lblMarcaMdf.TabIndex = 47
        Me.lblMarcaMdf.Text = "La marca de este equipo no está registrada"
        Me.lblMarcaMdf.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cmbCodEquipoMdf
        '
        Me.cmbCodEquipoMdf.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cmbCodEquipoMdf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCodEquipoMdf.FormattingEnabled = True
        Me.cmbCodEquipoMdf.Location = New System.Drawing.Point(159, 54)
        Me.cmbCodEquipoMdf.Name = "cmbCodEquipoMdf"
        Me.cmbCodEquipoMdf.Size = New System.Drawing.Size(285, 26)
        Me.cmbCodEquipoMdf.TabIndex = 46
        '
        'txtDescMantMdf
        '
        Me.txtDescMantMdf.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtDescMantMdf.Location = New System.Drawing.Point(159, 306)
        Me.txtDescMantMdf.Multiline = True
        Me.txtDescMantMdf.Name = "txtDescMantMdf"
        Me.txtDescMantMdf.Size = New System.Drawing.Size(285, 93)
        Me.txtDescMantMdf.TabIndex = 42
        '
        'Label39
        '
        Me.Label39.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label39.AutoSize = True
        Me.Label39.Location = New System.Drawing.Point(30, 309)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(112, 36)
        Me.Label39.TabIndex = 45
        Me.Label39.Text = "Descripción del" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "mantenimiento"
        '
        'Label40
        '
        Me.Label40.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label40.AutoSize = True
        Me.Label40.Location = New System.Drawing.Point(29, 263)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(163, 18)
        Me.Label40.TabIndex = 44
        Me.Label40.Text = "Tipo de mantenimiento"
        '
        'Label41
        '
        Me.Label41.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label41.AutoSize = True
        Me.Label41.Location = New System.Drawing.Point(29, 211)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(112, 36)
        Me.Label41.TabIndex = 43
        Me.Label41.Text = "Fecha del" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "mantenimiento"
        '
        'Label42
        '
        Me.Label42.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label42.AutoSize = True
        Me.Label42.Location = New System.Drawing.Point(29, 144)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(53, 18)
        Me.Label42.TabIndex = 41
        Me.Label42.Text = "Modelo"
        '
        'Label43
        '
        Me.Label43.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label43.AutoSize = True
        Me.Label43.Location = New System.Drawing.Point(29, 102)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(49, 18)
        Me.Label43.TabIndex = 40
        Me.Label43.Text = "Marca"
        '
        'Label44
        '
        Me.Label44.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label44.AutoSize = True
        Me.Label44.Location = New System.Drawing.Point(29, 57)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(121, 18)
        Me.Label44.TabIndex = 39
        Me.Label44.Text = "Código del equipo"
        '
        'btnModificar
        '
        Me.btnModificar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnModificar.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnModificar.Font = New System.Drawing.Font("Bookman Old Style", 12.0!)
        Me.btnModificar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnModificar.Location = New System.Drawing.Point(346, 409)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(98, 31)
        Me.btnModificar.TabIndex = 5
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'Label23
        '
        Me.Label23.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Bookman Old Style", 12.0!)
        Me.Label23.Location = New System.Drawing.Point(9, 14)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(333, 20)
        Me.Label23.TabIndex = 27
        Me.Label23.Text = "Modificar los datos de un mantenimiento"
        '
        'tabBuscar
        '
        Me.tabBuscar.AutoScroll = True
        Me.tabBuscar.AutoScrollMargin = New System.Drawing.Size(0, 15)
        Me.tabBuscar.BackColor = System.Drawing.Color.Lavender
        Me.tabBuscar.Controls.Add(Me.Panel3)
        Me.tabBuscar.Location = New System.Drawing.Point(4, 27)
        Me.tabBuscar.Name = "tabBuscar"
        Me.tabBuscar.Padding = New System.Windows.Forms.Padding(3)
        Me.tabBuscar.Size = New System.Drawing.Size(479, 354)
        Me.tabBuscar.TabIndex = 2
        Me.tabBuscar.Text = "Buscar"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.radioCorrectivoBus)
        Me.Panel3.Controls.Add(Me.radioPreventivoBus)
        Me.Panel3.Controls.Add(Me.fechaMantBus)
        Me.Panel3.Controls.Add(Me.lblModeloBus)
        Me.Panel3.Controls.Add(Me.lblMarcaBus)
        Me.Panel3.Controls.Add(Me.cmbCodEquipoBus)
        Me.Panel3.Controls.Add(Me.txtDescMantBus)
        Me.Panel3.Controls.Add(Me.Label19)
        Me.Panel3.Controls.Add(Me.Label20)
        Me.Panel3.Controls.Add(Me.Label21)
        Me.Panel3.Controls.Add(Me.Label22)
        Me.Panel3.Controls.Add(Me.Label24)
        Me.Panel3.Controls.Add(Me.Label25)
        Me.Panel3.Controls.Add(Me.btnBuscar)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(3, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(456, 453)
        Me.Panel3.TabIndex = 54
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bookman Old Style", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 178)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(200, 19)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "Datos del mantenimiento" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'radioCorrectivoBus
        '
        Me.radioCorrectivoBus.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.radioCorrectivoBus.AutoSize = True
        Me.radioCorrectivoBus.Enabled = False
        Me.radioCorrectivoBus.Location = New System.Drawing.Point(350, 261)
        Me.radioCorrectivoBus.Name = "radioCorrectivoBus"
        Me.radioCorrectivoBus.Size = New System.Drawing.Size(94, 22)
        Me.radioCorrectivoBus.TabIndex = 52
        Me.radioCorrectivoBus.TabStop = True
        Me.radioCorrectivoBus.Text = "Correctivo"
        Me.radioCorrectivoBus.UseVisualStyleBackColor = True
        '
        'radioPreventivoBus
        '
        Me.radioPreventivoBus.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.radioPreventivoBus.AutoSize = True
        Me.radioPreventivoBus.Enabled = False
        Me.radioPreventivoBus.Location = New System.Drawing.Point(244, 261)
        Me.radioPreventivoBus.Name = "radioPreventivoBus"
        Me.radioPreventivoBus.Size = New System.Drawing.Size(96, 22)
        Me.radioPreventivoBus.TabIndex = 51
        Me.radioPreventivoBus.TabStop = True
        Me.radioPreventivoBus.Text = "Preventivo"
        Me.radioPreventivoBus.UseVisualStyleBackColor = True
        '
        'fechaMantBus
        '
        Me.fechaMantBus.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.fechaMantBus.Location = New System.Drawing.Point(159, 213)
        Me.fechaMantBus.Name = "fechaMantBus"
        Me.fechaMantBus.Size = New System.Drawing.Size(285, 23)
        Me.fechaMantBus.TabIndex = 50
        '
        'lblModeloBus
        '
        Me.lblModeloBus.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblModeloBus.AutoSize = True
        Me.lblModeloBus.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModeloBus.Location = New System.Drawing.Point(136, 146)
        Me.lblModeloBus.Name = "lblModeloBus"
        Me.lblModeloBus.Size = New System.Drawing.Size(308, 16)
        Me.lblModeloBus.TabIndex = 49
        Me.lblModeloBus.Text = "El modelo de este equipo no está registrado"
        Me.lblModeloBus.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblMarcaBus
        '
        Me.lblMarcaBus.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblMarcaBus.AutoSize = True
        Me.lblMarcaBus.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMarcaBus.Location = New System.Drawing.Point(142, 104)
        Me.lblMarcaBus.Name = "lblMarcaBus"
        Me.lblMarcaBus.Size = New System.Drawing.Size(302, 16)
        Me.lblMarcaBus.TabIndex = 48
        Me.lblMarcaBus.Text = "La marca de este equipo no está registrada"
        Me.lblMarcaBus.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cmbCodEquipoBus
        '
        Me.cmbCodEquipoBus.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cmbCodEquipoBus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCodEquipoBus.FormattingEnabled = True
        Me.cmbCodEquipoBus.Location = New System.Drawing.Point(159, 54)
        Me.cmbCodEquipoBus.Name = "cmbCodEquipoBus"
        Me.cmbCodEquipoBus.Size = New System.Drawing.Size(285, 26)
        Me.cmbCodEquipoBus.TabIndex = 47
        '
        'txtDescMantBus
        '
        Me.txtDescMantBus.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtDescMantBus.Enabled = False
        Me.txtDescMantBus.Location = New System.Drawing.Point(159, 306)
        Me.txtDescMantBus.Multiline = True
        Me.txtDescMantBus.Name = "txtDescMantBus"
        Me.txtDescMantBus.Size = New System.Drawing.Size(285, 93)
        Me.txtDescMantBus.TabIndex = 43
        '
        'Label19
        '
        Me.Label19.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(30, 309)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(112, 36)
        Me.Label19.TabIndex = 46
        Me.Label19.Text = "Descripción del" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "mantenimiento"
        '
        'Label20
        '
        Me.Label20.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(29, 263)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(163, 18)
        Me.Label20.TabIndex = 45
        Me.Label20.Text = "Tipo de mantenimiento"
        '
        'Label21
        '
        Me.Label21.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(29, 211)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(112, 36)
        Me.Label21.TabIndex = 44
        Me.Label21.Text = "Fecha del" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "mantenimiento"
        '
        'Label22
        '
        Me.Label22.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(29, 144)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(53, 18)
        Me.Label22.TabIndex = 42
        Me.Label22.Text = "Modelo"
        '
        'Label24
        '
        Me.Label24.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(29, 102)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(49, 18)
        Me.Label24.TabIndex = 41
        Me.Label24.Text = "Marca"
        '
        'Label25
        '
        Me.Label25.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(29, 57)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(121, 18)
        Me.Label25.TabIndex = 40
        Me.Label25.Text = "Código del equipo"
        '
        'btnBuscar
        '
        Me.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnBuscar.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBuscar.Font = New System.Drawing.Font("Bookman Old Style", 12.0!)
        Me.btnBuscar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnBuscar.Location = New System.Drawing.Point(346, 410)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(98, 31)
        Me.btnBuscar.TabIndex = 9
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Bookman Old Style", 12.0!)
        Me.Label10.Location = New System.Drawing.Point(9, 14)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(288, 20)
        Me.Label10.TabIndex = 36
        Me.Label10.Text = "Buscar datos de un mantenimiento"
        '
        'tabEliminar
        '
        Me.tabEliminar.AutoScroll = True
        Me.tabEliminar.AutoScrollMargin = New System.Drawing.Size(0, 15)
        Me.tabEliminar.BackColor = System.Drawing.Color.Lavender
        Me.tabEliminar.Controls.Add(Me.Panel4)
        Me.tabEliminar.Location = New System.Drawing.Point(4, 27)
        Me.tabEliminar.Name = "tabEliminar"
        Me.tabEliminar.Padding = New System.Windows.Forms.Padding(3)
        Me.tabEliminar.Size = New System.Drawing.Size(479, 354)
        Me.tabEliminar.TabIndex = 3
        Me.tabEliminar.Text = "Eliminar"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Label11)
        Me.Panel4.Controls.Add(Me.radioCorrectivoDel)
        Me.Panel4.Controls.Add(Me.radioPreventivoDel)
        Me.Panel4.Controls.Add(Me.fechaMantDel)
        Me.Panel4.Controls.Add(Me.lblModeloDel)
        Me.Panel4.Controls.Add(Me.lblMarcaDel)
        Me.Panel4.Controls.Add(Me.cmbCodEquipoDel)
        Me.Panel4.Controls.Add(Me.txtDescMantDel)
        Me.Panel4.Controls.Add(Me.Label18)
        Me.Panel4.Controls.Add(Me.Label26)
        Me.Panel4.Controls.Add(Me.Label27)
        Me.Panel4.Controls.Add(Me.Label28)
        Me.Panel4.Controls.Add(Me.Label29)
        Me.Panel4.Controls.Add(Me.Label30)
        Me.Panel4.Controls.Add(Me.btnEliminar)
        Me.Panel4.Controls.Add(Me.Label31)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(3, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(456, 449)
        Me.Panel4.TabIndex = 70
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Bookman Old Style", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(7, 178)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(200, 19)
        Me.Label11.TabIndex = 69
        Me.Label11.Text = "Datos del mantenimiento" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'radioCorrectivoDel
        '
        Me.radioCorrectivoDel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.radioCorrectivoDel.AutoSize = True
        Me.radioCorrectivoDel.Enabled = False
        Me.radioCorrectivoDel.Location = New System.Drawing.Point(348, 261)
        Me.radioCorrectivoDel.Name = "radioCorrectivoDel"
        Me.radioCorrectivoDel.Size = New System.Drawing.Size(94, 22)
        Me.radioCorrectivoDel.TabIndex = 68
        Me.radioCorrectivoDel.TabStop = True
        Me.radioCorrectivoDel.Text = "Correctivo"
        Me.radioCorrectivoDel.UseVisualStyleBackColor = True
        '
        'radioPreventivoDel
        '
        Me.radioPreventivoDel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.radioPreventivoDel.AutoSize = True
        Me.radioPreventivoDel.Enabled = False
        Me.radioPreventivoDel.Location = New System.Drawing.Point(242, 261)
        Me.radioPreventivoDel.Name = "radioPreventivoDel"
        Me.radioPreventivoDel.Size = New System.Drawing.Size(96, 22)
        Me.radioPreventivoDel.TabIndex = 67
        Me.radioPreventivoDel.TabStop = True
        Me.radioPreventivoDel.Text = "Preventivo"
        Me.radioPreventivoDel.UseVisualStyleBackColor = True
        '
        'fechaMantDel
        '
        Me.fechaMantDel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.fechaMantDel.Location = New System.Drawing.Point(157, 213)
        Me.fechaMantDel.Name = "fechaMantDel"
        Me.fechaMantDel.Size = New System.Drawing.Size(285, 23)
        Me.fechaMantDel.TabIndex = 66
        '
        'lblModeloDel
        '
        Me.lblModeloDel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblModeloDel.AutoSize = True
        Me.lblModeloDel.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModeloDel.Location = New System.Drawing.Point(134, 146)
        Me.lblModeloDel.Name = "lblModeloDel"
        Me.lblModeloDel.Size = New System.Drawing.Size(308, 16)
        Me.lblModeloDel.TabIndex = 65
        Me.lblModeloDel.Text = "El modelo de este equipo no está registrado"
        '
        'lblMarcaDel
        '
        Me.lblMarcaDel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblMarcaDel.AutoSize = True
        Me.lblMarcaDel.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMarcaDel.Location = New System.Drawing.Point(140, 104)
        Me.lblMarcaDel.Name = "lblMarcaDel"
        Me.lblMarcaDel.Size = New System.Drawing.Size(302, 16)
        Me.lblMarcaDel.TabIndex = 64
        Me.lblMarcaDel.Text = "La marca de este equipo no está registrada"
        '
        'cmbCodEquipoDel
        '
        Me.cmbCodEquipoDel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cmbCodEquipoDel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCodEquipoDel.FormattingEnabled = True
        Me.cmbCodEquipoDel.Location = New System.Drawing.Point(157, 54)
        Me.cmbCodEquipoDel.Name = "cmbCodEquipoDel"
        Me.cmbCodEquipoDel.Size = New System.Drawing.Size(285, 26)
        Me.cmbCodEquipoDel.TabIndex = 63
        '
        'txtDescMantDel
        '
        Me.txtDescMantDel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtDescMantDel.Enabled = False
        Me.txtDescMantDel.Location = New System.Drawing.Point(157, 306)
        Me.txtDescMantDel.Multiline = True
        Me.txtDescMantDel.Name = "txtDescMantDel"
        Me.txtDescMantDel.Size = New System.Drawing.Size(285, 93)
        Me.txtDescMantDel.TabIndex = 59
        '
        'Label18
        '
        Me.Label18.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(28, 309)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(112, 36)
        Me.Label18.TabIndex = 62
        Me.Label18.Text = "Descripción del" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "mantenimiento"
        '
        'Label26
        '
        Me.Label26.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(27, 263)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(163, 18)
        Me.Label26.TabIndex = 61
        Me.Label26.Text = "Tipo de mantenimiento"
        '
        'Label27
        '
        Me.Label27.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(27, 211)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(112, 36)
        Me.Label27.TabIndex = 60
        Me.Label27.Text = "Fecha del" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "mantenimiento"
        '
        'Label28
        '
        Me.Label28.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(27, 144)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(53, 18)
        Me.Label28.TabIndex = 58
        Me.Label28.Text = "Modelo"
        '
        'Label29
        '
        Me.Label29.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(27, 102)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(49, 18)
        Me.Label29.TabIndex = 57
        Me.Label29.Text = "Marca"
        '
        'Label30
        '
        Me.Label30.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(27, 57)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(121, 18)
        Me.Label30.TabIndex = 56
        Me.Label30.Text = "Código del equipo"
        '
        'btnEliminar
        '
        Me.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnEliminar.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEliminar.Font = New System.Drawing.Font("Bookman Old Style", 12.0!)
        Me.btnEliminar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnEliminar.Location = New System.Drawing.Point(344, 409)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(98, 31)
        Me.btnEliminar.TabIndex = 54
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'Label31
        '
        Me.Label31.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Bookman Old Style", 12.0!)
        Me.Label31.Location = New System.Drawing.Point(7, 14)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(301, 20)
        Me.Label31.TabIndex = 55
        Me.Label31.Text = "Eliminar datos de un mantenimiento"
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Old English Text MT", 14.25!)
        Me.Label13.Location = New System.Drawing.Point(131, 86)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(210, 23)
        Me.Label13.TabIndex = 23
        Me.Label13.Text = "Administrar Mantenimiento"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Old English Text MT", 12.75!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(116, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(237, 21)
        Me.Label4.TabIndex = 22
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
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Control de Mantenimiento"
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
        Me.btnVolver.TabIndex = 26
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = False
        '
        'mantenimiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.CancelButton = Me.btnSalir
        Me.ClientSize = New System.Drawing.Size(484, 561)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.tabCtrlMant)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Font = New System.Drawing.Font("Bookman Old Style", 9.75!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(500, 600)
        Me.Name = "mantenimiento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administrar Mantenimiento"
        Me.tabCtrlMant.ResumeLayout(False)
        Me.tabAnadir.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.tabModificar.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.tabBuscar.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.tabEliminar.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents tabCtrlMant As System.Windows.Forms.TabControl
    Friend WithEvents tabAnadir As System.Windows.Forms.TabPage
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents radioCorrectivoAdd As System.Windows.Forms.RadioButton
    Friend WithEvents radioPreventivoAdd As System.Windows.Forms.RadioButton
    Friend WithEvents fechaMantAdd As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblModeloAdd As System.Windows.Forms.Label
    Friend WithEvents lblMarcaAdd As System.Windows.Forms.Label
    Friend WithEvents cmbCodEquipoAdd As System.Windows.Forms.ComboBox
    Friend WithEvents txtDescMantAdd As System.Windows.Forms.TextBox
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents btnAnadir As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tabModificar As System.Windows.Forms.TabPage
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents radioCorrectivoMdf As System.Windows.Forms.RadioButton
    Friend WithEvents radioPreventivoMdf As System.Windows.Forms.RadioButton
    Friend WithEvents fechaMantMdf As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblModeloMdf As System.Windows.Forms.Label
    Friend WithEvents lblMarcaMdf As System.Windows.Forms.Label
    Friend WithEvents cmbCodEquipoMdf As System.Windows.Forms.ComboBox
    Friend WithEvents txtDescMantMdf As System.Windows.Forms.TextBox
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents tabBuscar As System.Windows.Forms.TabPage
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents radioCorrectivoBus As System.Windows.Forms.RadioButton
    Friend WithEvents radioPreventivoBus As System.Windows.Forms.RadioButton
    Friend WithEvents fechaMantBus As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblModeloBus As System.Windows.Forms.Label
    Friend WithEvents lblMarcaBus As System.Windows.Forms.Label
    Friend WithEvents cmbCodEquipoBus As System.Windows.Forms.ComboBox
    Friend WithEvents txtDescMantBus As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents tabEliminar As System.Windows.Forms.TabPage
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents radioCorrectivoDel As System.Windows.Forms.RadioButton
    Friend WithEvents radioPreventivoDel As System.Windows.Forms.RadioButton
    Friend WithEvents fechaMantDel As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblModeloDel As System.Windows.Forms.Label
    Friend WithEvents lblMarcaDel As System.Windows.Forms.Label
    Friend WithEvents cmbCodEquipoDel As System.Windows.Forms.ComboBox
    Friend WithEvents txtDescMantDel As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
End Class
