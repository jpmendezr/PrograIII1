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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.label = New System.Windows.Forms.Label()
        Me.ComboBoxDia = New System.Windows.Forms.ComboBox()
        Me.ComboBoxMes = New System.Windows.Forms.ComboBox()
        Me.ComboBoxAño = New System.Windows.Forms.ComboBox()
        Me.ComboBoxSexo = New System.Windows.Forms.ComboBox()
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
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.BtnRegrsar = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.label)
        Me.Panel1.Controls.Add(Me.ComboBoxDia)
        Me.Panel1.Controls.Add(Me.ComboBoxMes)
        Me.Panel1.Controls.Add(Me.ComboBoxAño)
        Me.Panel1.Controls.Add(Me.ComboBoxSexo)
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
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(109, 94)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(26, 13)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "Año"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(54, 94)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(27, 13)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "Mes"
        '
        'label
        '
        Me.label.AutoSize = True
        Me.label.Location = New System.Drawing.Point(0, 94)
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(23, 13)
        Me.label.TabIndex = 39
        Me.label.Text = "Dia"
        '
        'ComboBoxDia
        '
        Me.ComboBoxDia.FormattingEnabled = True
        Me.ComboBoxDia.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31"})
        Me.ComboBoxDia.Location = New System.Drawing.Point(-2, 110)
        Me.ComboBoxDia.Name = "ComboBoxDia"
        Me.ComboBoxDia.Size = New System.Drawing.Size(41, 21)
        Me.ComboBoxDia.TabIndex = 38
        Me.ComboBoxDia.Text = "dia"
        '
        'ComboBoxMes
        '
        Me.ComboBoxMes.FormattingEnabled = True
        Me.ComboBoxMes.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12"})
        Me.ComboBoxMes.Location = New System.Drawing.Point(45, 110)
        Me.ComboBoxMes.Name = "ComboBoxMes"
        Me.ComboBoxMes.Size = New System.Drawing.Size(44, 21)
        Me.ComboBoxMes.TabIndex = 37
        Me.ComboBoxMes.Text = "mes"
        '
        'ComboBoxAño
        '
        Me.ComboBoxAño.FormattingEnabled = True
        Me.ComboBoxAño.Items.AddRange(New Object() {"2020", "2019", "2018", "2017", "2016", "2015", "2014", "2013", "2012", "2011", "2010", "2009", "2008", "2007", "2006", "2005", "2004", "2003", "2002", "2001", "2000", "1999", "1998", "1997", "1996", "1995", "1994", "1993", "1992", "1991", "1990", "1989", "1988", "1987", "1986", "1985", "1984", "1983", "1982", "1981", "1980", "1979", "1978", "1977", "1976", "1975", "1974", "1973", "1972", "1971", "1970", "1969", "1968", "1967", "1966", "1965", "1964", "1963", "1962", "1961", "1960", "1959", "1958", "1957", "1956", "1955", "1954", "1953", "1952", "1951", "1949", "1948", "1947", "1946", "1945", "1944", "1943", "1942", "1941", "1940"})
        Me.ComboBoxAño.Location = New System.Drawing.Point(95, 110)
        Me.ComboBoxAño.Name = "ComboBoxAño"
        Me.ComboBoxAño.Size = New System.Drawing.Size(51, 21)
        Me.ComboBoxAño.TabIndex = 36
        Me.ComboBoxAño.Text = "año"
        '
        'ComboBoxSexo
        '
        Me.ComboBoxSexo.FormattingEnabled = True
        Me.ComboBoxSexo.Items.AddRange(New Object() {"M", "F"})
        Me.ComboBoxSexo.Location = New System.Drawing.Point(636, 38)
        Me.ComboBoxSexo.Name = "ComboBoxSexo"
        Me.ComboBoxSexo.Size = New System.Drawing.Size(79, 21)
        Me.ComboBoxSexo.TabIndex = 11
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(650, 12)
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
        Me.Label7.Location = New System.Drawing.Point(9, 74)
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
        Me.Label15.Location = New System.Drawing.Point(650, 41)
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
        Me.Label14.Text = "Teléfono"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
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
        Me.txtDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccion.Location = New System.Drawing.Point(553, 65)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(233, 21)
        Me.txtDireccion.TabIndex = 3
        '
        'txtTelefonoFamiliar
        '
        Me.txtTelefonoFamiliar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefonoFamiliar.Location = New System.Drawing.Point(411, 65)
        Me.txtTelefonoFamiliar.Name = "txtTelefonoFamiliar"
        Me.txtTelefonoFamiliar.Size = New System.Drawing.Size(126, 21)
        Me.txtTelefonoFamiliar.TabIndex = 2
        '
        'txtrelacion
        '
        Me.txtrelacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtrelacion.Location = New System.Drawing.Point(258, 65)
        Me.txtrelacion.Name = "txtrelacion"
        Me.txtrelacion.Size = New System.Drawing.Size(137, 21)
        Me.txtrelacion.TabIndex = 1
        '
        'txtFamiliar
        '
        Me.txtFamiliar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.Label3.ForeColor = System.Drawing.Color.Black
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
        Me.BtnElimino.Location = New System.Drawing.Point(567, 492)
        Me.BtnElimino.Name = "BtnElimino"
        Me.BtnElimino.Size = New System.Drawing.Size(136, 23)
        Me.BtnElimino.TabIndex = 7
        Me.BtnElimino.UseVisualStyleBackColor = False
        '
        'BtnRegistro
        '
        Me.BtnRegistro.BackColor = System.Drawing.Color.Aqua
        Me.BtnRegistro.Image = CType(resources.GetObject("BtnRegistro.Image"), System.Drawing.Image)
        Me.BtnRegistro.Location = New System.Drawing.Point(12, 492)
        Me.BtnRegistro.Name = "BtnRegistro"
        Me.BtnRegistro.Size = New System.Drawing.Size(125, 23)
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
        Me.BtnLupa.Location = New System.Drawing.Point(425, 492)
        Me.BtnLupa.Name = "BtnLupa"
        Me.BtnLupa.Size = New System.Drawing.Size(151, 23)
        Me.BtnLupa.TabIndex = 9
        Me.BtnLupa.UseVisualStyleBackColor = False
        '
        'BtnMostrar
        '
        Me.BtnMostrar.BackColor = System.Drawing.Color.Aqua
        Me.BtnMostrar.Location = New System.Drawing.Point(280, 492)
        Me.BtnMostrar.Name = "BtnMostrar"
        Me.BtnMostrar.Size = New System.Drawing.Size(148, 23)
        Me.BtnMostrar.TabIndex = 10
        Me.BtnMostrar.Text = "Mostrar"
        Me.BtnMostrar.UseVisualStyleBackColor = False
        '
        'ACT
        '
        Me.ACT.BackColor = System.Drawing.Color.Aqua
        Me.ACT.Image = Global.Proyecto._1Medico.My.Resources.Resources.update
        Me.ACT.Location = New System.Drawing.Point(136, 492)
        Me.ACT.Name = "ACT"
        Me.ACT.Size = New System.Drawing.Size(147, 23)
        Me.ACT.TabIndex = 23
        Me.ACT.UseVisualStyleBackColor = False
        '
        'BtnRegrsar
        '
        Me.BtnRegrsar.BackColor = System.Drawing.Color.Cyan
        Me.BtnRegrsar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnRegrsar.Location = New System.Drawing.Point(690, 492)
        Me.BtnRegrsar.Name = "BtnRegrsar"
        Me.BtnRegrsar.Size = New System.Drawing.Size(110, 23)
        Me.BtnRegrsar.TabIndex = 24
        Me.BtnRegrsar.Text = "Regresar"
        Me.BtnRegrsar.UseVisualStyleBackColor = False
        '
        'FormPaciente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(814, 516)
        Me.Controls.Add(Me.BtnRegrsar)
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
        Me.MaximizeBox = False
        Me.Name = "FormPaciente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pacientes"
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
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BtnLupa As Button
    Friend WithEvents BtnMostrar As Button
    Friend WithEvents ComboBoxSexo As ComboBox
    Friend WithEvents ACT As Button
    Friend WithEvents ComboBoxAño As ComboBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents ComboBoxDia As ComboBox
    Friend WithEvents ComboBoxMes As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents label As Label
    Friend WithEvents BtnRegrsar As Button
End Class
