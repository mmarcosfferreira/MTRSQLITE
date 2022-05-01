'Imports System.Data.OleDb
Imports Tulpep.NotificationWindow.PopupNotifier
Imports System.Data.SQLite
Public Class CadMTR
#Region "Propriedades das variáveis do banco de dados"
   ''' <summary>
   '''Representa uma conexão aberta com o banco de dados
   ''' </summary>
   friend Conexao As SQLiteConnection  'OleDbConnection

   ''' <summary>
   ''' Representa uma instrução SQL ou  um procedimento armazenado a executar contra um fonte de dados
   ''' </summary>
   Private Comando As SQLiteCommand 'OleDbCommand '

   ''' <summary>
   ''' Conjunto de comando de dados e uma Conexão c o banco dedados q sao usados p preencher o DataSet e atualizar a fonte de dados
   ''' </summary>
   Private Da As SQLiteDataAdapter 'OleDbDataAdapter

   Private Dt As DataTable

   ''' <summary>
   ''' Fornece uma maneira de lerum fluxo somente de encaminhamentos de linha de dados por meio de uma fonte de dados. Esta Classe OledbDataReader n pode ser herdada 
   ''' </summary>
   Private Dr As SQLiteDataReader 'OleDbDataReader '

   ''' <summary>
   ''' Representa um dado no cache da memoria, como se fosse uma cópia
   ''' </summary>
   Private Ds As DataSet



#End Region

#Region "Construtor com parametro"

   ''' <summary>
   ''' Nome do Banco de dados ex: BDVITAL.accdb
   ''' Serve para criar uma instancia da minha classe New! alguma coisa e é chamado automaticamente quando ao executar
   ''' Neste contexto quero iniciar a String de conexão
   ''' </summary>
   Sub New(ByVal NomedoArquivo As String)
	 'definindo a conexao
	 'Conexao = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\BD\" & NomedoArquivo & ";Jet OLEDB:Database Password=FERREIRA;")
	 Conexao = New SQLiteConnection("Data Source=" & Application.StartupPath & "\BD\" & NomedoArquivo)
	 'Conexao.SetPassword("FERREIRA")
   End Sub

#End Region

#Region "propriedades da classe"
   Public Property CÓDIGO As Integer
   Public Property MTR As String 'LONG
   Public Property DATAHORA As String
   Public Property OP_ENTRADA As String
   Public Property OBSERVACAO As String

#End Region
   'Comando = New SQLiteCommand()
   'Comando.Connection = Conexao
   'Dim Adicionou As Boolean = False

   'Try
   '   Conexao.Open()
   '   Comando = New SQLiteCommand("Select count(*) from cad_mtr where mtr=" & "'" & Mtr & "'", Conexao)
   '   Dim I As Integer = Comando.ExecuteScalar
   '   If I = 0 Then
   '  Comando = New SQLiteCommand("insert into cad_mtr (MTR, DATAHORA, OP_ENTRADA, OBSERVACAO) values (?,?,?,?)", Conexao)
   '  Comando.Parameters.AddWithValue("@mtr", Mtr) 'aqui adiciona
   '  Comando.Parameters.AddWithValue("@datahora", DataHora)
   '  Comando.Parameters.AddWithValue("@op_entrada", Opentrada)
   '  Comando.Parameters.AddWithValue("@observacao", Observacao)
   '  Comando.ExecuteNonQuery()
   '  info4.Notifyicone_PopupNotifier(vbNewLine & vbNewLine & Chr(9) & "Registro adicionado com êxito!", vbNewLine & Chr(9) & Chr(9) & "Atenção", 3000) 'BTadicionarMtr)
   '  Adicionou = True
   '   Else
   '  Adicionou = False
   '  MsgBox("Existe um registro com esses dados informados!" & Chr(13) &
   '	 vbTab &
   '	 "Localizando registro!",
   '	 vbCritical,
   '	 "MarcosFerreira - Projetos T.I")
   '   End If
   'Catch ex As Exception
   '   MsgBox(ex.Message, vbCritical, "Erro")
   'Finally
   '   Conexao.Close()
   'End Try
   'Return Await Task.FromResult(Adicionou)
   Public Shared info4 As New Notifyicone_PopupNotifier

#Region "Métodos da classe"
   'adicionar
   ''' <summary>
   ''' Adiciona um novo registro no formulário MTR
   ''' </summary>
   ''' <returns></returns>
   Public Async Function Adicionar() As Task(Of Boolean)
	 Application.DoEvents()
	 Dim Tabela As New DataTable
	 Using Con As New SQLiteConnection(Conexao.ConnectionString)
	    Dim Retornou = False
	    Con.Open()
	    Dim Query1, Query2 As String
	    Query1 = "Select count(*) from cad_mtr where mtr=" & "'" & Mtr & "'"
	    Query2 = "insert into cad_mtr (MTR, DATAHORA, OP_ENTRADA, OBSERVACAO) values (?,?,?,?)"

	    Using Da As New SQLiteDataAdapter(Query2, Con)
		  Comando = New SQLiteCommand(Query1, Con)
		  Dim I As Integer = Comando.ExecuteScalar
		  If I = 0 Then
			Comando = New SQLiteCommand(Query2, Con)
			Comando.Parameters.AddWithValue("@mtr", MTR) 'aqui adiciona
			Comando.Parameters.AddWithValue("@datahora", DATAHORA)
			Comando.Parameters.AddWithValue("@op_entrada", OP_ENTRADA)
			Comando.Parameters.AddWithValue("@observacao", OBSERVACAO)
			Comando.ExecuteNonQuery()
			Retornou = True
		  Else
			Retornou = False
			MsgBox("Existe um registro com esses dados informados!" & Chr(13) & vbTab & "Localizando registro!", vbExclamation,
			    "MarcosFerreira - Projetos T.I")
		  End If
		  Return Await Task.FromResult(Retornou)
	    End Using
	 End Using

   End Function

   ''' <summary>
   ''' Função paracontar a qtu de registros
   ''' </summary>
   ''' <returns>Retorna a qtu de registros</returns>
   Public Function ContarRegistros() As Integer
	 Comando = New SQLiteCommand
	 Comando.Connection = Conexao
	 Dim Tabela As New DataTable

	 Try
	    Conexao.Open()
	    Comando = New SQLiteCommand("Select count(*) from CAD_MTR", Conexao)
	    ContarRegistros = Comando.ExecuteScalar
	    Conexao.Close()

	 Catch ex As Exception
	    MsgBox(ex.Message, vbCritical, "Erro")
	 End Try
	 Return ContarRegistros
   End Function
   'alterar
   'cria a transação
   'Dim trans As SQLite.SQLiteTransaction
   'trans = Con.BeginTransaction(IsolationLevel.RepeatableRead)

   Public Async Function Alterar() As Task(Of Boolean)
	 Dim Tabela As New DataTable
	 Dim Alterou As Boolean = False
	 Try
	    Using Con As New SQLiteConnection(Conexao.ConnectionString)
		  Con.Open()

		  Using Da As New SQLiteDataAdapter("UPDATE CAD_MTR SET
		  MTR = @MTR,
		  DATAHORA = @DATAHORA,
		  OP_ENTRADA = @OP_ENTRADA,
		  OBSERVACAO = @OBSERVACAO
		  WHERE CÓDIGO = @CÓDIGO", Con)
			Da.SelectCommand.Parameters.Clear()
			Da.SelectCommand.Parameters.AddWithValue("@MTR", MTR)
			Da.SelectCommand.Parameters.AddWithValue("@DATAHORA", DATAHORA)
			Da.SelectCommand.Parameters.AddWithValue("@OP_ENTRADA", OP_ENTRADA)
			Da.SelectCommand.Parameters.AddWithValue("@OBSERVACAO", OBSERVACAO)
			Da.SelectCommand.Parameters.AddWithValue("@CÓDIGO", CÓDIGO)

			Dim LinhasAfetadas As Integer
			LinhasAfetadas = Da.SelectCommand.ExecuteNonQuery()
			Da.Fill(Tabela)
			If LinhasAfetadas = 1 Then
			   Alterou = True
			End If
		  End Using
	    End Using
	 Catch ex As Exception
	    MsgBox(ex.Message, vbCritical, "Erro")
	 End Try
	 Return Await Task.FromResult(Alterou)
   End Function

   Public Mensagem As New FrmMTR
   'Carregar
   Public Async Function Carregar(nome As String) As Task(Of DataTable)
	 Dim Comando As New SQLiteCommand
	 Dim Tabela As New DataTable
	 Try
	    Comando.Connection = Conexao
	    If nome.Length = 0 Then

		  Comando.CommandText = "select * from cad_mtr order by código"
		  If Conexao.State = ConnectionState.Closed Then Conexao.Open()
		  Da = New SQLiteDataAdapter(Comando)
		  Da.Fill(Tabela)

	    Else
		  If nome.Length > 0 Then
			'I.CabeçarioDGVdados() 'cabeçario
			Comando.CommandText = "select * from cad_mtr where MTR like'" & nome & "%'"
			Comando.Parameters.AddWithValue("@MTR", Mtr)

			' If Conexao.State = ConnectionState.Closed Then Conexao.Open()
			'MsgBox("Filtro Concluído com sucesso!", MsgBoxStyle.Information, "Filtro")

			Da = New SQLiteDataAdapter(Comando)
			Da.Fill(Tabela)
			info4.Notifyicone_PopupNotifier(vbNewLine & vbNewLine & Chr(9) & "____Filtragem concluída____ " & vbCr & vbCr & " item's começado em '" + nome, vbNewLine & Chr(9) & Chr(9) & Chr(9) & "----------Filtragem---------", 700, Mensagem.BTcarregarMtr)
		  End If
	    End If

	 Catch ex As Exception
	    MsgBox(ex.Message, vbCritical, "Erro não tratado")
	 Finally
	    Conexao.Close()
	 End Try
	 Return Await Task.FromResult(Tabela)
   End Function

   Public Function GetTabelaViaAdapterMtr(ConsultaSqlString As String) As Task(Of DataTable)
	 Try
	    Dim Tabela As New DataTable
	    Using con As New SQLiteConnection(Conexao.ConnectionString)
		  con.Open()
		  Using da As New SQLiteDataAdapter(ConsultaSqlString, con)
			da.Fill(Tabela)
		  End Using
	    End Using
	    Return Task.FromResult(Tabela)
	 Catch ex As Exception
	    MsgBox(ex.Message.ToString)
	 End Try

   End Function

#End Region

   Public Function GetTabelaViaReader(ConsultaSqlString As String) As DataTable
	 Try
	    Conexao.Open()
	    Comando = New SQLiteCommand(ConsultaSqlString, Conexao) 'New OleDbCommand(ConsultaSqlString, Conexao)
	    Comando.Connection = Conexao
	    Dt = New DataTable
	    Dr = Comando.ExecuteReader
	    Dt.Load(Dr)

	    If Dt.Rows.Count = 0 Then
		  Throw New Exception("Não foram localizados dados para este critério.")
	    End If
	    Return Dt
	 Catch ex As Exception
	    Throw ex
	    MsgBox(ex.Message, MsgBoxStyle.Critical, "Atenção!")
	 Finally
	    Conexao.Close()
	 End Try
   End Function

   ''' <summary>
   ''' 
   ''' </summary>
   ''' <param name="ConsultaSqlString">É a query a ser usado como parametro de sql. Ex: "select * from CAD_MTR where MTR like"+"'"+TXTmtr.Text+"%"+"'"</param>
   ''' <returns>Retorna a cópia de um dado, neste caso o dataset q é a memória em cache, cópia de várias várias tabelas pos é isso q o ds trata</returns>
   Public Function GetDataSet(ConsultaSqlString As String) As DataSet
	 Try

	    Conexao.Open()
	    Da = New SQLiteDataAdapter(ConsultaSqlString, Conexao) 'New OleDbDataAdapter(ConsultaSqlString, Conexao)
	    Ds = New DataSet
	    Da.Fill(Ds)

	 Catch ex As Exception
	    Throw ex
	 Finally
	    Conexao.Close()
	 End Try
	 Return Ds.Clone
   End Function


   'excluir
   ''' <summary>
   ''' Função booleana para excluir registros
   ''' </summary>
   ''' <returns></returns>
   Public Function Excluir(Id As String) As Boolean
	 Dim Excluiu As Boolean = False
	 Using Conex As New SQLiteConnection(Conexao.ConnectionString)
	    Conex.Open()
	    Using Da As New SQLiteDataAdapter("DELETE FROM CAD_MTR WHERE CÓDIGO = @CÓDIGO", Conex)
		  Da.SelectCommand.Parameters.Clear()
		  Da.SelectCommand.Parameters.AddWithValue("@CÓDIGO", Id)
		  Da.SelectCommand.ExecuteNonQuery()
		  Excluiu = True
	    End Using
	 End Using
	 Return Excluiu
   End Function


End Class
