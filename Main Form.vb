Public Class frmMain
    Private Const MI_salesTax = 0.06 'Michigan sales tax

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        Dim subTotal As Double

        calculateSubtotal(subTotal)
        Dim salesTax As Double = salesTaxCalculation(subTotal)

        lblSubtotal.Text = subTotal.ToString("C2")
        lblSalestax.Text = salesTax.ToString("C2")
        lblTotaldue.Text = (salesTax + subTotal).ToString("C2")


    End Sub

    Private Sub calculateSubtotal(ByRef subTotal As Double)
        Select Case True
            Case rbGlazed.Checked
                subTotal += 1.05
            Case rbSugar.Checked
                subTotal += 1.05
            Case rbChocolate.Checked
                subTotal += 1.25
            Case rbFilled.Checked
                subTotal += 1.5
            Case Else

        End Select

        If rbNone.Checked Then
        ElseIf rbRegular.Checked Then
            subTotal += 1.5
        ElseIf rbCappuccino.Checked Then
            subTotal += 2.75
        End If
    End Sub

    Private Function salesTaxCalculation(subTotal As Double) As Double
        Return subTotal * MI_salesTax
    End Function

    Private Sub clearLabels(sender As Object, e As EventArgs) Handles rbSugar.CheckedChanged, rbRegular.CheckedChanged, rbNone.CheckedChanged, rbGlazed.CheckedChanged, rbFilled.CheckedChanged, rbChocolate.CheckedChanged, rbCappuccino.CheckedChanged
        lblSubtotal.Text = ""
        lblSalestax.Text = ""
        lblTotaldue.Text = ""
    End Sub
End Class
