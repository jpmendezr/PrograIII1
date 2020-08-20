Public Class Consultorio
    '   Unificacion de las clases medico y enfermera.


    '' ATRIBUTOS Enfermera ''
    Private presion As Double
    Private peso As Double
    Private altura As Double
    Private mostrar_sintomas As String
    Private cedula As String
    Private Id_paci As String
    Private tipoSangre As String
    Private medicamentos As String


    '' ATRIBUTOS medico ''

    Private ISintomasMostrados As String
    Private IDiagnostico As String
    Private IMediacamentosAdministrados As String
    Private IMedicamentosRecetados As String
    Private cedulaactualizar As String
    Private exa_orina As String
    Private exa_sangre As String
    Private id As String

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

    Public Property Id_paci1 As String
        Get
            Return Id_paci
        End Get
        Set(value As String)
            Id_paci = value
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

    Public Property Cedulaactualizar1 As String
        Get
            Return cedulaactualizar
        End Get
        Set(value As String)
            cedulaactualizar = value
        End Set
    End Property

    Public Property Exa_orina1 As String
        Get
            Return exa_orina
        End Get
        Set(value As String)
            exa_orina = value
        End Set
    End Property

    Public Property Exa_sangre1 As String
        Get
            Return exa_sangre
        End Get
        Set(value As String)
            exa_sangre = value
        End Set
    End Property

    Public Property Id1 As String
        Get
            Return id
        End Get
        Set(value As String)
            id = value
        End Set
    End Property

    Public Property TipoSangre1 As String
        Get
            Return tipoSangre
        End Get
        Set(value As String)
            tipoSangre = value
        End Set
    End Property

    Public Property Medicamentos1 As String
        Get
            Return medicamentos
        End Get
        Set(value As String)
            medicamentos = value
        End Set
    End Property






    ''''''''''''''''''''''''''''''' ACTUALIZAR ENFERMERIA '''''''''''''''''''''''''''''''

    Public Sub Actualizar_datos() ' este metodo va a actualizar los datos de tbpaciente 
        Dim resultado As Integer = 0
        Try
            Using actualizar As New BdCentroMedicoEntities

                Dim actu = (From ac In actualizar.TbPaciente Where ac.IdPaciente = Id_paci Select ac).SingleOrDefault

                If Not IsNothing(actu) Then

                    actu.peso = peso
                    actu.Altura = altura
                    actu.TipoSangre = tipoSangre
                    actu.Sintomas = mostrar_sintomas
                    actu.MedicamentoAlergico = medicamentos


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


    Public Sub actualizar_Idiagnostico()
        Dim resultado As Integer = 0
        Try
            Using actualizar As New BdCentroMedicoEntities
                Dim actu = (From ac In actualizar.TbConsultaMedica Where ac.IdConsulta = id Select ac).SingleOrDefault
                If Not IsNothing(actu) Then

                    actu.Diagnostico = IDiagnostico

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
End Class
