Public Class Asset

#Region "       Constructors"

    Private _Name As String

    Public Property Name As String
        Get
            Return _Name
        End Get
        Set(value As String)
            _Name = value
        End Set
    End Property

#End Region

#Region "       Properties"

    Private _Buttons As List(Of Button)

    Public ReadOnly Property Buttons As List(Of Button)
        Get
            Return _Buttons
        End Get
    End Property

#End Region

#Region "       Functions"

#End Region

End Class
