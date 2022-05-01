<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frmpesoliquido
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frmpesoliquido))
        Me.txtpesobruto = New System.Windows.Forms.TextBox()
        Me.txtpesotara = New System.Windows.Forms.TextBox()
        Me.txtpesoliquido = New System.Windows.Forms.TextBox()
        Me.lblBruto = New System.Windows.Forms.Label()
        Me.lbltara = New System.Windows.Forms.Label()
        Me.lblliquido = New System.Windows.Forms.Label()
        Me.CheckBoxTopMost = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'txtpesobruto
        '
        Me.txtpesobruto.Location = New System.Drawing.Point(4, 33)
        Me.txtpesobruto.Name = "txtpesobruto"
        Me.txtpesobruto.Size = New System.Drawing.Size(213, 20)
        Me.txtpesobruto.TabIndex = 0
        Me.txtpesobruto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtpesotara
        '
        Me.txtpesotara.Location = New System.Drawing.Point(4, 53)
        Me.txtpesotara.Name = "txtpesotara"
        Me.txtpesotara.Size = New System.Drawing.Size(213, 20)
        Me.txtpesotara.TabIndex = 1
        Me.txtpesotara.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtpesoliquido
        '
        Me.txtpesoliquido.Location = New System.Drawing.Point(4, 74)
        Me.txtpesoliquido.Name = "txtpesoliquido"
        Me.txtpesoliquido.Size = New System.Drawing.Size(213, 20)
        Me.txtpesoliquido.TabIndex = 2
        Me.txtpesoliquido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblBruto
        '
        Me.lblBruto.AutoSize = True
        Me.lblBruto.BackColor = System.Drawing.Color.White
        Me.lblBruto.ForeColor = System.Drawing.Color.Blue
        Me.lblBruto.Location = New System.Drawing.Point(7, 38)
        Me.lblBruto.Name = "lblBruto"
        Me.lblBruto.Size = New System.Drawing.Size(21, 13)
        Me.lblBruto.TabIndex = 1
        Me.lblBruto.Text = "PB"
        '
        'lbltara
        '
        Me.lbltara.AutoSize = True
        Me.lbltara.BackColor = System.Drawing.Color.White
        Me.lbltara.ForeColor = System.Drawing.Color.Blue
        Me.lbltara.Location = New System.Drawing.Point(5, 57)
        Me.lbltara.Name = "lbltara"
        Me.lbltara.Size = New System.Drawing.Size(21, 13)
        Me.lbltara.TabIndex = 1
        Me.lbltara.Text = "PT"
        '
        'lblliquido
        '
        Me.lblliquido.AutoSize = True
        Me.lblliquido.BackColor = System.Drawing.Color.White
        Me.lblliquido.ForeColor = System.Drawing.Color.Blue
        Me.lblliquido.Location = New System.Drawing.Point(8, 77)
        Me.lblliquido.Name = "lblliquido"
        Me.lblliquido.Size = New System.Drawing.Size(20, 13)
        Me.lblliquido.TabIndex = 1
        Me.lblliquido.Text = "PL"
        '
        'CheckBoxTopMost
        '
        Me.CheckBoxTopMost.AutoSize = True
        Me.CheckBoxTopMost.Location = New System.Drawing.Point(4, 12)
        Me.CheckBoxTopMost.Name = "CheckBoxTopMost"
        Me.CheckBoxTopMost.Size = New System.Drawing.Size(71, 17)
        Me.CheckBoxTopMost.TabIndex = 3
        Me.CheckBoxTopMost.Text = "Top Most"
        Me.CheckBoxTopMost.UseVisualStyleBackColor = True
        '
        'Frmpesoliquido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(241, 99)
        Me.Controls.Add(Me.CheckBoxTopMost)
        Me.Controls.Add(Me.lblliquido)
        Me.Controls.Add(Me.lbltara)
        Me.Controls.Add(Me.lblBruto)
        Me.Controls.Add(Me.txtpesoliquido)
        Me.Controls.Add(Me.txtpesotara)
        Me.Controls.Add(Me.txtpesobruto)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "Frmpesoliquido"
        Me.Opacity = 0.95R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Peso liquido"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtpesobruto As TextBox
    Friend WithEvents txtpesotara As TextBox
    Friend WithEvents txtpesoliquido As TextBox
    Friend WithEvents lblBruto As Label
    Friend WithEvents lbltara As Label
    Friend WithEvents lblliquido As Label
    Friend WithEvents CheckBoxTopMost As CheckBox
End Class
