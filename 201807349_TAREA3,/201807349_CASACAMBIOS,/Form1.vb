Public Class Form1
    Private Sub Checkcompra_CheckedChanged(sender As Object, e As EventArgs) Handles CheckCompra.CheckedChanged
        If CheckCompra.Checked = True Then
            TextCompra.Enabled = True
        Else
            TextCompra.Enabled = False

        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckVenta.CheckedChanged
        If CheckVenta.Checked = True Then
            TextVenta.Enabled = True
        Else
            TextVenta.Enabled = False

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonCalcular.Click
        Form2.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ButtonLimpiar.Click
        Limpiar()

    End Sub

    Private Sub ButtonSalir_Click(sender As Object, e As EventArgs) Handles ButtonSalir.Click
        MsgBox("¿Desea salir?", vbQuestion + vbYesNo)
        If MsgBox("¿Desea salir?", vbQuestion + vbYesNo) = vbYes Then

            End





        End If
    End Sub
End Class
