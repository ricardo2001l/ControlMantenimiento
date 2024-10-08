<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class acercaDe
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(acercaDe))
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnManual = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Old English Text MT", 12.75!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(35, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(237, 21)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "U. E. ""Miguel Otero Silva"""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Old English Text MT", 21.75!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(24, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(343, 34)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Control de Mantenimiento"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Old English Text MT", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 28)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Acerca de:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bookman Old Style", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(62, 141)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 19)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Versión"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(308, 141)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(28, 18)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "1.0"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(59, 241)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(281, 54)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Un programa diseñado para mantener la" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "organización de los mantenimientos" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "realiz" &
    "ados en la U. E ""Miguel Otero Silva""."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(222, 184)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(118, 18)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Ricardo Astudillo"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Bookman Old Style", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(62, 183)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(125, 19)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Programado por"
        '
        'btnManual
        '
        Me.btnManual.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnManual.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnManual.Font = New System.Drawing.Font("Bookman Old Style", 12.0!)
        Me.btnManual.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnManual.Location = New System.Drawing.Point(198, 327)
        Me.btnManual.Name = "btnManual"
        Me.btnManual.Size = New System.Drawing.Size(180, 28)
        Me.btnManual.TabIndex = 24
        Me.btnManual.Text = "Manual de usuario"
        Me.btnManual.UseVisualStyleBackColor = False
        '
        'acercaDe
        '
        Me.AcceptButton = Me.btnManual
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(390, 367)
        Me.Controls.Add(Me.btnManual)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Font = New System.Drawing.Font("Bookman Old Style", 9.75!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "acercaDe"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Acerca de Control de Mantenimiento"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnManual As System.Windows.Forms.Button
End Class
