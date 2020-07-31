Public Class FormUsuarios
    Dim auten As New Autenticacion
    Dim formMenu As FormMenu

    Private Sub FormUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()

    End Sub



    Public Function VerificarCampos() As Boolean
        If Information.IsNumeric(txtCedula.Text) And Information.IsNumeric(txtdia.Text) And Information.IsNumeric(txtmes.Text) And Information.IsNumeric(txtano.Text) Then
            If (txtNombre.Text.Length > 0 And Not Information.IsNumeric(txtNombre.Text)) And (txtapell.Text.Length > 0 And Not Information.IsNumeric(txtapell.Text)) And CBSexo.Text.Length > 0 And txttel.Text.Length > 0 And txtCorr.Text.Length > 0 And CBdepa.Text.Length > 0 And txtContra.Text.Length > 0 And (txtdia.Text > 0 And txtdia.Text <= 31) And (txtmes.Text > 0 And txtmes.Text <= 12) And (txtdia.Text > 0 And txtdia.Text <= 31) And (txtano.Text > 1900 And txtano.Text <= 2020 And txtano.Text.Length = 4) Then

                Return True
            Else
                MsgBox("Campos mal ingresados")
                Return False


            End If

        Else
            MsgBox("No puede ingresar letras o estar vacio los campos ")
            Return False
        End If
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If VerificarCampos() Then
            auten.Cedula1 = txtCedula.Text
            auten.Nombre1 = txtNombre.Text
            auten.Apellido1 = txtapell.Text
            auten.Sexo1 = CBSexo.Text
            auten.Fecha1 = txtdia.Text + "/" + txtmes.Text + "/" + txtano.Text
            auten.Telef1 = txttel.Text
            auten.Corre1 = txtCorr.Text
            auten.Departamento1 = CBdepa.Text
            auten.Contra1 = txtContra.Text
            If auten.agregarPersonal() Then
                auten.InsertarEspecialidad()
                LimpiarTexto()

            End If
        End If
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            Using bd As New BdCentroMedicoEntities
                Dim mostrar = bd.f_sp_BuscarPersonal(txtBusCedula.Text).ToList
                If (mostrar.Count > 0) Then
                    Me.DataGridView1.DataSource = mostrar
                Else
                    MsgBox("No se encuentra el usuario")
                End If
            End Using
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub


    Public Sub mostrar()
        Try
            Using bd As New BdCentroMedicoEntities
                Dim mostrar = bd.f_sp_MostrarPersonal.ToList
                If (mostrar.Count > 0) Then
                    Me.DataGridView1.DataSource = mostrar
                End If
            End Using
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub


    Public Sub InsertarPersonal()
        Dim resultado As Integer = 0
        Dim fecha As String = txtdia.Text + "/" + txtmes.Text + "/" + txtano.Text
        Try
            Using registro As New BdCentroMedicoEntities
                Dim NuevoRegistro As New TbPersona With {.Cedula = txtCedula.Text, .Nombre = txtNombre.Text, .Apellido = txtapell.Text, .Sexo = CBSexo.Text, .FechaNacimiento = fecha, .Telefono = txttel.Text, .Correo = txtCorr.Text}
                registro.TbPersona.Add(NuevoRegistro)
                resultado = registro.SaveChanges
                If resultado > 0 Then
                    MsgBox(" se registraron los datos ")
                Else
                    MsgBox(" no se registraron ")

                End If
            End Using
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Public Sub InsertarEspecialidad()
        Dim resultado As Integer = 0
        Try
            Using regi As New BdCentroMedicoEntities
                Dim tbnuev As New TbPersonalInterno With {.Cedula = txtCedula.Text, .Departamento = CBdepa.Text, .Contrasena = txtContra.Text}
                regi.TbPersonalInterno.Add(tbnuev)
                resultado = regi.SaveChanges
                If resultado > 0 Then
                    MsgBox(" se registraron los datos en la tabla especialidad ")
                Else
                    MsgBox(" no se registraron en la tabla especialidad  ")

                End If
            End Using
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        auten.Cedula1 = txtBusCedula.Text
        auten.eliminarUsuario()
    End Sub

    Private Sub btnMostar_Click(sender As Object, e As EventArgs) Handles btnMostar.Click
        mostrar()

    End Sub

    Private Sub DataGridView1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles DataGridView1.MouseDoubleClick
        btnAgregar.Enabled = False
        btnBuscar.Enabled = False
        btnEliminar.Enabled = False
        Dim valor As String = ""
        valor = DataGridView1.CurrentRow.Cells(1).Value.ToString
        llenarTexto(valor)
    End Sub

    Private Sub llenarTexto(valor As String)
        Try
            Using bd As New BdCentroMedicoEntities
                Dim actua = (From a In bd.TbPersona Where a.Cedula = valor Select a).ToList
                Dim sen = (From a In bd.TbPersona Where a.Cedula = valor Select a).SingleOrDefault
                Dim senr = (From a In bd.TbPersonalInterno Where a.Cedula = valor Select a).SingleOrDefault  'Dim fecha = (From a In bd.TbPersona Where a.Cedula = valor Select a.FechaNacimiento).SingleOrDefault
                Dim fe As String() = sen.fechanacimiento.ToString.Split("/")
                If (actua.Count > 0) Then
                    txtCedula.Text = sen.cedula.ToString
                    txtNombre.Text = sen.Nombre.ToString
                    txtapell.Text = sen.Apellido.ToString
                    CBSexo.Text = sen.Sexo.ToString
                    txtdia.Text = fe(0)
                    txtmes.Text = fe(1)
                    txtano.Text = fe(2)
                    txttel.Text = sen.Telefono.ToString
                    txtCorr.Text = sen.Correo.ToString
                    CBdepa.Text = senr.Departamento.ToString
                    txtContra.Text = senr.Contrasena.ToString
                Else
                    MsgBox("error")
                End If
            End Using

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        If VerificarCampos() Then
            auten.Cedula1 = txtCedula.Text
            auten.Nombre1 = txtNombre.Text
            auten.Apellido1 = txtapell.Text
            auten.Sexo1 = CBSexo.Text
            auten.Fecha1 = txtdia.Text + "/" + txtmes.Text + "/" + txtano.Text
            auten.Telef1 = txttel.Text
            auten.Corre1 = txtCorr.Text
            auten.Departamento1 = CBdepa.Text
            auten.Contra1 = txtContra.Text
            auten.actualizar()
            LimpiarTexto()
            btnAgregar.Enabled = True
            btnBuscar.Enabled = True
            btnEliminar.Enabled = True

        End If

    End Sub
    Public Sub LimpiarTexto()
        txtCedula.Text = ""
        txtNombre.Text = ""
        txtapell.Text = ""
        CBSexo.Text = ""
        txtdia.Text = ""
        txtmes.Text = ""
        txtano.Text = ""
        txttel.Text = ""
        txtCorr.Text = ""
        CBdepa.Text = ""
        txtContra.Text = ""
    End Sub

    Private Sub CBSexo_TextChanged(sender As Object, e As EventArgs) Handles CBSexo.TextChanged
        Me.CBdepa.DropDownStyle = ComboBoxStyle.DropDownList
        Me.CBSexo.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub BtnRegresar_Click(sender As Object, e As EventArgs) Handles BtnRegresar.Click
        formMenu = New FormMenu()
        formMenu.Show()
        Me.Dispose()


    End Sub


End Class