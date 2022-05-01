Imports System.IO
Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json
Imports Principal.Configuracao

Public Class ManifestoRecebimentoJSON

   ''' <summary>
   ''' manifestoCodigo, Tipo string,Tamanho 10 e obrigatorio 
   ''' </summary>
   ''' <returns></returns>
   <JsonProperty("manifestoCodigo")>
   Public Property ManifestoCodigo As String


   ''' <summary>
   ''' CnpGerador tipo:String (CNPJ OU CPF), tamanho: 14, obrigatorio: Sim
   ''' </summary>
   ''' <returns></returns>
   <JsonProperty("cnpGerador")>
   Public Property CnpGerador As String


   ''' <summary>
   ''' CAMPO:cnpTransportador, TIPO:String (CNPJ OU CPF), TAMANHO:14, OBRIGATÓRIO:Sim
   ''' </summary>
   ''' <returns></returns>
   <JsonProperty("cnpTransportador")>
   Public Property CnpTransportador As String


   ''' <summary>
   ''' CAMPO:recebimentoMtrResponsavel, TIPO:String, TAMANHO:150, OBRIGATÓRIO:sim
   ''' </summary>
   ''' <returns></returns>
   <JsonProperty("recebimentoMtrResponsavel")>
   Public Property RecebimentoMtrResponsavel As String


   ''' <summary>
   ''' CAMPO:recebimentoMtrCargo, TIPO:string, TAMANHO:100, OBRIGATÓRIO:sim
   ''' </summary>
   ''' <returns></returns>
   <JsonProperty("recebimentoMtrCargo")>
   Public Property RecebimentoMtrCargo As String


   ''' <summary>
   ''' CAMPO:recebimentoMtrData, TIPO:String (YYYYMMDD), TAMANHO:8, OBRIGATÓRIO: sim
   ''' </summary>
   ''' <returns></returns>
   <JsonProperty("recebimentoMtrData")>
   Public Property RecebimentoMtrData As String


   ''' <summary>
   ''' CAMPO:recebimentoMtrObs, TIPO:String, TAMANHO:255, OBRIGATÓRIO: não
   ''' </summary>
   ''' <returns></returns>
   <JsonProperty("recebimentoMtrObs")>
   Public Property RecebimentoMtrObs As String


   ''' <summary>
   '''  CAMPO:nomeMotorista, TIPO:String, TAMANHO:100, OBRIGATÓRIO: sim
   ''' </summary>
   ''' <returns></returns>
   <JsonProperty("nomeMotorista")>
   Public Property NomeMotorista As String


   ''' <summary>
   ''' CAMPO:placaVeiculo, TIPO:String, TAMANHO:10 ex:ABC-1234 ou ABC1234, OBRIGATÓRIO: sim
   ''' </summary>
   ''' <returns></returns>
   <JsonProperty("placaVeiculo")>
   Public Property PlacaVeiculo As String


   ''' <summary>
   ''' CAMPO:transporteMtrData, TIPO:String (YYYYMMDD), TAMANHO:8, OBRIGATÓRIO: sim
   ''' </summary>
   ''' <returns></returns>
   <JsonProperty("transporteMtrData")>
   Public Property TransporteMtrData As String


   '''' <summary>
   '''' CAMPO:itemManifestoRecebimentoJSONs, TIPO:[], TAMANHO:, OBRIGATÓRIO: 
   '''' </summary>
   '''' <returns></returns>
   '<JsonProperty("itemManifestoRecebimentoJSONs")>
   'Public ItemManifestoRecebimentoJSONs As List(Of ItemManifestoRecebimentoJSON)

   Public Property codigoSequencial As Integer
   Public Property justificativa As String
   Public Property codigoInterno As Integer
   Public Property qtdRecebida As Double
   Public Property residuo As String
   Public Property codigoTecnologia As Integer

   Sub New()
   End Sub

   Public Sub New(manifestoCodigo As String, cnpGerador As String, cnpTransportador As String, recebimentoMtrResponsavel As String, recebimentoMtrCargo As String, recebimentoMtrData As String, recebimentoMtrObs As String, nomeMotorista As String, placaVeiculo As String, transporteMtrData As String, codigoSequencial As Integer, justificativa As String, codigoInterno As Integer, qtdRecebida As Double, residuo As String, codigoTecnologia As Integer)

	 Me.ManifestoCodigo = manifestoCodigo
	 Me.CnpGerador = cnpGerador
	 Me.CnpTransportador = cnpTransportador
	 Me.RecebimentoMtrResponsavel = recebimentoMtrResponsavel
	 Me.RecebimentoMtrCargo = recebimentoMtrCargo
	 Me.RecebimentoMtrData = recebimentoMtrData
	 Me.RecebimentoMtrObs = recebimentoMtrObs
	 Me.NomeMotorista = nomeMotorista
	 Me.PlacaVeiculo = placaVeiculo
	 Me.TransporteMtrData = transporteMtrData
	 Me.codigoSequencial = codigoSequencial
	 Me.justificativa = justificativa
	 Me.codigoInterno = codigoInterno
	 Me.qtdRecebida = qtdRecebida
	 Me.residuo = residuo
	 Me.codigoTecnologia = codigoTecnologia
   End Sub

   Public Async Function ReceberManifestoLoteFunc(
	 manifestoCodigo As String,
	 cnpGerador As String,
	 cnpTransportador As String,
	 recebimentoMtrResponsavel As String,
	 recebimentoMtrCargo As String,
	 recebimentoMtrData As String,
	 NomeMotorista As String,
	 placaVeiculo As String,
	 transporteMtrData As String,
	 qtdRecebida As Double,
	 residuo As String,
	 codigoTecnologia As Integer,
	Optional recebimentoMtrObs As String = Nothing,
	Optional codigoSequencial As Integer = Nothing,
	Optional justificativa As String = Nothing,
	Optional codigoInterno As Integer = Nothing) As Task(Of List(Of ManifestoRecebimentoJSON))


	 Dim Lista As New List(Of ManifestoRecebimentoJSON)
	 Dim CF As List(Of Configuracao) = Carregar_Configuracao(Application.StartupPath & "/Configuracao.Json")
	 Dim URI = New Uri(CF.Item(0).Req.ReceberManifestoLote)
	 Dim Token As String
	 Dim Credencial As New RetornarToken

	 Using StreamReader_ As New StreamReader(Application.StartupPath & "\ChaveToken.Json")
	    Token = StreamReader_.ReadToEnd()
	    Credencial = JsonConvert.DeserializeObject(Of RetornarToken)(Token)
	 End Using

	 Dim M As New ManifestoRecebimentoJSON(manifestoCodigo, cnpGerador, cnpTransportador, recebimentoMtrResponsavel, recebimentoMtrCargo, recebimentoMtrData, recebimentoMtrObs, NomeMotorista, placaVeiculo, transporteMtrData, codigoSequencial, justificativa, codigoInterno, qtdRecebida, residuo, codigoTecnologia)

	 Dim M2 As New ItemManifestoRecebimentoJSON(codigoSequencial, justificativa, codigoInterno, qtdRecebida, residuo, codigoTecnologia) With {.CodigoSequencial = codigoSequencial, .Justificativa = justificativa, .CodigoInterno = codigoInterno, .QtdRecebida = qtdRecebida, .Residuo = residuo, .CodigoTecnologia = codigoTecnologia}

	 Try
	    'com o inicializador/ body
	    M.ManifestoCodigo = manifestoCodigo
	    M.CnpGerador = manifestoCodigo
	    M.CnpTransportador = cnpTransportador
	    M.RecebimentoMtrResponsavel = recebimentoMtrResponsavel
	    M.RecebimentoMtrCargo = recebimentoMtrCargo
	    M.RecebimentoMtrData = recebimentoMtrData
	    M.NomeMotorista = NomeMotorista
	    M.PlacaVeiculo = placaVeiculo
	    M.TransporteMtrData = transporteMtrData


	    M.codigoSequencial = codigoSequencial
	    M.justificativa = justificativa
	    M.codigoInterno = codigoInterno
	    M.qtdRecebida = qtdRecebida
	    M.residuo = residuo
	    M.codigoTecnologia = codigoTecnologia

	    Dim Dic As New Dictionary(Of String, String) From {
			 {"Authorization", String.Format("Bearer {0}", Credencial.Token)},
			 {"chave_feam", Credencial.Chave},
			 {"manifestoCodigo", M.ManifestoCodigo},
			 {"cnpGerador", M.CnpGerador},
			 {"cnpTransportador", M.CnpTransportador},
			 {"recebimentoMtrResponsavel", M.RecebimentoMtrResponsavel},
			 {"recebimentoMtrCargo", M.RecebimentoMtrCargo},
			 {"recebimentoMtrData", M.RecebimentoMtrData},
			 {"recebimentoMtrObs", M.RecebimentoMtrObs},
			 {"nomeMotorista", M.NomeMotorista},
			 {"placaVeiculo", M.PlacaVeiculo},
			 {"transporteMtrData", M.TransporteMtrData},
			 {"codigoSequencial", M.codigoSequencial},
			 {"justificativa", M.justificativa},
			 {"codigoInterno", M.codigoInterno},
			 {"qtdRecebida", M.qtdRecebida},
			 {"residuo", M.residuo},
			 {"codigoTecnologia", M.codigoTecnologia}
		  }

	    Dim parameters As String = JsonConvert.SerializeObject(Dic, Formatting.Indented)
	    Dim DadosPost = New System.Net.Http.StringContent(parameters.ToString, Encoding.UTF8, "application/json") 'Dados inseridos no Body da requisicao
	    Using client As New HttpClient()
		  With client
			.BaseAddress = URI
			.DefaultRequestHeaders.Add("Authorization", Dic.Values(0))
			.DefaultRequestHeaders.Add("chave_feam", Dic.Values(1))
			.DefaultRequestHeaders.Accept.Add(New Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"))
		  End With

		  Using Resposta As HttpResponseMessage = Await client.PostAsync(URI, DadosPost)
			Dim Resultado As String = Resposta.Content.ReadAsStringAsync().Result 'le o conteudo da pagia
			Dim K = Await Resposta.Content.ReadAsStringAsync
			Using SW = New StreamWriter(Application.StartupPath & "\ReceberManifestoLote.json")
			   SW.WriteLine(K)
			End Using
			Lista = JsonConvert.DeserializeObject(Of List(Of ManifestoRecebimentoJSON))(K)
		  End Using
	    End Using
	 Catch ex As Exception
	    MsgBox(ex.Message.ToString)
	 End Try
	 Return Await Task.FromResult(Lista)
	 'Restaura achecagem do certificado ssl
	 System.Net.ServicePointManager.ServerCertificateValidationCallback = Nothing
   End Function

End Class


Public Class ItemManifestoRecebimentoJSON
   Public Sub New()
   End Sub

   Public Sub New(codigoSequencial As Integer, justificativa As String, codigoInterno As Integer, qtdRecebida As Double, residuo As String, codigoTecnologia As Integer)
	 Me.CodigoSequencial = codigoSequencial
	 Me.Justificativa = justificativa
	 Me.CodigoInterno = codigoInterno
	 Me.QtdRecebida = qtdRecebida
	 Me.Residuo = residuo
	 Me.CodigoTecnologia = codigoTecnologia
   End Sub

   ''' <summary>
   ''' CAMPO:codigoSequencial, TIPO:Integer, TAMANHO:, OBRIGATÓRIO: nao
   ''' </summary>
   ''' <returns></returns>
   <JsonProperty("codigoSequencial")>
   Public Property CodigoSequencial As Integer


   ''' <summary>
   ''' CAMPO:justificativa, TIPO:string, TAMANHO:300, OBRIGATÓRIO: nao
   ''' </summary>
   ''' <returns></returns>
   <JsonProperty("justificativa")>
   Public Property Justificativa As String


   ''' <summary>
   ''' CAMPO:codigoInterno, TIPO:integer, TAMANHO:, OBRIGATÓRIO: nao
   ''' </summary>
   ''' <returns></returns>
   <JsonProperty("codigoInterno")>
   Public Property CodigoInterno As Integer

   ''' <summary>
   ''' CAMPO:qtdRecebida, TIPO:Double, TAMANHO:, OBRIGATÓRIO: sim
   ''' </summary>
   ''' <returns></returns>
   <JsonProperty("qtdRecebida")>
   Public Property QtdRecebida As Double



   ''' <summary>
   ''' CAMPO:residuo, TIPO:String (Informar o Código do IBAMA), TAMANHO:10, OBRIGATÓRIO: sim
   ''' </summary>
   ''' <returns></returns>
   <JsonProperty("residuo")>
   Public Property Residuo As String


   ''' <summary>
   ''' CAMPO:codigoTecnologia, TIPO:Integer, TAMANHO:, OBRIGATÓRIO: sim
   ''' </summary>
   ''' <returns></returns>
   <JsonProperty("codigoTecnologia")>
   Public Property CodigoTecnologia As Integer
End Class



