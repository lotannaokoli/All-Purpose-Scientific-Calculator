<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQE
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
        Me.lblX1 = New System.Windows.Forms.Label()
        Me.lblScreen = New System.Windows.Forms.Label()
        Me.cboMode = New System.Windows.Forms.ComboBox()
        Me.lblMode = New System.Windows.Forms.Label()
        Me.lblB = New System.Windows.Forms.Label()
        Me.lblA = New System.Windows.Forms.Label()
        Me.lblC = New System.Windows.Forms.Label()
        Me.lblX2 = New System.Windows.Forms.Label()
        Me.txtA = New System.Windows.Forms.TextBox()
        Me.txtC = New System.Windows.Forms.TextBox()
        Me.txtB = New System.Windows.Forms.TextBox()
        Me.cmdClearAll = New System.Windows.Forms.Button()
        Me.cmdAnswer = New System.Windows.Forms.Button()
        Me.txtNegative = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblX1
        '
        Me.lblX1.BackColor = System.Drawing.Color.White
        Me.lblX1.Font = New System.Drawing.Font("Comic Sans MS", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblX1.Location = New System.Drawing.Point(43, 97)
        Me.lblX1.Name = "lblX1"
        Me.lblX1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblX1.Size = New System.Drawing.Size(285, 65)
        Me.lblX1.TabIndex = 47
        Me.lblX1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblScreen
        '
        Me.lblScreen.BackColor = System.Drawing.Color.White
        Me.lblScreen.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScreen.Location = New System.Drawing.Point(43, 32)
        Me.lblScreen.Name = "lblScreen"
        Me.lblScreen.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblScreen.Size = New System.Drawing.Size(570, 65)
        Me.lblScreen.TabIndex = 46
        Me.lblScreen.Text = "aX2 + bX + c = 0"
        Me.lblScreen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cboMode
        '
        Me.cboMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMode.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMode.FormattingEnabled = True
        Me.cboMode.Items.AddRange(New Object() {"1 - Standard", "2 - Quadratic Equation", "3 - Simultaneous Equation"})
        Me.cboMode.Location = New System.Drawing.Point(671, 70)
        Me.cboMode.Name = "cboMode"
        Me.cboMode.Size = New System.Drawing.Size(211, 27)
        Me.cboMode.TabIndex = 45
        '
        'lblMode
        '
        Me.lblMode.AutoSize = True
        Me.lblMode.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMode.ForeColor = System.Drawing.Color.White
        Me.lblMode.Location = New System.Drawing.Point(740, 32)
        Me.lblMode.Name = "lblMode"
        Me.lblMode.Size = New System.Drawing.Size(67, 30)
        Me.lblMode.TabIndex = 44
        Me.lblMode.Text = "Mode"
        Me.lblMode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblB
        '
        Me.lblB.AutoSize = True
        Me.lblB.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblB.ForeColor = System.Drawing.Color.White
        Me.lblB.Location = New System.Drawing.Point(43, 250)
        Me.lblB.Name = "lblB"
        Me.lblB.Size = New System.Drawing.Size(38, 30)
        Me.lblB.TabIndex = 48
        Me.lblB.Text = "b="
        Me.lblB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblA
        '
        Me.lblA.AutoSize = True
        Me.lblA.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblA.ForeColor = System.Drawing.Color.White
        Me.lblA.Location = New System.Drawing.Point(43, 200)
        Me.lblA.Name = "lblA"
        Me.lblA.Size = New System.Drawing.Size(38, 30)
        Me.lblA.TabIndex = 49
        Me.lblA.Text = "a="
        Me.lblA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblC
        '
        Me.lblC.AutoSize = True
        Me.lblC.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblC.ForeColor = System.Drawing.Color.White
        Me.lblC.Location = New System.Drawing.Point(45, 300)
        Me.lblC.Name = "lblC"
        Me.lblC.Size = New System.Drawing.Size(37, 30)
        Me.lblC.TabIndex = 50
        Me.lblC.Text = "c="
        Me.lblC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblX2
        '
        Me.lblX2.BackColor = System.Drawing.Color.White
        Me.lblX2.Font = New System.Drawing.Font("Comic Sans MS", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblX2.Location = New System.Drawing.Point(328, 97)
        Me.lblX2.Name = "lblX2"
        Me.lblX2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblX2.Size = New System.Drawing.Size(285, 65)
        Me.lblX2.TabIndex = 51
        Me.lblX2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtA
        '
        Me.txtA.Location = New System.Drawing.Point(87, 209)
        Me.txtA.Name = "txtA"
        Me.txtA.Size = New System.Drawing.Size(122, 20)
        Me.txtA.TabIndex = 64
        '
        'txtC
        '
        Me.txtC.Location = New System.Drawing.Point(87, 309)
        Me.txtC.Name = "txtC"
        Me.txtC.Size = New System.Drawing.Size(122, 20)
        Me.txtC.TabIndex = 66
        '
        'txtB
        '
        Me.txtB.Location = New System.Drawing.Point(87, 259)
        Me.txtB.Name = "txtB"
        Me.txtB.Size = New System.Drawing.Size(122, 20)
        Me.txtB.TabIndex = 65
        '
        'cmdClearAll
        '
        Me.cmdClearAll.BackColor = System.Drawing.Color.Transparent
        Me.cmdClearAll.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClearAll.Location = New System.Drawing.Point(419, 364)
        Me.cmdClearAll.Name = "cmdClearAll"
        Me.cmdClearAll.Size = New System.Drawing.Size(50, 40)
        Me.cmdClearAll.TabIndex = 77
        Me.cmdClearAll.Text = "&AC"
        Me.cmdClearAll.UseVisualStyleBackColor = True
        '
        'cmdAnswer
        '
        Me.cmdAnswer.BackColor = System.Drawing.Color.Transparent
        Me.cmdAnswer.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAnswer.Location = New System.Drawing.Point(491, 364)
        Me.cmdAnswer.Name = "cmdAnswer"
        Me.cmdAnswer.Size = New System.Drawing.Size(122, 40)
        Me.cmdAnswer.TabIndex = 79
        Me.cmdAnswer.Text = "&="
        Me.cmdAnswer.UseVisualStyleBackColor = True
        '
        'txtNegative
        '
        Me.txtNegative.Location = New System.Drawing.Point(709, 260)
        Me.txtNegative.Name = "txtNegative"
        Me.txtNegative.Size = New System.Drawing.Size(158, 20)
        Me.txtNegative.TabIndex = 81
        Me.txtNegative.Visible = False
        '
        'frmQE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(924, 432)
        Me.Controls.Add(Me.txtNegative)
        Me.Controls.Add(Me.cmdAnswer)
        Me.Controls.Add(Me.cmdClearAll)
        Me.Controls.Add(Me.txtB)
        Me.Controls.Add(Me.txtC)
        Me.Controls.Add(Me.txtA)
        Me.Controls.Add(Me.lblX2)
        Me.Controls.Add(Me.lblC)
        Me.Controls.Add(Me.lblA)
        Me.Controls.Add(Me.lblB)
        Me.Controls.Add(Me.lblX1)
        Me.Controls.Add(Me.lblScreen)
        Me.Controls.Add(Me.cboMode)
        Me.Controls.Add(Me.lblMode)
        Me.Name = "frmQE"
        Me.Text = "OKOLI Lotanna Uche   Calculator Project   Quadratic Equation Mode"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblX1 As System.Windows.Forms.Label
    Friend WithEvents lblScreen As System.Windows.Forms.Label
    Friend WithEvents cboMode As System.Windows.Forms.ComboBox
    Friend WithEvents lblMode As System.Windows.Forms.Label
    Friend WithEvents lblB As System.Windows.Forms.Label
    Friend WithEvents lblA As System.Windows.Forms.Label
    Friend WithEvents lblC As System.Windows.Forms.Label
    Friend WithEvents lblX2 As System.Windows.Forms.Label
    Friend WithEvents txtA As System.Windows.Forms.TextBox
    Friend WithEvents txtC As System.Windows.Forms.TextBox
    Friend WithEvents txtB As System.Windows.Forms.TextBox
    Friend WithEvents cmdClearAll As System.Windows.Forms.Button
    Friend WithEvents cmdAnswer As System.Windows.Forms.Button
    Friend WithEvents txtNegative As System.Windows.Forms.TextBox
End Class
