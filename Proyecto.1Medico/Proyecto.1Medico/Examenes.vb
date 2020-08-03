Public Class Examenes
    Private sangre As String
    Private orina As String
    Private cedula As String

    Public Property Sangre1 As String
        Get
            Return sangre
        End Get
        Set(value As String)
            sangre = value
        End Set
    End Property

    Public Property Orina1 As String
        Get
            Return orina
        End Get
        Set(value As String)
            orina = value
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

    Public Sub enviar_exa()
        Dim resultado As Integer = 0
        Try
            Using regitro_exa As New BdCentroMedicoEntities

                Dim registro As New TbChequeoExamanes With {.CedulaP = cedula, .Sangre = sangre, .Orina = orina}
                regitro_exa.TbChequeoExamanes.Add(registro)
                resultado = regitro_exa.SaveChanges()

                If resultado > 0 Then
                    MsgBox(" Se registraon los datos ")
                Else
                    MsgBox(" No se registraron los datos ")
                End If
            End Using
        Catch ex As Exception
            resultado = 0
            'MsgBox(ex.Message.ToString)
        End Try
    End Sub

End Class
