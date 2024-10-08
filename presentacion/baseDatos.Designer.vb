<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class baseDatos
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(baseDatos))
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.btnExportar = New System.Windows.Forms.Button()
        Me.btnImportar = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.SuspendLayout()
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Old English Text MT", 14.25!)
        Me.Label13.Location = New System.Drawing.Point(124, 86)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(214, 23)
        Me.Label13.TabIndex = 21
        Me.Label13.Text = "Administrar Base de Datos"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Old English Text MT", 12.75!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(116, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(237, 21)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "U. E. ""Miguel Otero Silva"""
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Old English Text MT", 21.75!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(68, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(343, 34)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Control de Mantenimiento"
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnSalir.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSalir.Font = New System.Drawing.Font("Bookman Old Style", 12.0!)
        Me.btnSalir.Location = New System.Drawing.Point(14, 318)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(97, 31)
        Me.btnSalir.TabIndex = 22
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnVolver
        '
        Me.btnVolver.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnVolver.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnVolver.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnVolver.Font = New System.Drawing.Font("Bookman Old Style", 12.0!)
        Me.btnVolver.Location = New System.Drawing.Point(369, 318)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(97, 31)
        Me.btnVolver.TabIndex = 27
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = False
        '
        'btnExportar
        '
        Me.btnExportar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnExportar.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnExportar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExportar.Font = New System.Drawing.Font("Bookman Old Style", 12.0!)
        Me.btnExportar.Location = New System.Drawing.Point(74, 168)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(337, 31)
        Me.btnExportar.TabIndex = 28
        Me.btnExportar.Text = "Exportar Base de Datos"
        Me.btnExportar.UseVisualStyleBackColor = False
        '
        'btnImportar
        '
        Me.btnImportar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnImportar.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnImportar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnImportar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnImportar.Font = New System.Drawing.Font("Bookman Old Style", 12.0!)
        Me.btnImportar.Location = New System.Drawing.Point(74, 239)
        Me.btnImportar.Name = "btnImportar"
        Me.btnImportar.Size = New System.Drawing.Size(337, 31)
        Me.btnImportar.TabIndex = 29
        Me.btnImportar.Text = "Importar Base de Datos"
        Me.btnImportar.UseVisualStyleBackColor = False
        '
        'baseDatos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.CancelButton = Me.btnSalir
        Me.ClientSize = New System.Drawing.Size(484, 374)
        Me.Controls.Add(Me.btnImportar)
        Me.Controls.Add(Me.btnExportar)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnSalir)
        Me.Font = New System.Drawing.Font("Bookman Old Style", 9.75!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(500, 400)
        Me.Name = "baseDatos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administrar Base de Datos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents btnExportar As System.Windows.Forms.Button
    Friend WithEvents btnImportar As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
End Class
