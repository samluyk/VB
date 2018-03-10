<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRevenue
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
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.grpTickets = New System.Windows.Forms.GroupBox()
        Me.txtClassC = New System.Windows.Forms.TextBox()
        Me.txtClassB = New System.Windows.Forms.TextBox()
        Me.txtClassA = New System.Windows.Forms.TextBox()
        Me.lblClassC = New System.Windows.Forms.Label()
        Me.lblClassB = New System.Windows.Forms.Label()
        Me.lblClassA = New System.Windows.Forms.Label()
        Me.lblDesc = New System.Windows.Forms.Label()
        Me.grpRevenue = New System.Windows.Forms.GroupBox()
        Me.txtTotalRevenue = New System.Windows.Forms.TextBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.txtClassC2 = New System.Windows.Forms.TextBox()
        Me.txtClassB2 = New System.Windows.Forms.TextBox()
        Me.txtClassA2 = New System.Windows.Forms.TextBox()
        Me.lblClassC2 = New System.Windows.Forms.Label()
        Me.lblClassB2 = New System.Windows.Forms.Label()
        Me.lblClassA2 = New System.Windows.Forms.Label()
        Me.grpTickets.SuspendLayout()
        Me.grpRevenue.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(92, 431)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(187, 57)
        Me.btnCalc.TabIndex = 0
        Me.btnCalc.Text = "&Calculate Revenue"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(389, 440)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(106, 48)
        Me.btnClear.TabIndex = 1
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(547, 440)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(106, 48)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'grpTickets
        '
        Me.grpTickets.Controls.Add(Me.txtClassC)
        Me.grpTickets.Controls.Add(Me.txtClassB)
        Me.grpTickets.Controls.Add(Me.txtClassA)
        Me.grpTickets.Controls.Add(Me.lblClassC)
        Me.grpTickets.Controls.Add(Me.lblClassB)
        Me.grpTickets.Controls.Add(Me.lblClassA)
        Me.grpTickets.Controls.Add(Me.lblDesc)
        Me.grpTickets.Location = New System.Drawing.Point(59, 64)
        Me.grpTickets.Name = "grpTickets"
        Me.grpTickets.Size = New System.Drawing.Size(313, 260)
        Me.grpTickets.TabIndex = 10
        Me.grpTickets.TabStop = False
        Me.grpTickets.Text = "Tickets Sold"
        '
        'txtClassC
        '
        Me.txtClassC.Location = New System.Drawing.Point(111, 205)
        Me.txtClassC.Name = "txtClassC"
        Me.txtClassC.Size = New System.Drawing.Size(100, 20)
        Me.txtClassC.TabIndex = 16
        '
        'txtClassB
        '
        Me.txtClassB.Location = New System.Drawing.Point(111, 154)
        Me.txtClassB.Name = "txtClassB"
        Me.txtClassB.Size = New System.Drawing.Size(100, 20)
        Me.txtClassB.TabIndex = 15
        '
        'txtClassA
        '
        Me.txtClassA.Location = New System.Drawing.Point(111, 101)
        Me.txtClassA.Name = "txtClassA"
        Me.txtClassA.Size = New System.Drawing.Size(100, 20)
        Me.txtClassA.TabIndex = 14
        '
        'lblClassC
        '
        Me.lblClassC.AutoSize = True
        Me.lblClassC.Location = New System.Drawing.Point(37, 212)
        Me.lblClassC.Name = "lblClassC"
        Me.lblClassC.Size = New System.Drawing.Size(45, 13)
        Me.lblClassC.TabIndex = 13
        Me.lblClassC.Text = "Class C:"
        '
        'lblClassB
        '
        Me.lblClassB.AutoSize = True
        Me.lblClassB.Location = New System.Drawing.Point(37, 157)
        Me.lblClassB.Name = "lblClassB"
        Me.lblClassB.Size = New System.Drawing.Size(45, 13)
        Me.lblClassB.TabIndex = 12
        Me.lblClassB.Text = "Class B:"
        '
        'lblClassA
        '
        Me.lblClassA.AutoSize = True
        Me.lblClassA.Location = New System.Drawing.Point(37, 104)
        Me.lblClassA.Name = "lblClassA"
        Me.lblClassA.Size = New System.Drawing.Size(45, 13)
        Me.lblClassA.TabIndex = 11
        Me.lblClassA.Text = "Class A:"
        '
        'lblDesc
        '
        Me.lblDesc.AutoSize = True
        Me.lblDesc.Location = New System.Drawing.Point(30, 43)
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.Size = New System.Drawing.Size(260, 13)
        Me.lblDesc.TabIndex = 10
        Me.lblDesc.Text = "Enter the number of tickets sold for each class of seat"
        Me.lblDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grpRevenue
        '
        Me.grpRevenue.Controls.Add(Me.txtTotalRevenue)
        Me.grpRevenue.Controls.Add(Me.lblTotal)
        Me.grpRevenue.Controls.Add(Me.txtClassC2)
        Me.grpRevenue.Controls.Add(Me.txtClassB2)
        Me.grpRevenue.Controls.Add(Me.txtClassA2)
        Me.grpRevenue.Controls.Add(Me.lblClassC2)
        Me.grpRevenue.Controls.Add(Me.lblClassB2)
        Me.grpRevenue.Controls.Add(Me.lblClassA2)
        Me.grpRevenue.Location = New System.Drawing.Point(411, 64)
        Me.grpRevenue.Name = "grpRevenue"
        Me.grpRevenue.Size = New System.Drawing.Size(290, 260)
        Me.grpRevenue.TabIndex = 11
        Me.grpRevenue.TabStop = False
        Me.grpRevenue.Text = "Revenue Generated"
        '
        'txtTotalRevenue
        '
        Me.txtTotalRevenue.Location = New System.Drawing.Point(122, 212)
        Me.txtTotalRevenue.Name = "txtTotalRevenue"
        Me.txtTotalRevenue.ReadOnly = True
        Me.txtTotalRevenue.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalRevenue.TabIndex = 7
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(28, 215)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(81, 13)
        Me.lblTotal.TabIndex = 6
        Me.lblTotal.Text = "Total Revenue:"
        '
        'txtClassC2
        '
        Me.txtClassC2.Location = New System.Drawing.Point(122, 143)
        Me.txtClassC2.Name = "txtClassC2"
        Me.txtClassC2.ReadOnly = True
        Me.txtClassC2.Size = New System.Drawing.Size(100, 20)
        Me.txtClassC2.TabIndex = 5
        '
        'txtClassB2
        '
        Me.txtClassB2.Location = New System.Drawing.Point(122, 97)
        Me.txtClassB2.Name = "txtClassB2"
        Me.txtClassB2.ReadOnly = True
        Me.txtClassB2.Size = New System.Drawing.Size(100, 20)
        Me.txtClassB2.TabIndex = 4
        '
        'txtClassA2
        '
        Me.txtClassA2.Location = New System.Drawing.Point(122, 49)
        Me.txtClassA2.Name = "txtClassA2"
        Me.txtClassA2.ReadOnly = True
        Me.txtClassA2.Size = New System.Drawing.Size(100, 20)
        Me.txtClassA2.TabIndex = 3
        '
        'lblClassC2
        '
        Me.lblClassC2.AutoSize = True
        Me.lblClassC2.Location = New System.Drawing.Point(39, 150)
        Me.lblClassC2.Name = "lblClassC2"
        Me.lblClassC2.Size = New System.Drawing.Size(45, 13)
        Me.lblClassC2.TabIndex = 2
        Me.lblClassC2.Text = "Class C:"
        '
        'lblClassB2
        '
        Me.lblClassB2.AutoSize = True
        Me.lblClassB2.Location = New System.Drawing.Point(39, 100)
        Me.lblClassB2.Name = "lblClassB2"
        Me.lblClassB2.Size = New System.Drawing.Size(45, 13)
        Me.lblClassB2.TabIndex = 1
        Me.lblClassB2.Text = "Class B:"
        '
        'lblClassA2
        '
        Me.lblClassA2.AutoSize = True
        Me.lblClassA2.Location = New System.Drawing.Point(39, 56)
        Me.lblClassA2.Name = "lblClassA2"
        Me.lblClassA2.Size = New System.Drawing.Size(45, 13)
        Me.lblClassA2.TabIndex = 0
        Me.lblClassA2.Text = "Class A:"
        '
        'frmRevenue
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 509)
        Me.Controls.Add(Me.grpRevenue)
        Me.Controls.Add(Me.grpTickets)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalc)
        Me.Name = "frmRevenue"
        Me.Text = "Theater Revenue"
        Me.grpTickets.ResumeLayout(False)
        Me.grpTickets.PerformLayout()
        Me.grpRevenue.ResumeLayout(False)
        Me.grpRevenue.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCalc As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents grpTickets As System.Windows.Forms.GroupBox
    Friend WithEvents txtClassC As System.Windows.Forms.TextBox
    Friend WithEvents txtClassB As System.Windows.Forms.TextBox
    Friend WithEvents txtClassA As System.Windows.Forms.TextBox
    Friend WithEvents lblClassC As System.Windows.Forms.Label
    Friend WithEvents lblClassB As System.Windows.Forms.Label
    Friend WithEvents lblClassA As System.Windows.Forms.Label
    Friend WithEvents lblDesc As System.Windows.Forms.Label
    Friend WithEvents grpRevenue As System.Windows.Forms.GroupBox
    Friend WithEvents lblClassC2 As System.Windows.Forms.Label
    Friend WithEvents lblClassB2 As System.Windows.Forms.Label
    Friend WithEvents lblClassA2 As System.Windows.Forms.Label
    Friend WithEvents txtTotalRevenue As System.Windows.Forms.TextBox
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents txtClassC2 As System.Windows.Forms.TextBox
    Friend WithEvents txtClassB2 As System.Windows.Forms.TextBox
    Friend WithEvents txtClassA2 As System.Windows.Forms.TextBox

End Class
