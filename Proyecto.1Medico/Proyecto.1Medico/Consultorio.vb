Public Class Consultorio
    '   Unificacion de las clases medico y enfermera.


    '' ATRIBUTOS Enfermera ''
    Private presion As Double
    Private peso As Double
    Private altura As Double
    Private mostrar_sintomas As String

    '' ATRIBUTOS medico ''

    Private ISintomasMostrados As String
    Private IDescripcionProceso As String
    Private IDiagnostico As String
    Private IMediacamentosAdministrados As String
    Private IMedicamentosRecetados As String
    ''

    'Enfermera metodos de acceso.
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

    'Medicos metodos de acceso
    Public Property ISintomasMostrados1 As String
        Get
            Return ISintomasMostrados
        End Get
        Set(value As String)
            ISintomasMostrados = value
        End Set
    End Property

    Public Property IDescripcionProceso1 As String
        Get
            Return IDescripcionProceso
        End Get
        Set(value As String)
            IDescripcionProceso = value
        End Set
    End Property

    Public Property IDiagnostico1 As String
        Get
            Return IDiagnostico
        End Get
        Set(value As String)
            IDiagnostico = value
        End Set
    End Property

    Public Property IMediacamentosAdministrados1 As String
        Get
            Return IMediacamentosAdministrados
        End Get
        Set(value As String)
            IMediacamentosAdministrados = value
        End Set
    End Property

    Public Property IMedicamentosRecetados1 As String
        Get
            Return IMedicamentosRecetados
        End Get
        Set(value As String)
            IMedicamentosRecetados = value
        End Set
    End Property

    'consultorio Enfermera
    Public Function agregar_sintomas() As Boolean

    End Function

    Public Function descripcion() As Boolean

    End Function

    Public Function actualizar_sintomas() As Boolean

    End Function

    'Consultorio Medico

    Public Sub IAgregarRegistro(ISintomasMostrados1, IDescripcionProceso1, IDiagnostico1, IMediacamentosAdministrados1, IMedicamentosRecetados1)

    End Sub
End Class
