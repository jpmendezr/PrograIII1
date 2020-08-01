Public Class FormConsultorio
    Dim registro As New Consultorio()
    Dim frmMenu As New FormMenu

    Private Sub llenar_datos(valor As String)
        Using llenar As New BdCentroMedicoEntities
            'Dim cheqMedi = (From c In llenar.TbChequeoExamanes Where c.CedulaP = valor Select c).ToList
            Dim cheqmedi = (From c In llenar.TbChequeoExamanes Where c.CedulaP = valor Select c).ToList

            Dim cheqme = (From c In llenar.TbChequeoMedicamentos Where c.CedulaP = valor Select c).SingleOrDefault
            Dim cheqexa = (From c In llenar.TbChequeoExamanes Where c.CedulaP = valor Select c).SingleOrDefault

            If (cheqMedi.Count > 0) Then
                Txtcedula.Text = cheqme.CedulaP.ToString
                txtMedicamentosAdminis.Text = cheqme.MedicamentoAdm.ToString
                TxtMedicamentosRece.Text = cheqme.MedicamentoRecetado.ToString
                txtsangre.Text = cheqme.Sangre.ToString
                txtorina.Text = cheqme.Orina.ToString
                txtsintomas.Text = cheqme.Sintomas.ToString
            Else
                MsgBox(" Se presento un problema ")
            End If

        End Using
    End Sub
    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click

        registro.Cedulaactualizar1 = Txtcedula.Text
        registro.ISintomasMostrados1 = txtsintomas.Text
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
        Me.Hide()
    End Sub

    Private Sub BtnMedicamentos_Click(sender As Object, e As EventArgs) Handles BtnMedicamentos.Click

        FRMChequeoMedicamentos.Show()
        Me.Hide()
    End Sub

    Private Sub btnmostrar_Click(sender As Object, e As EventArgs) Handles Btnmostrar.Click
        Try
            Using selexion As New BdCentroMedicoEntities
                Dim mostrar = selexion.mostrar_tablas(Txtcedula.Text).ToList

                If (mostrar.count > 0) Then
                    Me.DataGridView1.DataSource = mostrar

                Else
                    MsgBox("No se mostraron los datos ")
                End If
            End Using
        Catch ex As Exception

        End Try



    End Sub

    Private Sub Btnregresar_Click(sender As Object, e As EventArgs) Handles Btnregresar.Click
        '' Regresar a la ventana principal
        Me.Hide()
        frmMenu = New FormMenu()
        frmMenu.Show()
    End Sub

    Private Sub DataGridView1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles DataGridView1.MouseDoubleClick
        Dim llenar As String
        llenar = DataGridView1.CurrentRow.Cells(0).Value.ToString
        MsgBox(llenar)
        llenar_datos(llenar)
    End Sub
End Class
