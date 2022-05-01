<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRMControlePesagemManual_
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
	 Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRMControlePesagemManual_))
		Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Me.BTLIMPAR = New System.Windows.Forms.Button()
		Me.BTINSERIR = New System.Windows.Forms.Button()
		Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
		Me.NotifyIconControlePesagemManual = New System.Windows.Forms.NotifyIcon(Me.components)
		Me.BTN_IMPRIMIR = New System.Windows.Forms.Button()
		Me.BTSALVAR = New System.Windows.Forms.Button()
		Me.BTCARREGAR = New System.Windows.Forms.Button()
		Me.BTDELETAR = New System.Windows.Forms.Button()
		Me.DgvDados = New System.Windows.Forms.DataGridView()
		Me.CODIGO = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.PLACA = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.PESO_BRUTO = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.PESO_TARA = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.PESO_LIQUIDO = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.MOTORISTA = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.CLIENTE = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.TRANSPORTADORA = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.OPCAO_DE_ENTRADA = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.OPCAO_DE_SAIDA = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.STATUS = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.RESIDUO = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.TabPage_EnviarEmail = New System.Windows.Forms.TabPage()
		Me.TxtEnviarEmail = New Guna.UI2.WinForms.Guna2Button()
		Me.BTexcluiranexos = New Guna.UI2.WinForms.Guna2Button()
		Me.BTincluiranexos = New Guna.UI2.WinForms.Guna2Button()
		Me.Lista_de_Anexos = New System.Windows.Forms.ListBox()
		Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
		Me.CboServidor = New Guna.UI2.WinForms.Guna2ComboBox()
		Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
		Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
		Me.CBOPrioridade = New Guna.UI2.WinForms.Guna2ComboBox()
		Me.TxtPorta = New Guna.UI2.WinForms.Guna2TextBox()
		Me.TXTNomeUserEmail = New Guna.UI2.WinForms.Guna2TextBox()
		Me.TXTmessage = New Guna.UI2.WinForms.Guna2TextBox()
		Me.TXTfrom = New Guna.UI2.WinForms.Guna2TextBox()
		Me.TXTSubject = New Guna.UI2.WinForms.Guna2TextBox()
		Me.TXTto = New Guna.UI2.WinForms.Guna2TextBox()
		Me.TxtSenha = New Guna.UI2.WinForms.Guna2TextBox()
		Me.TabPagePesqCNPJ = New System.Windows.Forms.TabPage()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.GBAtividades = New System.Windows.Forms.GroupBox()
		Me.TreeView_Atividades = New System.Windows.Forms.TreeView()
		Me.LblData_situacao_especial = New Bunifu.Framework.UI.BunifuCustomLabel()
		Me.LblSituacao_especia = New Bunifu.Framework.UI.BunifuCustomLabel()
		Me.LblMotivo_situacao = New Bunifu.Framework.UI.BunifuCustomLabel()
		Me.LblEfr = New Bunifu.Framework.UI.BunifuCustomLabel()
		Me.LblComplemento = New Bunifu.Framework.UI.BunifuCustomLabel()
		Me.LblCep = New Bunifu.Framework.UI.BunifuCustomLabel()
		Me.LblTipo = New Bunifu.Framework.UI.BunifuCustomLabel()
		Me.LblNumero = New Bunifu.Framework.UI.BunifuCustomLabel()
		Me.LblData_Situacao = New Bunifu.Framework.UI.BunifuCustomLabel()
		Me.LblNome = New Bunifu.Framework.UI.BunifuCustomLabel()
		Me.LblMunicipio = New Bunifu.Framework.UI.BunifuCustomLabel()
		Me.LblUF = New Bunifu.Framework.UI.BunifuCustomLabel()
		Me.LblPorte = New Bunifu.Framework.UI.BunifuCustomLabel()
		Me.LblLogradouro = New Bunifu.Framework.UI.BunifuCustomLabel()
		Me.LblBairro = New Bunifu.Framework.UI.BunifuCustomLabel()
		Me.LblAbertura = New Bunifu.Framework.UI.BunifuCustomLabel()
		Me.LblSituacao = New Bunifu.Framework.UI.BunifuCustomLabel()
		Me.LblEmail = New Bunifu.Framework.UI.BunifuCustomLabel()
		Me.LblStatus = New Bunifu.Framework.UI.BunifuCustomLabel()
		Me.LblTelefone = New Bunifu.Framework.UI.BunifuCustomLabel()
		Me.LblNatureza_juridica = New Bunifu.Framework.UI.BunifuCustomLabel()
		Me.LblUltima_atualizacao = New Bunifu.Framework.UI.BunifuCustomLabel()
		Me.LblFantasia = New Bunifu.Framework.UI.BunifuCustomLabel()
		Me.LblCnpj = New Bunifu.Framework.UI.BunifuCustomLabel()
		Me.BTpesquisar = New Guna.UI2.WinForms.Guna2Button()
		Me.TXTResult = New System.Windows.Forms.RichTextBox()
		Me.TXTCNPJ = New Guna.UI2.WinForms.Guna2TextBox()
		Me.TabPageSaida = New System.Windows.Forms.TabPage()
		Me.LBLCODIGO = New System.Windows.Forms.Label()
		Me.Label13 = New System.Windows.Forms.Label()
		Me.Label27 = New System.Windows.Forms.Label()
		Me.Label26 = New System.Windows.Forms.Label()
		Me.Label25 = New System.Windows.Forms.Label()
		Me.BTPESARSAIDA = New Guna.UI2.WinForms.Guna2CircleButton()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.Label12 = New System.Windows.Forms.Label()
		Me.Label9 = New System.Windows.Forms.Label()
		Me.Label10 = New System.Windows.Forms.Label()
		Me.Label11 = New System.Windows.Forms.Label()
		Me.TXTSTATUS = New Principal.TextboxMonetário()
		Me.TXTPESOBRUTO_LEITURA = New Principal.TextboxMonetário()
		Me.TXTTRASNPORTADORSAIDA = New Principal.TextboxMonetário()
		Me.TXTCLIENTESAIDA = New Principal.TextboxMonetário()
		Me.TXTMOTORISTA_SAIDA = New Principal.TextboxMonetário()
		Me.TXTRESIDUO = New Principal.TextboxMonetário()
		Me.TXTPESO_TARA = New Principal.TextboxMonetário()
		Me.TXTPLACA_SAIDA = New Principal.TextboxMonetário()
		Me.TxtOpcaoEntrada_Saida = New Principal.TextboxMonetário()
		Me.TXTOPCAODESAIDA = New Principal.TextboxMonetário()
		Me.TabPageEntrada = New System.Windows.Forms.TabPage()
		Me.IPsMaquina = New System.Windows.Forms.Label()
		Me.BTcadastrarTransportadora = New Guna.UI2.WinForms.Guna2CircleButton()
		Me.BTcadastrarCliente = New Guna.UI2.WinForms.Guna2CircleButton()
		Me.BTcadastrarResiduo = New Guna.UI2.WinForms.Guna2CircleButton()
		Me.BTPESARENTRADA = New Guna.UI2.WinForms.Guna2CircleButton()
		Me.CBOTRANSPORTADORENTRADA = New Guna.UI2.WinForms.Guna2ComboBox()
		Me.CBOCLIENTEENTRADA = New Guna.UI2.WinForms.Guna2ComboBox()
		Me.CBOCADASTRARRESIDUOS = New Guna.UI2.WinForms.Guna2ComboBox()
		Me.TXTOPCAODEENTRADA = New Principal.TextboxMonetário()
		Me.TXTMOTORISTA_ENTRADA = New Principal.TextboxMonetário()
		Me.TXTPESO_BRUTO = New Principal.TextboxMonetário()
		Me.TXTPLACA_ENTRADA = New Principal.TextboxMonetário()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label24 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.LBLPLACA = New System.Windows.Forms.Label()
		Me.TabControl = New System.Windows.Forms.TabControl()
		Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
		CType(Me.DgvDados, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.TabPage_EnviarEmail.SuspendLayout()
		Me.TabPagePesqCNPJ.SuspendLayout()
		Me.GroupBox1.SuspendLayout()
		Me.GBAtividades.SuspendLayout()
		Me.TabPageSaida.SuspendLayout()
		Me.TabPageEntrada.SuspendLayout()
		Me.TabControl.SuspendLayout()
		Me.SuspendLayout()
		'
		'BTLIMPAR
		'
		resources.ApplyResources(Me.BTLIMPAR, "BTLIMPAR")
		Me.BTLIMPAR.BackColor = System.Drawing.Color.Ivory
		Me.BTLIMPAR.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
		Me.BTLIMPAR.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray
		Me.BTLIMPAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
		Me.BTLIMPAR.ForeColor = System.Drawing.Color.DarkGray
		Me.BTLIMPAR.Name = "BTLIMPAR"
		Me.BTLIMPAR.UseVisualStyleBackColor = False
		'
		'BTINSERIR
		'
		resources.ApplyResources(Me.BTINSERIR, "BTINSERIR")
		Me.BTINSERIR.BackColor = System.Drawing.Color.Ivory
		Me.BTINSERIR.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
		Me.BTINSERIR.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray
		Me.BTINSERIR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
		Me.BTINSERIR.ForeColor = System.Drawing.Color.DarkGray
		Me.BTINSERIR.Name = "BTINSERIR"
		Me.BTINSERIR.UseVisualStyleBackColor = False
		'
		'ImageList1
		'
		Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
		Me.ImageList1.TransparentColor = System.Drawing.Color.LightSalmon
		Me.ImageList1.Images.SetKeyName(0, "pencil_delete.png")
		Me.ImageList1.Images.SetKeyName(1, "VITAL ENGENHARIA.png")
		'
		'NotifyIconControlePesagemManual
		'
		resources.ApplyResources(Me.NotifyIconControlePesagemManual, "NotifyIconControlePesagemManual")
		'
		'BTN_IMPRIMIR
		'
		resources.ApplyResources(Me.BTN_IMPRIMIR, "BTN_IMPRIMIR")
		Me.BTN_IMPRIMIR.BackColor = System.Drawing.Color.Ivory
		Me.BTN_IMPRIMIR.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
		Me.BTN_IMPRIMIR.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray
		Me.BTN_IMPRIMIR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
		Me.BTN_IMPRIMIR.ForeColor = System.Drawing.Color.DarkGray
		Me.BTN_IMPRIMIR.Name = "BTN_IMPRIMIR"
		Me.BTN_IMPRIMIR.UseVisualStyleBackColor = False
		'
		'BTSALVAR
		'
		resources.ApplyResources(Me.BTSALVAR, "BTSALVAR")
		Me.BTSALVAR.BackColor = System.Drawing.Color.Ivory
		Me.BTSALVAR.DialogResult = System.Windows.Forms.DialogResult.OK
		Me.BTSALVAR.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
		Me.BTSALVAR.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray
		Me.BTSALVAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
		Me.BTSALVAR.ForeColor = System.Drawing.Color.DarkGray
		Me.BTSALVAR.Name = "BTSALVAR"
		Me.BTSALVAR.UseVisualStyleBackColor = False
		'
		'BTCARREGAR
		'
		resources.ApplyResources(Me.BTCARREGAR, "BTCARREGAR")
		Me.BTCARREGAR.BackColor = System.Drawing.Color.Ivory
		Me.BTCARREGAR.DialogResult = System.Windows.Forms.DialogResult.OK
		Me.BTCARREGAR.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
		Me.BTCARREGAR.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray
		Me.BTCARREGAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
		Me.BTCARREGAR.ForeColor = System.Drawing.Color.DarkGray
		Me.BTCARREGAR.Name = "BTCARREGAR"
		Me.BTCARREGAR.UseVisualStyleBackColor = False
		'
		'BTDELETAR
		'
		resources.ApplyResources(Me.BTDELETAR, "BTDELETAR")
		Me.BTDELETAR.BackColor = System.Drawing.Color.Ivory
		Me.BTDELETAR.DialogResult = System.Windows.Forms.DialogResult.OK
		Me.BTDELETAR.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
		Me.BTDELETAR.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray
		Me.BTDELETAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
		Me.BTDELETAR.ForeColor = System.Drawing.Color.DarkGray
		Me.BTDELETAR.Name = "BTDELETAR"
		Me.BTDELETAR.UseVisualStyleBackColor = False
		'
		'DgvDados
		'
		Me.DgvDados.AllowUserToOrderColumns = True
		DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
		DataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkGray
		DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkGray
		DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Green
		Me.DgvDados.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
		resources.ApplyResources(Me.DgvDados, "DgvDados")
		Me.DgvDados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
		Me.DgvDados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
		Me.DgvDados.BackgroundColor = System.Drawing.Color.WhiteSmoke
		Me.DgvDados.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.DgvDados.CausesValidation = False
		Me.DgvDados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
		DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
		DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
		DataGridViewCellStyle2.Font = New System.Drawing.Font("Mongolian Baiti", 9.75!)
		DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gray
		DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Window
		DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.DimGray
		DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.DgvDados.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
		Me.DgvDados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CODIGO, Me.PLACA, Me.PESO_BRUTO, Me.PESO_TARA, Me.PESO_LIQUIDO, Me.MOTORISTA, Me.CLIENTE, Me.TRANSPORTADORA, Me.OPCAO_DE_ENTRADA, Me.OPCAO_DE_SAIDA, Me.STATUS, Me.RESIDUO})
		DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
		DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
		DataGridViewCellStyle3.Font = New System.Drawing.Font("Mongolian Baiti", 9.75!)
		DataGridViewCellStyle3.ForeColor = System.Drawing.Color.DimGray
		DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White
		DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.DimGray
		DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
		Me.DgvDados.DefaultCellStyle = DataGridViewCellStyle3
		Me.DgvDados.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
		Me.DgvDados.GridColor = System.Drawing.Color.Gainsboro
		Me.DgvDados.MultiSelect = False
		Me.DgvDados.Name = "DgvDados"
		DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
		DataGridViewCellStyle4.BackColor = System.Drawing.Color.Silver
		DataGridViewCellStyle4.Font = New System.Drawing.Font("Mongolian Baiti", 9.75!)
		DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
		DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White
		DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.MediumBlue
		DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.DgvDados.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
		Me.DgvDados.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
		DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
		DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
		DataGridViewCellStyle5.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		DataGridViewCellStyle5.ForeColor = System.Drawing.Color.DimGray
		DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White
		DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.DarkGray
		Me.DgvDados.RowsDefaultCellStyle = DataGridViewCellStyle5
		Me.DgvDados.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
		Me.DgvDados.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.WhiteSmoke
		Me.DgvDados.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.DgvDados.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.DimGray
		Me.DgvDados.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Azure
		Me.DgvDados.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.DimGray
		Me.DgvDados.RowTemplate.Height = 23
		Me.DgvDados.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
		Me.DgvDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		'
		'CODIGO
		'
		Me.CODIGO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
		resources.ApplyResources(Me.CODIGO, "CODIGO")
		Me.CODIGO.Name = "CODIGO"
		Me.CODIGO.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
		'
		'PLACA
		'
		Me.PLACA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
		resources.ApplyResources(Me.PLACA, "PLACA")
		Me.PLACA.Name = "PLACA"
		'
		'PESO_BRUTO
		'
		Me.PESO_BRUTO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
		resources.ApplyResources(Me.PESO_BRUTO, "PESO_BRUTO")
		Me.PESO_BRUTO.Name = "PESO_BRUTO"
		'
		'PESO_TARA
		'
		Me.PESO_TARA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
		resources.ApplyResources(Me.PESO_TARA, "PESO_TARA")
		Me.PESO_TARA.Name = "PESO_TARA"
		'
		'PESO_LIQUIDO
		'
		Me.PESO_LIQUIDO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
		resources.ApplyResources(Me.PESO_LIQUIDO, "PESO_LIQUIDO")
		Me.PESO_LIQUIDO.Name = "PESO_LIQUIDO"
		'
		'MOTORISTA
		'
		Me.MOTORISTA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
		resources.ApplyResources(Me.MOTORISTA, "MOTORISTA")
		Me.MOTORISTA.Name = "MOTORISTA"
		'
		'CLIENTE
		'
		Me.CLIENTE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
		resources.ApplyResources(Me.CLIENTE, "CLIENTE")
		Me.CLIENTE.Name = "CLIENTE"
		'
		'TRANSPORTADORA
		'
		Me.TRANSPORTADORA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
		resources.ApplyResources(Me.TRANSPORTADORA, "TRANSPORTADORA")
		Me.TRANSPORTADORA.Name = "TRANSPORTADORA"
		'
		'OPCAO_DE_ENTRADA
		'
		Me.OPCAO_DE_ENTRADA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
		resources.ApplyResources(Me.OPCAO_DE_ENTRADA, "OPCAO_DE_ENTRADA")
		Me.OPCAO_DE_ENTRADA.Name = "OPCAO_DE_ENTRADA"
		'
		'OPCAO_DE_SAIDA
		'
		Me.OPCAO_DE_SAIDA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
		resources.ApplyResources(Me.OPCAO_DE_SAIDA, "OPCAO_DE_SAIDA")
		Me.OPCAO_DE_SAIDA.Name = "OPCAO_DE_SAIDA"
		'
		'STATUS
		'
		Me.STATUS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
		resources.ApplyResources(Me.STATUS, "STATUS")
		Me.STATUS.Name = "STATUS"
		'
		'RESIDUO
		'
		Me.RESIDUO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
		resources.ApplyResources(Me.RESIDUO, "RESIDUO")
		Me.RESIDUO.Name = "RESIDUO"
		'
		'TabPage_EnviarEmail
		'
		Me.TabPage_EnviarEmail.BackColor = System.Drawing.Color.Azure
		Me.TabPage_EnviarEmail.Controls.Add(Me.TxtEnviarEmail)
		Me.TabPage_EnviarEmail.Controls.Add(Me.BTexcluiranexos)
		Me.TabPage_EnviarEmail.Controls.Add(Me.BTincluiranexos)
		Me.TabPage_EnviarEmail.Controls.Add(Me.Lista_de_Anexos)
		Me.TabPage_EnviarEmail.Controls.Add(Me.Guna2HtmlLabel3)
		Me.TabPage_EnviarEmail.Controls.Add(Me.CboServidor)
		Me.TabPage_EnviarEmail.Controls.Add(Me.Guna2HtmlLabel2)
		Me.TabPage_EnviarEmail.Controls.Add(Me.Guna2HtmlLabel1)
		Me.TabPage_EnviarEmail.Controls.Add(Me.CBOPrioridade)
		Me.TabPage_EnviarEmail.Controls.Add(Me.TxtPorta)
		Me.TabPage_EnviarEmail.Controls.Add(Me.TXTNomeUserEmail)
		Me.TabPage_EnviarEmail.Controls.Add(Me.TXTmessage)
		Me.TabPage_EnviarEmail.Controls.Add(Me.TXTfrom)
		Me.TabPage_EnviarEmail.Controls.Add(Me.TXTSubject)
		Me.TabPage_EnviarEmail.Controls.Add(Me.TXTto)
		Me.TabPage_EnviarEmail.Controls.Add(Me.TxtSenha)
		resources.ApplyResources(Me.TabPage_EnviarEmail, "TabPage_EnviarEmail")
		Me.TabPage_EnviarEmail.Name = "TabPage_EnviarEmail"
		'
		'TxtEnviarEmail
		'
		Me.TxtEnviarEmail.Animated = True
		Me.TxtEnviarEmail.BorderColor = System.Drawing.Color.Gainsboro
		Me.TxtEnviarEmail.BorderThickness = 1
		Me.TxtEnviarEmail.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton
		Me.TxtEnviarEmail.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.TxtEnviarEmail.CheckedState.FillColor = System.Drawing.Color.Lime
		Me.TxtEnviarEmail.CheckedState.Parent = Me.TxtEnviarEmail
		Me.TxtEnviarEmail.CustomImages.Parent = Me.TxtEnviarEmail
		Me.TxtEnviarEmail.FillColor = System.Drawing.Color.WhiteSmoke
		resources.ApplyResources(Me.TxtEnviarEmail, "TxtEnviarEmail")
		Me.TxtEnviarEmail.ForeColor = System.Drawing.Color.DimGray
		Me.TxtEnviarEmail.HoverState.Parent = Me.TxtEnviarEmail
		Me.TxtEnviarEmail.Name = "TxtEnviarEmail"
		Me.TxtEnviarEmail.PressedColor = System.Drawing.Color.Khaki
		Me.TxtEnviarEmail.ShadowDecoration.Parent = Me.TxtEnviarEmail
		'
		'BTexcluiranexos
		'
		Me.BTexcluiranexos.Animated = True
		Me.BTexcluiranexos.BorderColor = System.Drawing.Color.Gainsboro
		Me.BTexcluiranexos.BorderThickness = 1
		Me.BTexcluiranexos.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton
		Me.BTexcluiranexos.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.BTexcluiranexos.CheckedState.FillColor = System.Drawing.Color.Lime
		Me.BTexcluiranexos.CheckedState.Parent = Me.BTexcluiranexos
		Me.BTexcluiranexos.CustomImages.Parent = Me.BTexcluiranexos
		Me.BTexcluiranexos.FillColor = System.Drawing.Color.WhiteSmoke
		resources.ApplyResources(Me.BTexcluiranexos, "BTexcluiranexos")
		Me.BTexcluiranexos.ForeColor = System.Drawing.Color.DimGray
		Me.BTexcluiranexos.HoverState.Parent = Me.BTexcluiranexos
		Me.BTexcluiranexos.Name = "BTexcluiranexos"
		Me.BTexcluiranexos.PressedColor = System.Drawing.Color.Khaki
		Me.BTexcluiranexos.ShadowDecoration.Parent = Me.BTexcluiranexos
		'
		'BTincluiranexos
		'
		Me.BTincluiranexos.Animated = True
		Me.BTincluiranexos.BorderColor = System.Drawing.Color.Gainsboro
		Me.BTincluiranexos.BorderThickness = 1
		Me.BTincluiranexos.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton
		Me.BTincluiranexos.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.BTincluiranexos.CheckedState.FillColor = System.Drawing.Color.Lime
		Me.BTincluiranexos.CheckedState.Parent = Me.BTincluiranexos
		Me.BTincluiranexos.CustomImages.Parent = Me.BTincluiranexos
		Me.BTincluiranexos.FillColor = System.Drawing.Color.WhiteSmoke
		resources.ApplyResources(Me.BTincluiranexos, "BTincluiranexos")
		Me.BTincluiranexos.ForeColor = System.Drawing.Color.DimGray
		Me.BTincluiranexos.HoverState.Parent = Me.BTincluiranexos
		Me.BTincluiranexos.Name = "BTincluiranexos"
		Me.BTincluiranexos.PressedColor = System.Drawing.Color.Khaki
		Me.BTincluiranexos.ShadowDecoration.Parent = Me.BTincluiranexos
		'
		'Lista_de_Anexos
		'
		resources.ApplyResources(Me.Lista_de_Anexos, "Lista_de_Anexos")
		Me.Lista_de_Anexos.BackColor = System.Drawing.Color.White
		Me.Lista_de_Anexos.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Lista_de_Anexos.ForeColor = System.Drawing.Color.DimGray
		Me.Lista_de_Anexos.FormattingEnabled = True
		Me.Lista_de_Anexos.Name = "Lista_de_Anexos"
		'
		'Guna2HtmlLabel3
		'
		Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
		resources.ApplyResources(Me.Guna2HtmlLabel3, "Guna2HtmlLabel3")
		Me.Guna2HtmlLabel3.ForeColor = System.Drawing.Color.DimGray
		Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
		'
		'CboServidor
		'
		Me.CboServidor.Animated = True
		Me.CboServidor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
		Me.CboServidor.BackColor = System.Drawing.Color.Transparent
		Me.CboServidor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
		Me.CboServidor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.CboServidor.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.CboServidor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.CboServidor.FocusedState.Parent = Me.CboServidor
		resources.ApplyResources(Me.CboServidor, "CboServidor")
		Me.CboServidor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
		Me.CboServidor.HoverState.Parent = Me.CboServidor
		Me.CboServidor.Items.AddRange(New Object() {resources.GetString("CboServidor.Items"), resources.GetString("CboServidor.Items1"), resources.GetString("CboServidor.Items2"), resources.GetString("CboServidor.Items3"), resources.GetString("CboServidor.Items4"), resources.GetString("CboServidor.Items5"), resources.GetString("CboServidor.Items6")})
		Me.CboServidor.ItemsAppearance.Parent = Me.CboServidor
		Me.CboServidor.Name = "CboServidor"
		Me.CboServidor.ShadowDecoration.Parent = Me.CboServidor
		Me.CboServidor.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(2)
		'
		'Guna2HtmlLabel2
		'
		Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
		resources.ApplyResources(Me.Guna2HtmlLabel2, "Guna2HtmlLabel2")
		Me.Guna2HtmlLabel2.ForeColor = System.Drawing.Color.DimGray
		Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
		'
		'Guna2HtmlLabel1
		'
		Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
		resources.ApplyResources(Me.Guna2HtmlLabel1, "Guna2HtmlLabel1")
		Me.Guna2HtmlLabel1.ForeColor = System.Drawing.Color.DimGray
		Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
		'
		'CBOPrioridade
		'
		Me.CBOPrioridade.BackColor = System.Drawing.Color.Transparent
		Me.CBOPrioridade.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
		Me.CBOPrioridade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.CBOPrioridade.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.CBOPrioridade.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.CBOPrioridade.FocusedState.Parent = Me.CBOPrioridade
		resources.ApplyResources(Me.CBOPrioridade, "CBOPrioridade")
		Me.CBOPrioridade.ForeColor = System.Drawing.Color.DimGray
		Me.CBOPrioridade.HoverState.Parent = Me.CBOPrioridade
		Me.CBOPrioridade.Items.AddRange(New Object() {resources.GetString("CBOPrioridade.Items"), resources.GetString("CBOPrioridade.Items1"), resources.GetString("CBOPrioridade.Items2")})
		Me.CBOPrioridade.ItemsAppearance.Parent = Me.CBOPrioridade
		Me.CBOPrioridade.Name = "CBOPrioridade"
		Me.CBOPrioridade.ShadowDecoration.Parent = Me.CBOPrioridade
		Me.CBOPrioridade.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(2)
		'
		'TxtPorta
		'
		Me.TxtPorta.AllowDrop = True
		Me.TxtPorta.Animated = True
		Me.TxtPorta.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
		Me.TxtPorta.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
		Me.TxtPorta.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.TxtPorta.DefaultText = "587"
		Me.TxtPorta.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
		Me.TxtPorta.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
		Me.TxtPorta.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.TxtPorta.DisabledState.Parent = Me.TxtPorta
		Me.TxtPorta.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.TxtPorta.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.TxtPorta.FocusedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
		Me.TxtPorta.FocusedState.ForeColor = System.Drawing.Color.DimGray
		Me.TxtPorta.FocusedState.Parent = Me.TxtPorta
		Me.TxtPorta.FocusedState.PlaceholderForeColor = System.Drawing.Color.DimGray
		Me.TxtPorta.HoverState.BorderColor = System.Drawing.Color.OrangeRed
		Me.TxtPorta.HoverState.FillColor = System.Drawing.Color.White
		Me.TxtPorta.HoverState.ForeColor = System.Drawing.Color.DimGray
		Me.TxtPorta.HoverState.Parent = Me.TxtPorta
		Me.TxtPorta.HoverState.PlaceholderForeColor = System.Drawing.Color.Gray
		Me.TxtPorta.IconLeft = Global.Principal.My.Resources.Resources.configuration_config_system_1540
		resources.ApplyResources(Me.TxtPorta, "TxtPorta")
		Me.TxtPorta.Name = "TxtPorta"
		Me.TxtPorta.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.TxtPorta.PlaceholderText = "PORTA"
		Me.TxtPorta.SelectedText = ""
		Me.TxtPorta.SelectionStart = 3
		Me.TxtPorta.ShadowDecoration.Parent = Me.TxtPorta
		Me.TxtPorta.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
		Me.TxtPorta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'TXTNomeUserEmail
		'
		Me.TXTNomeUserEmail.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.TXTNomeUserEmail.DefaultText = ""
		Me.TXTNomeUserEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
		Me.TXTNomeUserEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
		Me.TXTNomeUserEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.TXTNomeUserEmail.DisabledState.Parent = Me.TXTNomeUserEmail
		Me.TXTNomeUserEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.TXTNomeUserEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.TXTNomeUserEmail.FocusedState.Parent = Me.TXTNomeUserEmail
		Me.TXTNomeUserEmail.ForeColor = System.Drawing.Color.DimGray
		Me.TXTNomeUserEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.TXTNomeUserEmail.HoverState.Parent = Me.TXTNomeUserEmail
		Me.TXTNomeUserEmail.IconLeft = CType(resources.GetObject("TXTNomeUserEmail.IconLeft"), System.Drawing.Image)
		resources.ApplyResources(Me.TXTNomeUserEmail, "TXTNomeUserEmail")
		Me.TXTNomeUserEmail.Name = "TXTNomeUserEmail"
		Me.TXTNomeUserEmail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.TXTNomeUserEmail.PlaceholderText = "NOME DE USUÁRIO OU E-MAIL"
		Me.TXTNomeUserEmail.SelectedText = ""
		Me.TXTNomeUserEmail.ShadowDecoration.Parent = Me.TXTNomeUserEmail
		Me.TXTNomeUserEmail.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
		Me.TXTNomeUserEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'TXTmessage
		'
		resources.ApplyResources(Me.TXTmessage, "TXTmessage")
		Me.TXTmessage.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.TXTmessage.DefaultText = ""
		Me.TXTmessage.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
		Me.TXTmessage.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
		Me.TXTmessage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.TXTmessage.DisabledState.Parent = Me.TXTmessage
		Me.TXTmessage.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.TXTmessage.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.TXTmessage.FocusedState.Parent = Me.TXTmessage
		Me.TXTmessage.ForeColor = System.Drawing.Color.DimGray
		Me.TXTmessage.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.TXTmessage.HoverState.Parent = Me.TXTmessage
		Me.TXTmessage.IconLeft = Global.Principal.My.Resources.Resources.bullet_go
		Me.TXTmessage.IconLeftSize = New System.Drawing.Size(30, 30)
		Me.TXTmessage.IconRightSize = New System.Drawing.Size(90, 90)
		Me.TXTmessage.Multiline = True
		Me.TXTmessage.Name = "TXTmessage"
		Me.TXTmessage.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.TXTmessage.PlaceholderForeColor = System.Drawing.Color.DimGray
		Me.TXTmessage.PlaceholderText = "DIGITE SUA MENSAGEM "
		Me.TXTmessage.SelectedText = ""
		Me.TXTmessage.ShadowDecoration.Parent = Me.TXTmessage
		Me.TXTmessage.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
		Me.TXTmessage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'TXTfrom
		'
		Me.TXTfrom.Animated = True
		Me.TXTfrom.AutoCompleteCustomSource.AddRange(New String() {"marcosferreira@vitalambiental.com.br", "mmarcos.fferreira@gmail.com", "mmarcos.fferreira078@gmail.com", "aaraujo@vitalambiental.com.br", "anderson.fernandes@vitalambiental.com.br", "wlima@vitalambiental.com.br", "ppereira@vitalambiental.com.br", "spdias@vitalambiental.com.br", "rafaela.santos@vitalambiental.com.br", "marcos.andrade@vitalambiental.com.br", "cigidio@vitalambiental.com.br", "terezinha.oliveira@vitalambiental.com.br", "wanessa.alcantara@vitalambiental.com.br", "jesilva@vitalambiental.com.br", "thales.dutra@vitalambiental.com.br", "welison.artuso@vitalambiental.com.br", "marodrigues@vitalambiental.com.br", "sandra.ferraz@vitalambiental.com.br", "wildes.rocha@vitalambiental.com.br"})
		Me.TXTfrom.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
		Me.TXTfrom.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
		Me.TXTfrom.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.TXTfrom.DefaultText = ""
		Me.TXTfrom.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
		Me.TXTfrom.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
		Me.TXTfrom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.TXTfrom.DisabledState.Parent = Me.TXTfrom
		Me.TXTfrom.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.TXTfrom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.TXTfrom.FocusedState.Parent = Me.TXTfrom
		resources.ApplyResources(Me.TXTfrom, "TXTfrom")
		Me.TXTfrom.ForeColor = System.Drawing.Color.DimGray
		Me.TXTfrom.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.TXTfrom.HoverState.Parent = Me.TXTfrom
		Me.TXTfrom.IconLeft = CType(resources.GetObject("TXTfrom.IconLeft"), System.Drawing.Image)
		Me.TXTfrom.Name = "TXTfrom"
		Me.TXTfrom.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.TXTfrom.PlaceholderText = "FROM" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
		Me.TXTfrom.SelectedText = ""
		Me.TXTfrom.ShadowDecoration.Parent = Me.TXTfrom
		Me.TXTfrom.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
		Me.TXTfrom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'TXTSubject
		'
		Me.TXTSubject.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.TXTSubject.DefaultText = ""
		Me.TXTSubject.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
		Me.TXTSubject.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
		Me.TXTSubject.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.TXTSubject.DisabledState.Parent = Me.TXTSubject
		Me.TXTSubject.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.TXTSubject.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.TXTSubject.FocusedState.Parent = Me.TXTSubject
		Me.TXTSubject.ForeColor = System.Drawing.Color.DimGray
		Me.TXTSubject.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.TXTSubject.HoverState.Parent = Me.TXTSubject
		Me.TXTSubject.IconLeft = CType(resources.GetObject("TXTSubject.IconLeft"), System.Drawing.Image)
		resources.ApplyResources(Me.TXTSubject, "TXTSubject")
		Me.TXTSubject.Name = "TXTSubject"
		Me.TXTSubject.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.TXTSubject.PlaceholderText = "SUBJECT"
		Me.TXTSubject.SelectedText = ""
		Me.TXTSubject.ShadowDecoration.Parent = Me.TXTSubject
		Me.TXTSubject.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
		Me.TXTSubject.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'TXTto
		'
		Me.TXTto.Animated = True
		Me.TXTto.AutoCompleteCustomSource.AddRange(New String() {"marcosferreira@vitalambiental.com.br", "mmarcos.fferreira@gmail.com", "mmarcos.fferreira078@gmail.com", "aaraujo@vitalambiental.com.br", "anderson.fernandes@vitalambiental.com.br", "wlima@vitalambiental.com.br", "ppereira@vitalambiental.com.br", "spdias@vitalambiental.com.br", "rafaela.santos@vitalambiental.com.br", "marcos.andrade@vitalambiental.com.br", "cigidio@vitalambiental.com.br", "terezinha.oliveira@vitalambiental.com.br", "wanessa.alcantara@vitalambiental.com.br", "jesilva@vitalambiental.com.br", "thales.dutra@vitalambiental.com.br", "welison.artuso@vitalambiental.com.br", "marodrigues@vitalambiental.com.br", "sandra.ferraz@vitalambiental.com.br", "wildes.rocha@vitalambiental.com.br"})
		Me.TXTto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
		Me.TXTto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
		Me.TXTto.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.TXTto.DefaultText = ""
		Me.TXTto.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
		Me.TXTto.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
		Me.TXTto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.TXTto.DisabledState.Parent = Me.TXTto
		Me.TXTto.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.TXTto.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.TXTto.FocusedState.Parent = Me.TXTto
		Me.TXTto.ForeColor = System.Drawing.Color.DimGray
		Me.TXTto.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.TXTto.HoverState.Parent = Me.TXTto
		Me.TXTto.IconLeft = CType(resources.GetObject("TXTto.IconLeft"), System.Drawing.Image)
		resources.ApplyResources(Me.TXTto, "TXTto")
		Me.TXTto.Name = "TXTto"
		Me.TXTto.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.TXTto.PlaceholderText = "TO"
		Me.TXTto.SelectedText = ""
		Me.TXTto.ShadowDecoration.Parent = Me.TXTto
		Me.TXTto.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
		Me.TXTto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'TxtSenha
		'
		Me.TxtSenha.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.TxtSenha.DefaultText = ""
		Me.TxtSenha.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
		Me.TxtSenha.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
		Me.TxtSenha.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.TxtSenha.DisabledState.Parent = Me.TxtSenha
		Me.TxtSenha.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.TxtSenha.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.TxtSenha.FocusedState.Parent = Me.TxtSenha
		Me.TxtSenha.ForeColor = System.Drawing.Color.DimGray
		Me.TxtSenha.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.TxtSenha.HoverState.Parent = Me.TxtSenha
		Me.TxtSenha.IconLeft = CType(resources.GetObject("TxtSenha.IconLeft"), System.Drawing.Image)
		resources.ApplyResources(Me.TxtSenha, "TxtSenha")
		Me.TxtSenha.Name = "TxtSenha"
		Me.TxtSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.TxtSenha.PlaceholderText = "SENHA DO SEU EMAIL"
		Me.TxtSenha.SelectedText = ""
		Me.TxtSenha.ShadowDecoration.Parent = Me.TxtSenha
		Me.TxtSenha.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
		Me.TxtSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.TxtSenha.UseSystemPasswordChar = True
		'
		'TabPagePesqCNPJ
		'
		Me.TabPagePesqCNPJ.BackColor = System.Drawing.Color.Azure
		Me.TabPagePesqCNPJ.Controls.Add(Me.GroupBox1)
		Me.TabPagePesqCNPJ.Controls.Add(Me.BTpesquisar)
		Me.TabPagePesqCNPJ.Controls.Add(Me.TXTResult)
		Me.TabPagePesqCNPJ.Controls.Add(Me.TXTCNPJ)
		resources.ApplyResources(Me.TabPagePesqCNPJ, "TabPagePesqCNPJ")
		Me.TabPagePesqCNPJ.Name = "TabPagePesqCNPJ"
		'
		'GroupBox1
		'
		Me.GroupBox1.BackColor = System.Drawing.Color.LightCyan
		resources.ApplyResources(Me.GroupBox1, "GroupBox1")
		Me.GroupBox1.Controls.Add(Me.GBAtividades)
		Me.GroupBox1.Controls.Add(Me.LblData_situacao_especial)
		Me.GroupBox1.Controls.Add(Me.LblSituacao_especia)
		Me.GroupBox1.Controls.Add(Me.LblMotivo_situacao)
		Me.GroupBox1.Controls.Add(Me.LblEfr)
		Me.GroupBox1.Controls.Add(Me.LblComplemento)
		Me.GroupBox1.Controls.Add(Me.LblCep)
		Me.GroupBox1.Controls.Add(Me.LblTipo)
		Me.GroupBox1.Controls.Add(Me.LblNumero)
		Me.GroupBox1.Controls.Add(Me.LblData_Situacao)
		Me.GroupBox1.Controls.Add(Me.LblNome)
		Me.GroupBox1.Controls.Add(Me.LblMunicipio)
		Me.GroupBox1.Controls.Add(Me.LblUF)
		Me.GroupBox1.Controls.Add(Me.LblPorte)
		Me.GroupBox1.Controls.Add(Me.LblLogradouro)
		Me.GroupBox1.Controls.Add(Me.LblBairro)
		Me.GroupBox1.Controls.Add(Me.LblAbertura)
		Me.GroupBox1.Controls.Add(Me.LblSituacao)
		Me.GroupBox1.Controls.Add(Me.LblEmail)
		Me.GroupBox1.Controls.Add(Me.LblStatus)
		Me.GroupBox1.Controls.Add(Me.LblTelefone)
		Me.GroupBox1.Controls.Add(Me.LblNatureza_juridica)
		Me.GroupBox1.Controls.Add(Me.LblUltima_atualizacao)
		Me.GroupBox1.Controls.Add(Me.LblFantasia)
		Me.GroupBox1.Controls.Add(Me.LblCnpj)
		Me.GroupBox1.ForeColor = System.Drawing.Color.DimGray
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.TabStop = False
		'
		'GBAtividades
		'
		resources.ApplyResources(Me.GBAtividades, "GBAtividades")
		Me.GBAtividades.BackColor = System.Drawing.Color.LightCyan
		Me.GBAtividades.Controls.Add(Me.TreeView_Atividades)
		Me.GBAtividades.ForeColor = System.Drawing.Color.DimGray
		Me.GBAtividades.Name = "GBAtividades"
		Me.GBAtividades.TabStop = False
		'
		'TreeView_Atividades
		'
		resources.ApplyResources(Me.TreeView_Atividades, "TreeView_Atividades")
		Me.TreeView_Atividades.BackColor = System.Drawing.Color.MintCream
		Me.TreeView_Atividades.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.TreeView_Atividades.ForeColor = System.Drawing.Color.DimGray
		Me.TreeView_Atividades.Name = "TreeView_Atividades"
		'
		'LblData_situacao_especial
		'
		resources.ApplyResources(Me.LblData_situacao_especial, "LblData_situacao_especial")
		Me.LblData_situacao_especial.BackColor = System.Drawing.Color.Transparent
		Me.LblData_situacao_especial.ForeColor = System.Drawing.Color.DimGray
		Me.LblData_situacao_especial.Name = "LblData_situacao_especial"
		'
		'LblSituacao_especia
		'
		resources.ApplyResources(Me.LblSituacao_especia, "LblSituacao_especia")
		Me.LblSituacao_especia.BackColor = System.Drawing.Color.Transparent
		Me.LblSituacao_especia.ForeColor = System.Drawing.Color.DimGray
		Me.LblSituacao_especia.Name = "LblSituacao_especia"
		'
		'LblMotivo_situacao
		'
		resources.ApplyResources(Me.LblMotivo_situacao, "LblMotivo_situacao")
		Me.LblMotivo_situacao.BackColor = System.Drawing.Color.Transparent
		Me.LblMotivo_situacao.ForeColor = System.Drawing.Color.DimGray
		Me.LblMotivo_situacao.Name = "LblMotivo_situacao"
		'
		'LblEfr
		'
		resources.ApplyResources(Me.LblEfr, "LblEfr")
		Me.LblEfr.BackColor = System.Drawing.Color.Transparent
		Me.LblEfr.ForeColor = System.Drawing.Color.DimGray
		Me.LblEfr.Name = "LblEfr"
		'
		'LblComplemento
		'
		resources.ApplyResources(Me.LblComplemento, "LblComplemento")
		Me.LblComplemento.BackColor = System.Drawing.Color.Transparent
		Me.LblComplemento.ForeColor = System.Drawing.Color.DimGray
		Me.LblComplemento.Name = "LblComplemento"
		'
		'LblCep
		'
		resources.ApplyResources(Me.LblCep, "LblCep")
		Me.LblCep.BackColor = System.Drawing.Color.Transparent
		Me.LblCep.ForeColor = System.Drawing.Color.DimGray
		Me.LblCep.Name = "LblCep"
		'
		'LblTipo
		'
		resources.ApplyResources(Me.LblTipo, "LblTipo")
		Me.LblTipo.BackColor = System.Drawing.Color.Transparent
		Me.LblTipo.ForeColor = System.Drawing.Color.DimGray
		Me.LblTipo.Name = "LblTipo"
		'
		'LblNumero
		'
		resources.ApplyResources(Me.LblNumero, "LblNumero")
		Me.LblNumero.BackColor = System.Drawing.Color.Transparent
		Me.LblNumero.ForeColor = System.Drawing.Color.DimGray
		Me.LblNumero.Name = "LblNumero"
		'
		'LblData_Situacao
		'
		resources.ApplyResources(Me.LblData_Situacao, "LblData_Situacao")
		Me.LblData_Situacao.BackColor = System.Drawing.Color.Transparent
		Me.LblData_Situacao.ForeColor = System.Drawing.Color.DimGray
		Me.LblData_Situacao.Name = "LblData_Situacao"
		'
		'LblNome
		'
		resources.ApplyResources(Me.LblNome, "LblNome")
		Me.LblNome.BackColor = System.Drawing.Color.Transparent
		Me.LblNome.ForeColor = System.Drawing.Color.DimGray
		Me.LblNome.Name = "LblNome"
		'
		'LblMunicipio
		'
		resources.ApplyResources(Me.LblMunicipio, "LblMunicipio")
		Me.LblMunicipio.BackColor = System.Drawing.Color.Transparent
		Me.LblMunicipio.ForeColor = System.Drawing.Color.DimGray
		Me.LblMunicipio.Name = "LblMunicipio"
		'
		'LblUF
		'
		resources.ApplyResources(Me.LblUF, "LblUF")
		Me.LblUF.BackColor = System.Drawing.Color.Transparent
		Me.LblUF.ForeColor = System.Drawing.Color.DimGray
		Me.LblUF.Name = "LblUF"
		'
		'LblPorte
		'
		resources.ApplyResources(Me.LblPorte, "LblPorte")
		Me.LblPorte.BackColor = System.Drawing.Color.Transparent
		Me.LblPorte.ForeColor = System.Drawing.Color.DimGray
		Me.LblPorte.Name = "LblPorte"
		'
		'LblLogradouro
		'
		resources.ApplyResources(Me.LblLogradouro, "LblLogradouro")
		Me.LblLogradouro.BackColor = System.Drawing.Color.Transparent
		Me.LblLogradouro.ForeColor = System.Drawing.Color.DimGray
		Me.LblLogradouro.Name = "LblLogradouro"
		'
		'LblBairro
		'
		resources.ApplyResources(Me.LblBairro, "LblBairro")
		Me.LblBairro.BackColor = System.Drawing.Color.Transparent
		Me.LblBairro.ForeColor = System.Drawing.Color.DimGray
		Me.LblBairro.Name = "LblBairro"
		'
		'LblAbertura
		'
		resources.ApplyResources(Me.LblAbertura, "LblAbertura")
		Me.LblAbertura.BackColor = System.Drawing.Color.Transparent
		Me.LblAbertura.ForeColor = System.Drawing.Color.DimGray
		Me.LblAbertura.Name = "LblAbertura"
		'
		'LblSituacao
		'
		resources.ApplyResources(Me.LblSituacao, "LblSituacao")
		Me.LblSituacao.BackColor = System.Drawing.Color.Transparent
		Me.LblSituacao.ForeColor = System.Drawing.Color.DimGray
		Me.LblSituacao.Name = "LblSituacao"
		'
		'LblEmail
		'
		resources.ApplyResources(Me.LblEmail, "LblEmail")
		Me.LblEmail.BackColor = System.Drawing.Color.Transparent
		Me.LblEmail.ForeColor = System.Drawing.Color.DimGray
		Me.LblEmail.Name = "LblEmail"
		'
		'LblStatus
		'
		resources.ApplyResources(Me.LblStatus, "LblStatus")
		Me.LblStatus.BackColor = System.Drawing.Color.Transparent
		Me.LblStatus.ForeColor = System.Drawing.Color.DimGray
		Me.LblStatus.Name = "LblStatus"
		'
		'LblTelefone
		'
		resources.ApplyResources(Me.LblTelefone, "LblTelefone")
		Me.LblTelefone.BackColor = System.Drawing.Color.Transparent
		Me.LblTelefone.ForeColor = System.Drawing.Color.DimGray
		Me.LblTelefone.Name = "LblTelefone"
		'
		'LblNatureza_juridica
		'
		resources.ApplyResources(Me.LblNatureza_juridica, "LblNatureza_juridica")
		Me.LblNatureza_juridica.BackColor = System.Drawing.Color.Transparent
		Me.LblNatureza_juridica.ForeColor = System.Drawing.Color.DimGray
		Me.LblNatureza_juridica.Name = "LblNatureza_juridica"
		'
		'LblUltima_atualizacao
		'
		resources.ApplyResources(Me.LblUltima_atualizacao, "LblUltima_atualizacao")
		Me.LblUltima_atualizacao.BackColor = System.Drawing.Color.Transparent
		Me.LblUltima_atualizacao.ForeColor = System.Drawing.Color.DimGray
		Me.LblUltima_atualizacao.Name = "LblUltima_atualizacao"
		'
		'LblFantasia
		'
		resources.ApplyResources(Me.LblFantasia, "LblFantasia")
		Me.LblFantasia.BackColor = System.Drawing.Color.Transparent
		Me.LblFantasia.ForeColor = System.Drawing.Color.DimGray
		Me.LblFantasia.Name = "LblFantasia"
		'
		'LblCnpj
		'
		resources.ApplyResources(Me.LblCnpj, "LblCnpj")
		Me.LblCnpj.BackColor = System.Drawing.Color.Transparent
		Me.LblCnpj.ForeColor = System.Drawing.Color.DimGray
		Me.LblCnpj.Name = "LblCnpj"
		'
		'BTpesquisar
		'
		Me.BTpesquisar.Animated = True
		Me.BTpesquisar.CheckedState.Parent = Me.BTpesquisar
		Me.BTpesquisar.CustomImages.Parent = Me.BTpesquisar
		Me.BTpesquisar.FillColor = System.Drawing.Color.SkyBlue
		resources.ApplyResources(Me.BTpesquisar, "BTpesquisar")
		Me.BTpesquisar.ForeColor = System.Drawing.Color.White
		Me.BTpesquisar.HoverState.Parent = Me.BTpesquisar
		Me.BTpesquisar.Name = "BTpesquisar"
		Me.BTpesquisar.ShadowDecoration.Parent = Me.BTpesquisar
		Me.BTpesquisar.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase
		'
		'TXTResult
		'
		resources.ApplyResources(Me.TXTResult, "TXTResult")
		Me.TXTResult.BackColor = System.Drawing.Color.White
		Me.TXTResult.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.TXTResult.ForeColor = System.Drawing.Color.DimGray
		Me.TXTResult.Name = "TXTResult"
		'
		'TXTCNPJ
		'
		Me.TXTCNPJ.BorderThickness = 2
		Me.TXTCNPJ.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.TXTCNPJ.DefaultText = ""
		Me.TXTCNPJ.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
		Me.TXTCNPJ.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
		Me.TXTCNPJ.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.TXTCNPJ.DisabledState.Parent = Me.TXTCNPJ
		Me.TXTCNPJ.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.TXTCNPJ.FocusedState.BorderColor = System.Drawing.Color.Lime
		Me.TXTCNPJ.FocusedState.FillColor = System.Drawing.Color.SkyBlue
		Me.TXTCNPJ.FocusedState.ForeColor = System.Drawing.Color.DimGray
		Me.TXTCNPJ.FocusedState.Parent = Me.TXTCNPJ
		Me.TXTCNPJ.FocusedState.PlaceholderForeColor = System.Drawing.Color.DimGray
		Me.TXTCNPJ.ForeColor = System.Drawing.Color.DimGray
		Me.TXTCNPJ.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.TXTCNPJ.HoverState.Parent = Me.TXTCNPJ
		Me.TXTCNPJ.IconLeft = Global.Principal.My.Resources.Resources.bullet_go
		resources.ApplyResources(Me.TXTCNPJ, "TXTCNPJ")
		Me.TXTCNPJ.Name = "TXTCNPJ"
		Me.TXTCNPJ.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.TXTCNPJ.PlaceholderText = "DIGITE A CNPJ"
		Me.TXTCNPJ.SelectedText = ""
		Me.TXTCNPJ.ShadowDecoration.Parent = Me.TXTCNPJ
		Me.TXTCNPJ.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
		'
		'TabPageSaida
		'
		Me.TabPageSaida.BackColor = System.Drawing.Color.Azure
		Me.TabPageSaida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.TabPageSaida.Controls.Add(Me.LBLCODIGO)
		Me.TabPageSaida.Controls.Add(Me.Label13)
		Me.TabPageSaida.Controls.Add(Me.Label27)
		Me.TabPageSaida.Controls.Add(Me.Label26)
		Me.TabPageSaida.Controls.Add(Me.Label25)
		Me.TabPageSaida.Controls.Add(Me.BTPESARSAIDA)
		Me.TabPageSaida.Controls.Add(Me.Label6)
		Me.TabPageSaida.Controls.Add(Me.Label7)
		Me.TabPageSaida.Controls.Add(Me.Label8)
		Me.TabPageSaida.Controls.Add(Me.Label12)
		Me.TabPageSaida.Controls.Add(Me.Label9)
		Me.TabPageSaida.Controls.Add(Me.Label10)
		Me.TabPageSaida.Controls.Add(Me.Label11)
		Me.TabPageSaida.Controls.Add(Me.TXTSTATUS)
		Me.TabPageSaida.Controls.Add(Me.TXTPESOBRUTO_LEITURA)
		Me.TabPageSaida.Controls.Add(Me.TXTTRASNPORTADORSAIDA)
		Me.TabPageSaida.Controls.Add(Me.TXTCLIENTESAIDA)
		Me.TabPageSaida.Controls.Add(Me.TXTMOTORISTA_SAIDA)
		Me.TabPageSaida.Controls.Add(Me.TXTRESIDUO)
		Me.TabPageSaida.Controls.Add(Me.TXTPESO_TARA)
		Me.TabPageSaida.Controls.Add(Me.TXTPLACA_SAIDA)
		Me.TabPageSaida.Controls.Add(Me.TxtOpcaoEntrada_Saida)
		Me.TabPageSaida.Controls.Add(Me.TXTOPCAODESAIDA)
		resources.ApplyResources(Me.TabPageSaida, "TabPageSaida")
		Me.TabPageSaida.ForeColor = System.Drawing.Color.Silver
		Me.TabPageSaida.Name = "TabPageSaida"
		'
		'LBLCODIGO
		'
		Me.LBLCODIGO.BackColor = System.Drawing.SystemColors.ButtonFace
		Me.LBLCODIGO.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.LBLCODIGO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		resources.ApplyResources(Me.LBLCODIGO, "LBLCODIGO")
		Me.LBLCODIGO.ForeColor = System.Drawing.Color.DarkGray
		Me.LBLCODIGO.Name = "LBLCODIGO"
		'
		'Label13
		'
		resources.ApplyResources(Me.Label13, "Label13")
		Me.Label13.BackColor = System.Drawing.Color.Transparent
		Me.Label13.ForeColor = System.Drawing.Color.DarkGray
		Me.Label13.Name = "Label13"
		'
		'Label27
		'
		resources.ApplyResources(Me.Label27, "Label27")
		Me.Label27.BackColor = System.Drawing.Color.Transparent
		Me.Label27.ForeColor = System.Drawing.Color.DarkGray
		Me.Label27.Name = "Label27"
		'
		'Label26
		'
		resources.ApplyResources(Me.Label26, "Label26")
		Me.Label26.BackColor = System.Drawing.Color.Transparent
		Me.Label26.ForeColor = System.Drawing.Color.DarkGray
		Me.Label26.Name = "Label26"
		'
		'Label25
		'
		resources.ApplyResources(Me.Label25, "Label25")
		Me.Label25.BackColor = System.Drawing.Color.Transparent
		Me.Label25.ForeColor = System.Drawing.Color.DarkGray
		Me.Label25.Name = "Label25"
		'
		'BTPESARSAIDA
		'
		Me.BTPESARSAIDA.BorderThickness = 1
		Me.BTPESARSAIDA.CheckedState.Parent = Me.BTPESARSAIDA
		Me.BTPESARSAIDA.CustomImages.Parent = Me.BTPESARSAIDA
		Me.BTPESARSAIDA.FillColor = System.Drawing.Color.WhiteSmoke
		resources.ApplyResources(Me.BTPESARSAIDA, "BTPESARSAIDA")
		Me.BTPESARSAIDA.ForeColor = System.Drawing.Color.Gray
		Me.BTPESARSAIDA.HoverState.Parent = Me.BTPESARSAIDA
		Me.BTPESARSAIDA.IndicateFocus = True
		Me.BTPESARSAIDA.Name = "BTPESARSAIDA"
		Me.BTPESARSAIDA.PressedColor = System.Drawing.Color.Green
		Me.BTPESARSAIDA.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
		Me.BTPESARSAIDA.ShadowDecoration.Parent = Me.BTPESARSAIDA
		'
		'Label6
		'
		resources.ApplyResources(Me.Label6, "Label6")
		Me.Label6.BackColor = System.Drawing.Color.Transparent
		Me.Label6.ForeColor = System.Drawing.Color.DarkGray
		Me.Label6.Name = "Label6"
		'
		'Label7
		'
		resources.ApplyResources(Me.Label7, "Label7")
		Me.Label7.BackColor = System.Drawing.Color.Transparent
		Me.Label7.ForeColor = System.Drawing.Color.DarkGray
		Me.Label7.Name = "Label7"
		'
		'Label8
		'
		resources.ApplyResources(Me.Label8, "Label8")
		Me.Label8.BackColor = System.Drawing.Color.Transparent
		Me.Label8.ForeColor = System.Drawing.Color.DarkGray
		Me.Label8.Name = "Label8"
		'
		'Label12
		'
		resources.ApplyResources(Me.Label12, "Label12")
		Me.Label12.BackColor = System.Drawing.Color.Transparent
		Me.Label12.ForeColor = System.Drawing.Color.DarkGray
		Me.Label12.Name = "Label12"
		'
		'Label9
		'
		resources.ApplyResources(Me.Label9, "Label9")
		Me.Label9.BackColor = System.Drawing.Color.Transparent
		Me.Label9.ForeColor = System.Drawing.Color.DarkGray
		Me.Label9.Name = "Label9"
		'
		'Label10
		'
		resources.ApplyResources(Me.Label10, "Label10")
		Me.Label10.BackColor = System.Drawing.Color.Transparent
		Me.Label10.ForeColor = System.Drawing.Color.DarkGray
		Me.Label10.Name = "Label10"
		'
		'Label11
		'
		resources.ApplyResources(Me.Label11, "Label11")
		Me.Label11.BackColor = System.Drawing.Color.Transparent
		Me.Label11.ForeColor = System.Drawing.Color.DarkGray
		Me.Label11.Name = "Label11"
		'
		'TXTSTATUS
		'
		Me.TXTSTATUS.Ativar_CasasDecimais = False
		Me.TXTSTATUS.Ativar_so_Letras = False
		Me.TXTSTATUS.Ativar_so_Numeros = False
		Me.TXTSTATUS.AtivarSoNumeroSemFormatacao_ = False
		Me.TXTSTATUS.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
		Me.TXTSTATUS.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
		Me.TXTSTATUS.BackColor = System.Drawing.Color.WhiteSmoke
		Me.TXTSTATUS.BorderColor = System.Drawing.Color.Silver
		Me.TXTSTATUS.BorderRadius = 5
		Me.TXTSTATUS.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.TXTSTATUS.DefaultText = ""
		Me.TXTSTATUS.DisabledState.BorderColor = System.Drawing.Color.DimGray
		Me.TXTSTATUS.DisabledState.FillColor = System.Drawing.Color.White
		Me.TXTSTATUS.DisabledState.ForeColor = System.Drawing.Color.Gray
		Me.TXTSTATUS.DisabledState.Parent = Me.TXTSTATUS
		Me.TXTSTATUS.DisabledState.PlaceholderForeColor = System.Drawing.Color.Silver
		Me.TXTSTATUS.FocusedState.BorderColor = System.Drawing.Color.DimGray
		Me.TXTSTATUS.FocusedState.FillColor = System.Drawing.Color.WhiteSmoke
		Me.TXTSTATUS.FocusedState.ForeColor = System.Drawing.Color.Gray
		Me.TXTSTATUS.FocusedState.Parent = Me.TXTSTATUS
		Me.TXTSTATUS.FocusedState.PlaceholderForeColor = System.Drawing.Color.LightGray
		Me.TXTSTATUS.ForeColor = System.Drawing.Color.Gray
		Me.TXTSTATUS.HoverState.BorderColor = System.Drawing.Color.DimGray
		Me.TXTSTATUS.HoverState.FillColor = System.Drawing.Color.Ivory
		Me.TXTSTATUS.HoverState.ForeColor = System.Drawing.Color.Gray
		Me.TXTSTATUS.HoverState.Parent = Me.TXTSTATUS
		Me.TXTSTATUS.HoverState.PlaceholderForeColor = System.Drawing.Color.DimGray
		resources.ApplyResources(Me.TXTSTATUS, "TXTSTATUS")
		Me.TXTSTATUS.Name = "TXTSTATUS"
		Me.TXTSTATUS.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.TXTSTATUS.PlaceholderText = ""
		Me.TXTSTATUS.ReadOnly = True
		Me.TXTSTATUS.SelectedText = ""
		Me.TXTSTATUS.ShadowDecoration.Parent = Me.TXTSTATUS
		Me.TXTSTATUS.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
		'
		'TXTPESOBRUTO_LEITURA
		'
		Me.TXTPESOBRUTO_LEITURA.Animated = True
		Me.TXTPESOBRUTO_LEITURA.Ativar_CasasDecimais = True
		Me.TXTPESOBRUTO_LEITURA.Ativar_so_Letras = False
		Me.TXTPESOBRUTO_LEITURA.Ativar_so_Numeros = True
		Me.TXTPESOBRUTO_LEITURA.AtivarSoNumeroSemFormatacao_ = False
		Me.TXTPESOBRUTO_LEITURA.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
		Me.TXTPESOBRUTO_LEITURA.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
		Me.TXTPESOBRUTO_LEITURA.BackColor = System.Drawing.Color.WhiteSmoke
		Me.TXTPESOBRUTO_LEITURA.BorderColor = System.Drawing.Color.Silver
		Me.TXTPESOBRUTO_LEITURA.BorderRadius = 5
		Me.TXTPESOBRUTO_LEITURA.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.TXTPESOBRUTO_LEITURA.DefaultText = ""
		Me.TXTPESOBRUTO_LEITURA.DisabledState.BorderColor = System.Drawing.Color.DimGray
		Me.TXTPESOBRUTO_LEITURA.DisabledState.FillColor = System.Drawing.Color.White
		Me.TXTPESOBRUTO_LEITURA.DisabledState.ForeColor = System.Drawing.Color.Gray
		Me.TXTPESOBRUTO_LEITURA.DisabledState.Parent = Me.TXTPESOBRUTO_LEITURA
		Me.TXTPESOBRUTO_LEITURA.DisabledState.PlaceholderForeColor = System.Drawing.Color.Silver
		Me.TXTPESOBRUTO_LEITURA.FocusedState.BorderColor = System.Drawing.Color.DimGray
		Me.TXTPESOBRUTO_LEITURA.FocusedState.FillColor = System.Drawing.Color.WhiteSmoke
		Me.TXTPESOBRUTO_LEITURA.FocusedState.ForeColor = System.Drawing.Color.Gray
		Me.TXTPESOBRUTO_LEITURA.FocusedState.Parent = Me.TXTPESOBRUTO_LEITURA
		Me.TXTPESOBRUTO_LEITURA.FocusedState.PlaceholderForeColor = System.Drawing.Color.LightGray
		Me.TXTPESOBRUTO_LEITURA.ForeColor = System.Drawing.Color.Gray
		Me.TXTPESOBRUTO_LEITURA.HoverState.BorderColor = System.Drawing.Color.DimGray
		Me.TXTPESOBRUTO_LEITURA.HoverState.FillColor = System.Drawing.Color.Ivory
		Me.TXTPESOBRUTO_LEITURA.HoverState.ForeColor = System.Drawing.Color.Gray
		Me.TXTPESOBRUTO_LEITURA.HoverState.Parent = Me.TXTPESOBRUTO_LEITURA
		Me.TXTPESOBRUTO_LEITURA.HoverState.PlaceholderForeColor = System.Drawing.Color.DimGray
		resources.ApplyResources(Me.TXTPESOBRUTO_LEITURA, "TXTPESOBRUTO_LEITURA")
		Me.TXTPESOBRUTO_LEITURA.Name = "TXTPESOBRUTO_LEITURA"
		Me.TXTPESOBRUTO_LEITURA.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.TXTPESOBRUTO_LEITURA.PlaceholderText = ""
		Me.TXTPESOBRUTO_LEITURA.ReadOnly = True
		Me.TXTPESOBRUTO_LEITURA.SelectedText = ""
		Me.TXTPESOBRUTO_LEITURA.ShadowDecoration.Parent = Me.TXTPESOBRUTO_LEITURA
		Me.TXTPESOBRUTO_LEITURA.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
		'
		'TXTTRASNPORTADORSAIDA
		'
		Me.TXTTRASNPORTADORSAIDA.Animated = True
		Me.TXTTRASNPORTADORSAIDA.Ativar_CasasDecimais = False
		Me.TXTTRASNPORTADORSAIDA.Ativar_so_Letras = False
		Me.TXTTRASNPORTADORSAIDA.Ativar_so_Numeros = False
		Me.TXTTRASNPORTADORSAIDA.AtivarSoNumeroSemFormatacao_ = False
		Me.TXTTRASNPORTADORSAIDA.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
		Me.TXTTRASNPORTADORSAIDA.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
		Me.TXTTRASNPORTADORSAIDA.BackColor = System.Drawing.Color.WhiteSmoke
		Me.TXTTRASNPORTADORSAIDA.BorderColor = System.Drawing.Color.Silver
		Me.TXTTRASNPORTADORSAIDA.BorderRadius = 5
		Me.TXTTRASNPORTADORSAIDA.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.TXTTRASNPORTADORSAIDA.DefaultText = ""
		Me.TXTTRASNPORTADORSAIDA.DisabledState.BorderColor = System.Drawing.Color.DimGray
		Me.TXTTRASNPORTADORSAIDA.DisabledState.FillColor = System.Drawing.Color.White
		Me.TXTTRASNPORTADORSAIDA.DisabledState.ForeColor = System.Drawing.Color.Gray
		Me.TXTTRASNPORTADORSAIDA.DisabledState.Parent = Me.TXTTRASNPORTADORSAIDA
		Me.TXTTRASNPORTADORSAIDA.DisabledState.PlaceholderForeColor = System.Drawing.Color.Silver
		Me.TXTTRASNPORTADORSAIDA.FocusedState.BorderColor = System.Drawing.Color.DimGray
		Me.TXTTRASNPORTADORSAIDA.FocusedState.FillColor = System.Drawing.Color.WhiteSmoke
		Me.TXTTRASNPORTADORSAIDA.FocusedState.ForeColor = System.Drawing.Color.Gray
		Me.TXTTRASNPORTADORSAIDA.FocusedState.Parent = Me.TXTTRASNPORTADORSAIDA
		Me.TXTTRASNPORTADORSAIDA.FocusedState.PlaceholderForeColor = System.Drawing.Color.LightGray
		Me.TXTTRASNPORTADORSAIDA.ForeColor = System.Drawing.Color.Gray
		Me.TXTTRASNPORTADORSAIDA.HoverState.BorderColor = System.Drawing.Color.DimGray
		Me.TXTTRASNPORTADORSAIDA.HoverState.FillColor = System.Drawing.Color.Ivory
		Me.TXTTRASNPORTADORSAIDA.HoverState.ForeColor = System.Drawing.Color.Gray
		Me.TXTTRASNPORTADORSAIDA.HoverState.Parent = Me.TXTTRASNPORTADORSAIDA
		Me.TXTTRASNPORTADORSAIDA.HoverState.PlaceholderForeColor = System.Drawing.Color.DimGray
		resources.ApplyResources(Me.TXTTRASNPORTADORSAIDA, "TXTTRASNPORTADORSAIDA")
		Me.TXTTRASNPORTADORSAIDA.Name = "TXTTRASNPORTADORSAIDA"
		Me.TXTTRASNPORTADORSAIDA.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.TXTTRASNPORTADORSAIDA.PlaceholderText = ""
		Me.TXTTRASNPORTADORSAIDA.SelectedText = ""
		Me.TXTTRASNPORTADORSAIDA.ShadowDecoration.Parent = Me.TXTTRASNPORTADORSAIDA
		Me.TXTTRASNPORTADORSAIDA.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
		'
		'TXTCLIENTESAIDA
		'
		Me.TXTCLIENTESAIDA.Animated = True
		Me.TXTCLIENTESAIDA.Ativar_CasasDecimais = False
		Me.TXTCLIENTESAIDA.Ativar_so_Letras = False
		Me.TXTCLIENTESAIDA.Ativar_so_Numeros = False
		Me.TXTCLIENTESAIDA.AtivarSoNumeroSemFormatacao_ = False
		Me.TXTCLIENTESAIDA.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
		Me.TXTCLIENTESAIDA.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
		Me.TXTCLIENTESAIDA.BackColor = System.Drawing.Color.WhiteSmoke
		Me.TXTCLIENTESAIDA.BorderColor = System.Drawing.Color.Silver
		Me.TXTCLIENTESAIDA.BorderRadius = 5
		Me.TXTCLIENTESAIDA.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.TXTCLIENTESAIDA.DefaultText = ""
		Me.TXTCLIENTESAIDA.DisabledState.BorderColor = System.Drawing.Color.DimGray
		Me.TXTCLIENTESAIDA.DisabledState.FillColor = System.Drawing.Color.White
		Me.TXTCLIENTESAIDA.DisabledState.ForeColor = System.Drawing.Color.Gray
		Me.TXTCLIENTESAIDA.DisabledState.Parent = Me.TXTCLIENTESAIDA
		Me.TXTCLIENTESAIDA.DisabledState.PlaceholderForeColor = System.Drawing.Color.Silver
		Me.TXTCLIENTESAIDA.FocusedState.BorderColor = System.Drawing.Color.DimGray
		Me.TXTCLIENTESAIDA.FocusedState.FillColor = System.Drawing.Color.WhiteSmoke
		Me.TXTCLIENTESAIDA.FocusedState.ForeColor = System.Drawing.Color.Gray
		Me.TXTCLIENTESAIDA.FocusedState.Parent = Me.TXTCLIENTESAIDA
		Me.TXTCLIENTESAIDA.FocusedState.PlaceholderForeColor = System.Drawing.Color.LightGray
		Me.TXTCLIENTESAIDA.ForeColor = System.Drawing.Color.Gray
		Me.TXTCLIENTESAIDA.HoverState.BorderColor = System.Drawing.Color.DimGray
		Me.TXTCLIENTESAIDA.HoverState.FillColor = System.Drawing.Color.Ivory
		Me.TXTCLIENTESAIDA.HoverState.ForeColor = System.Drawing.Color.Gray
		Me.TXTCLIENTESAIDA.HoverState.Parent = Me.TXTCLIENTESAIDA
		Me.TXTCLIENTESAIDA.HoverState.PlaceholderForeColor = System.Drawing.Color.DimGray
		resources.ApplyResources(Me.TXTCLIENTESAIDA, "TXTCLIENTESAIDA")
		Me.TXTCLIENTESAIDA.Name = "TXTCLIENTESAIDA"
		Me.TXTCLIENTESAIDA.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.TXTCLIENTESAIDA.PlaceholderText = ""
		Me.TXTCLIENTESAIDA.SelectedText = ""
		Me.TXTCLIENTESAIDA.ShadowDecoration.Parent = Me.TXTCLIENTESAIDA
		Me.TXTCLIENTESAIDA.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
		'
		'TXTMOTORISTA_SAIDA
		'
		Me.TXTMOTORISTA_SAIDA.Animated = True
		Me.TXTMOTORISTA_SAIDA.Ativar_CasasDecimais = False
		Me.TXTMOTORISTA_SAIDA.Ativar_so_Letras = False
		Me.TXTMOTORISTA_SAIDA.Ativar_so_Numeros = False
		Me.TXTMOTORISTA_SAIDA.AtivarSoNumeroSemFormatacao_ = False
		Me.TXTMOTORISTA_SAIDA.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
		Me.TXTMOTORISTA_SAIDA.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
		Me.TXTMOTORISTA_SAIDA.BackColor = System.Drawing.Color.WhiteSmoke
		Me.TXTMOTORISTA_SAIDA.BorderColor = System.Drawing.Color.Silver
		Me.TXTMOTORISTA_SAIDA.BorderRadius = 5
		Me.TXTMOTORISTA_SAIDA.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.TXTMOTORISTA_SAIDA.DefaultText = ""
		Me.TXTMOTORISTA_SAIDA.DisabledState.BorderColor = System.Drawing.Color.DimGray
		Me.TXTMOTORISTA_SAIDA.DisabledState.FillColor = System.Drawing.Color.White
		Me.TXTMOTORISTA_SAIDA.DisabledState.ForeColor = System.Drawing.Color.Gray
		Me.TXTMOTORISTA_SAIDA.DisabledState.Parent = Me.TXTMOTORISTA_SAIDA
		Me.TXTMOTORISTA_SAIDA.DisabledState.PlaceholderForeColor = System.Drawing.Color.Silver
		Me.TXTMOTORISTA_SAIDA.FocusedState.BorderColor = System.Drawing.Color.DimGray
		Me.TXTMOTORISTA_SAIDA.FocusedState.FillColor = System.Drawing.Color.WhiteSmoke
		Me.TXTMOTORISTA_SAIDA.FocusedState.ForeColor = System.Drawing.Color.Gray
		Me.TXTMOTORISTA_SAIDA.FocusedState.Parent = Me.TXTMOTORISTA_SAIDA
		Me.TXTMOTORISTA_SAIDA.FocusedState.PlaceholderForeColor = System.Drawing.Color.LightGray
		Me.TXTMOTORISTA_SAIDA.ForeColor = System.Drawing.Color.Gray
		Me.TXTMOTORISTA_SAIDA.HoverState.BorderColor = System.Drawing.Color.DimGray
		Me.TXTMOTORISTA_SAIDA.HoverState.FillColor = System.Drawing.Color.Ivory
		Me.TXTMOTORISTA_SAIDA.HoverState.ForeColor = System.Drawing.Color.Gray
		Me.TXTMOTORISTA_SAIDA.HoverState.Parent = Me.TXTMOTORISTA_SAIDA
		Me.TXTMOTORISTA_SAIDA.HoverState.PlaceholderForeColor = System.Drawing.Color.DimGray
		resources.ApplyResources(Me.TXTMOTORISTA_SAIDA, "TXTMOTORISTA_SAIDA")
		Me.TXTMOTORISTA_SAIDA.Name = "TXTMOTORISTA_SAIDA"
		Me.TXTMOTORISTA_SAIDA.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.TXTMOTORISTA_SAIDA.PlaceholderText = ""
		Me.TXTMOTORISTA_SAIDA.SelectedText = ""
		Me.TXTMOTORISTA_SAIDA.ShadowDecoration.Parent = Me.TXTMOTORISTA_SAIDA
		Me.TXTMOTORISTA_SAIDA.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
		'
		'TXTRESIDUO
		'
		Me.TXTRESIDUO.Ativar_CasasDecimais = False
		Me.TXTRESIDUO.Ativar_so_Letras = False
		Me.TXTRESIDUO.Ativar_so_Numeros = False
		Me.TXTRESIDUO.AtivarSoNumeroSemFormatacao_ = False
		Me.TXTRESIDUO.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
		Me.TXTRESIDUO.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
		Me.TXTRESIDUO.BackColor = System.Drawing.Color.WhiteSmoke
		Me.TXTRESIDUO.BorderColor = System.Drawing.Color.Silver
		Me.TXTRESIDUO.BorderRadius = 5
		Me.TXTRESIDUO.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.TXTRESIDUO.DefaultText = ""
		Me.TXTRESIDUO.DisabledState.BorderColor = System.Drawing.Color.DimGray
		Me.TXTRESIDUO.DisabledState.FillColor = System.Drawing.Color.White
		Me.TXTRESIDUO.DisabledState.ForeColor = System.Drawing.Color.Gray
		Me.TXTRESIDUO.DisabledState.Parent = Me.TXTRESIDUO
		Me.TXTRESIDUO.DisabledState.PlaceholderForeColor = System.Drawing.Color.Silver
		Me.TXTRESIDUO.FocusedState.BorderColor = System.Drawing.Color.DimGray
		Me.TXTRESIDUO.FocusedState.FillColor = System.Drawing.Color.WhiteSmoke
		Me.TXTRESIDUO.FocusedState.ForeColor = System.Drawing.Color.Gray
		Me.TXTRESIDUO.FocusedState.Parent = Me.TXTRESIDUO
		Me.TXTRESIDUO.FocusedState.PlaceholderForeColor = System.Drawing.Color.LightGray
		Me.TXTRESIDUO.ForeColor = System.Drawing.Color.Gray
		Me.TXTRESIDUO.HoverState.BorderColor = System.Drawing.Color.DimGray
		Me.TXTRESIDUO.HoverState.FillColor = System.Drawing.Color.Ivory
		Me.TXTRESIDUO.HoverState.ForeColor = System.Drawing.Color.Gray
		Me.TXTRESIDUO.HoverState.Parent = Me.TXTRESIDUO
		Me.TXTRESIDUO.HoverState.PlaceholderForeColor = System.Drawing.Color.DimGray
		resources.ApplyResources(Me.TXTRESIDUO, "TXTRESIDUO")
		Me.TXTRESIDUO.Name = "TXTRESIDUO"
		Me.TXTRESIDUO.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.TXTRESIDUO.PlaceholderText = ""
		Me.TXTRESIDUO.SelectedText = ""
		Me.TXTRESIDUO.ShadowDecoration.Parent = Me.TXTRESIDUO
		Me.TXTRESIDUO.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
		'
		'TXTPESO_TARA
		'
		Me.TXTPESO_TARA.Animated = True
		Me.TXTPESO_TARA.Ativar_CasasDecimais = True
		Me.TXTPESO_TARA.Ativar_so_Letras = False
		Me.TXTPESO_TARA.Ativar_so_Numeros = True
		Me.TXTPESO_TARA.AtivarSoNumeroSemFormatacao_ = False
		Me.TXTPESO_TARA.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
		Me.TXTPESO_TARA.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
		Me.TXTPESO_TARA.BackColor = System.Drawing.Color.WhiteSmoke
		Me.TXTPESO_TARA.BorderColor = System.Drawing.Color.Silver
		Me.TXTPESO_TARA.BorderRadius = 5
		Me.TXTPESO_TARA.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.TXTPESO_TARA.DefaultText = ""
		Me.TXTPESO_TARA.DisabledState.BorderColor = System.Drawing.Color.DimGray
		Me.TXTPESO_TARA.DisabledState.FillColor = System.Drawing.Color.White
		Me.TXTPESO_TARA.DisabledState.ForeColor = System.Drawing.Color.Gray
		Me.TXTPESO_TARA.DisabledState.Parent = Me.TXTPESO_TARA
		Me.TXTPESO_TARA.DisabledState.PlaceholderForeColor = System.Drawing.Color.Silver
		Me.TXTPESO_TARA.FocusedState.BorderColor = System.Drawing.Color.DimGray
		Me.TXTPESO_TARA.FocusedState.FillColor = System.Drawing.Color.WhiteSmoke
		Me.TXTPESO_TARA.FocusedState.ForeColor = System.Drawing.Color.Gray
		Me.TXTPESO_TARA.FocusedState.Parent = Me.TXTPESO_TARA
		Me.TXTPESO_TARA.FocusedState.PlaceholderForeColor = System.Drawing.Color.LightGray
		Me.TXTPESO_TARA.ForeColor = System.Drawing.Color.Gray
		Me.TXTPESO_TARA.HoverState.BorderColor = System.Drawing.Color.DimGray
		Me.TXTPESO_TARA.HoverState.FillColor = System.Drawing.Color.Ivory
		Me.TXTPESO_TARA.HoverState.ForeColor = System.Drawing.Color.Gray
		Me.TXTPESO_TARA.HoverState.Parent = Me.TXTPESO_TARA
		Me.TXTPESO_TARA.HoverState.PlaceholderForeColor = System.Drawing.Color.DimGray
		resources.ApplyResources(Me.TXTPESO_TARA, "TXTPESO_TARA")
		Me.TXTPESO_TARA.Name = "TXTPESO_TARA"
		Me.TXTPESO_TARA.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.TXTPESO_TARA.PlaceholderText = ""
		Me.TXTPESO_TARA.SelectedText = ""
		Me.TXTPESO_TARA.ShadowDecoration.Parent = Me.TXTPESO_TARA
		Me.TXTPESO_TARA.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
		'
		'TXTPLACA_SAIDA
		'
		Me.TXTPLACA_SAIDA.Animated = True
		Me.TXTPLACA_SAIDA.Ativar_CasasDecimais = False
		Me.TXTPLACA_SAIDA.Ativar_so_Letras = False
		Me.TXTPLACA_SAIDA.Ativar_so_Numeros = False
		Me.TXTPLACA_SAIDA.AtivarSoNumeroSemFormatacao_ = False
		Me.TXTPLACA_SAIDA.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
		Me.TXTPLACA_SAIDA.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
		Me.TXTPLACA_SAIDA.AutoRoundedCorners = True
		Me.TXTPLACA_SAIDA.BackColor = System.Drawing.Color.White
		Me.TXTPLACA_SAIDA.BorderColor = System.Drawing.Color.Silver
		Me.TXTPLACA_SAIDA.BorderRadius = 12
		Me.TXTPLACA_SAIDA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
		Me.TXTPLACA_SAIDA.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.TXTPLACA_SAIDA.DefaultText = ""
		Me.TXTPLACA_SAIDA.DisabledState.BorderColor = System.Drawing.Color.DimGray
		Me.TXTPLACA_SAIDA.DisabledState.FillColor = System.Drawing.Color.White
		Me.TXTPLACA_SAIDA.DisabledState.ForeColor = System.Drawing.Color.Gray
		Me.TXTPLACA_SAIDA.DisabledState.Parent = Me.TXTPLACA_SAIDA
		Me.TXTPLACA_SAIDA.DisabledState.PlaceholderForeColor = System.Drawing.Color.Silver
		Me.TXTPLACA_SAIDA.FillColor = System.Drawing.Color.WhiteSmoke
		Me.TXTPLACA_SAIDA.FocusedState.BorderColor = System.Drawing.Color.White
		Me.TXTPLACA_SAIDA.FocusedState.FillColor = System.Drawing.Color.WhiteSmoke
		Me.TXTPLACA_SAIDA.FocusedState.ForeColor = System.Drawing.Color.Gray
		Me.TXTPLACA_SAIDA.FocusedState.Parent = Me.TXTPLACA_SAIDA
		Me.TXTPLACA_SAIDA.FocusedState.PlaceholderForeColor = System.Drawing.Color.LightGray
		Me.TXTPLACA_SAIDA.ForeColor = System.Drawing.Color.Gray
		Me.TXTPLACA_SAIDA.HoverState.BorderColor = System.Drawing.Color.DimGray
		Me.TXTPLACA_SAIDA.HoverState.FillColor = System.Drawing.Color.Ivory
		Me.TXTPLACA_SAIDA.HoverState.ForeColor = System.Drawing.Color.Gray
		Me.TXTPLACA_SAIDA.HoverState.Parent = Me.TXTPLACA_SAIDA
		Me.TXTPLACA_SAIDA.HoverState.PlaceholderForeColor = System.Drawing.Color.DimGray
		resources.ApplyResources(Me.TXTPLACA_SAIDA, "TXTPLACA_SAIDA")
		Me.TXTPLACA_SAIDA.Name = "TXTPLACA_SAIDA"
		Me.TXTPLACA_SAIDA.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.TXTPLACA_SAIDA.PlaceholderText = ""
		Me.TXTPLACA_SAIDA.SelectedText = ""
		Me.TXTPLACA_SAIDA.ShadowDecoration.Parent = Me.TXTPLACA_SAIDA
		Me.TXTPLACA_SAIDA.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
		'
		'TxtOpcaoEntrada_Saida
		'
		Me.TxtOpcaoEntrada_Saida.Animated = True
		Me.TxtOpcaoEntrada_Saida.Ativar_CasasDecimais = False
		Me.TxtOpcaoEntrada_Saida.Ativar_so_Letras = False
		Me.TxtOpcaoEntrada_Saida.Ativar_so_Numeros = False
		Me.TxtOpcaoEntrada_Saida.AtivarSoNumeroSemFormatacao_ = False
		Me.TxtOpcaoEntrada_Saida.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
		Me.TxtOpcaoEntrada_Saida.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
		Me.TxtOpcaoEntrada_Saida.BackColor = System.Drawing.Color.WhiteSmoke
		Me.TxtOpcaoEntrada_Saida.BorderColor = System.Drawing.Color.Silver
		Me.TxtOpcaoEntrada_Saida.BorderRadius = 5
		Me.TxtOpcaoEntrada_Saida.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
		Me.TxtOpcaoEntrada_Saida.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.TxtOpcaoEntrada_Saida.DefaultText = ""
		Me.TxtOpcaoEntrada_Saida.DisabledState.BorderColor = System.Drawing.Color.DimGray
		Me.TxtOpcaoEntrada_Saida.DisabledState.FillColor = System.Drawing.Color.White
		Me.TxtOpcaoEntrada_Saida.DisabledState.ForeColor = System.Drawing.Color.Gray
		Me.TxtOpcaoEntrada_Saida.DisabledState.Parent = Me.TxtOpcaoEntrada_Saida
		Me.TxtOpcaoEntrada_Saida.DisabledState.PlaceholderForeColor = System.Drawing.Color.Silver
		Me.TxtOpcaoEntrada_Saida.FocusedState.BorderColor = System.Drawing.Color.DimGray
		Me.TxtOpcaoEntrada_Saida.FocusedState.FillColor = System.Drawing.Color.WhiteSmoke
		Me.TxtOpcaoEntrada_Saida.FocusedState.ForeColor = System.Drawing.Color.Gray
		Me.TxtOpcaoEntrada_Saida.FocusedState.Parent = Me.TxtOpcaoEntrada_Saida
		Me.TxtOpcaoEntrada_Saida.FocusedState.PlaceholderForeColor = System.Drawing.Color.LightGray
		Me.TxtOpcaoEntrada_Saida.ForeColor = System.Drawing.Color.Gray
		Me.TxtOpcaoEntrada_Saida.HoverState.BorderColor = System.Drawing.Color.DimGray
		Me.TxtOpcaoEntrada_Saida.HoverState.FillColor = System.Drawing.Color.Ivory
		Me.TxtOpcaoEntrada_Saida.HoverState.ForeColor = System.Drawing.Color.Gray
		Me.TxtOpcaoEntrada_Saida.HoverState.Parent = Me.TxtOpcaoEntrada_Saida
		Me.TxtOpcaoEntrada_Saida.HoverState.PlaceholderForeColor = System.Drawing.Color.DimGray
		Me.TxtOpcaoEntrada_Saida.IconLeft = Global.Principal.My.Resources.Resources.bullet_key
		resources.ApplyResources(Me.TxtOpcaoEntrada_Saida, "TxtOpcaoEntrada_Saida")
		Me.TxtOpcaoEntrada_Saida.Name = "TxtOpcaoEntrada_Saida"
		Me.TxtOpcaoEntrada_Saida.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.TxtOpcaoEntrada_Saida.PlaceholderText = ""
		Me.TxtOpcaoEntrada_Saida.ReadOnly = True
		Me.TxtOpcaoEntrada_Saida.SelectedText = ""
		Me.TxtOpcaoEntrada_Saida.ShadowDecoration.Parent = Me.TxtOpcaoEntrada_Saida
		Me.TxtOpcaoEntrada_Saida.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
		'
		'TXTOPCAODESAIDA
		'
		Me.TXTOPCAODESAIDA.Animated = True
		Me.TXTOPCAODESAIDA.Ativar_CasasDecimais = False
		Me.TXTOPCAODESAIDA.Ativar_so_Letras = False
		Me.TXTOPCAODESAIDA.Ativar_so_Numeros = False
		Me.TXTOPCAODESAIDA.AtivarSoNumeroSemFormatacao_ = False
		Me.TXTOPCAODESAIDA.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
		Me.TXTOPCAODESAIDA.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
		Me.TXTOPCAODESAIDA.BackColor = System.Drawing.Color.WhiteSmoke
		Me.TXTOPCAODESAIDA.BorderColor = System.Drawing.Color.Silver
		Me.TXTOPCAODESAIDA.BorderRadius = 5
		Me.TXTOPCAODESAIDA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
		Me.TXTOPCAODESAIDA.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.TXTOPCAODESAIDA.DefaultText = ""
		Me.TXTOPCAODESAIDA.DisabledState.BorderColor = System.Drawing.Color.DimGray
		Me.TXTOPCAODESAIDA.DisabledState.FillColor = System.Drawing.Color.White
		Me.TXTOPCAODESAIDA.DisabledState.ForeColor = System.Drawing.Color.Gray
		Me.TXTOPCAODESAIDA.DisabledState.Parent = Me.TXTOPCAODESAIDA
		Me.TXTOPCAODESAIDA.DisabledState.PlaceholderForeColor = System.Drawing.Color.Silver
		Me.TXTOPCAODESAIDA.FocusedState.BorderColor = System.Drawing.Color.DimGray
		Me.TXTOPCAODESAIDA.FocusedState.FillColor = System.Drawing.Color.WhiteSmoke
		Me.TXTOPCAODESAIDA.FocusedState.ForeColor = System.Drawing.Color.Gray
		Me.TXTOPCAODESAIDA.FocusedState.Parent = Me.TXTOPCAODESAIDA
		Me.TXTOPCAODESAIDA.FocusedState.PlaceholderForeColor = System.Drawing.Color.LightGray
		Me.TXTOPCAODESAIDA.ForeColor = System.Drawing.Color.Gray
		Me.TXTOPCAODESAIDA.HoverState.BorderColor = System.Drawing.Color.DimGray
		Me.TXTOPCAODESAIDA.HoverState.FillColor = System.Drawing.Color.Ivory
		Me.TXTOPCAODESAIDA.HoverState.ForeColor = System.Drawing.Color.Gray
		Me.TXTOPCAODESAIDA.HoverState.Parent = Me.TXTOPCAODESAIDA
		Me.TXTOPCAODESAIDA.HoverState.PlaceholderForeColor = System.Drawing.Color.DimGray
		Me.TXTOPCAODESAIDA.IconLeft = Global.Principal.My.Resources.Resources.bullet_key
		resources.ApplyResources(Me.TXTOPCAODESAIDA, "TXTOPCAODESAIDA")
		Me.TXTOPCAODESAIDA.Name = "TXTOPCAODESAIDA"
		Me.TXTOPCAODESAIDA.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.TXTOPCAODESAIDA.PlaceholderText = ""
		Me.TXTOPCAODESAIDA.ReadOnly = True
		Me.TXTOPCAODESAIDA.SelectedText = ""
		Me.TXTOPCAODESAIDA.ShadowDecoration.Parent = Me.TXTOPCAODESAIDA
		Me.TXTOPCAODESAIDA.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
		'
		'TabPageEntrada
		'
		Me.TabPageEntrada.AllowDrop = True
		resources.ApplyResources(Me.TabPageEntrada, "TabPageEntrada")
		Me.TabPageEntrada.BackColor = System.Drawing.Color.Azure
		Me.TabPageEntrada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.TabPageEntrada.CausesValidation = False
		Me.TabPageEntrada.Controls.Add(Me.IPsMaquina)
		Me.TabPageEntrada.Controls.Add(Me.BTcadastrarTransportadora)
		Me.TabPageEntrada.Controls.Add(Me.BTcadastrarCliente)
		Me.TabPageEntrada.Controls.Add(Me.BTcadastrarResiduo)
		Me.TabPageEntrada.Controls.Add(Me.BTPESARENTRADA)
		Me.TabPageEntrada.Controls.Add(Me.CBOTRANSPORTADORENTRADA)
		Me.TabPageEntrada.Controls.Add(Me.CBOCLIENTEENTRADA)
		Me.TabPageEntrada.Controls.Add(Me.CBOCADASTRARRESIDUOS)
		Me.TabPageEntrada.Controls.Add(Me.TXTOPCAODEENTRADA)
		Me.TabPageEntrada.Controls.Add(Me.TXTMOTORISTA_ENTRADA)
		Me.TabPageEntrada.Controls.Add(Me.TXTPESO_BRUTO)
		Me.TabPageEntrada.Controls.Add(Me.TXTPLACA_ENTRADA)
		Me.TabPageEntrada.Controls.Add(Me.Label4)
		Me.TabPageEntrada.Controls.Add(Me.Label3)
		Me.TabPageEntrada.Controls.Add(Me.Label24)
		Me.TabPageEntrada.Controls.Add(Me.Label2)
		Me.TabPageEntrada.Controls.Add(Me.Label1)
		Me.TabPageEntrada.Controls.Add(Me.Label5)
		Me.TabPageEntrada.Controls.Add(Me.LBLPLACA)
		Me.TabPageEntrada.ForeColor = System.Drawing.Color.Silver
		Me.TabPageEntrada.Name = "TabPageEntrada"
		'
		'IPsMaquina
		'
		resources.ApplyResources(Me.IPsMaquina, "IPsMaquina")
		Me.IPsMaquina.BackColor = System.Drawing.Color.Transparent
		Me.IPsMaquina.ForeColor = System.Drawing.Color.DimGray
		Me.IPsMaquina.Name = "IPsMaquina"
		'
		'BTcadastrarTransportadora
		'
		Me.BTcadastrarTransportadora.BorderThickness = 1
		Me.BTcadastrarTransportadora.CheckedState.Parent = Me.BTcadastrarTransportadora
		Me.BTcadastrarTransportadora.CustomImages.Parent = Me.BTcadastrarTransportadora
		Me.BTcadastrarTransportadora.FillColor = System.Drawing.Color.WhiteSmoke
		resources.ApplyResources(Me.BTcadastrarTransportadora, "BTcadastrarTransportadora")
		Me.BTcadastrarTransportadora.ForeColor = System.Drawing.Color.Gray
		Me.BTcadastrarTransportadora.HoverState.Parent = Me.BTcadastrarTransportadora
		Me.BTcadastrarTransportadora.IndicateFocus = True
		Me.BTcadastrarTransportadora.Name = "BTcadastrarTransportadora"
		Me.BTcadastrarTransportadora.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
		Me.BTcadastrarTransportadora.ShadowDecoration.Parent = Me.BTcadastrarTransportadora
		'
		'BTcadastrarCliente
		'
		Me.BTcadastrarCliente.BorderThickness = 1
		Me.BTcadastrarCliente.CheckedState.Parent = Me.BTcadastrarCliente
		Me.BTcadastrarCliente.CustomImages.Parent = Me.BTcadastrarCliente
		Me.BTcadastrarCliente.FillColor = System.Drawing.Color.WhiteSmoke
		resources.ApplyResources(Me.BTcadastrarCliente, "BTcadastrarCliente")
		Me.BTcadastrarCliente.ForeColor = System.Drawing.Color.Gray
		Me.BTcadastrarCliente.HoverState.Parent = Me.BTcadastrarCliente
		Me.BTcadastrarCliente.IndicateFocus = True
		Me.BTcadastrarCliente.Name = "BTcadastrarCliente"
		Me.BTcadastrarCliente.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
		Me.BTcadastrarCliente.ShadowDecoration.Parent = Me.BTcadastrarCliente
		'
		'BTcadastrarResiduo
		'
		Me.BTcadastrarResiduo.BorderThickness = 1
		Me.BTcadastrarResiduo.CheckedState.Parent = Me.BTcadastrarResiduo
		Me.BTcadastrarResiduo.CustomImages.Parent = Me.BTcadastrarResiduo
		Me.BTcadastrarResiduo.FillColor = System.Drawing.Color.WhiteSmoke
		resources.ApplyResources(Me.BTcadastrarResiduo, "BTcadastrarResiduo")
		Me.BTcadastrarResiduo.ForeColor = System.Drawing.Color.Gray
		Me.BTcadastrarResiduo.HoverState.Parent = Me.BTcadastrarResiduo
		Me.BTcadastrarResiduo.IndicateFocus = True
		Me.BTcadastrarResiduo.Name = "BTcadastrarResiduo"
		Me.BTcadastrarResiduo.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
		Me.BTcadastrarResiduo.ShadowDecoration.Parent = Me.BTcadastrarResiduo
		'
		'BTPESARENTRADA
		'
		Me.BTPESARENTRADA.BorderThickness = 1
		Me.BTPESARENTRADA.CheckedState.Parent = Me.BTPESARENTRADA
		Me.BTPESARENTRADA.CustomImages.Parent = Me.BTPESARENTRADA
		Me.BTPESARENTRADA.FillColor = System.Drawing.Color.WhiteSmoke
		resources.ApplyResources(Me.BTPESARENTRADA, "BTPESARENTRADA")
		Me.BTPESARENTRADA.ForeColor = System.Drawing.Color.Gray
		Me.BTPESARENTRADA.HoverState.Parent = Me.BTPESARENTRADA
		Me.BTPESARENTRADA.IndicateFocus = True
		Me.BTPESARENTRADA.Name = "BTPESARENTRADA"
		Me.BTPESARENTRADA.PressedColor = System.Drawing.Color.Green
		Me.BTPESARENTRADA.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
		Me.BTPESARENTRADA.ShadowDecoration.Parent = Me.BTPESARENTRADA
		'
		'CBOTRANSPORTADORENTRADA
		'
		Me.CBOTRANSPORTADORENTRADA.AutoCompleteCustomSource.AddRange(New String() {resources.GetString("CBOTRANSPORTADORENTRADA.AutoCompleteCustomSource"), resources.GetString("CBOTRANSPORTADORENTRADA.AutoCompleteCustomSource1"), resources.GetString("CBOTRANSPORTADORENTRADA.AutoCompleteCustomSource2"), resources.GetString("CBOTRANSPORTADORENTRADA.AutoCompleteCustomSource3"), resources.GetString("CBOTRANSPORTADORENTRADA.AutoCompleteCustomSource4"), resources.GetString("CBOTRANSPORTADORENTRADA.AutoCompleteCustomSource5"), resources.GetString("CBOTRANSPORTADORENTRADA.AutoCompleteCustomSource6"), resources.GetString("CBOTRANSPORTADORENTRADA.AutoCompleteCustomSource7"), resources.GetString("CBOTRANSPORTADORENTRADA.AutoCompleteCustomSource8"), resources.GetString("CBOTRANSPORTADORENTRADA.AutoCompleteCustomSource9"), resources.GetString("CBOTRANSPORTADORENTRADA.AutoCompleteCustomSource10"), resources.GetString("CBOTRANSPORTADORENTRADA.AutoCompleteCustomSource11"), resources.GetString("CBOTRANSPORTADORENTRADA.AutoCompleteCustomSource12"), resources.GetString("CBOTRANSPORTADORENTRADA.AutoCompleteCustomSource13"), resources.GetString("CBOTRANSPORTADORENTRADA.AutoCompleteCustomSource14")})
		Me.CBOTRANSPORTADORENTRADA.BackColor = System.Drawing.Color.White
		Me.CBOTRANSPORTADORENTRADA.BorderColor = System.Drawing.Color.DimGray
		Me.CBOTRANSPORTADORENTRADA.BorderRadius = 5
		Me.CBOTRANSPORTADORENTRADA.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
		Me.CBOTRANSPORTADORENTRADA.DropDownHeight = 500
		Me.CBOTRANSPORTADORENTRADA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.CBOTRANSPORTADORENTRADA.DropDownWidth = 460
		Me.CBOTRANSPORTADORENTRADA.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
		Me.CBOTRANSPORTADORENTRADA.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
		Me.CBOTRANSPORTADORENTRADA.FocusedState.FillColor = System.Drawing.Color.White
		Me.CBOTRANSPORTADORENTRADA.FocusedState.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.CBOTRANSPORTADORENTRADA.FocusedState.ForeColor = System.Drawing.Color.Gray
		Me.CBOTRANSPORTADORENTRADA.FocusedState.Parent = Me.CBOTRANSPORTADORENTRADA
		resources.ApplyResources(Me.CBOTRANSPORTADORENTRADA, "CBOTRANSPORTADORENTRADA")
		Me.CBOTRANSPORTADORENTRADA.ForeColor = System.Drawing.Color.Silver
		Me.CBOTRANSPORTADORENTRADA.HoverState.BorderColor = System.Drawing.Color.White
		Me.CBOTRANSPORTADORENTRADA.HoverState.FillColor = System.Drawing.Color.White
		Me.CBOTRANSPORTADORENTRADA.HoverState.Parent = Me.CBOTRANSPORTADORENTRADA
		Me.CBOTRANSPORTADORENTRADA.ItemsAppearance.BackColor = System.Drawing.Color.White
		Me.CBOTRANSPORTADORENTRADA.ItemsAppearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.CBOTRANSPORTADORENTRADA.ItemsAppearance.Parent = Me.CBOTRANSPORTADORENTRADA
		Me.CBOTRANSPORTADORENTRADA.ItemsAppearance.SelectedBackColor = System.Drawing.Color.SkyBlue
		Me.CBOTRANSPORTADORENTRADA.ItemsAppearance.SelectedForeColor = System.Drawing.Color.Maroon
		Me.CBOTRANSPORTADORENTRADA.Name = "CBOTRANSPORTADORENTRADA"
		Me.CBOTRANSPORTADORENTRADA.ShadowDecoration.Color = System.Drawing.Color.Brown
		Me.CBOTRANSPORTADORENTRADA.ShadowDecoration.Parent = Me.CBOTRANSPORTADORENTRADA
		Me.CBOTRANSPORTADORENTRADA.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(2)
		Me.CBOTRANSPORTADORENTRADA.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
		Me.CBOTRANSPORTADORENTRADA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.CBOTRANSPORTADORENTRADA.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
		'
		'CBOCLIENTEENTRADA
		'
		Me.CBOCLIENTEENTRADA.AutoCompleteCustomSource.AddRange(New String() {resources.GetString("CBOCLIENTEENTRADA.AutoCompleteCustomSource"), resources.GetString("CBOCLIENTEENTRADA.AutoCompleteCustomSource1"), resources.GetString("CBOCLIENTEENTRADA.AutoCompleteCustomSource2"), resources.GetString("CBOCLIENTEENTRADA.AutoCompleteCustomSource3"), resources.GetString("CBOCLIENTEENTRADA.AutoCompleteCustomSource4"), resources.GetString("CBOCLIENTEENTRADA.AutoCompleteCustomSource5"), resources.GetString("CBOCLIENTEENTRADA.AutoCompleteCustomSource6"), resources.GetString("CBOCLIENTEENTRADA.AutoCompleteCustomSource7"), resources.GetString("CBOCLIENTEENTRADA.AutoCompleteCustomSource8"), resources.GetString("CBOCLIENTEENTRADA.AutoCompleteCustomSource9"), resources.GetString("CBOCLIENTEENTRADA.AutoCompleteCustomSource10"), resources.GetString("CBOCLIENTEENTRADA.AutoCompleteCustomSource11"), resources.GetString("CBOCLIENTEENTRADA.AutoCompleteCustomSource12"), resources.GetString("CBOCLIENTEENTRADA.AutoCompleteCustomSource13"), resources.GetString("CBOCLIENTEENTRADA.AutoCompleteCustomSource14")})
		Me.CBOCLIENTEENTRADA.BackColor = System.Drawing.Color.White
		Me.CBOCLIENTEENTRADA.BorderColor = System.Drawing.Color.DimGray
		Me.CBOCLIENTEENTRADA.BorderRadius = 5
		Me.CBOCLIENTEENTRADA.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
		Me.CBOCLIENTEENTRADA.DropDownHeight = 500
		Me.CBOCLIENTEENTRADA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.CBOCLIENTEENTRADA.DropDownWidth = 460
		Me.CBOCLIENTEENTRADA.FocusedColor = System.Drawing.SystemColors.ButtonShadow
		Me.CBOCLIENTEENTRADA.FocusedState.BorderColor = System.Drawing.SystemColors.ButtonShadow
		Me.CBOCLIENTEENTRADA.FocusedState.FillColor = System.Drawing.Color.White
		Me.CBOCLIENTEENTRADA.FocusedState.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.CBOCLIENTEENTRADA.FocusedState.ForeColor = System.Drawing.Color.DimGray
		Me.CBOCLIENTEENTRADA.FocusedState.Parent = Me.CBOCLIENTEENTRADA
		resources.ApplyResources(Me.CBOCLIENTEENTRADA, "CBOCLIENTEENTRADA")
		Me.CBOCLIENTEENTRADA.ForeColor = System.Drawing.Color.Silver
		Me.CBOCLIENTEENTRADA.HoverState.BorderColor = System.Drawing.Color.White
		Me.CBOCLIENTEENTRADA.HoverState.FillColor = System.Drawing.Color.White
		Me.CBOCLIENTEENTRADA.HoverState.Parent = Me.CBOCLIENTEENTRADA
		Me.CBOCLIENTEENTRADA.ItemsAppearance.BackColor = System.Drawing.Color.White
		Me.CBOCLIENTEENTRADA.ItemsAppearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.CBOCLIENTEENTRADA.ItemsAppearance.Parent = Me.CBOCLIENTEENTRADA
		Me.CBOCLIENTEENTRADA.ItemsAppearance.SelectedBackColor = System.Drawing.Color.SkyBlue
		Me.CBOCLIENTEENTRADA.ItemsAppearance.SelectedForeColor = System.Drawing.Color.Maroon
		Me.CBOCLIENTEENTRADA.Name = "CBOCLIENTEENTRADA"
		Me.CBOCLIENTEENTRADA.ShadowDecoration.Color = System.Drawing.Color.Brown
		Me.CBOCLIENTEENTRADA.ShadowDecoration.Parent = Me.CBOCLIENTEENTRADA
		Me.CBOCLIENTEENTRADA.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(2)
		Me.CBOCLIENTEENTRADA.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
		Me.CBOCLIENTEENTRADA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.CBOCLIENTEENTRADA.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
		'
		'CBOCADASTRARRESIDUOS
		'
		Me.CBOCADASTRARRESIDUOS.AutoCompleteCustomSource.AddRange(New String() {resources.GetString("CBOCADASTRARRESIDUOS.AutoCompleteCustomSource"), resources.GetString("CBOCADASTRARRESIDUOS.AutoCompleteCustomSource1"), resources.GetString("CBOCADASTRARRESIDUOS.AutoCompleteCustomSource2"), resources.GetString("CBOCADASTRARRESIDUOS.AutoCompleteCustomSource3"), resources.GetString("CBOCADASTRARRESIDUOS.AutoCompleteCustomSource4"), resources.GetString("CBOCADASTRARRESIDUOS.AutoCompleteCustomSource5"), resources.GetString("CBOCADASTRARRESIDUOS.AutoCompleteCustomSource6"), resources.GetString("CBOCADASTRARRESIDUOS.AutoCompleteCustomSource7"), resources.GetString("CBOCADASTRARRESIDUOS.AutoCompleteCustomSource8"), resources.GetString("CBOCADASTRARRESIDUOS.AutoCompleteCustomSource9"), resources.GetString("CBOCADASTRARRESIDUOS.AutoCompleteCustomSource10"), resources.GetString("CBOCADASTRARRESIDUOS.AutoCompleteCustomSource11"), resources.GetString("CBOCADASTRARRESIDUOS.AutoCompleteCustomSource12"), resources.GetString("CBOCADASTRARRESIDUOS.AutoCompleteCustomSource13"), resources.GetString("CBOCADASTRARRESIDUOS.AutoCompleteCustomSource14")})
		Me.CBOCADASTRARRESIDUOS.BackColor = System.Drawing.Color.White
		Me.CBOCADASTRARRESIDUOS.BorderColor = System.Drawing.Color.DimGray
		Me.CBOCADASTRARRESIDUOS.BorderRadius = 5
		Me.CBOCADASTRARRESIDUOS.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
		Me.CBOCADASTRARRESIDUOS.DropDownHeight = 500
		Me.CBOCADASTRARRESIDUOS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.CBOCADASTRARRESIDUOS.DropDownWidth = 460
		Me.CBOCADASTRARRESIDUOS.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
		Me.CBOCADASTRARRESIDUOS.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
		Me.CBOCADASTRARRESIDUOS.FocusedState.FillColor = System.Drawing.Color.White
		Me.CBOCADASTRARRESIDUOS.FocusedState.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.CBOCADASTRARRESIDUOS.FocusedState.ForeColor = System.Drawing.Color.DimGray
		Me.CBOCADASTRARRESIDUOS.FocusedState.Parent = Me.CBOCADASTRARRESIDUOS
		resources.ApplyResources(Me.CBOCADASTRARRESIDUOS, "CBOCADASTRARRESIDUOS")
		Me.CBOCADASTRARRESIDUOS.ForeColor = System.Drawing.Color.Silver
		Me.CBOCADASTRARRESIDUOS.HoverState.BorderColor = System.Drawing.Color.White
		Me.CBOCADASTRARRESIDUOS.HoverState.FillColor = System.Drawing.Color.White
		Me.CBOCADASTRARRESIDUOS.HoverState.Parent = Me.CBOCADASTRARRESIDUOS
		Me.CBOCADASTRARRESIDUOS.ItemsAppearance.BackColor = System.Drawing.Color.White
		Me.CBOCADASTRARRESIDUOS.ItemsAppearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.CBOCADASTRARRESIDUOS.ItemsAppearance.Parent = Me.CBOCADASTRARRESIDUOS
		Me.CBOCADASTRARRESIDUOS.ItemsAppearance.SelectedBackColor = System.Drawing.Color.SkyBlue
		Me.CBOCADASTRARRESIDUOS.ItemsAppearance.SelectedForeColor = System.Drawing.Color.Maroon
		Me.CBOCADASTRARRESIDUOS.Name = "CBOCADASTRARRESIDUOS"
		Me.CBOCADASTRARRESIDUOS.ShadowDecoration.Color = System.Drawing.Color.Brown
		Me.CBOCADASTRARRESIDUOS.ShadowDecoration.Parent = Me.CBOCADASTRARRESIDUOS
		Me.CBOCADASTRARRESIDUOS.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(2)
		Me.CBOCADASTRARRESIDUOS.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
		Me.CBOCADASTRARRESIDUOS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.CBOCADASTRARRESIDUOS.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
		'
		'TXTOPCAODEENTRADA
		'
		Me.TXTOPCAODEENTRADA.Ativar_CasasDecimais = False
		Me.TXTOPCAODEENTRADA.Ativar_so_Letras = False
		Me.TXTOPCAODEENTRADA.Ativar_so_Numeros = False
		Me.TXTOPCAODEENTRADA.AtivarSoNumeroSemFormatacao_ = False
		Me.TXTOPCAODEENTRADA.BackColor = System.Drawing.Color.White
		Me.TXTOPCAODEENTRADA.BorderColor = System.Drawing.Color.DimGray
		Me.TXTOPCAODEENTRADA.BorderRadius = 5
		Me.TXTOPCAODEENTRADA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
		Me.TXTOPCAODEENTRADA.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.TXTOPCAODEENTRADA.DefaultText = ""
		Me.TXTOPCAODEENTRADA.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
		Me.TXTOPCAODEENTRADA.DisabledState.FillColor = System.Drawing.Color.White
		Me.TXTOPCAODEENTRADA.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.TXTOPCAODEENTRADA.DisabledState.Parent = Me.TXTOPCAODEENTRADA
		Me.TXTOPCAODEENTRADA.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.TXTOPCAODEENTRADA.FocusedState.BorderColor = System.Drawing.Color.DimGray
		Me.TXTOPCAODEENTRADA.FocusedState.FillColor = System.Drawing.Color.White
		Me.TXTOPCAODEENTRADA.FocusedState.ForeColor = System.Drawing.Color.Gray
		Me.TXTOPCAODEENTRADA.FocusedState.Parent = Me.TXTOPCAODEENTRADA
		Me.TXTOPCAODEENTRADA.FocusedState.PlaceholderForeColor = System.Drawing.Color.DimGray
		Me.TXTOPCAODEENTRADA.ForeColor = System.Drawing.Color.Silver
		Me.TXTOPCAODEENTRADA.HoverState.BorderColor = System.Drawing.Color.DimGray
		Me.TXTOPCAODEENTRADA.HoverState.FillColor = System.Drawing.Color.Ivory
		Me.TXTOPCAODEENTRADA.HoverState.ForeColor = System.Drawing.Color.Gray
		Me.TXTOPCAODEENTRADA.HoverState.Parent = Me.TXTOPCAODEENTRADA
		Me.TXTOPCAODEENTRADA.HoverState.PlaceholderForeColor = System.Drawing.Color.DimGray
		Me.TXTOPCAODEENTRADA.IconLeft = Global.Principal.My.Resources.Resources.bullet_key
		resources.ApplyResources(Me.TXTOPCAODEENTRADA, "TXTOPCAODEENTRADA")
		Me.TXTOPCAODEENTRADA.Name = "TXTOPCAODEENTRADA"
		Me.TXTOPCAODEENTRADA.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.TXTOPCAODEENTRADA.PlaceholderText = ""
		Me.TXTOPCAODEENTRADA.ReadOnly = True
		Me.TXTOPCAODEENTRADA.SelectedText = ""
		Me.TXTOPCAODEENTRADA.ShadowDecoration.Parent = Me.TXTOPCAODEENTRADA
		Me.TXTOPCAODEENTRADA.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
		'
		'TXTMOTORISTA_ENTRADA
		'
		Me.TXTMOTORISTA_ENTRADA.AcceptsReturn = True
		Me.TXTMOTORISTA_ENTRADA.AcceptsTab = True
		Me.TXTMOTORISTA_ENTRADA.Ativar_CasasDecimais = False
		Me.TXTMOTORISTA_ENTRADA.Ativar_so_Letras = True
		Me.TXTMOTORISTA_ENTRADA.Ativar_so_Numeros = False
		Me.TXTMOTORISTA_ENTRADA.AtivarSoNumeroSemFormatacao_ = False
		Me.TXTMOTORISTA_ENTRADA.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
		Me.TXTMOTORISTA_ENTRADA.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
		Me.TXTMOTORISTA_ENTRADA.BackColor = System.Drawing.Color.White
		Me.TXTMOTORISTA_ENTRADA.BorderColor = System.Drawing.Color.DimGray
		Me.TXTMOTORISTA_ENTRADA.BorderRadius = 5
		Me.TXTMOTORISTA_ENTRADA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
		Me.TXTMOTORISTA_ENTRADA.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.TXTMOTORISTA_ENTRADA.DefaultText = ""
		Me.TXTMOTORISTA_ENTRADA.DisabledState.BorderColor = System.Drawing.Color.DimGray
		Me.TXTMOTORISTA_ENTRADA.DisabledState.FillColor = System.Drawing.Color.White
		Me.TXTMOTORISTA_ENTRADA.DisabledState.ForeColor = System.Drawing.Color.DimGray
		Me.TXTMOTORISTA_ENTRADA.DisabledState.Parent = Me.TXTMOTORISTA_ENTRADA
		Me.TXTMOTORISTA_ENTRADA.DisabledState.PlaceholderForeColor = System.Drawing.Color.DimGray
		Me.TXTMOTORISTA_ENTRADA.FocusedState.BorderColor = System.Drawing.Color.DimGray
		Me.TXTMOTORISTA_ENTRADA.FocusedState.FillColor = System.Drawing.Color.WhiteSmoke
		Me.TXTMOTORISTA_ENTRADA.FocusedState.ForeColor = System.Drawing.Color.DimGray
		Me.TXTMOTORISTA_ENTRADA.FocusedState.Parent = Me.TXTMOTORISTA_ENTRADA
		Me.TXTMOTORISTA_ENTRADA.FocusedState.PlaceholderForeColor = System.Drawing.Color.DimGray
		Me.TXTMOTORISTA_ENTRADA.ForeColor = System.Drawing.Color.Silver
		Me.TXTMOTORISTA_ENTRADA.HoverState.BorderColor = System.Drawing.Color.DimGray
		Me.TXTMOTORISTA_ENTRADA.HoverState.FillColor = System.Drawing.Color.Ivory
		Me.TXTMOTORISTA_ENTRADA.HoverState.ForeColor = System.Drawing.Color.Gray
		Me.TXTMOTORISTA_ENTRADA.HoverState.Parent = Me.TXTMOTORISTA_ENTRADA
		Me.TXTMOTORISTA_ENTRADA.HoverState.PlaceholderForeColor = System.Drawing.Color.DimGray
		resources.ApplyResources(Me.TXTMOTORISTA_ENTRADA, "TXTMOTORISTA_ENTRADA")
		Me.TXTMOTORISTA_ENTRADA.Name = "TXTMOTORISTA_ENTRADA"
		Me.TXTMOTORISTA_ENTRADA.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.TXTMOTORISTA_ENTRADA.PlaceholderText = ""
		Me.TXTMOTORISTA_ENTRADA.SelectedText = ""
		Me.TXTMOTORISTA_ENTRADA.ShadowDecoration.Parent = Me.TXTMOTORISTA_ENTRADA
		Me.TXTMOTORISTA_ENTRADA.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
		'
		'TXTPESO_BRUTO
		'
		Me.TXTPESO_BRUTO.Ativar_CasasDecimais = True
		Me.TXTPESO_BRUTO.Ativar_so_Letras = False
		Me.TXTPESO_BRUTO.Ativar_so_Numeros = True
		Me.TXTPESO_BRUTO.AtivarSoNumeroSemFormatacao_ = False
		Me.TXTPESO_BRUTO.BackColor = System.Drawing.Color.White
		Me.TXTPESO_BRUTO.BorderColor = System.Drawing.Color.DimGray
		Me.TXTPESO_BRUTO.BorderRadius = 5
		Me.TXTPESO_BRUTO.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.TXTPESO_BRUTO.DefaultText = ""
		Me.TXTPESO_BRUTO.DisabledState.BorderColor = System.Drawing.Color.DimGray
		Me.TXTPESO_BRUTO.DisabledState.FillColor = System.Drawing.Color.White
		Me.TXTPESO_BRUTO.DisabledState.ForeColor = System.Drawing.Color.DimGray
		Me.TXTPESO_BRUTO.DisabledState.Parent = Me.TXTPESO_BRUTO
		Me.TXTPESO_BRUTO.DisabledState.PlaceholderForeColor = System.Drawing.Color.DimGray
		Me.TXTPESO_BRUTO.FocusedState.BorderColor = System.Drawing.Color.DimGray
		Me.TXTPESO_BRUTO.FocusedState.FillColor = System.Drawing.Color.WhiteSmoke
		Me.TXTPESO_BRUTO.FocusedState.ForeColor = System.Drawing.Color.DimGray
		Me.TXTPESO_BRUTO.FocusedState.Parent = Me.TXTPESO_BRUTO
		Me.TXTPESO_BRUTO.FocusedState.PlaceholderForeColor = System.Drawing.Color.DimGray
		Me.TXTPESO_BRUTO.ForeColor = System.Drawing.Color.DimGray
		Me.TXTPESO_BRUTO.HoverState.BorderColor = System.Drawing.Color.DimGray
		Me.TXTPESO_BRUTO.HoverState.FillColor = System.Drawing.Color.Ivory
		Me.TXTPESO_BRUTO.HoverState.ForeColor = System.Drawing.Color.Gray
		Me.TXTPESO_BRUTO.HoverState.Parent = Me.TXTPESO_BRUTO
		Me.TXTPESO_BRUTO.HoverState.PlaceholderForeColor = System.Drawing.Color.DimGray
		resources.ApplyResources(Me.TXTPESO_BRUTO, "TXTPESO_BRUTO")
		Me.TXTPESO_BRUTO.Name = "TXTPESO_BRUTO"
		Me.TXTPESO_BRUTO.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.TXTPESO_BRUTO.PlaceholderText = ""
		Me.TXTPESO_BRUTO.SelectedText = ""
		Me.TXTPESO_BRUTO.ShadowDecoration.Parent = Me.TXTPESO_BRUTO
		Me.TXTPESO_BRUTO.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
		'
		'TXTPLACA_ENTRADA
		'
		Me.TXTPLACA_ENTRADA.Animated = True
		Me.TXTPLACA_ENTRADA.Ativar_CasasDecimais = False
		Me.TXTPLACA_ENTRADA.Ativar_so_Letras = False
		Me.TXTPLACA_ENTRADA.Ativar_so_Numeros = False
		Me.TXTPLACA_ENTRADA.AtivarSoNumeroSemFormatacao_ = False
		Me.TXTPLACA_ENTRADA.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
		Me.TXTPLACA_ENTRADA.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
		Me.TXTPLACA_ENTRADA.AutoRoundedCorners = True
		Me.TXTPLACA_ENTRADA.BackColor = System.Drawing.Color.White
		Me.TXTPLACA_ENTRADA.BorderColor = System.Drawing.Color.Silver
		Me.TXTPLACA_ENTRADA.BorderRadius = 13
		Me.TXTPLACA_ENTRADA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
		Me.TXTPLACA_ENTRADA.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.TXTPLACA_ENTRADA.DefaultText = ""
		Me.TXTPLACA_ENTRADA.DisabledState.BorderColor = System.Drawing.Color.DimGray
		Me.TXTPLACA_ENTRADA.DisabledState.FillColor = System.Drawing.Color.White
		Me.TXTPLACA_ENTRADA.DisabledState.ForeColor = System.Drawing.Color.Gray
		Me.TXTPLACA_ENTRADA.DisabledState.Parent = Me.TXTPLACA_ENTRADA
		Me.TXTPLACA_ENTRADA.DisabledState.PlaceholderForeColor = System.Drawing.Color.DimGray
		Me.TXTPLACA_ENTRADA.FocusedState.BorderColor = System.Drawing.Color.DimGray
		Me.TXTPLACA_ENTRADA.FocusedState.FillColor = System.Drawing.Color.WhiteSmoke
		Me.TXTPLACA_ENTRADA.FocusedState.ForeColor = System.Drawing.Color.DimGray
		Me.TXTPLACA_ENTRADA.FocusedState.Parent = Me.TXTPLACA_ENTRADA
		Me.TXTPLACA_ENTRADA.FocusedState.PlaceholderForeColor = System.Drawing.Color.DarkGray
		Me.TXTPLACA_ENTRADA.ForeColor = System.Drawing.Color.Gray
		Me.TXTPLACA_ENTRADA.HoverState.BorderColor = System.Drawing.Color.DimGray
		Me.TXTPLACA_ENTRADA.HoverState.FillColor = System.Drawing.Color.Ivory
		Me.TXTPLACA_ENTRADA.HoverState.ForeColor = System.Drawing.Color.Gray
		Me.TXTPLACA_ENTRADA.HoverState.Parent = Me.TXTPLACA_ENTRADA
		resources.ApplyResources(Me.TXTPLACA_ENTRADA, "TXTPLACA_ENTRADA")
		Me.TXTPLACA_ENTRADA.Name = "TXTPLACA_ENTRADA"
		Me.TXTPLACA_ENTRADA.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.TXTPLACA_ENTRADA.PlaceholderForeColor = System.Drawing.Color.DarkGray
		Me.TXTPLACA_ENTRADA.PlaceholderText = ""
		Me.TXTPLACA_ENTRADA.SelectedText = ""
		Me.TXTPLACA_ENTRADA.ShadowDecoration.Parent = Me.TXTPLACA_ENTRADA
		Me.TXTPLACA_ENTRADA.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
		'
		'Label4
		'
		resources.ApplyResources(Me.Label4, "Label4")
		Me.Label4.BackColor = System.Drawing.Color.Transparent
		Me.Label4.ForeColor = System.Drawing.Color.DarkGray
		Me.Label4.Name = "Label4"
		'
		'Label3
		'
		resources.ApplyResources(Me.Label3, "Label3")
		Me.Label3.BackColor = System.Drawing.Color.Transparent
		Me.Label3.ForeColor = System.Drawing.Color.DarkGray
		Me.Label3.Name = "Label3"
		'
		'Label24
		'
		resources.ApplyResources(Me.Label24, "Label24")
		Me.Label24.BackColor = System.Drawing.Color.Transparent
		Me.Label24.ForeColor = System.Drawing.Color.DarkGray
		Me.Label24.Name = "Label24"
		'
		'Label2
		'
		resources.ApplyResources(Me.Label2, "Label2")
		Me.Label2.BackColor = System.Drawing.Color.Transparent
		Me.Label2.ForeColor = System.Drawing.Color.DarkGray
		Me.Label2.Name = "Label2"
		'
		'Label1
		'
		resources.ApplyResources(Me.Label1, "Label1")
		Me.Label1.BackColor = System.Drawing.Color.Transparent
		Me.Label1.ForeColor = System.Drawing.Color.DarkGray
		Me.Label1.Name = "Label1"
		'
		'Label5
		'
		resources.ApplyResources(Me.Label5, "Label5")
		Me.Label5.BackColor = System.Drawing.Color.Transparent
		Me.Label5.ForeColor = System.Drawing.Color.DarkGray
		Me.Label5.Name = "Label5"
		'
		'LBLPLACA
		'
		resources.ApplyResources(Me.LBLPLACA, "LBLPLACA")
		Me.LBLPLACA.BackColor = System.Drawing.Color.Transparent
		Me.LBLPLACA.ForeColor = System.Drawing.Color.DarkGray
		Me.LBLPLACA.Name = "LBLPLACA"
		'
		'TabControl
		'
		Me.TabControl.Controls.Add(Me.TabPageEntrada)
		Me.TabControl.Controls.Add(Me.TabPageSaida)
		Me.TabControl.Controls.Add(Me.TabPagePesqCNPJ)
		Me.TabControl.Controls.Add(Me.TabPage_EnviarEmail)
		resources.ApplyResources(Me.TabControl, "TabControl")
		Me.TabControl.HotTrack = True
		Me.TabControl.Name = "TabControl"
		Me.TabControl.SelectedIndex = 0
		'
		'LinkLabel1
		'
		resources.ApplyResources(Me.LinkLabel1, "LinkLabel1")
		Me.LinkLabel1.LinkColor = System.Drawing.Color.DimGray
		Me.LinkLabel1.Name = "LinkLabel1"
		Me.LinkLabel1.TabStop = True
		'
		'FRMControlePesagemManual_
		'
		resources.ApplyResources(Me, "$this")
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.SkyBlue
		Me.Controls.Add(Me.LinkLabel1)
		Me.Controls.Add(Me.DgvDados)
		Me.Controls.Add(Me.TabControl)
		Me.Controls.Add(Me.BTDELETAR)
		Me.Controls.Add(Me.BTCARREGAR)
		Me.Controls.Add(Me.BTSALVAR)
		Me.Controls.Add(Me.BTN_IMPRIMIR)
		Me.Controls.Add(Me.BTLIMPAR)
		Me.Controls.Add(Me.BTINSERIR)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.KeyPreview = True
		Me.Name = "FRMControlePesagemManual_"
		Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
		CType(Me.DgvDados, System.ComponentModel.ISupportInitialize).EndInit()
		Me.TabPage_EnviarEmail.ResumeLayout(False)
		Me.TabPage_EnviarEmail.PerformLayout()
		Me.TabPagePesqCNPJ.ResumeLayout(False)
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		Me.GBAtividades.ResumeLayout(False)
		Me.TabPageSaida.ResumeLayout(False)
		Me.TabPageSaida.PerformLayout()
		Me.TabPageEntrada.ResumeLayout(False)
		Me.TabPageEntrada.PerformLayout()
		Me.TabControl.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents BTLIMPAR As Button
    Friend WithEvents BTINSERIR As Button
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents NotifyIconControlePesagemManual As NotifyIcon
    Friend WithEvents BTN_IMPRIMIR As Button
    Friend WithEvents BTSALVAR As Button
    Friend WithEvents BTCARREGAR As Button
    Friend WithEvents BTDELETAR As Button
    Friend WithEvents DgvDados As DataGridView
    Friend WithEvents TabPage_EnviarEmail As TabPage
    Friend WithEvents BTexcluiranexos As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTincluiranexos As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Lista_de_Anexos As ListBox
    Friend WithEvents TxtPorta As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents CboServidor As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents TXTNomeUserEmail As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents CBOPrioridade As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents TxtEnviarEmail As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TXTmessage As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TXTfrom As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TXTSubject As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TXTto As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TxtSenha As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TabPagePesqCNPJ As TabPage
    Friend WithEvents BTpesquisar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TXTResult As RichTextBox
    Friend WithEvents TXTCNPJ As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TabPageSaida As TabPage
    Friend WithEvents Label27 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents BTPESARSAIDA As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents TXTSTATUS As TextboxMonetário
    Friend WithEvents TxtOpcaoEntrada_Saida As TextboxMonetário
    Friend WithEvents TXTPESOBRUTO_LEITURA As TextboxMonetário
    Friend WithEvents TXTOPCAODESAIDA As TextboxMonetário
    Friend WithEvents TXTTRASNPORTADORSAIDA As TextboxMonetário
    Friend WithEvents TXTCLIENTESAIDA As TextboxMonetário
    Friend WithEvents TXTMOTORISTA_SAIDA As TextboxMonetário
    Friend WithEvents TXTRESIDUO As TextboxMonetário
    Friend WithEvents TXTPESO_TARA As TextboxMonetário
    Friend WithEvents TXTPLACA_SAIDA As TextboxMonetário
    Public WithEvents TabPageEntrada As TabPage
    Friend WithEvents BTcadastrarTransportadora As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents BTcadastrarCliente As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents BTcadastrarResiduo As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents BTPESARENTRADA As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents CBOTRANSPORTADORENTRADA As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents CBOCLIENTEENTRADA As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents CBOCADASTRARRESIDUOS As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents TXTOPCAODEENTRADA As TextboxMonetário
    Friend WithEvents TXTMOTORISTA_ENTRADA As TextboxMonetário
    Friend WithEvents TXTPESO_BRUTO As TextboxMonetário
    Friend WithEvents TXTPLACA_ENTRADA As TextboxMonetário
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents LBLPLACA As Label
    Friend WithEvents TabControl As TabControl
    Friend WithEvents IPsMaquina As Label
    Friend WithEvents CODIGO As DataGridViewTextBoxColumn
    Friend WithEvents PLACA As DataGridViewTextBoxColumn
    Friend WithEvents PESO_BRUTO As DataGridViewTextBoxColumn
    Friend WithEvents PESO_TARA As DataGridViewTextBoxColumn
    Friend WithEvents PESO_LIQUIDO As DataGridViewTextBoxColumn
    Friend WithEvents MOTORISTA As DataGridViewTextBoxColumn
    Friend WithEvents CLIENTE As DataGridViewTextBoxColumn
    Friend WithEvents TRANSPORTADORA As DataGridViewTextBoxColumn
    Friend WithEvents OPCAO_DE_ENTRADA As DataGridViewTextBoxColumn
    Friend WithEvents OPCAO_DE_SAIDA As DataGridViewTextBoxColumn
    Friend WithEvents STATUS As DataGridViewTextBoxColumn
    Friend WithEvents RESIDUO As DataGridViewTextBoxColumn
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents LblNatureza_juridica As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents LblFantasia As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents LblCnpj As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents LblUltima_atualizacao As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents LblStatus As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents LblAbertura As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents LblPorte As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents LblMunicipio As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents LblCep As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents LblNumero As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents LblTelefone As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents LblEmail As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents LblSituacao As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents LblBairro As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents LblLogradouro As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents LblUF As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents LblNome As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents LblTipo As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents LblData_Situacao As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LblData_situacao_especial As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents LblSituacao_especia As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents LblMotivo_situacao As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents LblEfr As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents LblComplemento As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents GBAtividades As GroupBox
    Friend WithEvents TreeView_Atividades As TreeView
	Friend WithEvents LBLCODIGO As Label
	Friend WithEvents Label13 As Label
End Class
