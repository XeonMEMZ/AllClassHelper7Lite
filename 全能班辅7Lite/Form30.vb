Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form30
    Dim getfc As Integer

    Public Function EncryptData(txt As String)
        For i = 1 To Len(txt)
            If Asc(Mid(txt, i, 1)) + 1 = 127 Then
                EncryptData = EncryptData & Chr(32)
            Else
                EncryptData = EncryptData & Chr(Asc(Mid(txt, i, 1)) + 1)
            End If
        Next
    End Function

    Public Function DecryptData(txt As String)
        For i = 1 To Len(txt)
            If Asc(Mid(txt, i, 1)) - 1 = 31 Then
                DecryptData = DecryptData & Chr(126)
            Else
                DecryptData = DecryptData & Chr(Asc(Mid(txt, i, 1)) - 1)
            End If
        Next
    End Function

    Private Sub TextBox1_GotFocus(sender As Object, e As EventArgs) Handles TextBox1.GotFocus
        getfc = 1
    End Sub

    Private Sub TextBox2_GotFocus(sender As Object, e As EventArgs) Handles TextBox2.GotFocus
        getfc = 2
    End Sub

    Private Sub Inputkey(tbox As Integer, key As String)
        If Not key = "bks" Then
            If tbox = 1 Then
                TextBox1.Text = TextBox1.Text & key
            ElseIf tbox = 2 Then
                TextBox2.Text = TextBox2.Text & key
            End If
        Else
            If tbox = 1 Then
                If Not TextBox1.Text = "" Then
                    TextBox1.Text = Microsoft.VisualBasic.Left(TextBox1.Text, Len(TextBox1.Text) - 1)
                End If
            ElseIf tbox = 2 Then
                If Not TextBox2.Text = "" Then
                    TextBox2.Text = Microsoft.VisualBasic.Left(TextBox2.Text, Len(TextBox2.Text) - 1)
                End If
            End If
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Inputkey(getfc, "1")
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Inputkey(getfc, "2")
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Inputkey(getfc, "3")
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Inputkey(getfc, "4")
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Inputkey(getfc, "5")
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Inputkey(getfc, "6")
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Inputkey(getfc, "7")
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Inputkey(getfc, "8")
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Inputkey(getfc, "9")
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        Inputkey(getfc, ".")
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Inputkey(getfc, "0")
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Inputkey(getfc, "bks")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If DecryptData(My.Computer.FileSystem.ReadAllText("data\psw.txt")) = TextBox1.Text And TextBox1.Text <> "231144" Then
            If Not TextBox2.Text = TextBox1.Text Then
                mmzq = True
                If TextBox2.Text = "" Then
                    My.Computer.FileSystem.WriteAllText("data\psw.txt", EncryptData("231144"), False)
                    Me.Close()
                Else
                    My.Computer.FileSystem.WriteAllText("data\psw.txt", EncryptData(TextBox2.Text), False)
                    Me.Close()
                End If
            Else
                Label4.Text = "新密码不能与原密码相同，请重新输入"
                Label4.Visible = True
            End If
        Else
            If DecryptData(My.Computer.FileSystem.ReadAllText("data\psw.txt")) = "231144" And TextBox1.Text = "" Then
                If TextBox2.Text <> TextBox1.Text And TextBox2.Text <> "231144" Then
                    mmzq = True
                    If TextBox2.Text = "" Then
                        My.Computer.FileSystem.WriteAllText("data\psw.txt", EncryptData("231144"), False)
                        Me.Close()
                    Else
                        My.Computer.FileSystem.WriteAllText("data\psw.txt", EncryptData(TextBox2.Text), False)
                        Me.Close()
                    End If
                Else
                    Label4.Text = "新密码不能与原密码相同，请重新输入"
                    Label4.Visible = True
                End If
            Else
                Label4.Text = "原密码错误，请重新输入"
                Label4.Visible = True
            End If
        End If
    End Sub

    Private Sub Form30_Load(sender As Object, e As EventArgs) Handles Me.Load
        Label4.Visible = False
    End Sub
End Class