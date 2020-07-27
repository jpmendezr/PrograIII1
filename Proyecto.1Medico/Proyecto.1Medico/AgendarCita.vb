Public Class AgendarCita

    Private Fecha As String
    Private Hora As String
    Private EspecialidadM As String
    Private NombreM As String 'nombre medico
    Private cedulaP As String 'cedula paciente 

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

    Public Sub eliminarDatos()
        'Eliminar

        Try
            Using eleminar As New BdCentroMedicoEntities
                Dim delete = (From e In eleminar.TbCita Where e.CedulaPaciente = cedulaP Select e).SingleOrDefault
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
        Dim resul As Integer = 0
        Try
            Using actualizar As New BdCentroMedicoEntities
                Dim act = (From ac In actualizar.TbCita Where ac.CedulaPaciente = cedulaP Select ac).SingleOrDefault
                If Not IsNothing(act) Then
                    act.CedulaPaciente = cedulaP
                    act.Fecha = Fecha
                    act.Hora = Hora
                    act.NombreMedico = NombreM
                    act.Especialidad = EspecialidadM
                    actualizar.SaveChanges()
                    MessageBox.Show("Datos actualizados ")
                Else
                    MessageBox.Show("Error al actualizar ")
                End If
            End Using
        Catch ex As Exception
            resul = 0
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub

    Public Sub RegistrarPersona()
        Dim resultado As Integer = 0
        Try
            Using registro As New BdCentroMedicoEntities
                Dim NuevoRegistro As New TbCita With {.CedulaPaciente = cedulaP, .Fecha = Fecha, .Hora = Hora, .Especialidad = EspecialidadM, .NombreMedico = NombreM}
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
        End Try

    End Sub


    Public Sub ReservarCita(Hora1, NombreM1)

    End Sub

End Class
