Imports System.IO
Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json

Public Class RetornaListaEstadoFisico
   <JsonProperty("tpestCodigo")>
   Public Property TpestCodigo As Integer
   <JsonProperty("tpestDescricao")>
   Public Property TpestDescricao As String
   <JsonProperty("tpestSigla")>
   Public Property TpestSigla As String
   <JsonProperty("retornoCodigo")>
   Public Property RetornoCodigo As Object
   <JsonProperty("retorno")>
   Public Property Retorno As Object

   Public Sub New()

   End Sub

   Public Sub New(tpestCodigo As Integer, tpestDescricao As String, tpestSigla As String, retornoCodigo As Object, retorno As Object)
	 Me.TpestCodigo = tpestCodigo
	 Me.TpestDescricao = tpestDescricao
	 Me.TpestSigla = tpestSigla
	 Me.RetornoCodigo = retornoCodigo
	 Me.Retorno = retorno
   End Sub

   Public Async Function RetornaListaEstadoFisico(ByVal URL As String) As Task(Of List(Of RetornaListaEstadoFisico))
	 Dim ListaRetornaListaEstadoFisico As New List(Of RetornaListaEstadoFisico)
	 Try
	    'Ler a chave token
	    Dim Resultado As String
	    Dim Token_e_Chave As New RetornarToken
	    Dim Resposta As String

	    Using sr As New StreamReader(Application.StartupPath & "\ChaveToken.json")
		  Resultado = sr.ReadToEnd
		  Token_e_Chave = JsonConvert.DeserializeObject(Of RetornarToken)(Resultado)
	    End Using

	    Dim Dic As New Dictionary(Of String, String) From {
	    {"Authorization", String.Format("Bearer {0}", Token_e_Chave.Token)},
	    {"chave_feam", Token_e_Chave.Chave}}

	    Using HttpClient_ As New HttpClient()
		  Dim Postagem As New StringContent(Dic.ToString, Encoding.UTF8, "application/json")
		  With HttpClient_
			.BaseAddress = New Uri(URL)
			.DefaultRequestHeaders.Add("Authorization", String.Format("Bearer {0}", Token_e_Chave.Token))
			.DefaultRequestHeaders.Add("chave_feam", Token_e_Chave.Chave)
			.DefaultRequestHeaders.Accept.Add(New Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"))
		  End With

		  Using Response_ As HttpResponseMessage = Await HttpClient_.PostAsync(URL, Postagem)
			Resposta = Response_.Content.ReadAsStringAsync().Result
			ListaRetornaListaEstadoFisico = JsonConvert.DeserializeObject(Of List(Of RetornaListaEstadoFisico))(Resposta)

			Using StreamWriter_ As New StreamWriter(Application.StartupPath & "\RetornaListaEstadoFisico.json")
			   StreamWriter_.WriteLine(Resposta)
			End Using
		  End Using
	    End Using

	 Catch ex As Exception
	    MsgBox(ex.Message.ToString())
	    If ex.Message.ToString.Contains("401") Then
		  Exit Function
	    End If

	 End Try
	 Return Await Task.FromResult(ListaRetornaListaEstadoFisico)

   End Function

End Class




