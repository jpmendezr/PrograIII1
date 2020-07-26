Public Class FRM_Enfermeria

    Dim registro As New Consultorio()
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles BTNactualizar.Click

        registro.Peso1 = Me.Txtpeso.Text
        registro.Altura1 = Me.Txtaltura.Text
        registro.Mostrar_sintomas1 = Me.txtSintomas.Text

    End Sub
End Class