Imports System.Data.SqlClient
Imports Resinplast.Indicadores.Utils
Imports Resinplast.Indicadores.Wrapper
Public Class ImpresionIndicadoresMetrosDomain

    Public Function ListaIndicadoresMetrosIndividuales(ByVal itemRequest As ImpresionIndicadoresMetrosRequest) As ImpresionIndicadoresMetrosResponse

        Dim result As ImpresionIndicadoresMetrosResponse = New ImpresionIndicadoresMetrosResponse()
        result.ListaProduccionMetros = New List(Of ImpresionIndicadoresMetrosEL)()

        Dim cn As SqlConnection = New SqlConnection()
        Dim conexion As DataBaseConnection = New DataBaseConnection()

        Try

            cn = conexion.GetSql()
            cn.Open()

            Dim cmd As SqlCommand = cn.CreateCommand()
            cmd.CommandTimeout = 120
            cmd.CommandType = System.Data.CommandType.StoredProcedure
            cmd.CommandText = "RES136_IndicadoresImpresionMetros"
            cmd.Parameters.Clear()
            cmd.Parameters.Add(New SqlParameter("@TipoRecurso", SqlDbType.VarChar, 15)).Value = IIf(String.IsNullOrWhiteSpace(itemRequest.TipoRecurso), DBNull.Value, itemRequest.TipoRecurso)
            cmd.Parameters.Add(New SqlParameter("@FechaInicio", SqlDbType.DateTime)).Value = IIf(String.IsNullOrWhiteSpace(itemRequest.BuscarFechaInicio), DBNull.Value, itemRequest.BuscarFechaInicio)
            cmd.Parameters.Add(New SqlParameter("@FechaFin", SqlDbType.DateTime)).Value = IIf(String.IsNullOrWhiteSpace(itemRequest.BuscarFechaFin), DBNull.Value, itemRequest.BuscarFechaFin)

            Dim reader = cmd.ExecuteReader()

            If reader.HasRows Then

                While (reader.Read())

                    result.ListaProduccionMetros.Add(New ImpresionIndicadoresMetrosEL() With {
                        .IdRecurso = IIf(reader("Recurso").ToString() = DBNull.Value.ToString(), Nothing, reader("Recurso")),
                        .Año = IIf(reader("Año").ToString() = DBNull.Value.ToString(), Nothing, reader("Año")),
                        .Mes = IIf(reader("Mes").ToString() = DBNull.Value.ToString(), String.Empty, reader("Mes")),
                        .ProduccionMetrosMiles = IIf(reader("ProduccionMetroMiles").ToString() = DBNull.Value.ToString(), String.Empty, reader("ProduccionMetroMiles")),
                        .MetrosObjetivos = IIf(reader("MetrosObjetivos").ToString() = DBNull.Value.ToString(), 0, reader("MetrosObjetivos")),
                        .MetrosCumplidos = IIf(reader("MetrosCumplimiento").ToString() = DBNull.Value.ToString(), 0, reader("MetrosCumplimiento"))
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

    Public Function ListaIndicadoresMetrosTotales(ByVal itemRequest As ImpresionIndicadoresMetrosRequest) As ImpresionIndicadoresMetrosResponse

        Dim result As ImpresionIndicadoresMetrosResponse = New ImpresionIndicadoresMetrosResponse()
        result.ListaProduccionMetros = New List(Of ImpresionIndicadoresMetrosEL)()

        Dim cn As SqlConnection = New SqlConnection()
        Dim conexion As DataBaseConnection = New DataBaseConnection()

        Try

            cn = conexion.GetSql()
            cn.Open()

            Dim cmd As SqlCommand = cn.CreateCommand()
            cmd.CommandTimeout = 120
            cmd.CommandType = System.Data.CommandType.StoredProcedure
            cmd.CommandText = "RES136_IndicadoresImpresionMetros"
            cmd.Parameters.Clear()
            cmd.Parameters.Add(New SqlParameter("@TipoRecurso", SqlDbType.VarChar, 15)).Value = IIf(String.IsNullOrWhiteSpace(itemRequest.TipoRecurso), DBNull.Value, itemRequest.TipoRecurso)
            cmd.Parameters.Add(New SqlParameter("@FechaInicio", SqlDbType.DateTime)).Value = IIf(String.IsNullOrWhiteSpace(itemRequest.BuscarFechaInicio), DBNull.Value, itemRequest.BuscarFechaInicio)
            cmd.Parameters.Add(New SqlParameter("@FechaFin", SqlDbType.DateTime)).Value = IIf(String.IsNullOrWhiteSpace(itemRequest.BuscarFechaFin), DBNull.Value, itemRequest.BuscarFechaFin)

            Dim reader = cmd.ExecuteReader()

            If reader.HasRows Then

                While (reader.Read())

                    result.ListaProduccionMetros.Add(New ImpresionIndicadoresMetrosEL() With {
                        .Año = IIf(reader("Año").ToString() = DBNull.Value.ToString(), Nothing, reader("Año")),
                        .Mes = IIf(reader("Mes").ToString() = DBNull.Value.ToString(), String.Empty, reader("Mes")),
                        .ProduccionMetrosMiles = IIf(reader("ProduccionMetroMiles").ToString() = DBNull.Value.ToString(), String.Empty, reader("ProduccionMetroMiles")),
                        .MetrosObjetivos = IIf(reader("MetrosObjetivos").ToString() = DBNull.Value.ToString(), 0, reader("MetrosObjetivos")),
                        .MetrosCumplidos = IIf(reader("MetrosCumplimiento").ToString() = DBNull.Value.ToString(), 0, reader("MetrosCumplimiento"))
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
