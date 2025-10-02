Imports System.ComponentModel.Design
Imports System.Drawing.Drawing2D
Imports System.IO
Imports System.Runtime.InteropServices
Imports Newtonsoft.Json.Linq
Imports IWshRuntimeLibrary
Public Class Form20
    Private Const WM_NCLBUTTONDOWN As Integer = &HA1
    Private Const HT_CAPTION As Integer = &H2
    <DllImport("user32.dll")>
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
    End Function
    <DllImport("user32.dll")>
    Private Shared Function ReleaseCapture() As Boolean
    End Function

    Dim ccolr As Boolean
    Dim gspeed As Double
    Dim speed As Double
    Dim tytop As Double
    Dim ytop As Double
    Dim cdan As Integer
    Dim getfc As Integer
    Dim srmm As Boolean
    Dim ylxx As Boolean
    Dim ylzt As String
    Dim ztc As Integer
    Dim dcl As String
    Dim rq As Integer
    Dim bc As Boolean
    Dim cq As Boolean
    Dim zt As String
    Dim cl As String
    Dim bg As String

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Alt Or Keys.F4) Then
            Return True
        Else
            Return MyBase.ProcessCmdKey(msg, keyData)
        End If
    End Function

    Public Function EncryptData(txt As String)
        For i = 1 To Len(txt)
            If Asc(Mid(txt, i, 1)) + 1 = 127 Then
                EncryptData = EncryptData & Chr(32)
            Else
                EncryptData = EncryptData & Chr(Asc(Mid(txt, i, 1)) + 1)
            End If
        Next
    End Function

    Public Function DecryptData(txt As String)
        For i = 1 To Len(txt)
            If Asc(Mid(txt, i, 1)) - 1 = 31 Then
                DecryptData = DecryptData & Chr(126)
            Else
                DecryptData = DecryptData & Chr(Asc(Mid(txt, i, 1)) - 1)
            End If
        Next
    End Function

    Private Sub Form20_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        If e.Button = MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Me.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If
    End Sub

    Private Sub RoundedForm_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        Dim path As New GraphicsPath()
        Dim radius As Integer = 20
        path.AddArc(0, 0, radius, radius, 180, 90)
        path.AddArc(Me.Width - radius, 0, radius, radius, 270, 90)
        path.AddArc(Me.Width - radius, Me.Height - radius, radius, radius, 0, 90)
        path.AddArc(0, Me.Height - radius, radius, radius, 90, 90)
        path.CloseFigure()
        Me.Region = New Region(path)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If speed + 0.1 <= 1 Then
            speed = speed + 0.1
            Me.Opacity = speed
        Else
            speed = 1
            Me.Opacity = 1
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If speed - 0.1 >= 0 Then
            speed = speed - 0.1
            Me.Opacity = speed
        Else
            speed = 0
            Me.Opacity = 0
            Me.Close()
            Timer2.Enabled = False
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If bc = False Or ccolr = True Then
            rq = MsgBox("您刚才做的所有更改将丢失" & vbCrLf & "是否不保存更改并关闭设置?", vbOKCancel + vbQuestion, "全能班辅")
            If rq = 1 Then
                Timer2.Enabled = True
            End If
        Else
            Timer2.Enabled = True
        End If
    End Sub

    Private Sub Form20_Load(sender As Object, e As EventArgs) Handles Me.Load
        gspeed = 1
        mmzq = False
        srmm = False
        cq = False
        Me.Width = 850
        Me.Height = 600
        Label25.Top = 71
        cdan = 1
        jzsz()
    End Sub

    Private Sub Inputkey(tbox As Integer, key As String)
        If Not key = "bks" Then
            If tbox = 1 Then
                If Not Len(TextBox1.Text) >= 4 Then
                    TextBox1.Text = TextBox1.Text & key
                End If
            ElseIf tbox = 2 Then
                If Not Len(TextBox2.Text) >= 10 Then
                    TextBox2.Text = TextBox2.Text & key
                End If
            ElseIf tbox = 3 Then
                TextBox3.Text = TextBox3.Text & key
            ElseIf tbox = 4 Then
                If Not Len(TextBox4.Text) >= 3 Then
                    TextBox4.Text = TextBox4.Text & key
                End If
            ElseIf tbox = 5 Then
                TextBox5.Text = TextBox5.Text & key
            ElseIf tbox = 6 Then
                TextBox6.Text = TextBox6.Text & key
            ElseIf tbox = 7 Then
                TextBox7.Text = TextBox7.Text & key
            ElseIf tbox = 8 Then
                TextBox8.Text = TextBox8.Text & key
            ElseIf tbox = 9 Then
                TextBox9.Text = TextBox9.Text & key
            ElseIf tbox = 10 Then
                TextBox10.Text = TextBox10.Text & key
            ElseIf tbox = 11 Then
                TextBox11.Text = TextBox11.Text & key
            ElseIf tbox = 12 Then
                TextBox12.Text = TextBox12.Text & key
            ElseIf tbox = 13 Then
                TextBox13.Text = TextBox13.Text & key
            ElseIf tbox = 14 Then
                TextBox14.Text = TextBox14.Text & key
            ElseIf tbox = 15 Then
                TextBox15.Text = TextBox15.Text & key
            ElseIf tbox = 16 Then
                TextBox16.Text = TextBox16.Text & key
            ElseIf tbox = 17 Then
                TextBox17.Text = TextBox17.Text & key
            ElseIf tbox = 18 Then
                TextBox18.Text = TextBox18.Text & key
            ElseIf tbox = 19 Then
                TextBox19.Text = TextBox19.Text & key
            ElseIf tbox = 20 Then
                TextBox20.Text = TextBox20.Text & key
            End If
        Else
            If tbox = 1 Then
                If Not TextBox1.Text = "" Then
                    TextBox1.Text = Microsoft.VisualBasic.Left(TextBox1.Text, Len(TextBox1.Text) - 1)
                End If
            ElseIf tbox = 2 Then
                If Not TextBox2.Text = "" Then
                    TextBox2.Text = Microsoft.VisualBasic.Left(TextBox2.Text, Len(TextBox2.Text) - 1)
                End If
            ElseIf tbox = 3 Then
                If Not TextBox3.Text = "" Then
                    TextBox3.Text = Microsoft.VisualBasic.Left(TextBox3.Text, Len(TextBox3.Text) - 1)
                End If
            ElseIf tbox = 4 Then
                If Not TextBox4.Text = "" Then
                    TextBox4.Text = Microsoft.VisualBasic.Left(TextBox4.Text, Len(TextBox4.Text) - 1)
                End If
            ElseIf tbox = 5 Then
                If Not TextBox5.Text = "" Then
                    TextBox5.Text = Microsoft.VisualBasic.Left(TextBox5.Text, Len(TextBox5.Text) - 1)
                End If
            ElseIf tbox = 6 Then
                If Not TextBox6.Text = "" Then
                    TextBox6.Text = Microsoft.VisualBasic.Left(TextBox6.Text, Len(TextBox6.Text) - 1)
                End If
            ElseIf tbox = 7 Then
                If Not TextBox7.Text = "" Then
                    TextBox7.Text = Microsoft.VisualBasic.Left(TextBox7.Text, Len(TextBox7.Text) - 1)
                End If
            ElseIf tbox = 8 Then
                If Not TextBox8.Text = "" Then
                    TextBox8.Text = Microsoft.VisualBasic.Left(TextBox8.Text, Len(TextBox8.Text) - 1)
                End If
            ElseIf tbox = 9 Then
                If Not TextBox9.Text = "" Then
                    TextBox9.Text = Microsoft.VisualBasic.Left(TextBox9.Text, Len(TextBox9.Text) - 1)
                End If
            ElseIf tbox = 10 Then
                If Not TextBox10.Text = "" Then
                    TextBox10.Text = Microsoft.VisualBasic.Left(TextBox10.Text, Len(TextBox10.Text) - 1)
                End If
            ElseIf tbox = 11 Then
                If Not TextBox11.Text = "" Then
                    TextBox11.Text = Microsoft.VisualBasic.Left(TextBox11.Text, Len(TextBox11.Text) - 1)
                End If
            ElseIf tbox = 12 Then
                If Not TextBox12.Text = "" Then
                    TextBox12.Text = Microsoft.VisualBasic.Left(TextBox12.Text, Len(TextBox12.Text) - 1)
                End If
            ElseIf tbox = 13 Then
                If Not TextBox13.Text = "" Then
                    TextBox13.Text = Microsoft.VisualBasic.Left(TextBox13.Text, Len(TextBox13.Text) - 1)
                End If
            ElseIf tbox = 14 Then
                If Not TextBox14.Text = "" Then
                    TextBox14.Text = Microsoft.VisualBasic.Left(TextBox14.Text, Len(TextBox14.Text) - 1)
                End If
            ElseIf tbox = 15 Then
                If Not TextBox15.Text = "" Then
                    TextBox15.Text = Microsoft.VisualBasic.Left(TextBox15.Text, Len(TextBox15.Text) - 1)
                End If
            ElseIf tbox = 16 Then
                If Not TextBox16.Text = "" Then
                    TextBox16.Text = Microsoft.VisualBasic.Left(TextBox16.Text, Len(TextBox16.Text) - 1)
                End If
            ElseIf tbox = 17 Then
                If Not TextBox17.Text = "" Then
                    TextBox17.Text = Microsoft.VisualBasic.Left(TextBox17.Text, Len(TextBox17.Text) - 1)
                End If
            ElseIf tbox = 18 Then
                If Not TextBox18.Text = "" Then
                    TextBox18.Text = Microsoft.VisualBasic.Left(TextBox18.Text, Len(TextBox18.Text) - 1)
                End If
            ElseIf tbox = 19 Then
                If Not TextBox19.Text = "" Then
                    TextBox19.Text = Microsoft.VisualBasic.Left(TextBox19.Text, Len(TextBox19.Text) - 1)
                End If
            ElseIf tbox = 20 Then
                If Not TextBox20.Text = "" Then
                    TextBox20.Text = Microsoft.VisualBasic.Left(TextBox20.Text, Len(TextBox20.Text) - 1)
                End If
            End If
        End If
    End Sub

    Private Sub TextBox1_GotFocus(sender As Object, e As EventArgs) Handles TextBox1.GotFocus
        getfc = 1
    End Sub

    Private Sub TextBox2_GotFocus(sender As Object, e As EventArgs) Handles TextBox2.GotFocus
        getfc = 2
    End Sub

    Private Sub TextBox3_GotFocus(sender As Object, e As EventArgs) Handles TextBox3.GotFocus
        getfc = 3
    End Sub

    Private Sub TextBox4_GotFocus(sender As Object, e As EventArgs) Handles TextBox4.GotFocus
        getfc = 4
    End Sub

    Private Sub TextBox5_GotFocus(sender As Object, e As EventArgs) Handles TextBox5.GotFocus
        getfc = 5
    End Sub

    Private Sub TextBox6_GotFocus(sender As Object, e As EventArgs) Handles TextBox6.GotFocus
        getfc = 6
    End Sub

    Private Sub TextBox7_GotFocus(sender As Object, e As EventArgs) Handles TextBox7.GotFocus
        getfc = 7
    End Sub

    Private Sub TextBox8_GotFocus(sender As Object, e As EventArgs) Handles TextBox8.GotFocus
        getfc = 8
    End Sub

    Private Sub TextBox9_GotFocus(sender As Object, e As EventArgs) Handles TextBox9.GotFocus
        getfc = 9
    End Sub

    Private Sub TextBox10_GotFocus(sender As Object, e As EventArgs) Handles TextBox10.GotFocus
        getfc = 10
    End Sub

    Private Sub TextBox11_GotFocus(sender As Object, e As EventArgs) Handles TextBox11.GotFocus
        getfc = 11
    End Sub

    Private Sub TextBox12_GotFocus(sender As Object, e As EventArgs) Handles TextBox12.GotFocus
        getfc = 12
    End Sub

    Private Sub TextBox13_GotFocus(sender As Object, e As EventArgs) Handles TextBox13.GotFocus
        getfc = 13
    End Sub

    Private Sub TextBox14_GotFocus(sender As Object, e As EventArgs) Handles TextBox14.GotFocus
        getfc = 14
    End Sub

    Private Sub TextBox15_GotFocus(sender As Object, e As EventArgs) Handles TextBox15.GotFocus
        getfc = 15
    End Sub

    Private Sub TextBox16_GotFocus(sender As Object, e As EventArgs) Handles TextBox16.GotFocus
        getfc = 16
    End Sub

    Private Sub TextBox17_GotFocus(sender As Object, e As EventArgs) Handles TextBox17.GotFocus
        getfc = 17
    End Sub

    Private Sub TextBox18_GotFocus(sender As Object, e As EventArgs) Handles TextBox18.GotFocus
        getfc = 18
    End Sub

    Private Sub TextBox19_GotFocus(sender As Object, e As EventArgs) Handles TextBox19.GotFocus
        getfc = 19
    End Sub

    Private Sub TextBox20_GotFocus(sender As Object, e As EventArgs) Handles TextBox20.GotFocus
        getfc = 20
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Inputkey(getfc, "1")
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Inputkey(getfc, "2")
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Inputkey(getfc, "3")
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Inputkey(getfc, "4")
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Inputkey(getfc, "5")
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Inputkey(getfc, "6")
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Inputkey(getfc, "7")
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Inputkey(getfc, "8")
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Inputkey(getfc, "9")
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Inputkey(getfc, "0")
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        Inputkey(getfc, ":")
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        Inputkey(getfc, "/")
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Inputkey(getfc, "bks")
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        If Not TextBox1.Text = "" Then
            My.Computer.FileSystem.WriteAllText("data\djstext.txt", TextBox1.Text, False)
        Else
            MsgBox("倒计时事件不能为空!", vbExclamation + vbOKOnly, "全能班辅")
        End If
        If Not TextBox2.Text = "" Then
            My.Computer.FileSystem.WriteAllText("data\djstime.txt", TextBox2.Text, False)
        Else
            MsgBox("倒计时时间不能为空!", vbExclamation + vbOKOnly, "全能班辅")
        End If
        If Not TextBox3.Text = "" Then
            My.Computer.FileSystem.WriteAllText("data\city.txt", TextBox3.Text, False)
        Else
            MsgBox("天气地区不能为空!", vbExclamation + vbOKOnly, "全能班辅")
        End If
        If Not TextBox4.Text = "" Then
            If IsNumeric(TextBox4.Text) Then
                If CInt(TextBox4.Text) >= 150 Then
                    My.Computer.FileSystem.WriteAllText("data\sx.txt", TextBox4.Text, False)
                Else
                    MsgBox("刷新时间不得小于150分钟!", vbExclamation + vbOKOnly, "全能班辅")
                    TextBox4.Text = "150"
                End If
            Else
                MsgBox("刷新时间填写有误!", vbExclamation + vbOKOnly, "全能班辅")
            End If
        Else
            MsgBox("刷新时间不能为空!", vbExclamation + vbOKOnly, "全能班辅")
        End If
        If CheckBox1.Checked = True Then
            If Not TextBox5.Text = "" Then
                If TextBox5.Text = "单" Then
                    My.Computer.FileSystem.WriteAllText("data\cl.txt", "1", False)
                ElseIf TextBox5.Text = "双" Then
                    My.Computer.FileSystem.WriteAllText("data\cl.txt", "2", False)
                Else
                    MsgBox("单双周请填写单或双!", vbExclamation + vbOKOnly, "全能班辅")
                End If
            Else
                MsgBox("单双周设置不能为空!", vbExclamation + vbOKOnly, "全能班辅")
            End If
        Else
            My.Computer.FileSystem.WriteAllText("data\cl.txt", "0", False)
        End If
        If CheckBox4.Checked = True Then
            If Trim(My.Computer.FileSystem.ReadAllText("data\kjzq.txt")) = "0" Then
                My.Computer.FileSystem.WriteAllText("data\kjzq.txt", "1", False)
                Dim appPath As String = System.Reflection.Assembly.GetExecutingAssembly().Location
                Dim appDirectory As String = System.IO.Path.GetDirectoryName(appPath)
                Dim shortcutPath As String = System.IO.Path.Combine(appDirectory, "qnbf.lnk")
                Dim wshell As New WshShell()
                Dim shortcut As IWshShortcut = CType(wshell.CreateShortcut(shortcutPath), IWshShortcut)
                shortcut.TargetPath = appPath
                shortcut.WorkingDirectory = appDirectory
                shortcut.IconLocation = appPath & ", 0"
                shortcut.Save()
                Call Shell("cmd /c reg add HKLM\SOFTWARE\Microsoft\Windows\CurrentVersion\Run /v qnbf /t REG_SZ /d " & Application.StartupPath & "\qnbf.lnk /f")
            End If
        Else
            If Trim(My.Computer.FileSystem.ReadAllText("data\kjzq.txt")) = "1" Then
                My.Computer.FileSystem.WriteAllText("data\kjzq.txt", "0", False)
                Call Shell("cmd /c del /f qnbf.lnk")
                Call Shell("cmd /c reg delete HKLM\SOFTWARE\Microsoft\Windows\CurrentVersion\Run /v qnbf /f")
            End If
        End If
        If Trim(TextBox6.Text) = "" Then
            My.Computer.FileSystem.WriteAllText("data\atlink1.txt", "", False)
            My.Computer.FileSystem.WriteAllText("data\attime1.txt", "", False)
            My.Computer.FileSystem.WriteAllText("data\atoc1.txt", "0", False)
        Else
            My.Computer.FileSystem.WriteAllText("data\atlink1.txt", TextBox6.Text, False)
            My.Computer.FileSystem.WriteAllText("data\attime1.txt", TextBox7.Text, False)
            If RadioButton6.Checked = True Then
                My.Computer.FileSystem.WriteAllText("data\atoc1.txt", "1", False)
            Else
                My.Computer.FileSystem.WriteAllText("data\atoc1.txt", "0", False)
            End If
        End If
        If Trim(TextBox9.Text) = "" Then
            My.Computer.FileSystem.WriteAllText("data\atlink2.txt", "", False)
            My.Computer.FileSystem.WriteAllText("data\attime2.txt", "", False)
            My.Computer.FileSystem.WriteAllText("data\atoc2.txt", "0", False)
        Else
            My.Computer.FileSystem.WriteAllText("data\atlink2.txt", TextBox9.Text, False)
            My.Computer.FileSystem.WriteAllText("data\attime2.txt", TextBox8.Text, False)
            If RadioButton9.Checked = True Then
                My.Computer.FileSystem.WriteAllText("data\atoc2.txt", "1", False)
            Else
                My.Computer.FileSystem.WriteAllText("data\atoc2.txt", "0", False)
            End If
        End If
        If Trim(TextBox11.Text) = "" Then
            My.Computer.FileSystem.WriteAllText("data\atlink3.txt", "", False)
            My.Computer.FileSystem.WriteAllText("data\attime3.txt", "", False)
            My.Computer.FileSystem.WriteAllText("data\atoc3.txt", "0", False)
        Else
            My.Computer.FileSystem.WriteAllText("data\atlink3.txt", TextBox11.Text, False)
            My.Computer.FileSystem.WriteAllText("data\attime3.txt", TextBox10.Text, False)
            If RadioButton11.Checked = True Then
                My.Computer.FileSystem.WriteAllText("data\atoc3.txt", "1", False)
            Else
                My.Computer.FileSystem.WriteAllText("data\atoc3.txt", "0", False)
            End If
        End If
        If Trim(TextBox13.Text) = "" Then
            My.Computer.FileSystem.WriteAllText("data\atlink4.txt", "", False)
            My.Computer.FileSystem.WriteAllText("data\attime4.txt", "", False)
            My.Computer.FileSystem.WriteAllText("data\atoc4.txt", "0", False)
        Else
            My.Computer.FileSystem.WriteAllText("data\atlink4.txt", TextBox13.Text, False)
            My.Computer.FileSystem.WriteAllText("data\attime4.txt", TextBox12.Text, False)
            If RadioButton13.Checked = True Then
                My.Computer.FileSystem.WriteAllText("data\atoc4.txt", "1", False)
            Else
                My.Computer.FileSystem.WriteAllText("data\atoc4.txt", "0", False)
            End If
        End If
        If RadioButton15.Checked = True And RadioButton15.Enabled = True And TextBox15.Text <> "" Then
            My.Computer.FileSystem.WriteAllText("data\autostd.txt", "1", False)
            My.Computer.FileSystem.WriteAllText("data\autostdt.txt", TextBox15.Text, False)
        Else
            My.Computer.FileSystem.WriteAllText("data\autostd.txt", "0", False)
            My.Computer.FileSystem.WriteAllText("data\autostdt.txt", "", False)
        End If
        If Trim(TextBox14.Text) = "" Then
            My.Computer.FileSystem.WriteAllText("data\skatlink.txt", "", False)
            My.Computer.FileSystem.WriteAllText("data\skatoc.txt", "0", False)
        Else
            My.Computer.FileSystem.WriteAllText("data\skatlink.txt", TextBox14.Text, False)
            If RadioButton17.Checked = True Then
                My.Computer.FileSystem.WriteAllText("data\skatoc.txt", "1", False)
            Else
                My.Computer.FileSystem.WriteAllText("data\skatoc.txt", "0", False)
            End If
        End If
        If Trim(TextBox16.Text) = "" Then
            My.Computer.FileSystem.WriteAllText("data\xkatlink.txt", "", False)
            My.Computer.FileSystem.WriteAllText("data\xkatoc.txt", "0", False)
        Else
            My.Computer.FileSystem.WriteAllText("data\xkatlink.txt", TextBox16.Text, False)
            If RadioButton19.Checked = True Then
                My.Computer.FileSystem.WriteAllText("data\xkatoc.txt", "1", False)
            Else
                My.Computer.FileSystem.WriteAllText("data\xkatoc.txt", "0", False)
            End If
        End If
        If Trim(TextBox17.Text) <> "" Or CheckBox2.Checked = True Or CheckBox3.Checked = True Then
            My.Computer.FileSystem.WriteAllText("data\tctask1.txt", TextBox17.Text, False)
            My.Computer.FileSystem.WriteAllText("data\tctask2.txt", TextBox18.Text, False)
            My.Computer.FileSystem.WriteAllText("data\tctimejy.txt", TextBox19.Text, False)
            My.Computer.FileSystem.WriteAllText("data\tctimejj.txt", TextBox20.Text, False)
            If CheckBox2.Checked = True Then
                My.Computer.FileSystem.WriteAllText("data\tcllq.txt", "1", False)
            Else
                My.Computer.FileSystem.WriteAllText("data\tcllq.txt", "0", False)
            End If
            If CheckBox3.Checked = True Then
                My.Computer.FileSystem.WriteAllText("data\tcmgr.txt", "1", False)
            Else
                My.Computer.FileSystem.WriteAllText("data\tcmgr.txt", "0", False)
            End If
        Else
            My.Computer.FileSystem.WriteAllText("data\tctask1.txt", "", False)
            My.Computer.FileSystem.WriteAllText("data\tctask2.txt", "", False)
            My.Computer.FileSystem.WriteAllText("data\tctimejy.txt", "", False)
            My.Computer.FileSystem.WriteAllText("data\tctimejj.txt", "", False)
            My.Computer.FileSystem.WriteAllText("data\tcllq.txt", "0", False)
            My.Computer.FileSystem.WriteAllText("data\tcmgr.txt", "0", False)
        End If
    End Sub

    Private Sub CheckBox1_Click(sender As Object, e As EventArgs) Handles CheckBox1.Click
        If CheckBox1.CheckState = CheckState.Checked Then
            TextBox5.Enabled = True
            dcl = My.Computer.FileSystem.ReadAllText("data\cl.txt")
            If dcl = "1" Then
                TextBox5.Text = "单"
            ElseIf dcl = "2" Then
                TextBox5.Text = "双"
            Else
                TextBox5.Text = "单"
            End If
        ElseIf CheckBox1.CheckState = CheckState.Unchecked Then
            TextBox5.Enabled = False
            TextBox5.Text = ""
        End If
    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        AddHandler Form30.FormClosed, AddressOf Form30_Closed
        AddHandler Form31.FormClosed, AddressOf Form31_Closed
        If srmm = False Then
            If DecryptData(My.Computer.FileSystem.ReadAllText("data\psw.txt")) = "231144" Then
                mmzq = False
                Form30.Show()
            Else
                mmzq = False
                srmm = True
                mmzx = 1
                Form31.Show()
            End If
        End If
    End Sub

    Private Sub Form30_Closed(sender As Object, e As FormClosedEventArgs)
        If mmzq = True Then
            If DecryptData(My.Computer.FileSystem.ReadAllText("data\psw.txt")) = "231144" Then
                Button26.Text = "开启密码保护"
            Else
                Button26.Text = "关闭密码保护"
            End If
        End If
    End Sub

    Private Sub Form31_Closed(sender As Object, e As FormClosedEventArgs)
        srmm = False
        If mmzq = True Then
            If mmzx = 1 Then
                My.Computer.FileSystem.WriteAllText("data\psw.txt", EncryptData("231144"), False)
                If DecryptData(My.Computer.FileSystem.ReadAllText("data\psw.txt")) = "231144" Then
                    Button26.Text = "开启密码保护"
                Else
                    Button26.Text = "关闭密码保护"
                End If
            ElseIf mmzx = 2 Then
                If Timer3.Enabled = False And Timer4.Enabled = False And Timer5.Enabled = False And Timer6.Enabled = False Then
                    ytop = GroupBox2.Top
                    tytop = Label25.Top
                    If cdan = 2 Then
                        Timer3.Enabled = True
                        GroupBox2.Top = ytop - 450
                        GroupBox1.Top = GroupBox2.Top - 450
                        GroupBox3.Top = GroupBox2.Top + 450
                        cdan = 3
                    ElseIf cdan = 1 Then
                        Timer5.Enabled = True
                        GroupBox2.Top = ytop - 900
                        GroupBox1.Top = GroupBox2.Top - 450
                        GroupBox3.Top = GroupBox2.Top + 450
                        cdan = 3
                    End If
                End If
            ElseIf mmzx = 3 Then
                If dtrs = 1 Then
                    dtrs = 0
                    My.Computer.FileSystem.WriteAllText("data\dt.txt", "0", False)
                    Call Shell("cmd /c taskkill /f /im dual.exe")
                    Button27.Text = "开启进程保护"
                Else
                    dtrs = 1
                    My.Computer.FileSystem.WriteAllText("data\dt.txt", "1", False)
                    Call Shell("cmd /c start dual.exe")
                    Button27.Text = "关闭进程保护"
                End If
            ElseIf mmzx = 4 Then
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
                Timer7.Enabled = True
            ElseIf mmzx = 5 Then
                rq = MsgBox("您的所有设置参数将丢失" & vbCrLf & "是否还原本软件所有设置?", vbOKCancel + vbQuestion, "全能班辅")
                If rq = 1 Then
                    hysysz()
                End If
            ElseIf mmzx = 6 Then
                AddHandler Form36.FormClosed, AddressOf Form36_Closed
                Form36.Show()
            ElseIf mmzx = 7 Then
                If ylxx = True Then
                    CheckBox4.Checked = False
                    ylxx = False
                Else
                    CheckBox4.Checked = True
                    ylxx = True
                End If
            End If
        Else
            If mmzx = 7 Then
                If ylxx = True Then
                    CheckBox4.Checked = True
                    ylxx = True
                Else
                    CheckBox4.Checked = False
                    ylxx = False
                End If
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Timer3.Enabled = False And Timer4.Enabled = False And Timer5.Enabled = False And Timer6.Enabled = False Then
            ytop = GroupBox2.Top
            tytop = Label25.Top
            If cdan = 2 Then
                Timer4.Enabled = True
                GroupBox2.Top = ytop + 450
                GroupBox1.Top = GroupBox2.Top - 450
                GroupBox3.Top = GroupBox2.Top + 450
                cdan = 1
            ElseIf cdan = 3 Then
                Timer6.Enabled = True
                GroupBox2.Top = ytop + 900
                GroupBox1.Top = GroupBox2.Top - 450
                GroupBox3.Top = GroupBox2.Top + 450
                cdan = 1
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Timer3.Enabled = False And Timer4.Enabled = False And Timer5.Enabled = False And Timer6.Enabled = False Then
            ytop = GroupBox2.Top
            tytop = Label25.Top
            If cdan = 1 Then
                Timer3.Enabled = True
                GroupBox2.Top = ytop - 450
                GroupBox1.Top = GroupBox2.Top - 450
                GroupBox3.Top = GroupBox2.Top + 450
                cdan = 2
            ElseIf cdan = 3 Then
                Timer4.Enabled = True
                GroupBox2.Top = ytop + 450
                GroupBox1.Top = GroupBox2.Top - 450
                GroupBox3.Top = GroupBox2.Top + 450
                cdan = 2
            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        AddHandler Form31.FormClosed, AddressOf Form31_Closed
        If DecryptData(My.Computer.FileSystem.ReadAllText("data\psw.txt")) = "231144" Then
            If Timer3.Enabled = False And Timer4.Enabled = False And Timer5.Enabled = False And Timer6.Enabled = False Then
                ytop = GroupBox2.Top
                tytop = Label25.Top
                If cdan = 2 Then
                    Timer3.Enabled = True
                    GroupBox2.Top = ytop - 450
                    GroupBox1.Top = GroupBox2.Top - 450
                    GroupBox3.Top = GroupBox2.Top + 450
                    cdan = 3
                ElseIf cdan = 1 Then
                    Timer5.Enabled = True
                    GroupBox2.Top = ytop - 900
                    GroupBox1.Top = GroupBox2.Top - 450
                    GroupBox3.Top = GroupBox2.Top + 450
                    cdan = 3
                End If
            End If
        Else
            mmzq = False
            srmm = True
            mmzx = 2
            Form31.Show()
        End If
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        If speed > 0 Then
            If Label25.Top + speed <= tytop + (43 / 3) Then
                Label25.Top = Label25.Top + speed
                speed = speed + 1
            Else
                Label25.Top = Label25.Top + speed
                speed = speed - 0.5
            End If
        Else
            speed = 1
            Label25.Top = tytop + 43
            Timer3.Enabled = False
        End If
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        If speed > 0 Then
            If Label25.Top - speed >= tytop - (43 / 3) Then
                Label25.Top = Label25.Top - speed
                speed = speed + 1
            Else
                Label25.Top = Label25.Top - speed
                speed = speed - 0.5
            End If
        Else
            speed = 1
            Label25.Top = tytop - 43
            Timer4.Enabled = False
        End If
    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        If speed > 0 Then
            If Label25.Top + speed <= tytop + (86 / 3) Then
                Label25.Top = Label25.Top + speed
                speed = speed + 1.5
            Else
                Label25.Top = Label25.Top + speed
                speed = speed - 1
            End If
        Else
            speed = 1
            Label25.Top = tytop + 86
            Timer5.Enabled = False
        End If
    End Sub

    Private Sub Timer6_Tick(sender As Object, e As EventArgs) Handles Timer6.Tick
        If speed > 0 Then
            If Label25.Top - speed >= tytop - (86 / 3) Then
                Label25.Top = Label25.Top - speed
                speed = speed + 1.5
            Else
                Label25.Top = Label25.Top - speed
                speed = speed - 1
            End If
        Else
            speed = 1
            Label25.Top = tytop - 86
            Timer6.Enabled = False
        End If
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        Form26.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
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
            Timer7.Enabled = True
        Else
            mmzq = False
            srmm = True
            mmzx = 4
            Form31.Show()
        End If
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        Form27.Show()
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        Form28.Show()
    End Sub

    Function GetFolderCount(directoryPath As String) As Integer
        If Directory.Exists(directoryPath) Then
            Return Directory.GetDirectories(directoryPath).Length
        Else
            Return 0
        End If
    End Function

    Private Sub Button34_Click(sender As Object, e As EventArgs) Handles Button34.Click
        If RadioButton1.Checked = True Then
            sxzt("1")
        ElseIf RadioButton2.Checked = True Then
            sxzt("2")
        ElseIf RadioButton3.Checked = True Then
            sxzt("3")
        ElseIf RadioButton4.Checked = True Then
            sxzt("4")
        ElseIf RadioButton5.Checked = True Then
            sxzt("5")
        End If
    End Sub

    Private Sub Button35_Click(sender As Object, e As EventArgs) Handles Button35.Click
        For frm = 3 To 18
            If frm = 3 Then
                My.Computer.FileSystem.WriteAllText("themes\" & ylzt & "\f3color.txt", Label28.BackColor.ToArgb, False)
            ElseIf frm = 4 Then
                My.Computer.FileSystem.WriteAllText("themes\" & ylzt & "\f4color.txt", Label29.BackColor.ToArgb, False)
            ElseIf frm = 5 Then
                My.Computer.FileSystem.WriteAllText("themes\" & ylzt & "\f5color.txt", Label30.BackColor.ToArgb, False)
            ElseIf frm = 6 Then
                My.Computer.FileSystem.WriteAllText("themes\" & ylzt & "\f6color.txt", Label31.BackColor.ToArgb, False)
            ElseIf frm = 7 Then
                My.Computer.FileSystem.WriteAllText("themes\" & ylzt & "\f7color.txt", Label32.BackColor.ToArgb, False)
            ElseIf frm = 8 Then
                My.Computer.FileSystem.WriteAllText("themes\" & ylzt & "\f8color.txt", Label33.BackColor.ToArgb, False)
            ElseIf frm = 9 Then
                My.Computer.FileSystem.WriteAllText("themes\" & ylzt & "\f9color.txt", Label34.BackColor.ToArgb, False)
            ElseIf frm = 10 Then
                My.Computer.FileSystem.WriteAllText("themes\" & ylzt & "\f10color.txt", Label35.BackColor.ToArgb, False)
            ElseIf frm = 11 Then
                My.Computer.FileSystem.WriteAllText("themes\" & ylzt & "\f11color.txt", Label36.BackColor.ToArgb, False)
            ElseIf frm = 12 Then
                My.Computer.FileSystem.WriteAllText("themes\" & ylzt & "\f12color.txt", Label37.BackColor.ToArgb, False)
            ElseIf frm = 13 Then
                My.Computer.FileSystem.WriteAllText("themes\" & ylzt & "\f13color.txt", Label38.BackColor.ToArgb, False)
            ElseIf frm = 14 Then
                My.Computer.FileSystem.WriteAllText("themes\" & ylzt & "\f14color.txt", Label39.BackColor.ToArgb, False)
            ElseIf frm = 15 Then
                My.Computer.FileSystem.WriteAllText("themes\" & ylzt & "\f15color.txt", Label40.BackColor.ToArgb, False)
            ElseIf frm = 16 Then
                My.Computer.FileSystem.WriteAllText("themes\" & ylzt & "\f16color.txt", Label41.BackColor.ToArgb, False)
            ElseIf frm = 17 Then
                My.Computer.FileSystem.WriteAllText("themes\" & ylzt & "\f17color.txt", Label42.BackColor.ToArgb, False)
            ElseIf frm = 18 Then
                My.Computer.FileSystem.WriteAllText("themes\" & ylzt & "\f18color.txt", Label43.BackColor.ToArgb, False)
            End If
        Next
        ccolr = False
        sxzt(ylzt)
    End Sub

    Public Sub sxzt(thm As String)
        Label17.Text = "已安装" & ztc & "个主题，当前为主题" & thm
        My.Computer.FileSystem.WriteAllText("themes\themes.txt", thm, False)
        theme = thm
        bg = My.Computer.FileSystem.ReadAllText("themes\" & thm & "\f3color.txt")
        Form3.BackColor = Color.FromArgb(bg)
        bg = My.Computer.FileSystem.ReadAllText("themes\" & thm & "\f4color.txt")
        Form4.BackColor = Color.FromArgb(bg)
        bg = My.Computer.FileSystem.ReadAllText("themes\" & thm & "\f5color.txt")
        Form5.BackColor = Color.FromArgb(bg)
        bg = My.Computer.FileSystem.ReadAllText("themes\" & thm & "\f6color.txt")
        Form6.BackColor = Color.FromArgb(bg)
        bg = My.Computer.FileSystem.ReadAllText("themes\" & thm & "\f7color.txt")
        Form7.BackColor = Color.FromArgb(bg)
        bg = My.Computer.FileSystem.ReadAllText("themes\" & thm & "\f8color.txt")
        Form8.BackColor = Color.FromArgb(bg)
        bg = My.Computer.FileSystem.ReadAllText("themes\" & thm & "\f9color.txt")
        Form9.BackColor = Color.FromArgb(bg)
        bg = My.Computer.FileSystem.ReadAllText("themes\" & thm & "\f10color.txt")
        Form10.BackColor = Color.FromArgb(bg)
        bg = My.Computer.FileSystem.ReadAllText("themes\" & thm & "\f11color.txt")
        Form11.BackColor = Color.FromArgb(bg)
        bg = My.Computer.FileSystem.ReadAllText("themes\" & thm & "\f12color.txt")
        Form12.BackColor = Color.FromArgb(bg)
        bg = My.Computer.FileSystem.ReadAllText("themes\" & thm & "\f13color.txt")
        Form13.BackColor = Color.FromArgb(bg)
        bg = My.Computer.FileSystem.ReadAllText("themes\" & thm & "\f14color.txt")
        Form14.BackColor = Color.FromArgb(bg)
        bg = My.Computer.FileSystem.ReadAllText("themes\" & thm & "\f15color.txt")
        Form15.BackColor = Color.FromArgb(bg)
        bg = My.Computer.FileSystem.ReadAllText("themes\" & thm & "\f16color.txt")
        Form16.BackColor = Color.FromArgb(bg)
        bg = My.Computer.FileSystem.ReadAllText("themes\" & thm & "\f17color.txt")
        Form17.BackColor = Color.FromArgb(bg)
        bg = My.Computer.FileSystem.ReadAllText("themes\" & thm & "\f18color.txt")
        Form18.BackColor = Color.FromArgb(bg)
        If tq = "阴" Or tq = "雾" Or tq = "霾" Then
            Form24.BackgroundImage = Image.FromFile("themes\" & thm & "\weatherbg\2.png")
        ElseIf tq = "小雨" Or tq = "中雨" Or tq = "大雨" Or tq = "阵雨" Or tq = "雷阵雨" Then
            Form24.BackgroundImage = Image.FromFile("themes\" & thm & "\weatherbg\3.png")
        Else
            Form24.BackgroundImage = Image.FromFile("themes\" & thm & "\weatherbg\1.png")
        End If
    End Sub

    Public Sub sxyl(thm As String)
        ylzt = thm
        Panel1.BackgroundImage = Image.FromFile("themes\" & theme & "\weatherbg\1.png")
        Label28.BackColor = Color.FromArgb(My.Computer.FileSystem.ReadAllText("themes\" & thm & "\f3color.txt"))
        Label29.BackColor = Color.FromArgb(My.Computer.FileSystem.ReadAllText("themes\" & thm & "\f4color.txt"))
        Label30.BackColor = Color.FromArgb(My.Computer.FileSystem.ReadAllText("themes\" & thm & "\f5color.txt"))
        Label31.BackColor = Color.FromArgb(My.Computer.FileSystem.ReadAllText("themes\" & thm & "\f6color.txt"))
        Label32.BackColor = Color.FromArgb(My.Computer.FileSystem.ReadAllText("themes\" & thm & "\f7color.txt"))
        Label33.BackColor = Color.FromArgb(My.Computer.FileSystem.ReadAllText("themes\" & thm & "\f8color.txt"))
        Label34.BackColor = Color.FromArgb(My.Computer.FileSystem.ReadAllText("themes\" & thm & "\f9color.txt"))
        Label35.BackColor = Color.FromArgb(My.Computer.FileSystem.ReadAllText("themes\" & thm & "\f10color.txt"))
        Label36.BackColor = Color.FromArgb(My.Computer.FileSystem.ReadAllText("themes\" & thm & "\f11color.txt"))
        Label37.BackColor = Color.FromArgb(My.Computer.FileSystem.ReadAllText("themes\" & thm & "\f12color.txt"))
        Label38.BackColor = Color.FromArgb(My.Computer.FileSystem.ReadAllText("themes\" & thm & "\f13color.txt"))
        Label39.BackColor = Color.FromArgb(My.Computer.FileSystem.ReadAllText("themes\" & thm & "\f14color.txt"))
        Label40.BackColor = Color.FromArgb(My.Computer.FileSystem.ReadAllText("themes\" & thm & "\f15color.txt"))
        Label41.BackColor = Color.FromArgb(My.Computer.FileSystem.ReadAllText("themes\" & thm & "\f16color.txt"))
        Label42.BackColor = Color.FromArgb(My.Computer.FileSystem.ReadAllText("themes\" & thm & "\f17color.txt"))
        Label43.BackColor = Color.FromArgb(My.Computer.FileSystem.ReadAllText("themes\" & thm & "\f18color.txt"))
        ccolr = False
    End Sub

    Private Sub RadioButton1_Click(sender As Object, e As EventArgs) Handles RadioButton1.Click
        If RadioButton1.Checked = True And RadioButton1.Enabled = True Then
            If ccolr = True Then
                rq = MsgBox("您刚才做的颜色更改将丢失" & vbCrLf & "是否不保存更改并切换主题?", vbOKCancel + vbQuestion, "全能班辅")
                If rq = 1 Then
                    sxyl("1")
                Else
                    If ylzt = 2 Then
                        RadioButton1.Checked = False
                        RadioButton2.Checked = True
                    ElseIf ylzt = 3 Then
                        RadioButton1.Checked = False
                        RadioButton3.Checked = True
                    ElseIf ylzt = 4 Then
                        RadioButton1.Checked = False
                        RadioButton4.Checked = True
                    ElseIf ylzt = 5 Then
                        RadioButton1.Checked = False
                        RadioButton5.Checked = True
                    End If
                End If
            Else
                sxyl("1")
            End If
        End If
    End Sub

    Private Sub RadioButton2_Click(sender As Object, e As EventArgs) Handles RadioButton2.Click
        If RadioButton2.Checked = True And RadioButton2.Enabled = True Then
            If ccolr = True Then
                rq = MsgBox("您刚才做的颜色更改将丢失" & vbCrLf & "是否不保存更改并切换主题?", vbOKCancel + vbQuestion, "全能班辅")
                If rq = 1 Then
                    sxyl("2")
                Else
                    If ylzt = 1 Then
                        RadioButton2.Checked = False
                        RadioButton1.Checked = True
                    ElseIf ylzt = 3 Then
                        RadioButton2.Checked = False
                        RadioButton3.Checked = True
                    ElseIf ylzt = 4 Then
                        RadioButton2.Checked = False
                        RadioButton4.Checked = True
                    ElseIf ylzt = 5 Then
                        RadioButton2.Checked = False
                        RadioButton5.Checked = True
                    End If
                End If
            Else
                sxyl("2")
            End If
        End If
    End Sub

    Private Sub RadioButton3_Click(sender As Object, e As EventArgs) Handles RadioButton3.Click
        If RadioButton3.Checked = True And RadioButton3.Enabled = True Then
            If ccolr = True Then
                rq = MsgBox("您刚才做的颜色更改将丢失" & vbCrLf & "是否不保存更改并切换主题?", vbOKCancel + vbQuestion, "全能班辅")
                If rq = 1 Then
                    sxyl("3")
                Else
                    If ylzt = 1 Then
                        RadioButton3.Checked = False
                        RadioButton1.Checked = True
                    ElseIf ylzt = 2 Then
                        RadioButton3.Checked = False
                        RadioButton2.Checked = True
                    ElseIf ylzt = 4 Then
                        RadioButton3.Checked = False
                        RadioButton4.Checked = True
                    ElseIf ylzt = 5 Then
                        RadioButton3.Checked = False
                        RadioButton5.Checked = True
                    End If
                End If
            Else
                sxyl("3")
            End If
        End If
    End Sub

    Private Sub RadioButton4_Click(sender As Object, e As EventArgs) Handles RadioButton4.Click
        If RadioButton4.Checked = True And RadioButton4.Enabled = True Then
            If ccolr = True Then
                rq = MsgBox("您刚才做的颜色更改将丢失" & vbCrLf & "是否不保存更改并切换主题?", vbOKCancel + vbQuestion, "全能班辅")
                If rq = 1 Then
                    sxyl("4")
                Else
                    If ylzt = 1 Then
                        RadioButton4.Checked = False
                        RadioButton1.Checked = True
                    ElseIf ylzt = 2 Then
                        RadioButton4.Checked = False
                        RadioButton2.Checked = True
                    ElseIf ylzt = 3 Then
                        RadioButton4.Checked = False
                        RadioButton3.Checked = True
                    ElseIf ylzt = 5 Then
                        RadioButton4.Checked = False
                        RadioButton5.Checked = True
                    End If
                End If
            Else
                sxyl("4")
            End If
        End If
    End Sub

    Private Sub RadioButton5_Click(sender As Object, e As EventArgs) Handles RadioButton5.Click
        If RadioButton5.Checked = True And RadioButton5.Enabled = True Then
            If ccolr = True Then
                rq = MsgBox("您刚才做的颜色更改将丢失" & vbCrLf & "是否不保存更改并切换主题?", vbOKCancel + vbQuestion, "全能班辅")
                If rq = 1 Then
                    sxyl("5")
                Else
                    If ylzt = 1 Then
                        RadioButton5.Checked = False
                        RadioButton1.Checked = True
                    ElseIf ylzt = 2 Then
                        RadioButton5.Checked = False
                        RadioButton2.Checked = True
                    ElseIf ylzt = 3 Then
                        RadioButton5.Checked = False
                        RadioButton3.Checked = True
                    ElseIf ylzt = 4 Then
                        RadioButton5.Checked = False
                        RadioButton4.Checked = True
                    End If
                End If
            Else
                sxyl("5")
            End If
        End If
    End Sub

    Private Sub Button30_Click(sender As Object, e As EventArgs) Handles Button30.Click
        If ColorDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            Label28.BackColor = ColorDialog1.Color
            ccolr = True
        End If
    End Sub

    Private Sub Button29_Click(sender As Object, e As EventArgs) Handles Button29.Click
        Panel1.BackgroundImage = Image.FromFile("themes\" & theme & "\weatherbg\1.png")
    End Sub

    Private Sub Button49_Click(sender As Object, e As EventArgs) Handles Button49.Click
        Panel1.BackgroundImage = Image.FromFile("themes\" & theme & "\weatherbg\2.png")
    End Sub

    Private Sub Button50_Click(sender As Object, e As EventArgs) Handles Button50.Click
        Panel1.BackgroundImage = Image.FromFile("themes\" & theme & "\weatherbg\3.png")
    End Sub

    Private Sub Button31_Click(sender As Object, e As EventArgs) Handles Button31.Click
        If ColorDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            Label29.BackColor = ColorDialog1.Color
            ccolr = True
        End If
    End Sub

    Private Sub Button32_Click(sender As Object, e As EventArgs) Handles Button32.Click
        If ColorDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            Label30.BackColor = ColorDialog1.Color
            ccolr = True
        End If
    End Sub

    Private Sub Button33_Click(sender As Object, e As EventArgs) Handles Button33.Click
        If ColorDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            Label31.BackColor = ColorDialog1.Color
            ccolr = True
        End If
    End Sub

    Private Sub Button37_Click(sender As Object, e As EventArgs) Handles Button37.Click
        If ColorDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            Label32.BackColor = ColorDialog1.Color
            ccolr = True
        End If
    End Sub

    Private Sub Button38_Click(sender As Object, e As EventArgs) Handles Button38.Click
        If ColorDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            Label33.BackColor = ColorDialog1.Color
            ccolr = True
        End If
    End Sub

    Private Sub Button39_Click(sender As Object, e As EventArgs) Handles Button39.Click
        If ColorDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            Label34.BackColor = ColorDialog1.Color
            ccolr = True
        End If
    End Sub

    Private Sub Button40_Click(sender As Object, e As EventArgs) Handles Button40.Click
        If ColorDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            Label35.BackColor = ColorDialog1.Color
            ccolr = True
        End If
    End Sub

    Private Sub Button41_Click(sender As Object, e As EventArgs) Handles Button41.Click
        If ColorDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            Label36.BackColor = ColorDialog1.Color
            ccolr = True
        End If
    End Sub

    Private Sub Button42_Click(sender As Object, e As EventArgs) Handles Button42.Click
        If ColorDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            Label37.BackColor = ColorDialog1.Color
            ccolr = True
        End If
    End Sub

    Private Sub Button43_Click(sender As Object, e As EventArgs) Handles Button43.Click
        If ColorDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            Label38.BackColor = ColorDialog1.Color
            ccolr = True
        End If
    End Sub

    Private Sub Button44_Click(sender As Object, e As EventArgs) Handles Button44.Click
        If ColorDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            Label39.BackColor = ColorDialog1.Color
            ccolr = True
        End If
    End Sub

    Private Sub Button45_Click(sender As Object, e As EventArgs) Handles Button45.Click
        If ColorDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            Label40.BackColor = ColorDialog1.Color
            ccolr = True
        End If
    End Sub

    Private Sub Button46_Click(sender As Object, e As EventArgs) Handles Button46.Click
        If ColorDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            Label41.BackColor = ColorDialog1.Color
            ccolr = True
        End If
    End Sub

    Private Sub Button47_Click(sender As Object, e As EventArgs) Handles Button47.Click
        If ColorDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            Label42.BackColor = ColorDialog1.Color
            ccolr = True
        End If
    End Sub

    Private Sub Button48_Click(sender As Object, e As EventArgs) Handles Button48.Click
        If ColorDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            Label43.BackColor = ColorDialog1.Color
            ccolr = True
        End If
    End Sub

    Public Function dycolor(z$, f%) As String
        Dim colorlist As String
        colorlist = My.Computer.FileSystem.ReadAllText("themes\" & z & "\ycolor.txt")
        Dim fxc As String
        fxc = "f" & f & "c"
        If Len(fxc) = 3 Then
            dycolor = Trim(Mid(colorlist, InStr(colorlist, CStr(fxc)) + 3, 10))
        Else
            dycolor = Trim(Mid(colorlist, InStr(colorlist, CStr(fxc)) + 4, 10))
        End If
    End Function

    Private Sub Button36_Click(sender As Object, e As EventArgs) Handles Button36.Click
        rq = MsgBox("是否重置课表颜色?" & vbCrLf & "重置后如需保存,请再点击保存课表颜色", vbOKCancel + vbQuestion, "全能班辅")
        If rq = 1 Then
            For frm = 3 To 18
                If frm = 3 Then
                    Label28.BackColor = Color.FromArgb(dycolor(ylzt, frm))
                ElseIf frm = 4 Then
                    Label29.BackColor = Color.FromArgb(dycolor(ylzt, frm))
                ElseIf frm = 5 Then
                    Label30.BackColor = Color.FromArgb(dycolor(ylzt, frm))
                ElseIf frm = 6 Then
                    Label31.BackColor = Color.FromArgb(dycolor(ylzt, frm))
                ElseIf frm = 7 Then
                    Label32.BackColor = Color.FromArgb(dycolor(ylzt, frm))
                ElseIf frm = 8 Then
                    Label33.BackColor = Color.FromArgb(dycolor(ylzt, frm))
                ElseIf frm = 9 Then
                    Label34.BackColor = Color.FromArgb(dycolor(ylzt, frm))
                ElseIf frm = 10 Then
                    Label35.BackColor = Color.FromArgb(dycolor(ylzt, frm))
                ElseIf frm = 11 Then
                    Label36.BackColor = Color.FromArgb(dycolor(ylzt, frm))
                ElseIf frm = 12 Then
                    Label37.BackColor = Color.FromArgb(dycolor(ylzt, frm))
                ElseIf frm = 13 Then
                    Label38.BackColor = Color.FromArgb(dycolor(ylzt, frm))
                ElseIf frm = 14 Then
                    Label39.BackColor = Color.FromArgb(dycolor(ylzt, frm))
                ElseIf frm = 15 Then
                    Label40.BackColor = Color.FromArgb(dycolor(ylzt, frm))
                ElseIf frm = 16 Then
                    Label41.BackColor = Color.FromArgb(dycolor(ylzt, frm))
                ElseIf frm = 17 Then
                    Label42.BackColor = Color.FromArgb(dycolor(ylzt, frm))
                ElseIf frm = 18 Then
                    Label43.BackColor = Color.FromArgb(dycolor(ylzt, frm))
                End If
            Next
            ccolr = True
        End If
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged
        If Trim(TextBox6.Text) = "" Then
            TextBox7.Enabled = False
            RadioButton6.Enabled = False
            RadioButton7.Enabled = False
        Else
            TextBox7.Enabled = True
            RadioButton6.Enabled = True
            RadioButton7.Enabled = True
        End If
    End Sub

    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs) Handles TextBox9.TextChanged
        If Trim(TextBox9.Text) = "" Then
            TextBox8.Enabled = False
            RadioButton9.Enabled = False
            RadioButton8.Enabled = False
        Else
            TextBox8.Enabled = True
            RadioButton9.Enabled = True
            RadioButton8.Enabled = True
        End If
    End Sub

    Private Sub TextBox11_TextChanged(sender As Object, e As EventArgs) Handles TextBox11.TextChanged
        If Trim(TextBox11.Text) = "" Then
            TextBox10.Enabled = False
            RadioButton11.Enabled = False
            RadioButton10.Enabled = False
        Else
            TextBox10.Enabled = True
            RadioButton11.Enabled = True
            RadioButton10.Enabled = True
        End If
    End Sub

    Private Sub TextBox13_TextChanged(sender As Object, e As EventArgs) Handles TextBox13.TextChanged
        If Trim(TextBox13.Text) = "" Then
            TextBox12.Enabled = False
            RadioButton13.Enabled = False
            RadioButton12.Enabled = False
        Else
            TextBox12.Enabled = True
            RadioButton13.Enabled = True
            RadioButton12.Enabled = True
        End If
    End Sub

    Private Sub TextBox14_TextChanged(sender As Object, e As EventArgs) Handles TextBox14.TextChanged
        If Trim(TextBox14.Text) = "" Then
            RadioButton17.Enabled = False
            RadioButton16.Enabled = False
        Else
            RadioButton17.Enabled = True
            RadioButton16.Enabled = True
        End If
    End Sub

    Private Sub TextBox16_TextChanged(sender As Object, e As EventArgs) Handles TextBox16.TextChanged
        If Trim(TextBox16.Text) = "" Then
            RadioButton19.Enabled = False
            RadioButton18.Enabled = False
        Else
            RadioButton19.Enabled = True
            RadioButton18.Enabled = True
        End If
    End Sub

    Private Sub TextBox17_TextChanged(sender As Object, e As EventArgs) Handles TextBox17.TextChanged
        If Trim(TextBox17.Text) <> "" Or CheckBox2.Checked = True Or CheckBox3.Checked = True Then
            TextBox18.Enabled = True
            TextBox19.Enabled = True
            TextBox20.Enabled = True
        Else
            TextBox18.Enabled = False
            TextBox19.Enabled = False
            TextBox20.Enabled = False
        End If
    End Sub

    Private Sub RadioButton15_Click(sender As Object, e As EventArgs) Handles RadioButton15.Click
        If RadioButton15.Checked = True And RadioButton15.Enabled = True Then
            TextBox15.Enabled = True
        End If
    End Sub

    Private Sub RadioButton14_Click(sender As Object, e As EventArgs) Handles RadioButton14.Click
        If RadioButton14.Checked = True And RadioButton14.Enabled = True Then
            TextBox15.Enabled = False
        End If
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        If fricls = 1 Then
            fricls = 0
            Button24.Text = "改为特殊作息"
        Else
            fricls = 1
            Button24.Text = "改为正常作息"
        End If
    End Sub

    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles Button28.Click
        If dtrs = "1" Then
            cq = False
            Timer7.Enabled = True
        ElseIf dtrs = "0" Then
            cq = True
            Timer7.Enabled = True
        End If
    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        AddHandler Form31.FormClosed, AddressOf Form31_Closed
        If DecryptData(My.Computer.FileSystem.ReadAllText("data\psw.txt")) = "231144" Then
            If dtrs = "1" Then
                dtrs = "0"
                My.Computer.FileSystem.WriteAllText("data\dt.txt", "0", False)
                Call Shell("cmd /c taskkill /f /im dual.exe")
                Button27.Text = "开启进程保护"
            Else
                dtrs = "1"
                My.Computer.FileSystem.WriteAllText("data\dt.txt", "1", False)
                Call Shell("cmd /c start dual.exe")
                Button27.Text = "关闭进程保护"
            End If
        Else
            mmzq = False
            srmm = True
            mmzx = 3
            Form31.Show()
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form32.Close()
        Form32.Show()
    End Sub

    Private Sub Button51_Click(sender As Object, e As EventArgs) Handles Button51.Click
        If DecryptData(My.Computer.FileSystem.ReadAllText("data\psw.txt")) = "231144" Then
            MsgBox("请先开启密码保护功能!", vbOKOnly + vbInformation, "全能班辅")
        Else
            AddHandler Form30.FormClosed, AddressOf Form30_Closed
            If srmm = False Then
                mmzq = False
                Form30.Show()
            End If
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If Trim(TextBox17.Text) <> "" Or CheckBox2.Checked = True Or CheckBox3.Checked = True Then
            TextBox18.Enabled = True
            TextBox19.Enabled = True
            TextBox20.Enabled = True
        Else
            TextBox18.Enabled = False
            TextBox19.Enabled = False
            TextBox20.Enabled = False
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If Trim(TextBox17.Text) <> "" Or CheckBox2.Checked = True Or CheckBox3.Checked = True Then
            TextBox18.Enabled = True
            TextBox19.Enabled = True
            TextBox20.Enabled = True
        Else
            TextBox18.Enabled = False
            TextBox19.Enabled = False
            TextBox20.Enabled = False
        End If
    End Sub

    Private Sub Timer7_Tick(sender As Object, e As EventArgs) Handles Timer7.Tick
        If Me.Left < My.Computer.Screen.Bounds.Size.Width + 100 Then
            Form2.Left = Form2.Left + gspeed
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
            Form22.Left = Form22.Left + gspeed
            Form23.Left = Form23.Left + gspeed
            Form24.Left = Form24.Left + gspeed
            Me.Left = Me.Left + gspeed
            gspeed = gspeed + 0.5
        Else
            If cq = False Then
                Form2.NotifyIcon1.Visible = False
                End
            Else
                Form2.NotifyIcon1.Visible = False
                Call Shell("cmd /c start rstme.bat")
                End
            End If
        End If
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        rq = MsgBox("您刚才做的所有更改将丢失" & vbCrLf & "是否撤销刚才所做的所有更改?", vbOKCancel + vbQuestion, "全能班辅")
        If rq = 1 Then
            jzsz()
        End If
    End Sub

    Private Sub Button52_Click(sender As Object, e As EventArgs) Handles Button52.Click
        AddHandler Form31.FormClosed, AddressOf Form31_Closed
        If DecryptData(My.Computer.FileSystem.ReadAllText("data\psw.txt")) = "231144" Then
            AddHandler Form36.FormClosed, AddressOf Form36_Closed
            Form36.Show()
        Else
            mmzq = False
            srmm = True
            mmzx = 6
            Form31.Show()
        End If
    End Sub

    Private Sub Form36_Closed(sender As Object, e As FormClosedEventArgs)
        jzsz()
    End Sub

    Private Sub Button53_Click(sender As Object, e As EventArgs) Handles Button53.Click
        AddHandler Form31.FormClosed, AddressOf Form31_Closed
        If DecryptData(My.Computer.FileSystem.ReadAllText("data\psw.txt")) = "231144" Then
            rq = MsgBox("您的所有设置参数将丢失" & vbCrLf & "是否还原本软件所有设置?", vbOKCancel + vbQuestion, "全能班辅")
            If rq = 1 Then
                hysysz()
            End If
        Else
            mmzq = False
            srmm = True
            mmzx = 5
            Form31.Show()
        End If
    End Sub


    Private Sub hysysz()
        For a = 1 To 2
            For b = 1 To 7
                My.Computer.FileSystem.WriteAllText("data\cl" & a & "\z" & b & ".txt", "ct 07   c1 请    c2 输    c3 入    c4 您    c5 的    c6 课    c7 表    c8     c9     c10     c11     c12     c13     c14     c15   ", False)
            Next
            My.Computer.FileSystem.WriteAllText("data\cl" & a & "\timelist.txt", "  zm1s 08:20:00  zm1x 09:00:00  zm2s 09:10:00  zm2x 09:50:00  zm3s 10:00:00  zm3x 10:40:00  zm4s 10:50:00  zm4x 11:25:00  zm5s 13:20:00  zm5x 13:50:00  zm6s 14:00:00  zm6x 14:40:00  zm7s 14:50:00  zm7x 15:30:00  zm8s 15:50:00  zm8x 16:30:00  zm9s 18:10:00  zm9x 18:50:00  zm10s 19:00:00  zm10x 19:40:00  zm11s 19:50:00  zm11x 20:30:00  zm12s 23:59:59  zm12x 23:59:59  zm13s 23:59:59  zm13x 23:59:59  zm14s 23:59:59  zm14x 23:59:59  zm15s 23:59:59  zm15x 23:59:59  zt1s 08:20:00  zt1x 09:00:00  zt2s 09:10:00  zt2x 09:50:00  zt3s 10:00:00  zt3x 10:40:00  zt4s 10:50:00  zt4x 11:25:00  zt5s 12:40:00  zt5x 13:20:00  zt6s 13:30:00  zt6x 14:10:00  zt7s 23:59:59  zt7x 23:59:59  zt8s 23:59:59  zt8x 23:59:59  zt9s 23:59:59  zt9x 23:59:59  zt10s 23:59:59  zt10x 23:59:59  zt11s 23:59:59  zt11x 23:59:59  zt12s 23:59:59  zt12x 23:59:59  zt13s 23:59:59  zt13x 23:59:59  zt14s 23:59:59  zt14x 23:59:59  zt15s 23:59:59  zt15x 23:59:59  ", False)
        Next
        For a = 1 To 4
            My.Computer.FileSystem.WriteAllText("data\atlink" & a & ".txt", "", False)
            My.Computer.FileSystem.WriteAllText("data\attime" & a & ".txt", "", False)
            My.Computer.FileSystem.WriteAllText("data\atoc" & a & ".txt", "0", False)
        Next
        My.Computer.FileSystem.WriteAllText("data\autostd.txt", "0", False)
        My.Computer.FileSystem.WriteAllText("data\autostdt.txt", "", False)
        My.Computer.FileSystem.WriteAllText("data\city.txt", "杭州", False)
        My.Computer.FileSystem.WriteAllText("data\cl.txt", "0", False)
        My.Computer.FileSystem.WriteAllText("data\djstext.txt", "明年", False)
        My.Computer.FileSystem.WriteAllText("data\djstime.txt", CStr(CInt(Now.Year) + 1) & "/1/1", False)
        My.Computer.FileSystem.WriteAllText("data\dt.txt", "0", False)
        CheckBox4.Checked = False
        If Trim(My.Computer.FileSystem.ReadAllText("data\kjzq.txt")) = "1" Then
            My.Computer.FileSystem.WriteAllText("data\kjzq.txt", "0", False)
            ylxx = False
            Call Shell("cmd /c del /f qnbf.lnk")
            Call Shell("cmd /c reg delete HKLM\SOFTWARE\Microsoft\Windows\CurrentVersion\Run /v qnbf /f")
        Else
            My.Computer.FileSystem.WriteAllText("data\kjzq.txt", "0", False)
        End If
        My.Computer.FileSystem.WriteAllText("data\name.txt", " 1王某某 2张某某 3沈某某 4徐某某 5杨某某", False)
        My.Computer.FileSystem.WriteAllText("data\namec.txt", "5", False)
        My.Computer.FileSystem.WriteAllText("data\psw.txt", "342255", False)
        My.Computer.FileSystem.WriteAllText("data\skatlink.txt", "", False)
        My.Computer.FileSystem.WriteAllText("data\skatoc.txt", "0", False)
        My.Computer.FileSystem.WriteAllText("data\xkatlink.txt", "", False)
        My.Computer.FileSystem.WriteAllText("data\xkatoc.txt", "0", False)
        My.Computer.FileSystem.WriteAllText("data\sx.txt", "150", False)
        My.Computer.FileSystem.WriteAllText("data\tcllq.txt", "0", False)
        My.Computer.FileSystem.WriteAllText("data\tcmgr.txt", "0", False)
        My.Computer.FileSystem.WriteAllText("data\tctask1.txt", "", False)
        My.Computer.FileSystem.WriteAllText("data\tctask2.txt", "", False)
        My.Computer.FileSystem.WriteAllText("data\tctimejy.txt", "", False)
        My.Computer.FileSystem.WriteAllText("data\tctimejj.txt", "", False)
        My.Computer.FileSystem.WriteAllText("data\tss.txt", "5", False)
        My.Computer.FileSystem.WriteAllText("data\week.txt", CStr(DatePart(DateInterval.WeekOfYear, Now, vbMonday)), False)
        For frm = 3 To 18
            If frm = 3 Then
                Label28.BackColor = Color.FromArgb(dycolor("1", frm))
            ElseIf frm = 4 Then
                Label29.BackColor = Color.FromArgb(dycolor("1", frm))
            ElseIf frm = 5 Then
                Label30.BackColor = Color.FromArgb(dycolor("1", frm))
            ElseIf frm = 6 Then
                Label31.BackColor = Color.FromArgb(dycolor("1", frm))
            ElseIf frm = 7 Then
                Label32.BackColor = Color.FromArgb(dycolor("1", frm))
            ElseIf frm = 8 Then
                Label33.BackColor = Color.FromArgb(dycolor("1", frm))
            ElseIf frm = 9 Then
                Label34.BackColor = Color.FromArgb(dycolor("1", frm))
            ElseIf frm = 10 Then
                Label35.BackColor = Color.FromArgb(dycolor("1", frm))
            ElseIf frm = 11 Then
                Label36.BackColor = Color.FromArgb(dycolor("1", frm))
            ElseIf frm = 12 Then
                Label37.BackColor = Color.FromArgb(dycolor("1", frm))
            ElseIf frm = 13 Then
                Label38.BackColor = Color.FromArgb(dycolor("1", frm))
            ElseIf frm = 14 Then
                Label39.BackColor = Color.FromArgb(dycolor("1", frm))
            ElseIf frm = 15 Then
                Label40.BackColor = Color.FromArgb(dycolor("1", frm))
            ElseIf frm = 16 Then
                Label41.BackColor = Color.FromArgb(dycolor("1", frm))
            ElseIf frm = 17 Then
                Label42.BackColor = Color.FromArgb(dycolor("1", frm))
            ElseIf frm = 18 Then
                Label43.BackColor = Color.FromArgb(dycolor("1", frm))
            End If
        Next
        bc = True
        For frm = 3 To 18
            If frm = 3 Then
                My.Computer.FileSystem.WriteAllText("themes\1\f3color.txt", Label28.BackColor.ToArgb, False)
            ElseIf frm = 4 Then
                My.Computer.FileSystem.WriteAllText("themes\1\f4color.txt", Label29.BackColor.ToArgb, False)
            ElseIf frm = 5 Then
                My.Computer.FileSystem.WriteAllText("themes\1\f5color.txt", Label30.BackColor.ToArgb, False)
            ElseIf frm = 6 Then
                My.Computer.FileSystem.WriteAllText("themes\1\f6color.txt", Label31.BackColor.ToArgb, False)
            ElseIf frm = 7 Then
                My.Computer.FileSystem.WriteAllText("themes\1\f7color.txt", Label32.BackColor.ToArgb, False)
            ElseIf frm = 8 Then
                My.Computer.FileSystem.WriteAllText("themes\1\f8color.txt", Label33.BackColor.ToArgb, False)
            ElseIf frm = 9 Then
                My.Computer.FileSystem.WriteAllText("themes\1\f9color.txt", Label34.BackColor.ToArgb, False)
            ElseIf frm = 10 Then
                My.Computer.FileSystem.WriteAllText("themes\1\f10color.txt", Label35.BackColor.ToArgb, False)
            ElseIf frm = 11 Then
                My.Computer.FileSystem.WriteAllText("themes\1\f11color.txt", Label36.BackColor.ToArgb, False)
            ElseIf frm = 12 Then
                My.Computer.FileSystem.WriteAllText("themes\1\f12color.txt", Label37.BackColor.ToArgb, False)
            ElseIf frm = 13 Then
                My.Computer.FileSystem.WriteAllText("themes\1\f13color.txt", Label38.BackColor.ToArgb, False)
            ElseIf frm = 14 Then
                My.Computer.FileSystem.WriteAllText("themes\1\f14color.txt", Label39.BackColor.ToArgb, False)
            ElseIf frm = 15 Then
                My.Computer.FileSystem.WriteAllText("themes\1\f15color.txt", Label40.BackColor.ToArgb, False)
            ElseIf frm = 16 Then
                My.Computer.FileSystem.WriteAllText("themes\1\f16color.txt", Label41.BackColor.ToArgb, False)
            ElseIf frm = 17 Then
                My.Computer.FileSystem.WriteAllText("themes\1\f17color.txt", Label42.BackColor.ToArgb, False)
            ElseIf frm = 18 Then
                My.Computer.FileSystem.WriteAllText("themes\1\f18color.txt", Label43.BackColor.ToArgb, False)
            End If
        Next
        ccolr = False
        sxzt("1")
        If fricls = 1 Then
            Button24.Text = "改为正常作息"
        Else
            Button24.Text = "改为特殊作息"
        End If
        If dtrs = 1 Then
            Button27.Text = "关闭进程保护"
        Else
            Button27.Text = "开启进程保护"
        End If
        If DecryptData(My.Computer.FileSystem.ReadAllText("data\psw.txt")) = "231144" Then
            Button26.Text = "开启密码保护"
        Else
            Button26.Text = "关闭密码保护"
        End If
        TextBox1.Text = Trim(My.Computer.FileSystem.ReadAllText("data\djstext.txt"))
        TextBox2.Text = Trim(My.Computer.FileSystem.ReadAllText("data\djstime.txt"))
        TextBox3.Text = Trim(My.Computer.FileSystem.ReadAllText("data\city.txt"))
        TextBox4.Text = Trim(My.Computer.FileSystem.ReadAllText("data\sx.txt"))
        cl = My.Computer.FileSystem.ReadAllText("data\cl.txt")
        If cl = "0" Then
            CheckBox1.Checked = False
            TextBox5.Text = ""
            TextBox5.Enabled = False
        ElseIf cl = "1" Then
            CheckBox1.Checked = True
            TextBox5.Text = "单"
            TextBox5.Enabled = True
        ElseIf cl = "2" Then
            CheckBox1.Checked = True
            TextBox5.Text = "双"
            TextBox5.Enabled = True
        End If
        Dim path As New GraphicsPath()
        Dim radius As Integer = 20
        path.AddArc(0, 0, radius, radius, 180, 90)
        path.AddArc(Me.Width - radius, 0, radius, radius, 270, 90)
        path.AddArc(Me.Width - radius, Me.Height - radius, radius, radius, 0, 90)
        path.AddArc(0, Me.Height - radius, radius, radius, 90, 90)
        path.CloseFigure()
        Me.Region = New Region(path)
        ztc = GetFolderCount("themes")
        zt = My.Computer.FileSystem.ReadAllText("themes\themes.txt")
        Label17.Text = "已安装" & ztc & "个主题，当前为主题" & zt
        If zt = 1 Then
            ylzt = "1"
            RadioButton1.Checked = True
        ElseIf zt = 2 Then
            ylzt = "2"
            RadioButton2.Checked = True
        ElseIf zt = 3 Then
            ylzt = "3"
            RadioButton3.Checked = True
        ElseIf zt = 4 Then
            ylzt = "4"
            RadioButton4.Checked = True
        ElseIf zt = 5 Then
            ylzt = "5"
            RadioButton5.Checked = True
        End If
        If ztc = 4 Then
            RadioButton5.Enabled = False
        ElseIf ztc = 3 Then
            RadioButton5.Enabled = False
            RadioButton4.Enabled = False
        ElseIf ztc = 2 Then
            RadioButton5.Enabled = False
            RadioButton4.Enabled = False
            RadioButton3.Enabled = False
        ElseIf ztc = 1 Then
            RadioButton5.Enabled = False
            RadioButton4.Enabled = False
            RadioButton3.Enabled = False
            RadioButton2.Enabled = False
        End If
        Panel1.BackgroundImage = Image.FromFile("themes\1\weatherbg\1.png")
        Label28.BackColor = Color.FromArgb(My.Computer.FileSystem.ReadAllText("themes\1\f3color.txt"))
        Label29.BackColor = Color.FromArgb(My.Computer.FileSystem.ReadAllText("themes\1\f4color.txt"))
        Label30.BackColor = Color.FromArgb(My.Computer.FileSystem.ReadAllText("themes\1\f5color.txt"))
        Label31.BackColor = Color.FromArgb(My.Computer.FileSystem.ReadAllText("themes\1\f6color.txt"))
        Label32.BackColor = Color.FromArgb(My.Computer.FileSystem.ReadAllText("themes\1\f7color.txt"))
        Label33.BackColor = Color.FromArgb(My.Computer.FileSystem.ReadAllText("themes\1\f8color.txt"))
        Label34.BackColor = Color.FromArgb(My.Computer.FileSystem.ReadAllText("themes\1\f9color.txt"))
        Label35.BackColor = Color.FromArgb(My.Computer.FileSystem.ReadAllText("themes\1\f10color.txt"))
        Label36.BackColor = Color.FromArgb(My.Computer.FileSystem.ReadAllText("themes\1\f11color.txt"))
        Label37.BackColor = Color.FromArgb(My.Computer.FileSystem.ReadAllText("themes\1\f12color.txt"))
        Label38.BackColor = Color.FromArgb(My.Computer.FileSystem.ReadAllText("themes\1\f13color.txt"))
        Label39.BackColor = Color.FromArgb(My.Computer.FileSystem.ReadAllText("themes\1\f14color.txt"))
        Label40.BackColor = Color.FromArgb(My.Computer.FileSystem.ReadAllText("themes\1\f15color.txt"))
        Label41.BackColor = Color.FromArgb(My.Computer.FileSystem.ReadAllText("themes\1\f16color.txt"))
        Label42.BackColor = Color.FromArgb(My.Computer.FileSystem.ReadAllText("themes\1\f17color.txt"))
        Label43.BackColor = Color.FromArgb(My.Computer.FileSystem.ReadAllText("themes\1\f18color.txt"))
        If Trim(My.Computer.FileSystem.ReadAllText("data\atlink1.txt")) = "" Then
            TextBox7.Enabled = False
            RadioButton6.Enabled = False
            RadioButton7.Enabled = False
            RadioButton6.Checked = True
            TextBox6.Text = ""
            TextBox7.Text = ""
        Else
            TextBox7.Enabled = True
            RadioButton6.Enabled = True
            RadioButton7.Enabled = True
            TextBox6.Text = Trim(My.Computer.FileSystem.ReadAllText("data\atlink1.txt"))
            TextBox7.Text = Trim(My.Computer.FileSystem.ReadAllText("data\attime1.txt"))
            If Trim(My.Computer.FileSystem.ReadAllText("data\atoc1.txt")) = "1" Then
                RadioButton6.Checked = True
            Else
                RadioButton7.Checked = True
            End If
        End If
        If Trim(My.Computer.FileSystem.ReadAllText("data\atlink2.txt")) = "" Then
            TextBox8.Enabled = False
            RadioButton9.Enabled = False
            RadioButton8.Enabled = False
            RadioButton9.Checked = True
            TextBox9.Text = ""
            TextBox8.Text = ""
        Else
            TextBox8.Enabled = True
            RadioButton9.Enabled = True
            RadioButton8.Enabled = True
            TextBox9.Text = Trim(My.Computer.FileSystem.ReadAllText("data\atlink2.txt"))
            TextBox8.Text = Trim(My.Computer.FileSystem.ReadAllText("data\attime2.txt"))
            If Trim(My.Computer.FileSystem.ReadAllText("data\atoc2.txt")) = "1" Then
                RadioButton9.Checked = True
            Else
                RadioButton8.Checked = True
            End If
        End If
        If Trim(My.Computer.FileSystem.ReadAllText("data\atlink3.txt")) = "" Then
            TextBox10.Enabled = False
            RadioButton11.Enabled = False
            RadioButton10.Enabled = False
            RadioButton11.Checked = True
            TextBox11.Text = ""
            TextBox10.Text = ""
        Else
            TextBox10.Enabled = True
            RadioButton11.Enabled = True
            RadioButton10.Enabled = True
            TextBox11.Text = Trim(My.Computer.FileSystem.ReadAllText("data\atlink3.txt"))
            TextBox10.Text = Trim(My.Computer.FileSystem.ReadAllText("data\attime3.txt"))
            If Trim(My.Computer.FileSystem.ReadAllText("data\atoc3.txt")) = "1" Then
                RadioButton11.Checked = True
            Else
                RadioButton10.Checked = True
            End If
        End If
        If Trim(My.Computer.FileSystem.ReadAllText("data\atlink4.txt")) = "" Then
            TextBox12.Enabled = False
            RadioButton13.Enabled = False
            RadioButton12.Enabled = False
            RadioButton13.Checked = True
            TextBox13.Text = ""
            TextBox12.Text = ""
        Else
            TextBox12.Enabled = True
            RadioButton13.Enabled = True
            RadioButton12.Enabled = True
            TextBox13.Text = Trim(My.Computer.FileSystem.ReadAllText("data\atlink4.txt"))
            TextBox12.Text = Trim(My.Computer.FileSystem.ReadAllText("data\attime4.txt"))
            If Trim(My.Computer.FileSystem.ReadAllText("data\atoc4.txt")) = "1" Then
                RadioButton13.Checked = True
            Else
                RadioButton12.Checked = True
            End If
        End If
        If Trim(My.Computer.FileSystem.ReadAllText("data\autostd.txt")) = "0" Then
            TextBox15.Enabled = False
            RadioButton14.Checked = True
            TextBox15.Text = ""
        Else
            TextBox15.Enabled = True
            RadioButton15.Checked = True
            TextBox15.Text = Trim(My.Computer.FileSystem.ReadAllText("data\autostdt.txt"))
        End If
        If Trim(My.Computer.FileSystem.ReadAllText("data\skatlink.txt")) = "" Then
            RadioButton17.Enabled = False
            RadioButton16.Enabled = False
            RadioButton17.Checked = True
            TextBox14.Text = ""
        Else
            RadioButton17.Enabled = True
            RadioButton16.Enabled = True
            TextBox14.Text = Trim(My.Computer.FileSystem.ReadAllText("data\skatlink.txt"))
            If Trim(My.Computer.FileSystem.ReadAllText("data\skatoc.txt")) = "1" Then
                RadioButton17.Checked = True
            Else
                RadioButton16.Checked = True
            End If
        End If
        If Trim(My.Computer.FileSystem.ReadAllText("data\xkatlink.txt")) = "" Then
            RadioButton19.Enabled = False
            RadioButton18.Enabled = False
            RadioButton19.Checked = True
            TextBox16.Text = ""
        Else
            RadioButton19.Enabled = True
            RadioButton18.Enabled = True
            TextBox16.Text = Trim(My.Computer.FileSystem.ReadAllText("data\xkatlink.txt"))
            If Trim(My.Computer.FileSystem.ReadAllText("data\xkatoc.txt")) = "1" Then
                RadioButton19.Checked = True
            Else
                RadioButton18.Checked = True
            End If
        End If
        If Trim(My.Computer.FileSystem.ReadAllText("data\tctask1.txt")) <> "" Or Trim(My.Computer.FileSystem.ReadAllText("data\tcllq.txt")) = "1" Or Trim(My.Computer.FileSystem.ReadAllText("data\tcmgr.txt")) = "1" Then
            TextBox18.Enabled = True
            TextBox19.Enabled = True
            TextBox20.Enabled = True
            TextBox17.Text = Trim(My.Computer.FileSystem.ReadAllText("data\tctask1.txt"))
            TextBox18.Text = Trim(My.Computer.FileSystem.ReadAllText("data\tctask2.txt"))
            TextBox19.Text = Trim(My.Computer.FileSystem.ReadAllText("data\tctimejy.txt"))
            TextBox20.Text = Trim(My.Computer.FileSystem.ReadAllText("data\tctimejj.txt"))
            If Trim(My.Computer.FileSystem.ReadAllText("data\tcllq.txt")) = "1" Then
                CheckBox2.Checked = True
            Else
                CheckBox2.Checked = False
            End If
            If Trim(My.Computer.FileSystem.ReadAllText("data\tcmgr.txt")) = "1" Then
                CheckBox3.Checked = True
            Else
                CheckBox3.Checked = False
            End If
        Else
            TextBox18.Enabled = False
            TextBox19.Enabled = False
            TextBox20.Enabled = False
            TextBox17.Text = ""
            TextBox18.Text = ""
            TextBox19.Text = ""
            TextBox20.Text = ""
        End If
    End Sub

    Private Sub CheckBox4_Click(sender As Object, e As EventArgs) Handles CheckBox4.Click
        AddHandler Form31.FormClosed, AddressOf Form31_Closed
        If DecryptData(My.Computer.FileSystem.ReadAllText("data\psw.txt")) <> "231144" Then
            If ylxx = True Then
                CheckBox4.Checked = True
            Else
                CheckBox4.Checked = False
            End If
            mmzq = False
            srmm = True
            mmzx = 7
            Form31.Show()
        End If
    End Sub

    Private Sub jzsz()
        bc = True
        ccolr = False
        If fricls = 1 Then
            Button24.Text = "改为正常作息"
        Else
            Button24.Text = "改为特殊作息"
        End If
        If dtrs = 1 Then
            Button27.Text = "关闭进程保护"
        Else
            Button27.Text = "开启进程保护"
        End If
        If DecryptData(My.Computer.FileSystem.ReadAllText("data\psw.txt")) = "231144" Then
            Button26.Text = "开启密码保护"
        Else
            Button26.Text = "关闭密码保护"
        End If
        If Trim(My.Computer.FileSystem.ReadAllText("data\kjzq.txt")) = "1" Then
            CheckBox4.Checked = True
            ylxx = True
        Else
            CheckBox4.Checked = False
            ylxx = False
        End If
        TextBox1.Text = Trim(My.Computer.FileSystem.ReadAllText("data\djstext.txt"))
        TextBox2.Text = Trim(My.Computer.FileSystem.ReadAllText("data\djstime.txt"))
        TextBox3.Text = Trim(My.Computer.FileSystem.ReadAllText("data\city.txt"))
        TextBox4.Text = Trim(My.Computer.FileSystem.ReadAllText("data\sx.txt"))
        cl = My.Computer.FileSystem.ReadAllText("data\cl.txt")
        If cl = "0" Then
            CheckBox1.Checked = False
            TextBox5.Text = ""
            TextBox5.Enabled = False
        ElseIf cl = "1" Then
            CheckBox1.Checked = True
            TextBox5.Text = "单"
            TextBox5.Enabled = True
        ElseIf cl = "2" Then
            CheckBox1.Checked = True
            TextBox5.Text = "双"
            TextBox5.Enabled = True
        End If
        Dim path As New GraphicsPath()
        Dim radius As Integer = 20
        path.AddArc(0, 0, radius, radius, 180, 90)
        path.AddArc(Me.Width - radius, 0, radius, radius, 270, 90)
        path.AddArc(Me.Width - radius, Me.Height - radius, radius, radius, 0, 90)
        path.AddArc(0, Me.Height - radius, radius, radius, 90, 90)
        path.CloseFigure()
        Me.Region = New Region(path)
        ztc = GetFolderCount("themes")
        zt = My.Computer.FileSystem.ReadAllText("themes\themes.txt")
        Label17.Text = "已安装" & ztc & "个主题，当前为主题" & zt
        If zt = 1 Then
            ylzt = "1"
            RadioButton1.Checked = True
        ElseIf zt = 2 Then
            ylzt = "2"
            RadioButton2.Checked = True
        ElseIf zt = 3 Then
            ylzt = "3"
            RadioButton3.Checked = True
        ElseIf zt = 4 Then
            ylzt = "4"
            RadioButton4.Checked = True
        ElseIf zt = 5 Then
            ylzt = "5"
            RadioButton5.Checked = True
        End If
        If ztc = 4 Then
            RadioButton5.Enabled = False
        ElseIf ztc = 3 Then
            RadioButton5.Enabled = False
            RadioButton4.Enabled = False
        ElseIf ztc = 2 Then
            RadioButton5.Enabled = False
            RadioButton4.Enabled = False
            RadioButton3.Enabled = False
        ElseIf ztc = 1 Then
            RadioButton5.Enabled = False
            RadioButton4.Enabled = False
            RadioButton3.Enabled = False
            RadioButton2.Enabled = False
        End If
        Panel1.BackgroundImage = Image.FromFile("themes\" & theme & "\weatherbg\1.png")
        Label28.BackColor = Color.FromArgb(My.Computer.FileSystem.ReadAllText("themes\" & theme & "\f3color.txt"))
        Label29.BackColor = Color.FromArgb(My.Computer.FileSystem.ReadAllText("themes\" & theme & "\f4color.txt"))
        Label30.BackColor = Color.FromArgb(My.Computer.FileSystem.ReadAllText("themes\" & theme & "\f5color.txt"))
        Label31.BackColor = Color.FromArgb(My.Computer.FileSystem.ReadAllText("themes\" & theme & "\f6color.txt"))
        Label32.BackColor = Color.FromArgb(My.Computer.FileSystem.ReadAllText("themes\" & theme & "\f7color.txt"))
        Label33.BackColor = Color.FromArgb(My.Computer.FileSystem.ReadAllText("themes\" & theme & "\f8color.txt"))
        Label34.BackColor = Color.FromArgb(My.Computer.FileSystem.ReadAllText("themes\" & theme & "\f9color.txt"))
        Label35.BackColor = Color.FromArgb(My.Computer.FileSystem.ReadAllText("themes\" & theme & "\f10color.txt"))
        Label36.BackColor = Color.FromArgb(My.Computer.FileSystem.ReadAllText("themes\" & theme & "\f11color.txt"))
        Label37.BackColor = Color.FromArgb(My.Computer.FileSystem.ReadAllText("themes\" & theme & "\f12color.txt"))
        Label38.BackColor = Color.FromArgb(My.Computer.FileSystem.ReadAllText("themes\" & theme & "\f13color.txt"))
        Label39.BackColor = Color.FromArgb(My.Computer.FileSystem.ReadAllText("themes\" & theme & "\f14color.txt"))
        Label40.BackColor = Color.FromArgb(My.Computer.FileSystem.ReadAllText("themes\" & theme & "\f15color.txt"))
        Label41.BackColor = Color.FromArgb(My.Computer.FileSystem.ReadAllText("themes\" & theme & "\f16color.txt"))
        Label42.BackColor = Color.FromArgb(My.Computer.FileSystem.ReadAllText("themes\" & theme & "\f17color.txt"))
        Label43.BackColor = Color.FromArgb(My.Computer.FileSystem.ReadAllText("themes\" & theme & "\f18color.txt"))
        If Trim(My.Computer.FileSystem.ReadAllText("data\atlink1.txt")) = "" Then
            TextBox7.Enabled = False
            RadioButton6.Enabled = False
            RadioButton7.Enabled = False
            RadioButton6.Checked = True
            TextBox6.Text = ""
            TextBox7.Text = ""
        Else
            TextBox7.Enabled = True
            RadioButton6.Enabled = True
            RadioButton7.Enabled = True
            TextBox6.Text = Trim(My.Computer.FileSystem.ReadAllText("data\atlink1.txt"))
            TextBox7.Text = Trim(My.Computer.FileSystem.ReadAllText("data\attime1.txt"))
            If Trim(My.Computer.FileSystem.ReadAllText("data\atoc1.txt")) = "1" Then
                RadioButton6.Checked = True
            Else
                RadioButton7.Checked = True
            End If
        End If
        If Trim(My.Computer.FileSystem.ReadAllText("data\atlink2.txt")) = "" Then
            TextBox8.Enabled = False
            RadioButton9.Enabled = False
            RadioButton8.Enabled = False
            RadioButton9.Checked = True
            TextBox9.Text = ""
            TextBox8.Text = ""
        Else
            TextBox8.Enabled = True
            RadioButton9.Enabled = True
            RadioButton8.Enabled = True
            TextBox9.Text = Trim(My.Computer.FileSystem.ReadAllText("data\atlink2.txt"))
            TextBox8.Text = Trim(My.Computer.FileSystem.ReadAllText("data\attime2.txt"))
            If Trim(My.Computer.FileSystem.ReadAllText("data\atoc2.txt")) = "1" Then
                RadioButton9.Checked = True
            Else
                RadioButton8.Checked = True
            End If
        End If
        If Trim(My.Computer.FileSystem.ReadAllText("data\atlink3.txt")) = "" Then
            TextBox10.Enabled = False
            RadioButton11.Enabled = False
            RadioButton10.Enabled = False
            RadioButton11.Checked = True
            TextBox11.Text = ""
            TextBox10.Text = ""
        Else
            TextBox10.Enabled = True
            RadioButton11.Enabled = True
            RadioButton10.Enabled = True
            TextBox11.Text = Trim(My.Computer.FileSystem.ReadAllText("data\atlink3.txt"))
            TextBox10.Text = Trim(My.Computer.FileSystem.ReadAllText("data\attime3.txt"))
            If Trim(My.Computer.FileSystem.ReadAllText("data\atoc3.txt")) = "1" Then
                RadioButton11.Checked = True
            Else
                RadioButton10.Checked = True
            End If
        End If
        If Trim(My.Computer.FileSystem.ReadAllText("data\atlink4.txt")) = "" Then
            TextBox12.Enabled = False
            RadioButton13.Enabled = False
            RadioButton12.Enabled = False
            RadioButton13.Checked = True
            TextBox13.Text = ""
            TextBox12.Text = ""
        Else
            TextBox12.Enabled = True
            RadioButton13.Enabled = True
            RadioButton12.Enabled = True
            TextBox13.Text = Trim(My.Computer.FileSystem.ReadAllText("data\atlink4.txt"))
            TextBox12.Text = Trim(My.Computer.FileSystem.ReadAllText("data\attime4.txt"))
            If Trim(My.Computer.FileSystem.ReadAllText("data\atoc4.txt")) = "1" Then
                RadioButton13.Checked = True
            Else
                RadioButton12.Checked = True
            End If
        End If
        If Trim(My.Computer.FileSystem.ReadAllText("data\autostd.txt")) = "0" Then
            TextBox15.Enabled = False
            RadioButton14.Checked = True
            TextBox15.Text = ""
        Else
            TextBox15.Enabled = True
            RadioButton15.Checked = True
            TextBox15.Text = Trim(My.Computer.FileSystem.ReadAllText("data\autostdt.txt"))
        End If
        If Trim(My.Computer.FileSystem.ReadAllText("data\skatlink.txt")) = "" Then
            RadioButton17.Enabled = False
            RadioButton16.Enabled = False
            RadioButton17.Checked = True
            TextBox14.Text = ""
        Else
            RadioButton17.Enabled = True
            RadioButton16.Enabled = True
            TextBox14.Text = Trim(My.Computer.FileSystem.ReadAllText("data\skatlink.txt"))
            If Trim(My.Computer.FileSystem.ReadAllText("data\skatoc.txt")) = "1" Then
                RadioButton17.Checked = True
            Else
                RadioButton16.Checked = True
            End If
        End If
        If Trim(My.Computer.FileSystem.ReadAllText("data\xkatlink.txt")) = "" Then
            RadioButton19.Enabled = False
            RadioButton18.Enabled = False
            RadioButton19.Checked = True
            TextBox16.Text = ""
        Else
            RadioButton19.Enabled = True
            RadioButton18.Enabled = True
            TextBox16.Text = Trim(My.Computer.FileSystem.ReadAllText("data\xkatlink.txt"))
            If Trim(My.Computer.FileSystem.ReadAllText("data\xkatoc.txt")) = "1" Then
                RadioButton19.Checked = True
            Else
                RadioButton18.Checked = True
            End If
        End If
        If Trim(My.Computer.FileSystem.ReadAllText("data\tctask1.txt")) <> "" Or Trim(My.Computer.FileSystem.ReadAllText("data\tcllq.txt")) = "1" Or Trim(My.Computer.FileSystem.ReadAllText("data\tcmgr.txt")) = "1" Then
            TextBox18.Enabled = True
            TextBox19.Enabled = True
            TextBox20.Enabled = True
            TextBox17.Text = Trim(My.Computer.FileSystem.ReadAllText("data\tctask1.txt"))
            TextBox18.Text = Trim(My.Computer.FileSystem.ReadAllText("data\tctask2.txt"))
            TextBox19.Text = Trim(My.Computer.FileSystem.ReadAllText("data\tctimejy.txt"))
            TextBox20.Text = Trim(My.Computer.FileSystem.ReadAllText("data\tctimejj.txt"))
            If Trim(My.Computer.FileSystem.ReadAllText("data\tcllq.txt")) = "1" Then
                CheckBox2.Checked = True
            Else
                CheckBox2.Checked = False
            End If
            If Trim(My.Computer.FileSystem.ReadAllText("data\tcmgr.txt")) = "1" Then
                CheckBox3.Checked = True
            Else
                CheckBox3.Checked = False
            End If
        Else
            TextBox18.Enabled = False
            TextBox19.Enabled = False
            TextBox20.Enabled = False
            TextBox17.Text = ""
            TextBox18.Text = ""
            TextBox19.Text = ""
            TextBox20.Text = ""
        End If
    End Sub
End Class