Imports Resinplast.Indicadores.Utils
Imports Resinplast.Indicadores.Wrapper
Imports Resinplast.Indicadores.Web.Models.Base
Imports Resinplast.Indicadores.Web.Models

Public Class ImpresionContext
    Private oImpresionIndicadoresService As ImpresionIndicadoresService.ImpresionIndicadoresClient = Nothing


    ''' <summary>
    ''' Listar Aperturas Dia y detalle
    ''' </summary>
    ''' <param name="itemRequest"></param>
    ''' <returns></returns>
    Public Function ListaIndicadoresSetUpTotal(ByVal itemRequest As ImpresionIndicadoresSetUpRequest) As List(Of ImpresionIndicadoresSetUpEL)

        Dim result As List(Of ImpresionIndicadoresSetUpEL) = New List(Of ImpresionIndicadoresSetUpEL)()

        Try

            oImpresionIndicadoresService = New ImpresionIndicadoresService.ImpresionIndicadoresClient()

            Dim ListarSetUpTotal = oImpresionIndicadoresService.ListaIndicadoresSetUpTotal(New ImpresionIndicadoresService.ImpresionIndicadoresSetUpRequest With {
                                                                                                                            .BuscarFechaInicio = itemRequest.BuscarFechaInicio,
                                                                                                                            .BuscarFechaFin = itemRequest.BuscarFechaFin
                                                                                                                                                                         })



            oImpresionIndicadoresService.Close()



            Dim ListSetUpTotal = ListarSetUpTotal.ListaIndicadoresSetUp

            If ListSetUpTotal.Count > 0 Then

                For Each item As ImpresionIndicadoresService.ImpresionIndicadoresSetUpEL In ListSetUpTotal

                    result.Add(New ImpresionIndicadoresSetUpEL() With {
                                                    .Año = item.Año,
                                                    .Mes = item.Mes,
                                                    .DescripcionFecha = ConvertMes(item.Mes) & " " & (item.Año).Substring(2),
                                                    .NumeroCambios = item.NumeroCambios,
                                                    .SetUpPromedio = item.SetUpPromedio,
                                                    .SetUpObjetivo = item.SetUpObjetivo
                                             })

                Next

            End If



        Catch ex As Exception

            'result.ErrorCode = Enumerated.ResponseCode.CodigoErrorAplicacion
            'result.ErrorDescription = ex.Message
        End Try

        Return result
    End Function


    ''' <summary>
    ''' Listar Aperturas Dia y detalle
    ''' </summary>
    ''' <param name="itemRequest"></param>
    ''' <returns></returns>
    Public Function ListaIndicadoresSetUpIndividual(ByVal itemRequest As ImpresionIndicadoresSetUpRequest) As List(Of ImpresionIndicadoresSetUpEL)

        Dim result As List(Of ImpresionIndicadoresSetUpEL) = New List(Of ImpresionIndicadoresSetUpEL)()

        Try

            oImpresionIndicadoresService = New ImpresionIndicadoresService.ImpresionIndicadoresClient()

            Dim ListarSetUpIndividuales = oImpresionIndicadoresService.ListaIndicadoresSetUpIndividual(New ImpresionIndicadoresService.ImpresionIndicadoresSetUpRequest With {
                                                                                                                        .TipoRecurso = itemRequest.TipoRecurso,
                                                                                                                        .BuscarFechaInicio = itemRequest.BuscarFechaInicio,
                                                                                                                        .BuscarFechaFin = itemRequest.BuscarFechaFin
                                                                                                                         })

            oImpresionIndicadoresService.Close()



            Dim ListSetUpIndividual = ListarSetUpIndividuales.ListaIndicadoresSetUp

            If ListSetUpIndividual.Count > 0 Then

                For Each item As ImpresionIndicadoresService.ImpresionIndicadoresSetUpEL In ListSetUpIndividual

                    result.Add(New ImpresionIndicadoresSetUpEL() With {
                                                    .IdRecurso = item.IdRecurso,
                                                    .Año = item.Año,
                                                    .Mes = item.Mes,
                                                    .DescripcionFecha = ConvertMes(item.Mes) & " " & (item.Año).Substring(2),
                                                    .NumeroCambios = item.NumeroCambios,
                                                    .SetUpPromedio = item.SetUpPromedio,
                                                    .SetUpObjetivo = item.SetUpObjetivo
                                             })

                Next

            End If



        Catch ex As Exception

            'result.ErrorCode = Enumerated.ResponseCode.CodigoErrorAplicacion
            'result.ErrorDescription = ex.Message
        End Try

        Return result
    End Function

    ''' <summary>
    ''' Listar Aperturas Dia y detalle
    ''' </summary>
    ''' <param name="itemRequest"></param>
    ''' <returns></returns>
    Public Function ListaIndicadoresSetUpConHeptacromia(ByVal itemRequest As ImpresionIndicadoresSetUpRequest) As List(Of ImpresionIndicadoresSetUpEL)

        Dim result As List(Of ImpresionIndicadoresSetUpEL) = New List(Of ImpresionIndicadoresSetUpEL)()

        Try

            oImpresionIndicadoresService = New ImpresionIndicadoresService.ImpresionIndicadoresClient()

            Dim ListarSetUpConHeptacromia = oImpresionIndicadoresService.ListaIndicadoresSetUpConHeptacromia(New ImpresionIndicadoresService.ImpresionIndicadoresSetUpRequest With {
                                                                                                          .BuscarFechaFin = itemRequest.BuscarFechaFin,
                                                                                                          .BuscarFechaInicio = itemRequest.BuscarFechaInicio
                                                                                                           })

            oImpresionIndicadoresService.Close()


            Dim ListSetUpConHeptacromia = ListarSetUpConHeptacromia.ListaIndicadoresSetUpConHeptacromia

            If ListSetUpConHeptacromia.Count > 0 Then

                For Each item As ImpresionIndicadoresService.ImpresionIndicadoresSetUpEL In ListSetUpConHeptacromia

                    result.Add(New ImpresionIndicadoresSetUpEL() With {
                                                    .IdRecurso = IIf(item.IdRecurso = "FX09", "FX07", "FX08"),
                                                    .Año = item.Año,
                                                    .Mes = item.Mes,
                                                    .DescripcionFecha = ConvertMes(item.Mes) & " " & (item.Año).Substring(2),
                                                    .NumeroCambios = 0,
                                                    .SetUpPromedioHeptacromia = 0,
                                                    .SetUpObjetivoHeptacromia = 0
                                             })

                Next

                For Each item As ImpresionIndicadoresService.ImpresionIndicadoresSetUpEL In ListSetUpConHeptacromia

                    result.Add(New ImpresionIndicadoresSetUpEL() With {
                                                    .IdRecurso = item.IdRecurso,
                                                    .Año = item.Año,
                                                    .Mes = item.Mes,
                                                    .DescripcionFecha = ConvertMes(item.Mes) & " " & (item.Año).Substring(2),
                                                    .NumeroCambios = item.NumeroCambios,
                                                    .SetUpPromedioHeptacromia = item.SetUpPromedioHeptacromia,
                                                    .SetUpObjetivoHeptacromia = item.SetUpObjetivoHeptacromia
                                             })

                Next

            End If



        Catch ex As Exception

            'result.ErrorCode = Enumerated.ResponseCode.CodigoErrorAplicacion
            'result.ErrorDescription = ex.Message
        End Try

        Return result
    End Function

    ''' <summary>
    ''' Listar Aperturas Dia y detalle
    ''' </summary>
    ''' <param name="itemRequest"></param>
    ''' <returns></returns>
    Public Function ListaIndicadoresSetUpSinHeptacromiaTotal(ByVal itemRequest As ImpresionIndicadoresSetUpRequest) As List(Of ImpresionIndicadoresSetUpEL)

        Dim result As List(Of ImpresionIndicadoresSetUpEL) = New List(Of ImpresionIndicadoresSetUpEL)()

        Try

            oImpresionIndicadoresService = New ImpresionIndicadoresService.ImpresionIndicadoresClient()

            Dim ListarSetUpSinHeptacromia = oImpresionIndicadoresService.ListaIndicadoresSetUpSinHeptacromiaTotal(New ImpresionIndicadoresService.ImpresionIndicadoresSetUpRequest With {
                                                                                                                .BuscarFechaInicio = itemRequest.BuscarFechaInicio,
                                                                                                                .BuscarFechaFin = itemRequest.BuscarFechaFin
                                                                                                                })

            oImpresionIndicadoresService.Close()


            Dim ListSetUpSinHeptacromia = ListarSetUpSinHeptacromia.ListaIndicadoresSetUpSinHeptacromia

            If ListSetUpSinHeptacromia.Count > 0 Then

                For Each item As ImpresionIndicadoresService.ImpresionIndicadoresSetUpEL In ListSetUpSinHeptacromia

                    result.Add(New ImpresionIndicadoresSetUpEL() With {
                                                    .Año = item.Año,
                                                    .Mes = item.Mes,
                                                    .DescripcionFecha = ConvertMes(item.Mes) & " " & (item.Año).Substring(2),
                                                    .NumeroCambios = item.NumeroCambios,
                                                    .SetUpPromedioSinHeptacromia = item.SetUpPromedioSinHeptacromia,
                                                    .SetUpObjetivoSinHeptacromia = item.SetUpObjetivoSinHeptacromia
                                             })

                Next

            End If



        Catch ex As Exception

            'result.ErrorCode = Enumerated.ResponseCode.CodigoErrorAplicacion
            'result.ErrorDescription = ex.Message
        End Try

        Return result
    End Function



    ''' <summary>
    ''' Listar Aperturas Dia y detalle
    ''' </summary>
    ''' <param name="itemRequest"></param>
    ''' <returns></returns>
    Public Function ListaIndicadoresSetUpSinHeptacromiaIndividual(ByVal itemRequest As ImpresionIndicadoresSetUpRequest) As List(Of ImpresionIndicadoresSetUpEL)

        Dim result As List(Of ImpresionIndicadoresSetUpEL) = New List(Of ImpresionIndicadoresSetUpEL)()

        Try

            oImpresionIndicadoresService = New ImpresionIndicadoresService.ImpresionIndicadoresClient()



            Dim ListarSetUpSinHeptacromia = oImpresionIndicadoresService.ListaIndicadoresSetUpSinHeptacromiaIndividual(New ImpresionIndicadoresService.ImpresionIndicadoresSetUpRequest With {
                                                                                                                            .TipoRecurso = itemRequest.TipoRecurso,
                                                                                                                            .BuscarFechaInicio = itemRequest.BuscarFechaInicio,
                                                                                                                            .BuscarFechaFin = itemRequest.BuscarFechaFin
                                                                                                                                        })


            oImpresionIndicadoresService.Close()


            Dim ListSetUpSinHeptacromia = ListarSetUpSinHeptacromia.ListaIndicadoresSetUpSinHeptacromia

            If ListSetUpSinHeptacromia.Count > 0 Then

                For Each item As ImpresionIndicadoresService.ImpresionIndicadoresSetUpEL In ListSetUpSinHeptacromia

                    result.Add(New ImpresionIndicadoresSetUpEL() With {
                                                    .IdRecurso = item.IdRecurso,
                                                    .Año = item.Año,
                                                    .Mes = item.Mes,
                                                    .DescripcionFecha = ConvertMes(item.Mes) & " " & (item.Año).Substring(2),
                                                    .NumeroCambios = item.NumeroCambios,
                                                    .SetUpPromedioSinHeptacromia = item.SetUpPromedioSinHeptacromia,
                                                    .SetUpObjetivoSinHeptacromia = item.SetUpObjetivoSinHeptacromia
                                             })

                Next

            End If



        Catch ex As Exception

            'result.ErrorCode = Enumerated.ResponseCode.CodigoErrorAplicacion
            'result.ErrorDescription = ex.Message
        End Try

        Return result
    End Function


    ''' <summary>
    ''' Listar Aperturas Dia y detalle
    ''' </summary>
    ''' <param name="itemRequest"></param>
    ''' <returns></returns>
    Public Function ListaIndicadoresVelocidadTotales(ByVal itemRequest As ImpresionIndicadoresVelocidadRequest) As List(Of ImpresionIndicadoresVelocidadEL)

        Dim result As List(Of ImpresionIndicadoresVelocidadEL) = New List(Of ImpresionIndicadoresVelocidadEL)()

        Try

            oImpresionIndicadoresService = New ImpresionIndicadoresService.ImpresionIndicadoresClient()

            Dim ListarVelocidadTotales = oImpresionIndicadoresService.ListaIndicadoresVelocidadTotales(New ImpresionIndicadoresService.ImpresionIndicadoresVelocidadRequest With {
                                                                                                                  .BuscarFechaFin = itemRequest.BuscarFechaFin,
                                                                                                                  .BuscarFechaInicio = itemRequest.BuscarFechaInicio
                                                                                                                                            })

            oImpresionIndicadoresService.Close()


            Dim ListVelocidadTotales = ListarVelocidadTotales.ListaIndicadoresVelocidad

            If ListVelocidadTotales.Count > 0 Then

                For Each item As ImpresionIndicadoresService.ImpresionIndicadoresVelocidadEL In ListVelocidadTotales

                    result.Add(New ImpresionIndicadoresVelocidadEL() With {
                                                    .Año = item.Año,
                                                    .Mes = item.Mes,
                                                    .SumaMetros = item.SumaMetros,
                                                    .SumaHoras = item.SumaHoras,
                                                    .VelocidadTotal = item.VelocidadTotal,
                                                    .VelocidadEfectiva = item.VelocidadEfectiva,
                                                    .VelocidadObjetivo = item.VelocidadObjetivo,
                                                    .DescripcionFecha = ConvertMes(item.Mes) & " " & (item.Año).Substring(2)
                                             })

                Next

            End If



        Catch ex As Exception

            'result.ErrorCode = Enumerated.ResponseCode.CodigoErrorAplicacion
            'result.ErrorDescription = ex.Message
        End Try

        Return result
    End Function


    ''' <summary>
    ''' Listar Aperturas Dia y detalle
    ''' </summary>
    ''' <param name="itemRequest"></param>
    ''' <returns></returns>
    Public Function ListaIndicadoresVelocidadIndividuales(ByVal itemRequest As ImpresionIndicadoresVelocidadRequest) As List(Of ImpresionIndicadoresVelocidadEL)

        Dim result As List(Of ImpresionIndicadoresVelocidadEL) = New List(Of ImpresionIndicadoresVelocidadEL)()

        Try

            oImpresionIndicadoresService = New ImpresionIndicadoresService.ImpresionIndicadoresClient()

            Dim ListarVelocidadIndividuales = oImpresionIndicadoresService.ListaIndicadoresVelocidadIndividuales(New ImpresionIndicadoresService.ImpresionIndicadoresVelocidadRequest With {
                                                                                                                            .TipoRecurso = itemRequest.TipoRecurso,
                                                                                                                            .BuscarFechaFin = itemRequest.BuscarFechaFin,
                                                                                                                            .BuscarFechaInicio = itemRequest.BuscarFechaInicio
                                                                                                                                            })


            oImpresionIndicadoresService.Close()


            Dim ListVelocidadIndividuales = ListarVelocidadIndividuales.ListaIndicadoresVelocidad

            If ListVelocidadIndividuales.Count > 0 Then

                For Each item As ImpresionIndicadoresService.ImpresionIndicadoresVelocidadEL In ListVelocidadIndividuales

                    result.Add(New ImpresionIndicadoresVelocidadEL() With {
                                                    .IdRecurso = item.IdRecurso,
                                                    .Año = item.Año,
                                                    .Mes = item.Mes,
                                                    .SumaMetros = item.SumaMetros,
                                                    .SumaHoras = item.SumaHoras,
                                                    .VelocidadTotal = item.VelocidadTotal,
                                                    .VelocidadEfectiva = item.VelocidadEfectiva,
                                                    .VelocidadObjetivo = item.VelocidadObjetivo,
                                                    .DescripcionFecha = ConvertMes(item.Mes) & " " & (item.Año).Substring(2)
                                             })

                Next

            End If



        Catch ex As Exception

            'result.ErrorCode = Enumerated.ResponseCode.CodigoErrorAplicacion
            'result.ErrorDescription = ex.Message
        End Try

        Return result
    End Function


    ''' <summary>
    ''' Listar Aperturas Dia y detalle
    ''' </summary>
    ''' <param name="itemRequest"></param>
    ''' <returns></returns>
    Public Function ListaIndicadoresMetrosTotales(ByVal itemRequest As ImpresionIndicadoresMetrosRequest) As List(Of ImpresionIndicadoresMetrosEL)

        Dim result As List(Of ImpresionIndicadoresMetrosEL) = New List(Of ImpresionIndicadoresMetrosEL)()

        Try

            oImpresionIndicadoresService = New ImpresionIndicadoresService.ImpresionIndicadoresClient()

            Dim ListarMetrosTotales = oImpresionIndicadoresService.ListaIndicadoresMetrosTotales(New ImpresionIndicadoresService.ImpresionIndicadoresMetrosRequest With {
                                                                                                            .BuscarFechaFin = itemRequest.BuscarFechaFin,
                                                                                                                  .BuscarFechaInicio = itemRequest.BuscarFechaInicio
                                                                                                                                            })

            oImpresionIndicadoresService.Close()


            Dim ListMetrosTotales = ListarMetrosTotales.ListaProduccionMetros

            If ListMetrosTotales.Count > 0 Then

                For Each item As ImpresionIndicadoresService.ImpresionIndicadoresMetrosEL In ListMetrosTotales

                    result.Add(New ImpresionIndicadoresMetrosEL() With {
                                                    .Año = item.Año,
                                                    .Mes = item.Mes,
                                                    .ProduccionMetrosMiles = item.ProduccionMetrosMiles,
                                                    .MetrosObjetivos = item.MetrosObjetivos,
                                                    .MetrosCumplidos = item.MetrosCumplidos,
                                                    .DescripcionFecha = ConvertMes(item.Mes) & " " & (item.Año).Substring(2)
                                             })

                Next

            End If



        Catch ex As Exception

            'result.ErrorCode = Enumerated.ResponseCode.CodigoErrorAplicacion
            'result.ErrorDescription = ex.Message
        End Try

        Return result
    End Function


    ''' <summary>
    ''' Listar Aperturas Dia y detalle
    ''' </summary>
    ''' <param name="itemRequest"></param>
    ''' <returns></returns>
    Public Function ListaIndicadoresMetrosIndividuales(ByVal itemRequest As ImpresionIndicadoresMetrosRequest) As List(Of ImpresionIndicadoresMetrosEL)

        Dim result As List(Of ImpresionIndicadoresMetrosEL) = New List(Of ImpresionIndicadoresMetrosEL)()

        Try

            oImpresionIndicadoresService = New ImpresionIndicadoresService.ImpresionIndicadoresClient()

            Dim ListarMetrosIndividuales = oImpresionIndicadoresService.ListaIndicadoresMetrosIndividuales(New ImpresionIndicadoresService.ImpresionIndicadoresMetrosRequest With {
                                                                                                   .TipoRecurso = itemRequest.TipoRecurso,
                                                                                                   .BuscarFechaFin = itemRequest.BuscarFechaFin,
                                                                                                   .BuscarFechaInicio = itemRequest.BuscarFechaInicio
                                                                                                                                            })


            oImpresionIndicadoresService.Close()


            Dim ListMetrosIndividuales = ListarMetrosIndividuales.ListaProduccionMetros

            If ListMetrosIndividuales.Count > 0 Then

                For Each item As ImpresionIndicadoresService.ImpresionIndicadoresMetrosEL In ListMetrosIndividuales

                    result.Add(New ImpresionIndicadoresMetrosEL() With {
                                                    .IdRecurso = item.IdRecurso,
                                                    .Año = item.Año,
                                                    .Mes = item.Mes,
                                                    .ProduccionMetrosMiles = item.ProduccionMetrosMiles,
                                                    .MetrosObjetivos = item.MetrosObjetivos,
                                                    .MetrosCumplidos = item.MetrosCumplidos,
                                                    .DescripcionFecha = ConvertMes(item.Mes) & " " & (item.Año).Substring(2)
                                             })

                Next

            End If



        Catch ex As Exception

            'result.ErrorCode = Enumerated.ResponseCode.CodigoErrorAplicacion
            'result.ErrorDescription = ex.Message
        End Try

        Return result
    End Function



    ''' <summary>
    ''' Listar Aperturas Dia y detalle
    ''' </summary>
    ''' <param name="itemRequest"></param>
    ''' <returns></returns>
    Public Function ListaIndicadoresScrapTotales(ByVal itemRequest As ImpresionIndicadoresScrapRequest) As List(Of ImpresionIndicadoresScrapEL)

        Dim result As List(Of ImpresionIndicadoresScrapEL) = New List(Of ImpresionIndicadoresScrapEL)()

        Try

            oImpresionIndicadoresService = New ImpresionIndicadoresService.ImpresionIndicadoresClient()

            Dim ListarScrapTotales = oImpresionIndicadoresService.ListaIndicadoresScrapTotales(New ImpresionIndicadoresService.ImpresionIndicadoresScrapRequest With {
                                                                                                                    .BuscarFechaFin = itemRequest.BuscarFechaFin,
                                                                                                                  .BuscarFechaInicio = itemRequest.BuscarFechaInicio
                                                                                                                                            })

            oImpresionIndicadoresService.Close()


            Dim ListScrapTotales = ListarScrapTotales.ListaProduccionScrap

            If ListScrapTotales.Count > 0 Then

                For Each item As ImpresionIndicadoresService.ImpresionIndicadoresScrapEL In ListScrapTotales

                    result.Add(New ImpresionIndicadoresScrapEL() With {
                                                    .Año = item.Año,
                                                    .Mes = item.Mes,
                                                    .SumaKilosScrap = item.SumaKilosScrap,
                                                    .SumaKilosProduccion = item.SumaKilosProduccion,
                                                    .SumaKilosRegulacion = item.SumaKilosRegulacion,
                                                    .MermaObjetivo = item.MermaObjetivo,
                                                    .MermaResultante = item.MermaResultante,
                                                    .DescripcionFecha = ConvertMes(item.Mes) & " " & (item.Año).Substring(2)
                                             })

                Next

            End If



        Catch ex As Exception

            'result.ErrorCode = Enumerated.ResponseCode.CodigoErrorAplicacion
            'result.ErrorDescription = ex.Message
        End Try

        Return result
    End Function


    ''' <summary>
    ''' Listar Aperturas Dia y detalle
    ''' </summary>
    ''' <param name="itemRequest"></param>
    ''' <returns></returns>
    Public Function ListaIndicadoresScrapIndividuales(ByVal itemRequest As ImpresionIndicadoresScrapRequest) As List(Of ImpresionIndicadoresScrapEL)

        Dim result As List(Of ImpresionIndicadoresScrapEL) = New List(Of ImpresionIndicadoresScrapEL)()

        Try

            oImpresionIndicadoresService = New ImpresionIndicadoresService.ImpresionIndicadoresClient()

            Dim ListarScrapTotales = oImpresionIndicadoresService.ListaIndicadoresScrapIndividuales(New ImpresionIndicadoresService.ImpresionIndicadoresScrapRequest With {
                                                                                                   .TipoRecurso = itemRequest.TipoRecurso,
                                                                                                   .BuscarFechaFin = itemRequest.BuscarFechaFin,
                                                                                                                  .BuscarFechaInicio = itemRequest.BuscarFechaInicio
                                                                                                                                            })


            oImpresionIndicadoresService.Close()


            Dim ListScrapTotales = ListarScrapTotales.ListaProduccionScrap

            If ListScrapTotales.Count > 0 Then

                For Each item As ImpresionIndicadoresService.ImpresionIndicadoresScrapEL In ListScrapTotales

                    result.Add(New ImpresionIndicadoresScrapEL() With {
                                                    .IdRecurso = item.IdRecurso,
                                                    .Año = item.Año,
                                                    .Mes = item.Mes,
                                                    .SumaKilosScrap = item.SumaKilosScrap,
                                                    .SumaKilosProduccion = item.SumaKilosProduccion,
                                                    .SumaKilosRegulacion = item.SumaKilosRegulacion,
                                                    .MermaObjetivo = item.MermaObjetivo,
                                                    .MermaResultante = item.MermaResultante,
                                                    .DescripcionFecha = ConvertMes(item.Mes) & " " & (item.Año).Substring(2)
                                             })

                Next

            End If



        Catch ex As Exception

            'result.ErrorCode = Enumerated.ResponseCode.CodigoErrorAplicacion
            'result.ErrorDescription = ex.Message
        End Try

        Return result
    End Function

    Public Function ConvertMes(ByVal mes As Integer) As String

        Return Choose(mes, "Ene", "Feb", "Mar", "Abr", "May", "Jun", "Jul", "Agos", "Set", "Oct", "Nov", "Dic")
    End Function


End Class
