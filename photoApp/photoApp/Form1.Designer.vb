<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.lblLocation = New System.Windows.Forms.Label()
        Me.txtLocation = New System.Windows.Forms.TextBox()
        Me.lblPaymentMethod = New System.Windows.Forms.Label()
        Me.txtPaymentMethod = New System.Windows.Forms.TextBox()
        Me.txtDuration = New System.Windows.Forms.TextBox()
        Me.lblDuration = New System.Windows.Forms.Label()
        Me.lblPostTime = New System.Windows.Forms.Label()
        Me.txtPostTime = New System.Windows.Forms.TextBox()
        Me.lblDetails = New System.Windows.Forms.Label()
        Me.richtxtDetails = New System.Windows.Forms.RichTextBox()
        Me.lblGreeting = New System.Windows.Forms.Label()
        Me.Process1 = New System.Diagnostics.Process()
        Me.mskDate = New System.Windows.Forms.MaskedTextBox()
        Me.lblDistance = New System.Windows.Forms.Label()
        Me.txtDistance = New System.Windows.Forms.TextBox()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.cbxSex = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblShootTime = New System.Windows.Forms.Label()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(15, 20)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(45, 17)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Name"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(188, 20)
        Me.txtName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(132, 22)
        Me.txtName.TabIndex = 1
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(15, 87)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(38, 17)
        Me.lblDate.TabIndex = 3
        Me.lblDate.Text = "Date"
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(543, 394)
        Me.btnSubmit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(192, 64)
        Me.btnSubmit.TabIndex = 4
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(743, 394)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(124, 64)
        Me.btnClose.TabIndex = 5
        Me.btnClose.Text = "Close Program"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Location = New System.Drawing.Point(15, 167)
        Me.lblPrice.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(98, 17)
        Me.lblPrice.TabIndex = 6
        Me.lblPrice.Text = "Price (Dollars)"
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(187, 167)
        Me.txtPrice.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(131, 22)
        Me.txtPrice.TabIndex = 7
        '
        'lblLocation
        '
        Me.lblLocation.AutoSize = True
        Me.lblLocation.Location = New System.Drawing.Point(16, 245)
        Me.lblLocation.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLocation.Name = "lblLocation"
        Me.lblLocation.Size = New System.Drawing.Size(62, 17)
        Me.lblLocation.TabIndex = 8
        Me.lblLocation.Text = "Location"
        '
        'txtLocation
        '
        Me.txtLocation.Location = New System.Drawing.Point(187, 241)
        Me.txtLocation.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtLocation.Name = "txtLocation"
        Me.txtLocation.Size = New System.Drawing.Size(132, 22)
        Me.txtLocation.TabIndex = 9
        '
        'lblPaymentMethod
        '
        Me.lblPaymentMethod.AutoSize = True
        Me.lblPaymentMethod.Location = New System.Drawing.Point(16, 207)
        Me.lblPaymentMethod.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPaymentMethod.Name = "lblPaymentMethod"
        Me.lblPaymentMethod.Size = New System.Drawing.Size(114, 17)
        Me.lblPaymentMethod.TabIndex = 10
        Me.lblPaymentMethod.Text = "Payment Method"
        '
        'txtPaymentMethod
        '
        Me.txtPaymentMethod.Location = New System.Drawing.Point(187, 203)
        Me.txtPaymentMethod.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPaymentMethod.Name = "txtPaymentMethod"
        Me.txtPaymentMethod.Size = New System.Drawing.Size(132, 22)
        Me.txtPaymentMethod.TabIndex = 11
        '
        'txtDuration
        '
        Me.txtDuration.Location = New System.Drawing.Point(187, 282)
        Me.txtDuration.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtDuration.Name = "txtDuration"
        Me.txtDuration.Size = New System.Drawing.Size(132, 22)
        Me.txtDuration.TabIndex = 12
        '
        'lblDuration
        '
        Me.lblDuration.AutoSize = True
        Me.lblDuration.Location = New System.Drawing.Point(15, 290)
        Me.lblDuration.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDuration.Name = "lblDuration"
        Me.lblDuration.Size = New System.Drawing.Size(166, 17)
        Me.lblDuration.TabIndex = 13
        Me.lblDuration.Text = "Shoot Duration (Minutes)"
        '
        'lblPostTime
        '
        Me.lblPostTime.AutoSize = True
        Me.lblPostTime.Location = New System.Drawing.Point(16, 338)
        Me.lblPostTime.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPostTime.Name = "lblPostTime"
        Me.lblPostTime.Size = New System.Drawing.Size(149, 17)
        Me.lblPostTime.TabIndex = 14
        Me.lblPostTime.Text = "Editing Time (Minutes)"
        '
        'txtPostTime
        '
        Me.txtPostTime.Location = New System.Drawing.Point(188, 338)
        Me.txtPostTime.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPostTime.Name = "txtPostTime"
        Me.txtPostTime.Size = New System.Drawing.Size(132, 22)
        Me.txtPostTime.TabIndex = 15
        '
        'lblDetails
        '
        Me.lblDetails.AutoSize = True
        Me.lblDetails.Location = New System.Drawing.Point(423, 23)
        Me.lblDetails.Name = "lblDetails"
        Me.lblDetails.Size = New System.Drawing.Size(121, 17)
        Me.lblDetails.TabIndex = 16
        Me.lblDetails.Text = "Additional Details:"
        '
        'richtxtDetails
        '
        Me.richtxtDetails.Location = New System.Drawing.Point(564, 20)
        Me.richtxtDetails.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.richtxtDetails.Name = "richtxtDetails"
        Me.richtxtDetails.Size = New System.Drawing.Size(303, 163)
        Me.richtxtDetails.TabIndex = 17
        Me.richtxtDetails.Text = ""
        '
        'lblGreeting
        '
        Me.lblGreeting.AutoSize = True
        Me.lblGreeting.Location = New System.Drawing.Point(387, 405)
        Me.lblGreeting.Name = "lblGreeting"
        Me.lblGreeting.Size = New System.Drawing.Size(0, 17)
        Me.lblGreeting.TabIndex = 18
        '
        'Process1
        '
        Me.Process1.StartInfo.Domain = ""
        Me.Process1.StartInfo.LoadUserProfile = False
        Me.Process1.StartInfo.Password = Nothing
        Me.Process1.StartInfo.StandardErrorEncoding = Nothing
        Me.Process1.StartInfo.StandardOutputEncoding = Nothing
        Me.Process1.StartInfo.UserName = ""
        Me.Process1.SynchronizingObject = Me
        '
        'mskDate
        '
        Me.mskDate.Location = New System.Drawing.Point(188, 87)
        Me.mskDate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.mskDate.Mask = "00/00/0000"
        Me.mskDate.Name = "mskDate"
        Me.mskDate.Size = New System.Drawing.Size(132, 22)
        Me.mskDate.TabIndex = 19
        Me.mskDate.ValidatingType = GetType(Date)
        '
        'lblDistance
        '
        Me.lblDistance.AutoSize = True
        Me.lblDistance.Location = New System.Drawing.Point(16, 394)
        Me.lblDistance.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDistance.Name = "lblDistance"
        Me.lblDistance.Size = New System.Drawing.Size(151, 17)
        Me.lblDistance.TabIndex = 20
        Me.lblDistance.Text = "Distance Traveled (mi)"
        '
        'txtDistance
        '
        Me.txtDistance.Location = New System.Drawing.Point(188, 385)
        Me.txtDistance.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtDistance.Name = "txtDistance"
        Me.txtDistance.Size = New System.Drawing.Size(132, 22)
        Me.txtDistance.TabIndex = 21
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Location = New System.Drawing.Point(16, 54)
        Me.lblGender.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(56, 17)
        Me.lblGender.TabIndex = 22
        Me.lblGender.Text = "Gender"
        '
        'cbxSex
        '
        Me.cbxSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxSex.FormattingEnabled = True
        Me.cbxSex.Items.AddRange(New Object() {"Male", "Female"})
        Me.cbxSex.Location = New System.Drawing.Point(188, 54)
        Me.cbxSex.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbxSex.Name = "cbxSex"
        Me.cbxSex.Size = New System.Drawing.Size(132, 24)
        Me.cbxSex.TabIndex = 23
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(797, 374)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 17)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "tab order!"
        '
        'lblShootTime
        '
        Me.lblShootTime.AutoSize = True
        Me.lblShootTime.Location = New System.Drawing.Point(16, 124)
        Me.lblShootTime.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblShootTime.Name = "lblShootTime"
        Me.lblShootTime.Size = New System.Drawing.Size(80, 17)
        Me.lblShootTime.TabIndex = 25
        Me.lblShootTime.Text = "Shoot Time"
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.Location = New System.Drawing.Point(188, 127)
        Me.MaskedTextBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaskedTextBox1.Mask = "00:00"
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(132, 22)
        Me.MaskedTextBox1.TabIndex = 26
        Me.MaskedTextBox1.ValidatingType = GetType(Date)
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(883, 465)
        Me.Controls.Add(Me.MaskedTextBox1)
        Me.Controls.Add(Me.lblShootTime)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbxSex)
        Me.Controls.Add(Me.lblGender)
        Me.Controls.Add(Me.txtDistance)
        Me.Controls.Add(Me.lblDistance)
        Me.Controls.Add(Me.mskDate)
        Me.Controls.Add(Me.lblGreeting)
        Me.Controls.Add(Me.richtxtDetails)
        Me.Controls.Add(Me.lblDetails)
        Me.Controls.Add(Me.txtPostTime)
        Me.Controls.Add(Me.lblPostTime)
        Me.Controls.Add(Me.lblDuration)
        Me.Controls.Add(Me.txtDuration)
        Me.Controls.Add(Me.txtPaymentMethod)
        Me.Controls.Add(Me.lblPaymentMethod)
        Me.Controls.Add(Me.txtLocation)
        Me.Controls.Add(Me.lblLocation)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblName)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmMain"
        Me.Text = "Sam Luyk"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents lblPrice As System.Windows.Forms.Label
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents lblLocation As System.Windows.Forms.Label
    Friend WithEvents txtLocation As System.Windows.Forms.TextBox
    Friend WithEvents lblPaymentMethod As System.Windows.Forms.Label
    Friend WithEvents txtPaymentMethod As System.Windows.Forms.TextBox
    Friend WithEvents txtDuration As System.Windows.Forms.TextBox
    Friend WithEvents lblDuration As System.Windows.Forms.Label
    Friend WithEvents lblPostTime As System.Windows.Forms.Label
    Friend WithEvents txtPostTime As System.Windows.Forms.TextBox
    Friend WithEvents lblDetails As System.Windows.Forms.Label
    Friend WithEvents richtxtDetails As System.Windows.Forms.RichTextBox
    Public WithEvents lblGreeting As System.Windows.Forms.Label
    Friend WithEvents Process1 As System.Diagnostics.Process
    Friend WithEvents mskDate As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cbxSex As System.Windows.Forms.ComboBox
    Friend WithEvents lblGender As System.Windows.Forms.Label
    Friend WithEvents txtDistance As System.Windows.Forms.TextBox
    Friend WithEvents lblDistance As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MaskedTextBox1 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblShootTime As System.Windows.Forms.Label

End Class
