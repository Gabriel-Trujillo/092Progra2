Module Module1
    'Constantes
    Public Const PrecioTablet = 375.0
    Public Const PrecioDrone = 560.0
    Public Const PrecioCelular = 1450.0
    Public Const PrecioTelevisor = 3250.0
    Public Const Comis = 0.055
    Public Const BonoIncentivo1 = 0.03
    Public Const BonoIncentivo2 = 0.04
    Public Const BonoIncentivo3 = 0.05

    Public Posicion As Byte = 0
    Public NombreEmpleado(7) As String
    Public SueldoBruto(7) As Double
    Public Comision(7) As Double
    Public bono(7) As Double
    Public SueldoFinal(7) As Double



    Sub Limpiar()
        Form1.Nombre.Items.Clear()
        Form1.Valor.Items.Clear()
        Form1.ComisiónEmpleado.Items.Clear()
        Form1.Bono.Items.Clear()
        Form1.SueldoFinal.Items.Clear()

    End Sub

    Sub CalculoComision()
        If Form1.RadioButton1.Checked Then
            Comision(Posicion) = PrecioCelular * SueldoBruto(Posicion) * Comis
        End If
        If Form1.RadioButton2.Checked Then
            Comision(Posicion) = PrecioDrone * SueldoBruto(Posicion) * Comis
        End If
        If Form1.RadioButton3.Checked Then
            Comision(Posicion) = PrecioTablet * SueldoBruto(Posicion) * Comis
        End If
        If Form1.RadioButton4.Checked Then
            Comision(Posicion) = PrecioTelevisor * SueldoBruto(Posicion) * Comis
        End If
    End Sub

    Sub CalculoBono()
        bono(Posicion) = Comis * SueldoBruto(Posicion)
    End Sub

    Sub() MostrarTotales()
        Form1.Nombre.Items.Add(NombreEmpleado(Posicion))
        Form1.Valor.Items.Add(SueldoBruto(Posicion))
        Form1.ComisiónEmpleado.Items.Add(Comision(Posicion))
        Form1.Bono.Items.Add(bono(Posicion))
        Form1.SueldoFinal.Items.Add(SueldoFinal(Posicion))
    End Sub




End Module
