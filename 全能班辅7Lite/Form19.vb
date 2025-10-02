Imports System.IO

Public Class Form19
    Dim bg As String
    Dim kbcount As Integer
    Dim tss As String
    Dim wk As Integer
    Dim rq As Integer
    Dim d As Integer
    Dim c As Integer
    Dim b As Integer
    Dim ccolr As Boolean

    Private Sub Form19_Load(sender As Object, e As EventArgs) Handles Me.Load
        ccolr = False
        hkcolrc = False
        kbcount = kbcout
        TextBox1.Text = kbtext
        TextBox1.BackColor = kbcolr
        Label3.BackColor = kbcolr
        b = 1
        For d = 1 To 7
            For c = 1 To Val(alldclass("ct", d))
                If b = 1 Then
                    Button2.Text = alldclass("c1", d)
                    b = b + 1
                ElseIf b = 2 Then
                    If Button2.Text <> alldclass("c" & c, d) Then
                        Button3.Text = alldclass("c" & c, d)
                        b = b + 1
                    End If
                ElseIf b = 3 Then
                    If Button2.Text <> alldclass("c" & c, d) And Button3.Text <> alldclass("c" & c, d) Then
                        Button4.Text = alldclass("c" & c, d)
                        b = b + 1
                    End If
                ElseIf b = 4 Then
                    If Button2.Text <> alldclass("c" & c, d) And Button3.Text <> alldclass("c" & c, d) And Button4.Text <> alldclass("c" & c, d) Then
                        Button5.Text = alldclass("c" & c, d)
                        b = b + 1
                    End If
                ElseIf b = 5 Then
                    If Button2.Text <> alldclass("c" & c, d) And Button3.Text <> alldclass("c" & c, d) And Button4.Text <> alldclass("c" & c, d) And Button5.Text <> alldclass("c" & c, d) Then
                        Button6.Text = alldclass("c" & c, d)
                        b = b + 1
                    End If
                ElseIf b = 6 Then
                    If Button2.Text <> alldclass("c" & c, d) And Button3.Text <> alldclass("c" & c, d) And Button4.Text <> alldclass("c" & c, d) And Button5.Text <> alldclass("c" & c, d) And Button6.Text <> alldclass("c" & c, d) Then
                        Button7.Text = alldclass("c" & c, d)
                        b = b + 1
                    End If
                ElseIf b = 7 Then
                    If Button2.Text <> alldclass("c" & c, d) And Button3.Text <> alldclass("c" & c, d) And Button4.Text <> alldclass("c" & c, d) And Button5.Text <> alldclass("c" & c, d) And Button6.Text <> alldclass("c" & c, d) And Button7.Text <> alldclass("c" & c, d) Then
                        Button8.Text = alldclass("c" & c, d)
                        b = b + 1
                    End If
                ElseIf b = 8 Then
                    If Button2.Text <> alldclass("c" & c, d) And Button3.Text <> alldclass("c" & c, d) And Button4.Text <> alldclass("c" & c, d) And Button5.Text <> alldclass("c" & c, d) And Button6.Text <> alldclass("c" & c, d) And Button7.Text <> alldclass("c" & c, d) And Button8.Text <> alldclass("c" & c, d) Then
                        Button9.Text = alldclass("c" & c, d)
                        b = b + 1
                    End If
                ElseIf b = 9 Then
                    If Button2.Text <> alldclass("c" & c, d) And Button3.Text <> alldclass("c" & c, d) And Button4.Text <> alldclass("c" & c, d) And Button5.Text <> alldclass("c" & c, d) And Button6.Text <> alldclass("c" & c, d) And Button7.Text <> alldclass("c" & c, d) And Button8.Text <> alldclass("c" & c, d) And Button9.Text <> alldclass("c" & c, d) Then
                        Button10.Text = alldclass("c" & c, d)
                        b = b + 1
                    End If
                ElseIf b = 10 Then
                    If Button2.Text <> alldclass("c" & c, d) And Button3.Text <> alldclass("c" & c, d) And Button4.Text <> alldclass("c" & c, d) And Button5.Text <> alldclass("c" & c, d) And Button6.Text <> alldclass("c" & c, d) And Button7.Text <> alldclass("c" & c, d) And Button8.Text <> alldclass("c" & c, d) And Button9.Text <> alldclass("c" & c, d) And Button10.Text <> alldclass("c" & c, d) Then
                        Button11.Text = alldclass("c" & c, d)
                        b = b + 1
                    End If
                ElseIf b = 11 Then
                    If Button2.Text <> alldclass("c" & c, d) And Button3.Text <> alldclass("c" & c, d) And Button4.Text <> alldclass("c" & c, d) And Button5.Text <> alldclass("c" & c, d) And Button6.Text <> alldclass("c" & c, d) And Button7.Text <> alldclass("c" & c, d) And Button8.Text <> alldclass("c" & c, d) And Button9.Text <> alldclass("c" & c, d) And Button10.Text <> alldclass("c" & c, d) And Button11.Text <> alldclass("c" & c, d) Then
                        Button12.Text = alldclass("c" & c, d)
                        b = b + 1
                    End If
                ElseIf b = 12 Then
                    If Button2.Text <> alldclass("c" & c, d) And Button3.Text <> alldclass("c" & c, d) And Button4.Text <> alldclass("c" & c, d) And Button5.Text <> alldclass("c" & c, d) And Button6.Text <> alldclass("c" & c, d) And Button7.Text <> alldclass("c" & c, d) And Button8.Text <> alldclass("c" & c, d) And Button9.Text <> alldclass("c" & c, d) And Button10.Text <> alldclass("c" & c, d) And Button11.Text <> alldclass("c" & c, d) And Button12.Text <> alldclass("c" & c, d) Then
                        Button13.Text = alldclass("c" & c, d)
                        b = b + 1
                    End If
                ElseIf b = 13 Then
                    If Button2.Text <> alldclass("c" & c, d) And Button3.Text <> alldclass("c" & c, d) And Button4.Text <> alldclass("c" & c, d) And Button5.Text <> alldclass("c" & c, d) And Button6.Text <> alldclass("c" & c, d) And Button7.Text <> alldclass("c" & c, d) And Button8.Text <> alldclass("c" & c, d) And Button9.Text <> alldclass("c" & c, d) And Button10.Text <> alldclass("c" & c, d) And Button11.Text <> alldclass("c" & c, d) And Button12.Text <> alldclass("c" & c, d) And Button13.Text <> alldclass("c" & c, d) Then
                        Button14.Text = alldclass("c" & c, d)
                        b = b + 1
                    End If
                ElseIf b = 14 Then
                    If Button2.Text <> alldclass("c" & c, d) And Button3.Text <> alldclass("c" & c, d) And Button4.Text <> alldclass("c" & c, d) And Button5.Text <> alldclass("c" & c, d) And Button6.Text <> alldclass("c" & c, d) And Button7.Text <> alldclass("c" & c, d) And Button8.Text <> alldclass("c" & c, d) And Button9.Text <> alldclass("c" & c, d) And Button10.Text <> alldclass("c" & c, d) And Button11.Text <> alldclass("c" & c, d) And Button12.Text <> alldclass("c" & c, d) And Button13.Text <> alldclass("c" & c, d) And Button14.Text <> alldclass("c" & c, d) Then
                        Button15.Text = alldclass("c" & c, d)
                        b = b + 1
                    End If
                ElseIf b = 15 Then
                    If Button2.Text <> alldclass("c" & c, d) And Button3.Text <> alldclass("c" & c, d) And Button4.Text <> alldclass("c" & c, d) And Button5.Text <> alldclass("c" & c, d) And Button6.Text <> alldclass("c" & c, d) And Button7.Text <> alldclass("c" & c, d) And Button8.Text <> alldclass("c" & c, d) And Button9.Text <> alldclass("c" & c, d) And Button10.Text <> alldclass("c" & c, d) And Button11.Text <> alldclass("c" & c, d) And Button12.Text <> alldclass("c" & c, d) And Button13.Text <> alldclass("c" & c, d) And Button14.Text <> alldclass("c" & c, d) And Button15.Text <> alldclass("c" & c, d) Then
                        Button16.Text = alldclass("c" & c, d)
                        b = b + 1
                    End If
                ElseIf b = 16 Then
                    If Button2.Text <> alldclass("c" & c, d) And Button3.Text <> alldclass("c" & c, d) And Button4.Text <> alldclass("c" & c, d) And Button5.Text <> alldclass("c" & c, d) And Button6.Text <> alldclass("c" & c, d) And Button7.Text <> alldclass("c" & c, d) And Button8.Text <> alldclass("c" & c, d) And Button9.Text <> alldclass("c" & c, d) And Button10.Text <> alldclass("c" & c, d) And Button11.Text <> alldclass("c" & c, d) And Button12.Text <> alldclass("c" & c, d) And Button13.Text <> alldclass("c" & c, d) And Button14.Text <> alldclass("c" & c, d) And Button15.Text <> alldclass("c" & c, d) And Button16.Text <> alldclass("c" & c, d) Then
                        Button17.Text = alldclass("c" & c, d)
                        b = b + 1
                    End If
                End If
            Next c
        Next d
    End Sub

    Public Sub kjhk(b%)
        hkcout = kbcount
        If b = 2 Then
            hktext = Button2.Text
        ElseIf b = 3 Then
            hktext = Button3.Text
        ElseIf b = 4 Then
            hktext = Button4.Text
        ElseIf b = 5 Then
            hktext = Button5.Text
        ElseIf b = 6 Then
            hktext = Button6.Text
        ElseIf b = 7 Then
            hktext = Button7.Text
        ElseIf b = 8 Then
            hktext = Button8.Text
        ElseIf b = 9 Then
            hktext = Button9.Text
        ElseIf b = 10 Then
            hktext = Button10.Text
        ElseIf b = 11 Then
            hktext = Button11.Text
        ElseIf b = 12 Then
            hktext = Button12.Text
        ElseIf b = 13 Then
            hktext = Button13.Text
        ElseIf b = 14 Then
            hktext = Button14.Text
        ElseIf b = 15 Then
            hktext = Button15.Text
        ElseIf b = 16 Then
            hktext = Button16.Text
        ElseIf b = 17 Then
            hktext = Button17.Text
        End If
        If kbcount = 3 Then
            Form3.Close()
            Form3.Show()
        ElseIf kbcount = 4 Then
            Form4.Close()
            Form4.Show()
        ElseIf kbcount = 5 Then
            Form5.Close()
            Form5.Show()
        ElseIf kbcount = 6 Then
            Form6.Close()
            Form6.Show()
        ElseIf kbcount = 7 Then
            Form7.Close()
            Form7.Show()
        ElseIf kbcount = 8 Then
            Form8.Close()
            Form8.Show()
        ElseIf kbcount = 9 Then
            Form9.Close()
            Form9.Show()
        ElseIf kbcount = 10 Then
            Form10.Close()
            Form10.Show()
        ElseIf kbcount = 11 Then
            Form11.Close()
            Form11.Show()
        ElseIf kbcount = 12 Then
            Form12.Close()
            Form12.Show()
        ElseIf kbcount = 13 Then
            Form13.Close()
            Form13.Show()
        ElseIf kbcount = 14 Then
            Form14.Close()
            Form14.Show()
        ElseIf kbcount = 15 Then
            Form15.Close()
            Form15.Show()
        ElseIf kbcount = 16 Then
            Form16.Close()
            Form16.Show()
        ElseIf kbcount = 17 Then
            Form17.Close()
            Form17.Show()
        End If
        Me.Close()
    End Sub

    Public Sub zrhk(b%)
        wk = b
        allkbh = Form2.Height
        Form22.Close()
        Form23.Close()
        hkcout = 3
        hktext = allclass("c1")
        Form3.Close()
        Form3.Show()
        hkcout = 4
        hktext = allclass("c2")
        Form4.Close()
        Form4.Show()
        hkcout = 5
        hktext = allclass("c3")
        Form5.Close()
        Form5.Show()
        hkcout = 6
        hktext = allclass("c4")
        Form6.Close()
        Form6.Show()
        hkcout = 7
        If Val(allclass("ct")) < 5 Then
            hktext = ""
            Form7.Close()
        Else
            hktext = allclass("c5")
            Form7.Close()
            Form7.Show()
        End If
        hkcout = 8
        If Val(allclass("ct")) < 6 Then
            hktext = ""
            Form8.Close()
        Else
            hktext = allclass("c6")
            Form8.Close()
            Form8.Show()
        End If
        hkcout = 9
        If Val(allclass("ct")) < 7 Then
            hktext = ""
            Form9.Close()
        Else
            hktext = allclass("c7")
            Form9.Close()
            Form9.Show()
        End If
        hkcout = 10
        If Val(allclass("ct")) < 8 Then
            hktext = ""
            Form10.Close()
        Else
            hktext = allclass("c8")
            Form10.Close()
            Form10.Show()
        End If
        hkcout = 11
        If Val(allclass("ct")) < 9 Then
            hktext = ""
            Form11.Close()
        Else
            hktext = allclass("c9")
            Form11.Close()
            Form11.Show()
        End If
        hkcout = 12
        If Val(allclass("ct")) < 10 Then
            hktext = ""
            Form12.Close()
        Else
            hktext = allclass("c10")
            Form12.Close()
            Form12.Show()
        End If
        hkcout = 13
        If Val(allclass("ct")) < 11 Then
            hktext = ""
            Form13.Close()
        Else
            hktext = allclass("c11")
            Form13.Close()
            Form13.Show()
        End If
        hkcout = 14
        If Val(allclass("ct")) < 12 Then
            hktext = ""
            Form14.Close()
        Else
            hktext = allclass("c12")
            Form14.Close()
            Form14.Show()
        End If
        hkcout = 15
        If Val(allclass("ct")) < 13 Then
            hktext = ""
            Form15.Close()
        Else
            hktext = allclass("c13")
            Form15.Close()
            Form15.Show()
        End If
        hkcout = 16
        If Val(allclass("ct")) < 14 Then
            hktext = ""
            Form16.Close()
        Else
            hktext = allclass("c14")
            Form16.Close()
            Form16.Show()
        End If
        hkcout = 17
        If Val(allclass("ct")) < 15 Then
            hktext = ""
            Form17.Close()
        Else
            hktext = allclass("c15")
            Form17.Close()
            Form17.Show()
        End If
        Form18.Close()
        Form18.Show()
        Form22.Show()
        Form23.Show()
        Me.Close()
    End Sub

    Public Function allclass(s$) As String
        Dim classlist As String
        classlist = My.Computer.FileSystem.ReadAllText("data\cl" & dqcl & "\z" & wk & ".txt")
        If Len(s) = 2 Then
            allclass = Trim(Mid(classlist, InStr(classlist, CStr(s)) + 2, 4))
        Else
            allclass = Trim(Mid(classlist, InStr(classlist, CStr(s)) + 3, 4))
        End If
    End Function

    Public Function alldclass(s$, z%) As String
        Dim classlist As String
        classlist = My.Computer.FileSystem.ReadAllText("data\cl" & dqcl & "\z" & z & ".txt")
        If Len(s) = 2 Then
            alldclass = Trim(Mid(classlist, InStr(classlist, CStr(s)) + 2, 4))
        Else
            alldclass = Trim(Mid(classlist, InStr(classlist, CStr(s)) + 3, 4))
        End If
    End Function

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        hkcout = kbcount
        hktext = TextBox1.Text
        hkcolr = TextBox1.BackColor
        If ccolr = True Then
            hkcolrc = True
        End If
        If kbcount = 3 Then
            Form3.Close()
            Form3.Show()
        ElseIf kbcount = 4 Then
            Form4.Close()
            Form4.Show()
        ElseIf kbcount = 5 Then
            Form5.Close()
            Form5.Show()
        ElseIf kbcount = 6 Then
            Form6.Close()
            Form6.Show()
        ElseIf kbcount = 7 Then
            Form7.Close()
            Form7.Show()
        ElseIf kbcount = 8 Then
            Form8.Close()
            Form8.Show()
        ElseIf kbcount = 9 Then
            Form9.Close()
            Form9.Show()
        ElseIf kbcount = 10 Then
            Form10.Close()
            Form10.Show()
        ElseIf kbcount = 11 Then
            Form11.Close()
            Form11.Show()
        ElseIf kbcount = 12 Then
            Form12.Close()
            Form12.Show()
        ElseIf kbcount = 13 Then
            Form13.Close()
            Form13.Show()
        ElseIf kbcount = 14 Then
            Form14.Close()
            Form14.Show()
        ElseIf kbcount = 15 Then
            Form15.Close()
            Form15.Show()
        ElseIf kbcount = 16 Then
            Form16.Close()
            Form16.Show()
        ElseIf kbcount = 17 Then
            Form17.Close()
            Form17.Show()
        End If
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        kjhk(2)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        kjhk(3)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        kjhk(4)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        kjhk(5)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        kjhk(6)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        kjhk(7)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        kjhk(8)
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        kjhk(9)
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        kjhk(10)
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        kjhk(11)
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        kjhk(12)
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        kjhk(13)
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        kjhk(14)
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        kjhk(15)
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        kjhk(16)
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        kjhk(17)
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        tss = My.Computer.FileSystem.ReadAllText("data\tss.txt")
        If fricls = 0 Then
            If tss = "1" Then
                rq = MsgBox("周一为特殊作息时间" & vbCrLf & "是否切换到特殊作息时间?", vbOKCancel + vbQuestion, "全能班辅")
                If rq = 1 Then
                    fricls = 1
                    zrhk(1)
                Else
                    zrhk(1)
                End If
            Else
                zrhk(1)
            End If
        Else
            If tss = "1" Then
                zrhk(1)
            Else
                rq = MsgBox("周一为正常作息时间" & vbCrLf & "是否切换到正常作息时间?", vbOKCancel + vbQuestion, "全能班辅")
                If rq = 1 Then
                    fricls = 0
                    zrhk(1)
                Else
                    zrhk(1)
                End If
            End If
        End If
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        tss = My.Computer.FileSystem.ReadAllText("data\tss.txt")
        If fricls = 0 Then
            If tss = "2" Then
                rq = MsgBox("周二为特殊作息时间" & vbCrLf & "是否切换到特殊作息时间?", vbOKCancel + vbQuestion, "全能班辅")
                If rq = 1 Then
                    fricls = 1
                    zrhk(2)
                Else
                    zrhk(2)
                End If
            Else
                zrhk(2)
            End If
        Else
            If tss = "2" Then
                zrhk(2)
            Else
                rq = MsgBox("周二为正常作息时间" & vbCrLf & "是否切换到正常作息时间?", vbOKCancel + vbQuestion, "全能班辅")
                If rq = 1 Then
                    fricls = 0
                    zrhk(2)
                Else
                    zrhk(2)
                End If
            End If
        End If
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        tss = My.Computer.FileSystem.ReadAllText("data\tss.txt")
        If fricls = 0 Then
            If tss = "3" Then
                rq = MsgBox("周三为特殊作息时间" & vbCrLf & "是否切换到特殊作息时间?", vbOKCancel + vbQuestion, "全能班辅")
                If rq = 1 Then
                    fricls = 1
                    zrhk(3)
                Else
                    zrhk(3)
                End If
            Else
                zrhk(3)
            End If
        Else
            If tss = "3" Then
                zrhk(3)
            Else
                rq = MsgBox("周三为正常作息时间" & vbCrLf & "是否切换到正常作息时间?", vbOKCancel + vbQuestion, "全能班辅")
                If rq = 1 Then
                    fricls = 0
                    zrhk(3)
                Else
                    zrhk(3)
                End If
            End If
        End If
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        tss = My.Computer.FileSystem.ReadAllText("data\tss.txt")
        If fricls = 0 Then
            If tss = "4" Then
                rq = MsgBox("周四为特殊作息时间" & vbCrLf & "是否切换到特殊作息时间?", vbOKCancel + vbQuestion, "全能班辅")
                If rq = 1 Then
                    fricls = 1
                    zrhk(4)
                Else
                    zrhk(4)
                End If
            Else
                zrhk(4)
            End If
        Else
            If tss = "4" Then
                zrhk(4)
            Else
                rq = MsgBox("周四为正常作息时间" & vbCrLf & "是否切换到正常作息时间?", vbOKCancel + vbQuestion, "全能班辅")
                If rq = 1 Then
                    fricls = 0
                    zrhk(4)
                Else
                    zrhk(4)
                End If
            End If
        End If
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        tss = My.Computer.FileSystem.ReadAllText("data\tss.txt")
        If fricls = 0 Then
            If tss = "5" Then
                rq = MsgBox("周五为特殊作息时间" & vbCrLf & "是否切换到特殊作息时间?", vbOKCancel + vbQuestion, "全能班辅")
                If rq = 1 Then
                    fricls = 1
                    zrhk(5)
                Else
                    zrhk(5)
                End If
            Else
                zrhk(5)
            End If
        Else
            If tss = "5" Then
                zrhk(5)
            Else
                rq = MsgBox("周五为正常作息时间" & vbCrLf & "是否切换到正常作息时间?", vbOKCancel + vbQuestion, "全能班辅")
                If rq = 1 Then
                    fricls = 0
                    zrhk(5)
                Else
                    zrhk(5)
                End If
            End If
        End If
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        tss = My.Computer.FileSystem.ReadAllText("data\tss.txt")
        If fricls = 0 Then
            If tss = "6" Then
                rq = MsgBox("周六为特殊作息时间" & vbCrLf & "是否切换到特殊作息时间?", vbOKCancel + vbQuestion, "全能班辅")
                If rq = 1 Then
                    fricls = 1
                    zrhk(6)
                Else
                    zrhk(6)
                End If
            Else
                zrhk(6)
            End If
        Else
            If tss = "6" Then
                zrhk(6)
            Else
                rq = MsgBox("周六为正常作息时间" & vbCrLf & "是否切换到正常作息时间?", vbOKCancel + vbQuestion, "全能班辅")
                If rq = 1 Then
                    fricls = 0
                    zrhk(6)
                Else
                    zrhk(6)
                End If
            End If
        End If
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        tss = My.Computer.FileSystem.ReadAllText("data\tss.txt")
        If fricls = 0 Then
            If tss = "7" Then
                rq = MsgBox("周日为特殊作息时间" & vbCrLf & "是否切换到特殊作息时间?", vbOKCancel + vbQuestion, "全能班辅")
                If rq = 1 Then
                    fricls = 1
                    zrhk(7)
                Else
                    zrhk(7)
                End If
            Else
                zrhk(7)
            End If
        Else
            If tss = "7" Then
                zrhk(7)
            Else
                rq = MsgBox("周日为正常作息时间" & vbCrLf & "是否切换到正常作息时间?", vbOKCancel + vbQuestion, "全能班辅")
                If rq = 1 Then
                    fricls = 0
                    zrhk(7)
                Else
                    zrhk(7)
                End If
            End If
        End If
    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ColorDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            TextBox1.BackColor = ColorDialog1.Color
            Label3.BackColor = ColorDialog1.Color
            ccolr = True
        End If
    End Sub
End Class