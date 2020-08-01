<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRMChequeoExamen
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtcedula = New System.Windows.Forms.TextBox()
        Me.Btnmostrar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Btnagregar = New System.Windows.Forms.Button()
        Me.com_sangre = New System.Windows.Forms.ComboBox()
        Me.com_orina = New System.Windows.Forms.ComboBox()
        Me.Btnregresar = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(29, 121)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(506, 165)
        Me.DataGridView1.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(26, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 15)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Cedula:"
        '
        'txtcedula
        '
        Me.txtcedula.Location = New System.Drawing.Point(29, 67)
        Me.txtcedula.Name = "txtcedula"
        Me.txtcedula.Size = New System.Drawing.Size(143, 20)
        Me.txtcedula.TabIndex = 4
        '
        'Btnmostrar
        '
        Me.Btnmostrar.BackColor = System.Drawing.Color.Aqua
        Me.Btnmostrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnmostrar.Location = New System.Drawing.Point(238, 307)
        Me.Btnmostrar.Name = "Btnmostrar"
        Me.Btnmostrar.Size = New System.Drawing.Size(75, 23)
        Me.Btnmostrar.TabIndex = 5
        Me.Btnmostrar.Text = "Mostar"
        Me.Btnmostrar.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(204, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Examen Sangre"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(389, 31)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 15)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Examen Orina"
        '
        'Btnagregar
        '
        Me.Btnagregar.BackColor = System.Drawing.Color.Aqua
        Me.Btnagregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnagregar.Location = New System.Drawing.Point(84, 307)
        Me.Btnagregar.Name = "Btnagregar"
        Me.Btnagregar.Size = New System.Drawing.Size(75, 23)
        Me.Btnagregar.TabIndex = 10
        Me.Btnagregar.Text = "Agregar"
        Me.Btnagregar.UseVisualStyleBackColor = False
        '
        'com_sangre
        '
        Me.com_sangre.FormattingEnabled = True
        Me.com_sangre.Items.AddRange(New Object() {"Hemoglobina", "Colesterol", "Hematocritos", "Triglicerios", "Ácido Úrico", "Creatinina"})
        Me.com_sangre.Location = New System.Drawing.Point(207, 66)
        Me.com_sangre.Name = "com_sangre"
        Me.com_sangre.Size = New System.Drawing.Size(143, 21)
        Me.com_sangre.TabIndex = 11
        '
        'com_orina
        '
        Me.com_orina.FormattingEnabled = True
        Me.com_orina.Items.AddRange(New Object() {"Glucosa", "Eritrocitos", "Color", "Leucocitos(esterasa)"})
        Me.com_orina.Location = New System.Drawing.Point(392, 66)
        Me.com_orina.Name = "com_orina"
        Me.com_orina.Size = New System.Drawing.Size(143, 21)
        Me.com_orina.TabIndex = 12
        '
        'Btnregresar
        '
        Me.Btnregresar.BackColor = System.Drawing.Color.Aqua
        Me.Btnregresar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnregresar.Location = New System.Drawing.Point(383, 307)
        Me.Btnregresar.Name = "Btnregresar"
        Me.Btnregresar.Size = New System.Drawing.Size(75, 23)
        Me.Btnregresar.TabIndex = 13
        Me.Btnregresar.Text = "Regresar"
        Me.Btnregresar.UseVisualStyleBackColor = False
        '
        'FRMChequeoExamen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(570, 353)
        Me.Controls.Add(Me.Btnregresar)
        Me.Controls.Add(Me.com_orina)
        Me.Controls.Add(Me.com_sangre)
        Me.Controls.Add(Me.Btnagregar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Btnmostrar)
        Me.Controls.Add(Me.txtcedula)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "FRMChequeoExamen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FRMChequeoExamen"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Dim chequeo_examen As New Examenes
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents txtcedula As TextBox
    Friend WithEvents Btnmostrar As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Btnagregar As Button
    Friend WithEvents com_sangre As ComboBox
    Friend WithEvents com_orina As ComboBox
    Friend WithEvents Btnregresar As Button

    Dim registro As New Examenes()
    Dim frmConsultorio As New FormConsultorio()
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btnmostrar.Click
        Try
            Using mostrar_examen As New BdCentroMedicoEntities
                Dim mostrar = (From mos In mostrar_examen.TbChequeoExamanes Take (1000) Select mos).ToList

                If (mostrar.count > 0) Then
                    Me.DataGridView1.DataSource = mostrar
                    DataGridView1.Columns.Remove("TbConsultaMedica")
                    'MsgBox("se mostraron los datos")
                End If
            End Using
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Btnagregar.Click
        If txtcedula.Text.Length > 0 And com_sangre.Text.Length > 0 And com_orina.Text.Length > 0 Then
            If Information.IsNumeric(Me.txtcedula.Text) Then
                registro.Cedula1 = Me.txtcedula.Text
            Else
                MsgBox(" No se permiten letras ")
            End If

            If Information.IsNumeric(Me.com_sangre.Text) And Information.IsNumeric(com_orina.Text) Then

                MsgBox(" No se prermiten Numeros")
            Else
                registro.Sangre1 = Me.com_sangre.Text
                registro.Orina1 = Me.com_orina.Text

            End If
            registro.enviar_exa()
        Else
            MsgBox("Se debe ingresar los datos")
        End If


    End Sub

    Private Sub Btnregresar_Click(sender As Object, e As EventArgs) Handles Btnregresar.Click
        '' Para regresar al formulario consultorio
        Me.Hide()
        frmConsultorio = New FormConsultorio()
        frmConsultorio.Show()
    End Sub
End Class
