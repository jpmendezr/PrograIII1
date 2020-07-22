<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMConsultorio
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ListSintomas = New System.Windows.Forms.ListBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.RichTextBox()
        Me.txtMedicamentosAdmi = New System.Windows.Forms.RichTextBox()
        Me.TxtMedicamentosRece = New System.Windows.Forms.RichTextBox()
        Me.txtDiagnostico = New System.Windows.Forms.RichTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtPresion = New System.Windows.Forms.TextBox()
        Me.TxtPeso = New System.Windows.Forms.TextBox()
        Me.TxtAltura = New System.Windows.Forms.TextBox()
        Me.TxtSintomas = New System.Windows.Forms.RichTextBox()
        Me.BtnEnviar = New System.Windows.Forms.Button()
        Me.BtnRegistrar = New System.Windows.Forms.Button()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.BtnEnviar)
        Me.Panel1.Controls.Add(Me.TxtSintomas)
        Me.Panel1.Controls.Add(Me.TxtAltura)
        Me.Panel1.Controls.Add(Me.TxtPeso)
        Me.Panel1.Controls.Add(Me.TxtPresion)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(12, 37)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(417, 332)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.txtDiagnostico)
        Me.Panel2.Controls.Add(Me.TxtMedicamentosRece)
        Me.Panel2.Controls.Add(Me.txtMedicamentosAdmi)
        Me.Panel2.Controls.Add(Me.txtDescripcion)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.ListSintomas)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Location = New System.Drawing.Point(445, 37)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(444, 332)
        Me.Panel2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(135, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Enfermeria"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(630, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 25)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Medico"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(3, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(102, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Sintomas Mostrados"
        '
        'ListSintomas
        '
        Me.ListSintomas.FormattingEnabled = True
        Me.ListSintomas.Location = New System.Drawing.Point(3, 25)
        Me.ListSintomas.Name = "ListSintomas"
        Me.ListSintomas.Size = New System.Drawing.Size(120, 95)
        Me.ListSintomas.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(3, 132)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 13)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Descripción"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(333, 9)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(63, 13)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Diagnóstico"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(3, 231)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(144, 13)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Medicamentos Administrados"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(291, 132)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(131, 13)
        Me.Label12.TabIndex = 5
        Me.Label12.Text = "Medicamentos Recetados"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(6, 157)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(186, 62)
        Me.txtDescripcion.TabIndex = 6
        Me.txtDescripcion.Text = ""
        '
        'txtMedicamentosAdmi
        '
        Me.txtMedicamentosAdmi.Location = New System.Drawing.Point(6, 247)
        Me.txtMedicamentosAdmi.Name = "txtMedicamentosAdmi"
        Me.txtMedicamentosAdmi.Size = New System.Drawing.Size(186, 62)
        Me.txtMedicamentosAdmi.TabIndex = 7
        Me.txtMedicamentosAdmi.Text = ""
        '
        'TxtMedicamentosRece
        '
        Me.TxtMedicamentosRece.Location = New System.Drawing.Point(251, 157)
        Me.TxtMedicamentosRece.Name = "TxtMedicamentosRece"
        Me.TxtMedicamentosRece.Size = New System.Drawing.Size(186, 62)
        Me.TxtMedicamentosRece.TabIndex = 8
        Me.TxtMedicamentosRece.Text = ""
        '
        'txtDiagnostico
        '
        Me.txtDiagnostico.Location = New System.Drawing.Point(251, 38)
        Me.txtDiagnostico.Name = "txtDiagnostico"
        Me.txtDiagnostico.Size = New System.Drawing.Size(186, 62)
        Me.txtDiagnostico.TabIndex = 9
        Me.txtDiagnostico.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Presión"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 59)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Peso"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 107)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Altura"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(92, 169)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Síntomas"
        '
        'TxtPresion
        '
        Me.TxtPresion.Location = New System.Drawing.Point(3, 25)
        Me.TxtPresion.Name = "TxtPresion"
        Me.TxtPresion.Size = New System.Drawing.Size(112, 20)
        Me.TxtPresion.TabIndex = 4
        '
        'TxtPeso
        '
        Me.TxtPeso.Location = New System.Drawing.Point(3, 75)
        Me.TxtPeso.Name = "TxtPeso"
        Me.TxtPeso.Size = New System.Drawing.Size(112, 20)
        Me.TxtPeso.TabIndex = 5
        '
        'TxtAltura
        '
        Me.TxtAltura.Location = New System.Drawing.Point(3, 132)
        Me.TxtAltura.Name = "TxtAltura"
        Me.TxtAltura.Size = New System.Drawing.Size(112, 20)
        Me.TxtAltura.TabIndex = 6
        '
        'TxtSintomas
        '
        Me.TxtSintomas.Location = New System.Drawing.Point(6, 197)
        Me.TxtSintomas.Name = "TxtSintomas"
        Me.TxtSintomas.Size = New System.Drawing.Size(233, 103)
        Me.TxtSintomas.TabIndex = 7
        Me.TxtSintomas.Text = ""
        '
        'BtnEnviar
        '
        Me.BtnEnviar.BackColor = System.Drawing.Color.Aqua
        Me.BtnEnviar.Location = New System.Drawing.Point(277, 231)
        Me.BtnEnviar.Name = "BtnEnviar"
        Me.BtnEnviar.Size = New System.Drawing.Size(75, 23)
        Me.BtnEnviar.TabIndex = 8
        Me.BtnEnviar.Text = "Enviar"
        Me.BtnEnviar.UseVisualStyleBackColor = False
        '
        'BtnRegistrar
        '
        Me.BtnRegistrar.BackColor = System.Drawing.Color.Aqua
        Me.BtnRegistrar.Location = New System.Drawing.Point(30, 396)
        Me.BtnRegistrar.Name = "BtnRegistrar"
        Me.BtnRegistrar.Size = New System.Drawing.Size(75, 23)
        Me.BtnRegistrar.TabIndex = 4
        Me.BtnRegistrar.Text = "Registrar"
        Me.BtnRegistrar.UseVisualStyleBackColor = False
        '
        'BtnActualizar
        '
        Me.BtnActualizar.BackColor = System.Drawing.Color.Aqua
        Me.BtnActualizar.Location = New System.Drawing.Point(408, 396)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(75, 23)
        Me.BtnActualizar.TabIndex = 5
        Me.BtnActualizar.Text = "Actualizar"
        Me.BtnActualizar.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.Aqua
        Me.btnEliminar.Location = New System.Drawing.Point(794, 396)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar.TabIndex = 6
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'FRMConsultorio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(888, 452)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.BtnActualizar)
        Me.Controls.Add(Me.BtnRegistrar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FRMConsultorio"
        Me.Text = "FRMConsultorio"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnEnviar As Button
    Friend WithEvents TxtSintomas As RichTextBox
    Friend WithEvents TxtAltura As TextBox
    Friend WithEvents TxtPeso As TextBox
    Friend WithEvents TxtPresion As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtDiagnostico As RichTextBox
    Friend WithEvents TxtMedicamentosRece As RichTextBox
    Friend WithEvents txtMedicamentosAdmi As RichTextBox
    Friend WithEvents txtDescripcion As RichTextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents ListSintomas As ListBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnRegistrar As Button
    Friend WithEvents BtnActualizar As Button
    Friend WithEvents btnEliminar As Button
End Class
