<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMenu
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnRegPaciente = New System.Windows.Forms.Button()
        Me.btnRegCita = New System.Windows.Forms.Button()
        Me.btnConsMedico = New System.Windows.Forms.Button()
        Me.BtnConsEnferm = New System.Windows.Forms.Button()
        Me.btnReporte = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(343, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Menu de Usuario"
        '
        'btnRegPaciente
        '
        Me.btnRegPaciente.Location = New System.Drawing.Point(22, 319)
        Me.btnRegPaciente.Name = "btnRegPaciente"
        Me.btnRegPaciente.Size = New System.Drawing.Size(139, 23)
        Me.btnRegPaciente.TabIndex = 1
        Me.btnRegPaciente.Text = "Registrar Paciente"
        Me.btnRegPaciente.UseVisualStyleBackColor = True
        '
        'btnRegCita
        '
        Me.btnRegCita.Location = New System.Drawing.Point(366, 319)
        Me.btnRegCita.Name = "btnRegCita"
        Me.btnRegCita.Size = New System.Drawing.Size(166, 23)
        Me.btnRegCita.TabIndex = 2
        Me.btnRegCita.Text = "Registrar Cita"
        Me.btnRegCita.UseVisualStyleBackColor = True
        '
        'btnConsMedico
        '
        Me.btnConsMedico.Location = New System.Drawing.Point(557, 319)
        Me.btnConsMedico.Name = "btnConsMedico"
        Me.btnConsMedico.Size = New System.Drawing.Size(139, 23)
        Me.btnConsMedico.TabIndex = 3
        Me.btnConsMedico.Text = "Consultorio Medico"
        Me.btnConsMedico.UseVisualStyleBackColor = True
        '
        'BtnConsEnferm
        '
        Me.BtnConsEnferm.Location = New System.Drawing.Point(185, 319)
        Me.BtnConsEnferm.Name = "BtnConsEnferm"
        Me.BtnConsEnferm.Size = New System.Drawing.Size(166, 23)
        Me.BtnConsEnferm.TabIndex = 4
        Me.BtnConsEnferm.Text = "Consultorio Enfermeria"
        Me.BtnConsEnferm.UseVisualStyleBackColor = True
        '
        'btnReporte
        '
        Me.btnReporte.Location = New System.Drawing.Point(713, 319)
        Me.btnReporte.Name = "btnReporte"
        Me.btnReporte.Size = New System.Drawing.Size(75, 23)
        Me.btnReporte.TabIndex = 5
        Me.btnReporte.Text = "Reporte"
        Me.btnReporte.UseVisualStyleBackColor = True
        '
        'FormMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnReporte)
        Me.Controls.Add(Me.BtnConsEnferm)
        Me.Controls.Add(Me.btnConsMedico)
        Me.Controls.Add(Me.btnRegCita)
        Me.Controls.Add(Me.btnRegPaciente)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormMenu"
        Me.Text = "FormMenu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnRegPaciente As Button
    Friend WithEvents btnRegCita As Button
    Friend WithEvents btnConsMedico As Button
    Friend WithEvents BtnConsEnferm As Button
    Friend WithEvents btnReporte As Button
End Class
