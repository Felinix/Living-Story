Public Class BodyType
    Inherits BaseClass

    Public Sub New()
        _BodyType = BodyTypes.Average
    End Sub

    Private _BodyType As BodyTypes

    Public Property BodyType As BodyTypes
        Get
            Return _BodyType
        End Get
        Set(value As BodyTypes)
            _BodyType = value
        End Set
    End Property

    Public Overrides Function GetMe() As String
        If _BodyType = BodyTypes.Average Then
            Return "Average"
        ElseIf _BodyType = BodyTypes.Chubby Then
            Return "Chubby"
        ElseIf _BodyType = BodyTypes.Muscular Then
            Return "Muscular"
        ElseIf _BodyType = BodyTypes.Slim Then
            Return "Slim"
        ElseIf _BodyType = BodyTypes.Thick Then
            Return "Thick"
        ElseIf _BodyType = BodyTypes.Toned Then
            Return "Toned"
        Else
            Return "Error"
        End If
    End Function

End Class

Public Enum BodyTypes
    Slim
    Toned
    Average
    Muscular
    Chubby
    Thick
End Enum