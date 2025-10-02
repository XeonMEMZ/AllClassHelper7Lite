Imports System.Drawing.Text
Imports System.IO
Imports System.Runtime.CompilerServices

Public Class Form1
    Dim qdtm As Double
    Dim rq As Integer
    Dim cl As String
    Dim wk As String
    Dim tss As String

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Alt Or Keys.F4) Then
            Return True
        Else
            Return MyBase.ProcessCmdKey(msg, keyData)
        End If
    End Function

    Public Sub CheckRunning()
        Dim currentProcess As Process = Process.GetCurrentProcess()
        Dim processes As Process() = Process.GetProcessesByName(currentProcess.ProcessName)
        If processes.Length > 1 Then
            MessageBox.Show("程序已经在运行!", "全能班辅", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Environment.Exit(0)
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        CheckRunning()
        If Not IsFontInstalled("HarmonyOS Sans SC") Then
            rq = MsgBox("您的电脑未安装程序所需要的字体" & vbCrLf & "请将fonts文件夹内的字体全部安装" & vbCrLf & "否则程序会使用系统默认字体运行" & vbCrLf & "是否使用默认字体运行程序?", vbOKCancel + vbQuestion, "全能班辅")
            If rq = 2 Then
                Application.Exit()
            End If
        End If
        Timer1.Enabled = True
        xday = CStr(Now.Day)
        xwidth = My.Computer.Screen.Bounds.Size.Width
        xheight = My.Computer.Screen.Bounds.Size.Height
        My.Computer.FileSystem.WriteAllText("weather\zt.txt", "0", False)
        My.Computer.FileSystem.WriteAllText("data\exit.txt", "0", False)
        fdczt = False
        theme = My.Computer.FileSystem.ReadAllText("themes\themes.txt")
        Call Shell("cmd /c start getw.exe -r")
        dtrs = My.Computer.FileSystem.ReadAllText("data\dt.txt")
        If dtrs = "1" Then
            If Not Exitproc("dual.exe") Then
                Call Shell("cmd /c start dual.exe")
            End If
        End If
        wk = My.Computer.FileSystem.ReadAllText("data\week.txt")
        cl = My.Computer.FileSystem.ReadAllText("data\cl.txt")
        If cl = "0" Then
            sfds = False
            dqcl = 1
            My.Computer.FileSystem.WriteAllText("data\week.txt", CStr(DatePart(DateInterval.WeekOfYear, Now, vbMonday)), False)
        Else
            sfds = True
            If DatePart(DateInterval.WeekOfYear, Now, vbMonday) - CInt(wk) = 0 Then
                If cl = "1" Then
                    dqcl = 1
                ElseIf cl = "2" Then
                    dqcl = 2
                End If
            ElseIf DatePart(DateInterval.WeekOfYear, Now, vbMonday) - CInt(wk) = 1 Then
                If cl = "1" Then
                    dqcl = 2
                ElseIf cl = "2" Then
                    dqcl = 1
                End If
                My.Computer.FileSystem.WriteAllText("data\cl.txt", dqcl, False)
                My.Computer.FileSystem.WriteAllText("data\week.txt", CStr(DatePart(DateInterval.WeekOfYear, Now, vbMonday)), False)
            Else
                If DatePart(DateInterval.WeekOfYear, Now, vbMonday) - CInt(wk) Mod 2 = 0 Then
                    If cl = "1" Then
                        dqcl = 1
                    ElseIf cl = "2" Then
                        dqcl = 2
                    End If
                ElseIf DatePart(DateInterval.WeekOfYear, Now, vbMonday) - CInt(wk) Mod 2 = 1 Then
                    If cl = "1" Then
                        dqcl = 2
                    ElseIf cl = "2" Then
                        dqcl = 1
                    End If
                End If
                My.Computer.FileSystem.WriteAllText("data\cl.txt", dqcl, False)
                My.Computer.FileSystem.WriteAllText("data\week.txt", CStr(DatePart(DateInterval.WeekOfYear, Now, vbMonday)), False)
            End If
        End If
        tss = My.Computer.FileSystem.ReadAllText("data\cl" & dqcl & "\tss.txt")
        If tss = "1" Then
            If Weekday(Now, FirstDayOfWeek.Monday) = 1 Then
                fricls = 1
            Else
                fricls = 0
            End If
        ElseIf tss = "2" Then
            If Weekday(Now, FirstDayOfWeek.Monday) = 2 Then
                fricls = 1
            Else
                fricls = 0
            End If
        ElseIf tss = "3" Then
            If Weekday(Now, FirstDayOfWeek.Monday) = 3 Then
                fricls = 1
            Else
                fricls = 0
            End If
        ElseIf tss = "4" Then
            If Weekday(Now, FirstDayOfWeek.Monday) = 4 Then
                fricls = 1
            Else
                fricls = 0
            End If
        ElseIf tss = "5" Then
            If Weekday(Now, FirstDayOfWeek.Monday) = 5 Then
                fricls = 1
            Else
                fricls = 0
            End If
        ElseIf tss = "6" Then
            If Weekday(Now, FirstDayOfWeek.Monday) = 6 Then
                fricls = 1
            Else
                fricls = 0
            End If
        ElseIf tss = "7" Then
            If Weekday(Now, FirstDayOfWeek.Monday) = 7 Then
                fricls = 1
            Else
                fricls = 0
            End If
        Else
            fricls = 0
        End If
        loading = True
        Form2.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If qdtm + 0.025 <= 1 Then
            qdtm = qdtm + 0.025
            Me.Opacity = qdtm
        Else
            qdtm = 1
            Timer2.Enabled = True
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Timer3.Enabled = True
        Timer2.Enabled = False
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        If qdtm - 0.025 >= 0 Then
            qdtm = qdtm - 0.025
            Me.Opacity = qdtm
        Else
            qdtm = 0
            Timer1.Enabled = False
            Timer2.Enabled = False
            Me.Hide()
            Timer3.Enabled = False
        End If
    End Sub

    Private Function IsFontInstalled(fontName As String) As Boolean
        Using fontCollection As New InstalledFontCollection()
            Return fontCollection.Families.Any(Function(f) f.Name.Equals(fontName, StringComparison.InvariantCultureIgnoreCase))
        End Using
    End Function

    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or &H80
            Return cp
        End Get
    End Property
End Class
