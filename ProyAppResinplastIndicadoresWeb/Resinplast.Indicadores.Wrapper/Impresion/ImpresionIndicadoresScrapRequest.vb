Imports System.ServiceModel

<MessageContract(IsWrapped:=False)>
Public Class ImpresionIndicadoresScrapRequest
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

    Private pSumaKilosScrap As Double
    <MessageBodyMember([Namespace]:="", Order:=4)>
    Public Property SumaKilosScrap() As Double
        Get
            Return pSumaKilosScrap
        End Get
        Set(ByVal value As Double)
            pSumaKilosScrap = value
        End Set
    End Property

    Private pSumaKilosProduccion As Double
    <MessageBodyMember([Namespace]:="", Order:=5)>
    Public Property SumaKilosProduccion() As Double
        Get
            Return pSumaKilosProduccion
        End Get
        Set(ByVal value As Double)
            pSumaKilosProduccion = value
        End Set
    End Property

    Private pSumaKilosRegulacion As Double
    <MessageBodyMember([Namespace]:="", Order:=6)>
    Public Property SumaKilosRegulacion() As Double
        Get
            Return pSumaKilosRegulacion
        End Get
        Set(ByVal value As Double)
            pSumaKilosRegulacion = value
        End Set
    End Property

    Private pMermaObjetivo As Double
    <MessageBodyMember([Namespace]:="", Order:=7)>
    Public Property MermaObjetivo() As Double
        Get
            Return pMermaObjetivo
        End Get
        Set(ByVal value As Double)
            pMermaObjetivo = value
        End Set
    End Property

    Private pMermaResultante As Double
    <MessageBodyMember([Namespace]:="", Order:=8)>
    Public Property MermaResultante() As Double
        Get
            Return pMermaResultante
        End Get
        Set(ByVal value As Double)
            pMermaResultante = value
        End Set
    End Property

    Private pTipoRecurso As String
    <MessageBodyMember([Namespace]:="", Order:=9)>
    Public Property TipoRecurso() As String
        Get
            Return pTipoRecurso
        End Get
        Set(ByVal value As String)
            pTipoRecurso = value
        End Set
    End Property

    Private pDescripcionFecha As String
    <MessageBodyMember([Namespace]:="", Order:=10)>
    Public Property DescripcionFecha() As String
        Get
            Return pDescripcionFecha
        End Get
        Set(ByVal value As String)
            pDescripcionFecha = value
        End Set
    End Property

    Private pBuscarFechaInicio As DateTime
    <MessageBodyMember([Namespace]:="", Order:=11)>
    Public Property BuscarFechaInicio() As DateTime
        Get
            Return pBuscarFechaInicio
        End Get
        Set(ByVal value As DateTime)
            pBuscarFechaInicio = value
        End Set
    End Property

    Private pBuscarFechaFin As DateTime
    <MessageBodyMember([Namespace]:="", Order:=12)>
    Public Property BuscarFechaFin() As DateTime
        Get
            Return pBuscarFechaFin
        End Get
        Set(ByVal value As DateTime)
            pBuscarFechaFin = value
        End Set
    End Property

End Class
