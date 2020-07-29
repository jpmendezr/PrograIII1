Public Class FormPaciente
    Dim registro As New Paciente()


    Private Sub BtnRegistro_Click(sender As Object, e As EventArgs) Handles BtnRegistro.Click

        If Me.TexCedula.Text.Length > 0 And Me.txtDireccion.Text.Length > 0 And Me.TexApellidos.Text.Length > 0 And Me.TexCorreoElectronico.Text.Length > 0 And Me.TextNombre.Text.Length > 0 And Me.TexCorreoElectronico.Text.Length > 0 And Me.ComboBoxAño.Text.Length > 0 And Me.ComboBoxDia.Text.Length > 0 Then
            If Information.IsNumeric(Me.TexCedula.Text) And Information.IsNumeric(Me.txtTelefonoFamiliar.Text) And Information.IsNumeric(Me.ComboBoxDia.Text) And Information.IsNumeric(Me.ComboBoxMes.Text) And Information.IsNumeric(Me.ComboBoxAño.Text) Then
                registro.pro_Cedula1 = Me.TexCedula.Text
                registro.pro_TelefonoPaciente1 = Me.TextCel.Text
                registro.pro_Fecha1 = Me.ComboBoxDia.Text + "/" + Me.ComboBoxMes.Text + "/" + Me.ComboBoxAño.Text

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

            registro.pro_Correo1 = Me.TexCorreoElectronico.Text
            registro.pro_Direccion1 = Me.txtDireccion.Text
            registro.pro_Sexo1 = Me.ComboBoxSexo.Text

            registro.RegistrarPersona()
            registro.RegistrarPaciente()
            registro.RegistrarFamiliar()
        Else
            MessageBox.Show("Debe de ingresar los datos primero")
        End If



    End Sub


    Private Sub BtnElimino_Click(sender As Object, e As EventArgs) Handles BtnElimino.Click
        Me.txtrelacion.Enabled = False
        Me.txtFamiliar.Enabled = False
        Me.TexApellidos.Enabled = False
        Me.ComboBoxAño.Enabled = False
        Me.ComboBoxDia.Enabled = False
        Me.ComboBoxMes.Enabled = False

        Me.txtTelefonoFamiliar.Enabled = False
        Me.txtDireccion.Enabled = False

        Me.TexCorreoElectronico.Enabled = False
        Me.TexApellidos.Enabled = False
        Me.TextCel.Enabled = False
        Me.TextNombre.Enabled = False
        Me.ComboBoxSexo.Enabled = False

        If Me.TexCedula.Text.Length > 0 Then
            If Information.IsNumeric(Me.TexCedula.Text) Then
                registro.pro_Cedula1 = Me.TexCedula.Text
            End If

            registro.EliminarPersona()
            registro.EliminarPaciente()
            registro.EliminarFamiliar()
        Else
            MessageBox.Show("Debe de ingresar valores")

        End If



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
        Me.txtrelacion.Enabled = False
        Me.txtFamiliar.Enabled = False
        Me.TexApellidos.Enabled = False
        Me.ComboBoxAño.Enabled = False
        Me.ComboBoxDia.Enabled = False
        Me.ComboBoxMes.Enabled = False

        If Me.TexCedula.Text.Length > 0 Then
            If Information.IsNumeric(Me.TexCedula.Text) And Information.IsNumeric(Me.TextCel.Text) And Information.IsNumeric(Me.txtTelefonoFamiliar.Text) Then
                registro.pro_Cedula1 = Me.TexCedula.Text
                registro.pro_TelefonoPaciente1 = Me.TextCel.Text
                registro.pro_Telefono1 = Me.txtTelefonoFamiliar.Text
            Else
                MessageBox.Show("No puede ingresar letras ")
            End If

            If Information.IsNumeric(Me.TextNombre.Text) Then
                MessageBox.Show("No puede ingresar numeros")
            Else
                registro.pro_NombreP1 = Me.TextNombre.Text

            End If

            registro.pro_Correo1 = Me.TexCorreoElectronico.Text
            registro.pro_Sexo1 = Me.ComboBoxSexo.Text
            registro.pro_Direccion1 = Me.txtDireccion.Text


            registro.ActualizarPersona()
            registro.ActualizarFamilia()
        Else
            MessageBox.Show("Debe de ingresar datos")

        End If



    End Sub

    Private Sub ComboBoxAño_TextChanged(sender As Object, e As EventArgs) Handles ComboBoxAño.TextChanged
        Me.ComboBoxAño.DropDownStyle = ComboBoxStyle.DropDownList

    End Sub

    Private Sub ComboBoxMes_TextChanged(sender As Object, e As EventArgs) Handles ComboBoxMes.TextChanged
        Me.ComboBoxMes.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub ComboBoxDia_TextChanged(sender As Object, e As EventArgs) Handles ComboBoxDia.TextChanged
        Me.ComboBoxDia.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub
End Class