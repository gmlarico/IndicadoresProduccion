Imports System.Web.Mvc
Imports Newtonsoft.Json
Imports Resinplast.Indicadores.Wrapper
Imports Resinplast.Indicadores.Web.Models
Imports Resinplast.Indicadores.Web.Models.Base
Imports Resinplast.Indicadores.Utils

Namespace Resinplast.Indicadores.Web
    Public Class ImpresionController
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
        Public Function ListaIndicadoresSetUpTotal(ByVal itemRequest As List(Of ImpresionIndicadoresSetUpRequest)) As JsonResult
            Dim result = New ImpresionContext().ListaIndicadoresSetUpTotal(itemRequest(0))
            Return Json(result)
        End Function

        ''' <summary>
        ''' Lista Consultar
        ''' </summary>
        ''' <param name="itemRequest"></param>
        ''' <returns></returns>
        Public Function ListaIndicadoresSetUpIndividual(ByVal itemRequest As List(Of ImpresionIndicadoresSetUpRequest)) As JsonResult
            Dim result = New ImpresionContext().ListaIndicadoresSetUpIndividual(itemRequest(0))
            Return Json(result)
        End Function


        ''' <summary>
        ''' Lista Consultar
        ''' </summary>
        ''' <param name="itemRequest"></param>
        ''' <returns></returns>
        Public Function ListaIndicadoresSetUpConHeptacromia(ByVal itemRequest As List(Of ImpresionIndicadoresSetUpRequest)) As JsonResult
            Dim result = New ImpresionContext().ListaIndicadoresSetUpConHeptacromia(itemRequest(0))
            Return Json(result)
        End Function


        ''' <summary>
        ''' Lista Consultar
        ''' </summary>
        ''' <param name="itemRequest"></param>
        ''' <returns></returns>
        Public Function ListaIndicadoresSetUpSinHeptacromiaTotal(ByVal itemRequest As List(Of ImpresionIndicadoresSetUpRequest)) As JsonResult
            Dim result = New ImpresionContext().ListaIndicadoresSetUpSinHeptacromiaTotal(itemRequest(0))
            Return Json(result)
        End Function

        ''' <summary>
        ''' Lista Consultar
        ''' </summary>
        ''' <param name="itemRequest"></param>
        ''' <returns></returns>
        Public Function ListaIndicadoresSetUpSinHeptacromiaIndividual(ByVal itemRequest As List(Of ImpresionIndicadoresSetUpRequest)) As JsonResult
            Dim result = New ImpresionContext().ListaIndicadoresSetUpSinHeptacromiaIndividual(itemRequest(0))
            Return Json(result)
        End Function

        ''' <summary>
        ''' Lista Consultar
        ''' </summary>
        ''' <param name="itemRequest"></param>
        ''' <returns></returns>
        Public Function ListaIndicadoresVelocidadTotales(ByVal itemRequest As List(Of ImpresionIndicadoresVelocidadRequest)) As JsonResult
            Dim result = New ImpresionContext().ListaIndicadoresVelocidadTotales(itemRequest(0))
            Return Json(result)
        End Function

        ''' <summary>
        ''' Lista Consultar
        ''' </summary>
        ''' <param name="itemRequest"></param>
        ''' <returns></returns>
        Public Function ListaIndicadoresVelocidadIndividuales(ByVal itemRequest As List(Of ImpresionIndicadoresVelocidadRequest)) As JsonResult
            Dim result = New ImpresionContext().ListaIndicadoresVelocidadIndividuales(itemRequest(0))
            Return Json(result)
        End Function

        ''' <summary>
        ''' Lista Consultar
        ''' </summary>
        ''' <param name="itemRequest"></param>
        ''' <returns></returns>
        Public Function ListaIndicadoresMetrosTotales(ByVal itemRequest As List(Of ImpresionIndicadoresMetrosRequest)) As JsonResult
            Dim result = New ImpresionContext().ListaIndicadoresMetrosTotales(itemRequest(0))
            Return Json(result)
        End Function

        ''' <summary>
        ''' Lista Consultar
        ''' </summary>
        ''' <param name="itemRequest"></param>
        ''' <returns></returns>
        Public Function ListaIndicadoresMetrosIndividuales(ByVal itemRequest As List(Of ImpresionIndicadoresMetrosRequest)) As JsonResult
            Dim result = New ImpresionContext().ListaIndicadoresMetrosIndividuales(itemRequest(0))
            Return Json(result)
        End Function


        ''' <summary>
        ''' Lista Consultar
        ''' </summary>
        ''' <param name="itemRequest"></param>
        ''' <returns></returns>
        Public Function ListaIndicadoresScrapTotales(ByVal itemRequest As List(Of ImpresionIndicadoresScrapRequest)) As JsonResult
            Dim result = New ImpresionContext().ListaIndicadoresScrapTotales(itemRequest(0))
            Return Json(result)
        End Function


        ''' <summary>
        ''' Lista Consultar
        ''' </summary>
        ''' <param name="itemRequest"></param>
        ''' <returns></returns>
        Public Function ListaIndicadoresScrapIndividuales(ByVal itemRequest As List(Of ImpresionIndicadoresScrapRequest)) As JsonResult
            Dim result = New ImpresionContext().ListaIndicadoresScrapIndividuales(itemRequest(0))
            Return Json(result)
        End Function

    End Class
End Namespace

