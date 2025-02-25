Public Class BaseModel

    Public Sub New()
        [Error] = New ErrorModel()
    End Sub

    Public Property [Error] As ErrorModel
End Class
