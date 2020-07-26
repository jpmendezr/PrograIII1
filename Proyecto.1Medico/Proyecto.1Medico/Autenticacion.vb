Imports System.Data
Imports System.Data.SqlClient
Public Class Autenticacion
    Dim cmb As SqlCommandBuilder
    Dim ds As DataSet = New DataSet()
    Dim da As SqlDataAdapter
    Dim comand As SqlCommand
    ' Dim myconnection As New SqlConnection("Server=DESKTOP-EBUQM5L\SQLEXPRESS;Initial Catalog=BdCentroMedico;INTEGRATED SECURITY= SSPI")
    '--------------------------------------

    Private Cedula As String = ""
    Private Contrasena As String = ""
    Private Departamento As String = ""


    'conecta con la base de datos
    'Public Sub conectar()
    '    Try
    '        myconnection.Open()
    '        MsgBox(" conexion valida")

    '    Catch ex As Exception
    '        MsgBox(" conexion mala ")

    '    End Try
    'End Sub
    'Verifica si en la base de datos existe el usuario
    'Public Sub verificarUsuario()
    '    Dim tabla As String = "TbPersonalInterno"
    '    Dim cedula As String = "select cedula, contrasena,departamento from " + tabla + " where Cedula=" + Cedula1 + " and Contrasena=" + "'" + Contrasena1 + "'"
    '    da = New SqlDataAdapter(cedula, myconnection)
    '    cmb = New SqlCommandBuilder(da)
    '    da.Fill(ds, tabla)
    '    If ds.Tables(0).Rows.Count > 0 Then
    '        'MsgBox(ds.Tables(0).Rows(0).Item(0).ToString + ds.Tables(0).Rows(0).Item(1).ToString + ds.Tables(0).Rows(0).Item(2).ToString)
    '        Departamento1 = ds.Tables(0).Rows(0).Item(2).ToString
    '        MsgBox("Ingreso exitoso")
    '    Else
    '        MsgBox("No existe el usuario o contraseña")
    '    End If
    'End Sub
    Public Sub VerificarUSua()
        Try
            Using selexion As New BdCentroMedicoEntities
                Dim dato = (From se In selexion.TbPersonalInterno Where se.Cedula = Cedula1 And se.Contrasena = Contrasena1 Select se.Departamento).SingleOrDefault
                Dim mostrar = (From se In selexion.TbPersonalInterno Where se.Cedula = Cedula1 And se.Contrasena = Contrasena1 Select se).ToList
                If (mostrar.Count > 0) Then
                    Departamento1 = dato
                    MsgBox("Ingreso exitoso")
                Else
                    MsgBox("No existe el usuario o contraseña")
                End If
            End Using
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

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

    Public Function agregar() As Boolean

    End Function

    Public Function actualizar() As Boolean

    End Function

    Public Function eliminarUsuario() As Boolean


    End Function

End Class
