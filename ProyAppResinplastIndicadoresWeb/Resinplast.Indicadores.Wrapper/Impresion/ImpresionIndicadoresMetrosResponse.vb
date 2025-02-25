Imports System.ServiceModel

<MessageContract(IsWrapped:=False)>
Public Class ImpresionIndicadoresMetrosResponse
    Inherits BaseResponse

    <MessageBodyMember([Namespace]:="", Order:=1)>
    Public Property ListaProduccionMetros As List(Of ImpresionIndicadoresMetrosEL)
End Class
