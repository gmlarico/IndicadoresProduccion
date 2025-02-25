Imports System.Data.SqlClient
Imports Resinplast.Indicadores.Utils
Imports Resinplast.Indicadores.Wrapper
Public Class ImpresionIndicadoresSetUpDomain

    Public Function ListaIndicadoresSetUpIndividual(ByVal itemRequest As ImpresionIndicadoresSetUpRequest) As ImpresionIndicadoresSetUpResponse

        Dim result As ImpresionIndicadoresSetUpResponse = New ImpresionIndicadoresSetUpResponse()
        result.ListaIndicadoresSetUp = New List(Of ImpresionIndicadoresSetUpEL)()

        Dim cn As SqlConnection = New SqlConnection()
        Dim conexion As DataBaseConnection = New DataBaseConnection()

        Try

            cn = conexion.GetSql()
            cn.Open()

            Dim cmd As SqlCommand = cn.CreateCommand()
            cmd.CommandTimeout = 120
            cmd.CommandType = System.Data.CommandType.StoredProcedure
            cmd.CommandText = "RES136_IndicadoresImpresionSetUp"
            cmd.Parameters.Clear()
            cmd.Parameters.Add(New SqlParameter("@TipoRecurso", SqlDbType.VarChar, 15)).Value = IIf(String.IsNullOrWhiteSpace(itemRequest.TipoRecurso), DBNull.Value, itemRequest.TipoRecurso)
            cmd.Parameters.Add(New SqlParameter("@FechaInicio", SqlDbType.DateTime)).Value = IIf(String.IsNullOrWhiteSpace(itemRequest.BuscarFechaInicio), DBNull.Value, itemRequest.BuscarFechaInicio)
            cmd.Parameters.Add(New SqlParameter("@FechaFin", SqlDbType.DateTime)).Value = IIf(String.IsNullOrWhiteSpace(itemRequest.BuscarFechaFin), DBNull.Value, itemRequest.BuscarFechaFin)

            Dim reader = cmd.ExecuteReader()

            If reader.HasRows Then

                While (reader.Read())

                    result.ListaIndicadoresSetUp.Add(New ImpresionIndicadoresSetUpEL() With {
                        .IdRecurso = IIf(reader("Recurso").ToString() = DBNull.Value.ToString(), Nothing, reader("Recurso")),
                        .Año = IIf(reader("Año").ToString() = DBNull.Value.ToString(), Nothing, reader("Año")),
                        .Mes = IIf(reader("Mes").ToString() = DBNull.Value.ToString(), String.Empty, reader("Mes")),
                        .NumeroCambios = IIf(reader("NumeroCambios").ToString() = DBNull.Value.ToString(), String.Empty, reader("NumeroCambios")),
                        .SetUpPromedio = IIf(reader("SetUpPromedio").ToString() = DBNull.Value.ToString(), 0, reader("SetUpPromedio")),
                        .SetUpObjetivo = IIf(reader("SetUpObjetivo").ToString() = DBNull.Value.ToString(), 0, reader("SetUpObjetivo"))
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

    Public Function ListaIndicadoresSetUpTotal(ByVal itemRequest As ImpresionIndicadoresSetUpRequest) As ImpresionIndicadoresSetUpResponse

        Dim result As ImpresionIndicadoresSetUpResponse = New ImpresionIndicadoresSetUpResponse()
        result.ListaIndicadoresSetUp = New List(Of ImpresionIndicadoresSetUpEL)()

        Dim cn As SqlConnection = New SqlConnection()
        Dim conexion As DataBaseConnection = New DataBaseConnection()

        Try

            cn = conexion.GetSql()
            cn.Open()

            Dim cmd As SqlCommand = cn.CreateCommand()
            cmd.CommandTimeout = 120
            cmd.CommandType = System.Data.CommandType.StoredProcedure
            cmd.CommandText = "RES136_IndicadoresImpresionSetUp"
            cmd.Parameters.Clear()
            cmd.Parameters.Add(New SqlParameter("@TipoRecurso", SqlDbType.VarChar, 15)).Value = IIf(String.IsNullOrWhiteSpace(itemRequest.TipoRecurso), DBNull.Value, itemRequest.TipoRecurso)
            cmd.Parameters.Add(New SqlParameter("@FechaInicio", SqlDbType.DateTime)).Value = IIf(String.IsNullOrWhiteSpace(itemRequest.BuscarFechaInicio), DBNull.Value, itemRequest.BuscarFechaInicio)
            cmd.Parameters.Add(New SqlParameter("@FechaFin", SqlDbType.DateTime)).Value = IIf(String.IsNullOrWhiteSpace(itemRequest.BuscarFechaFin), DBNull.Value, itemRequest.BuscarFechaFin)

            Dim reader = cmd.ExecuteReader()

            If reader.HasRows Then

                While (reader.Read())

                    result.ListaIndicadoresSetUp.Add(New ImpresionIndicadoresSetUpEL() With {
                        .Año = IIf(reader("Año").ToString() = DBNull.Value.ToString(), Nothing, reader("Año")),
                        .Mes = IIf(reader("Mes").ToString() = DBNull.Value.ToString(), String.Empty, reader("Mes")),
                        .NumeroCambios = IIf(reader("NumeroCambios").ToString() = DBNull.Value.ToString(), String.Empty, reader("NumeroCambios")),
                        .SetUpPromedio = IIf(reader("SetUpPromedio").ToString() = DBNull.Value.ToString(), 0, reader("SetUpPromedio")),
                        .SetUpObjetivo = IIf(reader("SetUpObjetivo").ToString() = DBNull.Value.ToString(), 0, reader("SetUpObjetivo"))
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

    Public Function ListaIndicadoresSetUpConHeptacromia(ByVal itemRequest As ImpresionIndicadoresSetUpRequest) As ImpresionIndicadoresSetUpResponse

        Dim result As ImpresionIndicadoresSetUpResponse = New ImpresionIndicadoresSetUpResponse()
        result.ListaIndicadoresSetUpConHeptacromia = New List(Of ImpresionIndicadoresSetUpEL)()

        Dim cn As SqlConnection = New SqlConnection()
        Dim conexion As DataBaseConnection = New DataBaseConnection()

        Try

            cn = conexion.GetSql()
            cn.Open()

            Dim cmd As SqlCommand = cn.CreateCommand()
            cmd.CommandTimeout = 120
            cmd.CommandType = System.Data.CommandType.StoredProcedure
            cmd.CommandText = "RES136_IndicadoresImpresionSetUpConHeptacromia"
            cmd.Parameters.Clear()
            cmd.Parameters.Add(New SqlParameter("@TipoRecurso", SqlDbType.VarChar, 15)).Value = IIf(String.IsNullOrWhiteSpace(itemRequest.TipoRecurso), DBNull.Value, itemRequest.TipoRecurso)
            cmd.Parameters.Add(New SqlParameter("@FechaInicio", SqlDbType.DateTime)).Value = IIf(String.IsNullOrWhiteSpace(itemRequest.BuscarFechaInicio), DBNull.Value, itemRequest.BuscarFechaInicio)
            cmd.Parameters.Add(New SqlParameter("@FechaFin", SqlDbType.DateTime)).Value = IIf(String.IsNullOrWhiteSpace(itemRequest.BuscarFechaFin), DBNull.Value, itemRequest.BuscarFechaFin)

            Dim reader = cmd.ExecuteReader()

            If reader.HasRows Then

                While (reader.Read())

                    result.ListaIndicadoresSetUpConHeptacromia.Add(New ImpresionIndicadoresSetUpEL() With {
                        .IdRecurso = IIf(reader("Recurso").ToString() = DBNull.Value.ToString(), Nothing, reader("Recurso")),
                        .Año = IIf(reader("Año").ToString() = DBNull.Value.ToString(), Nothing, reader("Año")),
                        .Mes = IIf(reader("Mes").ToString() = DBNull.Value.ToString(), String.Empty, reader("Mes")),
                        .NumeroCambios = IIf(reader("NumeroCambios").ToString() = DBNull.Value.ToString(), String.Empty, reader("NumeroCambios")),
                        .HorasAcumuladas = IIf(reader("HorasAcumuladas").ToString() = DBNull.Value.ToString(), String.Empty, reader("HorasAcumuladas")),
                        .SetUpPromedioHeptacromia = IIf(reader("SetUpPromedioHeptacromia").ToString() = DBNull.Value.ToString(), 0, reader("SetUpPromedioHeptacromia")),
                        .SetUpObjetivoHeptacromia = IIf(reader("SetUpObjetivoHeptacromia").ToString() = DBNull.Value.ToString(), 0, reader("SetUpObjetivoHeptacromia"))
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

    Public Function ListaIndicadoresSetUpSinHeptacromiaIndividual(ByVal itemRequest As ImpresionIndicadoresSetUpRequest) As ImpresionIndicadoresSetUpResponse

        Dim result As ImpresionIndicadoresSetUpResponse = New ImpresionIndicadoresSetUpResponse()
        result.ListaIndicadoresSetUpSinHeptacromia = New List(Of ImpresionIndicadoresSetUpEL)()

        Dim cn As SqlConnection = New SqlConnection()
        Dim conexion As DataBaseConnection = New DataBaseConnection()

        Try

            cn = conexion.GetSql()
            cn.Open()

            Dim cmd As SqlCommand = cn.CreateCommand()
            cmd.CommandTimeout = 120
            cmd.CommandType = System.Data.CommandType.StoredProcedure
            cmd.CommandText = "RES136_IndicadoresImpresionSetUpSinHeptacromia"
            cmd.Parameters.Clear()
            cmd.Parameters.Add(New SqlParameter("@TipoRecurso", SqlDbType.VarChar, 15)).Value = IIf(String.IsNullOrWhiteSpace(itemRequest.TipoRecurso), DBNull.Value, itemRequest.TipoRecurso)
            cmd.Parameters.Add(New SqlParameter("@FechaInicio", SqlDbType.DateTime)).Value = IIf(String.IsNullOrWhiteSpace(itemRequest.BuscarFechaInicio), DBNull.Value, itemRequest.BuscarFechaInicio)
            cmd.Parameters.Add(New SqlParameter("@FechaFin", SqlDbType.DateTime)).Value = IIf(String.IsNullOrWhiteSpace(itemRequest.BuscarFechaFin), DBNull.Value, itemRequest.BuscarFechaFin)

            Dim reader = cmd.ExecuteReader()

            If reader.HasRows Then

                While (reader.Read())

                    result.ListaIndicadoresSetUpSinHeptacromia.Add(New ImpresionIndicadoresSetUpEL() With {
                        .IdRecurso = IIf(reader("Recurso").ToString() = DBNull.Value.ToString(), Nothing, reader("Recurso")),
                        .Año = IIf(reader("Año").ToString() = DBNull.Value.ToString(), Nothing, reader("Año")),
                        .Mes = IIf(reader("Mes").ToString() = DBNull.Value.ToString(), String.Empty, reader("Mes")),
                        .NumeroCambios = IIf(reader("NumeroCambios").ToString() = DBNull.Value.ToString(), String.Empty, reader("NumeroCambios")),
                        .HorasAcumuladas = IIf(reader("HorasAcumuladas").ToString() = DBNull.Value.ToString(), String.Empty, reader("HorasAcumuladas")),
                        .SetUpPromedioSinHeptacromia = IIf(reader("SetUpPromedioSinHeptacromia").ToString() = DBNull.Value.ToString(), 0, reader("SetUpPromedioSinHeptacromia")),
                        .SetUpObjetivoSinHeptacromia = IIf(reader("SetUpObjetivoSinHeptacromia").ToString() = DBNull.Value.ToString(), 0, reader("SetUpObjetivoSinHeptacromia"))
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

    Public Function ListaIndicadoresSetUpSinHeptacromiaTotal(ByVal itemRequest As ImpresionIndicadoresSetUpRequest) As ImpresionIndicadoresSetUpResponse

        Dim result As ImpresionIndicadoresSetUpResponse = New ImpresionIndicadoresSetUpResponse()
        result.ListaIndicadoresSetUpSinHeptacromia = New List(Of ImpresionIndicadoresSetUpEL)()

        Dim cn As SqlConnection = New SqlConnection()
        Dim conexion As DataBaseConnection = New DataBaseConnection()

        Try

            cn = conexion.GetSql()
            cn.Open()

            Dim cmd As SqlCommand = cn.CreateCommand()
            cmd.CommandTimeout = 120
            cmd.CommandType = System.Data.CommandType.StoredProcedure
            cmd.CommandText = "RES136_IndicadoresImpresionSetUpSinHeptacromia"
            cmd.Parameters.Clear()
            cmd.Parameters.Add(New SqlParameter("@TipoRecurso", SqlDbType.VarChar, 15)).Value = IIf(String.IsNullOrWhiteSpace(itemRequest.TipoRecurso), DBNull.Value, itemRequest.TipoRecurso)
            cmd.Parameters.Add(New SqlParameter("@FechaInicio", SqlDbType.DateTime)).Value = IIf(String.IsNullOrWhiteSpace(itemRequest.BuscarFechaInicio), DBNull.Value, itemRequest.BuscarFechaInicio)
            cmd.Parameters.Add(New SqlParameter("@FechaFin", SqlDbType.DateTime)).Value = IIf(String.IsNullOrWhiteSpace(itemRequest.BuscarFechaFin), DBNull.Value, itemRequest.BuscarFechaFin)

            Dim reader = cmd.ExecuteReader()

            If reader.HasRows Then

                While (reader.Read())

                    result.ListaIndicadoresSetUpSinHeptacromia.Add(New ImpresionIndicadoresSetUpEL() With {
                        .Año = IIf(reader("Año").ToString() = DBNull.Value.ToString(), Nothing, reader("Año")),
                        .Mes = IIf(reader("Mes").ToString() = DBNull.Value.ToString(), String.Empty, reader("Mes")),
                        .NumeroCambios = IIf(reader("NumeroCambios").ToString() = DBNull.Value.ToString(), String.Empty, reader("NumeroCambios")),
                        .HorasAcumuladas = IIf(reader("HorasAcumuladas").ToString() = DBNull.Value.ToString(), String.Empty, reader("HorasAcumuladas")),
                        .SetUpPromedioSinHeptacromia = IIf(reader("SetUpPromedioSinHeptacromia").ToString() = DBNull.Value.ToString(), 0, reader("SetUpPromedioSinHeptacromia")),
                        .SetUpObjetivoSinHeptacromia = IIf(reader("SetUpObjetivoSinHeptacromia").ToString() = DBNull.Value.ToString(), 0, reader("SetUpObjetivoSinHeptacromia"))
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
