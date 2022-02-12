Module Module1
    Public Const CambioDolar = 7.69
    Public Const CambioPesoMexicano = 0.38
    Public Const CambioEuro = 8.78
    Public Const CambioColonesCR = 0.012
    Const ComisionCompra = 2.5 / 100
    Const ComisionVenta = 3 / 100
    Dim TotalParcial = 0
    Dim total
    Sub Limpiar()
        Form1.TextCompra.Clear()
        Form1.TextVenta.Clear()

        Form1.CheckCompra.Checked = False
        Form1.CheckVenta.Checked = False

    End Sub

    Function calcularCompra(CantidadCompra As Double, MonedaCompra As Double) As Double

        If CantidadCompra > 0 Then
            TotalParcial = CantidadCompra * MonedaCompra
            total = TotalParcial * ComisionCompra + TotalParcial
        End If
        Return Math.Round(total, 2)

    End Function
    Function calcularVenta(Cantidadventa As Double, MonedaVenta As Double) As Double

        If Cantidadventa > 0 Then
            TotalParcial = Cantidadventa * MonedaVenta
            total = TotalParcial * ComisionVenta + TotalParcial
        End If
        Return Math.Round(total, 2)

    End Function


End Module
