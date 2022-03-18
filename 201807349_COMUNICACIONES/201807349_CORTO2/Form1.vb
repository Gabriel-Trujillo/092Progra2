Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (Posicion <= 7) Then
            If (TextBox1.Text <> "") And (TextBox2.Text <> "") Then
                NombreEmpleado(Posicion) = TextBox1.Text
            Else
                MsgBox("Datos incorrectos")
                TextBox1.Focus()

            End If
        End If

        SueldoBruto(Posicion) = TextBox2.Text






    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Limpiar()
    End Sub
End Class
