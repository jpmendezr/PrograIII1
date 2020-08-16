Public Class FRM_Enfermeria

    Dim registro As New Consultorio()

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles BTNactualizar.Click

        registro.Cedula1 = Me.txtcedula.Text
        registro.Peso1 = Me.Txtpeso.Text
        registro.Altura1 = Me.Txtaltura.Text
        registro.Mostrar_sintomas1 = Me.TxtSintomas.Text
        registro.Actualizar_datos()

    End Sub

    Private Sub Btnregresar_Click(sender As Object, e As EventArgs) Handles Btnregresar.Click
        FormMenu.Show()
        Me.Hide()
    End Sub
End Class