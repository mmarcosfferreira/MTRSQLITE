'Imports System
'Imports System.Drawing
'Imports System.IO
'Imports System.Net
'Imports System.Text
'Imports System.Text.RegularExpressions
'Imports System.Windows.Forms

'Namespace DllConsultaCNPJ
'    Private Enum Coluna 'Public Enum Coluna
'        RazaoSocial
'        NomeFantasia
'        AtividadeEconomicaPrimaria
'        AtividadesEconomicasSecundarias
'        NumeroDaInscricao
'        MatrizFilial
'        NaturezaJuridica
'        SituacaoCadastral
'        DataSituacaoCadastral
'        MotivoSituacaoCadastral
'        Endereco
'        Numero
'        Bairro
'        Cidade
'        UF
'        Complemento
'        CEP
'        Telefone
'        Email
'        DataAbertura
'        EnteFederativoResponsavel
'        SituacaoEspecial
'        DataSituacaoEspecial
'        Cnae
'    End Enum

'    Private Class Empresa
'        Public Property CodEmresa As Integer
'        Public Property Cnpj As String
'        Public Property RazaoSocial As String
'        Public Property NomeFantasia As String
'        Public Property NaturezaJuridica As String
'        Public Property AtividadeEconomicaPrimaria As String
'        Public Property AtividadeEconomicaSecundaria As String
'        Public Property NumeroDaInscricao As String
'        Public Property MatrizFilial As String
'        Public Property SituacaoCadastral As String
'        Public Property DataSituacaoCadastral As String
'        Public Property MotivoSituacaoCadastral As String
'        Public Property Endereco As String
'        Public Property Numero As String
'        Public Property Bairro As String
'        Public Property Cidade As String
'        Public Property UF As String
'        Public Property CEP As String
'        Public Property Complemento As String
'        Public Property Cnae As String
'        Public Property Email As String
'        Public Property Telefones As String
'        Public Property DataAbertura As String
'        Public Property SituacaoEspecial As String
'        Public Property DataSituacaoEspecial As String
'        Public Property EnteFederativoResponsavel As String
'    End Class

'    Public Class ConsultaCNPJReceita
'        Shared Private ReadOnly _cookies As CookieContainer = New CookieContainer()
'        Shared Private urlBaseReceitaFederal As String = "http://www.receita.fazenda.gov.br/pessoajuridica/cnpj/cnpjreva/"
'        Shared Private paginaValidacao As String = "valida.asp"
'        Shared Private paginaPrincipal As String = "cnpjreva_solicitacao2.asp"
'        Shared Private paginaCaptcha As String = "captcha/gerarCaptcha.asp"
'        Shared Private paginaHTML As String = ""
'        Shared Public Empresa As Empresa = New Empresa()
'        Shared Public Mensagem As String = ""

'        Shared Public Function GetCaptcha(ByVal picLetras As PictureBox) As Boolean
'            Dim htmlResult As String = ""

'            Using wc = Nothing 'New CookieAwareWebClient()

'                Try
'                    picLetras.Image = Nothing
'                    wc.SetCookieContainer(_cookies)
'                    wc.Headers(HttpRequestHeader.UserAgent) = "Mozilla/4.0 (compatible; Synapse)"
'                    wc.Headers(HttpRequestHeader.KeepAlive) = "600"
'                    htmlResult = wc.DownloadString(urlBaseReceitaFederal & paginaPrincipal)
'                Catch __unusedException1__ As Exception
'                    Mensagem = "Não foi possível carregar a imagem de validação." & vbLf & "Serviço da Receita Federal fora do ar ou bloqueado. Tente novamente mais tarde"
'                    Return False
'                End Try
'            End Using

'            If htmlResult.Length > 0 Then
'                Dim wc2 = Nothing 'New CookieAwareWebClient()
'                wc2.SetCookieContainer(_cookies)
'                wc2.Headers(HttpRequestHeader.UserAgent) = "Mozilla/4.0 (compatible; Synapse)"
'                wc2.Headers(HttpRequestHeader.KeepAlive) = "300"
'                Dim data As Byte() = wc2.DownloadData(urlBaseReceitaFederal & paginaCaptcha)
'                Dim bit As Bitmap = New Bitmap(New MemoryStream(data))

'                If bit IsNot Nothing Then
'                    picLetras.Image = bit
'                    Return True
'                Else
'                    Mensagem = "Não foi possível carregar a imagem de validação. Tente novamente mais tarde"
'                    Return False
'                End If
'            Else
'                Return False
'            End If
'        End Function

'        Shared Public Function Consulta(ByVal aCNPJ As String, ByVal aCaptcha As String) As Boolean
'            aCNPJ = aCNPJ.Trim()
'            aCaptcha = aCaptcha.Trim()
'            If ValidaCampos(aCNPJ, aCaptcha) = False Then Return False
'            Dim retornoConsulta As Boolean = True
'            paginaHTML = ""
'            Dim request = CType(WebRequest.Create(urlBaseReceitaFederal & paginaValidacao), HttpWebRequest)
'            request.ProtocolVersion = HttpVersion.Version10
'            request.CookieContainer = _cookies
'            request.Method = "POST"
'            Dim postData As String = ""
'            postData = postData & "origem=comprovante&"
'            postData = postData & "cnpj=" & New Regex("[^\d]").Replace(aCNPJ, String.Empty) & "&"
'            postData = postData & "txtTexto_captcha_serpro_gov_br=" & aCaptcha & "&"
'            postData = postData & "submit1=Consultar&"
'            postData = postData & "search_type=cnpj"
'            Dim byteArray As Byte() = Encoding.UTF8.GetBytes(postData)
'            request.ContentType = "application/x-www-form-urlencoded"
'            request.ContentLength = byteArray.Length
'            Dim retorno As String = ""

'            Try
'                Dim dataStream As Stream = request.GetRequestStream()
'                dataStream.Write(byteArray, 0, byteArray.Length)
'                dataStream.Close()
'                Dim response As WebResponse = request.GetResponse()
'                Dim stHtml As StreamReader = New StreamReader(response.GetResponseStream(), Encoding.GetEncoding("ISO-8859-1"))
'                retorno = stHtml.ReadToEnd()
'            Catch __unusedException1__ As Exception
'                retornoConsulta = False
'                Mensagem = "Não foi possível consultar o CNPJ." & vbLf & "Serviço da Receita Federal fora do ar ou bloqueado. Tente novamente mais tarde"
'            End Try

'            If retorno.Contains("Verifique se o mesmo foi digitado corretamente") Then
'                retornoConsulta = False
'                Mensagem = "O número do CNPJ não foi digitado corretamente"
'            End If

'            If retorno.Contains("Erro na Consulta") Then
'                retornoConsulta = False
'                Mensagem = "Os caracteres digitados não correspondem com a imagem"
'            End If

'            If retornoConsulta = True AndAlso RecuperaColunaValor(retorno, Coluna.RazaoSocial) = "" Then
'                retornoConsulta = False
'                Mensagem = "Não foi possível recuperar os dados. Verifique os dados digitados e Tente novamente"
'            End If

'            If retornoConsulta = True Then
'                paginaHTML = retorno
'                Empresa = New Empresa()
'                Empresa.Cnpj = aCNPJ
'                Empresa.RazaoSocial = RecuperaColunaValor(paginaHTML, Coluna.RazaoSocial)
'                Empresa.NomeFantasia = RecuperaColunaValor(paginaHTML, Coluna.NomeFantasia)
'                Empresa.NaturezaJuridica = RecuperaColunaValor(paginaHTML, Coluna.NaturezaJuridica)
'                Empresa.AtividadeEconomicaPrimaria = RecuperaColunaValor(paginaHTML, Coluna.AtividadeEconomicaPrimaria)
'                Empresa.AtividadeEconomicaSecundaria = RecuperaColunaValor(paginaHTML, Coluna.AtividadesEconomicasSecundarias)
'                Empresa.NumeroDaInscricao = RecuperaColunaValor(paginaHTML, Coluna.NumeroDaInscricao)
'                Empresa.MatrizFilial = RecuperaColunaValor(paginaHTML, Coluna.MatrizFilial)
'                Empresa.SituacaoCadastral = RecuperaColunaValor(paginaHTML, Coluna.SituacaoCadastral)
'                Empresa.DataSituacaoCadastral = RecuperaColunaValor(paginaHTML, Coluna.DataSituacaoCadastral)
'                Empresa.MotivoSituacaoCadastral = RecuperaColunaValor(paginaHTML, Coluna.MotivoSituacaoCadastral)
'                Empresa.Endereco = RecuperaColunaValor(paginaHTML, Coluna.Endereco)
'                Empresa.Numero = RecuperaColunaValor(paginaHTML, Coluna.Numero)
'                Empresa.Bairro = RecuperaColunaValor(paginaHTML, Coluna.Bairro)
'                Empresa.Cidade = RecuperaColunaValor(paginaHTML, Coluna.Cidade)
'                Empresa.CEP = RecuperaColunaValor(paginaHTML, Coluna.CEP)
'                Empresa.UF = RecuperaColunaValor(paginaHTML, Coluna.UF)
'                Empresa.Complemento = RecuperaColunaValor(paginaHTML, Coluna.Complemento)
'                Empresa.Email = RecuperaColunaValor(paginaHTML, Coluna.Email)
'                Empresa.Telefones = RecuperaColunaValor(paginaHTML, Coluna.Telefone)
'                Empresa.Cnae = RecuperaColunaValor(paginaHTML, Coluna.Cnae)
'                Empresa.DataAbertura = RecuperaColunaValor(paginaHTML, Coluna.DataAbertura)
'                Empresa.EnteFederativoResponsavel = RecuperaColunaValor(paginaHTML, Coluna.EnteFederativoResponsavel)
'                Empresa.SituacaoEspecial = RecuperaColunaValor(paginaHTML, Coluna.SituacaoEspecial)
'                Empresa.DataSituacaoEspecial = RecuperaColunaValor(paginaHTML, Coluna.DataSituacaoEspecial)
'            End If

'            Return retornoConsulta
'        End Function

'        Shared Public Function ValidaCampos(ByVal aCNPJ As String, ByVal aCaptcha As String) As Boolean
'            Dim erro As String = ""
'            If IsCnpj(aCNPJ) = False Then erro += "CNPJ não informado corretamente" & vbLf
'            If aCaptcha.Length <> 6 Then erro += "Caracteres não informados corretamente" & vbLf

'            If erro.Length > 0 Then
'                Mensagem = erro
'                Return False
'            Else
'                Return True
'            End If
'        End Function

'        Shared Private Function IsCnpj(ByVal cnpj As String) As Boolean
'            Dim multiplicador1 As Integer() = New Integer(11) {5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2}
'            Dim multiplicador2 As Integer() = New Integer(12) {6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2}
'            Dim soma, resto As Integer
'            Dim digito, tempCnpj As String
'            cnpj = cnpj.Trim()
'            cnpj = cnpj.Replace(".", "").Replace("-", "").Replace("/", "").Replace(" ", "")

'            If cnpj.Length <> 14 Then
'                Return False
'            Else
'                tempCnpj = cnpj.Substring(0, 12)
'                soma = 0

'                For i As Integer = 0 To 12 - 1
'                    soma += Integer.Parse(tempCnpj(i).ToString()) * multiplicador1(i)
'                Next

'                resto = (soma Mod 11)

'                If resto < 2 Then
'                    resto = 0
'                Else
'                    resto = 11 - resto
'                End If

'                digito = resto.ToString()
'                tempCnpj = tempCnpj & digito
'                soma = 0

'                For i As Integer = 0 To 13 - 1
'                    soma += Integer.Parse(tempCnpj(i).ToString()) * multiplicador2(i)
'                Next

'                resto = (soma Mod 11)

'                If resto < 2 Then
'                    resto = 0
'                Else
'                    resto = 11 - resto
'                End If

'                digito = digito & resto.ToString()
'                Return cnpj.EndsWith(digito)
'            End If
'        End Function

'        Private Shared Function RecuperaColunaValor(ByVal pattern As String, ByVal col As Coluna) As String
'            Dim S As String = pattern.Replace(vbLf, "").Replace(vbTab, "").Replace(vbCr, "")

'            Select Case col
'                Case Coluna.RazaoSocial
'                    S = StringEntreString(S, ">NOME EMPRESARIAL<")
'                    S = StringEntreString(S, "<b>", "</b>")
'                    Return S.Trim()
'                Case Coluna.NomeFantasia
'                    S = StringEntreString(S, ">TÍTULO DO ESTABELECIMENTO (NOME DE FANTASIA)<")
'                    S = StringEntreString(S, "<b>", "</b>")
'                    Return S.Trim()
'                Case Coluna.NaturezaJuridica
'                    S = StringEntreString(S, ">CÓDIGO E DESCRIÇÃO DA NATUREZA JURÍDICA<")
'                    S = StringEntreString(S, "<b>", "</b>")
'                    Return S.Trim()
'                Case Coluna.AtividadeEconomicaPrimaria
'                    S = StringEntreString(S, ">CÓDIGO E DESCRIÇÃO DA ATIVIDADE ECONÔMICA PRINCIPAL<")
'                    S = StringEntreString(S, "<b>", "</b>")
'                    Return S.Trim()
'                Case Coluna.AtividadesEconomicasSecundarias
'                    S = StringEntreString(S, "ATIVIDADE ECONOMICA SECUNDARIA", "Fim Linha ATIVIDADE ECONOMICA SECUNDARIA")

'                    Dim regex As Regex = New Regex("\s * | * \s", RegexOptions.IgnoreCase Or RegexOptions.Compiled)
'                    Dim listaAtividades As String() = Regex.Split(S, "<br>")
'                    Dim atividades As String = ""

'                    For Each item In Regex.Split(S, "<br>")
'                        S = StringEntreString(item, "<b>", "</b>")
'                        If S <> "" Then atividades = atividades & Environment.NewLine & (regex.Replace(S, " ")).Trim()
'                    Next

'                    Return atividades.Trim()
'                Case Coluna.NumeroDaInscricao
'                    S = StringEntreString(S, ">NÚMERO DE INSCRIÇÃO<")
'                    S = StringEntreString(S, "<b>", "</b>")
'                    Return S.Trim()
'                Case Coluna.MatrizFilial
'                    S = StringEntreString(S, ">NÚMERO DE INSCRIÇÃO<")
'                    S = StringEntreString(S, "</b>")
'                    S = StringEntreString(S, "<b>", "</b>")
'                    Return S.Trim()
'                Case Coluna.Endereco
'                    S = StringEntreString(S, ">LOGRADOURO<")
'                    S = StringEntreString(S, "<b>", "</b>")
'                    Return S.Trim()
'                Case Coluna.Numero
'                    S = StringEntreString(S, ">NÚMERO<")
'                    S = StringEntreString(S, "<b>", "</b>")
'                    Return S.Trim()
'                Case Coluna.Complemento
'                    S = StringEntreString(S, ">COMPLEMENTO<")
'                    S = StringEntreString(S, "<b>", "</b>")
'                    Return S.Trim()
'                Case Coluna.CEP
'                    S = StringEntreString(S, ">CEP<")
'                    S = StringEntreString(S, "<b>", "</b>")
'                    Return S.Trim()
'                Case Coluna.Bairro
'                    S = StringEntreString(S, ">BAIRRO/DISTRITO<")
'                    S = StringEntreString(S, "<b>", "</b>")
'                    Return S.Trim()
'                Case Coluna.Cidade
'                    S = StringEntreString(S, ">MUNICÍPIO<")
'                    S = StringEntreString(S, "<b>", "</b>")
'                    Return S.Trim()
'                Case Coluna.UF
'                    S = StringEntreString(S, ">UF<")
'                    S = StringEntreString(S, "<b>", "</b>")
'                    Return S.Trim()
'                Case Coluna.SituacaoCadastral
'                    S = StringEntreString(S, ">SITUAÇÃO CADASTRAL<")
'                    S = StringEntreString(S, "<b>", "</b>")
'                    Return S.Trim()
'                Case Coluna.DataSituacaoCadastral
'                    S = StringEntreString(S, ">DATA DA SITUAÇÃO CADASTRAL<")
'                    S = StringEntreString(S, "<b>", "</b>")
'                    Return S.Trim()
'                Case Coluna.MotivoSituacaoCadastral
'                    S = StringEntreString(S, ">MOTIVO DE SITUAÇÃO CADASTRAL<")
'                    S = StringEntreString(S, "<b>", "</b>")
'                    Return S.Trim()
'                Case Coluna.Email
'                    S = StringEntreString(S, ">ENDEREÇO ELETRÔNICO<")
'                    S = StringEntreString(S, "<b>", "</b>")
'                    Return S.Trim()
'                Case Coluna.SituacaoEspecial
'                    S = StringEntreString(S, ">SITUAÇÃO ESPECIAL<")
'                    S = StringEntreString(S, "<b>", "</b>")
'                    Return S.Trim()
'                Case Coluna.DataSituacaoEspecial
'                    S = StringEntreString(S, ">DATA DA SITUAÇÃO ESPECIAL<")
'                    S = StringEntreString(S, "<b>", "</b>")
'                    Return S.Trim()
'                Case Coluna.EnteFederativoResponsavel
'                    S = StringEntreString(S, ">ENTE FEDERATIVO RESPONSÁVEL (EFR)<")
'                    S = StringEntreString(S, "<b>", "</b>")
'                    Return S.Trim()
'                Case Coluna.DataAbertura
'                    S = StringEntreString(S, ">DATA DE ABERTURA<")
'                    S = StringEntreString(S, "<b>", "</b>")
'                    Return S.Trim()
'                Case Coluna.Telefone
'                    S = StringEntreString(S, ">TELEFONE<")
'                    S = StringEntreString(S, "<b>", "</font>")
'                    Return S.Trim()
'                Case Coluna.Cnae
'                    S = StringEntreString(S, ">CÓDIGO E DESCRIÇÃO DA ATIVIDADE ECONÔMICA PRINCIPAL<")
'                    S = StringEntreString(S, "<b>", " - ")
'                    Return S.Trim()
'                Case Else
'                    Return S
'            End Select
'        End Function

'        Private Shared Function StringEntreString(ByVal Texto As String, ByVal StrInicio As String, ByVal Optional StrFinal As String = "") As String
'            Try
'                Dim Ini, Fim, Diff As Integer
'                Ini = Texto.IndexOf(StrInicio)
'                If Ini = -1 Then Return ""
'                Fim = Texto.IndexOf(StrFinal, Ini)
'                If Ini = Fim OrElse Fim = -1 Then Fim = Texto.Length
'                If Ini > 0 Then Ini = Ini + StrInicio.Length
'                If Fim > 0 Then Fim = Fim + StrFinal.Length
'                Diff = ((Fim - Ini) - StrFinal.Length)

'                If (Fim > Ini) AndAlso (Diff > 0) Then
'                    Return Texto.Substring(Ini, Diff)
'                Else
'                    Return ""
'                End If

'            Catch __unusedException1__ As Exception
'                Return ""
'            End Try
'        End Function
'    End Class
'End Namespace
