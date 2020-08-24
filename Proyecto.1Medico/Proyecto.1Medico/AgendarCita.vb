Public Class AgendarCita

    Private Fecha As String
    Private Hora As String
    Private EspecialidadM As String
    Private cedulaM As String 'nombre medico
    Private cedulaP As String 'cedula paciente 
    Private Id As Integer 'Id de la persona


    Public Property EspecialidadM1 As String
        Get
            Return EspecialidadM
        End Get
        Set(value As String)
            EspecialidadM = value
        End Set
    End Property


    Public Property CedulaP1 As String
        Get
            Return cedulaP
        End Get
        Set(value As String)
            cedulaP = value
        End Set
    End Property

    Public Property Fecha1 As String
        Get
            Return Fecha
        End Get
        Set(value As String)
            Fecha = value
        End Set
    End Property

    Public Property Hora1 As String
        Get
            Return Hora
        End Get
        Set(value As String)
            Hora = value
        End Set
    End Property

    Public Property Id1 As Integer
        Get
            Return Id
        End Get
        Set(value As Integer)
            Id = value
        End Set
    End Property

    Public Property CedulaM1 As String
        Get
            Return cedulaM
        End Get
        Set(value As String)
            cedulaM = value
        End Set
    End Property

    Public Sub eliminarDatos()
        'Eliminar
        Try
            Using eleminar As New BdCentroMedicoEntities
                Dim delete = (From e In eleminar.TbCita Where e.IdCita = Id Select e).SingleOrDefault
                If Not IsNothing(delete) Then
                    eleminar.TbCita.Remove(delete)
                    eleminar.SaveChanges()
                    MsgBox("Se eliminaron los datos")
                End If
            End Using
        Catch ex As Exception
            MsgBox("Error al eliminar.")
        End Try
    End Sub


    Public Sub ActualizarCita()
        Try
            Using actualizar As New BdCentroMedicoEntities
                Dim act = (From ac In actualizar.TbCita Where ac.IdCita = Id Select ac).SingleOrDefault
                If Not IsNothing(act) Then
                    'act.CedulaPaciente = cedulaP
                    act.Fecha = Fecha
                    act.Hora = Hora
                    act.NombreMedico = cedulaM
                    act.Especialidad = EspecialidadM
                    actualizar.SaveChanges()
                    MessageBox.Show("Datos actualizados ")
                Else
                    MessageBox.Show("Error al actualizar ")
                End If
            End Using
        Catch ex As Exception
            'MsgBox("No se puede realizar la accion.")
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Sub RegistrarPersona()
        Dim resultado As Integer = 0
        Try
            Using registro As New BdCentroMedicoEntities
                Dim NuevoRegistro As New TbCita With {.CedulaPaciente = cedulaP, .Fecha = Fecha, .Hora = Hora, .CedulaMedico = cedulaM, .Especialidad = EspecialidadM}
                registro.TbCita.Add(NuevoRegistro)
                resultado = registro.SaveChanges
                If resultado > 0 Then
                    MsgBox(" se registraron los datos ")
                Else
                    MsgBox(" no se registraron ")
                End If
            End Using
        Catch ex As Exception
            resultado = 0
            MessageBox.Show(ex.ToString)
        End Try

    End Sub

    Function ConsultaFechaHora() As Boolean
        Try
            Using consulta As New BdCentroMedicoEntities
                Dim QuerrySelect = (From dato In consulta.TbCita Where dato.Hora = Hora1 And dato.Fecha = Fecha1 Take (2000) Select dato).ToList
                If (QuerrySelect.Count > 0) Then
                    MsgBox("No se pueden registrar usuarios a la misma Fecha y Hora.")
                    Return False
                Else
                    MsgBox("Fecha Valida.")
                    Return True
                End If
            End Using
        Catch ex As Exception
            MsgBox("No se pueden verificar. ")
            Return False
        End Try
    End Function

    Public Sub registrarMedico()
        Dim resultado As Integer = 0
        Try
            Using consulta As New BdCentroMedicoEntities
                Using registro As New BdCentroMedicoEntities
                    Dim seleccion = (From dato In consulta.TbCita Where dato.CedulaPaciente = CedulaP1 And dato.Fecha = Fecha1 And dato.Hora = Hora1 And dato.CedulaMedico = cedulaM And dato.Especialidad = EspecialidadM1 Take (2000)).SingleOrDefault
                    Dim NRegistro As New TbConsultaMedica With {.IdCita = seleccion.idCita.ToString, .CedulaP = cedulaP, .CedulaM = cedulaM, .Diagnostico = "na", .IdCheqExamenes = 0, .IdCheqMedicamento = 0}
                    registro.TbConsultaMedica.Add(NRegistro)
                    resultado = registro.SaveChanges
                    If (resultado > 0) Then
                        MsgBox(" se registraron los datos ")
                    Else
                        MsgBox(" no se registraron ")
                    End If
                End Using
            End Using
        Catch ex As Exception
            MsgBox("No se pueden verificar el id de tbconsultaMedica. ")
        End Try
    End Sub

End Class
