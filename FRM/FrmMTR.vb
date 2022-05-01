Imports Newtonsoft.Json
Imports Principal.Configuracao
Imports System.Data.SQLite
Imports System.Runtime.InteropServices

Public Class FrmMTR

   Public _jjj As New FRMConfigurar_banco_de_Dados
   Public _info5 As New Notifyicone_PopupNotifier
   Public _Lvi_Observação As New AutoCompleteStringCollection
   Public _DialogResult As DialogResult
   Private _Cont As Integer = 0

   Private _ConfigFeam As New Configuracao
   Private _RetornaToken_ As New RetornarToken
   Private _FRMconfigFeam As New FRMConfiguracaoFeam

   Private _RetornarManifestar As New retornaManifesto
   Private _RetornaListaClasse As New retornaListaClasse
   Private _RetornaListaResiduo As New RetornaListaResiduo
   Private _RetornaListaUnidade As New RetornaListaUnidade
   Private _RetornaListaTecnologia As New RetornaListaTecnologia
   Private _RetornaListaEstadoFisico As New RetornaListaEstadoFisico
   Private _RetornaListaAcondicionamento As New RetornaListaAcondicionamento
   Private _ManifestoRecebimentoJSON As New ManifestoRecebimentoJSON()
   Private _ItemManifestoRecebimentoJSONs As New List(Of ItemManifestoRecebimentoJSON)

   Sub New()
	 InitializeComponent()
	 My.Settings.Reload()
	 'Verificação de validação do certificado SSL para  ByPass(Desabilitar SSL) as vezes o site est em manutenção
	 System.Net.ServicePointManager.ServerCertificateValidationCallback = Function(se As Object, cert As System.Security.Cryptography.X509Certificates.X509Certificate, chain As System.Security.Cryptography.X509Certificates.X509Chain, sslerror As System.Net.Security.SslPolicyErrors) True
   End Sub

   Private Async Function ADICIONAR() As Task

	 Dim CF = Configuracao.Carregar_Configuracao(Application.StartupPath & "\Configuracao.json")
	 Dim L As New CadMTR("BDVITAL.db")
	 Dim MTR As String = TXTmtr.Text
	 Dim MTR_ParteA As String = ""
	 Dim MTR_ParteB As String = ""
	 Dim DataHora As Date
	 DataHora = Now
	 TXTdataHora.Text = DataHora

	 If TXTmtr.Text.Length = 10 Or TXTmtr.Text.Length = 34 Then
	    Select Case CF.Item(0).Modalidade_.RdbDesativado
		  Case True
			If Char.IsLetter(TXTmtr.Text) Then
			   MsgBox("Neste campo não é permitido letras!", MsgBoxStyle.Critical, "Cuidado!")
			   TXTmtr.Focus()
			   Exit Function
			End If

			If VALIDARENTRADA.VALIDARENTRADA(TXTmtr) = True Then Exit Select
			If VALIDARENTRADA.VALIDARENTRADA(TXTdataHora) = True Then Exit Select

			If CF.Item(0).LeitorCodigoBarras.ReceberMtr10Dig Then
			   MTR_ParteA = MTR.Substring(0, 10)
			   MTR_ParteB = MTR.Substring(10, 24)
			Else
			   If CF.Item(0).LeitorCodigoBarras.ReceberMtr34Dig = True Then
				 MTR_ParteA = MTR.Substring(0, 10)
				 MTR_ParteB = MTR.Substring(10, 24)
			   End If
			End If

			If CF.Item(0).LeitorCodigoBarras.ReceberMtr10Dig = True Then
			   L.Mtr = MTR_ParteA
			   L.DataHora = TXTdataHora.Text
			   L.OP_ENTRADA = UsuarioLogado2()
			   L.Observacao = MTR_ParteB

			Else
			   L.Mtr = MTR_ParteA
			   L.DataHora = TXTdataHora.Text
			   L.OP_ENTRADA = UCase(UsuarioLogado2())
			   L.Observacao = MTR_ParteB
			End If

			Try
			   If TXTmtr.Text.Substring(29, 5) = DestinadorLocal.Text Then
				 If Await L.Adicionar = True Then

				    DGVdados.DataSource = Await L.GetTabelaViaAdapterMtr("SELECT * FROM CAD_MTR ORDER BY CÓDIGO DESC limit 30")
				    _info5.Notifyicone_PopupNotifier(vbNewLine & vbNewLine & Chr(9) & "Registro Adicionado com êxito!", vbNewLine & Chr(9) & Chr(9) & "Atenção", 700, BTadicionarMtr)

				    TXTCodigo.Clear()
				    TXTobservacao.Clear()
				    TXTmtr.Clear()
				    TXTmtr.Focus()
				 Else
				    '--------se tem um numero na caixa txtMTR então pesquise antes de adicionar----
				    If L.Mtr > 0 Then
					  Dim Tabela As New DataTable
					  Using con As New SQLiteConnection("DATA SOURCE=" & Application.StartupPath & "\BD\" & "BDVITAL.db")
						con.Open()
						Using da As New SQLiteDataAdapter("select * from CAD_MTR WHERE MTR LIKE'" & L.Mtr & "%'", con)
						   da.Fill(Tabela)
						   DGVdados.DataSource = Tabela
						End Using
					  End Using
					  TXTmtr.SelectAll()
					  ' Principal.My.Resources.Resources.accept
				    End If
				 End If
			   Else
				 Application.DoEvents()
				 'For i As Integer = 0 To 1
				 MsgBox("Atenção! Destinador Inválido!" & vbCrLf & vbCrLf &
				 "Este manifesto não pode ser aceito!" & vbCrLf & vbCrLf &
				 "Favor entrar em contato com o Responsavel!" & vbCrLf & vbCrLf &
				 "Ou considere a troca do manifesto!", MsgBoxStyle.Exclamation, "CUIDADO!")

				 'Next
				 TXTmtr.SelectAll()
			   End If

			   TXTdataHora.Clear()
			   TXTobservacao.Clear()
			   TXTmtr.Focus()
			   Exit Select
			Catch ex As Exception
			   MsgBox(ex.Message, vbCritical, "Erro")
			End Try
		  Case Else
			Try
			   Select Case CF.Item(0).Modalidade_.RdbPessoaFisica
				 Case True
				    If CF.Item(0).LeitorCodigoBarras.ReceberMtr10Dig = True Then
					  MTR_ParteA = MTR.Substring(0, 10)
					  MTR_ParteB = MTR.Substring(10, 24)
				    Else
					  If CF.Item(0).LeitorCodigoBarras.ReceberMtr34Dig = True Then
						MTR_ParteA = MTR.Substring(0, 10)
						MTR_ParteB = MTR.Substring(10, 24)
					  End If
				    End If
				    L.Mtr = MTR_ParteA
				    L.OP_ENTRADA = UsuarioLogado2()
				    L.DataHora = TXTdataHora.Text
				    L.Observacao = MTR_ParteB

				    If txtmanifestoCodigo.Text <> "" And txtcodUnidadeDestinador.Text = TXTmtr.Text.Substring(29, 5) Then

					  If Await L.Adicionar = True Then
						DGVdados.DataSource = Await L.GetTabelaViaAdapterMtr("SELECT * FROM CAD_MTR ORDER BY CÓDIGO DESC limit 20")
						TXTCodigo.Clear()
						TXTobservacao.Clear()
						TXTmtr.Clear()
						TXTmtr.Focus()
						LimparResultados()

					  Else ''--------se ha um numero repetido vamos exibilo----

						If L.Mtr > 0 Then
						   Dim Mensagem As New FrmMTR
						   Dim Tabela As New DataTable
						   Dim Da As New SQLiteDataAdapter
						   Dim Comando As New SQLiteCommand
						   Dim Cn As New SQLiteConnection("Data Source=" & Application.StartupPath & "\BD\" & "BDVITAL.db")

						   Comando.Connection = Cn

						   Cn.Open()
						   Comando.CommandText = "select * from cad_mtr where MTR like'" & L.Mtr & "%'"
						   Comando.Parameters.AddWithValue("@MTR", L.Mtr)
						   Da = New SQLiteDataAdapter(Comando)
						   Da.Fill(Tabela)
						   DGVdados.DataSource = Tabela
						   Dim p As Object = MsgBox("Existe um registro com esses dados informados!" & Chr(13) & vbTab &
						   "Localizando registro!",
						   vbCritical,
						   "MarcosFerreira - Projetos T.I")
						   Threading.Tasks.Task.FromResult(p).Wait()

						   Cn.Close()
						   LimparResultados()
						   TXTmtr.Focus()
						   TXTmtr.SelectAll()
						End If
					  End If
				    Else
					  LimparResultados()
					  Dim Uri
					  Uri = CF.Item(0).Req.RetornaListaClasse

					  If CF.Item(0).Pessoa_fisica.CodigoUnidadePF = TXTmtr.Text.Substring(29, 5) Then
						Dim Lista_Classe As List(Of retornaListaClasse) = Await _RetornaListaClasse.PostRetornaListaClasse(Uri)

						Uri = CF.Item(0).Req.RetornaListaUnidade
						Dim Lista_Unidade As List(Of RetornaListaUnidade) = Await _RetornaListaUnidade.RetornaListaUnidade(Uri)

						Uri = CF.Item(0).Req.RetornaListaTecnologia
						Dim Lista_retornaListaTecnologia As List(Of RetornaListaTecnologia) = Await _RetornaListaTecnologia.retornaListaTecnologia(Uri)

						Uri = CF.Item(0).Req.RetornaListaEstadoFisico
						Dim Lista_RetornaListaEstadoFisico As List(Of RetornaListaEstadoFisico) = Await _RetornaListaEstadoFisico.RetornaListaEstadoFisico(Uri)

						Uri = CF.Item(0).Req.RetornaListaAcondicionamento
						Dim Lista_RetornaListaAcondicionamento As List(Of RetornaListaAcondicionamento) = Await _RetornaListaAcondicionamento.RetornaListaAcondicionamento(Uri)

						Uri = CF.Item(0).Req.RetornaListaResiduo
						Dim Lista_RetornaListaResiduo = Await _RetornaListaResiduo.RetornaListaResiduo(Uri)

						Uri = CF.Item(0).Req.RetornaManifesto & TXTmtr.Text
						Dim R = Await _RetornarManifestar.RetornaManifesto(Uri)

						txtmanifestoCodigo.Text = R.manifestoCodigo
						txtretornoCodigo.Text = R.retornoCodigo

						txtcnpGerador.Text = R.cnpGerador
						txtcodUnidadeGerador.Text = R.codUnidadeGerador

						txtcnpTransportador.Text = R.cnpTransportador
						txtcodUnidadeTransportador.Text = R.codUnidadeTransportador

						txtcnpDestinador.Text = R.cnpDestinador
						txtcodUnidadeDestinador.Text = R.codUnidadeDestinador

						txtcnpArmazenador.Text = R.cnpArmazenador
						txtcodUnidadeArmazenador.Text = R.codUnidadeArmazenador
						txtsituacaoManifestoCodigo.Text = R.situacaoManifestoCodigo

						'converter  ano/mes/dia para dia/mes/ano 
						'1 forma de conversao
						txtmanifDataExpedicao.Text = R.manifDataExpedicao.Substring(6, 2) & "/" & R.manifDataExpedicao.Substring(4, 2) & "/" & R.manifDataExpedicao.Substring(0, 4)

						'2 forma de conversao
						txtmanifData.Text = String.Format($"{{0}}/{{1}}/{{2}}", R.manifData.Substring(6, 2), R.manifData.Substring(4, 2), R.manifData.Substring(0, 4))

						txtmanifDataRecebimento.ForeColor = Color.Red
						txtmanifDataRecebimento.Text = If(R.manifDataRecebimento = Nothing,
													   $"{R.manifDataRecebimento}",
													   String.Format($"{{0}}/{{1}}/{{2}}",
													   R.manifDataRecebimento.Substring(6, 2),
													   R.manifDataRecebimento.Substring(4, 2),
													   R.manifDataRecebimento.Substring(0, 4)))


						txtmanifObservacao.Text = R.manifObservacao
						txtretorno.Text = R.retorno
						txtmanifGeradorNomeResponsavel.Text = R.manifGeradorNomeResponsavel
						txtcodigoSequencial.Text = R.itemManifestoJSONs.Item(0).codigoSequencial
						txtmanifGeradorCargoResponsavel.Text = R.manifGeradorCargoResponsavel
						txtjustificativa.Text = R.itemManifestoJSONs.Item(0).justificativa

						txtmanifTransportadorNomeMotorista.Text = R.manifTransportadorNomeMotorista
						txtcodigoInterno.Text = R.itemManifestoJSONs.Item(0).codigoInterno
						txtmanifTransportadorPlacaVeiculo.Text = R.manifTransportadorPlacaVeiculo
						txtquantidade.Text = R.itemManifestoJSONs.Item(0).quantidade

						txtmanifTransportadorDataExpedicao.Text = String.Format($"{{0}}/{{1}}/{{2}}", R.manifTransportadorDataExpedicao.Substring(6, 2), R.manifTransportadorDataExpedicao.Substring(4, 2), R.manifTransportadorDataExpedicao.Substring(0, 4))

						txtquantidadeRecebida.ForeColor = Color.Red
						txtquantidadeRecebida.Text = R.itemManifestoJSONs.Item(0).quantidadeRecebida

						txtresiduo.Text = R.itemManifestoJSONs.Item(0).residuo
						txtcodigoClasse.Text = R.itemManifestoJSONs.Item(0).codigoClasse
						txtcodigoAcondicionamento.Text = R.itemManifestoJSONs.Item(0).codigoAcondicionamento
						txtcodigoTipoEstado.Text = R.itemManifestoJSONs.Item(0).codigoTipoEstado
						txtcodigoTecnologia.Text = R.itemManifestoJSONs.Item(0).codigoTecnologia
						txtcodigoUnidade.Text = R.itemManifestoJSONs.Item(0).codigoUnidade
						txtmanifestoItemObservacao.Text = R.itemManifestoJSONs.Item(0).manifestoItemObservacao
						txttipoDensidadeValor.Text = R.itemManifestoJSONs.Item(0).tipoDensidadeValor
						txtmanifestoItemCodInterno.Text = R.itemManifestoJSONs.Item(0).manifestoItemCodInterno
						txttipoDensidadeUnidade.Text = R.itemManifestoJSONs.Item(0).tipoDensidadeUnidade
						txtmanifestoItemCodInternoDestinador.Text = R.itemManifestoJSONs.Item(0).manifestoItemCodInternoDestinador
						txtnumeroONU.Text = R.itemManifestoJSONs.Item(0).numeroONU
						txtnomeEmbarque.Text = R.itemManifestoJSONs.Item(0).nomeEmbarque
						txtclasseDeRisco.Text = R.itemManifestoJSONs.Item(0).classeDeRisco
						txtgrupoEmbalagem.Text = R.itemManifestoJSONs.Item(0).grupoEmbalagem

						'	Listaclase
						Dim index0 = R.itemManifestoJSONs(0).codigoClasse
						Dim G As List(Of retornaListaClasse) = Lista_Classe.FindAll(Function(Z As retornaListaClasse) Z.TpclaCodigo = index0.ToString)
						txtClasseDescrição.Text = G.Item(0).TpclaDescricao

						'lista unidade
						Dim Item_ = R.itemManifestoJSONs(0).codigoUnidade
						Dim L1 As List(Of RetornaListaUnidade) = Lista_Unidade.FindAll(Function(N As RetornaListaUnidade) N.TpuniCodigo = Item_.ToString)
						txtUnidadeDescricao.Text = L1.Item(0).TpuniDescricao

						'lista tecnologia
						Dim Item0 = R.itemManifestoJSONs(0).codigoTecnologia
						Dim F As List(Of RetornaListaTecnologia) = Lista_retornaListaTecnologia.FindAll(Function(M As RetornaListaTecnologia) M.TipoCodigo = Item0.ToString)
						txtDescriçãoTecnologia.Text = F.Item(0).TipoDescricao

						'lista estado fisico
						Dim Item1 As String = R.itemManifestoJSONs(0).codigoTipoEstado
						Dim L4 As List(Of RetornaListaEstadoFisico) = Lista_RetornaListaEstadoFisico.FindAll(Function(A As RetornaListaEstadoFisico) A.TpestCodigo = Item1.ToString)
						txtDescricaoEstadoFisico.Text = L4.Item(0).TpestDescricao

						'Lista Acondicionamento
						Dim Item2 As String = R.itemManifestoJSONs(0).codigoAcondicionamento
						Dim L2 As List(Of RetornaListaAcondicionamento) = Lista_RetornaListaAcondicionamento.FindAll(Function(H As RetornaListaAcondicionamento) H.TipoCodigo = Item2.ToString)
						txtDescricaoAcondicionamento.Text = L2.Item(0).TipoDescricao

						txtretorno.Text = JsonConvert.DeserializeObject(Of retornaManifesto.RetornoCodigo_)(R.retornoCodigo)

						Select Case txtsituacaoManifestoCodigo.Text
						   Case "1"
							 txtSituacaoMTR.Text = "SALVO"
							 txtSituacaoMTR.ForeColor = Color.DarkGreen
						   Case "3"
							 txtSituacaoMTR.Text = "MTR RECEBIDO"
							 txtSituacaoMTR.ForeColor = Color.Red
						   Case "4"
							 txtSituacaoMTR.Text = "CANCELADO"
							 txtSituacaoMTR.ForeColor = Color.Red
						   Case "9"
							 txtSituacaoMTR.Text = "EM ARMAZENAMENTO TEMPOTARIO"
							 txtSituacaoMTR.ForeColor = Color.Yellow
						End Select

						Dim item3 As String = R.itemManifestoJSONs(0).residuo
						TreeView1.Nodes.Clear()

						Dim k As List(Of RetornaListaResiduo) = Lista_RetornaListaResiduo.FindAll(Function(V As RetornaListaResiduo) V.tpre3Numero = item3.ToString)

						TreeView1.Nodes.Add("Cod IBAMA: " & k.Item(0).tpre3Numero)
						TreeView1.Nodes.Add(k.Item(0).tpre2Numero)
						TreeView1.Nodes.Add(k.Item(0).tpre1Numero)

						TreeView1.Nodes.Item(0).Nodes.Add(k.Item(0).tpre3Descricao)
						TreeView1.Nodes.Item(1).Nodes.Add(k.Item(0).tpre2Descricao)
						TreeView1.Nodes.Item(2).Nodes.Add(k.Item(0).tpre1Descricao)

					  Else
						MsgBox("Destinador diferente do que" & vbNewLine & "está cadastrado em Configurações!" &
						vbNewLine & vbNewLine & "Atenção: MTR deve ser rejeitada!", MsgBoxStyle.Exclamation, "Atenção")
					  End If
				    End If
			   End Select
			Catch ex As Exception
			   MsgBox(ex.Message.ToString)
			   Exit Select
			End Try
	    End Select
	 End If
   End Function
   Private Sub BTadicionarMtr_Click(sender As Object, e As EventArgs) Handles BTadicionarMtr.Click
	 Dim T1 = New Threading.Thread(AddressOf ADICIONAR.Wait)
	 T1.Start()
   End Sub

   Private Sub TXTmtr_Leave(sender As Object, e As EventArgs) Handles TXTmtr.Leave

	 TXTdataHora.Text = Now.ToShortDateString & " " & Now.ToLongTimeString

	 If TXTmtr.Text.Length = 34 Then
	    Dim C As List(Of Configuracao) = Carregar_Configuracao(Application.StartupPath & "\Configuracao.json")
	    If C.Item(0).LeitorCodigoBarras.ReceberMtr34Dig = True And C.Item(0).Modalidade_.RdbPessoaFisica = True OrElse
	    C.Item(0).LeitorCodigoBarras.ReceberMtr34Dig = True And C.Item(0).Modalidade_.RdbPessoaFisica = True Then
		  Dim T1 = New Threading.Thread(AddressOf ADICIONAR.Wait)
		  T1.Start()
	    End If
	 End If

   End Sub

   ''' <summary>
   ''' Função para pegar o usuario logado namaquina
   ''' </summary>
   ''' <returns></returns>
   Public Shared Function UsuarioLogado2()
	 Dim ObjNetWork As Object = CreateObject("Wscript.network")
	 Dim j As Object = ObjNetWork.username()
	 UsuarioLogado2 = j
	 Return UsuarioLogado2
   End Function

#Region "FTP"

   'Await Task.Delay(3000)
   'Internet.FTP_Upload(Application.StartupPath & "\BD\BancoMTR.txt",
   '                   "ftp://files.000webhost.com/public_html/BancoMTR.txt",
   '                   "marcosferreiramf",
   '                   "Senha0789", BtMTRsalvar)
   'Await Task.Delay(200)



   ' Private Sub FrmMTR_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

   'If e.KeyValue = Keys.Escape AndAlso MessageBox.Show("Deseja SAIR da aplicação?", "Atenção", MessageBoxButtons.YesNo) = DialogResult.Yes Then

   '    Internet.FTP_Upload("C:\MTR\Principal\BD\BancoMTR.txt",
   '                        "ftp://ftpupload.net/htdocs/BancoMTR.txt",
   '                        "epiz_25111379",
   '                        "FERREIRAMARCOS")


   '    'Internet.FTP_Upload("C:\MTR\Principal\BD\Controle de Pesagem Manual.xlsm",
   '    '                    "ftp://ftpupload.net/htdocs/Controle de Pesagem Manual.xlsm",
   '    '                    "epiz_25111379",
   '    '                    "FERREIRAMARCOS")

   '    Dispose()
   '    e.Handled = True
   '    Exit Sub
   'End If

   'End Sub
#End Region
#Region "FTP"

   'Internet.FTP_Upload("C:\MTR\Principal\BD\BancoMTR.txt",
   '                            "ftp://ftpupload.net/htdocs/BancoMTR.txt",
   '                            "epiz_25111379",
   '                            "FERREIRAMARCOS")
   '====================================
   'Internet.FTP_Upload("C:\MTR\Principal\BD\BancoMTR.txt",
   '                            "ftp://files.000webhost.com/public_html/BancoMTR.txt",
   '                            "marcosferreiraa",
   '                            "Senha0789")
   '
   '
   ' Internet.FTP_Dowload("C:\MTR\Principal\BD\BancoMTR.txt",
   '"ftp://ftpupload.net/htdocs/BancoMTR.txt",
   '"epiz_25111379",
   '"FERREIRAMARCOS")
   '
   'Internet.FTP_Dowload(Application.StartupPath & "\BancoMTR.txt",
   '                            "ftp://files.000webhost.com/public_html/BancoMTR.txt",
   '                            "marcosferreiramf",
   '                            "Senha0789")
   '
   ' My.Settings.Reload()
   'If jjj.RadioButtonServer.Checked = True Then
   ' Public jjj As New FRMConfigurar_banco_de_Dados
   'Call SalvarOnline()
#End Region
   Private Function SeleccionarImpresora() As Boolean
	 Dim prtDialog As New PrintDialog
	 If prtDialog Is Nothing Then
	    prtDialog = New PrintDialog
	 End If

	 With prtDialog
	    .AllowPrintToFile = False
	    .AllowSelection = False
	    .AllowSomePages = False
	    .PrintToFile = False
	    .ShowHelp = False
	    .ShowNetwork = True

	    ' .PrinterSettings = prtDialog.Document

	    If .ShowDialog() = DialogResult.OK Then
		  ' .prtSettings = .PrinterSettings
	    Else
		  Return False
	    End If

	 End With

	 Return True
   End Function

   Public Sub COPIAR_BD_MTR()
#Region "Comentario Copiar"

	 'Try

	 '    If Directory.Exists(Application.StartupPath & "\BD_BKP") = False Then ' SE O DIRETORIO NÃO EXISTE

	 '        If MsgBox("Diretório não existe" & Chr(13) & "Deseja criar o diretório para Salvar o Banco de dados?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Informação Relevante!") = DialogResult.Yes Then
	 '            Dim directoryInfo = Directory.CreateDirectory(Application.StartupPath & "\BD_BKP")

	 '            If Not File.Exists(Application.StartupPath & "\BD_BKP\BancoMTR.txt") Then
	 '                ' File.Create(Application.StartupPath & "\BD_BKP\BancoMTR.txt")
	 '                File.Copy(Caminho, Application.StartupPath & "\BD_BKP\BancoMTR.txt")
	 '            End If
	 '        End If


	 '        'verifica se o arquivo na pasta de bkp existe e se ao mesmo tempo o seu tamnho é igual ao arquivo original do bd
	 '        'se for igual nesta dual condição
	 '    ElseIf File.Exists(Application.StartupPath & "\BD_BKP\BancoMTR.txt") AndAlso
	 '        FileLen(Application.StartupPath & "\BD\BancoMTR.txt") = FileLen(Application.StartupPath & "\BD_BKP\BancoMTR.txt") Then


	 '        File.Delete(Application.StartupPath & "\BD_BKP\BancoMTR.txt")
	 '        File.Copy(Caminho, Application.StartupPath & "\BD_BKP\BancoMTR.txt")



	 '    ElseIf File.Exists(Application.StartupPath & "\BD_BKP\BancoMTR.txt") AndAlso
	 '                          FileLen(Application.StartupPath & "\BD_BKP\BancoMTR.txt") = 0 Then

	 '        File.Delete(Application.StartupPath & "\BD_BKP\BancoMTR.txt")
	 '        File.Copy(Caminho, Application.StartupPath & "\BD_BKP\BancoMTR.txt")

	 '    Else

	 '        If Not File.Exists(Application.StartupPath & "\BD_BKP\BancoMTR.txt") Then
	 '            File.Create(Application.StartupPath & "\BD_BKP\BancoMTR.txt")

	 '        Else  'se o arq de bkp for meor que o arquivo principal de oprigem

	 '            If File.Exists(Application.StartupPath & "\BD_BKP\BancoMTR.txt") Then
	 '                File.Delete(Application.StartupPath & "\BD_BKP\BancoMTR.txt")
	 '                File.Copy(Caminho, Application.StartupPath & "\BD_BKP\BancoMTR.txt")

	 '            ElseIf FileLen(Application.StartupPath & "\BD_BKP\BancoMTR.txt") > FileLen(Application.StartupPath & "\BD\BancoMTR.txt") Then

	 '                If MsgBox("O arquivo de Bakup é maior que o arquivo de origem" & Chr(13) &
	 '                    "Abortando Operação!", MsgBoxStyle.Information + vbOKOnly, "Cuidado") _
	 '                     = DialogResult.OK Then
	 '                    Process.Start(Application.StartupPath & "\BD_BKP\")
	 '                End If

	 '            End If
	 '        End If
	 '    End If
	 'Catch ex As Exception
	 '    'MsgBox("Detalhes do erro: " & ex.Message.ToString)
	 'End Try

#End Region
   End Sub
   Private Sub BTN_Pesquisar_Click(sender As Object, e As EventArgs)
	 ValidarPesquisar()
   End Sub
   Sub ValidarPesquisar()
	 BTadicionarMtr.Enabled = False
	 BTsalvarMtr.Enabled = False
	 '	 BTdeletar.Enabled = False
	 BTcarregarMtr.Enabled = False
	 BTeditarMTR.Enabled = False
   End Sub
   Sub DesvalidarPesquisar()
	 BTadicionarMtr.Enabled = True
	 BTsalvarMtr.Enabled = True
	 ' BTdeletar.Enabled = True
	 BTcarregarMtr.Enabled = True
	 BTeditarMTR.Enabled = True
   End Sub


   Private Sub BtMTRcarregar_MouseEnter(sender As Object, e As EventArgs)
	 Ajuda_Tooltip(ToolTipMTR, BTcarregarMtr, "Carrega o banco de dados ou filtra quando há critério na caixa Texto 'MTR'")
   End Sub
   Private Sub BTN_editarMTR_MouseEnter(sender As Object, e As EventArgs)
	 Ajuda_Tooltip(ToolTipMTR, BTeditarMTR, "Faz alteração de registro!")
   End Sub
   Private Sub TXTmtr_MouseEnter(sender As Object, e As EventArgs) Handles TXTmtr.MouseEnter, TXTdataHora.MouseEnter, TXTobservacao.MouseEnter
	 Ajuda_Tooltip(ToolTipMTR, TXTmtr, "Digite o número da mTR")
   End Sub

   Private Sub TextBoxMTRdataHora_MouseEnter(sender As Object, e As EventArgs)
	 Ajuda_Tooltip(ToolTipMTR, TXTdataHora, "Digite o hora e data que o veículo deu início a pesagem")
   End Sub
   Private Sub TextBoxMTRobservação_MouseEnter(sender As Object, e As EventArgs)
	 Ajuda_Tooltip(ToolTipMTR, TXTobservacao, "Digite resumidamente o nome da Empresa")
   End Sub

#Region "FTPcoment"

   '================================================================================================================
   ' faz o dowload do banco de dados no servidor para a pasta raiz da aplicação

   'Internet.FTP_Dowload("C:\MTR\Principal\BD\BancoMTR.txt",
   '          "ftp://ftpupload.net/htdocs/BancoMTR.txt",
   '          "epiz_25111379",
   '          "FERREIRAMARCOS")
   '==============================================================================================================

   'Internet.FTP_Dowload(Application.StartupPath & "\BancoMTR.txt",
   '                            "ftp://files.000webhost.com/public_html/BancoMTR.txt",
   '                            "marcosferreiramf",
   '                            "Senha0789")
   '===============================================================================================================
#End Region

   Private Sub BTMEMORANDO_Click(sender As Object, e As EventArgs)
	 Checking_da_Instancia_aplicação.AbrirUmaInstanciadaAplicação()
	 With FRMmemorando
	    .ShowDialog()
	    Threading.Thread.Sleep(200)
	    .WindowState = FormWindowState.Maximized
	 End With

   End Sub
   Private Sub BTALTERADATA_Click(sender As Object, e As EventArgs)
	 If FrmAlterardataehora.Visible = False Then
	    FrmAlterardataehora.Show()
	 Else
	    Show()
	 End If
   End Sub
   Private Sub BunifuThinButtonconfig_MouseEnter(sender As Object, e As EventArgs)
	 Me.BackColor = Color.WhiteSmoke
   End Sub
   Private Sub BunifuThinButtonconfig_MouseLeave(sender As Object, e As EventArgs)
	 Me.BackColor = Color.WhiteSmoke
   End Sub
   Private Sub BTControlePesagemManual_Click(sender As Object, e As EventArgs)
	 If FRMControlePesagemManual_.Visible = False Then
	    FRMControlePesagemManual_.Visible = True
	 Else
	    If FRMControlePesagemManual_.Visible = True Then
		  FRMControlePesagemManual_.Visible = False
	    End If
	 End If
   End Sub
   Private Sub BtPesagemManual_Click(sender As Object, e As EventArgs)
	 Dim J = FrmEstimativaManual
	 If J Is Nothing Then
	    J.Show()
	 Else
	    J.Visible = True
	 End If
   End Sub
   Private Sub BTconfigBancodedados_Click(sender As Object, e As EventArgs)
	 My.Settings.Reload()
	 Dim unused = _jjj.ShowDialog()
	 _jjj.RadioButtonServer.Checked = My.Settings.Config_ini
   End Sub
   Private Sub NotifyIcone_MTR_DoubleClick(sender As Object, e As EventArgs) Handles NotifyIcone_MTR.DoubleClick
	 Close()
   End Sub
   'Private Sub NotifyIcone_MTR_BalloonTipClosed(sender As Object, e As EventArgs) Handles NotifyIcone_MTR.BalloonTipClosed
   '    Dim CONT As Integer
   '    For CONT = 0 To 100
   '        If CONT = 10 Then
   '            NotifyIcone_MTR.BalloonTipText = Nothing
   '            NotifyIcone_MTR.Visible = False
   '            If IsHandleCreated = False Then
   '                Close()
   '                Exit Sub
   '            Else
   '                Activate()
   '            End If
   '        End If
   '    Next
   '   End Sub
   Private Sub BtMTRcarregar_MouseEnter_1(sender As Object, e As EventArgs) Handles BTcarregarMtr.MouseEnter
	 Ajuda_Tooltip(ToolTipMTR, BTcarregarMtr, "Carrega o Banco de dados.")
   End Sub

   Public radiobuttonserver As New FRMConfigurar_banco_de_Dados
   Public radiobuttonLocalHost As New FRMConfigurar_banco_de_Dados
   ''' <summary>
   ''' Método que varre os controles para achar qual está em foco (criei como método de extensão já que ele pode ser bastante útil para todos os controles)
   '''Forma de Usar: formulario.ActiveControl.FindFocusedControl()
   ''' </summary>
   ''' <param name="control"></param>
   ''' <returns></returns>
   Public Shared Function FindFocusedControl(ByVal control As Control) As Control
	 Dim container = TryCast(control, IContainerControl)
	 While container IsNot Nothing
	    control = container.ActiveControl
	    container = TryCast(control, IContainerControl)
	 End While
	 Return control
   End Function

   Private Function Licenca() As DataTable
	 Dim Tabela As New DataTable
	 Using Con As New SQLiteConnection("DATA SOURCE =" & Application.StartupPath & "\BD\BDVITAL.db;")
	    Con.Open()
	    Dim retorno = False
	    Dim query As String = "SELECT * FROM CAD_LICENCA"
	    Using da As New SQLiteDataAdapter(query, Con)
		  da.Fill(Tabela)
	    End Using
	 End Using
	 Return Tabela
   End Function

   Private Sub BtVolume_Click(sender As Object, e As EventArgs) Handles BtVolume.Click
	 FrmVolumeWindows.Show()
	 FrmVolumeWindows.Activate()
   End Sub
   Private Sub MostrarToolStripMenuItem_Click(sender As Object, e As EventArgs)
	 With Me
	    .Location = New System.Drawing.Point(0, 0)
	    .Size = New System.Drawing.Point(1390, 1000)
	 End With
   End Sub

   Private Sub PadrãoToolStripMenuItem_Click(sender As Object, e As EventArgs)
	 With Me
	    ColocaFormularionoCentro(Me)
	    .Location = New System.Drawing.Point(0, 0)
	    .Size = New System.Drawing.Point(1000, 465)
	    '.WindowState = FormWindowState.Normal
	 End With
   End Sub

   ' Dim stopwatch As Stopwatch = Stopwatch.StartNew 'StartNew
   Dim LL As Integer = 1
   Private Sub Button2_Click_1(sender As Object, e As EventArgs)
	 End
   End Sub

#Region "PesqCNP"

   ' Public Function get_company(tax_id As Object)
   '' Coloque aqui sua Chave de API
   'Dim api_key As String
   'api_key = "333d084f-c552-42cb-bd7c-2d2d804f5bde-80bb2355-0950-4539-8018-9734094e0424"
   'Dim requests As Newtonsoft.Json.Schema.JsonSchema

   'Dim url As String
   'url = "https://api.cnpja.com.br/companies/" + tax_id 'TAXIDE = CNPJ
   'Dim headers = "Authorization:" & api_key
   'Dim response As New Object
   'Return requests.Id(response.text)

   ' End Function


   'Private Sub PesquisarCnpj_Click(sender As Object, e As EventArgs) Handles PesquisarCnpj.Click
   '    If TxtCNPJ.Text.Length <= 0 Then
   '        info5.Notifyicone_PopupNotifier("Neste campo não pode ficar vazio", "Buscar CNPJ", 10000, PesquisarCnpj)
   '        Return
   '    Else
   '        RichTextBox1.Visible = True
   '        BTSAIR.Visible = True
   '        PCnpj(TxtCNPJ.Text)
   '    End If
   'End Sub

   'Sub PCnpj(ByVal cnpj As String)


   '    Try
   '        Dim retorno As String = String.Empty
   '        Dim api As String = String.Format("https://www.receitaws.com.br/v1/cnpj/{0}", cnpj).ToString

   '        '  Dim api As String = String.Format("https://api.cnpja.com.br/companies/", cnpj).ToString

   '        Dim api_key As String
   '        api_key = "333d084f-c552-42cb-bd7c-2d2d804f5bde-80bb2355-0950-4539-8018-9734094e0424"

   '        Using wc As WebClient = New WebClient()
   '            retorno = wc.DownloadString(api)
   '        End Using

   '        'TRATAR RETORNO QUE ESTÁ BAGUNÇADO
   '        Encoding.Unicode.GetBytes(retorno).Clone()

   '        'EXIBE RETORNO
   '        RichTextBox1.Text = Chr(13) & retorno

   '        ' MessageBox.Show(retorno)
   '    Catch ex As Exception
   '        MsgBox("Detalhes da excessão: " & ex.Message.ToString)
   '    End Try

   'End Sub
#End Region

   Private Sub TXTmtr_GotFocus(sender As Object, e As EventArgs) Handles Me.GotFocus
	 TXTmtr.Focus()
   End Sub

   Dim Completar As AutoCompleteStringCollection = New AutoCompleteStringCollection
   Private Async Sub TextBoxMTRobservação_TextChanged(sender As Object, e As EventArgs)
	 TXTobservacao.SelectionStart = Len(TXTobservacao.Text)
	 TXTobservacao.Text = StrConv(TXTobservacao.Text, 3)
	 Await Task.Delay(200)
   End Sub
   Private Sub TextBoxMTRdataHora_Enter(sender As Object, e As EventArgs)
	 TXTdataHora.Text = Now
   End Sub

   Private Sub FrmMTR_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
	 If e.Alt And e.KeyCode = Keys.O Then
	    TXTobservacao.Focus()
	    TXTobservacao.SelectAll()
	 End If
   End Sub

   Private Sub FrmMTR_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
	 If e.KeyChar = Chr(43) Then '+
	    btnIncVol_Click(Me, e)
	 Else
	    If e.KeyChar = Chr(45) Then '-
		  btnDecVol_Click(Me, e)
	    Else
		  If e.KeyChar = Chr(42) Then '*
			btnMute_Click(Me, e)
		  End If
	    End If
	 End If
   End Sub
   Private Sub BTcontrole_de_Infratores_Click(sender As Object, e As EventArgs)
	 If Application.OpenForms.OfType(Of FrmInfratores)().Count() > 0 Then
	    Application.OpenForms.OfType(Of FrmInfratores)().First().Focus()
	 Else
	    Dim frmNomeDoForm As FrmInfratores = New FrmInfratores()
	    frmNomeDoForm.Show()
	 End If
   End Sub

   Private Sub BTMINIMIZAR_Click(sender As Object, e As EventArgs)
	 Me.WindowState = FormWindowState.Minimized
   End Sub

   Private Sub BTconfig_Click(sender As Object, e As EventArgs) Handles BTconfig.Click
	 Select Case Application.OpenForms.OfType(Of FRMopcoes).Count()
	    Case Is > 0
		  Application.OpenForms.OfType(Of Form)().First().Focus()
	    Case Else
		  FRMopcoes.Show()
	 End Select
   End Sub

   Private Async Sub BTdeletar_Click(sender As Object, e As EventArgs)
	 Dim L As New CadMTR("BDVITAL.db")

	 Try
	    Select Case L.Excluir(TXTCodigo.Text)
		  Case True
			_info5.Notifyicone_PopupNotifier(vbNewLine & vbNewLine & Chr(9) & "Registro deletado com êxito!", vbNewLine & Chr(9) & Chr(9) & "Atenção", 800, sender)
	    End Select

	 Catch ex As Exception
	    MsgBox(ex.Message, vbCritical, "Excepção")
	 End Try
	 'para carregar depois q deleta
	 DGVdados.DataSource = Await L.GetTabelaViaAdapterMtr("SELECT * FROM CAD_MTR ORDER BY CÓDIGO DESC limit 30")   '("select top 50 * from cad_mtr order by código DESC") '
	 TXTCodigo.Clear()
	 TXTdataHora.Clear()
	 TXTmtr.Focus()
	 '   DGVdados.CurrentCell = DGVdados.Rows(DGVdados.Rows.Count - 1).Cells(0)
   End Sub


   'CRIAR cabeçario
   Public Sub CabeçarioDGVdados()
	 DGVdados.ColumnHeadersVisible = True
	 DGVdados.Columns.Add("Código", "Código").ToString()
	 DGVdados.Columns.Add("MTR", "MTR").ToString()
	 DGVdados.Columns.Add("DATAHORA", "DATA HORA").ToString()
	 DGVdados.Columns.Add("OP_ENTRADA", "OP_ENTRADA").ToString()
	 DGVdados.Columns.Add("OBSERVACAO", "OBSERVACAO").ToString()
	 DGVdados.Columns.Add("GERADOR", "GERADOR") '%%%%%%%%%%%%%%%%%%%%%%%%%%
	 DGVdados.Columns.Add("TRANSPORTADOR", "TRANSPORTADOR").ToString()
	 DGVdados.Columns.Add("DESTINADOR", "DESTINADOR").ToString()
   End Sub


   Private Async Sub BTsalvarMtr_Click(sender As Object, e As EventArgs) Handles BTsalvarMtr.Click

	 Dim C = Internet.FTP_Upload(Application.StartupPath & "\BD\BDVITAL.db", "ftp://files.000webhost.com/public_html/BDVITAL.db", "marcosferreiramf", "Senha0789")
	 Await C


	 Dim D = Internet.FTP_Dowload(Application.StartupPath & "\BD\BDVITAL.db", "ftp://files.000webhost.com/public_html/BDVITAL.db", "marcosferreiramf", "Senha0789")
	 Await D


   End Sub
   Private Sub DGVdados_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DGVdados.CellValueChanged
	 Call BTeditarMTR_Click(DGVdados, e)
   End Sub


   Private Async Sub BTeditarMTR_Click(sender As Object, e As EventArgs)
	 Dim L As New CadMTR("BDVITAL.db")

	 Try
	    L.MTR = DGVdados.CurrentRow.Cells(1).Value 'TXTmtr.Text
	    L.DATAHORA = DGVdados.CurrentRow.Cells(2).Value 'TXTdataHora.Text
	    L.OP_ENTRADA = DGVdados.CurrentRow.Cells(3).Value   ' UsuarioLogado2()
	    L.OBSERVACAO = DGVdados.CurrentRow.Cells(4).Value.ToString '(TXTobservacao.Text)
	    L.CÓDIGO = DGVdados.CurrentRow.Cells(0).Value
	    If MsgBox("Deseja alterar o registro?", MsgBoxStyle.Exclamation + vbYesNo, "Atenção") = DialogResult.Yes Then

		  If Await L.Alterar = True Then
			_info5.Notifyicone_PopupNotifier(vbTab & vbCrLf & vbCr & vbCrLf & "        Registro atualizado com sucesso!", vbCrLf & vbTab & vbTab & "Atenção", 500, DGVdados)
			TXTmtr.Focus()
			Exit Sub
		  Else
			MsgBox("Problema ao atualizar registro!", vbCritical, "Erro")
			Exit Sub
		  End If

	    End If
	 Catch ex As Exception
	    MsgBox(ex.Message, vbCritical, "Erro")
	 End Try

   End Sub

   Private Async Sub BTcarregarMtr_Click(sender As Object, e As EventArgs) Handles BTcarregarMtr.Click
	 Dim L As New CadMTR("BDVITAL.db")
	 Dim Resp As String
	 Try
	    'em grandes bancos de dados, a instrução ORDER BY DESC realmente pode desacelerar o sistema. Uma boa abordagem para evitar ORDER BY é o comando OFFSET. E você ainda mantém a ordem armazenada:'DGVdados.DataSource = L.GetTabelaViaAdapter("SELECT * FROM CAD_MTR LIMIT 10 OFFSET(SELECT COUNT(*) FROM CAD_MTR) - 10")

	    DGVdados.DataSource = Await L.GetTabelaViaAdapterMtr("SELECT * FROM CAD_MTR ORDER BY CÓDIGO DESC limit 30")


	    If Licenca() IsNot Nothing And Licenca.Rows(0).ItemArray(1) = "LIBERADO" Then
		  Resp = "Olá " & UsuarioLogado2() & ". Você está " & Licenca.Rows(0).ItemArray(1) & " a acessar o sistema!"
	    Else
		  DesativarControles()
		  Resp = "Olá " & UsuarioLogado2() & ". Você está " & Licenca.Rows(0).ItemArray(1) & " a acessar o sistema!"
	    End If
	    lblComprimentar.Text = Resp
	 Catch ex As Exception
	    MsgBox(ex.Message, vbCritical, "Erro")
	 End Try
	 TXTmtr.Focus()

   End Sub

   Private Sub DesativarControles()
	 TXTCodigo.Enabled = False
	 TXTdataHora.Enabled = False

	 TXTmtr.Enabled = False
	 TXTobservacao.Enabled = False

	 BTadicionarMtr.Enabled = False
	 BTcarregarMtr.Enabled = False
	 'BTdeletar.Enabled = False
	 BTeditarMTR.Enabled = False
	 BTsalvarMtr.Enabled = False
	 BTconfig.Enabled = False
	 DGVdados.Enabled = False

   End Sub
   Private Async Sub FrmMTR_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

	 MsgBox("Salvando todas as alterações....." & vbCrLf & "Aguarde a conclusão do processo que pode durar até 30 segundos!", MsgBoxStyle.ApplicationModal, "Atenção!")

	 Await Internet.FTP_Upload(Application.StartupPath & "\BD\BDVITAL.db",
	 "ftp://files.000webhost.com/public_html/BDVITAL.db",
	 "marcosferreiramf",
	 "Senha0789")


	 Dim G = Internet.FTP_Dowload(Application.StartupPath & "\BD\BDVITAL.db",
																													"ftp://files.000webhost.com/public_html/BDVITAL.db",
																													"marcosferreiramf",
																													"Senha0789")
   End Sub
   Private Async Sub LinkAtualizar_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkAtualizar.LinkClicked

	 Dim L As New CadMTR("BDVITAL.db")
	 Dim P As Object = ImputBoxPersonalizado.InputBox_Personalizado("Atualizar a grade com quantos registros?.", vbTab & UCase(UsuarioLogado2()), BunifuCustomTextbox1.Text, False)

	 If P <> String.Empty And P <> "" And IsNumeric(P) Then

	    DGVdados.DataSource = Await L.GetTabelaViaAdapterMtr("select * from CAD_MTR order by CÓDIGO DESC LIMIT " &
	    P)
	    _info5.Notifyicone_PopupNotifier(vbNewLine & vbNewLine & Chr(9) &
	    "           Tabela atualizada em  " &
	    P & vbNewLine & vbTab & vbTab &
	    "Registros para Grade ", vbNewLine & Chr(9) & Chr(9) &
	    "Informativo", 3000, BTcarregarMtr)

	 End If
   End Sub
   Private Sub BTconfig_MouseEnter(sender As Object, e As EventArgs) Handles BTconfig.MouseEnter
	 Ajuda_Tooltip(ToolTipMTR, BTconfig, "Acionar outros recursos.")
   End Sub

   Dim Tempo As TimeSpan = TimeSpan.FromSeconds(11000)
   Private Async Sub TimerSalvarNaNuvem_Tick(sender As Object, e As EventArgs) Handles TimerSalvarNaNuvem.Tick

	 Tempo -= TimeSpan.FromSeconds(1)
	 Me.Text = "Controle Manifesto de Transporte - MarcosFerreira-Proj T.I " & "-" & "Save " & Format(Tempo.TotalSeconds - LL, "000")


	 If Tempo.TotalSeconds = "002" Then
	    Visible = False
	    Await Internet.FTP_Upload(Application.StartupPath & "\BD\BDVITAL.db",
	    "ftp://files.000webhost.com/public_html/BDVITAL.db",
	    "marcosferreiramf",
	    "Senha0789")

	    Await Internet.FTP_Dowload(Application.StartupPath & "\BD\BDVITAL.db",
	    "ftp://files.000webhost.com/public_html/BDVITAL.db",
	    "marcosferreiramf",
	    "Senha0789")
	    Await Task.Delay(100)
	    Visible = True
	    Tempo = TimeSpan.FromSeconds(11000)  '1 HORA
	 End If
   End Sub
   Private Sub BtContrair_Click(sender As Object, e As EventArgs) Handles BtContrair.Click
	 Contrair()
   End Sub

   Sub Contrair()
	 Width = 547
	 Height = 336
	 CenterToScreen()
	 GroupBox6.Dock = DockStyle.None
	 DGVdados.Size = New Size(509, 141)
   End Sub
   Private Sub Bt_Expandir_Click(sender As Object, e As EventArgs) Handles Bt_Expandir.Click
	 Expandir()
   End Sub
   Sub Expandir()
	 Width = 1044
	 Height = 752 '786
	 CenterToScreen()
	 GroupBox6.Dock = DockStyle.Bottom
	 DGVdados.Size = New Size(509, 589)
	 StatusStrip1.Dock = DockStyle.Bottom
   End Sub
   Private Sub FrmMTR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
	 Dim k1 As CadMTR = New CadMTR("BDVITAL.db")
	 'para trabalhar com threeds
	 CheckForIllegalCrossThreadCalls = False
	 My.Settings.Reload()

	 Dim k As New Notifyicone_PopupNotifier
	 TimerSalvarNaNuvem.Start()
	 TXTmtr.SelectAll()
	 ToolStripStatusLabeUsuarioLogado.Text = UsuarioLogado2()
	 ToolStripStatusLabel_HOJE.Text = Today.ToLongDateString

	 Dim _ip As New Internet
	 ToolStripStatusLabel_IPlocal.Text = _ip.Endereço_de_Ip_local
	 ToolStripStatusLabel_Host.Text = _ip.Endereço_de_Host

	 StartPosition = FormStartPosition.CenterScreen
	 BTcarregarMtr_Click(Me, Nothing)
	 TXTmtr.Focus()
	 Contrair()
	 CarregarConfiguracoes()



   End Sub

#Region "Carregando as configurações Feam"
   Public Async Sub CarregarConfiguracoes()
	 Dim Conf As New FRMConfiguracaoFeam
	 Dim CF As List(Of Configuracao) = Carregar_Configuracao(Application.StartupPath & "\Configuracao.json")

	 DestinadorLocal.Text = CF.Item(0).Destinador_CodigoUnidade.CodigoUnidade

	 If CF.Item(0).Modalidade_.RdbPessoaFisica = True Then
	    Try
		  ' Dim T = Task.Run(Of RetornarToken)(Function() RetornaToken_.GetTokenAsync) lambda mais n funciona em vb
		  Dim PF As New PessoaFisica(
		  CF.Item(0).Pessoa_fisica.CodigoUnidadePF,
		  CF.Item(0).Pessoa_fisica.CPF,
		  CF.Item(0).Pessoa_fisica.Id_CPF_Usuario,
		  CF.Item(0).Pessoa_fisica.SenhaAcesso)

		  _RetornaToken_.PessoaCodigo = PF.CodigoUnidadePF
		  _RetornaToken_.PessoaCnpj = PF.CPF
		  _RetornaToken_.UsuarioCpf = PF.Id_CPF_Usuario
		  _RetornaToken_.Senha = PF.SenhaAcesso

		  Await _RetornaToken_.GetTokenAsync()

		  If _RetornaToken_.RetornoCodigo <> "" Then
			ToolStripStatusLabelLogin.Text += $"{ _RetornaToken_.Lista.Item(0).Retorno}" 'var embutida
		  Else
			ToolStripStatusLabelLogin.Text += $" { "Erro ao autenticar"}" 'var embutida
		  End If

		  Conf.txtDestinadorCodigoUnidade.Text = CF.Item(0).Destinador_CodigoUnidade.CodigoUnidade
	    Catch ex As Exception
		  MsgBox(ex.Message.ToString)
	    End Try

#End Region


#Region "PJ Atribuindo valores de autenticação antes da chamada da função GetTokenAsync q espera receber os dados de credenciais para mandar a requisição no BODY"
	 ElseIf CF.Item(0).Modalidade_.RdbPessoaJridica = True Then

	    Try
		  Dim PJ As New Configuracao.PessoaJuridica(
		 CF.Item(0).Pessoa_Juridica.CodigoUnidadePJ,
		 CF.Item(0).Pessoa_Juridica.CNPJ,
		 CF.Item(0).Pessoa_Juridica.IdCPFusuarioPJ,
		 CF.Item(0).Pessoa_Juridica.SenhaAcessoPJ)

		  _RetornaToken_.PessoaCodigo = PJ.CodigoUnidadePJ
		  _RetornaToken_.PessoaCnpj = PJ.CNPJ
		  _RetornaToken_.UsuarioCpf = PJ.IdCPFusuarioPJ
		  _RetornaToken_.Senha = PJ.SenhaAcessoPJ
		  Await _RetornaToken_.GetTokenAsync()
		  ToolStripStatusLabelLogin.Text += $"{ _RetornaToken_.Lista.Item(0).Retorno}"

		  'destinado cod Unidade_Local p Vital Eng
		  Conf.txtDestinadorCodigoUnidade.Text = CF.Item(0).Destinador_CodigoUnidade.CodigoUnidade
	    Catch ex As Exception
		  MsgBox(ex.Message.ToString)
	    End Try

#End Region
	 ElseIf CF.Item(0).Modalidade_.RdbDesativado = True Then
	    ToolStripStatusLabelLogin.Text += " Desativado"
	    Conf.txtDestinadorCodigoUnidade.Text = CF.Item(0).Destinador_CodigoUnidade.CodigoUnidade
	    'If CF.Item(0).Modalidade_.RdbDesativado = True Then
	    '   DestinadorLocal.Image = Principal.My.Resources.Resources.accept
	    ' End If
	 End If
   End Sub


   Dim C As List(Of Configuracao) = Carregar_Configuracao(Application.StartupPath & "\Configuracao.json")
   Private DS As DataSet
   Dim NomedoArquivo As String = "BDVITAL.db"
   Private Async Sub TXTmtr_TextChanged(sender As Object, e As EventArgs) Handles TXTmtr.TextChanged




	 'Dim Pesq As New CadMTR("BDVITAL.db")
	 'DS = Pesq.GetDataSet("MTR LIKE '%" & TXTmtr.Text & "%'")
	 ' Dim dr() As DataRow = DS.Tables(0).Select("MTR LIKE '%" & TXTmtr.Text & "%'")
	 ' Dim Dt As DataTable = DS.Tables(0).Copy

	 ' Dt.Clear()

	 ' For Each Linhas As DataRow In dr
	 'Dt.ImportRow(Linhas)
	 ' Next
	 ' Dt.AcceptChanges()
	 ' DGVdados.DataSource = Dt
	 'DGVdados.DataSource = Await Pesq.GetTabelaViaAdapterMtr("SELECT * FROM CAD_MTR WHERE MTR like'" + TXTmtr.Text + "%'")


	 Dim MTR As String = TXTmtr.Text
	 Dim MTR_Parte_A As String = ""
	 Dim MTR_Parte_B As String = ""


	 Select Case C.Item(0).LeitorCodigoBarras.ReceberMtr10Dig
	    Case True
		  If TXTmtr.Text.Length = 34 Then
			MTR_Parte_A = TXTmtr.Text
			MTR_Parte_B = TXTmtr.Text
			'Await Threading.Tasks.Task.Delay(100)
			'	BTadicionarMtr.PerformClick()
			'AddHandler BTadicionarMtr.Click, AddressOf ADICIONAR.Wait

		  End If

	    Case False
		  If TXTmtr.Text.Length = 34 Then
			MTR_Parte_A = TXTmtr.Text
			MTR_Parte_B = TXTmtr.Text
			BTadicionarMtr.Focus()
			'BTadicionarMtr.PerformClick()
			'AddHandler BTadicionarMtr.Click, AddressOf ADICIONAR.Wait
		  End If
	 End Select
   End Sub
   Private Sub LimparResultados()
	 txtmanifestoCodigo.Text = ""
	 txtretornoCodigo.Text = ""
	 txtcnpGerador.Text = ""
	 txtcodUnidadeGerador.Text = ""
	 txtcnpTransportador.Text = ""
	 txtcodUnidadeTransportador.Text = ""
	 txtcnpDestinador.Text = ""
	 txtcodUnidadeDestinador.Text = ""
	 txtcnpArmazenador.Text = ""
	 txtcodUnidadeArmazenador.Text = ""
	 txtsituacaoManifestoCodigo.Text = ""
	 txtmanifDataExpedicao.Text = ""
	 txtmanifData.Text = ""
	 txtmanifDataRecebimento.Text = ""
	 txtmanifObservacao.Text = ""
	 txtretorno.Text = ""
	 txtmanifGeradorNomeResponsavel.Text = ""
	 txtcodigoSequencial.Text = ""
	 txtmanifGeradorCargoResponsavel.Text = ""
	 txtjustificativa.Text = ""
	 txtmanifTransportadorNomeMotorista.Text = ""
	 txtcodigoInterno.Text = ""
	 txtmanifTransportadorPlacaVeiculo.Text = ""
	 txtcodigoClasse.Text = ""
	 txtmanifTransportadorDataExpedicao.Text = ""
	 txtcodigoTipoEstado.Text = ""
	 txtresiduo.Text = ""
	 txttipoDensidadeValor.Text = ""
	 txtcodigoAcondicionamento.Text = ""
	 txttipoDensidadeUnidade.Text = ""
	 txtcodigoTecnologia.Text = ""
	 txtnumeroONU.Text = ""
	 txtmanifestoItemObservacao.Text = ""
	 txtclasseDeRisco.Text = ""
	 txtmanifestoItemCodInterno.Text = ""
	 txtmanifestoItemCodInternoDestinador.Text = ""
	 txtquantidade.Text = ""
	 txtcodigoUnidade.Text = ""
	 txtnomeEmbarque.Text = ""
	 txtquantidadeRecebida.Text = ""
	 txtgrupoEmbalagem.Text = ""
	 txtSituacaoMTR.Text = ""

	 txtClasseDescrição.Text = ""
	 txtDescricaoAcondicionamento.Text = ""
	 txtUnidadeDescricao.Text = ""
	 txtDescricaoEstadoFisico.Text = ""
	 txtDescriçãoTecnologia.Text = ""
	 TreeView1.Nodes.Clear()
   End Sub

   Private Async Sub BtnReceberManifestoBunifuFlatButton_Click(sender As Object, e As EventArgs) Handles BtnReceberManifestoBunifuFlatButton.Click

	 If txtquantidadeRecebida.Text <> "" Then
	    Dim CF = Configuracao.Carregar_Configuracao(Application.StartupPath & "\Configuracao.json")

	    Dim DataHoje As String = DateTime.Now.Date.ToString.Replace("/", "")
	    DataHoje = DataHoje.Substring(4, 4) & DataHoje.Substring(2, 2) & DataHoje.Substring(0, 2) '(YYYYMMDD

	    Dim TransportadorDataExpedicao As String = txtmanifDataExpedicao.Text
	    TransportadorDataExpedicao = TransportadorDataExpedicao.Replace("/", "").Substring(4, 4) & TransportadorDataExpedicao.Replace("/", "").Substring(2, 2) & TransportadorDataExpedicao.Replace("/", "").Substring(0, 2)



	    Await _ManifestoRecebimentoJSON.ReceberManifestoLoteFunc(
	    txtmanifestoCodigo.Text,
	    txtcnpGerador.Text,
	    txtcnpTransportador.Text,
	    txtmanifGeradorNomeResponsavel.Text,
	    txtmanifGeradorCargoResponsavel.Text,
	    DataHoje,
	    txtmanifTransportadorNomeMotorista.Text,
	    txtmanifTransportadorPlacaVeiculo.Text,
	    TransportadorDataExpedicao,
	    Convert.ToDouble(txtquantidadeRecebida.Text),
	    txtresiduo.Text,
	    txtcodigoTecnologia.Text,
	    txtmanifObservacao.Text,
	    If(txtcodigoSequencial.Text <> "", Convert.ToInt32(txtcodigoSequencial.Text), 0),
	    txtjustificativa.Text,
	    If(txtcodigoInterno.Text <> "", Convert.ToInt32(txtcodigoInterno.Text), 0))

	 Else
	    MsgBox("Para receber o manifesto digite um" & vbCrLf & "Valor de peso na caixa de texto" & vbCrLf & "Quantidade Recebida", MsgBoxStyle.Exclamation, e.ToString)
	    txtquantidadeRecebida.Focus()
	 End If
   End Sub

   Private Async Sub TXTmtr_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTmtr.KeyPress
	 If TXTmtr.Text.Length >= 0 And Pesquisar.Checked = True And e.KeyChar = ChrW(Keys.Enter) Then
	    If Pesquisar.Checked = True And TXTmtr.TextLength >= 1 Then

		  Dim sql = " select * from CAD_MTR "
		  sql &= "where CÓDIGO like @keyword "
		  sql &= "or MTR like @keyword "
		  sql &= "or DATAHORA like @keyword "
		  sql &= "or OP_ENTRADA like @keyword "
		  sql &= "or OBSERVACAO like @keyword "
		  sql &= "order by CÓDIGO ASC"

		  Dim dt As New DataTable
		  Using con = New SQLiteConnection("Data Source=" & Application.StartupPath & "\BD\" & NomedoArquivo)
			con.Open()
			Using adapter = New SQLiteDataAdapter(sql, con)
			   adapter.SelectCommand.Parameters.Clear()
			   Dim keywordsString = String.Format("%{0}%", TXTmtr.Text)
			   adapter.SelectCommand.Parameters.AddWithValue("@keyword", keywordsString)
			   adapter.SelectCommand.ExecuteNonQuery()
			   adapter.Fill(dt)
			   DGVdados.DataSource = dt
			End Using
		  End Using
	    End If

	    'Dim M As CadMTR = New CadMTR("BDVITAL.db")
	    'DGVdados.DataSource = Await M.Carregar(TXTmtr.Text)
	    Await Threading.Tasks.Task.Delay(500)

	 End If
   End Sub

   Private Sub Pesquisar_MouseEnter(sender As Object, e As EventArgs) Handles Pesquisar.MouseEnter
	 Ajuda_Tooltip(ToolTipMTR, Pesquisar, "Ative a checkBox em Pesquisar MTR, digite uma chave e pressione ENTER")
   End Sub


   'WithEvents t As New TextBox() With {.Name = "lblalterarquantidadeRecebida",
   '		    .BackColor = Color.White, .Location = New Point(443, 435), .Size = New Size(144 / 2, 16),
   '		    .Font = New Font("Century Gothic", 10, FontStyle.Regular)}

End Class
