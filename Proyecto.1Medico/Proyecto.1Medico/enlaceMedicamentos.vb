Public Class enlaceMedicamentos

    'No existe una clase para enlazar los medicamentos.
    'Por ello el atributo medicamentoRecetado de la clase ClsConsultaMedida debe ser un arreglo por agregación

    Private MRecetado As String
    Private enlaceMedicamento As List(Of String)

    Public Property MRecetado1 As String
        Get
            Return MRecetado
        End Get
        Set(value As String)
            MRecetado = value
        End Set
    End Property

    Public Property EnlaceMedicamento1 As List(Of String)
        Get
            Return enlaceMedicamento
        End Get
        Set(value As List(Of String))
            enlaceMedicamento = value
        End Set
    End Property

    Public Sub AgregarM()
        For Each Item In EnlaceMedicamento1
            Me.EnlaceMedicamento1.Add(MRecetado1)
        Next
    End Sub
End Class
