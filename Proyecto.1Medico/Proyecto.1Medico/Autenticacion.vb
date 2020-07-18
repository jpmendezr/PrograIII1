Public Class Autenticacion


    Private Cedula As String
    Private Contrasena As String

    Public Property Cedula1 As String
        Get
            Return Cedula
        End Get
        Set(value As String)
            Cedula = value
        End Set
    End Property

    Public Property Contrasena1 As String
        Get
            Return Contrasena
        End Get
        Set(value As String)
            Contrasena = value
        End Set
    End Property

    Public Function agregar() As Boolean

    End Function

    Public Function actualizar() As Boolean

    End Function

    Public Function eliminarUsuario() As Boolean


    End Function
End Class
