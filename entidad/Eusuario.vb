Public Class Eusuario
    Private nombreUsuario, cedula, contrasena, nombre, apellido, tipo As String

    Public Property _nombreUsuario As String
        Get
            Return nombreUsuario
        End Get
        Set(ByVal value As String)
            nombreUsuario = value
        End Set
    End Property
    Public Property _cedula As String
        Get
            Return cedula
        End Get
        Set(ByVal value As String)
            cedula = value
        End Set
    End Property
    Public Property _contrasena As String
        Get
            Return contrasena
        End Get
        Set(ByVal value As String)
            contrasena = value
        End Set
    End Property
    Public Property _nombre As String
        Get
            Return nombre
        End Get
        Set(ByVal value As String)
            nombre = value
        End Set
    End Property
    Public Property _apellido As String
        Get
            Return apellido
        End Get
        Set(ByVal value As String)
            apellido = value
        End Set
    End Property
    Public Property _tipo As String
        Get
            Return tipo
        End Get
        Set(ByVal value As String)
            tipo = value
        End Set
    End Property


    Public Sub New()

    End Sub
End Class
