Imports Resinplast.Indicadores.Wrapper

Public Module EnumeratedGlobales

    ''' <summary>
    ''' Usuario registrado
    ''' </summary>
    ''' <remarks></remarks>
    Public UsuarioConectado As String

    ''' <summary>
    ''' URL de servidor
    ''' </summary>
    ''' <remarks></remarks>
    Public EntornoTrabajo As String

    ''' <summary>
    ''' Nombre de base de datos
    ''' </summary>
    ''' <remarks></remarks>
    Public NombreBaseDatos As String

    ''' <summary>
    ''' Lista Detalle Aperturas
    ''' </summary>

    Public ListaIndicadoresAperturaDiaDetalle As List(Of DiseñoIndicadoresAperturaEL)


    ''' <summary>
    ''' Lista Detalle Preprensa
    ''' </summary>

    Public ListaIndicadoresPreprensaDiaDetalle As List(Of DiseñoIndicadoresPreprensasEL)

    ''' <summary>
    ''' Lista Filtrada Apertura
    ''' </summary>
    Public ListFiltradaApertura As List(Of DiseñoIndicadoresAperturaEL)


    ''' <summary>
    ''' Lista Filtrada Preprensa
    ''' </summary>
    Public ListFiltradaPreprensa As List(Of DiseñoIndicadoresPreprensasEL)

End Module
