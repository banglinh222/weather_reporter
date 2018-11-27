Imports Twitterizer
Imports System.Text
Imports System.Threading
Imports System.Threading.Tasks
Imports System.IO
Imports System.Linq

'Imports System.Net

Public Class Main_GUI
#Region "Dim Parameters"
    Dim ID As String = "AjimuP"
    Dim Password As String = "nishantha"
    Shared ConsumerKey As String = "mCKrsOYLg86dAU5HxEYBTw"
    Shared ConsumerSecret As String = "bBYcZ6vEko0W2c7jpq1VReSHqdwrpFEY9dlVyjKkQ8"
    Shared AccessToken As String = "431465229-T84dvG9rKjEas6BNHrp6SBSmDLibho2tR9LyhrFl"
    Shared AccessTokenSecret As String = "xMe8w502kNAvfux3uaZqKd1XK1IcKhVtgjcR9Vgzq8"

    'OAuthTokens = Information for connecting with twitter using OAuth
    Public Shared tokens As OAuthTokens = New OAuthTokens With {
                                 .ConsumerKey = ConsumerKey,
                                 .ConsumerSecret = ConsumerSecret,
                                 .AccessToken = AccessToken,
                                 .AccessTokenSecret = AccessTokenSecret}

    Dim statusupdated As Boolean = False
    Dim updatestatus As String = ""
    Dim lstToFillNewTweetInto As ListBox
    Dim clearlistfirst As Boolean = False
    Dim LoadtoListAjimuP As Boolean = False
    Dim LoadtoMentionsList As Boolean = False
    Dim lstUserInfo As New List(Of UserInfo)
    Dim lstUserIntervalInfo As New List(Of IntervalInfo)
    Dim lstUserWarningInfo As New List(Of NotificationInfo)
    Dim CurrentNotiDB As String = "Notification1"
#End Region

#Region "Form Load and Close"

    Private Sub Main_GUI_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadMySettings()
    End Sub

    Private Sub Main_GUI_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        SaveMySettings()
    End Sub

    Private Sub LoadMySettings()
        'Enable Timer for posting and loading tweet
        TimerCheckNewTweet.Interval = numRefresh.Value * 1000
        TimerCheckNewTweet.Enabled = True
        TimerPostNewTweet.Interval = numAutoTweet.Value * 60000
        TimerPostNewTweet.Enabled = True
        TimerGetGW.Interval = numGW.Value * 1000
        TimerGetGW.Enabled = True
        TimerCheckIntervalEveryMinute.Enabled = True

        'Select default location for weather condition retrieval
        chkAutoTweet.Checked = My.Settings.AutoTweet
        chkRefresh.Checked = My.Settings.AutoRefresh
        chkGW.Checked = My.Settings.AutoGetGW
        numAutoTweet.Value = My.Settings.AutoTweetTime
        numRefresh.Value = My.Settings.AutoRefreshTime
        numGW.Value = My.Settings.AutoGetGWTime

        'Load place stored in my.settings
        If My.Settings.ListOfPlaces Is Nothing Then
            My.Settings.ListOfPlaces = New ArrayList
            My.Settings.ListOfPlaces.Add("Beppu")
            My.Settings.Save()
        End If

        For Each i In My.Settings.ListOfPlaces
            lstPlace.Items.Add(i)
        Next
        lstPlace.SelectedIndex = My.Settings.WeatherPlaceIndex

        Try
            Using myReader As StreamReader = New StreamReader("lstMention.txt", True)
                Do Until myReader.EndOfStream()
                    lstMentions.Items.Add(myReader.ReadLine())
                Loop
            End Using
        Catch ex As Exception
        End Try

        'Load DB
        RefreshListDB()

        'Load Tweet into 3 lists
        Load3TL()
    End Sub

    Private Sub SaveMySettings()
        My.Settings.AutoTweet = chkAutoTweet.Checked
        My.Settings.AutoRefresh = chkRefresh.Checked
        My.Settings.AutoGetGW = chkGW.Checked
        My.Settings.AutoTweetTime = numAutoTweet.Value
        My.Settings.AutoRefreshTime = numRefresh.Value
        My.Settings.AutoGetGWTime = numGW.Value
        My.Settings.WeatherPlaceIndex = lstPlace.SelectedIndex
        My.Settings.Save()

        Using myWriter As StreamWriter = New StreamWriter("lstMention.txt")
            For Each i In lstMentions.Items
                myWriter.WriteLine(i.ToString)
            Next
            myWriter.Close()
        End Using
    End Sub
#End Region

#Region "GUI Zone"

    Private Sub btnTweet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTweet.Click
        '->Use when user need to login OAuthUtility.GetAccessToken("mCKrsOYLg86dAU5HxEYBTw", "bBYcZ6vEko0W2c7jpq1VReSHqdwrpFEY9dlVyjKkQ8", ")
        Dim showUserResponse As TwitterResponse(Of TwitterUser) = TwitterUser.Show(tokens, "AjimuP")
        MessageBox.Show(showUserResponse.ResponseObject.ToString)
        PostTweetFromTextBox(txtText)
    End Sub

    Private Sub txtText_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtText.KeyPress
        'Press Enter From Textbox to Post Tweet
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            PostTweetFromTextBox(txtText)
        End If
    End Sub

    Private Sub btnRefreshTweet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefreshTweet.Click
        RefreshListDB()
        'If chkGW.Checked Then
        EvaluateGoogleWeather()
        ' End If
        'Stop timer to prevent loading tweet in the same time
        TimerCheckNewTweet.Enabled = False
        Load3TL()
        TimerCheckNewTweet.Enabled = True
    End Sub


    Private Sub btnVerify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVerify.Click
        Dim twitterResponse As TwitterResponse(Of TwitterUser) = TwitterAccount.VerifyCredentials(tokens)
        If twitterResponse.Result = RequestResult.Success Then
            Dim response As New StringBuilder()

            response.Append("Verification Status: " & twitterResponse.Result.ToString).AppendLine()
            response.Append("Your ID: " & twitterResponse.ResponseObject.Id.ToString).AppendLine()
            response.Append("Your Screen Name: " & twitterResponse.ResponseObject.ScreenName).AppendLine()
            response.Append("Your Description: " & twitterResponse.ResponseObject.Description.ToString).AppendLine()
            response.Append("Your Remaining Limit is now: " & twitterResponse.RateLimiting.Remaining.ToString)

            MessageBox.Show(response.ToString)
        Else
            MessageBox.Show(twitterResponse.Result.ToString)
        End If

    End Sub


    Private Sub TimerCheckNewTweet_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerCheckNewTweet.Tick
        If chkRefresh.Checked = True Then
            Load3TL()
        End If
    End Sub

    Private Sub TimerPostNewTweet_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerPostNewTweet.Tick
        If chkAutoTweet.Checked = True Then
            TweetWeather(lstPlace.SelectedItem)
        End If
    End Sub

    Private Sub TimerGetGW_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerGetGW.Tick
        If chkGW.Checked Then
            EvaluateGoogleWeather()
        End If
    End Sub

    Private Sub numTimer_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles numRefresh.ValueChanged
        TimerCheckNewTweet.Interval = numRefresh.Value * 1000
    End Sub

    Private Sub numAutoTweet_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles numAutoTweet.ValueChanged
        TimerPostNewTweet.Interval = numAutoTweet.Value * 60000
    End Sub

    Private Sub numGW_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles numGW.ValueChanged
        TimerGetGW.Interval = numGW.Value * 1000
    End Sub

#End Region

#Region "Tweet Zone"
#Region "Post"
    ''' <summary>
    ''' Indicate if the StartPostTweet() is called from textbox so that 
    ''' we can clear textbox when the tweet is sent.
    ''' </summary>
    ''' <remarks></remarks>
    Dim PostFromTextBoxFlag As Boolean = False
    Dim TextBoxUsedToPost As TextBox = Nothing
    Dim PostTweetCompletedFlag As Boolean = False

    Private Sub PostTweetFromTextBox(ByVal txtBox As TextBox)
        If txtBox.Text <> "" Then
            StartPostTweet(txtBox.Text)
            PostFromTextBoxFlag = True
            TextBoxUsedToPost = txtBox
        Else
            UpdateStatusLabel("Please input a message to tweet", stsLabel)
        End If

    End Sub

    'Private Sub PostDM(ByVal s As String, ByVal name As String)

    '    If s.Count > 140 Then
    '        UpdateStatusLabel("Your message is over 140 characters. Please try to shorten.", stsLabel)
    '        s = s.Remove(140)
    '    End If

    '    Dim a As New PostTweet(s, name)
    '    Dim b = a.DirectMessage()
    '    If b.Result = RequestResult.Success Then
    '        AddLogTweetPosted("d " & b.ResponseObject.RecipientScreenName.ToString & " " & b.ResponseObject.Text.ToString)
    '        UpdateStatusLabel(b.Result.ToString, stsLabel)

    '        Select Case EvalGWtoNotifyFlag
    '            Case True
    '                ConnectDB.UpdateNotificationInfo(lstUserWarningInfo.Item(iThatTriggersEvalGWtoNotify).ID, b.ResponseObject.Text.ToString, CurrentNotiDB)
    '                EvalGWtoNotifyFlag = False
    '                RefreshListDB()
    '        End Select
    '    Else
    '        EvalGWtoNotifyFlag = False
    '        UpdateStatusLabel(b.Result.ToString, stsLabel)
    '    End If
    'End Sub

    Private WithEvents BackgroundPostTweetWorker As New System.ComponentModel.BackgroundWorker
    ''' <summary>
    ''' Post new tweet, can supply person to reply to (@)
    ''' And also statusID to reply to.
    ''' </summary>
    ''' <param name="s"></param>
    ''' <remarks></remarks>
    Private Sub StartPostTweet(ByVal s As String, Optional ByVal mention As String = Nothing, Optional ByVal ReplyToID As String = Nothing)
        PostTweetCompletedFlag = False

        If s.Count > 140 Then
            UpdateStatusLabel("Your message is over 140 characters. Please try to shorten.", stsLabel)
            s = s.Remove(140)
        End If

        Dim a
        If mention <> Nothing Then
            If ReplyToID <> Nothing Then
                a = New PostTweet(s, mention, ReplyToID)
            Else
                a = New PostTweet(s, mention)
            End If
        Else
            a = New PostTweet(s)
        End If

        Try
            If BackgroundPostTweetWorker.IsBusy Then
                UpdateStatusLabel("Posting Tweet Thread is now busy, please try again", stsLabel)
            Else
                BackgroundPostTweetWorker.RunWorkerAsync(a)
            End If
        Catch ex As Exception
            UpdateStatusLabel(ex.ToString, stsLabel)
        End Try

    End Sub


    Private Sub BGPostTweet_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundPostTweetWorker.DoWork
        Dim b As PostTweet = CType(e.Argument, PostTweet)
        e.Result = b.UpdateTweet()

    End Sub
    Private Sub BGPostTweet_Completed(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) _
        Handles BackgroundPostTweetWorker.RunWorkerCompleted
        Try

            If e.Result.Content IsNot Nothing Then

                Dim TweetResult = e.Result.Result.ToString()
                Dim Log As String

                If TweetResult = "Success" Then
                    Dim TweetResponse = e.Result.ResponseObject()
                    Log = String.Format("@{0}: {1}", TweetResponse.User.ScreenName.ToString,
                                                      TweetResponse.Text.ToString)
                    'If tweet is posted from textbox, clear the textbox
                    Select Case PostFromTextBoxFlag
                        Case True
                            TextBoxUsedToPost.Text = ""
                            TextBoxUsedToPost = Nothing
                            PostFromTextBoxFlag = False
                    End Select

                    'If tweet is posted from AnalyzeTweet Sub, Refresh TL
                    Select Case AnalyzedFlag
                        Case True
                            Load3TL()
                            AnalyzedFlag = False
                    End Select

                    'If tweet is posted from EvaluateGoogleWeather Sub, Update LastTweet column
                    Select Case EvalGWtoMentionFlag
                        Case True
                            ConnectDB.UpdateIntervalInfo(lstUserIntervalInfo.Item(iThatTriggersEvalGWtoMention).ID, TweetResponse.Text.ToString)
                            EvalGWtoMentionFlag = False
                            RefreshListDB()
                    End Select

                    Select Case EvalGWtoNotifyFlag
                        Case True
                            ConnectDB.UpdateNotificationInfo(lstUserWarningInfo.Item(iThatTriggersEvalGWtoNotify).ID, TweetResponse.Text.ToString, CurrentNotiDB)
                            EvalGWtoNotifyFlag = False
                            RefreshListDB()
                    End Select
                Else
                    Log = String.Format("Error! {0}", e.Result.ErrorMessage.ToString)
                End If
                PostTweetCompletedFlag = True
                UpdateStatusLabel(TweetResult, stsLabel)
                AddLogTweetPosted(Log)
                'TimerCheckNewTweet.Enabled = False
                'StartLoadTweet(1, False, LoadTweetIntoListOfTwitterStatus.TimeLineToLoad.UserTimeline, lstAjimuP)
                'TimerCheckNewTweet.Enabled = True
            Else
                UpdateStatusLabel("Posting tweet failed...", stsLabel)
            End If

        Catch ex As Exception

        End Try
    End Sub
#End Region

#Region "Get With Background Thread + Event Handler!"

    ''' <summary>
    ''' Fetch tweets into 3 timelines
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub Load3TL()
        StartLoadTweet(100, True, LoadTweetIntoListOfTwitterStatus.TimeLineToLoad.HomeTimeline, lstTweet)
        LoadtoListAjimuP = True
        LoadtoMentionsList = True
    End Sub

    ''' <summary>
    ''' http://msdn.microsoft.com/en-us/library/wkays279.aspx
    ''' Returning Value From Multithread Procedures
    ''' </summary>
    ''' <remarks></remarks>
    Private WithEvents BackgroundLoadTweetWorker As New System.ComponentModel.BackgroundWorker
    Private Sub StartLoadTweet(ByVal amount As Integer, ByVal clear As Boolean, ByVal TL As LoadTweetIntoListOfTwitterStatus.TimeLineToLoad, ByVal lstbox As ListBox)

        Using a As New LoadTweetIntoListOfTwitterStatus(amount, TL)
            clearlistfirst = clear
            lstToFillNewTweetInto = lstbox

            Try
                BackgroundLoadTweetWorker.RunWorkerAsync(a)
            Catch ex As Exception
                UpdateStatusLabel(ex.ToString, stsLabel)
                Exit Sub
            End Try
        End Using
    End Sub

    ' This method runs on the background thread when it starts.
    Private Sub BackgroundWorker1_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs
        ) Handles BackgroundLoadTweetWorker.DoWork

        Dim b As LoadTweetIntoListOfTwitterStatus = CType(e.Argument, LoadTweetIntoListOfTwitterStatus)

        ' Return the value through the Result property.
        e.Result = b.AddTweetToList()

    End Sub

    ' This method runs on the main thread when the background thread finishes.
    Private Sub BackgroundWorker1_RunWorkerCompleted(
      ByVal sender As Object,
      ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs
      ) Handles BackgroundLoadTweetWorker.RunWorkerCompleted

        ' Access the result through the Result property.
        Dim c As List(Of TwitterStatus) = e.Result

        If c IsNot Nothing Then
            'Check duplicated status
            If lstToFillNewTweetInto.Items.Count > 0 Then
                'Use existing listbox's highest (newest) tweet for comparing
                Dim ls As String = lstToFillNewTweetInto.Items.Item(0).ToString
                Try
                    For a = c.Count - 1 To 0 Step -1
                        'Check if each new list's item matches with the old one
                        If ls.Contains(c(a).Text.ToString()) Then
                            'If matched, remove that item and items below
                            '(because they are loaded into existing list, in most cased)
                            For b = a To 0 Step -1
                                c.RemoveAt(b)
                            Next
                        End If
                        'In case no tweet retrieved at all
                        If c.Count = 0 Then
                            Exit For
                        End If
                    Next
                Catch ex As Exception
                    UpdateStatusLabel(ex.ToString, stsLabel)
                End Try
            End If


            For Each i In c
                'Split Date and Time; Use only Time 
                Dim sp As String() = Split(i.CreatedDate, " ")
                Dim d As String = String.Format("{0} @{1}: {2}", i.CreatedDate, i.User.ScreenName, i.Text)
                lstToFillNewTweetInto.Items.Insert(0, d)

                'Check for mention to @AjimuP and check if asked for weather
                If LoadtoListAjimuP = False And LoadtoMentionsList = False Then
                    Dim strToTweet = AnalyzeTweetData(i, lstPlace.SelectedIndex)
                    If strToTweet <> Nothing Then
                        StartPostTweet(String.Format("@{0} {1}", i.User.ScreenName, strToTweet))
                    End If
                End If

            Next
            UpdateStatusLabel("Loaded Tweets to " & lstToFillNewTweetInto.Name & " Successfully.", stsLabel)

        End If

        ' Simple trigger to load into AjimuP's self TL after first TL is loaded completely.
        ' Still want a better way!
        If LoadtoListAjimuP = True Then
            StartLoadTweet(100, True, LoadTweetIntoListOfTwitterStatus.TimeLineToLoad.UserTimeline, lstYourTweet)
        End If

        If LoadtoListAjimuP = False Then
            If LoadtoMentionsList = True Then
                StartLoadTweet(100, True, LoadTweetIntoListOfTwitterStatus.TimeLineToLoad.Mentions, lstMentions)
                LoadtoMentionsList = False
            End If
        End If

        LoadtoListAjimuP = False
    End Sub

#End Region

#End Region

#Region "Log Zone"
    Private Sub AddLogTweetPosted(ByVal log As String)
        lstLogOfTweetPosted.Items.Add(Date.Now.ToString & " " & log)
        lstLogOfTweetPosted.SelectedIndex = lstLogOfTweetPosted.Items.Count - 1
    End Sub


    Private Sub UpdateStatusLabel(ByVal s As String, ByVal lbl As System.Windows.Forms.ToolStripStatusLabel)
        Dim m = Date.Now.ToString + " " + s
        lbl.Text = m
        lstStatusBarLog.Items.Add(m)
        lstStatusBarLog.SelectedIndex = lstStatusBarLog.Items.Count - 1
    End Sub

#End Region

#Region "User Information DB & UI"


    Sub RefreshListDB()
        LoadUserList()
        For Each i In lstUserIntervalInfo
            ConnectDB.UpdateIntervalInfo(i.ID, i.CurrentInterval)
        Next
        lstUserIntervalInfo = ConnectDB.IntervalDBConn()
        lstUserWarningInfo = ConnectDB.NotiDBConn(CurrentNotiDB)
    End Sub

    Sub LoadUserList()

        lstUserInfo = ConnectDB.UserDatabaseConn()

        LV_UserList.Clear()

        'Set the List to Detail View
        LV_UserList.View = View.Details
        LV_UserList.CheckBoxes = False

        'To Activate an Item you must doubleclick the item
        'This will fire the 
        'ListView_OrderEntry.Activation = ItemActivation.TwoClick

        'Add Columns
        LV_UserList.Columns.Add("ID", 30, HorizontalAlignment.Right)
        LV_UserList.Columns.Add("Twitter ID", 80, HorizontalAlignment.Left)
        LV_UserList.Columns.Add("Place", 80, HorizontalAlignment.Left)


        'ListviewItem
        Dim LV_item As ListViewItem

        Dim UserList_CountRow As Integer = lstUserInfo.Count
        'MsgBox(UserList_CountRow)
        Dim i As Integer = 0
        Do While i < UserList_CountRow

            Dim lv_showlist(2) As String
            lv_showlist(0) = lstUserInfo.Item(i).ID
            lv_showlist(1) = lstUserInfo.Item(i).TwitterName
            lv_showlist(2) = lstUserInfo.Item(i).Place

            LV_item = New ListViewItem(lv_showlist)
            LV_UserList.Items.Add(LV_item)

            i += 1
        Loop

    End Sub


    Private Sub LoadMentionIntoField(ByVal IDbyAutoNumber As Integer)

        Dim i As Integer = 0
        Do While i < lstUserInfo.Count

            If lstUserInfo(i).ID = IDbyAutoNumber Then
                txt_ID1.Text = lstUserInfo(i).ID
                txt_tname1.Text = lstUserInfo(i).TwitterName
                txt_place1.Text = lstUserInfo(i).Place

                'Receive Interval mention
                If lstUserIntervalInfo(i).GetInterval = True Then
                    Chk_GetIn1.CheckState = CheckState.Checked
                Else : Chk_GetIn1.CheckState = CheckState.Unchecked
                End If

                'Get Interval Time Value
                txt_interval.Text = lstUserIntervalInfo(i).Interval

                ' Get Temp C/F
                If lstUserIntervalInfo(i).GetTempC = True Then
                    RD_GetTempC.Checked = True
                    RD_GetTempF.Checked = False
                Else
                    RD_GetTempC.Checked = False
                    RD_GetTempF.Checked = True
                End If

                'Receive Humidity
                If lstUserIntervalInfo(i).GetHumid = True Then
                    chk_GetHumd.CheckState = CheckState.Checked
                Else : chk_GetHumd.CheckState = CheckState.Unchecked
                End If

                'Receive Wind
                If lstUserIntervalInfo(i).GetWind = True Then
                    chk_GetWind.CheckState = CheckState.Checked
                Else : chk_GetWind.CheckState = CheckState.Unchecked
                End If

                'Receive Status
                If lstUserIntervalInfo(i).GetStatus = True Then
                    Chk_GetStatus.CheckState = CheckState.Checked
                Else : Chk_GetStatus.CheckState = CheckState.Unchecked
                End If

                'Receive Mention at time
                If lstUserIntervalInfo(i).GetAt = True Then
                    Chk_GetAt.Checked = True
                Else : Chk_GetAt.Checked = False

                End If
                numGetAtHour.Value = lstUserIntervalInfo(i).GetAtHour
                numGetAtMin.Value = lstUserIntervalInfo(i).GetAtMin

            End If

            i += 1
        Loop

    End Sub

    Private Sub UpdateMentionInfo()
        Dim ID As Integer = CInt(txt_ID1.Text)
        Dim Twittername As String = txt_tname1.Text
        Dim GetIn As Boolean = Chk_GetIn1.CheckState
        Dim Interval As Integer = txt_interval.Text
        Dim GetTempC As Boolean
        If RD_GetTempC.Checked = True Then
            GetTempC = True
        Else : GetTempC = False
        End If
        Dim GetHumid As Boolean = chk_GetHumd.CheckState
        Dim GetWind As Boolean = chk_GetWind.CheckState
        Dim GetRain As Boolean = False
        Dim GetStatus As Boolean = Chk_GetStatus.CheckState
        Dim GetAt As Boolean = Chk_GetAt.CheckState
        Dim GetAtHour As Integer = numGetAtHour.Value
        Dim GetAtMin As Integer = numGetAtMin.Value

        ConnectDB.UpdateIntervalInfo(ID, Twittername, GetIn, Interval, GetTempC, GetHumid, GetWind, GetRain, GetStatus, GetAt, GetAtHour, GetAtMin)

    End Sub

    Private Sub btn_SaveInterval_Click(sender As System.Object, e As System.EventArgs)
        UpdateMentionInfo()
        RefreshListDB()
    End Sub

    Private Sub LV_UserList_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles LV_UserList.SelectedIndexChanged
        If LV_UserList.SelectedItems.Count > 0 Then
            Dim a = LV_UserList.SelectedItems(0).SubItems(0).Text
            LoadMentionIntoField(a)
            LoadNotiInfoToField(a)
        End If

    End Sub

    Private Sub btn_New_Click(sender As System.Object, e As System.EventArgs) Handles btn_New.Click
        Dim Place1 As String
        If txt_place1.Text <> "" Then
            Place1 = txt_place1.Text
        Else
            Place1 = lstPlace.SelectedItem.ToString
        End If


        Dim Tname1 As String = txt_tname1.Text

        If Tname1 = "" Then
            UpdateStatusLabel("Please Enter Your Twitter ID (Name)", stsLabel)
            Exit Sub
        End If

        ConnectDB.InsertNew(Tname1, Place1)
        RefreshListDB()

    End Sub



    Private Sub Btn_Clear_Click(sender As System.Object, e As System.EventArgs) Handles Btn_Clear.Click
        ' UserInfo
        txt_ID1.Clear()
        txt_tname1.Clear()

        'Reload List
        LV_UserList.Clear()
        LoadUserList()

        'Interval
        Chk_GetIn1.CheckState = False
        txt_interval.Clear()
        RD_GetTempC.Checked = True
        RD_GetTempF.Checked = False
        chk_GetHumd.CheckState = False
        chk_GetWind.Checked = False
        Chk_GetStatus.Checked = False

        'Notification1
        RD_GetTempC1.Checked = True
        RD_GetTempF1.Checked = False
        Chk_GetTempOver1.Checked = False
        Chk_GetTempUnder1.Checked = False
        Chk_GetHumidOver1.Checked = False
        Chk_GetHumidUnder1.Checked = False
        Chk_GetWindOver1.Checked = False
        Txt_TempOver1.Clear()
        Txt_TempUnder1.Clear()
        Txt_HumidOver1.Clear()
        Txt_HumidUnder1.Clear()
        Txt_WindOver1.Clear()

    End Sub

    Private Sub Btn_Delete_Click(sender As System.Object, e As System.EventArgs) Handles Btn_Delete.Click
        If txt_ID1.Text <> "" Then
            Dim ID As Integer = txt_ID1.Text

            ConnectDB.DeleteUser(ID)
            MsgBox("User Deleted")
            RefreshListDB()
        End If

    End Sub

    Public Sub NotiInfoUpdate()

        'Set Selected ID
        Dim ID As Integer = txt_ID1.Text
        Dim Twittername As String = txt_tname1.Text

        'Set Variable Get
        Dim GetNotify As Boolean
        Dim GetTempC As Boolean
        Dim GetTempOver As Boolean
        Dim TempOverC As Integer = 0
        Dim TempOverF As Integer = 0
        Dim GetTempUnder As Boolean
        Dim TempUnderC As Integer = 0
        Dim TempUnderF As Integer = 0
        Dim GetHumidOver As Boolean
        Dim HumidOver As Integer = 0
        Dim GetHumidUnder As Boolean
        Dim HumidUnder As Integer = 0
        Dim GetWindOver As Boolean
        Dim WindOver As Integer = 0

        If RD_GetTempC1.Checked = True Then
            GetTempC = True
            TempOverC = Txt_TempOver1.Text
            TempUnderC = Txt_TempUnder1.Text
        Else
            GetTempC = False
            TempOverF = Txt_TempOver1.Text
            TempUnderF = Txt_TempUnder1.Text
        End If

        GetTempOver = Chk_GetTempOver1.CheckState
        GetTempUnder = Chk_GetTempUnder1.CheckState
        GetHumidOver = Chk_GetHumidOver1.CheckState
        GetHumidUnder = Chk_GetHumidUnder1.CheckState
        GetWindOver = Chk_GetWindOver1.CheckState
        HumidOver = Txt_HumidOver1.Text
        HumidUnder = Txt_HumidUnder1.Text
        WindOver = Txt_WindOver1.Text

        ConnectDB.UpdateNotificationInfo(ID, Twittername, GetNotify, GetTempC,
                                         GetTempOver, TempOverC, TempOverF, GetTempUnder,
                                         TempUnderC, TempUnderF, GetHumidOver, HumidOver,
                                         GetHumidUnder, HumidUnder, GetWindOver, WindOver, CurrentNotiDB)
        RefreshListDB()
    End Sub

    Private Sub LoadNotiInfoToField(ByVal IDbyAutoNumber As Integer)
        'Set Selected ID
        For i = 0 To lstUserWarningInfo.Count - 1
            If lstUserWarningInfo(i).ID = IDbyAutoNumber Then

                Dim NotiInfo As NotificationInfo = lstUserWarningInfo.Item(i)

                'Get TempC/F
                If NotiInfo.GetTempC = True Then
                    RD_GetTempC1.Checked = True
                    RD_GetTempF1.Checked = False
                    Txt_TempOver1.Text = NotiInfo.TempOverC
                    Txt_TempUnder1.Text = NotiInfo.TempUnderC
                Else
                    RD_GetTempC1.Checked = False
                    RD_GetTempF1.Checked = True
                    Txt_TempOver1.Text = NotiInfo.TempOverF
                    Txt_TempUnder1.Text = NotiInfo.TempUnderF
                End If
                'Get TempOver
                If NotiInfo.GetTempOver = True Then
                    Chk_GetTempOver1.Checked = True
                Else
                    Chk_GetTempOver1.Checked = False
                End If
                'Get TempUnder
                If NotiInfo.GetTempUnder = True Then
                    Chk_GetTempUnder1.Checked = True
                Else
                    Chk_GetTempUnder1.Checked = False
                End If
                'Get HumidityOver
                If NotiInfo.GetHumidOver = True Then
                    Chk_GetHumidOver1.Checked = True
                Else : Chk_GetHumidOver1.Checked = False
                End If
                'Get HumidityUnder
                If NotiInfo.GetHumidUnder = True Then
                    Chk_GetHumidUnder1.Checked = True
                Else : Chk_GetHumidUnder1.Checked = False
                End If
                'Get Wind
                If NotiInfo.GetWindOver = True Then
                    Chk_GetWindOver1.Checked = True
                Else : Chk_GetWindOver1.Checked = False
                End If
                Txt_HumidOver1.Text = NotiInfo.HumidOver
                Txt_HumidUnder1.Text = NotiInfo.HumidUnder
                Txt_WindOver1.Text = NotiInfo.WindOver
            End If
        Next

    End Sub


    Private Sub Btn_SaveNoti1_Click(sender As System.Object, e As System.EventArgs) Handles Btn_SaveNoti1.Click
        If txt_ID1.Text <> "" Then


            Dim ID1 As Integer = txt_ID1.Text
            Dim Tname1 As String = txt_tname1.Text
            'Dim Place1 As String = lstPlace.SelectedItem.ToString
            Dim Place1 As String = txt_place1.Text

            ConnectDB.UpdateUserInfo1(ID1, Tname1, Place1)

            UpdateMentionInfo()
            NotiInfoUpdate()
            MsgBox("Saved!")
            RefreshListDB()
        End If
    End Sub


#End Region

#Region "Google Weather Get and Tweet"

    Private Sub txtPlaceToAdd_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtPlaceToAdd.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            lstPlace.Items.Add(txtPlaceToAdd.Text.ToString)
            My.Settings.ListOfPlaces.Add(txtPlaceToAdd.Text.ToString)
        End If
    End Sub


    Private Sub lstPlace_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles lstPlace.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Delete) Or e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Back) Then
            Dim a = lstPlace.SelectedIndex
            lstPlace.Items.RemoveAt(a)
            My.Settings.ListOfPlaces.RemoveAt(a)
        End If
    End Sub

    Private Sub btnTweetWeather_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTweetWeather.Click
        TweetWeather(lstPlace.SelectedItem)
    End Sub


    Private Sub TimerCheckInterval_Tick(sender As System.Object, e As System.EventArgs) Handles TimerCheckIntervalEveryMinute.Tick
        'Add 1 (minute) to CurrentInterval
        For Each i In lstUserIntervalInfo
            i.CurrentInterval += 1
        Next
    End Sub

    '// For References
    'Dim temperature = GW.currenttempC
    'Dim humidity = GW.humidity
    'Dim currentforecastdate = GW.forcast_date
    'Dim location = GW.location
    'Dim weathercon = GW.current_condition
    'Dim wind = GW.wind_condition

    Private Function GetGoogleWeather(ByVal Place As String) As GoogleWeatherinfo
        Dim GW As GoogleWeatherinfo = GoogleWeatherAPI.Grab_Weather(Place)
        Return GW
    End Function

    Public Sub TweetWeather(ByVal Place As String, Optional ByVal mention As String = Nothing, Optional ByVal ReplyID As String = Nothing)
        Dim GW = GetGoogleWeather(Place)

        'Check if Google Weather does not return Nothing
        If GW.currenttempC <> Nothing Then

            Dim s = String.Format("Current weather of {0} is {1}, {2}°C, {3}, {4}. #{5}Weather",
                                GW.location, GW.current_condition, GW.currenttempC, GW.humidity,
                                GW.wind_condition, GW.location.Split(New Char() {","})(0))

            'Try to remove Hashtag in case the character number is over 140
            If s.Count > 140 Then
                Dim s2() = s.Split(New Char() {"#"})
                s = s2(0)
            End If

            'Post new weather information:; in reply
            If mention <> Nothing Then
                If ReplyID <> Nothing Then
                    StartPostTweet(s, mention, ReplyID)
                Else
                    StartPostTweet(s, mention)
                End If
            Else
                StartPostTweet(s)
            End If


        Else
            UpdateStatusLabel("Failed to retrieve Google Weather data", stsLabel)
        End If
    End Sub


#End Region


    Dim EvalGWtoMentionFlag As Boolean = False
    Dim EvalGWtoNotifyFlag As Boolean = False
    Dim iThatTriggersEvalGWtoMention As Integer
    Dim iThatTriggersEvalGWtoNotify As Integer
    ''' <summary>
    ''' Evaluate the google weather information retrieve to match with user condition
    ''' If the condition triggers, tweet will be sent to the users.
    ''' </summary>
    ''' <param name="gw"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function EvaluateGoogleWeather()
        For Each g In lstUserInfo
            Dim gw As GoogleWeatherinfo = GetGoogleWeather(g.Place)

            If gw.currenttempC = Nothing Then
                UpdateStatusLabel("Failed to retrieve Google Weather data", stsLabel)
                Exit Function
            End If

            Dim temperatureC = gw.currenttempC
            Dim temperatureF = gw.currenttempF
            Dim humidity = gw.humidity
            Dim wind = Split(gw.wind_condition, " ")(3)
            Dim condition = gw.current_condition
            Dim humidityNum = Trim(Split(Split(gw.humidity, ":")(1), "%")(0))

            'Check if it is time to report weather "GetAt"
            'Still have problem if time passes the specified minute
            If lstUserIntervalInfo IsNot Nothing Then
                Dim i = lstUserIntervalInfo(lstUserInfo.IndexOf(g))
                If i.GetAt = True Then
                    Dim CurrentHour As Integer = Date.Now.Hour
                    Dim CurrentMin As Integer = Date.Now.Minute

                    If i.GetAtHour = CurrentHour And i.GetAtMin = CurrentMin Then

                        Dim StrToTweet As New StringBuilder

                        StrToTweet.Append(Date.Now.Month.ToString & "/" & Date.Now.Day.ToString & " Weather Notification at " & gw.location & ": ")

                        If i.GetTempC = True Then
                            StrToTweet.Append("Temperature: " & temperatureC & "°C ")
                        ElseIf i.GetTempC = False Then
                            StrToTweet.Append("Temperature: " & temperatureF & "°F ")
                        End If

                        If i.GetHumid = True Then
                            StrToTweet.Append(humidity & " ")
                        End If

                        If i.GetWind = True Then
                            StrToTweet.Append(gw.wind_condition & " ")
                        End If

                        If i.GetStatus = True Then
                            StrToTweet.Append("Current condition: " & condition & " ")
                        End If

                        EvalGWtoMentionFlag = True
                        iThatTriggersEvalGWtoMention = lstUserIntervalInfo.IndexOf(i)
                        StartPostTweet(StrToTweet.ToString, i.Twittername)

                        Exit Function

                    End If
                End If
            End If

            'Check for Warning Option
            If lstUserWarningInfo IsNot Nothing Then
                Dim i = lstUserWarningInfo(lstUserInfo.IndexOf(g))
                'Check for any desire for warning
                If i.GetTempUnder = True Or i.GetTempOver = True Or i.GetHumidOver = True Or
                    i.GetHumidUnder = True Or i.GetWindOver = True Then

                    Dim StrToTweet As New StringBuilder

                    If i.GetTempOver = True Then
                        If i.GetTempC = True Then
                            If temperatureC > i.TempOverC Then
                                StrToTweet.Append("Temperature: " & temperatureC & "°C ")
                            End If
                        ElseIf i.GetTempC = False Then
                            If temperatureF > i.TempOverF Then
                                StrToTweet.Append("Temperature: " & temperatureF & "°F ")
                            End If
                        End If
                    End If

                    If i.GetTempUnder = True Then
                        If i.GetTempC = True Then
                            If temperatureC < i.TempUnderC Then
                                StrToTweet.Append("Temperature: " & temperatureC & "°C ")
                            End If
                        ElseIf i.GetTempC = False Then
                            If temperatureF < i.TempUnderF Then
                                StrToTweet.Append("Temperature: " & temperatureF & "°F ")
                            End If
                        End If
                    End If

                    If i.GetHumidOver = True Then
                        If humidityNum > i.HumidOver Then
                            StrToTweet.Append(humidity & " ")
                        End If
                    End If
                    If i.GetHumidUnder = True Then
                        If humidityNum < i.HumidUnder Then
                            StrToTweet.Append(humidity & " ")
                        End If
                    End If

                    If i.GetWindOver = True Then
                        If wind > i.WindOver Then
                            StrToTweet.Append(gw.wind_condition & " ")
                        End If
                    End If

                    If StrToTweet.ToString <> "" Then
                        If Not i.LastTweet.Trim.Contains(StrToTweet.ToString.Trim) Then

                            StrToTweet.Insert(0, "Weather Warning at " & Split(gw.location, ",")(0) & ": ")

                            EvalGWtoNotifyFlag = True
                            iThatTriggersEvalGWtoNotify = lstUserWarningInfo.IndexOf(i)
                            StartPostTweet(StrToTweet.ToString, i.Twittername)
                            'PostDM(StrToTweet.ToString, i.Twittername)

                            Exit Function
                        End If

                    End If

                End If

            End If

            'Check for user interval mention option
            If lstUserIntervalInfo IsNot Nothing Then

                Dim i = lstUserIntervalInfo(lstUserInfo.IndexOf(g))

                'Check if time passes enough to trigger interval mention
                If i.GetInterval = True And i.CurrentInterval >= i.Interval Then
                    Dim StrToTweet As New StringBuilder

                    StrToTweet.Append("Weather Report at " & gw.location & ": ")

                    If i.GetTempC = True Then
                        StrToTweet.Append("Temperature: " & temperatureC & "°C ")
                    ElseIf i.GetTempC = False Then
                        StrToTweet.Append("Temperature: " & temperatureF & "°F ")
                    End If

                    If i.GetHumid = True Then
                        StrToTweet.Append(humidity & " ")
                    End If

                    If i.GetWind = True Then
                        StrToTweet.Append(gw.wind_condition & " ")
                    End If

                    If i.GetStatus = True Then
                        StrToTweet.Append("Current condition: " & condition & " ")
                    End If

                    If Not i.LastTweet.Trim.Contains(StrToTweet.ToString.Trim) Then
                        EvalGWtoMentionFlag = True
                        iThatTriggersEvalGWtoMention = lstUserIntervalInfo.IndexOf(i)
                        StartPostTweet(StrToTweet.ToString, i.Twittername)

                    End If

                    'Clear Timer
                    i.CurrentInterval = 0
                    Exit Function
                End If

            End If
        Next

    End Function


#Region "Analyze Retrieved Tweet to Check for Keyword"
    Dim lstKeyword As New List(Of String)
    Dim keyword() As String = {"weather", "天気", "whether"}
    Dim keywordcnt = 3
    Dim AnalyzedFlag As Boolean = False

    ''' <summary>
    ''' Check TwitterStatus.Text for weather keyword
    ''' </summary>
    ''' <param name="i"></param>
    ''' <param name="Place"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function AnalyzeTweetData(ByVal i As Twitterizer.TwitterStatus, ByVal Place As String) As String

        Dim str As String = Nothing

        'Check for @mention asking about weather
        If i.Text.ToLower.Contains("@" + ID.ToLower) And i.User.ScreenName <> ID Then
            For a = 0 To keywordcnt - 1
                If i.Text.ToLower.Contains(keyword(a)) Then
                    'If keyword contains weather, check further if it contain "of Place"
                    If i.Text.ToLower.Contains("of ") Then
                        Dim sp() As String = Split(i.Text.ToLower, " ")
                        For b = 0 To sp.GetUpperBound(0)
                            If sp(b).Contains("of") Then
                                Dim c = sp(b + 1)
                                TweetWeather(c, i.User.ScreenName, i.Id)
                                Exit For
                            End If
                        Next
                    Else
                        TweetWeather(lstPlace.SelectedItem, i.User.ScreenName, i.Id)
                    End If
                    AnalyzedFlag = True
                End If
            Next
        End If
        Return str
    End Function
#End Region


End Class
