Imports System.IO
Imports System.Reflection.Emit

Public Class Form23
    Dim speed As Double

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Alt Or Keys.F4) Then
            Return True
        Else
            Return MyBase.ProcessCmdKey(msg, keyData)
        End If
    End Function

    Private Sub Form23_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Width = 44
        Me.Height = allkbh
        Me.Location = New Point(My.Computer.Screen.Bounds.Size.Width - 113 - 8 - Me.Width, 0)
        speed = 0
        Label1.Height = Me.Height
        Try
            If fricls = 0 Then
                If TimeOfDay < CDate(zxtime("zm1s")) Then
                    If DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm1s"))) + 1 > 99 Then
                        Label1.Text = "距上课还有" & 99 & "分钟"
                    Else
                        Label1.Text = "距上课还有" & DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm1s"))) + 1 & "分钟"
                    End If
                ElseIf CDate(zxtime("zm1s")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zm1x")) Then
                    If DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm1x"))) + 1 > 99 Then
                        Label1.Text = "距下课还有" & 99 & "分钟"
                    Else
                        Label1.Text = "距下课还有" & DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm1x"))) + 1 & "分钟"
                    End If
                ElseIf CDate(zxtime("zm1x")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zm2s")) Then
                    If DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm2s"))) + 1 > 99 Then
                        Label1.Text = "距上课还有" & 99 & "分钟"
                    Else
                        Label1.Text = "距上课还有" & DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm2s"))) + 1 & "分钟"
                    End If
                ElseIf CDate(zxtime("zm2s")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zm2x")) Then
                    If DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm2x"))) + 1 > 99 Then
                        Label1.Text = "距下课还有" & 99 & "分钟"
                    Else
                        Label1.Text = "距下课还有" & DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm2x"))) + 1 & "分钟"
                    End If
                ElseIf CDate(zxtime("zm2x")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zm3s")) Then
                    If DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm3s"))) + 1 > 99 Then
                        Label1.Text = "距上课还有" & 99 & "分钟"
                    Else
                        Label1.Text = "距上课还有" & DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm3s"))) + 1 & "分钟"
                    End If
                ElseIf CDate(zxtime("zm3s")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zm3x")) Then
                    If DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm3x"))) + 1 > 99 Then
                        Label1.Text = "距下课还有" & 99 & "分钟"
                    Else
                        Label1.Text = "距下课还有" & DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm3x"))) + 1 & "分钟"
                    End If
                ElseIf CDate(zxtime("zm3x")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zm4s")) Then
                    If DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm4s"))) + 1 > 99 Then
                        Label1.Text = "距上课还有" & 99 & "分钟"
                    Else
                        Label1.Text = "距上课还有" & DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm4s"))) + 1 & "分钟"
                    End If
                ElseIf CDate(zxtime("zm4s")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zm4x")) Then
                    If DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm4x"))) + 1 > 99 Then
                        Label1.Text = "距下课还有" & 99 & "分钟"
                    Else
                        Label1.Text = "距下课还有" & DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm4x"))) + 1 & "分钟"
                    End If
                ElseIf CDate(zxtime("zm4x")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zm5s")) Then
                    If DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm5s"))) + 1 > 99 Then
                        Label1.Text = "距上课还有" & 99 & "分钟"
                    Else
                        Label1.Text = "距上课还有" & DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm5s"))) + 1 & "分钟"
                    End If
                ElseIf CDate(zxtime("zm5s")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zm5x")) Then
                    If DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm5x"))) + 1 > 99 Then
                        Label1.Text = "距下课还有" & 99 & "分钟"
                    Else
                        Label1.Text = "距下课还有" & DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm5x"))) + 1 & "分钟"
                    End If
                ElseIf CDate(zxtime("zm5x")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zm6s")) Then
                    If DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm6s"))) + 1 > 99 Then
                        Label1.Text = "距上课还有" & 99 & "分钟"
                    Else
                        Label1.Text = "距上课还有" & DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm6s"))) + 1 & "分钟"
                    End If
                ElseIf CDate(zxtime("zm6s")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zm6x")) Then
                    If DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm6x"))) + 1 > 99 Then
                        Label1.Text = "距下课还有" & 99 & "分钟"
                    Else
                        Label1.Text = "距下课还有" & DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm6x"))) + 1 & "分钟"
                    End If
                ElseIf CDate(zxtime("zm6x")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zm7s")) Then
                    If DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm7s"))) + 1 > 99 Then
                        Label1.Text = "距上课还有" & 99 & "分钟"
                    Else
                        Label1.Text = "距上课还有" & DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm7s"))) + 1 & "分钟"
                    End If
                ElseIf CDate(zxtime("zm7s")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zm7x")) Then
                    If DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm7x"))) + 1 > 99 Then
                        Label1.Text = "距下课还有" & 99 & "分钟"
                    Else
                        Label1.Text = "距下课还有" & DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm7x"))) + 1 & "分钟"
                    End If
                ElseIf CDate(zxtime("zm7x")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zm8s")) Then
                    If DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm8s"))) + 1 > 99 Then
                        Label1.Text = "距上课还有" & 99 & "分钟"
                    Else
                        Label1.Text = "距上课还有" & DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm8s"))) + 1 & "分钟"
                    End If
                ElseIf CDate(zxtime("zm8s")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zm8x")) Then
                    If DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm8x"))) + 1 > 99 Then
                        Label1.Text = "距下课还有" & 99 & "分钟"
                    Else
                        Label1.Text = "距下课还有" & DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm8x"))) + 1 & "分钟"
                    End If
                ElseIf CDate(zxtime("zm8x")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zm9s")) Then
                    If DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm9s"))) + 1 > 99 Then
                        Label1.Text = "距上课还有" & 99 & "分钟"
                    Else
                        Label1.Text = "距上课还有" & DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm9s"))) + 1 & "分钟"
                    End If
                ElseIf CDate(zxtime("zm9s")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zm9x")) Then
                    If DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm9x"))) + 1 > 99 Then
                        Label1.Text = "距下课还有" & 99 & "分钟"
                    Else
                        Label1.Text = "距下课还有" & DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm9x"))) + 1 & "分钟"
                    End If
                ElseIf CDate(zxtime("zm9x")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zm10s")) Then
                    If DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm10s"))) + 1 > 99 Then
                        Label1.Text = "距上课还有" & 99 & "分钟"
                    Else
                        Label1.Text = "距上课还有" & DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm10s"))) + 1 & "分钟"
                    End If
                ElseIf CDate(zxtime("zm10s")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zm10x")) Then
                    If DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm10x"))) + 1 > 99 Then
                        Label1.Text = "距下课还有" & 99 & "分钟"
                    Else
                        Label1.Text = "距下课还有" & DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm10x"))) + 1 & "分钟"
                    End If
                ElseIf CDate(zxtime("zm10x")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zm11s")) Then
                    If DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm11s"))) + 1 > 99 Then
                        Label1.Text = "距上课还有" & 99 & "分钟"
                    Else
                        Label1.Text = "距上课还有" & DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm11s"))) + 1 & "分钟"
                    End If
                ElseIf CDate(zxtime("zm11s")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zm11x")) Then
                    If DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm11x"))) + 1 > 99 Then
                        Label1.Text = "距下课还有" & 99 & "分钟"
                    Else
                        Label1.Text = "距下课还有" & DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm11x"))) + 1 & "分钟"
                    End If
                ElseIf CDate(zxtime("zm11x")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zm12s")) Then
                    If DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm12s"))) + 1 > 99 Then
                        Label1.Text = "距上课还有" & 99 & "分钟"
                    Else
                        Label1.Text = "距上课还有" & DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm12s"))) + 1 & "分钟"
                    End If
                ElseIf CDate(zxtime("zm12s")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zm12x")) Then
                    If DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm12x"))) + 1 > 99 Then
                        Label1.Text = "距下课还有" & 99 & "分钟"
                    Else
                        Label1.Text = "距下课还有" & DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm12x"))) + 1 & "分钟"
                    End If
                ElseIf CDate(zxtime("zm12x")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zm13s")) Then
                    If DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm13s"))) + 1 > 99 Then
                        Label1.Text = "距上课还有" & 99 & "分钟"
                    Else
                        Label1.Text = "距上课还有" & DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm13s"))) + 1 & "分钟"
                    End If
                ElseIf CDate(zxtime("zm13s")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zm13x")) Then
                    If DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm13x"))) + 1 > 99 Then
                        Label1.Text = "距下课还有" & 99 & "分钟"
                    Else
                        Label1.Text = "距下课还有" & DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm13x"))) + 1 & "分钟"
                    End If
                ElseIf CDate(zxtime("zm13x")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zm14s")) Then
                    If DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm14s"))) + 1 > 99 Then
                        Label1.Text = "距上课还有" & 99 & "分钟"
                    Else
                        Label1.Text = "距上课还有" & DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm14s"))) + 1 & "分钟"
                    End If
                ElseIf CDate(zxtime("zm14s")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zm14x")) Then
                    If DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm14x"))) + 1 > 99 Then
                        Label1.Text = "距下课还有" & 99 & "分钟"
                    Else
                        Label1.Text = "距下课还有" & DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm14x"))) + 1 & "分钟"
                    End If
                ElseIf CDate(zxtime("zm14x")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zm15s")) Then
                    If DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm15s"))) + 1 > 99 Then
                        Label1.Text = "距上课还有" & 99 & "分钟"
                    Else
                        Label1.Text = "距上课还有" & DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm15s"))) + 1 & "分钟"
                    End If
                ElseIf CDate(zxtime("zm15s")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zm15x")) Then
                    If DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm15x"))) + 1 > 99 Then
                        Label1.Text = "距下课还有" & 99 & "分钟"
                    Else
                        Label1.Text = "距下课还有" & DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm15x"))) + 1 & "分钟"
                    End If
                ElseIf CDate(zxtime("zm15x")) < TimeOfDay Then
                    Label1.Text = "距下课还有" & 0 & "分钟"
                End If
            Else
                If TimeOfDay < CDate(zxtime("zt1s")) Then
                    If DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt1s"))) + 1 > 99 Then
                        Label1.Text = "距上课还有" & 99 & "分钟"
                    Else
                        Label1.Text = "距上课还有" & DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt1s"))) + 1 & "分钟"
                    End If
                ElseIf CDate(zxtime("zt1s")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zt1x")) Then
                    If DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt1x"))) + 1 > 99 Then
                        Label1.Text = "距下课还有" & 99 & "分钟"
                    Else
                        Label1.Text = "距下课还有" & DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt1x"))) + 1 & "分钟"
                    End If
                ElseIf CDate(zxtime("zt1x")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zt2s")) Then
                    If DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt2s"))) + 1 > 99 Then
                        Label1.Text = "距上课还有" & 99 & "分钟"
                    Else
                        Label1.Text = "距上课还有" & DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt2s"))) + 1 & "分钟"
                    End If
                ElseIf CDate(zxtime("zt2s")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zt2x")) Then
                    If DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt2x"))) + 1 > 99 Then
                        Label1.Text = "距下课还有" & 99 & "分钟"
                    Else
                        Label1.Text = "距下课还有" & DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt2x"))) + 1 & "分钟"
                    End If
                ElseIf CDate(zxtime("zt2x")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zt3s")) Then
                    If DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt3s"))) + 1 > 99 Then
                        Label1.Text = "距上课还有" & 99 & "分钟"
                    Else
                        Label1.Text = "距上课还有" & DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt3s"))) + 1 & "分钟"
                    End If
                ElseIf CDate(zxtime("zt3s")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zt3x")) Then
                    If DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt3x"))) + 1 > 99 Then
                        Label1.Text = "距下课还有" & 99 & "分钟"
                    Else
                        Label1.Text = "距下课还有" & DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt3x"))) + 1 & "分钟"
                    End If
                ElseIf CDate(zxtime("zt3x")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zt4s")) Then
                    If DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt4s"))) + 1 > 99 Then
                        Label1.Text = "距上课还有" & 99 & "分钟"
                    Else
                        Label1.Text = "距上课还有" & DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt4s"))) + 1 & "分钟"
                    End If
                ElseIf CDate(zxtime("zt4s")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zt4x")) Then
                    If DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt4x"))) + 1 > 99 Then
                        Label1.Text = "距下课还有" & 99 & "分钟"
                    Else
                        Label1.Text = "距下课还有" & DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt4x"))) + 1 & "分钟"
                    End If
                ElseIf CDate(zxtime("zt4x")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zt5s")) Then
                    If DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt5s"))) + 1 > 99 Then
                        Label1.Text = "距上课还有" & 99 & "分钟"
                    Else
                        Label1.Text = "距上课还有" & DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt5s"))) + 1 & "分钟"
                    End If
                ElseIf CDate(zxtime("zt5s")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zt5x")) Then
                    If DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt5x"))) + 1 > 99 Then
                        Label1.Text = "距下课还有" & 99 & "分钟"
                    Else
                        Label1.Text = "距下课还有" & DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt5x"))) + 1 & "分钟"
                    End If
                ElseIf CDate(zxtime("zt5x")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zt6s")) Then
                    If DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt6s"))) + 1 > 99 Then
                        Label1.Text = "距上课还有" & 99 & "分钟"
                    Else
                        Label1.Text = "距上课还有" & DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt6s"))) + 1 & "分钟"
                    End If
                ElseIf CDate(zxtime("zt6s")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zt6x")) Then
                    If DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt6x"))) + 1 > 99 Then
                        Label1.Text = "距下课还有" & 99 & "分钟"
                    Else
                        Label1.Text = "距下课还有" & DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt6x"))) + 1 & "分钟"
                    End If
                ElseIf CDate(zxtime("zt6x")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zt7s")) Then
                    If DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt7s"))) + 1 > 99 Then
                        Label1.Text = "距上课还有" & 99 & "分钟"
                    Else
                        Label1.Text = "距上课还有" & DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt7s"))) + 1 & "分钟"
                    End If
                ElseIf CDate(zxtime("zt7s")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zt7x")) Then
                    If DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt7x"))) + 1 > 99 Then
                        Label1.Text = "距下课还有" & 99 & "分钟"
                    Else
                        Label1.Text = "距下课还有" & DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt7x"))) + 1 & "分钟"
                    End If
                ElseIf CDate(zxtime("zt7x")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zt8s")) Then
                    If DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt8s"))) + 1 > 99 Then
                        Label1.Text = "距上课还有" & 99 & "分钟"
                    Else
                        Label1.Text = "距上课还有" & DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt8s"))) + 1 & "分钟"
                    End If
                ElseIf CDate(zxtime("zt8s")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zt8x")) Then
                    If DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt8x"))) + 1 > 99 Then
                        Label1.Text = "距下课还有" & 99 & "分钟"
                    Else
                        Label1.Text = "距下课还有" & DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt8x"))) + 1 & "分钟"
                    End If
                ElseIf CDate(zxtime("zt8x")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zt9s")) Then
                    If DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt9s"))) + 1 > 99 Then
                        Label1.Text = "距上课还有" & 99 & "分钟"
                    Else
                        Label1.Text = "距上课还有" & DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt9s"))) + 1 & "分钟"
                    End If
                ElseIf CDate(zxtime("zt9s")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zt9x")) Then
                    If DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt9x"))) + 1 > 99 Then
                        Label1.Text = "距下课还有" & 99 & "分钟"
                    Else
                        Label1.Text = "距下课还有" & DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt9x"))) + 1 & "分钟"
                    End If
                ElseIf CDate(zxtime("zt9x")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zt10s")) Then
                    If DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt10s"))) + 1 > 99 Then
                        Label1.Text = "距上课还有" & 99 & "分钟"
                    Else
                        Label1.Text = "距上课还有" & DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt10s"))) + 1 & "分钟"
                    End If
                ElseIf CDate(zxtime("zt10s")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zt10x")) Then
                    If DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt10x"))) + 1 > 99 Then
                        Label1.Text = "距下课还有" & 99 & "分钟"
                    Else
                        Label1.Text = "距下课还有" & DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt10x"))) + 1 & "分钟"
                    End If
                ElseIf CDate(zxtime("zt10x")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zt11s")) Then
                    If DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt11s"))) + 1 > 99 Then
                        Label1.Text = "距上课还有" & 99 & "分钟"
                    Else
                        Label1.Text = "距上课还有" & DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt11s"))) + 1 & "分钟"
                    End If
                ElseIf CDate(zxtime("zt11s")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zt11x")) Then
                    If DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt11x"))) + 1 > 99 Then
                        Label1.Text = "距下课还有" & 99 & "分钟"
                    Else
                        Label1.Text = "距下课还有" & DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt11x"))) + 1 & "分钟"
                    End If
                ElseIf CDate(zxtime("zt11x")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zt12s")) Then
                    If DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt12s"))) + 1 > 99 Then
                        Label1.Text = "距上课还有" & 99 & "分钟"
                    Else
                        Label1.Text = "距上课还有" & DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt12s"))) + 1 & "分钟"
                    End If
                ElseIf CDate(zxtime("zt12s")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zt12x")) Then
                    If DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt12x"))) + 1 > 99 Then
                        Label1.Text = "距下课还有" & 99 & "分钟"
                    Else
                        Label1.Text = "距下课还有" & DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt12x"))) + 1 & "分钟"
                    End If
                ElseIf CDate(zxtime("zt12x")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zt13s")) Then
                    If DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt13s"))) + 1 > 99 Then
                        Label1.Text = "距上课还有" & 99 & "分钟"
                    Else
                        Label1.Text = "距上课还有" & DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt13s"))) + 1 & "分钟"
                    End If
                ElseIf CDate(zxtime("zt13s")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zt13x")) Then
                    If DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt13x"))) + 1 > 99 Then
                        Label1.Text = "距下课还有" & 99 & "分钟"
                    Else
                        Label1.Text = "距下课还有" & DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt13x"))) + 1 & "分钟"
                    End If
                ElseIf CDate(zxtime("zt13x")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zt14s")) Then
                    If DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt14s"))) + 1 > 99 Then
                        Label1.Text = "距上课还有" & 99 & "分钟"
                    Else
                        Label1.Text = "距上课还有" & DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt14s"))) + 1 & "分钟"
                    End If
                ElseIf CDate(zxtime("zt14s")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zt14x")) Then
                    If DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt14x"))) + 1 > 99 Then
                        Label1.Text = "距下课还有" & 99 & "分钟"
                    Else
                        Label1.Text = "距下课还有" & DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt14x"))) + 1 & "分钟"
                    End If
                ElseIf CDate(zxtime("zt14x")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zt15s")) Then
                    If DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt15s"))) + 1 > 99 Then
                        Label1.Text = "距上课还有" & 99 & "分钟"
                    Else
                        Label1.Text = "距上课还有" & DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt15s"))) + 1 & "分钟"
                    End If
                ElseIf CDate(zxtime("zt15s")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zt15x")) Then
                    If DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt15x"))) + 1 > 99 Then
                        Label1.Text = "距下课还有" & 99 & "分钟"
                    Else
                        Label1.Text = "距下课还有" & DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt15x"))) + 1 & "分钟"
                    End If
                ElseIf CDate(zxtime("zt15x")) < TimeOfDay Then
                    Label1.Text = "距下课还有" & 0 & "分钟"
                End If
            End If
        Catch ex As Exception
            Timer2.Enabled = False
            MessageBox.Show("时间表填写有误，已停止课程倒计时功能" & vbCrLf & "请修改正确后重启软件以启用倒计时功能!", "全能班辅", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If speed + 0.0375 <= 0.75 Then
            speed = speed + 0.0375
            Me.Opacity = speed
        Else
            speed = 1
            Me.Opacity = 0.75
            Form24.Show()
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Try
            If fricls = 0 Then
                If TimeOfDay < CDate(zxtime("zm1s")) Then
                    If DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm1s"))) + 1 > 99 Then
                        Label1.Text = "距上课还有" & 99 & "分钟"
                    Else
                        Label1.Text = "距上课还有" & DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm1s"))) + 1 & "分钟"
                    End If
                ElseIf CDate(zxtime("zm1s")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zm1x")) Then
                    If DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm1x"))) + 1 > 99 Then
                        Label1.Text = "距下课还有" & 99 & "分钟"
                    Else
                        Label1.Text = "距下课还有" & DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm1x"))) + 1 & "分钟"
                    End If
                ElseIf CDate(zxtime("zm1x")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zm2s")) Then
                    If DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm2s"))) + 1 > 99 Then
                        Label1.Text = "距上课还有" & 99 & "分钟"
                    Else
                        Label1.Text = "距上课还有" & DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm2s"))) + 1 & "分钟"
                    End If
                ElseIf CDate(zxtime("zm2s")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zm2x")) Then
                    If DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm2x"))) + 1 > 99 Then
                        Label1.Text = "距下课还有" & 99 & "分钟"
                    Else
                        Label1.Text = "距下课还有" & DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm2x"))) + 1 & "分钟"
                    End If
                ElseIf CDate(zxtime("zm2x")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zm3s")) Then
                    If DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm3s"))) + 1 > 99 Then
                        Label1.Text = "距上课还有" & 99 & "分钟"
                    Else
                        Label1.Text = "距上课还有" & DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm3s"))) + 1 & "分钟"
                    End If
                ElseIf CDate(zxtime("zm3s")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zm3x")) Then
                    If DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm3x"))) + 1 > 99 Then
                        Label1.Text = "距下课还有" & 99 & "分钟"
                    Else
                        Label1.Text = "距下课还有" & DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm3x"))) + 1 & "分钟"
                    End If
                ElseIf CDate(zxtime("zm3x")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zm4s")) Then
                    If DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm4s"))) + 1 > 99 Then
                        Label1.Text = "距上课还有" & 99 & "分钟"
                    Else
                        Label1.Text = "距上课还有" & DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm4s"))) + 1 & "分钟"
                    End If
                ElseIf CDate(zxtime("zm4s")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zm4x")) Then
                    If DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm4x"))) + 1 > 99 Then
                        Label1.Text = "距下课还有" & 99 & "分钟"
                    Else
                        Label1.Text = "距下课还有" & DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm4x"))) + 1 & "分钟"
                    End If
                ElseIf CDate(zxtime("zm4x")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zm5s")) Then
                    If DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm5s"))) + 1 > 99 Then
                        Label1.Text = "距上课还有" & 99 & "分钟"
                    Else
                        Label1.Text = "距上课还有" & DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm5s"))) + 1 & "分钟"
                    End If
                ElseIf CDate(zxtime("zm5s")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zm5x")) Then
                    If DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm5x"))) + 1 > 99 Then
                        Label1.Text = "距下课还有" & 99 & "分钟"
                    Else
                        Label1.Text = "距下课还有" & DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm5x"))) + 1 & "分钟"
                    End If
                ElseIf CDate(zxtime("zm5x")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zm6s")) Then
                    If DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm6s"))) + 1 > 99 Then
                        Label1.Text = "距上课还有" & 99 & "分钟"
                    Else
                        Label1.Text = "距上课还有" & DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm6s"))) + 1 & "分钟"
                    End If
                ElseIf CDate(zxtime("zm6s")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zm6x")) Then
                    If DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm6x"))) + 1 > 99 Then
                        Label1.Text = "距下课还有" & 99 & "分钟"
                    Else
                        Label1.Text = "距下课还有" & DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm6x"))) + 1 & "分钟"
                    End If
                ElseIf CDate(zxtime("zm6x")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zm7s")) Then
                    If DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm7s"))) + 1 > 99 Then
                        Label1.Text = "距上课还有" & 99 & "分钟"
                    Else
                        Label1.Text = "距上课还有" & DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm7s"))) + 1 & "分钟"
                    End If
                ElseIf CDate(zxtime("zm7s")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zm7x")) Then
                    If DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm7x"))) + 1 > 99 Then
                        Label1.Text = "距下课还有" & 99 & "分钟"
                    Else
                        Label1.Text = "距下课还有" & DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm7x"))) + 1 & "分钟"
                    End If
                ElseIf CDate(zxtime("zm7x")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zm8s")) Then
                    If DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm8s"))) + 1 > 99 Then
                        Label1.Text = "距上课还有" & 99 & "分钟"
                    Else
                        Label1.Text = "距上课还有" & DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm8s"))) + 1 & "分钟"
                    End If
                ElseIf CDate(zxtime("zm8s")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zm8x")) Then
                    If DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm8x"))) + 1 > 99 Then
                        Label1.Text = "距下课还有" & 99 & "分钟"
                    Else
                        Label1.Text = "距下课还有" & DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm8x"))) + 1 & "分钟"
                    End If
                ElseIf CDate(zxtime("zm8x")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zm9s")) Then
                    If DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm9s"))) + 1 > 99 Then
                        Label1.Text = "距上课还有" & 99 & "分钟"
                    Else
                        Label1.Text = "距上课还有" & DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm9s"))) + 1 & "分钟"
                    End If
                ElseIf CDate(zxtime("zm9s")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zm9x")) Then
                    If DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm9x"))) + 1 > 99 Then
                        Label1.Text = "距下课还有" & 99 & "分钟"
                    Else
                        Label1.Text = "距下课还有" & DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm9x"))) + 1 & "分钟"
                    End If
                ElseIf CDate(zxtime("zm9x")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zm10s")) Then
                    If DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm10s"))) + 1 > 99 Then
                        Label1.Text = "距上课还有" & 99 & "分钟"
                    Else
                        Label1.Text = "距上课还有" & DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm10s"))) + 1 & "分钟"
                    End If
                ElseIf CDate(zxtime("zm10s")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zm10x")) Then
                    If DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm10x"))) + 1 > 99 Then
                        Label1.Text = "距下课还有" & 99 & "分钟"
                    Else
                        Label1.Text = "距下课还有" & DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm10x"))) + 1 & "分钟"
                    End If
                ElseIf CDate(zxtime("zm10x")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zm11s")) Then
                    If DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm11s"))) + 1 > 99 Then
                        Label1.Text = "距上课还有" & 99 & "分钟"
                    Else
                        Label1.Text = "距上课还有" & DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm11s"))) + 1 & "分钟"
                    End If
                ElseIf CDate(zxtime("zm11s")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zm11x")) Then
                    If DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm11x"))) + 1 > 99 Then
                        Label1.Text = "距下课还有" & 99 & "分钟"
                    Else
                        Label1.Text = "距下课还有" & DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm11x"))) + 1 & "分钟"
                    End If
                ElseIf CDate(zxtime("zm11x")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zm12s")) Then
                    If DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm12s"))) + 1 > 99 Then
                        Label1.Text = "距上课还有" & 99 & "分钟"
                    Else
                        Label1.Text = "距上课还有" & DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm12s"))) + 1 & "分钟"
                    End If
                ElseIf CDate(zxtime("zm12s")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zm12x")) Then
                    If DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm12x"))) + 1 > 99 Then
                        Label1.Text = "距下课还有" & 99 & "分钟"
                    Else
                        Label1.Text = "距下课还有" & DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm12x"))) + 1 & "分钟"
                    End If
                ElseIf CDate(zxtime("zm12x")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zm13s")) Then
                    If DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm13s"))) + 1 > 99 Then
                        Label1.Text = "距上课还有" & 99 & "分钟"
                    Else
                        Label1.Text = "距上课还有" & DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm13s"))) + 1 & "分钟"
                    End If
                ElseIf CDate(zxtime("zm13s")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zm13x")) Then
                    If DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm13x"))) + 1 > 99 Then
                        Label1.Text = "距下课还有" & 99 & "分钟"
                    Else
                        Label1.Text = "距下课还有" & DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm13x"))) + 1 & "分钟"
                    End If
                ElseIf CDate(zxtime("zm13x")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zm14s")) Then
                    If DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm14s"))) + 1 > 99 Then
                        Label1.Text = "距上课还有" & 99 & "分钟"
                    Else
                        Label1.Text = "距上课还有" & DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm14s"))) + 1 & "分钟"
                    End If
                ElseIf CDate(zxtime("zm14s")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zm14x")) Then
                    If DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm14x"))) + 1 > 99 Then
                        Label1.Text = "距下课还有" & 99 & "分钟"
                    Else
                        Label1.Text = "距下课还有" & DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm14x"))) + 1 & "分钟"
                    End If
                ElseIf CDate(zxtime("zm14x")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zm15s")) Then
                    If DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm15s"))) + 1 > 99 Then
                        Label1.Text = "距上课还有" & 99 & "分钟"
                    Else
                        Label1.Text = "距上课还有" & DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm15s"))) + 1 & "分钟"
                    End If
                ElseIf CDate(zxtime("zm15s")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zm15x")) Then
                    If DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm15x"))) + 1 > 99 Then
                        Label1.Text = "距下课还有" & 99 & "分钟"
                    Else
                        Label1.Text = "距下课还有" & DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zm15x"))) + 1 & "分钟"
                    End If
                ElseIf CDate(zxtime("zm15x")) < TimeOfDay Then
                    Label1.Text = "距下课还有" & 0 & "分钟"
                End If
            Else
                If TimeOfDay < CDate(zxtime("zt1s")) Then
                    If DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt1s"))) + 1 > 99 Then
                        Label1.Text = "距上课还有" & 99 & "分钟"
                    Else
                        Label1.Text = "距上课还有" & DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt1s"))) + 1 & "分钟"
                    End If
                ElseIf CDate(zxtime("zt1s")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zt1x")) Then
                    If DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt1x"))) + 1 > 99 Then
                        Label1.Text = "距下课还有" & 99 & "分钟"
                    Else
                        Label1.Text = "距下课还有" & DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt1x"))) + 1 & "分钟"
                    End If
                ElseIf CDate(zxtime("zt1x")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zt2s")) Then
                    If DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt2s"))) + 1 > 99 Then
                        Label1.Text = "距上课还有" & 99 & "分钟"
                    Else
                        Label1.Text = "距上课还有" & DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt2s"))) + 1 & "分钟"
                    End If
                ElseIf CDate(zxtime("zt2s")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zt2x")) Then
                    If DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt2x"))) + 1 > 99 Then
                        Label1.Text = "距下课还有" & 99 & "分钟"
                    Else
                        Label1.Text = "距下课还有" & DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt2x"))) + 1 & "分钟"
                    End If
                ElseIf CDate(zxtime("zt2x")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zt3s")) Then
                    If DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt3s"))) + 1 > 99 Then
                        Label1.Text = "距上课还有" & 99 & "分钟"
                    Else
                        Label1.Text = "距上课还有" & DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt3s"))) + 1 & "分钟"
                    End If
                ElseIf CDate(zxtime("zt3s")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zt3x")) Then
                    If DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt3x"))) + 1 > 99 Then
                        Label1.Text = "距下课还有" & 99 & "分钟"
                    Else
                        Label1.Text = "距下课还有" & DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt3x"))) + 1 & "分钟"
                    End If
                ElseIf CDate(zxtime("zt3x")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zt4s")) Then
                    If DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt4s"))) + 1 > 99 Then
                        Label1.Text = "距上课还有" & 99 & "分钟"
                    Else
                        Label1.Text = "距上课还有" & DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt4s"))) + 1 & "分钟"
                    End If
                ElseIf CDate(zxtime("zt4s")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zt4x")) Then
                    If DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt4x"))) + 1 > 99 Then
                        Label1.Text = "距下课还有" & 99 & "分钟"
                    Else
                        Label1.Text = "距下课还有" & DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt4x"))) + 1 & "分钟"
                    End If
                ElseIf CDate(zxtime("zt4x")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zt5s")) Then
                    If DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt5s"))) + 1 > 99 Then
                        Label1.Text = "距上课还有" & 99 & "分钟"
                    Else
                        Label1.Text = "距上课还有" & DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt5s"))) + 1 & "分钟"
                    End If
                ElseIf CDate(zxtime("zt5s")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zt5x")) Then
                    If DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt5x"))) + 1 > 99 Then
                        Label1.Text = "距下课还有" & 99 & "分钟"
                    Else
                        Label1.Text = "距下课还有" & DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt5x"))) + 1 & "分钟"
                    End If
                ElseIf CDate(zxtime("zt5x")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zt6s")) Then
                    If DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt6s"))) + 1 > 99 Then
                        Label1.Text = "距上课还有" & 99 & "分钟"
                    Else
                        Label1.Text = "距上课还有" & DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt6s"))) + 1 & "分钟"
                    End If
                ElseIf CDate(zxtime("zt6s")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zt6x")) Then
                    If DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt6x"))) + 1 > 99 Then
                        Label1.Text = "距下课还有" & 99 & "分钟"
                    Else
                        Label1.Text = "距下课还有" & DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt6x"))) + 1 & "分钟"
                    End If
                ElseIf CDate(zxtime("zt6x")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zt7s")) Then
                    If DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt7s"))) + 1 > 99 Then
                        Label1.Text = "距上课还有" & 99 & "分钟"
                    Else
                        Label1.Text = "距上课还有" & DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt7s"))) + 1 & "分钟"
                    End If
                ElseIf CDate(zxtime("zt7s")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zt7x")) Then
                    If DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt7x"))) + 1 > 99 Then
                        Label1.Text = "距下课还有" & 99 & "分钟"
                    Else
                        Label1.Text = "距下课还有" & DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt7x"))) + 1 & "分钟"
                    End If
                ElseIf CDate(zxtime("zt7x")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zt8s")) Then
                    If DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt8s"))) + 1 > 99 Then
                        Label1.Text = "距上课还有" & 99 & "分钟"
                    Else
                        Label1.Text = "距上课还有" & DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt8s"))) + 1 & "分钟"
                    End If
                ElseIf CDate(zxtime("zt8s")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zt8x")) Then
                    If DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt8x"))) + 1 > 99 Then
                        Label1.Text = "距下课还有" & 99 & "分钟"
                    Else
                        Label1.Text = "距下课还有" & DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt8x"))) + 1 & "分钟"
                    End If
                ElseIf CDate(zxtime("zt8x")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zt9s")) Then
                    If DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt9s"))) + 1 > 99 Then
                        Label1.Text = "距上课还有" & 99 & "分钟"
                    Else
                        Label1.Text = "距上课还有" & DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt9s"))) + 1 & "分钟"
                    End If
                ElseIf CDate(zxtime("zt9s")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zt9x")) Then
                    If DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt9x"))) + 1 > 99 Then
                        Label1.Text = "距下课还有" & 99 & "分钟"
                    Else
                        Label1.Text = "距下课还有" & DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt9x"))) + 1 & "分钟"
                    End If
                ElseIf CDate(zxtime("zt9x")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zt10s")) Then
                    If DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt10s"))) + 1 > 99 Then
                        Label1.Text = "距上课还有" & 99 & "分钟"
                    Else
                        Label1.Text = "距上课还有" & DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt10s"))) + 1 & "分钟"
                    End If
                ElseIf CDate(zxtime("zt10s")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zt10x")) Then
                    If DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt10x"))) + 1 > 99 Then
                        Label1.Text = "距下课还有" & 99 & "分钟"
                    Else
                        Label1.Text = "距下课还有" & DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt10x"))) + 1 & "分钟"
                    End If
                ElseIf CDate(zxtime("zt10x")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zt11s")) Then
                    If DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt11s"))) + 1 > 99 Then
                        Label1.Text = "距上课还有" & 99 & "分钟"
                    Else
                        Label1.Text = "距上课还有" & DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt11s"))) + 1 & "分钟"
                    End If
                ElseIf CDate(zxtime("zt11s")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zt11x")) Then
                    If DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt11x"))) + 1 > 99 Then
                        Label1.Text = "距下课还有" & 99 & "分钟"
                    Else
                        Label1.Text = "距下课还有" & DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt11x"))) + 1 & "分钟"
                    End If
                ElseIf CDate(zxtime("zt11x")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zt12s")) Then
                    If DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt12s"))) + 1 > 99 Then
                        Label1.Text = "距上课还有" & 99 & "分钟"
                    Else
                        Label1.Text = "距上课还有" & DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt12s"))) + 1 & "分钟"
                    End If
                ElseIf CDate(zxtime("zt12s")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zt12x")) Then
                    If DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt12x"))) + 1 > 99 Then
                        Label1.Text = "距下课还有" & 99 & "分钟"
                    Else
                        Label1.Text = "距下课还有" & DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt12x"))) + 1 & "分钟"
                    End If
                ElseIf CDate(zxtime("zt12x")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zt13s")) Then
                    If DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt13s"))) + 1 > 99 Then
                        Label1.Text = "距上课还有" & 99 & "分钟"
                    Else
                        Label1.Text = "距上课还有" & DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt13s"))) + 1 & "分钟"
                    End If
                ElseIf CDate(zxtime("zt13s")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zt13x")) Then
                    If DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt13x"))) + 1 > 99 Then
                        Label1.Text = "距下课还有" & 99 & "分钟"
                    Else
                        Label1.Text = "距下课还有" & DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt13x"))) + 1 & "分钟"
                    End If
                ElseIf CDate(zxtime("zt13x")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zt14s")) Then
                    If DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt14s"))) + 1 > 99 Then
                        Label1.Text = "距上课还有" & 99 & "分钟"
                    Else
                        Label1.Text = "距上课还有" & DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt14s"))) + 1 & "分钟"
                    End If
                ElseIf CDate(zxtime("zt14s")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zt14x")) Then
                    If DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt14x"))) + 1 > 99 Then
                        Label1.Text = "距下课还有" & 99 & "分钟"
                    Else
                        Label1.Text = "距下课还有" & DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt14x"))) + 1 & "分钟"
                    End If
                ElseIf CDate(zxtime("zt14x")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zt15s")) Then
                    If DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt15s"))) + 1 > 99 Then
                        Label1.Text = "距上课还有" & 99 & "分钟"
                    Else
                        Label1.Text = "距上课还有" & DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt15s"))) + 1 & "分钟"
                    End If
                ElseIf CDate(zxtime("zt15s")) <= TimeOfDay And TimeOfDay < CDate(zxtime("zt15x")) Then
                    If DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt15x"))) + 1 > 99 Then
                        Label1.Text = "距下课还有" & 99 & "分钟"
                    Else
                        Label1.Text = "距下课还有" & DateDiff(DateInterval.Minute, TimeOfDay, CDate(zxtime("zt15x"))) + 1 & "分钟"
                    End If
                ElseIf CDate(zxtime("zt15x")) < TimeOfDay Then
                    Label1.Text = "距下课还有" & 0 & "分钟"
                End If
            End If
        Catch ex As Exception
            Timer2.Enabled = False
            MessageBox.Show("时间表填写有误，已停止课程倒计时功能" & vbCrLf & "请修改正确后重启软件以启用倒计时功能!", "全能班辅", MessageBoxButtons.OK, MessageBoxIcon.Warning)
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