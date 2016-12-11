<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStandard
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
        Me.cmdAns = New System.Windows.Forms.Button()
        Me.cmdClearAll = New System.Windows.Forms.Button()
        Me.cmdClear = New System.Windows.Forms.Button()
        Me.cmdTan = New System.Windows.Forms.Button()
        Me.cmdCosine = New System.Windows.Forms.Button()
        Me.cmdSine = New System.Windows.Forms.Button()
        Me.cmdPi = New System.Windows.Forms.Button()
        Me.cmdLogBase10 = New System.Windows.Forms.Button()
        Me.cmdReciprocal = New System.Windows.Forms.Button()
        Me.cmdMemoryMinus = New System.Windows.Forms.Button()
        Me.cmdSquare = New System.Windows.Forms.Button()
        Me.cmdSqrt = New System.Windows.Forms.Button()
        Me.cmdMemoryRecall = New System.Windows.Forms.Button()
        Me.cmdMemoryPlus = New System.Windows.Forms.Button()
        Me.txtOperator = New System.Windows.Forms.TextBox()
        Me.txtMemory = New System.Windows.Forms.TextBox()
        Me.txtPreAns = New System.Windows.Forms.TextBox()
        Me.txtAns = New System.Windows.Forms.TextBox()
        Me.cmdAdd = New System.Windows.Forms.Button()
        Me.CmdMinus = New System.Windows.Forms.Button()
        Me.cmdMultiply = New System.Windows.Forms.Button()
        Me.cmdDivide = New System.Windows.Forms.Button()
        Me.cmdZero = New System.Windows.Forms.Button()
        Me.cmdDecimal = New System.Windows.Forms.Button()
        Me.cmdThree = New System.Windows.Forms.Button()
        Me.cmdTwo = New System.Windows.Forms.Button()
        Me.cmdOne = New System.Windows.Forms.Button()
        Me.cmdSix = New System.Windows.Forms.Button()
        Me.cmdFive = New System.Windows.Forms.Button()
        Me.cmdFour = New System.Windows.Forms.Button()
        Me.cmdNine = New System.Windows.Forms.Button()
        Me.cmdEight = New System.Windows.Forms.Button()
        Me.cmdSeven = New System.Windows.Forms.Button()
        Me.lblMemory = New System.Windows.Forms.Label()
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.lblScreen = New System.Windows.Forms.Label()
        Me.cboMode = New System.Windows.Forms.ComboBox()
        Me.lblMode = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmdAnswer
        '
        Me.cmdAnswer.BackColor = System.Drawing.Color.Transparent
        Me.cmdAnswer.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAnswer.Location = New System.Drawing.Point(491, 360)
        Me.cmdAnswer.Name = "cmdAnswer"
        Me.cmdAnswer.Size = New System.Drawing.Size(122, 40)
        Me.cmdAnswer.TabIndex = 78
        Me.cmdAnswer.Text = "&="
        Me.cmdAnswer.UseVisualStyleBackColor = True
        '
        'cmdAns
        '
        Me.cmdAns.BackColor = System.Drawing.Color.Transparent
        Me.cmdAns.Font = New System.Drawing.Font("Comic Sans MS", 12.5!, System.Drawing.FontStyle.Bold)
        Me.cmdAns.Location = New System.Drawing.Point(563, 305)
        Me.cmdAns.Name = "cmdAns"
        Me.cmdAns.Size = New System.Drawing.Size(50, 40)
        Me.cmdAns.TabIndex = 77
        Me.cmdAns.Text = "A&ns"
        Me.cmdAns.UseVisualStyleBackColor = True
        '
        'cmdClearAll
        '
        Me.cmdClearAll.BackColor = System.Drawing.Color.Transparent
        Me.cmdClearAll.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClearAll.Location = New System.Drawing.Point(563, 250)
        Me.cmdClearAll.Name = "cmdClearAll"
        Me.cmdClearAll.Size = New System.Drawing.Size(50, 40)
        Me.cmdClearAll.TabIndex = 76
        Me.cmdClearAll.Text = "&AC"
        Me.cmdClearAll.UseVisualStyleBackColor = True
        '
        'cmdClear
        '
        Me.cmdClear.BackColor = System.Drawing.Color.Transparent
        Me.cmdClear.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClear.Location = New System.Drawing.Point(563, 195)
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(50, 40)
        Me.cmdClear.TabIndex = 75
        Me.cmdClear.Text = "&Del"
        Me.cmdClear.UseVisualStyleBackColor = True
        '
        'cmdTan
        '
        Me.cmdTan.BackColor = System.Drawing.Color.Transparent
        Me.cmdTan.Font = New System.Drawing.Font("Comic Sans MS", 12.5!, System.Drawing.FontStyle.Bold)
        Me.cmdTan.Location = New System.Drawing.Point(491, 305)
        Me.cmdTan.Name = "cmdTan"
        Me.cmdTan.Size = New System.Drawing.Size(50, 40)
        Me.cmdTan.TabIndex = 74
        Me.cmdTan.Text = "&Tan"
        Me.cmdTan.UseVisualStyleBackColor = True
        '
        'cmdCosine
        '
        Me.cmdCosine.BackColor = System.Drawing.Color.Transparent
        Me.cmdCosine.Font = New System.Drawing.Font("Comic Sans MS", 13.0!, System.Drawing.FontStyle.Bold)
        Me.cmdCosine.Location = New System.Drawing.Point(491, 250)
        Me.cmdCosine.Name = "cmdCosine"
        Me.cmdCosine.Size = New System.Drawing.Size(50, 40)
        Me.cmdCosine.TabIndex = 73
        Me.cmdCosine.Text = "&Cos"
        Me.cmdCosine.UseVisualStyleBackColor = True
        '
        'cmdSine
        '
        Me.cmdSine.BackColor = System.Drawing.Color.Transparent
        Me.cmdSine.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSine.Location = New System.Drawing.Point(491, 195)
        Me.cmdSine.Name = "cmdSine"
        Me.cmdSine.Size = New System.Drawing.Size(50, 40)
        Me.cmdSine.TabIndex = 72
        Me.cmdSine.Text = "&Sin"
        Me.cmdSine.UseVisualStyleBackColor = True
        '
        'cmdPi
        '
        Me.cmdPi.BackColor = System.Drawing.Color.Transparent
        Me.cmdPi.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPi.Location = New System.Drawing.Point(419, 360)
        Me.cmdPi.Name = "cmdPi"
        Me.cmdPi.Size = New System.Drawing.Size(50, 40)
        Me.cmdPi.TabIndex = 71
        Me.cmdPi.Text = "π"
        Me.cmdPi.UseVisualStyleBackColor = True
        '
        'cmdLogBase10
        '
        Me.cmdLogBase10.BackColor = System.Drawing.Color.Transparent
        Me.cmdLogBase10.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLogBase10.Location = New System.Drawing.Point(419, 305)
        Me.cmdLogBase10.Name = "cmdLogBase10"
        Me.cmdLogBase10.Size = New System.Drawing.Size(50, 40)
        Me.cmdLogBase10.TabIndex = 70
        Me.cmdLogBase10.Text = "&Log"
        Me.cmdLogBase10.UseVisualStyleBackColor = True
        '
        'cmdReciprocal
        '
        Me.cmdReciprocal.BackColor = System.Drawing.Color.Transparent
        Me.cmdReciprocal.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.cmdReciprocal.Location = New System.Drawing.Point(419, 250)
        Me.cmdReciprocal.Name = "cmdReciprocal"
        Me.cmdReciprocal.Size = New System.Drawing.Size(50, 40)
        Me.cmdReciprocal.TabIndex = 69
        Me.cmdReciprocal.Text = "1/x"
        Me.cmdReciprocal.UseVisualStyleBackColor = True
        '
        'cmdMemoryMinus
        '
        Me.cmdMemoryMinus.BackColor = System.Drawing.Color.Transparent
        Me.cmdMemoryMinus.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdMemoryMinus.Location = New System.Drawing.Point(419, 195)
        Me.cmdMemoryMinus.Name = "cmdMemoryMinus"
        Me.cmdMemoryMinus.Size = New System.Drawing.Size(50, 40)
        Me.cmdMemoryMinus.TabIndex = 68
        Me.cmdMemoryMinus.Text = "M-"
        Me.cmdMemoryMinus.UseVisualStyleBackColor = True
        '
        'cmdSquare
        '
        Me.cmdSquare.BackColor = System.Drawing.Color.Transparent
        Me.cmdSquare.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.cmdSquare.Location = New System.Drawing.Point(347, 360)
        Me.cmdSquare.Name = "cmdSquare"
        Me.cmdSquare.Size = New System.Drawing.Size(50, 40)
        Me.cmdSquare.TabIndex = 67
        Me.cmdSquare.Text = "&x^2"
        Me.cmdSquare.UseVisualStyleBackColor = True
        '
        'cmdSqrt
        '
        Me.cmdSqrt.BackColor = System.Drawing.Color.Transparent
        Me.cmdSqrt.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.cmdSqrt.Location = New System.Drawing.Point(347, 305)
        Me.cmdSqrt.Name = "cmdSqrt"
        Me.cmdSqrt.Size = New System.Drawing.Size(50, 40)
        Me.cmdSqrt.TabIndex = 66
        Me.cmdSqrt.Text = "√"
        Me.cmdSqrt.UseVisualStyleBackColor = True
        '
        'cmdMemoryRecall
        '
        Me.cmdMemoryRecall.BackColor = System.Drawing.Color.Transparent
        Me.cmdMemoryRecall.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdMemoryRecall.Location = New System.Drawing.Point(347, 250)
        Me.cmdMemoryRecall.Name = "cmdMemoryRecall"
        Me.cmdMemoryRecall.Size = New System.Drawing.Size(50, 40)
        Me.cmdMemoryRecall.TabIndex = 65
        Me.cmdMemoryRecall.Text = "M&R"
        Me.cmdMemoryRecall.UseVisualStyleBackColor = True
        '
        'cmdMemoryPlus
        '
        Me.cmdMemoryPlus.BackColor = System.Drawing.Color.Transparent
        Me.cmdMemoryPlus.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdMemoryPlus.Location = New System.Drawing.Point(347, 195)
        Me.cmdMemoryPlus.Name = "cmdMemoryPlus"
        Me.cmdMemoryPlus.Size = New System.Drawing.Size(50, 40)
        Me.cmdMemoryPlus.TabIndex = 64
        Me.cmdMemoryPlus.Text = "&M+"
        Me.cmdMemoryPlus.UseVisualStyleBackColor = True
        '
        'txtOperator
        '
        Me.txtOperator.Location = New System.Drawing.Point(703, 341)
        Me.txtOperator.Name = "txtOperator"
        Me.txtOperator.Size = New System.Drawing.Size(122, 20)
        Me.txtOperator.TabIndex = 63
        Me.txtOperator.Visible = False
        '
        'txtMemory
        '
        Me.txtMemory.Location = New System.Drawing.Point(703, 291)
        Me.txtMemory.Name = "txtMemory"
        Me.txtMemory.Size = New System.Drawing.Size(122, 20)
        Me.txtMemory.TabIndex = 62
        Me.txtMemory.Text = "0"
        Me.txtMemory.Visible = False
        '
        'txtPreAns
        '
        Me.txtPreAns.Location = New System.Drawing.Point(703, 250)
        Me.txtPreAns.Name = "txtPreAns"
        Me.txtPreAns.Size = New System.Drawing.Size(122, 20)
        Me.txtPreAns.TabIndex = 61
        Me.txtPreAns.Text = "0"
        Me.txtPreAns.Visible = False
        '
        'txtAns
        '
        Me.txtAns.Location = New System.Drawing.Point(703, 194)
        Me.txtAns.Name = "txtAns"
        Me.txtAns.Size = New System.Drawing.Size(122, 20)
        Me.txtAns.TabIndex = 60
        Me.txtAns.Text = "0"
        Me.txtAns.Visible = False
        '
        'cmdAdd
        '
        Me.cmdAdd.BackColor = System.Drawing.Color.Transparent
        Me.cmdAdd.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAdd.Location = New System.Drawing.Point(267, 360)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(50, 40)
        Me.cmdAdd.TabIndex = 59
        Me.cmdAdd.Text = "&+"
        Me.cmdAdd.UseVisualStyleBackColor = True
        '
        'CmdMinus
        '
        Me.CmdMinus.BackColor = System.Drawing.Color.Transparent
        Me.CmdMinus.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdMinus.Location = New System.Drawing.Point(267, 305)
        Me.CmdMinus.Name = "CmdMinus"
        Me.CmdMinus.Size = New System.Drawing.Size(50, 40)
        Me.CmdMinus.TabIndex = 58
        Me.CmdMinus.Text = "&-"
        Me.CmdMinus.UseVisualStyleBackColor = True
        '
        'cmdMultiply
        '
        Me.cmdMultiply.BackColor = System.Drawing.Color.Transparent
        Me.cmdMultiply.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdMultiply.Location = New System.Drawing.Point(267, 250)
        Me.cmdMultiply.Name = "cmdMultiply"
        Me.cmdMultiply.Size = New System.Drawing.Size(50, 40)
        Me.cmdMultiply.TabIndex = 57
        Me.cmdMultiply.Text = "&*"
        Me.cmdMultiply.UseVisualStyleBackColor = True
        '
        'cmdDivide
        '
        Me.cmdDivide.BackColor = System.Drawing.Color.Transparent
        Me.cmdDivide.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDivide.Location = New System.Drawing.Point(267, 195)
        Me.cmdDivide.Name = "cmdDivide"
        Me.cmdDivide.Size = New System.Drawing.Size(50, 40)
        Me.cmdDivide.TabIndex = 56
        Me.cmdDivide.Text = "&/"
        Me.cmdDivide.UseVisualStyleBackColor = True
        '
        'cmdZero
        '
        Me.cmdZero.BackColor = System.Drawing.Color.Transparent
        Me.cmdZero.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdZero.Location = New System.Drawing.Point(43, 360)
        Me.cmdZero.Name = "cmdZero"
        Me.cmdZero.Size = New System.Drawing.Size(122, 40)
        Me.cmdZero.TabIndex = 55
        Me.cmdZero.Text = "&0"
        Me.cmdZero.UseVisualStyleBackColor = True
        '
        'cmdDecimal
        '
        Me.cmdDecimal.BackColor = System.Drawing.Color.Transparent
        Me.cmdDecimal.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDecimal.Location = New System.Drawing.Point(187, 360)
        Me.cmdDecimal.Name = "cmdDecimal"
        Me.cmdDecimal.Size = New System.Drawing.Size(50, 40)
        Me.cmdDecimal.TabIndex = 54
        Me.cmdDecimal.Text = "&."
        Me.cmdDecimal.UseVisualStyleBackColor = True
        '
        'cmdThree
        '
        Me.cmdThree.BackColor = System.Drawing.Color.Transparent
        Me.cmdThree.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdThree.Location = New System.Drawing.Point(187, 305)
        Me.cmdThree.Name = "cmdThree"
        Me.cmdThree.Size = New System.Drawing.Size(50, 40)
        Me.cmdThree.TabIndex = 53
        Me.cmdThree.Text = "&3"
        Me.cmdThree.UseVisualStyleBackColor = True
        '
        'cmdTwo
        '
        Me.cmdTwo.BackColor = System.Drawing.Color.Transparent
        Me.cmdTwo.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdTwo.Location = New System.Drawing.Point(115, 305)
        Me.cmdTwo.Name = "cmdTwo"
        Me.cmdTwo.Size = New System.Drawing.Size(50, 40)
        Me.cmdTwo.TabIndex = 52
        Me.cmdTwo.Text = "&2"
        Me.cmdTwo.UseVisualStyleBackColor = True
        '
        'cmdOne
        '
        Me.cmdOne.BackColor = System.Drawing.Color.Transparent
        Me.cmdOne.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOne.Location = New System.Drawing.Point(43, 305)
        Me.cmdOne.Name = "cmdOne"
        Me.cmdOne.Size = New System.Drawing.Size(50, 40)
        Me.cmdOne.TabIndex = 51
        Me.cmdOne.Text = "&1"
        Me.cmdOne.UseVisualStyleBackColor = True
        '
        'cmdSix
        '
        Me.cmdSix.BackColor = System.Drawing.Color.Transparent
        Me.cmdSix.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSix.Location = New System.Drawing.Point(187, 250)
        Me.cmdSix.Name = "cmdSix"
        Me.cmdSix.Size = New System.Drawing.Size(50, 40)
        Me.cmdSix.TabIndex = 50
        Me.cmdSix.Text = "&6"
        Me.cmdSix.UseVisualStyleBackColor = True
        '
        'cmdFive
        '
        Me.cmdFive.BackColor = System.Drawing.Color.Transparent
        Me.cmdFive.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFive.Location = New System.Drawing.Point(115, 250)
        Me.cmdFive.Name = "cmdFive"
        Me.cmdFive.Size = New System.Drawing.Size(50, 40)
        Me.cmdFive.TabIndex = 49
        Me.cmdFive.Text = "&5"
        Me.cmdFive.UseVisualStyleBackColor = True
        '
        'cmdFour
        '
        Me.cmdFour.BackColor = System.Drawing.Color.Transparent
        Me.cmdFour.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFour.Location = New System.Drawing.Point(43, 250)
        Me.cmdFour.Name = "cmdFour"
        Me.cmdFour.Size = New System.Drawing.Size(50, 40)
        Me.cmdFour.TabIndex = 48
        Me.cmdFour.Text = "&4"
        Me.cmdFour.UseVisualStyleBackColor = True
        '
        'cmdNine
        '
        Me.cmdNine.BackColor = System.Drawing.Color.Transparent
        Me.cmdNine.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNine.Location = New System.Drawing.Point(187, 195)
        Me.cmdNine.Name = "cmdNine"
        Me.cmdNine.Size = New System.Drawing.Size(50, 40)
        Me.cmdNine.TabIndex = 47
        Me.cmdNine.Text = "&9"
        Me.cmdNine.UseVisualStyleBackColor = True
        '
        'cmdEight
        '
        Me.cmdEight.BackColor = System.Drawing.Color.Transparent
        Me.cmdEight.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEight.Location = New System.Drawing.Point(115, 195)
        Me.cmdEight.Name = "cmdEight"
        Me.cmdEight.Size = New System.Drawing.Size(50, 40)
        Me.cmdEight.TabIndex = 46
        Me.cmdEight.Text = "&8"
        Me.cmdEight.UseVisualStyleBackColor = True
        '
        'cmdSeven
        '
        Me.cmdSeven.BackColor = System.Drawing.Color.Transparent
        Me.cmdSeven.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSeven.Location = New System.Drawing.Point(43, 195)
        Me.cmdSeven.Name = "cmdSeven"
        Me.cmdSeven.Size = New System.Drawing.Size(50, 40)
        Me.cmdSeven.TabIndex = 45
        Me.cmdSeven.Text = "&7"
        Me.cmdSeven.UseVisualStyleBackColor = True
        '
        'lblMemory
        '
        Me.lblMemory.BackColor = System.Drawing.Color.White
        Me.lblMemory.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMemory.Location = New System.Drawing.Point(44, 116)
        Me.lblMemory.Name = "lblMemory"
        Me.lblMemory.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblMemory.Size = New System.Drawing.Size(31, 29)
        Me.lblMemory.TabIndex = 44
        Me.lblMemory.Text = "M"
        Me.lblMemory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblMemory.Visible = False
        '
        'lblAnswer
        '
        Me.lblAnswer.BackColor = System.Drawing.Color.White
        Me.lblAnswer.Font = New System.Drawing.Font("Comic Sans MS", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnswer.Location = New System.Drawing.Point(43, 97)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblAnswer.Size = New System.Drawing.Size(570, 65)
        Me.lblAnswer.TabIndex = 43
        Me.lblAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblScreen
        '
        Me.lblScreen.BackColor = System.Drawing.Color.White
        Me.lblScreen.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScreen.Location = New System.Drawing.Point(43, 32)
        Me.lblScreen.Name = "lblScreen"
        Me.lblScreen.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblScreen.Size = New System.Drawing.Size(570, 65)
        Me.lblScreen.TabIndex = 42
        Me.lblScreen.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.cboMode.TabIndex = 41
        '
        'lblMode
        '
        Me.lblMode.AutoSize = True
        Me.lblMode.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMode.ForeColor = System.Drawing.Color.White
        Me.lblMode.Location = New System.Drawing.Point(740, 32)
        Me.lblMode.Name = "lblMode"
        Me.lblMode.Size = New System.Drawing.Size(67, 30)
        Me.lblMode.TabIndex = 40
        Me.lblMode.Text = "Mode"
        Me.lblMode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmStandard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(924, 432)
        Me.Controls.Add(Me.cmdAnswer)
        Me.Controls.Add(Me.cmdAns)
        Me.Controls.Add(Me.cmdClearAll)
        Me.Controls.Add(Me.cmdClear)
        Me.Controls.Add(Me.cmdTan)
        Me.Controls.Add(Me.cmdCosine)
        Me.Controls.Add(Me.cmdSine)
        Me.Controls.Add(Me.cmdPi)
        Me.Controls.Add(Me.cmdLogBase10)
        Me.Controls.Add(Me.cmdReciprocal)
        Me.Controls.Add(Me.cmdMemoryMinus)
        Me.Controls.Add(Me.cmdSquare)
        Me.Controls.Add(Me.cmdSqrt)
        Me.Controls.Add(Me.cmdMemoryRecall)
        Me.Controls.Add(Me.cmdMemoryPlus)
        Me.Controls.Add(Me.txtOperator)
        Me.Controls.Add(Me.txtMemory)
        Me.Controls.Add(Me.txtPreAns)
        Me.Controls.Add(Me.txtAns)
        Me.Controls.Add(Me.cmdAdd)
        Me.Controls.Add(Me.CmdMinus)
        Me.Controls.Add(Me.cmdMultiply)
        Me.Controls.Add(Me.cmdDivide)
        Me.Controls.Add(Me.cmdZero)
        Me.Controls.Add(Me.cmdDecimal)
        Me.Controls.Add(Me.cmdThree)
        Me.Controls.Add(Me.cmdTwo)
        Me.Controls.Add(Me.cmdOne)
        Me.Controls.Add(Me.cmdSix)
        Me.Controls.Add(Me.cmdFive)
        Me.Controls.Add(Me.cmdFour)
        Me.Controls.Add(Me.cmdNine)
        Me.Controls.Add(Me.cmdEight)
        Me.Controls.Add(Me.cmdSeven)
        Me.Controls.Add(Me.lblMemory)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.lblScreen)
        Me.Controls.Add(Me.cboMode)
        Me.Controls.Add(Me.lblMode)
        Me.Name = "frmStandard"
        Me.Text = "OKOLI Lotanna Uche   Calculator Project   Standard Mode"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdAnswer As System.Windows.Forms.Button
    Friend WithEvents cmdAns As System.Windows.Forms.Button
    Friend WithEvents cmdClearAll As System.Windows.Forms.Button
    Friend WithEvents cmdClear As System.Windows.Forms.Button
    Friend WithEvents cmdTan As System.Windows.Forms.Button
    Friend WithEvents cmdCosine As System.Windows.Forms.Button
    Friend WithEvents cmdSine As System.Windows.Forms.Button
    Friend WithEvents cmdPi As System.Windows.Forms.Button
    Friend WithEvents cmdLogBase10 As System.Windows.Forms.Button
    Friend WithEvents cmdReciprocal As System.Windows.Forms.Button
    Friend WithEvents cmdMemoryMinus As System.Windows.Forms.Button
    Friend WithEvents cmdSquare As System.Windows.Forms.Button
    Friend WithEvents cmdSqrt As System.Windows.Forms.Button
    Friend WithEvents cmdMemoryRecall As System.Windows.Forms.Button
    Friend WithEvents cmdMemoryPlus As System.Windows.Forms.Button
    Friend WithEvents txtOperator As System.Windows.Forms.TextBox
    Friend WithEvents txtMemory As System.Windows.Forms.TextBox
    Friend WithEvents txtPreAns As System.Windows.Forms.TextBox
    Friend WithEvents txtAns As System.Windows.Forms.TextBox
    Friend WithEvents cmdAdd As System.Windows.Forms.Button
    Friend WithEvents CmdMinus As System.Windows.Forms.Button
    Friend WithEvents cmdMultiply As System.Windows.Forms.Button
    Friend WithEvents cmdDivide As System.Windows.Forms.Button
    Friend WithEvents cmdZero As System.Windows.Forms.Button
    Friend WithEvents cmdDecimal As System.Windows.Forms.Button
    Friend WithEvents cmdThree As System.Windows.Forms.Button
    Friend WithEvents cmdTwo As System.Windows.Forms.Button
    Friend WithEvents cmdOne As System.Windows.Forms.Button
    Friend WithEvents cmdSix As System.Windows.Forms.Button
    Friend WithEvents cmdFive As System.Windows.Forms.Button
    Friend WithEvents cmdFour As System.Windows.Forms.Button
    Friend WithEvents cmdNine As System.Windows.Forms.Button
    Friend WithEvents cmdEight As System.Windows.Forms.Button
    Friend WithEvents cmdSeven As System.Windows.Forms.Button
    Friend WithEvents lblMemory As System.Windows.Forms.Label
    Friend WithEvents lblAnswer As System.Windows.Forms.Label
    Friend WithEvents lblScreen As System.Windows.Forms.Label
    Friend WithEvents cboMode As System.Windows.Forms.ComboBox
    Friend WithEvents lblMode As System.Windows.Forms.Label

End Class
