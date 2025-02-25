Imports System.Data.SqlClient
Imports Resinplast.Indicadores.Utils
Imports Resinplast.Indicadores.Wrapper
Public Class ImpresionIndicadoresScrapDomain

    Public Function ListaIndicadoresScrapIndividuales(ByVal itemRequest As ImpresionIndicadoresScrapRequest) As ImpresionIndicadoresScrapResponse

        Dim result As ImpresionIndicadoresScrapResponse = New ImpresionIndicadoresScrapResponse()
        result.ListaProduccionScrap = New List(Of ImpresionIndicadoresScrapEL)()

        Dim cn As SqlConnection = New SqlConnection()
        Dim conexion As DataBaseConnection = New DataBaseConnection()

        Try

            cn = conexion.GetSql()
            cn.Open()

            Dim cmd As SqlCommand = cn.CreateCommand()
            cmd.CommandTimeout = 120
            cmd.CommandType = System.Data.CommandType.StoredProcedure
            cmd.CommandText = "RES136_IndicadoresImpresionScrap"
            cmd.Parameters.Clear()
            cmd.Parameters.Add(New SqlParameter("@TipoRecurso", SqlDbType.VarChar, 15)).Value = IIf(String.IsNullOrWhiteSpace(itemRequest.TipoRecurso), DBNull.Value, itemRequest.TipoRecurso)
            cmd.Parameters.Add(New SqlParameter("@FechaInicio", SqlDbType.DateTime)).Value = IIf(String.IsNullOrWhiteSpace(itemRequest.BuscarFechaInicio), DBNull.Value, itemRequest.BuscarFechaInicio)
            cmd.Parameters.Add(New SqlParameter("@FechaFin", SqlDbType.DateTime)).Value = IIf(String.IsNullOrWhiteSpace(itemRequest.BuscarFechaFin), DBNull.Value, itemRequest.BuscarFechaFin)

            Dim reader = cmd.ExecuteReader()

            If reader.HasRows Then

                While (reader.Read())

                    result.ListaProduccionScrap.Add(New ImpresionIndicadoresScrapEL() With {
                        .IdRecurso = IIf(reader("Recurso").ToString() = DBNull.Value.ToString(), Nothing, reader("Recurso")),
                        .Año = IIf(reader("Año").ToString() = DBNull.Value.ToString(), Nothing, reader("Año")),
                        .Mes = IIf(reader("Mes").ToString() = DBNull.Value.ToString(), Nothing, reader("Mes")),
                        .SumaKilosProduccion = IIf(reader("SumaKilosProduccion").ToString() = DBNull.Value.ToString(), 0, reader("SumaKilosProduccion")),
                        .SumaKilosRegulacion = IIf(reader("SumaKilosRegulacion").ToString() = DBNull.Value.ToString(), 0, reader("SumaKilosRegulacion")),
                        .SumaKilosScrap = IIf(reader("SumaKilosScrap").ToString() = DBNull.Value.ToString(), 0, reader("SumaKilosScrap")),
                        .MermaObjetivo = IIf(reader("MermaObjetivo").ToString() = DBNull.Value.ToString(), 0, reader("MermaObjetivo")),
                        .MermaResultante = IIf(reader("MermaResultante").ToString() = DBNull.Value.ToString(), 0, reader("MermaResultante"))
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


    Public Function ListaIndicadoresScrapTotales(ByVal itemRequest As ImpresionIndicadoresScrapRequest) As ImpresionIndicadoresScrapResponse

        Dim result As ImpresionIndicadoresScrapResponse = New ImpresionIndicadoresScrapResponse()
        result.ListaProduccionScrap = New List(Of ImpresionIndicadoresScrapEL)()

        Dim cn As SqlConnection = New SqlConnection()
        Dim conexion As DataBaseConnection = New DataBaseConnection()

        Try

            cn = conexion.GetSql()
            cn.Open()

            Dim cmd As SqlCommand = cn.CreateCommand()
            cmd.CommandTimeout = 120
            cmd.CommandType = System.Data.CommandType.StoredProcedure
            cmd.CommandText = "RES136_IndicadoresImpresionScrap"
            cmd.Parameters.Clear()
            cmd.Parameters.Add(New SqlParameter("@TipoRecurso", SqlDbType.VarChar, 15)).Value = IIf(String.IsNullOrWhiteSpace(itemRequest.TipoRecurso), DBNull.Value, itemRequest.TipoRecurso)
            cmd.Parameters.Add(New SqlParameter("@FechaInicio", SqlDbType.DateTime)).Value = IIf(String.IsNullOrWhiteSpace(itemRequest.BuscarFechaInicio), DBNull.Value, itemRequest.BuscarFechaInicio)
            cmd.Parameters.Add(New SqlParameter("@FechaFin", SqlDbType.DateTime)).Value = IIf(String.IsNullOrWhiteSpace(itemRequest.BuscarFechaFin), DBNull.Value, itemRequest.BuscarFechaFin)

            Dim reader = cmd.ExecuteReader()

            If reader.HasRows Then

                While (reader.Read())

                    result.ListaProduccionScrap.Add(New ImpresionIndicadoresScrapEL() With {
                        .Año = IIf(reader("Año").ToString() = DBNull.Value.ToString(), Nothing, reader("Año")),
                        .Mes = IIf(reader("Mes").ToString() = DBNull.Value.ToString(), Nothing, reader("Mes")),
                        .SumaKilosProduccion = IIf(reader("SumaKilosProduccion").ToString() = DBNull.Value.ToString(), 0, reader("SumaKilosProduccion")),
                        .SumaKilosRegulacion = IIf(reader("SumaKilosRegulacion").ToString() = DBNull.Value.ToString(), 0, reader("SumaKilosRegulacion")),
                        .SumaKilosScrap = IIf(reader("SumaKilosScrap").ToString() = DBNull.Value.ToString(), 0, reader("SumaKilosScrap")),
                        .MermaObjetivo = IIf(reader("MermaObjetivo").ToString() = DBNull.Value.ToString(), 0, reader("MermaObjetivo")),
                        .MermaResultante = IIf(reader("MermaResultante").ToString() = DBNull.Value.ToString(), 0, reader("MermaResultante"))
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
