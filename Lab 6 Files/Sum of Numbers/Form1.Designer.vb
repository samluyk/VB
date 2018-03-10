<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSum
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
        Me.btnNumbers = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnNumbers
        '
        Me.btnNumbers.Location = New System.Drawing.Point(29, 44)
        Me.btnNumbers.Name = "btnNumbers"
        Me.btnNumbers.Size = New System.Drawing.Size(152, 86)
        Me.btnNumbers.TabIndex = 0
        Me.btnNumbers.Text = "Enter Numbers"
        Me.btnNumbers.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(205, 44)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(143, 86)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmSum
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(404, 192)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnNumbers)
        Me.Name = "frmSum"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sum of Numbers"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnNumbers As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
