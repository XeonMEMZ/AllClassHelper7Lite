Imports System.Diagnostics

Module Module2
    Public Function Exitproc(pName As String) As Boolean
        Dim processName As String
        processName = Left(pName, Len(pName) - 4)
        Dim processes() As Process = Process.GetProcessesByName(processName)
        If processes.Length > 0 Then
            For Each proc As Process In processes
                proc.Dispose()
            Next
            Return True
        Else
            Return False
        End If
    End Function
End Module
