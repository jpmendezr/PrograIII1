<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMagendar
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
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextHora = New System.Windows.Forms.TextBox()
        Me.TextEspecialidad = New System.Windows.Forms.TextBox()
        Me.TextNMedico = New System.Windows.Forms.TextBox()
        Me.TextCedula = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.BtnCitas = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBoxDia = New System.Windows.Forms.TextBox()
        Me.TextBoxMes = New System.Windows.Forms.TextBox()
        Me.TextBoxAño = New System.Windows.Forms.TextBox()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.BtnRegresar = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnEliminar
        '
        Me.BtnEliminar.BackColor = System.Drawing.Color.Aqua
        Me.BtnEliminar.Location = New System.Drawing.Point(571, 415)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(120, 23)
        Me.BtnEliminar.TabIndex = 0
        Me.BtnEliminar.Text = "Eliminar Citas"
        Me.BtnEliminar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Fecha"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(209, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Hora"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(351, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 15)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Especialidad"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(480, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(133, 15)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Nombre del Medico"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(675, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(136, 15)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Cedula del Paciente"
        '
        'TextHora
        '
        Me.TextHora.Location = New System.Drawing.Point(212, 53)
        Me.TextHora.Name = "TextHora"
        Me.TextHora.Size = New System.Drawing.Size(100, 20)
        Me.TextHora.TabIndex = 6
        '
        'TextEspecialidad
        '
        Me.TextEspecialidad.Location = New System.Drawing.Point(354, 53)
        Me.TextEspecialidad.Name = "TextEspecialidad"
        Me.TextEspecialidad.Size = New System.Drawing.Size(100, 20)
        Me.TextEspecialidad.TabIndex = 7
        '
        'TextNMedico
        '
        Me.TextNMedico.Location = New System.Drawing.Point(483, 53)
        Me.TextNMedico.Multiline = True
        Me.TextNMedico.Name = "TextNMedico"
        Me.TextNMedico.Size = New System.Drawing.Size(167, 20)
        Me.TextNMedico.TabIndex = 8
        '
        'TextCedula
        '
        Me.TextCedula.Location = New System.Drawing.Point(678, 53)
        Me.TextCedula.Name = "TextCedula"
        Me.TextCedula.Size = New System.Drawing.Size(155, 20)
        Me.TextCedula.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(16, 108)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(123, 15)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Citas Disponibles:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(388, 108)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(110, 15)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Actualizar Citas:"
        '
        'BtnActualizar
        '
        Me.BtnActualizar.BackColor = System.Drawing.Color.Aqua
        Me.BtnActualizar.Location = New System.Drawing.Point(392, 415)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(75, 23)
        Me.BtnActualizar.TabIndex = 15
        Me.BtnActualizar.Text = "Actualizar"
        Me.BtnActualizar.UseVisualStyleBackColor = False
        '
        'BtnCitas
        '
        Me.BtnCitas.BackColor = System.Drawing.Color.Aqua
        Me.BtnCitas.Location = New System.Drawing.Point(162, 415)
        Me.BtnCitas.Name = "BtnCitas"
        Me.BtnCitas.Size = New System.Drawing.Size(120, 23)
        Me.BtnCitas.TabIndex = 16
        Me.BtnCitas.Text = "Citas Disponibles"
        Me.BtnCitas.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(731, 108)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(97, 15)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Elminar Citas:"
        '
        'TextBoxDia
        '
        Me.TextBoxDia.Location = New System.Drawing.Point(19, 53)
        Me.TextBoxDia.Name = "TextBoxDia"
        Me.TextBoxDia.Size = New System.Drawing.Size(40, 20)
        Me.TextBoxDia.TabIndex = 21
        '
        'TextBoxMes
        '
        Me.TextBoxMes.Location = New System.Drawing.Point(65, 53)
        Me.TextBoxMes.Name = "TextBoxMes"
        Me.TextBoxMes.Size = New System.Drawing.Size(40, 20)
        Me.TextBoxMes.TabIndex = 22
        '
        'TextBoxAño
        '
        Me.TextBoxAño.Location = New System.Drawing.Point(111, 53)
        Me.TextBoxAño.Name = "TextBoxAño"
        Me.TextBoxAño.Size = New System.Drawing.Size(40, 20)
        Me.TextBoxAño.TabIndex = 23
        '
        'BtnAgregar
        '
        Me.BtnAgregar.BackColor = System.Drawing.Color.Aqua
        Me.BtnAgregar.Location = New System.Drawing.Point(16, 415)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(120, 23)
        Me.BtnAgregar.TabIndex = 24
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.UseVisualStyleBackColor = False
        '
        'BtnRegresar
        '
        Me.BtnRegresar.BackColor = System.Drawing.Color.Aqua
        Me.BtnRegresar.Location = New System.Drawing.Point(713, 415)
        Me.BtnRegresar.Name = "BtnRegresar"
        Me.BtnRegresar.Size = New System.Drawing.Size(120, 23)
        Me.BtnRegresar.TabIndex = 25
        Me.BtnRegresar.Text = "Regresar"
        Me.BtnRegresar.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(19, 155)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(814, 254)
        Me.DataGridView1.TabIndex = 26
        '
        'FRMagendar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(857, 450)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.BtnRegresar)
        Me.Controls.Add(Me.BtnAgregar)
        Me.Controls.Add(Me.TextBoxAño)
        Me.Controls.Add(Me.TextBoxMes)
        Me.Controls.Add(Me.TextBoxDia)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.BtnCitas)
        Me.Controls.Add(Me.BtnActualizar)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextCedula)
        Me.Controls.Add(Me.TextNMedico)
        Me.Controls.Add(Me.TextEspecialidad)
        Me.Controls.Add(Me.TextHora)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Name = "FRMagendar"
        Me.Text = "Agendar Citas"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnEliminar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextHora As TextBox
    Friend WithEvents TextEspecialidad As TextBox
    Friend WithEvents TextNMedico As TextBox
    Friend WithEvents TextCedula As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents BtnActualizar As Button
    Friend WithEvents BtnCitas As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBoxDia As TextBox
    Friend WithEvents TextBoxMes As TextBox
    Friend WithEvents TextBoxAño As TextBox
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents BtnRegresar As Button
    Friend WithEvents DataGridView1 As DataGridView
End Class
