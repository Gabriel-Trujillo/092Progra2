Imports System.Math
Public Class Form1

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ToolStripMenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem8.Click

        Call salir()

    End Sub

    Private Sub ToolStripMenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem6.Click

        limpiar_vectores()

    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click

        Mostrar_vectores()

    End Sub

    Private Sub ToolStripMenuItem1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click

        If (fila <= 4) Then
            Kilometrajefinal(fila) = Val(TextBox1.Text)
            Kilometrajefinal(fila) = TextBox2.Text
            Placa(fila) = Val(TextBox3.Text)
            Cobro(fila) = Val(TextBox4.Text)
            Pagoinicial(fila) = Val(TextBox5.Text)
            Pagofinal(fila) = ComboBox1.Text
            Tipoauto(fila) = Round(((Nota1(fila) + Nota2(fila) + Nota3(fila)) / N), 2)
            fila = fila + 1
            limpiar_entradas()
        End If
        If (fila = 5) Then
            MsgBox("vectores llenos")
        End If
    End Sub

    Private Sub ToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem3.Click
       
        Dim existe As Boolean = False

        I = 0
       
        
        While (I <= 4) And Not (existe)
            
            If (Placa(I) = Val(TextBox9.Text)) Then
                existe = True
            Else
                I = I + 1
            End If
        End While

      
        If (existe) Then
            MsgBox("Registro Encontrado exitosamente")
            
            TextBox1.Text = Str(Kilometrajeinicial(I))
            TextBox2.Text = Placa(I)
            TextBox3.Text = Str(Kilometrajefinal(I))
            TextBox4.Text = Str(Cobro(I))
            TextBox5.Text = Str(Pagofinal(I))
            ComboBox1.Text = Pagoinicial(I)
          
            DataGridView1.Rows.Clear()
            DataGridView1.Rows.Add(Str(Kilometrajeinicial(I)), Kilometrajefinal(I), Str(Placa(I)), Str(Tipoauto(I)), Str(Cobro(I)), Pagoinicial(I), Str(Pagofinal(I)))
           
            fila = I
        Else
            MsgBox("Carnet no encontrado")
            TextBox9.Focus()
        End If

    End Sub

    Private Sub ToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem4.Click
       

        Placa(fila) = Val(TextBox1.Text)
        Tipoauto(fila) = TextBox2.Text
        Kilometrajeinicial(fila)) = Val(TextBox3.Text)
        Cobro(fila) = Val(TextBox4.Text)
        Pagoinicial(fila) = Val(TextBox5.Text)
        Kilometrajefinal(fila) = ComboBox1.Text
        Pagofinal(fila) = Round(((Nota1(fila) + Nota2(fila) + Nota3(fila)) / N), 2)

        MsgBox("Registro actualizado correctamente en los vectores")
        
        fila = 5
    End Sub

    Private Sub ToolStripMenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
       
        Dim Pago As Integer = 0
        

    End Sub

    Private Sub ToolStripMenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem5.Click
     
        Placa(fila) = Nothing
        Tipoauto(fila) = Nothing
        Kilometrajeinicial(fila) = Nothing
        Kilometrajefinal(fila) = Nothing
        Cobro(fila) = Nothing
        Pagoinicial(fila) = Nothing
        Pagofinal(fila) = Nothing

       
        For I = fila To 3
           
            Placa(I) = Placa(I + 1)
            Tipoauto(I) = Tipoauto(I + 1)
            Kilometrajeinicial(I) = Kilometrajeinicial(I + 1)
            Kilometrajefinal(I) = Kilometrajefinal(I + 1)
            Cobro(I) = Cobro(I + 1)
            Pagoinicial(I) = Pagoinicial(I + 1)
            Pagofinal(I) = Pagofinal(I + 1)
        Next I
        MsgBox("Registro Eliminado exitosamente")
        
        Placa(I) = Nothing
        Tipoauto(I) = Nothing
        Kilometrajeinicial(I) = Nothing
        Kilometrajefinal(I) = Nothing
        Cobro(I) = Nothing
        Pagoinicial(I) = Nothing
        Pagofinal(I) = Nothing
      
        fila = I
        limpiar_entradas()
        DataGridView1.Rows.Clear()
    End Sub

    Private Sub ToolStripMenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        limpiar_estadisticas()
    End Sub


    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
