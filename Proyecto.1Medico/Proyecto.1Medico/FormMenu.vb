Public Class FormMenu
    Dim FormPaciente As FormPaciente
    Dim FormEnfermera As FRM_Enfermeria
    Dim FormConsultorio As FormConsultorio
    Dim FormReporte As Reporteria
    Dim Form
    Private Sub FormMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Public Sub VereficarUsuario(depa As String)
        If depa.Equals("Medico") Then
            MsgBox(depa)
            btnRegCita.Enabled = False
            btnRegPaciente.Enabled = False
            btnReporte.Enabled = False

        ElseIf depa.Equals("Enfermermeria") Then

            MsgBox(depa)
            btnRegPaciente.Enabled = False
            btnConsMedico.Enabled = False
            btnReporte.Enabled = False
        ElseIf depa.Equals("Recepcion") Then
            MsgBox(depa)
            BtnConsEnferm.Enabled = False
            btnConsMedico.Enabled = False
            btnReporte.Enabled = False

        End If
    End Sub
End Class