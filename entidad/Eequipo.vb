Public Class Eequipo
    Private codEquipo, marca, modelo, piezas As String

    Public Property _codEquipo As String
        Get
            Return codEquipo
        End Get
        Set(ByVal value As String)
            codEquipo = value
        End Set
    End Property
    Public Property _marca As String
        Get
            Return marca
        End Get
        Set(ByVal value As String)
            marca = value
        End Set
    End Property
    Public Property _modelo As String
        Get
            Return modelo
        End Get
        Set(ByVal value As String)
            modelo = value
        End Set
    End Property

    Public Property _piezas As String
        Get
            Return piezas
        End Get
        Set(ByVal value As String)
            piezas = value
        End Set
    End Property

    Public Sub New()

    End Sub
End Class
