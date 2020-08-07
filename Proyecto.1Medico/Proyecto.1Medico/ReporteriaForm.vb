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

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Try
            Using bd As New BdCentroMedicoEntities
                Dim mostrar = bd.BuscarPersona(TxtCedula.Text).ToList
                If (mostrar.Count > 0) Then
                    Me.DataGridView1.DataSource = mostrar
                Else
                    MsgBox("No se encuentra el usuario")
                End If
            End Using
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Private Sub BtnMostrar_Click(sender As Object, e As EventArgs) Handles BtnMostrar.Click

    End Sub
End Class