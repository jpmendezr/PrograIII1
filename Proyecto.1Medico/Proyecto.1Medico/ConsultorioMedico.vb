Public Class ConsultorioMedico
    Private ISintomasMostrados As String
    Private IDescripcionProceso As String
    Private IDiagnostico As String
    Private IMediacamentosAdministrados As String
    Private IMedicamentosRecetados As String

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

    Public Sub IAgregarRegistro(ISintomasMostrados1, IDescripcionProceso1, IDiagnostico1, IMediacamentosAdministrados1, IMedicamentosRecetados1)

    End Sub

End Class
