Public Class Employee
    Private _UserId As Integer
    Private _EmployeeNumber As String
    Private _Username As String
    Private _Password As String
    Private _FirstName As String
    Private _LastName As String
    Private _DateOfBirth As Date
    Private _Address As String
    Private _City As String
    Private _Province As String
    Private _PostalCode As String
    Private _HomePhone As String
    Private _CellPhone As String
    Private _StartDate As Date
    Private _SIN As String
    Private _HourlyPay As Double
    Private _Education As String
    Private _Level As String
    Private _Status As String


    Public Enum CanadianProvince
        Alberta
        BritishColumbia
        Manitoba
        NewBrunswick
        NewfoundlandAndLabrador
        NorthwestTerritories
        NovaScotia
        Nunavut
        Ontario
        PrinceEdwardIsland
        Quebec
        Saskatchewan
        Yukon
    End Enum
    Public Enum EducationLevel
        DES
        AEC
        DEC
        Certificate
        BAC
        Master
        Doc
    End Enum

    Public Enum LevelType
        Low
        Medium
        High
        Admin
    End Enum

    Public Enum StatusType
        Inactive
        Active
        Deleted
    End Enum

    '***************************** CONSTRUCTORS '*****************************
    ' Parameterless constructor
    Public Sub New()

    End Sub



    '***************************** GETTERS AND SETTERS '*****************************
    ' Getter and Setter for _UserId
    Public Property UserId As Integer
        Get
            Return _UserId
        End Get
        Set(value As Integer)
            _UserId = value
        End Set
    End Property

    ' Getter and Setter for _EmployeeNumber
    Public Property EmployeeNumber As String
        Get
            Return _EmployeeNumber
        End Get
        Set(value As String)
            _EmployeeNumber = value
        End Set
    End Property

    ' Getter and Setter for _Username
    Public Property Username As String
        Get
            Return _Username
        End Get
        Set(value As String)
            _Username = value
        End Set
    End Property

    ' Getter and Setter for _Password
    Public Property Password As String
        Get
            Return _Password
        End Get
        Set(value As String)
            _Password = value
        End Set
    End Property

    ' Getter and Setter for _FirstName
    Public Property FirstName As String
        Get
            Return _FirstName
        End Get
        Set(value As String)
            _FirstName = value
        End Set
    End Property

    ' Getter and Setter for _LastName
    Public Property LastName As String
        Get
            Return _LastName
        End Get
        Set(value As String)
            _LastName = value
        End Set
    End Property

    ' Getter and Setter for _DateOfBirth
    Public Property DateOfBirth As Date
        Get
            Return _DateOfBirth
        End Get
        Set(value As Date)
            _DateOfBirth = value
        End Set
    End Property

    ' Getter and Setter for _Address
    Public Property Address As String
        Get
            Return _Address
        End Get
        Set(value As String)
            _Address = value
        End Set
    End Property

    ' Getter and Setter for _City
    Public Property City As String
        Get
            Return _City
        End Get
        Set(value As String)
            _City = value
        End Set
    End Property

    ' Getter and Setter for _Province
    Public Property Province As String
        Get
            Return _Province
        End Get
        Set(value As String)
            _Province = value
        End Set
    End Property

    ' Getter and Setter for _PostalCode
    Public Property PostalCode As String
        Get
            Return _PostalCode
        End Get
        Set(value As String)
            _PostalCode = value
        End Set
    End Property

    ' Getter and Setter for _HomePhone
    Public Property HomePhone As String
        Get
            Return _HomePhone
        End Get
        Set(value As String)
            _HomePhone = value
        End Set
    End Property

    ' Getter and Setter for _CellPhone
    Public Property CellPhone As String
        Get
            Return _CellPhone
        End Get
        Set(value As String)
            _CellPhone = value
        End Set
    End Property

    ' Getter and Setter for _StartDate
    Public Property StartDate As DateTime
        Get
            Return _StartDate
        End Get
        Set(value As DateTime)
            _StartDate = value
        End Set
    End Property

    ' Getter and Setter for _SIN
    Public Property SIN As String
        Get
            Return _SIN
        End Get
        Set(value As String)
            _SIN = value
        End Set
    End Property

    ' Getter and Setter for _HourlyPay
    Public Property HourlyPay As Double
        Get
            Return _HourlyPay
        End Get
        Set(value As Double)
            _HourlyPay = value
        End Set
    End Property

    ' Getter and Setter for _Education
    Public Property Education As String
        Get
            Return _Education
        End Get
        Set(value As String)
            _Education = value
        End Set
    End Property

    ' Getter and Setter for _Level
    Public Property Level As String
        Get
            Return _Level
        End Get
        Set(value As String)
            _Level = value
        End Set
    End Property

    ' Getter and Setter for _Status
    Public Property Status As String
        Get
            Return _Status
        End Get
        Set(value As String)
            _Status = value
        End Set
    End Property

End Class
