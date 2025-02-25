Imports System.ServiceModel

<MessageContract(IsWrapped:=False)>
Public Class ImpresionIndicadoresSetUpRequest
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

    Private pNumeroCambios As Double
    <MessageBodyMember([Namespace]:="", Order:=4)>
    Public Property NumeroCambios() As Double
        Get
            Return pNumeroCambios
        End Get
        Set(ByVal value As Double)
            pNumeroCambios = value
        End Set
    End Property

    Private pSetUpPromedio As Double
    <MessageBodyMember([Namespace]:="", Order:=5)>
    Public Property SetUpPromedio() As Double
        Get
            Return pSetUpPromedio
        End Get
        Set(ByVal value As Double)
            pSetUpPromedio = value
        End Set
    End Property

    Private pSetUpObjetivo As Double
    <MessageBodyMember([Namespace]:="", Order:=6)>
    Public Property SetUpObjetivo() As Double
        Get
            Return pSetUpObjetivo
        End Get
        Set(ByVal value As Double)
            pSetUpObjetivo = value
        End Set
    End Property


    Private pHorasAcumuladas As Double
    <MessageBodyMember([Namespace]:="", Order:=7)>
    Public Property HorasAcumuladas() As Double
        Get
            Return pHorasAcumuladas
        End Get
        Set(ByVal value As Double)
            pHorasAcumuladas = value
        End Set
    End Property

    Private pSetUpPromedioHeptacromia As Double
    <MessageBodyMember([Namespace]:="", Order:=8)>
    Public Property SetUpPromedioHeptacromia() As Double
        Get
            Return pSetUpPromedioHeptacromia
        End Get
        Set(ByVal value As Double)
            pSetUpPromedioHeptacromia = value
        End Set
    End Property

    Private pSetUpObjetivoHeptacromia As Double
    <MessageBodyMember([Namespace]:="", Order:=9)>
    Public Property SetUpObjetivoHeptacromia() As Double
        Get
            Return pSetUpObjetivoHeptacromia
        End Get
        Set(ByVal value As Double)
            pSetUpObjetivoHeptacromia = value
        End Set
    End Property

    Private pSetUpPromedioSinHeptacromia As Double
    <MessageBodyMember([Namespace]:="", Order:=10)>
    Public Property SetUpPromedioSinHeptacromia() As Double
        Get
            Return pSetUpPromedioSinHeptacromia
        End Get
        Set(ByVal value As Double)
            pSetUpPromedioSinHeptacromia = value
        End Set
    End Property

    Private pSetUpObjetivoSinHeptacromia As Double
    <MessageBodyMember([Namespace]:="", Order:=11)>
    Public Property SetUpObjetivoSinHeptacromia() As Double
        Get
            Return pSetUpObjetivoSinHeptacromia
        End Get
        Set(ByVal value As Double)
            pSetUpObjetivoSinHeptacromia = value
        End Set
    End Property

    Private pTipoRecurso As String
    <MessageBodyMember([Namespace]:="", Order:=12)>
    Public Property TipoRecurso() As String
        Get
            Return pTipoRecurso
        End Get
        Set(ByVal value As String)
            pTipoRecurso = value
        End Set
    End Property

    Private pDescripcionFecha As String
    <MessageBodyMember([Namespace]:="", Order:=13)>
    Public Property DescripcionFecha() As String
        Get
            Return pDescripcionFecha
        End Get
        Set(ByVal value As String)
            pDescripcionFecha = value
        End Set
    End Property

    Private pBuscarFechaInicio As DateTime
    <MessageBodyMember([Namespace]:="", Order:=14)>
    Public Property BuscarFechaInicio() As DateTime
        Get
            Return pBuscarFechaInicio
        End Get
        Set(ByVal value As DateTime)
            pBuscarFechaInicio = value
        End Set
    End Property

    Private pBuscarFechaFin As DateTime
    <MessageBodyMember([Namespace]:="", Order:=15)>
    Public Property BuscarFechaFin() As DateTime
        Get
            Return pBuscarFechaFin
        End Get
        Set(ByVal value As DateTime)
            pBuscarFechaFin = value
        End Set
    End Property

End Class
