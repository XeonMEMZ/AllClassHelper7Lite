Imports System.Drawing.Drawing2D
Imports System.Runtime.InteropServices

Public Class Form25
    Private Const WM_NCLBUTTONDOWN As Integer = &HA1
    Private Const HT_CAPTION As Integer = &H2
    <DllImport("user32.dll")>
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
    End Function
    <DllImport("user32.dll")>
    Private Shared Function ReleaseCapture() As Boolean
    End Function

    Dim speed As Double
    Dim cname As String
    Dim cq As Integer
    Dim md As String

    Private Sub Form20_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        If e.Button = MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Me.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If
    End Sub
    Private Sub Form25_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim path As New GraphicsPath()
        Dim radius As Integer = 20
        path.AddArc(0, 0, radius, radius, 180, 90)
        path.AddArc(Me.Width - radius, 0, radius, radius, 270, 90)
        path.AddArc(Me.Width - radius, Me.Height - radius, radius, radius, 0, 90)
        path.AddArc(0, Me.Height - radius, radius, radius, 90, 90)
        path.CloseFigure()
        Me.Region = New Region(path)
        cq = 1
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
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer2.Enabled = True
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        cq = 1
        CheckBox1.Enabled = False
        Button2.Enabled = False
        Button2.Text = "正在抽取中……"
        If CheckBox1.Checked = False Or ycq.Count = cname Then
            ycq.Clear()
        End If
        Randomize()
        cname = My.Computer.FileSystem.ReadAllText("data\namec.txt")
        Timer4.Interval = Int(Rnd() * (1500 - 500 + 1) + 500)
        Timer3.Enabled = True
        Timer4.Enabled = True
    End Sub

    Public Function namelist(n%) As String
        Dim name As String
        name = My.Computer.FileSystem.ReadAllText("data\name.txt")
        If n < 10 Then
            namelist = Trim(Mid(name, InStr(name, CStr(n)) + 1, 4))
        ElseIf n >= 10 Then
            namelist = Trim(Mid(name, InStr(name, CStr(n)) + 2, 4))
        End If
    End Function

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        If cq < cname Then
            TextBox1.Text = namelist(cq)
            cq = cq + 1
        Else
            TextBox1.Text = namelist(cq)
            cq = 1
        End If
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        If CheckBox1.Checked = True Then
            If ycq.Contains(TextBox1.Text) Then
                Timer4.Interval = 5
            Else
                ycq.Add(TextBox1.Text)
                CheckBox1.Enabled = True
                Button2.Enabled = True
                Button2.Text = "点击开始抽取"
                Timer3.Enabled = False
                Timer4.Enabled = False
            End If
        Else
            CheckBox1.Enabled = True
            Button2.Enabled = True
            Button2.Text = "点击开始抽取"
            Timer3.Enabled = False
            Timer4.Enabled = False
        End If
    End Sub
End Class