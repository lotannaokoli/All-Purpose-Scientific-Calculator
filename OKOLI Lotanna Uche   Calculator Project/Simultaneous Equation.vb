Public Class frmSE

    Private Sub cboMode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMode.SelectedIndexChanged
        If cboMode.SelectedIndex = 1 Then
            frmQE.Show()
            frmStandard.Hide()
            Me.Hide()
            frmQE.cboMode.SelectedIndex = 1
            frmQE.lblX1.Text = ""
            frmQE.lblX2.Text = ""
            frmQE.txtA.Text = ""
            frmQE.txtB.Text = ""
            frmQE.txtC.Text = ""
        Else
            If cboMode.SelectedIndex = 0 Then
                frmQE.Hide()
                frmStandard.Show()
                Me.Hide()
                frmStandard.cboMode.SelectedIndex = 0
                frmStandard.lblScreen.Text = ""
                frmStandard.lblAnswer.Text = ""
            Else
                If cboMode.SelectedIndex = 2 Then
                    frmQE.Hide()
                    frmStandard.Hide()
                    Me.Show()
                    Me.cboMode.SelectedIndex = 2
                    Me.txtA1.Text = ""
                    Me.txtA2.Text = ""
                    Me.txtB1.Text = ""
                    Me.txtB2.Text = ""
                    Me.txtC1.Text = ""
                    Me.txtC2.Text = ""
                    Me.lblX.Text = ""
                    Me.lblY.Text = ""
                End If
            End If
        End If
    End Sub

    Private Sub txtC_TextChanged(sender As Object, e As EventArgs) Handles txtC1.TextChanged

    End Sub

    Private Sub cmdAnswer_Click(sender As Object, e As EventArgs) Handles cmdAnswer.Click
        If (Val(txtA1.Text) = 0 And txtA1.Text <> "0") Or (Val(txtB1.Text) = 0 And txtB1.Text <> "0") Or (Val(txtC1.Text) = 0 And txtC1.Text <> "0") Or (Val(txtA2.Text) = 0 And txtA2.Text <> "0") Or (Val(txtB2.Text) = 0 And txtB2.Text <> "0") Or (Val(txtC2.Text) = 0 And txtC2.Text <> "0") Then
            MsgBox("Please type in a real number in all the textboxes")
        Else
            Dim a1, a2, b1, b2, c1, c2, G, S, F, H, I, J, K, L, M, X, Y As Double
            a1 = CDbl(txtA1.Text)
            a2 = CDbl(txtA2.Text)
            b1 = CDbl(txtB1.Text)
            b2 = CDbl(txtB2.Text)
            c1 = CDbl(txtC1.Text)
            c2 = CDbl(txtC2.Text)
            S = a1 * b2
            F = a2 * b1
            G = S - F
            H = b2 * c1
            I = b1 * c2
            J = H - I
            X = Math.Round((J / G), 6)
            L = a1 * c2
            K = a2 * c1
            M = L - K
            Y = Math.Round((M / G), 6)
            lblX.Text = "x=" & X
            lblY.Text = "y=" & Y
            txtTestX.Text = CStr(X)
            txtTestY.Text = CStr(Y)
            If txtTestX.Text = "Infinity" Or txtTestY.Text = "Infinity" Or txtTestX.Text = "NaN" Or txtTestY.Text = "NaN" Then
                lblX.Text = ""
                lblY.Text = ""
                MsgBox("Math Error")
            Else
                lblX.Text = lblX.Text
                lblY.Text = lblY.Text
            End If
        End If
    End Sub

    Private Sub cmdClearAll_Click(sender As Object, e As EventArgs) Handles cmdClearAll.Click
        txtA1.Text = ""
        txtA2.Text = ""
        txtB1.Text = ""
        txtB2.Text = ""
        txtC1.Text = ""
        txtC2.Text = ""
        lblX.Text = ""
        lblY.Text = ""
    End Sub

    Private Sub frmSE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboMode.SelectedIndex = "2"
    End Sub
End Class