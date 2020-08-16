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
        Me.Btnregresar = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSintomas = New System.Windows.Forms.RichTextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtsangre = New System.Windows.Forms.TextBox()
        Me.txtorina = New System.Windows.Forms.TextBox()
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Btnmostrar = New System.Windows.Forms.Button()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.BtnMedicamentos = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Btnexamen = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Btnregresar
        '
        Me.Btnregresar.BackColor = System.Drawing.Color.Aqua
        Me.Btnregresar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnregresar.Location = New System.Drawing.Point(538, 454)
        Me.Btnregresar.Name = "Btnregresar"
        Me.Btnregresar.Size = New System.Drawing.Size(75, 23)
        Me.Btnregresar.TabIndex = 8
        Me.Btnregresar.Text = "Regresar"
        Me.Btnregresar.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.txtid)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.txtSintomas)
        Me.Panel2.Controls.Add(Me.DataGridView1)
        Me.Panel2.Controls.Add(Me.txtsangre)
        Me.Panel2.Controls.Add(Me.txtorina)
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
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Location = New System.Drawing.Point(12, 47)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(724, 402)
        Me.Panel2.TabIndex = 1
        '
        'txtid
        '
        Me.txtid.Location = New System.Drawing.Point(358, 97)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(100, 20)
        Me.txtid.TabIndex = 19
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(355, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 15)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Actualizar por ID"
        '
        'txtSintomas
        '
        Me.txtSintomas.Location = New System.Drawing.Point(16, 160)
        Me.txtSintomas.Name = "txtSintomas"
        Me.txtSintomas.Size = New System.Drawing.Size(307, 95)
        Me.txtSintomas.TabIndex = 17
        Me.txtSintomas.Text = ""
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(16, 268)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(649, 110)
        Me.DataGridView1.TabIndex = 16
        '
        'txtsangre
        '
        Me.txtsangre.Location = New System.Drawing.Point(16, 97)
        Me.txtsangre.Name = "txtsangre"
        Me.txtsangre.Size = New System.Drawing.Size(100, 20)
        Me.txtsangre.TabIndex = 15
        '
        'txtorina
        '
        Me.txtorina.Location = New System.Drawing.Point(168, 97)
        Me.txtorina.Name = "txtorina"
        Me.txtorina.Size = New System.Drawing.Size(100, 20)
        Me.txtorina.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 15)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Examen sangre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(165, 70)
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
        Me.TxtDiagnostico.Location = New System.Drawing.Point(358, 160)
        Me.TxtDiagnostico.Name = "TxtDiagnostico"
        Me.TxtDiagnostico.Size = New System.Drawing.Size(307, 95)
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
        'Btnmostrar
        '
        Me.Btnmostrar.BackColor = System.Drawing.Color.Aqua
        Me.Btnmostrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnmostrar.Location = New System.Drawing.Point(436, 455)
        Me.Btnmostrar.Name = "Btnmostrar"
        Me.Btnmostrar.Size = New System.Drawing.Size(75, 23)
        Me.Btnmostrar.TabIndex = 9
        Me.Btnmostrar.Text = "Mostrar"
        Me.Btnmostrar.UseVisualStyleBackColor = False
        '
        'BtnActualizar
        '
        Me.BtnActualizar.BackColor = System.Drawing.Color.Aqua
        Me.BtnActualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnActualizar.Location = New System.Drawing.Point(118, 455)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(75, 23)
        Me.BtnActualizar.TabIndex = 10
        Me.BtnActualizar.Text = "Actualizar"
        Me.BtnActualizar.UseVisualStyleBackColor = False
        '
        'BtnMedicamentos
        '
        Me.BtnMedicamentos.BackColor = System.Drawing.Color.Aqua
        Me.BtnMedicamentos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMedicamentos.Location = New System.Drawing.Point(211, 455)
        Me.BtnMedicamentos.Name = "BtnMedicamentos"
        Me.BtnMedicamentos.Size = New System.Drawing.Size(99, 23)
        Me.BtnMedicamentos.TabIndex = 11
        Me.BtnMedicamentos.Text = "Medicamentos"
        Me.BtnMedicamentos.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(319, 9)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(88, 25)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "Medico"
        '
        'Btnexamen
        '
        Me.Btnexamen.BackColor = System.Drawing.Color.Aqua
        Me.Btnexamen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnexamen.Location = New System.Drawing.Point(332, 455)
        Me.Btnexamen.Name = "Btnexamen"
        Me.Btnexamen.Size = New System.Drawing.Size(75, 23)
        Me.Btnexamen.TabIndex = 14
        Me.Btnexamen.Text = "Examenes"
        Me.Btnexamen.UseVisualStyleBackColor = False
        '
        'FormConsultorio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(748, 494)
        Me.Controls.Add(Me.Btnexamen)
        Me.Controls.Add(Me.Btnregresar)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.BtnMedicamentos)
        Me.Controls.Add(Me.BtnActualizar)
        Me.Controls.Add(Me.Btnmostrar)
        Me.Controls.Add(Me.Panel2)
        Me.MaximizeBox = False
        Me.Name = "FormConsultorio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormConsultorio"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Btnregresar As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TxtDiagnostico As RichTextBox
    Friend WithEvents txtMedicamentosAdminis As RichTextBox
    Friend WithEvents TxtMedicamentosRece As RichTextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Btnmostrar As Button
    Friend WithEvents BtnActualizar As Button
    Friend WithEvents BtnMedicamentos As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Txtcedula As TextBox
    Friend WithEvents label As Label
    Friend WithEvents Btnexamen As Button
    Friend WithEvents txtsangre As TextBox
    Friend WithEvents txtorina As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtSintomas As RichTextBox
    Friend WithEvents txtid As TextBox
    Friend WithEvents Label3 As Label
End Class
