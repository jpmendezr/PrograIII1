<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRM_Enfermeria
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ID = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BtnMostrar = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Btnregresar = New System.Windows.Forms.Button()
        Me.TxtSintomas = New System.Windows.Forms.RichTextBox()
        Me.BTNactualizar = New System.Windows.Forms.Button()
        Me.txtcedula = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Txtpeso = New System.Windows.Forms.TextBox()
        Me.TXTaltura = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TXTtiposangre = New System.Windows.Forms.TextBox()
        Me.TXTMedicamentosAler = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(332, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enfermeria"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(373, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Altura"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(572, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Peso"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(18, 115)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Sintoma"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.TXTMedicamentosAler)
        Me.Panel1.Controls.Add(Me.TXTtiposangre)
        Me.Panel1.Controls.Add(Me.ID)
        Me.Panel1.Controls.Add(Me.txtId)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.BtnMostrar)
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.ListBox1)
        Me.Panel1.Controls.Add(Me.Btnregresar)
        Me.Panel1.Controls.Add(Me.TxtSintomas)
        Me.Panel1.Controls.Add(Me.BTNactualizar)
        Me.Panel1.Controls.Add(Me.txtcedula)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Txtpeso)
        Me.Panel1.Controls.Add(Me.TXTaltura)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(61, 92)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(678, 415)
        Me.Panel1.TabIndex = 5
        '
        'ID
        '
        Me.ID.AutoSize = True
        Me.ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ID.Location = New System.Drawing.Point(22, 10)
        Me.ID.Name = "ID"
        Me.ID.Size = New System.Drawing.Size(21, 15)
        Me.ID.TabIndex = 19
        Me.ID.Text = "ID"
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(21, 28)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(124, 20)
        Me.txtId.TabIndex = 18
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(320, 117)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(97, 15)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Mostrar Datos"
        '
        'BtnMostrar
        '
        Me.BtnMostrar.BackColor = System.Drawing.Color.Aqua
        Me.BtnMostrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMostrar.Location = New System.Drawing.Point(431, 377)
        Me.BtnMostrar.Name = "BtnMostrar"
        Me.BtnMostrar.Size = New System.Drawing.Size(75, 23)
        Me.BtnMostrar.TabIndex = 16
        Me.BtnMostrar.Text = "Mostrar"
        Me.BtnMostrar.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(323, 149)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(332, 222)
        Me.DataGridView1.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(18, 264)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(184, 15)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Mostrar Sintmas Agregados"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(21, 292)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(249, 108)
        Me.ListBox1.TabIndex = 13
        '
        'Btnregresar
        '
        Me.Btnregresar.BackColor = System.Drawing.Color.Aqua
        Me.Btnregresar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnregresar.Location = New System.Drawing.Point(600, 377)
        Me.Btnregresar.Name = "Btnregresar"
        Me.Btnregresar.Size = New System.Drawing.Size(75, 23)
        Me.Btnregresar.TabIndex = 12
        Me.Btnregresar.Text = "Regresar"
        Me.Btnregresar.UseVisualStyleBackColor = False
        '
        'TxtSintomas
        '
        Me.TxtSintomas.Location = New System.Drawing.Point(21, 149)
        Me.TxtSintomas.Name = "TxtSintomas"
        Me.TxtSintomas.Size = New System.Drawing.Size(249, 108)
        Me.TxtSintomas.TabIndex = 11
        Me.TxtSintomas.Text = ""
        '
        'BTNactualizar
        '
        Me.BTNactualizar.BackColor = System.Drawing.Color.Aqua
        Me.BTNactualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNactualizar.Location = New System.Drawing.Point(512, 377)
        Me.BTNactualizar.Name = "BTNactualizar"
        Me.BTNactualizar.Size = New System.Drawing.Size(82, 23)
        Me.BTNactualizar.TabIndex = 8
        Me.BTNactualizar.Text = "Actualizar"
        Me.BTNactualizar.UseVisualStyleBackColor = False
        '
        'txtcedula
        '
        Me.txtcedula.Location = New System.Drawing.Point(178, 28)
        Me.txtcedula.Name = "txtcedula"
        Me.txtcedula.Size = New System.Drawing.Size(124, 20)
        Me.txtcedula.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(175, 10)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 15)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Cedula"
        '
        'Txtpeso
        '
        Me.Txtpeso.Location = New System.Drawing.Point(531, 28)
        Me.Txtpeso.Name = "Txtpeso"
        Me.Txtpeso.Size = New System.Drawing.Size(124, 20)
        Me.Txtpeso.TabIndex = 7
        '
        'TXTaltura
        '
        Me.TXTaltura.Location = New System.Drawing.Point(348, 28)
        Me.TXTaltura.Name = "TXTaltura"
        Me.TXTaltura.Size = New System.Drawing.Size(124, 20)
        Me.TXTaltura.TabIndex = 6
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Proyecto._1Medico.My.Resources.Resources.doctor_medical_mask_avatar_care_hospital_icon_141626
        Me.PictureBox1.Location = New System.Drawing.Point(703, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(97, 90)
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'TXTtiposangre
        '
        Me.TXTtiposangre.Location = New System.Drawing.Point(21, 75)
        Me.TXTtiposangre.Name = "TXTtiposangre"
        Me.TXTtiposangre.Size = New System.Drawing.Size(57, 20)
        Me.TXTtiposangre.TabIndex = 20
        '
        'TXTMedicamentosAler
        '
        Me.TXTMedicamentosAler.Location = New System.Drawing.Point(154, 85)
        Me.TXTMedicamentosAler.Name = "TXTMedicamentosAler"
        Me.TXTMedicamentosAler.Size = New System.Drawing.Size(318, 20)
        Me.TXTMedicamentosAler.TabIndex = 21
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 15)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Tipo Sangre"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(233, 57)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(164, 15)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Medicamentos Alergicos"
        '
        'FRM_Enfermeria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 519)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "FRM_Enfermeria"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Enfermeria"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Txtpeso As TextBox
    Friend WithEvents TXTaltura As TextBox
    Friend WithEvents BTNactualizar As Button
    Friend WithEvents txtcedula As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtSintomas As RichTextBox
    Friend WithEvents Btnregresar As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents BtnMostrar As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ID As Label
    Friend WithEvents txtId As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TXTMedicamentosAler As TextBox
    Friend WithEvents TXTtiposangre As TextBox
End Class
