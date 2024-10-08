Public Class Fequipo
    Inherits Fgeneral
    Public EXEerror As Boolean
    Public Sub agregar(ByVal codEquipo As String, ByVal marca As String, ByVal modelo As String, ByVal piezas As String)
        Dim yaExiste = existe("CodEquipo", "TEquipo", codEquipo)

        If yaExiste Then
            MsgBox("El código del equipo ya existe. Elija otro nombre.", MsgBoxStyle.Information, "Atención")
        Else
            conectar()

            cmd.Connection = conn
            cmd.CommandType = CommandType.Text
            sql = "INSERT INTO TEquipo (CodEquipo, Marca, Modelo, Piezas)"
            sql += "VALUES ('" & codEquipo & "','" & marca & "','" & modelo & "','" & piezas & "');"
            cmd.CommandText = sql

            Try
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
        desconectar()
    End Sub

    Public Sub modificar(ByVal codEquipo As String, ByVal marca As String, ByVal modelo As String, ByVal piezas As String)
        Dim yaExiste = existe("CodEquipo", "TEquipo", codEquipo)

        If yaExiste Then
            conectar()

            cmd.Connection = conn
            cmd.CommandType = CommandType.Text

            sql = "UPDATE TEquipo "
            sql += "SET marca='" & marca & "', "
            sql += "Piezas='" & piezas & "', "
            sql += "modelo='" & modelo & "' "
            sql += "WHERE CodEquipo='" & codEquipo & "'"

            cmd.CommandText = sql


            Try
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        Else
            MsgBox("El equipo con el código ingresado no existe", MsgBoxStyle.Information, "Atención")
        End If
        desconectar()
    End Sub
    Public Sub eliminar(ByVal codEquipo As String)
        Dim yaExiste = existe("CodEquipo", "TEquipo", codEquipo)

        If yaExiste Then
            conectar()

            cmd.Connection = conn
            cmd.CommandType = CommandType.Text

            sql = "DELETE FROM TEquipo WHERE CodEquipo='" & codEquipo & "'"
            cmd.CommandText = sql
            Try
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        Else
            MsgBox("El equipo con el código ingresado no existe", MsgBoxStyle.Information, "Atención")
        End If
        desconectar()

    End Sub
End Class
