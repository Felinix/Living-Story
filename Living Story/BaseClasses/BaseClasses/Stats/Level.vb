Public Class Level

#Region "       Constructors"

#End Region

#Region "       Properties"

    Private _Level As Integer
    Private _EXPearned As Integer
    Private _EXPneeded As Integer
    Private _EXPearnedTotal As Integer
    Private _EXPneededTotal As Integer

    Public Property Level As Integer
        Get
            Return _Level
        End Get
        Set(value As Integer)
            _Level = value
        End Set
    End Property

    Public Property EXPearned As Integer
        Get
            Return _EXPearned
        End Get
        Set(value As Integer)
            _EXPearned += value
            _EXPearnedTotal += value
            EXPChanged()
        End Set
    End Property

    Public Property EXPneeded As Integer
        Get
            Return _Level * 1000
        End Get
        Set(value As Integer)
            _EXPneeded = value
            _EXPneededTotal += _EXPneeded
        End Set
    End Property

    Public ReadOnly Property EXPearnedTotal As Integer
        Get
            Return _EXPearnedTotal
        End Get
    End Property

    Public ReadOnly Property EXPneededTotal As Integer
        Get
            Return _EXPneededTotal
        End Get
    End Property

#End Region

#Region "       Functions"

    Private Sub EXPChanged()
        If _EXPearned >= _EXPneeded Then
            _EXPearned = EXPearned - EXPneeded
            LevelUp()
            _EXPneededTotal += EXPneeded
        End If
    End Sub

    Private Sub LevelUp()
        Level += 1
    End Sub

#End Region

End Class