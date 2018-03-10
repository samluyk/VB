<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmArea
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
        Me.lblLength = New System.Windows.Forms.Label()
        Me.lblWidth = New System.Windows.Forms.Label()
        Me.lblArea = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblAns = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.txtLength = New System.Windows.Forms.MaskedTextBox()
        Me.txtWidth = New System.Windows.Forms.MaskedTextBox()
        Me.SuspendLayout()
        '
        'lblLength
        '
        Me.lblLength.AutoSize = True
        Me.lblLength.Location = New System.Drawing.Point(37, 80)
        Me.lblLength.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLength.Name = "lblLength"
        Me.lblLength.Size = New System.Drawing.Size(132, 17)
        Me.lblLength.TabIndex = 0
        Me.lblLength.Text = "Length of the room:"
        '
        'lblWidth
        '
        Me.lblWidth.AutoSize = True
        Me.lblWidth.Location = New System.Drawing.Point(37, 134)
        Me.lblWidth.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblWidth.Name = "lblWidth"
        Me.lblWidth.Size = New System.Drawing.Size(124, 17)
        Me.lblWidth.TabIndex = 1
        Me.lblWidth.Text = "Width of the room:"
        '
        'lblArea
        '
        Me.lblArea.AutoSize = True
        Me.lblArea.Location = New System.Drawing.Point(37, 186)
        Me.lblArea.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblArea.Name = "lblArea"
        Me.lblArea.Size = New System.Drawing.Size(84, 17)
        Me.lblArea.TabIndex = 2
        Me.lblArea.Text = "The area is:"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(16, 320)
        Me.btnCalculate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(155, 49)
        Me.btnCalculate.TabIndex = 3
        Me.btnCalculate.Text = "&Caclulate Area"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(368, 320)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(155, 49)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblAns
        '
        Me.lblAns.AutoSize = True
        Me.lblAns.Location = New System.Drawing.Point(272, 186)
        Me.lblAns.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAns.Name = "lblAns"
        Me.lblAns.Size = New System.Drawing.Size(0, 17)
        Me.lblAns.TabIndex = 7
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(217, 286)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(113, 84)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "C&LEAR, MAN."
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'txtLength
        '
        Me.txtLength.Location = New System.Drawing.Point(276, 71)
        Me.txtLength.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtLength.Name = "txtLength"
        Me.txtLength.Size = New System.Drawing.Size(132, 22)
        Me.txtLength.TabIndex = 9
        '
        'txtWidth
        '
        Me.txtWidth.Location = New System.Drawing.Point(276, 126)
        Me.txtWidth.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtWidth.Name = "txtWidth"
        Me.txtWidth.Size = New System.Drawing.Size(132, 22)
        Me.txtWidth.TabIndex = 10
        Me.txtWidth.ValidatingType = GetType(Integer)
        '
        'frmArea
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(539, 384)
        Me.Controls.Add(Me.txtWidth)
        Me.Controls.Add(Me.txtLength)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblAns)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblArea)
        Me.Controls.Add(Me.lblWidth)
        Me.Controls.Add(Me.lblLength)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmArea"
        Me.Text = "Area Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblLength As System.Windows.Forms.Label
    Friend WithEvents lblWidth As System.Windows.Forms.Label
    Friend WithEvents lblArea As System.Windows.Forms.Label
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblAns As System.Windows.Forms.Label
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents txtLength As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtWidth As System.Windows.Forms.MaskedTextBox

End Class
