﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PacienteBuscarFiltros
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
        Dim BtnMostrar As System.Windows.Forms.Button
        Me.TextBuscar = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BTNbuscar = New System.Windows.Forms.Button()
        BtnMostrar = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBuscar
        '
        Me.TextBuscar.Location = New System.Drawing.Point(12, 51)
        Me.TextBuscar.Name = "TextBuscar"
        Me.TextBuscar.Size = New System.Drawing.Size(100, 20)
        Me.TextBuscar.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Ingrese la Cédula"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 97)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(600, 186)
        Me.DataGridView1.TabIndex = 3
        '
        'BTNbuscar
        '
        Me.BTNbuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BTNbuscar.Image = Global.Proyecto._1Medico.My.Resources.Resources.lupa
        Me.BTNbuscar.Location = New System.Drawing.Point(132, 51)
        Me.BTNbuscar.Name = "BTNbuscar"
        Me.BTNbuscar.Size = New System.Drawing.Size(75, 23)
        Me.BTNbuscar.TabIndex = 1
        Me.BTNbuscar.UseVisualStyleBackColor = False
        '
        'BtnMostrar
        '
        BtnMostrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        BtnMostrar.Location = New System.Drawing.Point(237, 51)
        BtnMostrar.Name = "BtnMostrar"
        BtnMostrar.Size = New System.Drawing.Size(75, 23)
        BtnMostrar.TabIndex = 4
        BtnMostrar.Text = "Mostrar"
        BtnMostrar.UseVisualStyleBackColor = False
        '
        'PacienteBuscarFiltros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 307)
        Me.Controls.Add(BtnMostrar)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BTNbuscar)
        Me.Controls.Add(Me.TextBuscar)
        Me.Name = "PacienteBuscarFiltros"
        Me.Text = "PacienteBuscarFiltros"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBuscar As TextBox
    Friend WithEvents BTNbuscar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
End Class
