Public Class AgendarCita

    Private Fecha As Date
    Private Hora As Date
    Private EspecialidadM As String
    Private NombreM As String 'nombre medico
    Private NombreP As String 'nombre paciente 

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

    Public Sub ReservarCita(Hora1, NombreM1)

    End Sub

    Public Sub actualizar(Fecha1, Hora1, EspecialidadM1, NombreM1, NombreP1)

    End Sub

    Public Sub eliminar()

    End Sub

End Class
