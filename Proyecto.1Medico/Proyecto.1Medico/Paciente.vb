Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class Paciente
    Private cedula As String
    Private NombreP As String
    Private Apellidos As String
    Private sexo As String
    Private fecha As String
    Private TelefonoPaciente As String
    Private correo As String


    'informacion del familiar'
    Private NombreFamiliar As String
    Private TipoFamiliar As String
    Private Telefono As String
    Private Direccion As String


    ' variables base de datos 
    Private cmb As SqlCommandBuilder
    Public ds As DataSet = New DataSet()
    Public da As SqlDataAdapter
    Public comand As SqlCommand


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

    Public Property pro_Telefono1 As String
        Get
            Return Telefono
        End Get
        Set(value As String)
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


    Public Property pro_Sexo1 As String
        Get
            Return sexo
        End Get
        Set(value As String)
            sexo = value
        End Set
    End Property

    Public Property pro_Fecha1 As String
        Get
            Return fecha
        End Get
        Set(value As String)
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



    Public Sub RegistrarPersona()
        Dim resultado As Integer = 0
        Try
            Using registro As New BdCentroMedicoEntities
                Dim NuevoRegistro As New TbPersona With {.Cedula = cedula, .Nombre = NombreP, .Apellido = Apellidos, .Sexo = sexo, .FechaNacimiento = fecha, .Telefono = TelefonoPaciente, .Correo = correo}

                registro.TbPersona.Add(NuevoRegistro)
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

    Public Function RegistrarPaciente() As Boolean
        Dim resultado As Integer = 0
        Try
            Using registro As New BdCentroMedicoEntities
                Dim NuevoRegistro As New TbPaciente With {.CedulaPersona = cedula, .Peso = "NA", .Altura = "NA", .TipoSangre = "NA", .Sintomas = "NA", .MedicamentoAlergico = "NA"}

                registro.TbPaciente.Add(NuevoRegistro)
                resultado = registro.SaveChanges
                If resultado > 0 Then
                    Return True
                Else
                    Return False

                End If
            End Using
        Catch ex As Exception
            resultado = 0
        End Try

    End Function

    Public Function RegistrarFamiliar() As Boolean
        Dim resultado As Integer
        Try
            Using registro As New BdCentroMedicoEntities
                Dim NuevoRegistro As New TbFamiliarPaciente With {.CedulaPaciente = cedula, .Parentesco = TipoFamiliar, .NombreCompleto = NombreFamiliar, .TelefonoFamiliar = Telefono, .Direccion = Direccion}
                registro.TbFamiliarPaciente.Add(NuevoRegistro)
                resultado = registro.SaveChanges
                If resultado > 0 Then
                    Return True
                Else
                    Return False

                End If
            End Using
        Catch ex As Exception

            MessageBox.Show(ex.ToString)
        End Try

    End Function


    Public Sub ActualizarPersona()
        Dim resul As Integer = 0
        Try
            Using actualizar As New BdCentroMedicoEntities
                Dim act = (From ac In actualizar.TbPersona Where ac.Cedula = cedula Select ac).SingleOrDefault
                If Not IsNothing(act) Then
                    act.Nombre = NombreP
                    act.Sexo = sexo
                    act.Telefono = TelefonoPaciente
                    act.Correo = correo
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

    Public Function ActualizarFamilia() As Boolean
        Dim resul As Integer = 0
        Try
            Using actualizar As New BdCentroMedicoEntities
                Dim act = (From ac In actualizar.TbFamiliarPaciente Where ac.CedulaPaciente = cedula Select ac).SingleOrDefault
                If Not IsNothing(act) Then
                    act.TelefonoFamiliar = Telefono
                    act.Direccion = Direccion
                    actualizar.SaveChanges()
                    Return True
                Else
                    Return False
                End If
            End Using
        Catch ex As Exception
            resul = 0
            MessageBox.Show("Error")

        End Try
    End Function



    Public Sub EliminarPersona()
        Dim resultado As Integer = 0
        Try
            Using eleminar As New BdCentroMedicoEntities
                Dim delete = (From e In eleminar.TbPersona Where e.Cedula = cedula Select e).SingleOrDefault
                If Not IsNothing(delete) Then
                    eleminar.TbPersona.Remove(delete)
                    eleminar.SaveChanges()
                    MsgBox("Se eliminaron los datos")
                End If

            End Using
        Catch ex As Exception
            resultado = 0
        End Try
    End Sub

    Public Sub EliminarFamiliar()
        Dim resultado As Integer = 0
        Try
            Using eleminar As New BdCentroMedicoEntities
                Dim delete = (From e In eleminar.TbFamiliarPaciente Where e.CedulaPaciente = cedula Select e).SingleOrDefault
                If Not IsNothing(delete) Then
                    eleminar.TbFamiliarPaciente.Remove(delete)
                    eleminar.SaveChanges()

                End If

            End Using
        Catch ex As Exception
            resultado = 0
        End Try
    End Sub
    Public Sub EliminarPaciente()
        Dim resultado As Integer = 0
        Try
            Using eleminar As New BdCentroMedicoEntities
                Dim delete = (From e In eleminar.TbPaciente Where e.CedulaPersona = cedula Select e).SingleOrDefault
                If Not IsNothing(delete) Then
                    eleminar.TbPaciente.Remove(delete)
                    eleminar.SaveChanges()

                End If

            End Using
        Catch ex As Exception
            resultado = 0
        End Try
    End Sub



End Class
