Imports Microsoft.Reporting.WinForms
Public Class Reporte2
    Private Sub Reporte2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        poblar1()


        Me.ReportViewer1.RefreshReport()
    End Sub

    Public Sub poblar1()
        Try
            Using alm As New BdCentroMedicoEntities
                Dim parametro_1 As New ReportParameter("Cedula", "100000")
                Dim parametro_2 As New ReportParameter("FechaI", "1/01/2020")
                Dim parametro_3 As New ReportParameter("FechaF", "1/02/2020")

                Dim a = alm.Sp_Reporte_Examenes("100000", "1/01/2020", "1/01/2020").ToList

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
End Class