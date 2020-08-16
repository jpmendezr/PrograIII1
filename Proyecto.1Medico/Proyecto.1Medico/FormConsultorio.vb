Public Class FormConsultorio
    Dim registro As New Consultorio()
    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        ' Arreglar esta clase
        'registro.Cedulaactualizar1 = Txtcedula.Text
        Try
            registro.Id1 = txtid.Text
            registro.IDiagnostico1 = TxtDiagnostico.Text
            registro.actualizar_Idiagnostico()
        Catch ex As Exception
            MsgBox("btn actualizar" + ex.InnerException.ToString)
        End Try


    End Sub

    Private Sub Btnexamen_Click(sender As Object, e As EventArgs) Handles Btnexamen.Click
        FRMChequeoExamen.Show()
        Me.Hide()
    End Sub

    Private Sub Btnmostrar_Click(sender As Object, e As EventArgs) Handles Btnmostrar.Click
        mostrar()
    End Sub

    Private Sub BtnMedicamentos_Click(sender As Object, e As EventArgs) Handles BtnMedicamentos.Click
        FrmMedicamentos.Show()
        Me.Hide()
    End Sub

    Private Sub Btnregresar_Click(sender As Object, e As EventArgs) Handles Btnregresar.Click
        FormMenu.Show()
        Me.Hide()
    End Sub

    Private Sub FormConsultorio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
    End Sub

    Public Sub mostrar()
        Try
            Using mostrar_datos As New BdCentroMedicoEntities
                Dim mostrar = mostrar_datos.mostrar_tablas5(Txtcedula.Text).ToList
                If (mostrar.count > 0) Then
                    Me.DataGridView1.DataSource = mostrar

                End If
            End Using
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub


End Class
