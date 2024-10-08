Public Class Fgeneral
    Inherits conexion

    Dim dt As New DataTable
    Dim dt2 As New DataTable
    Dim dt3 As New DataTable

    Public Function existe(ByVal campo As String, ByVal tabla As String, ByVal valor As String, Optional ByVal isString As Boolean = True, Optional ByVal isFecha As Boolean = False) As Boolean
        Dim yaExiste As Boolean
        yaExiste = False

        conectar()
        cmd.Connection = conn
        cmd.CommandType = CommandType.Text
        If isString Then
            sql = "SELECT " & campo & " FROM " & tabla & " WHERE " & campo & "='" & valor & "'"
        Else
            sql = "SELECT " & campo & " FROM " & tabla & " WHERE " & campo & "=" & valor & ""
        End If

        If isFecha Then
            sql = "SELECT " & campo & " FROM " & tabla & " WHERE " & campo & "=#" & valor & "#"
        End If
        cmd.CommandText = sql
        Try
            cmd.ExecuteNonQuery()
            Using dt As New DataTable
                Using da As New OleDb.OleDbDataAdapter(cmd)
                    da.Fill(dt)
                    If dt.Rows.Count > 0 Then
                        yaExiste = True
                    Else
                        yaExiste = False
                    End If
                    desconectar()
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.ToString)
            Return Nothing
        End Try
        Return yaExiste
    End Function

    Public Function consultarId(ByVal id As String, ByVal tabla As String, Optional ByVal repeat As Boolean = True) As DataTable
        conectar()
        cmd.Connection = conn
        cmd.CommandType = CommandType.Text
        If repeat Then
            sql = "SELECT " & id & " FROM " & tabla & ";"
        Else
            sql = "SELECT DISTINCT " & id & " FROM " & tabla & ";"
        End If
        cmd.CommandText = sql
        Try
            cmd.ExecuteNonQuery()
            Using dt As New DataTable
                Using da As New OleDb.OleDbDataAdapter(cmd)
                    da.Fill(dt)
                    Return dt
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.ToString)
            Return Nothing
        End Try
    End Function

    Public Function consultarRegistro(ByVal campo As String, ByVal valorCampo As String, ByVal tabla As String, ByVal isString As Boolean) As DataTable
        conectar()
        cmd.Connection = conn
        cmd.CommandType = CommandType.Text
        If isString Then
            sql = "SELECT * FROM " & tabla & " WHERE " & campo & "='" & valorCampo & "'"
        Else
            sql = "SELECT * FROM " & tabla & " WHERE " & campo & "=" & valorCampo & ""
        End If
        cmd.CommandText = sql

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
    Public Function consultarRegistro(ByVal campo As String, ByVal campo2 As String, ByVal valor As String, ByVal valor2 As String, ByVal tabla As String, ByVal isString As Boolean) As DataTable
        conectar()
        cmd.Connection = conn
        cmd.CommandType = CommandType.Text
        If isString Then
            sql = "SELECT * FROM " & tabla & " WHERE " & campo & "='" & valor & "' AND " & campo2 & "=#" & valor2 & "#"
        Else
            sql = "SELECT * FROM " & tabla & " WHERE " & campo & "=" & valor & " AND " & campo2 & "=#" & valor2 & "#"
        End If
        
        cmd.CommandText = sql

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

    Public Function lastDate(ByVal campo As String, ByVal tabla As String, Optional ByVal cod As String = "", Optional ByVal esPrev As String = "") As DataTable
        conectar()
        cmd.Connection = conn
        cmd.CommandType = CommandType.Text
        If cod = "" Then
            If esPrev = "" Then
                sql = "SELECT MAX(" & campo & ") AS Fecha FROM " & tabla & ""
            Else
                sql = "SELECT MAX(" & campo & ") AS Fecha FROM " & tabla & " WHERE EsPreventiva=" & esPrev & """"
            End If
        Else
            If esPrev = "" Then
                sql = "SELECT MAX(" & campo & ") AS Fecha FROM " & tabla & " WHERE CodEquipo='" & cod & "'"
            Else
                sql = "SELECT MAX(" & campo & ") AS Fecha FROM " & tabla & " WHERE CodEquipo='" & cod & "' AND EsPreventiva=" & esPrev & ""
            End If
        End If
        cmd.CommandText = sql

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

    Public Function unionTodosUlt(ByVal tipo As String) As DataTable
        Dim fecha As Date
        Dim fechaStr As String
        Dim i As Integer
        Dim dt2 As New DataTable
        Dim dt3 As New DataTable
        


        dt3.Columns.Add("Fecha")
        dt = consultarId("CodEquipo", "TEquipo")


        desconectar()
        For i = 0 To (dt.Rows.Count - 1)
            If tipo = "Ambos" Then
                dt2 = lastDate("Fecha", "TMantenimiento", dt(i)("CodEquipo").ToString)
            ElseIf tipo = "Correctivo" Then
                dt2 = lastDate("Fecha", "TMantenimiento", dt(i)("CodEquipo").ToString, "False")
            ElseIf tipo = "Preventivo" Then
                dt2 = lastDate("Fecha", "TMantenimiento", dt(i)("CodEquipo").ToString, "True")
            End If
            If Not IsDBNull(dt2(0)("Fecha")) Then
                fecha = CDate(dt2(0)("Fecha"))
                If CInt(fecha.Day) <= 12 Then
                    fechaStr = fecha.Month.ToString & "/" & fecha.Day.ToString & "/" & fecha.Year.ToString
                Else
                    fechaStr = fecha.Day.ToString & "/" & fecha.Month.ToString & "/" & fecha.Year.ToString
                End If
            Else
                fechaStr = ""
            End If
            dt3.Rows.Add(fechaStr)
        Next










        'conectar()
        'cmd.Connection = conn
        'cmd.CommandType = CommandType.Text


        'If tipo = "Ambos" Then
        '    sql = "SELECT IDMantenimiento, Fecha, Descripcion, EsPreventiva, TEquipo.CodEquipo AS CodEquipo, Marca, Modelo "
        '    sql += "FROM (TMantenimiento LEFT JOIN TEquipo ON TMantenimiento.CodEquipo=TEquipo.CodEquipo) WHERE "
        '    For i = 0 To (dt3.Rows.Count - 1)
        '        fechaStr = dt3(i)("Fecha").ToString

        '        If (dt3.Rows.Count - 1) = i Then
        '            sql += "(Fecha=#" & fechaStr & "# AND TMantenimiento.CodEquipo='" & dt(i)("CodEquipo").ToString & "');"
        '        Else
        '            sql += "(Fecha=#" & fechaStr & "# AND TMantenimiento.CodEquipo='" & dt(i)("CodEquipo").ToString & "') OR "
        '        End If
        '    Next
        'ElseIf tipo = "Correctivo" Then
        '    sql = "SELECT IDMantenimiento, Fecha, Descripcion, EsPreventiva, TEquipo.CodEquipo AS CodEquipo, Marca, Modelo "
        '    sql += "FROM (TMantenimiento LEFT JOIN TEquipo ON TEquipo.CodEquipo=TMantenimiento.CodEquipo) WHERE TMantenimiento.EsPreventiva=False AND ("
        '    For i = 0 To (dt3.Rows.Count - 1)
        '        fechaStr = dt3(i)("Fecha").ToString

        '        If (dt3.Rows.Count - 1) = i Then
        '            sql += "(Fecha=#" & fechaStr & "# AND TMantenimiento.CodEquipo='" & dt(i)("CodEquipo").ToString & "'));"
        '        Else
        '            sql += "(Fecha=#" & fechaStr & "# AND TMantenimiento.CodEquipo='" & dt(i)("CodEquipo").ToString & "') OR "
        '        End If
        '    Next
        'ElseIf tipo = "Preventivo" Then
        '    sql = "SELECT IDMantenimiento, Fecha, Descripcion, EsPreventiva, TEquipo.CodEquipo AS CodEquipo, Marca, Modelo "
        '    sql += "FROM (TMantenimiento LEFT JOIN TEquipo ON TEquipo.CodEquipo=TMantenimiento.CodEquipo) WHERE TMantenimiento.EsPreventiva=True AND ("
        '    For i = 0 To (dt3.Rows.Count - 1)
        '        fechaStr = dt3(i)("Fecha").ToString

        '        If (dt3.Rows.Count - 1) = i Then
        '            sql += "(Fecha=#" & fechaStr & "# AND TMantenimiento.CodEquipo='" & dt(i)("CodEquipo").ToString & "'));"
        '        Else
        '            sql += "(Fecha=#" & fechaStr & "# AND TMantenimiento.CodEquipo='" & dt(i)("CodEquipo").ToString & "') OR "
        '        End If
        '    Next
        'End If

        'cmd.CommandText = sql










        conectar()
        cmd.Connection = conn
        cmd.CommandType = CommandType.Text


        If tipo = "Ambos" Then
            sql = "SELECT IDMantenimiento, Fecha, Descripcion, EsPreventiva, TEquipo.CodEquipo AS CodEquipo, Marca, Modelo "
            sql += "FROM (TMantenimiento LEFT JOIN TEquipo ON TMantenimiento.CodEquipo=TEquipo.CodEquipo) WHERE ("
            For i = 0 To (dt3.Rows.Count - 1)
                fechaStr = dt3(i)("Fecha").ToString
                If (dt3.Rows.Count - 1) = i Then
                    If fechaStr <> "" Then
                        sql += "(Fecha=#" & fechaStr & "# AND TEquipo.CodEquipo='" & dt(i)("CodEquipo").ToString & "'));"
                    Else
                        sql += ");"
                    End If
                Else
                    Dim fechaStrNext = dt3(i + 1)("Fecha").ToString
                    If (dt3.Rows.Count - 1) = (i + 1) And fechaStrNext = "" Then
                        If fechaStr <> "" Then
                            sql += "(Fecha=#" & fechaStr & "# AND TEquipo.CodEquipo='" & dt(i)("CodEquipo").ToString & "')"
                        Else
                            sql += ""
                        End If
                    ElseIf fechaStrNext = "" And Not ((dt3.Rows.Count - 1) = (i + 1)) Then
                        If fechaStr <> "" Then
                            sql += "(Fecha=#" & fechaStr & "# AND TEquipo.CodEquipo='" & dt(i)("CodEquipo").ToString & "') "
                        Else
                            sql += ""
                        End If
                    Else
                        If fechaStr <> "" Then
                            sql += "(Fecha=#" & fechaStr & "# AND TEquipo.CodEquipo='" & dt(i)("CodEquipo").ToString & "') OR "
                        Else
                            sql += " OR "
                        End If
                    End If
                End If

            Next
        ElseIf tipo = "Correctivo" Then
            sql = "SELECT IDMantenimiento, Fecha, Descripcion, EsPreventiva, TEquipo.CodEquipo AS CodEquipo, Marca, Modelo "
            sql += "FROM (TEquipo LEFT JOIN TMantenimiento ON TEquipo.CodEquipo=TMantenimiento.CodEquipo) WHERE TMantenimiento.EsPreventiva=False AND ("
            For i = 0 To (dt3.Rows.Count - 1)
                fechaStr = dt3(i)("Fecha").ToString

                If (dt3.Rows.Count - 1) = i Then
                    If fechaStr <> "" Then
                        sql += "(Fecha=#" & fechaStr & "# AND TEquipo.CodEquipo='" & dt(i)("CodEquipo").ToString & "'));"
                    Else
                        sql += ");"
                    End If
                Else
                    Dim fechaStrNext = dt3(i + 1)("Fecha").ToString
                    If (dt3.Rows.Count - 1) = (i + 1) And fechaStrNext = "" Then
                        If fechaStr <> "" Then
                            sql += "(Fecha=#" & fechaStr & "# AND TEquipo.CodEquipo='" & dt(i)("CodEquipo").ToString & "')"
                        Else
                            sql += ""
                        End If
                    ElseIf fechaStrNext = "" And Not ((dt3.Rows.Count - 1) = (i + 1)) Then
                        If fechaStr <> "" Then
                            sql += "(Fecha=#" & fechaStr & "# AND TEquipo.CodEquipo='" & dt(i)("CodEquipo").ToString & "') "
                        Else
                            sql += ""
                        End If
                    Else
                        If fechaStr <> "" Then
                            sql += "(Fecha=#" & fechaStr & "# AND TEquipo.CodEquipo='" & dt(i)("CodEquipo").ToString & "') OR "
                        Else
                            sql += " OR "
                        End If
                    End If
                End If
            Next
        ElseIf tipo = "Preventivo" Then
            sql = "SELECT IDMantenimiento, Fecha, Descripcion, EsPreventiva, TEquipo.CodEquipo AS CodEquipo, Marca, Modelo "
            sql += "FROM (TEquipo LEFT JOIN TMantenimiento ON TEquipo.CodEquipo=TMantenimiento.CodEquipo) WHERE TMantenimiento.EsPreventiva=True AND ("
            For i = 0 To (dt3.Rows.Count - 1)
                fechaStr = dt3(i)("Fecha").ToString

                If (dt3.Rows.Count - 1) = i Then
                    If fechaStr <> "" Then
                        sql += "(Fecha=#" & fechaStr & "# AND TEquipo.CodEquipo='" & dt(i)("CodEquipo").ToString & "'));"
                    Else
                        sql += ");"
                    End If
                Else
                    Dim fechaStrNext = dt3(i + 1)("Fecha").ToString
                    If (dt3.Rows.Count - 1) = (i + 1) And fechaStrNext = "" Then
                        If fechaStr <> "" Then
                            sql += "(Fecha=#" & fechaStr & "# AND TEquipo.CodEquipo='" & dt(i)("CodEquipo").ToString & "')"
                        Else
                            sql += ""
                        End If
                    ElseIf fechaStrNext = "" And Not ((dt3.Rows.Count - 1) = (i + 1)) Then
                        If fechaStr <> "" Then
                            sql += "(Fecha=#" & fechaStr & "# AND TEquipo.CodEquipo='" & dt(i)("CodEquipo").ToString & "') "
                        Else
                            sql += ""
                        End If
                    Else
                        If fechaStr <> "" Then
                            sql += "(Fecha=#" & fechaStr & "# AND TEquipo.CodEquipo='" & dt(i)("CodEquipo").ToString & "') OR "
                        Else
                            sql += " OR "
                        End If
                    End If
                End If
            Next
        End If

        cmd.CommandText = sql







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
    Public Function unionCodigoUlt(ByVal codEquipo As String, ByVal tipo As String) As DataTable
        Dim fecha As Date
        Dim fechaStr As String
        Dim i As Integer
        Dim dt2 As New DataTable
        Dim dt3 As New DataTable



        dt3.Columns.Add("Fecha")
        dt = consultarId("CodEquipo", "TEquipo")
        desconectar()


        For i = 0 To (dt.Rows.Count - 1)
            If tipo = "Ambos" Then
                dt2 = lastDate("Fecha", "TMantenimiento", dt(i)("CodEquipo").ToString)
            ElseIf tipo = "Correctivo" Then
                dt2 = lastDate("Fecha", "TMantenimiento", dt(i)("CodEquipo").ToString, "False")
            ElseIf tipo = "Preventivo" Then
                dt2 = lastDate("Fecha", "TMantenimiento", dt(i)("CodEquipo").ToString, "True")
            End If
            If Not IsDBNull(dt2(0)("Fecha")) Then
                fecha = CDate(dt2(0)("Fecha"))
                If CInt(fecha.Day) <= 12 Then
                    fechaStr = fecha.Month.ToString & "/" & fecha.Day.ToString & "/" & fecha.Year.ToString
                Else
                    fechaStr = fecha.Day.ToString & "/" & fecha.Month.ToString & "/" & fecha.Year.ToString
                End If
            Else
                fechaStr = ""
            End If
            dt3.Rows.Add(fechaStr)
        Next







        'conectar()
        'cmd.Connection = conn
        'cmd.CommandType = CommandType.Text

        'If tipo = "Ambos" Then
        '    sql = "SELECT IDMantenimiento, Fecha, Descripcion, EsPreventiva, TEquipo.CodEquipo AS CodEquipo, Marca, Modelo "
        '    sql += "FROM (TMantenimiento LEFT JOIN TEquipo ON TMantenimiento.CodEquipo=TEquipo.CodEquipo) WHERE TMantenimiento.CodEquipo='" & codEquipo & "' AND ("
        '    For i = 0 To (dt3.Rows.Count - 1)
        '        fechaStr = dt3(i)("Fecha").ToString

        '        If (dt3.Rows.Count - 1) = i Then
        '            sql += "(Fecha=#" & fechaStr & "# AND TMantenimiento.CodEquipo='" & dt(i)("CodEquipo").ToString & "'));"
        '        Else
        '            sql += "(Fecha=#" & fechaStr & "# AND TMantenimiento.CodEquipo='" & dt(i)("CodEquipo").ToString & "') OR "
        '        End If
        '    Next
        'ElseIf tipo = "Correctivo" Then
        '    sql = "SELECT IDMantenimiento, Fecha, Descripcion, EsPreventiva, TEquipo.CodEquipo AS CodEquipo, Marca, Modelo "
        '    sql += "FROM (TEquipo LEFT JOIN TMantenimiento ON TEquipo.CodEquipo=TMantenimiento.CodEquipo) WHERE TMantenimiento.CodEquipo='" & codEquipo & "' AND TMantenimiento.EsPreventiva=False AND ("
        '    For i = 0 To (dt3.Rows.Count - 1)
        '        fechaStr = dt3(i)("Fecha").ToString

        '        If (dt3.Rows.Count - 1) = i Then
        '            sql += "(Fecha=#" & fechaStr & "# AND TMantenimiento.CodEquipo='" & dt(i)("CodEquipo").ToString & "'));"
        '        Else
        '            sql += "(Fecha=#" & fechaStr & "# AND TMantenimiento.CodEquipo='" & dt(i)("CodEquipo").ToString & "') OR "
        '        End If
        '    Next
        'ElseIf tipo = "Preventivo" Then
        '    sql = "SELECT IDMantenimiento, Fecha, Descripcion, EsPreventiva, TEquipo.CodEquipo AS CodEquipo, Marca, Modelo "
        '    sql += "FROM (TEquipo LEFT JOIN TMantenimiento ON TEquipo.CodEquipo=TMantenimiento.CodEquipo) WHERE TMantenimiento.CodEquipo='" & codEquipo & "' AND TMantenimiento.EsPreventiva=True AND ("
        '    For i = 0 To (dt3.Rows.Count - 1)
        '        fechaStr = dt3(i)("Fecha").ToString

        '        If (dt3.Rows.Count - 1) = i Then
        '            sql += "(Fecha=#" & fechaStr & "# AND TMantenimiento.CodEquipo='" & dt(i)("CodEquipo").ToString & "'));"
        '        Else
        '            sql += "(Fecha=#" & fechaStr & "# AND TMantenimiento.CodEquipo='" & dt(i)("CodEquipo").ToString & "') OR "
        '        End If
        '    Next
        'End If

        'cmd.CommandText = sql






        conectar()
        cmd.Connection = conn
        cmd.CommandType = CommandType.Text


        If tipo = "Ambos" Then
            sql = "SELECT IDMantenimiento, Fecha, Descripcion, EsPreventiva, TEquipo.CodEquipo AS CodEquipo, Marca, Modelo "
            sql += "FROM (TMantenimiento LEFT JOIN TEquipo ON TMantenimiento.CodEquipo=TEquipo.CodEquipo) WHERE TEquipo.CodEquipo='" & codEquipo & "' AND ("
            For i = 0 To (dt3.Rows.Count - 1)
                fechaStr = dt3(i)("Fecha").ToString
                If (dt3.Rows.Count - 1) = i Then
                    If fechaStr <> "" Then
                        sql += "(Fecha=#" & fechaStr & "# AND TEquipo.CodEquipo='" & dt(i)("CodEquipo").ToString & "'));"
                    Else
                        sql += ");"
                    End If
                Else
                    Dim fechaStrNext = dt3(i + 1)("Fecha").ToString
                    If (dt3.Rows.Count - 1) = (i + 1) And fechaStrNext = "" Then
                        If fechaStr <> "" Then
                            sql += "(Fecha=#" & fechaStr & "# AND TEquipo.CodEquipo='" & dt(i)("CodEquipo").ToString & "')"
                        Else
                            sql += ""
                        End If
                    ElseIf fechaStrNext = "" And Not ((dt3.Rows.Count - 1) = (i + 1)) Then
                        If fechaStr <> "" Then
                            sql += "(Fecha=#" & fechaStr & "# AND TEquipo.CodEquipo='" & dt(i)("CodEquipo").ToString & "') "
                        Else
                            sql += ""
                        End If
                    Else
                        If fechaStr <> "" Then
                            sql += "(Fecha=#" & fechaStr & "# AND TEquipo.CodEquipo='" & dt(i)("CodEquipo").ToString & "') OR "
                        Else
                            sql += " OR "
                        End If
                    End If
                End If

            Next
        ElseIf tipo = "Correctivo" Then
            sql = "SELECT IDMantenimiento, Fecha, Descripcion, EsPreventiva, TEquipo.CodEquipo AS CodEquipo, Marca, Modelo "
            sql += "FROM (TEquipo LEFT JOIN TMantenimiento ON TEquipo.CodEquipo=TMantenimiento.CodEquipo) WHERE TEquipo.CodEquipo='" & codEquipo & "' AND TMantenimiento.EsPreventiva=False AND ("
            For i = 0 To (dt3.Rows.Count - 1)
                fechaStr = dt3(i)("Fecha").ToString

                If (dt3.Rows.Count - 1) = i Then
                    If fechaStr <> "" Then
                        sql += "(Fecha=#" & fechaStr & "# AND TEquipo.CodEquipo='" & dt(i)("CodEquipo").ToString & "'));"
                    Else
                        sql += ");"
                    End If
                Else
                    Dim fechaStrNext = dt3(i + 1)("Fecha").ToString
                    If (dt3.Rows.Count - 1) = (i + 1) And fechaStrNext = "" Then
                        If fechaStr <> "" Then
                            sql += "(Fecha=#" & fechaStr & "# AND TEquipo.CodEquipo='" & dt(i)("CodEquipo").ToString & "')"
                        Else
                            sql += ""
                        End If
                    ElseIf fechaStrNext = "" And Not ((dt3.Rows.Count - 1) = (i + 1)) Then
                        If fechaStr <> "" Then
                            sql += "(Fecha=#" & fechaStr & "# AND TEquipo.CodEquipo='" & dt(i)("CodEquipo").ToString & "') "
                        Else
                            sql += ""
                        End If
                    Else
                        If fechaStr <> "" Then
                            sql += "(Fecha=#" & fechaStr & "# AND TEquipo.CodEquipo='" & dt(i)("CodEquipo").ToString & "') OR "
                        Else
                            sql += " OR "
                        End If
                    End If
                End If
            Next
        ElseIf tipo = "Preventivo" Then
            sql = "SELECT IDMantenimiento, Fecha, Descripcion, EsPreventiva, TEquipo.CodEquipo AS CodEquipo, Marca, Modelo "
            sql += "FROM (TEquipo LEFT JOIN TMantenimiento ON TEquipo.CodEquipo=TMantenimiento.CodEquipo) WHERE TEquipo.CodEquipo='" & codEquipo & "' AND TMantenimiento.EsPreventiva=True AND ("
            For i = 0 To (dt3.Rows.Count - 1)
                fechaStr = dt3(i)("Fecha").ToString

                If (dt3.Rows.Count - 1) = i Then
                    If fechaStr <> "" Then
                        sql += "(Fecha=#" & fechaStr & "# AND TEquipo.CodEquipo='" & dt(i)("CodEquipo").ToString & "'));"
                    Else
                        sql += ");"
                    End If
                Else
                    Dim fechaStrNext = dt3(i + 1)("Fecha").ToString
                    If (dt3.Rows.Count - 1) = (i + 1) And fechaStrNext = "" Then
                        If fechaStr <> "" Then
                            sql += "(Fecha=#" & fechaStr & "# AND TEquipo.CodEquipo='" & dt(i)("CodEquipo").ToString & "')"
                        Else
                            sql += ""
                        End If
                    ElseIf fechaStrNext = "" And Not ((dt3.Rows.Count - 1) = (i + 1)) Then
                        If fechaStr <> "" Then
                            sql += "(Fecha=#" & fechaStr & "# AND TEquipo.CodEquipo='" & dt(i)("CodEquipo").ToString & "') "
                        Else
                            sql += ""
                        End If
                    Else
                        If fechaStr <> "" Then
                            sql += "(Fecha=#" & fechaStr & "# AND TEquipo.CodEquipo='" & dt(i)("CodEquipo").ToString & "') OR "
                        Else
                            sql += " OR "
                        End If
                    End If
                End If
            Next
        End If

        cmd.CommandText = sql







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
    Public Function unionMarcaUlt(ByVal marca As String, ByVal tipo As String) As DataTable
        Dim fecha As Date
        Dim fechaStr As String
        Dim i As Integer
        Dim dt2 As New DataTable
        Dim dt3 As New DataTable



        dt3.Columns.Add("Fecha")
        dt = consultarId("CodEquipo", "TEquipo")
        desconectar()

        For i = 0 To (dt.Rows.Count - 1)
            If tipo = "Ambos" Then
                dt2 = lastDate("Fecha", "TMantenimiento", dt(i)("CodEquipo").ToString)
            ElseIf tipo = "Correctivo" Then
                dt2 = lastDate("Fecha", "TMantenimiento", dt(i)("CodEquipo").ToString, "False")
            ElseIf tipo = "Preventivo" Then
                dt2 = lastDate("Fecha", "TMantenimiento", dt(i)("CodEquipo").ToString, "True")
            End If

            If IsDBNull(dt2(0)("Fecha")) Then
                fechaStr = ""
            Else
                fecha = CDate(dt2(0)("Fecha"))
                If CInt(fecha.Day) <= 12 Then
                    fechaStr = fecha.Month.ToString & "/" & fecha.Day.ToString & "/" & fecha.Year.ToString
                Else
                    fechaStr = fecha.Day.ToString & "/" & fecha.Month.ToString & "/" & fecha.Year.ToString
                End If
            End If
            dt3.Rows.Add(fechaStr)
        Next


        conectar()
        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        If tipo = "Ambos" Then
            sql = "SELECT IDMantenimiento, Fecha, Descripcion, EsPreventiva, TEquipo.CodEquipo AS CodEquipo, Marca, Modelo "
            sql += "FROM (TMantenimiento LEFT JOIN TEquipo ON TMantenimiento.CodEquipo=TEquipo.CodEquipo) WHERE TEquipo.Marca='" & marca & "' AND ("
            For i = 0 To (dt3.Rows.Count - 1)
                fechaStr = dt3(i)("Fecha").ToString
                If (dt3.Rows.Count - 1) = i Then
                    If fechaStr <> "" Then
                        sql += "(Fecha=#" & fechaStr & "# AND TEquipo.CodEquipo='" & dt(i)("CodEquipo").ToString & "'));"
                    Else
                        sql += ");"
                    End If
                Else
                    Dim fechaStrNext = dt3(i + 1)("Fecha").ToString
                    If (dt3.Rows.Count - 1) = (i + 1) And fechaStrNext = "" Then
                        If fechaStr <> "" Then
                            sql += "(Fecha=#" & fechaStr & "# AND TEquipo.CodEquipo='" & dt(i)("CodEquipo").ToString & "')"
                        Else
                            sql += ""
                        End If
                    ElseIf fechaStrNext = "" And Not ((dt3.Rows.Count - 1) = (i + 1)) Then
                        If fechaStr <> "" Then
                            sql += "(Fecha=#" & fechaStr & "# AND TEquipo.CodEquipo='" & dt(i)("CodEquipo").ToString & "') "
                        Else
                            sql += ""
                        End If
                    Else
                        If fechaStr <> "" Then
                            sql += "(Fecha=#" & fechaStr & "# AND TEquipo.CodEquipo='" & dt(i)("CodEquipo").ToString & "') OR "
                        Else
                            sql += " OR "
                        End If
                    End If
                End If

            Next
        ElseIf tipo = "Correctivo" Then
            sql = "SELECT IDMantenimiento, Fecha, Descripcion, EsPreventiva, TEquipo.CodEquipo AS CodEquipo, Marca, Modelo "
            sql += "FROM (TEquipo LEFT JOIN TMantenimiento ON TEquipo.CodEquipo=TMantenimiento.CodEquipo) WHERE Marca='" & marca & "' AND TMantenimiento.EsPreventiva=False AND ("
            For i = 0 To (dt3.Rows.Count - 1)
                fechaStr = dt3(i)("Fecha").ToString

                If (dt3.Rows.Count - 1) = i Then
                    If fechaStr <> "" Then
                        sql += "(Fecha=#" & fechaStr & "# AND TEquipo.CodEquipo='" & dt(i)("CodEquipo").ToString & "'));"
                    Else
                        sql += ");"
                    End If
                Else
                    Dim fechaStrNext = dt3(i + 1)("Fecha").ToString
                    If (dt3.Rows.Count - 1) = (i + 1) And fechaStrNext = "" Then
                        If fechaStr <> "" Then
                            sql += "(Fecha=#" & fechaStr & "# AND TEquipo.CodEquipo='" & dt(i)("CodEquipo").ToString & "')"
                        Else
                            sql += ""
                        End If
                    ElseIf fechaStrNext = "" And Not ((dt3.Rows.Count - 1) = (i + 1)) Then
                        If fechaStr <> "" Then
                            sql += "(Fecha=#" & fechaStr & "# AND TEquipo.CodEquipo='" & dt(i)("CodEquipo").ToString & "') "
                        Else
                            sql += ""
                        End If
                    Else
                        If fechaStr <> "" Then
                            sql += "(Fecha=#" & fechaStr & "# AND TEquipo.CodEquipo='" & dt(i)("CodEquipo").ToString & "') OR "
                        Else
                            sql += " OR "
                        End If
                    End If
                End If
            Next
        ElseIf tipo = "Preventivo" Then
            sql = "SELECT IDMantenimiento, Fecha, Descripcion, EsPreventiva, TEquipo.CodEquipo AS CodEquipo, Marca, Modelo "
            sql += "FROM (TEquipo LEFT JOIN TMantenimiento ON TEquipo.CodEquipo=TMantenimiento.CodEquipo) WHERE Marca='" & marca & "' AND TMantenimiento.EsPreventiva=True AND ("
            For i = 0 To (dt3.Rows.Count - 1)
                fechaStr = dt3(i)("Fecha").ToString

                If (dt3.Rows.Count - 1) = i Then
                    If fechaStr <> "" Then
                        sql += "(Fecha=#" & fechaStr & "# AND TEquipo.CodEquipo='" & dt(i)("CodEquipo").ToString & "'));"
                    Else
                        sql += ");"
                    End If
                Else
                    Dim fechaStrNext = dt3(i + 1)("Fecha").ToString
                    If (dt3.Rows.Count - 1) = (i + 1) And fechaStrNext = "" Then
                        If fechaStr <> "" Then
                            sql += "(Fecha=#" & fechaStr & "# AND TEquipo.CodEquipo='" & dt(i)("CodEquipo").ToString & "')"
                        Else
                            sql += ""
                        End If
                    ElseIf fechaStrNext = "" And Not ((dt3.Rows.Count - 1) = (i + 1)) Then
                        If fechaStr <> "" Then
                            sql += "(Fecha=#" & fechaStr & "# AND TEquipo.CodEquipo='" & dt(i)("CodEquipo").ToString & "') "
                        Else
                            sql += ""
                        End If
                    Else
                        If fechaStr <> "" Then
                            sql += "(Fecha=#" & fechaStr & "# AND TEquipo.CodEquipo='" & dt(i)("CodEquipo").ToString & "') OR "
                        Else
                            sql += " OR "
                        End If
                    End If
                End If
            Next
        End If
        cmd.CommandText = sql


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
    Public Function unionModeloUlt(ByVal modelo As String, ByVal tipo As String) As DataTable
        Dim fecha As Date
        Dim fechaStr As String
        Dim i As Integer
        Dim dt2 As New DataTable
        Dim dt3 As New DataTable



        dt3.Columns.Add("Fecha")
        dt = consultarId("CodEquipo", "TEquipo")
        desconectar()

        For i = 0 To (dt.Rows.Count - 1)
            If tipo = "Ambos" Then
                dt2 = lastDate("Fecha", "TMantenimiento", dt(i)("CodEquipo").ToString)
            ElseIf tipo = "Correctivo" Then
                dt2 = lastDate("Fecha", "TMantenimiento", dt(i)("CodEquipo").ToString, "False")
            ElseIf tipo = "Preventivo" Then
                dt2 = lastDate("Fecha", "TMantenimiento", dt(i)("CodEquipo").ToString, "True")
            End If

            If IsDBNull(dt2(0)("Fecha")) Then
                fechaStr = ""
            Else
                fecha = CDate(dt2(0)("Fecha"))
                If CInt(fecha.Day) <= 12 Then
                    fechaStr = fecha.Month.ToString & "/" & fecha.Day.ToString & "/" & fecha.Year.ToString
                Else
                    fechaStr = fecha.Day.ToString & "/" & fecha.Month.ToString & "/" & fecha.Year.ToString
                End If
            End If
            dt3.Rows.Add(fechaStr)
        Next

        conectar()
        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        If tipo = "Ambos" Then
            sql = "SELECT IDMantenimiento, Fecha, Descripcion, EsPreventiva, TEquipo.CodEquipo AS CodEquipo, Marca, Modelo "
            sql += "FROM (TMantenimiento LEFT JOIN TEquipo ON TMantenimiento.CodEquipo=TEquipo.CodEquipo) WHERE TEquipo.Modelo='" & modelo & "' AND ("
            For i = 0 To (dt3.Rows.Count - 1)
                fechaStr = dt3(i)("Fecha").ToString
                If (dt3.Rows.Count - 1) = i Then
                    If fechaStr <> "" Then
                        sql += "(Fecha=#" & fechaStr & "# AND TEquipo.CodEquipo='" & dt(i)("CodEquipo").ToString & "'));"
                    Else
                        sql += ");"
                    End If
                Else
                    Dim fechaStrNext = dt3(i + 1)("Fecha").ToString
                    If (dt3.Rows.Count - 1) = (i + 1) And fechaStrNext = "" Then
                        If fechaStr <> "" Then
                            sql += "(Fecha=#" & fechaStr & "# AND TEquipo.CodEquipo='" & dt(i)("CodEquipo").ToString & "')"
                        Else
                            sql += ""
                        End If
                    ElseIf fechaStrNext = "" And Not ((dt3.Rows.Count - 1) = (i + 1)) Then
                        If fechaStr <> "" Then
                            sql += "(Fecha=#" & fechaStr & "# AND TEquipo.CodEquipo='" & dt(i)("CodEquipo").ToString & "') "
                        Else
                            sql += ""
                        End If
                    Else
                        If fechaStr <> "" Then
                            sql += "(Fecha=#" & fechaStr & "# AND TEquipo.CodEquipo='" & dt(i)("CodEquipo").ToString & "') OR "
                        Else
                            sql += " OR "
                        End If
                    End If
                End If

            Next
        ElseIf tipo = "Correctivo" Then
            sql = "SELECT IDMantenimiento, Fecha, Descripcion, EsPreventiva, TEquipo.CodEquipo AS CodEquipo, Marca, Modelo "
            sql += "FROM (TEquipo LEFT JOIN TMantenimiento ON TEquipo.CodEquipo=TMantenimiento.CodEquipo) WHERE Modelo='" & modelo & "' AND TMantenimiento.EsPreventiva=False AND ("
            For i = 0 To (dt3.Rows.Count - 1)
                fechaStr = dt3(i)("Fecha").ToString

                If (dt3.Rows.Count - 1) = i Then
                    If fechaStr <> "" Then
                        sql += "(Fecha=#" & fechaStr & "# AND TEquipo.CodEquipo='" & dt(i)("CodEquipo").ToString & "'));"
                    Else
                        sql += ");"
                    End If
                Else
                    Dim fechaStrNext = dt3(i + 1)("Fecha").ToString
                    If (dt3.Rows.Count - 1) = (i + 1) And fechaStrNext = "" Then
                        If fechaStr <> "" Then
                            sql += "(Fecha=#" & fechaStr & "# AND TEquipo.CodEquipo='" & dt(i)("CodEquipo").ToString & "')"
                        Else
                            sql += ""
                        End If
                    ElseIf fechaStrNext = "" And Not ((dt3.Rows.Count - 1) = (i + 1)) Then
                        If fechaStr <> "" Then
                            sql += "(Fecha=#" & fechaStr & "# AND TEquipo.CodEquipo='" & dt(i)("CodEquipo").ToString & "') "
                        Else
                            sql += ""
                        End If
                    Else
                        If fechaStr <> "" Then
                            sql += "(Fecha=#" & fechaStr & "# AND TEquipo.CodEquipo='" & dt(i)("CodEquipo").ToString & "') OR "
                        Else
                            sql += " OR "
                        End If
                    End If
                End If
            Next
        ElseIf tipo = "Preventivo" Then
            sql = "SELECT IDMantenimiento, Fecha, Descripcion, EsPreventiva, TEquipo.CodEquipo AS CodEquipo, Marca, Modelo "
            sql += "FROM (TEquipo LEFT JOIN TMantenimiento ON TEquipo.CodEquipo=TMantenimiento.CodEquipo) WHERE Modelo='" & modelo & "' AND TMantenimiento.EsPreventiva=True AND ("
            For i = 0 To (dt3.Rows.Count - 1)
                fechaStr = dt3(i)("Fecha").ToString

                If (dt3.Rows.Count - 1) = i Then
                    If fechaStr <> "" Then
                        sql += "(Fecha=#" & fechaStr & "# AND TEquipo.CodEquipo='" & dt(i)("CodEquipo").ToString & "'));"
                    Else
                        sql += ");"
                    End If
                Else
                    Dim fechaStrNext = dt3(i + 1)("Fecha").ToString
                    If (dt3.Rows.Count - 1) = (i + 1) And fechaStrNext = "" Then
                        If fechaStr <> "" Then
                            sql += "(Fecha=#" & fechaStr & "# AND TEquipo.CodEquipo='" & dt(i)("CodEquipo").ToString & "')"
                        Else
                            sql += ""
                        End If
                    ElseIf fechaStrNext = "" And Not ((dt3.Rows.Count - 1) = (i + 1)) Then
                        If fechaStr <> "" Then
                            sql += "(Fecha=#" & fechaStr & "# AND TEquipo.CodEquipo='" & dt(i)("CodEquipo").ToString & "') "
                        Else
                            sql += ""
                        End If
                    Else
                        If fechaStr <> "" Then
                            sql += "(Fecha=#" & fechaStr & "# AND TEquipo.CodEquipo='" & dt(i)("CodEquipo").ToString & "') OR "
                        Else
                            sql += " OR "
                        End If
                    End If
                End If
            Next
        End If
        cmd.CommandText = sql


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



    Public Function unionTodosFechas(ByVal tipo As String, ByVal fechaInicial As String, ByVal fechaFinal As String) As DataTable
        conectar()
        cmd.Connection = conn
        cmd.CommandType = CommandType.Text


        If tipo = "Ambos" Then
            sql = "SELECT IDMantenimiento, Fecha, Descripcion, EsPreventiva, TEquipo.CodEquipo AS CodEquipo, Marca, Modelo "
            sql += "FROM (TMantenimiento LEFT JOIN TEquipo ON TMantenimiento.CodEquipo=TEquipo.CodEquipo) WHERE Fecha >= #" & fechaInicial & "# AND Fecha <= #" & fechaFinal & "#;"
        ElseIf tipo = "Correctivo" Then
            sql = "SELECT IDMantenimiento, Fecha, Descripcion, EsPreventiva, TEquipo.CodEquipo AS CodEquipo, Marca, Modelo "
            sql += "FROM (TMantenimiento LEFT JOIN TEquipo ON TEquipo.CodEquipo=TMantenimiento.CodEquipo) WHERE TMantenimiento.EsPreventiva=False AND (Fecha >= #" & fechaInicial & "# AND Fecha <= #" & fechaFinal & "#);"
        ElseIf tipo = "Preventivo" Then
            sql = "SELECT IDMantenimiento, Fecha, Descripcion, EsPreventiva, TEquipo.CodEquipo AS CodEquipo, Marca, Modelo "
            sql += "FROM (TMantenimiento LEFT JOIN TEquipo ON TEquipo.CodEquipo=TMantenimiento.CodEquipo) WHERE TMantenimiento.EsPreventiva=True AND (Fecha >= #" & fechaInicial & "# AND Fecha <= #" & fechaFinal & "#);"
        End If

        cmd.CommandText = sql


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
    Public Function unionCodigoFechas(ByVal codEquipo As String, ByVal tipo As String, ByVal fechaInicial As String, ByVal fechaFinal As String) As DataTable

        conectar()
        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        If tipo = "Ambos" Then
            sql = "SELECT IDMantenimiento, Fecha, Descripcion, EsPreventiva, TEquipo.CodEquipo AS CodEquipo, Marca, Modelo "
            sql += "FROM (TMantenimiento LEFT JOIN TEquipo ON TMantenimiento.CodEquipo=TEquipo.CodEquipo) WHERE TMantenimiento.CodEquipo='" & codEquipo & "' AND (Fecha >= #" & fechaInicial & "# AND Fecha <= #" & fechaFinal & "#);"

        ElseIf tipo = "Correctivo" Then
            sql = "SELECT IDMantenimiento, Fecha, Descripcion, EsPreventiva, TEquipo.CodEquipo AS CodEquipo, Marca, Modelo "
            sql += "FROM (TEquipo LEFT JOIN TMantenimiento ON TEquipo.CodEquipo=TMantenimiento.CodEquipo) WHERE TMantenimiento.CodEquipo='" & codEquipo & "' AND TMantenimiento.EsPreventiva=False AND (Fecha >= #" & fechaInicial & "# AND Fecha <= #" & fechaFinal & "#);"
        ElseIf tipo = "Preventivo" Then
            sql = "SELECT IDMantenimiento, Fecha, Descripcion, EsPreventiva, TEquipo.CodEquipo AS CodEquipo, Marca, Modelo "
            sql += "FROM (TEquipo LEFT JOIN TMantenimiento ON TEquipo.CodEquipo=TMantenimiento.CodEquipo) WHERE TMantenimiento.CodEquipo='" & codEquipo & "' AND TMantenimiento.EsPreventiva=True AND (Fecha >= #" & fechaInicial & "# AND Fecha <= #" & fechaFinal & "#);"
        End If

        cmd.CommandText = sql


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
    Public Function unionMarcaFechas(ByVal marca As String, ByVal tipo As String, ByVal fechaInicial As String, ByVal fechaFinal As String) As DataTable
        
        conectar()
        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        If tipo = "Ambos" Then
            sql = "SELECT IDMantenimiento, Fecha, Descripcion, EsPreventiva, TEquipo.CodEquipo AS CodEquipo, Marca, Modelo "
            sql += "FROM (TMantenimiento LEFT JOIN TEquipo ON TMantenimiento.CodEquipo=TEquipo.CodEquipo) WHERE TEquipo.Marca='" & marca & "' AND (Fecha >= #" & fechaInicial & "# AND Fecha <= #" & fechaFinal & "#);"
        ElseIf tipo = "Correctivo" Then
            sql = "SELECT IDMantenimiento, Fecha, Descripcion, EsPreventiva, TEquipo.CodEquipo AS CodEquipo, Marca, Modelo "
            sql += "FROM (TEquipo LEFT JOIN TMantenimiento ON TEquipo.CodEquipo=TMantenimiento.CodEquipo) WHERE Marca='" & marca & "' AND TMantenimiento.EsPreventiva=False AND (Fecha >= #" & fechaInicial & "# AND Fecha <= #" & fechaFinal & "#);"
        ElseIf tipo = "Preventivo" Then
            sql = "SELECT IDMantenimiento, Fecha, Descripcion, EsPreventiva, TEquipo.CodEquipo AS CodEquipo, Marca, Modelo "
            sql += "FROM (TEquipo LEFT JOIN TMantenimiento ON TEquipo.CodEquipo=TMantenimiento.CodEquipo) WHERE Marca='" & marca & "' AND TMantenimiento.EsPreventiva=True AND (Fecha >= #" & fechaInicial & "# AND Fecha <= #" & fechaFinal & "#);"
        End If
        cmd.CommandText = sql


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
    Public Function unionModeloFechas(ByVal modelo As String, ByVal tipo As String, ByVal fechaInicial As String, ByVal fechaFinal As String) As DataTable
        'Dim fecha As Date
        'Dim fechaStr As String
        'Dim i As Integer
        'Dim dt2 As New DataTable
        'Dim dt3 As New DataTable



        'dt3.Columns.Add("Fecha")
        'dt = consultarId("CodEquipo", "TEquipo")
        'desconectar()

        'For i = 0 To (dt.Rows.Count - 1)
        '    If tipo = "Ambos" Then
        '        dt2 = lastDate("Fecha", "TMantenimiento", dt(i)("CodEquipo").ToString)
        '    ElseIf tipo = "Correctivo" Then
        '        dt2 = lastDate("Fecha", "TMantenimiento", dt(i)("CodEquipo").ToString, "False")
        '    ElseIf tipo = "Preventivo" Then
        '        dt2 = lastDate("Fecha", "TMantenimiento", dt(i)("CodEquipo").ToString, "True")
        '    End If

        '    If IsDBNull(dt2(0)("Fecha")) Then
        '        fechaStr = ""
        '    Else
        '        fecha = CDate(dt2(0)("Fecha"))
        '        If CInt(fecha.Day) <= 12 Then
        '            fechaStr = fecha.Month.ToString & "/" & fecha.Day.ToString & "/" & fecha.Year.ToString
        '        Else
        '            fechaStr = fecha.Day.ToString & "/" & fecha.Month.ToString & "/" & fecha.Year.ToString
        '        End If
        '    End If
        '    dt3.Rows.Add(fechaStr)
        'Next

        conectar()
        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        If tipo = "Ambos" Then
            sql = "SELECT IDMantenimiento, Fecha, Descripcion, EsPreventiva, TEquipo.CodEquipo AS CodEquipo, Marca, Modelo "
            sql += "FROM (TMantenimiento LEFT JOIN TEquipo ON TMantenimiento.CodEquipo=TEquipo.CodEquipo) WHERE TEquipo.Modelo='" & modelo & "' AND  (Fecha >= #" & fechaInicial & "# AND Fecha <= #" & fechaFinal & "#);"
            'For i = 0 To (dt3.Rows.Count - 1)
            '    fechaStr = dt3(i)("Fecha").ToString
            '    If (dt3.Rows.Count - 1) = i Then
            '        If fechaStr <> "" Then
            '            sql += "(Fecha=#" & fechaStr & "# AND TEquipo.CodEquipo='" & dt(i)("CodEquipo").ToString & "'));"
            '        Else
            '            sql += ");"
            '        End If
            '    Else
            '        Dim fechaStrNext = dt3(i + 1)("Fecha").ToString
            '        If (dt3.Rows.Count - 1) = (i + 1) And fechaStrNext = "" Then
            '            If fechaStr <> "" Then
            '                sql += "(Fecha=#" & fechaStr & "# AND TEquipo.CodEquipo='" & dt(i)("CodEquipo").ToString & "')"
            '            Else
            '                sql += ""
            '            End If
            '        ElseIf fechaStrNext = "" And Not ((dt3.Rows.Count - 1) = (i + 1)) Then
            '            If fechaStr <> "" Then
            '                sql += "(Fecha=#" & fechaStr & "# AND TEquipo.CodEquipo='" & dt(i)("CodEquipo").ToString & "') "
            '            Else
            '                sql += ""
            '            End If
            '        Else
            '            If fechaStr <> "" Then
            '                sql += "(Fecha=#" & fechaStr & "# AND TEquipo.CodEquipo='" & dt(i)("CodEquipo").ToString & "') OR "
            '            Else
            '                sql += " OR "
            '            End If
            '        End If
            '    End If

            'Next
        ElseIf tipo = "Correctivo" Then
            sql = "SELECT IDMantenimiento, Fecha, Descripcion, EsPreventiva, TEquipo.CodEquipo AS CodEquipo, Marca, Modelo "
            sql += "FROM (TEquipo LEFT JOIN TMantenimiento ON TEquipo.CodEquipo=TMantenimiento.CodEquipo) WHERE Modelo='" & modelo & "' AND TMantenimiento.EsPreventiva=False AND (Fecha >= #" & fechaInicial & "# AND Fecha <= #" & fechaFinal & "#);"
            'For i = 0 To (dt3.Rows.Count - 1)
            '    fechaStr = dt3(i)("Fecha").ToString

            '    If (dt3.Rows.Count - 1) = i Then
            '        If fechaStr <> "" Then
            '            sql += "(Fecha=#" & fechaStr & "# AND TEquipo.CodEquipo='" & dt(i)("CodEquipo").ToString & "'));"
            '        Else
            '            sql += ");"
            '        End If
            '    Else
            '        Dim fechaStrNext = dt3(i + 1)("Fecha").ToString
            '        If (dt3.Rows.Count - 1) = (i + 1) And fechaStrNext = "" Then
            '            If fechaStr <> "" Then
            '                sql += "(Fecha=#" & fechaStr & "# AND TEquipo.CodEquipo='" & dt(i)("CodEquipo").ToString & "')"
            '            Else
            '                sql += ""
            '            End If
            '        ElseIf fechaStrNext = "" And Not ((dt3.Rows.Count - 1) = (i + 1)) Then
            '            If fechaStr <> "" Then
            '                sql += "(Fecha=#" & fechaStr & "# AND TEquipo.CodEquipo='" & dt(i)("CodEquipo").ToString & "') "
            '            Else
            '                sql += ""
            '            End If
            '        Else
            '            If fechaStr <> "" Then
            '                sql += "(Fecha=#" & fechaStr & "# AND TEquipo.CodEquipo='" & dt(i)("CodEquipo").ToString & "') OR "
            '            Else
            '                sql += " OR "
            '            End If
            '        End If
            '    End If
            'Next
        ElseIf tipo = "Preventivo" Then
            sql = "SELECT IDMantenimiento, Fecha, Descripcion, EsPreventiva, TEquipo.CodEquipo AS CodEquipo, Marca, Modelo "
            sql += "FROM (TEquipo LEFT JOIN TMantenimiento ON TEquipo.CodEquipo=TMantenimiento.CodEquipo) WHERE Modelo='" & modelo & "' AND TMantenimiento.EsPreventiva=True AND (Fecha >= #" & fechaInicial & "# AND Fecha <= #" & fechaFinal & "#);"
            'For i = 0 To (dt3.Rows.Count - 1)
            '    fechaStr = dt3(i)("Fecha").ToString

            '    If (dt3.Rows.Count - 1) = i Then
            '        If fechaStr <> "" Then
            '            sql += "(Fecha=#" & fechaStr & "# AND TEquipo.CodEquipo='" & dt(i)("CodEquipo").ToString & "'));"
            '        Else
            '            sql += ");"
            '        End If
            '    Else
            '        Dim fechaStrNext = dt3(i + 1)("Fecha").ToString
            '        If (dt3.Rows.Count - 1) = (i + 1) And fechaStrNext = "" Then
            '            If fechaStr <> "" Then
            '                sql += "(Fecha=#" & fechaStr & "# AND TEquipo.CodEquipo='" & dt(i)("CodEquipo").ToString & "')"
            '            Else
            '                sql += ""
            '            End If
            '        ElseIf fechaStrNext = "" And Not ((dt3.Rows.Count - 1) = (i + 1)) Then
            '            If fechaStr <> "" Then
            '                sql += "(Fecha=#" & fechaStr & "# AND TEquipo.CodEquipo='" & dt(i)("CodEquipo").ToString & "') "
            '            Else
            '                sql += ""
            '            End If
            '        Else
            '            If fechaStr <> "" Then
            '                sql += "(Fecha=#" & fechaStr & "# AND TEquipo.CodEquipo='" & dt(i)("CodEquipo").ToString & "') OR "
            '            Else
            '                sql += " OR "
            '            End If
            '        End If
            '    End If
            'Next
        End If
        cmd.CommandText = sql


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
End Class
