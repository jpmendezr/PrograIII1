Public Class AgendarCita

    Private Fecha As Date
    Private Hora As Date
    Private EspecialidadM As String
    Private NombreM As String
    Private NombreP As String

    Public Property Fecha1 As Date
        Get
            Return Fecha
        End Get
        Set(value As Date)
            Fecha = value
        End Set
    End Property

    Public Property Hora1 As Date
        Get
            Return Hora
        End Get
        Set(value As Date)
            Hora = value
        End Set
    End Property

    Public Property EspecialidadM1 As String
        Get
            Return EspecialidadM
        End Get
        Set(value As String)
            EspecialidadM = value
        End Set
    End Property

    Public Property NombreM1 As String
        Get
            Return NombreM
        End Get
        Set(value As String)
            NombreM = value
        End Set
    End Property

    Public Property NombreP1 As String
        Get
            Return NombreP
        End Get
        Set(value As String)
            NombreP = value
        End Set
    End Property


End Class
