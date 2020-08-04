Public Class FrmMedicamentos
    Dim registro As New Medicamentos_1()
    Dim frmConsultorio As New FormConsultorio()

    Public Sub mostrar_medicamentos()
        Try
            Using mostrar_medicamentos As New BdCentroMedicoEntities
                Dim mostrar = (From mos In mostrar_medicamentos.TbMedicamento Select mos).ToList

                If (mostrar.count > 0) Then
                    Me.DataGridView1.DataSource = mostrar
                    DataGridView1.Columns.Remove("TbChequeoMedicamentos")
                    DataGridView1.Columns.Remove("TbChequeoMedicamentos1")

                Else
                    MsgBox(" No se moatraron los datos ")
                End If

            End Using
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Public Sub mostrar_agregados()
        Try
            Using medicamentos_agregados As New BdCentroMedicoEntities
                Dim mostrar = (From mos In medicamentos_agregados.TbChequeoMedicamentos Select mos).ToList

                If (mostrar.count > 0) Then
                    Me.DataGridView2.DataSource = mostrar

                    DataGridView2.Columns.Remove("TbConsultaMedica")
                    DataGridView2.Columns.Remove("TbMedicamento")
                    DataGridView2.Columns.Remove("TbMedicamento1")
                Else
                    MsgBox(" No se moatraron los datos ")
                End If

            End Using
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        If Me.txtcedula.Text.Length > 0 And Me.txtadmi.Text.Length > 0 And Me.txtrece.Text.Length > 0 Then
            If Information.IsNumeric(Me.txtcedula.Text) And Information.IsNumeric(txtadmi.Text) And Information.IsNumeric(txtrece.Text) Then
                registro.CedulaPaci1 = Me.txtcedula.Text
                registro.Medi_admi1 = Me.txtadmi.Text
                registro.Medi_rece1 = Me.txtrece.Text
            Else
                MsgBox(" No se pueden ingresar letras ")
            End If
        Else

            MsgBox(" Tiene que ingresar datos")
        End If
        registro.recetar_medi()
    End Sub

    Private Sub BtnMostrar_Click(sender As Object, e As EventArgs) Handles BtnMostrar.Click
        mostrar_agregados()
    End Sub

    Private Sub BtnRegresar_Click(sender As Object, e As EventArgs) Handles BtnRegresar.Click
        '' Para regresar al formulario consultorio
        Me.Hide()
        frmConsultorio = New FormConsultorio()
        frmConsultorio.Show()
    End Sub

    Private Sub FrmMedicamentos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar_medicamentos()
    End Sub
End Class