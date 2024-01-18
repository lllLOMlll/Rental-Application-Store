Public Class Movie
    Private _VideoId As Long
    Private _Photo As String
    Private _Title As String
    Private _Year As String
    Private _Country As String
    Private _Language As String
    Private _Length As Integer
    Private _Resume As String
    Private _Genre As String
    Private _Actors As String
    Private _Director As String
    Private _Status As MovieStatus

    Public Enum MovieStatus
        Rented = 0
        Available = 1
        Removed = 2
        Lost = 3
    End Enum

    ' Parameterless constructor
    Public Sub New()
    End Sub

    ' Getters and Setters
    Public Property VideoId As Long
        Get
            Return _VideoId
        End Get
        Set(value As Long)
            _VideoId = value
        End Set
    End Property

    Public Property Photo As String
        Get
            Return _Photo
        End Get
        Set(value As String)
            _Photo = value
        End Set
    End Property

    Public Property Title As String
        Get
            Return _Title
        End Get
        Set(value As String)
            _Title = value
        End Set
    End Property

    Public Property Year As String
        Get
            Return _Year
        End Get
        Set(value As String)
            _Year = value
        End Set
    End Property

    Public Property Country As String
        Get
            Return _Country
        End Get
        Set(value As String)
            _Country = value
        End Set
    End Property

    Public Property Language As String
        Get
            Return _Language
        End Get
        Set(value As String)
            _Language = value
        End Set
    End Property

    Public Property Length As Integer
        Get
            Return _Length
        End Get
        Set(value As Integer)
            _Length = value
        End Set
    End Property

    Public Property [Resume] As String
        Get
            Return _Resume
        End Get
        Set(value As String)
            _Resume = value
        End Set
    End Property

    Public Property Genre As String
        Get
            Return _Genre
        End Get
        Set(value As String)
            _Genre = value
        End Set
    End Property

    Public Property Actors As String
        Get
            Return _Actors
        End Get
        Set(value As String)
            _Actors = value
        End Set
    End Property

    Public Property Director As String
        Get
            Return _Director
        End Get
        Set(value As String)
            _Director = value
        End Set
    End Property

    Public Property Status As MovieStatus
        Get
            Return _Status
        End Get
        Set(value As MovieStatus)
            _Status = value
        End Set
    End Property
End Class

