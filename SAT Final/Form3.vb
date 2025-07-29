Public Class Form3
    Private _parentForm As Form2
    ''' <summary>
    ''' Reference to the parent form (Form2) to allow navigation back to it.
    ''' </summary>
    ''' <param name="parent">This is the parent form to allow re-showing Form2 after hiding</param>
    Public Sub New(parent As Form2)
        InitializeComponent()
        _parentForm = parent
    End Sub

    Private Sub rfiCancel_Click(sender As Object, e As EventArgs) Handles rfiCancel.Click
        Me.Close()
        _parentForm.Show()
    End Sub
End Class