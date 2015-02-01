Public Class BodyType

#Region "       Constructors"

#End Region

#Region "       Properties"

    Private _Name As String
    Private _BodyTypeStat As String
    Private _BodyTypeStatBonus As Integer
    Private _BodyTypeDerivedStat As String
    Private _BodyTypeDerivedStatBonus As Integer
    Private _BodyTypeHPBonus As Integer
    Private _BodyTypeMPBonus As Integer

    Public Property Name As String
        Get
            Return _Name
        End Get
        Set(value As String)
            _Name = value
        End Set
    End Property

    Public Property BodyTypeStat As String
        Get
            Return _BodyTypeStat
        End Get
        Set(value As String)
            _BodyTypeStat = value
        End Set
    End Property

    Public Property BodyTypeStatBonus As Integer
        Get
            Return _BodyTypeStatBonus
        End Get
        Set(value As Integer)
            _BodyTypeStatBonus = value
        End Set
    End Property

    Public Property BodyTypeDerivedStat As String
        Get
            Return _BodyTypeDerivedStat
        End Get
        Set(value As String)
            _BodyTypeDerivedStat = value
        End Set
    End Property

    Public Property BodyTypeDerivedStatBonus As Integer
        Get
            Return _BodyTypeDerivedStatBonus
        End Get
        Set(value As Integer)
            _BodyTypeDerivedStatBonus = value
        End Set
    End Property

    Public Property BodyTypeHPBonus As Integer
        Get
            Return _BodyTypeHPBonus
        End Get
        Set(value As Integer)
            _BodyTypeHPBonus = value
        End Set
    End Property

    Public Property BodyTypeMPBonus As Integer
        Get
            Return _BodyTypeMPBonus
        End Get
        Set(value As Integer)
            _BodyTypeMPBonus = value
        End Set
    End Property

#End Region

#Region "       Functions"

#End Region

End Class