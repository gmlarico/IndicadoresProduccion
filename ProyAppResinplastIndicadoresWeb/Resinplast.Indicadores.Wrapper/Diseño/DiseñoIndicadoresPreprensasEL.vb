Imports System.Xml.Serialization

<XmlTypeAttribute()>
Public Class DiseñoIndicadoresPreprensasEL
    Inherits BaseEL

    Private pIdPizarraInterno As String
    <XmlElementAttribute([Namespace]:="", Order:=1)>
    Public Property IdPizarraInterno() As String
        Get
            Return pIdPizarraInterno
        End Get
        Set(ByVal value As String)
            pIdPizarraInterno = value
        End Set
    End Property

    Private pNroLegalOrdenTrabajo As String
    <XmlElementAttribute([Namespace]:="", Order:=2)>
    Public Property NroLegalOrdenTrabajo() As String
        Get
            Return pNroLegalOrdenTrabajo
        End Get
        Set(ByVal value As String)
            pNroLegalOrdenTrabajo = value
        End Set
    End Property

    Private pNombreCliente As String
    <XmlElementAttribute([Namespace]:="", Order:=3)>
    Public Property NombreCliente() As String
        Get
            Return pNombreCliente
        End Get
        Set(ByVal value As String)
            pNombreCliente = value
        End Set
    End Property

    Private pNombreProducto As String
    <XmlElementAttribute([Namespace]:="", Order:=4)>
    Public Property NombreProducto() As String
        Get
            Return pNombreProducto
        End Get
        Set(ByVal value As String)
            pNombreProducto = value
        End Set
    End Property

    Private pFechaEnviadoCliche As DateTime
    <XmlElementAttribute([Namespace]:="", Order:=5)>
    Public Property FechaEnviadoCliche() As DateTime
        Get
            Return pFechaEnviadoCliche
        End Get
        Set(ByVal value As DateTime)
            pFechaEnviadoCliche = value
        End Set
    End Property

    Private pTotalTrabajos As String
    <XmlElementAttribute([Namespace]:="", Order:=6)>
    Public Property TotalTrabajos() As String
        Get
            Return pTotalTrabajos
        End Get
        Set(ByVal value As String)
            pTotalTrabajos = value
        End Set
    End Property

    Private pTotalTrabajosAño As String
    <XmlElementAttribute([Namespace]:="", Order:=7)>
    Public Property TotalTrabajosAño() As String
        Get
            Return pTotalTrabajosAño
        End Get
        Set(ByVal value As String)
            pTotalTrabajosAño = value
        End Set
    End Property

    Private pTotalTrabajosmes As String
    <XmlElementAttribute([Namespace]:="", Order:=8)>
    Public Property TotalTrabajosmes() As String
        Get
            Return pTotalTrabajosmes
        End Get
        Set(ByVal value As String)
            pTotalTrabajosmes = value
        End Set
    End Property


    Private pTotalTrabajosdia As String
    <XmlElementAttribute([Namespace]:="", Order:=9)>
    Public Property TotalTrabajosdia() As String
        Get
            Return pTotalTrabajosdia
        End Get
        Set(ByVal value As String)
            pTotalTrabajosdia = value
        End Set
    End Property

    Private pFechaEnviadoClichemes As String
    <XmlElementAttribute([Namespace]:="", Order:=10)>
    Public Property FechaEnviadoClichemes() As String
        Get
            Return pFechaEnviadoClichemes
        End Get
        Set(ByVal value As String)
            pFechaEnviadoClichemes = value
        End Set
    End Property

    Private pAño As String
    <XmlElementAttribute([Namespace]:="", Order:=11)>
    Public Property Año() As String
        Get
            Return pAño
        End Get
        Set(ByVal value As String)
            pAño = value
        End Set
    End Property

    Private pmes As String
    <XmlElementAttribute([Namespace]:="", Order:=12)>
    Public Property mes() As String
        Get
            Return pmes
        End Get
        Set(ByVal value As String)
            pmes = value
        End Set
    End Property

    Private pNumeroSemana As String
    <XmlElementAttribute([Namespace]:="", Order:=13)>
    Public Property NumeroSemana() As String
        Get
            Return pNumeroSemana
        End Get
        Set(ByVal value As String)
            pNumeroSemana = value
        End Set
    End Property

    Private pFechaIniSemEnviadoProceso As DateTime
    <XmlElementAttribute([Namespace]:="", Order:=14)>
    Public Property FechaIniSemEnviadoProceso() As DateTime
        Get
            Return pFechaIniSemEnviadoProceso
        End Get
        Set(ByVal value As DateTime)
            pFechaIniSemEnviadoProceso = value
        End Set
    End Property

    Private pFechaFinSemEnviadoProceso As DateTime
    <XmlElementAttribute([Namespace]:="", Order:=15)>
    Public Property FechaFinSemEnviadoProceso() As DateTime
        Get
            Return pFechaFinSemEnviadoProceso
        End Get
        Set(ByVal value As DateTime)
            pFechaFinSemEnviadoProceso = value
        End Set
    End Property

    Private pPromedioSem As String
    <XmlElementAttribute([Namespace]:="", Order:=16)>
    Public Property PromedioSem() As String
        Get
            Return pPromedioSem
        End Get
        Set(ByVal value As String)
            pPromedioSem = value
        End Set
    End Property

    Private pTrabajosSinCompletar As String
    <XmlElementAttribute([Namespace]:="", Order:=17)>
    Public Property TrabajosSinCompletar() As String
        Get
            Return pTrabajosSinCompletar
        End Get
        Set(ByVal value As String)
            pTrabajosSinCompletar = value
        End Set
    End Property

    Private pFechaEnviadoProceso As DateTime
    <XmlElementAttribute([Namespace]:="", Order:=18)>
    Public Property FechaEnviadoProceso() As DateTime
        Get
            Return pFechaEnviadoProceso
        End Get
        Set(ByVal value As DateTime)
            pFechaEnviadoProceso = value
        End Set
    End Property


    Private pDescripcionFecha As String
    <XmlElementAttribute([Namespace]:="", Order:=19)>
    Public Property DescripcionFecha() As String
        Get
            Return pDescripcionFecha
        End Get
        Set(ByVal value As String)
            pDescripcionFecha = value
        End Set
    End Property

    Private pEstadoTrabajo As String
    <XmlElementAttribute([Namespace]:="", Order:=20)>
    Public Property EstadoTrabajo() As String
        Get
            Return pEstadoTrabajo
        End Get
        Set(ByVal value As String)
            pEstadoTrabajo = value
        End Set
    End Property


    Private pFechaIniSemEnviadoCliche As DateTime
    <XmlElementAttribute([Namespace]:="", Order:=21)>
    Public Property FechaIniSemEnviadoCliche() As DateTime
        Get
            Return pFechaIniSemEnviadoCliche
        End Get
        Set(ByVal value As DateTime)
            pFechaIniSemEnviadoCliche = value
        End Set
    End Property

    Private pFechaFinSemEnviadoCliche As DateTime
    <XmlElementAttribute([Namespace]:="", Order:=22)>
    Public Property FechaFinSemEnviadoCliche() As DateTime
        Get
            Return pFechaFinSemEnviadoCliche
        End Get
        Set(ByVal value As DateTime)
            pFechaFinSemEnviadoCliche = value
        End Set
    End Property

    Private pTiempoPreprensa As Integer
    <XmlElementAttribute([Namespace]:="", Order:=23)>
    Public Property TiempoPreprensa() As Integer
        Get
            Return pTiempoPreprensa
        End Get
        Set(ByVal value As Integer)
            pTiempoPreprensa = value
        End Set
    End Property

    Private pTrabajosPromedio As String
    <XmlElementAttribute([Namespace]:="", Order:=24)>
    Public Property TrabajosPromedio() As String
        Get
            Return pTrabajosPromedio
        End Get
        Set(ByVal value As String)
            pTrabajosPromedio = value
        End Set
    End Property

    Private pIdEventoControl As String
    <XmlElementAttribute([Namespace]:="", Order:=25)>
    Public Property IdEventoControl() As String
        Get
            Return pIdEventoControl
        End Get
        Set(ByVal value As String)
            pIdEventoControl = value
        End Set
    End Property

    Private pTrabajosConPC As String
    <XmlElementAttribute([Namespace]:="", Order:=26)>
    Public Property TrabajosConPC() As String
        Get
            Return pTrabajosConPC
        End Get
        Set(ByVal value As String)
            pTrabajosConPC = value
        End Set
    End Property

    Private pTrabajosSinPC As String
    <XmlElementAttribute([Namespace]:="", Order:=27)>
    Public Property TrabajosSinPC() As String
        Get
            Return pTrabajosSinPC
        End Get
        Set(ByVal value As String)
            pTrabajosSinPC = value
        End Set
    End Property
End Class
