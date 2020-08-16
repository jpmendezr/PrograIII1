Public Class FRM_Enfermeria

    Dim registro As New Consultorio()

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles BTNactualizar.Click
        Try
            registro.Id_paci1 = Me.txtId.Text
            registro.Peso1 = Me.Txtpeso.Text
            registro.Altura1 = Me.TXTaltura.Text
            registro.Mostrar_sintomas1 = Me.TxtSintomas.Text
            registro.Actualizar_datos()
            agregar()

        Catch ex As Exception
            MsgBox("Ingrese los valores.")
        End Try

    End Sub

    Private Sub Btnregresar_Click(sender As Object, e As EventArgs) Handles Btnregresar.Click
        FormMenu.Show()
        Me.Hide()
    End Sub

    Private Sub BtnMostrar_Click(sender As Object, e As EventArgs) Handles BtnMostrar.Click
        Try
            Using mostrar_paciente As New BdCentroMedicoEntities
                Dim mostrar = (From mos In mostrar_paciente.TbPaciente Select mos).ToList

                If (mostrar.count > 0) Then
                    Me.DataGridView1.DataSource = mostrar
                Else
                    MsgBox(" No se moatraron los datos ")
                End If

            End Using
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Public Sub agregar()

        Dim lista_sintomas As New List(Of String)
        lista_sintomas.Add(registro.Mostrar_sintomas1)

        Dim itemregistro As String

        For Each itemregistro In lista_sintomas

            Me.ListBox1.Items.Add(itemregistro)

        Next
    End Sub

    'msgbox()

End Class