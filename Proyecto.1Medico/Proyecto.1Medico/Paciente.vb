Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class Paciente
    Private cedula As String
    Private NombreP As String
    Private Apellidos As String
    Private sexo As String
    Private fecha As DateTime
    Private TelefonoPaciente As Integer
    Private correo As String




    ' informacion adicional'
    Private CedulaAd As Integer
    Private Peso As String
    Private Altura As String
    Private TipoSangre As String
    Private contactoTel As Integer
    Private sintomas As String
    Private MedicamentosAlergicos As String

    'informacion del familiar'
    Private NombreFamiliar As String
    Private TipoFamiliar As String
    Private Telefono As Integer
    Private Direccion As String


    ' variables base de datos 
    Private cmb As SqlCommandBuilder
    Public ds As DataSet = New DataSet()
    Public da As SqlDataAdapter
    Public comand As SqlCommand

    Private myconnection As New SqlConnection("Server=LAPTOP-JQ6UM2LL\SQLEXPRESS;Initial Catalog=BdCentroMedico;INTEGRATED SECURITY= SSPI")
    Public Sub conectar()
        Try
            myconnection.Open()
            MsgBox(" conexion valida")

        Catch ex As Exception
            MsgBox(" conexion mala ")

        End Try
    End Sub

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

    Public Property pro_Peso1 As String
        Get
            Return Peso
        End Get
        Set(value As String)
            Peso = value
        End Set
    End Property

    Public Property pro_Altura1 As String
        Get
            Return Altura
        End Get
        Set(value As String)
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

    Public Property pro_ContactoTel As Integer
        Get
            Return contactoTel
        End Get
        Set(value As Integer)
            contactoTel = value
        End Set
    End Property

    Public Property pro_Sintomas1 As String
        Get
            Return sintomas
        End Get
        Set(value As String)
            sintomas = value
        End Set
    End Property

    Public Property pro_CedulaAd1 As Integer
        Get
            Return CedulaAd
        End Get
        Set(value As Integer)
            CedulaAd = value
        End Set
    End Property

    Public Property pro_Sexo1 As String
        Get
            Return sexo
        End Get
        Set(value As String)
            sexo = value
        End Set
    End Property

    Public Property pro_Fecha1 As Date
        Get
            Return fecha
        End Get
        Set(value As Date)
            fecha = value
        End Set
    End Property

    Public Property pro_TelefonoPaciente1 As Integer
        Get
            Return TelefonoPaciente
        End Get
        Set(value As Integer)
            TelefonoPaciente = value
        End Set
    End Property

    Public Property pro_Correo1 As String
        Get
            Return correo
        End Get
        Set(value As String)
            correo = value
        End Set
    End Property

    Public Sub Consulta(ByVal sql As String, ByVal tabla As String)
        ds.Tables.Clear()
        da = New SqlDataAdapter(sql, myconnection)
        cmb = New SqlCommandBuilder(da)
        da.Fill(ds, tabla)



    End Sub
    Function RegistrarSQL(ByVal sql)
        myconnection.Open()
        comand = New SqlCommand(sql, myconnection)
        Dim i As Integer = comand.ExecuteNonQuery()
        If (i > 0) Then
            Return True
        Else
            Return False
        End If
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
