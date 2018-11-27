''' <summary>
''' Connect to Google Weather and retrieve weatherinfo
''' Taken from http://duncsweb.com/forums/topic/429-vbnet-google-weather-api/
''' </summary>
''' <remarks></remarks>
Module GoogleWeatherAPI
    Public Structure GoogleWeatherinfo
        Dim Failed As Boolean
        Dim errormessage As Exception
        Dim location As String
        Dim forcast_date As String
        Dim checked_time_date As String
        Dim humidity As String
        Dim highf As String
        Dim lowf As String
        Dim highc As String
        Dim lowc As String
        Dim currenttempC As String
        Dim currenttempF As String
        Dim predicted_icon As String
        Dim current_icon As String
        Dim current_condition As String
        Dim predicted_condition As String
        Dim wind_condition As String
        Dim day As String
    End Structure


    Public Function Grab_Weather(ByVal Location As String) As GoogleWeatherinfo
        With Grab_Weather
            .Failed = True
            Try
                Dim webclient As New Net.WebClient
                Dim xml As String = webclient.DownloadString("http://www.google.com/ig/api?weather=" & Location)
                xml = xml.Replace(Chr(34), "").Replace(vbNewLine, "")

                If xml.Contains("<problem_cause data=/>") Then
                    .Failed = True
                    Exit Function
                End If

                .location = Mid(Mid(xml, xml.IndexOf("<city data=") + 12), 1, Mid(xml, xml.IndexOf("<city data=") + 12).IndexOf("/>"))
                .forcast_date = Mid(Mid(xml, xml.IndexOf("<forecast_date data=") + 21), 1, Mid(xml, xml.IndexOf("<forecast_date data=") + 21).IndexOf("/>"))
                .checked_time_date = Mid(Mid(xml, xml.IndexOf("<current_date_time data=") + 25), 1, Mid(xml, xml.IndexOf("<current_date_time data=") + 25).IndexOf("/>"))
                .humidity = Mid(Mid(xml, xml.IndexOf("<humidity data=") + 16), 1, Mid(xml, xml.IndexOf("<humidity data=") + 16).IndexOf("/>"))
                .highf = Mid(Mid(xml, xml.IndexOf("<high data=") + 12), 1, Mid(xml, xml.IndexOf("<high data=") + 12).IndexOf("/>"))
                .lowf = Mid(Mid(xml, xml.IndexOf("<low data=") + 11), 1, Mid(xml, xml.IndexOf("<low data=") + 11).IndexOf("/>"))
                .highc = Math.Round((((.highf - "32") / "9") * "5"), 0)
                .lowc = Math.Round((((.lowf - "32") / "9") * "5"), 0)
                .currenttempC = Mid(Mid(xml, xml.IndexOf("<temp_c data=") + 14), 1, Mid(xml, xml.IndexOf("<temp_c data=") + 14).IndexOf("/>"))
                .currenttempF = Mid(Mid(xml, xml.IndexOf("<temp_f data=") + 14), 1, Mid(xml, xml.IndexOf("<temp_f data=") + 14).IndexOf("/>"))
                .current_icon = Mid(Mid(xml, xml.IndexOf("<icon data=") + 12), 1, Mid(xml, xml.IndexOf("<icon data=") + 12).IndexOf("/>")) : .current_icon = "http://www.google.com" & .current_icon
                .predicted_icon = Mid(xml, xml.IndexOf("<high data=")) : .predicted_icon = Mid(.predicted_icon, .predicted_icon.IndexOf("<icon data=") + 12) : .predicted_icon = Mid(.predicted_icon, 1, .predicted_icon.IndexOf("/>")) : .predicted_icon = "http://wwww.google.com" & .predicted_icon
                .current_condition = Mid(Mid(xml, xml.IndexOf("<condition data=") + 17), 1, Mid(xml, xml.IndexOf("<condition data=") + 17).IndexOf("/>"))
                .predicted_condition = Mid(xml, xml.IndexOf("<day_of_week data=")) : .predicted_condition = Mid(Mid(.predicted_condition, .predicted_condition.IndexOf("<condition data=") + 17), 1, Mid(.predicted_condition, .predicted_condition.IndexOf("<condition data=") + 16).IndexOf("/>") - 1)
                .wind_condition = Mid(Mid(xml, xml.IndexOf("<wind_condition data=") + 22), 1, Mid(xml, xml.IndexOf("<wind_condition data=") + 22).IndexOf("/>"))
                .day = Mid(Mid(xml, xml.IndexOf("<day_of_week data=") + 19), 1, Mid(xml, xml.IndexOf("<day_of_week data=") + 19).IndexOf("/>"))

                Return Grab_Weather
            Catch ex As Exception
                .Failed = True
                .errormessage = ex
                Exit Function
            End Try
            .Failed = False
        End With
    End Function


End Module