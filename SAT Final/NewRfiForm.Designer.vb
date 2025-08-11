<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewRfiForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NewRfiForm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.rfiImg = New System.Windows.Forms.PictureBox()
        Me.rfiID = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.rfiDesc = New System.Windows.Forms.TextBox()
        Me.rfiSubmit = New System.Windows.Forms.Button()
        Me.rfiCancel = New System.Windows.Forms.Button()
        Me.imgBtn = New System.Windows.Forms.Button()
        CType(Me.rfiImg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!)
        Me.Label1.Location = New System.Drawing.Point(445, 7)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(262, 69)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "New RFI"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.Label2.Location = New System.Drawing.Point(45, 130)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 58)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ID"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.Label3.Location = New System.Drawing.Point(704, 130)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(165, 58)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Image"
        '
        'rfiImg
        '
        Me.rfiImg.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rfiImg.Location = New System.Drawing.Point(902, 130)
        Me.rfiImg.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.rfiImg.Name = "rfiImg"
        Me.rfiImg.Size = New System.Drawing.Size(216, 182)
        Me.rfiImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.rfiImg.TabIndex = 3
        Me.rfiImg.TabStop = False
        '
        'rfiID
        '
        Me.rfiID.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.rfiID.Location = New System.Drawing.Point(124, 145)
        Me.rfiID.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.rfiID.Name = "rfiID"
        Me.rfiID.Size = New System.Drawing.Size(95, 41)
        Me.rfiID.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.Label4.Location = New System.Drawing.Point(45, 252)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(276, 58)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Description"
        '
        'rfiDesc
        '
        Me.rfiDesc.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rfiDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.rfiDesc.Location = New System.Drawing.Point(55, 333)
        Me.rfiDesc.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.rfiDesc.Multiline = True
        Me.rfiDesc.Name = "rfiDesc"
        Me.rfiDesc.Size = New System.Drawing.Size(1065, 372)
        Me.rfiDesc.TabIndex = 6
        '
        'rfiSubmit
        '
        Me.rfiSubmit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rfiSubmit.BackColor = System.Drawing.SystemColors.ControlDark
        Me.rfiSubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.rfiSubmit.Location = New System.Drawing.Point(1030, 728)
        Me.rfiSubmit.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.rfiSubmit.Name = "rfiSubmit"
        Me.rfiSubmit.Size = New System.Drawing.Size(112, 39)
        Me.rfiSubmit.TabIndex = 7
        Me.rfiSubmit.Text = "Submit"
        Me.rfiSubmit.UseVisualStyleBackColor = False
        '
        'rfiCancel
        '
        Me.rfiCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rfiCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.rfiCancel.Location = New System.Drawing.Point(902, 728)
        Me.rfiCancel.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.rfiCancel.Name = "rfiCancel"
        Me.rfiCancel.Size = New System.Drawing.Size(112, 39)
        Me.rfiCancel.TabIndex = 8
        Me.rfiCancel.Text = "Cancel"
        Me.rfiCancel.UseVisualStyleBackColor = True
        '
        'imgBtn
        '
        Me.imgBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.imgBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.imgBtn.Location = New System.Drawing.Point(718, 199)
        Me.imgBtn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.imgBtn.Name = "imgBtn"
        Me.imgBtn.Size = New System.Drawing.Size(139, 39)
        Me.imgBtn.TabIndex = 9
        Me.imgBtn.Text = "Add image"
        Me.imgBtn.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1174, 787)
        Me.Controls.Add(Me.imgBtn)
        Me.Controls.Add(Me.rfiCancel)
        Me.Controls.Add(Me.rfiSubmit)
        Me.Controls.Add(Me.rfiDesc)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.rfiID)
        Me.Controls.Add(Me.rfiImg)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Form3"
        Me.Text = "New RFI"
        CType(Me.rfiImg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents rfiImg As PictureBox
    Friend WithEvents rfiID As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents rfiDesc As TextBox
    Friend WithEvents rfiSubmit As Button
    Friend WithEvents rfiCancel As Button
    Friend WithEvents imgBtn As Button
End Class
