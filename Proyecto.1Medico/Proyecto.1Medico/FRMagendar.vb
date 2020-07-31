Public Class FRMagendar

    Dim agenda As New AgendarCita
    Dim frmMenu As FormMenu
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        'Btn eliminar
        'Encargado de eliminar

        If Information.IsNumeric(Me.TextCedula.Text) Then
            agenda.CedulaP1 = Me.TextCedula.Text
        End If
        agenda.eliminarDatos()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles BtnCitas.Click
        'Btn citas disponibles
        Try
            Using selexion As New BdCentroMedicoEntities
                Dim mostrar = (From se In selexion.TbCita Take (1000) Select se).ToList

                If (mostrar.Count > 0) Then
                    Me.DataGridView1.DataSource = mostrar

                End If

            End Using
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        'Btn de agregar a la base de datos.
        ' Validaciones de la agregacion en la base de datos.
        If Information.IsNumeric(Me.TextEspecialidad.Text) And Information.IsNumeric(Me.TextNMedico.Text) Then
            MsgBox(" no puede ingresar numeros")
        Else
            agenda.EspecialidadM1 = Me.TextEspecialidad.Text
            agenda.NombreM1 = Me.TextNMedico.Text

        End If

        agenda.Fecha1 = Me.ComboBoxDia.Text + "/" + Me.ComboBoxMes.Text + "/" + Me.ComboBoxAño.Text


        If Information.IsDate(Me.TextHora.Text) And Information.IsNumeric(Me.TextCedula.Text) Then
            agenda.CedulaP1 = Me.TextCedula.Text
            agenda.Hora1 = Me.TextHora.Text
        Else
            MsgBox("No puede meter letras ")
        End If
        ReservarCita()
        agenda.RegistrarPersona()

    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        'Btn de actualizar las citas por numero de cedula.
        agenda.CedulaP1 = Me.TextCedula.Text
        agenda.ActualizarCita()
    End Sub

    Private Sub BtnRegresar_Click(sender As Object, e As EventArgs) Handles BtnRegresar.Click
        'Btn de regresar a la ventana principal.
        Me.Hide()
        frmMenu = New FormMenu()
        frmMenu.Show()

    End Sub

    Private Sub ComboBoxMes_TextChanged(sender As Object, e As EventArgs) Handles ComboBoxMes.TextChanged
        Me.ComboBoxMes.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub ComboBoxAño_TextChanged(sender As Object, e As EventArgs) Handles ComboBoxAño.TextChanged
        Me.ComboBoxAño.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub ComboBoxDia_TextChanged(sender As Object, e As EventArgs) Handles ComboBoxDia.TextChanged
        Me.ComboBoxDia.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Public Sub ReservarCita()

        'Select de verificar valores.

        Dim resultado As Integer = 0
        Try
            Using consulta As New BdCentroMedicoEntities
                Dim QuerrySelect = (From dato In consulta.TbCita Where dato.Hora = TextHora.Text And dato.NombreMedico = TextNMedico.Text Take (2000) Select dato).ToList
                If (QuerrySelect.Count > 0) Then
                    'Me.DataGridView1.DataSource = QuerrySelect
                    MsgBox("Si existe este registro.")
                Else
                    MsgBox("No exite este registro.")
                End If
            End Using
        Catch ex As Exception
            MsgBox("No se pueden verificar. ")
        End Try

    End Sub
End Class
