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
    Private Property _isDarkMode As Boolean

    Public Property isDarkMode
        Get
            Return _isDarkMode
        End Get
        Set(value)
            _isDarkMode = isDarkMode
        End Set
    End Property

End Class