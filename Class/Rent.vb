Public Class Rent
    Private _RentId As Long
    Private _ClientFk As Long
    Private _VideoFk As Long
    Private _RentDate As DateTime
    'Nullable because when the client rent a movie, we dont know when he will return it
    Private _ReturnDate As Nullable(Of DateTime)

    ' Parameterless constructor
    Public Sub New()
    End Sub

    ' Getters and Setters
    Public Property RentId As Long
        Get
            Return _RentId
        End Get
        Set(value As Long)
            _RentId = value
        End Set
    End Property

    Public Property ClientFk As Long
        Get
            Return _ClientFk
        End Get
        Set(value As Long)
            _ClientFk = value
        End Set
    End Property

    Public Property VideoFk As Long
        Get
            Return _VideoFk
        End Get
        Set(value As Long)
            _VideoFk = value
        End Set
    End Property

    Public Property RentDate As DateTime
        Get
            Return _RentDate
        End Get
        Set(value As DateTime)
            _RentDate = value
        End Set
    End Property

    Public Property ReturnDate As DateTime
        Get
            Return _ReturnDate
        End Get
        Set(value As DateTime)
            _ReturnDate = value
        End Set
    End Property


End Class
