Public Class FormConsultorio
    Dim registro As New Consultorio()
    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click

        registro.Cedulaactualizar1 = Txtcedula.Text
        registro.ISintomasMostrados1 = ListSintomas.Text
        'registro.IDescripcionProceso1 = TxtDiagnostico.Text
        ' registro.IDiagnostico1 = TxtDescrip.Text
        'registro.IMediacamentosAdministrados1 = txtMedicamentosAdminis.Text se resetan
        'registro.IMedicamentosRecetados1 = TxtMedicamentosRece.Text  se resetan

        registro.Actualizar_ISintoma()
        registro.actualizar_Idiagnostico()
        'registro.actualizar_medicamentos()

    End Sub

    Private Sub Btnexamen_Click(sender As Object, e As EventArgs) Handles Btnexamen.Click
        FRMChequeoExamen.Show()
    End Sub

    Private Sub Btnagregar_Click(sender As Object, e As EventArgs) Handles Btnagregar.Click

    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click

    End Sub
End Class
