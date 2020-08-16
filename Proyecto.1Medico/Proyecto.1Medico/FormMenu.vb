Public Class FormMenu
    Dim FormPaciente As FormPaciente
    Dim FormEnfermera As FRM_Enfermeria
    Dim FormConsultorio As FormConsultorio
    Dim FormReporte As ReporteriaForm
    Dim Formchequeo As FRMChequeoExamen
    Dim formCita As FRMagendar
    Dim formUsuario As FormUsuarios
    Private Sub FormMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

    End Sub

    Public Sub VereficarUsuario(depa As String)
        If depa.Equals("Medico") Then
            MsgBox(depa)
            btnRegCita.Enabled = False
            btnRegPaciente.Enabled = False
            BtnConsEnferm.Enabled = False
            btnAbrir.Enabled = False
        ElseIf depa.Equals("Enfermermeria") Then

            MsgBox(depa)
            btnAbrir.Enabled = False
            btnRegPaciente.Enabled = False
            btnConsMedico.Enabled = False
            btnReporte.Enabled = False
            btnRegCita.Enabled = False
        ElseIf depa.Equals("Recepcion") Then
            MsgBox(depa)
            BtnConsEnferm.Enabled = False
            btnConsMedico.Enabled = False
            btnReporte.Enabled = False
            BtnConsEnferm.Enabled = False
        End If
    End Sub

    Private Sub btnRegPaciente_Click(sender As Object, e As EventArgs) Handles btnRegPaciente.Click
        Try
            FormPaciente = New FormPaciente
            FormPaciente.Show()
        Catch ex As Exception
            'MsgBox(ex.Message.ToString)
            MsgBox("btnRegPaciente_Click" + ex.InnerException.ToString)
        End Try

    End Sub

    Private Sub btnRegCita_Click(sender As Object, e As EventArgs) Handles btnRegCita.Click
        Try
            formCita = New FRMagendar()
            formCita.Show()
        Catch ex As Exception
            MsgBox("BtnRegCita_Click" + ex.InnerException.ToString)
        End Try

    End Sub

    Private Sub BtnConsEnferm_Click(sender As Object, e As EventArgs) Handles BtnConsEnferm.Click
        Try
            FormEnfermera = New FRM_Enfermeria
            FormEnfermera.Show()
        Catch ex As Exception
            MsgBox("BtnConsEnferm_Click" + ex.InnerException.ToString)
        End Try

    End Sub

    Private Sub btnConsMedico_Click(sender As Object, e As EventArgs) Handles btnConsMedico.Click
        Try
            FormConsultorio = New FormConsultorio
            FormConsultorio.Show()
        Catch ex As Exception
            MsgBox("btnConsMedico_Click" + ex.InnerException.ToString)
        End Try

    End Sub

    Private Sub btnReporte_Click(sender As Object, e As EventArgs) Handles btnReporte.Click
        Try
            FormReporte = New ReporteriaForm
            FormReporte.Show()
        Catch ex As Exception
            MsgBox("btnReporte_Click" + ex.InnerException.ToString)
        End Try
    End Sub

    Private Sub btnAbrir_Click(sender As Object, e As EventArgs) Handles btnAbrir.Click
        Try
            formUsuario = New FormUsuarios
            FormUsuarios.Show()
        Catch ex As Exception
            MsgBox("btnAbrir_Click" + ex.InnerException.ToString)
        End Try
    End Sub

End Class