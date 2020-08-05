Public Class FRMagendar

    Dim agenda As New AgendarCita
    Dim frmMenu As FormMenu
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        'Btn eliminar
        'Encargado de eliminar
        Try
            If Information.IsNumeric(Me.TextID.Text) Then
                agenda.Id1 = Me.TextID.Text
                agenda.eliminarDatos()
            End If
        Catch ex As Exception
            MsgBox("Ingrese un ID para eliminar alguna cita.")
        End Try

    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles BtnCitas.Click
        'Btn citas disponibles

        MostrarCitas()
    End Sub

    Public Sub MostrarCitas()
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
            If Information.IsNumeric(Me.TextCedula.Text) Then
                If ConsultaValores() And agenda.ConsultaHora() And agenda.ConsultaFecha Then
                    agenda.EspecialidadM1 = Me.TextEspecialidad.Text
                    agenda.NombreM1 = Me.TextNMedico.Text
                    agenda.Fecha1 = Me.ComboBoxDia.Text + "/" + Me.ComboBoxMes.Text + "/" + Me.ComboBoxAño.Text
                    agenda.CedulaP1 = Me.TextCedula.Text
                    agenda.Hora1 = Me.ComboHora.Text
                    agenda.estado1 = Me.ComboEstado.Text
                    agenda.RegistrarPersona()
                End If
            Else
                MsgBox("No puede meter letras ")
            End If
        End If
    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        'Btn de actualizar las citas por numero de cedula.
        Try
            agenda.Id1 = Me.TextID.Text
            agenda.EspecialidadM1 = Me.TextEspecialidad.Text
            agenda.NombreM1 = Me.TextNMedico.Text
            agenda.Fecha1 = Me.ComboBoxDia.Text + "/" + Me.ComboBoxMes.Text + "/" + Me.ComboBoxAño.Text
            agenda.CedulaP1 = Me.TextCedula.Text
            agenda.Hora1 = Me.ComboHora.Text
            agenda.estado1 = Me.ComboEstado.Text
            agenda.ActualizarCita()
        Catch ex As Exception
            MsgBox("ingrese un valor de Id valido.")
        End Try

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


    Function ConsultaValores() As Boolean

        'Select de verificar valores.
        Dim valorFecha As String = Me.ComboBoxDia.Text + "/" + Me.ComboBoxMes.Text + "/" + Me.ComboBoxAño.Text

        Dim resultado As Integer = 0
        Try
            Using consulta As New BdCentroMedicoEntities
                Dim QuerrySelect = (From dato In consulta.TbCita Where dato.Fecha = valorFecha And dato.Hora = ComboHora.Text And dato.NombreMedico = TextNMedico.Text And dato.CedulaPaciente = TextCedula.Text Take (2000) Select dato).ToList
                If (QuerrySelect.Count > 0) Then
                    MsgBox("Si existe este registro.")
                    Return False
                Else
                    MsgBox("No exite este registro.")
                    Return True
                End If
            End Using
        Catch ex As Exception
            MsgBox("No se pueden verificar. ")
            Return False
        End Try

    End Function

    Private Sub FRMagendar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarCitas()
    End Sub

    Private Sub ComboHora_TextChanged(sender As Object, e As EventArgs) Handles ComboHora.TextChanged
        Me.ComboHora.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub ComboEstado_VisibleChanged(sender As Object, e As EventArgs) Handles ComboEstado.VisibleChanged
        Me.ComboEstado.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub
End Class
