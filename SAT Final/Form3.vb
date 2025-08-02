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

    Private Sub rfiSubmit_Click(sender As Object, e As EventArgs) Handles rfiSubmit.Click

    End Sub
End Class