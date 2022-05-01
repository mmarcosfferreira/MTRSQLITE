Imports System.IO
Imports System.Net
Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json

Public Class RetornaListaTecnologia
   Public Sub New(tipoCodigo As Integer, tipoDescricao As String, retornoCodigo As Object, retorno As Object)
	 Me.TipoCodigo = tipoCodigo
	 Me.TipoDescricao = tipoDescricao
	 Me.RetornoCodigo = retornoCodigo
	 Me.Retorno = retorno
   End Sub

   <JsonProperty("tipoCodigo")>
   Public Property TipoCodigo As Integer
   <JsonProperty("tipoDescricao")>
   Public Property TipoDescricao As String
   <JsonProperty("retornoCodigo")>
   Public Property RetornoCodigo As Object
   <JsonProperty("retorno")>
   Public Property Retorno As Object

   Sub New()

   End Sub


   Public Async Function retornaListaTecnologia(Url As String) As Task(Of List(Of RetornaListaTecnologia))
	 Dim Lista_RetornaListaTecnologia As New List(Of RetornaListaTecnologia)

	 Try
	    'ler e carregar a chave e o token de acesso
	    Using streamreader As StreamReader = New StreamReader(Application.StartupPath & "\ChaveToken.json")
		  Dim LeituraToke = streamreader.ReadToEnd
		  Dim F = JsonConvert.DeserializeObject(Of RetornarToken)(LeituraToke)
		  '____________________________________________________________________________________________________
		  'Criar o paylodad 
		  Dim Dic As New Dictionary(Of String, String) From {
		  {"Authorization", String.Format("Bearer {0}", F.Token)},
		  {"chave_feam", F.Chave}}

		  Dim Postagem As StringContent = New StringContent(Dic.ToString, Encoding.UTF8, "application/json")

		  'chamando a classe p fazer a comunicacao e pegar a resposta
		  Using wbcli As New WebClient
			With wbcli
			   .Headers.Add("Authorization", Dic.Values(0))
			   .Headers.Add("chave_feam", Dic.Values(1))
			   .Headers.Add(HttpRequestHeader.Accept, "application/json") ' deve aceitar estes dados do cabelario formt json
			End With

			Dim GetBytes = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(Dic))
			Dim Upar = wbcli.UploadData(Url, "POST", GetBytes)
			Dim GetResponse = Encoding.UTF8.GetString(Upar)

			Lista_RetornaListaTecnologia = JsonConvert.DeserializeObject(Of List(Of RetornaListaTecnologia))(GetResponse)

			Using Streawriter As New StreamWriter(Application.StartupPath & "\RetornaListaTecnologia.json")
			   Streawriter.WriteLine(GetResponse)
			End Using
		  End Using
	    End Using

	 Catch ex As Exception
	    MsgBox("Erro encontrado: " & ex.Message.ToString)
	    If ex.Message.ToString.Contains("401") Then
		  Exit Function
	    End If
	 End Try

	 Return Await Task.FromResult(Lista_RetornaListaTecnologia)

   End Function

End Class
