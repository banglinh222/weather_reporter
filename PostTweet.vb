Imports Twitterizer


Public Class PostTweet
    Public Tweet As String = ""
    Public upoption As StatusUpdateOptions = New StatusUpdateOptions
    Public mentionuser As String

    Sub New(ByVal StringToTweet As String)
        Tweet = StringToTweet
    End Sub

    Sub New(ByVal StringToTweet As String, ByVal mention As String)
        Tweet = StringToTweet
        mentionuser = mention
    End Sub

    Sub New(ByVal StringToTweet As String, ByVal mention As String, ByVal InReplyToID As Decimal)
        Tweet = StringToTweet
        mentionuser = mention
        upoption.InReplyToStatusId = InReplyToID
    End Sub

    Public Function UpdateTweet() As TwitterResponse(Of TwitterStatus)
        Try
            Dim update As TwitterResponse(Of TwitterStatus)
            If mentionuser = Nothing Then
                'The twitter response class provides details of the response from an api call to the twitter api.
                update = TwitterStatus.Update(Main_GUI.tokens, Tweet, upoption)
            ElseIf mentionuser <> Nothing Then
                update = TwitterStatus.Update(Main_GUI.tokens, String.Format("@{0} {1}", mentionuser, Tweet), upoption)
            End If
            Return update
        Catch ex As Exception
            'MessageBox.Show(ex.ToString)
            Return Nothing
        End Try
    End Function

    Public Function DirectMessage() As TwitterResponse(Of TwitterDirectMessage)
        Try
            Dim update As TwitterResponse(Of TwitterDirectMessage)
            update = TwitterDirectMessage.Send(Main_GUI.tokens, mentionuser, Tweet)

            Return update

        Catch ex As Exception
            Return Nothing

        End Try
    End Function
End Class
