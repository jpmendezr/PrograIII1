Public Class Paciente
    Dim enfermedad As New Enfermedades()
    Private cedula As String
    Private NombreP As String
    Private Apellidos As String
    Private Peso As Double
    Private Edad As Integer
    Private Altura As Double
    Private TipoSangre As String
    Private MedicamentosAlergicos As String
    Private NombreFamiliar As String
    Private TipoFamiliar As String
    Private Telefono As Integer
    Private Direccion As String
    Private Medicamentos As String

    Public Property pro_Cedula1 As String
        Get
            Return cedula
        End Get
        Set(value As String)
            cedula = value
        End Set
    End Property

    Public Property pro_NombreP1 As String
        Get
            Return NombreP
        End Get
        Set(value As String)
            NombreP = value
        End Set
    End Property

    Public Property pro_Apellidos1 As String
        Get
            Return Apellidos
        End Get
        Set(value As String)
            Apellidos = value
        End Set
    End Property

    Public Property pro_Peso1 As Double
        Get
            Return Peso
        End Get
        Set(value As Double)
            Peso = value
        End Set
    End Property

    Public Property pro_Edad1 As Integer
        Get
            Return Edad
        End Get
        Set(value As Integer)
            Edad = value
        End Set
    End Property

    Public Property pro_Altura1 As Double
        Get
            Return Altura
        End Get
        Set(value As Double)
            Altura = value
        End Set
    End Property


    Public Property pro_TipoSangre1 As String
        Get
            Return TipoSangre
        End Get
        Set(value As String)
            TipoSangre = value
        End Set
    End Property

    Public Property pro_MedicamentosAlergicos1 As String
        Get
            Return MedicamentosAlergicos
        End Get
        Set(value As String)
            MedicamentosAlergicos = value
        End Set
    End Property

    Public Property pro_NombreFamiliar1 As String
        Get
            Return NombreFamiliar
        End Get
        Set(value As String)
            NombreFamiliar = value
        End Set
    End Property

    Public Property pro_TipoFamiliar1 As String
        Get
            Return TipoFamiliar
        End Get
        Set(value As String)
            TipoFamiliar = value
        End Set
    End Property

    Public Property pro_Telefono1 As Integer
        Get
            Return Telefono
        End Get
        Set(value As Integer)
            Telefono = value
        End Set
    End Property

    Public Property pro_Direccion1 As String
        Get
            Return Direccion
        End Get
        Set(value As String)
            Direccion = value
        End Set
    End Property

    Public Property pro_Medicamentos1 As String
        Get
            Return Medicamentos
        End Get
        Set(value As String)
            Medicamentos = value
        End Set
    End Property

    Public Function Registrar() As Boolean


    End Function

    Public Function FichaEmergencia() As String


    End Function

    Public Function Actualizar() As Boolean

    End Function
    Public Function Eliminar() As Boolean

    End Function

    Public Function Buscar() As Boolean

    End Function



End Class
