Public Class Form1
    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        If indice < 8 Then
                matriz(0, indice) = TextCarne.Text
                matriz(1, indice) = TextNombre.Text
                matriz(2, indice) = ComboIdioma.SelectedItem
                matriz(3, indice) = DateInscripccion.Value
                matriz(4, indice) = ComboDias.SelectedItem
                matriz(5, indice) = TextHoras.Text

                If RadioButtonCheque.Checked Then
                    matriz(6, indice) = RadioButtonCheque.Text
                ElseIf RadioButtonEfectivo.Checked Then
                    matriz(6, indice) = RadioButtonEfectivo.Text
                End If

            Select Case ComboIdioma.SelectedIndex
                Case 0 : matriz(7, indice) = Str(Val(matriz(5, indice) * Ingles))
                Case 1 : matriz(7, indice) = Str(Val(matriz(5, indice) * Portugues))
                Case 2 : matriz(7, indice) = Str(Val(matriz(5, indice) * Frances))
            End Select



            If RadioButtonEfectivo.Checked Then
                matriz(8, indice) = Str(Val(matriz(7, indice) * DescEfectivo))

            End If

            If RadioButtonCheque.Checked Then
                matriz(8, indice) = Str(Val(matriz(7, indice) * DescCheque))

            End If

            Select Case ComboDias.SelectedIndex
                Case 2 : matriz(9, indice) = Str(Val(matriz(7, indice) * DescDias))
            End Select



            matriz(10, indice) = ((Str(Val(matriz(7, indice)) - Val(matriz(8, indice)) - Val(matriz(9, indice)))))


            DataGridView1.Rows.Add(indice + 1, matriz(0, indice), matriz(1, indice), matriz(2, indice), matriz(3, indice), matriz(4, indice), matriz(5, indice), matriz(6, indice), matriz(7, indice), matriz(8, indice), matriz(9, indice), matriz(10, indice))
            indice = indice + 1

            Else
                MessageBox.Show("No hay más espacio")

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If MsgBox("¿Desea salir?", vbYesNo) - vbYes Then
            End
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        LimpiarDatosEntrada()
    End Sub
End Class
