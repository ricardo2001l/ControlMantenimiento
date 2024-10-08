<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class equipo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(equipo))
        Me.Label13 = New System.Windows.Forms.Label()
        Me.tabCtrlEquipo = New System.Windows.Forms.TabControl()
        Me.tabAnadir = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtCodEquipoAdd = New System.Windows.Forms.TextBox()
        Me.btnAnadir = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtModeloAdd = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtMarcaAdd = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tabModificar = New System.Windows.Forms.TabPage()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtModeloMdf = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtMarcaMdf = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cmbCodEquipoMdf = New System.Windows.Forms.ComboBox()
        Me.tabBuscar = New System.Windows.Forms.TabPage()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.lblDescMantBus = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.lblTipoMantBus = New System.Windows.Forms.Label()
        Me.lblUltMantBus = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtModeloBus = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMarcaBus = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cmbCodEquipoBus = New System.Windows.Forms.ComboBox()
        Me.tabEliminar = New System.Windows.Forms.TabPage()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.lblDescMantDel = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.lblTipoMantDel = New System.Windows.Forms.Label()
        Me.lblUltMantDel = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtModeloDel = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtMarcaDel = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.cmbCodEquipoDel = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.txtPiezasAdd = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtPiezasMdf = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtPiezasBus = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txtPiezasDel = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.tabCtrlEquipo.SuspendLayout()
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
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Old English Text MT", 14.25!)
        Me.Label13.Location = New System.Drawing.Point(156, 86)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(163, 23)
        Me.Label13.TabIndex = 21
        Me.Label13.Text = "Administrar Equipos"
        '
        'tabCtrlEquipo
        '
        Me.tabCtrlEquipo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.tabCtrlEquipo.Controls.Add(Me.tabAnadir)
        Me.tabCtrlEquipo.Controls.Add(Me.tabModificar)
        Me.tabCtrlEquipo.Controls.Add(Me.tabBuscar)
        Me.tabCtrlEquipo.Controls.Add(Me.tabEliminar)
        Me.tabCtrlEquipo.Location = New System.Drawing.Point(0, 120)
        Me.tabCtrlEquipo.MinimumSize = New System.Drawing.Size(486, 385)
        Me.tabCtrlEquipo.Name = "tabCtrlEquipo"
        Me.tabCtrlEquipo.SelectedIndex = 0
        Me.tabCtrlEquipo.Size = New System.Drawing.Size(486, 385)
        Me.tabCtrlEquipo.TabIndex = 23
        '
        'tabAnadir
        '
        Me.tabAnadir.BackColor = System.Drawing.Color.Lavender
        Me.tabAnadir.Controls.Add(Me.Panel1)
        Me.tabAnadir.Location = New System.Drawing.Point(4, 27)
        Me.tabAnadir.Name = "tabAnadir"
        Me.tabAnadir.Padding = New System.Windows.Forms.Padding(3)
        Me.tabAnadir.Size = New System.Drawing.Size(478, 354)
        Me.tabAnadir.TabIndex = 0
        Me.tabAnadir.Text = "Añadir"
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel1.Controls.Add(Me.txtPiezasAdd)
        Me.Panel1.Controls.Add(Me.Label22)
        Me.Panel1.Controls.Add(Me.txtCodEquipoAdd)
        Me.Panel1.Controls.Add(Me.btnAnadir)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtModeloAdd)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.txtMarcaAdd)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(477, 353)
        Me.Panel1.TabIndex = 26
        '
        'txtCodEquipoAdd
        '
        Me.txtCodEquipoAdd.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtCodEquipoAdd.Location = New System.Drawing.Point(157, 57)
        Me.txtCodEquipoAdd.Name = "txtCodEquipoAdd"
        Me.txtCodEquipoAdd.Size = New System.Drawing.Size(285, 23)
        Me.txtCodEquipoAdd.TabIndex = 26
        '
        'btnAnadir
        '
        Me.btnAnadir.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnAnadir.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnAnadir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAnadir.Font = New System.Drawing.Font("Bookman Old Style", 12.0!)
        Me.btnAnadir.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnAnadir.Location = New System.Drawing.Point(344, 306)
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
        Me.Label5.Location = New System.Drawing.Point(7, 14)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(149, 20)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Añadir un Equipo"
        '
        'txtModeloAdd
        '
        Me.txtModeloAdd.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtModeloAdd.Location = New System.Drawing.Point(157, 141)
        Me.txtModeloAdd.Name = "txtModeloAdd"
        Me.txtModeloAdd.Size = New System.Drawing.Size(285, 23)
        Me.txtModeloAdd.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(27, 144)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 18)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Modelo"
        '
        'txtMarcaAdd
        '
        Me.txtMarcaAdd.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtMarcaAdd.Location = New System.Drawing.Point(157, 99)
        Me.txtMarcaAdd.Name = "txtMarcaAdd"
        Me.txtMarcaAdd.Size = New System.Drawing.Size(285, 23)
        Me.txtMarcaAdd.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(27, 102)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 18)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Marca"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 18)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Código del equipo"
        '
        'tabModificar
        '
        Me.tabModificar.AutoScroll = True
        Me.tabModificar.BackColor = System.Drawing.Color.Lavender
        Me.tabModificar.Controls.Add(Me.Panel2)
        Me.tabModificar.Location = New System.Drawing.Point(4, 27)
        Me.tabModificar.Name = "tabModificar"
        Me.tabModificar.Padding = New System.Windows.Forms.Padding(3)
        Me.tabModificar.Size = New System.Drawing.Size(478, 354)
        Me.tabModificar.TabIndex = 1
        Me.tabModificar.Text = "Modificar"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.txtPiezasMdf)
        Me.Panel2.Controls.Add(Me.Label24)
        Me.Panel2.Controls.Add(Me.btnModificar)
        Me.Panel2.Controls.Add(Me.Label23)
        Me.Panel2.Controls.Add(Me.txtModeloMdf)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.txtMarcaMdf)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.cmbCodEquipoMdf)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(477, 353)
        Me.Panel2.TabIndex = 28
        '
        'btnModificar
        '
        Me.btnModificar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnModificar.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnModificar.Font = New System.Drawing.Font("Bookman Old Style", 12.0!)
        Me.btnModificar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnModificar.Location = New System.Drawing.Point(344, 306)
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
        Me.Label23.Location = New System.Drawing.Point(7, 14)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(167, 20)
        Me.Label23.TabIndex = 27
        Me.Label23.Text = "Modificar un equipo"
        '
        'txtModeloMdf
        '
        Me.txtModeloMdf.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtModeloMdf.Location = New System.Drawing.Point(157, 141)
        Me.txtModeloMdf.Name = "txtModeloMdf"
        Me.txtModeloMdf.Size = New System.Drawing.Size(285, 23)
        Me.txtModeloMdf.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(27, 144)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 18)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "Modelo"
        '
        'txtMarcaMdf
        '
        Me.txtMarcaMdf.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtMarcaMdf.Location = New System.Drawing.Point(157, 99)
        Me.txtMarcaMdf.Name = "txtMarcaMdf"
        Me.txtMarcaMdf.Size = New System.Drawing.Size(285, 23)
        Me.txtMarcaMdf.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(27, 102)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 18)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Marca"
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(27, 57)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(121, 18)
        Me.Label12.TabIndex = 19
        Me.Label12.Text = "Código del equipo"
        '
        'cmbCodEquipoMdf
        '
        Me.cmbCodEquipoMdf.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cmbCodEquipoMdf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCodEquipoMdf.FormattingEnabled = True
        Me.cmbCodEquipoMdf.Location = New System.Drawing.Point(157, 54)
        Me.cmbCodEquipoMdf.Name = "cmbCodEquipoMdf"
        Me.cmbCodEquipoMdf.Size = New System.Drawing.Size(285, 26)
        Me.cmbCodEquipoMdf.TabIndex = 6
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
        Me.tabBuscar.Size = New System.Drawing.Size(478, 354)
        Me.tabBuscar.TabIndex = 2
        Me.tabBuscar.Text = "Buscar"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.txtPiezasBus)
        Me.Panel3.Controls.Add(Me.Label26)
        Me.Panel3.Controls.Add(Me.btnBuscar)
        Me.Panel3.Controls.Add(Me.lblDescMantBus)
        Me.Panel3.Controls.Add(Me.Label25)
        Me.Panel3.Controls.Add(Me.lblTipoMantBus)
        Me.Panel3.Controls.Add(Me.lblUltMantBus)
        Me.Panel3.Controls.Add(Me.Label21)
        Me.Panel3.Controls.Add(Me.Label20)
        Me.Panel3.Controls.Add(Me.Label19)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.txtModeloBus)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.txtMarcaBus)
        Me.Panel3.Controls.Add(Me.Label14)
        Me.Panel3.Controls.Add(Me.Label17)
        Me.Panel3.Controls.Add(Me.cmbCodEquipoBus)
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(461, 401)
        Me.Panel3.TabIndex = 46
        '
        'btnBuscar
        '
        Me.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnBuscar.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBuscar.Font = New System.Drawing.Font("Bookman Old Style", 12.0!)
        Me.btnBuscar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnBuscar.Location = New System.Drawing.Point(344, 357)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(98, 31)
        Me.btnBuscar.TabIndex = 9
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'lblDescMantBus
        '
        Me.lblDescMantBus.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblDescMantBus.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblDescMantBus.Location = New System.Drawing.Point(293, 301)
        Me.lblDescMantBus.Name = "lblDescMantBus"
        Me.lblDescMantBus.Size = New System.Drawing.Size(151, 84)
        Me.lblDescMantBus.TabIndex = 45
        Me.lblDescMantBus.Text = "Sin descripción"
        Me.lblDescMantBus.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label25
        '
        Me.Label25.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(31, 302)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(213, 18)
        Me.Label25.TabIndex = 44
        Me.Label25.Text = "Descripcion de mantenimiento"
        '
        'lblTipoMantBus
        '
        Me.lblTipoMantBus.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblTipoMantBus.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblTipoMantBus.Location = New System.Drawing.Point(269, 264)
        Me.lblTipoMantBus.Name = "lblTipoMantBus"
        Me.lblTipoMantBus.Size = New System.Drawing.Size(179, 16)
        Me.lblTipoMantBus.TabIndex = 43
        Me.lblTipoMantBus.Text = "Sin información"
        Me.lblTipoMantBus.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblUltMantBus
        '
        Me.lblUltMantBus.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblUltMantBus.AutoSize = True
        Me.lblUltMantBus.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblUltMantBus.Location = New System.Drawing.Point(369, 219)
        Me.lblUltMantBus.Name = "lblUltMantBus"
        Me.lblUltMantBus.Size = New System.Drawing.Size(76, 16)
        Me.lblUltMantBus.TabIndex = 42
        Me.lblUltMantBus.Text = "Sin Fecha"
        Me.lblUltMantBus.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label21
        '
        Me.Label21.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(210, 219)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(0, 18)
        Me.Label21.TabIndex = 41
        '
        'Label20
        '
        Me.Label20.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(29, 262)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(163, 18)
        Me.Label20.TabIndex = 39
        Me.Label20.Text = "Tipo de mantenimiento"
        '
        'Label19
        '
        Me.Label19.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(29, 219)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(242, 18)
        Me.Label19.TabIndex = 37
        Me.Label19.Text = "Fecha de su último mantenimiento" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Bookman Old Style", 12.0!)
        Me.Label10.Location = New System.Drawing.Point(7, 14)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(149, 20)
        Me.Label10.TabIndex = 36
        Me.Label10.Text = "Buscar un equipo"
        '
        'txtModeloBus
        '
        Me.txtModeloBus.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtModeloBus.Enabled = False
        Me.txtModeloBus.Location = New System.Drawing.Point(157, 141)
        Me.txtModeloBus.Name = "txtModeloBus"
        Me.txtModeloBus.Size = New System.Drawing.Size(285, 23)
        Me.txtModeloBus.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 144)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 18)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Modelo"
        '
        'txtMarcaBus
        '
        Me.txtMarcaBus.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtMarcaBus.Enabled = False
        Me.txtMarcaBus.Location = New System.Drawing.Point(157, 99)
        Me.txtMarcaBus.Name = "txtMarcaBus"
        Me.txtMarcaBus.Size = New System.Drawing.Size(285, 23)
        Me.txtMarcaBus.TabIndex = 11
        '
        'Label14
        '
        Me.Label14.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(29, 102)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(49, 18)
        Me.Label14.TabIndex = 32
        Me.Label14.Text = "Marca"
        '
        'Label17
        '
        Me.Label17.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(27, 57)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(121, 18)
        Me.Label17.TabIndex = 28
        Me.Label17.Text = "Código del equipo"
        '
        'cmbCodEquipoBus
        '
        Me.cmbCodEquipoBus.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cmbCodEquipoBus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCodEquipoBus.FormattingEnabled = True
        Me.cmbCodEquipoBus.Location = New System.Drawing.Point(157, 54)
        Me.cmbCodEquipoBus.Name = "cmbCodEquipoBus"
        Me.cmbCodEquipoBus.Size = New System.Drawing.Size(285, 26)
        Me.cmbCodEquipoBus.TabIndex = 10
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
        Me.tabEliminar.Size = New System.Drawing.Size(478, 354)
        Me.tabEliminar.TabIndex = 3
        Me.tabEliminar.Text = "Eliminar"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.txtPiezasDel)
        Me.Panel4.Controls.Add(Me.Label28)
        Me.Panel4.Controls.Add(Me.btnEliminar)
        Me.Panel4.Controls.Add(Me.lblDescMantDel)
        Me.Panel4.Controls.Add(Me.Label27)
        Me.Panel4.Controls.Add(Me.lblTipoMantDel)
        Me.Panel4.Controls.Add(Me.lblUltMantDel)
        Me.Panel4.Controls.Add(Me.Label30)
        Me.Panel4.Controls.Add(Me.Label31)
        Me.Panel4.Controls.Add(Me.Label32)
        Me.Panel4.Controls.Add(Me.Label11)
        Me.Panel4.Controls.Add(Me.txtModeloDel)
        Me.Panel4.Controls.Add(Me.Label15)
        Me.Panel4.Controls.Add(Me.txtMarcaDel)
        Me.Panel4.Controls.Add(Me.Label16)
        Me.Panel4.Controls.Add(Me.Label18)
        Me.Panel4.Controls.Add(Me.cmbCodEquipoDel)
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(461, 396)
        Me.Panel4.TabIndex = 53
        '
        'btnEliminar
        '
        Me.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnEliminar.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEliminar.Font = New System.Drawing.Font("Bookman Old Style", 12.0!)
        Me.btnEliminar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnEliminar.Location = New System.Drawing.Point(344, 358)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(98, 31)
        Me.btnEliminar.TabIndex = 13
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'lblDescMantDel
        '
        Me.lblDescMantDel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblDescMantDel.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblDescMantDel.Location = New System.Drawing.Point(316, 313)
        Me.lblDescMantDel.Name = "lblDescMantDel"
        Me.lblDescMantDel.Size = New System.Drawing.Size(128, 74)
        Me.lblDescMantDel.TabIndex = 52
        Me.lblDescMantDel.Text = "Sin descripción"
        Me.lblDescMantDel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label27
        '
        Me.Label27.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(31, 314)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(213, 18)
        Me.Label27.TabIndex = 51
        Me.Label27.Text = "Descripción de mantenimiento"
        '
        'lblTipoMantDel
        '
        Me.lblTipoMantDel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblTipoMantDel.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblTipoMantDel.Location = New System.Drawing.Point(293, 276)
        Me.lblTipoMantDel.Name = "lblTipoMantDel"
        Me.lblTipoMantDel.Size = New System.Drawing.Size(155, 16)
        Me.lblTipoMantDel.TabIndex = 50
        Me.lblTipoMantDel.Text = "Sin información"
        Me.lblTipoMantDel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblUltMantDel
        '
        Me.lblUltMantDel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblUltMantDel.AutoSize = True
        Me.lblUltMantDel.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblUltMantDel.Location = New System.Drawing.Point(369, 231)
        Me.lblUltMantDel.Name = "lblUltMantDel"
        Me.lblUltMantDel.Size = New System.Drawing.Size(76, 16)
        Me.lblUltMantDel.TabIndex = 49
        Me.lblUltMantDel.Text = "Sin Fecha"
        Me.lblUltMantDel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label30
        '
        Me.Label30.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(210, 231)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(0, 18)
        Me.Label30.TabIndex = 48
        '
        'Label31
        '
        Me.Label31.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(29, 274)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(163, 18)
        Me.Label31.TabIndex = 47
        Me.Label31.Text = "Tipo de mantenimiento"
        '
        'Label32
        '
        Me.Label32.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(29, 231)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(242, 18)
        Me.Label32.TabIndex = 46
        Me.Label32.Text = "Fecha de su último mantenimiento" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Bookman Old Style", 12.0!)
        Me.Label11.Location = New System.Drawing.Point(7, 14)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(162, 20)
        Me.Label11.TabIndex = 43
        Me.Label11.Text = "Eliminar un equipo"
        '
        'txtModeloDel
        '
        Me.txtModeloDel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtModeloDel.Enabled = False
        Me.txtModeloDel.Location = New System.Drawing.Point(157, 141)
        Me.txtModeloDel.Name = "txtModeloDel"
        Me.txtModeloDel.Size = New System.Drawing.Size(285, 23)
        Me.txtModeloDel.TabIndex = 16
        '
        'Label15
        '
        Me.Label15.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(29, 144)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(53, 18)
        Me.Label15.TabIndex = 41
        Me.Label15.Text = "Modelo"
        '
        'txtMarcaDel
        '
        Me.txtMarcaDel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtMarcaDel.Enabled = False
        Me.txtMarcaDel.Location = New System.Drawing.Point(157, 99)
        Me.txtMarcaDel.Name = "txtMarcaDel"
        Me.txtMarcaDel.Size = New System.Drawing.Size(285, 23)
        Me.txtMarcaDel.TabIndex = 15
        '
        'Label16
        '
        Me.Label16.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(29, 102)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(49, 18)
        Me.Label16.TabIndex = 39
        Me.Label16.Text = "Marca"
        '
        'Label18
        '
        Me.Label18.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(27, 57)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(121, 18)
        Me.Label18.TabIndex = 38
        Me.Label18.Text = "Código del equipo"
        '
        'cmbCodEquipoDel
        '
        Me.cmbCodEquipoDel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cmbCodEquipoDel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCodEquipoDel.FormattingEnabled = True
        Me.cmbCodEquipoDel.Location = New System.Drawing.Point(157, 54)
        Me.cmbCodEquipoDel.Name = "cmbCodEquipoDel"
        Me.cmbCodEquipoDel.Size = New System.Drawing.Size(285, 26)
        Me.cmbCodEquipoDel.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Old English Text MT", 12.75!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(116, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(237, 21)
        Me.Label4.TabIndex = 20
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
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Control de Mantenimiento"
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
        Me.btnSalir.TabIndex = 22
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnVolver
        '
        Me.btnVolver.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnVolver.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnVolver.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnVolver.Font = New System.Drawing.Font("Bookman Old Style", 12.0!)
        Me.btnVolver.Location = New System.Drawing.Point(369, 516)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(97, 31)
        Me.btnVolver.TabIndex = 27
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = False
        '
        'txtPiezasAdd
        '
        Me.txtPiezasAdd.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtPiezasAdd.Location = New System.Drawing.Point(157, 184)
        Me.txtPiezasAdd.Name = "txtPiezasAdd"
        Me.txtPiezasAdd.Size = New System.Drawing.Size(285, 23)
        Me.txtPiezasAdd.TabIndex = 27
        '
        'Label22
        '
        Me.Label22.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(27, 187)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(50, 18)
        Me.Label22.TabIndex = 28
        Me.Label22.Text = "Piezas"
        '
        'txtPiezasMdf
        '
        Me.txtPiezasMdf.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtPiezasMdf.Location = New System.Drawing.Point(157, 189)
        Me.txtPiezasMdf.Name = "txtPiezasMdf"
        Me.txtPiezasMdf.Size = New System.Drawing.Size(285, 23)
        Me.txtPiezasMdf.TabIndex = 29
        '
        'Label24
        '
        Me.Label24.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(27, 192)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(50, 18)
        Me.Label24.TabIndex = 30
        Me.Label24.Text = "Piezas"
        '
        'txtPiezasBus
        '
        Me.txtPiezasBus.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtPiezasBus.Enabled = False
        Me.txtPiezasBus.Location = New System.Drawing.Point(157, 180)
        Me.txtPiezasBus.Name = "txtPiezasBus"
        Me.txtPiezasBus.Size = New System.Drawing.Size(285, 23)
        Me.txtPiezasBus.TabIndex = 46
        '
        'Label26
        '
        Me.Label26.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(27, 183)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(50, 18)
        Me.Label26.TabIndex = 47
        Me.Label26.Text = "Piezas"
        '
        'txtPiezasDel
        '
        Me.txtPiezasDel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtPiezasDel.Enabled = False
        Me.txtPiezasDel.Location = New System.Drawing.Point(157, 184)
        Me.txtPiezasDel.Name = "txtPiezasDel"
        Me.txtPiezasDel.Size = New System.Drawing.Size(285, 23)
        Me.txtPiezasDel.TabIndex = 53
        '
        'Label28
        '
        Me.Label28.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(27, 187)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(50, 18)
        Me.Label28.TabIndex = 54
        Me.Label28.Text = "Piezas"
        '
        'equipo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.CancelButton = Me.btnSalir
        Me.ClientSize = New System.Drawing.Size(484, 561)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.tabCtrlEquipo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnSalir)
        Me.Font = New System.Drawing.Font("Bookman Old Style", 9.75!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(500, 600)
        Me.Name = "equipo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administrar Equipos"
        Me.tabCtrlEquipo.ResumeLayout(False)
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
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents tabCtrlEquipo As System.Windows.Forms.TabControl
    Friend WithEvents tabAnadir As System.Windows.Forms.TabPage
    Friend WithEvents btnAnadir As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtModeloAdd As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtMarcaAdd As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tabModificar As System.Windows.Forms.TabPage
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtModeloMdf As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtMarcaMdf As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cmbCodEquipoMdf As System.Windows.Forms.ComboBox
    Friend WithEvents tabBuscar As System.Windows.Forms.TabPage
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents lblDescMantBus As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents lblTipoMantBus As System.Windows.Forms.Label
    Friend WithEvents lblUltMantBus As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtModeloBus As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtMarcaBus As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents cmbCodEquipoBus As System.Windows.Forms.ComboBox
    Friend WithEvents tabEliminar As System.Windows.Forms.TabPage
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents lblDescMantDel As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents lblTipoMantDel As System.Windows.Forms.Label
    Friend WithEvents lblUltMantDel As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtModeloDel As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtMarcaDel As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents cmbCodEquipoDel As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents txtCodEquipoAdd As System.Windows.Forms.TextBox
    Friend WithEvents txtPiezasAdd As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtPiezasMdf As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtPiezasBus As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents txtPiezasDel As System.Windows.Forms.TextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
End Class
