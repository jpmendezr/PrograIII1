Public Class Consultorio
    '   Unificacion de las clases medico y enfermera.


    '' ATRIBUTOS Enfermera ''
    Private presion As Double
    Private peso As Double
    Private altura As Double
    Private mostrar_sintomas As String
    Private cedula As String

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

    Public Property Cedula1 As String
        Get
            Return cedula
        End Get
        Set(value As String)
            cedula = value
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


    ''''''''''''''''''''''''''''''' ACTUALIZAR ENFERMERIA '''''''''''''''''''''''''''''''

    Public Sub Actualizar_datos() ' este metodo va a actualizar los datos de tbpaciente 
        Dim resultado As Integer = 0
        Try
            Using actualizar As New BdCentroMedicoEntities

                Dim actu = (From ac In actualizar.TbPaciente Where ac.CedulaPersona = cedula Select ac).SingleOrDefault

                If Not IsNothing(actu) Then
                    'actu.Presion = presion
                    actu.peso = peso
                    actu.Altura = altura

                    actualizar.SaveChanges()

                    MessageBox.Show(" Datos actualizados ")
                Else
                    MessageBox.Show(" Error al actualizar ")

                End If
            End Using
        Catch ex As Exception
            resultado = 0
            MessageBox.Show(ex.Message.ToString)
            'MsgBox(ex.Message.ToString)


        End Try
    End Sub

    ''''''''''''''''''''''''''''''  MEDICO  ''''''''''''''''''''''''''''''
    Public Sub Actualizar_Medico()

    End Sub
End Class
