<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmInfratores
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmInfratores))
        Me.Panel_Botões = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.BTCADEMPRESA = New Guna.UI2.WinForms.Guna2Button()
        Me.BTLISTAR_INFRATORES = New Guna.UI2.WinForms.Guna2Button()
        Me.BTBUSCAR = New Guna.UI2.WinForms.Guna2Button()
        Me.BTSAIR = New Guna.UI2.WinForms.Guna2Button()
        Me.BTEXCLUIR = New Guna.UI2.WinForms.Guna2Button()
        Me.BTEDITAR = New Guna.UI2.WinForms.Guna2Button()
        Me.BTADICIONAR = New Guna.UI2.WinForms.Guna2Button()
        Me.PainelEntrada = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.LLCarregarAtualizar = New System.Windows.Forms.LinkLabel()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.CBOEmpresa = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.TXTID = New Principal.TextboxMonetário()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.LBLMOTIVO = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.LBLMOTORISTA = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.TxtMotivo = New Principal.TextboxMonetário()
        Me.TxtMotorista = New Principal.TextboxMonetário()
        Me.DGVdados = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Panel_Botões.SuspendLayout()
        Me.PainelEntrada.SuspendLayout()
        CType(Me.DGVdados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel_Botões
        '
        Me.Panel_Botões.BackColor = System.Drawing.Color.Transparent
        Me.Panel_Botões.Controls.Add(Me.BTCADEMPRESA)
        Me.Panel_Botões.Controls.Add(Me.BTBUSCAR)
        Me.Panel_Botões.Controls.Add(Me.BTSAIR)
        Me.Panel_Botões.Controls.Add(Me.BTEXCLUIR)
        Me.Panel_Botões.Controls.Add(Me.BTEDITAR)
        Me.Panel_Botões.Controls.Add(Me.BTADICIONAR)
        Me.Panel_Botões.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Botões.FillColor = System.Drawing.Color.SkyBlue
        Me.Panel_Botões.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Botões.Name = "Panel_Botões"
        Me.Panel_Botões.ShadowColor = System.Drawing.Color.Black
        Me.Panel_Botões.Size = New System.Drawing.Size(933, 62)
        Me.Panel_Botões.TabIndex = 0
        '
        'BTCADEMPRESA
        '
        Me.BTCADEMPRESA.Animated = True
        Me.BTCADEMPRESA.CheckedState.Parent = Me.BTCADEMPRESA
        Me.BTCADEMPRESA.CustomImages.Parent = Me.BTCADEMPRESA
        Me.BTCADEMPRESA.FillColor = System.Drawing.Color.Transparent
        Me.BTCADEMPRESA.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BTCADEMPRESA.ForeColor = System.Drawing.Color.White
        Me.BTCADEMPRESA.HoverState.Parent = Me.BTCADEMPRESA
        Me.BTCADEMPRESA.Location = New System.Drawing.Point(447, 14)
        Me.BTCADEMPRESA.Name = "BTCADEMPRESA"
        Me.BTCADEMPRESA.ShadowDecoration.Parent = Me.BTCADEMPRESA
        Me.BTCADEMPRESA.Size = New System.Drawing.Size(187, 36)
        Me.BTCADEMPRESA.TabIndex = 6
        Me.BTCADEMPRESA.Text = "Cadastro de Empresa/Cliente"
        '
        'BTLISTAR_INFRATORES
        '
        Me.BTLISTAR_INFRATORES.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTLISTAR_INFRATORES.Animated = True
        Me.BTLISTAR_INFRATORES.BackColor = System.Drawing.Color.Transparent
        Me.BTLISTAR_INFRATORES.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.BTLISTAR_INFRATORES.BorderRadius = 10
        Me.BTLISTAR_INFRATORES.BorderThickness = 1
        Me.BTLISTAR_INFRATORES.CheckedState.Parent = Me.BTLISTAR_INFRATORES
        Me.BTLISTAR_INFRATORES.CustomImages.Parent = Me.BTLISTAR_INFRATORES
        Me.BTLISTAR_INFRATORES.FillColor = System.Drawing.Color.Transparent
        Me.BTLISTAR_INFRATORES.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BTLISTAR_INFRATORES.ForeColor = System.Drawing.Color.Gray
        Me.BTLISTAR_INFRATORES.HoverState.Parent = Me.BTLISTAR_INFRATORES
        Me.BTLISTAR_INFRATORES.Location = New System.Drawing.Point(843, 11)
        Me.BTLISTAR_INFRATORES.Name = "BTLISTAR_INFRATORES"
        Me.BTLISTAR_INFRATORES.ShadowDecoration.Parent = Me.BTLISTAR_INFRATORES
        Me.BTLISTAR_INFRATORES.Size = New System.Drawing.Size(72, 20)
        Me.BTLISTAR_INFRATORES.TabIndex = 4
        Me.BTLISTAR_INFRATORES.Text = "Carregar"
        '
        'BTBUSCAR
        '
        Me.BTBUSCAR.Animated = True
        Me.BTBUSCAR.CheckedState.Parent = Me.BTBUSCAR
        Me.BTBUSCAR.CustomImages.Parent = Me.BTBUSCAR
        Me.BTBUSCAR.FillColor = System.Drawing.Color.Transparent
        Me.BTBUSCAR.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BTBUSCAR.ForeColor = System.Drawing.Color.White
        Me.BTBUSCAR.HoverState.Parent = Me.BTBUSCAR
        Me.BTBUSCAR.Location = New System.Drawing.Point(312, 14)
        Me.BTBUSCAR.Name = "BTBUSCAR"
        Me.BTBUSCAR.ShadowDecoration.Parent = Me.BTBUSCAR
        Me.BTBUSCAR.Size = New System.Drawing.Size(99, 36)
        Me.BTBUSCAR.TabIndex = 3
        Me.BTBUSCAR.Text = "Busca por ID"
        '
        'BTSAIR
        '
        Me.BTSAIR.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTSAIR.Animated = True
        Me.BTSAIR.CheckedState.Parent = Me.BTSAIR
        Me.BTSAIR.CustomImages.Parent = Me.BTSAIR
        Me.BTSAIR.FillColor = System.Drawing.Color.Transparent
        Me.BTSAIR.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BTSAIR.ForeColor = System.Drawing.Color.White
        Me.BTSAIR.HoverState.Parent = Me.BTSAIR
        Me.BTSAIR.Location = New System.Drawing.Point(852, 12)
        Me.BTSAIR.Name = "BTSAIR"
        Me.BTSAIR.ShadowDecoration.Parent = Me.BTSAIR
        Me.BTSAIR.Size = New System.Drawing.Size(64, 36)
        Me.BTSAIR.TabIndex = 5
        Me.BTSAIR.Text = "Sair"
        '
        'BTEXCLUIR
        '
        Me.BTEXCLUIR.Animated = True
        Me.BTEXCLUIR.CheckedState.Parent = Me.BTEXCLUIR
        Me.BTEXCLUIR.CustomImages.Parent = Me.BTEXCLUIR
        Me.BTEXCLUIR.FillColor = System.Drawing.Color.Transparent
        Me.BTEXCLUIR.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BTEXCLUIR.ForeColor = System.Drawing.Color.White
        Me.BTEXCLUIR.HoverState.Parent = Me.BTEXCLUIR
        Me.BTEXCLUIR.Location = New System.Drawing.Point(212, 14)
        Me.BTEXCLUIR.Name = "BTEXCLUIR"
        Me.BTEXCLUIR.ShadowDecoration.Parent = Me.BTEXCLUIR
        Me.BTEXCLUIR.Size = New System.Drawing.Size(64, 36)
        Me.BTEXCLUIR.TabIndex = 2
        Me.BTEXCLUIR.Text = "Excluir"
        '
        'BTEDITAR
        '
        Me.BTEDITAR.Animated = True
        Me.BTEDITAR.CheckedState.Parent = Me.BTEDITAR
        Me.BTEDITAR.CustomImages.Parent = Me.BTEDITAR
        Me.BTEDITAR.FillColor = System.Drawing.Color.Transparent
        Me.BTEDITAR.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BTEDITAR.ForeColor = System.Drawing.Color.White
        Me.BTEDITAR.HoverState.Parent = Me.BTEDITAR
        Me.BTEDITAR.Location = New System.Drawing.Point(112, 14)
        Me.BTEDITAR.Name = "BTEDITAR"
        Me.BTEDITAR.ShadowDecoration.Parent = Me.BTEDITAR
        Me.BTEDITAR.Size = New System.Drawing.Size(64, 36)
        Me.BTEDITAR.TabIndex = 1
        Me.BTEDITAR.Text = "Editar"
        '
        'BTADICIONAR
        '
        Me.BTADICIONAR.Animated = True
        Me.BTADICIONAR.CheckedState.Parent = Me.BTADICIONAR
        Me.BTADICIONAR.CustomImages.Parent = Me.BTADICIONAR
        Me.BTADICIONAR.FillColor = System.Drawing.Color.Transparent
        Me.BTADICIONAR.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BTADICIONAR.ForeColor = System.Drawing.Color.White
        Me.BTADICIONAR.HoverState.Parent = Me.BTADICIONAR
        Me.BTADICIONAR.Location = New System.Drawing.Point(12, 14)
        Me.BTADICIONAR.Name = "BTADICIONAR"
        Me.BTADICIONAR.ShadowDecoration.Parent = Me.BTADICIONAR
        Me.BTADICIONAR.Size = New System.Drawing.Size(64, 36)
        Me.BTADICIONAR.TabIndex = 0
        Me.BTADICIONAR.Text = "Adicionar"
        '
        'PainelEntrada
        '
        Me.PainelEntrada.AutoSize = True
        Me.PainelEntrada.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PainelEntrada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PainelEntrada.Controls.Add(Me.LLCarregarAtualizar)
        Me.PainelEntrada.Controls.Add(Me.BTLISTAR_INFRATORES)
        Me.PainelEntrada.Controls.Add(Me.Guna2HtmlLabel1)
        Me.PainelEntrada.Controls.Add(Me.CBOEmpresa)
        Me.PainelEntrada.Controls.Add(Me.TXTID)
        Me.PainelEntrada.Controls.Add(Me.Guna2HtmlLabel3)
        Me.PainelEntrada.Controls.Add(Me.LBLMOTIVO)
        Me.PainelEntrada.Controls.Add(Me.LBLMOTORISTA)
        Me.PainelEntrada.Controls.Add(Me.TxtMotivo)
        Me.PainelEntrada.Controls.Add(Me.TxtMotorista)
        Me.PainelEntrada.Controls.Add(Me.DGVdados)
        Me.PainelEntrada.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PainelEntrada.FillColor = System.Drawing.Color.SkyBlue
        Me.PainelEntrada.Location = New System.Drawing.Point(0, 62)
        Me.PainelEntrada.Name = "PainelEntrada"
        Me.PainelEntrada.ShadowColor = System.Drawing.Color.Black
        Me.PainelEntrada.Size = New System.Drawing.Size(933, 313)
        Me.PainelEntrada.TabIndex = 1
        '
        'LLCarregarAtualizar
        '
        Me.LLCarregarAtualizar.BackColor = System.Drawing.Color.Transparent
        Me.LLCarregarAtualizar.LinkColor = System.Drawing.Color.Gray
        Me.LLCarregarAtualizar.Location = New System.Drawing.Point(183, 228)
        Me.LLCarregarAtualizar.Name = "LLCarregarAtualizar"
        Me.LLCarregarAtualizar.Size = New System.Drawing.Size(92, 29)
        Me.LLCarregarAtualizar.TabIndex = 7
        Me.LLCarregarAtualizar.TabStop = True
        Me.LLCarregarAtualizar.Text = "Atualizar Empresa/Cliente"
        Me.LLCarregarAtualizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Maiandra GD", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(11, 238)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(87, 17)
        Me.Guna2HtmlLabel1.TabIndex = 6
        Me.Guna2HtmlLabel1.Text = "Empresa/Cliente"
        '
        'CBOEmpresa
        '
        Me.CBOEmpresa.BackColor = System.Drawing.Color.White
        Me.CBOEmpresa.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CBOEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBOEmpresa.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CBOEmpresa.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CBOEmpresa.FocusedState.Parent = Me.CBOEmpresa
        Me.CBOEmpresa.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CBOEmpresa.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.CBOEmpresa.HoverState.Parent = Me.CBOEmpresa
        Me.CBOEmpresa.ItemHeight = 24
        Me.CBOEmpresa.ItemsAppearance.Parent = Me.CBOEmpresa
        Me.CBOEmpresa.Location = New System.Drawing.Point(11, 259)
        Me.CBOEmpresa.Name = "CBOEmpresa"
        Me.CBOEmpresa.ShadowDecoration.Parent = Me.CBOEmpresa
        Me.CBOEmpresa.Size = New System.Drawing.Size(264, 30)
        Me.CBOEmpresa.TabIndex = 3
        '
        'TXTID
        '
        Me.TXTID.Ativar_CasasDecimais = False
        Me.TXTID.Ativar_so_Letras = False
        Me.TXTID.Ativar_so_Numeros = True
        Me.TXTID.AtivarSoNumeroSemFormatacao_ = False
        Me.TXTID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXTID.DefaultText = ""
        Me.TXTID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXTID.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXTID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTID.DisabledState.Parent = Me.TXTID
        Me.TXTID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTID.FocusedState.Parent = Me.TXTID
        Me.TXTID.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTID.HoverState.Parent = Me.TXTID
        Me.TXTID.Location = New System.Drawing.Point(10, 37)
        Me.TXTID.Name = "TXTID"
        Me.TXTID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTID.PlaceholderText = ""
        Me.TXTID.SelectedText = ""
        Me.TXTID.ShadowDecoration.Parent = Me.TXTID
        Me.TXTID.Size = New System.Drawing.Size(72, 31)
        Me.TXTID.TabIndex = 0
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Maiandra GD", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(10, 14)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(14, 17)
        Me.Guna2HtmlLabel3.TabIndex = 5
        Me.Guna2HtmlLabel3.Text = "Id"
        '
        'LBLMOTIVO
        '
        Me.LBLMOTIVO.BackColor = System.Drawing.Color.Transparent
        Me.LBLMOTIVO.Font = New System.Drawing.Font("Maiandra GD", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLMOTIVO.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.LBLMOTIVO.Location = New System.Drawing.Point(11, 159)
        Me.LBLMOTIVO.Name = "LBLMOTIVO"
        Me.LBLMOTIVO.Size = New System.Drawing.Size(41, 17)
        Me.LBLMOTIVO.TabIndex = 2
        Me.LBLMOTIVO.Text = "Motivo"
        '
        'LBLMOTORISTA
        '
        Me.LBLMOTORISTA.BackColor = System.Drawing.Color.Transparent
        Me.LBLMOTORISTA.Font = New System.Drawing.Font("Maiandra GD", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLMOTORISTA.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.LBLMOTORISTA.Location = New System.Drawing.Point(11, 90)
        Me.LBLMOTORISTA.Name = "LBLMOTORISTA"
        Me.LBLMOTORISTA.Size = New System.Drawing.Size(53, 17)
        Me.LBLMOTORISTA.TabIndex = 0
        Me.LBLMOTORISTA.Text = "Motorista"
        '
        'TxtMotivo
        '
        Me.TxtMotivo.Ativar_CasasDecimais = False
        Me.TxtMotivo.Ativar_so_Letras = True
        Me.TxtMotivo.Ativar_so_Numeros = False
        Me.TxtMotivo.AtivarSoNumeroSemFormatacao_ = False
        Me.TxtMotivo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtMotivo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtMotivo.DefaultText = ""
        Me.TxtMotivo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtMotivo.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtMotivo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtMotivo.DisabledState.Parent = Me.TxtMotivo
        Me.TxtMotivo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtMotivo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtMotivo.FocusedState.Parent = Me.TxtMotivo
        Me.TxtMotivo.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtMotivo.HoverState.Parent = Me.TxtMotivo
        Me.TxtMotivo.Location = New System.Drawing.Point(11, 179)
        Me.TxtMotivo.Name = "TxtMotivo"
        Me.TxtMotivo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtMotivo.PlaceholderText = ""
        Me.TxtMotivo.SelectedText = ""
        Me.TxtMotivo.ShadowDecoration.Parent = Me.TxtMotivo
        Me.TxtMotivo.Size = New System.Drawing.Size(264, 31)
        Me.TxtMotivo.TabIndex = 2
        '
        'TxtMotorista
        '
        Me.TxtMotorista.Ativar_CasasDecimais = False
        Me.TxtMotorista.Ativar_so_Letras = True
        Me.TxtMotorista.Ativar_so_Numeros = False
        Me.TxtMotorista.AtivarSoNumeroSemFormatacao_ = False
        Me.TxtMotorista.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtMotorista.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtMotorista.DefaultText = ""
        Me.TxtMotorista.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtMotorista.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtMotorista.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtMotorista.DisabledState.Parent = Me.TxtMotorista
        Me.TxtMotorista.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtMotorista.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtMotorista.FocusedState.Parent = Me.TxtMotorista
        Me.TxtMotorista.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtMotorista.HoverState.Parent = Me.TxtMotorista
        Me.TxtMotorista.Location = New System.Drawing.Point(11, 111)
        Me.TxtMotorista.Name = "TxtMotorista"
        Me.TxtMotorista.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtMotorista.PlaceholderText = ""
        Me.TxtMotorista.SelectedText = ""
        Me.TxtMotorista.ShadowDecoration.Parent = Me.TxtMotorista
        Me.TxtMotorista.Size = New System.Drawing.Size(264, 31)
        Me.TxtMotorista.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.TxtMotorista.TabIndex = 1
        '
        'DGVdados
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.DGVdados.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVdados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGVdados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGVdados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGVdados.BackgroundColor = System.Drawing.Color.White
        Me.DGVdados.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGVdados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVdados.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGVdados.ColumnHeadersHeight = 40
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVdados.DefaultCellStyle = DataGridViewCellStyle3
        Me.DGVdados.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.DGVdados.EnableHeadersVisualStyles = False
        Me.DGVdados.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGVdados.Location = New System.Drawing.Point(281, 34)
        Me.DGVdados.MultiSelect = False
        Me.DGVdados.Name = "DGVdados"
        Me.DGVdados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVdados.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DGVdados.RowHeadersWidth = 60
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DGVdados.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.DGVdados.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.DGVdados.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVdados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVdados.Size = New System.Drawing.Size(634, 259)
        Me.DGVdados.TabIndex = 3
        Me.DGVdados.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.DGVdados.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.DGVdados.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DGVdados.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DGVdados.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DGVdados.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DGVdados.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.DGVdados.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGVdados.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGVdados.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DGVdados.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.DGVdados.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DGVdados.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DGVdados.ThemeStyle.HeaderStyle.Height = 40
        Me.DGVdados.ThemeStyle.ReadOnly = False
        Me.DGVdados.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.DGVdados.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        Me.DGVdados.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.DGVdados.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DGVdados.ThemeStyle.RowsStyle.Height = 22
        Me.DGVdados.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGVdados.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'FrmInfratores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(933, 375)
        Me.Controls.Add(Me.PainelEntrada)
        Me.Controls.Add(Me.Panel_Botões)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmInfratores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "  INFRATORES"
        Me.Panel_Botões.ResumeLayout(False)
        Me.PainelEntrada.ResumeLayout(False)
        Me.PainelEntrada.PerformLayout()
        CType(Me.DGVdados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel_Botões As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents PainelEntrada As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents BTEXCLUIR As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTEDITAR As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTADICIONAR As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents LBLMOTIVO As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents LBLMOTORISTA As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents BTSAIR As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TxtMotivo As TextboxMonetário
    Friend WithEvents DGVdados As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents TXTID As TextboxMonetário
    Public WithEvents TxtMotorista As TextboxMonetário
    Friend WithEvents BTBUSCAR As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTLISTAR_INFRATORES As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents CBOEmpresa As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents BTCADEMPRESA As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents LLCarregarAtualizar As LinkLabel
End Class
