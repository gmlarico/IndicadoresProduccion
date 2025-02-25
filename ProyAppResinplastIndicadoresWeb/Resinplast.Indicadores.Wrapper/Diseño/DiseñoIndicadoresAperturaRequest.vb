Imports System.ServiceModel

<MessageContract(IsWrapped:=False)>
Public Class DiseñoIndicadoresAperturaRequest

    Private pIdOrdenTrabajo As String
    <MessageBodyMember([Namespace]:="", Order:=1)>
    Public Property IdOrdenTrabajo() As String
        Get
            Return pIdOrdenTrabajo
        End Get
        Set(ByVal value As String)
            pIdOrdenTrabajo = value
        End Set
    End Property

    Private pNroLegalOrdenTrabajo As String
    <MessageBodyMember([Namespace]:="", Order:=2)>
    Public Property NroLegalOrdenTrabajo() As String
        Get
            Return pNroLegalOrdenTrabajo
        End Get
        Set(ByVal value As String)
            pNroLegalOrdenTrabajo = value
        End Set
    End Property

    Private pNombreCliente As String
    <MessageBodyMember([Namespace]:="", Order:=3)>
    Public Property NombreCliente() As String
        Get
            Return pNombreCliente
        End Get
        Set(ByVal value As String)
            pNombreCliente = value
        End Set
    End Property

    Private pNombreProducto As String
    <MessageBodyMember([Namespace]:="", Order:=4)>
    Public Property NombreProducto() As String
        Get
            Return pNombreProducto
        End Get
        Set(ByVal value As String)
            pNombreProducto = value
        End Set
    End Property

    Private pFechaEnAprobacionCliente As DateTime
    <MessageBodyMember([Namespace]:="", Order:=5)>
    Public Property FechaEnAprobacionCliente() As DateTime
        Get
            Return pFechaEnAprobacionCliente
        End Get
        Set(ByVal value As DateTime)
            pFechaEnAprobacionCliente = value
        End Set
    End Property

    Private pTotalTrabajos As String
    <MessageBodyMember([Namespace]:="", Order:=6)>
    Public Property TotalTrabajos() As String
        Get
            Return pTotalTrabajos
        End Get
        Set(ByVal value As String)
            pTotalTrabajos = value
        End Set
    End Property

    Private pTotalTrabajosAño As String
    <MessageBodyMember([Namespace]:="", Order:=7)>
    Public Property TotalTrabajosAño() As String
        Get
            Return pTotalTrabajosAño
        End Get
        Set(ByVal value As String)
            pTotalTrabajosAño = value
        End Set
    End Property

    Private pTotalTrabajosmes As String
    <MessageBodyMember([Namespace]:="", Order:=8)>
    Public Property TotalTrabajosmes() As String
        Get
            Return pTotalTrabajosmes
        End Get
        Set(ByVal value As String)
            pTotalTrabajosmes = value
        End Set
    End Property


    Private pTotalTrabajosdia As String
    <MessageBodyMember([Namespace]:="", Order:=9)>
    Public Property TotalTrabajosdia() As String
        Get
            Return pTotalTrabajosdia
        End Get
        Set(ByVal value As String)
            pTotalTrabajosdia = value
        End Set
    End Property

    Private pFechaEnAprobacionClientemes As String
    <MessageBodyMember([Namespace]:="", Order:=10)>
    Public Property FechaEnAprobacionClientemes() As String
        Get
            Return pFechaEnAprobacionClientemes
        End Get
        Set(ByVal value As String)
            pFechaEnAprobacionClientemes = value
        End Set
    End Property


    Private pAño As String
    <MessageBodyMember([Namespace]:="", Order:=11)>
    Public Property Año() As String
        Get
            Return pAño
        End Get
        Set(ByVal value As String)
            pAño = value
        End Set
    End Property

    Private pmes As String
    <MessageBodyMember([Namespace]:="", Order:=12)>
    Public Property mes() As String
        Get
            Return pmes
        End Get
        Set(ByVal value As String)
            pmes = value
        End Set
    End Property

    Private pNumeroSemana As String
    <MessageBodyMember([Namespace]:="", Order:=13)>
    Public Property NumeroSemana() As String
        Get
            Return pNumeroSemana
        End Get
        Set(ByVal value As String)
            pNumeroSemana = value
        End Set
    End Property

    Private pFechaIniSemEnAprobacionCliente As DateTime
    <MessageBodyMember([Namespace]:="", Order:=14)>
    Public Property FechaIniSemEnAprobacionCliente() As DateTime
        Get
            Return pFechaIniSemEnAprobacionCliente
        End Get
        Set(ByVal value As DateTime)
            pFechaIniSemEnAprobacionCliente = value
        End Set
    End Property

    Private pFechaFinSemEnAprobacionCliente As DateTime
    <MessageBodyMember([Namespace]:="", Order:=15)>
    Public Property FechaFinSemEnAprobacionCliente() As DateTime
        Get
            Return pFechaFinSemEnAprobacionCliente
        End Get
        Set(ByVal value As DateTime)
            pFechaFinSemEnAprobacionCliente = value
        End Set
    End Property

    Private pPromedioSem As String
    <MessageBodyMember([Namespace]:="", Order:=16)>
    Public Property PromedioSem() As String
        Get
            Return pPromedioSem
        End Get
        Set(ByVal value As String)
            pPromedioSem = value
        End Set
    End Property

    Private pTrabajosSinCompletar As String
    <MessageBodyMember([Namespace]:="", Order:=17)>
    Public Property TrabajosSinCompletar() As String
        Get
            Return pTrabajosSinCompletar
        End Get
        Set(ByVal value As String)
            pTrabajosSinCompletar = value
        End Set
    End Property

    Private pFechaEnviadoDiseno As DateTime
    <MessageBodyMember([Namespace]:="", Order:=18)>
    Public Property FechaEnviadoDiseno() As DateTime
        Get
            Return pFechaEnviadoDiseno
        End Get
        Set(ByVal value As DateTime)
            pFechaEnviadoDiseno = value
        End Set
    End Property

    Private pDescripcionFecha As String
    <MessageBodyMember([Namespace]:="", Order:=19)>
    Public Property DescripcionFecha() As String
        Get
            Return pDescripcionFecha
        End Get
        Set(ByVal value As String)
            pDescripcionFecha = value
        End Set
    End Property

    Private pEstadoTrabajo As String
    <MessageBodyMember([Namespace]:="", Order:=20)>
    Public Property EstadoTrabajo() As String
        Get
            Return pEstadoTrabajo
        End Get
        Set(ByVal value As String)
            pEstadoTrabajo = value
        End Set
    End Property

    Private pFechaIniSemEnviadoDiseno As DateTime
    <MessageBodyMember([Namespace]:="", Order:=21)>
    Public Property FechaIniSemEnviadoDiseno() As DateTime
        Get
            Return pFechaIniSemEnviadoDiseno
        End Get
        Set(ByVal value As DateTime)
            pFechaIniSemEnviadoDiseno = value
        End Set
    End Property

    Private pFechaFinSemEnviadoDiseno As DateTime
    <MessageBodyMember([Namespace]:="", Order:=22)>
    Public Property FechaFinSemEnviadoDiseno() As DateTime
        Get
            Return pFechaFinSemEnviadoDiseno
        End Get
        Set(ByVal value As DateTime)
            pFechaFinSemEnviadoDiseno = value
        End Set
    End Property

    Private pTiempoAperturaHoras As Double
    <MessageBodyMember([Namespace]:="", Order:=23)>
    Public Property TiempoAperturaHoras() As Double
        Get
            Return pTiempoAperturaHoras
        End Get
        Set(ByVal value As Double)
            pTiempoAperturaHoras = value
        End Set
    End Property

    Private pTiempoPromedio As String
    <MessageBodyMember([Namespace]:="", Order:=24)>
    Public Property TiempoPromedio() As String
        Get
            Return pTiempoPromedio
        End Get
        Set(ByVal value As String)
            pTiempoPromedio = value
        End Set
    End Property

    Private pUsuarioEnAprobacionCliente As String
    <MessageBodyMember([Namespace]:="", Order:=25)>
    Public Property UsuarioEnAprobacionCliente() As String
        Get
            Return pUsuarioEnAprobacionCliente
        End Get
        Set(ByVal value As String)
            pUsuarioEnAprobacionCliente = value
        End Set
    End Property

    Private pUsuarioEnviadoDiseno As String
    <MessageBodyMember([Namespace]:="", Order:=26)>
    Public Property UsuarioEnviadoDiseno() As String
        Get
            Return pUsuarioEnviadoDiseno
        End Get
        Set(ByVal value As String)
            pUsuarioEnviadoDiseno = value
        End Set
    End Property

    Private pTiempoDeApertura As Double
    <MessageBodyMember([Namespace]:="", Order:=27)>
    Public Property TiempoDeApertura() As Double
        Get
            Return pTiempoDeApertura
        End Get
        Set(ByVal value As Double)
            pTiempoDeApertura = value
        End Set
    End Property
End Class
