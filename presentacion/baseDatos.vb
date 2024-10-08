Imports entidad
Imports datos

Public Class baseDatos

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        mainMenu.Show()
        Me.Close()
    End Sub

    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
        exportardb(SaveFileDialog1)
    End Sub

    Private Sub btnImportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImportar.Click
        importardb(SaveFileDialog1)
    End Sub

    Public Sub exportardb(ByVal SaveFileDialog1 As System.Windows.Forms.SaveFileDialog)
        SaveFileDialog1.Filter = "Access Files |*.accdb"
        SaveFileDialog1.FileName = "controlMantenimiento.accdb"
        SaveFileDialog1.OverwritePrompt = False
        SaveFileDialog1.AddExtension = True
        Dim guardado As Integer = SaveFileDialog1.ShowDialog()

        Dim path As String = SaveFileDialog1.FileName
        If guardado = 1 Then
            If My.Computer.FileSystem.FileExists(path) And path <> "controlMantenimiento.accdb" Then
                My.Computer.FileSystem.DeleteFile(path)
                My.Computer.FileSystem.CopyFile("controlMantenimiento.accdb", path)
            Else
                My.Computer.FileSystem.CopyFile("controlMantenimiento.accdb", path)
            End If
            MsgBox("Se ha exportado la base de datos correctamente", MsgBoxStyle.Information, "Se exportó con exito")
        End If
        SaveFileDialog1.Reset()
    End Sub

    Public Sub importardb(ByVal SaveFileDialog1 As System.Windows.Forms.SaveFileDialog)
        SaveFileDialog1.Filter = "Access Files |*.accdb"
        SaveFileDialog1.FileName = "archivo.accdb"
        SaveFileDialog1.OverwritePrompt = False
        SaveFileDialog1.AddExtension = True
        Dim guardado As Integer = SaveFileDialog1.ShowDialog()

        Dim path As String = SaveFileDialog1.FileName
        If guardado = 1 Then
            If My.Computer.FileSystem.FileExists(path) Then
                Try
                    My.Computer.FileSystem.DeleteFile("controlMantenimiento.accdb")
                    My.Computer.FileSystem.CopyFile(path, "controlMantenimiento.accdb")
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                MsgBox("Se ha importado la base de datos correctamente", MsgBoxStyle.Information, "Se importó con exito")
            End If
        End If
        SaveFileDialog1.Reset()
    End Sub
End Class