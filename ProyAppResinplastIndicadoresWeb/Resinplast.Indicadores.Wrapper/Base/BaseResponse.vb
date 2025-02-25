Imports System.ServiceModel
<MessageContract(IsWrapped:=False)>
Public Class BaseResponse
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <MessageBodyMember([Namespace]:="")>
    Public Property CodigoError As Integer

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <MessageBodyMember([Namespace]:="")>
    Public Property DescripcionError As String

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <MessageBodyMember([Namespace]:="")>
    Public Property ListaError As List(Of BaseErrorEL)
End Class
