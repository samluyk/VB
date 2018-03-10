<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFlip
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
        Me.btnToss = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.picTails = New System.Windows.Forms.PictureBox()
        Me.picHeads = New System.Windows.Forms.PictureBox()
        CType(Me.picTails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picHeads, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnToss
        '
        Me.btnToss.Location = New System.Drawing.Point(155, 353)
        Me.btnToss.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnToss.Name = "btnToss"
        Me.btnToss.Size = New System.Drawing.Size(135, 84)
        Me.btnToss.TabIndex = 0
        Me.btnToss.Text = "&Flip"
        Me.btnToss.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(313, 353)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(130, 84)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'picTails
        '
        Me.picTails.Image = Global.Coin_Toss.My.Resources.Resources._21
        Me.picTails.Location = New System.Drawing.Point(313, 27)
        Me.picTails.Name = "picTails"
        Me.picTails.Size = New System.Drawing.Size(285, 291)
        Me.picTails.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picTails.TabIndex = 3
        Me.picTails.TabStop = False
        Me.picTails.Visible = False
        '
        'picHeads
        '
        Me.picHeads.Image = Global.Coin_Toss.My.Resources.Resources._1
        Me.picHeads.Location = New System.Drawing.Point(12, 27)
        Me.picHeads.Name = "picHeads"
        Me.picHeads.Size = New System.Drawing.Size(278, 275)
        Me.picHeads.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picHeads.TabIndex = 2
        Me.picHeads.TabStop = False
        Me.picHeads.Visible = False
        '
        'frmFlip
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(616, 454)
        Me.Controls.Add(Me.picTails)
        Me.Controls.Add(Me.picHeads)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnToss)
        Me.Name = "frmFlip"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Coin Toss"
        CType(Me.picTails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picHeads, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnToss As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents picHeads As System.Windows.Forms.PictureBox
    Friend WithEvents picTails As System.Windows.Forms.PictureBox

End Class
