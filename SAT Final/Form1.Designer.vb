<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.encodeXML = New System.Windows.Forms.Button()
        Me.decodeXML = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'encodeXML
        '
        Me.encodeXML.Location = New System.Drawing.Point(299, 99)
        Me.encodeXML.Name = "encodeXML"
        Me.encodeXML.Size = New System.Drawing.Size(476, 134)
        Me.encodeXML.TabIndex = 0
        Me.encodeXML.Text = "Encode to XML"
        Me.encodeXML.UseVisualStyleBackColor = True
        '
        'decodeXML
        '
        Me.decodeXML.Location = New System.Drawing.Point(299, 335)
        Me.decodeXML.Name = "decodeXML"
        Me.decodeXML.Size = New System.Drawing.Size(476, 134)
        Me.decodeXML.TabIndex = 1
        Me.decodeXML.Text = "Decode From XML"
        Me.decodeXML.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1104, 603)
        Me.Controls.Add(Me.decodeXML)
        Me.Controls.Add(Me.encodeXML)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents encodeXML As Button
    Friend WithEvents decodeXML As Button
End Class
