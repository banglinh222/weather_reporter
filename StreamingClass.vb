Imports System
Imports Twitterizer
Imports Twitterizer.Streaming
'Imports System.Collections.Generic
Imports System.Windows.Forms
Imports System.Threading
Imports System.IO


Public Class StreamingClass

    Shared streamop As StreamOptions = New StreamOptions
    Shared stream As TwitterStream = New TwitterStream(Main_GUI.tokens, "AjimuP", streamop)


    Shared jsonView As Boolean = False


    Shared Sub StreamCUI()
        'Search for new tweet
        streamop.Track.Add("AKB48")

        streamop.Track.Add("@AjimuP")

        Console.WriteLine("The stream is starting ...")
        StartStream()
        Console.WriteLine("The stream has started. Press any key to stop.")
        Console.ReadKey()
        Console.WriteLine("Stopping the stream ...")
        stream.EndStream(StopReasons.StoppedByRequest, "I'm stopping the stream.")
        Console.WriteLine("Press any key to exit.")
        Console.ReadKey()
    End Sub

    Shared Sub StartStream()

        stream.StartUserStream(AddressOf StreamInit, AddressOf StreamStopped, AddressOf NewTweet,
                               AddressOf DeletedTweet, AddressOf NewDirectMessage,
                               AddressOf DeletedDirectMessage, AddressOf OtherEvent, AddressOf RawJson)
    End Sub

    Private Shared Sub StreamInit(friends As TwitterIdCollection)
        If Not jsonView Then
            Console.WriteLine(String.Format("{0} friends reported.", friends.Count))
        End If
    End Sub

    Private Shared Sub StreamStopped(reason As StopReasons)
        If Not jsonView Then
            Console.WriteLine(String.Format("The stream has stopped. Reason: {0}", reason.ToString()))
            Try
                For i As Integer = 0 To 10
                    Do Until i = 10
                        Thread.Sleep(1000)
                        StartStream()
                    Loop
                Next
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Shared Sub NewTweet(tweet As TwitterStatus)
        If Not jsonView Then
            Console.WriteLine(String.Format("New tweet: @{0}: {1}", tweet.User.ScreenName, tweet.Text))
            'If tweet.User.ScreenName.Contains("000pyo") And tweet.Text.Contains("マイリスト") Then
            If tweet.User.ScreenName = "000pyo" Then
                'Dim update As TwitterResponse(Of TwitterStatus)
                'update = TwitterStatus.Retweet(Main_GUI.tokens, tweet.Id)
                Dim myWriter As StreamWriter = New StreamWriter("log.txt", True, System.Text.Encoding.Default)
                myWriter.WriteLine("{0}|{1}|{2}", tweet.CreatedDate, tweet.User.ScreenName, tweet.Text)
                myWriter.Close()
                Console.WriteLine("LOGGED!!")
            End If

            If StrConv(tweet.Text, VbStrConv.Lowercase).Contains("@ajimup") Then
                Console.WriteLine("Message to you Arrived!!")
                Dim update As TwitterResponse(Of TwitterStatus)
                update = TwitterStatus.Update(Main_GUI.tokens, "Hello: @" & tweet.User.ScreenName.ToString)
            End If

        End If
    End Sub

    Private Shared Sub DeletedTweet(e As TwitterStreamDeletedEvent)
        If Not jsonView Then
            Console.WriteLine(String.Format("Deleted tweet: Id: {0}; UserId: {1}", e.Id, e.UserId))
        End If
    End Sub

    Private Shared Sub NewDirectMessage(message As TwitterDirectMessage)
        If Not jsonView Then
            Console.WriteLine(String.Format("New message from {0}", message.SenderScreenName))
        End If
    End Sub

    Private Shared Sub DeletedDirectMessage(e As TwitterStreamDeletedEvent)
        If Not jsonView Then
            Console.WriteLine(String.Format("Deleted message: {0}", e.UserId))
        End If
    End Sub

    Private Shared Sub OtherEvent(e As TwitterStreamEvent)
        If Not jsonView Then
            Console.WriteLine(String.Format("Other event. Type: {0}; From: {1}; {2}", e.EventType, e.Source.ScreenName, e.TargetObject))
        End If
    End Sub

    Private Shared Sub RawJson(json As String)
        If jsonView Then
            Console.WriteLine(json)
        End If
    End Sub
End Class
