<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUsuarios
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBusCedula = New System.Windows.Forms.TextBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.Nombre = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtapell = New System.Windows.Forms.TextBox()
        Me.txtdia = New System.Windows.Forms.TextBox()
        Me.txtmes = New System.Windows.Forms.TextBox()
        Me.txtano = New System.Windows.Forms.TextBox()
        Me.txttel = New System.Windows.Forms.TextBox()
        Me.txtCorr = New System.Windows.Forms.TextBox()
        Me.CBSexo = New System.Windows.Forms.ComboBox()
        Me.txtCedula = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CBdepa = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtContra = New System.Windows.Forms.TextBox()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnMostar = New System.Windows.Forms.Button()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.BtnRegresar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(6, 254)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(790, 152)
        Me.DataGridView1.TabIndex = 0
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.Cyan
        Me.btnBuscar.Location = New System.Drawing.Point(182, 415)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 1
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 108)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Buscar Usuario o Eliminar"
        '
        'txtBusCedula
        '
        Me.txtBusCedula.Location = New System.Drawing.Point(18, 134)
        Me.txtBusCedula.Name = "txtBusCedula"
        Me.txtBusCedula.Size = New System.Drawing.Size(76, 20)
        Me.txtBusCedula.TabIndex = 3
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.Cyan
        Me.btnAgregar.Location = New System.Drawing.Point(597, 415)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregar.TabIndex = 4
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'Nombre
        '
        Me.Nombre.AutoSize = True
        Me.Nombre.Location = New System.Drawing.Point(700, 9)
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Size = New System.Drawing.Size(44, 13)
        Me.Nombre.TabIndex = 5
        Me.Nombre.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(700, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Apellidos"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Fecha Nacimiento"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(718, 176)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Sexo"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(700, 137)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Telefono"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(684, 89)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(94, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Correo Electronico"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(351, 49)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 13)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Departamento"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(613, 25)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(190, 20)
        Me.txtNombre.TabIndex = 12
        '
        'txtapell
        '
        Me.txtapell.Location = New System.Drawing.Point(612, 66)
        Me.txtapell.Name = "txtapell"
        Me.txtapell.Size = New System.Drawing.Size(195, 20)
        Me.txtapell.TabIndex = 13
        '
        'txtdia
        '
        Me.txtdia.Location = New System.Drawing.Point(18, 34)
        Me.txtdia.Name = "txtdia"
        Me.txtdia.Size = New System.Drawing.Size(19, 20)
        Me.txtdia.TabIndex = 15
        '
        'txtmes
        '
        Me.txtmes.Location = New System.Drawing.Point(55, 34)
        Me.txtmes.Name = "txtmes"
        Me.txtmes.Size = New System.Drawing.Size(25, 20)
        Me.txtmes.TabIndex = 16
        '
        'txtano
        '
        Me.txtano.Location = New System.Drawing.Point(99, 34)
        Me.txtano.Name = "txtano"
        Me.txtano.Size = New System.Drawing.Size(49, 20)
        Me.txtano.TabIndex = 17
        '
        'txttel
        '
        Me.txttel.Location = New System.Drawing.Point(678, 153)
        Me.txttel.Name = "txttel"
        Me.txttel.Size = New System.Drawing.Size(100, 20)
        Me.txttel.TabIndex = 18
        '
        'txtCorr
        '
        Me.txtCorr.Location = New System.Drawing.Point(618, 105)
        Me.txtCorr.Name = "txtCorr"
        Me.txtCorr.Size = New System.Drawing.Size(190, 20)
        Me.txtCorr.TabIndex = 19
        '
        'CBSexo
        '
        Me.CBSexo.FormattingEnabled = True
        Me.CBSexo.Items.AddRange(New Object() {"F", "M"})
        Me.CBSexo.Location = New System.Drawing.Point(712, 192)
        Me.CBSexo.Name = "CBSexo"
        Me.CBSexo.Size = New System.Drawing.Size(53, 21)
        Me.CBSexo.TabIndex = 22
        '
        'txtCedula
        '
        Me.txtCedula.Location = New System.Drawing.Point(291, 26)
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.Size = New System.Drawing.Size(209, 20)
        Me.txtCedula.TabIndex = 24
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(357, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Cedula"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(18, 65)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(113, 13)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "30    /    12    /    2020"
        '
        'CBdepa
        '
        Me.CBdepa.FormattingEnabled = True
        Me.CBdepa.Items.AddRange(New Object() {"Recepción", "Enfermería", "Médico"})
        Me.CBdepa.Location = New System.Drawing.Point(322, 66)
        Me.CBdepa.Name = "CBdepa"
        Me.CBdepa.Size = New System.Drawing.Size(121, 21)
        Me.CBdepa.TabIndex = 27
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(351, 105)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(61, 13)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "Contraseña"
        '
        'txtContra
        '
        Me.txtContra.Location = New System.Drawing.Point(325, 121)
        Me.txtContra.Name = "txtContra"
        Me.txtContra.Size = New System.Drawing.Size(100, 20)
        Me.txtContra.TabIndex = 29
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.Cyan
        Me.btnEliminar.Location = New System.Drawing.Point(316, 415)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar.TabIndex = 30
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'btnMostar
        '
        Me.btnMostar.BackColor = System.Drawing.Color.Cyan
        Me.btnMostar.Location = New System.Drawing.Point(457, 415)
        Me.btnMostar.Name = "btnMostar"
        Me.btnMostar.Size = New System.Drawing.Size(75, 23)
        Me.btnMostar.TabIndex = 31
        Me.btnMostar.Text = "Mostrar"
        Me.btnMostar.UseVisualStyleBackColor = False
        '
        'btnActualizar
        '
        Me.btnActualizar.BackColor = System.Drawing.Color.Cyan
        Me.btnActualizar.Location = New System.Drawing.Point(721, 415)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(75, 23)
        Me.btnActualizar.TabIndex = 32
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = False
        '
        'BtnRegresar
        '
        Me.BtnRegresar.BackColor = System.Drawing.Color.Cyan
        Me.BtnRegresar.Location = New System.Drawing.Point(6, 415)
        Me.BtnRegresar.Name = "BtnRegresar"
        Me.BtnRegresar.Size = New System.Drawing.Size(102, 23)
        Me.BtnRegresar.TabIndex = 33
        Me.BtnRegresar.Text = "Regresar"
        Me.BtnRegresar.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.txtano)
        Me.Panel1.Controls.Add(Me.txtmes)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.txttel)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.txtContra)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.txtdia)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtCorr)
        Me.Panel1.Controls.Add(Me.CBdepa)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtCedula)
        Me.Panel1.Controls.Add(Me.txtapell)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.CBSexo)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtNombre)
        Me.Panel1.Controls.Add(Me.Nombre)
        Me.Panel1.Controls.Add(Me.txtBusCedula)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(-8, -2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(810, 250)
        Me.Panel1.TabIndex = 34
        '
        'FormUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BtnRegresar)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.btnMostar)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Name = "FormUsuarios"
        Me.Text = "FormUsuarios"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnBuscar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtBusCedula As TextBox
    Friend WithEvents btnAgregar As Button
    Friend WithEvents Nombre As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtapell As TextBox
    Friend WithEvents txtdia As TextBox
    Friend WithEvents txtmes As TextBox
    Friend WithEvents txtano As TextBox
    Friend WithEvents txttel As TextBox
    Friend WithEvents txtCorr As TextBox
    Friend WithEvents CBSexo As ComboBox
    Friend WithEvents txtCedula As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents CBdepa As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtContra As TextBox
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnMostar As Button
    Friend WithEvents btnActualizar As Button
    Friend WithEvents BtnRegresar As Button
    Friend WithEvents Panel1 As Panel
End Class
