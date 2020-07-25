Public Class PacienteBuscarFiltros
    Private Sub BtnMostrar_Click(sender As Object, e As EventArgs)

        Try
            Using selexion As New BdCentroMedicoEntities
                Dim mostrar = (From se In selexion.TbPersona Take (1000) Select se).ToList

                If (mostrar.Count > 0) Then
                    Me.DataGridView1.DataSource = mostrar
                End If

            End Using
        Catch ex As Exception

        End Try

    End Sub

    Private Sub PacienteBuscarFiltros_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class