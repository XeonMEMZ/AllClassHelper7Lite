Imports System.Reflection.Emit

Public Class Form21
    Dim speed As Double

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Alt Or Keys.F4) Then
            Return True
        Else
            Return MyBase.ProcessCmdKey(msg, keyData)
        End If
    End Function

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If speed + 0.05 <= 1 Then
            speed = speed + 0.05
            Me.Opacity = speed
        Else
            speed = 1
            Me.Opacity = 1
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If speed - 0.05 >= 0 Then
            speed = speed - 0.05
            Me.Opacity = speed
        Else
            speed = 0
            Me.Opacity = 0
            If qpms = 1 Then
                zdh = True
            End If
            Me.Close()
            Timer2.Enabled = False
        End If
    End Sub

    Private Sub Form21_Load(sender As Object, e As EventArgs) Handles Me.Load
        If qpms = 0 Then
            Me.BackgroundImage = Image.FromFile("themes\" & theme & "\boardbg1.jpg")
            PictureBox1.BackgroundImage = Image.FromFile("themes\" & theme & "\gb1.png")
        ElseIf qpms = 1 Then
            Me.BackgroundImage = Image.FromFile("themes\" & theme & "\boardbg2.jpg")
            PictureBox1.BackgroundImage = Image.FromFile("themes\" & theme & "\gb2.png")
        ElseIf qpms = 2 Then
            Me.BackgroundImage = Image.FromFile("themes\" & theme & "\boardbg1.jpg")
            PictureBox1.BackgroundImage = Image.FromFile("themes\" & theme & "\gb1.png")
        End If
        Me.Location = New Point(0, 0)
        Me.Height = My.Computer.Screen.Bounds.Size.Height
        Me.Width = My.Computer.Screen.Bounds.Size.Width
        If qpms = 0 Then
            Label1.Location = New Point(My.Computer.Screen.Bounds.Size.Width / 2 - 294, My.Computer.Screen.Bounds.Size.Height / 2 - 155)
            TextBox1.Location = New Point(My.Computer.Screen.Bounds.Size.Width / 2 - 264, My.Computer.Screen.Bounds.Size.Height / 2 + 15)
            TextBox2.Location = New Point(My.Computer.Screen.Bounds.Size.Width / 2 - 62, My.Computer.Screen.Bounds.Size.Height / 2 + 15)
            TextBox3.Location = New Point(My.Computer.Screen.Bounds.Size.Width / 2 - 264, My.Computer.Screen.Bounds.Size.Height / 2 + 74)
            TextBox4.Location = New Point(My.Computer.Screen.Bounds.Size.Width / 2 - 62, My.Computer.Screen.Bounds.Size.Height / 2 + 74)
            PictureBox1.Location = New Point(My.Computer.Screen.Bounds.Size.Width - 100, My.Computer.Screen.Bounds.Size.Height - 100)
            TextBox1.Visible = True
            TextBox2.Visible = True
            TextBox3.Visible = True
            TextBox4.Visible = True
        ElseIf qpms = 1 Then
            Label1.Location = New Point(My.Computer.Screen.Bounds.Size.Width / 2 - 294, My.Computer.Screen.Bounds.Size.Height / 2 - 100)
            PictureBox1.Location = New Point(My.Computer.Screen.Bounds.Size.Width - 100, My.Computer.Screen.Bounds.Size.Height - 100)
            Label1.ForeColor = Color.Gray
            TextBox1.Visible = False
            TextBox2.Visible = False
            TextBox3.Visible = False
            TextBox4.Visible = False
        ElseIf qpms = 2 Then
            Label1.Visible = False
            PictureBox1.Location = New Point(My.Computer.Screen.Bounds.Size.Width - 100, My.Computer.Screen.Bounds.Size.Height - 100)
            TextBox1.Visible = False
            TextBox2.Visible = False
            TextBox3.Visible = False
            TextBox4.Visible = False
        End If
        If Len(CStr(TimeOfDay)) = 7 Then
            Label1.Text = "0" & TimeOfDay
        Else
            Label1.Text = TimeOfDay
        End If
    End Sub

    Private Sub PictureBox1_DoubleClick(sender As Object, e As EventArgs) Handles PictureBox1.DoubleClick
        If Timer2.Enabled = False Then
            Timer2.Enabled = True
        End If
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        If Len(CStr(TimeOfDay)) = 7 Then
            Label1.Text = "0" & TimeOfDay
        Else
            Label1.Text = TimeOfDay
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