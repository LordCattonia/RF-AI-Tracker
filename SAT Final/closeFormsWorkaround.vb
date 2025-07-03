Imports System.Windows.Forms

Public Class MyApplicationContext
    Inherits ApplicationContext

    Public Sub New()
        ' Create and show the first form(s)
        OpenNewForm(New Form1())

    End Sub

    Public Sub OpenNewForm(f As Form)
        AddHandler f.FormClosed, AddressOf OnFormClosed
        f.Show()
    End Sub

    Private Sub OnFormClosed(sender As Object, e As FormClosedEventArgs)
        ExitThread() ' All forms closed, exit the app.
    End Sub
End Class
