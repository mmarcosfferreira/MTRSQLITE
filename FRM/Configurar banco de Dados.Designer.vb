<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRMConfigurar_banco_de_Dados
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRMConfigurar_banco_de_Dados))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButtonLocalHost = New System.Windows.Forms.RadioButton()
        Me.RadioButtonServer = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblStatusdaRede = New System.Windows.Forms.Label()
        Me.TimerRede = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButtonLocalHost)
        Me.GroupBox1.Controls.Add(Me.RadioButtonServer)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Gray
        Me.GroupBox1.Location = New System.Drawing.Point(36, 29)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(302, 88)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Automatização do Banco de dados"
        '
        'RadioButtonLocalHost
        '
        Me.RadioButtonLocalHost.AutoSize = True
        Me.RadioButtonLocalHost.Location = New System.Drawing.Point(166, 45)
        Me.RadioButtonLocalHost.Name = "RadioButtonLocalHost"
        Me.RadioButtonLocalHost.Size = New System.Drawing.Size(93, 21)
        Me.RadioButtonLocalHost.TabIndex = 1
        Me.RadioButtonLocalHost.TabStop = True
        Me.RadioButtonLocalHost.Text = "Local Host"
        Me.RadioButtonLocalHost.Checked = False
        Me.RadioButtonLocalHost.UseVisualStyleBackColor = True


        '
        'RadioButtonServer
        '
        Me.RadioButtonServer.AutoSize = True
        Me.RadioButtonServer.Location = New System.Drawing.Point(19, 45)
        Me.RadioButtonServer.Name = "RadioButtonServer"
        Me.RadioButtonServer.Size = New System.Drawing.Size(64, 21)
        Me.RadioButtonServer.TabIndex = 0
        Me.RadioButtonServer.TabStop = True
        Me.RadioButtonServer.Text = "Server"
        Me.RadioButtonServer.UseVisualStyleBackColor = True
        Me.RadioButtonServer.Checked = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(33, 135)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Status da rede:"
        '
        'LblStatusdaRede
        '
        Me.LblStatusdaRede.AutoSize = True
        Me.LblStatusdaRede.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblStatusdaRede.ForeColor = System.Drawing.Color.DimGray
        Me.LblStatusdaRede.Location = New System.Drawing.Point(144, 135)
        Me.LblStatusdaRede.Name = "LblStatusdaRede"
        Me.LblStatusdaRede.Size = New System.Drawing.Size(122, 17)
        Me.LblStatusdaRede.TabIndex = 1
        Me.LblStatusdaRede.Text = "___________________"
        Me.LblStatusdaRede.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'TimerRede
        '
        Me.TimerRede.Interval = 200
        '
        'FRMConfigurar_banco_de_Dados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Principal.My.Resources.Resources.fbvasfhjvas
        Me.ClientSize = New System.Drawing.Size(384, 161)
        Me.Controls.Add(Me.LblStatusdaRede)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FRMConfigurar_banco_de_Dados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Configurar_banco_de_Dados"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButtonLocalHost As RadioButton
    Friend WithEvents RadioButtonServer As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents LblStatusdaRede As Label
    Friend WithEvents TimerRede As Timer
End Class
