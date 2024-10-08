Imports entidad
Imports datos

Public Class mantenimiento

    Dim fm As New FMantenimiento
    Dim em As New Emantenimiento
    Dim ee As New Eequipo
    Public dt As New DataTable
    Public dt2 As New DataTable

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        mainMenu.Show()
        Me.Close()
    End Sub


    Private Sub cmbCodEquipoAdd_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCodEquipoAdd.SelectedValueChanged
        If Me.cmbCodEquipoAdd.Text <> "" Then
            dt = fm.consultarRegistro("CodEquipo", Me.cmbCodEquipoAdd.Text.ToString, "TEquipo", True)
            If dt.Rows.Count > 0 Then
                ee._marca = dt(0)("Marca").ToString
                ee._modelo = dt(0)("Modelo").ToString

                Me.lblMarcaAdd.Text = ee._marca
                Me.lblModeloAdd.Text = ee._modelo
                eliminarVacioCmb(Me.cmbCodEquipoAdd)
            End If
        Else
            limpiarControles("Add")
        End If
    End Sub

    Private Sub cmbCodEquipoBus_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCodEquipoBus.SelectedValueChanged
        If Me.cmbCodEquipoBus.Text <> "" Then
            dt = fm.consultarRegistro("CodEquipo", Me.cmbCodEquipoBus.Text.ToString, "TEquipo", True)
            If dt.Rows.Count > 0 Then
                ee._marca = dt(0)("Marca").ToString
                ee._modelo = dt(0)("Modelo").ToString

                Me.lblMarcaBus.Text = ee._marca
                Me.lblModeloBus.Text = ee._modelo
                eliminarVacioCmb(Me.cmbCodEquipoBus)
            End If
        Else
            limpiarControles("Bus")
        End If
    End Sub


    Private Sub cmbCodEquipoMdf_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCodEquipoMdf.SelectedValueChanged
        If Me.cmbCodEquipoMdf.Text <> "" Then
            dt = fm.consultarRegistro("CodEquipo", Me.cmbCodEquipoMdf.Text.ToString, "TEquipo", True)
            If dt.Rows.Count > 0 Then
                ee._marca = dt(0)("Marca").ToString
                ee._modelo = dt(0)("Modelo").ToString

                Me.lblMarcaMdf.Text = ee._marca
                Me.lblModeloMdf.Text = ee._modelo
                eliminarVacioCmb(Me.cmbCodEquipoMdf)
            End If
        Else
            limpiarControles("Mdf")
        End If
    End Sub

    Private Sub cmbCodEquipoDel_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCodEquipoDel.SelectedValueChanged
        If Me.cmbCodEquipoDel.Text <> "" Then
            dt = fm.consultarRegistro("CodEquipo", Me.cmbCodEquipoDel.Text.ToString, "TEquipo", True)

            If dt.Rows.Count > 0 Then
                ee._marca = dt(0)("Marca").ToString
                ee._modelo = dt(0)("Modelo").ToString

                Me.lblMarcaDel.Text = ee._marca
                Me.lblModeloDel.Text = ee._modelo
                eliminarVacioCmb(Me.cmbCodEquipoDel)
            End If
        Else
            limpiarControles("Del")
        End If
    End Sub

    Private Sub fechaMantDel_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles fechaMantDel.ValueChanged
        If Me.cmbCodEquipoDel.Text <> "" Then
            em._codEquipo = Me.cmbCodEquipoDel.Text
            Dim fecha As String
            'If CInt(Me.fechaMantDel.Value.Day) <= 12 Then
            '    fecha = Me.fechaMantDel.Value.Day.ToString & "/" & Me.fechaMantDel.Value.Month.ToString & "/" & Me.fechaMantDel.Value.Year.ToString
            'Else
            fecha = Me.fechaMantDel.Value.Month.ToString & "/" & Me.fechaMantDel.Value.Day.ToString & "/" & Me.fechaMantDel.Value.Year.ToString
            'End If

            'If CInt(Me.fechaMantDel.Value.Month) = 3 Then
            '    fecha = Me.fechaMantDel.Value.Month.ToString & "/" & Me.fechaMantDel.Value.Day.ToString & "/" & Me.fechaMantDel.Value.Year.ToString
            'End If
            dt2 = fm.consultarRegistro("CodEquipo", "Fecha", em._codEquipo, fecha, "TMantenimiento", True)
            If dt2.Rows.Count > 0 Then
                em._esPreventiva = CBool(dt2(0)("EsPreventiva").ToString)
                em._descripcion = dt2(0)("Descripcion").ToString

                If em._esPreventiva Then
                    Me.radioCorrectivoDel.Checked = False
                    Me.radioPreventivoDel.Checked = True
                Else
                    Me.radioCorrectivoDel.Checked = True
                    Me.radioPreventivoDel.Checked = False
                End If
                Me.txtDescMantDel.Text = em._descripcion
                eliminarVacioCmb(Me.cmbCodEquipoDel)
            End If
        End If
    End Sub

    Private Sub btnAnadir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnadir.Click
        If Me.cmbCodEquipoAdd.Text <> "" And Me.txtDescMantAdd.Text <> "" And (Me.radioCorrectivoAdd.Checked Or Me.radioPreventivoAdd.Checked) Then
            If (Me.txtDescMantAdd.TextLength >= 6) And (Me.txtDescMantAdd.TextLength <= 254) Then
                em._codEquipo = Me.cmbCodEquipoAdd.Text
                em._descripcion = Me.txtDescMantAdd.Text
                If Me.radioCorrectivoAdd.Checked Then
                    em._esPreventiva = False
                Else
                    em._esPreventiva = True
                End If

                Dim fecha As String
                If CInt(Me.fechaMantAdd.Value.Day) <= 12 Then
                    fecha = Me.fechaMantAdd.Value.Day.ToString & "/" & Me.fechaMantAdd.Value.Month.ToString & "/" & Me.fechaMantAdd.Value.Year.ToString
                Else
                    fecha = Me.fechaMantAdd.Value.Month.ToString & "/" & Me.fechaMantAdd.Value.Day.ToString & "/" & Me.fechaMantAdd.Value.Year.ToString
                End If
                Dim EXEerror = fm.agregar(fecha, em._codEquipo, em._descripcion, em._esPreventiva)
                If Not EXEerror Then
                    MsgBox("Se ha añadido correctamente los datos del mantenimiento.", MsgBoxStyle.OkOnly, "Adición corecta")
                End If

                limpiarControles("Add")
                llenarCmb(Me.cmbCodEquipoAdd, "CodEquipo", "TEquipo")
                llenarCmb(Me.cmbCodEquipoMdf, "CodEquipo", "TEquipo")
                llenarCmb(Me.cmbCodEquipoBus, "CodEquipo", "TEquipo")
                llenarCmb(Me.cmbCodEquipoDel, "CodEquipo", "TEquipo")
            Else
                MsgBox("La descripción del mantenimiento no puede ser mayor a 254 caracteres ni menor a 6 caracteres", MsgBoxStyle.Information, "Error")
            End If
            Else
                MsgBox("Alguno de los campos está vacio. Para añadir un equipo tiene que llenar todos los datos.", MsgBoxStyle.Information, "Atención")
            End If
    End Sub


    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        If Me.cmbCodEquipoMdf.Text <> "" And Me.txtDescMantMdf.Text <> "" And (Me.radioCorrectivoMdf.Checked Or Me.radioPreventivoMdf.Checked) Then
            If (Me.txtDescMantMdf.TextLength >= 6) And (Me.txtDescMantMdf.TextLength <= 254) Then
                em._codEquipo = Me.cmbCodEquipoMdf.Text
                em._descripcion = Me.txtDescMantMdf.Text
                If Me.radioCorrectivoMdf.Checked Then
                    em._esPreventiva = False
                Else
                    em._esPreventiva = True
                End If

                Dim fecha As String
                If CInt(Me.fechaMantMdf.Value.Day) <= 12 Then
                    fecha = Me.fechaMantMdf.Value.Month.ToString & "/" & Me.fechaMantMdf.Value.Day.ToString & "/" & Me.fechaMantMdf.Value.Year.ToString
                Else
                    fecha = Me.fechaMantMdf.Value.Day.ToString & "/" & Me.fechaMantMdf.Value.Month.ToString & "/" & Me.fechaMantMdf.Value.Year.ToString
                End If
                Dim EXEerror = fm.modificar(fecha, em._codEquipo, em._descripcion, em._esPreventiva)
                If Not EXEerror Then
                    MsgBox("Se ha modificado correctamente el mantenimiento.", MsgBoxStyle.OkOnly, "Modificación corecta")
                End If
                limpiarControles("Mdf")
            Else
                MsgBox("La descripción del mantenimiento no puede ser mayor a 254 caracteres ni menor a 6 caracteres", MsgBoxStyle.Information, "Error")
            End If
            Else
                MsgBox("Alguno de los campos está vacio. Para añadir un equipo tiene que llenar todos los datos.", MsgBoxStyle.Information, "Atención")
            End If
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        If Me.cmbCodEquipoBus.Text <> "" Then
            em._codEquipo = Me.cmbCodEquipoBus.Text
            em._fecha = Me.fechaMantBus.Value
            Dim fecha As String
            'If CInt(Me.fechaMantBus.Value.Day) <= 12 Then
            '    fecha = Me.fechaMantBus.Value.Day.ToString & "/" & Me.fechaMantBus.Value.Month.ToString & "/" & Me.fechaMantBus.Value.Year.ToString
            'Else
            fecha = Me.fechaMantBus.Value.Month.ToString & "/" & Me.fechaMantBus.Value.Day.ToString & "/" & Me.fechaMantBus.Value.Year.ToString
            'End If

            'If CInt(Me.fechaMantBus.Value.Month) = 3 Then
            '    fecha = Me.fechaMantBus.Value.Month.ToString & "/" & Me.fechaMantBus.Value.Day.ToString & "/" & Me.fechaMantBus.Value.Year.ToString
            'End If


            dt = fm.consultarRegistro("CodEquipo", "Fecha", em._codEquipo, fecha.ToString, "TMantenimiento", True)
            If dt.Rows.Count > 0 Then
                em._esPreventiva = CBool(dt(0)("EsPreventiva").ToString)
                em._descripcion = dt(0)("Descripcion").ToString

                If em._esPreventiva Then
                    Me.radioCorrectivoBus.Checked = False
                    Me.radioPreventivoBus.Checked = True
                Else
                    Me.radioCorrectivoBus.Checked = True
                    Me.radioPreventivoBus.Checked = False
                End If
                Me.txtDescMantBus.Text = em._descripcion
                eliminarVacioCmb(Me.cmbCodEquipoBus)
            Else
                limpiarControles("Bus")
                llenarCmb(Me.cmbCodEquipoBus, "CodEquipo", "TEquipo")
                MsgBox("No se ha encontrado lo que buscaba, verifique los datos ingresados.", MsgBoxStyle.OkOnly, "Busqueda erronea")
            End If
        Else
            MsgBox("Alguno de los campos está vacio. Para añadir un equipo tiene que llenar todos los datos.", MsgBoxStyle.Information, "Atención")
        End If
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Dim eliminar As Integer
        eliminar = MsgBox("¿Está seguro que desea eliminar este mantenimiento?", MsgBoxStyle.OkCancel, "Eliminar equipo")

        If eliminar = 1 Then
            If Me.cmbCodEquipoDel.Text.ToString <> "" Then
                em._codEquipo = Me.cmbCodEquipoDel.Text

                Dim fecha As String
                'If CInt(Me.fechaMantDel.Value.Day) <= 12 Then
                '    fecha = Me.fechaMantDel.Value.Day.ToString & "/" & Me.fechaMantDel.Value.Month.ToString & "/" & Me.fechaMantDel.Value.Year.ToString
                'Else
                fecha = Me.fechaMantDel.Value.Month.ToString & "/" & Me.fechaMantDel.Value.Day.ToString & "/" & Me.fechaMantDel.Value.Year.ToString
                'End If

                'If CInt(Me.fechaMantDel.Value.Month) = 3 Then
                '    fecha = Me.fechaMantDel.Value.Month.ToString & "/" & Me.fechaMantDel.Value.Day.ToString & "/" & Me.fechaMantDel.Value.Year.ToString
                'End If
                Try
                    fm.eliminar(em._codEquipo.ToString, fecha)
                    MsgBox("Se ha eliminado correctamente el mantenimiento.", MsgBoxStyle.OkOnly, "Eliminación corecta")

                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try

                llenarCmb(Me.cmbCodEquipoMdf, "CodEquipo", "TEquipo")
                llenarCmb(Me.cmbCodEquipoMdf, "CodEquipo", "TEquipo")
                llenarCmb(Me.cmbCodEquipoBus, "CodEquipo", "TEquipo")
                llenarCmb(Me.cmbCodEquipoDel, "CodEquipo", "TEquipo")
                limpiarControles("Del")
            Else
                MsgBox("Es necesario elegir un código del equipo para eliminar sus datos", MsgBoxStyle.Information, "No eligió el código del equipo")
            End If
        End If
    End Sub
    Private Sub mantenimiento_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llenarCmb(Me.cmbCodEquipoAdd, "CodEquipo", "TEquipo")
        llenarCmb(Me.cmbCodEquipoMdf, "CodEquipo", "TEquipo")
        llenarCmb(Me.cmbCodEquipoBus, "CodEquipo", "TEquipo")
        llenarCmb(Me.cmbCodEquipoDel, "CodEquipo", "TEquipo")
    End Sub

    Private Sub limpiarControles(ByVal tab As String)
        em._idMantenimiento = ""
        em._fecha = Date.Today
        em._codEquipo = ""
        em._descripcion = ""
        em._esPreventiva = False

        ee._codEquipo = ""
        ee._marca = "La marca de este equipo no está registrada"
        ee._modelo = "El modelo de este equipo no está registrada"
        If tab = "Add" Then
            Me.cmbCodEquipoAdd.Text = em._codEquipo
            Me.lblMarcaAdd.Text = ee._marca
            Me.lblModeloAdd.Text = ee._modelo
            Me.fechaMantAdd.Text = em._fecha.ToString
            Me.radioCorrectivoAdd.Checked = False
            Me.radioPreventivoAdd.Checked = False
            Me.txtDescMantAdd.Text = em._descripcion
        ElseIf tab = "Mdf" Then
            Me.cmbCodEquipoMdf.Text = em._codEquipo
            Me.lblMarcaMdf.Text = ee._marca
            Me.lblModeloMdf.Text = ee._modelo
            Me.fechaMantMdf.Text = em._fecha.ToString
            Me.radioCorrectivoMdf.Checked = False
            Me.radioPreventivoMdf.Checked = False
            Me.txtDescMantMdf.Text = em._descripcion
        ElseIf tab = "Bus" Then
            Me.cmbCodEquipoBus.Text = em._codEquipo
            Me.lblMarcaBus.Text = ee._marca
            Me.lblModeloBus.Text = ee._modelo
            Me.fechaMantBus.Text = em._fecha.ToString
            Me.radioCorrectivoBus.Checked = False
            Me.radioPreventivoBus.Checked = False
            Me.txtDescMantBus.Text = em._descripcion
        ElseIf tab = "Del" Then
            Me.cmbCodEquipoDel.Text = em._codEquipo
            Me.lblMarcaDel.Text = ee._marca
            Me.lblModeloDel.Text = ee._modelo
            Me.fechaMantDel.Text = em._fecha.ToString
            Me.radioCorrectivoDel.Checked = False
            Me.radioPreventivoDel.Checked = False
            Me.txtDescMantDel.Text = em._descripcion
        End If
    End Sub
End Class