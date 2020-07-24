Public Class FormPaciente
    Dim registro As New Paciente()
    Dim registroPaciente As New Paciente()
    Dim registroFamilia As New Paciente()


    Private Sub MostrarDatosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MostrarDatosToolStripMenuItem.Click
        Dim buscar As New PacienteBuscarFiltros()
        buscar.Show()

    End Sub


    Private Sub BtnActualizo_Click(sender As Object, e As EventArgs) Handles BtnActualizo.Click

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


        AgregarRegistrosPersona()
        AgregarRegistroPaciente()
        AgregarRegistroFamiliar()




    End Sub

    Public Sub AgregarRegistrosPersona()
        Dim agregar As String = "insert into TbPersona values ('" + Me.TexCedula.Text + "','" + Me.TextNombre.Text + "','" + Me.TexApellidos.Text + "','" + Me.Sexo.Text + "','" + Me.TexFecha.Text + "','" + Me.TextCel.Text + "','" + Me.TexCorreoElectronico.Text + "')"

        If (registro.RegistrarSQLPersona(agregar)) Then
            MsgBox("datos agregados")
        Else
            MsgBox("error al agregar")

        End If
    End Sub

    Public Function AgregarRegistroPaciente() As Boolean

        Dim agregarP As String = "insert into TbPaciente values ('" + Me.TexCedula.Text + "','" + "0" + "','" + "0" + "','" + TXTsangre.Text + "','" + "0" + "','" + Me.TXTMedicamento.Text + "')"
        If (registroPaciente.RegistrarSQLPaciente(agregarP)) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function AgregarRegistroFamiliar() As Boolean
        Dim agregarf As String = "insert into TbFamiliarPaciente values ('" + Me.TexCedula.Text + "','" + Me.txtrelacion.Text + "','" + Me.txtFamiliar.Text + "','" + Me.txtTelefonoFamiliar.Text + "','" + Me.txtDireccion.Text + "')"
        If (registroFamilia.RegistrarSQLFamiliar(agregarf)) Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub Label18_Click(sender As Object, e As EventArgs)

    End Sub
End Class