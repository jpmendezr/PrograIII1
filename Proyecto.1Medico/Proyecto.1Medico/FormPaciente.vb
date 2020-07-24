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
        'registro.pro_Cedula1 = Me.TexCedula.Text
        ' registro.pro_Peso1 = Me.TexPeso.Text
        'registro.pro_Altura1 = Me.TextAltura.Text
        ' registro.pro_TipoSangre1 = Me.TextTipoSangre.Text
        ' registro.pro_ContactoTel = Me.TXTContacto.Text
        'registro.pro_MedicamentosAlergicos1 = Me.TextMedicamentosAlergicos.Text
        AgregarRegistrosPersona()


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