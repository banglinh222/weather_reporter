

Public Class UserInfo
    Private _ID As Integer
    Private _Twittername As String
    Private _Place As String

    Property ID As Integer
        Get
            Return _ID
        End Get
        Set(ByVal value As Integer)
            _ID = value
        End Set
    End Property

    Property TwitterName As String
        Get
            Return _Twittername
        End Get
        Set(ByVal value As String)
            _Twittername = value

        End Set
    End Property

    Property Place As String
        Get
            Return _Place
        End Get
        Set(ByVal value As String)
            _Place = value

        End Set
    End Property



    Sub New(ByVal z As Integer, ByVal a As String, ByVal b As String)
        ID = z
        TwitterName = a
        Place = b
    End Sub

End Class




Public Class IntervalInfo
    Private _ID As Integer
    Private _Twittername As String
    Private _Get As Boolean
    Private _Interval As Integer
    Private _GetTempC As Boolean
    Private _GetHumid As Boolean
    Private _GetWind As Boolean
    Private _GetRain As Boolean
    Private _GetStatus As Boolean
    Private _CurrentInterval As Integer
    Private _LastTweet As String

    Private _GetAt As Boolean
    Public Property GetAt() As Boolean
        Get
            Return _GetAt
        End Get
        Set(ByVal value As Boolean)
            _GetAt = value
        End Set
    End Property

    Private _GetAtHour As Integer
    Public Property GetAtHour() As Integer
        Get
            Return _GetAtHour
        End Get
        Set(ByVal value As Integer)
            _GetAtHour = value
        End Set
    End Property

    Private _GetAtMin As Integer
    Public Property GetAtMin() As Integer
        Get
            Return _GetAtMin
        End Get
        Set(ByVal value As Integer)
            _GetAtMin = value
        End Set
    End Property


    Property LastTweet As String
        Get
            Return _LastTweet
        End Get
        Set(ByVal value As String)
            _LastTweet = value
        End Set
    End Property
    ''' <summary>
    ''' Use for counting the time passed
    ''' Need for triggering the event
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Property CurrentInterval As Integer
        Get
            Return _CurrentInterval
        End Get
        Set(value As Integer)
            _CurrentInterval = value
        End Set
    End Property

    Property ID As Integer
        Get
            Return _ID
        End Get
        Set(ByVal value As Integer)
            _ID = value
        End Set
    End Property

    Property Twittername As String
        Get
            Return _Twittername
        End Get
        Set(ByVal value As String)
            _Twittername = value
        End Set
    End Property

    Property GetInterval As Boolean
        Get
            Return _Get
        End Get
        Set(ByVal value As Boolean)
            _Get = value
        End Set
    End Property


    Property Interval As Integer
        Get
            Return _Interval
        End Get
        Set(ByVal value As Integer)
            _Interval = value
        End Set
    End Property


    Property GetTempC As Boolean
        Get
            Return _GetTempC
        End Get
        Set(ByVal value As Boolean)
            _GetTempC = value
        End Set
    End Property


    Property GetHumid As Boolean
        Get
            Return _GetHumid
        End Get
        Set(ByVal value As Boolean)
            _GetHumid = value
        End Set
    End Property


    Property GetWind As Boolean
        Get
            Return _GetWind
        End Get
        Set(ByVal value As Boolean)
            _GetWind = value
        End Set
    End Property

    Property GetRain As Boolean
        Get
            Return _GetRain
        End Get
        Set(ByVal value As Boolean)
            _GetRain = value
        End Set
    End Property

    Property GetStatus As Boolean
        Get
            Return _GetStatus
        End Get
        Set(ByVal value As Boolean)
            _GetStatus = value
        End Set
    End Property

    Sub New(ByVal z As Integer, ByVal a As String, ByVal b As Boolean, ByVal c As Integer, ByVal d As Boolean, ByVal e As Boolean, ByVal f As Boolean,
            ByVal g As Boolean, ByVal h As Boolean, ByVal j As String, ByVal k As Integer, ByVal l As Boolean, ByVal m As Integer, ByVal n As Integer)
        ID = z
        Twittername = a
        GetInterval = b
        Interval = c
        GetTempC = d
        GetHumid = e
        GetWind = f
        GetRain = g
        GetStatus = h
        CurrentInterval = k
        LastTweet = j
        GetAt = l
        GetAtHour = m
        GetAtMin = n

    End Sub



End Class



Public Class NotificationInfo
    Private _ID As Integer
    Private _Twittername As String
    Private _GetNotify As Boolean
    Private _GetTempC As Boolean
    Private _GetTempOver As Boolean
    Private _TempOverC As Integer
    Private _TempOverF As Integer
    Private _GetTempUnder As Boolean
    Private _TempUnderC As Integer
    Private _TempUnderF As Integer
    Private _GetHumidOver As Boolean
    Private _HumidOver As Integer
    Private _GetHumidUnder As Boolean
    Private _HumidUnder As Integer
    Private _GetWindOver As Boolean
    Private _WindOver As Integer
    Private _LastTweet As String

    Property LastTweet As String
        Get
            Return _LastTweet
        End Get
        Set(ByVal value As String)
            _LastTweet = value
        End Set
    End Property


    Property ID As Integer
        Get
            Return _ID
        End Get
        Set(ByVal value As Integer)
            _ID = value
        End Set
    End Property

    Property Twittername As String
        Get
            Return _Twittername
        End Get
        Set(ByVal value As String)
            _Twittername = value
        End Set
    End Property

    Property GetNotify As Boolean
        Get
            Return _GetNotify
        End Get
        Set(ByVal value As Boolean)
            _GetNotify = value
        End Set
    End Property

    Property GetTempC As Boolean
        Get
            Return _GetTempC
        End Get
        Set(ByVal value As Boolean)
            _GetTempC = value
        End Set
    End Property

    Property GetTempOver As Boolean
        Get
            Return _GetTempOver
        End Get
        Set(ByVal value As Boolean)
            _GetTempOver = value
        End Set
    End Property

    Property TempOverC As Integer
        Get
            Return _TempOverC
        End Get
        Set(ByVal value As Integer)
            _TempOverC = value
        End Set
    End Property

    Property TempOverF As Integer
        Get
            Return _TempOverF
        End Get
        Set(ByVal value As Integer)
            _TempOverF = value
        End Set
    End Property


    Property GetTempUnder As Boolean
        Get
            Return _GetTempUnder
        End Get
        Set(ByVal value As Boolean)
            _GetTempUnder = value
        End Set
    End Property

    Property TempUnderC As Integer
        Get
            Return _TempUnderC
        End Get
        Set(ByVal value As Integer)
            _TempUnderC = value
        End Set
    End Property

    Property TempUnderF As Integer
        Get
            Return _TempUnderF
        End Get
        Set(ByVal value As Integer)
            _TempUnderF = value
        End Set
    End Property

    Property GetHumidOver As Boolean
        Get
            Return _GetHumidOver
        End Get
        Set(ByVal value As Boolean)
            _GetHumidOver = value
        End Set
    End Property

    Property HumidOver As Integer
        Get
            Return _HumidOver
        End Get
        Set(ByVal value As Integer)
            _HumidOver = value
        End Set
    End Property

    Property GetHumidUnder As Boolean
        Get
            Return _GetHumidUnder
        End Get
        Set(ByVal value As Boolean)
            _GetHumidUnder = value
        End Set
    End Property

    Property HumidUnder As Integer
        Get
            Return _HumidUnder
        End Get
        Set(ByVal value As Integer)
            _HumidUnder = value
        End Set
    End Property

    Property GetWindOver As Boolean
        Get
            Return _GetWindOver
        End Get
        Set(ByVal value As Boolean)
            _GetWindOver = value
        End Set
    End Property

    Property WindOver As Integer
        Get
            Return _WindOver
        End Get
        Set(ByVal value As Integer)
            _WindOver = value
        End Set
    End Property

    Sub New(ByVal z As Integer, ByVal a As String, ByVal b As Boolean, ByVal c As Boolean, ByVal d As Boolean, ByVal e As Integer, ByVal f As Integer, ByVal g As Boolean, ByVal h As Integer, ByVal i As Integer, ByVal j As Boolean, ByVal k As Integer, ByVal l As Boolean, ByVal m As Integer, ByVal n As Boolean, ByVal o As Integer, ByVal p As String)
        ID = z
        Twittername = a
        GetNotify = b
        GetTempC = c
        GetTempOver = d
        TempOverC = e
        TempOverF = f
        GetTempUnder = g
        TempUnderC = h
        TempUnderF = i
        GetHumidOver = j
        HumidOver = k
        GetHumidUnder = l
        HumidUnder = m
        GetWindOver = n
        WindOver = o
        LastTweet = p
    End Sub

End Class



Public Class UserList
    Inherits CollectionBase

    Public Sub Add(ByRef value As UserInfo)
        List.Add(value)
    End Sub

    Public Sub Remove(ByVal index As Integer)
        If index >= 0 And index < Count Then
            List.RemoveAt(index)
        End If
    End Sub


End Class