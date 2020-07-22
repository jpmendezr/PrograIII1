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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FechaFin = New System.Windows.Forms.DateTimePicker()
        Me.fechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.TxtCedula = New System.Windows.Forms.TextBox()
        Me.BtnMostrar = New System.Windows.Forms.Button()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.FechaFin)
        Me.Panel1.Controls.Add(Me.fechaInicio)
        Me.Panel1.Controls.Add(Me.TxtCedula)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(732, 295)
        Me.Panel1.TabIndex = 0
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
        Me.Label3.Location = New System.Drawing.Point(78, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Fecha de Inicio"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(362, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Fecha Final"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(652, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Cédula"
        '
        'FechaFin
        '
        Me.FechaFin.Location = New System.Drawing.Point(291, 33)
        Me.FechaFin.Name = "FechaFin"
        Me.FechaFin.Size = New System.Drawing.Size(200, 20)
        Me.FechaFin.TabIndex = 3
        '
        'fechaInicio
        '
        Me.fechaInicio.Location = New System.Drawing.Point(14, 33)
        Me.fechaInicio.Name = "fechaInicio"
        Me.fechaInicio.Size = New System.Drawing.Size(200, 20)
        Me.fechaInicio.TabIndex = 2
        '
        'TxtCedula
        '
        Me.TxtCedula.Location = New System.Drawing.Point(625, 33)
        Me.TxtCedula.Name = "TxtCedula"
        Me.TxtCedula.Size = New System.Drawing.Size(100, 20)
        Me.TxtCedula.TabIndex = 1
        '
        'BtnMostrar
        '
        Me.BtnMostrar.Location = New System.Drawing.Point(669, 313)
        Me.BtnMostrar.Name = "BtnMostrar"
        Me.BtnMostrar.Size = New System.Drawing.Size(75, 23)
        Me.BtnMostrar.TabIndex = 2
        Me.BtnMostrar.Text = "Mostrar"
        Me.BtnMostrar.UseVisualStyleBackColor = True
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
    Friend WithEvents FechaFin As DateTimePicker
    Friend WithEvents fechaInicio As DateTimePicker
    Friend WithEvents TxtCedula As TextBox
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents BtnMostrar As Button
End Class
