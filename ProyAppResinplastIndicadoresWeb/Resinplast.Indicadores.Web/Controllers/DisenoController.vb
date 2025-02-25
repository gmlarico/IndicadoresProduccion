Imports System.Web.Mvc
Imports Newtonsoft.Json
Imports Resinplast.Indicadores.Wrapper
Imports Resinplast.Indicadores.Web.Models
Imports Resinplast.Indicadores.Web.Models.Base
Imports Resinplast.Indicadores.Utils

Namespace Resinplast.Indicadores.Web
    Public Class DisenoController

        Inherits System.Web.Mvc.Controller
        Function Index() As ActionResult
            Return View()
        End Function

        Function General() As ActionResult
            Return View()
        End Function

        ''' <summary>
        ''' Lista Consultar
        ''' </summary>
        ''' <param name="itemRequest"></param>
        ''' <returns></returns>
        Public Function ListarAperturasDia(ByVal itemRequest As List(Of DiseñoIndicadoresAperturaRequest)) As JsonResult
            Dim result = New DisenoContext().ListarAperturasDia(itemRequest(0))
            Return Json(result)
        End Function

        ''' <summary>
        ''' Lista Consultar
        ''' </summary>
        ''' <param name="itemRequest"></param>
        ''' <returns></returns>
        Public Function ListarAperturasSemana(ByVal itemRequest As List(Of DiseñoIndicadoresAperturaRequest)) As JsonResult
            Dim result = New DisenoContext().ListarAperturasSemana(itemRequest(0))
            Return Json(result)
        End Function

        ''' <summary>
        ''' Lista Consultar
        ''' </summary>
        ''' <param name="itemRequest"></param>
        ''' <returns></returns>
        Public Function ListarPreprensasSemana(ByVal itemRequest As List(Of DiseñoIndicadoresPreprensasRequest)) As JsonResult
            Dim result = New DisenoContext().ListarPreprensasSemana(itemRequest(0))
            Return Json(result)
        End Function

        ''' <summary>
        ''' Lista Consultar
        ''' </summary>
        ''' <param name="itemRequest"></param>
        ''' <returns></returns>
        Public Function ListarPrepensaDia(ByVal itemRequest As List(Of DiseñoIndicadoresPreprensasRequest)) As JsonResult
            Dim result = New DisenoContext().ListarPrepensaDia(itemRequest(0))
            Return Json(result)
        End Function

        ''' <summary>
        ''' Lista Consultar
        ''' </summary>
        ''' <param name="itemRequest"></param>
        ''' <returns></returns>
        Public Function ListarPrepensaDiaPruebaColor(ByVal itemRequest As List(Of DiseñoIndicadoresPreprensasRequest)) As JsonResult
            Dim result = New DisenoContext().ListarPrepensaDiaPruebaColor(itemRequest(0))
            Return Json(result)
        End Function

        ''' <summary>
        ''' Lista Consultar
        ''' </summary>
        ''' <param name="itemRequest"></param>
        ''' <returns></returns>
        Public Function ConsultarAperturasDiasDetalle2(ByVal itemRequest As List(Of DiseñoIndicadoresAperturaRequest)) As JsonResult
            Dim result = New DisenoContext().ConsultarAperturasDiasDetalle2(itemRequest(0))
            Return Json(result)
        End Function

        ''' <summary>
        ''' Lista Consultar
        ''' </summary>
        ''' <param name="itemRequest"></param>
        ''' <returns></returns>
        Public Function ConsultarPreprensaDiasDetalle2(ByVal itemRequest As List(Of DiseñoIndicadoresPreprensasRequest)) As JsonResult
            Dim result = New DisenoContext().ConsultarPreprensaDiasDetalle2(itemRequest(0))
            Return Json(result)
        End Function


        ''' <summary>
        ''' Lista Consultar
        ''' </summary>
        ''' <param name="itemRequest"></param>
        ''' <returns></returns>
        Public Function ListarAperturasCompletadasSemana(ByVal itemRequest As List(Of DiseñoIndicadoresAperturaRequest)) As JsonResult
            Dim result = New DisenoContext().ListarAperturasCompletadasSemana(itemRequest(0))
            Return Json(result)
        End Function

        ''' <summary>
        ''' Lista Consultar
        ''' </summary>
        ''' <param name="itemRequest"></param>
        ''' <returns></returns>
        Public Function ListarPreprensasCompletadasSemana(ByVal itemRequest As List(Of DiseñoIndicadoresPreprensasRequest)) As JsonResult
            Dim result = New DisenoContext().ListarPreprensasCompletadasSemana(itemRequest(0))
            Return Json(result)
        End Function



    End Class
End Namespace

