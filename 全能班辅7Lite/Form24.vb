
Public Class Form24
    Dim djstext As String
    Dim djstime As String
    Dim speed As Double
    Dim sj As Integer
    Dim sx As Integer

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Alt Or Keys.F4) Then
            Return True
        Else
            Return MyBase.ProcessCmdKey(msg, keyData)
        End If
    End Function

    Private Sub Form24_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Location = New Point(My.Computer.Screen.Bounds.Size.Width - 113 - 52 - Me.Width, 0)
        speed = 0
        sj = 0
        If sfds = False Then
            Label3.Visible = False
        Else
            Label3.Visible = True
            If dqcl = "1" Then
                Label3.Text = "单"
            ElseIf dqcl = "2" Then
                Label3.Text = "双"
            End If
        End If
        Try
            djstext = My.Computer.FileSystem.ReadAllText("data\djstext.txt").Replace(vbCrLf, "")
            djstime = My.Computer.FileSystem.ReadAllText("data\djstime.txt").Replace(vbCrLf, "")
            Label5.Text = "距" & djstext & "还有"
            If Len(CStr(DateDiff(DateInterval.Day, Now, CDate(djstime)))) = 1 Then
                Label7.Left = 93
                Label6.Text = CInt(DateDiff(DateInterval.Day, Now, CDate(djstime)))
            ElseIf Len(CStr(DateDiff(DateInterval.Day, Now, CDate(djstime)))) = 2 Then
                Label7.Left = 106
                Label6.Text = CInt(DateDiff(DateInterval.Day, Now, CDate(djstime)))
            ElseIf Len(CStr(DateDiff(DateInterval.Day, Now, CDate(djstime)))) = 3 Then
                Label7.Left = 119
                Label6.Text = CInt(DateDiff(DateInterval.Day, Now, CDate(djstime)))
            ElseIf Len(CStr(DateDiff(DateInterval.Day, Now, CDate(djstime)))) = 4 Then
                Label7.Left = 132
                Label6.Text = CInt(DateDiff(DateInterval.Day, Now, CDate(djstime)))
            Else
                Label7.Left = 132
                Label6.Text = "9999"
            End If
        Catch ex As Exception
            Timer3.Enabled = False
            MessageBox.Show("倒计时时间填写有误，已停止倒计时功能" & vbCrLf & "请修改正确后重启软件以启用倒计时功能!", "全能班辅", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
        Label1.Text = Now.Year & "年"
        Label2.Text = Now.Month & "月" & Now.Day & "日"
        If Len(CStr(TimeOfDay)) = 7 Then
            Label4.Text = "0" & TimeOfDay
        Else
            Label4.Text = TimeOfDay
        End If
        If IsNumeric(My.Computer.FileSystem.ReadAllText("data\sx.txt")) Then
            sx = CInt(My.Computer.FileSystem.ReadAllText("data\sx.txt"))
        Else
            My.Computer.FileSystem.WriteAllText("data\sx.txt", "150", False)
            sx = 150
        End If
        If sx < 150 Then
            My.Computer.FileSystem.WriteAllText("data\sx.txt", "150", False)
            sx = 150
        End If
        Try
            If My.Computer.FileSystem.ReadAllText("weather\zt.txt") = "1" Then
                If Len(My.Computer.FileSystem.ReadAllText("weather\showtext.txt")) > 7 Then
                    Label8.Text = Microsoft.VisualBasic.Left(My.Computer.FileSystem.ReadAllText("weather\showtext.txt"), 7)
                Else
                    Label8.Text = My.Computer.FileSystem.ReadAllText("weather\showtext.txt")
                End If
                Label9.Text = My.Computer.FileSystem.ReadAllText("weather\showtemp.txt")
                tq = My.Computer.FileSystem.ReadAllText("weather\tq.txt")
                If tq = "阴" Or tq = "雾" Or tq = "霾" Then
                    Me.BackgroundImage = Image.FromFile("themes\" & theme & "\weatherbg\2.png")
                ElseIf tq = "小雨" Or tq = "中雨" Or tq = "大雨" Or tq = "阵雨" Or tq = "雷阵雨" Then
                    Me.BackgroundImage = Image.FromFile("themes\" & theme & "\weatherbg\3.png")
                Else
                    Me.BackgroundImage = Image.FromFile("themes\" & theme & "\weatherbg\1.png")
                End If
                My.Computer.FileSystem.WriteAllText("weather\zt.txt", "0", False)
            Else
                Label8.Text = "正在获取天气..."
                Label9.Text = "--"
                Timer5.Enabled = True
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If speed + 0.045 <= 0.9 Then
            speed = speed + 0.045
            Me.Opacity = speed
        Else
            speed = 1
            Me.Opacity = 0.9
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Label1.Text = Now.Year & "年"
        Label2.Text = Now.Month & "月" & Now.Day & "日"
        If Len(CStr(TimeOfDay)) = 7 Then
            Label4.Text = "0" & TimeOfDay
        Else
            Label4.Text = TimeOfDay
        End If
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Try
            djstext = My.Computer.FileSystem.ReadAllText("data\djstext.txt")
            djstime = My.Computer.FileSystem.ReadAllText("data\djstime.txt")
            Label5.Text = "距" & djstext & "还有"
            If Len(CStr(DateDiff(DateInterval.Day, Now, CDate(djstime)))) = 1 Then
                Label7.Left = 93
                Label6.Text = CInt(DateDiff(DateInterval.Day, Now, CDate(djstime)))
            ElseIf Len(CStr(DateDiff(DateInterval.Day, Now, CDate(djstime)))) = 2 Then
                Label7.Left = 106
                Label6.Text = CInt(DateDiff(DateInterval.Day, Now, CDate(djstime)))
            ElseIf Len(CStr(DateDiff(DateInterval.Day, Now, CDate(djstime)))) = 3 Then
                Label7.Left = 119
                Label6.Text = CInt(DateDiff(DateInterval.Day, Now, CDate(djstime)))
            ElseIf Len(CStr(DateDiff(DateInterval.Day, Now, CDate(djstime)))) = 4 Then
                Label7.Left = 132
                Label6.Text = CInt(DateDiff(DateInterval.Day, Now, CDate(djstime)))
            Else
                Label7.Left = 132
                Label6.Text = "9999"
            End If
            sx = CInt(My.Computer.FileSystem.ReadAllText("data\sx.txt"))
        Catch ex As Exception
            Timer3.Enabled = False
            MessageBox.Show("倒计时时间填写有误，已停止倒计时功能" & vbCrLf & "请修改正确后重启软件以启用倒计时功能!", "全能班辅", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        sj = sj + 1
        If sj >= sx Then
            Call Shell("cmd /c start getw.exe -r")
            Timer5.Enabled = True
            sj = 0
        End If
    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        Try
            If My.Computer.FileSystem.ReadAllText("weather\zt.txt") = "1" Then
                If Len(My.Computer.FileSystem.ReadAllText("weather\showtext.txt")) > 7 Then
                    Label8.Text = Microsoft.VisualBasic.Left(My.Computer.FileSystem.ReadAllText("weather\showtext.txt"), 7)
                Else
                    Label8.Text = My.Computer.FileSystem.ReadAllText("weather\showtext.txt")
                End If
                Label9.Text = My.Computer.FileSystem.ReadAllText("weather\showtemp.txt")
                tq = My.Computer.FileSystem.ReadAllText("weather\tq.txt")
                If tq = "阴" Or tq = "雾" Or tq = "霾" Then
                    Me.BackgroundImage = Image.FromFile("themes\" & theme & "\weatherbg\2.png")
                ElseIf tq = "小雨" Or tq = "中雨" Or tq = "大雨" Or tq = "阵雨" Or tq = "雷阵雨" Then
                    Me.BackgroundImage = Image.FromFile("themes\" & theme & "\weatherbg\3.png")
                Else
                    Me.BackgroundImage = Image.FromFile("themes\" & theme & "\weatherbg\1.png")
                End If
                My.Computer.FileSystem.WriteAllText("weather\zt.txt", "0", False)
                Timer5.Enabled = False
            End If
        Catch ex As Exception

        End Try
    End Sub

    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or &H80
            Return cp
        End Get
    End Property
End Class