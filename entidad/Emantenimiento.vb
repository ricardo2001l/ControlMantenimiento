Public Class Emantenimiento
    Private idMantenimiento, codEquipo, descripcion As String
    Private fecha As Date
    Private esPreventiva As Boolean

    Public Property _idMantenimiento As String
        Get
            Return idMantenimiento
        End Get
        Set(ByVal value As String)
            idMantenimiento = value
        End Set
    End Property
    Public Property _fecha As Date
        Get
            Return fecha
        End Get
        Set(ByVal value As Date)
            fecha = value
        End Set
    End Property
    Public Property _codEquipo As String
        Get
            Return codEquipo
        End Get
        Set(ByVal value As String)
            codEquipo = value
        End Set
    End Property
    Public Property _descripcion As String
        Get
            Return descripcion
        End Get
        Set(ByVal value As String)
            descripcion = value
        End Set
    End Property
    Public Property _esPreventiva As Boolean
        Get
            Return esPreventiva
        End Get
        Set(ByVal value As Boolean)
            esPreventiva = value
        End Set
    End Property

    Public Sub New()

    End Sub
End Class
