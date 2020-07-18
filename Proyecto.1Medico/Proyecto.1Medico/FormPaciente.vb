Public Class FormPaciente
    Private Sub MostrarDatosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MostrarDatosToolStripMenuItem.Click
        Dim buscar As New PacienteBuscarFiltros()
        buscar.Show()

    End Sub
End Class