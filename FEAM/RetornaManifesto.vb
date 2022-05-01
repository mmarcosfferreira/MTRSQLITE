
Imports System.IO
Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json

Public Class retornaManifesto
   Public Property manifestoCodigo As Integer
   Public Property seuCodigoReferencia As Object
   Public Property retornoCodigo As Integer
   Public Property cnpGerador As String
   Public Property codUnidadeGerador As Integer
   Public Property cnpTransportador As String
   Public Property codUnidadeTransportador As Integer
   Public Property cnpDestinador As String
   Public Property codUnidadeDestinador As Integer
   Public Property cnpArmazenador As Object
   Public Property codUnidadeArmazenador As Object
   Public Property situacaoManifestoCodigo As Integer
   Public Property manifData As String
   Public Property manifDataExpedicao As String
   Public Property manifObservacao As String
   Public Property manifDataRecebimento As String
   Public Property manifGeradorNomeResponsavel As String
   Public Property manifGeradorCargoResponsavel As String
   Public Property manifTransportadorNomeMotorista As String
   Public Property manifTransportadorPlacaVeiculo As String
   Public Property manifTransportadorDataExpedicao As Object
   Public Property retorno As String
   Public Property itemManifestoJSONs As List(Of Itemmanifestojson)

   Public Sub New(manifestoCodigo As Integer, seuCodigoReferencia As Object,
				retornoCodigo As Integer, cnpGerador As String,
				codUnidadeGerador As Integer, cnpTransportador As String,
				codUnidadeTransportador As Integer, cnpDestinador As String,
				codUnidadeDestinador As Integer, cnpArmazenador As Object,
				codUnidadeArmazenador As Object, situacaoManifestoCodigo As Integer,
				manifData As String, manifDataExpedicao As String,
				manifObservacao As String, manifGeradorNomeResponsavel As String,
				manifGeradorCargoResponsavel As String, manifTransportadorNomeMotorista As String,
				manifTransportadorPlacaVeiculo As String, manifTransportadorDataExpedicao As Object,
				retorno As String, itemManifestoJSONs As List(Of Itemmanifestojson))

	 Me.manifestoCodigo = manifestoCodigo
	 Me.seuCodigoReferencia = seuCodigoReferencia
	 Me.retornoCodigo = retornoCodigo
	 Me.cnpGerador = cnpGerador
	 Me.codUnidadeGerador = codUnidadeGerador
	 Me.cnpTransportador = cnpTransportador
	 Me.codUnidadeTransportador = codUnidadeTransportador
	 Me.cnpDestinador = cnpDestinador
	 Me.codUnidadeDestinador = codUnidadeDestinador
	 Me.cnpArmazenador = cnpArmazenador
	 Me.codUnidadeArmazenador = codUnidadeArmazenador
	 Me.situacaoManifestoCodigo = situacaoManifestoCodigo
	 Me.manifData = manifData
	 Me.manifDataExpedicao = manifDataExpedicao
	 Me.manifObservacao = manifObservacao
	 Me.manifGeradorNomeResponsavel = manifGeradorNomeResponsavel
	 Me.manifGeradorCargoResponsavel = manifGeradorCargoResponsavel
	 Me.manifTransportadorNomeMotorista = manifTransportadorNomeMotorista
	 Me.manifTransportadorPlacaVeiculo = manifTransportadorPlacaVeiculo
	 Me.manifTransportadorDataExpedicao = manifTransportadorDataExpedicao
	 Me.retorno = retorno
	 Me.itemManifestoJSONs = itemManifestoJSONs
   End Sub

   Public Sub New()
   End Sub

   Public Enum RetornoCodigo_
	 Sucesso = 0
	 CódigodeBarrasInválido = 901
	 ManifestoInválidoOuNaoEncontrado = 902
	 ErroNãoIdentificado = 903
   End Enum

   Public Enum SituacaoManifestoCodigo_
	 Salvo = 1
	 MTRRecebido = 3
	 Cancelado = 4
	 EmArmazenamentoTemporario = 9
   End Enum

   'METODOS E FUNÇÕES
   'Public Shared Sub SalvarConteudo(ByVal caminhoArquivo As String, ByVal conteudo As Object, ByVal identar As Boolean)
   '    Dim formatacao As Formatting = If(identar, Formatting.Indented, Formatting.None)
   '    Dim texto As Object = JsonConvert.SerializeObject(conteudo, formatacao)
   '    File.WriteAllText(caminhoArquivo, texto, Encoding.Default)
   'End Sub
   Public Shared Sub SalvarConteudo(ByVal caminhoArquivo As String, ByVal conteudo As Object)
	 File.WriteAllText(caminhoArquivo, conteudo, Encoding.Default)
   End Sub
   Public Shared Sub SerializarNewtonsoft(manifesto As Object)
	 Using StreamWriter = New System.IO.StreamWriter("RetornaManifesto.json")
	    Dim Json_ As String = JsonConvert.SerializeObject(manifesto, Formatting.Indented)
	 End Using
   End Sub
   Public Shared Function DeserializarNewtonsoft() As Object
	 Dim Json = System.IO.File.ReadAllText("RetornaManifesto.json")
	 Return Newtonsoft.Json.JsonConvert.DeserializeObject(Of List(Of retornaManifesto))(Json)
   End Function

   'Dim t = Task.Run(Function() PostURI(u, c))
   't.Wait()
   Public Async Function RetornaManifesto(ByVal url As String) As Task(Of retornaManifesto)
	 Dim Lista As New List(Of retornaManifesto)
	 Dim Resultado As String
	 Try
	    Using streamreader_ As New StreamReader(Application.StartupPath & "\ChaveToken.Json") 'pega o token
		  Dim str = streamreader_.ReadToEnd
		  Dim P = JsonConvert.DeserializeObject(Of RetornarToken)(str)
		  Dim payload As IEnumerable(Of KeyValuePair(Of String, String))
		  payload = New List(Of KeyValuePair(Of String, String))() From {
						   New KeyValuePair(Of String, String)("Authorization", String.Format("Bearer {0}", P.Token)),
										 New KeyValuePair(Of String, String)("chave_feam", P.Chave),
										 New KeyValuePair(Of String, String)("content-type", "application/json")}
		  Dim DadosPostar As New StringContent(payload.ToString, Encoding.UTF8, "application/json")
		  Using client As New HttpClient()
			With client
			   .BaseAddress = New Uri(url)
			   .DefaultRequestHeaders.Add("Authorization", payload(0).Value)
			   .DefaultRequestHeaders.Add("chave_feam", payload(1).Value)
			   .DefaultRequestHeaders.Accept.Add(New Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"))
			End With

			Using resp As HttpResponseMessage = Await client.PostAsync(url, DadosPostar)
			   Resultado = resp.Content.ReadAsStringAsync().Result

			   Dim T As _HttpStatusCode._HttpStatusCode = JsonConvert.DeserializeObject(Of _HttpStatusCode._HttpStatusCode)(resp.StatusCode)

			   Select Case T
				 Case _HttpStatusCode._HttpStatusCode.Ok
				    'escreve os valores no arquivo
				    Using Sw As New StreamWriter(Application.StartupPath & "\RetornaManifesto.json")
					  Sw.WriteLine(Resultado)
					  JsonConvert.DeserializeObject(Of retornaManifesto)(Resultado)
				    End Using

				 Case _HttpStatusCode._HttpStatusCode.Aceito '202
				    MsgBox("Aceito", MsgBoxStyle.Exclamation)

				 Case _HttpStatusCode._HttpStatusCode.SolicitaçaoInvalida '400
				    MsgBox("SolicitaçaoInvalida", MsgBoxStyle.Exclamation)

				 Case _HttpStatusCode._HttpStatusCode.NãoAutorizado
				    MsgBox("Cliente não autorizado")

				 Case _HttpStatusCode._HttpStatusCode.NãoEncontrado '404
				    MsgBox("Não Encontrado")

				 Case _HttpStatusCode._HttpStatusCode.NaoAceito '406
				    MsgBox("Nao Aceito", MsgBoxStyle.Exclamation)

				 Case _HttpStatusCode._HttpStatusCode.AutenticaçãodeProxyNecessaria '407
				    MsgBox("AutenticaçãodeProxyNecessaria", MsgBoxStyle.Exclamation)

				 Case _HttpStatusCode._HttpStatusCode.ErroDoServidorInterno '500
				    MsgBox("ErroDoServidorInterno", MsgBoxStyle.Exclamation)

				 Case _HttpStatusCode._HttpStatusCode.PortadeEntradaRuim '502 
				    MsgBox("PortadeEntradaRuim", MsgBoxStyle.Exclamation)

				 Case _HttpStatusCode._HttpStatusCode.ServiçoIndisponivel '503 
				    MsgBox("ServiçoIndisponivel", MsgBoxStyle.Exclamation)

				 Case _HttpStatusCode._HttpStatusCode.TempoLimitedaPortadeEntrada '504  
				    MsgBox("TempoLimitedaPortadeEntrada", MsgBoxStyle.Exclamation)
			   End Select

			   Return JsonConvert.DeserializeObject(Of retornaManifesto)(Resultado)
			   Dim U As SituacaoManifestoCodigo_ = JsonConvert.DeserializeObject(Of SituacaoManifestoCodigo_)(situacaoManifestoCodigo)

			   'Dim GT As New RetornarToken
			   'Await GT.GetTokenAsync()
			End Using
		  End Using
	    End Using
	 Catch ex As Exception
	    MsgBox(ex.Message)
	    If ex.Message.ToString.Contains("401") Then
		  Dim NovoToken As New RetornarToken
		  NovoToken.GetTokenAsync().Wait()
	    Else
		  Exit Function
	    End If

	 End Try

	 'Dim Result As List(Of retornaManifesto) = Await Task.FromResult
	 Return JsonConvert.DeserializeObject(Of retornaManifesto)(Resultado)

	 'Restaura achecagem do certificado ssl
	 System.Net.ServicePointManager.ServerCertificateValidationCallback = Nothing '(final do metodo)

   End Function

   'Lista_A = New List(Of RetornaManifesto) From {JsonConvert.DeserializeObject(Of RetornaManifesto)(texto)}
   Public Shared Function ObterConteudo(ByVal caminhoArquivo As String)

	 Dim texto As Object = File.ReadAllText(caminhoArquivo)
	 'Using StreamReader_ = New System.IO.StreamReader(caminhoArquivo)
	 '    Dim Objeto = JsonConvert.DeserializeObject(Of RetornaManifesto)(StreamReader_.ReadToEnd)
	 '    Return Objeto
	 'End Using
	 Return JsonConvert.DeserializeObject(Of retornaManifesto)(texto)

   End Function

End Class

Public Class Itemmanifestojson
   Public Property codigoSequencial As Integer
   Public Property justificativa As Object
   Public Property codigoInterno As Object
   Public Property quantidade As Object
   Public Property quantidadeRecebida As Object
   Public Property residuo As String
   Public Property codigoAcondicionamento As Integer
   Public Property codigoClasse As Integer
   Public Property codigoTecnologia As Integer
   Public Property codigoTipoEstado As Integer
   Public Property codigoUnidade As Integer
   Public Property manifestoItemObservacao As Object
   Public Property manifestoItemCodInterno As Object
   Public Property manifestoItemCodInternoDestinador As Object
   Public Property tipoDensidadeValor As Object
   Public Property tipoDensidadeUnidade As Object
   Public Property numeroONU As String
   Public Property classeDeRisco As String
   Public Property nomeEmbarque As Object
   Public Property grupoEmbalagem As Object
End Class














