

Imports System.Data.SQLite

Public Class CAD_CONTROLE_DE_PESAGEM_MANUAL
   'VARIAVEIS DO BANCO DE DADOS

   Private Conexao As SQLiteConnection

   ''' <summary>
   ''' Representa uma instrução SQL ou  um procedimento armazenado a executar contra um fonte de dados
   ''' </summary>
   Private Comando As SQLiteCommand '


   Private Da As SQLiteDataAdapter

   Private Dt As DataTable

   ''' <summary>
   ''' Fornece uma maneira de lerum fluxo somente de encaminhamentos de linha de dados por meio de uma fonte de dados. Esta Classe OledbDataReader n pode ser herdada 
   ''' </summary>
   Private Dr As SQLiteDataReader '

   ''' <summary>
   ''' Representa um dado no cache da memoria, como se fosse uma cópia
   ''' </summary>
   Private Ds As DataSet

#Region "Construtor com parametro"

   ''' <summary>
   ''' Nome do Banco de dados ex: BDVITAL.accdb
   ''' Serve para criar uma instancia da minha classe New! alguma coisa e é chamado automaticamente quando ao executar
   ''' Neste contexto quero iniciar a String de conexão
   ''' </summary>
   Sub New(ByVal NomedoArquivo As String)
	 'definindo a conexao
	 Conexao = New SQLiteConnection("Data Source=" & Application.StartupPath & "\BD\" & NomedoArquivo)
   End Sub

   Sub New()
   End Sub

#End Region


#Region "propriedades da classe"

   Public Property PLACA As String
   Public Property PESO_BRUTO As String
   Public Property MOTORISTA As String
   Public Property PESO_TARA As String
   Public Property PESO_LIQUIDO As String
   Public Property CLIENTE As String
   Public Property TRANSPORTADORA As String
   Public Property OPCAO_DE_ENTRADA As String
   Public Property OPCAO_DE_SAIDA As String
   Public Property STATUS As String
   Public Property RESIDUO As String

   Public Property CODIGO As Integer


#End Region


#Region "Métodos da classe"

   'Comando.CommandText = QueryStd
   'Comando.Parameters.AddWithValue("@PLACA", PLACA) 'aqui adiciona
   'Comando.Parameters.AddWithValue("@PESO_BRUTO", PESO_BRUTO)
   'Comando.Parameters.AddWithValue("@MOTORISTA", MOTORISTA)
   'Comando.Parameters.AddWithValue("@PESO_TARA", PESO_TARA)
   'Comando.Parameters.AddWithValue("@PESO_LIQUIDO", PESO_LIQUIDO)
   'Comando.Parameters.AddWithValue("@CLIENTE", CLIENTE)
   'Comando.Parameters.AddWithValue("@TRANSPORTADORA", TRANSPORTADORA)
   'Comando.Parameters.AddWithValue("@OPCAO_DE_ENTRADA", OPCAO_DE_ENTRADA)
   'Comando.Parameters.AddWithValue("@OPCAO_DE_SAIDA", OPCAO_DE_SAIDA)
   'Comando.Parameters.AddWithValue("@STATUS", STATUS)
   'Comando.Parameters.AddWithValue("@RESIDUO", RESIDUO)
   'Comando.ExecuteNonQuery()

   ''' <summary> Função para converter dados de datagrid em string pois na ADO net não existe a função GET STRING!
   ''' </summary>
   ''' <param name="dt">um DataTable a ser convertido</param>
   ''' <param name="numLinhas">o número de linhas a ser convertido na tabela. Se o número for negativo todas as linhas serão convertidas.</param>
   ''' <param name="delimitadorColunas">o delimitador de colunas. O valor padrão é TAB</param>
   ''' <param name="delimitadorLinhas">o delimitador de linhas. O valor padrão é o CARRIAGE RETURN</param>
   ''' <param name="nullExpr">a expressão Null. A string que será substituida por null na tabela. O valor padrão é vazio.</param>
   ''' <returns></returns>
   Public Function GetString(dt As DataTable, numLinhas As Integer, delimitadorColunas As [String],
delimitadorLinhas As [String], nullExpr As [String]) As [String]

	 If numLinhas < 0 Then
	    ' um número negativo retorna todas as rows (linhas)
	    numLinhas = dt.Rows.Count
	 Else
	    numLinhas = Math.Max(numLinhas, dt.Rows.Count)
	 End If

	 ' o delimitador padrão da coluna é TAB
	 If delimitadorColunas Is Nothing Then
	    delimitadorColunas = ControlChars.Tab
	 End If

	 If delimitadorLinhas Is Nothing Then
	    delimitadorLinhas = ControlChars.CrLf  '' o delimitador padrão de row é CARRIAGE RETURN
	 End If

	 ' se houver um null expression transforma em vazio
	 If nullExpr Is Nothing Then
	    nullExpr = ""
	 End If

	 Dim sb As New System.Text.StringBuilder
	 ' percorre a coleção de linhas(rows)
	 Dim i As Integer
	 For i = 0 To numLinhas - 1
	    ' percorre a coleção de oclunas
	    Dim col As Object
	    For Each col In dt.Rows(i).ItemArray
		  ' substitui os valores nulls
		  Dim colString As String
		  If col Is System.DBNull.Value Then
			colString = nullExpr
		  Else
			colString = col.ToString()
		  End If
		  ' inclua o valor da coluna para string
		  sb.Append(colString & delimitadorColunas)
	    Next col
	    ' remove o delimitador de colunas no último campo
	    sb.Remove(sb.Length - delimitadorColunas.Length, delimitadorColunas.Length)
	    ' inclui o delmitador de linha
	    sb.Append(delimitadorLinhas) '<<<<
	 Next i
	 Return sb.ToString '.ToString()
   End Function

   Friend Property Completar As New AutoCompleteStringCollection

   Public Function Preenchimento_Automatico_Text(Query As String) As AutoCompleteStringCollection

	 Try
	    If Conexao.State = ConnectionState.Open Then Conexao.Close()
	    Conexao.Open()
	    Comando = New SQLiteCommand
	    Comando.Connection = Conexao
	    Dt = New DataTable
	    Da = New SQLiteDataAdapter(Query, Conexao)
	    Da.Fill(Dt)
	    If Dt.Rows.Count = 0 Then Throw New Exception("Não foram localizados dados para este critério.")
	    For Each r In Dt.Rows
		  Completar.Add(r(0))
	    Next
	    Conexao.Close()
	 Catch ex As Exception
	    MsgBox(ex.Message)
	 Finally
	    Conexao.Close()
	    Conexao.Dispose()
	 End Try
	 Return Completar

   End Function

   'alterar
   Public Function Alterar() As Boolean
	 Dim Tabela As New DataTable
	 Dim alterou As Boolean = False

	 Try
	    Dim Sql = "update CAD_CONTROLE_DE_PESAGEM_MANUAL set 
	    PLACA = @PLACA,
	    PESO_BRUTO = @PESO_BRUTO,
	    MOTORISTA = @MOTORISTA,
	    PESO_TARA = @PESO_TARA,
	    PESO_LIQUIDO = @PESO_LIQUIDO,
	    CLIENTE = @CLIENTE,
	    TRANSPORTADORA = @TRANSPORTADORA,
	    OPCAO_DE_ENTRADA = @OPCAO_DE_ENTRADA,
	    OPCAO_DE_SAIDA = @OPCAO_DE_SAIDA,
	    STATUS = @STATUS,
	    RESIDUO = @RESIDUO where CODIGO = @CODIGO"

	    Using con = New SQLiteConnection(Conexao.ConnectionString)
		  con.Open()
		  Using CMD = New SQLiteCommand(Sql, con)
			CMD.Parameters.AddWithValue("@PLACA", PLACA)
			CMD.Parameters.AddWithValue("@PESO_BRUTO", PESO_BRUTO)
			CMD.Parameters.AddWithValue("@MOTORISTA", MOTORISTA)
			CMD.Parameters.AddWithValue("@PESO_TARA", PESO_TARA)
			CMD.Parameters.AddWithValue("@PESO_LIQUIDO", PESO_LIQUIDO)
			CMD.Parameters.AddWithValue("@CLIENTE", CLIENTE)
			CMD.Parameters.AddWithValue("@TRANSPORTADORA", TRANSPORTADORA)
			CMD.Parameters.AddWithValue("@OPCAO_DE_ENTRADA", OPCAO_DE_ENTRADA)
			CMD.Parameters.AddWithValue("@CODIGO", CODIGO)
			If PESO_TARA = 0 Then
			   CMD.Parameters.AddWithValue("@OPCAO_DE_SAIDA", OPCAO_DE_SAIDA)
			Else
			   OPCAO_DE_SAIDA = UCase(UsuarioLogado.UsuarioLogado & " " & Now)
			   CMD.Parameters.AddWithValue("@OPCAO_DE_SAIDA", OPCAO_DE_SAIDA)
			End If

			If PESO_TARA = 0 Then
			   CMD.Parameters.AddWithValue("@STATUS", STATUS)
			Else
			   STATUS = "CONCLUIDO"
			   CMD.Parameters.AddWithValue("@STATUS", STATUS)
			End If
			CMD.Parameters.AddWithValue("@RESIDUO", RESIDUO)
			Dim linhasAfetadas = CMD.ExecuteNonQuery
			If linhasAfetadas = 1 Then
			   alterou = True
			Else
			   alterou = False
			End If
		  End Using
	    End Using
	 Catch ex As Exception
	    MsgBox(ex.Message, vbCritical, "Erro")
	    Conexao.Close()
	 End Try

	 Return alterou

   End Function

   'excluir
   ''' <summary>
   ''' Função booleana para excluir registros
   ''' </summary>
   ''' <returns></returns>
   Public Function Excluir(Id_para_Escluir As Integer) As Boolean

	 Try
	    Dim query As String = "Delete from CAD_CONTROLE_DE_PESAGEM_MANUAL where CODIGO = @CODIGO" 'delete da tabela cadmtr 
	    Using Con As New SQLiteConnection(Conexao)
		  Conexao.Open()
		  Using Comando As New SQLiteCommand(query, Conexao)
			Comando.Parameters.AddWithValue("@CODIGO", CODIGO)
			Dim Cmd As Integer = Comando.ExecuteNonQuery
			If Cmd Then
			   Return True
			Else
			   Return False
			End If
		  End Using
	    End Using
	 Catch ex As Exception
	    MsgBox(ex.Message, vbCritical, "Erro")
	 Finally
	    Conexao.Close()

	 End Try
	 Return Excluir
   End Function

#End Region

   Public Function GetTabelaViaAdapter(ConsultaSqlString As String) As DataTable
	 Dim tabela As New DataTable
	 Try
	    If Conexao.State = ConnectionState.Open Then
		  Conexao.Close()
	    End If
	    Using Con As New SQLiteConnection(Conexao)
		  If Con.State = ConnectionState.Closed Then Con.Open()
		  Using Da As New SQLiteDataAdapter(ConsultaSqlString, Con)
			Da.Fill(tabela)
		  End Using
		  Con.Close()
	    End Using
	    Conexao.Close()
	 Catch ex As Exception

	 Finally
	    Conexao.Close()
	 End Try

	 Return tabela
   End Function

   Public Function ValidarPesagemEmAberto(Textbox_p_Pesquisar As TextboxMonetário) As Boolean
	 Dim Retorno As Boolean = False
	 Try
	    Dim query As String = "SELECT COUNT(*) FROM CAD_CONTROLE_DE_PESAGEM_MANUAL WHERE PLACA='" & Textbox_p_Pesquisar.Text & "'" & " AND STATUS='EM ABERTO'"
	    Using con As New SQLiteConnection(Conexao)
		  If con.State = ConnectionState.Open Then
			con.Close()
		  End If
		  con.Open()
		  Using cmd As New SQLiteCommand(query, con)
			Dim L = cmd.ExecuteScalar()

			If L > 0 Then
			   Retorno = True
			End If

		  End Using
	    End Using
	 Catch ex As Exception
	    MsgBox("erro encontrado: " & ex.Message)
	 Finally
	 End Try
	 Return Retorno
   End Function

   Public Function BuscarPsagemAberto(query As Object) As Boolean
	 Dim retorno As Boolean = False
	 Try
	    Conexao.Open()
	    Comando = New SQLiteCommand(query, Conexao)
	    Comando.Connection = Conexao
	    Comando.Parameters.AddWithValue("@CODIGO", CODIGO)
	    Comando.Parameters.AddWithValue("@PLACA", PLACA)
	    Comando.Parameters.AddWithValue("@PESO_BRUTO", PESO_BRUTO)
	    Comando.Parameters.AddWithValue("@MOTORISTA", MOTORISTA)
	    Comando.Parameters.AddWithValue("@PESO_TARA", PESO_TARA)
	    Comando.Parameters.AddWithValue("@PESO_LIQUIDO", PESO_LIQUIDO)
	    Comando.Parameters.AddWithValue("@CLIENTE", CLIENTE)
	    Comando.Parameters.AddWithValue("@TRANSPORTADORA", TRANSPORTADORA)
	    Comando.Parameters.AddWithValue("@OPCAO_DE_ENTRADA", OPCAO_DE_ENTRADA)
	    Comando.Parameters.AddWithValue("@OPCAO_DE_SAIDA", OPCAO_DE_SAIDA)
	    Comando.Parameters.AddWithValue("@STATUS", STATUS)
	    Comando.Parameters.AddWithValue("@RESIDUO", RESIDUO)
	    Dr = Comando.ExecuteReader
	    Do While Dr.Read
		  PLACA = Dr("PLACA") 'SE N FOR NULO O CAMPO PLACA ENTÃO SO P MOSTRAR COMO FAZ SE O CAMPO FOR NULO
		  PESO_BRUTO = Dr("PESO_BRUTO")
		  MOTORISTA = Dr("MOTORISTA")
		  PESO_TARA = Dr("PESO_TARA")
		  PESO_LIQUIDO = Dr("PESO_LIQUIDO") 'If Not IsDBNull(Dr("PESO_LIQUIDO")) Then PESO_LIQUIDO = Dr("PESO_LIQUIDO")
		  CLIENTE = Dr("CLIENTE")
		  TRANSPORTADORA = Dr("TRANSPORTADORA")
		  OPCAO_DE_ENTRADA = Dr("OPCAO_DE_ENTRADA")
		  OPCAO_DE_SAIDA = If(Not IsDBNull(Dr("OPCAO_DE_SAIDA")), Dr("OPCAO_DE_SAIDA"), Nothing) ' AQUI É NULL RESOLVER ISSO
		  STATUS = Dr("STATUS")
		  RESIDUO = Dr("RESIDUO")
		  CODIGO = Dr("CODIGO")
		  Dr.Close()
		  Return True
	    Loop
	    Return retorno
	 Catch ex As Exception
	    MsgBox(ex.Message)
	 Finally

	 End Try
	 Return retorno

   End Function


   Public Function AdicionarEntrada() As Boolean
	 Dim Tabela As New DataTable 'p atualizar o grid depois q adicionar

	 Using Con = New SQLiteConnection(Conexao.ConnectionString)
	    Dim Retornou = False
	    Con.Open()
	    Dim Query1, Query2 As String
	    Query1 = "Select count(*) from CAD_CONTROLE_DE_PESAGEM_MANUAL where PLACA=" & "'" & PLACA & "'"
	    Query2 = "insert into CAD_CONTROLE_DE_PESAGEM_MANUAL (PLACA, PESO_BRUTO, MOTORISTA, PESO_TARA, PESO_LIQUIDO, CLIENTE, TRANSPORTADORA, OPCAO_DE_ENTRADA, OPCAO_DE_SAIDA, STATUS, RESIDUO) values (?,?,?,?,?,?,?,?,?,?,?)"

	    Using Da As New SQLiteDataAdapter(Query2, Con)
		  Comando = New SQLiteCommand(Query1, Con)
		  Comando = New SQLiteCommand(Query2, Con)
		  Comando.Parameters.AddWithValue("@PLACA", PLACA) 'aqui adiciona
		  Comando.Parameters.AddWithValue("@PESO_BRUTO", PESO_BRUTO)
		  Comando.Parameters.AddWithValue("@MOTORISTA", MOTORISTA)
		  Comando.Parameters.AddWithValue("@PESO_TARA", PESO_TARA)
		  Comando.Parameters.AddWithValue("@PESO_LIQUIDO", PESO_LIQUIDO)
		  Comando.Parameters.AddWithValue("@CLIENTE", CLIENTE)
		  Comando.Parameters.AddWithValue("@TRANSPORTADORA", TRANSPORTADORA)
		  Comando.Parameters.AddWithValue("@OPCAO_DE_ENTRADA", OPCAO_DE_ENTRADA)
		  Comando.Parameters.AddWithValue("@OPCAO_DE_SAIDA", OPCAO_DE_SAIDA)
		  Comando.Parameters.AddWithValue("@STATUS", STATUS)
		  Comando.Parameters.AddWithValue("@RESIDUO", RESIDUO)
		  Comando.ExecuteNonQuery()
		  Retornou = True
		  Return Retornou
	    End Using
	 End Using
	 Return AdicionarEntrada

   End Function

   Public Function adicionarSaida(codigo_ As Integer) As Boolean
	 Dim query = ""
	 query = "update CAD_CONTROLE_DE_PESAGEM_MANUAL set
	 PLACA=@PLACA, PESO_BRUTO=@PESO_BRUTO, MOTORISTA=@MOTORISTA, PESO_TARA=@PESO_TARA, PESO_LIQUIDO=@PESO_LIQUIDO, CLIENTE=@CLIENTE, TRANSPORTADORA=@TRANSPORTADORA, OPCAO_DE_ENTRADA=@OPCAO_DE_ENTRADA, OPCAO_DE_SAIDA=@OPCAO_DE_SAIDA, STATUS=@STATUS, RESIDUO=@RESIDUO 
	 where CODIGO=" & codigo_ & " and STATUS='EM ABERTO'"

	 Dim adicionou As Boolean = False

	 Using CONEX As SQLiteConnection = New SQLiteConnection(Conexao.ConnectionString)
	    Dim Tabela As New DataTable
	    CONEX.Open()
	    Dim CMD As SQLiteCommand = New SQLiteCommand(query, CONEX)
	    CMD.Parameters.AddWithValue("@PLACA", PLACA)
	    CMD.Parameters.AddWithValue("PESO_BRUTO", PESO_BRUTO)
	    CMD.Parameters.AddWithValue("@MOTORISTA", MOTORISTA)
	    CMD.Parameters.AddWithValue("@PESO_TARA", PESO_TARA)
	    CMD.Parameters.AddWithValue("@PESO_LIQUIDO", PESO_LIQUIDO)
	    CMD.Parameters.AddWithValue("@CLIENTE", CLIENTE)
	    CMD.Parameters.AddWithValue("@TRANSPORTADORA", TRANSPORTADORA)
	    CMD.Parameters.AddWithValue("@OPCAO_DE_ENTRADA", OPCAO_DE_ENTRADA)
	    CMD.Parameters.AddWithValue("@OPCAO_DE_SAIDA", OPCAO_DE_SAIDA)
	    CMD.Parameters.AddWithValue("@STATUS", STATUS)
	    CMD.Parameters.AddWithValue("@RESIDUO", RESIDUO)
	    Dim LinhasAfetadas = CMD.ExecuteNonQuery
	    If LinhasAfetadas = 1 Then
		  adicionou = True
		  CONEX.BeginTransaction.Commit()
	    Else
		  adicionou = False
		  CONEX.BeginTransaction.Rollback()
	    End If
	    'CONEX.Close()
	    Return adicionou
	 End Using
   End Function
End Class
