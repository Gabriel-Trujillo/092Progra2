Public Class Form1
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        salir()
    End Sub

    Private Sub LimpiarSalidasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarSalidasToolStripMenuItem.Click
        limpiar_entradas()

    End Sub

    Private Sub LimpiarVectoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarVectoresToolStripMenuItem.Click
        Limpiar_Vectores()
    End Sub

    Private Sub CalcularToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalcularToolStripMenuItem.Click
        TotalFinal()
        MostrarTotales()
        posicion = posicion + 1


    End Sub
End Class
