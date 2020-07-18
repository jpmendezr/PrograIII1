Public Class Reporteria
    Private FechaInicio As Date
    Private FechaFin As Date
    Private cedula As String

    Public Property pro_FechaInicio1 As Date
        Get
            Return FechaInicio
        End Get
        Set(value As Date)
            FechaInicio = value
        End Set
    End Property

    Public Property pro_FechaFin1 As Date
        Get
            Return FechaFin
        End Get
        Set(value As Date)
            FechaFin = value
        End Set
    End Property

    Public Property pro_Cedula1 As String
        Get
            Return cedula
        End Get
        Set(value As String)
            cedula = value
        End Set
    End Property

    Public Function InformacionPersonal() As String

    End Function

    Public Function ExamenesPaciente() As String

    End Function
End Class
