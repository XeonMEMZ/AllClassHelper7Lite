Imports System.Drawing.Drawing2D

Public Class Form29
    Private Sub RoundedForm_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        Dim path As New GraphicsPath()
        Dim radius As Integer = 30
        path.AddArc(0, 0, radius, radius, 180, 90)
        path.AddArc(Me.Width - radius, 0, radius, radius, 270, 90)
        path.AddArc(Me.Width - radius, Me.Height - radius, radius, radius, 0, 90)
        path.AddArc(0, Me.Height - radius, radius, radius, 90, 90)
        path.CloseFigure()
        Me.Region = New Region(path)
    End Sub

    Private Sub Form29_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim path As New GraphicsPath()
        Dim radius As Integer = 30
        path.AddArc(0, 0, radius, radius, 180, 90)
        path.AddArc(Me.Width - radius, 0, radius, radius, 270, 90)
        path.AddArc(Me.Width - radius, Me.Height - radius, radius, radius, 0, 90)
        path.AddArc(0, Me.Height - radius, radius, radius, 90, 90)
        path.CloseFigure()
        Me.Region = New Region(path)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.Close()
    End Sub
End Class