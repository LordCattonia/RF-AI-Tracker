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
        If darkMode.isDarkMode Then
            colourToggle.Text = "Dark"
        Else
            colourToggle.Text = "Light"
        End If
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
        Me.Hide()
        Dim form3 As New Form3(Me) ' Pass Form2 reference
        form3.Show()
    End Sub


    Private Sub colourToggle_Click(sender As Object, e As EventArgs) Handles colourToggle.Click
        darkMode.setAllForms(True) ' true activates the toggle, so it will switch to the opposite theme before running. It will also change the global variable isDarkMode to the opposite of what it was before.
        If colourToggle.Text = "Dark" Then
            colourToggle.Text = "Light"
        Else
            colourToggle.Text = "Dark"
        End If

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        darkMode.setAllForms(False) ' This will apply the current theme to this form and all other open forms. False as we do not want to toggle the theme here, we just want to apply the current theme.
        ' Has to be in load as the theme is not applied until the form is loaded, so if it was in the constructor it would not apply the theme.
    End Sub

    Private Sub rfiDisplay_Paint(sender As Object, e As PaintEventArgs) Handles rfiDisplay.Paint

    End Sub
End Class