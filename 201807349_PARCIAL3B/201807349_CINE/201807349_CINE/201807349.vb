Module _201807349
    Public x(7, 4)
    Public film As Byte = 0
    Public Const var = 7

    Public Q As Double

    Public iosp As Byte = 0

    Sub mnsidp()
        Form1.nitcliente.Clear()
        Form1.Pelicula.Clear()
        Form1.Boletas.Clear()
        Form1.Normal.Checked = False
        Form1.tresd.Checked = False
        Form1.cuatrod.Checked = False
    End Sub

    Sub dsqohg()
        Form1.listado.Rows.Clear()

        film = 0
        iosp = 0
        While (iosp <= 6)
            x(iosp, 0) = Nothing
            x(iosp, 1) = Nothing
            x(iosp, 2) = Nothing
            x(iosp, 3) = Nothing
            x(iosp, 4) = Nothing
            iosp = iosp + 1
        End While
    End Sub
End Module
