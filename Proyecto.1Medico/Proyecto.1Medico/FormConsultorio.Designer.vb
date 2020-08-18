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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Txtcedula = New System.Windows.Forms.TextBox()
        Me.label = New System.Windows.Forms.Label()
        Me.TxtDiagnostico = New System.Windows.Forms.RichTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
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
        Me.Panel2.Controls.Add(Me.DataGridView1)
        Me.Panel2.Controls.Add(Me.Txtcedula)
        Me.Panel2.Controls.Add(Me.label)
        Me.Panel2.Controls.Add(Me.TxtDiagnostico)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Location = New System.Drawing.Point(12, 47)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(724, 402)
        Me.Panel2.TabIndex = 1
        '
        'txtid
        '
        Me.txtid.Location = New System.Drawing.Point(16, 45)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(100, 20)
        Me.txtid.TabIndex = 19
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 15)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Actualizar por ID"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(16, 268)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(649, 110)
        Me.DataGridView1.TabIndex = 16
        '
        'Txtcedula
        '
        Me.Txtcedula.Location = New System.Drawing.Point(587, 29)
        Me.Txtcedula.Name = "Txtcedula"
        Me.Txtcedula.Size = New System.Drawing.Size(130, 20)
        Me.Txtcedula.TabIndex = 11
        '
        'label
        '
        Me.label.AutoSize = True
        Me.label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label.Location = New System.Drawing.Point(635, 11)
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(52, 15)
        Me.label.TabIndex = 10
        Me.label.Text = "Cedula"
        '
        'TxtDiagnostico
        '
        Me.TxtDiagnostico.Location = New System.Drawing.Point(16, 129)
        Me.TxtDiagnostico.Name = "TxtDiagnostico"
        Me.TxtDiagnostico.Size = New System.Drawing.Size(671, 95)
        Me.TxtDiagnostico.TabIndex = 9
        Me.TxtDiagnostico.Text = ""
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(315, 101)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 15)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Diagnóstico"
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
    Friend WithEvents Label7 As Label
    Friend WithEvents Btnmostrar As Button
    Friend WithEvents BtnActualizar As Button
    Friend WithEvents BtnMedicamentos As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Txtcedula As TextBox
    Friend WithEvents label As Label
    Friend WithEvents Btnexamen As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtid As TextBox
    Friend WithEvents Label3 As Label
End Class
