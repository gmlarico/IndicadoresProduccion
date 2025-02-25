Imports System.ServiceModel
Imports Resinplast.Indicadores.Wrapper


<ServiceContract([Namespace]:="urn:resinplast:Indicadores:DisenoIndicadores")>
Public Interface IDiseñoIndicadores

    ''' <summary>
    ''' Lista IndicadoresKPI ListaAperturasDias
    ''' </summary>
    ''' <param name="itemRequest"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <OperationContract(Action:="urn:resinplast:Indicadores:DisenoIndicadores:ListarAperturasDia", ReplyAction:="")>
    <XmlSerializerFormatAttribute(SupportFaults:=True)>
    Function ListarAperturasDia(ByVal itemRequest As DiseñoIndicadoresAperturaRequest) As DiseñoIndicadoresAperturaResponse

    ''' <summary>
    ''' Lista IndicadoresKPI ListaAperturasDias
    ''' </summary>
    ''' <param name="itemRequest"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <OperationContract(Action:="urn:resinplast:Indicadores:DisenoIndicadores:ListarAperturasCompletadasSemana", ReplyAction:="")>
    <XmlSerializerFormatAttribute(SupportFaults:=True)>
    Function ListarAperturasCompletadasSemana(ByVal itemRequest As DiseñoIndicadoresAperturaRequest) As DiseñoIndicadoresAperturaResponse


    ''' <summary>
    ''' Lista IndicadoresKPI ListaAperturasDias
    ''' </summary>
    ''' <param name="itemRequest"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <OperationContract(Action:="urn:resinplast:Indicadores:DisenoIndicadores:ListarAperturasSemana", ReplyAction:="")>
    <XmlSerializerFormatAttribute(SupportFaults:=True)>
    Function ListarAperturasSemana(ByVal itemRequest As DiseñoIndicadoresAperturaRequest) As DiseñoIndicadoresAperturaResponse

    ''' <summary>
    ''' Lista IndicadoresKPI ListaAperturasDias
    ''' </summary>
    ''' <param name="itemRequest"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <OperationContract(Action:="urn:resinplast:Indicadores:DisenoIndicadores:ListarAperturasDiaDetalle", ReplyAction:="")>
    <XmlSerializerFormatAttribute(SupportFaults:=True)>
    Function ListarAperturasDiaDetalle(ByVal itemRequest As DiseñoIndicadoresAperturaRequest) As DiseñoIndicadoresAperturaResponse

    ''' <summary>
    ''' Lista IndicadoresKPI ListaAperturasDias
    ''' </summary>
    ''' <param name="itemRequest"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <OperationContract(Action:="urn:resinplast:Indicadores:DisenoIndicadores:ListarAperturasCompletadasPorUsuario", ReplyAction:="")>
    <XmlSerializerFormatAttribute(SupportFaults:=True)>
    Function ListarAperturasCompletadasPorUsuario(ByVal itemRequest As DiseñoIndicadoresAperturaRequest) As DiseñoIndicadoresAperturaResponse

    ''' <summary>
    ''' Lista IndicadoresKPI ListaPreprensasDias
    ''' </summary>
    ''' <param name="itemRequest"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <OperationContract(Action:="urn:resinplast:Indicadores:DisenoIndicadores:ListarPrepensaDia", ReplyAction:="")>
    <XmlSerializerFormatAttribute(SupportFaults:=True)>
    Function ListarPrepensaDia(ByVal itemRequest As DiseñoIndicadoresPreprensasRequest) As DiseñoIndicadoresPreprensasResponse


    ''' <summary>
    ''' Lista IndicadoresKPI ListaPreprensaDiasCliente
    ''' </summary>
    ''' <param name="itemRequest"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <OperationContract(Action:="urn:resinplast:Indicadores:DisenoIndicadores:ListarPreprensaDiaDetalle", ReplyAction:="")>
    <XmlSerializerFormatAttribute(SupportFaults:=True)>
    Function ListarPreprensaDiaDetalle(ByVal itemRequest As DiseñoIndicadoresPreprensasRequest) As DiseñoIndicadoresPreprensasResponse


    ''' <summary>
    ''' Lista IndicadoresKPI ListaPreprensasDias
    ''' </summary>
    ''' <param name="itemRequest"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <OperationContract(Action:="urn:resinplast:Indicadores:DisenoIndicadores:ListarPreprensasSemana", ReplyAction:="")>
    <XmlSerializerFormatAttribute(SupportFaults:=True)>
    Function ListarPreprensasSemana(ByVal itemRequest As DiseñoIndicadoresPreprensasRequest) As DiseñoIndicadoresPreprensasResponse


    ''' <summary>
    ''' Lista IndicadoresKPI ListaPreprensasDias
    ''' </summary>
    ''' <param name="itemRequest"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <OperationContract(Action:="urn:resinplast:Indicadores:DisenoIndicadores:ListarPreprensasCompletadasSemana", ReplyAction:="")>
    <XmlSerializerFormatAttribute(SupportFaults:=True)>
    Function ListarPreprensasCompletadasSemana(ByVal itemRequest As DiseñoIndicadoresPreprensasRequest) As DiseñoIndicadoresPreprensasResponse


    ''' <summary>
    ''' Lista IndicadoresKPI ListaPreprensasDias
    ''' </summary>
    ''' <param name="itemRequest"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <OperationContract(Action:="urn:resinplast:Indicadores:DisenoIndicadores:ListarPrepensaDiaPruebaColor", ReplyAction:="")>
    <XmlSerializerFormatAttribute(SupportFaults:=True)>
    Function ListarPrepensaDiaPruebaColor(ByVal itemRequest As DiseñoIndicadoresPreprensasRequest) As DiseñoIndicadoresPreprensasResponse


End Interface
