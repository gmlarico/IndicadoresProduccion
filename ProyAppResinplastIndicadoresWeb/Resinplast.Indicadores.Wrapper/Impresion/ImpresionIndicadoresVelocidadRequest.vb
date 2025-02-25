Imports System.ServiceModel

<MessageContract(IsWrapped:=False)>
Public Class ImpresionIndicadoresVelocidadRequest
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

    Private pSumaMetros As Double
    <MessageBodyMember([Namespace]:="", Order:=4)>
    Public Property SumaMetros() As Double
        Get
            Return pSumaMetros
        End Get
        Set(ByVal value As Double)
            pSumaMetros = value
        End Set
    End Property

    Private pSumaHoras As Double
    <MessageBodyMember([Namespace]:="", Order:=5)>
    Public Property SumaHoras() As Double
        Get
            Return pSumaHoras
        End Get
        Set(ByVal value As Double)
            pSumaHoras = value
        End Set
    End Property

    Private pVelocidadTotal As Double
    <MessageBodyMember([Namespace]:="", Order:=6)>
    Public Property VelocidadTotal() As Double
        Get
            Return pVelocidadTotal
        End Get
        Set(ByVal value As Double)
            pVelocidadTotal = value
        End Set
    End Property

    Private pVelocidadEfectiva As Double
    <MessageBodyMember([Namespace]:="", Order:=7)>
    Public Property VelocidadEfectiva() As Double
        Get
            Return pVelocidadEfectiva
        End Get
        Set(ByVal value As Double)
            pVelocidadEfectiva = value
        End Set
    End Property


    Private pVelocidadObjetivo As Double
    <MessageBodyMember([Namespace]:="", Order:=8)>
    Public Property VelocidadObjetivo() As Double
        Get
            Return pVelocidadObjetivo
        End Get
        Set(ByVal value As Double)
            pVelocidadObjetivo = value
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
