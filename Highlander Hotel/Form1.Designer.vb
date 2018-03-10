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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.grpRoomInfo = New System.Windows.Forms.GroupBox()
        Me.grpAdditionalCharges = New System.Windows.Forms.GroupBox()
        Me.grpTotals = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNights = New System.Windows.Forms.TextBox()
        Me.txtNightlyCharge = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtRoomService = New System.Windows.Forms.TextBox()
        Me.txtTelephone = New System.Windows.Forms.TextBox()
        Me.txtMisc = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblRoomCharges = New System.Windows.Forms.TextBox()
        Me.lblAddCharges = New System.Windows.Forms.TextBox()
        Me.lblSubtotal = New System.Windows.Forms.TextBox()
        Me.lblTax = New System.Windows.Forms.TextBox()
        Me.lblTotal = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblDateToday = New System.Windows.Forms.TextBox()
        Me.lblTimeToday = New System.Windows.Forms.TextBox()
        Me.grpRoomInfo.SuspendLayout()
        Me.grpAdditionalCharges.SuspendLayout()
        Me.grpTotals.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(41, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Today's Date:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(41, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Time:"
        '
        'grpRoomInfo
        '
        Me.grpRoomInfo.Controls.Add(Me.txtNightlyCharge)
        Me.grpRoomInfo.Controls.Add(Me.txtNights)
        Me.grpRoomInfo.Controls.Add(Me.Label4)
        Me.grpRoomInfo.Controls.Add(Me.Label3)
        Me.grpRoomInfo.Location = New System.Drawing.Point(44, 104)
        Me.grpRoomInfo.Name = "grpRoomInfo"
        Me.grpRoomInfo.Size = New System.Drawing.Size(241, 139)
        Me.grpRoomInfo.TabIndex = 4
        Me.grpRoomInfo.TabStop = False
        Me.grpRoomInfo.Text = "Room Information"
        '
        'grpAdditionalCharges
        '
        Me.grpAdditionalCharges.Controls.Add(Me.txtMisc)
        Me.grpAdditionalCharges.Controls.Add(Me.txtTelephone)
        Me.grpAdditionalCharges.Controls.Add(Me.txtRoomService)
        Me.grpAdditionalCharges.Controls.Add(Me.Label7)
        Me.grpAdditionalCharges.Controls.Add(Me.Label6)
        Me.grpAdditionalCharges.Controls.Add(Me.Label5)
        Me.grpAdditionalCharges.Location = New System.Drawing.Point(291, 104)
        Me.grpAdditionalCharges.Name = "grpAdditionalCharges"
        Me.grpAdditionalCharges.Size = New System.Drawing.Size(241, 139)
        Me.grpAdditionalCharges.TabIndex = 5
        Me.grpAdditionalCharges.TabStop = False
        Me.grpAdditionalCharges.Text = "Additional Charges"
        '
        'grpTotals
        '
        Me.grpTotals.Controls.Add(Me.lblTotal)
        Me.grpTotals.Controls.Add(Me.lblTax)
        Me.grpTotals.Controls.Add(Me.lblSubtotal)
        Me.grpTotals.Controls.Add(Me.lblAddCharges)
        Me.grpTotals.Controls.Add(Me.lblRoomCharges)
        Me.grpTotals.Controls.Add(Me.Label12)
        Me.grpTotals.Controls.Add(Me.Label11)
        Me.grpTotals.Controls.Add(Me.Label10)
        Me.grpTotals.Controls.Add(Me.Label9)
        Me.grpTotals.Controls.Add(Me.Label8)
        Me.grpTotals.Location = New System.Drawing.Point(44, 249)
        Me.grpTotals.Name = "grpTotals"
        Me.grpTotals.Size = New System.Drawing.Size(488, 199)
        Me.grpTotals.TabIndex = 5
        Me.grpTotals.TabStop = False
        Me.grpTotals.Text = "Total Charges"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(41, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Nights:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(41, 82)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Nightly Charge:"
        '
        'txtNights
        '
        Me.txtNights.Location = New System.Drawing.Point(135, 40)
        Me.txtNights.Name = "txtNights"
        Me.txtNights.Size = New System.Drawing.Size(100, 20)
        Me.txtNights.TabIndex = 2
        '
        'txtNightlyCharge
        '
        Me.txtNightlyCharge.Location = New System.Drawing.Point(135, 82)
        Me.txtNightlyCharge.Name = "txtNightlyCharge"
        Me.txtNightlyCharge.Size = New System.Drawing.Size(100, 20)
        Me.txtNightlyCharge.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 27)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Room Service:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 65)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Telephone:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(15, 102)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Misc:"
        '
        'txtRoomService
        '
        Me.txtRoomService.Location = New System.Drawing.Point(113, 19)
        Me.txtRoomService.Name = "txtRoomService"
        Me.txtRoomService.Size = New System.Drawing.Size(100, 20)
        Me.txtRoomService.TabIndex = 3
        '
        'txtTelephone
        '
        Me.txtTelephone.Location = New System.Drawing.Point(113, 57)
        Me.txtTelephone.Name = "txtTelephone"
        Me.txtTelephone.Size = New System.Drawing.Size(100, 20)
        Me.txtTelephone.TabIndex = 4
        '
        'txtMisc
        '
        Me.txtMisc.Location = New System.Drawing.Point(113, 102)
        Me.txtMisc.Name = "txtMisc"
        Me.txtMisc.Size = New System.Drawing.Size(100, 20)
        Me.txtMisc.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(43, 27)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Room Charges"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(43, 53)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(95, 13)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Additional Charges"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(43, 79)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(46, 13)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Subtotal"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(41, 105)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(25, 13)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "Tax"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(43, 151)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(31, 13)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "Total"
        '
        'lblRoomCharges
        '
        Me.lblRoomCharges.Location = New System.Drawing.Point(360, 24)
        Me.lblRoomCharges.Name = "lblRoomCharges"
        Me.lblRoomCharges.Size = New System.Drawing.Size(100, 20)
        Me.lblRoomCharges.TabIndex = 6
        '
        'lblAddCharges
        '
        Me.lblAddCharges.Location = New System.Drawing.Point(360, 50)
        Me.lblAddCharges.Name = "lblAddCharges"
        Me.lblAddCharges.Size = New System.Drawing.Size(100, 20)
        Me.lblAddCharges.TabIndex = 7
        '
        'lblSubtotal
        '
        Me.lblSubtotal.Location = New System.Drawing.Point(360, 76)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(100, 20)
        Me.lblSubtotal.TabIndex = 8
        '
        'lblTax
        '
        Me.lblTax.Location = New System.Drawing.Point(360, 102)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(100, 20)
        Me.lblTax.TabIndex = 9
        '
        'lblTotal
        '
        Me.lblTotal.Location = New System.Drawing.Point(360, 148)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(100, 20)
        Me.lblTotal.TabIndex = 10
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(44, 476)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(120, 55)
        Me.btnCalculate.TabIndex = 6
        Me.btnCalculate.Text = "C&alculate Charges"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(246, 476)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(108, 55)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Clea&r"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(435, 476)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(97, 55)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblDateToday
        '
        Me.lblDateToday.Location = New System.Drawing.Point(246, 26)
        Me.lblDateToday.Name = "lblDateToday"
        Me.lblDateToday.Size = New System.Drawing.Size(100, 20)
        Me.lblDateToday.TabIndex = 9
        '
        'lblTimeToday
        '
        Me.lblTimeToday.Location = New System.Drawing.Point(246, 65)
        Me.lblTimeToday.Name = "lblTimeToday"
        Me.lblTimeToday.Size = New System.Drawing.Size(100, 20)
        Me.lblTimeToday.TabIndex = 10
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(582, 580)
        Me.Controls.Add(Me.lblTimeToday)
        Me.Controls.Add(Me.lblDateToday)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.grpTotals)
        Me.Controls.Add(Me.grpAdditionalCharges)
        Me.Controls.Add(Me.grpRoomInfo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmMain"
        Me.Text = "Highlander Hotel"
        Me.grpRoomInfo.ResumeLayout(False)
        Me.grpRoomInfo.PerformLayout()
        Me.grpAdditionalCharges.ResumeLayout(False)
        Me.grpAdditionalCharges.PerformLayout()
        Me.grpTotals.ResumeLayout(False)
        Me.grpTotals.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents grpRoomInfo As System.Windows.Forms.GroupBox
    Friend WithEvents grpAdditionalCharges As System.Windows.Forms.GroupBox
    Friend WithEvents grpTotals As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNightlyCharge As System.Windows.Forms.TextBox
    Friend WithEvents txtNights As System.Windows.Forms.TextBox
    Friend WithEvents txtMisc As System.Windows.Forms.TextBox
    Friend WithEvents txtTelephone As System.Windows.Forms.TextBox
    Friend WithEvents txtRoomService As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.TextBox
    Friend WithEvents lblTax As System.Windows.Forms.TextBox
    Friend WithEvents lblSubtotal As System.Windows.Forms.TextBox
    Friend WithEvents lblAddCharges As System.Windows.Forms.TextBox
    Friend WithEvents lblRoomCharges As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblDateToday As System.Windows.Forms.TextBox
    Friend WithEvents lblTimeToday As System.Windows.Forms.TextBox

End Class
