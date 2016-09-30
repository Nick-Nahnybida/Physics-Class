Public Class Form1

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' M1 = -(M2 *(V2f - V2i)) / (V1f - V1i)
        Dim M1, M2, V2f, V2i, V1F, V1i As Double
        M2 = Convert.ToDouble(txtM2.Text)
        V1F = Convert.ToDouble(txtV1f.Text)
        V1i = Convert.ToDouble(txtV1i.Text)
        V2f = Convert.ToDouble(txtV2f.Text)
        V2i = Convert.ToDouble(txtV2i.Text)
        ' M1 = Convert.ToDouble(lblM1.Text)

        ' Solving for mass.
        M1 = (-(M2 * (V2f - V2i)) / (V1F - V1i))
        lblM1.Text = CDbl(M1)

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtM2.Clear()
        txtV1f.Clear()
        txtV1i.Clear()
        txtV2f.Clear()
        txtV2i.Clear()
        lblM1.Text = ("")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
