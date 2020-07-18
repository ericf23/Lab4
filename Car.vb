Option Strict On
Public Class Car

#Region "Properties"
    Private carMake As String = String.Empty
    Private carModel As String = String.Empty
    Private carYear As Integer = 0
    Private carPrice As Decimal = 0
    Private carNewStatus As Boolean = False

    Private carInternalId As Integer = 0
    Private carCount As Integer = 0
#End Region

#Region "Property methods"
    ''' <summary>
    ''' Get/ Set the Car's Make
    ''' </summary>
    ''' <returns>Make as a string</returns>
    Public Property Make() As String
        Get
            Return carMake
        End Get
        Set(ByVal value As String)
            carMake = value
        End Set
    End Property

    ''' <summary>
    ''' Get/ Set the Car's Model
    ''' </summary>
    ''' <returns>Model as a string</returns>
    Public Property Model() As String
        Get
            Return carModel
        End Get
        Set(ByVal value As String)
            carModel = value
        End Set
    End Property

    ''' <summary>
    ''' Get/ Set the Car's Year
    ''' </summary>
    ''' <returns>Year as a string</returns>
    Public Property Year() As Integer
        Get
            Return carYear
        End Get
        Set(ByVal value As Integer)
            carYear = value
        End Set
    End Property

    ''' <summary>
    ''' Get/ Set the Car's Price
    ''' </summary>
    ''' <returns>Price as a Double</returns>
    Public Property Price() As Decimal
        Get
            Return carPrice
        End Get
        Set(ByVal value As Decimal)
            carPrice = value
        End Set
    End Property

    ''' <summary>
    ''' Get/ Set whether the Car is new
    ''' </summary>
    ''' <returns>New status as boolean</returns>
    Public Property NewStatus() As Boolean
        Get
            Return carNewStatus
        End Get
        Set(ByVal value As Boolean)
            carNewStatus = value
        End Set
    End Property

    ''' <summary>
    ''' Get the Car's Internal ID
    ''' </summary>
    ''' <returns>Internal ID as an integer</returns>
    Public ReadOnly Property InternalId() As Integer
        Get
            Return carInternalId
        End Get
    End Property

    ''' <summary>
    ''' Get the current count of cars
    ''' </summary>
    ''' <returns>Count as an integer</returns>
    Public ReadOnly Property Count() As Integer
        Get
            Return carCount
        End Get
    End Property
#End Region

#Region "Constructors"
    ''' <summary>
    ''' Create a new car using default values
    ''' </summary>
    Public Sub New()
        carCount += 1
        carInternalId = carCount
    End Sub

    ''' <summary>
    ''' Create a new car using provided values
    ''' </summary>
    Public Sub New(make As String, model As String, year As Integer, price As Decimal, newStatus As Boolean)
        carCount += 1
        carInternalId = carCount
        Me.Make = make
        Me.Model = model
        Me.Year = year
        Me.Price = price
        Me.NewStatus = newStatus
    End Sub
#End Region

#Region "Methods"
    Public Function GetCarData() As String
        Return "The lot has a " & Me.Year & " " & Me.Make & " " & Me.Model & " that costs " & Me.Price
    End Function
#End Region

End Class
