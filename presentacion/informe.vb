Imports entidad
Imports datos

Public Class informe
    Dim fpdf As New Fpdf
    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        mainMenu.Show()
        Me.Close()
    End Sub

    Private Sub informe_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llenarCmb(Me.cmbCodEquipoFechas, "CodEquipo", "TEquipo")
        llenarCmb(Me.cmbCodEquipoUlt, "CodEquipo", "TEquipo")

        llenarCmb(Me.cmbMarcaFechas, "Marca", "TEquipo")
        llenarCmb(Me.cmbMarcaUlt, "Marca", "TEquipo")

        llenarCmb(Me.cmbModeloFechas, "Modelo", "TEquipo")
        llenarCmb(Me.cmbModeloUlt, "Modelo", "TEquipo")
    End Sub


    Private Sub radioCodigoUlt_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles radioCodigoUlt.CheckedChanged
        If Me.radioCodigoUlt.Checked Then
            Me.cmbCodEquipoUlt.Enabled = True
            Me.cmbMarcaUlt.Enabled = False
            Me.cmbModeloUlt.Enabled = False
        End If
    End Sub
    Private Sub radioMarcaUlt_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles radioMarcaUlt.CheckedChanged
        If Me.radioMarcaUlt.Checked Then
            Me.cmbCodEquipoUlt.Enabled = False
            Me.cmbMarcaUlt.Enabled = True
            Me.cmbModeloUlt.Enabled = False
        End If
    End Sub
    Private Sub radioModeloUlt_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles radioModeloUlt.CheckedChanged
        If Me.radioModeloUlt.Checked Then
            Me.cmbCodEquipoUlt.Enabled = False
            Me.cmbMarcaUlt.Enabled = False
            Me.cmbModeloUlt.Enabled = True
        End If
    End Sub
    Private Sub radioTodosUlt_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles radioTodosUlt.CheckedChanged
        If Me.radioTodosUlt.Checked Then
            Me.cmbCodEquipoUlt.Enabled = False
            Me.cmbMarcaUlt.Enabled = False
            Me.cmbModeloUlt.Enabled = False
        End If
    End Sub

    Private Sub radioCodigoFechas_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles radioCodigoFechas.CheckedChanged
        If Me.radioCodigoFechas.Checked Then
            Me.cmbCodEquipoFechas.Enabled = True
            Me.cmbMarcaFechas.Enabled = False
            Me.cmbModeloFechas.Enabled = False
        End If
    End Sub
    Private Sub radioMarcaFechas_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles radioMarcaFechas.CheckedChanged
        If Me.radioMarcaFechas.Checked Then
            Me.cmbCodEquipoFechas.Enabled = False
            Me.cmbMarcaFechas.Enabled = True
            Me.cmbModeloFechas.Enabled = False
        End If
    End Sub
    Private Sub radioModeloFechas_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles radioModeloFechas.CheckedChanged
        If Me.radioModeloFechas.Checked Then
            Me.cmbCodEquipoFechas.Enabled = False
            Me.cmbMarcaFechas.Enabled = False
            Me.cmbModeloFechas.Enabled = True
        End If
    End Sub
    Private Sub radioTodosFechas_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles radioTodosFechas.CheckedChanged
        If Me.radioTodosFechas.Checked Then
            Me.cmbCodEquipoFechas.Enabled = False
            Me.cmbMarcaFechas.Enabled = False
            Me.cmbModeloFechas.Enabled = False
        End If
    End Sub

    Private Sub btnRealizarUlt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRealizarUlt.Click
        If Me.radioAmbosUlt.Checked Then
            If Me.radioTodosUlt.Checked Then
                fpdf.iniciarPdf(True, "Todos", "Ambos")
            ElseIf Me.radioCodigoUlt.Checked Then
                fpdf.iniciarPdf(True, "Codigo", "Ambos", Me.cmbCodEquipoUlt.Text)
            ElseIf Me.radioMarcaUlt.Checked Then
                fpdf.iniciarPdf(True, "Marca", "Ambos", Me.cmbMarcaUlt.Text)
            ElseIf Me.radioModeloUlt.Checked Then
                fpdf.iniciarPdf(True, "Modelo", "Ambos", Me.cmbModeloUlt.Text)
            End If
        ElseIf Me.radioCorrectivoUlt.Checked Then
            If Me.radioTodosUlt.Checked Then
                fpdf.iniciarPdf(True, "Todos", "Correctivo")
            ElseIf Me.radioCodigoUlt.Checked Then
                fpdf.iniciarPdf(True, "Codigo", "Correctivo", Me.cmbCodEquipoUlt.Text)
            ElseIf Me.radioMarcaUlt.Checked Then
                fpdf.iniciarPdf(True, "Marca", "Correctivo", Me.cmbMarcaUlt.Text)
            ElseIf Me.radioModeloUlt.Checked Then
                fpdf.iniciarPdf(True, "Modelo", "Correctivo", Me.cmbModeloUlt.Text)
            End If
        ElseIf Me.radioPreventivoUlt.Checked Then
            If Me.radioTodosUlt.Checked Then
                fpdf.iniciarPdf(True, "Todos", "Preventivo")
            ElseIf Me.radioCodigoUlt.Checked Then
                fpdf.iniciarPdf(True, "Codigo", "Preventivo", Me.cmbCodEquipoUlt.Text)
            ElseIf Me.radioMarcaUlt.Checked Then
                fpdf.iniciarPdf(True, "Marca", "Preventivo", Me.cmbMarcaUlt.Text)
            ElseIf Me.radioModeloUlt.Checked Then
                fpdf.iniciarPdf(True, "Modelo", "Preventivo", Me.cmbModeloUlt.Text)
            End If
        End If
        MsgBox("El archivo se encuentra en 'Documentos\Informe.pdf'. Cuidado, si desea realizar otro informe, mueva el archivo 'informe.pdf' o cámbiele el nombre.", MsgBoxStyle.Information, "Creación exitosa")
    End Sub

    Private Sub btnRealizarFechas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRealizarFechas.Click
        Dim fechaIniStr As String = ""
        If CInt(Me.fechaInicial.Value.Day) <= 12 Then
            fechaIniStr = Me.fechaInicial.Value.Month.ToString & "/" & Me.fechaInicial.Value.Day.ToString & "/" & Me.fechaInicial.Value.Year.ToString
        Else
            fechaIniStr = Me.fechaInicial.Value.Day.ToString & "/" & Me.fechaInicial.Value.Month.ToString & "/" & Me.fechaInicial.Value.Year.ToString
        End If

        Dim fechaFinStr As String = ""
        If CInt(Me.fechaInicial.Value.Day) <= 12 Then
            fechaFinStr = Me.fechaFinal.Value.Month.ToString & "/" & Me.fechaFinal.Value.Day.ToString & "/" & Me.fechaFinal.Value.Year.ToString
        Else
            fechaFinStr = Me.fechaFinal.Value.Day.ToString & "/" & Me.fechaFinal.Value.Month.ToString & "/" & Me.fechaFinal.Value.Year.ToString
        End If

        If Me.radioAmbosFechas.Checked Then
            If Me.radioTodosFechas.Checked Then
                fpdf.iniciarPdf(False, "Todos", "Ambos", fechaInicio:=fechaIniStr, fechaFinal:=fechaFinStr)
            ElseIf Me.radioCodigoFechas.Checked Then
                fpdf.iniciarPdf(False, "Codigo", "Ambos", Me.cmbCodEquipoFechas.Text, fechaInicio:=fechaIniStr, fechaFinal:=fechaFinStr)
            ElseIf Me.radioMarcaFechas.Checked Then
                fpdf.iniciarPdf(False, "Marca", "Ambos", Me.cmbMarcaFechas.Text, fechaInicio:=fechaIniStr, fechaFinal:=fechaFinStr)
            ElseIf Me.radioModeloFechas.Checked Then
                fpdf.iniciarPdf(False, "Modelo", "Ambos", Me.cmbModeloFechas.Text, fechaInicio:=fechaIniStr, fechaFinal:=fechaFinStr)
            End If
        ElseIf Me.radioCorrectivoFechas.Checked Then
            If Me.radioTodosFechas.Checked Then
                fpdf.iniciarPdf(False, "Todos", "Correctivo", fechaInicio:=fechaIniStr, fechaFinal:=fechaFinStr)
            ElseIf Me.radioCodigoFechas.Checked Then
                fpdf.iniciarPdf(False, "Codigo", "Correctivo", Me.cmbCodEquipoFechas.Text, fechaInicio:=fechaIniStr, fechaFinal:=fechaFinStr)
            ElseIf Me.radioMarcaFechas.Checked Then
                fpdf.iniciarPdf(False, "Marca", "Correctivo", Me.cmbMarcaFechas.Text, fechaInicio:=fechaIniStr, fechaFinal:=fechaFinStr)
            ElseIf Me.radioModeloFechas.Checked Then
                fpdf.iniciarPdf(False, "Modelo", "Correctivo", Me.cmbModeloFechas.Text, fechaInicio:=fechaIniStr, fechaFinal:=fechaFinStr)
            End If
        ElseIf Me.radioPreventivoFechas.Checked Then
            If Me.radioTodosFechas.Checked Then
                fpdf.iniciarPdf(False, "Todos", "Preventivo", fechaInicio:=fechaIniStr, fechaFinal:=fechaFinStr)
            ElseIf Me.radioCodigoFechas.Checked Then
                fpdf.iniciarPdf(False, "Codigo", "Preventivo", Me.cmbCodEquipoFechas.Text, fechaInicio:=fechaIniStr, fechaFinal:=fechaFinStr)
            ElseIf Me.radioMarcaFechas.Checked Then
                fpdf.iniciarPdf(False, "Marca", "Preventivo", Me.cmbMarcaFechas.Text, fechaInicio:=fechaIniStr, fechaFinal:=fechaFinStr)
            ElseIf Me.radioModeloFechas.Checked Then
                fpdf.iniciarPdf(False, "Modelo", "Preventivo", Me.cmbModeloFechas.Text, fechaInicio:=fechaIniStr, fechaFinal:=fechaFinStr)
            End If
        End If
        MsgBox("El archivo se encuentra en 'Documentos\Informe.pdf'. Cuidado, si desea realizar otro informe, mueva el archivo 'informe.pdf' o cámbiele el nombre.", MsgBoxStyle.Information, "Creación exitosa")
    End Sub
End Class