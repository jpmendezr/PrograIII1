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
        formCita = New FRMagendar()
        formCita.Show()
    End Sub

    Private Sub BtnConsEnferm_Click(sender As Object, e As EventArgs) Handles BtnConsEnferm.Click
        FormEnfermera = New FRM_Enfermeria
        FormEnfermera.Show()
    End Sub

    Private Sub btnConsMedico_Click(sender As Object, e As EventArgs) Handles btnConsMedico.Click
        FormConsultorio = New FormConsultorio
        FormConsultorio.Show()


    End Sub

    Private Sub btnReporte_Click(sender As Object, e As EventArgs) Handles btnReporte.Click
        FormReporte = New ReporteriaForm
        FormReporte.Show()


    End Sub

    Private Sub btnAbrir_Click(sender As Object, e As EventArgs) Handles btnAbrir.Click
        formUsuario = New FormUsuarios
        FormUsuarios.Show()

    End Sub

End Class