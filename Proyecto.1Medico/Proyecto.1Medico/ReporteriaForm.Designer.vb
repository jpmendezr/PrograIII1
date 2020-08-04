<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReporteriaForm
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ComboBoxAño2 = New System.Windows.Forms.ComboBox()
        Me.ComboBoxMes2 = New System.Windows.Forms.ComboBox()
        Me.ComboBoxDia2 = New System.Windows.Forms.ComboBox()
        Me.ComboBoxAño1 = New System.Windows.Forms.ComboBox()
        Me.ComboBoxMes1 = New System.Windows.Forms.ComboBox()
        Me.ComboBoxDia1 = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtCedula = New System.Windows.Forms.TextBox()
        Me.BtnMostrar = New System.Windows.Forms.Button()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.ComboBoxAño2)
        Me.Panel1.Controls.Add(Me.ComboBoxMes2)
        Me.Panel1.Controls.Add(Me.ComboBoxDia2)
        Me.Panel1.Controls.Add(Me.ComboBoxAño1)
        Me.Panel1.Controls.Add(Me.ComboBoxMes1)
        Me.Panel1.Controls.Add(Me.ComboBoxDia1)
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.TxtCedula)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(732, 295)
        Me.Panel1.TabIndex = 0
        '
        'ComboBoxAño2
        '
        Me.ComboBoxAño2.FormattingEnabled = True
        Me.ComboBoxAño2.Items.AddRange(New Object() {"2020", "2019", "2018", "2017", "2016", "2015", "2014", "2013", "2012", "2011", "2010", "2009", "2008", "2007", "2006", "2005", "2004", "2003", "2002", "2001", "2000", "1999", "1998", "1997", "1996", "1995", "1994", "1993", "1992", "1991", "1990", "1989", "1988", "1987", "1986", "1985", "1984", "1983", "1982", "1981", "1980", "1979", "1978", "1977", "1976", "1975", "1974", "1973", "1972", "1971", "1970", "1969", "1968", "1967", "1966", "1965", "1964", "1963", "1962", "1961", "1960", "1959", "1958", "1957", "1956", "1955", "1954", "1953", "1952", "1951", "1949", "1948", "1947", "1946", "1945", "1944", "1943", "1942", "1941", "1940"})
        Me.ComboBoxAño2.Location = New System.Drawing.Point(348, 44)
        Me.ComboBoxAño2.Name = "ComboBoxAño2"
        Me.ComboBoxAño2.Size = New System.Drawing.Size(41, 21)
        Me.ComboBoxAño2.TabIndex = 13
        '
        'ComboBoxMes2
        '
        Me.ComboBoxMes2.FormattingEnabled = True
        Me.ComboBoxMes2.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12"})
        Me.ComboBoxMes2.Location = New System.Drawing.Point(301, 44)
        Me.ComboBoxMes2.Name = "ComboBoxMes2"
        Me.ComboBoxMes2.Size = New System.Drawing.Size(41, 21)
        Me.ComboBoxMes2.TabIndex = 12
        '
        'ComboBoxDia2
        '
        Me.ComboBoxDia2.FormattingEnabled = True
        Me.ComboBoxDia2.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31"})
        Me.ComboBoxDia2.Location = New System.Drawing.Point(261, 43)
        Me.ComboBoxDia2.Name = "ComboBoxDia2"
        Me.ComboBoxDia2.Size = New System.Drawing.Size(34, 21)
        Me.ComboBoxDia2.TabIndex = 11
        '
        'ComboBoxAño1
        '
        Me.ComboBoxAño1.FormattingEnabled = True
        Me.ComboBoxAño1.Items.AddRange(New Object() {"2020", "2019", "2018", "2017", "2016", "2015", "2014", "2013", "2012", "2011", "2010", "2009", "2008", "2007", "2006", "2005", "2004", "2003", "2002", "2001", "2000", "1999", "1998", "1997", "1996", "1995", "1994", "1993", "1992", "1991", "1990", "1989", "1988", "1987", "1986", "1985", "1984", "1983", "1982", "1981", "1980", "1979", "1978", "1977", "1976", "1975", "1974", "1973", "1972", "1971", "1970", "1969", "1968", "1967", "1966", "1965", "1964", "1963", "1962", "1961", "1960", "1959", "1958", "1957", "1956", "1955", "1954", "1953", "1952", "1951", "1949", "1948", "1947", "1946", "1945", "1944", "1943", "1942", "1941", "1940"})
        Me.ComboBoxAño1.Location = New System.Drawing.Point(90, 44)
        Me.ComboBoxAño1.Name = "ComboBoxAño1"
        Me.ComboBoxAño1.Size = New System.Drawing.Size(43, 21)
        Me.ComboBoxAño1.TabIndex = 10
        '
        'ComboBoxMes1
        '
        Me.ComboBoxMes1.FormattingEnabled = True
        Me.ComboBoxMes1.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12"})
        Me.ComboBoxMes1.Location = New System.Drawing.Point(46, 44)
        Me.ComboBoxMes1.Name = "ComboBoxMes1"
        Me.ComboBoxMes1.Size = New System.Drawing.Size(38, 21)
        Me.ComboBoxMes1.TabIndex = 9
        '
        'ComboBoxDia1
        '
        Me.ComboBoxDia1.FormattingEnabled = True
        Me.ComboBoxDia1.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31"})
        Me.ComboBoxDia1.Location = New System.Drawing.Point(3, 43)
        Me.ComboBoxDia1.Name = "ComboBoxDia1"
        Me.ComboBoxDia1.Size = New System.Drawing.Size(37, 21)
        Me.ComboBoxDia1.TabIndex = 8
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(3, 80)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(722, 208)
        Me.DataGridView1.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 15)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Fecha de Inicio"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(283, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 15)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Fecha Final"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(593, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 15)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Cédula"
        '
        'TxtCedula
        '
        Me.TxtCedula.Location = New System.Drawing.Point(551, 44)
        Me.TxtCedula.Name = "TxtCedula"
        Me.TxtCedula.Size = New System.Drawing.Size(148, 20)
        Me.TxtCedula.TabIndex = 1
        '
        'BtnMostrar
        '
        Me.BtnMostrar.BackColor = System.Drawing.Color.Aqua
        Me.BtnMostrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnMostrar.Location = New System.Drawing.Point(669, 313)
        Me.BtnMostrar.Name = "BtnMostrar"
        Me.BtnMostrar.Size = New System.Drawing.Size(75, 23)
        Me.BtnMostrar.TabIndex = 2
        Me.BtnMostrar.Text = "Mostrar"
        Me.BtnMostrar.UseVisualStyleBackColor = False
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Image = Global.Proyecto._1Medico.My.Resources.Resources.lupa
        Me.BtnBuscar.Location = New System.Drawing.Point(12, 313)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.BtnBuscar.TabIndex = 1
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(25, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Día"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(48, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(27, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Mes"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(94, 28)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(26, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Año"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(258, 28)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(25, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Día"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(303, 28)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(27, 13)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Mes"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(350, 28)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(26, 13)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Año"
        '
        'ReporteriaForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(756, 345)
        Me.Controls.Add(Me.BtnMostrar)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ReporteriaForm"
        Me.Text = "ReporteriaForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtCedula As TextBox
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents BtnMostrar As Button
    Friend WithEvents ComboBoxAño2 As ComboBox
    Friend WithEvents ComboBoxMes2 As ComboBox
    Friend WithEvents ComboBoxDia2 As ComboBox
    Friend WithEvents ComboBoxAño1 As ComboBox
    Friend WithEvents ComboBoxMes1 As ComboBox
    Friend WithEvents ComboBoxDia1 As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
End Class
