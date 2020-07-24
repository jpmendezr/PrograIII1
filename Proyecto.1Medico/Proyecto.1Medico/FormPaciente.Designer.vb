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
        Me.TexFecha = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Sexo = New System.Windows.Forms.TextBox()
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtTelefonoFamiliar = New System.Windows.Forms.TextBox()
        Me.txtrelacion = New System.Windows.Forms.TextBox()
        Me.txtFamiliar = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.menu = New System.Windows.Forms.ToolStripMenuItem()
        Me.MostrarDatosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.BtnElimino = New System.Windows.Forms.Button()
        Me.BtnActualizo = New System.Windows.Forms.Button()
        Me.BtnRegistro = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TXTMedicamento = New System.Windows.Forms.TextBox()
        Me.TXTsangre = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.TXTsangre)
        Me.Panel1.Controls.Add(Me.TXTMedicamento)
        Me.Panel1.Controls.Add(Me.Label18)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.TexFecha)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.Sexo)
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
        Me.Panel1.Size = New System.Drawing.Size(961, 267)
        Me.Panel1.TabIndex = 0
        '
        'TexFecha
        '
        Me.TexFecha.Location = New System.Drawing.Point(833, 28)
        Me.TexFecha.Name = "TexFecha"
        Me.TexFecha.Size = New System.Drawing.Size(115, 20)
        Me.TexFecha.TabIndex = 24
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(-2, 160)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(31, 13)
        Me.Label17.TabIndex = 23
        Me.Label17.Text = "Sexo"
        '
        'Sexo
        '
        Me.Sexo.Location = New System.Drawing.Point(-2, 176)
        Me.Sexo.Name = "Sexo"
        Me.Sexo.Size = New System.Drawing.Size(73, 20)
        Me.Sexo.TabIndex = 22
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(820, 110)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(94, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Correo Electrónico" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(865, 61)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Teléfono" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(843, 12)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(93, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Fecha Nacimiento"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(-2, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Apellidos"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(0, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Nombre" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Cedula"
        '
        'TextCel
        '
        Me.TextCel.Location = New System.Drawing.Point(823, 77)
        Me.TextCel.Name = "TextCel"
        Me.TextCel.Size = New System.Drawing.Size(125, 20)
        Me.TextCel.TabIndex = 7
        '
        'TexCorreoElectronico
        '
        Me.TexCorreoElectronico.Location = New System.Drawing.Point(756, 138)
        Me.TexCorreoElectronico.Name = "TexCorreoElectronico"
        Me.TexCorreoElectronico.Size = New System.Drawing.Size(192, 20)
        Me.TexCorreoElectronico.TabIndex = 6
        '
        'TexApellidos
        '
        Me.TexApellidos.Location = New System.Drawing.Point(-2, 126)
        Me.TexApellidos.Name = "TexApellidos"
        Me.TexApellidos.Size = New System.Drawing.Size(202, 20)
        Me.TexApellidos.TabIndex = 3
        '
        'TextNombre
        '
        Me.TextNombre.Location = New System.Drawing.Point(-2, 77)
        Me.TextNombre.Name = "TextNombre"
        Me.TextNombre.Size = New System.Drawing.Size(202, 20)
        Me.TextNombre.TabIndex = 2
        '
        'TexCedula
        '
        Me.TexCedula.Location = New System.Drawing.Point(-2, 28)
        Me.TexCedula.Name = "TexCedula"
        Me.TexCedula.Size = New System.Drawing.Size(113, 20)
        Me.TexCedula.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveBorder
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
        Me.Panel2.Location = New System.Drawing.Point(12, 323)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(950, 267)
        Me.Panel2.TabIndex = 1
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(419, 201)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(52, 13)
        Me.Label15.TabIndex = 8
        Me.Label15.Text = "Dirección"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(414, 151)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(49, 13)
        Me.Label14.TabIndex = 7
        Me.Label14.Text = "Telefono"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(394, 87)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(87, 13)
        Me.Label13.TabIndex = 6
        Me.Label13.Text = "Relación Familiar"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(394, 37)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(99, 13)
        Me.Label12.TabIndex = 5
        Me.Label12.Text = "Nombre del Familiar"
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(296, 217)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(329, 20)
        Me.txtDireccion.TabIndex = 3
        '
        'txtTelefonoFamiliar
        '
        Me.txtTelefonoFamiliar.Location = New System.Drawing.Point(389, 167)
        Me.txtTelefonoFamiliar.Name = "txtTelefonoFamiliar"
        Me.txtTelefonoFamiliar.Size = New System.Drawing.Size(116, 20)
        Me.txtTelefonoFamiliar.TabIndex = 2
        '
        'txtrelacion
        '
        Me.txtrelacion.Location = New System.Drawing.Point(356, 112)
        Me.txtrelacion.Name = "txtrelacion"
        Me.txtrelacion.Size = New System.Drawing.Size(173, 20)
        Me.txtrelacion.TabIndex = 1
        '
        'txtFamiliar
        '
        Me.txtFamiliar.Location = New System.Drawing.Point(306, 53)
        Me.txtFamiliar.Name = "txtFamiliar"
        Me.txtFamiliar.Size = New System.Drawing.Size(295, 20)
        Me.txtFamiliar.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menu})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(962, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'menu
        '
        Me.menu.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.menu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MostrarDatosToolStripMenuItem})
        Me.menu.Name = "menu"
        Me.menu.Size = New System.Drawing.Size(67, 20)
        Me.menu.Text = "Registros"
        '
        'MostrarDatosToolStripMenuItem
        '
        Me.MostrarDatosToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.MostrarDatosToolStripMenuItem.Image = CType(resources.GetObject("MostrarDatosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.MostrarDatosToolStripMenuItem.Name = "MostrarDatosToolStripMenuItem"
        Me.MostrarDatosToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.MostrarDatosToolStripMenuItem.Text = "Buscador "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(88, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 26)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Informacion Personal" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Fuchsia
        Me.Label10.Location = New System.Drawing.Point(370, 11)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(149, 13)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Informacion Contacto Familiar "
        '
        'BtnElimino
        '
        Me.BtnElimino.BackColor = System.Drawing.Color.Aqua
        Me.BtnElimino.Image = Global.Proyecto._1Medico.My.Resources.Resources.eliminar
        Me.BtnElimino.Location = New System.Drawing.Point(731, 596)
        Me.BtnElimino.Name = "BtnElimino"
        Me.BtnElimino.Size = New System.Drawing.Size(120, 23)
        Me.BtnElimino.TabIndex = 7
        Me.BtnElimino.UseVisualStyleBackColor = False
        '
        'BtnActualizo
        '
        Me.BtnActualizo.BackColor = System.Drawing.Color.Aqua
        Me.BtnActualizo.Image = Global.Proyecto._1Medico.My.Resources.Resources.update
        Me.BtnActualizo.Location = New System.Drawing.Point(365, 596)
        Me.BtnActualizo.Name = "BtnActualizo"
        Me.BtnActualizo.Size = New System.Drawing.Size(112, 23)
        Me.BtnActualizo.TabIndex = 6
        Me.BtnActualizo.UseVisualStyleBackColor = False
        '
        'BtnRegistro
        '
        Me.BtnRegistro.BackColor = System.Drawing.Color.Aqua
        Me.BtnRegistro.Image = CType(resources.GetObject("BtnRegistro.Image"), System.Drawing.Image)
        Me.BtnRegistro.Location = New System.Drawing.Point(20, 596)
        Me.BtnRegistro.Name = "BtnRegistro"
        Me.BtnRegistro.Size = New System.Drawing.Size(108, 23)
        Me.BtnRegistro.TabIndex = 3
        Me.BtnRegistro.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(0, 209)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(65, 13)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "Tipo Sangre"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(820, 161)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(112, 13)
        Me.Label18.TabIndex = 29
        Me.Label18.Text = "Medicamento Alergico"
        '
        'TXTMedicamento
        '
        Me.TXTMedicamento.Location = New System.Drawing.Point(756, 180)
        Me.TXTMedicamento.Name = "TXTMedicamento"
        Me.TXTMedicamento.Size = New System.Drawing.Size(192, 20)
        Me.TXTMedicamento.TabIndex = 31
        '
        'TXTsangre
        '
        Me.TXTsangre.Location = New System.Drawing.Point(1, 225)
        Me.TXTsangre.Name = "TXTsangre"
        Me.TXTsangre.Size = New System.Drawing.Size(56, 20)
        Me.TXTsangre.TabIndex = 33
        '
        'FormPaciente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(962, 623)
        Me.Controls.Add(Me.BtnElimino)
        Me.Controls.Add(Me.BtnActualizo)
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
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents menu As ToolStripMenuItem
    Friend WithEvents MostrarDatosToolStripMenuItem As ToolStripMenuItem
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
    Friend WithEvents BtnActualizo As Button
    Friend WithEvents BtnElimino As Button
    Friend WithEvents Sexo As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents TexFecha As TextBox
    Friend WithEvents TXTsangre As TextBox
    Friend WithEvents TXTMedicamento As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label11 As Label
End Class
