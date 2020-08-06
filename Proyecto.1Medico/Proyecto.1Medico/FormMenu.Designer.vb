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
        Me.btnAbrir = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(161, 1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(234, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Menu de Usuario"
        '
        'btnRegPaciente
        '
        Me.btnRegPaciente.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnRegPaciente.Location = New System.Drawing.Point(16, 317)
        Me.btnRegPaciente.Name = "btnRegPaciente"
        Me.btnRegPaciente.Size = New System.Drawing.Size(124, 23)
        Me.btnRegPaciente.TabIndex = 1
        Me.btnRegPaciente.Text = "Registrar Paciente"
        Me.btnRegPaciente.UseVisualStyleBackColor = False
        '
        'btnRegCita
        '
        Me.btnRegCita.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnRegCita.Location = New System.Drawing.Point(464, 317)
        Me.btnRegCita.Name = "btnRegCita"
        Me.btnRegCita.Size = New System.Drawing.Size(126, 23)
        Me.btnRegCita.TabIndex = 2
        Me.btnRegCita.Text = "Registrar Cita"
        Me.btnRegCita.UseVisualStyleBackColor = False
        '
        'btnConsMedico
        '
        Me.btnConsMedico.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnConsMedico.Location = New System.Drawing.Point(471, 356)
        Me.btnConsMedico.Name = "btnConsMedico"
        Me.btnConsMedico.Size = New System.Drawing.Size(119, 23)
        Me.btnConsMedico.TabIndex = 3
        Me.btnConsMedico.Text = "Consultorio Medico"
        Me.btnConsMedico.UseVisualStyleBackColor = False
        '
        'BtnConsEnferm
        '
        Me.BtnConsEnferm.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnConsEnferm.Location = New System.Drawing.Point(16, 356)
        Me.BtnConsEnferm.Name = "BtnConsEnferm"
        Me.BtnConsEnferm.Size = New System.Drawing.Size(131, 23)
        Me.BtnConsEnferm.TabIndex = 4
        Me.BtnConsEnferm.Text = "Consultorio Enfermeria"
        Me.BtnConsEnferm.UseVisualStyleBackColor = False
        '
        'btnReporte
        '
        Me.btnReporte.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnReporte.Location = New System.Drawing.Point(272, 356)
        Me.btnReporte.Name = "btnReporte"
        Me.btnReporte.Size = New System.Drawing.Size(75, 23)
        Me.btnReporte.TabIndex = 5
        Me.btnReporte.Text = "Reporte"
        Me.btnReporte.UseVisualStyleBackColor = False
        '
        'btnAbrir
        '
        Me.btnAbrir.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAbrir.Location = New System.Drawing.Point(259, 317)
        Me.btnAbrir.Name = "btnAbrir"
        Me.btnAbrir.Size = New System.Drawing.Size(103, 23)
        Me.btnAbrir.TabIndex = 6
        Me.btnAbrir.Text = "Ingreso Usuarios"
        Me.btnAbrir.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.BtnConsEnferm)
        Me.Panel1.Controls.Add(Me.btnAbrir)
        Me.Panel1.Controls.Add(Me.btnRegPaciente)
        Me.Panel1.Controls.Add(Me.btnConsMedico)
        Me.Panel1.Controls.Add(Me.btnReporte)
        Me.Panel1.Controls.Add(Me.btnRegCita)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(-4, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(603, 424)
        Me.Panel1.TabIndex = 8
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Proyecto._1Medico.My.Resources.Resources.Hospital
        Me.PictureBox1.Location = New System.Drawing.Point(3, 40)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(598, 259)
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'FormMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(598, 423)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.Name = "FormMenu"
        Me.Text = "FormMenu"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnRegPaciente As Button
    Friend WithEvents btnRegCita As Button
    Friend WithEvents btnConsMedico As Button
    Friend WithEvents BtnConsEnferm As Button
    Friend WithEvents btnReporte As Button
    Friend WithEvents btnAbrir As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
End Class
