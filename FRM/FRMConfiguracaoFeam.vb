Imports System.IO
Imports Newtonsoft.Json
Imports Principal.Configuracao
Public Class FRMConfiguracaoFeam

#Region "Comentario"
   '{
   '"pessoaCodigo": 96942,
   '   "pessoaCnpj":"07893348607",
   '   "usuarioCpf":"08773819689",
   '   "senha": "ferreira"
   '}

   '{
   '"pessoaCodigo": 96942,
   '"pessoaCnpj": "07893348607",
   '"pessoaNome": "Marcos Ferreira",
   '"usuarioCodigo": 77867,
   '"usuarioNome": "Marcos Ferreira",
   '"usuarioCpf": "08773819689",
   '"token": "eyJhbGciOiJIUzUxMiJ9.eyJzdWIiOiIwMDc3ODY3N2Y0Yjg5ZjM2YTEzNzQwMiIsInJvbGUiOjEsImV4cCI6MTYyODgyODYxMH0.duKDQFOQcVSOa6Y6EDkRCBLLHz0jCx-O9KyUCKVdocqmcQfyn63knfOO5JSAGue4eKWMMDFjnh9Yv59oDC3vHg",
   '"chave": "00778677f4b89f36a137402",
   '"senha": "",
   '"retornoCodigo": 0,
   '"retorno": "Login com Sucesso;"

   'Dim D As New Dictionary(Of String, String) 'tchave e tvalor
   'D.Add("pessoaCodigo", TxtCodigoUnidadePF.Text)
   'D.Add("pessoaCnpj", TXT_CPF.Text)
   'D.Add("usuarioCpf", Txt_Id_CPF_Usuario.Text)
   'D.Add("senha", TxtSenhaAcesso.Text)

   'Dim Serializa = JsonConvert.SerializeObject(D, Formatting.Indented)
   'SalvarJson(Serializa, Application.StartupPath & "\Credencial_PF.Json")
   'MsgBox("Alterações em Pessoa Física registrada com sucesso.", MsgBoxStyle.Information + MsgBoxStyle.Question)

#End Region

   '    A primeira entrada no objeto array pode ser acessada da seguinte forma:
   'alunos[0].nome; => retona Jose Carlos
   'Para alterar um valor usamos a seguinte sintaxe:
   'alunos[0].nome = "Teste";

   'Dim P As New ConfiguracaoFeam
   'Dim D As New Dictionary(Of String, ConfiguracaoFeam.PessoaFisica)
   'D.Add("PessoaFisica", New ConfiguracaoFeam.PessoaFisica With {.CodigoUnidadePF = TxtCodigoUnidadePF.Text, .CPF = TXT_CPF.Text, .Id_CPF_Usuario = Txt_Id_CPF_Usuario.Text, .SenhaAcesso = TxtSenhaAcesso.Text})
   'Dim D1 As New Dictionary(Of String, ConfiguracaoFeam.PessoaJuridica) From
   '    {{"PessoaJuridica", New ConfiguracaoFeam.PessoaJuridica() With
   '    {.CodigoUnidadePJ = TxtCodigoUnidadePJ.Text, .CNPJ = TxtCNPJ.Text, .IdCPFusuarioPJ = TxtIdCPFusuarioPJ.Text, .SenhaAcessoPJ = TxtSenhaAcessoPJ.Text}}}
   'Dim Serializar = JsonConvert.SerializeObject(D, Formatting.Indented)
   'MsgBox(Serializar)
   'Dim CF As New ConfiguracaoFeam.PessoaFisica



#Region "Usando Dicionario"
   ' Dim D As New Dictionary(Of String, String)
   'D.Add("pessoaCodigo", TxtCodigoUnidadePJ.Text)
   'D.Add("pessoaCnpj", TxtCNPJ.Text)
   'D.Add("usuarioCpf", TxtIdCPFusuarioPJ.Text)
   'D.Add("senha", TxtSenhaAcessoPJ.Text)

   'Dim S = JsonConvert.SerializeObject(D, Formatting.Indented)
   'SalvarJson(S, Application.StartupPath & "\Credencial_PJ.Json")
   'MsgBox("Alterações em Pessoa Jurídica registrada com sucesso.", MsgBoxStyle.Information + MsgBoxStyle.Question)

#End Region

   'Dim I As Integer
   'For I = 0 To ObjJson.Length - 1
   '    Console.Write("{0:X2} ", ObjJson(I))
   'Next
   ' Console.WriteLine()
   'JsonConvert.SerializeObject(ObjJson)

   Public Shared Sub SalvarJson(ObjJson As Object, Path As String)
	 Try
	    Using SW = New StreamWriter(Path)
		  SW.WriteLine(ObjJson)
		  ObjJson = JsonConvert.SerializeObject(ObjJson)
		  MsgBox("Alterações Registradas com êxito!", MsgBoxStyle.Information, UsuarioLogado.UsuarioLogado)
	    End Using
	 Catch ex As Exception
	    MessageBox.Show(ex.Message)
	 End Try
   End Sub

   Private Sub RdbPessoaFisica_CheckedChanged(sender As Object, e As EventArgs) Handles RdbPessoaFisica.CheckedChanged
	 GBPessoaJuridica.Enabled = False
	 GBPessoaFisica.Enabled = True
   End Sub

   Private Sub RdbPessoaJridica_CheckedChanged(sender As Object, e As EventArgs) Handles RdbPessoaJridica.CheckedChanged
	 GBPessoaFisica.Enabled = False
	 GBPessoaJuridica.Enabled = True
   End Sub

   Private Sub RdbDesativado_CheckedChanged(sender As Object, e As EventArgs) Handles RdbDesativado.CheckedChanged
	 GBPessoaFisica.Enabled = False
	 GBPessoaJuridica.Enabled = False
   End Sub

   Private Sub FRMConfiguracaoFeam_Load(sender As Object, e As EventArgs) Handles MyBase.Load

	 Dim list As New List(Of Configuracao)
	 list = Carregar_Configuracao(Application.StartupPath & "\Configuracao.json")

	 GBPessoaFisica.Enabled = False
	 GBPessoaJuridica.Enabled = False

	 'modalidade
	 RdbPessoaFisica.Checked = list.Item(0).Modalidade_.RdbPessoaFisica
	 RdbPessoaJridica.Checked = list.Item(0).Modalidade_.RdbPessoaJridica
	 RdbDesativado.Checked = list.Item(0).Modalidade_.RdbDesativado

	 'fisico
	 TxtCodigoUnidadePF.Text = list.Item(0).Pessoa_fisica.CodigoUnidadePF
	 TXT_CNPJ_pessoa_fisica.Text = list.Item(0).Pessoa_fisica.CPF
	 Txt_Id_CPF_Usuario.Text = list.Item(0).Pessoa_fisica.Id_CPF_Usuario
	 TxtSenhaAcesso.Text = list.Item(0).Pessoa_fisica.SenhaAcesso
	 'juridico
	 TxtCodigoUnidadePJ.Text = list.Item(0).Pessoa_Juridica.CodigoUnidadePJ
	 TXT_CNPJ_pessoa_Juridica.Text = list.Item(0).Pessoa_Juridica.CNPJ
	 TxtIdCPFusuarioPJ.Text = list.Item(0).Pessoa_Juridica.IdCPFusuarioPJ
	 TxtSenhaAcessoPJ.Text = list.Item(0).Pessoa_Juridica.SenhaAcessoPJ

	 'LEITOR

	 RDB_ReceberMtr10Dig.Checked = list.Item(0).LeitorCodigoBarras.ReceberMtr10Dig
	 RDB_ReceberMtr34Dig.Checked = list.Item(0).LeitorCodigoBarras.ReceberMtr34Dig

	 'req
	 Txt_api_gettoken.Text = list.Item(0).Req.Gettoken
	 TxtRetornaListaClasse.Text = list.Item(0).Req.RetornaListaClasse
	 TxtRetornaListaUnidade.Text = list.Item(0).Req.RetornaListaUnidade
	 TxtRetornaListaTecnologia.Text = list.Item(0).Req.RetornaListaTecnologia
	 Txt_retornaListaEstadoFisico.Text = list.Item(0).Req.RetornaListaEstadoFisico
	 Txt_RetornaListaResiduo.Text = list.Item(0).Req.RetornaListaResiduo
	 TxtRetornaListaAcondicionamento.Text = list(0).Req.RetornaListaAcondicionamento
	 Txt_SalvarManifestoLote.Text = list(0).Req.SalvarManifestoLote
	 Txt_Donwload_PDF_Manifesto.Text = list(0).Req.Donwload_PDF_Manifesto
	 Txt_DonwloadCDF.Text = list(0).Req.DonwloadCDF
	 Txt_EmiteCDF.Text = list(0).Req.EmiteCDF
	 Txt_ReceberManifestoLote.Text = list(0).Req.ReceberManifestoLote
	 Txt_AlteraçãoManifestoRecebido.Text = list(0).Req.AlteraçãoManifestoRecebido
	 Txt_AceiteAlteracaoRecebimento.Text = list(0).Req.AceiteAlteracaoRecebimento
	 Txt_CancelarManifesto.Text = list(0).Req.CancelarManifesto
	 Txt_RetornaManifesto.Text = list(0).Req.RetornaManifesto
	 Txt_RetornaListaCodigoBarasManifesto.Text = list(0).Req.RetornaListaCodigoBarasManifesto

	 'DestinadorCodigoUnidade
	 txtDestinadorCodigoUnidade.Text = list(0).Destinador_CodigoUnidade.CodigoUnidade

	 GetTravar()
   End Sub

   Public Function GetTravar() As Boolean
	 Txt_api_gettoken.ReadOnly = True
	 TxtRetornaListaClasse.ReadOnly = True
	 TxtRetornaListaUnidade.ReadOnly = True
	 TxtRetornaListaTecnologia.ReadOnly = True
	 Txt_retornaListaEstadoFisico.ReadOnly = True
	 Txt_RetornaListaResiduo.ReadOnly = True
	 TxtRetornaListaAcondicionamento.ReadOnly = True
	 Txt_SalvarManifestoLote.ReadOnly = True
	 Txt_Donwload_PDF_Manifesto.ReadOnly = True
	 Txt_DonwloadCDF.ReadOnly = True
	 Txt_EmiteCDF.ReadOnly = True
	 Txt_ReceberManifestoLote.ReadOnly = True
	 Txt_AlteraçãoManifestoRecebido.ReadOnly = True
	 Txt_AceiteAlteracaoRecebimento.ReadOnly = True
	 Txt_CancelarManifesto.ReadOnly = True
	 Txt_RetornaManifesto.ReadOnly = True
	 Txt_RetornaListaCodigoBarasManifesto.ReadOnly = True
	 Return True
   End Function

   Public Function GetDestravar() As Boolean
	 Txt_api_gettoken.ReadOnly = False
	 TxtRetornaListaClasse.ReadOnly = False
	 TxtRetornaListaUnidade.ReadOnly = False
	 TxtRetornaListaTecnologia.ReadOnly = False
	 Txt_retornaListaEstadoFisico.ReadOnly = False
	 Txt_RetornaListaResiduo.ReadOnly = False
	 TxtRetornaListaAcondicionamento.ReadOnly = False
	 Txt_SalvarManifestoLote.ReadOnly = False
	 Txt_Donwload_PDF_Manifesto.ReadOnly = False
	 Txt_DonwloadCDF.ReadOnly = False
	 Txt_EmiteCDF.ReadOnly = False
	 Txt_ReceberManifestoLote.ReadOnly = False
	 Txt_AlteraçãoManifestoRecebido.ReadOnly = False
	 Txt_AceiteAlteracaoRecebimento.ReadOnly = False
	 Txt_CancelarManifesto.ReadOnly = False
	 Txt_RetornaManifesto.ReadOnly = False
	 Txt_RetornaListaCodigoBarasManifesto.ReadOnly = False
	 Return False
   End Function

   Private Sub PBDesbloquear_Click(sender As Object, e As EventArgs) Handles PBDesbloquear.Click

	 Dim P = ImputBoxPersonalizado.InputBox_Personalizado("Digite a senha de administrador para desbloquear os controles", vbTab & UCase(UsuarioLogado.UsuarioLogado()), BunifuCustomTextbox1.Text, True)
	 If P <> String.Empty And P <> "" And P = "ferreiram" Then
	    MsgBox("Você desbloqueou os controles de requisição com sucesso!", MsgBoxStyle.Information, "Atenção")
	    GetDestravar()
	 End If
   End Sub

   Private Sub PBbloquear_Click(sender As Object, e As EventArgs) Handles PBbloquear.Click
	 Dim P = ImputBoxPersonalizado.InputBox_Personalizado("Digite a senha de administrador para Bloquear os controles", vbTab & UCase(UsuarioLogado.UsuarioLogado()), BunifuCustomTextbox1.Text, True)
	 If P <> String.Empty And P <> "" And P = "ferreiram" Then
	    MsgBox("Você Bloqueou os controles da requisição !", MsgBoxStyle.Information, "Atenção")
	    GetTravar()
	 End If
   End Sub

   Private Sub BtRegistrarAlteracoes_Click(sender As Object, e As EventArgs) Handles BtRegistrarAlteracoes.Click
	 Dim Lista As New List(Of Configuracao)

	 Dim ConfigTipo_Modalidade As New Configuracao.Modalidade(RdbPessoaFisica.Checked,
	 RdbPessoaJridica.Checked,
	 RdbDesativado.Checked)

	 Dim ConfigPfisica As New Configuracao.PessoaFisica(TxtCodigoUnidadePF.Text,
	 TXT_CNPJ_pessoa_fisica.Text,
	 Txt_Id_CPF_Usuario.Text,
	 TxtSenhaAcesso.Text)

	 Dim ConfigPJuridica As New Configuracao.PessoaJuridica(TxtCodigoUnidadePJ.Text,
	 TXT_CNPJ_pessoa_Juridica.Text,
	 TxtIdCPFusuarioPJ.Text,
	 TxtSenhaAcessoPJ.Text)

	 Dim ConfigLeitor_Codigo_Barras As New Configuracao.Leitor_Codigo_Barras(
	 RDB_ReceberMtr34Dig.Checked,
	 RDB_ReceberMtr10Dig.Checked)

	 Dim ConfigRequisicoes As New Configuracao.Requisicoes(
	 Txt_api_gettoken.Text,
	 TxtRetornaListaClasse.Text,
	 TxtRetornaListaUnidade.Text,
	 TxtRetornaListaTecnologia.Text,
	 Txt_retornaListaEstadoFisico.Text,
	 Txt_RetornaListaResiduo.Text,
	 TxtRetornaListaAcondicionamento.Text,
	 Txt_SalvarManifestoLote.Text,
	 Txt_Donwload_PDF_Manifesto.Text,
	 Txt_DonwloadCDF.Text,
	 Txt_EmiteCDF.Text,
	 Txt_ReceberManifestoLote.Text,
	 Txt_AlteraçãoManifestoRecebido.Text,
	 Txt_AceiteAlteracaoRecebimento.Text,
	 Txt_CancelarManifesto.Text,
	 Txt_RetornaManifesto.Text,
	 Txt_RetornaListaCodigoBarasManifesto.Text)

	 Dim ConfigDestinador As New DestinadorCodigoUnidade(txtDestinadorCodigoUnidade.Text)


	 Lista.Add(New Configuracao(ConfigTipo_Modalidade,
						   ConfigPfisica, ConfigPJuridica,
						   ConfigLeitor_Codigo_Barras,
						   ConfigRequisicoes,
						   ConfigDestinador))

	 Dim P = JsonConvert.SerializeObject(Lista, Formatting.Indented)

	 SalvarJson(P, Application.StartupPath & "\Configuracao.json")
	 Carregar_Configuracao(Application.StartupPath & "\Configuracao.json")
	 Abrir(Application.ExecutablePath)
	 End

	 'Atualiza Config depois de alterações
   End Sub
   Public Shared Sub Abrir(CaminhoComNomeArquivo As String)
	 Dim G = New ProcessStartInfo
	 G.FileName = CaminhoComNomeArquivo
	 Process.Start(G)
   End Sub

End Class