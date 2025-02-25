Imports System.ServiceModel

<MessageContract(IsWrapped:=False)>
Public Class DiseñoIndicadoresAperturaResponse

    Inherits BaseResponse

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    <MessageBodyMember([Namespace]:="", Order:=1)>
    Public Property ListaIndicadorAperturasDia As List(Of DiseñoIndicadoresAperturaEL)

    <MessageBodyMember([Namespace]:="", Order:=2)>
    Public Property ListaIndicadorAperturasDiaCliente As List(Of DiseñoIndicadoresAperturaEL)

    <MessageBodyMember([Namespace]:="", Order:=3)>
    Public Property ListaIndicadorAperturasDiaDetalle As List(Of DiseñoIndicadoresAperturaEL)

    <MessageBodyMember([Namespace]:="", Order:=4)>
    Public Property ListaIndicadorAperturasSemana As List(Of DiseñoIndicadoresAperturaEL)

    <MessageBodyMember([Namespace]:="", Order:=5)>
    Public Property ListaIndicadorAperturasCompletadasSemana As List(Of DiseñoIndicadoresAperturaEL)

    <MessageBodyMember([Namespace]:="", Order:=6)>
    Public Property ListarAperturasCompletadasPorUsuario As List(Of DiseñoIndicadoresAperturaEL)

End Class
