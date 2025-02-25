Imports System.Configuration
Imports Resinplast.Indicadores.Domain
Imports Resinplast.Indicadores.Implementation.Service
Imports Resinplast.Indicadores.Utils
Imports Resinplast.Indicadores.Wrapper


Public Class DiseñoIndicadores
    Implements IDiseñoIndicadores

    Public oDiseñoIndicadoresAperturasDomain As New DiseñoIndicadoresAperturasDomain()
    Public oDiseñoIndicadoresPreprensasDomain As New DiseñoIndicadoresPreprensasDomain()

    Public Function ListarAperturasCompletadasPorUsuario(itemRequest As DiseñoIndicadoresAperturaRequest) As DiseñoIndicadoresAperturaResponse Implements IDiseñoIndicadores.ListarAperturasCompletadasPorUsuario
        EnumeratedGlobales.EntornoTrabajo = ConfigurationManager.AppSettings("EntornoTrabajo").ToString()

        Dim result As DiseñoIndicadoresAperturaResponse = New DiseñoIndicadoresAperturaResponse()
        Try
            oDiseñoIndicadoresAperturasDomain = New DiseñoIndicadoresAperturasDomain()
            result = oDiseñoIndicadoresAperturasDomain.ListarAperturasCompletadasPorUsuario(itemRequest)
        Catch ex As Exception
            result.CodigoError = Enumerated.ResponseCode.CodigoErrorAplicacion
            result.DescripcionError = ex.Message
        End Try

        Return result
    End Function

    Public Function ListarAperturasCompletadasSemana(itemRequest As DiseñoIndicadoresAperturaRequest) As DiseñoIndicadoresAperturaResponse Implements IDiseñoIndicadores.ListarAperturasCompletadasSemana
        EnumeratedGlobales.EntornoTrabajo = ConfigurationManager.AppSettings("EntornoTrabajo").ToString()

        Dim result As DiseñoIndicadoresAperturaResponse = New DiseñoIndicadoresAperturaResponse()
        Try
            oDiseñoIndicadoresAperturasDomain = New DiseñoIndicadoresAperturasDomain()
            result = oDiseñoIndicadoresAperturasDomain.ListarAperturasCompletadasSemana(itemRequest)
        Catch ex As Exception
            result.CodigoError = Enumerated.ResponseCode.CodigoErrorAplicacion
            result.DescripcionError = ex.Message
        End Try

        Return result
    End Function

    Public Function ListarAperturasDia(itemRequest As DiseñoIndicadoresAperturaRequest) As DiseñoIndicadoresAperturaResponse Implements IDiseñoIndicadores.ListarAperturasDia
        EnumeratedGlobales.EntornoTrabajo = ConfigurationManager.AppSettings("EntornoTrabajo").ToString()

        Dim result As DiseñoIndicadoresAperturaResponse = New DiseñoIndicadoresAperturaResponse()
        Try
            oDiseñoIndicadoresAperturasDomain = New DiseñoIndicadoresAperturasDomain()
            result = oDiseñoIndicadoresAperturasDomain.ListarAperturasDia(itemRequest)
        Catch ex As Exception
            result.CodigoError = Enumerated.ResponseCode.CodigoErrorAplicacion
            result.DescripcionError = ex.Message
        End Try

        Return result
    End Function

    Public Function ListarAperturasDiaDetalle(itemRequest As DiseñoIndicadoresAperturaRequest) As DiseñoIndicadoresAperturaResponse Implements IDiseñoIndicadores.ListarAperturasDiaDetalle
        EnumeratedGlobales.EntornoTrabajo = ConfigurationManager.AppSettings("EntornoTrabajo").ToString()

        Dim result As DiseñoIndicadoresAperturaResponse = New DiseñoIndicadoresAperturaResponse()
        Try
            oDiseñoIndicadoresAperturasDomain = New DiseñoIndicadoresAperturasDomain()
            result = oDiseñoIndicadoresAperturasDomain.ListarAperturasDiaDetalle(itemRequest)
        Catch ex As Exception
            result.CodigoError = Enumerated.ResponseCode.CodigoErrorAplicacion
            result.DescripcionError = ex.Message
        End Try

        Return result
    End Function

    Public Function ListarAperturasSemana(itemRequest As DiseñoIndicadoresAperturaRequest) As DiseñoIndicadoresAperturaResponse Implements IDiseñoIndicadores.ListarAperturasSemana
        EnumeratedGlobales.EntornoTrabajo = ConfigurationManager.AppSettings("EntornoTrabajo").ToString()

        Dim result As DiseñoIndicadoresAperturaResponse = New DiseñoIndicadoresAperturaResponse()
        Try
            oDiseñoIndicadoresAperturasDomain = New DiseñoIndicadoresAperturasDomain()
            result = oDiseñoIndicadoresAperturasDomain.ListarAperturasSemana(itemRequest)
        Catch ex As Exception
            result.CodigoError = Enumerated.ResponseCode.CodigoErrorAplicacion
            result.DescripcionError = ex.Message
        End Try

        Return result
    End Function

    Public Function ListarPrepensaDia(itemRequest As DiseñoIndicadoresPreprensasRequest) As DiseñoIndicadoresPreprensasResponse Implements IDiseñoIndicadores.ListarPrepensaDia
        EnumeratedGlobales.EntornoTrabajo = ConfigurationManager.AppSettings("EntornoTrabajo").ToString()

        Dim result As DiseñoIndicadoresPreprensasResponse = New DiseñoIndicadoresPreprensasResponse()
        Try
            oDiseñoIndicadoresPreprensasDomain = New DiseñoIndicadoresPreprensasDomain()
            result = oDiseñoIndicadoresPreprensasDomain.ListarPrepensaDia(itemRequest)
        Catch ex As Exception
            result.CodigoError = Enumerated.ResponseCode.CodigoErrorAplicacion
            result.DescripcionError = ex.Message
        End Try

        Return result
    End Function

    Public Function ListarPrepensaDiaPruebaColor(itemRequest As DiseñoIndicadoresPreprensasRequest) As DiseñoIndicadoresPreprensasResponse Implements IDiseñoIndicadores.ListarPrepensaDiaPruebaColor

        Dim result As DiseñoIndicadoresPreprensasResponse = New DiseñoIndicadoresPreprensasResponse()
        Try
            oDiseñoIndicadoresPreprensasDomain = New DiseñoIndicadoresPreprensasDomain()
            result = oDiseñoIndicadoresPreprensasDomain.ListarPrepensaDiaPruebaColor(itemRequest)
        Catch ex As Exception
            result.CodigoError = Enumerated.ResponseCode.CodigoErrorAplicacion
            result.DescripcionError = ex.Message
        End Try

        Return result
    End Function

    Public Function ListarPreprensaDiaDetalle(itemRequest As DiseñoIndicadoresPreprensasRequest) As DiseñoIndicadoresPreprensasResponse Implements IDiseñoIndicadores.ListarPreprensaDiaDetalle
        EnumeratedGlobales.EntornoTrabajo = ConfigurationManager.AppSettings("EntornoTrabajo").ToString()

        Dim result As DiseñoIndicadoresPreprensasResponse = New DiseñoIndicadoresPreprensasResponse()
        Try
            oDiseñoIndicadoresPreprensasDomain = New DiseñoIndicadoresPreprensasDomain()
            result = oDiseñoIndicadoresPreprensasDomain.ListarPreprensaDiaDetalle(itemRequest)
        Catch ex As Exception
            result.CodigoError = Enumerated.ResponseCode.CodigoErrorAplicacion
            result.DescripcionError = ex.Message
        End Try

        Return result
    End Function

    Public Function ListarPreprensasCompletadasSemana(itemRequest As DiseñoIndicadoresPreprensasRequest) As DiseñoIndicadoresPreprensasResponse Implements IDiseñoIndicadores.ListarPreprensasCompletadasSemana
        EnumeratedGlobales.EntornoTrabajo = ConfigurationManager.AppSettings("EntornoTrabajo").ToString()

        Dim result As DiseñoIndicadoresPreprensasResponse = New DiseñoIndicadoresPreprensasResponse()
        Try
            oDiseñoIndicadoresPreprensasDomain = New DiseñoIndicadoresPreprensasDomain()
            result = oDiseñoIndicadoresPreprensasDomain.ListarPreprensasCompletadasSemana(itemRequest)
        Catch ex As Exception
            result.CodigoError = Enumerated.ResponseCode.CodigoErrorAplicacion
            result.DescripcionError = ex.Message
        End Try

        Return result
    End Function

    Public Function ListarPreprensasSemana(itemRequest As DiseñoIndicadoresPreprensasRequest) As DiseñoIndicadoresPreprensasResponse Implements IDiseñoIndicadores.ListarPreprensasSemana
        EnumeratedGlobales.EntornoTrabajo = ConfigurationManager.AppSettings("EntornoTrabajo").ToString()

        Dim result As DiseñoIndicadoresPreprensasResponse = New DiseñoIndicadoresPreprensasResponse()
        Try
            oDiseñoIndicadoresPreprensasDomain = New DiseñoIndicadoresPreprensasDomain()
            result = oDiseñoIndicadoresPreprensasDomain.ListarPreprensasSemana(itemRequest)
        Catch ex As Exception
            result.CodigoError = Enumerated.ResponseCode.CodigoErrorAplicacion
            result.DescripcionError = ex.Message
        End Try

        Return result
    End Function
End Class
