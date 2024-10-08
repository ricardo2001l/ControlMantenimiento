Imports entidad
Imports datos

Public Class iniciarSesion

    Dim fu As New Fusuario
    Dim eu As New Eusuario

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnIniciar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIniciar.Click
        If Me.txtUsuario.Text <> "" And Me.txtContrasena.Text <> "" Then
            Dim dt As New DataTable

            eu._nombreUsuario = Me.txtUsuario.Text
            eu._contrasena = Me.txtContrasena.Text
            dt = fu.validarUsuario(eu)

            If dt.Rows.Count > 0 Then
                Dim tipo As String
                tipo = dt.Rows(0)("Tipo").ToString

                If tipo = "Usuario" Then
                    mainMenu.btnAyuda.Enabled = True
                    mainMenu.btnEquipo.Enabled = False
                    mainMenu.btnInforme.Enabled = True
                    mainMenu.btnMantenimiento.Enabled = True
                    mainMenu.btnUsuario.Enabled = False
                ElseIf tipo = "Administrador" Then
                    mainMenu.btnAyuda.Enabled = True
                    mainMenu.btnEquipo.Enabled = True
                    mainMenu.btnInforme.Enabled = True
                    mainMenu.btnMantenimiento.Enabled = True
                    mainMenu.btnUsuario.Enabled = True
                End If

                mainMenu.Show()
                Me.Close()
            Else
                MsgBox("Usuario o Contraseña erroneos.", MsgBoxStyle.Information, "Cuidado")
                limpiarCampos()
            End If
        Else
            MsgBox("Ingrese los datos requeridos en los campos.", MsgBoxStyle.Information, "No se pueden enviar campos vacíos")
        End If
    End Sub

    Private Sub iniciarSesion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub limpiarCampos()
        Me.txtUsuario.Text = ""
        Me.txtContrasena.Text = ""
    End Sub
End Class
