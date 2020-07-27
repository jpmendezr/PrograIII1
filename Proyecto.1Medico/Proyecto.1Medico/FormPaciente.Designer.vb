<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPaciente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPaciente))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TexAño = New System.Windows.Forms.TextBox()
        Me.TexMes = New System.Windows.Forms.TextBox()
        Me.ComboBoxSexo = New System.Windows.Forms.ComboBox()
        Me.TexDia = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextCel = New System.Windows.Forms.TextBox()
        Me.TexCorreoElectronico = New System.Windows.Forms.TextBox()
        Me.TexApellidos = New System.Windows.Forms.TextBox()
        Me.TextNombre = New System.Windows.Forms.TextBox()
        Me.TexCedula = New System.Windows.Forms.TextBox()
        Me.Sexo = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtTelefonoFamiliar = New System.Windows.Forms.TextBox()
        Me.txtrelacion = New System.Windows.Forms.TextBox()
        Me.txtFamiliar = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnElimino = New System.Windows.Forms.Button()
        Me.BtnRegistro = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BtnLupa = New System.Windows.Forms.Button()
        Me.BtnMostrar = New System.Windows.Forms.Button()
        Me.ACT = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.TexAño)
        Me.Panel1.Controls.Add(Me.TexMes)
        Me.Panel1.Controls.Add(Me.ComboBoxSexo)
        Me.Panel1.Controls.Add(Me.TexDia)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.TextCel)
        Me.Panel1.Controls.Add(Me.TexCorreoElectronico)
        Me.Panel1.Controls.Add(Me.TexApellidos)
        Me.Panel1.Controls.Add(Me.TextNombre)
        Me.Panel1.Controls.Add(Me.TexCedula)
        Me.Panel1.Location = New System.Drawing.Point(12, 50)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(793, 166)
        Me.Panel1.TabIndex = 0
        '
        'TexAño
        '
        Me.TexAño.Location = New System.Drawing.Point(112, 110)
        Me.TexAño.Name = "TexAño"
        Me.TexAño.Size = New System.Drawing.Size(34, 20)
        Me.TexAño.TabIndex = 35
        '
        'TexMes
        '
        Me.TexMes.Location = New System.Drawing.Point(55, 110)
        Me.TexMes.Name = "TexMes"
        Me.TexMes.Size = New System.Drawing.Size(34, 20)
        Me.TexMes.TabIndex = 34
        '
        'ComboBoxSexo
        '
        Me.ComboBoxSexo.FormattingEnabled = True
        Me.ComboBoxSexo.Items.AddRange(New Object() {"M", "F"})
        Me.ComboBoxSexo.Location = New System.Drawing.Point(636, 39)
        Me.ComboBoxSexo.Name = "ComboBoxSexo"
        Me.ComboBoxSexo.Size = New System.Drawing.Size(79, 21)
        Me.ComboBoxSexo.TabIndex = 11
        '
        'TexDia
        '
        Me.TexDia.Location = New System.Drawing.Point(10, 110)
        Me.TexDia.Name = "TexDia"
        Me.TexDia.Size = New System.Drawing.Size(28, 20)
        Me.TexDia.TabIndex = 24
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(651, 21)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(39, 15)
        Me.Label17.TabIndex = 23
        Me.Label17.Text = "Sexo"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(589, 84)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(126, 15)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Correo Electrónico" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(321, 84)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 15)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Teléfono" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(23, 84)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(123, 15)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Fecha Nacimiento"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(435, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 15)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Apellidos"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(217, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 15)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Nombre" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(37, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 15)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Cedula"
        '
        'TextCel
        '
        Me.TextCel.Location = New System.Drawing.Point(285, 110)
        Me.TextCel.Name = "TextCel"
        Me.TextCel.Size = New System.Drawing.Size(146, 20)
        Me.TextCel.TabIndex = 7
        '
        'TexCorreoElectronico
        '
        Me.TexCorreoElectronico.Location = New System.Drawing.Point(535, 110)
        Me.TexCorreoElectronico.Name = "TexCorreoElectronico"
        Me.TexCorreoElectronico.Size = New System.Drawing.Size(239, 20)
        Me.TexCorreoElectronico.TabIndex = 6
        '
        'TexApellidos
        '
        Me.TexApellidos.Location = New System.Drawing.Point(385, 40)
        Me.TexApellidos.Name = "TexApellidos"
        Me.TexApellidos.Size = New System.Drawing.Size(202, 20)
        Me.TexApellidos.TabIndex = 3
        '
        'TextNombre
        '
        Me.TextNombre.Location = New System.Drawing.Point(151, 39)
        Me.TextNombre.Name = "TextNombre"
        Me.TextNombre.Size = New System.Drawing.Size(202, 20)
        Me.TextNombre.TabIndex = 2
        '
        'TexCedula
        '
        Me.TexCedula.Location = New System.Drawing.Point(6, 39)
        Me.TexCedula.Name = "TexCedula"
        Me.TexCedula.Size = New System.Drawing.Size(126, 20)
        Me.TexCedula.TabIndex = 1
        '
        'Sexo
        '
        Me.Sexo.Location = New System.Drawing.Point(615, 371)
        Me.Sexo.Name = "Sexo"
        Me.Sexo.Size = New System.Drawing.Size(73, 20)
        Me.Sexo.TabIndex = 22
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.txtDireccion)
        Me.Panel2.Controls.Add(Me.txtTelefonoFamiliar)
        Me.Panel2.Controls.Add(Me.txtrelacion)
        Me.Panel2.Controls.Add(Me.txtFamiliar)
        Me.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(12, 222)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(793, 121)
        Me.Panel2.TabIndex = 1
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(671, 41)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(68, 15)
        Me.Label15.TabIndex = 8
        Me.Label15.Text = "Dirección"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(435, 41)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(63, 15)
        Me.Label14.TabIndex = 7
        Me.Label14.Text = "Telefono"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(282, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(255, 20)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Informacion Contacto Familiar "
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(272, 41)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(121, 15)
        Me.Label13.TabIndex = 6
        Me.Label13.Text = "Relación Familiar"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(7, 41)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(139, 15)
        Me.Label12.TabIndex = 5
        Me.Label12.Text = "Nombre del Familiar"
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(553, 68)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(233, 21)
        Me.txtDireccion.TabIndex = 3
        '
        'txtTelefonoFamiliar
        '
        Me.txtTelefonoFamiliar.Location = New System.Drawing.Point(411, 68)
        Me.txtTelefonoFamiliar.Name = "txtTelefonoFamiliar"
        Me.txtTelefonoFamiliar.Size = New System.Drawing.Size(126, 21)
        Me.txtTelefonoFamiliar.TabIndex = 2
        '
        'txtrelacion
        '
        Me.txtrelacion.Location = New System.Drawing.Point(258, 65)
        Me.txtrelacion.Name = "txtrelacion"
        Me.txtrelacion.Size = New System.Drawing.Size(137, 21)
        Me.txtrelacion.TabIndex = 1
        '
        'txtFamiliar
        '
        Me.txtFamiliar.Location = New System.Drawing.Point(-2, 65)
        Me.txtFamiliar.Name = "txtFamiliar"
        Me.txtFamiliar.Size = New System.Drawing.Size(254, 21)
        Me.txtFamiliar.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(814, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(295, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(179, 40)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Informacion Personal" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'BtnElimino
        '
        Me.BtnElimino.BackColor = System.Drawing.Color.Aqua
        Me.BtnElimino.Image = Global.Proyecto._1Medico.My.Resources.Resources.eliminar
        Me.BtnElimino.Location = New System.Drawing.Point(657, 492)
        Me.BtnElimino.Name = "BtnElimino"
        Me.BtnElimino.Size = New System.Drawing.Size(120, 23)
        Me.BtnElimino.TabIndex = 7
        Me.BtnElimino.UseVisualStyleBackColor = False
        '
        'BtnRegistro
        '
        Me.BtnRegistro.BackColor = System.Drawing.Color.Aqua
        Me.BtnRegistro.Image = CType(resources.GetObject("BtnRegistro.Image"), System.Drawing.Image)
        Me.BtnRegistro.Location = New System.Drawing.Point(12, 492)
        Me.BtnRegistro.Name = "BtnRegistro"
        Me.BtnRegistro.Size = New System.Drawing.Size(108, 23)
        Me.BtnRegistro.TabIndex = 3
        Me.BtnRegistro.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 349)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(788, 137)
        Me.DataGridView1.TabIndex = 8
        '
        'BtnLupa
        '
        Me.BtnLupa.BackColor = System.Drawing.Color.Aqua
        Me.BtnLupa.Image = Global.Proyecto._1Medico.My.Resources.Resources.lupa
        Me.BtnLupa.Location = New System.Drawing.Point(517, 492)
        Me.BtnLupa.Name = "BtnLupa"
        Me.BtnLupa.Size = New System.Drawing.Size(97, 23)
        Me.BtnLupa.TabIndex = 9
        Me.BtnLupa.UseVisualStyleBackColor = False
        '
        'BtnMostrar
        '
        Me.BtnMostrar.BackColor = System.Drawing.Color.Aqua
        Me.BtnMostrar.Location = New System.Drawing.Point(387, 492)
        Me.BtnMostrar.Name = "BtnMostrar"
        Me.BtnMostrar.Size = New System.Drawing.Size(98, 23)
        Me.BtnMostrar.TabIndex = 10
        Me.BtnMostrar.Text = "Mostrar"
        Me.BtnMostrar.UseVisualStyleBackColor = False
        '
        'ACT
        '
        Me.ACT.BackColor = System.Drawing.Color.Aqua
        Me.ACT.Location = New System.Drawing.Point(234, 492)
        Me.ACT.Name = "ACT"
        Me.ACT.Size = New System.Drawing.Size(75, 23)
        Me.ACT.TabIndex = 23
        Me.ACT.Text = "Actualizar"
        Me.ACT.UseVisualStyleBackColor = False
        '
        'FormPaciente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(814, 516)
        Me.Controls.Add(Me.ACT)
        Me.Controls.Add(Me.BtnMostrar)
        Me.Controls.Add(Me.BtnLupa)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.BtnElimino)
        Me.Controls.Add(Me.Sexo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BtnRegistro)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FormPaciente"
        Me.Text = "FormPaciente"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents BtnRegistro As Button
    Friend WithEvents TextCel As TextBox
    Friend WithEvents TexCorreoElectronico As TextBox
    Friend WithEvents TexApellidos As TextBox
    Friend WithEvents TextNombre As TextBox
    Friend WithEvents TexCedula As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents txtTelefonoFamiliar As TextBox
    Friend WithEvents txtrelacion As TextBox
    Friend WithEvents txtFamiliar As TextBox
    Friend WithEvents BtnElimino As Button
    Friend WithEvents Sexo As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents TexDia As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BtnLupa As Button
    Friend WithEvents BtnMostrar As Button
    Friend WithEvents ComboBoxSexo As ComboBox
    Friend WithEvents TexAño As TextBox
    Friend WithEvents TexMes As TextBox
    Friend WithEvents ACT As Button
End Class
