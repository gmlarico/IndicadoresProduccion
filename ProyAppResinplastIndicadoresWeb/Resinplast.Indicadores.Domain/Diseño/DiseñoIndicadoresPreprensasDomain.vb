Imports System.Data.SqlClient
Imports Resinplast.Indicadores.Utils
Imports Resinplast.Indicadores.Wrapper
Public Class DiseñoIndicadoresPreprensasDomain

    Public Function ListarPrepensaDia(ByVal itemRequest As DiseñoIndicadoresPreprensasRequest) As DiseñoIndicadoresPreprensasResponse

        Dim result As DiseñoIndicadoresPreprensasResponse = New DiseñoIndicadoresPreprensasResponse()
        result.ListaIndicadorPreprensasDia = New List(Of DiseñoIndicadoresPreprensasEL)()

        Dim cn As SqlConnection = New SqlConnection()
        Dim conexion As DataBaseConnection = New DataBaseConnection()

        Try

            cn = conexion.GetSql()
            cn.Open()

            Dim cmd As SqlCommand = cn.CreateCommand()
            cmd.CommandTimeout = 120
            cmd.CommandType = System.Data.CommandType.StoredProcedure
            cmd.CommandText = "RES124_PizarraDiseñoPreprensaKPIDias"
            cmd.Parameters.Clear()
            cmd.Parameters.Add(New SqlParameter("@FechaEnviadoProceso", SqlDbType.DateTime)).Value = IIf(String.IsNullOrWhiteSpace(itemRequest.FechaEnviadoProceso), DBNull.Value, itemRequest.FechaEnviadoProceso)

            Dim reader = cmd.ExecuteReader()

            If reader.HasRows Then

                While (reader.Read())
                    result.ListaIndicadorPreprensasDia.Add(New DiseñoIndicadoresPreprensasEL() With {
                        .FechaEnviadoCliche = IIf(reader("FechaEnviadoCliche").ToString() = DBNull.Value.ToString(), Nothing, reader("FechaEnviadoCliche")),
                        .TotalTrabajos = IIf(reader("TotalTrabajos").ToString() = DBNull.Value.ToString(), String.Empty, reader("TotalTrabajos").ToString),
                        .TrabajosConPC = IIf(reader("TrabajosConPC").ToString() = DBNull.Value.ToString(), String.Empty, reader("TrabajosConPC").ToString),
                        .TrabajosSinPC = IIf(reader("TrabajosSinPC").ToString() = DBNull.Value.ToString(), String.Empty, reader("TrabajosSinPC").ToString),
                        .TotalTrabajosmes = IIf(reader("Trabajopormes").ToString() = DBNull.Value.ToString(), String.Empty, reader("Trabajopormes").ToString),
                        .TrabajosPromedio = IIf(reader("TrabajosPromedio").ToString() = DBNull.Value.ToString(), 0, reader("TrabajosPromedio").ToString)
                                             })

                End While

            End If

            reader.Close()
            cn.Close()
            cmd.Dispose()

        Catch ex As Exception
            result.CodigoError = Enumerated.ResponseCode.CodigoErrorAplicacion
            result.DescripcionError = ex.Message
        End Try

        Return result
    End Function


    Public Function ListarPreprensaDiaDetalle(ByVal itemRequest As DiseñoIndicadoresPreprensasRequest) As DiseñoIndicadoresPreprensasResponse

        Dim result As DiseñoIndicadoresPreprensasResponse = New DiseñoIndicadoresPreprensasResponse()
        result.ListaIndicadorPreprensasDiaDetalle = New List(Of DiseñoIndicadoresPreprensasEL)()

        Dim cn As SqlConnection = New SqlConnection()
        Dim conexion As DataBaseConnection = New DataBaseConnection()

        Try

            cn = conexion.GetSql()
            cn.Open()

            Dim cmd As SqlCommand = cn.CreateCommand()
            cmd.CommandTimeout = 120
            cmd.CommandType = System.Data.CommandType.StoredProcedure
            cmd.CommandText = "RES124_PizarraDiseñoPreprensaKPIDiasDetalle"
            cmd.Parameters.Clear()

            cmd.Parameters.Add(New SqlParameter("@AÑO", SqlDbType.Char, 8)).Value = IIf(String.IsNullOrWhiteSpace(itemRequest.Año), DBNull.Value, itemRequest.Año)
            cmd.Parameters.Add(New SqlParameter("@MES", SqlDbType.Char, 8)).Value = IIf(String.IsNullOrWhiteSpace(itemRequest.mes), DBNull.Value, itemRequest.mes)
            cmd.Parameters.Add(New SqlParameter("@NombreCliente", SqlDbType.Char, 8)).Value = IIf(String.IsNullOrWhiteSpace(itemRequest.NombreCliente), DBNull.Value, itemRequest.NombreCliente)
            'cmd.Parameters.Add(New SqlParameter("@NombreEjecutivo", SqlDbType.VarChar, 250)).Value = IIf(String.IsNullOrWhiteSpace(itemRequest.NombreEjecutivo), DBNull.Value, itemRequest.NombreEjecutivo.Trim())

            Dim reader = cmd.ExecuteReader()

            If reader.HasRows Then

                While (reader.Read())
                    result.ListaIndicadorPreprensasDiaDetalle.Add(New DiseñoIndicadoresPreprensasEL() With {
                        .IdPizarraInterno = IIf(reader("IdPizarraInterno").ToString() = DBNull.Value.ToString(), String.Empty, reader("IdPizarraInterno").ToString),
                        .NroLegalOrdenTrabajo = IIf(reader("NroLegalOrdenTrabajo").ToString() = DBNull.Value.ToString(), String.Empty, reader("NroLegalOrdenTrabajo").ToString),
                        .NombreCliente = IIf(reader("Cliente").ToString() = DBNull.Value.ToString(), String.Empty, reader("Cliente").ToString),
                        .NombreProducto = IIf(reader("Producto").ToString() = DBNull.Value.ToString(), String.Empty, reader("Producto").ToString),
                        .FechaEnviadoCliche = IIf(reader("FechaEnviadoCliche").ToString() = DBNull.Value.ToString(), Nothing, reader("FechaEnviadoCliche")),
                        .FechaEnviadoProceso = IIf(reader("FechaEnviadoProceso").ToString() = DBNull.Value.ToString(), Nothing, reader("FechaEnviadoProceso")),
                        .FechaIniSemEnviadoCliche = IIf(reader("FechaIniSemEnviadoCliche").ToString() = DBNull.Value.ToString(), Nothing, reader("FechaIniSemEnviadoCliche")),
                        .FechaFinSemEnviadoCliche = IIf(reader("FechaFinSemEnviadoCliche").ToString() = DBNull.Value.ToString(), Nothing, reader("FechaFinSemEnviadoCliche")),
                        .FechaIniSemEnviadoProceso = IIf(reader("FechaIniSemEnviadoProceso").ToString() = DBNull.Value.ToString(), Nothing, reader("FechaIniSemEnviadoProceso")),
                        .FechaFinSemEnviadoProceso = IIf(reader("FechaFinSemEnviadoProceso").ToString() = DBNull.Value.ToString(), Nothing, reader("FechaFinSemEnviadoProceso")),
                        .TiempoPreprensa = IIf(reader("TiempoDePreprensa").ToString() = DBNull.Value.ToString(), Nothing, reader("TiempoDePreprensa")),
                        .IdEventoControl = IIf(reader("IdEventoControl").ToString() = DBNull.Value.ToString(), Nothing, reader("IdEventoControl"))
                                             })

                End While

            End If

            reader.Close()
            cn.Close()
            cmd.Dispose()

        Catch ex As Exception
            result.CodigoError = Enumerated.ResponseCode.CodigoErrorAplicacion
            result.DescripcionError = ex.Message
        End Try

        Return result
    End Function

    Public Function ListarPreprensasSemana(ByVal itemRequest As DiseñoIndicadoresPreprensasRequest) As DiseñoIndicadoresPreprensasResponse

        Dim result As DiseñoIndicadoresPreprensasResponse = New DiseñoIndicadoresPreprensasResponse()
        result.ListaIndicadorPreprensasSemana = New List(Of DiseñoIndicadoresPreprensasEL)()

        Dim cn As SqlConnection = New SqlConnection()
        Dim conexion As DataBaseConnection = New DataBaseConnection()

        Try

            cn = conexion.GetSql()
            cn.Open()

            Dim cmd As SqlCommand = cn.CreateCommand()
            cmd.CommandTimeout = 120
            cmd.CommandType = System.Data.CommandType.StoredProcedure
            cmd.CommandText = "RES124_PizarraDiseñoPreprensaKPISemanas"
            cmd.Parameters.Clear()
            cmd.Parameters.Add(New SqlParameter("@FechaEnviadoProceso", SqlDbType.DateTime)).Value = IIf(String.IsNullOrWhiteSpace(itemRequest.FechaEnviadoProceso), DBNull.Value, itemRequest.FechaEnviadoProceso)

            Dim reader = cmd.ExecuteReader()

            If reader.HasRows Then

                While (reader.Read())

                    result.ListaIndicadorPreprensasSemana.Add(New DiseñoIndicadoresPreprensasEL() With {
                        .NumeroSemana = IIf(reader("NumeroSemana").ToString() = DBNull.Value.ToString(), String.Empty, reader("NumeroSemana").ToString),
                        .Año = IIf(reader("año").ToString() = DBNull.Value.ToString(), String.Empty, reader("año").ToString),
                        .FechaIniSemEnviadoProceso = IIf(reader("FechaIniSemEnviadoProceso").ToString() = DBNull.Value.ToString(), Nothing, reader("FechaIniSemEnviadoProceso")),
                        .FechaFinSemEnviadoProceso = IIf(reader("FechaFinSemEnviadoProceso").ToString() = DBNull.Value.ToString(), Nothing, reader("FechaFinSemEnviadoProceso")),
                        .PromedioSem = IIf(reader("PromedioSem").ToString() = DBNull.Value.ToString(), String.Empty, reader("PromedioSem").ToString),
                        .TotalTrabajos = IIf(reader("TotalTrabajos").ToString() = DBNull.Value.ToString(), String.Empty, reader("TotalTrabajos").ToString),
                        .TrabajosSinCompletar = IIf(reader("TotalTrabajosNoCompletado").ToString() = DBNull.Value.ToString(), String.Empty, reader("TotalTrabajosNoCompletado").ToString)
                                             })

                End While

            End If

            reader.Close()
            cn.Close()
            cmd.Dispose()

        Catch ex As Exception
            result.CodigoError = Enumerated.ResponseCode.CodigoErrorAplicacion
            result.DescripcionError = ex.Message
        End Try

        Return result
    End Function

    Public Function ListarPreprensasCompletadasSemana(ByVal itemRequest As DiseñoIndicadoresPreprensasRequest) As DiseñoIndicadoresPreprensasResponse

        Dim result As DiseñoIndicadoresPreprensasResponse = New DiseñoIndicadoresPreprensasResponse()
        result.ListaIndicadorPreprensasCompletadasSemana = New List(Of DiseñoIndicadoresPreprensasEL)()

        Dim cn As SqlConnection = New SqlConnection()
        Dim conexion As DataBaseConnection = New DataBaseConnection()

        Try

            cn = conexion.GetSql()
            cn.Open()

            Dim cmd As SqlCommand = cn.CreateCommand()
            cmd.CommandTimeout = 120
            cmd.CommandType = System.Data.CommandType.StoredProcedure
            cmd.CommandText = "RES124_PizarraDiseñoPreprensaKPICompletadasPorSemanas"
            cmd.Parameters.Clear()
            cmd.Parameters.Add(New SqlParameter("@FechaEnviadoProceso", SqlDbType.DateTime)).Value = IIf(String.IsNullOrWhiteSpace(itemRequest.FechaEnviadoProceso), DBNull.Value, itemRequest.FechaEnviadoProceso)

            Dim reader = cmd.ExecuteReader()

            If reader.HasRows Then

                While (reader.Read())

                    result.ListaIndicadorPreprensasCompletadasSemana.Add(New DiseñoIndicadoresPreprensasEL() With {
                        .NumeroSemana = IIf(reader("NumeroSemana").ToString() = DBNull.Value.ToString(), String.Empty, reader("NumeroSemana").ToString),
                        .Año = IIf(reader("año").ToString() = DBNull.Value.ToString(), String.Empty, reader("año").ToString),
                        .FechaIniSemEnviadoCliche = IIf(reader("FechaIniSemEnviadoCliche").ToString() = DBNull.Value.ToString(), Nothing, reader("FechaIniSemEnviadoCliche")),
                        .FechaFinSemEnviadoCliche = IIf(reader("FechaFinSemEnviadoCliche").ToString() = DBNull.Value.ToString(), Nothing, reader("FechaFinSemEnviadoCliche")),
                        .PromedioSem = IIf(reader("PromedioSem").ToString() = DBNull.Value.ToString(), String.Empty, reader("PromedioSem").ToString),
                        .TotalTrabajos = IIf(reader("TotalTrabajos").ToString() = DBNull.Value.ToString(), String.Empty, reader("TotalTrabajos").ToString),
                        .TrabajosSinCompletar = IIf(reader("TotalTrabajosNoCompletado").ToString() = DBNull.Value.ToString(), String.Empty, reader("TotalTrabajosNoCompletado").ToString)
                                             })

                End While

            End If

            reader.Close()
            cn.Close()
            cmd.Dispose()

        Catch ex As Exception
            result.CodigoError = Enumerated.ResponseCode.CodigoErrorAplicacion
            result.DescripcionError = ex.Message
        End Try

        Return result
    End Function


    Public Function ListarPrepensaDiaPruebaColor(ByVal itemRequest As DiseñoIndicadoresPreprensasRequest) As DiseñoIndicadoresPreprensasResponse

        Dim result As DiseñoIndicadoresPreprensasResponse = New DiseñoIndicadoresPreprensasResponse()
        result.ListaIndicadorPreprensasDiaPruebaColor = New List(Of DiseñoIndicadoresPreprensasEL)()

        Dim cn As SqlConnection = New SqlConnection()
        Dim conexion As DataBaseConnection = New DataBaseConnection()

        Try

            cn = conexion.GetSql()
            cn.Open()

            Dim cmd As SqlCommand = cn.CreateCommand()
            cmd.CommandTimeout = 120
            cmd.CommandType = System.Data.CommandType.StoredProcedure
            cmd.CommandText = "RES124_PizarraDiseñoPreprensaKPIDiasPruebaColor"
            cmd.Parameters.Clear()
            cmd.Parameters.Add(New SqlParameter("@FechaEnviadoProceso", SqlDbType.DateTime)).Value = IIf(String.IsNullOrWhiteSpace(itemRequest.FechaEnviadoProceso), DBNull.Value, itemRequest.FechaEnviadoProceso)

            Dim reader = cmd.ExecuteReader()

            If reader.HasRows Then

                While (reader.Read())
                    result.ListaIndicadorPreprensasDiaPruebaColor.Add(New DiseñoIndicadoresPreprensasEL() With {
                        .FechaEnviadoCliche = IIf(reader("FechaEnviadoCliche").ToString() = DBNull.Value.ToString(), Nothing, reader("FechaEnviadoCliche")),
                        .TotalTrabajos = IIf(reader("TotalTrabajos").ToString() = DBNull.Value.ToString(), String.Empty, reader("TotalTrabajos").ToString),
                        .TotalTrabajosmes = IIf(reader("Trabajopormes").ToString() = DBNull.Value.ToString(), String.Empty, reader("Trabajopormes").ToString),
                        .TrabajosPromedio = IIf(reader("TrabajosPromedio").ToString() = DBNull.Value.ToString(), 0, reader("TrabajosPromedio").ToString)
                                             })

                End While


            End If

            reader.Close()
            cn.Close()
            cmd.Dispose()

        Catch ex As Exception
            result.CodigoError = Enumerated.ResponseCode.CodigoErrorAplicacion
            result.DescripcionError = ex.Message
        End Try

        Return result
    End Function

End Class
