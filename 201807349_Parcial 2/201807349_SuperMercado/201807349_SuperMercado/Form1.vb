Imports System.Math
Public Class Form1
    Private Sub AceptarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AceptarToolStripMenuItem.Click
        If z <= 5 Then

            NoInvent(z) = Val(TextBox1.Text)
            NoPedido(z) = Val(TextBox2.Text)
            cond = NoInvent(z) / NoPedido(z)

            If NoInvent(z) >= NoPedido(6) Then
                limit = NoInvent(z) Mod NoPedido(z)
            Else
                MsgBox("Lo sentimos, No se puede Operar")
            End If

            If RadioButton1.Checked Then
                NomProducto(z) = "jugos"
                If cond >= 1 And cond <= 3 Then
                    DescPrev = NoInvent(z) - limit
                    valor = (DescPrev * 8.5)
                    DescTotal(z) = (DescPrev * 8.5) * (3 / 100)
                ElseIf cond > 3 And cond <= 5 Then
                    DescPrev = NoInvent(z) - limit
                    valor = (DescPrev * 8.5)
                    DescTotal(z) = (DescPrev * 8.5) * (5 / 100)
                ElseIf cond > 10 Then
                    DescPrev = NoInvent(z) - limit
                    valor = (DescPrev * 8.5)
                    DescTotal(z) = (DescPrev * 8.5) * (10 / 100)
                End If
            ElseIf RadioButton2.Checked Then
                NomProducto(z) = "frturas"
                If cond >= 1 And cond <= 3 Then
                    DescPrev = NoInvent(z) - limit
                    valor = (DescPrev * 11.2)
                    DescTotal(z) = (DescPrev * 11.2) * (3 / 100)
                ElseIf cond > 3 And cond <= 5 Then
                    DescPrev = NoInvent(z) - limit
                    valor = (DescPrev * 11.2)
                    DescTotal(z) = (DescPrev * 11.2) * (5 / 100)
                ElseIf cond > 10 Then
                    DescPrev = NoInvent(z) - limit
                    valor = (DescPrev * 11.2)
                    DescTotal(z) = (DescPrev * 11.2) * (10 / 100)
                End If
            ElseIf RadioButton3.Checked Then
                NomProducto(z) = "galletas"

                If cond >= 1 And cond <= 3 Then
                    DescPrev = NoInvent(z) - limit
                    valor = (DescPrev * 4.25)
                    DescTotal(z) = (DescPrev * 4.25) * (3 / 100)
                ElseIf cond > 3 And cond <= 5 Then
                    DescPrev = NoInvent(z) - limit
                    valor = (DescPrev * 4.25)
                    DescTotal(z) = (DescPrev * 4.25) * (5 / 100)
                ElseIf cond > 10 Then
                    DescPrev = NoInvent(z) - limit
                    valor = (DescPrev * 4.25)
                    DescTotal(z) = (DescPrev * 4.25) * (10 / 100)
                End If
            ElseIf RadioButton4.Checked Then
                NomProducto(z) = "baterias"

                If cond >= 1 And cond <= 3 Then
                    DescPrev = NoInvent(z) - limit
                    valor = (DescPrev * 15)
                    DescTotal(z) = (DescPrev * 15) * (3 / 100)
                ElseIf cond > 3 And cond <= 5 Then
                    DescPrev = NoInvent(z) - limit
                    valor = (DescPrev * 15)
                    DescTotal(z) = (DescPrev * 15) * (5 / 100)
                ElseIf cond > 10 Then
                    DescPrev = NoInvent(z) - limit
                    valor = (DescPrev * 15)
                    DescTotal(z) = (DescPrev * 15) * (10 / 100)
                End If

            End If


            TotPagar(z) = valor - DescTotal(z)

            z = z + 1
            TextBox1.Clear()
            TextBox2.Clear()
            RadioButton1.Checked = False
            RadioButton2.Checked = False
            RadioButton3.Checked = False
            RadioButton4.Checked = False
        End If
    End Sub

    Private Sub MostrarDataGriedViewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MostrarDataGriedViewToolStripMenuItem.Click
        Dim asc As Byte
        DataGridView1.Rows.Clear()
        For asc = 0 To 7
            If (NoInvent(asc) <> Nothing) Then
                DataGridView1.Rows.Add(NoInvent(asc), NoPedido(asc), NomProducto(asc), Round(DescTotal(asc), 2), Round(TotPagar(asc), 2))
            Else
                Exit For
            End If
        Next asc
    End Sub

    Private Sub LimpiarVectoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarVectoresToolStripMenuItem.Click
        Dim qwe As Byte
        DataGridView1.Rows.Clear()
        For I = 0 To 7
            NoInvent(qwe) = Nothing
            NoPedido(qwe) = Nothing
            NomProducto(qwe) = Nothing
            DescTotal(qwe) = Nothing
            TotPagar(qwe) = Nothing


        Next I
        z = 0
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click

        If (MsgBox("DESEA SALIR", vbQuestion + vbYesNo, "Mensaje Salida") = vbYes) Then
            End
        Else
            Dim qwe As Byte
            DataGridView1.Rows.Clear()
            For I = 0 To 7
                NoInvent(qwe) = Nothing
                NoPedido(qwe) = Nothing
                NomProducto(qwe) = Nothing
                DescTotal(qwe) = Nothing
                TotPagar(qwe) = Nothing


            Next I
            z = 0
            TextBox1.Clear()
            TextBox2.Clear()
            RadioButton1.Checked = False
            RadioButton2.Checked = False
            RadioButton3.Checked = False
            RadioButton4.Checked = False
        End If
    End Sub
End Class
