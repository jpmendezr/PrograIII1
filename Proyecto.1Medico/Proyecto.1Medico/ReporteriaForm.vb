Imports Microsoft.Reporting.WinForms
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



    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnReporteExamen.Click
        Dim fechaInicio As String = Me.ComboBoxDia1.Text + "/" + Me.ComboBoxMes1.Text + "/" + Me.ComboBoxAño1.Text
        Dim fechaFin As String = Me.ComboBoxDia2.Text + "/" + Me.ComboBoxMes2.Text + "/" + Me.ComboBoxAño2.Text
        Try
            Using alm As New BdCentroMedicoEntities
                Dim parametro_1 As New ReportParameter("Cedula", TxtCedula.Text)
                Dim parametro_2 As New ReportParameter("FechaI", fechaInicio)
                Dim parametro_3 As New ReportParameter("FechaF", fechaFin)

                Dim a = alm.Sp_Reporte_Examenes(TxtCedula.Text, fechaInicio, fechaFin).ToList

                If (a.Count > 0) Then
                    Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Proyecto._1Medico.Report1.rdlc"

                    Me.ReportViewer1.LocalReport.SetParameters(parametro_1)
                    Me.ReportViewer1.LocalReport.SetParameters(parametro_2)
                    Me.ReportViewer1.LocalReport.SetParameters(parametro_3)


                    Dim rds As ReportDataSource = New ReportDataSource("DataSet4", a)

                    Me.ReportViewer1.LocalReport.DataSources.Clear()
                    Me.ReportViewer1.LocalReport.EnableExternalImages = True
                    Me.ReportViewer1.LocalReport.DataSources.Add(rds)
                    Me.ReportViewer1.RefreshReport()
                Else
                    MsgBox("No hay articulos cargados")
                End If
            End Using
        Catch ex As Exception
            MsgBox("Error en la carga: " + ex.InnerException.ToString)
        End Try
    End Sub

    Private Sub BtnBuscar2_Click(sender As Object, e As EventArgs) Handles BtnReporteCita.Click
        Dim fechaInicio As String = Me.ComboBoxDia1.Text + "/" + Me.ComboBoxMes1.Text + "/" + Me.ComboBoxAño1.Text
        Dim fechaFin As String = Me.ComboBoxDia2.Text + "/" + Me.ComboBoxMes2.Text + "/" + Me.ComboBoxAño2.Text
        Try
            Using alm As New BdCentroMedicoEntities
                Dim parametro_1 As New ReportParameter("Cedula", TxtCedula.Text)
                Dim parametro_2 As New ReportParameter("FechaInicio", fechaInicio)
                Dim parametro_3 As New ReportParameter("FechaFinal", fechaFin)

                Dim a = alm.f_Sp_Reporte_Cita(TxtCedula.Text, fechaInicio, fechaFin).ToList

                If (a.Count > 0) Then
                    Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Proyecto._1Medico.Report2.rdlc"

                    Me.ReportViewer1.LocalReport.SetParameters(parametro_1)
                    Me.ReportViewer1.LocalReport.SetParameters(parametro_2)
                    Me.ReportViewer1.LocalReport.SetParameters(parametro_3)


                    Dim rds As ReportDataSource = New ReportDataSource("DataSet1", a)

                    Me.ReportViewer1.LocalReport.DataSources.Clear()
                    Me.ReportViewer1.LocalReport.EnableExternalImages = True
                    Me.ReportViewer1.LocalReport.DataSources.Add(rds)
                    Me.ReportViewer1.RefreshReport()
                Else
                    MsgBox("No hay articulos cargados")
                End If
            End Using
        Catch ex As Exception
            MsgBox("Error en la carga: " + ex.InnerException.ToString)
        End Try
    End Sub

    Private Sub ReporteriaForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.ReportViewer1.RefreshReport()
    End Sub
    Private Sub BtnRegresar_Click(sender As Object, e As EventArgs) Handles BtnRegresar.Click

        Me.Dispose()
    End Sub

End Class