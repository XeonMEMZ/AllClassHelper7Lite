Imports System.IO

Public Class Form18
    Dim speed As Double
    Dim sc As Boolean
    Dim gd As Boolean
    Dim bg As String

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Alt Or Keys.F4) Then
            Return True
        Else
            Return MyBase.ProcessCmdKey(msg, keyData)
        End If
    End Function

    Private Sub Form18_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Width = 113
        bg = My.Computer.FileSystem.ReadAllText("themes\" & theme & "\f18color.txt")
        Me.Height = 41
        Me.Location = New Point(My.Computer.Screen.Bounds.Size.Width - Me.Width, allkbh)
        speed = 0
        allkbh = allkbh + 41
        Me.BackColor = Color.FromArgb(bg)
        loading = False
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If speed + 0.05 <= 1 Then
            speed = speed + 0.05
            Me.Opacity = speed
        Else
            speed = 1
            Me.Opacity = 1
            Form22.Show()
            Form23.Show()
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If speed > 0 Then
            If Me.Left - speed >= My.Computer.Screen.Bounds.Size.Width - 165 + (52 / 3) Then
                Me.Left = Me.Left - speed
                Me.Height = Me.Height + speed - 0.4
                Form22.Height = Form22.Height + speed - 0.4
                Form23.Height = Form23.Height + speed - 0.4
                Me.Width = Me.Width + speed
                speed = speed + 0.116
            Else
                Me.Left = Me.Left - speed
                Me.Height = Me.Height + speed - 0.4
                Form22.Height = Form22.Height + speed - 0.4
                Form23.Height = Form23.Height + speed - 0.4
                Me.Width = Me.Width + speed
                speed = speed - 0.25
            End If
        Else
            speed = 1
            sc = True
            Me.Left = My.Computer.Screen.Bounds.Size.Width - 113 - 52
            Me.Height = 82
            Me.Width = 165
            Form22.Height = Me.Top + Me.Height
            Form23.Height = Me.Top + Me.Height
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
                Me.Height = Me.Height - speed + 0.37
                Form22.Height = Form22.Height - speed + 0.37
                Form23.Height = Form23.Height - speed + 0.37
                Me.Width = Me.Width - speed
                speed = speed + 0.12
            Else
                Me.Left = Me.Left + speed
                Me.Height = Me.Height - speed + 0.37
                Form22.Height = Form22.Height - speed + 0.37
                Form23.Height = Form23.Height - speed + 0.37
                Me.Width = Me.Width - speed
                speed = speed - 0.135
            End If
        Else
            speed = 1
            Me.Left = My.Computer.Screen.Bounds.Size.Width - 113
            Me.Height = 41
            Me.Width = 113
            Form22.Height = Me.Top + Me.Height
            Form23.Height = Me.Top + Me.Height
            Timer4.Enabled = False
        End If
    End Sub

    Private Sub Label1_DoubleClick(sender As Object, e As EventArgs) Handles Label1.DoubleClick
        If Timer2.Enabled = False And Timer3.Enabled = False And Timer4.Enabled = False And gd = False Then
            Timer2.Enabled = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If sc = True Then
            If Timer3.Enabled = True Then
                Timer3.Enabled = False
                gd = True
            Else
                Timer4.Enabled = True
                gd = False
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form25.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        qpms = 0
        Form21.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        qpms = 1
        zdh = False
        Form21.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form34.Show()
    End Sub

    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or &H80
            Return cp
        End Get
    End Property
End Class