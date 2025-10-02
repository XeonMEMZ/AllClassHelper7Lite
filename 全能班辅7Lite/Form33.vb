Imports System.Drawing.Drawing2D
Imports System.Runtime.InteropServices

Public Class Form33
    Private Const WM_NCLBUTTONDOWN As Integer = &HA1
    Private Const HT_CAPTION As Integer = &H2
    <DllImport("user32.dll")>
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
    End Function
    <DllImport("user32.dll")>
    Private Shared Function ReleaseCapture() As Boolean
    End Function

    Dim speed As Long
    Dim n As Integer

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Alt Or Keys.F4) Then
            Return True
        Else
            Return MyBase.ProcessCmdKey(msg, keyData)
        End If
    End Function

    Private Sub Form33_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim path As New GraphicsPath()
        Dim radius As Integer = 15
        path.AddArc(0, 0, radius, radius, 180, 90)
        path.AddArc(Me.Width - radius, 0, radius, radius, 270, 90)
        path.AddArc(Me.Width - radius, Me.Height - radius, radius, radius, 0, 90)
        path.AddArc(0, Me.Height - radius, radius, radius, 90, 90)
        path.CloseFigure()
        Me.Region = New Region(path)
        Label1.Text = fdctitle
        Label2.Text = fdctext
        speed = 1
        Me.Left = (My.Computer.Screen.Bounds.Size.Width - Me.Width) / 2
        Me.Top = 0 - Me.Height
        Me.Width = 110
        theme = My.Computer.FileSystem.ReadAllText("themes\themes.txt")
        If fdctitle = "上课提醒" Or fdctitle = "下课提醒" Then
            PictureBox1.BackgroundImage = Image.FromFile("themes\" & theme & "\fdc2.png")
        ElseIf fdctitle = "自动关机" Then
            PictureBox1.BackgroundImage = Image.FromFile("themes\" & theme & "\fdc3.png")
        Else
            PictureBox1.BackgroundImage = Image.FromFile("themes\" & theme & "\fdc1.png")
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If speed > 0 Then
            If Me.Top + speed <= Me.Height * -1 / 3 Then
                Me.Top = Me.Top + speed / 3.5
                Me.Width = Me.Width + speed
                Me.Left = (My.Computer.Screen.Bounds.Size.Width - Me.Width) / 2
                Label1.Text = fdctitle
                Label2.Text = fdctext
                speed = speed + 1
            Else
                Me.Top = Me.Top + speed / 3.5
                Me.Width = Me.Width + speed
                Me.Left = (My.Computer.Screen.Bounds.Size.Width - Me.Width) / 2
                Label1.Text = fdctitle
                Label2.Text = fdctext
                speed = speed - 0.9
            End If
        Else
            Dim path As New GraphicsPath()
            Dim radius As Integer = 15
            path.AddArc(0, 0, radius, radius, 180, 90)
            path.AddArc(Me.Width - radius, 0, radius, radius, 270, 90)
            path.AddArc(Me.Width - radius, Me.Height - radius, radius, radius, 0, 90)
            path.AddArc(0, Me.Height - radius, radius, radius, 90, 90)
            path.CloseFigure()
            Me.Region = New Region(path)
            Timer2.Enabled = True
            Timer3.Enabled = False
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If Not n >= fdctime * 2 Then
            n = n + 1
            Label1.Text = fdctitle
            Label2.Text = fdctext
        Else
            speed = 1
            Timer3.Enabled = True
            Timer1.Enabled = False
            Timer2.Enabled = False
        End If
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        If Not Me.Top < Me.Height * -1 - 100 Then
            Me.Top = Me.Top - speed / 3.5
            Me.Width = Me.Width - speed
            Me.Left = (My.Computer.Screen.Bounds.Size.Width - Me.Width) / 2
            Label1.Text = fdctitle
            Label2.Text = fdctext
            speed = speed + 1
        Else
            Timer1.Enabled = False
            Timer2.Enabled = False
            Timer3.Enabled = False
            Me.Close()
        End If
    End Sub
End Class