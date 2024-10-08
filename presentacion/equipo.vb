Imports entidad
Imports datos

Public Class equipo

    Dim fe As New Fequipo
    Dim ee As New Eequipo
    Dim em As New Emantenimiento
    Public dt As New DataTable
    Public dt2 As New DataTable
    Public dt3 As New DataTable
    Public EXEerror As Boolean

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        mainMenu.Show()
        Me.Close()
    End Sub

    Private Sub cmbCodEquipoDel_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCodEquipoDel.SelectedValueChanged
        If Me.cmbCodEquipoDel.Text <> "" Then
            dt = fe.consultarRegistro("CodEquipo", Me.cmbCodEquipoDel.Text.ToString, "TEquipo", True)
            If dt.Rows.Count > 0 Then
                ee._codEquipo = dt(0)("CodEquipo").ToString
                ee._marca = dt(0)("Marca").ToString
                ee._modelo = dt(0)("Modelo").ToString
                ee._piezas = dt(0)("Piezas").ToString



                Me.txtMarcaDel.Text = ee._marca
                Me.txtModeloDel.Text = ee._modelo
                Me.txtPiezasDel.Text = ee._piezas
                eliminarVacioCmb(Me.cmbCodEquipoDel)

                dt2 = fe.lastDate("Fecha", "TMantenimiento", ee._codEquipo)
                Try
                    If dt2(0)("Fecha").ToString <> "" Then
                        em._fecha = CDate(dt2(0)("Fecha").ToString)
                        Dim fecha As String
                        If CInt(em._fecha.Day) <= 12 Then
                            fecha = em._fecha.Month.ToString & "/" & em._fecha.Day.ToString & "/" & em._fecha.Year.ToString
                        Else
                            fecha = em._fecha.Day.ToString & "/" & em._fecha.Month.ToString & "/" & em._fecha.Year.ToString
                        End If
                        dt3 = fe.consultarRegistro("CodEquipo", "Fecha", ee._codEquipo, fecha, "TMantenimiento", True)
                        If dt2.Rows.Count > 0 Then
                            If dt3.Rows.Count > 0 Then
                                em._esPreventiva = CBool(dt3(0)("EsPreventiva").ToString)
                                em._descripcion = dt3(0)("Descripcion").ToString

                                Me.lblUltMantDel.Text = em._fecha.Day.ToString & "/" & em._fecha.Month.ToString & "/" & em._fecha.Year.ToString
                                Me.lblDescMantDel.Text = em._descripcion
                                If em._esPreventiva Then
                                    Me.lblTipoMantDel.Text = "Preventiva"
                                Else
                                    Me.lblTipoMantDel.Text = "Correctiva"
                                End If
                            End If
                        End If
                    End If
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End If
        Else
            limpiarControles("Del")
        End If
    End Sub

    Private Sub btnAnadir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnadir.Click
        If Me.txtCodEquipoAdd.Text <> "" And Me.txtMarcaAdd.Text <> "" And Me.txtModeloAdd.Text <> "" Then
            If (Me.txtCodEquipoAdd.TextLength >= 6) And (Me.txtCodEquipoAdd.TextLength <= 20) Then
                If (Me.txtMarcaAdd.TextLength >= 6) And (Me.txtMarcaAdd.TextLength <= 15) Then
                    If (Me.txtModeloAdd.TextLength >= 6) And (Me.txtModeloAdd.TextLength <= 15) Then
                        ee._codEquipo = Me.txtCodEquipoAdd.Text
                        ee._marca = Me.txtMarcaAdd.Text
                        ee._modelo = Me.txtModeloAdd.Text
                        ee._piezas = Me.txtPiezasAdd.Text

                        fe.agregar(ee._codEquipo, ee._marca, ee._modelo, ee._piezas)
                        MsgBox("Se ha añadido correctamente el equipo.", MsgBoxStyle.OkOnly, "Adición corecta")

                        limpiarControles("Add")
                        llenarCmb(Me.cmbCodEquipoMdf, "CodEquipo", "TEquipo")
                        llenarCmb(Me.cmbCodEquipoBus, "CodEquipo", "TEquipo")
                        llenarCmb(Me.cmbCodEquipoDel, "CodEquipo", "TEquipo")
                    Else
                        MsgBox("El modelo del equipo no puede ser menor a 6 caracteres ni mayor a 15", MsgBoxStyle.Information, "Error")
                    End If
                Else
                    MsgBox("La marca del equipo no puede ser menor a 6 caracteres ni mayor a 15", MsgBoxStyle.Information, "Error")
                End If
            Else
                MsgBox("El Código del equipo no puede ser menor a 6 caracteres ni mayor a 20", MsgBoxStyle.Information, "Error")
            End If
        Else
            MsgBox("Alguno de los campos está vacio. Para añadir un equipo tiene que llenar todos los datos.", MsgBoxStyle.Information, "Atención")
        End If
    End Sub
    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        If Me.cmbCodEquipoMdf.Text <> "" And Me.txtMarcaMdf.Text <> "" And Me.txtModeloMdf.Text <> "" Then
            If (Me.txtMarcaMdf.TextLength >= 6) And (Me.txtMarcaMdf.TextLength <= 15) Then
                If (Me.txtModeloMdf.TextLength >= 6) And (Me.txtModeloMdf.TextLength <= 15) Then
                    ee._codEquipo = Me.cmbCodEquipoMdf.Text
                    ee._marca = Me.txtMarcaMdf.Text
                    ee._modelo = Me.txtModeloMdf.Text
                    ee._piezas = Me.txtPiezasMdf.Text

                    fe.modificar(ee._codEquipo, ee._marca, ee._modelo, ee._piezas)
                    MsgBox("Se ha modificado correctamente el equipo.", MsgBoxStyle.OkOnly, "Modificación corecta")
                    limpiarControles("Mdf")
                Else
                    MsgBox("El modelo del equipo no puede ser menor a 6 caracteres ni mayor a 15", MsgBoxStyle.Information, "Error")
                End If
            Else
                MsgBox("La marca del equipo no puede ser menor a 6 caracteres ni mayor a 15", MsgBoxStyle.Information, "Error")
            End If
        Else
            MsgBox("Alguno de los campos está vacio. Para añadir un equipo tiene que llenar todos los datos.", MsgBoxStyle.Information, "Atención")
        End If
    End Sub
    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        If Me.cmbCodEquipoBus.Text <> "" Then
            dt = fe.consultarRegistro("CodEquipo", Me.cmbCodEquipoBus.Text.ToString, "TEquipo", True)
            If dt.Rows.Count > 0 Then

                ee._codEquipo = dt(0)("CodEquipo").ToString
                ee._marca = dt(0)("Marca").ToString
                ee._modelo = dt(0)("Modelo").ToString
                ee._piezas = dt(0)("Piezas").ToString

                Me.txtMarcaBus.Text = ee._marca
                Me.txtModeloBus.Text = ee._modelo
                Me.txtPiezasBus.Text = ee._piezas

                eliminarVacioCmb(Me.cmbCodEquipoBus)

                dt2 = fe.lastDate("Fecha", "TMantenimiento", ee._codEquipo)
                Try
                    If dt2(0)("Fecha").ToString <> "" Then
                        em._fecha = CDate(dt2(0)("Fecha").ToString)
                        Dim fecha As String
                        If CInt(em._fecha.Day) <= 12 Then
                            fecha = em._fecha.Month.ToString & "/" & em._fecha.Day.ToString & "/" & em._fecha.Year.ToString
                        Else
                            fecha = em._fecha.Day.ToString & "/" & em._fecha.Month.ToString & "/" & em._fecha.Year.ToString
                        End If
                        dt3 = fe.consultarRegistro("CodEquipo", "Fecha", ee._codEquipo, fecha, "TMantenimiento", True)
                        If dt2.Rows.Count > 0 Then
                            If dt3.Rows.Count > 0 Then
                                em._esPreventiva = CBool(dt3(0)("EsPreventiva").ToString)
                                em._descripcion = dt3(0)("Descripcion").ToString

                                Me.lblUltMantBus.Text = em._fecha.Day.ToString & "/" & em._fecha.Month.ToString & "/" & em._fecha.Year.ToString
                                Me.lblDescMantBus.Text = em._descripcion
                                If em._esPreventiva Then
                                    Me.lblTipoMantBus.Text = "Preventiva"
                                Else
                                    Me.lblTipoMantBus.Text = "Correctiva"
                                End If
                            End If
                        End If
                    End If
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End If
        Else
            limpiarControles("Bus")
            MsgBox("No se ha encontrado lo que buscaba, verifique los datos ingresados.", MsgBoxStyle.OkOnly, "Busqueda erronea")
        End If
    End Sub
    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Dim eliminar As Integer
        eliminar = MsgBox("¿Está seguro que desea eliminar este equipo?", MsgBoxStyle.OkCancel, "Eliminar equipo")

        If eliminar = 1 Then
            If Me.cmbCodEquipoDel.Text.ToString <> "" Then
                ee._codEquipo = Me.cmbCodEquipoDel.Text

                Try
                    fe.eliminar(ee._codEquipo.ToString)
                    MsgBox("Se ha eliminado correctamente el equipo.", MsgBoxStyle.OkOnly, "Eliminación corecta")

                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try


                llenarCmb(Me.cmbCodEquipoMdf, "CodEquipo", "TEquipo")
                llenarCmb(Me.cmbCodEquipoBus, "CodEquipo", "TEquipo")
                llenarCmb(Me.cmbCodEquipoDel, "CodEquipo", "TEquipo")
                limpiarControles("Del")
            Else
                MsgBox("Es necesario elegir un código del equipo para eliminar sus datos", MsgBoxStyle.Information, "No eligió el código del equipo")
            End If
        End If
    End Sub

    Private Sub limpiarControles(ByVal tab As String)
        ee._codEquipo = ""
        ee._marca = ""
        ee._modelo = ""
        ee._piezas = ""
        If tab = "Add" Then
            Me.txtCodEquipoAdd.Text = ee._codEquipo
            Me.txtMarcaAdd.Text = ee._marca
            Me.txtModeloAdd.Text = ee._modelo
            Me.txtPiezasAdd.Text = ee._piezas
        ElseIf tab = "Mdf" Then
            Me.cmbCodEquipoMdf.Text = ee._codEquipo
            Me.txtMarcaMdf.Text = ee._marca
            Me.txtModeloMdf.Text = ee._modelo
            Me.txtPiezasMdf.Text = ee._piezas
        ElseIf tab = "Bus" Then
            Me.cmbCodEquipoBus.Text = ee._codEquipo
            Me.txtMarcaBus.Text = ee._marca
            Me.txtModeloBus.Text = ee._modelo
            Me.txtPiezasBus.Text = ee._piezas
        ElseIf tab = "Del" Then
            Me.cmbCodEquipoDel.Text = ee._codEquipo
            Me.txtMarcaDel.Text = ee._marca
            Me.txtModeloDel.Text = ee._modelo
            Me.txtPiezasDel.Text = ee._piezas
        End If
    End Sub

    Private Sub equipo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llenarCmb(Me.cmbCodEquipoMdf, "CodEquipo", "TEquipo")
        llenarCmb(Me.cmbCodEquipoBus, "CodEquipo", "TEquipo")
        llenarCmb(Me.cmbCodEquipoDel, "CodEquipo", "TEquipo")
    End Sub

    
    Private Sub txtMarcaAdd_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMarcaAdd.KeyPress
        soloLetras(e)
    End Sub
    Private Sub txtModeloAdd_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtModeloAdd.KeyPress
        soloNumerosYletras(e)
    End Sub


    Private Sub txtMarcaMdf_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMarcaMdf.KeyPress
        soloLetras(e)
    End Sub
    Private Sub txtModeloMdf_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtModeloMdf.KeyPress
        soloNumerosYletras(e)
    End Sub


    Private Sub txtMarcaBus_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMarcaBus.KeyPress
        soloLetras(e)
    End Sub
    Private Sub txtModeloBus_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtModeloBus.KeyPress
        soloNumerosYletras(e)
    End Sub

    Private Sub txtMarcaDel_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMarcaDel.KeyPress
        soloLetras(e)
    End Sub
    Private Sub txtModeloDel_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtModeloDel.KeyPress
        soloNumerosYletras(e)
    End Sub

    Private Sub txtCodEquipoAdd_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodEquipoAdd.KeyPress
        soloNumerosletrasYGuiones(e)
    End Sub

    Private Sub cmbCodEquipoMdf_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCodEquipoMdf.SelectedValueChanged
        If Me.cmbCodEquipoMdf.Text <> "" Then
            dt = fe.consultarRegistro("CodEquipo", Me.cmbCodEquipoMdf.Text.ToString, "TEquipo", True)
            If dt.Rows.Count > 0 Then
                ee._codEquipo = dt(0)("CodEquipo").ToString
                ee._marca = dt(0)("Marca").ToString
                ee._modelo = dt(0)("Modelo").ToString
                ee._piezas = dt(0)("Piezas").ToString


                Me.txtMarcaMdf.Text = ee._marca
                Me.txtModeloMdf.Text = ee._modelo
                Me.txtPiezasMdf.Text = ee._piezas

                eliminarVacioCmb(Me.cmbCodEquipoMdf)

                dt2 = fe.lastDate("Fecha", "TMantenimiento", ee._codEquipo)

            End If
        Else
            limpiarControles("Mdf")
        End If
    End Sub
End Class