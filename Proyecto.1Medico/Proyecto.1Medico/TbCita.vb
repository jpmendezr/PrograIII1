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

Partial Public Class TbCita
    Public Property IdCita As Integer
    Public Property CedulaPaciente As String
    Public Property Fecha As Date
    Public Property Hora As String
    Public Property NombreMedico As String
    Public Property Especialidad As String

    Public Overridable Property TbConsultaMedica As ICollection(Of TbConsultaMedica) = New HashSet(Of TbConsultaMedica)

End Class