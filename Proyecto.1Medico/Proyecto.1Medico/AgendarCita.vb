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
            Using _listaCitas As New BdCentroMedicoEntities
                Dim querryDelete = (From delete In _listaCitas.TbCita Where delete.CedulaPaciente = CedulaP1 Select delete).SingleOrDefault
                If (Not IsNothing(querryDelete)) Then
                    _listaCitas.TbCita.Remove(querryDelete)
                    _listaCitas.SaveChanges()
                End If
            End Using
        Catch ex As Exception
        End Try
        MsgBox("se elimino correctamente.")


    End Sub


    Public Sub ActualizarCita()
        'Dim resultado As Integer = 0
        'Try
        '    Dim ordenDeCompra As String = "987"

        '    Using _Clinica As New BdCentroMedicoEntities
        '        Dim Registro = (From x In _Clinica.TbCita Where x.Orden_compra1 = ordenDeCompra Select x).SingleOrDefault
        '        If (Not IsNothing(Registro)) Then
        '            Registro.Bodega = "bod03"
        '            Registro.Id_proveedor = "1233"
        '            '  _almacen.Orden_Compra.Add(Registro)
        '            _Clinica.SaveChanges()
        '            MsgBox("actualizado")
        '        Else
        '            MsgBox("Fallo")
        '        End If
        '    End Using
        'Catch ex As Exception
        '    resultado = 0
        '    MsgBox(ex.Message)
        'End Try

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
