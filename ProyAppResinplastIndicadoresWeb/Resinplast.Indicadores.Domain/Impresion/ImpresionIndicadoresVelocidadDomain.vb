Imports System.Data.SqlClient
Imports Resinplast.Indicadores.Utils
Imports Resinplast.Indicadores.Wrapper
Public Class ImpresionIndicadoresVelocidadDomain


    Public Function ListaIndicadoresVelocidadIndividuales(ByVal itemRequest As ImpresionIndicadoresVelocidadRequest) As ImpresionIndicadoresVelocidadResponse

        Dim result As ImpresionIndicadoresVelocidadResponse = New ImpresionIndicadoresVelocidadResponse()
        result.ListaIndicadoresVelocidad = New List(Of ImpresionIndicadoresVelocidadEL)()

        Dim cn As SqlConnection = New SqlConnection()
        Dim conexion As DataBaseConnection = New DataBaseConnection()

        Try

            cn = conexion.GetSql()
            cn.Open()

            Dim cmd As SqlCommand = cn.CreateCommand()
            cmd.CommandTimeout = 120
            cmd.CommandType = System.Data.CommandType.StoredProcedure
            cmd.CommandText = "RES136_IndicadoresImpresionVelocidad"
            cmd.Parameters.Clear()
            cmd.Parameters.Add(New SqlParameter("@TipoRecurso", SqlDbType.VarChar, 15)).Value = IIf(String.IsNullOrWhiteSpace(itemRequest.TipoRecurso), DBNull.Value, itemRequest.TipoRecurso)
            cmd.Parameters.Add(New SqlParameter("@FechaInicio", SqlDbType.DateTime)).Value = IIf(String.IsNullOrWhiteSpace(itemRequest.BuscarFechaInicio), DBNull.Value, itemRequest.BuscarFechaInicio)
            cmd.Parameters.Add(New SqlParameter("@FechaFin", SqlDbType.DateTime)).Value = IIf(String.IsNullOrWhiteSpace(itemRequest.BuscarFechaFin), DBNull.Value, itemRequest.BuscarFechaFin)

            Dim reader = cmd.ExecuteReader()

            If reader.HasRows Then

                While (reader.Read())

                    result.ListaIndicadoresVelocidad.Add(New ImpresionIndicadoresVelocidadEL() With {
                        .IdRecurso = IIf(reader("Recurso").ToString() = DBNull.Value.ToString(), Nothing, reader("Recurso")),
                        .Año = IIf(reader("Año").ToString() = DBNull.Value.ToString(), Nothing, reader("Año")),
                        .Mes = IIf(reader("Mes").ToString() = DBNull.Value.ToString(), Nothing, reader("Mes")),
                        .SumaMetros = IIf(reader("SumaMetros").ToString() = DBNull.Value.ToString(), 0, reader("SumaMetros")),
                        .SumaHoras = IIf(reader("SumaHoras").ToString() = DBNull.Value.ToString(), 0, reader("SumaHoras")),
                        .VelocidadTotal = IIf(reader("VelocidadTotal").ToString() = DBNull.Value.ToString(), 0, reader("VelocidadTotal")),
                        .VelocidadEfectiva = IIf(reader("VelocidadEfectiva").ToString() = DBNull.Value.ToString(), 0, reader("VelocidadEfectiva")),
                        .VelocidadObjetivo = IIf(reader("VelocidadObjetivo").ToString() = DBNull.Value.ToString(), 0, reader("VelocidadObjetivo"))
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

    Public Function ListaIndicadoresVelocidadTotales(ByVal itemRequest As ImpresionIndicadoresVelocidadRequest) As ImpresionIndicadoresVelocidadResponse

        Dim result As ImpresionIndicadoresVelocidadResponse = New ImpresionIndicadoresVelocidadResponse()
        result.ListaIndicadoresVelocidad = New List(Of ImpresionIndicadoresVelocidadEL)()

        Dim cn As SqlConnection = New SqlConnection()
        Dim conexion As DataBaseConnection = New DataBaseConnection()

        Try

            cn = conexion.GetSql()
            cn.Open()

            Dim cmd As SqlCommand = cn.CreateCommand()
            cmd.CommandTimeout = 120
            cmd.CommandType = System.Data.CommandType.StoredProcedure
            cmd.CommandText = "RES136_IndicadoresImpresionVelocidad"
            cmd.Parameters.Clear()
            cmd.Parameters.Add(New SqlParameter("@TipoRecurso", SqlDbType.VarChar, 15)).Value = IIf(String.IsNullOrWhiteSpace(itemRequest.TipoRecurso), DBNull.Value, itemRequest.TipoRecurso)
            cmd.Parameters.Add(New SqlParameter("@FechaInicio", SqlDbType.DateTime)).Value = IIf(String.IsNullOrWhiteSpace(itemRequest.BuscarFechaInicio), DBNull.Value, itemRequest.BuscarFechaInicio)
            cmd.Parameters.Add(New SqlParameter("@FechaFin", SqlDbType.DateTime)).Value = IIf(String.IsNullOrWhiteSpace(itemRequest.BuscarFechaFin), DBNull.Value, itemRequest.BuscarFechaFin)

            Dim reader = cmd.ExecuteReader()

            If reader.HasRows Then

                While (reader.Read())

                    result.ListaIndicadoresVelocidad.Add(New ImpresionIndicadoresVelocidadEL() With {
                        .Año = IIf(reader("Año").ToString() = DBNull.Value.ToString(), Nothing, reader("Año")),
                        .Mes = IIf(reader("Mes").ToString() = DBNull.Value.ToString(), Nothing, reader("Mes")),
                        .SumaMetros = IIf(reader("SumaMetros").ToString() = DBNull.Value.ToString(), 0, reader("SumaMetros")),
                        .SumaHoras = IIf(reader("SumaHoras").ToString() = DBNull.Value.ToString(), 0, reader("SumaHoras")),
                        .VelocidadTotal = IIf(reader("VelocidadTotal").ToString() = DBNull.Value.ToString(), 0, reader("VelocidadTotal")),
                        .VelocidadEfectiva = IIf(reader("VelocidadEfectiva").ToString() = DBNull.Value.ToString(), 0, reader("VelocidadEfectiva")),
                        .VelocidadObjetivo = IIf(reader("VelocidadObjetivo").ToString() = DBNull.Value.ToString(), 0, reader("VelocidadObjetivo"))
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
