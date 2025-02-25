Imports System.Xml.Serialization

<XmlTypeAttribute()>
Public Class BaseErrorEL
    <XmlElementAttribute([Namespace]:="", Order:=1)>
    Public Property Codigo As String

    <XmlElementAttribute([Namespace]:="", Order:=2)>
    Public Property Descripcion As String

    <XmlElementAttribute([Namespace]:="", Order:=3)>
    Public Property Parametros As String
End Class
