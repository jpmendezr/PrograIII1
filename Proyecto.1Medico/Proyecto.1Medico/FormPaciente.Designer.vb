<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPaciente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPaciente))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.menu = New System.Windows.Forms.ToolStripMenuItem()
        Me.TexCedula = New System.Windows.Forms.TextBox()
        Me.TextNombre = New System.Windows.Forms.TextBox()
        Me.TexApellidos = New System.Windows.Forms.TextBox()
        Me.TexPeso = New System.Windows.Forms.TextBox()
        Me.TextAltura = New System.Windows.Forms.TextBox()
        Me.TextTipoSangre = New System.Windows.Forms.TextBox()
        Me.TextPadecimientos = New System.Windows.Forms.TextBox()
        Me.TextEdad = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextMedicamentosAlergicos = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.BtnElimino = New System.Windows.Forms.Button()
        Me.BtnActualizo = New System.Windows.Forms.Button()
        Me.BtnRegistro = New System.Windows.Forms.Button()
        Me.MostrarDatosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.TextMedicamentosAlergicos)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.TextEdad)
        Me.Panel1.Controls.Add(Me.TextPadecimientos)
        Me.Panel1.Controls.Add(Me.TextTipoSangre)
        Me.Panel1.Controls.Add(Me.TextAltura)
        Me.Panel1.Controls.Add(Me.TexPeso)
        Me.Panel1.Controls.Add(Me.TexApellidos)
        Me.Panel1.Controls.Add(Me.TextNombre)
        Me.Panel1.Controls.Add(Me.TexCedula)
        Me.Panel1.Location = New System.Drawing.Point(12, 50)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(421, 267)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.TextBox4)
        Me.Panel2.Controls.Add(Me.TextBox3)
        Me.Panel2.Controls.Add(Me.TextBox2)
        Me.Panel2.Controls.Add(Me.TextBox1)
        Me.Panel2.Location = New System.Drawing.Point(439, 50)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(428, 267)
        Me.Panel2.TabIndex = 1
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menu})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(879, 24)
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
        'TexCedula
        '
        Me.TexCedula.Location = New System.Drawing.Point(3, 43)
        Me.TexCedula.Name = "TexCedula"
        Me.TexCedula.Size = New System.Drawing.Size(158, 20)
        Me.TexCedula.TabIndex = 1
        '
        'TextNombre
        '
        Me.TextNombre.Location = New System.Drawing.Point(3, 86)
        Me.TextNombre.Name = "TextNombre"
        Me.TextNombre.Size = New System.Drawing.Size(158, 20)
        Me.TextNombre.TabIndex = 2
        '
        'TexApellidos
        '
        Me.TexApellidos.Location = New System.Drawing.Point(3, 126)
        Me.TexApellidos.Name = "TexApellidos"
        Me.TexApellidos.Size = New System.Drawing.Size(158, 20)
        Me.TexApellidos.TabIndex = 3
        '
        'TexPeso
        '
        Me.TexPeso.Location = New System.Drawing.Point(3, 166)
        Me.TexPeso.Name = "TexPeso"
        Me.TexPeso.Size = New System.Drawing.Size(92, 20)
        Me.TexPeso.TabIndex = 4
        '
        'TextAltura
        '
        Me.TextAltura.Location = New System.Drawing.Point(291, 28)
        Me.TextAltura.Name = "TextAltura"
        Me.TextAltura.Size = New System.Drawing.Size(95, 20)
        Me.TextAltura.TabIndex = 5
        '
        'TextTipoSangre
        '
        Me.TextTipoSangre.Location = New System.Drawing.Point(256, 150)
        Me.TextTipoSangre.Name = "TextTipoSangre"
        Me.TextTipoSangre.Size = New System.Drawing.Size(158, 20)
        Me.TextTipoSangre.TabIndex = 6
        '
        'TextPadecimientos
        '
        Me.TextPadecimientos.Location = New System.Drawing.Point(256, 86)
        Me.TextPadecimientos.Name = "TextPadecimientos"
        Me.TextPadecimientos.Size = New System.Drawing.Size(158, 20)
        Me.TextPadecimientos.TabIndex = 7
        '
        'TextEdad
        '
        Me.TextEdad.Location = New System.Drawing.Point(3, 213)
        Me.TextEdad.Name = "TextEdad"
        Me.TextEdad.Size = New System.Drawing.Size(92, 20)
        Me.TextEdad.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Cedula"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Nombre" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Apellidos"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(31, 150)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Peso"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(31, 197)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Edad"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(328, 12)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Altura"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(288, 61)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(115, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Enfermedades Padece"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(306, 126)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Tipo de Sangre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(113, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Informacion Paciente"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Fuchsia
        Me.Label10.Location = New System.Drawing.Point(640, 34)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(103, 13)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Informacion Familiar "
        '
        'TextMedicamentosAlergicos
        '
        Me.TextMedicamentosAlergicos.Location = New System.Drawing.Point(256, 213)
        Me.TextMedicamentosAlergicos.Name = "TextMedicamentosAlergicos"
        Me.TextMedicamentosAlergicos.Size = New System.Drawing.Size(158, 20)
        Me.TextMedicamentosAlergicos.TabIndex = 18
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(281, 188)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(122, 13)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "Medicamentos Alérgicos"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(-2, 54)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(132, 20)
        Me.TextBox1.TabIndex = 0
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(-2, 110)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(132, 20)
        Me.TextBox2.TabIndex = 1
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(-2, 181)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(132, 20)
        Me.TextBox3.TabIndex = 2
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(289, 43)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(132, 20)
        Me.TextBox4.TabIndex = 3
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(3, 27)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(99, 13)
        Me.Label12.TabIndex = 5
        Me.Label12.Text = "Nombre del Familiar"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(3, 89)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(87, 13)
        Me.Label13.TabIndex = 6
        Me.Label13.Text = "Relación Familiar"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(17, 153)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(49, 13)
        Me.Label14.TabIndex = 7
        Me.Label14.Text = "Telefono"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(331, 12)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(52, 13)
        Me.Label15.TabIndex = 8
        Me.Label15.Text = "Dirección"
        '
        'BtnElimino
        '
        Me.BtnElimino.BackColor = System.Drawing.Color.Aqua
        Me.BtnElimino.Image = Global.Proyecto._1Medico.My.Resources.Resources.eliminar
        Me.BtnElimino.Location = New System.Drawing.Point(730, 323)
        Me.BtnElimino.Name = "BtnElimino"
        Me.BtnElimino.Size = New System.Drawing.Size(120, 23)
        Me.BtnElimino.TabIndex = 7
        Me.BtnElimino.UseVisualStyleBackColor = False
        '
        'BtnActualizo
        '
        Me.BtnActualizo.BackColor = System.Drawing.Color.Aqua
        Me.BtnActualizo.Image = Global.Proyecto._1Medico.My.Resources.Resources.update
        Me.BtnActualizo.Location = New System.Drawing.Point(395, 323)
        Me.BtnActualizo.Name = "BtnActualizo"
        Me.BtnActualizo.Size = New System.Drawing.Size(112, 23)
        Me.BtnActualizo.TabIndex = 6
        Me.BtnActualizo.UseVisualStyleBackColor = False
        '
        'BtnRegistro
        '
        Me.BtnRegistro.BackColor = System.Drawing.Color.Aqua
        Me.BtnRegistro.Image = CType(resources.GetObject("BtnRegistro.Image"), System.Drawing.Image)
        Me.BtnRegistro.Location = New System.Drawing.Point(17, 323)
        Me.BtnRegistro.Name = "BtnRegistro"
        Me.BtnRegistro.Size = New System.Drawing.Size(108, 23)
        Me.BtnRegistro.TabIndex = 3
        Me.BtnRegistro.UseVisualStyleBackColor = False
        '
        'MostrarDatosToolStripMenuItem
        '
        Me.MostrarDatosToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.MostrarDatosToolStripMenuItem.Image = CType(resources.GetObject("MostrarDatosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.MostrarDatosToolStripMenuItem.Name = "MostrarDatosToolStripMenuItem"
        Me.MostrarDatosToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.MostrarDatosToolStripMenuItem.Text = "Buscador "
        '
        'FormPaciente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(879, 358)
        Me.Controls.Add(Me.BtnElimino)
        Me.Controls.Add(Me.BtnActualizo)
        Me.Controls.Add(Me.Label10)
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
    Friend WithEvents TextEdad As TextBox
    Friend WithEvents TextPadecimientos As TextBox
    Friend WithEvents TextTipoSangre As TextBox
    Friend WithEvents TextAltura As TextBox
    Friend WithEvents TexPeso As TextBox
    Friend WithEvents TexApellidos As TextBox
    Friend WithEvents TextNombre As TextBox
    Friend WithEvents TexCedula As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents TextMedicamentosAlergicos As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents BtnActualizo As Button
    Friend WithEvents BtnElimino As Button
End Class
