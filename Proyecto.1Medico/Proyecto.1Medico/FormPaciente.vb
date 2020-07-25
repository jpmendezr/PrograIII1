Public Class FormPaciente
    Dim registro As New Paciente()


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
        registro.pro_Sexo1 = Me.ComboBoxSexo.Text
        registro.pro_Fecha1 = Me.TexFecha.Text
        registro.pro_TelefonoPaciente1 = Me.TextCel.Text
        registro.pro_Correo1 = Me.TexCorreoElectronico.Text

        registro.pro_Sangre = TXTsangre.Text
        registro.MedicamentosAlergicos1 = Me.TXTMedicamento.Text


        registro.pro_NombreFamiliar1 = Me.txtFamiliar.Text
        registro.pro_Direccion1 = Me.txtDireccion.Text
        registro.pro_TipoFamiliar1 = Me.txtrelacion.Text
        registro.pro_Telefono1 = Me.txtTelefonoFamiliar.Text

        registro.RegistrarPersona()
        registro.RegistrarPaciente()
        registro.RegistrarFamiliar()



    End Sub


    Private Sub BtnElimino_Click(sender As Object, e As EventArgs) Handles BtnElimino.Click
        registro.pro_Cedula1 = Me.TexCedula.Text
        registro.EliminarPersona()
        registro.EliminarPaciente()
        registro.EliminarFamiliar()


    End Sub

    Private Sub BtnMostrar_Click(sender As Object, e As EventArgs) Handles BtnMostrar.Click
        Try
            Using selexion As New BdCentroMedicoEntities
                Dim mostrar = (From se In selexion.TbPersona Take (1000) Select se).ToList

                If (mostrar.Count > 0) Then
                    Me.DataGridView1.DataSource = mostrar
                End If

            End Using
        Catch ex As Exception

        End Try
    End Sub
End Class