Imports System.ServiceModel

<MessageContract(IsWrapped:=False)>
Public Class ImpresionIndicadoresSetUpResponse
    Inherits BaseResponse

    <MessageBodyMember([Namespace]:="", Order:=1)>
    Public Property ListaIndicadoresSetUp As List(Of ImpresionIndicadoresSetUpEL)

    <MessageBodyMember([Namespace]:="", Order:=2)>
    Public Property ListaIndicadoresSetUpConHeptacromia As List(Of ImpresionIndicadoresSetUpEL)

    <MessageBodyMember([Namespace]:="", Order:=3)>
    Public Property ListaIndicadoresSetUpSinHeptacromia As List(Of ImpresionIndicadoresSetUpEL)

End Class
