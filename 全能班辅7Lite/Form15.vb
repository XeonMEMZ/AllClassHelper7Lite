Imports System.IO

Public Class Form15
    Dim speed As Double
    Dim sc As Boolean
    Dim bg As String

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Alt Or Keys.F4) Then
            Return True
        Else
            Return MyBase.ProcessCmdKey(msg, keyData)
        End If
    End Function

    Private Sub Form15_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Width = 113
        bg = My.Computer.FileSystem.ReadAllText("themes\" & theme & "\f15color.txt")
        Me.Location = New Point(My.Computer.Screen.Bounds.Size.Width - Me.Width, Form2.Height * 13)
        speed = 0
        allkbh = allkbh + Me.Height
        If hkcout = 15 Then
            Label1.Text = hktext
            If hkcolrc = True Then
                Me.BackColor = hkcolr
            Else
                Me.BackColor = Color.FromArgb(bg)
            End If
        Else
            If Val(allclass("ct")) < 13 Then
                Label1.Text = ""
            Else
                Label1.Text = allclass("c13")
            End If
            Me.BackColor = Color.FromArgb(bg)
        End If
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If speed + 0.05 <= 1 Then
            speed = speed + 0.05
            Me.Opacity = speed
        Else
            speed = 1
            Me.Opacity = 1
            If Val(allclass("ct")) > 13 Then
                If loading = True Then
                    Form16.Show()
                End If
            Else
                Form18.Show()
            End If
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

    Public Function allclass(s$) As String
        Dim classlist As String
        classlist = My.Computer.FileSystem.ReadAllText("data\cl" & dqcl & "\z" & Weekday(Now, FirstDayOfWeek.Monday) & ".txt")
        allclass = Trim(Mid(classlist, InStr(classlist, CStr(s)) + 3, 4))
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If sc = True Then
            kbcout = 15
            kbtext = Label1.Text
            kbcolr = Me.BackColor
            Form19.Show()
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