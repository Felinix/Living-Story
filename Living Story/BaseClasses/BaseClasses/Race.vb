Public Class Race

#Region "       Constructors"

#End Region

#Region "       Properties"

    Private _Name As String
    Private _RaceStat As String
    Private _RaceStatBonus As Integer
    Private _RaceDerivedStat As String
    Private _RaceDerivedStatBonus As Integer
    Private _RaceHPBonus As Integer
    Private _RaceMPBonus As Integer

    Public Property Name As String
        Get
            Return _Name
        End Get
        Set(value As String)
            _Name = value
        End Set
    End Property

    Public Property RaceStat As String
        Get
            Return _RaceStat
        End Get
        Set(value As String)
            _RaceStat = value
        End Set
    End Property

    Public Property RaceStatBonus As Integer
        Get
            Return _RaceStatBonus
        End Get
        Set(value As Integer)
            _RaceStatBonus = value
        End Set
    End Property

    Public Property RaceDerivedStat As String
        Get
            Return _RaceDerivedStat
        End Get
        Set(value As String)
            _RaceDerivedStat = value
        End Set
    End Property

    Public Property RaceDerivedStatBonus As Integer
        Get
            Return _RaceDerivedStatBonus
        End Get
        Set(value As Integer)
            _RaceDerivedStatBonus = value
        End Set
    End Property

    Public Property RaceHPBonus As Integer
        Get
            Return _RaceHPBonus
        End Get
        Set(value As Integer)
            _RaceHPBonus = value
        End Set
    End Property

    Public Property RaceMPBonus As Integer
        Get
            Return _RaceMPBonus
        End Get
        Set(value As Integer)
            _RaceMPBonus = value
        End Set
    End Property

#End Region

#Region "       Functions"

#End Region

End Class