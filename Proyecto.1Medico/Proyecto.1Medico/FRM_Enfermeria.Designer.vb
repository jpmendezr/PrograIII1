<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRM_Enfermeria
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Btnregresar = New System.Windows.Forms.Button()
        Me.TxtSintomas = New System.Windows.Forms.RichTextBox()
        Me.BTNactualizar = New System.Windows.Forms.Button()
        Me.txtcedula = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Txtpeso = New System.Windows.Forms.TextBox()
        Me.TXTaltura = New System.Windows.Forms.TextBox()
        Me.txtpresion = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(332, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enfermeria"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(178, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Presión"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(338, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Altura"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(498, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Peso"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(18, 115)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Sintoma"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.Btnregresar)
        Me.Panel1.Controls.Add(Me.TxtSintomas)
        Me.Panel1.Controls.Add(Me.BTNactualizar)
        Me.Panel1.Controls.Add(Me.txtcedula)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Txtpeso)
        Me.Panel1.Controls.Add(Me.TXTaltura)
        Me.Panel1.Controls.Add(Me.txtpresion)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(61, 92)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(678, 320)
        Me.Panel1.TabIndex = 5
        '
        'Btnregresar
        '
        Me.Btnregresar.BackColor = System.Drawing.Color.Aqua
        Me.Btnregresar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnregresar.Location = New System.Drawing.Point(376, 294)
        Me.Btnregresar.Name = "Btnregresar"
        Me.Btnregresar.Size = New System.Drawing.Size(75, 23)
        Me.Btnregresar.TabIndex = 12
        Me.Btnregresar.Text = "Regresar"
        Me.Btnregresar.UseVisualStyleBackColor = False
        '
        'TxtSintomas
        '
        Me.TxtSintomas.Location = New System.Drawing.Point(21, 149)
        Me.TxtSintomas.Name = "TxtSintomas"
        Me.TxtSintomas.Size = New System.Drawing.Size(634, 124)
        Me.TxtSintomas.TabIndex = 11
        Me.TxtSintomas.Text = ""
        '
        'BTNactualizar
        '
        Me.BTNactualizar.BackColor = System.Drawing.Color.Aqua
        Me.BTNactualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNactualizar.Location = New System.Drawing.Point(207, 294)
        Me.BTNactualizar.Name = "BTNactualizar"
        Me.BTNactualizar.Size = New System.Drawing.Size(82, 23)
        Me.BTNactualizar.TabIndex = 8
        Me.BTNactualizar.Text = "Actualizar"
        Me.BTNactualizar.UseVisualStyleBackColor = False
        '
        'txtcedula
        '
        Me.txtcedula.Location = New System.Drawing.Point(21, 52)
        Me.txtcedula.Name = "txtcedula"
        Me.txtcedula.Size = New System.Drawing.Size(154, 20)
        Me.txtcedula.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(24, 27)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 15)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Cedula"
        '
        'Txtpeso
        '
        Me.Txtpeso.Location = New System.Drawing.Point(501, 52)
        Me.Txtpeso.Name = "Txtpeso"
        Me.Txtpeso.Size = New System.Drawing.Size(154, 20)
        Me.Txtpeso.TabIndex = 7
        '
        'TXTaltura
        '
        Me.TXTaltura.Location = New System.Drawing.Point(341, 52)
        Me.TXTaltura.Name = "TXTaltura"
        Me.TXTaltura.Size = New System.Drawing.Size(154, 20)
        Me.TXTaltura.TabIndex = 6
        '
        'txtpresion
        '
        Me.txtpresion.Location = New System.Drawing.Point(181, 52)
        Me.txtpresion.Name = "txtpresion"
        Me.txtpresion.Size = New System.Drawing.Size(154, 20)
        Me.txtpresion.TabIndex = 5
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Proyecto._1Medico.My.Resources.Resources.doctor_medical_mask_avatar_care_hospital_icon_141626
        Me.PictureBox1.Location = New System.Drawing.Point(703, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(97, 90)
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'FRM_Enfermeria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 418)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "FRM_Enfermeria"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Enfermeria"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Txtpeso As TextBox
    Friend WithEvents TXTaltura As TextBox
    Friend WithEvents txtpresion As TextBox
    Friend WithEvents BTNactualizar As Button
    Friend WithEvents txtcedula As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtSintomas As RichTextBox
    Friend WithEvents Btnregresar As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
