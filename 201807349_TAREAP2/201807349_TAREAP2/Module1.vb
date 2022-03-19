Module Module1
    Public Const PSofa = 250.99
    Public Const PIndividual = 150.99
    Public Const PDoble = 200.99

    Public Const PCuero = 75.0
    Public Const PCuerina = 45.99

    Public numeroventa(8)
    Public tamaño(8)
    Public material(8)
    Public preciomanoobra(8)
    Public preciocosto(8)
    Public precioventa(8)

    Public contador = 0

    Sub Limpiar()
        numeroventa(8) = 0
        tamaño(8) = 0
        material(8) = 0
        preciomanoobra(8) = 0
        preciocosto(8) = 0
        precioventa(8) = 0

        Form1.ComboBox1.SelectedIndex = False
        Form1.ComboBox2.SelectedIndex = False

        Form1.ListBox1.Items.Clear()
        Form1.ListBox2.Items.Clear()
        Form1.ListBox3.Items.Clear()
        Form1.ListBox4.Items.Clear()
        Form1.ListBox5.Items.Clear()
        Form1.ListBox6.Items.Clear()
    End Sub







End Module
