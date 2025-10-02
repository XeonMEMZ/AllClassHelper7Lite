Imports System.ComponentModel
Imports System.Drawing.Text
Imports System.IO
Imports System.Management
Imports System.Reflection.Emit
Imports System.Security.Cryptography
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock

Public Class Form2
    Private WithEvents watcher As ManagementEventWatcher
    Dim gspeed As Double
    Dim speed As Double
    Dim sc As Boolean
    Dim cq As Boolean
    Dim lin1 As String
    Dim tim1 As String
    Dim oc1 As String
    Dim lin2 As String
    Dim tim2 As String
    Dim oc2 As String
    Dim lin3 As String
    Dim tim3 As String
    Dim oc3 As String
    Dim lin4 As String
    Dim tim4 As String
    Dim oc4 As String
    Dim sklin As String
    Dim skoc As String
    Dim xklin As String
    Dim xkoc As String
    Dim autostd As String
    Dim autostdt As String
    Dim tlino As String
    Dim tlint As String
    Dim ttimjy As String
    Dim ttimjj As String
    Dim tllq As String
    Dim tmgr As String
    Dim zdrw As Boolean
    Dim sjkz As Boolean
    Dim srmm As Boolean

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Alt Or Keys.F4) Then
            Return True
        Else
            Return MyBase.ProcessCmdKey(msg, keyData)
        End If
    End Function

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles Me.Load
        mmzq = False
        srmm = False
        gspeed = 1
        Me.Width = 113
        My.Computer.FileSystem.WriteAllText("data\atlink1.txt", Trim(My.Computer.FileSystem.ReadAllText("data\atlink1.txt").Replace(vbCrLf, "")), False)
        My.Computer.FileSystem.WriteAllText("data\attime1.txt", Trim(My.Computer.FileSystem.ReadAllText("data\attime1.txt").Replace(vbCrLf, "")), False)
        My.Computer.FileSystem.WriteAllText("data\atoc1.txt", Trim(My.Computer.FileSystem.ReadAllText("data\atoc1.txt").Replace(vbCrLf, "")), False)
        My.Computer.FileSystem.WriteAllText("data\atlink2.txt", Trim(My.Computer.FileSystem.ReadAllText("data\atlink2.txt").Replace(vbCrLf, "")), False)
        My.Computer.FileSystem.WriteAllText("data\attime2.txt", Trim(My.Computer.FileSystem.ReadAllText("data\attime2.txt").Replace(vbCrLf, "")), False)
        My.Computer.FileSystem.WriteAllText("data\atoc2.txt", Trim(My.Computer.FileSystem.ReadAllText("data\atoc2.txt").Replace(vbCrLf, "")), False)
        My.Computer.FileSystem.WriteAllText("data\atlink3.txt", Trim(My.Computer.FileSystem.ReadAllText("data\atlink3.txt").Replace(vbCrLf, "")), False)
        My.Computer.FileSystem.WriteAllText("data\attime3.txt", Trim(My.Computer.FileSystem.ReadAllText("data\attime3.txt").Replace(vbCrLf, "")), False)
        My.Computer.FileSystem.WriteAllText("data\atoc3.txt", Trim(My.Computer.FileSystem.ReadAllText("data\atoc3.txt").Replace(vbCrLf, "")), False)
        My.Computer.FileSystem.WriteAllText("data\atlink4.txt", Trim(My.Computer.FileSystem.ReadAllText("data\atlink4.txt").Replace(vbCrLf, "")), False)
        My.Computer.FileSystem.WriteAllText("data\attime4.txt", Trim(My.Computer.FileSystem.ReadAllText("data\attime4.txt").Replace(vbCrLf, "")), False)
        My.Computer.FileSystem.WriteAllText("data\atoc4.txt", Trim(My.Computer.FileSystem.ReadAllText("data\atoc4.txt").Replace(vbCrLf, "")), False)
        My.Computer.FileSystem.WriteAllText("data\skatlink.txt", Trim(My.Computer.FileSystem.ReadAllText("data\skatlink.txt").Replace(vbCrLf, "")), False)
        My.Computer.FileSystem.WriteAllText("data\skatoc.txt", Trim(My.Computer.FileSystem.ReadAllText("data\skatoc.txt").Replace(vbCrLf, "")), False)
        My.Computer.FileSystem.WriteAllText("data\xkatlink.txt", Trim(My.Computer.FileSystem.ReadAllText("data\xkatlink.txt").Replace(vbCrLf, "")), False)
        My.Computer.FileSystem.WriteAllText("data\xkatoc.txt", Trim(My.Computer.FileSystem.ReadAllText("data\xkatoc.txt").Replace(vbCrLf, "")), False)
        My.Computer.FileSystem.WriteAllText("data\autostd.txt", Trim(My.Computer.FileSystem.ReadAllText("data\autostd.txt").Replace(vbCrLf, "")), False)
        My.Computer.FileSystem.WriteAllText("data\autostdt.txt", Trim(My.Computer.FileSystem.ReadAllText("data\autostdt.txt").Replace(vbCrLf, "")), False)
        My.Computer.FileSystem.WriteAllText("data\tctask1.txt", Trim(My.Computer.FileSystem.ReadAllText("data\tctask1.txt").Replace(vbCrLf, "")), False)
        My.Computer.FileSystem.WriteAllText("data\tctask2.txt", Trim(My.Computer.FileSystem.ReadAllText("data\tctask2.txt").Replace(vbCrLf, "")), False)
        My.Computer.FileSystem.WriteAllText("data\tctimejy.txt", Trim(My.Computer.FileSystem.ReadAllText("data\tctimejy.txt").Replace(vbCrLf, "")), False)
        My.Computer.FileSystem.WriteAllText("data\tctimejj.txt", Trim(My.Computer.FileSystem.ReadAllText("data\tctimejj.txt").Replace(vbCrLf, "")), False)
        My.Computer.FileSystem.WriteAllText("data\tcllq.txt", Trim(My.Computer.FileSystem.ReadAllText("data\tcllq.txt").Replace(vbCrLf, "")), False)
        My.Computer.FileSystem.WriteAllText("data\tcmgr.txt", Trim(My.Computer.FileSystem.ReadAllText("data\tcmgr.txt").Replace(vbCrLf, "")), False)
        Timer8.Enabled = False
        zdh = True
        Me.Location = New Point(My.Computer.Screen.Bounds.Size.Width - Me.Width, 0)
        speed = 0
        allkbh = allkbh + Me.Height
        If Weekday(Now, FirstDayOfWeek.Monday) = 1 Then
            Label1.Text = "星期一"
        ElseIf Weekday(Now, FirstDayOfWeek.Monday) = 2 Then
            Label1.Text = "星期二"
        ElseIf Weekday(Now, FirstDayOfWeek.Monday) = 3 Then
            Label1.Text = "星期三"
        ElseIf Weekday(Now, FirstDayOfWeek.Monday) = 4 Then
            Label1.Text = "星期四"
        ElseIf Weekday(Now, FirstDayOfWeek.Monday) = 5 Then
            Label1.Text = "星期五"
        ElseIf Weekday(Now, FirstDayOfWeek.Monday) = 6 Then
            Label1.Text = "星期六"
        ElseIf Weekday(Now, FirstDayOfWeek.Monday) = 7 Then
            Label1.Text = "星期日"
        End If
        Dim query As New WqlEventQuery("SELECT * FROM Win32_VolumeChangeEvent WHERE EventType = 2")
        watcher = New ManagementEventWatcher(query)
        watcher.Start()
        lin1 = My.Computer.FileSystem.ReadAllText("data\atlink1.txt")
        tim1 = My.Computer.FileSystem.ReadAllText("data\attime1.txt")
        oc1 = My.Computer.FileSystem.ReadAllText("data\atoc1.txt")
        lin2 = My.Computer.FileSystem.ReadAllText("data\atlink2.txt")
        tim2 = My.Computer.FileSystem.ReadAllText("data\attime2.txt")
        oc2 = My.Computer.FileSystem.ReadAllText("data\atoc2.txt")
        lin3 = My.Computer.FileSystem.ReadAllText("data\atlink3.txt")
        tim3 = My.Computer.FileSystem.ReadAllText("data\attime3.txt")
        oc3 = My.Computer.FileSystem.ReadAllText("data\atoc3.txt")
        lin4 = My.Computer.FileSystem.ReadAllText("data\atlink4.txt")
        tim4 = My.Computer.FileSystem.ReadAllText("data\attime4.txt")
        oc4 = My.Computer.FileSystem.ReadAllText("data\atoc4.txt")
        If (lin1 <> "" And tim1 <> "") Or (lin2 <> "" And tim2 <> "") Or (lin3 <> "" And tim3 <> "") Or (lin4 <> "" And tim4 <> "") Then
            zdrw = True
        Else
            zdrw = False
        End If
        NotifyIcon1.Icon = Form1.Icon
        NotifyIcon1.Text = "全能班辅"
        NotifyIcon1.ContextMenuStrip = ContextMenuStrip1
        NotifyIcon1.Visible = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If speed + 0.05 <= 1 Then
            speed = speed + 0.05
            Me.Opacity = speed
        Else
            speed = 1
            Me.Opacity = 1
            Form3.Show()
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If speed > 0 Then
            If Me.Left - speed >= My.Computer.Screen.Bounds.Size.Width - 165 + (52 / 3) Then
                Me.Left = Me.Left - speed
                Me.Width = Me.Width + speed
                speed = speed + 0.116
            Else
                Me.Left = Me.Left - speed
                Me.Width = Me.Width + speed
                speed = speed - 0.25
            End If
        Else
            speed = 1
            sc = True
            Me.Left = My.Computer.Screen.Bounds.Size.Width - 113 - 52
            Me.Width = 165
            Timer3.Enabled = True
            Timer2.Enabled = False
        End If
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Timer4.Enabled = True
        Timer3.Enabled = False
        sc = False
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        If speed > 0 Then
            If Me.Left - speed <= My.Computer.Screen.Bounds.Size.Width - 165 + (52 / 2.5) Then
                Me.Left = Me.Left + speed
                Me.Width = Me.Width - speed
                speed = speed + 0.12
            Else
                Me.Left = Me.Left + speed
                Me.Width = Me.Width - speed
                speed = speed - 0.135
            End If
        Else
            speed = 1
            Me.Left = My.Computer.Screen.Bounds.Size.Width - 113
            Me.Width = 113
            Timer4.Enabled = False
        End If
    End Sub

    Private Sub Label1_DoubleClick(sender As Object, e As EventArgs) Handles Label1.DoubleClick
        If Timer2.Enabled = False And Timer3.Enabled = False And Timer4.Enabled = False Then
            Timer2.Enabled = True
        End If
    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        If Weekday(Now, FirstDayOfWeek.Monday) = 1 Then
            Label1.Text = "星期一"
        ElseIf Weekday(Now, FirstDayOfWeek.Monday) = 2 Then
            Label1.Text = "星期二"
        ElseIf Weekday(Now, FirstDayOfWeek.Monday) = 3 Then
            Label1.Text = "星期三"
        ElseIf Weekday(Now, FirstDayOfWeek.Monday) = 4 Then
            Label1.Text = "星期四"
        ElseIf Weekday(Now, FirstDayOfWeek.Monday) = 5 Then
            Label1.Text = "星期五"
        ElseIf Weekday(Now, FirstDayOfWeek.Monday) = 6 Then
            Label1.Text = "星期六"
        ElseIf Weekday(Now, FirstDayOfWeek.Monday) = 7 Then
            Label1.Text = "星期日"
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If sc = True Then
            Form20.Show()
        End If
    End Sub

    Private Sub Watcher_EventArrived(sender As Object, e As EventArrivedEventArgs) Handles watcher.EventArrived
        Dim driveName As String = e.NewEvent.Properties("DriveName").Value.ToString()
        Me.Invoke(Sub()
                      Try
                          If Directory.Exists(driveName) Then
                              Dim driveInfo As New DriveInfo(driveName)
                              If driveInfo.DriveType = DriveType.Removable Then
                                  Process.Start(driveName)
                                  Form29.Show()
                              End If
                          End If
                      Catch ex As Exception
                      End Try
                  End Sub)
    End Sub

    Private Sub Form2_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        NotifyIcon1.Visible = False
        If watcher IsNot Nothing Then
            watcher.Stop()
            watcher.Dispose()
        End If
    End Sub

    Private Sub Timer6_Tick(sender As Object, e As EventArgs) Handles Timer6.Tick
        If xday <> CStr(Now.Day) Then
            If dtrs = "1" Then
                cq = False
            ElseIf dtrs = "0" Then
                cq = True
            End If
            Form19.Close()
            Form20.Close()
            Form21.Close()
            Form25.Close()
            Form26.Close()
            Form27.Close()
            Form28.Close()
            Form29.Close()
            Form30.Close()
            Form31.Close()
            Form32.Close()
            Form33.Close()
            Form34.Close()
            Form35.Close()
            Form36.Close()
            Timer9.Enabled = True
        End If
        If xwidth <> My.Computer.Screen.Bounds.Size.Width Or xheight <> My.Computer.Screen.Bounds.Size.Height Then
            Me.Location = New Point(My.Computer.Screen.Bounds.Size.Width - Me.Width, 0)
            Form3.Location = New Point(My.Computer.Screen.Bounds.Size.Width - Me.Width, Me.Height)
            Form4.Location = New Point(My.Computer.Screen.Bounds.Size.Width - Me.Width, Me.Height * 2)
            Form5.Location = New Point(My.Computer.Screen.Bounds.Size.Width - Me.Width, Me.Height * 3)
            Form6.Location = New Point(My.Computer.Screen.Bounds.Size.Width - Me.Width, Me.Height * 4)
            Form7.Location = New Point(My.Computer.Screen.Bounds.Size.Width - Me.Width, Me.Height * 5)
            Form8.Location = New Point(My.Computer.Screen.Bounds.Size.Width - Me.Width, Me.Height * 6)
            Form9.Location = New Point(My.Computer.Screen.Bounds.Size.Width - Me.Width, Me.Height * 7)
            Form10.Location = New Point(My.Computer.Screen.Bounds.Size.Width - Me.Width, Me.Height * 8)
            Form11.Location = New Point(My.Computer.Screen.Bounds.Size.Width - Me.Width, Me.Height * 9)
            Form12.Location = New Point(My.Computer.Screen.Bounds.Size.Width - Me.Width, Me.Height * 10)
            Form13.Location = New Point(My.Computer.Screen.Bounds.Size.Width - Me.Width, Me.Height * 11)
            Form14.Location = New Point(My.Computer.Screen.Bounds.Size.Width - Me.Width, Me.Height * 12)
            Form15.Location = New Point(My.Computer.Screen.Bounds.Size.Width - Me.Width, Me.Height * 13)
            Form16.Location = New Point(My.Computer.Screen.Bounds.Size.Width - Me.Width, Me.Height * 14)
            Form17.Location = New Point(My.Computer.Screen.Bounds.Size.Width - Me.Width, Me.Height * 15)
            Form18.Location = New Point(My.Computer.Screen.Bounds.Size.Width - Me.Width, allkbh - 41)
            Form22.Location = New Point(My.Computer.Screen.Bounds.Size.Width - 113 - Form22.Width, 0)
            Form23.Location = New Point(My.Computer.Screen.Bounds.Size.Width - 113 - 8 - Form23.Width, 0)
            Form24.Location = New Point(My.Computer.Screen.Bounds.Size.Width - 113 - 52 - Form24.Width, 0)
            xwidth = My.Computer.Screen.Bounds.Size.Width
            xheight = My.Computer.Screen.Bounds.Size.Height
        End If
        Try
            If zdh = True Then
                lin1 = My.Computer.FileSystem.ReadAllText("data\atlink1.txt")
                tim1 = My.Computer.FileSystem.ReadAllText("data\attime1.txt")
                lin2 = My.Computer.FileSystem.ReadAllText("data\atlink2.txt")
                tim2 = My.Computer.FileSystem.ReadAllText("data\attime2.txt")
                lin3 = My.Computer.FileSystem.ReadAllText("data\atlink3.txt")
                tim3 = My.Computer.FileSystem.ReadAllText("data\attime3.txt")
                lin4 = My.Computer.FileSystem.ReadAllText("data\atlink4.txt")
                tim4 = My.Computer.FileSystem.ReadAllText("data\attime4.txt")
                If (lin1 <> "" And tim1 <> "") Or (lin2 <> "" And tim2 <> "") Or (lin3 <> "" And tim3 <> "") Or (lin4 <> "" And tim4 <> "") Then
                    zdrw = True
                Else
                    zdrw = False
                End If
                If zdrw = True Then
                    lin1 = My.Computer.FileSystem.ReadAllText("data\atlink1.txt")
                    tim1 = My.Computer.FileSystem.ReadAllText("data\attime1.txt")
                    oc1 = My.Computer.FileSystem.ReadAllText("data\atoc1.txt")
                    If tim1 <> "" Then
                        If CDate(tim1) = TimeOfDay Then
                            If lin1 <> "ksms" And lin1 <> "wsms" Then
                                If oc1 = "1" Then
                                    Call Shell("cmd /c start " & lin1)
                                Else
                                    If lin1.Contains("\") Or lin1.Contains("/") Then
                                        Call Shell("cmd /c taskkill /f /im " & System.IO.Path.GetFileName(lin1))
                                    Else
                                        Call Shell("cmd /c taskkill /f /im " & lin1)
                                    End If
                                End If
                                fdctext = "自动任务1已执行"
                                fdctitle = "自动任务"
                                fdctime = 3
                                Form33.Show()
                            ElseIf lin1 = "ksms" Then
                                If oc1 = "1" Then
                                    qpms = 0
                                    Form21.Show()
                                Else
                                    If Form21.Timer2.Enabled = False Then
                                        Form21.Timer2.Enabled = True
                                    End If
                                End If
                            ElseIf lin1 = "wsms" Then
                                If oc1 = "1" Then
                                    qpms = 1
                                    Form21.Show()
                                Else
                                    If Form21.Timer2.Enabled = False Then
                                        Form21.Timer2.Enabled = True
                                    End If
                                End If
                            End If
                        End If
                    End If
                    lin2 = My.Computer.FileSystem.ReadAllText("data\atlink2.txt")
                    tim2 = My.Computer.FileSystem.ReadAllText("data\attime2.txt")
                    oc2 = My.Computer.FileSystem.ReadAllText("data\atoc2.txt")
                    If tim2 <> "" Then
                        If CDate(tim2) = TimeOfDay Then
                            If lin2 <> "ksms" And lin2 <> "wsms" Then
                                If oc2 = "1" Then
                                    Call Shell("cmd /c start " & lin2)
                                Else
                                    If lin2.Contains("\") Or lin2.Contains("/") Then
                                        Call Shell("cmd /c taskkill /f /im " & System.IO.Path.GetFileName(lin2))
                                    Else
                                        Call Shell("cmd /c taskkill /f /im " & lin2)
                                    End If
                                End If
                                fdctext = "自动任务2已执行"
                                fdctitle = "自动任务"
                                fdctime = 3
                                Form33.Show()
                            ElseIf lin2 = "ksms" Then
                                If oc2 = "1" Then
                                    qpms = 0
                                    Form21.Show()
                                Else
                                    If Form21.Timer2.Enabled = False Then
                                        Form21.Timer2.Enabled = True
                                    End If
                                End If
                            ElseIf lin2 = "wsms" Then
                                If oc2 = "1" Then
                                    qpms = 1
                                    Form21.Show()
                                Else
                                    If Form21.Timer2.Enabled = False Then
                                        Form21.Timer2.Enabled = True
                                    End If
                                End If
                            End If
                        End If
                    End If
                    lin3 = My.Computer.FileSystem.ReadAllText("data\atlink3.txt")
                    tim3 = My.Computer.FileSystem.ReadAllText("data\attime3.txt")
                    oc3 = My.Computer.FileSystem.ReadAllText("data\atoc3.txt")
                    If tim3 <> "" Then
                        If CDate(tim3) = TimeOfDay Then
                            If lin3 <> "ksms" And lin3 <> "wsms" Then
                                If oc3 = "1" Then
                                    Call Shell("cmd /c start " & lin3)
                                Else
                                    If lin3.Contains("\") Or lin3.Contains("/") Then
                                        Call Shell("cmd /c taskkill /f /im " & System.IO.Path.GetFileName(lin3))
                                    Else
                                        Call Shell("cmd /c taskkill /f /im " & lin3)
                                    End If
                                End If
                                fdctext = "自动任务3已执行"
                                fdctitle = "自动任务"
                                fdctime = 3
                                Form33.Show()
                            ElseIf lin3 = "ksms" Then
                                If oc3 = "1" Then
                                    qpms = 0
                                    Form21.Show()
                                Else
                                    If Form21.Timer2.Enabled = False Then
                                        Form21.Timer2.Enabled = True
                                    End If
                                End If
                            ElseIf lin3 = "wsms" Then
                                If oc3 = "1" Then
                                    qpms = 1
                                    Form21.Show()
                                Else
                                    If Form21.Timer2.Enabled = False Then
                                        Form21.Timer2.Enabled = True
                                    End If
                                End If
                            End If
                        End If
                    End If
                    lin4 = My.Computer.FileSystem.ReadAllText("data\atlink4.txt")
                    tim4 = My.Computer.FileSystem.ReadAllText("data\attime4.txt")
                    oc4 = My.Computer.FileSystem.ReadAllText("data\atoc4.txt")
                    If tim4 <> "" Then
                        If CDate(tim4) = TimeOfDay Then
                            If lin4 <> "ksms" And lin4 <> "wsms" Then
                                If oc4 = "1" Then
                                    Call Shell("cmd /c start " & lin4)
                                Else
                                    If lin4.Contains("\") Or lin4.Contains("/") Then
                                        Call Shell("cmd /c taskkill /f /im " & System.IO.Path.GetFileName(lin4))
                                    Else
                                        Call Shell("cmd /c taskkill /f /im " & lin4)
                                    End If
                                End If
                                fdctext = "自动任务4已执行"
                                fdctitle = "自动任务"
                                fdctime = 3
                                Form33.Show()
                            ElseIf lin4 = "ksms" Then
                                If oc4 = "1" Then
                                    qpms = 0
                                    Form21.Show()
                                Else
                                    If Form21.Timer2.Enabled = False Then
                                        Form21.Timer2.Enabled = True
                                    End If
                                End If
                            ElseIf lin4 = "wsms" Then
                                If oc4 = "1" Then
                                    qpms = 1
                                    Form21.Show()
                                Else
                                    If Form21.Timer2.Enabled = False Then
                                        Form21.Timer2.Enabled = True
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
                sklin = My.Computer.FileSystem.ReadAllText("data\skatlink.txt")
                skoc = My.Computer.FileSystem.ReadAllText("data\skatoc.txt")
                If Not sklin = "" Then
                    If fricls = 0 Then
                        If CDate(zxtime("zm1s")) = TimeOfDay Or CDate(zxtime("zm2s")) = TimeOfDay Or CDate(zxtime("zm3s")) = TimeOfDay Or CDate(zxtime("zm4s")) = TimeOfDay Or CDate(zxtime("zm5s")) = TimeOfDay Or CDate(zxtime("zm6s")) = TimeOfDay Or CDate(zxtime("zm7s")) = TimeOfDay Or CDate(zxtime("zm8s")) = TimeOfDay Or CDate(zxtime("zm9s")) = TimeOfDay Or CDate(zxtime("zm10s")) = TimeOfDay Or CDate(zxtime("zm11s")) = TimeOfDay Or CDate(zxtime("zm12s")) = TimeOfDay Or CDate(zxtime("zm13s")) = TimeOfDay Or CDate(zxtime("zm14s")) = TimeOfDay Or CDate(zxtime("zm15s")) = TimeOfDay Then
                            If sklin <> "ksms" And sklin <> "wsms" Then
                                If skoc = "1" Then
                                    Call Shell("cmd /c start " & sklin)
                                Else
                                    If sklin.Contains("\") Or sklin.Contains("/") Then
                                        Call Shell("cmd /c taskkill /f /im " & System.IO.Path.GetFileName(sklin))
                                    Else
                                        Call Shell("cmd /c taskkill /f /im " & sklin)
                                    End If
                                End If
                                fdctext = "上课自动任务已执行"
                                fdctitle = "自动任务"
                                fdctime = 3
                                Form33.Show()
                            ElseIf sklin = "ksms" Then
                                If skoc = "1" Then
                                    qpms = 0
                                    Form21.Show()
                                Else
                                    If Form21.Timer2.Enabled = False Then
                                        Form21.Timer2.Enabled = True
                                    End If
                                End If
                            ElseIf sklin = "wsms" Then
                                If skoc = "1" Then
                                    qpms = 1
                                    Form21.Show()
                                Else
                                    If Form21.Timer2.Enabled = False Then
                                        Form21.Timer2.Enabled = True
                                    End If
                                End If
                            End If
                        End If
                    Else
                        If CDate(zxtime("zt1s")) = TimeOfDay Or CDate(zxtime("zt2s")) = TimeOfDay Or CDate(zxtime("zt3s")) = TimeOfDay Or CDate(zxtime("zt4s")) = TimeOfDay Or CDate(zxtime("zt5s")) = TimeOfDay Or CDate(zxtime("zt6s")) = TimeOfDay Or CDate(zxtime("zt7s")) = TimeOfDay Or CDate(zxtime("zt8s")) = TimeOfDay Or CDate(zxtime("zt9s")) = TimeOfDay Or CDate(zxtime("zt10s")) = TimeOfDay Or CDate(zxtime("zt11s")) = TimeOfDay Or CDate(zxtime("zt12s")) = TimeOfDay Or CDate(zxtime("zt13s")) = TimeOfDay Or CDate(zxtime("zt14s")) = TimeOfDay Or CDate(zxtime("zt15s")) = TimeOfDay Then
                            If sklin <> "ksms" And sklin <> "wsms" Then
                                If skoc = "1" Then
                                    Call Shell("cmd /c start " & sklin)
                                Else
                                    If sklin.Contains("\") Or sklin.Contains("/") Then
                                        Call Shell("cmd /c taskkill /f /im " & System.IO.Path.GetFileName(sklin))
                                    Else
                                        Call Shell("cmd /c taskkill /f /im " & sklin)
                                    End If
                                End If
                                fdctext = "上课自动任务已执行"
                                fdctitle = "自动任务"
                                fdctime = 3
                                Form33.Show()
                            ElseIf sklin = "ksms" Then
                                If skoc = "1" Then
                                    qpms = 0
                                    Form21.Show()
                                Else
                                    If Form21.Timer2.Enabled = False Then
                                        Form21.Timer2.Enabled = True
                                    End If
                                End If
                            ElseIf sklin = "wsms" Then
                                If skoc = "1" Then
                                    qpms = 1
                                    Form21.Show()
                                Else
                                    If Form21.Timer2.Enabled = False Then
                                        Form21.Timer2.Enabled = True
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
                xklin = My.Computer.FileSystem.ReadAllText("data\xkatlink.txt")
                xkoc = My.Computer.FileSystem.ReadAllText("data\xkatoc.txt")
                If Not xklin = "" Then
                    If fricls = 0 Then
                        If CDate(zxtime("zm1x")) = TimeOfDay Or CDate(zxtime("zm2x")) = TimeOfDay Or CDate(zxtime("zm3x")) = TimeOfDay Or CDate(zxtime("zm4x")) = TimeOfDay Or CDate(zxtime("zm5x")) = TimeOfDay Or CDate(zxtime("zm6x")) = TimeOfDay Or CDate(zxtime("zm7x")) = TimeOfDay Or CDate(zxtime("zm8x")) = TimeOfDay Or CDate(zxtime("zm9x")) = TimeOfDay Or CDate(zxtime("zm10x")) = TimeOfDay Or CDate(zxtime("zm11x")) = TimeOfDay Or CDate(zxtime("zm12x")) = TimeOfDay Or CDate(zxtime("zm13x")) = TimeOfDay Or CDate(zxtime("zm14x")) = TimeOfDay Or CDate(zxtime("zm15x")) = TimeOfDay Then
                            If xklin <> "ksms" And xklin <> "wsms" Then
                                If xkoc = "1" Then
                                    Call Shell("cmd /c start " & xklin)
                                Else
                                    If xklin.Contains("\") Or xklin.Contains("/") Then
                                        Call Shell("cmd /c taskkill /f /im " & System.IO.Path.GetFileName(xklin))
                                    Else
                                        Call Shell("cmd /c taskkill /f /im " & xklin)
                                    End If
                                End If
                                fdctext = "下课自动任务已执行"
                                fdctitle = "自动任务"
                                fdctime = 3
                                Form33.Show()
                            ElseIf xklin = "ksms" Then
                                If xkoc = "1" Then
                                    qpms = 0
                                    Form21.Show()
                                Else
                                    If Form21.Timer2.Enabled = False Then
                                        Form21.Timer2.Enabled = True
                                    End If
                                End If
                            ElseIf xklin = "wsms" Then
                                If xkoc = "1" Then
                                    qpms = 1
                                    Form21.Show()
                                Else
                                    If Form21.Timer2.Enabled = False Then
                                        Form21.Timer2.Enabled = True
                                    End If
                                End If
                            End If
                        End If
                    Else
                        If CDate(zxtime("zt1x")) = TimeOfDay Or CDate(zxtime("zt2x")) = TimeOfDay Or CDate(zxtime("zt3x")) = TimeOfDay Or CDate(zxtime("zt4x")) = TimeOfDay Or CDate(zxtime("zt5x")) = TimeOfDay Or CDate(zxtime("zt6x")) = TimeOfDay Or CDate(zxtime("zt7x")) = TimeOfDay Or CDate(zxtime("zt8x")) = TimeOfDay Or CDate(zxtime("zt9x")) = TimeOfDay Or CDate(zxtime("zt10x")) = TimeOfDay Or CDate(zxtime("zt11x")) = TimeOfDay Or CDate(zxtime("zt12x")) = TimeOfDay Or CDate(zxtime("zt13x")) = TimeOfDay Or CDate(zxtime("zt14x")) = TimeOfDay Or CDate(zxtime("zt15x")) = TimeOfDay Then
                            If xklin <> "ksms" And xklin <> "wsms" Then
                                If xkoc = "1" Then
                                    Call Shell("cmd /c start " & xklin)
                                Else
                                    If xklin.Contains("\") Or xklin.Contains("/") Then
                                        Call Shell("cmd /c taskkill /f /im " & System.IO.Path.GetFileName(xklin))
                                    Else
                                        Call Shell("cmd /c taskkill /f /im " & xklin)
                                    End If
                                End If
                                fdctext = "下课自动任务已执行"
                                fdctitle = "自动任务"
                                fdctime = 3
                                Form33.Show()
                            ElseIf xklin = "ksms" Then
                                If xkoc = "1" Then
                                    qpms = 0
                                    Form21.Show()
                                Else
                                    If Form21.Timer2.Enabled = False Then
                                        Form21.Timer2.Enabled = True
                                    End If
                                End If
                            ElseIf xklin = "wsms" Then
                                If xkoc = "1" Then
                                    qpms = 1
                                    Form21.Show()
                                Else
                                    If Form21.Timer2.Enabled = False Then
                                        Form21.Timer2.Enabled = True
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
                autostd = My.Computer.FileSystem.ReadAllText("data\autostd.txt")
                autostdt = My.Computer.FileSystem.ReadAllText("data\autostdt.txt")
                If autostd = "1" And autostdt <> "" Then
                    If CDate(autostdt) = TimeOfDay Then
                        fdctext = "计算机将在5秒内关机"
                        fdctitle = "自动关机"
                        fdctime = 3
                        Form33.Show()
                        Timer8.Enabled = True
                    End If
                End If
                tlino = My.Computer.FileSystem.ReadAllText("data\tctask1.txt")
                tlint = My.Computer.FileSystem.ReadAllText("data\tctask2.txt")
                ttimjy = My.Computer.FileSystem.ReadAllText("data\tctimejy.txt")
                ttimjj = My.Computer.FileSystem.ReadAllText("data\tctimejj.txt")
                tllq = My.Computer.FileSystem.ReadAllText("data\tcllq.txt")
                tmgr = My.Computer.FileSystem.ReadAllText("data\tcmgr.txt")
                If ttimjy <> "" And ttimjj <> "" Then
                    If CDate(ttimjy) <= TimeOfDay And TimeOfDay <= CDate(ttimjj) Then
                        sjkz = True
                    Else
                        sjkz = False
                    End If
                Else
                    sjkz = False
                End If
                If sjkz = True Then
                    If CDate(ttimjj) <= TimeOfDay Then
                        sjkz = False
                    Else
                        If tlino <> "" And tlino <> "qnbf.exe" And tlino <> "dual.exe" Then
                            If Exitproc(tlino) Then
                                Call Shell("cmd /c taskkill /f /im " & tlino)
                                fdctext = "此程序在该时间段不可使用"
                                fdctitle = "时间控制"
                                fdctime = 3
                                Form33.Show()
                            End If
                        End If
                        If tlint <> "" And tlint <> "qnbf.exe" And tlint <> "dual.exe" Then
                            If Exitproc(tlint) Then
                                Call Shell("cmd /c taskkill /f /im " & tlint)
                                fdctext = "此程序在该时间段不可使用"
                                fdctitle = "时间控制"
                                fdctime = 3
                                Form33.Show()
                            End If
                        End If
                        If tllq = "1" Then
                            If Exitproc("iexplore.exe") Then
                                Call Shell("cmd /c taskkill /f /im iexplore.exe")
                                fdctext = "浏览器在该时间段不可使用"
                                fdctitle = "时间控制"
                                fdctime = 3
                                Form33.Show()
                            End If
                            If Exitproc("msedge.exe") Then
                                Call Shell("cmd /c taskkill /f /im msedge.exe")
                                fdctext = "浏览器在该时间段不可使用"
                                fdctitle = "时间控制"
                                fdctime = 3
                                Form33.Show()
                            End If
                            If Exitproc("chrome.exe") Then
                                Call Shell("cmd /c taskkill /f /im chrome.exe")
                                fdctext = "浏览器在该时间段不可使用"
                                fdctitle = "时间控制"
                                fdctime = 3
                                Form33.Show()
                            End If
                            If Exitproc("firefox.exe") Then
                                Call Shell("cmd /c taskkill /f /im firefox.exe")
                                fdctext = "浏览器在该时间段不可使用"
                                fdctitle = "时间控制"
                                fdctime = 3
                                Form33.Show()
                            End If
                            If Exitproc("opera.exe") Then
                                Call Shell("cmd /c taskkill /f /im opera.exe")
                                fdctext = "浏览器在该时间段不可使用"
                                fdctitle = "时间控制"
                                fdctime = 3
                                Form33.Show()
                            End If
                            If Exitproc("360se.exe") Then
                                Call Shell("cmd /c taskkill /f /im 360se.exe")
                                fdctext = "浏览器在该时间段不可使用"
                                fdctitle = "时间控制"
                                fdctime = 3
                                Form33.Show()
                            End If
                            If Exitproc("360chrome.exe") Then
                                Call Shell("cmd /c taskkill /f /im 360chrome.exe")
                                fdctext = "浏览器在该时间段不可使用"
                                fdctitle = "时间控制"
                                fdctime = 3
                                Form33.Show()
                            End If
                            If Exitproc("2345Explorer.exe") Then
                                Call Shell("cmd /c taskkill /f /im 2345Explorer.exe")
                                fdctext = "浏览器在该时间段不可使用"
                                fdctitle = "时间控制"
                                fdctime = 3
                                Form33.Show()
                            End If
                            If Exitproc("QQBrowser.exe") Then
                                Call Shell("cmd /c taskkill /f /im QQBrowser.exe")
                                fdctext = "浏览器在该时间段不可使用"
                                fdctitle = "时间控制"
                                fdctime = 3
                                Form33.Show()
                            End If
                            If Exitproc("SogouExplorer.exe") Then
                                Call Shell("cmd /c taskkill /f /im SogouExplorer.exe")
                                fdctext = "浏览器在该时间段不可使用"
                                fdctitle = "时间控制"
                                fdctime = 3
                                Form33.Show()
                            End If
                            If Exitproc("UCBrowser.exe") Then
                                Call Shell("cmd /c taskkill /f /im UCBrowser.exe")
                                fdctext = "浏览器在该时间段不可使用"
                                fdctitle = "时间控制"
                                fdctime = 3
                                Form33.Show()
                            End If
                            If Exitproc("liebao.exe") Then
                                Call Shell("cmd /c taskkill /f /im liebao.exe")
                                fdctext = "浏览器在该时间段不可使用"
                                fdctitle = "时间控制"
                                fdctime = 3
                                Form33.Show()
                            End If
                        End If
                        If tmgr = "1" Then
                            If Exitproc("Taskmgr.exe") Then
                                Call Shell("cmd /c taskkill /f /im Taskmgr.exe")
                                fdctext = "任务管理器在该时间段不可使用"
                                fdctitle = "时间控制"
                                fdctime = 3
                                Form33.Show()
                            End If
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            My.Computer.FileSystem.WriteAllText("data\atlink1.txt", Trim(My.Computer.FileSystem.ReadAllText("data\atlink1.txt").Replace(vbCrLf, "")), False)
            My.Computer.FileSystem.WriteAllText("data\attime1.txt", Trim(My.Computer.FileSystem.ReadAllText("data\attime1.txt").Replace(vbCrLf, "")), False)
            My.Computer.FileSystem.WriteAllText("data\atoc1.txt", Trim(My.Computer.FileSystem.ReadAllText("data\atoc1.txt").Replace(vbCrLf, "")), False)
            My.Computer.FileSystem.WriteAllText("data\atlink2.txt", Trim(My.Computer.FileSystem.ReadAllText("data\atlink2.txt").Replace(vbCrLf, "")), False)
            My.Computer.FileSystem.WriteAllText("data\attime2.txt", Trim(My.Computer.FileSystem.ReadAllText("data\attime2.txt").Replace(vbCrLf, "")), False)
            My.Computer.FileSystem.WriteAllText("data\atoc2.txt", Trim(My.Computer.FileSystem.ReadAllText("data\atoc2.txt").Replace(vbCrLf, "")), False)
            My.Computer.FileSystem.WriteAllText("data\atlink3.txt", Trim(My.Computer.FileSystem.ReadAllText("data\atlink3.txt").Replace(vbCrLf, "")), False)
            My.Computer.FileSystem.WriteAllText("data\attime3.txt", Trim(My.Computer.FileSystem.ReadAllText("data\attime3.txt").Replace(vbCrLf, "")), False)
            My.Computer.FileSystem.WriteAllText("data\atoc3.txt", Trim(My.Computer.FileSystem.ReadAllText("data\atoc3.txt").Replace(vbCrLf, "")), False)
            My.Computer.FileSystem.WriteAllText("data\atlink4.txt", Trim(My.Computer.FileSystem.ReadAllText("data\atlink4.txt").Replace(vbCrLf, "")), False)
            My.Computer.FileSystem.WriteAllText("data\attime4.txt", Trim(My.Computer.FileSystem.ReadAllText("data\attime4.txt").Replace(vbCrLf, "")), False)
            My.Computer.FileSystem.WriteAllText("data\atoc4.txt", Trim(My.Computer.FileSystem.ReadAllText("data\atoc4.txt").Replace(vbCrLf, "")), False)
            My.Computer.FileSystem.WriteAllText("data\skatlink.txt", Trim(My.Computer.FileSystem.ReadAllText("data\skatlink.txt").Replace(vbCrLf, "")), False)
            My.Computer.FileSystem.WriteAllText("data\skatoc.txt", Trim(My.Computer.FileSystem.ReadAllText("data\skatoc.txt").Replace(vbCrLf, "")), False)
            My.Computer.FileSystem.WriteAllText("data\xkatlink.txt", Trim(My.Computer.FileSystem.ReadAllText("data\xkatlink.txt").Replace(vbCrLf, "")), False)
            My.Computer.FileSystem.WriteAllText("data\xkatoc.txt", Trim(My.Computer.FileSystem.ReadAllText("data\xkatoc.txt").Replace(vbCrLf, "")), False)
            My.Computer.FileSystem.WriteAllText("data\autostd.txt", Trim(My.Computer.FileSystem.ReadAllText("data\autostd.txt").Replace(vbCrLf, "")), False)
            My.Computer.FileSystem.WriteAllText("data\autostdt.txt", Trim(My.Computer.FileSystem.ReadAllText("data\autostdt.txt").Replace(vbCrLf, "")), False)
            My.Computer.FileSystem.WriteAllText("data\tctask1.txt", Trim(My.Computer.FileSystem.ReadAllText("data\tctask1.txt").Replace(vbCrLf, "")), False)
            My.Computer.FileSystem.WriteAllText("data\tctask2.txt", Trim(My.Computer.FileSystem.ReadAllText("data\tctask2.txt").Replace(vbCrLf, "")), False)
            My.Computer.FileSystem.WriteAllText("data\tctimejy.txt", Trim(My.Computer.FileSystem.ReadAllText("data\tctimejy.txt").Replace(vbCrLf, "")), False)
            My.Computer.FileSystem.WriteAllText("data\tctimejj.txt", Trim(My.Computer.FileSystem.ReadAllText("data\tctimejj.txt").Replace(vbCrLf, "")), False)
            My.Computer.FileSystem.WriteAllText("data\tcllq.txt", Trim(My.Computer.FileSystem.ReadAllText("data\tcllq.txt").Replace(vbCrLf, "")), False)
            My.Computer.FileSystem.WriteAllText("data\tcmgr.txt", Trim(My.Computer.FileSystem.ReadAllText("data\tcmgr.txt").Replace(vbCrLf, "")), False)
            zdh = False
            MessageBox.Show("自动化时间填写有误，已关闭自动化功能" & vbCrLf & "请修改正确后重启软件以启用自动化功能!", "全能班辅", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub Timer7_Tick(sender As Object, e As EventArgs) Handles Timer7.Tick
        dtrs = My.Computer.FileSystem.ReadAllText("data\dt.txt")
        If dtrs = "1" Then
            If Not Exitproc("dual.exe") Then
                Call Shell("cmd /c start dual.exe")
            End If
        End If
    End Sub

    Private Sub Timer8_Tick(sender As Object, e As EventArgs) Handles Timer8.Tick
        Call Shell("cmd /c shutdown /s /t 0")
        Timer8.Enabled = False
    End Sub

    Public Function zxtime(s$) As String
        Dim timelist As String
        timelist = My.Computer.FileSystem.ReadAllText("data\cl" & dqcl & "\timelist.txt")
        If Len(s) = 4 Then
            zxtime = Trim(Mid(timelist, InStr(timelist, CStr(s)) + 4, 9))
        Else
            zxtime = Trim(Mid(timelist, InStr(timelist, CStr(s)) + 5, 9))
        End If
    End Function

    Private Sub Timer9_Tick(sender As Object, e As EventArgs) Handles Timer9.Tick
        If Form24.Left < My.Computer.Screen.Bounds.Size.Width + 500 Then
            Form3.Left = Form3.Left + gspeed
            Form4.Left = Form4.Left + gspeed
            Form5.Left = Form5.Left + gspeed
            Form6.Left = Form6.Left + gspeed
            Form7.Left = Form7.Left + gspeed
            Form8.Left = Form8.Left + gspeed
            Form9.Left = Form9.Left + gspeed
            Form10.Left = Form10.Left + gspeed
            Form11.Left = Form11.Left + gspeed
            Form12.Left = Form12.Left + gspeed
            Form13.Left = Form13.Left + gspeed
            Form14.Left = Form14.Left + gspeed
            Form15.Left = Form15.Left + gspeed
            Form16.Left = Form16.Left + gspeed
            Form17.Left = Form17.Left + gspeed
            Form18.Left = Form18.Left + gspeed
            Form20.Left = Form20.Left + gspeed
            Form22.Left = Form22.Left + gspeed
            Form23.Left = Form23.Left + gspeed
            Form24.Left = Form24.Left + gspeed
            Me.Left = Me.Left + gspeed
            gspeed = gspeed + 0.5
        Else
            If cq = False Then
                NotifyIcon1.Visible = False
                End
            Else
                NotifyIcon1.Visible = False
                Call Shell("cmd /c start rstme.bat")
                End
            End If
        End If
    End Sub

    Private Sub 随机点名ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 随机点名ToolStripMenuItem.Click
        Form25.Show()
    End Sub

    Private Sub 考试模式ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 考试模式ToolStripMenuItem.Click
        qpms = 0
        Form21.Show()
    End Sub

    Private Sub 午睡模式ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 午睡模式ToolStripMenuItem.Click
        qpms = 1
        zdh = False
        Form21.Show()
    End Sub

    Private Sub 一周课表ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 一周课表ToolStripMenuItem.Click
        Form34.Show()
    End Sub

    Private Sub 软件设置ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 软件设置ToolStripMenuItem.Click
        Form20.Show()
    End Sub

    Private Sub 关于软件ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 关于软件ToolStripMenuItem.Click
        Form32.Close()
        Form32.Show()
    End Sub

    Private Sub 重启软件ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 重启软件ToolStripMenuItem.Click
        If dtrs = "1" Then
            cq = False
            Timer9.Enabled = True
        ElseIf dtrs = "0" Then
            cq = True
            Timer9.Enabled = True
        End If
    End Sub

    Private Sub 关闭软件ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 关闭软件ToolStripMenuItem.Click
        AddHandler Form31.FormClosed, AddressOf Form31_Closed
        If DecryptData(My.Computer.FileSystem.ReadAllText("data\psw.txt")) = "231144" Then
            My.Computer.FileSystem.WriteAllText("data\exit.txt", "1", False)
            cq = False
            Form19.Close()
            Form21.Close()
            Form25.Close()
            Form26.Close()
            Form27.Close()
            Form28.Close()
            Form29.Close()
            Form30.Close()
            Form31.Close()
            Form32.Close()
            Form33.Close()
            Form34.Close()
            Form35.Close()
            Form36.Close()
            Timer9.Enabled = True
        Else
            mmzq = False
            srmm = True
            Form31.Show()
        End If
    End Sub

    Public Function DecryptData(txt As String)
        For i = 1 To Len(txt)
            If Asc(Mid(txt, i, 1)) - 1 = 31 Then
                DecryptData = DecryptData & Chr(126)
            Else
                DecryptData = DecryptData & Chr(Asc(Mid(txt, i, 1)) - 1)
            End If
        Next
    End Function

    Private Sub Form31_Closed(sender As Object, e As FormClosedEventArgs)
        srmm = False
        If mmzq = True Then
            My.Computer.FileSystem.WriteAllText("data\exit.txt", "1", False)
            cq = False
            Form19.Close()
            Form21.Close()
            Form25.Close()
            Form26.Close()
            Form27.Close()
            Form28.Close()
            Form29.Close()
            Form30.Close()
            Form32.Close()
            Form33.Close()
            Form34.Close()
            Form35.Close()
            Form36.Close()
            Timer9.Enabled = True
        End If
    End Sub

    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or &H80
            Return cp
        End Get
    End Property
End Class