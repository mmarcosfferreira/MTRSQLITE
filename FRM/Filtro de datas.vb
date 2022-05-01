Imports System.Drawing.Printing

Public Class FRMFiltroDatas



   Private PaginaAtual As Integer = 1
   Private RelatorioTitulos



   Private Sub Begin_Print(sender As Object, e As PrintEventArgs)
	 PaginaAtual = 1
   End Sub

   'ou seja p imprimir c estes componentes precisa dos tres eventos se n dara erro
   Private Sub End_Print(ByVal sender As Object, ByVal e As Printing.PrintEventArgs)

   End Sub

   'Netse evento é onde vai muitos códigos
   'pois é aqui mque definimos a forma que a impressão vai tomar ou seja 
   'O layout da pagina a imprimir

   Private Sub PdRelatorios_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs)
	 'variaveis das linhas
	 Dim LinhasPorPaginas As Single = 0 'defindo quantas linhas por paginas eu vou ter
	 Dim PosiçãoDaLinha As Single = 0   'Qual é a posição dalinha  
	 Dim LinhaAtual As Integer = 0      'Qual é a linha atual
	 ' então p fazer isto estou usando o Obnjeto PrintPageEventArgs que é representado pela variavel e
	 '=========================================================================================================================

	 'Variaveis das margens(e.MarginBounds obtem a área retangular que representa a parte da página dentro das margens.)
	 Dim MargemEsquerda As Single = 0 ' e.MarginBounds.Left  'defindo a margem equerda
	 Dim MargemSuperior As Single = e.MarginBounds.Top + 100  'A margem superior q incluo mais 100 un por causa do titulo
	 Dim MargemDireita As Single = 0 'e.MarginBounds.Right        'A Margem direira
	 Dim MargemInferior As Single = 0 'e.MarginBounds.Bottom      'A Margem inferior
	 '======================================================================================



	 'Classe Pen define um Objeto usado para definir as linhas e curvas
	 ' Dim CanetaDaImpressora As Pen = New Pen(Color.Black, 1)
	 'Dim Placa, Pentrada, Psaida, Pliquido, Motorista, Cliente, Trasnportadora, OpEntrada, OpSaida, Status, Resíduo As String
	 '=====================================================Campos da tabela========================================================

	 'definimos agora variaveis que serão usadas p impreensão´que serão usadas na listview referentes aos campos
	 'da tabela,


	 'LVCONTROLEDEPESAGEMMANUAL.View = View.Details
	 'LVCONTROLEDEPESAGEMMANUAL.Columns.Add("PLACA", 100, HorizontalAlignment.Right) ' INDEX 0
	 'LVCONTROLEDEPESAGEMMANUAL.Columns.Add("P.ENTRADA", 70, HorizontalAlignment.Left) ' INDEX 1
	 'LVCONTROLEDEPESAGEMMANUAL.Columns.Add("P.SAIDA", 70, HorizontalAlignment.Left)   ' INDEX 2
	 'LVCONTROLEDEPESAGEMMANUAL.Columns.Add("P.LIQUIDO", 50, HorizontalAlignment.Left)    ' INDEX 3
	 'LVCONTROLEDEPESAGEMMANUAL.Columns.Add("MOTORISTA", 120, HorizontalAlignment.Left)       ' INDEX 4
	 'LVCONTROLEDEPESAGEMMANUAL.Columns.Add("CLIENTE", 180, HorizontalAlignment.Left)         ' INDEX 5
	 'LVCONTROLEDEPESAGEMMANUAL.Columns.Add("TRASPORTADORA", 180, HorizontalAlignment.Left)   ' INDEX 6
	 'LVCONTROLEDEPESAGEMMANUAL.Columns.Add("OPÇÃO DE ENTRADA", 210, HorizontalAlignment.Left) ' INDEX 7 
	 'LVCONTROLEDEPESAGEMMANUAL.Columns.Add("OPÇÃO DE SAIDA", 210, HorizontalAlignment.Left)   ' INDEX 8
	 'LVCONTROLEDEPESAGEMMANUAL.Columns.Add("STATUS", 89, HorizontalAlignment.Left)             'INDEX 9
	 'LVCONTROLEDEPESAGEMMANUAL.Columns.Add("RESÍDUO", 120, HorizontalAlignment.Left)            'INDEX 10

	 '=============================================================================================================================

	 '======================================'Definindo as fontes que serão usadas p impressão=================================
	 Dim FonteNegrito As Font = New Font("Arial", 9, FontStyle.Bold)
	 Dim FonteTitulo As Font = New Font("Arial", 15, FontStyle.Bold)
	 Dim FonteSubtitulo As Font = New Font("Arial", 12, FontStyle.Bold)
	 Dim FonteRodape As Font = New Font("Arial", 8)
	 Dim FonteNormal As Font = New Font("Arial", 8)

	 '===============================================================================================================================


	 '=================================Define valores para linha atual e p linha de impressão========================================
	 LinhaAtual = 0
	 ' cabeçario
	 'drawline - Desenha uma linha q conecta os dois pontos especificados pelos pares ordenados os seja
	 ' A linha da Borda da página   

	 ' aqui faço o desenho quadrado q no seu interior vou desenha oq colocar usando o código abaixo isto tudo dentro do interior deste linha ou quadrado
	 ' e.Graphics.DrawLine(CanetaDaImpressora, MargemEsquerda, 100, MargemDireita, 100) '  60 quando matenho o memso valor significa q vai desenha uma linha desenha uma linha no plano horizontal especificado
	 'e.Graphics.DrawLine(CanetaDaImpressora, MargemEsquerda, 160, MargemDireita, 160) '160,160


	 '=============================================Definir o Nome Da Empresa dentro do quadrado=========================================
	 'e.Graphics.DrawString(My.Settings.NomeDaEmpresa, FonteTitulo, Brushes.Blue, MargemEsquerda + 280, 80, New StringFormat()) '  OK
	 'e.Graphics.DrawString("Relatório", FonteTitulo, Brushes.Blue, MargemEsquerda + 360, 37, New StringFormat())

	 '====================================='imprime o logo tipo da empresa ===============================================================
	 ' e.Graphics.DrawImage(Image.FromFile("C:\Develop SGP\Icones\ico\Vital.ico"), 0, 40) '  ok 0 é o eixo x e 40 é o eixo y
	 '============================================================================100========================================================

	 '================================================Imprime o titulo do relatório=======================================================
	 'quando vou imprimir tenho q me preocupar c a margem esquerda e da a ela um deslocamento para ela ficar mais a frente como um titulo ou siuubtitulo

	 'aqui é a data maior                                                                                           'eixo x, eixo y
	 'e.Graphics.DrawString(RelatorioTitulos & System.DateTime.Today, FonteSubtitulo, Brushes.Black, MargemEsquerda + 370, 130, New StringFormat()) ' na linha 120
	 '=-===================================================================================================================================



	 'Obtendo os valores do listview
	 'atribuindo valores as variaveis
	 '      Dim Placa, Pentrada, Psaida, Pliquido, Motorista, Cliente, Trasnportadora, OpEntrada, OpSaida, Status, Resíduo As String
	 'Placa = FRMControlePesagemManual_.LVCONTROLEDEPESAGEMMANUAL.SelectedItems(0).SubItems(0).Text
	 'Pentrada = FRMControlePesagemManual_.LVCONTROLEDEPESAGEMMANUAL.SelectedItems(0).SubItems(1).Text
	 'Psaida = FRMControlePesagemManual_.LVCONTROLEDEPESAGEMMANUAL.SelectedItems(0).SubItems(2).Text
	 'Pliquido = FRMControlePesagemManual_.LVCONTROLEDEPESAGEMMANUAL.SelectedItems(0).SubItems(3).Text
	 'Motorista = FRMControlePesagemManual_.LVCONTROLEDEPESAGEMMANUAL.SelectedItems(0).SubItems(4).Text
	 'Cliente = FRMControlePesagemManual_.LVCONTROLEDEPESAGEMMANUAL.SelectedItems(0).SubItems(5).Text
	 'Trasnportadora = FRMControlePesagemManual_.LVCONTROLEDEPESAGEMMANUAL.SelectedItems(0).SubItems(6).Text
	 'OpEntrada = FRMControlePesagemManual_.LVCONTROLEDEPESAGEMMANUAL.SelectedItems(0).SubItems(7).Text
	 'OpSaida = FRMControlePesagemManual_.LVCONTROLEDEPESAGEMMANUAL.SelectedItems(0).SubItems(8).Text
	 'Status = FRMControlePesagemManual_.LVCONTROLEDEPESAGEMMANUAL.SelectedItems(0).SubItems(9).Text
	 'Resíduo = FRMControlePesagemManual_.LVCONTROLEDEPESAGEMMANUAL.SelectedItems(0).SubItems(10).Text













	 ' Dim Placa, Pentrada, Psaida, Pliquido, Motorista, Cliente, Trasnportadora, OpEntrada, OpSaida, Status, Resíduo As String

	 '================Aqui vai entrar os campos q serão impressos no nosso Relatorio DO CABEÇARIO ============================


	 'e.Graphics.DrawString("Placa: ", FonteNegrito, Brushes.Black, MargemEsquerda + 0, 170, New StringFormat()) 'todos tem um deslocamento na horizontal + a vertical permaneça
	 'e.Graphics.DrawString(Placa.ToString(), FonteNormal, Brushes.Black, MargemEsquerda + 100, 170, New StringFormat())



	 'e.Graphics.DrawString("Peso Bruto: ", FonteNegrito, Brushes.Black, MargemEsquerda + 100, 200, New StringFormat()) ' mais só quando eu for imprimir a linha q vai mudar
	 'e.Graphics.DrawString(Pentrada.ToString(), FonteNormal, Brushes.Black, MargemEsquerda + 100, 200, New StringFormat())


	 'e.Graphics.DrawString("Peso Tara: ", FonteNegrito, Brushes.Black, MargemEsquerda + 100, 250, New StringFormat())
	 'e.Graphics.DrawString(Psaida.ToString(), FonteNormal, Brushes.Black, MargemEsquerda + 100, 250, New StringFormat())


	 'e.Graphics.DrawString("Peso Líquido: ", FonteNegrito, Brushes.Black, MargemEsquerda + 100, 300, New StringFormat())
	 'e.Graphics.DrawString(Pliquido.ToString(), FonteNormal, Brushes.Black, MargemEsquerda + 100, 300, New StringFormat())


	 'e.Graphics.DrawString("Motorista: ", FonteNegrito, Brushes.Black, MargemEsquerda + 0, 350, New StringFormat())
	 'e.Graphics.DrawString(Motorista, FonteNormal, Brushes.Black, MargemEsquerda + 100, 350, New StringFormat())


	 'e.Graphics.DrawString("Cliente: ", FonteNegrito, Brushes.Black, MargemEsquerda + 100, 400, New StringFormat())
	 'e.Graphics.DrawString(Cliente, FonteNormal, Brushes.Black, MargemEsquerda + 100, 400, New StringFormat())


	 'e.Graphics.DrawString("Trasnportador: ", FonteNegrito, Brushes.Black, MargemEsquerda + 0, 450, New StringFormat())
	 'e.Graphics.DrawString(Trasnportadora, FonteNormal, Brushes.Black, MargemEsquerda + 100, 450, New StringFormat())


	 'e.Graphics.DrawString("Material: ", FonteNegrito, Brushes.Black, MargemEsquerda + 0, 500, New StringFormat())
	 'e.Graphics.DrawString(Resíduo, FonteNormal, Brushes.Black, MargemEsquerda + 100, 500, New StringFormat())


	 'e.Graphics.DrawString("Op Entrada: ", FonteNegrito, Brushes.Black, MargemEsquerda + 0, 550, New StringFormat())
	 'e.Graphics.DrawString(OpEntrada, FonteNormal, Brushes.Black, MargemEsquerda + 100, 550, New StringFormat())


	 'e.Graphics.DrawString("Op Saída: ", FonteNegrito, Brushes.Black, MargemEsquerda + 0, 600, New StringFormat())
	 'e.Graphics.DrawString(OpSaida, FonteNormal, Brushes.Black, MargemEsquerda + 100, 600, New StringFormat())



	 'e.Graphics.DrawString("Status: ", FonteNegrito, Brushes.Black, MargemEsquerda + 0, 650, New StringFormat())
	 'e.Graphics.DrawString(Status, FonteNormal, Brushes.Black, MargemEsquerda + 100, 650, New StringFormat())


	 ' PosiçãoDaLinha = MargemSuperior + (LinhaAtual * FonteNormal.GetHeight(e.Graphics)) ' definindo a posição da line no momento q ele esta imprimindo
	 'e.Graphics.DrawString(Placa.ToString(), FonteNormal, Brushes.Black, MargemEsquerda + 0, PosiçãoDaLinha, New StringFormat())
	 'e.Graphics.DrawString(Registro.ToString(), FonteNormal, Brushes.Black, MargemEsquerda + 40, PosiçãoDaLinha, New StringFormat())
	 'e.Graphics.DrawString(Nome.ToString(), FonteNormal, Brushes.Black, MargemEsquerda + 130, PosiçãoDaLinha, New StringFormat())
	 'e.Graphics.DrawString(Motivo.ToString(), FonteNormal, Brushes.Black, MargemEsquerda + 265, PosiçãoDaLinha, New StringFormat())
	 'e.Graphics.DrawString(DataInicio.ToString(), FonteNormal, Brushes.Black, MargemEsquerda + 365, PosiçãoDaLinha, New StringFormat())
	 'e.Graphics.DrawString(DataFim.ToString(), FonteNormal, Brushes.Black, MargemEsquerda + 445, PosiçãoDaLinha, New StringFormat())
	 'e.Graphics.DrawString(Diferenca.ToString(), FonteNormal, Brushes.Black, MargemEsquerda + 520, PosiçãoDaLinha, New StringFormat())
	 'e.Graphics.DrawString(Status.ToString(), FonteNormal, Brushes.Black, MargemEsquerda + 545, PosiçãoDaLinha, New StringFormat())
	 'e.Graphics.DrawString(OpcaoEntrada.ToString(), FonteNormal, Brushes.Black, MargemEsquerda + 605, PosiçãoDaLinha, New StringFormat())
	 'e.Graphics.DrawString(OpcaoSaida.ToString(), FonteNormal, Brushes.Black, MargemEsquerda + 710, PosiçãoDaLinha, New StringFormat())






	 '    'imprimir o rodapé
	 '    e.Graphics.DrawLine(CanetaDaImpressora, MargemEsquerda, MargemInferior, MargemDireita, MargemInferior) 'inserindo a linha p o rodapé
	 'LinhaAtual += CInt(FonteNormal.GetHeight(e.Graphics))
	 'LinhaAtual += 1
	 'e.Graphics.DrawString("Página: " & PaginaAtual, FonteRodape, Brushes.Black, MargemDireita - 70, MargemInferior, New StringFormat())
	 'e.Graphics.DrawString("                                               Report View from Marcos Ferreira to " & UsuarioLogado.UsuarioLogado & "  " & DateTime.Now, FonteRodape, Brushes.Black, MargemEsquerda + 100, MargemInferior + 1140, New StringFormat()) 'usando o draw string p escrever a data e hora, font e alinhamemto
	 ''verifica se continua imprimindo
	 'If (LinhaAtual > LinhasPorPaginas) Then
	 '    e.HasMorePages = True
	 'Else
	 '    e.HasMorePages = False
	 'End If

   End Sub





End Class