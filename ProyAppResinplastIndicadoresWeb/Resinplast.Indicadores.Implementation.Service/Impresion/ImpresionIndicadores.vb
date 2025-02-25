Imports System.Configuration
Imports Resinplast.Indicadores.Domain
Imports Resinplast.Indicadores.Implementation.Service
Imports Resinplast.Indicadores.Utils
Imports Resinplast.Indicadores.Wrapper
Public Class ImpresionIndicadores
    Implements IImpresionIndicadores

    Public oImpresionIndicadoresMetrosDomain As New ImpresionIndicadoresMetrosDomain()
    Public oImpresionIndicadoresScrapDomain As New ImpresionIndicadoresScrapDomain()
    Public oImpresionIndicadoresSetUpDomain As New ImpresionIndicadoresSetUpDomain()
    Public oImpresionIndicadoresVelocidadDomain As New ImpresionIndicadoresVelocidadDomain()


    Public Function ListaIndicadoresMetrosIndividuales(itemRequest As ImpresionIndicadoresMetrosRequest) As ImpresionIndicadoresMetrosResponse Implements IImpresionIndicadores.ListaIndicadoresMetrosIndividuales
        EnumeratedGlobales.EntornoTrabajo = ConfigurationManager.AppSettings("EntornoTrabajo").ToString()

        Dim result As ImpresionIndicadoresMetrosResponse = New ImpresionIndicadoresMetrosResponse()

        Try
            oImpresionIndicadoresMetrosDomain = New ImpresionIndicadoresMetrosDomain()
            result = oImpresionIndicadoresMetrosDomain.ListaIndicadoresMetrosIndividuales(itemRequest)
        Catch ex As Exception
            result.CodigoError = Enumerated.ResponseCode.CodigoErrorAplicacion
            result.DescripcionError = ex.Message
        End Try
        Return result

    End Function

    Public Function ListaIndicadoresMetrosTotales(itemRequest As ImpresionIndicadoresMetrosRequest) As ImpresionIndicadoresMetrosResponse Implements IImpresionIndicadores.ListaIndicadoresMetrosTotales
        EnumeratedGlobales.EntornoTrabajo = ConfigurationManager.AppSettings("EntornoTrabajo").ToString()

        Dim result As ImpresionIndicadoresMetrosResponse = New ImpresionIndicadoresMetrosResponse()

        Try
            oImpresionIndicadoresMetrosDomain = New ImpresionIndicadoresMetrosDomain()
            result = oImpresionIndicadoresMetrosDomain.ListaIndicadoresMetrosTotales(itemRequest)
        Catch ex As Exception
            result.CodigoError = Enumerated.ResponseCode.CodigoErrorAplicacion
            result.DescripcionError = ex.Message
        End Try
        Return result
    End Function

    Public Function ListaIndicadoresScrapIndividuales(itemRequest As ImpresionIndicadoresScrapRequest) As ImpresionIndicadoresScrapResponse Implements IImpresionIndicadores.ListaIndicadoresScrapIndividuales
        EnumeratedGlobales.EntornoTrabajo = ConfigurationManager.AppSettings("EntornoTrabajo").ToString()

        Dim result As ImpresionIndicadoresScrapResponse = New ImpresionIndicadoresScrapResponse()

        Try
            oImpresionIndicadoresScrapDomain = New ImpresionIndicadoresScrapDomain()
            result = oImpresionIndicadoresScrapDomain.ListaIndicadoresScrapIndividuales(itemRequest)
        Catch ex As Exception
            result.CodigoError = Enumerated.ResponseCode.CodigoErrorAplicacion
            result.DescripcionError = ex.Message
        End Try
        Return result
    End Function

    Public Function ListaIndicadoresScrapTotales(itemRequest As ImpresionIndicadoresScrapRequest) As ImpresionIndicadoresScrapResponse Implements IImpresionIndicadores.ListaIndicadoresScrapTotales
        EnumeratedGlobales.EntornoTrabajo = ConfigurationManager.AppSettings("EntornoTrabajo").ToString()

        Dim result As ImpresionIndicadoresScrapResponse = New ImpresionIndicadoresScrapResponse()

        Try
            oImpresionIndicadoresScrapDomain = New ImpresionIndicadoresScrapDomain()
            result = oImpresionIndicadoresScrapDomain.ListaIndicadoresScrapTotales(itemRequest)
        Catch ex As Exception
            result.CodigoError = Enumerated.ResponseCode.CodigoErrorAplicacion
            result.DescripcionError = ex.Message
        End Try
        Return result
    End Function

    Public Function ListaIndicadoresSetUpConHeptacromia(itemRequest As ImpresionIndicadoresSetUpRequest) As ImpresionIndicadoresSetUpResponse Implements IImpresionIndicadores.ListaIndicadoresSetUpConHeptacromia
        EnumeratedGlobales.EntornoTrabajo = ConfigurationManager.AppSettings("EntornoTrabajo").ToString()

        Dim result As ImpresionIndicadoresSetUpResponse = New ImpresionIndicadoresSetUpResponse()

        Try
            oImpresionIndicadoresSetUpDomain = New ImpresionIndicadoresSetUpDomain()
            result = oImpresionIndicadoresSetUpDomain.ListaIndicadoresSetUpConHeptacromia(itemRequest)
        Catch ex As Exception
            result.CodigoError = Enumerated.ResponseCode.CodigoErrorAplicacion
            result.DescripcionError = ex.Message
        End Try
        Return result
    End Function

    Public Function ListaIndicadoresSetUpIndividual(itemRequest As ImpresionIndicadoresSetUpRequest) As ImpresionIndicadoresSetUpResponse Implements IImpresionIndicadores.ListaIndicadoresSetUpIndividual
        EnumeratedGlobales.EntornoTrabajo = ConfigurationManager.AppSettings("EntornoTrabajo").ToString()

        Dim result As ImpresionIndicadoresSetUpResponse = New ImpresionIndicadoresSetUpResponse()

        Try
            oImpresionIndicadoresSetUpDomain = New ImpresionIndicadoresSetUpDomain()
            result = oImpresionIndicadoresSetUpDomain.ListaIndicadoresSetUpIndividual(itemRequest)
        Catch ex As Exception
            result.CodigoError = Enumerated.ResponseCode.CodigoErrorAplicacion
            result.DescripcionError = ex.Message
        End Try
        Return result
    End Function

    Public Function ListaIndicadoresSetUpSinHeptacromiaIndividual(itemRequest As ImpresionIndicadoresSetUpRequest) As ImpresionIndicadoresSetUpResponse Implements IImpresionIndicadores.ListaIndicadoresSetUpSinHeptacromiaIndividual
        EnumeratedGlobales.EntornoTrabajo = ConfigurationManager.AppSettings("EntornoTrabajo").ToString()

        Dim result As ImpresionIndicadoresSetUpResponse = New ImpresionIndicadoresSetUpResponse()

        Try
            oImpresionIndicadoresSetUpDomain = New ImpresionIndicadoresSetUpDomain()
            result = oImpresionIndicadoresSetUpDomain.ListaIndicadoresSetUpSinHeptacromiaIndividual(itemRequest)
        Catch ex As Exception
            result.CodigoError = Enumerated.ResponseCode.CodigoErrorAplicacion
            result.DescripcionError = ex.Message
        End Try
        Return result
    End Function

    Public Function ListaIndicadoresSetUpSinHeptacromiaTotal(itemRequest As ImpresionIndicadoresSetUpRequest) As ImpresionIndicadoresSetUpResponse Implements IImpresionIndicadores.ListaIndicadoresSetUpSinHeptacromiaTotal
        EnumeratedGlobales.EntornoTrabajo = ConfigurationManager.AppSettings("EntornoTrabajo").ToString()

        Dim result As ImpresionIndicadoresSetUpResponse = New ImpresionIndicadoresSetUpResponse()

        Try
            oImpresionIndicadoresSetUpDomain = New ImpresionIndicadoresSetUpDomain()
            result = oImpresionIndicadoresSetUpDomain.ListaIndicadoresSetUpSinHeptacromiaTotal(itemRequest)
        Catch ex As Exception
            result.CodigoError = Enumerated.ResponseCode.CodigoErrorAplicacion
            result.DescripcionError = ex.Message
        End Try
        Return result
    End Function

    Public Function ListaIndicadoresSetUpTotal(itemRequest As ImpresionIndicadoresSetUpRequest) As ImpresionIndicadoresSetUpResponse Implements IImpresionIndicadores.ListaIndicadoresSetUpTotal
        EnumeratedGlobales.EntornoTrabajo = ConfigurationManager.AppSettings("EntornoTrabajo").ToString()

        Dim result As ImpresionIndicadoresSetUpResponse = New ImpresionIndicadoresSetUpResponse()

        Try
            oImpresionIndicadoresSetUpDomain = New ImpresionIndicadoresSetUpDomain()
            result = oImpresionIndicadoresSetUpDomain.ListaIndicadoresSetUpTotal(itemRequest)
        Catch ex As Exception
            result.CodigoError = Enumerated.ResponseCode.CodigoErrorAplicacion
            result.DescripcionError = ex.Message
        End Try
        Return result
    End Function

    Public Function ListaIndicadoresVelocidadIndividuales(itemRequest As ImpresionIndicadoresVelocidadRequest) As ImpresionIndicadoresVelocidadResponse Implements IImpresionIndicadores.ListaIndicadoresVelocidadIndividuales
        EnumeratedGlobales.EntornoTrabajo = ConfigurationManager.AppSettings("EntornoTrabajo").ToString()

        Dim result As ImpresionIndicadoresVelocidadResponse = New ImpresionIndicadoresVelocidadResponse()

        Try
            oImpresionIndicadoresVelocidadDomain = New ImpresionIndicadoresVelocidadDomain()
            result = oImpresionIndicadoresVelocidadDomain.ListaIndicadoresVelocidadIndividuales(itemRequest)
        Catch ex As Exception
            result.CodigoError = Enumerated.ResponseCode.CodigoErrorAplicacion
            result.DescripcionError = ex.Message
        End Try
        Return result
    End Function

    Public Function ListaIndicadoresVelocidadTotales(itemRequest As ImpresionIndicadoresVelocidadRequest) As ImpresionIndicadoresVelocidadResponse Implements IImpresionIndicadores.ListaIndicadoresVelocidadTotales
        EnumeratedGlobales.EntornoTrabajo = ConfigurationManager.AppSettings("EntornoTrabajo").ToString()

        Dim result As ImpresionIndicadoresVelocidadResponse = New ImpresionIndicadoresVelocidadResponse()

        Try
            oImpresionIndicadoresVelocidadDomain = New ImpresionIndicadoresVelocidadDomain()
            result = oImpresionIndicadoresVelocidadDomain.ListaIndicadoresVelocidadTotales(itemRequest)
        Catch ex As Exception
            result.CodigoError = Enumerated.ResponseCode.CodigoErrorAplicacion
            result.DescripcionError = ex.Message
        End Try
        Return result
    End Function
End Class
