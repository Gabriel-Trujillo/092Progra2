Module Module1

    Public matriz(10, 7)
    Public indice = 0

    Public Const Ingles = 150
    Public Const Portugues = 80
    Public Const Frances = 125
    Public Const DescEfectivo = 0.02
    Public Const DescCheque = 0.015
    Public Const DescDias = 0.05

    Sub LimpiarDatosEntrada()
        Form1.TextCarne.Clear()
        Form1.TextNombre.Clear()
        Form1.TextHoras.Clear()
        Form1.RadioButtonCheque.Checked = False
        Form1.RadioButtonEfectivo.Checked = False


        Form1.ComboDias.SelectedItem = Nothing
        Form1.ComboIdioma.SelectedItem = Nothing


    End Sub
    Sub LimpiarResultados()
        matriz(0, indice) = 0
        matriz(1, indice) = 0
        matriz(2, indice) = 0
        matriz(3, indice) = 0
        matriz(4, indice) = 0
        matriz(5, indice) = 0
        matriz(6, indice) = 0
        matriz(7, indice) = 0
        matriz(8, indice) = 0
        matriz(9, indice) = 0
        matriz(10, indice) = 0

        Form1.DataGridView1.Rows.Clear()
    End Sub


End Module
