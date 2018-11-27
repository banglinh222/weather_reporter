

Public Class WeatherInfo

    Private _Date As DateTime
    Private _Time As DateTime
    Private _DayLight As Boolean
    Private _OutTemp As Double
    Private _CurrentRain As Double
    Private _CurrentWind As Double
    Private _WindDirection As String
    Private _Humidity As Double

    Property tDate As DateTime
        Get
            Return _Date
        End Get
        Set(ByVal value As DateTime)
            _Date = value
        End Set
    End Property

    Property tTime As DateTime
        Get
            Return _Time
        End Get
        Set(ByVal value As DateTime)
            _Time = value
        End Set
    End Property

    Property DayLight As Boolean
        Get
            Return _DayLight
        End Get
        Set(ByVal value As Boolean)
            _DayLight = value
        End Set
    End Property

    Property OutTemp As Double
        Get
            Return _OutTemp
        End Get
        Set(ByVal value As Double)
            _OutTemp = value
        End Set
    End Property

    Property CurrentRain As Double
        Get
            Return _CurrentRain
        End Get
        Set(ByVal value As Double)
            _CurrentRain = value
        End Set
    End Property

    Property CurrentWind As Double
        Get
            Return _CurrentWind
        End Get
        Set(ByVal value As Double)
            _CurrentWind = value
        End Set
    End Property

    Property WindDirection As String
        Get
            Return _WindDirection
        End Get
        Set(ByVal value As String)
            _WindDirection = value
        End Set
    End Property

    Property Humidity As Double
        Get
            Return _Humidity
        End Get
        Set(ByVal value As Double)
            _Humidity = value
        End Set
    End Property

    Sub New(ByVal a As DateTime, ByVal b As DateTime, ByVal c As Boolean, ByVal d As Double, ByVal e As Double, ByVal f As Double, ByVal g As String, ByVal h As Double)

        tDate = a
        tTime = b
        DayLight = c
        OutTemp = d
        CurrentRain = e
        CurrentWind = f
        WindDirection = g
        Humidity = h


    End Sub
End Class

