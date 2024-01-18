Public Class CreditCard
    Private _CreditCardId As Long
    Private _CardType As String
    Private _Number As String
    Private _ExpDate As Date
    Private _ClientNumber As String

    ' Parameterless constructor
    Public Sub New()
    End Sub

    ' Getters and Setters
    Public Property CreditCardId As Long
        Get
            Return _CreditCardId
        End Get
        Set(value As Long)
            _CreditCardId = value
        End Set
    End Property

    Public Property CardType As String
        Get
            Return _CardType
        End Get
        Set(value As String)
            _CardType = value
        End Set
    End Property

    Public Property Number As String
        Get
            Return _Number
        End Get
        Set(value As String)
            _Number = value
        End Set
    End Property

    Public Property ExpDate As Date
        Get
            Return _ExpDate
        End Get
        Set(value As Date)
            _ExpDate = value
        End Set
    End Property

    Public Property ClientNumber As String
        Get
            Return _ClientNumber
        End Get
        Set(value As String)
            _ClientNumber = value
        End Set
    End Property

End Class

