Imports System.ComponentModel

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
        Dim rfiRow As New RfiRow("001", "AI-generated description goes here", "Some notes go here", doneDisplay, False, DateTime.Now)
        AddHandler rfiRow.ToggleCompleteClicked, AddressOf toggleComplete ' This will call the toggleComplete function in Form2, which will move the RFI row to the appropriate display based on its completion state.
        ' uses custom event ToggleCompleteClicked to handle the toggle complete button click and avoid any issues with button as the sender.
        todoDisplay.Controls.Add(rfiRow)
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

    ''' <summary>
    ''' Used by the RfiRow class to toggle the completion state of the RFI.
    ''' Moves the RFI row to the appropriate display based on its completion state.
    ''' If it is complete, it will move to the doneDisplay, otherwise it will move to the todoDisplay.
    ''' 
    ''' Cannot be placed in the RfiRow class as it needs access to the todoDisplay and doneDisplay controls, which are not accessible from within the RfiRow class.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Public Sub toggleComplete(sender As RfiRow, e As EventArgs)

        'if we get here, we know that the cast was successful and we can safely use parentRfiRow
        If sender.isComplete Then ' If the rfi is complete, we toggle it to uncomplete
            ' Move to todo display
            todoDisplay.Controls.Add(sender)

        Else ' otherwise , if it is not complete, we toggle it to complete
            ' Move to done display
            doneDisplay.Controls.Add(sender)
        End If
    End Sub
    ''' <summary>
    ''' Represents a single RFI row in the display.
    ''' Contains buttons for actions and labels for details.
    ''' </summary>)

    Public Class RfiRow
        Inherits Panel

        ' Private fields containing the display details, created to use in functions in the future.
        Private rfiIdButton As Button ' button that displays the RFI ID, to make it more noticeable

        Private toggleCompleteButton As Button ' button to mark the RFI as complete/uncomplete, when clicked it will change the text to "Complete" or "Uncomplete" depending on the current state and move it to the corresponding container

        Private editNotesButton As Button ' button to edit the notes, when clicked it will open an input box to edit the notes
        ' Labels for the RFI details
        Private titleLabel As Label
        Private notesLabel As Label
        Private dateLabel As Label
        ' Panels for layout
        Private buttonContainer As FlowLayoutPanel ' this is the panel that contains the right-side buttons and stacks them vertically, with extensibility for more buttons in the future
        Private mainContainer As TableLayoutPanel ' uses a table layout to stack the title and bottom row vertically and maintain a consistent layout
        Private bottomRow As TableLayoutPanel ' table to keep layout consistent for the notes and date labels

        ' Event to handle the toggle complete button click
        ''' <summary>
        ''' Event that is raised when the toggle complete button is clicked.
        ''' This will be handled by the Form2 class to move the RFI row to the appropriate display based on its completion state.
        ''' </summary>
        Public Event ToggleCompleteClicked(sender As RfiRow, e As EventArgs)

        ' Property to check whether the RFI is complete or not
        ''' <summary>
        ''' Gets whether the RFI is complete.
        ''' Used in toggleComplete function
        ''' </summary>
        ''' <returns>True if complete, False otherwise.</returns>
        Public ReadOnly Property isComplete As Boolean
            Get
                Return toggleCompleteButton.Text = "Reset" ' If the button text is "Undo", then it is complete, otherwise it is not.
            End Get
        End Property


        ''' <summary>
        ''' Constructor to initialize the RFI row with details provided.
        ''' This will create a panel with the RFI ID, description, notes, and buttons for actions.
        ''' </summary>
        ''' <param name="rfiId">The RFI ID</param>
        ''' <param name="description">The description of the RFI</param>
        ''' <param name="notes">Any notes associated with the RFI</param>
        ''' <param name="container">The container to add this row to</param>
        ''' <param name="creationDate">The creation date of the RFI</param>
        Public Sub New(rfiId As String, description As String, notes As String, container As FlowLayoutPanel, isComplete As Boolean, creationDate As DateTime)
            ' we create the buttons and labels in the constructor, to aid editing and reduce redundant code. 

            ' General panel settings
            Height = 80
            Width = container.ClientSize.Width
            Anchor = AnchorStyles.Left Or AnchorStyles.Right
            Dock = DockStyle.Top
            BackColor = Color.White
            Padding = New Padding(5)
            BorderStyle = BorderStyle.FixedSingle

            ' RFI ID button
            rfiIdButton = New Button With {
            .Text = rfiId,
            .Width = 60,
            .Dock = DockStyle.Left,
            .BackColor = Color.White,
            .FlatStyle = FlatStyle.Flat,
            .Margin = New Padding(0)
            }

            ' Right-side buttons
            toggleCompleteButton = New Button With {
            .Width = 100,
            .Height = 30,
            .FlatStyle = FlatStyle.Flat
            }
            AddHandler toggleCompleteButton.Click, AddressOf OnToggleCompleteClicked ' start the chain of events when the button is clicked

            If isComplete Then ' If the RFI is complete, set the button text to the appropriate value
                toggleCompleteButton.Text = "Reset"
            Else
                toggleCompleteButton.Text = "Complete"
            End If

            editNotesButton = New Button With {
            .Text = "Edit Notes",
            .Width = 100,
            .Height = 30,
            .FlatStyle = FlatStyle.Flat
            }
            AddHandler editNotesButton.Click, AddressOf OnEditNotesClick

            ' Container for right-side buttons
            buttonContainer = New FlowLayoutPanel With {
            .Dock = DockStyle.Right,
            .FlowDirection = FlowDirection.TopDown,
            .WrapContents = False,
            .AutoSize = True,
            .AutoSizeMode = AutoSizeMode.GrowAndShrink,
            .Margin = New Padding(0)
            }
            buttonContainer.Controls.Add(toggleCompleteButton)
            buttonContainer.Controls.Add(editNotesButton)

            ' Middle panel
            mainContainer = New TableLayoutPanel With {
            .Dock = DockStyle.Fill,
            .ColumnCount = 1,
            .RowCount = 2,
            .Margin = New Padding(0)
        }
            mainContainer.RowStyles.Add(New RowStyle(SizeType.Percent, 60))
            mainContainer.RowStyles.Add(New RowStyle(SizeType.Percent, 40))

            ' Title label
            titleLabel = New Label With {
            .Text = description,
            .Dock = DockStyle.Fill,
            .Font = New Font("Segoe UI", 10, FontStyle.Regular),
            .AutoSize = False,
            .TextAlign = ContentAlignment.MiddleLeft
        }

            ' Bottom row for notes/date
            bottomRow = New TableLayoutPanel With {
            .Dock = DockStyle.Fill,
            .ColumnCount = 2,
            .Margin = New Padding(0)
        }
            bottomRow.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 60))
            bottomRow.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 40))

            notesLabel = New Label With {
            .Text = notes,
            .Dock = DockStyle.Fill,
            .ForeColor = Color.Gray,
            .Font = New Font("Segoe UI", 8, FontStyle.Italic),
            .AutoEllipsis = True,
            .TextAlign = ContentAlignment.MiddleLeft
        }

            dateLabel = New Label With {
            .Text = creationDate.ToString("dd/MM/yyyy"),
            .Dock = DockStyle.Fill,
            .ForeColor = Color.Gray,
            .Font = New Font("Segoe UI", 8, FontStyle.Italic),
            .TextAlign = ContentAlignment.MiddleRight
        }

            bottomRow.Controls.Add(notesLabel, 0, 0)
            bottomRow.Controls.Add(dateLabel, 1, 0)

            mainContainer.Controls.Add(titleLabel, 0, 0)
            mainContainer.Controls.Add(bottomRow, 0, 1)

            ' Add to main panel
            Controls.Add(mainContainer)
            Controls.Add(buttonContainer)
            Controls.Add(rfiIdButton)
        End Sub
        ''' <summary>
        ''' Handles the click event for the toggle complete button.
        ''' Raises an event to notify the parent form to handle the completion toggle.
        ''' </summary>
        ''' <param name="sender">The sender of the event</param>
        ''' <param name="e">The event arguments</param>
        Private Sub OnToggleCompleteClicked(sender As Object, e As EventArgs)
            ' Raise the event to notify the parent form to handle the completion toggle
            RaiseEvent ToggleCompleteClicked(Me, EventArgs.Empty)

            If Me.isComplete Then ' reuse the isComplete property to check if the RFI is complete, done within the RfiRow class to avoid any issues.
                toggleCompleteButton.Text = "Complete"
            Else
                toggleCompleteButton.Text = "Reset"
            End If

        End Sub


        ''' <summary>
        ''' Handles the click event for the Edit Notes button.
        ''' Opens an input box to edit the notes.
        ''' </summary>
        ''' <param name="sender">The sender of the event</param>
        ''' <param name="e">The event arguments</param>

        Private Sub OnEditNotesClick(sender As Object, e As EventArgs)
            Dim input As String = InputBox("Enter new notes:", "Edit Notes", notesLabel.Text)
            If Not String.IsNullOrWhiteSpace(input) Then
                notesLabel.Text = input
            End If
        End Sub
    End Class
End Class