Imports System.IO
Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json
Public Class RetornaListaAcondicionamento

   <JsonProperty("tipoCodigo")>
   Public Property TipoCodigo As Integer
   <JsonProperty("tipoDescricao")>
   Public Property TipoDescricao As String
   <JsonProperty("codigoErro")>
   Public Property CodigoErro As Object
   <JsonProperty("mensagem")>
   Public Property Mensagem As Object
   Public Sub New()
   End Sub
   Public Sub New(tipoCodigo As Integer, tipoDescricao As String, codigoErro As Object, mensagem As Object)
	 Me.TipoCodigo = tipoCodigo
	 Me.TipoDescricao = tipoDescricao
	 Me.CodigoErro = codigoErro
	 Me.Mensagem = mensagem
   End Sub
   Public Async Function RetornaListaAcondicionamento(URL As String) As Task(Of List(Of RetornaListaAcondicionamento))
	 Dim Lista_RetornaListaAcondicionamento As New List(Of RetornaListaAcondicionamento)
	 Dim Leitor As String
	 Dim ChaveToken As New RetornarToken

	 Try
	    Using StreamReader_ As New StreamReader(Application.StartupPath & "\ChaveToken.json")
		  Leitor = StreamReader_.ReadToEnd
		  ChaveToken = JsonConvert.DeserializeObject(Of RetornarToken)(Leitor)
	    End Using
	    'payload
	    Dim Dic As New Dictionary(Of String, String) From {
	    {"Authorization", String.Format("Bearer {0}", ChaveToken.Token)},
	    {"chave_feam", ChaveToken.Chave},
	    {"content-type", "application/json"}
	    }

	    Using HttpClient_ As New HttpClient()
		  Dim Postagem As New StringContent(Dic.ToString, Encoding.UTF8, "application/json")

		  With HttpClient_
			.BaseAddress = New Uri(URL)
			.DefaultRequestHeaders.Add(Dic.Keys(0), Dic.Values(0))
			.DefaultRequestHeaders.Add(Dic.Keys(1), Dic.Values(1))
			.DefaultRequestHeaders.Accept.Add(New Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"))
		  End With

		  Using Response_ As HttpResponseMessage = Await HttpClient_.PostAsync(URL, Postagem)
			Dim Resposta = Response_.Content.ReadAsStringAsync().Result
			Lista_RetornaListaAcondicionamento = JsonConvert.DeserializeObject(Of List(Of RetornaListaAcondicionamento))(Resposta)

			Using StreamWriter_ As New StreamWriter(Application.StartupPath & "\RetornaListaAcondicionamento.json")
			   StreamWriter_.WriteLine()
			End Using
		  End Using
	    End Using
	 Catch ex As Exception
	    MsgBox(ex.Message.ToString)
	    If ex.Message.ToString.Contains("401") Then
		  Exit Function
	    End If

	 End Try
	 Return Await Task.FromResult(Lista_RetornaListaAcondicionamento)

   End Function

End Class
