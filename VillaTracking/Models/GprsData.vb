Public Class GprsData
    Private _localPort As Integer
    Public Property LocalPort() As Integer
        Get
            Return _localPort
        End Get
        Set(ByVal value As Integer)
            _localPort = value
        End Set
    End Property

    Private _remotePort As Integer
    Public Property RemotePort() As Integer
        Get
            Return _remotePort
        End Get
        Set(ByVal value As Integer)
            _remotePort = value
        End Set
    End Property

    Private _remoteIp As String
    Public Property RemoteIp() As String
        Get
            Return _remoteIp
        End Get
        Set(ByVal value As String)
            _remoteIp = value
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

    Private _event_name As String
    Public Property EventName() As String
        Get
            Return _event_name
        End Get
        Set(ByVal value As String)
            _event_name = value
        End Set
    End Property

    Private _speed_limit As Integer
    Public Property SpeedLimit() As Integer
        Get
            Return _speed_limit
        End Get
        Set(ByVal value As Integer)
            _speed_limit = value
        End Set
    End Property

    Private _battery_alert As Integer
    Public Property BatteryAlert() As Integer
        Get
            Return _battery_alert
        End Get
        Set(ByVal value As Integer)
            _battery_alert = value
        End Set
    End Property

    Private _geofence_alert As Integer
    Public Property GeofenceAlert() As Integer
        Get
            Return _geofence_alert
        End Get
        Set(ByVal value As Integer)
            _geofence_alert = value
        End Set
    End Property

    Private _speed_alert As Integer
    Public Property SpeedAlert() As Integer
        Get
            Return _speed_alert
        End Get
        Set(ByVal value As Integer)
            _speed_alert = value
        End Set
    End Property

    Private _ignition_alert As Integer
    Public Property IgnitionAlert() As Integer
        Get
            Return _ignition_alert
        End Get
        Set(ByVal value As Integer)
            _ignition_alert = value
        End Set
    End Property

    Private _motion_alert As Integer
    Public Property MotionAlert() As Integer
        Get
            Return _motion_alert
        End Get
        Set(ByVal value As Integer)
            _motion_alert = value
        End Set
    End Property

    Private _validation_speed As Date?
    Public Property ValidationSpeed() As Date?
        Get
            Return _validation_speed
        End Get
        Set(ByVal value As Date?)
            _validation_speed = value
        End Set
    End Property

    Private _validation_battery As Date?
    Public Property ValidationBattery() As Date?
        Get
            Return _validation_battery
        End Get
        Set(ByVal value As Date?)
            _validation_battery = value
        End Set
    End Property

    Private _validation_geofence As Date?
    Public Property ValidationGeofence() As Date?
        Get
            Return _validation_geofence
        End Get
        Set(ByVal value As Date?)
            _validation_geofence = value
        End Set
    End Property

    Private _client_id As Integer
    Public Property ClientId() As Integer
        Get
            Return _client_id
        End Get
        Set(ByVal value As Integer)
            _client_id = value
        End Set
    End Property

    Private _vehicle_id As Integer
    Public Property VehicleId() As Integer
        Get
            Return _vehicle_id
        End Get
        Set(ByVal value As Integer)
            _vehicle_id = value
        End Set
    End Property

    Private _device_id As Integer
    Public Property DeviceId() As Integer
        Get
            Return _device_id
        End Get
        Set(ByVal value As Integer)
            _device_id = value
        End Set
    End Property

    Private _geofence_id As Integer
    Public Property GeofenceId() As Integer
        Get
            Return _geofence_id
        End Get
        Set(ByVal value As Integer)
            _geofence_id = value
        End Set
    End Property

    Private _geofence_vehicle_id As Integer
    Public Property GeofenceVehicleId() As Integer
        Get
            Return _geofence_vehicle_id
        End Get
        Set(ByVal value As Integer)
            _geofence_vehicle_id = value
        End Set
    End Property

    Private _geofence_last_status As Integer
    Public Property GeofenceLastStatus() As Integer
        Get
            Return _geofence_last_status
        End Get
        Set(ByVal value As Integer)
            _geofence_last_status = value
        End Set
    End Property

    Private _geofence_name As String
    Public Property GeofenceName() As String
        Get
            Return _geofence_name
        End Get
        Set(ByVal value As String)
            _geofence_name = value
        End Set
    End Property

    Private _geofence_points As String
    Public Property GeofencePoints() As String
        Get
            Return _geofence_points
        End Get
        Set(ByVal value As String)
            _geofence_points = value
        End Set
    End Property
    Public Sub New()
        DateTime = Now
    End Sub
End Class
