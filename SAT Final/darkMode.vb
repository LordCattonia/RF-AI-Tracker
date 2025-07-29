Module darkMode
    Public Property isDarkMode = False ' This will be accessible by every form, and stores the current theme state. Global variable is the most simple and effective way to achieve this
    ''' <summary>
    ''' Sets the theme for all open forms.
    ''' If toggle is True, it will switch to the opposite theme before running.
    ''' </summary>
    ''' <param name="toggle">If True, toggles the current mode.</param>
    Public Sub setAllForms(toggle As Boolean)
        If toggle Then
            isDarkMode = Not isDarkMode
        End If

        For Each frm As Form In Application.OpenForms
            ApplyTheme(frm, isDarkMode)
        Next
    End Sub

    ''' <summary>
    ''' Applies a set theme to a control and its child controls.
    ''' <param name="ctrl">The control to apply the theme to.</param>
    ''' <param name="dark">If True applies dark theme, otherwise applies light theme.</param>
    ''' </summary>
    Private Sub ApplyTheme(ctrl As Control, dark As Boolean)
        If dark Then
            ctrl.BackColor = Color.FromArgb(30, 30, 30)
            ctrl.ForeColor = Color.White
        Else
            ctrl.BackColor = SystemColors.Control
            ctrl.ForeColor = SystemColors.ControlText
        End If

        ' Recursively apply to child controls
        For Each child As Control In ctrl.Controls
            ApplyTheme(child, dark)
        Next
    End Sub
End Module
