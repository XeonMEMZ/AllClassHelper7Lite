Imports System.ComponentModel
Imports System.IO
Imports System.Reflection.Emit
Imports System.Text

Public Class Form36
    Dim foldertitle As String
    Dim datapath As String
    Dim copytext As String
    Dim copytext2 As String
    Dim maxclass As Integer
    Dim timlist As String
    Dim gspeed As Double
    Dim drbb As Integer
    Dim ctt As String
    Dim cq As Boolean
    Dim rq As Integer
    Dim ct As Integer
    Dim d As Integer
    Dim c As Integer

    Public Function EncryptData(txt As String)
        If txt = "" Then
            EncryptData = "342255"
        Else
            For i = 1 To Len(txt)
                If Asc(Mid(txt, i, 1)) + 1 = 127 Then
                    EncryptData = EncryptData & Chr(32)
                Else
                    EncryptData = EncryptData & Chr(Asc(Mid(txt, i, 1)) + 1)
                End If
            Next
        End If
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label6.ForeColor = Color.Black
        Label6.Text = "导入状态显示"
        Dim selectedPath As String = SelectFolderWithCustomTitle(foldertitle)
        If Not String.IsNullOrEmpty(selectedPath) Then
            datapath = selectedPath
            Label7.Text = selectedPath
        Else
            datapath = ""
            Label7.Text = "未选择任何文件夹"
        End If
    End Sub

    Private Sub RadioButton1_Click(sender As Object, e As EventArgs) Handles RadioButton1.Click
        If RadioButton1.Checked = True And RadioButton1.Enabled = True Then
            drbb = 1
            foldertitle = "请直接选择软件安装文件夹"
            Label4.Text = "请直接选择软件安装文件夹"
        End If
    End Sub

    Private Sub RadioButton2_Click(sender As Object, e As EventArgs) Handles RadioButton2.Click
        If RadioButton2.Checked = True And RadioButton2.Enabled = True Then
            drbb = 2
            foldertitle = "请选择软件data文件夹"
            Label4.Text = "请选择软件data文件夹"
        End If
    End Sub

    Private Sub RadioButton3_Click(sender As Object, e As EventArgs) Handles RadioButton3.Click
        If RadioButton3.Checked = True And RadioButton3.Enabled = True Then
            drbb = 3
            foldertitle = "请选择软件data文件夹"
            Label4.Text = "请选择软件data文件夹"
        End If
    End Sub

    Private Sub RadioButton4_Click(sender As Object, e As EventArgs) Handles RadioButton4.Click
        If RadioButton4.Checked = True And RadioButton4.Enabled = True Then
            drbb = 4
            foldertitle = "请选择软件data文件夹"
            Label4.Text = "请选择软件data文件夹"
        End If
    End Sub

    Private Sub RadioButton5_Click(sender As Object, e As EventArgs) Handles RadioButton5.Click
        If RadioButton5.Checked = True And RadioButton5.Enabled = True Then
            drbb = 5
            foldertitle = "请选择软件data文件夹"
            Label4.Text = "请选择软件data文件夹"
        End If
    End Sub

    Private Sub RadioButton6_Click(sender As Object, e As EventArgs) Handles RadioButton6.Click
        If RadioButton6.Checked = True And RadioButton6.Enabled = True Then
            drbb = 6
            foldertitle = "请选择软件data文件夹"
            Label4.Text = "请选择软件data文件夹"
        End If
    End Sub

    Private Sub RadioButton7_Click(sender As Object, e As EventArgs) Handles RadioButton7.Click
        If RadioButton7.Checked = True And RadioButton7.Enabled = True Then
            drbb = 7
            foldertitle = "请选择软件data文件夹"
            Label4.Text = "请选择软件data文件夹"
        End If
    End Sub

    Public Shared Function SelectFolderWithCustomTitle(title As String, Optional initialPath As String = "") As String
        Using folderDialog As New FolderBrowserDialog()
            folderDialog.Description = title
            folderDialog.RootFolder = Environment.SpecialFolder.MyComputer
            folderDialog.ShowNewFolderButton = True
            If Not String.IsNullOrEmpty(initialPath) Then
                folderDialog.SelectedPath = initialPath
            End If
            If folderDialog.ShowDialog() = DialogResult.OK Then
                Return folderDialog.SelectedPath
            End If
            Return String.Empty
        End Using
    End Function


    Public Sub tmdr(txtname As String)
        Dim fileBytes As Byte() = File.ReadAllBytes(datapath & "\" & txtname)
        Dim gbkEncoding As Encoding = Encoding.GetEncoding("GBK")
        Dim decodedText As String = gbkEncoding.GetString(fileBytes)
        Dim utf8Encoding As Encoding = Encoding.UTF8
        Dim utf8Bytes As Byte() = utf8Encoding.GetBytes(decodedText)
        File.WriteAllBytes("data\" & txtname, utf8Bytes)
        My.Computer.FileSystem.WriteAllText("data\" & txtname, My.Computer.FileSystem.ReadAllText("data\" & txtname).Replace(vbCrLf, ""), False)
    End Sub

    Public Sub tmdr7(txtname As String)
        My.Computer.FileSystem.WriteAllText("data\" & txtname, My.Computer.FileSystem.ReadAllText(datapath & "\" & txtname).Replace(vbCrLf, ""), False)
    End Sub

    Public Sub ymdr(oldtxtname As String, txtname As String)
        Dim fileBytes As Byte() = File.ReadAllBytes(datapath & "\" & oldtxtname)
        Dim gbkEncoding As Encoding = Encoding.GetEncoding("GBK")
        Dim decodedText As String = gbkEncoding.GetString(fileBytes)
        Dim utf8Encoding As Encoding = Encoding.UTF8
        Dim utf8Bytes As Byte() = utf8Encoding.GetBytes(decodedText)
        File.WriteAllBytes("data\" & txtname, utf8Bytes)
        My.Computer.FileSystem.WriteAllText("data\" & txtname, My.Computer.FileSystem.ReadAllText("data\" & txtname).Replace(vbCrLf, ""), False)
    End Sub


    Public Sub drkb(zcount As Integer)
        For d = 1 To zcount
            Dim fileBytes As Byte() = File.ReadAllBytes(datapath & "\z" & d & ".txt")
            Dim gbkEncoding As Encoding = Encoding.GetEncoding("GBK")
            Dim decodedText As String = gbkEncoding.GetString(fileBytes)
            Dim utf8Encoding As Encoding = Encoding.UTF8
            Dim utf8Bytes As Byte() = utf8Encoding.GetBytes(decodedText)
            File.WriteAllBytes("data\cl1\z" & d & ".txt", utf8Bytes)
            My.Computer.FileSystem.WriteAllText("data\cl1\z" & d & ".txt", My.Computer.FileSystem.ReadAllText("data\cl1\z" & d & ".txt").Replace(vbCrLf, ""), False)
            copytext2 = My.Computer.FileSystem.ReadAllText("data\cl1\z" & d & ".txt")
            copytext = ""
            ct = 0
            c = 1
            While c <= Len(copytext2)
                If Asc(Mid(copytext2, c, 1)) >= 65 And Asc(Mid(copytext2, c, 1)) <= 90 Or Asc(Mid(copytext2, c, 1)) >= 97 And Asc(Mid(copytext2, c, 1)) <= 122 Then
                    ct = ct + 1
                    c = c + 1
                Else
                    ct = ct + 1
                End If
                c = c + 1
            End While
            copytext = "ct 0" & ct
            ct = 0
            c = 1
            While c <= Len(copytext2)
                If Asc(Mid(copytext2, c, 1)) >= 65 And Asc(Mid(copytext2, c, 1)) <= 90 Or Asc(Mid(copytext2, c, 1)) >= 97 And Asc(Mid(copytext2, c, 1)) <= 122 Then
                    ct = ct + 1
                    copytext = copytext & "    c" & ct & " " & Mid(copytext2, c, 2)
                    c = c + 1
                Else
                    ct = ct + 1
                    copytext = copytext & "    c" & ct & " " & Mid(copytext2, c, 1)
                End If
                c = c + 1
            End While
            If d <= 4 Then
                My.Computer.FileSystem.WriteAllText("data\cl1\z" & d & ".txt", copytext & "    c9     c10     c11     c12     c13     c14     c15   ", False)
            ElseIf d = 5 Then
                My.Computer.FileSystem.WriteAllText("data\cl1\z" & d & ".txt", copytext & "    c7     c8     c9     c10     c11     c12     c13     c14     c15   ", False)
            Else
                My.Computer.FileSystem.WriteAllText("data\cl1\z" & d & ".txt", copytext & "    c6     c7     c8     c9     c10     c11     c12     c13     c14     c15   ", False)
            End If
        Next d
    End Sub

    Public Sub xdrkb()
        For d = 1 To 7
            Dim fileBytes As Byte() = File.ReadAllBytes(datapath & "\z" & d & ".txt")
            Dim gbkEncoding As Encoding = Encoding.GetEncoding("GBK")
            Dim decodedText As String = gbkEncoding.GetString(fileBytes)
            Dim utf8Encoding As Encoding = Encoding.UTF8
            Dim utf8Bytes As Byte() = utf8Encoding.GetBytes(decodedText)
            File.WriteAllBytes("data\cl1\z" & d & ".txt", utf8Bytes)
            My.Computer.FileSystem.WriteAllText("data\cl1\z" & d & ".txt", My.Computer.FileSystem.ReadAllText("data\cl1\z" & d & ".txt").Replace(vbCrLf, ""), False)
            copytext2 = My.Computer.FileSystem.ReadAllText("data\cl1\z" & d & ".txt")
            c = Val(alldclass("ct", d))
            If Len(alldclass("ct", d)) = 1 Then
                ctt = "0" & alldclass("ct", d)
            Else
                ctt = alldclass("ct", d)
            End If
            For n = 1 To c
                copytext = "ct " & ctt & "   c1 " & alldclass("c1", d) & "    c2 " & alldclass("c2", d) & "    c3 " & alldclass("c3", d) & "    c4 " & alldclass("c4", d)
                If c > 4 Then
                    copytext = copytext & "    c5 " & alldclass("c5", d)
                    If c > 5 Then
                        copytext = copytext & "    c6 " & alldclass("c6", d)
                        If c > 6 Then
                            copytext = copytext & "    c7 " & alldclass("c7", d)
                            If c > 7 Then
                                copytext = copytext & "    c8 " & alldclass("c8", d)
                                If c > 8 Then
                                    copytext = copytext & "    c9 " & alldclass("c9", d)
                                    If c > 9 Then
                                        copytext = copytext & "    c10 " & alldclass("c10", d)
                                        If c > 10 Then
                                            copytext = copytext & "    c11 " & alldclass("c11", d)
                                            If c > 11 Then
                                                copytext = copytext & "    c12 " & alldclass("c12", d)
                                                If c > 12 Then
                                                    copytext = copytext & "    c13 " & alldclass("c13", d)
                                                    If c > 13 Then
                                                        copytext = copytext & "    c14 " & alldclass("c14", d)
                                                        If c > 14 Then
                                                            copytext = copytext & "    c15 " & alldclass("c15", d)
                                                        Else
                                                            copytext = copytext & "    c15   "
                                                        End If
                                                    Else
                                                        copytext = copytext & "    c14     c15   "
                                                    End If
                                                Else
                                                    copytext = copytext & "    c13     c14     c15   "
                                                End If
                                            Else
                                                copytext = copytext & "    c12     c13     c14     c15   "
                                            End If
                                        Else
                                            copytext = copytext & "    c11     c12     c13     c14     c15   "
                                        End If
                                    Else
                                        copytext = copytext & "    c10     c11     c12     c13     c14     c15   "
                                    End If
                                Else
                                    copytext = copytext & "    c9     c10     c11     c12     c13     c14     c15   "
                                End If
                            Else
                                copytext = copytext & "    c8     c9     c10     c11     c12     c13     c14     c15   "
                            End If
                        Else
                            copytext = copytext & "    c7     c8     c9     c10     c11     c12     c13     c14     c15   "
                        End If
                    Else
                        copytext = copytext & "    c6     c7     c8     c9     c10     c11     c12     c13     c14     c15   "
                    End If
                Else
                    copytext = copytext & "    c5     c6     c7     c8     c9     c10     c11     c12     c13     c14     c15   "
                End If
            Next
            My.Computer.FileSystem.WriteAllText("data\cl1\z" & d & ".txt", copytext, False)
        Next
    End Sub

    Public Sub drsj(bb As Integer)
        Dim fileBytes As Byte() = File.ReadAllBytes(datapath & "\timelist.txt")
        Dim gbkEncoding As Encoding = Encoding.GetEncoding("GBK")
        Dim decodedText As String = gbkEncoding.GetString(fileBytes)
        Dim utf8Encoding As Encoding = Encoding.UTF8
        Dim utf8Bytes As Byte() = utf8Encoding.GetBytes(decodedText)
        File.WriteAllBytes("data\cl1\timelist.txt", utf8Bytes)
        My.Computer.FileSystem.WriteAllText("data\cl1\timelist.txt", My.Computer.FileSystem.ReadAllText("data\cl1\timelist.txt").Replace(vbCrLf, ""), False)
        timlist = My.Computer.FileSystem.ReadAllText("data\cl1\timelist.txt")
        If bb = 1 Then
            copytext2 = "  zm1s " & zxtime("zm1s") & "  zm1x " & zxtime("zm1x") & "  zm2s " & zxtime("zm2s") & "  zm2x " & zxtime("zm2x") & "  zm3s " & zxtime("zm3s") & "  zm3x " & zxtime("zm3x") & "  zm4s " & zxtime("zm4s") & "  zm4x " & zxtime("zm4x") & "  zm5s " & zxtime("zm5s") & "  zm5x " & zxtime("zm5x") & "  zm6s " & zxtime("zm6s") & "  zm6x " & zxtime("zm6x") & "  zm7s " & zxtime("zm7s") & "  zm7x " & zxtime("zm7x") & "  zm8s " & zxtime("zm8s") & "  zm8x " & zxtime("zm8x") & "  zm9s 23:59:59  zm9x 23:59:59  zm10s 23:59:59  zm10x 23:59:59  zm11s 23:59:59  zm11x 23:59:59  zm12s 23:59:59  zm12x 23:59:59  zm13s 23:59:59  zm13x 23:59:59  zm14s 23:59:59  zm14x 23:59:59  zm15s 23:59:59  zm15x 23:59:59" & "  zt1s " & zxtime("zm1s") & "  zt1x " & zxtime("zm1x") & "  zt2s " & zxtime("zm2s") & "  zt2x " & zxtime("zm2x") & "  zt3s " & zxtime("zm3s") & "  zt3x " & zxtime("zm3x") & "  zt4s " & zxtime("zm4s") & "  zt4x " & zxtime("zm4x") & "  zt5s " & zxtime("zf5s") & "  zt5x " & zxtime("zf5x") & "  zt6s " & zxtime("zf6s") & "  zt6x " & zxtime("zf6x") & "  zt7s 23:59:59  zt7x 23:59:59  zt8s 23:59:59  zt8x 23:59:59  zt9s 23:59:59  zt9x 23:59:59  zt10s 23:59:59  zt10x 23:59:59  zt11s 23:59:59  zt11x 23:59:59  zt12s 23:59:59  zt12x 23:59:59  zt13s 23:59:59  zt13x 23:59:59  zt14s 23:59:59  zt14x 23:59:59  zt15s 23:59:59  zt15x 23:59:59  "
        ElseIf bb = 2 Then
            copytext2 = "  zm1s " & zxtime("zm1s") & "  zm1x " & zxtime("zm1x") & "  zm2s " & zxtime("zm2s") & "  zm2x " & zxtime("zm2x") & "  zm3s " & zxtime("zm3s") & "  zm3x " & zxtime("zm3x") & "  zm4s " & zxtime("zm4s") & "  zm4x " & zxtime("zm4x") & "  zm5s " & zxtime("zm5s") & "  zm5x " & zxtime("zm5x") & "  zm6s " & zxtime("zm6s") & "  zm6x " & zxtime("zm6x") & "  zm7s " & zxtime("zm7s") & "  zm7x " & zxtime("zm7x") & "  zm8s " & zxtime("zm8s") & "  zm8x " & zxtime("zm8x") & "  zm9s 23:59:59  zm9x 23:59:59  zm10s 23:59:59  zm10x 23:59:59  zm11s 23:59:59  zm11x 23:59:59  zm12s 23:59:59  zm12x 23:59:59  zm13s 23:59:59  zm13x 23:59:59  zm14s 23:59:59  zm14x 23:59:59  zm15s 23:59:59  zm15x 23:59:59" & "  zt1s " & zxtime("zm1s") & "  zt1x " & zxtime("zm1x") & "  zt2s " & zxtime("zm2s") & "  zt2x " & zxtime("zm2x") & "  zt3s " & zxtime("zm3s") & "  zt3x " & zxtime("zm3x") & "  zt4s " & zxtime("zm4s") & "  zt4x " & zxtime("zm4x") & "  zt5s " & zxtime("zf5s") & "  zt5x " & zxtime("zf5x") & "  zt6s " & zxtime("zf6s") & "  zt6x " & zxtime("zf6x") & "  zt7s 23:59:59  zt7x 23:59:59  zt8s 23:59:59  zt8x 23:59:59  zt9s 23:59:59  zt9x 23:59:59  zt10s 23:59:59  zt10x 23:59:59  zt11s 23:59:59  zt11x 23:59:59  zt12s 23:59:59  zt12x 23:59:59  zt13s 23:59:59  zt13x 23:59:59  zt14s 23:59:59  zt14x 23:59:59  zt15s 23:59:59  zt15x 23:59:59  "
        ElseIf bb = 3 Then
            copytext2 = "  zm1s " & zxtime("zm1s") & "  zm1x " & zxtime("zm1x") & "  zm2s " & zxtime("zm2s") & "  zm2x " & zxtime("zm2x") & "  zm3s " & zxtime("zm3s") & "  zm3x " & zxtime("zm3x") & "  zm4s " & zxtime("zm4s") & "  zm4x " & zxtime("zm4x") & "  zm5s " & zxtime("zm5s") & "  zm5x " & zxtime("zm5x") & "  zm6s " & zxtime("zm6s") & "  zm6x " & zxtime("zm6x") & "  zm7s " & zxtime("zm7s") & "  zm7x " & zxtime("zm7x") & "  zm8s " & zxtime("zm8s") & "  zm8x " & zxtime("zm8x") & "  zm9s 23:59:59  zm9x 23:59:59  zm10s 23:59:59  zm10x 23:59:59  zm11s 23:59:59  zm11x 23:59:59  zm12s 23:59:59  zm12x 23:59:59  zm13s 23:59:59  zm13x 23:59:59  zm14s 23:59:59  zm14x 23:59:59  zm15s 23:59:59  zm15x 23:59:59" & "  zt1s " & zxtime("zm1s") & "  zt1x " & zxtime("zm1x") & "  zt2s " & zxtime("zm2s") & "  zt2x " & zxtime("zm2x") & "  zt3s " & zxtime("zm3s") & "  zt3x " & zxtime("zm3x") & "  zt4s " & zxtime("zm4s") & "  zt4x " & zxtime("zm4x") & "  zt5s " & zxtime("zf5s") & "  zt5x " & zxtime("zf5x") & "  zt6s " & zxtime("zf6s") & "  zt6x " & zxtime("zf6x") & "  zt7s 23:59:59  zt7x 23:59:59  zt8s 23:59:59  zt8x 23:59:59  zt9s 23:59:59  zt9x 23:59:59  zt10s 23:59:59  zt10x 23:59:59  zt11s 23:59:59  zt11x 23:59:59  zt12s 23:59:59  zt12x 23:59:59  zt13s 23:59:59  zt13x 23:59:59  zt14s 23:59:59  zt14x 23:59:59  zt15s 23:59:59  zt15x 23:59:59  "
        ElseIf bb = 4 Then
            copytext2 = "  zm1s " & zxtime("zm1s") & "  zm1x " & zxtime("zm1x") & "  zm2s " & zxtime("zm2s") & "  zm2x " & zxtime("zm2x") & "  zm3s " & zxtime("zm3s") & "  zm3x " & zxtime("zm3x") & "  zm4s " & zxtime("zm4s") & "  zm4x " & zxtime("zm4x") & "  zm5s " & zxtime("zm5s") & "  zm5x " & zxtime("zm5x") & "  zm6s " & zxtime("zm6s") & "  zm6x " & zxtime("zm6x") & "  zm7s " & zxtime("zm7s") & "  zm7x " & zxtime("zm7x") & "  zm8s " & zxtime("zm8s") & "  zm8x " & zxtime("zm8x") & "  zm9s 23:59:59  zm9x 23:59:59  zm10s 23:59:59  zm10x 23:59:59  zm11s 23:59:59  zm11x 23:59:59  zm12s 23:59:59  zm12x 23:59:59  zm13s 23:59:59  zm13x 23:59:59  zm14s 23:59:59  zm14x 23:59:59  zm15s 23:59:59  zm15x 23:59:59" & "  zt1s " & zxtime("zm1s") & "  zt1x " & zxtime("zm1x") & "  zt2s " & zxtime("zm2s") & "  zt2x " & zxtime("zm2x") & "  zt3s " & zxtime("zm3s") & "  zt3x " & zxtime("zm3x") & "  zt4s " & zxtime("zm4s") & "  zt4x " & zxtime("zm4x") & "  zt5s " & zxtime("zf5s") & "  zt5x " & zxtime("zf5x") & "  zt6s " & zxtime("zf6s") & "  zt6x " & zxtime("zf6x") & "  zt7s 23:59:59  zt7x 23:59:59  zt8s 23:59:59  zt8x 23:59:59  zt9s 23:59:59  zt9x 23:59:59  zt10s 23:59:59  zt10x 23:59:59  zt11s 23:59:59  zt11x 23:59:59  zt12s 23:59:59  zt12x 23:59:59  zt13s 23:59:59  zt13x 23:59:59  zt14s 23:59:59  zt14x 23:59:59  zt15s 23:59:59  zt15x 23:59:59  "
        ElseIf bb = 5 Then
            For n = 1 To 7
                c = Val(alldclass("ct", n))
                If c > maxclass Then
                    maxclass = c
                End If
            Next n
            copytext2 = "  zm1s " & zxtime("zm1s") & "  zm1x " & zxtime("zm1x") & "  zm2s " & zxtime("zm2s") & "  zm2x " & zxtime("zm2x") & "  zm3s " & zxtime("zm3s") & "  zm3x " & zxtime("zm3x") & "  zm4s " & zxtime("zm4s") & "  zm4x " & zxtime("zm4x")
            If maxclass > 4 Then
                copytext2 = copytext2 & "  zm5s " & zxtime("zm5s") & "  zm5x " & zxtime("zm5x")
                If maxclass > 5 Then
                    copytext2 = copytext2 & "  zm6s " & zxtime("zm6s") & "  zm6x " & zxtime("zm6x")
                    If maxclass > 6 Then
                        copytext2 = copytext2 & "  zm7s " & zxtime("zm7s") & "  zm7x " & zxtime("zm7x")
                        If maxclass > 7 Then
                            copytext2 = copytext2 & "  zm8s " & zxtime("zm8s") & "  zm8x " & zxtime("zm8x")
                            If maxclass > 8 Then
                                copytext2 = copytext2 & "  zm9s " & zxtime("zm9s") & "  zm9x " & zxtime("zm9x")
                                If maxclass > 9 Then
                                    copytext2 = copytext2 & "  zm10s " & zxtime("zm10s") & "  zm10x " & zxtime("zm10x")
                                    If maxclass > 10 Then
                                        copytext2 = copytext2 & "  zm11s " & zxtime("zm11s") & "  zm11x " & zxtime("zm11x")
                                        If maxclass > 11 Then
                                            copytext2 = copytext2 & "  zm12s " & zxtime("zm12s") & "  zm12x " & zxtime("zm12x")
                                        Else
                                            copytext2 = copytext2 & "  zm12s 23:59:59  zm12x 23:59:59  zm13s 23:59:59  zm13x 23:59:59  zm14s 23:59:59  zm14x 23:59:59  zm15s 23:59:59  zm15x 23:59:59" & "  zt1s " & zxtime("zm1s") & "  zt1x " & zxtime("zm1x") & "  zt2s " & zxtime("zm2s") & "  zt2x " & zxtime("zm2x") & "  zt3s " & zxtime("zm3s") & "  zt3x " & zxtime("zm3x") & "  zt4s " & zxtime("zm4s") & "  zt4x " & zxtime("zm4x") & "  zt5s " & zxtime("zf5s") & "  zt5x " & zxtime("zf5x") & "  zt6s " & zxtime("zf6s") & "  zt6x " & zxtime("zf6x") & "  zt7s 23:59:59  zt7x 23:59:59  zt8s 23:59:59  zt8x 23:59:59  zt9s 23:59:59  zt9x 23:59:59  zt10s 23:59:59  zt10x 23:59:59  zt11s 23:59:59  zt11x 23:59:59  zt12s 23:59:59  zt12x 23:59:59  zt13s 23:59:59  zt13x 23:59:59  zt14s 23:59:59  zt14x 23:59:59  zt15s 23:59:59  zt15x 23:59:59  "
                                        End If
                                    Else
                                        copytext2 = copytext2 & "  zm11s 23:59:59  zm11x 23:59:59  zm12s 23:59:59  zm12x 23:59:59  zm13s 23:59:59  zm13x 23:59:59  zm14s 23:59:59  zm14x 23:59:59  zm15s 23:59:59  zm15x 23:59:59" & "  zt1s " & zxtime("zm1s") & "  zt1x " & zxtime("zm1x") & "  zt2s " & zxtime("zm2s") & "  zt2x " & zxtime("zm2x") & "  zt3s " & zxtime("zm3s") & "  zt3x " & zxtime("zm3x") & "  zt4s " & zxtime("zm4s") & "  zt4x " & zxtime("zm4x") & "  zt5s " & zxtime("zf5s") & "  zt5x " & zxtime("zf5x") & "  zt6s " & zxtime("zf6s") & "  zt6x " & zxtime("zf6x") & "  zt7s 23:59:59  zt7x 23:59:59  zt8s 23:59:59  zt8x 23:59:59  zt9s 23:59:59  zt9x 23:59:59  zt10s 23:59:59  zt10x 23:59:59  zt11s 23:59:59  zt11x 23:59:59  zt12s 23:59:59  zt12x 23:59:59  zt13s 23:59:59  zt13x 23:59:59  zt14s 23:59:59  zt14x 23:59:59  zt15s 23:59:59  zt15x 23:59:59  "
                                    End If
                                Else
                                    copytext2 = copytext2 & "  zm10s 23:59:59  zm10x 23:59:59  zm11s 23:59:59  zm11x 23:59:59  zm12s 23:59:59  zm12x 23:59:59  zm13s 23:59:59  zm13x 23:59:59  zm14s 23:59:59  zm14x 23:59:59  zm15s 23:59:59  zm15x 23:59:59" & "  zt1s " & zxtime("zm1s") & "  zt1x " & zxtime("zm1x") & "  zt2s " & zxtime("zm2s") & "  zt2x " & zxtime("zm2x") & "  zt3s " & zxtime("zm3s") & "  zt3x " & zxtime("zm3x") & "  zt4s " & zxtime("zm4s") & "  zt4x " & zxtime("zm4x") & "  zt5s " & zxtime("zf5s") & "  zt5x " & zxtime("zf5x") & "  zt6s " & zxtime("zf6s") & "  zt6x " & zxtime("zf6x") & "  zt7s 23:59:59  zt7x 23:59:59  zt8s 23:59:59  zt8x 23:59:59  zt9s 23:59:59  zt9x 23:59:59  zt10s 23:59:59  zt10x 23:59:59  zt11s 23:59:59  zt11x 23:59:59  zt12s 23:59:59  zt12x 23:59:59  zt13s 23:59:59  zt13x 23:59:59  zt14s 23:59:59  zt14x 23:59:59  zt15s 23:59:59  zt15x 23:59:59  "
                                End If
                            Else
                                copytext2 = copytext2 & "  zm9s 23:59:59  zm9x 23:59:59  zm10s 23:59:59  zm10x 23:59:59  zm11s 23:59:59  zm11x 23:59:59  zm12s 23:59:59  zm12x 23:59:59  zm13s 23:59:59  zm13x 23:59:59  zm14s 23:59:59  zm14x 23:59:59  zm15s 23:59:59  zm15x 23:59:59" & "  zt1s " & zxtime("zm1s") & "  zt1x " & zxtime("zm1x") & "  zt2s " & zxtime("zm2s") & "  zt2x " & zxtime("zm2x") & "  zt3s " & zxtime("zm3s") & "  zt3x " & zxtime("zm3x") & "  zt4s " & zxtime("zm4s") & "  zt4x " & zxtime("zm4x") & "  zt5s " & zxtime("zf5s") & "  zt5x " & zxtime("zf5x") & "  zt6s " & zxtime("zf6s") & "  zt6x " & zxtime("zf6x") & "  zt7s 23:59:59  zt7x 23:59:59  zt8s 23:59:59  zt8x 23:59:59  zt9s 23:59:59  zt9x 23:59:59  zt10s 23:59:59  zt10x 23:59:59  zt11s 23:59:59  zt11x 23:59:59  zt12s 23:59:59  zt12x 23:59:59  zt13s 23:59:59  zt13x 23:59:59  zt14s 23:59:59  zt14x 23:59:59  zt15s 23:59:59  zt15x 23:59:59  "
                            End If
                        Else
                            copytext2 = copytext2 & "  zm8s 23:59:59  zm8x 23:59:59  zm9s 23:59:59  zm9x 23:59:59  zm10s 23:59:59  zm10x 23:59:59  zm11s 23:59:59  zm11x 23:59:59  zm12s 23:59:59  zm12x 23:59:59  zm13s 23:59:59  zm13x 23:59:59  zm14s 23:59:59  zm14x 23:59:59  zm15s 23:59:59  zm15x 23:59:59" & "  zt1s " & zxtime("zm1s") & "  zt1x " & zxtime("zm1x") & "  zt2s " & zxtime("zm2s") & "  zt2x " & zxtime("zm2x") & "  zt3s " & zxtime("zm3s") & "  zt3x " & zxtime("zm3x") & "  zt4s " & zxtime("zm4s") & "  zt4x " & zxtime("zm4x") & "  zt5s " & zxtime("zf5s") & "  zt5x " & zxtime("zf5x") & "  zt6s " & zxtime("zf6s") & "  zt6x " & zxtime("zf6x") & "  zt7s 23:59:59  zt7x 23:59:59  zt8s 23:59:59  zt8x 23:59:59  zt9s 23:59:59  zt9x 23:59:59  zt10s 23:59:59  zt10x 23:59:59  zt11s 23:59:59  zt11x 23:59:59  zt12s 23:59:59  zt12x 23:59:59  zt13s 23:59:59  zt13x 23:59:59  zt14s 23:59:59  zt14x 23:59:59  zt15s 23:59:59  zt15x 23:59:59  "
                        End If
                    Else
                        copytext2 = copytext2 & "  zm7s 23:59:59  zm7x 23:59:59  zm8s 23:59:59  zm8x 23:59:59  zm9s 23:59:59  zm9x 23:59:59  zm10s 23:59:59  zm10x 23:59:59  zm11s 23:59:59  zm11x 23:59:59  zm12s 23:59:59  zm12x 23:59:59  zm13s 23:59:59  zm13x 23:59:59  zm14s 23:59:59  zm14x 23:59:59  zm15s 23:59:59  zm15x 23:59:59" & "  zt1s " & zxtime("zm1s") & "  zt1x " & zxtime("zm1x") & "  zt2s " & zxtime("zm2s") & "  zt2x " & zxtime("zm2x") & "  zt3s " & zxtime("zm3s") & "  zt3x " & zxtime("zm3x") & "  zt4s " & zxtime("zm4s") & "  zt4x " & zxtime("zm4x") & "  zt5s " & zxtime("zf5s") & "  zt5x " & zxtime("zf5x") & "  zt6s " & zxtime("zf6s") & "  zt6x " & zxtime("zf6x") & "  zt7s 23:59:59  zt7x 23:59:59  zt8s 23:59:59  zt8x 23:59:59  zt9s 23:59:59  zt9x 23:59:59  zt10s 23:59:59  zt10x 23:59:59  zt11s 23:59:59  zt11x 23:59:59  zt12s 23:59:59  zt12x 23:59:59  zt13s 23:59:59  zt13x 23:59:59  zt14s 23:59:59  zt14x 23:59:59  zt15s 23:59:59  zt15x 23:59:59  "
                    End If
                Else
                    copytext2 = copytext2 & "  zm6s 23:59:59  zm6x 23:59:59  zm7s 23:59:59  zm7x 23:59:59  zm8s 23:59:59  zm8x 23:59:59  zm9s 23:59:59  zm9x 23:59:59  zm10s 23:59:59  zm10x 23:59:59  zm11s 23:59:59  zm11x 23:59:59  zm12s 23:59:59  zm12x 23:59:59  zm13s 23:59:59  zm13x 23:59:59  zm14s 23:59:59  zm14x 23:59:59  zm15s 23:59:59  zm15x 23:59:59" & "  zt1s " & zxtime("zm1s") & "  zt1x " & zxtime("zm1x") & "  zt2s " & zxtime("zm2s") & "  zt2x " & zxtime("zm2x") & "  zt3s " & zxtime("zm3s") & "  zt3x " & zxtime("zm3x") & "  zt4s " & zxtime("zm4s") & "  zt4x " & zxtime("zm4x") & "  zt5s " & zxtime("zf5s") & "  zt5x " & zxtime("zf5x") & "  zt6s " & zxtime("zf6s") & "  zt6x " & zxtime("zf6x") & "  zt7s 23:59:59  zt7x 23:59:59  zt8s 23:59:59  zt8x 23:59:59  zt9s 23:59:59  zt9x 23:59:59  zt10s 23:59:59  zt10x 23:59:59  zt11s 23:59:59  zt11x 23:59:59  zt12s 23:59:59  zt12x 23:59:59  zt13s 23:59:59  zt13x 23:59:59  zt14s 23:59:59  zt14x 23:59:59  zt15s 23:59:59  zt15x 23:59:59  "
                End If
            Else
                copytext2 = copytext2 & "  zm5s 23:59:59  zm5x 23:59:59  zm6s 23:59:59  zm6x 23:59:59  zm7s 23:59:59  zm7x 23:59:59  zm8s 23:59:59  zm8x 23:59:59  zm9s 23:59:59  zm9x 23:59:59  zm10s 23:59:59  zm10x 23:59:59  zm11s 23:59:59  zm11x 23:59:59  zm12s 23:59:59  zm12x 23:59:59  zm13s 23:59:59  zm13x 23:59:59  zm14s 23:59:59  zm14x 23:59:59  zm15s 23:59:59  zm15x 23:59:59" & "  zt1s " & zxtime("zm1s") & "  zt1x " & zxtime("zm1x") & "  zt2s " & zxtime("zm2s") & "  zt2x " & zxtime("zm2x") & "  zt3s " & zxtime("zm3s") & "  zt3x " & zxtime("zm3x") & "  zt4s " & zxtime("zm4s") & "  zt4x " & zxtime("zm4x") & "  zt5s " & zxtime("zf5s") & "  zt5x " & zxtime("zf5x") & "  zt6s " & zxtime("zf6s") & "  zt6x " & zxtime("zf6x") & "  zt7s 23:59:59  zt7x 23:59:59  zt8s 23:59:59  zt8x 23:59:59  zt9s 23:59:59  zt9x 23:59:59  zt10s 23:59:59  zt10x 23:59:59  zt11s 23:59:59  zt11x 23:59:59  zt12s 23:59:59  zt12x 23:59:59  zt13s 23:59:59  zt13x 23:59:59  zt14s 23:59:59  zt14x 23:59:59  zt15s 23:59:59  zt15x 23:59:59  "
            End If
        ElseIf bb = 6 Then
            copytext2 = "  zm1s " & zxtime("zm1s") & "  zm1x " & zxtime("zm1x") & "  zm2s " & zxtime("zm2s") & "  zm2x " & zxtime("zm2x") & "  zm3s " & zxtime("zm3s") & "  zm3x " & zxtime("zm3x") & "  zm4s " & zxtime("zm4s") & "  zm4x " & zxtime("zm4x") & "  zm5s " & zxtime("zm5s") & "  zm5x " & zxtime("zm5x") & "  zm6s " & zxtime("zm6s") & "  zm6x " & zxtime("zm6x") & "  zm7s " & zxtime("zm7s") & "  zm7x " & zxtime("zm7x") & "  zm8s " & zxtime("zm8s") & "  zm8x " & zxtime("zm8x") & "  zm9s " & zxtime("zm9s") & "  zm9x " & zxtime("zm9x") & "  zm10s " & zxtime("zm10s") & "  zm10x " & zxtime("zm10x") & "  zm11s " & zxtime("zm11s") & "  zm11x " & zxtime("zm11x") & "  zm12s " & zxtime("zm12s") & "  zm12x " & zxtime("zm12x") & "  zm13s 23:59:59  zm13x 23:59:59  zm14s 23:59:59  zm14x 23:59:59  zm15s 23:59:59  zm15x 23:59:59" & "  zt1s " & zxtime("zm1s") & "  zt1x " & zxtime("zm1x") & "  zt2s " & zxtime("zm2s") & "  zt2x " & zxtime("zm2x") & "  zt3s " & zxtime("zm3s") & "  zt3x " & zxtime("zm3x") & "  zt4s " & zxtime("zm4s") & "  zt4x " & zxtime("zm4x") & "  zt5s " & zxtime("zf5s") & "  zt5x " & zxtime("zf5x") & "  zt6s " & zxtime("zf6s") & "  zt6x " & zxtime("zf6x") & "  zt7s 23:59:59  zt7x 23:59:59  zt8s 23:59:59  zt8x 23:59:59  zt9s 23:59:59  zt9x 23:59:59  zt10s 23:59:59  zt10x 23:59:59  zt11s 23:59:59  zt11x 23:59:59  zt12s 23:59:59  zt12x 23:59:59  zt13s 23:59:59  zt13x 23:59:59  zt14s 23:59:59  zt14x 23:59:59  zt15s 23:59:59  zt15x 23:59:59  "
        End If
        My.Computer.FileSystem.WriteAllText("data\cl1\timelist.txt", copytext2, False)
    End Sub

    Public Sub dr1d()
        Dim ts As String
        Label6.ForeColor = Color.Green
        ts = "导入成功"
        Try
            tmdr("atlink1.txt")
            tmdr("atlink2.txt")
            tmdr("atlink3.txt")
            tmdr("atlink4.txt")
            tmdr("atoc1.txt")
            tmdr("atoc2.txt")
            tmdr("atoc3.txt")
            tmdr("atoc4.txt")
            tmdr("attime1.txt")
            tmdr("attime2.txt")
            tmdr("attime3.txt")
            tmdr("attime4.txt")
            tmdr("name.txt")
            tmdr("namec.txt")
            My.Computer.FileSystem.WriteAllText("data\psw.txt", EncryptData(My.Computer.FileSystem.ReadAllText(datapath & "\pswtc.txt").Replace(vbCrLf, "")), False)
            tmdr("skatlink.txt")
            tmdr("skatoc.txt")
            tmdr("xkatlink.txt")
            tmdr("xkatoc.txt")
            tmdr("tctask1.txt")
            tmdr("tctask2.txt")
            tmdr("tctimejy.txt")
            tmdr("tctimejj.txt")
            tmdr("tcllq.txt")
            tmdr("tcmgr.txt")
            My.Computer.FileSystem.WriteAllText("data\cl1\tss.txt", "5", False)
            drkb(5)
            My.Computer.FileSystem.WriteAllText("data\cl1\z6.txt", "ct 05    c1 今    c2 天    c3 不    c4 上    c5 课    c6     c7     c8     c9     c10     c11     c12     c13     c14     c15   ", False)
            My.Computer.FileSystem.WriteAllText("data\cl1\z7.txt", "ct 05    c1 今    c2 天    c3 不    c4 上    c5 课    c6     c7     c8     c9     c10     c11     c12     c13     c14     c15   ", False)
            drsj(1)
            My.Computer.FileSystem.WriteAllText("data\cl.txt", "0", False)
        Catch ex As Exception
            ts = ex.Message
            Label6.ForeColor = Color.Red
        Finally
            Label6.Text = ts
        End Try
    End Sub

    Public Sub dr2d()
        Dim ts As String
        Label6.ForeColor = Color.Green
        ts = "导入成功"
        Try
            tmdr("atlink1.txt")
            tmdr("atlink2.txt")
            tmdr("atlink3.txt")
            tmdr("atlink4.txt")
            tmdr("atoc1.txt")
            tmdr("atoc2.txt")
            tmdr("atoc3.txt")
            tmdr("atoc4.txt")
            tmdr("attime1.txt")
            tmdr("attime2.txt")
            tmdr("attime3.txt")
            tmdr("attime4.txt")
            tmdr("name.txt")
            tmdr("namec.txt")
            My.Computer.FileSystem.WriteAllText("data\psw.txt", EncryptData(My.Computer.FileSystem.ReadAllText(datapath & "\pswtc.txt").Replace(vbCrLf, "")), False)
            tmdr("skatlink.txt")
            tmdr("skatoc.txt")
            tmdr("xkatlink.txt")
            tmdr("xkatoc.txt")
            tmdr("tctask1.txt")
            tmdr("tctask2.txt")
            tmdr("tctimejy.txt")
            tmdr("tctimejj.txt")
            tmdr("tcllq.txt")
            tmdr("tcmgr.txt")
            tmdr("djstime.txt")
            tmdr("djstext.txt")
            ymdr("zdgj.txt", "autostd.txt")
            ymdr("autostd.txt", "autostdt.txt")
            My.Computer.FileSystem.WriteAllText("data\cl1\tss.txt", "5", False)
            drkb(5)
            My.Computer.FileSystem.WriteAllText("data\cl1\z6.txt", "ct 05    c1 今    c2 天    c3 不    c4 上    c5 课    c6     c7     c8     c9     c10     c11     c12     c13     c14     c15   ", False)
            My.Computer.FileSystem.WriteAllText("data\cl1\z7.txt", "ct 05    c1 今    c2 天    c3 不    c4 上    c5 课    c6     c7     c8     c9     c10     c11     c12     c13     c14     c15   ", False)
            drsj(2)
            My.Computer.FileSystem.WriteAllText("data\cl.txt", "0", False)
        Catch ex As Exception
            ts = ex.Message
            Label6.ForeColor = Color.Red
        Finally
            Label6.Text = ts
        End Try
    End Sub

    Public Sub dr3d()
        Dim ts As String
        Label6.ForeColor = Color.Green
        ts = "导入成功"
        Try
            tmdr("atlink1.txt")
            tmdr("atlink2.txt")
            tmdr("atlink3.txt")
            tmdr("atlink4.txt")
            tmdr("atoc1.txt")
            tmdr("atoc2.txt")
            tmdr("atoc3.txt")
            tmdr("atoc4.txt")
            tmdr("attime1.txt")
            tmdr("attime2.txt")
            tmdr("attime3.txt")
            tmdr("attime4.txt")
            tmdr("name.txt")
            tmdr("namec.txt")
            My.Computer.FileSystem.WriteAllText("data\psw.txt", EncryptData(My.Computer.FileSystem.ReadAllText(datapath & "\pswtc.txt").Replace(vbCrLf, "")), False)
            tmdr("skatlink.txt")
            tmdr("skatoc.txt")
            tmdr("xkatlink.txt")
            tmdr("xkatoc.txt")
            tmdr("tctask1.txt")
            tmdr("tctask2.txt")
            tmdr("tctimejy.txt")
            tmdr("tctimejj.txt")
            tmdr("tcllq.txt")
            tmdr("tcmgr.txt")
            tmdr("djstime.txt")
            tmdr("djstext.txt")
            ymdr("zdgj.txt", "autostd.txt")
            ymdr("autostd.txt", "autostdt.txt")
            ymdr("fx.txt", "cl1\tss.txt")
            drkb(7)
            drsj(3)
            My.Computer.FileSystem.WriteAllText("data\cl.txt", "0", False)
        Catch ex As Exception
            ts = ex.Message
            Label6.ForeColor = Color.Red
        Finally
            Label6.Text = ts
        End Try
    End Sub

    Public Sub dr4d()
        Dim ts As String
        Label6.ForeColor = Color.Green
        ts = "导入成功"
        Try
            tmdr("atlink1.txt")
            tmdr("atlink2.txt")
            tmdr("atlink3.txt")
            tmdr("atlink4.txt")
            tmdr("atoc1.txt")
            tmdr("atoc2.txt")
            tmdr("atoc3.txt")
            tmdr("atoc4.txt")
            tmdr("attime1.txt")
            tmdr("attime2.txt")
            tmdr("attime3.txt")
            tmdr("attime4.txt")
            tmdr("name.txt")
            tmdr("namec.txt")
            My.Computer.FileSystem.WriteAllText("data\psw.txt", EncryptData(My.Computer.FileSystem.ReadAllText(datapath & "\pswtc.txt").Replace(vbCrLf, "")), False)
            tmdr("skatlink.txt")
            tmdr("skatoc.txt")
            tmdr("xkatlink.txt")
            tmdr("xkatoc.txt")
            tmdr("tctask1.txt")
            tmdr("tctask2.txt")
            tmdr("tctimejy.txt")
            tmdr("tctimejj.txt")
            tmdr("tcllq.txt")
            tmdr("tcmgr.txt")
            tmdr("djstime.txt")
            tmdr("djstext.txt")
            tmdr("dt.txt")
            ymdr("zdgj.txt", "autostd.txt")
            ymdr("autostd.txt", "autostdt.txt")
            ymdr("fx.txt", "cl1\tss.txt")
            drkb(7)
            drsj(4)
            My.Computer.FileSystem.WriteAllText("data\cl.txt", "0", False)
        Catch ex As Exception
            ts = ex.Message
            Label6.ForeColor = Color.Red
        Finally
            Label6.Text = ts
        End Try
    End Sub

    Public Sub dr5d()
        Dim ts As String
        Label6.ForeColor = Color.Green
        ts = "导入成功"
        Try
            tmdr("name.txt")
            tmdr("namec.txt")
            tmdr("djstime.txt")
            tmdr("djstext.txt")
            ymdr("fx.txt", "cl1\tss.txt")
            xdrkb()
            drsj(5)
            My.Computer.FileSystem.WriteAllText("data\cl.txt", "0", False)
        Catch ex As Exception
            ts = ex.Message
            Label6.ForeColor = Color.Red
        Finally
            Label6.Text = ts
        End Try
    End Sub

    Public Sub dr6d()
        Dim ts As String
        Label6.ForeColor = Color.Green
        ts = "导入成功"
        Try
            tmdr("atlink1.txt")
            tmdr("atlink2.txt")
            tmdr("atlink3.txt")
            tmdr("atlink4.txt")
            tmdr("atoc1.txt")
            tmdr("atoc2.txt")
            tmdr("atoc3.txt")
            tmdr("atoc4.txt")
            tmdr("attime1.txt")
            tmdr("attime2.txt")
            tmdr("attime3.txt")
            tmdr("attime4.txt")
            tmdr("name.txt")
            tmdr("namec.txt")
            My.Computer.FileSystem.WriteAllText("data\psw.txt", EncryptData(My.Computer.FileSystem.ReadAllText(datapath & "\pswtc.txt").Replace(vbCrLf, "")), False)
            tmdr("skatlink.txt")
            tmdr("skatoc.txt")
            tmdr("xkatlink.txt")
            tmdr("xkatoc.txt")
            tmdr("tctask1.txt")
            tmdr("tctask2.txt")
            tmdr("tctimejy.txt")
            tmdr("tctimejj.txt")
            tmdr("tcllq.txt")
            tmdr("tcmgr.txt")
            tmdr("djstime.txt")
            tmdr("djstext.txt")
            tmdr("dt.txt")
            ymdr("zdgj.txt", "autostd.txt")
            ymdr("autostd.txt", "autostdt.txt")
            ymdr("fx.txt", "cl1\tss.txt")
            xdrkb()
            drsj(6)
            My.Computer.FileSystem.WriteAllText("data\cl.txt", "0", False)
        Catch ex As Exception
            ts = ex.Message
            Label6.ForeColor = Color.Red
        Finally
            Label6.Text = ts
        End Try
    End Sub

    Public Sub dr7d()
        Dim ts As String
        Label6.ForeColor = Color.Green
        ts = "导入成功"
        Try
            tmdr7("atlink1.txt")
            tmdr7("atlink2.txt")
            tmdr7("atlink3.txt")
            tmdr7("atlink4.txt")
            tmdr7("atoc1.txt")
            tmdr7("atoc2.txt")
            tmdr7("atoc3.txt")
            tmdr7("atoc4.txt")
            tmdr7("attime1.txt")
            tmdr7("attime2.txt")
            tmdr7("attime3.txt")
            tmdr7("attime4.txt")
            tmdr7("name.txt")
            tmdr7("namec.txt")
            tmdr7("psw.txt")
            tmdr7("skatlink.txt")
            tmdr7("skatoc.txt")
            tmdr7("xkatlink.txt")
            tmdr7("xkatoc.txt")
            tmdr7("tctask1.txt")
            tmdr7("tctask2.txt")
            tmdr7("tctimejy.txt")
            tmdr7("tctimejj.txt")
            tmdr7("tcllq.txt")
            tmdr7("tcmgr.txt")
            tmdr7("djstime.txt")
            tmdr7("djstext.txt")
            tmdr7("dt.txt")
            tmdr7("autostd.txt")
            tmdr7("autostdt.txt")
            tmdr7("city.txt")
            tmdr7("cl.txt")
            tmdr7("week.txt")
            tmdr7("sx.txt")
            tmdr7("cl1\timelist.txt")
            tmdr7("cl1\tss.txt")
            tmdr7("cl1\z1.txt")
            tmdr7("cl1\z2.txt")
            tmdr7("cl1\z3.txt")
            tmdr7("cl1\z4.txt")
            tmdr7("cl1\z5.txt")
            tmdr7("cl1\z6.txt")
            tmdr7("cl1\z7.txt")
            tmdr7("cl2\timelist.txt")
            tmdr7("cl2\tss.txt")
            tmdr7("cl2\z1.txt")
            tmdr7("cl2\z2.txt")
            tmdr7("cl2\z3.txt")
            tmdr7("cl2\z4.txt")
            tmdr7("cl2\z5.txt")
            tmdr7("cl2\z6.txt")
            tmdr7("cl2\z7.txt")
        Catch ex As Exception
            ts = ex.Message
            Label6.ForeColor = Color.Red
        Finally
            Label6.Text = ts
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If RadioButton1.Checked = True Then
            dr1d()
        ElseIf RadioButton2.Checked = True Then
            If InStr(datapath, "\data") <> "0" Then
                dr2d()
            Else
                Label6.ForeColor = Color.Red
                Label6.Text = "请选择软件data文件夹"
            End If
        ElseIf RadioButton3.Checked = True Then
            If InStr(datapath, "\data") <> "0" Then
                dr3d()
            Else
                Label6.ForeColor = Color.Red
                Label6.Text = "请选择软件data文件夹"
            End If
        ElseIf RadioButton4.Checked = True Then
            If InStr(datapath, "\data") <> "0" Then
                dr4d()
            Else
                Label6.ForeColor = Color.Red
                Label6.Text = "请选择软件data文件夹"
            End If
        ElseIf RadioButton5.Checked = True Then
            If InStr(datapath, "\data") <> "0" Then
                dr5d()
            Else
                Label6.ForeColor = Color.Red
                Label6.Text = "请选择软件data文件夹"
            End If
        ElseIf RadioButton6.Checked = True Then
            If InStr(datapath, "\data") <> "0" Then
                dr6d()
            Else
                Label6.ForeColor = Color.Red
                Label6.Text = "请选择软件data文件夹"
            End If
        ElseIf RadioButton7.Checked = True Then
            If InStr(datapath, "\data") <> "0" Then
                dr7d()
            Else
                Label6.ForeColor = Color.Red
                Label6.Text = "请选择软件data文件夹"
            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Public Function zxtime(s$) As String
        If Len(s) = 4 Then
            zxtime = Trim(Mid(timlist, InStr(timlist, CStr(s)) + 4, 9))
        Else
            zxtime = Trim(Mid(timlist, InStr(timlist, CStr(s)) + 5, 9))
        End If
    End Function

    Public Function alldclass(s$, z%) As String
        Dim classlist As String
        classlist = My.Computer.FileSystem.ReadAllText("data\cl1\z" & z & ".txt")
        If Len(s) = 2 Then
            alldclass = Trim(Mid(classlist, InStr(classlist, CStr(s)) + 2, 3))
        Else
            alldclass = Trim(Mid(classlist, InStr(classlist, CStr(s)) + 3, 3))
        End If
    End Function

    Private Sub Form36_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If Label6.Text = "导入成功" Then
            rq = MsgBox("导入配置后重启软件生效" & vbCrLf & "是否重启软件?", vbOKCancel + vbQuestion, "全能班辅")
            If rq = 1 Then
                e.Cancel = True
                If dtrs = "1" Then
                    cq = False
                ElseIf dtrs = "0" Then
                    cq = True
                End If
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
                Timer1.Enabled = True
            Else
                e.Cancel = False
            End If
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Me.Left < My.Computer.Screen.Bounds.Size.Width + 600 Then
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
            Form20.Left = Form20.Left + gspeed
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

    Private Sub Form36_Load(sender As Object, e As EventArgs) Handles Me.Load
        gspeed = 1
    End Sub
End Class