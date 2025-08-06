<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.homeBtn = New System.Windows.Forms.Button()
        Me.searchBar = New System.Windows.Forms.TextBox()
        Me.colourToggle = New System.Windows.Forms.Button()
        Me.exportBtn = New System.Windows.Forms.Button()
        Me.newRFI = New System.Windows.Forms.Button()
        Me.rfiDisplay = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.hideToDo = New System.Windows.Forms.Button()
        Me.todoDisplay = New System.Windows.Forms.FlowLayoutPanel()
        Me.testRfi1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.hideDone = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.doneDisplay = New System.Windows.Forms.FlowLayoutPanel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.rfiDisplay.SuspendLayout()
        Me.todoDisplay.SuspendLayout()
        Me.doneDisplay.SuspendLayout()
        Me.SuspendLayout()
        '
        'homeBtn
        '
        Me.homeBtn.Font = New System.Drawing.Font("Arial", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.homeBtn.Location = New System.Drawing.Point(10, 10)
        Me.homeBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.homeBtn.Name = "homeBtn"
        Me.homeBtn.Size = New System.Drawing.Size(217, 48)
        Me.homeBtn.TabIndex = 0
        Me.homeBtn.Text = "Back to Home"
        Me.homeBtn.UseVisualStyleBackColor = True
        '
        'searchBar
        '
        Me.searchBar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.searchBar.Location = New System.Drawing.Point(231, 10)
        Me.searchBar.Margin = New System.Windows.Forms.Padding(2)
        Me.searchBar.Multiline = True
        Me.searchBar.Name = "searchBar"
        Me.searchBar.Size = New System.Drawing.Size(585, 49)
        Me.searchBar.TabIndex = 1
        Me.searchBar.WordWrap = False
        '
        'colourToggle
        '
        Me.colourToggle.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.colourToggle.Font = New System.Drawing.Font("Arial", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colourToggle.Location = New System.Drawing.Point(943, 10)
        Me.colourToggle.Margin = New System.Windows.Forms.Padding(2)
        Me.colourToggle.Name = "colourToggle"
        Me.colourToggle.Size = New System.Drawing.Size(86, 48)
        Me.colourToggle.TabIndex = 2
        Me.colourToggle.Text = "Light"
        Me.colourToggle.UseVisualStyleBackColor = True
        '
        'exportBtn
        '
        Me.exportBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.exportBtn.Font = New System.Drawing.Font("Arial", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exportBtn.Location = New System.Drawing.Point(820, 10)
        Me.exportBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.exportBtn.Name = "exportBtn"
        Me.exportBtn.Size = New System.Drawing.Size(118, 48)
        Me.exportBtn.TabIndex = 3
        Me.exportBtn.Text = "Export"
        Me.exportBtn.UseVisualStyleBackColor = True
        '
        'newRFI
        '
        Me.newRFI.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.newRFI.BackColor = System.Drawing.SystemColors.ControlDark
        Me.newRFI.Font = New System.Drawing.Font("Arial", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.newRFI.Location = New System.Drawing.Point(1034, 10)
        Me.newRFI.Margin = New System.Windows.Forms.Padding(2)
        Me.newRFI.Name = "newRFI"
        Me.newRFI.Size = New System.Drawing.Size(154, 49)
        Me.newRFI.TabIndex = 4
        Me.newRFI.Text = "New RFI"
        Me.newRFI.UseVisualStyleBackColor = False
        '
        'rfiDisplay
        '
        Me.rfiDisplay.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rfiDisplay.AutoScroll = True
        Me.rfiDisplay.Controls.Add(Me.Label1)
        Me.rfiDisplay.Controls.Add(Me.hideToDo)
        Me.rfiDisplay.Controls.Add(Me.todoDisplay)
        Me.rfiDisplay.Controls.Add(Me.Label2)
        Me.rfiDisplay.Controls.Add(Me.hideDone)
        Me.rfiDisplay.Controls.Add(Me.FlowLayoutPanel1)
        Me.rfiDisplay.Controls.Add(Me.doneDisplay)
        Me.rfiDisplay.Location = New System.Drawing.Point(10, 64)
        Me.rfiDisplay.Name = "rfiDisplay"
        Me.rfiDisplay.Size = New System.Drawing.Size(1174, 725)
        Me.rfiDisplay.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "To Do"
        '
        'hideToDo
        '
        Me.rfiDisplay.SetFlowBreak(Me.hideToDo, True)
        Me.hideToDo.Location = New System.Drawing.Point(114, 3)
        Me.hideToDo.Name = "hideToDo"
        Me.hideToDo.Size = New System.Drawing.Size(66, 34)
        Me.hideToDo.TabIndex = 1
        Me.hideToDo.Text = "Hide"
        Me.hideToDo.UseVisualStyleBackColor = True
        '
        'todoDisplay
        '
        Me.todoDisplay.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.todoDisplay.AutoSize = True
        Me.todoDisplay.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.todoDisplay.Controls.Add(Me.testRfi1)
        Me.todoDisplay.Location = New System.Drawing.Point(3, 43)
        Me.todoDisplay.Name = "todoDisplay"
        Me.todoDisplay.Size = New System.Drawing.Size(1164, 44)
        Me.todoDisplay.TabIndex = 2
        '
        'testRfi1
        '
        Me.todoDisplay.SetFlowBreak(Me.testRfi1, True)
        Me.testRfi1.Location = New System.Drawing.Point(3, 3)
        Me.testRfi1.Name = "testRfi1"
        Me.testRfi1.Size = New System.Drawing.Size(1158, 38)
        Me.testRfi1.TabIndex = 0
        Me.testRfi1.Text = "This is a test rfi"
        Me.testRfi1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.Label2.Location = New System.Drawing.Point(3, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 37)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Done"
        '
        'hideDone
        '
        Me.rfiDisplay.SetFlowBreak(Me.hideDone, True)
        Me.hideDone.Location = New System.Drawing.Point(113, 93)
        Me.hideDone.Margin = New System.Windows.Forms.Padding(14, 3, 3, 3)
        Me.hideDone.Name = "hideDone"
        Me.hideDone.Size = New System.Drawing.Size(66, 34)
        Me.hideDone.TabIndex = 4
        Me.hideDone.Text = "Hide"
        Me.hideDone.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanel1.AutoSize = True
        Me.FlowLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(3, 133)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(0, 0)
        Me.FlowLayoutPanel1.TabIndex = 5
        '
        'doneDisplay
        '
        Me.doneDisplay.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.doneDisplay.AutoSize = True
        Me.doneDisplay.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.doneDisplay.Controls.Add(Me.Button1)
        Me.doneDisplay.Location = New System.Drawing.Point(3, 139)
        Me.doneDisplay.Name = "doneDisplay"
        Me.doneDisplay.Size = New System.Drawing.Size(1164, 44)
        Me.doneDisplay.TabIndex = 6
        '
        'Button1
        '
        Me.doneDisplay.SetFlowBreak(Me.Button1, True)
        Me.Button1.Location = New System.Drawing.Point(3, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(1158, 38)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "This is a test rfi"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1196, 801)
        Me.Controls.Add(Me.rfiDisplay)
        Me.Controls.Add(Me.newRFI)
        Me.Controls.Add(Me.exportBtn)
        Me.Controls.Add(Me.colourToggle)
        Me.Controls.Add(Me.searchBar)
        Me.Controls.Add(Me.homeBtn)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form2"
        Me.Text = "RFI List"
        Me.rfiDisplay.ResumeLayout(False)
        Me.rfiDisplay.PerformLayout()
        Me.todoDisplay.ResumeLayout(False)
        Me.doneDisplay.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents homeBtn As Button
    Friend WithEvents searchBar As TextBox
    Friend WithEvents colourToggle As Button
    Friend WithEvents exportBtn As Button
    Friend WithEvents newRFI As Button
    Friend WithEvents rfiDisplay As FlowLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents hideToDo As Button
    Friend WithEvents todoDisplay As FlowLayoutPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents hideDone As Button
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents testRfi1 As Button
    Friend WithEvents doneDisplay As FlowLayoutPanel
    Friend WithEvents Button1 As Button
End Class
