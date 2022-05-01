Imports System.IO
Imports System.Net
Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json

Public Class retornaListaClasse
   Public Sub New()
   End Sub

   <JsonProperty("tpclaCodigo")>
   Public Property TpclaCodigo As Integer
   <JsonProperty("tpclaDescricao")>
   Public Property TpclaDescricao As String
   <JsonProperty("tpclaSigla")>
   Public Property TpclaSigla As String
   <JsonProperty("retornoCodigo")>
   Public Property RetornoCodigo As Object
   <JsonProperty("retorno")>
   Public Property Retorno As Object

   Public Async Function PostRetornaListaClasse(Url As String) As Task(Of List(Of retornaListaClasse))

	 Dim Lista As New List(Of retornaListaClasse)
	 'pega o token p montar a req post
	 Try
	    Using streamreader = New StreamReader(Application.StartupPath & "\ChaveToken.Json")
		  Dim str = streamreader.ReadToEnd
		  Dim S = JsonConvert.DeserializeObject(Of RetornarToken)(str)

		  'payload
		  Dim Payload As IEnumerable(Of KeyValuePair(Of String, String))
		  Payload = New List(Of KeyValuePair(Of String, String)) From {
				  New KeyValuePair(Of String, String)("Authorization", String.Format("Bearer {0}", S.Token)),
				  New KeyValuePair(Of String, String)("chave_feam", S.Chave)}
		  Dim Postagem As New StringContent(Payload.ToString, Encoding.UTF8, "application/json")

		  Using WebClient As New WebClient()
			WebClient.Headers.Add("Authorization", Payload(0).Value)
			WebClient.Headers.Add("chave_feam", Payload(1).Value)
			WebClient.Headers.Add(HttpRequestHeader.Accept, "application/json")
			Dim ReqString = Encoding.Default.GetBytes(JsonConvert.SerializeObject(Payload, Formatting.Indented))
			Dim Resbyte = WebClient.UploadData(Url, "POST", ReqString)
			Dim ResString = Encoding.Default.GetString(Resbyte)
			' Dim RESULTA As New List(Of retornaListaClasse)
			Lista = JsonConvert.DeserializeObject(Of List(Of retornaListaClasse))(ResString)

			Using Sw = New StreamWriter(Application.StartupPath & "\retornaListaClasse.json")
			   Sw.WriteLine(ResString)
			End Using
		  End Using
	    End Using

	 Catch ex As Exception
	    MsgBox(ex.Message.ToString)
	    ' If ex.Message.ToString.Contains("401") Then
	    'Exit Function
	    ' End If
	 End Try
	 'Return Await Task.FromResult(RESULTA) 'RETORNA UMA LISTA
	 Return Await Task.FromResult(Lista)
   End Function

End Class



