Public Class Gender
    Inherits BaseClass

    Public Sub New()
        _Gender = Genders.Male
    End Sub

    Private _Gender As Genders

    Public Property Gender As Genders
        Get
            Return _Gender
        End Get
        Set(value As Genders)
            _Gender = value
        End Set
    End Property

    Public Overrides Function GetMe() As String
        If _Gender = Genders.Male Then
            Return "Male"
        ElseIf _Gender = Genders.Female Then
            Return "Female"
        ElseIf _Gender = Genders.Herm Then
            Return "Herm"
        Else
            Return "Error"
        End If
    End Function

End Class

Public Enum Genders
    Male = 1
    Female
    Herm
End Enum