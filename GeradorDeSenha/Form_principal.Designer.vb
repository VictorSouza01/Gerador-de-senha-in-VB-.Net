<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_principal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_principal))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_qtd = New System.Windows.Forms.NumericUpDown()
        Me.txt_erroCopia = New System.Windows.Forms.Label()
        Me.txt_copiado = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Checked_tudo = New System.Windows.Forms.CheckBox()
        Me.checked_numeros = New System.Windows.Forms.CheckBox()
        Me.checked_mm = New System.Windows.Forms.CheckBox()
        Me.checked_car = New System.Windows.Forms.CheckBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txt_senha = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btn_close = New System.Windows.Forms.Button()
        Me.btn_minimize = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.txt_qtd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txt_qtd)
        Me.Panel1.Controls.Add(Me.txt_erroCopia)
        Me.Panel1.Controls.Add(Me.txt_copiado)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Checked_tudo)
        Me.Panel1.Controls.Add(Me.checked_numeros)
        Me.Panel1.Controls.Add(Me.checked_mm)
        Me.Panel1.Controls.Add(Me.checked_car)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.txt_senha)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.ForeColor = System.Drawing.Color.AliceBlue
        Me.Panel1.Location = New System.Drawing.Point(-56, 26)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(684, 368)
        Me.Panel1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(467, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 17)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "In VB .Net"
        '
        'txt_qtd
        '
        Me.txt_qtd.Location = New System.Drawing.Point(583, 231)
        Me.txt_qtd.Maximum = New Decimal(New Integer() {14, 0, 0, 0})
        Me.txt_qtd.Minimum = New Decimal(New Integer() {6, 0, 0, 0})
        Me.txt_qtd.Name = "txt_qtd"
        Me.txt_qtd.Size = New System.Drawing.Size(63, 20)
        Me.txt_qtd.TabIndex = 15
        Me.txt_qtd.Value = New Decimal(New Integer() {6, 0, 0, 0})
        '
        'txt_erroCopia
        '
        Me.txt_erroCopia.AutoSize = True
        Me.txt_erroCopia.Location = New System.Drawing.Point(107, 309)
        Me.txt_erroCopia.Name = "txt_erroCopia"
        Me.txt_erroCopia.Size = New System.Drawing.Size(125, 13)
        Me.txt_erroCopia.TabIndex = 14
        Me.txt_erroCopia.Text = "Não há nada para copiar"
        Me.txt_erroCopia.Visible = False
        '
        'txt_copiado
        '
        Me.txt_copiado.AutoSize = True
        Me.txt_copiado.Location = New System.Drawing.Point(107, 309)
        Me.txt_copiado.Name = "txt_copiado"
        Me.txt_copiado.Size = New System.Drawing.Size(55, 13)
        Me.txt_copiado.TabIndex = 13
        Me.txt_copiado.Text = "Copiado!!!"
        Me.txt_copiado.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(575, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(70, 53)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Checked_tudo
        '
        Me.Checked_tudo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Checked_tudo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Checked_tudo.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Checked_tudo.Location = New System.Drawing.Point(68, 231)
        Me.Checked_tudo.Name = "Checked_tudo"
        Me.Checked_tudo.Size = New System.Drawing.Size(203, 28)
        Me.Checked_tudo.TabIndex = 8
        Me.Checked_tudo.Text = "Tudo"
        Me.Checked_tudo.UseVisualStyleBackColor = True
        '
        'checked_numeros
        '
        Me.checked_numeros.Cursor = System.Windows.Forms.Cursors.Hand
        Me.checked_numeros.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.checked_numeros.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checked_numeros.Location = New System.Drawing.Point(68, 130)
        Me.checked_numeros.Name = "checked_numeros"
        Me.checked_numeros.Size = New System.Drawing.Size(203, 28)
        Me.checked_numeros.TabIndex = 7
        Me.checked_numeros.Text = "Números"
        Me.checked_numeros.UseVisualStyleBackColor = True
        '
        'checked_mm
        '
        Me.checked_mm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.checked_mm.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.checked_mm.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checked_mm.Location = New System.Drawing.Point(68, 198)
        Me.checked_mm.Name = "checked_mm"
        Me.checked_mm.Size = New System.Drawing.Size(230, 28)
        Me.checked_mm.TabIndex = 6
        Me.checked_mm.Text = "Letras maiusculas e minusculas"
        Me.checked_mm.UseVisualStyleBackColor = True
        '
        'checked_car
        '
        Me.checked_car.Cursor = System.Windows.Forms.Cursors.Hand
        Me.checked_car.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.checked_car.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checked_car.Location = New System.Drawing.Point(68, 164)
        Me.checked_car.Name = "checked_car"
        Me.checked_car.Size = New System.Drawing.Size(203, 28)
        Me.checked_car.TabIndex = 5
        Me.checked_car.Text = "Caracteres especiais"
        Me.checked_car.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Location = New System.Drawing.Point(68, 301)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(31, 28)
        Me.Button2.TabIndex = 4
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Gray
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Location = New System.Drawing.Point(583, 257)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(63, 51)
        Me.Button1.TabIndex = 3
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txt_senha
        '
        Me.txt_senha.Font = New System.Drawing.Font("Bahnschrift", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_senha.Location = New System.Drawing.Point(68, 265)
        Me.txt_senha.Name = "txt_senha"
        Me.txt_senha.ReadOnly = True
        Me.txt_senha.Size = New System.Drawing.Size(508, 30)
        Me.txt_senha.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(340, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(229, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "GERADOR DE SENHAS"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.PictureBox2.Location = New System.Drawing.Point(-11, 71)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(828, 60)
        Me.PictureBox2.TabIndex = 12
        Me.PictureBox2.TabStop = False
        '
        'btn_close
        '
        Me.btn_close.BackColor = System.Drawing.Color.Transparent
        Me.btn_close.BackgroundImage = CType(resources.GetObject("btn_close.BackgroundImage"), System.Drawing.Image)
        Me.btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_close.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_close.FlatAppearance.BorderSize = 0
        Me.btn_close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed
        Me.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_close.Location = New System.Drawing.Point(572, 1)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(29, 23)
        Me.btn_close.TabIndex = 3
        Me.btn_close.UseVisualStyleBackColor = False
        '
        'btn_minimize
        '
        Me.btn_minimize.BackColor = System.Drawing.Color.Transparent
        Me.btn_minimize.BackgroundImage = CType(resources.GetObject("btn_minimize.BackgroundImage"), System.Drawing.Image)
        Me.btn_minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_minimize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_minimize.FlatAppearance.BorderSize = 0
        Me.btn_minimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn_minimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btn_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_minimize.Location = New System.Drawing.Point(537, 1)
        Me.btn_minimize.Name = "btn_minimize"
        Me.btn_minimize.Size = New System.Drawing.Size(29, 23)
        Me.btn_minimize.TabIndex = 2
        Me.btn_minimize.UseVisualStyleBackColor = False
        '
        'Form_principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Snow
        Me.ClientSize = New System.Drawing.Size(602, 380)
        Me.Controls.Add(Me.btn_close)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btn_minimize)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form_principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gerador de Senhas"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.txt_qtd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btn_minimize As System.Windows.Forms.Button
    Friend WithEvents btn_close As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txt_senha As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Checked_tudo As System.Windows.Forms.CheckBox
    Friend WithEvents checked_numeros As System.Windows.Forms.CheckBox
    Friend WithEvents checked_mm As System.Windows.Forms.CheckBox
    Friend WithEvents checked_car As System.Windows.Forms.CheckBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents txt_copiado As System.Windows.Forms.Label
    Friend WithEvents txt_erroCopia As System.Windows.Forms.Label
    Friend WithEvents txt_qtd As NumericUpDown
    Friend WithEvents Label2 As Label
End Class
