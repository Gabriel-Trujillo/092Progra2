Module Module1

    Public posicion As Byte = 0


    Public Pago(6) As Double
    Public Descuento(6) As Double
    Public Recargo(6) as Double
    Public Total(6) As Double
    Public Paciente(6) As String
    Public Nit(6) As Byte
    Public DiasHosp(6) as byte
    Public Honorarios(6) as Double
    Public Habitacion(6) As String
    Public Servicio(6) As String
    Public FormaPago(6) As String
    Public Parcial(6) As Double



    Public Const PrecioEncamamientoPrivada = 350
    Public Const PrecioEncamamientoSemi = 250
    Public Const PrecioEncamamientoNoPrivada = 150
    Public Const PrecioOperacionPrivada = 550
    Public Const PrecioOperacionSemi = 400
    Public Const PrecioOperacionNoprivada = 300
    Public Const PrecioMaternidadPrivada = 450
    Public Const PrecioMaternidadSemi = 350
    Public Const PrecioMaternidadNoprivada = 250

    Public Const DescuentoChequeEfectivo = 0.15
    Public Const RecargoTarjetaDebito = 0.08
    Public Const RecargoTarjetaCredito = 0.05

    Sub salir()
        If (MsgBox("DESEA SALIR", vbQuestion + vbYesNo, "mensaje de salida") = vbYes) Then
            End
        Else
            limpiar_entradas()
            LIMPIAR_VECTORES()
        End If
    End Sub
    Sub limpiar_entradas()
        Form1.TextBox1.Clear()
        Form1.TextBox2.Clear()
        Form1.TextBox3.Clear()
        Form1.RadioButton1.Checked = 0
        Form1.RadioButton2.Checked = 0
        Form1.RadioButton3.Checked = 0
        Form1.RadioButton4.Checked = 0
        Form1.RadioButton5.Checked = 0
        Form1.RadioButton6.Checked = 0
        Form1.RadioButton7.Checked = 0
        Form1.CheckBox1.Checked = 0
        Form1.CheckBox2.Checked = 0
        Form1.CheckBox3.Checked = 0

    End Sub

    Sub Limpiar_Vectores()

        Form1.ListBox1.Items.Clear()
        Form1.ListBox2.Items.Clear()
        Form1.ListBox3.Items.Clear()
        Form1.ListBox4.Items.Clear()
        Form1.ListBox5.Items.Clear()
        Form1.ListBox6.Items.Clear()
        Form1.ListBox7.Items.Clear()
        Form1.ListBox8.Items.Clear()


        Form1.ListBox11.Items.Clear()


    End Sub

    Function CalcularDescuentoRecargo() As Double
        Dim desc As Double
        Dim recargo As Double


        If Form1.RadioButton4.Checked Or Form1.RadioButton5.Checked Then
            FormaPago(posicion) = Form1.RadioButton4.Text
            desc = Parcial(posicion) * DescuentoChequeEfectivo
            Return desc * -1
        ElseIf Form1.RadioButton6.Checked Then
            FormaPago(posicion) = Form1.RadioButton6.Text
            recargo = Parcial(posicion) * RecargoTarjetaCredito
            Return recargo
        ElseIf Form1.RadioButton7.Checked Then
            FormaPago(posicion) = Form1.RadioButton7.Text
            recargo = Parcial(posicion) * RecargoTarjetaDebito
            Return recargo



        End If
    End Function
    Sub TipoHabitacion()
        If Form1.RadioButton1.Checked Then
            Habitacion(posicion) = Form1.RadioButton1.Text
        ElseIf Form1.RadioButton2.Checked Then
            Habitacion(posicion) = Form1.RadioButton2.Text
        ElseIf Form1.RadioButton3.Checked Then
            Habitacion(posicion) = Form1.RadioButton3.Text

        End If
    End Sub

    Sub TipoServicio()
        If Form1.CheckBox1.Checked Then
            Servicio(posicion) = Form1.CheckBox1.Text
        ElseIf Form1.CheckBox2.Checked Then
            Servicio(posicion) = Form1.CheckBox2.Text
        ElseIf Form1.CheckBox3.Checked Then
            Servicio(posicion) = Form1.CheckBox3.Text
        Else


        End If
    End Sub

    Sub CalculoParcial()
        If Form1.RadioButton1.Checked And Form1.CheckBox1.Checked Then
            Parcial(posicion) = PrecioEncamamientoPrivada
        ElseIf Form1.RadioButton1.Checked And Form1.CheckBox2.Checked Then
            Parcial(posicion) = PrecioOperacionPrivada
        ElseIf Form1.RadioButton1.Checked And Form1.CheckBox3.Checked Then
            Parcial(posicion) = PrecioMaternidadPrivada

        ElseIf Form1.RadioButton2.Checked And Form1.CheckBox1.Checked Then
            Parcial(posicion) = PrecioEncamamientoSemi
        ElseIf Form1.RadioButton2.Checked And Form1.CheckBox2.Checked Then
            Parcial(posicion) = PrecioOperacionSemi
        ElseIf Form1.RadioButton2.Checked And Form1.CheckBox3.Checked Then
            Parcial(posicion) = PrecioMaternidadSemi

        ElseIf Form1.RadioButton3.Checked And Form1.CheckBox1.Checked Then
            Parcial(posicion) = PrecioEncamamientoNoPrivada
        ElseIf Form1.RadioButton3.Checked And Form1.CheckBox2.Checked Then
            Parcial(posicion) = PrecioOperacionNoprivada
        ElseIf Form1.RadioButton3.Checked And Form1.CheckBox3.Checked Then
            Parcial(posicion) = PrecioMaternidadNoprivada

        End If

    End Sub
    Function TotalFinal() As Double
        TotalFinal = Parcial(posicion) + Descuento(posicion)
        Return TotalFinal



    End Function

    Sub MostrarTotales()

        Form1.ListBox1.Items.Add(Paciente(posicion))
        Form1.ListBox2.Items.Add(Nit(posicion))
        Form1.ListBox3.Items.Add(DiasHosp(posicion))
        Form1.ListBox4.Items.Add(Habitacion(posicion))
        Form1.ListBox5.Items.Add(Servicio(posicion))
        Form1.ListBox6.Items.Add(Parcial(posicion))
        Form1.ListBox7.Items.Add(Recargo(posicion))
        Form1.ListBox8.Items.Add(Descuento(posicion))
        Form1.ListBox11.Items.Add(Total(posicion))




    End Sub


End Module
