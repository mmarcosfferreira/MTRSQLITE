Imports System.Drawing.Printing
Imports System.IO.Ports
Imports System.Net
Imports System.Net.Sockets
Imports System.Text
Imports System.Text.RegularExpressions
Imports Newtonsoft.Json

Public Class FRMControlePesagemManual_
   Implements System.IDisposable
   Public info As New Notifyicone_PopupNotifier()
   Private Pd As New Printing.PrintDocument
   Private PaginaAtual As Integer = 1
   Private RelatorioTitulos


   Private Sub TXTPESOENTRADA_KeyPress(sender As Object, e As KeyPressEventArgs)
	 AddHandler TXTPESO_BRUTO.KeyPress, AddressOf SONUMEROS.SONUMEROS
   End Sub
   Private Sub TXTMOTORISTA_ENTRADA_KeyPress(sender As Object, e As KeyPressEventArgs)
	 'addhandler Manipulador de evento, addressof Função/Rotina/Sub
	 AddHandler TXTMOTORISTA_ENTRADA.KeyPress, AddressOf SOLETRAS.SOLETRAS
   End Sub
   Private Async Sub AdicionarRegistroSaida()
	 Dim P As New CAD_CONTROLE_DE_PESAGEM_MANUAL("BDVITAL.db")
	 P.PLACA = TXTPLACA_SAIDA.Text
	 P.PESO_BRUTO = TXTPESOBRUTO_LEITURA.Text
	 P.MOTORISTA = TXTMOTORISTA_SAIDA.Text
	 P.PESO_TARA = TXTPESO_TARA.Text
	 P.PESO_LIQUIDO = FormatNumber(P.PESO_BRUTO - TXTPESO_TARA.Text, 2)
	 P.CLIENTE = TXTCLIENTESAIDA.Text
	 P.TRANSPORTADORA = TXTTRASNPORTADORSAIDA.Text
	 P.OPCAO_DE_ENTRADA = TxtOpcaoEntrada_Saida.Text 'UCase(UsuarioLogado.UsuarioLogado())
	 P.OPCAO_DE_SAIDA = UCase(UsuarioLogado.UsuarioLogado() & " " & Now) 'TXTOPCAODESAIDA.Text
	 P.STATUS = "CONCLUIDO"
	 P.RESIDUO = TXTRESIDUO.Text
	 P.CODIGO = LBLCODIGO.Text

	 If P.adicionarSaida(P.CODIGO) = True Then
	    MsgBox("Adicionado com sucesso", MsgBoxStyle.Information, "Novo registro!")

	    DgvDados.Columns.Clear()
	    Dim Dal As New CAD_CONTROLE_DE_PESAGEM_MANUAL("BDVITAL.db")
	    With DgvDados
		  .AutoSize = True
		  .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
		  .ColumnHeadersHeight = 50
	    End With
	    DgvDados.DataSource = Dal.GetTabelaViaAdapter("select * from CAD_CONTROLE_DE_PESAGEM_MANUAL ORDER BY CODIGO DESC LIMIT 30")  '
	    'SELECT * FROM CAD_MTR ORDER BY CÓDIGO DESC limit 20
	    LBLCODIGO.Text = ""
	 Else
	    MsgBox("´Falha ao tentar fechar a pesagem!", MsgBoxStyle.Exclamation, "Novo registro!")
	 End If


   End Sub

   Private Sub AdicionarRegistroEntrada()
	 'Preenchimento das propriedades com valore
	 Dim P As New CAD_CONTROLE_DE_PESAGEM_MANUAL("BDVITAL.db") 'Local Banco de dados
	 P.PLACA = TXTPLACA_ENTRADA.Text
	 P.PESO_BRUTO = If(TXTPESO_BRUTO.Text = "", 0, TXTPESO_BRUTO.Text)
	 P.MOTORISTA = TXTMOTORISTA_ENTRADA.Text
	 P.PESO_TARA = If(TXTPESO_TARA.Text = "", 0, TXTPESO_TARA.Text)
	 P.PESO_LIQUIDO = 0 'P.PESO_BRUTO - P.PESO_TARA
	 P.CLIENTE = CBOCLIENTEENTRADA.Text
	 P.TRANSPORTADORA = CBOTRANSPORTADORENTRADA.Text
	 P.OPCAO_DE_ENTRADA = UCase(UsuarioLogado.UsuarioLogado() & " " & Now)
	 P.OPCAO_DE_SAIDA = String.Empty 'TXTOPCAODESAIDA.Text
	 P.STATUS = "EM ABERTO"
	 P.RESIDUO = CBOCADASTRARRESIDUOS.Text

	 'verifica se existe uma pesahem com a mesma placa em aberto
	 If P.ValidarPesagemEmAberto(TXTPLACA_ENTRADA) = True Then
	    MsgBox("Há uma pesagem em aberto com esta placa que deve ser concluída ou excluída!", MsgBoxStyle.Exclamation, "Atenção!")
	 Else
	    TXTOPCAODEENTRADA.Text = UsuarioLogado.UsuarioLogado() & " " & Now
	    If P.AdicionarEntrada = True Then
		  MsgBox("adicionado com sucesso", MsgBoxStyle.Information, "Novo registro!")
	    Else
		  MsgBox("Erro ao adicionar registro", MsgBoxStyle.Information, "erro!")
	    End If

	    DgvDados.Columns.Clear()
	    Dim Dal As New CAD_CONTROLE_DE_PESAGEM_MANUAL("BDVITAL.db")

	    With DgvDados
		  .AutoSize = True
		  .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
		  .ColumnHeadersHeight = 50
	    End With
	    'recarrega a fonte de dados no grid ("select top 5 * from cad_mtr order by código desc") ACCES
	    DgvDados.DataSource = Dal.GetTabelaViaAdapter("select * from CAD_CONTROLE_DE_PESAGEM_MANUAL ORDER BY CODIGO desc LIMIT 30")
	 End If
   End Sub


   Private Sub BTREGISTRAR_Click(sender As Object, e As EventArgs) Handles BTINSERIR.Click
	 If TabPageEntrada.Focus = True Then 'entrada
	    Threading.Thread.Sleep(100)
	    'VALIDAÇÃO DE DADOS C A FUNÇÃO BOOLEAN
	    If VALIDARENTRADA.VALIDARENTRADA(CT:=TXTPLACA_ENTRADA) = True Then Exit Sub
	    If VALIDARENTRADA.VALIDARENTRADA(CT:=TXTPESO_BRUTO) = True Then Exit Sub
	    If VALIDARENTRADA.VALIDARENTRADA(CT:=TXTMOTORISTA_ENTRADA) = True Then Exit Sub
	    If VALIDARENTRADA.VALIDARENTRADA(CT:=CBOCLIENTEENTRADA) = True Then Exit Sub
	    If VALIDARENTRADA.VALIDARENTRADA(CT:=CBOTRANSPORTADORENTRADA) = True Then Exit Sub
	    If VALIDARENTRADA.VALIDARENTRADA(CBOCADASTRARRESIDUOS) = True Then Exit Sub
	    TXTOPCAODEENTRADA.Text = UCase(UsuarioLogado.UsuarioLogado() & Now)
	    'depois q passa a validação então adiciona
	    AdicionarRegistroEntrada()
	    LIMPAR_CONTROLES.LIMPAR_CONTROLES(Me)
	 Else
	    If TabPageSaida.Focus Then 'saida
		  Threading.Thread.Sleep(100)
		  If VALIDARENTRADA.VALIDARENTRADA(TXTPLACA_SAIDA) = True Then Exit Sub
		  If VALIDARENTRADA.VALIDARENTRADA(TXTPESO_TARA) = True Then Exit Sub
		  If VALIDARENTRADA.VALIDARENTRADA(TXTRESIDUO) = True Then Exit Sub
		  If VALIDARENTRADA.VALIDARENTRADA(TXTMOTORISTA_SAIDA) = True Then Exit Sub
		  If VALIDARENTRADA.VALIDARENTRADA(TXTCLIENTESAIDA) = True Then Exit Sub
		  If VALIDARENTRADA.VALIDARENTRADA(TXTTRASNPORTADORSAIDA) = True Then Exit Sub
		  AdicionarRegistroSaida()
		  LIMPAR_CONTROLES.LIMPAR_CONTROLES(Me)
	    End If
	 End If
	 Try
	    Dim dt1, dt2, dt3 As Object
	    Dim banco4 = New CAD_CONTROLE_DE_PESAGEM_MANUAL("bdvital.db")
	    Dim banco5 = New CAD_CONTROLE_DE_PESAGEM_MANUAL("bdvital.db")
	    Dim banco6 = New CAD_CONTROLE_DE_PESAGEM_MANUAL("bdvital.db")

	    dt1 = banco4.Preenchimento_Automatico_Text("Select PLACA FROM CAD_CONTROLE_DE_PESAGEM_MANUAL")
	    TXTPLACA_ENTRADA.AutoCompleteCustomSource = dt1 'banco4.Completar 'dt1
	    dt2 = banco5.Preenchimento_Automatico_Text("Select MOTORISTA FROM CAD_CONTROLE_DE_PESAGEM_MANUAL")
	    TXTMOTORISTA_ENTRADA.AutoCompleteCustomSource = dt2
	    dt3 = banco6.Preenchimento_Automatico_Text("Select PLACA FROM CAD_CONTROLE_DE_PESAGEM_MANUAL")
	    TXTPLACA_SAIDA.AutoCompleteCustomSource = dt3
	 Catch ex As Exception
	    MsgBox(ex.Message, vbCritical, "excepção encontrada")
	 End Try
   End Sub

   Private Sub BTLIMPAR_Click(sender As Object, e As EventArgs) Handles BTLIMPAR.Click
	 LIMPAR_CONTROLES.LIMPAR_CONTROLES(Me)
	 'TabControl.SelectedTab = TabControl.TabPages(0)
	 CBOCADASTRARRESIDUOS.Text = Nothing
	 TXTPLACA_ENTRADA.Focus()
	 Play("mario_moeda_efeito.wav")
   End Sub

   Private Sub TXTPLACA_ENTRADA_KeyUp(sender As Object, e As KeyEventArgs) Handles TXTPLACA_ENTRADA.KeyUp
	 TXTPLACA_ENTRADA.MaxLength = 7
	 'If TXTPLACA_ENTRADA.TextLength <= 9 Then
	 'If TXTPLACA_ENTRADA.TextLength >= 0 AndAlso TXTPLACA_ENTRADA.TextLength <= 3 Then
	 '    'If TXTPLACA_ENTRADA.SelectionStart = 3 Then
	 '    '    TXTPLACA_ENTRADA.SelectedText = ""
	 '    '    Exit Sub
	 '    'End If
	 'End If
	 'End If
	 If e.KeyData = Keys.Enter Then
	    TXTPESO_BRUTO.Focus()
	 End If
   End Sub

   Private Sub TXTPLACA_SAIDA_KeyUp(sender As Object, e As KeyEventArgs) Handles TXTPLACA_SAIDA.KeyUp
	 TXTPLACA_SAIDA.MaxLength = 7
	 'If TXTPLACA_SAIDA.TextLength <= 9 Then
	 '    If TXTPLACA_SAIDA.SelectionStart = 3 Then
	 '        TXTPLACA_SAIDA.SelectedText = "-"
	 '    End If
	 'End If
	 If e.KeyData = Keys.Enter Then
	    TXTPESO_TARA.Focus()
	 End If
   End Sub

   Public Function EPlacaValida(value As String) As Boolean
	 Dim regex As New Regex("^[a-zA-Z]{3}\-\d{4}$")
	 Return regex.IsMatch(value)
   End Function
   Private Sub TXTPLACA_ENTRADA_Leave(sender As Object, e As EventArgs) Handles TXTPLACA_ENTRADA.Leave
	 TXTPLACA_ENTRADA.MaxLength = 7
	 Me.TXTPLACA_ENTRADA.ForeColor = Color.Black
	 Me.TXTPLACA_ENTRADA.BackColor = Color.White
   End Sub

   'Private Sub FRMControlePesagemManual__KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
   'If e.KeyCode = Keys.F1 Then
   '    TabControl.SelectedTab = TabControl.TabPages(0)
   'Else
   '    If e.KeyCode = Keys.F2 Then
   '        TabControl.SelectedTab = TabControl.TabPages(1)
   '    Else
   '        If e.KeyCode = Keys.F3 Then
   '            TabControl.SelectedTab = TabControl.TabPages(2)
   '        Else
   '            If e.Alt And e.KeyValue = Keys.L Then
   '                BTLIMPAR_Click(BTLIMPAR, e)

   '            Else
   '                If e.Alt And e.KeyCode = Keys.I Then
   '                    BTREGISTRAR_Click(BTINSERIR, e)
   '                End If

   '            End If
   '        End If
   '    End If
   'End If
   'End Sub
   Private Sub TXTPESODESAIDA_KeyPress(sender As Object, e As KeyPressEventArgs)
	 AddHandler TXTPESO_TARA.KeyPress, AddressOf SONUMEROS.SONUMEROS
   End Sub
   Private Sub TXTPESODESAIDA_KeyUp(sender As Object, e As KeyEventArgs) Handles TXTPESO_TARA.KeyUp
	 If e.KeyData = Keys.Enter Then
	    TXTRESIDUO.Focus()
	 End If
	 AddHandler TXTPESO_TARA.KeyPress, AddressOf SONUMEROS.SONUMEROS

   End Sub
   Private Sub LVCONTROLEDEPESAGEMMANUAL_SelectedIndexChanged(sender As Object, e As EventArgs)
   End Sub

   'Private Async Sub LVCONTROLEDEPESAGEMMANUAL_DoubleClick(sender As Object, e As EventArgs) Handles LVCONTROLEDEPESAGEMMANUAL.DoubleClick
   '    Dim Contar As Integer = 0
   '    If FrmMTR.jjj.RadioButtonServer.Checked = True Then
   '        If LVCONTROLEDEPESAGEMMANUAL.SelectedItems.Count > 0 Then
   '            If MsgBox("Deletar seleção de item's'?", MsgBoxStyle.Critical + MsgBoxStyle.YesNo, "Cuidado") = DialogResult.Yes Then
   '                For Each IT As ListViewItem In LVCONTROLEDEPESAGEMMANUAL.SelectedItems
   '                    IT.Remove()
   '                    Contar += 1
   '                Next
   '                SalvarOnlineContPesagemManual.SalvarOnlineContPesagemManual(Application.StartupPath & "\Controle_de_Pesagem_Manual.txt", LVCONTROLEDEPESAGEMMANUAL, BTINSERIR)
   '                Await Task.Delay(2200)
   '                info.Notifyicone_PopupNotifier(vbCrLf & "            < " & Contar & " item(s) <deletado(s) com êxito!! > ", "                             ...Informativo...", 1000, Me)
   '            Else
   '                info.Notifyicone_PopupNotifier(vbCrLf & "            < <Cancelado pelo Usuario! > ", "                             ...Informativo...", 1000, BTINSERIR)
   '            End If
   '        End If
   '    Else ' SE MEU RADIO BUTTON SERVIDOR WEB =FALSE oq implica q quero apenas salvar no localhost e não no server
   '        If LVCONTROLEDEPESAGEMMANUAL.SelectedItems.Count > 0 Then
   '            If MsgBox("Deletar seleção de item's'?", MsgBoxStyle.Critical + MsgBoxStyle.YesNo, "Cuidado") = DialogResult.Yes Then
   '                For Each IT As ListViewItem In LVCONTROLEDEPESAGEMMANUAL.SelectedItems
   '                    IT.Remove()
   '                    Contar += 1
   '                Next
   '                Await Task.Delay(2200)
   '                info.Notifyicone_PopupNotifier(vbCrLf & "            < " & Contar & " item(s) <deletado(s) com êxito!! > ", "                             ...Informativo...", 1000, Me)
   '            Else
   '                info.Notifyicone_PopupNotifier(vbCrLf & "            < <Cancelado pelo Usuario! > ", "                             ...Informativo...", 1000, BTINSERIR)
   '            End If
   '        End If
   '    End If
   'End Sub
   'Private Sub BtExibir_Visualizacao_da_Impresao_Click(sender As Object, e As EventArgs)
   '    'M_PrintDocument = New PrintDocument
   '    'PrintPreviewDialog1.Document = M_PrintDocument
   '    'PrintPreviewDialog1.ShowDialog()
   'End Sub
   'Private Sub Exibir_dialogos_de_Impressao_Click(sender As Object, e As EventArgs)
   '    'M_PrintDocument = New PrintDocument
   '    'PrintDialog1.Document = M_PrintDocument
   '    'PrintDialog1.ShowDialog()
   'End Sub

   Private Msg As Object
   Private ObjPrintPreviewDialog As New PrintPreviewDialog() 'define o objeto para visualizar a impressão
   Private Sub BTN_IMPRIMIR_Click(sender As Object, e As EventArgs) Handles BTN_IMPRIMIR.Click

	 Dim RelatorioTitulos = "Controle de Pesagem Manual by Marcos Ferreira "   'aqui concatenar a data depois

	 Using Pd As Printing.PrintDocument = New Printing.PrintDocument() 'define o objeto printdocuments e eventos associados definimos 3 eventos p tratar a impressão
	    AddHandler Pd.BeginPrint, New Printing.PrintEventHandler(AddressOf Begin_Print)
	    AddHandler Pd.PrintPage, New Printing.PrintPageEventHandler(AddressOf PdRelatorios_PrintPage)
	    AddHandler Pd.EndPrint, New Printing.PrintEventHandler(AddressOf End_Print)

	    Try
		  'define o objeto como maximazado e com zum
		  With ObjPrintPreviewDialog
			.Document = Pd  'tenho que atribuir ao obj printpreview dialog o documento  q quero imprimir(PD) ao preview dialog que vao me dar a visualização  
			.WindowState = FormWindowState.Maximized
			.PrintPreviewControl.Zoom = 1 ' 1
			.Text = RelatorioTitulos

			If MsgBox("Deseja exibir a visualização da impressão?", MsgBoxStyle.YesNo + MsgBoxStyle.Information, "Visualizar impressão") = DialogResult.Yes Then
			   .ShowDialog()
			Else
			   Msg = InputBox_Personalizado("Informe a Quantidade de vias ?", "Impressão", Nothing, False, False)
			   If Msg <> String.Empty And Msg <> "" And IsNumeric(Msg) Then
				 PaginaAtual = Msg  'AddHandler Pd.PrintPage, New Printing.PrintPageEventHandler(AddressOf PdRelatorios_PrintPage)

				 If PaginaAtual = 0 Then
				    MsgBox("Quantidade inválida para impressão!" & vbNewLine & "Digite uma valor diferente de 0", MsgBoxStyle.Exclamation)
				 Else
				    Pd.PrinterSettings.Copies = PaginaAtual
				    Pd.Print()
				 End If

			   End If
			End If
		  End With
	    Catch ex As Exception
		  MessageBox.Show(ex.Message)
	    End Try
	 End Using
   End Sub

   Private Sub Begin_Print(sender As Object, e As PrintEventArgs) '5555
	 '===============Definindo atributos do PrintPreviw Dialog=============================================


   End Sub

   'ou seja p imprimir c estes componentes precisa dos tres eventos se n dara erro
   Private Sub End_Print(ByVal sender As Object, ByVal e As Printing.PrintEventArgs)

   End Sub

   Private Sub PdRelatorios_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs)
	 'variaveis das linhas
	 ' então p fazer isto estou usando o Obnjeto PrintPageEventArgs que é representado pela variavel e
	 If DgvDados.SelectedRows.Count > 0 Then
	    Dim LinhasPorPaginas As Single = 0 'defindo quantas linhas por paginas eu vou ter
	    Dim PosiçãoDaLinha As Single = 0   'Qual é a posição dalinha  
	    Dim LinhaAtual As Integer = 0      'Qual é a linha atual

	    'Variaveis das margens(e.MarginBounds obtem a área retangular que representa a parte da página dentro das margens.)
	    Dim MargemEsquerda As Single = 0 ' e.MarginBounds.Left  'defindo a margem equerda
	    Dim MargemSuperior As Single = e.MarginBounds.Top + 50  'A margem superior q incluo mais 100 un por causa do titulo
	    Dim MargemDireita As Single = 0 'e.MarginBounds.Right        'A Margem direira
	    Dim MargemInferior As Single = 0 'e.MarginBounds.Bottom      'A Margem inferior

	    'Classe Pen define um Objeto usado para definir as linhas e curvas
	    Using CanetaDaImpressora As New Pen(Color.Black, 1)
		  Dim Placa, Pentrada, Psaida, Pliquido, Motorista, Cliente, Trasnportadora, OpEntrada, OpSaida, Status, Resíduo As String

		  '======================================'Definindo as fontes que serão usadas p impressão=================================
		  Dim FonteNegrito As New Font("Arial", 9, FontStyle.Bold)
		  Dim FonteTitulo As New Font("Arial", 9, FontStyle.Bold)
		  Dim FonteSubtitulo As New Font("Arial", 9, FontStyle.Bold)
		  Dim FonteRodape As New Font("Arial", 8)
		  Dim FonteNormal As New Font("Arial", 8)

		  '====================================='imprime o logo tipo da empresa ===============================================================
		  e.Graphics.DrawImage(Image.FromFile(Application.StartupPath & "\Vital.ico"), 0, -5) '  ok 0 é o eixo x e 40 é o eixo y

		  'drawline - Desenha uma linha q conecta os dois pontos especificados pelos pares ordenados os seja
		  ' A linha da Borda da página   

		  ' aqui faço o desenho quadrado q no seu interior vou desenha oq colocar usando o código abaixo isto tudo dentro do interior deste linha ou quadrado
		  e.Graphics.DrawLine(CanetaDaImpressora, MargemEsquerda, 0, MargemDireita, 80) '  100,60 quando matenho o memso valor significa q vai desenha uma linha desenha uma linha no plano horizontal especificado
		  e.Graphics.DrawLine(CanetaDaImpressora, MargemEsquerda, 45, MargemDireita, 80) '160,160

		  '=============================================Definir o Nome Da Empresa dentro do quadrado=========================================
		  e.Graphics.DrawString("     TÍQUETE DE PESAGEM", FonteTitulo, Brushes.Blue, MargemEsquerda + 50, 120, New StringFormat())
		  e.Graphics.DrawString(" CENTRAL DE RESÍDUOS VALE DO AÇO", FonteTitulo, Brushes.Blue, MargemEsquerda + 30, 140, New StringFormat())
		  e.Graphics.DrawString(" " & My.Settings.NomeDaEmpresa, FonteTitulo, Brushes.Blue, MargemEsquerda + 35, 160, New StringFormat()) '  OK
		  e.Graphics.DrawString("    CNPJ: 02.536.066/0004-79", FonteTitulo, Brushes.Blue, MargemEsquerda + 50, 180, New StringFormat())

		  Placa = DgvDados.CurrentRow.Cells(1).Value 'PLACA
		  Pentrada = DgvDados.CurrentRow.Cells(2).Value 'PBRUTO
		  Psaida = DgvDados.CurrentRow.Cells(4).Value  'TARA
		  Pliquido = DgvDados.CurrentRow.Cells(5).Value 'LQUIDO
		  Motorista = DgvDados.CurrentRow.Cells(3).Value 'MOTORISTA
		  Cliente = DgvDados.CurrentRow.Cells(6).Value   'CLIENTE
		  Trasnportadora = DgvDados.CurrentRow.Cells(7).Value 'TRASNP
		  Resíduo = DgvDados.CurrentRow.Cells(11).Value  'RESIDUO 
		  Status = DgvDados.CurrentRow.Cells(10).Value 'STATUS
		  OpEntrada = DgvDados.CurrentRow.Cells(8).Value 'OPENTRADA
		  OpSaida = DgvDados.CurrentRow.Cells(9).Value 'OPSAIDA

		  ' Dim Placa, Pentrada, Psaida, Pliquido, Motorista, Cliente, Trasnportadora, OpEntrada, OpSaida, Status, Resíduo As String
		  '================Aqui vai entrar os campos do Cabelario destcado em negito a frente da linha seu respectivo   valor c fonte normal ============================
		  e.Graphics.DrawString("Placa: ", FonteNegrito, Brushes.Black, MargemEsquerda + 0, 210, New StringFormat()) 'todos tem um deslocamento na horizontal + a vertical permaneça
		  e.Graphics.DrawString(Placa.ToString(), FonteNormal, Brushes.Black, MargemEsquerda + 60, 210, New StringFormat()) '1
		  e.Graphics.DrawString("Bruto: ", FonteNegrito, Brushes.Black, MargemEsquerda + 0, 230, New StringFormat()) ' mais só quando eu for imprimir a linha q vai mudar
		  e.Graphics.DrawString(Pentrada.ToString(), FonteNormal, Brushes.Black, MargemEsquerda + 60, 230, New StringFormat()) '2 BRUTO
		  e.Graphics.DrawString("Tara: ", FonteNegrito, Brushes.Black, MargemEsquerda + 0, 250, New StringFormat())
		  e.Graphics.DrawString(Psaida.ToString(), FonteNormal, Brushes.Black, MargemEsquerda + 60, 250, New StringFormat())

		  e.Graphics.DrawString("Líquido: ", FonteNegrito, Brushes.Black, MargemEsquerda + 0, 270, New StringFormat())
		  e.Graphics.DrawString(Pliquido.ToString(), FonteNormal, Brushes.Black, MargemEsquerda + 60, 270, New StringFormat())
		  e.Graphics.DrawString("Motorista: ", FonteNegrito, Brushes.Black, MargemEsquerda + 0, 289, New StringFormat())
		  e.Graphics.DrawString(Motorista, FonteNormal, Brushes.Black, MargemEsquerda + 65, 291, New StringFormat())
		  e.Graphics.DrawString("Cliente: ", FonteNegrito, Brushes.Black, MargemEsquerda + 0, 310, New StringFormat())
		  e.Graphics.DrawString(Cliente, FonteNormal, Brushes.Black, MargemEsquerda + 60, 310, New StringFormat())
		  e.Graphics.DrawString("Transp: ", FonteNegrito, Brushes.Black, MargemEsquerda + 0, 330, New StringFormat())
		  e.Graphics.DrawString(Trasnportadora, FonteNormal, Brushes.Black, MargemEsquerda + 60, 330, New StringFormat())
		  e.Graphics.DrawString("Resíduo: ", FonteNegrito, Brushes.Black, MargemEsquerda + 0, 350, New StringFormat())
		  e.Graphics.DrawString(Resíduo, FonteNormal, Brushes.Black, MargemEsquerda + 60, 350, New StringFormat())
		  e.Graphics.DrawString("Status: ", FonteNegrito, Brushes.Black, MargemEsquerda + 0, 410, New StringFormat())
		  e.Graphics.DrawString(Status, FonteNormal, Brushes.Black, MargemEsquerda + 60, 410, New StringFormat())
		  e.Graphics.DrawString("Op Ent: ", FonteNegrito, Brushes.Black, MargemEsquerda + 0, 370, New StringFormat())
		  e.Graphics.DrawString(OpEntrada, FonteNormal, Brushes.Black, MargemEsquerda + 60, 370, New StringFormat())
		  e.Graphics.DrawString("Op Saída: ", FonteNegrito, Brushes.Black, MargemEsquerda + 0, 390, New StringFormat())
		  e.Graphics.DrawString(OpSaida, FonteNormal, Brushes.Black, MargemEsquerda + 60, 390, New StringFormat())

		  e.Graphics.DrawImage(Image.FromFile(Application.StartupPath & "/barcode.png"), -50, 440, 355, 60)
	    End Using
	    'e.Graphics.DrawImage(Image.FromFile(Application.StartupPath & "/CQG.Ico"), -50, 430, 450, 100)
	    'Play("classic-whistle-old-spice-v2.wav")
	 End If
   End Sub

   Private Sub FRMControlePesagemManual__FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing


	 'If MsgBox("Deseja fechar o formulário?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Atenção") = DialogResult.Yes Then
	 '   FRMopcoes.Close()
	 'Else
	 '   MsgBox("Cancelado pelo usuário(a): " & UCase(UsuarioLogado.UsuarioLogado), MsgBoxStyle.Information, "Controle de Pesagem Manual")
	 '   e.Cancel = True
	 'End If
   End Sub

   Private Async Sub BTSALVAR_Click(sender As Object, e As EventArgs) Handles BTSALVAR.Click
	 Call Internet.FTP_Upload(Application.StartupPath & "\BD\BDVITAL.db",
											  "ftp://files.000webhost.com/public_html/BDVITAL.db",
											    "marcosferreiramf",
											   "Senha0789")
	 Await Task.Delay(10000)
	 Call Internet.FTP_Dowload(Application.StartupPath & "\BD\BDVITAL.db",
											  "ftp://files.000webhost.com/public_html/BDVITAL.db",
											    "marcosferreiramf",
											   "Senha0789")
	 Await Task.CompletedTask
	 Play("sms-good-news.wav")
   End Sub

   Private Sub TXTPESOENTRADA_KeyUp(sender As Object, e As KeyEventArgs) Handles TXTPESO_BRUTO.KeyUp
	 If e.KeyData = Keys.Enter Then
	    TXTMOTORISTA_ENTRADA.Focus()
	 End If
   End Sub

   Private Sub TXTCLIENTEENTRADA_KeyUp(sender As Object, e As KeyEventArgs)
	 If e.KeyData = Keys.Enter Then
	    CBOTRANSPORTADORENTRADA.Focus()
	 End If
   End Sub
   Private Sub TXTTRANSPORTADORENTRADA_KeyUp(sender As Object, e As KeyEventArgs)
	 If e.KeyData = Keys.Enter Then
	    BTINSERIR.Focus()
	 End If
   End Sub

   Private Sub CBOCASTRARRESIDUOS_KeyUp(sender As Object, e As KeyEventArgs) Handles CBOCADASTRARRESIDUOS.KeyUp
	 If e.KeyData = Keys.Enter Then
	    CBOCLIENTEENTRADA.Focus()
	 End If
   End Sub

   Private Sub TXTRESIDUO_KeyUp(sender As Object, e As KeyEventArgs) Handles TXTRESIDUO.KeyUp
	 If e.KeyData = Keys.Enter Then
	    TXTMOTORISTA_SAIDA.Focus()
	 End If
   End Sub
   Private Sub TXTMOTORISTA_SAIDA_KeyUp(sender As Object, e As KeyEventArgs) Handles TXTMOTORISTA_SAIDA.KeyUp
	 If e.KeyData = Keys.Enter Then
	    TXTCLIENTESAIDA.Focus()
	 End If
   End Sub
   Private Sub TXTCLIENTESAIDA_KeyUp(sender As Object, e As KeyEventArgs) Handles TXTCLIENTESAIDA.KeyUp
	 If e.KeyData = Keys.Enter Then
	    TXTTRASNPORTADORSAIDA.Focus()
	 End If
   End Sub

   Private Sub TXTTRASNPORTADORSAIDA_KeyUp(sender As Object, e As KeyEventArgs) Handles TXTTRASNPORTADORSAIDA.KeyUp
	 If e.KeyData = Keys.Enter Then
	    BTINSERIR.Focus()
	 End If
   End Sub

   Private Sub TXTMOTORISTA_ENTRADA_KeyUp(sender As Object, e As KeyEventArgs) Handles TXTMOTORISTA_ENTRADA.KeyUp
	 If e.KeyData = Keys.Enter Then
	    CBOCADASTRARRESIDUOS.Focus()
	 End If
   End Sub

   Private Function LePorta(ByVal PortaSerial As String) As String
	 Dim Retorno As String = String.Empty
	 Try
	    Using Porta As IO.Ports.SerialPort = My.Computer.Ports.OpenSerialPort(PortaSerial) 'IO.Ports.SerialPort = My.Computer.Ports.OpenSerialPort(PortaSerial)
		  Porta.BaudRate = 4800
		  Porta.DataBits = 8
		  Porta.Parity = Parity.None 'Ports.Parity.None
		  Porta.StopBits = StopBits.One
		  Porta.ReadTimeout = 30000 ' em milisegundos
		  Dim LinhaLeitura As String = Porta.ReadLine
		  If LinhaLeitura Is Nothing Then
			Retorno = String.Empty
		  Else
			Retorno &= LinhaLeitura & vbCrLf
		  End If
	    End Using
	 Catch ex As Exception
	    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
	 End Try
	 Return Retorno
   End Function

   Dim Peso As Double
   Dim Ip_Balanca As New IPAddress("10.153.2.90") '"10.153.2.102"
   Dim PortaUsada = "1001" '"1001"
   Dim dados As String
   Public Async Sub PEGARPESO_BAL()
	 Try
	    '                                  SE FOR TCP/IP
	    Using tcpClient = New TcpClient()
		  tcpClient.Connect(IPAddress.Parse("10.153.2.90"), CInt(PortaUsada))
		  If tcpClient.Connected Then
			' Application.DoEvents() 'SE estáconectado esperar as outras funções de captura
			Dim networkStream As NetworkStream = tcpClient.GetStream
			If networkStream.CanRead Then 'Obtem um valor q indica se o network stream dá leitura ou seja se der leitura entre neste bloco de codigo
			   Application.DoEvents()
			   If TabPageEntrada.Focus Then
				 TXTPESO_BRUTO.Text = "Aguarde....."
				 'Application.DoEvents()
				 Dim b As Byte() = New Byte(tcpClient.ReceiveBufferSize - 1) {}
				 Await Task.Delay(500)
				 Application.DoEvents()
				 Await networkStream.ReadAsync(b, 0, tcpClient.ReceiveBufferSize)
				 Await Task.Delay(1000)
				 Application.DoEvents()
				 dados = Encoding.UTF8.GetString(b)  'Encoding.ASCII.GetString(b)
				 Application.DoEvents()
				 Threading.Thread.Sleep(200)
				 TXTPESO_BRUTO.Text = dados.Substring(5, 5)
				 TXTPESO_BRUTO.Text = FormatNumber(TXTPESO_BRUTO.Text, 2)

				 If TXTPESO_BRUTO.Text.Contains("*") Then
				    Call PEGARPESO_BAL()
				 End If
			   ElseIf TabPageSaida.Focus Then
				 TXTPESO_TARA.Text = "Aguarde....."
				 ' Application.DoEvents()
				 Await Task.Delay(1000)
				 Dim b As Byte() = New Byte(tcpClient.ReceiveBufferSize - 1) {}
				 Await networkStream.ReadAsync(b, 0, tcpClient.ReceiveBufferSize)
				 Await Task.Delay(1300)
				 dados = Encoding.UTF8.GetString(b) 'Encoding.ASCII.GetString(b)  PEGA O PESO
				 TXTPESO_TARA.Text = dados.Substring(5, 5)
				 TXTPESO_TARA.Text = FormatNumber(TXTPESO_TARA.Text, 2)
				 If TXTPESO_TARA.Text.Contains("*") Then
				    Call PEGARPESO_BAL()
				 End If
			   End If
			End If
		  End If
	    End Using
	 Catch ex As Exception
	    TXTPESO_BRUTO.Clear()
	    Call PEGARPESO_BAL()
	 End Try
   End Sub

   Private Async Sub FRMControlePesagemManual__KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
	 If e.KeyCode = Keys.F1 Then
	    TabControl.SelectedTab = TabControl.TabPages(0)
	 Else
	    If e.KeyCode = Keys.F2 Then
		  TabControl.SelectedTab = TabControl.TabPages(1)
	    Else
		  If e.KeyCode = Keys.F3 Then
			TabControl.SelectedTab = TabControl.TabPages(2)
		  Else
			If e.KeyCode = Keys.F4 Then
			   TabControl.SelectedTab = TabControl.TabPages(3)
			Else
			   If e.Alt And e.KeyValue = Keys.L Then
				 BTLIMPAR_Click(BTLIMPAR, e)
			   Else
				 If e.Alt And e.KeyCode = Keys.I Then
				    BTREGISTRAR_Click(BTINSERIR, e)
				 Else
				    If e.Alt And e.Control And e.KeyCode = Keys.P Then
					  '---------------------------------------------------------------------------------------------------------------
					  PEGARPESO_BAL()
					  Await Task.Delay(200)
				    End If
				 End If
			   End If
			End If
		  End If
	    End If
	 End If
   End Sub

   Private Sub BTCARREGAR_Click(sender As Object, e As EventArgs) Handles BTCARREGAR.Click
	 '("select top 5 * from cad_mtr order by código desc")
	 DgvDados.Columns.Clear()
	 Dim SQL = "select * from CAD_CONTROLE_DE_PESAGEM_MANUAL ORDER BY CODIGO DESC"
	 Dim Dal As New CAD_CONTROLE_DE_PESAGEM_MANUAL("BDVITAL.db")

	 With DgvDados
	    .AutoSize = True
	    .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
	    .ColumnHeadersHeight = 50
	 End With
	 DgvDados.DataSource = Dal.GetTabelaViaAdapter(SQL)

	 ''-----------PLACA ENTRADA/SAIDA----------------------
	 'dim completar as new autocompletestringcollection() from {"dal.gettabelaviaadapter(sql)"}
	 'completar.clear()
	 'for each i as object in dgvdados.rows
	 '    completar.add(i.tostring(0))
	 '    if not txtplaca_entrada.text.contains(completar.item(0)) then
	 '        txtplaca_entrada.autocompletecustomsource = completar
	 '        txtplaca_saida.autocompletecustomsource = completar
	 '    end if
	 'next
	 Dim o As New Notifyicone_PopupNotifier()
	 o.Notifyicone_PopupNotifier(vbNewLine + Chr(9) & "  Banco de dados carregado", Chr(9) & Chr(9) & "Atenção", 1000, BTCARREGAR)
	 'Play("Activate.wav")
	 'DgvDados.CurrentCell = DgvDados.Rows(DgvDados.Rows.Count - 1).Cells(0)
   End Sub

   Private Sub DgvDados_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DgvDados.CellValueChanged
	 Dim P As New CAD_CONTROLE_DE_PESAGEM_MANUAL("BDVITAL.db")
	 Dim Tabela As DataTable
	 If DgvDados.DisplayedRowCount(True) > 1 Then '.DisplayedRowCount(True) > 0 Then
	    If MsgBox("Deseja fazer alteração no registro?", vbInformation + vbYesNo, "Cuidado") = DialogResult.Yes Then
		  'Dim P As New CAD_CONTROLE_DE_PESAGEM_MANUAL("BDVITAL.d")
		  P.PLACA = DgvDados.CurrentRow.Cells(1).Value.ToString.Trim 'OK
		  P.PESO_BRUTO = DgvDados.CurrentRow.Cells(2).Value.ToString.Trim 'OK
		  P.MOTORISTA = DgvDados.CurrentRow.Cells(3).Value.ToString.Trim 'OK
		  P.PESO_TARA = DgvDados.CurrentRow.Cells(4).Value.ToString.Trim 'OK
		  P.PESO_LIQUIDO = P.PESO_BRUTO - P.PESO_TARA 'DgvDados.CurrentRow.Cells(4).Value.ToString.Trim 'OK
		  P.CLIENTE = DgvDados.CurrentRow.Cells(6).Value.ToString.Trim
		  P.TRANSPORTADORA = DgvDados.CurrentRow.Cells(7).Value.ToString.Trim
		  P.OPCAO_DE_ENTRADA = DgvDados.CurrentRow.Cells(8).Value.ToString.Trim
		  P.OPCAO_DE_SAIDA = DgvDados.CurrentRow.Cells(9).Value.ToString.Trim
		  P.STATUS = DgvDados.CurrentRow.Cells(10).Value.ToString.Trim
		  P.RESIDUO = DgvDados.CurrentRow.Cells(11).Value.ToString.Trim
		  P.CODIGO = DgvDados.CurrentRow.Cells(0).Value.ToString.Trim
		  If P.Alterar = True Then
			' Exit Sub
			'Tabela = P.GetTabelaViaAdapter("select * from CAD_CONTROLE_DE_PESAGEM_MANUAL ORDER BY CODIGO desc LIMIT 10")
			'IMPLEMENTEI A CLASSE P USAR O USING
			'  Implements IDisposable
			'  Public Sub Dispose() Implements IDisposable.Dispose
			'Throw New NotImplementedException()
			'End Sub

			Dim o As New Notifyicone_PopupNotifier
			o.Notifyicone_PopupNotifier(vbNewLine + Chr(9) & "  Alterações realizadas com exito!", Chr(9) & Chr(9) & "Atenção", 1000, BTCARREGAR)

		  Else
			MsgBox("Problema ao atualizar registro!", vbCritical, "Atualizar Registro")
		  End If
		  Tabela = P.GetTabelaViaAdapter("select * from CAD_CONTROLE_DE_PESAGEM_MANUAL ORDER BY CODIGO desc LIMIT 10")
		  On Error Resume Next
		  DgvDados.DataSource = Tabela
		  On Error Resume Next
		  Exit Sub
	    End If
	    'ATUALIZAR REGISTROS
	    Tabela = P.GetTabelaViaAdapter("select * from CAD_CONTROLE_DE_PESAGEM_MANUAL ORDER BY CODIGO desc LIMIT 10")
	    On Error Resume Next
	    DgvDados.DataSource = Tabela
	    On Error Resume Next
	 End If
   End Sub

   Public Function PegarTodosIpsLocais(OBJ As Object) As IPAddress
	 Dim Host_ As IPHostEntry = Dns.GetHostEntry(My.Computer.Name)
	 Dim Ip_ As IPAddress() = Dns.GetHostAddresses(Host_.HostName) 'Host_.AddressList()
	 OBJ.text = "Ip: " + Ip_(1).ToString
	 Return Ip_(1)
   End Function

   Private Async Sub FRMControlePesagemManual__Load(sender As Object, e As EventArgs) Handles MyBase.Load
	 BTCARREGAR_Click(Me, e)
	 TXTOPCAODEENTRADA.Text = UsuarioLogado.UsuarioLogado() & " " & Now

	 PegarTodosIpsLocais(IPsMaquina)
	 '--------------------ROTINA P CARREGAR A COMBO RESIDUO RESIDUOS------------------------
	 Dim banco1 = New CadResiduo("BDVITAL.db")
	 Dim dt As DataTable
	 Try
	    dt = banco1.Carregar
	    CBOCADASTRARRESIDUOS.DisplayMember = "RESIDUO"
	    CBOCADASTRARRESIDUOS.DataSource = dt
	 Catch ex As Exception
	    MsgBox(ex.Message, vbCritical, "excepção encontrada")
	 End Try
	 Await Task.Delay(150)
	 '------------------ CARREGAR CLIENTES------------
	 Dim banco2 = New Cad_Controle_de_Pesagem_Manual_Cliente("BDVITAL.db")
	 Try
	    dt = banco2.Carregar("BDVITAL.db")
	    CBOCLIENTEENTRADA.DisplayMember = "CLIENTE"
	    CBOCLIENTEENTRADA.DataSource = dt
	 Catch ex As Exception
	    MsgBox(ex.Message, vbCritical, "excepção encontrada")
	 End Try
	 Await Task.Delay(100)
	 '------------CARREGAR TRANSPORTADOR_FORNECEDOR-----------

	 Dim banco3 = New Cad_Controle_de_Pesagem_Manual_Transportador("BDVITAL.db")
	 Try
	    dt = banco3.Carregar("BDVITAL.db")
	    CBOTRANSPORTADORENTRADA.DisplayMember = "TRANSPORTADOR_FORNECEDOR"
	    CBOTRANSPORTADORENTRADA.DataSource = dt
	 Catch ex As Exception
	    MsgBox(ex.Message, vbCritical, "excepção encontrada")
	 End Try
	 Await Task.Delay(100)
	 '---------------txtmotorista_de Entrada,PLACA autocompletar----------------
	 Try
	    Dim dt1, dt2, dt3 As Object
	    Dim banco4 = New CAD_CONTROLE_DE_PESAGEM_MANUAL("BDVITAL.db")
	    Dim banco5 = New CAD_CONTROLE_DE_PESAGEM_MANUAL("BDVITAL.db")
	    Dim banco6 = New CAD_CONTROLE_DE_PESAGEM_MANUAL("BDVITAL.db")
	    dt1 = banco4.Preenchimento_Automatico_Text("Select PLACA FROM CAD_CONTROLE_DE_PESAGEM_MANUAL")
	    TXTPLACA_ENTRADA.AutoCompleteCustomSource = dt1 'banco4.Completar 'dt1
	    dt2 = banco5.Preenchimento_Automatico_Text("Select MOTORISTA FROM CAD_CONTROLE_DE_PESAGEM_MANUAL")
	    TXTMOTORISTA_ENTRADA.AutoCompleteCustomSource = dt2
	    dt3 = banco6.Preenchimento_Automatico_Text("Select PLACA FROM CAD_CONTROLE_DE_PESAGEM_MANUAL")
	    TXTPLACA_SAIDA.AutoCompleteCustomSource = dt3
	 Catch ex As Exception
	    MsgBox(ex.Message, vbCritical, "excepção encontrada")
	 End Try
	 Application.DoEvents()
	 LIMPAR_CONTROLES.LIMPAR_CONTROLES(Me)
	 Application.DoEvents()
   End Sub

   Private Sub FRMControlePesagemManual__KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
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

   Private Async Sub BTDELETAR_Click(sender As Object, e As EventArgs) Handles BTDELETAR.Click
	 Dim K As New CAD_CONTROLE_DE_PESAGEM_MANUAL("BDVITAL.db")
	 Dim Contar As Integer = 0
	 If FrmMTR._jjj.RadioButtonServer.Checked = True Then
	    If DgvDados.Rows.Count > 0 Then
		  If MsgBox("excluir registro?", MsgBoxStyle.Critical + MsgBoxStyle.YesNo, "Cuidado") = DialogResult.Yes Then
			Dim P = InputBox_Personalizado("Digite o Código do registro a ser excluído!", "Deleção", Nothing, True, True)
			If P <> String.Empty And P <> "" And IsNumeric(P) Then
			   K.CODIGO = P
			   If K.Excluir(P) = True Then
				 Await Task.Delay(2200)
				 info.Notifyicone_PopupNotifier(vbCrLf & "            < " & "item <deletado com êxito!! > ", "                             ...Informativo...", 1000, Me)
				 Dim Dal As New CAD_CONTROLE_DE_PESAGEM_MANUAL("BDVITAL.db")
				 With DgvDados
				    .AutoSize = True
				    .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
				    .ColumnHeadersHeight = 50
				 End With
				 DgvDados.DataSource = Dal.GetTabelaViaAdapter("select * from CAD_CONTROLE_DE_PESAGEM_MANUAL")
			   End If
			End If
		  Else
			info.Notifyicone_PopupNotifier(vbCrLf & "            < <Cancelado pelo Usuario! > ", "                             ...Informativo...", 1000, BTINSERIR)
		  End If
	    End If
	 Else
	    If DgvDados.Rows.Count > 0 Then
		  If MsgBox("Excluir registro?", MsgBoxStyle.Critical + MsgBoxStyle.YesNo, "Cuidado") = DialogResult.Yes Then
			Dim P = InputBox_Personalizado("DIGITE O CÓDIGO DO REGISTRO A SER EXCLUÍDO!", "Deleção", Nothing, False, False)
			If P <> String.Empty And P <> "" And IsNumeric(P) Then
			   K.CODIGO = P
			   If K.Excluir(P) = True Then
				 Await Task.Delay(200)
				 Dim Dal As New CAD_CONTROLE_DE_PESAGEM_MANUAL("BDVITAL.db")
				 With DgvDados
				    .AutoSize = True
				    .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
				    .ColumnHeadersHeight = 50
				 End With
				 DgvDados.DataSource = Dal.GetTabelaViaAdapter("select * from CAD_CONTROLE_DE_PESAGEM_MANUAL ORDER BY CODIGO desc LIMIT 10")
				 info.Notifyicone_PopupNotifier(vbCrLf & "            < " & " item <deletado com êxito!! > ", "                             ...Informativo...", 1000, Me)
			   End If
			Else
			   MsgBox("Não foi possivel excluir o registro! " & Chr(13) & "Verifique se foi digitado corretamente", MsgBoxStyle.Critical)
			End If
		  Else
			info.Notifyicone_PopupNotifier(vbCrLf & "            < <Cancelado pelo Usuario! > ", "                             ...Informativo...", 1000, BTINSERIR)
		  End If
	    End If
	 End If
	 'DgvDados.CurrentCell = DgvDados.Rows(DgvDados.Rows.Count - 1).Cells(0)
   End Sub
   Private I As New Internet
   Private Sub BTIR_Click(sender As Object, e As EventArgs) Handles BTpesquisar.Click
	 If Not TXTCNPJ.Text Is String.Empty Then
	    If IsNumeric(TXTCNPJ.Text) Then
		  If TXTCNPJ.TextLength = 14 Then
			I.PCnpj(TXTCNPJ.Text, TXTResult)

			Dim F_Conf_ = JsonConvert.DeserializeObject(Of DadosEmpresa)(I.Retorno)
			TreeView_Atividades.Nodes.Clear()
			LblFantasia.Text = $"Fantasia: {F_Conf_.fantasia}"
			LblNome.Text = $"Nome: {F_Conf_.nome}"

			With LblData_Situacao
			   .Text = $"Data_situacao: {F_Conf_.data_situacao}"
			   .ForeColor = Color.Blue
			End With

			LblUF.Text = $"UF: {F_Conf_.uf}"
			LblCnpj.Text = $"Cnpj: {F_Conf_.cnpj}"

			With LblTipo
			   .Text = $"Tipo: {F_Conf_.tipo}"
			   .ForeColor = Color.Blue
			End With

			LblNatureza_juridica.Text = $"Natureza Juridica: { F_Conf_.natureza_juridica}"
			With LblBairro
			   .Text = $"Bairro: {F_Conf_.bairro}"
			   .ForeColor = Color.Blue
			End With

			With LblTelefone
			   .Text = $"Telefone: {F_Conf_.telefone}"
			   .ForeColor = Color.SaddleBrown
			End With

			With LblEmail
			   .Text = $"Email: {F_Conf_.email}"
			   .ForeColor = Color.DimGray
			End With

			LblSituacao.Text = $"Situação: {F_Conf_.situacao}"
			If LblSituacao.Text = "Situação: ATIVA" Then
			   LblSituacao.ForeColor = Color.Green
			Else
			   LblSituacao.ForeColor = Color.Red
			End If
			LblLogradouro.Text = $"Logradouro: {F_Conf_.logradouro}"
			LblNumero.Text = $"Número: {F_Conf_.numero}"
			With LblMunicipio
			   .Text = $"Município: {F_Conf_.municipio}"
			   .ForeColor = Color.Blue
			End With
			LblCep.Text = $"Cep: {F_Conf_.cep}"
			LblPorte.Text = $"Porte: {F_Conf_.porte}"
			With LblAbertura
			   .Text = $"Abertura: {F_Conf_.abertura}"
			   .ForeColor = Color.Blue
			End With
			With LblUltima_atualizacao
			   .Text = $"Ult.Atualização: {F_Conf_.ultima_atualizacao}"
			   .ForeColor = Color.Blue
			End With
			With LblStatus
			   .Text = $"Status: {F_Conf_.status}"
			   If .Text = "Status: OK" Then .ForeColor = Color.Green Else .ForeColor = Color.Red
			End With
			LblComplemento.Text = $"Complemento: {F_Conf_.complemento}"
			LblEfr.Text = $"Efr: {F_Conf_.efr}"
			LblMotivo_situacao.Text = $"{F_Conf_.motivo_situacao}"
			LblSituacao_especia.Text = $"Situação Especial: {F_Conf_.situacao_especial}"
			LblData_Situacao.Text = $"Data da situação: {F_Conf_.data_situacao}"
			LblData_situacao_especial.Text = $"Data Situa Especial: {F_Conf_.data_situacao_especial}"

			TreeView_Atividades.Nodes.Add("Atividade Principal")
			TreeView_Atividades.Nodes.Add("Atividade Secundárias")

			For Each CONTROLEPESAGEM In F_Conf_.atividade_principal
			   TreeView_Atividades.Nodes.Item(0).Nodes.Add($"Codigo: {CONTROLEPESAGEM.code}")
			   TreeView_Atividades.Nodes.Item(0).Nodes.Add($"Descrição: {CONTROLEPESAGEM.text}")
			   For Each k2 In F_Conf_.atividades_secundarias
				 TreeView_Atividades.Nodes.Item(1).Nodes.Add($"Codigo: {k2.code}")
				 TreeView_Atividades.Nodes.Item(1).Nodes.Add($"Descrição: {k2.text}")
			   Next
			Next

		  Else
			MsgBox("Verifique se não está faltando dígitos!", MsgBoxStyle.Exclamation + vbOKOnly, "Atenção")
			TXTCNPJ.Focus()
		  End If
	    Else
		  MsgBox("Não é permitido letras!", MsgBoxStyle.Exclamation + vbOKOnly, "Atenção")
		  TXTCNPJ.Focus()
	    End If
	 Else
	    MsgBox("Nenhum critério foi inserido!", MsgBoxStyle.Exclamation + vbOKOnly, "Atenção")
	    TXTCNPJ.Focus()
	 End If
   End Sub

   Private Sub TXTCNPJ_KeyDown(sender As Object, e As KeyEventArgs) Handles TXTCNPJ.KeyDown
	 If e.KeyCode = Keys.Enter Then
	    Dim Palavra As String = TXTCNPJ.Text
	    Dim MyChar_excluir() As Char = {"-", "/", ".", " "}
	    For Each x As Char In MyChar_excluir
		  Palavra = Palavra.Replace(x, "")
	    Next
	    TXTCNPJ.Text = Palavra
	    BTpesquisar.PerformClick()
	 End If
   End Sub

   Public Function EnviarEmail(ByVal StrDestino As String, ByVal DisplayName As String) As Boolean
	 Dim Obj_SMTP_Server As Net.Mail.SmtpClient = Nothing
	 Dim ObjEmail As Net.Mail.MailMessage = Nothing
	 Dim BlnRetorno As Boolean = False
	 Try
	    Obj_SMTP_Server = New Mail.SmtpClient(TXTto.Text, TxtPorta.Text) With {
				 .EnableSsl = True
			  }
	    ObjEmail = New Mail.MailMessage
	    ObjEmail.IsBodyHtml = False
	    'emaildestino  
	    ObjEmail.To.Add(New Net.Mail.MailAddress(StrDestino, DisplayName))
	    'email remetente
	    ObjEmail.From = New Mail.MailAddress(TXTto.Text, TXTfrom.Text)
	    'setar prioridade
	    If ObjEmail.ToString IsNot Nothing Then
		  Select Case CBOPrioridade.Text
			Case "Alta"
			   ObjEmail.Priority = Mail.MailPriority.High
			Case "Normal"
			   ObjEmail.Priority = Mail.MailPriority.Normal
			Case "Baixa"
			   ObjEmail.Priority = Mail.MailPriority.Low
			Case ""
			   MsgBox("Escolha uma prioridade!", MsgBoxStyle.Information, "Parametrizando Mensagem")
			   CBOPrioridade.Focus()
		  End Select
	    End If
	    'setar confirmação de leitura
	    ObjEmail.Headers.Add("Disposition-Notification-To", TXTSubject.Text)
	    'setar mensagem do texo
	    Dim Messagem As Mail.AlternateView = Mail.AlternateView.CreateAlternateViewFromString(TXTmessage.Text, Nothing, Mime.MediaTypeNames.Text.Plain)
	    'setar as credenciais
	    Dim Credencial As New NetworkCredential("marcosferreira", "ferreira")
	    Obj_SMTP_Server.Credentials = Credencial
	    'enviar email
	    Obj_SMTP_Server.Send(ObjEmail)
	    'retorna
	    BlnRetorno = True
	 Catch ex As Exception
	    MessageBox.Show("-------------detalhes------------- " & Chr(13) & ex.Message.ToString)
	 Finally
	    ObjEmail = Nothing
	    Obj_SMTP_Server = Nothing
	 End Try
	 Return BlnRetorno
   End Function

   'validação de dados
   Private Function ValidaDados(ByVal Obj1 As Object, Optional OBJ2 As Object = Nothing, Optional OBJ3 As Object = Nothing) As Boolean
	 If String.IsNullOrWhiteSpace(Obj1.Text) Then
	    Return False
	 ElseIf String.IsNullOrWhiteSpace(OBJ2.Text) Then
	    Return False
	 ElseIf String.IsNullOrWhiteSpace(OBJ3.Text) Then
	    Return False
	 Else
	    Return True
	 End If
   End Function
   Private Sub TxtEnviarEmail_Click(sender As Object, e As EventArgs) Handles TxtEnviarEmail.Click

	 Try
	    'Dim SmtpServer As New Mail.SmtpClient("smtp.gmail.com", "587")
	    Dim SmtpServer As New Mail.SmtpClient
	    Dim email As New Mail.MailMessage   'representa uma mensagem de email
	    SmtpServer.UseDefaultCredentials = False
	    SmtpServer.Credentials = New NetworkCredential(TXTNomeUserEmail.Text, TxtSenha.Text)   '("mmarcos.fferreira078@gmail.com", "Senha0789") '1 param meu email, 2 param é a senha
	    SmtpServer.Port = TxtPorta.Text  ';587
	    email.Headers.Add("Disposition-Notification-To", TXTSubject.Text)
	    SmtpServer.EnableSsl = True
	    'Selecionar host do servidor a ser usado
	    Select Case CboServidor.SelectedItem.ToString
		  Case "smtp.gmail.com"
			SmtpServer.Host = "smtp.gmail.com"
		  Case "smtp.live.com"
			SmtpServer.Host = "smtp.live.com"
		  Case "smtp.terra.com"
			SmtpServer.Host = "Smtp.terra.com"
		  Case "smtps.uol.com.br﻿"
			SmtpServer.Host = "Smtps.uol.com.br﻿"
		  Case "Mail.yahoo.com"
			SmtpServer.Host = "Mail.yahoo.com"
		  Case "Smtps.bol.com.br﻿"
			SmtpServer.Host = "Smtps.bol.com.br﻿"
		  Case "smtp.office365.com"
			SmtpServer.Host = "smtp.office365.com"
		  Case Else
			MsgBox("Servidor não cadastrado na lista")
	    End Select

	    'EXISTE DIFERENÇAS P CADA SERVIDOR
	    'EXEMPLO: HOTMAIL= smtp.live.com  'a porta é a 587
	    '         GMAIL= smt.gmail.com    'a porta é a 587 para gmail tem q autorizar o google a aceitar aplicação menos seguara
	    ''neste link : https://myaccount.google.com/lesssecureapps         
	    email = New Mail.MailMessage With {.From = New Mail.MailAddress(TXTfrom.Text)}
	    email.To.Add(TXTto.Text)
	    email.Subject = TXTSubject.Text
	    email.IsBodyHtml = False
	    email.Body = TXTmessage.Text

	    'setar prioridade
	    If email.ToString IsNot Nothing Then
		  Select Case CBOPrioridade.Text
			Case "Alta"
			   email.Priority = Mail.MailPriority.High
			Case "Normal"
			   email.Priority = Mail.MailPriority.Normal
			Case "Baixa"
			   email.Priority = Mail.MailPriority.Low
			Case ""
			   MsgBox("Escolha uma prioridade!", MsgBoxStyle.Information, "Parametrizando Mensagem")
			   CBOPrioridade.Focus()
		  End Select
	    End If
	    'Set anexos adicionando-os um por um
	    For i As Integer = 0 To Lista_de_Anexos.Items.Count - 1
		  email.Attachments.Add(New Mail.Attachment(Lista_de_Anexos.Items(i)))
	    Next
	    SmtpServer.Send(email)
	    MsgBox("Email enviado com sucesso. Obrigado! :) ", vbInformation, "Atenção")
	 Catch ex As Exception
	    MsgBox(ex.Message.ToString)
	 End Try
   End Sub

   Private Sub TXTfrom_TextChanged(sender As Object, e As EventArgs) Handles TXTfrom.TextChanged
	 TXTNomeUserEmail.Text = TXTfrom.Text
   End Sub
   Private Sub TxtEnviarEmail_Leave(sender As Object, e As EventArgs) Handles TxtEnviarEmail.Leave
	 Me.TxtEnviarEmail.PressedColor = Color.White
   End Sub
   Private Sub TxtEnviarEmail_Enter(sender As Object, e As EventArgs) Handles TxtEnviarEmail.Enter
	 Me.TxtEnviarEmail.PressedColor = Color.Khaki
   End Sub

   Private Sub Guna2Button1_Click(sender As Object, e As EventArgs)
	 If MsgBox("Deseja fazer alteração do registro selecionado?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Atenção") = DialogResult.Yes Then
	 Else
	    MsgBox("Cancelado pelo usuário(a): " & UsuarioLogado.UsuarioLogado, MsgBoxStyle.Information, "Controle de Pesagem Manual")
	 End If
   End Sub

   Dim Anexos_ As System.Net.Mail.Attachment
   Public Property Salvar As (Json As String, String)


   Public Sub New()
	 ' Esta chamada é requerida pelo designer.
	 InitializeComponent()
	 ' Adicione qualquer inicialização após a chamada InitializeComponent().


   End Sub

   Private Sub BTincluiranexos_Click(sender As Object, e As EventArgs) Handles BTincluiranexos.Click
	 Dim OFD As New OpenFileDialog With {.CheckFileExists = True, .Title = "Selecione uma arquivo para Indexar"} 'iniciliaza uma instancia c aalguma spropriedades
	 OFD.ShowDialog() ' abre a caixa modal para escolher os arquivos
	 Dim Contar As Integer = 0
	 For Contar = 0 To UBound(OFD.FileNames)
	    Lista_de_Anexos.Items.Add(OFD.FileNames(Contar))
	 Next
   End Sub

   Private Sub BTexcluiranexos_Click(sender As Object, e As EventArgs) Handles BTexcluiranexos.Click
	 'remove os anexos 
	 If Lista_de_Anexos.SelectedIndex > -1 Then 'se lista de seleção for > que nada porque 0 corresponde a um item de indice zero
	    Lista_de_Anexos.Items.RemoveAt(Lista_de_Anexos.SelectedIndex)
	 End If
   End Sub

   Private Sub BTPESARENTRADA_Click(sender As Object, e As EventArgs) Handles BTPESARENTRADA.Click
	 PEGARPESO_BAL()
   End Sub
   Private Sub BTPESARSAIDA_Click(sender As Object, e As EventArgs) Handles BTPESARSAIDA.Click
	 PEGARPESO_BAL()
   End Sub

   Private Sub BTcadastrarResiduo_Click(sender As Object, e As EventArgs) Handles BTcadastrarResiduo.Click
	 Dim Banco = New CadResiduo("BDVITAL.db")
	 'Dim IB = InputBox("Digite o nome do resíduo!", "Cadastro de resíduos",, 340, 340)
	 'Dim IB = InputBox_Personaliza("Digite o nome do resíduo!", vbTab & "Cadastro de resíduos", ValorPadrao_)
	 Dim IBP As Object = ImputBoxPersonalizado.InputBox_Personalizado("Digite o nome do resíduo a ser cadastrado?",
														    vbTab & UCase(UsuarioLogado.UsuarioLogado()),
														    BunifuCustomTextbox1.Text)

	 If IBP <> String.Empty And IBP <> "" Then
	    Banco.RESIDUO = UCase(IBP)  'ATRIBUO A MINHA PROPRIEDADE O VALOR DA VARIAVEL

	    If Banco.Adicionar = True Then
		  MsgBox("Cadastro do novo Resíduo efetuado corretamente!", vbInformation, "Informação")

		  Dim dt As DataTable
		  Try
			dt = Banco.Carregar
			CBOCADASTRARRESIDUOS.DisplayMember = "residuo"
			CBOCADASTRARRESIDUOS.DataSource = dt
		  Catch ex As Exception
			MsgBox(ex.Message, vbCritical, "excepção encontrada")
		  End Try
	    Else
		  IBP = DialogResult.Cancel
		  MsgBox("Você cancelou a operação ou não digitou!", vbInformation, "Informação")
	    End If
	 End If
   End Sub

   Private Sub BTcadastrarCliente_Click(sender As Object, e As EventArgs) Handles BTcadastrarCliente.Click
	 Dim Banco = New Cad_Controle_de_Pesagem_Manual_Cliente("BDVITAL.db")
	 'Dim IB = InputBox("Digite o nome do Cliente a ser cadastrado!", "Cadastro de Clientes",, 340, 340)
	 Dim IBP As Object = ImputBoxPersonalizado.InputBox_Personalizado("Digite o nome do Cliente a ser cadastrado?",
														    vbTab & UCase(UsuarioLogado.UsuarioLogado()),
														    BunifuCustomTextbox1.Text)
	 If IBP <> String.Empty And IBP <> "" Then
	    Banco.Cliente = UCase(IBP)  'ATRIBUO A MINHA PROPRIEDADE O VALOR DA VARIAVEL
	    If Banco.Adicionar = True Then
		  MsgBox("Cadastro do novo Cliente efetuado corretamente!", vbInformation, "Informação")
		  Dim dt As DataTable
		  Try
			dt = Banco.Carregar("bdvital.db")
			CBOCLIENTEENTRADA.DisplayMember = "cliente"
			CBOCLIENTEENTRADA.DataSource = dt
		  Catch ex As Exception
			MsgBox(ex.Message, vbCritical, "excepção encontrada")
		  End Try
	    Else
		  IBP = DialogResult.Cancel
		  MsgBox("Você cancelou a operação ou não digitou!", vbInformation, "Informação")
	    End If
	 End If
   End Sub

   Private Sub BTcadastrarTransportadora_Click(sender As Object, e As EventArgs) Handles BTcadastrarTransportadora.Click
	 Dim Banco = New Cad_Controle_de_Pesagem_Manual_Transportador("BDVITAL.db")
	 'Dim IB = InputBox("Digite o nome do Transportador/Fornecedor a ser cadastrado!", "Cadastro de Transportador/Fornecedor",, 340, 340)
	 Dim IBK As Object = ImputBoxPersonalizado.InputBox_Personalizado("Digite o nome do Transportador/Fornecedor a ser cadastrado!",
														    vbTab & UCase(UsuarioLogado.UsuarioLogado()),
														    BunifuCustomTextbox1.Text)
	 If IBK <> String.Empty And IBK <> "" Then
	    Banco.Transportador_Fornecedor = UCase(IBK)  'ATRIBUO A MINHA PROPRIEDADE O VALOR DA VARIAVEL
	    If Banco.Adicionar = True Then
		  MsgBox("Cadastro do Transportador/Fornecedor efetuado corretamente!", vbInformation, "Informação")
		  Dim dt As DataTable
		  Try
			dt = Banco.Carregar("bdvital.db")
			CBOTRANSPORTADORENTRADA.DisplayMember = "TRANSPORTADOR_FORNECEDOR"
			CBOTRANSPORTADORENTRADA.DataSource = dt
		  Catch ex As Exception
			MsgBox(ex.Message, vbCritical, "excepção encontrada")
		  End Try
	    Else
		  IBK = DialogResult.Cancel
		  MsgBox("Você cancelou a operação ou não digitou!", vbInformation, "Informação")
	    End If
	 End If
   End Sub
   Private Sub TXTOPCAODEENTRADA_GotFocus(sender As Object, e As EventArgs) Handles TXTOPCAODEENTRADA.GotFocus
	 UsuarioLogado.UsuarioLogado()
   End Sub

   Private Sub TXTOPCAODEENTRADA_TextChanged(sender As Object, e As EventArgs) Handles TXTOPCAODEENTRADA.TextChanged
	 UsuarioLogado.UsuarioLogado()
   End Sub

   Private Sub TXTPLACA_SAIDA_Leave(sender As Object, e As EventArgs) Handles TXTPLACA_SAIDA.Leave
	 Dim CONTROLEPESAGEM As New CAD_CONTROLE_DE_PESAGEM_MANUAL("BDVITAL.db")
	 'NESTE EVENTO VAMOS FAZER A PESQUISA SE EXISTE UMA PESAGEM EM ABERTO

	 If TXTPLACA_SAIDA.TextLength = 7 Then
	    Dim query As String =
	    "SELECT CODIGO, PLACA,PESO_BRUTO,MOTORISTA,PESO_TARA,PESO_LIQUIDO,CLIENTE,TRANSPORTADORA,OPCAO_DE_ENTRADA,OPCAO_DE_SAIDA,STATUS,RESIDUO FROM CAD_CONTROLE_DE_PESAGEM_MANUAL WHERE PLACA='" & TXTPLACA_SAIDA.Text & "' AND STATUS='EM ABERTO'"
	    If CONTROLEPESAGEM.BuscarPsagemAberto(query) = True Then
		  'PLACA DIGITADA
		  TXTPESOBRUTO_LEITURA.Text = FormatNumber(CONTROLEPESAGEM.PESO_BRUTO, 2)
		  TXTRESIDUO.Text = CONTROLEPESAGEM.RESIDUO
		  TXTMOTORISTA_SAIDA.Text = CONTROLEPESAGEM.MOTORISTA
		  TXTCLIENTESAIDA.Text = CONTROLEPESAGEM.CLIENTE
		  TXTTRASNPORTADORSAIDA.Text = CONTROLEPESAGEM.TRANSPORTADORA
		  TxtOpcaoEntrada_Saida.Text = CONTROLEPESAGEM.OPCAO_DE_ENTRADA
		  TXTOPCAODESAIDA.Text = UCase(UsuarioLogado.UsuarioLogado() & " " & Now)
		  TXTSTATUS.Text = CONTROLEPESAGEM.STATUS
		  LBLCODIGO.Text = CONTROLEPESAGEM.CODIGO
	    End If
	 End If
   End Sub
   Private Sub FRMControlePesagemManual__TextChanged(sender As Object, e As EventArgs) Handles MyBase.TextChanged
	 TXTOPCAODESAIDA.Text = UCase(UsuarioLogado.UsuarioLogado() & " " & Now)
   End Sub
   Public Shared Function Getdados(Query As String) As DataTable
	 Dim P As New CAD_CONTROLE_DE_PESAGEM_MANUAL("BDVITAL.db")
	 Dim Conexao As New SQLite.SQLiteConnection("Data Source=" & Application.StartupPath & "\BD\" & "BDVITAL.db")
	 Dim Con As New SQLite.SQLiteConnection(Conexao.ConnectionString)
	 Con.Open()
	 Dim dt As New DataTable
	 Try
	    Using da As New SQLite.SQLiteDataAdapter(Query, Conexao)
		  da.Fill(dt)
		  Return dt
	    End Using
	 Catch ex As Exception
	    MsgBox(ex.Message)
	 End Try
	 Return dt
   End Function
   Private Sub TXTMOTORISTA_ENTRADA_Enter(sender As Object, e As EventArgs) Handles TXTMOTORISTA_ENTRADA.Enter
	 Getdados("select MOTORISTA from CAD_CONTROLE_DE_PESAGEM_MANUAL where MOTORISTA LIKE'" & TXTMOTORISTA_ENTRADA.Text & "%'")                 'LIKE '%'" & TXTMOTORISTA_ENTRADA.Text & "'%'")
   End Sub
   Private Sub TXTPLACA_ENTRADA_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTPLACA_ENTRADA.KeyPress
	 If e.KeyChar = Chr(45) Then
	    e.Handled = True
	 End If
   End Sub

   Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
	 'Dim P As Object = InputBox("Digite a quantidade de registros a ser visualizada na grade!", "Visualização!", "", 320, 320)
	 'Dim p As New ImputBoxPersonalizado("Digite a quantidade de registros a ser visualizada na grade!", "formPrompt", "Caption")
	 Dim P As Object = ImputBoxPersonalizado.InputBox_Personalizado("Atualizar a grade com quantos registros?.", vbTab & UsuarioLogado.UsuarioLogado(), BunifuCustomTextbox1.Text)
	 If P <> String.Empty And IsNumeric(P) Then
	    DgvDados.DataSource = New CAD_CONTROLE_DE_PESAGEM_MANUAL("BDVITAL.db").GetTabelaViaAdapter("select * from CAD_CONTROLE_DE_PESAGEM_MANUAL ORDER BY CODIGO desc LIMIT " & P)
	 End If
   End Sub

   <STAThreadAttribute>
   Private Sub LblEmail_DoubleClick(sender As Object, e As EventArgs)
	 'Dim Tarefa = Task.Run(AddressOf Copiarconteudo)
	 Copiarconteudo(LblEmail)
   End Sub
   Private Sub Copiarconteudo(sender As Object)
	 If MsgBox("Deseja copiar o conteúdo para área de tranferência do Windows?", MsgBoxStyle.Information + vbYesNo) = vbYes Then
	    If Clipboard.ContainsText Then Clipboard.Clear()
	    If sender.Text <> Nothing Then
		  Clipboard.SetText(sender.Text)
		  MsgBox("Texto copiado do objeto " & sender.name & ": " & Clipboard.GetText)
	    End If
	 End If
   End Sub

#Region "Clipboard- Copiar p área de transferencia do windoes valores das label"
   Private Sub LblNome_DoubleClick(sender As Object, e As EventArgs) Handles LblNome.DoubleClick
	 Copiarconteudo(LblNome)
   End Sub
   Private Sub LblFantasia_DoubleClick(sender As Object, e As EventArgs) Handles LblFantasia.DoubleClick
	 Copiarconteudo(LblFantasia)
   End Sub
   Private Sub Cnpj_DoubleClick(sender As Object, e As EventArgs) Handles LblCnpj.DoubleClick
	 Copiarconteudo(LblCnpj)
   End Sub
   Private Sub NaturezaJuridica_DoubleClick(sender As Object, e As EventArgs) Handles LblNatureza_juridica.DoubleClick
	 Copiarconteudo(LblNatureza_juridica)
   End Sub
   Private Sub Bairro_DoubleClick(sender As Object, e As EventArgs) Handles LblBairro.DoubleClick
	 Copiarconteudo(LblBairro)
   End Sub

   Private Sub Telefone_DoubleClick(sender As Object, e As EventArgs) Handles LblTelefone.DoubleClick
	 Copiarconteudo(LblTelefone)
   End Sub
   Private Sub Email_DoubleClick(sender As Object, e As EventArgs) Handles LblEmail.DoubleClick
	 Copiarconteudo(LblEmail)
   End Sub
   Private Sub Logradouro_DoubleClick(sender As Object, e As EventArgs) Handles LblLogradouro.DoubleClick
	 Copiarconteudo(LblLogradouro)
   End Sub
   Private Sub Numero_DoubleClick(sender As Object, e As EventArgs) Handles LblNumero.DoubleClick
	 Copiarconteudo(LblNumero)
   End Sub
   Private Sub Municipio_DoubleClick(sender As Object, e As EventArgs) Handles LblMunicipio.DoubleClick
	 Copiarconteudo(LblMunicipio)
   End Sub
   Private Sub Cep_DoubleClick(sender As Object, e As EventArgs) Handles LblCep.DoubleClick
	 Copiarconteudo(LblCep)
   End Sub
   Private Sub Situacao_DoubleClick(sender As Object, e As EventArgs) Handles LblSituacao.DoubleClick
	 Copiarconteudo(LblSituacao)
   End Sub

#End Region

End Class
