Public Class Form2
    Private Property _parentForm As Form1
    ''' <summary>
    ''' Reference to the parent form (Form1) to allow navigation back to it.
    ''' If this is not here, the application will not properly exit.
    ''' </summary>
    ''' <param name="parent">This is the parent form to allow re-showing form1 after hiding</param>
    Public Sub New(parent As Form1)
        InitializeComponent()
        _parentForm = parent
    End Sub
    Private Sub homeBtn_Click(sender As Object, e As EventArgs) Handles homeBtn.Click
        _parentForm.Show()
        Me.Close()
    End Sub
    ''' <summary>
    ''' This intercepts the close function, and makes it show the parent form
    ''' </summary>
    ''' <param name="e">Any arguments sent by windows when the form is closing, eg user or shutdown.</param>
    Protected Overrides Sub OnFormClosing(e As FormClosingEventArgs)
        _parentForm.Show() ' Show the parent form when this form is closing, to prevent it from being hidden.
    End Sub

    Private Sub searchBar_TextChanged(sender As Object, e As EventArgs) Handles searchBar.TextChanged

    End Sub

    Private Sub newRFI_Click(sender As Object, e As EventArgs) Handles newRFI.Click

    End Sub
End Class