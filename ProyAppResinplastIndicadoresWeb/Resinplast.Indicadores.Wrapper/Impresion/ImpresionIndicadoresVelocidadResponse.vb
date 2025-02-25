Imports System.ServiceModel

<MessageContract(IsWrapped:=False)>
Public Class ImpresionIndicadoresVelocidadResponse
    Inherits BaseResponse

    <MessageBodyMember([Namespace]:="", Order:=1)>
    Public Property ListaIndicadoresVelocidad As List(Of ImpresionIndicadoresVelocidadEL)
End Class
