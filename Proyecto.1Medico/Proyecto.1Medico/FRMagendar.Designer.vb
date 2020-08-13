<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRMagendar
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
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextEspecialidad = New System.Windows.Forms.TextBox()
        Me.TextNMedico = New System.Windows.Forms.TextBox()
        Me.TextCedula = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.BtnCitas = New System.Windows.Forms.Button()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.BtnRegresar = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ComboBoxMes = New System.Windows.Forms.ComboBox()
        Me.ComboBoxAño = New System.Windows.Forms.ComboBox()
        Me.ComboBoxDia = New System.Windows.Forms.ComboBox()
        Me.ComboHora = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextID = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnEliminar
        '
        Me.BtnEliminar.BackColor = System.Drawing.Color.Aqua
        Me.BtnEliminar.Location = New System.Drawing.Point(529, 415)
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
        Me.Label2.Location = New System.Drawing.Point(179, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Hora"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(305, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 15)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Especialidad"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(429, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(133, 15)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Nombre del Medico"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(630, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(136, 15)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Cedula del Paciente"
        '
        'TextEspecialidad
        '
        Me.TextEspecialidad.Location = New System.Drawing.Point(308, 53)
        Me.TextEspecialidad.Name = "TextEspecialidad"
        Me.TextEspecialidad.Size = New System.Drawing.Size(100, 20)
        Me.TextEspecialidad.TabIndex = 7
        '
        'TextNMedico
        '
        Me.TextNMedico.Location = New System.Drawing.Point(432, 53)
        Me.TextNMedico.Multiline = True
        Me.TextNMedico.Name = "TextNMedico"
        Me.TextNMedico.Size = New System.Drawing.Size(167, 20)
        Me.TextNMedico.TabIndex = 8
        '
        'TextCedula
        '
        Me.TextCedula.Location = New System.Drawing.Point(622, 53)
        Me.TextCedula.Name = "TextCedula"
        Me.TextCedula.Size = New System.Drawing.Size(155, 20)
        Me.TextCedula.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(338, 143)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(123, 15)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Citas Disponibles:"
        '
        'BtnActualizar
        '
        Me.BtnActualizar.BackColor = System.Drawing.Color.Aqua
        Me.BtnActualizar.Location = New System.Drawing.Point(362, 415)
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
        Me.BtnRegresar.Location = New System.Drawing.Point(670, 415)
        Me.BtnRegresar.Name = "BtnRegresar"
        Me.BtnRegresar.Size = New System.Drawing.Size(120, 23)
        Me.BtnRegresar.TabIndex = 25
        Me.BtnRegresar.Text = "Regresar"
        Me.BtnRegresar.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(75, 174)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(644, 210)
        Me.DataGridView1.TabIndex = 26
        '
        'ComboBoxMes
        '
        Me.ComboBoxMes.FormattingEnabled = True
        Me.ComboBoxMes.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12"})
        Me.ComboBoxMes.Location = New System.Drawing.Point(66, 53)
        Me.ComboBoxMes.Name = "ComboBoxMes"
        Me.ComboBoxMes.Size = New System.Drawing.Size(44, 21)
        Me.ComboBoxMes.TabIndex = 40
        Me.ComboBoxMes.Text = "mes"
        '
        'ComboBoxAño
        '
        Me.ComboBoxAño.FormattingEnabled = True
        Me.ComboBoxAño.Items.AddRange(New Object() {"2020", "2021", "2022", "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030", "2031", "2032", "2033", "2034", "2035", "2036", "2037", "2038", "2039", "2040", "2041", "2042", "2043", "2044", "2045", "2046", "2047", "2048", "2049", "2050", "2051", "2052", "2053", "2054", "2055", "2056", "2057", "2058", "2059", "2060", "2061", "2062", "2063", "2064", "2065", "2066", "2067", "2068", "2069", "2070", "2071", "2072", "2073", "2074", "2075", "2076", "2077", "2078", "2079", "2080", "2081", "2082", "2083", "2084", "2085", "2086", "2087", "2088", "2089", "2090", "2091", "2092", "2093", "2094", "2095", "2096", "2097", "2098", "2099", "2100", "2101", "2102", "2103", "2104", "2105", "2106", "2107", "2108", "2109"})
        Me.ComboBoxAño.Location = New System.Drawing.Point(116, 53)
        Me.ComboBoxAño.Name = "ComboBoxAño"
        Me.ComboBoxAño.Size = New System.Drawing.Size(51, 21)
        Me.ComboBoxAño.TabIndex = 41
        Me.ComboBoxAño.Text = "año"
        '
        'ComboBoxDia
        '
        Me.ComboBoxDia.FormattingEnabled = True
        Me.ComboBoxDia.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31"})
        Me.ComboBoxDia.Location = New System.Drawing.Point(16, 53)
        Me.ComboBoxDia.Name = "ComboBoxDia"
        Me.ComboBoxDia.Size = New System.Drawing.Size(41, 21)
        Me.ComboBoxDia.TabIndex = 42
        Me.ComboBoxDia.Text = "dia"
        '
        'ComboHora
        '
        Me.ComboHora.FormattingEnabled = True
        Me.ComboHora.Items.AddRange(New Object() {"8:00", "8:30", "9:00", "9:30", "10:00", "10:30", "11:00", "11:30", "12:00", "12:30", "1:00", "1:30", "2:00", "2:30", "3:00", "3:30", "4:00", "4:30", "5:00"})
        Me.ComboHora.Location = New System.Drawing.Point(182, 53)
        Me.ComboHora.Name = "ComboHora"
        Me.ComboHora.Size = New System.Drawing.Size(64, 21)
        Me.ComboHora.TabIndex = 43
        Me.ComboHora.Text = "Hora"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(650, 94)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(105, 15)
        Me.Label7.TabIndex = 45
        Me.Label7.Text = "ID del Paciente"
        '
        'TextID
        '
        Me.TextID.Location = New System.Drawing.Point(622, 112)
        Me.TextID.Name = "TextID"
        Me.TextID.Size = New System.Drawing.Size(155, 20)
        Me.TextID.TabIndex = 44
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(702, 145)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 48
        Me.Button1.Text = "Estado cita"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(123, 77)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(26, 13)
        Me.Label8.TabIndex = 51
        Me.Label8.Text = "Año"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(72, 77)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(27, 13)
        Me.Label9.TabIndex = 50
        Me.Label9.Text = "Mes"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(18, 77)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(25, 13)
        Me.Label10.TabIndex = 49
        Me.Label10.Text = "Día"
        '
        'FRMagendar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(802, 450)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextID)
        Me.Controls.Add(Me.ComboHora)
        Me.Controls.Add(Me.ComboBoxDia)
        Me.Controls.Add(Me.ComboBoxAño)
        Me.Controls.Add(Me.ComboBoxMes)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.BtnRegresar)
        Me.Controls.Add(Me.BtnAgregar)
        Me.Controls.Add(Me.BtnCitas)
        Me.Controls.Add(Me.BtnActualizar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextCedula)
        Me.Controls.Add(Me.TextNMedico)
        Me.Controls.Add(Me.TextEspecialidad)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnEliminar)
        Me.MaximizeBox = False
        Me.Name = "FRMagendar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
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
    Friend WithEvents TextEspecialidad As TextBox
    Friend WithEvents TextNMedico As TextBox
    Friend WithEvents TextCedula As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents BtnActualizar As Button
    Friend WithEvents BtnCitas As Button
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents BtnRegresar As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ComboBoxMes As ComboBox
    Friend WithEvents ComboBoxAño As ComboBox
    Friend WithEvents ComboBoxDia As ComboBox
    Friend WithEvents ComboHora As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextID As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
End Class
