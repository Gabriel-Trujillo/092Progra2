Public Class Form1
    Const PrecioArroz As Double = 2.0
    Const PrecioFrijol As Double = 1.75
    Const PrecioAzucar As Double = 2.5
    Const IVA As Double = 0.12

    Dim PagoSinIVA As Double = 0
    Dim ValorIVA As Double = 0
    Dim PagoConIVA As Double = 0
    Dim Descuento As Double = 0
    Dim PagoFinal As Double = 0




    Private Sub ButtonAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAceptar.Click
        PagoSinIVA = (Val(textoarroz.Text) * PrecioArroz) + (Val(textofrijol.Text) * PrecioFrijol) + (Val(textoazucar.Text) * PrecioAzucar)
        ValorIVA = PagoSinIVA * IVA
        PagoConIVA = PagoSinIVA + ValorIVA
        Descuento = PagoConIVA * 0.02
        PagoFinal = PagoConIVA - Descuento

        LabelR1.Text = PagoSinIVA
        LabelR2.Text = ValorIVA
        LabelR3.Text = PagoConIVA
        LabelR4.Text = Descuento
        LabelR5.Text = PagoFinal

    End Sub

    Private Sub ButtonLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonLimpiar.Click
        textoarroz.Clear()
        textofrijol.Clear()
        textoazucar.Clear()

        textoarroz.Text = 0
        textofrijol.Text = 0
        textoazucar.Text = 0


        LabelR1.Text = 0
        LabelR2.Text = 0
        LabelR3.Text = 0
        LabelR4.Text = 0
        LabelR5.Text = 0

        textoarroz.Focus()








    End Sub

    Private Sub ButtonSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSalir.Click
        End

    End Sub

    Private Sub textoarroz_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles textoarroz.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub textofrijol_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles textofrijol.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub textoazucar_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles textoazucar.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
End Class
