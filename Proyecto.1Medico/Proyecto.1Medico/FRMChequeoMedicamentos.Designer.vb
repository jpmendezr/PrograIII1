<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMChequeoMedicamentos
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
        Me.Btnregresar = New System.Windows.Forms.Button()
        Me.Btnmostrar = New System.Windows.Forms.Button()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Btnagregar = New System.Windows.Forms.Button()
        Me.txtrece = New System.Windows.Forms.TextBox()
        Me.txtadmi = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtcedula = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.Btnregresar)
        Me.Panel1.Controls.Add(Me.Btnmostrar)
        Me.Panel1.Controls.Add(Me.DataGridView2)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Controls.Add(Me.Btnagregar)
        Me.Panel1.Controls.Add(Me.txtrece)
        Me.Panel1.Controls.Add(Me.txtadmi)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtcedula)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(814, 319)
        Me.Panel1.TabIndex = 0
        '
        'Btnregresar
        '
        Me.Btnregresar.BackColor = System.Drawing.Color.Aqua
        Me.Btnregresar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnregresar.Location = New System.Drawing.Point(635, 288)
        Me.Btnregresar.Name = "Btnregresar"
        Me.Btnregresar.Size = New System.Drawing.Size(75, 23)
        Me.Btnregresar.TabIndex = 17
        Me.Btnregresar.Text = "Regresar"
        Me.Btnregresar.UseVisualStyleBackColor = False
        '
        'Btnmostrar
        '
        Me.Btnmostrar.BackColor = System.Drawing.Color.Aqua
        Me.Btnmostrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnmostrar.Location = New System.Drawing.Point(518, 288)
        Me.Btnmostrar.Name = "Btnmostrar"
        Me.Btnmostrar.Size = New System.Drawing.Size(75, 23)
        Me.Btnmostrar.TabIndex = 16
        Me.Btnmostrar.Text = "Mostrar"
        Me.Btnmostrar.UseVisualStyleBackColor = False
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(317, 132)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(458, 150)
        Me.DataGridView2.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(371, 114)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(158, 15)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Mostrar Medicamentos "
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(27, 132)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(238, 150)
        Me.DataGridView1.TabIndex = 13
        '
        'Btnagregar
        '
        Me.Btnagregar.BackColor = System.Drawing.Color.Aqua
        Me.Btnagregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnagregar.Location = New System.Drawing.Point(388, 288)
        Me.Btnagregar.Name = "Btnagregar"
        Me.Btnagregar.Size = New System.Drawing.Size(75, 23)
        Me.Btnagregar.TabIndex = 7
        Me.Btnagregar.Text = "Agregar"
        Me.Btnagregar.UseVisualStyleBackColor = False
        '
        'txtrece
        '
        Me.txtrece.Location = New System.Drawing.Point(388, 61)
        Me.txtrece.Name = "txtrece"
        Me.txtrece.Size = New System.Drawing.Size(121, 20)
        Me.txtrece.TabIndex = 12
        '
        'txtadmi
        '
        Me.txtadmi.Location = New System.Drawing.Point(181, 61)
        Me.txtadmi.Name = "txtadmi"
        Me.txtadmi.Size = New System.Drawing.Size(121, 20)
        Me.txtadmi.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(24, 102)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(215, 15)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Mostrar Chequeo Medicamentos"
        '
        'txtcedula
        '
        Me.txtcedula.Location = New System.Drawing.Point(27, 61)
        Me.txtcedula.Name = "txtcedula"
        Me.txtcedula.Size = New System.Drawing.Size(121, 20)
        Me.txtcedula.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(385, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(173, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Medicamentos Recetados"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(178, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(196, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Medicamentos Administrados"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cedula"
        '
        'FRMChequeoMedicamentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(838, 343)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FRMChequeoMedicamentos"
        Me.Text = "FRMChequeoMedicamentos"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtcedula As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Btnagregar As Button
    Friend WithEvents txtrece As TextBox
    Friend WithEvents txtadmi As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents Btnmostrar As Button
    Friend WithEvents Btnregresar As Button
End Class
