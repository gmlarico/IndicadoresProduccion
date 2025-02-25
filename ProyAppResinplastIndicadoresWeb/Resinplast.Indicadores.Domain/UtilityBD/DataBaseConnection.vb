Imports System.Data.SqlClient
Imports Resinplast.Indicadores.Utils
Public Class DataBaseConnection

    Private sConexionProduccion As String = "ConexionSQLProduccion"
    Private sConexionDesarrollo As String = "ConexionSQLDesarrollo"
    Private Property cnSQL As SqlConnection


    Public Function GetSql() As SqlConnection

        Dim oConfig As System.Configuration.AppSettingsReader

        Select Case EnumeratedGlobales.EntornoTrabajo

            Case "AppServerDC://SERVER-APP:9401" ' RESINPLAST
                oConfig = New System.Configuration.AppSettingsReader()
                Dim sConexionSlq1 As String = oConfig.GetValue(sConexionProduccion, GetType(System.String)).ToString()
                'TODO 20210801 AMHV CONEXION CAMBIADA a la fuerza
                'sConexionSlq1 = "data source=SERVER-DAT;Initial Catalog=Desarrollo;Persist Security Info=True;User ID=userapp; Password=epicornet; MultipleActiveResultSets = True;"

                If Not String.IsNullOrEmpty(sConexionSlq1) Then
                    If cnSQL Is Nothing Then cnSQL = New SqlConnection(sConexionSlq1)
                End If

            Case "AppServerDC://SERVER-APP:9421" ' RESINPLAST - TEST
                oConfig = New System.Configuration.AppSettingsReader()
                Dim sConexionSlq2 As String = oConfig.GetValue(sConexionDesarrollo, GetType(System.String)).ToString()
                If Not String.IsNullOrEmpty(sConexionSlq2) Then
                    If cnSQL Is Nothing Then cnSQL = New SqlConnection(sConexionSlq2)
                End If

            Case "AppServerDC://SERVER-APP:9431" ' RESINPLAST - TEST
                oConfig = New System.Configuration.AppSettingsReader()
                Dim sConexionSlq2 As String = oConfig.GetValue(sConexionDesarrollo, GetType(System.String)).ToString()
                If Not String.IsNullOrEmpty(sConexionSlq2) Then
                    If cnSQL Is Nothing Then cnSQL = New SqlConnection(sConexionSlq2)
                End If
        End Select

        Return cnSQL
    End Function
End Class
