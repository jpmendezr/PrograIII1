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
        Me.Btnagregar = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txtcedula = New System.Windows.Forms.TextBox()
        Me.label = New System.Windows.Forms.Label()
        Me.TxtDiagnostico = New System.Windows.Forms.RichTextBox()
        Me.txtMedicamentosAdminis = New System.Windows.Forms.RichTextBox()
        Me.TxtMedicamentosRece = New System.Windows.Forms.RichTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ListSintomas = New System.Windows.Forms.ListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnRegresar = New System.Windows.Forms.Button()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Btnexamen = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Btnagregar
        '
        Me.Btnagregar.BackColor = System.Drawing.Color.Aqua
        Me.Btnagregar.Location = New System.Drawing.Point(549, 473)
        Me.Btnagregar.Name = "Btnagregar"
        Me.Btnagregar.Size = New System.Drawing.Size(75, 23)
        Me.Btnagregar.TabIndex = 8
        Me.Btnagregar.Text = "Agregar"
        Me.Btnagregar.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.DataGridView1)
        Me.Panel2.Controls.Add(Me.TextBox2)
        Me.Panel2.Controls.Add(Me.TextBox1)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Txtcedula)
        Me.Panel2.Controls.Add(Me.label)
        Me.Panel2.Controls.Add(Me.TxtDiagnostico)
        Me.Panel2.Controls.Add(Me.txtMedicamentosAdminis)
        Me.Panel2.Controls.Add(Me.TxtMedicamentosRece)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.ListSintomas)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Location = New System.Drawing.Point(12, 47)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(724, 402)
        Me.Panel2.TabIndex = 1
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(168, 97)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 15
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(16, 97)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(165, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 15)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Examen sangre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 15)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Examen Orina"
        '
        'Txtcedula
        '
        Me.Txtcedula.Location = New System.Drawing.Point(16, 32)
        Me.Txtcedula.Name = "Txtcedula"
        Me.Txtcedula.Size = New System.Drawing.Size(130, 20)
        Me.Txtcedula.TabIndex = 11
        '
        'label
        '
        Me.label.AutoSize = True
        Me.label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label.Location = New System.Drawing.Point(13, 14)
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(52, 15)
        Me.label.TabIndex = 10
        Me.label.Text = "Cedula"
        '
        'TxtDiagnostico
        '
        Me.TxtDiagnostico.Location = New System.Drawing.Point(358, 169)
        Me.TxtDiagnostico.Name = "TxtDiagnostico"
        Me.TxtDiagnostico.Size = New System.Drawing.Size(307, 82)
        Me.TxtDiagnostico.TabIndex = 9
        Me.TxtDiagnostico.Text = ""
        '
        'txtMedicamentosAdminis
        '
        Me.txtMedicamentosAdminis.Location = New System.Drawing.Point(168, 32)
        Me.txtMedicamentosAdminis.Name = "txtMedicamentosAdminis"
        Me.txtMedicamentosAdminis.Size = New System.Drawing.Size(170, 24)
        Me.txtMedicamentosAdminis.TabIndex = 8
        Me.txtMedicamentosAdminis.Text = ""
        '
        'TxtMedicamentosRece
        '
        Me.TxtMedicamentosRece.Location = New System.Drawing.Point(358, 32)
        Me.TxtMedicamentosRece.Name = "TxtMedicamentosRece"
        Me.TxtMedicamentosRece.Size = New System.Drawing.Size(193, 24)
        Me.TxtMedicamentosRece.TabIndex = 7
        Me.TxtMedicamentosRece.Text = ""
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(165, 14)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(173, 15)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Medicamentos Recetados"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(355, 14)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(196, 15)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Medicamentos Administrados"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(355, 130)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 15)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Diagnóstico"
        '
        'ListSintomas
        '
        Me.ListSintomas.FormattingEnabled = True
        Me.ListSintomas.Location = New System.Drawing.Point(16, 169)
        Me.ListSintomas.Name = "ListSintomas"
        Me.ListSintomas.Size = New System.Drawing.Size(297, 82)
        Me.ListSintomas.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(13, 130)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(138, 15)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Sintomas Mostrados"
        '
        'btnRegresar
        '
        Me.btnRegresar.BackColor = System.Drawing.Color.Aqua
        Me.btnRegresar.Location = New System.Drawing.Point(411, 473)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(75, 23)
        Me.btnRegresar.TabIndex = 9
        Me.btnRegresar.Text = "Mostrar"
        Me.btnRegresar.UseVisualStyleBackColor = False
        '
        'BtnActualizar
        '
        Me.BtnActualizar.BackColor = System.Drawing.Color.Aqua
        Me.BtnActualizar.Location = New System.Drawing.Point(55, 473)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(75, 23)
        Me.BtnActualizar.TabIndex = 10
        Me.BtnActualizar.Text = "Actualizar"
        Me.BtnActualizar.UseVisualStyleBackColor = False
        '
        'BtnEliminar
        '
        Me.BtnEliminar.BackColor = System.Drawing.Color.Aqua
        Me.BtnEliminar.Location = New System.Drawing.Point(165, 473)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(88, 23)
        Me.BtnEliminar.TabIndex = 11
        Me.BtnEliminar.Text = "Medicamentos"
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
        'Btnexamen
        '
        Me.Btnexamen.BackColor = System.Drawing.Color.Aqua
        Me.Btnexamen.Location = New System.Drawing.Point(292, 473)
        Me.Btnexamen.Name = "Btnexamen"
        Me.Btnexamen.Size = New System.Drawing.Size(75, 23)
        Me.Btnexamen.TabIndex = 14
        Me.Btnexamen.Text = "Examenes"
        Me.Btnexamen.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(16, 268)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(649, 110)
        Me.DataGridView1.TabIndex = 16
        '
        'FormConsultorio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(748, 508)
        Me.Controls.Add(Me.Btnexamen)
        Me.Controls.Add(Me.Btnagregar)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnActualizar)
        Me.Controls.Add(Me.btnRegresar)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "FormConsultorio"
        Me.Text = "FormConsultorio"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Btnagregar As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TxtDiagnostico As RichTextBox
    Friend WithEvents txtMedicamentosAdminis As RichTextBox
    Friend WithEvents TxtMedicamentosRece As RichTextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents ListSintomas As ListBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnRegresar As Button
    Friend WithEvents BtnActualizar As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Txtcedula As TextBox
    Friend WithEvents label As Label
    Friend WithEvents Btnexamen As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
End Class
