<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class iniciarSesion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(iniciarSesion))
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtContrasena = New System.Windows.Forms.TextBox()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnIniciar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Old English Text MT", 12.75!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(71, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(237, 21)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "U. E. ""Miguel Otero Silva"""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Old English Text MT", 21.75!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(23, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(343, 34)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Control de Mantenimiento"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Bookman Old Style", 11.25!)
        Me.Label2.Location = New System.Drawing.Point(51, 221)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 19)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Contraseña"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bookman Old Style", 11.25!)
        Me.Label1.Location = New System.Drawing.Point(51, 128)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 19)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Usuario"
        '
        'txtContrasena
        '
        Me.txtContrasena.Font = New System.Drawing.Font("Bookman Old Style", 9.75!)
        Me.txtContrasena.Location = New System.Drawing.Point(54, 251)
        Me.txtContrasena.Name = "txtContrasena"
        Me.txtContrasena.Size = New System.Drawing.Size(284, 23)
        Me.txtContrasena.TabIndex = 10
        Me.txtContrasena.UseSystemPasswordChar = True
        '
        'txtUsuario
        '
        Me.txtUsuario.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
        Me.txtUsuario.Font = New System.Drawing.Font("Bookman Old Style", 9.75!)
        Me.txtUsuario.Location = New System.Drawing.Point(54, 160)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(284, 23)
        Me.txtUsuario.TabIndex = 9
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSalir.Font = New System.Drawing.Font("Bookman Old Style", 12.0!)
        Me.btnSalir.Location = New System.Drawing.Point(54, 367)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(97, 31)
        Me.btnSalir.TabIndex = 11
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnIniciar
        '
        Me.btnIniciar.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnIniciar.Font = New System.Drawing.Font("Bookman Old Style", 12.0!)
        Me.btnIniciar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnIniciar.Location = New System.Drawing.Point(240, 367)
        Me.btnIniciar.Name = "btnIniciar"
        Me.btnIniciar.Size = New System.Drawing.Size(98, 31)
        Me.btnIniciar.TabIndex = 8
        Me.btnIniciar.Text = "Iniciar"
        Me.btnIniciar.UseVisualStyleBackColor = False
        '
        'iniciarSesion
        '
        Me.AcceptButton = Me.btnIniciar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.CancelButton = Me.btnSalir
        Me.ClientSize = New System.Drawing.Size(390, 467)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtContrasena)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnIniciar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "iniciarSesion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Iniciar Sesión"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtContrasena As System.Windows.Forms.TextBox
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnIniciar As System.Windows.Forms.Button

End Class
