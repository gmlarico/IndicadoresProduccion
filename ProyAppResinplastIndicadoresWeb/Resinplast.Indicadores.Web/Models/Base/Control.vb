Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web

Namespace Models.Base
    Public MustInherit Class Control
        Public Property Id As String
        Public Property Text As String
        Public Property Visible As Boolean
        Public Property Enabled As Boolean
        Public Property ClassName As String
    End Class
End Namespace