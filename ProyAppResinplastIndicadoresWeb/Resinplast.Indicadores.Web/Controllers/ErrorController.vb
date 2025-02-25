Imports System.Web.Mvc

Namespace Resinplast.Indicadores.Web
    Public Class ErrorController
        Inherits Controller

        ' GET: Error
        Function Index() As ActionResult
            Return View()
        End Function

        ''' <summary>
        ''' Muestra la vista de acceso no permitido
        ''' </summary>
        ''' <returns>Vista de acceso no autorizado de la opción</returns>
        Function ErrorApplication() As ActionResult
            Return View()
        End Function

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <returns></returns>
        Function NotSession() As ActionResult
            Return View()
        End Function

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <returns></returns>
        Function NotFound() As ActionResult
            Return View()
        End Function

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <returns></returns>
        Function GatewayTimeout() As ActionResult
            Return View()
        End Function



    End Class

End Namespace

