Public Class Character

#Region "       Constructors"

#End Region

#Region "       Properties"

    Private _Stats As List(Of Stat)
    Private _Money As Currency
    Private _Level As Level
    Private _DerivedStats As DerivedStats
    Private _Traits As Traits

    Public Property Stats As List(Of Stat)
        Get
            Return _Stats
        End Get
        Set(value As List(Of Stat))
            _Stats = value
        End Set
    End Property

    Public Property Money As Currency
        Get
            Return _Money
        End Get
        Set(value As Currency)
            _Money = value
        End Set
    End Property

    Public Property Level As Level
        Get
            Return _Level
        End Get
        Set(value As Level)
            _Level = value
        End Set
    End Property

    Public Property DerivedStats As DerivedStats
        Get
            Return _DerivedStats
        End Get
        Set(value As DerivedStats)
            _DerivedStats = value
        End Set
    End Property

    Public Property Traits As Traits
        Get
            Return _Traits
        End Get
        Set(value As Traits)
            _Traits = value
        End Set
    End Property

#End Region

#Region "       Functions"



#End Region

End Class