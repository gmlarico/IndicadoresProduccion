Imports System.ServiceModel

<MessageContract(IsWrapped:=False)>
Public Class ImpresionIndicadoresScrapResponse
    Inherits BaseResponse

    <MessageBodyMember([Namespace]:="", Order:=1)>
    Public Property ListaProduccionScrap As List(Of ImpresionIndicadoresScrapEL)
End Class
