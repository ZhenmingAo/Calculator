'Affirmation of Authorship:

'Name: Zhenming Ao

'Date: 5/19/2022

'I affirm that this program was created by me. It is solely my work and ‘does not include any work done by anyone else.
Public Class frmCalculator
    Private Sub txtInput_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtInput.KeyPress
        Dim Ch As Char = e.KeyChar
        If Not Char.IsDigit(Ch) AndAlso Asc(Ch) <> 8 Then
            e.Handled = True
            'MessageBox.Show("You can only input number!")
        End If
    End Sub

    Dim dblMemory As Double
    Dim dblNumber1 As Double
    Dim dblNumber2 As Double
    Dim dblResult As Double
    Dim strEquation As String
    Dim intOperator As Integer = Nothing
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtInput.Text = String.Empty Then
            MessageBox.Show("Please input a value first!")
        Else
            dblNumber1 = CDbl(txtInput.Text)
            strEquation = CStr(dblNumber1) + " + "
            lblEquation.Text = strEquation
            txtInput.Text = String.Empty
            dblResult = Nothing
            lblResult.Text = String.Empty
            intOperator = 1
        End If
    End Sub

    Private Sub btnSubtract_Click(sender As Object, e As EventArgs) Handles btnSubtract.Click
        If txtInput.Text = String.Empty Then
            MessageBox.Show("Please input a value first!")
        Else
            dblNumber1 = CDbl(txtInput.Text)
            strEquation = CStr(dblNumber1) + " - "
            lblEquation.Text = strEquation
            txtInput.Text = String.Empty
            dblResult = Nothing
            lblResult.Text = String.Empty
            intOperator = 2
        End If
    End Sub

    Private Sub btnMultiply_Click(sender As Object, e As EventArgs) Handles btnMultiply.Click
        If txtInput.Text = String.Empty Then
            MessageBox.Show("Please input a value first!")
        Else
            dblNumber1 = CDbl(txtInput.Text)
            strEquation = CStr(dblNumber1) + " X "
            lblEquation.Text = strEquation
            txtInput.Text = String.Empty
            dblResult = Nothing
            lblResult.Text = String.Empty
            intOperator = 3
        End If
    End Sub

    Private Sub btnExponent_Click(sender As Object, e As EventArgs) Handles btnExponent.Click
        If txtInput.Text = String.Empty Then
            MessageBox.Show("Please input a value first!")
        Else
            dblNumber1 = CDbl(txtInput.Text)
            strEquation = CStr(dblNumber1) + " ^ "
            lblEquation.Text = strEquation
            txtInput.Text = String.Empty
            dblResult = Nothing
            lblResult.Text = String.Empty
            intOperator = 4
        End If
    End Sub

    Private Sub btnDivide_Click(sender As Object, e As EventArgs) Handles btnDivide.Click
        If txtInput.Text = String.Empty Then
            MessageBox.Show("Please input a value first!")
        Else
            dblNumber1 = CDbl(txtInput.Text)
            strEquation = CStr(dblNumber1) + " / "
            lblEquation.Text = strEquation
            txtInput.Text = String.Empty
            dblResult = Nothing
            lblResult.Text = String.Empty
            intOperator = 5
        End If
    End Sub

    Private Sub btnMod_Click(sender As Object, e As EventArgs) Handles btnMod.Click
        If txtInput.Text = String.Empty Then
            MessageBox.Show("Please input a value first!")
        Else
            dblNumber1 = CDbl(txtInput.Text)
            strEquation = CStr(dblNumber1) + " Mod "
            lblEquation.Text = strEquation
            txtInput.Text = String.Empty
            dblResult = Nothing
            lblResult.Text = String.Empty
            intOperator = 6
        End If
    End Sub

    Private Sub btnEqual_Click(sender As Object, e As EventArgs) Handles btnEqual.Click
        If dblNumber1 = Nothing Then
            If txtInput.Text = String.Empty Then
                MessageBox.Show("Please input a value first!")
            ElseIf intOperator = Nothing Then
                MessageBox.Show("Please input an equation! (Select an operator)")
            End If
        ElseIf intOperator = 1 Then 'Addition
            If txtInput.Text = String.Empty Then
                MessageBox.Show("Please input the second value")
            Else
                dblNumber2 = CDbl(txtInput.Text)
                dblResult = dblNumber1 + dblNumber2
                lblEquation.Text = strEquation + CStr(dblNumber2)
                txtInput.Text = String.Empty
                dblNumber1 = Nothing
                intOperator = Nothing
                lblResult.Text = CStr(dblResult)
            End If
        ElseIf intOperator = 2 Then 'Subtraction
            If txtInput.Text = String.Empty Then
                MessageBox.Show("Please input the second value")
            Else
                dblNumber2 = CDbl(txtInput.Text)
                dblResult = dblNumber1 - dblNumber2
                lblEquation.Text = strEquation + CStr(dblNumber2)
                txtInput.Text = String.Empty
                dblNumber1 = Nothing
                intOperator = Nothing
                lblResult.Text = CStr(dblResult)
            End If
        ElseIf intOperator = 3 Then 'Multiplication
            If txtInput.Text = String.Empty Then
                MessageBox.Show("Please input the second value")
            Else
                dblNumber2 = CDbl(txtInput.Text)
                dblResult = dblNumber1 * dblNumber2
                lblEquation.Text = strEquation + CStr(dblNumber2)
                txtInput.Text = String.Empty
                dblNumber1 = Nothing
                intOperator = Nothing
                lblResult.Text = CStr(dblResult)
            End If
        ElseIf intOperator = 4 Then 'Exponentiation
            If txtInput.Text = String.Empty Then
                MessageBox.Show("Please input the second value")
            Else
                dblNumber2 = CDbl(txtInput.Text)
                dblResult = dblNumber1 ^ dblNumber2
                lblEquation.Text = strEquation + CStr(dblNumber2)
                txtInput.Text = String.Empty
                dblNumber1 = Nothing
                intOperator = Nothing
                lblResult.Text = CStr(dblResult)
            End If
        ElseIf intOperator = 5 Then 'Division
            If txtInput.Text = String.Empty Then
                MessageBox.Show("Please input the second value")
            Else
                dblNumber2 = CDbl(txtInput.Text)
                If dblNumber2 = 0 Then
                    lblEquation.Text = strEquation + CStr(dblNumber2)
                    txtInput.Text = String.Empty
                    dblNumber1 = Nothing
                    intOperator = Nothing
                    lblResult.Text = "Error"
                    MessageBox.Show("Cannot divide by zero!")
                Else
                    dblResult = dblNumber1 / dblNumber2
                    lblEquation.Text = strEquation + CStr(dblNumber2)
                    txtInput.Text = String.Empty
                    dblNumber1 = Nothing
                    intOperator = Nothing
                    lblResult.Text = CStr(dblResult)
                End If
            End If
        ElseIf intOperator = 6 Then 'Modulus
            If txtInput.Text = String.Empty Then
                MessageBox.Show("Please input the second value")
            Else
                dblNumber2 = CDbl(txtInput.Text)
                dblResult = dblNumber1 Mod dblNumber2
                lblEquation.Text = strEquation + CStr(dblNumber2)
                txtInput.Text = String.Empty
                dblNumber1 = Nothing
                intOperator = Nothing
                lblResult.Text = CStr(dblResult)
            End If
        End If
    End Sub

    Private Sub btnMC_Click(sender As Object, e As EventArgs) Handles btnMC.Click
        dblMemory = Nothing
        lblMemory.Text = String.Empty
    End Sub

    Private Sub btnMR_Click(sender As Object, e As EventArgs) Handles btnMR.Click
        If dblMemory.Equals(Nothing) Then
            MessageBox.Show("No memory stored!")
        Else
            txtInput.Text = CStr(dblMemory)
        End If
    End Sub

    Private Sub btnMS_Click(sender As Object, e As EventArgs) Handles btnMS.Click
        If txtInput.Text = String.Empty Then
            MessageBox.Show("Please input a value first!")
        Else
            dblMemory = CDbl(txtInput.Text)
            lblMemory.Text = CStr(dblMemory)
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtInput.Text = String.Empty
        dblMemory = Nothing
        lblMemory.Text = String.Empty
        dblNumber1 = Nothing
        dblNumber2 = Nothing
        dblResult = Nothing
        strEquation = String.Empty
        intOperator = Nothing
        lblEquation.Text = String.Empty
        lblResult.Text = String.Empty
    End Sub

End Class
