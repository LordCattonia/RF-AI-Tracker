''' <summary>
''' Globally accessible project class and next ID variable.
''' This module is used to store the project data and the next ID for RFIs across forms.
''' </summary>
Module globalProj
    Public Property proj As New projectClass
    Public Property nextId As Integer = 0
End Module
