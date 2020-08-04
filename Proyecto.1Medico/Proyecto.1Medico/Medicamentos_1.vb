Public Class Medicamentos_1
    Private cedulaPaci As String
    Private medi_admi As Integer
    Private medi_rece As Integer

    Public Property CedulaPaci1 As String
        Get
            Return cedulaPaci
        End Get
        Set(value As String)
            cedulaPaci = value
        End Set
    End Property

    Public Property Medi_admi1 As Integer
        Get
            Return medi_admi
        End Get
        Set(value As Integer)
            medi_admi = value
        End Set
    End Property

    Public Property Medi_rece1 As Integer
        Get
            Return medi_rece
        End Get
        Set(value As Integer)
            medi_rece = value
        End Set
    End Property

    Public Sub recetar_medi()

        Dim resultado As Integer = 0

        Try
            Using registro_medi As New BdCentroMedicoEntities
                Dim registro As New TbChequeoMedicamentos With {.CedulaP = cedulaPaci, .MedicamentoAdm = medi_admi, .MedicamentoRecetado = medi_rece}
                registro_medi.TbChequeoMedicamentos.Add(registro)
                resultado = registro_medi.SaveChanges()

                If resultado > 0 Then
                    MsgBox(" Se registraron los datos correctamente ")
                Else
                    MsgBox(" No se registraron los datos correctamente ")

                End If

            End Using
        Catch ex As Exception
            resultado = 0
        End Try
    End Sub
End Class
