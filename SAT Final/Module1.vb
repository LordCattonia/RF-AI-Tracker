
Imports System.Windows.Forms
''' <summary>
''' Diverts the application startup to a custom ApplicationContext
''' to manage multiple forms and ensure the application exits cleanly
''' when all forms are closed. This also allows us to stop the program from looking XP era
''' </summary>
Module Program
    <STAThread>
    Sub Main()
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)

        Application.Run(New Form1)
    End Sub
End Module

