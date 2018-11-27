<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main_GUI
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main_GUI))
        Me.btnTweet = New System.Windows.Forms.Button()
        Me.txtText = New System.Windows.Forms.TextBox()
        Me.btnVerify = New System.Windows.Forms.Button()
        Me.lstTweet = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TimerCheckNewTweet = New System.Windows.Forms.Timer(Me.components)
        Me.numRefresh = New System.Windows.Forms.NumericUpDown()
        Me.btnRefreshTweet = New System.Windows.Forms.Button()
        Me.lstYourTweet = New System.Windows.Forms.ListBox()
        Me.lblYourTweet = New System.Windows.Forms.Label()
        Me.tabTL = New System.Windows.Forms.TabControl()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.GB_Noti1 = New System.Windows.Forms.GroupBox()
        Me.GB_Wind1 = New System.Windows.Forms.GroupBox()
        Me.Chk_GetWindOver1 = New System.Windows.Forms.CheckBox()
        Me.Lbl_Kmh = New System.Windows.Forms.Label()
        Me.Txt_WindOver1 = New System.Windows.Forms.TextBox()
        Me.Btn_Clear = New System.Windows.Forms.Button()
        Me.Btn_SaveNoti1 = New System.Windows.Forms.Button()
        Me.GB_humid1 = New System.Windows.Forms.GroupBox()
        Me.Lbl_Pct12 = New System.Windows.Forms.Label()
        Me.Lbl_Pct11 = New System.Windows.Forms.Label()
        Me.Chk_GetHumidUnder1 = New System.Windows.Forms.CheckBox()
        Me.Chk_GetHumidOver1 = New System.Windows.Forms.CheckBox()
        Me.Txt_HumidUnder1 = New System.Windows.Forms.TextBox()
        Me.Txt_HumidOver1 = New System.Windows.Forms.TextBox()
        Me.GB_Temp1 = New System.Windows.Forms.GroupBox()
        Me.lbl_CF12 = New System.Windows.Forms.Label()
        Me.lbl_CF11 = New System.Windows.Forms.Label()
        Me.Txt_TempUnder1 = New System.Windows.Forms.TextBox()
        Me.Txt_TempOver1 = New System.Windows.Forms.TextBox()
        Me.Chk_GetTempUnder1 = New System.Windows.Forms.CheckBox()
        Me.Chk_GetTempOver1 = New System.Windows.Forms.CheckBox()
        Me.GB_ShowTemp1 = New System.Windows.Forms.GroupBox()
        Me.RD_GetTempC1 = New System.Windows.Forms.RadioButton()
        Me.RD_GetTempF1 = New System.Windows.Forms.RadioButton()
        Me.GB_UserInfo = New System.Windows.Forms.GroupBox()
        Me.txt_place1 = New System.Windows.Forms.TextBox()
        Me.lblPlace = New System.Windows.Forms.Label()
        Me.Btn_Delete = New System.Windows.Forms.Button()
        Me.LV_UserList = New System.Windows.Forms.ListView()
        Me.txt_ID1 = New System.Windows.Forms.TextBox()
        Me.lbl_twitname1 = New System.Windows.Forms.Label()
        Me.lbl_ID1 = New System.Windows.Forms.Label()
        Me.btn_New = New System.Windows.Forms.Button()
        Me.txt_tname1 = New System.Windows.Forms.TextBox()
        Me.GB_GetInterval = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Chk_GetAt = New System.Windows.Forms.CheckBox()
        Me.Chk_GetIn1 = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbl_interval2 = New System.Windows.Forms.Label()
        Me.numGetAtMin = New System.Windows.Forms.NumericUpDown()
        Me.numGetAtHour = New System.Windows.Forms.NumericUpDown()
        Me.txt_interval = New System.Windows.Forms.TextBox()
        Me.GB_GetMention1 = New System.Windows.Forms.GroupBox()
        Me.chk_GetHumd = New System.Windows.Forms.CheckBox()
        Me.chk_GetWind = New System.Windows.Forms.CheckBox()
        Me.Chk_GetStatus = New System.Windows.Forms.CheckBox()
        Me.GB_GetTempC0 = New System.Windows.Forms.GroupBox()
        Me.RD_GetTempC = New System.Windows.Forms.RadioButton()
        Me.RD_GetTempF = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lstPlace = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnTweetWeather = New System.Windows.Forms.Button()
        Me.txtPlaceToAdd = New System.Windows.Forms.TextBox()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.lstMentions = New System.Windows.Forms.ListBox()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.lstStatusBarLog = New System.Windows.Forms.ListBox()
        Me.lstLogOfTweetPosted = New System.Windows.Forms.ListBox()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.numAutoTweet = New System.Windows.Forms.NumericUpDown()
        Me.chkAutoTweet = New System.Windows.Forms.CheckBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.stsLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TimerPostNewTweet = New System.Windows.Forms.Timer(Me.components)
        Me.chkRefresh = New System.Windows.Forms.CheckBox()
        Me.TimerCheckIntervalEveryMinute = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.chkGW = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.numGW = New System.Windows.Forms.NumericUpDown()
        Me.TimerGetGW = New System.Windows.Forms.Timer(Me.components)
        CType(Me.numRefresh, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabTL.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.GB_Noti1.SuspendLayout()
        Me.GB_Wind1.SuspendLayout()
        Me.GB_humid1.SuspendLayout()
        Me.GB_Temp1.SuspendLayout()
        Me.GB_ShowTemp1.SuspendLayout()
        Me.GB_UserInfo.SuspendLayout()
        Me.GB_GetInterval.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.numGetAtMin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numGetAtHour, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB_GetMention1.SuspendLayout()
        Me.GB_GetTempC0.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        CType(Me.numAutoTweet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.numGW, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnTweet
        '
        Me.btnTweet.Location = New System.Drawing.Point(356, 9)
        Me.btnTweet.Name = "btnTweet"
        Me.btnTweet.Size = New System.Drawing.Size(75, 23)
        Me.btnTweet.TabIndex = 0
        Me.btnTweet.Text = "Tweet"
        Me.btnTweet.UseVisualStyleBackColor = True
        '
        'txtText
        '
        Me.txtText.Location = New System.Drawing.Point(90, 12)
        Me.txtText.MaxLength = 150
        Me.txtText.Name = "txtText"
        Me.txtText.Size = New System.Drawing.Size(260, 20)
        Me.txtText.TabIndex = 1
        '
        'btnVerify
        '
        Me.btnVerify.Location = New System.Drawing.Point(398, 7)
        Me.btnVerify.Name = "btnVerify"
        Me.btnVerify.Size = New System.Drawing.Size(95, 23)
        Me.btnVerify.TabIndex = 2
        Me.btnVerify.Text = "Verify Status"
        Me.btnVerify.UseVisualStyleBackColor = True
        '
        'lstTweet
        '
        Me.lstTweet.FormattingEnabled = True
        Me.lstTweet.HorizontalScrollbar = True
        Me.lstTweet.Location = New System.Drawing.Point(6, 6)
        Me.lstTweet.Name = "lstTweet"
        Me.lstTweet.Size = New System.Drawing.Size(490, 381)
        Me.lstTweet.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(190, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "seconds"
        '
        'TimerCheckNewTweet
        '
        Me.TimerCheckNewTweet.Interval = 1000
        '
        'numRefresh
        '
        Me.numRefresh.Location = New System.Drawing.Point(141, 5)
        Me.numRefresh.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        Me.numRefresh.Minimum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.numRefresh.Name = "numRefresh"
        Me.numRefresh.Size = New System.Drawing.Size(48, 20)
        Me.numRefresh.TabIndex = 7
        Me.numRefresh.Value = New Decimal(New Integer() {120, 0, 0, 0})
        '
        'btnRefreshTweet
        '
        Me.btnRefreshTweet.Location = New System.Drawing.Point(476, 10)
        Me.btnRefreshTweet.Name = "btnRefreshTweet"
        Me.btnRefreshTweet.Size = New System.Drawing.Size(56, 23)
        Me.btnRefreshTweet.TabIndex = 8
        Me.btnRefreshTweet.Text = "Refresh"
        Me.btnRefreshTweet.UseVisualStyleBackColor = True
        '
        'lstYourTweet
        '
        Me.lstYourTweet.FormattingEnabled = True
        Me.lstYourTweet.HorizontalScrollbar = True
        Me.lstYourTweet.Location = New System.Drawing.Point(8, 7)
        Me.lstYourTweet.Name = "lstYourTweet"
        Me.lstYourTweet.Size = New System.Drawing.Size(494, 381)
        Me.lstYourTweet.TabIndex = 9
        '
        'lblYourTweet
        '
        Me.lblYourTweet.AutoSize = True
        Me.lblYourTweet.Location = New System.Drawing.Point(9, 14)
        Me.lblYourTweet.Name = "lblYourTweet"
        Me.lblYourTweet.Size = New System.Drawing.Size(75, 13)
        Me.lblYourTweet.TabIndex = 10
        Me.lblYourTweet.Text = "Your Message"
        '
        'tabTL
        '
        Me.tabTL.Controls.Add(Me.TabPage4)
        Me.tabTL.Controls.Add(Me.TabPage1)
        Me.tabTL.Controls.Add(Me.TabPage2)
        Me.tabTL.Controls.Add(Me.TabPage3)
        Me.tabTL.Controls.Add(Me.TabPage5)
        Me.tabTL.Controls.Add(Me.TabPage6)
        Me.tabTL.Location = New System.Drawing.Point(13, 88)
        Me.tabTL.Name = "tabTL"
        Me.tabTL.SelectedIndex = 0
        Me.tabTL.Size = New System.Drawing.Size(517, 417)
        Me.tabTL.TabIndex = 11
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.GB_Noti1)
        Me.TabPage4.Controls.Add(Me.GB_UserInfo)
        Me.TabPage4.Controls.Add(Me.GB_GetInterval)
        Me.TabPage4.Controls.Add(Me.GroupBox1)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(509, 391)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = " Control Panel"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'GB_Noti1
        '
        Me.GB_Noti1.Controls.Add(Me.GB_Wind1)
        Me.GB_Noti1.Controls.Add(Me.Btn_Clear)
        Me.GB_Noti1.Controls.Add(Me.Btn_SaveNoti1)
        Me.GB_Noti1.Controls.Add(Me.GB_humid1)
        Me.GB_Noti1.Controls.Add(Me.GB_Temp1)
        Me.GB_Noti1.Location = New System.Drawing.Point(5, 229)
        Me.GB_Noti1.Name = "GB_Noti1"
        Me.GB_Noti1.Size = New System.Drawing.Size(501, 154)
        Me.GB_Noti1.TabIndex = 0
        Me.GB_Noti1.TabStop = False
        Me.GB_Noti1.Text = "Get Notify When"
        '
        'GB_Wind1
        '
        Me.GB_Wind1.Controls.Add(Me.Chk_GetWindOver1)
        Me.GB_Wind1.Controls.Add(Me.Lbl_Kmh)
        Me.GB_Wind1.Controls.Add(Me.Txt_WindOver1)
        Me.GB_Wind1.Location = New System.Drawing.Point(245, 83)
        Me.GB_Wind1.Name = "GB_Wind1"
        Me.GB_Wind1.Size = New System.Drawing.Size(250, 41)
        Me.GB_Wind1.TabIndex = 16
        Me.GB_Wind1.TabStop = False
        Me.GB_Wind1.Text = "Wind"
        '
        'Chk_GetWindOver1
        '
        Me.Chk_GetWindOver1.AutoSize = True
        Me.Chk_GetWindOver1.Location = New System.Drawing.Point(7, 17)
        Me.Chk_GetWindOver1.Name = "Chk_GetWindOver1"
        Me.Chk_GetWindOver1.Size = New System.Drawing.Size(90, 17)
        Me.Chk_GetWindOver1.TabIndex = 0
        Me.Chk_GetWindOver1.Text = "Stronger than"
        Me.Chk_GetWindOver1.UseVisualStyleBackColor = True
        '
        'Lbl_Kmh
        '
        Me.Lbl_Kmh.AutoSize = True
        Me.Lbl_Kmh.Location = New System.Drawing.Point(169, 18)
        Me.Lbl_Kmh.Name = "Lbl_Kmh"
        Me.Lbl_Kmh.Size = New System.Drawing.Size(32, 13)
        Me.Lbl_Kmh.TabIndex = 16
        Me.Lbl_Kmh.Text = "km/h"
        '
        'Txt_WindOver1
        '
        Me.Txt_WindOver1.Location = New System.Drawing.Point(98, 15)
        Me.Txt_WindOver1.Name = "Txt_WindOver1"
        Me.Txt_WindOver1.Size = New System.Drawing.Size(62, 20)
        Me.Txt_WindOver1.TabIndex = 15
        '
        'Btn_Clear
        '
        Me.Btn_Clear.Location = New System.Drawing.Point(412, 125)
        Me.Btn_Clear.Name = "Btn_Clear"
        Me.Btn_Clear.Size = New System.Drawing.Size(39, 23)
        Me.Btn_Clear.TabIndex = 7
        Me.Btn_Clear.Text = "Clear"
        Me.Btn_Clear.UseVisualStyleBackColor = True
        '
        'Btn_SaveNoti1
        '
        Me.Btn_SaveNoti1.Location = New System.Drawing.Point(275, 125)
        Me.Btn_SaveNoti1.Name = "Btn_SaveNoti1"
        Me.Btn_SaveNoti1.Size = New System.Drawing.Size(121, 23)
        Me.Btn_SaveNoti1.TabIndex = 4
        Me.Btn_SaveNoti1.Text = "Save and Update"
        Me.Btn_SaveNoti1.UseVisualStyleBackColor = True
        '
        'GB_humid1
        '
        Me.GB_humid1.Controls.Add(Me.Lbl_Pct12)
        Me.GB_humid1.Controls.Add(Me.Lbl_Pct11)
        Me.GB_humid1.Controls.Add(Me.Chk_GetHumidUnder1)
        Me.GB_humid1.Controls.Add(Me.Chk_GetHumidOver1)
        Me.GB_humid1.Controls.Add(Me.Txt_HumidUnder1)
        Me.GB_humid1.Controls.Add(Me.Txt_HumidOver1)
        Me.GB_humid1.Location = New System.Drawing.Point(9, 83)
        Me.GB_humid1.Name = "GB_humid1"
        Me.GB_humid1.Size = New System.Drawing.Size(230, 68)
        Me.GB_humid1.TabIndex = 15
        Me.GB_humid1.TabStop = False
        Me.GB_humid1.Text = "Humidity"
        '
        'Lbl_Pct12
        '
        Me.Lbl_Pct12.AutoSize = True
        Me.Lbl_Pct12.Location = New System.Drawing.Point(170, 40)
        Me.Lbl_Pct12.Name = "Lbl_Pct12"
        Me.Lbl_Pct12.Size = New System.Drawing.Size(15, 13)
        Me.Lbl_Pct12.TabIndex = 16
        Me.Lbl_Pct12.Text = "%"
        '
        'Lbl_Pct11
        '
        Me.Lbl_Pct11.AutoSize = True
        Me.Lbl_Pct11.Location = New System.Drawing.Point(170, 18)
        Me.Lbl_Pct11.Name = "Lbl_Pct11"
        Me.Lbl_Pct11.Size = New System.Drawing.Size(15, 13)
        Me.Lbl_Pct11.TabIndex = 16
        Me.Lbl_Pct11.Text = "%"
        '
        'Chk_GetHumidUnder1
        '
        Me.Chk_GetHumidUnder1.AutoSize = True
        Me.Chk_GetHumidUnder1.Location = New System.Drawing.Point(31, 40)
        Me.Chk_GetHumidUnder1.Name = "Chk_GetHumidUnder1"
        Me.Chk_GetHumidUnder1.Size = New System.Drawing.Size(55, 17)
        Me.Chk_GetHumidUnder1.TabIndex = 0
        Me.Chk_GetHumidUnder1.Text = "Below"
        Me.Chk_GetHumidUnder1.UseVisualStyleBackColor = True
        '
        'Chk_GetHumidOver1
        '
        Me.Chk_GetHumidOver1.AutoSize = True
        Me.Chk_GetHumidOver1.Location = New System.Drawing.Point(31, 17)
        Me.Chk_GetHumidOver1.Name = "Chk_GetHumidOver1"
        Me.Chk_GetHumidOver1.Size = New System.Drawing.Size(49, 17)
        Me.Chk_GetHumidOver1.TabIndex = 0
        Me.Chk_GetHumidOver1.Text = "Over"
        Me.Chk_GetHumidOver1.UseVisualStyleBackColor = True
        '
        'Txt_HumidUnder1
        '
        Me.Txt_HumidUnder1.Location = New System.Drawing.Point(86, 37)
        Me.Txt_HumidUnder1.Name = "Txt_HumidUnder1"
        Me.Txt_HumidUnder1.Size = New System.Drawing.Size(73, 20)
        Me.Txt_HumidUnder1.TabIndex = 15
        '
        'Txt_HumidOver1
        '
        Me.Txt_HumidOver1.Location = New System.Drawing.Point(86, 15)
        Me.Txt_HumidOver1.Name = "Txt_HumidOver1"
        Me.Txt_HumidOver1.Size = New System.Drawing.Size(73, 20)
        Me.Txt_HumidOver1.TabIndex = 15
        '
        'GB_Temp1
        '
        Me.GB_Temp1.Controls.Add(Me.lbl_CF12)
        Me.GB_Temp1.Controls.Add(Me.lbl_CF11)
        Me.GB_Temp1.Controls.Add(Me.Txt_TempUnder1)
        Me.GB_Temp1.Controls.Add(Me.Txt_TempOver1)
        Me.GB_Temp1.Controls.Add(Me.Chk_GetTempUnder1)
        Me.GB_Temp1.Controls.Add(Me.Chk_GetTempOver1)
        Me.GB_Temp1.Controls.Add(Me.GB_ShowTemp1)
        Me.GB_Temp1.Location = New System.Drawing.Point(6, 19)
        Me.GB_Temp1.Name = "GB_Temp1"
        Me.GB_Temp1.Size = New System.Drawing.Size(489, 63)
        Me.GB_Temp1.TabIndex = 14
        Me.GB_Temp1.TabStop = False
        Me.GB_Temp1.Text = "Temperature"
        '
        'lbl_CF12
        '
        Me.lbl_CF12.AutoSize = True
        Me.lbl_CF12.Location = New System.Drawing.Point(384, 38)
        Me.lbl_CF12.Name = "lbl_CF12"
        Me.lbl_CF12.Size = New System.Drawing.Size(41, 13)
        Me.lbl_CF12.TabIndex = 16
        Me.lbl_CF12.Text = "Celcius"
        '
        'lbl_CF11
        '
        Me.lbl_CF11.AutoSize = True
        Me.lbl_CF11.Location = New System.Drawing.Point(384, 15)
        Me.lbl_CF11.Name = "lbl_CF11"
        Me.lbl_CF11.Size = New System.Drawing.Size(41, 13)
        Me.lbl_CF11.TabIndex = 16
        Me.lbl_CF11.Text = "Celcius"
        '
        'Txt_TempUnder1
        '
        Me.Txt_TempUnder1.Location = New System.Drawing.Point(301, 35)
        Me.Txt_TempUnder1.Name = "Txt_TempUnder1"
        Me.Txt_TempUnder1.Size = New System.Drawing.Size(73, 20)
        Me.Txt_TempUnder1.TabIndex = 15
        '
        'Txt_TempOver1
        '
        Me.Txt_TempOver1.Location = New System.Drawing.Point(301, 12)
        Me.Txt_TempOver1.Name = "Txt_TempOver1"
        Me.Txt_TempOver1.Size = New System.Drawing.Size(73, 20)
        Me.Txt_TempOver1.TabIndex = 15
        '
        'Chk_GetTempUnder1
        '
        Me.Chk_GetTempUnder1.AutoSize = True
        Me.Chk_GetTempUnder1.Location = New System.Drawing.Point(246, 37)
        Me.Chk_GetTempUnder1.Name = "Chk_GetTempUnder1"
        Me.Chk_GetTempUnder1.Size = New System.Drawing.Size(55, 17)
        Me.Chk_GetTempUnder1.TabIndex = 14
        Me.Chk_GetTempUnder1.Text = "Below"
        Me.Chk_GetTempUnder1.UseVisualStyleBackColor = True
        '
        'Chk_GetTempOver1
        '
        Me.Chk_GetTempOver1.AutoSize = True
        Me.Chk_GetTempOver1.Location = New System.Drawing.Point(246, 14)
        Me.Chk_GetTempOver1.Name = "Chk_GetTempOver1"
        Me.Chk_GetTempOver1.Size = New System.Drawing.Size(49, 17)
        Me.Chk_GetTempOver1.TabIndex = 14
        Me.Chk_GetTempOver1.Text = "Over"
        Me.Chk_GetTempOver1.UseVisualStyleBackColor = True
        '
        'GB_ShowTemp1
        '
        Me.GB_ShowTemp1.Controls.Add(Me.RD_GetTempC1)
        Me.GB_ShowTemp1.Controls.Add(Me.RD_GetTempF1)
        Me.GB_ShowTemp1.Location = New System.Drawing.Point(17, 17)
        Me.GB_ShowTemp1.Name = "GB_ShowTemp1"
        Me.GB_ShowTemp1.Size = New System.Drawing.Size(180, 35)
        Me.GB_ShowTemp1.TabIndex = 13
        Me.GB_ShowTemp1.TabStop = False
        Me.GB_ShowTemp1.Text = "Show Temperature in"
        '
        'RD_GetTempC1
        '
        Me.RD_GetTempC1.AutoSize = True
        Me.RD_GetTempC1.Checked = True
        Me.RD_GetTempC1.Location = New System.Drawing.Point(34, 13)
        Me.RD_GetTempC1.Name = "RD_GetTempC1"
        Me.RD_GetTempC1.Size = New System.Drawing.Size(59, 17)
        Me.RD_GetTempC1.TabIndex = 9
        Me.RD_GetTempC1.TabStop = True
        Me.RD_GetTempC1.Text = "Celcius"
        Me.RD_GetTempC1.UseVisualStyleBackColor = True
        '
        'RD_GetTempF1
        '
        Me.RD_GetTempF1.AutoSize = True
        Me.RD_GetTempF1.Location = New System.Drawing.Point(101, 13)
        Me.RD_GetTempF1.Name = "RD_GetTempF1"
        Me.RD_GetTempF1.Size = New System.Drawing.Size(75, 17)
        Me.RD_GetTempF1.TabIndex = 9
        Me.RD_GetTempF1.Text = "Fahrenheit"
        Me.RD_GetTempF1.UseVisualStyleBackColor = True
        '
        'GB_UserInfo
        '
        Me.GB_UserInfo.Controls.Add(Me.txt_place1)
        Me.GB_UserInfo.Controls.Add(Me.lblPlace)
        Me.GB_UserInfo.Controls.Add(Me.Btn_Delete)
        Me.GB_UserInfo.Controls.Add(Me.LV_UserList)
        Me.GB_UserInfo.Controls.Add(Me.txt_ID1)
        Me.GB_UserInfo.Controls.Add(Me.lbl_twitname1)
        Me.GB_UserInfo.Controls.Add(Me.lbl_ID1)
        Me.GB_UserInfo.Controls.Add(Me.btn_New)
        Me.GB_UserInfo.Controls.Add(Me.txt_tname1)
        Me.GB_UserInfo.Location = New System.Drawing.Point(9, 70)
        Me.GB_UserInfo.Name = "GB_UserInfo"
        Me.GB_UserInfo.Size = New System.Drawing.Size(318, 151)
        Me.GB_UserInfo.TabIndex = 17
        Me.GB_UserInfo.TabStop = False
        Me.GB_UserInfo.Text = "User Information"
        '
        'txt_place1
        '
        Me.txt_place1.Location = New System.Drawing.Point(59, 70)
        Me.txt_place1.Name = "txt_place1"
        Me.txt_place1.Size = New System.Drawing.Size(88, 20)
        Me.txt_place1.TabIndex = 27
        '
        'lblPlace
        '
        Me.lblPlace.AutoSize = True
        Me.lblPlace.Location = New System.Drawing.Point(22, 72)
        Me.lblPlace.Name = "lblPlace"
        Me.lblPlace.Size = New System.Drawing.Size(34, 13)
        Me.lblPlace.TabIndex = 26
        Me.lblPlace.Text = "Place"
        '
        'Btn_Delete
        '
        Me.Btn_Delete.Location = New System.Drawing.Point(12, 121)
        Me.Btn_Delete.Name = "Btn_Delete"
        Me.Btn_Delete.Size = New System.Drawing.Size(133, 23)
        Me.Btn_Delete.TabIndex = 25
        Me.Btn_Delete.Text = "Delete Selected User"
        Me.Btn_Delete.UseVisualStyleBackColor = True
        '
        'LV_UserList
        '
        Me.LV_UserList.FullRowSelect = True
        Me.LV_UserList.GridLines = True
        Me.LV_UserList.HideSelection = False
        Me.LV_UserList.Location = New System.Drawing.Point(151, 13)
        Me.LV_UserList.MultiSelect = False
        Me.LV_UserList.Name = "LV_UserList"
        Me.LV_UserList.Size = New System.Drawing.Size(161, 131)
        Me.LV_UserList.TabIndex = 6
        Me.LV_UserList.UseCompatibleStateImageBehavior = False
        Me.LV_UserList.View = System.Windows.Forms.View.Details
        '
        'txt_ID1
        '
        Me.txt_ID1.Location = New System.Drawing.Point(59, 19)
        Me.txt_ID1.Name = "txt_ID1"
        Me.txt_ID1.ReadOnly = True
        Me.txt_ID1.Size = New System.Drawing.Size(88, 20)
        Me.txt_ID1.TabIndex = 3
        '
        'lbl_twitname1
        '
        Me.lbl_twitname1.AutoSize = True
        Me.lbl_twitname1.Location = New System.Drawing.Point(7, 48)
        Me.lbl_twitname1.Name = "lbl_twitname1"
        Me.lbl_twitname1.Size = New System.Drawing.Size(53, 13)
        Me.lbl_twitname1.TabIndex = 2
        Me.lbl_twitname1.Text = "Twitter @"
        '
        'lbl_ID1
        '
        Me.lbl_ID1.AutoSize = True
        Me.lbl_ID1.Location = New System.Drawing.Point(19, 22)
        Me.lbl_ID1.Name = "lbl_ID1"
        Me.lbl_ID1.Size = New System.Drawing.Size(41, 13)
        Me.lbl_ID1.TabIndex = 2
        Me.lbl_ID1.Text = "Ref. ID"
        '
        'btn_New
        '
        Me.btn_New.Location = New System.Drawing.Point(36, 95)
        Me.btn_New.Name = "btn_New"
        Me.btn_New.Size = New System.Drawing.Size(88, 23)
        Me.btn_New.TabIndex = 5
        Me.btn_New.Text = "New User"
        Me.btn_New.UseVisualStyleBackColor = True
        '
        'txt_tname1
        '
        Me.txt_tname1.Location = New System.Drawing.Point(59, 45)
        Me.txt_tname1.Name = "txt_tname1"
        Me.txt_tname1.Size = New System.Drawing.Size(88, 20)
        Me.txt_tname1.TabIndex = 3
        '
        'GB_GetInterval
        '
        Me.GB_GetInterval.Controls.Add(Me.GroupBox2)
        Me.GB_GetInterval.Controls.Add(Me.GB_GetMention1)
        Me.GB_GetInterval.Controls.Add(Me.GB_GetTempC0)
        Me.GB_GetInterval.Location = New System.Drawing.Point(333, 6)
        Me.GB_GetInterval.Name = "GB_GetInterval"
        Me.GB_GetInterval.Size = New System.Drawing.Size(167, 217)
        Me.GB_GetInterval.TabIndex = 27
        Me.GB_GetInterval.TabStop = False
        Me.GB_GetInterval.Text = "Interval Mention"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Chk_GetAt)
        Me.GroupBox2.Controls.Add(Me.Chk_GetIn1)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.lbl_interval2)
        Me.GroupBox2.Controls.Add(Me.numGetAtMin)
        Me.GroupBox2.Controls.Add(Me.numGetAtHour)
        Me.GroupBox2.Controls.Add(Me.txt_interval)
        Me.GroupBox2.Location = New System.Drawing.Point(15, 19)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(155, 87)
        Me.GroupBox2.TabIndex = 30
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Receive weather mention"
        '
        'Chk_GetAt
        '
        Me.Chk_GetAt.AutoSize = True
        Me.Chk_GetAt.Location = New System.Drawing.Point(7, 53)
        Me.Chk_GetAt.Name = "Chk_GetAt"
        Me.Chk_GetAt.Size = New System.Drawing.Size(36, 17)
        Me.Chk_GetAt.TabIndex = 30
        Me.Chk_GetAt.Text = "At"
        Me.Chk_GetAt.UseVisualStyleBackColor = True
        '
        'Chk_GetIn1
        '
        Me.Chk_GetIn1.AutoSize = True
        Me.Chk_GetIn1.Location = New System.Drawing.Point(6, 25)
        Me.Chk_GetIn1.Name = "Chk_GetIn1"
        Me.Chk_GetIn1.Size = New System.Drawing.Size(53, 17)
        Me.Chk_GetIn1.TabIndex = 6
        Me.Chk_GetIn1.Text = "Every"
        Me.Chk_GetIn1.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(94, 54)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(10, 13)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = ":"
        '
        'lbl_interval2
        '
        Me.lbl_interval2.AutoSize = True
        Me.lbl_interval2.Location = New System.Drawing.Point(121, 25)
        Me.lbl_interval2.Name = "lbl_interval2"
        Me.lbl_interval2.Size = New System.Drawing.Size(23, 13)
        Me.lbl_interval2.TabIndex = 8
        Me.lbl_interval2.Text = "min"
        '
        'numGetAtMin
        '
        Me.numGetAtMin.Location = New System.Drawing.Point(105, 52)
        Me.numGetAtMin.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.numGetAtMin.Name = "numGetAtMin"
        Me.numGetAtMin.Size = New System.Drawing.Size(38, 20)
        Me.numGetAtMin.TabIndex = 28
        Me.numGetAtMin.Value = New Decimal(New Integer() {30, 0, 0, 0})
        '
        'numGetAtHour
        '
        Me.numGetAtHour.Location = New System.Drawing.Point(57, 52)
        Me.numGetAtHour.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.numGetAtHour.Name = "numGetAtHour"
        Me.numGetAtHour.Size = New System.Drawing.Size(38, 20)
        Me.numGetAtHour.TabIndex = 27
        Me.numGetAtHour.Value = New Decimal(New Integer() {7, 0, 0, 0})
        '
        'txt_interval
        '
        Me.txt_interval.Location = New System.Drawing.Point(62, 23)
        Me.txt_interval.Name = "txt_interval"
        Me.txt_interval.Size = New System.Drawing.Size(54, 20)
        Me.txt_interval.TabIndex = 7
        '
        'GB_GetMention1
        '
        Me.GB_GetMention1.Controls.Add(Me.chk_GetHumd)
        Me.GB_GetMention1.Controls.Add(Me.chk_GetWind)
        Me.GB_GetMention1.Controls.Add(Me.Chk_GetStatus)
        Me.GB_GetMention1.Location = New System.Drawing.Point(12, 147)
        Me.GB_GetMention1.Name = "GB_GetMention1"
        Me.GB_GetMention1.Size = New System.Drawing.Size(147, 61)
        Me.GB_GetMention1.TabIndex = 14
        Me.GB_GetMention1.TabStop = False
        Me.GB_GetMention1.Text = "Get Mention on"
        '
        'chk_GetHumd
        '
        Me.chk_GetHumd.AutoSize = True
        Me.chk_GetHumd.Location = New System.Drawing.Point(12, 18)
        Me.chk_GetHumd.Name = "chk_GetHumd"
        Me.chk_GetHumd.Size = New System.Drawing.Size(66, 17)
        Me.chk_GetHumd.TabIndex = 6
        Me.chk_GetHumd.Text = "Humidity"
        Me.chk_GetHumd.UseVisualStyleBackColor = True
        '
        'chk_GetWind
        '
        Me.chk_GetWind.AutoSize = True
        Me.chk_GetWind.Location = New System.Drawing.Point(12, 39)
        Me.chk_GetWind.Name = "chk_GetWind"
        Me.chk_GetWind.Size = New System.Drawing.Size(51, 17)
        Me.chk_GetWind.TabIndex = 6
        Me.chk_GetWind.Text = "Wind"
        Me.chk_GetWind.UseVisualStyleBackColor = True
        '
        'Chk_GetStatus
        '
        Me.Chk_GetStatus.AutoSize = True
        Me.Chk_GetStatus.Location = New System.Drawing.Point(84, 39)
        Me.Chk_GetStatus.Name = "Chk_GetStatus"
        Me.Chk_GetStatus.Size = New System.Drawing.Size(56, 17)
        Me.Chk_GetStatus.TabIndex = 6
        Me.Chk_GetStatus.Text = "Status"
        Me.Chk_GetStatus.UseVisualStyleBackColor = True
        '
        'GB_GetTempC0
        '
        Me.GB_GetTempC0.Controls.Add(Me.RD_GetTempC)
        Me.GB_GetTempC0.Controls.Add(Me.RD_GetTempF)
        Me.GB_GetTempC0.Location = New System.Drawing.Point(10, 110)
        Me.GB_GetTempC0.Name = "GB_GetTempC0"
        Me.GB_GetTempC0.Size = New System.Drawing.Size(148, 33)
        Me.GB_GetTempC0.TabIndex = 13
        Me.GB_GetTempC0.TabStop = False
        Me.GB_GetTempC0.Text = "Show Temperature in"
        '
        'RD_GetTempC
        '
        Me.RD_GetTempC.AutoSize = True
        Me.RD_GetTempC.Checked = True
        Me.RD_GetTempC.Location = New System.Drawing.Point(7, 13)
        Me.RD_GetTempC.Name = "RD_GetTempC"
        Me.RD_GetTempC.Size = New System.Drawing.Size(59, 17)
        Me.RD_GetTempC.TabIndex = 9
        Me.RD_GetTempC.TabStop = True
        Me.RD_GetTempC.Text = "Celcius"
        Me.RD_GetTempC.UseVisualStyleBackColor = True
        '
        'RD_GetTempF
        '
        Me.RD_GetTempF.AutoSize = True
        Me.RD_GetTempF.Location = New System.Drawing.Point(67, 13)
        Me.RD_GetTempF.Name = "RD_GetTempF"
        Me.RD_GetTempF.Size = New System.Drawing.Size(75, 17)
        Me.RD_GetTempF.TabIndex = 9
        Me.RD_GetTempF.Text = "Fahrenheit"
        Me.RD_GetTempF.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lstPlace)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnTweetWeather)
        Me.GroupBox1.Controls.Add(Me.txtPlaceToAdd)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(307, 62)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Place"
        '
        'lstPlace
        '
        Me.lstPlace.FormattingEnabled = True
        Me.lstPlace.Location = New System.Drawing.Point(11, 12)
        Me.lstPlace.Name = "lstPlace"
        Me.lstPlace.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lstPlace.Size = New System.Drawing.Size(134, 43)
        Me.lstPlace.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(153, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Add Place"
        '
        'btnTweetWeather
        '
        Me.btnTweetWeather.Location = New System.Drawing.Point(166, 32)
        Me.btnTweetWeather.Name = "btnTweetWeather"
        Me.btnTweetWeather.Size = New System.Drawing.Size(132, 23)
        Me.btnTweetWeather.TabIndex = 12
        Me.btnTweetWeather.Text = "Tweet Current Weather"
        Me.btnTweetWeather.UseVisualStyleBackColor = True
        '
        'txtPlaceToAdd
        '
        Me.txtPlaceToAdd.Location = New System.Drawing.Point(215, 9)
        Me.txtPlaceToAdd.Name = "txtPlaceToAdd"
        Me.txtPlaceToAdd.Size = New System.Drawing.Size(83, 20)
        Me.txtPlaceToAdd.TabIndex = 19
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.lstTweet)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(509, 391)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Your Timeline"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.lstYourTweet)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(509, 391)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Your Tweets"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.lstMentions)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(509, 391)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Mentions To You"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'lstMentions
        '
        Me.lstMentions.FormattingEnabled = True
        Me.lstMentions.Location = New System.Drawing.Point(3, 3)
        Me.lstMentions.Name = "lstMentions"
        Me.lstMentions.Size = New System.Drawing.Size(503, 381)
        Me.lstMentions.TabIndex = 0
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.lstStatusBarLog)
        Me.TabPage5.Controls.Add(Me.lstLogOfTweetPosted)
        Me.TabPage5.Controls.Add(Me.btnVerify)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(509, 391)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Logs"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'lstStatusBarLog
        '
        Me.lstStatusBarLog.FormattingEnabled = True
        Me.lstStatusBarLog.HorizontalScrollbar = True
        Me.lstStatusBarLog.Location = New System.Drawing.Point(7, 36)
        Me.lstStatusBarLog.Name = "lstStatusBarLog"
        Me.lstStatusBarLog.Size = New System.Drawing.Size(232, 342)
        Me.lstStatusBarLog.TabIndex = 24
        '
        'lstLogOfTweetPosted
        '
        Me.lstLogOfTweetPosted.FormattingEnabled = True
        Me.lstLogOfTweetPosted.HorizontalScrollbar = True
        Me.lstLogOfTweetPosted.Location = New System.Drawing.Point(245, 36)
        Me.lstLogOfTweetPosted.Name = "lstLogOfTweetPosted"
        Me.lstLogOfTweetPosted.Size = New System.Drawing.Size(257, 342)
        Me.lstLogOfTweetPosted.TabIndex = 23
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.TextBox1)
        Me.TabPage6.Location = New System.Drawing.Point(4, 22)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Size = New System.Drawing.Size(509, 391)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "About"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(73, 77)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(344, 217)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = resources.GetString("TextBox1.Text")
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(190, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "minutes"
        '
        'numAutoTweet
        '
        Me.numAutoTweet.Location = New System.Drawing.Point(141, 29)
        Me.numAutoTweet.Maximum = New Decimal(New Integer() {240, 0, 0, 0})
        Me.numAutoTweet.Minimum = New Decimal(New Integer() {30, 0, 0, 0})
        Me.numAutoTweet.Name = "numAutoTweet"
        Me.numAutoTweet.Size = New System.Drawing.Size(47, 20)
        Me.numAutoTweet.TabIndex = 20
        Me.numAutoTweet.Value = New Decimal(New Integer() {120, 0, 0, 0})
        '
        'chkAutoTweet
        '
        Me.chkAutoTweet.AutoSize = True
        Me.chkAutoTweet.Checked = True
        Me.chkAutoTweet.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkAutoTweet.Location = New System.Drawing.Point(8, 29)
        Me.chkAutoTweet.Name = "chkAutoTweet"
        Me.chkAutoTweet.Size = New System.Drawing.Size(129, 17)
        Me.chkAutoTweet.TabIndex = 19
        Me.chkAutoTweet.Text = "Tweet Weather every"
        Me.chkAutoTweet.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.stsLabel})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 508)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(541, 22)
        Me.StatusStrip1.TabIndex = 13
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'stsLabel
        '
        Me.stsLabel.Name = "stsLabel"
        Me.stsLabel.Size = New System.Drawing.Size(39, 17)
        Me.stsLabel.Text = "Status"
        '
        'TimerPostNewTweet
        '
        Me.TimerPostNewTweet.Interval = 60000
        '
        'chkRefresh
        '
        Me.chkRefresh.AutoSize = True
        Me.chkRefresh.Checked = True
        Me.chkRefresh.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkRefresh.Location = New System.Drawing.Point(8, 6)
        Me.chkRefresh.Name = "chkRefresh"
        Me.chkRefresh.Size = New System.Drawing.Size(134, 17)
        Me.chkRefresh.TabIndex = 23
        Me.chkRefresh.Text = "Refresh Timeline every"
        Me.chkRefresh.UseVisualStyleBackColor = True
        '
        'TimerCheckIntervalEveryMinute
        '
        Me.TimerCheckIntervalEveryMinute.Enabled = True
        Me.TimerCheckIntervalEveryMinute.Interval = 60000
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.chkGW)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.numGW)
        Me.Panel1.Controls.Add(Me.chkRefresh)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.numAutoTweet)
        Me.Panel1.Controls.Add(Me.numRefresh)
        Me.Panel1.Controls.Add(Me.chkAutoTweet)
        Me.Panel1.Location = New System.Drawing.Point(13, 36)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(516, 52)
        Me.Panel1.TabIndex = 24
        '
        'chkGW
        '
        Me.chkGW.AutoSize = True
        Me.chkGW.Checked = True
        Me.chkGW.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkGW.Location = New System.Drawing.Point(240, 18)
        Me.chkGW.Name = "chkGW"
        Me.chkGW.Size = New System.Drawing.Size(176, 17)
        Me.chkGW.TabIndex = 26
        Me.chkGW.Text = "Retrieve Google Weather every"
        Me.chkGW.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(463, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "seconds"
        '
        'numGW
        '
        Me.numGW.Location = New System.Drawing.Point(416, 17)
        Me.numGW.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        Me.numGW.Minimum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.numGW.Name = "numGW"
        Me.numGW.Size = New System.Drawing.Size(48, 20)
        Me.numGW.TabIndex = 25
        Me.numGW.Value = New Decimal(New Integer() {30, 0, 0, 0})
        '
        'TimerGetGW
        '
        Me.TimerGetGW.Enabled = True
        Me.TimerGetGW.Interval = 1000
        '
        'Main_GUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(541, 530)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.tabTL)
        Me.Controls.Add(Me.lblYourTweet)
        Me.Controls.Add(Me.btnRefreshTweet)
        Me.Controls.Add(Me.txtText)
        Me.Controls.Add(Me.btnTweet)
        Me.Name = "Main_GUI"
        Me.Text = "Twitter Weather Reporter"
        CType(Me.numRefresh, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabTL.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.GB_Noti1.ResumeLayout(False)
        Me.GB_Wind1.ResumeLayout(False)
        Me.GB_Wind1.PerformLayout()
        Me.GB_humid1.ResumeLayout(False)
        Me.GB_humid1.PerformLayout()
        Me.GB_Temp1.ResumeLayout(False)
        Me.GB_Temp1.PerformLayout()
        Me.GB_ShowTemp1.ResumeLayout(False)
        Me.GB_ShowTemp1.PerformLayout()
        Me.GB_UserInfo.ResumeLayout(False)
        Me.GB_UserInfo.PerformLayout()
        Me.GB_GetInterval.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.numGetAtMin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numGetAtHour, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GB_GetMention1.ResumeLayout(False)
        Me.GB_GetMention1.PerformLayout()
        Me.GB_GetTempC0.ResumeLayout(False)
        Me.GB_GetTempC0.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage6.ResumeLayout(False)
        Me.TabPage6.PerformLayout()
        CType(Me.numAutoTweet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.numGW, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnTweet As System.Windows.Forms.Button
    Friend WithEvents txtText As System.Windows.Forms.TextBox
    Friend WithEvents btnVerify As System.Windows.Forms.Button
    Friend WithEvents lstTweet As System.Windows.Forms.ListBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TimerCheckNewTweet As System.Windows.Forms.Timer
    Friend WithEvents numRefresh As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnRefreshTweet As System.Windows.Forms.Button
    Friend WithEvents lstYourTweet As System.Windows.Forms.ListBox
    Friend WithEvents lblYourTweet As System.Windows.Forms.Label
    Friend WithEvents tabTL As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents lstMentions As System.Windows.Forms.ListBox
    Friend WithEvents btnTweetWeather As System.Windows.Forms.Button
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents stsLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lstPlace As System.Windows.Forms.ListBox
    Friend WithEvents numAutoTweet As System.Windows.Forms.NumericUpDown
    Friend WithEvents chkAutoTweet As System.Windows.Forms.CheckBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TimerPostNewTweet As System.Windows.Forms.Timer
    Friend WithEvents chkRefresh As System.Windows.Forms.CheckBox
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents lstStatusBarLog As System.Windows.Forms.ListBox
    Friend WithEvents lstLogOfTweetPosted As System.Windows.Forms.ListBox
    Friend WithEvents txtPlaceToAdd As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GB_GetInterval As System.Windows.Forms.GroupBox
    Friend WithEvents Chk_GetIn1 As System.Windows.Forms.CheckBox
    Friend WithEvents txt_interval As System.Windows.Forms.TextBox
    Friend WithEvents GB_GetMention1 As System.Windows.Forms.GroupBox
    Friend WithEvents chk_GetHumd As System.Windows.Forms.CheckBox
    Friend WithEvents chk_GetWind As System.Windows.Forms.CheckBox
    Friend WithEvents Chk_GetStatus As System.Windows.Forms.CheckBox
    Friend WithEvents GB_GetTempC0 As System.Windows.Forms.GroupBox
    Friend WithEvents RD_GetTempC As System.Windows.Forms.RadioButton
    Friend WithEvents RD_GetTempF As System.Windows.Forms.RadioButton
    Friend WithEvents lbl_interval2 As System.Windows.Forms.Label
    Friend WithEvents GB_UserInfo As System.Windows.Forms.GroupBox
    Friend WithEvents LV_UserList As System.Windows.Forms.ListView
    Friend WithEvents txt_ID1 As System.Windows.Forms.TextBox
    Friend WithEvents lbl_twitname1 As System.Windows.Forms.Label
    Friend WithEvents lbl_ID1 As System.Windows.Forms.Label
    Friend WithEvents btn_New As System.Windows.Forms.Button
    Friend WithEvents txt_tname1 As System.Windows.Forms.TextBox
    Friend WithEvents TimerCheckIntervalEveryMinute As System.Windows.Forms.Timer
    Friend WithEvents GB_Noti1 As System.Windows.Forms.GroupBox
    Friend WithEvents GB_Wind1 As System.Windows.Forms.GroupBox
    Friend WithEvents Chk_GetWindOver1 As System.Windows.Forms.CheckBox
    Friend WithEvents Lbl_Kmh As System.Windows.Forms.Label
    Friend WithEvents Txt_WindOver1 As System.Windows.Forms.TextBox
    Friend WithEvents Btn_SaveNoti1 As System.Windows.Forms.Button
    Friend WithEvents GB_humid1 As System.Windows.Forms.GroupBox
    Friend WithEvents Lbl_Pct12 As System.Windows.Forms.Label
    Friend WithEvents Lbl_Pct11 As System.Windows.Forms.Label
    Friend WithEvents Chk_GetHumidUnder1 As System.Windows.Forms.CheckBox
    Friend WithEvents Chk_GetHumidOver1 As System.Windows.Forms.CheckBox
    Friend WithEvents Txt_HumidUnder1 As System.Windows.Forms.TextBox
    Friend WithEvents Txt_HumidOver1 As System.Windows.Forms.TextBox
    Friend WithEvents GB_Temp1 As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_CF12 As System.Windows.Forms.Label
    Friend WithEvents lbl_CF11 As System.Windows.Forms.Label
    Friend WithEvents Txt_TempUnder1 As System.Windows.Forms.TextBox
    Friend WithEvents Txt_TempOver1 As System.Windows.Forms.TextBox
    Friend WithEvents Chk_GetTempUnder1 As System.Windows.Forms.CheckBox
    Friend WithEvents Chk_GetTempOver1 As System.Windows.Forms.CheckBox
    Friend WithEvents GB_ShowTemp1 As System.Windows.Forms.GroupBox
    Friend WithEvents RD_GetTempC1 As System.Windows.Forms.RadioButton
    Friend WithEvents RD_GetTempF1 As System.Windows.Forms.RadioButton
    Friend WithEvents Btn_Clear As System.Windows.Forms.Button
    Friend WithEvents Btn_Delete As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents chkGW As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents numGW As System.Windows.Forms.NumericUpDown
    Friend WithEvents TimerGetGW As System.Windows.Forms.Timer
    Friend WithEvents lblPlace As System.Windows.Forms.Label
    Friend WithEvents txt_place1 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents numGetAtMin As System.Windows.Forms.NumericUpDown
    Friend WithEvents numGetAtHour As System.Windows.Forms.NumericUpDown
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Chk_GetAt As System.Windows.Forms.CheckBox
    Friend WithEvents TabPage6 As System.Windows.Forms.TabPage
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox

End Class
