<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormConsultorio
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
        Me.BtnEnviar = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TxtDiagnostico = New System.Windows.Forms.RichTextBox()
        Me.txtMedicamentosAdminis = New System.Windows.Forms.RichTextBox()
        Me.TxtMedicamentosRece = New System.Windows.Forms.RichTextBox()
        Me.TxtDescrip = New System.Windows.Forms.RichTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ListSintomas = New System.Windows.Forms.ListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnRegresar = New System.Windows.Forms.Button()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnEnviar
        '
        Me.BtnEnviar.BackColor = System.Drawing.Color.Aqua
        Me.BtnEnviar.Location = New System.Drawing.Point(428, 301)
        Me.BtnEnviar.Name = "BtnEnviar"
        Me.BtnEnviar.Size = New System.Drawing.Size(75, 23)
        Me.BtnEnviar.TabIndex = 8
        Me.BtnEnviar.Text = "Enviar"
        Me.BtnEnviar.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.BtnEnviar)
        Me.Panel2.Controls.Add(Me.TxtDiagnostico)
        Me.Panel2.Controls.Add(Me.txtMedicamentosAdminis)
        Me.Panel2.Controls.Add(Me.TxtMedicamentosRece)
        Me.Panel2.Controls.Add(Me.TxtDescrip)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.ListSintomas)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Location = New System.Drawing.Point(12, 47)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(724, 375)
        Me.Panel2.TabIndex = 1
        '
        'TxtDiagnostico
        '
        Me.TxtDiagnostico.Location = New System.Drawing.Point(339, 45)
        Me.TxtDiagnostico.Name = "TxtDiagnostico"
        Me.TxtDiagnostico.Size = New System.Drawing.Size(365, 82)
        Me.TxtDiagnostico.TabIndex = 9
        Me.TxtDiagnostico.Text = ""
        '
        'txtMedicamentosAdminis
        '
        Me.txtMedicamentosAdminis.Location = New System.Drawing.Point(329, 172)
        Me.txtMedicamentosAdminis.Name = "txtMedicamentosAdminis"
        Me.txtMedicamentosAdminis.Size = New System.Drawing.Size(375, 80)
        Me.txtMedicamentosAdminis.TabIndex = 8
        Me.txtMedicamentosAdminis.Text = ""
        '
        'TxtMedicamentosRece
        '
        Me.TxtMedicamentosRece.Location = New System.Drawing.Point(16, 289)
        Me.TxtMedicamentosRece.Name = "TxtMedicamentosRece"
        Me.TxtMedicamentosRece.Size = New System.Drawing.Size(297, 70)
        Me.TxtMedicamentosRece.TabIndex = 7
        Me.TxtMedicamentosRece.Text = ""
        '
        'TxtDescrip
        '
        Me.TxtDescrip.Location = New System.Drawing.Point(16, 172)
        Me.TxtDescrip.Name = "TxtDescrip"
        Me.TxtDescrip.Size = New System.Drawing.Size(297, 80)
        Me.TxtDescrip.TabIndex = 6
        Me.TxtDescrip.Text = ""
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(18, 264)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(173, 15)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Medicamentos Recetados"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(336, 140)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(196, 15)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Medicamentos Administrados"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(336, 15)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 15)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Diagnóstico"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(18, 140)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 15)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Descripción"
        '
        'ListSintomas
        '
        Me.ListSintomas.FormattingEnabled = True
        Me.ListSintomas.Location = New System.Drawing.Point(16, 45)
        Me.ListSintomas.Name = "ListSintomas"
        Me.ListSintomas.Size = New System.Drawing.Size(297, 82)
        Me.ListSintomas.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(13, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(138, 15)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Sintomas Mostrados"
        '
        'btnRegresar
        '
        Me.btnRegresar.BackColor = System.Drawing.Color.Aqua
        Me.btnRegresar.Location = New System.Drawing.Point(324, 428)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(75, 23)
        Me.btnRegresar.TabIndex = 9
        Me.btnRegresar.Text = "Regresar"
        Me.btnRegresar.UseVisualStyleBackColor = False
        '
        'BtnActualizar
        '
        Me.BtnActualizar.BackColor = System.Drawing.Color.Aqua
        Me.BtnActualizar.Location = New System.Drawing.Point(30, 428)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(75, 23)
        Me.BtnActualizar.TabIndex = 10
        Me.BtnActualizar.Text = "Actualizar"
        Me.BtnActualizar.UseVisualStyleBackColor = False
        '
        'BtnEliminar
        '
        Me.BtnEliminar.BackColor = System.Drawing.Color.Aqua
        Me.BtnEliminar.Location = New System.Drawing.Point(643, 428)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.BtnEliminar.TabIndex = 11
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(319, 9)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(88, 25)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "Medico"
        '
        'FormConsultorio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(748, 454)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnActualizar)
        Me.Controls.Add(Me.btnRegresar)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "FormConsultorio"
        Me.Text = "FormConsultorio"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnEnviar As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TxtDiagnostico As RichTextBox
    Friend WithEvents txtMedicamentosAdminis As RichTextBox
    Friend WithEvents TxtMedicamentosRece As RichTextBox
    Friend WithEvents TxtDescrip As RichTextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents ListSintomas As ListBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnRegresar As Button
    Friend WithEvents BtnActualizar As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents Label11 As Label
End Class
