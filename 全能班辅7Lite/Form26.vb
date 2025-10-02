Imports System.ComponentModel
Imports System.Net.Mime.MediaTypeNames
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button

Public Class Form26
    Dim getfc As Integer
    Dim xbox As Integer
    Dim gkb As String
    Dim bc As Boolean
    Dim rq As Integer
    Dim cl As String
    Dim ds As String

    Private Sub Form26_Load(sender As Object, e As EventArgs) Handles Me.Load
        xbox = 1
        bc = True
        cl = My.Computer.FileSystem.ReadAllText("data\cl.txt")
        If cl = "0" Then
            ds = "1"
            RadioButton1.Checked = True
            RadioButton2.Checked = False
            RadioButton1.Enabled = False
            RadioButton2.Enabled = False
        ElseIf cl = "1" Then
            ds = "1"
            RadioButton1.Checked = True
            RadioButton2.Checked = False
            RadioButton1.Enabled = True
            RadioButton2.Enabled = True
        ElseIf cl = "2" Then
            ds = "2"
            RadioButton1.Checked = False
            RadioButton2.Checked = True
            RadioButton1.Enabled = True
            RadioButton2.Enabled = True
        End If
        jzkb()
    End Sub

    Private Sub RadioButton1_Click(sender As Object, e As EventArgs) Handles RadioButton1.Click
        If RadioButton1.Checked = True And RadioButton1.Enabled = True Then
            If bc = False Then
                rq = MsgBox("您刚才做的课表更改将丢失" & vbCrLf & "是否不保存更改并切换课表?", vbOKCancel + vbQuestion, "课表编辑器")
                If rq = 1 Then
                    xbox = 1
                    ds = "1"
                    jzkb()
                Else
                    RadioButton1.Checked = False
                    RadioButton2.Checked = True
                End If
            Else
                xbox = 1
                ds = "1"
                jzkb()
            End If
        End If
    End Sub

    Private Sub RadioButton2_Click(sender As Object, e As EventArgs) Handles RadioButton2.Click
        If RadioButton2.Checked = True And RadioButton2.Enabled = True Then
            If bc = False Then
                rq = MsgBox("您刚才做的课表更改将丢失" & vbCrLf & "是否不保存更改并切换课表?", vbOKCancel + vbQuestion, "课表编辑器")
                If rq = 1 Then
                    xbox = 1
                    ds = "2"
                    jzkb()
                Else
                    RadioButton1.Checked = True
                    RadioButton2.Checked = False
                End If
            Else
                xbox = 1
                ds = "2"
                jzkb()
            End If
        End If
    End Sub

    Private Sub TextBox_TextChanged(sender As Object, e As EventArgs)
        bc = False
    End Sub

    Public Function alldclass(s$, z%) As String
        Dim classlist As String
        classlist = My.Computer.FileSystem.ReadAllText("data\cl" & ds & "\z" & z & ".txt")
        If Len(s) = 2 Then
            alldclass = Trim(Mid(classlist, InStr(classlist, CStr(s)) + 2, 4))
        Else
            alldclass = Trim(Mid(classlist, InStr(classlist, CStr(s)) + 3, 4))
        End If
    End Function

    Public Sub jzkb()
        For n = 1 To 7
            For c = 1 To 15
                If n = 1 Then
                    If c = 1 Then
                        TextBox1.Text = alldclass("c" & c, n)
                    ElseIf c = 2 Then
                        TextBox2.Text = alldclass("c" & c, n)
                    ElseIf c = 3 Then
                        TextBox3.Text = alldclass("c" & c, n)
                    ElseIf c = 4 Then
                        TextBox4.Text = alldclass("c" & c, n)
                    ElseIf c = 5 Then
                        TextBox5.Text = alldclass("c" & c, n)
                    ElseIf c = 6 Then
                        TextBox6.Text = alldclass("c" & c, n)
                    ElseIf c = 7 Then
                        TextBox7.Text = alldclass("c" & c, n)
                    ElseIf c = 8 Then
                        TextBox8.Text = alldclass("c" & c, n)
                    ElseIf c = 9 Then
                        TextBox9.Text = alldclass("c" & c, n)
                    ElseIf c = 10 Then
                        TextBox10.Text = alldclass("c" & c, n)
                    ElseIf c = 11 Then
                        TextBox11.Text = alldclass("c" & c, n)
                    ElseIf c = 12 Then
                        TextBox12.Text = alldclass("c" & c, n)
                    ElseIf c = 13 Then
                        TextBox13.Text = alldclass("c" & c, n)
                    ElseIf c = 14 Then
                        TextBox14.Text = alldclass("c" & c, n)
                    ElseIf c = 15 Then
                        TextBox15.Text = alldclass("c" & c, n)
                    End If
                ElseIf n = 2 Then
                    If c = 1 Then
                        TextBox16.Text = alldclass("c" & c, n)
                    ElseIf c = 2 Then
                        TextBox17.Text = alldclass("c" & c, n)
                    ElseIf c = 3 Then
                        TextBox18.Text = alldclass("c" & c, n)
                    ElseIf c = 4 Then
                        TextBox19.Text = alldclass("c" & c, n)
                    ElseIf c = 5 Then
                        TextBox20.Text = alldclass("c" & c, n)
                    ElseIf c = 6 Then
                        TextBox21.Text = alldclass("c" & c, n)
                    ElseIf c = 7 Then
                        TextBox22.Text = alldclass("c" & c, n)
                    ElseIf c = 8 Then
                        TextBox23.Text = alldclass("c" & c, n)
                    ElseIf c = 9 Then
                        TextBox24.Text = alldclass("c" & c, n)
                    ElseIf c = 10 Then
                        TextBox25.Text = alldclass("c" & c, n)
                    ElseIf c = 11 Then
                        TextBox26.Text = alldclass("c" & c, n)
                    ElseIf c = 12 Then
                        TextBox27.Text = alldclass("c" & c, n)
                    ElseIf c = 13 Then
                        TextBox28.Text = alldclass("c" & c, n)
                    ElseIf c = 14 Then
                        TextBox29.Text = alldclass("c" & c, n)
                    ElseIf c = 15 Then
                        TextBox30.Text = alldclass("c" & c, n)
                    End If
                ElseIf n = 3 Then
                    If c = 1 Then
                        TextBox31.Text = alldclass("c" & c, n)
                    ElseIf c = 2 Then
                        TextBox32.Text = alldclass("c" & c, n)
                    ElseIf c = 3 Then
                        TextBox33.Text = alldclass("c" & c, n)
                    ElseIf c = 4 Then
                        TextBox34.Text = alldclass("c" & c, n)
                    ElseIf c = 5 Then
                        TextBox35.Text = alldclass("c" & c, n)
                    ElseIf c = 6 Then
                        TextBox36.Text = alldclass("c" & c, n)
                    ElseIf c = 7 Then
                        TextBox37.Text = alldclass("c" & c, n)
                    ElseIf c = 8 Then
                        TextBox38.Text = alldclass("c" & c, n)
                    ElseIf c = 9 Then
                        TextBox39.Text = alldclass("c" & c, n)
                    ElseIf c = 10 Then
                        TextBox40.Text = alldclass("c" & c, n)
                    ElseIf c = 11 Then
                        TextBox41.Text = alldclass("c" & c, n)
                    ElseIf c = 12 Then
                        TextBox42.Text = alldclass("c" & c, n)
                    ElseIf c = 13 Then
                        TextBox43.Text = alldclass("c" & c, n)
                    ElseIf c = 14 Then
                        TextBox44.Text = alldclass("c" & c, n)
                    ElseIf c = 15 Then
                        TextBox45.Text = alldclass("c" & c, n)
                    End If
                ElseIf n = 4 Then
                    If c = 1 Then
                        TextBox46.Text = alldclass("c" & c, n)
                    ElseIf c = 2 Then
                        TextBox47.Text = alldclass("c" & c, n)
                    ElseIf c = 3 Then
                        TextBox48.Text = alldclass("c" & c, n)
                    ElseIf c = 4 Then
                        TextBox49.Text = alldclass("c" & c, n)
                    ElseIf c = 5 Then
                        TextBox50.Text = alldclass("c" & c, n)
                    ElseIf c = 6 Then
                        TextBox51.Text = alldclass("c" & c, n)
                    ElseIf c = 7 Then
                        TextBox52.Text = alldclass("c" & c, n)
                    ElseIf c = 8 Then
                        TextBox53.Text = alldclass("c" & c, n)
                    ElseIf c = 9 Then
                        TextBox54.Text = alldclass("c" & c, n)
                    ElseIf c = 10 Then
                        TextBox55.Text = alldclass("c" & c, n)
                    ElseIf c = 11 Then
                        TextBox56.Text = alldclass("c" & c, n)
                    ElseIf c = 12 Then
                        TextBox57.Text = alldclass("c" & c, n)
                    ElseIf c = 13 Then
                        TextBox58.Text = alldclass("c" & c, n)
                    ElseIf c = 14 Then
                        TextBox59.Text = alldclass("c" & c, n)
                    ElseIf c = 15 Then
                        TextBox60.Text = alldclass("c" & c, n)
                    End If
                ElseIf n = 5 Then
                    If c = 1 Then
                        TextBox61.Text = alldclass("c" & c, n)
                    ElseIf c = 2 Then
                        TextBox62.Text = alldclass("c" & c, n)
                    ElseIf c = 3 Then
                        TextBox63.Text = alldclass("c" & c, n)
                    ElseIf c = 4 Then
                        TextBox64.Text = alldclass("c" & c, n)
                    ElseIf c = 5 Then
                        TextBox65.Text = alldclass("c" & c, n)
                    ElseIf c = 6 Then
                        TextBox66.Text = alldclass("c" & c, n)
                    ElseIf c = 7 Then
                        TextBox67.Text = alldclass("c" & c, n)
                    ElseIf c = 8 Then
                        TextBox68.Text = alldclass("c" & c, n)
                    ElseIf c = 9 Then
                        TextBox69.Text = alldclass("c" & c, n)
                    ElseIf c = 10 Then
                        TextBox70.Text = alldclass("c" & c, n)
                    ElseIf c = 11 Then
                        TextBox71.Text = alldclass("c" & c, n)
                    ElseIf c = 12 Then
                        TextBox72.Text = alldclass("c" & c, n)
                    ElseIf c = 13 Then
                        TextBox73.Text = alldclass("c" & c, n)
                    ElseIf c = 14 Then
                        TextBox74.Text = alldclass("c" & c, n)
                    ElseIf c = 15 Then
                        TextBox75.Text = alldclass("c" & c, n)
                    End If
                ElseIf n = 6 Then
                    If c = 1 Then
                        TextBox76.Text = alldclass("c" & c, n)
                    ElseIf c = 2 Then
                        TextBox77.Text = alldclass("c" & c, n)
                    ElseIf c = 3 Then
                        TextBox78.Text = alldclass("c" & c, n)
                    ElseIf c = 4 Then
                        TextBox79.Text = alldclass("c" & c, n)
                    ElseIf c = 5 Then
                        TextBox80.Text = alldclass("c" & c, n)
                    ElseIf c = 6 Then
                        TextBox81.Text = alldclass("c" & c, n)
                    ElseIf c = 7 Then
                        TextBox82.Text = alldclass("c" & c, n)
                    ElseIf c = 8 Then
                        TextBox83.Text = alldclass("c" & c, n)
                    ElseIf c = 9 Then
                        TextBox84.Text = alldclass("c" & c, n)
                    ElseIf c = 10 Then
                        TextBox85.Text = alldclass("c" & c, n)
                    ElseIf c = 11 Then
                        TextBox86.Text = alldclass("c" & c, n)
                    ElseIf c = 12 Then
                        TextBox87.Text = alldclass("c" & c, n)
                    ElseIf c = 13 Then
                        TextBox88.Text = alldclass("c" & c, n)
                    ElseIf c = 14 Then
                        TextBox89.Text = alldclass("c" & c, n)
                    ElseIf c = 15 Then
                        TextBox90.Text = alldclass("c" & c, n)
                    End If
                ElseIf n = 7 Then
                    If c = 1 Then
                        TextBox91.Text = alldclass("c" & c, n)
                    ElseIf c = 2 Then
                        TextBox92.Text = alldclass("c" & c, n)
                    ElseIf c = 3 Then
                        TextBox93.Text = alldclass("c" & c, n)
                    ElseIf c = 4 Then
                        TextBox94.Text = alldclass("c" & c, n)
                    ElseIf c = 5 Then
                        TextBox95.Text = alldclass("c" & c, n)
                    ElseIf c = 6 Then
                        TextBox96.Text = alldclass("c" & c, n)
                    ElseIf c = 7 Then
                        TextBox97.Text = alldclass("c" & c, n)
                    ElseIf c = 8 Then
                        TextBox98.Text = alldclass("c" & c, n)
                    ElseIf c = 9 Then
                        TextBox99.Text = alldclass("c" & c, n)
                    ElseIf c = 10 Then
                        TextBox100.Text = alldclass("c" & c, n)
                    ElseIf c = 11 Then
                        TextBox101.Text = alldclass("c" & c, n)
                    ElseIf c = 12 Then
                        TextBox102.Text = alldclass("c" & c, n)
                    ElseIf c = 13 Then
                        TextBox103.Text = alldclass("c" & c, n)
                    ElseIf c = 14 Then
                        TextBox104.Text = alldclass("c" & c, n)
                    ElseIf c = 15 Then
                        TextBox105.Text = alldclass("c" & c, n)
                    End If
                End If
            Next c
        Next n
        bc = True
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is TextBox Then
                AddHandler ctrl.TextChanged, AddressOf TextBox_TextChanged
            End If
        Next
    End Sub

    Public Sub bckb()
        If TextBox5.Text = "" Then
            gkb = "ct 04   c1 " & TextBox1.Text & "    c2 " & TextBox2.Text & "    c3 " & TextBox3.Text & "    c4 " & TextBox4.Text & "    c5 " & TextBox5.Text & "    c6 " & TextBox6.Text & "    c7 " & TextBox7.Text & "    c8 " & TextBox8.Text & "    c9 " & TextBox9.Text & "    c10 " & TextBox10.Text & "    c11 " & TextBox11.Text & "    c12 " & TextBox12.Text & "    c13 " & TextBox13.Text & "    c14 " & TextBox14.Text & "    c15 " & TextBox15.Text & "  "
        ElseIf TextBox6.Text = "" Then
            gkb = "ct 05   c1 " & TextBox1.Text & "    c2 " & TextBox2.Text & "    c3 " & TextBox3.Text & "    c4 " & TextBox4.Text & "    c5 " & TextBox5.Text & "    c6 " & TextBox6.Text & "    c7 " & TextBox7.Text & "    c8 " & TextBox8.Text & "    c9 " & TextBox9.Text & "    c10 " & TextBox10.Text & "    c11 " & TextBox11.Text & "    c12 " & TextBox12.Text & "    c13 " & TextBox13.Text & "    c14 " & TextBox14.Text & "    c15 " & TextBox15.Text & "  "
        ElseIf TextBox7.Text = "" Then
            gkb = "ct 06   c1 " & TextBox1.Text & "    c2 " & TextBox2.Text & "    c3 " & TextBox3.Text & "    c4 " & TextBox4.Text & "    c5 " & TextBox5.Text & "    c6 " & TextBox6.Text & "    c7 " & TextBox7.Text & "    c8 " & TextBox8.Text & "    c9 " & TextBox9.Text & "    c10 " & TextBox10.Text & "    c11 " & TextBox11.Text & "    c12 " & TextBox12.Text & "    c13 " & TextBox13.Text & "    c14 " & TextBox14.Text & "    c15 " & TextBox15.Text & "  "
        ElseIf TextBox8.Text = "" Then
            gkb = "ct 07   c1 " & TextBox1.Text & "    c2 " & TextBox2.Text & "    c3 " & TextBox3.Text & "    c4 " & TextBox4.Text & "    c5 " & TextBox5.Text & "    c6 " & TextBox6.Text & "    c7 " & TextBox7.Text & "    c8 " & TextBox8.Text & "    c9 " & TextBox9.Text & "    c10 " & TextBox10.Text & "    c11 " & TextBox11.Text & "    c12 " & TextBox12.Text & "    c13 " & TextBox13.Text & "    c14 " & TextBox14.Text & "    c15 " & TextBox15.Text & "  "
        ElseIf TextBox9.Text = "" Then
            gkb = "ct 08   c1 " & TextBox1.Text & "    c2 " & TextBox2.Text & "    c3 " & TextBox3.Text & "    c4 " & TextBox4.Text & "    c5 " & TextBox5.Text & "    c6 " & TextBox6.Text & "    c7 " & TextBox7.Text & "    c8 " & TextBox8.Text & "    c9 " & TextBox9.Text & "    c10 " & TextBox10.Text & "    c11 " & TextBox11.Text & "    c12 " & TextBox12.Text & "    c13 " & TextBox13.Text & "    c14 " & TextBox14.Text & "    c15 " & TextBox15.Text & "  "
        ElseIf TextBox10.Text = "" Then
            gkb = "ct 09   c1 " & TextBox1.Text & "    c2 " & TextBox2.Text & "    c3 " & TextBox3.Text & "    c4 " & TextBox4.Text & "    c5 " & TextBox5.Text & "    c6 " & TextBox6.Text & "    c7 " & TextBox7.Text & "    c8 " & TextBox8.Text & "    c9 " & TextBox9.Text & "    c10 " & TextBox10.Text & "    c11 " & TextBox11.Text & "    c12 " & TextBox12.Text & "    c13 " & TextBox13.Text & "    c14 " & TextBox14.Text & "    c15 " & TextBox15.Text & "  "
        ElseIf TextBox11.Text = "" Then
            gkb = "ct 10   c1 " & TextBox1.Text & "    c2 " & TextBox2.Text & "    c3 " & TextBox3.Text & "    c4 " & TextBox4.Text & "    c5 " & TextBox5.Text & "    c6 " & TextBox6.Text & "    c7 " & TextBox7.Text & "    c8 " & TextBox8.Text & "    c9 " & TextBox9.Text & "    c10 " & TextBox10.Text & "    c11 " & TextBox11.Text & "    c12 " & TextBox12.Text & "    c13 " & TextBox13.Text & "    c14 " & TextBox14.Text & "    c15 " & TextBox15.Text & "  "
        ElseIf TextBox12.Text = "" Then
            gkb = "ct 11   c1 " & TextBox1.Text & "    c2 " & TextBox2.Text & "    c3 " & TextBox3.Text & "    c4 " & TextBox4.Text & "    c5 " & TextBox5.Text & "    c6 " & TextBox6.Text & "    c7 " & TextBox7.Text & "    c8 " & TextBox8.Text & "    c9 " & TextBox9.Text & "    c10 " & TextBox10.Text & "    c11 " & TextBox11.Text & "    c12 " & TextBox12.Text & "    c13 " & TextBox13.Text & "    c14 " & TextBox14.Text & "    c15 " & TextBox15.Text & "  "
        ElseIf TextBox13.Text = "" Then
            gkb = "ct 12   c1 " & TextBox1.Text & "    c2 " & TextBox2.Text & "    c3 " & TextBox3.Text & "    c4 " & TextBox4.Text & "    c5 " & TextBox5.Text & "    c6 " & TextBox6.Text & "    c7 " & TextBox7.Text & "    c8 " & TextBox8.Text & "    c9 " & TextBox9.Text & "    c10 " & TextBox10.Text & "    c11 " & TextBox11.Text & "    c12 " & TextBox12.Text & "    c13 " & TextBox13.Text & "    c14 " & TextBox14.Text & "    c15 " & TextBox15.Text & "  "
        ElseIf TextBox14.Text = "" Then
            gkb = "ct 13   c1 " & TextBox1.Text & "    c2 " & TextBox2.Text & "    c3 " & TextBox3.Text & "    c4 " & TextBox4.Text & "    c5 " & TextBox5.Text & "    c6 " & TextBox6.Text & "    c7 " & TextBox7.Text & "    c8 " & TextBox8.Text & "    c9 " & TextBox9.Text & "    c10 " & TextBox10.Text & "    c11 " & TextBox11.Text & "    c12 " & TextBox12.Text & "    c13 " & TextBox13.Text & "    c14 " & TextBox14.Text & "    c15 " & TextBox15.Text & "  "
        ElseIf TextBox15.Text = "" Then
            gkb = "ct 14   c1 " & TextBox1.Text & "    c2 " & TextBox2.Text & "    c3 " & TextBox3.Text & "    c4 " & TextBox4.Text & "    c5 " & TextBox5.Text & "    c6 " & TextBox6.Text & "    c7 " & TextBox7.Text & "    c8 " & TextBox8.Text & "    c9 " & TextBox9.Text & "    c10 " & TextBox10.Text & "    c11 " & TextBox11.Text & "    c12 " & TextBox12.Text & "    c13 " & TextBox13.Text & "    c14 " & TextBox14.Text & "    c15 " & TextBox15.Text & "  "
        ElseIf Not TextBox15.Text = "" Then
            gkb = "ct 15   c1 " & TextBox1.Text & "    c2 " & TextBox2.Text & "    c3 " & TextBox3.Text & "    c4 " & TextBox4.Text & "    c5 " & TextBox5.Text & "    c6 " & TextBox6.Text & "    c7 " & TextBox7.Text & "    c8 " & TextBox8.Text & "    c9 " & TextBox9.Text & "    c10 " & TextBox10.Text & "    c11 " & TextBox11.Text & "    c12 " & TextBox12.Text & "    c13 " & TextBox13.Text & "    c14 " & TextBox14.Text & "    c15 " & TextBox15.Text & "  "
        Else
            MsgBox("课表不得少于4节课")
        End If
        If RadioButton1.Checked = True Then
            My.Computer.FileSystem.WriteAllText("data\cl1\z1.txt", gkb, False)
        ElseIf RadioButton2.Checked = True Then
            My.Computer.FileSystem.WriteAllText("data\cl2\z1.txt", gkb, False)
        End If
        If TextBox20.Text = "" Then
            gkb = "ct 04   c1 " & TextBox16.Text & "    c2 " & TextBox17.Text & "    c3 " & TextBox18.Text & "    c4 " & TextBox19.Text & "    c5 " & TextBox20.Text & "    c6 " & TextBox21.Text & "    c7 " & TextBox22.Text & "    c8 " & TextBox23.Text & "    c9 " & TextBox24.Text & "    c10 " & TextBox25.Text & "    c11 " & TextBox26.Text & "    c12 " & TextBox27.Text & "    c13 " & TextBox28.Text & "    c14 " & TextBox29.Text & "    c15 " & TextBox30.Text & "  "
        ElseIf TextBox21.Text = "" Then
            gkb = "ct 05   c1 " & TextBox16.Text & "    c2 " & TextBox17.Text & "    c3 " & TextBox18.Text & "    c4 " & TextBox19.Text & "    c5 " & TextBox20.Text & "    c6 " & TextBox21.Text & "    c7 " & TextBox22.Text & "    c8 " & TextBox23.Text & "    c9 " & TextBox24.Text & "    c10 " & TextBox25.Text & "    c11 " & TextBox26.Text & "    c12 " & TextBox27.Text & "    c13 " & TextBox28.Text & "    c14 " & TextBox29.Text & "    c15 " & TextBox30.Text & "  "
        ElseIf TextBox22.Text = "" Then
            gkb = "ct 06   c1 " & TextBox16.Text & "    c2 " & TextBox17.Text & "    c3 " & TextBox18.Text & "    c4 " & TextBox19.Text & "    c5 " & TextBox20.Text & "    c6 " & TextBox21.Text & "    c7 " & TextBox22.Text & "    c8 " & TextBox23.Text & "    c9 " & TextBox24.Text & "    c10 " & TextBox25.Text & "    c11 " & TextBox26.Text & "    c12 " & TextBox27.Text & "    c13 " & TextBox28.Text & "    c14 " & TextBox29.Text & "    c15 " & TextBox30.Text & "  "
        ElseIf TextBox23.Text = "" Then
            gkb = "ct 07   c1 " & TextBox16.Text & "    c2 " & TextBox17.Text & "    c3 " & TextBox18.Text & "    c4 " & TextBox19.Text & "    c5 " & TextBox20.Text & "    c6 " & TextBox21.Text & "    c7 " & TextBox22.Text & "    c8 " & TextBox23.Text & "    c9 " & TextBox24.Text & "    c10 " & TextBox25.Text & "    c11 " & TextBox26.Text & "    c12 " & TextBox27.Text & "    c13 " & TextBox28.Text & "    c14 " & TextBox29.Text & "    c15 " & TextBox30.Text & "  "
        ElseIf TextBox24.Text = "" Then
            gkb = "ct 08   c1 " & TextBox16.Text & "    c2 " & TextBox17.Text & "    c3 " & TextBox18.Text & "    c4 " & TextBox19.Text & "    c5 " & TextBox20.Text & "    c6 " & TextBox21.Text & "    c7 " & TextBox22.Text & "    c8 " & TextBox23.Text & "    c9 " & TextBox24.Text & "    c10 " & TextBox25.Text & "    c11 " & TextBox26.Text & "    c12 " & TextBox27.Text & "    c13 " & TextBox28.Text & "    c14 " & TextBox29.Text & "    c15 " & TextBox30.Text & "  "
        ElseIf TextBox25.Text = "" Then
            gkb = "ct 09   c1 " & TextBox16.Text & "    c2 " & TextBox17.Text & "    c3 " & TextBox18.Text & "    c4 " & TextBox19.Text & "    c5 " & TextBox20.Text & "    c6 " & TextBox21.Text & "    c7 " & TextBox22.Text & "    c8 " & TextBox23.Text & "    c9 " & TextBox24.Text & "    c10 " & TextBox25.Text & "    c11 " & TextBox26.Text & "    c12 " & TextBox27.Text & "    c13 " & TextBox28.Text & "    c14 " & TextBox29.Text & "    c15 " & TextBox30.Text & "  "
        ElseIf TextBox26.Text = "" Then
            gkb = "ct 10   c1 " & TextBox16.Text & "    c2 " & TextBox17.Text & "    c3 " & TextBox18.Text & "    c4 " & TextBox19.Text & "    c5 " & TextBox20.Text & "    c6 " & TextBox21.Text & "    c7 " & TextBox22.Text & "    c8 " & TextBox23.Text & "    c9 " & TextBox24.Text & "    c10 " & TextBox25.Text & "    c11 " & TextBox26.Text & "    c12 " & TextBox27.Text & "    c13 " & TextBox28.Text & "    c14 " & TextBox29.Text & "    c15 " & TextBox30.Text & "  "
        ElseIf TextBox27.Text = "" Then
            gkb = "ct 11   c1 " & TextBox16.Text & "    c2 " & TextBox17.Text & "    c3 " & TextBox18.Text & "    c4 " & TextBox19.Text & "    c5 " & TextBox20.Text & "    c6 " & TextBox21.Text & "    c7 " & TextBox22.Text & "    c8 " & TextBox23.Text & "    c9 " & TextBox24.Text & "    c10 " & TextBox25.Text & "    c11 " & TextBox26.Text & "    c12 " & TextBox27.Text & "    c13 " & TextBox28.Text & "    c14 " & TextBox29.Text & "    c15 " & TextBox30.Text & "  "
        ElseIf TextBox28.Text = "" Then
            gkb = "ct 12   c1 " & TextBox16.Text & "    c2 " & TextBox17.Text & "    c3 " & TextBox18.Text & "    c4 " & TextBox19.Text & "    c5 " & TextBox20.Text & "    c6 " & TextBox21.Text & "    c7 " & TextBox22.Text & "    c8 " & TextBox23.Text & "    c9 " & TextBox24.Text & "    c10 " & TextBox25.Text & "    c11 " & TextBox26.Text & "    c12 " & TextBox27.Text & "    c13 " & TextBox28.Text & "    c14 " & TextBox29.Text & "    c15 " & TextBox30.Text & "  "
        ElseIf TextBox29.Text = "" Then
            gkb = "ct 13   c1 " & TextBox16.Text & "    c2 " & TextBox17.Text & "    c3 " & TextBox18.Text & "    c4 " & TextBox19.Text & "    c5 " & TextBox20.Text & "    c6 " & TextBox21.Text & "    c7 " & TextBox22.Text & "    c8 " & TextBox23.Text & "    c9 " & TextBox24.Text & "    c10 " & TextBox25.Text & "    c11 " & TextBox26.Text & "    c12 " & TextBox27.Text & "    c13 " & TextBox28.Text & "    c14 " & TextBox29.Text & "    c15 " & TextBox30.Text & "  "
        ElseIf TextBox30.Text = "" Then
            gkb = "ct 14   c1 " & TextBox16.Text & "    c2 " & TextBox17.Text & "    c3 " & TextBox18.Text & "    c4 " & TextBox19.Text & "    c5 " & TextBox20.Text & "    c6 " & TextBox21.Text & "    c7 " & TextBox22.Text & "    c8 " & TextBox23.Text & "    c9 " & TextBox24.Text & "    c10 " & TextBox25.Text & "    c11 " & TextBox26.Text & "    c12 " & TextBox27.Text & "    c13 " & TextBox28.Text & "    c14 " & TextBox29.Text & "    c15 " & TextBox30.Text & "  "
        ElseIf Not TextBox30.Text = "" Then
            gkb = "ct 15   c1 " & TextBox16.Text & "    c2 " & TextBox17.Text & "    c3 " & TextBox18.Text & "    c4 " & TextBox19.Text & "    c5 " & TextBox20.Text & "    c6 " & TextBox21.Text & "    c7 " & TextBox22.Text & "    c8 " & TextBox23.Text & "    c9 " & TextBox24.Text & "    c10 " & TextBox25.Text & "    c11 " & TextBox26.Text & "    c12 " & TextBox27.Text & "    c13 " & TextBox28.Text & "    c14 " & TextBox29.Text & "    c15 " & TextBox30.Text & "  "
        Else
            MsgBox("课表不得少于4节课")
        End If
        If RadioButton1.Checked = True Then
            My.Computer.FileSystem.WriteAllText("data\cl1\z2.txt", gkb, False)
        ElseIf RadioButton2.Checked = True Then
            My.Computer.FileSystem.WriteAllText("data\cl2\z2.txt", gkb, False)
        End If
        If TextBox35.Text = "" Then
            gkb = "ct 04   c1 " & TextBox31.Text & "    c2 " & TextBox32.Text & "    c3 " & TextBox33.Text & "    c4 " & TextBox34.Text & "    c5 " & TextBox35.Text & "    c6 " & TextBox36.Text & "    c7 " & TextBox37.Text & "    c8 " & TextBox38.Text & "    c9 " & TextBox39.Text & "    c10 " & TextBox40.Text & "    c11 " & TextBox41.Text & "    c12 " & TextBox42.Text & "    c13 " & TextBox43.Text & "    c14 " & TextBox44.Text & "    c15 " & TextBox45.Text & "  "
        ElseIf TextBox36.Text = "" Then
            gkb = "ct 05   c1 " & TextBox31.Text & "    c2 " & TextBox32.Text & "    c3 " & TextBox33.Text & "    c4 " & TextBox34.Text & "    c5 " & TextBox35.Text & "    c6 " & TextBox36.Text & "    c7 " & TextBox37.Text & "    c8 " & TextBox38.Text & "    c9 " & TextBox39.Text & "    c10 " & TextBox40.Text & "    c11 " & TextBox41.Text & "    c12 " & TextBox42.Text & "    c13 " & TextBox43.Text & "    c14 " & TextBox44.Text & "    c15 " & TextBox45.Text & "  "
        ElseIf TextBox37.Text = "" Then
            gkb = "ct 06   c1 " & TextBox31.Text & "    c2 " & TextBox32.Text & "    c3 " & TextBox33.Text & "    c4 " & TextBox34.Text & "    c5 " & TextBox35.Text & "    c6 " & TextBox36.Text & "    c7 " & TextBox37.Text & "    c8 " & TextBox38.Text & "    c9 " & TextBox39.Text & "    c10 " & TextBox40.Text & "    c11 " & TextBox41.Text & "    c12 " & TextBox42.Text & "    c13 " & TextBox43.Text & "    c14 " & TextBox44.Text & "    c15 " & TextBox45.Text & "  "
        ElseIf TextBox38.Text = "" Then
            gkb = "ct 07   c1 " & TextBox31.Text & "    c2 " & TextBox32.Text & "    c3 " & TextBox33.Text & "    c4 " & TextBox34.Text & "    c5 " & TextBox35.Text & "    c6 " & TextBox36.Text & "    c7 " & TextBox37.Text & "    c8 " & TextBox38.Text & "    c9 " & TextBox39.Text & "    c10 " & TextBox40.Text & "    c11 " & TextBox41.Text & "    c12 " & TextBox42.Text & "    c13 " & TextBox43.Text & "    c14 " & TextBox44.Text & "    c15 " & TextBox45.Text & "  "
        ElseIf TextBox39.Text = "" Then
            gkb = "ct 08   c1 " & TextBox31.Text & "    c2 " & TextBox32.Text & "    c3 " & TextBox33.Text & "    c4 " & TextBox34.Text & "    c5 " & TextBox35.Text & "    c6 " & TextBox36.Text & "    c7 " & TextBox37.Text & "    c8 " & TextBox38.Text & "    c9 " & TextBox39.Text & "    c10 " & TextBox40.Text & "    c11 " & TextBox41.Text & "    c12 " & TextBox42.Text & "    c13 " & TextBox43.Text & "    c14 " & TextBox44.Text & "    c15 " & TextBox45.Text & "  "
        ElseIf TextBox40.Text = "" Then
            gkb = "ct 09   c1 " & TextBox31.Text & "    c2 " & TextBox32.Text & "    c3 " & TextBox33.Text & "    c4 " & TextBox34.Text & "    c5 " & TextBox35.Text & "    c6 " & TextBox36.Text & "    c7 " & TextBox37.Text & "    c8 " & TextBox38.Text & "    c9 " & TextBox39.Text & "    c10 " & TextBox40.Text & "    c11 " & TextBox41.Text & "    c12 " & TextBox42.Text & "    c13 " & TextBox43.Text & "    c14 " & TextBox44.Text & "    c15 " & TextBox45.Text & "  "
        ElseIf TextBox41.Text = "" Then
            gkb = "ct 10   c1 " & TextBox31.Text & "    c2 " & TextBox32.Text & "    c3 " & TextBox33.Text & "    c4 " & TextBox34.Text & "    c5 " & TextBox35.Text & "    c6 " & TextBox36.Text & "    c7 " & TextBox37.Text & "    c8 " & TextBox38.Text & "    c9 " & TextBox39.Text & "    c10 " & TextBox40.Text & "    c11 " & TextBox41.Text & "    c12 " & TextBox42.Text & "    c13 " & TextBox43.Text & "    c14 " & TextBox44.Text & "    c15 " & TextBox45.Text & "  "
        ElseIf TextBox42.Text = "" Then
            gkb = "ct 11   c1 " & TextBox31.Text & "    c2 " & TextBox32.Text & "    c3 " & TextBox33.Text & "    c4 " & TextBox34.Text & "    c5 " & TextBox35.Text & "    c6 " & TextBox36.Text & "    c7 " & TextBox37.Text & "    c8 " & TextBox38.Text & "    c9 " & TextBox39.Text & "    c10 " & TextBox40.Text & "    c11 " & TextBox41.Text & "    c12 " & TextBox42.Text & "    c13 " & TextBox43.Text & "    c14 " & TextBox44.Text & "    c15 " & TextBox45.Text & "  "
        ElseIf TextBox43.Text = "" Then
            gkb = "ct 12   c1 " & TextBox31.Text & "    c2 " & TextBox32.Text & "    c3 " & TextBox33.Text & "    c4 " & TextBox34.Text & "    c5 " & TextBox35.Text & "    c6 " & TextBox36.Text & "    c7 " & TextBox37.Text & "    c8 " & TextBox38.Text & "    c9 " & TextBox39.Text & "    c10 " & TextBox40.Text & "    c11 " & TextBox41.Text & "    c12 " & TextBox42.Text & "    c13 " & TextBox43.Text & "    c14 " & TextBox44.Text & "    c15 " & TextBox45.Text & "  "
        ElseIf TextBox44.Text = "" Then
            gkb = "ct 13   c1 " & TextBox31.Text & "    c2 " & TextBox32.Text & "    c3 " & TextBox33.Text & "    c4 " & TextBox34.Text & "    c5 " & TextBox35.Text & "    c6 " & TextBox36.Text & "    c7 " & TextBox37.Text & "    c8 " & TextBox38.Text & "    c9 " & TextBox39.Text & "    c10 " & TextBox40.Text & "    c11 " & TextBox41.Text & "    c12 " & TextBox42.Text & "    c13 " & TextBox43.Text & "    c14 " & TextBox44.Text & "    c15 " & TextBox45.Text & "  "
        ElseIf TextBox45.Text = "" Then
            gkb = "ct 14   c1 " & TextBox31.Text & "    c2 " & TextBox32.Text & "    c3 " & TextBox33.Text & "    c4 " & TextBox34.Text & "    c5 " & TextBox35.Text & "    c6 " & TextBox36.Text & "    c7 " & TextBox37.Text & "    c8 " & TextBox38.Text & "    c9 " & TextBox39.Text & "    c10 " & TextBox40.Text & "    c11 " & TextBox41.Text & "    c12 " & TextBox42.Text & "    c13 " & TextBox43.Text & "    c14 " & TextBox44.Text & "    c15 " & TextBox45.Text & "  "
        ElseIf Not TextBox45.Text = "" Then
            gkb = "ct 15   c1 " & TextBox31.Text & "    c2 " & TextBox32.Text & "    c3 " & TextBox33.Text & "    c4 " & TextBox34.Text & "    c5 " & TextBox35.Text & "    c6 " & TextBox36.Text & "    c7 " & TextBox37.Text & "    c8 " & TextBox38.Text & "    c9 " & TextBox39.Text & "    c10 " & TextBox40.Text & "    c11 " & TextBox41.Text & "    c12 " & TextBox42.Text & "    c13 " & TextBox43.Text & "    c14 " & TextBox44.Text & "    c15 " & TextBox45.Text & "  "
        Else
            MsgBox("课表不得少于4节课")
        End If
        If RadioButton1.Checked = True Then
            My.Computer.FileSystem.WriteAllText("data\cl1\z3.txt", gkb, False)
        ElseIf RadioButton2.Checked = True Then
            My.Computer.FileSystem.WriteAllText("data\cl2\z3.txt", gkb, False)
        End If
        If TextBox50.Text = "" Then
            gkb = "ct 04   c1 " & TextBox46.Text & "    c2 " & TextBox47.Text & "    c3 " & TextBox48.Text & "    c4 " & TextBox49.Text & "    c5 " & TextBox50.Text & "    c6 " & TextBox51.Text & "    c7 " & TextBox52.Text & "    c8 " & TextBox53.Text & "    c9 " & TextBox54.Text & "    c10 " & TextBox55.Text & "    c11 " & TextBox56.Text & "    c12 " & TextBox57.Text & "    c13 " & TextBox58.Text & "    c14 " & TextBox59.Text & "    c15 " & TextBox60.Text & "  "
        ElseIf TextBox51.Text = "" Then
            gkb = "ct 05   c1 " & TextBox46.Text & "    c2 " & TextBox47.Text & "    c3 " & TextBox48.Text & "    c4 " & TextBox49.Text & "    c5 " & TextBox50.Text & "    c6 " & TextBox51.Text & "    c7 " & TextBox52.Text & "    c8 " & TextBox53.Text & "    c9 " & TextBox54.Text & "    c10 " & TextBox55.Text & "    c11 " & TextBox56.Text & "    c12 " & TextBox57.Text & "    c13 " & TextBox58.Text & "    c14 " & TextBox59.Text & "    c15 " & TextBox60.Text & "  "
        ElseIf TextBox52.Text = "" Then
            gkb = "ct 06   c1 " & TextBox46.Text & "    c2 " & TextBox47.Text & "    c3 " & TextBox48.Text & "    c4 " & TextBox49.Text & "    c5 " & TextBox50.Text & "    c6 " & TextBox51.Text & "    c7 " & TextBox52.Text & "    c8 " & TextBox53.Text & "    c9 " & TextBox54.Text & "    c10 " & TextBox55.Text & "    c11 " & TextBox56.Text & "    c12 " & TextBox57.Text & "    c13 " & TextBox58.Text & "    c14 " & TextBox59.Text & "    c15 " & TextBox60.Text & "  "
        ElseIf TextBox53.Text = "" Then
            gkb = "ct 07   c1 " & TextBox46.Text & "    c2 " & TextBox47.Text & "    c3 " & TextBox48.Text & "    c4 " & TextBox49.Text & "    c5 " & TextBox50.Text & "    c6 " & TextBox51.Text & "    c7 " & TextBox52.Text & "    c8 " & TextBox53.Text & "    c9 " & TextBox54.Text & "    c10 " & TextBox55.Text & "    c11 " & TextBox56.Text & "    c12 " & TextBox57.Text & "    c13 " & TextBox58.Text & "    c14 " & TextBox59.Text & "    c15 " & TextBox60.Text & "  "
        ElseIf TextBox54.Text = "" Then
            gkb = "ct 08   c1 " & TextBox46.Text & "    c2 " & TextBox47.Text & "    c3 " & TextBox48.Text & "    c4 " & TextBox49.Text & "    c5 " & TextBox50.Text & "    c6 " & TextBox51.Text & "    c7 " & TextBox52.Text & "    c8 " & TextBox53.Text & "    c9 " & TextBox54.Text & "    c10 " & TextBox55.Text & "    c11 " & TextBox56.Text & "    c12 " & TextBox57.Text & "    c13 " & TextBox58.Text & "    c14 " & TextBox59.Text & "    c15 " & TextBox60.Text & "  "
        ElseIf TextBox55.Text = "" Then
            gkb = "ct 09   c1 " & TextBox46.Text & "    c2 " & TextBox47.Text & "    c3 " & TextBox48.Text & "    c4 " & TextBox49.Text & "    c5 " & TextBox50.Text & "    c6 " & TextBox51.Text & "    c7 " & TextBox52.Text & "    c8 " & TextBox53.Text & "    c9 " & TextBox54.Text & "    c10 " & TextBox55.Text & "    c11 " & TextBox56.Text & "    c12 " & TextBox57.Text & "    c13 " & TextBox58.Text & "    c14 " & TextBox59.Text & "    c15 " & TextBox60.Text & "  "
        ElseIf TextBox56.Text = "" Then
            gkb = "ct 10   c1 " & TextBox46.Text & "    c2 " & TextBox47.Text & "    c3 " & TextBox48.Text & "    c4 " & TextBox49.Text & "    c5 " & TextBox50.Text & "    c6 " & TextBox51.Text & "    c7 " & TextBox52.Text & "    c8 " & TextBox53.Text & "    c9 " & TextBox54.Text & "    c10 " & TextBox55.Text & "    c11 " & TextBox56.Text & "    c12 " & TextBox57.Text & "    c13 " & TextBox58.Text & "    c14 " & TextBox59.Text & "    c15 " & TextBox60.Text & "  "
        ElseIf TextBox57.Text = "" Then
            gkb = "ct 11   c1 " & TextBox46.Text & "    c2 " & TextBox47.Text & "    c3 " & TextBox48.Text & "    c4 " & TextBox49.Text & "    c5 " & TextBox50.Text & "    c6 " & TextBox51.Text & "    c7 " & TextBox52.Text & "    c8 " & TextBox53.Text & "    c9 " & TextBox54.Text & "    c10 " & TextBox55.Text & "    c11 " & TextBox56.Text & "    c12 " & TextBox57.Text & "    c13 " & TextBox58.Text & "    c14 " & TextBox59.Text & "    c15 " & TextBox60.Text & "  "
        ElseIf TextBox58.Text = "" Then
            gkb = "ct 12   c1 " & TextBox46.Text & "    c2 " & TextBox47.Text & "    c3 " & TextBox48.Text & "    c4 " & TextBox49.Text & "    c5 " & TextBox50.Text & "    c6 " & TextBox51.Text & "    c7 " & TextBox52.Text & "    c8 " & TextBox53.Text & "    c9 " & TextBox54.Text & "    c10 " & TextBox55.Text & "    c11 " & TextBox56.Text & "    c12 " & TextBox57.Text & "    c13 " & TextBox58.Text & "    c14 " & TextBox59.Text & "    c15 " & TextBox60.Text & "  "
        ElseIf TextBox59.Text = "" Then
            gkb = "ct 13   c1 " & TextBox46.Text & "    c2 " & TextBox47.Text & "    c3 " & TextBox48.Text & "    c4 " & TextBox49.Text & "    c5 " & TextBox50.Text & "    c6 " & TextBox51.Text & "    c7 " & TextBox52.Text & "    c8 " & TextBox53.Text & "    c9 " & TextBox54.Text & "    c10 " & TextBox55.Text & "    c11 " & TextBox56.Text & "    c12 " & TextBox57.Text & "    c13 " & TextBox58.Text & "    c14 " & TextBox59.Text & "    c15 " & TextBox60.Text & "  "
        ElseIf TextBox60.Text = "" Then
            gkb = "ct 14   c1 " & TextBox46.Text & "    c2 " & TextBox47.Text & "    c3 " & TextBox48.Text & "    c4 " & TextBox49.Text & "    c5 " & TextBox50.Text & "    c6 " & TextBox51.Text & "    c7 " & TextBox52.Text & "    c8 " & TextBox53.Text & "    c9 " & TextBox54.Text & "    c10 " & TextBox55.Text & "    c11 " & TextBox56.Text & "    c12 " & TextBox57.Text & "    c13 " & TextBox58.Text & "    c14 " & TextBox59.Text & "    c15 " & TextBox60.Text & "  "
        ElseIf Not TextBox60.Text = "" Then
            gkb = "ct 15   c1 " & TextBox46.Text & "    c2 " & TextBox47.Text & "    c3 " & TextBox48.Text & "    c4 " & TextBox49.Text & "    c5 " & TextBox50.Text & "    c6 " & TextBox51.Text & "    c7 " & TextBox52.Text & "    c8 " & TextBox53.Text & "    c9 " & TextBox54.Text & "    c10 " & TextBox55.Text & "    c11 " & TextBox56.Text & "    c12 " & TextBox57.Text & "    c13 " & TextBox58.Text & "    c14 " & TextBox59.Text & "    c15 " & TextBox60.Text & "  "
        Else
            MsgBox("课表不得少于4节课")
        End If
        If RadioButton1.Checked = True Then
            My.Computer.FileSystem.WriteAllText("data\cl1\z4.txt", gkb, False)
        ElseIf RadioButton2.Checked = True Then
            My.Computer.FileSystem.WriteAllText("data\cl2\z4.txt", gkb, False)
        End If
        If TextBox65.Text = "" Then
            gkb = "ct 04   c1 " & TextBox61.Text & "    c2 " & TextBox62.Text & "    c3 " & TextBox63.Text & "    c4 " & TextBox64.Text & "    c5 " & TextBox65.Text & "    c6 " & TextBox66.Text & "    c7 " & TextBox67.Text & "    c8 " & TextBox68.Text & "    c9 " & TextBox69.Text & "    c10 " & TextBox70.Text & "    c11 " & TextBox71.Text & "    c12 " & TextBox72.Text & "    c13 " & TextBox73.Text & "    c14 " & TextBox74.Text & "    c15 " & TextBox75.Text & "  "
        ElseIf TextBox66.Text = "" Then
            gkb = "ct 05   c1 " & TextBox61.Text & "    c2 " & TextBox62.Text & "    c3 " & TextBox63.Text & "    c4 " & TextBox64.Text & "    c5 " & TextBox65.Text & "    c6 " & TextBox66.Text & "    c7 " & TextBox67.Text & "    c8 " & TextBox68.Text & "    c9 " & TextBox69.Text & "    c10 " & TextBox70.Text & "    c11 " & TextBox71.Text & "    c12 " & TextBox72.Text & "    c13 " & TextBox73.Text & "    c14 " & TextBox74.Text & "    c15 " & TextBox75.Text & "  "
        ElseIf TextBox67.Text = "" Then
            gkb = "ct 06   c1 " & TextBox61.Text & "    c2 " & TextBox62.Text & "    c3 " & TextBox63.Text & "    c4 " & TextBox64.Text & "    c5 " & TextBox65.Text & "    c6 " & TextBox66.Text & "    c7 " & TextBox67.Text & "    c8 " & TextBox68.Text & "    c9 " & TextBox69.Text & "    c10 " & TextBox70.Text & "    c11 " & TextBox71.Text & "    c12 " & TextBox72.Text & "    c13 " & TextBox73.Text & "    c14 " & TextBox74.Text & "    c15 " & TextBox75.Text & "  "
        ElseIf TextBox68.Text = "" Then
            gkb = "ct 07   c1 " & TextBox61.Text & "    c2 " & TextBox62.Text & "    c3 " & TextBox63.Text & "    c4 " & TextBox64.Text & "    c5 " & TextBox65.Text & "    c6 " & TextBox66.Text & "    c7 " & TextBox67.Text & "    c8 " & TextBox68.Text & "    c9 " & TextBox69.Text & "    c10 " & TextBox70.Text & "    c11 " & TextBox71.Text & "    c12 " & TextBox72.Text & "    c13 " & TextBox73.Text & "    c14 " & TextBox74.Text & "    c15 " & TextBox75.Text & "  "
        ElseIf TextBox69.Text = "" Then
            gkb = "ct 08   c1 " & TextBox61.Text & "    c2 " & TextBox62.Text & "    c3 " & TextBox63.Text & "    c4 " & TextBox64.Text & "    c5 " & TextBox65.Text & "    c6 " & TextBox66.Text & "    c7 " & TextBox67.Text & "    c8 " & TextBox68.Text & "    c9 " & TextBox69.Text & "    c10 " & TextBox70.Text & "    c11 " & TextBox71.Text & "    c12 " & TextBox72.Text & "    c13 " & TextBox73.Text & "    c14 " & TextBox74.Text & "    c15 " & TextBox75.Text & "  "
        ElseIf TextBox70.Text = "" Then
            gkb = "ct 09   c1 " & TextBox61.Text & "    c2 " & TextBox62.Text & "    c3 " & TextBox63.Text & "    c4 " & TextBox64.Text & "    c5 " & TextBox65.Text & "    c6 " & TextBox66.Text & "    c7 " & TextBox67.Text & "    c8 " & TextBox68.Text & "    c9 " & TextBox69.Text & "    c10 " & TextBox70.Text & "    c11 " & TextBox71.Text & "    c12 " & TextBox72.Text & "    c13 " & TextBox73.Text & "    c14 " & TextBox74.Text & "    c15 " & TextBox75.Text & "  "
        ElseIf TextBox71.Text = "" Then
            gkb = "ct 10   c1 " & TextBox61.Text & "    c2 " & TextBox62.Text & "    c3 " & TextBox63.Text & "    c4 " & TextBox64.Text & "    c5 " & TextBox65.Text & "    c6 " & TextBox66.Text & "    c7 " & TextBox67.Text & "    c8 " & TextBox68.Text & "    c9 " & TextBox69.Text & "    c10 " & TextBox70.Text & "    c11 " & TextBox71.Text & "    c12 " & TextBox72.Text & "    c13 " & TextBox73.Text & "    c14 " & TextBox74.Text & "    c15 " & TextBox75.Text & "  "
        ElseIf TextBox72.Text = "" Then
            gkb = "ct 11   c1 " & TextBox61.Text & "    c2 " & TextBox62.Text & "    c3 " & TextBox63.Text & "    c4 " & TextBox64.Text & "    c5 " & TextBox65.Text & "    c6 " & TextBox66.Text & "    c7 " & TextBox67.Text & "    c8 " & TextBox68.Text & "    c9 " & TextBox69.Text & "    c10 " & TextBox70.Text & "    c11 " & TextBox71.Text & "    c12 " & TextBox72.Text & "    c13 " & TextBox73.Text & "    c14 " & TextBox74.Text & "    c15 " & TextBox75.Text & "  "
        ElseIf TextBox73.Text = "" Then
            gkb = "ct 12   c1 " & TextBox61.Text & "    c2 " & TextBox62.Text & "    c3 " & TextBox63.Text & "    c4 " & TextBox64.Text & "    c5 " & TextBox65.Text & "    c6 " & TextBox66.Text & "    c7 " & TextBox67.Text & "    c8 " & TextBox68.Text & "    c9 " & TextBox69.Text & "    c10 " & TextBox70.Text & "    c11 " & TextBox71.Text & "    c12 " & TextBox72.Text & "    c13 " & TextBox73.Text & "    c14 " & TextBox74.Text & "    c15 " & TextBox75.Text & "  "
        ElseIf TextBox74.Text = "" Then
            gkb = "ct 13   c1 " & TextBox61.Text & "    c2 " & TextBox62.Text & "    c3 " & TextBox63.Text & "    c4 " & TextBox64.Text & "    c5 " & TextBox65.Text & "    c6 " & TextBox66.Text & "    c7 " & TextBox67.Text & "    c8 " & TextBox68.Text & "    c9 " & TextBox69.Text & "    c10 " & TextBox70.Text & "    c11 " & TextBox71.Text & "    c12 " & TextBox72.Text & "    c13 " & TextBox73.Text & "    c14 " & TextBox74.Text & "    c15 " & TextBox75.Text & "  "
        ElseIf TextBox75.Text = "" Then
            gkb = "ct 14   c1 " & TextBox61.Text & "    c2 " & TextBox62.Text & "    c3 " & TextBox63.Text & "    c4 " & TextBox64.Text & "    c5 " & TextBox65.Text & "    c6 " & TextBox66.Text & "    c7 " & TextBox67.Text & "    c8 " & TextBox68.Text & "    c9 " & TextBox69.Text & "    c10 " & TextBox70.Text & "    c11 " & TextBox71.Text & "    c12 " & TextBox72.Text & "    c13 " & TextBox73.Text & "    c14 " & TextBox74.Text & "    c15 " & TextBox75.Text & "  "
        ElseIf Not TextBox75.Text = "" Then
            gkb = "ct 15   c1 " & TextBox61.Text & "    c2 " & TextBox62.Text & "    c3 " & TextBox63.Text & "    c4 " & TextBox64.Text & "    c5 " & TextBox65.Text & "    c6 " & TextBox66.Text & "    c7 " & TextBox67.Text & "    c8 " & TextBox68.Text & "    c9 " & TextBox69.Text & "    c10 " & TextBox70.Text & "    c11 " & TextBox71.Text & "    c12 " & TextBox72.Text & "    c13 " & TextBox73.Text & "    c14 " & TextBox74.Text & "    c15 " & TextBox75.Text & "  "
        Else
            MsgBox("课表不得少于4节课")
        End If
        If RadioButton1.Checked = True Then
            My.Computer.FileSystem.WriteAllText("data\cl1\z5.txt", gkb, False)
        ElseIf RadioButton2.Checked = True Then
            My.Computer.FileSystem.WriteAllText("data\cl2\z5.txt", gkb, False)
        End If
        If TextBox80.Text = "" Then
            gkb = "ct 04   c1 " & TextBox76.Text & "    c2 " & TextBox77.Text & "    c3 " & TextBox78.Text & "    c4 " & TextBox79.Text & "    c5 " & TextBox80.Text & "    c6 " & TextBox81.Text & "    c7 " & TextBox82.Text & "    c8 " & TextBox83.Text & "    c9 " & TextBox84.Text & "    c10 " & TextBox85.Text & "    c11 " & TextBox86.Text & "    c12 " & TextBox87.Text & "    c13 " & TextBox88.Text & "    c14 " & TextBox89.Text & "    c15 " & TextBox90.Text & "  "
        ElseIf TextBox81.Text = "" Then
            gkb = "ct 05   c1 " & TextBox76.Text & "    c2 " & TextBox77.Text & "    c3 " & TextBox78.Text & "    c4 " & TextBox79.Text & "    c5 " & TextBox80.Text & "    c6 " & TextBox81.Text & "    c7 " & TextBox82.Text & "    c8 " & TextBox83.Text & "    c9 " & TextBox84.Text & "    c10 " & TextBox85.Text & "    c11 " & TextBox86.Text & "    c12 " & TextBox87.Text & "    c13 " & TextBox88.Text & "    c14 " & TextBox89.Text & "    c15 " & TextBox90.Text & "  "
        ElseIf TextBox82.Text = "" Then
            gkb = "ct 06   c1 " & TextBox76.Text & "    c2 " & TextBox77.Text & "    c3 " & TextBox78.Text & "    c4 " & TextBox79.Text & "    c5 " & TextBox80.Text & "    c6 " & TextBox81.Text & "    c7 " & TextBox82.Text & "    c8 " & TextBox83.Text & "    c9 " & TextBox84.Text & "    c10 " & TextBox85.Text & "    c11 " & TextBox86.Text & "    c12 " & TextBox87.Text & "    c13 " & TextBox88.Text & "    c14 " & TextBox89.Text & "    c15 " & TextBox90.Text & "  "
        ElseIf TextBox83.Text = "" Then
            gkb = "ct 07   c1 " & TextBox76.Text & "    c2 " & TextBox77.Text & "    c3 " & TextBox78.Text & "    c4 " & TextBox79.Text & "    c5 " & TextBox80.Text & "    c6 " & TextBox81.Text & "    c7 " & TextBox82.Text & "    c8 " & TextBox83.Text & "    c9 " & TextBox84.Text & "    c10 " & TextBox85.Text & "    c11 " & TextBox86.Text & "    c12 " & TextBox87.Text & "    c13 " & TextBox88.Text & "    c14 " & TextBox89.Text & "    c15 " & TextBox90.Text & "  "
        ElseIf TextBox84.Text = "" Then
            gkb = "ct 08   c1 " & TextBox76.Text & "    c2 " & TextBox77.Text & "    c3 " & TextBox78.Text & "    c4 " & TextBox79.Text & "    c5 " & TextBox80.Text & "    c6 " & TextBox81.Text & "    c7 " & TextBox82.Text & "    c8 " & TextBox83.Text & "    c9 " & TextBox84.Text & "    c10 " & TextBox85.Text & "    c11 " & TextBox86.Text & "    c12 " & TextBox87.Text & "    c13 " & TextBox88.Text & "    c14 " & TextBox89.Text & "    c15 " & TextBox90.Text & "  "
        ElseIf TextBox85.Text = "" Then
            gkb = "ct 09   c1 " & TextBox76.Text & "    c2 " & TextBox77.Text & "    c3 " & TextBox78.Text & "    c4 " & TextBox79.Text & "    c5 " & TextBox80.Text & "    c6 " & TextBox81.Text & "    c7 " & TextBox82.Text & "    c8 " & TextBox83.Text & "    c9 " & TextBox84.Text & "    c10 " & TextBox85.Text & "    c11 " & TextBox86.Text & "    c12 " & TextBox87.Text & "    c13 " & TextBox88.Text & "    c14 " & TextBox89.Text & "    c15 " & TextBox90.Text & "  "
        ElseIf TextBox86.Text = "" Then
            gkb = "ct 10   c1 " & TextBox76.Text & "    c2 " & TextBox77.Text & "    c3 " & TextBox78.Text & "    c4 " & TextBox79.Text & "    c5 " & TextBox80.Text & "    c6 " & TextBox81.Text & "    c7 " & TextBox82.Text & "    c8 " & TextBox83.Text & "    c9 " & TextBox84.Text & "    c10 " & TextBox85.Text & "    c11 " & TextBox86.Text & "    c12 " & TextBox87.Text & "    c13 " & TextBox88.Text & "    c14 " & TextBox89.Text & "    c15 " & TextBox90.Text & "  "
        ElseIf TextBox87.Text = "" Then
            gkb = "ct 11   c1 " & TextBox76.Text & "    c2 " & TextBox77.Text & "    c3 " & TextBox78.Text & "    c4 " & TextBox79.Text & "    c5 " & TextBox80.Text & "    c6 " & TextBox81.Text & "    c7 " & TextBox82.Text & "    c8 " & TextBox83.Text & "    c9 " & TextBox84.Text & "    c10 " & TextBox85.Text & "    c11 " & TextBox86.Text & "    c12 " & TextBox87.Text & "    c13 " & TextBox88.Text & "    c14 " & TextBox89.Text & "    c15 " & TextBox90.Text & "  "
        ElseIf TextBox88.Text = "" Then
            gkb = "ct 12   c1 " & TextBox76.Text & "    c2 " & TextBox77.Text & "    c3 " & TextBox78.Text & "    c4 " & TextBox79.Text & "    c5 " & TextBox80.Text & "    c6 " & TextBox81.Text & "    c7 " & TextBox82.Text & "    c8 " & TextBox83.Text & "    c9 " & TextBox84.Text & "    c10 " & TextBox85.Text & "    c11 " & TextBox86.Text & "    c12 " & TextBox87.Text & "    c13 " & TextBox88.Text & "    c14 " & TextBox89.Text & "    c15 " & TextBox90.Text & "  "
        ElseIf TextBox89.Text = "" Then
            gkb = "ct 13   c1 " & TextBox76.Text & "    c2 " & TextBox77.Text & "    c3 " & TextBox78.Text & "    c4 " & TextBox79.Text & "    c5 " & TextBox80.Text & "    c6 " & TextBox81.Text & "    c7 " & TextBox82.Text & "    c8 " & TextBox83.Text & "    c9 " & TextBox84.Text & "    c10 " & TextBox85.Text & "    c11 " & TextBox86.Text & "    c12 " & TextBox87.Text & "    c13 " & TextBox88.Text & "    c14 " & TextBox89.Text & "    c15 " & TextBox90.Text & "  "
        ElseIf TextBox90.Text = "" Then
            gkb = "ct 14   c1 " & TextBox76.Text & "    c2 " & TextBox77.Text & "    c3 " & TextBox78.Text & "    c4 " & TextBox79.Text & "    c5 " & TextBox80.Text & "    c6 " & TextBox81.Text & "    c7 " & TextBox82.Text & "    c8 " & TextBox83.Text & "    c9 " & TextBox84.Text & "    c10 " & TextBox85.Text & "    c11 " & TextBox86.Text & "    c12 " & TextBox87.Text & "    c13 " & TextBox88.Text & "    c14 " & TextBox89.Text & "    c15 " & TextBox90.Text & "  "
        ElseIf Not TextBox90.Text = "" Then
            gkb = "ct 15   c1 " & TextBox76.Text & "    c2 " & TextBox77.Text & "    c3 " & TextBox78.Text & "    c4 " & TextBox79.Text & "    c5 " & TextBox80.Text & "    c6 " & TextBox81.Text & "    c7 " & TextBox82.Text & "    c8 " & TextBox83.Text & "    c9 " & TextBox84.Text & "    c10 " & TextBox85.Text & "    c11 " & TextBox86.Text & "    c12 " & TextBox87.Text & "    c13 " & TextBox88.Text & "    c14 " & TextBox89.Text & "    c15 " & TextBox90.Text & "  "
        Else
            MsgBox("课表不得少于4节课")
        End If
        If RadioButton1.Checked = True Then
            My.Computer.FileSystem.WriteAllText("data\cl1\z6.txt", gkb, False)
        ElseIf RadioButton2.Checked = True Then
            My.Computer.FileSystem.WriteAllText("data\cl2\z6.txt", gkb, False)
        End If
        If TextBox95.Text = "" Then
            gkb = "ct 04   c1 " & TextBox91.Text & "    c2 " & TextBox92.Text & "    c3 " & TextBox93.Text & "    c4 " & TextBox94.Text & "    c5 " & TextBox95.Text & "    c6 " & TextBox96.Text & "    c7 " & TextBox97.Text & "    c8 " & TextBox98.Text & "    c9 " & TextBox99.Text & "    c10 " & TextBox100.Text & "    c11 " & TextBox101.Text & "    c12 " & TextBox102.Text & "    c13 " & TextBox103.Text & "    c14 " & TextBox104.Text & "    c15 " & TextBox105.Text & "  "
        ElseIf TextBox96.Text = "" Then
            gkb = "ct 05   c1 " & TextBox91.Text & "    c2 " & TextBox92.Text & "    c3 " & TextBox93.Text & "    c4 " & TextBox94.Text & "    c5 " & TextBox95.Text & "    c6 " & TextBox96.Text & "    c7 " & TextBox97.Text & "    c8 " & TextBox98.Text & "    c9 " & TextBox99.Text & "    c10 " & TextBox100.Text & "    c11 " & TextBox101.Text & "    c12 " & TextBox102.Text & "    c13 " & TextBox103.Text & "    c14 " & TextBox104.Text & "    c15 " & TextBox105.Text & "  "
        ElseIf TextBox97.Text = "" Then
            gkb = "ct 06   c1 " & TextBox91.Text & "    c2 " & TextBox92.Text & "    c3 " & TextBox93.Text & "    c4 " & TextBox94.Text & "    c5 " & TextBox95.Text & "    c6 " & TextBox96.Text & "    c7 " & TextBox97.Text & "    c8 " & TextBox98.Text & "    c9 " & TextBox99.Text & "    c10 " & TextBox100.Text & "    c11 " & TextBox101.Text & "    c12 " & TextBox102.Text & "    c13 " & TextBox103.Text & "    c14 " & TextBox104.Text & "    c15 " & TextBox105.Text & "  "
        ElseIf TextBox98.Text = "" Then
            gkb = "ct 07   c1 " & TextBox91.Text & "    c2 " & TextBox92.Text & "    c3 " & TextBox93.Text & "    c4 " & TextBox94.Text & "    c5 " & TextBox95.Text & "    c6 " & TextBox96.Text & "    c7 " & TextBox97.Text & "    c8 " & TextBox98.Text & "    c9 " & TextBox99.Text & "    c10 " & TextBox100.Text & "    c11 " & TextBox101.Text & "    c12 " & TextBox102.Text & "    c13 " & TextBox103.Text & "    c14 " & TextBox104.Text & "    c15 " & TextBox105.Text & "  "
        ElseIf TextBox99.Text = "" Then
            gkb = "ct 08   c1 " & TextBox91.Text & "    c2 " & TextBox92.Text & "    c3 " & TextBox93.Text & "    c4 " & TextBox94.Text & "    c5 " & TextBox95.Text & "    c6 " & TextBox96.Text & "    c7 " & TextBox97.Text & "    c8 " & TextBox98.Text & "    c9 " & TextBox99.Text & "    c10 " & TextBox100.Text & "    c11 " & TextBox101.Text & "    c12 " & TextBox102.Text & "    c13 " & TextBox103.Text & "    c14 " & TextBox104.Text & "    c15 " & TextBox105.Text & "  "
        ElseIf TextBox100.Text = "" Then
            gkb = "ct 09   c1 " & TextBox91.Text & "    c2 " & TextBox92.Text & "    c3 " & TextBox93.Text & "    c4 " & TextBox94.Text & "    c5 " & TextBox95.Text & "    c6 " & TextBox96.Text & "    c7 " & TextBox97.Text & "    c8 " & TextBox98.Text & "    c9 " & TextBox99.Text & "    c10 " & TextBox100.Text & "    c11 " & TextBox101.Text & "    c12 " & TextBox102.Text & "    c13 " & TextBox103.Text & "    c14 " & TextBox104.Text & "    c15 " & TextBox105.Text & "  "
        ElseIf TextBox101.Text = "" Then
            gkb = "ct 10   c1 " & TextBox91.Text & "    c2 " & TextBox92.Text & "    c3 " & TextBox93.Text & "    c4 " & TextBox94.Text & "    c5 " & TextBox95.Text & "    c6 " & TextBox96.Text & "    c7 " & TextBox97.Text & "    c8 " & TextBox98.Text & "    c9 " & TextBox99.Text & "    c10 " & TextBox100.Text & "    c11 " & TextBox101.Text & "    c12 " & TextBox102.Text & "    c13 " & TextBox103.Text & "    c14 " & TextBox104.Text & "    c15 " & TextBox105.Text & "  "
        ElseIf TextBox102.Text = "" Then
            gkb = "ct 11   c1 " & TextBox91.Text & "    c2 " & TextBox92.Text & "    c3 " & TextBox93.Text & "    c4 " & TextBox94.Text & "    c5 " & TextBox95.Text & "    c6 " & TextBox96.Text & "    c7 " & TextBox97.Text & "    c8 " & TextBox98.Text & "    c9 " & TextBox99.Text & "    c10 " & TextBox100.Text & "    c11 " & TextBox101.Text & "    c12 " & TextBox102.Text & "    c13 " & TextBox103.Text & "    c14 " & TextBox104.Text & "    c15 " & TextBox105.Text & "  "
        ElseIf TextBox103.Text = "" Then
            gkb = "ct 12   c1 " & TextBox91.Text & "    c2 " & TextBox92.Text & "    c3 " & TextBox93.Text & "    c4 " & TextBox94.Text & "    c5 " & TextBox95.Text & "    c6 " & TextBox96.Text & "    c7 " & TextBox97.Text & "    c8 " & TextBox98.Text & "    c9 " & TextBox99.Text & "    c10 " & TextBox100.Text & "    c11 " & TextBox101.Text & "    c12 " & TextBox102.Text & "    c13 " & TextBox103.Text & "    c14 " & TextBox104.Text & "    c15 " & TextBox105.Text & "  "
        ElseIf TextBox104.Text = "" Then
            gkb = "ct 13   c1 " & TextBox91.Text & "    c2 " & TextBox92.Text & "    c3 " & TextBox93.Text & "    c4 " & TextBox94.Text & "    c5 " & TextBox95.Text & "    c6 " & TextBox96.Text & "    c7 " & TextBox97.Text & "    c8 " & TextBox98.Text & "    c9 " & TextBox99.Text & "    c10 " & TextBox100.Text & "    c11 " & TextBox101.Text & "    c12 " & TextBox102.Text & "    c13 " & TextBox103.Text & "    c14 " & TextBox104.Text & "    c15 " & TextBox105.Text & "  "
        ElseIf TextBox105.Text = "" Then
            gkb = "ct 14   c1 " & TextBox91.Text & "    c2 " & TextBox92.Text & "    c3 " & TextBox93.Text & "    c4 " & TextBox94.Text & "    c5 " & TextBox95.Text & "    c6 " & TextBox96.Text & "    c7 " & TextBox97.Text & "    c8 " & TextBox98.Text & "    c9 " & TextBox99.Text & "    c10 " & TextBox100.Text & "    c11 " & TextBox101.Text & "    c12 " & TextBox102.Text & "    c13 " & TextBox103.Text & "    c14 " & TextBox104.Text & "    c15 " & TextBox105.Text & "  "
        ElseIf Not TextBox105.Text = "" Then
            gkb = "ct 15   c1 " & TextBox91.Text & "    c2 " & TextBox92.Text & "    c3 " & TextBox93.Text & "    c4 " & TextBox94.Text & "    c5 " & TextBox95.Text & "    c6 " & TextBox96.Text & "    c7 " & TextBox97.Text & "    c8 " & TextBox98.Text & "    c9 " & TextBox99.Text & "    c10 " & TextBox100.Text & "    c11 " & TextBox101.Text & "    c12 " & TextBox102.Text & "    c13 " & TextBox103.Text & "    c14 " & TextBox104.Text & "    c15 " & TextBox105.Text & "  "
        Else
            MsgBox("课表不得少于4节课")
        End If
        If RadioButton1.Checked = True Then
            My.Computer.FileSystem.WriteAllText("data\cl1\z7.txt", gkb, False)
        ElseIf RadioButton2.Checked = True Then
            My.Computer.FileSystem.WriteAllText("data\cl2\z7.txt", gkb, False)
        End If
        bc = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        bckb()
    End Sub

    Private Sub InputClass(clas As String)
        If xbox = 1 Then
            TextBox1.Text = clas
        ElseIf xbox = 2 Then
            TextBox2.Text = clas
        ElseIf xbox = 3 Then
            TextBox3.Text = clas
        ElseIf xbox = 4 Then
            TextBox4.Text = clas
        ElseIf xbox = 5 Then
            TextBox5.Text = clas
        ElseIf xbox = 6 Then
            TextBox6.Text = clas
        ElseIf xbox = 7 Then
            TextBox7.Text = clas
        ElseIf xbox = 8 Then
            TextBox8.Text = clas
        ElseIf xbox = 9 Then
            TextBox9.Text = clas
        ElseIf xbox = 10 Then
            TextBox10.Text = clas
        ElseIf xbox = 11 Then
            TextBox11.Text = clas
        ElseIf xbox = 12 Then
            TextBox12.Text = clas
        ElseIf xbox = 13 Then
            TextBox13.Text = clas
        ElseIf xbox = 14 Then
            TextBox14.Text = clas
        ElseIf xbox = 15 Then
            TextBox15.Text = clas
        ElseIf xbox = 16 Then
            TextBox16.Text = clas
        ElseIf xbox = 17 Then
            TextBox17.Text = clas
        ElseIf xbox = 18 Then
            TextBox18.Text = clas
        ElseIf xbox = 19 Then
            TextBox19.Text = clas
        ElseIf xbox = 20 Then
            TextBox20.Text = clas
        ElseIf xbox = 21 Then
            TextBox21.Text = clas
        ElseIf xbox = 22 Then
            TextBox22.Text = clas
        ElseIf xbox = 23 Then
            TextBox23.Text = clas
        ElseIf xbox = 24 Then
            TextBox24.Text = clas
        ElseIf xbox = 25 Then
            TextBox25.Text = clas
        ElseIf xbox = 26 Then
            TextBox26.Text = clas
        ElseIf xbox = 27 Then
            TextBox27.Text = clas
        ElseIf xbox = 28 Then
            TextBox28.Text = clas
        ElseIf xbox = 29 Then
            TextBox29.Text = clas
        ElseIf xbox = 30 Then
            TextBox30.Text = clas
        ElseIf xbox = 31 Then
            TextBox31.Text = clas
        ElseIf xbox = 32 Then
            TextBox32.Text = clas
        ElseIf xbox = 33 Then
            TextBox33.Text = clas
        ElseIf xbox = 34 Then
            TextBox34.Text = clas
        ElseIf xbox = 35 Then
            TextBox35.Text = clas
        ElseIf xbox = 36 Then
            TextBox36.Text = clas
        ElseIf xbox = 37 Then
            TextBox37.Text = clas
        ElseIf xbox = 38 Then
            TextBox38.Text = clas
        ElseIf xbox = 39 Then
            TextBox39.Text = clas
        ElseIf xbox = 40 Then
            TextBox40.Text = clas
        ElseIf xbox = 41 Then
            TextBox41.Text = clas
        ElseIf xbox = 42 Then
            TextBox42.Text = clas
        ElseIf xbox = 43 Then
            TextBox43.Text = clas
        ElseIf xbox = 44 Then
            TextBox44.Text = clas
        ElseIf xbox = 45 Then
            TextBox45.Text = clas
        ElseIf xbox = 46 Then
            TextBox46.Text = clas
        ElseIf xbox = 47 Then
            TextBox47.Text = clas
        ElseIf xbox = 48 Then
            TextBox48.Text = clas
        ElseIf xbox = 49 Then
            TextBox49.Text = clas
        ElseIf xbox = 50 Then
            TextBox50.Text = clas
        ElseIf xbox = 51 Then
            TextBox51.Text = clas
        ElseIf xbox = 52 Then
            TextBox52.Text = clas
        ElseIf xbox = 53 Then
            TextBox53.Text = clas
        ElseIf xbox = 54 Then
            TextBox54.Text = clas
        ElseIf xbox = 55 Then
            TextBox55.Text = clas
        ElseIf xbox = 56 Then
            TextBox56.Text = clas
        ElseIf xbox = 57 Then
            TextBox57.Text = clas
        ElseIf xbox = 58 Then
            TextBox58.Text = clas
        ElseIf xbox = 59 Then
            TextBox59.Text = clas
        ElseIf xbox = 60 Then
            TextBox60.Text = clas
        ElseIf xbox = 61 Then
            TextBox61.Text = clas
        ElseIf xbox = 62 Then
            TextBox62.Text = clas
        ElseIf xbox = 63 Then
            TextBox63.Text = clas
        ElseIf xbox = 64 Then
            TextBox64.Text = clas
        ElseIf xbox = 65 Then
            TextBox65.Text = clas
        ElseIf xbox = 66 Then
            TextBox66.Text = clas
        ElseIf xbox = 67 Then
            TextBox67.Text = clas
        ElseIf xbox = 68 Then
            TextBox68.Text = clas
        ElseIf xbox = 69 Then
            TextBox69.Text = clas
        ElseIf xbox = 70 Then
            TextBox70.Text = clas
        ElseIf xbox = 71 Then
            TextBox71.Text = clas
        ElseIf xbox = 72 Then
            TextBox72.Text = clas
        ElseIf xbox = 73 Then
            TextBox73.Text = clas
        ElseIf xbox = 74 Then
            TextBox74.Text = clas
        ElseIf xbox = 75 Then
            TextBox75.Text = clas
        ElseIf xbox = 76 Then
            TextBox76.Text = clas
        ElseIf xbox = 77 Then
            TextBox77.Text = clas
        ElseIf xbox = 78 Then
            TextBox78.Text = clas
        ElseIf xbox = 79 Then
            TextBox79.Text = clas
        ElseIf xbox = 80 Then
            TextBox80.Text = clas
        ElseIf xbox = 81 Then
            TextBox81.Text = clas
        ElseIf xbox = 82 Then
            TextBox82.Text = clas
        ElseIf xbox = 83 Then
            TextBox83.Text = clas
        ElseIf xbox = 84 Then
            TextBox84.Text = clas
        ElseIf xbox = 85 Then
            TextBox85.Text = clas
        ElseIf xbox = 86 Then
            TextBox86.Text = clas
        ElseIf xbox = 87 Then
            TextBox87.Text = clas
        ElseIf xbox = 88 Then
            TextBox88.Text = clas
        ElseIf xbox = 89 Then
            TextBox89.Text = clas
        ElseIf xbox = 90 Then
            TextBox90.Text = clas
        ElseIf xbox = 91 Then
            TextBox91.Text = clas
        ElseIf xbox = 92 Then
            TextBox92.Text = clas
        ElseIf xbox = 93 Then
            TextBox93.Text = clas
        ElseIf xbox = 94 Then
            TextBox94.Text = clas
        ElseIf xbox = 95 Then
            TextBox95.Text = clas
        ElseIf xbox = 96 Then
            TextBox96.Text = clas
        ElseIf xbox = 97 Then
            TextBox97.Text = clas
        ElseIf xbox = 98 Then
            TextBox98.Text = clas
        ElseIf xbox = 99 Then
            TextBox99.Text = clas
        ElseIf xbox = 100 Then
            TextBox100.Text = clas
        ElseIf xbox = 101 Then
            TextBox101.Text = clas
        ElseIf xbox = 102 Then
            TextBox102.Text = clas
        ElseIf xbox = 103 Then
            TextBox103.Text = clas
        ElseIf xbox = 104 Then
            TextBox104.Text = clas
        ElseIf xbox = 105 Then
            TextBox105.Text = clas
        End If
        xbox = xbox + 1
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        InputClass(Button4.Text)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        InputClass(Button5.Text)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        InputClass(Button6.Text)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        InputClass(Button7.Text)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        InputClass(Button8.Text)
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        InputClass(Button9.Text)
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        InputClass(Button10.Text)
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        InputClass(Button11.Text)
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        InputClass(Button12.Text)
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        InputClass(Button13.Text)
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        InputClass(Button14.Text)
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        InputClass(Button15.Text)
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        InputClass(Button16.Text)
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        InputClass(Button17.Text)
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        InputClass(Button18.Text)
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        InputClass(Button19.Text)
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        InputClass(Button20.Text)
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        InputClass(Button21.Text)
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        InputClass(Button22.Text)
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        InputClass(Button23.Text)
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        InputClass(Button24.Text)
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        InputClass(Button25.Text)
    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        InputClass(Button26.Text)
    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        InputClass(Button27.Text)
    End Sub

    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles Button28.Click
        InputClass(Button28.Text)
    End Sub

    Private Sub Button29_Click(sender As Object, e As EventArgs) Handles Button29.Click
        InputClass(Button29.Text)
    End Sub

    Private Sub Button30_Click(sender As Object, e As EventArgs) Handles Button30.Click
        InputClass(Button30.Text)
    End Sub

    Private Sub Button31_Click(sender As Object, e As EventArgs) Handles Button31.Click
        InputClass(Button31.Text)
    End Sub

    Private Sub Button32_Click(sender As Object, e As EventArgs) Handles Button32.Click
        InputClass(Button32.Text)
    End Sub

    Private Sub Button33_Click(sender As Object, e As EventArgs) Handles Button33.Click
        InputClass(Button33.Text)
    End Sub

    Private Sub Button34_Click(sender As Object, e As EventArgs) Handles Button34.Click
        InputClass(Button34.Text)
    End Sub

    Private Sub Button35_Click(sender As Object, e As EventArgs) Handles Button35.Click
        InputClass(Button35.Text)
    End Sub

    Private Sub TextBox1_GotFocus(sender As Object, e As EventArgs) Handles TextBox1.GotFocus
        xbox = 1
    End Sub

    Private Sub TextBox2_GotFocus(sender As Object, e As EventArgs) Handles TextBox2.GotFocus
        xbox = 2
    End Sub

    Private Sub TextBox3_GotFocus(sender As Object, e As EventArgs) Handles TextBox3.GotFocus
        xbox = 3
    End Sub

    Private Sub TextBox4_GotFocus(sender As Object, e As EventArgs) Handles TextBox4.GotFocus
        xbox = 4
    End Sub

    Private Sub TextBox5_GotFocus(sender As Object, e As EventArgs) Handles TextBox5.GotFocus
        xbox = 5
    End Sub

    Private Sub TextBox6_GotFocus(sender As Object, e As EventArgs) Handles TextBox6.GotFocus
        xbox = 6
    End Sub

    Private Sub TextBox7_GotFocus(sender As Object, e As EventArgs) Handles TextBox7.GotFocus
        xbox = 7
    End Sub

    Private Sub TextBox8_GotFocus(sender As Object, e As EventArgs) Handles TextBox8.GotFocus
        xbox = 8
    End Sub

    Private Sub TextBox9_GotFocus(sender As Object, e As EventArgs) Handles TextBox9.GotFocus
        xbox = 9
    End Sub

    Private Sub TextBox10_GotFocus(sender As Object, e As EventArgs) Handles TextBox10.GotFocus
        xbox = 10
    End Sub

    Private Sub TextBox11_GotFocus(sender As Object, e As EventArgs) Handles TextBox11.GotFocus
        xbox = 11
    End Sub

    Private Sub TextBox12_GotFocus(sender As Object, e As EventArgs) Handles TextBox12.GotFocus
        xbox = 12
    End Sub

    Private Sub TextBox13_GotFocus(sender As Object, e As EventArgs) Handles TextBox13.GotFocus
        xbox = 13
    End Sub

    Private Sub TextBox14_GotFocus(sender As Object, e As EventArgs) Handles TextBox14.GotFocus
        xbox = 14
    End Sub

    Private Sub TextBox15_GotFocus(sender As Object, e As EventArgs) Handles TextBox15.GotFocus
        xbox = 15
    End Sub

    Private Sub TextBox16_GotFocus(sender As Object, e As EventArgs) Handles TextBox16.GotFocus
        xbox = 16
    End Sub

    Private Sub TextBox17_GotFocus(sender As Object, e As EventArgs) Handles TextBox17.GotFocus
        xbox = 17
    End Sub

    Private Sub TextBox18_GotFocus(sender As Object, e As EventArgs) Handles TextBox18.GotFocus
        xbox = 18
    End Sub

    Private Sub TextBox19_GotFocus(sender As Object, e As EventArgs) Handles TextBox19.GotFocus
        xbox = 19
    End Sub

    Private Sub TextBox20_GotFocus(sender As Object, e As EventArgs) Handles TextBox20.GotFocus
        xbox = 20
    End Sub

    Private Sub TextBox21_GotFocus(sender As Object, e As EventArgs) Handles TextBox21.GotFocus
        xbox = 21
    End Sub

    Private Sub TextBox22_GotFocus(sender As Object, e As EventArgs) Handles TextBox22.GotFocus
        xbox = 22
    End Sub

    Private Sub TextBox23_GotFocus(sender As Object, e As EventArgs) Handles TextBox23.GotFocus
        xbox = 23
    End Sub

    Private Sub TextBox24_GotFocus(sender As Object, e As EventArgs) Handles TextBox24.GotFocus
        xbox = 24
    End Sub

    Private Sub TextBox25_GotFocus(sender As Object, e As EventArgs) Handles TextBox25.GotFocus
        xbox = 25
    End Sub

    Private Sub TextBox26_GotFocus(sender As Object, e As EventArgs) Handles TextBox26.GotFocus
        xbox = 26
    End Sub

    Private Sub TextBox27_GotFocus(sender As Object, e As EventArgs) Handles TextBox27.GotFocus
        xbox = 27
    End Sub

    Private Sub TextBox28_GotFocus(sender As Object, e As EventArgs) Handles TextBox28.GotFocus
        xbox = 28
    End Sub

    Private Sub TextBox29_GotFocus(sender As Object, e As EventArgs) Handles TextBox29.GotFocus
        xbox = 29
    End Sub

    Private Sub TextBox30_GotFocus(sender As Object, e As EventArgs) Handles TextBox30.GotFocus
        xbox = 30
    End Sub

    Private Sub TextBox31_GotFocus(sender As Object, e As EventArgs) Handles TextBox31.GotFocus
        xbox = 31
    End Sub

    Private Sub TextBox32_GotFocus(sender As Object, e As EventArgs) Handles TextBox32.GotFocus
        xbox = 32
    End Sub

    Private Sub TextBox33_GotFocus(sender As Object, e As EventArgs) Handles TextBox33.GotFocus
        xbox = 33
    End Sub

    Private Sub TextBox34_GotFocus(sender As Object, e As EventArgs) Handles TextBox34.GotFocus
        xbox = 34
    End Sub

    Private Sub TextBox35_GotFocus(sender As Object, e As EventArgs) Handles TextBox35.GotFocus
        xbox = 35
    End Sub

    Private Sub TextBox36_GotFocus(sender As Object, e As EventArgs) Handles TextBox36.GotFocus
        xbox = 36
    End Sub

    Private Sub TextBox37_GotFocus(sender As Object, e As EventArgs) Handles TextBox37.GotFocus
        xbox = 37
    End Sub

    Private Sub TextBox38_GotFocus(sender As Object, e As EventArgs) Handles TextBox38.GotFocus
        xbox = 38
    End Sub

    Private Sub TextBox39_GotFocus(sender As Object, e As EventArgs) Handles TextBox39.GotFocus
        xbox = 39
    End Sub

    Private Sub TextBox40_GotFocus(sender As Object, e As EventArgs) Handles TextBox40.GotFocus
        xbox = 40
    End Sub

    Private Sub TextBox41_GotFocus(sender As Object, e As EventArgs) Handles TextBox41.GotFocus
        xbox = 41
    End Sub

    Private Sub TextBox42_GotFocus(sender As Object, e As EventArgs) Handles TextBox42.GotFocus
        xbox = 42
    End Sub

    Private Sub TextBox43_GotFocus(sender As Object, e As EventArgs) Handles TextBox43.GotFocus
        xbox = 43
    End Sub

    Private Sub TextBox44_GotFocus(sender As Object, e As EventArgs) Handles TextBox44.GotFocus
        xbox = 44
    End Sub

    Private Sub TextBox45_GotFocus(sender As Object, e As EventArgs) Handles TextBox45.GotFocus
        xbox = 45
    End Sub

    Private Sub TextBox46_GotFocus(sender As Object, e As EventArgs) Handles TextBox46.GotFocus
        xbox = 46
    End Sub

    Private Sub TextBox47_GotFocus(sender As Object, e As EventArgs) Handles TextBox47.GotFocus
        xbox = 47
    End Sub

    Private Sub TextBox48_GotFocus(sender As Object, e As EventArgs) Handles TextBox48.GotFocus
        xbox = 48
    End Sub

    Private Sub TextBox49_GotFocus(sender As Object, e As EventArgs) Handles TextBox49.GotFocus
        xbox = 49
    End Sub

    Private Sub TextBox50_GotFocus(sender As Object, e As EventArgs) Handles TextBox50.GotFocus
        xbox = 50
    End Sub

    Private Sub TextBox51_GotFocus(sender As Object, e As EventArgs) Handles TextBox51.GotFocus
        xbox = 51
    End Sub

    Private Sub TextBox52_GotFocus(sender As Object, e As EventArgs) Handles TextBox52.GotFocus
        xbox = 52
    End Sub

    Private Sub TextBox53_GotFocus(sender As Object, e As EventArgs) Handles TextBox53.GotFocus
        xbox = 53
    End Sub

    Private Sub TextBox54_GotFocus(sender As Object, e As EventArgs) Handles TextBox54.GotFocus
        xbox = 54
    End Sub

    Private Sub TextBox55_GotFocus(sender As Object, e As EventArgs) Handles TextBox55.GotFocus
        xbox = 55
    End Sub

    Private Sub TextBox56_GotFocus(sender As Object, e As EventArgs) Handles TextBox56.GotFocus
        xbox = 56
    End Sub

    Private Sub TextBox57_GotFocus(sender As Object, e As EventArgs) Handles TextBox57.GotFocus
        xbox = 57
    End Sub

    Private Sub TextBox58_GotFocus(sender As Object, e As EventArgs) Handles TextBox58.GotFocus
        xbox = 58
    End Sub

    Private Sub TextBox59_GotFocus(sender As Object, e As EventArgs) Handles TextBox59.GotFocus
        xbox = 59
    End Sub

    Private Sub TextBox60_GotFocus(sender As Object, e As EventArgs) Handles TextBox60.GotFocus
        xbox = 60
    End Sub

    Private Sub TextBox61_GotFocus(sender As Object, e As EventArgs) Handles TextBox61.GotFocus
        xbox = 61
    End Sub

    Private Sub TextBox62_GotFocus(sender As Object, e As EventArgs) Handles TextBox62.GotFocus
        xbox = 62
    End Sub

    Private Sub TextBox63_GotFocus(sender As Object, e As EventArgs) Handles TextBox63.GotFocus
        xbox = 63
    End Sub

    Private Sub TextBox64_GotFocus(sender As Object, e As EventArgs) Handles TextBox64.GotFocus
        xbox = 64
    End Sub

    Private Sub TextBox65_GotFocus(sender As Object, e As EventArgs) Handles TextBox65.GotFocus
        xbox = 65
    End Sub

    Private Sub TextBox66_GotFocus(sender As Object, e As EventArgs) Handles TextBox66.GotFocus
        xbox = 66
    End Sub

    Private Sub TextBox67_GotFocus(sender As Object, e As EventArgs) Handles TextBox67.GotFocus
        xbox = 67
    End Sub

    Private Sub TextBox68_GotFocus(sender As Object, e As EventArgs) Handles TextBox68.GotFocus
        xbox = 68
    End Sub

    Private Sub TextBox69_GotFocus(sender As Object, e As EventArgs) Handles TextBox69.GotFocus
        xbox = 69
    End Sub

    Private Sub TextBox70_GotFocus(sender As Object, e As EventArgs) Handles TextBox70.GotFocus
        xbox = 70
    End Sub

    Private Sub TextBox71_GotFocus(sender As Object, e As EventArgs) Handles TextBox71.GotFocus
        xbox = 71
    End Sub

    Private Sub TextBox72_GotFocus(sender As Object, e As EventArgs) Handles TextBox72.GotFocus
        xbox = 72
    End Sub

    Private Sub TextBox73_GotFocus(sender As Object, e As EventArgs) Handles TextBox73.GotFocus
        xbox = 73
    End Sub

    Private Sub TextBox74_GotFocus(sender As Object, e As EventArgs) Handles TextBox74.GotFocus
        xbox = 74
    End Sub

    Private Sub TextBox75_GotFocus(sender As Object, e As EventArgs) Handles TextBox75.GotFocus
        xbox = 75
    End Sub

    Private Sub TextBox76_GotFocus(sender As Object, e As EventArgs) Handles TextBox76.GotFocus
        xbox = 76
    End Sub

    Private Sub TextBox77_GotFocus(sender As Object, e As EventArgs) Handles TextBox77.GotFocus
        xbox = 77
    End Sub

    Private Sub TextBox78_GotFocus(sender As Object, e As EventArgs) Handles TextBox78.GotFocus
        xbox = 78
    End Sub

    Private Sub TextBox79_GotFocus(sender As Object, e As EventArgs) Handles TextBox79.GotFocus
        xbox = 79
    End Sub

    Private Sub TextBox80_GotFocus(sender As Object, e As EventArgs) Handles TextBox80.GotFocus
        xbox = 80
    End Sub

    Private Sub TextBox81_GotFocus(sender As Object, e As EventArgs) Handles TextBox81.GotFocus
        xbox = 81
    End Sub

    Private Sub TextBox82_GotFocus(sender As Object, e As EventArgs) Handles TextBox82.GotFocus
        xbox = 82
    End Sub

    Private Sub TextBox83_GotFocus(sender As Object, e As EventArgs) Handles TextBox83.GotFocus
        xbox = 83
    End Sub

    Private Sub TextBox84_GotFocus(sender As Object, e As EventArgs) Handles TextBox84.GotFocus
        xbox = 84
    End Sub

    Private Sub TextBox85_GotFocus(sender As Object, e As EventArgs) Handles TextBox85.GotFocus
        xbox = 85
    End Sub

    Private Sub TextBox86_GotFocus(sender As Object, e As EventArgs) Handles TextBox86.GotFocus
        xbox = 86
    End Sub

    Private Sub TextBox87_GotFocus(sender As Object, e As EventArgs) Handles TextBox87.GotFocus
        xbox = 87
    End Sub

    Private Sub TextBox88_GotFocus(sender As Object, e As EventArgs) Handles TextBox88.GotFocus
        xbox = 88
    End Sub

    Private Sub TextBox89_GotFocus(sender As Object, e As EventArgs) Handles TextBox89.GotFocus
        xbox = 89
    End Sub

    Private Sub TextBox90_GotFocus(sender As Object, e As EventArgs) Handles TextBox90.GotFocus
        xbox = 90
    End Sub

    Private Sub TextBox91_GotFocus(sender As Object, e As EventArgs) Handles TextBox91.GotFocus
        xbox = 91
    End Sub

    Private Sub TextBox92_GotFocus(sender As Object, e As EventArgs) Handles TextBox92.GotFocus
        xbox = 92
    End Sub

    Private Sub TextBox93_GotFocus(sender As Object, e As EventArgs) Handles TextBox93.GotFocus
        xbox = 93
    End Sub

    Private Sub TextBox94_GotFocus(sender As Object, e As EventArgs) Handles TextBox94.GotFocus
        xbox = 94
    End Sub

    Private Sub TextBox95_GotFocus(sender As Object, e As EventArgs) Handles TextBox95.GotFocus
        xbox = 95
    End Sub

    Private Sub TextBox96_GotFocus(sender As Object, e As EventArgs) Handles TextBox96.GotFocus
        xbox = 96
    End Sub

    Private Sub TextBox97_GotFocus(sender As Object, e As EventArgs) Handles TextBox97.GotFocus
        xbox = 97
    End Sub

    Private Sub TextBox98_GotFocus(sender As Object, e As EventArgs) Handles TextBox98.GotFocus
        xbox = 98
    End Sub

    Private Sub TextBox99_GotFocus(sender As Object, e As EventArgs) Handles TextBox99.GotFocus
        xbox = 99
    End Sub

    Private Sub TextBox100_GotFocus(sender As Object, e As EventArgs) Handles TextBox100.GotFocus
        xbox = 100
    End Sub

    Private Sub TextBox101_GotFocus(sender As Object, e As EventArgs) Handles TextBox101.GotFocus
        xbox = 101
    End Sub

    Private Sub TextBox102_GotFocus(sender As Object, e As EventArgs) Handles TextBox102.GotFocus
        xbox = 102
    End Sub

    Private Sub TextBox103_GotFocus(sender As Object, e As EventArgs) Handles TextBox103.GotFocus
        xbox = 103
    End Sub

    Private Sub TextBox104_GotFocus(sender As Object, e As EventArgs) Handles TextBox104.GotFocus
        xbox = 104
    End Sub

    Private Sub TextBox105_GotFocus(sender As Object, e As EventArgs) Handles TextBox105.GotFocus
        xbox = 105
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        bckb()
        Me.Close()
    End Sub

    Private Sub Form26_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If bc = False Then
            rq = MsgBox("您刚才做的课表更改将丢失" & vbCrLf & "是否不保存更改并退出编辑器?", vbOKCancel + vbQuestion, "课表编辑器")
            If rq = 1 Then
                e.Cancel = False
            Else
                e.Cancel = True
            End If
        Else
            e.Cancel = False
        End If
    End Sub
End Class