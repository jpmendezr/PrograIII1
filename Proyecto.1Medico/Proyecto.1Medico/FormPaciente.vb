Public Class FormPaciente
    Dim registro As New Paciente()
    ' Dim registroPaciente As New Paciente()
    '  Dim registroFamilia As New Paciente()


    Private Sub MostrarDatosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MostrarDatosToolStripMenuItem.Click
        Dim buscar As New PacienteBuscarFiltros()
        buscar.Show()

    End Sub


    Private Sub BtnActualizo_Click(sender As Object, e As EventArgs) Handles BtnActualizo.Click
        Dim act As String = "Nombre '" + Me.TextNombre.Text + "' Apellido '" + Me.TexApellidos.Text + "' Sexo '" + Me.Sexo.Text + "' FechaNacimiento '" + Me.TexFecha.Text + "' Telefono '" + Me.TextCel.Text + "' Correo '" + Me.TexCorreoElectronico.Text + "'"
        'If registro.Actualizar("TbPersona", act, "Cedula =" + Me.TexCedula.Text) Then
        'MsgBox("se actualizaron los datos ")
        'Else
        'MsgBox("no se actualizaron")
        'End If


    End Sub

    Private Sub FormPaciente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conectar As New Paciente()
        conectar.conectar()

    End Sub

    Private Sub BtnRegistro_Click(sender As Object, e As EventArgs) Handles BtnRegistro.Click
        registro.pro_Cedula1 = Me.TexCedula.Text
        registro.pro_NombreP1 = Me.TextNombre.Text
        registro.pro_Apellidos1 = Me.TexApellidos.Text
        registro.pro_Sexo1 = Me.Sexo.Text
        registro.pro_Fecha1 = Me.TexFecha.Text
        registro.pro_TelefonoPaciente1 = Me.TextCel.Text
        registro.pro_Correo1 = Me.TexCorreoElectronico.Text

        registro.pro_Sangre = TXTsangre.Text
        registro.pro_MedicamentosAlergicos1 = Me.TXTMedicamento.Text


        registro.pro_NombreFamiliar1 = Me.txtFamiliar.Text
        registro.pro_Direccion1 = Me.txtDireccion.Text
        registro.pro_TipoFamiliar1 = Me.txtrelacion.Text
        registro.pro_Telefono1 = Me.txtTelefonoFamiliar.Text

        registro.RegistrarPersona()
        registro.RegistrarPaciente()
        registro.RegistrarFamiliar()



    End Sub

    Public Function AgregarRegistroPaciente() As Boolean


    End Function

    Public Function AgregarRegistroFamiliar() As Boolean

    End Function

    Private Sub Label18_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BtnElimino_Click(sender As Object, e As EventArgs) Handles BtnElimino.Click
        registro.pro_Cedula1 = Me.TexCedula.Text
        registro.Eliminar()

    End Sub
End Class