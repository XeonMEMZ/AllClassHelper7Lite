Imports System.ComponentModel
Imports System.Net.Mime.MediaTypeNames

Public Class Form27
    Dim maxclass As Integer
    Dim alltime As String
    Dim xbox As Integer
    Dim tss As String
    Dim bc As Boolean
    Dim rq As Integer
    Dim cl As String
    Dim ds As String
    Dim n As Integer
    Private Sub Form27_Load(sender As Object, e As EventArgs) Handles Me.Load
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
        jzsjb()
    End Sub

    Public Sub jzsjb()
        For n = 1 To 7
            If Val(alldclass("ct", n)) > maxclass Then
                maxclass = Val(alldclass("ct", n))
            End If
        Next n
        TextBox6.ReadOnly = False
        TextBox21.ReadOnly = False
        TextBox7.ReadOnly = False
        TextBox22.ReadOnly = False
        TextBox8.ReadOnly = False
        TextBox23.ReadOnly = False
        TextBox9.ReadOnly = False
        TextBox24.ReadOnly = False
        TextBox10.ReadOnly = False
        TextBox25.ReadOnly = False
        TextBox11.ReadOnly = False
        TextBox26.ReadOnly = False
        TextBox12.ReadOnly = False
        TextBox27.ReadOnly = False
        TextBox13.ReadOnly = False
        TextBox28.ReadOnly = False
        TextBox14.ReadOnly = False
        TextBox29.ReadOnly = False
        TextBox15.ReadOnly = False
        TextBox30.ReadOnly = False
        TextBox1.Text = zxtime("zm1s")
        TextBox16.Text = zxtime("zm1x")
        TextBox2.Text = zxtime("zm2s")
        TextBox17.Text = zxtime("zm2x")
        TextBox3.Text = zxtime("zm3s")
        TextBox18.Text = zxtime("zm3x")
        TextBox4.Text = zxtime("zm4s")
        TextBox19.Text = zxtime("zm4x")
        If maxclass > 14 Then
            TextBox5.Text = zxtime("zm5s")
            TextBox20.Text = zxtime("zm5x")
            TextBox6.Text = zxtime("zm6s")
            TextBox21.Text = zxtime("zm6x")
            TextBox7.Text = zxtime("zm7s")
            TextBox22.Text = zxtime("zm7x")
            TextBox8.Text = zxtime("zm8s")
            TextBox23.Text = zxtime("zm8x")
            TextBox9.Text = zxtime("zm9s")
            TextBox24.Text = zxtime("zm9x")
            TextBox10.Text = zxtime("zm10s")
            TextBox25.Text = zxtime("zm10x")
            TextBox11.Text = zxtime("zm11s")
            TextBox26.Text = zxtime("zm11x")
            TextBox12.Text = zxtime("zm12s")
            TextBox27.Text = zxtime("zm12x")
            TextBox13.Text = zxtime("zm13s")
            TextBox28.Text = zxtime("zm13x")
            TextBox14.Text = zxtime("zm14s")
            TextBox29.Text = zxtime("zm14x")
            TextBox15.Text = zxtime("zm15s")
            TextBox30.Text = zxtime("zm15x")
        ElseIf maxclass > 13 Then
            TextBox5.Text = zxtime("zm5s")
            TextBox20.Text = zxtime("zm5x")
            TextBox6.Text = zxtime("zm6s")
            TextBox21.Text = zxtime("zm6x")
            TextBox7.Text = zxtime("zm7s")
            TextBox22.Text = zxtime("zm7x")
            TextBox8.Text = zxtime("zm8s")
            TextBox23.Text = zxtime("zm8x")
            TextBox9.Text = zxtime("zm9s")
            TextBox24.Text = zxtime("zm9x")
            TextBox10.Text = zxtime("zm10s")
            TextBox25.Text = zxtime("zm10x")
            TextBox11.Text = zxtime("zm11s")
            TextBox26.Text = zxtime("zm11x")
            TextBox12.Text = zxtime("zm12s")
            TextBox27.Text = zxtime("zm12x")
            TextBox13.Text = zxtime("zm13s")
            TextBox28.Text = zxtime("zm13x")
            TextBox14.Text = zxtime("zm14s")
            TextBox29.Text = zxtime("zm14x")
            TextBox15.Text = "23:59:59"
            TextBox30.Text = "23:59:59"
            TextBox15.ReadOnly = True
            TextBox30.ReadOnly = True
        ElseIf maxclass > 12 Then
            TextBox5.Text = zxtime("zm5s")
            TextBox20.Text = zxtime("zm5x")
            TextBox6.Text = zxtime("zm6s")
            TextBox21.Text = zxtime("zm6x")
            TextBox7.Text = zxtime("zm7s")
            TextBox22.Text = zxtime("zm7x")
            TextBox8.Text = zxtime("zm8s")
            TextBox23.Text = zxtime("zm8x")
            TextBox9.Text = zxtime("zm9s")
            TextBox24.Text = zxtime("zm9x")
            TextBox10.Text = zxtime("zm10s")
            TextBox25.Text = zxtime("zm10x")
            TextBox11.Text = zxtime("zm11s")
            TextBox26.Text = zxtime("zm11x")
            TextBox12.Text = zxtime("zm12s")
            TextBox27.Text = zxtime("zm12x")
            TextBox13.Text = zxtime("zm13s")
            TextBox28.Text = zxtime("zm13x")
            TextBox14.Text = "23:59:59"
            TextBox29.Text = "23:59:59"
            TextBox15.Text = "23:59:59"
            TextBox30.Text = "23:59:59"
            TextBox14.ReadOnly = True
            TextBox29.ReadOnly = True
            TextBox15.ReadOnly = True
            TextBox30.ReadOnly = True
        ElseIf maxclass > 11 Then
            TextBox5.Text = zxtime("zm5s")
            TextBox20.Text = zxtime("zm5x")
            TextBox6.Text = zxtime("zm6s")
            TextBox21.Text = zxtime("zm6x")
            TextBox7.Text = zxtime("zm7s")
            TextBox22.Text = zxtime("zm7x")
            TextBox8.Text = zxtime("zm8s")
            TextBox23.Text = zxtime("zm8x")
            TextBox9.Text = zxtime("zm9s")
            TextBox24.Text = zxtime("zm9x")
            TextBox10.Text = zxtime("zm10s")
            TextBox25.Text = zxtime("zm10x")
            TextBox11.Text = zxtime("zm11s")
            TextBox26.Text = zxtime("zm11x")
            TextBox12.Text = zxtime("zm12s")
            TextBox27.Text = zxtime("zm12x")
            TextBox13.Text = "23:59:59"
            TextBox28.Text = "23:59:59"
            TextBox14.Text = "23:59:59"
            TextBox29.Text = "23:59:59"
            TextBox15.Text = "23:59:59"
            TextBox30.Text = "23:59:59"
            TextBox13.ReadOnly = True
            TextBox28.ReadOnly = True
            TextBox14.ReadOnly = True
            TextBox29.ReadOnly = True
            TextBox15.ReadOnly = True
            TextBox30.ReadOnly = True
        ElseIf maxclass > 10 Then
            TextBox5.Text = zxtime("zm5s")
            TextBox20.Text = zxtime("zm5x")
            TextBox6.Text = zxtime("zm6s")
            TextBox21.Text = zxtime("zm6x")
            TextBox7.Text = zxtime("zm7s")
            TextBox22.Text = zxtime("zm7x")
            TextBox8.Text = zxtime("zm8s")
            TextBox23.Text = zxtime("zm8x")
            TextBox9.Text = zxtime("zm9s")
            TextBox24.Text = zxtime("zm9x")
            TextBox10.Text = zxtime("zm10s")
            TextBox25.Text = zxtime("zm10x")
            TextBox11.Text = zxtime("zm11s")
            TextBox26.Text = zxtime("zm11x")
            TextBox12.Text = "23:59:59"
            TextBox27.Text = "23:59:59"
            TextBox13.Text = "23:59:59"
            TextBox28.Text = "23:59:59"
            TextBox14.Text = "23:59:59"
            TextBox29.Text = "23:59:59"
            TextBox15.Text = "23:59:59"
            TextBox30.Text = "23:59:59"
            TextBox12.ReadOnly = True
            TextBox27.ReadOnly = True
            TextBox13.ReadOnly = True
            TextBox28.ReadOnly = True
            TextBox14.ReadOnly = True
            TextBox29.ReadOnly = True
            TextBox15.ReadOnly = True
            TextBox30.ReadOnly = True
        ElseIf maxclass > 9 Then
            TextBox5.Text = zxtime("zm5s")
            TextBox20.Text = zxtime("zm5x")
            TextBox6.Text = zxtime("zm6s")
            TextBox21.Text = zxtime("zm6x")
            TextBox7.Text = zxtime("zm7s")
            TextBox22.Text = zxtime("zm7x")
            TextBox8.Text = zxtime("zm8s")
            TextBox23.Text = zxtime("zm8x")
            TextBox9.Text = zxtime("zm9s")
            TextBox24.Text = zxtime("zm9x")
            TextBox10.Text = zxtime("zm10s")
            TextBox25.Text = zxtime("zm10x")
            TextBox11.Text = "23:59:59"
            TextBox26.Text = "23:59:59"
            TextBox12.Text = "23:59:59"
            TextBox27.Text = "23:59:59"
            TextBox13.Text = "23:59:59"
            TextBox28.Text = "23:59:59"
            TextBox14.Text = "23:59:59"
            TextBox29.Text = "23:59:59"
            TextBox15.Text = "23:59:59"
            TextBox30.Text = "23:59:59"
            TextBox11.ReadOnly = True
            TextBox26.ReadOnly = True
            TextBox12.ReadOnly = True
            TextBox27.ReadOnly = True
            TextBox13.ReadOnly = True
            TextBox28.ReadOnly = True
            TextBox14.ReadOnly = True
            TextBox29.ReadOnly = True
            TextBox15.ReadOnly = True
            TextBox30.ReadOnly = True
        ElseIf maxclass > 8 Then
            TextBox5.Text = zxtime("zm5s")
            TextBox20.Text = zxtime("zm5x")
            TextBox6.Text = zxtime("zm6s")
            TextBox21.Text = zxtime("zm6x")
            TextBox7.Text = zxtime("zm7s")
            TextBox22.Text = zxtime("zm7x")
            TextBox8.Text = zxtime("zm8s")
            TextBox23.Text = zxtime("zm8x")
            TextBox9.Text = zxtime("zm9s")
            TextBox24.Text = zxtime("zm9x")
            TextBox10.Text = "23:59:59"
            TextBox25.Text = "23:59:59"
            TextBox11.Text = "23:59:59"
            TextBox26.Text = "23:59:59"
            TextBox12.Text = "23:59:59"
            TextBox27.Text = "23:59:59"
            TextBox13.Text = "23:59:59"
            TextBox28.Text = "23:59:59"
            TextBox14.Text = "23:59:59"
            TextBox29.Text = "23:59:59"
            TextBox15.Text = "23:59:59"
            TextBox30.Text = "23:59:59"
            TextBox10.ReadOnly = True
            TextBox25.ReadOnly = True
            TextBox11.ReadOnly = True
            TextBox26.ReadOnly = True
            TextBox12.ReadOnly = True
            TextBox27.ReadOnly = True
            TextBox13.ReadOnly = True
            TextBox28.ReadOnly = True
            TextBox14.ReadOnly = True
            TextBox29.ReadOnly = True
            TextBox15.ReadOnly = True
            TextBox30.ReadOnly = True
        ElseIf maxclass > 7 Then
            TextBox5.Text = zxtime("zm5s")
            TextBox20.Text = zxtime("zm5x")
            TextBox6.Text = zxtime("zm6s")
            TextBox21.Text = zxtime("zm6x")
            TextBox7.Text = zxtime("zm7s")
            TextBox22.Text = zxtime("zm7x")
            TextBox8.Text = zxtime("zm8s")
            TextBox23.Text = zxtime("zm8x")
            TextBox9.Text = "23:59:59"
            TextBox24.Text = "23:59:59"
            TextBox10.Text = "23:59:59"
            TextBox25.Text = "23:59:59"
            TextBox11.Text = "23:59:59"
            TextBox26.Text = "23:59:59"
            TextBox12.Text = "23:59:59"
            TextBox27.Text = "23:59:59"
            TextBox13.Text = "23:59:59"
            TextBox28.Text = "23:59:59"
            TextBox14.Text = "23:59:59"
            TextBox29.Text = "23:59:59"
            TextBox15.Text = "23:59:59"
            TextBox30.Text = "23:59:59"
            TextBox9.ReadOnly = True
            TextBox24.ReadOnly = True
            TextBox10.ReadOnly = True
            TextBox25.ReadOnly = True
            TextBox11.ReadOnly = True
            TextBox26.ReadOnly = True
            TextBox12.ReadOnly = True
            TextBox27.ReadOnly = True
            TextBox13.ReadOnly = True
            TextBox28.ReadOnly = True
            TextBox14.ReadOnly = True
            TextBox29.ReadOnly = True
            TextBox15.ReadOnly = True
            TextBox30.ReadOnly = True
        ElseIf maxclass > 6 Then
            TextBox5.Text = zxtime("zm5s")
            TextBox20.Text = zxtime("zm5x")
            TextBox6.Text = zxtime("zm6s")
            TextBox21.Text = zxtime("zm6x")
            TextBox7.Text = zxtime("zm7s")
            TextBox22.Text = zxtime("zm7x")
            TextBox8.Text = "23:59:59"
            TextBox23.Text = "23:59:59"
            TextBox9.Text = "23:59:59"
            TextBox24.Text = "23:59:59"
            TextBox10.Text = "23:59:59"
            TextBox25.Text = "23:59:59"
            TextBox11.Text = "23:59:59"
            TextBox26.Text = "23:59:59"
            TextBox12.Text = "23:59:59"
            TextBox27.Text = "23:59:59"
            TextBox13.Text = "23:59:59"
            TextBox28.Text = "23:59:59"
            TextBox14.Text = "23:59:59"
            TextBox29.Text = "23:59:59"
            TextBox15.Text = "23:59:59"
            TextBox30.Text = "23:59:59"
            TextBox8.ReadOnly = True
            TextBox23.ReadOnly = True
            TextBox9.ReadOnly = True
            TextBox24.ReadOnly = True
            TextBox10.ReadOnly = True
            TextBox25.ReadOnly = True
            TextBox11.ReadOnly = True
            TextBox26.ReadOnly = True
            TextBox12.ReadOnly = True
            TextBox27.ReadOnly = True
            TextBox13.ReadOnly = True
            TextBox28.ReadOnly = True
            TextBox14.ReadOnly = True
            TextBox29.ReadOnly = True
            TextBox15.ReadOnly = True
            TextBox30.ReadOnly = True
        ElseIf maxclass > 5 Then
            TextBox5.Text = zxtime("zm5s")
            TextBox20.Text = zxtime("zm5x")
            TextBox6.Text = zxtime("zm6s")
            TextBox21.Text = zxtime("zm6x")
            TextBox7.Text = "23:59:59"
            TextBox22.Text = "23:59:59"
            TextBox8.Text = "23:59:59"
            TextBox23.Text = "23:59:59"
            TextBox9.Text = "23:59:59"
            TextBox24.Text = "23:59:59"
            TextBox10.Text = "23:59:59"
            TextBox25.Text = "23:59:59"
            TextBox11.Text = "23:59:59"
            TextBox26.Text = "23:59:59"
            TextBox12.Text = "23:59:59"
            TextBox27.Text = "23:59:59"
            TextBox13.Text = "23:59:59"
            TextBox28.Text = "23:59:59"
            TextBox14.Text = "23:59:59"
            TextBox29.Text = "23:59:59"
            TextBox15.Text = "23:59:59"
            TextBox30.Text = "23:59:59"
            TextBox7.ReadOnly = True
            TextBox22.ReadOnly = True
            TextBox8.ReadOnly = True
            TextBox23.ReadOnly = True
            TextBox9.ReadOnly = True
            TextBox24.ReadOnly = True
            TextBox10.ReadOnly = True
            TextBox25.ReadOnly = True
            TextBox11.ReadOnly = True
            TextBox26.ReadOnly = True
            TextBox12.ReadOnly = True
            TextBox27.ReadOnly = True
            TextBox13.ReadOnly = True
            TextBox28.ReadOnly = True
            TextBox14.ReadOnly = True
            TextBox29.ReadOnly = True
            TextBox15.ReadOnly = True
            TextBox30.ReadOnly = True
        ElseIf maxclass > 4 Then
            TextBox5.Text = zxtime("zm5s")
            TextBox20.Text = zxtime("zm5x")
            TextBox6.Text = "23:59:59"
            TextBox21.Text = "23:59:59"
            TextBox7.Text = "23:59:59"
            TextBox22.Text = "23:59:59"
            TextBox8.Text = "23:59:59"
            TextBox23.Text = "23:59:59"
            TextBox9.Text = "23:59:59"
            TextBox24.Text = "23:59:59"
            TextBox10.Text = "23:59:59"
            TextBox25.Text = "23:59:59"
            TextBox11.Text = "23:59:59"
            TextBox26.Text = "23:59:59"
            TextBox12.Text = "23:59:59"
            TextBox27.Text = "23:59:59"
            TextBox13.Text = "23:59:59"
            TextBox28.Text = "23:59:59"
            TextBox14.Text = "23:59:59"
            TextBox29.Text = "23:59:59"
            TextBox15.Text = "23:59:59"
            TextBox30.Text = "23:59:59"
            TextBox6.ReadOnly = True
            TextBox21.ReadOnly = True
            TextBox7.ReadOnly = True
            TextBox22.ReadOnly = True
            TextBox8.ReadOnly = True
            TextBox23.ReadOnly = True
            TextBox9.ReadOnly = True
            TextBox24.ReadOnly = True
            TextBox10.ReadOnly = True
            TextBox25.ReadOnly = True
            TextBox11.ReadOnly = True
            TextBox26.ReadOnly = True
            TextBox12.ReadOnly = True
            TextBox27.ReadOnly = True
            TextBox13.ReadOnly = True
            TextBox28.ReadOnly = True
            TextBox14.ReadOnly = True
            TextBox29.ReadOnly = True
            TextBox15.ReadOnly = True
            TextBox30.ReadOnly = True
        End If
        tss = My.Computer.FileSystem.ReadAllText("data\cl" & ds & "\tss.txt")
        If tss = "1" Then
            maxclass = Val(alldclass("ct", 1))
            RadioButton3.Checked = True
        ElseIf tss = "2" Then
            maxclass = Val(alldclass("ct", 2))
            RadioButton4.Checked = True
        ElseIf tss = "3" Then
            maxclass = Val(alldclass("ct", 3))
            RadioButton5.Checked = True
        ElseIf tss = "4" Then
            maxclass = Val(alldclass("ct", 4))
            RadioButton6.Checked = True
        ElseIf tss = "5" Then
            maxclass = Val(alldclass("ct", 5))
            RadioButton7.Checked = True
        ElseIf tss = "6" Then
            maxclass = Val(alldclass("ct", 6))
            RadioButton8.Checked = True
        ElseIf tss = "7" Then
            maxclass = Val(alldclass("ct", 7))
            RadioButton9.Checked = True
        ElseIf tss = "0" Then
            maxclass = 0
            RadioButton10.Checked = True
        End If
        TextBox36.ReadOnly = False
        TextBox51.ReadOnly = False
        TextBox37.ReadOnly = False
        TextBox52.ReadOnly = False
        TextBox38.ReadOnly = False
        TextBox53.ReadOnly = False
        TextBox39.ReadOnly = False
        TextBox54.ReadOnly = False
        TextBox40.ReadOnly = False
        TextBox55.ReadOnly = False
        TextBox41.ReadOnly = False
        TextBox56.ReadOnly = False
        TextBox42.ReadOnly = False
        TextBox57.ReadOnly = False
        TextBox43.ReadOnly = False
        TextBox58.ReadOnly = False
        TextBox44.ReadOnly = False
        TextBox59.ReadOnly = False
        TextBox45.ReadOnly = False
        TextBox60.ReadOnly = False
        TextBox31.Text = zxtime("zt1s")
        TextBox46.Text = zxtime("zt1x")
        TextBox32.Text = zxtime("zt2s")
        TextBox47.Text = zxtime("zt2x")
        TextBox33.Text = zxtime("zt3s")
        TextBox48.Text = zxtime("zt3x")
        TextBox34.Text = zxtime("zt4s")
        TextBox49.Text = zxtime("zt4x")
        If maxclass > 14 Then
            TextBox35.Text = zxtime("zt5s")
            TextBox50.Text = zxtime("zt5x")
            TextBox36.Text = zxtime("zt6s")
            TextBox51.Text = zxtime("zt6x")
            TextBox37.Text = zxtime("zt7s")
            TextBox52.Text = zxtime("zt7x")
            TextBox38.Text = zxtime("zt8s")
            TextBox53.Text = zxtime("zt8x")
            TextBox39.Text = zxtime("zt9s")
            TextBox54.Text = zxtime("zt9x")
            TextBox40.Text = zxtime("zt10s")
            TextBox55.Text = zxtime("zt10x")
            TextBox41.Text = zxtime("zt11s")
            TextBox56.Text = zxtime("zt11x")
            TextBox42.Text = zxtime("zt12s")
            TextBox57.Text = zxtime("zt12x")
            TextBox43.Text = zxtime("zt13s")
            TextBox58.Text = zxtime("zt13x")
            TextBox44.Text = zxtime("zt14s")
            TextBox59.Text = zxtime("zt14x")
            TextBox45.Text = zxtime("zt15s")
            TextBox60.Text = zxtime("zt15x")
        ElseIf maxclass > 13 Then
            TextBox35.Text = zxtime("zt5s")
            TextBox50.Text = zxtime("zt5x")
            TextBox36.Text = zxtime("zt6s")
            TextBox51.Text = zxtime("zt6x")
            TextBox37.Text = zxtime("zt7s")
            TextBox52.Text = zxtime("zt7x")
            TextBox38.Text = zxtime("zt8s")
            TextBox53.Text = zxtime("zt8x")
            TextBox39.Text = zxtime("zt9s")
            TextBox54.Text = zxtime("zt9x")
            TextBox40.Text = zxtime("zt10s")
            TextBox55.Text = zxtime("zt10x")
            TextBox41.Text = zxtime("zt11s")
            TextBox56.Text = zxtime("zt11x")
            TextBox42.Text = zxtime("zt12s")
            TextBox57.Text = zxtime("zt12x")
            TextBox43.Text = zxtime("zt13s")
            TextBox58.Text = zxtime("zt13x")
            TextBox44.Text = zxtime("zt14s")
            TextBox59.Text = zxtime("zt14x")
            TextBox45.Text = "23:59:59"
            TextBox60.Text = "23:59:59"
            TextBox45.ReadOnly = True
            TextBox60.ReadOnly = True
        ElseIf maxclass > 12 Then
            TextBox35.Text = zxtime("zt5s")
            TextBox50.Text = zxtime("zt5x")
            TextBox36.Text = zxtime("zt6s")
            TextBox51.Text = zxtime("zt6x")
            TextBox37.Text = zxtime("zt7s")
            TextBox52.Text = zxtime("zt7x")
            TextBox38.Text = zxtime("zt8s")
            TextBox53.Text = zxtime("zt8x")
            TextBox39.Text = zxtime("zt9s")
            TextBox54.Text = zxtime("zt9x")
            TextBox40.Text = zxtime("zt10s")
            TextBox55.Text = zxtime("zt10x")
            TextBox41.Text = zxtime("zt11s")
            TextBox56.Text = zxtime("zt11x")
            TextBox42.Text = zxtime("zt12s")
            TextBox57.Text = zxtime("zt12x")
            TextBox43.Text = zxtime("zt13s")
            TextBox58.Text = zxtime("zt13x")
            TextBox44.Text = "23:59:59"
            TextBox59.Text = "23:59:59"
            TextBox45.Text = "23:59:59"
            TextBox60.Text = "23:59:59"
            TextBox44.ReadOnly = True
            TextBox59.ReadOnly = True
            TextBox45.ReadOnly = True
            TextBox60.ReadOnly = True
        ElseIf maxclass > 11 Then
            TextBox35.Text = zxtime("zt5s")
            TextBox50.Text = zxtime("zt5x")
            TextBox36.Text = zxtime("zt6s")
            TextBox51.Text = zxtime("zt6x")
            TextBox37.Text = zxtime("zt7s")
            TextBox52.Text = zxtime("zt7x")
            TextBox38.Text = zxtime("zt8s")
            TextBox53.Text = zxtime("zt8x")
            TextBox39.Text = zxtime("zt9s")
            TextBox54.Text = zxtime("zt9x")
            TextBox40.Text = zxtime("zt10s")
            TextBox55.Text = zxtime("zt10x")
            TextBox41.Text = zxtime("zt11s")
            TextBox56.Text = zxtime("zt11x")
            TextBox42.Text = zxtime("zt12s")
            TextBox57.Text = zxtime("zt12x")
            TextBox43.Text = "23:59:59"
            TextBox58.Text = "23:59:59"
            TextBox44.Text = "23:59:59"
            TextBox59.Text = "23:59:59"
            TextBox45.Text = "23:59:59"
            TextBox60.Text = "23:59:59"
            TextBox43.ReadOnly = True
            TextBox58.ReadOnly = True
            TextBox44.ReadOnly = True
            TextBox59.ReadOnly = True
            TextBox45.ReadOnly = True
            TextBox60.ReadOnly = True
        ElseIf maxclass > 10 Then
            TextBox35.Text = zxtime("zt5s")
            TextBox50.Text = zxtime("zt5x")
            TextBox36.Text = zxtime("zt6s")
            TextBox51.Text = zxtime("zt6x")
            TextBox37.Text = zxtime("zt7s")
            TextBox52.Text = zxtime("zt7x")
            TextBox38.Text = zxtime("zt8s")
            TextBox53.Text = zxtime("zt8x")
            TextBox39.Text = zxtime("zt9s")
            TextBox54.Text = zxtime("zt9x")
            TextBox40.Text = zxtime("zt10s")
            TextBox55.Text = zxtime("zt10x")
            TextBox41.Text = zxtime("zt11s")
            TextBox56.Text = zxtime("zt11x")
            TextBox42.Text = "23:59:59"
            TextBox57.Text = "23:59:59"
            TextBox43.Text = "23:59:59"
            TextBox58.Text = "23:59:59"
            TextBox44.Text = "23:59:59"
            TextBox59.Text = "23:59:59"
            TextBox45.Text = "23:59:59"
            TextBox60.Text = "23:59:59"
            TextBox42.ReadOnly = True
            TextBox57.ReadOnly = True
            TextBox43.ReadOnly = True
            TextBox58.ReadOnly = True
            TextBox44.ReadOnly = True
            TextBox59.ReadOnly = True
            TextBox45.ReadOnly = True
            TextBox60.ReadOnly = True
        ElseIf maxclass > 9 Then
            TextBox35.Text = zxtime("zt5s")
            TextBox50.Text = zxtime("zt5x")
            TextBox36.Text = zxtime("zt6s")
            TextBox51.Text = zxtime("zt6x")
            TextBox37.Text = zxtime("zt7s")
            TextBox52.Text = zxtime("zt7x")
            TextBox38.Text = zxtime("zt8s")
            TextBox53.Text = zxtime("zt8x")
            TextBox39.Text = zxtime("zt9s")
            TextBox54.Text = zxtime("zt9x")
            TextBox40.Text = zxtime("zt10s")
            TextBox55.Text = zxtime("zt10x")
            TextBox41.Text = "23:59:59"
            TextBox56.Text = "23:59:59"
            TextBox42.Text = "23:59:59"
            TextBox57.Text = "23:59:59"
            TextBox43.Text = "23:59:59"
            TextBox58.Text = "23:59:59"
            TextBox44.Text = "23:59:59"
            TextBox59.Text = "23:59:59"
            TextBox45.Text = "23:59:59"
            TextBox60.Text = "23:59:59"
            TextBox41.ReadOnly = True
            TextBox56.ReadOnly = True
            TextBox42.ReadOnly = True
            TextBox57.ReadOnly = True
            TextBox43.ReadOnly = True
            TextBox58.ReadOnly = True
            TextBox44.ReadOnly = True
            TextBox59.ReadOnly = True
            TextBox45.ReadOnly = True
            TextBox60.ReadOnly = True
        ElseIf maxclass > 8 Then
            TextBox35.Text = zxtime("zt5s")
            TextBox50.Text = zxtime("zt5x")
            TextBox36.Text = zxtime("zt6s")
            TextBox51.Text = zxtime("zt6x")
            TextBox37.Text = zxtime("zt7s")
            TextBox52.Text = zxtime("zt7x")
            TextBox38.Text = zxtime("zt8s")
            TextBox53.Text = zxtime("zt8x")
            TextBox39.Text = zxtime("zt9s")
            TextBox54.Text = zxtime("zt9x")
            TextBox40.Text = "23:59:59"
            TextBox55.Text = "23:59:59"
            TextBox41.Text = "23:59:59"
            TextBox56.Text = "23:59:59"
            TextBox42.Text = "23:59:59"
            TextBox57.Text = "23:59:59"
            TextBox43.Text = "23:59:59"
            TextBox58.Text = "23:59:59"
            TextBox44.Text = "23:59:59"
            TextBox59.Text = "23:59:59"
            TextBox45.Text = "23:59:59"
            TextBox60.Text = "23:59:59"
            TextBox40.ReadOnly = True
            TextBox55.ReadOnly = True
            TextBox41.ReadOnly = True
            TextBox56.ReadOnly = True
            TextBox42.ReadOnly = True
            TextBox57.ReadOnly = True
            TextBox43.ReadOnly = True
            TextBox58.ReadOnly = True
            TextBox44.ReadOnly = True
            TextBox59.ReadOnly = True
            TextBox45.ReadOnly = True
            TextBox60.ReadOnly = True
        ElseIf maxclass > 7 Then
            TextBox35.Text = zxtime("zt5s")
            TextBox50.Text = zxtime("zt5x")
            TextBox36.Text = zxtime("zt6s")
            TextBox51.Text = zxtime("zt6x")
            TextBox37.Text = zxtime("zt7s")
            TextBox52.Text = zxtime("zt7x")
            TextBox38.Text = zxtime("zt8s")
            TextBox53.Text = zxtime("zt8x")
            TextBox39.Text = "23:59:59"
            TextBox54.Text = "23:59:59"
            TextBox40.Text = "23:59:59"
            TextBox55.Text = "23:59:59"
            TextBox41.Text = "23:59:59"
            TextBox56.Text = "23:59:59"
            TextBox42.Text = "23:59:59"
            TextBox57.Text = "23:59:59"
            TextBox43.Text = "23:59:59"
            TextBox58.Text = "23:59:59"
            TextBox44.Text = "23:59:59"
            TextBox59.Text = "23:59:59"
            TextBox45.Text = "23:59:59"
            TextBox60.Text = "23:59:59"
            TextBox39.ReadOnly = True
            TextBox54.ReadOnly = True
            TextBox40.ReadOnly = True
            TextBox55.ReadOnly = True
            TextBox41.ReadOnly = True
            TextBox56.ReadOnly = True
            TextBox42.ReadOnly = True
            TextBox57.ReadOnly = True
            TextBox43.ReadOnly = True
            TextBox58.ReadOnly = True
            TextBox44.ReadOnly = True
            TextBox59.ReadOnly = True
            TextBox45.ReadOnly = True
            TextBox60.ReadOnly = True
        ElseIf maxclass > 6 Then
            TextBox35.Text = zxtime("zt5s")
            TextBox50.Text = zxtime("zt5x")
            TextBox36.Text = zxtime("zt6s")
            TextBox51.Text = zxtime("zt6x")
            TextBox37.Text = zxtime("zt7s")
            TextBox52.Text = zxtime("zt7x")
            TextBox38.Text = "23:59:59"
            TextBox53.Text = "23:59:59"
            TextBox39.Text = "23:59:59"
            TextBox54.Text = "23:59:59"
            TextBox40.Text = "23:59:59"
            TextBox55.Text = "23:59:59"
            TextBox41.Text = "23:59:59"
            TextBox56.Text = "23:59:59"
            TextBox42.Text = "23:59:59"
            TextBox57.Text = "23:59:59"
            TextBox43.Text = "23:59:59"
            TextBox58.Text = "23:59:59"
            TextBox44.Text = "23:59:59"
            TextBox59.Text = "23:59:59"
            TextBox45.Text = "23:59:59"
            TextBox60.Text = "23:59:59"
            TextBox38.ReadOnly = True
            TextBox53.ReadOnly = True
            TextBox39.ReadOnly = True
            TextBox54.ReadOnly = True
            TextBox40.ReadOnly = True
            TextBox55.ReadOnly = True
            TextBox41.ReadOnly = True
            TextBox56.ReadOnly = True
            TextBox42.ReadOnly = True
            TextBox57.ReadOnly = True
            TextBox43.ReadOnly = True
            TextBox58.ReadOnly = True
            TextBox44.ReadOnly = True
            TextBox59.ReadOnly = True
            TextBox45.ReadOnly = True
            TextBox60.ReadOnly = True
        ElseIf maxclass > 5 Then
            TextBox35.Text = zxtime("zt5s")
            TextBox50.Text = zxtime("zt5x")
            TextBox36.Text = zxtime("zt6s")
            TextBox51.Text = zxtime("zt6x")
            TextBox37.Text = "23:59:59"
            TextBox52.Text = "23:59:59"
            TextBox38.Text = "23:59:59"
            TextBox53.Text = "23:59:59"
            TextBox39.Text = "23:59:59"
            TextBox54.Text = "23:59:59"
            TextBox40.Text = "23:59:59"
            TextBox55.Text = "23:59:59"
            TextBox41.Text = "23:59:59"
            TextBox56.Text = "23:59:59"
            TextBox42.Text = "23:59:59"
            TextBox57.Text = "23:59:59"
            TextBox43.Text = "23:59:59"
            TextBox58.Text = "23:59:59"
            TextBox44.Text = "23:59:59"
            TextBox59.Text = "23:59:59"
            TextBox45.Text = "23:59:59"
            TextBox60.Text = "23:59:59"
            TextBox37.ReadOnly = True
            TextBox52.ReadOnly = True
            TextBox38.ReadOnly = True
            TextBox53.ReadOnly = True
            TextBox39.ReadOnly = True
            TextBox54.ReadOnly = True
            TextBox40.ReadOnly = True
            TextBox55.ReadOnly = True
            TextBox41.ReadOnly = True
            TextBox56.ReadOnly = True
            TextBox42.ReadOnly = True
            TextBox57.ReadOnly = True
            TextBox43.ReadOnly = True
            TextBox58.ReadOnly = True
            TextBox44.ReadOnly = True
            TextBox59.ReadOnly = True
            TextBox45.ReadOnly = True
            TextBox60.ReadOnly = True
        ElseIf maxclass > 4 Then
            TextBox35.Text = zxtime("zt5s")
            TextBox50.Text = zxtime("zt5x")
            TextBox36.Text = "23:59:59"
            TextBox51.Text = "23:59:59"
            TextBox37.Text = "23:59:59"
            TextBox52.Text = "23:59:59"
            TextBox38.Text = "23:59:59"
            TextBox53.Text = "23:59:59"
            TextBox39.Text = "23:59:59"
            TextBox54.Text = "23:59:59"
            TextBox40.Text = "23:59:59"
            TextBox55.Text = "23:59:59"
            TextBox41.Text = "23:59:59"
            TextBox56.Text = "23:59:59"
            TextBox42.Text = "23:59:59"
            TextBox57.Text = "23:59:59"
            TextBox43.Text = "23:59:59"
            TextBox58.Text = "23:59:59"
            TextBox44.Text = "23:59:59"
            TextBox59.Text = "23:59:59"
            TextBox45.Text = "23:59:59"
            TextBox60.Text = "23:59:59"
            TextBox36.ReadOnly = True
            TextBox51.ReadOnly = True
            TextBox37.ReadOnly = True
            TextBox52.ReadOnly = True
            TextBox38.ReadOnly = True
            TextBox53.ReadOnly = True
            TextBox39.ReadOnly = True
            TextBox54.ReadOnly = True
            TextBox40.ReadOnly = True
            TextBox55.ReadOnly = True
            TextBox41.ReadOnly = True
            TextBox56.ReadOnly = True
            TextBox42.ReadOnly = True
            TextBox57.ReadOnly = True
            TextBox43.ReadOnly = True
            TextBox58.ReadOnly = True
            TextBox44.ReadOnly = True
            TextBox59.ReadOnly = True
            TextBox45.ReadOnly = True
            TextBox60.ReadOnly = True
        ElseIf maxclass = 0 Then
            TextBox31.Text = "23:59:59"
            TextBox46.Text = "23:59:59"
            TextBox32.Text = "23:59:59"
            TextBox47.Text = "23:59:59"
            TextBox33.Text = "23:59:59"
            TextBox48.Text = "23:59:59"
            TextBox34.Text = "23:59:59"
            TextBox49.Text = "23:59:59"
            TextBox35.Text = "23:59:59"
            TextBox50.Text = "23:59:59"
            TextBox36.Text = "23:59:59"
            TextBox51.Text = "23:59:59"
            TextBox37.Text = "23:59:59"
            TextBox52.Text = "23:59:59"
            TextBox38.Text = "23:59:59"
            TextBox53.Text = "23:59:59"
            TextBox39.Text = "23:59:59"
            TextBox54.Text = "23:59:59"
            TextBox40.Text = "23:59:59"
            TextBox55.Text = "23:59:59"
            TextBox41.Text = "23:59:59"
            TextBox56.Text = "23:59:59"
            TextBox42.Text = "23:59:59"
            TextBox57.Text = "23:59:59"
            TextBox43.Text = "23:59:59"
            TextBox58.Text = "23:59:59"
            TextBox44.Text = "23:59:59"
            TextBox59.Text = "23:59:59"
            TextBox45.Text = "23:59:59"
            TextBox60.Text = "23:59:59"
            TextBox31.ReadOnly = True
            TextBox46.ReadOnly = True
            TextBox32.ReadOnly = True
            TextBox47.ReadOnly = True
            TextBox33.ReadOnly = True
            TextBox48.ReadOnly = True
            TextBox34.ReadOnly = True
            TextBox49.ReadOnly = True
            TextBox35.ReadOnly = True
            TextBox50.ReadOnly = True
            TextBox36.ReadOnly = True
            TextBox51.ReadOnly = True
            TextBox37.ReadOnly = True
            TextBox52.ReadOnly = True
            TextBox38.ReadOnly = True
            TextBox53.ReadOnly = True
            TextBox39.ReadOnly = True
            TextBox54.ReadOnly = True
            TextBox40.ReadOnly = True
            TextBox55.ReadOnly = True
            TextBox41.ReadOnly = True
            TextBox56.ReadOnly = True
            TextBox42.ReadOnly = True
            TextBox57.ReadOnly = True
            TextBox43.ReadOnly = True
            TextBox58.ReadOnly = True
            TextBox44.ReadOnly = True
            TextBox59.ReadOnly = True
            TextBox45.ReadOnly = True
            TextBox60.ReadOnly = True
        End If
        bc = True
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is TextBox Then
                AddHandler ctrl.TextChanged, AddressOf TextBox_TextChanged
            End If
        Next
        ycsj()
    End Sub

    Public Sub jztssjb(ts As Integer)
        If Not ts = 0 Then
            maxclass = Val(alldclass("ct", ts))
            TextBox31.ReadOnly = False
            TextBox46.ReadOnly = False
            TextBox32.ReadOnly = False
            TextBox47.ReadOnly = False
            TextBox33.ReadOnly = False
            TextBox48.ReadOnly = False
            TextBox34.ReadOnly = False
            TextBox49.ReadOnly = False
            TextBox35.ReadOnly = False
            TextBox50.ReadOnly = False
            TextBox36.ReadOnly = False
            TextBox51.ReadOnly = False
            TextBox37.ReadOnly = False
            TextBox52.ReadOnly = False
            TextBox38.ReadOnly = False
            TextBox53.ReadOnly = False
            TextBox39.ReadOnly = False
            TextBox54.ReadOnly = False
            TextBox40.ReadOnly = False
            TextBox55.ReadOnly = False
            TextBox41.ReadOnly = False
            TextBox56.ReadOnly = False
            TextBox42.ReadOnly = False
            TextBox57.ReadOnly = False
            TextBox43.ReadOnly = False
            TextBox58.ReadOnly = False
            TextBox44.ReadOnly = False
            TextBox59.ReadOnly = False
            TextBox45.ReadOnly = False
            TextBox60.ReadOnly = False
            TextBox31.Text = zxtime("zt1s")
            TextBox46.Text = zxtime("zt1x")
            TextBox32.Text = zxtime("zt2s")
            TextBox47.Text = zxtime("zt2x")
            TextBox33.Text = zxtime("zt3s")
            TextBox48.Text = zxtime("zt3x")
            TextBox34.Text = zxtime("zt4s")
            TextBox49.Text = zxtime("zt4x")
            If maxclass > 14 Then
                TextBox35.Text = zxtime("zt5s")
                TextBox50.Text = zxtime("zt5x")
                TextBox36.Text = zxtime("zt6s")
                TextBox51.Text = zxtime("zt6x")
                TextBox37.Text = zxtime("zt7s")
                TextBox52.Text = zxtime("zt7x")
                TextBox38.Text = zxtime("zt8s")
                TextBox53.Text = zxtime("zt8x")
                TextBox39.Text = zxtime("zt9s")
                TextBox54.Text = zxtime("zt9x")
                TextBox40.Text = zxtime("zt10s")
                TextBox55.Text = zxtime("zt10x")
                TextBox41.Text = zxtime("zt11s")
                TextBox56.Text = zxtime("zt11x")
                TextBox42.Text = zxtime("zt12s")
                TextBox57.Text = zxtime("zt12x")
                TextBox43.Text = zxtime("zt13s")
                TextBox58.Text = zxtime("zt13x")
                TextBox44.Text = zxtime("zt14s")
                TextBox59.Text = zxtime("zt14x")
                TextBox45.Text = zxtime("zt15s")
                TextBox60.Text = zxtime("zt15x")
            ElseIf maxclass > 13 Then
                TextBox35.Text = zxtime("zt5s")
                TextBox50.Text = zxtime("zt5x")
                TextBox36.Text = zxtime("zt6s")
                TextBox51.Text = zxtime("zt6x")
                TextBox37.Text = zxtime("zt7s")
                TextBox52.Text = zxtime("zt7x")
                TextBox38.Text = zxtime("zt8s")
                TextBox53.Text = zxtime("zt8x")
                TextBox39.Text = zxtime("zt9s")
                TextBox54.Text = zxtime("zt9x")
                TextBox40.Text = zxtime("zt10s")
                TextBox55.Text = zxtime("zt10x")
                TextBox41.Text = zxtime("zt11s")
                TextBox56.Text = zxtime("zt11x")
                TextBox42.Text = zxtime("zt12s")
                TextBox57.Text = zxtime("zt12x")
                TextBox43.Text = zxtime("zt13s")
                TextBox58.Text = zxtime("zt13x")
                TextBox44.Text = zxtime("zt14s")
                TextBox59.Text = zxtime("zt14x")
                TextBox45.Text = "23:59:59"
                TextBox60.Text = "23:59:59"
                TextBox45.ReadOnly = True
                TextBox60.ReadOnly = True
            ElseIf maxclass > 12 Then
                TextBox35.Text = zxtime("zt5s")
                TextBox50.Text = zxtime("zt5x")
                TextBox36.Text = zxtime("zt6s")
                TextBox51.Text = zxtime("zt6x")
                TextBox37.Text = zxtime("zt7s")
                TextBox52.Text = zxtime("zt7x")
                TextBox38.Text = zxtime("zt8s")
                TextBox53.Text = zxtime("zt8x")
                TextBox39.Text = zxtime("zt9s")
                TextBox54.Text = zxtime("zt9x")
                TextBox40.Text = zxtime("zt10s")
                TextBox55.Text = zxtime("zt10x")
                TextBox41.Text = zxtime("zt11s")
                TextBox56.Text = zxtime("zt11x")
                TextBox42.Text = zxtime("zt12s")
                TextBox57.Text = zxtime("zt12x")
                TextBox43.Text = zxtime("zt13s")
                TextBox58.Text = zxtime("zt13x")
                TextBox44.Text = "23:59:59"
                TextBox59.Text = "23:59:59"
                TextBox45.Text = "23:59:59"
                TextBox60.Text = "23:59:59"
                TextBox44.ReadOnly = True
                TextBox59.ReadOnly = True
                TextBox45.ReadOnly = True
                TextBox60.ReadOnly = True
            ElseIf maxclass > 11 Then
                TextBox35.Text = zxtime("zt5s")
                TextBox50.Text = zxtime("zt5x")
                TextBox36.Text = zxtime("zt6s")
                TextBox51.Text = zxtime("zt6x")
                TextBox37.Text = zxtime("zt7s")
                TextBox52.Text = zxtime("zt7x")
                TextBox38.Text = zxtime("zt8s")
                TextBox53.Text = zxtime("zt8x")
                TextBox39.Text = zxtime("zt9s")
                TextBox54.Text = zxtime("zt9x")
                TextBox40.Text = zxtime("zt10s")
                TextBox55.Text = zxtime("zt10x")
                TextBox41.Text = zxtime("zt11s")
                TextBox56.Text = zxtime("zt11x")
                TextBox42.Text = zxtime("zt12s")
                TextBox57.Text = zxtime("zt12x")
                TextBox43.Text = "23:59:59"
                TextBox58.Text = "23:59:59"
                TextBox44.Text = "23:59:59"
                TextBox59.Text = "23:59:59"
                TextBox45.Text = "23:59:59"
                TextBox60.Text = "23:59:59"
                TextBox43.ReadOnly = True
                TextBox58.ReadOnly = True
                TextBox44.ReadOnly = True
                TextBox59.ReadOnly = True
                TextBox45.ReadOnly = True
                TextBox60.ReadOnly = True
            ElseIf maxclass > 10 Then
                TextBox35.Text = zxtime("zt5s")
                TextBox50.Text = zxtime("zt5x")
                TextBox36.Text = zxtime("zt6s")
                TextBox51.Text = zxtime("zt6x")
                TextBox37.Text = zxtime("zt7s")
                TextBox52.Text = zxtime("zt7x")
                TextBox38.Text = zxtime("zt8s")
                TextBox53.Text = zxtime("zt8x")
                TextBox39.Text = zxtime("zt9s")
                TextBox54.Text = zxtime("zt9x")
                TextBox40.Text = zxtime("zt10s")
                TextBox55.Text = zxtime("zt10x")
                TextBox41.Text = zxtime("zt11s")
                TextBox56.Text = zxtime("zt11x")
                TextBox42.Text = "23:59:59"
                TextBox57.Text = "23:59:59"
                TextBox43.Text = "23:59:59"
                TextBox58.Text = "23:59:59"
                TextBox44.Text = "23:59:59"
                TextBox59.Text = "23:59:59"
                TextBox45.Text = "23:59:59"
                TextBox60.Text = "23:59:59"
                TextBox42.ReadOnly = True
                TextBox57.ReadOnly = True
                TextBox43.ReadOnly = True
                TextBox58.ReadOnly = True
                TextBox44.ReadOnly = True
                TextBox59.ReadOnly = True
                TextBox45.ReadOnly = True
                TextBox60.ReadOnly = True
            ElseIf maxclass > 9 Then
                TextBox35.Text = zxtime("zt5s")
                TextBox50.Text = zxtime("zt5x")
                TextBox36.Text = zxtime("zt6s")
                TextBox51.Text = zxtime("zt6x")
                TextBox37.Text = zxtime("zt7s")
                TextBox52.Text = zxtime("zt7x")
                TextBox38.Text = zxtime("zt8s")
                TextBox53.Text = zxtime("zt8x")
                TextBox39.Text = zxtime("zt9s")
                TextBox54.Text = zxtime("zt9x")
                TextBox40.Text = zxtime("zt10s")
                TextBox55.Text = zxtime("zt10x")
                TextBox41.Text = "23:59:59"
                TextBox56.Text = "23:59:59"
                TextBox42.Text = "23:59:59"
                TextBox57.Text = "23:59:59"
                TextBox43.Text = "23:59:59"
                TextBox58.Text = "23:59:59"
                TextBox44.Text = "23:59:59"
                TextBox59.Text = "23:59:59"
                TextBox45.Text = "23:59:59"
                TextBox60.Text = "23:59:59"
                TextBox41.ReadOnly = True
                TextBox56.ReadOnly = True
                TextBox42.ReadOnly = True
                TextBox57.ReadOnly = True
                TextBox43.ReadOnly = True
                TextBox58.ReadOnly = True
                TextBox44.ReadOnly = True
                TextBox59.ReadOnly = True
                TextBox45.ReadOnly = True
                TextBox60.ReadOnly = True
            ElseIf maxclass > 8 Then
                TextBox35.Text = zxtime("zt5s")
                TextBox50.Text = zxtime("zt5x")
                TextBox36.Text = zxtime("zt6s")
                TextBox51.Text = zxtime("zt6x")
                TextBox37.Text = zxtime("zt7s")
                TextBox52.Text = zxtime("zt7x")
                TextBox38.Text = zxtime("zt8s")
                TextBox53.Text = zxtime("zt8x")
                TextBox39.Text = zxtime("zt9s")
                TextBox54.Text = zxtime("zt9x")
                TextBox40.Text = "23:59:59"
                TextBox55.Text = "23:59:59"
                TextBox41.Text = "23:59:59"
                TextBox56.Text = "23:59:59"
                TextBox42.Text = "23:59:59"
                TextBox57.Text = "23:59:59"
                TextBox43.Text = "23:59:59"
                TextBox58.Text = "23:59:59"
                TextBox44.Text = "23:59:59"
                TextBox59.Text = "23:59:59"
                TextBox45.Text = "23:59:59"
                TextBox60.Text = "23:59:59"
                TextBox40.ReadOnly = True
                TextBox55.ReadOnly = True
                TextBox41.ReadOnly = True
                TextBox56.ReadOnly = True
                TextBox42.ReadOnly = True
                TextBox57.ReadOnly = True
                TextBox43.ReadOnly = True
                TextBox58.ReadOnly = True
                TextBox44.ReadOnly = True
                TextBox59.ReadOnly = True
                TextBox45.ReadOnly = True
                TextBox60.ReadOnly = True
            ElseIf maxclass > 7 Then
                TextBox35.Text = zxtime("zt5s")
                TextBox50.Text = zxtime("zt5x")
                TextBox36.Text = zxtime("zt6s")
                TextBox51.Text = zxtime("zt6x")
                TextBox37.Text = zxtime("zt7s")
                TextBox52.Text = zxtime("zt7x")
                TextBox38.Text = zxtime("zt8s")
                TextBox53.Text = zxtime("zt8x")
                TextBox39.Text = "23:59:59"
                TextBox54.Text = "23:59:59"
                TextBox40.Text = "23:59:59"
                TextBox55.Text = "23:59:59"
                TextBox41.Text = "23:59:59"
                TextBox56.Text = "23:59:59"
                TextBox42.Text = "23:59:59"
                TextBox57.Text = "23:59:59"
                TextBox43.Text = "23:59:59"
                TextBox58.Text = "23:59:59"
                TextBox44.Text = "23:59:59"
                TextBox59.Text = "23:59:59"
                TextBox45.Text = "23:59:59"
                TextBox60.Text = "23:59:59"
                TextBox39.ReadOnly = True
                TextBox54.ReadOnly = True
                TextBox40.ReadOnly = True
                TextBox55.ReadOnly = True
                TextBox41.ReadOnly = True
                TextBox56.ReadOnly = True
                TextBox42.ReadOnly = True
                TextBox57.ReadOnly = True
                TextBox43.ReadOnly = True
                TextBox58.ReadOnly = True
                TextBox44.ReadOnly = True
                TextBox59.ReadOnly = True
                TextBox45.ReadOnly = True
                TextBox60.ReadOnly = True
            ElseIf maxclass > 6 Then
                TextBox35.Text = zxtime("zt5s")
                TextBox50.Text = zxtime("zt5x")
                TextBox36.Text = zxtime("zt6s")
                TextBox51.Text = zxtime("zt6x")
                TextBox37.Text = zxtime("zt7s")
                TextBox52.Text = zxtime("zt7x")
                TextBox38.Text = "23:59:59"
                TextBox53.Text = "23:59:59"
                TextBox39.Text = "23:59:59"
                TextBox54.Text = "23:59:59"
                TextBox40.Text = "23:59:59"
                TextBox55.Text = "23:59:59"
                TextBox41.Text = "23:59:59"
                TextBox56.Text = "23:59:59"
                TextBox42.Text = "23:59:59"
                TextBox57.Text = "23:59:59"
                TextBox43.Text = "23:59:59"
                TextBox58.Text = "23:59:59"
                TextBox44.Text = "23:59:59"
                TextBox59.Text = "23:59:59"
                TextBox45.Text = "23:59:59"
                TextBox60.Text = "23:59:59"
                TextBox38.ReadOnly = True
                TextBox53.ReadOnly = True
                TextBox39.ReadOnly = True
                TextBox54.ReadOnly = True
                TextBox40.ReadOnly = True
                TextBox55.ReadOnly = True
                TextBox41.ReadOnly = True
                TextBox56.ReadOnly = True
                TextBox42.ReadOnly = True
                TextBox57.ReadOnly = True
                TextBox43.ReadOnly = True
                TextBox58.ReadOnly = True
                TextBox44.ReadOnly = True
                TextBox59.ReadOnly = True
                TextBox45.ReadOnly = True
                TextBox60.ReadOnly = True
            ElseIf maxclass > 5 Then
                TextBox35.Text = zxtime("zt5s")
                TextBox50.Text = zxtime("zt5x")
                TextBox36.Text = zxtime("zt6s")
                TextBox51.Text = zxtime("zt6x")
                TextBox37.Text = "23:59:59"
                TextBox52.Text = "23:59:59"
                TextBox38.Text = "23:59:59"
                TextBox53.Text = "23:59:59"
                TextBox39.Text = "23:59:59"
                TextBox54.Text = "23:59:59"
                TextBox40.Text = "23:59:59"
                TextBox55.Text = "23:59:59"
                TextBox41.Text = "23:59:59"
                TextBox56.Text = "23:59:59"
                TextBox42.Text = "23:59:59"
                TextBox57.Text = "23:59:59"
                TextBox43.Text = "23:59:59"
                TextBox58.Text = "23:59:59"
                TextBox44.Text = "23:59:59"
                TextBox59.Text = "23:59:59"
                TextBox45.Text = "23:59:59"
                TextBox60.Text = "23:59:59"
                TextBox37.ReadOnly = True
                TextBox52.ReadOnly = True
                TextBox38.ReadOnly = True
                TextBox53.ReadOnly = True
                TextBox39.ReadOnly = True
                TextBox54.ReadOnly = True
                TextBox40.ReadOnly = True
                TextBox55.ReadOnly = True
                TextBox41.ReadOnly = True
                TextBox56.ReadOnly = True
                TextBox42.ReadOnly = True
                TextBox57.ReadOnly = True
                TextBox43.ReadOnly = True
                TextBox58.ReadOnly = True
                TextBox44.ReadOnly = True
                TextBox59.ReadOnly = True
                TextBox45.ReadOnly = True
                TextBox60.ReadOnly = True
            ElseIf maxclass > 4 Then
                TextBox35.Text = zxtime("zt5s")
                TextBox50.Text = zxtime("zt5x")
                TextBox36.Text = "23:59:59"
                TextBox51.Text = "23:59:59"
                TextBox37.Text = "23:59:59"
                TextBox52.Text = "23:59:59"
                TextBox38.Text = "23:59:59"
                TextBox53.Text = "23:59:59"
                TextBox39.Text = "23:59:59"
                TextBox54.Text = "23:59:59"
                TextBox40.Text = "23:59:59"
                TextBox55.Text = "23:59:59"
                TextBox41.Text = "23:59:59"
                TextBox56.Text = "23:59:59"
                TextBox42.Text = "23:59:59"
                TextBox57.Text = "23:59:59"
                TextBox43.Text = "23:59:59"
                TextBox58.Text = "23:59:59"
                TextBox44.Text = "23:59:59"
                TextBox59.Text = "23:59:59"
                TextBox45.Text = "23:59:59"
                TextBox60.Text = "23:59:59"
                TextBox36.ReadOnly = True
                TextBox51.ReadOnly = True
                TextBox37.ReadOnly = True
                TextBox52.ReadOnly = True
                TextBox38.ReadOnly = True
                TextBox53.ReadOnly = True
                TextBox39.ReadOnly = True
                TextBox54.ReadOnly = True
                TextBox40.ReadOnly = True
                TextBox55.ReadOnly = True
                TextBox41.ReadOnly = True
                TextBox56.ReadOnly = True
                TextBox42.ReadOnly = True
                TextBox57.ReadOnly = True
                TextBox43.ReadOnly = True
                TextBox58.ReadOnly = True
                TextBox44.ReadOnly = True
                TextBox59.ReadOnly = True
                TextBox45.ReadOnly = True
                TextBox60.ReadOnly = True
            End If
        Else
            TextBox31.ReadOnly = True
            TextBox46.ReadOnly = True
            TextBox32.ReadOnly = True
            TextBox47.ReadOnly = True
            TextBox33.ReadOnly = True
            TextBox48.ReadOnly = True
            TextBox34.ReadOnly = True
            TextBox49.ReadOnly = True
            TextBox35.ReadOnly = True
            TextBox50.ReadOnly = True
            TextBox36.ReadOnly = True
            TextBox51.ReadOnly = True
            TextBox37.ReadOnly = True
            TextBox52.ReadOnly = True
            TextBox38.ReadOnly = True
            TextBox53.ReadOnly = True
            TextBox39.ReadOnly = True
            TextBox54.ReadOnly = True
            TextBox40.ReadOnly = True
            TextBox55.ReadOnly = True
            TextBox41.ReadOnly = True
            TextBox56.ReadOnly = True
            TextBox42.ReadOnly = True
            TextBox57.ReadOnly = True
            TextBox43.ReadOnly = True
            TextBox58.ReadOnly = True
            TextBox44.ReadOnly = True
            TextBox59.ReadOnly = True
            TextBox45.ReadOnly = True
            TextBox60.ReadOnly = True
            TextBox31.Text = "23:59:59"
            TextBox46.Text = "23:59:59"
            TextBox32.Text = "23:59:59"
            TextBox47.Text = "23:59:59"
            TextBox33.Text = "23:59:59"
            TextBox48.Text = "23:59:59"
            TextBox34.Text = "23:59:59"
            TextBox49.Text = "23:59:59"
            TextBox35.Text = "23:59:59"
            TextBox50.Text = "23:59:59"
            TextBox36.Text = "23:59:59"
            TextBox51.Text = "23:59:59"
            TextBox37.Text = "23:59:59"
            TextBox52.Text = "23:59:59"
            TextBox38.Text = "23:59:59"
            TextBox53.Text = "23:59:59"
            TextBox39.Text = "23:59:59"
            TextBox54.Text = "23:59:59"
            TextBox40.Text = "23:59:59"
            TextBox55.Text = "23:59:59"
            TextBox41.Text = "23:59:59"
            TextBox56.Text = "23:59:59"
            TextBox42.Text = "23:59:59"
            TextBox57.Text = "23:59:59"
            TextBox43.Text = "23:59:59"
            TextBox58.Text = "23:59:59"
            TextBox44.Text = "23:59:59"
            TextBox59.Text = "23:59:59"
            TextBox45.Text = "23:59:59"
            TextBox60.Text = "23:59:59"
        End If
        ycsj()
    End Sub

    Public Sub ycsj()
        Dim ybc As Color
        If TextBox1.Text = "23:59:59" And TextBox1.ReadOnly = True Then
            ybc = TextBox1.BackColor
            TextBox1.BackColor = ybc
            TextBox1.ForeColor = ybc
        Else
            ybc = TextBox1.BackColor
            TextBox1.BackColor = ybc
            TextBox1.ForeColor = Color.Black
        End If
        If TextBox2.Text = "23:59:59" And TextBox2.ReadOnly = True Then
            ybc = TextBox2.BackColor
            TextBox2.BackColor = ybc
            TextBox2.ForeColor = ybc
        Else
            ybc = TextBox2.BackColor
            TextBox2.BackColor = ybc
            TextBox2.ForeColor = Color.Black
        End If
        If TextBox3.Text = "23:59:59" And TextBox3.ReadOnly = True Then
            ybc = TextBox3.BackColor
            TextBox3.BackColor = ybc
            TextBox3.ForeColor = ybc
        Else
            ybc = TextBox3.BackColor
            TextBox3.BackColor = ybc
            TextBox3.ForeColor = Color.Black
        End If
        If TextBox4.Text = "23:59:59" And TextBox4.ReadOnly = True Then
            ybc = TextBox4.BackColor
            TextBox4.BackColor = ybc
            TextBox4.ForeColor = ybc
        Else
            ybc = TextBox4.BackColor
            TextBox4.BackColor = ybc
            TextBox4.ForeColor = Color.Black
        End If
        If TextBox5.Text = "23:59:59" And TextBox5.ReadOnly = True Then
            ybc = TextBox5.BackColor
            TextBox5.BackColor = ybc
            TextBox5.ForeColor = ybc
        Else
            ybc = TextBox5.BackColor
            TextBox5.BackColor = ybc
            TextBox5.ForeColor = Color.Black
        End If
        If TextBox6.Text = "23:59:59" And TextBox6.ReadOnly = True Then
            ybc = TextBox6.BackColor
            TextBox6.BackColor = ybc
            TextBox6.ForeColor = ybc
        Else
            ybc = TextBox6.BackColor
            TextBox6.BackColor = ybc
            TextBox6.ForeColor = Color.Black
        End If
        If TextBox7.Text = "23:59:59" And TextBox7.ReadOnly = True Then
            ybc = TextBox7.BackColor
            TextBox7.BackColor = ybc
            TextBox7.ForeColor = ybc
        Else
            ybc = TextBox7.BackColor
            TextBox7.BackColor = ybc
            TextBox7.ForeColor = Color.Black
        End If
        If TextBox8.Text = "23:59:59" And TextBox8.ReadOnly = True Then
            ybc = TextBox8.BackColor
            TextBox8.BackColor = ybc
            TextBox8.ForeColor = ybc
        Else
            ybc = TextBox8.BackColor
            TextBox8.BackColor = ybc
            TextBox8.ForeColor = Color.Black
        End If
        If TextBox9.Text = "23:59:59" And TextBox9.ReadOnly = True Then
            ybc = TextBox9.BackColor
            TextBox9.BackColor = ybc
            TextBox9.ForeColor = ybc
        Else
            ybc = TextBox9.BackColor
            TextBox9.BackColor = ybc
            TextBox9.ForeColor = Color.Black
        End If
        If TextBox10.Text = "23:59:59" And TextBox10.ReadOnly = True Then
            ybc = TextBox10.BackColor
            TextBox10.BackColor = ybc
            TextBox10.ForeColor = ybc
        Else
            ybc = TextBox10.BackColor
            TextBox10.BackColor = ybc
            TextBox10.ForeColor = Color.Black
        End If
        If TextBox11.Text = "23:59:59" And TextBox11.ReadOnly = True Then
            ybc = TextBox11.BackColor
            TextBox11.BackColor = ybc
            TextBox11.ForeColor = ybc
        Else
            ybc = TextBox11.BackColor
            TextBox11.BackColor = ybc
            TextBox11.ForeColor = Color.Black
        End If
        If TextBox12.Text = "23:59:59" And TextBox12.ReadOnly = True Then
            ybc = TextBox12.BackColor
            TextBox12.BackColor = ybc
            TextBox12.ForeColor = ybc
        Else
            ybc = TextBox12.BackColor
            TextBox12.BackColor = ybc
            TextBox12.ForeColor = Color.Black
        End If
        If TextBox13.Text = "23:59:59" And TextBox13.ReadOnly = True Then
            ybc = TextBox13.BackColor
            TextBox13.BackColor = ybc
            TextBox13.ForeColor = ybc
        Else
            ybc = TextBox13.BackColor
            TextBox13.BackColor = ybc
            TextBox13.ForeColor = Color.Black
        End If
        If TextBox14.Text = "23:59:59" And TextBox14.ReadOnly = True Then
            ybc = TextBox14.BackColor
            TextBox14.BackColor = ybc
            TextBox14.ForeColor = ybc
        Else
            ybc = TextBox14.BackColor
            TextBox14.BackColor = ybc
            TextBox14.ForeColor = Color.Black
        End If
        If TextBox15.Text = "23:59:59" And TextBox15.ReadOnly = True Then
            ybc = TextBox15.BackColor
            TextBox15.BackColor = ybc
            TextBox15.ForeColor = ybc
        Else
            ybc = TextBox15.BackColor
            TextBox15.BackColor = ybc
            TextBox15.ForeColor = Color.Black
        End If
        If TextBox16.Text = "23:59:59" And TextBox16.ReadOnly = True Then
            ybc = TextBox16.BackColor
            TextBox16.BackColor = ybc
            TextBox16.ForeColor = ybc
        Else
            ybc = TextBox16.BackColor
            TextBox16.BackColor = ybc
            TextBox16.ForeColor = Color.Black
        End If
        If TextBox17.Text = "23:59:59" And TextBox17.ReadOnly = True Then
            ybc = TextBox17.BackColor
            TextBox17.BackColor = ybc
            TextBox17.ForeColor = ybc
        Else
            ybc = TextBox17.BackColor
            TextBox17.BackColor = ybc
            TextBox17.ForeColor = Color.Black
        End If
        If TextBox18.Text = "23:59:59" And TextBox18.ReadOnly = True Then
            ybc = TextBox18.BackColor
            TextBox18.BackColor = ybc
            TextBox18.ForeColor = ybc
        Else
            ybc = TextBox18.BackColor
            TextBox18.BackColor = ybc
            TextBox18.ForeColor = Color.Black
        End If
        If TextBox19.Text = "23:59:59" And TextBox19.ReadOnly = True Then
            ybc = TextBox19.BackColor
            TextBox19.BackColor = ybc
            TextBox19.ForeColor = ybc
        Else
            ybc = TextBox19.BackColor
            TextBox19.BackColor = ybc
            TextBox19.ForeColor = Color.Black
        End If
        If TextBox20.Text = "23:59:59" And TextBox20.ReadOnly = True Then
            ybc = TextBox20.BackColor
            TextBox20.BackColor = ybc
            TextBox20.ForeColor = ybc
        Else
            ybc = TextBox20.BackColor
            TextBox20.BackColor = ybc
            TextBox20.ForeColor = Color.Black
        End If
        If TextBox21.Text = "23:59:59" And TextBox21.ReadOnly = True Then
            ybc = TextBox21.BackColor
            TextBox21.BackColor = ybc
            TextBox21.ForeColor = ybc
        Else
            ybc = TextBox21.BackColor
            TextBox21.BackColor = ybc
            TextBox21.ForeColor = Color.Black
        End If
        If TextBox22.Text = "23:59:59" And TextBox22.ReadOnly = True Then
            ybc = TextBox22.BackColor
            TextBox22.BackColor = ybc
            TextBox22.ForeColor = ybc
        Else
            ybc = TextBox22.BackColor
            TextBox22.BackColor = ybc
            TextBox22.ForeColor = Color.Black
        End If
        If TextBox23.Text = "23:59:59" And TextBox23.ReadOnly = True Then
            ybc = TextBox23.BackColor
            TextBox23.BackColor = ybc
            TextBox23.ForeColor = ybc
        Else
            ybc = TextBox23.BackColor
            TextBox23.BackColor = ybc
            TextBox23.ForeColor = Color.Black
        End If
        If TextBox24.Text = "23:59:59" And TextBox24.ReadOnly = True Then
            ybc = TextBox24.BackColor
            TextBox24.BackColor = ybc
            TextBox24.ForeColor = ybc
        Else
            ybc = TextBox24.BackColor
            TextBox24.BackColor = ybc
            TextBox24.ForeColor = Color.Black
        End If
        If TextBox25.Text = "23:59:59" And TextBox25.ReadOnly = True Then
            ybc = TextBox25.BackColor
            TextBox25.BackColor = ybc
            TextBox25.ForeColor = ybc
        Else
            ybc = TextBox25.BackColor
            TextBox25.BackColor = ybc
            TextBox25.ForeColor = Color.Black
        End If
        If TextBox26.Text = "23:59:59" And TextBox26.ReadOnly = True Then
            ybc = TextBox26.BackColor
            TextBox26.BackColor = ybc
            TextBox26.ForeColor = ybc
        Else
            ybc = TextBox26.BackColor
            TextBox26.BackColor = ybc
            TextBox26.ForeColor = Color.Black
        End If
        If TextBox27.Text = "23:59:59" And TextBox27.ReadOnly = True Then
            ybc = TextBox27.BackColor
            TextBox27.BackColor = ybc
            TextBox27.ForeColor = ybc
        Else
            ybc = TextBox27.BackColor
            TextBox27.BackColor = ybc
            TextBox27.ForeColor = Color.Black
        End If
        If TextBox28.Text = "23:59:59" And TextBox28.ReadOnly = True Then
            ybc = TextBox28.BackColor
            TextBox28.BackColor = ybc
            TextBox28.ForeColor = ybc
        Else
            ybc = TextBox28.BackColor
            TextBox28.BackColor = ybc
            TextBox28.ForeColor = Color.Black
        End If
        If TextBox29.Text = "23:59:59" And TextBox29.ReadOnly = True Then
            ybc = TextBox29.BackColor
            TextBox29.BackColor = ybc
            TextBox29.ForeColor = ybc
        Else
            ybc = TextBox29.BackColor
            TextBox29.BackColor = ybc
            TextBox29.ForeColor = Color.Black
        End If
        If TextBox30.Text = "23:59:59" And TextBox30.ReadOnly = True Then
            ybc = TextBox30.BackColor
            TextBox30.BackColor = ybc
            TextBox30.ForeColor = ybc
        Else
            ybc = TextBox30.BackColor
            TextBox30.BackColor = ybc
            TextBox30.ForeColor = Color.Black
        End If
        If TextBox31.Text = "23:59:59" And TextBox31.ReadOnly = True Then
            ybc = TextBox31.BackColor
            TextBox31.BackColor = ybc
            TextBox31.ForeColor = ybc
        Else
            ybc = TextBox31.BackColor
            TextBox31.BackColor = ybc
            TextBox31.ForeColor = Color.Black
        End If
        If TextBox32.Text = "23:59:59" And TextBox32.ReadOnly = True Then
            ybc = TextBox32.BackColor
            TextBox32.BackColor = ybc
            TextBox32.ForeColor = ybc
        Else
            ybc = TextBox32.BackColor
            TextBox32.BackColor = ybc
            TextBox32.ForeColor = Color.Black
        End If
        If TextBox33.Text = "23:59:59" And TextBox33.ReadOnly = True Then
            ybc = TextBox33.BackColor
            TextBox33.BackColor = ybc
            TextBox33.ForeColor = ybc
        Else
            ybc = TextBox33.BackColor
            TextBox33.BackColor = ybc
            TextBox33.ForeColor = Color.Black
        End If
        If TextBox34.Text = "23:59:59" And TextBox34.ReadOnly = True Then
            ybc = TextBox34.BackColor
            TextBox34.BackColor = ybc
            TextBox34.ForeColor = ybc
        Else
            ybc = TextBox34.BackColor
            TextBox34.BackColor = ybc
            TextBox34.ForeColor = Color.Black
        End If
        If TextBox35.Text = "23:59:59" And TextBox35.ReadOnly = True Then
            ybc = TextBox35.BackColor
            TextBox35.BackColor = ybc
            TextBox35.ForeColor = ybc
        Else
            ybc = TextBox35.BackColor
            TextBox35.BackColor = ybc
            TextBox35.ForeColor = Color.Black
        End If
        If TextBox36.Text = "23:59:59" And TextBox36.ReadOnly = True Then
            ybc = TextBox36.BackColor
            TextBox36.BackColor = ybc
            TextBox36.ForeColor = ybc
        Else
            ybc = TextBox36.BackColor
            TextBox36.BackColor = ybc
            TextBox36.ForeColor = Color.Black
        End If
        If TextBox37.Text = "23:59:59" And TextBox37.ReadOnly = True Then
            ybc = TextBox37.BackColor
            TextBox37.BackColor = ybc
            TextBox37.ForeColor = ybc
        Else
            ybc = TextBox37.BackColor
            TextBox37.BackColor = ybc
            TextBox37.ForeColor = Color.Black
        End If
        If TextBox38.Text = "23:59:59" And TextBox38.ReadOnly = True Then
            ybc = TextBox38.BackColor
            TextBox38.BackColor = ybc
            TextBox38.ForeColor = ybc
        Else
            ybc = TextBox38.BackColor
            TextBox38.BackColor = ybc
            TextBox38.ForeColor = Color.Black
        End If
        If TextBox39.Text = "23:59:59" And TextBox39.ReadOnly = True Then
            ybc = TextBox39.BackColor
            TextBox39.BackColor = ybc
            TextBox39.ForeColor = ybc
        Else
            ybc = TextBox39.BackColor
            TextBox39.BackColor = ybc
            TextBox39.ForeColor = Color.Black
        End If
        If TextBox40.Text = "23:59:59" And TextBox40.ReadOnly = True Then
            ybc = TextBox40.BackColor
            TextBox40.BackColor = ybc
            TextBox40.ForeColor = ybc
        Else
            ybc = TextBox40.BackColor
            TextBox40.BackColor = ybc
            TextBox40.ForeColor = Color.Black
        End If
        If TextBox41.Text = "23:59:59" And TextBox41.ReadOnly = True Then
            ybc = TextBox41.BackColor
            TextBox41.BackColor = ybc
            TextBox41.ForeColor = ybc
        Else
            ybc = TextBox41.BackColor
            TextBox41.BackColor = ybc
            TextBox41.ForeColor = Color.Black
        End If
        If TextBox42.Text = "23:59:59" And TextBox42.ReadOnly = True Then
            ybc = TextBox42.BackColor
            TextBox42.BackColor = ybc
            TextBox42.ForeColor = ybc
        Else
            ybc = TextBox42.BackColor
            TextBox42.BackColor = ybc
            TextBox42.ForeColor = Color.Black
        End If
        If TextBox43.Text = "23:59:59" And TextBox43.ReadOnly = True Then
            ybc = TextBox43.BackColor
            TextBox43.BackColor = ybc
            TextBox43.ForeColor = ybc
        Else
            ybc = TextBox43.BackColor
            TextBox43.BackColor = ybc
            TextBox43.ForeColor = Color.Black
        End If
        If TextBox44.Text = "23:59:59" And TextBox44.ReadOnly = True Then
            ybc = TextBox44.BackColor
            TextBox44.BackColor = ybc
            TextBox44.ForeColor = ybc
        Else
            ybc = TextBox44.BackColor
            TextBox44.BackColor = ybc
            TextBox44.ForeColor = Color.Black
        End If
        If TextBox45.Text = "23:59:59" And TextBox45.ReadOnly = True Then
            ybc = TextBox45.BackColor
            TextBox45.BackColor = ybc
            TextBox45.ForeColor = ybc
        Else
            ybc = TextBox45.BackColor
            TextBox45.BackColor = ybc
            TextBox45.ForeColor = Color.Black
        End If
        If TextBox46.Text = "23:59:59" And TextBox46.ReadOnly = True Then
            ybc = TextBox46.BackColor
            TextBox46.BackColor = ybc
            TextBox46.ForeColor = ybc
        Else
            ybc = TextBox46.BackColor
            TextBox46.BackColor = ybc
            TextBox46.ForeColor = Color.Black
        End If
        If TextBox47.Text = "23:59:59" And TextBox47.ReadOnly = True Then
            ybc = TextBox47.BackColor
            TextBox47.BackColor = ybc
            TextBox47.ForeColor = ybc
        Else
            ybc = TextBox47.BackColor
            TextBox47.BackColor = ybc
            TextBox47.ForeColor = Color.Black
        End If
        If TextBox48.Text = "23:59:59" And TextBox48.ReadOnly = True Then
            ybc = TextBox48.BackColor
            TextBox48.BackColor = ybc
            TextBox48.ForeColor = ybc
        Else
            ybc = TextBox48.BackColor
            TextBox48.BackColor = ybc
            TextBox48.ForeColor = Color.Black
        End If
        If TextBox49.Text = "23:59:59" And TextBox49.ReadOnly = True Then
            ybc = TextBox49.BackColor
            TextBox49.BackColor = ybc
            TextBox49.ForeColor = ybc
        Else
            ybc = TextBox49.BackColor
            TextBox49.BackColor = ybc
            TextBox49.ForeColor = Color.Black
        End If
        If TextBox50.Text = "23:59:59" And TextBox50.ReadOnly = True Then
            ybc = TextBox50.BackColor
            TextBox50.BackColor = ybc
            TextBox50.ForeColor = ybc
        Else
            ybc = TextBox50.BackColor
            TextBox50.BackColor = ybc
            TextBox50.ForeColor = Color.Black
        End If
        If TextBox51.Text = "23:59:59" And TextBox51.ReadOnly = True Then
            ybc = TextBox51.BackColor
            TextBox51.BackColor = ybc
            TextBox51.ForeColor = ybc
        Else
            ybc = TextBox51.BackColor
            TextBox51.BackColor = ybc
            TextBox51.ForeColor = Color.Black
        End If
        If TextBox52.Text = "23:59:59" And TextBox52.ReadOnly = True Then
            ybc = TextBox52.BackColor
            TextBox52.BackColor = ybc
            TextBox52.ForeColor = ybc
        Else
            ybc = TextBox52.BackColor
            TextBox52.BackColor = ybc
            TextBox52.ForeColor = Color.Black
        End If
        If TextBox53.Text = "23:59:59" And TextBox53.ReadOnly = True Then
            ybc = TextBox53.BackColor
            TextBox53.BackColor = ybc
            TextBox53.ForeColor = ybc
        Else
            ybc = TextBox53.BackColor
            TextBox53.BackColor = ybc
            TextBox53.ForeColor = Color.Black
        End If
        If TextBox54.Text = "23:59:59" And TextBox54.ReadOnly = True Then
            ybc = TextBox54.BackColor
            TextBox54.BackColor = ybc
            TextBox54.ForeColor = ybc
        Else
            ybc = TextBox54.BackColor
            TextBox54.BackColor = ybc
            TextBox54.ForeColor = Color.Black
        End If
        If TextBox55.Text = "23:59:59" And TextBox55.ReadOnly = True Then
            ybc = TextBox55.BackColor
            TextBox55.BackColor = ybc
            TextBox55.ForeColor = ybc
        Else
            ybc = TextBox55.BackColor
            TextBox55.BackColor = ybc
            TextBox55.ForeColor = Color.Black
        End If
        If TextBox56.Text = "23:59:59" And TextBox56.ReadOnly = True Then
            ybc = TextBox56.BackColor
            TextBox56.BackColor = ybc
            TextBox56.ForeColor = ybc
        Else
            ybc = TextBox56.BackColor
            TextBox56.BackColor = ybc
            TextBox56.ForeColor = Color.Black
        End If
        If TextBox57.Text = "23:59:59" And TextBox57.ReadOnly = True Then
            ybc = TextBox57.BackColor
            TextBox57.BackColor = ybc
            TextBox57.ForeColor = ybc
        Else
            ybc = TextBox57.BackColor
            TextBox57.BackColor = ybc
            TextBox57.ForeColor = Color.Black
        End If
        If TextBox58.Text = "23:59:59" And TextBox58.ReadOnly = True Then
            ybc = TextBox58.BackColor
            TextBox58.BackColor = ybc
            TextBox58.ForeColor = ybc
        Else
            ybc = TextBox58.BackColor
            TextBox58.BackColor = ybc
            TextBox58.ForeColor = Color.Black
        End If
        If TextBox59.Text = "23:59:59" And TextBox59.ReadOnly = True Then
            ybc = TextBox59.BackColor
            TextBox59.BackColor = ybc
            TextBox59.ForeColor = ybc
        Else
            ybc = TextBox59.BackColor
            TextBox59.BackColor = ybc
            TextBox59.ForeColor = Color.Black
        End If
        If TextBox60.Text = "23:59:59" And TextBox60.ReadOnly = True Then
            ybc = TextBox60.BackColor
            TextBox60.BackColor = ybc
            TextBox60.ForeColor = ybc
        Else
            ybc = TextBox60.BackColor
            TextBox60.BackColor = ybc
            TextBox60.ForeColor = Color.Black
        End If
    End Sub

    Private Sub TextBox_TextChanged(sender As Object, e As EventArgs)
        bc = False
    End Sub
    Private Sub RadioButton1_Click(sender As Object, e As EventArgs) Handles RadioButton1.Click
        If RadioButton1.Checked = True And RadioButton1.Enabled = True Then
            If bc = False Then
                rq = MsgBox("您刚才做的时间表更改将丢失" & vbCrLf & "是否不保存更改并切换时间表?", vbOKCancel + vbQuestion, "时间表编辑器")
                If rq = 1 Then
                    xbox = 1
                    ds = "1"
                    jzsjb()
                Else
                    RadioButton1.Checked = False
                    RadioButton2.Checked = True
                End If
            Else
                xbox = 1
                ds = "1"
                jzsjb()
            End If
        End If
    End Sub

    Private Sub RadioButton2_Click(sender As Object, e As EventArgs) Handles RadioButton2.Click
        If RadioButton2.Checked = True And RadioButton2.Enabled = True Then
            If bc = False Then
                rq = MsgBox("您刚才做的时间表更改将丢失" & vbCrLf & "是否不保存更改并切换时间表?", vbOKCancel + vbQuestion, "时间表编辑器")
                If rq = 1 Then
                    xbox = 1
                    ds = "2"
                    jzsjb()
                Else
                    RadioButton1.Checked = True
                    RadioButton2.Checked = False
                End If
            Else
                xbox = 1
                ds = "2"
                jzsjb()
            End If
        End If
    End Sub

    Public Function zxtime(s$) As String
        Dim timelist As String
        timelist = My.Computer.FileSystem.ReadAllText("data\cl" & ds & "\timelist.txt")
        If Len(s) = 4 Then
            zxtime = Trim(Mid(timelist, InStr(timelist, CStr(s)) + 4, 9))
        Else
            zxtime = Trim(Mid(timelist, InStr(timelist, CStr(s)) + 5, 9))
        End If
    End Function

    Public Function alldclass(s$, z%) As String
        Dim classlist As String
        classlist = My.Computer.FileSystem.ReadAllText("data\cl" & ds & "\z" & z & ".txt")
        If Len(s) = 2 Then
            alldclass = Trim(Mid(classlist, InStr(classlist, CStr(s)) + 2, 3))
        Else
            alldclass = Trim(Mid(classlist, InStr(classlist, CStr(s)) + 3, 3))
        End If
    End Function

    Private Sub Inputkey(tbox As Integer, key As String)
        If Not key = "bks" Then
            If tbox = 1 And TextBox1.ReadOnly = False Then
                TextBox1.Text = TextBox1.Text & key
            ElseIf tbox = 2 And TextBox2.ReadOnly = False Then
                TextBox2.Text = TextBox2.Text & key
            ElseIf tbox = 3 And TextBox3.ReadOnly = False Then
                TextBox3.Text = TextBox3.Text & key
            ElseIf tbox = 4 And TextBox4.ReadOnly = False Then
                TextBox4.Text = TextBox4.Text & key
            ElseIf tbox = 5 And TextBox5.ReadOnly = False Then
                TextBox5.Text = TextBox5.Text & key
            ElseIf tbox = 6 And TextBox6.ReadOnly = False Then
                TextBox6.Text = TextBox6.Text & key
            ElseIf tbox = 7 And TextBox7.ReadOnly = False Then
                TextBox7.Text = TextBox7.Text & key
            ElseIf tbox = 8 And TextBox8.ReadOnly = False Then
                TextBox8.Text = TextBox8.Text & key
            ElseIf tbox = 9 And TextBox9.ReadOnly = False Then
                TextBox9.Text = TextBox9.Text & key
            ElseIf tbox = 10 And TextBox10.ReadOnly = False Then
                TextBox10.Text = TextBox10.Text & key
            ElseIf tbox = 11 And TextBox11.ReadOnly = False Then
                TextBox11.Text = TextBox11.Text & key
            ElseIf tbox = 12 And TextBox12.ReadOnly = False Then
                TextBox12.Text = TextBox12.Text & key
            ElseIf tbox = 13 And TextBox13.ReadOnly = False Then
                TextBox13.Text = TextBox13.Text & key
            ElseIf tbox = 14 And TextBox14.ReadOnly = False Then
                TextBox14.Text = TextBox14.Text & key
            ElseIf tbox = 15 And TextBox15.ReadOnly = False Then
                TextBox15.Text = TextBox15.Text & key
            ElseIf tbox = 16 And TextBox16.ReadOnly = False Then
                TextBox16.Text = TextBox16.Text & key
            ElseIf tbox = 17 And TextBox17.ReadOnly = False Then
                TextBox17.Text = TextBox17.Text & key
            ElseIf tbox = 18 And TextBox18.ReadOnly = False Then
                TextBox18.Text = TextBox18.Text & key
            ElseIf tbox = 19 And TextBox19.ReadOnly = False Then
                TextBox19.Text = TextBox19.Text & key
            ElseIf tbox = 20 And TextBox20.ReadOnly = False Then
                TextBox20.Text = TextBox20.Text & key
            ElseIf tbox = 21 And TextBox21.ReadOnly = False Then
                TextBox21.Text = TextBox21.Text & key
            ElseIf tbox = 22 And TextBox22.ReadOnly = False Then
                TextBox22.Text = TextBox22.Text & key
            ElseIf tbox = 23 And TextBox23.ReadOnly = False Then
                TextBox23.Text = TextBox23.Text & key
            ElseIf tbox = 24 And TextBox24.ReadOnly = False Then
                TextBox24.Text = TextBox24.Text & key
            ElseIf tbox = 25 And TextBox25.ReadOnly = False Then
                TextBox25.Text = TextBox25.Text & key
            ElseIf tbox = 26 And TextBox26.ReadOnly = False Then
                TextBox26.Text = TextBox26.Text & key
            ElseIf tbox = 27 And TextBox27.ReadOnly = False Then
                TextBox27.Text = TextBox27.Text & key
            ElseIf tbox = 28 And TextBox28.ReadOnly = False Then
                TextBox28.Text = TextBox28.Text & key
            ElseIf tbox = 29 And TextBox29.ReadOnly = False Then
                TextBox29.Text = TextBox29.Text & key
            ElseIf tbox = 30 And TextBox30.ReadOnly = False Then
                TextBox30.Text = TextBox30.Text & key
            ElseIf tbox = 31 And TextBox31.ReadOnly = False Then
                TextBox31.Text = TextBox31.Text & key
            ElseIf tbox = 32 And TextBox32.ReadOnly = False Then
                TextBox32.Text = TextBox32.Text & key
            ElseIf tbox = 33 And TextBox33.ReadOnly = False Then
                TextBox33.Text = TextBox33.Text & key
            ElseIf tbox = 34 And TextBox34.ReadOnly = False Then
                TextBox34.Text = TextBox34.Text & key
            ElseIf tbox = 35 And TextBox35.ReadOnly = False Then
                TextBox35.Text = TextBox35.Text & key
            ElseIf tbox = 36 And TextBox36.ReadOnly = False Then
                TextBox36.Text = TextBox36.Text & key
            ElseIf tbox = 37 And TextBox37.ReadOnly = False Then
                TextBox37.Text = TextBox37.Text & key
            ElseIf tbox = 38 And TextBox38.ReadOnly = False Then
                TextBox38.Text = TextBox38.Text & key
            ElseIf tbox = 39 And TextBox39.ReadOnly = False Then
                TextBox39.Text = TextBox39.Text & key
            ElseIf tbox = 40 And TextBox40.ReadOnly = False Then
                TextBox40.Text = TextBox40.Text & key
            ElseIf tbox = 41 And TextBox41.ReadOnly = False Then
                TextBox41.Text = TextBox41.Text & key
            ElseIf tbox = 42 And TextBox42.ReadOnly = False Then
                TextBox42.Text = TextBox42.Text & key
            ElseIf tbox = 43 And TextBox43.ReadOnly = False Then
                TextBox43.Text = TextBox43.Text & key
            ElseIf tbox = 44 And TextBox44.ReadOnly = False Then
                TextBox44.Text = TextBox44.Text & key
            ElseIf tbox = 45 And TextBox45.ReadOnly = False Then
                TextBox45.Text = TextBox45.Text & key
            ElseIf tbox = 46 And TextBox46.ReadOnly = False Then
                TextBox46.Text = TextBox46.Text & key
            ElseIf tbox = 47 And TextBox47.ReadOnly = False Then
                TextBox47.Text = TextBox47.Text & key
            ElseIf tbox = 48 And TextBox48.ReadOnly = False Then
                TextBox48.Text = TextBox48.Text & key
            ElseIf tbox = 49 And TextBox49.ReadOnly = False Then
                TextBox49.Text = TextBox49.Text & key
            ElseIf tbox = 50 And TextBox50.ReadOnly = False Then
                TextBox50.Text = TextBox50.Text & key
            ElseIf tbox = 51 And TextBox51.ReadOnly = False Then
                TextBox51.Text = TextBox51.Text & key
            ElseIf tbox = 52 And TextBox52.ReadOnly = False Then
                TextBox52.Text = TextBox52.Text & key
            ElseIf tbox = 53 And TextBox53.ReadOnly = False Then
                TextBox53.Text = TextBox53.Text & key
            ElseIf tbox = 54 And TextBox54.ReadOnly = False Then
                TextBox54.Text = TextBox54.Text & key
            ElseIf tbox = 55 And TextBox55.ReadOnly = False Then
                TextBox55.Text = TextBox55.Text & key
            ElseIf tbox = 56 And TextBox56.ReadOnly = False Then
                TextBox56.Text = TextBox56.Text & key
            ElseIf tbox = 57 And TextBox57.ReadOnly = False Then
                TextBox57.Text = TextBox57.Text & key
            ElseIf tbox = 58 And TextBox58.ReadOnly = False Then
                TextBox58.Text = TextBox58.Text & key
            ElseIf tbox = 59 And TextBox59.ReadOnly = False Then
                TextBox59.Text = TextBox59.Text & key
            ElseIf tbox = 60 And TextBox60.ReadOnly = False Then
                TextBox60.Text = TextBox60.Text & key
            End If
        Else
            If tbox = 1 And TextBox1.ReadOnly = False Then
                If Not TextBox1.Text = "" Then
                    TextBox1.Text = Microsoft.VisualBasic.Left(TextBox1.Text, Len(TextBox1.Text) - 1)
                End If
            ElseIf tbox = 2 And TextBox2.ReadOnly = False Then
                If Not TextBox2.Text = "" Then
                    TextBox2.Text = Microsoft.VisualBasic.Left(TextBox2.Text, Len(TextBox2.Text) - 1)
                End If
            ElseIf tbox = 3 And TextBox3.ReadOnly = False Then
                If Not TextBox3.Text = "" Then
                    TextBox3.Text = Microsoft.VisualBasic.Left(TextBox3.Text, Len(TextBox3.Text) - 1)
                End If
            ElseIf tbox = 4 And TextBox4.ReadOnly = False Then
                If Not TextBox4.Text = "" Then
                    TextBox4.Text = Microsoft.VisualBasic.Left(TextBox4.Text, Len(TextBox4.Text) - 1)
                End If
            ElseIf tbox = 5 And TextBox5.ReadOnly = False Then
                If Not TextBox5.Text = "" Then
                    TextBox5.Text = Microsoft.VisualBasic.Left(TextBox5.Text, Len(TextBox5.Text) - 1)
                End If
            ElseIf tbox = 6 And TextBox6.ReadOnly = False Then
                If Not TextBox6.Text = "" Then
                    TextBox6.Text = Microsoft.VisualBasic.Left(TextBox6.Text, Len(TextBox6.Text) - 1)
                End If
            ElseIf tbox = 7 And TextBox7.ReadOnly = False Then
                If Not TextBox7.Text = "" Then
                    TextBox7.Text = Microsoft.VisualBasic.Left(TextBox7.Text, Len(TextBox7.Text) - 1)
                End If
            ElseIf tbox = 8 And TextBox8.ReadOnly = False Then
                If Not TextBox8.Text = "" Then
                    TextBox8.Text = Microsoft.VisualBasic.Left(TextBox8.Text, Len(TextBox8.Text) - 1)
                End If
            ElseIf tbox = 9 And TextBox9.ReadOnly = False Then
                If Not TextBox9.Text = "" Then
                    TextBox9.Text = Microsoft.VisualBasic.Left(TextBox9.Text, Len(TextBox9.Text) - 1)
                End If
            ElseIf tbox = 10 And TextBox10.ReadOnly = False Then
                If Not TextBox10.Text = "" Then
                    TextBox10.Text = Microsoft.VisualBasic.Left(TextBox10.Text, Len(TextBox10.Text) - 1)
                End If
            ElseIf tbox = 11 And TextBox11.ReadOnly = False Then
                If Not TextBox11.Text = "" Then
                    TextBox11.Text = Microsoft.VisualBasic.Left(TextBox11.Text, Len(TextBox11.Text) - 1)
                End If
            ElseIf tbox = 12 And TextBox12.ReadOnly = False Then
                If Not TextBox12.Text = "" Then
                    TextBox12.Text = Microsoft.VisualBasic.Left(TextBox12.Text, Len(TextBox12.Text) - 1)
                End If
            ElseIf tbox = 13 And TextBox13.ReadOnly = False Then
                If Not TextBox13.Text = "" Then
                    TextBox13.Text = Microsoft.VisualBasic.Left(TextBox13.Text, Len(TextBox13.Text) - 1)
                End If
            ElseIf tbox = 14 And TextBox14.ReadOnly = False Then
                If Not TextBox14.Text = "" Then
                    TextBox14.Text = Microsoft.VisualBasic.Left(TextBox14.Text, Len(TextBox14.Text) - 1)
                End If
            ElseIf tbox = 15 And TextBox15.ReadOnly = False Then
                If Not TextBox15.Text = "" Then
                    TextBox15.Text = Microsoft.VisualBasic.Left(TextBox15.Text, Len(TextBox15.Text) - 1)
                End If
            ElseIf tbox = 16 And TextBox16.ReadOnly = False Then
                If Not TextBox16.Text = "" Then
                    TextBox16.Text = Microsoft.VisualBasic.Left(TextBox16.Text, Len(TextBox16.Text) - 1)
                End If
            ElseIf tbox = 17 And TextBox17.ReadOnly = False Then
                If Not TextBox17.Text = "" Then
                    TextBox17.Text = Microsoft.VisualBasic.Left(TextBox17.Text, Len(TextBox17.Text) - 1)
                End If
            ElseIf tbox = 18 And TextBox18.ReadOnly = False Then
                If Not TextBox18.Text = "" Then
                    TextBox18.Text = Microsoft.VisualBasic.Left(TextBox18.Text, Len(TextBox18.Text) - 1)
                End If
            ElseIf tbox = 19 And TextBox19.ReadOnly = False Then
                If Not TextBox19.Text = "" Then
                    TextBox19.Text = Microsoft.VisualBasic.Left(TextBox19.Text, Len(TextBox19.Text) - 1)
                End If
            ElseIf tbox = 20 And TextBox20.ReadOnly = False Then
                If Not TextBox20.Text = "" Then
                    TextBox20.Text = Microsoft.VisualBasic.Left(TextBox20.Text, Len(TextBox20.Text) - 1)
                End If
            ElseIf tbox = 21 And TextBox21.ReadOnly = False Then
                If Not TextBox21.Text = "" Then
                    TextBox21.Text = Microsoft.VisualBasic.Left(TextBox21.Text, Len(TextBox21.Text) - 1)
                End If
            ElseIf tbox = 22 And TextBox22.ReadOnly = False Then
                If Not TextBox22.Text = "" Then
                    TextBox22.Text = Microsoft.VisualBasic.Left(TextBox22.Text, Len(TextBox22.Text) - 1)
                End If
            ElseIf tbox = 23 And TextBox23.ReadOnly = False Then
                If Not TextBox23.Text = "" Then
                    TextBox23.Text = Microsoft.VisualBasic.Left(TextBox23.Text, Len(TextBox23.Text) - 1)
                End If
            ElseIf tbox = 24 And TextBox24.ReadOnly = False Then
                If Not TextBox24.Text = "" Then
                    TextBox24.Text = Microsoft.VisualBasic.Left(TextBox24.Text, Len(TextBox24.Text) - 1)
                End If
            ElseIf tbox = 25 And TextBox25.ReadOnly = False Then
                If Not TextBox25.Text = "" Then
                    TextBox25.Text = Microsoft.VisualBasic.Left(TextBox25.Text, Len(TextBox25.Text) - 1)
                End If
            ElseIf tbox = 26 And TextBox26.ReadOnly = False Then
                If Not TextBox26.Text = "" Then
                    TextBox26.Text = Microsoft.VisualBasic.Left(TextBox26.Text, Len(TextBox26.Text) - 1)
                End If
            ElseIf tbox = 27 And TextBox27.ReadOnly = False Then
                If Not TextBox27.Text = "" Then
                    TextBox27.Text = Microsoft.VisualBasic.Left(TextBox27.Text, Len(TextBox27.Text) - 1)
                End If
            ElseIf tbox = 28 And TextBox28.ReadOnly = False Then
                If Not TextBox28.Text = "" Then
                    TextBox28.Text = Microsoft.VisualBasic.Left(TextBox28.Text, Len(TextBox28.Text) - 1)
                End If
            ElseIf tbox = 29 And TextBox29.ReadOnly = False Then
                If Not TextBox29.Text = "" Then
                    TextBox29.Text = Microsoft.VisualBasic.Left(TextBox29.Text, Len(TextBox29.Text) - 1)
                End If
            ElseIf tbox = 30 And TextBox30.ReadOnly = False Then
                If Not TextBox30.Text = "" Then
                    TextBox30.Text = Microsoft.VisualBasic.Left(TextBox30.Text, Len(TextBox30.Text) - 1)
                End If
            ElseIf tbox = 31 And TextBox31.ReadOnly = False Then
                If Not TextBox31.Text = "" Then
                    TextBox31.Text = Microsoft.VisualBasic.Left(TextBox31.Text, Len(TextBox31.Text) - 1)
                End If
            ElseIf tbox = 32 And TextBox32.ReadOnly = False Then
                If Not TextBox32.Text = "" Then
                    TextBox32.Text = Microsoft.VisualBasic.Left(TextBox32.Text, Len(TextBox32.Text) - 1)
                End If
            ElseIf tbox = 33 And TextBox33.ReadOnly = False Then
                If Not TextBox33.Text = "" Then
                    TextBox33.Text = Microsoft.VisualBasic.Left(TextBox33.Text, Len(TextBox33.Text) - 1)
                End If
            ElseIf tbox = 34 And TextBox34.ReadOnly = False Then
                If Not TextBox34.Text = "" Then
                    TextBox34.Text = Microsoft.VisualBasic.Left(TextBox34.Text, Len(TextBox34.Text) - 1)
                End If
            ElseIf tbox = 35 And TextBox35.ReadOnly = False Then
                If Not TextBox35.Text = "" Then
                    TextBox35.Text = Microsoft.VisualBasic.Left(TextBox35.Text, Len(TextBox35.Text) - 1)
                End If
            ElseIf tbox = 36 And TextBox36.ReadOnly = False Then
                If Not TextBox36.Text = "" Then
                    TextBox36.Text = Microsoft.VisualBasic.Left(TextBox36.Text, Len(TextBox36.Text) - 1)
                End If
            ElseIf tbox = 37 And TextBox37.ReadOnly = False Then
                If Not TextBox37.Text = "" Then
                    TextBox37.Text = Microsoft.VisualBasic.Left(TextBox37.Text, Len(TextBox37.Text) - 1)
                End If
            ElseIf tbox = 38 And TextBox38.ReadOnly = False Then
                If Not TextBox38.Text = "" Then
                    TextBox38.Text = Microsoft.VisualBasic.Left(TextBox38.Text, Len(TextBox38.Text) - 1)
                End If
            ElseIf tbox = 39 And TextBox39.ReadOnly = False Then
                If Not TextBox39.Text = "" Then
                    TextBox39.Text = Microsoft.VisualBasic.Left(TextBox39.Text, Len(TextBox39.Text) - 1)
                End If
            ElseIf tbox = 40 And TextBox40.ReadOnly = False Then
                If Not TextBox40.Text = "" Then
                    TextBox40.Text = Microsoft.VisualBasic.Left(TextBox40.Text, Len(TextBox40.Text) - 1)
                End If
            ElseIf tbox = 41 And TextBox41.ReadOnly = False Then
                If Not TextBox41.Text = "" Then
                    TextBox41.Text = Microsoft.VisualBasic.Left(TextBox41.Text, Len(TextBox41.Text) - 1)
                End If
            ElseIf tbox = 42 And TextBox42.ReadOnly = False Then
                If Not TextBox42.Text = "" Then
                    TextBox42.Text = Microsoft.VisualBasic.Left(TextBox42.Text, Len(TextBox42.Text) - 1)
                End If
            ElseIf tbox = 43 And TextBox43.ReadOnly = False Then
                If Not TextBox43.Text = "" Then
                    TextBox43.Text = Microsoft.VisualBasic.Left(TextBox43.Text, Len(TextBox43.Text) - 1)
                End If
            ElseIf tbox = 44 And TextBox44.ReadOnly = False Then
                If Not TextBox44.Text = "" Then
                    TextBox44.Text = Microsoft.VisualBasic.Left(TextBox44.Text, Len(TextBox44.Text) - 1)
                End If
            ElseIf tbox = 45 And TextBox45.ReadOnly = False Then
                If Not TextBox45.Text = "" Then
                    TextBox45.Text = Microsoft.VisualBasic.Left(TextBox45.Text, Len(TextBox45.Text) - 1)
                End If
            ElseIf tbox = 46 And TextBox46.ReadOnly = False Then
                If Not TextBox46.Text = "" Then
                    TextBox46.Text = Microsoft.VisualBasic.Left(TextBox46.Text, Len(TextBox46.Text) - 1)
                End If
            ElseIf tbox = 47 And TextBox47.ReadOnly = False Then
                If Not TextBox47.Text = "" Then
                    TextBox47.Text = Microsoft.VisualBasic.Left(TextBox47.Text, Len(TextBox47.Text) - 1)
                End If
            ElseIf tbox = 48 And TextBox48.ReadOnly = False Then
                If Not TextBox48.Text = "" Then
                    TextBox48.Text = Microsoft.VisualBasic.Left(TextBox48.Text, Len(TextBox48.Text) - 1)
                End If
            ElseIf tbox = 49 And TextBox49.ReadOnly = False Then
                If Not TextBox49.Text = "" Then
                    TextBox49.Text = Microsoft.VisualBasic.Left(TextBox49.Text, Len(TextBox49.Text) - 1)
                End If
            ElseIf tbox = 50 And TextBox50.ReadOnly = False Then
                If Not TextBox50.Text = "" Then
                    TextBox50.Text = Microsoft.VisualBasic.Left(TextBox50.Text, Len(TextBox50.Text) - 1)
                End If
            ElseIf tbox = 51 And TextBox51.ReadOnly = False Then
                If Not TextBox51.Text = "" Then
                    TextBox51.Text = Microsoft.VisualBasic.Left(TextBox51.Text, Len(TextBox51.Text) - 1)
                End If
            ElseIf tbox = 52 And TextBox52.ReadOnly = False Then
                If Not TextBox52.Text = "" Then
                    TextBox52.Text = Microsoft.VisualBasic.Left(TextBox52.Text, Len(TextBox52.Text) - 1)
                End If
            ElseIf tbox = 53 And TextBox53.ReadOnly = False Then
                If Not TextBox53.Text = "" Then
                    TextBox53.Text = Microsoft.VisualBasic.Left(TextBox53.Text, Len(TextBox53.Text) - 1)
                End If
            ElseIf tbox = 54 And TextBox54.ReadOnly = False Then
                If Not TextBox54.Text = "" Then
                    TextBox54.Text = Microsoft.VisualBasic.Left(TextBox54.Text, Len(TextBox54.Text) - 1)
                End If
            ElseIf tbox = 55 And TextBox55.ReadOnly = False Then
                If Not TextBox55.Text = "" Then
                    TextBox55.Text = Microsoft.VisualBasic.Left(TextBox55.Text, Len(TextBox55.Text) - 1)
                End If
            ElseIf tbox = 56 And TextBox56.ReadOnly = False Then
                If Not TextBox56.Text = "" Then
                    TextBox56.Text = Microsoft.VisualBasic.Left(TextBox56.Text, Len(TextBox56.Text) - 1)
                End If
            ElseIf tbox = 57 And TextBox57.ReadOnly = False Then
                If Not TextBox57.Text = "" Then
                    TextBox57.Text = Microsoft.VisualBasic.Left(TextBox57.Text, Len(TextBox57.Text) - 1)
                End If
            ElseIf tbox = 58 And TextBox58.ReadOnly = False Then
                If Not TextBox58.Text = "" Then
                    TextBox58.Text = Microsoft.VisualBasic.Left(TextBox58.Text, Len(TextBox58.Text) - 1)
                End If
            ElseIf tbox = 59 And TextBox59.ReadOnly = False Then
                If Not TextBox59.Text = "" Then
                    TextBox59.Text = Microsoft.VisualBasic.Left(TextBox59.Text, Len(TextBox59.Text) - 1)
                End If
            ElseIf tbox = 60 And TextBox60.ReadOnly = False Then
                If Not TextBox60.Text = "" Then
                    TextBox60.Text = Microsoft.VisualBasic.Left(TextBox60.Text, Len(TextBox60.Text) - 1)
                End If
            End If
        End If
    End Sub

    Public Sub bcsjb()
        alltime = "  zm1s " & TextBox1.Text & "  zm1x " & TextBox16.Text & "  zm2s " & TextBox2.Text & "  zm2x " & TextBox17.Text & "  zm3s " & TextBox3.Text & "  zm3x " & TextBox18.Text & "  zm4s " & TextBox4.Text & "  zm4x " & TextBox19.Text & "  zm5s " & TextBox5.Text & "  zm5x " & TextBox20.Text & "  zm6s " & TextBox6.Text & "  zm6x " & TextBox21.Text & "  zm7s " & TextBox7.Text & "  zm7x " & TextBox22.Text & "  zm8s " & TextBox8.Text & "  zm8x " & TextBox23.Text & "  zm9s " & TextBox9.Text & "  zm9x " & TextBox24.Text & "  zm10s " & TextBox10.Text & "  zm10x " & TextBox25.Text & "  zm11s " & TextBox11.Text & "  zm11x " & TextBox26.Text & "  zm12s " & TextBox12.Text & "  zm12x " & TextBox27.Text & "  zm13s " & TextBox13.Text & "  zm13x " & TextBox28.Text & "  zm14s " & TextBox14.Text & "  zm14x " & TextBox29.Text & "  zm15s " & TextBox15.Text & "  zm15x " & TextBox30.Text & "  zt1s " & TextBox31.Text & "  zt1x " & TextBox46.Text & "  zt2s " & TextBox32.Text & "  zt2x " & TextBox47.Text & "  zt3s " & TextBox33.Text & "  zt3x " & TextBox48.Text & "  zt4s " & TextBox34.Text & "  zt4x " & TextBox49.Text & "  zt5s " & TextBox35.Text & "  zt5x " & TextBox50.Text & "  zt6s " & TextBox36.Text & "  zt6x " & TextBox51.Text & "  zt7s " & TextBox37.Text & "  zt7x " & TextBox52.Text & "  zt8s " & TextBox38.Text & "  zt8x " & TextBox53.Text & "  zt9s " & TextBox39.Text & "  zt9x " & TextBox54.Text & "  zt10s " & TextBox40.Text & "  zt10x " & TextBox55.Text & "  zt11s " & TextBox41.Text & "  zt11x " & TextBox56.Text & "  zt12s " & TextBox42.Text & "  zt12x " & TextBox57.Text & "  zt13s " & TextBox43.Text & "  zt13x " & TextBox58.Text & "  zt14s " & TextBox44.Text & "  zt14x " & TextBox59.Text & "  zt15s " & TextBox45.Text & "  zt15x " & TextBox60.Text & "  "
        If RadioButton1.Checked = True Then
            My.Computer.FileSystem.WriteAllText("data\cl1\timelist.txt", alltime, False)
            If RadioButton3.Checked = True Then
                My.Computer.FileSystem.WriteAllText("data\cl1\tss.txt", "1", False)
            ElseIf RadioButton4.Checked = True Then
                My.Computer.FileSystem.WriteAllText("data\cl1\tss.txt", "2", False)
            ElseIf RadioButton5.Checked = True Then
                My.Computer.FileSystem.WriteAllText("data\cl1\tss.txt", "3", False)
            ElseIf RadioButton6.Checked = True Then
                My.Computer.FileSystem.WriteAllText("data\cl1\tss.txt", "4", False)
            ElseIf RadioButton7.Checked = True Then
                My.Computer.FileSystem.WriteAllText("data\cl1\tss.txt", "5", False)
            ElseIf RadioButton8.Checked = True Then
                My.Computer.FileSystem.WriteAllText("data\cl1\tss.txt", "6", False)
            ElseIf RadioButton9.Checked = True Then
                My.Computer.FileSystem.WriteAllText("data\cl1\tss.txt", "7", False)
            ElseIf RadioButton10.Checked = True Then
                My.Computer.FileSystem.WriteAllText("data\cl1\tss.txt", "0", False)
            End If
        ElseIf RadioButton2.Checked = True Then
            My.Computer.FileSystem.WriteAllText("data\cl2\timelist.txt", alltime, False)
            If RadioButton3.Checked = True Then
                My.Computer.FileSystem.WriteAllText("data\cl2\tss.txt", "1", False)
            ElseIf RadioButton4.Checked = True Then
                My.Computer.FileSystem.WriteAllText("data\cl2\tss.txt", "2", False)
            ElseIf RadioButton5.Checked = True Then
                My.Computer.FileSystem.WriteAllText("data\cl2\tss.txt", "3", False)
            ElseIf RadioButton6.Checked = True Then
                My.Computer.FileSystem.WriteAllText("data\cl2\tss.txt", "4", False)
            ElseIf RadioButton7.Checked = True Then
                My.Computer.FileSystem.WriteAllText("data\cl2\tss.txt", "5", False)
            ElseIf RadioButton8.Checked = True Then
                My.Computer.FileSystem.WriteAllText("data\cl2\tss.txt", "6", False)
            ElseIf RadioButton9.Checked = True Then
                My.Computer.FileSystem.WriteAllText("data\cl2\tss.txt", "7", False)
            ElseIf RadioButton10.Checked = True Then
                My.Computer.FileSystem.WriteAllText("data\cl2\tss.txt", "0", False)
            End If
        End If
        bc = True
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

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Inputkey(xbox, "1")
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Inputkey(xbox, "2")
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Inputkey(xbox, "3")
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Inputkey(xbox, "4")
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Inputkey(xbox, "5")
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Inputkey(xbox, "6")
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Inputkey(xbox, "7")
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Inputkey(xbox, "8")
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Inputkey(xbox, "9")
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Inputkey(xbox, "0")
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Inputkey(xbox, "bks")
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        Inputkey(xbox, ":")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim emptyTextBox = Me.Controls.OfType(Of TextBox)().FirstOrDefault(Function(tb) String.IsNullOrWhiteSpace(tb.Text))
        If emptyTextBox IsNot Nothing Then
            MessageBox.Show("时间表未填写完整!", "全能班辅", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            emptyTextBox.Focus()
        Else
            bcsjb()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim emptyTextBox = Me.Controls.OfType(Of TextBox)().FirstOrDefault(Function(tb) String.IsNullOrWhiteSpace(tb.Text))
        If emptyTextBox IsNot Nothing Then
            MessageBox.Show("时间表未填写完整!", "全能班辅", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            emptyTextBox.Focus()
        Else
            bcsjb()
            Me.Close()
        End If
    End Sub

    Private Sub Form27_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If bc = False Then
            rq = MsgBox("您刚才做的时间表更改将丢失" & vbCrLf & "是否不保存更改并退出编辑器?", vbOKCancel + vbQuestion, "时间表编辑器")
            If rq = 1 Then
                e.Cancel = False
            Else
                e.Cancel = True
            End If
        Else
            e.Cancel = False
        End If
    End Sub

    Private Sub RadioButton3_Click(sender As Object, e As EventArgs) Handles RadioButton3.Click
        If RadioButton3.Checked = True And RadioButton3.Enabled = True Then
            jztssjb(1)
        End If
    End Sub

    Private Sub RadioButton4_Click(sender As Object, e As EventArgs) Handles RadioButton4.Click
        If RadioButton4.Checked = True And RadioButton4.Enabled = True Then
            jztssjb(2)
        End If
    End Sub

    Private Sub RadioButton5_Click(sender As Object, e As EventArgs) Handles RadioButton5.Click
        If RadioButton5.Checked = True And RadioButton5.Enabled = True Then
            jztssjb(3)
        End If
    End Sub

    Private Sub RadioButton6_Click(sender As Object, e As EventArgs) Handles RadioButton6.Click
        If RadioButton6.Checked = True And RadioButton6.Enabled = True Then
            jztssjb(4)
        End If
    End Sub

    Private Sub RadioButton7_Click(sender As Object, e As EventArgs) Handles RadioButton7.Click
        If RadioButton7.Checked = True And RadioButton7.Enabled = True Then
            jztssjb(5)
        End If
    End Sub

    Private Sub RadioButton8_Click(sender As Object, e As EventArgs) Handles RadioButton8.Click
        If RadioButton8.Checked = True And RadioButton8.Enabled = True Then
            jztssjb(6)
        End If
    End Sub

    Private Sub RadioButton9_Click(sender As Object, e As EventArgs) Handles RadioButton9.Click
        If RadioButton9.Checked = True And RadioButton9.Enabled = True Then
            jztssjb(7)
        End If
    End Sub

    Private Sub RadioButton10_Click(sender As Object, e As EventArgs) Handles RadioButton10.Click
        If RadioButton10.Checked = True And RadioButton10.Enabled = True Then
            jztssjb(0)
        End If
    End Sub
End Class