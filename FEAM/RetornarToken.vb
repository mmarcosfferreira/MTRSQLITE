Imports System.IO
Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json
Imports Principal.Configuracao

Public Class RetornarToken
   <JsonProperty("pessoaCodigo")>
   Public Property PessoaCodigo As Integer
   <JsonProperty("pessoaCnpj")>
   Public Property PessoaCnpj As String
   <JsonProperty("pessoaNome")>
   Public Property PessoaNome As String
   <JsonProperty("usuarioCodigo")>
   Public Property UsuarioCodigo As String
   <JsonProperty("usuarioNome")>
   Public Property UsuarioNome As String
   <JsonProperty("usuarioCpf")>
   Public Property UsuarioCpf As String
   <JsonProperty("token")>
   Public Property Token As String
   <JsonProperty("chave")>
   Public Property Chave As String
   <JsonProperty("senha")>
   Public Property Senha As String
   <JsonProperty("retornoCodigo")>
   Public Property RetornoCodigo As String
   <JsonProperty("retorno")>
   Public Property Retorno As String
   Public Property Lista As List(Of RetornarToken)

   Public Sub New(_PessoaCodigo As Integer,
								    _PessoaCnpj As String,
								    _PessoaNome As String,
								    _UsuarioCodigo As String,
								    _UsuarioNome As String,
								    _UsuarioCpf As String,
								    _Token As String,
								    _Chave As String,
								    _Senha As String,
								    _RetornoCodigo As String,
								    _Retorno As String)

	 PessoaCodigo = _PessoaCodigo
	 PessoaCnpj = _PessoaCnpj
	 PessoaNome = _PessoaNome
	 UsuarioCodigo = _UsuarioCodigo
	 UsuarioNome = _UsuarioNome
	 UsuarioCpf = _UsuarioCpf
	 Token = _Token
	 Chave = _Chave
	 Senha = _Senha
	 RetornoCodigo = _RetornoCodigo
	 Retorno = _Retorno
   End Sub

   Private CF = Carregar_Configuracao(Application.StartupPath & "/Configuracao.Json")
   Sub New()
   End Sub

#Region "sem usar o inicilizador de obj"
   'Dim Dic As New Dictionary(Of String, String)

   'Dic.Add("pessoaCodigo", PessoaCodigo)
   'Dic.Add("pessoaCnpj", PessoaCnpj)
   'Dic.Add("usuarioCpf", UsuarioCpf)
   'Dic.Add("senha", Senha)

#End Region
   Public Async Function GetTokenAsync() As Task

	 'Verificação de validação do certificado SSL para  ByPass(Desabilitar SSL) as vezes o site est em manutenção
	 System.Net.ServicePointManager.ServerCertificateValidationCallback = Function(se As Object, cert As System.Security.Cryptography.X509Certificates.X509Certificate, chain As System.Security.Cryptography.X509Certificates.X509Chain, sslerror As System.Net.Security.SslPolicyErrors) True

	 'Dim P As New FRMConfiguracaoFeam()
	 Dim URI = New Uri(CF.Item(0).Req.Gettoken)
	 Try
	    'com o inicializador/ body
	    Dim Dic As New Dictionary(Of String, String) From {
						    {"pessoaCodigo", PessoaCodigo},
						    {"pessoaCnpj", PessoaCnpj},
						    {"usuarioCpf", UsuarioCpf},
						    {"senha", Senha}
				    }
	    Dim parameters As String = JsonConvert.SerializeObject(Dic, Formatting.Indented)
	    Dim DadosPost = New System.Net.Http.StringContent(parameters.ToString, Encoding.UTF8, "application/json") 'Dados inseridos no Body da requisicao
	    Using client As New HttpClient()
		  Using Resposta As HttpResponseMessage = Await client.PostAsync(URI, DadosPost)
			Dim Resultado As String = Resposta.Content.ReadAsStringAsync().Result 'le o conteudo da pagia
			If Resposta.IsSuccessStatusCode Then
			   Dim T = Await Resposta.Content.ReadAsStringAsync

			   Using SW = New StreamWriter(Application.StartupPath & "\ChaveToken.json")
				 SW.WriteLine(T)
			   End Using

			   Lista = New List(Of RetornarToken) From {
											   JsonConvert.DeserializeObject(Of RetornarToken)(T)
									   }
			   'atribuo aminha classe os valores deserializados
			   PessoaCodigo = Lista.Item(0).PessoaCodigo
			   PessoaCnpj = Lista.Item(0).PessoaCnpj
			   PessoaNome = Lista.Item(0).PessoaNome
			   UsuarioCodigo = Lista.Item(0).UsuarioCodigo
			   UsuarioNome = Lista.Item(0).UsuarioNome
			   UsuarioCpf = Lista.Item(0).UsuarioCpf
			   Token = Lista.Item(0).Token
			   Chave = Lista.Item(0).Chave
			   Senha = Lista.Item(0).Senha
			   RetornoCodigo = Lista.Item(0).RetornoCodigo
			   Retorno = Lista.Item(0).Retorno
			End If
		  End Using
	    End Using
	 Catch ex As Exception
	    MsgBox(ex.Message.ToString)
	 End Try

	 'Restaura achecagem do certificado ssl
	 System.Net.ServicePointManager.ServerCertificateValidationCallback = Nothing
   End Function
End Class
