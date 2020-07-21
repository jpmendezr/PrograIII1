Public Class Enfermedades

    Private enfermedad As String
    Private tipoEnfermedades As List(Of String)

    Public Property Enfermedad1 As String
        Get
            Return enfermedad
        End Get
        Set(value As String)
            enfermedad = value
        End Set
    End Property
    Public Property TipoEnfermedades1 As List(Of String)
        Get
            Return tipoEnfermedades
        End Get
        Set(value As List(Of String))
            tipoEnfermedades = value
        End Set
    End Property

    Public Sub agregacion()

        For Each Item In TipoEnfermedades1
            Me.TipoEnfermedades1.Add(Enfermedad1)
        Next

    End Sub

End Class
