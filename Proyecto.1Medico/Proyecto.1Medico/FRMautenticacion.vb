Imports System.Data
Imports System.Data.SqlClient
Public Class FRMautenticacion
    Dim Autent As New Autenticacion
    Dim bo As Boolean = False
    Dim FormMenu As FormMenu

    Private Sub FRMautenticacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label4.Visible = False
        Label5.Visible = False

    End Sub

    Private Sub BtnIngresar_Click(sender As Object, e As EventArgs) Handles BtnIngresar.Click

        If VerificarCampos() AndAlso Autent.VerificarUSua() Then

            Me.abrirform()

        Else
            MsgBox("Error usario o contraseña incorrecta  ")
        End If
    End Sub


    'verifica los campos del formulario si estan llenos o no y cedula solo numeros
    Public Function VerificarCampos() As Boolean
        Dim ced As Boolean = False
        Dim con As Boolean = False
        If Information.IsNumeric(txtCedula.Text) Then
            Autent.Cedula1 = txtCedula.Text
            ced = True
        Else
            Label4.Text = "En el espacio debe ingresar numeros"
            Label4.Visible = True

        End If

        If txtContrasena.Text.Length > 0 Then
            Autent.Contrasena1 = txtContrasena.Text
            con = True
        Else
            Label5.Text = "En el espacio no debe estar vacio"
            Label5.Visible = True
        End If
        If ced.ToString = True And con = True Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Sub abrirform()
        'If Autent.Departamento1.Equals("Medico") Then
        '    'Me.FormConsultorio = New FormConsultorio
        '    'Me.FormConsultorio.Show()

        Me.FormMenu = New FormMenu()
            Me.FormMenu.VereficarUsuario(Autent.Departamento1)
            Me.FormMenu.Show()




        'ElseIf Autent.Departamento1.Equals("Enfermermeria") Then
        '    'Me.FormEnfermera = New FRM_Enfermeria()
        '    'Me.FormEnfermera.Show()

        'ElseIf Autent.Departamento1.Equals("Recepcion") Then
        '    'Me.FormPaciente = New FormPaciente()
        '    'Me.FormPaciente.Show()
        'End If
    End Sub
End Class