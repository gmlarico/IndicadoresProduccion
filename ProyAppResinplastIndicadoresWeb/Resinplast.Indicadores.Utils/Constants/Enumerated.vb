Public Class Enumerated
    Public Structure ConfigurationInitial

        ''' <summary>
        ''' Formato de Fecha
        ''' </summary>
        ''' <remarks></remarks>
        Public Const FormatDate As String = "dd/MM/yyyy"

        ''' <summary>
        ''' Formato de Fecha
        ''' </summary>
        ''' <remarks></remarks>
        Public Const FormatDateFilter As String = "DD/MM/YYYY HH:mm"

        ''' <summary>
        ''' Formato de Fecha y Hora
        ''' </summary>
        ''' <remarks></remarks>
        Public Const FormatDateTime As String = "dd/MM/yyyy HH:mm:ss"

        ''' <summary>
        ''' Formato de Decimal
        ''' </summary>
        ''' <remarks></remarks>
        Public Const FormatoDecimal As String = "{0:###,###,##0.00}"

        ''' <summary>
        ''' Separador Decimal
        ''' </summary>
        ''' <remarks></remarks>
        Public Const NumberDecimalSeparator As String = "."

        ''' <summary>
        ''' Separador de Miles
        ''' </summary>
        ''' <remarks></remarks>
        Public Const NumberGroupSeparator As String = ","

        ''' <summary>
        ''' Número de Filas por Pagina
        ''' </summary>
        ''' <remarks></remarks>
        Public Const RowsPerPage As String = "10"

        ''' <summary>
        ''' Formato de Fecha Grid
        ''' </summary>
        ''' <remarks></remarks>
        Public Const FormatDateGrid As String = "DD/MM/YYYY"

        ''' <summary>
        ''' Formato de Fecha Completo Grid
        ''' </summary>
        ''' <remarks></remarks>
        Public Const FormatDateTimeGrid As String = "DD/MM/YYYY HH:mm:ss"

        ''' <summary>
        ''' Formato de Hora Grid
        ''' </summary>
        ''' <remarks></remarks>
        Public Const FormatHourGrid As String = "HH:mm:ss"
    End Structure

    Public Structure ResponseCode

        ''' <summary>
        ''' Codigo Correcto
        ''' </summary>
        ''' <remarks></remarks>
        Public Const CodigoCorrecto As Integer = 0

        ''' <summary>
        ''' Codigo de error controlado
        ''' </summary>
        ''' <remarks></remarks>
        Public Const CodigoErrorControlado As Integer = 1

        ''' <summary>
        ''' Codigo de error de base de datos
        ''' </summary>
        ''' <remarks></remarks>
        Public Const CodigoErrorDataBase As Integer = 2

        ''' <summary>
        ''' Codigo Error Aplicacion
        ''' </summary>
        ''' <remarks></remarks>
        Public Const CodigoErrorAplicacion As Integer = 3
    End Structure

    Public Structure CodigoEventoDocumento

        ''' <summary>
        ''' Ingresar
        ''' </summary>
        ''' <remarks></remarks>
        Public Const UsuarioAdministrado As String = "USERADMIN"

        ''' <summary>
        ''' Ingresar
        ''' </summary>
        ''' <remarks></remarks>
        Public Const Ingresar As String = "I"

        ''' <summary>
        ''' Visualizar
        ''' </summary>
        ''' <remarks></remarks>
        Public Const Visualizar As String = "V"

        ''' <summary>
        ''' Duplicar
        ''' </summary>
        ''' <remarks></remarks>
        Public Const Duplicar As String = "D"

        ''' <summary>
        ''' Actualizar
        ''' </summary>
        ''' <remarks></remarks>
        Public Const Actualizar As String = "A"

        ''' <summary>
        ''' Eliminar
        ''' </summary>
        ''' <remarks></remarks>
        Public Const Eliminar As String = "E"

        ''' <summary>
        ''' Anular
        ''' </summary>
        ''' <remarks></remarks>
        Public Const Anular As String = "N"

        ''' <summary>
        ''' Buscar
        ''' </summary>
        ''' <remarks></remarks>
        Public Const Buscar As String = "B"

    End Structure

    Public Structure TextoValidacionMessageBox

        ''' <summary>
        ''' Validar Descripcion
        ''' </summary>
        ''' <remarks></remarks>
        Public Const ValidarDescripcion = "Debe insertar la descripción."
    End Structure

    ''' <summary>
    ''' Texto Titulo Mensajes MessageBox
    ''' </summary>
    ''' <remarks></remarks>
    Public Structure TituloMessageBox

        ''' <summary>
        ''' ERROR
        ''' </summary>
        ''' <remarks></remarks>
        Public Const TituloError = "ERROR"

        ''' <summary>
        ''' MENSAJE
        ''' </summary>
        ''' <remarks></remarks>
        Public Const TituloMensaje = "MENSAJE"

        ''' <summary>
        ''' ERROR
        ''' </summary>
        ''' <remarks></remarks>
        Public Const TituloAviso = "Aviso"

    End Structure

End Class
