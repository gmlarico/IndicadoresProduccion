Imports System.Data.SqlClient
Imports Resinplast.Indicadores.Utils
Imports Resinplast.Indicadores.Wrapper
Public Class DiseñoIndicadoresAperturasDomain

    Public Function ListarAperturasDia(ByVal itemRequest As DiseñoIndicadoresAperturaRequest) As DiseñoIndicadoresAperturaResponse

        Dim result As DiseñoIndicadoresAperturaResponse = New DiseñoIndicadoresAperturaResponse()
        result.ListaIndicadorAperturasDia = New List(Of DiseñoIndicadoresAperturaEL)()

        Dim cn As SqlConnection = New SqlConnection()
        Dim conexion As DataBaseConnection = New DataBaseConnection()

        Try

            cn = conexion.GetSql()
            cn.Open()

            Dim cmd As SqlCommand = cn.CreateCommand()
            cmd.CommandTimeout = 120
            cmd.CommandType = System.Data.CommandType.StoredProcedure
            cmd.CommandText = "RES124_PizarraDiseñoAperturasKPIDias"
            cmd.Parameters.Clear()
            cmd.Parameters.Add(New SqlParameter("@FechaEnAprobacionCliente", SqlDbType.DateTime)).Value = IIf(String.IsNullOrWhiteSpace(itemRequest.FechaEnAprobacionCliente), DBNull.Value, itemRequest.FechaEnAprobacionCliente)

            Dim reader = cmd.ExecuteReader()

            If reader.HasRows Then

                While (reader.Read())

                    result.ListaIndicadorAperturasDia.Add(New DiseñoIndicadoresAperturaEL() With {
                        .FechaEnAprobacionCliente = IIf(reader("FechaEnAprobacionCliente").ToString() = DBNull.Value.ToString(), Nothing, reader("FechaEnAprobacionCliente")),
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

    Public Function ListarAperturasDiaDetalle(ByVal itemRequest As DiseñoIndicadoresAperturaRequest) As DiseñoIndicadoresAperturaResponse

        Dim result As DiseñoIndicadoresAperturaResponse = New DiseñoIndicadoresAperturaResponse()
        result.ListaIndicadorAperturasDiaDetalle = New List(Of DiseñoIndicadoresAperturaEL)()

        Dim cn As SqlConnection = New SqlConnection()
        Dim conexion As DataBaseConnection = New DataBaseConnection()

        Try

            cn = conexion.GetSql()
            cn.Open()

            Dim cmd As SqlCommand = cn.CreateCommand()
            cmd.CommandTimeout = 120
            cmd.CommandType = System.Data.CommandType.StoredProcedure
            cmd.CommandText = "RES124_PizarraDiseñoAperturasKPIDiasDetalle"
            cmd.Parameters.Clear()

            cmd.Parameters.Add(New SqlParameter("@FechaEnAprobacionCliente", SqlDbType.DateTime)).Value = IIf(String.IsNullOrWhiteSpace(itemRequest.FechaEnAprobacionCliente) Or itemRequest.FechaEnAprobacionCliente.Ticks <= 0, Nothing, itemRequest.FechaEnAprobacionCliente)
            cmd.Parameters.Add(New SqlParameter("@FechaIniSemEnviadoDiseno", SqlDbType.DateTime)).Value = IIf(String.IsNullOrWhiteSpace(itemRequest.FechaIniSemEnviadoDiseno) Or itemRequest.FechaIniSemEnviadoDiseno.Ticks <= 0, Nothing, itemRequest.FechaIniSemEnviadoDiseno)
            cmd.Parameters.Add(New SqlParameter("@FechaIniSemEnAprobacionCliente", SqlDbType.DateTime)).Value = IIf(String.IsNullOrWhiteSpace(itemRequest.FechaIniSemEnAprobacionCliente) Or itemRequest.FechaIniSemEnAprobacionCliente.Ticks <= 0, Nothing, itemRequest.FechaIniSemEnAprobacionCliente)
            'cmd.Parameters.Add(New SqlParameter("@NombreEjecutivo", SqlDbType.VarChar, 250)).Value = IIf(String.IsNullOrWhiteSpace(itemRequest.NombreEjecutivo), DBNull.Value, itemRequest.NombreEjecutivo.Trim())

            Dim reader = cmd.ExecuteReader()

            If reader.HasRows Then

                While (reader.Read())
                    result.ListaIndicadorAperturasDiaDetalle.Add(New DiseñoIndicadoresAperturaEL() With {
                        .IdOrdenTrabajo = IIf(reader("IdOrdenTrabajo").ToString() = DBNull.Value.ToString(), String.Empty, reader("IdOrdenTrabajo").ToString),
                        .NroLegalOrdenTrabajo = IIf(reader("NroLegalOrdenTrabajo").ToString() = DBNull.Value.ToString(), String.Empty, reader("NroLegalOrdenTrabajo").ToString),
                        .NombreCliente = IIf(reader("NombreCliente").ToString() = DBNull.Value.ToString(), String.Empty, reader("NombreCliente").ToString),
                        .NombreProducto = IIf(reader("NombreProducto").ToString() = DBNull.Value.ToString(), String.Empty, reader("NombreProducto").ToString),
                        .FechaEnAprobacionCliente = IIf(reader("FechaEnAprobacionCliente").ToString() = DBNull.Value.ToString(), Nothing, reader("FechaEnAprobacionCliente")),
                        .FechaEnviadoDiseno = IIf(reader("FechaEnviadoDiseno").ToString() = DBNull.Value.ToString(), Nothing, reader("FechaEnviadoDiseno").ToString),
                        .FechaIniSemEnAprobacionCliente = IIf(reader("FechaIniSemEnAprobacionCliente").ToString() = DBNull.Value.ToString(), Nothing, reader("FechaIniSemEnAprobacionCliente")),
                        .FechaFinSemEnAprobacionCliente = IIf(reader("FechaFinSemEnAprobacionCliente").ToString() = DBNull.Value.ToString(), Nothing, reader("FechaFinSemEnAprobacionCliente")),
                        .FechaIniSemEnviadoDiseno = IIf(reader("FechaIniSemEnviadoDiseno").ToString() = DBNull.Value.ToString(), Nothing, reader("FechaIniSemEnviadoDiseno")),
                        .FechaFinSemEnviadoDiseno = IIf(reader("FechaFinSemEnviadoDiseno").ToString() = DBNull.Value.ToString(), Nothing, reader("FechaFinSemEnviadoDiseno")),
                        .TiempoAperturaHoras = IIf(reader("HorasApertura").ToString() = DBNull.Value.ToString(), Nothing, reader("HorasApertura").ToString),
                        .TiempoDeApertura = IIf(reader("TiempoDeApertura").ToString() = DBNull.Value.ToString(), Nothing, reader("TiempoDeApertura").ToString),
                        .UsuarioEnAprobacionCliente = IIf(reader("UsuarioEnAprobacionCliente").ToString() = DBNull.Value.ToString(), Nothing, reader("UsuarioEnAprobacionCliente").ToString),
                        .UsuarioEnviadoDiseno = IIf(reader("UsuarioEnviadoDiseno").ToString() = DBNull.Value.ToString(), Nothing, reader("UsuarioEnviadoDiseno").ToString)
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

    Public Function ListarAperturasSemana(ByVal itemRequest As DiseñoIndicadoresAperturaRequest) As DiseñoIndicadoresAperturaResponse

        Dim result As DiseñoIndicadoresAperturaResponse = New DiseñoIndicadoresAperturaResponse()
        result.ListaIndicadorAperturasSemana = New List(Of DiseñoIndicadoresAperturaEL)()

        Dim cn As SqlConnection = New SqlConnection()
        Dim conexion As DataBaseConnection = New DataBaseConnection()

        Try

            cn = conexion.GetSql()
            cn.Open()

            Dim cmd As SqlCommand = cn.CreateCommand()
            cmd.CommandTimeout = 120
            cmd.CommandType = System.Data.CommandType.StoredProcedure
            cmd.CommandText = "RES124_PizarraDiseñoAperturasKPIsemanas"
            cmd.Parameters.Clear()
            cmd.Parameters.Add(New SqlParameter("@FechaEnAprobacionCliente", SqlDbType.DateTime)).Value = IIf(String.IsNullOrWhiteSpace(itemRequest.FechaEnAprobacionCliente), DBNull.Value, itemRequest.FechaEnAprobacionCliente)

            Dim reader = cmd.ExecuteReader()

            If reader.HasRows Then

                While (reader.Read())

                    result.ListaIndicadorAperturasSemana.Add(New DiseñoIndicadoresAperturaEL() With {
                        .NumeroSemana = IIf(reader("NumeroSemana").ToString() = DBNull.Value.ToString(), String.Empty, reader("NumeroSemana").ToString),
                        .Año = IIf(reader("año").ToString() = DBNull.Value.ToString(), String.Empty, reader("año").ToString),
                        .FechaIniSemEnviadoDiseno = IIf(reader("FechaIniSemEnviadoDiseno").ToString() = DBNull.Value.ToString(), Nothing, reader("FechaIniSemEnviadoDiseno").ToString),
                        .FechaFinSemEnviadoDiseno = IIf(reader("FechaFinSemEnviadoDiseno").ToString() = DBNull.Value.ToString(), Nothing, reader("FechaFinSemEnviadoDiseno").ToString),
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



    Public Function ListarAperturasCompletadasSemana(ByVal itemRequest As DiseñoIndicadoresAperturaRequest) As DiseñoIndicadoresAperturaResponse

        Dim result As DiseñoIndicadoresAperturaResponse = New DiseñoIndicadoresAperturaResponse()
        result.ListaIndicadorAperturasCompletadasSemana = New List(Of DiseñoIndicadoresAperturaEL)()

        Dim cn As SqlConnection = New SqlConnection()
        Dim conexion As DataBaseConnection = New DataBaseConnection()

        Try

            cn = conexion.GetSql()
            cn.Open()

            Dim cmd As SqlCommand = cn.CreateCommand()
            cmd.CommandTimeout = 120
            cmd.CommandType = System.Data.CommandType.StoredProcedure
            cmd.CommandText = "RES124_PizarraDiseñoAperturasKPICompletadasPorSemana"
            cmd.Parameters.Clear()
            cmd.Parameters.Add(New SqlParameter("@FechaEnAprobacionCliente", SqlDbType.DateTime)).Value = IIf(String.IsNullOrWhiteSpace(itemRequest.FechaEnAprobacionCliente), DBNull.Value, itemRequest.FechaEnAprobacionCliente)

            Dim reader = cmd.ExecuteReader()

            If reader.HasRows Then

                While (reader.Read())

                    result.ListaIndicadorAperturasCompletadasSemana.Add(New DiseñoIndicadoresAperturaEL() With {
                        .NumeroSemana = IIf(reader("NumeroSemana").ToString() = DBNull.Value.ToString(), String.Empty, reader("NumeroSemana").ToString),
                        .Año = IIf(reader("año").ToString() = DBNull.Value.ToString(), String.Empty, reader("año").ToString),
                        .FechaIniSemEnAprobacionCliente = IIf(reader("FechaIniSemEnAprobacionCliente").ToString() = DBNull.Value.ToString(), Nothing, reader("FechaIniSemEnAprobacionCliente").ToString),
                        .FechaFinSemEnAprobacionCliente = IIf(reader("FechaFinSemEnAprobacionCliente").ToString() = DBNull.Value.ToString(), Nothing, reader("FechaFinSemEnAprobacionCliente").ToString),
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

    Public Function ListarAperturasCompletadasPorUsuario(ByVal itemRequest As DiseñoIndicadoresAperturaRequest) As DiseñoIndicadoresAperturaResponse

        Dim result As DiseñoIndicadoresAperturaResponse = New DiseñoIndicadoresAperturaResponse()
        result.ListarAperturasCompletadasPorUsuario = New List(Of DiseñoIndicadoresAperturaEL)()

        Dim cn As SqlConnection = New SqlConnection()
        Dim conexion As DataBaseConnection = New DataBaseConnection()

        Try

            cn = conexion.GetSql()
            cn.Open()

            Dim cmd As SqlCommand = cn.CreateCommand()
            cmd.CommandTimeout = 120
            cmd.CommandType = System.Data.CommandType.StoredProcedure
            cmd.CommandText = "RES124_PizarraDiseñoAperturasKPI_PorUsuario"
            cmd.Parameters.Clear()
            cmd.Parameters.Add(New SqlParameter("@FechaEnAprobacionCliente", SqlDbType.DateTime)).Value = IIf(String.IsNullOrWhiteSpace(itemRequest.FechaEnAprobacionCliente), DBNull.Value, itemRequest.FechaEnAprobacionCliente)

            Dim reader = cmd.ExecuteReader()

            If reader.HasRows Then

                While (reader.Read())

                    result.ListarAperturasCompletadasPorUsuario.Add(New DiseñoIndicadoresAperturaEL() With {
                        .UsuarioEnAprobacionCliente = IIf(reader("UsuarioEnAprobacionCliente").ToString() = DBNull.Value.ToString(), String.Empty, reader("UsuarioEnAprobacionCliente").ToString),
                        .TotalTrabajos = IIf(reader("TotalTrabajos").ToString() = DBNull.Value.ToString(), String.Empty, reader("TotalTrabajos").ToString)
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
