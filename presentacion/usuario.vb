Imports entidad
Imports datos

Public Class usuario

    Dim fu As New Fusuario
    Dim eu As New Eusuario
    Public dt As New DataTable

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        mainMenu.Show()
        Me.Close()
    End Sub
    Private Sub cmbUsuarioDel_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbUsuarioDel.SelectedValueChanged
        If Me.cmbUsuarioDel.Text <> "" Then
            dt = fu.consultarRegistro("NombreUsuario", Me.cmbUsuarioDel.Text.ToString, "TUsuario", True)
            If dt.Rows.Count > 0 Then
                eu._nombreUsuario = dt(0)("NombreUsuario").ToString
                eu._contrasena = dt(0)("Contrasena").ToString
                eu._nombre = dt(0)("Nombre").ToString
                eu._apellido = dt(0)("Apellido").ToString
                eu._cedula = dt(0)("Cedula").ToString
                eu._tipo = dt(0)("Tipo").ToString

                Me.cmbUsuarioDel.Text = eu._nombreUsuario
                Me.txtContrasenaDel.Text = eu._contrasena
                Me.txtCedulaDel.Text = eu._cedula
                Me.txtNombreDel.Text = eu._nombre
                Me.txtApellidoDel.Text = eu._apellido
                If eu._tipo = "Administrador" Then
                    Me.radioAdminDel.Checked = True
                Else
                    Me.radioEstandarDel.Checked = True
                End If
                eliminarVacioCmb(Me.cmbUsuarioDel)
            End If
        Else
            limpiarControles("Del")
        End If
    End Sub

    Private Sub btnAnadir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnadir.Click
        If Me.txtUsuarioAdd.Text <> "" And Me.txtContrasenaAdd.Text <> "" And Me.txtCedulaAdd.Text <> "" And Me.txtNombreAdd.Text <> "" And Me.txtApellidoAdd.Text <> "" And (Me.radioAdminAdd.Checked Or Me.radioEstandarAdd.Checked) Then
            If (Me.txtUsuarioAdd.TextLength >= 6) And (Me.txtUsuarioAdd.TextLength <= 25) Then
                If (Me.txtContrasenaAdd.TextLength >= 6) And (Me.txtContrasenaAdd.TextLength <= 30) Then
                    eu._nombreUsuario = Me.txtUsuarioAdd.Text
                    eu._nombre = Me.txtNombreAdd.Text
                    eu._apellido = Me.txtApellidoAdd.Text
                    eu._cedula = Me.txtCedulaAdd.Text
                    If Me.radioAdminAdd.Checked Then
                        eu._tipo = "Administrador"
                    Else
                        eu._tipo = "Usuario"
                    End If
                    eu._contrasena = Me.txtContrasenaAdd.Text

                    fu.agregar(eu._nombreUsuario, eu._contrasena, eu._cedula, eu._nombre, eu._apellido, eu._tipo)

                    MsgBox("El usuario se ha agregado correctamente.", MsgBoxStyle.Information, "Ejecución correcta")
                    llenarCmb(Me.cmbUsuarioMdf, "NombreUsuario", "TUsuario")
                    llenarCmb(Me.cmbUsuarioBus, "NombreUsuario", "TUsuario")
                    llenarCmb(Me.cmbUsuarioDel, "NombreUsuario", "TUsuario")
                    limpiarControles("Add")
                Else
                    MsgBox("La contraseña del usuario no puede ser menor a 6 caracteres ni mayor a 30", MsgBoxStyle.Information, "Error")
                End If
            Else
                MsgBox("El nombre de usuario no puede ser menor a 6 caracteres ni mayor a 25", MsgBoxStyle.Information, "Error")
            End If
        Else
            MsgBox("Tiene que llenar todos los campos para añadir un usuario", MsgBoxStyle.Critical, "Le falta un campo por llenar")
        End If
    End Sub
    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        If Me.cmbUsuarioMdf.Text <> "" And Me.txtContrasenaMdf.Text <> "" And Me.txtCedulaMdf.Text <> "" And Me.txtNombreMdf.Text <> "" And Me.txtApellidoMdf.Text <> "" And (Me.radioAdminMdf.Checked Or Me.radioEstandarMdf.Checked) Then
            If (Me.txtContrasenaMdf.TextLength >= 6) And (Me.txtContrasenaMdf.TextLength <= 30) Then
                eu._nombreUsuario = Me.cmbUsuarioMdf.Text
                eu._nombre = Me.txtNombreMdf.Text
                eu._apellido = Me.txtApellidoMdf.Text
                eu._cedula = Me.txtCedulaMdf.Text
                If Me.radioAdminMdf.Checked Then
                    eu._tipo = "Administrador"
                Else
                    eu._tipo = "Usuario"
                End If
                eu._contrasena = txtContrasenaMdf.Text

                fu.modificar(eu._nombreUsuario, eu._contrasena, eu._cedula, eu._nombre, eu._apellido, eu._tipo)
                MsgBox("Se ha modificado correctamente el usuario.", MsgBoxStyle.OkOnly, "Modificación corecta")
                limpiarControles("Mdf")
            Else
                MsgBox("La contraseña del usuario no puede ser menor a 6 caracteres ni mayor a 30", MsgBoxStyle.Information, "Error")
            End If
        Else
            MsgBox("Alguno de los campos está vacio. Para añadir un equipo tiene que llenar todos los datos.", MsgBoxStyle.Information, "Atención")
        End If
    End Sub


    Private Sub limpiarControles(ByVal tab As String)
        eu._nombreUsuario = ""
        eu._nombre = ""
        eu._apellido = ""
        eu._cedula = ""
        eu._tipo = ""
        eu._contrasena = ""
        If tab = "Add" Then
            Me.txtUsuarioAdd.Text = eu._nombreUsuario
            Me.txtContrasenaAdd.Text = eu._contrasena
            Me.txtCedulaAdd.Text = eu._cedula
            Me.txtNombreAdd.Text = eu._nombre
            Me.txtApellidoAdd.Text = eu._apellido
            Me.radioAdminAdd.Checked = False
            Me.radioEstandarAdd.Checked = False
        ElseIf tab = "Mdf" Then
            Me.cmbUsuarioMdf.Text = eu._nombreUsuario
            Me.txtContrasenaMdf.Text = eu._contrasena
            Me.txtCedulaMdf.Text = eu._cedula
            Me.txtNombreMdf.Text = eu._nombre
            Me.txtApellidoMdf.Text = eu._apellido
            Me.radioAdminMdf.Checked = False
            Me.radioEstandarMdf.Checked = False
        ElseIf tab = "Bus" Then
            Me.cmbUsuarioBus.Text = eu._nombreUsuario
            Me.txtContrasenaBus.Text = eu._contrasena
            Me.txtCedulaBus.Text = eu._cedula
            Me.txtNombreBus.Text = eu._nombre
            Me.txtApellidoBus.Text = eu._apellido
            Me.radioAdminBus.Checked = False
            Me.radioEstandarBus.Checked = False
        ElseIf tab = "Del" Then
            Me.cmbUsuarioDel.Text = eu._nombreUsuario
            Me.txtContrasenaDel.Text = eu._contrasena
            Me.txtCedulaDel.Text = eu._cedula
            Me.txtNombreDel.Text = eu._nombre
            Me.txtApellidoDel.Text = eu._apellido
            Me.radioAdminDel.Checked = False
            Me.radioEstandarDel.Checked = False
        End If
    End Sub

    Private Sub equipo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llenarCmb(Me.cmbUsuarioMdf, "NombreUsuario", "TUsuario")
        llenarCmb(Me.cmbUsuarioBus, "NombreUsuario", "TUsuario")
        llenarCmb(Me.cmbUsuarioDel, "NombreUsuario", "TUsuario")
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        If Me.cmbUsuarioBus.Text <> "" Then
            dt = fu.consultarRegistro("NombreUsuario", Me.cmbUsuarioBus.Text.ToString, "TUsuario", True)
            If dt.Rows.Count > 0 Then

                eu._contrasena = dt(0)("Contrasena").ToString
                eu._nombre = dt(0)("Nombre").ToString
                eu._apellido = dt(0)("Apellido").ToString
                eu._cedula = dt(0)("Cedula").ToString
                eu._tipo = dt(0)("Tipo").ToString

                Me.txtContrasenaBus.Text = eu._contrasena
                Me.txtCedulaBus.Text = eu._cedula
                Me.txtNombreBus.Text = eu._nombre
                Me.txtApellidoBus.Text = eu._apellido
                If eu._tipo = "Administrador" Then
                    Me.radioAdminBus.Checked = True
                Else
                    Me.radioEstandarBus.Checked = True
                End If
                eliminarVacioCmb(Me.cmbUsuarioBus)
            End If
        Else
            limpiarControles("Bus")
        End If
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Dim eliminar As Integer
        eliminar = MsgBox("¿Está seguro que desea eliminar este usuario?", MsgBoxStyle.OkCancel, "Eliminar usuario")

        If eliminar = 1 Then
            If Me.cmbUsuarioDel.Text.ToString <> "" Then
                eu._nombreUsuario = Me.cmbUsuarioDel.Text

                Try
                    fu.eliminar(eu._nombreUsuario.ToString)
                    MsgBox("Se ha eliminado correctamente el usuario.", MsgBoxStyle.OkOnly, "Eliminación corecta")

                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try


                llenarCmb(Me.cmbUsuarioMdf, "NombreUsuario", "TUsuario")
                llenarCmb(Me.cmbUsuarioBus, "NombreUsuario", "TUsuario")
                llenarCmb(Me.cmbUsuarioDel, "NombreUsuario", "TUsuario")
                limpiarControles("Del")
            Else
                MsgBox("Es necesario elegir el nombre del usuario para eliminar sus datos", MsgBoxStyle.Information, "No eligió el nombre del usuario")
            End If
        End If
    End Sub

   
    Private Sub txtApellidoAdd_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtApellidoAdd.KeyPress
        soloLetras(e)
    End Sub
    Private Sub txtApellidoMdf_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtApellidoMdf.KeyPress
        soloLetras(e)
    End Sub
    Private Sub txtCedulaAdd_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCedulaAdd.KeyPress
        soloNumeros(e)
    End Sub
    Private Sub txtCedulaMdf_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCedulaMdf.KeyPress
        soloNumeros(e)
    End Sub
    Private Sub txtContrasenaAdd_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtContrasenaAdd.KeyPress
        soloNumerosLetrasYCaracteres(e)
    End Sub
    Private Sub txtContrasenaMdf_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtContrasenaMdf.KeyPress
        soloNumerosLetrasYCaracteres(e)
    End Sub
    Private Sub txtNombreAdd_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombreAdd.KeyPress
        soloLetras(e)
    End Sub
    Private Sub txtNombreMdf_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombreMdf.KeyPress
        soloLetras(e)
    End Sub
    Private Sub txtUsuarioAdd_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUsuarioAdd.KeyPress
        soloNumerosYletras(e)
    End Sub

    Private Sub cmbUsuarioMdf_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbUsuarioMdf.SelectedValueChanged
        If Me.cmbUsuarioMdf.Text <> "" Then
            dt = fu.consultarRegistro("NombreUsuario", Me.cmbUsuarioMdf.Text.ToString, "TUsuario", True)
            If dt.Rows.Count > 0 Then
                eu._nombreUsuario = dt(0)("NombreUsuario").ToString
                eu._contrasena = dt(0)("Contrasena").ToString
                eu._nombre = dt(0)("Nombre").ToString
                eu._apellido = dt(0)("Apellido").ToString
                eu._cedula = dt(0)("Cedula").ToString
                eu._tipo = dt(0)("Tipo").ToString

                Me.cmbUsuarioMdf.Text = eu._nombreUsuario
                Me.txtContrasenaMdf.Text = eu._contrasena
                Me.txtCedulaMdf.Text = eu._cedula
                Me.txtNombreMdf.Text = eu._nombre
                Me.txtApellidoMdf.Text = eu._apellido
                If eu._tipo = "Administrador" Then
                    Me.radioAdminMdf.Checked = True
                Else
                    Me.radioEstandarMdf.Checked = True
                End If
                eliminarVacioCmb(Me.cmbUsuarioMdf)
            End If
        Else
            limpiarControles("Mdf")
        End If
    End Sub
End Class