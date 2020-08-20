Public Class FRMagendar

    Dim agenda As New AgendarCita
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        'Btn eliminar
        'Encargado de eliminar
        Try
            If Information.IsNumeric(Me.TextID.Text) Then
                agenda.Id1 = Me.TextID.Text
                agenda.eliminarDatos()

                MostrarCitas()
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
        Dim fechas As String = Me.ComboBoxDia.Text + "/" + Me.ComboBoxMes.Text + "/" + Me.ComboBoxAño.Text
        If Information.IsNumeric(Me.TextEspecialidad.Text) Then
            MsgBox(" no puede ingresar numeros")
        Else
            If Information.IsNumeric(Me.TextCedula.Text) And Information.IsNumeric(Me.TextNMedico.Text) Then

                ConsultaValores()
                agenda.registrarMedico()
            Else
                MsgBox("No puede meter letras ")
            End If
        End If
    End Sub

    Function ConsultaValores() As Boolean
        Dim fechas As String = Me.ComboBoxDia.Text + "/" + Me.ComboBoxMes.Text + "/" + Me.ComboBoxAño.Text
        Try
            Using consulta As New BdCentroMedicoEntities
                Dim QuerrySelect = (From dato In consulta.TbCita Where dato.Fecha = fechas And dato.Hora = Me.ComboHora.Text And dato.CedulaMedico = Me.TextNMedico.Text Take (2000) Select dato).ToList
                If (QuerrySelect.Count > 0) Then
                    MsgBox("Si existe este registro.")
                    Return False
                Else
                    If Me.ComboHora.Text <> agenda.Hora1 Or Me.TextNMedico.Text <> agenda.CedulaM1 Or fechas <> agenda.Fecha1 Then
                        Llenado()
                        MostrarCitas()
                        'refrescarControladores()
                        MsgBox("No exite este registro.")
                        Return True
                    End If
                End If
            End Using
        Catch ex As Exception
            MsgBox("No se pueden verificar. ")
            Return False
        End Try

    End Function
    Public Sub Llenado()
        agenda.EspecialidadM1 = Me.TextEspecialidad.Text
        agenda.CedulaM1 = Me.TextNMedico.Text
        agenda.Fecha1 = Me.ComboBoxDia.Text + "/" + Me.ComboBoxMes.Text + "/" + Me.ComboBoxAño.Text
        agenda.CedulaP1 = Me.TextCedula.Text
        agenda.Hora1 = Me.ComboHora.Text
        agenda.RegistrarPersona()
    End Sub
    Public Sub refrescarControladores()
        Me.TextEspecialidad.Clear()
        Me.TextNMedico.Clear()
        Me.TextCedula.Clear()
        Me.TextID.Clear()
        Me.ComboHora.Text = ""
        Me.ComboBoxDia.Text = ""
        Me.ComboBoxMes.Text = ""
        Me.ComboBoxAño.Text = ""
    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        'Btn de actualizar las citas por numero de cedula.
        Try
            agenda.Id1 = Me.TextID.Text
            agenda.EspecialidadM1 = Me.TextEspecialidad.Text
            agenda.CedulaM1 = Me.TextNMedico.Text
            agenda.Fecha1 = Me.ComboBoxDia.Text + "/" + Me.ComboBoxMes.Text + "/" + Me.ComboBoxAño.Text
            agenda.CedulaP1 = Me.TextCedula.Text
            agenda.Hora1 = Me.ComboHora.Text
            agenda.ActualizarCita()
            MostrarCitas()
        Catch ex As Exception
            MsgBox("ingrese un valor de Id valido.")
        End Try

    End Sub

    Private Sub BtnRegresar_Click(sender As Object, e As EventArgs) Handles BtnRegresar.Click
        'Btn de regresar a la ventana principal.
        Me.Hide()

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


    Private Sub FRMagendar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarCitas()
    End Sub

    Private Sub ComboHora_TextChanged(sender As Object, e As EventArgs) Handles ComboHora.TextChanged
        Me.ComboHora.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub


    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            estado()
        Catch ex As Exception
            MsgBox("Ingrese un ID si decea ver el estado o desea eliminar.")
        End Try


    End Sub

    Public Sub estado()
        Try
            Using selexion As New BdCentroMedicoEntities
                Dim mostrar = (From se In selexion.TbCita Where se.IdCita = Me.TextID.Text Take (1000) Select se).ToList

                If (mostrar.Count > 0) Then
                    Me.DataGridView1.DataSource = mostrar

                End If

            End Using
        Catch ex As Exception
            MsgBox("Ingrese un Valor de Id valido.")
        End Try
    End Sub


End Class
