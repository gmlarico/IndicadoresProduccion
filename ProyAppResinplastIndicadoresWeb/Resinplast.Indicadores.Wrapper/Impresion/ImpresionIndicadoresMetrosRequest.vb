Imports System.ServiceModel

<MessageContract(IsWrapped:=False)>
Public Class ImpresionIndicadoresMetrosRequest
    Inherits BaseRequest

    Private pIdRecurso As String
    <MessageBodyMember([Namespace]:="", Order:=1)>
    Public Property IdRecurso() As String
        Get
            Return pIdRecurso
        End Get
        Set(ByVal value As String)
            pIdRecurso = value
        End Set
    End Property

    Private pAño As String
    <MessageBodyMember([Namespace]:="", Order:=2)>
    Public Property Año() As String
        Get
            Return pAño
        End Get
        Set(ByVal value As String)
            pAño = value
        End Set
    End Property

    Private pMes As String
    <MessageBodyMember([Namespace]:="", Order:=3)>
    Public Property Mes() As String
        Get
            Return pMes
        End Get
        Set(ByVal value As String)
            pMes = value
        End Set
    End Property

    Private pProduccionMetrosMiles As Double
    <MessageBodyMember([Namespace]:="", Order:=4)>
    Public Property ProduccionMetrosMiles() As Double
        Get
            Return pProduccionMetrosMiles
        End Get
        Set(ByVal value As Double)
            pProduccionMetrosMiles = value
        End Set
    End Property

    Private pMetrosObjetivos As Double
    <MessageBodyMember([Namespace]:="", Order:=5)>
    Public Property MetrosObjetivos() As Double
        Get
            Return pMetrosObjetivos
        End Get
        Set(ByVal value As Double)
            pMetrosObjetivos = value
        End Set
    End Property

    Private pMetrosCumplidos As Double
    <MessageBodyMember([Namespace]:="", Order:=6)>
    Public Property MetrosCumplidos() As Double
        Get
            Return pMetrosCumplidos
        End Get
        Set(ByVal value As Double)
            pMetrosCumplidos = value
        End Set
    End Property

    Private pTipoRecurso As String
    <MessageBodyMember([Namespace]:="", Order:=7)>
    Public Property TipoRecurso() As String
        Get
            Return pTipoRecurso
        End Get
        Set(ByVal value As String)
            pTipoRecurso = value
        End Set
    End Property

    Private pDescripcionFecha As String
    <MessageBodyMember([Namespace]:="", Order:=8)>
    Public Property DescripcionFecha() As String
        Get
            Return pDescripcionFecha
        End Get
        Set(ByVal value As String)
            pDescripcionFecha = value
        End Set
    End Property

    Private pBuscarFechaInicio As DateTime
    <MessageBodyMember([Namespace]:="", Order:=9)>
    Public Property BuscarFechaInicio() As DateTime
        Get
            Return pBuscarFechaInicio
        End Get
        Set(ByVal value As DateTime)
            pBuscarFechaInicio = value
        End Set
    End Property

    Private pBuscarFechaFin As DateTime
    <MessageBodyMember([Namespace]:="", Order:=10)>
    Public Property BuscarFechaFin() As DateTime
        Get
            Return pBuscarFechaFin
        End Get
        Set(ByVal value As DateTime)
            pBuscarFechaFin = value
        End Set
    End Property

End Class
