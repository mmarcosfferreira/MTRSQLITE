<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMopcoes
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRMopcoes))
		Me.GradientPanel = New Guna.UI2.WinForms.Guna2GradientPanel()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.BTend = New Guna.UI2.WinForms.Guna2GradientButton()
		Me.BTalterarData = New Guna.UI2.WinForms.Guna2GradientButton()
		Me.BTConfiguraçãoFeam = New Guna.UI2.WinForms.Guna2GradientButton()
		Me.BTControleInfratores = New Guna.UI2.WinForms.Guna2GradientButton()
		Me.BTMemorando = New Guna.UI2.WinForms.Guna2GradientButton()
		Me.BTcontrolePesagemManual = New Guna.UI2.WinForms.Guna2GradientButton()
		Me.btsair = New System.Windows.Forms.Button()
		Me.BtRestore = New Guna.UI2.WinForms.Guna2GradientButton()
		Me.GradientPanel.SuspendLayout()
		Me.GroupBox1.SuspendLayout()
		Me.SuspendLayout()
		'
		'GradientPanel
		'
		Me.GradientPanel.Controls.Add(Me.GroupBox1)
		Me.GradientPanel.Dock = System.Windows.Forms.DockStyle.Fill
		Me.GradientPanel.FillColor = System.Drawing.Color.SkyBlue
		Me.GradientPanel.FillColor2 = System.Drawing.Color.CadetBlue
		Me.GradientPanel.Location = New System.Drawing.Point(0, 0)
		Me.GradientPanel.Name = "GradientPanel"
		Me.GradientPanel.ShadowDecoration.Parent = Me.GradientPanel
		Me.GradientPanel.Size = New System.Drawing.Size(214, 266)
		Me.GradientPanel.TabIndex = 0
		'
		'GroupBox1
		'
		Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
		Me.GroupBox1.Controls.Add(Me.BtRestore)
		Me.GroupBox1.Controls.Add(Me.btsair)
		Me.GroupBox1.Controls.Add(Me.BTend)
		Me.GroupBox1.Controls.Add(Me.BTalterarData)
		Me.GroupBox1.Controls.Add(Me.BTConfiguraçãoFeam)
		Me.GroupBox1.Controls.Add(Me.BTControleInfratores)
		Me.GroupBox1.Controls.Add(Me.BTMemorando)
		Me.GroupBox1.Controls.Add(Me.BTcontrolePesagemManual)
		Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Left
		Me.GroupBox1.ForeColor = System.Drawing.Color.DarkBlue
		Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(219, 266)
		Me.GroupBox1.TabIndex = 5
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "Ferramentas"
		'
		'BTend
		'
		Me.BTend.CheckedState.Parent = Me.BTend
		Me.BTend.CustomImages.Parent = Me.BTend
		Me.BTend.FillColor = System.Drawing.SystemColors.ActiveBorder
		Me.BTend.FillColor2 = System.Drawing.Color.SkyBlue
		Me.BTend.Font = New System.Drawing.Font("Segoe UI", 9.0!)
		Me.BTend.ForeColor = System.Drawing.Color.White
		Me.BTend.HoverState.Parent = Me.BTend
		Me.BTend.Location = New System.Drawing.Point(6, 210)
		Me.BTend.Name = "BTend"
		Me.BTend.ShadowDecoration.Parent = Me.BTend
		Me.BTend.Size = New System.Drawing.Size(198, 21)
		Me.BTend.TabIndex = 4
		Me.BTend.Text = "Fechar toda aplicações"
		'
		'BTalterarData
		'
		Me.BTalterarData.CheckedState.Parent = Me.BTalterarData
		Me.BTalterarData.CustomImages.Parent = Me.BTalterarData
		Me.BTalterarData.FillColor = System.Drawing.SystemColors.ActiveBorder
		Me.BTalterarData.FillColor2 = System.Drawing.Color.SkyBlue
		Me.BTalterarData.Font = New System.Drawing.Font("Segoe UI", 9.0!)
		Me.BTalterarData.ForeColor = System.Drawing.Color.White
		Me.BTalterarData.HoverState.Parent = Me.BTalterarData
		Me.BTalterarData.Location = New System.Drawing.Point(6, 17)
		Me.BTalterarData.Name = "BTalterarData"
		Me.BTalterarData.ShadowDecoration.Parent = Me.BTalterarData
		Me.BTalterarData.Size = New System.Drawing.Size(198, 21)
		Me.BTalterarData.TabIndex = 0
		Me.BTalterarData.Text = "Alterar Data"
		'
		'BTConfiguraçãoFeam
		'
		Me.BTConfiguraçãoFeam.CheckedState.Parent = Me.BTConfiguraçãoFeam
		Me.BTConfiguraçãoFeam.CustomImages.Parent = Me.BTConfiguraçãoFeam
		Me.BTConfiguraçãoFeam.FillColor = System.Drawing.SystemColors.ActiveBorder
		Me.BTConfiguraçãoFeam.FillColor2 = System.Drawing.Color.SkyBlue
		Me.BTConfiguraçãoFeam.Font = New System.Drawing.Font("Segoe UI", 9.0!)
		Me.BTConfiguraçãoFeam.ForeColor = System.Drawing.Color.White
		Me.BTConfiguraçãoFeam.HoverState.Parent = Me.BTConfiguraçãoFeam
		Me.BTConfiguraçãoFeam.Location = New System.Drawing.Point(6, 116)
		Me.BTConfiguraçãoFeam.Name = "BTConfiguraçãoFeam"
		Me.BTConfiguraçãoFeam.ShadowDecoration.Parent = Me.BTConfiguraçãoFeam
		Me.BTConfiguraçãoFeam.Size = New System.Drawing.Size(198, 21)
		Me.BTConfiguraçãoFeam.TabIndex = 3
		Me.BTConfiguraçãoFeam.Text = "Configuração Feam"
		'
		'BTControleInfratores
		'
		Me.BTControleInfratores.CheckedState.Parent = Me.BTControleInfratores
		Me.BTControleInfratores.CustomImages.Parent = Me.BTControleInfratores
		Me.BTControleInfratores.FillColor = System.Drawing.SystemColors.ActiveBorder
		Me.BTControleInfratores.FillColor2 = System.Drawing.Color.SkyBlue
		Me.BTControleInfratores.Font = New System.Drawing.Font("Segoe UI", 9.0!)
		Me.BTControleInfratores.ForeColor = System.Drawing.Color.White
		Me.BTControleInfratores.HoverState.Parent = Me.BTControleInfratores
		Me.BTControleInfratores.Location = New System.Drawing.Point(6, 149)
		Me.BTControleInfratores.Name = "BTControleInfratores"
		Me.BTControleInfratores.ShadowDecoration.Parent = Me.BTControleInfratores
		Me.BTControleInfratores.Size = New System.Drawing.Size(198, 21)
		Me.BTControleInfratores.TabIndex = 3
		Me.BTControleInfratores.Text = "Controle de Infratores"
		'
		'BTMemorando
		'
		Me.BTMemorando.CheckedState.Parent = Me.BTMemorando
		Me.BTMemorando.CustomImages.Parent = Me.BTMemorando
		Me.BTMemorando.FillColor = System.Drawing.SystemColors.ActiveBorder
		Me.BTMemorando.FillColor2 = System.Drawing.Color.SkyBlue
		Me.BTMemorando.Font = New System.Drawing.Font("Segoe UI", 9.0!)
		Me.BTMemorando.ForeColor = System.Drawing.Color.White
		Me.BTMemorando.HoverState.Parent = Me.BTMemorando
		Me.BTMemorando.Location = New System.Drawing.Point(6, 50)
		Me.BTMemorando.Name = "BTMemorando"
		Me.BTMemorando.ShadowDecoration.Parent = Me.BTMemorando
		Me.BTMemorando.Size = New System.Drawing.Size(198, 21)
		Me.BTMemorando.TabIndex = 1
		Me.BTMemorando.Text = "Memorando"
		'
		'BTcontrolePesagemManual
		'
		Me.BTcontrolePesagemManual.CheckedState.Parent = Me.BTcontrolePesagemManual
		Me.BTcontrolePesagemManual.CustomImages.Parent = Me.BTcontrolePesagemManual
		Me.BTcontrolePesagemManual.FillColor = System.Drawing.SystemColors.ActiveBorder
		Me.BTcontrolePesagemManual.FillColor2 = System.Drawing.Color.SkyBlue
		Me.BTcontrolePesagemManual.Font = New System.Drawing.Font("Segoe UI", 9.0!)
		Me.BTcontrolePesagemManual.ForeColor = System.Drawing.Color.White
		Me.BTcontrolePesagemManual.HoverState.Parent = Me.BTcontrolePesagemManual
		Me.BTcontrolePesagemManual.Location = New System.Drawing.Point(6, 83)
		Me.BTcontrolePesagemManual.Name = "BTcontrolePesagemManual"
		Me.BTcontrolePesagemManual.ShadowDecoration.Parent = Me.BTcontrolePesagemManual
		Me.BTcontrolePesagemManual.Size = New System.Drawing.Size(198, 21)
		Me.BTcontrolePesagemManual.TabIndex = 2
		Me.BTcontrolePesagemManual.Text = "Controle de Pesagem Manual"
		'
		'btsair
		'
		Me.btsair.BackColor = System.Drawing.Color.Transparent
		Me.btsair.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btsair.Location = New System.Drawing.Point(133, 241)
		Me.btsair.Name = "btsair"
		Me.btsair.Size = New System.Drawing.Size(81, 22)
		Me.btsair.TabIndex = 1
		Me.btsair.Text = "Sair"
		Me.btsair.UseVisualStyleBackColor = False
		'
		'BtRestore
		'
		Me.BtRestore.CheckedState.Parent = Me.BtRestore
		Me.BtRestore.CustomImages.Parent = Me.BtRestore
		Me.BtRestore.FillColor = System.Drawing.SystemColors.ActiveBorder
		Me.BtRestore.FillColor2 = System.Drawing.Color.SkyBlue
		Me.BtRestore.Font = New System.Drawing.Font("Segoe UI", 9.0!)
		Me.BtRestore.ForeColor = System.Drawing.Color.White
		Me.BtRestore.HoverState.Parent = Me.BtRestore
		Me.BtRestore.Location = New System.Drawing.Point(6, 180)
		Me.BtRestore.Name = "BtRestore"
		Me.BtRestore.ShadowDecoration.Parent = Me.BtRestore
		Me.BtRestore.Size = New System.Drawing.Size(198, 21)
		Me.BtRestore.TabIndex = 5
		Me.BtRestore.Text = "Restore DataBase MTR"
		'
		'FRMopcoes
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(214, 266)
		Me.ControlBox = False
		Me.Controls.Add(Me.GradientPanel)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaximizeBox = False
		Me.Name = "FRMopcoes"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Opções"
		Me.GradientPanel.ResumeLayout(False)
		Me.GroupBox1.ResumeLayout(False)
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents GradientPanel As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents BTMemorando As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents BTalterarData As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents BTend As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents BTControleInfratores As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents BTcontrolePesagemManual As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BTConfiguraçãoFeam As Guna.UI2.WinForms.Guna2GradientButton
	Friend WithEvents btsair As Button
	Friend WithEvents BtRestore As Guna.UI2.WinForms.Guna2GradientButton
End Class
