Public Class Traits

#Region "       Constructors"

#End Region

#Region "       Properties"

    Private _Name As String
    Private _BodyType As BodyType
    Private _Background As Background
    Private _Race As Race

    Public Property Name As String
        Get
            Return _Name
        End Get
        Set(value As String)
            _Name = value
        End Set
    End Property

    Public Property BodyType As BodyType
        Get
            Return _BodyType
        End Get
        Set(value As BodyType)
            _BodyType = value
        End Set
    End Property

    Public Property Background As Background
        Get
            Return _Background
        End Get
        Set(value As Background)
            _Background = value
        End Set
    End Property

    Public Property Race As Race
        Get
            Return _Race
        End Get
        Set(value As Race)
            _Race = value
        End Set
    End Property

#End Region

#Region "       Functions"

#End Region

End Class