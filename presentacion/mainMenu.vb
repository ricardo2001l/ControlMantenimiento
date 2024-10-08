Public Class mainMenu

    Private Sub mainMenu_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If acercaDe.Created Then
            acercaDe.Close()
        End If
    End Sub


    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnEquipo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEquipo.Click
        equipo.Show()
        Me.Close()
    End Sub

    Private Sub btnMantenimiento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMantenimiento.Click
        mantenimiento.Show()
        Me.Close()
    End Sub

    Private Sub btnInforme_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInforme.Click
        informe.Show()
        Me.Close()
    End Sub

    Private Sub btnUsuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUsuario.Click
        usuario.Show()
        Me.Close()
    End Sub

    Private Sub btnAyuda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAyuda.Click
        If Not (acercaDe.Created) Then
            acercaDe.Show()
        End If
    End Sub

    Private Sub btnCerrarSesion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrarSesion.Click
        iniciarSesion.Show()
        Me.Close()
    End Sub

    Private Sub btnBaseDeDatos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBaseDeDatos.Click
        baseDatos.Show()
        Me.Close()
    End Sub
End Class