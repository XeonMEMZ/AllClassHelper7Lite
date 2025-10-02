Imports System.Drawing
Imports System.IO
Imports System.Reflection.Emit
Public Class Form22
    Dim speed As Double
    Dim timeline As Integer

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Alt Or Keys.F4) Then
            Return True
        Else
            Return MyBase.ProcessCmdKey(msg, keyData)
        End If
    End Function

    Private Sub Form22_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Width = 8
        Me.Height = allkbh
        Me.Location = New Point(My.Computer.Screen.Bounds.Size.Width - 113 - Me.Width, 0)
        speed = 0
        Try
            If fricls = 0 Then
                If TimeOfDay < CDate(zxtime("zm1s")) Then
                    timeline = 41
                ElseIf CDate(zxtime("zm1s")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zm1x")) Then
                    timeline = 41 + 41 / DateDiff(DateInterval.Minute, CDate(zxtime("zm1s")), CDate(zxtime("zm1x"))) * (DateDiff(DateInterval.Minute, CDate(zxtime("zm1s")), CDate(zxtime("zm1x"))) - DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm1x"))))
                ElseIf CDate(zxtime("zm1x")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zm2s")) Then
                    timeline = 82
                ElseIf CDate(zxtime("zm2s")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zm2x")) Then
                    timeline = 82 + 41 / DateDiff(DateInterval.Minute, CDate(zxtime("zm2s")), CDate(zxtime("zm2x"))) * (DateDiff(DateInterval.Minute, CDate(zxtime("zm2s")), CDate(zxtime("zm2x"))) - DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm2x"))))
                ElseIf CDate(zxtime("zm2x")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zm3s")) Then
                    timeline = 123
                ElseIf CDate(zxtime("zm3s")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zm3x")) Then
                    timeline = 123 + 41 / DateDiff(DateInterval.Minute, CDate(zxtime("zm3s")), CDate(zxtime("zm3x"))) * (DateDiff(DateInterval.Minute, CDate(zxtime("zm3s")), CDate(zxtime("zm3x"))) - DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm3x"))))
                ElseIf CDate(zxtime("zm3x")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zm4s")) Then
                    timeline = 164
                ElseIf CDate(zxtime("zm4s")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zm4x")) Then
                    timeline = 164 + 41 / DateDiff(DateInterval.Minute, CDate(zxtime("zm4s")), CDate(zxtime("zm4x"))) * (DateDiff(DateInterval.Minute, CDate(zxtime("zm4s")), CDate(zxtime("zm4x"))) - DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm4x"))))
                ElseIf CDate(zxtime("zm4x")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zm5s")) Then
                    timeline = 205
                ElseIf CDate(zxtime("zm5s")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zm5x")) Then
                    timeline = 205 + 41 / DateDiff(DateInterval.Minute, CDate(zxtime("zm5s")), CDate(zxtime("zm5x"))) * (DateDiff(DateInterval.Minute, CDate(zxtime("zm5s")), CDate(zxtime("zm5x"))) - DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm5x"))))
                ElseIf CDate(zxtime("zm5x")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zm6s")) Then
                    timeline = 246
                ElseIf CDate(zxtime("zm6s")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zm6x")) Then
                    timeline = 246 + 41 / DateDiff(DateInterval.Minute, CDate(zxtime("zm6s")), CDate(zxtime("zm6x"))) * (DateDiff(DateInterval.Minute, CDate(zxtime("zm6s")), CDate(zxtime("zm6x"))) - DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm6x"))))
                ElseIf CDate(zxtime("zm6x")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zm7s")) Then
                    timeline = 287
                ElseIf CDate(zxtime("zm7s")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zm7x")) Then
                    timeline = 287 + 41 / DateDiff(DateInterval.Minute, CDate(zxtime("zm7s")), CDate(zxtime("zm7x"))) * (DateDiff(DateInterval.Minute, CDate(zxtime("zm7s")), CDate(zxtime("zm7x"))) - DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm7x"))))
                ElseIf CDate(zxtime("zm7x")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zm8s")) Then
                    timeline = 328
                ElseIf CDate(zxtime("zm8s")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zm8x")) Then
                    timeline = 328 + 41 / DateDiff(DateInterval.Minute, CDate(zxtime("zm8s")), CDate(zxtime("zm8x"))) * (DateDiff(DateInterval.Minute, CDate(zxtime("zm8s")), CDate(zxtime("zm8x"))) - DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm8x"))))
                ElseIf CDate(zxtime("zm8x")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zm9s")) Then
                    timeline = 369
                ElseIf CDate(zxtime("zm9s")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zm9x")) Then
                    timeline = 369 + 41 / DateDiff(DateInterval.Minute, CDate(zxtime("zm9s")), CDate(zxtime("zm9x"))) * (DateDiff(DateInterval.Minute, CDate(zxtime("zm9s")), CDate(zxtime("zm9x"))) - DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm9x"))))
                ElseIf CDate(zxtime("zm9x")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zm10s")) Then
                    timeline = 410
                ElseIf CDate(zxtime("zm10s")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zm10x")) Then
                    timeline = 410 + 41 / DateDiff(DateInterval.Minute, CDate(zxtime("zm10s")), CDate(zxtime("zm10x"))) * (DateDiff(DateInterval.Minute, CDate(zxtime("zm10s")), CDate(zxtime("zm10x"))) - DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm10x"))))
                ElseIf CDate(zxtime("zm10x")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zm11s")) Then
                    timeline = 451
                ElseIf CDate(zxtime("zm11s")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zm11x")) Then
                    timeline = 451 + 41 / DateDiff(DateInterval.Minute, CDate(zxtime("zm11s")), CDate(zxtime("zm11x"))) * (DateDiff(DateInterval.Minute, CDate(zxtime("zm11s")), CDate(zxtime("zm11x"))) - DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm11x"))))
                ElseIf CDate(zxtime("zm11x")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zm12s")) Then
                    timeline = 492
                ElseIf CDate(zxtime("zm12s")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zm12x")) Then
                    timeline = 492 + 41 / DateDiff(DateInterval.Minute, CDate(zxtime("zm12s")), CDate(zxtime("zm12x"))) * (DateDiff(DateInterval.Minute, CDate(zxtime("zm12s")), CDate(zxtime("zm12x"))) - DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm12x"))))
                ElseIf CDate(zxtime("zm12x")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zm13s")) Then
                    timeline = 533
                ElseIf CDate(zxtime("zm13s")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zm13x")) Then
                    timeline = 533 + 41 / DateDiff(DateInterval.Minute, CDate(zxtime("zm13s")), CDate(zxtime("zm13x"))) * (DateDiff(DateInterval.Minute, CDate(zxtime("zm13s")), CDate(zxtime("zm13x"))) - DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm13x"))))
                ElseIf CDate(zxtime("zm13x")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zm14s")) Then
                    timeline = 574
                ElseIf CDate(zxtime("zm14s")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zm14x")) Then
                    timeline = 574 + 41 / DateDiff(DateInterval.Minute, CDate(zxtime("zm14s")), CDate(zxtime("zm14x"))) * (DateDiff(DateInterval.Minute, CDate(zxtime("zm14s")), CDate(zxtime("zm14x"))) - DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm14x"))))
                ElseIf CDate(zxtime("zm14x")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zm15s")) Then
                    timeline = 615
                ElseIf CDate(zxtime("zm15s")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zm15x")) Then
                    timeline = 615 + 41 / DateDiff(DateInterval.Minute, CDate(zxtime("zm15s")), CDate(zxtime("zm15x"))) * (DateDiff(DateInterval.Minute, CDate(zxtime("zm15s")), CDate(zxtime("zm15x"))) - DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm15x"))))
                ElseIf CDate(zxtime("zm15x")) < TimeOfDay Then
                    timeline = 656
                End If
            Else
                If TimeOfDay < CDate(zxtime("zt1s")) Then
                    timeline = 41
                ElseIf CDate(zxtime("zt1s")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zt1x")) Then
                    timeline = 41 + 41 / DateDiff(DateInterval.Minute, CDate(zxtime("zt1s")), CDate(zxtime("zt1x"))) * (DateDiff(DateInterval.Minute, CDate(zxtime("zt1s")), CDate(zxtime("zt1x"))) - DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt1x"))))
                ElseIf CDate(zxtime("zt1x")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zt2s")) Then
                    timeline = 82
                ElseIf CDate(zxtime("zt2s")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zt2x")) Then
                    timeline = 82 + 41 / DateDiff(DateInterval.Minute, CDate(zxtime("zt2s")), CDate(zxtime("zt2x"))) * (DateDiff(DateInterval.Minute, CDate(zxtime("zt2s")), CDate(zxtime("zt2x"))) - DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt2x"))))
                ElseIf CDate(zxtime("zt2x")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zt3s")) Then
                    timeline = 123
                ElseIf CDate(zxtime("zt3s")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zt3x")) Then
                    timeline = 123 + 41 / DateDiff(DateInterval.Minute, CDate(zxtime("zt3s")), CDate(zxtime("zt3x"))) * (DateDiff(DateInterval.Minute, CDate(zxtime("zt3s")), CDate(zxtime("zt3x"))) - DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt3x"))))
                ElseIf CDate(zxtime("zt3x")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zt4s")) Then
                    timeline = 164
                ElseIf CDate(zxtime("zt4s")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zt4x")) Then
                    timeline = 164 + 41 / DateDiff(DateInterval.Minute, CDate(zxtime("zt4s")), CDate(zxtime("zt4x"))) * (DateDiff(DateInterval.Minute, CDate(zxtime("zt4s")), CDate(zxtime("zt4x"))) - DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt4x"))))
                ElseIf CDate(zxtime("zt4x")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zt5s")) Then
                    timeline = 205
                ElseIf CDate(zxtime("zt5s")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zt5x")) Then
                    timeline = 205 + 41 / DateDiff(DateInterval.Minute, CDate(zxtime("zt5s")), CDate(zxtime("zt5x"))) * (DateDiff(DateInterval.Minute, CDate(zxtime("zt5s")), CDate(zxtime("zt5x"))) - DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt5x"))))
                ElseIf CDate(zxtime("zt5x")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zt6s")) Then
                    timeline = 246
                ElseIf CDate(zxtime("zt6s")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zt6x")) Then
                    timeline = 246 + 41 / DateDiff(DateInterval.Minute, CDate(zxtime("zt6s")), CDate(zxtime("zt6x"))) * (DateDiff(DateInterval.Minute, CDate(zxtime("zt6s")), CDate(zxtime("zt6x"))) - DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt6x"))))
                ElseIf CDate(zxtime("zt6x")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zt7s")) Then
                    timeline = 287
                ElseIf CDate(zxtime("zt7s")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zt7x")) Then
                    timeline = 287 + 41 / DateDiff(DateInterval.Minute, CDate(zxtime("zt7s")), CDate(zxtime("zt7x"))) * (DateDiff(DateInterval.Minute, CDate(zxtime("zt7s")), CDate(zxtime("zt7x"))) - DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt7x"))))
                ElseIf CDate(zxtime("zt7x")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zt8s")) Then
                    timeline = 328
                ElseIf CDate(zxtime("zt8s")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zt8x")) Then
                    timeline = 328 + 41 / DateDiff(DateInterval.Minute, CDate(zxtime("zt8s")), CDate(zxtime("zt8x"))) * (DateDiff(DateInterval.Minute, CDate(zxtime("zt8s")), CDate(zxtime("zt8x"))) - DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt8x"))))
                ElseIf CDate(zxtime("zt8x")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zt9s")) Then
                    timeline = 369
                ElseIf CDate(zxtime("zt9s")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zt9x")) Then
                    timeline = 369 + 41 / DateDiff(DateInterval.Minute, CDate(zxtime("zt9s")), CDate(zxtime("zt9x"))) * (DateDiff(DateInterval.Minute, CDate(zxtime("zt9s")), CDate(zxtime("zt9x"))) - DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt9x"))))
                ElseIf CDate(zxtime("zt9x")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zt10s")) Then
                    timeline = 410
                ElseIf CDate(zxtime("zt10s")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zt10x")) Then
                    timeline = 410 + 41 / DateDiff(DateInterval.Minute, CDate(zxtime("zt10s")), CDate(zxtime("zt10x"))) * (DateDiff(DateInterval.Minute, CDate(zxtime("zt10s")), CDate(zxtime("zt10x"))) - DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt10x"))))
                ElseIf CDate(zxtime("zt10x")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zt11s")) Then
                    timeline = 451
                ElseIf CDate(zxtime("zt11s")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zt11x")) Then
                    timeline = 451 + 41 / DateDiff(DateInterval.Minute, CDate(zxtime("zt11s")), CDate(zxtime("zt11x"))) * (DateDiff(DateInterval.Minute, CDate(zxtime("zt11s")), CDate(zxtime("zt11x"))) - DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt11x"))))
                ElseIf CDate(zxtime("zt11x")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zt12s")) Then
                    timeline = 492
                ElseIf CDate(zxtime("zt12s")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zt12x")) Then
                    timeline = 492 + 41 / DateDiff(DateInterval.Minute, CDate(zxtime("zt12s")), CDate(zxtime("zt12x"))) * (DateDiff(DateInterval.Minute, CDate(zxtime("zt12s")), CDate(zxtime("zt12x"))) - DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt12x"))))
                ElseIf CDate(zxtime("zt12x")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zt13s")) Then
                    timeline = 533
                ElseIf CDate(zxtime("zt13s")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zt13x")) Then
                    timeline = 533 + 41 / DateDiff(DateInterval.Minute, CDate(zxtime("zt13s")), CDate(zxtime("zt13x"))) * (DateDiff(DateInterval.Minute, CDate(zxtime("zt13s")), CDate(zxtime("zt13x"))) - DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt13x"))))
                ElseIf CDate(zxtime("zt13x")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zt14s")) Then
                    timeline = 574
                ElseIf CDate(zxtime("zt14s")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zt14x")) Then
                    timeline = 574 + 41 / DateDiff(DateInterval.Minute, CDate(zxtime("zt14s")), CDate(zxtime("zt14x"))) * (DateDiff(DateInterval.Minute, CDate(zxtime("zt14s")), CDate(zxtime("zt14x"))) - DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt14x"))))
                ElseIf CDate(zxtime("zt14x")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zt15s")) Then
                    timeline = 615
                ElseIf CDate(zxtime("zt15s")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zt15x")) Then
                    timeline = 615 + 41 / DateDiff(DateInterval.Minute, CDate(zxtime("zt15s")), CDate(zxtime("zt15x"))) * (DateDiff(DateInterval.Minute, CDate(zxtime("zt15s")), CDate(zxtime("zt15x"))) - DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt15x"))))
                ElseIf CDate(zxtime("zt15x")) < TimeOfDay Then
                    timeline = 656
                End If
            End If
        Catch ex As Exception
            Timer3.Enabled = False
        End Try
    End Sub

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
        Dim cprogress As Graphics = Me.CreateGraphics
        Dim p1 As New Pen(Color.SkyBlue, 8)
        Dim p2 As New Pen(Color.DimGray, 8)
        cprogress.DrawLine(p1, 4, 0, 4, timeline)
        cprogress.DrawLine(p2, 4, timeline, 4, Me.Height)
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Try
            If fricls = 0 Then
                If TimeOfDay < CDate(zxtime("zm1s")) Then
                    timeline = 41
                ElseIf CDate(zxtime("zm1s")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zm1x")) Then
                    timeline = 41 + 41 / DateDiff(DateInterval.Minute, CDate(zxtime("zm1s")), CDate(zxtime("zm1x"))) * (DateDiff(DateInterval.Minute, CDate(zxtime("zm1s")), CDate(zxtime("zm1x"))) - DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm1x"))))
                ElseIf CDate(zxtime("zm1x")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zm2s")) Then
                    timeline = 82
                ElseIf CDate(zxtime("zm2s")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zm2x")) Then
                    timeline = 82 + 41 / DateDiff(DateInterval.Minute, CDate(zxtime("zm2s")), CDate(zxtime("zm2x"))) * (DateDiff(DateInterval.Minute, CDate(zxtime("zm2s")), CDate(zxtime("zm2x"))) - DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm2x"))))
                ElseIf CDate(zxtime("zm2x")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zm3s")) Then
                    timeline = 123
                ElseIf CDate(zxtime("zm3s")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zm3x")) Then
                    timeline = 123 + 41 / DateDiff(DateInterval.Minute, CDate(zxtime("zm3s")), CDate(zxtime("zm3x"))) * (DateDiff(DateInterval.Minute, CDate(zxtime("zm3s")), CDate(zxtime("zm3x"))) - DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm3x"))))
                ElseIf CDate(zxtime("zm3x")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zm4s")) Then
                    timeline = 164
                ElseIf CDate(zxtime("zm4s")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zm4x")) Then
                    timeline = 164 + 41 / DateDiff(DateInterval.Minute, CDate(zxtime("zm4s")), CDate(zxtime("zm4x"))) * (DateDiff(DateInterval.Minute, CDate(zxtime("zm4s")), CDate(zxtime("zm4x"))) - DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm4x"))))
                ElseIf CDate(zxtime("zm4x")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zm5s")) Then
                    timeline = 205
                ElseIf CDate(zxtime("zm5s")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zm5x")) Then
                    timeline = 205 + 41 / DateDiff(DateInterval.Minute, CDate(zxtime("zm5s")), CDate(zxtime("zm5x"))) * (DateDiff(DateInterval.Minute, CDate(zxtime("zm5s")), CDate(zxtime("zm5x"))) - DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm5x"))))
                ElseIf CDate(zxtime("zm5x")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zm6s")) Then
                    timeline = 246
                ElseIf CDate(zxtime("zm6s")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zm6x")) Then
                    timeline = 246 + 41 / DateDiff(DateInterval.Minute, CDate(zxtime("zm6s")), CDate(zxtime("zm6x"))) * (DateDiff(DateInterval.Minute, CDate(zxtime("zm6s")), CDate(zxtime("zm6x"))) - DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm6x"))))
                ElseIf CDate(zxtime("zm6x")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zm7s")) Then
                    timeline = 287
                ElseIf CDate(zxtime("zm7s")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zm7x")) Then
                    timeline = 287 + 41 / DateDiff(DateInterval.Minute, CDate(zxtime("zm7s")), CDate(zxtime("zm7x"))) * (DateDiff(DateInterval.Minute, CDate(zxtime("zm7s")), CDate(zxtime("zm7x"))) - DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm7x"))))
                ElseIf CDate(zxtime("zm7x")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zm8s")) Then
                    timeline = 328
                ElseIf CDate(zxtime("zm8s")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zm8x")) Then
                    timeline = 328 + 41 / DateDiff(DateInterval.Minute, CDate(zxtime("zm8s")), CDate(zxtime("zm8x"))) * (DateDiff(DateInterval.Minute, CDate(zxtime("zm8s")), CDate(zxtime("zm8x"))) - DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm8x"))))
                ElseIf CDate(zxtime("zm8x")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zm9s")) Then
                    timeline = 369
                ElseIf CDate(zxtime("zm9s")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zm9x")) Then
                    timeline = 369 + 41 / DateDiff(DateInterval.Minute, CDate(zxtime("zm9s")), CDate(zxtime("zm9x"))) * (DateDiff(DateInterval.Minute, CDate(zxtime("zm9s")), CDate(zxtime("zm9x"))) - DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm9x"))))
                ElseIf CDate(zxtime("zm9x")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zm10s")) Then
                    timeline = 410
                ElseIf CDate(zxtime("zm10s")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zm10x")) Then
                    timeline = 410 + 41 / DateDiff(DateInterval.Minute, CDate(zxtime("zm10s")), CDate(zxtime("zm10x"))) * (DateDiff(DateInterval.Minute, CDate(zxtime("zm10s")), CDate(zxtime("zm10x"))) - DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm10x"))))
                ElseIf CDate(zxtime("zm10x")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zm11s")) Then
                    timeline = 451
                ElseIf CDate(zxtime("zm11s")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zm11x")) Then
                    timeline = 451 + 41 / DateDiff(DateInterval.Minute, CDate(zxtime("zm11s")), CDate(zxtime("zm11x"))) * (DateDiff(DateInterval.Minute, CDate(zxtime("zm11s")), CDate(zxtime("zm11x"))) - DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm11x"))))
                ElseIf CDate(zxtime("zm11x")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zm12s")) Then
                    timeline = 492
                ElseIf CDate(zxtime("zm12s")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zm12x")) Then
                    timeline = 492 + 41 / DateDiff(DateInterval.Minute, CDate(zxtime("zm12s")), CDate(zxtime("zm12x"))) * (DateDiff(DateInterval.Minute, CDate(zxtime("zm12s")), CDate(zxtime("zm12x"))) - DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm12x"))))
                ElseIf CDate(zxtime("zm12x")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zm13s")) Then
                    timeline = 533
                ElseIf CDate(zxtime("zm13s")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zm13x")) Then
                    timeline = 533 + 41 / DateDiff(DateInterval.Minute, CDate(zxtime("zm13s")), CDate(zxtime("zm13x"))) * (DateDiff(DateInterval.Minute, CDate(zxtime("zm13s")), CDate(zxtime("zm13x"))) - DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm13x"))))
                ElseIf CDate(zxtime("zm13x")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zm14s")) Then
                    timeline = 574
                ElseIf CDate(zxtime("zm14s")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zm14x")) Then
                    timeline = 574 + 41 / DateDiff(DateInterval.Minute, CDate(zxtime("zm14s")), CDate(zxtime("zm14x"))) * (DateDiff(DateInterval.Minute, CDate(zxtime("zm14s")), CDate(zxtime("zm14x"))) - DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm14x"))))
                ElseIf CDate(zxtime("zm14x")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zm15s")) Then
                    timeline = 615
                ElseIf CDate(zxtime("zm15s")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zm15x")) Then
                    timeline = 615 + 41 / DateDiff(DateInterval.Minute, CDate(zxtime("zm15s")), CDate(zxtime("zm15x"))) * (DateDiff(DateInterval.Minute, CDate(zxtime("zm15s")), CDate(zxtime("zm15x"))) - DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm15x"))))
                ElseIf CDate(zxtime("zm15x")) < TimeOfDay Then
                    timeline = 656
                End If
            Else
                If TimeOfDay < CDate(zxtime("zt1s")) Then
                    timeline = 41
                ElseIf CDate(zxtime("zt1s")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zt1x")) Then
                    timeline = 41 + 41 / DateDiff(DateInterval.Minute, CDate(zxtime("zt1s")), CDate(zxtime("zt1x"))) * (DateDiff(DateInterval.Minute, CDate(zxtime("zt1s")), CDate(zxtime("zt1x"))) - DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt1x"))))
                ElseIf CDate(zxtime("zt1x")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zt2s")) Then
                    timeline = 82
                ElseIf CDate(zxtime("zt2s")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zt2x")) Then
                    timeline = 82 + 41 / DateDiff(DateInterval.Minute, CDate(zxtime("zt2s")), CDate(zxtime("zt2x"))) * (DateDiff(DateInterval.Minute, CDate(zxtime("zt2s")), CDate(zxtime("zt2x"))) - DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt2x"))))
                ElseIf CDate(zxtime("zt2x")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zt3s")) Then
                    timeline = 123
                ElseIf CDate(zxtime("zt3s")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zt3x")) Then
                    timeline = 123 + 41 / DateDiff(DateInterval.Minute, CDate(zxtime("zt3s")), CDate(zxtime("zt3x"))) * (DateDiff(DateInterval.Minute, CDate(zxtime("zt3s")), CDate(zxtime("zt3x"))) - DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt3x"))))
                ElseIf CDate(zxtime("zt3x")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zt4s")) Then
                    timeline = 164
                ElseIf CDate(zxtime("zt4s")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zt4x")) Then
                    timeline = 164 + 41 / DateDiff(DateInterval.Minute, CDate(zxtime("zt4s")), CDate(zxtime("zt4x"))) * (DateDiff(DateInterval.Minute, CDate(zxtime("zt4s")), CDate(zxtime("zt4x"))) - DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt4x"))))
                ElseIf CDate(zxtime("zt4x")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zt5s")) Then
                    timeline = 205
                ElseIf CDate(zxtime("zt5s")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zt5x")) Then
                    timeline = 205 + 41 / DateDiff(DateInterval.Minute, CDate(zxtime("zt5s")), CDate(zxtime("zt5x"))) * (DateDiff(DateInterval.Minute, CDate(zxtime("zt5s")), CDate(zxtime("zt5x"))) - DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt5x"))))
                ElseIf CDate(zxtime("zt5x")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zt6s")) Then
                    timeline = 246
                ElseIf CDate(zxtime("zt6s")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zt6x")) Then
                    timeline = 246 + 41 / DateDiff(DateInterval.Minute, CDate(zxtime("zt6s")), CDate(zxtime("zt6x"))) * (DateDiff(DateInterval.Minute, CDate(zxtime("zt6s")), CDate(zxtime("zt6x"))) - DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt6x"))))
                ElseIf CDate(zxtime("zt6x")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zt7s")) Then
                    timeline = 287
                ElseIf CDate(zxtime("zt7s")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zt7x")) Then
                    timeline = 287 + 41 / DateDiff(DateInterval.Minute, CDate(zxtime("zt7s")), CDate(zxtime("zt7x"))) * (DateDiff(DateInterval.Minute, CDate(zxtime("zt7s")), CDate(zxtime("zt7x"))) - DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt7x"))))
                ElseIf CDate(zxtime("zt7x")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zt8s")) Then
                    timeline = 328
                ElseIf CDate(zxtime("zt8s")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zt8x")) Then
                    timeline = 328 + 41 / DateDiff(DateInterval.Minute, CDate(zxtime("zt8s")), CDate(zxtime("zt8x"))) * (DateDiff(DateInterval.Minute, CDate(zxtime("zt8s")), CDate(zxtime("zt8x"))) - DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt8x"))))
                ElseIf CDate(zxtime("zt8x")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zt9s")) Then
                    timeline = 369
                ElseIf CDate(zxtime("zt9s")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zt9x")) Then
                    timeline = 369 + 41 / DateDiff(DateInterval.Minute, CDate(zxtime("zt9s")), CDate(zxtime("zt9x"))) * (DateDiff(DateInterval.Minute, CDate(zxtime("zt9s")), CDate(zxtime("zt9x"))) - DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt9x"))))
                ElseIf CDate(zxtime("zt9x")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zt10s")) Then
                    timeline = 410
                ElseIf CDate(zxtime("zt10s")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zt10x")) Then
                    timeline = 410 + 41 / DateDiff(DateInterval.Minute, CDate(zxtime("zt10s")), CDate(zxtime("zt10x"))) * (DateDiff(DateInterval.Minute, CDate(zxtime("zt10s")), CDate(zxtime("zt10x"))) - DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt10x"))))
                ElseIf CDate(zxtime("zt10x")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zt11s")) Then
                    timeline = 451
                ElseIf CDate(zxtime("zt11s")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zt11x")) Then
                    timeline = 451 + 41 / DateDiff(DateInterval.Minute, CDate(zxtime("zt11s")), CDate(zxtime("zt11x"))) * (DateDiff(DateInterval.Minute, CDate(zxtime("zt11s")), CDate(zxtime("zt11x"))) - DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt11x"))))
                ElseIf CDate(zxtime("zt11x")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zt12s")) Then
                    timeline = 492
                ElseIf CDate(zxtime("zt12s")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zt12x")) Then
                    timeline = 492 + 41 / DateDiff(DateInterval.Minute, CDate(zxtime("zt12s")), CDate(zxtime("zt12x"))) * (DateDiff(DateInterval.Minute, CDate(zxtime("zt12s")), CDate(zxtime("zt12x"))) - DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt12x"))))
                ElseIf CDate(zxtime("zt12x")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zt13s")) Then
                    timeline = 533
                ElseIf CDate(zxtime("zt13s")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zt13x")) Then
                    timeline = 533 + 41 / DateDiff(DateInterval.Minute, CDate(zxtime("zt13s")), CDate(zxtime("zt13x"))) * (DateDiff(DateInterval.Minute, CDate(zxtime("zt13s")), CDate(zxtime("zt13x"))) - DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt13x"))))
                ElseIf CDate(zxtime("zt13x")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zt14s")) Then
                    timeline = 574
                ElseIf CDate(zxtime("zt14s")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zt14x")) Then
                    timeline = 574 + 41 / DateDiff(DateInterval.Minute, CDate(zxtime("zt14s")), CDate(zxtime("zt14x"))) * (DateDiff(DateInterval.Minute, CDate(zxtime("zt14s")), CDate(zxtime("zt14x"))) - DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt14x"))))
                ElseIf CDate(zxtime("zt14x")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zt15s")) Then
                    timeline = 615
                ElseIf CDate(zxtime("zt15s")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zt15x")) Then
                    timeline = 615 + 41 / DateDiff(DateInterval.Minute, CDate(zxtime("zt15s")), CDate(zxtime("zt15x"))) * (DateDiff(DateInterval.Minute, CDate(zxtime("zt15s")), CDate(zxtime("zt15x"))) - DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt15x"))))
                ElseIf CDate(zxtime("zt15x")) < TimeOfDay Then
                    timeline = 656
                End If
            End If
        Catch ex As Exception
            Timer3.Enabled = False
        End Try
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

    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or &H80
            Return cp
        End Get
    End Property
End Class