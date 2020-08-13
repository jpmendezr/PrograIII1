Public Class ReporteriaForm
    Private Sub ComboBoxDia1_TextChanged(sender As Object, e As EventArgs) Handles ComboBoxDia1.TextChanged
        Me.ComboBoxDia1.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub ComboBoxMes1_TextChanged(sender As Object, e As EventArgs) Handles ComboBoxMes1.TextChanged
        Me.ComboBoxMes1.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub ComboBoxAño1_TextChanged(sender As Object, e As EventArgs) Handles ComboBoxAño1.TextChanged
        Me.ComboBoxAño1.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub ComboBoxDia2_TextChanged(sender As Object, e As EventArgs) Handles ComboBoxDia2.TextChanged
        Me.ComboBoxDia2.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub ComboBoxMes2_TextChanged(sender As Object, e As EventArgs) Handles ComboBoxMes2.TextChanged
        Me.ComboBoxMes2.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub ComboBoxAño2_TextChanged(sender As Object, e As EventArgs) Handles ComboBoxAño2.TextChanged
        Me.ComboBoxAño2.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub BtnMostrar_Click(sender As Object, e As EventArgs) Handles BtnMostrar.Click
        Try
            Using bd As New BdCentroMedicoEntities
                Dim mostrar = bd.Mostrar_ReporteriaPacientePersonal().ToList
                If (mostrar.Count > 0) Then
                    Me.DataGridView1.DataSource = mostrar

                End If
            End Using
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Dim fechaInicio As String = Me.ComboBoxDia1.Text + "/" + Me.ComboBoxMes1.Text + "/" + Me.ComboBoxAño1.Text
        Dim fechaFin As String = Me.ComboBoxDia2.Text + "/" + Me.ComboBoxMes2.Text + "/" + Me.ComboBoxAño2.Text
        Try
            Using bd As New BdCentroMedicoEntities
                Dim mostrar = bd.f_Sp_Reporte_Cita(Me.TxtCedula.Text, fechaInicio, fechaFin).ToList
                If (mostrar.Count > 0) Then
                    Me.DataGridView1.DataSource = mostrar

                End If
            End Using
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub


    Private Sub BtnRegresar_Click(sender As Object, e As EventArgs) Handles BtnRegresar.Click

        Me.Dispose()
    End Sub

    Private Sub BtnBuscar2_Click(sender As Object, e As EventArgs) Handles BtnBuscar2.Click
        Dim fechaInicio As String = Me.ComboBoxDia1.Text + "/" + Me.ComboBoxMes1.Text + "/" + Me.ComboBoxAño1.Text
        Dim fechaFin As String = Me.ComboBoxDia2.Text + "/" + Me.ComboBoxMes2.Text + "/" + Me.ComboBoxAño2.Text
        Try
            Using bd As New BdCentroMedicoEntities
                Dim mostrar = bd.Sp_Reporte_Examenes(Me.TxtCedula.Text, fechaInicio, fechaFin).ToList
                If (mostrar.Count > 0) Then
                    Me.DataGridView1.DataSource = mostrar

                End If
            End Using
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Private Sub BtnMostrar2_Click(sender As Object, e As EventArgs) Handles BtnMostrar2.Click
        Try
            Using bd As New BdCentroMedicoEntities
                Dim mostrar = bd.MostrarExamenes.ToList
                If (mostrar.Count > 0) Then
                    Me.DataGridView1.DataSource = mostrar

                End If
            End Using
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub
End Class