Imports System.ServiceModel

<MessageContract(IsWrapped:=False)>
Public Class DiseñoIndicadoresPreprensasResponse

    Inherits BaseResponse

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    <MessageBodyMember([Namespace]:="", Order:=1)>
    Public Property ListaIndicadorPreprensasDia As List(Of DiseñoIndicadoresPreprensasEL)

    <MessageBodyMember([Namespace]:="", Order:=2)>
    Public Property ListaIndicadorPreprensasDiaCliente As List(Of DiseñoIndicadoresPreprensasEL)

    <MessageBodyMember([Namespace]:="", Order:=3)>
    Public Property ListaIndicadorPreprensasDiaDetalle As List(Of DiseñoIndicadoresPreprensasEL)

    <MessageBodyMember([Namespace]:="", Order:=4)>
    Public Property ListaIndicadorPreprensasSemana As List(Of DiseñoIndicadoresPreprensasEL)

    <MessageBodyMember([Namespace]:="", Order:=5)>
    Public Property ListaIndicadorPreprensasCompletadasSemana As List(Of DiseñoIndicadoresPreprensasEL)

    <MessageBodyMember([Namespace]:="", Order:=6)>
    Public Property ListaIndicadorPreprensasDiaPruebaColor As List(Of DiseñoIndicadoresPreprensasEL)
End Class
