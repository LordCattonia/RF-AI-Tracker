Imports System.Xml

Public Class Form1
    Dim RFIlist As XElement
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim args() As String = Environment.GetCommandLineArgs()
        If args.Length > 1 Then
            Dim rfiFile As String = args(1)
            MsgBox("Opening RFI file: " & rfiFile)
            OpenRfiFile(rfiFile)
        End If
    End Sub
    Sub OpenRfiFile(filePath As String)
        Try
            Dim tempRFI As XDocument  = XDocument.Load(filePath)
            RFIlist = tempRFI.Root
            MsgBox("RFI File loaded successfully.")
            Form2.Activate()
            Me.Close()
        Catch ex As Exception
            MsgBox("Please make sure the file is a valid .RFI file.")
        End Try
    End Sub
End Class
