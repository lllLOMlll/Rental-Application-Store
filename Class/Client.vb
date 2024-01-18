Public Class Client
    Private _ClientId As Long
    Private _ClientNumber As String
    Private _FirstName As String
    Private _LastName As String
    Private _Email As String
    Private _Phone As String
    Private _DateOfBirth As Date
    Private _Address As String
    Private _City As String
    Private _Province As String
    Private _PostalCode As String
    Private _Status As ClientStatus

    Public Enum ClientStatus
        Inactive
        Active
        Deleted
    End Enum

    ' Parameterless constructor
    Public Sub New()
    End Sub

    ' Getters and Setters
    Public Property ClientId As Long
        Get
            Return _ClientId
        End Get
        Set(value As Long)
            _ClientId = value
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

    Public Property FirstName As String
        Get
            Return _FirstName
        End Get
        Set(value As String)
            _FirstName = value
        End Set
    End Property

    Public Property LastName As String
        Get
            Return _LastName
        End Get
        Set(value As String)
            _LastName = value
        End Set
    End Property

    Public Property Email As String
        Get
            Return _Email
        End Get
        Set(value As String)
            _Email = value
        End Set
    End Property

    Public Property Phone As String
        Get
            Return _Phone
        End Get
        Set(value As String)
            _Phone = value
        End Set
    End Property

    Public Property DateOfBirth As Date
        Get
            Return _DateOfBirth
        End Get
        Set(value As Date)
            _DateOfBirth = value
        End Set
    End Property

    Public Property Address As String
        Get
            Return _Address
        End Get
        Set(value As String)
            _Address = value
        End Set
    End Property

    Public Property City As String
        Get
            Return _City
        End Get
        Set(value As String)
            _City = value
        End Set
    End Property

    Public Property Province As String
        Get
            Return _Province
        End Get
        Set(value As String)
            _Province = value
        End Set
    End Property

    Public Property PostalCode As String
        Get
            Return _PostalCode
        End Get
        Set(value As String)
            _PostalCode = value
        End Set
    End Property

    Public Property Status As ClientStatus
        Get
            Return _Status
        End Get
        Set(value As ClientStatus)
            _Status = value
        End Set
    End Property

End Class

