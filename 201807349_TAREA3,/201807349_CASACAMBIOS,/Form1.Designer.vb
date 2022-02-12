<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CheckVenta = New System.Windows.Forms.CheckBox()
        Me.CheckCompra = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextVenta = New System.Windows.Forms.TextBox()
        Me.TextCompra = New System.Windows.Forms.TextBox()
        Me.GroupBoxCompra = New System.Windows.Forms.GroupBox()
        Me.CompraDolar = New System.Windows.Forms.RadioButton()
        Me.CompraPesoMexicano = New System.Windows.Forms.RadioButton()
        Me.CompraEuro = New System.Windows.Forms.RadioButton()
        Me.CompraColonesCR = New System.Windows.Forms.RadioButton()
        Me.GroupBoxVenta = New System.Windows.Forms.GroupBox()
        Me.VentaColonesCR = New System.Windows.Forms.RadioButton()
        Me.VentaEuro = New System.Windows.Forms.RadioButton()
        Me.VentaPesoMexicano = New System.Windows.Forms.RadioButton()
        Me.VentaDolar = New System.Windows.Forms.RadioButton()
        Me.ButtonCalcular = New System.Windows.Forms.Button()
        Me.ButtonLimpiar = New System.Windows.Forms.Button()
        Me.ButtonSalir = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBoxCompra.SuspendLayout()
        Me.GroupBoxVenta.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CheckVenta)
        Me.GroupBox1.Controls.Add(Me.CheckCompra)
        Me.GroupBox1.Location = New System.Drawing.Point(31, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(189, 109)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Transacciones"
        '
        'CheckVenta
        '
        Me.CheckVenta.AutoSize = True
        Me.CheckVenta.Location = New System.Drawing.Point(7, 49)
        Me.CheckVenta.Name = "CheckVenta"
        Me.CheckVenta.Size = New System.Drawing.Size(64, 20)
        Me.CheckVenta.TabIndex = 1
        Me.CheckVenta.Text = "Venta"
        Me.CheckVenta.UseVisualStyleBackColor = True
        '
        'CheckCompra
        '
        Me.CheckCompra.AutoSize = True
        Me.CheckCompra.Location = New System.Drawing.Point(7, 22)
        Me.CheckCompra.Name = "CheckCompra"
        Me.CheckCompra.Size = New System.Drawing.Size(77, 20)
        Me.CheckCompra.TabIndex = 0
        Me.CheckCompra.Text = "Compra"
        Me.CheckCompra.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.TextVenta)
        Me.GroupBox2.Controls.Add(Me.TextCompra)
        Me.GroupBox2.Location = New System.Drawing.Point(33, 145)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(187, 96)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Cantidad"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Venta"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Compra"
        '
        'TextVenta
        '
        Me.TextVenta.Enabled = False
        Me.TextVenta.Location = New System.Drawing.Point(68, 51)
        Me.TextVenta.Name = "TextVenta"
        Me.TextVenta.Size = New System.Drawing.Size(100, 22)
        Me.TextVenta.TabIndex = 1
        '
        'TextCompra
        '
        Me.TextCompra.Enabled = False
        Me.TextCompra.Location = New System.Drawing.Point(68, 23)
        Me.TextCompra.Name = "TextCompra"
        Me.TextCompra.Size = New System.Drawing.Size(100, 22)
        Me.TextCompra.TabIndex = 0
        '
        'GroupBoxCompra
        '
        Me.GroupBoxCompra.Controls.Add(Me.CompraColonesCR)
        Me.GroupBoxCompra.Controls.Add(Me.CompraEuro)
        Me.GroupBoxCompra.Controls.Add(Me.CompraPesoMexicano)
        Me.GroupBoxCompra.Controls.Add(Me.CompraDolar)
        Me.GroupBoxCompra.Location = New System.Drawing.Point(226, 64)
        Me.GroupBoxCompra.Name = "GroupBoxCompra"
        Me.GroupBoxCompra.Size = New System.Drawing.Size(200, 154)
        Me.GroupBoxCompra.TabIndex = 2
        Me.GroupBoxCompra.TabStop = False
        Me.GroupBoxCompra.Text = "Compra"
        '
        'CompraDolar
        '
        Me.CompraDolar.AutoSize = True
        Me.CompraDolar.Location = New System.Drawing.Point(22, 37)
        Me.CompraDolar.Name = "CompraDolar"
        Me.CompraDolar.Size = New System.Drawing.Size(61, 20)
        Me.CompraDolar.TabIndex = 0
        Me.CompraDolar.TabStop = True
        Me.CompraDolar.Text = "Dolar"
        Me.CompraDolar.UseVisualStyleBackColor = True
        '
        'CompraPesoMexicano
        '
        Me.CompraPesoMexicano.AutoSize = True
        Me.CompraPesoMexicano.Location = New System.Drawing.Point(22, 64)
        Me.CompraPesoMexicano.Name = "CompraPesoMexicano"
        Me.CompraPesoMexicano.Size = New System.Drawing.Size(121, 20)
        Me.CompraPesoMexicano.TabIndex = 1
        Me.CompraPesoMexicano.TabStop = True
        Me.CompraPesoMexicano.Text = "Peso Mexicano"
        Me.CompraPesoMexicano.UseVisualStyleBackColor = True
        '
        'CompraEuro
        '
        Me.CompraEuro.AutoSize = True
        Me.CompraEuro.Location = New System.Drawing.Point(22, 91)
        Me.CompraEuro.Name = "CompraEuro"
        Me.CompraEuro.Size = New System.Drawing.Size(56, 20)
        Me.CompraEuro.TabIndex = 2
        Me.CompraEuro.TabStop = True
        Me.CompraEuro.Text = "Euro"
        Me.CompraEuro.UseVisualStyleBackColor = True
        '
        'CompraColonesCR
        '
        Me.CompraColonesCR.AutoSize = True
        Me.CompraColonesCR.Location = New System.Drawing.Point(22, 118)
        Me.CompraColonesCR.Name = "CompraColonesCR"
        Me.CompraColonesCR.Size = New System.Drawing.Size(100, 20)
        Me.CompraColonesCR.TabIndex = 3
        Me.CompraColonesCR.TabStop = True
        Me.CompraColonesCR.Text = "Colones CR"
        Me.CompraColonesCR.UseVisualStyleBackColor = True
        '
        'GroupBoxVenta
        '
        Me.GroupBoxVenta.Controls.Add(Me.VentaColonesCR)
        Me.GroupBoxVenta.Controls.Add(Me.VentaEuro)
        Me.GroupBoxVenta.Controls.Add(Me.VentaPesoMexicano)
        Me.GroupBoxVenta.Controls.Add(Me.VentaDolar)
        Me.GroupBoxVenta.Location = New System.Drawing.Point(432, 64)
        Me.GroupBoxVenta.Name = "GroupBoxVenta"
        Me.GroupBoxVenta.Size = New System.Drawing.Size(200, 157)
        Me.GroupBoxVenta.TabIndex = 4
        Me.GroupBoxVenta.TabStop = False
        Me.GroupBoxVenta.Text = "Venta"
        '
        'VentaColonesCR
        '
        Me.VentaColonesCR.AutoSize = True
        Me.VentaColonesCR.Location = New System.Drawing.Point(22, 118)
        Me.VentaColonesCR.Name = "VentaColonesCR"
        Me.VentaColonesCR.Size = New System.Drawing.Size(100, 20)
        Me.VentaColonesCR.TabIndex = 3
        Me.VentaColonesCR.TabStop = True
        Me.VentaColonesCR.Text = "Colones CR"
        Me.VentaColonesCR.UseVisualStyleBackColor = True
        '
        'VentaEuro
        '
        Me.VentaEuro.AutoSize = True
        Me.VentaEuro.Location = New System.Drawing.Point(22, 91)
        Me.VentaEuro.Name = "VentaEuro"
        Me.VentaEuro.Size = New System.Drawing.Size(56, 20)
        Me.VentaEuro.TabIndex = 2
        Me.VentaEuro.TabStop = True
        Me.VentaEuro.Text = "Euro"
        Me.VentaEuro.UseVisualStyleBackColor = True
        '
        'VentaPesoMexicano
        '
        Me.VentaPesoMexicano.AutoSize = True
        Me.VentaPesoMexicano.Location = New System.Drawing.Point(22, 64)
        Me.VentaPesoMexicano.Name = "VentaPesoMexicano"
        Me.VentaPesoMexicano.Size = New System.Drawing.Size(121, 20)
        Me.VentaPesoMexicano.TabIndex = 1
        Me.VentaPesoMexicano.TabStop = True
        Me.VentaPesoMexicano.Text = "Peso Mexicano"
        Me.VentaPesoMexicano.UseVisualStyleBackColor = True
        '
        'VentaDolar
        '
        Me.VentaDolar.AutoSize = True
        Me.VentaDolar.Location = New System.Drawing.Point(22, 37)
        Me.VentaDolar.Name = "VentaDolar"
        Me.VentaDolar.Size = New System.Drawing.Size(61, 20)
        Me.VentaDolar.TabIndex = 0
        Me.VentaDolar.TabStop = True
        Me.VentaDolar.Text = "Dolar"
        Me.VentaDolar.UseVisualStyleBackColor = True
        '
        'ButtonCalcular
        '
        Me.ButtonCalcular.Location = New System.Drawing.Point(273, 246)
        Me.ButtonCalcular.Name = "ButtonCalcular"
        Me.ButtonCalcular.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCalcular.TabIndex = 5
        Me.ButtonCalcular.Text = "Calcular"
        Me.ButtonCalcular.UseVisualStyleBackColor = True
        '
        'ButtonLimpiar
        '
        Me.ButtonLimpiar.Location = New System.Drawing.Point(391, 246)
        Me.ButtonLimpiar.Name = "ButtonLimpiar"
        Me.ButtonLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonLimpiar.TabIndex = 6
        Me.ButtonLimpiar.Text = "Limpiar"
        Me.ButtonLimpiar.UseVisualStyleBackColor = True
        '
        'ButtonSalir
        '
        Me.ButtonSalir.Location = New System.Drawing.Point(500, 246)
        Me.ButtonSalir.Name = "ButtonSalir"
        Me.ButtonSalir.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSalir.TabIndex = 7
        Me.ButtonSalir.Text = "Salir"
        Me.ButtonSalir.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(653, 299)
        Me.Controls.Add(Me.ButtonSalir)
        Me.Controls.Add(Me.ButtonLimpiar)
        Me.Controls.Add(Me.ButtonCalcular)
        Me.Controls.Add(Me.GroupBoxVenta)
        Me.Controls.Add(Me.GroupBoxCompra)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBoxCompra.ResumeLayout(False)
        Me.GroupBoxCompra.PerformLayout()
        Me.GroupBoxVenta.ResumeLayout(False)
        Me.GroupBoxVenta.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CheckVenta As CheckBox
    Friend WithEvents CheckCompra As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextVenta As TextBox
    Friend WithEvents TextCompra As TextBox
    Friend WithEvents GroupBoxCompra As GroupBox
    Friend WithEvents CompraColonesCR As RadioButton
    Friend WithEvents CompraEuro As RadioButton
    Friend WithEvents CompraPesoMexicano As RadioButton
    Friend WithEvents CompraDolar As RadioButton
    Friend WithEvents GroupBoxVenta As GroupBox
    Friend WithEvents VentaColonesCR As RadioButton
    Friend WithEvents VentaEuro As RadioButton
    Friend WithEvents VentaPesoMexicano As RadioButton
    Friend WithEvents VentaDolar As RadioButton
    Friend WithEvents ButtonCalcular As Button
    Friend WithEvents ButtonLimpiar As Button
    Friend WithEvents ButtonSalir As Button
End Class
