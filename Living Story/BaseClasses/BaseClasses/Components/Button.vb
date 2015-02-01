Public Class Button

    Private _Name As String
    Private _Caption As String
    Private _LeadsTo As Integer
    Private _IsShown As Boolean
    Private _Requisites As List(Of Requisite)

    Public Property Name As String
        Get
            Return _Name
        End Get
        Set(value As String)
            _Name = value
        End Set
    End Property

    Public Property Caption As String
        Get
            Return _Caption
        End Get
        Set(value As String)
            _Caption = value
        End Set
    End Property

    Public Property LeadsTo As Integer
        Get
            Return _LeadsTo
        End Get
        Set(value As Integer)
            _LeadsTo = value
        End Set
    End Property

    Public Property IsShown As Boolean
        Get
            Return _IsShown
        End Get
        Set(value As Boolean)
            _IsShown = value
        End Set
    End Property

    Public ReadOnly Property Requisites As List(Of Requisite)
        Get
            Return _Requisites
        End Get
    End Property

End Class
