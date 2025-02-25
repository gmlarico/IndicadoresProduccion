Imports System.ServiceModel
Imports Resinplast.Indicadores.Wrapper
<ServiceContract([Namespace]:="urn:resinplast:Indicadores:ImpresionIndicadores")>
Public Interface IImpresionIndicadores

    ''' <summary>
    ''' Lista Indicadores SetUp Individual
    ''' </summary>
    ''' <param name="itemRequest"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <OperationContract(Action:="urn:resinplast:Indicadores:ImpresionIndicadores:ListaIndicadoresSetUpIndividual", ReplyAction:="")>
    <XmlSerializerFormatAttribute(SupportFaults:=True)>
    Function ListaIndicadoresSetUpIndividual(ByVal itemRequest As ImpresionIndicadoresSetUpRequest) As ImpresionIndicadoresSetUpResponse


    ''' <summary>
    ''' Lista Indicadores SetUp Total
    ''' </summary>
    ''' <param name="itemRequest"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <OperationContract(Action:="urn:resinplast:Indicadores:ImpresionIndicadores:ListaIndicadoresSetUpTotal", ReplyAction:="")>
    <XmlSerializerFormatAttribute(SupportFaults:=True)>
    Function ListaIndicadoresSetUpTotal(ByVal itemRequest As ImpresionIndicadoresSetUpRequest) As ImpresionIndicadoresSetUpResponse


    ''' <summary>
    ''' Lista Indicadores SetUp Con Heptacromia
    ''' </summary>
    ''' <param name="itemRequest"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <OperationContract(Action:="urn:resinplast:Indicadores:ImpresionIndicadores:ListaIndicadoresSetUpConHeptacromia", ReplyAction:="")>
    <XmlSerializerFormatAttribute(SupportFaults:=True)>
    Function ListaIndicadoresSetUpConHeptacromia(ByVal itemRequest As ImpresionIndicadoresSetUpRequest) As ImpresionIndicadoresSetUpResponse

    ''' <summary>
    ''' Lista Indicadores SetUp Sin Heptacromia Individual
    ''' </summary>
    ''' <param name="itemRequest"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <OperationContract(Action:="urn:resinplast:Indicadores:ImpresionIndicadores:ListaIndicadoresSetUpSinHeptacromiaIndividual", ReplyAction:="")>
    <XmlSerializerFormatAttribute(SupportFaults:=True)>
    Function ListaIndicadoresSetUpSinHeptacromiaIndividual(ByVal itemRequest As ImpresionIndicadoresSetUpRequest) As ImpresionIndicadoresSetUpResponse

    ''' <summary>
    ''' Lista Indicadores SetUp Sin HeptacromiaTotal
    ''' </summary>
    ''' <param name="itemRequest"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <OperationContract(Action:="urn:resinplast:Indicadores:ImpresionIndicadores:ListaIndicadoresSetUpSinHeptacromiaTotal", ReplyAction:="")>
    <XmlSerializerFormatAttribute(SupportFaults:=True)>
    Function ListaIndicadoresSetUpSinHeptacromiaTotal(ByVal itemRequest As ImpresionIndicadoresSetUpRequest) As ImpresionIndicadoresSetUpResponse

    ''' <summary>
    ''' Lista Indicadores Metros Individuales
    ''' </summary>
    ''' <param name="itemRequest"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <OperationContract(Action:="urn:resinplast:Indicadores:ImpresionIndicadores:ListaIndicadoresMetrosIndividuales", ReplyAction:="")>
    <XmlSerializerFormatAttribute(SupportFaults:=True)>
    Function ListaIndicadoresMetrosIndividuales(ByVal itemRequest As ImpresionIndicadoresMetrosRequest) As ImpresionIndicadoresMetrosResponse


    ''' <summary>
    ''' Lista Indicadores Metros Totales
    ''' </summary>
    ''' <param name="itemRequest"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <OperationContract(Action:="urn:resinplast:Indicadores:ImpresionIndicadores:ListaIndicadoresMetrosTotales", ReplyAction:="")>
    <XmlSerializerFormatAttribute(SupportFaults:=True)>
    Function ListaIndicadoresMetrosTotales(ByVal itemRequest As ImpresionIndicadoresMetrosRequest) As ImpresionIndicadoresMetrosResponse

    ''' <summary>
    '''Lista Indicadores Scrap Individuales
    ''' </summary>
    ''' <param name="itemRequest"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <OperationContract(Action:="urn:resinplast:Indicadores:ImpresionIndicadores:ListaIndicadoresScrapIndividuales", ReplyAction:="")>
    <XmlSerializerFormatAttribute(SupportFaults:=True)>
    Function ListaIndicadoresScrapIndividuales(ByVal itemRequest As ImpresionIndicadoresScrapRequest) As ImpresionIndicadoresScrapResponse


    ''' <summary>
    '''Lista Indicadores Scrap Totales
    ''' </summary>
    ''' <param name="itemRequest"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <OperationContract(Action:="urn:resinplast:Indicadores:ImpresionIndicadores:ListaIndicadoresScrapTotales", ReplyAction:="")>
    <XmlSerializerFormatAttribute(SupportFaults:=True)>
    Function ListaIndicadoresScrapTotales(ByVal itemRequest As ImpresionIndicadoresScrapRequest) As ImpresionIndicadoresScrapResponse


    ''' <summary>
    ''' Lista Indicadores Velocidad Individuales
    ''' </summary>
    ''' <param name="itemRequest"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <OperationContract(Action:="urn:resinplast:Indicadores:ImpresionIndicadores:ListaIndicadoresVelocidadIndividuales", ReplyAction:="")>
    <XmlSerializerFormatAttribute(SupportFaults:=True)>
    Function ListaIndicadoresVelocidadIndividuales(ByVal itemRequest As ImpresionIndicadoresVelocidadRequest) As ImpresionIndicadoresVelocidadResponse


    ''' <summary>
    ''' Lista Indicadores Velocidad Totales
    ''' </summary>
    ''' <param name="itemRequest"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <OperationContract(Action:="urn:resinplast:Indicadores:ImpresionIndicadores:ListaIndicadoresVelocidadTotales", ReplyAction:="")>
    <XmlSerializerFormatAttribute(SupportFaults:=True)>
    Function ListaIndicadoresVelocidadTotales(ByVal itemRequest As ImpresionIndicadoresVelocidadRequest) As ImpresionIndicadoresVelocidadResponse

End Interface
