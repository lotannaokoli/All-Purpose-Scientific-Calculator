<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSE
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
        Me.cmdAnswer = New System.Windows.Forms.Button()
        Me.cmdClearAll = New System.Windows.Forms.Button()
        Me.txtB1 = New System.Windows.Forms.TextBox()
        Me.txtC1 = New System.Windows.Forms.TextBox()
        Me.txtA1 = New System.Windows.Forms.TextBox()
        Me.lblY = New System.Windows.Forms.Label()
        Me.lblC1 = New System.Windows.Forms.Label()
        Me.lblA1 = New System.Windows.Forms.Label()
        Me.lblB1 = New System.Windows.Forms.Label()
        Me.lblX = New System.Windows.Forms.Label()
        Me.lblScreen = New System.Windows.Forms.Label()
        Me.cboMode = New System.Windows.Forms.ComboBox()
        Me.lblMode = New System.Windows.Forms.Label()
        Me.txtB2 = New System.Windows.Forms.TextBox()
        Me.txtC2 = New System.Windows.Forms.TextBox()
        Me.txtA2 = New System.Windows.Forms.TextBox()
        Me.lblC2 = New System.Windows.Forms.Label()
        Me.lblA2 = New System.Windows.Forms.Label()
        Me.lblB2 = New System.Windows.Forms.Label()
        Me.txtTestY = New System.Windows.Forms.TextBox()
        Me.txtTestX = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'cmdAnswer
        '
        Me.cmdAnswer.BackColor = System.Drawing.Color.Transparent
        Me.cmdAnswer.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAnswer.Location = New System.Drawing.Point(491, 362)
        Me.cmdAnswer.Name = "cmdAnswer"
        Me.cmdAnswer.Size = New System.Drawing.Size(122, 40)
        Me.cmdAnswer.TabIndex = 92
        Me.cmdAnswer.Text = "&="
        Me.cmdAnswer.UseVisualStyleBackColor = True
        '
        'cmdClearAll
        '
        Me.cmdClearAll.BackColor = System.Drawing.Color.Transparent
        Me.cmdClearAll.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClearAll.Location = New System.Drawing.Point(419, 362)
        Me.cmdClearAll.Name = "cmdClearAll"
        Me.cmdClearAll.Size = New System.Drawing.Size(50, 40)
        Me.cmdClearAll.TabIndex = 91
        Me.cmdClearAll.Text = "&AC"
        Me.cmdClearAll.UseVisualStyleBackColor = True
        '
        'txtB1
        '
        Me.txtB1.Location = New System.Drawing.Point(100, 257)
        Me.txtB1.Name = "txtB1"
        Me.txtB1.Size = New System.Drawing.Size(122, 20)
        Me.txtB1.TabIndex = 89
        '
        'txtC1
        '
        Me.txtC1.Location = New System.Drawing.Point(100, 307)
        Me.txtC1.Name = "txtC1"
        Me.txtC1.Size = New System.Drawing.Size(122, 20)
        Me.txtC1.TabIndex = 90
        '
        'txtA1
        '
        Me.txtA1.Location = New System.Drawing.Point(100, 207)
        Me.txtA1.Name = "txtA1"
        Me.txtA1.Size = New System.Drawing.Size(122, 20)
        Me.txtA1.TabIndex = 88
        '
        'lblY
        '
        Me.lblY.BackColor = System.Drawing.Color.White
        Me.lblY.Font = New System.Drawing.Font("Comic Sans MS", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblY.Location = New System.Drawing.Point(328, 95)
        Me.lblY.Name = "lblY"
        Me.lblY.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblY.Size = New System.Drawing.Size(285, 65)
        Me.lblY.TabIndex = 87
        Me.lblY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblC1
        '
        Me.lblC1.AutoSize = True
        Me.lblC1.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblC1.ForeColor = System.Drawing.Color.White
        Me.lblC1.Location = New System.Drawing.Point(45, 298)
        Me.lblC1.Name = "lblC1"
        Me.lblC1.Size = New System.Drawing.Size(50, 30)
        Me.lblC1.TabIndex = 86
        Me.lblC1.Text = "c1="
        Me.lblC1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblA1
        '
        Me.lblA1.AutoSize = True
        Me.lblA1.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblA1.ForeColor = System.Drawing.Color.White
        Me.lblA1.Location = New System.Drawing.Point(43, 198)
        Me.lblA1.Name = "lblA1"
        Me.lblA1.Size = New System.Drawing.Size(51, 30)
        Me.lblA1.TabIndex = 85
        Me.lblA1.Text = "a1="
        Me.lblA1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblB1
        '
        Me.lblB1.AutoSize = True
        Me.lblB1.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblB1.ForeColor = System.Drawing.Color.White
        Me.lblB1.Location = New System.Drawing.Point(43, 248)
        Me.lblB1.Name = "lblB1"
        Me.lblB1.Size = New System.Drawing.Size(51, 30)
        Me.lblB1.TabIndex = 84
        Me.lblB1.Text = "b1="
        Me.lblB1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblX
        '
        Me.lblX.BackColor = System.Drawing.Color.White
        Me.lblX.Font = New System.Drawing.Font("Comic Sans MS", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblX.Location = New System.Drawing.Point(43, 95)
        Me.lblX.Name = "lblX"
        Me.lblX.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblX.Size = New System.Drawing.Size(285, 65)
        Me.lblX.TabIndex = 83
        Me.lblX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblScreen
        '
        Me.lblScreen.BackColor = System.Drawing.Color.White
        Me.lblScreen.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScreen.Location = New System.Drawing.Point(43, 30)
        Me.lblScreen.Name = "lblScreen"
        Me.lblScreen.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblScreen.Size = New System.Drawing.Size(570, 65)
        Me.lblScreen.TabIndex = 82
        Me.lblScreen.Text = "a1X + b1Y = C1; a2X + b2Y = C2"
        Me.lblScreen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cboMode
        '
        Me.cboMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMode.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMode.FormattingEnabled = True
        Me.cboMode.Items.AddRange(New Object() {"1 - Standard", "2 - Quadratic Equation", "3 - Simultaneous Equation"})
        Me.cboMode.Location = New System.Drawing.Point(671, 68)
        Me.cboMode.Name = "cboMode"
        Me.cboMode.Size = New System.Drawing.Size(211, 27)
        Me.cboMode.TabIndex = 81
        '
        'lblMode
        '
        Me.lblMode.AutoSize = True
        Me.lblMode.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMode.ForeColor = System.Drawing.Color.White
        Me.lblMode.Location = New System.Drawing.Point(740, 30)
        Me.lblMode.Name = "lblMode"
        Me.lblMode.Size = New System.Drawing.Size(67, 30)
        Me.lblMode.TabIndex = 80
        Me.lblMode.Text = "Mode"
        Me.lblMode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtB2
        '
        Me.txtB2.Location = New System.Drawing.Point(314, 258)
        Me.txtB2.Name = "txtB2"
        Me.txtB2.Size = New System.Drawing.Size(122, 20)
        Me.txtB2.TabIndex = 97
        '
        'txtC2
        '
        Me.txtC2.Location = New System.Drawing.Point(314, 308)
        Me.txtC2.Name = "txtC2"
        Me.txtC2.Size = New System.Drawing.Size(122, 20)
        Me.txtC2.TabIndex = 98
        '
        'txtA2
        '
        Me.txtA2.Location = New System.Drawing.Point(314, 208)
        Me.txtA2.Name = "txtA2"
        Me.txtA2.Size = New System.Drawing.Size(122, 20)
        Me.txtA2.TabIndex = 96
        '
        'lblC2
        '
        Me.lblC2.AutoSize = True
        Me.lblC2.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblC2.ForeColor = System.Drawing.Color.White
        Me.lblC2.Location = New System.Drawing.Point(259, 299)
        Me.lblC2.Name = "lblC2"
        Me.lblC2.Size = New System.Drawing.Size(50, 30)
        Me.lblC2.TabIndex = 95
        Me.lblC2.Text = "c2="
        Me.lblC2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblA2
        '
        Me.lblA2.AutoSize = True
        Me.lblA2.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblA2.ForeColor = System.Drawing.Color.White
        Me.lblA2.Location = New System.Drawing.Point(257, 199)
        Me.lblA2.Name = "lblA2"
        Me.lblA2.Size = New System.Drawing.Size(51, 30)
        Me.lblA2.TabIndex = 94
        Me.lblA2.Text = "a2="
        Me.lblA2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblB2
        '
        Me.lblB2.AutoSize = True
        Me.lblB2.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblB2.ForeColor = System.Drawing.Color.White
        Me.lblB2.Location = New System.Drawing.Point(257, 249)
        Me.lblB2.Name = "lblB2"
        Me.lblB2.Size = New System.Drawing.Size(51, 30)
        Me.lblB2.TabIndex = 93
        Me.lblB2.Text = "b2="
        Me.lblB2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtTestY
        '
        Me.txtTestY.Location = New System.Drawing.Point(760, 257)
        Me.txtTestY.Name = "txtTestY"
        Me.txtTestY.Size = New System.Drawing.Size(122, 20)
        Me.txtTestY.TabIndex = 99
        Me.txtTestY.Visible = False
        '
        'txtTestX
        '
        Me.txtTestX.Location = New System.Drawing.Point(760, 209)
        Me.txtTestX.Name = "txtTestX"
        Me.txtTestX.Size = New System.Drawing.Size(122, 20)
        Me.txtTestX.TabIndex = 100
        Me.txtTestX.Visible = False
        '
        'frmSE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(924, 432)
        Me.Controls.Add(Me.txtTestX)
        Me.Controls.Add(Me.txtTestY)
        Me.Controls.Add(Me.txtB2)
        Me.Controls.Add(Me.txtC2)
        Me.Controls.Add(Me.txtA2)
        Me.Controls.Add(Me.lblC2)
        Me.Controls.Add(Me.lblA2)
        Me.Controls.Add(Me.lblB2)
        Me.Controls.Add(Me.cmdAnswer)
        Me.Controls.Add(Me.cmdClearAll)
        Me.Controls.Add(Me.txtB1)
        Me.Controls.Add(Me.txtC1)
        Me.Controls.Add(Me.txtA1)
        Me.Controls.Add(Me.lblY)
        Me.Controls.Add(Me.lblC1)
        Me.Controls.Add(Me.lblA1)
        Me.Controls.Add(Me.lblB1)
        Me.Controls.Add(Me.lblX)
        Me.Controls.Add(Me.lblScreen)
        Me.Controls.Add(Me.cboMode)
        Me.Controls.Add(Me.lblMode)
        Me.Name = "frmSE"
        Me.Text = "OKOLI Lotanna Uche   Calculator Project   Simultaneous Equation Mode"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdAnswer As System.Windows.Forms.Button
    Friend WithEvents cmdClearAll As System.Windows.Forms.Button
    Friend WithEvents txtB1 As System.Windows.Forms.TextBox
    Friend WithEvents txtC1 As System.Windows.Forms.TextBox
    Friend WithEvents txtA1 As System.Windows.Forms.TextBox
    Friend WithEvents lblY As System.Windows.Forms.Label
    Friend WithEvents lblC1 As System.Windows.Forms.Label
    Friend WithEvents lblA1 As System.Windows.Forms.Label
    Friend WithEvents lblB1 As System.Windows.Forms.Label
    Friend WithEvents lblX As System.Windows.Forms.Label
    Friend WithEvents lblScreen As System.Windows.Forms.Label
    Friend WithEvents cboMode As System.Windows.Forms.ComboBox
    Friend WithEvents lblMode As System.Windows.Forms.Label
    Friend WithEvents txtB2 As System.Windows.Forms.TextBox
    Friend WithEvents txtC2 As System.Windows.Forms.TextBox
    Friend WithEvents txtA2 As System.Windows.Forms.TextBox
    Friend WithEvents lblC2 As System.Windows.Forms.Label
    Friend WithEvents lblA2 As System.Windows.Forms.Label
    Friend WithEvents lblB2 As System.Windows.Forms.Label
    Friend WithEvents txtTestY As System.Windows.Forms.TextBox
    Friend WithEvents txtTestX As System.Windows.Forms.TextBox
End Class
