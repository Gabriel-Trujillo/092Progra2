Module Declaraciones
    
    Public Kilometrajeinicial(5) As Double
    Public Kilometrajefinal(5) As Double
    Public Placa(4) As Byte
    Public Pagoinicial(4) As Double
    Public Pagofinal(4) As Double
    Public Tipoauto(4) As Integer
    Public Cobro(4) As Double


    Public fila As Byte = 0

    Public Const N = 3

    Public I As Byte




    Sub salir()
        If MsgBox("¿Desea Salir?", vbQuestion + vbYesNo, "Mensaje Salida") = vbYes Then
            Form1.Close()
        Else
            Limpiar_entradas()
            Limpiar_estadisticas()
        End If
    End Sub
    Sub limpiar_entradas()
        Form1.TextBox1.Clear()
        Form1.TextBox2.Clear()
        Form1.TextBox3.Clear()
        Form1.TextBox4.Clear()
        Form1.TextBox5.Clear()
        Form1.ComboBox1.Text = ""
        Form1.TextBox1.Focus()
    End Sub
   
    Sub Mostrar_vectores()

        Form1.DataGridView1.Rows.Clear()
        For I = 0 To 4

            If (Carnet(I) <> Nothing) Then
                Form1.DataGridView1.Rows.Add(Str(Carnet(I)), Nombre(I), Str(Nota1(I)), Str(Nota2(I)), Str(Nota3(I)), Curso(I), Str(Promedio(I)))
            Else

                Exit For
            End If
        Next I

    End Sub
    Sub limpiar_vectores()

        Form1.DataGridView1.Rows.Clear()

        fila = 0

        For I = 0 To 4

            Carnet(I) = Nothing
            Nombre(I) = Nothing
            Nota1(I) = Nothing
            Nota2(I) = Nothing
            Nota3(I) = Nothing
            Curso(I) = Nothing
            Promedio(I) = Nothing
        Next I

    End Sub
End Module
