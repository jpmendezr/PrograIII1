Imports System.Data
Imports System.Data.SqlClient
Public Class Autenticacion


    Private Cedula As String = ""
    Private Contrasena As String = ""
    Private Departamento As String = ""
    Private nombre As String = ""
    Private apellido As String = ""
    Private Sexo As String = ""
    Private Fecha As String = ""
    Private Telef As String = ""
    Private Corre As String = ""
    Private Contra As String = ""
    Private boo As Boolean = False
    Public Function VerificarUSua() As Boolean
        Try
            Using selexion As New BdCentroMedicoEntities
                Dim dato = (From se In selexion.TbPersonalInterno Where se.Cedula = Cedula1 And se.Contrasena = Contrasena1 Select se.Departamento).SingleOrDefault
                Dim mostrar = (From se In selexion.TbPersonalInterno Where se.Cedula = Cedula1 And se.Contrasena = Contrasena1 Select se).ToList
                If (mostrar.Count > 0) Then
                    Departamento1 = dato
                    Return True
                    MsgBox("Ingreso exitoso")
                Else
                    MsgBox("No existe el usuario o contraseña")
                    Return False
                End If
            End Using
        Catch ex As Exception
            Return False
            MsgBox(ex.Message.ToString)
        End Try
    End Function

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

    Public Property Departamento1 As String
        Get
            Return Departamento
        End Get
        Set(value As String)
            Departamento = value
        End Set
    End Property

    Public Property Nombre1 As String
        Get
            Return nombre
        End Get
        Set(value As String)
            nombre = value
        End Set
    End Property

    Public Property Apellido1 As String
        Get
            Return apellido
        End Get
        Set(value As String)
            apellido = value
        End Set
    End Property

    Public Property Sexo1 As String
        Get
            Return Sexo
        End Get
        Set(value As String)
            Sexo = value
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

    Public Property Telef1 As String
        Get
            Return Telef
        End Get
        Set(value As String)
            Telef = value
        End Set
    End Property

    Public Property Corre1 As String
        Get
            Return Corre
        End Get
        Set(value As String)
            Corre = value
        End Set
    End Property

    Public Property Contra1 As String
        Get
            Return Contra
        End Get
        Set(value As String)
            Contra = value
        End Set
    End Property

    Public Property Boo1 As Boolean
        Get
            Return boo
        End Get
        Set(value As Boolean)
            boo = value
        End Set
    End Property

    Public Function agregarPersonal() As Boolean
        Dim resultado As Integer = 0
        Try
            Using registro As New BdCentroMedicoEntities
                Dim NuevoRegistro As New TbPersona With {.Cedula = Cedula1, .Nombre = Nombre1, .Apellido = Apellido1, .Sexo = Sexo1, .FechaNacimiento = Fecha1, .Telefono = Telef1, .Correo = Corre1}
                registro.TbPersona.Add(NuevoRegistro)
                resultado = registro.SaveChanges
                If resultado > 0 Then
                    MsgBox(" se registraron los datos ")
                    Return True
                Else

                    MsgBox(" no se registraron ")
                    Return False
                End If
            End Using
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
            Return False
        End Try
    End Function
    Public Sub InsertarEspecialidad()
        Dim resultado As Integer = 0
        Try
            Using regi As New BdCentroMedicoEntities
                Dim tbnuev As New TbPersonalInterno With {.Cedula = Cedula1, .Departamento = Departamento1, .Contrasena = Contra1}
                regi.TbPersonalInterno.Add(tbnuev)
                resultado = regi.SaveChanges
                If resultado > 0 Then
                    MsgBox(" se registraron los datos en la tabla especialidad ")
                Else
                    MsgBox(" no se registraron en la tabla especialidad  ")

                End If
            End Using
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Public Function actualizar() As Boolean
        Try
            Using bd As New BdCentroMedicoEntities
                Dim sen = (From ac In bd.TbPersona Where ac.Cedula = Cedula Select ac).SingleOrDefault
                Dim senr = (From ac In bd.TbPersonalInterno Where ac.Cedula = Cedula Select ac).SingleOrDefault
                MsgBox(Apellido1)
                If Not IsNothing(sen) Then
                    sen.cedula = Cedula1
                    sen.Nombre = Nombre1
                    sen.Apellido = Apellido1
                    sen.Sexo = Sexo1
                    sen.fechanacimiento = Fecha1
                    sen.Telefono = Telef1
                    sen.Correo = Corre1
                    senr.Departamento = Departamento1
                    senr.Contrasena = Contra1
                    bd.SaveChanges()
                    MsgBox("Actualización exitosa")
                Else
                    MsgBox("Error al actualizar")
                End If

            End Using

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Function

    Public Sub eliminarUsuario()
        Try
            ElminarEspecialidad()
            If Boo1 Then
                Using eleminar As New BdCentroMedicoEntities
                    Dim delete = (From e In eleminar.TbPersona Where e.Cedula = Cedula1 Select e).SingleOrDefault
                    If Not IsNothing(delete) Then
                        eleminar.TbPersona.Remove(delete)
                        eleminar.SaveChanges()
                        MsgBox("Se eliminaron los datos en persona")

                    Else
                        MsgBox("Error al eliminar persona")

                    End If

                End Using
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)

        End Try
    End Sub


    Public Sub ElminarEspecialidad()
        Try
            Using eleminar As New BdCentroMedicoEntities
                Dim delete = (From e In eleminar.TbPersonalInterno Where e.Cedula = Cedula1 Select e).SingleOrDefault
                If Not IsNothing(delete) Then
                    eleminar.TbPersonalInterno.Remove(delete)
                    eleminar.SaveChanges()
                    MsgBox("Se eliminaron los datos")
                    Boo1 = True
                Else
                    MsgBox("Error al eliminar Especialidad")

                End If

            End Using
        Catch ex As Exception
            MsgBox(ex.Message.ToString)

        End Try
    End Sub
End Class
