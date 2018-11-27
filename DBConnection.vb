Imports System.Data.OleDb
Imports System.Data



Public Class ConnectDB


    Shared Function UserDatabaseConn()

        Dim lst As New List(Of UserInfo)

        Dim ID As Integer
        Dim Twittername As String
        Dim Place As String

        ' Connection string for ADO.NET via OleDB
        Dim conn As OleDbConnection = New OleDbConnection(My.Settings.ConnectionString)
        Dim cmd As OleDbCommand
        Dim dr As OleDbDataReader

        'Open Database
        conn.Open()
        'MsgBox("Open Database")

        'Prepare query
        Dim query As String = "SELECT * from UserDB"


        'Run Query
        cmd = New OleDbCommand(query, conn)
        dr = cmd.ExecuteReader

        ' this loop allows you to check every row 
        Do While dr.Read

            'Set Property
            ID = dr.Item("ID")
            Twittername = dr.Item("Tname")
            Place = dr.Item("Place")


            'New Weather Info
            Dim UInfo As UserInfo
            UInfo = New UserInfo(ID, Twittername, Place)
            lst.Add(UInfo)

        Loop

        ' Close Connection
        Conn.Close()

        Return lst

    End Function


    Shared Sub UpdateUserInfo1(ByVal ID1 As Integer,
                               ByVal Tname1 As String,
                               ByVal Place1 As String)

        Dim lst As New List(Of UserInfo)

        ' Connection string for ADO.NET via OleDB
        Dim conn As OleDbConnection = New OleDbConnection(My.Settings.ConnectionString)
        Dim cmd As OleDbCommand

        'Open Database
        conn.Open()


        Dim query2 As String = String.Format("UPDATE UserDB SET Tname = '{0}', Place = '{1}'" &
                                            "WHERE ID = {2}", Tname1, Place1, ID1)


        cmd = New OleDbCommand(query2, conn)
        cmd.ExecuteNonQuery()

        'MsgBox("Data Updated")

        ' Close Connection
        conn.Close()


    End Sub



    Shared Sub InsertNew(ByVal Tname1 As String,
                         ByVal Place1 As String)


        ' Connection string for ADO.NET via OleDB
        Dim conn As OleDbConnection = New OleDbConnection(My.Settings.ConnectionString)
        Dim cmd As OleDbCommand


        'Open Database
        conn.Open()
        'MsgBox("Open Database")

        'Prepare query
        Dim query As String = String.Format("INSERT INTO UserDB (Tname, Place) VALUES ('{0}', '{1}')", Tname1, Place1)

        'Run Query
        cmd = New OleDbCommand(query, conn)
        cmd.ExecuteNonQuery()


        'For Add Interval

        query = String.Format("INSERT INTO IntervalDB (Twittername, GetIn, IntervalT, GetTempC, GetHumid, GetWind, GetRain, GetStatus, CurrentInterval, GetAt, GetAtHour, GetAtMin)" &
                              " VALUES ('{0}', {1}, {2}, {3}, {4}, {5}, {6}, {7}, 0, {8}, {9}, {10})", Tname1, False, 0, True, False, False, False, False, False, False, 0, 0)
        cmd = New OleDbCommand(query, conn)
        cmd.ExecuteNonQuery()

        'For Add Notification1

        query = String.Format("INSERT INTO Notification1 (Twittername, GetNotify, GetTempC, GetTempOver, TempOverC , TempOverF, GetTempUnder, TempUnderC, TempUnderF, GetHumidOver, HumidOver, GetHumidUnder, HumidUnder, GetWindOver, WindOver) VALUES ('{0}', {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10}, {11}, {12}, {13}, {14})", Tname1, False, True, False, 0, 0, False, 0, 0, False, 0, False, 0, False, 0)
        cmd = New OleDbCommand(query, conn)
        cmd.ExecuteNonQuery()

        conn.Close()

    End Sub


    Shared Function IntervalDBConn()

        Dim lst As New List(Of IntervalInfo)

        Dim ID As Integer
        Dim Twittername As String
        Dim GetInterval As Boolean
        Dim Interval As Integer
        Dim GetTempC As Boolean
        Dim GetHumid As Boolean
        Dim GetWind As Boolean
        Dim GetRain As Boolean
        Dim GetStatus As Boolean
        Dim LastTweet As String
        Dim CurrentInterval As Integer
        Dim GetAt As Boolean
        Dim GetAtHour As Integer
        Dim GetAtMin As Integer

        ' Connection string for ADO.NET via OleDB
        Dim conn As OleDbConnection = New OleDbConnection(My.Settings.ConnectionString)
        Dim cmd As OleDbCommand
        Dim dr As OleDbDataReader

        'Open Database
        conn.Open()
        'MsgBox("Open Database")

        'Prepare query
        ' Dim query As String = "SELECT * FROM IntervalDB WHERE ID = " & i
        Dim query As String = "SELECT * FROM IntervalDB"


        'Run Query
        cmd = New OleDbCommand(query, conn)
        dr = cmd.ExecuteReader

        ' this loop allows you to check every row 
        Do While dr.Read

            'Set Property
            ID = dr.Item("ID")
            Twittername = dr.Item("TwitterName")
            GetInterval = dr.Item("GetIn")
            Interval = dr.Item("IntervalT")
            GetTempC = dr.Item("GetTempC")
            GetHumid = dr.Item("GetHumid")
            GetWind = dr.Item("GetWind")
            GetRain = dr.Item("GetRain")
            GetStatus = dr.Item("GetStatus")
            LastTweet = TryCast(dr.Item("LastTweet"), String)
            If LastTweet = Nothing Then
                LastTweet = ""
            End If
            CurrentInterval = dr.Item("CurrentInterval")
            GetAt = dr.Item("GetAt")
            GetAtHour = dr.Item("GetAtHour")
            GetAtMin = dr.Item("GetAtMin")

            'New IntervalInfo
            Dim IntInfo As IntervalInfo
            IntInfo = New IntervalInfo(ID, Twittername, GetInterval, Interval, GetTempC, GetHumid, GetWind, GetRain, GetStatus, LastTweet, CurrentInterval, GetAt, GetAtHour, GetAtMin)
            lst.Add(IntInfo)

        Loop


        ' Close Connection
        conn.Close()

        Return lst

    End Function



    Shared Sub UpdateIntervalInfo(ByVal ID As Integer, ByVal TwitterID As String, ByVal GetIn As Boolean, ByVal Interval As Integer,
                                  ByVal GetTempC As Boolean, ByVal GetHumid As Boolean, ByVal GetWind As Boolean, ByVal GetRain As Boolean,
                                  ByVal GetStatus As Boolean, ByVal GetAt As Boolean, ByVal GetAtHour As Integer, ByVal GetAtMin As Integer)
        ' Connection string for ADO.NET via OleDB
        Dim conn As OleDbConnection = New OleDbConnection(My.Settings.ConnectionString)
        Dim cmd As OleDbCommand
        'Dim dr As OleDbDataReader

        'Open Database
        conn.Open()
        'MsgBox("Open Database")

        Dim query2 As String = String.Format("UPDATE IntervalDB SET Twittername = '{1}', GetIn = {2}, IntervalT = {3}, GetTempC = {4}, GetHumid = {5}, GetWind = {6}, GetRain = {7}, GetStatus = {8}, GetAt = {9}, GetAtHour = {10}, GetAtMin = {11}" &
                                          " WHERE ID = {0}", ID, TwitterID, GetIn, Interval, GetTempC, GetHumid, GetWind, GetRain, GetStatus, GetAt, GetAtHour, GetAtMin)

        'cmd.Parameters.Clear()
        cmd = New OleDbCommand(query2, conn)
        cmd.ExecuteNonQuery()

        'MsgBox("Data Updated")

        ' Close Connection
        conn.Close()
    End Sub
    Shared Sub UpdateIntervalInfo(ByVal ID As Integer, ByVal LastTweet As String)
        ' Connection string for ADO.NET via OleDB
        Dim conn As OleDbConnection = New OleDbConnection(My.Settings.ConnectionString)
        Dim cmd As OleDbCommand
        'Dim dr As OleDbDataReader

        'Open Database
        conn.Open()
        'MsgBox("Open Database")

        Dim query2 As String = String.Format("UPDATE IntervalDB SET LastTweet='{0}'" &
                                          " WHERE ID = {1}", LastTweet, ID)

        'cmd.Parameters.Clear()
        cmd = New OleDbCommand(query2, conn)
        cmd.ExecuteNonQuery()

        'MsgBox("Data Updated")

        ' Close Connection
        conn.Close()
    End Sub
    Shared Sub UpdateIntervalInfo(ByVal ID As Integer, ByVal CurrentInterval As Integer)
        ' Connection string for ADO.NET via OleDB
        Dim conn As OleDbConnection = New OleDbConnection(My.Settings.ConnectionString)
        Dim cmd As OleDbCommand
        'Dim dr As OleDbDataReader

        'Open Database
        conn.Open()
        'MsgBox("Open Database")

        Dim query2 As String = String.Format("UPDATE IntervalDB SET CurrentInterval={0}" &
                                          " WHERE ID = {1}", CurrentInterval, ID)

        'cmd.Parameters.Clear()
        cmd = New OleDbCommand(query2, conn)
        cmd.ExecuteNonQuery()

        'MsgBox("Data Updated")

        ' Close Connection
        conn.Close()
    End Sub


    Shared Function NotiDBConn(ByVal NotiDB As String)

        Dim lst As New List(Of NotificationInfo)

        Dim ID As Integer
        Dim Twittername As String
        Dim GetNotify As Boolean
        Dim GetTempC As Boolean
        Dim GetTempOver As Boolean
        Dim TempOverC As Integer
        Dim TempOverF As Integer
        Dim GetTempUnder As Boolean
        Dim TempUnderC As Integer
        Dim TempUnderF As Integer
        Dim GetHumidOver As Boolean
        Dim HumidOver As Integer
        Dim GetHumidUnder As Boolean
        Dim HumidUnder As Integer
        Dim GetWindOver As Boolean
        Dim WindOver As Integer
        Dim LastTweet As String

        ' Connection string for ADO.NET via OleDB
        Dim conn As OleDbConnection = New OleDbConnection(My.Settings.ConnectionString)
        Dim cmd As OleDbCommand
        Dim dr As OleDbDataReader

        'Open Database
        conn.Open()
        'MsgBox("Open Database")

        'Prepare query
        Dim query As String = "SELECT * FROM " & NotiDB ' & " WHERE ID = " & i


        'Run Query
        cmd = New OleDbCommand(query, conn)
        dr = cmd.ExecuteReader

        ' this loop allows you to check every row 
        Do While dr.Read

            'Set Property
            ID = dr.Item("ID")
            Twittername = dr.Item("TwitterName")
            GetNotify = dr.Item("GetNotify")
            GetTempC = dr.Item("GetTempC")
            GetTempOver = dr.Item("GetTempOver")
            TempOverC = dr.Item("TempOverC")
            TempOverF = dr.Item("TempOverF")
            GetTempUnder = dr.Item("GetTempUnder")
            TempUnderC = dr.Item("TempUnderC")
            TempUnderF = dr.Item("TempUnderF")
            GetHumidOver = dr.Item("GetHumidOver")
            HumidOver = dr.Item("HumidOver")
            GetHumidUnder = dr.Item("GetHumidUnder")
            HumidUnder = dr.Item("HumidUnder")
            GetWindOver = dr.Item("GetWindOver")
            WindOver = dr.Item("WindOver")
            LastTweet = TryCast(dr.Item("LastTweet"), String)
            If LastTweet = Nothing Then
                LastTweet = ""
            End If


            'New IntervalInfo
            Dim NotiInfo As NotificationInfo
            NotiInfo = New NotificationInfo(ID, Twittername, GetNotify, GetTempC, GetTempOver, TempOverC, TempOverF, GetTempUnder, TempUnderC, TempUnderF, GetHumidOver, HumidOver, GetHumidUnder, HumidUnder, GetWindOver, WindOver, LastTweet)
            lst.Add(NotiInfo)

        Loop


        ' Close Connection
        conn.Close()

        Return lst

    End Function


    Shared Sub UpdateNotificationInfo(ByVal ID As Integer, ByVal TwitterID As String, ByVal GetNotify As Boolean, ByVal GetTempC As Boolean, ByVal GetTempOver As Boolean, ByVal TempOverC As Integer, ByVal TempOverF As Integer, ByVal GetTempUnder As Boolean, ByVal TempUnderC As Integer, TempUnderF As Integer, ByVal GetHumidOver As Boolean, ByVal HumidOver As Integer, ByVal GetHumidUnder As Boolean, ByVal HumidUnder As Integer, ByVal GetWindOver As Boolean, ByVal WindOver As Integer, ByVal NotiDB As String)
        ' Connection string for ADO.NET via OleDB
        Dim conn As OleDbConnection = New OleDbConnection(My.Settings.ConnectionString)
        Dim cmd As OleDbCommand
        'Dim dr As OleDbDataReader

        'Open Database
        conn.Open()
        'MsgBox("Open Database")

        Dim query2 As String = String.Format("UPDATE {16}" &
                                           " SET Twittername = '{1}', GetNotify = {2}, GetTempC = {3}, GetTempOver = {4}, TempOverC = {5}, TempOverF = {6}, GetTempUnder = {7}, TempUnderC = {8}, TempUnderF = {9}, GetHumidOver = {10}, HumidOver = {11}, GetHumidUnder = {12}, HumidUnder = {13}, GetWindOver = {14}, WindOver = {15}" &
                                           " WHERE ID = {0}", ID, TwitterID, GetNotify, GetTempC, GetTempOver, TempOverC, TempOverF, GetTempUnder, TempUnderC, TempUnderF, GetHumidOver, HumidOver, GetHumidUnder, HumidUnder, GetWindOver, WindOver, NotiDB)

        'cmd.Parameters.Clear()
        cmd = New OleDbCommand(query2, conn)
        cmd.ExecuteNonQuery()

        'MsgBox("Data Updated")

        ' Close Connection
        conn.Close()
    End Sub

    Shared Sub UpdateNotificationInfo(ByVal ID As Integer, ByVal LastTweet As String, ByVal NotiDB As String)
        ' Connection string for ADO.NET via OleDB
        Dim conn As OleDbConnection = New OleDbConnection(My.Settings.ConnectionString)
        Dim cmd As OleDbCommand
        'Dim dr As OleDbDataReader

        'Open Database
        conn.Open()
        'MsgBox("Open Database")

        Dim query2 As String = String.Format("UPDATE {2}" &
                                           " SET LastTweet = '{1}'" &
                                           " WHERE ID = {0}", ID, LastTweet, NotiDB)

        'cmd.Parameters.Clear()
        cmd = New OleDbCommand(query2, conn)
        cmd.ExecuteNonQuery()

        'MsgBox("Data Updated")

        ' Close Connection
        conn.Close()
    End Sub

    Shared Sub DeleteUser(ByVal ID As Integer)
        Dim conn As OleDbConnection = New OleDbConnection(My.Settings.ConnectionString)
        Dim cmd As OleDbCommand

        conn.Open()
        Dim query As String

        'Delete from UserDB
        query = "DELETE FROM UserDB WHERE ID = " & ID
        cmd = New OleDbCommand(query, conn)
        cmd.ExecuteNonQuery()

        'Delete from IntervalDB
        query = "DELETE FROM IntervalDB WHERE ID = " & ID
        cmd = New OleDbCommand(query, conn)
        cmd.ExecuteNonQuery()

        'Delete from Notification1
        query = "DELETE FROM Notification1 WHERE ID = " & ID
        cmd = New OleDbCommand(query, conn)
        cmd.ExecuteNonQuery()

        conn.Close()




    End Sub

End Class
