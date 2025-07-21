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
        Me.homeBtn = New System.Windows.Forms.Button()
        Me.searchBar = New System.Windows.Forms.TextBox()
        Me.colourToggle = New System.Windows.Forms.Button()
        Me.exportBtn = New System.Windows.Forms.Button()
        Me.newRFI = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'homeBtn
        '
        Me.homeBtn.Font = New System.Drawing.Font("Arial", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.homeBtn.Location = New System.Drawing.Point(13, 13)
        Me.homeBtn.Name = "homeBtn"
        Me.homeBtn.Size = New System.Drawing.Size(289, 60)
        Me.homeBtn.TabIndex = 0
        Me.homeBtn.Text = "Back to Home"
        Me.homeBtn.UseVisualStyleBackColor = True
        '
        'searchBar
        '
        Me.searchBar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.searchBar.Location = New System.Drawing.Point(308, 13)
        Me.searchBar.Multiline = True
        Me.searchBar.Name = "searchBar"
        Me.searchBar.Size = New System.Drawing.Size(779, 60)
        Me.searchBar.TabIndex = 1
        Me.searchBar.WordWrap = False
        '
        'colourToggle
        '
        Me.colourToggle.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.colourToggle.Font = New System.Drawing.Font("Arial", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colourToggle.Location = New System.Drawing.Point(1257, 13)
        Me.colourToggle.Name = "colourToggle"
        Me.colourToggle.Size = New System.Drawing.Size(115, 60)
        Me.colourToggle.TabIndex = 2
        Me.colourToggle.Text = "Light"
        Me.colourToggle.UseVisualStyleBackColor = True
        '
        'exportBtn
        '
        Me.exportBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.exportBtn.Font = New System.Drawing.Font("Arial", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exportBtn.Location = New System.Drawing.Point(1093, 12)
        Me.exportBtn.Name = "exportBtn"
        Me.exportBtn.Size = New System.Drawing.Size(158, 60)
        Me.exportBtn.TabIndex = 3
        Me.exportBtn.Text = "Export"
        Me.exportBtn.UseVisualStyleBackColor = True
        '
        'newRFI
        '
        Me.newRFI.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.newRFI.BackColor = System.Drawing.SystemColors.ControlDark
        Me.newRFI.Font = New System.Drawing.Font("Arial", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.newRFI.Location = New System.Drawing.Point(1378, 12)
        Me.newRFI.Name = "newRFI"
        Me.newRFI.Size = New System.Drawing.Size(205, 61)
        Me.newRFI.TabIndex = 4
        Me.newRFI.Text = "New RFI"
        Me.newRFI.UseVisualStyleBackColor = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1595, 1001)
        Me.Controls.Add(Me.newRFI)
        Me.Controls.Add(Me.exportBtn)
        Me.Controls.Add(Me.colourToggle)
        Me.Controls.Add(Me.searchBar)
        Me.Controls.Add(Me.homeBtn)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents homeBtn As Button
    Friend WithEvents searchBar As TextBox
    Friend WithEvents colourToggle As Button
    Friend WithEvents exportBtn As Button
    Friend WithEvents newRFI As Button
End Class
