Public Class Form2
    Private Sub Form2_formclosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Form1.Show()

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Form1.CompraDolar.Checked Then
            LabelResultados.Text = "La cantidad comprada es:" + Str(calcularCompra(Form1.TextCompra.Text, CambioDolar))

        ElseIf Form1.CompraPesoMexicano.Checked Then
            LabelResultados.Text = "La cantidad comprada es:" + Str(calcularCompra(Form1.TextCompra.Text, CambioPesoMexicano))
        ElseIf Form1.CompraEuro.Checked Then
            LabelResultados.Text = "La cantidad comprada es:" + Str(calcularCompra(Form1.TextCompra.Text, CambioEuro))
        ElseIf Form1.CompraColonesCR.Checked Then
            LabelResultados.Text = "La cantidad comprada es:" + Str(calcularCompra(Form1.TextCompra.Text, CambioColonesCR))
        End If

        If Form1.VentaDolar.Checked Then
            LabelResultados.Text = "La cantidad vendida es:" + Str(calcularVenta(Form1.TextVenta.Text, CambioDolar))

        ElseIf Form1.VentaPesoMexicano.Checked Then
            LabelResultados.Text = "La cantidad vendida es:" + Str(calcularVenta(Form1.TextVenta.Text, CambioPesoMexicano))
        ElseIf Form1.VentaEuro.Checked Then
            LabelResultados.Text = "La cantidad vendida es:" + Str(calcularVenta(Form1.TextVenta.Text, CambioEuro))
        ElseIf Form1.ventaColonesCR.Checked Then
            LabelResultados.Text = "La cantidad vendida es:" + Str(calcularVenta(Form1.TextVenta.Text, CambioColonesCR))
        End If

    End Sub
End Class