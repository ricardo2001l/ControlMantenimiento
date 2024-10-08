Imports iTextSharp.text.pdf
Imports iTextSharp.text
Imports System.IO

Public Class Fpdf
    Public fg As New Fgeneral
    Public dt As DataTable

    Public Sub iniciarPdf(ByVal isUlt As Boolean, ByVal tipoInforme As String, ByVal tipoMant As String, Optional ByVal id As String = "", Optional ByVal fechaInicio As String = "", Optional ByVal fechaFinal As String = "")
        If isUlt Then
            If tipoMant = "Ambos" Then
                Select Case tipoInforme
                    Case "Todos"
                        dt = fg.unionTodosUlt("Ambos")
                        crearPdf(dt, isUlt, tipoMant, tipoInforme)
                    Case "Codigo"
                        dt = CType(fg.unionCodigoUlt(id, "Ambos"), DataTable)
                        crearPdf(dt, isUlt, tipoMant, tipoInforme)
                    Case "Marca"
                        dt = CType(fg.unionMarcaUlt(id, "Ambos"), DataTable)
                        crearPdf(dt, isUlt, tipoMant, tipoInforme)
                    Case "Modelo"
                        dt = CType(fg.unionModeloUlt(id, "Ambos"), DataTable)
                        crearPdf(dt, isUlt, tipoMant, tipoInforme)
                End Select
            ElseIf tipoMant = "Correctivo" Then
                Select Case tipoInforme
                    Case "Todos"
                        dt = CType(fg.unionTodosUlt("Correctivo"), DataTable)
                        crearPdf(dt, isUlt, tipoMant, tipoInforme)
                    Case "Codigo"
                        dt = CType(fg.unionCodigoUlt(id, "Correctivo"), DataTable)
                        crearPdf(dt, isUlt, tipoMant, tipoInforme)
                    Case "Marca"
                        dt = CType(fg.unionMarcaUlt(id, "Correctivo"), DataTable)
                        crearPdf(dt, isUlt, tipoMant, tipoInforme)
                    Case "Modelo"
                        dt = CType(fg.unionModeloUlt(id, "Correctivo"), DataTable)
                        crearPdf(dt, isUlt, tipoMant, tipoInforme)
                End Select
            ElseIf tipoMant = "Preventivo" Then
                Select Case tipoInforme
                    Case "Todos"
                        dt = CType(fg.unionTodosUlt("Preventivo"), DataTable)
                        crearPdf(dt, isUlt, tipoMant, tipoInforme)
                    Case "Codigo"
                        dt = CType(fg.unionCodigoUlt(id, "Preventivo"), DataTable)
                        crearPdf(dt, isUlt, tipoMant, tipoInforme)
                    Case "Marca"
                        dt = CType(fg.unionMarcaUlt(id, "Preventivo"), DataTable)
                        crearPdf(dt, isUlt, tipoMant, tipoInforme)
                    Case "Modelo"
                        dt = CType(fg.unionModeloUlt(id, "Preventivo"), DataTable)
                        crearPdf(dt, isUlt, tipoMant, tipoInforme)
                End Select
            End If
        Else
            If tipoMant = "Ambos" Then
                Select Case tipoInforme
                    Case "Todos"
                        dt = fg.unionTodosFechas("Ambos", fechaInicio, fechaFinal)
                        crearPdf(dt, isUlt, tipoMant, tipoInforme)
                    Case "Codigo"
                        dt = CType(fg.unionCodigoFechas(id, "Ambos", fechaInicio, fechaFinal), DataTable)
                        crearPdf(dt, isUlt, tipoMant, tipoInforme)
                    Case "Marca"
                        dt = CType(fg.unionMarcaFechas(id, "Ambos", fechaInicio, fechaFinal), DataTable)
                        crearPdf(dt, isUlt, tipoMant, tipoInforme)
                    Case "Modelo"
                        dt = CType(fg.unionModeloFechas(id, "Ambos", fechaInicio, fechaFinal), DataTable)
                        crearPdf(dt, isUlt, tipoMant, tipoInforme)
                End Select
            ElseIf tipoMant = "Correctivo" Then
                Select Case tipoInforme
                    Case "Todos"
                        dt = CType(fg.unionTodosFechas("Correctivo", fechaInicio, fechaFinal), DataTable)
                        crearPdf(dt, isUlt, tipoMant, tipoInforme)
                    Case "Codigo"
                        dt = CType(fg.unionCodigoFechas(id, "Correctivo", fechaInicio, fechaFinal), DataTable)
                        crearPdf(dt, isUlt, tipoMant, tipoInforme)
                    Case "Marca"
                        dt = CType(fg.unionMarcaFechas(id, "Correctivo", fechaInicio, fechaFinal), DataTable)
                        crearPdf(dt, isUlt, tipoMant, tipoInforme)
                    Case "Modelo"
                        dt = CType(fg.unionModeloFechas(id, "Correctivo", fechaInicio, fechaFinal), DataTable)
                        crearPdf(dt, isUlt, tipoMant, tipoInforme)
                End Select
            ElseIf tipoMant = "Preventivo" Then
                Select Case tipoInforme
                    Case "Todos"
                        dt = CType(fg.unionTodosFechas("Preventivo", fechaInicio, fechaFinal), DataTable)
                        crearPdf(dt, isUlt, tipoMant, tipoInforme)
                    Case "Codigo"
                        dt = CType(fg.unionCodigoFechas(id, "Preventivo", fechaInicio, fechaFinal), DataTable)
                        crearPdf(dt, isUlt, tipoMant, tipoInforme)
                    Case "Marca"
                        dt = CType(fg.unionMarcaFechas(id, "Preventivo", fechaInicio, fechaFinal), DataTable)
                        crearPdf(dt, isUlt, tipoMant, tipoInforme)
                    Case "Modelo"
                        dt = CType(fg.unionModeloFechas(id, "Preventivo", fechaInicio, fechaFinal), DataTable)
                        crearPdf(dt, isUlt, tipoMant, tipoInforme)
                End Select
            End If
        End If
    End Sub

    Public Sub crearPdf(ByVal dt As DataTable, ByVal isUlt As Boolean, ByVal tipoMant As String, ByVal tipoInforme As String)
        Try
            Dim pdfDoc As New Document(iTextSharp.text.PageSize.A4, 15.0F, 15.0F, 30.0F, 30.0F)
            Dim pdfWrite As PdfWriter = PdfWriter.GetInstance(pdfDoc, New FileStream(My.Computer.FileSystem.SpecialDirectories.MyDocuments.ToString & "\Informe.pdf", FileMode.Create))

            Dim font8hel As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 8, iTextSharp.text.Font.NORMAL))
            Dim fontB8hel As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 8, iTextSharp.text.Font.BOLD))
            Dim font12times As New Font(FontFactory.GetFont(FontFactory.TIMES_ROMAN, 14, iTextSharp.text.Font.BOLD))
            Dim cVacio As PdfPCell = New PdfPCell(New Phrase(""))
            cVacio.Border = 0

            pdfDoc.Open()


            Dim col1 As PdfPCell
            Dim col2 As PdfPCell
            Dim col3 As PdfPCell
            Dim col4 As PdfPCell
            Dim col5 As PdfPCell
            Dim col6 As PdfPCell
            Dim col7 As PdfPCell
            Dim titulo As String = ""


            If isUlt Then
                If tipoMant = "Ambos" Then
                    titulo = "Informe de los Ultimos Mantenimientos de Todos los Tipos"
                    Select Case tipoInforme
                        Case "Todos"
                            encabezado(pdfDoc, cVacio, col1, col2, col3, col4, col5, font8hel, fontB8hel, font12times, titulo)
                            headers(pdfDoc, cVacio, col1, col2, col3, col4, col5, col6, col7, font8hel, fontB8hel, font12times, True)
                            tabla(pdfDoc, cVacio, col1, col2, col3, col4, col5, col6, col7, font8hel, fontB8hel, font12times, dt, True)
                        Case "Codigo"
                            titulo += " Por Código"
                            encabezado(pdfDoc, cVacio, col1, col2, col3, col4, col5, font8hel, fontB8hel, font12times, titulo)
                            headers(pdfDoc, cVacio, col1, col2, col3, col4, col5, col6, col7, font8hel, fontB8hel, font12times, True)
                            tabla(pdfDoc, cVacio, col1, col2, col3, col4, col5, col6, col7, font8hel, fontB8hel, font12times, dt, True)
                        Case "Marca"
                            titulo += " Por Marca"
                            encabezado(pdfDoc, cVacio, col1, col2, col3, col4, col5, font8hel, fontB8hel, font12times, titulo)
                            headers(pdfDoc, cVacio, col1, col2, col3, col4, col5, col6, col7, font8hel, fontB8hel, font12times, True)
                            tabla(pdfDoc, cVacio, col1, col2, col3, col4, col5, col6, col7, font8hel, fontB8hel, font12times, dt, True)
                        Case "Modelo"
                            titulo += " Por Modelo"
                            encabezado(pdfDoc, cVacio, col1, col2, col3, col4, col5, font8hel, fontB8hel, font12times, titulo)
                            headers(pdfDoc, cVacio, col1, col2, col3, col4, col5, col6, col7, font8hel, fontB8hel, font12times, True)
                            tabla(pdfDoc, cVacio, col1, col2, col3, col4, col5, col6, col7, font8hel, fontB8hel, font12times, dt, True)
                    End Select
                ElseIf tipoMant = "Correctivo" Then
                    titulo = "Informe de los Ultimos Mantenimientos Correctivos"
                    Select Case tipoInforme
                        Case "Todos"
                            encabezado(pdfDoc, cVacio, col1, col2, col3, col4, col5, font8hel, fontB8hel, font12times, titulo)
                            headers(pdfDoc, cVacio, col1, col2, col3, col4, col5, col6, col7, font8hel, fontB8hel, font12times, True)
                            tabla(pdfDoc, cVacio, col1, col2, col3, col4, col5, col6, col7, font8hel, fontB8hel, font12times, dt, True)
                        Case "Codigo"
                            titulo += " Por Código"
                            encabezado(pdfDoc, cVacio, col1, col2, col3, col4, col5, font8hel, fontB8hel, font12times, titulo)
                            headers(pdfDoc, cVacio, col1, col2, col3, col4, col5, col6, col7, font8hel, fontB8hel, font12times, True)
                            tabla(pdfDoc, cVacio, col1, col2, col3, col4, col5, col6, col7, font8hel, fontB8hel, font12times, dt, True)
                        Case "Marca"
                            titulo += " Por Marca"
                            encabezado(pdfDoc, cVacio, col1, col2, col3, col4, col5, font8hel, fontB8hel, font12times, titulo)
                            headers(pdfDoc, cVacio, col1, col2, col3, col4, col5, col6, col7, font8hel, fontB8hel, font12times, True)
                            tabla(pdfDoc, cVacio, col1, col2, col3, col4, col5, col6, col7, font8hel, fontB8hel, font12times, dt, True)
                        Case "Modelo"
                            titulo += " Por Modelo"
                            encabezado(pdfDoc, cVacio, col1, col2, col3, col4, col5, font8hel, fontB8hel, font12times, titulo)
                            headers(pdfDoc, cVacio, col1, col2, col3, col4, col5, col6, col7, font8hel, fontB8hel, font12times, True)
                            tabla(pdfDoc, cVacio, col1, col2, col3, col4, col5, col6, col7, font8hel, fontB8hel, font12times, dt, True)
                    End Select
                ElseIf tipoMant = "Preventivo" Then
                    titulo = "Informe de los Ultimos Mantenimientos Preventivos"
                    Select Case tipoInforme
                        Case "Todos"
                            encabezado(pdfDoc, cVacio, col1, col2, col3, col4, col5, font8hel, fontB8hel, font12times, titulo)
                            headers(pdfDoc, cVacio, col1, col2, col3, col4, col5, col6, col7, font8hel, fontB8hel, font12times, True)
                            tabla(pdfDoc, cVacio, col1, col2, col3, col4, col5, col6, col7, font8hel, fontB8hel, font12times, dt, True)
                        Case "Codigo"
                            titulo += " Por Código"
                            encabezado(pdfDoc, cVacio, col1, col2, col3, col4, col5, font8hel, fontB8hel, font12times, titulo)
                            headers(pdfDoc, cVacio, col1, col2, col3, col4, col5, col6, col7, font8hel, fontB8hel, font12times, True)
                            tabla(pdfDoc, cVacio, col1, col2, col3, col4, col5, col6, col7, font8hel, fontB8hel, font12times, dt, True)
                        Case "Marca"
                            titulo += " Por Marca"
                            encabezado(pdfDoc, cVacio, col1, col2, col3, col4, col5, font8hel, fontB8hel, font12times, titulo)
                            headers(pdfDoc, cVacio, col1, col2, col3, col4, col5, col6, col7, font8hel, fontB8hel, font12times, True)
                            tabla(pdfDoc, cVacio, col1, col2, col3, col4, col5, col6, col7, font8hel, fontB8hel, font12times, dt, True)
                        Case "Modelo"
                            titulo += " Por Modelo"
                            encabezado(pdfDoc, cVacio, col1, col2, col3, col4, col5, font8hel, fontB8hel, font12times, titulo)
                            headers(pdfDoc, cVacio, col1, col2, col3, col4, col5, col6, col7, font8hel, fontB8hel, font12times, True)
                            tabla(pdfDoc, cVacio, col1, col2, col3, col4, col5, col6, col7, font8hel, fontB8hel, font12times, dt, True)
                    End Select
                End If
            Else
                Dim fe = " en un Intervalo de Fechas"
                If tipoMant = "Ambos" Then
                    titulo = "Informe de Mantenimientos de Todos los Tipos"
                    Select Case tipoInforme
                        Case "Todos"
                            titulo += fe
                            encabezado(pdfDoc, cVacio, col1, col2, col3, col4, col5, font8hel, fontB8hel, font12times, titulo)
                            headers(pdfDoc, cVacio, col1, col2, col3, col4, col5, col6, col7, font8hel, fontB8hel, font12times, True)
                            tabla(pdfDoc, cVacio, col1, col2, col3, col4, col5, col6, col7, font8hel, fontB8hel, font12times, dt, True)
                        Case "Codigo"
                            titulo += " Por Código" + fe
                            encabezado(pdfDoc, cVacio, col1, col2, col3, col4, col5, font8hel, fontB8hel, font12times, titulo)
                            headers(pdfDoc, cVacio, col1, col2, col3, col4, col5, col6, col7, font8hel, fontB8hel, font12times, True)
                            tabla(pdfDoc, cVacio, col1, col2, col3, col4, col5, col6, col7, font8hel, fontB8hel, font12times, dt, True)
                        Case "Marca"
                            titulo += " Por Marca" + fe
                            encabezado(pdfDoc, cVacio, col1, col2, col3, col4, col5, font8hel, fontB8hel, font12times, titulo)
                            headers(pdfDoc, cVacio, col1, col2, col3, col4, col5, col6, col7, font8hel, fontB8hel, font12times, True)
                            tabla(pdfDoc, cVacio, col1, col2, col3, col4, col5, col6, col7, font8hel, fontB8hel, font12times, dt, True)
                        Case "Modelo"
                            titulo += " Por Modelo" + fe
                            encabezado(pdfDoc, cVacio, col1, col2, col3, col4, col5, font8hel, fontB8hel, font12times, titulo)
                            headers(pdfDoc, cVacio, col1, col2, col3, col4, col5, col6, col7, font8hel, fontB8hel, font12times, True)
                            tabla(pdfDoc, cVacio, col1, col2, col3, col4, col5, col6, col7, font8hel, fontB8hel, font12times, dt, True)
                    End Select
                ElseIf tipoMant = "Correctivo" Then
                    titulo = "Informe de Mantenimientos Correctivos"
                    Select Case tipoInforme
                        Case "Todos"
                            titulo += fe
                            encabezado(pdfDoc, cVacio, col1, col2, col3, col4, col5, font8hel, fontB8hel, font12times, titulo)
                            headers(pdfDoc, cVacio, col1, col2, col3, col4, col5, col6, col7, font8hel, fontB8hel, font12times, True)
                            tabla(pdfDoc, cVacio, col1, col2, col3, col4, col5, col6, col7, font8hel, fontB8hel, font12times, dt, True)
                        Case "Codigo"
                            titulo += " Por Código" + fe
                            encabezado(pdfDoc, cVacio, col1, col2, col3, col4, col5, font8hel, fontB8hel, font12times, titulo)
                            headers(pdfDoc, cVacio, col1, col2, col3, col4, col5, col6, col7, font8hel, fontB8hel, font12times, True)
                            tabla(pdfDoc, cVacio, col1, col2, col3, col4, col5, col6, col7, font8hel, fontB8hel, font12times, dt, True)
                        Case "Marca"
                            titulo += " Por Marca" + fe
                            encabezado(pdfDoc, cVacio, col1, col2, col3, col4, col5, font8hel, fontB8hel, font12times, titulo)
                            headers(pdfDoc, cVacio, col1, col2, col3, col4, col5, col6, col7, font8hel, fontB8hel, font12times, True)
                            tabla(pdfDoc, cVacio, col1, col2, col3, col4, col5, col6, col7, font8hel, fontB8hel, font12times, dt, True)
                        Case "Modelo"
                            titulo += " Por Modelo" + fe
                            encabezado(pdfDoc, cVacio, col1, col2, col3, col4, col5, font8hel, fontB8hel, font12times, titulo)
                            headers(pdfDoc, cVacio, col1, col2, col3, col4, col5, col6, col7, font8hel, fontB8hel, font12times, True)
                            tabla(pdfDoc, cVacio, col1, col2, col3, col4, col5, col6, col7, font8hel, fontB8hel, font12times, dt, True)
                    End Select
                ElseIf tipoMant = "Preventivo" Then
                    titulo = "Informe de Mantenimientos Preventivos"
                    Select Case tipoInforme
                        Case "Todos"
                            titulo += fe
                            encabezado(pdfDoc, cVacio, col1, col2, col3, col4, col5, font8hel, fontB8hel, font12times, titulo)
                            headers(pdfDoc, cVacio, col1, col2, col3, col4, col5, col6, col7, font8hel, fontB8hel, font12times, True)
                            tabla(pdfDoc, cVacio, col1, col2, col3, col4, col5, col6, col7, font8hel, fontB8hel, font12times, dt, True)
                        Case "Codigo"
                            titulo += " Por Código" + fe
                            encabezado(pdfDoc, cVacio, col1, col2, col3, col4, col5, font8hel, fontB8hel, font12times, titulo)
                            headers(pdfDoc, cVacio, col1, col2, col3, col4, col5, col6, col7, font8hel, fontB8hel, font12times, True)
                            tabla(pdfDoc, cVacio, col1, col2, col3, col4, col5, col6, col7, font8hel, fontB8hel, font12times, dt, True)
                        Case "Marca"
                            titulo += " Por Marca" + fe
                            encabezado(pdfDoc, cVacio, col1, col2, col3, col4, col5, font8hel, fontB8hel, font12times, titulo)
                            headers(pdfDoc, cVacio, col1, col2, col3, col4, col5, col6, col7, font8hel, fontB8hel, font12times, True)
                            tabla(pdfDoc, cVacio, col1, col2, col3, col4, col5, col6, col7, font8hel, fontB8hel, font12times, dt, True)
                        Case "Modelo"
                            titulo += " Por Modelo" + fe
                            encabezado(pdfDoc, cVacio, col1, col2, col3, col4, col5, font8hel, fontB8hel, font12times, titulo)
                            headers(pdfDoc, cVacio, col1, col2, col3, col4, col5, col6, col7, font8hel, fontB8hel, font12times, True)
                            tabla(pdfDoc, cVacio, col1, col2, col3, col4, col5, col6, col7, font8hel, fontB8hel, font12times, dt, True)
                    End Select
                End If
            End If


            pdfDoc.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Sub encabezado(ByVal pdfDoc As Document, ByVal cVacio As PdfPCell, ByVal col1 As PdfPCell, ByVal col2 As PdfPCell, ByVal col3 As PdfPCell, ByVal col4 As PdfPCell, ByVal col5 As PdfPCell, ByVal font8hel As Font, ByVal fontB8hel As Font, ByVal font8times As Font, ByVal titulo As String)
        ' --------------------------------------------- ENCABEZADO ---------------------------------------------
        Dim table1 As PdfPTable = New PdfPTable(3)
        table1.WidthPercentage = 95
        Dim widths As Single() = New Single() {6.0F, 6.0F, 5.0F}
        table1.SetWidths(widths)
        Dim imagenURL As String = "logo.png"
        Dim imagenBMP As iTextSharp.text.Image
        imagenBMP = iTextSharp.text.Image.GetInstance(imagenURL)
        imagenBMP.ScaleToFit(60.0F, 80.0F)
        imagenBMP.SpacingBefore = 20.0F
        imagenBMP.SpacingAfter = 10.0F
        imagenBMP.SetAbsolutePosition(40, 770)
        pdfDoc.Add(imagenBMP)

        cVacio.Rowspan = 5
        table1.AddCell(cVacio)


        col1 = New PdfPCell(New Phrase(titulo, font8times))
        col1.VerticalAlignment = Element.ALIGN_MIDDLE
        col1.Border = 0
        col1.Rowspan = 5
        table1.AddCell(col1)

        col1 = New PdfPCell(New Phrase("U. E. 'Miguel Otero Silva'", fontB8hel))
        col1.HorizontalAlignment = Element.ALIGN_RIGHT
        col1.Border = 0
        table1.AddCell(col1)
        col2 = New PdfPCell(New Phrase("Puerto La Cruz, Calle Marino", font8hel))
        col2.HorizontalAlignment = Element.ALIGN_RIGHT
        col2.Border = 0
        table1.AddCell(col2)
        col3 = New PdfPCell(New Phrase("Anzoátegui - Anzoátegui - Anzoátegui", font8hel))
        col3.HorizontalAlignment = Element.ALIGN_RIGHT
        col3.Border = 0
        table1.AddCell(col3)
        col4 = New PdfPCell(New Phrase("(+58) 281-2680881", font8hel))
        col4.HorizontalAlignment = Element.ALIGN_RIGHT
        col4.Border = 0
        table1.AddCell(col4)
        col5 = New PdfPCell(New Phrase("", font8hel))
        col5.HorizontalAlignment = Element.ALIGN_RIGHT
        col5.Border = 0
        table1.AddCell(col5)

        cVacio.Colspan = 5
        cVacio.Border = 1
        cVacio.Rowspan = 1
        table1.AddCell(cVacio)

        pdfDoc.Add(table1)
        ' -----------------------------------------------------------------------------------------------------

    End Sub
    Public Sub headers(ByVal pdfDoc As Document, ByVal cVacio As PdfPCell, ByVal col1 As PdfPCell, ByVal col2 As PdfPCell, ByVal col3 As PdfPCell, ByVal col4 As PdfPCell, ByVal col5 As PdfPCell, ByVal col6 As PdfPCell, ByVal col7 As PdfPCell, ByVal font8hel As Font, ByVal fontB8hel As Font, ByVal font8times As Font, Optional ByVal solo As Boolean = False)
        Dim table3 As PdfPTable
        Dim widths3 As Single()

        table3 = New PdfPTable(7)
        widths3 = New Single() {3.0F, 1.0F, 1.0F, 2.0F, 4.0F, 2.0F, 2.0F}

        table3.SpacingBefore = 20.0F
        table3.WidthPercentage = 95
        table3.SetWidths(widths3)

        col1 = New PdfPCell(New Phrase("Código del Equipo", fontB8hel))
        col1.HorizontalAlignment = Element.ALIGN_LEFT
        table3.AddCell(col1)

        col2 = New PdfPCell(New Phrase("Marca", fontB8hel))
        col2.HorizontalAlignment = Element.ALIGN_LEFT
        table3.AddCell(col2)

        col3 = New PdfPCell(New Phrase("Modelo", fontB8hel))
        col3.HorizontalAlignment = Element.ALIGN_LEFT
        table3.AddCell(col3)

        col4 = New PdfPCell(New Phrase("Id Mantenimiento", fontB8hel))
        col4.HorizontalAlignment = Element.ALIGN_LEFT
        table3.AddCell(col4)

        col5 = New PdfPCell(New Phrase("Descripcion", fontB8hel))
        col5.HorizontalAlignment = Element.ALIGN_LEFT
        table3.AddCell(col5)

        col6 = New PdfPCell(New Phrase("Tipo de mantenimiento", fontB8hel))
        col6.HorizontalAlignment = Element.ALIGN_LEFT
        table3.AddCell(col6)

        col7 = New PdfPCell(New Phrase("Fecha del mantenimiento", fontB8hel))
        col7.HorizontalAlignment = Element.ALIGN_LEFT
        table3.AddCell(col7)


        pdfDoc.Add(table3)
    End Sub
    Public Sub tabla(ByVal pdfDoc As Document, ByVal cVacio As PdfPCell, ByVal col1 As PdfPCell, ByVal col2 As PdfPCell, ByVal col3 As PdfPCell, ByVal col4 As PdfPCell, ByVal col5 As PdfPCell, ByVal col6 As PdfPCell, ByVal col7 As PdfPCell, ByVal font8hel As Font, ByVal fontB8hel As Font, ByVal font8times As Font, ByVal dt As DataTable, Optional ByVal solo As Boolean = False)
        Dim table4 As PdfPTable
        Dim widths4 As Single()

        table4 = New PdfPTable(7)
        widths4 = New Single() {3.0F, 1.0F, 1.0F, 2.0F, 4.0F, 2.0F, 2.0F}

        table4.WidthPercentage = 95
        table4.SetWidths(widths4)
        Dim i As Integer

        For i = 0 To (dt.Rows.Count - 1)
            col1 = New PdfPCell(New Phrase(dt(i)("CodEquipo").ToString, font8hel))
            col1.HorizontalAlignment = Element.ALIGN_LEFT
            table4.AddCell(col1)

            col2 = New PdfPCell(New Phrase(dt(i)("Marca").ToString, font8hel))
            col2.HorizontalAlignment = Element.ALIGN_LEFT
            table4.AddCell(col2)

            col3 = New PdfPCell(New Phrase(dt(i)("Modelo").ToString, font8hel))
            col3.HorizontalAlignment = Element.ALIGN_LEFT
            table4.AddCell(col3)

            col4 = New PdfPCell(New Phrase(dt(i)("IDMantenimiento").ToString, font8hel))
            col4.HorizontalAlignment = Element.ALIGN_LEFT
            table4.AddCell(col4)

            col5 = New PdfPCell(New Phrase(dt(i)("Descripcion").ToString, font8hel))
            col5.HorizontalAlignment = Element.ALIGN_LEFT
            table4.AddCell(col5)

            If CBool(dt(i)("EsPreventiva")) Then
                col6 = New PdfPCell(New Phrase("Preventivo", font8hel))
            Else
                col6 = New PdfPCell(New Phrase("Correctivo", font8hel))
            End If
            col6.HorizontalAlignment = Element.ALIGN_LEFT
            table4.AddCell(col6)

            Dim fecha As Date
            Dim fechaStr As String
            fecha = CDate(dt(i)("Fecha"))
            If Not IsDBNull(fecha) Then
                fechaStr = fecha.Day.ToString & "/" & fecha.Month.ToString & "/" & fecha.Year.ToString
            Else
                fechaStr = ""
            End If

            col7 = New PdfPCell(New Phrase(fechaStr, font8hel))
            col7.HorizontalAlignment = Element.ALIGN_LEFT
            table4.AddCell(col7)
        Next
        pdfDoc.Add(table4)
    End Sub

End Class
