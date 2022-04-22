Public Class Form1

    Public Const PrecioSencilla = 250
    Public Const PrecioDoble = 400
    Public Const PrecioCabaña = 650

    Public Const DescEfectivo = 0.15
    Public Const RecTarjeta = 0.03


    Public contador = 0
    Public Nombrecliente(7)
    Public Días(7)
    Public TipoHabitacion(7)
    Public Tipopago(7)

    Sub Limpiar()

        Public Nombrecliente(7) = 0
        Public Días(7) = 0
        Public TipoHabitacion(7) = 0
        Public Tipopago(7) = 0
    End Sub



    Private Sub CálculoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CálculoToolStripMenuItem.Click

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
                        Case "Sencilla"
                            (contador) = Psencilla
                            preciocosto(contador) = 8 * Psencilla + DescEfectivo(contador)
                        Case "Doble"
                    End Select
                Case "Doble"
                    Select Case Doble(contador)
                        Case "Doble"
                            PrecioDoble(contador) = Pdoble
                            preciocosto(contador) = 8 * Pdoble + RecTarjeta(contador)
                        Case "Doble"
                    End Select

                Case "Cabaña"
                    Select Case Tipopago(contador)
                        Case "Efectivo"
                            PrecioCabaña(contador) = PrecioCabaña
                            PrecioCabaña(contador) = 8 * PrecioCabaña + RecTarjeta(contador)
                        Case "Cuerina"
                    End Select

            End Select


    End Sub

    Private Sub LimpiarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarToolStripMenuItem.Click
        Limpiar()
    End Sub
End Class
