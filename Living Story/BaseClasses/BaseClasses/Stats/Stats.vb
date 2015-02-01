Public Class Stat

#Region "       Constructors"

#End Region

#Region "       Properties"

    Private _Name As String
    Private _Value As Integer

    Public Property Name As String
        Get
            Return _Name
        End Get
        Set(value As String)
            _Name = value
        End Set
    End Property

    Public Property Value As Integer
        Get
            Return _Value
        End Get
        Set(value As Integer)
            _Value = value
        End Set
    End Property

    Public ReadOnly Property Modifier As Integer
        Get
            Return (_Value - 10) / 2
        End Get
    End Property

#End Region

#Region "       Functions"

#End Region

End Class

Public Class DerivedStats

#Region "       Constructors"

#End Region

#Region "       Properties"

    Private _HP As Integer
    Private _MaxHP As Integer
    Private _MP As Integer
    Private _MaxMP As Integer
    Private _MeleeDamage As Integer
    Private _RangeDamage As Integer
    Private _MagicDamage As Integer
    Private _MagicHeal As Integer
    Private _CarryCapacity As Integer
    Private _Speed As Integer
    Private _Range As Integer
    Private _ResistNormal As Integer
    Private _ResistMagic As Integer
    Private _HPRecoveryRate As Integer
    Private _MPRecoveryRate As Integer

    Public Property HP As Integer
        Get
            Return _HP
        End Get
        Set(value As Integer)
            _HP = value
        End Set
    End Property

    Public Property MaxHP As Integer
        Get
            Return _MaxHP
        End Get
        Set(value As Integer)
            _MaxHP = value
        End Set
    End Property

    Public Property MP As Integer
        Get
            Return _MP
        End Get
        Set(value As Integer)
            _MP = value
        End Set
    End Property

    Public Property MaxMP As Integer
        Get
            Return _MaxMP
        End Get
        Set(value As Integer)
            _MaxMP = value
        End Set
    End Property

    Public Property MeleeDamage As Integer
        Get
            Return _MeleeDamage
        End Get
        Set(value As Integer)
            _MeleeDamage = value
        End Set
    End Property

    Public Property RangeDamage As Integer
        Get
            Return _RangeDamage
        End Get
        Set(value As Integer)
            _RangeDamage = value
        End Set
    End Property

    Public Property MagicDamage As Integer
        Get
            Return _MagicDamage
        End Get
        Set(value As Integer)
            _MagicDamage = value
        End Set
    End Property

    Public Property MagicHeal As Integer
        Get
            Return _MagicHeal
        End Get
        Set(value As Integer)
            _MagicHeal = value
        End Set
    End Property

    Public Property CarryCapacity As Integer
        Get
            Return _CarryCapacity
        End Get
        Set(value As Integer)
            _CarryCapacity = value
        End Set
    End Property

    Public Property Speed As Integer
        Get
            Return _Speed
        End Get
        Set(value As Integer)
            _Speed = value
        End Set
    End Property

    Public Property Range As Integer
        Get
            Return _Range
        End Get
        Set(value As Integer)
            _Range = value
        End Set
    End Property

    Public Property ResistNormal As Integer
        Get
            Return _ResistNormal
        End Get
        Set(value As Integer)
            _ResistNormal = value
        End Set
    End Property

    Public Property ResistMagic As Integer
        Get
            Return _ResistMagic
        End Get
        Set(value As Integer)
            _ResistMagic = value
        End Set
    End Property

    Public Property HPRecoveryRate As Integer
        Get
            Return _HPRecoveryRate
        End Get
        Set(value As Integer)
            _HPRecoveryRate = value
        End Set
    End Property

    Public Property MPRecoveryRate As Integer
        Get
            Return _MPRecoveryRate
        End Get
        Set(value As Integer)
            _MPRecoveryRate = value
        End Set
    End Property

#End Region

#Region "       Functions"

    Public Sub UpdateDerivedStats(_Stats As Stat, _Level As Level, _Characteristics As Traits)

        'HP = _Stats.ConstitutionMod * _Level.Level + _Characteristics.BodyType.BodyTypeHPBonus ' + Feats
        'MP = _Stats.IntelligenceMod * _Level.Level + _Characteristics.BodyType.BodyTypeMPBonus ' + Feats
        'MeleeDamage = _Stats.StrengthMod ' + Feats
        'RangeDamage = _Stats.AgilityMod ' + Feats
        'MagicDamage = _Stats.IntelligenceMod ' + Feats
        'MagicHeal = _Stats.IntelligenceMod ' + Feats
        'CarryCapacity = _Stats.StrengthMod * 2
        'Speed = _Stats.AgilityMod * 5
        'Range = _Stats.AgilityMod * 10
        'ResistNormal = _Stats.ConstitutionMod * 10
        'ResistMagic = _Stats.SpiritMod * 10
        'HPRecoveryRate = (_Stats.SpiritMod * _Stats.ConstitutionMod) / 5
        'MPRecoveryRate = (_Stats.SpiritMod * _Stats.IntelligenceMod) / 5

    End Sub

#End Region

End Class