Imports System.IO
Imports System.Net
Imports System.Text
Imports Newtonsoft.Json
Public Class RetornaListaUnidade
   <JsonProperty("tpuniCodigo")>
   Public Property TpuniCodigo As Integer
   <JsonProperty("tpuniDescricao")>
   Public Property TpuniDescricao As String
   <JsonProperty("tpuniSigla")>
   Public Property TpuniSigla As String
   <JsonProperty("retornoCodigo")>
   Public Property RetornoCodigo As Object
   <JsonProperty("retorno")>
   Public Property Retorno As Object

   Sub New()
   End Sub

   Public Async Function RetornaListaUnidade(Url_0 As String) As Task(Of List(Of RetornaListaUnidade))
	 Dim Lista As New List(Of RetornaListaUnidade)
	 Try
	    Using streamreader As New StreamReader(Application.StartupPath & "\ChaveToken.Json")
		  Dim Toke As String = streamreader.ReadToEnd()
		  Dim X = JsonConvert.DeserializeObject(Of RetornarToken)(Toke)

		  'payload
		  Dim Payload As IEnumerable(Of KeyValuePair(Of String, String))
		  Payload = New List(Of KeyValuePair(Of String, String)) From {New KeyValuePair(Of String, String)("Authorization", String.Format("Bearer {0}", X.Token)), New KeyValuePair(Of String, String)("chave_feam", X.Chave)}
		  Dim Postagem As New Http.StringContent(Payload.ToString, Encoding.UTF8, "application/json")

		  Using webclient As New WebClient
			With webclient
			   .Headers.Add("Authorization", Payload(0).Value)
			   .Headers.Add("chave_feam", Payload(1).Value)
			   .Headers.Add(HttpRequestHeader.Accept, "application/json")
			End With

			Dim GetBytes_Dados = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(Payload))
			Dim Upar = webclient.UploadData(Url_0, "POST", GetBytes_Dados)
			Dim GetResposta = Encoding.UTF8.GetString(Upar)
			Lista = JsonConvert.DeserializeObject(Of List(Of RetornaListaUnidade))(GetResposta)

			Using streamWriter2 As New StreamWriter(Application.StartupPath & "\RetornaListaUnidade.json")
			   streamWriter2.WriteLine(GetResposta)
			End Using
		  End Using
	    End Using

	 Catch ex As Exception
	    MsgBox(ex.Message.ToString)
	    If ex.Message.ToString.Contains("401") Then
		  Exit Function
	    End If
	 Finally
	 End Try
	 Return Await Task.FromResult(Lista)
   End Function
End Class



