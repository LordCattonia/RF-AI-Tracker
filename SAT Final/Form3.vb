Imports System.Runtime.CompilerServices

Public Class Form3
    Private _parentForm As Form2

    Private _imgLoc As String
    ''' <summary>
    ''' Reference to the parent form (Form2) to allow navigation back to it.
    ''' </summary>
    ''' <param name="parent">This is the parent form to allow re-showing Form2 after hiding</param>
    ''' 
    Public Sub New(parent As Form2)
        InitializeComponent()
        _parentForm = parent
    End Sub
    Private Property _isDarkMode As Boolean

    Private Sub rfiCancel_Click(sender As Object, e As EventArgs) Handles rfiCancel.Click
        Me.Close()
        _parentForm.Show()
    End Sub

    Private Sub imgBtn_Click(sender As Object, e As EventArgs) Handles imgBtn.Click
        Dim openFile As OpenFileDialog = New OpenFileDialog()
        openFile.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif"
        openFile.Title = "Select an Image"
        If openFile.ShowDialog() = DialogResult.OK Then
            Try
                rfiImg.Image = Image.FromFile(openFile.FileName)
                _imgLoc = openFile.FileName
            Catch ex As Exception
                MessageBox.Show("Error loading image: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rfiID.Text = globalProj.nextId
    End Sub
    ''' <summary>
    ''' This code handles the submit button click event for the RFI form.
    ''' It creates a new RFI object with the ID, description, and image location,
    ''' and adds it to the global project list for use in other forms.
    ''' </summary>
    Private Sub rfiSubmit_Click(sender As Object, e As EventArgs) Handles rfiSubmit.Click
        Dim newRFI = New rfiClass(Val(rfiID.Text), rfiDesc.Text, _imgLoc) ' creates a new RFI with the ID, description and image location.
        globalProj.proj.rfiList.Add(newRFI) ' add it to the global project list to use in other forms. Use globalProj. for clarity that it is a global variable.
        globalProj.nextId += 1 ' increment the next ID for the next RFI to be created. Use globalProj. for clarity that it is a global variable.
        Me.Close() ' close the form after submitting the RFI.
    End Sub
    ''' <summary>
    ''' This handles the type stage of validation by only allowing backspace and digits in the ID textbox.
    ''' Also handles range by not allowing dash for negative.
    ''' </summary>
    ''' <param name="sender">Irrelevant, but required</param>
    ''' <param name="e">the key pressed information</param>
    Private Sub rfiID_TextChanged(sender As Object, e As KeyPressEventArgs) Handles rfiID.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Asc(e.KeyChar) <> 8 Then ' Allow only digits and backspace, 8 is the ASCII code for backspace as I don't think there is any other way to check

            e.Handled = True ' Ignore the keypress if it is not a digit or backspace. Unintuitively, handled is set to true to ignore the keypress, not false.
        End If
    End Sub
End Class