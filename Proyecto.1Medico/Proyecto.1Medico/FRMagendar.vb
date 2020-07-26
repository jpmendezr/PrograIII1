Public Class FRMagendar

    Dim agenda As New AgendarCita

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        'Btn eliminar
        'Encargado de eliminar

        If Information.IsNumeric(Me.TextCedula.Text) Then
            agenda.CedulaP1 = Me.TextCedula.Text
        End If

        agenda.eliminarDatos()

    End Sub

    Private Sub FRMagendar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles BtnCitas.Click
        'Btn citas disponibles

        Try
            Using selexion As New BdCentroMedicoEntities
                Dim mostrar = (From se In selexion.TbCita Take (2) Select se).ToList

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
            MsgBox("Los valores se agregaron corectamente. ")

        End If

        If Information.IsNumeric(Me.TextBoxDia.Text) And Information.IsNumeric(Me.TextBoxMes.Text) And Information.IsNumeric(Me.TextBoxAño.Text) Then
            agenda.Fecha1 = Me.TextBoxDia.Text + "/" + Me.TextBoxMes.Text + "/" + Me.TextBoxAño.Text
            MsgBox("Los valores se agregaron corectamente. ")
        Else
            MsgBox("No puede meter letras ")

        End If

        If Information.IsNumeric(Me.TextHora.Text) And Information.IsNumeric(Me.TextCedula.Text) Then
            agenda.CedulaP1 = Me.TextCedula.Text
            agenda.Hora1 = Me.TextHora.Text
            MsgBox("Los valores se agregaron corectamente. ")
        Else
            MsgBox("No puede meter letras ")
        End If


    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        'Btn de actualizar las citas.


    End Sub

    Private Sub BtnRegresar_Click(sender As Object, e As EventArgs) Handles BtnRegresar.Click
        'Btn de regresar a la ventana principal.

    End Sub
End Class
