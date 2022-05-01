Imports System.IO
Imports Newtonsoft.Json
'File.WriteAllText(AgentWorkingDirectory & "\json.txt",JsonConvert.SerializeObject(return_message, Newtonsoft.Json.Formatting.Indented))

''' <summary>
''' Classe Container Para pegar toda cconfiguração das subclasses[ Classe-filhos..>PessoaFisica,  PessoaJuridica,  Leitor_Codigo_Barras,  Modalidade]
''' </summary>
Public Class Configuracao
   Public Property Modalidade_() As Modalidade
   Public Property Pessoa_fisica() As PessoaFisica
   Public Property Pessoa_Juridica() As PessoaJuridica
   Public Property LeitorCodigoBarras() As Leitor_Codigo_Barras
   Public Property Req() As Requisicoes
   Public Property Destinador_CodigoUnidade() As DestinadorCodigoUnidade


   'Metodos
   Public Shared Function Carregar_Configuracao(path As String) As List(Of Configuracao)
	 Dim Lista As New List(Of Configuracao)
	 Try
	    Using SR = New StreamReader(path)
		  Dim P = SR.ReadToEnd
		  Lista = JsonConvert.DeserializeObject(Of List(Of Configuracao))(P)
	    End Using
	 Catch ex As Exception
	    MsgBox(ex.Message)
	 End Try
	 Return Lista
   End Function


   '4 CONSTRUTORES PessoaFisica/PessoaJuridica/Leitor_Codigo_Barras/Modalidade/ DEVE SEGUIR A ORDEM EXATA
   Public Sub New(configModalidade As Modalidade,
   configPF As PessoaFisica,
   configPJ As PessoaJuridica,
   configLeitorCodBarras As Leitor_Codigo_Barras,
   ConfigRequisicoes As Requisicoes,
   Configdestinador As DestinadorCodigoUnidade)

	 Me.Modalidade_ = configModalidade
	 Me.Pessoa_fisica = configPF
	 Me.Pessoa_Juridica = configPJ
	 Me.LeitorCodigoBarras = configLeitorCodBarras
	 Me.Req = ConfigRequisicoes
	 Me.Destinador_CodigoUnidade = Configdestinador
   End Sub

   Public Sub New()

   End Sub

   '_________________________________ConfiguracaoFeam___________________________________________
   Public Class Modalidade
	 'classe Modalidade
	 Public Property RdbPessoaFisica
	 Public Property RdbPessoaJridica
	 Public Property RdbDesativado

	 'construtor da classe Modalidade
	 Public Sub New(rdbPessoaFisica As Boolean,
	 rdbPessoaJridica As Boolean,
	 rdbDesativado As Boolean)

	    Me.RdbPessoaFisica = rdbPessoaFisica
	    Me.RdbPessoaJridica = rdbPessoaJridica
	    Me.RdbDesativado = rdbDesativado
	 End Sub
   End Class




   Public Class PessoaFisica
	 Public Property CodigoUnidadePF As String
	 Public Property CPF As String
	 Public Property Id_CPF_Usuario As String
	 Public Property SenhaAcesso As String

	 'CONSTRUTOR DA CLASSE PESSOA FISICA
	 Public Sub New(
	 _CodigoUnidadePF As String,
	 _CPF As String,
	 _Id_CPF_Usuario As String,
	 _SenhaAcesso As String)

	    Me.CodigoUnidadePF = _CodigoUnidadePF
	    Me.CPF = _CPF
	    Me.Id_CPF_Usuario = _Id_CPF_Usuario
	    Me.SenhaAcesso = _SenhaAcesso

	 End Sub
   End Class

   'CLASSE
   Public Class PessoaJuridica
	 Public Property CodigoUnidadePJ As String
	 Public Property CNPJ As String
	 Public Property IdCPFusuarioPJ As String
	 Public Property SenhaAcessoPJ As String

	 'CONSTRUTOR DA CLASSE PESSOA JURIDCA
	 Public Sub New(codigoUnidadePJ As String, cNPJ As String, idCPFusuarioPJ As String, senhaAcessoPJ As String)
	    Me.CodigoUnidadePJ = codigoUnidadePJ
	    Me.CNPJ = cNPJ
	    Me.IdCPFusuarioPJ = idCPFusuarioPJ
	    Me.SenhaAcessoPJ = senhaAcessoPJ
	 End Sub

   End Class

   Public Class Leitor_Codigo_Barras
	 'CLASSE Leitor_Codigo_Barras
	 Public Property ReceberMtr34Dig
	 Public Property ReceberMtr10Dig

	 'CONSTRUTOR Leitor_Codigo_Barras
	 Public Sub New(receberMtr34Dig As Boolean, receberMtr10Dig As Boolean)
	    Me.ReceberMtr34Dig = receberMtr34Dig
	    Me.ReceberMtr10Dig = receberMtr10Dig
	 End Sub
   End Class

   'CLASSE REQUISICOES
   Public Class Requisicoes
	 Public Property Gettoken As String
	 Public Property RetornaListaClasse As String
	 Public Property RetornaListaUnidade As String
	 Public Property RetornaListaTecnologia As String
	 Public Property RetornaListaEstadoFisico As String
	 Public Property RetornaListaResiduo As String
	 Public Property RetornaListaAcondicionamento As String
	 Public Property SalvarManifestoLote As String
	 Public Property Donwload_PDF_Manifesto As String
	 Public Property DonwloadCDF As String
	 Public Property EmiteCDF As String
	 Public Property ReceberManifestoLote As String
	 Public Property AlteraçãoManifestoRecebido As String
	 Public Property AceiteAlteracaoRecebimento As String
	 Public Property CancelarManifesto As String
	 Public Property RetornaManifesto As String
	 Public Property RetornaListaCodigoBarasManifesto As String
	 Public Sub New(gettoken As String, retornaListaClasse As String, retornaListaUnidade As String, retornaListaTecnologia As String, retornaListaEstadoFisico As String, retornaListaResiduo As String, retornaListaAcondicionamento As String, salvarManifestoLote As String, donwload_PDF_Manifesto As String, donwloadCDF As String, emiteCDF As String, receberManifestoLote As String, alteraçãoManifestoRecebido As String, aceiteAlteracaoRecebimento As String, cancelarManifesto As String, retornaManifesto As String, retornaListaCodigoBarasManifesto As String)

	    Me.Gettoken = gettoken
	    Me.RetornaListaClasse = retornaListaClasse
	    Me.RetornaListaUnidade = retornaListaUnidade
	    Me.RetornaListaTecnologia = retornaListaTecnologia
	    Me.RetornaListaEstadoFisico = retornaListaEstadoFisico
	    Me.RetornaListaResiduo = retornaListaResiduo
	    Me.RetornaListaAcondicionamento = retornaListaAcondicionamento
	    Me.SalvarManifestoLote = salvarManifestoLote
	    Me.Donwload_PDF_Manifesto = donwload_PDF_Manifesto
	    Me.DonwloadCDF = donwloadCDF
	    Me.EmiteCDF = emiteCDF
	    Me.ReceberManifestoLote = receberManifestoLote
	    Me.AlteraçãoManifestoRecebido = alteraçãoManifestoRecebido
	    Me.AceiteAlteracaoRecebimento = aceiteAlteracaoRecebimento
	    Me.CancelarManifesto = cancelarManifesto
	    Me.RetornaManifesto = retornaManifesto
	    Me.RetornaListaCodigoBarasManifesto = retornaListaCodigoBarasManifesto
	 End Sub

   End Class

   'Desativado
   Public Class DestinadorCodigoUnidade

	 Public Property CodigoUnidade As String

	 Public Sub New(codigoUnidade As String)
	    Me.CodigoUnidade = codigoUnidade
	 End Sub

	 Sub New()

	 End Sub

   End Class

End Class
