Imports System.ServiceModel

<MessageContract(IsWrapped:=False)>
Public Class BaseRequest
    ''' <summary>
    ''' Estado de registro
    ''' </summary>
    ''' <remarks></remarks>
    Private nFlagEstado As Integer
    <MessageBodyMember([Namespace]:="")>
    Public Property FlagEstado() As Integer
        Get
            Return nFlagEstado
        End Get
        Set(ByVal value As Integer)
            nFlagEstado = value
        End Set
    End Property

    ''' <summary>
    ''' Usuarion creacion
    ''' </summary>
    ''' <remarks></remarks>
    Private sUsuarioCreacion As String
    <MessageBodyMember([Namespace]:="")>
    Public Property UsuarioCreacion() As String
        Get
            Return sUsuarioCreacion
        End Get
        Set(ByVal value As String)
            sUsuarioCreacion = value
        End Set
    End Property

    ''' <summary>
    ''' Fecha Creacion
    ''' </summary>
    ''' <remarks></remarks>
    Private fFechaCreacion As DateTime
    <MessageBodyMember([Namespace]:="")>
    Public Property FechaCreacion() As DateTime
        Get
            Return fFechaCreacion
        End Get
        Set(ByVal value As DateTime)
            fFechaCreacion = value
        End Set
    End Property

    ''' <summary>
    ''' Usuario Modificacion
    ''' </summary>
    ''' <remarks></remarks>
    Private fUsuarioModificacion As String
    <MessageBodyMember([Namespace]:="")>
    Public Property UsuarioModificacion() As String
        Get
            Return fUsuarioModificacion
        End Get
        Set(ByVal value As String)
            fUsuarioModificacion = value
        End Set
    End Property

    ''' <summary>
    ''' Fecha modificacion
    ''' </summary>
    ''' <remarks></remarks>
    Private fFechaModificacion As DateTime
    <MessageBodyMember([Namespace]:="")>
    Public Property FechaModificacion() As DateTime
        Get
            Return fFechaModificacion
        End Get
        Set(ByVal value As DateTime)
            fFechaModificacion = value
        End Set
    End Property

    ''' <summary>
    ''' Usuario Eliminacion
    ''' </summary>
    ''' <remarks></remarks>
    Private fUsuarioEliminacion As String
    <MessageBodyMember([Namespace]:="")>
    Public Property UsuarioEliminacion() As String
        Get
            Return fUsuarioEliminacion
        End Get
        Set(ByVal value As String)
            fUsuarioEliminacion = value
        End Set
    End Property

    ''' <summary>
    ''' Usuario Eliminacion
    ''' </summary>
    ''' <remarks></remarks>
    Private fFechaEliminacion As DateTime
    <MessageBodyMember([Namespace]:="")>
    Public Property FechaEliminacion() As DateTime
        Get
            Return fFechaEliminacion
        End Get
        Set(ByVal value As DateTime)
            fFechaEliminacion = value
        End Set
    End Property
End Class
