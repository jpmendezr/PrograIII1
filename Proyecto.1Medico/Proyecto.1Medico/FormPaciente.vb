Public Class FormPaciente

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
        Dim registro As New Paciente()
        registro.pro_Cedula1 = Me.TexCedula.Text
        registro.pro_NombreP1 = Me.TextNombre.Text
        registro.pro_Apellidos1 = Me.TexApellidos.Text
        registro.pro_Sexo1 = Me.Sexo.Text
        registro.pro_Fecha1 = Me.TexFecha.Text
        registro.pro_TelefonoPaciente1 = Me.TextCel.Text
        registro.pro_Correo1 = Me.TexCorreoElectronico.Text
        'AgregarRegistrosPersona()


    End Sub

    Public Sub AgregarRegistrosPersona()
        Dim registro As New Paciente()
        Dim agregar As String = "insert into TbPersona values ('" + Me.TexCedula.Text + "','" + Me.TextNombre.Text + "','" + Me.TexApellidos.Text + "','" + Me.Sexo.Text + "','" + Me.TexFecha.Text + "','" + Me.TextCel.Text + "','" + Me.TexCorreoElectronico.Text + "')"
        If (registro.RegistrarSQL(agregar)) Then
            MsgBox("datos agregados")
        Else
            MsgBox("error al agregar")

        End If
    End Sub
End Class