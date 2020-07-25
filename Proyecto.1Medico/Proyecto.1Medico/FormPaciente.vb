Public Class FormPaciente
    Dim registro As New Paciente()


    Private Sub BtnActualizo_Click(sender As Object, e As EventArgs) Handles BtnActualizo.Click
        registro.pro_Cedula1 = Me.TexCedula.Text
        registro.pro_NombreP1 = Me.TextNombre.Text
        registro.pro_Sexo1 = Me.ComboBoxSexo.Text
        registro.pro_TelefonoPaciente1 = Me.TextCel.Text
        registro.pro_Correo1 = Me.TexCorreoElectronico.Text
        registro.ActualizarPersona()


    End Sub

    Private Sub FormPaciente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conectar As New Paciente()
        conectar.conectar()

    End Sub

    Private Sub BtnRegistro_Click(sender As Object, e As EventArgs) Handles BtnRegistro.Click
        If Information.IsNumeric(Me.TexCedula.Text) Then
            registro.pro_Cedula1 = Me.TexCedula.Text
        Else
            MsgBox("No puede meter letras ")
        End If

        If Information.IsNumeric(Me.TextNombre.Text) And Information.IsNumeric(Me.TexApellidos.Text) And Information.IsNumeric(TXTsangre.Text) Then
            MsgBox(" no puede ingresar numeros")
        Else
            registro.pro_NombreP1 = Me.TextNombre.Text
            registro.pro_Apellidos1 = Me.TexApellidos.Text
            registro.pro_Sangre = TXTsangre.Text
        End If

        registro.pro_Sexo1 = Me.ComboBoxSexo.Text

        If Information.IsNumeric(Me.TexDia.Text) And Information.IsNumeric(Me.TexMes.Text) And Information.IsNumeric(Me.TexAño.Text) Then
            registro.pro_Fecha1 = Me.TexDia.Text + "/" + Me.TexMes.Text + "/" + Me.TexAño.Text

        Else
            MsgBox("No puede meter letras ")

        End If

        If Information.IsNumeric(Me.TextCel.Text) Then
            registro.pro_TelefonoPaciente1 = Me.TextCel.Text
        Else
            MsgBox(" no puede meter letras")
        End If

        registro.pro_Correo1 = Me.TexCorreoElectronico.Text

        If Information.IsNumeric(Me.TXTMedicamento.Text) Then
            registro.MedicamentosAlergicos1 = Me.TXTMedicamento.Text
        Else
            MsgBox("No puede ingresar letras")
        End If


        If Information.IsNumeric(Me.txtFamiliar.Text) And Information.IsNumeric(Me.txtrelacion.Text) Then
            MsgBox("no puede ingresar numeros")
        Else
            registro.pro_NombreFamiliar1 = Me.txtFamiliar.Text

            registro.pro_TipoFamiliar1 = Me.txtrelacion.Text
        End If

        registro.pro_Direccion1 = Me.txtDireccion.Text
        If Information.IsNumeric(Me.txtTelefonoFamiliar.Text) Then
            registro.pro_Telefono1 = Me.txtTelefonoFamiliar.Text
        Else
            MsgBox("no puede ingresar letras")

        End If


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