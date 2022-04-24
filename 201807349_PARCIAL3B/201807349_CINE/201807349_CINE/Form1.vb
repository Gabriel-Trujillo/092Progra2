Public Class Form1
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Dim R = MsgBox("desea salir", vbQuestion + vbYesNo, "mensaje salida")

        If R = vbYes Then
            Me.Close()

        Else
            dsqohg()
            mnsidp()
        End If
    End Sub

    Private Sub CalcularToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalcularToolStripMenuItem.Click
        If film <= 6 Then

            x(film, 0) = Val(nitcliente.Text)
            x(film, 1) = Pelicula.Text
            x(film, 3) = Val(Boletas.Text)

            If Normal.Checked Then

                x(film, 2) = "normal"
                Q = 44
            ElseIf tresd.Checked Then

                x(film, 2) = "tres de"
                Q = 62
            ElseIf cuatrod.Checked Then
                x(film, 2) = "cuatro de"
                Q = 104
            Else
                MsgBox("NO SELECCIONO SALA")

            End If

            x(film, 4) = Q * x(film, 3)

            film = film + 1
            mnsidp()
        End If

        If film = 7 Then
            MsgBox("Se lleno la matriz")
        End If
    End Sub

    Private Sub MostrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MostrarToolStripMenuItem.Click
        listado.Rows.Clear()

        iosp = 0

        While (iosp <= 4)

            If (x(iosp, 0) <> Nothing) Then
                listado.Rows.Add(x(iosp, 0), x(iosp, 1), x(iosp, 2), x(iosp, 3), x(iosp, 4))
            Else
                Exit While
            End If

            iosp = iosp
        End While
    End Sub

    Private Sub BuscarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuscarToolStripMenuItem.Click
        Dim I As Byte = 0
        Dim EXISTE As Boolean = True

        While (I <= 4) And (EXISTE)
            If (Val(x(I, 0)) = Val(nitcliente.Text)) Then
                EXISTE = False
            Else
                I = I + 1
            End If
        End While

        If (EXISTE) Then
            MsgBox("Número de factura no encontrado")
        Else
            nitcliente.Text = x(I, 0)
            listado.Rows.Clear()
            listado.Rows.Add(x(iosp, 0), x(iosp, 1), x(iosp, 2), x(iosp, 3), x(iosp, 4))

            iosp = I

            nitcliente.Clear()

        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
