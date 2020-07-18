Public Class ConsultorioEnfermera

    '' ATRIBUTOS ''
    Private presion As Double
    Private peso As Double
    Private altura As Double
    Private mostrar_sintomas As String

    '' METODOS DE ACCESO ''
    Public Property Presion1 As Double
        Get
            Return presion
        End Get
        Set(value As Double)
            presion = value
        End Set
    End Property

    Public Property Peso1 As Double
        Get
            Return peso
        End Get
        Set(value As Double)
            peso = value
        End Set
    End Property

    Public Property Altura1 As Double
        Get
            Return altura
        End Get
        Set(value As Double)
            altura = value
        End Set
    End Property

    Public Property Mostrar_sintomas1 As String
        Get
            Return mostrar_sintomas
        End Get
        Set(value As String)
            mostrar_sintomas = value
        End Set
    End Property


    '' METODOS ''
    Public Function agregar_sintomas() As Boolean

    End Function

    Public Function descripcion() As Boolean

    End Function

    Public Function actualizar_sintomas() As Boolean

    End Function

End Class
