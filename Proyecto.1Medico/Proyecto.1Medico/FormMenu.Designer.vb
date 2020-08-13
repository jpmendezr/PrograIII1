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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(582, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(239, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Menú De Usuario"
        '
        'btnRegPaciente
        '
        Me.btnRegPaciente.BackColor = System.Drawing.Color.Aqua
        Me.btnRegPaciente.Location = New System.Drawing.Point(10, 592)
        Me.btnRegPaciente.Name = "btnRegPaciente"
        Me.btnRegPaciente.Size = New System.Drawing.Size(124, 23)
        Me.btnRegPaciente.TabIndex = 1
        Me.btnRegPaciente.Text = "Registrar Paciente"
        Me.btnRegPaciente.UseVisualStyleBackColor = False
        '
        'btnRegCita
        '
        Me.btnRegCita.BackColor = System.Drawing.Color.Aqua
        Me.btnRegCita.Location = New System.Drawing.Point(168, 659)
        Me.btnRegCita.Name = "btnRegCita"
        Me.btnRegCita.Size = New System.Drawing.Size(126, 23)
        Me.btnRegCita.TabIndex = 2
        Me.btnRegCita.Text = "Registrar Cita"
        Me.btnRegCita.UseVisualStyleBackColor = False
        '
        'btnConsMedico
        '
        Me.btnConsMedico.BackColor = System.Drawing.Color.Aqua
        Me.btnConsMedico.Location = New System.Drawing.Point(322, 659)
        Me.btnConsMedico.Name = "btnConsMedico"
        Me.btnConsMedico.Size = New System.Drawing.Size(119, 23)
        Me.btnConsMedico.TabIndex = 3
        Me.btnConsMedico.Text = "Consultorio Medico"
        Me.btnConsMedico.UseVisualStyleBackColor = False
        '
        'BtnConsEnferm
        '
        Me.BtnConsEnferm.BackColor = System.Drawing.Color.Aqua
        Me.BtnConsEnferm.Location = New System.Drawing.Point(163, 592)
        Me.BtnConsEnferm.Name = "BtnConsEnferm"
        Me.BtnConsEnferm.Size = New System.Drawing.Size(131, 23)
        Me.BtnConsEnferm.TabIndex = 4
        Me.BtnConsEnferm.Text = "Consultorio Enfermeria"
        Me.BtnConsEnferm.UseVisualStyleBackColor = False
        '
        'btnReporte
        '
        Me.btnReporte.BackColor = System.Drawing.Color.Aqua
        Me.btnReporte.Location = New System.Drawing.Point(32, 659)
        Me.btnReporte.Name = "btnReporte"
        Me.btnReporte.Size = New System.Drawing.Size(75, 23)
        Me.btnReporte.TabIndex = 5
        Me.btnReporte.Text = "Reporte"
        Me.btnReporte.UseVisualStyleBackColor = False
        '
        'btnAbrir
        '
        Me.btnAbrir.BackColor = System.Drawing.Color.Aqua
        Me.btnAbrir.Location = New System.Drawing.Point(322, 592)
        Me.btnAbrir.Name = "btnAbrir"
        Me.btnAbrir.Size = New System.Drawing.Size(103, 23)
        Me.btnAbrir.TabIndex = 6
        Me.btnAbrir.Text = "Ingreso Usuarios"
        Me.btnAbrir.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.BtnConsEnferm)
        Me.Panel1.Controls.Add(Me.btnAbrir)
        Me.Panel1.Controls.Add(Me.btnRegPaciente)
        Me.Panel1.Controls.Add(Me.btnConsMedico)
        Me.Panel1.Controls.Add(Me.btnReporte)
        Me.Panel1.Controls.Add(Me.btnRegCita)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1366, 713)
        Me.Panel1.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(984, 158)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(240, 31)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Fundado en 2020"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(1019, 127)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(171, 31)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Guanacaste"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(1008, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(199, 31)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Centro Clínico"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(1016, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(191, 31)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "¡Bienvenidos!"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Proyecto._1Medico.My.Resources.Resources.doctorhospital_101095
        Me.PictureBox1.Location = New System.Drawing.Point(717, 353)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(126, 119)
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Proyecto._1Medico.My.Resources.Resources.hospital_health_clinic_urban_buildings_medical_icon_134527
        Me.PictureBox2.Location = New System.Drawing.Point(588, 466)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(255, 245)
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Proyecto._1Medico.My.Resources.Resources.medicine_2_icon_icons_com_66043
        Me.PictureBox3.Location = New System.Drawing.Point(844, 192)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(515, 519)
        Me.PictureBox3.TabIndex = 15
        Me.PictureBox3.TabStop = False
        '
        'FormMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1366, 713)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.Name = "FormMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menú"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
End Class
