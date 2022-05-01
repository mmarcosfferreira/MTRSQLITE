Imports System.IO
Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json
Public Class RetornaListaResiduo

   Public Sub New(tpre1Codigo As Integer, tpre2Codigo As Integer, tpre3Codigo As Integer, tpre1Descricao As String, tpre2Descricao As String, tpre3Descricao As String, tpre1Numero As String, tpre2Numero As String, tpre3Numero As String, retornoCodigo As Object, retorno As Object)
	 Me.tpre1Codigo = tpre1Codigo
	 Me.tpre2Codigo = tpre2Codigo
	 Me.tpre3Codigo = tpre3Codigo
	 Me.tpre1Descricao = tpre1Descricao
	 Me.tpre2Descricao = tpre2Descricao
	 Me.tpre3Descricao = tpre3Descricao
	 Me.tpre1Numero = tpre1Numero
	 Me.tpre2Numero = tpre2Numero
	 Me.tpre3Numero = tpre3Numero
	 Me.retornoCodigo = retornoCodigo
	 Me.retorno = retorno
   End Sub
   Sub New()
   End Sub
   Public Property tpre1Codigo As Integer
   Public Property tpre2Codigo As Integer
   Public Property tpre3Codigo As Integer
   Public Property tpre1Descricao As String
   Public Property tpre2Descricao As String
   Public Property tpre3Descricao As String
   Public Property tpre1Numero As String
   Public Property tpre2Numero As String
   Public Property tpre3Numero As String
   Public Property retornoCodigo As Object
   Public Property retorno As Object

   Public Async Function RetornaListaResiduo(Url As String) As Task(Of List(Of RetornaListaResiduo))

	 Dim Lista_RetornaListaResiduo As New List(Of RetornaListaResiduo)
	 Dim Leitura As String
	 Try
	    Using StreamReader_ As New StreamReader(Application.StartupPath & "\ChaveToken.json")
		  Leitura = StreamReader_.ReadToEnd
	    End Using
	    Dim L = JsonConvert.DeserializeObject(Of RetornarToken)(Leitura)
	    Dim Payload As New Dictionary(Of String, String) From {
				    {"Authorization", String.Format("Bearer {0}", L.Token)},
				    {"chave_feam", L.Chave},
					{"content-type", "application/json"}}

	    Using HttpClient_ As New HttpClient With {.BaseAddress = New Uri(Url)}

		  Dim Carga = New StringContent(Payload.ToString, Encoding.UTF8, "application/json")
		  HttpClient_.DefaultRequestHeaders.Add(Payload.Keys(0), Payload.Values(0))
		  HttpClient_.DefaultRequestHeaders.Add(Payload.Keys(1), Payload.Values(1))

		  Using HttpResponseMessage_ As HttpResponseMessage = Await HttpClient_.PostAsync("", Carga)
			Dim Resposta = HttpResponseMessage_.Content.ReadAsStringAsync.Result
			Lista_RetornaListaResiduo = JsonConvert.DeserializeObject(Of List(Of RetornaListaResiduo))(Resposta)
			'escrever
			Using StreamWriter_ As New StreamWriter(Application.StartupPath & "\RetornaListaResiduo.json")
			   StreamWriter_.WriteLine(Resposta)
			End Using
		  End Using
	    End Using
	 Catch ex As Exception
	    MsgBox(ex.Message.ToString)
	    If ex.Message.ToString.Contains("401") Then
		  Exit Function
	    End If
	 End Try
	 Return Await Task.FromResult(Lista_RetornaListaResiduo)
   End Function
End Class



