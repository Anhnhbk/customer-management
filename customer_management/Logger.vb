Imports System.IO

Module Logger
    Private ReadOnly logFilePath As String = "error_log.txt"

    Public Sub LogError(message As String)
        Using writer As New StreamWriter(logFilePath, True)
            writer.WriteLine($"{DateTime.Now}: {message}")
        End Using
    End Sub
End Module
