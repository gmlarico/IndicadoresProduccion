Imports Resinplast.Indicadores.Utils
Imports Resinplast.Indicadores.Wrapper
Imports Resinplast.Indicadores.Web.Models.Base
Imports Resinplast.Indicadores.Web.Models
Public Class DisenoContext
    Public ListarAperturasDiaDetalle As DisenoIndicadoresService.DiseñoIndicadoresAperturaResponse
    Private oDisenoIndicadoresService As DisenoIndicadoresService.DiseñoIndicadoresClient = Nothing

    ''' <summary>
    ''' Listar Aperturas Dia y detalle
    ''' </summary>
    ''' <param name="itemRequest"></param>
    ''' <returns></returns>
    Public Function ListarAperturasDia(ByVal itemRequest As DiseñoIndicadoresAperturaRequest) As List(Of DiseñoIndicadoresAperturaEL)

        Dim result As List(Of DiseñoIndicadoresAperturaEL) = New List(Of DiseñoIndicadoresAperturaEL)()

        Try

            oDisenoIndicadoresService = New DisenoIndicadoresService.DiseñoIndicadoresClient()

            Dim ListarAperturasDias = oDisenoIndicadoresService.ListarAperturasDia(New DisenoIndicadoresService.DiseñoIndicadoresAperturaRequest With {
                                                                             .FechaEnAprobacionCliente = itemRequest.FechaEnAprobacionCliente
                                                                             })

            ListarAperturasDiaDetalle = oDisenoIndicadoresService.ListarAperturasDiaDetalle(New DisenoIndicadoresService.DiseñoIndicadoresAperturaRequest)

            oDisenoIndicadoresService.Close()
            ListaIndicadoresAperturaDiaDetalle = New List(Of DiseñoIndicadoresAperturaEL)

            For Each item As DisenoIndicadoresService.DiseñoIndicadoresAperturaEL In ListarAperturasDiaDetalle.ListaIndicadorAperturasDiaDetalle

                ListaIndicadoresAperturaDiaDetalle.Add(New DiseñoIndicadoresAperturaEL() With {
                                                .IdOrdenTrabajo = item.IdOrdenTrabajo,
                                                .NroLegalOrdenTrabajo = item.NroLegalOrdenTrabajo,
                                                .NombreCliente = item.NombreCliente,
                                                .NombreProducto = item.NombreProducto,
                                                .FechaEnAprobacionCliente = item.FechaEnAprobacionCliente,
                                                .FechaEnviadoDiseno = item.FechaEnviadoDiseno,
                                                .FechaIniSemEnAprobacionCliente = item.FechaIniSemEnAprobacionCliente,
                                                .FechaFinSemEnAprobacionCliente = item.FechaFinSemEnAprobacionCliente,
                                                .FechaIniSemEnviadoDiseno = item.FechaIniSemEnviadoDiseno,
                                                .FechaFinSemEnviadoDiseno = item.FechaFinSemEnviadoDiseno
                                         })

            Next


            Dim ListAperturasDiariasFil = ListarAperturasDias.ListaIndicadorAperturasDia

            If ListAperturasDiariasFil.Count > 0 Then

                For Each item As DisenoIndicadoresService.DiseñoIndicadoresAperturaEL In ListAperturasDiariasFil

                    result.Add(New DiseñoIndicadoresAperturaEL() With {
                                                    .DescripcionFecha = Day(item.FechaEnAprobacionCliente) & " " & ConvertMes(Month(item.FechaEnAprobacionCliente)),
                                                    .TotalTrabajos = item.TotalTrabajos,
                                                    .TotalTrabajosmes = item.TotalTrabajosmes,
                                                    .TrabajosPromedio = item.TrabajosPromedio,
                                                    .TotalTrabajosAño = ListaIndicadoresAperturaDiaDetalle.Where(Function(x) (x.FechaEnAprobacionCliente.Ticks > 0 And Year(x.FechaEnAprobacionCliente) = Year(itemRequest.FechaEnAprobacionCliente))).ToList().Count()
                                             })

                Next

            Else
                result.Add(New DiseñoIndicadoresAperturaEL() With {
                                                    .DescripcionFecha = Day(DateTime.Now()) & " " & ConvertMes(Month(DateTime.Now())),
                                                    .TotalTrabajos = 0,
                                                    .TotalTrabajosmes = 0,
                                                    .TrabajosPromedio = 0,
                                                    .TotalTrabajosAño = ListaIndicadoresAperturaDiaDetalle.Where(Function(x) (x.FechaEnAprobacionCliente.Ticks > 0 And Year(x.FechaEnAprobacionCliente) = Year(itemRequest.FechaEnAprobacionCliente))).ToList().Count()
                                             })

            End If



        Catch ex As Exception

            'result.ErrorCode = Enumerated.ResponseCode.CodigoErrorAplicacion
            'result.ErrorDescription = ex.Message
        End Try

        Return result
    End Function

    ''' <summary>
    ''' Listar Aperturas Semana
    ''' </summary>
    ''' <param name="itemRequest"></param>
    ''' <returns></returns>
    Public Function ListarAperturasSemana(ByVal itemRequest As DiseñoIndicadoresAperturaRequest) As List(Of DiseñoIndicadoresAperturaEL)

        Dim result As List(Of DiseñoIndicadoresAperturaEL) = New List(Of DiseñoIndicadoresAperturaEL)()

        Try

            oDisenoIndicadoresService = New DisenoIndicadoresService.DiseñoIndicadoresClient()

            Dim ListarAperturasSemanas = oDisenoIndicadoresService.ListarAperturasSemana(New DisenoIndicadoresService.DiseñoIndicadoresAperturaRequest With {
                                                                             .FechaEnAprobacionCliente = itemRequest.FechaEnAprobacionCliente
                                                                             })

            oDisenoIndicadoresService.Close()

            Dim ListAperturasSemanaFil = ListarAperturasSemanas.ListaIndicadorAperturasSemana

            For Each item As DisenoIndicadoresService.DiseñoIndicadoresAperturaEL In ListAperturasSemanaFil

                Dim FechaIniSem = Day(item.FechaIniSemEnviadoDiseno) & " " & ConvertMes(Month(item.FechaIniSemEnviadoDiseno))
                Dim FechaFinSem = Day(item.FechaFinSemEnviadoDiseno) & " " & ConvertMes(Month(item.FechaFinSemEnviadoDiseno))

                result.Add(New DiseñoIndicadoresAperturaEL() With {
                                                .DescripcionFecha = FechaIniSem & " / " & FechaFinSem,
                                                .PromedioSem = item.PromedioSem,
                                                .TotalTrabajos = item.TotalTrabajos,
                                                .TrabajosSinCompletar = item.TrabajosSinCompletar
                                         })

            Next

        Catch ex As Exception

            'result.ErrorCode = Enumerated.ResponseCode.CodigoErrorAplicacion
            'result.ErrorDescription = ex.Message
        End Try

        Return result
    End Function



    ''' <summary>
    ''' Listar Aperturas Completadas Semana
    ''' </summary>
    ''' <param name="itemRequest"></param>
    ''' <returns></returns>
    Public Function ListarAperturasCompletadasSemana(ByVal itemRequest As DiseñoIndicadoresAperturaRequest) As List(Of DiseñoIndicadoresAperturaEL)

        Dim result As List(Of DiseñoIndicadoresAperturaEL) = New List(Of DiseñoIndicadoresAperturaEL)()

        Try

            oDisenoIndicadoresService = New DisenoIndicadoresService.DiseñoIndicadoresClient()

            Dim ListarAperturasSemanas = oDisenoIndicadoresService.ListarAperturasCompletadasSemana(New DisenoIndicadoresService.DiseñoIndicadoresAperturaRequest With {
                                                                             .FechaEnAprobacionCliente = itemRequest.FechaEnAprobacionCliente
                                                                             })

            oDisenoIndicadoresService.Close()

            Dim ListAperturasSemanaFil = ListarAperturasSemanas.ListaIndicadorAperturasCompletadasSemana

            For Each item As DisenoIndicadoresService.DiseñoIndicadoresAperturaEL In ListAperturasSemanaFil

                Dim FechaIniSem = Day(item.FechaIniSemEnAprobacionCliente) & " " & ConvertMes(Month(item.FechaIniSemEnAprobacionCliente))
                Dim FechaFinSem = Day(item.FechaFinSemEnAprobacionCliente) & " " & ConvertMes(Month(item.FechaFinSemEnAprobacionCliente))

                result.Add(New DiseñoIndicadoresAperturaEL() With {
                                                .DescripcionFecha = FechaIniSem & " / " & FechaFinSem,
                                                .PromedioSem = item.PromedioSem,
                                                .TotalTrabajos = item.TotalTrabajos,
                                                .TrabajosSinCompletar = item.TrabajosSinCompletar
                                         })

            Next

        Catch ex As Exception

            'result.ErrorCode = Enumerated.ResponseCode.CodigoErrorAplicacion
            'result.ErrorDescription = ex.Message
        End Try

        Return result
    End Function



    ''' <summary>
    ''' Consultar Aperturas DiasDetalle 2
    ''' </summary>
    ''' <param name="itemRequest"></param>
    ''' <returns></returns>
    Public Function ConsultarAperturasDiasDetalle2(ByVal itemRequest As DiseñoIndicadoresAperturaRequest) As List(Of DiseñoIndicadoresAperturaEL)

        Dim result As List(Of DiseñoIndicadoresAperturaEL) = New List(Of DiseñoIndicadoresAperturaEL)()

        Try

            ListarAperturasDiaDetalle = New DisenoIndicadoresService.DiseñoIndicadoresAperturaResponse

            oDisenoIndicadoresService = New DisenoIndicadoresService.DiseñoIndicadoresClient()
            ListFiltradaApertura = New List(Of DiseñoIndicadoresAperturaEL)
            Dim FechaBusqueda As DateTime
            FechaBusqueda = itemRequest.FechaEnAprobacionCliente




            If itemRequest.EstadoTrabajo Is Nothing Then

                ListarAperturasDiaDetalle = oDisenoIndicadoresService.ListarAperturasDiaDetalle(New DisenoIndicadoresService.DiseñoIndicadoresAperturaRequest With {
                                                                             .FechaEnAprobacionCliente = itemRequest.FechaEnAprobacionCliente
                                                                             })

                For Each item As DisenoIndicadoresService.DiseñoIndicadoresAperturaEL In ListarAperturasDiaDetalle.ListaIndicadorAperturasDiaDetalle

                    result.Add(New DiseñoIndicadoresAperturaEL() With {
                                                .IdOrdenTrabajo = item.IdOrdenTrabajo,
                                                .NroLegalOrdenTrabajo = item.NroLegalOrdenTrabajo,
                                                .NombreCliente = item.NombreCliente,
                                                .NombreProducto = item.NombreProducto,
                                                .FechaEnAprobacionCliente = item.FechaEnAprobacionCliente,
                                                .FechaEnviadoDiseno = item.FechaEnviadoDiseno,
                                                .FechaIniSemEnAprobacionCliente = item.FechaIniSemEnAprobacionCliente,
                                                .FechaFinSemEnAprobacionCliente = item.FechaFinSemEnAprobacionCliente,
                                                .FechaIniSemEnviadoDiseno = item.FechaIniSemEnviadoDiseno,
                                                .FechaFinSemEnviadoDiseno = item.FechaFinSemEnviadoDiseno,
                                                .TiempoAperturaHoras = item.TiempoAperturaHoras,
                                                .TiempoDeApertura = item.TiempoDeApertura
                                         })

                Next



            ElseIf itemRequest.EstadoTrabajo = "COMPLETO" Then

                ListarAperturasDiaDetalle = oDisenoIndicadoresService.ListarAperturasDiaDetalle(New DisenoIndicadoresService.DiseñoIndicadoresAperturaRequest With {
                                                                             .FechaIniSemEnAprobacionCliente = itemRequest.FechaIniSemEnAprobacionCliente
                                                                             })

                For Each item As DisenoIndicadoresService.DiseñoIndicadoresAperturaEL In ListarAperturasDiaDetalle.ListaIndicadorAperturasDiaDetalle.Where(Function(x) (Month(x.FechaEnAprobacionCliente) = itemRequest.mes And x.FechaEnAprobacionCliente.Ticks > 0)).ToList()

                    result.Add(New DiseñoIndicadoresAperturaEL() With {
                                                .IdOrdenTrabajo = item.IdOrdenTrabajo,
                                                .NroLegalOrdenTrabajo = item.NroLegalOrdenTrabajo,
                                                .NombreCliente = item.NombreCliente,
                                                .NombreProducto = item.NombreProducto,
                                                .FechaEnAprobacionCliente = item.FechaEnAprobacionCliente,
                                                .FechaEnviadoDiseno = item.FechaEnviadoDiseno,
                                                .FechaIniSemEnAprobacionCliente = item.FechaIniSemEnAprobacionCliente,
                                                .FechaFinSemEnAprobacionCliente = item.FechaFinSemEnAprobacionCliente,
                                                .FechaIniSemEnviadoDiseno = item.FechaIniSemEnviadoDiseno,
                                                .FechaFinSemEnviadoDiseno = item.FechaFinSemEnviadoDiseno,
                                                .TiempoAperturaHoras = item.TiempoAperturaHoras,
                                                .TiempoDeApertura = item.TiempoDeApertura
                                         })

                Next


            Else
                If itemRequest.EstadoTrabajo = "1" Then

                    ListarAperturasDiaDetalle = oDisenoIndicadoresService.ListarAperturasDiaDetalle(New DisenoIndicadoresService.DiseñoIndicadoresAperturaRequest With {
                                                                             .FechaIniSemEnviadoDiseno = itemRequest.FechaIniSemEnviadoDiseno
                                                                             })

                    For Each item As DisenoIndicadoresService.DiseñoIndicadoresAperturaEL In ListarAperturasDiaDetalle.ListaIndicadorAperturasDiaDetalle.Where(Function(x) (Month(x.FechaEnviadoDiseno) = itemRequest.mes And x.FechaEnAprobacionCliente.Ticks <= 0)).ToList()

                        result.Add(New DiseñoIndicadoresAperturaEL() With {
                                                .IdOrdenTrabajo = item.IdOrdenTrabajo,
                                                .NroLegalOrdenTrabajo = item.NroLegalOrdenTrabajo,
                                                .NombreCliente = item.NombreCliente,
                                                .NombreProducto = item.NombreProducto,
                                                .FechaEnAprobacionCliente = item.FechaEnAprobacionCliente,
                                                .FechaEnviadoDiseno = item.FechaEnviadoDiseno,
                                                .FechaIniSemEnAprobacionCliente = item.FechaIniSemEnAprobacionCliente,
                                                .FechaFinSemEnAprobacionCliente = item.FechaFinSemEnAprobacionCliente,
                                                .FechaIniSemEnviadoDiseno = item.FechaIniSemEnviadoDiseno,
                                                .FechaFinSemEnviadoDiseno = item.FechaFinSemEnviadoDiseno,
                                                .TiempoAperturaHoras = item.TiempoAperturaHoras,
                                                .TiempoDeApertura = item.TiempoDeApertura
                                         })

                    Next


                Else

                    ListarAperturasDiaDetalle = oDisenoIndicadoresService.ListarAperturasDiaDetalle(New DisenoIndicadoresService.DiseñoIndicadoresAperturaRequest With {
                                                                             .FechaIniSemEnviadoDiseno = itemRequest.FechaIniSemEnviadoDiseno
                                                                             })

                    For Each item As DisenoIndicadoresService.DiseñoIndicadoresAperturaEL In ListarAperturasDiaDetalle.ListaIndicadorAperturasDiaDetalle.Where(Function(x) (Month(x.FechaEnviadoDiseno) = itemRequest.mes And x.FechaEnAprobacionCliente.Ticks > 0)).ToList()

                        result.Add(New DiseñoIndicadoresAperturaEL() With {
                                                .IdOrdenTrabajo = item.IdOrdenTrabajo,
                                                .NroLegalOrdenTrabajo = item.NroLegalOrdenTrabajo,
                                                .NombreCliente = item.NombreCliente,
                                                .NombreProducto = item.NombreProducto,
                                                .FechaEnAprobacionCliente = item.FechaEnAprobacionCliente,
                                                .FechaEnviadoDiseno = item.FechaEnviadoDiseno,
                                                .FechaIniSemEnAprobacionCliente = item.FechaIniSemEnAprobacionCliente,
                                                .FechaFinSemEnAprobacionCliente = item.FechaFinSemEnAprobacionCliente,
                                                .FechaIniSemEnviadoDiseno = item.FechaIniSemEnviadoDiseno,
                                                .FechaFinSemEnviadoDiseno = item.FechaFinSemEnviadoDiseno,
                                                .TiempoAperturaHoras = item.TiempoAperturaHoras,
                                                .TiempoDeApertura = item.TiempoDeApertura
                                         })

                    Next



                End If
            End If

        Catch ex As Exception
            'result.ErrorCode = Enumerated.ResponseCode.CodigoErrorAplicacion
            'result.ErrorDescription = ex.Message
        End Try

        Return result
    End Function


    ''' <summary>
    ''' Listar Prepensa Dia y detalle
    ''' </summary>
    ''' <param name="itemRequest"></param>
    ''' <returns></returns>
    Public Function ListarPrepensaDia(ByVal itemRequest As DiseñoIndicadoresPreprensasRequest) As List(Of DiseñoIndicadoresPreprensasEL)

        Dim result As List(Of DiseñoIndicadoresPreprensasEL) = New List(Of DiseñoIndicadoresPreprensasEL)()

        Try

            oDisenoIndicadoresService = New DisenoIndicadoresService.DiseñoIndicadoresClient()

            Dim ListarPrepensaDias = oDisenoIndicadoresService.ListarPrepensaDia(New DisenoIndicadoresService.DiseñoIndicadoresPreprensasRequest With {
                                                                             .FechaEnviadoProceso = itemRequest.FechaEnviadoProceso
                                                                             })

            Dim ListarPrepensaDiasPruebaColor = oDisenoIndicadoresService.ListarPrepensaDia(New DisenoIndicadoresService.DiseñoIndicadoresPreprensasRequest With {
                                                                             .FechaEnviadoProceso = itemRequest.FechaEnviadoProceso
                                                                             })

            Dim ListarPreprensaDiaDetalle = oDisenoIndicadoresService.ListarPreprensaDiaDetalle(New DisenoIndicadoresService.DiseñoIndicadoresPreprensasRequest With {
                                                                             .Año = itemRequest.Año
                                                                             })

            oDisenoIndicadoresService.Close()



            ListaIndicadoresPreprensaDiaDetalle = New List(Of DiseñoIndicadoresPreprensasEL)




            For Each item As DisenoIndicadoresService.DiseñoIndicadoresPreprensasEL In ListarPreprensaDiaDetalle.ListaIndicadorPreprensasDiaDetalle
                ListaIndicadoresPreprensaDiaDetalle.Add(New DiseñoIndicadoresPreprensasEL() With {
                                                .IdPizarraInterno = item.IdPizarraInterno,
                                                .NroLegalOrdenTrabajo = item.NroLegalOrdenTrabajo,
                                                .NombreCliente = item.NombreCliente,
                                                .NombreProducto = item.NombreProducto,
                                                .FechaEnviadoCliche = item.FechaEnviadoCliche,
                                                .FechaEnviadoProceso = item.FechaEnviadoProceso,
                                                .FechaFinSemEnviadoProceso = item.FechaFinSemEnviadoProceso,
                                                .FechaIniSemEnviadoProceso = item.FechaIniSemEnviadoProceso,
                                                .FechaIniSemEnviadoCliche = item.FechaIniSemEnviadoCliche,
                                                .FechaFinSemEnviadoCliche = item.FechaFinSemEnviadoCliche,
                                                .TiempoPreprensa = item.TiempoPreprensa,
                                                .IdEventoControl = item.IdEventoControl
                                         })

            Next





            Dim ListPreprensaDiariasFil = ListarPrepensaDias.ListaIndicadorPreprensasDia


            If ListPreprensaDiariasFil.Count > 0 Then

                For Each item As DisenoIndicadoresService.DiseñoIndicadoresPreprensasEL In ListPreprensaDiariasFil

                    result.Add(New DiseñoIndicadoresPreprensasEL() With {
                                                    .DescripcionFecha = Day(item.FechaEnviadoCliche) & " " & ConvertMes(Month(item.FechaEnviadoCliche)),
                                                    .TotalTrabajos = item.TotalTrabajos,
                                                    .TrabajosSinPC = item.TrabajosSinPC,
                                                    .TrabajosConPC = item.TrabajosConPC,
                                                    .TotalTrabajosmes = item.TotalTrabajosmes,
                                                    .TrabajosPromedio = item.TrabajosPromedio,
                                                    .TotalTrabajosAño = ListaIndicadoresPreprensaDiaDetalle.Where(Function(x) (x.FechaEnviadoCliche.Ticks > 0 And Year(x.FechaEnviadoCliche) = Year(itemRequest.FechaEnviadoProceso))).ToList().Count()
                                             })

                Next

            Else
                result.Add(New DiseñoIndicadoresPreprensasEL() With {
                                                    .DescripcionFecha = Day(DateTime.Now()) & " " & ConvertMes(Month(DateTime.Now())),
                                                    .TotalTrabajos = 0,
                                                    .TrabajosSinPC = 0,
                                                    .TrabajosConPC = 0,
                                                    .TotalTrabajosmes = 0,
                                                    .TrabajosPromedio = 0,
                                                    .TotalTrabajosAño = ListaIndicadoresPreprensaDiaDetalle.Where(Function(x) (x.FechaEnviadoCliche.Ticks > 0 And Year(x.FechaEnviadoCliche) = Year(itemRequest.FechaEnviadoProceso))).ToList().Count()
                                             })


            End If




        Catch ex As Exception
            'result.ErrorCode = Enumerated.ResponseCode.CodigoErrorAplicacion
            'result.ErrorDescription = ex.Message
        End Try

        Return result
    End Function


    ''' <summary>
    ''' Listar Prepensa Dia Prueba color
    ''' </summary>
    ''' <param name="itemRequest"></param>
    ''' <returns></returns>
    Public Function ListarPrepensaDiaPruebaColor(ByVal itemRequest As DiseñoIndicadoresPreprensasRequest) As List(Of DiseñoIndicadoresPreprensasEL)

        Dim result As List(Of DiseñoIndicadoresPreprensasEL) = New List(Of DiseñoIndicadoresPreprensasEL)()

        Try

            oDisenoIndicadoresService = New DisenoIndicadoresService.DiseñoIndicadoresClient()

            Dim ListarPrepensaPruebaColor = oDisenoIndicadoresService.ListarPrepensaDiaPruebaColor(New DisenoIndicadoresService.DiseñoIndicadoresPreprensasRequest With {
                                                                             .FechaEnviadoProceso = itemRequest.FechaEnviadoProceso
                                                                             })

            oDisenoIndicadoresService.Close()

            Dim ListPreprensaDiariasPruebaColorFil = ListarPrepensaPruebaColor.ListaIndicadorPreprensasDiaPruebaColor


            If ListPreprensaDiariasPruebaColorFil.Count > 0 Then

                For Each item As DisenoIndicadoresService.DiseñoIndicadoresPreprensasEL In ListPreprensaDiariasPruebaColorFil

                    result.Add(New DiseñoIndicadoresPreprensasEL() With {
                                                    .DescripcionFecha = Day(item.FechaEnviadoCliche) & " " & ConvertMes(Month(item.FechaEnviadoCliche)),
                                                    .TotalTrabajos = item.TotalTrabajos,
                                                    .TotalTrabajosmes = item.TotalTrabajosmes,
                                                    .TrabajosPromedio = item.TrabajosPromedio,
                                                    .TotalTrabajosAño = 0
                                             })

                Next

            Else
                result.Add(New DiseñoIndicadoresPreprensasEL() With {
                                                    .DescripcionFecha = Day(DateTime.Now()) & " " & ConvertMes(Month(DateTime.Now())),
                                                    .TotalTrabajos = 0,
                                                    .TotalTrabajosmes = 0,
                                                    .TrabajosPromedio = 0,
                                                    .TotalTrabajosAño = 0
                                             })


            End If




        Catch ex As Exception
            'result.ErrorCode = Enumerated.ResponseCode.CodigoErrorAplicacion
            'result.ErrorDescription = ex.Message
        End Try

        Return result
    End Function


    ''' <summary>
    ''' Listar Preprensas Semana
    ''' </summary>
    ''' <param name="itemRequest"></param>
    ''' <returns></returns>
    Public Function ListarPreprensasSemana(ByVal itemRequest As DiseñoIndicadoresPreprensasRequest) As List(Of DiseñoIndicadoresPreprensasEL)

        Dim result As List(Of DiseñoIndicadoresPreprensasEL) = New List(Of DiseñoIndicadoresPreprensasEL)()

        Try

            oDisenoIndicadoresService = New DisenoIndicadoresService.DiseñoIndicadoresClient()

            Dim ListarPreprensasSemanas = oDisenoIndicadoresService.ListarPreprensasSemana(New DisenoIndicadoresService.DiseñoIndicadoresPreprensasRequest With {
                                                                             .FechaEnviadoProceso = itemRequest.FechaEnviadoProceso
                                                                             })

            oDisenoIndicadoresService.Close()

            Dim ListPreprensaDiariasFil = ListarPreprensasSemanas.ListaIndicadorPreprensasSemana

            For Each item As DisenoIndicadoresService.DiseñoIndicadoresPreprensasEL In ListPreprensaDiariasFil

                Dim FechaIniSem = Day(item.FechaIniSemEnviadoProceso) & " " & ConvertMes(Month(item.FechaIniSemEnviadoProceso))
                Dim FechaFinSem = Day(item.FechaFinSemEnviadoProceso) & " " & ConvertMes(Month(item.FechaFinSemEnviadoProceso))

                result.Add(New DiseñoIndicadoresPreprensasEL() With {
                                                .DescripcionFecha = FechaIniSem & " / " & FechaFinSem,
                                                .PromedioSem = item.PromedioSem,
                                                .TotalTrabajos = item.TotalTrabajos,
                                                .TrabajosSinCompletar = item.TrabajosSinCompletar
                                         })

            Next

        Catch ex As Exception
            'result.ErrorCode = Enumerated.ResponseCode.CodigoErrorAplicacion
            'result.ErrorDescription = ex.Message
        End Try

        Return result
    End Function


    ''' <summary>
    ''' Listar Preprensas Completadas Semana
    ''' </summary>
    ''' <param name="itemRequest"></param>
    ''' <returns></returns>
    Public Function ListarPreprensasCompletadasSemana(ByVal itemRequest As DiseñoIndicadoresPreprensasRequest) As List(Of DiseñoIndicadoresPreprensasEL)

        Dim result As List(Of DiseñoIndicadoresPreprensasEL) = New List(Of DiseñoIndicadoresPreprensasEL)()

        Try

            oDisenoIndicadoresService = New DisenoIndicadoresService.DiseñoIndicadoresClient()

            Dim ListarPreprensasCompletadasSemanas = oDisenoIndicadoresService.ListarPreprensasCompletadasSemana(New DisenoIndicadoresService.DiseñoIndicadoresPreprensasRequest With {
                                                                             .FechaEnviadoProceso = itemRequest.FechaEnviadoProceso
                                                                             })

            oDisenoIndicadoresService.Close()

            Dim ListPreprensaDiariasFil = ListarPreprensasCompletadasSemanas.ListaIndicadorPreprensasCompletadasSemana

            For Each item As DisenoIndicadoresService.DiseñoIndicadoresPreprensasEL In ListPreprensaDiariasFil

                Dim FechaIniSem = Day(item.FechaIniSemEnviadoCliche) & " " & ConvertMes(Month(item.FechaIniSemEnviadoCliche))
                Dim FechaFinSem = Day(item.FechaFinSemEnviadoCliche) & " " & ConvertMes(Month(item.FechaFinSemEnviadoCliche))

                result.Add(New DiseñoIndicadoresPreprensasEL() With {
                                                .DescripcionFecha = FechaIniSem & " / " & FechaFinSem,
                                                .PromedioSem = item.PromedioSem,
                                                .TotalTrabajos = item.TotalTrabajos,
                                                .TrabajosSinCompletar = item.TrabajosSinCompletar
                                         })

            Next

        Catch ex As Exception
            'result.ErrorCode = Enumerated.ResponseCode.CodigoErrorAplicacion
            'result.ErrorDescription = ex.Message
        End Try

        Return result
    End Function

    ''' <summary>
    ''' Consultar Preprensa Dias Detalle2
    ''' </summary>
    ''' <param name="itemRequest"></param>
    ''' <returns></returns>
    Public Function ConsultarPreprensaDiasDetalle2(ByVal itemRequest As DiseñoIndicadoresPreprensasRequest) As List(Of DiseñoIndicadoresPreprensasEL)

        Dim result As List(Of DiseñoIndicadoresPreprensasEL) = New List(Of DiseñoIndicadoresPreprensasEL)()

        Try
            ListFiltradaPreprensa = New List(Of DiseñoIndicadoresPreprensasEL)
            Dim FechaEnviadoCliche As DateTime
            FechaEnviadoCliche = itemRequest.FechaEnviadoCliche

            If itemRequest.EstadoTrabajo = "SIN PC" Then

                ListFiltradaPreprensa = ListaIndicadoresPreprensaDiaDetalle.Where(Function(x) (x.FechaEnviadoCliche.ToString("dd/MM/yyyy") = FechaEnviadoCliche.ToString("dd/MM/yyyy") And x.IdEventoControl = "1")).ToList()

            ElseIf itemRequest.EstadoTrabajo = "CON PC" Then

                ListFiltradaPreprensa = ListaIndicadoresPreprensaDiaDetalle.Where(Function(x) (x.FechaEnviadoCliche.ToString("dd/MM/yyyy") = itemRequest.FechaEnviadoCliche.ToString("dd/MM/yyyy") And x.IdEventoControl > "1")).ToList()

            ElseIf itemRequest.EstadoTrabajo = "COMPLETO" Then
                ListFiltradaPreprensa = ListaIndicadoresPreprensaDiaDetalle.Where(Function(x) (x.FechaIniSemEnviadoCliche.ToString("dd/MM/yyyy") = itemRequest.FechaIniSemEnviadoCliche.ToString("dd/MM/yyyy") And Month(x.FechaEnviadoCliche) = itemRequest.mes And x.FechaEnviadoCliche.Ticks > 0)).ToList()

            Else
                If itemRequest.EstadoTrabajo = "1" Then

                    ListFiltradaPreprensa = ListaIndicadoresPreprensaDiaDetalle.Where(Function(x) (x.FechaIniSemEnviadoProceso.ToString("dd/MM/yyyy") = itemRequest.FechaIniSemEnviadoProceso.ToString("dd/MM/yyyy") And Month(x.FechaEnviadoProceso) = itemRequest.mes And x.FechaEnviadoCliche.Ticks <= 0)).ToList()

                Else
                    ListFiltradaPreprensa = ListaIndicadoresPreprensaDiaDetalle.Where(Function(x) (x.FechaIniSemEnviadoProceso.ToString("dd/MM/yyyy") = itemRequest.FechaIniSemEnviadoProceso.ToString("dd/MM/yyyy") And Month(x.FechaEnviadoProceso) = itemRequest.mes And x.FechaEnviadoCliche.Ticks > 0)).ToList()

                End If
            End If

            For Each item As DiseñoIndicadoresPreprensasEL In ListFiltradaPreprensa

                result.Add(New DiseñoIndicadoresPreprensasEL() With {
                                                .IdPizarraInterno = item.IdPizarraInterno,
                                                .NroLegalOrdenTrabajo = item.NroLegalOrdenTrabajo,
                                                .NombreCliente = item.NombreCliente,
                                                .NombreProducto = item.NombreProducto,
                                                .FechaEnviadoCliche = item.FechaEnviadoCliche,
                                                .FechaEnviadoProceso = item.FechaEnviadoProceso,
                                                .TiempoPreprensa = item.TiempoPreprensa
                                         })

            Next

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
