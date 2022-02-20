Public Class Form1
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click

        If btnSmall.Checked() Or btnMedium.Checked() Or btnLarge.Checked() Then

            If btnAlgodon.Checked() Or btnSeda.Checked() Or btnLona.Checked() Then

                If txtCantidad.Text() = "" Then

                    MsgBox("Debe ingresar una cantidad", 64, "Ingrese una cantidad")

                Else

                    Dim material, precioCosto, precioVenta As Double

                    If btnAlgodon.Checked() Then
                        material = 15
                    ElseIf btnSeda.Checked() Then
                        material = 23.99
                    ElseIf btnLona.Checked() Then
                        material = 30.99
                    End If

                    If btnSmall.Checked() Then
                        precioCosto = 65.5 + 2 * material * Val(txtCantidad.Text())
                    End If

                    If btnMedium.Checked() Then
                        precioCosto = 85.99 + 2.5 * material * Val(txtCantidad.Text())
                    End If

                    If btnLarge.Checked() Then
                        precioCosto = 30.99 + 3 * material * Val(txtCantidad.Text())
                    End If

                    precioVenta = precioCosto + 0.65 * precioCosto

                    lblPCosto.Text() = Math.Round(precioCosto, 2)
                    lblPVenta.Text() = Math.Round(precioVenta, 2)
                    lblTCosto.Text() = Math.Round(precioCosto + precioVenta, 2)

                End If

            Else
                MsgBox("Debe seleccionar un tipo de material", 64, "Escoge un material")
            End If

        Else
            MsgBox("Debe seleccionar al menos un tamaño", 64, "Escoge un tamaño")
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim meboi As DialogResult

        meboi = MsgBox("¿De verdad me vas a dejar?", 4, "No te vayas :(")

        Console.WriteLine(meboi)

        If meboi = DialogResult.Yes Then
            Me.Close()
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtCantidad.Clear()
        btnSmall.Checked = False
        btnMedium.Checked = False
        btnLarge.Checked = False
        btnAlgodon.Checked = False
        btnSeda.Checked = False
        btnLona.Checked = False
        txtCantidad.Text = 0

        lblPCosto.Text = 0
        lblPVenta.Text = 0
        lblTCosto.Text = 0


    End Sub
End Class
