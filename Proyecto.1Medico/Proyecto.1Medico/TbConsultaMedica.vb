'------------------------------------------------------------------------------
' <auto-generated>
'     Este código se generó a partir de una plantilla.
'
'     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
'     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class TbConsultaMedica
    Public Property IdConsulta As Integer
    Public Property IdCita As Integer
    Public Property CedulaP As String
    Public Property CedulaM As String
    Public Property Diagnostico As String
    Public Property IdCheqMedicamento As Integer
    Public Property IdCheqExamenes As Integer

    Public Overridable Property TbChequeoExamanes As TbChequeoExamanes
    Public Overridable Property TbChequeoMedicamentos As TbChequeoMedicamentos
    Public Overridable Property TbCita As TbCita

End Class