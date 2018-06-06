Public Class GprsData
    Private _port As Integer
    Public Property Port() As Integer
        Get
            Return _port
        End Get
        Set(ByVal value As Integer)
            _port = value
        End Set
    End Property

    Private _device_model As String
    Public Property DeviceModel() As String
        Get
            Return _device_model
        End Get
        Set(ByVal value As String)
            _device_model = value
        End Set
    End Property

    Private _client As String
    Public Property Client() As String
        Get
            Return _client
        End Get
        Set(ByVal value As String)
            _client = value
        End Set
    End Property

    Private _date_time As Date
    Public Property DateTime() As Date
        Get
            Return _date_time
        End Get
        Set(ByVal value As Date)
            _date_time = value
        End Set
    End Property

    Private _imei As String
    Public Property Imei() As String
        Get
            Return _imei
        End Get
        Set(ByVal value As String)
            _imei = value
        End Set
    End Property

    Private _trace As String
    Public Property Trace() As String
        Get
            Return _trace
        End Get
        Set(ByVal value As String)
            _trace = value
        End Set
    End Property

    Private _code As String
    Public Property Code() As String
        Get
            Return _code
        End Get
        Set(ByVal value As String)
            _code = value
        End Set
    End Property

    Private _latitude As Double
    Public Property Latitude() As Double
        Get
            Return _latitude
        End Get
        Set(ByVal value As Double)
            _latitude = value
        End Set
    End Property

    Private _longitude As Double
    Public Property Longitude() As Double
        Get
            Return _longitude
        End Get
        Set(ByVal value As Double)
            _longitude = value
        End Set
    End Property

    Private _license_plate As String
    Public Property LicensePlate() As String
        Get
            Return _license_plate
        End Get
        Set(ByVal value As String)
            _license_plate = value
        End Set
    End Property

    Private _orientation As Integer
    Public Property Orientation() As Integer
        Get
            Return _orientation
        End Get
        Set(ByVal value As Integer)
            _orientation = value
        End Set
    End Property

    Private _origin As String
    Public Property Origin() As String
        Get
            Return _origin
        End Get
        Set(ByVal value As String)
            _origin = value
        End Set
    End Property

    Private _fix As String
    Public Property Fix() As String
        Get
            Return _fix
        End Get
        Set(ByVal value As String)
            _fix = value
        End Set
    End Property

    Private _speed As Integer
    Public Property Speed() As Integer
        Get
            Return _speed
        End Get
        Set(ByVal value As Integer)
            _speed = value
        End Set
    End Property

    Public Sub New()
        DateTime = Now
    End Sub
End Class
