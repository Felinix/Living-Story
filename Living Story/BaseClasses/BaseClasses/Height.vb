Public Class Height
    Inherits BaseClass

    Public Sub New()
        _Height = Heights.Medium
    End Sub

    Private _Height As Heights

    Public Property Height As Heights
        Get
            Return _Height
        End Get
        Set(value As Heights)
            _Height = value
        End Set
    End Property

    Public Overrides Function GetMe() As String
        If _Height = Heights._Short Then
            Return "Short"
        ElseIf _Height = Heights.Medium Then
            Return "Medium"
        ElseIf _Height = Heights.Tall Then
            Return "Tall"
        Else
            Return "Error"
        End If
    End Function

End Class

Public Enum Heights
    _Short = 1
    Medium
    Tall
End Enum