Imports BaseClasses

Public Class StatLine

    Private _Font As Font
    Private _FontFamily As String = "Times New Roman"
    Private _FontSize As Integer = 10

    Public Property StatName As String
        Get
            Return lblStatName.Text
        End Get
        Set(value As String)
            lblStatName.Text = value.ToString()
        End Set
    End Property

    Public Property StatValue As String
        Get
            Return lblStatValue.Text
        End Get
        Set(value As String)
            lblStatValue.Text = value.ToString()
        End Set
    End Property

    Public Property StatMod As String
        Get
            Return lblStatMod.Text
        End Get
        Set(value As String)
            lblStatMod.Text = value.ToString()
        End Set
    End Property

    Public Property FontSize As Integer
        Get
            Return _FontSize
        End Get
        Set(value As Integer)
            _FontSize = value
            UpdateFonts()
        End Set
    End Property

    Public Property FontFamily As String
        Get
            Return _FontFamily
        End Get
        Set(value As String)
            _FontFamily = value
            UpdateFonts()
        End Set
    End Property

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        _Font = New Font(_FontFamily, _FontSize)

        UpdateFonts()

    End Sub

    Public Sub UpdateFonts()
        lblStatName.Font = New Font(_FontFamily, _FontSize, FontStyle.Bold)
        lblStatValue.Font = New Font(_FontFamily, _FontSize)
        lblStatMod.Font = New Font(_FontFamily, _FontSize)
    End Sub

End Class
