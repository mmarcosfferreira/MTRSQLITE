Imports System.IO
Imports System.Net
Imports System.Text
Imports Tulpep.NotificationWindow.PopupNotifier
'Imports Newtonsoft.Json.Linq

Public Class Internet
   Private myHost
   Private Shared CT As New Control
   Dim retornoConsulta As Boolean = True
   Private Shared paginaHTML As String = ""
   Private _Retorno As String = ""

   Sub New()
   End Sub
   Public Function Endereço_de_Ip_local()

	 Dim myHost As String = System.Net.Dns.GetHostName
	 Dim myIPs As System.Net.IPHostEntry = System.Net.Dns.GetHostEntry(myHost)

	 Dim ip As String = ""

	 For Each myIP As System.Net.IPAddress In myIPs.AddressList

	    ip = myIP.ToString
	 Next
	 Return ip
   End Function

   Public Function Endereço_de_Host()
	 myHost = System.Net.Dns.GetHostName
	 Dim myIPs As System.Net.IPHostEntry = System.Net.Dns.GetHostEntry(myHost)
	 Return myHost
   End Function

   Public Shared Async Function FTP_Upload(DirArquivo As String,
							   SiteFTP As String,
							   Usuario As String,
							   Senha As String,
							   Optional CT_paraNotificar As Control = Nothing) As Task

	 Try
	    DirArquivo = DirArquivo
	    SiteFTP = SiteFTP
	    Usuario = Usuario
	    Senha = Senha
	    Dim request_ As System.Net.FtpWebRequest
	    Dim X As New FrmMTR
	    Dim Info6 As New Notifyicone_PopupNotifier

	    ' faz uma requisição web
	    request_ = DirectCast(System.Net.WebRequest.Create(SiteFTP),
		  System.Net.FtpWebRequest)

	    'DirectCast(System.Net.WebRequest.Create(SiteFTP & "/" &
	    'System.Path.GetFileName(Arquivo)),
	    'System.Net.FtpWebRequest)
	    request_.AuthenticationLevel = Security.AuthenticationLevel.MutualAuthRequested
	    request_.Proxy = Nothing
	    request_.Credentials = New System.Net.NetworkCredential(Usuario, Senha)
	    request_.Method = WebRequestMethods.Ftp.UploadFile
	    request_.ReadWriteTimeout = 30000
	    request_.UsePassive = True
	    request_.UseBinary = True  'xxx

	    'Ler arquivo local  
	    Dim file_() As Byte = File.ReadAllBytes(DirArquivo) 'salva todos os bytes obtidos em um array
	    'Escreve no destino
	    Dim stream_ As System.IO.Stream = Await request_.GetRequestStreamAsync

	    'aqui pode fazer a validação para sobreescrever no arquivo se o arquivo for maior q a do servidor
	    stream_.Write(file_, 0, file_.Length)
	    stream_.Close()

	    ' Dim Response = DirectCast(request_.GetResponse(), System.Net.FtpWebResponse)
	    Dim Response = DirectCast(Await request_.GetResponseAsync, System.Net.FtpWebResponse)

	    Using info4 As New FrmMTR
		  'Cria uma instancia do formulario mtr para acesar suas propriedades e métodos
		  'define as características para mensagem no balão
		  Dim Mensagemm As String = "Banco de dados Salvo na Nuvem com sucesso! Upload da transferência Concluído! " &
				"Informações do servidor:" & Chr(13) & Response.StatusDescription

		  Dim Titulo As String = Chr(9) & "      Transferencia concluída"
		  'Dim Texto_associado_ao_Controle As String = ""
		  CT_paraNotificar = CT
		  'exibe o balão
		  Info6.Notifyicone_PopupNotifier(Mensagemm, Titulo, 1200, CT)
		  'Await Task.Delay(2000)
	    End Using
	    Await Task.Delay(10000) '400
	 Catch ex As Exception
	    Using pa As New FrmMTR
		  '  MsgBox("Ocorreu um, erro ao tentar subir os dados para o Servidor FTP! Detalhes:   " & ex.Message)
		  info6.Notifyicone_PopupNotifier("   Ocorreu uma excepção...ao fazer a transferencia em Upload" & "        Detalhes: " & ex.Message.ToString, "       Ocorreu um Erro", 2000, CT)
	    End Using
	 Finally
	 End Try
   End Function


   ''' <summary>
   ''' usando um servidor FTP
   ''' </summary>
   ''' <param name="Caminho"></param>
   ''' <param name="SiteFTP"></param>
   ''' <param name="Usuario"></param>
   ''' <param name="Senha"></param>
   Public Shared Async Function FTP_Dowload(Caminho As String, SiteFTP As String, Usuario As String, Senha As String) As Task

	 Dim info3 As New Notifyicone_PopupNotifier
	 Dim X As New FrmMTR

	 Try
	    ' faz uma requisição web
	    Dim request_ As System.Net.FtpWebRequest = DirectCast(System.Net.WebRequest.Create(SiteFTP), System.Net.FtpWebRequest)
	    request_.AuthenticationLevel = Security.AuthenticationLevel.MutualAuthRequired
	    request_.Proxy = Nothing
	    request_.Credentials = New System.Net.NetworkCredential(Usuario, Senha)
	    request_.Method = WebRequestMethods.Ftp.DownloadFile
	    request_.UsePassive = True
	    request_.ReadWriteTimeout = 300000

	    'request_.Proxy = CByte("queirozgalvao.com.br:8080")
	    Dim Response = DirectCast(Await request_.GetResponseAsync, System.Net.FtpWebResponse) ' transforma a var em um objeto de resposta do servidor
	    Dim R = Response.GetResponseStream 'guarda na var R o conteúdo. usando o método de pegar conteudo do fluxo

	    Using MemoryStream = New MemoryStream()
		  Await R.CopyToAsync(MemoryStream) ''R.CopyTo (MemoryStream)
		  Dim ConteudodoArquivo = MemoryStream.ToArray
		  File.WriteAllBytes(Caminho, ConteudodoArquivo)
	    End Using

	    Await Task.Delay(1000)

	    Dim Mensagem As String = "   Banco de dados carregado do servidor corretamente!! " & Chr(13) & "-------Transferência Concluída com êxito-------" & Chr(13) &
		  "Informações do servidor: " & Response.StatusDescription

	    Dim Titulo As String = Chr(9) & "     Transferencia concluída"
	    Dim Texto_associado_ao_Controle As String = Nothing
	    CT = X.BTsalvarMtr

	    'exibe o balão
	    Await Task.Delay(1000)
	    ' info3.Notifyicone_PopupNotifier(M, Titulo, 2, CT)
	    '  MsgBox(M, MsgBoxStyle.Information, Titulo)
	    Await Task.Delay(5000)
	    'Response.Close()
	    info3.Notifyicone_PopupNotifier(Mensagem & vbNewLine, Titulo, 1000, CT)
	    Response.Close()
	    Await Task.CompletedTask
	 Catch ex As Exception
	 End Try

   End Function

   Public Property Retorno As String
	 Get
	    Return _Retorno
	 End Get
	 Set
	    _Retorno = Value
	 End Set
   End Property

   ''' <summary>
   ''' Usa uma API para retornar dados de uma CNPJ
   ''' </summary>
   ''' <param name="cnpj"></param>
   ''' <param name="CTLRetorno"></param>
   Public Sub PCnpj(cnpj As String, CTLRetorno As Control)

	 Try

	    Dim api As String = String.Format("https://www.receitaws.com.br/v1/cnpj/{0}", cnpj)
	    '  Dim api As String = String.Format("https://api.cnpja.com.br/companies/", cnpj).ToString


	    Dim api_key As String = "333d084f-c552-42cb-bd7c-2d2d804f5bde-80bb2355-0950-4539-8018-9734094e0424"

	    Using wc = New WebClient()

		  '  wc.Encoding = UTF8Encoding.UTF8
		  Retorno = wc.DownloadString(api)

		  Dim P As New DadosEmpresa
		  P.Salvar(Retorno, Application.StartupPath & "\" & "retorno.Json") '2º parametro é o local e o nome do arq q vou salvar

		  Retorno = System.IO.File.ReadAllText("retorno.Json", New UTF8Encoding)


	    End Using
	 Catch ex As Exception
	    MsgBox("Detalhes da excessão: " & ex.Message.ToString)
	 End Try

   End Sub
   Public Shared Sub Conexão_com_Rede(CTL As Object)
	 Try
	    If My.Computer.Network.Ping("www.google.com.br") = True Then
		  '  LblStatusdaRede.Text = "ON"
		  CTL.Text = "ON"
		  DirectCast(CTL, Control).ForeColor = Color.Green

	    Else

		  If My.Computer.Network.Ping("www.google.com.br") = False Then
			CTL.Text = "OF "
			DirectCast(CTL, Control).ForeColor = Color.Red
			Exit Sub
		  End If

	    End If

	 Catch ex As Exception

	 End Try
   End Sub


End Class
