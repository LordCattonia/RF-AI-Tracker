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
        Const shouldToggle = False
        darkMode.setAllForms(shouldToggle) ' This will apply the current theme to this form and all other open forms. False as we do not want to toggle the theme here, we just want to apply the current theme.
        ' Has to be in load as the theme is not applied until the form is loaded, so if it was in the constructor it would not apply the theme.
    End Sub

    Private Sub displayRfi()
        ' Planned layout:
        'flowlayoutpanel>{label for id, aiDesc, 
        Dim rfiRow As New RfiRow("RFI-001", "AI-generated description goes here", "Some notes go here", DateTime.Now)
        doneDisplay.Controls.Add(rfiRow)
    End Sub

    Private Sub exportBtn_Click(sender As Object, e As EventArgs) Handles exportBtn.Click
        displayRfi()
    End Sub

    Private Sub hideToDo_Click(sender As Object, e As EventArgs) Handles hideToDo.Click
        If sender.text = "Hide" Then
            sender.text = "Show"
            todoDisplay.Visible = False
        Else
            sender.text = "Hide"
            todoDisplay.Visible = True
        End If
    End Sub

    Private Sub doneHide_Click(sender As Object, e As EventArgs) Handles hideDone.Click
        If sender.text = "Hide" Then
            sender.text = "Show"
            doneDisplay.Visible = False
        Else
            sender.text = "Hide"
            doneDisplay.Visible = True
        End If
    End Sub


    Private Function CreateRfiRow() As Panel
        ' Container for the whole row
        Dim rowPanel As New Panel With {
            .Height = 80,
            .Width = doneDisplay.ClientSize.Width,
            .Anchor = AnchorStyles.Left Or AnchorStyles.Right,
            .Dock = DockStyle.Top,
            .BackColor = Color.White,
            .Padding = New Padding(5),
            .BorderStyle = BorderStyle.FixedSingle
        }

        ' Left vertical button
        Dim btnLeft As New Button With {
            .Text = "RFI ID",
            .Width = 50,
            .Dock = DockStyle.Left,
            .BackColor = Color.White,
            .FlatStyle = FlatStyle.Flat
        }

        ' Right-side buttons
        Dim btnComplete As New Button With {
            .Text = "Complete",
            .Width = 80,
            .Height = 30,
            .FlatStyle = FlatStyle.Flat
        }

        Dim btnEdit As New Button With {
            .Text = "Edit Notes",
            .Width = 80,
            .Height = 30,
            .FlatStyle = FlatStyle.Flat
        }

        ' Right panel to stack buttons vertically
        Dim rightPanel As New FlowLayoutPanel With {
            .Dock = DockStyle.Right,
            .Width = 90
        }
        rightPanel.Controls.Add(btnComplete)
        rightPanel.Controls.Add(btnEdit)

        ' Middle panel for text and labels
        Dim middlePanel As New TableLayoutPanel With {
            .Dock = DockStyle.Fill,
            .ColumnCount = 1,
            .RowCount = 2
        }
        middlePanel.RowStyles.Add(New RowStyle(SizeType.Percent, 60))
        middlePanel.RowStyles.Add(New RowStyle(SizeType.Percent, 40))

        ' Top row: AI generated description
        Dim lblTitle As New Label With {
            .Text = "15 word AI generated description goes here",
            .Dock = DockStyle.Fill,
            .Font = New Font("Segoe UI", 10, FontStyle.Regular)
        }

        ' Bottom row: Notes and date
        Dim bottomRow As New TableLayoutPanel With {
            .Dock = DockStyle.Fill,
            .ColumnCount = 2
        }
        bottomRow.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50))
        bottomRow.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50))

        Dim lblNotes As New Label With {
            .Text = "Notes go here",
            .Dock = DockStyle.Fill,
            .ForeColor = Color.Gray,
            .Font = New Font("Segoe UI", 8, FontStyle.Italic)
        }

        Dim lblDate As New Label With {
            .Text = "Creation Date here",
            .Dock = DockStyle.Right,
            .ForeColor = Color.Gray,
            .Font = New Font("Segoe UI", 8, FontStyle.Italic),
            .TextAlign = ContentAlignment.MiddleRight
        }

        bottomRow.Controls.Add(lblNotes, 0, 0)
        bottomRow.Controls.Add(lblDate, 1, 0)

        ' Add labels to middle panel
        middlePanel.Controls.Add(lblTitle)
        middlePanel.Controls.Add(bottomRow)

        ' Add everything to main panel
        rowPanel.Controls.Add(middlePanel)
        rowPanel.Controls.Add(rightPanel)
        rowPanel.Controls.Add(btnLeft)

        Return rowPanel
    End Function

    Public Class RfiRow
        Inherits Panel

        Public Sub New(rfiId As String, description As String, notes As String, creationDate As DateTime)
            ' General panel settings
            Me.Height = 90
            Me.Dock = DockStyle.Top
            Me.BackColor = Color.White
            Me.Padding = New Padding(5)
            Me.BorderStyle = BorderStyle.FixedSingle

            ' Left vertical RFI ID button
            Dim btnLeft As New Button With {
                .Text = rfiId,
                .Width = 60,
                .Dock = DockStyle.Left,
                .BackColor = Color.White,
                .FlatStyle = FlatStyle.Flat,
                .Margin = New Padding(0)
            }

            ' Right-side buttons
            Dim btnComplete As New Button With {
                .Text = "Complete",
                .Width = 80,
                .Height = 30,
                .FlatStyle = FlatStyle.Flat
            }

            Dim btnEdit As New Button With {
                .Text = "Edit Notes",
                .Width = 80,
                .Height = 30,
                .FlatStyle = FlatStyle.Flat
            }

            ' Right panel to contain buttons
            Dim rightPanel As New FlowLayoutPanel With {
                .Dock = DockStyle.Right,
                .Width = 100,
                .FlowDirection = FlowDirection.TopDown,
                .WrapContents = False,
                .AutoSize = True,
                .AutoSizeMode = AutoSizeMode.GrowAndShrink,
                .Margin = New Padding(0)
            }
            rightPanel.Controls.Add(btnComplete)
            rightPanel.Controls.Add(btnEdit)

            ' Middle panel for description and notes/date
            Dim middlePanel As New TableLayoutPanel With {
                .Dock = DockStyle.Fill,
                .ColumnCount = 1,
                .RowCount = 2,
                .Margin = New Padding(0)
            }
            middlePanel.RowStyles.Add(New RowStyle(SizeType.Percent, 60))
            middlePanel.RowStyles.Add(New RowStyle(SizeType.Percent, 40))

            ' Title/description label
            Dim lblTitle As New Label With {
                .Text = description,
                .Dock = DockStyle.Fill,
                .Font = New Font("Segoe UI", 10, FontStyle.Regular),
                .AutoSize = False,
                .TextAlign = ContentAlignment.MiddleLeft,
                .Padding = New Padding(0, 0, 0, 0)
            }

            ' Bottom row (notes and date)
            Dim bottomRow As New TableLayoutPanel With {
                .Dock = DockStyle.Fill,
                .ColumnCount = 2,
                .Margin = New Padding(0)
            }
            bottomRow.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 60))
            bottomRow.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 40))

            Dim lblNotes As New Label With {
                .Text = notes,
                .Dock = DockStyle.Fill,
                .ForeColor = Color.Gray,
                .Font = New Font("Segoe UI", 8, FontStyle.Italic),
                .AutoEllipsis = True,
                .TextAlign = ContentAlignment.MiddleLeft,
                .Padding = New Padding(0, 0, 0, 2) ' prevent clipping
            }

            Dim lblDate As New Label With {
                .Text = creationDate.ToString("yyyy-MM-dd"),
                .Dock = DockStyle.Fill,
                .ForeColor = Color.Gray,
                .Font = New Font("Segoe UI", 8, FontStyle.Italic),
                .TextAlign = ContentAlignment.MiddleRight
            }

            bottomRow.Controls.Add(lblNotes, 0, 0)
            bottomRow.Controls.Add(lblDate, 1, 0)

            ' Add components to middle panel
            middlePanel.Controls.Add(lblTitle, 0, 0)
            middlePanel.Controls.Add(bottomRow, 0, 1)

            ' Add all main components to the row panel (Me)
            Me.Controls.Add(middlePanel)
            Me.Controls.Add(rightPanel)
            Me.Controls.Add(btnLeft)
        End Sub
    End Class
End Class