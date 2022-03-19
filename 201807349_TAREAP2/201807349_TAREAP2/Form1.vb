Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.SelectedIndex = -1 Or ComboBox2.SelectedIndex = -1 Then
            MsgBox("No seleccionó todos los datos")
            Exit Sub

        End If
        If contador < 8 Then

            numeroventa(contador) = contador + 1

            tamaño(contador) = ComboBox1.SelectedItem
            material(contador) = ComboBox2.SelectedItem


            Select Case tamaño(contador)
                Case "Sofá"
                    Select Case material(contador)
                        Case "Cuero"
                            preciomanoobra(contador) = PSofa
                            preciocosto(contador) = 8 * PCuero + preciomanoobra(contador)
                        Case "Cuerina"
                    End Select
                Case "Individual"
                    Select Case material(contador)
                        Case "Cuero"
                            preciomanoobra(contador) = PSofa
                            preciocosto(contador) = 8 * PCuero + preciomanoobra(contador)
                        Case "Cuerina"
                    End Select

                Case "Doble"
                    Select Case material(contador)
                        Case "Cuero"
                            preciomanoobra(contador) = PSofa
                            preciocosto(contador) = 8 * PCuero + preciomanoobra(contador)
                        Case "Cuerina"
                    End Select

            End Select


            precioventa(contador) = preciocosto(contador) * 1.65



            ListBox1.Items.Add(numeroventa(contador))
            ListBox2.Items.Add(tamaño(contador))
            ListBox3.Items.Add(material(contador))
            ListBox4.Items.Add(preciomanoobra(contador))
            ListBox5.Items.Add(preciocosto(contador))
            ListBox6.Items.Add(precioventa(contador))

            contador = contador + 1

        Else
            MsgBox("Límite alcanzado")
        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Limpiar()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub
End Class
