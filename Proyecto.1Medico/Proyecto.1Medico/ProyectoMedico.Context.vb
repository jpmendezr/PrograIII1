﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Este código se generó a partir de una plantilla.
'
'     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
'     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Data.Entity
Imports System.Data.Entity.Infrastructure
Imports System.Data.Entity.Core.Objects
Imports System.Linq

Partial Public Class BdCentroMedicoEntities
    Inherits DbContext

    Public Sub New()
        MyBase.New("name=BdCentroMedicoEntities")
    End Sub

    Protected Overrides Sub OnModelCreating(modelBuilder As DbModelBuilder)
        Throw New UnintentionalCodeFirstException()
    End Sub

    Public Overridable Property sysdiagrams() As DbSet(Of sysdiagrams)
    Public Overridable Property TbChequeoExamanes() As DbSet(Of TbChequeoExamanes)
    Public Overridable Property TbChequeoMedicamentos() As DbSet(Of TbChequeoMedicamentos)
    Public Overridable Property TbConsultaMedica() As DbSet(Of TbConsultaMedica)
    Public Overridable Property TbEnfermedad() As DbSet(Of TbEnfermedad)
    Public Overridable Property TbEspecialidad() As DbSet(Of TbEspecialidad)
    Public Overridable Property TbFamiliarPaciente() As DbSet(Of TbFamiliarPaciente)
    Public Overridable Property TbMedicamento() As DbSet(Of TbMedicamento)
    Public Overridable Property TbPersona() As DbSet(Of TbPersona)
    Public Overridable Property TbPersonalInterno() As DbSet(Of TbPersonalInterno)
    Public Overridable Property TbPaciente() As DbSet(Of TbPaciente)
    Public Overridable Property TbCita() As DbSet(Of TbCita)

    Public Overridable Function f_sp_BuscarPersonal(cedu As String) As ObjectResult(Of f_sp_BuscarPersonal_Result1)
        Dim ceduParameter As ObjectParameter = If(cedu IsNot Nothing, New ObjectParameter("Cedu", cedu), New ObjectParameter("Cedu", GetType(String)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction(Of f_sp_BuscarPersonal_Result1)("f_sp_BuscarPersonal", ceduParameter)
    End Function

    Public Overridable Function f_sp_MostrarPersonal() As ObjectResult(Of f_sp_MostrarPersonal_Result1)
        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction(Of f_sp_MostrarPersonal_Result1)("f_sp_MostrarPersonal")
    End Function

    Public Overridable Function BuscarPersona(cedulas As String) As ObjectResult(Of BuscarPersona_Result)
        Dim cedulasParameter As ObjectParameter = If(cedulas IsNot Nothing, New ObjectParameter("cedulas", cedulas), New ObjectParameter("cedulas", GetType(String)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction(Of BuscarPersona_Result)("BuscarPersona", cedulasParameter)
    End Function

    Public Overridable Function MostrarPersona() As ObjectResult(Of MostrarPersona_Result)
        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction(Of MostrarPersona_Result)("MostrarPersona")
    End Function

    Public Overridable Function Mostrar_ReporteriaPacientePersonal() As ObjectResult(Of Mostrar_ReporteriaPacientePersonal_Result)
        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction(Of Mostrar_ReporteriaPacientePersonal_Result)("Mostrar_ReporteriaPacientePersonal")
    End Function

    Public Overridable Function Sp_Reporte_Examenes(cedula As String, fechaInicio As String, fechaFinal As String) As ObjectResult(Of Sp_Reporte_Examenes_Result)
        Dim cedulaParameter As ObjectParameter = If(cedula IsNot Nothing, New ObjectParameter("Cedula", cedula), New ObjectParameter("Cedula", GetType(String)))

        Dim fechaInicioParameter As ObjectParameter = If(fechaInicio IsNot Nothing, New ObjectParameter("FechaInicio", fechaInicio), New ObjectParameter("FechaInicio", GetType(String)))

        Dim fechaFinalParameter As ObjectParameter = If(fechaFinal IsNot Nothing, New ObjectParameter("FechaFinal", fechaFinal), New ObjectParameter("FechaFinal", GetType(String)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction(Of Sp_Reporte_Examenes_Result)("Sp_Reporte_Examenes", cedulaParameter, fechaInicioParameter, fechaFinalParameter)
    End Function

    Public Overridable Function MostrarExamenes() As ObjectResult(Of MostrarExamenes_Result)
        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction(Of MostrarExamenes_Result)("MostrarExamenes")
    End Function

    Public Overridable Function f_Sp_Reporte_Cita(cedula As String, fechaInicio As String, fechaFinal As String) As ObjectResult(Of f_Sp_Reporte_Cita_Result3)
        Dim cedulaParameter As ObjectParameter = If(cedula IsNot Nothing, New ObjectParameter("Cedula", cedula), New ObjectParameter("Cedula", GetType(String)))

        Dim fechaInicioParameter As ObjectParameter = If(fechaInicio IsNot Nothing, New ObjectParameter("FechaInicio", fechaInicio), New ObjectParameter("FechaInicio", GetType(String)))

        Dim fechaFinalParameter As ObjectParameter = If(fechaFinal IsNot Nothing, New ObjectParameter("FechaFinal", fechaFinal), New ObjectParameter("FechaFinal", GetType(String)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction(Of f_Sp_Reporte_Cita_Result3)("f_Sp_Reporte_Cita", cedulaParameter, fechaInicioParameter, fechaFinalParameter)
    End Function

    Public Overridable Function mostrar_tablas() As ObjectResult(Of mostrar_tablas_Result1)
        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction(Of mostrar_tablas_Result1)("mostrar_tablas")
    End Function

End Class
