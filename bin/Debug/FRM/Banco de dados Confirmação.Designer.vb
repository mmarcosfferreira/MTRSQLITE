<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMConfirmarBancodeDados
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TxtSenha = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BTOk = New System.Windows.Forms.Button()
        Me.BTVoltar = New System.Windows.Forms.Button()
        Me.LblContagem = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TxtSenha
        '
        Me.TxtSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtSenha.Font = New System.Drawing.Font("Mongolian Baiti", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSenha.Location = New System.Drawing.Point(22, 40)
        Me.TxtSenha.Name = "TxtSenha"
        Me.TxtSenha.Size = New System.Drawing.Size(172, 20)
        Me.TxtSenha.TabIndex = 0
        Me.TxtSenha.UseSystemPasswordChar = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Mongolian Baiti", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 11)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Senha de autorização"
        '
        'BTOk
        '
        Me.BTOk.Location = New System.Drawing.Point(199, 38)
        Me.BTOk.Name = "BTOk"
        Me.BTOk.Size = New System.Drawing.Size(75, 23)
        Me.BTOk.TabIndex = 1
        Me.BTOk.Text = "Ok"
        Me.BTOk.UseVisualStyleBackColor = True
        '
        'BTVoltar
        '
        Me.BTVoltar.Location = New System.Drawing.Point(280, 38)
        Me.BTVoltar.Name = "BTVoltar"
        Me.BTVoltar.Size = New System.Drawing.Size(75, 23)
        Me.BTVoltar.TabIndex = 2
        Me.BTVoltar.Text = "Sair"
        Me.BTVoltar.UseVisualStyleBackColor = True
        '
        'LblContagem
        '
        Me.LblContagem.AutoSize = True
        Me.LblContagem.Font = New System.Drawing.Font("Mongolian Baiti", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblContagem.Location = New System.Drawing.Point(303, 9)
        Me.LblContagem.Name = "LblContagem"
        Me.LblContagem.Size = New System.Drawing.Size(52, 11)
        Me.LblContagem.TabIndex = 1
        Me.LblContagem.Text = "Tentativas"
        '
        'FRMConfirmarBancodeDados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(386, 81)
        Me.ControlBox = False
        Me.Controls.Add(Me.LblContagem)
        Me.Controls.Add(Me.BTVoltar)
        Me.Controls.Add(Me.BTOk)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtSenha)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FRMConfirmarBancodeDados"
        Me.Text = "Banco_de_dados_Confirmação"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtSenha As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BTOk As Button
    Friend WithEvents BTVoltar As Button
    Friend WithEvents LblContagem As Label
End Class
