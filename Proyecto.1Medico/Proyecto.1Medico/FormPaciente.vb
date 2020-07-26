Public Class FormPaciente
    Dim registro As New Paciente()


    Private Sub BtnActualizo_Click(sender As Object, e As EventArgs)
        registro.pro_Cedula1 = Me.TexCedula.Text
        registro.pro_TelefonoPaciente1 = Me.TextCel.Text
        registro.pro_NombreP1 = Me.TextNombre.Text
        registro.pro_Correo1 = Me.TexCorreoElectronico.Text
        registro.pro_Direccion1 = Me.txtDireccion.Text
        registro.ActualizarPersona()

    End Sub

    Private Sub FormPaciente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnRegistro_Click(sender As Object, e As EventArgs) Handles BtnRegistro.Click

        If Information.IsNumeric(Me.TexCedula.Text) And Information.IsNumeric(Me.txtTelefonoFamiliar.Text) Then
            registro.pro_Cedula1 = Me.TexCedula.Text
            registro.pro_TelefonoPaciente1 = Me.TextCel.Text

        Else
            MsgBox("No puede meter letras ")
        End If


        If Information.IsNumeric(Me.TextNombre.Text) And Information.IsNumeric(Me.TexApellidos.Text) And Information.IsNumeric(Me.txtFamiliar.Text) And Information.IsNumeric(Me.txtrelacion.Text) Then
            MsgBox(" no puede ingresar numeros")
        Else
            registro.pro_NombreP1 = Me.TextNombre.Text
            registro.pro_Apellidos1 = Me.TexApellidos.Text

            registro.pro_NombreFamiliar1 = Me.txtFamiliar.Text

            registro.pro_TipoFamiliar1 = Me.txtrelacion.Text
        End If


        If Information.IsNumeric(Me.TexDia.Text) And Information.IsNumeric(Me.TexMes.Text) And Information.IsNumeric(Me.TexAño.Text) Then
            registro.pro_Fecha1 = Me.TexDia.Text + "/" + Me.TexMes.Text + "/" + Me.TexAño.Text

        Else
            MsgBox("No puede meter letras ")

        End If

        registro.pro_Correo1 = Me.TexCorreoElectronico.Text
        registro.pro_Direccion1 = Me.txtDireccion.Text
        registro.pro_Sexo1 = Me.ComboBoxSexo.Text


        registro.RegistrarPersona()
        registro.RegistrarPaciente()
        registro.RegistrarFamiliar()

    End Sub


    Private Sub BtnElimino_Click(sender As Object, e As EventArgs) Handles BtnElimino.Click
        If Information.IsNumeric(Me.TexCedula.Text) Then
            registro.pro_Cedula1 = Me.TexCedula.Text
        End If
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

    Private Sub ACT_Click(sender As Object, e As EventArgs) Handles ACT.Click
        registro.pro_Cedula1 = Me.TexCedula.Text
        ' registro.pro_TelefonoPaciente1 = Me.TextCel.Text
        ' registro.pro_Correo1 = Me.TexCorreoElectronico.Text
        'registro.pro_Sexo1 = Me.ComboBoxSexo.Text
        registro.pro_NombreP1 = Me.TextNombre.Text
        registro.ActualizarPersona()


    End Sub
End Class