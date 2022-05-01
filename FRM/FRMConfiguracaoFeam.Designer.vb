<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRMConfiguracaoFeam
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
		Dim GB_RequisicaoFeam As System.Windows.Forms.GroupBox
		Me.PBbloquear = New System.Windows.Forms.PictureBox()
		Me.PBDesbloquear = New System.Windows.Forms.PictureBox()
		Me.Txt_SalvarManifestoLote = New Principal.TextboxMonetário()
		Me.Txt_DonwloadCDF = New Principal.TextboxMonetário()
		Me.Txt_Donwload_PDF_Manifesto = New Principal.TextboxMonetário()
		Me.Txt_RetornaListaResiduo = New Principal.TextboxMonetário()
		Me.TxtRetornaListaAcondicionamento = New Principal.TextboxMonetário()
		Me.TxtRetornaListaClasse = New Principal.TextboxMonetário()
		Me.TxtRetornaListaUnidade = New Principal.TextboxMonetário()
		Me.TxtRetornaListaTecnologia = New Principal.TextboxMonetário()
		Me.Txt_EmiteCDF = New Principal.TextboxMonetário()
		Me.Txt_RetornaListaCodigoBarasManifesto = New Principal.TextboxMonetário()
		Me.Txt_CancelarManifesto = New Principal.TextboxMonetário()
		Me.Txt_AceiteAlteracaoRecebimento = New Principal.TextboxMonetário()
		Me.Txt_AlteraçãoManifestoRecebido = New Principal.TextboxMonetário()
		Me.Txt_ReceberManifestoLote = New Principal.TextboxMonetário()
		Me.Txt_retornaListaEstadoFisico = New Principal.TextboxMonetário()
		Me.Txt_RetornaManifesto = New Principal.TextboxMonetário()
		Me.Txt_api_gettoken = New Principal.TextboxMonetário()
		Me.GBPessoaFisica = New System.Windows.Forms.GroupBox()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.TxtSenhaAcesso = New Principal.TextboxMonetário()
		Me.Txt_Id_CPF_Usuario = New Principal.TextboxMonetário()
		Me.TxtCodigoUnidadePF = New Principal.TextboxMonetário()
		Me.TXT_CNPJ_pessoa_fisica = New Principal.TextboxMonetário()
		Me.BtRegistrarAlteracoes = New System.Windows.Forms.Button()
		Me.GBPessoaJuridica = New System.Windows.Forms.GroupBox()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.TxtSenhaAcessoPJ = New Principal.TextboxMonetário()
		Me.TXT_CNPJ_pessoa_Juridica = New Principal.TextboxMonetário()
		Me.TxtCodigoUnidadePJ = New Principal.TextboxMonetário()
		Me.TxtIdCPFusuarioPJ = New Principal.TextboxMonetário()
		Me.RdbPessoaFisica = New System.Windows.Forms.RadioButton()
		Me.RdbPessoaJridica = New System.Windows.Forms.RadioButton()
		Me.GBModalidade = New System.Windows.Forms.GroupBox()
		Me.RdbDesativado = New System.Windows.Forms.RadioButton()
		Me.GB_CodigoBarras = New System.Windows.Forms.GroupBox()
		Me.RDB_ReceberMtr34Dig = New System.Windows.Forms.RadioButton()
		Me.RDB_ReceberMtr10Dig = New System.Windows.Forms.RadioButton()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.Label12 = New System.Windows.Forms.Label()
		Me.txtDestinadorCodigoUnidade = New Principal.TextboxMonetário()
		GB_RequisicaoFeam = New System.Windows.Forms.GroupBox()
		GB_RequisicaoFeam.SuspendLayout()
		CType(Me.PBbloquear, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PBDesbloquear, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.GBPessoaFisica.SuspendLayout()
		Me.GBPessoaJuridica.SuspendLayout()
		Me.GBModalidade.SuspendLayout()
		Me.GB_CodigoBarras.SuspendLayout()
		Me.GroupBox1.SuspendLayout()
		Me.SuspendLayout()
		'
		'GB_RequisicaoFeam
		'
		GB_RequisicaoFeam.AutoSize = True
		GB_RequisicaoFeam.Controls.Add(Me.PBbloquear)
		GB_RequisicaoFeam.Controls.Add(Me.PBDesbloquear)
		GB_RequisicaoFeam.Controls.Add(Me.Txt_SalvarManifestoLote)
		GB_RequisicaoFeam.Controls.Add(Me.Txt_DonwloadCDF)
		GB_RequisicaoFeam.Controls.Add(Me.Txt_Donwload_PDF_Manifesto)
		GB_RequisicaoFeam.Controls.Add(Me.Txt_RetornaListaResiduo)
		GB_RequisicaoFeam.Controls.Add(Me.TxtRetornaListaAcondicionamento)
		GB_RequisicaoFeam.Controls.Add(Me.TxtRetornaListaClasse)
		GB_RequisicaoFeam.Controls.Add(Me.TxtRetornaListaUnidade)
		GB_RequisicaoFeam.Controls.Add(Me.TxtRetornaListaTecnologia)
		GB_RequisicaoFeam.Controls.Add(Me.Txt_EmiteCDF)
		GB_RequisicaoFeam.Controls.Add(Me.Txt_RetornaListaCodigoBarasManifesto)
		GB_RequisicaoFeam.Controls.Add(Me.Txt_CancelarManifesto)
		GB_RequisicaoFeam.Controls.Add(Me.Txt_AceiteAlteracaoRecebimento)
		GB_RequisicaoFeam.Controls.Add(Me.Txt_AlteraçãoManifestoRecebido)
		GB_RequisicaoFeam.Controls.Add(Me.Txt_ReceberManifestoLote)
		GB_RequisicaoFeam.Controls.Add(Me.Txt_retornaListaEstadoFisico)
		GB_RequisicaoFeam.Controls.Add(Me.Txt_RetornaManifesto)
		GB_RequisicaoFeam.Controls.Add(Me.Txt_api_gettoken)
		GB_RequisicaoFeam.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		GB_RequisicaoFeam.Font = New System.Drawing.Font("Segoe UI", 12.0!)
		GB_RequisicaoFeam.ForeColor = System.Drawing.Color.DodgerBlue
		GB_RequisicaoFeam.ImeMode = System.Windows.Forms.ImeMode.Off
		GB_RequisicaoFeam.Location = New System.Drawing.Point(427, 14)
		GB_RequisicaoFeam.Margin = New System.Windows.Forms.Padding(4)
		GB_RequisicaoFeam.Name = "GB_RequisicaoFeam"
		GB_RequisicaoFeam.Padding = New System.Windows.Forms.Padding(4)
		GB_RequisicaoFeam.Size = New System.Drawing.Size(3641, 1875)
		GB_RequisicaoFeam.TabIndex = 2
		GB_RequisicaoFeam.TabStop = False
		GB_RequisicaoFeam.Text = "Requisições"
		'
		'PBbloquear
		'
		Me.PBbloquear.Image = Global.Principal.My.Resources.Resources.lock
		Me.PBbloquear.Location = New System.Drawing.Point(520, 15)
		Me.PBbloquear.Name = "PBbloquear"
		Me.PBbloquear.Size = New System.Drawing.Size(20, 20)
		Me.PBbloquear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.PBbloquear.TabIndex = 16
		Me.PBbloquear.TabStop = False
		'
		'PBDesbloquear
		'
		Me.PBDesbloquear.Image = Global.Principal.My.Resources.Resources.lock_edit
		Me.PBDesbloquear.Location = New System.Drawing.Point(494, 15)
		Me.PBDesbloquear.Name = "PBDesbloquear"
		Me.PBDesbloquear.Size = New System.Drawing.Size(20, 20)
		Me.PBDesbloquear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.PBDesbloquear.TabIndex = 16
		Me.PBDesbloquear.TabStop = False
		'
		'Txt_SalvarManifestoLote
		'
		Me.Txt_SalvarManifestoLote.AcceptsTab = True
		Me.Txt_SalvarManifestoLote.Ativar_CasasDecimais = False
		Me.Txt_SalvarManifestoLote.Ativar_so_Letras = False
		Me.Txt_SalvarManifestoLote.Ativar_so_Numeros = False
		Me.Txt_SalvarManifestoLote.AtivarSoNumeroSemFormatacao_ = False
		Me.Txt_SalvarManifestoLote.BorderColor = System.Drawing.Color.DimGray
		Me.Txt_SalvarManifestoLote.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.Txt_SalvarManifestoLote.DefaultText = ""
		Me.Txt_SalvarManifestoLote.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
		Me.Txt_SalvarManifestoLote.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
		Me.Txt_SalvarManifestoLote.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.Txt_SalvarManifestoLote.DisabledState.Parent = Me.Txt_SalvarManifestoLote
		Me.Txt_SalvarManifestoLote.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.Txt_SalvarManifestoLote.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.Txt_SalvarManifestoLote.FocusedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.Txt_SalvarManifestoLote.FocusedState.Parent = Me.Txt_SalvarManifestoLote
		Me.Txt_SalvarManifestoLote.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.Txt_SalvarManifestoLote.HoverState.Parent = Me.Txt_SalvarManifestoLote
		Me.Txt_SalvarManifestoLote.Location = New System.Drawing.Point(9, 260)
		Me.Txt_SalvarManifestoLote.Margin = New System.Windows.Forms.Padding(125, 177, 125, 177)
		Me.Txt_SalvarManifestoLote.Name = "Txt_SalvarManifestoLote"
		Me.Txt_SalvarManifestoLote.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.Txt_SalvarManifestoLote.PlaceholderText = ""
		Me.Txt_SalvarManifestoLote.SelectedText = ""
		Me.Txt_SalvarManifestoLote.ShadowDecoration.Parent = Me.Txt_SalvarManifestoLote
		Me.Txt_SalvarManifestoLote.Size = New System.Drawing.Size(2858, 25)
		Me.Txt_SalvarManifestoLote.TabIndex = 6
		Me.Txt_SalvarManifestoLote.WordWrap = False
		'
		'Txt_DonwloadCDF
		'
		Me.Txt_DonwloadCDF.AcceptsTab = True
		Me.Txt_DonwloadCDF.Ativar_CasasDecimais = False
		Me.Txt_DonwloadCDF.Ativar_so_Letras = False
		Me.Txt_DonwloadCDF.Ativar_so_Numeros = False
		Me.Txt_DonwloadCDF.AtivarSoNumeroSemFormatacao_ = False
		Me.Txt_DonwloadCDF.BorderColor = System.Drawing.Color.DimGray
		Me.Txt_DonwloadCDF.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.Txt_DonwloadCDF.DefaultText = ""
		Me.Txt_DonwloadCDF.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
		Me.Txt_DonwloadCDF.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
		Me.Txt_DonwloadCDF.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.Txt_DonwloadCDF.DisabledState.Parent = Me.Txt_DonwloadCDF
		Me.Txt_DonwloadCDF.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.Txt_DonwloadCDF.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.Txt_DonwloadCDF.FocusedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.Txt_DonwloadCDF.FocusedState.Parent = Me.Txt_DonwloadCDF
		Me.Txt_DonwloadCDF.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.Txt_DonwloadCDF.HoverState.Parent = Me.Txt_DonwloadCDF
		Me.Txt_DonwloadCDF.Location = New System.Drawing.Point(9, 324)
		Me.Txt_DonwloadCDF.Margin = New System.Windows.Forms.Padding(125, 177, 125, 177)
		Me.Txt_DonwloadCDF.Name = "Txt_DonwloadCDF"
		Me.Txt_DonwloadCDF.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.Txt_DonwloadCDF.PlaceholderText = ""
		Me.Txt_DonwloadCDF.SelectedText = ""
		Me.Txt_DonwloadCDF.ShadowDecoration.Parent = Me.Txt_DonwloadCDF
		Me.Txt_DonwloadCDF.Size = New System.Drawing.Size(2858, 25)
		Me.Txt_DonwloadCDF.TabIndex = 8
		Me.Txt_DonwloadCDF.WordWrap = False
		'
		'Txt_Donwload_PDF_Manifesto
		'
		Me.Txt_Donwload_PDF_Manifesto.AcceptsTab = True
		Me.Txt_Donwload_PDF_Manifesto.Ativar_CasasDecimais = False
		Me.Txt_Donwload_PDF_Manifesto.Ativar_so_Letras = False
		Me.Txt_Donwload_PDF_Manifesto.Ativar_so_Numeros = False
		Me.Txt_Donwload_PDF_Manifesto.AtivarSoNumeroSemFormatacao_ = False
		Me.Txt_Donwload_PDF_Manifesto.BorderColor = System.Drawing.Color.DimGray
		Me.Txt_Donwload_PDF_Manifesto.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.Txt_Donwload_PDF_Manifesto.DefaultText = ""
		Me.Txt_Donwload_PDF_Manifesto.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
		Me.Txt_Donwload_PDF_Manifesto.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
		Me.Txt_Donwload_PDF_Manifesto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.Txt_Donwload_PDF_Manifesto.DisabledState.Parent = Me.Txt_Donwload_PDF_Manifesto
		Me.Txt_Donwload_PDF_Manifesto.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.Txt_Donwload_PDF_Manifesto.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.Txt_Donwload_PDF_Manifesto.FocusedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.Txt_Donwload_PDF_Manifesto.FocusedState.Parent = Me.Txt_Donwload_PDF_Manifesto
		Me.Txt_Donwload_PDF_Manifesto.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.Txt_Donwload_PDF_Manifesto.HoverState.Parent = Me.Txt_Donwload_PDF_Manifesto
		Me.Txt_Donwload_PDF_Manifesto.Location = New System.Drawing.Point(9, 292)
		Me.Txt_Donwload_PDF_Manifesto.Margin = New System.Windows.Forms.Padding(68, 92, 68, 92)
		Me.Txt_Donwload_PDF_Manifesto.Name = "Txt_Donwload_PDF_Manifesto"
		Me.Txt_Donwload_PDF_Manifesto.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.Txt_Donwload_PDF_Manifesto.PlaceholderText = ""
		Me.Txt_Donwload_PDF_Manifesto.SelectedText = ""
		Me.Txt_Donwload_PDF_Manifesto.ShadowDecoration.Parent = Me.Txt_Donwload_PDF_Manifesto
		Me.Txt_Donwload_PDF_Manifesto.Size = New System.Drawing.Size(2858, 25)
		Me.Txt_Donwload_PDF_Manifesto.TabIndex = 7
		Me.Txt_Donwload_PDF_Manifesto.WordWrap = False
		'
		'Txt_RetornaListaResiduo
		'
		Me.Txt_RetornaListaResiduo.AcceptsTab = True
		Me.Txt_RetornaListaResiduo.Ativar_CasasDecimais = False
		Me.Txt_RetornaListaResiduo.Ativar_so_Letras = False
		Me.Txt_RetornaListaResiduo.Ativar_so_Numeros = False
		Me.Txt_RetornaListaResiduo.AtivarSoNumeroSemFormatacao_ = False
		Me.Txt_RetornaListaResiduo.BorderColor = System.Drawing.Color.DimGray
		Me.Txt_RetornaListaResiduo.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.Txt_RetornaListaResiduo.DefaultText = ""
		Me.Txt_RetornaListaResiduo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
		Me.Txt_RetornaListaResiduo.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
		Me.Txt_RetornaListaResiduo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.Txt_RetornaListaResiduo.DisabledState.Parent = Me.Txt_RetornaListaResiduo
		Me.Txt_RetornaListaResiduo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.Txt_RetornaListaResiduo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.Txt_RetornaListaResiduo.FocusedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.Txt_RetornaListaResiduo.FocusedState.Parent = Me.Txt_RetornaListaResiduo
		Me.Txt_RetornaListaResiduo.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.Txt_RetornaListaResiduo.HoverState.Parent = Me.Txt_RetornaListaResiduo
		Me.Txt_RetornaListaResiduo.Location = New System.Drawing.Point(9, 196)
		Me.Txt_RetornaListaResiduo.Margin = New System.Windows.Forms.Padding(420, 654, 420, 654)
		Me.Txt_RetornaListaResiduo.Name = "Txt_RetornaListaResiduo"
		Me.Txt_RetornaListaResiduo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.Txt_RetornaListaResiduo.PlaceholderText = ""
		Me.Txt_RetornaListaResiduo.SelectedText = ""
		Me.Txt_RetornaListaResiduo.ShadowDecoration.Parent = Me.Txt_RetornaListaResiduo
		Me.Txt_RetornaListaResiduo.Size = New System.Drawing.Size(2858, 25)
		Me.Txt_RetornaListaResiduo.TabIndex = 4
		Me.Txt_RetornaListaResiduo.WordWrap = False
		'
		'TxtRetornaListaAcondicionamento
		'
		Me.TxtRetornaListaAcondicionamento.AcceptsTab = True
		Me.TxtRetornaListaAcondicionamento.Ativar_CasasDecimais = False
		Me.TxtRetornaListaAcondicionamento.Ativar_so_Letras = False
		Me.TxtRetornaListaAcondicionamento.Ativar_so_Numeros = False
		Me.TxtRetornaListaAcondicionamento.AtivarSoNumeroSemFormatacao_ = False
		Me.TxtRetornaListaAcondicionamento.BorderColor = System.Drawing.Color.DimGray
		Me.TxtRetornaListaAcondicionamento.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.TxtRetornaListaAcondicionamento.DefaultText = ""
		Me.TxtRetornaListaAcondicionamento.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
		Me.TxtRetornaListaAcondicionamento.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
		Me.TxtRetornaListaAcondicionamento.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.TxtRetornaListaAcondicionamento.DisabledState.Parent = Me.TxtRetornaListaAcondicionamento
		Me.TxtRetornaListaAcondicionamento.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.TxtRetornaListaAcondicionamento.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.TxtRetornaListaAcondicionamento.FocusedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.TxtRetornaListaAcondicionamento.FocusedState.Parent = Me.TxtRetornaListaAcondicionamento
		Me.TxtRetornaListaAcondicionamento.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.TxtRetornaListaAcondicionamento.HoverState.Parent = Me.TxtRetornaListaAcondicionamento
		Me.TxtRetornaListaAcondicionamento.Location = New System.Drawing.Point(9, 228)
		Me.TxtRetornaListaAcondicionamento.Margin = New System.Windows.Forms.Padding(229, 340, 229, 340)
		Me.TxtRetornaListaAcondicionamento.Name = "TxtRetornaListaAcondicionamento"
		Me.TxtRetornaListaAcondicionamento.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.TxtRetornaListaAcondicionamento.PlaceholderText = ""
		Me.TxtRetornaListaAcondicionamento.SelectedText = ""
		Me.TxtRetornaListaAcondicionamento.ShadowDecoration.Parent = Me.TxtRetornaListaAcondicionamento
		Me.TxtRetornaListaAcondicionamento.Size = New System.Drawing.Size(2858, 25)
		Me.TxtRetornaListaAcondicionamento.TabIndex = 5
		Me.TxtRetornaListaAcondicionamento.WordWrap = False
		'
		'TxtRetornaListaClasse
		'
		Me.TxtRetornaListaClasse.AcceptsTab = True
		Me.TxtRetornaListaClasse.Ativar_CasasDecimais = False
		Me.TxtRetornaListaClasse.Ativar_so_Letras = False
		Me.TxtRetornaListaClasse.Ativar_so_Numeros = False
		Me.TxtRetornaListaClasse.AtivarSoNumeroSemFormatacao_ = False
		Me.TxtRetornaListaClasse.BorderColor = System.Drawing.Color.DimGray
		Me.TxtRetornaListaClasse.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.TxtRetornaListaClasse.DefaultText = ""
		Me.TxtRetornaListaClasse.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
		Me.TxtRetornaListaClasse.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
		Me.TxtRetornaListaClasse.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.TxtRetornaListaClasse.DisabledState.Parent = Me.TxtRetornaListaClasse
		Me.TxtRetornaListaClasse.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.TxtRetornaListaClasse.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.TxtRetornaListaClasse.FocusedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.TxtRetornaListaClasse.FocusedState.Parent = Me.TxtRetornaListaClasse
		Me.TxtRetornaListaClasse.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.TxtRetornaListaClasse.HoverState.Parent = Me.TxtRetornaListaClasse
		Me.TxtRetornaListaClasse.Location = New System.Drawing.Point(9, 69)
		Me.TxtRetornaListaClasse.Margin = New System.Windows.Forms.Padding(125, 177, 125, 177)
		Me.TxtRetornaListaClasse.Name = "TxtRetornaListaClasse"
		Me.TxtRetornaListaClasse.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.TxtRetornaListaClasse.PlaceholderText = ""
		Me.TxtRetornaListaClasse.SelectedText = ""
		Me.TxtRetornaListaClasse.ShadowDecoration.Parent = Me.TxtRetornaListaClasse
		Me.TxtRetornaListaClasse.Size = New System.Drawing.Size(2858, 25)
		Me.TxtRetornaListaClasse.TabIndex = 0
		Me.TxtRetornaListaClasse.WordWrap = False
		'
		'TxtRetornaListaUnidade
		'
		Me.TxtRetornaListaUnidade.AcceptsTab = True
		Me.TxtRetornaListaUnidade.Ativar_CasasDecimais = False
		Me.TxtRetornaListaUnidade.Ativar_so_Letras = False
		Me.TxtRetornaListaUnidade.Ativar_so_Numeros = False
		Me.TxtRetornaListaUnidade.AtivarSoNumeroSemFormatacao_ = False
		Me.TxtRetornaListaUnidade.BorderColor = System.Drawing.Color.DimGray
		Me.TxtRetornaListaUnidade.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.TxtRetornaListaUnidade.DefaultText = ""
		Me.TxtRetornaListaUnidade.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
		Me.TxtRetornaListaUnidade.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
		Me.TxtRetornaListaUnidade.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.TxtRetornaListaUnidade.DisabledState.Parent = Me.TxtRetornaListaUnidade
		Me.TxtRetornaListaUnidade.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.TxtRetornaListaUnidade.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.TxtRetornaListaUnidade.FocusedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.TxtRetornaListaUnidade.FocusedState.Parent = Me.TxtRetornaListaUnidade
		Me.TxtRetornaListaUnidade.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.TxtRetornaListaUnidade.HoverState.Parent = Me.TxtRetornaListaUnidade
		Me.TxtRetornaListaUnidade.Location = New System.Drawing.Point(9, 101)
		Me.TxtRetornaListaUnidade.Margin = New System.Windows.Forms.Padding(68, 92, 68, 92)
		Me.TxtRetornaListaUnidade.Name = "TxtRetornaListaUnidade"
		Me.TxtRetornaListaUnidade.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.TxtRetornaListaUnidade.PlaceholderText = ""
		Me.TxtRetornaListaUnidade.SelectedText = ""
		Me.TxtRetornaListaUnidade.ShadowDecoration.Parent = Me.TxtRetornaListaUnidade
		Me.TxtRetornaListaUnidade.Size = New System.Drawing.Size(2858, 25)
		Me.TxtRetornaListaUnidade.TabIndex = 1
		Me.TxtRetornaListaUnidade.WordWrap = False
		'
		'TxtRetornaListaTecnologia
		'
		Me.TxtRetornaListaTecnologia.AcceptsTab = True
		Me.TxtRetornaListaTecnologia.Ativar_CasasDecimais = False
		Me.TxtRetornaListaTecnologia.Ativar_so_Letras = False
		Me.TxtRetornaListaTecnologia.Ativar_so_Numeros = False
		Me.TxtRetornaListaTecnologia.AtivarSoNumeroSemFormatacao_ = False
		Me.TxtRetornaListaTecnologia.BorderColor = System.Drawing.Color.DimGray
		Me.TxtRetornaListaTecnologia.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.TxtRetornaListaTecnologia.DefaultText = ""
		Me.TxtRetornaListaTecnologia.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
		Me.TxtRetornaListaTecnologia.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
		Me.TxtRetornaListaTecnologia.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.TxtRetornaListaTecnologia.DisabledState.Parent = Me.TxtRetornaListaTecnologia
		Me.TxtRetornaListaTecnologia.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.TxtRetornaListaTecnologia.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.TxtRetornaListaTecnologia.FocusedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.TxtRetornaListaTecnologia.FocusedState.Parent = Me.TxtRetornaListaTecnologia
		Me.TxtRetornaListaTecnologia.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.TxtRetornaListaTecnologia.HoverState.Parent = Me.TxtRetornaListaTecnologia
		Me.TxtRetornaListaTecnologia.Location = New System.Drawing.Point(9, 133)
		Me.TxtRetornaListaTecnologia.Margin = New System.Windows.Forms.Padding(37, 48, 37, 48)
		Me.TxtRetornaListaTecnologia.Name = "TxtRetornaListaTecnologia"
		Me.TxtRetornaListaTecnologia.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.TxtRetornaListaTecnologia.PlaceholderText = ""
		Me.TxtRetornaListaTecnologia.SelectedText = ""
		Me.TxtRetornaListaTecnologia.ShadowDecoration.Parent = Me.TxtRetornaListaTecnologia
		Me.TxtRetornaListaTecnologia.Size = New System.Drawing.Size(2858, 25)
		Me.TxtRetornaListaTecnologia.TabIndex = 2
		Me.TxtRetornaListaTecnologia.WordWrap = False
		'
		'Txt_EmiteCDF
		'
		Me.Txt_EmiteCDF.AcceptsTab = True
		Me.Txt_EmiteCDF.Ativar_CasasDecimais = False
		Me.Txt_EmiteCDF.Ativar_so_Letras = False
		Me.Txt_EmiteCDF.Ativar_so_Numeros = False
		Me.Txt_EmiteCDF.AtivarSoNumeroSemFormatacao_ = False
		Me.Txt_EmiteCDF.BorderColor = System.Drawing.Color.DimGray
		Me.Txt_EmiteCDF.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.Txt_EmiteCDF.DefaultText = ""
		Me.Txt_EmiteCDF.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
		Me.Txt_EmiteCDF.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
		Me.Txt_EmiteCDF.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.Txt_EmiteCDF.DisabledState.Parent = Me.Txt_EmiteCDF
		Me.Txt_EmiteCDF.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.Txt_EmiteCDF.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.Txt_EmiteCDF.FocusedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.Txt_EmiteCDF.FocusedState.Parent = Me.Txt_EmiteCDF
		Me.Txt_EmiteCDF.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.Txt_EmiteCDF.HoverState.Parent = Me.Txt_EmiteCDF
		Me.Txt_EmiteCDF.Location = New System.Drawing.Point(9, 356)
		Me.Txt_EmiteCDF.Margin = New System.Windows.Forms.Padding(125, 177, 125, 177)
		Me.Txt_EmiteCDF.Name = "Txt_EmiteCDF"
		Me.Txt_EmiteCDF.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.Txt_EmiteCDF.PlaceholderText = ""
		Me.Txt_EmiteCDF.SelectedText = ""
		Me.Txt_EmiteCDF.ShadowDecoration.Parent = Me.Txt_EmiteCDF
		Me.Txt_EmiteCDF.Size = New System.Drawing.Size(2858, 25)
		Me.Txt_EmiteCDF.TabIndex = 9
		Me.Txt_EmiteCDF.WordWrap = False
		'
		'Txt_RetornaListaCodigoBarasManifesto
		'
		Me.Txt_RetornaListaCodigoBarasManifesto.AcceptsTab = True
		Me.Txt_RetornaListaCodigoBarasManifesto.Ativar_CasasDecimais = False
		Me.Txt_RetornaListaCodigoBarasManifesto.Ativar_so_Letras = False
		Me.Txt_RetornaListaCodigoBarasManifesto.Ativar_so_Numeros = False
		Me.Txt_RetornaListaCodigoBarasManifesto.AtivarSoNumeroSemFormatacao_ = False
		Me.Txt_RetornaListaCodigoBarasManifesto.BorderColor = System.Drawing.Color.DimGray
		Me.Txt_RetornaListaCodigoBarasManifesto.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.Txt_RetornaListaCodigoBarasManifesto.DefaultText = ""
		Me.Txt_RetornaListaCodigoBarasManifesto.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
		Me.Txt_RetornaListaCodigoBarasManifesto.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
		Me.Txt_RetornaListaCodigoBarasManifesto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.Txt_RetornaListaCodigoBarasManifesto.DisabledState.Parent = Me.Txt_RetornaListaCodigoBarasManifesto
		Me.Txt_RetornaListaCodigoBarasManifesto.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.Txt_RetornaListaCodigoBarasManifesto.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.Txt_RetornaListaCodigoBarasManifesto.FocusedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.Txt_RetornaListaCodigoBarasManifesto.FocusedState.Parent = Me.Txt_RetornaListaCodigoBarasManifesto
		Me.Txt_RetornaListaCodigoBarasManifesto.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.Txt_RetornaListaCodigoBarasManifesto.HoverState.Parent = Me.Txt_RetornaListaCodigoBarasManifesto
		Me.Txt_RetornaListaCodigoBarasManifesto.Location = New System.Drawing.Point(9, 566)
		Me.Txt_RetornaListaCodigoBarasManifesto.Margin = New System.Windows.Forms.Padding(770, 1258, 770, 1258)
		Me.Txt_RetornaListaCodigoBarasManifesto.Name = "Txt_RetornaListaCodigoBarasManifesto"
		Me.Txt_RetornaListaCodigoBarasManifesto.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.Txt_RetornaListaCodigoBarasManifesto.PlaceholderText = ""
		Me.Txt_RetornaListaCodigoBarasManifesto.SelectedText = ""
		Me.Txt_RetornaListaCodigoBarasManifesto.ShadowDecoration.Parent = Me.Txt_RetornaListaCodigoBarasManifesto
		Me.Txt_RetornaListaCodigoBarasManifesto.Size = New System.Drawing.Size(2858, 25)
		Me.Txt_RetornaListaCodigoBarasManifesto.TabIndex = 15
		Me.Txt_RetornaListaCodigoBarasManifesto.WordWrap = False
		'
		'Txt_CancelarManifesto
		'
		Me.Txt_CancelarManifesto.AcceptsTab = True
		Me.Txt_CancelarManifesto.Ativar_CasasDecimais = False
		Me.Txt_CancelarManifesto.Ativar_so_Letras = False
		Me.Txt_CancelarManifesto.Ativar_so_Numeros = False
		Me.Txt_CancelarManifesto.AtivarSoNumeroSemFormatacao_ = False
		Me.Txt_CancelarManifesto.BorderColor = System.Drawing.Color.DimGray
		Me.Txt_CancelarManifesto.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.Txt_CancelarManifesto.DefaultText = ""
		Me.Txt_CancelarManifesto.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
		Me.Txt_CancelarManifesto.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
		Me.Txt_CancelarManifesto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.Txt_CancelarManifesto.DisabledState.Parent = Me.Txt_CancelarManifesto
		Me.Txt_CancelarManifesto.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.Txt_CancelarManifesto.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.Txt_CancelarManifesto.FocusedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.Txt_CancelarManifesto.FocusedState.Parent = Me.Txt_CancelarManifesto
		Me.Txt_CancelarManifesto.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.Txt_CancelarManifesto.HoverState.Parent = Me.Txt_CancelarManifesto
		Me.Txt_CancelarManifesto.Location = New System.Drawing.Point(9, 496)
		Me.Txt_CancelarManifesto.Margin = New System.Windows.Forms.Padding(420, 654, 420, 654)
		Me.Txt_CancelarManifesto.Name = "Txt_CancelarManifesto"
		Me.Txt_CancelarManifesto.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.Txt_CancelarManifesto.PlaceholderText = ""
		Me.Txt_CancelarManifesto.SelectedText = ""
		Me.Txt_CancelarManifesto.ShadowDecoration.Parent = Me.Txt_CancelarManifesto
		Me.Txt_CancelarManifesto.Size = New System.Drawing.Size(2858, 25)
		Me.Txt_CancelarManifesto.TabIndex = 13
		Me.Txt_CancelarManifesto.WordWrap = False
		'
		'Txt_AceiteAlteracaoRecebimento
		'
		Me.Txt_AceiteAlteracaoRecebimento.AcceptsTab = True
		Me.Txt_AceiteAlteracaoRecebimento.Ativar_CasasDecimais = False
		Me.Txt_AceiteAlteracaoRecebimento.Ativar_so_Letras = False
		Me.Txt_AceiteAlteracaoRecebimento.Ativar_so_Numeros = False
		Me.Txt_AceiteAlteracaoRecebimento.AtivarSoNumeroSemFormatacao_ = False
		Me.Txt_AceiteAlteracaoRecebimento.BorderColor = System.Drawing.Color.DimGray
		Me.Txt_AceiteAlteracaoRecebimento.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.Txt_AceiteAlteracaoRecebimento.DefaultText = ""
		Me.Txt_AceiteAlteracaoRecebimento.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
		Me.Txt_AceiteAlteracaoRecebimento.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
		Me.Txt_AceiteAlteracaoRecebimento.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.Txt_AceiteAlteracaoRecebimento.DisabledState.Parent = Me.Txt_AceiteAlteracaoRecebimento
		Me.Txt_AceiteAlteracaoRecebimento.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.Txt_AceiteAlteracaoRecebimento.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.Txt_AceiteAlteracaoRecebimento.FocusedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.Txt_AceiteAlteracaoRecebimento.FocusedState.Parent = Me.Txt_AceiteAlteracaoRecebimento
		Me.Txt_AceiteAlteracaoRecebimento.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.Txt_AceiteAlteracaoRecebimento.HoverState.Parent = Me.Txt_AceiteAlteracaoRecebimento
		Me.Txt_AceiteAlteracaoRecebimento.Location = New System.Drawing.Point(9, 460)
		Me.Txt_AceiteAlteracaoRecebimento.Margin = New System.Windows.Forms.Padding(229, 340, 229, 340)
		Me.Txt_AceiteAlteracaoRecebimento.Name = "Txt_AceiteAlteracaoRecebimento"
		Me.Txt_AceiteAlteracaoRecebimento.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.Txt_AceiteAlteracaoRecebimento.PlaceholderText = ""
		Me.Txt_AceiteAlteracaoRecebimento.SelectedText = ""
		Me.Txt_AceiteAlteracaoRecebimento.ShadowDecoration.Parent = Me.Txt_AceiteAlteracaoRecebimento
		Me.Txt_AceiteAlteracaoRecebimento.Size = New System.Drawing.Size(2858, 25)
		Me.Txt_AceiteAlteracaoRecebimento.TabIndex = 12
		Me.Txt_AceiteAlteracaoRecebimento.WordWrap = False
		'
		'Txt_AlteraçãoManifestoRecebido
		'
		Me.Txt_AlteraçãoManifestoRecebido.AcceptsTab = True
		Me.Txt_AlteraçãoManifestoRecebido.Ativar_CasasDecimais = False
		Me.Txt_AlteraçãoManifestoRecebido.Ativar_so_Letras = False
		Me.Txt_AlteraçãoManifestoRecebido.Ativar_so_Numeros = False
		Me.Txt_AlteraçãoManifestoRecebido.AtivarSoNumeroSemFormatacao_ = False
		Me.Txt_AlteraçãoManifestoRecebido.BorderColor = System.Drawing.Color.DimGray
		Me.Txt_AlteraçãoManifestoRecebido.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.Txt_AlteraçãoManifestoRecebido.DefaultText = ""
		Me.Txt_AlteraçãoManifestoRecebido.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
		Me.Txt_AlteraçãoManifestoRecebido.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
		Me.Txt_AlteraçãoManifestoRecebido.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.Txt_AlteraçãoManifestoRecebido.DisabledState.Parent = Me.Txt_AlteraçãoManifestoRecebido
		Me.Txt_AlteraçãoManifestoRecebido.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.Txt_AlteraçãoManifestoRecebido.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.Txt_AlteraçãoManifestoRecebido.FocusedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.Txt_AlteraçãoManifestoRecebido.FocusedState.Parent = Me.Txt_AlteraçãoManifestoRecebido
		Me.Txt_AlteraçãoManifestoRecebido.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.Txt_AlteraçãoManifestoRecebido.HoverState.Parent = Me.Txt_AlteraçãoManifestoRecebido
		Me.Txt_AlteraçãoManifestoRecebido.Location = New System.Drawing.Point(9, 423)
		Me.Txt_AlteraçãoManifestoRecebido.Margin = New System.Windows.Forms.Padding(125, 177, 125, 177)
		Me.Txt_AlteraçãoManifestoRecebido.Name = "Txt_AlteraçãoManifestoRecebido"
		Me.Txt_AlteraçãoManifestoRecebido.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.Txt_AlteraçãoManifestoRecebido.PlaceholderText = ""
		Me.Txt_AlteraçãoManifestoRecebido.SelectedText = ""
		Me.Txt_AlteraçãoManifestoRecebido.ShadowDecoration.Parent = Me.Txt_AlteraçãoManifestoRecebido
		Me.Txt_AlteraçãoManifestoRecebido.Size = New System.Drawing.Size(2858, 25)
		Me.Txt_AlteraçãoManifestoRecebido.TabIndex = 11
		Me.Txt_AlteraçãoManifestoRecebido.WordWrap = False
		'
		'Txt_ReceberManifestoLote
		'
		Me.Txt_ReceberManifestoLote.AcceptsTab = True
		Me.Txt_ReceberManifestoLote.Ativar_CasasDecimais = False
		Me.Txt_ReceberManifestoLote.Ativar_so_Letras = False
		Me.Txt_ReceberManifestoLote.Ativar_so_Numeros = False
		Me.Txt_ReceberManifestoLote.AtivarSoNumeroSemFormatacao_ = False
		Me.Txt_ReceberManifestoLote.BorderColor = System.Drawing.Color.DimGray
		Me.Txt_ReceberManifestoLote.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.Txt_ReceberManifestoLote.DefaultText = ""
		Me.Txt_ReceberManifestoLote.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
		Me.Txt_ReceberManifestoLote.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
		Me.Txt_ReceberManifestoLote.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.Txt_ReceberManifestoLote.DisabledState.Parent = Me.Txt_ReceberManifestoLote
		Me.Txt_ReceberManifestoLote.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.Txt_ReceberManifestoLote.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.Txt_ReceberManifestoLote.FocusedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.Txt_ReceberManifestoLote.FocusedState.Parent = Me.Txt_ReceberManifestoLote
		Me.Txt_ReceberManifestoLote.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.Txt_ReceberManifestoLote.HoverState.Parent = Me.Txt_ReceberManifestoLote
		Me.Txt_ReceberManifestoLote.Location = New System.Drawing.Point(9, 390)
		Me.Txt_ReceberManifestoLote.Margin = New System.Windows.Forms.Padding(68, 92, 68, 92)
		Me.Txt_ReceberManifestoLote.Name = "Txt_ReceberManifestoLote"
		Me.Txt_ReceberManifestoLote.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.Txt_ReceberManifestoLote.PlaceholderText = ""
		Me.Txt_ReceberManifestoLote.SelectedText = ""
		Me.Txt_ReceberManifestoLote.ShadowDecoration.Parent = Me.Txt_ReceberManifestoLote
		Me.Txt_ReceberManifestoLote.Size = New System.Drawing.Size(2858, 25)
		Me.Txt_ReceberManifestoLote.TabIndex = 10
		Me.Txt_ReceberManifestoLote.WordWrap = False
		'
		'Txt_retornaListaEstadoFisico
		'
		Me.Txt_retornaListaEstadoFisico.AcceptsTab = True
		Me.Txt_retornaListaEstadoFisico.Ativar_CasasDecimais = False
		Me.Txt_retornaListaEstadoFisico.Ativar_so_Letras = False
		Me.Txt_retornaListaEstadoFisico.Ativar_so_Numeros = False
		Me.Txt_retornaListaEstadoFisico.AtivarSoNumeroSemFormatacao_ = False
		Me.Txt_retornaListaEstadoFisico.BorderColor = System.Drawing.Color.DimGray
		Me.Txt_retornaListaEstadoFisico.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.Txt_retornaListaEstadoFisico.DefaultText = ""
		Me.Txt_retornaListaEstadoFisico.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
		Me.Txt_retornaListaEstadoFisico.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
		Me.Txt_retornaListaEstadoFisico.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.Txt_retornaListaEstadoFisico.DisabledState.Parent = Me.Txt_retornaListaEstadoFisico
		Me.Txt_retornaListaEstadoFisico.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.Txt_retornaListaEstadoFisico.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.Txt_retornaListaEstadoFisico.FocusedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.Txt_retornaListaEstadoFisico.FocusedState.Parent = Me.Txt_retornaListaEstadoFisico
		Me.Txt_retornaListaEstadoFisico.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.Txt_retornaListaEstadoFisico.HoverState.Parent = Me.Txt_retornaListaEstadoFisico
		Me.Txt_retornaListaEstadoFisico.Location = New System.Drawing.Point(9, 165)
		Me.Txt_retornaListaEstadoFisico.Margin = New System.Windows.Forms.Padding(37, 48, 37, 48)
		Me.Txt_retornaListaEstadoFisico.Name = "Txt_retornaListaEstadoFisico"
		Me.Txt_retornaListaEstadoFisico.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.Txt_retornaListaEstadoFisico.PlaceholderText = ""
		Me.Txt_retornaListaEstadoFisico.SelectedText = ""
		Me.Txt_retornaListaEstadoFisico.ShadowDecoration.Parent = Me.Txt_retornaListaEstadoFisico
		Me.Txt_retornaListaEstadoFisico.Size = New System.Drawing.Size(2858, 25)
		Me.Txt_retornaListaEstadoFisico.TabIndex = 3
		Me.Txt_retornaListaEstadoFisico.WordWrap = False
		'
		'Txt_RetornaManifesto
		'
		Me.Txt_RetornaManifesto.AcceptsTab = True
		Me.Txt_RetornaManifesto.Ativar_CasasDecimais = False
		Me.Txt_RetornaManifesto.Ativar_so_Letras = False
		Me.Txt_RetornaManifesto.Ativar_so_Numeros = False
		Me.Txt_RetornaManifesto.AtivarSoNumeroSemFormatacao_ = False
		Me.Txt_RetornaManifesto.BorderColor = System.Drawing.Color.DimGray
		Me.Txt_RetornaManifesto.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.Txt_RetornaManifesto.DefaultText = ""
		Me.Txt_RetornaManifesto.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
		Me.Txt_RetornaManifesto.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
		Me.Txt_RetornaManifesto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.Txt_RetornaManifesto.DisabledState.Parent = Me.Txt_RetornaManifesto
		Me.Txt_RetornaManifesto.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.Txt_RetornaManifesto.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.Txt_RetornaManifesto.FocusedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.Txt_RetornaManifesto.FocusedState.Parent = Me.Txt_RetornaManifesto
		Me.Txt_RetornaManifesto.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.Txt_RetornaManifesto.HoverState.Parent = Me.Txt_RetornaManifesto
		Me.Txt_RetornaManifesto.Location = New System.Drawing.Point(9, 533)
		Me.Txt_RetornaManifesto.Margin = New System.Windows.Forms.Padding(20, 25, 20, 25)
		Me.Txt_RetornaManifesto.Name = "Txt_RetornaManifesto"
		Me.Txt_RetornaManifesto.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.Txt_RetornaManifesto.PlaceholderText = ""
		Me.Txt_RetornaManifesto.SelectedText = ""
		Me.Txt_RetornaManifesto.ShadowDecoration.Parent = Me.Txt_RetornaManifesto
		Me.Txt_RetornaManifesto.Size = New System.Drawing.Size(2858, 25)
		Me.Txt_RetornaManifesto.TabIndex = 14
		Me.Txt_RetornaManifesto.WordWrap = False
		'
		'Txt_api_gettoken
		'
		Me.Txt_api_gettoken.AcceptsTab = True
		Me.Txt_api_gettoken.Ativar_CasasDecimais = False
		Me.Txt_api_gettoken.Ativar_so_Letras = False
		Me.Txt_api_gettoken.Ativar_so_Numeros = False
		Me.Txt_api_gettoken.AtivarSoNumeroSemFormatacao_ = False
		Me.Txt_api_gettoken.BorderColor = System.Drawing.Color.DimGray
		Me.Txt_api_gettoken.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.Txt_api_gettoken.DefaultText = ""
		Me.Txt_api_gettoken.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
		Me.Txt_api_gettoken.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
		Me.Txt_api_gettoken.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.Txt_api_gettoken.DisabledState.Parent = Me.Txt_api_gettoken
		Me.Txt_api_gettoken.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.Txt_api_gettoken.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.Txt_api_gettoken.FocusedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.Txt_api_gettoken.FocusedState.Parent = Me.Txt_api_gettoken
		Me.Txt_api_gettoken.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.Txt_api_gettoken.HoverState.Parent = Me.Txt_api_gettoken
		Me.Txt_api_gettoken.Location = New System.Drawing.Point(9, 38)
		Me.Txt_api_gettoken.Margin = New System.Windows.Forms.Padding(11, 13, 11, 13)
		Me.Txt_api_gettoken.Name = "Txt_api_gettoken"
		Me.Txt_api_gettoken.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.Txt_api_gettoken.PlaceholderText = ""
		Me.Txt_api_gettoken.SelectedText = ""
		Me.Txt_api_gettoken.ShadowDecoration.Parent = Me.Txt_api_gettoken
		Me.Txt_api_gettoken.Size = New System.Drawing.Size(2858, 25)
		Me.Txt_api_gettoken.TabIndex = 0
		Me.Txt_api_gettoken.WordWrap = False
		'
		'GBPessoaFisica
		'
		Me.GBPessoaFisica.Controls.Add(Me.Label4)
		Me.GBPessoaFisica.Controls.Add(Me.Label3)
		Me.GBPessoaFisica.Controls.Add(Me.Label2)
		Me.GBPessoaFisica.Controls.Add(Me.Label1)
		Me.GBPessoaFisica.Controls.Add(Me.TxtSenhaAcesso)
		Me.GBPessoaFisica.Controls.Add(Me.Txt_Id_CPF_Usuario)
		Me.GBPessoaFisica.Controls.Add(Me.TxtCodigoUnidadePF)
		Me.GBPessoaFisica.Controls.Add(Me.TXT_CNPJ_pessoa_fisica)
		Me.GBPessoaFisica.ForeColor = System.Drawing.Color.DodgerBlue
		Me.GBPessoaFisica.Location = New System.Drawing.Point(11, 95)
		Me.GBPessoaFisica.Margin = New System.Windows.Forms.Padding(4)
		Me.GBPessoaFisica.Name = "GBPessoaFisica"
		Me.GBPessoaFisica.Padding = New System.Windows.Forms.Padding(4)
		Me.GBPessoaFisica.Size = New System.Drawing.Size(194, 246)
		Me.GBPessoaFisica.TabIndex = 0
		Me.GBPessoaFisica.TabStop = False
		Me.GBPessoaFisica.Text = "PessoaFisica"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.ForeColor = System.Drawing.Color.DimGray
		Me.Label4.Location = New System.Drawing.Point(7, 186)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(107, 17)
		Me.Label4.TabIndex = 8
		Me.Label4.Text = "Senha de Acesso"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.ForeColor = System.Drawing.Color.DimGray
		Me.Label3.Location = New System.Drawing.Point(7, 131)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(97, 17)
		Me.Label3.TabIndex = 7
		Me.Label3.Text = "CPF de Usuario"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.ForeColor = System.Drawing.Color.DimGray
		Me.Label2.Location = New System.Drawing.Point(7, 76)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(54, 17)
		Me.Label2.TabIndex = 6
		Me.Label2.Text = "Seu CPF"
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.ForeColor = System.Drawing.Color.DimGray
		Me.Label1.Location = New System.Drawing.Point(7, 22)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(123, 17)
		Me.Label1.TabIndex = 5
		Me.Label1.Text = "Codigo da Unidade"
		'
		'TxtSenhaAcesso
		'
		Me.TxtSenhaAcesso.Ativar_CasasDecimais = False
		Me.TxtSenhaAcesso.Ativar_so_Letras = False
		Me.TxtSenhaAcesso.Ativar_so_Numeros = False
		Me.TxtSenhaAcesso.AtivarSoNumeroSemFormatacao_ = False
		Me.TxtSenhaAcesso.BorderColor = System.Drawing.Color.Silver
		Me.TxtSenhaAcesso.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.TxtSenhaAcesso.DefaultText = ""
		Me.TxtSenhaAcesso.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
		Me.TxtSenhaAcesso.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
		Me.TxtSenhaAcesso.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.TxtSenhaAcesso.DisabledState.Parent = Me.TxtSenhaAcesso
		Me.TxtSenhaAcesso.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.TxtSenhaAcesso.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.TxtSenhaAcesso.FocusedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.TxtSenhaAcesso.FocusedState.Parent = Me.TxtSenhaAcesso
		Me.TxtSenhaAcesso.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.TxtSenhaAcesso.HoverState.Parent = Me.TxtSenhaAcesso
		Me.TxtSenhaAcesso.Location = New System.Drawing.Point(7, 204)
		Me.TxtSenhaAcesso.Margin = New System.Windows.Forms.Padding(3, 7, 3, 7)
		Me.TxtSenhaAcesso.Name = "TxtSenhaAcesso"
		Me.TxtSenhaAcesso.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.TxtSenhaAcesso.PlaceholderText = "SENHA DE ACESSO"
		Me.TxtSenhaAcesso.SelectedText = ""
		Me.TxtSenhaAcesso.ShadowDecoration.Parent = Me.TxtSenhaAcesso
		Me.TxtSenhaAcesso.Size = New System.Drawing.Size(179, 31)
		Me.TxtSenhaAcesso.TabIndex = 3
		Me.TxtSenhaAcesso.UseSystemPasswordChar = True
		Me.TxtSenhaAcesso.WordWrap = False
		'
		'Txt_Id_CPF_Usuario
		'
		Me.Txt_Id_CPF_Usuario.Ativar_CasasDecimais = False
		Me.Txt_Id_CPF_Usuario.Ativar_so_Letras = False
		Me.Txt_Id_CPF_Usuario.Ativar_so_Numeros = False
		Me.Txt_Id_CPF_Usuario.AtivarSoNumeroSemFormatacao_ = False
		Me.Txt_Id_CPF_Usuario.BorderColor = System.Drawing.Color.Silver
		Me.Txt_Id_CPF_Usuario.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.Txt_Id_CPF_Usuario.DefaultText = ""
		Me.Txt_Id_CPF_Usuario.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
		Me.Txt_Id_CPF_Usuario.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
		Me.Txt_Id_CPF_Usuario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.Txt_Id_CPF_Usuario.DisabledState.Parent = Me.Txt_Id_CPF_Usuario
		Me.Txt_Id_CPF_Usuario.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.Txt_Id_CPF_Usuario.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.Txt_Id_CPF_Usuario.FocusedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.Txt_Id_CPF_Usuario.FocusedState.Parent = Me.Txt_Id_CPF_Usuario
		Me.Txt_Id_CPF_Usuario.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.Txt_Id_CPF_Usuario.HoverState.Parent = Me.Txt_Id_CPF_Usuario
		Me.Txt_Id_CPF_Usuario.Location = New System.Drawing.Point(8, 149)
		Me.Txt_Id_CPF_Usuario.Margin = New System.Windows.Forms.Padding(3, 7, 3, 7)
		Me.Txt_Id_CPF_Usuario.Name = "Txt_Id_CPF_Usuario"
		Me.Txt_Id_CPF_Usuario.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.Txt_Id_CPF_Usuario.PlaceholderText = "CPF DE USUARIO"
		Me.Txt_Id_CPF_Usuario.SelectedText = ""
		Me.Txt_Id_CPF_Usuario.ShadowDecoration.Parent = Me.Txt_Id_CPF_Usuario
		Me.Txt_Id_CPF_Usuario.Size = New System.Drawing.Size(179, 31)
		Me.Txt_Id_CPF_Usuario.TabIndex = 2
		Me.Txt_Id_CPF_Usuario.WordWrap = False
		'
		'TxtCodigoUnidadePF
		'
		Me.TxtCodigoUnidadePF.Animated = True
		Me.TxtCodigoUnidadePF.Ativar_CasasDecimais = False
		Me.TxtCodigoUnidadePF.Ativar_so_Letras = False
		Me.TxtCodigoUnidadePF.Ativar_so_Numeros = False
		Me.TxtCodigoUnidadePF.AtivarSoNumeroSemFormatacao_ = False
		Me.TxtCodigoUnidadePF.BorderColor = System.Drawing.Color.Silver
		Me.TxtCodigoUnidadePF.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.TxtCodigoUnidadePF.DefaultText = ""
		Me.TxtCodigoUnidadePF.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
		Me.TxtCodigoUnidadePF.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
		Me.TxtCodigoUnidadePF.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.TxtCodigoUnidadePF.DisabledState.Parent = Me.TxtCodigoUnidadePF
		Me.TxtCodigoUnidadePF.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.TxtCodigoUnidadePF.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.TxtCodigoUnidadePF.FocusedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.TxtCodigoUnidadePF.FocusedState.Parent = Me.TxtCodigoUnidadePF
		Me.TxtCodigoUnidadePF.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.TxtCodigoUnidadePF.HoverState.Parent = Me.TxtCodigoUnidadePF
		Me.TxtCodigoUnidadePF.Location = New System.Drawing.Point(8, 40)
		Me.TxtCodigoUnidadePF.Margin = New System.Windows.Forms.Padding(3, 7, 3, 7)
		Me.TxtCodigoUnidadePF.Name = "TxtCodigoUnidadePF"
		Me.TxtCodigoUnidadePF.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.TxtCodigoUnidadePF.PlaceholderText = "CODIGO DA UNIDADE"
		Me.TxtCodigoUnidadePF.SelectedText = ""
		Me.TxtCodigoUnidadePF.ShadowDecoration.Parent = Me.TxtCodigoUnidadePF
		Me.TxtCodigoUnidadePF.Size = New System.Drawing.Size(179, 31)
		Me.TxtCodigoUnidadePF.TabIndex = 0
		Me.TxtCodigoUnidadePF.WordWrap = False
		'
		'TXT_CNPJ_pessoa_fisica
		'
		Me.TXT_CNPJ_pessoa_fisica.Ativar_CasasDecimais = False
		Me.TXT_CNPJ_pessoa_fisica.Ativar_so_Letras = False
		Me.TXT_CNPJ_pessoa_fisica.Ativar_so_Numeros = False
		Me.TXT_CNPJ_pessoa_fisica.AtivarSoNumeroSemFormatacao_ = False
		Me.TXT_CNPJ_pessoa_fisica.BorderColor = System.Drawing.Color.Silver
		Me.TXT_CNPJ_pessoa_fisica.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.TXT_CNPJ_pessoa_fisica.DefaultText = ""
		Me.TXT_CNPJ_pessoa_fisica.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
		Me.TXT_CNPJ_pessoa_fisica.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
		Me.TXT_CNPJ_pessoa_fisica.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.TXT_CNPJ_pessoa_fisica.DisabledState.Parent = Me.TXT_CNPJ_pessoa_fisica
		Me.TXT_CNPJ_pessoa_fisica.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.TXT_CNPJ_pessoa_fisica.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.TXT_CNPJ_pessoa_fisica.FocusedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.TXT_CNPJ_pessoa_fisica.FocusedState.Parent = Me.TXT_CNPJ_pessoa_fisica
		Me.TXT_CNPJ_pessoa_fisica.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.TXT_CNPJ_pessoa_fisica.HoverState.Parent = Me.TXT_CNPJ_pessoa_fisica
		Me.TXT_CNPJ_pessoa_fisica.Location = New System.Drawing.Point(8, 94)
		Me.TXT_CNPJ_pessoa_fisica.Margin = New System.Windows.Forms.Padding(3, 7, 3, 7)
		Me.TXT_CNPJ_pessoa_fisica.Name = "TXT_CNPJ_pessoa_fisica"
		Me.TXT_CNPJ_pessoa_fisica.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.TXT_CNPJ_pessoa_fisica.PlaceholderText = "SEU CPF"
		Me.TXT_CNPJ_pessoa_fisica.SelectedText = ""
		Me.TXT_CNPJ_pessoa_fisica.ShadowDecoration.Parent = Me.TXT_CNPJ_pessoa_fisica
		Me.TXT_CNPJ_pessoa_fisica.Size = New System.Drawing.Size(179, 31)
		Me.TXT_CNPJ_pessoa_fisica.TabIndex = 1
		Me.TXT_CNPJ_pessoa_fisica.WordWrap = False
		'
		'BtRegistrarAlteracoes
		'
		Me.BtRegistrarAlteracoes.BackColor = System.Drawing.SystemColors.ControlLightLight
		Me.BtRegistrarAlteracoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.BtRegistrarAlteracoes.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.BtRegistrarAlteracoes.ForeColor = System.Drawing.Color.DodgerBlue
		Me.BtRegistrarAlteracoes.Location = New System.Drawing.Point(133, 559)
		Me.BtRegistrarAlteracoes.Margin = New System.Windows.Forms.Padding(4)
		Me.BtRegistrarAlteracoes.Name = "BtRegistrarAlteracoes"
		Me.BtRegistrarAlteracoes.Size = New System.Drawing.Size(153, 33)
		Me.BtRegistrarAlteracoes.TabIndex = 4
		Me.BtRegistrarAlteracoes.Text = "Registrar Alterações"
		Me.BtRegistrarAlteracoes.UseVisualStyleBackColor = False
		'
		'GBPessoaJuridica
		'
		Me.GBPessoaJuridica.Controls.Add(Me.Label8)
		Me.GBPessoaJuridica.Controls.Add(Me.Label7)
		Me.GBPessoaJuridica.Controls.Add(Me.Label6)
		Me.GBPessoaJuridica.Controls.Add(Me.Label5)
		Me.GBPessoaJuridica.Controls.Add(Me.TxtSenhaAcessoPJ)
		Me.GBPessoaJuridica.Controls.Add(Me.TXT_CNPJ_pessoa_Juridica)
		Me.GBPessoaJuridica.Controls.Add(Me.TxtCodigoUnidadePJ)
		Me.GBPessoaJuridica.Controls.Add(Me.TxtIdCPFusuarioPJ)
		Me.GBPessoaJuridica.ForeColor = System.Drawing.Color.DodgerBlue
		Me.GBPessoaJuridica.Location = New System.Drawing.Point(211, 95)
		Me.GBPessoaJuridica.Margin = New System.Windows.Forms.Padding(4)
		Me.GBPessoaJuridica.Name = "GBPessoaJuridica"
		Me.GBPessoaJuridica.Padding = New System.Windows.Forms.Padding(4)
		Me.GBPessoaJuridica.Size = New System.Drawing.Size(208, 246)
		Me.GBPessoaJuridica.TabIndex = 1
		Me.GBPessoaJuridica.TabStop = False
		Me.GBPessoaJuridica.Text = "Pessoa Juridica"
		'
		'Label8
		'
		Me.Label8.AutoSize = True
		Me.Label8.ForeColor = System.Drawing.Color.DimGray
		Me.Label8.Location = New System.Drawing.Point(7, 22)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(123, 17)
		Me.Label8.TabIndex = 12
		Me.Label8.Text = "Codigo da Unidade"
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.ForeColor = System.Drawing.Color.DimGray
		Me.Label7.Location = New System.Drawing.Point(7, 76)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(54, 17)
		Me.Label7.TabIndex = 11
		Me.Label7.Text = "Seu CPF"
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.ForeColor = System.Drawing.Color.DimGray
		Me.Label6.Location = New System.Drawing.Point(3, 131)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(97, 17)
		Me.Label6.TabIndex = 10
		Me.Label6.Text = "CPF de Usuario"
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.ForeColor = System.Drawing.Color.DimGray
		Me.Label5.Location = New System.Drawing.Point(5, 186)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(107, 17)
		Me.Label5.TabIndex = 9
		Me.Label5.Text = "Senha de Acesso"
		'
		'TxtSenhaAcessoPJ
		'
		Me.TxtSenhaAcessoPJ.Ativar_CasasDecimais = False
		Me.TxtSenhaAcessoPJ.Ativar_so_Letras = False
		Me.TxtSenhaAcessoPJ.Ativar_so_Numeros = False
		Me.TxtSenhaAcessoPJ.AtivarSoNumeroSemFormatacao_ = False
		Me.TxtSenhaAcessoPJ.BorderColor = System.Drawing.Color.Silver
		Me.TxtSenhaAcessoPJ.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.TxtSenhaAcessoPJ.DefaultText = ""
		Me.TxtSenhaAcessoPJ.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
		Me.TxtSenhaAcessoPJ.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
		Me.TxtSenhaAcessoPJ.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.TxtSenhaAcessoPJ.DisabledState.Parent = Me.TxtSenhaAcessoPJ
		Me.TxtSenhaAcessoPJ.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.TxtSenhaAcessoPJ.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.TxtSenhaAcessoPJ.FocusedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.TxtSenhaAcessoPJ.FocusedState.Parent = Me.TxtSenhaAcessoPJ
		Me.TxtSenhaAcessoPJ.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.TxtSenhaAcessoPJ.HoverState.Parent = Me.TxtSenhaAcessoPJ
		Me.TxtSenhaAcessoPJ.Location = New System.Drawing.Point(6, 204)
		Me.TxtSenhaAcessoPJ.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
		Me.TxtSenhaAcessoPJ.Name = "TxtSenhaAcessoPJ"
		Me.TxtSenhaAcessoPJ.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.TxtSenhaAcessoPJ.PlaceholderText = "SENHA DE ACESSO"
		Me.TxtSenhaAcessoPJ.SelectedText = ""
		Me.TxtSenhaAcessoPJ.ShadowDecoration.Parent = Me.TxtSenhaAcessoPJ
		Me.TxtSenhaAcessoPJ.Size = New System.Drawing.Size(192, 31)
		Me.TxtSenhaAcessoPJ.TabIndex = 3
		Me.TxtSenhaAcessoPJ.UseSystemPasswordChar = True
		Me.TxtSenhaAcessoPJ.WordWrap = False
		'
		'TXT_CNPJ_pessoa_Juridica
		'
		Me.TXT_CNPJ_pessoa_Juridica.Ativar_CasasDecimais = False
		Me.TXT_CNPJ_pessoa_Juridica.Ativar_so_Letras = False
		Me.TXT_CNPJ_pessoa_Juridica.Ativar_so_Numeros = False
		Me.TXT_CNPJ_pessoa_Juridica.AtivarSoNumeroSemFormatacao_ = False
		Me.TXT_CNPJ_pessoa_Juridica.BorderColor = System.Drawing.Color.Silver
		Me.TXT_CNPJ_pessoa_Juridica.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.TXT_CNPJ_pessoa_Juridica.DefaultText = ""
		Me.TXT_CNPJ_pessoa_Juridica.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
		Me.TXT_CNPJ_pessoa_Juridica.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
		Me.TXT_CNPJ_pessoa_Juridica.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.TXT_CNPJ_pessoa_Juridica.DisabledState.Parent = Me.TXT_CNPJ_pessoa_Juridica
		Me.TXT_CNPJ_pessoa_Juridica.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.TXT_CNPJ_pessoa_Juridica.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.TXT_CNPJ_pessoa_Juridica.FocusedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.TXT_CNPJ_pessoa_Juridica.FocusedState.Parent = Me.TXT_CNPJ_pessoa_Juridica
		Me.TXT_CNPJ_pessoa_Juridica.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.TXT_CNPJ_pessoa_Juridica.HoverState.Parent = Me.TXT_CNPJ_pessoa_Juridica
		Me.TXT_CNPJ_pessoa_Juridica.Location = New System.Drawing.Point(6, 94)
		Me.TXT_CNPJ_pessoa_Juridica.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
		Me.TXT_CNPJ_pessoa_Juridica.Name = "TXT_CNPJ_pessoa_Juridica"
		Me.TXT_CNPJ_pessoa_Juridica.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.TXT_CNPJ_pessoa_Juridica.PlaceholderText = "SEU CNPJ"
		Me.TXT_CNPJ_pessoa_Juridica.SelectedText = ""
		Me.TXT_CNPJ_pessoa_Juridica.ShadowDecoration.Parent = Me.TXT_CNPJ_pessoa_Juridica
		Me.TXT_CNPJ_pessoa_Juridica.Size = New System.Drawing.Size(192, 31)
		Me.TXT_CNPJ_pessoa_Juridica.TabIndex = 1
		Me.TXT_CNPJ_pessoa_Juridica.WordWrap = False
		'
		'TxtCodigoUnidadePJ
		'
		Me.TxtCodigoUnidadePJ.Ativar_CasasDecimais = False
		Me.TxtCodigoUnidadePJ.Ativar_so_Letras = False
		Me.TxtCodigoUnidadePJ.Ativar_so_Numeros = False
		Me.TxtCodigoUnidadePJ.AtivarSoNumeroSemFormatacao_ = False
		Me.TxtCodigoUnidadePJ.BorderColor = System.Drawing.Color.Silver
		Me.TxtCodigoUnidadePJ.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.TxtCodigoUnidadePJ.DefaultText = ""
		Me.TxtCodigoUnidadePJ.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
		Me.TxtCodigoUnidadePJ.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
		Me.TxtCodigoUnidadePJ.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.TxtCodigoUnidadePJ.DisabledState.Parent = Me.TxtCodigoUnidadePJ
		Me.TxtCodigoUnidadePJ.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.TxtCodigoUnidadePJ.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.TxtCodigoUnidadePJ.FocusedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.TxtCodigoUnidadePJ.FocusedState.Parent = Me.TxtCodigoUnidadePJ
		Me.TxtCodigoUnidadePJ.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.TxtCodigoUnidadePJ.HoverState.Parent = Me.TxtCodigoUnidadePJ
		Me.TxtCodigoUnidadePJ.Location = New System.Drawing.Point(8, 40)
		Me.TxtCodigoUnidadePJ.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
		Me.TxtCodigoUnidadePJ.Name = "TxtCodigoUnidadePJ"
		Me.TxtCodigoUnidadePJ.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.TxtCodigoUnidadePJ.PlaceholderText = "CODIGO DA UNIDADE"
		Me.TxtCodigoUnidadePJ.SelectedText = ""
		Me.TxtCodigoUnidadePJ.ShadowDecoration.Parent = Me.TxtCodigoUnidadePJ
		Me.TxtCodigoUnidadePJ.Size = New System.Drawing.Size(190, 30)
		Me.TxtCodigoUnidadePJ.TabIndex = 0
		Me.TxtCodigoUnidadePJ.WordWrap = False
		'
		'TxtIdCPFusuarioPJ
		'
		Me.TxtIdCPFusuarioPJ.Ativar_CasasDecimais = False
		Me.TxtIdCPFusuarioPJ.Ativar_so_Letras = False
		Me.TxtIdCPFusuarioPJ.Ativar_so_Numeros = False
		Me.TxtIdCPFusuarioPJ.AtivarSoNumeroSemFormatacao_ = False
		Me.TxtIdCPFusuarioPJ.BorderColor = System.Drawing.Color.Silver
		Me.TxtIdCPFusuarioPJ.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.TxtIdCPFusuarioPJ.DefaultText = ""
		Me.TxtIdCPFusuarioPJ.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
		Me.TxtIdCPFusuarioPJ.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
		Me.TxtIdCPFusuarioPJ.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.TxtIdCPFusuarioPJ.DisabledState.Parent = Me.TxtIdCPFusuarioPJ
		Me.TxtIdCPFusuarioPJ.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.TxtIdCPFusuarioPJ.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.TxtIdCPFusuarioPJ.FocusedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.TxtIdCPFusuarioPJ.FocusedState.Parent = Me.TxtIdCPFusuarioPJ
		Me.TxtIdCPFusuarioPJ.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.TxtIdCPFusuarioPJ.HoverState.Parent = Me.TxtIdCPFusuarioPJ
		Me.TxtIdCPFusuarioPJ.Location = New System.Drawing.Point(6, 149)
		Me.TxtIdCPFusuarioPJ.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
		Me.TxtIdCPFusuarioPJ.Name = "TxtIdCPFusuarioPJ"
		Me.TxtIdCPFusuarioPJ.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.TxtIdCPFusuarioPJ.PlaceholderText = "CPF DE USUARIO"
		Me.TxtIdCPFusuarioPJ.SelectedText = ""
		Me.TxtIdCPFusuarioPJ.ShadowDecoration.Parent = Me.TxtIdCPFusuarioPJ
		Me.TxtIdCPFusuarioPJ.Size = New System.Drawing.Size(192, 31)
		Me.TxtIdCPFusuarioPJ.TabIndex = 2
		Me.TxtIdCPFusuarioPJ.WordWrap = False
		'
		'RdbPessoaFisica
		'
		Me.RdbPessoaFisica.AutoSize = True
		Me.RdbPessoaFisica.Font = New System.Drawing.Font("Segoe UI", 10.0!)
		Me.RdbPessoaFisica.ForeColor = System.Drawing.Color.DimGray
		Me.RdbPessoaFisica.Location = New System.Drawing.Point(8, 32)
		Me.RdbPessoaFisica.Margin = New System.Windows.Forms.Padding(4)
		Me.RdbPessoaFisica.Name = "RdbPessoaFisica"
		Me.RdbPessoaFisica.Size = New System.Drawing.Size(139, 23)
		Me.RdbPessoaFisica.TabIndex = 0
		Me.RdbPessoaFisica.TabStop = True
		Me.RdbPessoaFisica.Text = "Ativa Pessoa Física"
		Me.RdbPessoaFisica.UseVisualStyleBackColor = True
		'
		'RdbPessoaJridica
		'
		Me.RdbPessoaJridica.AutoSize = True
		Me.RdbPessoaJridica.Font = New System.Drawing.Font("Segoe UI", 10.0!)
		Me.RdbPessoaJridica.ForeColor = System.Drawing.Color.DimGray
		Me.RdbPessoaJridica.Location = New System.Drawing.Point(152, 32)
		Me.RdbPessoaJridica.Margin = New System.Windows.Forms.Padding(4)
		Me.RdbPessoaJridica.Name = "RdbPessoaJridica"
		Me.RdbPessoaJridica.Size = New System.Drawing.Size(152, 23)
		Me.RdbPessoaJridica.TabIndex = 1
		Me.RdbPessoaJridica.TabStop = True
		Me.RdbPessoaJridica.Text = "Ativa Pessoa Jurídica"
		Me.RdbPessoaJridica.UseVisualStyleBackColor = True
		'
		'GBModalidade
		'
		Me.GBModalidade.Controls.Add(Me.RdbDesativado)
		Me.GBModalidade.Controls.Add(Me.RdbPessoaFisica)
		Me.GBModalidade.Controls.Add(Me.RdbPessoaJridica)
		Me.GBModalidade.Font = New System.Drawing.Font("Segoe UI", 14.0!)
		Me.GBModalidade.ForeColor = System.Drawing.Color.DodgerBlue
		Me.GBModalidade.Location = New System.Drawing.Point(11, 14)
		Me.GBModalidade.Margin = New System.Windows.Forms.Padding(4)
		Me.GBModalidade.Name = "GBModalidade"
		Me.GBModalidade.Padding = New System.Windows.Forms.Padding(4)
		Me.GBModalidade.Size = New System.Drawing.Size(408, 70)
		Me.GBModalidade.TabIndex = 2
		Me.GBModalidade.TabStop = False
		Me.GBModalidade.Text = "Modalidade"
		'
		'RdbDesativado
		'
		Me.RdbDesativado.AutoSize = True
		Me.RdbDesativado.Font = New System.Drawing.Font("Segoe UI", 10.0!)
		Me.RdbDesativado.ForeColor = System.Drawing.Color.DimGray
		Me.RdbDesativado.Location = New System.Drawing.Point(307, 32)
		Me.RdbDesativado.Margin = New System.Windows.Forms.Padding(4)
		Me.RdbDesativado.Name = "RdbDesativado"
		Me.RdbDesativado.Size = New System.Drawing.Size(95, 23)
		Me.RdbDesativado.TabIndex = 2
		Me.RdbDesativado.TabStop = True
		Me.RdbDesativado.Text = "Desativado"
		Me.RdbDesativado.UseVisualStyleBackColor = True
		'
		'GB_CodigoBarras
		'
		Me.GB_CodigoBarras.BackColor = System.Drawing.SystemColors.Control
		Me.GB_CodigoBarras.Controls.Add(Me.RDB_ReceberMtr34Dig)
		Me.GB_CodigoBarras.Controls.Add(Me.RDB_ReceberMtr10Dig)
		Me.GB_CodigoBarras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.GB_CodigoBarras.Font = New System.Drawing.Font("Segoe UI", 12.0!)
		Me.GB_CodigoBarras.ForeColor = System.Drawing.Color.DodgerBlue
		Me.GB_CodigoBarras.Location = New System.Drawing.Point(11, 349)
		Me.GB_CodigoBarras.Margin = New System.Windows.Forms.Padding(4)
		Me.GB_CodigoBarras.Name = "GB_CodigoBarras"
		Me.GB_CodigoBarras.Padding = New System.Windows.Forms.Padding(4)
		Me.GB_CodigoBarras.Size = New System.Drawing.Size(410, 99)
		Me.GB_CodigoBarras.TabIndex = 2
		Me.GB_CodigoBarras.TabStop = False
		Me.GB_CodigoBarras.Text = "Leitor de Código de Barras"
		'
		'RDB_ReceberMtr34Dig
		'
		Me.RDB_ReceberMtr34Dig.AutoSize = True
		Me.RDB_ReceberMtr34Dig.Font = New System.Drawing.Font("Segoe UI", 10.0!)
		Me.RDB_ReceberMtr34Dig.ForeColor = System.Drawing.Color.DimGray
		Me.RDB_ReceberMtr34Dig.Location = New System.Drawing.Point(8, 30)
		Me.RDB_ReceberMtr34Dig.Margin = New System.Windows.Forms.Padding(4)
		Me.RDB_ReceberMtr34Dig.Name = "RDB_ReceberMtr34Dig"
		Me.RDB_ReceberMtr34Dig.Size = New System.Drawing.Size(319, 23)
		Me.RDB_ReceberMtr34Dig.TabIndex = 0
		Me.RDB_ReceberMtr34Dig.TabStop = True
		Me.RDB_ReceberMtr34Dig.Text = "Receber MTR utilizando código de barras 34 dig"
		Me.RDB_ReceberMtr34Dig.UseVisualStyleBackColor = True
		'
		'RDB_ReceberMtr10Dig
		'
		Me.RDB_ReceberMtr10Dig.AutoSize = True
		Me.RDB_ReceberMtr10Dig.Font = New System.Drawing.Font("Segoe UI", 10.0!)
		Me.RDB_ReceberMtr10Dig.ForeColor = System.Drawing.Color.DimGray
		Me.RDB_ReceberMtr10Dig.Location = New System.Drawing.Point(8, 63)
		Me.RDB_ReceberMtr10Dig.Margin = New System.Windows.Forms.Padding(4)
		Me.RDB_ReceberMtr10Dig.Name = "RDB_ReceberMtr10Dig"
		Me.RDB_ReceberMtr10Dig.Size = New System.Drawing.Size(220, 23)
		Me.RDB_ReceberMtr10Dig.TabIndex = 1
		Me.RDB_ReceberMtr10Dig.TabStop = True
		Me.RDB_ReceberMtr10Dig.Text = "Receber MTR por código 10 dig"
		Me.RDB_ReceberMtr10Dig.UseVisualStyleBackColor = True
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.Label12)
		Me.GroupBox1.Controls.Add(Me.txtDestinadorCodigoUnidade)
		Me.GroupBox1.ForeColor = System.Drawing.Color.DodgerBlue
		Me.GroupBox1.Location = New System.Drawing.Point(13, 465)
		Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
		Me.GroupBox1.Size = New System.Drawing.Size(406, 86)
		Me.GroupBox1.TabIndex = 5
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "Destinador"
		'
		'Label12
		'
		Me.Label12.AutoSize = True
		Me.Label12.ForeColor = System.Drawing.Color.DimGray
		Me.Label12.Location = New System.Drawing.Point(138, 22)
		Me.Label12.Name = "Label12"
		Me.Label12.Size = New System.Drawing.Size(121, 17)
		Me.Label12.TabIndex = 5
		Me.Label12.Text = "Codigo da unidade"
		'
		'txtDestinadorCodigoUnidade
		'
		Me.txtDestinadorCodigoUnidade.Ativar_CasasDecimais = False
		Me.txtDestinadorCodigoUnidade.Ativar_so_Letras = False
		Me.txtDestinadorCodigoUnidade.Ativar_so_Numeros = False
		Me.txtDestinadorCodigoUnidade.AtivarSoNumeroSemFormatacao_ = False
		Me.txtDestinadorCodigoUnidade.BorderColor = System.Drawing.Color.Silver
		Me.txtDestinadorCodigoUnidade.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtDestinadorCodigoUnidade.DefaultText = ""
		Me.txtDestinadorCodigoUnidade.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
		Me.txtDestinadorCodigoUnidade.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
		Me.txtDestinadorCodigoUnidade.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.txtDestinadorCodigoUnidade.DisabledState.Parent = Me.txtDestinadorCodigoUnidade
		Me.txtDestinadorCodigoUnidade.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.txtDestinadorCodigoUnidade.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.txtDestinadorCodigoUnidade.FocusedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.txtDestinadorCodigoUnidade.FocusedState.Parent = Me.txtDestinadorCodigoUnidade
		Me.txtDestinadorCodigoUnidade.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.txtDestinadorCodigoUnidade.HoverState.Parent = Me.txtDestinadorCodigoUnidade
		Me.txtDestinadorCodigoUnidade.Location = New System.Drawing.Point(139, 40)
		Me.txtDestinadorCodigoUnidade.Margin = New System.Windows.Forms.Padding(3, 7, 3, 7)
		Me.txtDestinadorCodigoUnidade.Name = "txtDestinadorCodigoUnidade"
		Me.txtDestinadorCodigoUnidade.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.txtDestinadorCodigoUnidade.PlaceholderText = "CODIGO DA UNIDADE"
		Me.txtDestinadorCodigoUnidade.SelectedText = ""
		Me.txtDestinadorCodigoUnidade.ShadowDecoration.Parent = Me.txtDestinadorCodigoUnidade
		Me.txtDestinadorCodigoUnidade.Size = New System.Drawing.Size(120, 31)
		Me.txtDestinadorCodigoUnidade.TabIndex = 0
		Me.txtDestinadorCodigoUnidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.txtDestinadorCodigoUnidade.WordWrap = False
		'
		'FRMConfiguracaoFeam
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(977, 619)
		Me.Controls.Add(Me.GroupBox1)
		Me.Controls.Add(Me.BtRegistrarAlteracoes)
		Me.Controls.Add(Me.GB_CodigoBarras)
		Me.Controls.Add(GB_RequisicaoFeam)
		Me.Controls.Add(Me.GBModalidade)
		Me.Controls.Add(Me.GBPessoaJuridica)
		Me.Controls.Add(Me.GBPessoaFisica)
		Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Margin = New System.Windows.Forms.Padding(4)
		Me.MaximizeBox = False
		Me.Name = "FRMConfiguracaoFeam"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Configuracao Feam"
		GB_RequisicaoFeam.ResumeLayout(False)
		CType(Me.PBbloquear, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PBDesbloquear, System.ComponentModel.ISupportInitialize).EndInit()
		Me.GBPessoaFisica.ResumeLayout(False)
		Me.GBPessoaFisica.PerformLayout()
		Me.GBPessoaJuridica.ResumeLayout(False)
		Me.GBPessoaJuridica.PerformLayout()
		Me.GBModalidade.ResumeLayout(False)
		Me.GBModalidade.PerformLayout()
		Me.GB_CodigoBarras.ResumeLayout(False)
		Me.GB_CodigoBarras.PerformLayout()
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents TXT_CNPJ_pessoa_fisica As TextboxMonetário
	Friend WithEvents GBPessoaFisica As GroupBox
	Friend WithEvents BtRegistrarAlteracoes As Button
	Friend WithEvents TxtSenhaAcesso As TextboxMonetário
	Friend WithEvents Txt_Id_CPF_Usuario As TextboxMonetário
	Friend WithEvents TxtCodigoUnidadePF As TextboxMonetário
	Friend WithEvents GBPessoaJuridica As GroupBox
	Friend WithEvents TxtSenhaAcessoPJ As TextboxMonetário
	Friend WithEvents TXT_CNPJ_pessoa_Juridica As TextboxMonetário
	Friend WithEvents TxtIdCPFusuarioPJ As TextboxMonetário
	Friend WithEvents RdbPessoaFisica As RadioButton
	Friend WithEvents RdbPessoaJridica As RadioButton
	Friend WithEvents GBModalidade As GroupBox
	Friend WithEvents RdbDesativado As RadioButton
	Friend WithEvents TxtCodigoUnidadePJ As TextboxMonetário
	Friend WithEvents GB_CodigoBarras As GroupBox
	Friend WithEvents RDB_ReceberMtr34Dig As RadioButton
	Friend WithEvents RDB_ReceberMtr10Dig As RadioButton
	Friend WithEvents Txt_api_gettoken As TextboxMonetário
	Friend WithEvents TxtRetornaListaTecnologia As TextboxMonetário
	Friend WithEvents Txt_RetornaManifesto As TextboxMonetário
	Friend WithEvents Txt_RetornaListaResiduo As TextboxMonetário
	Friend WithEvents TxtRetornaListaAcondicionamento As TextboxMonetário
	Friend WithEvents TxtRetornaListaClasse As TextboxMonetário
	Friend WithEvents TxtRetornaListaUnidade As TextboxMonetário
	Friend WithEvents Txt_DonwloadCDF As TextboxMonetário
	Friend WithEvents Txt_Donwload_PDF_Manifesto As TextboxMonetário
	Friend WithEvents Txt_ReceberManifestoLote As TextboxMonetário
	Friend WithEvents Txt_retornaListaEstadoFisico As TextboxMonetário
	Friend WithEvents Txt_SalvarManifestoLote As TextboxMonetário
	Friend WithEvents Txt_EmiteCDF As TextboxMonetário
	Friend WithEvents Txt_RetornaListaCodigoBarasManifesto As TextboxMonetário
	Friend WithEvents Txt_CancelarManifesto As TextboxMonetário
	Friend WithEvents Txt_AceiteAlteracaoRecebimento As TextboxMonetário
	Friend WithEvents Txt_AlteraçãoManifestoRecebido As TextboxMonetário
	Friend WithEvents Label4 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents Label1 As Label
	Friend WithEvents Label8 As Label
	Friend WithEvents Label7 As Label
	Friend WithEvents Label6 As Label
	Friend WithEvents Label5 As Label
	Friend WithEvents PBDesbloquear As PictureBox
	Friend WithEvents PBbloquear As PictureBox
	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents Label12 As Label
	Friend WithEvents txtDestinadorCodigoUnidade As TextboxMonetário
End Class
