Public Class PacienteBuscarFiltros
    Private Sub BtnMostrar_Click(sender As Object, e As EventArgs)
        Dim consulta As New Paciente()

        consulta.Consulta("select * from TbPaciente", "TbPaciente")
        DataGridView1.DataSource = consulta.ds.Tables("TbPaciente")

    End Sub
End Class