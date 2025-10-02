Imports System.ComponentModel

Public Class Form28
    Dim zrs As Integer
    Dim xzc As Integer
    Dim xzx As String
    Dim bc As Boolean
    Dim rq As Integer
    Dim md As String
    Private Sub Form28_Load(sender As Object, e As EventArgs) Handles Me.Load
        bc = True
        zrs = CInt(My.Computer.FileSystem.ReadAllText("data\namec.txt"))
        For r = 1 To zrs
            ListBox1.Items.Add(namelist(r))
        Next
        Label1.Text = "该名单共有" & ListBox1.Items.Count & "人"
    End Sub

    Public Function namelist(n%) As String
        Dim name As String
        name = My.Computer.FileSystem.ReadAllText("data\name.txt")
        If n < 10 Then
            namelist = Trim(Mid(name, InStr(name, CStr(n)) + 1, 4))
        ElseIf n >= 10 Then
            namelist = Trim(Mid(name, InStr(name, CStr(n)) + 2, 4))
        End If
    End Function

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If Not ListBox1.SelectedIndex = -1 Then
            bc = False
            xzc = ListBox1.SelectedIndex
            ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)
            If xzc < ListBox1.Items.Count Then
                ListBox1.SelectedIndex = xzc
            End If
            Label1.Text = "该名单共有" & ListBox1.Items.Count & "人"
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If Not ListBox1.SelectedIndex = -1 Then
            If ListBox1.SelectedIndex > 0 Then
                bc = False
                xzx = ListBox1.Items(ListBox1.SelectedIndex)
                xzc = ListBox1.SelectedIndex
                ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)
                ListBox1.Items.Insert(xzc - 1, xzx)
                ListBox1.SelectedIndex = xzc - 1
            End If
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If Not ListBox1.SelectedIndex = -1 Then
            If ListBox1.SelectedIndex < ListBox1.Items.Count - 1 Then
                bc = False
                xzx = ListBox1.Items(ListBox1.SelectedIndex)
                xzc = ListBox1.SelectedIndex
                ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)
                ListBox1.Items.Insert(xzc + 1, xzx)
                ListBox1.SelectedIndex = xzc + 1
            End If
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If Not TextBox1.Text = "" Then
            If Not TextBox2.Text = "" Then
                If CInt(TextBox2.Text) >= 0 And CInt(TextBox2.Text) <= ListBox1.Items.Count Then
                    bc = False
                    ListBox1.Items.Insert(CInt(TextBox2.Text), TextBox1.Text)
                    Label1.Text = "该名单共有" & ListBox1.Items.Count & "人"
                End If
            End If
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If Not TextBox1.Text = "" Then
            If Not ListBox1.SelectedIndex = -1 Then
                bc = False
                xzc = ListBox1.SelectedIndex
                ListBox1.Items.Insert(xzc + 1, TextBox1.Text)
                Label1.Text = "该名单共有" & ListBox1.Items.Count & "人"
            End If
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If Not TextBox1.Text = "" Then
            bc = False
            ListBox1.Items.Add(TextBox1.Text)
            Label1.Text = "该名单共有" & ListBox1.Items.Count & "人"
        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If Not TextBox3.Text = "" Then
            If Not ListBox1.SelectedIndex = -1 Then
                bc = False
                xzc = ListBox1.SelectedIndex
                ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)
                ListBox1.Items.Insert(xzc, TextBox3.Text)
                ListBox1.SelectedIndex = xzc
            End If
        End If
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        If Not TextBox1.Text = "" Then
            If Not ListBox1.SelectedIndex = -1 Then
                bc = False
                xzc = ListBox1.SelectedIndex
                ListBox1.Items.Insert(xzc, TextBox1.Text)
                Label1.Text = "该名单共有" & ListBox1.Items.Count & "人"
            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        bcmd()
    End Sub
    Public Sub bcmd()
        md = ""
        My.Computer.FileSystem.WriteAllText("data\namec.txt", ListBox1.Items.Count, False)
        For x = 0 To ListBox1.Items.Count - 1
            md = md & " " & x + 1 & ListBox1.Items(x) & " "
        Next
        My.Computer.FileSystem.WriteAllText("data\name.txt", md, False)
        bc = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        bcmd()
        Me.Close()
    End Sub

    Private Sub Form28_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If bc = False Then
            rq = MsgBox("您刚才做的名单更改将丢失" & vbCrLf & "是否不保存更改并退出编辑器?", vbOKCancel + vbQuestion, "名单编辑器")
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