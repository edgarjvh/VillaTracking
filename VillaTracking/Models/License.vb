Public Class License
    Private _id As Integer
    Public Property Id() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property

    Private _serial As String
    Public Property Serial() As String
        Get
            Return _serial
        End Get
        Set(ByVal value As String)
            _serial = value
        End Set
    End Property

    Private _type As String
    Public Property Type() As String
        Get
            Return _type
        End Get
        Set(ByVal value As String)
            _type = value
        End Set
    End Property

    Private _owner As String
    Public Property Owner() As String
        Get
            Return _owner
        End Get
        Set(ByVal value As String)
            _owner = value
        End Set
    End Property

    Private _creation_date As Date
    Public Property CreationDate() As Date
        Get
            Return _creation_date
        End Get
        Set(ByVal value As Date)
            _creation_date = value
        End Set
    End Property

    Private _expiration_date As Date
    Public Property ExpirationDate() As Date
        Get
            Return _expiration_date
        End Get
        Set(ByVal value As Date)
            _expiration_date = value
        End Set
    End Property

    Private _status As Integer
    Public Property Status() As Integer
        Get
            Return _status
        End Get
        Set(ByVal value As Integer)
            _status = value
        End Set
    End Property
End Class
