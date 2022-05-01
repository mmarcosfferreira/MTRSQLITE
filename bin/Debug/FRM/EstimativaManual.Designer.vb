<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmEstimativaManual
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEstimativaManual))
        Me.TxtBruto = New System.Windows.Forms.TextBox()
        Me.TxtTara = New System.Windows.Forms.TextBox()
        Me.RichTextBoxSaida = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtLiquido = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LblTara = New System.Windows.Forms.Label()
        Me.Lblliquido = New System.Windows.Forms.Label()
        Me.Btestimativa = New System.Windows.Forms.Button()
        Me.LblContagem = New System.Windows.Forms.Label()
        Me.LblValor = New System.Windows.Forms.Label()
        Me.LblBruto = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Txtpreco = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Lblestimativa = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TxtBruto
        '
        Me.TxtBruto.BackColor = System.Drawing.Color.White
        Me.TxtBruto.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBruto.Location = New System.Drawing.Point(6, 21)
        Me.TxtBruto.Name = "TxtBruto"
        Me.TxtBruto.Size = New System.Drawing.Size(105, 22)
        Me.TxtBruto.TabIndex = 0
        '
        'TxtTara
        '
        Me.TxtTara.BackColor = System.Drawing.Color.White
        Me.TxtTara.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTara.Location = New System.Drawing.Point(6, 61)
        Me.TxtTara.Name = "TxtTara"
        Me.TxtTara.Size = New System.Drawing.Size(105, 22)
        Me.TxtTara.TabIndex = 1
        '
        'RichTextBoxSaida
        '
        Me.RichTextBoxSaida.BackColor = System.Drawing.Color.White
        Me.RichTextBoxSaida.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBoxSaida.ForeColor = System.Drawing.Color.Gray
        Me.RichTextBoxSaida.Location = New System.Drawing.Point(117, 21)
        Me.RichTextBoxSaida.Name = "RichTextBoxSaida"
        Me.RichTextBoxSaida.Size = New System.Drawing.Size(337, 188)
        Me.RichTextBoxSaida.TabIndex = 4
        Me.RichTextBoxSaida.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Book", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(6, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Bruto"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Franklin Gothic Book", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(6, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Tara"
        '
        'TxtLiquido
        '
        Me.TxtLiquido.Enabled = False
        Me.TxtLiquido.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtLiquido.Location = New System.Drawing.Point(6, 153)
        Me.TxtLiquido.Name = "TxtLiquido"
        Me.TxtLiquido.ReadOnly = True
        Me.TxtLiquido.Size = New System.Drawing.Size(105, 22)
        Me.TxtLiquido.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Franklin Gothic Book", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(6, 137)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 15)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Liquido"
        '
        'LblTara
        '
        Me.LblTara.AutoSize = True
        Me.LblTara.BackColor = System.Drawing.Color.Transparent
        Me.LblTara.Font = New System.Drawing.Font("Franklin Gothic Book", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTara.ForeColor = System.Drawing.Color.DimGray
        Me.LblTara.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LblTara.Location = New System.Drawing.Point(34, 42)
        Me.LblTara.Name = "LblTara"
        Me.LblTara.Size = New System.Drawing.Size(28, 15)
        Me.LblTara.TabIndex = 4
        Me.LblTara.Text = "Tara"
        '
        'Lblliquido
        '
        Me.Lblliquido.AutoSize = True
        Me.Lblliquido.BackColor = System.Drawing.Color.Transparent
        Me.Lblliquido.Font = New System.Drawing.Font("Franklin Gothic Book", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblliquido.ForeColor = System.Drawing.Color.DimGray
        Me.Lblliquido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Lblliquido.Location = New System.Drawing.Point(34, 60)
        Me.Lblliquido.Name = "Lblliquido"
        Me.Lblliquido.Size = New System.Drawing.Size(42, 15)
        Me.Lblliquido.TabIndex = 4
        Me.Lblliquido.Text = "Liquido"
        '
        'Btestimativa
        '
        Me.Btestimativa.AutoSize = True
        Me.Btestimativa.BackColor = System.Drawing.Color.Transparent
        Me.Btestimativa.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Btestimativa.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btestimativa.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btestimativa.ForeColor = System.Drawing.Color.Gray
        Me.Btestimativa.Location = New System.Drawing.Point(6, 184)
        Me.Btestimativa.Name = "Btestimativa"
        Me.Btestimativa.Size = New System.Drawing.Size(105, 25)
        Me.Btestimativa.TabIndex = 3
        Me.Btestimativa.Text = "Estimativa"
        Me.Btestimativa.UseVisualStyleBackColor = False
        '
        'LblContagem
        '
        Me.LblContagem.AutoSize = True
        Me.LblContagem.BackColor = System.Drawing.Color.Transparent
        Me.LblContagem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblContagem.ForeColor = System.Drawing.Color.DarkGray
        Me.LblContagem.Location = New System.Drawing.Point(249, 5)
        Me.LblContagem.Name = "LblContagem"
        Me.LblContagem.Size = New System.Drawing.Size(31, 15)
        Me.LblContagem.TabIndex = 5
        Me.LblContagem.Text = "Cont"
        '
        'LblValor
        '
        Me.LblValor.AutoSize = True
        Me.LblValor.BackColor = System.Drawing.Color.Transparent
        Me.LblValor.Font = New System.Drawing.Font("Franklin Gothic Book", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblValor.ForeColor = System.Drawing.Color.DimGray
        Me.LblValor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LblValor.Location = New System.Drawing.Point(339, 82)
        Me.LblValor.Name = "LblValor"
        Me.LblValor.Size = New System.Drawing.Size(71, 15)
        Me.LblValor.TabIndex = 4
        Me.LblValor.Text = "valor em R$  "
        '
        'LblBruto
        '
        Me.LblBruto.AutoSize = True
        Me.LblBruto.BackColor = System.Drawing.Color.Transparent
        Me.LblBruto.Font = New System.Drawing.Font("Franklin Gothic Book", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBruto.ForeColor = System.Drawing.Color.DimGray
        Me.LblBruto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LblBruto.Location = New System.Drawing.Point(34, 22)
        Me.LblBruto.Name = "LblBruto"
        Me.LblBruto.Size = New System.Drawing.Size(33, 15)
        Me.LblBruto.TabIndex = 4
        Me.LblBruto.Text = "Bruto"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Transparent
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Image = Global.Principal.My.Resources.Resources.bullet_purple
        Me.Button4.Location = New System.Drawing.Point(325, 81)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(16, 15)
        Me.Button4.TabIndex = 7
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Image = Global.Principal.My.Resources.Resources.bullet_green
        Me.Button3.Location = New System.Drawing.Point(13, 60)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(16, 15)
        Me.Button3.TabIndex = 7
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = Global.Principal.My.Resources.Resources.bullet_blue
        Me.Button2.Location = New System.Drawing.Point(13, 40)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(16, 15)
        Me.Button2.TabIndex = 7
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.Principal.My.Resources.Resources.bullet_red
        Me.Button1.Location = New System.Drawing.Point(13, 20)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(16, 15)
        Me.Button1.TabIndex = 7
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Txtpreco
        '
        Me.Txtpreco.BackColor = System.Drawing.Color.White
        Me.Txtpreco.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtpreco.Location = New System.Drawing.Point(6, 109)
        Me.Txtpreco.Name = "Txtpreco"
        Me.Txtpreco.Size = New System.Drawing.Size(105, 22)
        Me.Txtpreco.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Franklin Gothic Book", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DimGray
        Me.Label4.Location = New System.Drawing.Point(6, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 15)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Preço por Tonelada"
        '
        'Lblestimativa
        '
        Me.Lblestimativa.AutoSize = True
        Me.Lblestimativa.BackColor = System.Drawing.Color.Transparent
        Me.Lblestimativa.Font = New System.Drawing.Font("Franklin Gothic Book", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblestimativa.ForeColor = System.Drawing.Color.DimGray
        Me.Lblestimativa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Lblestimativa.Location = New System.Drawing.Point(34, 83)
        Me.Lblestimativa.Name = "Lblestimativa"
        Me.Lblestimativa.Size = New System.Drawing.Size(96, 15)
        Me.Lblestimativa.TabIndex = 4
        Me.Lblestimativa.Text = "Estimativa em R$  "
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Transparent
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Image = Global.Principal.My.Resources.Resources.bullet_orange
        Me.Button5.Location = New System.Drawing.Point(13, 82)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(16, 15)
        Me.Button5.TabIndex = 7
        Me.Button5.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.LblBruto)
        Me.GroupBox1.Controls.Add(Me.LblValor)
        Me.GroupBox1.Controls.Add(Me.LblTara)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Lblliquido)
        Me.GroupBox1.Controls.Add(Me.Lblestimativa)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 210)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(449, 105)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Média Geral"
        '
        'FrmEstimativaManual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Principal.My.Resources.Resources.fbvasfhjvas
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(466, 318)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LblContagem)
        Me.Controls.Add(Me.Btestimativa)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RichTextBoxSaida)
        Me.Controls.Add(Me.TxtLiquido)
        Me.Controls.Add(Me.TxtTara)
        Me.Controls.Add(Me.Txtpreco)
        Me.Controls.Add(Me.TxtBruto)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "FrmEstimativaManual"
        Me.Opacity = 0.95R
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Estimativa Manual"
        Me.TransparencyKey = System.Drawing.Color.Blue
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtBruto As TextBox
    Friend WithEvents TxtTara As TextBox
    Friend WithEvents RichTextBoxSaida As RichTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtLiquido As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents LblBruto As Label
    Friend WithEvents LblTara As Label
    Friend WithEvents Lblliquido As Label
    Friend WithEvents Btestimativa As Button
    Friend WithEvents LblContagem As Label
    Friend WithEvents LblValor As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Txtpreco As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Lblestimativa As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents GroupBox1 As GroupBox
End Class
