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
        Me.grpLicensing = New System.Windows.Forms.GroupBox()
        Me.rdoFlat = New System.Windows.Forms.RadioButton()
        Me.rdoYearly = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkBackup = New System.Windows.Forms.CheckBox()
        Me.chkTraining = New System.Windows.Forms.CheckBox()
        Me.chkSupport = New System.Windows.Forms.CheckBox()
        Me.grp3 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtAdditional = New System.Windows.Forms.TextBox()
        Me.txtLicensing = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.grpLicensing.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.grp3.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpLicensing
        '
        Me.grpLicensing.Controls.Add(Me.rdoFlat)
        Me.grpLicensing.Controls.Add(Me.rdoYearly)
        Me.grpLicensing.Location = New System.Drawing.Point(35, 29)
        Me.grpLicensing.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.grpLicensing.Name = "grpLicensing"
        Me.grpLicensing.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.grpLicensing.Size = New System.Drawing.Size(176, 169)
        Me.grpLicensing.TabIndex = 0
        Me.grpLicensing.TabStop = False
        Me.grpLicensing.Text = "Licensing Options"
        '
        'rdoFlat
        '
        Me.rdoFlat.AutoSize = True
        Me.rdoFlat.Location = New System.Drawing.Point(16, 94)
        Me.rdoFlat.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.rdoFlat.Name = "rdoFlat"
        Me.rdoFlat.Size = New System.Drawing.Size(119, 17)
        Me.rdoFlat.TabIndex = 1
        Me.rdoFlat.TabStop = True
        Me.rdoFlat.Text = "One-Time Purchase"
        Me.rdoFlat.UseVisualStyleBackColor = True
        '
        'rdoYearly
        '
        Me.rdoYearly.AutoSize = True
        Me.rdoYearly.Location = New System.Drawing.Point(16, 45)
        Me.rdoYearly.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.rdoYearly.Name = "rdoYearly"
        Me.rdoYearly.Size = New System.Drawing.Size(94, 17)
        Me.rdoYearly.TabIndex = 0
        Me.rdoYearly.TabStop = True
        Me.rdoYearly.Text = "Yearly License"
        Me.rdoYearly.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkBackup)
        Me.GroupBox2.Controls.Add(Me.chkTraining)
        Me.GroupBox2.Controls.Add(Me.chkSupport)
        Me.GroupBox2.Location = New System.Drawing.Point(261, 29)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(175, 169)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Optional Features (Yearly)"
        '
        'chkBackup
        '
        Me.chkBackup.AutoSize = True
        Me.chkBackup.Location = New System.Drawing.Point(39, 147)
        Me.chkBackup.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chkBackup.Name = "chkBackup"
        Me.chkBackup.Size = New System.Drawing.Size(93, 17)
        Me.chkBackup.TabIndex = 2
        Me.chkBackup.Text = "Cloud Backup"
        Me.chkBackup.UseVisualStyleBackColor = True
        '
        'chkTraining
        '
        Me.chkTraining.AutoSize = True
        Me.chkTraining.Location = New System.Drawing.Point(39, 94)
        Me.chkTraining.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chkTraining.Name = "chkTraining"
        Me.chkTraining.Size = New System.Drawing.Size(100, 17)
        Me.chkTraining.TabIndex = 1
        Me.chkTraining.Text = "On-site Training"
        Me.chkTraining.UseVisualStyleBackColor = True
        '
        'chkSupport
        '
        Me.chkSupport.AutoSize = True
        Me.chkSupport.Location = New System.Drawing.Point(39, 46)
        Me.chkSupport.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chkSupport.Name = "chkSupport"
        Me.chkSupport.Size = New System.Drawing.Size(101, 17)
        Me.chkSupport.TabIndex = 0
        Me.chkSupport.Text = "Level 3 Support"
        Me.chkSupport.UseVisualStyleBackColor = True
        '
        'grp3
        '
        Me.grp3.Controls.Add(Me.Label2)
        Me.grp3.Controls.Add(Me.Label1)
        Me.grp3.Controls.Add(Me.txtAdditional)
        Me.grp3.Controls.Add(Me.txtLicensing)
        Me.grp3.Location = New System.Drawing.Point(91, 221)
        Me.grp3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.grp3.Name = "grp3"
        Me.grp3.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.grp3.Size = New System.Drawing.Size(256, 97)
        Me.grp3.TabIndex = 2
        Me.grp3.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 59)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Cost of additional features:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 32)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Cost of licensing:"
        '
        'txtAdditional
        '
        Me.txtAdditional.Location = New System.Drawing.Point(163, 59)
        Me.txtAdditional.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtAdditional.Name = "txtAdditional"
        Me.txtAdditional.Size = New System.Drawing.Size(76, 20)
        Me.txtAdditional.TabIndex = 1
        '
        'txtLicensing
        '
        Me.txtLicensing.Location = New System.Drawing.Point(163, 32)
        Me.txtLicensing.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtLicensing.Name = "txtLicensing"
        Me.txtLicensing.Size = New System.Drawing.Size(76, 20)
        Me.txtLicensing.TabIndex = 0
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(179, 353)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(86, 29)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(300, 353)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(86, 29)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(66, 353)
        Me.btnCalculate.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(86, 29)
        Me.btnCalculate.TabIndex = 6
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(454, 401)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.grp3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.grpLicensing)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmSoftware"
        Me.grpLicensing.ResumeLayout(False)
        Me.grpLicensing.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.grp3.ResumeLayout(False)
        Me.grp3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpLicensing As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents grp3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents rdoFlat As System.Windows.Forms.RadioButton
    Friend WithEvents rdoYearly As System.Windows.Forms.RadioButton
    Friend WithEvents chkBackup As System.Windows.Forms.CheckBox
    Friend WithEvents chkTraining As System.Windows.Forms.CheckBox
    Friend WithEvents chkSupport As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtAdditional As System.Windows.Forms.TextBox
    Friend WithEvents txtLicensing As System.Windows.Forms.TextBox

End Class
