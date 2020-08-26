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
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBoxAño2 = New System.Windows.Forms.ComboBox()
        Me.ComboBoxMes2 = New System.Windows.Forms.ComboBox()
        Me.ComboBoxDia2 = New System.Windows.Forms.ComboBox()
        Me.ComboBoxAño1 = New System.Windows.Forms.ComboBox()
        Me.ComboBoxMes1 = New System.Windows.Forms.ComboBox()
        Me.ComboBoxDia1 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtCedula = New System.Windows.Forms.TextBox()
        Me.BtnReporteExamen = New System.Windows.Forms.Button()
        Me.BtnReporteCita = New System.Windows.Forms.Button()
        Me.BtnRegresar = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.ReportViewer1)
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
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.TxtCedula)
        Me.Panel1.Location = New System.Drawing.Point(-1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(853, 383)
        Me.Panel1.TabIndex = 0
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Location = New System.Drawing.Point(-2, 71)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(848, 305)
        Me.ReportViewer1.TabIndex = 20
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(464, 29)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(26, 13)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Año"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(406, 29)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(27, 13)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Mes"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(361, 29)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(25, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Día"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(99, 28)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(26, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Año"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(57, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(27, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Mes"
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
        'ComboBoxAño2
        '
        Me.ComboBoxAño2.FormattingEnabled = True
        Me.ComboBoxAño2.Items.AddRange(New Object() {"1940", "1941", "1942", "1943", "1944", "1945", "1946", "1947", "1948", "1949", "1951", "1952", "1953", "1954", "1955", "1956", "1957", "1958", "1959", "1960", "1961", "1962", "1963", "1964", "1965", "1966", "1967", "1968", "1969", "1970", "1971", "1972", "1973", "1974", "1975", "1976", "1977", "1978", "1979", "1980", "1981", "1982", "1983", "1984", "1985", "1986", "1987", "1988", "1989", "1990", "1991", "1992", "1993", "1994", "1995", "1996", "1997", "1998", "1999", "2000", "2001", "2002", "2003", "2004", "2005", "2006", "2007", "2008", "2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2020", "2021", "2022", "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030", "2031", "2032", "2033", "2034", "2035", "2036", "2037", "2038", "2039", "2040", "2041", "2042", "2043", "2044", "2045", "2046", "2047", "2048", "2049", "2050", "2051", "2052", "2053", "2054", "2055", "2056", "2057", "2058", "2059", "2060", "2061", "2062", "2063", "2064", "2065", "2066", "2067", "2068", "2069", "2070", "2071", "2072", "2073", "2074", "2075", "2076", "2077", "2078", "2079", "2080", "2081", "2082", "2083", "2084", "2085", "2086", "2087", "2088", "2089", "2090", "2091", "2092", "2093", "2094", "2095", "2096", "2097", "2098", "2099", "2100", "2101", "2102", "2103", "2104", "2105", "2106", "2107", "2108", "2109"})
        Me.ComboBoxAño2.Location = New System.Drawing.Point(451, 45)
        Me.ComboBoxAño2.Name = "ComboBoxAño2"
        Me.ComboBoxAño2.Size = New System.Drawing.Size(59, 21)
        Me.ComboBoxAño2.TabIndex = 13
        '
        'ComboBoxMes2
        '
        Me.ComboBoxMes2.FormattingEnabled = True
        Me.ComboBoxMes2.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12"})
        Me.ComboBoxMes2.Location = New System.Drawing.Point(404, 45)
        Me.ComboBoxMes2.Name = "ComboBoxMes2"
        Me.ComboBoxMes2.Size = New System.Drawing.Size(41, 21)
        Me.ComboBoxMes2.TabIndex = 12
        '
        'ComboBoxDia2
        '
        Me.ComboBoxDia2.FormattingEnabled = True
        Me.ComboBoxDia2.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31"})
        Me.ComboBoxDia2.Location = New System.Drawing.Point(351, 44)
        Me.ComboBoxDia2.Name = "ComboBoxDia2"
        Me.ComboBoxDia2.Size = New System.Drawing.Size(47, 21)
        Me.ComboBoxDia2.TabIndex = 11
        '
        'ComboBoxAño1
        '
        Me.ComboBoxAño1.FormattingEnabled = True
        Me.ComboBoxAño1.Items.AddRange(New Object() {"1940", "1941", "1942", "1943", "1944", "1945", "1946", "1947", "1948", "1949", "1951", "1952", "1953", "1954", "1955", "1956", "1957", "1958", "1959", "1960", "1961", "1962", "1963", "1964", "1965", "1966", "1967", "1968", "1969", "1970", "1971", "1972", "1973", "1974", "1975", "1976", "1977", "1978", "1979", "1980", "1981", "1982", "1983", "1984", "1985", "1986", "1987", "1988", "1989", "1990", "1991", "1992", "1993", "1994", "1995", "1996", "1997", "1998", "1999", "2000", "2001", "2002", "2003", "2004", "2005", "2006", "2007", "2008", "2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2020", "2021", "2022", "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030", "2031", "2032", "2033", "2034", "2035", "2036", "2037", "2038", "2039", "2040", "2041", "2042", "2043", "2044", "2045", "2046", "2047", "2048", "2049", "2050", "2051", "2052", "2053", "2054", "2055", "2056", "2057", "2058", "2059", "2060", "2061", "2062", "2063", "2064", "2065", "2066", "2067", "2068", "2069", "2070", "2071", "2072", "2073", "2074", "2075", "2076", "2077", "2078", "2079", "2080", "2081", "2082", "2083", "2084", "2085", "2086", "2087", "2088", "2089", "2090", "2091", "2092", "2093", "2094", "2095", "2096", "2097", "2098", "2099", "2100", "2101", "2102", "2103", "2104", "2105", "2106", "2107", "2108", "2109"})
        Me.ComboBoxAño1.Location = New System.Drawing.Point(90, 44)
        Me.ComboBoxAño1.Name = "ComboBoxAño1"
        Me.ComboBoxAño1.Size = New System.Drawing.Size(53, 21)
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
        Me.Label2.Location = New System.Drawing.Point(387, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 15)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Fecha Final"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(731, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 15)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Cédula"
        '
        'TxtCedula
        '
        Me.TxtCedula.Location = New System.Drawing.Point(688, 45)
        Me.TxtCedula.Name = "TxtCedula"
        Me.TxtCedula.Size = New System.Drawing.Size(148, 20)
        Me.TxtCedula.TabIndex = 1
        '
        'BtnReporteExamen
        '
        Me.BtnReporteExamen.BackColor = System.Drawing.Color.Aqua
        Me.BtnReporteExamen.Location = New System.Drawing.Point(-1, 384)
        Me.BtnReporteExamen.Name = "BtnReporteExamen"
        Me.BtnReporteExamen.Size = New System.Drawing.Size(156, 37)
        Me.BtnReporteExamen.TabIndex = 1
        Me.BtnReporteExamen.Text = "Reporte Examenes"
        Me.BtnReporteExamen.UseVisualStyleBackColor = False
        '
        'BtnReporteCita
        '
        Me.BtnReporteCita.BackColor = System.Drawing.Color.Aqua
        Me.BtnReporteCita.Location = New System.Drawing.Point(349, 384)
        Me.BtnReporteCita.Name = "BtnReporteCita"
        Me.BtnReporteCita.Size = New System.Drawing.Size(162, 37)
        Me.BtnReporteCita.TabIndex = 3
        Me.BtnReporteCita.Text = "Reporte Cita"
        Me.BtnReporteCita.UseVisualStyleBackColor = False
        '
        'BtnRegresar
        '
        Me.BtnRegresar.BackColor = System.Drawing.Color.Aqua
        Me.BtnRegresar.Location = New System.Drawing.Point(689, 384)
        Me.BtnRegresar.Name = "BtnRegresar"
        Me.BtnRegresar.Size = New System.Drawing.Size(158, 37)
        Me.BtnRegresar.TabIndex = 5
        Me.BtnRegresar.Text = "Regresar"
        Me.BtnRegresar.UseVisualStyleBackColor = False
        '
        'ReporteriaForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(861, 423)
        Me.Controls.Add(Me.BtnRegresar)
        Me.Controls.Add(Me.BtnReporteCita)
        Me.Controls.Add(Me.BtnReporteExamen)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.Name = "ReporteriaForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporteria"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtCedula As TextBox
    Friend WithEvents BtnReporteExamen As Button
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
    Friend WithEvents BtnReporteCita As Button
    Friend WithEvents BtnRegresar As Button
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
End Class
