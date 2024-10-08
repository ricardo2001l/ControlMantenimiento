Imports entidad

Public Class Fusuario
    Inherits Fgeneral

    Public Function validarUsuario(ByVal dts As Eusuario) As DataTable
        conectar()
        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        sql = "SELECT * FROM TUsuario WHERE NombreUsuario='" & dts._nombreUsuario & "' AND Contrasena='" & dts._contrasena & "';"
        cmd.CommandText = Sql
        Try
            cmd.ExecuteNonQuery()
            Using dt As New DataTable
                Using da As New OleDb.OleDbDataAdapter(cmd)
                    da.Fill(dt)
                    desconectar()
                    Return dt
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.ToString)
            Return Nothing
        End Try
    End Function

    Public Sub agregar(ByVal nombreUsuario As String, ByVal clave As String, ByVal cedula As String, ByVal nombre As String, ByVal apellido As String, ByVal tipo As String)
        Dim yaExiste = existe("NombreUsuario", "TUsuario", nombreUsuario)

        If Not yaExiste Then
            conectar()

            cmd.Connection = conn
            cmd.CommandType = CommandType.Text
            'Dim Eclave As String = generarClaveSHA1(clave)

            sql = "INSERT INTO TUsuario (NombreUsuario, Cedula, Contrasena, Nombre, Apellido, Tipo)"
            sql += "VALUES ('" & nombreUsuario & "','" & cedula & "','" & clave & "','" & nombre & "','" & apellido & "','" & tipo & "');"
            cmd.CommandText = sql
            Try
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            desconectar()
        Else
            MsgBox("El nombre de usuario ya existe, elija otro", MsgBoxStyle.Critical, "ERROR")
        End If
    End Sub

    Public Sub modificar(ByVal nombreUsuario As String, ByVal clave As String, ByVal cedula As String, ByVal nombre As String, ByVal apellido As String, ByVal tipo As String)
        conectar()

        ' MODIFICA LA TABLA INVENTARIO COMPRA
        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        sql = "UPDATE TUsuario "
        sql += "SET Cedula='" & cedula & "', "
        sql += "Nombre='" & nombre & "', "
        sql += "Apellido='" & apellido & "', "
        'If modificarClave Then
        'Dim Eclave As String = generarClaveSHA1(clave)
        sql += "Contrasena='" & clave & "', "
        'End If
        sql += "Tipo='" & tipo & "' "
        sql += "WHERE NombreUsuario='" & nombreUsuario & "';"
        cmd.CommandText = sql

        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        desconectar()
    End Sub
    Public Sub eliminar(ByVal NombreUsuario As String)
        Dim yaExiste = existe("NombreUsuario", "TUsuario", NombreUsuario)

        If yaExiste Then
            conectar()

            cmd.Connection = conn
            cmd.CommandType = CommandType.Text

            sql = "DELETE FROM TUsuario WHERE NombreUsuario='" & NombreUsuario & "'"
            cmd.CommandText = sql
            Try
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        Else
            MsgBox("El nombre de usuario ingresado no existe", MsgBoxStyle.Information, "Usuario no existe")
        End If
        desconectar()

    End Sub
End Class
