Public Class Examenes
    Private sangre As String
    Private orina As String

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

    Public Function examen_sangre(Sangre1 As String) As String

    End Function

    Public Function examen_orina(Orina1 As String) As String

    End Function

End Class
