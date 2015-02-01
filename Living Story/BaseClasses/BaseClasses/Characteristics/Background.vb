Public Class Background

#Region "       Constructors"

#End Region

#Region "       Properties"

    Private _Name As String
    Private _BackgroundStat As String
    Private _BackgroundStatBonus As Integer
    Private _BackgroundDerivedStat As String
    Private _BackgroundDerivedStatBonus As Integer
    Private _BackgroundHPBonus As Integer
    Private _BackgroundMPBonus As Integer

    Public Property Name As String
        Get
            Return _Name
        End Get
        Set(value As String)
            _Name = value
        End Set
    End Property

    Public Property BackgroundStat As String
        Get
            Return _BackgroundStat
        End Get
        Set(value As String)
            _BackgroundStat = value
        End Set
    End Property

    Public Property BackgroundStatBonus As Integer
        Get
            Return _BackgroundStatBonus
        End Get
        Set(value As Integer)
            _BackgroundStatBonus = value
        End Set
    End Property

    Public Property BackgroundDerivedStat As String
        Get
            Return _BackgroundDerivedStat
        End Get
        Set(value As String)
            _BackgroundDerivedStat = value
        End Set
    End Property

    Public Property BackgroundDerivedStatBonus As Integer
        Get
            Return _BackgroundDerivedStatBonus
        End Get
        Set(value As Integer)
            _BackgroundDerivedStatBonus = value
        End Set
    End Property

    Public Property BackgroundHPBonus As Integer
        Get
            Return _BackgroundHPBonus
        End Get
        Set(value As Integer)
            _BackgroundHPBonus = value
        End Set
    End Property

    Public Property BackgroundMPBonus As Integer
        Get
            Return _BackgroundMPBonus
        End Get
        Set(value As Integer)
            _BackgroundMPBonus = value
        End Set
    End Property

#End Region

#Region "       Functions"

#End Region

End Class