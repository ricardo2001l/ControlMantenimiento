Public Class Fmantenimiento
    Inherits Fgeneral
    Public EXEerror As Boolean

    Public Function agregar(ByVal fecha As String, ByVal codEquipo As String, ByVal descripcion As String, ByVal esPreventiva As Boolean) As Boolean
        Dim yaExiste = existe("Fecha", "TMantenimiento", fecha, isFecha:=True)
        Dim yaExiste2 = existe("CodEquipo", "TMantenimiento", codEquipo)

        If yaExiste And yaExiste2 Then
            MsgBox("No pueden existir dos mantenimientos con la misma fecha.", MsgBoxStyle.Information, "Fecha repetida")
            EXEerror = True
        Else
            conectar()

            cmd.Connection = conn
            cmd.CommandType = CommandType.Text
            sql = "INSERT INTO TMantenimiento (Fecha, CodEquipo, Descripcion, EsPreventiva)"
            sql += "VALUES ('" & fecha & "','" & codEquipo & "','" & descripcion & "'," & esPreventiva & ");"
            cmd.CommandText = sql

            Try
                cmd.ExecuteNonQuery()
                EXEerror = False
            Catch ex As Exception
                MsgBox(ex.ToString)
                EXEerror = True
            End Try
        End If
        desconectar()
        Return EXEerror
    End Function

    Public Function modificar(ByVal fecha As String, ByVal codEquipo As String, ByVal descripcion As String, ByVal esPreventiva As Boolean) As Boolean
        Dim yaExiste = existe("Fecha", "TMantenimiento", fecha, isFecha:=True)
        Dim yaExiste2 = existe("CodEquipo", "TMantenimiento", codEquipo)

        If yaExiste And yaExiste2 Then
            conectar()

            cmd.Connection = conn
            cmd.CommandType = CommandType.Text

            sql = "UPDATE TMantenimiento "
            sql += "SET "
            sql += "descripcion='" & descripcion & "', "
            sql += "EsPreventiva=" & esPreventiva & " "
            sql += "WHERE CodEquipo='" & codEquipo & "' AND Fecha=#" & fecha & "#"

            cmd.CommandText = sql


            Try
                cmd.ExecuteNonQuery()
                EXEerror = False
            Catch ex As Exception
                MsgBox(ex.ToString)
                EXEerror = True
            End Try
        Else
            MsgBox("El equipo con la fecha de mantenimiento ingresada no existe", MsgBoxStyle.Information, "Atención")
            EXEerror = True
        End If
        desconectar()
        Return EXEerror
    End Function

    Public Sub eliminar(ByVal codEquipo As String, ByVal fecha As String)
        Dim yaExiste = existe("Fecha", "TMantenimiento", fecha, isFecha:=True)
        Dim yaExiste2 = existe("CodEquipo", "TMantenimiento", codEquipo)
        If yaExiste And yaExiste2 Then
            conectar()

            cmd.Connection = conn
            cmd.CommandType = CommandType.Text

            sql = "DELETE FROM TMantenimiento WHERE CodEquipo='" & codEquipo & "' AND Fecha=#" & fecha & "#"
            cmd.CommandText = sql
            Try
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        Else
            MsgBox("El mantenimiento con los datos ingresados no existe", MsgBoxStyle.Information, "Atención")
        End If
        desconectar()

    End Sub
End Class
