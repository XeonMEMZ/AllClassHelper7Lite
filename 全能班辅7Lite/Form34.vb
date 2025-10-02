Public Class Form34
    Private Sub Form34_Load(sender As Object, e As EventArgs) Handles Me.Load
        jzkb()
    End Sub

    Public Function alldclass(s$, z%) As String
        Dim classlist As String
        classlist = My.Computer.FileSystem.ReadAllText("data\cl" & CStr(dqcl) & "\z" & z & ".txt")
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
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class