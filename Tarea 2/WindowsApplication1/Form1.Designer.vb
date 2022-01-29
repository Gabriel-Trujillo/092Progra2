<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.textoazucar = New System.Windows.Forms.TextBox()
        Me.textofrijol = New System.Windows.Forms.TextBox()
        Me.textoarroz = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LabelR1 = New System.Windows.Forms.Label()
        Me.LabelR2 = New System.Windows.Forms.Label()
        Me.LabelR3 = New System.Windows.Forms.Label()
        Me.LabelR4 = New System.Windows.Forms.Label()
        Me.LabelR5 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ButtonAceptar = New System.Windows.Forms.Button()
        Me.ButtonLimpiar = New System.Windows.Forms.Button()
        Me.ButtonSalir = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.textoazucar)
        Me.GroupBox1.Controls.Add(Me.textofrijol)
        Me.GroupBox1.Controls.Add(Me.textoarroz)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 22)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(292, 165)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de la compra"
        '
        'textoazucar
        '
        Me.textoazucar.Location = New System.Drawing.Point(157, 111)
        Me.textoazucar.Name = "textoazucar"
        Me.textoazucar.Size = New System.Drawing.Size(100, 22)
        Me.textoazucar.TabIndex = 5
        Me.textoazucar.Text = "0"
        '
        'textofrijol
        '
        Me.textofrijol.Location = New System.Drawing.Point(157, 76)
        Me.textofrijol.Name = "textofrijol"
        Me.textofrijol.Size = New System.Drawing.Size(100, 22)
        Me.textofrijol.TabIndex = 4
        Me.textofrijol.Text = "0"
        '
        'textoarroz
        '
        Me.textoarroz.Location = New System.Drawing.Point(157, 38)
        Me.textoarroz.Name = "textoarroz"
        Me.textoarroz.Size = New System.Drawing.Size(100, 22)
        Me.textoarroz.TabIndex = 3
        Me.textoarroz.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Libras de azucar"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Libras de frijol"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Libras de arroz"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 17)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Pago antes del IVA"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LabelR5)
        Me.GroupBox2.Controls.Add(Me.LabelR4)
        Me.GroupBox2.Controls.Add(Me.LabelR3)
        Me.GroupBox2.Controls.Add(Me.LabelR2)
        Me.GroupBox2.Controls.Add(Me.LabelR1)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(23, 207)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(292, 209)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Resultados en Quetzales (Q)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(28, 73)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 17)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Valor del IVA"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(28, 103)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 17)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Pago con el IVA"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(28, 132)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 17)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Descuento"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(28, 162)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 17)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Pago final"
        '
        'LabelR1
        '
        Me.LabelR1.AutoSize = True
        Me.LabelR1.Location = New System.Drawing.Point(188, 42)
        Me.LabelR1.Name = "LabelR1"
        Me.LabelR1.Size = New System.Drawing.Size(36, 17)
        Me.LabelR1.TabIndex = 6
        Me.LabelR1.Text = "0.00"
        '
        'LabelR2
        '
        Me.LabelR2.AutoSize = True
        Me.LabelR2.Location = New System.Drawing.Point(188, 73)
        Me.LabelR2.Name = "LabelR2"
        Me.LabelR2.Size = New System.Drawing.Size(36, 17)
        Me.LabelR2.TabIndex = 7
        Me.LabelR2.Text = "0.00"
        '
        'LabelR3
        '
        Me.LabelR3.AutoSize = True
        Me.LabelR3.Location = New System.Drawing.Point(188, 103)
        Me.LabelR3.Name = "LabelR3"
        Me.LabelR3.Size = New System.Drawing.Size(36, 17)
        Me.LabelR3.TabIndex = 8
        Me.LabelR3.Text = "0.00"
        '
        'LabelR4
        '
        Me.LabelR4.AutoSize = True
        Me.LabelR4.Location = New System.Drawing.Point(188, 132)
        Me.LabelR4.Name = "LabelR4"
        Me.LabelR4.Size = New System.Drawing.Size(36, 17)
        Me.LabelR4.TabIndex = 9
        Me.LabelR4.Text = "0.00"
        '
        'LabelR5
        '
        Me.LabelR5.AutoSize = True
        Me.LabelR5.Location = New System.Drawing.Point(188, 162)
        Me.LabelR5.Name = "LabelR5"
        Me.LabelR5.Size = New System.Drawing.Size(36, 17)
        Me.LabelR5.TabIndex = 10
        Me.LabelR5.Text = "0.00"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ButtonSalir)
        Me.GroupBox3.Controls.Add(Me.ButtonLimpiar)
        Me.GroupBox3.Controls.Add(Me.ButtonAceptar)
        Me.GroupBox3.Location = New System.Drawing.Point(331, 132)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(200, 165)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Opciones"
        '
        'ButtonAceptar
        '
        Me.ButtonAceptar.Location = New System.Drawing.Point(62, 36)
        Me.ButtonAceptar.Name = "ButtonAceptar"
        Me.ButtonAceptar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonAceptar.TabIndex = 0
        Me.ButtonAceptar.Text = "Aceptar"
        Me.ButtonAceptar.UseVisualStyleBackColor = True
        '
        'ButtonLimpiar
        '
        Me.ButtonLimpiar.Location = New System.Drawing.Point(62, 76)
        Me.ButtonLimpiar.Name = "ButtonLimpiar"
        Me.ButtonLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonLimpiar.TabIndex = 1
        Me.ButtonLimpiar.Text = "Limpiar"
        Me.ButtonLimpiar.UseVisualStyleBackColor = True
        '
        'ButtonSalir
        '
        Me.ButtonSalir.Location = New System.Drawing.Point(62, 111)
        Me.ButtonSalir.Name = "ButtonSalir"
        Me.ButtonSalir.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSalir.TabIndex = 2
        Me.ButtonSalir.Text = "Salir"
        Me.ButtonSalir.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.ClientSize = New System.Drawing.Size(562, 445)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents textoazucar As System.Windows.Forms.TextBox
    Friend WithEvents textofrijol As System.Windows.Forms.TextBox
    Friend WithEvents textoarroz As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents LabelR5 As System.Windows.Forms.Label
    Friend WithEvents LabelR4 As System.Windows.Forms.Label
    Friend WithEvents LabelR3 As System.Windows.Forms.Label
    Friend WithEvents LabelR2 As System.Windows.Forms.Label
    Friend WithEvents LabelR1 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonSalir As System.Windows.Forms.Button
    Friend WithEvents ButtonLimpiar As System.Windows.Forms.Button
    Friend WithEvents ButtonAceptar As System.Windows.Forms.Button

End Class
